Module productsmodule
    Dim timeof As DateTime = TimeOfDay
    Dim todayday As DateTime = Format("yyyy-mmm-dd", Today)


    '=================================================================
    '  ========Product section===================================
    'fill all compboxes
    Sub fillAllCompoBox()
        findthis("SELECT DISTINCT(supplier_name) FROM suppliers  ")
        fillcombo(Product.cboSup, "supplier_name", "supplier_name")

        findthis("SELECT DISTINCT(category_name) FROM category  ")
        fillcombo(Product.cboCat, "category_name", "category_name")
    End Sub
    Sub GeneratebarNumber()
        Try
            findthis("SELECT Max(pro_barcode) From `product_details`")
            con.Open()
            Dim num As Integer = cmd.ExecuteScalar
            Product.txtprobar.Text = num + 1
            If Product.txtprobar.Text = "" Then
                Product.txtprobar.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub



    '  ***************Product registration************************
    Sub AddProduct()
        If Product.txtDName.Text = "" Then
            MsgBox("Product  name is required", MsgBoxStyle.Critical)

        ElseIf Product.cboCat.Text = "" Then
            MsgBox("Please select Category", MsgBoxStyle.Critical)

        ElseIf Product.cboSup.Text = "" Then
            MsgBox("Please select Supplier", MsgBoxStyle.Critical)
        ElseIf Product.med_sel_price.Text = "" Then
            MsgBox("Selling Price is required", MsgBoxStyle.Critical)

        Else
            issucess = insert("INSERT INTO `product_details` (`product_name`, `product_supplier`,`product_category`,`expiry_date`,`quantity`,`price`,`supplier_price`,`pro_barcode`,`tax`,`registered`)   VALUES ('" & Product.txtDName.Text & "','" & Product.catID.Text & "' ,'" & Product.supID.Text & "','" & Product.datePicked.Value & "','" & Product.med_avail_quantity.Value & "','" & Product.med_sel_price.Value & "','" & Product.med_supplier_price.Value & "','" & Product.txtprobar.Text & "' ,'" & Product.med_tax.Value & "' ,'" & todayday & "');")
            If issucess = True Then
                MsgBox("New product has been added successfully!", MsgBoxStyle.Information)
                CollectingAllProduct()

                Product.txtDName.Clear()
                Product.med_avail_quantity.ResetText()
                Product.med_sel_price.ResetText()
                Product.med_supplier_price.ResetText()
                Product.med_tax.ResetText()
            Else
                MsgBox("No product added into the database!", MsgBoxStyle.Critical)

            End If
        End If
    End Sub

    'update
    Sub updatePRO()
        ' issucess = insert("INSERT INTO `product_details` (`product_name`, `product_supplier`,`product_category`,`expiry_date`,`quantity`,`price`,`supplier_price`,`pro_barcode`,`tax`,`registered`)   VALUES ('" & Product.txtDName.Text & "','" & Product.catID.Text & "' ,'" & Product.supID.Text & "','" & Product.datePicked.Value & "','" & Product.med_avail_quantity.Value & "','" & Product.med_sel_price.Value & "','" & Product.med_supplier_price.Value & "','" & Product.txtprobar.Text & "' ,'" & Product.med_tax.Value & "' ,'" & todayday & "');")

        issucess = insert("UPDATE product_details SET product_name='" & Product.txtDName.Text & "', product_category='" & Product.catID.Text & "', product_supplier='" & Product.supID.Text & "',expiry_date='" & Product.datePicked.Value & "',quantity='" & Product.med_avail_quantity.Value & "',price='" & Product.med_sel_price.Value & "',supplier_price='" & Product.med_supplier_price.Value & "',tax='" & Product.med_tax.Value & "' Where pro_barcode='" & Product.txtprobar.Text & "'")
        If issucess = True Then
            MsgBox("Poduct has been updated successfully!", MsgBoxStyle.Information)
            CollectingAllProduct()
        Else
            MsgBox("No Poduct updated into the database!", MsgBoxStyle.Critical)

        End If
    End Sub

    'del
    Sub DeletePro()
        issucess = delete("DELETE From product_details  Where pro_barcode='" & Product.txtprobar.Text & "'")
        If issucess = True Then
            MsgBox("Product has been deleted successfully!", MsgBoxStyle.Information)
            CollectingAllProduct()
        Else
            MsgBox("Error check your connections!", MsgBoxStyle.Critical)
        End If
    End Sub
    '  ***************Load all Products************************
    Sub CollectingAllProduct()

        sql = "SELECT product_details.product_id, product_details.product_name, suppliers.supplier_name, category.category_name, product_details.expiry_date, product_details.quantity, product_details.price, product_details.supplier_price, product_details.pro_barcode, product_details.tax
FROM suppliers INNER JOIN (category INNER JOIN product_details ON category.category_id = product_details.product_category) ON suppliers.supplier_id = product_details.product_supplier
WHERE (((suppliers.supplier_id)= product_details.product_supplier) AND ((category.category_id)=product_details.product_category))"
        ' findthis("SELECT product_details.product_id, product_details.product_name, suppliers.supplier_name, category.category_name,product_details.expiry_date,product_details.quantity,product_details.price ,product_details.supplier_price ,product_details.tax  FROM `product_details` INNER JOIN `suppliers` on suppliers.supplier_id = product_details.product_supplier INNER JOIN `category` on category.category_id = product_details.product_category")
        findthis(sql)
        LoadData(Product.product_items, "productList")
    End Sub


    Sub fillproTextBox()

        Product.txtDName.Text = Product.product_items.CurrentRow.Cells(1).Value.ToString
        Product.cboSup.Text = Product.product_items.CurrentRow.Cells(2).Value.ToString
        Product.cboCat.Text = Product.product_items.CurrentRow.Cells(3).Value.ToString
        Product.datePicked.Text = Product.product_items.CurrentRow.Cells(4).Value.ToString
        Product.med_avail_quantity.Text = Product.product_items.CurrentRow.Cells(5).Value.ToString
        Product.med_sel_price.Text = Product.product_items.CurrentRow.Cells(6).Value.ToString
        Product.med_supplier_price.Text = Product.product_items.CurrentRow.Cells(7).Value.ToString
        Product.txtprobar.Text = Product.product_items.CurrentRow.Cells(8).Value.ToString

        Product.btnDelete.Text = "Delete"
        Product.btnAddPr.Text = "Update"
    End Sub






    '========End Product section================
    '===========================================================
    ' =================================================================








    '============================================
    '  ========Category section=============
    '  ***************Category registration************************
    Sub AddCategory()
        If Category.txtDName.Text = "" Then
            MsgBox("Category name is required", MsgBoxStyle.Critical)

        ElseIf Category.txtDiscription.Text = "" Then
            MsgBox("Description is required", MsgBoxStyle.Critical)
        Else
            issucess = insert("INSERT INTO `category` (`category_name`, `category_detail`)   VALUES ('" & Category.txtDName.Text & "','" & Category.txtDiscription.Text & "' );")
            If issucess = True Then
                MsgBox("New Category has been added successfully!", MsgBoxStyle.Information)
                RefreshCategory()
            Else
                MsgBox("No Category added into the database!", MsgBoxStyle.Critical)

            End If
        End If
    End Sub






    '  ***************Load all Category************************
    Sub RefreshCategory()
        findthis("SELECT category_id,category_name,category_detail FROM category")
        LoadData(Category.DataCategory, "category")
    End Sub




    '  ***************fill textbox************************
    Sub fillCategoryTextBox()
        Category.lblcatid.Text = Category.DataCategory.CurrentRow.Cells(0).Value.ToString
        Category.txtDName.Text = Category.DataCategory.CurrentRow.Cells(1).Value.ToString
        Category.txtDiscription.Text = Category.DataCategory.CurrentRow.Cells(2).Value.ToString
        Category.btnDelete.Text = "Delete"
        Category.btnAdCat.Text = "Update Category"
    End Sub



    '  ***************Update Category************************
    Sub UpdateCategory()
        issucess = insert("UPDATE category SET category_name='" & Category.txtDName.Text & "', category_detail='" & Category.txtDiscription.Text & "' Where category_id='" & Category.lblcatid.Text & "'")
        If issucess = True Then
            MsgBox("Category has been updated successfully!", MsgBoxStyle.Information)
            RefreshCategory()
        Else
            MsgBox("No Category updated into the database!", MsgBoxStyle.Critical)

        End If
    End Sub





    '  ***************Delete Category************************
    Sub DeleteCategory()
        issucess = delete("DELETE From category  Where category_id='" & Category.lblcatid.Text & "'")
        If issucess = True Then
            MsgBox("Category has been deleted successfully!", MsgBoxStyle.Information)
            RefreshCategory()
        Else
            MsgBox("Error check your connections!", MsgBoxStyle.Critical)
        End If
    End Sub

    '========End Category section=============
    '===========================================


    Sub getAllOutStock()

        sql = "SELECT product_details.product_id, product_details.product_name, suppliers.supplier_name, category.category_name, product_details.expiry_date, product_details.price, product_details.quantity, product_details.supplier_price, product_details.tax, product_details.registered
FROM suppliers INNER JOIN (category INNER JOIN product_details ON category.category_id = product_details.product_category) ON suppliers.supplier_id = product_details.product_supplier
WHERE (((product_details.quantity)<700));
"


        findthis(sql)
        LoadData(OutStock.Cart_itemoutstock, "outStocksFills")
    End Sub

    Sub OutOfStock()
        sql = "SELECT count(quantity) FROM product_details WHERE quantity <= 700"
        findthis(sql)
        If GetNumRows() = 1 Then
            Dim countoutstock = GetCount()
            OutStock.lblStockLvl.Text = countoutstock
            MsgBox(OutStock.lblStockLvl.Text & " Product(s) run out of stock", MsgBoxStyle.Information)

        End If


    End Sub

End Module
