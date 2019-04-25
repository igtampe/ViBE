Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.Sockets

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

    Function ServerCommand(ByVal ClientMSG As String) As String

        Dim tc As TcpClient = New TcpClient()
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter
        Dim ServerMSG As String

        ServerMSG = "E"

        If ClientMSG = "" Then
            ServerCommand = "E"
            Exit Function
        End If

        Try
            tc.Connect(“Igtnet-w.ddns.net”, 757)
            'tc.Connect(“127.0.0.1”, 757)
            Exit Try

        Catch

            MsgBox("Unable to connect to the server.", MsgBoxStyle.Exclamation, "ViBE Error")
            VibeLogin.Show()
            Close()
            ServerCommand = "NOCONNECT"
            Exit Function

        End Try



        If tc.Connected = True Then
            ns = tc.GetStream
            br = New BinaryReader(ns)
            bw = New BinaryWriter(ns)

            bw.Write(ClientMSG)

            Try
                ServerMSG = br.ReadString()
            Catch
                MsgBox("Seems like the server might've crashed! Contact CHOPO!", MsgBoxStyle.Exclamation, "ViBE Error")
                VibeLogin.Show()
                Close()
                ServerCommand = "CRASH"
                Exit Function

            End Try


            tc.Close()

        End If



        ServerCommand = ServerMSG

    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Servermsg = ServerCommand("CERT" & Certify)

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

    Private Sub TakeScreenshot()
        Dim bmpScreenShot As Bitmap
        Dim gfxScreenshot As Graphics

        bmpScreenShot = New Bitmap(Width, Height, PixelFormat.Format32bppArgb)

        gfxScreenshot = Graphics.FromImage(bmpScreenShot)
        gfxScreenshot.CopyFromScreen(Location.X, Location.Y, 0, 0, Size, CopyPixelOperation.SourceCopy)
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\ViBEScrSHT.png") Then File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\ViBEScrSHT.png")
        bmpScreenShot.Save(My.Computer.FileSystem.SpecialDirectories.Temp & "\ViBEScrSHT.png", ImageFormat.Png)

        Dim Coso As Image
        Coso = Image.FromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\ViBEScrSHT.png")
        My.Computer.Clipboard.SetImage(Coso)
        Coso.Dispose()
        ClipboardNotice.Show()
    End Sub

    Private Sub WaitForRender_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles WaitForRender.DoWork
        Threading.Thread.Sleep(50)
    End Sub

    Sub OKTakeTheScreenshotpls() Handles WaitForRender.RunWorkerCompleted
        TakeScreenshot()
    End Sub

End Class