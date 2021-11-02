Imports System.Data.SqlClient
Imports System.IO

Public Class frm_product_add

    Dim con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim i As Integer
    Dim a As New OpenFileDialog
    Dim dt As New DataTable
    Dim x As String = ""
    Dim rand As Random = New Random()
    Dim bytImage() As Byte
    Dim ms As MemoryStream
    Dim photo_array() As Byte

    Private Sub generate_serial()
        For y As Integer = 1 To 6
            x = Date.Now.Year
            If y = 6 Then
                x += "0000"
            End If
        Next
        For y As Integer = 1 To 6
            x += Convert.ToString(rand.Next(0, 9))
        Next

        txt_generated_code.Text = x
        If txt_generated_code.Text = x Then
            x = Nothing
        End If
    End Sub
    Private Sub clear()
        cmb_category.SelectedIndex = -1
        txt_product_name.Text = ""
        txt_product_description.Text = ""
        txt_generated_code.Text = ""
        txt_unit_price.Text = ""
        txt_stock_on_hand.Text = ""
        txt_retail_price.Text = ""
        pb_product_picture.Image = Image.FromFile(a.FileName)
    End Sub

    Private Sub btn_browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_browse.Click
        Dim picl As String
        a.Filter = Nothing
        picl = a.FileName
        a.ShowDialog()
        pb_product_picture.Image = Image.FromFile(a.FileName)
    End Sub
    Private Sub btn_generate_code_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generate_code.Click
        generate_serial()
    End Sub
    Private Sub btn_view_product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view_product.Click
        Me.Hide()
        frm_product_main.Show()
    End Sub
    Private Sub btn_add_product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_product.Click
        Dim date2 = Now.ToShortDateString

        If IsNumeric(txt_product_name.Text) Then
            MsgBox("Product Name must be a letter. ")
            txt_product_name.Text = ""
        ElseIf IsNumeric(txt_product_description.Text) Then
            MsgBox("Product Description must be a letter. ")
            txt_product_description.Text = ""
        ElseIf Not IsNumeric(txt_stock_on_hand.Text) Then
            MsgBox("Stock on Hand must be a number. ")
            txt_stock_on_hand.Text = ""
        ElseIf Not IsNumeric(txt_retail_price.Text) Then
            MsgBox("Retail Price number must be a number.")
            txt_retail_price.Text = ""
        ElseIf Not IsNumeric(txt_unit_price.Text) Then
            MsgBox("Retail Price number must be a number.")
            txt_unit_price.Text = ""
        ElseIf txt_product_name.Text = "" Then
            MessageBox.Show("Product Name are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txt_product_description.Text = "" Then
            MessageBox.Show("Product Description are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txt_stock_on_hand.Text = "" Then
            MessageBox.Show("Stock on Hand are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txt_retail_price.Text = "" Then
            MessageBox.Show("Retail Price are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cmb_category.Text = "" Then
            MessageBox.Show("Choose Product Category", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txt_unit_price.Text = "" Then
            MessageBox.Show("Unit Price number are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txt_generated_code.Text = "" Then
            MessageBox.Show("Code must be created first", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                Using con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")
                    con.Open()
                    Dim cmd As New SqlCommand("insert into products (category_id,product_name,product_description,product_barcode,unit_price,stock_on_hand,retail_price,product_date,product_image) values (@category_id,@product_name,@product_description,@product_barcode,@unit_price,@stock_on_hand,@retail_price,@product_date,@product_image)", con)

                    With cmd.Parameters
                        .AddWithValue("@category_id", cmb_category.SelectedValue)
                        .AddWithValue("@product_name", txt_product_name.Text)
                        .AddWithValue("@product_description", txt_product_description.Text)
                        .AddWithValue("@product_barcode", txt_generated_code.Text)
                        .AddWithValue("@unit_price", txt_unit_price.Text)
                        .AddWithValue("@stock_on_hand", txt_stock_on_hand.Text)
                        .AddWithValue("@retail_price", txt_retail_price.Text)
                        .AddWithValue("@product_date", Date.Now())

                        Try
                            Dim ms As New System.IO.MemoryStream
                            Dim bmpImage As New Bitmap(pb_product_picture.Image)

                            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                            bytImage = ms.ToArray()
                            ms.Close()

                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try

                        .AddWithValue("@product_image", bytImage)

                    End With
                    'save_actions()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Product's Informations Successfuly Recorded!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Clear()
                    cmd.Dispose()
                    con.Close()
                End Using
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub frm_product_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IMS_FINALDataSet4.categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.IMS_FINALDataSet4.categories)

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        frm_product_main.Show()
    End Sub
End Class