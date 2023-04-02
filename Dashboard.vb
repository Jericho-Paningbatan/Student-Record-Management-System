

Public Class Dashboard

    Private isDragging As Boolean = False
    Private mouseOffset As Point







    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dashboardbtn.BackColor = Color.FromArgb(192, 0, 192)
        addbtn.BackColor = Color.FromArgb(64, 0, 64)
        recordbtn.BackColor = Color.FromArgb(64, 0, 64)

        'Design of Windows Form'

        Me.FormBorderStyle = FormBorderStyle.None

        dashboardbtn.FlatStyle = FlatStyle.Flat
        dashboardbtn.FlatAppearance.BorderSize = 0

        addbtn.FlatStyle = FlatStyle.Flat
        addbtn.FlatAppearance.BorderSize = 0

        recordbtn.FlatStyle = FlatStyle.Flat
        recordbtn.FlatAppearance.BorderSize = 0

        Logoutbtn.FlatStyle = FlatStyle.Flat
        Logoutbtn.FlatAppearance.BorderSize = 0

        With dash

            .TopLevel = False
            showpanel.Controls.Add(dash)
            .BringToFront()
            .Show()


        End With

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

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim mousePos As Point = MousePosition
            mousePos.Offset(mouseOffset)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addbtn.Click

        addbtn.BackColor = Color.FromArgb(192, 0, 192)
        dashboardbtn.BackColor = Color.FromArgb(64, 0, 64)
        recordbtn.BackColor = Color.FromArgb(64, 0, 64)


        With main

            .TopLevel = False
            showpanel.Controls.Add(main)
            .BringToFront()
            .Show()
            dash.Hide()
            Records.Hide()
        End With







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dashboardbtn.Click

        dashboardbtn.BackColor = Color.FromArgb(192, 0, 192)
        addbtn.BackColor = Color.FromArgb(64, 0, 64)
        recordbtn.BackColor = Color.FromArgb(64, 0, 64)

        With dash

            .TopLevel = False
            showpanel.Controls.Add(dash)
            .BringToFront()
            .Show()


        End With

        With main

            .TopLevel = False
            showpanel.Controls.Add(main)

            .Hide()


        End With

        With Records

            .TopLevel = False
            showpanel.Controls.Add(Records)

            .Hide()


        End With



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Logoutbtn.Click


        msgbox1.Show()




    End Sub

    Private Sub recordbtn_Click(sender As Object, e As EventArgs) Handles recordbtn.Click




        recordbtn.BackColor = Color.FromArgb(192, 0, 192)
        addbtn.BackColor = Color.FromArgb(64, 0, 64)
        dashboardbtn.BackColor = Color.FromArgb(64, 0, 64)

        With Records

            .TopLevel = False
            showpanel.Controls.Add(Records)
            .BringToFront()
            .Show()


        End With

        With main

            .TopLevel = False
            showpanel.Controls.Add(main)

            .Hide()


        End With

        With dash

            .TopLevel = False
            showpanel.Controls.Add(dash)

            .Hide()


        End With


    End Sub

    Private Sub showpanel_Paint(sender As Object, e As PaintEventArgs) Handles showpanel.Paint

    End Sub
End Class
