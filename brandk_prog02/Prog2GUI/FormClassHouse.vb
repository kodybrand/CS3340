Imports UWPCS3340

Public Class FormClassHouse

    Private _frmList As FormClassList
    Private h As House

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
        Try
            Dim theName As String = txtID.Text.Trim
            If (cboType.SelectedText = "Platteville") Then
                h = New Platteville(theName)
            ElseIf (cboType.SelectedText = "Chicago") Then
                h = New Chicago(theName)
            ElseIf (cboType.SelectedText = "Madison") Then
                h = New Madison(theName)
            Else
                Throw New Exception("Unsupported city selected!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        txtPrice.Text = FormatCurrency(txtPrice)
    End Sub

    Private Sub FormClassHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class