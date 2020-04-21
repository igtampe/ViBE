''' <summary>Handles the creation of checks and bills</summary>
Public Class CheckbookOutbox

    '--------------------------------[Variables]--------------------------------

    Private ReadOnly MyUser As User

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(User As User, Optional ContractusMode As Boolean = False, Optional ToID As String = "", Optional Value As Long = 0, Optional Description As String = "")
        InitializeComponent()
        MyUser = User

        CheckName.Text = User.ToString
        BillName.Text = User.ToString

        BillGraphic(False)

        UMSNBRButton.Enabled = User.UMSNB
        GBANKRbutton.Enabled = User.GBANK
        RIVERRButton.Enabled = User.RIVER

        ToBank.Text = ""
        ItemValueUD.Value = 0
        ItemCommentTXB.Text = ""
        CheckWordAmount.Text = ""
        ItemTypeCMB.SelectedIndex = 0
        CheckVariantCombobox.SelectedIndex = 0
        CheckGraphic(True)

        If ContractusMode Then
            CheckGraphic(False)
            BillGraphic(True)
            ItemTypeCMB.SelectedIndex = 1

            ToBank.Text = ToID
            ItemValueUD.Value = Value
            ItemCommentTXB.Text = "Payment for '" & Description & "'"
        End If

    End Sub

    Private Sub LoadingTime() Handles Me.Load
        CheckDate.Text = DateTime.Now
        BillDate.Text = DateTime.Now
    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub ItemTypeChange() Handles ItemTypeCMB.SelectedIndexChanged
        Select Case ItemTypeCMB.SelectedIndex
            Case 0
                BillGraphic(False)
                CheckGraphic(True)
            Case 1
                CheckGraphic(False)
                BillGraphic(True)
            Case Else
                BillGraphic(False)
                CheckGraphic(False)
        End Select

    End Sub

    Private Sub ItemValueChanged() Handles ItemValueUD.ValueChanged
        Try
            CheckAmount.Text = ItemValueUD.Value.ToString("N0") & "p"
            CheckWordAmount.Text = NumberToText(ItemValueUD.Value) & " Pecunia"
            BillAmount.Text = ItemValueUD.Value.ToString("N0") & "p"
        Catch
        End Try
    End Sub

    Private Sub CommentChanged() Handles ItemCommentTXB.TextChanged
        Try
            CheckComment.Text = ItemCommentTXB.Text
            BillComment.Text = ItemCommentTXB.Text
        Catch
        End Try
    End Sub

    Private Sub UMSNBSelected() Handles UMSNBRButton.CheckedChanged
        If UMSNBRButton.Checked Then
            CheckFrom.Text = MyUser.ID & "\UMSNB"
            BillFrom.Text = MyUser.ID & "\UMSNB"
            BalanceLabel.Text = VibeMainScreen.UMSNBBLabel.Text
        End If
    End Sub

    Private Sub GBANKSelected() Handles GBANKRbutton.CheckedChanged
        If GBANKRbutton.Checked Then
            CheckFrom.Text = MyUser.ID & "\GBANK"
            BillFrom.Text = MyUser.ID & "\GBANK"
            BalanceLabel.Text = VibeMainScreen.GBANKBLabel.Text
        End If
    End Sub

    Private Sub RIVERRSelected() Handles RIVERRButton.CheckedChanged
        If RIVERRButton.Checked Then
            CheckFrom.Text = MyUser.ID & "\RIVER"
            BillFrom.Text = MyUser.ID & "\RIVER"
            BalanceLabel.Text = VibeMainScreen.RIVERBLabel.Text
        End If
    End Sub

    Private Sub DirectoryButton_Click(sender As Object, e As EventArgs) Handles DirectoryButton.Click
        Dim CheckbookDirectory As DirWindow = New DirWindow(DirWindow.DirectoryMode.Checkbook)

        CheckbookDirectory.ShowDialog()

        If CheckbookDirectory.Commit Then
            ToBank.Text = CheckbookDirectory.MyReturn.Split(":")(0)
            CheckTo.Text = CheckbookDirectory.MyReturn.Split(":")(1) & " (" & CheckbookDirectory.MyReturn.Split(":")(0) & ")"
        End If

    End Sub

    Private Sub SendIt() Handles SendBTN.Click
        'send\
        '0`12/4/2018 7:42:42 PM`A Test Account`57174\UMSNB`100`This is a Check
        Dim Type As Integer = ItemTypeCMB.SelectedIndex
        Dim Time As String = DateTime.Now.ToString
        Dim Name As String = VibeMainScreen.NameLabel.Text
        Dim bank As String = VibeLogin.LogonID.Text
        Dim Subtype As Integer = CheckVariantCombobox.SelectedIndex

        If UMSNBRButton.Checked = True Then
            bank &= "\UMSNB"
        ElseIf GBANKRbutton.Checked = True Then
            bank &= "\GBANK"
        ElseIf RIVERRButton.Checked = True Then
            bank &= "\RIVER"
        End If

        Dim amount As Long = ItemValueUD.Value
        Dim destination As String = ToBank.Text
        Dim Comment As String = ItemCommentTXB.Text
        'OLD: 0`12/4/2018 7:42:42 PM`A Test Account`57174\UMSNB`100`This is a Check
        'NEW: 0`12/4/2018 7:42:42 PM`A Test Account`57174\UMSNB`100`VariantID~This is a Check
        'Split the comment again with the ~ character, the second one will then be the actual comment, the first will be the color
        'check to make sure the count is of two elements because otherwise its an older check/bill so `azul`
        Dim servermsg = AddCheck(destination, Type, Time, Name, bank, amount, Subtype, Comment)
        Select Case servermsg
            Case "E"
                MsgBox("A server side error has occurred. Contact CHOPO!", vbExclamation)

            Case "N"
                MsgBox("There's No Check File.", vbInformation)
                Close()
            Case "S"
                Select Case Type
                    Case 0
                        MsgBox("Check has been sent successfully, now " & destination & " must cash it.", vbInformation, "Checkbook 2000")
                    Case 1
                        MsgBox("Bill has been sent successfully, now " & destination & " must pay it.", vbInformation, "Checkbook 2000")
                End Select
                Close()

        End Select

    End Sub

    Private Sub Nevermind() Handles CancelBTN.Click
        Close()
    End Sub

    '--------------------------------[Other Functions]--------------------------------

    Sub BillGraphic(Status As Boolean)
        BillAmount.Visible = Status
        BillComment.Visible = Status
        BillDate.Visible = Status
        BillFrom.Visible = Status
        BillName.Visible = Status

        Select Case Status
            Case True
                PictureBox1.Image = My.Resources.Bill
            Case False
                PictureBox1.Image = Nothing
        End Select

    End Sub

    Sub CheckGraphic(Status As Boolean)
        CheckAmount.Visible = Status
        CheckComment.Visible = Status
        CheckDate.Visible = Status
        CheckName.Visible = Status
        CheckTo.Visible = Status
        CheckFrom.Visible = Status
        CheckWordAmount.Visible = Status
        CheckVariantCombobox.Enabled = Status

        Select Case Status
            Case True
                CheckVariantCombobox_SelectedIndexChanged()
            Case False
                PictureBox1.Image = Nothing
        End Select

    End Sub

    Function NumberToText(ByVal n As Long) As String

        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven",
                  "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)

            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundred " & NumberToText(n Mod 100)

            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)

            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousand " & NumberToText(n Mod 1000)

            Case 1000000 To 1999999
                Return "One Million " & NumberToText(n Mod 1000000)

            Case 1000000 To 999999999
                Return NumberToText(n \ 1000000) & "Million " & NumberToText(n Mod 1000000)

            Case 1000000000 To 1999999999
                Return "One Billion " & NumberToText(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " _
                  & NumberToText(n Mod 1000000000)
        End Select
    End Function

    Private Sub ChangeCheckLabelBGTo(ByVal NewColor As Color)

        CheckComment.BackColor = NewColor
        CheckDate.BackColor = NewColor
        CheckName.BackColor = NewColor
        CheckTo.BackColor = NewColor
        CheckFrom.BackColor = NewColor
        CheckWordAmount.BackColor = NewColor
    End Sub

    Private Sub ChangeCheckLabelFGTo(ByVal NewColor As Color)
        CheckAmount.ForeColor = NewColor
        CheckComment.ForeColor = NewColor
        CheckDate.ForeColor = NewColor
        CheckName.ForeColor = NewColor
        CheckTo.ForeColor = NewColor
        CheckFrom.ForeColor = NewColor
        CheckWordAmount.ForeColor = NewColor
    End Sub

    Private Sub CheckVariantCombobox_SelectedIndexChanged() Handles CheckVariantCombobox.SelectedIndexChanged

        Dim DefaultColor As Color = Color.FromArgb(219, 241, 245)
        Dim GrayColor As Color = Color.FromArgb(235, 235, 235)
        Dim YellowColor As Color = Color.FromArgb(255, 255, 182)
        Dim PurpleColor As Color = Color.FromArgb(252, 229, 255)
        Dim RedColor As Color = Color.FromArgb(255, 233, 231)
        Dim GreenColor As Color = Color.FromArgb(178, 255, 192)
        Dim BlackColor As Color = Color.FromArgb(20, 20, 20)


        Select Case CheckVariantCombobox.SelectedIndex
            Case 0
                'Default
                PictureBox1.Image = My.Resources.Check
                ChangeCheckLabelBGTo(DefaultColor)
                CheckAmount.BackColor = Color.FromArgb(235, 245, 247)
                ChangeCheckLabelFGTo(Color.Black)

            Case 1
                'Gray
                PictureBox1.Image = My.Resources.CheckGray
                ChangeCheckLabelBGTo(GrayColor)
                CheckAmount.BackColor = Color.FromArgb(243, 243, 243)
                ChangeCheckLabelFGTo(Color.Black)

            Case 2
                'Green
                PictureBox1.Image = My.Resources.CheckGreen
                ChangeCheckLabelBGTo(GreenColor)
                CheckAmount.BackColor = Color.FromArgb(194, 255, 194)
                ChangeCheckLabelFGTo(Color.Black)

            Case 3
                'Purple
                PictureBox1.Image = My.Resources.CheckPurple
                ChangeCheckLabelBGTo(PurpleColor)
                CheckAmount.BackColor = Color.FromArgb(255, 233, 255)
                ChangeCheckLabelFGTo(Color.Black)

            Case 4
                'Red
                PictureBox1.Image = My.Resources.CheckRed
                ChangeCheckLabelBGTo(RedColor)
                CheckAmount.BackColor = Color.FromArgb(255, 239, 233)
                ChangeCheckLabelFGTo(Color.Black)

            Case 5
                'Yellow
                PictureBox1.Image = My.Resources.CheckYellow
                ChangeCheckLabelBGTo(YellowColor)
                CheckAmount.BackColor = Color.FromArgb(255, 255, 184)
                ChangeCheckLabelFGTo(Color.Black)

            Case 6
                'Black
                PictureBox1.Image = My.Resources.CheckBlack
                ChangeCheckLabelBGTo(BlackColor)
                CheckAmount.BackColor = Color.FromArgb(12, 12, 12)
                ChangeCheckLabelFGTo(Color.White)

        End Select

    End Sub
End Class