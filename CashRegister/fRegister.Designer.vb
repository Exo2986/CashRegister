<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fRegister
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
        Me.spltBase = New System.Windows.Forms.SplitContainer()
        Me.tabcItems = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnPagesManager = New System.Windows.Forms.Button()
        Me.btnOpenProduct = New System.Windows.Forms.Button()
        Me.btnOpenTax = New System.Windows.Forms.Button()
        Me.btnOpenTag = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbxTotal = New System.Windows.Forms.TextBox()
        Me.tbxTax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxSubtotal = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnQuantity = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.lbxReceipt = New System.Windows.Forms.ListBox()
        Me.RegisterDBTables = New CashRegister.RegisterDBTables()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New CashRegister.RegisterDBTablesTableAdapters.ProductsTableAdapter()
        Me.TagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TagsTableAdapter = New CashRegister.RegisterDBTablesTableAdapters.TagsTableAdapter()
        Me.TaxesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaxesTableAdapter = New CashRegister.RegisterDBTablesTableAdapters.TaxesTableAdapter()
        Me.PagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagesTableAdapter = New CashRegister.RegisterDBTablesTableAdapters.PagesTableAdapter()
        CType(Me.spltBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltBase.Panel1.SuspendLayout()
        Me.spltBase.Panel2.SuspendLayout()
        Me.spltBase.SuspendLayout()
        Me.tabcItems.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RegisterDBTables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spltBase
        '
        Me.spltBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltBase.Location = New System.Drawing.Point(0, 0)
        Me.spltBase.Name = "spltBase"
        '
        'spltBase.Panel1
        '
        Me.spltBase.Panel1.Controls.Add(Me.tabcItems)
        '
        'spltBase.Panel2
        '
        Me.spltBase.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.spltBase.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.spltBase.Panel2.Controls.Add(Me.lbxReceipt)
        Me.spltBase.Size = New System.Drawing.Size(984, 761)
        Me.spltBase.SplitterDistance = 669
        Me.spltBase.TabIndex = 0
        '
        'tabcItems
        '
        Me.tabcItems.Controls.Add(Me.TabPage2)
        Me.tabcItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcItems.ItemSize = New System.Drawing.Size(15, 75)
        Me.tabcItems.Location = New System.Drawing.Point(0, 0)
        Me.tabcItems.Multiline = True
        Me.tabcItems.Name = "tabcItems"
        Me.tabcItems.SelectedIndex = 0
        Me.tabcItems.Size = New System.Drawing.Size(669, 761)
        Me.tabcItems.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnPagesManager)
        Me.TabPage2.Controls.Add(Me.btnOpenProduct)
        Me.TabPage2.Controls.Add(Me.btnOpenTax)
        Me.TabPage2.Controls.Add(Me.btnOpenTag)
        Me.TabPage2.Location = New System.Drawing.Point(4, 79)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(661, 678)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Tag = "Settings"
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnPagesManager
        '
        Me.btnPagesManager.Location = New System.Drawing.Point(195, 99)
        Me.btnPagesManager.Name = "btnPagesManager"
        Me.btnPagesManager.Size = New System.Drawing.Size(111, 42)
        Me.btnPagesManager.TabIndex = 3
        Me.btnPagesManager.Text = "Pages Manager"
        Me.btnPagesManager.UseVisualStyleBackColor = True
        '
        'btnOpenProduct
        '
        Me.btnOpenProduct.Location = New System.Drawing.Point(48, 99)
        Me.btnOpenProduct.Name = "btnOpenProduct"
        Me.btnOpenProduct.Size = New System.Drawing.Size(111, 42)
        Me.btnOpenProduct.TabIndex = 2
        Me.btnOpenProduct.Text = "Product Manager"
        Me.btnOpenProduct.UseVisualStyleBackColor = True
        '
        'btnOpenTax
        '
        Me.btnOpenTax.Location = New System.Drawing.Point(195, 34)
        Me.btnOpenTax.Name = "btnOpenTax"
        Me.btnOpenTax.Size = New System.Drawing.Size(111, 42)
        Me.btnOpenTax.TabIndex = 1
        Me.btnOpenTax.Text = "Tax Manager"
        Me.btnOpenTax.UseVisualStyleBackColor = True
        '
        'btnOpenTag
        '
        Me.btnOpenTag.Location = New System.Drawing.Point(48, 34)
        Me.btnOpenTag.Name = "btnOpenTag"
        Me.btnOpenTag.Size = New System.Drawing.Size(111, 42)
        Me.btnOpenTag.TabIndex = 0
        Me.btnOpenTag.Text = "Tag Manager"
        Me.btnOpenTag.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.tbxTotal, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tbxTax, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbxSubtotal, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 612)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(310, 64)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'tbxTotal
        '
        Me.tbxTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tbxTotal.Location = New System.Drawing.Point(206, 32)
        Me.tbxTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.tbxTotal.Multiline = True
        Me.tbxTotal.Name = "tbxTotal"
        Me.tbxTotal.ReadOnly = True
        Me.tbxTotal.Size = New System.Drawing.Size(104, 32)
        Me.tbxTotal.TabIndex = 5
        Me.tbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxTax
        '
        Me.tbxTax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tbxTax.Location = New System.Drawing.Point(103, 32)
        Me.tbxTax.Margin = New System.Windows.Forms.Padding(0)
        Me.tbxTax.Multiline = True
        Me.tbxTax.Name = "tbxTax"
        Me.tbxTax.ReadOnly = True
        Me.tbxTax.Size = New System.Drawing.Size(103, 32)
        Me.tbxTax.TabIndex = 4
        Me.tbxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(209, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(106, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxSubtotal
        '
        Me.tbxSubtotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tbxSubtotal.Location = New System.Drawing.Point(0, 32)
        Me.tbxSubtotal.Margin = New System.Windows.Forms.Padding(0)
        Me.tbxSubtotal.Multiline = True
        Me.tbxSubtotal.Name = "tbxSubtotal"
        Me.tbxSubtotal.ReadOnly = True
        Me.tbxSubtotal.Size = New System.Drawing.Size(103, 32)
        Me.tbxSubtotal.TabIndex = 3
        Me.tbxSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnQuantity, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMinus, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 677)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(309, 83)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(206, 0)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 41)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "+1"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnQuantity
        '
        Me.btnQuantity.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuantity.Location = New System.Drawing.Point(103, 0)
        Me.btnQuantity.Margin = New System.Windows.Forms.Padding(0)
        Me.btnQuantity.Name = "btnQuantity"
        Me.btnQuantity.Size = New System.Drawing.Size(103, 41)
        Me.btnQuantity.TabIndex = 1
        Me.btnQuantity.Text = "Quantity"
        Me.btnQuantity.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinus.Location = New System.Drawing.Point(0, 0)
        Me.btnMinus.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(103, 41)
        Me.btnMinus.TabIndex = 0
        Me.btnMinus.Text = "-1"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'lbxReceipt
        '
        Me.lbxReceipt.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbxReceipt.FormattingEnabled = True
        Me.lbxReceipt.ItemHeight = 16
        Me.lbxReceipt.Location = New System.Drawing.Point(0, 0)
        Me.lbxReceipt.Margin = New System.Windows.Forms.Padding(0)
        Me.lbxReceipt.Name = "lbxReceipt"
        Me.lbxReceipt.Size = New System.Drawing.Size(311, 612)
        Me.lbxReceipt.TabIndex = 0
        '
        'RegisterDBTables
        '
        Me.RegisterDBTables.DataSetName = "RegisterDBTables"
        Me.RegisterDBTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.RegisterDBTables
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TagsBindingSource
        '
        Me.TagsBindingSource.DataMember = "Tags"
        Me.TagsBindingSource.DataSource = Me.RegisterDBTables
        '
        'TagsTableAdapter
        '
        Me.TagsTableAdapter.ClearBeforeFill = True
        '
        'TaxesBindingSource
        '
        Me.TaxesBindingSource.DataMember = "Taxes"
        Me.TaxesBindingSource.DataSource = Me.RegisterDBTables
        '
        'TaxesTableAdapter
        '
        Me.TaxesTableAdapter.ClearBeforeFill = True
        '
        'PagesBindingSource
        '
        Me.PagesBindingSource.DataMember = "Pages"
        Me.PagesBindingSource.DataSource = Me.RegisterDBTables
        '
        'PagesTableAdapter
        '
        Me.PagesTableAdapter.ClearBeforeFill = True
        '
        'fRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.spltBase)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fRegister"
        Me.Text = "Cash Register"
        Me.spltBase.Panel1.ResumeLayout(False)
        Me.spltBase.Panel2.ResumeLayout(False)
        CType(Me.spltBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltBase.ResumeLayout(False)
        Me.tabcItems.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.RegisterDBTables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents spltBase As SplitContainer
    Friend WithEvents tabcItems As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnOpenTax As Button
    Friend WithEvents btnOpenTag As Button
    Friend WithEvents btnOpenProduct As Button
    Friend WithEvents RegisterDBTables As RegisterDBTables
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As RegisterDBTablesTableAdapters.ProductsTableAdapter
    Friend WithEvents TagsBindingSource As BindingSource
    Friend WithEvents TagsTableAdapter As RegisterDBTablesTableAdapters.TagsTableAdapter
    Friend WithEvents TaxesBindingSource As BindingSource
    Friend WithEvents TaxesTableAdapter As RegisterDBTablesTableAdapters.TaxesTableAdapter
    Friend WithEvents btnPagesManager As Button
    Friend WithEvents PagesBindingSource As BindingSource
    Friend WithEvents PagesTableAdapter As RegisterDBTablesTableAdapters.PagesTableAdapter
    Friend WithEvents lbxReceipt As ListBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnQuantity As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents tbxTotal As TextBox
    Friend WithEvents tbxTax As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxSubtotal As TextBox
End Class
