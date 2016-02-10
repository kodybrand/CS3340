'----------------------------------------------
' Name: Kody Brand
' Date: 2/05/2016
' Description: Program2
'              Class Madison
'       Object class for Madison
'----------------------------------------------
Public Class Madison
    Inherits House

    Private Const HOUSE_TYPE As String = "Madison"
    Private Const MAX_ROOMS As Integer = 4
    Private Const MIN_ROOMS As Integer = 2
    Private Const MAX_GARAGE As Integer = 2
    Private Const MIN_GARAGE As Integer = 1
    Private Const BASE_PRICE As Integer = 300000
    Private Const EXTRA_ROOM As Integer = 10000
    Private Const EXTRA_GARAGE As Integer = 5000

    'Constructor
    Public Sub New(ByVal aID As String)
        MyBase.New(aID, HOUSE_TYPE, EXTRA_ROOM, MIN_ROOMS, MAX_ROOMS, _
                   EXTRA_GARAGE, MIN_GARAGE, MAX_GARAGE, BASE_PRICE)
    End Sub

End Class
