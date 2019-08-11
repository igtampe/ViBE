
Public Class EZTaxWizard

    Public ItemName As String
    Public ItemIncome As Long
    Public NameClicked As Boolean
    Public ItemCompleteDetails As String

    Sub ResetEverything() Handles Me.Load
        EZTaxMain.Visible = False
        StudioUnits.Value = 0
        OneBRUnits.Value = 0
        TwoBRUnits.Value = 0
        ThreeBRUnits.Value = 0
        PHUnits.Value = 0
        HotelRooms.Value = 0
        HotelSuites.Value = 0
        HotelRoomRate.Value = 200
        HotelSuitesRate.Value = 400
        HotelMiscIncome.Value = 0
        StoreChairs.Value = 0
        StoreAvgSpending.Value = 0
        StoreCustomersPerHour.Value = 0
        StoreHoursOpen.Value = 0
        StoreType.SelectedIndex = -1
        ItemNameTXB.Text = "(Name)"
        ItemIncome = 0
        TotalIncome.Text = ItemIncome.ToString("N0") & "p"
        NameClicked = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StoreType.SelectedIndexChanged
        Select Case StoreType.SelectedIndex
            Case 0
                'Restaurant
                StoreChairs.Value = 0
                StoreChairs.Enabled = True
            Case 1
                'Other Store
                StoreChairs.Value = 1
                StoreChairs.Enabled = False
            Case Else
                StoreChairs.Value = 0
                StoreChairs.Enabled = True
        End Select
    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click, Quit.Click
        ItemName = "~CANCEL~"
        EZTaxMain.Visible = True
        Close()
    End Sub

    Private Sub AddItemButton_Click_1(sender As Object, e As EventArgs) Handles AddItemButton.Click

        If ItemIncome = 0 Then
            MsgBox("Cannot add an empty item!", MsgBoxStyle.Information)
            Exit Sub
        End If

        RegenerateItemCompleteDetails()

        EzTaxCertify.ShowDialog()
        EZTaxMain.Visible = True
        Close()
    End Sub

    Private Sub ItemNameTXB_TextChanged(sender As Object, e As EventArgs) Handles ItemNameTXB.TextChanged
        ItemName = ItemNameTXB.Text
        RegenerateItemCompleteDetails()
    End Sub

    Private Sub StudioUnits_ValueChanged(sender As Object, e As EventArgs) Handles StudioUnits.ValueChanged, OneBRUnits.ValueChanged, TwoBRUnits.ValueChanged, ThreeBRUnits.ValueChanged, PHUnits.ValueChanged, HotelRooms.ValueChanged, HotelSuites.ValueChanged, HotelRoomRate.ValueChanged, HotelSuitesRate.ValueChanged, HotelMiscIncome.ValueChanged, StoreChairs.ValueChanged, StoreAvgSpending.ValueChanged, StoreCustomersPerHour.ValueChanged, StoreHoursOpen.ValueChanged, HotelMiscIncome.ValueChanged, StudioRent.ValueChanged, OneBRRent.ValueChanged, TwoBRRent.ValueChanged, ThreeBRRent.ValueChanged, PHRent.ValueChanged, FlightsPerDay.ValueChanged, EconSeats.ValueChanged, EconTicket.ValueChanged, BusinessSeats.ValueChanged, BusinessTicket.ValueChanged, FirstClassSeats.ValueChanged, FirstClassTicket.ValueChanged


        Dim ApartmentIncome As Long
        Dim HotelIncome As Long
        Dim StoreIncome As Long
        Dim PlaneIncome As Long

        ApartmentIncome = (StudioRent.Value * StudioUnits.Value) + (OneBRRent.Value * OneBRUnits.Value) + (TwoBRRent.Value * TwoBRUnits.Value) + (ThreeBRRent.Value * ThreeBRUnits.Value) + (PHRent.Value * PHUnits.Value)

        Dim MonthlyHotelRoomIncome As Long
        Dim MonthlyHotelSuiteIncome As Long

        MonthlyHotelRoomIncome = (((HotelRoomRate.Value) / 2) * 365) / 12
        MonthlyHotelSuiteIncome = (((HotelSuitesRate.Value) / 2) * 365) / 12

        HotelIncome = (MonthlyHotelRoomIncome * HotelRooms.Value) + (MonthlyHotelSuiteIncome * HotelSuites.Value) + HotelMiscIncome.Value

        StoreIncome = ((StoreAvgSpending.Value / 2) * StoreCustomersPerHour.Value * StoreHoursOpen.Value) * StoreChairs.Value

        PlaneIncome = FlightsPerDay.Value * ((EconSeats.Value * EconTicket.Value * 0.125) + (BusinessTicket.Value * BusinessSeats.Value * 0.125) + (FirstClassTicket.Value * FirstClassSeats.Value * 0.125))

        ItemIncome = ApartmentIncome + HotelIncome + StoreIncome + PlaneIncome
        TotalIncome.Text = ItemIncome.ToString("N0") & "p"
        RegenerateItemCompleteDetails()

    End Sub

    Sub RegenerateItemCompleteDetails()
        ItemCompleteDetails = Nothing
        ItemCompleteDetails = ItemCompleteDetails & "-{" & ItemName & "}--------------"

        If StudioUnits.Value = 0 And
            OneBRUnits.Value = 0 And
            TwoBRUnits.Value = 0 And
            ThreeBRUnits.Value = 0 And
            PHUnits.Value = 0 Then
            'do nothing
        Else
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Apartments]---------"

            'Apartments

            If Not StudioUnits.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Studio Units        : " & StudioUnits.Value
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Studio Rent         : " & StudioRent.Value.ToString("N0") & "p"
            End If

            If Not OneBRUnits.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "One Bedroom Units   : " & OneBRUnits.Value
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "One Bedroom Rent    : " & OneBRRent.Value.ToString("N0") & "p"
            End If

            If Not TwoBRUnits.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Two Bedroom Units   : " & TwoBRUnits.Value
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Two Bedroom Rent    : " & TwoBRRent.Value.ToString("N0") & "p"
            End If

            If Not ThreeBRUnits.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Three Bedroom Units : " & ThreeBRUnits.Value
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Three Bedroom Rent  : " & ThreeBRRent.Value.ToString("N0") & "p"
            End If

            If Not PHUnits.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Penthouse Units     : " & PHUnits.Value
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Penthouse Rent      : " & PHRent.Value.ToString("N0") & "p"
            End If

        End If

        If HotelRooms.Value = 0 And
            HotelSuites.Value = 0 And
            HotelMiscIncome.Value = 0 Then
            'do nothing
        Else
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Hotel]--------------"

            'Hotel

            If Not HotelRooms.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Rooms         : " & HotelRooms.Value
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Room Rate     : " & HotelRoomRate.Value.ToString("N0") & "p"
            End If

            If Not HotelSuites.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Suites        : " & HotelSuites.Value
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Suites Rate   : " & HotelSuitesRate.Value.ToString("N0") & "p"
            End If

            If Not HotelMiscIncome.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Misc Income   : " & HotelMiscIncome.Value.ToString("N0") & "p"
            End If

        End If

        If Not (((StoreAvgSpending.Value / 2) * StoreCustomersPerHour.Value * StoreHoursOpen.Value) * StoreChairs.Value) = 0 Then
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Business]-----------"
            'Stores

            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Chairs              : " & StoreChairs.Value
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Average Spending    : " & StoreAvgSpending.Value
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Customers Per Hour  : " & StoreCustomersPerHour.Value
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hours Open          : " & StoreHoursOpen.Value
        End If

        Dim MonthlyHotelRoomIncome As Long = (((HotelRoomRate.Value) / 2) * 365) / 12
        Dim MonthlyHotelSuiteIncome As Long = (((HotelSuitesRate.Value) / 2) * 365) / 12

        If FlightsPerDay.Value = 0 Then
            'do nothing
        Else
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Planes]-------------"
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Flights/Day         : " & FlightsPerDay.Value
            'Planes
            If Not EconTicket.Value * EconSeats.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "~~~~~~~~~~~~[Economy]~"
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Seats               : " & EconSeats.Value
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Ticket Price        : " & EconTicket.Value
            End If
            If Not BusinessTicket.Value * BusinessSeats.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "~~~~~~~~~~~[Business]~"
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Seats               : " & BusinessSeats.Value
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Ticket Price        : " & BusinessTicket.Value
            End If
            If Not FirstClassTicket.Value * FirstClassSeats.Value = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "~~~~~~~~[First Class]~"
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Seats               : " & FirstClassSeats.Value
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Ticket Price        : " & FirstClassTicket.Value
            End If
        End If


        If (StudioRent.Value * StudioUnits.Value) + (OneBRRent.Value * OneBRUnits.Value) + (TwoBRRent.Value * TwoBRUnits.Value) + (ThreeBRRent.Value * ThreeBRUnits.Value) + (PHRent.Value * PHUnits.Value) = 0 And
            ((MonthlyHotelRoomIncome * HotelRooms.Value) + (MonthlyHotelSuiteIncome * HotelSuites.Value) + HotelMiscIncome.Value) = 0 And
            (((StoreAvgSpending.Value / 2) * StoreCustomersPerHour.Value * StoreHoursOpen.Value) * StoreChairs.Value) = 0 Then
            'do nothing
        Else
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Totals]-------------"
            If Not (StudioRent.Value * StudioUnits.Value) + (OneBRRent.Value * OneBRUnits.Value) + (TwoBRRent.Value * TwoBRUnits.Value) + (ThreeBRRent.Value * ThreeBRUnits.Value) + (PHRent.Value * PHUnits.Value) = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Apartment Total     : " & ((StudioRent.Value * StudioUnits.Value) + (OneBRRent.Value * OneBRUnits.Value) + (TwoBRRent.Value * TwoBRUnits.Value) + (ThreeBRRent.Value * ThreeBRUnits.Value) + (PHRent.Value * PHUnits.Value)).ToString("N0") & "p"
            End If

            If Not ((MonthlyHotelRoomIncome * HotelRooms.Value) + (MonthlyHotelSuiteIncome * HotelSuites.Value) + HotelMiscIncome.Value) = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Total         : " & ((MonthlyHotelRoomIncome * HotelRooms.Value) + (MonthlyHotelSuiteIncome * HotelSuites.Value) + HotelMiscIncome.Value).ToString("N0") & "p"
            End If

            If Not (((StoreAvgSpending.Value / 2) * StoreCustomersPerHour.Value * StoreHoursOpen.Value) * StoreChairs.Value) = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Business Total      : " & (((StoreAvgSpending.Value / 2) * StoreCustomersPerHour.Value * StoreHoursOpen.Value) * StoreChairs.Value).ToString("N0") & "p"
            End If

        End If


        DetailsTXB.Text = ItemCompleteDetails
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Size = MinimumSize Then
            Size = MaximumSize
            Quit.Location = New Point(481, 0)
        Else
            Size = MinimumSize
            Quit.Location = New Point(207, 0)
        End If
        'Normal

        'Extended

    End Sub


End Class