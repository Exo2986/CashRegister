﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.spltBase = New System.Windows.Forms.SplitContainer()
        Me.tabcItems = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnOpenTax = New System.Windows.Forms.Button()
        Me.btnOpenTag = New System.Windows.Forms.Button()
        Me.btnOpenProduct = New System.Windows.Forms.Button()
        CType(Me.spltBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltBase.Panel1.SuspendLayout()
        Me.spltBase.SuspendLayout()
        Me.tabcItems.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.tabcItems.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabcItems.Controls.Add(Me.TabPage1)
        Me.tabcItems.Controls.Add(Me.TabPage2)
        Me.tabcItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcItems.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabcItems.ItemSize = New System.Drawing.Size(15, 75)
        Me.tabcItems.Location = New System.Drawing.Point(0, 0)
        Me.tabcItems.Multiline = True
        Me.tabcItems.Name = "tabcItems"
        Me.tabcItems.SelectedIndex = 0
        Me.tabcItems.Size = New System.Drawing.Size(669, 761)
        Me.tabcItems.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(79, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(586, 753)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(580, 747)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnOpenProduct)
        Me.TabPage2.Controls.Add(Me.btnOpenTax)
        Me.TabPage2.Controls.Add(Me.btnOpenTag)
        Me.TabPage2.Location = New System.Drawing.Point(79, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(586, 753)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnOpenTax
        '
        Me.btnOpenTax.Location = New System.Drawing.Point(230, 30)
        Me.btnOpenTax.Name = "btnOpenTax"
        Me.btnOpenTax.Size = New System.Drawing.Size(111, 35)
        Me.btnOpenTax.TabIndex = 1
        Me.btnOpenTax.Text = "Tax Manager"
        Me.btnOpenTax.UseVisualStyleBackColor = True
        '
        'btnOpenTag
        '
        Me.btnOpenTag.Location = New System.Drawing.Point(83, 30)
        Me.btnOpenTag.Name = "btnOpenTag"
        Me.btnOpenTag.Size = New System.Drawing.Size(111, 35)
        Me.btnOpenTag.TabIndex = 0
        Me.btnOpenTag.Text = "Tag Manager"
        Me.btnOpenTag.UseVisualStyleBackColor = True
        '
        'btnOpenProduct
        '
        Me.btnOpenProduct.Location = New System.Drawing.Point(377, 30)
        Me.btnOpenProduct.Name = "btnOpenProduct"
        Me.btnOpenProduct.Size = New System.Drawing.Size(131, 35)
        Me.btnOpenProduct.TabIndex = 2
        Me.btnOpenProduct.Text = "Product Manager"
        Me.btnOpenProduct.UseVisualStyleBackColor = True
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
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents spltBase As SplitContainer
    Friend WithEvents tabcItems As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOpenTax As Button
    Friend WithEvents btnOpenTag As Button
    Friend WithEvents btnOpenProduct As Button
End Class
