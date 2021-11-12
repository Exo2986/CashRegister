Public Class fTagManager
    Const strNONE_SELECTED = "No rows selected. Please select one or more rows by clicking the arrow at the beginning of each row."
    Private Sub fTagManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegisterDBTables.Tags' table. You can move, or remove it, as needed.
        Me.TagsTableAdapter.Fill(Me.RegisterDBTables.Tags)
        Me.TaxesTableAdapter.Fill(Me.RegisterDBTables.Taxes)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click 'Add new tag to the database
        Try
            Dim row = RegisterDBTables.Tags.NewTagsRow()

            If String.IsNullOrWhiteSpace(tbxID.Text) Or String.IsNullOrWhiteSpace(tbxName.Text) Then 'Basic input validation
                MessageBox.Show(Me, "Please input data.")
            End If

            row.Id = tbxID.Text
            row.Name = tbxName.Text

            RegisterDBTables.Tags.AddTagsRow(row)

            TagsTableAdapter.Update(RegisterDBTables.Tags) 'We do this to commit the changes back to the database so data persists when the program closes

            btnClear_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxID.Clear()
        tbxName.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Delete selected rows (not selected cells)
        If dgvTags.SelectedRows.Count = 0 Then 'Communicate the selection process to the user
            MessageBox.Show(Me, strNONE_SELECTED, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then 'Confirmation box to account for accidents
            For Each row As DataGridViewRow In dgvTags.SelectedRows
                TagsTableAdapter.Delete(row.Cells.Item(0).Value, row.Cells.Item(1).Value)
            Next

            TagsTableAdapter.Update(RegisterDBTables.Tags)

            TagsTableAdapter.Fill(RegisterDBTables.Tags)
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Select Case cbxColumn.Text
            Case "Id"
                TagsTableAdapter.FillById(RegisterDBTables.Tags, tbxFilter.Text)
            Case "Name"
                TagsTableAdapter.FillByName(RegisterDBTables.Tags, tbxFilter.Text)
        End Select
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        TagsTableAdapter.Fill(RegisterDBTables.Tags)
    End Sub

    Private Sub btnAssocTaxes_Click(sender As Object, e As EventArgs) Handles btnAssocTaxes.Click
        If dgvTags.SelectedRows.Count = 0 Then 'Communicate the selection process to the user
            MessageBox.Show(Me, strNONE_SELECTED, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        For Each row As DataGridViewRow In dgvTags.SelectedRows
            Dim taxes = TaxesTableAdapter.GetDataByTag(row.Cells.Item(0).Value)

            Dim taxStr As String = ""

            For Each tax In taxes.AsEnumerable()
                taxStr &= tax.Id + vbNewLine
            Next

            MessageBox.Show(Me, taxStr, "Associated Taxes")
        Next
    End Sub

    Private Sub fTagManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        fRegister.UpdateTablesAndPages()
    End Sub
End Class