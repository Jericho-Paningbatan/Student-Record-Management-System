Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class DBConnect
    Private conn As SqlConnection

    Public Sub New()
        conn = New SqlConnection("Data Source=db4free.net;Initial Catalog=student_system;User ID=echoop01;Password=EchooP0126;")
    End Sub

    Public Function GetConnection() As SqlConnection
        Return conn
    End Function
End Class

