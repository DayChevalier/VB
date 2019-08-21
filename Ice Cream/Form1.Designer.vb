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
        Me.splitPriceShow = New System.Windows.Forms.Button
        Me.sundaePriceShow = New System.Windows.Forms.Button
        Me.shakePriceShow = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.splitPrice = New System.Windows.Forms.Label
        Me.sundaePrice = New System.Windows.Forms.Label
        Me.shakePrice = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'splitPriceShow
        '
        Me.splitPriceShow.Location = New System.Drawing.Point(21, 45)
        Me.splitPriceShow.Name = "splitPriceShow"
        Me.splitPriceShow.Size = New System.Drawing.Size(103, 41)
        Me.splitPriceShow.TabIndex = 0
        Me.splitPriceShow.Text = "Banana Split"
        Me.splitPriceShow.UseVisualStyleBackColor = True
        '
        'sundaePriceShow
        '
        Me.sundaePriceShow.Location = New System.Drawing.Point(21, 92)
        Me.sundaePriceShow.Name = "sundaePriceShow"
        Me.sundaePriceShow.Size = New System.Drawing.Size(101, 41)
        Me.sundaePriceShow.TabIndex = 1
        Me.sundaePriceShow.Text = "Sundae"
        Me.sundaePriceShow.UseVisualStyleBackColor = True
        '
        'shakePriceShow
        '
        Me.shakePriceShow.Location = New System.Drawing.Point(21, 140)
        Me.shakePriceShow.Name = "shakePriceShow"
        Me.shakePriceShow.Size = New System.Drawing.Size(99, 41)
        Me.shakePriceShow.TabIndex = 2
        Me.shakePriceShow.Text = "Milkshake"
        Me.shakePriceShow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Click a button to see the price of a menu item."
        '
        'splitPrice
        '
        Me.splitPrice.AutoSize = True
        Me.splitPrice.Location = New System.Drawing.Point(147, 59)
        Me.splitPrice.Name = "splitPrice"
        Me.splitPrice.Size = New System.Drawing.Size(34, 13)
        Me.splitPrice.TabIndex = 4
        Me.splitPrice.Text = "$1.79"
        Me.splitPrice.Visible = False
        '
        'sundaePrice
        '
        Me.sundaePrice.AutoSize = True
        Me.sundaePrice.Location = New System.Drawing.Point(147, 106)
        Me.sundaePrice.Name = "sundaePrice"
        Me.sundaePrice.Size = New System.Drawing.Size(34, 13)
        Me.sundaePrice.TabIndex = 5
        Me.sundaePrice.Text = "$0.99"
        Me.sundaePrice.Visible = False
        '
        'shakePrice
        '
        Me.shakePrice.AutoSize = True
        Me.shakePrice.Location = New System.Drawing.Point(147, 154)
        Me.shakePrice.Name = "shakePrice"
        Me.shakePrice.Size = New System.Drawing.Size(34, 13)
        Me.shakePrice.TabIndex = 6
        Me.shakePrice.Text = "$2.25"
        Me.shakePrice.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 46)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 245)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.shakePrice)
        Me.Controls.Add(Me.sundaePrice)
        Me.Controls.Add(Me.splitPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.shakePriceShow)
        Me.Controls.Add(Me.sundaePriceShow)
        Me.Controls.Add(Me.splitPriceShow)
        Me.Name = "Form1"
        Me.Text = "Castle's Parlor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents splitPriceShow As System.Windows.Forms.Button
    Friend WithEvents sundaePriceShow As System.Windows.Forms.Button
    Friend WithEvents shakePriceShow As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents splitPrice As System.Windows.Forms.Label
    Friend WithEvents sundaePrice As System.Windows.Forms.Label
    Friend WithEvents shakePrice As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
