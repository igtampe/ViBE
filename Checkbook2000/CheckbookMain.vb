Imports VIBE__But_on_Visual_Studio_.Checkbook
Imports System.ComponentModel

Public Class CheckbookMain

    Public Tips(10) As String
    Public ID As String
    Public Servermsg As String
    Public bwerror As String

    Public Shared MessageItem() As Inbox


    Public Structure Inbox
        Public Type As Integer
        Public Time As String
        Public FromName As String
        Public FromBank As String
        Public Amount As Integer
        Public Comment As String
        Public Subtype As Integer
    End Structure


    Shared Coso As New Random


    Private Sub CheckbookMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ID = VibeLogin.LogonID.Text

        Tips(0) = "Does anyone actually read these?"
        Tips(1) = "Outbox helps you send items like checks, bills, and more things in the future!"
        Tips(2) = "The inbox system was made with the same technology as the notification system for ViBE"
        Tips(3) = "This program took way too long to make because I actually downloaded a copy of Windows 2000 and Office 2000 to make sure this looked correct."
        Tips(4) = "Multiple banks? No problem! You now only need to specify user from the directory, and away you go!"
        Tips(5) = "All you have to do is download Adobe Reader"
        Tips(6) = "Stuck? CHOPO is always available on #UMSWEB-TECHNICAL-SUPPORT. Send him a mention!"
        Tips(7) = "ViBE has a sensitive ego. Don't insult it or it might crash."
        Tips(8) = "DO WHAT YOU WANT CAUSE A PIRATE IS FREE. YOU ARE A PIRATE!"
        Tips(9) = "You still haven't WOKEN UP"

        Try
            TipLBL.Text = Tips(Coso.Next(0, 9))
        Catch ex As Exception
            TipLBL.Text = "Bonjour Bitch the tip failed to load" & vbNewLine & vbNewLine & ex.ToString
        End Try
        InboxButton.Enabled = False

    End Sub

    Private Sub CheckbookMain_splash() Handles Me.Shown
        CheckbookSplash.Show()
        BackgroundWorker1.RunWorkerAsync()


    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        bwerror = "ono"
        Dim Servermsg = ReadChecks(ID)
        If Servermsg = "N" Or Servermsg = "E" Or Servermsg = "F" Then
            bwerror = Servermsg
            Exit Sub
        End If

        Dim Doot() As String = Servermsg.Split("`")

        Dim I As Integer = -1
        Dim N As Integer = 0
        Dim SubtypeProcessor As String

        Do
            ReDim Preserve MessageItem(N)
            I += 1
            MessageItem(N).Type = Doot(I)
            I += 1
            MessageItem(N).Time = Doot(I)
            I += 1
            MessageItem(N).FromName = Doot(I)
            I += 1
            MessageItem(N).FromBank = Doot(I)
            I += 1
            MessageItem(N).Amount = Doot(I)
            I += 1
            MessageItem(N).Comment = Doot(I)

            If MessageItem(N).Comment.StartsWith("::") Then
                SubtypeProcessor = MessageItem(N).Comment.Remove(5, MessageItem(N).Comment.Length - 5)
                MessageItem(N).Subtype = CInt(SubtypeProcessor.Replace(":", ""))
                MessageItem(N).Comment = MessageItem(N).Comment.Replace(SubtypeProcessor, "")

            Else
                MessageItem(N).Subtype = 0
            End If

            N += 1

            If I = Doot.Count - 1 Then Exit Do
        Loop


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If bwerror = "N" Then
            InboxButton.Enabled = False
            CheckbookSplash.Close()
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
        CheckbookSplash.Close()



    End Sub

    Private Sub OutboxButton_Click(sender As Object, e As EventArgs) Handles OutboxButton.Click
        CheckbookOutbox.ShowDialog()

    End Sub

    Private Sub InboxButton_Click(sender As Object, e As EventArgs) Handles InboxButton.Click
        CheckbookInbox.ShowDialog()
    End Sub
End Class