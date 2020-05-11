Public Class Form2
    Dim a, b As Integer

    Private Sub TomTanya_Click(sender As Object, e As EventArgs) Handles TomTanya.Click
        MsgBox("Program ini dibuat oleh " & vbCrLf & "Nama : Franciscus Rangga Yogianto" & vbCrLf & "Rombel : RPL X-1" & vbCrLf & "Rayon : Cicurug 6")
    End Sub

    Private Sub TomKeluar_Click(sender As Object, e As EventArgs) Handles TomKeluar.Click
        End
    End Sub

    Private Sub MenuAwal_Click(sender As Object, e As EventArgs) Handles MenuAwal.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub NextModul_Click(sender As Object, e As EventArgs) Handles NextModul.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If a > b Then
            MsgBox("Nilai A terbesar")
        ElseIf b > a Then
            MsgBox("Nilai B terbesar")
        Else
            MsgBox("Nilai A & B terbesar")
        End If
    End Sub
End Class