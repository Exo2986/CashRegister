Public Class fNewProduct
    Const strROW_NOT_SELECTED = "No rows selected. Please select one or more rows by clicking the arrow at the beginning of each row."
    Const strAPPLY_TAGS_SUCCESS = "Tags successfully applied."
    Private Sub fNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegisterDBTables.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.RegisterDBTables.Products)
        Me.TagsTableAdapter.Fill(Me.RegisterDBTables.Tags)

        For Each row As DataRow In RegisterDBTables.Tags
            lbxTags.Items.Add(row.ItemArray(0), False)
        Next
    End Sub
    Private Sub dgvProducts_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvProducts.RowStateChanged
        If e.StateChanged = DataGridViewElementStates.Selected And dgvProducts.SelectedRows.Count = 1 Then 'Check if the state is "selected"
            Dim table = ProductsTableAdapter.GetDataById(dgvProducts.SelectedRows.Item(0).Cells.Item(0).Value) 'Get selected row
            Dim row = table.Item(0)

            Dim currentTags = row.Tags.Split(";")

            For i As Integer = 0 To lbxTags.Items.Count - 1 Step 1 'Change checked tags to match database
                lbxTags.SetItemChecked(i, currentTags.Contains(lbxTags.Items.Item(i).ToString()))
            Next

            lbxTags.Visible = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvProducts.SelectedRows.Count = 0 Then 'Communicate the selection process to the user
            MessageBox.Show(Me, strROW_NOT_SELECTED, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then 'Confirmation box to account for accidents
            For Each row As DataGridViewRow In dgvProducts.SelectedRows
                ProductsTableAdapter.Delete(row.Cells.Item(0).Value, row.Cells.Item(1).Value, row.Cells.Item(2).Value)
            Next

            ProductsTableAdapter.Update(RegisterDBTables.Products)

            ProductsTableAdapter.Fill(RegisterDBTables.Products)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim row = RegisterDBTables.Products.NewProductsRow()

            If String.IsNullOrWhiteSpace(tbxID.Text) Or String.IsNullOrWhiteSpace(tbxName.Text) Then 'Basic input validation
                MessageBox.Show(Me, "Please input data.")
            End If

            row.Id = tbxID.Text
            row.Name = tbxName.Text
            row.Price = nbxPrice.Value
            row.Tags = ";"

            RegisterDBTables.Products.AddProductsRow(row)

            ProductsTableAdapter.Update(RegisterDBTables.Products) 'We do this to commit the changes back to the database so data persists when the program closes

            btnClear_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message)
        End Try
    End Sub
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Select Case cbxColumn.Text
            Case "Id"
                ProductsTableAdapter.FillById(RegisterDBTables.Products, tbxFilter.Text)
            Case "Name"
                ProductsTableAdapter.FillByName(RegisterDBTables.Products, tbxFilter.Text)
        End Select
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        ProductsTableAdapter.Fill(RegisterDBTables.Products)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxID.Clear()
        tbxName.Clear()
        nbxPrice.Value = 0.0
    End Sub
    Private Sub btnApplyTags_Click(sender As Object, e As EventArgs) Handles btnApplyTags.Click
        If dgvProducts.SelectedRows.Count = 0 Then 'Communicate the selection process to the user
            MessageBox.Show(Me, strROW_NOT_SELECTED, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim tags As String = ""
        For Each selected As String In lbxTags.CheckedItems
            tags += selected & ";"
        Next

        tags = tags.TrimEnd(";"c) 'remove trailing semicolon

        If String.IsNullOrWhiteSpace(tags) Then 'SQL doesn't like nulls very much
            tags = ";"
        End If

        For Each row As DataGridViewRow In dgvProducts.SelectedRows
            ProductsTableAdapter.UpdateQuery(tags, row.Cells.Item(0).Value.ToString(), row.Cells.Item(1).Value.ToString())
        Next

        MessageBox.Show(strAPPLY_TAGS_SUCCESS)
    End Sub

    Private Sub btnSelection_Click(sender As Object, e As EventArgs) Handles btnSelection.Click
        Dim selectOrDeselect As Boolean = lbxTags.CheckedItems.Count.Equals(0) 'Flag to set every item to. if nothing is selected, it equals true. false otherwise
        For i As Integer = 0 To lbxTags.Items.Count - 1 Step 1 'Change every tag
            lbxTags.SetItemChecked(i, selectOrDeselect)
        Next
    End Sub

    Private Sub fNewProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        fRegister.UpdateTablesAndPages()
    End Sub
End Class