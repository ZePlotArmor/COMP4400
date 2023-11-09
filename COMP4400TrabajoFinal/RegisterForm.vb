Public Class RegisterForm
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'COMP4400DataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.COMP4400DataSet.Login)

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        LoginBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        LoginBindingSource.EndEdit()
        LoginTableAdapter.Update(COMP4400DataSet)
        MessageBox.Show("Successfully Registered.")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        LoginBindingSource.RemoveCurrent()
        MessageBox.Show("Account Successfully Deleted.")
        txtUsername.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Hide()
        VGLogin.ShowDialog()
    End Sub
End Class