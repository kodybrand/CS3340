Public Class Chicago
    Inherits House

    Private Const HOUSE_TYPE As String = "Chicago"
    Private Const MAX_ROOMS As Integer = 4
    Private Const MIN_ROOMS As Integer = 3
    Private Const MAX_GARAGE As Integer = 3
    Private Const MIN_GARAGE As Integer = 2
    Private Const BASE_PRICE As Integer = 400000
    Private Const EXTRA_ROOM As Integer = 20000
    Private Const EXTRA_GARAGE As Integer = 8000

    Public Sub New(ByVal aID As String)
        MyBase.New(aID, HOUSE_TYPE, EXTRA_ROOM, MIN_ROOMS, MAX_ROOMS, _
                   EXTRA_GARAGE, MIN_GARAGE, MAX_GARAGE, BASE_PRICE)
    End Sub

    Public Overrides Sub setPrice()
        Dim tmp As Single = _price
        If (_rooms = MAX_ROOMS And _garages = MAX_GARAGE) Then
            _price = BASE_PRICE + EXTRA_ROOM + EXTRA_GARAGE
        ElseIf (_rooms = MAX_ROOMS And _garages = MIN_GARAGE) Then
            _price = BASE_PRICE + EXTRA_ROOM
        ElseIf (_rooms = MIN_ROOMS + MAX_GARAGE) Then
            _price = BASE_PRICE + 10000
        Else
            _price = BASE_PRICE
        End If

        RaisePriceChangedEvent()


    End Sub


End Class
