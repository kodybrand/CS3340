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
    Private WithEvents _currHouse As House

    Private Const CURRENCY As String = "{0:c0}"

    Public WriteOnly Property MainForm As FormClassHouse
        Set(ByVal value As FormClassHouse)
            _mainForm = value
        End Set
    End Property

    ' Sets up form when activated
    Private Sub FormClassList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        HandleListUpdatedEvent()
    End Sub

    ' Hides the form and displays main form
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
        _mainForm.Show()
        _mainForm.BringToFront()
    End Sub

    ' Sends the selected house to the main form
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If lstHouses.SelectedIndex = -1 Then
            MessageBox.Show("Select a house from the list!")
        Else
            _mainForm.displayHouse(House.HouseByIndex(lstHouses.SelectedIndex))
            Me.Hide()
            _mainForm.Show()
            _mainForm.BringToFront()
        End If
    End Sub

    Private Sub HandleListUpdatedEvent() Handles _currHouse.HouseListUpdatedEvent
        Dim totalCount As Integer = House.TotalCount
        Dim num1 As Integer = 0
        Dim num2 As Integer = House.TotalCount - 1
        Dim index As Integer = num1
        Dim h As House
        txtHouseCount.Text = totalCount
        lstHouses.Items.Clear()
        While index <= num2
            h = House.HouseByIndex(index)
            lstHouses.Items.Add(h.ID.PadRight(8) + h.Type.PadLeft(12) + String.Format(CURRENCY, h.Price).PadLeft(13))
            index = index + 1
        End While
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            ErrorProvider1.Clear()

            CType(House.HouseByIndex(lstHouses.SelectedIndex), IDisposable).Dispose()
            _currHouse = Nothing


        Catch ex As Exception
            ErrorProvider1.SetError(btnRemove, ex.Message)
        End Try

        

    End Sub
End Class