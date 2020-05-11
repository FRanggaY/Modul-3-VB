Public Class Form11
    Dim a As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Menghitung listrik terpakai
        a = 0
        total1.Text = Val(televisi1.Text) + Val(mesin1.Text) + Val(ac1.Text) + Val(lemari1.Text)
        'Menghitung total listrik di masing masing rumah
        listrikterpakai.Text = Val(total1.Text) + Val(total2.Text) + Val(total3.Text)
        If Val(listrikterpakai.Text) <= Val(totallistrik.Text) Then
            Panel1.BackColor = Color.Green
        Else
            Panel1.BackColor = Color.Red
        End If
        If Val(totallistrik.Text) = a Then
            Panel1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Menghitung listrik terpakai
        total2.Text = Val(televisi2.Text) + Val(mesin2.Text) + Val(ac2.Text) + Val(lemari2.Text)
        'Menghitung total listrik di masing masing rumah
        listrikterpakai.Text = Val(total1.Text) + Val(total2.Text) + Val(total3.Text)
        If Val(listrikterpakai.Text) <= Val(totallistrik.Text) Then
            Panel2.BackColor = Color.Green
        Else
            Panel2.BackColor = Color.Red
        End If
        If Val(totallistrik.Text) = a Then
            Panel2.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Menghitung listrik terpakai
        total3.Text = Val(televisi3.Text) + Val(mesin3.Text) + Val(ac3.Text) + Val(lemari3.Text)
        'Menghitung total listrik di masing masing rumah
        listrikterpakai.Text = Val(total1.Text) + Val(total2.Text) + Val(total3.Text)
        If Val(listrikterpakai.Text) <= Val(totallistrik.Text) Then
            Panel3.BackColor = Color.Green
        Else
            Panel3.BackColor = Color.Red
        End If
        If Val(totallistrik.Text) = a Then
            Panel3.BackColor = Color.Red
        End If
    End Sub

    Private Sub TomKeluar_Click(sender As Object, e As EventArgs) Handles TomKeluar.Click

    End Sub

    Private Sub MenuAwal_Click(sender As Object, e As EventArgs) Handles MenuAwal.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TomTanya_Click(sender As Object, e As EventArgs) Handles TomTanya.Click
        MsgBox("Program ini dibuat oleh " & vbCrLf & "Nama : Franciscus Rangga Yogianto" & vbCrLf & "Rombel : RPL X-1" & vbCrLf & "Rayon : Cicurug 6")
    End Sub
End Class