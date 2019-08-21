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
        Me.lblCost = New System.Windows.Forms.Label
        Me.lblLife = New System.Windows.Forms.Label
        Me.lblValue = New System.Windows.Forms.Label
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.lstLife = New System.Windows.Forms.ListBox
        Me.txtValue = New System.Windows.Forms.TextBox
        Me.lblSchedule = New System.Windows.Forms.Label
        Me.txtDepreciation = New System.Windows.Forms.TextBox
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(22, 9)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(60, 13)
        Me.lblCost.TabIndex = 0
        Me.lblCost.Text = "&Asset Cost:"
        '
        'lblLife
        '
        Me.lblLife.AutoSize = True
        Me.lblLife.Location = New System.Drawing.Point(116, 9)
        Me.lblLife.Name = "lblLife"
        Me.lblLife.Size = New System.Drawing.Size(60, 13)
        Me.lblLife.TabIndex = 1
        Me.lblLife.Text = "&Useful Life:"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(203, 9)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(79, 13)
        Me.lblValue.TabIndex = 2
        Me.lblValue.Text = "&Salvage Value:"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(25, 25)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(76, 20)
        Me.txtCost.TabIndex = 3
        '
        'lstLife
        '
        Me.lstLife.FormattingEnabled = True
        Me.lstLife.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.lstLife.Location = New System.Drawing.Point(119, 28)
        Me.lstLife.Name = "lstLife"
        Me.lstLife.Size = New System.Drawing.Size(51, 43)
        Me.lstLife.TabIndex = 4
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(206, 28)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(76, 20)
        Me.txtValue.TabIndex = 5
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Location = New System.Drawing.Point(22, 90)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(118, 13)
        Me.lblSchedule.TabIndex = 6
        Me.lblSchedule.Text = "Depreciation Schedule:"
        '
        'txtDepreciation
        '
        Me.txtDepreciation.Location = New System.Drawing.Point(25, 106)
        Me.txtDepreciation.Multiline = True
        Me.txtDepreciation.Name = "txtDepreciation"
        Me.txtDepreciation.ReadOnly = True
        Me.txtDepreciation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDepreciation.Size = New System.Drawing.Size(257, 101)
        Me.txtDepreciation.TabIndex = 7
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(25, 219)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(175, 31)
        Me.btnDisplay.TabIndex = 8
        Me.btnDisplay.Text = "&Display Depreciation Schedule"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(206, 219)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtDepreciation)
        Me.Controls.Add(Me.lblSchedule)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lstLife)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblLife)
        Me.Controls.Add(Me.lblCost)
        Me.Name = "Form1"
        Me.Text = "Sonheim Manufacturing Company"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblLife As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents lstLife As System.Windows.Forms.ListBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents lblSchedule As System.Windows.Forms.Label
    Friend WithEvents txtDepreciation As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
