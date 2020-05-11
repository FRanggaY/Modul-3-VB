Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With combobox1.Items
            .Add("Sumatera")
            .Add("Kalimantan")
            .Add("Jawa")
            .Add("Sulawesi")
            .Add("Papua")
        End With
    End Sub

    Private Sub combobox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox1.SelectedIndexChanged
        Select Case combobox1.Text
            Case Is = "Sumatera"
                With ListBox1.Items
                    .Clear()
                    .Add("NAD")
                    .Add("Sumatera Utara")
                    .Add("Sumatera Barat")
                    .Add("Palembang")
                    .Add("Lampung")
                    .Add("Riau")
                End With
            Case Is = "Kalimantan"
                With ListBox1.Items
                    .Clear()
                    .Add("Kalimantan Utara")
                    .Add("Kalimantan Tengah")
                    .Add("Kalimantan Barat")
                    .Add("Kalimantan Timur")
                    .Add("Kalimantan Selatan")
                End With
            Case Is = "Jawa"
                With ListBox1.Items
                    .Clear()
                    .Add("Banten")
                    .Add("Jawa Tengah")
                    .Add("Jawa Barat")
                    .Add("Jawa Timur")
                    .Add("Jakarta")
                    .Add("Yogyakarta")
                End With
            Case Is = "Sulawesi"
                With ListBox1.Items
                    .Clear()
                    .Add("Sulawesi Utara")
                    .Add("Sulawesi Selatan")
                    .Add("Sulawesi Tenggara")
                End With
            Case Is = "Papua"
                With ListBox1.Items
                    .Clear()
                    .Add("Papua Barat")
                End With
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Pilih provinsi terlebih dahulu")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("Maaf Pilih provinsi yang ingin hapus")
        Else
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub
    Private Sub TomKeluar_Click(sender As Object, e As EventArgs) Handles TomKeluar.Click

    End Sub

    Private Sub MenuAwal_Click(sender As Object, e As EventArgs) Handles MenuAwal.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub NextModul_Click(sender As Object, e As EventArgs) Handles NextModul.Click
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub TomTanya_Click(sender As Object, e As EventArgs) Handles TomTanya.Click
        MsgBox("Program ini dibuat oleh " & vbCrLf & "Nama : Franciscus Rangga Yogianto" & vbCrLf & "Rombel : RPL X-1" & vbCrLf & "Rayon : Cicurug 6")
    End Sub
End Class