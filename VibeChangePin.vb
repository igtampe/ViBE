Public Class VibeChangePin

    '--------------------------------[Variables]--------------------------------

    Private ServerMSG As String
    Private ID As String
    Private Pin As String

    '--------------------------------[Buttons]--------------------------------

    Private Sub TimeForANewPin() Handles OKBTN.Click
        Pin = NewPinTextBox.Text
        ID = VibeLogin.LogonID.Text

        If Not IsValidPin(Pin) Then
            MsgBox("Invalid Pin specified", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Enabled = False
        RefreshNotice.Show()
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Nevermind() Handles CancelBTN.Click
        Close()
    End Sub

    '--------------------------------[Background Worker]--------------------------------

    Private Sub SendNewPin(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ServerMSG = ChangePin(ID, Pin)
    End Sub

    Private Sub TheResults() Handles BackgroundWorker1.RunWorkerCompleted
        Enabled = True
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

    '--------------------------------[Other Functions]--------------------------------

    Private Function IsValidPin(Pin As String) As Boolean
        Return Pin.Count = 4
    End Function

End Class