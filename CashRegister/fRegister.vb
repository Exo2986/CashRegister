Public Class fRegister
    Private receipt As List(Of ReceiptItem) = New List(Of ReceiptItem)

    Private subTotal As Decimal = 0
    Private total As Decimal = 0
    Private taxTotal As Decimal = 0

    Private Sub AddReceiptItem(name As String)
        Dim results = ProductsTableAdapter.GetDataById(name)

        Dim taxes = New Dictionary(Of String, Decimal)

        For Each tag As String In results.Item(0).Tags.Split(";"c) 'Find applicable taxes
            Dim taxResults = TaxesTableAdapter.GetDataByTag(tag)
            For Each row As RegisterDBTables.TaxesRow In taxResults.AsEnumerable()
                If Not taxes.ContainsKey(row.Id) Then
                    taxes.Add(row.Id, row.Modifier)
                End If
            Next
        Next

        Dim item = ReceiptItem.FromProductRow(results.Item(0), taxes)

        receipt.Insert(0, item)

        UpdateReceipt()
    End Sub

    Private Sub ModifyReceiptItemCount(name As String, quantity As Integer)
        Dim index = receipt.FindIndex(Function(a As ReceiptItem)
                                          Return a.Id.Equals(name)
                                      End Function)

        Dim item = receipt.Item(index)

        receipt.RemoveAt(index)

        If quantity > 0 Then
            item.Quantity = quantity
            receipt.Insert(index, item)
        End If

        UpdateReceipt()
    End Sub

    Private Sub UpdateReceipt()
        Dim prevSelected = lbxReceipt.SelectedIndex
        lbxReceipt.Items.Clear()

        total = 0
        subTotal = 0
        taxTotal = 0
        tbxSubtotal.Text = String.Empty
        tbxTotal.Text = String.Empty
        tbxTax.Text = String.Empty

        For Each item As ReceiptItem In receipt
            lbxReceipt.Items.Add(item)

            subTotal += item.GetPrice()
            taxTotal += item.GetCalculatedTax()
        Next

        total = subTotal + taxTotal

        tbxSubtotal.Text = FormatCurrency(subTotal)
        tbxTax.Text = FormatCurrency(taxTotal)
        tbxTotal.Text = FormatCurrency(total)

        If prevSelected < lbxReceipt.Items.Count And prevSelected >= 0 Then
            lbxReceipt.SelectedIndex = prevSelected
        End If
    End Sub

    Private Sub fRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTablesAndPages()
    End Sub

    Public Sub UpdateTablesAndPages()
        Me.TaxesTableAdapter.Fill(Me.RegisterDBTables.Taxes)
        Me.TagsTableAdapter.Fill(Me.RegisterDBTables.Tags)
        Me.ProductsTableAdapter.Fill(Me.RegisterDBTables.Products)
        Me.PagesTableAdapter.Fill(Me.RegisterDBTables.Pages)

        receipt.Clear()
        lbxReceipt.Items.Clear()

        SetupTabs()
    End Sub

    Private Sub SetupTabs() 'Instantiate Pages

        For Each item As TabPage In tabcItems.TabPages
            If String.IsNullOrWhiteSpace(item.Tag) Then
                tabcItems.TabPages.Remove(item)
            End If
        Next

        For Each page As RegisterDBTables.PagesRow In RegisterDBTables.Pages 'Make a new tab for each page
            Dim tabPage As TabPage = New TabPage()
            tabPage.Text = page.Name
            Dim layout As FlowLayoutPanel = New FlowLayoutPanel()
            layout.Parent = tabPage
            layout.AutoScroll = True
            layout.FlowDirection = FlowDirection.LeftToRight
            layout.WrapContents = True
            layout.Dock = Dock.Fill

            tabcItems.TabPages.Insert(0, tabPage)

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

        tabcItems.SelectedIndex = 0
    End Sub

    Private Sub btnAddItem_Click(sender As Button, e As EventArgs)
        AddReceiptItem(sender.Name)
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

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If CheckIfItemSelected() Then
            Dim item = receipt.Item(lbxReceipt.SelectedIndex)
            ModifyReceiptItemCount(item.Id, item.Quantity - 1)
        End If
    End Sub

    Private Sub btnQuantity_Click(sender As Object, e As EventArgs) Handles btnQuantity.Click

        If CheckIfItemSelected() Then
            Dim item = receipt.Item(lbxReceipt.SelectedIndex)
            Dim complete = False

            Do
                Dim input As String = InputBox("Input the new quantity.")
                Dim value As Integer = 0

                If input.Length = 0 Then
                    complete = True 'Do this so the user can escape without inputting anything and not risk losing information
                ElseIf Integer.TryParse(input, value) Then
                    ModifyReceiptItemCount(item.Id, value)
                    complete = True
                End If
            Loop Until complete
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If CheckIfItemSelected() Then
            Dim item = receipt.Item(lbxReceipt.SelectedIndex)
            ModifyReceiptItemCount(item.Id, item.Quantity + 1)
        End If

    End Sub

    Private Function CheckIfItemSelected() As Boolean
        If lbxReceipt.SelectedIndex >= 0 Then
            Return True
        Else
            MessageBox.Show("Please select an item in the receipt.")
            Return False
        End If
    End Function
End Class

Public Class ReceiptItem
    Public Id As String
    Public Name As String
    Public SinglePrice As Decimal
    Public Quantity As Integer
    Public TotalTax As Decimal

    Public Function GetPrice() As Decimal
        Return SinglePrice * Quantity * 1.0
    End Function
    Public Overrides Function ToString() As String
        Return String.Format("{0}x {1} {2}", Quantity, Name, FormatCurrency(GetPrice()))
    End Function

    Public Function GetCalculatedTax() As Decimal
        Return GetPrice() * TotalTax
    End Function

    Public Function GetCalculatedTotal() As Decimal
        Return GetPrice() + GetCalculatedTax()
    End Function

    Public Shared Function FromProductRow(row As RegisterDBTables.ProductsRow, taxes As Dictionary(Of String, Decimal)) As ReceiptItem
        Dim item = New ReceiptItem()
        With item
            .Id = row.Id
            .Name = row.Name
            .SinglePrice = row.Price
            .Quantity = 1
            .TotalTax = 0
        End With

        For Each pair As KeyValuePair(Of String, Decimal) In taxes
            item.TotalTax += pair.Value
        Next

        Return item
    End Function
End Class
