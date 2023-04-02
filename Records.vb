Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Records

	Dim CONNECT As MySqlConnection
	Dim constring As String = "server=db4free.net;port=3306;user=echoop01;password=EchooP0126;database=student_system"
	Dim CMD As MySqlCommand
	Dim itemcoll(999) As String
	Dim da As MySqlDataAdapter
	Dim ds As DataSet
	Private dt As New DataTable()
	Private du As New DataTable()






	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick






		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			' Check if the clicked cell is in the first button column
			If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "Information" Then
				' Handle the click for the first button column


				' Check if the clicked cell is a button
				If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
					' Get the selected row in the DataGridView
					Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

					' Get the value of the cell containing the information you want to display
					Dim one As String = selectedRow.Cells("Student_Number").Value.ToString()
					Dim two As String = selectedRow.Cells("Firstname").Value.ToString()
					Dim three As String = selectedRow.Cells("Lastname").Value.ToString()
					Dim four As String = selectedRow.Cells("Suffix").Value.ToString()
					Dim five As String = selectedRow.Cells("Gender").Value.ToString()
					Dim six As String = selectedRow.Cells("Birthday").Value.ToString()
					Dim seven As String = selectedRow.Cells("Contact_Number").Value.ToString()
					Dim eight As String = selectedRow.Cells("Address").Value.ToString()

					' Get the value of the Profile column as a byte array
					Dim profile As Byte() = DirectCast(selectedRow.Cells("Profiles").Value, Byte())

					' Create a new instance of Form2 and set the value of the TextBox and PictureBox controls
					Dim form2 As New Forminformation()
					form2.idtxt.Text = one
					form2.fnametxt.Text = two
					form2.lnametxt.Text = three
					form2.suffixtxt.Text = four
					form2.ComboBox1.Text = five
					form2.TextBox1.Text = six
					form2.contacttxt.Text = seven
					form2.addresstxt.Text = eight

					If profile IsNot Nothing Then
						' Convert the byte array to a MemoryStream
						Dim ms As New MemoryStream(profile)

						' Set the Image property of the PictureBox control using the MemoryStream
						form2.PictureBox2.Image = Image.FromStream(ms)
						form2.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
					End If

					' Show Form2
					form2.Show()
				End If

			End If



		End If


		If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "Delete" Then

			'Delete Item in Database
			If e.ColumnIndex = DataGridView1.Columns("Delete").Index AndAlso e.RowIndex >= 0 Then
				Dim primaryKey As Integer = DataGridView1.Rows(e.RowIndex).Cells("Student_Number").Value

				Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
				If result = DialogResult.Yes Then
					Dim connString As String = "server=db4free.net;port=3306;user=echoop01;password=EchooP0126;database=student_system"
					Dim query As String = "DELETE FROM student_info WHERE Student_Number = @primaryKey"
					Using conn As New MySqlConnection(connString), cmd As New MySqlCommand(query, conn)
						cmd.Parameters.AddWithValue("@primaryKey", primaryKey)
						conn.Open()
						cmd.ExecuteNonQuery()
						conn.Close()
					End Using

					DataGridView1.Rows.RemoveAt(e.RowIndex)
				End If
			End If


		End If



	End Sub




	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		' Show a dialog box to let the user choose the save location and name
		Dim saveFileDialog As New SaveFileDialog()
		saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
		If saveFileDialog.ShowDialog() = DialogResult.OK Then
			' Open a stream writer to write the data to the file
			Using writer As New StreamWriter(saveFileDialog.FileName)
				' Write the header row
				For Each headerCell As DataGridViewColumn In DataGridView1.Columns
					If Not headerCell.HeaderText.Equals("") AndAlso Not headerCell.HeaderText.Equals("") Then ' Exclude the columns with the header text "ButtonColumn" and "Column2"
						writer.Write(headerCell.HeaderText)
						writer.Write(vbTab)
					End If
				Next
				writer.WriteLine()

				' Write the data rows
				For Each row As DataGridViewRow In DataGridView1.Rows
					For Each cell As DataGridViewCell In row.Cells
						If Not DataGridView1.Columns(cell.ColumnIndex).HeaderText.Equals("") AndAlso Not DataGridView1.Columns(cell.ColumnIndex).HeaderText.Equals("") Then ' Exclude the columns with the header text "ButtonColumn" and "Column2"
							writer.Write(cell.Value)
							writer.Write(vbTab)
						End If
					Next
					writer.WriteLine()
				Next
			End Using
		End If
	End Sub

	Private Sub Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load



		DataGridView2.EditMode = DataGridViewEditMode.EditOnEnter


		LoadData()

		' Establish a connection to the database
		Dim connectionString As String = "server=db4free.net;user=echoop01;password=EchooP0126;database=student_system;port=3306"
		Dim connection As MySqlConnection = New MySqlConnection(connectionString)

		' Retrieve the data from the database
		Dim query As String = "SELECT * FROM student_grades"
		Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(query, connection)
		Dim dataSet As DataSet = New DataSet()
		adapter.Fill(dataSet, "student_grades")
		DataGridView2.DataSource = dataSet.Tables("student_grades")

		' Subscribe to the DataGridView's CellValueChanged event
		AddHandler DataGridView2.CellValueChanged, AddressOf DataGridView2_CellValueChanged



	End Sub
	Private Sub DataGridView2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)




		' Update the database when a cell's value is changed
		Dim rowIndex As Integer = e.RowIndex
		Dim columnIndex As Integer = e.ColumnIndex
		Dim cellValue As String = DataGridView2.Rows(rowIndex).Cells(columnIndex).Value.ToString()

		Dim connectionString As String = "server=db4free.net;user=echoop01;password=EchooP0126;database=student_system;port=3306"
		Dim connection As MySqlConnection = New MySqlConnection(connectionString)

		Dim query As String = "UPDATE student_grades SET " + DataGridView2.Columns(columnIndex).Name + " = @value WHERE ID = @id"
		Dim command As MySqlCommand = New MySqlCommand(query, connection)
		command.Parameters.AddWithValue("@value", cellValue)
		command.Parameters.AddWithValue("@id", DataGridView2.Rows(rowIndex).Cells("ID").Value)
		connection.Open()
		command.ExecuteNonQuery()
		connection.Close()


		If e.ColumnIndex = 6 AndAlso e.RowIndex >= 0 Then
			Dim totalCellValue As Double = CType(DataGridView2.Rows(e.RowIndex).Cells(6).Value, Double)
			If totalCellValue < 75 Then
				DataGridView2.Rows(e.RowIndex).Cells(7).Value = "Failed"

			Else
				DataGridView2.Rows(e.RowIndex).Cells(7).Value = "Passed"

			End If

		End If


	End Sub

	'Compute the grades

	Private Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
		Dim prelim As Double
		Dim midterm As Double
		Dim final_grade As Double
		Dim total As Double

		If Double.TryParse(DataGridView2.Rows(e.RowIndex).Cells("Prelim_Grade").Value.ToString(), prelim) AndAlso
		   Double.TryParse(DataGridView2.Rows(e.RowIndex).Cells("Midterm_Grade").Value.ToString(), midterm) AndAlso
		   Double.TryParse(DataGridView2.Rows(e.RowIndex).Cells("Final_Grade").Value.ToString(), final_grade) Then

			total = prelim * 0.3 + midterm * 0.3 + final_grade * 0.4
			DataGridView2.Rows(e.RowIndex).Cells("Total_Grade").Value = total
		End If




	End Sub

	Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
		If e.ColumnIndex = 6 AndAlso e.Value IsNot Nothing AndAlso CType(e.Value, Double) < 75 Then
			e.CellStyle.BackColor = Color.Red
			e.CellStyle.ForeColor = Color.White
			DataGridView2.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.Red
		Else
			e.CellStyle.BackColor = Color.White
			e.CellStyle.ForeColor = Color.Black
			DataGridView2.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.White
		End If




	End Sub

	Private Sub DataGridView2_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView2.CellPainting
		If e.RowIndex = -1 Then 'check if it is the header row
			e.CellStyle.ForeColor = Color.White

		End If
	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		Dim query As String = "SELECT * FROM student_info WHERE Firstname LIKE @search OR Lastname LIKE @search"
		Dim connString As String = "server=db4free.net;user=echoop01;password=EchooP0126;database=student_system;port=3306"

		Using conn As New MySqlConnection(connString), cmd As New MySqlCommand(query, conn)
			cmd.Parameters.AddWithValue("@search", "%" & TextBox1.Text & "%")

			Dim du As New DataTable
			Dim da As New MySqlDataAdapter(cmd)

			da.Fill(du)

			DataGridView1.DataSource = du
			conn.Close()

			If du.Rows.Count > 0 Then
				Label1.Visible = False
				PictureBox2.Visible = False
			Else
				Label1.Visible = True
				PictureBox2.Visible = True
			End If
		End Using
	End Sub





	'Public Sub that Call to Form Dashboard
	Public Sub LoadData()
		Dim conn As New MySqlConnection(constring)
		conn.Open()
		Dim cmd As New MySqlCommand("SELECT Student_Number, Firstname, Lastname, Suffix, Gender, Birthday, Contact_Number, Address, Profiles FROM student_info", conn)
		Dim reader As MySqlDataReader = cmd.ExecuteReader()
		Dim du As New DataTable()
		du.Load(reader)
		reader.Close()
		conn.Close()

		DataGridView1.DataSource = du

		Dim con As New MySqlConnection(constring)
		con.Open()
		Dim dcm As New MySqlCommand("SELECT ID, Firstname, Lastname, Prelim_Grade, Midterm_Grade, Final_Grade, Total_Grade, Remark FROM student_grades", con)
		Dim dp As New MySqlDataAdapter(dcm)
		Dim dt As New DataTable()
		dp.Fill(dt)
		DataGridView2.DataSource = dt
		con.Close()


		'Change the column name
		DataGridView1.Columns("Student_Number").HeaderText = "ID"
		DataGridView1.Columns("Contact_Number").HeaderText = "Contact"
		DataGridView1.Columns("Birthday").HeaderText = "Birthdate"

		DataGridView2.Columns("Prelim_Grade").HeaderText = "Prelim Grade"
		DataGridView2.Columns("Midterm_Grade").HeaderText = "Midterm Grade"
		DataGridView2.Columns("Final_Grade").HeaderText = "Final Grade"
		DataGridView2.Columns("Total_Grade").HeaderText = "Total Grade"
		DataGridView2.Columns("Remark").HeaderText = "Remarks"

		'Allow to edit
		DataGridView2.Columns("ID").ReadOnly = True
		DataGridView2.Columns("Firstname").ReadOnly = True
		DataGridView2.Columns("Lastname").ReadOnly = True
		DataGridView2.Columns("Total_Grade").ReadOnly = True
		DataGridView2.Columns("Remark").ReadOnly = True

		'Set the width of the column
		DataGridView1.Columns("Student_Number").Width = 40
		DataGridView1.Columns("Address").Width = 233
		DataGridView1.Columns("Gender").Width = 70
		DataGridView1.Columns("Suffix").Width = 62
		DataGridView1.Columns("Contact_Number").Width = 108
		DataGridView1.Columns("Birthday").Width = 100
		DataGridView1.Columns("Firstname").Width = 120
		DataGridView1.Columns("Lastname").Width = 120

		DataGridView2.Columns("ID").Width = 40
		DataGridView2.Columns("Firstname").Width = 160
		DataGridView2.Columns("Lastname").Width = 160
		DataGridView2.Columns("Prelim_Grade").Width = 140
		DataGridView2.Columns("Midterm_Grade").Width = 140
		DataGridView2.Columns("Final_Grade").Width = 140
		DataGridView2.Columns("Total_Grade").Width = 140
		DataGridView2.Columns("Remark").Width = 130

		'Set the font style of the datagrid
		Dim font As New Font("Javanese Text", 10, FontStyle.Regular)
		DataGridView1.DefaultCellStyle.Font = font
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = font
		DataGridView2.DefaultCellStyle.Font = font
		DataGridView2.ColumnHeadersDefaultCellStyle.Font = font

		'Set the color of the button in the column
		Dim del As DataGridViewButtonColumn = DataGridView1.Columns("Delete")
		del.DefaultCellStyle.BackColor = Color.Red

		Dim updt As DataGridViewButtonColumn = DataGridView1.Columns("Information")
		updt.DefaultCellStyle.BackColor = Color.Green

		'Replace column position
		DataGridView1.Columns("Student_Number").DisplayIndex = 0
		DataGridView1.Columns("Firstname").DisplayIndex = 1
		DataGridView1.Columns("Lastname").DisplayIndex = 2
		DataGridView1.Columns("Suffix").DisplayIndex = 3
		DataGridView1.Columns("Gender").DisplayIndex = 4
		DataGridView1.Columns("Birthday").DisplayIndex = 5
		DataGridView1.Columns("Contact_Number").DisplayIndex = 6
		DataGridView1.Columns("Address").DisplayIndex = 7
		DataGridView1.Columns("Profiles").DisplayIndex = 8



		'Set the height of a row
		DataGridView1.RowTemplate.Height = 30
		DataGridView1.AllowUserToResizeRows = False
		DataGridView2.RowTemplate.Height = 30
		DataGridView2.AllowUserToResizeRows = False



	End Sub

End Class