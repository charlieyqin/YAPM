﻿' =======================================================
' Yet Another Process Monitor (YAPM)
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

Public Class windowList
    Inherits customLV

    ' ========================================
    ' Private
    ' ========================================
    Private _dicoNew As New Dictionary(Of String, cWindow)
    Private _dicoDel As New Dictionary(Of String, cWindow)
    Private _buffDico As New Dictionary(Of String, cWindow.LightWindow)
    Private _dico As New Dictionary(Of String, cWindow)

    Private _pid() As Integer
    Private _all As Boolean = False
    Private _unnamed As Boolean

#Region "Properties"

    ' ========================================
    ' Properties
    ' ========================================
    Public Property ProcessId() As Integer()
        Get
            Return _pid
        End Get
        Set(ByVal value As Integer())
            _pid = value
        End Set
    End Property
    Public Property ShowAllPid() As Boolean
        Get
            Return _all
        End Get
        Set(ByVal value As Boolean)
            _all = value
        End Set
    End Property
    Public Property ShowUnNamed() As Boolean
        Get
            Return _unnamed
        End Get
        Set(ByVal value As Boolean)
            _unnamed = value
        End Set
    End Property

#End Region

    ' ========================================
    ' Public properties
    ' ========================================

    Public Sub New()

        ' Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _IMG = New ImageList
        _IMG.ImageSize = New Size(16, 16)
        _IMG.ColorDepth = ColorDepth.Depth32Bit

        Me.SmallImageList = _IMG
        _IMG.Images.Add("noIcon", My.Resources.application_blue)

    End Sub

    ' Call this to update items in listview
    Public Overrides Sub UpdateItems()

        Dim _test As Integer = GetTickCount


        ' Create a buffer of subitems if necessary
        If _columnsName Is Nothing Then
            Call CreateSubItemsBuffer()
        End If


        ' Now enumerate items
        Dim _itemId() As Integer
        ReDim _itemId(0)
        If _all Then
            Call cWindow.EnumerateAll(_unnamed, _itemId, _buffDico)
        Else
            Call cWindow.Enumerate(_unnamed, _pid, _itemId, _buffDico)
        End If

        ' Now add all items with isKilled = true to _dicoDel dictionnary
        For Each z As cWindow In _dico.Values
            If z.IsKilledItem Then
                _dicoDel.Add(z.Handle.ToString, Nothing)
            End If
        Next


        ' Now add new items to dictionnary
        For Each z As Integer In _itemId
            If Not (_dico.ContainsKey(z.ToString)) Then
                ' Add to dico
                _dicoNew.Add(z.ToString, Nothing)
            End If
        Next


        ' Now remove deleted items from dictionnary
        For Each z As Integer In _dico.Keys
            If Array.IndexOf(_itemId, z) < 0 Then
                ' Remove from dico
                _dico.Item(z.ToString).IsKilledItem = True  ' Will be deleted next time
            End If
        Next


        ' Now remove all deleted items from listview and _dico
        For Each z As Integer In _dicoDel.Keys
            Me.Items.RemoveByKey(z.ToString)
            _dico.Remove(z.ToString)
        Next
        _dicoDel.Clear()


        ' Merge _dico and _dicoNew
        For Each z As Integer In _dicoNew.Keys
            Dim _it As cWindow = New cWindow(_buffDico.Item(z.ToString))
            _it.IsNewItem = Not (_firstItemUpdate)        ' If first refresh, don't highlight item
            _dico.Add(z.ToString, _it)
        Next


        ' Now add all new items to listview
        ' If first time, lock listview
        If _firstItemUpdate Then Me.BeginUpdate()
        For Each z As Integer In _dicoNew.Keys

            ' Add to listview
            Dim _subItems() As ListViewItem.ListViewSubItem
            ReDim _subItems(Me.Columns.Count - 1)
            For x As Integer = 1 To _subItems.Length - 1
                _subItems(x) = New ListViewItem.ListViewSubItem
            Next
            AddItemWithStyle(z.ToString).SubItems.AddRange(_subItems)

        Next
        If _firstItemUpdate Then Me.EndUpdate()
        _dicoNew.Clear()


        ' Now refresh all subitems of the listview
        Dim isub As ListViewItem.ListViewSubItem
        Dim it As ListViewItem
        For Each it In Me.Items
            Dim x As Integer = 0
            Dim _item As cWindow = _dico.Item(it.Name)
            For Each isub In it.SubItems
                isub.Text = _item.GetInformation(_columnsName(x))
                x += 1
            Next
            If _dico.Item(it.Name).IsNewItem Then
                _dico.Item(it.Name).IsNewItem = False
                it.BackColor = NEW_ITEM_COLOR
            ElseIf _dico.Item(it.Name).IsKilledItem Then
                it.BackColor = DELETED_ITEM_COLOR
            Else
                it.BackColor = Color.White
            End If
        Next

        ' This piece of code is needed. Strange behavior, the Text attribute must
        ' be set twice to be properly displayed.
        If _firstItemUpdate Then
            For Each it In Me.Items
                For Each isub In it.SubItems
                    isub.Text = isub.Text
                Next
            Next
        End If


        ' Sort items
        Me.Sort()

        _firstItemUpdate = False

        _test = GetTickCount - _test
        Trace.WriteLine("It tooks " & _test.ToString & " ms to refresh window list.")

        MyBase.UpdateItems()
    End Sub

    ' Get all items (associated to listviewitems)
    Public Function GetAllItems() As Dictionary(Of String, cWindow).ValueCollection
        Return _dico.Values
    End Function

    ' Get the selected item
    Public Function GetSelectedItem() As cWindow
        If Me.SelectedItems.Count > 0 Then
            Return _dico.Item(Me.SelectedItems.Item(0).Name)
        Else
            Return Nothing
        End If
    End Function

    ' Get a specified item
    Public Function GetItemByKey(ByVal key As String) As cWindow
        Return _dico.Item(key)
    End Function

    ' Get selected items
    Public Function GetSelectedItems() As Dictionary(Of String, cWindow).ValueCollection
        Dim res As New Dictionary(Of String, cWindow)

        For Each it As ListViewItem In Me.SelectedItems
            res.Add(it.Name, _dico.Item(it.Name))
        Next

        Return res.Values
    End Function


    ' ========================================
    ' Private properties
    ' ========================================

    ' Add an item (specific to type of list)
    Friend Overrides Function AddItemWithStyle(ByVal key As String) As ListViewItem

        Dim item As ListViewItem = Me.Items.Add(key)
        item.Name = key
        item.Group = Me.Groups(0)

        ' Add icon
        Try
            Dim icon As System.Drawing.Icon = _dico(key).SmallIcon
            If icon IsNot Nothing Then
                Me.SmallImageList.Images.Add(key, icon)
                item.ImageKey = key
            Else
                item.ImageKey = "noIcon"
            End If
        Catch ex As Exception
            item.ImageKey = "noIcon"
        End Try

        item.Tag = key

        Return item

    End Function

End Class