<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConBid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConBid))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BidValue = New System.Windows.Forms.NumericUpDown()
        Me.PlaceBidBTN = New System.Windows.Forms.Button()
        Me.CancelBTN = New System.Windows.Forms.Button()
        CType(Me.BidValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(73, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOTE: Your bid will be recorded, and you'll have to follow through with it! Don't" &
    " say we didn't warn you"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gold
        Me.Label2.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 58)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BidValue
        '
        Me.BidValue.Location = New System.Drawing.Point(76, 50)
        Me.BidValue.Name = "BidValue"
        Me.BidValue.Size = New System.Drawing.Size(128, 20)
        Me.BidValue.TabIndex = 3
        '
        'PlaceBidBTN
        '
        Me.PlaceBidBTN.Location = New System.Drawing.Point(210, 48)
        Me.PlaceBidBTN.Name = "PlaceBidBTN"
        Me.PlaceBidBTN.Size = New System.Drawing.Size(75, 23)
        Me.PlaceBidBTN.TabIndex = 4
        Me.PlaceBidBTN.Text = "Place Bid"
        Me.PlaceBidBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(291, 48)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(75, 23)
        Me.CancelBTN.TabIndex = 5
        Me.CancelBTN.Text = "Cancel"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'ConBid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 82)
        Me.Controls.Add(Me.CancelBTN)
        Me.Controls.Add(Me.PlaceBidBTN)
        Me.Controls.Add(Me.BidValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConBid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contract Bidding"
        CType(Me.BidValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BidValue As NumericUpDown
    Friend WithEvents PlaceBidBTN As Button
    Friend WithEvents CancelBTN As Button
End Class
