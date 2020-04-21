<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LandView))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RegionComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlotComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AreaLBL = New System.Windows.Forms.Label()
        Me.OwnerLBL = New System.Windows.Forms.Label()
        Me.PPBlockLBL = New System.Windows.Forms.Label()
        Me.PriceLBL = New System.Windows.Forms.Label()
        Me.SizeLBL = New System.Windows.Forms.Label()
        Me.PlotLBL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CommentLBL = New System.Windows.Forms.Label()
        Me.StatusLBL = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.Landview
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(793, 501)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RegionComboBox
        '
        Me.RegionComboBox.FormattingEnabled = True
        Me.RegionComboBox.Items.AddRange(New Object() {"INDUSTRIAL SECTOR", "NEWPOND", "SUBURBIA", "URBIA", "PARADISUS", "DOMUM", "LAETRES", "SYNERGIA"})
        Me.RegionComboBox.Location = New System.Drawing.Point(56, 13)
        Me.RegionComboBox.Name = "RegionComboBox"
        Me.RegionComboBox.Size = New System.Drawing.Size(168, 21)
        Me.RegionComboBox.TabIndex = 1
        Me.RegionComboBox.Text = "Select a Region"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Region:"
        '
        'PlotComboBox
        '
        Me.PlotComboBox.FormattingEnabled = True
        Me.PlotComboBox.Location = New System.Drawing.Point(56, 40)
        Me.PlotComboBox.Name = "PlotComboBox"
        Me.PlotComboBox.Size = New System.Drawing.Size(168, 21)
        Me.PlotComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Plot ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RegionComboBox)
        Me.GroupBox1.Controls.Add(Me.PlotComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 519)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 87)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AreaLBL)
        Me.GroupBox2.Controls.Add(Me.OwnerLBL)
        Me.GroupBox2.Controls.Add(Me.PPBlockLBL)
        Me.GroupBox2.Controls.Add(Me.PriceLBL)
        Me.GroupBox2.Controls.Add(Me.SizeLBL)
        Me.GroupBox2.Controls.Add(Me.PlotLBL)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CommentLBL)
        Me.GroupBox2.Controls.Add(Me.StatusLBL)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(254, 519)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 88)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selection"
        '
        'AreaLBL
        '
        Me.AreaLBL.AutoSize = True
        Me.AreaLBL.Location = New System.Drawing.Point(291, 43)
        Me.AreaLBL.Name = "AreaLBL"
        Me.AreaLBL.Size = New System.Drawing.Size(0, 13)
        Me.AreaLBL.TabIndex = 2
        '
        'OwnerLBL
        '
        Me.OwnerLBL.AutoSize = True
        Me.OwnerLBL.Location = New System.Drawing.Point(62, 63)
        Me.OwnerLBL.Name = "OwnerLBL"
        Me.OwnerLBL.Size = New System.Drawing.Size(0, 13)
        Me.OwnerLBL.TabIndex = 2
        '
        'PPBlockLBL
        '
        Me.PPBlockLBL.AutoSize = True
        Me.PPBlockLBL.Location = New System.Drawing.Point(456, 21)
        Me.PPBlockLBL.Name = "PPBlockLBL"
        Me.PPBlockLBL.Size = New System.Drawing.Size(0, 13)
        Me.PPBlockLBL.TabIndex = 2
        '
        'PriceLBL
        '
        Me.PriceLBL.AutoSize = True
        Me.PriceLBL.Location = New System.Drawing.Point(456, 43)
        Me.PriceLBL.Name = "PriceLBL"
        Me.PriceLBL.Size = New System.Drawing.Size(0, 13)
        Me.PriceLBL.TabIndex = 2
        '
        'SizeLBL
        '
        Me.SizeLBL.AutoSize = True
        Me.SizeLBL.Location = New System.Drawing.Point(291, 21)
        Me.SizeLBL.Name = "SizeLBL"
        Me.SizeLBL.Size = New System.Drawing.Size(0, 13)
        Me.SizeLBL.TabIndex = 2
        '
        'PlotLBL
        '
        Me.PlotLBL.AutoSize = True
        Me.PlotLBL.Location = New System.Drawing.Point(62, 21)
        Me.PlotLBL.Name = "PlotLBL"
        Me.PlotLBL.Size = New System.Drawing.Size(0, 13)
        Me.PlotLBL.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Plot ID:"
        '
        'CommentLBL
        '
        Me.CommentLBL.AutoSize = True
        Me.CommentLBL.Location = New System.Drawing.Point(291, 63)
        Me.CommentLBL.Name = "CommentLBL"
        Me.CommentLBL.Size = New System.Drawing.Size(0, 13)
        Me.CommentLBL.TabIndex = 2
        '
        'StatusLBL
        '
        Me.StatusLBL.AutoSize = True
        Me.StatusLBL.Location = New System.Drawing.Point(62, 43)
        Me.StatusLBL.Name = "StatusLBL"
        Me.StatusLBL.Size = New System.Drawing.Size(0, 13)
        Me.StatusLBL.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(182, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Aproximate Area:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Owner:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(351, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Price Per Block:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(351, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(182, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Aproximate Size:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(221, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Comment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Status:"
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(730, 613)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(75, 23)
        Me.OKBTN.TabIndex = 4
        Me.OKBTN.Text = "OK"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 613)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(490, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'LandView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 648)
        Me.Controls.Add(Me.OKBTN)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LandView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LandView"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RegionComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PlotComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AreaLBL As Label
    Friend WithEvents OwnerLBL As Label
    Friend WithEvents PriceLBL As Label
    Friend WithEvents SizeLBL As Label
    Friend WithEvents PlotLBL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StatusLBL As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OKBTN As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents CommentLBL As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PPBlockLBL As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
