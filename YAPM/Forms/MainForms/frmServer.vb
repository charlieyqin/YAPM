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

Imports System.Net
Imports System.Net.Sockets

Public Class frmServer

    Private WithEvents sock As New AsynchronousSocketListener
    Private Const PORT As Integer = 8081
    Private _state As SOCK_STATE = SOCK_STATE.Disconnected

    Private Enum SOCK_STATE As Integer
        Connected
        WaitingConnection
        Disconnected
    End Enum

    Private theConnection As New cConnection
    Private _procCon As New cProcessConnection(Me, theConnection, New cProcessConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedProcess))
    Private _windowCon As New cWindowConnection(Me, theConnection, New cWindowConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedWindows))
    Private _envCon As New cEnvVariableConnection(Me, theConnection, New cEnvVariableConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedEnvVar))
    Private _handleCon As New cHandleConnection(Me, theConnection, New cHandleConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedHandle))
    Private _memoryCon As New cMemRegionConnection(Me, theConnection, New cMemRegionConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedMemoryReg))
    Private _moduleCon As New cModuleConnection(Me, theConnection, New cModuleConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedModule))
    Private _networkCon As New cNetworkConnection(Me, theConnection, New cNetworkConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedNetwork))
    Private _serviceCon As New cServiceConnection(Me, theConnection, New cServiceConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedService))
    Private _servdepCon As New cServDepConnection(Me, theConnection, New cServDepConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedServDep))
    Private _priviCon As New cPrivilegeConnection(Me, theConnection, New cPrivilegeConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedPrivilege))
    Private _taskCon As New cTaskConnection(Me, theConnection, New cTaskConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedTask))
    Private _threadCon As New cThreadConnection(Me, theConnection, New cThreadConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedThread))
    Private _searchCon As New cSearchConnection(Me, theConnection, New cSearchConnection.HasEnumeratedEventHandler(AddressOf HasEnumeratedSearch))

    ' Connect to local machine
    Private Sub connectLocal()

        ' Set connection
        Try
            With theConnection
                .ConnectionType = cConnection.TypeOfConnection.LocalConnection
                .Connect()
            End With

            _procCon.ConnectionObj = theConnection
            _networkCon.ConnectionObj = theConnection
            _serviceCon.ConnectionObj = theConnection
            _windowCon.ConnectionObj = theConnection
            _threadCon.ConnectionObj = theConnection
            _envCon.ConnectionObj = theConnection
            _handleCon.ConnectionObj = theConnection
            _moduleCon.ConnectionObj = theConnection
            _memoryCon.ConnectionObj = theConnection
            _priviCon.ConnectionObj = theConnection
            _taskCon.ConnectionObj = theConnection
            _searchCon.ConnectionObj = theConnection
            _servdepCon.ConnectionObj = theConnection

            _networkCon.Connect()
            _moduleCon.Connect()
            _searchCon.Connect()
            _serviceCon.Connect()
            _servdepCon.Connect()
            _envCon.Connect()
            _memoryCon.Connect()
            _taskCon.Connect()
            _priviCon.Connect()
            _windowCon.Connect()
            _threadCon.Connect()
            _handleCon.Connect()
            _procCon.Connect()

            cWindow.Connection = _windowCon
            cProcess.Connection = _procCon
            cThread.Connection = _threadCon
            cEnvVariable.Connection = _envCon
            cHandle.Connection = _handleCon
            cMemRegion.Connection = _memoryCon
            cModule.Connection = _moduleCon
            cNetwork.Connection = _networkCon
            cService.Connection = _serviceCon
            cPrivilege.Connection = _priviCon
            cTask.Connection = _taskCon

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#Region "Has enumerated lists"

    Private Sub HasEnumeratedEnvVar(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, envVariableInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestEnvironmentVariableList)
                cDat.InstanceId = instanceId   ' The instance which requested the list
                cDat.SetEnvVarList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedServDep(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, serviceInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestServDepList)
                cDat.InstanceId = instanceId   ' The instance which requested the list
                cDat.SetServiceList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedMemoryReg(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, memRegionInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestMemoryRegionList)
                cDat.InstanceId = instanceId   ' The instance which requested the list
                cDat.SetMemoryRegList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedProcess(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, processInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestProcessList)
                cDat.InstanceId = instanceId   ' The instance which requested the list
                cDat.SetProcessList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedPrivilege(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, privilegeInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestPrivilegesList)
                cDat.InstanceId = instanceId   ' The instance which requested the list
                cDat.SetPrivilegeList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedService(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, serviceInfos), ByVal errorMessage As String, ByVal forII As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestServiceList)
                cDat.InstanceId = forII   ' The instance which requested the list
                cDat.SetServiceList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedThread(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, threadInfos), ByVal errorMessage As String, ByVal forII As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestThreadList)
                cDat.InstanceId = forII   ' The instance which requested the list
                cDat.SetThreadList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedModule(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, moduleInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestModuleList)
                cDat.InstanceId = instanceId  ' The instance which requested the list
                cDat.SetModuleList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedHandle(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, handleInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestHandleList)
                cDat.InstanceId = instanceId  ' The instance which requested the list
                cDat.SetHandleList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedNetwork(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, networkInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestNetworkConnectionList)
                cDat.InstanceId = instanceId  ' The instance which requested the list
                cDat.SetNetworkList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedSearch(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, searchInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestSearchList)
                cDat.InstanceId = instanceId  ' The instance which requested the list
                cDat.SetSearchList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedTask(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, windowInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestTaskList)
                cDat.InstanceId = instanceId  ' The instance which requested the list
                cDat.SetWindowsList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub

    Private Sub HasEnumeratedWindows(ByVal Success As Boolean, ByVal Dico As Dictionary(Of String, windowInfos), ByVal errorMessage As String, ByVal instanceId As Integer)

        If Success Then
            Try
                Dim cDat As New cSocketData(cSocketData.DataType.RequestedList, cSocketData.OrderType.RequestWindowList)
                cDat.InstanceId = instanceId  ' The instance which requested the list
                cDat.SetWindowsList(Dico)
                sock.Send(cDat)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' Send an error
        End If

    End Sub
#End Region

    Private Sub frmServeur_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            sock.Disconnect()
        Catch ex As Exception
            '
        End Try
    End Sub

    Private Delegate Sub ChangeConnectState(ByVal state As SOCK_STATE)
    Private Sub handlerChangeConnectState(ByVal state As SOCK_STATE)
        Select Case state
            Case SOCK_STATE.Connected
                Me.cmdConnection.Text = "Disconnect !"
                Me.Text = "YAPM remote process (connected)"
            Case SOCK_STATE.Disconnected
                Me.cmdConnection.Text = "Connect !"
                Me.Text = "YAPM remote process (disconnected)"
            Case SOCK_STATE.WaitingConnection
                Me.cmdConnection.Text = "Disconnect !"
                Me.Text = "YAPM remote process (waiting for client to connect...)"
        End Select
    End Sub
    Private Sub sock_ConnexionAccepted() Handles sock.Connected
        _state = SOCK_STATE.Connected
        Dim h As New ChangeConnectState(AddressOf handlerChangeConnectState)
        h.Invoke(SOCK_STATE.Connected)
    End Sub
    Private Sub sock_Disconnected() Handles sock.Disconnected
        _state = SOCK_STATE.Disconnected
        Dim h As New ChangeConnectState(AddressOf handlerChangeConnectState)
        h.Invoke(SOCK_STATE.Disconnected)
    End Sub
    Private Sub sock_Waiting() Handles sock.WaitingForConnection
        _state = SOCK_STATE.WaitingConnection
        Dim h As New ChangeConnectState(AddressOf handlerChangeConnectState)
        h.Invoke(SOCK_STATE.WaitingConnection)
    End Sub

    Private Sub sock_ReceivedData(ByRef cData As cSocketData) Handles sock.ReceivedData
        Try

            If cData Is Nothing Then
                Trace.WriteLine("Serialization error")
                Exit Sub
            End If

            Dim _forInstanceId As Integer = cData.InstanceId

            ' Add item to history
            Me.Invoke(New addItemHandler(AddressOf addItem), cData)

            ' Extract the type of information we have to send
            If cData.Type = cSocketData.DataType.Order Then

                ' ===== Request lists
                Select Case cData.Order
                    Case cSocketData.OrderType.RequestProcessList
                        Call _procCon.Enumerate(True, _forInstanceId)
                    Case cSocketData.OrderType.RequestNetworkConnectionList
                        Dim pid() As Integer = CType(cData.Param1, Integer())
                        Dim all As Boolean = CBool(cData.Param2)
                        Call _networkCon.Enumerate(True, pid, all, _forInstanceId)
                    Case cSocketData.OrderType.RequestServiceList
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Dim all As Boolean = CBool(cData.Param2)
                        Call _serviceCon.Enumerate(True, pid, all, _forInstanceId)
                    Case cSocketData.OrderType.RequestModuleList
                        Dim pid() As Integer = CType(cData.Param1, Integer())
                        Call _moduleCon.Enumerate(True, pid, _forInstanceId)
                    Case cSocketData.OrderType.RequestThreadList
                        Dim pid() As Integer = CType(cData.Param1, Integer())
                        Call _threadCon.Enumerate(True, pid, _forInstanceId)
                    Case cSocketData.OrderType.RequestHandleList
                        Dim pid() As Integer = CType(cData.Param1, Integer())
                        Dim unn As Boolean = CBool(cData.Param2)
                        Call _handleCon.Enumerate(True, pid, unn, _forInstanceId)
                    Case cSocketData.OrderType.RequestWindowList
                        Dim pid() As Integer = CType(cData.Param1, Integer())
                        Dim all As Boolean = CBool(cData.Param3)
                        Dim unn As Boolean = CBool(cData.Param2)
                        Call _windowCon.Enumerate(True, pid, unn, all, _forInstanceId)
                    Case cSocketData.OrderType.RequestTaskList
                        Call _taskCon.Enumerate(True, _forInstanceId)
                    Case cSocketData.OrderType.RequestSearchList
                        Dim st As String = CStr(cData.Param1)
                        Dim include As searchInfos.SearchInclude = CType(cData.Param2, searchInfos.SearchInclude)
                        Dim _case As Boolean = CBool(cData.Param3)
                        Call _searchCon.Enumerate(st, _case, include, _forInstanceId)
                    Case cSocketData.OrderType.RequestPrivilegesList
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Call _priviCon.Enumerate(True, pid, _forInstanceId)
                    Case cSocketData.OrderType.RequestEnvironmentVariableList
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Dim peb As Integer = CType(cData.Param2, Integer)
                        Call _envCon.Enumerate(True, pid, peb, _forInstanceId)
                    Case cSocketData.OrderType.RequestMemoryRegionList
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        'Dim all As Boolean = CBool(cData.Param2)   ' NOT NEEDED
                        Call _memoryCon.Enumerate(True, pid, _forInstanceId)
                    Case cSocketData.OrderType.RequestServDepList
                        Dim name As String = CStr(cData.Param1)
                        Dim type As cServDepConnection.DependenciesToget = CType(cData.Param2, cServDepConnection.DependenciesToget)
                        Call _servdepCon.Enumerate(name, type, _forInstanceId)
                End Select



                ' ===== Process functions
                Select Case cData.Order
                    Case cSocketData.OrderType.ProcessCreateNew
                        Try
                            Dim s As String = CStr(cData.Param1)
                            Dim pid As Integer = Shell(s, AppWinStyle.NormalFocus)
                        Catch ex As Exception
                            '
                        End Try
                    Case cSocketData.OrderType.ProcessReanalize
                        asyncCallbackProcEnumerate.ReanalizeLocalAfterSocket(CType(cData.Param1, Integer()))
                    Case cSocketData.OrderType.ProcessChangeAffinity
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Dim aff As Integer = CType(cData.Param2, Integer)
                        Try
                            cProcess.GetProcessById(pid).SetAffinity(aff)
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ProcessChangePriority
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Dim level As System.Diagnostics.ProcessPriorityClass = CType(cData.Param2, ProcessPriorityClass)
                        Try
                            cProcess.GetProcessById(pid).SetPriority(level)
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ProcessDecreasePriority
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Try
                            cProcess.GetProcessById(pid).DecreasePriority()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ProcessIncreasePriority
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Try
                            cProcess.GetProcessById(pid).IncreasePriority()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ProcessKill
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Try
                            cProcess.GetProcessById(pid).Kill()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ProcessKillTree
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Try
                            cProcess.GetProcessById(pid).KillProcessTree()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ProcessReduceWorkingSet
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Try
                            cProcess.GetProcessById(pid).EmptyWorkingSetSize()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ProcessResume
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Try
                            cProcess.GetProcessById(pid).ResumeProcess()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ProcessSuspend
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Try
                            cProcess.GetProcessById(pid).SuspendProcess()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                End Select



                ' ===== Windows functions
                Select Case cData.Order
                    Case cSocketData.OrderType.WindowBringToFront
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).BringToFront(True)
                    Case cSocketData.OrderType.WindowClose
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).Close()
                    Case cSocketData.OrderType.WindowDisable
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Dim w As cWindow = New cWindow(hWnd)
                        w.Enabled = False
                    Case cSocketData.OrderType.WindowDoNotBringToFront
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).BringToFront(False)
                    Case cSocketData.OrderType.WindowEnable
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Dim w As cWindow = New cWindow(hWnd)
                        w.Enabled = True
                    Case cSocketData.OrderType.WindowFlash
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).Flash()
                    Case cSocketData.OrderType.WindowHide
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).Hide()
                    Case cSocketData.OrderType.WindowMaximize
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).Maximize()
                    Case cSocketData.OrderType.WindowMinimize
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).Minimize()
                    Case cSocketData.OrderType.WindowSetAsActiveWindow
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).SetAsActiveWindow()
                    Case cSocketData.OrderType.WindowSetAsForegroundWindow
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).SetAsForegroundWindow()
                    Case cSocketData.OrderType.WindowSetCaption
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Dim s As String = CStr(cData.Param2)
                        Dim w As cWindow = New cWindow(hWnd)
                        w.Caption = s
                    Case cSocketData.OrderType.WindowSetOpacity
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Dim o As Byte = CByte(cData.Param2)
                        Dim w As cWindow = New cWindow(hWnd)
                        w.Opacity = o
                    Case cSocketData.OrderType.WindowSetPositions
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Dim r As API.RECT = CType(cData.Param2, API.RECT)
                        Call (New cWindow(hWnd)).SetPositions(r)
                    Case cSocketData.OrderType.WindowShow
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).Show()
                    Case cSocketData.OrderType.WindowStopFlashing
                        Dim hWnd As Integer = CInt(cData.Param1)
                        Call (New cWindow(hWnd)).StopFlashing()
                End Select



                ' ===== Service functions
                Select Case cData.Order
                    Case cSocketData.OrderType.ServiceReanalize
                        asyncCallbackServiceEnumerate.ReanalizeLocalAfterSocket(CType(cData.Param1, String()))
                    Case cSocketData.OrderType.ServicePause
                        Dim name As String = CStr(cData.Param1)
                        Try
                            cService.GetServiceByName(name).PauseService()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ServiceChangeServiceStartType
                        Dim name As String = CStr(cData.Param1)
                        Dim type As API.SERVICE_START_TYPE = CType(cData.Param2, API.SERVICE_START_TYPE)
                        Try
                            cService.GetServiceByName(name).SetServiceStartType(type)
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ServiceResume
                        Dim name As String = CStr(cData.Param1)
                        Try
                            cService.GetServiceByName(name).ResumeService()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ServiceStart
                        Dim name As String = CStr(cData.Param1)
                        Try
                            cService.GetServiceByName(name).StartService()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ServiceStop
                        Dim name As String = CStr(cData.Param1)
                        Try
                            cService.GetServiceByName(name).StopService()
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                End Select



                ' ===== Other functions
                Select cData.Order
                    Case cSocketData.OrderType.HandleClose
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Dim handle As Integer = CType(cData.Param2, Integer)
                        Try
                            cHandle.SharedLRCloseHandle(pid, handle)
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.ModuleUnload
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Dim address As Integer = CType(cData.Param2, Integer)
                        Try
                            cProcess.SharedRLUnLoadModuleFromProcess(pid, address)
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                    Case cSocketData.OrderType.PrivilegeChangeStatus
                        Dim pid As Integer = CType(cData.Param1, Integer)
                        Dim name As String = CType(cData.Param2, String)
                        Dim status As API.PRIVILEGE_STATUS = CType(cData.Param3, API.PRIVILEGE_STATUS)
                        Try
                            cPrivilege.LocalChangeStatus(pid, name, status)
                        Catch ex As Exception
                            ' Process does not exist
                        End Try
                End Select


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnection.Click
        ' Connect or disconnect the socket (server)
        Try
            If _state = SOCK_STATE.Disconnected Then
                sock.Connect(PORT)
            Else
                sock.Disconnect()
            End If
            Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmServeur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        API.SetWindowTheme(Me.lvServer.Handle, "explorer", Nothing)

        'sock.ConnexionAccepted = New AsynchronousServer.ConnexionAcceptedEventHandle(AddressOf sock_ConnexionAccepted)
        'sock.Disconnected = New AsynchronousServer.DisconnectedEventHandler(AddressOf sock_Disconnected)
        'sock.SentData = New AsynchronousServer.SentDataEventHandler(AddressOf sock_SentData)

        connectLocal()

    End Sub

    Private Delegate Sub addItemHandler(ByRef dat As cSocketData)
    Private Sub addItem(ByRef dat As cSocketData)
        Dim it As New ListViewItem(Date.Now.ToLongDateString & " - " & Date.Now.ToLongTimeString)
        it.SubItems.Add(dat.ToString)
        Me.lvServer.Items.Add(it)
    End Sub

End Class