﻿Public Class FormClassShow

    Private Const MAX_BUTTON_COUNT As Integer = 4
    Private xPos As Integer = 100
    ' For event resize
    Private Const BUTTON_HEIGHT As Integer = 23
    Private Const BUTTON_WIDTH As Integer = 75
    Private Const MENU_HEIGHT As Integer = 24
    Private Const MARGIN_SIZE As Integer = 100
    Private _frmCreate As FormClassCreate

    Private _allButtons As New SortedList

    ' Private method
    Friend Sub addButton(ByVal theCaption As String, ByVal theKey As String)
        Dim aButton As Button
        ' Don't use Dim here!
        Static count As Integer

        ' Gets a new button object
        aButton = New Button

        count += 1

        ' Sets the button properties
        aButton.Text = theCaption
        'aButton.Tag = theKey
        aButton.Location = New System.Drawing.Point(MARGIN_SIZE, 250)
        xPos += 100

        aButton.Name = "Button " & count
        aButton.Tag = "Tag " & count

        ' Set the event handler for the object pointed by aButton
        ' Even the object is not pointed by aButton later
        AddHandler aButton.Click, AddressOf ButtonClick

        ' Puts the button on the form
        Me.Controls.Add(aButton)

        ' Adds the button to the sorted list

        _allButtons.Add(theKey, aButton)

    End Sub

    Friend Sub removeButton(ByVal theKey As String)
        Dim index As Integer
        index = _allButtons.IndexOfKey(theKey)

        If index = -1 Then
            ' not in the sorted list
        Else
            Dim aButton As Button

            aButton = _allButtons.GetByIndex(index)
            Me.Controls.Remove(aButton)
            _allButtons.RemoveAt(index)
        End If

    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) 'Handles aButton.Click
        Dim b As Button
        b = sender

        MessageBox.Show(b.Name & Chr(Keys.LineFeed) & b.Tag)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Hide()
        _frmCreate.Show()
    End Sub
End Class