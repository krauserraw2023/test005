Namespace Visita


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscAutorizacion
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.grbEstado = New System.Windows.Forms.GroupBox()
            Me.rdbTodosEstado = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbActivo = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbInactivo = New Legolas.APPUIComponents.myRadioButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbAutorizado = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbAnulado = New Legolas.APPUIComponents.myRadioButton()
            Me.pnlAdd = New System.Windows.Forms.Panel()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_tip_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_Usuario_Registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fecha_registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlCabecera.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.pnlAdd.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.grbEstado)
            Me.pnlCabecera.Controls.Add(Me.GroupBox1)
            Me.pnlCabecera.Controls.Add(Me.pnlAdd)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(900, 56)
            Me.pnlCabecera.TabIndex = 19
            '
            'grbEstado
            '
            Me.grbEstado.Controls.Add(Me.rdbTodosEstado)
            Me.grbEstado.Controls.Add(Me.rdbActivo)
            Me.grbEstado.Controls.Add(Me.rdbInactivo)
            Me.grbEstado.Dock = System.Windows.Forms.DockStyle.Left
            Me.grbEstado.Location = New System.Drawing.Point(243, 0)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(243, 56)
            Me.grbEstado.TabIndex = 15
            Me.grbEstado.TabStop = False
            Me.grbEstado.Text = "Estado"
            Me.grbEstado.Visible = False
            '
            'rdbTodosEstado
            '
            Me.rdbTodosEstado.AutoSize = True
            Me.rdbTodosEstado.Location = New System.Drawing.Point(173, 23)
            Me.rdbTodosEstado.Name = "rdbTodosEstado"
            Me.rdbTodosEstado.Size = New System.Drawing.Size(62, 19)
            Me.rdbTodosEstado.TabIndex = 2
            Me.rdbTodosEstado.Text = "Todos"
            Me.rdbTodosEstado.UseVisualStyleBackColor = True
            '
            'rdbActivo
            '
            Me.rdbActivo.AutoSize = True
            Me.rdbActivo.Checked = True
            Me.rdbActivo.Location = New System.Drawing.Point(22, 23)
            Me.rdbActivo.Name = "rdbActivo"
            Me.rdbActivo.Size = New System.Drawing.Size(59, 19)
            Me.rdbActivo.TabIndex = 0
            Me.rdbActivo.TabStop = True
            Me.rdbActivo.Text = "Activo"
            Me.rdbActivo.UseVisualStyleBackColor = True
            '
            'rdbInactivo
            '
            Me.rdbInactivo.AutoSize = True
            Me.rdbInactivo.Location = New System.Drawing.Point(103, 23)
            Me.rdbInactivo.Name = "rdbInactivo"
            Me.rdbInactivo.Size = New System.Drawing.Size(69, 19)
            Me.rdbInactivo.TabIndex = 1
            Me.rdbInactivo.Text = "Inactivo"
            Me.rdbInactivo.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbTodos)
            Me.GroupBox1.Controls.Add(Me.rdbAutorizado)
            Me.GroupBox1.Controls.Add(Me.rdbAnulado)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(243, 56)
            Me.GroupBox1.TabIndex = 14
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Tipo"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Location = New System.Drawing.Point(173, 23)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(62, 19)
            Me.rdbTodos.TabIndex = 2
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbAutorizado
            '
            Me.rdbAutorizado.AutoSize = True
            Me.rdbAutorizado.Checked = True
            Me.rdbAutorizado.Location = New System.Drawing.Point(22, 23)
            Me.rdbAutorizado.Name = "rdbAutorizado"
            Me.rdbAutorizado.Size = New System.Drawing.Size(86, 19)
            Me.rdbAutorizado.TabIndex = 0
            Me.rdbAutorizado.TabStop = True
            Me.rdbAutorizado.Text = "Autorizado"
            Me.rdbAutorizado.UseVisualStyleBackColor = True
            '
            'rdbAnulado
            '
            Me.rdbAnulado.AutoSize = True
            Me.rdbAnulado.Location = New System.Drawing.Point(103, 23)
            Me.rdbAnulado.Name = "rdbAnulado"
            Me.rdbAnulado.Size = New System.Drawing.Size(73, 19)
            Me.rdbAnulado.TabIndex = 1
            Me.rdbAnulado.Text = "Anulado"
            Me.rdbAnulado.UseVisualStyleBackColor = True
            '
            'pnlAdd
            '
            Me.pnlAdd.Controls.Add(Me.btnAgregar)
            Me.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAdd.Location = New System.Drawing.Point(790, 0)
            Me.pnlAdd.Name = "pnlAdd"
            Me.pnlAdd.Size = New System.Drawing.Size(110, 56)
            Me.pnlAdd.TabIndex = 12
            '
            'btnAgregar
            '
            Me.btnAgregar.Image = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregar.Location = New System.Drawing.Point(5, 9)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(97, 40)
            Me.btnAgregar.TabIndex = 11
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.Column8, Me.Column1, Me.col_fec, Me.Column3, Me.col_int_ape_nom, Me.col_vis_id, Me.col_vis_tip_num_doc, Me.col_vis_ape_nom, Me.Column5, Me.Column7, Me.Column6, Me.col_Usuario_Registro, Me.col_fecha_registro})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 56)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.RowHeadersWidth = 51
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(900, 264)
            Me.dgwGrilla.TabIndex = 18
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.MinimumWidth = 6
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 125
            '
            'Column8
            '
            Me.Column8.DataPropertyName = "TipoNombre"
            Me.Column8.HeaderText = "Tipo"
            Me.Column8.MinimumWidth = 6
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            Me.Column8.Width = 125
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "Documento"
            Me.Column1.HeaderText = "Documento"
            Me.Column1.MinimumWidth = 6
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 120
            '
            'col_fec
            '
            Me.col_fec.DataPropertyName = "Fecha"
            Me.col_fec.HeaderText = "Fecha"
            Me.col_fec.MinimumWidth = 6
            Me.col_fec.Name = "col_fec"
            Me.col_fec.ReadOnly = True
            Me.col_fec.Width = 75
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "InternoID"
            Me.Column3.HeaderText = "InternoID"
            Me.Column3.MinimumWidth = 6
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Visible = False
            Me.Column3.Width = 125
            '
            'col_int_ape_nom
            '
            Me.col_int_ape_nom.DataPropertyName = "InternoApeNom"
            Me.col_int_ape_nom.HeaderText = "Interno"
            Me.col_int_ape_nom.MinimumWidth = 6
            Me.col_int_ape_nom.Name = "col_int_ape_nom"
            Me.col_int_ape_nom.ReadOnly = True
            Me.col_int_ape_nom.Visible = False
            Me.col_int_ape_nom.Width = 200
            '
            'col_vis_id
            '
            Me.col_vis_id.DataPropertyName = "VisitanteID"
            Me.col_vis_id.HeaderText = "VisitanteID"
            Me.col_vis_id.MinimumWidth = 6
            Me.col_vis_id.Name = "col_vis_id"
            Me.col_vis_id.ReadOnly = True
            Me.col_vis_id.Visible = False
            Me.col_vis_id.Width = 125
            '
            'col_vis_tip_num_doc
            '
            Me.col_vis_tip_num_doc.DataPropertyName = "VisitanteTipoDoc_Numero"
            Me.col_vis_tip_num_doc.HeaderText = "Tipo Doc./Num. "
            Me.col_vis_tip_num_doc.MinimumWidth = 6
            Me.col_vis_tip_num_doc.Name = "col_vis_tip_num_doc"
            Me.col_vis_tip_num_doc.ReadOnly = True
            Me.col_vis_tip_num_doc.Width = 110
            '
            'col_vis_ape_nom
            '
            Me.col_vis_ape_nom.DataPropertyName = "VisitanteApeNom"
            Me.col_vis_ape_nom.HeaderText = "Visitante"
            Me.col_vis_ape_nom.MinimumWidth = 6
            Me.col_vis_ape_nom.Name = "col_vis_ape_nom"
            Me.col_vis_ape_nom.ReadOnly = True
            Me.col_vis_ape_nom.Width = 200
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "Parentesco"
            Me.Column5.HeaderText = "Parentesco"
            Me.Column5.MinimumWidth = 6
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 125
            '
            'Column7
            '
            Me.Column7.DataPropertyName = "Estado"
            Me.Column7.HeaderText = "Estado"
            Me.Column7.MinimumWidth = 6
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Column7.Visible = False
            Me.Column7.Width = 70
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "HasObservacion"
            Me.Column6.HeaderText = "Obs"
            Me.Column6.MinimumWidth = 6
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.ToolTipText = "Tiene observacion"
            Me.Column6.Width = 35
            '
            'col_Usuario_Registro
            '
            Me.col_Usuario_Registro.DataPropertyName = "Usuario_Registro"
            Me.col_Usuario_Registro.HeaderText = "Usuario Registro"
            Me.col_Usuario_Registro.MinimumWidth = 6
            Me.col_Usuario_Registro.Name = "col_Usuario_Registro"
            Me.col_Usuario_Registro.ReadOnly = True
            Me.col_Usuario_Registro.Width = 150
            '
            'col_fecha_registro
            '
            Me.col_fecha_registro.DataPropertyName = "Fecha_Registro"
            Me.col_fecha_registro.HeaderText = "Fecha Registro"
            Me.col_fecha_registro.MinimumWidth = 6
            Me.col_fecha_registro.Name = "col_fecha_registro"
            Me.col_fecha_registro.ReadOnly = True
            Me.col_fecha_registro.Width = 125
            '
            'uscAutorizacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Name = "uscAutorizacion"
            Me.Size = New System.Drawing.Size(900, 320)
            Me.pnlCabecera.ResumeLayout(False)
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.pnlAdd.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlAdd As System.Windows.Forms.Panel
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents rdbTodos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbAnulado As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbAutorizado As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents grbEstado As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTodosEstado As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbActivo As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbInactivo As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents Column8 As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents col_int_ape_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_vis_id As DataGridViewTextBoxColumn
        Friend WithEvents col_vis_tip_num_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_vis_ape_nom As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewTextBoxColumn
        Friend WithEvents Column7 As DataGridViewTextBoxColumn
        Friend WithEvents Column6 As DataGridViewCheckBoxColumn
        Friend WithEvents col_Usuario_Registro As DataGridViewTextBoxColumn
        Friend WithEvents col_fecha_registro As DataGridViewTextBoxColumn
    End Class

End Namespace