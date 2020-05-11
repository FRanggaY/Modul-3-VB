Public Class Form4
    Sub hitung()
        Label3.Text = ListBox2.Items.Count & " Item "
    End Sub
    Sub tambah()
        With ListBox1.Items
            .Add("Nasi Goreng Cinta")
            .Add("Bebek Rebus jahe")
            .Add("Cumi - cumi casablanca")
            .Add("Krecek Tahu")
        End With
        hitung()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tambah()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("pilih makanan yang ingin anda pesan")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
        hitung()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("pilih makanan yang ingin anda pesan")
        Else
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            hitung()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        tambah()
        hitung()
        hitung()
    End Sub

    Private Sub TomKeluar_Click(sender As Object, e As EventArgs) Handles TomKeluar.Click
        End
    End Sub

    Private Sub MenuAwal_Click(sender As Object, e As EventArgs) Handles MenuAwal.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub NextModul_Click(sender As Object, e As EventArgs) Handles NextModul.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub TomTanya_Click(sender As Object, e As EventArgs) Handles TomTanya.Click
        MsgBox("Program ini dibuat oleh " & vbCrLf & "Nama : Franciscus Rangga Yogianto" & vbCrLf & "Rombel : RPL X-1" & vbCrLf & "Rayon : Cicurug 6")
    End Sub

End Class