Public Class Form1
    Dim nama(0) As String
    Dim gaji_pokok(0) As Integer
    Dim jumlahAnak As Integer
    Dim totalGaji As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Nama: Muhamad Rizki Ismail" & vbCrLf & "NIM: 240401010126" & vbCrLf & "Kelas: IF103", "Form ini dibuat oleh", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonCount_Click(sender As Object, e As EventArgs) Handles ButtonCount.Click
        ErrorChild.Visible = False
        ErroSalary.Visible = False

        nama(0) = InputName.Text
        If (Integer.TryParse(InputMainSalary.Text, gaji_pokok(0))) Then
            gaji_pokok(0) = InputMainSalary.Text
        Else
            ErroSalary.Visible = True
        End If

        If (Integer.TryParse(InputChild.Text, jumlahAnak)) Then
            jumlahAnak = InputChild.Text

            If (jumlahAnak > 3) Then
                MessageBox.Show("Jumlah anak yang diberi tunjangan hanya sampai anak ke-3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            totalGaji = (jumlahAnak * 50000) + gaji_pokok(0)
            TotalSalary.Text = totalGaji
        Else
            ErrorChild.Visible = True
        End If
    End Sub
End Class
