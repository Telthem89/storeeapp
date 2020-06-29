Public Class Product
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillAllCompoBox()
        CollectingAllProduct()

        GeneratebarNumber()
    End Sub

    Private Sub BtnAddPr_Click(sender As Object, e As EventArgs) Handles btnAddPr.Click
        If btnAddPr.Text = "Add Product" Then
            AddProduct()
        Else
            updatePRO()
        End If
    End Sub

    Private Sub CboCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCat.SelectedIndexChanged
        If cboCat.SelectedIndex = 0 Then
            cboCat.Text = "Select Category here ..."
        Else
            Try
                findthis("SELECT * FROM `category` WHERE `category_name`='" & cboCat.Text & "'")


                con.Open()
                dReader = cmd.ExecuteReader()

                While dReader.Read
                    catID.Text = dReader("category_id")
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                da.Dispose()

            End Try
            con.Close()
        End If
    End Sub

    Private Sub CboSup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSup.SelectedIndexChanged
        If cboSup.SelectedIndex = 0 Then
            cboSup.Text = "Select Supplier here ..."
        Else
            Try
                findthis("SELECT * FROM `suppliers` WHERE `supplier_name`='" & cboSup.Text & "'")


                con.Open()
                dReader = cmd.ExecuteReader()

                While dReader.Read
                    supID.Text = dReader("supplier_id")
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                da.Dispose()

            End Try
            con.Close()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim selected_id As String = product_items.SelectedCells(0).Value.ToString
        Dim selected_name As String = product_items.SelectedCells(1).Value.ToString

        Dim msg = MsgBox("Are you sure you want to Delete " & selected_name & " ??", MsgBoxStyle.OkCancel, "Confirm Delete")
        If msg = MsgBoxResult.Ok Then
            issucess = delete("DELETE From product_details  Where product_id='" & selected_id & "'")
            MsgBox("Category has been deleted successfully!", MsgBoxStyle.Information)
            CollectingAllProduct()
        Else
            MsgBox("Error check your connections!", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Clear" Then
            txtDName.Clear()
            med_avail_quantity.ResetText()
            med_sel_price.ResetText()
            med_supplier_price.ResetText()
            med_tax.ResetText()
        Else
            DeletePro()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CollectingAllProduct()
    End Sub

    Private Sub Product_items_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles product_items.CellClick
        fillproTextBox()
    End Sub

    Private Sub Searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged

    End Sub
End Class