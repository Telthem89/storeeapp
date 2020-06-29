<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSupplier
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSupp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtAddres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCity = New System.Windows.Forms.ComboBox()
        Me.supGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAdSup = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.supGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(982, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(298, 44)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(148, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Manage Suppliers"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label11.Location = New System.Drawing.Point(34, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Home / Suppliers/"
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
        Me.Label7.Size = New System.Drawing.Size(101, 25)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Suppliers"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SSBS.My.Resources.Resources.Shipped_65px
        Me.PictureBox5.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(57, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 72
        Me.PictureBox5.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSupp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtFname)
        Me.GroupBox1.Controls.Add(Me.txtAddres)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 187)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lblSupp
        '
        Me.lblSupp.AutoSize = True
        Me.lblSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupp.Location = New System.Drawing.Point(501, 157)
        Me.lblSupp.Name = "lblSupp"
        Me.lblSupp.Size = New System.Drawing.Size(19, 20)
        Me.lblSupp.TabIndex = 42
        Me.lblSupp.Text = "1"
        Me.lblSupp.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 20)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Physical Address"
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(164, 29)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(382, 26)
        Me.txtFname.TabIndex = 29
        Me.txtFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAddres
        '
        Me.txtAddres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddres.Location = New System.Drawing.Point(164, 61)
        Me.txtAddres.Name = "txtAddres"
        Me.txtAddres.Size = New System.Drawing.Size(384, 26)
        Me.txtAddres.TabIndex = 35
        Me.txtAddres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Supplier Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "E-mail Address"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(164, 128)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(384, 26)
        Me.txtPhone.TabIndex = 31
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(164, 93)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(384, 26)
        Me.txtEmail.TabIndex = 33
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(647, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Filter Supplier by Name"
        '
        'cbCity
        '
        Me.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCity.FormattingEnabled = True
        Me.cbCity.Location = New System.Drawing.Point(604, 193)
        Me.cbCity.Name = "cbCity"
        Me.cbCity.Size = New System.Drawing.Size(233, 32)
        Me.cbCity.TabIndex = 39
        '
        'supGrid
        '
        Me.supGrid.AllowUserToAddRows = False
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.supGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.supGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.supGrid.ColumnHeadersHeight = 24
        Me.supGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.supGrid.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.supGrid.Location = New System.Drawing.Point(12, 277)
        Me.supGrid.Name = "supGrid"
        Me.supGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.supGrid.RowHeadersVisible = False
        Me.supGrid.RowHeadersWidth = 25
        Me.supGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.supGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.supGrid.ShowEditingIcon = False
        Me.supGrid.Size = New System.Drawing.Size(1261, 393)
        Me.supGrid.TabIndex = 95
        '
        'Column1
        '
        Me.Column1.HeaderText = "SRN"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "SUPPLIER NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 234
        '
        'Column3
        '
        Me.Column3.HeaderText = "ADDRESS"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 234
        '
        'Column4
        '
        Me.Column4.HeaderText = "EMAIL ADDRESS"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 289
        '
        'Column5
        '
        Me.Column5.HeaderText = "PHONE NUMBER"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "REGISTERED DATE"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 250
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.SSBS.My.Resources.Resources.login_rounded
        Me.Button1.Location = New System.Drawing.Point(843, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 32)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "Search"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAdSup
        '
        Me.btnAdSup.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdSup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdSup.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnAdSup.FlatAppearance.BorderSize = 0
        Me.btnAdSup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdSup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdSup.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdSup.ForeColor = System.Drawing.Color.White
        Me.btnAdSup.Image = Global.SSBS.My.Resources.Resources.save_As
        Me.btnAdSup.Location = New System.Drawing.Point(604, 74)
        Me.btnAdSup.Name = "btnAdSup"
        Me.btnAdSup.Size = New System.Drawing.Size(154, 32)
        Me.btnAdSup.TabIndex = 92
        Me.btnAdSup.Text = "Add Supplier"
        Me.btnAdSup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdSup.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.SSBS.My.Resources.Resources.Delete_21px2
        Me.btnDelete.Location = New System.Drawing.Point(604, 112)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(154, 32)
        Me.btnDelete.TabIndex = 91
        Me.btnDelete.Text = "Clear Record"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SSBS.My.Resources.Resources.Shipped_65px
        Me.PictureBox1.Location = New System.Drawing.Point(983, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.SSBS.My.Resources.Resources.funnel
        Me.PictureBox10.Location = New System.Drawing.Point(618, 166)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(37, 20)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 94
        Me.PictureBox10.TabStop = False
        '
        'addSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 788)
        Me.Controls.Add(Me.supGrid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdSup)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCity)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addSupplier"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.supGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtAddres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCity As ComboBox
    Friend WithEvents lblSupp As Label
    Friend WithEvents btnAdSup As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents supGrid As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
