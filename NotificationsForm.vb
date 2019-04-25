Imports System.ComponentModel

Public Class NotificationsForm

    Public Structure NotificationStructure
        Public Time As String
        Public Notif As String
    End Structure

    Public BWError As String = "ono"
    Public notifs() As NotificationStructure
    Public ID As String

    Private Sub Begining() Handles Me.Shown
        ID = VibeLogin.LogonID.Text
        RefreshNotice.Show()
        ListView1.Clear()
        ListView1.Visible = False
        Button1.Enabled = False
        BackgroundWorker1.RunWorkerAsync()


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim servermsg = VibeMainScreen.ServerCommand("NOTIFREMO" & VibeLogin.LogonID.Text & ListView1.SelectedIndices(0))
        Select Case servermsg
            Case "E"
                MsgBox("A server side error has occurred. Contact CHOPO!", vbExclamation)

            Case "N"
                MsgBox("There's No Notification File.", vbInformation)
                Close()
            Case "S"
                If notifs.Count = 1 Then Close()
                RefreshNotice.Show()
                BackgroundWorker1.RunWorkerAsync()
        End Select


        Button1.Enabled = False

    End Sub




    Sub Populatelistview()
        ListView1.Clear()
        ListView1.View = View.Details
        ListView1.Columns.Add("Date and Time")
        ListView1.Columns.Item(0).Width = 132
        ListView1.Columns.Add("Notification")
        ListView1.Columns.Item(1).Width = 318
        ListView1.MultiSelect = False
        ListView1.FullRowSelect = True
        ListView1.HideSelection = False

        For I = 0 To notifs.Count - 1

            Dim CLVI As ListViewItem
            CLVI = New ListViewItem With {
                .Text = notifs(I).Time
            }
            CLVI.SubItems.Add(notifs(I).Notif)
            ListView1.Items.Add(CLVI)

        Next

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BWError = "ono"

        Dim servermsg = VibeMainScreen.ServerCommand("NOTIFREAD" & ID)
        If servermsg = "N" Or servermsg = "E" Then
            BWError = servermsg
            Exit Sub
        End If

        Dim Doot() As String = servermsg.Split("`")

        Dim I As Integer = -1
        Dim N As Integer = 0

        Do
            ReDim Preserve notifs(N)
            I = I + 1
            notifs(N).Time = Doot(I)
            I = I + 1
            notifs(N).Notif = Doot(I)
            N = N + 1
            If I = Doot.Count - 1 Then Exit Do
        Loop

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If BWError = "N" Then
            MsgBox("There's no notifications availale", vbInformation)
            ListView1.Visible = False
            RefreshNotice.Close()
            Exit Sub
        ElseIf BWError = "E" Then
            MsgBox("A server side error has occurred. Contact CHOPO!", vbExclamation)
            ListView1.Visible = False
            RefreshNotice.Close()
            Exit Sub
        End If

        Populatelistview()
        RefreshNotice.Close()
        ListView1.Visible = True

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        Button1.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case VibeMainScreen.ServerCommand("NOTIFCLEAR" & VibeLogin.LogonID.Text)
            Case "E"
                MsgBox("A server side error has occurred. Contact CHOPO!", vbExclamation)

            Case "N"
                MsgBox("There's No Notification File.", vbInformation)
                Close()
            Case "S"
                Close()
        End Select
        Button1.Enabled = False
    End Sub
End Class