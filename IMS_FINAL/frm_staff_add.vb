Imports System.Data.SqlClient
Imports System.IO

Public Class frm_staff_add

    Dim con As New SqlConnection("Data Source=DESKTOP-COUD8T6\SQLEXPRESS;Initial Catalog=IMS_FINAL;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim i As Integer
    Dim a As New OpenFileDialog
    Dim dt As New DataTable

    Private Sub Clear()
        txt_firstname.Text = ""
        txt_middlename.Text = ""
        txt_lastname.Text = ""
        txt_age.Text = ""
        txt_phone.Text = ""
        txt_address.Text = ""
        cmb_gender.SelectedIndex = -1
        cmb_status.SelectedIndex = -1
        dtp_birthday.Value = Now.Date
        pb_staff_profile.Image = Image.FromFile(a.FileName)
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        frm_staff_main.Show()
    End Sub
    Private Sub btn_browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_browse.Click
        Dim picl As String
        a.Filter = Nothing
        picl = a.FileName
        a.ShowDialog()
        pb_staff_profile.Image = Image.FromFile(a.FileName)
    End Sub
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click

        If txt_firstname.Text = "" Then
            MessageBox.Show("Firstname are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txt_middlename.Text = "" Then
            MessageBox.Show("Middlename are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txt_lastname.Text = "" Then
            MessageBox.Show("Lastname are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txt_address.Text = "" Then
            MessageBox.Show("Address are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cmb_gender.Text = "" Then
            MessageBox.Show("Choose Gender", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txt_phone.Text = "" Then
            MessageBox.Show("Phone number are required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cmb_status.Text = "" Then
            MessageBox.Show("Choose Status", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            con.Open()
            Using cmd As New SqlClient.SqlCommand("INSERT INTO staffs(firstname, middlename, lastname, age, gender_id, birthday, status_id, address, phone_number, staff_profile) VALUES ('" & txt_firstname.Text & "', '" & txt_middlename.Text & "', '" & txt_lastname.Text & "', '" & txt_age.Text & "', '" & cmb_gender.SelectedValue & "', '" & dtp_birthday.Text & "', '" & cmb_status.SelectedValue & "', '" & txt_address.Text & "', '" & txt_phone.Text & "', @staff_profile)", con)
                cmd.Parameters.Add(New SqlClient.SqlParameter("@staff_profile", SqlDbType.Image)).Value = IO.File.ReadAllBytes(a.FileName)
                i = cmd.ExecuteNonQuery
            End Using
            If (i > 0) Then
                MsgBox("Save" & i & "Record Successfully")
            End If
            Clear()
            con.Close()
        End If
    End Sub
    Private Sub frm_staff_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IMS_FINALDataSet1.statuses' table. You can move, or remove it, as needed.
        Me.StatusesTableAdapter.Fill(Me.IMS_FINALDataSet1.statuses)
        'TODO: This line of code loads data into the 'IMS_FINALDataSet.genders' table. You can move, or remove it, as needed.
        Me.GendersTableAdapter.Fill(Me.IMS_FINALDataSet.genders)

    End Sub
    Private Sub dtp_birthday_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_birthday.ValueChanged
        Dim d1, d2 As Date
        Dim days, months, years As Long

        d1 = dtp_birthday.Value.ToShortDateString
        d2 = Now.ToShortDateString

        years = Year(d1)
        months = Month(d1)
        days = d1.Day

        years = Year(d2) - years
        months = Month(d2) - months
        days = d2.Day - days

        If Math.Sign(days) = -1 Then
            days = 30 - Math.Abs(days)
            months = months - 1
        End If

        If Math.Sign(months) = -1 Then
            months = 12 - Math.Abs(months)
            years = years - 1
        End If

        txt_age.Text = years.ToString
    End Sub
End Class