Public Class addMembers
    Private Sub BtnAdUser_Click(sender As Object, e As EventArgs) Handles btnAdUser.Click

        If btnAdUser.Text = "Add user" Then
            RegisterMember()

        Else
            UpdateMrmber()
        End If
    End Sub

    Private Sub AddMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembers()
    End Sub

    Private Sub DataGridMembers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMembers.CellClick
        FillMemberTextBox()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If btnDelete.Text = "Delete" Then
            DeleteMember()
        Else
            txtPass.Text = ""
            txtSurname.Text = ""
            txtName.Text = ""
            txtUser.Text = ""
            cboGender.Text = ""
            cboUser.Text = ""
        End If
    End Sub
End Class