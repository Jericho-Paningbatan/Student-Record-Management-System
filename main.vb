Imports MySql.Data.MySqlClient



Public Class main
#Region "Declacres"

    Dim connect As MySqlConnection
    Dim constring As String = "server=db4free.net;port=3306;user=echoop01;password=EchooP0126;database=student_system"
    Dim conadapter As New MySqlDataAdapter
    Dim data As New DataTable
    Dim CMD As New MySqlCommand





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then

            MsgBox("Please Fill Up all the Fields", vbCritical, "Error")

        ElseIf TextBox2.Text = "" Then

            MsgBox("Please Fill Up all the Fields", vbCritical, "Error")

        ElseIf TextBox4.Text = "" Then

            MsgBox("Please Fill Up all the Fields", vbCritical, "Error")
        ElseIf TextBox5.Text = "" Then

            MsgBox("Please Fill Up all the Fields", vbCritical, "Error")
        ElseIf ComboBox1.Text = "" Then

            MsgBox("Please Fill Up all the Fields", vbCritical, "Error")



        Else

            Try


                ' Convert the image to a byte array
                Dim ms As New System.IO.MemoryStream()
                PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
                Dim imageBytes As Byte() = ms.ToArray()
                Dim DMC As New MySqlCommand

                connect = New MySqlConnection(constring)
                connect.Open()
                ' Insert the byte array into a BLOB column in the database
                Dim SQL As String = "INSERT INTO student_info (Firstname, Lastname, Suffix, Gender, Birthday, Contact_Number, Address, Profiles) VALUES (@Firstname, @Lastname, @Suffix, @Gender, @Birthday, @Contact_Number, @Address, @Picture)"
                CMD = New MySqlCommand(SQL, connect)
                CMD.Parameters.AddWithValue("@Firstname", TextBox1.Text)
                CMD.Parameters.AddWithValue("@Lastname", TextBox2.Text)
                CMD.Parameters.AddWithValue("@Suffix", TextBox3.Text)
                CMD.Parameters.AddWithValue("@Gender", ComboBox1.SelectedItem)
                CMD.Parameters.AddWithValue("@Birthday", MaskedTextBox1.Text)
                CMD.Parameters.AddWithValue("@Contact_Number", TextBox4.Text)
                CMD.Parameters.AddWithValue("@Address", TextBox5.Text)
                CMD.Parameters.AddWithValue("@Picture", imageBytes)

                Dim qsl As String = "INSERT INTO student_grades (Firstname, Lastname, Prelim_Grade, Midterm_Grade, Final_Grade, Total_Grade, Remark) VALUES (@Firstname, @Lastname, @Prelim_Grade, @Midterm_Grade, @Final_Grade, @Total_Grade, @Remark)"
                DMC = New MySqlCommand(qsl, connect)
                DMC.Parameters.AddWithValue("@Firstname", TextBox1.Text)
                DMC.Parameters.AddWithValue("@Lastname", TextBox2.Text)
                DMC.Parameters.AddWithValue("@Prelim_Grade", 0.0)
                DMC.Parameters.AddWithValue("@Midterm_Grade", 0.0)
                DMC.Parameters.AddWithValue("@Final_Grade", 0.0)
                DMC.Parameters.AddWithValue("@Total_Grade", 0.0)
                DMC.Parameters.AddWithValue("@Remark", "Failed")

                Dim i As Integer = CMD.ExecuteNonQuery
                Dim a As Integer = DMC.ExecuteNonQuery
                connect.Close()

                If i & a <> 0 Then
                    MsgBox("Student Information Added Successfully!!", vbInformation, "Recorded Successful")
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    TextBox5.Text = ""
                    MaskedTextBox1.Text = ""
                    ComboBox1.Text = ""
                    PictureBox2.Image = Nothing

                    'Call Public Sub in Record Form
                    Dim recordsForm As New Records()
                    Records.LoadData()

                Else
                    MsgBox("Student Information Not Recorded!!", vbCritical, "Error")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If






    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MaskedTextBox1.Mask = "00/00/0000"
        MaskedTextBox1.PromptChar = "-"
        MaskedTextBox1.Text = "MM-DD-YYYY"



        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        TextBox1.Text = "Firstname"
        TextBox2.Text = "Lastname"

        TextBox4.Text = "Contact Number"
        TextBox5.Text = "Address"

        TextBox1.ForeColor = Color.Gray
        TextBox2.ForeColor = Color.Gray

        TextBox3.ForeColor = Color.Gray
        TextBox4.ForeColor = Color.Gray

        TextBox5.ForeColor = Color.Gray



    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If String.IsNullOrEmpty(TextBox1.Text) Then
            TextBox3.Text = "N/A"
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Firstname" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Firstname"
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "Lastname" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "Lastname"

            TextBox2.ForeColor = Color.Gray
        End If
    End Sub




    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        If TextBox4.Text = "Contact Number" Then
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black

        End If
    End Sub

    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles TextBox4.LostFocus
        If TextBox4.Text = "" Then
            TextBox4.Text = "Contact Number"

            TextBox4.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox5_GotFocus(sender As Object, e As EventArgs) Handles TextBox5.GotFocus
        If TextBox5.Text = "Address" Then
            TextBox5.Text = ""
            TextBox5.ForeColor = Color.Black

        End If
    End Sub

    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
        If TextBox5.Text = "" Then
            TextBox5.Text = "Address"

            TextBox5.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        ' Create a new instance of the OpenFileDialog control
        Dim openFileDialog As New OpenFileDialog()

        ' Set the filter to allow only image files
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png"

        ' Display the OpenFileDialog control and get the result
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image file into a Bitmap object
            Dim selectedImage As New Bitmap(OpenFileDialog.FileName)

            ' Set the selected image as the Image property of the PictureBox control
            PictureBox2.Image = selectedImage

            ' Set the SizeMode property of the PictureBox control to automatically resize the image to fill the entire control
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

        End If



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub




#End Region
End Class