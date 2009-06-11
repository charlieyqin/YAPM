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

Public Class cNetwork
    Inherits cGeneralObject
    Implements IDisposable

    Private Const NO_INFO_RETRIEVED As String = "N/A"

    Private nullAddress As New IPAddress(0)     ' For address comparison

    Private _firstRefresh As Boolean = True
    Private _networkInfos As networkInfos
    Private _path As String
    Private Shared WithEvents _connection As cNetworkConnection

#Region "Properties"

    Public Shared Property Connection() As cNetworkConnection
        Get
            Return _connection
        End Get
        Set(ByVal value As cNetworkConnection)
            _connection = value
        End Set
    End Property

#End Region

#Region "Constructors & destructor"

    Public Sub New(ByRef infos As networkInfos)
        _networkInfos = infos
        _connection = Connection

        ' Solve DNS
        Try
            If Me.Infos._Local.Address.Equals(nullAddress) = False Then
                Dim callback As System.AsyncCallback = AddressOf ProcessLocalDnsInformation
                Dns.BeginGetHostEntry(Me.Infos._Local.Address, callback, Nothing)
                'GC.KeepAlive(callback)
            End If
        Catch ex As Exception
            '
        End Try
        Try
            If Me.Infos._remote IsNot Nothing AndAlso Me.Infos._remote.Address.Equals(nullAddress) = False Then
                Dim callback2 As System.AsyncCallback = AddressOf ProcessRemoteDnsInformation
                Dns.BeginGetHostEntry(Me.Infos._remote.Address, callback2, Nothing)
                'GC.KeepAlive(callback2)
            End If
        Catch ex As Exception
            '
        End Try
    End Sub
    Private disposed As Boolean = False
    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        ' This object will be cleaned up by the Dispose method.
        ' Therefore, you should call GC.SupressFinalize to
        ' take this object off the finalization queue 
        ' and prevent finalization code for this object
        ' from executing a second time.
        GC.SuppressFinalize(Me)
    End Sub
    Private Overloads Sub Dispose(ByVal disposing As Boolean)
        ' Check to see if Dispose has already been called.
        If Not Me.disposed Then
            ' If disposing equals true, dispose all managed 
            ' and unmanaged resources.
            If disposing Then
                ' Dispose managed resources.

            End If

            ' Note disposing has been done.
            disposed = True

        End If
    End Sub

#End Region

#Region "Normal properties"

    Public ReadOnly Property Infos() As networkInfos
        Get
            Return _networkInfos
        End Get
    End Property

#End Region

#Region "Local shared method"

    Public Shared Function LocalCloseTCP(ByVal locAdd As UInteger, ByVal locPort As Integer, ByVal remAdd As UInteger, ByVal remPort As Integer) As Integer
        Return asyncCallbackNetworkCloseConnection.CloseTcpConnection(locAdd, locPort, remAdd, remPort)
    End Function

#End Region

#Region "All actions on network (close tcp connection)"

    ' Unload module
    Private _closeTCP As asyncCallbackNetworkCloseConnection
    Public Function CloseTCP() As Integer

        If _closeTCP Is Nothing Then
            _closeTCP = New asyncCallbackNetworkCloseConnection(New asyncCallbackNetworkCloseConnection.HasClosedConnection(AddressOf closeTCPDone), _connection)
        End If

        Dim t As New System.Threading.WaitCallback(AddressOf _closeTCP.Process)
        Dim newAction As Integer = cGeneralObject.GetActionCount

        Dim locAdd As UInt32 = 0
        Dim locPort As Integer = 0
        If Me.Infos.Local IsNot Nothing Then
            locAdd = getAddressAsInteger(Me.Infos.Local)
            locPort = PermuteBytes(Me.Infos.Local.Port)
        End If
        Dim remAdd As UInt32 = 0
        Dim remPort As Integer = 0
        If Me.Infos.Remote IsNot Nothing Then
            remAdd = getAddressAsInteger(Me.Infos.Remote)
            remPort = PermuteBytes(Me.Infos.Remote.Port)
        End If
        Call Threading.ThreadPool.QueueUserWorkItem(t, New  _
            asyncCallbackNetworkCloseConnection.poolObj(locAdd, locPort, remAdd, remPort, newAction))

        AddPendingTask2(newAction, t)
    End Function
    Private Sub closeTCPDone(ByVal Success As Boolean, ByVal localAddress As UInteger, ByVal localPort As Integer, ByVal msg As String, ByVal actionNumber As Integer)
        If Success = False Then
            MsgBox("Error : " & msg, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, _
                   "Could not close TCP connection " & localAddress.ToString)
        End If
        RemovePendingTask(actionNumber)
    End Sub


#End Region

    ' Merge current infos and new infos
    Public Sub Merge(ByRef Thr As API.LightConnection)
        _networkInfos.Merge(Thr)
    End Sub

#Region "Get information overriden methods"

    ' Retrieve informations by its name
    Public Overrides Function GetInformation(ByVal info As String) As String

        If info = "ObjectCreationDate" Then
            Return _objectCreationDate.ToLongDateString & " -- " & _objectCreationDate.ToLongTimeString
        ElseIf info = "PendingTaskCount" Then
            Return PendingTaskCount.ToString
        End If

        Dim res As String = NO_INFO_RETRIEVED
        Select Case info
            Case "Local"
                If Me.Infos.Local IsNot Nothing Then
                    If Len(Me.Infos._localString) > 0 Then
                        res = Me.Infos.Local.ToString & "  ----  " & Me.Infos._localString
                    Else
                        res = Me.Infos.Local.ToString
                    End If
                Else
                    res = "0.0.0.0"
                End If
            Case "Remote"
                If Me.Infos.Remote IsNot Nothing Then
                    If Len(Me.Infos._remoteString) > 0 Then
                        res = Me.Infos.Remote.ToString & "  ----  " & Me.Infos._remoteString
                    Else
                        res = Me.Infos.Remote.ToString
                    End If
                End If
            Case "Protocol"
                res = Me.Infos.Protocol.ToString.ToUpperInvariant
            Case "ProcessId"
                res = Me.Infos.ProcessId.ToString
            Case "State"
                If Me.Infos.State > 0 Then
                    res = Me.Infos.State.ToString
                End If
        End Select

        Return res
    End Function


#End Region


    Private Sub ProcessLocalDnsInformation(ByVal result As IAsyncResult)
        Try
            Dim host As IPHostEntry = Dns.EndGetHostEntry(result)
            Me.Infos._localString = host.HostName
        Catch ex As Exception
            '
        End Try
    End Sub

    Private Sub ProcessRemoteDnsInformation(ByVal result As IAsyncResult)
        Try
            Dim host As IPHostEntry = Dns.EndGetHostEntry(result)
            Me.Infos._remoteString = host.HostName
        Catch ex As Exception
            '
        End Try
    End Sub

    Private Function getAddressAsInteger(ByVal ipep As IPEndPoint) As UInteger
        If ipep IsNot Nothing Then
            Dim i As Integer = 0
            Dim addressInteger As UInteger
            For Each b As Byte In ipep.Address.GetAddressBytes
                addressInteger = CUInt(addressInteger + CInt(b) << (8 * i))
                i += 1
            Next
            Return addressInteger
        End If
    End Function

    Public Shared Function PermuteBytes(ByVal v As Integer) As Integer
        Dim b1 As Byte = CType(v, Byte)
        Dim b2 As Byte = CType((v >> 8), Byte)

        Return CInt((b2 + (b1 << 8)))
    End Function
End Class
