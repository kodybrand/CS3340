'----------------------------------------------
' Name: Kody Brand
' Date: 02/18/2016
' Description: FormClassBranch
'              Handles the branches of the program

'----------------------------------------------
Imports UWPCS3340

Public Class FormClassBranch : Inherits FormClassHouse

    Private _branchNo As Integer

    Public WriteOnly Property BranchNo As Integer
        Set(value As Integer)
            _branchNo = value
            Me.Text = "Branch #" & _branchNo
        End Set
    End Property

    ' Loading of the form
    Protected Sub FormClassBranch_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Branch #" & _branchNo
        Me.btnExit.text = "Unload"
    End Sub

    ' Modify button actions
    Protected Overrides Sub btnModify_Click(sender As Object, e As EventArgs)
        ErrorProvider1.Clear()

        Try
            _currHouse.Modify(getRooms, getGarages)
        Catch ex As Exception
            If ex.Message.Contains("room") Then
                ErrorProvider1.SetError(gbRooms, ex.Message)
            End If
            If ex.Message.Contains("garage") Then
                ErrorProvider1.SetError(gbGarages, ex.Message)
            End If
        End Try
    End Sub

End Class