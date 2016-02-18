'----------------------------------------------
' Name: Kody Brand
' Date: 2/05/2016
' Description: Program3
'              Class FormClassHouse
'       Holds all the methods and functions for the House Form.
'----------------------------------------------

Imports UWPCS3340

Public Class FormClassHouse

    Protected _frmList As FormClassList
    Protected WithEvents _currHouse As House

    'form with list of houses
    Protected _listForm As FormClassList

    Private Const CURRENCY As String = "{0:c0}"

    Public Sub New()
        InitializeComponent()

        _frmList = New FormClassList
        _frmList.MainForm = Me
    End Sub

    'allows setting of _listForm
    Public WriteOnly Property ListForm As FormClassList
        Set(value As FormClassList)
            _listForm = value
        End Set
    End Property

    ' Handles the changed price event
    Private Sub PriceChanged() Handles _currHouse.PriceChanged
        MessageBox.Show("Price Changed!")
        txtPrice.Text = String.Format(CURRENCY, _currHouse.Price)
    End Sub

    ' Closes the application
    Public Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' Changes for to the list form
    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Me.Hide()
        _frmList.Show()
        _frmList.BringToFront()

    End Sub

    ' Sets the form up when loaded
    Private Sub FormClassHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboType.SelectedIndex = -1
        btnModify.Enabled = False
        gbRooms.Enabled = False
        gbGarages.Enabled = False

    End Sub

    ' handles the creating and saving click
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "Save" Then
            If cboType.SelectedIndex = -1 Then
                MessageBox.Show("Select a house type")
            Else
                Try
                    If cboType.SelectedIndex = 0 Then
                        _currHouse = New Chicago(txtID.Text.Trim)
                    ElseIf cboType.SelectedIndex = 1 Then
                        _currHouse = New Madison(txtID.Text.Trim)
                    ElseIf cboType.SelectedIndex = 2 Then
                        _currHouse = New Platteville(txtID.Text.Trim)
                    End If
                    setControls()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Else
            reset()
        End If

    End Sub

    ' sets the groupbox info for rooms
    Protected Sub setRooms(h As House)
        If h.Rooms = 2 Then
            rbR2.Checked = True
        ElseIf h.Rooms = 3 Then
            rbR3.Checked = True
        ElseIf h.Rooms = 4 Then
            rbR4.Checked = True
        End If
    End Sub

    ' sets the groupbox info for garages
    Protected Sub setGarages(h As House)
        If h.Garages = 1 Then
            rbG1.Checked = True
        ElseIf h.Garages = 2 Then
            rbG2.Checked = True
        ElseIf h.Garages = 3 Then
            rbG3.Checked = True
        End If
    End Sub

    ' gets selected room
    Protected Function getRooms() As Integer
        If rbR2.Checked = True Then
            Return 2
        ElseIf rbR3.Checked = True Then
            Return 3
        ElseIf rbR4.Checked = True Then
            Return 4
        Else
            Return -1
        End If
    End Function


    ' gets selected garage
    Protected Function getGarages() As Integer
        If rbG1.Checked = True Then
            Return 1
        ElseIf rbG2.Checked = True Then
            Return 2
        ElseIf rbG3.Checked = True Then
            Return 3
        Else
            Return -1
        End If
    End Function

    ' handles the modifying button
    Protected Overridable Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        ErrorProvider1.Clear()
        Try
            _currHouse.Modify(getRooms(), getGarages())
        Catch ex As Exception
            ErrorProvider1.SetError(btnModify, ex.Message)
        End Try
    End Sub

    ' sets the form to display the correct house info
    Public Sub displayHouse(h As House)
        _currHouse = h
        txtID.Text = h.ID
        If h.Type = "Chicago" Then
            cboType.SelectedIndex = 0
        ElseIf h.Type = "Madison" Then
            cboType.SelectedIndex = 1
        ElseIf h.Type = "Platteville" Then
            cboType.SelectedIndex = 2
        End If
        setControls()
    End Sub

    ' manages the form controls
    Private Sub setControls()
        setRooms(_currHouse)
        setGarages(_currHouse)
        txtPrice.Text = String.Format(CURRENCY, _currHouse.Price)
        cboType.Enabled = False
        txtID.ReadOnly = True
        btnSave.Text = "New"
        btnModify.Enabled = True
        gbGarages.Enabled = True
        gbRooms.Enabled = True
    End Sub

    Private Sub reset()
        txtID.ReadOnly = False
        txtID.Clear()
        cboType.SelectedIndex = -1
        cboType.Enabled = True
        txtPrice.Clear()
        btnSave.Text = "Save"
        btnModify.Enabled = False
        gbRooms.Enabled = False
        gbGarages.Enabled = False
        cboType.Focus()
    End Sub

    Private Sub HandleListUpdateEvent() 'Handles _currHouse.HouseListUpdated
        Dim left As String = txtID.Text.Trim
        Dim text As String = txtPrice.Text.Trim
        Dim num1 As Integer = 0
        Dim num2 As Integer = House.TotalCount - 1
        Dim index As Integer = num1
        Dim h As House
        While index <= num2
            h = House.HouseByIndex(index)
            If Not left = h.ID Then
                _currHouse = h
                If Not String.Format(CURRENCY, h.Price) = text Then
                    MessageBox.Show("Price Changed!")
                End If
                displayHouse(_currHouse)
                Return
            End If
        End While
        reset()
    End Sub
End Class