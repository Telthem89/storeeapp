<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblcatid = New System.Windows.Forms.Label()
        Me.txtDiscription = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataCategory = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnAdCat = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 58)
        Me.Panel1.TabIndex = 76
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(482, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(298, 44)
        Me.GroupBox4.TabIndex = 83
        Me.GroupBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(148, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Manage Category"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label11.Location = New System.Drawing.Point(34, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Home / Categories/"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(56, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Manage Invoices here"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(52, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 25)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "All Category"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdCat)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.lblcatid)
        Me.GroupBox1.Controls.Add(Me.txtDiscription)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 166)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        '
        'lblcatid
        '
        Me.lblcatid.AutoSize = True
        Me.lblcatid.Location = New System.Drawing.Point(59, 113)
        Me.lblcatid.Name = "lblcatid"
        Me.lblcatid.Size = New System.Drawing.Size(39, 13)
        Me.lblcatid.TabIndex = 88
        Me.lblcatid.Text = "Label4"
        Me.lblcatid.Visible = False
        '
        'txtDiscription
        '
        Me.txtDiscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscription.Location = New System.Drawing.Point(178, 65)
        Me.txtDiscription.Name = "txtDiscription"
        Me.txtDiscription.Size = New System.Drawing.Size(298, 48)
        Me.txtDiscription.TabIndex = 85
        Me.txtDiscription.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(10, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 25)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Category Descr"
        '
        'txtDName
        '
        Me.txtDName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDName.Location = New System.Drawing.Point(178, 27)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.Size = New System.Drawing.Size(298, 32)
        Me.txtDName.TabIndex = 86
        Me.txtDName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(10, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Category Name"
        '
        'DataCategory
        '
        Me.DataCategory.AllowUserToAddRows = False
        Me.DataCategory.BackgroundColor = System.Drawing.Color.White
        Me.DataCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataCategory.Location = New System.Drawing.Point(11, 265)
        Me.DataCategory.Name = "DataCategory"
        Me.DataCategory.RowHeadersVisible = False
        Me.DataCategory.Size = New System.Drawing.Size(773, 270)
        Me.DataCategory.TabIndex = 85
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SSBS.My.Resources.Resources.open_folder16001
        Me.PictureBox3.Location = New System.Drawing.Point(538, 69)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(242, 177)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'btnAdCat
        '
        Me.btnAdCat.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdCat.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnAdCat.FlatAppearance.BorderSize = 0
        Me.btnAdCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdCat.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdCat.ForeColor = System.Drawing.Color.White
        Me.btnAdCat.Image = Global.SSBS.My.Resources.Resources.save_As
        Me.btnAdCat.Location = New System.Drawing.Point(178, 119)
        Me.btnAdCat.Name = "btnAdCat"
        Me.btnAdCat.Size = New System.Drawing.Size(154, 32)
        Me.btnAdCat.TabIndex = 90
        Me.btnAdCat.Text = "Add Category"
        Me.btnAdCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdCat.UseVisualStyleBackColor = False
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
        Me.btnDelete.Location = New System.Drawing.Point(338, 119)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 32)
        Me.btnDelete.TabIndex = 89
        Me.btnDelete.Text = "Clear"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
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
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SSBS.My.Resources.Resources.folder_19
        Me.PictureBox5.Location = New System.Drawing.Point(13, 14)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(41, 31)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 80
        Me.PictureBox5.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "SRN"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 190
        '
        'Column2
        '
        Me.Column2.HeaderText = "CATEGORY NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 249
        '
        'Column3
        '
        Me.Column3.HeaderText = "DESCRIPTION"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 330
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 573)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.DataCategory)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiscription As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcatid As Label
    Friend WithEvents btnAdCat As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataCategory As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
