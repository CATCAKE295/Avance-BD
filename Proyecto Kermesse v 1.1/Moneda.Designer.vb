<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Moneda
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
        Me.txtSM = New System.Windows.Forms.TextBox()
        Me.txtCM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNM = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminarM = New System.Windows.Forms.Button()
        Me.BtnEditarM = New System.Windows.Forms.Button()
        Me.BtnGuardarM = New System.Windows.Forms.Button()
        Me.BtnNuevoM = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdMonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SimboloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KERMESSEDataSet = New Proyecto_Kermesse_v_1._1.KERMESSEDataSet()
        Me.txtBYSM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonedaTableAdapter = New Proyecto_Kermesse_v_1._1.KERMESSEDataSetTableAdapters.MonedaTableAdapter()
        Me.txtSegM = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KERMESSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSegM)
        Me.GroupBox1.Controls.Add(Me.txtSM)
        Me.GroupBox1.Controls.Add(Me.txtCM)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNM)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnEliminarM)
        Me.GroupBox1.Controls.Add(Me.BtnEditarM)
        Me.GroupBox1.Controls.Add(Me.BtnGuardarM)
        Me.GroupBox1.Controls.Add(Me.BtnNuevoM)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Menu
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 320)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Moneda"
        '
        'txtSM
        '
        Me.txtSM.Location = New System.Drawing.Point(72, 196)
        Me.txtSM.Name = "txtSM"
        Me.txtSM.Size = New System.Drawing.Size(100, 20)
        Me.txtSM.TabIndex = 15
        '
        'txtCM
        '
        Me.txtCM.Location = New System.Drawing.Point(72, 141)
        Me.txtCM.Name = "txtCM"
        Me.txtCM.Size = New System.Drawing.Size(100, 20)
        Me.txtCM.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Simbolo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nombre"
        '
        'txtNM
        '
        Me.txtNM.Location = New System.Drawing.Point(72, 92)
        Me.txtNM.Name = "txtNM"
        Me.txtNM.Size = New System.Drawing.Size(100, 20)
        Me.txtNM.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(72, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(32, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ID-Moneda"
        '
        'BtnEliminarM
        '
        Me.BtnEliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarM.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEliminarM.Location = New System.Drawing.Point(359, 198)
        Me.BtnEliminarM.Name = "BtnEliminarM"
        Me.BtnEliminarM.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarM.TabIndex = 7
        Me.BtnEliminarM.Text = "Eliminar"
        Me.BtnEliminarM.UseVisualStyleBackColor = True
        '
        'BtnEditarM
        '
        Me.BtnEditarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarM.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEditarM.Location = New System.Drawing.Point(359, 144)
        Me.BtnEditarM.Name = "BtnEditarM"
        Me.BtnEditarM.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditarM.TabIndex = 6
        Me.BtnEditarM.Text = "Editar"
        Me.BtnEditarM.UseVisualStyleBackColor = True
        '
        'BtnGuardarM
        '
        Me.BtnGuardarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarM.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnGuardarM.Location = New System.Drawing.Point(359, 94)
        Me.BtnGuardarM.Name = "BtnGuardarM"
        Me.BtnGuardarM.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardarM.TabIndex = 5
        Me.BtnGuardarM.Text = "Guardar"
        Me.BtnGuardarM.UseVisualStyleBackColor = True
        '
        'BtnNuevoM
        '
        Me.BtnNuevoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoM.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnNuevoM.Location = New System.Drawing.Point(359, 44)
        Me.BtnNuevoM.Name = "BtnNuevoM"
        Me.BtnNuevoM.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevoM.TabIndex = 4
        Me.BtnNuevoM.Text = "Nuevo "
        Me.BtnNuevoM.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.txtBYSM)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Menu
        Me.GroupBox2.Location = New System.Drawing.Point(12, 338)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 248)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda Y Seleccion"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMonedaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.SimboloDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MonedaBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(51, 58)
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
        Me.DataGridView1.Size = New System.Drawing.Size(451, 176)
        Me.DataGridView1.TabIndex = 2
        '
        'IdMonedaDataGridViewTextBoxColumn
        '
        Me.IdMonedaDataGridViewTextBoxColumn.DataPropertyName = "IdMoneda"
        Me.IdMonedaDataGridViewTextBoxColumn.HeaderText = "IdMoneda"
        Me.IdMonedaDataGridViewTextBoxColumn.Name = "IdMonedaDataGridViewTextBoxColumn"
        Me.IdMonedaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SimboloDataGridViewTextBoxColumn
        '
        Me.SimboloDataGridViewTextBoxColumn.DataPropertyName = "Simbolo"
        Me.SimboloDataGridViewTextBoxColumn.HeaderText = "Simbolo"
        Me.SimboloDataGridViewTextBoxColumn.Name = "SimboloDataGridViewTextBoxColumn"
        Me.SimboloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MonedaBindingSource
        '
        Me.MonedaBindingSource.DataMember = "Moneda"
        Me.MonedaBindingSource.DataSource = Me.KERMESSEDataSet
        '
        'KERMESSEDataSet
        '
        Me.KERMESSEDataSet.DataSetName = "KERMESSEDataSet"
        Me.KERMESSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtBYSM
        '
        Me.txtBYSM.BackColor = System.Drawing.SystemColors.Menu
        Me.txtBYSM.Location = New System.Drawing.Point(51, 32)
        Me.txtBYSM.Name = "txtBYSM"
        Me.txtBYSM.Size = New System.Drawing.Size(413, 20)
        Me.txtBYSM.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'MonedaTableAdapter
        '
        Me.MonedaTableAdapter.ClearBeforeFill = True
        '
        'txtSegM
        '
        Me.txtSegM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtSegM.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtSegM.Location = New System.Drawing.Point(359, 259)
        Me.txtSegM.Name = "txtSegM"
        Me.txtSegM.Size = New System.Drawing.Size(75, 23)
        Me.txtSegM.TabIndex = 16
        Me.txtSegM.Text = "Siguiente"
        Me.txtSegM.UseVisualStyleBackColor = True
        '
        'Moneda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(547, 598)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Moneda"
        Me.Text = "Moneda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KERMESSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtBYSM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents KERMESSEDataSet As KERMESSEDataSet
    Friend WithEvents MonedaBindingSource As BindingSource
    Friend WithEvents MonedaTableAdapter As KERMESSEDataSetTableAdapters.MonedaTableAdapter
    Friend WithEvents IdMonedaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SimboloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNM As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEliminarM As Button
    Friend WithEvents BtnEditarM As Button
    Friend WithEvents BtnGuardarM As Button
    Friend WithEvents BtnNuevoM As Button
    Friend WithEvents txtSM As TextBox
    Friend WithEvents txtCM As TextBox
    Friend WithEvents txtSegM As Button
End Class
