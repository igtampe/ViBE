Imports VIBE__But_on_Visual_Studio_.CoreCommands
Public Class TransferMonet

    Public ID As String
    Public Username As String
    Public UMSNB As Boolean
    Public GBANK As Boolean
    Public RIVER As Boolean
    Public UMSNBBalance As Long
    Public GBANKBalance As Long
    Public RIVERBalance As Long

    Private Sub Somethingorotheridk() Handles Me.Load

        'Clear
        UMSNBRButtonFROM.Checked = False
        GBANKRbuttonFROM.Checked = False
        RIVERRButtonFROM.Checked = False
        UMSNBRButtonTO.Checked = False
        GBANKRButtonTO.Checked = False
        RIVERRButtonTO.Checked = False

        FromBalance.Text = "0p"
        ToBalance.Text = "0p"
        TransferAmountBox.Value = "0"



        ID = VibeLogin.LogonID.Text

        UMSNBRButtonFROM.Enabled = VibeMainScreen.UMSNBCheck.Checked
        GBANKRbuttonFROM.Enabled = VibeMainScreen.GBANKCheck.Checked
        RIVERRButtonFROM.Enabled = VibeMainScreen.RIVERCheck.Checked
        UMSNBRButtonTO.Enabled = VibeMainScreen.UMSNBCheck.Checked
        GBANKRButtonTO.Enabled = VibeMainScreen.GBANKCheck.Checked
        RIVERRButtonTO.Enabled = VibeMainScreen.RIVERCheck.Checked

        UMSNBBalance = VibeMainScreen.UMSNBBLabel.Text.TrimEnd("p")
        GBANKBalance = VibeMainScreen.GBANKBLabel.Text.TrimEnd("p")
        RIVERBalance = VibeMainScreen.RIVERBLabel.Text.TrimEnd("p")



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Read banks

        Dim ServerMSG As String

        Dim frombank As String
        frombank = "NO"
        If UMSNBRButtonFROM.Checked = True Then frombank = "UMSNB"
        If GBANKRbuttonFROM.Checked = True Then frombank = "GBANK"
        If RIVERRButtonFROM.Checked = True Then frombank = "RIVER"

        Dim Tobank As String
        Tobank = "NO"
        If UMSNBRButtonTO.Checked = True Then Tobank = "UMSNB"
        If GBANKRButtonTO.Checked = True Then Tobank = "GBANK"
        If RIVERRButtonTO.Checked = True Then Tobank = "RIVER"

        'Data Validation

        If Tobank = "NO" Then
            MsgBox("Please specify a Destination", vbCritical, "Error in Transfer")

        Else
            If frombank = "NO" Then
                MsgBox("Please specify an origin", vbCritical, "Error in Transfer")

            Else

                If Tobank = frombank Then

                    MsgBox("Why on earth will you transfer money to the same account???", vbCritical, "Confusement")

                Else

                    Dim transferamount As Long

                    transferamount = TransferAmountBox.Value

                    'TM57174UMSNBGBANK5000

                    ServerMSG = TM(ID, frombank, Tobank, transferamount)

                    Select Case ServerMSG
                        Case "1"
                            MsgBox("Improperly Coded Vibing Request", vbInformation, "Transfer unsuccessful")
                        Case "E"
                            MsgBox("The Lemon tried to divert the funds, and we stopped him. Unfortunately, this means the transaction was unable to be completed. If this continues to happen please contact CHOPO.", vbInformation, "Transfer unsuccessful")
                        Case "S"
                            MsgBox("OK, Transfered " & transferamount & "p from " & frombank & " to " & Tobank & ".", vbInformation, "Transfer Successful")
                            Close()
                    End Select

                End If

            End If

        End If

        'Call a logman to log it to both bank's logs

    End Sub

    Private Sub UMSNBRButtonFROM_CheckedChanged(sender As Object, e As EventArgs) Handles UMSNBRButtonFROM.CheckedChanged
        If UMSNBRButtonFROM.Checked = True Then
            FromBalance.Text = UMSNBBalance.ToString("N0") & "p"
            TransferAmountBox.Maximum = UMSNBBalance
        End If


    End Sub

    Private Sub GBANKRbuttonFROM_CheckedChanged(sender As Object, e As EventArgs) Handles GBANKRbuttonFROM.CheckedChanged
        If GBANKRbuttonFROM.Checked = True Then
            FromBalance.Text = GBANKBalance.ToString("N0") & "p"
            TransferAmountBox.Maximum = GBANKBalance
        End If

    End Sub

    Private Sub RIVERRButtonFROM_CheckedChanged(sender As Object, e As EventArgs) Handles RIVERRButtonFROM.CheckedChanged
        If RIVERRButtonFROM.Checked = True Then
            FromBalance.Text = RIVERBalance.ToString("N0") & "p"
            TransferAmountBox.Maximum = RIVERBalance
        End If

    End Sub

    Private Sub UMSNBRButtonTO_CheckedChanged(sender As Object, e As EventArgs) Handles UMSNBRButtonTO.CheckedChanged
        If UMSNBRButtonTO.Checked = True Then
            ToBalance.Text = UMSNBBalance.ToString("N0") & "p"
        End If
    End Sub

    Private Sub GBANKRButtonTO_CheckedChanged(sender As Object, e As EventArgs) Handles GBANKRButtonTO.CheckedChanged
        If GBANKRButtonTO.Checked = True Then
            ToBalance.Text = GBANKBalance.ToString("N0") & "p"
        End If
    End Sub

    Private Sub RIVERRButtonTO_CheckedChanged(sender As Object, e As EventArgs) Handles RIVERRButtonTO.CheckedChanged
        If RIVERRButtonTO.Checked = True Then
            ToBalance.Text = RIVERBalance.ToString("N0") & "p"
        End If
    End Sub
End Class