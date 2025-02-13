Namespace Registro.Carceleta.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmIngresoPopup_V2
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresoPopup_V2))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.grbDatos = New System.Windows.Forms.GroupBox()
            Me.cbbMovMotivo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.cbbMovTipo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.nudMinutos = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.TextBox1 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox1 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblMovMotivo = New System.Windows.Forms.Label()
            Me.nudHora = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.lblMovTipo = New System.Windows.Forms.Label()
            Me.dtpFechaIngresoISP = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtobservacion = New System.Windows.Forms.TextBox()
            Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpFechaMovIngEP = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.pnBotones = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.dgwIngreso = New System.Windows.Forms.DataGridView()
            Me.lblCount = New System.Windows.Forms.Label()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id_crea_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ing_pen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_isp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column15 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_ing_inp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.grbDatos.SuspendLayout()
            Me.nudMinutos.SuspendLayout()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnBotones.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.dgwIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlCabecera.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbDatos)
            Me.gbxFormChildContainer.Controls.Add(Me.dgwIngreso)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlCabecera)
            Me.gbxFormChildContainer.Controls.Add(Me.pnBotones)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(497, 434)
            '
            'grbDatos
            '
            Me.grbDatos.BackColor = System.Drawing.Color.Transparent
            Me.grbDatos.Controls.Add(Me.cbbMovMotivo)
            Me.grbDatos.Controls.Add(Me.cbbMovTipo)
            Me.grbDatos.Controls.Add(Me.nudMinutos)
            Me.grbDatos.Controls.Add(Me.lblMovMotivo)
            Me.grbDatos.Controls.Add(Me.nudHora)
            Me.grbDatos.Controls.Add(Me.lblMovTipo)
            Me.grbDatos.Controls.Add(Me.dtpFechaIngresoISP)
            Me.grbDatos.Controls.Add(Me.Label4)
            Me.grbDatos.Controls.Add(Me.Label3)
            Me.grbDatos.Controls.Add(Me.txtobservacion)
            Me.grbDatos.Controls.Add(Me.NumericUpDown1)
            Me.grbDatos.Controls.Add(Me.Label2)
            Me.grbDatos.Controls.Add(Me.dtpFechaMovIngEP)
            Me.grbDatos.Controls.Add(Me.Label33)
            Me.grbDatos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbDatos.Location = New System.Drawing.Point(0, 125)
            Me.grbDatos.Name = "grbDatos"
            Me.grbDatos.Size = New System.Drawing.Size(497, 222)
            Me.grbDatos.TabIndex = 2
            Me.grbDatos.TabStop = False
            '
            'cbbMovMotivo
            '
            Me.cbbMovMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMovMotivo.FormattingEnabled = True
            Me.cbbMovMotivo.Location = New System.Drawing.Point(158, 68)
            Me.cbbMovMotivo.Name = "cbbMovMotivo"
            Me.cbbMovMotivo.Size = New System.Drawing.Size(332, 21)
            Me.cbbMovMotivo.TabIndex = 14
            '
            'cbbMovTipo
            '
            Me.cbbMovTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMovTipo.FormattingEnabled = True
            Me.cbbMovTipo.Location = New System.Drawing.Point(158, 42)
            Me.cbbMovTipo.Name = "cbbMovTipo"
            Me.cbbMovTipo.Size = New System.Drawing.Size(332, 21)
            Me.cbbMovTipo.TabIndex = 3
            '
            'nudMinutos
            '
            Me.nudMinutos._Formato = "00"
            Me.nudMinutos._Increment = 1
            Me.nudMinutos._Maximum = 59
            Me.nudMinutos._Minimum = 0
            Me.nudMinutos._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudMinutos._Value = 12
            Me.nudMinutos.Controls.Add(Me.TextBox1)
            Me.nudMinutos.Controls.Add(Me.MyTextBox1)
            Me.nudMinutos.Controls.Add(Me.MyTextBox2)
            Me.nudMinutos.Location = New System.Drawing.Point(289, 123)
            Me.nudMinutos.Name = "nudMinutos"
            Me.nudMinutos.Size = New System.Drawing.Size(34, 20)
            Me.nudMinutos.TabIndex = 11
            '
            'TextBox1
            '
            Me.TextBox1._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.TextBox1._BloquearPaste = False
            Me.TextBox1._SeleccionarTodo = False
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox1.Location = New System.Drawing.Point(2, 3)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(14, 13)
            Me.TextBox1.TabIndex = 0
            Me.TextBox1.Text = "5"
            Me.TextBox1.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.TextBox1.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox1
            '
            Me.MyTextBox1._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox1._BloquearPaste = False
            Me.MyTextBox1._SeleccionarTodo = False
            Me.MyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox1.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox1.Name = "MyTextBox1"
            Me.MyTextBox1.Size = New System.Drawing.Size(14, 13)
            Me.MyTextBox1.TabIndex = 0
            Me.MyTextBox1.Text = "5"
            Me.MyTextBox1.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox1.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox2
            '
            Me.MyTextBox2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox2._BloquearPaste = False
            Me.MyTextBox2._SeleccionarTodo = False
            Me.MyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox2.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox2.Name = "MyTextBox2"
            Me.MyTextBox2.Size = New System.Drawing.Size(14, 13)
            Me.MyTextBox2.TabIndex = 0
            Me.MyTextBox2.Text = "5"
            Me.MyTextBox2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'lblMovMotivo
            '
            Me.lblMovMotivo.AutoSize = True
            Me.lblMovMotivo.Location = New System.Drawing.Point(4, 71)
            Me.lblMovMotivo.Name = "lblMovMotivo"
            Me.lblMovMotivo.Size = New System.Drawing.Size(62, 13)
            Me.lblMovMotivo.TabIndex = 4
            Me.lblMovMotivo.Text = "Modalidad :"
            '
            'nudHora
            '
            Me.nudHora._Formato = "00"
            Me.nudHora._Increment = 1
            Me.nudHora._Maximum = 23
            Me.nudHora._Minimum = 0
            Me.nudHora._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudHora._Value = 12
            Me.nudHora.Location = New System.Drawing.Point(248, 123)
            Me.nudHora.Name = "nudHora"
            Me.nudHora.Size = New System.Drawing.Size(34, 20)
            Me.nudHora.TabIndex = 10
            '
            'lblMovTipo
            '
            Me.lblMovTipo.AutoSize = True
            Me.lblMovTipo.Location = New System.Drawing.Point(4, 46)
            Me.lblMovTipo.Name = "lblMovTipo"
            Me.lblMovTipo.Size = New System.Drawing.Size(64, 13)
            Me.lblMovTipo.TabIndex = 2
            Me.lblMovTipo.Text = "Movimiento:"
            '
            'dtpFechaIngresoISP
            '
            Me.dtpFechaIngresoISP.Location = New System.Drawing.Point(158, 96)
            Me.dtpFechaIngresoISP.Name = "dtpFechaIngresoISP"
            Me.dtpFechaIngresoISP.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIngresoISP.TabIndex = 7
            Me.dtpFechaIngresoISP.Value = "/  /"
            Me.dtpFechaIngresoISP.ValueLong = CType(0, Long)
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(4, 99)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(153, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Fec. reg. al Sist. Penitenciario :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(3, 150)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(73, 13)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Observación :"
            '
            'txtobservacion
            '
            Me.txtobservacion.Location = New System.Drawing.Point(158, 152)
            Me.txtobservacion.MaxLength = 500
            Me.txtobservacion.Multiline = True
            Me.txtobservacion.Name = "txtobservacion"
            Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtobservacion.Size = New System.Drawing.Size(332, 57)
            Me.txtobservacion.TabIndex = 13
            '
            'NumericUpDown1
            '
            Me.NumericUpDown1.Location = New System.Drawing.Point(158, 17)
            Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
            Me.NumericUpDown1.Name = "NumericUpDown1"
            Me.NumericUpDown1.Size = New System.Drawing.Size(84, 20)
            Me.NumericUpDown1.TabIndex = 1
            Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(4, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(63, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "N° Ingreso :"
            '
            'dtpFechaMovIngEP
            '
            Me.dtpFechaMovIngEP.Location = New System.Drawing.Point(158, 123)
            Me.dtpFechaMovIngEP.Name = "dtpFechaMovIngEP"
            Me.dtpFechaMovIngEP.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaMovIngEP.TabIndex = 9
            Me.dtpFechaMovIngEP.Value = "/  /"
            Me.dtpFechaMovIngEP.ValueLong = CType(0, Long)
            '
            'Label33
            '
            Me.Label33.Location = New System.Drawing.Point(4, 125)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(146, 19)
            Me.Label33.TabIndex = 8
            Me.Label33.Text = "Ultimo Ingreso a Carceleta :"
            '
            'pnBotones
            '
            Me.pnBotones.BackColor = System.Drawing.Color.Transparent
            Me.pnBotones.Controls.Add(Me.pnlGrabar)
            Me.pnBotones.Controls.Add(Me.pnlEliminar)
            Me.pnBotones.Controls.Add(Me.Panel2)
            Me.pnBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnBotones.Location = New System.Drawing.Point(0, 347)
            Me.pnBotones.Name = "pnBotones"
            Me.pnBotones.Size = New System.Drawing.Size(497, 45)
            Me.pnBotones.TabIndex = 3
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnNuevo)
            Me.pnlGrabar.Controls.Add(Me.btnGrabar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(142, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(183, 45)
            Me.pnlGrabar.TabIndex = 0
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
            Me.pnlEliminar.Location = New System.Drawing.Point(325, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(86, 45)
            Me.pnlEliminar.TabIndex = 1
            Me.pnlEliminar.Visible = False
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
            Me.Panel2.Location = New System.Drawing.Point(411, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(86, 45)
            Me.Panel2.TabIndex = 2
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
            Me.dgwIngreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ing_inp_id, Me.Column15, Me.col_ing_nro, Me.col_fec_isp, Me.col_fec_ing_pen, Me.col_pen_id_crea_reg, Me.Column1})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwIngreso.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgwIngreso.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgwIngreso.GridColor = System.Drawing.Color.LightGray
            Me.dgwIngreso.Location = New System.Drawing.Point(0, 25)
            Me.dgwIngreso.MultiSelect = False
            Me.dgwIngreso.Name = "dgwIngreso"
            Me.dgwIngreso.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwIngreso.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwIngreso.RowHeadersVisible = False
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwIngreso.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwIngreso.Size = New System.Drawing.Size(497, 100)
            Me.dgwIngreso.TabIndex = 1
            '
            'lblCount
            '
            Me.lblCount.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCount.Location = New System.Drawing.Point(0, 0)
            Me.lblCount.Name = "lblCount"
            Me.lblCount.Size = New System.Drawing.Size(497, 25)
            Me.lblCount.TabIndex = 0
            Me.lblCount.Text = "0 Reg."
            Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.lblCount)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(497, 25)
            Me.pnlCabecera.TabIndex = 0
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 392)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(497, 42)
            Me.UscAuditUser1.TabIndex = 4
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "getROrigen"
            Me.Column1.HeaderText = "Registrado"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 150
            '
            'col_pen_id_crea_reg
            '
            Me.col_pen_id_crea_reg.DataPropertyName = "RegistroCreaPenalID"
            Me.col_pen_id_crea_reg.HeaderText = "PenIdCreaReg"
            Me.col_pen_id_crea_reg.Name = "col_pen_id_crea_reg"
            Me.col_pen_id_crea_reg.ReadOnly = True
            Me.col_pen_id_crea_reg.Visible = False
            '
            'col_fec_ing_pen
            '
            Me.col_fec_ing_pen.DataPropertyName = "getFechaMovIngresoString"
            Me.col_fec_ing_pen.HeaderText = "F. Ing. Carceleta"
            Me.col_fec_ing_pen.Name = "col_fec_ing_pen"
            Me.col_fec_ing_pen.ReadOnly = True
            Me.col_fec_ing_pen.ToolTipText = "Fecha Ingreso a Carceleta"
            Me.col_fec_ing_pen.Width = 110
            '
            'col_fec_isp
            '
            Me.col_fec_isp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_fec_isp.DataPropertyName = "FechaISPDate"
            DataGridViewCellStyle2.Format = "d"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.col_fec_isp.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_fec_isp.HeaderText = "F. Reg. Sis. Pen."
            Me.col_fec_isp.Name = "col_fec_isp"
            Me.col_fec_isp.ReadOnly = True
            Me.col_fec_isp.Width = 120
            '
            'col_ing_nro
            '
            Me.col_ing_nro.DataPropertyName = "IngresoNro"
            Me.col_ing_nro.HeaderText = "Nro Ing."
            Me.col_ing_nro.Name = "col_ing_nro"
            Me.col_ing_nro.ReadOnly = True
            Me.col_ing_nro.Width = 68
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
            'col_ing_inp_id
            '
            Me.col_ing_inp_id.DataPropertyName = "Codigo"
            Me.col_ing_inp_id.HeaderText = "IngresoID"
            Me.col_ing_inp_id.Name = "col_ing_inp_id"
            Me.col_ing_inp_id.ReadOnly = True
            Me.col_ing_inp_id.Visible = False
            Me.col_ing_inp_id.Width = 30
            '
            'frmIngresoPopup_V2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(497, 434)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmIngresoPopup_V2"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Ingreso(s) del Interno - Carceleta"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.grbDatos.ResumeLayout(False)
            Me.grbDatos.PerformLayout()
            Me.nudMinutos.ResumeLayout(False)
            Me.nudMinutos.PerformLayout()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnBotones.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.dgwIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlCabecera.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbDatos As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaMovIngEP As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
        Friend WithEvents txtobservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents pnBotones As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents dtpFechaIngresoISP As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents dgwIngreso As System.Windows.Forms.DataGridView
        Friend WithEvents lblCount As System.Windows.Forms.Label
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents lblMovTipo As System.Windows.Forms.Label
        Friend WithEvents lblMovMotivo As System.Windows.Forms.Label
        Friend WithEvents nudMinutos As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents TextBox1 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox1 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents nudHora As Legolas.APPUIComponents.uscNumericUpDown
        Protected WithEvents cbbMovTipo As Legolas.APPUIComponents.MyComboBox
        Protected WithEvents cbbMovMotivo As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents col_ing_inp_id As DataGridViewTextBoxColumn
        Friend WithEvents Column15 As DataGridViewImageColumn
        Friend WithEvents col_ing_nro As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_isp As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ing_pen As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id_crea_reg As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
    End Class

End Namespace