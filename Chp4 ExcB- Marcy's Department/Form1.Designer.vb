﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Item1Box = New System.Windows.Forms.TextBox
        Me.Item2Box = New System.Windows.Forms.TextBox
        Me.HalfBox = New System.Windows.Forms.TextBox
        Me.TotalBox = New System.Windows.Forms.TextBox
        Me.CalcButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price of First Item:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(28, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Price of Second Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cheaper Item's Final Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Price:"
        '
        'Item1Box
        '
        Me.Item1Box.Location = New System.Drawing.Point(146, 9)
        Me.Item1Box.Name = "Item1Box"
        Me.Item1Box.Size = New System.Drawing.Size(100, 20)
        Me.Item1Box.TabIndex = 3
        '
        'Item2Box
        '
        Me.Item2Box.Location = New System.Drawing.Point(146, 35)
        Me.Item2Box.Name = "Item2Box"
        Me.Item2Box.Size = New System.Drawing.Size(100, 20)
        Me.Item2Box.TabIndex = 4
        '
        'HalfBox
        '
        Me.HalfBox.BackColor = System.Drawing.SystemColors.MenuBar
        Me.HalfBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HalfBox.Location = New System.Drawing.Point(146, 71)
        Me.HalfBox.Name = "HalfBox"
        Me.HalfBox.Size = New System.Drawing.Size(100, 20)
        Me.HalfBox.TabIndex = 5
        '
        'TotalBox
        '
        Me.TotalBox.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalBox.Location = New System.Drawing.Point(113, 97)
        Me.TotalBox.Name = "TotalBox"
        Me.TotalBox.Size = New System.Drawing.Size(133, 20)
        Me.TotalBox.TabIndex = 6
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(11, 143)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(96, 23)
        Me.CalcButton.TabIndex = 7
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(176, 143)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(96, 23)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 182)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.TotalBox)
        Me.Controls.Add(Me.HalfBox)
        Me.Controls.Add(Me.Item2Box)
        Me.Controls.Add(Me.Item1Box)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "BoGoHo Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Item1Box As System.Windows.Forms.TextBox
    Friend WithEvents Item2Box As System.Windows.Forms.TextBox
    Friend WithEvents HalfBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalBox As System.Windows.Forms.TextBox
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
