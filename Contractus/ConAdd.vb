''' <summary>Form to create and add a contract</summary>
Public Class ConAdd

    '--------------------------------[Variables]--------------------------------
    Private ReadOnly MyUser As User

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(User As User)
        InitializeComponent()
        MyUser = User
    End Sub

    Private Sub LoadingTime() Handles Me.Load
        FromLBL.Text = MyUser.ToString
        NameTXB.Text = ""
        DetailsTXB.Text = ""
    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub AddContract() Handles SendBTN.Click
        Select Case AddContractToAll(NameTXB.Text, MyUser.ID, MyUser.Username, DetailsTXB.Text)
            Case "S"
                MsgBox("Successfully added the contract", vbInformation)
                Close()
            Case "E"
                MsgBox("A serverside error occurred", vbInformation)
        End Select
    End Sub

    Private Sub Neverimnd() Handles CancelBTN.Click
        Close()
    End Sub

End Class