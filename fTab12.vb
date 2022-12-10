Public Class fTab12

    Private Sub fTab12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Me.Visible = True) Then
            fTab1.Close()
            fTab2.Close()
            fTab3.Close()
            fTab5.Close()
            fTab6.Close()
            fTab7.Close()
            fTab8.Close()
            fTab9.Close()
            fTab10.Close()
            fTab11.Close()
            fTab4.Close()
        End If
    End Sub
End Class