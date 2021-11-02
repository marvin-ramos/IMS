<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_start_transaction
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_new_stocks = New System.Windows.Forms.TextBox()
        Me.txt_old_stocks = New System.Windows.Forms.TextBox()
        Me.txt_stock_on_hand = New System.Windows.Forms.TextBox()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_start_transaction = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_add_to_cart = New System.Windows.Forms.Button()
        Me.txt_search_product = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_customer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_product_price = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_product_quantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search_product = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_start_transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_new_stocks)
        Me.GroupBox2.Controls.Add(Me.txt_old_stocks)
        Me.GroupBox2.Controls.Add(Me.txt_stock_on_hand)
        Me.GroupBox2.Controls.Add(Me.txt_product_id)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(841, 50)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'txt_new_stocks
        '
        Me.txt_new_stocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_new_stocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_stocks.Location = New System.Drawing.Point(35, 12)
        Me.txt_new_stocks.Name = "txt_new_stocks"
        Me.txt_new_stocks.Size = New System.Drawing.Size(10, 22)
        Me.txt_new_stocks.TabIndex = 11
        Me.txt_new_stocks.Visible = False
        '
        'txt_old_stocks
        '
        Me.txt_old_stocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_old_stocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_old_stocks.Location = New System.Drawing.Point(26, 12)
        Me.txt_old_stocks.Name = "txt_old_stocks"
        Me.txt_old_stocks.Size = New System.Drawing.Size(10, 22)
        Me.txt_old_stocks.TabIndex = 10
        Me.txt_old_stocks.Visible = False
        '
        'txt_stock_on_hand
        '
        Me.txt_stock_on_hand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stock_on_hand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stock_on_hand.Location = New System.Drawing.Point(16, 12)
        Me.txt_stock_on_hand.Name = "txt_stock_on_hand"
        Me.txt_stock_on_hand.Size = New System.Drawing.Size(10, 22)
        Me.txt_stock_on_hand.TabIndex = 9
        Me.txt_stock_on_hand.Visible = False
        '
        'txt_product_id
        '
        Me.txt_product_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_product_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_id.Location = New System.Drawing.Point(6, 12)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.Size = New System.Drawing.Size(10, 22)
        Me.txt_product_id.TabIndex = 8
        Me.txt_product_id.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(760, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(176, 110)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(249, 22)
        Me.txt_subtotal.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_start_transaction)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(7, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(841, 303)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'dgv_start_transaction
        '
        Me.dgv_start_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_start_transaction.Location = New System.Drawing.Point(5, 12)
        Me.dgv_start_transaction.Name = "dgv_start_transaction"
        Me.dgv_start_transaction.Size = New System.Drawing.Size(831, 285)
        Me.dgv_start_transaction.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_add_to_cart)
        Me.GroupBox3.Controls.Add(Me.txt_search_product)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.btn_search_product)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(7, 371)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(841, 160)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'btn_add_to_cart
        '
        Me.btn_add_to_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_to_cart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_to_cart.Location = New System.Drawing.Point(598, 99)
        Me.btn_add_to_cart.Name = "btn_add_to_cart"
        Me.btn_add_to_cart.Size = New System.Drawing.Size(133, 29)
        Me.btn_add_to_cart.TabIndex = 9
        Me.btn_add_to_cart.Text = "ADD TO CART"
        Me.btn_add_to_cart.UseVisualStyleBackColor = True
        '
        'txt_search_product
        '
        Me.txt_search_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_product.Location = New System.Drawing.Point(451, 70)
        Me.txt_search_product.Name = "txt_search_product"
        Me.txt_search_product.Size = New System.Drawing.Size(384, 22)
        Me.txt_search_product.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txt_customer)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txt_subtotal)
        Me.GroupBox4.Controls.Add(Me.txt_product_price)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txt_product_quantity)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txt_product_name)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(431, 144)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-2, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SUBTOTAL :"
        '
        'txt_customer
        '
        Me.txt_customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer.Location = New System.Drawing.Point(175, 19)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.Size = New System.Drawing.Size(250, 22)
        Me.txt_customer.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CUSTOMER'S NAME :"
        '
        'txt_product_price
        '
        Me.txt_product_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_product_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_price.Location = New System.Drawing.Point(324, 80)
        Me.txt_product_price.Name = "txt_product_price"
        Me.txt_product_price.Size = New System.Drawing.Size(101, 22)
        Me.txt_product_price.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PRICE :"
        '
        'txt_product_quantity
        '
        Me.txt_product_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_product_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_quantity.Location = New System.Drawing.Point(176, 78)
        Me.txt_product_quantity.Name = "txt_product_quantity"
        Me.txt_product_quantity.Size = New System.Drawing.Size(75, 22)
        Me.txt_product_quantity.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "QUANTITY :"
        '
        'txt_product_name
        '
        Me.txt_product_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_product_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_name.Location = New System.Drawing.Point(175, 49)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.Size = New System.Drawing.Size(250, 22)
        Me.txt_product_name.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PRODUCT NAME :"
        '
        'btn_search_product
        '
        Me.btn_search_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_product.Location = New System.Drawing.Point(451, 99)
        Me.btn_search_product.Name = "btn_search_product"
        Me.btn_search_product.Size = New System.Drawing.Size(141, 29)
        Me.btn_search_product.TabIndex = 0
        Me.btn_search_product.Text = "SEARCH"
        Me.btn_search_product.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(744, 470)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(98, 29)
        Me.btn_back.TabIndex = 10
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_start_transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(856, 543)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_start_transaction"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_start_transaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_start_transaction As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_search_product As System.Windows.Forms.Button
    Friend WithEvents btn_add_to_cart As System.Windows.Forms.Button
    Friend WithEvents txt_search_product As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_product_price As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_product_quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_product_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_product_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents txt_customer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents txt_stock_on_hand As System.Windows.Forms.TextBox
    Friend WithEvents txt_old_stocks As System.Windows.Forms.TextBox
    Friend WithEvents txt_new_stocks As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
