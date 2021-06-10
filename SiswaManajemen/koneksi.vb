Imports System.Data.OleDb
Module koneksi
    Public conn As OleDbConnection
    Public dataAdapt As OleDbDataAdapter
    Public dataSet As DataSet
    Public cmd As OleDbCommand
    Public readData As OleDbDataReader

    Public Sub dbConn()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\siswa.accdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub


End Module
