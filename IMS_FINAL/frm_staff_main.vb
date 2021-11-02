Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class frm_staff_main

    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable

    Private Sub btn_load_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load_staff.Click
        Try
            Using con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")

                con.Open()
                Dim cmd As New SqlCommand("SELECT *FROM staffs", con)
                da.SelectCommand = cmd

                dgv_staffs.DataSource = dt
                dgv_staffs.RowTemplate.Height = 100

                dt.Clear()
                da.Fill(dt)

                For i As Integer = 0 To dgv_staffs.ColumnCount - 1
                    If TypeOf dgv_staffs.Columns(i) Is DataGridViewImageColumn Then
                        DirectCast(dgv_staffs.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                    End If
                Next

                cmd.Dispose()
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_edit_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_staff.Click
        Me.Hide()
        frm_staff_update.Show()
    End Sub

    Private Sub btn_search_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search_staff.Click

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        frm_pos.Show()
    End Sub

    Private Sub frm_staff_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class