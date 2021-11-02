Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.DataTable
Imports System.Data.DataSet

Public Class frm_start_transaction

    Dim con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim i As Integer
    Dim dt As New DataTable
    Dim ds As New DataSet
    Dim index As Integer

    Public Sub FilterData(ByVal valuetoSearch As String)
        con.Open()
        Dim searchQuery As String = "SELECT *FROM products WHERE CONCAT(product_name, product_description, product_barcode) like '%" & txt_search_product.Text & "%'"
        Dim cmd As New sqlcommand(searchQuery, con)
        Dim da As New sqldataadapter(cmd)
        Dim dt As New DataTable()

        da.fill(dt)

        dgv_start_transaction.DataSource = dt
        con.Close()
    End Sub
    Public Sub GenerateProduct()
        Try
            Using con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")

                con.Open()
                Dim cmd As New SqlCommand("SELECT *FROM products", con)
                da.SelectCommand = cmd

                dgv_start_transaction.DataSource = dt
                dgv_start_transaction.RowTemplate.Height = 60

                dt.Clear()
                da.Fill(dt)

                For i As Integer = 0 To dgv_start_transaction.ColumnCount - 1
                    If TypeOf dgv_start_transaction.Columns(i) Is DataGridViewImageColumn Then
                        DirectCast(dgv_start_transaction.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cmd.Dispose()
        con.Close()
    End Sub
    Public Sub CalculateQuantity()
        Try
            Using con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")
                con.Open()
                Dim query As String = "UPDATE products SET stock_on_hand = @stock_on_hand WHERE product_id = @product_id"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@product_id", txt_product_id.Text)
                cmd.Parameters.AddWithValue("@stock_on_hand", txt_new_stocks.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_search_product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search_product.Click
        FilterData(txt_search_product.Text)
    End Sub
    Private Sub frm_start_transaction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GenerateProduct()
    End Sub
    Private Sub dgv_start_transaction_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_start_transaction.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow

        selectedRow = dgv_start_transaction.Rows(index)

        txt_product_id.Text = selectedRow.Cells(0).Value.ToString()
        txt_product_name.Text = selectedRow.Cells(2).Value.ToString()
        txt_product_price.Text = selectedRow.Cells(5).Value.ToString()
        txt_old_stocks.Text = selectedRow.Cells(6).Value.ToString()
    End Sub
    Private Sub txt_product_quantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_product_quantity.TextChanged
        If txt_product_price.Text <> "" Then
            txt_subtotal.Text = CInt(txt_product_quantity.Text) * CInt(txt_product_price.Text)
        End If
        If txt_product_quantity.Text <> "" Then
            txt_new_stocks.Text = CInt(txt_old_stocks.Text) - CInt(txt_product_quantity.Text)
        End If
    End Sub
    Private Sub btn_add_to_cart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_to_cart.Click
        con.Open()
        Dim date_purchase = Date.Now()

        If txt_old_stocks.Text < txt_product_quantity.Text Then
            MsgBox("Insuffient stocks")
        Else
            Using cmd As New SqlClient.SqlCommand("INSERT INTO pos(product_id,customer,quantity,subtotal,purchase_date) VALUES ('" & txt_product_id.Text & "', '" & txt_customer.Text & "', '" & txt_product_quantity.Text & "', '" & txt_subtotal.Text & "', '" & date_purchase & "')", con)
                i = cmd.ExecuteNonQuery
            End Using
            If (i > 0) Then
                MsgBox("Save" & i & "Record Successfully")
            End If
            CalculateQuantity()
            con.Close()
        End If
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        frm_pos.Show()
    End Sub
End Class