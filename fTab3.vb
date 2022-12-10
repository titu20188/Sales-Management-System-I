Public Class fTab3

    Private Sub fTab3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Me.Visible = True) Then
            fTab1.Close()
            fTab2.Close()
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
End Class