'----------------------------------------------
' Name: Kody Brand
' Date: 2/05/2016
' Description: Program2
'              Class FormClassList
'       Holds all the methods and functions for the List Form.
'----------------------------------------------
Imports UWPCS3340

Public Class FormClassList

    Private _mainForm As FormClassHouse

    Public WriteOnly Property MainForm As FormClassHouse
        Set(ByVal value As FormClassHouse)
            _mainForm = value
        End Set
    End Property

    'Shows form and hides this one
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
        _mainForm.Show()
        _mainForm.BringToFront()
    End Sub

    'Sends selected object to other form
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If lstHouses.SelectedIndex = -1 Then
            MessageBox.Show("No house selected!")
        Else
            _mainForm.displaySelectedHouse(lstHouses.SelectedIndex)
        End If
    End Sub

    'Sets up when loaded
    Private Sub FormClassList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtHouseCount.Text = House.TotalCount
        populateList()
    End Sub

    'Populates the list
    Private Sub populateList()
        Dim tmphouse As House
        Dim tmpList As List(Of String) = New List(Of String)
        lstHouses.Items.Clear()
        For i = 0 To House.TotalCount - 1
            tmphouse = House.HouseByIndex(i)
            lstHouses.Items.Add(tmphouse.ToString)
        Next
    End Sub

End Class