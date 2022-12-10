Public Class fTab9

    Private Sub fTab9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Me.Visible = True) Then
            fTab1.Close()
            fTab2.Close()
            fTab3.Close()
            fTab5.Close()
            fTab6.Close()
            fTab7.Close()
            fTab8.Close()
            fTab4.Close()
            fTab10.Close()
            fTab11.Close()
            fTab12.Close()
        End If
    End Sub
End Class