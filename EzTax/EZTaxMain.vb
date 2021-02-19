Imports VIBE__But_on_Visual_Studio_.TaxCalc
Imports VIBE__But_on_Visual_Studio_.IncomeRegistryItem
Imports System.IO

Public Class EZTaxMain

    '--------------------------------[Variables]--------------------------------

    Private ReadOnly MyUser As User

    Private LocalTaxInfo As TaxInformation
    Private ServerTaxInfo As TaxInformation

    Private InitializationResult
    Private IWStatus As String

    Private SelectedItem As IncomeRegistryItem
    Private IncomeregistryArray() As IncomeRegistryItem
    Private SearchIncomeArray() As IncomeRegistryItem

    Private Calculator As TaxCalc

    ''' <summary>This has to do with the Move Warning about having moved your IRF</summary>
    Private MoveWarning As Boolean

    ''' <summary>Indicates wether we're in search mode</summary>
    Private SearchMode As Boolean

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(User As User)
        InitializeComponent()
        MyUser = User
        EzTaxTopLabel.Text &= " [" & MyUser.ToString & "]"
        Text &= " [" & MyUser.ToString & "]"
    End Sub

    Private Sub Showtime() Handles Me.Shown
        EZTaxSplash.Show()

        'Clear stuff (Primarily for when we reload)
        SearchMode = False
        IncomeregistryArray = Nothing
        MoveWarning = False

        ViewDetailsToolStripMenuItem.Enabled = False
        ModifyToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False

        InitialBW.RunWorkerAsync()

    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub Additem() Handles AddToolStripMenuItem.Click
        Dim AddWindow As EZTaxWizard = New EZTaxWizard(EZTaxWizard.Mode.Add)
        Hide()
        AddWindow.ShowDialog()
        Show()

        If AddWindow.commit Then AddToIncomeRegistry(AddWindow.MyItem)

        AddWindow.Dispose()

        SearchBox.Text = ""
        PopulateListview()

    End Sub

    Private Sub ItemDoubleClick() Handles ListView1.DoubleClick
        Try
            ModifyItem()
        Catch
        End Try
    End Sub

    Private Sub ShowDetails() Handles ViewDetailsToolStripMenuItem.Click
        Dim Detailswindow As EzTaxDetails = New EzTaxDetails(SelectedItem)
        Detailswindow.Show()
    End Sub

    Private Sub ModifyItem() Handles ModifyToolStripMenuItem.Click

        'Get the location of the item
        Dim NewItemIndex As Integer
        Try
            NewItemIndex = ListView1.SelectedIndices(0)
        Catch
            MsgBox("Please select an item", MsgBoxStyle.Critical, "EzTax")
            Exit Sub
        End Try

        'make sure to adjust it if we're searching
        If SearchMode = True Then
            NewItemIndex = SearchIncomeArray(NewItemIndex + 1).RealItemLocation
        End If

        'Get the window and show it
        Dim ModWindow As EZTaxWizard = New EZTaxWizard(EZTaxWizard.Mode.Modify, SelectedItem)
        Hide()
        ModWindow.ShowDialog()
        Show()

        'If it's time to commit, commit.
        If ModWindow.commit Then
            ModifyItemInIncomeRegistry(ModWindow.MyItem, NewItemIndex)
        End If

        ModWindow.Dispose()
        RePopulateListView()

    End Sub

    Private Sub RemoveItemButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim DeletePrompt = MsgBox("Are you sure you want to remove " & SelectedItem.Name & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EzTax")

        If DeletePrompt = MsgBoxResult.Yes Then
            ViewDetailsToolStripMenuItem.Enabled = False
            ModifyToolStripMenuItem.Enabled = False
            DeleteToolStripMenuItem.Enabled = False


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

    Private Sub UpdateIncome() Handles UpdateIncomeToolStripMenuItem.Click
        Dim UpdateWindow As EzTaxUpdateIncome = New EzTaxUpdateIncome(IncomeregistryArray, MyUser)
        UpdateWindow.ShowDialog()
    End Sub

    Private Sub ShowAbout() Handles EzTaxLogo.Click, AboutToolStripMenuItem.Click
        EzTaxAbout.Show()
    End Sub

    Private Sub QuitIt() Handles Quit.Click
        Close()
    End Sub

    Private Sub ShowBreakdown() Handles TaxBreakdownLink.LinkClicked
        Dim THEBIGBOI As EzTaxBreakdown = New EzTaxBreakdown(ServerTaxInfo, LocalTaxInfo)
        THEBIGBOI.Show()
    End Sub

    Private Sub UploadIRF() Handles UploadIRFToolStripMenuItem.Click
        Dim LBLBackupWindow As LBLSender = New LBLSender(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry.csv")
        LBLBackupWindow.Show()
    End Sub

    Private Sub DownloadTime() Handles DownloadIRFToolStripMenuItem.Click

        'Make sure the user wants to
        Dim result As MsgBoxResult = MsgBox("EzTax can attempt to download a copy of your IRF from the server. Are you sure you want to do this? It will overwrite your current file! (we'll keep a backup just in case)", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "EzTax")
        If result = MsgBoxResult.Yes Then

            'Try to download the file.
            Try
                If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry2.csv") Then File.Delete(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry2.csv")
                My.Computer.Network.DownloadFile("http://igtnet-w.ddns.net:100/uploadedreports/" & MyUser.ID & ".IncomeRegistry.csv", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry2.csv")
            Catch ex As Exception
                'Catch it just in case
                MsgBox("EzTax could not download your IRF. You probably haven't uploaded it!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "EzTax IRF Downloader")
                Debug.Print(ex.Message & vbNewLine & vbNewLine & ex.StackTrace)
                Return
            End Try

            'If the file exists
            If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry.csv") Then

                'Backup the original file
                File.Copy(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry.csv",
                          My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & " BACKUP BEFORE DOWNLOADING.IncomeRegistry.csv", True)

                'Overwrite the file
                File.Copy(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry2.csv",
                      My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry.csv", True)

                'Delete the temporary download file
                File.Delete(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry2.csv")

                'Do some reset stuff for show
                MsgBox("The IRF has been successfully downloaded. In order for changes to take effect, EzTax will now restart.", MsgBoxStyle.Information)
                Hide()
                Show()
                Showtime()

            End If
        End If
    End Sub

    Private Sub ShowAllBrackets() Handles LinkLabel1.LinkClicked
        Dim AllBracketWindow As EzTaxAllBrackets = New EzTaxAllBrackets(Calculator)
        AllBracketWindow.Show()
    End Sub

    Private Sub ClickedAnItem() Handles ListView1.SelectedIndexChanged

        Dim Selectedindex As Integer

        Try
            Selectedindex = ListView1.SelectedIndices(0)
        Catch
            Exit Sub
        End Try

        If SearchMode Then
            Try
                SelectedItem = SearchIncomeArray(ListView1.SelectedIndices(0) + 1)
            Catch
            End Try
        Else
            Try
                SelectedItem = IncomeregistryArray(ListView1.SelectedIndices(0))
            Catch
            End Try
        End If

        ViewDetailsToolStripMenuItem.Enabled = True
        ModifyToolStripMenuItem.Enabled = True
        DeleteToolStripMenuItem.Enabled = True
    End Sub

    '--------------------------------[Background Worker]--------------------------------

    Private Sub GetEverything() Handles InitialBW.DoWork

        InitializationResult = 0

        'Try to access the IncomeRegistry
        IWStatus = "Opening File..."
        InitialBW.ReportProgress(1)

        Try

            'If we find the file in the original directory, move it to the new directory
            If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & MyUser.ID & ".IncomeRegistry.csv") Then
                'Flag that we moved stuff
                MoveWarning = True

                'if the directory does not exist, make it
                If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX") Then Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX")

                'move the coso
                File.Move(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & MyUser.ID & ".IncomeRegistry.csv", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry.csv")
            End If

            'Open the file
            FileOpen(1, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry.csv", OpenMode.Input)

        Catch EE As Exception

            'oopsie
            Console.Write(EE.ToString)
            InitializationResult = 2
            GoTo LabelNoDownload

        End Try

        IWStatus = "Preparing to Process..."
        InitialBW.ReportProgress(2)

        Dim I As Integer = 0
        Dim RecordsAdded As Boolean = False
        Dim currentline() As String

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

            I += 1
            Threading.Thread.Sleep(5)
        End While
        FileClose(1)

LabelNoDownload:

        'Retrieve TaxInfo.TXT
        IWStatus = "Generating Tax Calculator..."
        InitialBW.ReportProgress(I)

        'Create the taxcalc if we have the file
        If File.Exists(Application.UserAppDataPath & "\ViBE\TaxInfo.txt") Then Calculator = New TaxCalc(Application.UserAppDataPath & "\ViBE\TaxInfo.txt")

        IWStatus = "Comparing with Server's Tax Database"
        InitialBW.ReportProgress(I)
        Dim LocalID As Integer = 0
        If Not IsNothing(Calculator) Then LocalID = Calculator.TaxInfoID

        'Check if the file is out of date
        If TaxFileOutOfDate(LocalID) Then

            'Download Tax File.
            IWStatus = "Out of date! Downloading Tax Database..."
            InitialBW.ReportProgress(I)

            If File.Exists(Application.UserAppDataPath & "\ViBE\TaxInfo.txt") Then File.Delete(Application.UserAppDataPath & "\ViBE\TaxInfo.txt")
            My.Computer.Network.DownloadFile("http://igtnet-w.ddns.net:100/TaxInfo.Txt", Application.UserAppDataPath & "\ViBE\TaxInfo.txt")

            IWStatus = "Regenerating Tax Calculator"
            InitialBW.ReportProgress(I)
            Calculator = New TaxCalc(Application.UserAppDataPath & "\ViBE\TaxInfo.txt")

        End If

        'Retrieve Income
        Dim Servermsg As String
        Dim Incomes() As String
        Dim EI As Long

        IWStatus = "Retrieving Income From Server"
        InitialBW.ReportProgress(I)

        'Get the legacy info just for EI.
        Servermsg = EzTaxCommands.TaxInfo(MyUser)
        If Servermsg = "E" Then
            MsgBox("There has been a serverside error. Please Contact CHOPO.", vbCritical, "EzTax cannot continue")
            EI = 0
        Else
            EI = Servermsg.Split(",")(1)
        End If

        'Get Income Breakdown
        IWStatus = "Retrieving Income Breakdown"
        InitialBW.ReportProgress(I)
        Servermsg = Breakdown(MyUser)

        'Parse it
        If Servermsg = "E" Then
            MsgBox("There has been a serverside error. Please Contact CHOPO.", vbCritical, "EzTax cannot continue")
            ServerTaxInfo = New TaxInformation(EI, 0, 0, 0, 0, 0, 0, MyUser.Category, Calculator)
        Else
            Incomes = Servermsg.Split(",")
            ServerTaxInfo = New TaxInformation(EI, Incomes(0), Incomes(1), Incomes(2), Incomes(3), Incomes(4), Incomes(5), MyUser.Category, Calculator)
        End If

    End Sub

    Private Sub GettingEverything() Handles InitialBW.ProgressChanged
        EZTaxSplash.StatusLabel.Text = IWStatus
    End Sub

    Private Sub GotEverything() Handles InitialBW.RunWorkerCompleted

        'Update the labels
        IncomeLabel.Text = (ServerTaxInfo.FederalIncome - ServerTaxInfo.ExtraIncome).ToString("N0") & "p"
        UpdatedLabel.Text = "0p"
        EILabel.Text = ServerTaxInfo.ExtraIncome.ToString("N0") & "p"
        TotalLabel.Text = ServerTaxInfo.FederalIncome.ToString("N0") & "p"
        TaxDueLabel.Text = ServerTaxInfo.TotalTax.ToString("N0") & "p"

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

    '--------------------------------[Other Functions]--------------------------------

    ''' <summary>Animates the window shrinking when closing</summary>
    Private Sub ClosingAnimation() Handles Me.Closing

        Size = New Size(525, 390)

        Dim X As Integer = 525
        Dim y As Integer = 390

        While Not X < 15

            X -= 10
            If Not y < 15 Then y -= 10
            Size = New Size(X, y)
            Threading.Thread.Sleep(3)

        End While


    End Sub

    Private Sub AddToIncomeRegistry(NewItem As IncomeRegistryItem)

        Dim NewItemIndex As Integer

        Try
            NewItemIndex = IncomeregistryArray.Count
        Catch
        End Try

        ReDim Preserve IncomeregistryArray(NewItemIndex)
        IncomeregistryArray(NewItemIndex) = NewItem

    End Sub

    Private Sub ModifyItemInIncomeRegistry(NewItem As IncomeRegistryItem, ItemIndex As Integer)
        IncomeregistryArray(ItemIndex) = NewItem
    End Sub

    ''' <summary>Populate the listview</summary>
    ''' <param name="SearchItem"> find this item or items containing this </param>
    Public Sub PopulateListview(Optional ByVal SearchItem As String = "")

        ViewDetailsToolStripMenuItem.Enabled = False
        ModifyToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False

        Dim I As Integer
        Dim Hits As Integer
        Dim IRTI As Long = 0
        Hits = 0

        'Totals
        Dim NewpondIncome As Long = 0
        Dim UrbiaIncome As Long = 0
        Dim ParadisusIncome As Long = 0
        Dim LaertesIncome As Long = 0
        Dim NOIncome As Long = 0
        Dim SOIncome As Long = 0


        'Clear Listview items
        ListView1.Items.Clear()

        'Open the IRF to save it
        FileOpen(2, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & MyUser.ID & ".IncomeRegistry.csv", OpenMode.Output)

        For I = 0 To IncomeregistryArray.Count - 1

            Dim CLVI As ListViewItem
            EZTaxSplash.StatusLabel.Text = "Adding Record " & I & " out of " & IncomeregistryArray.Count - 1 & "To Listbox"

            If Not String.IsNullOrEmpty(SearchItem) Then
                'For Searching
                If IncomeregistryArray(I).Name.ToLower.Contains(SearchItem.ToLower) Then

                    'Create the LVI
                    CLVI = New ListViewItem With {.Text = IncomeregistryArray(I).Name}
                    CLVI.SubItems.Add(IncomeregistryArray(I).TotalIncome.ToString("N0") & "p")

                    'Add the LVI
                    ListView1.Items.Add(CLVI)

                    'Update Hits
                    Hits += 1
                    HitsCounter(Hits)

                    'Add to the SearchIncome Directory
                    ReDim Preserve SearchIncomeArray(Hits)
                    SearchIncomeArray(Hits) = New IncomeRegistryItem(IncomeregistryArray(I)) With {.RealItemLocation = I}

                End If
            Else
                'For Regular

                'Create LVI
                CLVI = New ListViewItem With {.Text = IncomeregistryArray(I).Name}
                CLVI.SubItems.Add(IncomeregistryArray(I).TotalIncome.ToString("N0") & "p")

                'AddLVI
                ListView1.Items.Add(CLVI)

                'Update Hits
                Hits += 1
                HitsCounter(Hits)

            End If

            'Save the item
            PrintLine(2, IncomeregistryArray(I).Name & "," & IncomeregistryArray(I).TotalIncome & "," & IncomeregistryArray(I).Apartment.StudioUnits & "," & IncomeregistryArray(I).Apartment.BR1Units & "," & IncomeregistryArray(I).Apartment.BR2Units & "," & IncomeregistryArray(I).Apartment.BR3Units & "," & IncomeregistryArray(I).Apartment.PHUnits & "," & IncomeregistryArray(I).Apartment.StudioRent & "," & IncomeregistryArray(I).Apartment.BR1Rent & "," & IncomeregistryArray(I).Apartment.BR2Rent & "," & IncomeregistryArray(I).Apartment.BR3Rent & "," & IncomeregistryArray(I).Apartment.PHRent & "," & IncomeregistryArray(I).Hotel.Rooms & "," & IncomeregistryArray(I).Hotel.Suites & "," & IncomeregistryArray(I).Hotel.RoomRate & "," & IncomeregistryArray(I).Hotel.SuiteRate & "," & IncomeregistryArray(I).Hotel.MiscIncome & "," & IncomeregistryArray(I).Business.Chairs & "," & IncomeregistryArray(I).Business.AvgSpend & "," & IncomeregistryArray(I).Business.CustomersPerHour & "," & IncomeregistryArray(I).Business.HoursOpen & "," & IncomeregistryArray(I).MiscIncome & "," & IncomeregistryArray(I).Location)

            'Update the IncomeRegistry Local Total
            IRTI += IncomeregistryArray(I).TotalIncome

            'Update the totals for the respective district
            Select Case IncomeregistryArray(I).Location.ToUpper
                Case "NEWPOND"
                    NewpondIncome += IncomeregistryArray(I).TotalIncome
                Case "URBIA"
                    UrbiaIncome += IncomeregistryArray(I).TotalIncome
                Case "PARADISUS"
                    ParadisusIncome += IncomeregistryArray(I).TotalIncome
                Case "LAERTES"
                    LaertesIncome += IncomeregistryArray(I).TotalIncome
                Case "NORTH OSTEN"
                    NOIncome += IncomeregistryArray(I).TotalIncome
                Case "SOUTH OSTEN"
                    SOIncome += IncomeregistryArray(I).TotalIncome
            End Select

        Next

        'Close the file
        FileClose(2)

        'Update the label
        UpdatedLabel.Text = IRTI.ToString("N0") & "p"

        'Create local tax info
        LocalTaxInfo = New TaxInformation(ServerTaxInfo.ExtraIncome, NewpondIncome, UrbiaIncome, ParadisusIncome, LaertesIncome, NOIncome, SOIncome, MyUser.Category, Calculator)

        UpdatedTotalLabel.Text = (IRTI + ServerTaxInfo.ExtraIncome).ToString("N0") & "p"
        UpdatedTaxDueLabel.Text = LocalTaxInfo.TotalTax.ToString("N0") & "p"
        If Hits = 0 Then HitsCounter(0)

    End Sub

    Public Sub HitsCounter(hits As Integer)
        If hits = 1 Then HitLabel.Text = "1 entry" Else HitLabel.Text = hits & " entries"
    End Sub

    Public Sub RePopulateListView() Handles SearchBox.TextChanged
        If Not String.IsNullOrEmpty(SearchBox.Text) Then
            PopulateListview(SearchBox.Text)
            SearchMode = True
        Else
            PopulateListview()
            SearchMode = False
        End If
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
            Me.SetDesktopLocation(DX + MousePosition.X, DY + MousePosition.Y)
        End If
    End Sub

    Public Sub OktimeToStop() Handles EzTaxTopLabel.MouseUp
        WindowIsmoving = False
    End Sub

End Class