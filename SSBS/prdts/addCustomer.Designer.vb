<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addCustomer
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCust = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtAddres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridMembers = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCustomer = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAdCust = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridMembers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(985, 4)
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
        Me.Label10.Size = New System.Drawing.Size(119, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Manage Customers"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label11.Location = New System.Drawing.Point(34, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Home / Customers/"
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
        Me.Label7.Size = New System.Drawing.Size(115, 25)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Customers"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SSBS.My.Resources.Resources.Add_User_Male_40px
        Me.PictureBox5.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(57, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 72
        Me.PictureBox5.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCust)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtFname)
        Me.GroupBox1.Controls.Add(Me.txtAddres)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 187)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'lblCust
        '
        Me.lblCust.AutoSize = True
        Me.lblCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCust.Location = New System.Drawing.Point(501, 157)
        Me.lblCust.Name = "lblCust"
        Me.lblCust.Size = New System.Drawing.Size(19, 20)
        Me.lblCust.TabIndex = 42
        Me.lblCust.Text = "1"
        Me.lblCust.Visible = False
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
        Me.txtFname.Size = New System.Drawing.Size(492, 26)
        Me.txtFname.TabIndex = 29
        Me.txtFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAddres
        '
        Me.txtAddres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddres.Location = New System.Drawing.Point(164, 61)
        Me.txtAddres.Name = "txtAddres"
        Me.txtAddres.Size = New System.Drawing.Size(494, 26)
        Me.txtAddres.TabIndex = 35
        Me.txtAddres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Customer Name"
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
        Me.txtPhone.Size = New System.Drawing.Size(494, 26)
        Me.txtPhone.TabIndex = 31
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(164, 93)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(494, 26)
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
        'DataGridMembers
        '
        Me.DataGridMembers.AllowUserToAddRows = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridMembers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridMembers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridMembers.ColumnHeadersHeight = 24
        Me.DataGridMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridMembers.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridMembers.Location = New System.Drawing.Point(35, 268)
        Me.DataGridMembers.Name = "DataGridMembers"
        Me.DataGridMembers.ReadOnly = True
        Me.DataGridMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridMembers.RowHeadersVisible = False
        Me.DataGridMembers.RowHeadersWidth = 25
        Me.DataGridMembers.Size = New System.Drawing.Size(1230, 381)
        Me.DataGridMembers.TabIndex = 54
        '
        'Column1
        '
        Me.Column1.HeaderText = "SRN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "CUSTOMER NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 195
        '
        'Column3
        '
        Me.Column3.HeaderText = "ADDRESS"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'Column4
        '
        Me.Column4.HeaderText = "PHONE NUMBER"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 344
        '
        'Column5
        '
        Me.Column5.HeaderText = "EMAIL ADDRESS"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 338
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(811, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 20)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Filter Customer by Name"
        '
        'cbCustomer
        '
        Me.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCustomer.FormattingEnabled = True
        Me.cbCustomer.Location = New System.Drawing.Point(768, 198)
        Me.cbCustomer.Name = "cbCustomer"
        Me.cbCustomer.Size = New System.Drawing.Size(233, 32)
        Me.cbCustomer.TabIndex = 95
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SSBS.My.Resources.Resources.add
        Me.PictureBox1.Location = New System.Drawing.Point(1051, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 100
        Me.PictureBox1.TabStop = False
        '
        'btnAdCust
        '
        Me.btnAdCust.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdCust.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnAdCust.FlatAppearance.BorderSize = 0
        Me.btnAdCust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdCust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdCust.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdCust.ForeColor = System.Drawing.Color.White
        Me.btnAdCust.Image = Global.SSBS.My.Resources.Resources.save_As
        Me.btnAdCust.Location = New System.Drawing.Point(768, 79)
        Me.btnAdCust.Name = "btnAdCust"
        Me.btnAdCust.Size = New System.Drawing.Size(154, 32)
        Me.btnAdCust.TabIndex = 98
        Me.btnAdCust.Text = "Add Customer"
        Me.btnAdCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdCust.UseVisualStyleBackColor = False
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
        Me.btnDelete.Location = New System.Drawing.Point(768, 117)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(154, 32)
        Me.btnDelete.TabIndex = 97
        Me.btnDelete.Text = "Clear Record"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.SSBS.My.Resources.Resources.funnel
        Me.PictureBox10.Location = New System.Drawing.Point(782, 171)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(37, 20)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 99
        Me.PictureBox10.TabStop = False
        '
        'addCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 788)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAdCust)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCustomer)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.DataGridMembers)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addCustomer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridMembers, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblCust As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtAddres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridMembers As DataGridView
    Friend WithEvents btnAdCust As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCustomer As ComboBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
