Namespace Mantenimiento.Registro.Sala
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmBuscar
        Inherits Legolas.APPUIComponents.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            Me.txtNomCorto = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rbTodos = New System.Windows.Forms.RadioButton()
            Me.rbInactivo = New System.Windows.Forms.RadioButton()
            Me.rbHistorico = New System.Windows.Forms.RadioButton()
            Me.rbVigente = New System.Windows.Forms.RadioButton()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlExportar = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlModificar = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dis_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_dis_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_sal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_cor = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            Me.cbbDistritoJud = New APPControls.uscComboParametrica()
            Me.grbBusqueda.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlExportar.SuspendLayout()
            Me.pnlModificar.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grbBusqueda
            '
            Me.grbBusqueda.Controls.Add(Me.txtNomCorto)
            Me.grbBusqueda.Controls.Add(Me.GroupBox2)
            Me.grbBusqueda.Controls.Add(Me.Label4)
            Me.grbBusqueda.Controls.Add(Me.Label3)
            Me.grbBusqueda.Controls.Add(Me.cbbDistritoJud)
            Me.grbBusqueda.Controls.Add(Me.Label11)
            Me.grbBusqueda.Controls.Add(Me.txtNom)
            Me.grbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Size = New System.Drawing.Size(1168, 120)
            Me.grbBusqueda.TabIndex = 38
            Me.grbBusqueda.TabStop = False
            '
            'txtNomCorto
            '
            Me.txtNomCorto._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNomCorto._BloquearPaste = False
            Me.txtNomCorto._SeleccionarTodo = False
            Me.txtNomCorto.Location = New System.Drawing.Point(434, 83)
            Me.txtNomCorto.Name = "txtNomCorto"
            Me.txtNomCorto.Size = New System.Drawing.Size(401, 20)
            Me.txtNomCorto.TabIndex = 101
            Me.txtNomCorto.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNomCorto.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rbTodos)
            Me.GroupBox2.Controls.Add(Me.rbInactivo)
            Me.GroupBox2.Controls.Add(Me.rbHistorico)
            Me.GroupBox2.Controls.Add(Me.rbVigente)
            Me.GroupBox2.Location = New System.Drawing.Point(434, 16)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(401, 40)
            Me.GroupBox2.TabIndex = 100
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Estado"
            '
            'rbTodos
            '
            Me.rbTodos.AutoSize = True
            Me.rbTodos.Location = New System.Drawing.Point(322, 16)
            Me.rbTodos.Name = "rbTodos"
            Me.rbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rbTodos.TabIndex = 84
            Me.rbTodos.Text = "Todos"
            Me.rbTodos.UseVisualStyleBackColor = True
            '
            'rbInactivo
            '
            Me.rbInactivo.AutoSize = True
            Me.rbInactivo.Location = New System.Drawing.Point(229, 16)
            Me.rbInactivo.Name = "rbInactivo"
            Me.rbInactivo.Size = New System.Drawing.Size(63, 17)
            Me.rbInactivo.TabIndex = 83
            Me.rbInactivo.Text = "Inactivo"
            Me.rbInactivo.UseVisualStyleBackColor = True
            '
            'rbHistorico
            '
            Me.rbHistorico.AutoSize = True
            Me.rbHistorico.Location = New System.Drawing.Point(133, 16)
            Me.rbHistorico.Name = "rbHistorico"
            Me.rbHistorico.Size = New System.Drawing.Size(66, 17)
            Me.rbHistorico.TabIndex = 82
            Me.rbHistorico.Text = "Historico"
            Me.rbHistorico.UseVisualStyleBackColor = True
            '
            'rbVigente
            '
            Me.rbVigente.AutoSize = True
            Me.rbVigente.Checked = True
            Me.rbVigente.Location = New System.Drawing.Point(48, 16)
            Me.rbVigente.Name = "rbVigente"
            Me.rbVigente.Size = New System.Drawing.Size(61, 17)
            Me.rbVigente.TabIndex = 0
            Me.rbVigente.TabStop = True
            Me.rbVigente.Text = "Vigente"
            Me.rbVigente.UseVisualStyleBackColor = True
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(431, 67)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(194, 13)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Denominación corta del Juzgado/Sala :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 67)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(167, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Denominación del Juzgado/Sala :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(8, 15)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(83, 13)
            Me.Label11.TabIndex = 76
            Me.Label11.Text = "Distrito Judicial :"
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(12, 83)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(401, 20)
            Me.txtNom.TabIndex = 80
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Controls.Add(Me.pnlEliminar)
            Me.Panel2.Controls.Add(Me.pnlExportar)
            Me.Panel2.Controls.Add(Me.pnlModificar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 321)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1258, 48)
            Me.Panel2.TabIndex = 62
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(363, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(86, 40)
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
            Me.pnlEliminar.Location = New System.Drawing.Point(273, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(89, 48)
            Me.pnlEliminar.TabIndex = 71
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(0, 3)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(86, 40)
            Me.btnEliminar.TabIndex = 68
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'pnlExportar
            '
            Me.pnlExportar.Controls.Add(Me.btnExportar)
            Me.pnlExportar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlExportar.Location = New System.Drawing.Point(184, 0)
            Me.pnlExportar.Name = "pnlExportar"
            Me.pnlExportar.Size = New System.Drawing.Size(89, 48)
            Me.pnlExportar.TabIndex = 70
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(1, 3)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(86, 40)
            Me.btnExportar.TabIndex = 65
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlModificar
            '
            Me.pnlModificar.Controls.Add(Me.btnNuevo)
            Me.pnlModificar.Controls.Add(Me.btnModificar)
            Me.pnlModificar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlModificar.Location = New System.Drawing.Point(0, 0)
            Me.pnlModificar.Name = "pnlModificar"
            Me.pnlModificar.Size = New System.Drawing.Size(184, 48)
            Me.pnlModificar.TabIndex = 69
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.Location = New System.Drawing.Point(3, 3)
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
            Me.btnModificar.Location = New System.Drawing.Point(89, 3)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(92, 40)
            Me.btnModificar.TabIndex = 64
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(1168, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(90, 120)
            Me.grbBuscar.TabIndex = 80
            Me.grbBuscar.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 95)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(84, 22)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            Me.ToolStrip1.Size = New System.Drawing.Size(84, 101)
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
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.grbBusqueda)
            Me.Panel1.Controls.Add(Me.grbBuscar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1258, 120)
            Me.Panel1.TabIndex = 63
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_dis_jud_id, Me.col_cod_dis_jud, Me.Column4, Me.col_cod_sal, Me.col_sal_nom, Me.col_nom_cor, Me.col_est, Me.col_est_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 120)
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1258, 201)
            Me.dgwGrilla.TabIndex = 64
            Me.dgwGrilla.VisibleCampos = True
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_dis_jud_id
            '
            Me.col_dis_jud_id.DataPropertyName = "DistritoJudID"
            Me.col_dis_jud_id.HeaderText = "DistritoJudicialID"
            Me.col_dis_jud_id.Name = "col_dis_jud_id"
            Me.col_dis_jud_id.ReadOnly = True
            Me.col_dis_jud_id.Visible = False
            '
            'col_cod_dis_jud
            '
            Me.col_cod_dis_jud.DataPropertyName = "DistritoJudCodigo"
            Me.col_cod_dis_jud.HeaderText = "Código Distrito Judicial"
            Me.col_cod_dis_jud.Name = "col_cod_dis_jud"
            Me.col_cod_dis_jud.ReadOnly = True
            Me.col_cod_dis_jud.Width = 150
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "DistritoJudicialNombre"
            Me.Column4.HeaderText = "Distrito Judicial"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 150
            '
            'col_cod_sal
            '
            Me.col_cod_sal.DataPropertyName = "SalaCodigo"
            Me.col_cod_sal.HeaderText = "Código del Juzgado/Sala"
            Me.col_cod_sal.Name = "col_cod_sal"
            Me.col_cod_sal.ReadOnly = True
            Me.col_cod_sal.Width = 150
            '
            'col_sal_nom
            '
            Me.col_sal_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_sal_nom.DataPropertyName = "Nombre"
            Me.col_sal_nom.HeaderText = "Denominación del Juzgado/Sala"
            Me.col_sal_nom.Name = "col_sal_nom"
            Me.col_sal_nom.ReadOnly = True
            '
            'col_nom_cor
            '
            Me.col_nom_cor.DataPropertyName = "NombreCorto"
            Me.col_nom_cor.HeaderText = "Denominación corta del Juzgado/Sala"
            Me.col_nom_cor.Name = "col_nom_cor"
            Me.col_nom_cor.ReadOnly = True
            Me.col_nom_cor.Width = 220
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "Estado"
            Me.col_est.HeaderText = "EstadoID"
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Visible = False
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "EstadoNombre"
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            Me.col_est_nom.Width = 80
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            '
            'cbbDistritoJud
            '
            Me.cbbDistritoJud._NoIndica = False
            Me.cbbDistritoJud._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbDistritoJud._Todos = False
            Me.cbbDistritoJud._TodosMensaje = ""
            Me.cbbDistritoJud._Visible_Add = False
            Me.cbbDistritoJud._Visible_Buscar = False
            Me.cbbDistritoJud._Visible_Eliminar = False
            Me.cbbDistritoJud.CodigoPadre = -1
            Me.cbbDistritoJud.ComboTipo = CType(15, Short)
            Me.cbbDistritoJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDistritoJud.DropDownWidth = 222
            Me.cbbDistritoJud.DropDownWidthAuto = False
            Me.cbbDistritoJud.ListaIdsParaExcluir = Nothing
            Me.cbbDistritoJud.Location = New System.Drawing.Point(12, 32)
            Me.cbbDistritoJud.ModuloTratamiento = False
            Me.cbbDistritoJud.Name = "cbbDistritoJud"
            Me.cbbDistritoJud.Parametro1 = -1
            Me.cbbDistritoJud.Parametro2 = -1
            Me.cbbDistritoJud.SelectedIndex = -1
            Me.cbbDistritoJud.SelectedValue = 0
            Me.cbbDistritoJud.Size = New System.Drawing.Size(401, 22)
            Me.cbbDistritoJud.TabIndex = 77
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1258, 369)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "frmBuscar"
            Me.Text = "Mantenimiento de Juzgados / Salas"
            Me.grbBusqueda.ResumeLayout(False)
            Me.grbBusqueda.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlExportar.ResumeLayout(False)
            Me.pnlModificar.ResumeLayout(False)
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents cbbDistritoJud As APPControls.uscComboParametrica
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents pnlExportar As System.Windows.Forms.Panel
        Friend WithEvents pnlModificar As System.Windows.Forms.Panel
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_dis_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_dis_jud As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_sal As DataGridViewTextBoxColumn
        Friend WithEvents col_sal_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_cor As DataGridViewTextBoxColumn
        Friend WithEvents col_est As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents rbTodos As RadioButton
        Friend WithEvents rbInactivo As RadioButton
        Friend WithEvents rbHistorico As RadioButton
        Friend WithEvents rbVigente As RadioButton
        Friend WithEvents txtNomCorto As Legolas.APPUIComponents.MyTextBox
    End Class
End Namespace

