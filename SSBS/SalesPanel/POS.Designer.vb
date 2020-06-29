<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.invoice_type_nav = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.search_results = New System.Windows.Forms.GroupBox()
        Me.item_code_box = New System.Windows.Forms.TextBox()
        Me.medicine_image = New System.Windows.Forms.PictureBox()
        Me.item_tax_box = New System.Windows.Forms.TextBox()
        Me.Item_quantity_box = New System.Windows.Forms.TextBox()
        Me.item_price_box = New System.Windows.Forms.TextBox()
        Me.item_name_box = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.add_Cart_btn = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.purchase_quantity_box = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.product_details_loader = New System.Windows.Forms.PictureBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.invoice_due_date = New System.Windows.Forms.DateTimePicker()
        Me.invoice_due_label = New System.Windows.Forms.Label()
        Me.customer_label_tag = New System.Windows.Forms.Label()
        Me.customer_name_box = New System.Windows.Forms.ComboBox()
        Me.cart_api2 = New System.Windows.Forms.GroupBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.search_combo_box = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cart_api = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Cart_items = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Checkout_btn = New System.Windows.Forms.Button()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.print_receipt_ask = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.paid_amount_box = New System.Windows.Forms.NumericUpDown()
        Me.change_box = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.total_tax_box = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.discount_box = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.total_sum_box = New System.Windows.Forms.TextBox()
        Me.currency1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.item_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_info = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.search_results.SuspendLayout()
        CType(Me.medicine_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.purchase_quantity_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.product_details_loader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.cart_api2.SuspendLayout()
        Me.cart_api.SuspendLayout()
        CType(Me.Cart_items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paid_amount_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.discount_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1352, 72)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.invoice_type_nav)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(1058, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 44)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'invoice_type_nav
        '
        Me.invoice_type_nav.AutoSize = True
        Me.invoice_type_nav.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_type_nav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.invoice_type_nav.Location = New System.Drawing.Point(139, 18)
        Me.invoice_type_nav.Name = "invoice_type_nav"
        Me.invoice_type_nav.Size = New System.Drawing.Size(88, 16)
        Me.invoice_type_nav.TabIndex = 6
        Me.invoice_type_nav.Text = "New POS Sale"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(34, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Home / Invoices /"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SSBS.My.Resources.Resources.ssb
        Me.PictureBox5.Location = New System.Drawing.Point(5, 7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(195, 53)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button33)
        Me.Panel2.Controls.Add(Me.Button34)
        Me.Panel2.Controls.Add(Me.Button31)
        Me.Panel2.Controls.Add(Me.Button29)
        Me.Panel2.Controls.Add(Me.Button30)
        Me.Panel2.Controls.Add(Me.Button28)
        Me.Panel2.Controls.Add(Me.Button27)
        Me.Panel2.Controls.Add(Me.Button23)
        Me.Panel2.Controls.Add(Me.Button24)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.search_results)
        Me.Panel2.Controls.Add(Me.product_details_loader)
        Me.Panel2.Controls.Add(Me.GroupBox8)
        Me.Panel2.Controls.Add(Me.cart_api2)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.cart_api)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(4, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1344, 673)
        Me.Panel2.TabIndex = 4
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.DimGray
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button33.ForeColor = System.Drawing.Color.White
        Me.Button33.Location = New System.Drawing.Point(1136, 577)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(170, 59)
        Me.Button33.TabIndex = 60
        Me.Button33.Text = "More..."
        Me.Button33.UseVisualStyleBackColor = False
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.DimGray
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button34.ForeColor = System.Drawing.Color.White
        Me.Button34.Location = New System.Drawing.Point(435, 577)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(228, 59)
        Me.Button34.TabIndex = 59
        Me.Button34.Text = "Print Change"
        Me.Button34.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.DimGray
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.ForeColor = System.Drawing.Color.White
        Me.Button31.Location = New System.Drawing.Point(670, 577)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(227, 59)
        Me.Button31.TabIndex = 58
        Me.Button31.Text = "Discount"
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.DimGray
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.ForeColor = System.Drawing.Color.White
        Me.Button29.Location = New System.Drawing.Point(903, 577)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(226, 59)
        Me.Button29.TabIndex = 57
        Me.Button29.Text = "Logout"
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.DimGray
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.ForeColor = System.Drawing.Color.White
        Me.Button30.Location = New System.Drawing.Point(221, 577)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(208, 59)
        Me.Button30.TabIndex = 56
        Me.Button30.Text = "Void Sale"
        Me.Button30.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.DimGray
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.ForeColor = System.Drawing.Color.White
        Me.Button28.Location = New System.Drawing.Point(12, 577)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(201, 59)
        Me.Button28.TabIndex = 51
        Me.Button28.Text = "Stock Search"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.DimGray
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.Color.White
        Me.Button27.Location = New System.Drawing.Point(1136, 512)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(170, 59)
        Me.Button27.TabIndex = 50
        Me.Button27.Text = "Suspend Sale"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.DimGray
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.Color.White
        Me.Button23.Location = New System.Drawing.Point(902, 514)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(228, 57)
        Me.Button23.TabIndex = 49
        Me.Button23.Text = "Print Last Slip"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.DimGray
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.Color.White
        Me.Button24.Location = New System.Drawing.Point(669, 514)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(228, 57)
        Me.Button24.TabIndex = 48
        Me.Button24.Text = "Refunds"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DimGray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(435, 514)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(228, 57)
        Me.Button6.TabIndex = 47
        Me.Button6.Text = "Price Check"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.DimGray
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(221, 514)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(208, 57)
        Me.Button10.TabIndex = 46
        Me.Button10.Text = "Account Payment"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 514)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 57)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Price Mode: Normal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'search_results
        '
        Me.search_results.Controls.Add(Me.item_code_box)
        Me.search_results.Controls.Add(Me.medicine_image)
        Me.search_results.Controls.Add(Me.item_tax_box)
        Me.search_results.Controls.Add(Me.Item_quantity_box)
        Me.search_results.Controls.Add(Me.item_price_box)
        Me.search_results.Controls.Add(Me.item_name_box)
        Me.search_results.Controls.Add(Me.Label21)
        Me.search_results.Controls.Add(Me.Label15)
        Me.search_results.Controls.Add(Me.GroupBox7)
        Me.search_results.Controls.Add(Me.Label13)
        Me.search_results.Controls.Add(Me.Label22)
        Me.search_results.Controls.Add(Me.Label11)
        Me.search_results.Location = New System.Drawing.Point(14, 221)
        Me.search_results.Name = "search_results"
        Me.search_results.Size = New System.Drawing.Size(540, 273)
        Me.search_results.TabIndex = 4
        Me.search_results.TabStop = False
        Me.search_results.Text = "Found / Selected Medicine"
        '
        'item_code_box
        '
        Me.item_code_box.BackColor = System.Drawing.Color.White
        Me.item_code_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.item_code_box.Cursor = System.Windows.Forms.Cursors.No
        Me.item_code_box.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_code_box.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.item_code_box.Location = New System.Drawing.Point(93, 65)
        Me.item_code_box.Name = "item_code_box"
        Me.item_code_box.ReadOnly = True
        Me.item_code_box.Size = New System.Drawing.Size(159, 19)
        Me.item_code_box.TabIndex = 9
        Me.item_code_box.TabStop = False
        Me.item_code_box.Text = "0"
        '
        'medicine_image
        '
        Me.medicine_image.Image = Global.SSBS.My.Resources.Resources.calculation
        Me.medicine_image.Location = New System.Drawing.Point(333, 19)
        Me.medicine_image.Name = "medicine_image"
        Me.medicine_image.Size = New System.Drawing.Size(207, 171)
        Me.medicine_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.medicine_image.TabIndex = 10
        Me.medicine_image.TabStop = False
        '
        'item_tax_box
        '
        Me.item_tax_box.BackColor = System.Drawing.Color.White
        Me.item_tax_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.item_tax_box.Cursor = System.Windows.Forms.Cursors.No
        Me.item_tax_box.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_tax_box.ForeColor = System.Drawing.Color.Purple
        Me.item_tax_box.Location = New System.Drawing.Point(46, 139)
        Me.item_tax_box.Name = "item_tax_box"
        Me.item_tax_box.ReadOnly = True
        Me.item_tax_box.Size = New System.Drawing.Size(61, 19)
        Me.item_tax_box.TabIndex = 9
        Me.item_tax_box.TabStop = False
        Me.item_tax_box.Text = "0"
        '
        'Item_quantity_box
        '
        Me.Item_quantity_box.BackColor = System.Drawing.Color.White
        Me.Item_quantity_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Item_quantity_box.Cursor = System.Windows.Forms.Cursors.No
        Me.Item_quantity_box.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_quantity_box.ForeColor = System.Drawing.Color.Red
        Me.Item_quantity_box.Location = New System.Drawing.Point(153, 101)
        Me.Item_quantity_box.Name = "Item_quantity_box"
        Me.Item_quantity_box.ReadOnly = True
        Me.Item_quantity_box.Size = New System.Drawing.Size(87, 19)
        Me.Item_quantity_box.TabIndex = 9
        Me.Item_quantity_box.TabStop = False
        Me.Item_quantity_box.Text = "0"
        '
        'item_price_box
        '
        Me.item_price_box.BackColor = System.Drawing.Color.White
        Me.item_price_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.item_price_box.Cursor = System.Windows.Forms.Cursors.No
        Me.item_price_box.Font = New System.Drawing.Font("Bahnschrift SemiLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_price_box.ForeColor = System.Drawing.Color.Red
        Me.item_price_box.Location = New System.Drawing.Point(183, 135)
        Me.item_price_box.Name = "item_price_box"
        Me.item_price_box.ReadOnly = True
        Me.item_price_box.Size = New System.Drawing.Size(97, 26)
        Me.item_price_box.TabIndex = 9
        Me.item_price_box.TabStop = False
        Me.item_price_box.Text = "999999"
        '
        'item_name_box
        '
        Me.item_name_box.BackColor = System.Drawing.Color.White
        Me.item_name_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.item_name_box.Cursor = System.Windows.Forms.Cursors.No
        Me.item_name_box.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_name_box.ForeColor = System.Drawing.Color.Black
        Me.item_name_box.Location = New System.Drawing.Point(109, 30)
        Me.item_name_box.Name = "item_name_box"
        Me.item_name_box.ReadOnly = True
        Me.item_name_box.Size = New System.Drawing.Size(253, 19)
        Me.item_name_box.TabIndex = 9
        Me.item_name_box.TabStop = False
        Me.item_name_box.Text = "Unkown Product"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(4, 137)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 19)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Tax:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(4, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 19)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Available Quantity:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.add_Cart_btn)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.purchase_quantity_box)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 186)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(339, 77)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Add Item"
        '
        'add_Cart_btn
        '
        Me.add_Cart_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.add_Cart_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_Cart_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.add_Cart_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.add_Cart_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.add_Cart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add_Cart_btn.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_Cart_btn.ForeColor = System.Drawing.Color.White
        Me.add_Cart_btn.Image = Global.SSBS.My.Resources.Resources.Checkout_21px
        Me.add_Cart_btn.Location = New System.Drawing.Point(191, 24)
        Me.add_Cart_btn.Name = "add_Cart_btn"
        Me.add_Cart_btn.Size = New System.Drawing.Size(109, 32)
        Me.add_Cart_btn.TabIndex = 3
        Me.add_Cart_btn.TabStop = False
        Me.add_Cart_btn.Text = "Add Cart"
        Me.add_Cart_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.add_Cart_btn.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(20, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 19)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "QTY"
        '
        'purchase_quantity_box
        '
        Me.purchase_quantity_box.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_quantity_box.Location = New System.Drawing.Point(67, 27)
        Me.purchase_quantity_box.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.purchase_quantity_box.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.purchase_quantity_box.Name = "purchase_quantity_box"
        Me.purchase_quantity_box.Size = New System.Drawing.Size(76, 27)
        Me.purchase_quantity_box.TabIndex = 4
        Me.purchase_quantity_box.ThousandsSeparator = True
        Me.purchase_quantity_box.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(5, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 19)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Item Name:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(5, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 19)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "ItemCode:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(131, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 19)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Price:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'product_details_loader
        '
        Me.product_details_loader.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.product_details_loader.Location = New System.Drawing.Point(123, 302)
        Me.product_details_loader.Name = "product_details_loader"
        Me.product_details_loader.Size = New System.Drawing.Size(100, 50)
        Me.product_details_loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.product_details_loader.TabIndex = 8
        Me.product_details_loader.TabStop = False
        Me.product_details_loader.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.invoice_due_date)
        Me.GroupBox8.Controls.Add(Me.invoice_due_label)
        Me.GroupBox8.Controls.Add(Me.customer_label_tag)
        Me.GroupBox8.Controls.Add(Me.customer_name_box)
        Me.GroupBox8.Location = New System.Drawing.Point(14, 54)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1305, 57)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Customer Information"
        '
        'invoice_due_date
        '
        Me.invoice_due_date.CalendarFont = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_due_date.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.invoice_due_date.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_due_date.Location = New System.Drawing.Point(848, 19)
        Me.invoice_due_date.MinDate = New Date(2018, 6, 6, 0, 0, 0, 0)
        Me.invoice_due_date.Name = "invoice_due_date"
        Me.invoice_due_date.Size = New System.Drawing.Size(299, 27)
        Me.invoice_due_date.TabIndex = 1
        Me.invoice_due_date.TabStop = False
        Me.invoice_due_date.Value = New Date(2019, 10, 25, 1, 31, 37, 0)
        Me.invoice_due_date.Visible = False
        '
        'invoice_due_label
        '
        Me.invoice_due_label.AutoSize = True
        Me.invoice_due_label.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_due_label.ForeColor = System.Drawing.Color.Green
        Me.invoice_due_label.Location = New System.Drawing.Point(761, 25)
        Me.invoice_due_label.Name = "invoice_due_label"
        Me.invoice_due_label.Size = New System.Drawing.Size(74, 16)
        Me.invoice_due_label.TabIndex = 6
        Me.invoice_due_label.Text = "Invoice Due"
        Me.invoice_due_label.Visible = False
        '
        'customer_label_tag
        '
        Me.customer_label_tag.AutoSize = True
        Me.customer_label_tag.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_label_tag.ForeColor = System.Drawing.Color.Green
        Me.customer_label_tag.Location = New System.Drawing.Point(7, 25)
        Me.customer_label_tag.Name = "customer_label_tag"
        Me.customer_label_tag.Size = New System.Drawing.Size(101, 16)
        Me.customer_label_tag.TabIndex = 2
        Me.customer_label_tag.Text = "Customer Name"
        '
        'customer_name_box
        '
        Me.customer_name_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.customer_name_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.customer_name_box.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_name_box.FormattingEnabled = True
        Me.customer_name_box.Location = New System.Drawing.Point(115, 20)
        Me.customer_name_box.Name = "customer_name_box"
        Me.customer_name_box.Size = New System.Drawing.Size(261, 26)
        Me.customer_name_box.TabIndex = 0
        Me.customer_name_box.TabStop = False
        Me.customer_name_box.Text = "Customer 1"
        '
        'cart_api2
        '
        Me.cart_api2.BackColor = System.Drawing.Color.White
        Me.cart_api2.Controls.Add(Me.txtBarcode)
        Me.cart_api2.Controls.Add(Me.Button3)
        Me.cart_api2.Controls.Add(Me.Label1)
        Me.cart_api2.Controls.Add(Me.Label8)
        Me.cart_api2.Controls.Add(Me.search_combo_box)
        Me.cart_api2.Location = New System.Drawing.Point(14, 117)
        Me.cart_api2.Name = "cart_api2"
        Me.cart_api2.Size = New System.Drawing.Size(540, 98)
        Me.cart_api2.TabIndex = 3
        Me.cart_api2.TabStop = False
        Me.cart_api2.Text = "New Sale"
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(199, 42)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(253, 26)
        Me.txtBarcode.TabIndex = 13
        Me.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(458, 41)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 24)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "enter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(201, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Search Barcode"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(14, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Search Item"
        '
        'search_combo_box
        '
        Me.search_combo_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.search_combo_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.search_combo_box.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_combo_box.FormattingEnabled = True
        Me.search_combo_box.Location = New System.Drawing.Point(7, 42)
        Me.search_combo_box.Name = "search_combo_box"
        Me.search_combo_box.Size = New System.Drawing.Size(175, 26)
        Me.search_combo_box.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(58, 222)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(222, 77)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Search Medicine or Enter Bar Code to Start a Sale"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cart_api
        '
        Me.cart_api.Controls.Add(Me.Button2)
        Me.cart_api.Controls.Add(Me.Button5)
        Me.cart_api.Controls.Add(Me.Cart_items)
        Me.cart_api.Controls.Add(Me.GroupBox4)
        Me.cart_api.Controls.Add(Me.GroupBox3)
        Me.cart_api.Location = New System.Drawing.Point(577, 117)
        Me.cart_api.Name = "cart_api"
        Me.cart_api.Size = New System.Drawing.Size(742, 377)
        Me.cart_api.TabIndex = 2
        Me.cart_api.TabStop = False
        Me.cart_api.Text = "Shop Cart"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.SSBS.My.Resources.Resources.Delete_21px1
        Me.Button2.Location = New System.Drawing.Point(370, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 26)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Empty Cart Items"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.SSBS.My.Resources.Resources.remove_white1
        Me.Button5.Location = New System.Drawing.Point(205, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(126, 26)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Delete selected"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Cart_items
        '
        Me.Cart_items.AllowUserToAddRows = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cart_items.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Cart_items.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cart_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cart_items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Cart_items.ColumnHeadersHeight = 30
        Me.Cart_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Cart_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_code, Me.item_info, Me.Quantity, Me.Rate, Me.tax, Me.total})
        Me.Cart_items.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cart_items.DefaultCellStyle = DataGridViewCellStyle6
        Me.Cart_items.EnableHeadersVisualStyles = False
        Me.Cart_items.Location = New System.Drawing.Point(11, 42)
        Me.Cart_items.Name = "Cart_items"
        Me.Cart_items.ReadOnly = True
        Me.Cart_items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Cart_items.RowHeadersVisible = False
        Me.Cart_items.RowHeadersWidth = 27
        Me.Cart_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Cart_items.ShowEditingIcon = False
        Me.Cart_items.Size = New System.Drawing.Size(711, 203)
        Me.Cart_items.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Checkout_btn)
        Me.GroupBox4.Controls.Add(Me.PictureBox17)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.print_receipt_ask)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.paid_amount_box)
        Me.GroupBox4.Controls.Add(Me.change_box)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(302, 255)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(420, 111)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'Checkout_btn
        '
        Me.Checkout_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Checkout_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Checkout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Checkout_btn.FlatAppearance.BorderSize = 0
        Me.Checkout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.Checkout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.Checkout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Checkout_btn.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkout_btn.ForeColor = System.Drawing.Color.White
        Me.Checkout_btn.Image = Global.SSBS.My.Resources.Resources.Checkout_21px
        Me.Checkout_btn.Location = New System.Drawing.Point(279, 56)
        Me.Checkout_btn.Name = "Checkout_btn"
        Me.Checkout_btn.Size = New System.Drawing.Size(135, 42)
        Me.Checkout_btn.TabIndex = 9
        Me.Checkout_btn.Text = "Checkout"
        Me.Checkout_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Checkout_btn.UseVisualStyleBackColor = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox17.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.PictureBox17.Location = New System.Drawing.Point(372, 57)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox17.TabIndex = 59
        Me.PictureBox17.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label24.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label24.Location = New System.Drawing.Point(293, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 16)
        Me.Label24.TabIndex = 58
        Me.Label24.Text = "Checking out"
        '
        'print_receipt_ask
        '
        Me.print_receipt_ask.AutoSize = True
        Me.print_receipt_ask.Checked = True
        Me.print_receipt_ask.CheckState = System.Windows.Forms.CheckState.Checked
        Me.print_receipt_ask.Cursor = System.Windows.Forms.Cursors.Hand
        Me.print_receipt_ask.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.print_receipt_ask.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime
        Me.print_receipt_ask.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print_receipt_ask.Location = New System.Drawing.Point(310, 20)
        Me.print_receipt_ask.Name = "print_receipt_ask"
        Me.print_receipt_ask.Size = New System.Drawing.Size(94, 18)
        Me.print_receipt_ask.TabIndex = 57
        Me.print_receipt_ask.Text = "Print Receipt"
        Me.print_receipt_ask.UseVisualStyleBackColor = True
        Me.print_receipt_ask.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"CASH", "ECOCASH"})
        Me.ComboBox1.Location = New System.Drawing.Point(54, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(132, 26)
        Me.ComboBox1.TabIndex = 25
        Me.ComboBox1.Text = "CASH"
        '
        'paid_amount_box
        '
        Me.paid_amount_box.DecimalPlaces = 2
        Me.paid_amount_box.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paid_amount_box.Location = New System.Drawing.Point(58, 17)
        Me.paid_amount_box.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.paid_amount_box.Name = "paid_amount_box"
        Me.paid_amount_box.Size = New System.Drawing.Size(128, 30)
        Me.paid_amount_box.TabIndex = 8
        Me.paid_amount_box.ThousandsSeparator = True
        '
        'change_box
        '
        Me.change_box.AutoSize = True
        Me.change_box.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_box.ForeColor = System.Drawing.Color.Red
        Me.change_box.Location = New System.Drawing.Point(208, 59)
        Me.change_box.Name = "change_box"
        Me.change_box.Size = New System.Drawing.Size(42, 23)
        Me.change_box.TabIndex = 56
        Me.change_box.Text = "0.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(201, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 23)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Change"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(7, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 23)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Via"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(5, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 23)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Paid"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.total_tax_box)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.discount_box)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.total_sum_box)
        Me.GroupBox3.Controls.Add(Me.currency1)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 255)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(285, 111)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'total_tax_box
        '
        Me.total_tax_box.BackColor = System.Drawing.Color.White
        Me.total_tax_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.total_tax_box.Cursor = System.Windows.Forms.Cursors.No
        Me.total_tax_box.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_tax_box.ForeColor = System.Drawing.Color.Red
        Me.total_tax_box.Location = New System.Drawing.Point(131, 84)
        Me.total_tax_box.Name = "total_tax_box"
        Me.total_tax_box.ReadOnly = True
        Me.total_tax_box.Size = New System.Drawing.Size(49, 15)
        Me.total_tax_box.TabIndex = 99
        Me.total_tax_box.TabStop = False
        Me.total_tax_box.Text = "0.00"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(69, 85)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 14)
        Me.Label23.TabIndex = 56
        Me.Label23.Text = "Total Tax"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(42, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 23)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Total"
        '
        'discount_box
        '
        Me.discount_box.DecimalPlaces = 2
        Me.discount_box.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_box.Location = New System.Drawing.Point(152, 48)
        Me.discount_box.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.discount_box.Name = "discount_box"
        Me.discount_box.Size = New System.Drawing.Size(114, 27)
        Me.discount_box.TabIndex = 7
        Me.discount_box.ThousandsSeparator = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(168, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 23)
        Me.Label16.TabIndex = 98
        Me.Label16.Text = "Discount"
        '
        'total_sum_box
        '
        Me.total_sum_box.BackColor = System.Drawing.Color.White
        Me.total_sum_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.total_sum_box.Cursor = System.Windows.Forms.Cursors.No
        Me.total_sum_box.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_sum_box.ForeColor = System.Drawing.Color.Red
        Me.total_sum_box.Location = New System.Drawing.Point(4, 49)
        Me.total_sum_box.Name = "total_sum_box"
        Me.total_sum_box.ReadOnly = True
        Me.total_sum_box.Size = New System.Drawing.Size(130, 23)
        Me.total_sum_box.TabIndex = 67
        Me.total_sum_box.TabStop = False
        Me.total_sum_box.Text = "0.00"
        Me.total_sum_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'currency1
        '
        Me.currency1.AutoSize = True
        Me.currency1.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currency1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.currency1.Location = New System.Drawing.Point(95, 20)
        Me.currency1.Name = "currency1"
        Me.currency1.Size = New System.Drawing.Size(18, 19)
        Me.currency1.TabIndex = 6
        Me.currency1.Text = "$"
        Me.currency1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lblUser)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1344, 48)
        Me.Panel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(1034, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Logged on user"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.DimGray
        Me.lblUser.Location = New System.Drawing.Point(1160, 14)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(74, 20)
        Me.lblUser.TabIndex = 21
        Me.lblUser.Text = ": Telthem"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SSBS.My.Resources.Resources.Bookmark_Ribbon_21px
        Me.PictureBox2.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'item_code
        '
        Me.item_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.item_code.HeaderText = "Item Code"
        Me.item_code.Name = "item_code"
        Me.item_code.ReadOnly = True
        Me.item_code.Width = 92
        '
        'item_info
        '
        Me.item_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.item_info.HeaderText = "Item Information"
        Me.item_info.MinimumWidth = 155
        Me.item_info.Name = "item_info"
        Me.item_info.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 80
        '
        'Rate
        '
        Me.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        Me.Rate.Width = 58
        '
        'tax
        '
        Me.tax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tax.HeaderText = "Tax"
        Me.tax.Name = "tax"
        Me.tax.ReadOnly = True
        Me.tax.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tax.Width = 51
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 60
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1352, 749)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.search_results.ResumeLayout(False)
        Me.search_results.PerformLayout()
        CType(Me.medicine_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.purchase_quantity_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.product_details_loader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.cart_api2.ResumeLayout(False)
        Me.cart_api2.PerformLayout()
        Me.cart_api.ResumeLayout(False)
        CType(Me.Cart_items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paid_amount_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.discount_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents invoice_type_nav As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents search_results As GroupBox
    Friend WithEvents item_code_box As TextBox
    Friend WithEvents medicine_image As PictureBox
    Friend WithEvents item_tax_box As TextBox
    Friend WithEvents Item_quantity_box As TextBox
    Friend WithEvents item_price_box As TextBox
    Friend WithEvents item_name_box As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents add_Cart_btn As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents purchase_quantity_box As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents product_details_loader As PictureBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents invoice_due_date As DateTimePicker
    Friend WithEvents invoice_due_label As Label
    Friend WithEvents customer_label_tag As Label
    Friend WithEvents customer_name_box As ComboBox
    Friend WithEvents cart_api2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents search_combo_box As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cart_api As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Cart_items As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Checkout_btn As Button
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents print_receipt_ask As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents paid_amount_box As NumericUpDown
    Friend WithEvents change_box As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents total_tax_box As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents discount_box As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents total_sum_box As TextBox
    Friend WithEvents currency1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents item_code As DataGridViewTextBoxColumn
    Friend WithEvents item_info As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents tax As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
