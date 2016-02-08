Imports UWPCS3340

Public Class FormClassHouse

    Private _frmList As FormClassList
    Private editingMode As Boolean = False
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

    Private Sub FormClassHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class