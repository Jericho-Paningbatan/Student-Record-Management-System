Public Class msgbox1


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        For Each form As Form In Application.OpenForms
            If form.Name = "Dashboard" Then
                form.Close()
                Exit For
            End If
        Next
        Me.Hide()

        'Check if Login form is already open
        Dim loginForm As Form = Application.OpenForms("Login")
        If loginForm Is Nothing Then
            'Create new instance of Login form if it doesn't exist
            loginForm = New Login()
        End If

        loginForm.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub
End Class