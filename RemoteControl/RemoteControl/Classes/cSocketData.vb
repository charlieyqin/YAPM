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


    ' Attributes
    Private _datatType As DataType
    Private _orderType As OrderType
    Private _param1 As Integer
    '<NonSerialized()> Private _dico As New Dictionary(Of String, LightProcess)
    Private _dico As New Dictionary(Of String,

    ' Properties
    Public ReadOnly Property GetDico() As LightProcess() ' Dictionary(Of String, LightProcess)
        Get
            Return _dico
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
    Public ReadOnly Property Param1() As Integer
        Get
            Return _param1
        End Get
    End Property


    ' Create a SocketData
    Public Sub New(ByVal dataT As DataType, Optional ByVal orderT As OrderType = _
                   OrderType.DoNothing, Optional ByVal param As Integer = -1)
        _datatType = dataT
        _orderType = orderT
        _param1 = param
    End Sub

    ' Set process list
    Public Sub SetProcessList(ByVal dico() As LightProcess) '  Dictionary(Of String, LightProcess))
        _dico = dico
    End Sub

End Class
