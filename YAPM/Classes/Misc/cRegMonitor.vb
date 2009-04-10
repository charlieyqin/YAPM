' =======================================================
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
Imports System.Threading

Public Class cRegMonitor

    ' Definition of a key
    Public Structure KeyDefinition
        Dim name As String
        ' Add what you want
    End Structure

    ' Event to raise
    Public Event KeyAdded(ByVal key As KeyDefinition)
    Public Event KeyDeleted(ByVal key As KeyDefinition)

    Private _hEvent As Integer
    Private _hKey As Integer
    Private _type As API.KEY_MONITORING_TYPE
    Private _keys() As String
    Private _ss() As String
    Private _path As String
    Private _kt As API.KEY_TYPE
    Public _t As Thread

    ' Constructor
    Public Sub New(ByVal KeyType As API.KEY_TYPE, ByVal path As String, ByVal monType As  _
        API.KEY_MONITORING_TYPE)

        ' Launch event waiting
        _kt = KeyType
        _type = monType
        _path = path
        _t = New Thread(AddressOf ThreadEvent)
        _t.IsBackground = True                  ' Thread will close when app close
        _t.Priority = ThreadPriority.Highest
        _t.Start()

    End Sub

    Protected Overrides Sub Finalize()
        API.RegCloseKey(_hKey)
        API.CloseHandle(_hEvent)
    End Sub

    ' Process thread
    Private Sub ThreadEvent()

        ' Create an event
        Do While True

            Call API.RegOpenKeyEx(CType(_kt, IntPtr), _path, 0, API.KEY_NOTIFY, _hKey)

            _hEvent = CInt(API.CreateEvent(CType(0, IntPtr), True, False, Nothing))

            ' Set monitoring
            Call API.RegNotifyChangeKeyValue(_hKey, 1, _type, _hEvent, 1)

            ' Get current keys
            _keys = getKeys(_path)

            ' Wait for modification
            If API.WaitForSingleObject(_hEvent, API.INFINITE) = API.WAIT_FAILED Then
                ' Buggy
            Else
                ' Changed
                'Trace.WriteLine("Detected a change")
                _ss = getKeys(_path)
                Call keysChanged()

            End If
            Call API.CloseHandle(_hEvent)
            Call API.RegCloseKey(_hKey)
        Loop

    End Sub

    Private Sub keysChanged()

        ' Compare with old list and get differences
        Dim s As String = ""

        Try

            ' Deleted keys
            For Each s In _keys
                Dim s2 As String = ""
                Dim b As Boolean = False
                For Each s2 In _ss
                    If s2 = s Then
                        b = True
                        Exit For
                    End If
                Next
                If Not (b) Then
                    ' s deleted
                    Dim k As KeyDefinition
                    k.name = s
                    'Trace.WriteLine("Key deleted")
                    RaiseEvent KeyDeleted(k)
                End If
            Next

            ' New keys
            For Each s In _ss
                Dim s2 As String = ""
                Dim b As Boolean = False
                For Each s2 In _keys
                    If s2 = s Then
                        b = True
                        Exit For
                    End If
                Next
                If Not (b) Then
                    ' s added
                    Dim k As KeyDefinition
                    k.name = s
                    'Trace.WriteLine("Key added")
                    RaiseEvent KeyAdded(k)
                End If
            Next

        Catch ex As Exception
            '
        End Try

    End Sub

    ' Get list of all subkeys from registry
    Public Shared Function getKeys(ByVal path As String) As String()
        Dim key As Microsoft.Win32.RegistryKey = _
            My.Computer.Registry.LocalMachine.OpenSubKey(path)
        Try
            Return key.GetSubKeyNames
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
