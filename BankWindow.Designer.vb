<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BankWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BankWindow))
        Me.BankPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Logbox = New System.Windows.Forms.ListBox()
        Me.CloseAccountBTN = New System.Windows.Forms.Button()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.OpenAccountBW = New System.ComponentModel.BackgroundWorker()
        Me.CloseAccountBW = New System.ComponentModel.BackgroundWorker()
        Me.LogBW = New System.ComponentModel.BackgroundWorker()
        Me.CertifyButton = New System.Windows.Forms.Button()
        CType(Me.BankPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BankPictureBox
        '
        Me.BankPictureBox.ErrorImage = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.LemonInvest1
        Me.BankPictureBox.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.LemonInvest1
        Me.BankPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.BankPictureBox.Name = "BankPictureBox"
        Me.BankPictureBox.Size = New System.Drawing.Size(501, 94)
        Me.BankPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BankPictureBox.TabIndex = 0
        Me.BankPictureBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Logbox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 208)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Log"
        '
        'Logbox
        '
        Me.Logbox.FormattingEnabled = True
        Me.Logbox.Location = New System.Drawing.Point(6, 19)
        Me.Logbox.Name = "Logbox"
        Me.Logbox.Size = New System.Drawing.Size(489, 173)
        Me.Logbox.TabIndex = 0
        '
        'CloseAccountBTN
        '
        Me.CloseAccountBTN.Location = New System.Drawing.Point(12, 333)
        Me.CloseAccountBTN.Name = "CloseAccountBTN"
        Me.CloseAccountBTN.Size = New System.Drawing.Size(108, 23)
        Me.CloseAccountBTN.TabIndex = 2
        Me.CloseAccountBTN.Text = "Close Account"
        Me.CloseAccountBTN.UseVisualStyleBackColor = True
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(438, 333)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(75, 23)
        Me.OKBTN.TabIndex = 3
        Me.OKBTN.Text = "OK"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'OpenAccountBW
        '
        '
        'CloseAccountBW
        '
        '
        'LogBW
        '
        '
        'CertifyButton
        '
        Me.CertifyButton.Enabled = False
        Me.CertifyButton.Location = New System.Drawing.Point(192, 333)
        Me.CertifyButton.Name = "CertifyButton"
        Me.CertifyButton.Size = New System.Drawing.Size(151, 23)
        Me.CertifyButton.TabIndex = 4
        Me.CertifyButton.Text = "Certify this Transaction"
        Me.CertifyButton.UseVisualStyleBackColor = True
        '
        'BankWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 368)
        Me.Controls.Add(Me.CertifyButton)
        Me.Controls.Add(Me.OKBTN)
        Me.Controls.Add(Me.CloseAccountBTN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BankPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BankWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BankPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BankPictureBox As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CloseAccountBTN As Button
    Friend WithEvents OKBTN As Button
    Friend WithEvents OpenAccountBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents CloseAccountBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents LogBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Logbox As ListBox
    Friend WithEvents CertifyButton As Button
End Class
