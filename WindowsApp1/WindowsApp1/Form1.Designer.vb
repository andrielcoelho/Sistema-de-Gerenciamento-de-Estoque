<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Login_Button
        '
        Me.Login_Button.Location = New System.Drawing.Point(137, 116)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(100, 28)
        Me.Login_Button.TabIndex = 0
        Me.Login_Button.Text = "Realizar Login"
        Me.Login_Button.UseVisualStyleBackColor = True
        '
        'UsernameBox
        '
        Me.UsernameBox.Location = New System.Drawing.Point(137, 64)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameBox.TabIndex = 1
        Me.UsernameBox.Text = "Usuário"
        '
        'PasswordBox
        '
        Me.PasswordBox.Location = New System.Drawing.Point(137, 90)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordBox.TabIndex = 2
        Me.PasswordBox.Text = "Senha"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 207)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.Login_Button)
        Me.Name = "Form1"
        Me.Text = "Sistema de Login - Andriel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login_Button As Button
    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents PasswordBox As TextBox
End Class
