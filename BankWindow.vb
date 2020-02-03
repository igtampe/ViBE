Imports System.IO
Imports VIBE__But_on_Visual_Studio_.BankCommands
Public Class BankWindow

    Public Bank As String
    Public BankName As String
    Public BankBalance As Long
    Public ID As String
    Public ServerMSG As String
    Public LWorkerREsult As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not BankBalance = 0 Then
            MsgBox("Please empty your account. The Lemon may steal your funds if they're left without anywhere to go.", MsgBoxStyle.Critical, "No can do Chief")
            Exit Sub
        End If

        Dim Result As Integer = MsgBox("Are you sure you want to close your " & BankName & " account?", 32 + 4, "Question")
        If Result = 6 Then CloseAccountBW.RunWorkerAsync()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub BankWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button3.Enabled = False
        ID = VibeLogin.LogonID.Text
        Icon = VibeMainScreen.Icon
        Bank = "LEMON"
        Try
            Bank = VibeMainScreen.BANKTXB.Text
        Catch
        End Try

        Select Case Bank
            Case "UMSNB"
                BankName = "The UMS National Bank"
                PictureBox1.Image = My.Resources.UMSNB
                BankBalance = VibeMainScreen.UMSNBBLabel.Text.TrimEnd("p")
            Case "GBANK"
                BankName = "G-Bank"
                PictureBox1.Image = My.Resources.GBANK
                BankBalance = VibeMainScreen.GBANKBLabel.Text.TrimEnd("p")
            Case "RIVER"
                BankName = "Riverside Bank"
                PictureBox1.Image = My.Resources.Riverside
                BankBalance = VibeMainScreen.RIVERBLabel.Text.TrimEnd("p")
            Case Else
                BankName = "Lemon Investments"
        End Select
        Logbox.Items.Clear()



    End Sub

    Private Sub HeyImHere() Handles Me.Shown
        If BankExists(Bank) = False Then
            Dim Result As Integer = MsgBox("It appears you don't have a bank account with " & BankName & " open." & vbNewLine & "Would You like to open one now?", 32 + 4, "Question")
            Select Case Result
                Case 6
                    RefreshNotice.Show()
                    OpenAccountBW.RunWorkerAsync()
                    Exit Sub
                Case 7
                    Close()
                    Exit Sub
            End Select
        End If
        RefreshNotice.Show()
        LogBW.RunWorkerAsync()

    End Sub

    Function BankExists(Bank As String) As Boolean

        Select Case Bank
            Case "UMSNB"
                BankExists = VibeMainScreen.UMSNBCheck.Checked
            Case "GBANK"
                BankExists = VibeMainScreen.GBANKCheck.Checked
            Case "RIVER"
                BankExists = VibeMainScreen.RIVERCheck.Checked
            Case Else
                BankExists = False
        End Select

    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles OpenAccountBW.DoWork
        ServerMSG = OpenBank(Bank)
    End Sub

    Private Sub DoneOpen() Handles OpenAccountBW.RunWorkerCompleted
        RefreshNotice.Close()
        Select Case ServerMSG
            Case "S"
                MsgBox("Account Created Succesfully", vbInformation, "Information")
                RefreshNotice.Show()
                LogBW.RunWorkerAsync()
            Case "E"
                MsgBox("An error occurred and your account could not be created." & vbNewLine & "If the problem persists, contact CHOPO.", vbCritical, "Error")
        End Select
    End Sub

    Private Sub CloseAccountBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CloseAccountBW.DoWork
        ServerMSG = CloseBank(Bank)
    End Sub

    Private Sub DoneClose() Handles CloseAccountBW.RunWorkerCompleted
        RefreshNotice.Close()
        Select Case ServerMSG
            Case "S"
                MsgBox("Account closed succesfully", vbInformation, "Information")
                Close()
            Case "E"
                MsgBox("An error occurred and your account could not be closed." & vbNewLine & "If the problem persists, contact CHOPO.", vbCritical, "Error")
        End Select
    End Sub

    Private Sub LogBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LogBW.DoWork
        'BNKL57174GBANK
        ServerMSG = BankLog(Bank)
        Select Case ServerMSG
            Case "S"
                Try
                    My.Computer.Network.DownloadFile("http://igtnet-w.ddns.net:100/logs/" & ID & Bank & ".log", "Templog.log")
                Catch
                    ServerMSG = "E"
                End Try
            Case "E"
        End Select
    End Sub

    Private Sub Logdone() Handles LogBW.RunWorkerCompleted
        If ServerMSG = "E" Then
            MsgBox("An error occurred while retrieving your log", vbCritical, "Error")
            Exit Sub
        End If

        FileOpen(2, "Templog.log", OpenMode.Input)

        While Not EOF(2)

            Logbox.Items.Add(LineInput(2))

        End While

        FileClose(2)
        File.Delete("Templog.log")

        Try
            RefreshNotice.Close()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Logbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Logbox.SelectedIndexChanged
        Button3.Enabled = True
        Selected.Text = Logbox.SelectedItem

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CertificationWindow.ShowDialog()
    End Sub
End Class