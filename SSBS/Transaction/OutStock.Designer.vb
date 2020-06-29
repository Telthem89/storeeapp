<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutStock
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.invoice_type_dsc = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Cart_itemoutstock = New System.Windows.Forms.DataGridView()
        Me.item_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_info = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockLevel = New System.Windows.Forms.GroupBox()
        Me.lblStockLvl = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cart_itemoutstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stockLevel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.invoice_type_dsc)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1304, 56)
        Me.Panel1.TabIndex = 4
        '
        'invoice_type_dsc
        '
        Me.invoice_type_dsc.AutoSize = True
        Me.invoice_type_dsc.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_type_dsc.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.invoice_type_dsc.Location = New System.Drawing.Point(73, 30)
        Me.invoice_type_dsc.Name = "invoice_type_dsc"
        Me.invoice_type_dsc.Size = New System.Drawing.Size(127, 16)
        Me.invoice_type_dsc.TabIndex = 76
        Me.invoice_type_dsc.Text = "View product in stock"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(1076, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 44)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(137, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Stock"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label11.Location = New System.Drawing.Point(34, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Home / Out Stock/"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(71, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 25)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Out Stock"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SSBS.My.Resources.Resources.Move_by_Trolley_40px
        Me.PictureBox5.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(57, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 72
        Me.PictureBox5.TabStop = False
        '
        'Cart_itemoutstock
        '
        Me.Cart_itemoutstock.AllowUserToAddRows = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cart_itemoutstock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Cart_itemoutstock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cart_itemoutstock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cart_itemoutstock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Cart_itemoutstock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_code, Me.item_info, Me.Column1, Me.Column2, Me.Column3, Me.Rate, Me.Quantity, Me.Column4, Me.tax, Me.Column5})
        Me.Cart_itemoutstock.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cart_itemoutstock.DefaultCellStyle = DataGridViewCellStyle6
        Me.Cart_itemoutstock.Location = New System.Drawing.Point(6, 237)
        Me.Cart_itemoutstock.Name = "Cart_itemoutstock"
        Me.Cart_itemoutstock.ReadOnly = True
        Me.Cart_itemoutstock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Cart_itemoutstock.RowHeadersVisible = False
        Me.Cart_itemoutstock.RowHeadersWidth = 27
        Me.Cart_itemoutstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Cart_itemoutstock.ShowEditingIcon = False
        Me.Cart_itemoutstock.Size = New System.Drawing.Size(1276, 421)
        Me.Cart_itemoutstock.TabIndex = 12
        '
        'item_code
        '
        Me.item_code.HeaderText = "Item Code"
        Me.item_code.Name = "item_code"
        Me.item_code.ReadOnly = True
        '
        'item_info
        '
        Me.item_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.item_info.HeaderText = "Item Information"
        Me.item_info.MinimumWidth = 155
        Me.item_info.Name = "item_info"
        Me.item_info.ReadOnly = True
        Me.item_info.Width = 155
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Suppler"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 190
        '
        'Column2
        '
        Me.Column2.HeaderText = "Iterm Category"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 123
        '
        'Column3
        '
        Me.Column3.HeaderText = "Expiry Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 130
        '
        'Rate
        '
        Me.Rate.HeaderText = "Price"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 103
        '
        'Column4
        '
        Me.Column4.HeaderText = "supplier price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'tax
        '
        Me.tax.HeaderText = "Tax"
        Me.tax.Name = "tax"
        Me.tax.ReadOnly = True
        Me.tax.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date Purchased"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 170
        '
        'stockLevel
        '
        Me.stockLevel.Controls.Add(Me.lblStockLvl)
        Me.stockLevel.Controls.Add(Me.Button3)
        Me.stockLevel.Controls.Add(Me.Label4)
        Me.stockLevel.Location = New System.Drawing.Point(223, 75)
        Me.stockLevel.Name = "stockLevel"
        Me.stockLevel.Size = New System.Drawing.Size(734, 137)
        Me.stockLevel.TabIndex = 13
        Me.stockLevel.TabStop = False
        '
        'lblStockLvl
        '
        Me.lblStockLvl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStockLvl.AutoSize = True
        Me.lblStockLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockLvl.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStockLvl.Location = New System.Drawing.Point(371, 40)
        Me.lblStockLvl.Name = "lblStockLvl"
        Me.lblStockLvl.Size = New System.Drawing.Size(38, 25)
        Me.lblStockLvl.TabIndex = 14
        Me.lblStockLvl.Text = "10"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(327, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 38)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Order  Now"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Olive
        Me.Label4.Location = New System.Drawing.Point(220, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(329, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "The following Items are running low on stock "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SSBS.My.Resources.Resources.Move_by_Trolley_40px
        Me.PictureBox1.Location = New System.Drawing.Point(1089, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'OutStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 788)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.stockLevel)
        Me.Controls.Add(Me.Cart_itemoutstock)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OutStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OutStock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cart_itemoutstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stockLevel.ResumeLayout(False)
        Me.stockLevel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Cart_itemoutstock As DataGridView
    Friend WithEvents invoice_type_dsc As Label
    Friend WithEvents stockLevel As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblStockLvl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents item_code As DataGridViewTextBoxColumn
    Friend WithEvents item_info As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents tax As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
