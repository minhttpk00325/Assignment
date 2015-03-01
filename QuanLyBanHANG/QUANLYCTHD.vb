Imports System.Data
Imports System.Data.SqlClient
Public Class QUANLYCTHD
    Dim abc As New SqlConnection("Data Source=ADRAGON-PC\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True")
    Private Sub loaddata()
        abc.Open()
        Dim load As New SqlCommand("select * from ChiTietHD", abc)
        Dim data As New SqlDataAdapter(load)
        Dim data1 As New DataTable
        data.Fill(data1)
        abc.Close()
        lstcthd.Items.Clear()
        Dim b As Integer
        For Each Row As DataRow In data1.Rows
            lstcthd.Items.Add(Row("idcthd").ToString())
            lstcthd.Items(b).SubItems.Add(Row("tensp").ToString())
            lstcthd.Items(b).SubItems.Add(Row("soluong").ToString())
            lstcthd.Items(b).SubItems.Add(Row("ngayxuat").ToString())
            lstcthd.Items(b).SubItems.Add(Row("mota").ToString())
            lstcthd.Items(b).SubItems.Add(Row("idhd").ToString())

            b += 1
        Next
    End Sub
    Private Sub QUANLYCTHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub QUANLYCTHD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn có muốn thoát khỏi chương trình không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "THOÁT") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ClearBox()
        txt_idcthd.Text = ""
        txt_tensp.Text = ""
        txt_soluong.Text = ""
        txt_ngayxuat.Text = ""
        txt_mota.Text = ""
        txt_idhd.Text = ""



    End Sub



    Private Sub lstcthd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstcthd.SelectedIndexChanged
        If lstcthd.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstcthd.SelectedItems
                txt_idcthd.Text = lis.SubItems(0).Text
                txt_tensp.Text = lis.SubItems(1).Text
                txt_soluong.Text = lis.SubItems(2).Text
                txt_ngayxuat.Text = lis.SubItems(3).Text
                txt_mota.Text = lis.SubItems(4).Text
                txt_idhd.Text = lis.SubItems(5).Text

                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub
    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_idcthd.TextChanged, txt_idcthd.TextChanged
        If (txt_idcthd.Text.Trim = "") Then
            bntthem.Enabled = False


        Else
            bntthem.Enabled = True


        End If
    End Sub

    Private Function KiemTraThongTin() As Boolean

        If (txt_idcthd.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã chi tiết hóa đơn", "Thông báo")
            Return False
        ElseIf (txt_idhd.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã hóa đơn", "Thông báo")
            Return False
        ElseIf (txt_tensp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập tên sản phẩm", "Thông báo")
            Return False
        ElseIf (txt_soluong.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo")
            Return False
        ElseIf (txt_ngayxuat.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập ngày xuất", "Thông báo")
            Return False


        End If

        Return True
    End Function

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        If (KiemTraThongTin() = True) Then
            Try
                abc.Open()
                Dim idcthd As String = txt_idcthd.Text

                Dim tensp As String = txt_tensp.Text
                Dim soluong As String = txt_soluong.Text
                Dim ngayxuat As String = txt_ngayxuat.Text
                Dim mota As String = txt_mota.Text
                Dim idhd As String = txt_idhd.Text

                Dim them As New SqlCommand("Insert into ChiTietHD(idcthd,tensp,soluong,ngayxuat,mota,idhd) values('" + idcthd + "' , N'" + tensp + "',N'" + soluong + "' ,'" + ngayxuat + "', N'" + mota + "',N'" + idhd + "')", abc)
                them.ExecuteNonQuery()
                abc.Close()
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loaddata()
            Catch ex As Exception
                MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ClearBox()
        End If
    End Sub

    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click
        Try
            abc.Open()
            Dim idcthd As String = txt_idcthd.Text
            Dim xoa As New SqlCommand("delete from ChiTietHD where idcthd ='" + idcthd + "'", abc)
            xoa.ExecuteNonQuery()
            abc.Close()
            MessageBox.Show("Có chắc là bạn muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            loaddata()
        Catch ex As Exception
            MessageBox.Show("Xóa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        bntsua.Enabled = False
        bntxoa.Enabled = False

    End Sub

    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click
        Try
            abc.Open()
            Dim idcthd As String = txt_idcthd.Text
            Dim idhd As String = txt_idhd.Text
            Dim tensp As String = txt_tensp.Text
            Dim soluong As String = txt_soluong.Text
            Dim ngayxuat As String = txt_ngayxuat.Text
            Dim mota As String = txt_mota.Text


            Dim sua As New SqlCommand("update ChiTietHD set   tensp = '" + tensp + "', soluong = '" + soluong + "', ngayxuat = '" + ngayxuat + "', mota = '" + mota + "', idhd = '" + idhd + "' where idcthd = '" + idcthd + "' ", abc)
            sua.ExecuteNonQuery()
            abc.Close()
            MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            loaddata()
        Catch ex As Exception
            MessageBox.Show("Sửa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub THOAT_Click(sender As Object, e As EventArgs) Handles THOAT.Click
        Close()
    End Sub

    Private Sub DK_Click(sender As Object, e As EventArgs) Handles DK.Click
        DANGKYTHANHVIEN.ShowDialog()
    End Sub

    Private Sub DMK_Click(sender As Object, e As EventArgs) Handles DMK.Click
        DOIMATKHAU.ShowDialog()
    End Sub

    Private Sub btQUANLYHANGHOA_Click(sender As Object, e As EventArgs) Handles btQUANLYHANGHOA.Click
        Me.Hide()
        QUANLYHANGHOA.ShowDialog()
    End Sub

    Private Sub btQUANLYSANPHAM_Click(sender As Object, e As EventArgs) Handles btQUANLYSANPHAM.Click
        Me.Hide()
        QUANLYHOADON.ShowDialog()
    End Sub


    Private Sub btkhachhang_Click(sender As Object, e As EventArgs) Handles btkhachhang.Click
        KHACHHANG.ShowDialog()
    End Sub
End Class