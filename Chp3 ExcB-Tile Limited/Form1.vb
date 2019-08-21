Public Class Form1

    Private Sub CalcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcButton.Click
        'Declarations
        Dim length As Integer
        Dim width As Integer
        Dim price As Double
        Dim area As Integer
        Dim total As Double

        'Assignments
        Integer.TryParse(LengthBox.Text, length)
        Integer.TryParse(WidthBox.Text, width)
        Integer.TryParse(PriceBox.Text, price)

        'Calculations
        area = length * width
        total = area * price

        'Output
        AreaBox.Text = Convert.ToString(area)
        TotalBox.Text = Convert.ToString(total)
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class
