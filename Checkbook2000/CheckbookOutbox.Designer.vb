<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckbookOutbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckbookOutbox))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CancelBTN = New System.Windows.Forms.Button()
        Me.SendBTN = New System.Windows.Forms.Button()
        Me.CheckVariantCombobox = New System.Windows.Forms.ComboBox()
        Me.ItemTypeCMB = New System.Windows.Forms.ComboBox()
        Me.ItemCommentTXB = New System.Windows.Forms.TextBox()
        Me.ItemValueUD = New System.Windows.Forms.NumericUpDown()
        Me.DirectoryButton = New System.Windows.Forms.Button()
        Me.ToBank = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.UMSNBRButton = New System.Windows.Forms.RadioButton()
        Me.RIVERRButton = New System.Windows.Forms.RadioButton()
        Me.GBANKRbutton = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckComment = New System.Windows.Forms.Label()
        Me.CheckTo = New System.Windows.Forms.Label()
        Me.CheckAmount = New System.Windows.Forms.Label()
        Me.BillAmount = New System.Windows.Forms.Label()
        Me.BillComment = New System.Windows.Forms.Label()
        Me.CheckFrom = New System.Windows.Forms.Label()
        Me.BillFrom = New System.Windows.Forms.Label()
        Me.CheckDate = New System.Windows.Forms.Label()
        Me.BillDate = New System.Windows.Forms.Label()
        Me.CheckName = New System.Windows.Forms.Label()
        Me.BillName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckWordAmount = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ItemValueUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BalanceLabel)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CancelBTN)
        Me.GroupBox2.Controls.Add(Me.SendBTN)
        Me.GroupBox2.Controls.Add(Me.CheckVariantCombobox)
        Me.GroupBox2.Controls.Add(Me.ItemTypeCMB)
        Me.GroupBox2.Controls.Add(Me.ItemCommentTXB)
        Me.GroupBox2.Controls.Add(Me.ItemValueUD)
        Me.GroupBox2.Controls.Add(Me.DirectoryButton)
        Me.GroupBox2.Controls.Add(Me.ToBank)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 333)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 154)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Form"
        '
        'BalanceLabel
        '
        Me.BalanceLabel.Location = New System.Drawing.Point(70, 79)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(160, 13)
        Me.BalanceLabel.TabIndex = 14
        Me.BalanceLabel.Text = "0p"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Funds"
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(455, 125)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(75, 23)
        Me.CancelBTN.TabIndex = 13
        Me.CancelBTN.Text = "Cancel"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'SendBTN
        '
        Me.SendBTN.Location = New System.Drawing.Point(536, 125)
        Me.SendBTN.Name = "SendBTN"
        Me.SendBTN.Size = New System.Drawing.Size(75, 23)
        Me.SendBTN.TabIndex = 13
        Me.SendBTN.Text = "Send"
        Me.SendBTN.UseVisualStyleBackColor = True
        '
        'CheckVariantCombobox
        '
        Me.CheckVariantCombobox.FormattingEnabled = True
        Me.CheckVariantCombobox.Items.AddRange(New Object() {"Default", "Gray", "Green", "Purple", "Red", "Yellow", "Black"})
        Me.CheckVariantCombobox.Location = New System.Drawing.Point(301, 127)
        Me.CheckVariantCombobox.Name = "CheckVariantCombobox"
        Me.CheckVariantCombobox.Size = New System.Drawing.Size(122, 21)
        Me.CheckVariantCombobox.TabIndex = 12
        '
        'ItemTypeCMB
        '
        Me.ItemTypeCMB.FormattingEnabled = True
        Me.ItemTypeCMB.Items.AddRange(New Object() {"Check", "Bill"})
        Me.ItemTypeCMB.Location = New System.Drawing.Point(301, 103)
        Me.ItemTypeCMB.Name = "ItemTypeCMB"
        Me.ItemTypeCMB.Size = New System.Drawing.Size(122, 21)
        Me.ItemTypeCMB.TabIndex = 12
        '
        'ItemCommentTXB
        '
        Me.ItemCommentTXB.Location = New System.Drawing.Point(258, 35)
        Me.ItemCommentTXB.Multiline = True
        Me.ItemCommentTXB.Name = "ItemCommentTXB"
        Me.ItemCommentTXB.Size = New System.Drawing.Size(353, 57)
        Me.ItemCommentTXB.TabIndex = 11
        '
        'ItemValueUD
        '
        Me.ItemValueUD.Location = New System.Drawing.Point(70, 128)
        Me.ItemValueUD.Maximum = New Decimal(New Integer() {705032704, 1, 0, 0})
        Me.ItemValueUD.Name = "ItemValueUD"
        Me.ItemValueUD.Size = New System.Drawing.Size(160, 20)
        Me.ItemValueUD.TabIndex = 10
        '
        'DirectoryButton
        '
        Me.DirectoryButton.Font = New System.Drawing.Font("Wingdings 2", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.DirectoryButton.Location = New System.Drawing.Point(210, 99)
        Me.DirectoryButton.Name = "DirectoryButton"
        Me.DirectoryButton.Size = New System.Drawing.Size(20, 19)
        Me.DirectoryButton.TabIndex = 9
        Me.DirectoryButton.Text = ","
        Me.DirectoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.DirectoryButton.UseVisualStyleBackColor = True
        '
        'ToBank
        '
        Me.ToBank.Enabled = False
        Me.ToBank.Location = New System.Drawing.Point(70, 99)
        Me.ToBank.Name = "ToBank"
        Me.ToBank.Size = New System.Drawing.Size(134, 20)
        Me.ToBank.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.UMSNBRButton)
        Me.GroupBox3.Controls.Add(Me.RIVERRButton)
        Me.GroupBox3.Controls.Add(Me.GBANKRbutton)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 47)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bank"
        '
        'UMSNBRButton
        '
        Me.UMSNBRButton.AutoSize = True
        Me.UMSNBRButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.UMSNBRButton.Location = New System.Drawing.Point(6, 19)
        Me.UMSNBRButton.Name = "UMSNBRButton"
        Me.UMSNBRButton.Size = New System.Drawing.Size(64, 17)
        Me.UMSNBRButton.TabIndex = 5
        Me.UMSNBRButton.Text = "UMSNB"
        Me.UMSNBRButton.UseVisualStyleBackColor = True
        '
        'RIVERRButton
        '
        Me.RIVERRButton.AutoSize = True
        Me.RIVERRButton.Location = New System.Drawing.Point(144, 19)
        Me.RIVERRButton.Name = "RIVERRButton"
        Me.RIVERRButton.Size = New System.Drawing.Size(58, 17)
        Me.RIVERRButton.TabIndex = 3
        Me.RIVERRButton.Text = "RIVER"
        Me.RIVERRButton.UseVisualStyleBackColor = True
        '
        'GBANKRbutton
        '
        Me.GBANKRbutton.AutoSize = True
        Me.GBANKRbutton.Location = New System.Drawing.Point(76, 19)
        Me.GBANKRbutton.Name = "GBANKRbutton"
        Me.GBANKRbutton.Size = New System.Drawing.Size(62, 17)
        Me.GBANKRbutton.TabIndex = 4
        Me.GBANKRbutton.Text = "GBANK"
        Me.GBANKRbutton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Variant"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Comment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Account"
        '
        'CheckComment
        '
        Me.CheckComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckComment.Location = New System.Drawing.Point(55, 228)
        Me.CheckComment.Name = "CheckComment"
        Me.CheckComment.Size = New System.Drawing.Size(228, 14)
        Me.CheckComment.TabIndex = 10
        Me.CheckComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CheckComment.Visible = False
        '
        'CheckTo
        '
        Me.CheckTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckTo.Location = New System.Drawing.Point(78, 117)
        Me.CheckTo.Name = "CheckTo"
        Me.CheckTo.Size = New System.Drawing.Size(375, 18)
        Me.CheckTo.TabIndex = 10
        Me.CheckTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CheckTo.Visible = False
        '
        'CheckAmount
        '
        Me.CheckAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CheckAmount.Location = New System.Drawing.Point(468, 120)
        Me.CheckAmount.Name = "CheckAmount"
        Me.CheckAmount.Size = New System.Drawing.Size(112, 19)
        Me.CheckAmount.TabIndex = 10
        Me.CheckAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckAmount.Visible = False
        '
        'BillAmount
        '
        Me.BillAmount.BackColor = System.Drawing.Color.White
        Me.BillAmount.Location = New System.Drawing.Point(477, 172)
        Me.BillAmount.Name = "BillAmount"
        Me.BillAmount.Size = New System.Drawing.Size(114, 56)
        Me.BillAmount.TabIndex = 10
        Me.BillAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BillAmount.Visible = False
        '
        'BillComment
        '
        Me.BillComment.BackColor = System.Drawing.Color.White
        Me.BillComment.Location = New System.Drawing.Point(26, 172)
        Me.BillComment.Name = "BillComment"
        Me.BillComment.Size = New System.Drawing.Size(429, 56)
        Me.BillComment.TabIndex = 9
        Me.BillComment.Visible = False
        '
        'CheckFrom
        '
        Me.CheckFrom.AutoSize = True
        Me.CheckFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckFrom.Location = New System.Drawing.Point(28, 80)
        Me.CheckFrom.Name = "CheckFrom"
        Me.CheckFrom.Size = New System.Drawing.Size(0, 13)
        Me.CheckFrom.TabIndex = 8
        Me.CheckFrom.Visible = False
        '
        'BillFrom
        '
        Me.BillFrom.AutoSize = True
        Me.BillFrom.BackColor = System.Drawing.Color.White
        Me.BillFrom.Location = New System.Drawing.Point(17, 99)
        Me.BillFrom.Name = "BillFrom"
        Me.BillFrom.Size = New System.Drawing.Size(0, 13)
        Me.BillFrom.TabIndex = 8
        Me.BillFrom.Visible = False
        '
        'CheckDate
        '
        Me.CheckDate.AutoSize = True
        Me.CheckDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDate.Location = New System.Drawing.Point(344, 77)
        Me.CheckDate.Name = "CheckDate"
        Me.CheckDate.Size = New System.Drawing.Size(151, 18)
        Me.CheckDate.TabIndex = 7
        Me.CheckDate.Text = "12/4/2018 5:05:03 PM"
        Me.CheckDate.Visible = False
        '
        'BillDate
        '
        Me.BillDate.AutoSize = True
        Me.BillDate.BackColor = System.Drawing.Color.White
        Me.BillDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillDate.Location = New System.Drawing.Point(429, 34)
        Me.BillDate.Name = "BillDate"
        Me.BillDate.Size = New System.Drawing.Size(151, 18)
        Me.BillDate.TabIndex = 7
        Me.BillDate.Text = "12/4/2018 5:05:03 PM"
        Me.BillDate.Visible = False
        '
        'CheckName
        '
        Me.CheckName.AutoSize = True
        Me.CheckName.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckName.Location = New System.Drawing.Point(26, 52)
        Me.CheckName.Name = "CheckName"
        Me.CheckName.Size = New System.Drawing.Size(414, 25)
        Me.CheckName.TabIndex = 6
        Me.CheckName.Text = "The Saint John Paul II Charity (11259)"
        Me.CheckName.Visible = False
        '
        'BillName
        '
        Me.BillName.AutoSize = True
        Me.BillName.BackColor = System.Drawing.Color.White
        Me.BillName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillName.Location = New System.Drawing.Point(15, 52)
        Me.BillName.Name = "BillName"
        Me.BillName.Size = New System.Drawing.Size(414, 25)
        Me.BillName.TabIndex = 6
        Me.BillName.Text = "The Saint John Paul II Charity (11259)"
        Me.BillName.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.Check
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(605, 286)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckWordAmount)
        Me.GroupBox1.Controls.Add(Me.CheckComment)
        Me.GroupBox1.Controls.Add(Me.CheckTo)
        Me.GroupBox1.Controls.Add(Me.CheckAmount)
        Me.GroupBox1.Controls.Add(Me.BillAmount)
        Me.GroupBox1.Controls.Add(Me.BillComment)
        Me.GroupBox1.Controls.Add(Me.CheckFrom)
        Me.GroupBox1.Controls.Add(Me.BillFrom)
        Me.GroupBox1.Controls.Add(Me.CheckDate)
        Me.GroupBox1.Controls.Add(Me.BillDate)
        Me.GroupBox1.Controls.Add(Me.CheckName)
        Me.GroupBox1.Controls.Add(Me.BillName)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 315)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview"
        '
        'CheckWordAmount
        '
        Me.CheckWordAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckWordAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckWordAmount.Location = New System.Drawing.Point(31, 144)
        Me.CheckWordAmount.Name = "CheckWordAmount"
        Me.CheckWordAmount.Size = New System.Drawing.Size(489, 24)
        Me.CheckWordAmount.TabIndex = 11
        Me.CheckWordAmount.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckWordAmount.Visible = False
        '
        'CheckbookOutbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 499)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CheckbookOutbox"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Outbox"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ItemValueUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckComment As Label
    Friend WithEvents CheckTo As Label
    Friend WithEvents CheckAmount As Label
    Friend WithEvents BillAmount As Label
    Friend WithEvents BillComment As Label
    Friend WithEvents CheckFrom As Label
    Friend WithEvents BillFrom As Label
    Friend WithEvents CheckDate As Label
    Friend WithEvents BillDate As Label
    Friend WithEvents CheckName As Label
    Friend WithEvents BillName As Label
    Friend WithEvents RIVERRButton As RadioButton
    Friend WithEvents GBANKRbutton As RadioButton
    Friend WithEvents UMSNBRButton As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToBank As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DirectoryButton As Button
    Friend WithEvents CancelBTN As Button
    Friend WithEvents SendBTN As Button
    Friend WithEvents ItemTypeCMB As ComboBox
    Friend WithEvents ItemCommentTXB As TextBox
    Friend WithEvents ItemValueUD As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BalanceLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckWordAmount As Label
    Friend WithEvents CheckVariantCombobox As ComboBox
    Friend WithEvents Label6 As Label
End Class
