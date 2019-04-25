<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"47471", "Senor Tipillo"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DirWindow))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadingLabel = New System.Windows.Forms.Label()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.UserGroupBox = New System.Windows.Forms.GroupBox()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DirectoryView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OKButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CheckbookOK = New System.Windows.Forms.Button()
        Me.UMSNBRButton = New System.Windows.Forms.RadioButton()
        Me.GBANKRButton = New System.Windows.Forms.RadioButton()
        Me.RIVERRButton = New System.Windows.Forms.RadioButton()
        Me.BankGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserGroupBox.SuspendLayout()
        Me.BankGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.UMSWEB
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UMSWEB Directory"
        '
        'LoadingLabel
        '
        Me.LoadingLabel.AutoSize = True
        Me.LoadingLabel.Location = New System.Drawing.Point(107, 37)
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(54, 13)
        Me.LoadingLabel.TabIndex = 2
        Me.LoadingLabel.Text = "Loading..."
        '
        'SelectButton
        '
        Me.SelectButton.Location = New System.Drawing.Point(12, 419)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(134, 23)
        Me.SelectButton.TabIndex = 4
        Me.SelectButton.Text = "Select"
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(185, 419)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(134, 23)
        Me.CancelButton.TabIndex = 4
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'UserGroupBox
        '
        Me.UserGroupBox.Controls.Add(Me.SearchBox)
        Me.UserGroupBox.Controls.Add(Me.Label2)
        Me.UserGroupBox.Controls.Add(Me.DirectoryView)
        Me.UserGroupBox.Location = New System.Drawing.Point(12, 71)
        Me.UserGroupBox.Name = "UserGroupBox"
        Me.UserGroupBox.Size = New System.Drawing.Size(308, 284)
        Me.UserGroupBox.TabIndex = 5
        Me.UserGroupBox.TabStop = False
        Me.UserGroupBox.Text = "User"
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(53, 13)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(247, 20)
        Me.SearchBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search"
        '
        'DirectoryView
        '
        Me.DirectoryView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.DirectoryView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.DirectoryView.Location = New System.Drawing.Point(6, 42)
        Me.DirectoryView.MultiSelect = False
        Me.DirectoryView.Name = "DirectoryView"
        Me.DirectoryView.Size = New System.Drawing.Size(294, 236)
        Me.DirectoryView.TabIndex = 4
        Me.DirectoryView.UseCompatibleStateImageBehavior = False
        Me.DirectoryView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 200
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(12, 419)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(134, 23)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        Me.OKButton.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'CheckbookOK
        '
        Me.CheckbookOK.Location = New System.Drawing.Point(12, 419)
        Me.CheckbookOK.Name = "CheckbookOK"
        Me.CheckbookOK.Size = New System.Drawing.Size(134, 23)
        Me.CheckbookOK.TabIndex = 1
        Me.CheckbookOK.Text = "OK"
        Me.CheckbookOK.UseVisualStyleBackColor = True
        Me.CheckbookOK.Visible = False
        '
        'UMSNBRButton
        '
        Me.UMSNBRButton.AutoSize = True
        Me.UMSNBRButton.Location = New System.Drawing.Point(6, 19)
        Me.UMSNBRButton.Name = "UMSNBRButton"
        Me.UMSNBRButton.Size = New System.Drawing.Size(64, 17)
        Me.UMSNBRButton.TabIndex = 0
        Me.UMSNBRButton.TabStop = True
        Me.UMSNBRButton.Text = "UMSNB"
        Me.UMSNBRButton.UseVisualStyleBackColor = True
        '
        'GBANKRButton
        '
        Me.GBANKRButton.AutoSize = True
        Me.GBANKRButton.Location = New System.Drawing.Point(121, 19)
        Me.GBANKRButton.Name = "GBANKRButton"
        Me.GBANKRButton.Size = New System.Drawing.Size(62, 17)
        Me.GBANKRButton.TabIndex = 0
        Me.GBANKRButton.TabStop = True
        Me.GBANKRButton.Text = "GBANK"
        Me.GBANKRButton.UseVisualStyleBackColor = True
        '
        'RIVERRButton
        '
        Me.RIVERRButton.AutoSize = True
        Me.RIVERRButton.Location = New System.Drawing.Point(242, 19)
        Me.RIVERRButton.Name = "RIVERRButton"
        Me.RIVERRButton.Size = New System.Drawing.Size(58, 17)
        Me.RIVERRButton.TabIndex = 0
        Me.RIVERRButton.TabStop = True
        Me.RIVERRButton.Text = "RIVER"
        Me.RIVERRButton.UseVisualStyleBackColor = True
        '
        'BankGroupBox
        '
        Me.BankGroupBox.Controls.Add(Me.RIVERRButton)
        Me.BankGroupBox.Controls.Add(Me.GBANKRButton)
        Me.BankGroupBox.Controls.Add(Me.UMSNBRButton)
        Me.BankGroupBox.Location = New System.Drawing.Point(12, 361)
        Me.BankGroupBox.Name = "BankGroupBox"
        Me.BankGroupBox.Size = New System.Drawing.Size(306, 52)
        Me.BankGroupBox.TabIndex = 6
        Me.BankGroupBox.TabStop = False
        Me.BankGroupBox.Text = "Bank"
        '
        'DirWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 454)
        Me.Controls.Add(Me.CheckbookOK)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.BankGroupBox)
        Me.Controls.Add(Me.UserGroupBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SelectButton)
        Me.Controls.Add(Me.LoadingLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(347, 505)
        Me.MinimumSize = New System.Drawing.Size(347, 300)

        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Directory"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserGroupBox.ResumeLayout(False)
        Me.UserGroupBox.PerformLayout()
        Me.BankGroupBox.ResumeLayout(False)
        Me.BankGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadingLabel As Label
    Friend WithEvents SelectButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents UserGroupBox As GroupBox
    Friend WithEvents OKButton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ID As ColumnHeader
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents Name As ColumnHeader
    Friend WithEvents CheckbookOK As Button
    Friend WithEvents UMSNBRButton As RadioButton
    Friend WithEvents GBANKRButton As RadioButton
    Friend WithEvents RIVERRButton As RadioButton
    Friend WithEvents BankGroupBox As GroupBox
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DirectoryView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
End Class
