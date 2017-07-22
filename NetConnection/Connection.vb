Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Npgsql

Module Connection
    Dim db_string As String
    Dim Conn1 As OleDbConnection    '' Access DB
    Dim Conn2 As SqlConnection      '' Ms SQL Server
    Dim Conn3 As MySqlConnection    '' Mysql
    Dim Conn4 As NpgsqlConnection   '' PostgreSQL

    Sub DBConn_Accdb() '' Connection For Access DB
        db_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Net\tarman.accdb;"
        Conn1 = New OleDbConnection(db_string)

        Try
            Conn1.Open()
            MsgBox("DB Access Success")
        Catch ex As OleDbException
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub DBConn_MsSQL()  ''COnnection For Ms SQL Server
        db_string = "Data Source=YOURPC\SQLEXPRESS;Initial Catalog=customer;User ID=sa;Password=12345;"
        Conn2 = New SqlConnection(db_string)

        Try
            Conn2.Open()
            MsgBox("Ms SQL Server Success")
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub DBConn_MySQL() '' Connection Mysql
        db_string = "server=localhost;user=root;password=yourpassword;port=3307;database=ma star;"
        Conn3 = New MySqlConnection(db_string)
        Try
            Conn3.Open()
            MsgBox("MySQL Success")
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub DBConn_PgSQL()
        db_string = "Server=localhost;Port=5432;Database=customer;username=postgres;password=yourpassword"
        Conn4 = New NpgsqlConnection(db_string)

        Try
            Conn4.Open()
            MsgBox("PostgreSQL Succes")
        Catch ex As NpgsqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
