﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridViewDecimalColumn8 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn9 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn10 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn11 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn12 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn13 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn14 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewCheckBoxColumn2 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewImageColumn2 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.NwindDataSet = New GridCheckAllGroupRowsVB.NwindDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New GridCheckAllGroupRowsVB.NwindDataSetTableAdapters.ProductsTableAdapter()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridView1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewDecimalColumn8.DataType = GetType(Integer)
        GridViewDecimalColumn8.FieldName = "ProductID"
        GridViewDecimalColumn8.HeaderText = "ProductID"
        GridViewDecimalColumn8.IsAutoGenerated = True
        GridViewDecimalColumn8.Name = "ProductID"
        GridViewDecimalColumn8.Width = 89
        GridViewTextBoxColumn3.FieldName = "ProductName"
        GridViewTextBoxColumn3.HeaderText = "ProductName"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.Name = "ProductName"
        GridViewTextBoxColumn3.Width = 89
        GridViewDecimalColumn9.DataType = GetType(Integer)
        GridViewDecimalColumn9.FieldName = "SupplierID"
        GridViewDecimalColumn9.HeaderText = "SupplierID"
        GridViewDecimalColumn9.IsAutoGenerated = True
        GridViewDecimalColumn9.Name = "SupplierID"
        GridViewDecimalColumn9.Width = 89
        GridViewDecimalColumn10.DataType = GetType(Integer)
        GridViewDecimalColumn10.FieldName = "CategoryID"
        GridViewDecimalColumn10.HeaderText = "CategoryID"
        GridViewDecimalColumn10.IsAutoGenerated = True
        GridViewDecimalColumn10.Name = "CategoryID"
        GridViewDecimalColumn10.Width = 89
        GridViewTextBoxColumn4.FieldName = "QuantityPerUnit"
        GridViewTextBoxColumn4.HeaderText = "QuantityPerUnit"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "QuantityPerUnit"
        GridViewTextBoxColumn4.Width = 89
        GridViewDecimalColumn11.FieldName = "UnitPrice"
        GridViewDecimalColumn11.HeaderText = "UnitPrice"
        GridViewDecimalColumn11.IsAutoGenerated = True
        GridViewDecimalColumn11.Name = "UnitPrice"
        GridViewDecimalColumn11.Width = 89
        GridViewDecimalColumn12.DataType = GetType(Short)
        GridViewDecimalColumn12.FieldName = "UnitsInStock"
        GridViewDecimalColumn12.HeaderText = "UnitsInStock"
        GridViewDecimalColumn12.IsAutoGenerated = True
        GridViewDecimalColumn12.Name = "UnitsInStock"
        GridViewDecimalColumn12.Width = 89
        GridViewDecimalColumn13.DataType = GetType(Short)
        GridViewDecimalColumn13.FieldName = "UnitsOnOrder"
        GridViewDecimalColumn13.HeaderText = "UnitsOnOrder"
        GridViewDecimalColumn13.IsAutoGenerated = True
        GridViewDecimalColumn13.Name = "UnitsOnOrder"
        GridViewDecimalColumn13.Width = 89
        GridViewDecimalColumn14.DataType = GetType(Short)
        GridViewDecimalColumn14.FieldName = "ReorderLevel"
        GridViewDecimalColumn14.HeaderText = "ReorderLevel"
        GridViewDecimalColumn14.IsAutoGenerated = True
        GridViewDecimalColumn14.Name = "ReorderLevel"
        GridViewDecimalColumn14.Width = 89
        GridViewCheckBoxColumn2.EditMode = Telerik.WinControls.UI.EditMode.OnValueChange
        GridViewCheckBoxColumn2.FieldName = "Discontinued"
        GridViewCheckBoxColumn2.HeaderText = "Discontinued"
        GridViewCheckBoxColumn2.IsAutoGenerated = True
        GridViewCheckBoxColumn2.Name = "Discontinued"
        GridViewCheckBoxColumn2.Width = 89
        GridViewImageColumn2.DataType = GetType(Byte())
        GridViewImageColumn2.FieldName = "Picture"
        GridViewImageColumn2.HeaderText = "Picture"
        GridViewImageColumn2.IsAutoGenerated = True
        GridViewImageColumn2.Name = "Picture"
        GridViewImageColumn2.Width = 91
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn8, GridViewTextBoxColumn3, GridViewDecimalColumn9, GridViewDecimalColumn10, GridViewTextBoxColumn4, GridViewDecimalColumn11, GridViewDecimalColumn12, GridViewDecimalColumn13, GridViewDecimalColumn14, GridViewCheckBoxColumn2, GridViewImageColumn2})
        Me.RadGridView1.MasterTemplate.DataSource = Me.ProductsBindingSource
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(992, 470)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        '
        'NwindDataSet
        '
        Me.NwindDataSet.DataSetName = "NwindDataSet"
        Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.NwindDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 470)
        Me.Controls.Add(Me.RadGridView1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents NwindDataSet As GridCheckAllGroupRowsVB.NwindDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As GridCheckAllGroupRowsVB.NwindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
End Class

