Imports System.Data
Imports System.Data.SqlClient
Public Class QUANLYHANGHOA
    Dim abc As New SqlConnection("Data Source=ADRAGON-PC\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True")
    Private Sub loaddata()
        abc.Open()
        Dim load As New SqlCommand("select * from SanPham", abc)
        Dim data As New SqlDataAdapter(load)
        Dim data1 As New DataTable
        data.Fill(data1)
        abc.Close()
        lstsp.Items.Clear()
        Dim b As Integer
        For Each Row As DataRow In data1.Rows
            lstsp.Items.Add(Row("idsp").ToString())
            lstsp.Items(b).SubItems.Add(Row("tensp").ToString())
            lstsp.Items(b).SubItems.Add(Row("hangsp").ToString())
            lstsp.Items(b).SubItems.Add(Row("gia").ToString())
            lstsp.Items(b).SubItems.Add(Row("mota").ToString())
            lstsp.Items(b).SubItems.Add(Row("idloaisp").ToString())

            b += 1
        Next
    End Sub
    Private Sub QUANLYBANHANG_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub QUANLYBANHANG_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn có muốn thoát khỏi chương trình không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "THOÁT") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub ClearBox()
        txt_idsp.Text = ""
        txt_idloaisp.Text = ""
        txt_tensp.Text = ""
        txt_gia.Text = ""
        txt_hangsp.Text = ""
        txt_mota.Text = ""



    End Sub



    Private Sub lstsp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstsp.SelectedIndexChanged
        If lstsp.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstsp.SelectedItems
                txt_idsp.Text = lis.SubItems(0).Text
                txt_tensp.Text = lis.SubItems(1).Text
                txt_hangsp.Text = lis.SubItems(2).Text
                txt_gia.Text = lis.SubItems(3).Text
                txt_mota.Text = lis.SubItems(4).Text
                txt_idloaisp.Text = lis.SubItems(5).Text

                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub

    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_idsp.TextChanged, txt_idsp.TextChanged
        If (txt_idsp.Text.Trim = "") Then
            bntthem.Enabled = False


        Else
            bntthem.Enabled = True


        End If
    End Sub

    Private Function KiemTraThongTin() As Boolean

        If (txt_idsp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã sp", "Thông báo")
            Return False
        ElseIf (txt_idloaisp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã loại SP", "Thông báo")
            Return False
        ElseIf (txt_tensp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập tên sản phẩm", "Thông báo")
            Return False
        ElseIf (txt_gia.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập giá", "Thông báo")
            Return False
        ElseIf (txt_hangsp.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập hãng sản phẩm", "Thông báo")
            Return False


        End If

        Return True
    End Function

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        If (KiemTraThongTin() = True) Then
            Try
                abc.Open()
                Dim idsp As String = txt_idsp.Text
                Dim idloaisp As String = txt_idloaisp.Text
                Dim tensp As String = txt_tensp.Text
                Dim hangsp As String = txt_hangsp.Text
                Dim gia As String = txt_gia.Text
                Dim mota As String = txt_mota.Text

                Dim them As New SqlCommand("Insert into HoaDon(idsp,tensp,hangsp,gia,mota,idloaisp) values('" + idsp + "' , N'" + tensp + "',N'" + hangsp + "' ,'" + gia + "', N'" + mota + "',N'" + idloaisp + "')", abc)
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
            Dim idsp As String = txt_idsp.Text
            Dim xoa As New SqlCommand("delete from SanPham where idsp ='" + idsp + "'", abc)
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
            Dim idsp As String = txt_idsp.Text
            Dim idloaisp As String = txt_idloaisp.Text
            Dim tensp As String = txt_tensp.Text
            Dim hangsp As String = txt_hangsp.Text
            Dim gia As String = txt_gia.Text
            Dim mota As String = txt_mota.Text

            Dim sua As New SqlCommand("update SanPham set   hangsp = '" + hangsp + "', idloaisp = '" + idloaisp + "', tensp = '" + tensp + "', gia = '" + gia + "', mota = '" + mota + "' where idsp = '" + idsp + "' ", abc)
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

        Private Sub btQUANLYHOADON_Click(sender As Object, e As EventArgs) Handles btQUANLYHOADON.Click
            Me.Hide()
            QUANLYHOADON.ShowDialog()
        End Sub

        Private Sub btQUANLYCTHD_Click(sender As Object, e As EventArgs) Handles btQUANLYCTHD.Click
            Me.Hide()
            QUANLYCTHD.ShowDialog()
        End Sub

        Private Sub btbhTHEM_Click(sender As Object, e As EventArgs)

        End Sub

    Private Sub btLoai_Click(sender As Object, e As EventArgs) Handles btLoai.Click
        Loai.ShowDialog()
    End Sub

    Private Sub btkhachhang_Click(sender As Object, e As EventArgs) Handles btkhachhang.Click
        KHACHHANG.ShowDialog()
    End Sub
End Class
