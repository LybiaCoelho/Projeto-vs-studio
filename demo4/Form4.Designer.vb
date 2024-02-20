<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        form4 = New Button()
        Button2 = New Button()
        ListView1 = New ListView()
        Label1 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' form4
        ' 
        form4.Location = New Point(32, 43)
        form4.Name = "form4"
        form4.Size = New Size(75, 23)
        form4.TabIndex = 0
        form4.Text = "Add_item"
        form4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(330, 43)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 23)
        Button2.TabIndex = 1
        Button2.Text = "Limpa ListView"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(57, 246)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(367, 97)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 228)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 3
        Label1.Text = "ListView"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 157)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 23)
        Button1.TabIndex = 4
        Button1.Text = "Add_10_numeros-1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(172, 157)
        Button3.Name = "Button3"
        Button3.Size = New Size(139, 23)
        Button3.TabIndex = 5
        Button3.Text = "Add_10_numeros-2"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(208, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 6
        Label2.Text = "Label2"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(327, 157)
        Button4.Name = "Button4"
        Button4.Size = New Size(139, 23)
        Button4.TabIndex = 7
        Button4.Text = "Intervalo 2_2"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(360, 417)
        Button5.Name = "Button5"
        Button5.Size = New Size(116, 21)
        Button5.TabIndex = 8
        Button5.Text = "FINAL"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(238, 417)
        Button6.Name = "Button6"
        Button6.Size = New Size(116, 21)
        Button6.TabIndex = 9
        Button6.Text = "BACK"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' F
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(488, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(ListView1)
        Controls.Add(Button2)
        Controls.Add(form4)
        Name = "F"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents form4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
