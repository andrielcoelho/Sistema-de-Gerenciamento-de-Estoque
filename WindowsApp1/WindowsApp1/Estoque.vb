Imports System.IO
Imports Newtonsoft.Json

Public Class Estoque
    Private Const arquivoEstoque As String = "estoque.json"

    Public Property Produtos As List(Of Produto)

    Public Sub New()
        If File.Exists(arquivoEstoque) Then
            Produtos = JsonConvert.DeserializeObject(Of List(Of Produto))(File.ReadAllText(arquivoEstoque))
        Else
            Produtos = New List(Of Produto)()
        End If
    End Sub

    Public Sub Salvar()
        File.WriteAllText(arquivoEstoque, JsonConvert.SerializeObject(Produtos, Formatting.Indented))
    End Sub

    Public Sub Register_Product(productName As String, sku As String, localization As String, price As Decimal, quantity As Integer, categoryOptions As List(Of String))
        Dim produto As New Produto With {
            .Product_Name = productName,
            .SKU = sku,
            .Localization = localization,
            .Price = price,
            .Quantity = quantity,
            .Category_options = categoryOptions
        }
        Produtos.Add(produto)
        Salvar()
    End Sub

    Public Sub AddQuantity(sku As String, quantidade As Integer)
        Dim produto = Produtos.FirstOrDefault(Function(p) p.SKU = sku)

        If produto IsNot Nothing Then
            produto.Quantity += quantidade
            Salvar() 'Salva as alterações no arquivo JSON
        Else
            MessageBox.Show("Produto não encontrado.")
        End If
    End Sub

    Public Sub RemoveQuantity(sku As String, quantidade As Integer)
        Dim produto = Produtos.FirstOrDefault(Function(p) p.SKU = sku)

        If produto IsNot Nothing Then
            If produto.Quantity >= quantidade Then
                produto.Quantity -= quantidade
                Salvar() 'Salva as alterações no arquivo JSON
            Else
                MessageBox.Show("Quantidade insuficiente para remover.")
            End If
        Else
            MessageBox.Show("Produto não encontrado.")
        End If
    End Sub
End Class