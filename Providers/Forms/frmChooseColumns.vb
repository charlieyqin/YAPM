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

Public Class frmChooseColumns

    Private theListview As customLV
    Private theClass As cGeneralObject

    Public Property ConcernedListView() As customLV
        Get
            Return theListview
        End Get
        Set(ByVal value As customLV)
            theListview = value
        End Set
    End Property


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        ' Remove all columns
        theListview.ReorganizeColumns = True
        For x As Integer = theListview.Columns.Count - 1 To 1 Step -1
            theListview.Columns.Remove(theListview.Columns(x))
        Next

        For Each it As ListViewItem In theListview.Items
            it.SubItems.Clear()
            Dim subit() As ListViewItem.ListViewSubItem
            ReDim subit(Me.lv.CheckedItems.Count)

            For z As Integer = 0 To UBound(subit) - 1
                subit(z) = New ListViewItem.ListViewSubItem
            Next

            it.SubItems.AddRange(subit)
        Next

        ' Add new columns
        For Each it As ListViewItem In Me.lv.CheckedItems
            theListview.Columns.Add(it.Text, 90)
        Next

        theListview.ReorganizeColumns = False
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdSelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelAll.Click
        Dim it As ListViewItem
        For Each it In Me.lv.Items
            it.Checked = True
        Next
    End Sub

    Private Sub btnUnSelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnSelAll.Click
        Dim it As ListViewItem
        For Each it In Me.lv.Items
            it.Checked = False
        Next
    End Sub

    Private Sub frmChooseProcessColumns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        API.SetWindowTheme(Me.lv.Handle, "explorer", Nothing)

        Dim ss() As String
        ReDim ss(-1)

        ' This is some kind of shit.
        ' But as I can't write a MustOverride Shared Function...
        If TypeOf (ConcernedListView) Is handleList Then
            ss = handleInfos.GetAvailableProperties
        ElseIf TypeOf (ConcernedListView) Is memoryList Then
            ss = memRegionInfos.GetAvailableProperties
        ElseIf TypeOf (ConcernedListView) Is moduleList Then
            ss = moduleInfos.GetAvailableProperties
        ElseIf TypeOf (ConcernedListView) Is networkList Then
            ss = networkInfos.GetAvailableProperties
        ElseIf TypeOf (ConcernedListView) Is processList Then
            ss = processInfos.GetAvailableProperties
        ElseIf TypeOf (ConcernedListView) Is serviceList Then
            ss = serviceInfos.GetAvailableProperties
        ElseIf TypeOf (ConcernedListView) Is taskList Then
            ss = taskInfos.GetAvailableProperties
        ElseIf TypeOf (ConcernedListView) Is threadList Then
            ss = threadInfos.GetAvailableProperties
        ElseIf TypeOf (ConcernedListView) Is windowList Then
            ss = windowInfos.GetAvailableProperties
        ElseIf TypeOf (ConcernedListView) Is privilegeList Then
            ss = privilegeInfos.GetAvailableProperties
        ElseIf TypeOf (ConcernedListView) Is envVariableList Then
            ss = envVariableInfos.GetAvailableProperties
        End If

        ReDim Preserve ss(ss.Length + 1)
        ss(ss.Length - 2) = "ObjectCreationDate"
        ss(ss.Length - 1) = "PendingTaskCount"

        For Each s As String In ss
            Dim it As New ListViewItem(s)

            ' Checked displayed columns
            For x As Integer = 0 To theListview.Columns.Count - 1
                If s = theListview.Columns(x).Text.Replace("< ", "").Replace("> ", "") Then
                    it.Checked = True
                    Exit For
                End If
            Next

            Me.lv.Items.Add(it)
        Next
    End Sub
End Class