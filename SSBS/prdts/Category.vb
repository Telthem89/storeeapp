Public Class Category
    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCategory()
    End Sub

    Private Sub BtnAdCat_Click(sender As Object, e As EventArgs) Handles btnAdCat.Click
        If btnAdCat.Text = "Add Category" Then
            AddCategory()
        Else
            UpdateCategory()
        End If
    End Sub

    Private Sub DataCategory_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataCategory.CellEnter
        fillCategoryTextBox()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Delete" Then
            DeleteCategory()
        Else
            txtDName.Text = ""
            txtDiscription.Text = ""
        End If
    End Sub
End Class