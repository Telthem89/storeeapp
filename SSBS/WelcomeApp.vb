Public Class WelcomeApp
    Private Sub BtnLogoutSales_Click(sender As Object, e As EventArgs) Handles btnLogoutSales.Click
        POS.Show()
        Me.Hide()
    End Sub
End Class