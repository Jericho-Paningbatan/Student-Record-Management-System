Imports MySql.Data.MySqlClient

Public Class Login
#Region "Declares"

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using connection As New MySqlConnection("server=db4free.net;port=3306;user=echoop01;password=EchooP0126;database=student_system")
                Await connection.OpenAsync()

                Using command As New MySqlCommand("SELECT * FROM admin_account WHERE Username = @Username AND Password = @Password", connection)
                    command.Parameters.AddWithValue("@Username", TextBox1.Text)
                    command.Parameters.AddWithValue("@Password", TextBox2.Text)

                    Dim data As New DataTable()
                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(data)

                    If data.Rows.Count() <= 0 Then
                        MessageBox.Show("Invalid Username or Password")
                    Else
                        MessageBox.Show("Welcome to Your Dashboard Admin!!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TextBox1.Clear()
                        TextBox2.Clear()
                        Me.Hide()
                        Dim dashboardForm As New Dashboard()
                        dashboardForm.Show()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect As Rectangle = Me.ClientRectangle
        Dim radius As Integer = 20
        Dim diameter As Integer = radius * 2

        ' Top left arc
        path.AddArc(rect.Left, rect.Top, diameter, diameter, 180, 90)

        ' Top edge
        path.AddLine(rect.Left + radius, rect.Top, rect.Right - radius, rect.Top)

        ' Top right arc
        path.AddArc(rect.Right - diameter, rect.Top, diameter, diameter, 270, 90)

        ' Right edge
        path.AddLine(rect.Right, rect.Top + radius, rect.Right, rect.Bottom - radius)

        ' Bottom right arc
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)

        ' Bottom edge
        path.AddLine(rect.Right - radius, rect.Bottom, rect.Left + radius, rect.Bottom)

        ' Bottom left arc
        path.AddArc(rect.Left, rect.Bottom - diameter, diameter, diameter, 90, 90)

        ' Left edge
        path.AddLine(rect.Left, rect.Bottom - radius, rect.Left, rect.Top + radius)

        Me.Region = New Region(path)

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

#End Region
End Class