Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles helloEnglish.Click
        helloSpanish.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles byeEnglish.Click
        byeSpanish.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loveEnglish.Click
        loveSpanish.Visible = True
    End Sub

    Private Sub catEnglish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles catEnglish.Click
        catSpanish.Visible = True
    End Sub

    Private Sub dogEnglish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dogEnglish.Click
        dogSpanish.Visible = True
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        helloSpanish.Visible = False
        byeSpanish.Visible = False
        loveSpanish.Visible = False
        catSpanish.Visible = False
        dogSpanish.Visible = False
    End Sub
End Class