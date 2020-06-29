Public Class OutStock
    Private Sub OutStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAllOutStock()
        OutOfStock()
    End Sub

    Private Sub StockLevel_Enter(sender As Object, e As EventArgs) Handles stockLevel.Enter

    End Sub
End Class