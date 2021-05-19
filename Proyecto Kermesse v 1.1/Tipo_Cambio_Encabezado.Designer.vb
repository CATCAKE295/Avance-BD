<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Cambio_Encabezado
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBYSTCE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIDMD = New System.Windows.Forms.TextBox()
        Me.txtIDMO = New System.Windows.Forms.TextBox()
        Me.txtMTCE = New System.Windows.Forms.TextBox()
        Me.IDTCE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminarTCE = New System.Windows.Forms.Button()
        Me.BtnEditarTCE = New System.Windows.Forms.Button()
        Me.BtnGuardarTCE = New System.Windows.Forms.Button()
        Me.BtnNuevoTCE = New System.Windows.Forms.Button()
        Me.KERMESSEDataSet = New Proyecto_Kermesse_v_1._1.KERMESSEDataSet()
        Me.TipoCambioEncBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoCambioEncTableAdapter = New Proyecto_Kermesse_v_1._1.KERMESSEDataSetTableAdapters.TipoCambioEncTableAdapter()
        Me.IdTipoCambioEncDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMonedaOrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMonedaDestinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSegTPE = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.KERMESSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoCambioEncBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBYSTCE)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Menu
        Me.GroupBox2.Location = New System.Drawing.Point(12, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 249)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda y Seleccion"
        '
        'txtBYSTCE
        '
        Me.txtBYSTCE.BackColor = System.Drawing.SystemColors.Menu
        Me.txtBYSTCE.Location = New System.Drawing.Point(55, 30)
        Me.txtBYSTCE.Name = "txtBYSTCE"
        Me.txtBYSTCE.Size = New System.Drawing.Size(413, 20)
        Me.txtBYSTCE.TabIndex = 3
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTipoCambioEncDataGridViewTextBoxColumn, Me.MesDataGridViewTextBoxColumn, Me.IdMonedaOrigenDataGridViewTextBoxColumn, Me.IdMonedaDestinoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TipoCambioEncBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(150, 93)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSegTPE)
        Me.GroupBox1.Controls.Add(Me.txtIDMD)
        Me.GroupBox1.Controls.Add(Me.txtIDMO)
        Me.GroupBox1.Controls.Add(Me.txtMTCE)
        Me.GroupBox1.Controls.Add(Me.IDTCE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnEliminarTCE)
        Me.GroupBox1.Controls.Add(Me.BtnEditarTCE)
        Me.GroupBox1.Controls.Add(Me.BtnGuardarTCE)
        Me.GroupBox1.Controls.Add(Me.BtnNuevoTCE)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Menu
        Me.GroupBox1.Location = New System.Drawing.Point(12, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 218)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Tipo Cambio Detalle"
        '
        'txtIDMD
        '
        Me.txtIDMD.BackColor = System.Drawing.SystemColors.Menu
        Me.txtIDMD.Location = New System.Drawing.Point(106, 149)
        Me.txtIDMD.Name = "txtIDMD"
        Me.txtIDMD.ReadOnly = True
        Me.txtIDMD.Size = New System.Drawing.Size(100, 20)
        Me.txtIDMD.TabIndex = 19
        '
        'txtIDMO
        '
        Me.txtIDMO.BackColor = System.Drawing.SystemColors.Menu
        Me.txtIDMO.Location = New System.Drawing.Point(106, 107)
        Me.txtIDMO.Name = "txtIDMO"
        Me.txtIDMO.ReadOnly = True
        Me.txtIDMO.Size = New System.Drawing.Size(100, 20)
        Me.txtIDMO.TabIndex = 18
        '
        'txtMTCE
        '
        Me.txtMTCE.BackColor = System.Drawing.SystemColors.Menu
        Me.txtMTCE.Location = New System.Drawing.Point(55, 65)
        Me.txtMTCE.Name = "txtMTCE"
        Me.txtMTCE.Size = New System.Drawing.Size(100, 20)
        Me.txtMTCE.TabIndex = 17
        '
        'IDTCE
        '
        Me.IDTCE.Location = New System.Drawing.Point(55, 32)
        Me.IDTCE.Name = "IDTCE"
        Me.IDTCE.ReadOnly = True
        Me.IDTCE.Size = New System.Drawing.Size(39, 20)
        Me.IDTCE.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ID-Moneda Destino"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ID-Moneda Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Mes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID-TCE"
        '
        'BtnEliminarTCE
        '
        Me.BtnEliminarTCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarTCE.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEliminarTCE.Location = New System.Drawing.Point(540, 176)
        Me.BtnEliminarTCE.Name = "BtnEliminarTCE"
        Me.BtnEliminarTCE.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarTCE.TabIndex = 11
        Me.BtnEliminarTCE.Text = "Eliminar"
        Me.BtnEliminarTCE.UseVisualStyleBackColor = True
        '
        'BtnEditarTCE
        '
        Me.BtnEditarTCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarTCE.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEditarTCE.Location = New System.Drawing.Point(540, 122)
        Me.BtnEditarTCE.Name = "BtnEditarTCE"
        Me.BtnEditarTCE.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditarTCE.TabIndex = 10
        Me.BtnEditarTCE.Text = "Editar"
        Me.BtnEditarTCE.UseVisualStyleBackColor = True
        '
        'BtnGuardarTCE
        '
        Me.BtnGuardarTCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarTCE.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnGuardarTCE.Location = New System.Drawing.Point(540, 72)
        Me.BtnGuardarTCE.Name = "BtnGuardarTCE"
        Me.BtnGuardarTCE.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardarTCE.TabIndex = 9
        Me.BtnGuardarTCE.Text = "Guardar"
        Me.BtnGuardarTCE.UseVisualStyleBackColor = True
        '
        'BtnNuevoTCE
        '
        Me.BtnNuevoTCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoTCE.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnNuevoTCE.Location = New System.Drawing.Point(540, 22)
        Me.BtnNuevoTCE.Name = "BtnNuevoTCE"
        Me.BtnNuevoTCE.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevoTCE.TabIndex = 8
        Me.BtnNuevoTCE.Text = "Nuevo "
        Me.BtnNuevoTCE.UseVisualStyleBackColor = True
        '
        'KERMESSEDataSet
        '
        Me.KERMESSEDataSet.DataSetName = "KERMESSEDataSet"
        Me.KERMESSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoCambioEncBindingSource
        '
        Me.TipoCambioEncBindingSource.DataMember = "TipoCambioEnc"
        Me.TipoCambioEncBindingSource.DataSource = Me.KERMESSEDataSet
        '
        'TipoCambioEncTableAdapter
        '
        Me.TipoCambioEncTableAdapter.ClearBeforeFill = True
        '
        'IdTipoCambioEncDataGridViewTextBoxColumn
        '
        Me.IdTipoCambioEncDataGridViewTextBoxColumn.DataPropertyName = "IdTipoCambioEnc"
        Me.IdTipoCambioEncDataGridViewTextBoxColumn.HeaderText = "IdTipoCambioEnc"
        Me.IdTipoCambioEncDataGridViewTextBoxColumn.Name = "IdTipoCambioEncDataGridViewTextBoxColumn"
        Me.IdTipoCambioEncDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MesDataGridViewTextBoxColumn
        '
        Me.MesDataGridViewTextBoxColumn.DataPropertyName = "Mes"
        Me.MesDataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.MesDataGridViewTextBoxColumn.Name = "MesDataGridViewTextBoxColumn"
        Me.MesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdMonedaOrigenDataGridViewTextBoxColumn
        '
        Me.IdMonedaOrigenDataGridViewTextBoxColumn.DataPropertyName = "IdMonedaOrigen"
        Me.IdMonedaOrigenDataGridViewTextBoxColumn.HeaderText = "IdMonedaOrigen"
        Me.IdMonedaOrigenDataGridViewTextBoxColumn.Name = "IdMonedaOrigenDataGridViewTextBoxColumn"
        Me.IdMonedaOrigenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdMonedaDestinoDataGridViewTextBoxColumn
        '
        Me.IdMonedaDestinoDataGridViewTextBoxColumn.DataPropertyName = "IdMonedaDestino"
        Me.IdMonedaDestinoDataGridViewTextBoxColumn.HeaderText = "IdMonedaDestino"
        Me.IdMonedaDestinoDataGridViewTextBoxColumn.Name = "IdMonedaDestinoDataGridViewTextBoxColumn"
        Me.IdMonedaDestinoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'txtSegTPE
        '
        Me.txtSegTPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtSegTPE.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtSegTPE.Location = New System.Drawing.Point(673, 19)
        Me.txtSegTPE.Name = "txtSegTPE"
        Me.txtSegTPE.Size = New System.Drawing.Size(75, 23)
        Me.txtSegTPE.TabIndex = 20
        Me.txtSegTPE.Text = "Siguiente"
        Me.txtSegTPE.UseVisualStyleBackColor = True
        '
        'Tipo_Cambio_Encabezado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 484)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Tipo_Cambio_Encabezado"
        Me.Text = "Tipo_Cambio_Encabezado"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.KERMESSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoCambioEncBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBYSTCE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIDMD As TextBox
    Friend WithEvents txtIDMO As TextBox
    Friend WithEvents txtMTCE As TextBox
    Friend WithEvents IDTCE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminarTCE As Button
    Friend WithEvents BtnEditarTCE As Button
    Friend WithEvents BtnGuardarTCE As Button
    Friend WithEvents BtnNuevoTCE As Button
    Friend WithEvents KERMESSEDataSet As KERMESSEDataSet
    Friend WithEvents TipoCambioEncBindingSource As BindingSource
    Friend WithEvents TipoCambioEncTableAdapter As KERMESSEDataSetTableAdapters.TipoCambioEncTableAdapter
    Friend WithEvents IdTipoCambioEncDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMonedaOrigenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMonedaDestinoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtSegTPE As Button
End Class
