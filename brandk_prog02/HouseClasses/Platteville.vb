Public Class Platteville
    Inherits House

    Public Sub New(ByVal aID As String)
        MyBase.New(aID)
        _type = "Platteville"
        _maxRooms = 3
        _minRooms = 2
        _maxGarage = 2
        _minGarage = 1
        _basePrice = 200000
        _extraRoomPrice = 8000
        _extraGaragePrice = 2500
        _rooms = _minRooms
        _garages = _minGarage
        _price = _basePrice
    End Sub

End Class
