Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Direktur")
            .Add("Manajer")
            .Add("Sekretaris")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Textbersih.Text = (Val(Textgaji.Text) + Val(Texttunjang.Text)) - (Val(Textpajak.Text) * Val(Textgaji.Text))
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Direktur" Then
            Textgaji.Text = 1000000
            Texttunjang.Text = 2500000
            Textpajak.Text = 0.1
        ElseIf ComboBox1.Text = "Manajer" Then
            Textgaji.Text = 7000000
            Texttunjang.Text = 2000000
            Textpajak.Text = 0.1
        ElseIf ComboBox1.Text = "Sekretaris" Then
            Textgaji.Text = 4000000
            Texttunjang.Text = 1000000
            Textpajak.Text = 0.1
        End If
    End Sub
    Private Sub TomKeluar_Click(sender As Object, e As EventArgs) Handles TomKeluar.Click

    End Sub

    Private Sub MenuAwal_Click(sender As Object, e As EventArgs) Handles MenuAwal.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub NextModul_Click(sender As Object, e As EventArgs) Handles NextModul.Click
        Form11.Show()
        Me.Hide()
    End Sub

    Private Sub TomTanya_Click(sender As Object, e As EventArgs) Handles TomTanya.Click
        MsgBox("Program ini dibuat oleh " & vbCrLf & "Nama : Franciscus Rangga Yogianto" & vbCrLf & "Rombel : RPL X-1" & vbCrLf & "Rayon : Cicurug 6")
    End Sub
End Class