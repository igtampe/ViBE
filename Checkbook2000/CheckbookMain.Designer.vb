<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckbookMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckbookMain))
        Me.InboxButton = New System.Windows.Forms.Button()
        Me.OutboxButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TipLBL = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InboxButton
        '
        Me.InboxButton.BackgroundImage = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.Iconsmind_Outline_Inbox_Into
        Me.InboxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InboxButton.Location = New System.Drawing.Point(12, 12)
        Me.InboxButton.Name = "InboxButton"
        Me.InboxButton.Size = New System.Drawing.Size(60, 60)
        Me.InboxButton.TabIndex = 0
        Me.InboxButton.UseVisualStyleBackColor = True
        '
        'OutboxButton
        '
        Me.OutboxButton.BackgroundImage = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.Iconsmind_Outline_Outbox_Into
        Me.OutboxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OutboxButton.Location = New System.Drawing.Point(12, 78)
        Me.OutboxButton.Name = "OutboxButton"
        Me.OutboxButton.Size = New System.Drawing.Size(60, 60)
        Me.OutboxButton.TabIndex = 0
        Me.OutboxButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImage = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.door_opened
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitButton.Location = New System.Drawing.Point(12, 144)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(60, 60)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inbox"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Outbox"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Exit"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(131, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 192)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(147, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(328, 30)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Welcome to Checkbook 2000!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.DidYouKnowBG
        Me.PictureBox1.Location = New System.Drawing.Point(153, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TipLBL
        '
        Me.TipLBL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TipLBL.Location = New System.Drawing.Point(213, 102)
        Me.TipLBL.Name = "TipLBL"
        Me.TipLBL.Size = New System.Drawing.Size(226, 79)
        Me.TipLBL.TabIndex = 5
        Me.TipLBL.Text = "Bonjour Bitch the tip failed to load"
        '
        'BackgroundWorker1
        '
        '
        'CheckbookMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 213)
        Me.Controls.Add(Me.TipLBL)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.OutboxButton)
        Me.Controls.Add(Me.InboxButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CheckbookMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkbook 2000"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InboxButton As Button
    Friend WithEvents OutboxButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TipLBL As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
