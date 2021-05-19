<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Cambio_Detalle
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminarTCD = New System.Windows.Forms.Button()
        Me.BtnEditarTCD = New System.Windows.Forms.Button()
        Me.BtnGuardarTCD = New System.Windows.Forms.Button()
        Me.BtnNuevoTCD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIDTCD = New System.Windows.Forms.TextBox()
        Me.txtFTCD = New System.Windows.Forms.TextBox()
        Me.txtVTCD = New System.Windows.Forms.TextBox()
        Me.txtIDTCE = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KERMESSEDataSet = New Proyecto_Kermesse_v_1._1.KERMESSEDataSet()
        Me.TipoCambioDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoCambioDetTableAdapter = New Proyecto_Kermesse_v_1._1.KERMESSEDataSetTableAdapters.TipoCambioDetTableAdapter()
        Me.IdTipoCambioDetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoCambioEncDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBYSTCD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KERMESSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoCambioDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIDTCE)
        Me.GroupBox1.Controls.Add(Me.txtVTCD)
        Me.GroupBox1.Controls.Add(Me.txtFTCD)
        Me.GroupBox1.Controls.Add(Me.txtIDTCD)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnEliminarTCD)
        Me.GroupBox1.Controls.Add(Me.BtnEditarTCD)
        Me.GroupBox1.Controls.Add(Me.BtnGuardarTCD)
        Me.GroupBox1.Controls.Add(Me.BtnNuevoTCD)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Menu
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 218)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Tipo Cambio Detalle"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBYSTCD)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Menu
        Me.GroupBox2.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(666, 229)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda y Seleccion"
        '
        'BtnEliminarTCD
        '
        Me.BtnEliminarTCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarTCD.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEliminarTCD.Location = New System.Drawing.Point(540, 176)
        Me.BtnEliminarTCD.Name = "BtnEliminarTCD"
        Me.BtnEliminarTCD.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarTCD.TabIndex = 11
        Me.BtnEliminarTCD.Text = "Eliminar"
        Me.BtnEliminarTCD.UseVisualStyleBackColor = True
        '
        'BtnEditarTCD
        '
        Me.BtnEditarTCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarTCD.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEditarTCD.Location = New System.Drawing.Point(540, 122)
        Me.BtnEditarTCD.Name = "BtnEditarTCD"
        Me.BtnEditarTCD.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditarTCD.TabIndex = 10
        Me.BtnEditarTCD.Text = "Editar"
        Me.BtnEditarTCD.UseVisualStyleBackColor = True
        '
        'BtnGuardarTCD
        '
        Me.BtnGuardarTCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarTCD.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnGuardarTCD.Location = New System.Drawing.Point(540, 72)
        Me.BtnGuardarTCD.Name = "BtnGuardarTCD"
        Me.BtnGuardarTCD.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardarTCD.TabIndex = 9
        Me.BtnGuardarTCD.Text = "Guardar"
        Me.BtnGuardarTCD.UseVisualStyleBackColor = True
        '
        'BtnNuevoTCD
        '
        Me.BtnNuevoTCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoTCD.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnNuevoTCD.Location = New System.Drawing.Point(540, 22)
        Me.BtnNuevoTCD.Name = "BtnNuevoTCD"
        Me.BtnNuevoTCD.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevoTCD.TabIndex = 8
        Me.BtnNuevoTCD.Text = "Nuevo "
        Me.BtnNuevoTCD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID-TCD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Valor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ID-TCE"
        '
        'txtIDTCD
        '
        Me.txtIDTCD.Location = New System.Drawing.Point(55, 32)
        Me.txtIDTCD.Name = "txtIDTCD"
        Me.txtIDTCD.ReadOnly = True
        Me.txtIDTCD.Size = New System.Drawing.Size(39, 20)
        Me.txtIDTCD.TabIndex = 16
        '
        'txtFTCD
        '
        Me.txtFTCD.BackColor = System.Drawing.SystemColors.Menu
        Me.txtFTCD.Location = New System.Drawing.Point(55, 65)
        Me.txtFTCD.Name = "txtFTCD"
        Me.txtFTCD.Size = New System.Drawing.Size(100, 20)
        Me.txtFTCD.TabIndex = 17
        '
        'txtVTCD
        '
        Me.txtVTCD.BackColor = System.Drawing.SystemColors.Menu
        Me.txtVTCD.Location = New System.Drawing.Point(55, 107)
        Me.txtVTCD.Name = "txtVTCD"
        Me.txtVTCD.Size = New System.Drawing.Size(100, 20)
        Me.txtVTCD.TabIndex = 18
        '
        'txtIDTCE
        '
        Me.txtIDTCE.BackColor = System.Drawing.SystemColors.Menu
        Me.txtIDTCE.Location = New System.Drawing.Point(55, 149)
        Me.txtIDTCE.Name = "txtIDTCE"
        Me.txtIDTCE.Size = New System.Drawing.Size(100, 20)
        Me.txtIDTCE.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTipoCambioDetDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn, Me.IdTipoCambioEncDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TipoCambioDetBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(55, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(444, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'KERMESSEDataSet
        '
        Me.KERMESSEDataSet.DataSetName = "KERMESSEDataSet"
        Me.KERMESSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoCambioDetBindingSource
        '
        Me.TipoCambioDetBindingSource.DataMember = "TipoCambioDet"
        Me.TipoCambioDetBindingSource.DataSource = Me.KERMESSEDataSet
        '
        'TipoCambioDetTableAdapter
        '
        Me.TipoCambioDetTableAdapter.ClearBeforeFill = True
        '
        'IdTipoCambioDetDataGridViewTextBoxColumn
        '
        Me.IdTipoCambioDetDataGridViewTextBoxColumn.DataPropertyName = "IdTipoCambioDet"
        Me.IdTipoCambioDetDataGridViewTextBoxColumn.HeaderText = "IdTipoCambioDet"
        Me.IdTipoCambioDetDataGridViewTextBoxColumn.Name = "IdTipoCambioDetDataGridViewTextBoxColumn"
        Me.IdTipoCambioDetDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdTipoCambioEncDataGridViewTextBoxColumn
        '
        Me.IdTipoCambioEncDataGridViewTextBoxColumn.DataPropertyName = "IdTipoCambioEnc"
        Me.IdTipoCambioEncDataGridViewTextBoxColumn.HeaderText = "IdTipoCambioEnc"
        Me.IdTipoCambioEncDataGridViewTextBoxColumn.Name = "IdTipoCambioEncDataGridViewTextBoxColumn"
        Me.IdTipoCambioEncDataGridViewTextBoxColumn.ReadOnly = True
        '
        'txtBYSTCD
        '
        Me.txtBYSTCD.BackColor = System.Drawing.SystemColors.Menu
        Me.txtBYSTCD.Location = New System.Drawing.Point(55, 30)
        Me.txtBYSTCD.Name = "txtBYSTCD"
        Me.txtBYSTCD.Size = New System.Drawing.Size(413, 20)
        Me.txtBYSTCD.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Buscar"
        '
        'Tipo_Cambio_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(694, 477)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Tipo_Cambio_Detalle"
        Me.Text = "Tipo Cambio Detalle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KERMESSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoCambioDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIDTCE As TextBox
    Friend WithEvents txtVTCD As TextBox
    Friend WithEvents txtFTCD As TextBox
    Friend WithEvents txtIDTCD As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminarTCD As Button
    Friend WithEvents BtnEditarTCD As Button
    Friend WithEvents BtnGuardarTCD As Button
    Friend WithEvents BtnNuevoTCD As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KERMESSEDataSet As KERMESSEDataSet
    Friend WithEvents TipoCambioDetBindingSource As BindingSource
    Friend WithEvents TipoCambioDetTableAdapter As KERMESSEDataSetTableAdapters.TipoCambioDetTableAdapter
    Friend WithEvents IdTipoCambioDetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdTipoCambioEncDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtBYSTCD As TextBox
    Friend WithEvents Label5 As Label
End Class
