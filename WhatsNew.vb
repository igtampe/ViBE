''' <summary>Shows what's new</summary>
Public Class WhatsNew

    Private Sub LoadingTime() Handles Me.Load

        'Set the label to the current id
        WelcomeLabel.Text = "WELCOME TO ViBE ID " & VibeLogin.VVer & "!"

        'Set the rtf to the what's new RTF
        RichTextBox1.Rtf = My.Resources.WhatsNew

        'Play the noise!
        My.Computer.Audio.Play(My.Resources.welcome, AudioPlayMode.Background)

    End Sub

    Private Sub ClosingTime() Handles Button1.Click
        Close()
    End Sub
End Class