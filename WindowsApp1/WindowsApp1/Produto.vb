Public Class Produto
    Public Property Product_Name As String
    Public Property SKU As String
    Public Property Localization As String
    Public Property Price As Decimal
    Public Property Quantity As Integer
    Public Property Category_options As List(Of String)

    Public Sub New()
        Category_options = New List(Of String)()
    End Sub
End Class