Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class frm_staff_load

    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")
    Dim cmd As New SqlCommand

    Public Sub FilterData(ByVal valuetoSearch As String)

        Dim searchQuery As String = "SELECT *FROM categories WHERE CONCAT(category_name, category_description) like '%" & txt_search_staff.Text & "%'"
        Dim cmd As New sqlcommand(searchQuery, con)
        Dim da As New sqldataadapter(cmd)
        Dim dt As New datatable()

        da.fill(dt)

        dgv_staffs.DataSource = dt
    End Sub
    Function changephoto(ByVal photo As Integer) As Byte()
        con.Open()

        With cmd
            .Connection = con
            .CommandText = "SELECT staff_profile FROM staffs WHERE id=" & dgv_staffs.SelectedRows(0).Cells(0).Value
        End With

        Dim myphoto() As Byte = CType(cmd.ExecuteScalar(), Byte())
        con.Close()
        Return myphoto
    End Function

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
    Private Sub dgv_staffs_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_staffs.CellClick
        Try
            txt_firstname.Text = dgv_staffs.Item(1, e.RowIndex).Value
            txt_middlename.Text = dgv_staffs.Item(2, e.RowIndex).Value
            txt_lastname.Text = dgv_staffs.Item(3, e.RowIndex).Value
            txt_age.Text = dgv_staffs.Item(4, e.RowIndex).Value
            txt_gender_id.Text = dgv_staffs.Item(5, e.RowIndex).Value
            txt_birthday.Text = dgv_staffs.Item(6, e.RowIndex).Value
            txt_status_id.Text = dgv_staffs.Item(7, e.RowIndex).Value
            txt_address.Text = dgv_staffs.Item(8, e.RowIndex).Value
            txt_phone_number.Text = dgv_staffs.Item(9, e.RowIndex).Value

            Dim ms As New MemoryStream(changephoto(CInt(dgv_staffs.SelectedCells(0).Value)))
            pb_staff.Image = Image.FromStream(ms)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load.Click
        With frm_staff_update
            .txt_firstname.Text = txt_firstname.Text
            .txt_middlename.Text = txt_middlename.Text
            .txt_lastname.Text = txt_firstname.Text
            .txt_age.Text = txt_age.Text
            .cmb_gender.SelectedValue = txt_gender_id.Text
            .dtp_birthday.Text = txt_birthday.Text
            .cmb_status.SelectedValue = txt_status_id.Text
            .txt_address.Text = txt_address.Text
            .txt_phone.Text = txt_phone_number.Text
            .pb_staff_profile.Image = pb_staff.Image
            .Show()
            Me.Hide()
        End With
    End Sub

    Private Sub btn_search_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search_staff.Click
    End Sub

    Private Sub frm_staff_load_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class