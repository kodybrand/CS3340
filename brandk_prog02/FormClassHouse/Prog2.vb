'----------------------------------------------
' Name: Kody Brand
' Date: 2/05/2016
' Description: Program2
'              Class Prog2
'       Starts up the forms
'----------------------------------------------
Public Class Prog2
    Public _frmList As FormClassList
    Public _frmHouse As FormClassHouse

    ' starts the program up.
    Public Shared Sub main()
        Application.Run(New FormClassHouse)
    End Sub
End Class
