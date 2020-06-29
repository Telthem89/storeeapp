<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Cart_itemInvoices = New System.Windows.Forms.DataGridView()
        Me.item_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_info = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cart_itemInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1304, 56)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(1057, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(223, 44)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(135, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Invoices"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label11.Location = New System.Drawing.Point(34, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Home / Invoices/"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SSBS.My.Resources.Resources.Home_21px
        Me.PictureBox2.Location = New System.Drawing.Point(13, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(71, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Manage Invoices here"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(71, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 25)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Invoices"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SSBS.My.Resources.Resources.income
        Me.PictureBox5.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(57, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 72
        Me.PictureBox5.TabStop = False
        '
        'Cart_itemInvoices
        '
        Me.Cart_itemInvoices.AllowUserToAddRows = False
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cart_itemInvoices.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Cart_itemInvoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cart_itemInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cart_itemInvoices.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Cart_itemInvoices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_code, Me.item_info, Me.Column1, Me.Column2, Me.tax, Me.Column3, Me.Rate, Me.Quantity, Me.Column4, Me.Column5})
        Me.Cart_itemInvoices.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cart_itemInvoices.DefaultCellStyle = DataGridViewCellStyle12
        Me.Cart_itemInvoices.Location = New System.Drawing.Point(1, 353)
        Me.Cart_itemInvoices.Name = "Cart_itemInvoices"
        Me.Cart_itemInvoices.ReadOnly = True
        Me.Cart_itemInvoices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Cart_itemInvoices.RowHeadersVisible = False
        Me.Cart_itemInvoices.RowHeadersWidth = 27
        Me.Cart_itemInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Cart_itemInvoices.ShowEditingIcon = False
        Me.Cart_itemInvoices.Size = New System.Drawing.Size(1280, 335)
        Me.Cart_itemInvoices.TabIndex = 12
        '
        'item_code
        '
        Me.item_code.HeaderText = "Receipt Number"
        Me.item_code.Name = "item_code"
        Me.item_code.ReadOnly = True
        '
        'item_info
        '
        Me.item_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.item_info.HeaderText = "Invoice Type"
        Me.item_info.MinimumWidth = 155
        Me.item_info.Name = "item_info"
        Me.item_info.ReadOnly = True
        Me.item_info.Width = 155
        '
        'Column1
        '
        Me.Column1.HeaderText = "Total Price"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 140
        '
        'Column2
        '
        Me.Column2.HeaderText = "Discount"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'tax
        '
        Me.tax.HeaderText = "Tax"
        Me.tax.Name = "tax"
        Me.tax.ReadOnly = True
        Me.tax.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column3
        '
        Me.Column3.HeaderText = "Paid Amount"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Rate
        '
        Me.Rate.HeaderText = "Change Amount"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Customer Name"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 143
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cashier"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 142
        '
        'Column5
        '
        Me.Column5.HeaderText = "Invoice Date"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 145
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SSBS.My.Resources.Resources.income
        Me.PictureBox1.Location = New System.Drawing.Point(34, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(338, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 217)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(277, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Total Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiLight", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(441, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 37)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = ":  $23 676 989"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiLight", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(529, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 37)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "23 233"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(277, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "StockIn"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiLight", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(529, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 37)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "23 233"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(277, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 25)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "StockOut"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiLight", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(441, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(201, 37)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = ":  $103 676 989"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift SemiLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(277, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 25)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Total Revenues"
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 788)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cart_itemInvoices)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cart_itemInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Cart_itemInvoices As DataGridView
    Friend WithEvents item_code As DataGridViewTextBoxColumn
    Friend WithEvents item_info As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents tax As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
