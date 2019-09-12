<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConMain))
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AvConLVIEW = New System.Windows.Forms.ListView()
        Me.ItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.From = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TopBid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TopBidFrom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BidBTN = New System.Windows.Forms.Button()
        Me.AvDetails = New System.Windows.Forms.Button()
        Me.AddContract = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AcConLVIEW = New System.Windows.Forms.ListView()
        Me.NameActive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FromActive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SendBillBTN = New System.Windows.Forms.Button()
        Me.AcDetails = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.InitialBW = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(12, 12)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(342, 32)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Cornerstone LLC (57174)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.Contractus
        Me.PictureBox1.Location = New System.Drawing.Point(368, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(15, 44)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(178, 13)
        Me.AmountLabel.TabIndex = 3
        Me.AmountLabel.Text = "0 Active Contracts, 1 Open Contract"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AvConLVIEW)
        Me.GroupBox1.Controls.Add(Me.BidBTN)
        Me.GroupBox1.Controls.Add(Me.AvDetails)
        Me.GroupBox1.Controls.Add(Me.AddContract)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 200)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Available Contracts"
        '
        'AvConLVIEW
        '
        Me.AvConLVIEW.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemName, Me.From, Me.TopBid, Me.TopBidFrom})
        Me.AvConLVIEW.HideSelection = False
        Me.AvConLVIEW.Location = New System.Drawing.Point(6, 19)
        Me.AvConLVIEW.Name = "AvConLVIEW"
        Me.AvConLVIEW.Size = New System.Drawing.Size(416, 146)
        Me.AvConLVIEW.TabIndex = 11
        Me.AvConLVIEW.UseCompatibleStateImageBehavior = False
        Me.AvConLVIEW.View = System.Windows.Forms.View.Details
        '
        'ItemName
        '
        Me.ItemName.Text = "Name"
        Me.ItemName.Width = 184
        '
        'From
        '
        Me.From.Text = "Posted By"
        '
        'TopBid
        '
        Me.TopBid.Text = "Top Bid"
        Me.TopBid.Width = 77
        '
        'TopBidFrom
        '
        Me.TopBidFrom.Text = "Top Bidder"
        Me.TopBidFrom.Width = 72
        '
        'BidBTN
        '
        Me.BidBTN.Location = New System.Drawing.Point(347, 171)
        Me.BidBTN.Name = "BidBTN"
        Me.BidBTN.Size = New System.Drawing.Size(75, 23)
        Me.BidBTN.TabIndex = 7
        Me.BidBTN.Text = "Bid"
        Me.BidBTN.UseVisualStyleBackColor = True
        '
        'AvDetails
        '
        Me.AvDetails.Location = New System.Drawing.Point(266, 171)
        Me.AvDetails.Name = "AvDetails"
        Me.AvDetails.Size = New System.Drawing.Size(75, 23)
        Me.AvDetails.TabIndex = 6
        Me.AvDetails.Text = "Details"
        Me.AvDetails.UseVisualStyleBackColor = True
        '
        'AddContract
        '
        Me.AddContract.Location = New System.Drawing.Point(6, 171)
        Me.AddContract.Name = "AddContract"
        Me.AddContract.Size = New System.Drawing.Size(118, 23)
        Me.AddContract.TabIndex = 5
        Me.AddContract.Text = "Add Contract"
        Me.AddContract.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(416, 149)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "No contracts are available at this time"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AcConLVIEW)
        Me.GroupBox2.Controls.Add(Me.SendBillBTN)
        Me.GroupBox2.Controls.Add(Me.AcDetails)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 290)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 200)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Active Contracts"
        '
        'AcConLVIEW
        '
        Me.AcConLVIEW.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameActive, Me.FromActive, Me.Amount})
        Me.AcConLVIEW.HideSelection = False
        Me.AcConLVIEW.Location = New System.Drawing.Point(6, 19)
        Me.AcConLVIEW.Name = "AcConLVIEW"
        Me.AcConLVIEW.Size = New System.Drawing.Size(416, 146)
        Me.AcConLVIEW.TabIndex = 10
        Me.AcConLVIEW.UseCompatibleStateImageBehavior = False
        Me.AcConLVIEW.View = System.Windows.Forms.View.Details
        '
        'NameActive
        '
        Me.NameActive.Text = "Name"
        Me.NameActive.Width = 192
        '
        'FromActive
        '
        Me.FromActive.Text = "Posted By"
        Me.FromActive.Width = 62
        '
        'Amount
        '
        Me.Amount.Text = "Amount"
        Me.Amount.Width = 91
        '
        'SendBillBTN
        '
        Me.SendBillBTN.Location = New System.Drawing.Point(347, 171)
        Me.SendBillBTN.Name = "SendBillBTN"
        Me.SendBillBTN.Size = New System.Drawing.Size(75, 23)
        Me.SendBillBTN.TabIndex = 9
        Me.SendBillBTN.Text = "Send Bill"
        Me.SendBillBTN.UseVisualStyleBackColor = True
        '
        'AcDetails
        '
        Me.AcDetails.Location = New System.Drawing.Point(266, 171)
        Me.AcDetails.Name = "AcDetails"
        Me.AcDetails.Size = New System.Drawing.Size(75, 23)
        Me.AcDetails.TabIndex = 8
        Me.AcDetails.Text = "Details"
        Me.AcDetails.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(416, 149)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "You have no active contracts"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(359, 504)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "Quit"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'InitialBW
        '
        Me.InitialBW.WorkerReportsProgress = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(18, 509)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Contractus is ©2019, Igtampe Development Inc."
        '
        'ConMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 539)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contractus"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AmountLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AvConLVIEW As ListView
    Friend WithEvents BidBTN As Button
    Friend WithEvents AvDetails As Button
    Friend WithEvents AddContract As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AcConLVIEW As ListView
    Friend WithEvents SendBillBTN As Button
    Friend WithEvents AcDetails As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ItemName As ColumnHeader
    Friend WithEvents From As ColumnHeader
    Friend WithEvents TopBid As ColumnHeader
    Friend WithEvents TopBidFrom As ColumnHeader
    Friend WithEvents NameActive As ColumnHeader
    Friend WithEvents FromActive As ColumnHeader
    Friend WithEvents Amount As ColumnHeader
    Friend WithEvents InitialBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
