Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.DataTable
Imports System.Data.DataSet

Public Class frm_product_main
    Dim con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim i As Integer
    Dim dt As New DataTable
    Dim ds As New DataSet
    Dim index As Integer

    Public Sub FilterData(ByVal valuetoSearch As String)

        Dim searchQuery As String = "SELECT *FROM products WHERE CONCAT(product_name, product_barcode) like '%" & txt_search_product.Text & "%'"
        Dim cmd As New sqlcommand(searchQuery, con)
        Dim da As New sqldataadapter(cmd)
        Dim dt As New DataTable()

        da.fill(dt)

        dgv_products.DataSource = dt
    End Sub

    Private Sub btn_search_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search_product.Click
        FilterData(txt_search_product.Text)
    End Sub

    Private Sub btn_edit_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_staff.Click
        Me.Hide()
        frm_product_add.Show()
    End Sub

    Private Sub btn_load_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load_product.Click
        Try
            Using con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")

                con.Open()
                Dim cmd As New SqlCommand("SELECT *FROM products", con)
                da.SelectCommand = cmd

                dgv_products.DataSource = dt
                dgv_products.RowTemplate.Height = 50

                dt.Clear()
                da.Fill(dt)

                For i As Integer = 0 To dgv_products.ColumnCount - 1
                    If TypeOf dgv_products.Columns(i) Is DataGridViewImageColumn Then
                        DirectCast(dgv_products.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                    End If
                Next

                cmd.Dispose()
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_product_category_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_product_category.Click
        Me.Hide()
        frm_product_category.Show()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        frm_pos.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_product.Click
        Me.Hide()
        frm_product_edit.Show()
    End Sub

    Private Sub btn_view_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view_staff.Click
        Try
            con.Open()
            Dim query As String
            query = "DELETE from products WHERE product_id= '" & txt_product_id.Text & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader

            MessageBox.Show("data updated")
            con.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgv_products_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_products.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow

        selectedRow = dgv_products.Rows(index)

        txt_product_id.Text = selectedRow.Cells(0).Value.ToString()
    End Sub
End Class