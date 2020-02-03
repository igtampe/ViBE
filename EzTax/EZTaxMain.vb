
Imports VIBE__But_on_Visual_Studio_.TaxCalc
Imports System.ComponentModel
Imports System.IO

Public Class EZTaxMain

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

    Public LocalTaxInfo As TaxInformation
    Public ServerTaxInfo As TaxInformation

    Public Income As Long
    Public IRTI As Long

    Public EI As Long

    Public TaxBracket As String
    Public Tax As Long

    Public Total As Long
    Public InitializationResult
    Public ID As String
    Public IWStatus As String
    Public Category As Integer
    Public SelectedItem As IncomeRegistryItem
    Public Shared IncomeregistryArray() As IncomeRegistryItem
    Public Shared SearchIncomeArray() As IncomeRegistryItem

    Public UpdatedTotal As Long
    Public UpdatedTaxDue As Long
    Public UpdatedTaxBracket As String

    Public MoveWarning As Boolean

    Public SearchMode As Boolean


    ''' <summary>
    ''' The structure for each Income Registry Item
    ''' </summary>
    Public Structure IncomeRegistryItem

        ''' <summary>
        ''' Name of the Item
        ''' </summary>
        Public Name As String

        ''' <summary>
        ''' Total income of the item (Calculated)
        ''' </summary>
        Public TotalIncome As Long

        ''' <summary>
        ''' The Item's real location on the IncomeRegistry Array (Used by Search Results)
        ''' </summary>
        Public RealItemLocation As Integer

        ''' <summary>
        ''' Apartment details of the item
        ''' </summary>
        Public Apartment As ApartmentDetails

        ''' <summary>
        ''' Hotel Details of the Item
        ''' </summary>
        Public Hotel As HotelDetails

        ''' <summary>
        ''' Business Details of the Item
        ''' </summary>
        Public Business As BusinessDetails

        ''' <summary>
        ''' Item Miscelaneuous Income
        ''' </summary>
        Public MiscIncome As Long

        ''' <summary>
        ''' Location of the Item
        ''' </summary>
        Public Location As String

        ''' <summary>
        ''' Makes a new IncomeRegistryItem
        ''' </summary>
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

        ''' <summary>
        ''' Makes a new legacy IncomeRegistryItem
        ''' </summary>
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

        ''' <summary>
        ''' Makes a new IncomeRegistryItem that is an exact copy of the one specified
        ''' </summary>
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

    End Structure

    ''' <summary>
    ''' Holds details for an apartment building
    ''' </summary>
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

        ''' <summary>
        ''' Total Apartment Income
        ''' </summary>
        Public Income As Long

        ''' <summary>
        ''' Creates a new Apartment details
        ''' </summary>
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
    End Structure

    ''' <summary>
    ''' A structure that holds details of a Hotel
    ''' </summary>
    Public Structure HotelDetails
        Public Rooms As Integer
        Public Suites As Integer
        Public RoomRate As Integer
        Public SuiteRate As Integer

        ''' <summary>
        ''' Hotel Miscelaneous income (provided by other services)
        ''' </summary>
        Public MiscIncome As Integer

        ''' <summary>
        ''' Total Hotel Income 
        ''' </summary>
        Public Income As Long

        ''' <summary>
        ''' Creates a new HotelDetails
        ''' </summary>
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
    End Structure

    ''' <summary>
    ''' A structure that holds details of a standard business (store/restaurant)
    ''' </summary>
    Public Structure BusinessDetails
        Public Chairs As Integer
        Public AvgSpend As Integer
        Public CustomersPerHour As Integer
        Public HoursOpen As Integer

        ''' <summary>
        ''' Total Business Income
        ''' </summary>
        Public Income As Long

        ''' <summary>
        ''' Creates a Business Details for Income Items
        ''' </summary>
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
    End Structure

    Private Sub AddButton_click() Handles AddButton.Click
        Dim AddWindow As EZTaxWizard = New EZTaxWizard

        Hide()
        AddWindow.ShowDialog()

        Show()
        AddWindow.Dispose()

        SearchBox.Text = ""
        PopulateListview()

        DetailsButton.Enabled = False
        ModifyItemButton.Enabled = False
        RemoveItemButton.Enabled = False

    End Sub

    Public Shared Sub AddToIncomeRegistry(NewItem As IncomeRegistryItem)

        Dim NewItemIndex As Integer

        Try
            NewItemIndex = IncomeregistryArray.Count
        Catch
        End Try

        ReDim Preserve IncomeregistryArray(NewItemIndex)
        IncomeregistryArray(NewItemIndex) = NewItem

    End Sub

    Public Shared Sub ModifyItemInIncomeRegistry(NewItem As IncomeRegistryItem, ItemIndex As Integer)
        IncomeregistryArray(ItemIndex) = NewItem
    End Sub

    Private Sub EzTaxDoubleClick() Handles ListView1.DoubleClick
        Try
            ModifyItemButton_Click()
        Catch
        End Try
    End Sub

    Private Sub ShowDetails() Handles DetailsButton.Click
        Dim Detailswindow As EzTaxDetails = New EzTaxDetails
        Detailswindow.myItem = SelectedItem
        Hide()
        Detailswindow.ShowDialog()
        Show()
    End Sub

    Private Sub ModifyItemButton_Click() Handles ModifyItemButton.Click

        Dim NewItemIndex As Integer

        Try
            NewItemIndex = ListView1.SelectedIndices(0)
        Catch
            MsgBox("Please select an item", MsgBoxStyle.Critical, "EzTax")
            Exit Sub
        End Try

        If SearchMode = True Then
            NewItemIndex = SearchIncomeArray(NewItemIndex + 1).RealItemLocation
        End If

        Dim ModWindow As EZTaxWizard = New EZTaxWizard
        ModWindow.WindowMode = EZTaxWizard.Mode.Modify
        ModWindow.AddItemButton.Text = "Modify"
        ModWindow.SelectedItemIndex = NewItemIndex

        'General Setup
        ModWindow.ItemName = SelectedItem.Name
        ModWindow.ItemNameTXB.Text = SelectedItem.Name
        ModWindow.TotalIncome.Text = SelectedItem.TotalIncome.ToString("N0") & "p"
        ModWindow.DistrictBox.Text = SelectedItem.Location



        'Apartments
        ''Apartment Units
        ModWindow.StudioUnits.Value = SelectedItem.Apartment.StudioUnits
        ModWindow.OneBRUnits.Value = SelectedItem.Apartment.BR1Units
        ModWindow.TwoBRUnits.Value = SelectedItem.Apartment.BR2Units
        ModWindow.ThreeBRUnits.Value = SelectedItem.Apartment.BR3Units
        ModWindow.PHUnits.Value = SelectedItem.Apartment.PHUnits

        ''Apartment Rents
        ModWindow.StudioRent.Value = SelectedItem.Apartment.StudioRent
        ModWindow.OneBRRent.Value = SelectedItem.Apartment.BR1Rent
        ModWindow.TwoBRRent.Value = SelectedItem.Apartment.BR2Rent
        ModWindow.ThreeBRRent.Value = SelectedItem.Apartment.BR3Rent
        ModWindow.PHRent.Value = SelectedItem.Apartment.PHRent

        'Hotel
        ModWindow.HotelRooms.Value = SelectedItem.Hotel.Rooms
        ModWindow.HotelSuites.Value = SelectedItem.Hotel.Suites
        ModWindow.HotelRoomRate.Value = SelectedItem.Hotel.RoomRate
        ModWindow.HotelSuitesRate.Value = SelectedItem.Hotel.SuiteRate
        ModWindow.HotelMiscIncome.Value = SelectedItem.Hotel.MiscIncome

        'Business
        ModWindow.StoreChairs.Value = SelectedItem.Business.Chairs
        ModWindow.StoreAvgSpending.Value = SelectedItem.Business.AvgSpend
        ModWindow.StoreCustomersPerHour.Value = SelectedItem.Business.CustomersPerHour
        ModWindow.StoreHoursOpen.Value = SelectedItem.Business.HoursOpen

        'MiscINcome
        ModWindow.MiscIncome.Value = SelectedItem.MiscIncome

        Hide()
        ModWindow.ShowDialog()

        Show()
        ModWindow.Dispose()



        RePopulateListView()
        DetailsButton.Enabled = False
        ModifyItemButton.Enabled = False
        RemoveItemButton.Enabled = False





    End Sub

    Private Sub RemoveItemButton_Click(sender As Object, e As EventArgs) Handles RemoveItemButton.Click
        Dim DeletePrompt = MsgBox("Are you sure you want to remove " & SelectedItem.Name & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EzTax")

        If DeletePrompt = MsgBoxResult.Yes Then
            DetailsButton.Enabled = False
            ModifyItemButton.Enabled = False
            RemoveItemButton.Enabled = False


            Dim NewItemIndex As Integer
            Try
                NewItemIndex = ListView1.SelectedIndices(0)
            Catch
            End Try

            If SearchMode = True Then
                NewItemIndex = SearchIncomeArray(NewItemIndex + 1).RealItemLocation
            End If

            Dim I As Integer

            For I = NewItemIndex To IncomeregistryArray.Count - 2
                IncomeregistryArray(I) = IncomeregistryArray(I + 1)
            Next

            ReDim Preserve IncomeregistryArray(IncomeregistryArray.Count - 2)

            RePopulateListView()
        End If


    End Sub

    Private Sub EZTaxMain_Load(sender As Object, e As EventArgs) Handles Me.Shown
        Dim ourTaxCalc As TaxCalc = New TaxCalc
        EZTaxSplash.Show()
        SearchMode = False
        IncomeregistryArray = Nothing
        ID = VibeLogin.LogonID.Text
        Category = VibeMainScreen.Category
        MoveWarning = False
        InitialBW.RunWorkerAsync()

        DetailsButton.Enabled = False
        ModifyItemButton.Enabled = False
        RemoveItemButton.Enabled = False
    End Sub

    Private Sub InitialBW_DoWork(sender As Object, e As DoWorkEventArgs) Handles InitialBW.DoWork

        Threading.Thread.Sleep(250)

        InitializationResult = 0

        'Try to access the IncomeRegistry

        IWStatus = "Opening File..."
        InitialBW.ReportProgress(1)

        Try

            If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & ID & ".IncomeRegistry.csv") Then
                'Flag that we moved stuff
                MoveWarning = True

                'if the directory does not exist, make it
                If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX") Then Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX")

                'move the coso
                File.Move(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & ID & ".IncomeRegistry.csv", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & ID & ".IncomeRegistry.csv")
            End If
            'Open the file
            FileOpen(1, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & ID & ".IncomeRegistry.csv", OpenMode.Input)
        Catch EE As Exception
            Console.Write(EE.ToString)
            InitializationResult = 2
            GoTo LabelNoDownload
        End Try

        IWStatus = "Preparing to Process..."
        InitialBW.ReportProgress(2)

        Dim I As Integer = 0
        Dim RecordsAdded As Boolean
        Dim currentline() As String
        RecordsAdded = False

        While Not EOF(1)
            IWStatus = "Processing Record " & I
            InitialBW.ReportProgress(I)

            RecordsAdded = True

            ReDim Preserve IncomeregistryArray(I)

            currentline = LineInput(1).Split(",")

            If currentline.Count = 2 Then
                'Legacy item
                IncomeregistryArray(I) = New IncomeRegistryItem(currentline(0), currentline(1))
            Else
                'New Item

                Dim CurrentName As String = currentline(0)
                Dim CurrentApartmentDetails As ApartmentDetails = New ApartmentDetails(currentline(2), currentline(3), currentline(4), currentline(5), currentline(6), currentline(7), currentline(8), currentline(9), currentline(10), currentline(11))
                Dim CurrentHotelDetails As HotelDetails = New HotelDetails(currentline(12), currentline(13), currentline(14), currentline(15), currentline(16))
                Dim CurrentBusinessDetails As BusinessDetails = New BusinessDetails(currentline(17), currentline(18), currentline(19), currentline(20))
                Dim CurrentMiscIncome As Long = currentline(21)
                Dim CurrentLocation As String = currentline(22)

                IncomeregistryArray(I) = New IncomeRegistryItem(CurrentName, CurrentApartmentDetails, CurrentHotelDetails, CurrentBusinessDetails, CurrentMiscIncome, CurrentLocation)

            End If

            I = I + 1
            Threading.Thread.Sleep(5)
        End While
        FileClose(1)

LabelNoDownload:

        'Retrieve Income
        Dim Servermsg As String
        Dim Incomes() As String

        IWStatus = "Retrieving Income From Server"
        InitialBW.ReportProgress(I)


        Servermsg = ServerCommand.RawCommand("EZTINF" & ID)
        If Servermsg = "E" Then
            MsgBox("There has been a serverside error. Please Contact CHOPO.", vbCritical, "EzTax cannot continue")
            Income = 0
            EI = 0
        Else
            EI = Servermsg.Split(",")(1)
        End If

        IWStatus = "Retrieving Income Breakdown"
        InitialBW.ReportProgress(I)
        Servermsg = ServerCommand.RawCommand("EZTBRK" & ID)
        If Servermsg = "E" Then
            MsgBox("There has been a serverside error. Please Contact CHOPO.", vbCritical, "EzTax cannot continue")
            ServerTaxInfo = New TaxInformation(EI, 0, 0, 0, 0, 0, 0, Category)
        Else
            Incomes = Servermsg.Split(",")
            ServerTaxInfo = New TaxInformation(EI, Incomes(0), Incomes(1), Incomes(2), Incomes(3), Incomes(4), Incomes(5), Category)
        End If

        Total = ServerTaxInfo.FederalIncome
        Tax = ServerTaxInfo.TotalTax

    End Sub

    Private Sub InitialBW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles InitialBW.RunWorkerCompleted

        IncomeLabel.Text = Income.ToString("N0") & "p"
        UpdatedLabel.Text = "0p"
        EILabel.Text = EI.ToString("N0") & "p"
        TotalLabel.Text = Total.ToString("N0") & "p"
        TaxDueLabel.Text = Tax.ToString("N0") & "p"

        If MoveWarning = True Then
            MsgBox("Your Income Registry file was successfully moved to the EzTAX Folder", MsgBoxStyle.Information, "EzTAX")
            MoveWarning = False
        End If


        Select Case InitializationResult

            Case 0

                Try
                    Dim AAAAAAAAAAAAAA As Integer = IncomeregistryArray.Count
                Catch
                    Exit Select
                End Try

                PopulateListview()

            Case 1
                MsgBox("It appears you no Income Registry file. A new one will be created when you add items", vbInformation, "No Income Registry File")
            Case 2
                MsgBox("It appears you no Income Registry file. A new one will be created when you add items", vbInformation, "No Income Registry File")
        End Select

        EZTaxSplash.Close()

    End Sub

    Private Sub InitialBW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles InitialBW.ProgressChanged
        EZTaxSplash.StatusLabel.Text = IWStatus
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        Dim Selectedindex As Integer

        Try
            Selectedindex = ListView1.SelectedIndices(0)
        Catch
            Exit Sub
        End Try

        Select Case SearchMode
            Case True
                Try
                    SelectedItem = SearchIncomeArray(ListView1.SelectedIndices(0) + 1)
                Catch
                End Try
            Case False
                Try
                    SelectedItem = IncomeregistryArray(ListView1.SelectedIndices(0))
                Catch
                End Try
        End Select

        DetailsButton.Enabled = True
        ModifyItemButton.Enabled = True
        RemoveItemButton.Enabled = True
    End Sub


    Private Sub EZTaxMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Me.Size = (New Drawing.Size(525, 390))

        Dim X As Integer = 525
        Dim y As Integer = 390

        While Not X < 15

            X = X - 10
            If Not y < 15 Then y = y - 10
            Me.Size = (New Drawing.Size(X, y))
            Threading.Thread.Sleep(3)

        End While


    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click
        Dim UpdateWindow As EzTaxUpdateIncome = New EzTaxUpdateIncome With {
            .AllIncomeItems = IncomeregistryArray
        }

        Hide()
        UpdateWindow.ShowDialog()
        Show()

    End Sub

    ''' <summary>
    ''' Populate the listview
    ''' </summary>
    ''' <param name="SearchItem"> find this item or items containing this </param>
    Public Sub PopulateListview(Optional ByVal SearchItem As String = "")


        Dim I As Integer
        Dim Hits As Integer
        IRTI = 0
        Hits = 0

        Dim NewpondIncome As Long = 0
        Dim UrbiaIncome As Long = 0
        Dim ParadisusIncome As Long = 0
        Dim LaertesIncome As Long = 0
        Dim NOIncome As Long = 0
        Dim SOIncome As Long = 0


        'Set up Listview
        ListView1.Clear()
        ListView1.View = View.Details
        ListView1.Columns.Add("Name")
        ListView1.Columns.Item(0).Width = 340
        ListView1.Columns.Add("Income")
        ListView1.Columns.Item(1).Width = 150
        ListView1.MultiSelect = False
        ListView1.FullRowSelect = True
        ListView1.HideSelection = False

        FileOpen(2, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & ID & ".IncomeRegistry.csv", OpenMode.Output)

        For I = 0 To IncomeregistryArray.Count - 1

            Dim CLVI As ListViewItem
            EZTaxSplash.StatusLabel.Text = "Adding Record " & I & " out of " & IncomeregistryArray.Count - 1 & "To Listbox"

            If Not SearchItem = "" Then
                'For Searching
                If IncomeregistryArray(I).Name.ToLower.Contains(SearchItem.ToLower) Then
                    CLVI = New ListViewItem With {
                .Text = IncomeregistryArray(I).Name
            }
                    CLVI.SubItems.Add(IncomeregistryArray(I).TotalIncome.ToString("N0") & "p")
                    ListView1.Items.Add(CLVI)
                    Hits = Hits + 1
                    HitsCounter(Hits)

                    ReDim Preserve SearchIncomeArray(Hits)
                    SearchIncomeArray(Hits) = New IncomeRegistryItem(IncomeregistryArray(I))
                    SearchIncomeArray(Hits).RealItemLocation = I


                End If
            Else
                'For Regular
                CLVI = New ListViewItem With {
                .Text = IncomeregistryArray(I).Name
            }
                CLVI.SubItems.Add(IncomeregistryArray(I).TotalIncome.ToString("N0") & "p")
                ListView1.Items.Add(CLVI)
                Hits = Hits + 1
                HitsCounter(Hits)
            End If

            'Save the item
            PrintLine(2, IncomeregistryArray(I).Name & "," & IncomeregistryArray(I).TotalIncome & "," & IncomeregistryArray(I).Apartment.StudioUnits & "," & IncomeregistryArray(I).Apartment.BR1Units & "," & IncomeregistryArray(I).Apartment.BR2Units & "," & IncomeregistryArray(I).Apartment.BR3Units & "," & IncomeregistryArray(I).Apartment.PHUnits & "," & IncomeregistryArray(I).Apartment.StudioRent & "," & IncomeregistryArray(I).Apartment.BR1Rent & "," & IncomeregistryArray(I).Apartment.BR2Rent & "," & IncomeregistryArray(I).Apartment.BR3Rent & "," & IncomeregistryArray(I).Apartment.PHRent & "," & IncomeregistryArray(I).Hotel.Rooms & "," & IncomeregistryArray(I).Hotel.Suites & "," & IncomeregistryArray(I).Hotel.RoomRate & "," & IncomeregistryArray(I).Hotel.SuiteRate & "," & IncomeregistryArray(I).Hotel.MiscIncome & "," & IncomeregistryArray(I).Business.Chairs & "," & IncomeregistryArray(I).Business.AvgSpend & "," & IncomeregistryArray(I).Business.CustomersPerHour & "," & IncomeregistryArray(I).Business.HoursOpen & "," & IncomeregistryArray(I).MiscIncome & "," & IncomeregistryArray(I).Location)

            IRTI = IRTI + IncomeregistryArray(I).TotalIncome

            Dim Current As IncomeRegistryItem = IncomeregistryArray(I)

            Select Case Current.Location.ToUpper
                Case "NEWPOND"
                    NewpondIncome += Current.TotalIncome
                Case "URBIA"
                    UrbiaIncome += Current.TotalIncome
                Case "PARADISUS"
                    ParadisusIncome += Current.TotalIncome
                Case "LAERTES"
                    LaertesIncome += Current.TotalIncome
                Case "NORTH OSTEN"
                    NOIncome += Current.TotalIncome
                Case "SOUTH OSTEN"
                    SOIncome += Current.TotalIncome
                Case Else
            End Select

        Next

        FileClose(2)

        UpdatedLabel.Text = IRTI.ToString("N0") & "p"
        UpdatedTotal = IRTI + EI

        LocalTaxInfo = New TaxInformation(EI, NewpondIncome, UrbiaIncome, ParadisusIncome, LaertesIncome, NOIncome, SOIncome, Category)

        UpdatedTaxDue = LocalTaxInfo.TotalTax

        UpdatedTotalLabel.Text = UpdatedTotal.ToString("N0") & "p"
        UpdatedTaxDueLabel.Text = UpdatedTaxDue.ToString("N0") & "p"
        If Hits = 0 Then HitsCounter(0)

    End Sub

    Public Sub HitsCounter(hits As Integer)
        If hits = 1 Then
            HitLabel.Text = "1 entry"
        Else
            HitLabel.Text = hits & " entries"
        End If
    End Sub

    Public Sub RePopulateListView() Handles SearchBox.TextChanged
        If Not SearchBox.Text = "" Then
            PopulateListview(SearchBox.Text)
            SearchMode = True
        Else
            PopulateListview()
            SearchMode = False
        End If
    End Sub

    Private Sub EzTaxLogoClick() Handles EzTaxLogo.Click
        Hide()
        EzTaxAbout.ShowDialog()
        Show()
    End Sub
    Private Sub QuitIt() Handles Quit.Click
        Close()
    End Sub

    Private Sub TaxBreakdownLink_LinkClicked() Handles TaxBreakdownLink.LinkClicked
        Dim THEBIGBOI As EzTaxBreakdown = New EzTaxBreakdown With {
         .LocalInformation = LocalTaxInfo,
         .ServerInformation = ServerTaxInfo
        }

        Hide()
        THEBIGBOI.ShowDialog()
        Show()


    End Sub
End Class