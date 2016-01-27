'----------------------------------------------
' Name: Kody Brand
' Date: 1/27/2016
' Description: Program1
'              Class Prog1. Handles the starting of the program. 
'----------------------------------------------

Public Class Prog1

    Public _frmShow As FormClassShow
    Public _frmCreate As FormClassCreate

    Public Shared Sub main()
        Application.Run(New FormClassCreate)
    End Sub
End Class