Public Class Dashboard
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '================== PanelMenu sidebar
        PanelMenu.Visible = True

        ' close others
        Product.Visible = False
        Category.Visible = False
        addSupplier.Visible = False
        addCustomer.Visible = False
        addMembers.Visible = False
        TransactMenu.Visible = False
        OutStock.Visible = False
        Sales.Visible = False
    End Sub


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ' ==================Product Panel sidebar
        Product.Show()
        Product.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
        Category.Visible = False
        addSupplier.Visible = False
        addCustomer.Visible = False
        addMembers.Visible = False
        TransactMenu.Visible = False
        OutStock.Visible = False
        Sales.Visible = False

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ==================Product Panel mainmenu
        Product.Show()
        Product.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        '=====================Category Panel Sidebar 249, 0
        Category.Show()
        Category.Location = New System.Drawing.Point(249, 55)

        ' close others
        PanelMenu.Visible = False
        Product.Visible = False
        addSupplier.Visible = False
        addCustomer.Visible = False
        addMembers.Visible = False
        TransactMenu.Visible = False
        OutStock.Visible = False
        Sales.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '=====================Category Panel mainmenu 
        Category.Show()
        Category.Location = New System.Drawing.Point(249, 55)
        ' close others
        PanelMenu.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '=====================Supplier Panel mainmenu
        addSupplier.Show()
        addSupplier.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        '=====================Supplier Panel sidebar
        addSupplier.Show()
        addSupplier.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
        Product.Visible = False
        Category.Visible = False
        addCustomer.Visible = False
        addMembers.Visible = False
        TransactMenu.Visible = False
        OutStock.Visible = False
        Sales.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        '=====================Customer Panel sidebar
        addCustomer.Show()
        addCustomer.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
        Product.Visible = False
        Category.Visible = False
        addSupplier.Visible = False
        addMembers.Visible = False
        TransactMenu.Visible = False
        OutStock.Visible = False
        Sales.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '=====================Customer Panel sidebar
        addCustomer.Show()
        addCustomer.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        '=====================Members Panel sidebar
        addMembers.Show()
        addMembers.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
        Product.Visible = False
        Category.Visible = False
        addSupplier.Visible = False
        addCustomer.Visible = False
        TransactMenu.Visible = False
        OutStock.Visible = False
        Sales.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '=====================Members Panel mainmenu
        addMembers.Show()
        addMembers.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        '=====================Transaction Panel sidebar
        TransactMenu.Show()
        TransactMenu.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
        Product.Visible = False
        Category.Visible = False
        addSupplier.Visible = False
        addCustomer.Visible = False
        addMembers.Visible = False
        OutStock.Visible = False
        Sales.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '=====================Transaction Panel mainmenu
        TransactMenu.Show()
        TransactMenu.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        '=====================OutStock Panel sidebar
        OutStock.Show()
        OutStock.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
        Product.Visible = False
        Category.Visible = False
        addSupplier.Visible = False
        addCustomer.Visible = False
        TransactMenu.Visible = False
        Sales.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '=====================OutStock Panel mainmenu
        OutStock.Show()
        OutStock.Location = New System.Drawing.Point(73, 55)

        ' close others
        PanelMenu.Visible = False
    End Sub
End Class