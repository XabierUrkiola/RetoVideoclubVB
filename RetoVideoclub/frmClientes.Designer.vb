<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView_Clientes = New System.Windows.Forms.DataGridView()
        Me.EMPRESADataSet = New RetoVideoclub.EMPRESADataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New RetoVideoclub.EMPRESADataSetTableAdapters.ClientesTableAdapter()
        Me.ClienteIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsBajaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Clientes
        '
        Me.DataGridView_Clientes.AutoGenerateColumns = False
        Me.DataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteIdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.Apellido1DataGridViewTextBoxColumn, Me.Apellido2DataGridViewTextBoxColumn, Me.EsBajaDataGridViewCheckBoxColumn})
        Me.DataGridView_Clientes.DataSource = Me.ClientesBindingSource
        Me.DataGridView_Clientes.Location = New System.Drawing.Point(36, 12)
        Me.DataGridView_Clientes.Name = "DataGridView_Clientes"
        Me.DataGridView_Clientes.Size = New System.Drawing.Size(541, 281)
        Me.DataGridView_Clientes.TabIndex = 0
        '
        'EMPRESADataSet
        '
        Me.EMPRESADataSet.DataSetName = "EMPRESADataSet"
        Me.EMPRESADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.EMPRESADataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ClienteIdDataGridViewTextBoxColumn
        '
        Me.ClienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId"
        Me.ClienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId"
        Me.ClienteIdDataGridViewTextBoxColumn.Name = "ClienteIdDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'Apellido1DataGridViewTextBoxColumn
        '
        Me.Apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.HeaderText = "Apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.Name = "Apellido1DataGridViewTextBoxColumn"
        '
        'Apellido2DataGridViewTextBoxColumn
        '
        Me.Apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.HeaderText = "Apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.Name = "Apellido2DataGridViewTextBoxColumn"
        '
        'EsBajaDataGridViewCheckBoxColumn
        '
        Me.EsBajaDataGridViewCheckBoxColumn.DataPropertyName = "EsBaja"
        Me.EsBajaDataGridViewCheckBoxColumn.HeaderText = "EsBaja"
        Me.EsBajaDataGridViewCheckBoxColumn.Name = "EsBajaDataGridViewCheckBoxColumn"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 392)
        Me.Controls.Add(Me.DataGridView_Clientes)
        Me.Name = "frmClientes"
        Me.Text = "frmClientes"
        CType(Me.DataGridView_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_Clientes As DataGridView
    Friend WithEvents EMPRESADataSet As EMPRESADataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As EMPRESADataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ClienteIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EsBajaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
