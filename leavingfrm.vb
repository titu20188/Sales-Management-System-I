Imports Microsoft.Win32.RegistryKey
Imports System.IO.BinaryWriter
Imports System.IO.BinaryReader

Public Class leavingfrm

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub btnBkup_Click(sender As Object, e As EventArgs) Handles btnBkup.Click
        SFD1.ShowDialog()
        If (Windows.Forms.DialogResult.Yes = Windows.Forms.DialogResult.Yes) Then
            SaveSetting()
        End If
    End Sub

    Private Sub SaveSetting()
        Throw New NotImplementedException
    End Sub

End Class