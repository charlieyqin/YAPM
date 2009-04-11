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

<Serializable()> Public Class cSocketData

    ' Type of data to send
    Public Enum DataType As Byte
        [Order] = 1                 ' An order (nothing expected after)
        [RequestedList] = 2         ' Requested list
    End Enum

    ' Type of orders
    Public Enum OrderType As Byte

        ' Process functions
        [ProcessKill]
        [ProcessKillTree]
        [ProcessReduceWorkingSet]
        [ProcessChangePriority]
        [ProcessChangeAffinity]
        [ProcessIncreasePriority]
        [ProcessDecreasePriority]
        [ProcessResume]
        [ProcessSuspend]
        [ProcessCreateNew]

        ' Service functions
        [ServicePause]
        [ServiceResume]
        [ServiceStop]
        [ServiceShutdown]
        [ServiceChangeServiceStartType]

        ' Request lists
        [RequestProcessList]
        [RequestServiceList]
        [RequestModuleList]
        [RequestThreadList]
        [RequestWindowList]
        [RequestHandleList]
        [RequestTaskList]
        [RequestNetworkConnectionList]
        [RequestPrivilegesList]
        [RequestMemoryRegionList]
        [RequestEnvironmentVariableList]

        ' General commands
        [GeneralCommandSearch]
        [GeneralCommandShutdown]
        [GeneralCommandRestart]
        [GeneralCommandPoweroff]
        [GeneralCommandSleep]
        [GeneralCommandHibernate]
        [GeneralCommandLogout]
        [GeneralCommandLock]

        ' Nothing
        [DoNothing]

    End Enum


    ' Type of data to send/receive
    Private _datatType As DataType
    Private _orderType As OrderType

    ' Some parameters for our functions
    Private _param1 As Object
    Private _param2 As Object
    Private _param3 As Object
    Private _param4 As Object

    ' Contains items requested
    Private _list() As generalInfos
    Private _keys() As String

    ' Properties
    Public ReadOnly Property GetList() As generalInfos()
        Get
            Return _list
        End Get
    End Property
    Public ReadOnly Property GetKeys() As String()
        Get
            Return _keys
        End Get
    End Property
    Public ReadOnly Property Type() As DataType
        Get
            Return _datatType
        End Get
    End Property
    Public ReadOnly Property Order() As OrderType
        Get
            Return _orderType
        End Get
    End Property
    Public ReadOnly Property Param1() As Object
        Get
            Return _param1
        End Get
    End Property
    Public ReadOnly Property Param2() As Object
        Get
            Return _param2
        End Get
    End Property
    Public ReadOnly Property Param3() As Object
        Get
            Return _param3
        End Get
    End Property
    Public ReadOnly Property Param4() As Object
        Get
            Return _param4
        End Get
    End Property

    ' Create a SocketData
    Public Sub New(ByVal dataT As DataType, Optional ByVal orderT As OrderType = _
                    OrderType.DoNothing, Optional ByVal param1 As Object = Nothing, _
                    Optional ByVal param2 As Object = Nothing, _
                    Optional ByVal param3 As Object = Nothing, _
                    Optional ByVal param4 As Object = Nothing)
        _datatType = dataT
        _orderType = orderT
        _param1 = param1
        _param2 = param2
        _param3 = param3
        _param4 = param4
    End Sub

#Region "Set list to data"

    Public Sub SetProcessList(ByVal dico As Dictionary(Of String, processInfos))
        If dico Is Nothing Then
            Exit Sub
        End If

        ' Transform a dico into two lists
        ReDim _list(dico.Count - 1)
        ReDim _keys(dico.Count - 1)

        Dim x As Integer = 0
        For Each pp As System.Collections.Generic.KeyValuePair(Of String, processInfos) In dico
            _list(x) = pp.Value
            _keys(x) = pp.Key
            x += 1
        Next

    End Sub

    Public Sub SetNetworkList(ByVal dico As Dictionary(Of String, networkInfos))
        If dico Is Nothing Then
            Exit Sub
        End If

        ' Transform a dico into two lists
        ReDim _list(dico.Count - 1)
        ReDim _keys(dico.Count - 1)

        Dim x As Integer = 0
        For Each pp As System.Collections.Generic.KeyValuePair(Of String, networkInfos) In dico
            _list(x) = pp.Value
            _keys(x) = pp.Key
            x += 1
        Next

    End Sub

    Public Sub SetModuleList(ByVal dico As Dictionary(Of String, moduleInfos))
        If dico Is Nothing Then
            Exit Sub
        End If

        ' Transform a dico into two lists
        ReDim _list(dico.Count - 1)
        ReDim _keys(dico.Count - 1)

        Dim x As Integer = 0
        For Each pp As System.Collections.Generic.KeyValuePair(Of String, moduleInfos) In dico
            _list(x) = pp.Value
            _keys(x) = pp.Key
            x += 1
        Next

    End Sub

    Public Sub SetServiceList(ByVal dico As Dictionary(Of String, serviceInfos))
        If dico Is Nothing Then
            Exit Sub
        End If

        ' Transform a dico into two lists
        ReDim _list(dico.Count - 1)
        ReDim _keys(dico.Count - 1)

        Dim x As Integer = 0
        For Each pp As System.Collections.Generic.KeyValuePair(Of String, serviceInfos) In dico
            _list(x) = pp.Value
            _keys(x) = pp.Key
            x += 1
        Next

    End Sub

#End Region

End Class