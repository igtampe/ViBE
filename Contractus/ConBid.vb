''' <summary>Form to file a contractus bid</summary>
Public Class ConBid

    '--------------------------------[Variables]--------------------------------

    Private ReadOnly MyUser As User
    Private ReadOnly MyContract As Contract

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(User As User, Contract As Contract)
        InitializeComponent()
        MyUser = User
        MyContract = Contract
    End Sub

    Private Sub LoadingTime() Handles Me.Load
        BidValue.Minimum = 0
        If MyContract.TopBid = -1 Then
            BidValue.Maximum = 2 ^ 32
        Else
            BidValue.Maximum = MyContract.TopBid - 1
            BidValue.Value = MyContract.TopBid - 1
        End If

    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub PlaceBid() Handles PlaceBidBTN.Click

        If BidValue.Value = -1 Then
            MsgBox("Cannot bid any lower!", vbCritical)
            Close()
        End If

        Select Case AddBid(MyContract.ID, BidValue.Value, MyUser.ID, MyUser.Username)
            Case "S"
                MsgBox("Successfully placed a bid", vbInformation)
                Close()
            Case "E"
                MsgBox("A Serverside error occurred", vbInformation)
        End Select
    End Sub

    Private Sub Nevermind() Handles CancelBTN.Click
        Close()
    End Sub

End Class