Imports VIBE__But_on_Visual_Studio_.CoreCommands

''' <summary>Shows the UMSWEB Directory</summary>
Public Class DirWindow

    '--------------------------------[Variables]--------------------------------

    ''' <summary>Mode of this directory window</summary>
    Private ReadOnly mode As DirectoryMode

    ''' <summary>Different modes for the directory window</summary>
    Public Enum DirectoryMode As Integer
        Login
        SendMoney
        Checkbook
    End Enum

    Private DirectoryArray() As String
    Private ServerMSG As String

    Public Commit As Boolean = False
    Public MyReturn As String = ""

    ''' <summary>Structure to hold directory items</summary>
    Public Structure DirectoryItem

        Public ID As String
        Public Name As String
        Public Category As Integer

    End Structure

    Public DirectoryUsers() As DirectoryItem

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(Mode As DirectoryMode)
        InitializeComponent()
        Me.mode = Mode
    End Sub

    Private Sub LoadingTime() Handles Me.Load

        Select Case mode
            Case DirectoryMode.Login
                BankGroupBox.Enabled = False
                SelectButton.Visible = False

                OKButton.Visible = True
                CheckbookOK.Visible = False

            Case DirectoryMode.SendMoney
                BankGroupBox.Enabled = True
                SelectButton.Visible = True

                OKButton.Visible = False
                CheckbookOK.Visible = False

            Case DirectoryMode.Checkbook
                BankGroupBox.Enabled = False
                SelectButton.Visible = False

                OKButton.Visible = False
                CheckbookOK.Visible = True

        End Select

        LoadingLabel.Text = "Loading..."
        DirectoryView.Items.Clear()
        DirectoryView.Visible = False

    End Sub

    Private Sub Showtime() Handles Me.Shown
        RefreshNotice.Show()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    '--------------------------------[Buttons]--------------------------------

    ''' <summary>Handles the OK action during Login Mode</summary>
    Private Sub ViBELoginOK() Handles OKButton.Click

        If HasUserSelected() Then
            Commit = True
            MyReturn = DirectoryView.SelectedItems(0).Text

            Close()
        End If

    End Sub

    ''' <summary>Handles the OK action during SendMoney Mode</summary>
    Private Sub SendMonetOK() Handles SelectButton.Click

        If HasUserSelected() Then

            Dim Bank As String = "NO"
            If UMSNBRButton.Checked Then Bank = "UMSNB"
            If GBANKRButton.Checked Then Bank = "GBANK"
            If RIVERRButton.Checked Then Bank = "RIVER"

            If Bank = "NO" Then
                MsgBox("Please select a destination bank", vbCritical, "ViBE")
                Exit Sub
            End If

            Commit = True
            MyReturn = DirectoryView.SelectedItems(0).Text & "\" & Bank
            Close()

        End If

    End Sub

    ''' <summary>Handles the OK action during Checkbook Mode</summary>
    Private Sub CheckbookOK_Click() Handles CheckbookOK.Click

        If HasUserSelected() Then

            Commit = True

            ''57174: Igtampe
            MyReturn = DirectoryView.SelectedItems(0).Text & ":" & DirectoryView.SelectedItems(0).SubItems(1).Text

            Close()

        End If

    End Sub

    Private Sub Nevermind() Handles NoNoButton.Click
        Close()
    End Sub

    ''' <summary>If we're in sendmoney mode, this directory window will grab the info of the selected user</summary>
    Private Sub HeDidAClick() Handles DirectoryView.SelectedIndexChanged
        Dim Selectedindex As Integer

        Try
            Selectedindex = DirectoryView.SelectedIndices(0)
        Catch
            Exit Sub
        End Try


        If mode = DirectoryMode.SendMoney Then

            UMSNBRButton.Enabled = False
            GBANKRButton.Enabled = False
            RIVERRButton.Enabled = False

            SelectButton.Enabled = False
            NoNoButton.Enabled = False
            DirectoryView.Enabled = False
            SearchBox.Enabled = False

            Dim INFO() As String

            INFO = CoreCommands.INFO(DirectoryView.SelectedItems(0).Text).Split(",")

            If INFO(0) = 1 Then UMSNBRButton.Enabled = True Else UMSNBRButton.Enabled = False
            If INFO(2) = 1 Then GBANKRButton.Enabled = True Else GBANKRButton.Enabled = False
            If INFO(4) = 1 Then RIVERRButton.Enabled = True Else RIVERRButton.Enabled = False

            SelectButton.Enabled = True
            NoNoButton.Enabled = True
            DirectoryView.Enabled = True
            SearchBox.Enabled = True

        End If

    End Sub

    '--------------------------------[Background Worker]--------------------------------

    ''' <summary>Gets the directory from the server</summary>
    Private Sub GetDirBW() Handles BackgroundWorker1.DoWork

        ServerMSG = GetDirectory()

        DirectoryArray = ServerMSG.Split(",")
        Dim N As Integer
        Dim StringProcessor() As String

        ReDim DirectoryUsers(DirectoryArray.Count - 1)

        For N = 0 To DirectoryArray.Count - 1
            StringProcessor = DirectoryArray(N).Split(":")
            DirectoryUsers(N).ID = StringProcessor(0)
            DirectoryUsers(N).Name = StringProcessor(1)
            If DirectoryUsers(N).Name.EndsWith(" (Corp.)") Then
                DirectoryUsers(N).Name = DirectoryUsers(N).Name.Replace(" (Corp.)", "")
                DirectoryUsers(N).Category = 1
            ElseIf DirectoryUsers(N).Name.EndsWith(" (Gov.)") Then
                DirectoryUsers(N).Name = DirectoryUsers(N).Name.Replace(" (Gov.)", "")
                DirectoryUsers(N).Category = 2
            Else
                DirectoryUsers(N).Category = 0
            End If
        Next

    End Sub

    ''' <summary>Populates the listview and prepares the form for presentation</summary>
    Private Sub DoneGettingDir() Handles BackgroundWorker1.RunWorkerCompleted

        RefreshNotice.Close()

        PopulateListview()

        DirectoryView.Visible = True
        LoadingLabel.Text = DirectoryArray.Count & " Users registered"


    End Sub

    '--------------------------------[Other Functions]--------------------------------

    ''' <summary>Populate the listview</summary>
    ''' <param name="SearchItem"> find this item or items containing this </param>
    Sub PopulateListview(Optional ByVal SearchItem As String = "")


        'Clears and sets up the directory listview
        Dim I As Integer
        DirectoryView.Clear()
        DirectoryView.View = View.Details
        DirectoryView.Columns.Add("ID")
        DirectoryView.Columns.Item(0).Width = 60
        DirectoryView.Columns.Add("Name")
        DirectoryView.Columns.Item(1).Width = 200
        DirectoryView.MultiSelect = False
        DirectoryView.FullRowSelect = True
        DirectoryView.HideSelection = False
        DirectoryView.Groups.Add(New ListViewGroup("Personal Accounts", HorizontalAlignment.Left))
        DirectoryView.Groups.Add(New ListViewGroup("Corporate Accounts", HorizontalAlignment.Left))
        DirectoryView.Groups.Add(New ListViewGroup("Government and Non-Taxed Accoutns", HorizontalAlignment.Left))


        'Adds the users
        For I = 0 To DirectoryUsers.Count - 1

            Dim CLVI As ListViewItem
            If Not String.IsNullOrWhiteSpace(SearchItem) Then

                'Search Mode
                If DirectoryUsers(I).Name.ToLower.Contains(SearchItem.ToLower) Or DirectoryUsers(I).ID.Contains(SearchItem) Then
                    CLVI = New ListViewItem With {.Text = DirectoryUsers(I).ID}
                    CLVI.SubItems.Add(DirectoryUsers(I).Name)
                    CLVI.Group = DirectoryView.Groups(DirectoryUsers(I).Category)
                    DirectoryView.Items.Add(CLVI)
                End If


            Else

                'Non-Search Mode
                CLVI = New ListViewItem With {.Text = DirectoryUsers(I).ID}
                CLVI.SubItems.Add(DirectoryUsers(I).Name)
                CLVI.Group = DirectoryView.Groups(DirectoryUsers(I).Category)
                DirectoryView.Items.Add(CLVI)
            End If

        Next

    End Sub

    ''' <summary>Repopulates the listview when the searchbox is changed</summary>
    Sub RePopulateListView() Handles SearchBox.TextChanged

        If Not String.IsNullOrEmpty(SearchBox.Text) Then
            PopulateListview(SearchBox.Text)
        Else
            PopulateListview()
        End If
    End Sub

    ''' <summary>Verifies if a user from the directory is selected</summary>
    Private Function HasUserSelected()
        Dim Selectedindex As Integer

        Try
            Selectedindex = DirectoryView.SelectedIndices(0)
        Catch
            Return False
        End Try

        If Selectedindex = -1 Then
            MsgBox("Please select a User", vbCritical, "ViBE")
            Return False
        End If

        Return True

    End Function


End Class