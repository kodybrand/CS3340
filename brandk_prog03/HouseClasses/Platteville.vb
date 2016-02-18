'----------------------------------------------
' Name: Kody Brand
' Date: 2/05/2016
' Description: Program2
'              Class Platteville
'       Object class for Platteville
'----------------------------------------------
Public Class Platteville : Inherits House

    ' Constructor
    Public Sub New(ByVal aID As String)
        MyBase.New(aID)
        Me._TYPE = "Platteville"
        Me._MAX_ROOMS = 3
        Me._MIN_ROOMS = 2
        Me._MAX_GARAGES = 2
        Me._MIN_GARAGES = 1
        Me._BASE_PRICE = 200000
        Me._EXTRA_ROOM = 8000
        Me._EXTRA_GARAGE = 2500
        Me._rooms = Me._MIN_ROOMS
        Me._garages = Me._MIN_GARAGES
        Me._price = Me._BASE_PRICE

    End Sub

End Class
