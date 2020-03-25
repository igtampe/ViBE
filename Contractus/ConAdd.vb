Imports VIBE__But_on_Visual_Studio_.ContractusCommands
Public Class ConAdd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Build The Building~57174~Igtampe;Build the Building and make it real good boio pls help
        Select Case AddContractToAll(NameTXB.Text, ConMain.UserID, ConMain.UserName, DetailsTXB.Text)
            Case "S"
                MsgBox("Successfully added the contract", vbInformation)
                Close()
            Case "E"
                MsgBox("A serverside error occurred", vbInformation)
        End Select
    End Sub

    Private Sub ConBid_Load(sender As Object, e As EventArgs) Handles Me.Load
        FromLBL.Text = ConMain.NameLabel.Text
        NameTXB.Text = ""
        DetailsTXB.Text = ""
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class