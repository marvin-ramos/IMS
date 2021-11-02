<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_category
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_category_description = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_category_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_delete_product = New System.Windows.Forms.Button()
        Me.btn_edit_staff = New System.Windows.Forms.Button()
        Me.btn_add_category = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_category_search = New System.Windows.Forms.TextBox()
        Me.btn_search_staff = New System.Windows.Forms.Button()
        Me.btn_load_staff = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_category = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_category_id = New System.Windows.Forms.TextBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1073, 455)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_category_description)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txt_category_name)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.Location = New System.Drawing.Point(784, 61)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(280, 324)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'txt_category_description
        '
        Me.txt_category_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_category_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_category_description.Location = New System.Drawing.Point(6, 101)
        Me.txt_category_description.Multiline = True
        Me.txt_category_description.Name = "txt_category_description"
        Me.txt_category_description.Size = New System.Drawing.Size(267, 217)
        Me.txt_category_description.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CATEGORY DESCRIPTION :"
        '
        'txt_category_name
        '
        Me.txt_category_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_category_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_category_name.Location = New System.Drawing.Point(6, 39)
        Me.txt_category_name.Multiline = True
        Me.txt_category_name.Name = "txt_category_name"
        Me.txt_category_name.Size = New System.Drawing.Size(267, 28)
        Me.txt_category_name.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CATEGORY NAME :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_delete_product)
        Me.GroupBox5.Controls.Add(Me.btn_edit_staff)
        Me.GroupBox5.Controls.Add(Me.btn_add_category)
        Me.GroupBox5.Controls.Add(Me.btn_back)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(210, 436)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'btn_delete_product
        '
        Me.btn_delete_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_product.Location = New System.Drawing.Point(6, 284)
        Me.btn_delete_product.Name = "btn_delete_product"
        Me.btn_delete_product.Size = New System.Drawing.Size(198, 29)
        Me.btn_delete_product.TabIndex = 5
        Me.btn_delete_product.Text = "DELETE CATEGORY"
        Me.btn_delete_product.UseVisualStyleBackColor = True
        '
        'btn_edit_staff
        '
        Me.btn_edit_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_staff.Location = New System.Drawing.Point(6, 249)
        Me.btn_edit_staff.Name = "btn_edit_staff"
        Me.btn_edit_staff.Size = New System.Drawing.Size(198, 29)
        Me.btn_edit_staff.TabIndex = 4
        Me.btn_edit_staff.Text = "EDIT CATEGORY"
        Me.btn_edit_staff.UseVisualStyleBackColor = True
        '
        'btn_add_category
        '
        Me.btn_add_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_category.Location = New System.Drawing.Point(6, 214)
        Me.btn_add_category.Name = "btn_add_category"
        Me.btn_add_category.Size = New System.Drawing.Size(198, 29)
        Me.btn_add_category.TabIndex = 3
        Me.btn_add_category.Text = "ADD CATEGORY"
        Me.btn_add_category.UseVisualStyleBackColor = True
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
        Me.GroupBox4.Controls.Add(Me.txt_category_search)
        Me.GroupBox4.Controls.Add(Me.btn_search_staff)
        Me.GroupBox4.Controls.Add(Me.btn_load_staff)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(225, 389)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(841, 50)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'txt_category_search
        '
        Me.txt_category_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_category_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_category_search.Location = New System.Drawing.Point(6, 12)
        Me.txt_category_search.Multiline = True
        Me.txt_category_search.Name = "txt_category_search"
        Me.txt_category_search.Size = New System.Drawing.Size(265, 29)
        Me.txt_category_search.TabIndex = 6
        '
        'btn_search_staff
        '
        Me.btn_search_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_staff.Location = New System.Drawing.Point(277, 12)
        Me.btn_search_staff.Name = "btn_search_staff"
        Me.btn_search_staff.Size = New System.Drawing.Size(172, 29)
        Me.btn_search_staff.TabIndex = 2
        Me.btn_search_staff.Text = "SEARCH CATEGORY"
        Me.btn_search_staff.UseVisualStyleBackColor = True
        '
        'btn_load_staff
        '
        Me.btn_load_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_staff.Location = New System.Drawing.Point(455, 12)
        Me.btn_load_staff.Name = "btn_load_staff"
        Me.btn_load_staff.Size = New System.Drawing.Size(150, 29)
        Me.btn_load_staff.TabIndex = 1
        Me.btn_load_staff.Text = "REFRESH CATEGORY"
        Me.btn_load_staff.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_category)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(224, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(554, 324)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'dgv_category
        '
        Me.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_category.Location = New System.Drawing.Point(6, 11)
        Me.dgv_category.Name = "dgv_category"
        Me.dgv_category.Size = New System.Drawing.Size(542, 307)
        Me.dgv_category.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_category_id)
        Me.GroupBox2.Controls.Add(Me.btn_logout)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(223, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(841, 50)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txt_category_id
        '
        Me.txt_category_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_category_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_category_id.Location = New System.Drawing.Point(8, 13)
        Me.txt_category_id.Multiline = True
        Me.txt_category_id.Name = "txt_category_id"
        Me.txt_category_id.Size = New System.Drawing.Size(10, 28)
        Me.txt_category_id.TabIndex = 10
        Me.txt_category_id.Visible = False
        '
        'btn_logout
        '
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(699, 12)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(135, 29)
        Me.btn_logout.TabIndex = 0
        Me.btn_logout.Text = "LOGOUT"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'frm_product_category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 460)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_product_category"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_delete_product As System.Windows.Forms.Button
    Friend WithEvents btn_edit_staff As System.Windows.Forms.Button
    Friend WithEvents btn_add_category As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_category_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_search_staff As System.Windows.Forms.Button
    Friend WithEvents btn_load_staff As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_category As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_category_description As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_category_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_category_id As System.Windows.Forms.TextBox
End Class
