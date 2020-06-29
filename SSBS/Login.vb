Public Class Login

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUser.Text = "" Then
            MsgBox("Username is required", MsgBoxStyle.Critical)

        ElseIf txtPass.Text = "" Then
            MsgBox("Password is required", MsgBoxStyle.Critical)

        Else
            sql = "SELECT * FROM `user` WHERE `username`='" & txtUser.Text & "' AND `password`='" & txtPass.Text & "' "
            findthis(sql)

            If GetNumRows() = 1 Then
                ' MsgBox("Success", MsgBoxStyle.Information)
                LoadSingleResult("login")
                txtPass.Text = ""
                txtUser.Text = ""

            Else
                MsgBox("Username or Passwrord is not correct, Please try again!!", MsgBoxStyle.Critical)
                txtPass.Text = ""
                txtUser.Text = ""

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class