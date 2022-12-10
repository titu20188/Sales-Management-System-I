Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T1.Start()
    End Sub

    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles T1.Tick
        ProgressBar1.Increment(25)
        If (ProgressBar1.Value = 100) Then

            Me.Hide()
            Dim Lgn As New login_Sym()
            Lgn.Show()
            T1.Enabled = False
        End If
    End Sub
End Class
