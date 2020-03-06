Public Class TaxCalc


    Public Structure TaxInformation
        Public Federal As TaxCalcResult
        Public Newpond As TaxCalcResult
        Public Urbia As TaxCalcResult
        Public Paradisus As TaxCalcResult
        Public Laertes As TaxCalcResult
        Public NorthOsten As TaxCalcResult
        Public SouthOsten As TaxCalcResult

        Public FederalIncome As Long
        Public NewpondIncome As Long
        Public UrbiaIncome As Long
        Public ParadisusIncome As Long
        Public LaertesIncome As Long
        Public NorthOstenIncome As Long
        Public SouthOstenIncome As Long
        Public ExtraIncome As Long

        Public TotalTax As Long

        ''' <summary>
        ''' Creates and calculates tax information based on income
        ''' </summary>
        Public Sub New(ExtraIncome As Long, NewpondIncome As Long, UrbiaIncome As Long, ParadisusIncome As Long, LaertesIncome As Long, NorthOstenIncome As Long, SouthOstenIncome As Long, Category As Integer)

            Me.NewpondIncome = NewpondIncome
            Me.UrbiaIncome = UrbiaIncome
            Me.ParadisusIncome = ParadisusIncome
            Me.LaertesIncome = LaertesIncome
            Me.NorthOstenIncome = NorthOstenIncome
            Me.SouthOstenIncome = SouthOstenIncome
            Me.ExtraIncome = ExtraIncome

            FederalIncome = ExtraIncome + NewpondIncome + UrbiaIncome + ParadisusIncome + LaertesIncome + NorthOstenIncome + SouthOstenIncome
            Dim Corporate As Boolean = False
            If Category = 1 Then Corporate = True
            Federal = CalculateTax(FederalIncome, AllDistricts.Federal, Corporate)
            Newpond = CalculateTax(NewpondIncome, AllDistricts.Newpond, Corporate)
            Urbia = CalculateTax(UrbiaIncome, AllDistricts.Urbia, Corporate)
            Paradisus = CalculateTax(ParadisusIncome, AllDistricts.Paradisus, Corporate)
            Laertes = CalculateTax(LaertesIncome, AllDistricts.Laertes, Corporate)
            NorthOsten = CalculateTax(NorthOstenIncome, AllDistricts.NorthOsten, Corporate)
            SouthOsten = CalculateTax(SouthOstenIncome, AllDistricts.SouthOsten, Corporate)
            TotalTax = Federal.MoneyOwed + Newpond.MoneyOwed + Urbia.MoneyOwed + Paradisus.MoneyOwed + Laertes.MoneyOwed + NorthOsten.MoneyOwed + SouthOsten.MoneyOwed

        End Sub
    End Structure

    Public Structure TaxBracket
        ''' <summary>
        ''' Percent taken at this tax bracket
        ''' </summary>
        Public Percent As Single

        ''' <summary>
        ''' Name of the Bracket
        ''' </summary>
        Public Name As String

        ''' <summary>
        ''' Upper limit of the Bracket
        ''' </summary>
        Public UpperLimit As Long

        ''' <summary>
        ''' Lower Limit of the bracket
        ''' </summary>
        Public LowerLimit As Long

        ''' <summary>
        ''' Creates a new Tax Bracket.
        ''' </summary>
        ''' <param name="N">Name of the Bracket</param>
        ''' <param name="P">Percent of the Bracket</param>
        ''' <param name="UL">Upper Limit of the Bracket</param>
        ''' <param name="LL">Lower Limit of the Bracket</param>
        Public Sub New(N As String, P As Single, UL As Long, LL As Long)
            Percent = P
            Name = N
            UpperLimit = UL
            LowerLimit = LL
        End Sub
    End Structure

    ''' <summary>
    ''' A result from a tax calculation which includes the Tax Bracket and the Money owed 
    ''' </summary>
    Public Structure TaxCalcResult
        ''' <summary>
        ''' Bracket of the tax result
        ''' </summary>
        Public Bracket As TaxBracket
        Public MoneyOwed As Long
        Public Sub New(ReturnBracket As TaxBracket, TaxAmount As Long)
            Bracket = ReturnBracket
            MoneyOwed = TaxAmount
        End Sub
    End Structure

    Public Enum AllDistricts As Integer
        Federal = 0
        Newpond = 1
        Urbia = 2
        Paradisus = 3
        Laertes = 4
        NorthOsten = 5
        SouthOsten = 6
    End Enum

    Public Structure District
        Public AllBrackets() As TaxBracket


        ''' <summary>
        ''' Makes a new district
        ''' </summary>
        ''' <param name="DistrictBrakcets">
        ''' An array of all the district brackets in string form. The format is:
        ''' NAME,PERCENT (As Decimal), LOWER LIMIT, TOP LIMIT
        ''' 
        ''' You can leave the top limit blank to treat it as infinity, BUT PLS LEAVE THE COMMA
        ''' </param>
        Public Sub New(DistrictBrakcets As String())
            Dim CurrentBracket() As String
            For Each NewBracket As String In DistrictBrakcets
                CurrentBracket = NewBracket.Split(",")
                Dim toplimit As Long
                If String.IsNullOrEmpty(CurrentBracket(3).Trim) Then toplimit = 2 ^ 62 Else toplimit = CurrentBracket(3).Trim

                'This isn't the max a long value can hold but if someone makes more than 4 Quintillion they deserve the money.

                AddBracket(CurrentBracket(0).Trim, CurrentBracket(1).Trim, toplimit, CurrentBracket(2).Trim)
            Next
        End Sub

        Private Sub AddBracket(N As String, P As Single, UL As Long, LL As Long)
            If IsNothing(AllBrackets) Then
                ReDim AllBrackets(0)
                AllBrackets(0) = New TaxBracket(N, P, UL, LL)
            Else
                ReDim Preserve AllBrackets(AllBrackets.Count)
                AllBrackets(AllBrackets.Count - 1) = New TaxBracket(N, P, UL, LL)
            End If
        End Sub
    End Structure

    Public Shared Federal As District = New District({
    "Personal Taxed  ,0.05,5000000,       ",
    "Personal Untaxed,0.00,      0,5000000"})

    Public Shared FederalCorporate As District = New District({
    "Corporate Taxed  ,0.02,500000000,       ",
    "Corporate Untaxed,0.00,      0,500000000"})

    Public Shared Newpond As District = New District({
    "Newpond Untaxed,0,0,"})

    Public Shared NewpondCorporate As District = New District({
    "Newpond Corporate Untaxed,0,0,"})

    Public Shared Urbia As District = New District({
    "Urbia Untaxed,0,0,"})

    Public Shared UrbiaCorporate As District = New District({
    "Urbia Corporate Untaxed,0,0,"})

    Public Shared Paradisus As District = New District({
    "Paradisus Untaxed,0,0,"})

    Public Shared ParadisusCorporate As District = New District({
    "Paradisus Corporate Untaxed,0,0,"})

    Public Shared Laertes As District = New District({
    "Laertes Untaxed,0,0,"})

    Public Shared LaertesCorporate As District = New District({
    "Laertes Corporate Untaxed,0,0,"})

    Public Shared NOsten As District = New District({
    "North Osten Untaxed,0,0,"})

    Public Shared NOstenCorporate As District = New District({
    "North Osten Corporate Untaxed,0,0,"})

    Public Shared SOsten As District = New District({
    "South Osten Untaxed,0,0,"})

    Public Shared SOstenCorporate As District = New District({
    "South Osten Corporate Untaxed,0,0,"})


    Public Shared Function CalculateTax(Money As Long, District As AllDistricts, Corporate As Boolean) As TaxCalcResult
        If Money = 0 Then
            Return New TaxCalcResult(New TaxBracket("N/A", 0, 0, 0), 0)
        End If
        Try
            Dim CurrentDistrict As District = EnumToDistrict(District, Corporate)
            For Each Bracket As TaxBracket In CurrentDistrict.AllBrackets
                If Money >= Bracket.LowerLimit And Money < Bracket.UpperLimit Then
                    Return New TaxCalcResult(Bracket, Money * Bracket.Percent)
                End If
            Next
        Catch ex As Exception
        End Try
        Return New TaxCalcResult(New TaxBracket("Unknown", 0, 0, 0), 0)
    End Function

    Private Shared Function EnumToDistrict(District As AllDistricts, Corporate As Boolean) As District
        Select Case District
            Case AllDistricts.Federal
                If Corporate Then Return FederalCorporate Else Return Federal
            Case AllDistricts.Newpond
                If Corporate Then Return NewpondCorporate Else Return NewpondCorporate
            Case AllDistricts.Urbia
                If Corporate Then Return UrbiaCorporate Else Return Urbia
            Case AllDistricts.Paradisus
                If Corporate Then Return ParadisusCorporate Else Return Paradisus
            Case AllDistricts.Laertes
                If Corporate Then Return LaertesCorporate Else Return Laertes
            Case AllDistricts.NorthOsten
                If Corporate Then Return NOstenCorporate Else Return NOsten
            Case AllDistricts.SouthOsten
                If Corporate Then Return SOstenCorporate Else Return SOsten
            Case Else
                Return New District({"UnknownDistrict,0,0,"})
        End Select

    End Function

End Class
