Module memberMdl
    Dim timeof As DateTime = TimeOfDay
    Dim todayday As DateTime = Format("yyyy-mmm-dd", Today)

    '============================================
    '  ========Member section=============
    '  ***************Member registration************************
    Sub RegisterMember()
        issucess = insert("INSERT INTO `user` (`username`, `name`, `surname`,`userType`,`gender`,`password`) VALUES('" & addMembers.txtUser.Text & "','" & addMembers.txtName.Text & "', '" & addMembers.txtSurname.Text & "','" & addMembers.cboUser.Text & "','" & addMembers.cboGender.Text & "','" & addMembers.txtPass.Text & "')")
        If issucess = True Then
            MsgBox("Member has been registered successfully!", MsgBoxStyle.Information)
            LoadMembers()
            addMembers.txtPass.Text = ""
            addMembers.txtSurname.Text = ""
            addMembers.txtName.Text = ""
            addMembers.txtUser.Text = ""
            addMembers.cboGender.Text = ""
            addMembers.cboUser.Text = ""
        Else
            MsgBox("No Member has been registered!", MsgBoxStyle.Critical)
        End If

    End Sub

    '  ***************Load all Members************************
    Sub LoadMembers()
        findthis("SELECT userid,username,name,surname,userType,gender,password FROM `user`")
        LoadData(addMembers.DataGridMembers, "addMembers")
    End Sub

    '  ***************Update Member************************
    Sub UpdateMrmber()
        issucess = insert("UPDATE `user` SET  `name`='" & addMembers.txtName.Text & "',`surname`= '" & addMembers.txtSurname.Text & "',`username`='" & addMembers.txtUser.Text & "',`userType`= '" & addMembers.cboUser.Text & "',`password`= '" & addMembers.txtPass.Text & "',`gender`='" & addMembers.cboGender.Text & "'  WHERE `userid`='" & addMembers.lblMem.Text & "'")
        If issucess = True Then
            MsgBox("Member details has been updated Successfully ", MsgBoxStyle.Information)
            LoadMembers()
        Else
            MsgBox("Error occured..................!!!", MsgBoxStyle.Critical)
        End If
    End Sub

    '********************fillable textbox****************************
    Sub FillMemberTextBox()
        addMembers.btnDelete.Text = "Delete"
        addMembers.btnAdUser.Text = "Update Member"
        addMembers.lblMem.Text = addMembers.DataGridMembers.CurrentRow.Cells(0).Value.ToString
        addMembers.txtUser.Text = addMembers.DataGridMembers.CurrentRow.Cells(1).Value.ToString
        addMembers.txtName.Text = addMembers.DataGridMembers.CurrentRow.Cells(2).Value.ToString
        addMembers.txtSurname.Text = addMembers.DataGridMembers.CurrentRow.Cells(3).Value.ToString
        addMembers.cboUser.Text = addMembers.DataGridMembers.CurrentRow.Cells(4).Value.ToString
        addMembers.cboGender.Text = addMembers.DataGridMembers.CurrentRow.Cells(5).Value.ToString
        addMembers.txtPass.Text = addMembers.DataGridMembers.CurrentRow.Cells(6).Value.ToString
    End Sub

    '********************delete member***************************
    Sub DeleteMember()
        issucess = delete("DELETE FROM user  WHERE `userid`='" & addMembers.lblMem.Text & "'")
        If issucess = True Then
            MsgBox("Member details has been Deleted successfully!", MsgBoxStyle.Information)
            LoadMembers()
        Else
            MsgBox("Error occured..................!!!", MsgBoxStyle.Critical)

        End If

    End Sub
    '========End Member section=============
    '===========================================







    '============================================
    '  ========Suppler section=============
    '  ***************Suppler registration************************
    Sub AddSuppliers()
        If addSupplier.txtAddres.Text = "" Then
            MsgBox("Address is required", MsgBoxStyle.Critical)
        ElseIf addSupplier.txtEmail.Text = "" Then
            MsgBox("Email is required", MsgBoxStyle.Critical)

        ElseIf addSupplier.txtFname.Text = "" Then
            MsgBox("Name Serial Number is required", MsgBoxStyle.Critical)
        ElseIf addSupplier.txtPhone.Text = "" Then
            MsgBox("Phone is required", MsgBoxStyle.Critical)
        Else
            issucess = insert("INSERT INTO `suppliers` (`supplier_name`, `supplier_address`, `supplier_email`,`supplier_mobile`, `registered`)   VALUES ('" & addSupplier.txtFname.Text & "','" & addSupplier.txtAddres.Text & "', '" & addSupplier.txtEmail.Text & "', '" & addSupplier.txtPhone.Text & "','" & todayday & "' );")
            If issucess = True Then
                MsgBox("New supplier has been added successfully!", MsgBoxStyle.Information)
                RefreshGrid()
            Else
                MsgBox("No supplier added into the database!", MsgBoxStyle.Critical)

            End If
        End If
    End Sub

    '  ***************Update Suppler************************
    Sub UpdateSup()
        issucess = insert("UPDATE suppliers SET supplier_name='" & addSupplier.txtFname.Text & "', supplier_address='" & addSupplier.txtAddres.Text & "',supplier_email='" & addSupplier.txtEmail.Text & "',supplier_mobile='" & addSupplier.txtPhone.Text & "' Where supplier_id='" & addSupplier.lblSupp.Text & "'")
        If issucess = True Then
            MsgBox("New supplier has been updated successfully!", MsgBoxStyle.Information)
            RefreshGrid()
        Else
            MsgBox("No supplier updated into the database!", MsgBoxStyle.Critical)

        End If
    End Sub

    '  ***************Delete Suppler************************

    Sub DeleteSup()
        issucess = delete("DELETE From suppliers  Where supplier_id='" & addSupplier.lblSupp.Text & "'")
        If issucess = True Then
            MsgBox("Supplier has been deleted successfully!", MsgBoxStyle.Information)
            RefreshGrid()

        End If
    End Sub

    '  ***************Fill Supplergrid************************
    Sub fillTextBox()

        addSupplier.lblSupp.Text = addSupplier.supGrid.CurrentRow.Cells(0).Value.ToString
        addSupplier.txtFname.Text = addSupplier.supGrid.CurrentRow.Cells(1).Value.ToString
        addSupplier.txtAddres.Text = addSupplier.supGrid.CurrentRow.Cells(2).Value.ToString
        addSupplier.txtEmail.Text = addSupplier.supGrid.CurrentRow.Cells(3).Value.ToString
        addSupplier.txtPhone.Text = addSupplier.supGrid.CurrentRow.Cells(4).Value.ToString
        addSupplier.btnDelete.Text = "Delete"
        addSupplier.btnAdSup.Text = "Update Supplier"
    End Sub

    '  ***************Load all Supplers************************
    Sub RefreshGrid()
        findthis("SELECT supplier_id,supplier_name,supplier_address,supplier_email,supplier_mobile,registered FROM `suppliers`")
        LoadData(addSupplier.supGrid, "supplier")
    End Sub
    '========End Suppler section=============
    '===========================================









    '============================================
    '  ========Customer section=============
    '  ***************Customer registration************************
    Sub AddSCustomerAcc()
        If addCustomer.txtAddres.Text = "" Then
            MsgBox("Address is required", MsgBoxStyle.Critical)
        ElseIf addCustomer.txtEmail.Text = "" Then
            MsgBox("Email is required", MsgBoxStyle.Critical)

        ElseIf addCustomer.txtFname.Text = "" Then
            MsgBox("Name  is required", MsgBoxStyle.Critical)
        ElseIf addCustomer.txtPhone.Text = "" Then
            MsgBox("Phone is required", MsgBoxStyle.Critical)
        Else
            issucess = insert("INSERT INTO `customer_details` (`customer_name`, `customer_address`, `customer_mobile`,`customer_email`, `registered`)   VALUES ('" & addCustomer.txtFname.Text & "','" & addCustomer.txtAddres.Text & "', '" & addCustomer.txtPhone.Text & "', '" & addCustomer.txtEmail.Text & "','" & todayday & "' );")
            If issucess = True Then
                MsgBox("New Customer has been added successfully!", MsgBoxStyle.Information)
                LoadCustomer()
            Else
                MsgBox("No Customer added into the database!", MsgBoxStyle.Critical)

            End If
        End If
    End Sub


    '  ***************Load all Customers************************
    Sub LoadCustomer()
        findthis("SELECT customer_id,customer_name,customer_address,customer_mobile,customer_email,registered FROM `customer_details`")
        LoadData(addCustomer.DataGridMembers, "customers")
    End Sub

    '  ***************fill textboxs************************
    Sub fillCustomerTextBox()

        addCustomer.lblCust.Text = addCustomer.DataGridMembers.CurrentRow.Cells(0).Value.ToString
        addCustomer.txtFname.Text = addCustomer.DataGridMembers.CurrentRow.Cells(1).Value.ToString
        addCustomer.txtAddres.Text = addCustomer.DataGridMembers.CurrentRow.Cells(2).Value.ToString
        addCustomer.txtPhone.Text = addCustomer.DataGridMembers.CurrentRow.Cells(3).Value.ToString
        addCustomer.txtEmail.Text = addCustomer.DataGridMembers.CurrentRow.Cells(4).Value.ToString
        addCustomer.btnDelete.Text = "Delete"
        addCustomer.btnAdCust.Text = "Update Customer"
    End Sub

    '  ***************Update Customer************************
    Sub UpdateCustomer()
        issucess = insert("UPDATE customer_details SET customer_name='" & addCustomer.txtFname.Text & "', customer_address='" & addCustomer.txtAddres.Text & "',customer_mobile='" & addCustomer.txtPhone.Text & "',customer_email='" & addCustomer.txtEmail.Text & "' Where customer_id='" & addCustomer.lblCust.Text & "'")
        If issucess = True Then
            MsgBox("New customer has been updated successfully!", MsgBoxStyle.Information)
            LoadCustomer()
        Else
            MsgBox("No customer updated into the database!", MsgBoxStyle.Critical)

        End If
    End Sub

    '  ***************Delete Suppler************************

    Sub DeleteCustomer()
        issucess = delete("DELETE From customer_details  Where customer_id='" & addSupplier.lblSupp.Text & "'")
        If issucess = True Then
            MsgBox("Customer has been deleted successfully!", MsgBoxStyle.Information)
            LoadCustomer()

        End If
    End Sub

    '========End Customer section=============
    '===========================================
End Module
