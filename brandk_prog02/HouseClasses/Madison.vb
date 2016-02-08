Public Class Madison
    Inherits House

    Public Sub New(ByVal aID As String)
        MyBase.New(aID)
        _type = "Madison"
        _maxRooms = 4
        _minRooms = 2
        _maxGarage = 3
        _minGarage = 1
        _basePrice = 300000
        _extraRoomPrice = 10000
        _extraGaragePrice = 5000
        _rooms = _minRooms
        _garages = _minGarage
        _price = _basePrice
    End Sub



End Class
