Namespace Mantenimiento.Clasificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantFicha
        Inherits Legolas.APPUIComponents.Form

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantFicha))
            Me.dgvFicha = New Legolas.APPUIComponents.myDatagridView()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_amb_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_amb_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_fic_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fic_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBotonOtros = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlBotonGrabar = New System.Windows.Forms.Panel()
            Me.cmdAnular = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.cbbDistritoJud = New APPControls.uscComboParametrica()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rdbAlta = New System.Windows.Forms.RadioButton()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbBaja = New System.Windows.Forms.RadioButton()
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            CType(Me.dgvFicha, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBotonOtros.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlBotonGrabar.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.grbBusqueda.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvFicha
            '
            Me.dgvFicha.AllowUserToAddRows = False
            Me.dgvFicha.AllowUserToDeleteRows = False
            Me.dgvFicha.AllowUserToResizeRows = False
            Me.dgvFicha.BackgroundColor = System.Drawing.Color.White
            Me.dgvFicha.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFicha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_amb_id, Me.col_amb_nom, Me.col_num_doc, Me.col_tip_fic_nom, Me.col_num_sec, Me.col_fic_nom, Me.col_est_nom})
            Me.dgvFicha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFicha.Location = New System.Drawing.Point(0, 100)
            Me.dgvFicha.MultiSelect = False
            Me.dgvFicha.Name = "dgvFicha"
            Me.dgvFicha.ReadOnly = True
            Me.dgvFicha.RowHeadersVisible = False
            Me.dgvFicha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFicha.Size = New System.Drawing.Size(911, 289)
            Me.dgvFicha.TabIndex = 2
            Me.dgvFicha.VisibleCampos = False
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            '
            'col_amb_id
            '
            Me.col_amb_id.DataPropertyName = "AmbitoClasificacionId"
            Me.col_amb_id.HeaderText = ""
            Me.col_amb_id.Name = "col_amb_id"
            Me.col_amb_id.ReadOnly = True
            Me.col_amb_id.Width = 20
            '
            'col_amb_nom
            '
            Me.col_amb_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_amb_nom.DataPropertyName = "AmbitoClasificacionNombre"
            Me.col_amb_nom.HeaderText = "Ambito"
            Me.col_amb_nom.MinimumWidth = 200
            Me.col_amb_nom.Name = "col_amb_nom"
            Me.col_amb_nom.ReadOnly = True
            Me.col_amb_nom.Width = 200
            '
            'col_num_doc
            '
            Me.col_num_doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.col_num_doc.DataPropertyName = "DocAprobacion"
            Me.col_num_doc.HeaderText = "Núm. Doc. Aprob."
            Me.col_num_doc.Name = "col_num_doc"
            Me.col_num_doc.ReadOnly = True
            Me.col_num_doc.Width = 107
            '
            'col_tip_fic_nom
            '
            Me.col_tip_fic_nom.DataPropertyName = "TipoFichaNombre"
            Me.col_tip_fic_nom.HeaderText = "Tipo"
            Me.col_tip_fic_nom.Name = "col_tip_fic_nom"
            Me.col_tip_fic_nom.ReadOnly = True
            Me.col_tip_fic_nom.Width = 110
            '
            'col_num_sec
            '
            Me.col_num_sec.DataPropertyName = "Secuencia"
            Me.col_num_sec.HeaderText = "N° Sec."
            Me.col_num_sec.Name = "col_num_sec"
            Me.col_num_sec.ReadOnly = True
            Me.col_num_sec.Width = 50
            '
            'col_fic_nom
            '
            Me.col_fic_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.col_fic_nom.DataPropertyName = "Nombre"
            Me.col_fic_nom.HeaderText = "Ficha"
            Me.col_fic_nom.Name = "col_fic_nom"
            Me.col_fic_nom.ReadOnly = True
            Me.col_fic_nom.Width = 58
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "EstadoNombre"
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            Me.col_est_nom.Width = 60
            '
            'pnlBotonOtros
            '
            Me.pnlBotonOtros.Controls.Add(Me.btnSalir)
            Me.pnlBotonOtros.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonOtros.Location = New System.Drawing.Point(359, 0)
            Me.pnlBotonOtros.Name = "pnlBotonOtros"
            Me.pnlBotonOtros.Size = New System.Drawing.Size(92, 42)
            Me.pnlBotonOtros.TabIndex = 73
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(1, 1)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(90, 40)
            Me.btnSalir.TabIndex = 66
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(269, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(90, 42)
            Me.pnlEliminar.TabIndex = 74
            '
            'btnEliminar
            '
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEliminar.Location = New System.Drawing.Point(1, 1)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(90, 40)
            Me.btnEliminar.TabIndex = 0
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'pnlBotonGrabar
            '
            Me.pnlBotonGrabar.Controls.Add(Me.cmdAnular)
            Me.pnlBotonGrabar.Controls.Add(Me.btnNuevo)
            Me.pnlBotonGrabar.Controls.Add(Me.btnModificar)
            Me.pnlBotonGrabar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonGrabar.Location = New System.Drawing.Point(0, 0)
            Me.pnlBotonGrabar.Name = "pnlBotonGrabar"
            Me.pnlBotonGrabar.Size = New System.Drawing.Size(269, 42)
            Me.pnlBotonGrabar.TabIndex = 71
            '
            'cmdAnular
            '
            Me.cmdAnular.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.cmdAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.cmdAnular.Location = New System.Drawing.Point(179, 1)
            Me.cmdAnular.Name = "cmdAnular"
            Me.cmdAnular.Size = New System.Drawing.Size(90, 40)
            Me.cmdAnular.TabIndex = 75
            Me.cmdAnular.Text = "Inactivar"
            Me.cmdAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.cmdAnular.UseVisualStyleBackColor = True
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(2, 1)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(86, 40)
            Me.btnNuevo.TabIndex = 63
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
            Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnModificar.Location = New System.Drawing.Point(89, 1)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(90, 40)
            Me.btnModificar.TabIndex = 64
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.pnlBotonOtros)
            Me.Panel1.Controls.Add(Me.pnlEliminar)
            Me.Panel1.Controls.Add(Me.pnlBotonGrabar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 389)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(911, 42)
            Me.Panel1.TabIndex = 3
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(821, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(90, 100)
            Me.grbBuscar.TabIndex = 80
            Me.grbBuscar.TabStop = False
            '
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(84, 81)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(82, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 75)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(84, 22)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.grbBusqueda)
            Me.Panel2.Controls.Add(Me.grbBuscar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(911, 100)
            Me.Panel2.TabIndex = 64
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(8, 32)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(39, 13)
            Me.Label11.TabIndex = 76
            Me.Label11.Text = "Ambito"
            '
            'cbbDistritoJud
            '
            Me.cbbDistritoJud._NoIndica = False
            Me.cbbDistritoJud._Todos = False
            Me.cbbDistritoJud._TodosMensaje = ""
            Me.cbbDistritoJud._Visible_Add = False
            Me.cbbDistritoJud._Visible_Buscar = False
            Me.cbbDistritoJud._Visible_Eliminar = False
            Me.cbbDistritoJud.CodigoPadre = -1
            Me.cbbDistritoJud.ComboTipo = Type.Combo.ComboTipo.AutorizacionJudicial
            Me.cbbDistritoJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDistritoJud.DropDownWidth = 222
            Me.cbbDistritoJud.DropDownWidthAuto = False
            Me.cbbDistritoJud.Location = New System.Drawing.Point(53, 29)
            Me.cbbDistritoJud.Name = "cbbDistritoJud"
            Me.cbbDistritoJud.Parametro1 = -1
            Me.cbbDistritoJud.Parametro2 = -1
            Me.cbbDistritoJud.SelectedIndex = -1
            Me.cbbDistritoJud.SelectedValue = 0
            Me.cbbDistritoJud.Size = New System.Drawing.Size(266, 22)
            Me.cbbDistritoJud.TabIndex = 77
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbBaja)
            Me.GroupBox1.Controls.Add(Me.rdbTodos)
            Me.GroupBox1.Controls.Add(Me.rdbAlta)
            Me.GroupBox1.Location = New System.Drawing.Point(342, 15)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(193, 48)
            Me.GroupBox1.TabIndex = 81
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Estado"
            '
            'rdbAlta
            '
            Me.rdbAlta.AutoSize = True
            Me.rdbAlta.Checked = True
            Me.rdbAlta.Location = New System.Drawing.Point(6, 19)
            Me.rdbAlta.Name = "rdbAlta"
            Me.rdbAlta.Size = New System.Drawing.Size(48, 17)
            Me.rdbAlta.TabIndex = 0
            Me.rdbAlta.TabStop = True
            Me.rdbAlta.Text = "Altas"
            Me.rdbAlta.UseVisualStyleBackColor = True
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Location = New System.Drawing.Point(124, 19)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 1
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbBaja
            '
            Me.rdbBaja.AutoSize = True
            Me.rdbBaja.Location = New System.Drawing.Point(63, 19)
            Me.rdbBaja.Name = "rdbBaja"
            Me.rdbBaja.Size = New System.Drawing.Size(51, 17)
            Me.rdbBaja.TabIndex = 82
            Me.rdbBaja.Text = "Bajas"
            Me.rdbBaja.UseVisualStyleBackColor = True
            '
            'grbBusqueda
            '
            Me.grbBusqueda.Controls.Add(Me.GroupBox1)
            Me.grbBusqueda.Controls.Add(Me.cbbDistritoJud)
            Me.grbBusqueda.Controls.Add(Me.Label11)
            Me.grbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Size = New System.Drawing.Size(821, 100)
            Me.grbBusqueda.TabIndex = 38
            Me.grbBusqueda.TabStop = False
            '
            'frmMantFicha
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(911, 431)
            Me.Controls.Add(Me.dgvFicha)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "frmMantFicha"
            Me.Text = ".::. Mantenimiento de fichas de clasificación"
            CType(Me.dgvFicha, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBotonOtros.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlBotonGrabar.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.grbBusqueda.ResumeLayout(False)
            Me.grbBusqueda.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvFicha As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlBotonOtros As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents pnlBotonGrabar As System.Windows.Forms.Panel
        Friend WithEvents cmdAnular As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_amb_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_amb_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_fic_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_sec As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fic_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents grbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbBaja As System.Windows.Forms.RadioButton
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbAlta As System.Windows.Forms.RadioButton
        Friend WithEvents cbbDistritoJud As APPControls.uscComboParametrica
        Friend WithEvents Label11 As System.Windows.Forms.Label
    End Class
End Namespace