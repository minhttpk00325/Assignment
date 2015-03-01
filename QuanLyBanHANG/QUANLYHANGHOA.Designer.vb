<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QUANLYHANGHOA
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DN = New System.Windows.Forms.ToolStripMenuItem()
        Me.DX = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMK = New System.Windows.Forms.ToolStripMenuItem()
        Me.DK = New System.Windows.Forms.ToolStripMenuItem()
        Me.LH = New System.Windows.Forms.ToolStripMenuItem()
        Me.HotlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐịaChỉToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NguyễnTiểuLaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.THOAT = New System.Windows.Forms.ToolStripMenuItem()
        Me.btQUANLYCTHD = New System.Windows.Forms.Button()
        Me.btQUANLYHOADON = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grHANGHOA = New System.Windows.Forms.GroupBox()
        Me.btLoai = New System.Windows.Forms.Button()
        Me.lbl_sdt = New System.Windows.Forms.Label()
        Me.txt_idloaisp = New System.Windows.Forms.TextBox()
        Me.lstsp = New System.Windows.Forms.ListView()
        Me.idsp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tensp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hangsp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idloaisp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.txt_idsp = New System.Windows.Forms.TextBox()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txt_gia = New System.Windows.Forms.TextBox()
        Me.txt_tensp = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_hangsp = New System.Windows.Forms.TextBox()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.txt_mota = New System.Windows.Forms.TextBox()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.btkhachhang = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grHANGHOA.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.DK, Me.LH, Me.THOAT})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DN, Me.DX, Me.DMK})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.HệThốngToolStripMenuItem.Text = "Hệ Thống"
        '
        'DN
        '
        Me.DN.Name = "DN"
        Me.DN.Size = New System.Drawing.Size(146, 22)
        Me.DN.Text = "Đăng Nhập"
        '
        'DX
        '
        Me.DX.Name = "DX"
        Me.DX.Size = New System.Drawing.Size(146, 22)
        Me.DX.Text = "Đăng Xuất"
        '
        'DMK
        '
        Me.DMK.Name = "DMK"
        Me.DMK.Size = New System.Drawing.Size(146, 22)
        Me.DMK.Text = "Đổi Mật Khẩu"
        '
        'DK
        '
        Me.DK.Name = "DK"
        Me.DK.Size = New System.Drawing.Size(65, 20)
        Me.DK.Text = "Đăng ký "
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
        'THOAT
        '
        Me.THOAT.Name = "THOAT"
        Me.THOAT.Size = New System.Drawing.Size(50, 20)
        Me.THOAT.Text = "Thoát"
        '
        'btQUANLYCTHD
        '
        Me.btQUANLYCTHD.Location = New System.Drawing.Point(12, 116)
        Me.btQUANLYCTHD.Name = "btQUANLYCTHD"
        Me.btQUANLYCTHD.Size = New System.Drawing.Size(192, 36)
        Me.btQUANLYCTHD.TabIndex = 1
        Me.btQUANLYCTHD.Text = "Quản Lý Chi Tiết Hóa Đơn"
        Me.btQUANLYCTHD.UseVisualStyleBackColor = True
        '
        'btQUANLYHOADON
        '
        Me.btQUANLYHOADON.Location = New System.Drawing.Point(246, 116)
        Me.btQUANLYHOADON.Name = "btQUANLYHOADON"
        Me.btQUANLYHOADON.Size = New System.Drawing.Size(181, 36)
        Me.btQUANLYHOADON.TabIndex = 2
        Me.btQUANLYHOADON.Text = "Quản Lý Hóa Đơn"
        Me.btQUANLYHOADON.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Constantia", 22.2!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblTitle.Location = New System.Drawing.Point(65, 30)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(534, 82)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG Quản Lý Hàng Hóa"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grHANGHOA
        '
        Me.grHANGHOA.Controls.Add(Me.btLoai)
        Me.grHANGHOA.Controls.Add(Me.lbl_sdt)
        Me.grHANGHOA.Controls.Add(Me.txt_idloaisp)
        Me.grHANGHOA.Controls.Add(Me.lstsp)
        Me.grHANGHOA.Controls.Add(Me.bntxoa)
        Me.grHANGHOA.Controls.Add(Me.bntsua)
        Me.grHANGHOA.Controls.Add(Me.txt_idsp)
        Me.grHANGHOA.Controls.Add(Me.bntthem)
        Me.grHANGHOA.Controls.Add(Me.txt_gia)
        Me.grHANGHOA.Controls.Add(Me.txt_tensp)
        Me.grHANGHOA.Controls.Add(Me.lbl_email)
        Me.grHANGHOA.Controls.Add(Me.txt_hangsp)
        Me.grHANGHOA.Controls.Add(Me.lbl_gioitinh)
        Me.grHANGHOA.Controls.Add(Me.txt_mota)
        Me.grHANGHOA.Controls.Add(Me.lbl_tenkh)
        Me.grHANGHOA.Controls.Add(Me.lbl_diachi)
        Me.grHANGHOA.Controls.Add(Me.lbl_idkh)
        Me.grHANGHOA.Location = New System.Drawing.Point(12, 165)
        Me.grHANGHOA.Name = "grHANGHOA"
        Me.grHANGHOA.Size = New System.Drawing.Size(617, 389)
        Me.grHANGHOA.TabIndex = 9
        Me.grHANGHOA.TabStop = False
        Me.grHANGHOA.Text = "Quản Lý Hàng Hóa"
        '
        'btLoai
        '
        Me.btLoai.Location = New System.Drawing.Point(504, 27)
        Me.btLoai.Name = "btLoai"
        Me.btLoai.Size = New System.Drawing.Size(97, 125)
        Me.btLoai.TabIndex = 82
        Me.btLoai.Text = "Các Loại Sản Phẩm"
        Me.btLoai.UseVisualStyleBackColor = True
        '
        'lbl_sdt
        '
        Me.lbl_sdt.AutoSize = True
        Me.lbl_sdt.Location = New System.Drawing.Point(258, 91)
        Me.lbl_sdt.Name = "lbl_sdt"
        Me.lbl_sdt.Size = New System.Drawing.Size(58, 13)
        Me.lbl_sdt.TabIndex = 81
        Me.lbl_sdt.Text = "ID Loai SP"
        '
        'txt_idloaisp
        '
        Me.txt_idloaisp.Location = New System.Drawing.Point(321, 84)
        Me.txt_idloaisp.Name = "txt_idloaisp"
        Me.txt_idloaisp.Size = New System.Drawing.Size(158, 20)
        Me.txt_idloaisp.TabIndex = 80
        '
        'lstsp
        '
        Me.lstsp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idsp, Me.tensp, Me.hangsp, Me.gia, Me.mota, Me.idloaisp})
        Me.lstsp.FullRowSelect = True
        Me.lstsp.GridLines = True
        Me.lstsp.Location = New System.Drawing.Point(6, 161)
        Me.lstsp.Name = "lstsp"
        Me.lstsp.Size = New System.Drawing.Size(605, 222)
        Me.lstsp.TabIndex = 79
        Me.lstsp.UseCompatibleStateImageBehavior = False
        Me.lstsp.View = System.Windows.Forms.View.Details
        '
        'idsp
        '
        Me.idsp.Text = "ID SP"
        Me.idsp.Width = 101
        '
        'tensp
        '
        Me.tensp.Text = "Tên SP"
        Me.tensp.Width = 113
        '
        'hangsp
        '
        Me.hangsp.Text = "Hãng SP"
        Me.hangsp.Width = 81
        '
        'gia
        '
        Me.gia.Text = "Giá"
        Me.gia.Width = 67
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        Me.mota.Width = 153
        '
        'idloaisp
        '
        Me.idloaisp.Text = "ID Loại SP"
        Me.idloaisp.Width = 85
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(378, 120)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(100, 32)
        Me.bntxoa.TabIndex = 76
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(206, 120)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(100, 32)
        Me.bntsua.TabIndex = 77
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'txt_idsp
        '
        Me.txt_idsp.Location = New System.Drawing.Point(78, 27)
        Me.txt_idsp.Name = "txt_idsp"
        Me.txt_idsp.Size = New System.Drawing.Size(157, 20)
        Me.txt_idsp.TabIndex = 69
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(34, 120)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(100, 32)
        Me.bntthem.TabIndex = 78
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txt_gia
        '
        Me.txt_gia.ForeColor = System.Drawing.Color.Red
        Me.txt_gia.Location = New System.Drawing.Point(320, 27)
        Me.txt_gia.Name = "txt_gia"
        Me.txt_gia.Size = New System.Drawing.Size(159, 20)
        Me.txt_gia.TabIndex = 68
        '
        'txt_tensp
        '
        Me.txt_tensp.Location = New System.Drawing.Point(78, 58)
        Me.txt_tensp.Name = "txt_tensp"
        Me.txt_tensp.Size = New System.Drawing.Size(157, 20)
        Me.txt_tensp.TabIndex = 67
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(258, 61)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 71
        Me.lbl_email.Text = "Mo Ta"
        '
        'txt_hangsp
        '
        Me.txt_hangsp.Location = New System.Drawing.Point(78, 88)
        Me.txt_hangsp.Name = "txt_hangsp"
        Me.txt_hangsp.Size = New System.Drawing.Size(157, 20)
        Me.txt_hangsp.TabIndex = 66
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(22, 88)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(50, 13)
        Me.lbl_gioitinh.TabIndex = 72
        Me.lbl_gioitinh.Text = "Hang SP"
        '
        'txt_mota
        '
        Me.txt_mota.Location = New System.Drawing.Point(319, 55)
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.Size = New System.Drawing.Size(160, 20)
        Me.txt_mota.TabIndex = 65
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(22, 58)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(43, 13)
        Me.lbl_tenkh.TabIndex = 73
        Me.lbl_tenkh.Text = "Tên SP"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(258, 30)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(23, 13)
        Me.lbl_diachi.TabIndex = 74
        Me.lbl_diachi.Text = "Gia"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(22, 30)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(35, 13)
        Me.lbl_idkh.TabIndex = 75
        Me.lbl_idkh.Text = "ID SP"
        '
        'btkhachhang
        '
        Me.btkhachhang.Location = New System.Drawing.Point(457, 116)
        Me.btkhachhang.Name = "btkhachhang"
        Me.btkhachhang.Size = New System.Drawing.Size(170, 36)
        Me.btkhachhang.TabIndex = 18
        Me.btkhachhang.Text = "Khách Hàng"
        Me.btkhachhang.UseVisualStyleBackColor = True
        '
        'QUANLYHANGHOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyBanHANG.My.Resources.Resources.Stainless_Steel_Uchiha_Clan_by_UchihaItachi121
        Me.ClientSize = New System.Drawing.Size(639, 563)
        Me.Controls.Add(Me.btkhachhang)
        Me.Controls.Add(Me.grHANGHOA)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btQUANLYHOADON)
        Me.Controls.Add(Me.btQUANLYCTHD)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "QUANLYHANGHOA"
        Me.Text = "QUANLYHANGHOA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grHANGHOA.ResumeLayout(False)
        Me.grHANGHOA.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DMK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents THOAT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btQUANLYCTHD As System.Windows.Forms.Button
    Friend WithEvents btQUANLYHOADON As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grHANGHOA As System.Windows.Forms.GroupBox
    Friend WithEvents HotlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐịaChỉToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NguyễnTiểuLaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents txt_idsp As System.Windows.Forms.TextBox
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents txt_gia As System.Windows.Forms.TextBox
    Friend WithEvents txt_tensp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents txt_hangsp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_gioitinh As System.Windows.Forms.Label
    Friend WithEvents txt_mota As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tenkh As System.Windows.Forms.Label
    Friend WithEvents lbl_diachi As System.Windows.Forms.Label
    Friend WithEvents lbl_idkh As System.Windows.Forms.Label
    Friend WithEvents lbl_sdt As System.Windows.Forms.Label
    Friend WithEvents txt_idloaisp As System.Windows.Forms.TextBox
    Friend WithEvents lstsp As System.Windows.Forms.ListView
    Friend WithEvents idsp As System.Windows.Forms.ColumnHeader
    Friend WithEvents tensp As System.Windows.Forms.ColumnHeader
    Friend WithEvents hangsp As System.Windows.Forms.ColumnHeader
    Friend WithEvents gia As System.Windows.Forms.ColumnHeader
    Friend WithEvents mota As System.Windows.Forms.ColumnHeader
    Friend WithEvents idloaisp As System.Windows.Forms.ColumnHeader
    Friend WithEvents btLoai As System.Windows.Forms.Button
    Friend WithEvents btkhachhang As System.Windows.Forms.Button
End Class
