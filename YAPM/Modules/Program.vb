﻿' =======================================================
' Yet Another (remote) Process Monitor (YAPM)
' Copyright (c) 2008-2009 Alain Descotes (violent_ken)
' https://sourceforge.net/projects/yaprocmon/
' =======================================================


' YAPM is free software; you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation; either version 3 of the License, or
' (at your option) any later version.
'
' YAPM is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with YAPM; if not, see http://www.gnu.org/licenses/.


Option Strict On

Imports System.Runtime.InteropServices

Public Module Program

    ' Represent options passed with command line
    Public Class ProgramParameters

        ' Available parameters
        Private isServerMode As Boolean = False
        Private remPort As Integer = 8081
        Private isAutoConnectMode As Boolean = False
        Private isHidden As Boolean = False
        Public ReadOnly Property ModeServer() As Boolean
            Get
                Return isServerMode
            End Get
        End Property
        Public ReadOnly Property AutoConnect() As Boolean
            Get
                Return isAutoConnectMode
            End Get
        End Property
        Public ReadOnly Property ModeHidden() As Boolean
            Get
                Return isHidden
            End Get
        End Property
        Public ReadOnly Property RemotePort() As Integer
            Get
                Return remPort
            End Get
        End Property
        Public Sub New(ByRef parameters As String())
            If parameters Is Nothing Then
                Exit Sub
            End If
            For i As Integer = 0 To parameters.Length - 1
                If parameters(i).ToLowerInvariant = "-server" Then
                    isServerMode = True
                ElseIf parameters(i).ToLowerInvariant = "-autoconnect" Then
                    isAutoConnectMode = True
                ElseIf parameters(i).ToLowerInvariant = "-hide" Then
                    isHidden = True
                ElseIf parameters(i).ToLowerInvariant = "-port" Then
                    If parameters.Length - 1 >= i + 1 Then
                        remPort = CInt(Val(parameters(i + 1)))
                    End If
                End If
            Next
        End Sub
    End Class



    Public _frmMain As frmMain
    Public _frmServer As frmServer
    Private _progParameters As ProgramParameters
    Private WithEvents theConnection As cConnection
    Private _systemInfo As cSystemInfo
    Private _hotkeys As cHotkeys
    Private _pref As Pref
    Private _log As cLog
    Private _isVista As Boolean
    Private _isAdmin As Boolean
    Private _trayIcon As cTrayIcon
    Private _ConnectionForm As frmConnection
    Private _time As Integer

    Public ReadOnly Property Parameters() As ProgramParameters
        Get
            Return _progParameters
        End Get
    End Property
    Public ReadOnly Property ElapsedTime() As Integer
        Get
            Return API.GetTickCount - _time
        End Get
    End Property
    Public ReadOnly Property Connection() As cConnection
        Get
            Return theConnection
        End Get
    End Property
    Public ReadOnly Property SystemInfo() As cSystemInfo
        Get
            Return _systemInfo
        End Get
    End Property
    Public ReadOnly Property Hotkeys() As cHotkeys
        Get
            Return _hotkeys
        End Get
    End Property
    Public ReadOnly Property Preferences() As Pref
        Get
            Return _pref
        End Get
    End Property
    Public ReadOnly Property Log() As cLog
        Get
            Return _log
        End Get
    End Property
    Public ReadOnly Property IsWindowsVista() As Boolean
        Get
            Return _isVista
        End Get
    End Property
    Public ReadOnly Property IsAdministrator() As Boolean
        Get
            Return _isAdmin
        End Get
    End Property
    Public ReadOnly Property TrayIcon() As cTrayIcon
        Get
            Return _trayIcon
        End Get
    End Property
    Public ReadOnly Property ConnectionForm() As frmConnection
        Get
            Return _ConnectionForm
        End Get
    End Property

    Public Const HELP_PATH As String = "http://yaprocmon.sourceforge.net/help.html"
    Public Const NO_INFO_RETRIEVED As String = "N/A"

    Public NEW_ITEM_COLOR As Color = Color.FromArgb(128, 255, 0)
    Public DELETED_ITEM_COLOR As Color = Color.FromArgb(255, 64, 48)
    Public PROCESSOR_COUNT As Integer



    Sub Main()

        ' ======= Save time of start
        _time = API.GetTickCount



        ' ======= Check if framework is 2.0 or above
        If cEnvironment.IsFramework2OrAbove = False Then
            MsgBox(".Net Framework 2.0 or above must be installed.", MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End If



        ' ======= Check if system is 32 bits
        If cEnvironment.Is32Bits = False Then
            MsgBox("Cannot start on a non 32-bits system." & vbNewLine & "YAPM only works on 32-bits systems.", MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End If



        ' ======= Close application if there is a previous instance of YAPM running
        If cEnvironment.IsAlreadyRunning Then
            Exit Sub
        End If



        ' ======= Some basic initialisations
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)    ' Use GDI, not GDI+



        ' ======= Set handler for exceptions
        AddHandler Application.ThreadException, AddressOf MYThreadHandler
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf MYExnHandler
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)



        ' ======= Read parameters
        _progParameters = New ProgramParameters(Environment.GetCommandLineArgs)



        ' ======= Parse port files
        Call cNetwork.ParsePortTextFile()


        ' ======= Instanciate all classes

        ' Common classes
        theConnection = New cConnection     ' The cConnection instance of the connection
        _systemInfo = New cSystemInfo       ' System informations
        _ConnectionForm = New frmConnection(theConnection)

        ' Classes for client only
        If _progParameters.ModeServer = False Then
            _pref = New Pref                    ' Preferences
            _hotkeys = New cHotkeys             ' Hotkeys
            _log = New cLog                     ' Log instance
            _trayIcon = New cTrayIcon(2)        ' Tray icons
            _frmMain = New frmMain              ' Main form
        Else
            _frmMain = New frmMain              ' Main form
            _frmServer = New frmServer          ' Server form (server mode)
        End If



        ' ======= Other init
        _isVista = cEnvironment.IsWindowsVistaOrAbove
        _isAdmin = cEnvironment.IsAdmin



        ' ======= Load preferences
        If My.Settings.ShouldUpgrade Then
            Try
                ' Try to update settings from a previous version of YAPM
                My.Settings.Upgrade()
            Catch ex As Exception
                '
            End Try
            My.Settings.ShouldUpgrade = False
            My.Settings.Save()
        End If
        If _progParameters.ModeServer = False Then
            Try
                If My.Settings.FirstTime Then
                    MsgBox(Pref.MSGFIRSTTIME, MsgBoxStyle.Information, "Please read this")
                    My.Settings.FirstTime = False
                    Program.Preferences.Save()
                End If
                Program.Preferences.Apply()
                cProcess.BuffSize = My.Settings.HistorySize
            Catch ex As Exception
                ' Preference file corrupted/missing
                MsgBox("Preference file is missing or corrupted and will be now recreated.", MsgBoxStyle.Critical, "Startup error")
                Program.Preferences.SetDefault()
            End Try
        End If



        ' ======= Enable some privileges
        cEnvironment.RequestPrivilege(cEnvironment.PrivilegeToRequest.DebugPrivilege)
        cEnvironment.RequestPrivilege(cEnvironment.PrivilegeToRequest.ShutdownPrivilege)



        ' ======= Read hotkeys & state based actions from XML files
        If _progParameters.ModeServer = False Then
            Call frmHotkeys.readHotkeysFromXML()
            'Call frmBasedStateAction.readStateBasedActionFromXML()
        End If



        ' ======= Show main form & start application
        If _progParameters.ModeServer Then
            Application.Run(_frmServer)
        Else
            Application.Run(_frmMain)
        End If

    End Sub

    ' Handler for exceptions
    Private Sub MYExnHandler(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        Dim ex As Exception
        ex = CType(e.ExceptionObject, Exception)
        Console.WriteLine(ex.StackTrace)
        Dim t As New frmError(ex)
        t.TopMost = True
#If RELEASE_MODE = 1 Then
        t.ShowDialog()
#End If
    End Sub
    Private Sub MYThreadHandler(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)
        Console.WriteLine(e.Exception.StackTrace)
        Dim t As New frmError(e.Exception)
        t.TopMost = True
#If RELEASE_MODE = 1 Then
        t.ShowDialog()
#End If
    End Sub




    ' Exit application
    Public Sub ExitYAPM()

        ' Save settings
        Pref.SaveListViewColumns(_frmMain.lvTask, "COLmain_task")
        Pref.SaveListViewColumns(_frmMain.lvServices, "COLmain_service")
        Pref.SaveListViewColumns(_frmMain.lvProcess, "COLmain_process")
        Pref.SaveListViewColumns(_frmMain.lvModules, "COLmain_module")
        Pref.SaveListViewColumns(_frmMain.lvWindows, "COLmain_window")
        Pref.SaveListViewColumns(_frmMain.lvThreads, "COLmain_thread")
        Pref.SaveListViewColumns(_frmMain.lvHandles, "COLmain_handle")
        Pref.SaveListViewColumns(_frmMain.lvNetwork, "COLmain_network")

        My.Settings.Save()

        ' Uninstall driver
        Try
            cHandle.GetOpenedHandlesClass.Close()
        Catch ex As Exception
            '
        End Try

        ' Close forms & exit
        My.Settings.HideWhenClosed = False
        If _frmMain IsNot Nothing Then
            _frmMain.Close()
        End If
        Application.Exit()

    End Sub

    Private Sub theConnection_Disconnected() Handles theConnection.Disconnected
        ' Clear list of processes (used to get ParentProcess name)
        Call cProcess.ClearProcessDico()
    End Sub
End Module
