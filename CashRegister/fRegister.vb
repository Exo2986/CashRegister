Public Class fRegister
    Private Sub fRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class
