Imports VIBE__But_on_Visual_Studio_.Core
Public Class DirWindow

    Public sortcolumn
    Public DirectoryArray() As String
    Public ServerMSG As String
    Public Structure DirectoryTable

        Public ID As String
        Public Name As String
        Public Category As Integer

    End Structure

    Public DirectoryUser() As DirectoryTable

    Private Sub DootDootDootDootDoot(Sender As Object, e As EventArgs) Handles Me.Load
        If Application.OpenForms().OfType(Of SendMonet).Any Then

            BankGroupBox.Enabled = True
            SelectButton.Visible = True

            OKButton.Visible = False
            CheckbookOK.Visible = False

        ElseIf Application.OpenForms().OfType(Of CheckbookOutbox).Any Then
            BankGroupBox.Enabled = False
            SelectButton.Visible = False

            OKButton.Visible = False
            CheckbookOK.Visible = True


        Else
            'From VibeLOGIN
            BankGroupBox.Enabled = False
            SelectButton.Visible = False

            OKButton.Visible = True
            CheckbookOK.Visible = False

        End If

        LoadingLabel.Text = "Loading..."
        DirectoryView.Items.Clear()
        DirectoryView.Visible = False

    End Sub

    Private Sub LoadAllTheCosos(Sender As Object, e As EventArgs) Handles Me.Shown
        RefreshNotice.Show()
        BackgroundWorker1.RunWorkerAsync()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim Selectedindex As Integer
        Try
            Selectedindex = DirectoryView.SelectedIndices(0)
        Catch
            Exit Sub
        End Try


        If Selectedindex = -1 Then

            MsgBox("Please select a User", vbCritical, "ViBE")
            Exit Sub

        End If

        VibeLogin.LogonID.Text = DirectoryView.SelectedItems(0).Text
        VibeLogin.LogonPIN.Text = ""


        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        'Send Info to the requested field

        Dim Bank As String
        Dim Selectedindex As Integer
        Try
            Selectedindex = DirectoryView.SelectedIndices(0)
        Catch
            Exit Sub
        End Try

        Bank = "NO"
        If UMSNBRButton.Checked Then Bank = "UMSNB"
        If GBANKRButton.Checked Then Bank = "GBANK"
        If RIVERRButton.Checked Then Bank = "RIVER"

        If Selectedindex = -1 Then

            MsgBox("Please select who you will ~ViBE~ money to", vbCritical, "ViBE")
            Exit Sub

        End If

        If Bank = "NO" Then

            MsgBox("Please select a destination bank", vbCritical, "ViBE")
            Exit Sub

        End If


        SendMonet.DestinationBox.Text = DirectoryView.SelectedItems(0).Text & "\" & Bank
        Close()


    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles NoNoButton.Click
        Close()
    End Sub

    Private Sub HeDidAClick() Handles DirectoryView.SelectedIndexChanged
        Dim Selectedindex As Integer

        Try
            Selectedindex = DirectoryView.SelectedIndices(0)
        Catch
            Exit Sub
        End Try


        If Application.OpenForms().OfType(Of SendMonet).Any Then

            UMSNBRButton.Enabled = False
            GBANKRButton.Enabled = False
            RIVERRButton.Enabled = False

            SelectButton.Enabled = False
            NoNoButton.Enabled = False
            DirectoryView.Enabled = False
            SearchBox.Enabled = False



            Dim INFO() As String

            INFO = Core.INFO(DirectoryView.SelectedItems(0).Text).Split(",")

            If INFO(0) = 1 Then UMSNBRButton.Enabled = True Else UMSNBRButton.Enabled = False
            If INFO(2) = 1 Then GBANKRButton.Enabled = True Else GBANKRButton.Enabled = False
            If INFO(4) = 1 Then RIVERRButton.Enabled = True Else RIVERRButton.Enabled = False

            SelectButton.Enabled = True
            NoNoButton.Enabled = True
            DirectoryView.Enabled = True
            SearchBox.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        ServerMSG = GetDirectory()

        DirectoryArray = ServerMSG.Split(",")
        Dim N As Integer
        Dim StringProcessor() As String

        ReDim DirectoryUser(DirectoryArray.Count - 1)

        For N = 0 To DirectoryArray.Count - 1
            StringProcessor = DirectoryArray(N).Split(":")
            DirectoryUser(N).ID = StringProcessor(0)
            DirectoryUser(N).Name = StringProcessor(1)
            If DirectoryUser(N).Name.EndsWith(" (Corp.)") Then
                DirectoryUser(N).Name = DirectoryUser(N).Name.Replace(" (Corp.)", "")
                DirectoryUser(N).Category = 1
            ElseIf DirectoryUser(N).Name.EndsWith(" (Gov.)") Then
                DirectoryUser(N).Name = DirectoryUser(N).Name.Replace(" (Gov.)", "")
                DirectoryUser(N).Category = 2
            Else
                DirectoryUser(N).Category = 0
            End If
        Next

    End Sub

    Private Sub BackgroundWorker1_Done() Handles BackgroundWorker1.RunWorkerCompleted

        RefreshNotice.Close()

        PopulateListview()

        DirectoryView.Visible = True
        LoadingLabel.Text = DirectoryArray.Count & " Users registered"


    End Sub

    ''' <summary>
    ''' Populate the listview
    ''' </summary>
    ''' <param name="SearchItem"> find this item or items containing this </param>
    Sub PopulateListview(Optional ByVal SearchItem As String = "")


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



        For I = 0 To DirectoryUser.Count - 1

            Dim CLVI As ListViewItem
            If Not String.IsNullOrEmpty(SearchItem) Then
                If DirectoryUser(I).Name.ToLower.Contains(SearchItem.ToLower) Then
                    CLVI = New ListViewItem With {
                .Text = DirectoryUser(I).ID
            }
                    CLVI.SubItems.Add(DirectoryUser(I).Name)
                    CLVI.Group = DirectoryView.Groups(DirectoryUser(I).Category)
                    DirectoryView.Items.Add(CLVI)

                End If
            Else
                CLVI = New ListViewItem With {
                .Text = DirectoryUser(I).ID
            }
                CLVI.SubItems.Add(DirectoryUser(I).Name)
                CLVI.Group = DirectoryView.Groups(DirectoryUser(I).Category)
                DirectoryView.Items.Add(CLVI)
            End If



        Next


    End Sub


    Private Sub CheckbookOK_Click(sender As Object, e As EventArgs) Handles CheckbookOK.Click
        Dim Selectedindex As Integer
        Try
            Selectedindex = DirectoryView.SelectedIndices(0)
        Catch
            Exit Sub
        End Try

        If Selectedindex = -1 Then

            MsgBox("Please select a User", vbCritical, "ViBE")
            Exit Sub

        End If

        CheckbookOutbox.ToBank.Text = DirectoryView.SelectedItems(0).Text
        ''57174: Igtampe
        CheckbookOutbox.CheckTo.Text = DirectoryView.SelectedItems(0).SubItems(1).Text & " (" & DirectoryView.SelectedItems(0).Text & ")"

        Close()

    End Sub

    'Me.Name = "DirWindow"
    Sub RePopulateListView() Handles SearchBox.TextChanged

        If Not String.IsNullOrEmpty(SearchBox.Text) Then
            PopulateListview(SearchBox.Text)
        Else
            PopulateListview()
        End If
    End Sub


End Class