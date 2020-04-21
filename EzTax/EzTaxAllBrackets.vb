''' <summary>Displays all tax brackets stored in a certain tax calculator</summary>
Public Class EzTaxAllBrackets

    Public Sub New(Calc As TaxCalc)
        InitializeComponent()
        MainTXB.Text = Calc.ToString
    End Sub

    Private Sub OKBTN_Click(sender As Object, e As EventArgs) Handles OKBTN.Click
        Close()
    End Sub

    Public WindowIsmoving As Boolean
    Public DX As Integer
    Public DY As Integer

    Public Sub TimeToMove() Handles EzTaxTopLabel.MouseDown
        WindowIsmoving = True
        DX = Location.X - MousePosition.X
        DY = Location.Y - MousePosition.Y
    End Sub

    Private Sub ImMoving(sender As Object, e As MouseEventArgs) Handles EzTaxTopLabel.MouseMove
        If WindowIsmoving Then
            SetDesktopLocation(DX + MousePosition.X, DY + MousePosition.Y)
        End If
    End Sub

    Public Sub OktimeToStop() Handles EzTaxTopLabel.MouseUp
        WindowIsmoving = False
    End Sub

End Class