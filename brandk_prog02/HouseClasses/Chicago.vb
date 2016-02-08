Public Class Chicago
    Inherits House

    Public Sub New(ByVal aID As String)
        MyBase.New(aID)
        _type = "Chicago"
        _maxRooms = 4
        _minRooms = 3
        _maxGarage = 3
        _minGarage = 2
        _basePrice = 400000
        _extraRoomPrice = 20000
        _extraGaragePrice = 8000
        _rooms = _minRooms
        _garages = _minGarage
        _price = _basePrice
    End Sub

End Class
