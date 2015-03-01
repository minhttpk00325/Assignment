<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QUANLYCTHD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grHANGHOA = New System.Windows.Forms.GroupBox()
        Me.lstcthd = New System.Windows.Forms.ListView()
        Me.idcthd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tensp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.soluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ngayxuat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idhd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.lbl_sdt = New System.Windows.Forms.Label()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.txt_idhd = New System.Windows.Forms.TextBox()
        Me.txt_mota = New System.Windows.Forms.TextBox()
        Me.txt_ngayxuat = New System.Windows.Forms.TextBox()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.txt_soluong = New System.Windows.Forms.TextBox()
        Me.txt_tensp = New System.Windows.Forms.TextBox()
        Me.txt_idcthd = New System.Windows.Forms.TextBox()
        Me.btQUANLYSANPHAM = New System.Windows.Forms.Button()
        Me.btQUANLYHANGHOA = New System.Windows.Forms.Button()
        Me.THOAT = New System.Windows.Forms.ToolStripMenuItem()
        Me.LH = New System.Windows.Forms.ToolStripMenuItem()
        Me.HotlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐịaChỉToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NguyễnTiểuLaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DK = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMK = New System.Windows.Forms.ToolStripMenuItem()
        Me.DX = New System.Windows.Forms.ToolStripMenuItem()
        Me.DN = New System.Windows.Forms.ToolStripMenuItem()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btkhachhang = New System.Windows.Forms.Button()
        Me.grHANGHOA.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grHANGHOA
        '
        Me.grHANGHOA.Controls.Add(Me.lstcthd)
        Me.grHANGHOA.Controls.Add(Me.bntxoa)
        Me.grHANGHOA.Controls.Add(Me.lbl_sdt)
        Me.grHANGHOA.Controls.Add(Me.bntsua)
        Me.grHANGHOA.Controls.Add(Me.bntthem)
        Me.grHANGHOA.Controls.Add(Me.lbl_email)
        Me.grHANGHOA.Controls.Add(Me.lbl_diachi)
        Me.grHANGHOA.Controls.Add(Me.txt_idhd)
        Me.grHANGHOA.Controls.Add(Me.txt_mota)
        Me.grHANGHOA.Controls.Add(Me.txt_ngayxuat)
        Me.grHANGHOA.Controls.Add(Me.lbl_gioitinh)
        Me.grHANGHOA.Controls.Add(Me.lbl_tenkh)
        Me.grHANGHOA.Controls.Add(Me.lbl_idkh)
        Me.grHANGHOA.Controls.Add(Me.txt_soluong)
        Me.grHANGHOA.Controls.Add(Me.txt_tensp)
        Me.grHANGHOA.Controls.Add(Me.txt_idcthd)
        Me.grHANGHOA.Location = New System.Drawing.Point(12, 154)
        Me.grHANGHOA.Name = "grHANGHOA"
        Me.grHANGHOA.Size = New System.Drawing.Size(540, 394)
        Me.grHANGHOA.TabIndex = 14
        Me.grHANGHOA.TabStop = False
        Me.grHANGHOA.Text = "Quản Lý Chi Tiết Hóa Đơn"
        '
        'lstcthd
        '
        Me.lstcthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idcthd, Me.tensp, Me.soluong, Me.ngayxuat, Me.mota, Me.idhd})
        Me.lstcthd.FullRowSelect = True
        Me.lstcthd.GridLines = True
        Me.lstcthd.Location = New System.Drawing.Point(7, 205)
        Me.lstcthd.Name = "lstcthd"
        Me.lstcthd.Size = New System.Drawing.Size(527, 182)
        Me.lstcthd.TabIndex = 47
        Me.lstcthd.UseCompatibleStateImageBehavior = False
        Me.lstcthd.View = System.Windows.Forms.View.Details
        '
        'idcthd
        '
        Me.idcthd.Text = "ID CTHD"
        Me.idcthd.Width = 70
        '
        'tensp
        '
        Me.tensp.Text = "Tên SP"
        Me.tensp.Width = 81
        '
        'soluong
        '
        Me.soluong.Text = "Số Lượng"
        Me.soluong.Width = 83
        '
        'ngayxuat
        '
        Me.ngayxuat.Text = "Ngày Xuất"
        Me.ngayxuat.Width = 99
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        Me.mota.Width = 124
        '
        'idhd
        '
        Me.idhd.Text = "ID HĐ"
        Me.idhd.Width = 67
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(386, 151)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 31)
        Me.bntxoa.TabIndex = 29
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'lbl_sdt
        '
        Me.lbl_sdt.AutoSize = True
        Me.lbl_sdt.Location = New System.Drawing.Point(272, 109)
        Me.lbl_sdt.Name = "lbl_sdt"
        Me.lbl_sdt.Size = New System.Drawing.Size(37, 13)
        Me.lbl_sdt.TabIndex = 44
        Me.lbl_sdt.Text = "ID HĐ"
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(219, 151)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 31)
        Me.bntsua.TabIndex = 30
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(59, 151)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 31)
        Me.bntthem.TabIndex = 31
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(272, 73)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 45
        Me.lbl_email.Text = "Mo Ta"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(272, 38)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(57, 13)
        Me.lbl_diachi.TabIndex = 46
        Me.lbl_diachi.Text = "Ngày Xuất"
        '
        'txt_idhd
        '
        Me.txt_idhd.Location = New System.Drawing.Point(335, 102)
        Me.txt_idhd.Name = "txt_idhd"
        Me.txt_idhd.Size = New System.Drawing.Size(159, 20)
        Me.txt_idhd.TabIndex = 41
        '
        'txt_mota
        '
        Me.txt_mota.Location = New System.Drawing.Point(335, 70)
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.Size = New System.Drawing.Size(159, 20)
        Me.txt_mota.TabIndex = 42
        '
        'txt_ngayxuat
        '
        Me.txt_ngayxuat.Location = New System.Drawing.Point(335, 38)
        Me.txt_ngayxuat.Name = "txt_ngayxuat"
        Me.txt_ngayxuat.Size = New System.Drawing.Size(159, 20)
        Me.txt_ngayxuat.TabIndex = 43
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(26, 109)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(53, 13)
        Me.lbl_gioitinh.TabIndex = 38
        Me.lbl_gioitinh.Text = "Số Lượng"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(28, 70)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(43, 13)
        Me.lbl_tenkh.TabIndex = 39
        Me.lbl_tenkh.Text = "Tên SP"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(29, 38)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(51, 13)
        Me.lbl_idkh.TabIndex = 40
        Me.lbl_idkh.Text = "ID CTHD"
        '
        'txt_soluong
        '
        Me.txt_soluong.ForeColor = System.Drawing.Color.Red
        Me.txt_soluong.Location = New System.Drawing.Point(80, 102)
        Me.txt_soluong.Name = "txt_soluong"
        Me.txt_soluong.Size = New System.Drawing.Size(156, 20)
        Me.txt_soluong.TabIndex = 35
        '
        'txt_tensp
        '
        Me.txt_tensp.Location = New System.Drawing.Point(80, 70)
        Me.txt_tensp.Name = "txt_tensp"
        Me.txt_tensp.Size = New System.Drawing.Size(156, 20)
        Me.txt_tensp.TabIndex = 36
        '
        'txt_idcthd
        '
        Me.txt_idcthd.Location = New System.Drawing.Point(80, 38)
        Me.txt_idcthd.Name = "txt_idcthd"
        Me.txt_idcthd.Size = New System.Drawing.Size(156, 20)
        Me.txt_idcthd.TabIndex = 37
        '
        'btQUANLYSANPHAM
        '
        Me.btQUANLYSANPHAM.Location = New System.Drawing.Point(204, 98)
        Me.btQUANLYSANPHAM.Name = "btQUANLYSANPHAM"
        Me.btQUANLYSANPHAM.Size = New System.Drawing.Size(159, 34)
        Me.btQUANLYSANPHAM.TabIndex = 12
        Me.btQUANLYSANPHAM.Text = "Quản Lý Hóa Đơn"
        Me.btQUANLYSANPHAM.UseVisualStyleBackColor = True
        '
        'btQUANLYHANGHOA
        '
        Me.btQUANLYHANGHOA.Location = New System.Drawing.Point(19, 98)
        Me.btQUANLYHANGHOA.Name = "btQUANLYHANGHOA"
        Me.btQUANLYHANGHOA.Size = New System.Drawing.Size(148, 34)
        Me.btQUANLYHANGHOA.TabIndex = 11
        Me.btQUANLYHANGHOA.Text = "Quản Lý Hàng Hóa"
        Me.btQUANLYHANGHOA.UseVisualStyleBackColor = True
        '
        'THOAT
        '
        Me.THOAT.Name = "THOAT"
        Me.THOAT.Size = New System.Drawing.Size(50, 20)
        Me.THOAT.Text = "Thoát"
        '
        'LH
        '
        Me.LH.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HotlineToolStripMenuItem, Me.FaxToolStripMenuItem, Me.ĐịaChỉToolStripMenuItem})
        Me.LH.Name = "LH"
        Me.LH.Size = New System.Drawing.Size(59, 20)
        Me.LH.Text = "Liên Hệ"
        '
        'HotlineToolStripMenuItem
        '
        Me.HotlineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.HotlineToolStripMenuItem.Name = "HotlineToolStripMenuItem"
        Me.HotlineToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.HotlineToolStripMenuItem.Text = "Hotline"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(140, 22)
        Me.ToolStripMenuItem2.Text = "01232764747"
        '
        'FaxToolStripMenuItem
        '
        Me.FaxToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.FaxToolStripMenuItem.Name = "FaxToolStripMenuItem"
        Me.FaxToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.FaxToolStripMenuItem.Text = "Fax"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem3.Text = "0500.3851888"
        '
        'ĐịaChỉToolStripMenuItem
        '
        Me.ĐịaChỉToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NguyễnTiểuLaToolStripMenuItem})
        Me.ĐịaChỉToolStripMenuItem.Name = "ĐịaChỉToolStripMenuItem"
        Me.ĐịaChỉToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ĐịaChỉToolStripMenuItem.Text = "Địa chỉ"
        '
        'NguyễnTiểuLaToolStripMenuItem
        '
        Me.NguyễnTiểuLaToolStripMenuItem.Name = "NguyễnTiểuLaToolStripMenuItem"
        Me.NguyễnTiểuLaToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.NguyễnTiểuLaToolStripMenuItem.Text = "19 Nguyễn Tiểu La"
        '
        'DK
        '
        Me.DK.Name = "DK"
        Me.DK.Size = New System.Drawing.Size(65, 20)
        Me.DK.Text = "Đăng ký "
        '
        'DMK
        '
        Me.DMK.Name = "DMK"
        Me.DMK.Size = New System.Drawing.Size(146, 22)
        Me.DMK.Text = "Đổi Mật Khẩu"
        '
        'DX
        '
        Me.DX.Name = "DX"
        Me.DX.Size = New System.Drawing.Size(146, 22)
        Me.DX.Text = "Đăng Xuất"
        '
        'DN
        '
        Me.DN.Name = "DN"
        Me.DN.Size = New System.Drawing.Size(146, 22)
        Me.DN.Text = "Đăng Nhập"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DN, Me.DX, Me.DMK})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.HệThốngToolStripMenuItem.Text = "Hệ Thống"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.DK, Me.LH, Me.THOAT})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(560, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(48, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 50)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Quản Lý Chi Tiết Hóa Đơn"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btkhachhang
        '
        Me.btkhachhang.Location = New System.Drawing.Point(398, 98)
        Me.btkhachhang.Name = "btkhachhang"
        Me.btkhachhang.Size = New System.Drawing.Size(148, 34)
        Me.btkhachhang.TabIndex = 17
        Me.btkhachhang.Text = "Khách Hàng"
        Me.btkhachhang.UseVisualStyleBackColor = True
        '
        'QUANLYCTHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyBanHANG.My.Resources.Resources.Stainless_Steel_Juin__Manga__by_UchihaItachi121
        Me.ClientSize = New System.Drawing.Size(560, 555)
        Me.Controls.Add(Me.btkhachhang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grHANGHOA)
        Me.Controls.Add(Me.btQUANLYSANPHAM)
        Me.Controls.Add(Me.btQUANLYHANGHOA)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "QUANLYCTHD"
        Me.Text = "Quản Lý CTHD"
        Me.grHANGHOA.ResumeLayout(False)
        Me.grHANGHOA.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grHANGHOA As System.Windows.Forms.GroupBox
    Friend WithEvents btQUANLYSANPHAM As System.Windows.Forms.Button
    Friend WithEvents btQUANLYHANGHOA As System.Windows.Forms.Button
    Friend WithEvents THOAT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DMK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HotlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐịaChỉToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NguyễnTiểuLaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstcthd As System.Windows.Forms.ListView
    Friend WithEvents idcthd As System.Windows.Forms.ColumnHeader
    Friend WithEvents tensp As System.Windows.Forms.ColumnHeader
    Friend WithEvents soluong As System.Windows.Forms.ColumnHeader
    Friend WithEvents ngayxuat As System.Windows.Forms.ColumnHeader
    Friend WithEvents mota As System.Windows.Forms.ColumnHeader
    Friend WithEvents idhd As System.Windows.Forms.ColumnHeader
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents lbl_sdt As System.Windows.Forms.Label
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_diachi As System.Windows.Forms.Label
    Friend WithEvents txt_idhd As System.Windows.Forms.TextBox
    Friend WithEvents txt_mota As System.Windows.Forms.TextBox
    Friend WithEvents txt_ngayxuat As System.Windows.Forms.TextBox
    Friend WithEvents lbl_gioitinh As System.Windows.Forms.Label
    Friend WithEvents lbl_tenkh As System.Windows.Forms.Label
    Friend WithEvents lbl_idkh As System.Windows.Forms.Label
    Friend WithEvents txt_soluong As System.Windows.Forms.TextBox
    Friend WithEvents txt_tensp As System.Windows.Forms.TextBox
    Friend WithEvents txt_idcthd As System.Windows.Forms.TextBox
    Friend WithEvents btkhachhang As System.Windows.Forms.Button
End Class
