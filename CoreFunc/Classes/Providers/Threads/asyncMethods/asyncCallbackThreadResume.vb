﻿Option Strict On

Imports CoreFunc.cProcessConnection
Imports System.Runtime.InteropServices
Imports System.Text

Public Class asyncCallbackThreadResume

    Private _id As Integer
    Private _connection As cThreadConnection
    Private _deg As HasResumed

    Public Delegate Sub HasResumed(ByVal Success As Boolean, ByVal msg As String)

    Public Sub New(ByVal deg As HasResumed, ByVal id As Integer, ByRef procConnection As cThreadConnection)
        _id = id
        _deg = deg
        _connection = procConnection
    End Sub

    Public Sub Process()
        Select Case _connection.ConnectionObj.ConnectionType
            Case cConnection.TypeOfConnection.RemoteConnectionViaSocket

            Case cConnection.TypeOfConnection.RemoteConnectionViaWMI

            Case Else
                ' Local
                Dim hProc As Integer
                Dim r As UInteger = -1
                hProc = API.OpenThread(API.THREAD_RIGHTS.THREAD_SUSPEND_RESUME, 0, _id)
                If hProc > 0 Then
                    r = API.ResumeThread(New IntPtr(hProc))
                    API.CloseHandle(hProc)
                    _deg.Invoke(r <> -1, API.GetError)
                Else
                    _deg.Invoke(False, API.GetError)
                End If
        End Select
    End Sub

End Class
