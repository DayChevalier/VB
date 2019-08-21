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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.IllinoisSales = New System.Windows.Forms.TextBox
        Me.IndianaSales = New System.Windows.Forms.TextBox
        Me.KentuckySales = New System.Windows.Forms.TextBox
        Me.OhioSales = New System.Windows.Forms.TextBox
        Me.TotalSales = New System.Windows.Forms.TextBox
        Me.CommissionTotal = New System.Windows.Forms.TextBox
        Me.CalcButton = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Illinois sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "I&ndiana sales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Kentucky sales:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Ohio sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total sales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Commission:"
        '
        'IllinoisSales
        '
        Me.IllinoisSales.Location = New System.Drawing.Point(15, 25)
        Me.IllinoisSales.Name = "IllinoisSales"
        Me.IllinoisSales.Size = New System.Drawing.Size(62, 20)
        Me.IllinoisSales.TabIndex = 6
        '
        'IndianaSales
        '
        Me.IndianaSales.Location = New System.Drawing.Point(164, 25)
        Me.IndianaSales.Name = "IndianaSales"
        Me.IndianaSales.Size = New System.Drawing.Size(62, 20)
        Me.IndianaSales.TabIndex = 7
        '
        'KentuckySales
        '
        Me.KentuckySales.Location = New System.Drawing.Point(86, 25)
        Me.KentuckySales.Name = "KentuckySales"
        Me.KentuckySales.Size = New System.Drawing.Size(62, 20)
        Me.KentuckySales.TabIndex = 8
        '
        'OhioSales
        '
        Me.OhioSales.Location = New System.Drawing.Point(252, 25)
        Me.OhioSales.Name = "OhioSales"
        Me.OhioSales.Size = New System.Drawing.Size(62, 20)
        Me.OhioSales.TabIndex = 9
        '
        'TotalSales
        '
        Me.TotalSales.BackColor = System.Drawing.SystemColors.Menu
        Me.TotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalSales.Location = New System.Drawing.Point(353, 25)
        Me.TotalSales.Name = "TotalSales"
        Me.TotalSales.Size = New System.Drawing.Size(100, 20)
        Me.TotalSales.TabIndex = 10
        '
        'CommissionTotal
        '
        Me.CommissionTotal.BackColor = System.Drawing.SystemColors.Menu
        Me.CommissionTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CommissionTotal.Location = New System.Drawing.Point(353, 64)
        Me.CommissionTotal.Name = "CommissionTotal"
        Me.CommissionTotal.Size = New System.Drawing.Size(100, 20)
        Me.CommissionTotal.TabIndex = 11
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(15, 84)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 12
        Me.CalcButton.Text = "&Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(96, 84)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "Clea&r Screen"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(177, 84)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 124)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.CommissionTotal)
        Me.Controls.Add(Me.TotalSales)
        Me.Controls.Add(Me.OhioSales)
        Me.Controls.Add(Me.KentuckySales)
        Me.Controls.Add(Me.IndianaSales)
        Me.Controls.Add(Me.IllinoisSales)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Jasper Health Foods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents IllinoisSales As System.Windows.Forms.TextBox
    Friend WithEvents IndianaSales As System.Windows.Forms.TextBox
    Friend WithEvents KentuckySales As System.Windows.Forms.TextBox
    Friend WithEvents OhioSales As System.Windows.Forms.TextBox
    Friend WithEvents TotalSales As System.Windows.Forms.TextBox
    Friend WithEvents CommissionTotal As System.Windows.Forms.TextBox
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
