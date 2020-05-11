Public Class Form7
    Dim s1, s2, s3, s4, s5 As String
    Dim gol As String

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With combo.Items
            .Add("KRISTEN")
            .Add("KATOLIK")
            .Add("ISLAM")
            .Add("BUDHA")
            .Add("HINDU")
            .Add("KONGHUCU")
        End With
    End Sub

    Sub syarat()
        If CheckBox1.Checked = True Then
            s1 = CheckBox1.Text & " : " & "ADA"
        Else
            s1 = CheckBox1.Text & " : " & "BELUM"
        End If
        If CheckBox2.Checked = True Then
            s2 = CheckBox2.Text & " : " & "ADA"
        Else
            s2 = CheckBox2.Text & " : " & "BELUM"
        End If
        If CheckBox3.Checked = True Then
            s3 = CheckBox3.Text & " : " & "ADA"
        Else
            s3 = CheckBox3.Text & " : " & "BELUM"
        End If
        If CheckBox4.Checked = True Then
            s4 = CheckBox4.Text & " : " & "ADA"
        Else
            s4 = CheckBox4.Text & " : " & "BELUM"
        End If
        If CheckBox5.Checked = True Then
            s5 = CheckBox5.Text & " : " & "ADA"
        Else
            s5 = CheckBox5.Text & " : " & "BELUM"
        End If
    End Sub
    Sub golongan()
        If a.Checked = True Then
            gol = "A"
        ElseIf b.Checked = True Then
            gol = "B"
        ElseIf o.Checked = True Then
            gol = "O"
        ElseIf ab.Checked = True Then
            gol = "AB"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call golongan()
        Call syarat()
        MsgBox("NISN : " & tboxnis.Text & vbCrLf & "Nama Lengkap : " & tboxnama.Text & vbCrLf & "Alamat : " & alamat.Text & vbCrLf & "Tanggal Lahir : " & DateTimePicker1.Value & vbCrLf & "Agama : " & combo.Text & vbCrLf & "Golongan Darah : " & gol & vbCrLf & "Prasyarat : " & vbCrLf & s1 & vbCrLf & s2 & vbCrLf & s3 & vbCrLf & s4 & vbCrLf & s5)
    End Sub
    Private Sub TomKeluar_Click(sender As Object, e As EventArgs) Handles TomKeluar.Click

    End Sub

    Private Sub MenuAwal_Click(sender As Object, e As EventArgs) Handles MenuAwal.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub NextModul_Click(sender As Object, e As EventArgs) Handles NextModul.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub TomTanya_Click(sender As Object, e As EventArgs) Handles TomTanya.Click
        MsgBox("Program ini dibuat oleh " & vbCrLf & "Nama : Franciscus Rangga Yogianto" & vbCrLf & "Rombel : RPL X-1" & vbCrLf & "Rayon : Cicurug 6")
    End Sub
End Class