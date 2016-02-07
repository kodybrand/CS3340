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
            'Clicking btnDisplay will hide the form, show _mainForm with the data 
            'of the selected house, and _mainForm will be ready
            'for user to modify the selected house.
            Me.Hide()
            _mainForm.Show()
            _mainForm.BringToFront()
        End If
    End Sub

    Private Sub FormClassList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtHouseCount.Text = House.TotalCount
    End Sub

    Private Sub FormClassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bs As New BindingSource
        'bs.DataSource = House.
    End Sub
End Class