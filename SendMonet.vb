''' <summary>Form to handle a SendMoney request</summary>
Public Class SendMonet

    '--------------------------------[Variables]--------------------------------

    Public MyUser As User

    '--------------------------------[Initialization]--------------------------------

    ''' <summary>Creates A new window to file a send money request</summary>
    ''' <param name="User">User who will be sending the money</param>
    Public Sub New(User As User)
        InitializeComponent()
        MyUser = User

        UMSNBRButton.Enabled = MyUser.UMSNB
        GBANKRbutton.Enabled = MyUser.GBANK
        RIVERRButton.Enabled = MyUser.RIVER

        Text = "Send Money Form [" & MyUser.ToString & "]"

    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub Nevermind() Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub SendMoneyWithoutCertification() Handles SendWOCertBTN.Click
        SendMonetPlsIBegYou(False)
    End Sub

    Private Sub SendMoneyWithCertification() Handles SendWCertBTN.Click
        SendMonetPlsIBegYou(True)
    End Sub

    Private Sub SelectedUMSNB() Handles UMSNBRButton.CheckedChanged
        If UMSNBRButton.Checked Then
            BalanceLabel.Text = MyUser.UMSNBBalance.ToString("N0") & "p"
            AmountBox.Maximum = MyUser.UMSNBBalance
        End If
    End Sub

    Private Sub SelectedGBANK() Handles GBANKRbutton.CheckedChanged
        If GBANKRbutton.Checked = True Then
            BalanceLabel.Text = MyUser.GBANKBalance.ToString("N0") & "p"
            AmountBox.Maximum = MyUser.GBANKBalance
        End If
    End Sub

    Private Sub SelectedRIVER() Handles RIVERRButton.CheckedChanged
        If RIVERRButton.Checked = True Then
            BalanceLabel.Text = MyUser.RIVERBalance.ToString("N0") & "p"
            AmountBox.Maximum = MyUser.RIVERBalance
        End If
    End Sub

    ''' <summary>Summons a directory window that'll help the user in filling out the destination field</summary>
    Private Sub GetUserFromDirectory() Handles DirectoryButton.Click
        Dim SendMoneyDirWindow As DirWindow = New DirWindow(DirWindow.DirectoryMode.SendMoney)
        SendMoneyDirWindow.ShowDialog()

        If SendMoneyDirWindow.Commit Then DestinationBox.Text = SendMoneyDirWindow.MyReturn
    End Sub

    '--------------------------------[The Actual SendMoney operation]--------------------------------

    ''' <summary>Sends the monet if it can. </summary>
    ''' <param name="PlsCertify">Specifies if this has to be certified or not</param>
    Private Sub SendMonetPlsIBegYou(Optional PlsCertify As Boolean = False)

        Dim Destination As String = DestinationBox.Text
        Dim Amount As Long = AmountBox.Value
        Dim fromBank As String = "NO"
        Dim fromBankImage As Image = My.Resources.LemonInvest1
        Dim ServerMSG As String

        'Get Bank
        If UMSNBRButton.Checked Then
            fromBank = "UMSNB"
            fromBankImage = My.Resources.UMSNB

        ElseIf GBANKRbutton.Checked Then
            fromBank = "GBANK"
            fromBankImage = My.Resources.GBANK

        ElseIf RIVERRButton.Checked Then
            fromBank = "RIVER"
            fromBankImage = My.Resources.Riverside
        Else
            MsgBox("Please select an origin", vbCritical, "Couldn't send money")
            Return
        End If

        'verify the destination is a propper one
        If Not Destination.Count = 11 Then
            MsgBox("Destination isn't formatted properly", vbCritical, "Couldn't send money")
        End If


        'Ask the server to send it
        'SM57174\UMSNB33118\UMSNB5000
        ServerMSG = SM(MyUser.ID + "\" + fromBank, Destination, Amount)
        Select Case ServerMSG
            Case "1"
                MsgBox("Improperly Coded Vibing Request", vbInformation, "Transfer unsuccessful")
            Case "E"
                MsgBox("The Lemon tried to divert the funds, and we stopped him. Unfortunately, this means the transaction was unable to be completed. If this continues to happen please contact CHOPO.", vbInformation, "Transfer unsuccessful")
            Case "S"
                If PlsCertify Then

                    'Certify
                    Dim CertWindow As CertificationWindow = New CertificationWindow(fromBankImage, "[" & DateTime.Now & "] " & VibeLogin.LogonID.Text & " ~vibed~ " & AmountBox.Value.ToString("N0") & "p to " & DestinationBox.Text)
                    CertWindow.ShowDialog()

                Else

                    'Just give a nice little msgbox
                    MsgBox("Successfully ~vibed~ " & Amount & "p to " & Destination & ".", vbInformation, "Transfer Successful")

                End If

                'Ask the ViBE Mainscreen to refresh.
                VibeMainScreen.RefreshMe()
                Close()

        End Select

    End Sub

End Class