Public Class fRegister
    Private Sub fRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegisterDBTables.Pages' table. You can move, or remove it, as needed.
        Me.PagesTableAdapter.Fill(Me.RegisterDBTables.Pages)
        'TODO: This line of code loads data into the 'RegisterDBTables.Taxes' table. You can move, or remove it, as needed.
        Me.TaxesTableAdapter.Fill(Me.RegisterDBTables.Taxes)
        'TODO: This line of code loads data into the 'RegisterDBTables.Tags' table. You can move, or remove it, as needed.
        Me.TagsTableAdapter.Fill(Me.RegisterDBTables.Tags)
        'TODO: This line of code loads data into the 'RegisterDBTables.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.RegisterDBTables.Products)


    End Sub

    Private Sub SetupTabs() 'Instantiate Pages

    End Sub

    Private Sub btnOpenTag_Click(sender As Object, e As EventArgs) Handles btnOpenTag.Click
        Dim form = New fTagManager()
        form.Show()
    End Sub

    Private Sub btnOpenTax_Click(sender As Object, e As EventArgs) Handles btnOpenTax.Click
        Dim form = New fTaxManager()
        form.Show()
    End Sub

    Private Sub btnOpenProduct_Click(sender As Object, e As EventArgs) Handles btnOpenProduct.Click
        Dim form = New fNewProduct()
        form.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New fPageManager()
        form.Show()
    End Sub
End Class
