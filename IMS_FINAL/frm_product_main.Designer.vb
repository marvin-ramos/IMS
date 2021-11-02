<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_main
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.btn_edit_product = New System.Windows.Forms.Button()
        Me.btn_view_staff = New System.Windows.Forms.Button()
        Me.btn_edit_staff = New System.Windows.Forms.Button()
        Me.btn_product_category = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_search_product = New System.Windows.Forms.TextBox()
        Me.btn_search_product = New System.Windows.Forms.Button()
        Me.btn_load_product = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_products = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1073, 455)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_product_id)
        Me.GroupBox5.Controls.Add(Me.btn_edit_product)
        Me.GroupBox5.Controls.Add(Me.btn_view_staff)
        Me.GroupBox5.Controls.Add(Me.btn_edit_staff)
        Me.GroupBox5.Controls.Add(Me.btn_product_category)
        Me.GroupBox5.Controls.Add(Me.btn_back)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(210, 436)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'txt_product_id
        '
        Me.txt_product_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_product_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_id.Location = New System.Drawing.Point(6, 138)
        Me.txt_product_id.Multiline = True
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.Size = New System.Drawing.Size(10, 29)
        Me.txt_product_id.TabIndex = 7
        Me.txt_product_id.Visible = False
        '
        'btn_edit_product
        '
        Me.btn_edit_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_product.Location = New System.Drawing.Point(6, 284)
        Me.btn_edit_product.Name = "btn_edit_product"
        Me.btn_edit_product.Size = New System.Drawing.Size(198, 29)
        Me.btn_edit_product.TabIndex = 6
        Me.btn_edit_product.Text = "EDIT PRODUCT"
        Me.btn_edit_product.UseVisualStyleBackColor = True
        '
        'btn_view_staff
        '
        Me.btn_view_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_staff.Location = New System.Drawing.Point(6, 327)
        Me.btn_view_staff.Name = "btn_view_staff"
        Me.btn_view_staff.Size = New System.Drawing.Size(198, 29)
        Me.btn_view_staff.TabIndex = 5
        Me.btn_view_staff.Text = "DELETE STAFF"
        Me.btn_view_staff.UseVisualStyleBackColor = True
        '
        'btn_edit_staff
        '
        Me.btn_edit_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_staff.Location = New System.Drawing.Point(6, 249)
        Me.btn_edit_staff.Name = "btn_edit_staff"
        Me.btn_edit_staff.Size = New System.Drawing.Size(198, 29)
        Me.btn_edit_staff.TabIndex = 4
        Me.btn_edit_staff.Text = "ADD PRODUCT"
        Me.btn_edit_staff.UseVisualStyleBackColor = True
        '
        'btn_product_category
        '
        Me.btn_product_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_product_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product_category.Location = New System.Drawing.Point(6, 214)
        Me.btn_product_category.Name = "btn_product_category"
        Me.btn_product_category.Size = New System.Drawing.Size(198, 29)
        Me.btn_product_category.TabIndex = 3
        Me.btn_product_category.Text = "PRODUCT CATEGORY"
        Me.btn_product_category.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(6, 392)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(198, 29)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_search_product)
        Me.GroupBox4.Controls.Add(Me.btn_search_product)
        Me.GroupBox4.Controls.Add(Me.btn_load_product)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(225, 389)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(841, 50)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'txt_search_product
        '
        Me.txt_search_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_product.Location = New System.Drawing.Point(6, 12)
        Me.txt_search_product.Multiline = True
        Me.txt_search_product.Name = "txt_search_product"
        Me.txt_search_product.Size = New System.Drawing.Size(265, 29)
        Me.txt_search_product.TabIndex = 6
        '
        'btn_search_product
        '
        Me.btn_search_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_product.Location = New System.Drawing.Point(277, 12)
        Me.btn_search_product.Name = "btn_search_product"
        Me.btn_search_product.Size = New System.Drawing.Size(135, 29)
        Me.btn_search_product.TabIndex = 2
        Me.btn_search_product.Text = "SEARCH PRODUCT"
        Me.btn_search_product.UseVisualStyleBackColor = True
        '
        'btn_load_product
        '
        Me.btn_load_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_product.Location = New System.Drawing.Point(418, 12)
        Me.btn_load_product.Name = "btn_load_product"
        Me.btn_load_product.Size = New System.Drawing.Size(149, 29)
        Me.btn_load_product.TabIndex = 1
        Me.btn_load_product.Text = "REFRESH PRODUCT"
        Me.btn_load_product.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_products)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(224, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(841, 324)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'dgv_products
        '
        Me.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_products.Location = New System.Drawing.Point(6, 11)
        Me.dgv_products.Name = "dgv_products"
        Me.dgv_products.Size = New System.Drawing.Size(829, 307)
        Me.dgv_products.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(223, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(841, 52)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'frm_product_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1090, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_product_main"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_view_staff As System.Windows.Forms.Button
    Friend WithEvents btn_edit_staff As System.Windows.Forms.Button
    Friend WithEvents btn_product_category As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_search_product As System.Windows.Forms.TextBox
    Friend WithEvents btn_search_product As System.Windows.Forms.Button
    Friend WithEvents btn_load_product As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_products As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_edit_product As System.Windows.Forms.Button
    Friend WithEvents txt_product_id As System.Windows.Forms.TextBox
End Class
