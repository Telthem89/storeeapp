Imports System.Drawing.Printing
Imports System.Drawing.Bitmap
Public Class POS
    Dim newpage As Boolean
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Application.Exit()
    End Sub

    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCombox()
    End Sub

    Private Sub Add_Cart_btn_Click(sender As Object, e As EventArgs) Handles add_Cart_btn.Click
        addCardD()
    End Sub

    Private Sub Search_combo_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles search_combo_box.SelectedIndexChanged
        If search_combo_box.SelectedIndex = 0 Then
            search_combo_box.Text = "Select Product here ..."
        Else
            Try
                findthis("SELECT * FROM `product_details` WHERE `product_name`='" & search_combo_box.Text & "'")
                con.Open()
                dReader = cmd.ExecuteReader()

                While dReader.Read
                    item_name_box.Text = dReader("product_name")
                    item_price_box.Text = dReader("price")
                    Item_quantity_box.Text = dReader("quantity")
                    item_code_box.Text = dReader("pro_barcode")
                    item_tax_box.Text = dReader("tax")
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

    Private Sub Customer_name_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles customer_name_box.SelectedIndexChanged
        If customer_name_box.SelectedIndex = 0 Then
            customer_name_box.Text = "Select Customer here..."
        Else

        End If
    End Sub

    Private Sub Checkout_btn_Click(sender As Object, e As EventArgs) Handles Checkout_btn.Click
        checkOut()
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim all As Integer = Cart_items.RowCount
            If all > 0 Then
                Dim at = Cart_items.CurrentRow
                Dim identity = at.Cells(2)
                Dim answer = MsgBox("Do you want to Remove Selected?", MsgBoxStyle.YesNo, "Delete Item")
                If answer = MsgBoxResult.Yes Then
                    Cart_items.Rows.Remove(at)
                End If
                update_price()
            End If
        Catch ex As Exception
            MsgBox("System error...", MsgBoxStyle.YesNo, "System error" + ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim all As Integer = Cart_items.RowCount
            If all > 0 Then

                Dim answer = MsgBox("Clear all Cart Items ?", MsgBoxStyle.YesNo, "Clear Cart")
                If answer = MsgBoxResult.Yes Then
                    Cart_items.Rows.Clear()
                End If
                update_price()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            findthis("SELECT * FROM `product_details` WHERE `pro_barcode`='" & txtBarcode.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()

            While dReader.Read
                item_name_box.Text = dReader("product_name")
                item_price_box.Text = dReader("price")
                Item_quantity_box.Text = dReader("quantity")
                item_code_box.Text = dReader("product_id")
                item_tax_box.Text = dReader("tax")
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With Cart_items
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)

            Dim text As String = ("Powered by: Glendale SuperStore")
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            e.Graphics.DrawString(text, New Font("Verdana", 10, FontStyle.Bold), Brushes.Black, 350, 30)
            Dim y As Single = e.MarginBounds.Top
            Dim mRow As Integer = Nothing

            Do While mRow < Cart_items.RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)


                    If (newpage) Then
                        e.Graphics.DrawString(Cart_items.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(Cart_items.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next




                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 0
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With
    End Sub

    Private Sub Print_receipt_ask_CheckedChanged(sender As Object, e As EventArgs) Handles print_receipt_ask.CheckedChanged
        'PrintDocument1.DefaultPageSettings.Landscape = True
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.ShowDialog()
    End Sub
End Class