<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LengthBox = New System.Windows.Forms.TextBox
        Me.WidthBox = New System.Windows.Forms.TextBox
        Me.HeightBox = New System.Windows.Forms.TextBox
        Me.VolumeBox = New System.Windows.Forms.TextBox
        Me.CalcButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Length:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Width:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Height:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Volume:"
        '
        'LengthBox
        '
        Me.LengthBox.Location = New System.Drawing.Point(57, 12)
        Me.LengthBox.Name = "LengthBox"
        Me.LengthBox.Size = New System.Drawing.Size(65, 20)
        Me.LengthBox.TabIndex = 4
        '
        'WidthBox
        '
        Me.WidthBox.Location = New System.Drawing.Point(57, 41)
        Me.WidthBox.Name = "WidthBox"
        Me.WidthBox.Size = New System.Drawing.Size(65, 20)
        Me.WidthBox.TabIndex = 5
        '
        'HeightBox
        '
        Me.HeightBox.Location = New System.Drawing.Point(57, 67)
        Me.HeightBox.Name = "HeightBox"
        Me.HeightBox.Size = New System.Drawing.Size(65, 20)
        Me.HeightBox.TabIndex = 6
        '
        'VolumeBox
        '
        Me.VolumeBox.BackColor = System.Drawing.SystemColors.Menu
        Me.VolumeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VolumeBox.Location = New System.Drawing.Point(57, 113)
        Me.VolumeBox.Name = "VolumeBox"
        Me.VolumeBox.Size = New System.Drawing.Size(65, 20)
        Me.VolumeBox.TabIndex = 7
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(155, 81)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 8
        Me.CalcButton.Text = "&Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(155, 110)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 9
        Me.CloseButton.Text = "E&xit"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 147)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.VolumeBox)
        Me.Controls.Add(Me.HeightBox)
        Me.Controls.Add(Me.WidthBox)
        Me.Controls.Add(Me.LengthBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Willow Pools"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LengthBox As System.Windows.Forms.TextBox
    Friend WithEvents WidthBox As System.Windows.Forms.TextBox
    Friend WithEvents HeightBox As System.Windows.Forms.TextBox
    Friend WithEvents VolumeBox As System.Windows.Forms.TextBox
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button

End Class
