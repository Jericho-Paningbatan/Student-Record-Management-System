<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Logoutbtn = New System.Windows.Forms.Button()
        Me.recordbtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.dashboardbtn = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.showpanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Logoutbtn)
        Me.Panel1.Controls.Add(Me.recordbtn)
        Me.Panel1.Controls.Add(Me.addbtn)
        Me.Panel1.Controls.Add(Me.dashboardbtn)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Location = New System.Drawing.Point(-6, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 519)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(53, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Welcome Admin"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(87, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.Location = New System.Drawing.Point(230, 6)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(716, 100)
        Me.Panel7.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 100)
        Me.Panel5.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(38, 25)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 100)
        Me.Panel6.TabIndex = 4
        '
        'Logoutbtn
        '
        Me.Logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Logoutbtn.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logoutbtn.ForeColor = System.Drawing.Color.White
        Me.Logoutbtn.Image = CType(resources.GetObject("Logoutbtn.Image"), System.Drawing.Image)
        Me.Logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logoutbtn.Location = New System.Drawing.Point(0, 453)
        Me.Logoutbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Logoutbtn.Name = "Logoutbtn"
        Me.Logoutbtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Logoutbtn.Size = New System.Drawing.Size(234, 60)
        Me.Logoutbtn.TabIndex = 3
        Me.Logoutbtn.Text = "Log Out"
        Me.Logoutbtn.UseVisualStyleBackColor = True
        '
        'recordbtn
        '
        Me.recordbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.recordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.recordbtn.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recordbtn.ForeColor = System.Drawing.Color.White
        Me.recordbtn.Image = CType(resources.GetObject("recordbtn.Image"), System.Drawing.Image)
        Me.recordbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.recordbtn.Location = New System.Drawing.Point(0, 263)
        Me.recordbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.recordbtn.Name = "recordbtn"
        Me.recordbtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.recordbtn.Size = New System.Drawing.Size(234, 60)
        Me.recordbtn.TabIndex = 2
        Me.recordbtn.Text = "Records"
        Me.recordbtn.UseVisualStyleBackColor = True
        '
        'addbtn
        '
        Me.addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addbtn.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.White
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addbtn.Location = New System.Drawing.Point(0, 204)
        Me.addbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.addbtn.Size = New System.Drawing.Size(234, 60)
        Me.addbtn.TabIndex = 1
        Me.addbtn.Text = "Add Students"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'dashboardbtn
        '
        Me.dashboardbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dashboardbtn.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardbtn.ForeColor = System.Drawing.Color.White
        Me.dashboardbtn.Image = CType(resources.GetObject("dashboardbtn.Image"), System.Drawing.Image)
        Me.dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardbtn.Location = New System.Drawing.Point(0, 146)
        Me.dashboardbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.dashboardbtn.Name = "dashboardbtn"
        Me.dashboardbtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.dashboardbtn.Size = New System.Drawing.Size(234, 60)
        Me.dashboardbtn.TabIndex = 0
        Me.dashboardbtn.Text = "Dashboard"
        Me.dashboardbtn.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(150, 100)
        Me.SplitContainer1.TabIndex = 2
        '
        'showpanel
        '
        Me.showpanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showpanel.AutoScroll = True
        Me.showpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.showpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.showpanel.Location = New System.Drawing.Point(226, 58)
        Me.showpanel.Name = "showpanel"
        Me.showpanel.Size = New System.Drawing.Size(1160, 516)
        Me.showpanel.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1277, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1237, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox2)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox6)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label6)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Purple
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Teal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1373, 58)
        Me.Guna2GradientPanel1.TabIndex = 7
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(29, 13)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 7
        Me.PictureBox6.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(65, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "STUDENT RECORD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Plum
        Me.Label5.Location = New System.Drawing.Point(248, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 29)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "MANAGEMENT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Plum
        Me.Label6.Location = New System.Drawing.Point(397, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 29)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "SYSTEM"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(67, 104)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 10
        Me.PictureBox7.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1370, 575)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.showpanel)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dashboardbtn As Button
    Friend WithEvents recordbtn As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents Logoutbtn As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents showpanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox7 As PictureBox
End Class
