<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckbookInbox
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"12/4/2018 5:05:03 PM", "BILL", "The Saint John Paul II Charity ", "5,000,000p"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckbookInbox))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.C1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.C2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.C3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.C4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckWordAmount = New System.Windows.Forms.Label()
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
        Me.RIVERRButton = New System.Windows.Forms.RadioButton()
        Me.GBANKRbutton = New System.Windows.Forms.RadioButton()
        Me.UMSNBRButton = New System.Windows.Forms.RadioButton()
        Me.DELETTHIS = New System.Windows.Forms.Button()
        Me.ActionBTN = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.C1, Me.C2, Me.C3, Me.C4})
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.Location = New System.Drawing.Point(6, 20)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(605, 148)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'C1
        '
        Me.C1.Text = "Date and Time"
        Me.C1.Width = 138
        '
        'C2
        '
        Me.C2.Text = "Type"
        Me.C2.Width = 40
        '
        'C3
        '
        Me.C3.Text = "From"
        Me.C3.Width = 245
        '
        'C4
        '
        Me.C4.Text = "Amount"
        Me.C4.Width = 160
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
        Me.GroupBox1.Controls.Add(Me.RIVERRButton)
        Me.GroupBox1.Controls.Add(Me.GBANKRbutton)
        Me.GroupBox1.Controls.Add(Me.UMSNBRButton)
        Me.GroupBox1.Controls.Add(Me.DELETTHIS)
        Me.GroupBox1.Controls.Add(Me.ActionBTN)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 340)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'CheckWordAmount
        '
        Me.CheckWordAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckWordAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckWordAmount.Location = New System.Drawing.Point(31, 148)
        Me.CheckWordAmount.Name = "CheckWordAmount"
        Me.CheckWordAmount.Size = New System.Drawing.Size(490, 20)
        Me.CheckWordAmount.TabIndex = 12
        Me.CheckWordAmount.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckWordAmount.Visible = False
        '
        'CheckComment
        '
        Me.CheckComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckComment.Location = New System.Drawing.Point(60, 228)
        Me.CheckComment.Name = "CheckComment"
        Me.CheckComment.Size = New System.Drawing.Size(223, 14)
        Me.CheckComment.TabIndex = 10
        Me.CheckComment.Text = "IGTAMPE (57174)"
        Me.CheckComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CheckComment.Visible = False
        '
        'CheckTo
        '
        Me.CheckTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckTo.Location = New System.Drawing.Point(78, 119)
        Me.CheckTo.Name = "CheckTo"
        Me.CheckTo.Size = New System.Drawing.Size(351, 16)
        Me.CheckTo.TabIndex = 10
        Me.CheckTo.Text = "IGTAMPE (57174)"
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
        Me.CheckAmount.Text = "5,000,000p"
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
        Me.BillAmount.Text = "5,000,000p"
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
        Me.BillComment.Text = "Label1"
        Me.BillComment.Visible = False
        '
        'CheckFrom
        '
        Me.CheckFrom.AutoSize = True
        Me.CheckFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckFrom.Location = New System.Drawing.Point(28, 80)
        Me.CheckFrom.Name = "CheckFrom"
        Me.CheckFrom.Size = New System.Drawing.Size(81, 13)
        Me.CheckFrom.TabIndex = 8
        Me.CheckFrom.Text = "(11259\RIVER)"
        Me.CheckFrom.Visible = False
        '
        'BillFrom
        '
        Me.BillFrom.AutoSize = True
        Me.BillFrom.BackColor = System.Drawing.Color.White
        Me.BillFrom.Location = New System.Drawing.Point(17, 99)
        Me.BillFrom.Name = "BillFrom"
        Me.BillFrom.Size = New System.Drawing.Size(81, 13)
        Me.BillFrom.TabIndex = 8
        Me.BillFrom.Text = "(11259\RIVER)"
        Me.BillFrom.Visible = False
        '
        'CheckDate
        '
        Me.CheckDate.AutoSize = True
        Me.CheckDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDate.Location = New System.Drawing.Point(345, 77)
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
        'RIVERRButton
        '
        Me.RIVERRButton.AutoSize = True
        Me.RIVERRButton.Location = New System.Drawing.Point(416, 314)
        Me.RIVERRButton.Name = "RIVERRButton"
        Me.RIVERRButton.Size = New System.Drawing.Size(58, 17)
        Me.RIVERRButton.TabIndex = 3
        Me.RIVERRButton.Text = "RIVER"
        Me.RIVERRButton.UseVisualStyleBackColor = True
        '
        'GBANKRbutton
        '
        Me.GBANKRbutton.AutoSize = True
        Me.GBANKRbutton.Location = New System.Drawing.Point(348, 314)
        Me.GBANKRbutton.Name = "GBANKRbutton"
        Me.GBANKRbutton.Size = New System.Drawing.Size(62, 17)
        Me.GBANKRbutton.TabIndex = 4
        Me.GBANKRbutton.Text = "GBANK"
        Me.GBANKRbutton.UseVisualStyleBackColor = True
        '
        'UMSNBRButton
        '
        Me.UMSNBRButton.AutoSize = True
        Me.UMSNBRButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.UMSNBRButton.Location = New System.Drawing.Point(278, 314)
        Me.UMSNBRButton.Name = "UMSNBRButton"
        Me.UMSNBRButton.Size = New System.Drawing.Size(64, 17)
        Me.UMSNBRButton.TabIndex = 5
        Me.UMSNBRButton.Text = "UMSNB"
        Me.UMSNBRButton.UseVisualStyleBackColor = True
        '
        'DELETTHIS
        '
        Me.DELETTHIS.Location = New System.Drawing.Point(6, 311)
        Me.DELETTHIS.Name = "DELETTHIS"
        Me.DELETTHIS.Size = New System.Drawing.Size(109, 23)
        Me.DELETTHIS.TabIndex = 2
        Me.DELETTHIS.Text = "Delete this item"
        Me.DELETTHIS.UseVisualStyleBackColor = True
        '
        'ActionBTN
        '
        Me.ActionBTN.Location = New System.Drawing.Point(480, 311)
        Me.ActionBTN.Name = "ActionBTN"
        Me.ActionBTN.Size = New System.Drawing.Size(131, 23)
        Me.ActionBTN.TabIndex = 1
        Me.ActionBTN.UseVisualStyleBackColor = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 358)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 174)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inbox"
        '
        'BackgroundWorker1
        '
        '
        'CheckbookInbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 544)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CheckbookInbox"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inbox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DELETTHIS As Button
    Friend WithEvents ActionBTN As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents C1 As ColumnHeader
    Friend WithEvents C2 As ColumnHeader
    Friend WithEvents C3 As ColumnHeader
    Friend WithEvents C4 As ColumnHeader
    Friend WithEvents RIVERRButton As RadioButton
    Friend WithEvents GBANKRbutton As RadioButton
    Friend WithEvents UMSNBRButton As RadioButton
    Friend WithEvents CheckTo As Label
    Friend WithEvents CheckAmount As Label
    Friend WithEvents BillAmount As Label
    Friend WithEvents BillComment As Label
    Friend WithEvents BillFrom As Label
    Friend WithEvents CheckDate As Label
    Friend WithEvents BillDate As Label
    Friend WithEvents CheckName As Label
    Friend WithEvents BillName As Label
    Friend WithEvents CheckComment As Label
    Friend WithEvents CheckFrom As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckWordAmount As Label
End Class
