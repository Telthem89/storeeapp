Module SalesApp
    Function check_out()
        Dim checkout_success As Boolean = False
        Return checkout_success
    End Function

    'This Function Returns Index of Replicancy
    Function item_exist(ItemCode, ColumnName)
        Dim exist_at As Integer = -1
        Dim at_row As Integer = 0
        For Each row In POS.Cart_items.Rows

            If row.cells(ColumnName).value = ItemCode Then
                exist_at = at_row

            End If
            at_row += 1
        Next
        Return exist_at
    End Function


    '@PERFORMS CALCULATION FOR ALL This function calculates Sum
    Function calculate_sum()
        Dim grand_sum As Double = POS.total_sum_box.Text
        Dim discount As Double = POS.discount_box.Value
        Dim maximum_val As Integer = grand_sum - 1
        If maximum_val > 0 Then
            POS.discount_box.Maximum = maximum_val
        End If

        'Check if
        'Calculate Change
        Dim sum As Double = POS.paid_amount_box.Value

        'Summation
        Dim total As Double = (sum - grand_sum) + (discount)
        'Update Change
        POS.change_box.Text = total
        Return True
    End Function

    '@CALCULATES THE TOTAL PRICE OF ALL CART ITEMS
    Function update_price()
        Dim total_price As Double = 0
        Dim total_tax As Double = 0

        For Each row In POS.Cart_items.Rows
            Dim total_row As Double = row.cells("total").value
            Dim tax As Double = row.cells("tax").value

            If total_row > 0 Then
                total_price += total_row
            End If
            If tax > 0 Then
                total_tax += tax
            End If
        Next
        ''Display Total Value adn Tax
        POS.total_sum_box.Text = total_price
        POS.total_tax_box.Text = total_tax

        'Set Minimum Price
        POS.paid_amount_box.Value = total_price
        Return True
    End Function

    Function add_cart(ItemCode As String, ItemName As String, Quantity As Integer, Rate As Double, tax As Double)
        'Check if Already Existing
        Dim exist_row As Integer = item_exist(ItemCode, "item_code")
        If exist_row >= 0 Then
            Dim limited_quantity As Integer = POS.Item_quantity_box.Text

            Dim existing_q As Integer = POS.Cart_items.Rows(exist_row).Cells(2).Value + Quantity
            Dim total As Double = existing_q * Rate
            'Update Quantity and Total ONly if Limited Quantity is Greater
            If existing_q > limited_quantity Then

                MsgBox("Available Stock is less than the Purchase Quantity", MsgBoxStyle.Critical)
            Else
                POS.Cart_items.Rows(exist_row).Cells(2).Value = existing_q
                POS.Cart_items.Rows(exist_row).Cells(5).Value = total
                'Update Balance
                update_price()
            End If

        Else
            Dim total As Double = Quantity * Rate
            'Update IF an only Quantity is Greater
            Dim limit_quantity As Integer = POS.Item_quantity_box.Text

            If Quantity > limit_quantity Then
                MsgBox("Available Stock is less than the Purchase Quantity", MsgBoxStyle.Critical)
            Else
                POS.Cart_items.Rows.Add(ItemCode, ItemName, Quantity, Rate, tax, total)
                'Update Balance
                update_price()
            End If
        End If
        POS.search_results.Visible = True
        POS.search_combo_box.ResetText()
        Return True
    End Function
    Sub addCardD()
        Try
            If POS.purchase_quantity_box.Value > POS.Item_quantity_box.Text Then
                MsgBox("Quantity(" + POS.purchase_quantity_box.Value.ToString + ") exceeds the Available Quantity(" + POS.Item_quantity_box.Text + ")  of the Item")

            ElseIf POS.Item_quantity_box.Text < 1 Then
                MsgBox("This Item is currently Out of Stock")

            ElseIf POS.purchase_quantity_box.Value < 1 Then
                MsgBox("Please Specify Quantity of Item")
            Else
                add_cart(POS.item_code_box.Text, POS.item_name_box.Text, POS.purchase_quantity_box.Value, POS.item_price_box.Text, POS.item_tax_box.Text)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Sub loadCombox()
        findthis("SELECT DISTINCT(customer_name) FROM customer_details  ")
        fillcombo(POS.customer_name_box, "customer_name", "customer_name")

        findthis("SELECT DISTINCT(product_name) FROM product_details  ")
        fillcombo(POS.search_combo_box, "product_name", "product_name")
        'search_combo_box.Items.Add("Select Product here ...")
    End Sub

    Sub checkOut()
        Try

            Dim r_unique As String = Rnd(6) + DateTime.Now.ToString("ddhhHmmss")
            'Assign not Global
            'POS.TRANSACTION_ID = r_unique.ToString

            Dim t_price As Double = POS.total_sum_box.Text
            Dim t_discount As Double = POS.discount_box.Value
            Dim t_tax As Double = POS.total_tax_box.Text
            Dim p_amt As Double = POS.paid_amount_box.Value
            Dim p_change As Double = POS.change_box.Text
            Dim customer_name As String = POS.customer_name_box.Text
            Dim invoice_due As String = POS.invoice_due_date.Value.ToString("yyyy-MM-dd hh:mm:ss")
            Dim invoice_date As String = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
            Dim dataeADD As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim status As String = "1"

            issucess = insert("INSERT INTO invoice_receipt(receipt_no,invoice_type,total_price,discount,tax,paid_amount,change_amount,customer_name,cashier_name,invoice_date,invoice_due,dateAdded) VALUES('" + r_unique + "','INVOICE','" + t_price.ToString + "','" + t_discount.ToString + "','" + t_tax.ToString + "','" + p_amt.ToString + "','" + p_change.ToString + "','" + customer_name + "','" + POS.lblUser.Text + "','" + invoice_date + "','" + invoice_due + "','" + dataeADD + "')")
            If issucess = True Then
                MsgBox("Success add invoice into my database.....", MsgBoxStyle.Information)
                For Each row In POS.Cart_items.Rows
                    insert("INSERT INTO invoice_receipt_details(receipt_no,product_id,product_name,quantity,rate,tax,total_price,checkout_date,dateAdded) VALUES('" + r_unique + "','" + row.cells("item_code").value.ToString + "','" + row.cells("item_info").value.ToString + "','" + row.cells("Quantity").value.ToString + "','" + row.cells("Rate").value.ToString + "','" + row.cells("tax").value.ToString + "','" + row.cells("total").value.ToString + "','" + invoice_date + "','" + dataeADD + "')")
                    'Deduct Sales
                    insert("UPDATE product_details set quantity=quantity-" + row.cells("Quantity").value.ToString + " WHERE pro_barcode='" + row.cells("item_code").value.ToString + "'")
                Next
            Else
                MsgBox("Error while trying to process your transaction.....")
            End If
        Catch ex As Exception
            MsgBox("Error while trying to process your transaction.....", ex.Message)
        End Try
    End Sub

    Sub CollectingInvoicess()
        findthis(" SELECT receipt_no, invoice_type, total_price, discount, tax, paid_amount ,change_amount, customer_name, cashier_name, invoice_date from invoice_receipt")
        LoadData(Sales.Cart_itemInvoices, "Invoice1")
    End Sub

End Module
