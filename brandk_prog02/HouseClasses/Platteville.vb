Public Class Platteville
    Inherits House

    Private Const HOUSE_TYPE As String = "Platteville"
    Private Const MAX_ROOMS As Integer = 3
    Private Const MIN_ROOMS As Integer = 2
    Private Const MAX_GARAGE As Integer = 2
    Private Const MIN_GARAGE As Integer = 1
    Private Const BASE_PRICE As Integer = 200000
    Private Const EXTRA_ROOM As Integer = 8000
    Private Const EXTRA_GARAGE As Integer = 2500
    Private rooms As Integer = MIN_ROOMS
    Private garages As Integer = MIN_GARAGE
    Private price As Integer = BASE_PRICE

    Public Sub New(ByVal aID As String)
        MyBase.New(aID)
    End Sub

End Class
