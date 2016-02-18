'----------------------------------------------
' Name: Kody Brand
' Date: 2/05/2016
' Description: Program2
'              Class Madison
'       Object class for Madison
'----------------------------------------------
Public Class Madison : Inherits House

    ' Constructor 
    Public Sub New(ByVal aID As String)
        MyBase.New(aID)
        Me._TYPE = "Madison"
        Me._MAX_ROOMS = 4
        Me._MIN_ROOMS = 2
        Me._MAX_GARAGES = 3
        Me._MIN_GARAGES = 1
        Me._BASE_PRICE = 300000
        Me._EXTRA_ROOM = 10000
        Me._EXTRA_GARAGE = 5000
        Me._rooms = Me._MIN_ROOMS
        Me._garages = Me._MIN_GARAGES
        Me._price = Me._BASE_PRICE

    End Sub

End Class
