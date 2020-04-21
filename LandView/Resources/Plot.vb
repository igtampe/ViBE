''' <summary>Represents a singular LandView Plot</summary>
Public Class Plot

    Public ID As String
    Public Status As String
    Public Height As Integer
    Public Width As Integer
    Public Area As Integer
    Public Price As String
    Public Owner As String
    Public Comment As String
    Public PricePerBlock As String

    Public Sub New(ID As String, Status As String, Height As Integer, Width As Integer, area As Integer, price As String, owner As String, PPB As String)
        Me.ID = ID
        Me.Status = Status
        Me.Height = Height
        Me.Width = Width
        Me.Area = area
        Me.Price = price
        Me.Owner = owner
        PricePerBlock = PPB
    End Sub


End Class
