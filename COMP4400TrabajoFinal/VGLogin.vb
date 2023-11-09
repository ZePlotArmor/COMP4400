Public Class VGLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "Admin" And PasswordTextBox.Text = "Admin" Then
            MessageBox.Show("Login Succesful!")
            Me.Hide()
            CardListDisplay.ShowDialog()
        Else
            MessageBox.Show("Login not successful, please check Username and Password")
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub RegisterLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterLink.LinkClicked
        Me.Hide()
        RegisterForm.ShowDialog()
    End Sub
End Class
