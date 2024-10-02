Imports System.IO

''' <summary>Shows logs of a bank account, and allows users to open/close their accounts</summary>
Public Class BankWindow

    '--------------------------------[Variables]--------------------------------

    Private ReadOnly MyUser As User
    Private ReadOnly Bank As String
    Private ReadOnly BankName As String
    Private ReadOnly BankBalance As Long

    Private ServerMSG As String

    '--------------------------------[Initialization]--------------------------------

    ''' <summary>
    ''' Creates a new bank window
    ''' </summary>
    ''' <param name="User">User whose bank account this bank window will show</param>
    ''' <param name="Bank">Bank you want to manage ("UMSNB","GBANK", or "RIVER")</param>
    Public Sub New(User As User, Bank As String)
        InitializeComponent()

        myUser = User
        Me.Bank = Bank
        Icon = VibeMainScreen.Icon

        Select Case Bank
            Case "UMSNB"
                BankName = "The UMS National Bank"
                BankPictureBox.Image = My.Resources.UMSNB
                BankBalance = User.UMSNBBalance
            Case "GBANK"
                BankName = "G-Bank"
                BankPictureBox.Image = My.Resources.GBANK
                BankBalance = User.GBANKBalance
            Case "RIVER"
                BankName = "Riverside Bank"
                BankPictureBox.Image = My.Resources.Riverside
                BankBalance = User.RIVERBalance
            Case Else
                BankName = "Lemon Investments"
                BankBalance = 0
        End Select

        Text = BankName & " [" & MyUser.ToString & "]"

        CloseAccountBTN.Enabled = (BankBalance = 0)

        Logbox.Items.Clear()

    End Sub

    Private Sub HeyImHere() Handles Me.Shown
        If BankExists(Bank) = False Then
            Dim Result As MsgBoxResult = MsgBox("It appears you don't have a bank account with " & BankName & " open." & vbNewLine & "Would You like to open one now?", 32 + 4, "Question")
            If Result = MsgBoxResult.Yes Then
                RefreshNotice.Show()
                OpenAccountBW.RunWorkerAsync()
            Else
                Close()
                Exit Sub
            End If
        End If

        RefreshNotice.Show()
        LogBW.RunWorkerAsync()

    End Sub

    '--------------------------------[Buttons]--------------------------------

    ''' <summary>Attempts to close the account</summary>
    Private Sub CloseAccount() Handles CloseAccountBTN.Click
        If Not BankBalance = 0 Then
            'Make sure the bank's balance is 0
            MsgBox("Please empty your account. The Lemon may steal your funds if they're left without anywhere to go.", MsgBoxStyle.Critical, "No can do Chief")
        Else
            Dim Result As MsgBoxResult = MsgBox("Are you sure you want to close your " & BankName & " account?", 32 + 4, "Question")
            If Result = MsgBoxResult.Yes Then CloseAccountBW.RunWorkerAsync()
        End If
    End Sub

    Private Sub CloseUp() Handles OKBTN.Click
        Close()
    End Sub

    Private Sub EnableCertifyButton() Handles Logbox.SelectedIndexChanged
        CertifyButton.Enabled = True
    End Sub

    Private Sub CertifyButtonPress() Handles CertifyButton.Click
        Dim NewCertWindow As CertificationWindow = New CertificationWindow(BankPictureBox.Image, Logbox.SelectedItem)
        NewCertWindow.Show()
    End Sub

    '--------------------------------[Background Workers]--------------------------------

    ''' <summary>Asks the server to open the account</summary>
    Private Sub OpenAccount() Handles OpenAccountBW.DoWork
        ServerMSG = OpenBank(Bank, myUser.ID)
    End Sub

    ''' <summary>Parse the server response</summary>
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

    ''' <summary>Asks the server to close the account</summary>
    Private Sub CloseAccountBW_DoWork() Handles CloseAccountBW.DoWork
        ServerMSG = CloseBank(Bank, myUser.ID)
    End Sub

    ''' <summary>Parses response after closing an account</summary>
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

    ''' <summary>Asks server to move the bank log to the web directory, and then downloads the log</summary>
    Private Sub LogBW_DoWork() Handles LogBW.DoWork
        'BNKL57174GBANK
        ServerMSG = BankLog(Bank, myUser.ID)
        Select Case ServerMSG
            Case "S"
                Try
                    My.Computer.Network.DownloadFile("http://" + IGTNET_IP + ":100/logs/" & MyUser.ID & Bank & ".log", "Templog.log")
                Catch
                    ServerMSG = "E"
                End Try
            Case "E"
        End Select
    End Sub

    ''' <summary>Parses the response from the server, and loads the log into the logbox</summary>
    Private Sub Logdone() Handles LogBW.RunWorkerCompleted

        If ServerMSG = "E" Then
            MsgBox("An error occurred while retrieving your log", vbCritical, "Error")
            Exit Sub
        End If

        'Open the file
        FileOpen(2, "Templog.log", OpenMode.Input)

        'Read it, add it to the logbox
        While Not EOF(2)
            Logbox.Items.Add(LineInput(2))
        End While

        'Close it and delete it
        FileClose(2)
        File.Delete("Templog.log")

        RefreshNotice.Close()

    End Sub

    '--------------------------------[Other Stuff]--------------------------------

    Private Sub TimeToClose() Handles Me.Closing
        VibeMainScreen.RefreshMe()
    End Sub

    Private Function BankExists(Bank As String) As Boolean

        Select Case Bank
            Case "UMSNB"
                Return myUser.UMSNB
            Case "GBANK"
                Return myUser.GBANK
            Case "RIVER"
                Return myUser.RIVER
            Case Else
                BankExists = False
        End Select

    End Function


End Class