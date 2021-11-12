<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fNewProduct
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
        Dim Label3 As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClearFilter = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.tbxFilter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSelection = New System.Windows.Forms.Button()
        Me.btnApplyTags = New System.Windows.Forms.Button()
        Me.lbxTags = New System.Windows.Forms.CheckedListBox()
        Me.cbxColumn = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nbxPrice = New System.Windows.Forms.NumericUpDown()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.tbpgNew = New System.Windows.Forms.TabPage()
        Me.tabFilter = New System.Windows.Forms.TabControl()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisterDBTables = New CashRegister.RegisterDBTables()
        Me.TagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New CashRegister.RegisterDBTablesTableAdapters.TableAdapterManager()
        Me.TagsTableAdapter = New CashRegister.RegisterDBTablesTableAdapters.TagsTableAdapter()
        Me.ProductsTableAdapter = New CashRegister.RegisterDBTablesTableAdapters.ProductsTableAdapter()
        Label3 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Me.TabPage2.SuspendLayout()
        CType(Me.nbxPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpgNew.SuspendLayout()
        Me.tabFilter.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterDBTables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(167, 79)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(44, 17)
        Label3.TabIndex = 6
        Label3.Text = "Price:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(188, 21)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(162, 50)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Name:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(16, 387)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 27)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete Selected Row(s)"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClearFilter
        '
        Me.btnClearFilter.Location = New System.Drawing.Point(341, 80)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(70, 27)
        Me.btnClearFilter.TabIndex = 5
        Me.btnClearFilter.Text = "Reset"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(341, 47)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(70, 27)
        Me.btnFilter.TabIndex = 4
        Me.btnFilter.Text = "Go"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'tbxFilter
        '
        Me.tbxFilter.Location = New System.Drawing.Point(235, 49)
        Me.tbxFilter.Name = "tbxFilter"
        Me.tbxFilter.Size = New System.Drawing.Size(100, 23)
        Me.tbxFilter.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "For"
        '
        'btnSelection
        '
        Me.btnSelection.Location = New System.Drawing.Point(671, 568)
        Me.btnSelection.Name = "btnSelection"
        Me.btnSelection.Size = New System.Drawing.Size(151, 31)
        Me.btnSelection.TabIndex = 19
        Me.btnSelection.Text = "Select/Deselect All"
        Me.btnSelection.UseVisualStyleBackColor = True
        '
        'btnApplyTags
        '
        Me.btnApplyTags.Location = New System.Drawing.Point(506, 568)
        Me.btnApplyTags.Name = "btnApplyTags"
        Me.btnApplyTags.Size = New System.Drawing.Size(151, 31)
        Me.btnApplyTags.TabIndex = 18
        Me.btnApplyTags.Text = "Apply Tags"
        Me.btnApplyTags.UseVisualStyleBackColor = True
        '
        'lbxTags
        '
        Me.lbxTags.FormattingEnabled = True
        Me.lbxTags.Location = New System.Drawing.Point(503, 13)
        Me.lbxTags.Name = "lbxTags"
        Me.lbxTags.Size = New System.Drawing.Size(319, 544)
        Me.lbxTags.TabIndex = 17
        Me.lbxTags.Visible = False
        '
        'cbxColumn
        '
        Me.cbxColumn.FormattingEnabled = True
        Me.cbxColumn.Items.AddRange(New Object() {"Id", "Name"})
        Me.cbxColumn.Location = New System.Drawing.Point(124, 49)
        Me.cbxColumn.Name = "cbxColumn"
        Me.cbxColumn.Size = New System.Drawing.Size(70, 24)
        Me.cbxColumn.TabIndex = 1
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
        Me.TabPage2.Size = New System.Drawing.Size(476, 154)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'nbxPrice
        '
        Me.nbxPrice.DecimalPlaces = 2
        Me.nbxPrice.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nbxPrice.Location = New System.Drawing.Point(217, 77)
        Me.nbxPrice.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nbxPrice.Name = "nbxPrice"
        Me.nbxPrice.Size = New System.Drawing.Size(100, 23)
        Me.nbxPrice.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(247, 105)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 31)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(165, 105)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 31)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbxID
        '
        Me.tbxID.Location = New System.Drawing.Point(217, 18)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.Size = New System.Drawing.Size(100, 23)
        Me.tbxID.TabIndex = 1
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(217, 47)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(100, 23)
        Me.tbxName.TabIndex = 3
        '
        'tbpgNew
        '
        Me.tbpgNew.AutoScroll = True
        Me.tbpgNew.Controls.Add(Me.nbxPrice)
        Me.tbpgNew.Controls.Add(Label3)
        Me.tbpgNew.Controls.Add(Me.btnClear)
        Me.tbpgNew.Controls.Add(Me.btnAdd)
        Me.tbpgNew.Controls.Add(IdLabel)
        Me.tbpgNew.Controls.Add(Me.tbxID)
        Me.tbpgNew.Controls.Add(NameLabel)
        Me.tbpgNew.Controls.Add(Me.tbxName)
        Me.tbpgNew.Location = New System.Drawing.Point(4, 25)
        Me.tbpgNew.Name = "tbpgNew"
        Me.tbpgNew.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgNew.Size = New System.Drawing.Size(476, 154)
        Me.tbpgNew.TabIndex = 0
        Me.tbpgNew.Text = "Add New Product"
        Me.tbpgNew.UseVisualStyleBackColor = True
        '
        'tabFilter
        '
        Me.tabFilter.Controls.Add(Me.tbpgNew)
        Me.tabFilter.Controls.Add(Me.TabPage2)
        Me.tabFilter.Location = New System.Drawing.Point(16, 420)
        Me.tabFilter.Name = "tabFilter"
        Me.tabFilter.SelectedIndex = 0
        Me.tabFilter.Size = New System.Drawing.Size(484, 183)
        Me.tabFilter.TabIndex = 15
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AutoGenerateColumns = False
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.dgvProducts.DataSource = Me.ProductsBindingSource
        Me.dgvProducts.Location = New System.Drawing.Point(16, 13)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(480, 368)
        Me.dgvProducts.TabIndex = 20
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.RegisterDBTables
        '
        'RegisterDBTables
        '
        Me.RegisterDBTables.DataSetName = "RegisterDBTables"
        Me.RegisterDBTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TagsBindingSource
        '
        Me.TagsBindingSource.DataMember = "Tags"
        Me.TagsBindingSource.DataSource = Me.RegisterDBTables
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PagesTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.TagsTableAdapter = Me.TagsTableAdapter
        Me.TableAdapterManager.TaxesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CashRegister.RegisterDBTablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TagsTableAdapter
        '
        Me.TagsTableAdapter.ClearBeforeFill = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'fNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 616)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSelection)
        Me.Controls.Add(Me.btnApplyTags)
        Me.Controls.Add(Me.lbxTags)
        Me.Controls.Add(Me.tabFilter)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fNewProduct"
        Me.Text = "fNewProduct"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nbxPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpgNew.ResumeLayout(False)
        Me.tbpgNew.PerformLayout()
        Me.tabFilter.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterDBTables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents tbxFilter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RegisterDBTables As RegisterDBTables
    Friend WithEvents btnSelection As Button
    Friend WithEvents btnApplyTags As Button
    Friend WithEvents lbxTags As CheckedListBox
    Friend WithEvents TagsBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As RegisterDBTablesTableAdapters.TableAdapterManager
    Friend WithEvents TagsTableAdapter As RegisterDBTablesTableAdapters.TagsTableAdapter
    Friend WithEvents cbxColumn As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents nbxPrice As NumericUpDown
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents tbxID As TextBox
    Friend WithEvents tbxName As TextBox
    Friend WithEvents tbpgNew As TabPage
    Friend WithEvents tabFilter As TabControl
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As RegisterDBTablesTableAdapters.ProductsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
