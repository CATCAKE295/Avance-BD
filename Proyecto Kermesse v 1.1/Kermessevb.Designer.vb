<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kermessevb
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
        Me.BtnEliminarK = New System.Windows.Forms.Button()
        Me.BtnEditarK = New System.Windows.Forms.Button()
        Me.BtnGuardarK = New System.Windows.Forms.Button()
        Me.BtnNuevoK = New System.Windows.Forms.Button()
        Me.txtDesK = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txtNK = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtIDP = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtIDK = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDKermesseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDParroquiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KermesseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KERMESSEDataSet = New Proyecto_Kermesse_v_1._1.KERMESSEDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BYSK = New System.Windows.Forms.TextBox()
        Me.KermesseTableAdapter = New Proyecto_Kermesse_v_1._1.KERMESSEDataSetTableAdapters.KermesseTableAdapter()
        Me.txtSegK = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KermesseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KERMESSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSegK)
        Me.GroupBox1.Controls.Add(Me.BtnEliminarK)
        Me.GroupBox1.Controls.Add(Me.BtnEditarK)
        Me.GroupBox1.Controls.Add(Me.BtnGuardarK)
        Me.GroupBox1.Controls.Add(Me.BtnNuevoK)
        Me.GroupBox1.Controls.Add(Me.txtDesK)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.txtNK)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.txtIDP)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.txtIDK)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 308)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Kermesse"
        '
        'BtnEliminarK
        '
        Me.BtnEliminarK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarK.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEliminarK.Location = New System.Drawing.Point(518, 188)
        Me.BtnEliminarK.Name = "BtnEliminarK"
        Me.BtnEliminarK.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarK.TabIndex = 19
        Me.BtnEliminarK.Text = "Eliminar"
        Me.BtnEliminarK.UseVisualStyleBackColor = True
        '
        'BtnEditarK
        '
        Me.BtnEditarK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarK.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEditarK.Location = New System.Drawing.Point(518, 134)
        Me.BtnEditarK.Name = "BtnEditarK"
        Me.BtnEditarK.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditarK.TabIndex = 18
        Me.BtnEditarK.Text = "Editar"
        Me.BtnEditarK.UseVisualStyleBackColor = True
        '
        'BtnGuardarK
        '
        Me.BtnGuardarK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarK.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnGuardarK.Location = New System.Drawing.Point(518, 84)
        Me.BtnGuardarK.Name = "BtnGuardarK"
        Me.BtnGuardarK.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardarK.TabIndex = 17
        Me.BtnGuardarK.Text = "Guardar"
        Me.BtnGuardarK.UseVisualStyleBackColor = True
        '
        'BtnNuevoK
        '
        Me.BtnNuevoK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoK.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnNuevoK.Location = New System.Drawing.Point(518, 34)
        Me.BtnNuevoK.Name = "BtnNuevoK"
        Me.BtnNuevoK.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevoK.TabIndex = 16
        Me.BtnNuevoK.Text = "Nuevo "
        Me.BtnNuevoK.UseVisualStyleBackColor = True
        '
        'txtDesK
        '
        Me.txtDesK.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDesK.Location = New System.Drawing.Point(75, 227)
        Me.txtDesK.Name = "txtDesK"
        Me.txtDesK.Size = New System.Drawing.Size(421, 20)
        Me.txtDesK.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Descripcion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Hora Fin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(221, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Hora Inicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(213, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ID-Parroquia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Plan Fin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Plan inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID-Kermesse"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox7.Location = New System.Drawing.Point(285, 137)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 6
        '
        'txtNK
        '
        Me.txtNK.BackColor = System.Drawing.SystemColors.Menu
        Me.txtNK.Location = New System.Drawing.Point(56, 93)
        Me.txtNK.Name = "txtNK"
        Me.txtNK.Size = New System.Drawing.Size(100, 20)
        Me.txtNK.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox5.Location = New System.Drawing.Point(67, 141)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox4.Location = New System.Drawing.Point(67, 181)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 3
        '
        'txtIDP
        '
        Me.txtIDP.BackColor = System.Drawing.SystemColors.Menu
        Me.txtIDP.Location = New System.Drawing.Point(285, 47)
        Me.txtIDP.Name = "txtIDP"
        Me.txtIDP.ReadOnly = True
        Me.txtIDP.Size = New System.Drawing.Size(38, 20)
        Me.txtIDP.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox2.Location = New System.Drawing.Point(285, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'txtIDK
        '
        Me.txtIDK.BackColor = System.Drawing.SystemColors.Menu
        Me.txtIDK.Location = New System.Drawing.Point(79, 47)
        Me.txtIDK.Name = "txtIDK"
        Me.txtIDK.ReadOnly = True
        Me.txtIDK.Size = New System.Drawing.Size(34, 20)
        Me.txtIDK.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.BYSK)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 326)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 309)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda y Seleccion"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDKermesseDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PlanInicioDataGridViewTextBoxColumn, Me.PlanFinDataGridViewTextBoxColumn, Me.HoraInicioDataGridViewTextBoxColumn, Me.HoraFinDataGridViewTextBoxColumn, Me.IDParroquiaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KermesseBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(601, 216)
        Me.DataGridView1.TabIndex = 13
        '
        'IDKermesseDataGridViewTextBoxColumn
        '
        Me.IDKermesseDataGridViewTextBoxColumn.DataPropertyName = "IDKermesse"
        Me.IDKermesseDataGridViewTextBoxColumn.HeaderText = "IDKermesse"
        Me.IDKermesseDataGridViewTextBoxColumn.Name = "IDKermesseDataGridViewTextBoxColumn"
        Me.IDKermesseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlanInicioDataGridViewTextBoxColumn
        '
        Me.PlanInicioDataGridViewTextBoxColumn.DataPropertyName = "PlanInicio"
        Me.PlanInicioDataGridViewTextBoxColumn.HeaderText = "PlanInicio"
        Me.PlanInicioDataGridViewTextBoxColumn.Name = "PlanInicioDataGridViewTextBoxColumn"
        Me.PlanInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlanFinDataGridViewTextBoxColumn
        '
        Me.PlanFinDataGridViewTextBoxColumn.DataPropertyName = "PlanFin"
        Me.PlanFinDataGridViewTextBoxColumn.HeaderText = "PlanFin"
        Me.PlanFinDataGridViewTextBoxColumn.Name = "PlanFinDataGridViewTextBoxColumn"
        Me.PlanFinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoraInicioDataGridViewTextBoxColumn
        '
        Me.HoraInicioDataGridViewTextBoxColumn.DataPropertyName = "HoraInicio"
        Me.HoraInicioDataGridViewTextBoxColumn.HeaderText = "HoraInicio"
        Me.HoraInicioDataGridViewTextBoxColumn.Name = "HoraInicioDataGridViewTextBoxColumn"
        Me.HoraInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoraFinDataGridViewTextBoxColumn
        '
        Me.HoraFinDataGridViewTextBoxColumn.DataPropertyName = "HoraFin"
        Me.HoraFinDataGridViewTextBoxColumn.HeaderText = "HoraFin"
        Me.HoraFinDataGridViewTextBoxColumn.Name = "HoraFinDataGridViewTextBoxColumn"
        Me.HoraFinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDParroquiaDataGridViewTextBoxColumn
        '
        Me.IDParroquiaDataGridViewTextBoxColumn.DataPropertyName = "IDParroquia"
        Me.IDParroquiaDataGridViewTextBoxColumn.HeaderText = "IDParroquia"
        Me.IDParroquiaDataGridViewTextBoxColumn.Name = "IDParroquiaDataGridViewTextBoxColumn"
        Me.IDParroquiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KermesseBindingSource
        '
        Me.KermesseBindingSource.DataMember = "Kermesse"
        Me.KermesseBindingSource.DataSource = Me.KERMESSEDataSet
        '
        'KERMESSEDataSet
        '
        Me.KERMESSEDataSet.DataSetName = "KERMESSEDataSet"
        Me.KERMESSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Buscar"
        '
        'BYSK
        '
        Me.BYSK.BackColor = System.Drawing.SystemColors.Menu
        Me.BYSK.Location = New System.Drawing.Point(51, 31)
        Me.BYSK.Name = "BYSK"
        Me.BYSK.Size = New System.Drawing.Size(559, 20)
        Me.BYSK.TabIndex = 11
        '
        'KermesseTableAdapter
        '
        Me.KermesseTableAdapter.ClearBeforeFill = True
        '
        'txtSegK
        '
        Me.txtSegK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtSegK.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtSegK.Location = New System.Drawing.Point(518, 251)
        Me.txtSegK.Name = "txtSegK"
        Me.txtSegK.Size = New System.Drawing.Size(75, 23)
        Me.txtSegK.TabIndex = 20
        Me.txtSegK.Text = "Siguiente"
        Me.txtSegK.UseVisualStyleBackColor = True
        '
        'Kermessevb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 647)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Kermessevb"
        Me.Text = "Kermessevb"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KermesseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KERMESSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIDP As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtIDK As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txtNK As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDesK As TextBox
    Friend WithEvents BtnEliminarK As Button
    Friend WithEvents BtnEditarK As Button
    Friend WithEvents BtnGuardarK As Button
    Friend WithEvents BtnNuevoK As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents BYSK As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KERMESSEDataSet As KERMESSEDataSet
    Friend WithEvents KermesseBindingSource As BindingSource
    Friend WithEvents KermesseTableAdapter As KERMESSEDataSetTableAdapters.KermesseTableAdapter
    Friend WithEvents IDKermesseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlanInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlanFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDParroquiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtSegK As Button
End Class
