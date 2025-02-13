Namespace Registro.Identificacion.RegionLM
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmIngresoPopup_v2
        Inherits Legolas.APPUIComponents.FormPopup

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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresoPopup_v2))
            Me.dgwIngreso = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column15 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_ing_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_tip_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_isp_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id_crea_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.grbDatos = New System.Windows.Forms.GroupBox()
            Me.pnlObs = New System.Windows.Forms.Panel()
            Me.txtobservacion = New System.Windows.Forms.TextBox()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.pnlISP = New System.Windows.Forms.Panel()
            Me.ckbHistorico = New System.Windows.Forms.CheckBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.dtpFecIngISP = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.plnNumIng = New System.Windows.Forms.Panel()
            Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblMovMotivo = New System.Windows.Forms.Label()
            Me.lblMovTipo = New System.Windows.Forms.Label()
            Me.txtMovimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtModalidad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbMovMotivo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.cbbMovTipo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.pnBotones = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            CType(Me.dgwIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grbDatos.SuspendLayout()
            Me.pnlObs.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.pnlISP.SuspendLayout()
            Me.plnNumIng.SuspendLayout()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.pnBotones.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbDatos)
            Me.gbxFormChildContainer.Controls.Add(Me.pnBotones)
            Me.gbxFormChildContainer.Controls.Add(Me.dgwIngreso)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(617, 392)
            '
            'dgwIngreso
            '
            Me.dgwIngreso.AllowUserToAddRows = False
            Me.dgwIngreso.AllowUserToDeleteRows = False
            Me.dgwIngreso.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwIngreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwIngreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.Column15, Me.col_ing_nro, Me.col_mov_tip_id, Me.Column2, Me.Column3, Me.col_fec_isp_date, Me.Column4, Me.Column1, Me.col_pen_id, Me.col_pen_id_crea_reg})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwIngreso.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwIngreso.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgwIngreso.GridColor = System.Drawing.Color.LightGray
            Me.dgwIngreso.Location = New System.Drawing.Point(0, 0)
            Me.dgwIngreso.MultiSelect = False
            Me.dgwIngreso.Name = "dgwIngreso"
            Me.dgwIngreso.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwIngreso.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwIngreso.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwIngreso.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwIngreso.Size = New System.Drawing.Size(617, 119)
            Me.dgwIngreso.TabIndex = 1
            '
            'col_id
            '
            Me.col_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "ID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            '
            'Column15
            '
            Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Column15.DataPropertyName = "LibertadIcon"
            Me.Column15.HeaderText = ""
            Me.Column15.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.Column15.Name = "Column15"
            Me.Column15.ReadOnly = True
            Me.Column15.Width = 23
            '
            'col_ing_nro
            '
            Me.col_ing_nro.DataPropertyName = "IngresoNro"
            Me.col_ing_nro.HeaderText = "Nro Ing."
            Me.col_ing_nro.Name = "col_ing_nro"
            Me.col_ing_nro.ReadOnly = True
            Me.col_ing_nro.Width = 35
            '
            'col_mov_tip_id
            '
            Me.col_mov_tip_id.DataPropertyName = "IDTipoMovimiento"
            Me.col_mov_tip_id.HeaderText = "IDTipoMovimiento"
            Me.col_mov_tip_id.Name = "col_mov_tip_id"
            Me.col_mov_tip_id.ReadOnly = True
            Me.col_mov_tip_id.Visible = False
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "TipoMovimientoNombre"
            Me.Column2.HeaderText = "Movimiento"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 110
            '
            'Column3
            '
            Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column3.DataPropertyName = "MotivoIngresoNombre"
            Me.Column3.HeaderText = "Motivo"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            '
            'col_fec_isp_date
            '
            Me.col_fec_isp_date.DataPropertyName = "FechaISPDate"
            Me.col_fec_isp_date.HeaderText = "F. Reg. Sist. Pen."
            Me.col_fec_isp_date.Name = "col_fec_isp_date"
            Me.col_fec_isp_date.ReadOnly = True
            Me.col_fec_isp_date.ToolTipText = "Fecha de Registro al sistema penitenciario"
            Me.col_fec_isp_date.Width = 75
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "FechaLibertadDate"
            Me.Column4.HeaderText = "F. Egreso"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 85
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "getROrigen"
            Me.Column1.HeaderText = "Registrado"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.HeaderText = "IDPenal"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_pen_id_crea_reg
            '
            Me.col_pen_id_crea_reg.DataPropertyName = "RegistroCreaPenalID"
            Me.col_pen_id_crea_reg.HeaderText = "PenIdCreaReg"
            Me.col_pen_id_crea_reg.Name = "col_pen_id_crea_reg"
            Me.col_pen_id_crea_reg.ReadOnly = True
            Me.col_pen_id_crea_reg.Visible = False
            '
            'grbDatos
            '
            Me.grbDatos.BackColor = System.Drawing.Color.Transparent
            Me.grbDatos.Controls.Add(Me.pnlObs)
            Me.grbDatos.Controls.Add(Me.pnlISP)
            Me.grbDatos.Controls.Add(Me.plnNumIng)
            Me.grbDatos.Controls.Add(Me.Panel1)
            Me.grbDatos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbDatos.Location = New System.Drawing.Point(0, 119)
            Me.grbDatos.Name = "grbDatos"
            Me.grbDatos.Size = New System.Drawing.Size(617, 186)
            Me.grbDatos.TabIndex = 2
            Me.grbDatos.TabStop = False
            '
            'pnlObs
            '
            Me.pnlObs.Controls.Add(Me.txtobservacion)
            Me.pnlObs.Controls.Add(Me.Panel6)
            Me.pnlObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlObs.Location = New System.Drawing.Point(3, 120)
            Me.pnlObs.Name = "pnlObs"
            Me.pnlObs.Size = New System.Drawing.Size(611, 63)
            Me.pnlObs.TabIndex = 15
            '
            'txtobservacion
            '
            Me.txtobservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtobservacion.Location = New System.Drawing.Point(164, 0)
            Me.txtobservacion.MaxLength = 500
            Me.txtobservacion.Multiline = True
            Me.txtobservacion.Name = "txtobservacion"
            Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtobservacion.Size = New System.Drawing.Size(447, 63)
            Me.txtobservacion.TabIndex = 11
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.Label3)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel6.Location = New System.Drawing.Point(0, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(164, 63)
            Me.Panel6.TabIndex = 12
            '
            'Label3
            '
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label3.Location = New System.Drawing.Point(0, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(164, 63)
            Me.Label3.TabIndex = 10
            Me.Label3.Text = "   Observación :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlISP
            '
            Me.pnlISP.Controls.Add(Me.ckbHistorico)
            Me.pnlISP.Controls.Add(Me.Label4)
            Me.pnlISP.Controls.Add(Me.dtpFecIngISP)
            Me.pnlISP.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlISP.Location = New System.Drawing.Point(3, 93)
            Me.pnlISP.Name = "pnlISP"
            Me.pnlISP.Size = New System.Drawing.Size(611, 27)
            Me.pnlISP.TabIndex = 14
            '
            'ckbHistorico
            '
            Me.ckbHistorico.AutoSize = True
            Me.ckbHistorico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbHistorico.Location = New System.Drawing.Point(505, 5)
            Me.ckbHistorico.Name = "ckbHistorico"
            Me.ckbHistorico.Size = New System.Drawing.Size(103, 17)
            Me.ckbHistorico.TabIndex = 8
            Me.ckbHistorico.Text = "Ingreso historico"
            Me.ckbHistorico.UseVisualStyleBackColor = True
            Me.ckbHistorico.Visible = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(8, 7)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(153, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Fec. reg. al Sist. Penitenciario :"
            '
            'dtpFecIngISP
            '
            Me.dtpFecIngISP.Location = New System.Drawing.Point(163, 4)
            Me.dtpFecIngISP.Name = "dtpFecIngISP"
            Me.dtpFecIngISP.Size = New System.Drawing.Size(84, 21)
            Me.dtpFecIngISP.TabIndex = 7
            Me.dtpFecIngISP.Value = "/  /"
            Me.dtpFecIngISP.ValueLong = CType(0, Long)
            '
            'plnNumIng
            '
            Me.plnNumIng.Controls.Add(Me.NumericUpDown1)
            Me.plnNumIng.Controls.Add(Me.Label2)
            Me.plnNumIng.Dock = System.Windows.Forms.DockStyle.Top
            Me.plnNumIng.Location = New System.Drawing.Point(3, 68)
            Me.plnNumIng.Name = "plnNumIng"
            Me.plnNumIng.Size = New System.Drawing.Size(611, 25)
            Me.plnNumIng.TabIndex = 17
            '
            'NumericUpDown1
            '
            Me.NumericUpDown1.Location = New System.Drawing.Point(162, 3)
            Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
            Me.NumericUpDown1.Name = "NumericUpDown1"
            Me.NumericUpDown1.Size = New System.Drawing.Size(84, 20)
            Me.NumericUpDown1.TabIndex = 1
            Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(8, 8)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(84, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "N° Ingreso Inpe:"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.lblMovMotivo)
            Me.Panel1.Controls.Add(Me.lblMovTipo)
            Me.Panel1.Controls.Add(Me.txtMovimiento)
            Me.Panel1.Controls.Add(Me.txtModalidad)
            Me.Panel1.Controls.Add(Me.cbbMovMotivo)
            Me.Panel1.Controls.Add(Me.cbbMovTipo)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(3, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(611, 52)
            Me.Panel1.TabIndex = 12
            '
            'lblMovMotivo
            '
            Me.lblMovMotivo.AutoSize = True
            Me.lblMovMotivo.Location = New System.Drawing.Point(8, 30)
            Me.lblMovMotivo.Name = "lblMovMotivo"
            Me.lblMovMotivo.Size = New System.Drawing.Size(62, 13)
            Me.lblMovMotivo.TabIndex = 4
            Me.lblMovMotivo.Text = "Modalidad :"
            '
            'lblMovTipo
            '
            Me.lblMovTipo.AutoSize = True
            Me.lblMovTipo.Location = New System.Drawing.Point(8, 6)
            Me.lblMovTipo.Name = "lblMovTipo"
            Me.lblMovTipo.Size = New System.Drawing.Size(64, 13)
            Me.lblMovTipo.TabIndex = 2
            Me.lblMovTipo.Text = "Movimiento:"
            '
            'txtMovimiento
            '
            Me.txtMovimiento._BackColor_Focus = System.Drawing.SystemColors.Info
            Me.txtMovimiento._BloquearPaste = False
            Me.txtMovimiento._SeleccionarTodo = False
            Me.txtMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMovimiento.Location = New System.Drawing.Point(163, 3)
            Me.txtMovimiento.Name = "txtMovimiento"
            Me.txtMovimiento.ReadOnly = True
            Me.txtMovimiento.Size = New System.Drawing.Size(445, 20)
            Me.txtMovimiento.TabIndex = 13
            Me.txtMovimiento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMovimiento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtModalidad
            '
            Me.txtModalidad._BackColor_Focus = System.Drawing.SystemColors.Info
            Me.txtModalidad._BloquearPaste = False
            Me.txtModalidad._SeleccionarTodo = False
            Me.txtModalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtModalidad.Location = New System.Drawing.Point(163, 28)
            Me.txtModalidad.Name = "txtModalidad"
            Me.txtModalidad.ReadOnly = True
            Me.txtModalidad.Size = New System.Drawing.Size(445, 20)
            Me.txtModalidad.TabIndex = 14
            Me.txtModalidad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtModalidad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbMovMotivo
            '
            Me.cbbMovMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMovMotivo.FormattingEnabled = True
            Me.cbbMovMotivo.Location = New System.Drawing.Point(162, 27)
            Me.cbbMovMotivo.Name = "cbbMovMotivo"
            Me.cbbMovMotivo.Size = New System.Drawing.Size(446, 21)
            Me.cbbMovMotivo.TabIndex = 5
            '
            'cbbMovTipo
            '
            Me.cbbMovTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMovTipo.FormattingEnabled = True
            Me.cbbMovTipo.Location = New System.Drawing.Point(162, 3)
            Me.cbbMovTipo.Name = "cbbMovTipo"
            Me.cbbMovTipo.Size = New System.Drawing.Size(446, 21)
            Me.cbbMovTipo.TabIndex = 3
            '
            'pnBotones
            '
            Me.pnBotones.BackColor = System.Drawing.Color.Transparent
            Me.pnBotones.Controls.Add(Me.pnlGrabar)
            Me.pnBotones.Controls.Add(Me.pnlEliminar)
            Me.pnBotones.Controls.Add(Me.Panel2)
            Me.pnBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnBotones.Location = New System.Drawing.Point(0, 305)
            Me.pnBotones.Name = "pnBotones"
            Me.pnBotones.Size = New System.Drawing.Size(617, 45)
            Me.pnBotones.TabIndex = 3
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnNuevo)
            Me.pnlGrabar.Controls.Add(Me.btnGrabar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(262, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(183, 45)
            Me.pnlGrabar.TabIndex = 4
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(1, 2)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(90, 40)
            Me.btnNuevo.TabIndex = 0
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
            Me.btnGrabar.Location = New System.Drawing.Point(92, 2)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(90, 40)
            Me.btnGrabar.TabIndex = 1
            Me.btnGrabar.Text = "&Grabar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminar.Location = New System.Drawing.Point(445, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(86, 45)
            Me.pnlEliminar.TabIndex = 5
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(1, 2)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(83, 40)
            Me.btnEliminar.TabIndex = 0
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(531, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(86, 45)
            Me.Panel2.TabIndex = 3
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(1, 2)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(84, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 350)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(617, 42)
            Me.UscAuditUser1.TabIndex = 4
            '
            'frmIngresoPopup_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(617, 392)
            Me.ControlBox = False
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmIngresoPopup_v2"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Ingreso(s) del Interno - ORL"
            Me.gbxFormChildContainer.ResumeLayout(False)
            CType(Me.dgwIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grbDatos.ResumeLayout(False)
            Me.pnlObs.ResumeLayout(False)
            Me.pnlObs.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.pnlISP.ResumeLayout(False)
            Me.pnlISP.PerformLayout()
            Me.plnNumIng.ResumeLayout(False)
            Me.plnNumIng.PerformLayout()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnBotones.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents dgwIngreso As System.Windows.Forms.DataGridView
        Friend WithEvents grbDatos As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFecIngISP As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblMovTipo As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtobservacion As System.Windows.Forms.TextBox
        Friend WithEvents pnBotones As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Protected WithEvents cbbMovTipo As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents lblMovMotivo As System.Windows.Forms.Label
        Friend WithEvents pnlObs As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents pnlISP As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Protected WithEvents cbbMovMotivo As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents txtModalidad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMovimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents plnNumIng As Panel
        Friend WithEvents NumericUpDown1 As NumericUpDown
        Friend WithEvents Label2 As Label
        Friend WithEvents pnlEliminar As Panel
        Friend WithEvents btnEliminar As Button
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents Column15 As DataGridViewImageColumn
        Friend WithEvents col_ing_nro As DataGridViewTextBoxColumn
        Friend WithEvents col_mov_tip_id As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_isp_date As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id_crea_reg As DataGridViewTextBoxColumn
        Friend WithEvents ckbHistorico As CheckBox
    End Class

End Namespace