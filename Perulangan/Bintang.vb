Public Class Bintang
    Dim hasil As String = ""
    Friend Shared MidParent As Form1

    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles btn_proses.Click
        Try
            Select Case combo_pola.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(text_baris.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(text_baris.Text))
                Case "Interverd Pyramid"
                    interverdPyramid(Convert.ToInt32(text_baris.Text))
                Case "Hollow Interverd Pyramid"
                    hollowIinterverdPyramid(Convert.ToInt32(text_baris.Text))
                Case Else
                    text_hasil.Text = "Anda Belum Memilih Pola"
            End Select
        Catch ex As Exception
            text_hasil.Text = "Masukkan Bukan Angka"
        End Try
    End Sub
    Private Sub pyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom < batasKolom1 Or kolom > batasKolom2) Then
                    Me.hasil &= "  "
                Else
                    Me.hasil &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        text_hasil.Text = hasil
        hasil = ""
    End Sub

    Private Sub hollowPyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris < batas) Then
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                Else
                    Me.hasil &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        text_hasil.Text = hasil
        hasil = ""
    End Sub

    Private Sub interverdPyramid(batas As Integer)
        Dim batasKolom1 As Integer = 0
        Dim batasKolom2 As Integer = batas * 2
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom > batasKolom1 And kolom < batasKolom2) Then
                    Me.hasil &= "*"
                Else
                    Me.hasil &= "  "
                End If
            Next
            Me.hasil &= vbCrLf
            batasKolom1 += 1
            batasKolom2 -= 1
        Next
        text_hasil.Text = hasil
        Me.hasil = ""
    End Sub

    Private Sub hollowIinterverdPyramid(batas As Integer)
        Dim batasKolom1 As Integer = 1
        Dim batasKolom2 As Integer = batas * 2 - 1
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris = 1) Then
                    Me.hasil &= "*"
                Else
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                End If
            Next
            batasKolom1 += 1
            batasKolom2 -= 1
            Me.hasil &= vbCrLf
        Next
        text_hasil.Text = hasil
        Me.hasil = ""
    End Sub
End Class