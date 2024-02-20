Public Class Form5
    Dim n, i, n_inicial, n_final, dia As Integer
    Dim txt As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n_inicial = Val(TextBox1.Text)
        n_final = Val(TextBox2.Text)

        n = n_final

        Do While n >= n_inicial
            MessageBox.Show(n & "- while", "contagem I- decrescente")
            n -= 1
        Loop

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n_inicial = Val(TextBox1.Text)
        n_final = Val(TextBox2.Text)

        For i = n_final To n_inicial Step -1


            MessageBox.Show(i & "- for", "contagem-II-decrescente")
        Next i
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form3.Show()

    End Sub
End Class