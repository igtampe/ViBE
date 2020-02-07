Imports System.IO

Public Class KeyringForm
    Public Structure KeyRingFormResult
        Public CommitAction As Boolean
        Public ID As String
        Public Pin As String
        Public Remember As Boolean
        Sub New(ReturnCommitAction As Boolean, ReturnID As String, ReturnPIN As String, ReturnRemember As Boolean)
            CommitAction = ReturnCommitAction
            ID = ReturnID
            Pin = ReturnPIN
            Remember = ReturnRemember
        End Sub
    End Structure
    Public Structure User
        Private ReadOnly ID As String
        Private ReadOnly Pin As String
        Private ReadOnly Name As String
        Sub New(NewID As String, NewPIN As String, NewName As String)
            ID = NewID
            Pin = NewPIN
            Name = NewName
        End Sub

        Function GetID() As String
            Return ID
        End Function

        Function GetPIN() As String
            Return Pin
        End Function

        Function GetName() As String
            Return Name
        End Function

    End Structure
    Public Structure KeyRing
        Private Users As ArrayList
        Private NumberofUsers As Integer
        Private NumberofHeaders As Integer
        Private ReadOnly Filename As String
        Private ReadOnly Ready As Boolean
        Sub New(NewFilename As String)
            Users = New ArrayList
            NumberofUsers = 0
            Filename = NewFilename
            If Not File.Exists(Filename) Then
                MsgBox("No KeyRing file exists, it will be generated when you add your first account to the keyring", MsgBoxStyle.Information, "KeyRing")
                Exit Sub
            Else
                Dim HoldArray() As String
                FileOpen(1, Filename, OpenMode.Input)
                Try
                    While Not EOF(1)
                        HoldArray = LineInput(1).Split(",")
                        AddUser(HoldArray(0), HoldArray(1), HoldArray(2))
                    End While
                Catch ex As Exception
                    Console.Write(ex.ToString)
                    MsgBox("Your KeyRing appears to be corrupted, Contact CHOPO", MsgBoxStyle.Critical, "KeyRing")
                    FileClose(1)
                    Exit Sub
                End Try
                Ready = True
                FileClose(1)
            End If
        End Sub
        Function GetNumberofUsers() As Integer
            Return NumberofUsers
        End Function

        Function GetNumberofHeaders() As Integer
            Return NumberofHeaders
        End Function

        Function IsHeader(Index As Integer) As Boolean
            If GetUser(Index).GetID() = "-----" Then
                Return True
            Else
                Return False
            End If
        End Function

        Sub Save()
            If NumberofUsers = 0 Then
                File.Delete(Filename)
            Else
                FileOpen(1, Filename, OpenMode.Output)
                For X = 0 To NumberofUsers - 1
                    Dim CurrentUser As User
                    CurrentUser = GetUser(X)
                    PrintLine(1, CurrentUser.GetID() & "," & CurrentUser.GetPIN() & "," & CurrentUser.GetName())
                Next
                FileClose(1)
            End If
        End Sub

        Function IsReady() As Boolean
            Return Ready
        End Function

        Public Sub RemoveUser(Index As Integer)
            If GetUser(Index).GetID = "-----" Then NumberofHeaders -= 1
            NumberofUsers -= 1
            Users.Remove(GetUser(Index))

        End Sub

        Public Sub MoveUserUp(Index As Integer)
            Dim TempUser As User = New User(GetUser(Index).GetID, GetUser(Index).GetPIN, GetUser(Index).GetName)
            Users.Remove(GetUser(Index))
            Users.Insert(Index - 1, TempUser)
        End Sub

        Public Sub MoveUserDown(Index As Integer)
            Dim TempUser As User = New User(GetUser(Index).GetID, GetUser(Index).GetPIN, GetUser(Index).GetName)
            Users.Remove(GetUser(Index))
            Users.Insert(Index + 1, TempUser)
        End Sub


        Public Sub AddUser(ID As String, Pin As String, Name As String)
            If ID = "-----" Then NumberofHeaders += 1
            NumberofUsers += 1
            Users.Add(New User(ID, Pin, Name))
        End Sub
        Function GetUser(Number As Integer) As User
            Return Users(Number)
        End Function
    End Structure

    Public KR As KeyRing
    Public FormMode As Integer
    Public ReturnValue As KeyRingFormResult
    Public CurrentFormMode As Integer

    Private Sub LoadUp() Handles Me.Shown
        GroupBox1.Enabled = False
        ActionButton.Enabled = False
        DeleteButton.Enabled = False
        MoveUpBTN.Enabled = False
        MoveDownBTN.Enabled = False
        Select Case CurrentFormMode
            Case 0
                'Login Mode
                AddToKeyRingButton.Visible = False
                CheckBox1.Visible = True
                ActionButton.Text = "Log In"
            Case 1
                'Switch User Mode
                AddToKeyRingButton.Visible = True
                GroupBox1.Enabled = True
                AddToKeyRingButton.Enabled = True
                CheckBox1.Visible = False
                ActionButton.Text = "Switch User"
        End Select

        ListView1.Clear()
        ListView1.View = View.Details
        Dim Column As ColumnHeader
        Column = New ColumnHeader With {
            .Text = "ID",
            .Width = 50
        }
        ListView1.Columns.Add(Column)

        Column = New ColumnHeader With {
            .Text = "Name",
            .Width = 220
        }
        ListView1.Columns.Add(Column)

        ListView1.FullRowSelect = True
        ListView1.MultiSelect = False

        ListView1.Enabled = False
        KR = New KeyRing(Application.UserAppDataPath & "\ViBE\KeyRing.KR")
        AccountNumberLabel.Text = (KR.GetNumberofUsers - KR.GetNumberofHeaders) & " account(s) on the KeyRing."
        If KR.IsReady() Then
            'populate the listview
            For X = 0 To KR.GetNumberofUsers - 1
                Dim CurrentUser As User = KR.GetUser(X)
                Dim Doot As New ListViewItem With {
                .Text = CurrentUser.GetID()
                }
                Doot.SubItems.Add(New ListViewItem.ListViewSubItem With {
                                  .Text = CurrentUser.GetName()
                })
                ListView1.Items.Add(Doot)
                If CurrentUser.GetID() = VibeLogin.LogonID.Text Then AddToKeyRingButton.Enabled = False
            Next
            ListView1.Enabled = True
        Else
        End If


    End Sub

    Sub Button4_Click() Handles Button4.Click
        ReturnValue = New KeyRingFormResult(False, "", "", False)
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged


        GroupBox1.Enabled = True
        DeleteButton.Enabled = True

        MoveUpBTN.Enabled = True
        MoveDownBTN.Enabled = True

        Try
            Dim SelectedIndex
            SelectedIndex = ListView1.SelectedIndices(0)
            If KR.IsHeader(SelectedIndex) Then
                ActionButton.Enabled = False
            Else
                ActionButton.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim RemovedUser As String = KR.GetUser(ListView1.SelectedIndices(0)).GetName
        KR.RemoveUser(ListView1.SelectedIndices(0))

        KR.Save()

        MsgBox("Removed " & RemovedUser & " from the KeyRing", MsgBoxStyle.Information, "KeyRing")
        LoadUp()
    End Sub

    Private Sub KeyRingDoubleclick() Handles ListView1.DoubleClick
        Try
            ActionButton_Click()
        Catch
        End Try
    End Sub

    Private Sub ActionButton_Click() Handles ActionButton.Click
        Dim SelectedIndex As Integer
        SelectedIndex = ListView1.SelectedIndices(0)

        If KR.IsHeader(SelectedIndex) Then Exit Sub

        ReturnValue = New KeyRingFormResult(True, KR.GetUser(SelectedIndex).GetID(), KR.GetUser(SelectedIndex).GetPIN(), CheckBox1.Checked)
        Me.Close()
    End Sub

    Private Sub AddToKeyRingButton_Click(sender As Object, e As EventArgs) Handles AddToKeyRingButton.Click
        If Not Directory.Exists(Application.UserAppDataPath & "\ViBE") Then
            Directory.CreateDirectory(Application.UserAppDataPath & "\ViBE")
        End If

        FileOpen(1, Application.UserAppDataPath & "\ViBE\KeyRing.KR", OpenMode.Append)
        PrintLine(1, VibeLogin.LogonID.Text & "," & VibeLogin.LogonPIN.Text & "," & VibeMainScreen.Username)
        FileClose(1)

        MsgBox("Added " & VibeMainScreen.Username & " to the KeyRing", MsgBoxStyle.Information, "KeyRing")
        LoadUp()
    End Sub

    Private Sub MoveUpBTN_Click(sender As Object, e As EventArgs) Handles MoveUpBTN.Click
        KR.MoveUserUp(ListView1.SelectedIndices(0))
        KR.Save()
        LoadUp()
    End Sub

    Private Sub MoveDownBTN_Click(sender As Object, e As EventArgs) Handles MoveDownBTN.Click
        Try
            Dim Index As Integer
            Index = ListView1.SelectedIndices(0)
            KR.MoveUserDown(Index)
            KR.Save()
            LoadUp()

        Catch
        End Try

    End Sub

    Private Sub AddHeader_Click(sender As Object, e As EventArgs) Handles AddHeader.Click
        Dim HeaderName As String
        HeaderName = FancyInputBox("Header Text:", "Specify Header")
        If HeaderName = "CANCEL" Then Exit Sub

        If Not Directory.Exists(Application.UserAppDataPath & "\ViBE") Then
            Directory.CreateDirectory(Application.UserAppDataPath & "\ViBE")
        End If

        FileOpen(1, Application.UserAppDataPath & "\ViBE\KeyRing.KR", OpenMode.Append)
        PrintLine(1, "-----,----," & HeaderName & "")
        FileClose(1)
        LoadUp()


    End Sub

    ''' <summary>
    ''' Renders a fancier input box
    ''' </summary>
    ''' <param name="Prompt">The prompt of the InputBox</param>
    ''' <returns></returns>
    Function FancyInputBox(ByVal Prompt As String, Optional ByVal maxstringlength As Integer = 999999) As String

        InputForm.PromptLBL.Text = Prompt
        InputForm.Answer.Text = ""
        InputForm.Answer.MaxLength = maxstringlength


        Select Case InputForm.ShowDialog()
            Case DialogResult.OK
                FancyInputBox = InputForm.Answer.Text
            Case DialogResult.Cancel
                FancyInputBox = "CANCEL"
            Case Else
                FancyInputBox = "CANCEL"
        End Select

    End Function

End Class