Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Maaf makanan tidak boleh kosong")
        Else
            If ListBox1.Items.Contains(TextBox1.Text) Then
                MsgBox("Maaf makanan yang anda masukkan sudah ada")
            Else
                ListBox1.Items.Add(TextBox1.Text)
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Maaf pilih dahulu makanan yang anda hapus")
        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub TomKeluar_Click(sender As Object, e As EventArgs) Handles TomKeluar.Click
        End
    End Sub

    Private Sub MenuAwal_Click(sender As Object, e As EventArgs) Handles MenuAwal.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub NextModul_Click(sender As Object, e As EventArgs) Handles NextModul.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub TomTanya_Click(sender As Object, e As EventArgs) Handles TomTanya.Click
        MsgBox("Program ini dibuat oleh " & vbCrLf & "Nama : Franciscus Rangga Yogianto" & vbCrLf & "Rombel : RPL X-1" & vbCrLf & "Rayon : Cicurug 6")
    End Sub
End Class