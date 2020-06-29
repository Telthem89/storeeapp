<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeApp
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
        Me.invoice_type_header2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnLogoutSales = New System.Windows.Forms.Button()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'invoice_type_header2
        '
        Me.invoice_type_header2.AutoSize = True
        Me.invoice_type_header2.BackColor = System.Drawing.Color.Transparent
        Me.invoice_type_header2.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_type_header2.ForeColor = System.Drawing.Color.White
        Me.invoice_type_header2.Location = New System.Drawing.Point(360, 44)
        Me.invoice_type_header2.Name = "invoice_type_header2"
        Me.invoice_type_header2.Size = New System.Drawing.Size(225, 42)
        Me.invoice_type_header2.TabIndex = 13
        Me.invoice_type_header2.Text = "Point of Sale"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.SSBS.My.Resources.Resources.Cash_Register_40px
        Me.PictureBox5.Location = New System.Drawing.Point(286, 37)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(73, 49)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'btnLogoutSales
        '
        Me.btnLogoutSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogoutSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogoutSales.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnLogoutSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnLogoutSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnLogoutSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogoutSales.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogoutSales.ForeColor = System.Drawing.Color.White
        Me.btnLogoutSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogoutSales.Location = New System.Drawing.Point(297, 207)
        Me.btnLogoutSales.Name = "btnLogoutSales"
        Me.btnLogoutSales.Size = New System.Drawing.Size(221, 57)
        Me.btnLogoutSales.TabIndex = 11
        Me.btnLogoutSales.TabStop = False
        Me.btnLogoutSales.Text = "Open Store now"
        Me.btnLogoutSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogoutSales.UseVisualStyleBackColor = False
        '
        'WelcomeApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SSBS.My.Resources.Resources.shopping_cart_4264939_1920
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.invoice_type_header2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnLogoutSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WelcomeApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WelcomeApp"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents invoice_type_header2 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnLogoutSales As Button
End Class
