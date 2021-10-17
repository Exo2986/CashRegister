Public Class fTagManager

    Private Sub fTagManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegisterDBTables.Tags' table. You can move, or remove it, as needed.
        Me.TagsTableAdapter.Fill(Me.RegisterDBTables.Tags)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click 'Add new tag to the database
        Try
            Dim row = RegisterDBTables.Tags.NewTagsRow()

            If String.IsNullOrWhiteSpace(tbxID.Text) Or String.IsNullOrWhiteSpace(tbxName.Text) Then
                MessageBox.Show(Me, "Please input data.")
            End If

            row.Id = tbxID.Text
            row.Name = tbxName.Text

            RegisterDBTables.Tags.AddTagsRow(row)

            TagsTableAdapter.Update(RegisterDBTables.Tags)

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
        If MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
            For Each row As DataGridViewRow In dgvTags.SelectedRows
                TagsTableAdapter.Delete(row.Cells.Item(0).Value, row.Cells.Item(1).Value)
            Next

            TagsTableAdapter.Update(RegisterDBTables.Tags)

            TagsTableAdapter.Fill(RegisterDBTables.Tags)
        End If
    End Sub
End Class