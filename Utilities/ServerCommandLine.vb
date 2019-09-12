Public Class ServerCommandLine

    Public log As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clientmsg As String = TextBox2.Text
        If clientmsg = "" Then Exit Sub
        log = log & "[SERVER] " & ServerCommand.ServerCommand(clientmsg, “127.0.0.1”) & vbNewLine
        TextBox1.Text = log
    End Sub


End Class