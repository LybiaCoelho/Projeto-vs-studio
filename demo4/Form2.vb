Imports System.Diagnostics.Eventing.Reader

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = var1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        F.Show()

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim resp As Integer
        resp = MessageBox.Show("botaoyes_no_cancel", "vb.net", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)


        If resp = vbYes Then
            MessageBox.Show("botao yes pressionado", "vb.net")

        ElseIf resp = vbNo Then
            MessageBox.Show("botao no pressionado", "vb.net")

        ElseIf resp = vbCancel Then
            MessageBox.Show("botao cancel pressionado", "vb.net")

        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim resp As Integer
        resp = MessageBox.Show("botaoAbortRetryIgnore", "vb.net", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question)
        If resp = vbAbort Then
            MessageBox.Show("botao abortar pressionado", "vb.net")


        ElseIf resp = vbRetry Then
            MessageBox.Show("botao Repetir pressionado", "vb.net")

        ElseIf resp = vbIgnore Then
            MessageBox.Show("botao Ignorar pressionado", "vb.net")

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim resp As Integer
        resp = MessageBox.Show("botaoOk", "vb.net", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If resp = vbOK Then
            MessageBox.Show("botao OK pressionado", "vb.net")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form5.Show()

    End Sub
End Class