Public Class addSupplier
    Private Sub BtnAdSup_Click(sender As Object, e As EventArgs) Handles btnAdSup.Click
        If btnAdSup.Text = "Add Supplier" Then
            AddSuppliers()
        Else
            UpdateSup()
        End If
    End Sub

    Private Sub SupGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles supGrid.CellClick
        fillTextBox()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Delete" Then
            DeleteSup()
        Else
            txtFname.Text = ""
            txtAddres.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub AddSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
End Class