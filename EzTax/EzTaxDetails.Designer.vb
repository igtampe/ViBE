<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EzTaxDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EzTaxDetails))
        Me.EzTaxTopLabel = New System.Windows.Forms.Label()
        Me.ItemNameLabel = New System.Windows.Forms.Label()
        Me.ItemLocationLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.DetailsTXB = New System.Windows.Forms.TextBox()
        Me.RecertifyButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EzTaxTopLabel
        '
        Me.EzTaxTopLabel.BackColor = System.Drawing.Color.DarkBlue
        Me.EzTaxTopLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EzTaxTopLabel.ForeColor = System.Drawing.Color.White
        Me.EzTaxTopLabel.Location = New System.Drawing.Point(0, 0)
        Me.EzTaxTopLabel.Name = "EzTaxTopLabel"
        Me.EzTaxTopLabel.Size = New System.Drawing.Size(307, 22)
        Me.EzTaxTopLabel.TabIndex = 15
        Me.EzTaxTopLabel.Text = "Item Details"
        Me.EzTaxTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemNameLabel
        '
        Me.ItemNameLabel.BackColor = System.Drawing.Color.DarkGray
        Me.ItemNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameLabel.Location = New System.Drawing.Point(12, 33)
        Me.ItemNameLabel.Name = "ItemNameLabel"
        Me.ItemNameLabel.Size = New System.Drawing.Size(280, 100)
        Me.ItemNameLabel.TabIndex = 17
        Me.ItemNameLabel.Text = "Stainless Steel Motel (Colesbrook)"
        Me.ItemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemLocationLabel
        '
        Me.ItemLocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemLocationLabel.ForeColor = System.Drawing.Color.DimGray
        Me.ItemLocationLabel.Location = New System.Drawing.Point(12, 133)
        Me.ItemLocationLabel.Name = "ItemLocationLabel"
        Me.ItemLocationLabel.Size = New System.Drawing.Size(280, 22)
        Me.ItemLocationLabel.TabIndex = 18
        Me.ItemLocationLabel.Text = "Located in: Newpond"
        Me.ItemLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 4)
        Me.Label2.TabIndex = 19
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 4)
        Me.Label3.TabIndex = 20
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OKBTN
        '
        Me.OKBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OKBTN.Image = CType(resources.GetObject("OKBTN.Image"), System.Drawing.Image)
        Me.OKBTN.Location = New System.Drawing.Point(217, 476)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(75, 23)
        Me.OKBTN.TabIndex = 22
        Me.OKBTN.Text = "Close"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'DetailsTXB
        '
        Me.DetailsTXB.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsTXB.Location = New System.Drawing.Point(12, 162)
        Me.DetailsTXB.Multiline = True
        Me.DetailsTXB.Name = "DetailsTXB"
        Me.DetailsTXB.ReadOnly = True
        Me.DetailsTXB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailsTXB.Size = New System.Drawing.Size(280, 304)
        Me.DetailsTXB.TabIndex = 24
        Me.DetailsTXB.Text = "help   :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "me     :"
        '
        'RecertifyButton
        '
        Me.RecertifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RecertifyButton.Image = CType(resources.GetObject("RecertifyButton.Image"), System.Drawing.Image)
        Me.RecertifyButton.Location = New System.Drawing.Point(12, 476)
        Me.RecertifyButton.Name = "RecertifyButton"
        Me.RecertifyButton.Size = New System.Drawing.Size(75, 23)
        Me.RecertifyButton.TabIndex = 25
        Me.RecertifyButton.Text = "Re-Certify"
        Me.RecertifyButton.UseVisualStyleBackColor = True
        '
        'EzTaxDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(307, 511)
        Me.Controls.Add(Me.RecertifyButton)
        Me.Controls.Add(Me.DetailsTXB)
        Me.Controls.Add(Me.OKBTN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ItemLocationLabel)
        Me.Controls.Add(Me.ItemNameLabel)
        Me.Controls.Add(Me.EzTaxTopLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EzTaxDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EzTaxDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EzTaxTopLabel As Label
    Friend WithEvents ItemNameLabel As Label
    Friend WithEvents ItemLocationLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OKBTN As Button
    Friend WithEvents DetailsTXB As TextBox
    Friend WithEvents RecertifyButton As Button
End Class
