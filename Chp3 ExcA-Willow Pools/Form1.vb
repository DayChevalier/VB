Public Class Form1

    Private Sub CalcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcButton.Click
        'Declarations
        Dim length As Integer
        Dim width As Integer
        Dim height As Integer
        Dim volume As Integer

        'Assignments
        Integer.TryParse(LengthBox.Text, length)
        Integer.TryParse(WidthBox.Text, width)
        Integer.TryParse(HeightBox.Text, height)

        'Calculations
        volume = length * width * height

        'Output
        VolumeBox.Text = Convert.ToString(volume)

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class
