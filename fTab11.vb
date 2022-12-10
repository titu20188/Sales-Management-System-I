Public Class fTab11

    Private Sub fTab11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            fTab4.Close()
            fTab12.Close()
        End If
    End Sub

    Private Sub btnPink_MouseHover(sender As Object, e As EventArgs) Handles btnPink.MouseHover
        Me.BackColor = Color.Violet
    End Sub

    Private Sub BtnYellow_MouseHover(sender As Object, e As EventArgs) Handles BtnYellow.MouseHover
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub BtnBlue_Click(sender As Object, e As EventArgs) Handles BtnBlue.Click
        Me.BackColor = Color.Blue
        lblRsdMwrd.Visible = False
        btnRsdMwrd.Visible = False
        btnRevMwrd.Visible = False
        btnPstvRsdMwrd.Visible = False
        lblMwrdn.Visible = False
        btnMwrdnKsfhsb.Visible = False
        btnMwrdnKsfhsbtfsl.Visible = False
        btnMwrdnItms.Visible = False
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lblPinkrsdOmala.Visible = False
        lblPinkRbhOmala.Visible = False
        lblPinkKsfhsbOmala.Visible = False
        btnRsdOmala.Visible = False
        btnRevOmala.Visible = False
        btnRsdNgtvOmala.Visible = False
        btnMostRbh.Visible = False
        btnLessRbh.Visible = False
        btnKsfHsb.Visible = False
        btndtlKsf.Visible = False
        btnCustitms.Visible = False
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lblGen.Visible = True
        btnRbhGen.Visible = True
        btndlySlsGen.Visible = True
        btnSlsRct.Visible = True
        btnPrchsRct.Visible = True
        btnSlsMostItms.Visible = True
        btnMovItms.Visible = True
        btnInqItm.Visible = True
    End Sub

    Private Sub btnPink_Click(sender As Object, e As EventArgs) Handles btnPink.Click
        lblPinkrsdOmala.Visible = True
        lblPinkRbhOmala.Visible = True
        lblPinkKsfhsbOmala.Visible = True
        btnRsdOmala.Visible = True
        btnRevOmala.Visible = True
        btnRsdNgtvOmala.Visible = True
        btnMostRbh.Visible = True
        btnLessRbh.Visible = True
        btnKsfHsb.Visible = True
        btndtlKsf.Visible = True
        btnCustitms.Visible = True
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lblGen.Visible = False
        btnRbhGen.Visible = False
        btndlySlsGen.Visible = False
        btnSlsRct.Visible = False
        btnPrchsRct.Visible = False
        btnSlsMostItms.Visible = False
        btnMovItms.Visible = False
        btnInqItm.Visible = False
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lblRsdMwrd.Visible = False
        btnRsdMwrd.Visible = False
        btnRevMwrd.Visible = False
        btnPstvRsdMwrd.Visible = False
        lblMwrdn.Visible = False
        btnMwrdnKsfhsb.Visible = False
        btnMwrdnKsfhsbtfsl.Visible = False
        btnMwrdnItms.Visible = False

    End Sub

    Private Sub BtnYellow_Click(sender As Object, e As EventArgs) Handles BtnYellow.Click
        lblRsdMwrd.Visible = True
        btnRsdMwrd.Visible = True
        btnRevMwrd.Visible = True
        btnPstvRsdMwrd.Visible = True
        lblMwrdn.Visible = True
        btnMwrdnKsfhsb.Visible = True
        btnMwrdnKsfhsbtfsl.Visible = True
        btnMwrdnItms.Visible = True
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lblPinkrsdOmala.Visible = False
        lblPinkRbhOmala.Visible = False
        lblPinkKsfhsbOmala.Visible = False
        btnRsdOmala.Visible = False
        btnRevOmala.Visible = False
        btnRsdNgtvOmala.Visible = False
        btnMostRbh.Visible = False
        btnLessRbh.Visible = False
        btnKsfHsb.Visible = False
        btndtlKsf.Visible = False
        btnCustitms.Visible = False
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lblGen.Visible = False
        btnRbhGen.Visible = False
        btndlySlsGen.Visible = False
        btnSlsRct.Visible = False
        btnPrchsRct.Visible = False
        btnSlsMostItms.Visible = False
        btnMovItms.Visible = False
        btnInqItm.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub btnRsdOmala_Click(sender As Object, e As EventArgs) Handles btnRsdOmala.Click

    End Sub

    Private Sub btnInqItm_Click(sender As Object, e As EventArgs) Handles btnInqItm.Click
        Este3lam3anSanf.MdiParent = ParentForm
        Este3lam3anSanf.Show()
        Este3lam3anSanf.Top = 165
        Este3lam3anSanf.Left = 115

    End Sub
End Class