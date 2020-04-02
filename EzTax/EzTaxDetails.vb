Imports VIBE__But_on_Visual_Studio_.EZTaxMain
Public Class EzTaxDetails
    Public ItemCompleteDetails As String = ""
    Public myItem As IncomeRegistryItem

    Private Sub OKBTN_Click(sender As Object, e As EventArgs) Handles OKBTN.Click
        Close()
    End Sub

    Private Sub EzTaxDetails_Load(sender As Object, e As EventArgs) Handles Me.Shown
        ItemNameLabel.Text = myItem.Name
        ItemLocationLabel.Text = "Located in: " & myItem.Location

        ItemCompleteDetails = ItemCompleteDetails & "-{" & myItem.Name & "}--------------" & vbNewLine & "Located in: " & myItem.Location

        If myItem.Apartment.StudioUnits = 0 And
            myItem.Apartment.BR1Units = 0 And
            myItem.Apartment.BR2Units = 0 And
            myItem.Apartment.BR3Units = 0 And
            myItem.Apartment.PHUnits = 0 Then
            'do nothing
        Else
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Apartments]---------"

            'Apartments

            If Not myItem.Apartment.StudioUnits = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Studio Units        : " & myItem.Apartment.StudioUnits
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Studio Rent         : " & myItem.Apartment.StudioRent.ToString("N0") & "p"
            End If

            If Not myItem.Apartment.BR1Units = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "One Bedroom Units   : " & myItem.Apartment.BR1Units
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "One Bedroom Rent    : " & myItem.Apartment.BR1Rent.ToString("N0") & "p"
            End If

            If Not myItem.Apartment.BR2Units = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Two Bedroom Units   : " & myItem.Apartment.BR2Units
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Two Bedroom Rent    : " & myItem.Apartment.BR2Rent.ToString("N0") & "p"
            End If

            If Not myItem.Apartment.BR3Units = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Three Bedroom Units : " & myItem.Apartment.BR3Units
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Three Bedroom Rent  : " & myItem.Apartment.BR3Rent.ToString("N0") & "p"
            End If

            If Not myItem.Apartment.PHUnits = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Penthouse Units     : " & myItem.Apartment.PHUnits
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Penthouse Rent      : " & myItem.Apartment.PHRent.ToString("N0") & "p"
            End If

        End If

        If myItem.Hotel.Rooms = 0 And
            myItem.Hotel.Suites = 0 And
            myItem.Hotel.MiscIncome = 0 Then
            'do nothing
        Else
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Hotel]--------------"

            'Hotel

            If Not myItem.Hotel.Rooms = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Rooms         : " & myItem.Hotel.Rooms
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Room Rate     : " & myItem.Hotel.RoomRate.ToString("N0") & "p"
            End If

            If Not myItem.Hotel.Suites = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Suites        : " & myItem.Hotel.Suites
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Suites Rate   : " & myItem.Hotel.SuiteRate.ToString("N0") & "p"
            End If

            If Not myItem.Hotel.MiscIncome = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Misc Income   : " & myItem.Hotel.MiscIncome.ToString("N0") & "p"
            End If

        End If

        If Not (((myItem.Business.AvgSpend / 2) * myItem.Business.CustomersPerHour * myItem.Business.HoursOpen) * myItem.Business.Chairs) = 0 Then
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Business]-----------"
            'Stores

            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Chairs              : " & myItem.Business.Chairs
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Average Spending    : " & myItem.Business.AvgSpend
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Customers Per Hour  : " & myItem.Business.CustomersPerHour
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hours Open          : " & myItem.Business.HoursOpen
        End If

        If myItem.MiscIncome = 0 Then
            'do nothing
        Else
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Misc. Income]-------"
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Income              : " & myItem.MiscIncome.ToString("N0") & "p"
        End If

        If myItem.Apartment.Income = 0 And
            myItem.Hotel.Income = 0 And
            myItem.Business.Income = 0 And
            myItem.MiscIncome = 0 Then
            'do nothing
        Else
            ItemCompleteDetails = ItemCompleteDetails & vbNewLine & vbNewLine & "-[Totals]-------------"
            If Not myItem.Apartment.Income = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Apartment Total     : " & (myItem.Apartment.Income).ToString("N0") & "p"
            End If

            If Not myItem.Hotel.Income = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Hotel Total         : " & (myItem.Hotel.Income).ToString("N0") & "p"
            End If

            If Not myItem.Business.Income = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Business Total      : " & (myItem.Business.Income).ToString("N0") & "p"
            End If

            If Not myItem.MiscIncome = 0 Then
                ItemCompleteDetails = ItemCompleteDetails & vbNewLine & "Misc. Total         : " & (myItem.MiscIncome).ToString("N0") & "p"
            End If

        End If


        DetailsTXB.Text = ItemCompleteDetails

    End Sub

    Private Sub Encore() Handles RecertifyButton.Click
        Dim RecertWindow As EzTaxCertify = New EzTaxCertify With {
            .HasToReport = False,
            .ItemToCertify = myItem
        }
        RecertWindow.DetailsTXB.Text = ItemCompleteDetails
        RecertWindow.ShowDialog()
    End Sub

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