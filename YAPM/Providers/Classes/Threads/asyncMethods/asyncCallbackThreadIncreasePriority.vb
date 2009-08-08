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
Imports System.Text

Public Class asyncCallbackThreadIncreasePriority

    Private con As cThreadConnection
    Private _deg As HasIncreasedPriority

    Public Delegate Sub HasIncreasedPriority(ByVal Success As Boolean, ByVal msg As String, ByVal actionNumber As Integer)

    Public Structure poolObj
        Public id As Integer
        Public level As Integer
        Public pid As Integer
        Public newAction As Integer
        Public Sub New(ByVal _id As Integer, _
                        ByVal _level As Integer, _
                       ByVal action As Integer, Optional ByVal processId As Integer = 0)
            newAction = action
            id = _id
            level = _level
            pid = processId
        End Sub
    End Structure

    Public Sub New(ByVal deg As HasIncreasedPriority, ByRef procConnection As cThreadConnection)
        _deg = deg
        con = procConnection
    End Sub

    Public Sub Process(ByVal thePoolObj As Object)

        Dim pObj As poolObj = DirectCast(thePoolObj, poolObj)
        If con.ConnectionObj.IsConnected = False Then
            Exit Sub
        End If

        Select Case con.ConnectionObj.ConnectionType
            Case cConnection.TypeOfConnection.RemoteConnectionViaSocket
                Try
                    Dim cDat As New cSocketData(cSocketData.DataType.Order, cSocketData.OrderType.ThreadIncreasePriority, pObj.pid, pObj.id, pObj.level)
                    con.ConnectionObj.Socket.Send(cDat)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case cConnection.TypeOfConnection.RemoteConnectionViaWMI

            Case Else
                ' Local
                Dim _level2 As System.Diagnostics.ThreadPriorityLevel
                Select Case pObj.level
                    Case ThreadPriorityLevel.AboveNormal
                        _level2 = ThreadPriorityLevel.Highest
                    Case ThreadPriorityLevel.BelowNormal
                        _level2 = ThreadPriorityLevel.Normal
                    Case ThreadPriorityLevel.Highest
                        _level2 = ThreadPriorityLevel.TimeCritical
                    Case ThreadPriorityLevel.Idle
                        _level2 = ThreadPriorityLevel.Lowest
                    Case ThreadPriorityLevel.Lowest
                        _level2 = ThreadPriorityLevel.BelowNormal
                    Case ThreadPriorityLevel.Normal
                        _level2 = ThreadPriorityLevel.AboveNormal
                    Case ThreadPriorityLevel.TimeCritical
                        '
                End Select

                Dim hProc As Integer
                Dim r As UInteger = -1
                hProc = API.OpenThread(API.THREAD_RIGHTS.THREAD_SET_INFORMATION, 0, pObj.id)
                If hProc > 0 Then
                    r = API.SetThreadPriority(New IntPtr(hProc), _level2)
                    API.CloseHandle(hProc)
                    _deg.Invoke(r <> 0, API.GetError, pObj.newAction)
                Else
                    _deg.Invoke(False, API.GetError, pObj.newAction)
                End If
        End Select
    End Sub

End Class