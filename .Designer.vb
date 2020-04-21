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
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.CancelBTN = New System.Windows.Forms.Button()
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
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(15, 51)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(66, 22)
        Me.OKBTN.TabIndex = 2
        Me.OKBTN.Text = "OK"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(102, 51)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(66, 22)
        Me.CancelBTN.TabIndex = 3
        Me.CancelBTN.Text = "Cancel"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'VibeChangePin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 85)
        Me.Controls.Add(Me.CancelBTN)
        Me.Controls.Add(Me.OKBTN)
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
    Friend WithEvents OKBTN As Button
    Friend WithEvents CancelBTN As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
