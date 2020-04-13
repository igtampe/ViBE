Public Class TaxCalc


    Public TaxInfoID As Integer = 0

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

        ''' <summary> Creates and calculates tax information based on income </summary>
        Public Sub New(ExtraIncome As Long, NewpondIncome As Long, UrbiaIncome As Long, ParadisusIncome As Long, LaertesIncome As Long, NorthOstenIncome As Long, SouthOstenIncome As Long, Category As Integer, Calculator As TaxCalc)

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
            Federal = Calculator.CalculateTax(FederalIncome, AllDistricts.Federal, Corporate)
            Newpond = Calculator.CalculateTax(NewpondIncome, AllDistricts.Newpond, Corporate)
            Urbia = Calculator.CalculateTax(UrbiaIncome, AllDistricts.Urbia, Corporate)
            Paradisus = Calculator.CalculateTax(ParadisusIncome, AllDistricts.Paradisus, Corporate)
            Laertes = Calculator.CalculateTax(LaertesIncome, AllDistricts.Laertes, Corporate)
            NorthOsten = Calculator.CalculateTax(NorthOstenIncome, AllDistricts.NorthOsten, Corporate)
            SouthOsten = Calculator.CalculateTax(SouthOstenIncome, AllDistricts.SouthOsten, Corporate)
            TotalTax = Federal.MoneyOwed + Newpond.MoneyOwed + Urbia.MoneyOwed + Paradisus.MoneyOwed + Laertes.MoneyOwed + NorthOsten.MoneyOwed + SouthOsten.MoneyOwed

        End Sub
    End Structure

    Public Structure TaxBracket
        ''' <summary> Percent taken at this tax bracket</summary>
        Public Percent As Single
        ''' <summary> Name of the Bracket </summary>
        Public Name As String
        ''' <summary> Upper limit of the Bracket</summary>
        Public UpperLimit As Long
        '''<summary> Lower Limit of the bracket </summary>
        Public LowerLimit As Long

        ''' <summary> Creates a new Tax Bracket. </summary>
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
        ''' <summary> Bracket of the tax result </summary>
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
        Public name As String

        Public Sub New(Name As String)
            Me.name = Name
        End Sub

        ''' <summary>
        ''' Adds a new bracket
        ''' </summary>
        ''' <param name="N">Name</param>
        ''' <param name="P">Percent (as decimal)</param>
        ''' <param name="UL">Upper Limit</param>
        ''' <param name="LL">Lower Limit</param>
        Public Sub AddBracket(N As String, P As Single, LL As Long, UL As Long)
            If IsNothing(AllBrackets) Then
                ReDim AllBrackets(0)
                AllBrackets(0) = New TaxBracket(N, P, UL, LL)
            Else
                ReDim Preserve AllBrackets(AllBrackets.Count)
                AllBrackets(AllBrackets.Count - 1) = New TaxBracket(N, P, UL, LL)
            End If
        End Sub

        Public Sub AddBracket(Line As String())
            Dim N As String = Line(0)
            Dim P As String = Line(1)
            Dim LL As Long = Line(2)
            Dim UL As Long
            If String.IsNullOrWhiteSpace(Line(3)) Then UL = 2 ^ 62 Else UL = Line(3)
            AddBracket(N, P, LL, UL)
        End Sub

    End Structure

    Private Federal As District
    Private FederalCorporate As District
    Private Newpond As District
    Private NewpondCorporate As District
    Private Urbia As District
    Private UrbiaCorporate As District
    Private Paradisus As District
    Private ParadisusCorporate As District
    Private Laertes As District
    Private LaertesCorporate As District
    Private NOsten As District
    Private NOstenCorporate As District
    Private SOsten As District
    Private SOstenCorporate As District

    Public Sub New(TaxFile As String)

        FileOpen(1, TaxFile, OpenMode.Input)

        Federal = New District("Federal")
        FederalCorporate = New District("Federal Corporate")
        Newpond = New District("Newpond")
        NewpondCorporate = New District("Newpond Corporate")
        Urbia = New District("Urbia")
        UrbiaCorporate = New District("Urbia Corporate")
        Paradisus = New District("Paradisus")
        ParadisusCorporate = New District("Paradisus Corporate")
        Laertes = New District("Laertes")
        LaertesCorporate = New District("Laertes Corporate")
        NOsten = New District("North Osten")
        NOstenCorporate = New District("North Osten Corporate")
        SOsten = New District("South Osten")
        SOstenCorporate = New District("South Osten Corporate")


        Dim SplitLine As String()
        Dim tempStr As String

        While Not EOF(1)
            tempStr = LineInput(1)

            If tempStr.StartsWith("'") Then
                'It's a comment do nada

            ElseIf String.IsNullOrWhiteSpace(TempStr) Then
                'Empty Line, we can ignore it.
            Else
                'Assume it's algo
                SplitLine = tempStr.Split(":")
                Select Case SplitLine(0).ToUpper
                    Case "FED"
                        Federal.AddBracket(SplitLine(1).Split(","))
                    Case "FCORP"
                        FederalCorporate.AddBracket(SplitLine(1).Split(","))
                    Case "NEW"
                        Newpond.AddBracket(SplitLine(1).Split(","))
                    Case "NCORP"
                        NewpondCorporate.AddBracket(SplitLine(1).Split(","))
                    Case "URB"
                        Urbia.AddBracket(SplitLine(1).Split(","))
                    Case "UCORP"
                        UrbiaCorporate.AddBracket(SplitLine(1).Split(","))
                    Case "PAR"
                        Paradisus.AddBracket(SplitLine(1).Split(","))
                    Case "PCORP"
                        ParadisusCorporate.AddBracket(SplitLine(1).Split(","))
                    Case "LAE"
                        Laertes.AddBracket(SplitLine(1).Split(","))
                    Case "LCORP"
                        LaertesCorporate.AddBracket(SplitLine(1).Split(","))
                    Case "NOSTEN"
                        NOsten.AddBracket(SplitLine(1).Split(","))
                    Case "NOCORP"
                        NOstenCorporate.AddBracket(SplitLine(1).Split(","))
                    Case "SOSTEN"
                        SOsten.AddBracket(SplitLine(1).Split(","))
                    Case "SOCORP"
                        SOstenCorporate.AddBracket(SplitLine(1).Split(","))
                    Case "ID"
                        TaxInfoID = SplitLine(1)
                End Select
            End If
        End While
        Debug.WriteLine(ToString())
        FileClose(1)
    End Sub

    Public Function CalculateTax(Money As Long, District As AllDistricts, Corporate As Boolean) As TaxCalcResult
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

    Private Function EnumToDistrict(District As AllDistricts, Corporate As Boolean) As District
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
                Return Nothing
        End Select
    End Function

    Private Function DistrictArray() As District()
        Return {Federal, FederalCorporate, Newpond, NewpondCorporate, Urbia, UrbiaCorporate, Paradisus, ParadisusCorporate, Laertes, LaertesCorporate, NOsten, NOstenCorporate, SOsten, SOstenCorporate}
    End Function

    Public Overrides Function ToString() As String
        Dim ReturnString As String = "=====[TAX CALCULATOR V 2.0]=====" & vbNewLine & "Loaded TaxInfo file " & TaxInfoID
        Dim totalbrackets As Integer = 0
        For Each District As District In DistrictArray()
            ReturnString &= vbNewLine & "::" & District.name & " (" & District.AllBrackets.Count & " Brackets)::"
            For Each bracket As TaxBracket In District.AllBrackets
                Dim UpperLimit As String = bracket.UpperLimit.ToString("N0") & "p"
                If bracket.UpperLimit = 2 ^ 62 Then UpperLimit = "INF"
                ReturnString &= vbNewLine & vbTab & bracket.Name & "(" & (bracket.Percent * 100) & "%) [From " & bracket.LowerLimit.ToString("N0") & "p to " & UpperLimit & "]"
            Next
            ReturnString &= vbNewLine
            totalbrackets += District.AllBrackets.Count
        Next
        ReturnString &= vbNewLine & "=====[" & totalbrackets & " Brackets]====="
        Return ReturnString
    End Function

    Public Function NumberOfBrackets() As Integer
        Dim totalbrackets As Integer = 0
        For Each District As District In DistrictArray()
            totalbrackets += District.AllBrackets.Count
        Next
        Return totalbrackets
    End Function

End Class
