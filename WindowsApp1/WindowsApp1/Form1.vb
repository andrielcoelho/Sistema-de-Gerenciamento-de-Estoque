Public Class Form1
    Dim username_gerente As String = "Gerente"
    Dim password_gerente As String = "Mks092m@"
    Dim username_estoquista As String = "Estoque"
    Dim password_estoquista As String = "Empresa2024"
    Function login(username, password)
        If (UsernameBox.Text = username_gerente And PasswordBox.Text = password_gerente) Then
            MessageBox.Show("Usuário Autorizado.")
            Me.Hide()
            Form2.Show()
        ElseIf (UsernameBox.Text = username_estoquista And PasswordBox.Text = password_estoquista) Then
            MessageBox.Show("Usuário Autorizado.")
            Me.Hide()
            Form2.Show()
            Form2.TabControl1.SelectTab(1) ' Deixar Selecionado a Parte Estoque
            Form2.TabControl1.TabPages(0).Enabled = False ' Desabilitar Cadastro de Produtos
            Form2.TabControl1.TabPages(2).Enabled = False ' Desabilitar Autorização de Compras
        Else
            MessageBox.Show("Login ou Senha Incorreta")
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        login(UsernameBox.Text, PasswordBox.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
