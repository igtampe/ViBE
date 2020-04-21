''' <summary>Represents a single LandView Region</summary>
Public Class Region

    'The only reason this isn't a structure is because we need TryCast

    Public Plots As ArrayList
    Public Name As String
    Public Prefix As String
    Public Picture As Image

    Public Sub New(Name As String, Prefix As String, picture As Image)
        Me.Name = Name
        Me.Prefix = Prefix
        Me.Picture = picture

        Plots = New ArrayList
    End Sub



End Class
