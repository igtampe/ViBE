Imports VIBE__But_on_Visual_Studio_.IncomeRegistryItem

Public Class EZTaxWizard

    '--------------------------------[Variables]--------------------------------

    Public commit As Boolean = False
    Public MyItem As IncomeRegistryItem

    Private ItemName As String
    Private ItemIncome As Long
    Private ReadOnly NameClicked As Boolean
    Private ItemCompleteDetails As String

    Public Enum Mode
        Add
        Modify
    End Enum

    Private ReadOnly WindowMode As Mode

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(Mode As Mode, Optional SelectedItem As IncomeRegistryItem = Nothing)
        InitializeComponent()

        WindowMode = Mode
        If WindowMode = Mode.Modify Then
            If IsNothing(SelectedItem) Then Throw New ArgumentException("I need an incomeregistry item to modify!")

            AddItemButton.Text = "Modify"

            ItemName = SelectedItem.Name
            ItemIncome = SelectedItem.TotalIncome

            'General Setup
            ItemNameTXB.Text = SelectedItem.Name
            TotalIncome.Text = SelectedItem.TotalIncome.ToString("N0") & "p"
            DistrictBox.Text = SelectedItem.Location

            'Apartments
            ''Apartment Units
            StudioUnits.Value = SelectedItem.Apartment.StudioUnits
            OneBRUnits.Value = SelectedItem.Apartment.BR1Units
            TwoBRUnits.Value = SelectedItem.Apartment.BR2Units
            ThreeBRUnits.Value = SelectedItem.Apartment.BR3Units
            PHUnits.Value = SelectedItem.Apartment.PHUnits

            ''Apartment Rents
            StudioRent.Value = SelectedItem.Apartment.StudioRent
            OneBRRent.Value = SelectedItem.Apartment.BR1Rent
            TwoBRRent.Value = SelectedItem.Apartment.BR2Rent
            ThreeBRRent.Value = SelectedItem.Apartment.BR3Rent
            PHRent.Value = SelectedItem.Apartment.PHRent

            'Hotel
            HotelRooms.Value = SelectedItem.Hotel.Rooms
            HotelSuites.Value = SelectedItem.Hotel.Suites
            HotelRoomRate.Value = SelectedItem.Hotel.RoomRate
            HotelSuitesRate.Value = SelectedItem.Hotel.SuiteRate
            HotelMiscIncome.Value = SelectedItem.Hotel.MiscIncome

            'Business
            StoreChairs.Value = SelectedItem.Business.Chairs
            StoreAvgSpending.Value = SelectedItem.Business.AvgSpend
            StoreCustomersPerHour.Value = SelectedItem.Business.CustomersPerHour
            StoreHoursOpen.Value = SelectedItem.Business.HoursOpen

            'MiscINcome
            MiscIncome.Value = SelectedItem.MiscIncome

        End If

    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub ShowHideSummary() Handles ShowSummaryButton.Click
        If Size = MinimumSize Then
            Size = MaximumSize
            Quit.Location = New Point(481, 0)
        Else
            Size = MinimumSize
            Quit.Location = New Point(207, 0)
        End If
    End Sub

    Private Sub Nevermind() Handles Cancel.Click, Quit.Click
        Close()
    End Sub

    Private Sub StoreTypeChanged() Handles StoreType.SelectedIndexChanged
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

    Private Sub ActionClick() Handles AddItemButton.Click

        If DistrictBox.SelectedIndex = -1 Then
            MsgBox("Please select a district.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If ItemIncome = 0 Then
            MsgBox("Cannot add an empty item!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        UpdateItem()

        If WindowMode = Mode.Add Then
            Dim CertifyWindow As EzTaxCertify = New EzTaxCertify(MyItem, True)

            CertifyWindow.ShowDialog()
            CertifyWindow.Dispose()

        End If

        commit = True
        Close()
    End Sub

    Private Sub ItemNameChanged() Handles ItemNameTXB.TextChanged
        ItemName = ItemNameTXB.Text
        UpdateItem()
    End Sub

    ''' <summary>Updates income item, and then updates visual elements</summary>
    Private Sub Recalculate() Handles StudioUnits.ValueChanged, OneBRUnits.ValueChanged, TwoBRUnits.ValueChanged, ThreeBRUnits.ValueChanged, PHUnits.ValueChanged, HotelRooms.ValueChanged, HotelSuites.ValueChanged, HotelRoomRate.ValueChanged, HotelSuitesRate.ValueChanged, HotelMiscIncome.ValueChanged, StoreChairs.ValueChanged, StoreAvgSpending.ValueChanged, StoreCustomersPerHour.ValueChanged, StoreHoursOpen.ValueChanged, HotelMiscIncome.ValueChanged, StudioRent.ValueChanged, OneBRRent.ValueChanged, TwoBRRent.ValueChanged, ThreeBRRent.ValueChanged, PHRent.ValueChanged, MiscIncome.ValueChanged, DistrictBox.TextChanged

        UpdateItem()

        TotalIncome.Text = ItemIncome.ToString("N0") & "p"
        DetailsTXB.Text = ItemCompleteDetails

    End Sub

    '--------------------------------[Other Functions]--------------------------------

    ''' <summary>Updates myItem</summary>
    Private Sub UpdateItem()

        'Since this is run rather frequently, we should do this to free-up memory.
        If Not IsNothing(MyItem) Then MyItem.Dispose()
        MyItem = Nothing

        Dim ItemApartmentDetails As ApartmentDetails = New ApartmentDetails(StudioUnits.Value, OneBRUnits.Value, TwoBRUnits.Value, ThreeBRUnits.Value, PHUnits.Value, StudioRent.Value, OneBRRent.Value, TwoBRRent.Value, ThreeBRRent.Value, PHRent.Value)
        Dim ItemHotelDetails As HotelDetails = New HotelDetails(HotelRooms.Value, HotelSuites.Value, HotelRoomRate.Value, HotelSuitesRate.Value, HotelMiscIncome.Value)
        Dim ItemBusinessDetails As BusinessDetails = New BusinessDetails(StoreChairs.Value, StoreAvgSpending.Value, StoreCustomersPerHour.Value, StoreHoursOpen.Value)
        Dim ItemMiscIncome As Long = MiscIncome.Value
        MyItem = New IncomeRegistryItem(ItemName, ItemApartmentDetails, ItemHotelDetails, ItemBusinessDetails, ItemMiscIncome, DistrictBox.Text)

        ItemIncome = MyItem.TotalIncome
        ItemCompleteDetails = MyItem.ToString

    End Sub

    '--------------------------------[Window Moving Functions]--------------------------------

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