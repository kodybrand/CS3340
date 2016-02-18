Imports UWPCS3340

Public Class FormClassBranch : Inherits FormClassHouse

    Private _branchNo As Integer

    Public WriteOnly Property BranchNo As Integer
        Set(value As Integer)
            _branchNo = value
            Me.Text = "Branch #" & _branchNo
        End Set
    End Property

    Protected Sub FormClassBranch_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Branch #" & _branchNo
        Me.btnExit.text = "Unload"
    End Sub


    Protected Overrides Sub btnModify_Click(sender As Object, e As EventArgs)
        Try
            errRooms.Clear()
            ErrGarages.Clear()
            _currHouse.Modify(getRooms, getGarages)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            If ex.Message.Contains("Room") Then
                errRooms.SetError(gbRooms, ex.Message)
            ElseIf ex.Message.Contains("Garage") Then
                errGarages.SetError(gbGarages, ex.Message)
            End If
        End Try
    End Sub

End Class