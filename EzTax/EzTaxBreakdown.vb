Imports VIBE__But_on_Visual_Studio_.EZTaxMain
Imports VIBE__But_on_Visual_Studio_.TaxCalc
Public Class EzTaxBreakdown
    Public ItemCompleteDetails As String = ""
    Public ServerInformation As TaxInformation
    Public LocalInformation As TaxInformation

    Private Sub OKBTN_Click(sender As Object, e As EventArgs) Handles OKBTN.Click
        Close()
    End Sub

    Private Sub EzTaxDetails_Load(sender As Object, e As EventArgs) Handles Me.Shown
        LocalTaxLBL.Text = LocalInformation.TotalTax.ToString("N0") & "p"
        ServerTaxLBL.Text = ServerInformation.TotalTax.ToString("N0") & "p"

        LocalDetailsTXB.Text = PrepareDetailsTextbox(LocalInformation)
        ServerDetailsTXB.Text = PrepareDetailsTextbox(ServerInformation)

    End Sub

    Private Function PrepareDetailsTextbox(TT As TaxInformation) As String
        Return String.Join(vbNewLine & vbNewLine, {"-{TAX REPORT}-----------------------------",
                           PrepareSection("FEDERAL", TT.FederalIncome, TT.Federal),
                           PrepareSection("NEWPOND", TT.NewpondIncome, TT.Newpond),
                           PrepareSection("URBIA", TT.UrbiaIncome, TT.Urbia),
                           PrepareSection("PARADISUS", TT.ParadisusIncome, TT.Paradisus),
                           PrepareSection("LAERTES", TT.LaertesIncome, TT.Laertes),
                           PrepareSection("NORTH OSTEN", TT.NorthOstenIncome, TT.NorthOsten),
                           PrepareSection("SOUTH OSTEN", TT.SouthOstenIncome, TT.SouthOsten)
        })
    End Function

    Private Function PrepareSection(SectionName As String, Income As Long, Result As TaxCalcResult) As String
        PrepareSection = ""
        '"-[NORTH OSTEN]----------------------------"
        PrepareSection &= "-[" & SectionName & "]"
        Dim initialsize As Integer = PrepareSection.Count
        For X = initialsize To "-[NORTH OSTEN]---------------------------".Count
            PrepareSection &= "-"
        Next
        PrepareSection &= vbNewLine

        '"     Income: 123,456,789,123,456p
        PrepareSection &= "     Income: " & Income.ToString("N0") & "p" & vbNewLine

        '"
        PrepareSection &= vbNewLine

        '"Tax Bracket: North Osten Corporate Taxed"
        PrepareSection &= "Tax Bracket: " & Result.Bracket.Name & vbNewLine

        '"     Bounds: 500,000,000p to 500,000,000p"
        PrepareSection &= "     Bounds: " & Result.Bracket.LowerLimit.ToString("N0") & "p to "
        If Result.Bracket.UpperLimit = 2 ^ 62 Then PrepareSection &= "INF" Else PrepareSection &= Result.Bracket.UpperLimit.ToString("N0") & "p"
        PrepareSection &= vbNewLine

        '" Percentage: 5%
        PrepareSection &= " Percentage: " & Result.Bracket.Percent * 100 & "%" & vbNewLine

        '"
        PrepareSection &= vbNewLine

        '"   Tax Owed: 123,456,789,123,456p
        PrepareSection &= "   Tax Owed: " & Result.MoneyOwed.ToString("N0") & "p"

    End Function

    ''' <summary>
    ''' This has to do with moving the window
    ''' </summary>
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
            Me.SetDesktopLocation(DX + MousePosition.X, DY + MousePosition.Y)
        End If
    End Sub

    Public Sub OktimeToStop() Handles EzTaxTopLabel.MouseUp
        WindowIsmoving = False
    End Sub

End Class