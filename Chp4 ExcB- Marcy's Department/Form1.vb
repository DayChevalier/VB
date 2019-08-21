Public Class Form1

    Private Sub CalcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcButton.Click
        Dim first As Double
        Dim second As Double
        Dim halfed As Double
        Dim total As Double

        'Assignments
        Integer.TryParse(Item1Box.Text, first)
        Integer.TryParse(Item2Box.Text, second)

        'Calculations
        If first < second Then
            halfed = first / 2
            total = second + halfed
        Else
            halfed = second / 2
            total = first + halfed
        End If

        'Output
        HalfBox.Text = Convert.ToString(halfed)
        TotalBox.Text = Convert.ToString(total)
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
