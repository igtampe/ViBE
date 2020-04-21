''' <summary>Shows details for a Contractus Contract</summary>
Public Class ConDetails

    '--------------------------------[Variables]--------------------------------

    Private ReadOnly MyUser As User
    Private ReadOnly MyContract As Contract
    Private ReadOnly FormMode As DetailsFormMode
    Private ContractDetails As String

    Public Enum DetailsFormMode
        Available = 0
        Active = 1
    End Enum

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(User As User, Contract As Contract, FormMode As DetailsFormMode)
        InitializeComponent()
        MyUser = User
        MyContract = Contract
        Me.FormMode = FormMode

        NameTXB.Text = ""
        DetailsTXB.Text = ""

    End Sub

    Private Sub LoadingTime() Handles Me.Load

        NameTXB.Text = MyContract.Name
        FromLBL.Text = MyContract.FromName & " (" & MyContract.FromID & ")"

        If MyContract.TopBid = -1 Then
            TopBidLBL.Text = " - "
            TopBidderLBL.Text = " - "
        Else
            TopBidLBL.Text = MyContract.TopBid
            TopBidderLBL.Text = MyContract.TopBidName & " (" & MyContract.TopBidID & ")"
        End If

        If FormMode = DetailsFormMode.Available Then
            'Available
            EndAuctionBTN.Visible = (MyContract.FromID = MyUser.ID)
            PlaceBidBTN.Enabled = Not (MyContract.FromID = MyUser.ID)

        Else
            'Active
            EndAuctionBTN.Visible = False
            PlaceBidBTN.Enabled = False
        End If


    End Sub

    Sub HelloDetailsTime() Handles Me.Shown
        RefreshNotice.Show()
        LoadDetails.RunWorkerAsync()
    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub ClickOKtoOk() Handles OKBtn.Click
        Close()
    End Sub

    Private Sub PlaceBid() Handles PlaceBidBTN.Click
        Dim AddBid As ConBid = New ConBid(MyUser, MyContract)
        AddBid.ShowDialog()
        Close()
    End Sub

    Private Sub EndAuction() Handles EndAuctionBTN.Click

        If MsgBox("Are you sure you wish to end the auction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes And FormMode = DetailsFormMode.Available Then
            Select Case MoveToUser(MyContract.ID, MyContract.TopBidID)
                Case "E"
                    MsgBox("A serverside error occurred", vbInformation)
                Case "S"
                    MsgBox(MyContract.TopBidID & " Has been awarded the contract. It is now in their active contracts, and they shall send you a bill upon its completion", vbInformation)
                    Close()
            End Select
        Else
            MsgBox("The lemon has prevented this transaction", vbInformation)
        End If

    End Sub

    '--------------------------------[Background Worker]--------------------------------

    Private Sub GetDetails() Handles LoadDetails.DoWork
        ContractDetails = ContractusCommands.ConDetails(MyContract.ID)
    End Sub

    Sub GotDetails() Handles LoadDetails.RunWorkerCompleted
        DetailsTXB.Text = ContractDetails
        RefreshNotice.Close()
    End Sub

End Class