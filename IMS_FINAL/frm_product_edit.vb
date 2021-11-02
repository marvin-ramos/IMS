Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.DataTable
Imports System.Data.DataSet

Class frm_product_edit
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
    Private Sub btn_view_product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view_product.Click
        Me.Hide()
        frm_product_load.Show()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        frm_product_main.Show()
    End Sub

    Private Sub frm_product_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IMS_FINALDataSet5.categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.IMS_FINALDataSet5.categories)

    End Sub

    Private Sub btn_add_product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_product.Click
        Dim query As String = "UPDATE products SET category_id = @category_id, product_name = @product_name, product_description = @product_description, product_barcode = @product_barcode, unit_price = @unit_price, stock_on_hand = @stock_on_hand, retail_price = @retail_price WHERE product_id = @product_id"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@product_id", txt_product_id.Text)
        cmd.Parameters.AddWithValue("@category_id", cmb_category.SelectedValue)
        cmd.Parameters.AddWithValue("@product_name", txt_product_name.Text)
        cmd.Parameters.AddWithValue("@product_description", txt_product_description.Text)
        cmd.Parameters.AddWithValue("@product_barcode", txt_generated_code.Text)
        cmd.Parameters.AddWithValue("@unit_price", txt_unit_price.Text)
        cmd.Parameters.AddWithValue("@stock_on_hand", txt_stock_on_hand.Text)
        cmd.Parameters.AddWithValue("@retail_price", txt_retail_price.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record Successfully updated")
    End Sub
End Class