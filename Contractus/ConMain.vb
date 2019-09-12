Imports System.IO

Public Class ConMain

    Public Structure ContractGroup
        Public ID As Integer
        Public Name As String
        Public FromName As String
        Public FromID As String
        Public TopBid As Long
        Public TopBidID As String
        Public TopBidName As String
    End Structure

    Public AllContracts() As ContractGroup
    Public UserContracts() As ContractGroup
    Public UserID As String
    Public UserName As String
    Public AllContractsExist As Boolean
    Public ActiveContractsExist As Boolean
    Public InitialBWErrorStatus As Integer
    Public InitialBWStatus As Integer
    Public OpenContractsAmount As Integer
    Public ActiveContractsAmount As Integer

    Public DetailsMode As Integer
    Public SelectedAvailableContract As Integer
    Public SelectedActiveContract As Integer



    Sub OKTimeToBootUp() Handles Me.Load
        UserID = VibeLogin.LogonID.Text
        UserName = VibeMainScreen.Username
        AllButtons(False)
        AllContracts = Nothing
        ActiveContractsExist = Nothing
        AllContractsExist = True
        ActiveContractsExist = True
        AcConLVIEW.Visible = True
        AvConLVIEW.Visible = True
        NameLabel.Text = VibeMainScreen.NameLabel.Text
        AmountLabel.Text = ""





    End Sub

    Private Sub ConMain_Load(sender As Object, e As EventArgs) Handles Me.Shown
        ConSplash.Show()
        InitialBW.RunWorkerAsync()

    End Sub

    Sub AllButtons(Status As Boolean)
        AddContract.Enabled = Status
        CloseButton.Enabled = Status
        AvDetails.Enabled = Status
        AcDetails.Enabled = Status
        BidBTN.Enabled = Status
        SendBillBTN.Enabled = Status

        AvConLVIEW.Enabled = Status
        AcConLVIEW.Enabled = Status

    End Sub

    Private Sub AddContract_Click(sender As Object, e As EventArgs) Handles AddContract.Click
        'Add Contract
        ConAdd.ShowDialog()
        RefreshAllContracts()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub AvDetails_Click(sender As Object, e As EventArgs) Handles AvDetails.Click
        'Details (Available)
        DetailsMode = 0
        ConDetails.ShowDialog()
        refreshAllContracts()
    End Sub

    Private Sub AcDetails_Click(sender As Object, e As EventArgs) Handles AcDetails.Click
        'Details (Active)
        DetailsMode = 1
        ConDetails.ShowDialog()
        refreshAllContracts()
    End Sub

    Private Sub BidBTN_Click(sender As Object, e As EventArgs) Handles BidBTN.Click
        ConBid.ShowDialog()
        refreshAllContracts()
    End Sub

    Private Sub SendBillBTN_Click(sender As Object, e As EventArgs) Handles SendBillBTN.Click
        Select Case MsgBox("Are you sure you want to send a bill? This will mark your contract as complete!", MsgBoxStyle.YesNo)
            Case DialogResult.Yes
                CheckbookOutbox.ShowDialog()
                If MsgBox("Are you sure you want to mark this contract as complete?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                    Select Case ServerCommand.ServerCommand("CONREMOVE" & UserContracts(SelectedActiveContract).ID & ";" & UserID)
                        Case "E"
                            MsgBox("A serverside error occurred", MsgBoxStyle.Information)
                        Case "S"
                            MsgBox("Successfully removed this contract", MsgBoxStyle.Information)
                    End Select
                    refreshAllContracts()

                End If



        End Select

        'Send Bill

    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs)
        'AboutWindow

    End Sub

    Sub refreshAllContracts()
        RefreshNotice.Show()
        AllContracts = Nothing
        ActiveContractsExist = Nothing
        AllContractsExist = True
        ActiveContractsExist = True
        InitialBW.RunWorkerAsync()
    End Sub

    Sub DoTheDoButLessSilently() Handles InitialBW.ProgressChanged

        Select Case InitialBWStatus
            Case 0
                ConSplash.StatusLabel.Text = "Downloading all contracts"
            Case 30
                ConSplash.StatusLabel.Text = "Parsing all contracts"
            Case 50
                ConSplash.StatusLabel.Text = "Downloading user contracts"
            Case 80
                ConSplash.StatusLabel.Text = "Parsing user contracts"
            Case 100
                ConSplash.StatusLabel.Text = "Displaying"
            Case Else
                ConSplash.StatusLabel.Text = "Dealing with The Lemon"
        End Select

    End Sub

    Private Sub DoTheDoSilently() Handles InitialBW.DoWork
        OpenContractsAmount = 0
        ActiveContractsAmount = 0
        InitialBWErrorStatus = 0
        InitialBWStatus = 0
        InitialBW.ReportProgress(0)
        Dim CurrentItem() As String
        Dim AVCMSG() = ServerCommand.ServerCommand("CONREADALL").Split(";")
        If AVCMSG(0) = "N" Then
            AllContractsExist = False
            GoTo NoContracts
        End If

        If AVCMSG(0) = "E" Then
            AllContractsExist = False
            InitialBWErrorStatus = 1
            GoTo NoMas
        End If

        InitialBWStatus = 30
        InitialBW.ReportProgress(30)
        ReDim AllContracts(AVCMSG.Count - 1)
        For N = 0 To AVCMSG.Count - 1
            CurrentItem = AVCMSG(N).Split("~")
            AllContracts(N).ID = CurrentItem(0)
            AllContracts(N).Name = CurrentItem(1)
            AllContracts(N).FromID = CurrentItem(2)

            If AllContracts(N).FromID = UserID Then
                OpenContractsAmount = OpenContractsAmount + 1
            End If

            AllContracts(N).FromName = CurrentItem(3)
            AllContracts(N).TopBid = CurrentItem(4)
            AllContracts(N).TopBidID = CurrentItem(5)
            AllContracts(N).TopBidName = CurrentItem(6)
        Next

NoContracts:
        InitialBWStatus = 50
        InitialBW.ReportProgress(50)
        Dim ACCMSG() = ServerCommand.ServerCommand("CONREADUSR" & UserID).Split(";")
        If ACCMSG(0) = "N" Then
            ActiveContractsExist = False
            GoTo NoMas
        End If

        If ACCMSG(0) = "E" Then
            ActiveContractsExist = False
            If InitialBWErrorStatus = 1 Then
                InitialBWErrorStatus = 3
            Else
                InitialBWErrorStatus = 2
            End If
        End If

        InitialBWStatus = 80
        InitialBW.ReportProgress(80)
        ReDim UserContracts(ACCMSG.Count - 1)
        ActiveContractsAmount = ACCMSG.Count
        For N = 0 To ACCMSG.Count - 1
            CurrentItem = ACCMSG(N).Split("~")
            UserContracts(N).ID = CurrentItem(0)
            UserContracts(N).Name = CurrentItem(1)
            UserContracts(N).FromID = CurrentItem(2)
            UserContracts(N).FromName = CurrentItem(3)
            UserContracts(N).TopBid = CurrentItem(4)
            UserContracts(N).TopBidID = CurrentItem(5)
            UserContracts(N).TopBidName = CurrentItem(6)
        Next

        InitialBWStatus = 100
        InitialBW.ReportProgress(100)
NoMas:
    End Sub

    Sub DoAftertheDo() Handles InitialBW.RunWorkerCompleted

        If InitialBWErrorStatus = 1 Then
            MsgBox("A server side error has occurred while retrieving the available contracts", MsgBoxStyle.Exclamation, "Oh no")
        End If
        If InitialBWErrorStatus = 2 Then
            MsgBox("A server side error has occurred while retrieving the available contracts", MsgBoxStyle.Exclamation, "Oh no")
        End If
        If InitialBWErrorStatus = 3 Then
            MsgBox("A server side error has occurred while retrieving both contracts", MsgBoxStyle.Exclamation, "Oh no")
        End If

        Dim I As Integer

        AvConLVIEW.Clear()
        AvConLVIEW.View = View.Details
        AvConLVIEW.Columns.Add("Name")
        AvConLVIEW.Columns.Item(0).Width = 185
        AvConLVIEW.Columns.Add("Posted By")
        AvConLVIEW.Columns.Item(1).Width = 60
        AvConLVIEW.Columns.Add("Lowest Bid")
        AvConLVIEW.Columns.Item(2).Width = 80
        AvConLVIEW.Columns.Add("Lowest Bidder")
        AvConLVIEW.Columns.Item(3).Width = 70
        AvConLVIEW.MultiSelect = False
        AvConLVIEW.FullRowSelect = True
        AvConLVIEW.HideSelection = False

        AcConLVIEW.Clear()
        AcConLVIEW.View = View.Details
        AcConLVIEW.Columns.Add("Name")
        AcConLVIEW.Columns.Item(0).Width = 185
        AcConLVIEW.Columns.Add("Posted By")
        AcConLVIEW.Columns.Item(1).Width = 60
        AcConLVIEW.Columns.Add("Amount")
        AcConLVIEW.Columns.Item(2).Width = 90
        AcConLVIEW.MultiSelect = False
        AcConLVIEW.FullRowSelect = True
        AcConLVIEW.HideSelection = False

        AllButtons(True)

        If AllContractsExist Then
            For I = 0 To AllContracts.Count - 1

                Dim CLVI As ListViewItem

                CLVI = New ListViewItem With {
                .Text = AllContracts(I).Name
            }
                CLVI.SubItems.Add(AllContracts(I).FromName)
                If AllContracts(I).TopBid = -1 Then
                    CLVI.SubItems.Add(" - ")
                    CLVI.SubItems.Add(" - ")
                Else
                    CLVI.SubItems.Add(AllContracts(I).TopBid)
                    CLVI.SubItems.Add(AllContracts(I).TopBidName)
                End If


                AvConLVIEW.Items.Add(CLVI)
            Next
            AvConLVIEW.Visible = True
            AvConLVIEW.BringToFront()
        Else
            AvConLVIEW.Visible = False

        End If


        If ActiveContractsExist Then
            For I = 0 To UserContracts.Count - 1

                Dim CLVI As ListViewItem

                CLVI = New ListViewItem With {
                .Text = UserContracts(I).Name
            }
                CLVI.SubItems.Add(UserContracts(I).FromName)
                CLVI.SubItems.Add(UserContracts(I).TopBid)
                AcConLVIEW.Items.Add(CLVI)
            Next
            AcConLVIEW.Visible = True
            AcConLVIEW.BringToFront()
        Else
            AcConLVIEW.Visible = False

        End If


        AvDetails.Enabled = False
        BidBTN.Enabled = False
        AcDetails.Enabled = False
        SendBillBTN.Enabled = False

        ConSplash.Close()

        NameLabel.Text = VibeMainScreen.NameLabel.Text
        AmountLabel.Text = ActiveContractsAmount & " active contracts and " & OpenContractsAmount & " open contracts"

        Try
            RefreshNotice.Close()
        Catch
        End Try


    End Sub

    Private Sub AvConLVIEW_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AvConLVIEW.SelectedIndexChanged
        Try
            SelectedAvailableContract = AvConLVIEW.SelectedIndices(0)
        Catch
            Exit Sub
        End Try

        AvDetails.Enabled = True
        BidBTN.Enabled = True

    End Sub

    Private Sub AcConLVIEW_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AcConLVIEW.SelectedIndexChanged
        Try
            SelectedActiveContract = AcConLVIEW.SelectedIndices(0)
        Catch
            Exit Sub
        End Try

        AcDetails.Enabled = True
        SendBillBTN.Enabled = True
    End Sub


End Class