Imports MySql.Data.MySqlClient

Public Class DatabaseConn

    Private ReadOnly connectionStringBuilder As New MySqlConnectionStringBuilder With {
        .Server = "db4free.net",
        .Port = 3306,
        .UserID = "echoop01",
        .Password = "EchooP0126",
        .Database = "student_system"
    }

    Public Function Open() As MySqlConnection
        Dim connection As New MySqlConnection(connectionStringBuilder.ConnectionString)
        Try
            connection.Open()
        Catch ex As Exception
            ' Log the error or display a generic error message to the user
        End Try
        Return connection
    End Function

    Public Function Close() As MySqlConnection
        Dim connection As New MySqlConnection(connectionStringBuilder.ConnectionString)
        Try
            connection.Close()
        Catch ex As Exception
            ' Log the error or display a generic error message to the user
        End Try
        Return connection
    End Function

End Class


