<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConDetails))
        Me.NameTXB = New System.Windows.Forms.TextBox()
        Me.DetailsTXB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TopBidderLBL = New System.Windows.Forms.Label()
        Me.TopBidLBL = New System.Windows.Forms.Label()
        Me.FromLBL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.PlaceBidBTN = New System.Windows.Forms.Button()
        Me.EndAuctionBTN = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LoadDetails = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTXB
        '
        Me.NameTXB.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTXB.Location = New System.Drawing.Point(12, 12)
        Me.NameTXB.Name = "NameTXB"
        Me.NameTXB.ReadOnly = True
        Me.NameTXB.Size = New System.Drawing.Size(285, 39)
        Me.NameTXB.TabIndex = 5
        Me.NameTXB.Text = "(Name)"
        '
        'DetailsTXB
        '
        Me.DetailsTXB.Location = New System.Drawing.Point(6, 19)
        Me.DetailsTXB.Multiline = True
        Me.DetailsTXB.Name = "DetailsTXB"
        Me.DetailsTXB.ReadOnly = True
        Me.DetailsTXB.Size = New System.Drawing.Size(273, 162)
        Me.DetailsTXB.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TopBidderLBL)
        Me.GroupBox1.Controls.Add(Me.TopBidLBL)
        Me.GroupBox1.Controls.Add(Me.FromLBL)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DetailsTXB)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 264)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lowest Bidder: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lowest Bid: "
        '
        'TopBidderLBL
        '
        Me.TopBidderLBL.AutoSize = True
        Me.TopBidderLBL.Location = New System.Drawing.Point(102, 224)
        Me.TopBidderLBL.Name = "TopBidderLBL"
        Me.TopBidderLBL.Size = New System.Drawing.Size(16, 13)
        Me.TopBidderLBL.TabIndex = 2
        Me.TopBidderLBL.Text = " - "
        '
        'TopBidLBL
        '
        Me.TopBidLBL.AutoSize = True
        Me.TopBidLBL.Location = New System.Drawing.Point(102, 211)
        Me.TopBidLBL.Name = "TopBidLBL"
        Me.TopBidLBL.Size = New System.Drawing.Size(16, 13)
        Me.TopBidLBL.TabIndex = 2
        Me.TopBidLBL.Text = " - "
        '
        'FromLBL
        '
        Me.FromLBL.AutoSize = True
        Me.FromLBL.Location = New System.Drawing.Point(102, 198)
        Me.FromLBL.Name = "FromLBL"
        Me.FromLBL.Size = New System.Drawing.Size(16, 13)
        Me.FromLBL.TabIndex = 2
        Me.FromLBL.Text = " - "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From: "
        '
        'OKBtn
        '
        Me.OKBtn.Location = New System.Drawing.Point(221, 332)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(75, 23)
        Me.OKBtn.TabIndex = 7
        Me.OKBtn.Text = "OK"
        Me.OKBtn.UseVisualStyleBackColor = True
        '
        'PlaceBidBTN
        '
        Me.PlaceBidBTN.Location = New System.Drawing.Point(140, 332)
        Me.PlaceBidBTN.Name = "PlaceBidBTN"
        Me.PlaceBidBTN.Size = New System.Drawing.Size(75, 23)
        Me.PlaceBidBTN.TabIndex = 6
        Me.PlaceBidBTN.Text = "Place Bid"
        Me.PlaceBidBTN.UseVisualStyleBackColor = True
        '
        'EndAuctionBTN
        '
        Me.EndAuctionBTN.Location = New System.Drawing.Point(12, 332)
        Me.EndAuctionBTN.Name = "EndAuctionBTN"
        Me.EndAuctionBTN.Size = New System.Drawing.Size(97, 23)
        Me.EndAuctionBTN.TabIndex = 6
        Me.EndAuctionBTN.Text = "End Auction"
        Me.ToolTip1.SetToolTip(Me.EndAuctionBTN, "End the Auciton and hand the contract to the Lowest bidder")
        Me.EndAuctionBTN.UseVisualStyleBackColor = True
        Me.EndAuctionBTN.Visible = False
        '
        'LoadDetails
        '
        '
        'ConDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 363)
        Me.Controls.Add(Me.NameTXB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OKBtn)
        Me.Controls.Add(Me.EndAuctionBTN)
        Me.Controls.Add(Me.PlaceBidBTN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contract Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTXB As TextBox
    Friend WithEvents DetailsTXB As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TopBidderLBL As Label
    Friend WithEvents TopBidLBL As Label
    Friend WithEvents FromLBL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OKBtn As Button
    Friend WithEvents PlaceBidBTN As Button
    Friend WithEvents EndAuctionBTN As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LoadDetails As System.ComponentModel.BackgroundWorker
End Class
