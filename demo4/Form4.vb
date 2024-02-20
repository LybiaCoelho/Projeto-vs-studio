Public Class F
    Dim n As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles form4.Click
        Dim n As Integer
        n = InputBox("Qual numero quer add?", "vb.net")
        ListView1.Items.Add(n)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.Clear()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Label2.Text = var2
        For i = 1 To 10
            Name = InputBox("Nºincial", "vb.net")
            ListView1.Items.Add(i)
        Next


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = var3

        For i = 10 To 1 Step -1
            Name = InputBox("Nºfinal", "vb.net")
            ListView1.Items.Add(i)
        Next i
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = var4
        For i = 10 To 1 Step -2
            Name = InputBox("Qual o intervalo", "vb.net")
            ListView1.Items.Add(i)
        Next i

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class