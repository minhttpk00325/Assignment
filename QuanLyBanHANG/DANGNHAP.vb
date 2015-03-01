Imports System.IO
Public Class DANGNHAP
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtpass.Text &= "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtpass.Text &= "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtpass.Text &= "3"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtpass.Text &= "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtpass.Text &= "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        txtpass.Text &= "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        txtpass.Text &= "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txtpass.Text &= "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        txtpass.Text &= "9"
    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        txtpass.Text &= "0"
    End Sub
    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        txtpass.Text = ""
    End Sub

    Private Sub btdangnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdangnhap.Click
        If txtdangnhap.Text = "admin" And txtpass.Text = "123123" Then
            txtpass.Text = ""
            MessageBox.Show("Đăng nhập thành công - Admin", "Thông báo")
            QUANLYHANGHOA.Show()
            Me.Hide()
        ElseIf txtdangnhap.Text = "minh" And txtpass.Text = "123123" Then
            txtpass.Text = ""
            MessageBox.Show("Đăng nhập thành công - Nhân Viên", "Thông báo")
            QUANLYHANGHOA.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo")
        End If
    End Sub

    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Close()
    End Sub

    Private Sub DANGNHAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
