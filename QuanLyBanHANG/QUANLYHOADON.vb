Imports System.Data
Imports System.Data.SqlClient
Public Class QUANLYHOADON
    Dim abc As New SqlConnection("Data Source=ADRAGON-PC\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True")
    Private Sub loaddata()
        abc.Open()
        Dim load As New SqlCommand("select * from HoaDon", abc)
        Dim data As New SqlDataAdapter(load)
        Dim data1 As New DataTable
        data.Fill(data1)
        abc.Close()
        lsthd.Items.Clear()
        Dim b As Integer
        For Each Row As DataRow In data1.Rows
            lsthd.Items.Add(Row("idhd").ToString())
            lsthd.Items(b).SubItems.Add(Row("idsp").ToString())
            lsthd.Items(b).SubItems.Add(Row("idkh").ToString())
            lsthd.Items(b).SubItems.Add(Row("tongtien").ToString())
            lsthd.Items(b).SubItems.Add(Row("ngayxuat").ToString())

            lsthd.Items(b).SubItems.Add(Row("mota").ToString())

            b += 1
        Next
    End Sub
    Private Sub QUANLYHOADON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub QUANLYHOADON_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn có muốn thoát khỏi chương trình không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "THOÁT") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ClearBox()
        txt_idhd.Text = ""
        txt_idsp.Text = ""
        txt_idkh.Text = ""
        txt_ngayxuat.Text = ""
        txt_tongtien.Text = ""
        txt_mota.Text = ""
    End Sub
    Private Sub lsthd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsthd.SelectedIndexChanged
        If lsthd.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsthd.SelectedItems
                txt_idhd.Text = lis.SubItems(0).Text
                txt_idsp.Text = lis.SubItems(1).Text
                txt_idkh.Text = lis.SubItems(2).Text
                txt_tongtien.Text = lis.SubItems(3).Text
                txt_ngayxuat.Text = lis.SubItems(4).Text
                txt_mota.Text = lis.SubItems(5).Text

                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub

    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_idhd.TextChanged, txt_idhd.TextChanged
        If (txt_idhd.Text.Trim = "") Then
            bntthem.Enabled = False


        Else
            bntthem.Enabled = True


        End If
    End Sub

    Private Function KiemTraThongTin() As Boolean

        If (txt_idhd.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã hóa đơn", "Thông báo")
            Return False
        ElseIf (txt_idkh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã khách hàng", "Thông báo")
            Return False
        ElseIf (txt_idsp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã sản phẩm", "Thông báo")
            Return False
        ElseIf (txt_tongtien.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập tổng tiền", "Thông báo")
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
                Dim idhd As String = txt_idhd.Text
                Dim idsp As String = txt_idsp.Text
                Dim idkh As String = txt_idkh.Text
                Dim tongtien As String = txt_tongtien.Text
                Dim ngayxuat As String = txt_ngayxuat.Text
                Dim mota As String = txt_mota.Text

                Dim them As New SqlCommand("Insert into HoaDon(idhd,idsp,idkh,tongtien,ngayxuat,mota) values('" + idhd + "' , N'" + idsp + "','" + idkh + "' ,'" + tongtien + "', N'" + ngayxuat + "',N'" + mota + "')", abc)
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

    End Sub

    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click
        Try
            abc.Open()
            Dim idhd As String = txt_idhd.Text
            Dim idsp As String = txt_idsp.Text
            Dim idkh As String = txt_idkh.Text
            Dim tongtien As String = txt_tongtien.Text
            Dim ngayxuat As String = txt_ngayxuat.Text
            Dim mota As String = txt_mota.Text

            Dim sua As New SqlCommand("update KhachHang set =  idkh = '" + idkh + "', idsp = '" + idsp + "',tongtien = '" + tongtien + "', ngayxuat = '" + ngayxuat + "',  mota = '" + mota + "' where idhd = '" + idhd + "' ", abc)
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

    Private Sub btCTHD_Click(sender As Object, e As EventArgs) Handles btCTHD.Click
        Me.Hide()
        QUANLYCTHD.ShowDialog()
    End Sub

    Private Sub btQUANLYHANGHOA_Click(sender As Object, e As EventArgs) Handles btQUANLYHANGHOA.Click
        Me.Hide()
        QUANLYHANGHOA.ShowDialog()
    End Sub

    Private Sub btkhachhang_Click(sender As Object, e As EventArgs) Handles btkhachhang.Click
        KHACHHANG.ShowDialog()
    End Sub
End Class