Public Class VibeChangePin
    Public ServerMSG As String
    Public ID As String
    Public Pin As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pin = NewPinTextBox.Text
        ID = VibeLogin.LogonID.Text
        Enabled = False
        RefreshNotice.Show()
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        servermsg = ServerCommand.RawCommand("CP" & ID & PIN)
    End Sub

    Private Sub BackgroundWorker1_RWC() Handles BackgroundWorker1.RunWorkerCompleted
        Me.Enabled = True
        RefreshNotice.Close()
        Select Case ServerMSG
            Case "1"
                MsgBox("Improperly Coded Change Pin Request", vbInformation, "Change Pin Notice")
            Case "2"
                MsgBox("Could not complete pin change", vbInformation, "Change Pin Notice")
            Case "S"
                MsgBox("Pin Changed Successfully", vbInformation, "Change Pin Notice")
                Enabled = True
                Close()
        End Select
    End Sub
End Class