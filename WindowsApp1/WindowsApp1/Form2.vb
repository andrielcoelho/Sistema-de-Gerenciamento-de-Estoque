
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Messaging
Imports System.Web.Script.Serialization
Imports System.Windows.Forms.ComponentModel.Com2Interop
Imports System.Windows.Forms.VisualStyles
Public Class Form2
    Private estoque As Estoque
    Dim Product_Name As String
    Dim SKU As String
    Dim Localization As String
    Dim Price As Integer

    Private Sub Register_Product_Click(sender As Object, e As EventArgs) Handles Register_Product.Click
        Dim productName As String = ProductNameBox.Text
        Dim sku As String = SKUBox.Text
        Dim localization As String = LocalizationBox.Text
        Dim price As Decimal = CDec(PriceBox.Text)

        'Captura da categoria selecionada do ComboBox
        Dim categoryOptions As New List(Of String) From {
            Category_List.SelectedItem.ToString()
        }

        estoque.Register_Product(productName, sku, localization, price, 0, categoryOptions)
        MessageBox.Show("Produto Cadastrado Com Sucesso!")

        'Limpar os campos após a adição
        ProductNameBox.Clear()
        SKUBox.Clear()
        LocalizationBox.Clear()
        PriceBox.Clear()
        Category_List.SelectedIndex = -1
    End Sub
    Private Sub AtualizarListView()
        ListView1.Items.Clear() 'Limpa a lista antes de adicionar novos itens

        For Each produto In estoque.Produtos
            Dim item As New ListViewItem(produto.Product_Name)
            item.SubItems.Add(produto.SKU)
            item.SubItems.Add(produto.Localization)
            item.SubItems.Add(produto.Price.ToString("C")) 'Formatação de moeda
            item.SubItems.Add(String.Join(", ", produto.Category_options))
            item.SubItems.Add(produto.Quantity.ToString())

            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estoque = New Estoque()

        ' Configurar o Timer
        Timer1.Interval = 1000 ' a cada segundo
        Timer1.Start()

        ' Adicionando opções ao ComboBox
        Category_List.Items.Add("CELULARES")
        Category_List.Items.Add("PERIFÉRICOS")
        Category_List.Items.Add("ELETRODOMÉSTICOS")
        Category_List.Items.Add("OUTROS")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Carregar os produtos no ListView pela primeira vez
        AtualizarListView()
    End Sub

    Private Sub ADDStockButton_Click(sender As Object, e As EventArgs) Handles ADDStockButton.Click
        Dim sku As String = ADDSKUBox.Text
        Dim quantidade As Integer = CInt(ADDQuantityBox.Text)

        estoque.AddQuantity(sku, quantidade)
        MessageBox.Show($"Estoque do Produto: {sku} Adicionado {quantidade} unidades com Sucesso!")

        'Limpar os campos após a adição
        ADDSKUBox.Clear()
        ADDQuantityBox.Clear()
    End Sub

    Private Sub RemoveStock_Click(sender As Object, e As EventArgs) Handles RemoveStock.Click
        Dim sku As String = RemoveSKUBox.Text
        Dim quantidade As Integer = CInt(RemoveQuantityBox.Text)

        estoque.RemoveQuantity(sku, quantidade)
        MessageBox.Show($"Estoque do Produto: {sku} Removido {quantidade} unidades com Sucesso!")

        'Limpar os campos após a remoção
        RemoveSKUBox.Clear()
        RemoveQuantityBox.Clear()
    End Sub

    Function GerarRelatorio(caminhoArquivo, nomeArquivo)

        ' Verificar se o arquivo JSON existe
        If Not File.Exists(caminhoArquivo) Then
            MessageBox.Show("Arquivo JSON não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Ler o conteúdo do arquivo JSON
        Dim jsonData As String = File.ReadAllText(caminhoArquivo)

        ' Desserializar o JSON em uma lista de dicionários
        Dim produtos As List(Of Dictionary(Of String, Object)) = Nothing
        Try
            Dim serializer As New JavaScriptSerializer()
            produtos = serializer.Deserialize(Of List(Of Dictionary(Of String, Object)))(jsonData)
        Catch ex As Exception
            MessageBox.Show("Erro ao processar o arquivo JSON: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        ' Definir os limites de estoque
        Dim limiteBaixo As Integer = 5
        Dim limiteExcesso As Integer = 20

        ' Criar o conteúdo do relatório
        Dim relatorio As String = "Relatório de Estoque" & Environment.NewLine & Environment.NewLine

        ' Produtos com estoque baixo
        relatorio &= "Produtos com Estoque Baixo:" & Environment.NewLine
        For Each produto In produtos
            If CInt(produto("Quantity")) < limiteBaixo Then
                relatorio &= $"- {produto("Product_Name")} (SKU: {produto("SKU")}): {produto("Quantity")} unidades" & Environment.NewLine
            End If
        Next

        ' Produtos com excesso de estoque
        relatorio &= Environment.NewLine & "Produtos com Excesso de Estoque:" & Environment.NewLine
        For Each produto In produtos
            If CInt(produto("Quantity")) > limiteExcesso Then
                relatorio &= $"- {produto("Product_Name")} (SKU: {produto("SKU")}): {produto("Quantity")} unidades" & Environment.NewLine
            End If
        Next

        ' Produtos com movimentação regular
        relatorio &= Environment.NewLine & "Movimentação de Produtos (Estoque Adequado):" & Environment.NewLine
        For Each produto In produtos
            If CInt(produto("Quantity")) >= limiteBaixo AndAlso CInt(produto("Quantity")) <= limiteExcesso Then
                relatorio &= $"- {produto("Product_Name")} (SKU: {produto("SKU")}): {produto("Quantity")} unidades" & Environment.NewLine
            End If
        Next

        ' Salvar o relatório em um arquivo .txt
        File.WriteAllText(nomeArquivo, relatorio)

        ' Abrir o arquivo de relatório no bloco de notas
        Process.Start("notepad.exe", nomeArquivo)
        Return True
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nomeArquivo = "relatorio_estoque.txt"
        Dim caminhoArquivo = "estoque.json"
        If (GerarRelatorio(caminhoArquivo, nomeArquivo) = True) Then
            MessageBox.Show($"Relatório salvo em {nomeArquivo} e aberto com sucesso.", "Relatório de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class