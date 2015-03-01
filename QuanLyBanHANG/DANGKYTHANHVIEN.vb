Public Class DANGKYTHANHVIEN
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthuybo.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdangky.Click
        If txtid.Text = "" Then
            MessageBox.Show("Vui long nhap ID dang ky")
        ElseIf txtpassdangky.Text = "" Then
            MessageBox.Show("Vui long nhap pass")
        ElseIf txtnhappass.Text = "" Then
            MessageBox.Show("Vui long nhap lai pass")
        ElseIf txthoten.Text = "" Then
            MessageBox.Show("Vui long nhap ho va ten")
        Else
            MessageBox.Show("Da dang ky thanh cong")
        End If
    End Sub

    Private Sub DANGKYTHANHVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub
End Class