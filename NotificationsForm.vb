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
        Me.Enabled = False
        GetNotificationsBW.RunWorkerAsync()


    End Sub

    Public ReferencedObject As String
    Public ServerMSG As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReferencedObject = ListView1.SelectedIndices(0)
        RefreshNotice.Show()
        Me.Enabled = False
        RemoveNotificationBW.RunWorkerAsync()

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

    Private Sub GetNotifications_GET(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles GetNotificationsBW.DoWork
        BWError = "ono"

        Dim servermsg = ServerCommand.RawCommand("NOTIFREAD" & ID)
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

    Private Sub GetNotifications_DO(sender As Object, e As RunWorkerCompletedEventArgs) Handles GetNotificationsBW.RunWorkerCompleted
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
        Me.Enabled = True
        Populatelistview()
        RefreshNotice.Close()
        ListView1.Visible = True

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RefreshNotice.Show()
        Me.Enabled = False
        ClearAllNotificationsBW.RunWorkerAsync()
    End Sub

    Private Sub RemoveNotificationBW_GET(sender As Object, e As DoWorkEventArgs) Handles RemoveNotificationBW.DoWork
        ServerMSG = ServerCommand.RawCommand("NOTIFREMO" & ID & ReferencedObject)
    End Sub

    Private Sub RemoveNotifications_DO() Handles RemoveNotificationBW.RunWorkerCompleted
        Select Case ServerMSG
            Case "E"
                MsgBox("A server side error has occurred. Contact CHOPO!", vbExclamation)

            Case "N"
                MsgBox("There's No Notification File.", vbInformation)
                Close()
            Case "S"
                If notifs.Count = 1 Then Close()
                GetNotificationsBW.RunWorkerAsync()
        End Select

        Me.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub ClearNotification_GET() Handles ClearAllNotificationsBW.DoWork
        ServerMSG = ServerCommand.RawCommand("NOTIFCLEAR" & ID)
    End Sub

    Private Sub ClearNotification_do() Handles ClearAllNotificationsBW.RunWorkerCompleted
        Me.Enabled = True
        RefreshNotice.Close()
        Select Case ServerMSG
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