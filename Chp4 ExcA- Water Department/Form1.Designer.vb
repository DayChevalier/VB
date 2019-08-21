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
        Me.CurrentReadBox = New System.Windows.Forms.TextBox
        Me.PreviousReadBox = New System.Windows.Forms.TextBox
        Me.GallonsBox = New System.Windows.Forms.TextBox
        Me.TotalBox = New System.Windows.Forms.TextBox
        Me.ErrorBox = New System.Windows.Forms.TextBox
        Me.CalcButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C&urrent reading:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Previous reading:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gallons used:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Charge:"
        '
        'CurrentReadBox
        '
        Me.CurrentReadBox.Location = New System.Drawing.Point(119, 12)
        Me.CurrentReadBox.Name = "CurrentReadBox"
        Me.CurrentReadBox.Size = New System.Drawing.Size(100, 20)
        Me.CurrentReadBox.TabIndex = 4
        '
        'PreviousReadBox
        '
        Me.PreviousReadBox.Location = New System.Drawing.Point(119, 38)
        Me.PreviousReadBox.Name = "PreviousReadBox"
        Me.PreviousReadBox.Size = New System.Drawing.Size(100, 20)
        Me.PreviousReadBox.TabIndex = 5
        '
        'GallonsBox
        '
        Me.GallonsBox.BackColor = System.Drawing.SystemColors.Menu
        Me.GallonsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GallonsBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GallonsBox.Location = New System.Drawing.Point(101, 75)
        Me.GallonsBox.Name = "GallonsBox"
        Me.GallonsBox.Size = New System.Drawing.Size(118, 20)
        Me.GallonsBox.TabIndex = 6
        '
        'TotalBox
        '
        Me.TotalBox.BackColor = System.Drawing.SystemColors.Menu
        Me.TotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalBox.Location = New System.Drawing.Point(101, 101)
        Me.TotalBox.Name = "TotalBox"
        Me.TotalBox.Size = New System.Drawing.Size(118, 20)
        Me.TotalBox.TabIndex = 7
        '
        'ErrorBox
        '
        Me.ErrorBox.BackColor = System.Drawing.SystemColors.Menu
        Me.ErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBox.Location = New System.Drawing.Point(27, 127)
        Me.ErrorBox.Name = "ErrorBox"
        Me.ErrorBox.Size = New System.Drawing.Size(192, 20)
        Me.ErrorBox.TabIndex = 8
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(225, 90)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(100, 26)
        Me.CalcButton.TabIndex = 9
        Me.CalcButton.Text = "&Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(225, 122)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(100, 26)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 163)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.ErrorBox)
        Me.Controls.Add(Me.TotalBox)
        Me.Controls.Add(Me.GallonsBox)
        Me.Controls.Add(Me.PreviousReadBox)
        Me.Controls.Add(Me.CurrentReadBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Allenton Water Department"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CurrentReadBox As System.Windows.Forms.TextBox
    Friend WithEvents PreviousReadBox As System.Windows.Forms.TextBox
    Friend WithEvents GallonsBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalBox As System.Windows.Forms.TextBox
    Friend WithEvents ErrorBox As System.Windows.Forms.TextBox
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
