<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Iphone 15 Pro Max", "IPHO_10", "SALA 7", "1000 R$", "CELULARES", "42"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Headset Gamer Razer", "HEAD_7", "SALA 10", "200 R$", "PERIFÉRICOS", "52"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Microondas Mondial", "MICRO_03K", "SALA 5", "500 R$", "ELETRODOMÉSTICOS", "22"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Iphone 15 Pro Max", "IPHO_10", "SALA 7", "1000 R$", "CELULARES", "42", "412515"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Headset Gamer Razer", "HEAD_7", "SALA 10", "200 R$", "PERIFÉRICOS", "52", "642132"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Microondas Mondial", "MICRO_03K", "SALA 5", "500 R$", "ELETRODOMÉSTICOS", "22", "562312"}, -1)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PriceBox = New System.Windows.Forms.TextBox()
        Me.LocalizationBox = New System.Windows.Forms.TextBox()
        Me.SKUBox = New System.Windows.Forms.TextBox()
        Me.Register_Product = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Category_List = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductNameBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RemoveQuantityBox = New System.Windows.Forms.TextBox()
        Me.RemoveSKUBox = New System.Windows.Forms.TextBox()
        Me.RemoveStock = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ADDQuantityBox = New System.Windows.Forms.TextBox()
        Me.ADDSKUBox = New System.Windows.Forms.TextBox()
        Me.ADDStockButton = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Product_NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SKUColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LocalizationColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PriceColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CategoryColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.QuantityColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(802, 449)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.PriceBox)
        Me.TabPage1.Controls.Add(Me.LocalizationBox)
        Me.TabPage1.Controls.Add(Me.SKUBox)
        Me.TabPage1.Controls.Add(Me.Register_Product)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Category_List)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ProductNameBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(794, 423)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro de Produtos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(485, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "R$"
        '
        'PriceBox
        '
        Me.PriceBox.Location = New System.Drawing.Point(343, 199)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(138, 20)
        Me.PriceBox.TabIndex = 10
        '
        'LocalizationBox
        '
        Me.LocalizationBox.Location = New System.Drawing.Point(343, 173)
        Me.LocalizationBox.Name = "LocalizationBox"
        Me.LocalizationBox.Size = New System.Drawing.Size(138, 20)
        Me.LocalizationBox.TabIndex = 9
        '
        'SKUBox
        '
        Me.SKUBox.Location = New System.Drawing.Point(343, 147)
        Me.SKUBox.Name = "SKUBox"
        Me.SKUBox.Size = New System.Drawing.Size(138, 20)
        Me.SKUBox.TabIndex = 8
        '
        'Register_Product
        '
        Me.Register_Product.Location = New System.Drawing.Point(343, 263)
        Me.Register_Product.Name = "Register_Product"
        Me.Register_Product.Size = New System.Drawing.Size(138, 33)
        Me.Register_Product.TabIndex = 7
        Me.Register_Product.Text = "Registrar Produto"
        Me.Register_Product.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Categoria"
        '
        'Category_List
        '
        Me.Category_List.FormattingEnabled = True
        Me.Category_List.Location = New System.Drawing.Point(343, 225)
        Me.Category_List.Name = "Category_List"
        Me.Category_List.Size = New System.Drawing.Size(138, 21)
        Me.Category_List.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Localização"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SKU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome do Produto"
        '
        'ProductNameBox
        '
        Me.ProductNameBox.Location = New System.Drawing.Point(343, 120)
        Me.ProductNameBox.Name = "ProductNameBox"
        Me.ProductNameBox.Size = New System.Drawing.Size(138, 20)
        Me.ProductNameBox.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.TextBox9)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.RemoveQuantityBox)
        Me.TabPage2.Controls.Add(Me.RemoveSKUBox)
        Me.TabPage2.Controls.Add(Me.RemoveStock)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.ADDQuantityBox)
        Me.TabPage2.Controls.Add(Me.ADDSKUBox)
        Me.TabPage2.Controls.Add(Me.ADDStockButton)
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(794, 423)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Estoque"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(509, 404)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(236, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "A Lista de Estoque é atualizada a cada segundo"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(509, 11)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 12
        Me.TextBox9.Text = "Pesquisar..."
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(512, 364)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 37)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Gerar Relatórios"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(539, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Quantidade"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(572, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "SKU"
        '
        'RemoveQuantityBox
        '
        Me.RemoveQuantityBox.Location = New System.Drawing.Point(607, 235)
        Me.RemoveQuantityBox.Name = "RemoveQuantityBox"
        Me.RemoveQuantityBox.Size = New System.Drawing.Size(120, 20)
        Me.RemoveQuantityBox.TabIndex = 8
        '
        'RemoveSKUBox
        '
        Me.RemoveSKUBox.Location = New System.Drawing.Point(607, 209)
        Me.RemoveSKUBox.Name = "RemoveSKUBox"
        Me.RemoveSKUBox.Size = New System.Drawing.Size(120, 20)
        Me.RemoveSKUBox.TabIndex = 7
        '
        'RemoveStock
        '
        Me.RemoveStock.Location = New System.Drawing.Point(607, 261)
        Me.RemoveStock.Name = "RemoveStock"
        Me.RemoveStock.Size = New System.Drawing.Size(120, 37)
        Me.RemoveStock.TabIndex = 6
        Me.RemoveStock.Text = "Remover Estoque"
        Me.RemoveStock.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(539, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Quantidade"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(572, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "SKU"
        '
        'ADDQuantityBox
        '
        Me.ADDQuantityBox.Location = New System.Drawing.Point(607, 113)
        Me.ADDQuantityBox.Name = "ADDQuantityBox"
        Me.ADDQuantityBox.Size = New System.Drawing.Size(120, 20)
        Me.ADDQuantityBox.TabIndex = 3
        '
        'ADDSKUBox
        '
        Me.ADDSKUBox.Location = New System.Drawing.Point(607, 87)
        Me.ADDSKUBox.Name = "ADDSKUBox"
        Me.ADDSKUBox.Size = New System.Drawing.Size(120, 20)
        Me.ADDSKUBox.TabIndex = 2
        '
        'ADDStockButton
        '
        Me.ADDStockButton.Location = New System.Drawing.Point(607, 139)
        Me.ADDStockButton.Name = "ADDStockButton"
        Me.ADDStockButton.Size = New System.Drawing.Size(120, 37)
        Me.ADDStockButton.TabIndex = 1
        Me.ADDStockButton.Text = "Adicionar Estoque"
        Me.ADDStockButton.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Product_NameColumn, Me.SKUColumn, Me.LocalizationColumn, Me.PriceColumn, Me.CategoryColumn, Me.QuantityColumn})
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListView1.Location = New System.Drawing.Point(8, 9)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(495, 408)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Product_NameColumn
        '
        Me.Product_NameColumn.Text = "Nome do Produto"
        Me.Product_NameColumn.Width = 107
        '
        'SKUColumn
        '
        Me.SKUColumn.Text = "SKU"
        Me.SKUColumn.Width = 59
        '
        'LocalizationColumn
        '
        Me.LocalizationColumn.Text = "Localização"
        Me.LocalizationColumn.Width = 73
        '
        'PriceColumn
        '
        Me.PriceColumn.Text = "Preço"
        Me.PriceColumn.Width = 57
        '
        'CategoryColumn
        '
        Me.CategoryColumn.Text = "Categoria"
        Me.CategoryColumn.Width = 127
        '
        'QuantityColumn
        '
        Me.QuantityColumn.Text = "Quantidade"
        Me.QuantityColumn.Width = 74
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.ListView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(794, 423)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Menu Gerente"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(612, 367)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(157, 47)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Autorizar Compra"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView2.HideSelection = False
        Me.ListView2.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6})
        Me.ListView2.Location = New System.Drawing.Point(8, 6)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(576, 408)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome do Produto"
        Me.ColumnHeader1.Width = 107
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "SKU"
        Me.ColumnHeader2.Width = 59
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Localização"
        Me.ColumnHeader3.Width = 73
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Preço"
        Me.ColumnHeader4.Width = 57
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Categoria"
        Me.ColumnHeader5.Width = 127
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Quantidade"
        Me.ColumnHeader6.Width = 74
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "PAYOUT_ID"
        Me.ColumnHeader7.Width = 74
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form2"
        Me.Text = "Menu de Gestão de Estoque - Andriel"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents PriceBox As TextBox
    Friend WithEvents LocalizationBox As TextBox
    Friend WithEvents SKUBox As TextBox
    Friend WithEvents Register_Product As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Category_List As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductNameBox As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RemoveQuantityBox As TextBox
    Friend WithEvents RemoveSKUBox As TextBox
    Friend WithEvents RemoveStock As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ADDQuantityBox As TextBox
    Friend WithEvents ADDSKUBox As TextBox
    Friend WithEvents ADDStockButton As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Product_NameColumn As ColumnHeader
    Friend WithEvents SKUColumn As ColumnHeader
    Friend WithEvents LocalizationColumn As ColumnHeader
    Friend WithEvents PriceColumn As ColumnHeader
    Friend WithEvents CategoryColumn As ColumnHeader
    Friend WithEvents QuantityColumn As ColumnHeader
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Timer1 As Timer
End Class
