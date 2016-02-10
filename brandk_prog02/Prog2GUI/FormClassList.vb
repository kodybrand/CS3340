Imports UWPCS3340

Public Class FormClassList

    Private _mainForm As FormClassHouse

    Public WriteOnly Property MainForm As FormClassHouse
        Set(ByVal value As FormClassHouse)
            _mainForm = value
        End Set
    End Property

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
        _mainForm.Show()
        _mainForm.BringToFront()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If lstHouses.SelectedIndex = -1 Then
            MessageBox.Show("No house selected!")
        Else
            _mainForm.displaySelectedHouse(lstHouses.SelectedIndex)
        End If
    End Sub

    Private Sub FormClassList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtHouseCount.Text = House.TotalCount
        populateList()
    End Sub

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