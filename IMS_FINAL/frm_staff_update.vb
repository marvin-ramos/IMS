Public Class frm_staff_update

    Private Sub btn_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load.Click
        Me.Hide()
        frm_staff_load.Show()
    End Sub

    Private Sub frm_staff_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'IMS_FINALDataSet3.statuses' table. You can move, or remove it, as needed.
        Me.StatusesTableAdapter.Fill(Me.IMS_FINALDataSet3.statuses)

        'TODO: This line of code loads data into the 'IMS_FINALDataSet2.genders' table. You can move, or remove it, as needed.
        Me.GendersTableAdapter.Fill(Me.IMS_FINALDataSet2.genders)

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        frm_staff_main.Show()
    End Sub
End Class