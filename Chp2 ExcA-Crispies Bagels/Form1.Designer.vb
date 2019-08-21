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
        Me.BagelBox = New System.Windows.Forms.TextBox
        Me.DonutBox = New System.Windows.Forms.TextBox
        Me.CoffeeBox = New System.Windows.Forms.TextBox
        Me.PriceBox = New System.Windows.Forms.TextBox
        Me.CalcButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Bagels:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Donuts:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Co&ffee:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price:"
        '
        'BagelBox
        '
        Me.BagelBox.Location = New System.Drawing.Point(57, 12)
        Me.BagelBox.Name = "BagelBox"
        Me.BagelBox.Size = New System.Drawing.Size(100, 20)
        Me.BagelBox.TabIndex = 4
        '
        'DonutBox
        '
        Me.DonutBox.Location = New System.Drawing.Point(57, 38)
        Me.DonutBox.Name = "DonutBox"
        Me.DonutBox.Size = New System.Drawing.Size(100, 20)
        Me.DonutBox.TabIndex = 5
        '
        'CoffeeBox
        '
        Me.CoffeeBox.Location = New System.Drawing.Point(57, 64)
        Me.CoffeeBox.Name = "CoffeeBox"
        Me.CoffeeBox.Size = New System.Drawing.Size(100, 20)
        Me.CoffeeBox.TabIndex = 6
        '
        'PriceBox
        '
        Me.PriceBox.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PriceBox.Location = New System.Drawing.Point(47, 101)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(225, 20)
        Me.PriceBox.TabIndex = 7
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(163, 10)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(109, 23)
        Me.CalcButton.TabIndex = 8
        Me.CalcButton.Text = "&Calculate Price"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(163, 36)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(109, 23)
        Me.CloseButton.TabIndex = 9
        Me.CloseButton.Text = "E&xit"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 135)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.PriceBox)
        Me.Controls.Add(Me.CoffeeBox)
        Me.Controls.Add(Me.DonutBox)
        Me.Controls.Add(Me.BagelBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Crispies Bagels and Bites"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BagelBox As System.Windows.Forms.TextBox
    Friend WithEvents DonutBox As System.Windows.Forms.TextBox
    Friend WithEvents CoffeeBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceBox As System.Windows.Forms.TextBox
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button

End Class
