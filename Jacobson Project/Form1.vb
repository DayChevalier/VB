Public Class Form1

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        'Declarations
        Dim oldPassword As String
        Dim newPassword As String
        Dim n As Integer

        'Assignments
        oldPassword = txtOriginal.Text
        newPassword = ""

        'Calculations
        If oldPassword.Contains("a") = True Or oldPassword.Contains("A") = True Then
            oldPassword = oldPassword.Replace("a", "X")
            oldPassword = oldPassword.Replace("A", "X")
        End If
        If oldPassword.Contains("e") = True Or oldPassword.Contains("E") = True Then
            oldPassword = oldPassword.Replace("e", "X")
            oldPassword = oldPassword.Replace("E", "X")
        End If
        If oldPassword.Contains("i") = True Or oldPassword.Contains("I") = True Then
            oldPassword = oldPassword.Replace("i", "X")
            oldPassword = oldPassword.Replace("I", "X")
        End If
        If oldPassword.Contains("o") = True Or oldPassword.Contains("O") = True Then
            oldPassword = oldPassword.Replace("o", "X")
            oldPassword = oldPassword.Replace("O", "X")
        End If
        If oldPassword.Contains("u") = True Or oldPassword.Contains("U") = True Then
            oldPassword = oldPassword.Replace("u", "X")
            oldPassword = oldPassword.Replace("U", "X")
        End If

        If oldPassword.Contains("1") = True Then
            oldPassword = oldPassword.Replace("1", "Z")
        End If
        If oldPassword.Contains("2") = True Then
            oldPassword = oldPassword.Replace("2", "Z")
        End If
        If oldPassword.Contains("3") = True Then
            oldPassword = oldPassword.Replace("3", "Z")
        End If
        If oldPassword.Contains("4") = True Then
            oldPassword = oldPassword.Replace("4", "Z")
        End If
        If oldPassword.Contains("5") = True Then
            oldPassword = oldPassword.Replace("5", "Z")
        End If
        If oldPassword.Contains("6") = True Then
            oldPassword = oldPassword.Replace("6", "Z")
        End If
        If oldPassword.Contains("7") = True Then
            oldPassword = oldPassword.Replace("7", "Z")
        End If
        If oldPassword.Contains("8") = True Then
            oldPassword = oldPassword.Replace("8", "Z")
        End If
        If oldPassword.Contains("9") = True Then
            oldPassword = oldPassword.Replace("9", "Z")
        End If
        If oldPassword.Contains("0") = True Then
            oldPassword = oldPassword.Replace("0", "Z")
        End If

        n = oldPassword.Length
        Do While n > 0
            newPassword += oldPassword.Substring(n - 1, 1)
            n = n - 1
        Loop


        'Output
        txtNew.Text = Convert.ToString(newPassword)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtOriginal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOriginal.TextChanged

    End Sub
End Class
