<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staff_load
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.txt_search_staff = New System.Windows.Forms.TextBox()
        Me.btn_search_staff = New System.Windows.Forms.Button()
        Me.btn_load_staff = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_staffs = New System.Windows.Forms.DataGridView()
        Me.pb_staff = New System.Windows.Forms.PictureBox()
        Me.txt_firstname = New System.Windows.Forms.TextBox()
        Me.txt_middlename = New System.Windows.Forms.TextBox()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.txt_gender_id = New System.Windows.Forms.TextBox()
        Me.txt_status_id = New System.Windows.Forms.TextBox()
        Me.txt_lastname = New System.Windows.Forms.TextBox()
        Me.txt_birthday = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_phone_number = New System.Windows.Forms.TextBox()
        Me.txt_staff_profile = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_staffs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 455)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_load)
        Me.GroupBox4.Controls.Add(Me.txt_search_staff)
        Me.GroupBox4.Controls.Add(Me.btn_search_staff)
        Me.GroupBox4.Controls.Add(Me.btn_load_staff)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(6, 394)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(841, 50)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'btn_load
        '
        Me.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load.Location = New System.Drawing.Point(699, 12)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(135, 29)
        Me.btn_load.TabIndex = 7
        Me.btn_load.Text = "LOAD STAFF"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'txt_search_staff
        '
        Me.txt_search_staff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_staff.Location = New System.Drawing.Point(6, 12)
        Me.txt_search_staff.Multiline = True
        Me.txt_search_staff.Name = "txt_search_staff"
        Me.txt_search_staff.Size = New System.Drawing.Size(265, 29)
        Me.txt_search_staff.TabIndex = 6
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
        Me.GroupBox3.Controls.Add(Me.pb_staff)
        Me.GroupBox3.Controls.Add(Me.txt_firstname)
        Me.GroupBox3.Controls.Add(Me.txt_middlename)
        Me.GroupBox3.Controls.Add(Me.txt_age)
        Me.GroupBox3.Controls.Add(Me.txt_gender_id)
        Me.GroupBox3.Controls.Add(Me.txt_status_id)
        Me.GroupBox3.Controls.Add(Me.txt_lastname)
        Me.GroupBox3.Controls.Add(Me.txt_birthday)
        Me.GroupBox3.Controls.Add(Me.txt_address)
        Me.GroupBox3.Controls.Add(Me.txt_phone_number)
        Me.GroupBox3.Controls.Add(Me.txt_staff_profile)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(6, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(841, 324)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'dgv_staffs
        '
        Me.dgv_staffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_staffs.Location = New System.Drawing.Point(6, 11)
        Me.dgv_staffs.Name = "dgv_staffs"
        Me.dgv_staffs.Size = New System.Drawing.Size(829, 307)
        Me.dgv_staffs.TabIndex = 0
        '
        'pb_staff
        '
        Me.pb_staff.Location = New System.Drawing.Point(512, 74)
        Me.pb_staff.Name = "pb_staff"
        Me.pb_staff.Size = New System.Drawing.Size(136, 78)
        Me.pb_staff.TabIndex = 1
        Me.pb_staff.TabStop = False
        '
        'txt_firstname
        '
        Me.txt_firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_firstname.Location = New System.Drawing.Point(6, 11)
        Me.txt_firstname.Multiline = True
        Me.txt_firstname.Name = "txt_firstname"
        Me.txt_firstname.Size = New System.Drawing.Size(10, 29)
        Me.txt_firstname.TabIndex = 8
        '
        'txt_middlename
        '
        Me.txt_middlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_middlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_middlename.Location = New System.Drawing.Point(15, 11)
        Me.txt_middlename.Multiline = True
        Me.txt_middlename.Name = "txt_middlename"
        Me.txt_middlename.Size = New System.Drawing.Size(10, 29)
        Me.txt_middlename.TabIndex = 9
        '
        'txt_age
        '
        Me.txt_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age.Location = New System.Drawing.Point(33, 11)
        Me.txt_age.Multiline = True
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(10, 29)
        Me.txt_age.TabIndex = 11
        '
        'txt_gender_id
        '
        Me.txt_gender_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_gender_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gender_id.Location = New System.Drawing.Point(41, 11)
        Me.txt_gender_id.Multiline = True
        Me.txt_gender_id.Name = "txt_gender_id"
        Me.txt_gender_id.Size = New System.Drawing.Size(10, 29)
        Me.txt_gender_id.TabIndex = 12
        '
        'txt_status_id
        '
        Me.txt_status_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_status_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_status_id.Location = New System.Drawing.Point(57, 11)
        Me.txt_status_id.Multiline = True
        Me.txt_status_id.Name = "txt_status_id"
        Me.txt_status_id.Size = New System.Drawing.Size(10, 29)
        Me.txt_status_id.TabIndex = 14
        '
        'txt_lastname
        '
        Me.txt_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lastname.Location = New System.Drawing.Point(24, 11)
        Me.txt_lastname.Multiline = True
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.Size = New System.Drawing.Size(10, 29)
        Me.txt_lastname.TabIndex = 10
        '
        'txt_birthday
        '
        Me.txt_birthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_birthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_birthday.Location = New System.Drawing.Point(50, 11)
        Me.txt_birthday.Multiline = True
        Me.txt_birthday.Name = "txt_birthday"
        Me.txt_birthday.Size = New System.Drawing.Size(10, 29)
        Me.txt_birthday.TabIndex = 13
        '
        'txt_address
        '
        Me.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(66, 11)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(10, 29)
        Me.txt_address.TabIndex = 15
        '
        'txt_phone_number
        '
        Me.txt_phone_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phone_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone_number.Location = New System.Drawing.Point(75, 11)
        Me.txt_phone_number.Multiline = True
        Me.txt_phone_number.Name = "txt_phone_number"
        Me.txt_phone_number.Size = New System.Drawing.Size(10, 29)
        Me.txt_phone_number.TabIndex = 16
        '
        'txt_staff_profile
        '
        Me.txt_staff_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_staff_profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_profile.Location = New System.Drawing.Point(82, 11)
        Me.txt_staff_profile.Multiline = True
        Me.txt_staff_profile.Name = "txt_staff_profile"
        Me.txt_staff_profile.Size = New System.Drawing.Size(10, 29)
        Me.txt_staff_profile.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(841, 50)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'frm_staff_load
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(871, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_staff_load"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_staffs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_search_staff As System.Windows.Forms.TextBox
    Friend WithEvents btn_search_staff As System.Windows.Forms.Button
    Friend WithEvents btn_load_staff As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_load As System.Windows.Forms.Button
    Friend WithEvents txt_middlename As System.Windows.Forms.TextBox
    Friend WithEvents txt_firstname As System.Windows.Forms.TextBox
    Friend WithEvents txt_staff_profile As System.Windows.Forms.TextBox
    Friend WithEvents txt_phone_number As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_status_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_birthday As System.Windows.Forms.TextBox
    Friend WithEvents txt_gender_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents txt_lastname As System.Windows.Forms.TextBox
    Friend WithEvents pb_staff As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_staffs As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
