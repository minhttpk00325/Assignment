<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DANGKYTHANHVIEN
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btdangky = New System.Windows.Forms.Button()
        Me.bthuybo = New System.Windows.Forms.Button()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.txtnhappass = New System.Windows.Forms.TextBox()
        Me.txtpassdangky = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QuanLyBanHANG.My.Resources.Resources._51b966ff63d0167465
        Me.PictureBox1.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'btdangky
        '
        Me.btdangky.Location = New System.Drawing.Point(445, 166)
        Me.btdangky.Name = "btdangky"
        Me.btdangky.Size = New System.Drawing.Size(75, 23)
        Me.btdangky.TabIndex = 37
        Me.btdangky.Text = "Đăng ký"
        Me.btdangky.UseVisualStyleBackColor = True
        '
        'bthuybo
        '
        Me.bthuybo.Location = New System.Drawing.Point(306, 165)
        Me.bthuybo.Name = "bthuybo"
        Me.bthuybo.Size = New System.Drawing.Size(75, 23)
        Me.bthuybo.TabIndex = 36
        Me.bthuybo.Text = "Hủy bỏ"
        Me.bthuybo.UseVisualStyleBackColor = True
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(381, 120)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(213, 20)
        Me.txthoten.TabIndex = 33
        '
        'txtnhappass
        '
        Me.txtnhappass.Location = New System.Drawing.Point(381, 84)
        Me.txtnhappass.Name = "txtnhappass"
        Me.txtnhappass.Size = New System.Drawing.Size(213, 20)
        Me.txtnhappass.TabIndex = 32
        Me.txtnhappass.UseSystemPasswordChar = True
        '
        'txtpassdangky
        '
        Me.txtpassdangky.Location = New System.Drawing.Point(381, 50)
        Me.txtpassdangky.Name = "txtpassdangky"
        Me.txtpassdangky.Size = New System.Drawing.Size(213, 20)
        Me.txtpassdangky.TabIndex = 31
        Me.txtpassdangky.UseSystemPasswordChar = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(381, 18)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(213, 20)
        Me.txtid.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nhập lại mật khẩu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Họ và tên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Mật khẩu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ID Đăng nhập"
        '
        'DANGKYTHANHVIEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 210)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btdangky)
        Me.Controls.Add(Me.bthuybo)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtnhappass)
        Me.Controls.Add(Me.txtpassdangky)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DANGKYTHANHVIEN"
        Me.Text = "Đăng Ký Thành Viên"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btdangky As System.Windows.Forms.Button
    Friend WithEvents bthuybo As System.Windows.Forms.Button
    Friend WithEvents txthoten As System.Windows.Forms.TextBox
    Friend WithEvents txtnhappass As System.Windows.Forms.TextBox
    Friend WithEvents txtpassdangky As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
