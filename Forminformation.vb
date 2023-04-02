Imports MySql.Data.MySqlClient

Public Class Forminformation

    Dim connect As MySqlConnection
    Dim constring As String = "server=db4free.net;port=3306;user=echoop01;password=EchooP0126;database=student_system"
    Dim conadapter As New MySqlDataAdapter
    Dim data As New DataTable
    Dim CMD As New MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()

            Dim SQL As String = "UPDATE student_info SET Firstname=@FirstName, Lastname=@LastName, Suffix=@Suffix, Gender=@Gender, Birthday=@Birthday, Contact_Number=@ContactNumber, Address=@Address WHERE Student_Number=@StudentNumber"
            CMD = New MySqlCommand(SQL, connect)

            Dim dcm As MySqlCommand

            Dim qsl As String = "UPDATE student_grades SET Firstname=@FirstName, Lastname=@LastName WHERE ID=@ID"
            dcm = New MySqlCommand(qsl, connect)

            ' Set the parameter values
            CMD.Parameters.AddWithValue("@FirstName", fnametxt.Text)
            CMD.Parameters.AddWithValue("@LastName", lnametxt.Text)
            CMD.Parameters.AddWithValue("@Suffix", suffixtxt.Text)
            CMD.Parameters.AddWithValue("@Gender", ComboBox1.SelectedItem.ToString())
            CMD.Parameters.AddWithValue("@Birthday", TextBox1.Text)
            CMD.Parameters.AddWithValue("@ContactNumber", contacttxt.Text)
            CMD.Parameters.AddWithValue("@Address", addresstxt.Text)
            CMD.Parameters.AddWithValue("@StudentNumber", idtxt.Text)

            dcm.Parameters.AddWithValue("@FirstName", fnametxt.Text)
            dcm.Parameters.AddWithValue("@LastName", lnametxt.Text)
            dcm.Parameters.AddWithValue("@ID", idtxt.Text)

            Dim i As Integer = CMD.ExecuteNonQuery()
            Dim v As Integer = dcm.ExecuteNonQuery()
            If i & v <> 0 Then
                msgbox2.Show()
                'Call Public Sub in Record Form
                Dim recordForm As Records = CType(Application.OpenForms("Records"), Records)
                recordForm.LoadData()
                Me.Close()
            Else
                MsgBox("Student Information Not Updated!!", vbCritical, "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connect.Close()
        End Try

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ' Create a new instance of the OpenFileDialog control
        Dim openFileDialog As New OpenFileDialog()

        ' Set the filter to allow only image files
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png"

        ' Display the OpenFileDialog control and get the result
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image file into a Bitmap object
            Dim selectedImage As New Bitmap(openFileDialog.FileName)

            ' Set the selected image as the Image property of the PictureBox control
            PictureBox2.Image = selectedImage

            ' Set the SizeMode property of the PictureBox control to automatically resize the image to fill the entire control
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class
