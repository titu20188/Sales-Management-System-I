Imports MySql.Data.MySqlClient

Public Class fTab1
    
    Private Sub fTab1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Me.Visible = True) Then
            fTab2.Close()
            fTab3.Close()
            fTab4.Close()
            fTab5.Close()
            fTab6.Close()
            fTab7.Close()
            fTab8.Close()
            fTab9.Close()
            fTab10.Close()
            fTab11.Close()
            fTab12.Close()
        End If
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click, Label29.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged, TextBox21.TextChanged

    End Sub


    Private Sub tabBtnExit_Click(sender As Object, e As EventArgs) Handles tabBtnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub btnBkup_Click(sender As Object, e As EventArgs) Handles btnBkup.Click
        TabPage7.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnextExit_Click(sender As Object, e As EventArgs) Handles btnextExit.Click
        ' Application.Exit()
        TabControl1.TabPages(9).Show()
    End Sub
End Class