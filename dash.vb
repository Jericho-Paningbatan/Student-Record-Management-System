Imports MySql.Data.MySqlClient

Public Class dash


    Dim constring As String = "server=db4free.net;port=3306;user=echoop01;password=EchooP0126;database=student_system"
    Dim conadapter As New MySqlDataAdapter
    Dim data As New DataTable




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label5.Text = DateTime.Now.ToString("MMMM dd yyyy")
        Label6.Text = DateTime.Now.ToString("hh:mm tt ")

    End Sub






    Private last_update As DateTime = DateTime.MinValue



    Private Sub dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True

    End Sub

    Private Function CountRecords() As Integer
        Dim count As Integer = 0
        Using connection As New MySqlConnection(constring)
            connection.Open()
            Dim commandText As String = "SELECT COUNT(*) FROM student_info"
            Using command As New MySqlCommand(commandText, connection)
                count = CInt(command.ExecuteScalar())
            End Using
        End Using
        Return count
    End Function

    Private Sub UpdateRecordCountLabel()
        Dim recordCount As Integer = CountRecords()
        updatelbl.Text = recordCount.ToString()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim conn As MySqlConnection = New MySqlConnection(constring)
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT COUNT(*) FROM student_info", conn)
        conn.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        conn.Close()
        updatelbl.Text = count.ToString()
    End Sub

End Class