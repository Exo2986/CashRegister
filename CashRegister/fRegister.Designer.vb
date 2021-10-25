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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnOpenProduct = New System.Windows.Forms.Button()
        Me.btnOpenTax = New System.Windows.Forms.Button()
        Me.btnOpenTag = New System.Windows.Forms.Button()
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
        Me.spltBase.SuspendLayout()
        Me.tabcItems.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.btnOpenProduct)
        Me.TabPage2.Controls.Add(Me.btnOpenTax)
        Me.TabPage2.Controls.Add(Me.btnOpenTag)
        Me.TabPage2.Location = New System.Drawing.Point(4, 79)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(661, 678)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Pages Manager"
        Me.Button1.UseVisualStyleBackColor = True
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
        CType(Me.spltBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltBase.ResumeLayout(False)
        Me.tabcItems.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents PagesBindingSource As BindingSource
    Friend WithEvents PagesTableAdapter As RegisterDBTablesTableAdapters.PagesTableAdapter
End Class
