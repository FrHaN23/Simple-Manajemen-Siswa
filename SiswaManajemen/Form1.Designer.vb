<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.txtBoxNim = New System.Windows.Forms.TextBox()
        Me.rdioBttnLaki = New System.Windows.Forms.RadioButton()
        Me.chkBoxBaca = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxAlamat = New System.Windows.Forms.TextBox()
        Me.txtBoxNama = New System.Windows.Forms.TextBox()
        Me.rdioBttnPermpu = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBoxTelp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkBoxGambar = New System.Windows.Forms.CheckBox()
        Me.chkBoxMasak = New System.Windows.Forms.CheckBox()
        Me.chkBoxFoto = New System.Windows.Forms.CheckBox()
        Me.chkBoxBerkebun = New System.Windows.Forms.CheckBox()
        Me.chkBoxOtomotif = New System.Windows.Forms.CheckBox()
        Me.chkBoxOlah = New System.Windows.Forms.CheckBox()
        Me.chkBoxMusik = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bttnUbah = New System.Windows.Forms.Button()
        Me.bttnSimpan = New System.Windows.Forms.Button()
        Me.bttnHapus = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.bttnCari = New System.Windows.Forms.Button()
        Me.bttnKeluar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBoxNim
        '
        Me.txtBoxNim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxNim.Location = New System.Drawing.Point(151, 24)
        Me.txtBoxNim.Name = "txtBoxNim"
        Me.txtBoxNim.Size = New System.Drawing.Size(115, 22)
        Me.txtBoxNim.TabIndex = 0
        '
        'rdioBttnLaki
        '
        Me.rdioBttnLaki.AutoSize = True
        Me.rdioBttnLaki.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdioBttnLaki.Location = New System.Drawing.Point(151, 101)
        Me.rdioBttnLaki.Name = "rdioBttnLaki"
        Me.rdioBttnLaki.Size = New System.Drawing.Size(80, 20)
        Me.rdioBttnLaki.TabIndex = 1
        Me.rdioBttnLaki.TabStop = True
        Me.rdioBttnLaki.Text = "Laki-Laki"
        Me.rdioBttnLaki.UseVisualStyleBackColor = True
        '
        'chkBoxBaca
        '
        Me.chkBoxBaca.AutoSize = True
        Me.chkBoxBaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxBaca.Location = New System.Drawing.Point(9, 8)
        Me.chkBoxBaca.Name = "chkBoxBaca"
        Me.chkBoxBaca.Size = New System.Drawing.Size(59, 20)
        Me.chkBoxBaca.TabIndex = 2
        Me.chkBoxBaca.Text = "Baca"
        Me.chkBoxBaca.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 469)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 232)
        Me.DataGridView1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jenis Kelamin"
        '
        'txtBoxAlamat
        '
        Me.txtBoxAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxAlamat.Location = New System.Drawing.Point(151, 138)
        Me.txtBoxAlamat.Multiline = True
        Me.txtBoxAlamat.Name = "txtBoxAlamat"
        Me.txtBoxAlamat.Size = New System.Drawing.Size(238, 57)
        Me.txtBoxAlamat.TabIndex = 7
        '
        'txtBoxNama
        '
        Me.txtBoxNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxNama.Location = New System.Drawing.Point(151, 62)
        Me.txtBoxNama.Name = "txtBoxNama"
        Me.txtBoxNama.Size = New System.Drawing.Size(192, 22)
        Me.txtBoxNama.TabIndex = 9
        '
        'rdioBttnPermpu
        '
        Me.rdioBttnPermpu.AutoSize = True
        Me.rdioBttnPermpu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdioBttnPermpu.Location = New System.Drawing.Point(254, 101)
        Me.rdioBttnPermpu.Name = "rdioBttnPermpu"
        Me.rdioBttnPermpu.Size = New System.Drawing.Size(96, 20)
        Me.rdioBttnPermpu.TabIndex = 10
        Me.rdioBttnPermpu.TabStop = True
        Me.rdioBttnPermpu.Text = "Perempuan"
        Me.rdioBttnPermpu.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nomor Telepon"
        '
        'txtBoxTelp
        '
        Me.txtBoxTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxTelp.Location = New System.Drawing.Point(151, 212)
        Me.txtBoxTelp.Name = "txtBoxTelp"
        Me.txtBoxTelp.Size = New System.Drawing.Size(130, 22)
        Me.txtBoxTelp.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Alamat Email"
        '
        'txtBoxEmail
        '
        Me.txtBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxEmail.Location = New System.Drawing.Point(151, 251)
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.Size = New System.Drawing.Size(167, 22)
        Me.txtBoxEmail.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Hobi"
        '
        'chkBoxGambar
        '
        Me.chkBoxGambar.AutoSize = True
        Me.chkBoxGambar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxGambar.Location = New System.Drawing.Point(9, 34)
        Me.chkBoxGambar.Name = "chkBoxGambar"
        Me.chkBoxGambar.Size = New System.Drawing.Size(108, 20)
        Me.chkBoxGambar.TabIndex = 17
        Me.chkBoxGambar.Text = "Menggambar"
        Me.chkBoxGambar.UseVisualStyleBackColor = True
        '
        'chkBoxMasak
        '
        Me.chkBoxMasak.AutoSize = True
        Me.chkBoxMasak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxMasak.Location = New System.Drawing.Point(131, 8)
        Me.chkBoxMasak.Name = "chkBoxMasak"
        Me.chkBoxMasak.Size = New System.Drawing.Size(68, 20)
        Me.chkBoxMasak.TabIndex = 18
        Me.chkBoxMasak.Text = "Masak"
        Me.chkBoxMasak.UseVisualStyleBackColor = True
        '
        'chkBoxFoto
        '
        Me.chkBoxFoto.AutoSize = True
        Me.chkBoxFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxFoto.Location = New System.Drawing.Point(131, 34)
        Me.chkBoxFoto.Name = "chkBoxFoto"
        Me.chkBoxFoto.Size = New System.Drawing.Size(80, 20)
        Me.chkBoxFoto.TabIndex = 19
        Me.chkBoxFoto.Text = "Fotografi"
        Me.chkBoxFoto.UseVisualStyleBackColor = True
        '
        'chkBoxBerkebun
        '
        Me.chkBoxBerkebun.AutoSize = True
        Me.chkBoxBerkebun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxBerkebun.Location = New System.Drawing.Point(131, 85)
        Me.chkBoxBerkebun.Name = "chkBoxBerkebun"
        Me.chkBoxBerkebun.Size = New System.Drawing.Size(85, 20)
        Me.chkBoxBerkebun.TabIndex = 23
        Me.chkBoxBerkebun.Text = "Berkebun"
        Me.chkBoxBerkebun.UseVisualStyleBackColor = True
        '
        'chkBoxOtomotif
        '
        Me.chkBoxOtomotif.AutoSize = True
        Me.chkBoxOtomotif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxOtomotif.Location = New System.Drawing.Point(131, 59)
        Me.chkBoxOtomotif.Name = "chkBoxOtomotif"
        Me.chkBoxOtomotif.Size = New System.Drawing.Size(76, 20)
        Me.chkBoxOtomotif.TabIndex = 22
        Me.chkBoxOtomotif.Text = "Otomotif"
        Me.chkBoxOtomotif.UseVisualStyleBackColor = True
        '
        'chkBoxOlah
        '
        Me.chkBoxOlah.AutoSize = True
        Me.chkBoxOlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxOlah.Location = New System.Drawing.Point(9, 85)
        Me.chkBoxOlah.Name = "chkBoxOlah"
        Me.chkBoxOlah.Size = New System.Drawing.Size(83, 20)
        Me.chkBoxOlah.TabIndex = 21
        Me.chkBoxOlah.Text = "Olahraga"
        Me.chkBoxOlah.UseVisualStyleBackColor = True
        '
        'chkBoxMusik
        '
        Me.chkBoxMusik.AutoSize = True
        Me.chkBoxMusik.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxMusik.Location = New System.Drawing.Point(9, 59)
        Me.chkBoxMusik.Name = "chkBoxMusik"
        Me.chkBoxMusik.Size = New System.Drawing.Size(62, 20)
        Me.chkBoxMusik.TabIndex = 20
        Me.chkBoxMusik.Text = "Musik"
        Me.chkBoxMusik.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkBoxBerkebun)
        Me.GroupBox1.Controls.Add(Me.chkBoxOtomotif)
        Me.GroupBox1.Controls.Add(Me.chkBoxOlah)
        Me.GroupBox1.Controls.Add(Me.chkBoxMusik)
        Me.GroupBox1.Controls.Add(Me.chkBoxFoto)
        Me.GroupBox1.Controls.Add(Me.chkBoxMasak)
        Me.GroupBox1.Controls.Add(Me.chkBoxGambar)
        Me.GroupBox1.Controls.Add(Me.chkBoxBaca)
        Me.GroupBox1.Location = New System.Drawing.Point(151, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 121)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'bttnUbah
        '
        Me.bttnUbah.Location = New System.Drawing.Point(128, 437)
        Me.bttnUbah.Name = "bttnUbah"
        Me.bttnUbah.Size = New System.Drawing.Size(80, 26)
        Me.bttnUbah.TabIndex = 26
        Me.bttnUbah.Text = "Ubah"
        Me.bttnUbah.UseVisualStyleBackColor = True
        '
        'bttnSimpan
        '
        Me.bttnSimpan.Location = New System.Drawing.Point(47, 436)
        Me.bttnSimpan.Name = "bttnSimpan"
        Me.bttnSimpan.Size = New System.Drawing.Size(75, 27)
        Me.bttnSimpan.TabIndex = 27
        Me.bttnSimpan.Text = "Simpan"
        Me.bttnSimpan.UseVisualStyleBackColor = True
        '
        'bttnHapus
        '
        Me.bttnHapus.Location = New System.Drawing.Point(214, 437)
        Me.bttnHapus.Name = "bttnHapus"
        Me.bttnHapus.Size = New System.Drawing.Size(82, 26)
        Me.bttnHapus.TabIndex = 28
        Me.bttnHapus.Text = "Hapus"
        Me.bttnHapus.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(302, 438)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(413, 22)
        Me.txtCari.TabIndex = 29
        '
        'bttnCari
        '
        Me.bttnCari.Location = New System.Drawing.Point(721, 438)
        Me.bttnCari.Name = "bttnCari"
        Me.bttnCari.Size = New System.Drawing.Size(58, 23)
        Me.bttnCari.TabIndex = 30
        Me.bttnCari.Text = "Cari"
        Me.bttnCari.UseVisualStyleBackColor = True
        '
        'bttnKeluar
        '
        Me.bttnKeluar.Location = New System.Drawing.Point(785, 649)
        Me.bttnKeluar.Name = "bttnKeluar"
        Me.bttnKeluar.Size = New System.Drawing.Size(65, 52)
        Me.bttnKeluar.TabIndex = 31
        Me.bttnKeluar.Text = "Keluar"
        Me.bttnKeluar.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(867, 713)
        Me.Controls.Add(Me.bttnKeluar)
        Me.Controls.Add(Me.bttnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.bttnHapus)
        Me.Controls.Add(Me.bttnSimpan)
        Me.Controls.Add(Me.bttnUbah)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBoxEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBoxTelp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rdioBttnPermpu)
        Me.Controls.Add(Me.txtBoxNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBoxAlamat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.rdioBttnLaki)
        Me.Controls.Add(Me.txtBoxNim)
        Me.Name = "Main"
        Me.Text = "Manajemen Siswa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBoxNim As TextBox
    Friend WithEvents rdioBttnLaki As RadioButton
    Friend WithEvents chkBoxBaca As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxAlamat As TextBox
    Friend WithEvents txtBoxNama As TextBox
    Friend WithEvents rdioBttnPermpu As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBoxTelp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBoxEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chkBoxGambar As CheckBox
    Friend WithEvents chkBoxMasak As CheckBox
    Friend WithEvents chkBoxFoto As CheckBox
    Friend WithEvents chkBoxBerkebun As CheckBox
    Friend WithEvents chkBoxOtomotif As CheckBox
    Friend WithEvents chkBoxOlah As CheckBox
    Friend WithEvents chkBoxMusik As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bttnUbah As Button
    Friend WithEvents bttnSimpan As Button
    Friend WithEvents bttnHapus As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents bttnCari As Button
    Friend WithEvents bttnKeluar As Button
End Class
