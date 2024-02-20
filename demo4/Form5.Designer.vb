<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(158, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 33)
        Label1.TabIndex = 1
        Label1.Text = "Ciclos"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(24, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 23)
        Label2.TabIndex = 2
        Label2.Text = "Numero incial"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(148, 205)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(146, 23)
        TextBox1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(24, 266)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 23)
        Label4.TabIndex = 6
        Label4.Text = "Numero final"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(148, 266)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(146, 23)
        TextBox2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(46, 356)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "while do"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(188, 356)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "for"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 416)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 15)
        Label3.TabIndex = 10
        Label3.Text = "Contagem decrescente"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(254, 416)
        Button3.Name = "Button3"
        Button3.Size = New Size(68, 29)
        Button3.TabIndex = 11
        Button3.Text = "NEXT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(180, 416)
        Button4.Name = "Button4"
        Button4.Size = New Size(68, 29)
        Button4.TabIndex = 12
        Button4.Text = "BACK"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(325, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
