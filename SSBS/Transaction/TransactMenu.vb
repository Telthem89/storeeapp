Public Class TransactMenu
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Sales.Show()
        Sales.Location = New System.Drawing.Point(73, 55)
        Me.Hide()
        Dashboard.PanelMenu.Visible = False
    End Sub
End Class