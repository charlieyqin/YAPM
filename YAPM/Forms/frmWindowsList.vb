﻿' =======================================================
' Yet Another Process Monitor (YAPM)
' Copyright (c) 2008-2009 Alain Descotes (violent_ken)
' https://sourceforge.net/projects/yaprocmon/
' =======================================================


' YAPM is free software; you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation; either version 2 of the License, or
' (at your option) any later version.
'
' YAPM is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with YAPM; if not, write to the Free Software
' Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA


Option Strict On

Imports System.Runtime.InteropServices

Public Class frmWindowsList

    Private NEW_ITEM_COLOR As Color = Color.FromArgb(128, 255, 0)
    Private DELETED_ITEM_COLOR As Color = Color.FromArgb(255, 64, 48)

    <DllImport("uxtheme.dll", CharSet:=CharSet.Unicode, ExactSpelling:=True)> _
    Private Shared Function SetWindowTheme(ByVal hWnd As IntPtr, ByVal appName As String, ByVal partList As String) As Integer
    End Function

    Private Sub frmWindowsList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetWindowTheme(lv.Handle, "explorer", Nothing)
        Call RefreshWindowsList()
    End Sub

    Private Sub timerRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerRefresh.Tick
        Call RefreshWindowsList()
    End Sub

    ' List all windows
    Private Sub RefreshWindowsList()

        Static first As Boolean = True

        ' Remove 'red' items (previosly deleted)
        For Each it As ListViewItem In Me.lv.Items
            If it.BackColor = Me.DELETED_ITEM_COLOR Then
                it.Remove()
            End If
        Next

        ' Deleted connections
        For Each it As ListViewItem In Me.lv.Items
            Dim exist As Boolean = False
            For Each frm As Form In Application.OpenForms
                If frm.Handle = CType(it.Tag, IntPtr) Then
                    ' Still existing -> update infos
                    it.Text = frm.Text
                    exist = True
                    Exit For
                End If
            Next

            If exist = False Then
                ' Deleted
                it.BackColor = Me.DELETED_ITEM_COLOR
            End If

        Next


        ' Remove 'green' items (previosly deleted)
        For Each it As ListViewItem In Me.lv.Items
            If it.BackColor = Me.NEW_ITEM_COLOR Then
                it.BackColor = Color.White
            End If
        Next


        ' New connections
        For Each frm As Form In Application.OpenForms
            Dim exist As Boolean = False
            For Each itt As ListViewItem In Me.lv.Items
                If CType(itt.Tag, IntPtr) = frm.Handle Then
                    exist = True
                    Exit For
                End If
            Next

            If exist = False Then
                ' Have to create
                Dim nene As New ListViewItem(frm.Text)
                If first = False Then
                    nene.BackColor = Me.NEW_ITEM_COLOR
                End If
                nene.ForeColor = Color.FromArgb(30, 30, 30)
                nene.Tag = frm.Handle

                ' Add icon
                Try
                    Dim sKey As String = "_" & CStr(frm.Handle)
                    Me.imgList.Images.Add(sKey, frm.Icon)
                    nene.ImageKey = sKey
                Catch ex As Exception
                    nene.ImageKey = ""
                End Try

                Me.lv.Items.Add(nene)
            End If

        Next

        first = False
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        For Each it As ListViewItem In Me.lv.SelectedItems
            Dim hWnd As IntPtr = CType(it.Tag, IntPtr)
            If Not (hWnd = IntPtr.Zero) Then
                Call cWindow.ShowWindowForeground(hWnd)
            End If
        Next
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        For Each it As ListViewItem In Me.lv.SelectedItems
            Dim hWnd As Integer = CInt(CType(it.Tag, IntPtr))
            If hWnd > 0 Then
                Call cWindow.CloseWindow(hWnd)
            End If
        Next
    End Sub
End Class