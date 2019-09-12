<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConSplash))
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.ForeColor = System.Drawing.Color.Black
        Me.StatusLabel.Location = New System.Drawing.Point(82, 299)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(188, 22)
        Me.StatusLabel.TabIndex = 1
        Me.StatusLabel.Text = "Please Wait"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StatusLabel.UseWaitCursor = True
        '
        'ConSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BackgroundImage = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.Contractus_Splash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(352, 413)
        Me.Controls.Add(Me.StatusLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contractus Splash"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StatusLabel As Label
End Class
