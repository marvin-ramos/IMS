Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class frm_product_load
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim i As Integer
    Dim index As Integer

    Public Sub FilterData(ByVal valuetoSearch As String)

        Dim searchQuery As String = "SELECT *FROM products WHERE CONCAT(product_name, product_barcode, product_date) like '%" & txt_search_product.Text & "%'"
        Dim cmd As New sqlcommand(searchQuery, con)
        Dim da As New sqldataadapter(cmd)
        Dim dt As New datatable()

        da.fill(dt)

        dgv_product.DataSource = dt
    End Sub

    Private Sub btn_load_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load_staff.Click
        Try
            Using con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")

                con.Open()
                Dim cmd As New SqlCommand("SELECT *FROM products", con)
                da.SelectCommand = cmd

                dgv_product.DataSource = dt
                dgv_product.RowTemplate.Height = 100

                dt.Clear()
                da.Fill(dt)

                For i As Integer = 0 To dgv_product.ColumnCount - 1
                    If TypeOf dgv_product.Columns(i) Is DataGridViewImageColumn Then
                        DirectCast(dgv_product.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                    End If
                Next

                cmd.Dispose()
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_search_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search_staff.Click
        FilterData(txt_search_product.Text)
    End Sub

    Private Sub dgv_product_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_product.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow

        selectedRow = dgv_product.Rows(index)

        txt_product_id.Text = selectedRow.Cells(0).Value.ToString()
        txt_category_id.Text = selectedRow.Cells(1).Value.ToString()
        txt_product_name.Text = selectedRow.Cells(2).Value.ToString()
        txt_product_description.Text = selectedRow.Cells(3).Value.ToString()
        txt_product_barcode.Text = selectedRow.Cells(4).Value.ToString()
        txt_unit_price.Text = selectedRow.Cells(5).Value.ToString()
        txt_stock_on_hand.Text = selectedRow.Cells(6).Value.ToString()
        txt_retail_price.Text = selectedRow.Cells(7).Value.ToString()
    End Sub

    Private Sub btn_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load.Click
        With frm_product_edit
            .txt_product_id.Text = txt_product_id.Text
            .cmb_category.SelectedValue = txt_category_id.Text
            .txt_product_name.Text = txt_product_name.Text
            .txt_product_description.Text = txt_product_description.Text
            .txt_generated_code.Text = txt_product_barcode.Text
            .txt_unit_price.Text = txt_unit_price.Text
            .txt_stock_on_hand.Text = txt_stock_on_hand.Text
            .txt_retail_price.Text = txt_retail_price.Text
            .Show()
            Me.Hide()
        End With
    End Sub
End Class