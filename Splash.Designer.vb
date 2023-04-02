<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pb = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(12, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOADING..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(428, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "lbl"
        '
        'Timer1
        '
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label7)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label6)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2GradientPanel1.Controls.Add(Me.pb)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Teal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(611, 301)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(173, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 39)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "STUDENT RECORD"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(49, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 130)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(419, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 39)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "SYSTEM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Plum
        Me.Label5.Location = New System.Drawing.Point(232, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 39)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "MANAGEMENT"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(0, 295)
        Me.pb.Name = "pb"
        Me.pb.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pb.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pb.Size = New System.Drawing.Size(611, 10)
        Me.pb.TabIndex = 0
        Me.pb.Text = "Guna2ProgressBar1"
        Me.pb.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Javanese Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(83, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 34)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "0%"
        '
        'Timer2
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label7.Location = New System.Drawing.Point(178, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(240, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Copyright © 2023 BSIT-3B (Group 1). All Rights Reserved"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(519, -5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(610, 338)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

        ' Set the initial text of the Label
        Label1.Text = "Loading..."

        ' Start the Timer to change the Label text
        Timer2.Interval = 500 ' set the interval to change the text
        Timer2.Start()

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

    Private Sub Guna2CircleProgressBar1_ValueChanged(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not pb.Value = 100 Then
            pb.Increment(1.8)
            Label2.Text = "Checking for System Update..."

            ' Show the percentage text
            Label3.Text = CInt(pb.Value / pb.Maximum * 100) & "%"

            If pb.Value >= 10 Then
                Label2.Text = "Checking Internet Connection..."
            End If
            If pb.Value >= 20 Then
                Label2.Text = "Patching Data From Server..."
            End If
            If pb.Value >= 30 Then
                Label2.Text = "Retrieving Data From Server..."
            End If
            If pb.Value >= 50 Then
                Label2.Text = "Updating Data To Grid View..."
                If pb.Value >= 80 Then
                    Label2.Text = "Updating Second Boot Up..."
                End If
                If pb.Value >= 90 Then
                    Label2.Text = "Finishing Up..."
                End If
            End If
        ElseIf pb.Value = 100 Then
            Timer1.Stop()

            Login.Show()
            Me.Hide()


        End If
    End Sub



    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pb As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Get the current text of the Label
        Dim labelText As String = Label1.Text

        ' Count the number of dots in the Label text
        Dim dotCount As Integer = labelText.Count(Function(c) c = "."c)

        ' Set the maximum number of dots
        Dim maxDots As Integer = 3

        ' Change the dots in the Label text
        If dotCount >= maxDots Then
            Label1.Text = "Loading"
        Else
            Label1.Text = labelText & "."
        End If

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class
