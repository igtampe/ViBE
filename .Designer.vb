<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VibeChangePin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewPinTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Pin"
        '
        'NewPinTextBox
        '
        Me.NewPinTextBox.Location = New System.Drawing.Point(15, 25)
        Me.NewPinTextBox.MaxLength = 4
        Me.NewPinTextBox.Name = "NewPinTextBox"
        Me.NewPinTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPinTextBox.Size = New System.Drawing.Size(153, 20)
        Me.NewPinTextBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(102, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 22)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'VibeChangePin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 85)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NewPinTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "VibeChangePin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Pin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NewPinTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
