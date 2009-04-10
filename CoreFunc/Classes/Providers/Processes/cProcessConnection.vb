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
Imports System.Net
Imports System.Windows.Forms
Imports System.Management
Imports System.Net.Sockets
Imports System.Text

Public Class cProcessConnection

    Private Const NO_INFO_RETRIEVED As String = "N/A"

    ' We will invoke this control
    Private _control As Control

    ' Rights to query infos with a handle
    Private Shared _minRights As API.PROCESS_RIGHTS = API.PROCESS_RIGHTS.PROCESS_QUERY_INFORMATION

    ' For processor count
    Private Shared _processors As Integer = 1

    ' For WMI
    Friend wmiSearcher As Management.ManagementObjectSearcher

    Public Shared ReadOnly Property ProcessMinRights() As API.PROCESS_RIGHTS
        Get
            Return _minRights
        End Get
    End Property

    Public Sub New(ByVal ControlWhichGetInvoked As Control, ByRef Conn As cConnection)
        _control = ControlWhichGetInvoked
        _conObj = Conn
        If IsWindowsVista() Then
            _minRights = API.PROCESS_RIGHTS.PROCESS_QUERY_LIMITED_INFORMATION
        End If
    End Sub

#Region "Events, delegate, invoke..."

    Public Delegate Sub ConnectedEventHandler(ByVal Success As Boolean)
    Public Delegate Sub DisconnectedEventHandler(ByVal Success As Boolean)
    Public Delegate Sub HasEnumeratedEventHandler(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, processInfos), ByVal errorMessage As String)

    Public Connected As ConnectedEventHandler
    Public Disconnected As DisconnectedEventHandler
    Public HasEnumerated As HasEnumeratedEventHandler

#End Region

#Region "Properties"

    Public Shared ReadOnly Property ProcessorCount() As Integer
        Get
            Return _processors
        End Get
    End Property

#End Region

#Region "Description of the type of connection"

    ' Attributes
    Private _connected As Boolean = False
    Private _conObj As cConnection
    Private WithEvents _sock As RemoteControl.cAsyncSocket

    Public ReadOnly Property IsConnected() As Boolean
        Get
            Return _connected
        End Get
    End Property
    Public Property ConnectionObj() As cConnection
        Get
            Return _conObj
        End Get
        Set(ByVal value As cConnection)
            If _connected = False Then
                _conObj = value
            End If
        End Set
    End Property


    ' Connection
    Public Sub Connect()
        Dim t As New Threading.Thread(AddressOf asyncConnect)
        t.Priority = Threading.ThreadPriority.Highest
        t.IsBackground = True
        t.Name = "Connect"
        t.Start()
    End Sub
    Public Sub asyncConnect()

        ' Connect
        Select Case _conObj.ConnectionType
            Case cConnection.TypeOfConnection.RemoteConnectionViaSocket

            Case cConnection.TypeOfConnection.RemoteConnectionViaWMI

                Dim __con As New ConnectionOptions
                __con.Impersonation = ImpersonationLevel.Impersonate
                __con.Password = _conObj.WmiParameters.password
                __con.Username = _conObj.WmiParameters.userName

                Try
                    wmiSearcher = New Management.ManagementObjectSearcher("SELECT * FROM Win32_Process")
                    wmiSearcher.Scope = New Management.ManagementScope("\\" & _conObj.WmiParameters.serverName & "\root\cimv2", __con)
                    _connected = True
                Catch ex As Exception
                    '
                End Try

            Case Else
                ' Local
                _connected = True
                _control.Invoke(Connected, True)
        End Select


        ' Get processor count
        Select Case _conObj.ConnectionType
            Case cConnection.TypeOfConnection.RemoteConnectionViaSocket

            Case cConnection.TypeOfConnection.RemoteConnectionViaWMI
                Try
                    Dim objSearcherSystem = New Management.ManagementObjectSearcher("SELECT * FROM Win32_Processor")
                    objSearcherSystem.Scope = wmiSearcher.Scope
                    Dim _count As Integer = 0
                    For Each res As Management.ManagementObject In objSearcherSystem.Get
                        _count += 1
                    Next
                    _processors = _count
                Catch ex As Exception
                    MsgBox("Cannot get informations about system : " & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "WMI connection")
                    _processors = 1
                End Try

            Case Else
                ' Local
                _processors = cSystemInfo.GetProcessorCount
        End Select

    End Sub

    ' Disconnect
    Public Sub Disconnect()
        Dim t As New Threading.Thread(AddressOf asyncDisconnect)
        t.Priority = Threading.ThreadPriority.Highest
        t.Name = "Disconnect"
        t.IsBackground = True
        t.Start()
    End Sub
    Public Sub asyncDisconnect()
        Select Case _conObj.ConnectionType
            Case cConnection.TypeOfConnection.RemoteConnectionViaSocket

            Case cConnection.TypeOfConnection.RemoteConnectionViaWMI
                _connected = False
                _control.Invoke(Disconnected, True)
            Case Else
                ' Local
                _connected = False
                _control.Invoke(Disconnected, True)
        End Select
    End Sub

#End Region

#Region "Enumerate processes"

    ' Enumerate processes
    Public Function Enumerate(ByVal getFixedInfos As Boolean) As Integer
        Call Threading.ThreadPool.QueueUserWorkItem(New  _
                System.Threading.WaitCallback(AddressOf _
                asyncCallbackProcEnumerate.Process), New  _
                asyncCallbackProcEnumerate.poolObj(_control, HasEnumerated, Me))
    End Function

#End Region

#Region "Sock events"

    Private Sub _sock_Connected() Handles _sock.Connected
        _connected = True
    End Sub

    Private Sub _sock_Disconnected() Handles _sock.Disconnected
        _connected = False
    End Sub

    Private Sub _sock_ReceivedData(ByRef data() As Byte, ByVal length As Integer) Handles _sock.ReceivedData
        '
    End Sub

    Private Sub _sock_SentData() Handles _sock.SentData
        '
    End Sub

#End Region

End Class
