Public Class Form1

    Private Sub CalcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcButton.Click
        'Declarations
        Const CHARGE As Double = 1.75
        Const RATE As Integer = 1000

        Dim current As Integer
        Dim previous As Integer
        Dim used As Integer
        Dim total As Double

        'Assignments
        Integer.TryParse(CurrentReadBox.Text, current)
        Integer.TryParse(PreviousReadBox.Text, previous)

        'Calculations
        If current > previous Then
            used = current - previous
            total = CHARGE * (used / RATE)
        Else
            used = 0
            total = 0
            ErrorBox.Text = "Current reading is lower than previous."
        End If

        'Output
        GallonsBox.Text = Convert.ToString(used)
        TotalBox.Text = Convert.ToString(total)
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class