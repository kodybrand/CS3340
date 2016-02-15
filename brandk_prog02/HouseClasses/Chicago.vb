'----------------------------------------------
' Name: Kody Brand
' Date: 2/05/2016
' Description: Program2
'              Class Chicago
'       Object class for Chicago
'----------------------------------------------
Public Class Chicago : Inherits House

    ' Constructor
    Public Sub New(ByVal aID As String)
        MyBase.New(aID)
        Me._TYPE = "Chicago"
        Me._MAX_ROOMS = 4
        Me._MIN_ROOMS = 3
        Me._MAX_GARAGES = 3
        Me._MIN_GARAGES = 2
        Me._BASE_PRICE = 400000
        Me._EXTRA_ROOM = 20000
        Me._EXTRA_GARAGE = 8000
        Me._rooms = Me._MIN_ROOMS
        Me._garages = Me._MIN_GARAGES
        Me._price = Me._BASE_PRICE
    End Sub

    ' Overided setPrice
    Protected Overrides Sub setPrice()
        Dim tmp As Integer = Me._price
        Me._price = Me._BASE_PRICE + ((Me._rooms - Me._MIN_ROOMS) * Me._EXTRA_ROOM) + ((Me._garages - Me._MIN_GARAGES) * Me._EXTRA_GARAGE)
        If (Me._rooms = 3 And Me._garages = 3) Then
            Me._price = Me._price + 2000
        End If
        If tmp <> Me._price Then
            RaisePriceChangedEvent()
        End If
    End Sub

End Class
