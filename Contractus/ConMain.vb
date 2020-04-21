Imports VIBE__But_on_Visual_Studio_.ContractusCommands

''' <summary>Main Contractus Form</summary>
Public Class ConMain

    '--------------------------------[Variables]--------------------------------

    Private AvailableContracts() As Contract
    Private ActiveContracts() As Contract
    Private ReadOnly MyUser As User

    Private InitialBWErrorStatus As Integer
    Private InitialBWStatus As Integer

    Private AllContractsExist As Boolean
    Private ActiveContractsExist As Boolean
    Private OpenContractsAmount As Integer
    Private ActiveContractsAmount As Integer

    Private SelectedAvailableContract As Integer
    Private SelectedActiveContract As Integer

    Private MySplash As ConSplash

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(User As User)
        InitializeComponent()
        MyUser = User
        AllButtonsEnabled(False)

        AvailableContracts = Nothing
        ActiveContractsExist = Nothing
        AllContractsExist = True
        ActiveContractsExist = True
        AcConLVIEW.Visible = True
        AvConLVIEW.Visible = True
        NameLabel.Text = MyUser.ToString
        AmountLabel.Text = ""

        MySplash = New ConSplash

    End Sub

    Private Sub LoadingTime() Handles Me.Shown
        MySplash.Show()
        InitialBW.RunWorkerAsync()

    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub AddContract_Click() Handles AddContract.Click
        Dim NewContractWindow As ConAdd = New ConAdd(MyUser)
        NewContractWindow.ShowDialog()
        RefreshAllContracts()
    End Sub

    Private Sub ClosingTime() Handles CloseButton.Click
        Close()
    End Sub

    Private Sub ShowAvailableContractDetails() Handles AvDetails.Click
        'Details (Available)
        Dim AvailableContractDetails As ConDetails = New ConDetails(MyUser, AvailableContracts(SelectedAvailableContract), ConDetails.DetailsFormMode.Available)
        AvailableContractDetails.ShowDialog()
        RefreshAllContracts()
    End Sub

    Private Sub ShowActiveContractDetails() Handles AcDetails.Click
        'Details (Active)
        Dim ActiveContractDetails As ConDetails = New ConDetails(MyUser, ActiveContracts(SelectedActiveContract), ConDetails.DetailsFormMode.Active)
        ActiveContractDetails.ShowDialog()
        RefreshAllContracts()
    End Sub

    Private Sub BiddingTime() Handles BidBTN.Click
        Dim AddBid As ConBid = New ConBid(MyUser, AvailableContracts(SelectedAvailableContract))
        AddBid.ShowDialog()
        RefreshAllContracts()
    End Sub

    ''' <summary>Handles the process of marking a contract as complete, and sending the bill for it.</summary>
    Private Sub SendBill() Handles SendBillBTN.Click

        If MsgBox("Are you sure you want to send a bill? This will mark your contract as complete!", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            'Hopefully this will send the bill
            Dim BillMaker As CheckbookOutbox = New CheckbookOutbox(MyUser, True, ActiveContracts(SelectedActiveContract).FromID, ActiveContracts(SelectedActiveContract).TopBid, ActiveContracts(SelectedActiveContract).Name)
            BillMaker.ShowDialog()

            If MsgBox("Are you sure you want to mark this contract as complete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Select Case RemoveContract(ActiveContracts(SelectedActiveContract).ID, MyUser.ID)
                    Case "E"
                        MsgBox("A serverside error occurred", MsgBoxStyle.Information)
                    Case "S"
                        MsgBox("Successfully removed this contract", MsgBoxStyle.Information)
                End Select

                RefreshAllContracts()

            End If

        End If

    End Sub

    Private Sub AvailableChanged() Handles AvConLVIEW.SelectedIndexChanged
        Try
            SelectedAvailableContract = AvConLVIEW.SelectedIndices(0)

            AvDetails.Enabled = True
            BidBTN.Enabled = True

        Catch
        End Try
    End Sub

    Private Sub ActiveChanged() Handles AcConLVIEW.SelectedIndexChanged
        Try
            SelectedActiveContract = AcConLVIEW.SelectedIndices(0)

            AcDetails.Enabled = True
            SendBillBTN.Enabled = True

        Catch
        End Try
    End Sub

    '--------------------------------[Background Worker]--------------------------------

    ''' <summary>Reports Progress to the splash</summary>
    Private Sub DoTheDoButLessSilently() Handles InitialBW.ProgressChanged

        Select Case InitialBWStatus
            Case 0
                MySplash.StatusLabel.Text = "Downloading all contracts"
            Case 30
                MySplash.StatusLabel.Text = "Parsing all contracts"
            Case 50
                MySplash.StatusLabel.Text = "Downloading user contracts"
            Case 80
                MySplash.StatusLabel.Text = "Parsing user contracts"
            Case 100
                MySplash.StatusLabel.Text = "Displaying"
            Case Else
                MySplash.StatusLabel.Text = "Dealing with The Lemon"
        End Select

    End Sub

    ''' <summary>Handles getting the contracts, silently</summary>
    Private Sub DoTheDoSilently() Handles InitialBW.DoWork

        'Clear out the form's data
        OpenContractsAmount = 0
        ActiveContractsAmount = 0
        InitialBWErrorStatus = 0
        InitialBWStatus = 0
        InitialBW.ReportProgress(0)

        'Get all Contracts
        Dim AVCMSG() = ReadAllContracts().Split(";")

        'Check input
        If AVCMSG(0) = "N" Then

            'No Contracts available
            AllContractsExist = False

        ElseIf AVCMSG(0) = "E" Then

            'Serverside error
            AllContractsExist = False
            InitialBWErrorStatus = 1
            Exit Sub

        Else

            'We have competent input, and we can parse them
            InitialBWStatus = 30
            InitialBW.ReportProgress(30)
            ReDim AvailableContracts(AVCMSG.Count - 1)

            For N = 0 To AVCMSG.Count - 1
                Dim CurrentItem() As String = AVCMSG(N).Split("~")
                AvailableContracts(N) = New Contract(CurrentItem(0), CurrentItem(1), CurrentItem(2), CurrentItem(3), CurrentItem(4), CurrentItem(5), CurrentItem(6))
                If AvailableContracts(N).FromID = MyUser.ID Then OpenContractsAmount += 1
            Next

        End If

        'Update Status
        InitialBWStatus = 50
        InitialBW.ReportProgress(50)

        'Get User contracts
        Dim ACCMSG() = ReadUserContracts(MyUser.ID).Split(";")

        'Check input
        If ACCMSG(0) = "N" Then

            'No user contracts
            ActiveContractsExist = False

        ElseIf ACCMSG(0) = "E" Then

            'Another error occurred
            ActiveContractsExist = False

            'Update BW error Status accordingly
            If InitialBWErrorStatus = 1 Then InitialBWErrorStatus = 3 Else InitialBWErrorStatus = 2

        Else

            'We have competent input. Parse it
            InitialBWStatus = 80
            InitialBW.ReportProgress(80)
            ReDim ActiveContracts(ACCMSG.Count - 1)
            ActiveContractsAmount = ACCMSG.Count

            For N = 0 To ACCMSG.Count - 1
                Dim CurrentItem() As String = ACCMSG(N).Split("~")
                ActiveContracts(N) = New Contract(CurrentItem(0), CurrentItem(1), CurrentItem(2), CurrentItem(3), CurrentItem(4), CurrentItem(5), CurrentItem(6))
            Next

        End If

        InitialBWStatus = 100
        InitialBW.ReportProgress(100)
    End Sub

    Private Sub DoAftertheDo() Handles InitialBW.RunWorkerCompleted

        'Check our 
        If InitialBWErrorStatus = 1 Then
            MsgBox("A server side error has occurred while retrieving the available contracts", MsgBoxStyle.Exclamation, "Oh no")
        ElseIf InitialBWErrorStatus = 2 Then
            MsgBox("A server side error has occurred while retrieving user contracts", MsgBoxStyle.Exclamation, "Oh no")
        ElseIf InitialBWErrorStatus = 3 Then
            MsgBox("A server side error has occurred while retrieving both contracts", MsgBoxStyle.Exclamation, "Oh no")
        End If

        Dim I As Integer

        'Clear Items
        AvConLVIEW.Items.Clear()
        AcConLVIEW.Items.Clear()

        'Enable all buttons
        AllButtonsEnabled(True)

        'Add all contracts
        If AllContractsExist Then

            For I = 0 To AvailableContracts.Count - 1

                'Create the LVI
                Dim CLVI As ListViewItem = New ListViewItem With {.Text = AvailableContracts(I).Name}
                CLVI.SubItems.Add(AvailableContracts(I).FromName)

                If AvailableContracts(I).TopBid = -1 Then
                    'A contract with no bids
                    CLVI.SubItems.Add(" - ")
                    CLVI.SubItems.Add(" - ")
                Else
                    'An Actual Contract
                    CLVI.SubItems.Add(AvailableContracts(I).TopBid)
                    CLVI.SubItems.Add(AvailableContracts(I).TopBidName)
                End If

                'Add the item
                AvConLVIEW.Items.Add(CLVI)
            Next

            AvConLVIEW.Visible = True
            AvConLVIEW.BringToFront()

        Else
            AvConLVIEW.Visible = False
        End If

        'Add Active Contracts
        If ActiveContractsExist Then

            For I = 0 To ActiveContracts.Count - 1

                'Create the LVI
                Dim CLVI As ListViewItem = New ListViewItem With {.Text = ActiveContracts(I).Name}
                CLVI.SubItems.Add(ActiveContracts(I).FromName)
                CLVI.SubItems.Add(ActiveContracts(I).TopBid)

                'Add the item
                AcConLVIEW.Items.Add(CLVI)
            Next
            AcConLVIEW.Visible = True
            AcConLVIEW.BringToFront()
        Else
            AcConLVIEW.Visible = False
        End If

        'Set up the form while no active or available contract is selected
        AvDetails.Enabled = False
        BidBTN.Enabled = False
        AcDetails.Enabled = False
        SendBillBTN.Enabled = False

        'Close the splash or the refreshNotice, if they're open
        MySplash.Close()
        RefreshNotice.Close()

        'Set the namelabel
        NameLabel.Text = MyUser.ToString
        AmountLabel.Text = ActiveContractsAmount & " active contracts and " & OpenContractsAmount & " open contracts"

    End Sub

    '--------------------------------[Other Functions]--------------------------------

    ''' <summary>Enable or disable all buttons</summary>
    Private Sub AllButtonsEnabled(Status As Boolean)
        AddContract.Enabled = Status
        CloseButton.Enabled = Status
        AvDetails.Enabled = Status
        AcDetails.Enabled = Status
        BidBTN.Enabled = Status
        SendBillBTN.Enabled = Status

        AvConLVIEW.Enabled = Status
        AcConLVIEW.Enabled = Status
    End Sub

    ''' <summary>Initiates the process to refresh contracts</summary>
    Private Sub RefreshAllContracts()
        RefreshNotice.Show()
        AvailableContracts = Nothing
        ActiveContractsExist = Nothing
        AllContractsExist = True
        ActiveContractsExist = True
        InitialBW.RunWorkerAsync()
    End Sub

End Class