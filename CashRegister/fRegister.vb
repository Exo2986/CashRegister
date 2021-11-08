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

        SetupTabs()
    End Sub

    Private Sub SetupTabs() 'Instantiate Pages
        For Each page As RegisterDBTables.PagesRow In RegisterDBTables.Pages 'Make a new tab for each page
            Dim tabPage As TabPage = New TabPage()
            tabPage.Text = page.Name
            Dim layout As FlowLayoutPanel = New FlowLayoutPanel()
            layout.Parent = tabPage
            layout.AutoScroll = True
            layout.FlowDirection = FlowDirection.LeftToRight
            layout.WrapContents = True
            layout.Dock = Dock.Fill

            tabcItems.TabPages.Add(tabPage)

            Dim products As List(Of RegisterDBTables.ProductsRow) = New List(Of RegisterDBTables.ProductsRow)
            For Each tag As String In page.Tags.Split(";") 'Search products that fit the tag criteria for this page without duplicates
                Dim results = ProductsTableAdapter.GetDataByTag(tag)

                For Each result As RegisterDBTables.ProductsRow In results
                    Dim flag As Boolean = (products.FindIndex(Function(x As RegisterDBTables.ProductsRow) 'Search to see if this is a duplicate result
                                                                  Return x.Id.Equals(result.Id)
                                                              End Function) = -1) 'Flag is true if it is a unique result, false if it is a duplicate

                    If flag Then 'If this is a unique result
                        Dim button As Button = New Button()
                        button.Parent = layout
                        button.Size = New Size(layout.Width \ 6, layout.Height \ 6)
                        button.Text = result.Name
                        button.Name = result.Id
                        AddHandler button.Click, AddressOf btnAddItem_Click

                        products.Add(result)
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub btnAddItem_Click(sender As Button, e As EventArgs)
        Dim results = ProductsTableAdapter.GetDataById(sender.Name)
        Dim tbx = CreateReceiptLine(results.Item(0))
    End Sub

    Private Function CreateReceiptLine(item As RegisterDBTables.ProductsRow) As TextBox
        Dim tbx As TextBox = New TextBox()
        With tbx
            .Name = item.Item(0) 'Give name equal to ID
            .ReadOnly = True
            .BorderStyle = BorderStyle.None
            .BackColor = SystemColors.Window
            .Font = btnOpenProduct.Font
            .Size = New Size(flpReceipt.Width, 20)
            .Text = "1x " & item.Name & " " & item.Price.ToString("c")
        End With

        AddHandler tbx.Enter, AddressOf ReceiptLineEnterFocus
        AddHandler tbx.Leave, AddressOf ReceiptLineLeaveFocus

        tbx.Parent = flpReceipt

        Return tbx
    End Function

    Private Sub ReceiptLineEnterFocus(sender As TextBox, e As EventArgs)
        sender.BackColor = SystemColors.Highlight
    End Sub

    Private Sub ReceiptLineLeaveFocus(sender As TextBox, e As EventArgs)
        sender.BackColor = SystemColors.Window
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

    Private Sub btnPagesManager_Click(sender As Object, e As EventArgs) Handles btnPagesManager.Click
        Dim form = New fPageManager()
        form.Show()
    End Sub
End Class
