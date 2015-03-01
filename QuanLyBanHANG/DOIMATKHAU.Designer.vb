<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOIMATKHAU
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtiddmk = New System.Windows.Forms.TextBox()
        Me.txtpasscudmk = New System.Windows.Forms.TextBox()
        Me.txtpassmoidmk = New System.Windows.Forms.TextBox()
        Me.txtrepassmoidmk = New System.Windows.Forms.TextBox()
        Me.Hủy = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Đăng Nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật khẩu cũ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mật khẩu mới"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nhập lại mật khẩu mới"
        '
        'txtiddmk
        '
        Me.txtiddmk.Location = New System.Drawing.Point(161, 16)
        Me.txtiddmk.Name = "txtiddmk"
        Me.txtiddmk.Size = New System.Drawing.Size(199, 20)
        Me.txtiddmk.TabIndex = 6
        '
        'txtpasscudmk
        '
        Me.txtpasscudmk.Location = New System.Drawing.Point(161, 54)
        Me.txtpasscudmk.Name = "txtpasscudmk"
        Me.txtpasscudmk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpasscudmk.Size = New System.Drawing.Size(199, 20)
        Me.txtpasscudmk.TabIndex = 32
        Me.txtpasscudmk.UseSystemPasswordChar = True
        '
        'txtpassmoidmk
        '
        Me.txtpassmoidmk.Location = New System.Drawing.Point(159, 91)
        Me.txtpassmoidmk.Name = "txtpassmoidmk"
        Me.txtpassmoidmk.Size = New System.Drawing.Size(201, 20)
        Me.txtpassmoidmk.TabIndex = 33
        Me.txtpassmoidmk.UseSystemPasswordChar = True
        '
        'txtrepassmoidmk
        '
        Me.txtrepassmoidmk.Location = New System.Drawing.Point(159, 127)
        Me.txtrepassmoidmk.Name = "txtrepassmoidmk"
        Me.txtrepassmoidmk.Size = New System.Drawing.Size(201, 20)
        Me.txtrepassmoidmk.TabIndex = 34
        Me.txtrepassmoidmk.UseSystemPasswordChar = True
        '
        'Hủy
        '
        Me.Hủy.Location = New System.Drawing.Point(60, 172)
        Me.Hủy.Name = "Hủy"
        Me.Hủy.Size = New System.Drawing.Size(75, 23)
        Me.Hủy.TabIndex = 35
        Me.Hủy.Text = "Hủy"
        Me.Hủy.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(248, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Đồng Ý"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DOIMATKHAU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 213)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Hủy)
        Me.Controls.Add(Me.txtrepassmoidmk)
        Me.Controls.Add(Me.txtpassmoidmk)
        Me.Controls.Add(Me.txtpasscudmk)
        Me.Controls.Add(Me.txtiddmk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DOIMATKHAU"
        Me.Text = "Đổi Mật Khẩu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtiddmk As System.Windows.Forms.TextBox
    Friend WithEvents txtpasscudmk As System.Windows.Forms.TextBox
    Friend WithEvents txtpassmoidmk As System.Windows.Forms.TextBox
    Friend WithEvents txtrepassmoidmk As System.Windows.Forms.TextBox
    Friend WithEvents Hủy As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
