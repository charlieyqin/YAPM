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

Imports CoreFunc.cProcessConnection
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Management

Public Class asyncCallbackServiceStart

    Private _name As String
    Private _connection As cServiceConnection
    Private _deg As HasStarted

    Public Delegate Sub HasStarted(ByVal Success As Boolean, ByVal name As String, ByVal msg As String)

    Public Sub New(ByVal deg As HasStarted, ByVal name As String, ByRef procConnection As cServiceConnection)
        _name = name
        _deg = deg
        _connection = procConnection
    End Sub

    Public Sub Process()
        Select Case _connection.ConnectionObj.ConnectionType
            Case cConnection.TypeOfConnection.RemoteConnectionViaSocket

            Case cConnection.TypeOfConnection.RemoteConnectionViaWMI
                Try
                    Dim res As Integer = 2        ' Access denied
                    For Each srv As ManagementObject In _connection.wmiSearcher.Get
                        If CStr(srv.GetPropertyValue(API.WMI_INFO_SERVICE.Name.ToString)) = _name Then
                            res = CInt(srv.InvokeMethod("StartService", Nothing))
                            Exit For
                        End If
                    Next
                    _deg.Invoke(res = 0, _name, CType(res, API.SERVICE_RETURN_CODE_WMI).ToString)
                Catch ex As Exception
                    _deg.Invoke(False, _name, ex.Message)
                End Try

            Case Else
                ' Local
                Dim hSCManager As IntPtr = _connection.SCManagerLocalHandle
                Dim lServ As IntPtr = API.OpenService(hSCManager, _name, API.SERVICE_RIGHTS.SERVICE_START)
                Dim res As Integer = 0
                If hSCManager <> IntPtr.Zero Then
                    If lServ <> IntPtr.Zero Then
                        res = API.apiStartService(lServ, 0, 0)
                        API.CloseServiceHandle(lServ)
                    End If
                End If
                _deg.Invoke(res <> 0, _name, API.GetError)
        End Select
    End Sub

End Class