﻿Imports UWPCS3340

Public Class FormClassHouse

    Private _frmList As FormClassList
    Private editingMode As Boolean = False
    Private WithEvents _currHouse As House
    Private h As House

    Private Const CURRENCY As String = "{0:c0}"

    Public Sub New()
        InitializeComponent()

        _frmList = New FormClassList
        _frmList.MainForm = Me
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Me.Hide()
        _frmList.Show()
        _frmList.BringToFront()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not editingMode Then
            Try
                Dim theID As String = txtID.Text.Trim
                If (cboType.SelectedItem = "Platteville") Then
                    h = New Platteville(theID)
                ElseIf (cboType.SelectedItem = "Chicago") Then
                    h = New Chicago(theID)
                ElseIf (cboType.SelectedItem = "Madison") Then
                    h = New Madison(theID)
                Else
                    Throw New Exception("Select a city!")
                End If
                EditMode()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            StopEdit()
        End If
    End Sub

    Private Sub EditMode()
        editingMode = True
        btnSave.Text = "New"
        btnModify.Enabled = True
        cboType.Enabled = False
        txtID.Enabled = False
        gbRooms.Enabled = True
        gbGarages.Enabled = True
    End Sub

    Private Sub StopEdit()
        editingMode = False
        btnSave.Text = "Save"
        btnModify.Enabled = False
        cboType.SelectedItem = -1
        cboType.ResetText()
        txtID.Clear()
        cboType.Enabled = True
        txtID.Enabled = True
        gbRooms.Enabled = False
        gbGarages.Enabled = False
    End Sub


    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        txtPrice.Text = FormatCurrency(txtPrice)
    End Sub

    'handles price change event, updates price field, displays message
    Private Sub updatePrice() Handles _currHouse.PriceChanged
        _currHouse = getHouseFromID()
        txtPrice.Text = String.Format(CURRENCY, _currHouse.Price)
        MessageBox.Show("Price has been changed!!")
    End Sub

    Private Function getHouseFromID() As House
        Dim idList As List(Of String) = New List(Of String)
        For i = 0 To House.TotalCount - 1
            idList.Add(House.HouseByIndex(i).ID)
        Next
        Return House.HouseByIndex(idList.IndexOf(txtID.Text.Trim))

    End Function

    Public Sub displaySelectedHouse(ByVal index As Integer)
        _currHouse = House.HouseByIndex(index)
        txtID.Text = _currHouse.ID
        txtPrice.Text = String.Format(CURRENCY, _currHouse.Price)
        cboType.SelectedIndex = cboType.Items.IndexOf(_currHouse.Type)
        cboType.Enabled = False
        showNumGarages(_currHouse)
        showNumRooms(_currHouse)
    End Sub

    'selects proper radio button for number of rooms in house
    Private Sub showNumRooms(ByVal tmpHouse As House)
        If tmpHouse.Rooms = Integer.Parse(rbRooms4.Text) Then
            rbRooms4.Select()
        ElseIf tmpHouse.Rooms = Integer.Parse(rbRooms3.Text) Then
            rbRooms3.Select()
        Else
            rbRooms2.Select()
        End If
    End Sub

    'selects proper radio button for number of garages in house
    Private Sub showNumGarages(ByVal tmpHouse As House)
        If tmpHouse.Garages = Integer.Parse(rbGarages3.Text) Then
            rbGarages3.Select()
        ElseIf tmpHouse.Garages = Integer.Parse(rbGarages2.Text) Then
            rbGarages2.Select()
        Else
            rbGarages1.Select()
        End If
    End Sub
End Class