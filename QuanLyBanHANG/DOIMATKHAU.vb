Public Class DOIMATKHAU

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtiddmk.Text = "" Then
            MessageBox.Show("Vui long nhap ID ")
        ElseIf txtpasscudmk.Text = "" Then
            MessageBox.Show("Vui long nhap pass cu")
        ElseIf txtpassmoidmk.Text = "" Then
            MessageBox.Show("Vui long nhap pass moi")
        ElseIf txtrepassmoidmk.Text = "" Then
            MessageBox.Show("Vui long nhap lai pass moi")
        Else
            MessageBox.Show("Doi Mat Khau Thanh Cong")
        End If
    End Sub

    Private Sub Hủy_Click(sender As Object, e As EventArgs) Handles Hủy.Click
        Close()
    End Sub
End Class