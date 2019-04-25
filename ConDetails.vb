Public Class ConDetails
    Public ContractID As Integer
    Public ContractDetails As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PlaceBidBTN.Click
        ConBid.ShowDialog()
    End Sub

    Sub HelloDetailsTime() Handles Me.Shown
        NameTXB.Text = ""
        DetailsTXB.Text = ""
        RefreshNotice.Show()
        LoadDetails.RunWorkerAsync()

    End Sub


    Private Sub ConDetails_Load(sender As Object, e As EventArgs) Handles Me.Load

        If ConMain.DetailsMode = 0 Then
            'Available
            NameTXB.Text = ConMain.AllContracts(ConMain.SelectedAvailableContract).Name
            FromLBL.Text = ConMain.AllContracts(ConMain.SelectedAvailableContract).FromName & " (" & ConMain.AllContracts(ConMain.SelectedAvailableContract).FromID & ")"

            If ConMain.AllContracts(ConMain.SelectedAvailableContract).TopBid = -1 Then
                TopBidLBL.Text = " - "
                TopBidderLBL.Text = " - "
            Else
                TopBidLBL.Text = ConMain.AllContracts(ConMain.SelectedAvailableContract).TopBid
                TopBidderLBL.Text = ConMain.AllContracts(ConMain.SelectedAvailableContract).TopBidName & " (" & ConMain.AllContracts(ConMain.SelectedAvailableContract).TopBidID & ")"
            End If
            ContractID = ConMain.AllContracts(ConMain.SelectedAvailableContract).ID


            If ConMain.AllContracts(ConMain.SelectedAvailableContract).FromID = ConMain.UserID Then
                EndAuctionBTN.Visible = True
                PlaceBidBTN.Enabled = False

            Else
                EndAuctionBTN.Visible = False
                PlaceBidBTN.Enabled = True

            End If


        ElseIf ConMain.DetailsMode = 1 Then
            'Active
            NameTXB.Text = ConMain.UserContracts(ConMain.SelectedActiveContract).Name
            FromLBL.Text = ConMain.UserContracts(ConMain.SelectedActiveContract).FromName & " (" & ConMain.UserContracts(ConMain.SelectedActiveContract).FromID & ")"
            TopBidLBL.Text = ConMain.UserContracts(ConMain.SelectedActiveContract).TopBid
            TopBidderLBL.Text = ConMain.UserContracts(ConMain.SelectedActiveContract).TopBidName & " (" & ConMain.UserContracts(ConMain.SelectedActiveContract).TopBidID & ")"
            ContractID = ConMain.UserContracts(ConMain.SelectedActiveContract).ID

            EndAuctionBTN.Visible = False
            PlaceBidBTN.Enabled = False

        Else
            MsgBox("I have no idea what you want me to show the details of", vbInformation)
            Close()
        End If


    End Sub

    Private Sub LoadDetails_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadDetails.DoWork
        ContractDetails = ConMain.ServerCommand("CONDETAILS" & ContractID)

    End Sub
    Sub LoadDetailsDone() Handles LoadDetails.RunWorkerCompleted
        DetailsTXB.Text = ContractDetails
        RefreshNotice.Close()
    End Sub

    Private Sub EndAuctionBTN_Click(sender As Object, e As EventArgs) Handles EndAuctionBTN.Click
        Select Case MsgBox("Are you sure you wish to end the auction?", MsgBoxStyle.YesNo)
            Case DialogResult.Yes
                If ConMain.DetailsMode = 0 Then
                    'Available

                    'ContractID;User
                    Select Case ConMain.ServerCommand("CONMOVETOUSER" & ContractID & ";" & ConMain.AllContracts(ConMain.SelectedAvailableContract).FromID)
                        Case "E"
                            MsgBox("A serverside error occurred", vbInformation)
                        Case "S"
                            MsgBox(ConMain.AllContracts(ConMain.SelectedAvailableContract).FromID & " Has been awarded the contract. It is now in their active contracts, and they shall send you a bill upon its completion", vbInformation)
                            Close()
                    End Select

                Else
                    MsgBox("The lemon has prevented this transaction", vbInformation)
                    Close()
                End If
        End Select
    End Sub
End Class