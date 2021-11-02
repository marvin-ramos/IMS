Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.DataTable
Imports System.Data.DataSet

Public Class frm_product_category

    Dim con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim i As Integer
    Dim dt As New DataTable
    Dim ds As New DataSet
    Dim index As Integer

    Private Sub Clear()
        txt_category_name.Text = ""
        txt_category_description.Text = ""
    End Sub
    Public Sub FilterData(ByVal valuetoSearch As String)

        Dim searchQuery As String = "SELECT *FROM categories WHERE CONCAT(category_name, category_description) like '%" & txt_category_search.Text & "%'"
        Dim cmd As New sqlcommand(searchQuery, con)
        Dim da As New sqldataadapter(cmd)
        Dim dt As New datatable()

        da.fill(dt)

        dgv_category.DataSource = dt
    End Sub

    Private Sub btn_add_category_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_category.Click
        If txt_category_name.Text = "" Then
            MessageBox.Show("Firstname are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txt_category_description.Text = "" Then
            MessageBox.Show("Middlename are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            con.Open()
            Using cmd As New SqlClient.SqlCommand("INSERT INTO categories(category_name, category_description) VALUES ('" & txt_category_name.Text & "', '" & txt_category_description.Text & "')", con)
                i = cmd.ExecuteNonQuery
            End Using
            If (i > 0) Then
                MsgBox("Save" & i & "Record Successfully")
            End If
            Clear()
            con.Close()
        End If
    End Sub
    Private Sub btn_load_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load_staff.Click
        Try
            Using con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")

                con.Open()
                Dim cmd As New SqlCommand("SELECT *FROM categories", con)
                da.SelectCommand = cmd

                dgv_category.DataSource = dt
                dgv_category.RowTemplate.Height = 50

                dt.Clear()
                da.Fill(dt)

                For i As Integer = 0 To dgv_category.ColumnCount - 1
                    If TypeOf dgv_category.Columns(i) Is DataGridViewImageColumn Then
                        DirectCast(dgv_category.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                    End If
                Next

                cmd.Dispose()
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgv_category_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_category.CellClick

        index = e.RowIndex
        Dim selectedRow As DataGridViewRow

        selectedRow = dgv_category.Rows(index)

        txt_category_id.Text = selectedRow.Cells(0).Value.ToString()
        txt_category_name.Text = selectedRow.Cells(1).Value.ToString()
        txt_category_description.Text = selectedRow.Cells(2).Value.ToString()
    End Sub
    Private Sub btn_edit_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_staff.Click
        Dim query As String = "UPDATE categories SET category_name = @category_name, category_description = @category_description WHERE category_id = @category_id"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@category_id", txt_category_id.Text)
        cmd.Parameters.AddWithValue("@category_name", txt_category_name.Text)
        cmd.Parameters.AddWithValue("@category_description", txt_category_description.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record Successfully updated")
    End Sub
    Private Sub btn_delete_product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete_product.Click
        Try
            con.Open()
            Dim query As String
            query = "DELETE from categories WHERE category_id= '" & txt_category_id.Text & "'"
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
    Private Sub btn_search_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search_staff.Click
        FilterData(txt_category_search.Text)
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        frm_product_main.Show()
    End Sub

    Private Sub dgv_category_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_category.CellContentClick

    End Sub
End Class