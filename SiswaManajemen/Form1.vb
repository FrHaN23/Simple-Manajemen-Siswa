Public Class Main
    Dim hobi As String
    Dim kelamin As String

    Sub checkedHobi()
        If chkBoxBaca.Checked Then
            hobi &= chkBoxBaca.Text
            hobi &= ","
        End If
        If chkBoxBerkebun.Checked Then
            hobi &= chkBoxBerkebun.Text
            hobi &= ","
        End If
        If chkBoxFoto.Checked Then
            hobi &= chkBoxFoto.Text
            hobi &= ","
        End If
        If chkBoxGambar.Checked Then
            hobi &= chkBoxGambar.Text
            hobi &= ","
        End If
        If chkBoxMasak.Checked Then
            hobi &= chkBoxMasak.Text
            hobi &= ","
        End If
        If chkBoxMusik.Checked Then
            hobi &= chkBoxMusik.Text
            hobi &= ","
        End If
        If chkBoxOlah.Checked Then
            hobi &= chkBoxOlah.Text
            hobi &= ","
        End If
        If chkBoxOtomotif.Checked Then
            hobi &= chkBoxOtomotif.Text
            hobi &= ","
        End If
    End Sub
    Private Sub rdioBttnLaki_CheckedChanged(sender As Object, e As EventArgs) Handles rdioBttnLaki.CheckedChanged
        kelamin = "Laki-laki"
    End Sub

    Private Sub rdioBttnPermpu_CheckedChanged(sender As Object, e As EventArgs) Handles rdioBttnPermpu.CheckedChanged
        kelamin = "Perempuan"
    End Sub
    Sub tampilData()
        Call dbConn()
        dataAdapt = New OleDb.OleDbDataAdapter("SELECT * FROM daftarSiswa", conn)
        dataSet = New DataSet
        dataSet.Clear()
        dataAdapt.Fill(dataSet, "daftarSiswa")
        DataGridView1.DataSource = dataSet.Tables("daftarSiswa")
        DataGridView1.Refresh()
    End Sub

    Sub clearBox()
        txtBoxNama.Clear()
        txtBoxAlamat.Clear()
        txtBoxNim.Clear()
        txtBoxTelp.Clear()
        txtBoxEmail.Clear()
        kelamin = ""
        hobi = ""
        txtBoxNim.Focus()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
        txtBoxNim.Focus()
    End Sub

    Private Sub bttnSimpan_Click(sender As Object, e As EventArgs) Handles bttnSimpan.Click
        Call checkedHobi()

        If txtBoxNim.Text = "" Or txtBoxNama.Text = "" Or txtBoxAlamat.Text = "" Then
            MsgBox("data belum lengkap.")
            txtBoxNim.Focus()
        Else
            cmd = New OleDb.OleDbCommand("SELECT * FROM daftarSiswa WHERE NIM='" & txtBoxNim.Text & "'", conn)
            readData = cmd.ExecuteReader
            readData.Read()
            If readData.HasRows = False Then
                cmd = New OleDb.OleDbCommand("INSERT INTO daftarSiswa VALUES('" & txtBoxNim.Text &
                                             "','" & txtBoxNama.Text & "','" & kelamin.ToString &
                                             "','" & txtBoxAlamat.Text & "','" & txtBoxTelp.Text &
                                             "','" & txtBoxEmail.Text & "','" & hobi.ToString & "')", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan data Sukses.", MsgBoxStyle.Information, "Perhatian")
            End If
            Call tampilData()
            Call clearBox()

        End If
    End Sub

    Private Sub bttnUbah_Click(sender As Object, e As EventArgs) Handles bttnUbah.Click
        Call checkedHobi()

        If txtBoxNim.Text = "" Then
            MsgBox("NIM belum diisi")
            txtBoxNim.Focus()
        Else
            cmd = New OleDb.OleDbCommand("UPDATE daftarSiswa SET Nama='" & txtBoxNama.Text &
                                         "', Kelamin='" & kelamin.ToString &
                                         "', Alamat='" & txtBoxAlamat.Text &
                                         "', Telp='" & txtBoxTelp.Text &
                                         "', email='" & txtBoxEmail.Text &
                                         "', hobi='" & hobi.ToString &
                                         "' WHERE NIM='" & txtBoxNim.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diubah.", MsgBoxStyle.Information, "Perhatian")
        End If
        Call tampilData()
        Call clearBox()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtBoxNim.Text = DataGridView1.Item(0, i).Value
        txtBoxNama.Text = DataGridView1.Item(1, i).Value
        txtBoxAlamat.Text = DataGridView1.Item(3, i).Value
        txtBoxTelp.Text = DataGridView1.Item(4, i).Value
        txtBoxEmail.Text = DataGridView1.Item(5, i).Value

    End Sub

    Private Sub bttnKeluar_Click(sender As Object, e As EventArgs) Handles bttnKeluar.Click
        End
    End Sub

    Private Sub bttnHapus_Click(sender As Object, e As EventArgs) Handles bttnHapus.Click
        Call checkedHobi()

        If txtBoxNim.Text = "" Then
            MsgBox("NIM belum diisi")
            txtBoxNim.Focus()
        Else
            If MessageBox.Show("Anda yakin menghapus data siswa dengan NIM " & txtBoxNim.Text &
                               "?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then


                cmd = New OleDb.OleDbCommand("DELETE * FROM daftarSiswa WHERE NIM='" & txtBoxNim.Text &
                                             "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diubah.", MsgBoxStyle.Information, "Perhatian")

            End If
        End If
        Call tampilData()
        Call clearBox()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            Call checkedHobi()
            cmd = New OleDb.OleDbCommand("SELECT * FROM daftarSiswa WHERE nama Like '%" & txtCari.Text &
                                         "%'", conn)
            readData = cmd.ExecuteReader
            readData.Read()
            If readData.HasRows = True Then
                dataSet = New DataSet
                dataAdapt.Fill(dataSet, "daftarSiswa")
                DataGridView1.DataSource = dataSet.Tables("daftarSiswa")
                DataGridView1.ReadOnly = True
            Else
                MsgBox("data tidak ada.")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub bttnCari_Click(sender As Object, e As EventArgs) Handles bttnCari.Click
        Call checkedHobi()
        cmd = New OleDb.OleDbCommand("SELECT * FROM daftarSiswa WHERE nama Like '%" & txtCari.Text &
                                     "%'", conn)
        readData = cmd.ExecuteReader
        readData.Read()
        If readData.HasRows = True Then
            dataSet = New DataSet
            dataAdapt.Fill(dataSet, "daftarSiswa")
            DataGridView1.DataSource = dataSet.Tables("daftarSiswa")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("data tidak ada.")
        End If
    End Sub

    Private Sub txtBoxNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxNim.KeyPress
        If e.KeyChar = Chr(13) Then
            Call checkedHobi()
            cmd = New OleDb.OleDbCommand("SELECT * FROM daftarSiswa WHERE NIM Like '%" & txtBoxNim.Text &
                                     "%'", conn)
            readData = cmd.ExecuteReader
            readData.Read()
            If readData.HasRows = True Then
                txtBoxNama.Text = readData.Item(1)
                txtBoxNama.Focus()

            Else
                txtBoxNama.Focus()

            End If
        End If
    End Sub
End Class
