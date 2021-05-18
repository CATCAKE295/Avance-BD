<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnNuevoP = New System.Windows.Forms.Button()
        Me.BtnGuardarP = New System.Windows.Forms.Button()
        Me.BtnEditarP = New System.Windows.Forms.Button()
        Me.BtnEliminarP = New System.Windows.Forms.Button()
        Me.txtIDP = New System.Windows.Forms.TextBox()
        Me.txtNP = New System.Windows.Forms.TextBox()
        Me.txtDesP = New System.Windows.Forms.TextBox()
        Me.txtDP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Label()
        Me.txtBYSP = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KERMESSEDataSet = New Proyecto_Kermesse_v_1._1.KERMESSEDataSet()
        Me.ParroquiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParroquiaTableAdapter = New Proyecto_Kermesse_v_1._1.KERMESSEDataSetTableAdapters.ParroquiaTableAdapter()
        Me.IDParroquiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KERMESSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParroquiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDP)
        Me.GroupBox1.Controls.Add(Me.txtDesP)
        Me.GroupBox1.Controls.Add(Me.txtNP)
        Me.GroupBox1.Controls.Add(Me.txtIDP)
        Me.GroupBox1.Controls.Add(Me.BtnEliminarP)
        Me.GroupBox1.Controls.Add(Me.BtnEditarP)
        Me.GroupBox1.Controls.Add(Me.BtnGuardarP)
        Me.GroupBox1.Controls.Add(Me.BtnNuevoP)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 243)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Parroquia"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.txtBYSP)
        Me.GroupBox2.Controls.Add(Me.Buscar)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(542, 237)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda y Seleccion"
        '
        'BtnNuevoP
        '
        Me.BtnNuevoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoP.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnNuevoP.Location = New System.Drawing.Point(396, 27)
        Me.BtnNuevoP.Name = "BtnNuevoP"
        Me.BtnNuevoP.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevoP.TabIndex = 0
        Me.BtnNuevoP.Text = "Nuevo "
        Me.BtnNuevoP.UseVisualStyleBackColor = True
        '
        'BtnGuardarP
        '
        Me.BtnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarP.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnGuardarP.Location = New System.Drawing.Point(396, 77)
        Me.BtnGuardarP.Name = "BtnGuardarP"
        Me.BtnGuardarP.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardarP.TabIndex = 1
        Me.BtnGuardarP.Text = "Guardar"
        Me.BtnGuardarP.UseVisualStyleBackColor = True
        '
        'BtnEditarP
        '
        Me.BtnEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarP.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEditarP.Location = New System.Drawing.Point(396, 127)
        Me.BtnEditarP.Name = "BtnEditarP"
        Me.BtnEditarP.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditarP.TabIndex = 2
        Me.BtnEditarP.Text = "Editar"
        Me.BtnEditarP.UseVisualStyleBackColor = True
        '
        'BtnEliminarP
        '
        Me.BtnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarP.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEliminarP.Location = New System.Drawing.Point(396, 181)
        Me.BtnEliminarP.Name = "BtnEliminarP"
        Me.BtnEliminarP.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarP.TabIndex = 3
        Me.BtnEliminarP.Text = "Eliminar"
        Me.BtnEliminarP.UseVisualStyleBackColor = True
        '
        'txtIDP
        '
        Me.txtIDP.BackColor = System.Drawing.SystemColors.Menu
        Me.txtIDP.Location = New System.Drawing.Point(78, 33)
        Me.txtIDP.Name = "txtIDP"
        Me.txtIDP.ReadOnly = True
        Me.txtIDP.Size = New System.Drawing.Size(36, 20)
        Me.txtIDP.TabIndex = 4
        '
        'txtNP
        '
        Me.txtNP.BackColor = System.Drawing.SystemColors.Menu
        Me.txtNP.Location = New System.Drawing.Point(220, 33)
        Me.txtNP.Name = "txtNP"
        Me.txtNP.Size = New System.Drawing.Size(100, 20)
        Me.txtNP.TabIndex = 5
        '
        'txtDesP
        '
        Me.txtDesP.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDesP.Location = New System.Drawing.Point(75, 138)
        Me.txtDesP.Name = "txtDesP"
        Me.txtDesP.Size = New System.Drawing.Size(245, 20)
        Me.txtDesP.TabIndex = 6
        '
        'txtDP
        '
        Me.txtDP.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDP.Location = New System.Drawing.Point(75, 83)
        Me.txtDP.Name = "txtDP"
        Me.txtDP.Size = New System.Drawing.Size(100, 20)
        Me.txtDP.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID-Parroquia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Descripcion"
        '
        'Buscar
        '
        Me.Buscar.AutoSize = True
        Me.Buscar.Location = New System.Drawing.Point(6, 32)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(40, 13)
        Me.Buscar.TabIndex = 10
        Me.Buscar.Text = "Buscar"
        '
        'txtBYSP
        '
        Me.txtBYSP.BackColor = System.Drawing.SystemColors.Menu
        Me.txtBYSP.Location = New System.Drawing.Point(56, 29)
        Me.txtBYSP.Name = "txtBYSP"
        Me.txtBYSP.Size = New System.Drawing.Size(444, 20)
        Me.txtBYSP.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDParroquiaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ParroquiaBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.Location = New System.Drawing.Point(56, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Size = New System.Drawing.Size(444, 157)
        Me.DataGridView1.TabIndex = 12
        '
        'KERMESSEDataSet
        '
        Me.KERMESSEDataSet.DataSetName = "KERMESSEDataSet"
        Me.KERMESSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParroquiaBindingSource
        '
        Me.ParroquiaBindingSource.DataMember = "Parroquia"
        Me.ParroquiaBindingSource.DataSource = Me.KERMESSEDataSet
        '
        'ParroquiaTableAdapter
        '
        Me.ParroquiaTableAdapter.ClearBeforeFill = True
        '
        'IDParroquiaDataGridViewTextBoxColumn
        '
        Me.IDParroquiaDataGridViewTextBoxColumn.DataPropertyName = "IDParroquia"
        Me.IDParroquiaDataGridViewTextBoxColumn.HeaderText = "IDParroquia"
        Me.IDParroquiaDataGridViewTextBoxColumn.Name = "IDParroquiaDataGridViewTextBoxColumn"
        Me.IDParroquiaDataGridViewTextBoxColumn.ReadOnly = True
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
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(566, 510)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Parroquia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KERMESSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParroquiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEliminarP As Button
    Friend WithEvents BtnEditarP As Button
    Friend WithEvents BtnGuardarP As Button
    Friend WithEvents BtnNuevoP As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDP As TextBox
    Friend WithEvents txtDesP As TextBox
    Friend WithEvents txtNP As TextBox
    Friend WithEvents txtIDP As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtBYSP As TextBox
    Friend WithEvents Buscar As Label
    Friend WithEvents KERMESSEDataSet As KERMESSEDataSet
    Friend WithEvents ParroquiaBindingSource As BindingSource
    Friend WithEvents ParroquiaTableAdapter As KERMESSEDataSetTableAdapters.ParroquiaTableAdapter
    Friend WithEvents IDParroquiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
