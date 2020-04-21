Imports VIBE__But_on_Visual_Studio_.CheckbookCommands

''' <summary>Main form of Checkbook 2000</summary>
Public Class CheckbookMain

    '--------------------------------[Variables]--------------------------------

    Public Tips As String() = {
     "Does anyone actually read these?",
     "Outbox helps you send items like checks, bills, and more things in the future!",
     "The inbox system was made with the same technology as the notification system for ViBE",
     "This program took way too long to make because I actually downloaded a copy of Windows 2000 and Office 2000 to make sure this looked correct.",
     "Multiple banks? No problem! You now only need to specify user from the directory, and away you go!",
     "All you have to do is download Adobe Reader",
     "Stuck? CHOPO is always available on #Assistance. Send him a mention!",
     "ViBE has a sensitive ego. Don't insult it or it might crash.",
     "DO WHAT YOU WANT CAUSE A PIRATE IS FREE. YOU ARE A PIRATE!",
     "You still haven't WOKEN UP"}

    Private ReadOnly MyUser As User
    Private bwerror As String

    Private Inbox() As InboxItem

    Public Structure InboxItem
        Public Type As Integer
        Public Time As String
        Public FromName As String
        Public FromBank As String
        Public Amount As Integer
        Public Comment As String
        Public Subtype As Integer
    End Structure

    Private Coso As New Random

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(User As User)
        InitializeComponent()
        MyUser = User
    End Sub

    Private Sub LoadingTime() Handles Me.Load
        Try
            TipLBL.Text = Tips(Coso.Next(0, 9))
        Catch ex As Exception
            TipLBL.Text = "Oopsie the tip failed to load" & vbNewLine & vbNewLine & ex.ToString
        End Try

        InboxButton.Enabled = False
    End Sub

    Private Sub Showtime() Handles Me.Shown
        CheckbookSplash.Show()
        Enabled = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub ExitButton_Click() Handles ExitButton.Click
        Close()
    End Sub

    Private Sub MakeNewCheck() Handles OutboxButton.Click
        Dim NewCheckOut As CheckbookOutbox = New CheckbookOutbox(MyUser)
        NewCheckOut.Show()

    End Sub

    Private Sub SeeAvailableChecks() Handles InboxButton.Click
        Dim InboxWindow As CheckbookInbox = New CheckbookInbox(MyUser, Inbox)
        InboxWindow.ShowDialog()

        Inbox = InboxWindow.Inbox

        If IsNothing(Inbox) Then InboxButton.Enabled = False

    End Sub

    '--------------------------------[Background Worker]--------------------------------

    Private Sub GetInboxItems() Handles BackgroundWorker1.DoWork
        bwerror = "ono"

        Dim Servermsg = ReadChecks(MyUser.ID)
        If Servermsg = "N" Or Servermsg = "E" Or Servermsg = "F" Then
            bwerror = Servermsg
            Exit Sub
        End If

        Dim Doot() As String = Servermsg.Split("`")

        Dim I As Integer = -1
        Dim N As Integer = 0
        Dim SubtypeProcessor As String

        Do
            ReDim Preserve Inbox(N)
            I += 1
            Inbox(N).Type = Doot(I)
            I += 1
            Inbox(N).Time = Doot(I)
            I += 1
            Inbox(N).FromName = Doot(I)
            I += 1
            Inbox(N).FromBank = Doot(I)
            I += 1
            Inbox(N).Amount = Doot(I)
            I += 1
            Inbox(N).Comment = Doot(I)

            'Indicates Colored check
            If Inbox(N).Comment.StartsWith("::") Then
                SubtypeProcessor = Inbox(N).Comment.Remove(5, Inbox(N).Comment.Length - 5)
                Inbox(N).Subtype = CInt(SubtypeProcessor.Replace(":", ""))
                Inbox(N).Comment = Inbox(N).Comment.Replace(SubtypeProcessor, "")

            Else
                Inbox(N).Subtype = 0
            End If

            N += 1

            If I = Doot.Count - 1 Then Exit Do
        Loop

    End Sub

    Private Sub DoneGettingChecks() Handles BackgroundWorker1.RunWorkerCompleted
        CheckbookSplash.Close()
        Activate()
        Enabled = True

        If bwerror = "N" Then
            InboxButton.Enabled = False
            Exit Sub
        ElseIf bwerror = "F" Then
            InboxButton.Enabled = False
            CheckbookSplash.Close()
            Exit Sub
        ElseIf bwerror = "E" Then
            MsgBox("A server side error has occurred. Contact CHOPO!", vbExclamation)
            Exit Sub
        End If

        InboxButton.Enabled = True

    End Sub

    '--------------------------------[Other Functions]--------------------------------

    Public Sub TimeToClose() Handles Me.Closing
        VibeMainScreen.RefreshMe()
    End Sub

End Class