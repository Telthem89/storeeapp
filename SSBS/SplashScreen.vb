Public Class SplashScreen
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class