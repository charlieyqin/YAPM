﻿Option Strict On

Imports CoreFunc.cProcessConnection
Imports System.Runtime.InteropServices
Imports System.Text

Public Class asyncCallbackDecreasePriority

    Private _pid As Integer
    Private _level As ProcessPriorityClass
    Private _connection As cProcessConnection

    Public Event HasDecreasedPriority(ByVal Success As Boolean)

    Public Sub New(ByVal pid As Integer, ByVal level As ProcessPriorityClass, ByRef procConnection As cProcessConnection)
        _pid = pid
        _level = level
        _connection = procConnection
    End Sub

    Public Sub Process()
        Select Case _connection.ConnectionObj.ConnectionType
            Case cConnection.TypeOfConnection.RemoteConnectionViaSocket

            Case cConnection.TypeOfConnection.RemoteConnectionViaWMI

            Case Else
                ' Local
                Dim hProc As Integer
                Dim r As Integer
                Dim _newlevel As ProcessPriorityClass
                Select Case _level
                    Case ProcessPriorityClass.AboveNormal
                        _newlevel = ProcessPriorityClass.Normal
                    Case ProcessPriorityClass.BelowNormal
                        _newlevel = ProcessPriorityClass.Idle
                    Case ProcessPriorityClass.High
                        _newlevel = ProcessPriorityClass.AboveNormal
                    Case ProcessPriorityClass.Idle
                        '
                    Case ProcessPriorityClass.Normal
                        _newlevel = ProcessPriorityClass.BelowNormal
                    Case ProcessPriorityClass.RealTime
                        _newlevel = ProcessPriorityClass.High
                End Select
                hProc = API.OpenProcess(API.PROCESS_SET_INFORMATION, 0, _pid)
                If hProc > 0 Then
                    r = API.SetPriorityClass(hProc, _newlevel)
                    API.CloseHandle(hProc)
                    RaiseEvent HasDecreasedPriority(r <> 0)
                Else
                    RaiseEvent HasDecreasedPriority(False)
                End If
        End Select
    End Sub

End Class