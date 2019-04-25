Public Class ConBid
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ConMain.ServerCommand("CONADDBID" & ConMain.AllContracts(ConMain.SelectedAvailableContract).ID & ";" & NumericUpDown1.Value & ";" & ConMain.UserID & ";" & ConMain.UserName)
            Case "S"
                MsgBox("Successfully placed a bid", vbInformation)
                Close()
            Case "E"
                MsgBox("A Serverside error occurred", vbInformation)
        End Select


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub ConBid_Load(sender As Object, e As EventArgs) Handles Me.Load
        NumericUpDown1.Minimum = 0
        If ConMain.AllContracts(ConMain.SelectedAvailableContract).TopBid = -1 Then
            NumericUpDown1.Maximum = 2000000000
        Else
            NumericUpDown1.Maximum = ConMain.AllContracts(ConMain.SelectedAvailableContract).TopBid - 1
            NumericUpDown1.Value = ConMain.AllContracts(ConMain.SelectedAvailableContract).TopBid - 1
        End If

    End Sub
End Class