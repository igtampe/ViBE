Imports VIBE__But_on_Visual_Studio_.CoreCommands

Public Class CertificationWindow

    Public Servermsg As String
    Public Certify As String


    Private Sub ClickOKtoOK_Click(sender As Object, e As EventArgs) Handles ClickOKtoOK.Click
        Close()
    End Sub

    Private Sub CertificationWindow_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Application.OpenForms().OfType(Of SendMonet).Any Then

            If SendMonet.UMSNBRButton.Checked = True Then
                PictureBox1.Image = My.Resources.UMSNB
            ElseIf SendMonet.GBANKRbutton.Checked = True Then
                PictureBox1.Image = My.Resources.GBANK
            ElseIf SendMonet.RIVERRButton.Checked = True Then
                PictureBox1.Image = My.Resources.Riverside
            End If
            Label3.Visible = False
            Label3.Text = "[" & DateTime.Now & "]" & vbNewLine & VibeLogin.LogonID.Text & " ~vibed~ " & SendMonet.AmountBox.Value.ToString("N0") & "p to " & SendMonet.DestinationBox.Text
            Certify = "[" & DateTime.Now & "] " & VibeLogin.LogonID.Text & " ~vibed~ " & SendMonet.AmountBox.Value.ToString("N0") & "p to " & SendMonet.DestinationBox.Text
            '[1/2/2019 1:37:29 AM] 57765 ~vibed~ 12000000p to 33118\UMSNB

        Else
            'From BankWindow
            PictureBox1.Image = BankWindow.PictureBox1.Image
            Label3.Visible = False
            Label3.Text = BankWindow.Selected.Text.Replace("] ", "]" & vbNewLine).Replace("You", VibeLogin.LogonID.Text)
            Certify = BankWindow.Selected.Text.Replace("You", VibeLogin.LogonID.Text)

        End If

        PictureBox2.Image = My.Resources.VibeLoad

        Label1.Text = "Certifying..."
        Label2.Text = "Your payment is being certified..."


        ClickOKtoOK.Visible = False

        'Your payment was certified
        'Your payment was successfully certified:
        'label3=(The Item)




    End Sub

    Private Sub GetTheWatermelon() Handles Me.Shown
        BackgroundWorker1.RunWorkerAsync()
    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Servermsg = CoreCommands.Certify(Certify)

    End Sub

    Private Sub Woopdiedooitsdone() Handles BackgroundWorker1.RunWorkerCompleted

        Select Case Servermsg
            Case "S"
                Label1.Text = "Your payment was certified"
                Label2.Text = "Your payment was successfully certified:"
                Label3.Visible = True
                ClickOKtoOK.Visible = True
                PictureBox2.Image = My.Resources.p

                WaitForRender.RunWorkerAsync()

            Case "E"
                MsgBox("The Lemon tried to certify a transaction at the same time you did, so we had to stop the certification system. Don't worry, it should work now, but if it doesn't please contact CHOPO.", MsgBoxStyle.Critical, "Please Help")
                Close()
        End Select

    End Sub

    Private Sub WaitForRender_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles WaitForRender.DoWork
        Threading.Thread.Sleep(50)
    End Sub

    Sub OKTakeTheScreenshotpls() Handles WaitForRender.RunWorkerCompleted
        ScreenCamera.TakeScreenshot(Width, Height, Location.X, Location.Y, Size)
    End Sub

End Class