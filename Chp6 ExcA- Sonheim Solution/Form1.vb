Public Class Form1

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim cost As Double
        Dim life As Double
        Dim value As Double
        Dim depreciation As Double
        Dim n As Double
        Dim tempString As String

        'Assignments
        Double.TryParse(txtCost.Text, cost)
        life = lstLife.SelectedItem
        Double.TryParse(txtValue.Text, value)

        'Calculations & Output
        n = 1
        txtDepreciation.Text = "Year    Depreciation" & vbNewLine
        Do While n <= life
            depreciation = Financial.DDB(cost, value, life, n)
            tempString = "  " & Convert.ToString(n) & "         " & Convert.ToString(depreciation) & vbNewLine
            txtDepreciation.Text += tempString
            n = n + 1
        Loop

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
