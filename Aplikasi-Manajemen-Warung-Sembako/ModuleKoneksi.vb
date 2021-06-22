Imports System.Data.Odbc

Module ModuleKoneksi

    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public da As OdbcDataAdapter
    Public dr As OdbcDataReader
    Public ds As DataSet
    Public dt As New DataTable
    Public str As String
    Public x As Integer

    Sub konek()
        Dim lokasidata As String

        lokasidata = "Driver={MySQL ODBC 3.51 Driver};Database=databasewarungkito;server=localhost;uid=root"
        conn = New OdbcConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else

        End If
    End Sub

End Module
