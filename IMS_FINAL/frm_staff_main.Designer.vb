<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staff_main
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
        Me.txt_middlename = New System.Windows.Forms.TextBox()
        Me.dgv_staffs = New System.Windows.Forms.DataGridView()
        Me.btn_search_staff = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_view_staff = New System.Windows.Forms.Button()
        Me.btn_edit_staff = New System.Windows.Forms.Button()
        Me.btn_add_staff = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_load_staff = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_staffs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_middlename
        '
        Me.txt_middlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_middlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_middlename.Location = New System.Drawing.Point(6, 12)
        Me.txt_middlename.Multiline = True
        Me.txt_middlename.Name = "txt_middlename"
        Me.txt_middlename.Size = New System.Drawing.Size(265, 29)
        Me.txt_middlename.TabIndex = 6
        '
        'dgv_staffs
        '
        Me.dgv_staffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_staffs.Location = New System.Drawing.Point(6, 11)
        Me.dgv_staffs.Name = "dgv_staffs"
        Me.dgv_staffs.Size = New System.Drawing.Size(829, 307)
        Me.dgv_staffs.TabIndex = 0
        '
        'btn_search_staff
        '
        Me.btn_search_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_staff.Location = New System.Drawing.Point(277, 12)
        Me.btn_search_staff.Name = "btn_search_staff"
        Me.btn_search_staff.Size = New System.Drawing.Size(135, 29)
        Me.btn_search_staff.TabIndex = 2
        Me.btn_search_staff.Text = "SEARCH STAFF"
        Me.btn_search_staff.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_view_staff)
        Me.GroupBox5.Controls.Add(Me.btn_edit_staff)
        Me.GroupBox5.Controls.Add(Me.btn_add_staff)
        Me.GroupBox5.Controls.Add(Me.btn_back)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(210, 436)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'btn_view_staff
        '
        Me.btn_view_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_staff.Location = New System.Drawing.Point(6, 284)
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
        Me.btn_edit_staff.Text = "EDIT STAFF"
        Me.btn_edit_staff.UseVisualStyleBackColor = True
        '
        'btn_add_staff
        '
        Me.btn_add_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_staff.Location = New System.Drawing.Point(6, 214)
        Me.btn_add_staff.Name = "btn_add_staff"
        Me.btn_add_staff.Size = New System.Drawing.Size(198, 29)
        Me.btn_add_staff.TabIndex = 3
        Me.btn_add_staff.Text = "ADD STAFF"
        Me.btn_add_staff.UseVisualStyleBackColor = True
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
        'btn_load_staff
        '
        Me.btn_load_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_staff.Location = New System.Drawing.Point(418, 12)
        Me.btn_load_staff.Name = "btn_load_staff"
        Me.btn_load_staff.Size = New System.Drawing.Size(135, 29)
        Me.btn_load_staff.TabIndex = 1
        Me.btn_load_staff.Text = "REFRESH STAFF"
        Me.btn_load_staff.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_staffs)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(224, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(841, 324)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_logout)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(223, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(841, 50)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1073, 455)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_middlename)
        Me.GroupBox4.Controls.Add(Me.btn_search_staff)
        Me.GroupBox4.Controls.Add(Me.btn_load_staff)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(225, 389)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(841, 50)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'frm_staff_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1081, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_staff_main"
        Me.Text = " "
        CType(Me.dgv_staffs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_middlename As System.Windows.Forms.TextBox
    Friend WithEvents dgv_staffs As System.Windows.Forms.DataGridView
    Friend WithEvents btn_search_staff As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_view_staff As System.Windows.Forms.Button
    Friend WithEvents btn_edit_staff As System.Windows.Forms.Button
    Friend WithEvents btn_add_staff As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_load_staff As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
