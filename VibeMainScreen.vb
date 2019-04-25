Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Net.Sockets



Public Class VibeMainScreen

    Public ServerMSG As String
    Public ID As String
    Public LogoutExit As Boolean = False
    Public Category As Integer
    Public Username As String

    Private Sub LoadValuesFromTemp() Handles Me.Shown
        Me.BackgroundImage = Nothing
        NameLabel.Text = ""
        AllButtonsEnabled(False)
        ID = VibeLogin.LogonID.Text
        Me.Text = "Visual Basic Economy (Build ID:" & VibeLogin.VVer & ")"
        RefreshNotice.Show()
        Call BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If File.Exists(System.Windows.Forms.Application.UserAppDataPath & "\ViBE\Login.dat") Then
            File.Delete(System.Windows.Forms.Application.UserAppDataPath & "\ViBE\Login.dat")
        End If

        LogoutExit = True

        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VibeChangePin.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TransferMonet.ShowDialog()
        Call RefreshButton_Click()



    End Sub

    Private Sub LaunchEzTax(Sender As Object, e As EventArgs) Handles EZTaxButton.Click
        EZTaxMain.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendMonet.ShowDialog()
        Call RefreshButton_Click()



    End Sub

    Private Sub ToQuitonQuit(sender As Object, e As EventArgs) Handles Me.Closing
        If LogoutExit = True Then
            VibeLogin.Show()
            VibeLogin.LogonID.Text = ""
            VibeLogin.LogonPIN.Text = ""
        Else

            VibeLogin.Close()

        End If

    End Sub

    Private Sub RefreshButton_Click() Handles RefreshButton.Click

        AllButtonsEnabled(False)
        RefreshNotice.Show()
        Call BackgroundWorker1.RunWorkerAsync()



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

        ServerMSG = ServerCommand("INFO" & ID)

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted


        Dim TotalBalance As Long

        Dim UMSNB As Boolean
        Dim GBANK As Boolean
        Dim RIVER As Boolean
        Dim UMSNBBalance As Long
        Dim GBANKBalance As Long
        Dim RIVERBalance As Long
        Dim SplitValues() As String




        SplitValues = ServerMSG.Split(",")

        If SplitValues(0) = 1 Then UMSNB = True Else UMSNB = False
        UMSNBBalance = SplitValues(1)
        If SplitValues(2) = 1 Then GBANK = True Else GBANK = False
        GBANKBalance = SplitValues(3)
        If SplitValues(4) = 1 Then RIVER = True Else RIVER = False
        RIVERBalance = SplitValues(5)
        Username = SplitValues(6)

        If Username.EndsWith(" (Corp.)") Then
            Category = 1
            Me.BackgroundImage = My.Resources.Corporate
            Username = Username.Replace(" (Corp.)", "")
        ElseIf Username.EndsWith(" (Gov.)") Then
            Me.BackgroundImage = My.Resources.Government
            Category = 2
            Username = Username.Replace(" (Gov.)", "")
        Else
            Me.BackgroundImage = Nothing
            Category = 0
        End If



        '111Igtampe

        'Username = ServerMSG.Remove(0, 3)

        'Processing = ServerMSG.Remove(1, 2 + Username.Length)
        'If Processing = "1" Then UMSNB = True Else UMSNB = False

        'Processing = ServerMSG.Remove(0, 1)
        'Processing = Processing.Remove(1, 1 + Username.Length)
        'If Processing = "1" Then GBANK = True Else GBANK = False

        'Processing = ServerMSG.Remove(0, 2)
        'Processing = Processing.Remove(1, Username.Length)
        'If Processing = "1" Then RIVER = True Else RIVER = False

        'If UMSNB = True Then UMSNBBalance = ServerCommand("UMSNB" & ID) Else UMSNBBalance = 0
        'If GBANK = True Then GBANKBalance = ServerCommand("GBANK" & ID) Else GBANKBalance = 0
        'If RIVER = True Then RIVERBalance = ServerCommand("RIVER" & ID) Else RIVERBalance = 0


        UMSNBCheck.Checked = UMSNB
        GBANKCheck.Checked = GBANK
        RIVERCheck.Checked = RIVER

        UMSNBBLabel.Text = UMSNBBalance.ToString("N0") & "p"
        GBANKBLabel.Text = GBANKBalance.ToString("N0") & "p"
        RIVERBLabel.Text = RIVERBalance.ToString("N0") & "p"

        TotalBalance = UMSNBBalance + GBANKBalance + RIVERBalance
        TotalBLabel.Text = TotalBalance.ToString("N0") & "p"

        NameLabel.Text = Username & " (" & ID & ")"

        RefreshNotice.Close()

        AllButtonsEnabled(True)
        If Category = 2 Then EZTaxButton.Enabled = False

        NotifButton.Text = SplitValues(7)
        If SplitValues(7) > 9 Then
            NotifButton.Font = New Font("Microsoft Sans Serif", 6)
        Else
            NotifButton.Font = New Font("Microsoft Sans Serif", 8)
        End If

        If SplitValues(7) = 0 Then
            NotifButton.Enabled = False
        Else
            NotifButton.Enabled = True
        End If

        If Not File.Exists(Application.UserAppDataPath & "\ViBE\WhatsNew.temp") Then
            WhatsNew.Show()
            File.Create(Application.UserAppDataPath & "\ViBE\WhatsNew.temp")
        End If

        Try
            VibeLogin.Hide()
        Catch
        End Try
    End Sub

    Private Sub UMSNBLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UMSNBLink.LinkClicked
        'UMSNB
        BANKTXB.Text = "UMSNB"
        BankWindow.ShowDialog()
        Call RefreshButton_Click()
    End Sub

    Private Sub GBANKLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GBANKLink.LinkClicked
        'GBANK
        BANKTXB.Text = "GBANK"
        BankWindow.ShowDialog()
        Call RefreshButton_Click()
    End Sub

    Private Sub RIVERLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RIVERLink.LinkClicked
        'RIVER
        BANKTXB.Text = "RIVER"
        BankWindow.ShowDialog()
        Call RefreshButton_Click()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        About.Show()
    End Sub

    Private Sub NotifButton_Click(sender As Object, e As EventArgs) Handles NotifButton.Click
        If NotifButton.Text = "0" Then
            MsgBox("There are no notifications, dummy!", vbInformation)
        Else
            NotificationsForm.ShowDialog()
            Call RefreshButton_Click()
        End If
    End Sub

    Private Sub LNDViewBTN_Click(sender As Object, e As EventArgs) Handles LNDViewBTN.Click
        LandView.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CheckbookMain.ShowDialog()
        Call RefreshButton_Click()
    End Sub

    Sub AllButtonsEnabled(Value As Boolean)

        RefreshButton.Enabled = Value
        Button1.Enabled = Value
        Button2.Enabled = Value
        Button3.Enabled = Value
        Button4.Enabled = Value
        Button5.Enabled = Value
        Button6.Enabled = Value
        EZTaxButton.Enabled = Value
        NotifButton.Enabled = Value
        LNDViewBTN.Enabled = Value
        RIVERLink.Enabled = Value
        UMSNBLink.Enabled = Value
        GBANKLink.Enabled = Value
        Button7.Enabled = Value

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ConMain.Show()

    End Sub

    Private Sub TakeScreenshot() Handles CaptureScreenshot.Click
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
End Class