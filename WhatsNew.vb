
Public Class WhatsNew
    Private Sub WhatsNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        WelcomeLabel.Text = "WELCOME TO ViBE ID " & VibeLogin.VVer & "!"
        RichTextBox1.Rtf = My.Resources.WhatsNew
        My.Computer.Audio.Play(My.Resources.welcome, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class