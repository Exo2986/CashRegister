Public Class fTaxManager
    Const strROW_NOT_SELECTED = "No rows selected. Please select one or more rows by clicking the arrow at the beginning of each row."
    Const strAPPLY_TAGS_SUCCESS = "Tags successfully applied."

    Private Sub fTaxManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TagsTableAdapter.Fill(Me.RegisterDBTables.Tags)
        Me.TaxesTableAdapter.Fill(Me.RegisterDBTables.Taxes)

        For Each row As DataRow In RegisterDBTables.Tags
            lbxTags.Items.Add(row.ItemArray(0), False)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim row = RegisterDBTables.Taxes.NewTaxesRow()

            If String.IsNullOrWhiteSpace(tbxID.Text) Or String.IsNullOrWhiteSpace(tbxName.Text) Then 'Basic input validation
                MessageBox.Show(Me, "Please input data.")
            End If

            row.Id = tbxID.Text
            row.Name = tbxName.Text
            row.Modifier = nbxModifier.Value
            row.Tags = ";"

            RegisterDBTables.Taxes.AddTaxesRow(row)

            TaxesTableAdapter.Update(RegisterDBTables.Taxes) 'We do this to commit the changes back to the database so data persists when the program closes

            btnClear_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxID.Clear()
        tbxName.Clear()
        nbxModifier.Value = 0.0
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Select Case cbxColumn.Text
            Case "Id"
                TaxesTableAdapter.FillByID(RegisterDBTables.Taxes, tbxFilter.Text)
            Case "Name"
                TaxesTableAdapter.FillByName(RegisterDBTables.Taxes, tbxFilter.Text)
        End Select
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        TaxesTableAdapter.Fill(RegisterDBTables.Taxes)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvTaxes.SelectedRows.Count = 0 Then 'Communicate the selection process to the user
            MessageBox.Show(Me, strROW_NOT_SELECTED, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then 'Confirmation box to account for accidents
            For Each row As DataGridViewRow In dgvTaxes.SelectedRows
                TaxesTableAdapter.Delete(row.Cells.Item(0).Value, row.Cells.Item(1).Value, row.Cells.Item(2).Value)
            Next

            TaxesTableAdapter.Update(RegisterDBTables.Taxes)

            TaxesTableAdapter.Fill(RegisterDBTables.Taxes)
        End If
    End Sub

    Private Sub dgvTaxes_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvTaxes.RowStateChanged
        If e.StateChanged = DataGridViewElementStates.Selected And dgvTaxes.SelectedRows.Count = 1 Then 'Check if the state is "selected"
            Dim table = TaxesTableAdapter.GetDataBy5(dgvTaxes.SelectedRows.Item(0).Cells.Item(0).Value) 'Get selected row
            Dim row = table.Item(0)

            Dim currentTags = row.Tags.Split(";")

            'For Each tagId As String In currentTags
            '   lbxTags.SetItemChecked(lbxTags.Items.IndexOf(tagId), True)
            'Next

            For i As Integer = 0 To lbxTags.Items.Count - 1 Step 1 'Change checked tags to match database
                lbxTags.SetItemChecked(i, currentTags.Contains(lbxTags.Items.Item(i).ToString()))
            Next

            lbxTags.Visible = True
        Else

        End If
    End Sub

    Private Sub btnApplyTags_Click(sender As Object, e As EventArgs) Handles btnApplyTags.Click
        If dgvTaxes.SelectedRows.Count = 0 Then 'Communicate the selection process to the user
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

        For Each row As DataGridViewRow In dgvTaxes.SelectedRows
            TaxesTableAdapter.UpdateQuery(tags, row.Cells.Item(0).Value.ToString(), row.Cells.Item(1).Value.ToString())
        Next

        MessageBox.Show(strAPPLY_TAGS_SUCCESS)
    End Sub

    Private Sub btnSelection_Click(sender As Object, e As EventArgs) Handles btnSelection.Click
        Dim selectOrDeselect As Boolean = lbxTags.CheckedItems.Count.Equals(0) 'Flag to set every item to. if nothing is selected, it equals true. false otherwise
        For i As Integer = 0 To lbxTags.Items.Count - 1 Step 1 'Change every tag
            lbxTags.SetItemChecked(i, selectOrDeselect)
        Next
    End Sub
End Class