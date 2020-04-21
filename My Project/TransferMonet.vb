''' <summary>Form that handles a transfer money request</summary>
Public Class TransferMonet

    '--------------------------------[Variables]--------------------------------
    Private ReadOnly MyUser As User


    '--------------------------------[Initialization]--------------------------------
    Public Sub New(User As User)
        InitializeComponent()
        MyUser = User

        UMSNBRButtonFROM.Enabled = MyUser.UMSNB
        GBANKRbuttonFROM.Enabled = MyUser.GBANK
        RIVERRButtonFROM.Enabled = MyUser.RIVER
        UMSNBRButtonTO.Enabled = MyUser.UMSNB
        GBANKRButtonTO.Enabled = MyUser.GBANK
        RIVERRButtonTO.Enabled = MyUser.RIVER

        Text &= " [" & MyUser.ToString & "]"

    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub Nevermind() Handles Button1.Click
        Close()
    End Sub

    ''' <summary>Actually  transfers the money</summary>
    Private Sub TransferTheMoney() Handles Button3.Click

        Dim ServerMSG As String

        'Grab FromBank
        Dim frombank As String
        If UMSNBRButtonFROM.Checked Then
            frombank = "UMSNB"
        ElseIf GBANKRbuttonFROM.Checked Then
            frombank = "GBANK"
        ElseIf RIVERRButtonFROM.Checked Then
            frombank = "RIVER"
        Else
            MsgBox("Please specify an origin", vbCritical, "Error in Transfer")
            Return
        End If

        'GetToBank
        Dim Tobank As String
        If UMSNBRButtonTO.Checked Then
            Tobank = "UMSNB"
        ElseIf GBANKRButtonTO.Checked Then
            Tobank = "GBANK"
        ElseIf RIVERRButtonTO.Checked Then
            Tobank = "RIVER"
        Else
            MsgBox("Please specify a Destination", vbCritical, "Error in Transfer")
            Return
        End If

        'Make sure we're not transfering to the same bank
        If Tobank = frombank Then
            MsgBox("Why on earth will you transfer money to the same account???", vbCritical, "Confusement")
            Return
        End If

        'Get the transfer amount
        Dim transferamount As Long
        transferamount = TransferAmountBox.Value


        'Transfer the money
        ServerMSG = TM(MyUser.ID, frombank, Tobank, transferamount)
        Select Case ServerMSG
            Case "1"
                MsgBox("Improperly Coded Vibing Request", vbInformation, "Transfer unsuccessful")
            Case "E"
                MsgBox("The Lemon tried to divert the funds, and we stopped him. Unfortunately, this means the transaction was unable to be completed. If this continues to happen please contact CHOPO.", vbInformation, "Transfer unsuccessful")
            Case "S"
                MsgBox("OK, Transfered " & transferamount & "p from " & frombank & " to " & Tobank & ".", vbInformation, "Transfer Successful")

                VibeMainScreen.RefreshMe()
                Close()
        End Select


    End Sub

    Private Sub UMSNBFromSelected() Handles UMSNBRButtonFROM.CheckedChanged
        If UMSNBRButtonFROM.Checked = True Then
            FromBalance.Text = MyUser.UMSNBBalance.ToString("N0") & "p"
            TransferAmountBox.Maximum = MyUser.UMSNBBalance
        End If
    End Sub

    Private Sub GBANKFromSelected() Handles GBANKRbuttonFROM.CheckedChanged
        If GBANKRbuttonFROM.Checked = True Then
            FromBalance.Text = MyUser.GBANKBalance.ToString("N0") & "p"
            TransferAmountBox.Maximum = MyUser.GBANKBalance
        End If
    End Sub

    Private Sub RIVERFromSelected() Handles RIVERRButtonFROM.CheckedChanged
        If RIVERRButtonFROM.Checked = True Then
            FromBalance.Text = MyUser.RIVERBalance.ToString("N0") & "p"
            TransferAmountBox.Maximum = MyUser.RIVERBalance
        End If
    End Sub

    Private Sub UMSNBToSelected() Handles UMSNBRButtonTO.CheckedChanged
        If UMSNBRButtonTO.Checked = True Then
            ToBalance.Text = MyUser.UMSNBBalance.ToString("N0") & "p"
        End If
    End Sub

    Private Sub GBANKToSelected() Handles GBANKRButtonTO.CheckedChanged
        If GBANKRButtonTO.Checked = True Then
            ToBalance.Text = MyUser.GBANKBalance.ToString("N0") & "p"
        End If
    End Sub

    Private Sub RiverToSelected() Handles RIVERRButtonTO.CheckedChanged
        If RIVERRButtonTO.Checked = True Then
            ToBalance.Text = MyUser.RIVERBalance.ToString("N0") & "p"
        End If
    End Sub
End Class