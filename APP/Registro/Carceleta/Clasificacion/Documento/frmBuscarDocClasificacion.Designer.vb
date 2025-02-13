Namespace Registro.Carceleta.Clasificacion.Documento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscarDocClasificacion
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarDocClasificacion))
            Me.pnlInferior = New System.Windows.Forms.Panel()
            Me.pnlGenMov = New System.Windows.Forms.Panel()
            Me.btnGenMov = New System.Windows.Forms.Button()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.pnlBotonOtros = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlBotonReporte = New System.Windows.Forms.Panel()
            Me.btnOficioConsolidado = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlBotonGrabar = New System.Windows.Forms.Panel()
            Me.btnDerivar = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.lblCantReg = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.grbEstado = New System.Windows.Forms.GroupBox()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgwDocumentos = New System.Windows.Forms.DataGridView()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_anio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_corr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_emi = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_tram_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvDetalle = New System.Windows.Forms.DataGridView()
            Me.col_det_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_class = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_pen_dest = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_cod_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_nom_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_n_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_fec_cla = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_doc_clas_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_int_fic_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cboEstado = New APPControls.uscComboParametrica()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.pnlInferior.SuspendLayout()
            Me.pnlGenMov.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlBotonOtros.SuspendLayout()
            Me.pnlBotonReporte.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlBotonGrabar.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.dgwDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlInferior
            '
            Me.pnlInferior.Controls.Add(Me.Panel3)
            Me.pnlInferior.Controls.Add(Me.pnlBotonOtros)
            Me.pnlInferior.Controls.Add(Me.pnlBotonReporte)
            Me.pnlInferior.Controls.Add(Me.pnlEliminar)
            Me.pnlInferior.Controls.Add(Me.pnlGenMov)
            Me.pnlInferior.Controls.Add(Me.pnlBotonGrabar)
            Me.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlInferior.Location = New System.Drawing.Point(0, 553)
            Me.pnlInferior.Name = "pnlInferior"
            Me.pnlInferior.Size = New System.Drawing.Size(1020, 43)
            Me.pnlInferior.TabIndex = 71
            '
            'pnlGenMov
            '
            Me.pnlGenMov.Controls.Add(Me.btnGenMov)
            Me.pnlGenMov.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlGenMov.Location = New System.Drawing.Point(278, 0)
            Me.pnlGenMov.Name = "pnlGenMov"
            Me.pnlGenMov.Size = New System.Drawing.Size(128, 43)
            Me.pnlGenMov.TabIndex = 84
            '
            'btnGenMov
            '
            Me.btnGenMov.Image = Global.SIPPOPE.My.Resources.Resources.sincronizar
            Me.btnGenMov.Location = New System.Drawing.Point(1, 1)
            Me.btnGenMov.Name = "btnGenMov"
            Me.btnGenMov.Size = New System.Drawing.Size(122, 40)
            Me.btnGenMov.TabIndex = 0
            Me.btnGenMov.Text = "Enviar internos a penal"
            Me.btnGenMov.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGenMov.UseVisualStyleBackColor = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Label7)
            Me.Panel3.Controls.Add(Me.Label3)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel3.Location = New System.Drawing.Point(675, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(160, 43)
            Me.Panel3.TabIndex = 83
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label7.Location = New System.Drawing.Point(3, 11)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(58, 18)
            Me.Label7.TabIndex = 79
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(64, 14)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(87, 13)
            Me.Label3.TabIndex = 80
            Me.Label3.Text = "Registro anulado"
            '
            'pnlBotonOtros
            '
            Me.pnlBotonOtros.BackColor = System.Drawing.SystemColors.Control
            Me.pnlBotonOtros.Controls.Add(Me.btnSalir)
            Me.pnlBotonOtros.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonOtros.Location = New System.Drawing.Point(591, 0)
            Me.pnlBotonOtros.Name = "pnlBotonOtros"
            Me.pnlBotonOtros.Size = New System.Drawing.Size(84, 43)
            Me.pnlBotonOtros.TabIndex = 73
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(0, 1)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 66
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlBotonReporte
            '
            Me.pnlBotonReporte.Controls.Add(Me.btnOficioConsolidado)
            Me.pnlBotonReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonReporte.Location = New System.Drawing.Point(499, 0)
            Me.pnlBotonReporte.Name = "pnlBotonReporte"
            Me.pnlBotonReporte.Size = New System.Drawing.Size(92, 43)
            Me.pnlBotonReporte.TabIndex = 82
            '
            'btnOficioConsolidado
            '
            Me.btnOficioConsolidado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOficioConsolidado.Image = CType(resources.GetObject("btnOficioConsolidado.Image"), System.Drawing.Image)
            Me.btnOficioConsolidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOficioConsolidado.Location = New System.Drawing.Point(1, 1)
            Me.btnOficioConsolidado.Name = "btnOficioConsolidado"
            Me.btnOficioConsolidado.Size = New System.Drawing.Size(90, 40)
            Me.btnOficioConsolidado.TabIndex = 67
            Me.btnOficioConsolidado.Text = "&Reportes"
            Me.btnOficioConsolidado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnOficioConsolidado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnOficioConsolidado.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.BackColor = System.Drawing.SystemColors.Control
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(406, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(93, 43)
            Me.pnlEliminar.TabIndex = 81
            '
            'btnEliminar
            '
            Me.btnEliminar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(0, 1)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(93, 40)
            Me.btnEliminar.TabIndex = 0
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlBotonGrabar
            '
            Me.pnlBotonGrabar.Controls.Add(Me.btnDerivar)
            Me.pnlBotonGrabar.Controls.Add(Me.btnNuevo)
            Me.pnlBotonGrabar.Controls.Add(Me.btnModificar)
            Me.pnlBotonGrabar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonGrabar.Location = New System.Drawing.Point(0, 0)
            Me.pnlBotonGrabar.Name = "pnlBotonGrabar"
            Me.pnlBotonGrabar.Size = New System.Drawing.Size(278, 43)
            Me.pnlBotonGrabar.TabIndex = 70
            '
            'btnDerivar
            '
            Me.btnDerivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDerivar.Image = Global.SIPPOPE.My.Resources.Resources.index_up
            Me.btnDerivar.Location = New System.Drawing.Point(179, 1)
            Me.btnDerivar.Name = "btnDerivar"
            Me.btnDerivar.Size = New System.Drawing.Size(98, 40)
            Me.btnDerivar.TabIndex = 65
            Me.btnDerivar.Text = "Derivar"
            Me.btnDerivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnDerivar.UseVisualStyleBackColor = True
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(3, 1)
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
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.lblCantReg)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.grbEstado)
            Me.Panel1.Controls.Add(Me.GroupBox6)
            Me.Panel1.Controls.Add(Me.grbBuscar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1020, 111)
            Me.Panel1.TabIndex = 72
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.cboEstado)
            Me.GroupBox3.Location = New System.Drawing.Point(566, 3)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(366, 43)
            Me.GroupBox3.TabIndex = 45
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Estado de trámite"
            '
            'lblCantReg
            '
            Me.lblCantReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCantReg.Location = New System.Drawing.Point(764, 92)
            Me.lblCantReg.Name = "lblCantReg"
            Me.lblCantReg.Size = New System.Drawing.Size(77, 16)
            Me.lblCantReg.TabIndex = 44
            Me.lblCantReg.Text = "0 Reg."
            Me.lblCantReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(8, 95)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(77, 13)
            Me.Label2.TabIndex = 43
            Me.Label2.Text = "Lista de oficios"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtNumDoc)
            Me.GroupBox2.Location = New System.Drawing.Point(4, 48)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(557, 43)
            Me.GroupBox2.TabIndex = 42
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "N° Documento"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(7, 16)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(543, 20)
            Me.txtNumDoc.TabIndex = 1
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'grbEstado
            '
            Me.grbEstado.Controls.Add(Me.cbbPenal)
            Me.grbEstado.Controls.Add(Me.Label34)
            Me.grbEstado.Controls.Add(Me.Label4)
            Me.grbEstado.Controls.Add(Me.cbbRegion)
            Me.grbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbEstado.Location = New System.Drawing.Point(4, 3)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(557, 43)
            Me.grbEstado.TabIndex = 41
            Me.grbEstado.TabStop = False
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Location = New System.Drawing.Point(278, 21)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(37, 13)
            Me.Label34.TabIndex = 55
            Me.Label34.Text = "Penal:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 21)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(47, 13)
            Me.Label4.TabIndex = 56
            Me.Label4.Text = "Región :"
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.dtpFechaFin)
            Me.GroupBox6.Controls.Add(Me.Label6)
            Me.GroupBox6.Controls.Add(Me.dtpFechaIni)
            Me.GroupBox6.Controls.Add(Me.Label5)
            Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox6.Location = New System.Drawing.Point(566, 48)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(366, 43)
            Me.GroupBox6.TabIndex = 40
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Fecha de Emisión"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFin.Location = New System.Drawing.Point(272, 19)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 24
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(215, 23)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(41, 13)
            Me.Label6.TabIndex = 58
            Me.Label6.Text = "Hasta :"
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaIni.Location = New System.Drawing.Point(72, 19)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 23
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(15, 23)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 13)
            Me.Label5.TabIndex = 57
            Me.Label5.Text = "Desde :"
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(937, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(83, 111)
            Me.grbBuscar.TabIndex = 39
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
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 92)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(75, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'lblReg
            '
            Me.lblReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblReg.Location = New System.Drawing.Point(939, 3)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 16)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.lblReg)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 318)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1020, 21)
            Me.Panel2.TabIndex = 75
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 4)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(83, 13)
            Me.Label1.TabIndex = 35
            Me.Label1.Text = "Detalle de oficio"
            '
            'dgwDocumentos
            '
            Me.dgwDocumentos.AllowUserToAddRows = False
            Me.dgwDocumentos.AllowUserToDeleteRows = False
            Me.dgwDocumentos.AllowUserToResizeRows = False
            Me.dgwDocumentos.BackgroundColor = System.Drawing.Color.White
            Me.dgwDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pen_nom, Me.col_cod, Me.col_anio, Me.col_corr, Me.col_fec_emi, Me.col_num_doc, Me.col_est, Me.col_est_tram_id})
            Me.dgwDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDocumentos.Location = New System.Drawing.Point(0, 111)
            Me.dgwDocumentos.MultiSelect = False
            Me.dgwDocumentos.Name = "dgwDocumentos"
            Me.dgwDocumentos.ReadOnly = True
            Me.dgwDocumentos.RowHeadersVisible = False
            Me.dgwDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDocumentos.Size = New System.Drawing.Size(1020, 207)
            Me.dgwDocumentos.TabIndex = 76
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            Me.col_pen_nom.Width = 200
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "Codigo"
            Me.col_cod.HeaderText = "Codigo"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            Me.col_cod.Visible = False
            '
            'col_anio
            '
            Me.col_anio.DataPropertyName = "AnioDoc"
            Me.col_anio.HeaderText = "Año"
            Me.col_anio.Name = "col_anio"
            Me.col_anio.ReadOnly = True
            Me.col_anio.Width = 60
            '
            'col_corr
            '
            Me.col_corr.DataPropertyName = "CorrelativoDoc"
            Me.col_corr.HeaderText = "Correlativo"
            Me.col_corr.Name = "col_corr"
            Me.col_corr.ReadOnly = True
            Me.col_corr.Width = 80
            '
            'col_fec_emi
            '
            Me.col_fec_emi.DataPropertyName = "FechaEmisionString"
            Me.col_fec_emi.HeaderText = "F. Emisión"
            Me.col_fec_emi.Name = "col_fec_emi"
            Me.col_fec_emi.ReadOnly = True
            '
            'col_num_doc
            '
            Me.col_num_doc.DataPropertyName = "NumeroDoc"
            Me.col_num_doc.HeaderText = "Núm. Doc."
            Me.col_num_doc.Name = "col_num_doc"
            Me.col_num_doc.ReadOnly = True
            Me.col_num_doc.Width = 250
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "EstadoDocString"
            Me.col_est.HeaderText = "Estado Trámite"
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Width = 150
            '
            'col_est_tram_id
            '
            Me.col_est_tram_id.DataPropertyName = "EstadoDocId"
            Me.col_est_tram_id.HeaderText = "EstadoTramiteId"
            Me.col_est_tram_id.Name = "col_est_tram_id"
            Me.col_est_tram_id.ReadOnly = True
            Me.col_est_tram_id.Visible = False
            '
            'dgvDetalle
            '
            Me.dgvDetalle.AllowUserToAddRows = False
            Me.dgvDetalle.AllowUserToDeleteRows = False
            Me.dgvDetalle.AllowUserToResizeRows = False
            Me.dgvDetalle.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
            Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_det_int_id, Me.col_id_class, Me.col_det_codigo, Me.col_det_pen_dest, Me.col_det_cod_int, Me.col_det_nom_int, Me.col_det_n_ing, Me.col_det_fec_cla, Me.col_det_doc_clas_id, Me.col_det_int_fic_id})
            Me.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.dgvDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalle.Location = New System.Drawing.Point(0, 339)
            Me.dgvDetalle.MultiSelect = False
            Me.dgvDetalle.Name = "dgvDetalle"
            Me.dgvDetalle.ReadOnly = True
            Me.dgvDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvDetalle.RowHeadersVisible = False
            Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalle.ShowEditingIcon = False
            Me.dgvDetalle.Size = New System.Drawing.Size(1020, 214)
            Me.dgvDetalle.TabIndex = 77
            '
            'col_det_int_id
            '
            Me.col_det_int_id.DataPropertyName = "InternoId"
            Me.col_det_int_id.HeaderText = "InternoId"
            Me.col_det_int_id.Name = "col_det_int_id"
            Me.col_det_int_id.ReadOnly = True
            Me.col_det_int_id.Visible = False
            '
            'col_id_class
            '
            Me.col_id_class.DataPropertyName = "ID_CLASS"
            Me.col_id_class.HeaderText = "ID_CLASS"
            Me.col_id_class.Name = "col_id_class"
            Me.col_id_class.ReadOnly = True
            Me.col_id_class.Visible = False
            '
            'col_det_codigo
            '
            Me.col_det_codigo.DataPropertyName = "Codigo"
            Me.col_det_codigo.HeaderText = "Codigo"
            Me.col_det_codigo.Name = "col_det_codigo"
            Me.col_det_codigo.ReadOnly = True
            Me.col_det_codigo.Visible = False
            '
            'col_det_pen_dest
            '
            Me.col_det_pen_dest.DataPropertyName = "PenalDestinoNombre"
            Me.col_det_pen_dest.HeaderText = "Penal Destino"
            Me.col_det_pen_dest.Name = "col_det_pen_dest"
            Me.col_det_pen_dest.ReadOnly = True
            Me.col_det_pen_dest.Width = 200
            '
            'col_det_cod_int
            '
            Me.col_det_cod_int.DataPropertyName = "CodigoInterno"
            Me.col_det_cod_int.HeaderText = "Cod. Interno"
            Me.col_det_cod_int.Name = "col_det_cod_int"
            Me.col_det_cod_int.ReadOnly = True
            '
            'col_det_nom_int
            '
            Me.col_det_nom_int.DataPropertyName = "NombresInterno"
            Me.col_det_nom_int.HeaderText = "Apellidos y Nombres"
            Me.col_det_nom_int.Name = "col_det_nom_int"
            Me.col_det_nom_int.ReadOnly = True
            Me.col_det_nom_int.Width = 300
            '
            'col_det_n_ing
            '
            Me.col_det_n_ing.DataPropertyName = "NumIngreso"
            Me.col_det_n_ing.HeaderText = "N° Ingreso"
            Me.col_det_n_ing.Name = "col_det_n_ing"
            Me.col_det_n_ing.ReadOnly = True
            Me.col_det_n_ing.Width = 80
            '
            'col_det_fec_cla
            '
            Me.col_det_fec_cla.DataPropertyName = "FechaClasificacionString"
            Me.col_det_fec_cla.HeaderText = "Fecha Clasificación"
            Me.col_det_fec_cla.Name = "col_det_fec_cla"
            Me.col_det_fec_cla.ReadOnly = True
            Me.col_det_fec_cla.Width = 130
            '
            'col_det_doc_clas_id
            '
            Me.col_det_doc_clas_id.DataPropertyName = "DocClasificacionId"
            Me.col_det_doc_clas_id.HeaderText = "DocClasificacionId"
            Me.col_det_doc_clas_id.Name = "col_det_doc_clas_id"
            Me.col_det_doc_clas_id.ReadOnly = True
            Me.col_det_doc_clas_id.Visible = False
            '
            'col_det_int_fic_id
            '
            Me.col_det_int_fic_id.DataPropertyName = "InternoFichaId"
            Me.col_det_int_fic_id.HeaderText = "InternoFichaId"
            Me.col_det_int_fic_id.Name = "col_det_int_fic_id"
            Me.col_det_int_fic_id.ReadOnly = True
            Me.col_det_int_fic_id.Visible = False
            '
            'cboEstado
            '
            Me.cboEstado._NoIndica = False
            Me.cboEstado._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cboEstado._Todos = False
            Me.cboEstado._TodosMensaje = ""
            Me.cboEstado._Visible_Add = False
            Me.cboEstado._Visible_Buscar = False
            Me.cboEstado._Visible_Eliminar = False
            Me.cboEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboEstado.CodigoPadre = -1
            Me.cboEstado.ComboTipo = CType(74, Short)
            Me.cboEstado.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cboEstado.DropDownWidth = 143
            Me.cboEstado.DropDownWidthAuto = False
            Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboEstado.ListaIdsParaExcluir = Nothing
            Me.cboEstado.Location = New System.Drawing.Point(12, 16)
            Me.cboEstado.ModuloTratamiento = False
            Me.cboEstado.Name = "cboEstado"
            Me.cboEstado.Parametro1 = -1
            Me.cboEstado.Parametro2 = -1
            Me.cboEstado.SelectedIndex = -1
            Me.cboEstado.SelectedValue = 0
            Me.cboEstado.Size = New System.Drawing.Size(348, 22)
            Me.cboEstado.TabIndex = 7
            Me.cboEstado.verToolTipItemSeleccionado = False
            '
            'cbbPenal
            '
            Me.cbbPenal._NoIndica = False
            Me.cbbPenal._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenal._Todos = False
            Me.cbbPenal._TodosMensaje = ""
            Me.cbbPenal._Visible_Add = False
            Me.cbbPenal._Visible_Buscar = False
            Me.cbbPenal._Visible_Eliminar = False
            Me.cbbPenal.CodigoPadre = -1
            Me.cbbPenal.ComboTipo = CType(36, Short)
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 238
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(316, 17)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(234, 22)
            Me.cbbPenal.TabIndex = 54
            Me.cbbPenal.verToolTipItemSeleccionado = False
            '
            'cbbRegion
            '
            Me.cbbRegion._NoIndica = False
            Me.cbbRegion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegion._Todos = False
            Me.cbbRegion._TodosMensaje = ""
            Me.cbbRegion._Visible_Add = False
            Me.cbbRegion._Visible_Buscar = False
            Me.cbbRegion._Visible_Eliminar = False
            Me.cbbRegion.CodigoPadre = -1
            Me.cbbRegion.ComboTipo = CType(37, Short)
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 178
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.Enabled = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(60, 17)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(189, 22)
            Me.cbbRegion.TabIndex = 53
            Me.cbbRegion.verToolTipItemSeleccionado = False
            '
            'frmBuscarDocClasificacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1020, 596)
            Me.Controls.Add(Me.dgwDocumentos)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.dgvDetalle)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.pnlInferior)
            Me.Name = "frmBuscarDocClasificacion"
            Me.Text = ""
            Me.pnlInferior.ResumeLayout(False)
            Me.pnlGenMov.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.pnlBotonOtros.ResumeLayout(False)
            Me.pnlBotonReporte.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlBotonGrabar.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            CType(Me.dgwDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlInferior As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgwDocumentos As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblCantReg As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents grbEstado As System.Windows.Forms.GroupBox
        Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
        Friend WithEvents pnlBotonOtros As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents cboEstado As APPControls.uscComboParametrica
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents col_det_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_id_class As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_pen_dest As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_cod_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_nom_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_n_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_fec_cla As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_doc_clas_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_int_fic_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlBotonReporte As System.Windows.Forms.Panel
        Friend WithEvents btnOficioConsolidado As System.Windows.Forms.Button
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_anio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_corr As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_emi As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_tram_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlBotonGrabar As System.Windows.Forms.Panel
        Friend WithEvents btnDerivar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents pnlGenMov As Panel
        Friend WithEvents btnGenMov As Button
    End Class
End Namespace