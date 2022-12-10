Imports MySql.Data.MySqlClient
Public Class login_Sym
    Dim OBJ As New Mainform

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        OBJ.usernameI = txtuname.Text
        'obj.Show()

        Dim connection As New CONNECT()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        Dim username As String = txtuname.Text
        Dim password As String = txtPass.Text
        Dim selectQuery As String = "SELECT * FROM `system_users` WHERE `username`=@un AND `password`=@pass"

        command.CommandText = selectQuery
        command.Connection = connection.getConnection()

        command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            Dim mainForm As New Mainform()
            mainForm.Show()
            Me.Hide()

        Else

            MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btnEditdata_Click(sender As Object, e As EventArgs) Handles btnEditdata.Click
        txtuname.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dr As New DialogResult()
        dr = MessageBox.Show("Confirm you want to quit !!", "Simple database System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (DialogResult.Yes = dr) Then
            Application.Exit()
        End If
    End Sub
End Class