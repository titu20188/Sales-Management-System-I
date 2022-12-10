Public Class Mainform
    Public Property usernameI As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        fTab1.MdiParent = ParentForm
        fTab1.Show()
        fTab1.Top = 200
        fTab1.Left = 16
        lblused.Text = "الملفات"


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        GC.Collect()
        Dim dr As New DialogResult()
        dr = MessageBox.Show("Confirm you want to quit !!", "Simple database System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (DialogResult.Yes = dr) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDatetime.Text = Convert.ToString(Now())
        lblCurntUsr.Text = usernameI()


    End Sub

    Private Sub btnCusts_Click(sender As Object, e As EventArgs) Handles btnCusts.Click
        fTab2.MdiParent = ParentForm
        fTab2.Show()
        fTab2.Top = 200
        fTab2.Left = 16
        lblused.Text = "العملاء"
    End Sub

    Private Function Form() As Object
        Throw New NotImplementedException
    End Function

    Private Sub btnSups_Click(sender As Object, e As EventArgs) Handles btnSups.Click
        fTab3.MdiParent = ParentForm
        fTab3.Show()
        fTab3.Top = 200
        fTab3.Left = 16
        lblused.Text = "الموردين"
        Me.lblused.Font = New System.Drawing.Font("Arabic Typesetting", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub btnStors_Click(sender As Object, e As EventArgs) Handles btnStors.Click
        fTab4.MdiParent = ParentForm
        fTab4.Show()
        fTab4.Top = 200
        fTab4.Left = 16
        lblused.Text = "المخازن"
    End Sub

    Private Sub btnPrchs_Click(sender As Object, e As EventArgs) Handles btnPrchs.Click
        fTab5.MdiParent = ParentForm
        fTab5.Show()
        fTab5.Top = 200
        fTab5.Left = 16
        lblused.Text = "المشتريات"
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        fTab6.MdiParent = ParentForm
        fTab6.Show()
        fTab6.Top = 200
        fTab6.Left = 16
        lblused.Text = "المبيعات"
    End Sub

    Private Sub btnCalcs_Click(sender As Object, e As EventArgs) Handles btnCalcs.Click
        fTab7.MdiParent = ParentForm
        fTab7.Show()
        fTab7.Top = 200
        fTab7.Left = 16
        lblused.Text = "الحسابات"
    End Sub

    Private Sub btnClarks_Click(sender As Object, e As EventArgs) Handles btnClarks.Click
        fTab8.MdiParent = ParentForm
        fTab8.Show()
        fTab8.Top = 200
        fTab8.Left = 16
        lblused.Text = "الموظفين"
    End Sub

    Private Sub btnReprts_Click(sender As Object, e As EventArgs) Handles btnReprts.Click
        fTab9.MdiParent = ParentForm
        fTab9.Show()
        fTab9.Top = 200
        fTab9.Left = 16
        lblused.Text = "التقارير"
    End Sub

    Private Sub btnCallus_Click(sender As Object, e As EventArgs) Handles btnCallus.Click
        fTab10.MdiParent = ParentForm
        fTab10.Show()
        fTab10.Top = 200
        fTab10.Left = 16
        lblused.Text = "التواصل"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        fTab11.MdiParent = ParentForm
        fTab11.Show()
        fTab11.Top = 200
        fTab11.Left = 16
        lblused.Text = "الخزنة"
    End Sub
End Class