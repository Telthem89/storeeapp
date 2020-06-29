Public Class addCustomer
    Private Sub BtnAdCust_Click(sender As Object, e As EventArgs) Handles btnAdCust.Click
        If btnAdCust.Text = "Add Customer" Then
            AddSCustomerAcc()
        Else
            UpdateCustomer()

        End If
    End Sub

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
    End Sub

    Private Sub DataGridMembers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMembers.CellClick
        fillCustomerTextBox()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Delete" Then
            DeleteCustomer()
        Else
            txtFname.Text = ""
            txtAddres.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
        End If
    End Sub
End Class