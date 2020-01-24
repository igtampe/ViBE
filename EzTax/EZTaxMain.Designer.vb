<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EZTaxMain
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
        Me.components = New System.ComponentModel.Container()
        Dim IncomeColumn As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EZTaxMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HitLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.RemoveItemButton = New System.Windows.Forms.Button()
        Me.ModifyItemButton = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UpdatedTotalLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.EILabel = New System.Windows.Forms.Label()
        Me.UpdatedLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IncomeLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.UpdatedTaxDueLabel = New System.Windows.Forms.Label()
        Me.TaxDueLabel = New System.Windows.Forms.Label()
        Me.UpdatedTaxBracketLabel = New System.Windows.Forms.Label()
        Me.TaxBracketLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.InitialBW = New System.ComponentModel.BackgroundWorker()
        Me.EzTaxLogo = New System.Windows.Forms.PictureBox()
        Me.UpdateBTN = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EzTaxTopLabel = New System.Windows.Forms.Label()
        IncomeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.EzTaxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IncomeColumn
        '
        IncomeColumn.Text = "Income"
        IncomeColumn.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HitLabel)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.SearchBox)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 309)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Income Registry"
        '
        'HitLabel
        '
        Me.HitLabel.Location = New System.Drawing.Point(441, 13)
        Me.HitLabel.Name = "HitLabel"
        Me.HitLabel.Size = New System.Drawing.Size(62, 20)
        Me.HitLabel.TabIndex = 3
        Me.HitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Search:"
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(56, 13)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(379, 20)
        Me.SearchBox.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, IncomeColumn})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 39)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(497, 264)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 340
        '
        'DetailsButton
        '
        Me.DetailsButton.BackgroundImage = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.EzTaxButton
        Me.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DetailsButton.Image = CType(resources.GetObject("DetailsButton.Image"), System.Drawing.Image)
        Me.DetailsButton.Location = New System.Drawing.Point(93, 462)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(75, 23)
        Me.DetailsButton.TabIndex = 5
        Me.DetailsButton.Text = "View Details"
        Me.ToolTip1.SetToolTip(Me.DetailsButton, "Add a new item with the specified information")
        Me.DetailsButton.UseVisualStyleBackColor = True
        '
        'RemoveItemButton
        '
        Me.RemoveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RemoveItemButton.Image = CType(resources.GetObject("RemoveItemButton.Image"), System.Drawing.Image)
        Me.RemoveItemButton.Location = New System.Drawing.Point(255, 462)
        Me.RemoveItemButton.Name = "RemoveItemButton"
        Me.RemoveItemButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveItemButton.TabIndex = 5
        Me.RemoveItemButton.Text = "Remove"
        Me.ToolTip1.SetToolTip(Me.RemoveItemButton, "Remove the selected item")
        Me.RemoveItemButton.UseVisualStyleBackColor = True
        '
        'ModifyItemButton
        '
        Me.ModifyItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ModifyItemButton.Image = CType(resources.GetObject("ModifyItemButton.Image"), System.Drawing.Image)
        Me.ModifyItemButton.Location = New System.Drawing.Point(174, 462)
        Me.ModifyItemButton.Name = "ModifyItemButton"
        Me.ModifyItemButton.Size = New System.Drawing.Size(75, 23)
        Me.ModifyItemButton.TabIndex = 5
        Me.ModifyItemButton.Text = "Modify"
        Me.ToolTip1.SetToolTip(Me.ModifyItemButton, "Modify the selected item so that it has the specified information")
        Me.ModifyItemButton.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Quit.Image = CType(resources.GetObject("Quit.Image"), System.Drawing.Image)
        Me.Quit.Location = New System.Drawing.Point(434, 462)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(75, 23)
        Me.Quit.TabIndex = 5
        Me.Quit.Text = "Quit"
        Me.ToolTip1.SetToolTip(Me.Quit, "Quit EzTax")
        Me.Quit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UpdatedTotalLabel)
        Me.GroupBox2.Controls.Add(Me.TotalLabel)
        Me.GroupBox2.Controls.Add(Me.EILabel)
        Me.GroupBox2.Controls.Add(Me.UpdatedLabel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.IncomeLabel)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 116)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Income"
        '
        'UpdatedTotalLabel
        '
        Me.UpdatedTotalLabel.AutoSize = True
        Me.UpdatedTotalLabel.Location = New System.Drawing.Point(101, 92)
        Me.UpdatedTotalLabel.Name = "UpdatedTotalLabel"
        Me.UpdatedTotalLabel.Size = New System.Drawing.Size(0, 13)
        Me.UpdatedTotalLabel.TabIndex = 0
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(101, 79)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(0, 13)
        Me.TotalLabel.TabIndex = 0
        '
        'EILabel
        '
        Me.EILabel.AutoSize = True
        Me.EILabel.Location = New System.Drawing.Point(101, 51)
        Me.EILabel.Name = "EILabel"
        Me.EILabel.Size = New System.Drawing.Size(0, 13)
        Me.EILabel.TabIndex = 0
        '
        'UpdatedLabel
        '
        Me.UpdatedLabel.AutoSize = True
        Me.UpdatedLabel.Location = New System.Drawing.Point(101, 38)
        Me.UpdatedLabel.Name = "UpdatedLabel"
        Me.UpdatedLabel.Size = New System.Drawing.Size(0, 13)
        Me.UpdatedLabel.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Updated Total:"
        '
        'IncomeLabel
        '
        Me.IncomeLabel.AutoSize = True
        Me.IncomeLabel.Location = New System.Drawing.Point(101, 25)
        Me.IncomeLabel.Name = "IncomeLabel"
        Me.IncomeLabel.Size = New System.Drawing.Size(0, 13)
        Me.IncomeLabel.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Extra Income:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Current Income:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Updated Income:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.UpdatedTaxDueLabel)
        Me.GroupBox3.Controls.Add(Me.TaxDueLabel)
        Me.GroupBox3.Controls.Add(Me.UpdatedTaxBracketLabel)
        Me.GroupBox3.Controls.Add(Me.TaxBracketLabel)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Location = New System.Drawing.Point(205, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 116)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tax Information"
        '
        'UpdatedTaxDueLabel
        '
        Me.UpdatedTaxDueLabel.AutoSize = True
        Me.UpdatedTaxDueLabel.Location = New System.Drawing.Point(80, 92)
        Me.UpdatedTaxDueLabel.Name = "UpdatedTaxDueLabel"
        Me.UpdatedTaxDueLabel.Size = New System.Drawing.Size(0, 13)
        Me.UpdatedTaxDueLabel.TabIndex = 0
        '
        'TaxDueLabel
        '
        Me.TaxDueLabel.AutoSize = True
        Me.TaxDueLabel.Location = New System.Drawing.Point(80, 38)
        Me.TaxDueLabel.Name = "TaxDueLabel"
        Me.TaxDueLabel.Size = New System.Drawing.Size(0, 13)
        Me.TaxDueLabel.TabIndex = 0
        '
        'UpdatedTaxBracketLabel
        '
        Me.UpdatedTaxBracketLabel.AutoSize = True
        Me.UpdatedTaxBracketLabel.Location = New System.Drawing.Point(80, 79)
        Me.UpdatedTaxBracketLabel.Name = "UpdatedTaxBracketLabel"
        Me.UpdatedTaxBracketLabel.Size = New System.Drawing.Size(0, 13)
        Me.UpdatedTaxBracketLabel.TabIndex = 0
        '
        'TaxBracketLabel
        '
        Me.TaxBracketLabel.AutoSize = True
        Me.TaxBracketLabel.Location = New System.Drawing.Point(80, 25)
        Me.TaxBracketLabel.Name = "TaxBracketLabel"
        Me.TaxBracketLabel.Size = New System.Drawing.Size(0, 13)
        Me.TaxBracketLabel.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "New Bracket:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "New Tax Due:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Tax Bracket:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Tax Due:"
        '
        'InitialBW
        '
        Me.InitialBW.WorkerReportsProgress = True
        '
        'EzTaxLogo
        '
        Me.EzTaxLogo.BackgroundImage = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.EzTax
        Me.EzTaxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EzTaxLogo.Location = New System.Drawing.Point(434, 25)
        Me.EzTaxLogo.Name = "EzTaxLogo"
        Me.EzTaxLogo.Size = New System.Drawing.Size(81, 115)
        Me.EzTaxLogo.TabIndex = 7
        Me.EzTaxLogo.TabStop = False
        '
        'UpdateBTN
        '
        Me.UpdateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateBTN.Image = CType(resources.GetObject("UpdateBTN.Image"), System.Drawing.Image)
        Me.UpdateBTN.Location = New System.Drawing.Point(336, 462)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(92, 23)
        Me.UpdateBTN.TabIndex = 5
        Me.UpdateBTN.Text = "Update Income"
        Me.ToolTip1.SetToolTip(Me.UpdateBTN, "Update your income")
        Me.UpdateBTN.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddButton.Image = CType(resources.GetObject("AddButton.Image"), System.Drawing.Image)
        Me.AddButton.Location = New System.Drawing.Point(12, 462)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 5
        Me.AddButton.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.AddButton, "About EzTax")
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'EzTaxTopLabel
        '
        Me.EzTaxTopLabel.BackColor = System.Drawing.Color.DarkBlue
        Me.EzTaxTopLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EzTaxTopLabel.ForeColor = System.Drawing.Color.White
        Me.EzTaxTopLabel.Location = New System.Drawing.Point(0, 0)
        Me.EzTaxTopLabel.Name = "EzTaxTopLabel"
        Me.EzTaxTopLabel.Size = New System.Drawing.Size(525, 22)
        Me.EzTaxTopLabel.TabIndex = 8
        Me.EzTaxTopLabel.Text = "EzTax"
        Me.EzTaxTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EZTaxMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(525, 497)
        Me.Controls.Add(Me.EzTaxTopLabel)
        Me.Controls.Add(Me.EzTaxLogo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.UpdateBTN)
        Me.Controls.Add(Me.RemoveItemButton)
        Me.Controls.Add(Me.ModifyItemButton)
        Me.Controls.Add(Me.DetailsButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EZTaxMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EZTaxMain"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.EzTaxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents DetailsButton As Button
    Friend WithEvents RemoveItemButton As Button
    Friend WithEvents ModifyItemButton As Button
    Friend WithEvents Quit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents EILabel As Label
    Friend WithEvents UpdatedLabel As Label
    Friend WithEvents IncomeLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TaxDueLabel As Label
    Friend WithEvents TaxBracketLabel As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents InitialBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents EzTaxLogo As PictureBox
    Friend WithEvents UpdatedTotalLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents UpdatedTaxDueLabel As Label
    Friend WithEvents UpdatedTaxBracketLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents UpdateBTN As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents HitLabel As Label
    Friend WithEvents EzTaxTopLabel As Label
    Friend WithEvents AddButton As Button
End Class
