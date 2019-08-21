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
        Me.CloseButton = New System.Windows.Forms.Button
        Me.CalcButton = New System.Windows.Forms.Button
        Me.AreaBox = New System.Windows.Forms.TextBox
        Me.PriceBox = New System.Windows.Forms.TextBox
        Me.WidthBox = New System.Windows.Forms.TextBox
        Me.LengthBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TotalBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(197, 91)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 19
        Me.CloseButton.Text = "E&xit"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(197, 62)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 18
        Me.CalcButton.Text = "&Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'AreaBox
        '
        Me.AreaBox.BackColor = System.Drawing.SystemColors.Menu
        Me.AreaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AreaBox.Location = New System.Drawing.Point(11, 91)
        Me.AreaBox.Name = "AreaBox"
        Me.AreaBox.Size = New System.Drawing.Size(78, 20)
        Me.AreaBox.TabIndex = 17
        '
        'PriceBox
        '
        Me.PriceBox.Location = New System.Drawing.Point(189, 25)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(83, 20)
        Me.PriceBox.TabIndex = 16
        '
        'WidthBox
        '
        Me.WidthBox.Location = New System.Drawing.Point(100, 25)
        Me.WidthBox.Name = "WidthBox"
        Me.WidthBox.Size = New System.Drawing.Size(83, 20)
        Me.WidthBox.TabIndex = 15
        '
        'LengthBox
        '
        Me.LengthBox.Location = New System.Drawing.Point(11, 25)
        Me.LengthBox.Name = "LengthBox"
        Me.LengthBox.Size = New System.Drawing.Size(83, 20)
        Me.LengthBox.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Area:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "&Price (sq. foot):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "&Width (feet):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "&Length (feet):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Total Price:"
        '
        'TotalBox
        '
        Me.TotalBox.BackColor = System.Drawing.SystemColors.Menu
        Me.TotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalBox.Location = New System.Drawing.Point(105, 91)
        Me.TotalBox.Name = "TotalBox"
        Me.TotalBox.Size = New System.Drawing.Size(78, 20)
        Me.TotalBox.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 123)
        Me.Controls.Add(Me.TotalBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.AreaBox)
        Me.Controls.Add(Me.PriceBox)
        Me.Controls.Add(Me.WidthBox)
        Me.Controls.Add(Me.LengthBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Tile Limited"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents AreaBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceBox As System.Windows.Forms.TextBox
    Friend WithEvents WidthBox As System.Windows.Forms.TextBox
    Friend WithEvents LengthBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TotalBox As System.Windows.Forms.TextBox

End Class
