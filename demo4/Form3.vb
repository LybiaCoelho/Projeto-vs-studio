Imports System.Runtime.InteropServices

Public Class Form3
    Dim n, i, n_inicial, n_final, dia As Integer
    Dim txt As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n_inicial = Val(TextBox1.Text)
        n_final = Val(TextBox2.Text)

        n = n_inicial

        Do While n <= n_final
            MessageBox.Show(n & "- while", "contagem I- crescente")
            n += 1
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n_inicial = Val(TextBox1.Text)
        n_final = Val(TextBox2.Text)

        For i = n_inicial To n_final

            MessageBox.Show(i & "- for", "contagem-II-crescente")
        Next i

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form5.Show()

    End Sub
End Class