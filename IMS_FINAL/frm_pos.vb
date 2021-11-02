Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.DataTable
Imports System.Data.DataSet

Public Class frm_pos

    Dim con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim i As Integer
    Dim dt As New DataTable
    Dim ds As New DataSet
    Dim index As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_start_transaction.Show()
    End Sub

    Private Sub frm_pos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Using con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")

                con.Open()
                Dim cmd As New SqlCommand("SELECT *FROM pos", con)
                da.SelectCommand = cmd

                dgv_pos.DataSource = dt
                dgv_pos.RowTemplate.Height = 50

                dt.Clear()
                da.Fill(dt)

                For i As Integer = 0 To dgv_pos.ColumnCount - 1
                    If TypeOf dgv_pos.Columns(i) Is DataGridViewImageColumn Then
                        DirectCast(dgv_pos.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        Me.Hide()
        frm_staff_main.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        frm_product_main.Show()
    End Sub
End Class