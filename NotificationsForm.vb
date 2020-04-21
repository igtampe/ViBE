Imports VIBE__But_on_Visual_Studio_.NotifCommands

''' <summary>Shows notifications of a User</summary>
Public Class NotificationsForm

    '--------------------------------[Variables]--------------------------------

    Private Structure NotificationStructure
        Public Time As String
        Public Notif As String
    End Structure

    Private ReadOnly ID As String

    Private BWError As String = "ono"
    Private notifs() As NotificationStructure
    Private ReferencedObject As String
    Private ServerMSG As String

    '--------------------------------[Initialization]--------------------------------

    ''' <summary>Creates a new Notification Form</summary>
    ''' <param name="ID">ID of the user whos notifs u want this window to display</param>
    Public Sub New(ID As String)
        InitializeComponent()
        Me.ID = ID
        Text = "Notifications for " & ID
    End Sub

    Private Sub Begining() Handles Me.Shown
        RefreshNotice.Show()
        ListView1.Items.Clear()
        Enabled = False
        GetNotificationsBW.RunWorkerAsync()
    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub ClosingTime() Handles OKBTN.Click
        Close()
    End Sub

    Private Sub RemoveNotifTime() Handles RemoveNotifBTN.Click
        ReferencedObject = ListView1.SelectedIndices(0)
        RefreshNotice.Show()
        Enabled = False
        RemoveNotificationBW.RunWorkerAsync()

    End Sub

    Private Sub EnableRemoveNotifBTN() Handles ListView1.SelectedIndexChanged
        RemoveNotifBTN.Enabled = True
    End Sub

    Private Sub ClearThemAll() Handles ClearNotifsBTN.Click
        Enabled = False
        RefreshNotice.Show()
        ClearAllNotificationsBW.RunWorkerAsync()
    End Sub

    '--------------------------------[Background Workers]--------------------------------

    ''' <summary>Requests, and splits all notifications from the user this window was constructed to view</summary>
    Public Sub GetNotifications_GET() Handles GetNotificationsBW.DoWork
        BWError = "ono"

        'Get the notificaitons
        Dim servermsg = ReadNotifs(ID)
        If servermsg = "N" Or servermsg = "E" Then
            BWError = servermsg
            Exit Sub
        End If

        'Split them
        Dim Doot() As String = servermsg.Split("`")

        Dim I As Integer = -1
        Dim N As Integer = 0

        'Add all the notifications to the notif array
        Do
            ReDim Preserve notifs(N)
            I += 1
            notifs(N).Time = Doot(I)
            I += 1
            notifs(N).Notif = Doot(I)
            N += 1
            If I = Doot.Count - 1 Then Exit Do
        Loop

    End Sub

    ''' <summary>Make sure that we have notifications, and the nenable the notification form</summary>
    Private Sub GetNotifications_DO() Handles GetNotificationsBW.RunWorkerCompleted

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

        Enabled = True
        Populatelistview()
        RefreshNotice.Close()
        ListView1.Visible = True

    End Sub

    ''' <summary>Asks the server to remove the specified notification</summary>
    Private Sub RemoveNotificationBW_GET() Handles RemoveNotificationBW.DoWork
        ServerMSG = RemoveNotif(ID, ReferencedObject)
    End Sub

    ''' <summary>Parses server response, ensuring we did the do</summary>
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

        Enabled = True
        RemoveNotifBTN.Enabled = False
    End Sub

    ''' <summary>Asks the server to clear notifications</summary>
    Private Sub ClearNotification_GET() Handles ClearAllNotificationsBW.DoWork
        ServerMSG = ClearNotifs(ID)
    End Sub

    ''' <summary>Parses server response, making sure the action was complated</summary>
    Private Sub ClearNotification_do() Handles ClearAllNotificationsBW.RunWorkerCompleted
        Enabled = True
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

        RemoveNotifBTN.Enabled = False
    End Sub

    '--------------------------------[Other Functions]--------------------------------

    ''' <summary>Populates the listview with the notifications</summary>
    Private Sub Populatelistview()
        ListView1.Items.Clear()

        For I = 0 To notifs.Count - 1

            Dim CLVI As ListViewItem
            CLVI = New ListViewItem With {.Text = notifs(I).Time}
            CLVI.SubItems.Add(notifs(I).Notif)
            ListView1.Items.Add(CLVI)

        Next

    End Sub

    ''' <summary> Make Sure the MainScreen refreshes after this.</summary>
    Private Sub MidClosing() Handles Me.Closing
        VibeMainScreen.RefreshMe()
    End Sub

End Class