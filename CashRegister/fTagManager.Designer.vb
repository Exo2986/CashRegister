<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fTagManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.tabFilter = New System.Windows.Forms.TabControl()
        Me.tbpgNew = New System.Windows.Forms.TabPage()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnClearFilter = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.tbxFilter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxColumn = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvTags = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisterDBTables = New CashRegister.RegisterDBTables()
        Me.btnAssocTaxes = New System.Windows.Forms.Button()
        Me.TagsTableAdapter = New CashRegister.RegisterDBTablesTableAdapters.TagsTableAdapter()
        Me.TableAdapterManager = New CashRegister.RegisterDBTablesTableAdapters.TableAdapterManager()
        Me.TaxesTableAdapter = New CashRegister.RegisterDBTablesTableAdapters.TaxesTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Me.tabFilter.SuspendLayout()
        Me.tbpgNew.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvTags, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterDBTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(188, 19)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(162, 48)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Name:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(13, 388)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 27)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Selected Tag(s)"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'tabFilter
        '
        Me.tabFilter.Controls.Add(Me.tbpgNew)
        Me.tabFilter.Controls.Add(Me.TabPage2)
        Me.tabFilter.Location = New System.Drawing.Point(13, 421)
        Me.tabFilter.Name = "tabFilter"
        Me.tabFilter.SelectedIndex = 0
        Me.tabFilter.Size = New System.Drawing.Size(484, 147)
        Me.tabFilter.TabIndex = 4
        '
        'tbpgNew
        '
        Me.tbpgNew.AutoScroll = True
        Me.tbpgNew.Controls.Add(Me.btnClear)
        Me.tbpgNew.Controls.Add(Me.btnAdd)
        Me.tbpgNew.Controls.Add(IdLabel)
        Me.tbpgNew.Controls.Add(Me.tbxID)
        Me.tbpgNew.Controls.Add(NameLabel)
        Me.tbpgNew.Controls.Add(Me.tbxName)
        Me.tbpgNew.Location = New System.Drawing.Point(4, 25)
        Me.tbpgNew.Name = "tbpgNew"
        Me.tbpgNew.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgNew.Size = New System.Drawing.Size(476, 118)
        Me.tbpgNew.TabIndex = 0
        Me.tbpgNew.Text = "Add New Tag"
        Me.tbpgNew.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(247, 74)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 31)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(165, 74)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 31)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbxID
        '
        Me.tbxID.Location = New System.Drawing.Point(217, 16)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.Size = New System.Drawing.Size(100, 23)
        Me.tbxID.TabIndex = 1
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(217, 45)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(100, 23)
        Me.tbxName.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnClearFilter)
        Me.TabPage2.Controls.Add(Me.btnFilter)
        Me.TabPage2.Controls.Add(Me.tbxFilter)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cbxColumn)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(476, 118)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnClearFilter
        '
        Me.btnClearFilter.Location = New System.Drawing.Point(341, 62)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(70, 27)
        Me.btnClearFilter.TabIndex = 5
        Me.btnClearFilter.Text = "Reset"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(341, 29)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(70, 27)
        Me.btnFilter.TabIndex = 4
        Me.btnFilter.Text = "Go"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'tbxFilter
        '
        Me.tbxFilter.Location = New System.Drawing.Point(235, 31)
        Me.tbxFilter.Name = "tbxFilter"
        Me.tbxFilter.Size = New System.Drawing.Size(100, 23)
        Me.tbxFilter.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "For"
        '
        'cbxColumn
        '
        Me.cbxColumn.FormattingEnabled = True
        Me.cbxColumn.Items.AddRange(New Object() {"Id", "Name"})
        Me.cbxColumn.Location = New System.Drawing.Point(124, 31)
        Me.cbxColumn.Name = "cbxColumn"
        Me.cbxColumn.Size = New System.Drawing.Size(70, 24)
        Me.cbxColumn.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'dgvTags
        '
        Me.dgvTags.AllowUserToAddRows = False
        Me.dgvTags.AllowUserToDeleteRows = False
        Me.dgvTags.AutoGenerateColumns = False
        Me.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTags.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.dgvTags.DataSource = Me.TagsBindingSource
        Me.dgvTags.Location = New System.Drawing.Point(13, 13)
        Me.dgvTags.Name = "dgvTags"
        Me.dgvTags.Size = New System.Drawing.Size(480, 369)
        Me.dgvTags.TabIndex = 5
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'TagsBindingSource
        '
        Me.TagsBindingSource.DataMember = "Tags"
        Me.TagsBindingSource.DataSource = Me.RegisterDBTables
        '
        'RegisterDBTables
        '
        Me.RegisterDBTables.DataSetName = "RegisterDBTables"
        Me.RegisterDBTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAssocTaxes
        '
        Me.btnAssocTaxes.Location = New System.Drawing.Point(323, 388)
        Me.btnAssocTaxes.Name = "btnAssocTaxes"
        Me.btnAssocTaxes.Size = New System.Drawing.Size(170, 27)
        Me.btnAssocTaxes.TabIndex = 6
        Me.btnAssocTaxes.Text = "View Associated Taxes"
        Me.btnAssocTaxes.UseVisualStyleBackColor = True
        '
        'TagsTableAdapter
        '
        Me.TagsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.TagsTableAdapter = Me.TagsTableAdapter
        Me.TableAdapterManager.TaxesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CashRegister.RegisterDBTablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TaxesTableAdapter
        '
        Me.TaxesTableAdapter.ClearBeforeFill = True
        '
        'fTagManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 580)
        Me.Controls.Add(Me.btnAssocTaxes)
        Me.Controls.Add(Me.dgvTags)
        Me.Controls.Add(Me.tabFilter)
        Me.Controls.Add(Me.btnDelete)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fTagManager"
        Me.Text = "fTagManager"
        Me.tabFilter.ResumeLayout(False)
        Me.tbpgNew.ResumeLayout(False)
        Me.tbpgNew.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvTags, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterDBTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelete As Button
    Friend WithEvents tabFilter As TabControl
    Friend WithEvents tbpgNew As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RegisterDBTables As RegisterDBTables
    Friend WithEvents TagsBindingSource As BindingSource
    Friend WithEvents TagsTableAdapter As RegisterDBTablesTableAdapters.TagsTableAdapter
    Friend WithEvents TableAdapterManager As RegisterDBTablesTableAdapters.TableAdapterManager
    Friend WithEvents btnAdd As Button
    Friend WithEvents tbxID As TextBox
    Friend WithEvents tbxName As TextBox
    Friend WithEvents dgvTags As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents tbxFilter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxColumn As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAssocTaxes As Button
    Friend WithEvents TaxesTableAdapter As RegisterDBTablesTableAdapters.TaxesTableAdapter
End Class
