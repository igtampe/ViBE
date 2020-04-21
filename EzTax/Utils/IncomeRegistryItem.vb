
''' <summary>The class that holds an IRI from an IRF</summary>
Public Class IncomeRegistryItem

    '--------------------------------[Structures]--------------------------------

    ''' <summary>Holds details for an apartment building</summary>
    Public Structure ApartmentDetails
        Public StudioUnits As Integer
        Public BR1Units As Integer
        Public BR2Units As Integer
        Public BR3Units As Integer
        Public PHUnits As Integer

        Public StudioRent As Integer
        Public BR1Rent As Integer
        Public BR2Rent As Integer
        Public BR3Rent As Integer
        Public PHRent As Integer

        ''' <summary>Total Apartment Income</summary>
        Public Income As Long

        ''' <summary>Creates a new Apartment details</summary>
        ''' <param name="S">Studio units</param>
        ''' <param name="BR1">1 Bedroom units</param>
        ''' <param name="BR2">2 Bedroom units</param>
        ''' <param name="BR3">3 Bedroom Units</param>
        ''' <param name="PH">Penthouse units</param>
        ''' <param name="SRent">Studio rent rate PER MONTH</param>
        ''' <param name="BR1Rent">1 Bedroom rent rate PER MONTH</param>
        ''' <param name="BR2Rent">2 Bedroom rent rate PER MONTH</param>
        ''' <param name="BR3Rent">3 Bedroom rent rate PER MONTH</param>
        ''' <param name="PHRent">Penthouse rent rate PER MONTH</param>
        Public Sub New(S As Integer, BR1 As Integer, BR2 As Integer, BR3 As Integer, PH As Integer, SRent As Integer, BR1Rent As Integer, BR2Rent As Integer, BR3Rent As Integer, PHRent As Integer)
            StudioUnits = S
            BR1Units = BR1
            BR2Units = BR2
            BR3Units = BR3
            PHUnits = PH

            StudioRent = SRent
            Me.BR1Rent = BR1Rent
            Me.BR2Rent = BR2Rent
            Me.BR3Rent = BR3Rent
            Me.PHRent = PHRent

            Income = (SRent * S) + (BR1Rent * BR1) + (BR2Rent * BR2) + (BR3Rent * BR3) + (PHRent * PH)

        End Sub

        Public Overrides Function ToString() As String

            Dim ApartmentDetails As String = ""

            If StudioUnits = 0 And
            BR1Units = 0 And
            BR2Units = 0 And
            BR3Units = 0 And
            PHUnits = 0 Then
                'do nothing
            Else
                ApartmentDetails &= vbNewLine & vbNewLine & "-[Apartments]---------"

                'Apartments

                If Not StudioUnits = 0 Then
                    ApartmentDetails &= vbNewLine & "Studio Units        : " & StudioUnits
                    ApartmentDetails &= vbNewLine & "Studio Rent         : " & StudioRent.ToString("N0") & "p"
                End If

                If Not BR1Units = 0 Then
                    ApartmentDetails &= vbNewLine & "One Bedroom Units   : " & BR1Units
                    ApartmentDetails &= vbNewLine & "One Bedroom Rent    : " & BR1Rent.ToString("N0") & "p"
                End If

                If Not BR2Units = 0 Then
                    ApartmentDetails &= vbNewLine & "Two Bedroom Units   : " & BR2Units
                    ApartmentDetails &= vbNewLine & "Two Bedroom Rent    : " & BR2Rent.ToString("N0") & "p"
                End If

                If Not BR3Units = 0 Then
                    ApartmentDetails &= vbNewLine & "Three Bedroom Units : " & BR3Units
                    ApartmentDetails &= vbNewLine & "Three Bedroom Rent  : " & BR3Rent.ToString("N0") & "p"
                End If

                If Not PHUnits = 0 Then
                    ApartmentDetails &= vbNewLine & "Penthouse Units     : " & PHUnits
                    ApartmentDetails &= vbNewLine & "Penthouse Rent      : " & PHRent.ToString("N0") & "p"
                End If

            End If

            Return ApartmentDetails

        End Function
    End Structure

    ''' <summary>A structure that holds details of a Hotel</summary>
    Public Structure HotelDetails
        Public Rooms As Integer
        Public Suites As Integer
        Public RoomRate As Integer
        Public SuiteRate As Integer

        ''' <summary>Hotel Miscelaneous income (provided by other services)</summary>
        Public MiscIncome As Integer

        ''' <summary>Total Hotel Income </summary>
        Public Income As Long

        ''' <summary>Creates a new HotelDetails</summary>
        ''' <param name="R">Rooms in the hotel</param>
        ''' <param name="S">Suites in the hotel</param>
        ''' <param name="RR">Room Rate per Night</param>
        ''' <param name="SR">Suite rate per night</param>
        ''' <param name="MI">Misc Income from other facilities</param>
        Public Sub New(R As Integer, S As Integer, RR As Integer, SR As Integer, MI As Integer)
            Rooms = R
            Suites = S
            RoomRate = RR
            SuiteRate = SR
            MiscIncome = MI

            Dim MonthlyHotelRoomIncome As Integer = ((((RR) / 2) * 365) / 12)
            Dim MonthlyHotelSuiteIncome As Integer = ((((SR) / 2) * 365) / 12)

            Income = (MonthlyHotelRoomIncome * R) + (MonthlyHotelSuiteIncome * S) + MI

        End Sub

        Public Overrides Function ToString() As String

            Dim HotelDetails As String = ""

            If Rooms = 0 And
              Suites = 0 And
              MiscIncome = 0 Then
                'do nothing
            Else
                HotelDetails &= vbNewLine & vbNewLine & "-[Hotel]--------------"

                'Hotel
                If Not Rooms = 0 Then
                    HotelDetails &= vbNewLine & "Hotel Rooms         : " & Rooms
                    HotelDetails &= vbNewLine & "Hotel Room Rate     : " & RoomRate.ToString("N0") & "p"
                End If

                If Not Suites = 0 Then
                    HotelDetails &= vbNewLine & "Hotel Suites        : " & Suites
                    HotelDetails &= vbNewLine & "Hotel Suites Rate   : " & SuiteRate.ToString("N0") & "p"
                End If

                If Not MiscIncome = 0 Then
                    HotelDetails &= vbNewLine & "Hotel Misc Income   : " & MiscIncome.ToString("N0") & "p"
                End If

            End If

            Return HotelDetails

        End Function

    End Structure

    ''' <summary>A structure that holds details of a standard business (store/restaurant)</summary>
    Public Structure BusinessDetails
        Public Chairs As Integer
        Public AvgSpend As Integer
        Public CustomersPerHour As Integer
        Public HoursOpen As Integer

        ''' <summary>Total Business Income</summary>
        Public Income As Long

        ''' <summary>Creates a Business Details for Income Items</summary>
        ''' <param name="C">Chairs in the establishment</param>
        ''' <param name="A">Average Spending per Customer</param>
        ''' <param name="CH">Customers Per Hour PER SEAT</param>
        ''' <param name="HO">Hours Open</param>
        Public Sub New(C As Integer, A As Integer, CH As Integer, HO As Integer)
            Chairs = C
            AvgSpend = A
            CustomersPerHour = CH
            HoursOpen = HO

            Income = (((A / 2) * CH * HO) * C) * 30

        End Sub

        Public Overrides Function ToString() As String

            Dim BusinessDetails As String = ""

            If Not Income = 0 Then
                BusinessDetails = BusinessDetails & vbNewLine & vbNewLine & "-[Business]-----------"
                'Stores

                BusinessDetails &= vbNewLine & "Chairs              : " & Chairs
                BusinessDetails &= vbNewLine & "Average Spending    : " & AvgSpend
                BusinessDetails &= vbNewLine & "Customers Per Hour  : " & CustomersPerHour
                BusinessDetails &= vbNewLine & "Hours Open          : " & HoursOpen
            End If

            Return BusinessDetails

        End Function

    End Structure

    '--------------------------------[Variables]--------------------------------

    ''' <summary>Name of the Item</summary>
    Public Name As String

    ''' <summary>Total income of the item (Calculated)</summary>
    Public TotalIncome As Long

    ''' <summary>The Item's real location on the IncomeRegistry Array (Used by Search Results)</summary>
    Public RealItemLocation As Integer

    ''' <summary>Apartment details of the item</summary>
    Public Apartment As ApartmentDetails

    ''' <summary>Hotel Details of the Item</summary>
    Public Hotel As HotelDetails

    ''' <summary>Business Details of the Item</summary>
    Public Business As BusinessDetails

    ''' <summary>Item Miscelaneuous Income</summary>
    Public MiscIncome As Long

    ''' <summary>Location of the Item</summary>
    Public Location As String

    '--------------------------------[Constructors]--------------------------------

    ''' <summary>Makes a new IncomeRegistryItem</summary>
    ''' <param name="N">Name of the Item</param>
    ''' <param name="A">Apartment Details of the item</param>
    ''' <param name="H">Hotel Details of the item</param>
    ''' <param name="B">Business Details of the Item</param>
    ''' <param name="MI">Misc Income of the item</param>
    ''' <param name="L">District of the item</param>
    Public Sub New(N As String, A As ApartmentDetails, H As HotelDetails, B As BusinessDetails, MI As Long, L As String)
        Name = N
        Apartment = A
        Hotel = H
        Business = B
        MiscIncome = MI
        Location = L

        TotalIncome = Apartment.Income + Hotel.Income + Business.Income + MiscIncome
    End Sub

    ''' <summary>Makes a new legacy IncomeRegistryItem </summary>
    ''' <param name="N">Name</param>
    ''' <param name="TI">Total INcome</param>
    Public Sub New(N As String, TI As Long)
        Name = N
        Apartment = New ApartmentDetails(0, 0, 0, 0, 0, 500, 750, 1000, 1250, 1250)
        Hotel = New HotelDetails(0, 0, 200, 400, 0)
        Business = New BusinessDetails(0, 0, 0, 0)
        MiscIncome = TI
        Location = "Unselected"
        TotalIncome = TI
    End Sub

    ''' <summary>Makes a new IncomeRegistryItem that is an exact copy of the one specified</summary>
    ''' <param name="ItemToCopy">The item to copy</param>
    Public Sub New(ItemToCopy As IncomeRegistryItem)
        Name = ItemToCopy.Name
        Apartment = ItemToCopy.Apartment
        Hotel = ItemToCopy.Hotel
        Business = ItemToCopy.Business
        MiscIncome = ItemToCopy.MiscIncome
        Location = ItemToCopy.Location
        TotalIncome = ItemToCopy.TotalIncome
    End Sub

    '--------------------------------[Other Functions]--------------------------------

    ''' <summary>Turns this item into a string (mostly for detail viewing</summary>
    Public Overrides Function ToString() As String
        Dim ItemCompleteDetails As String = "-{" & Name & "}--------------" & vbNewLine & "Located in: " & Location

        ItemCompleteDetails &= Apartment.ToString
        ItemCompleteDetails &= Hotel.ToString
        ItemCompleteDetails &= Business.ToString

        If Not MiscIncome = 0 Then
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Misc. Income]-------"
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Income              : " & MiscIncome.ToString("N0") & "p"
        End If


        If Apartment.Income = 0 And
            Hotel.Income = 0 And
            Business.Income = 0 And
            MiscIncome = 0 Then
            'do nothing
        Else
            ItemCompleteDetails &= vbNewLine & vbNewLine & "-[Totals]-------------"
            If Not Apartment.Income = 0 Then ItemCompleteDetails &= vbNewLine & "Apartment Total     : " & (Apartment.Income).ToString("N0") & "p"
            If Not Hotel.Income = 0 Then ItemCompleteDetails &= vbNewLine & "Hotel Total         : " & (Hotel.Income).ToString("N0") & "p"
            If Not Business.Income = 0 Then ItemCompleteDetails &= vbNewLine & "Business Total      : " & (Business.Income).ToString("N0") & "p"
            If Not MiscIncome = 0 Then ItemCompleteDetails &= vbNewLine & "Misc. Total         : " & (MiscIncome).ToString("N0") & "p"
        End If

        Return ItemCompleteDetails

    End Function

    ''' <summary>Clears out this item</summary>
    Public Sub Dispose()

        Name = Nothing
        MiscIncome = Nothing
        Location = Nothing
        TotalIncome = Nothing

        Apartment = Nothing
        Hotel = Nothing
        Business = Nothing
    End Sub

End Class
