Namespace Tratamiento.TallerAsistencia
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmRegularizarAsistencia
        Inherits Legolas.APPUIComponents.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.pnlOK = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.gbrBuscarNumDoc = New System.Windows.Forms.GroupBox()
            Me.cbbTipoJustificacion = New APPControls.uscComboParametrica()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dtpFechaAsistencia = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.pnlHoraInicio = New System.Windows.Forms.Panel()
            Me.nudInicioMinuto = New System.Windows.Forms.NumericUpDown()
            Me.nudInicioHora = New System.Windows.Forms.NumericUpDown()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.pnlHoraFin = New System.Windows.Forms.Panel()
            Me.nudFinMinuto = New System.Windows.Forms.NumericUpDown()
            Me.nudFinHora = New System.Windows.Forms.NumericUpDown()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnCargarInterno = New System.Windows.Forms.Button()
            Me.txtNumeroDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label52 = New System.Windows.Forms.Label()
            Me.txtActividadLaboral = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtTipoDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtSegundoApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtPrimerApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label51 = New System.Windows.Forms.Label()
            Me.Label48 = New System.Windows.Forms.Label()
            Me.txtPrenombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlPie.SuspendLayout()
            Me.pnlOK.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.gbrBuscarNumDoc.SuspendLayout()
            Me.pnlHoraInicio.SuspendLayout()
            CType(Me.nudInicioMinuto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudInicioHora, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlHoraFin.SuspendLayout()
            CType(Me.nudFinMinuto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFinHora, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlPie
            '
            Me.pnlPie.BackColor = System.Drawing.Color.Transparent
            Me.pnlPie.Controls.Add(Me.pnlOK)
            Me.pnlPie.Controls.Add(Me.pnlSalir)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 375)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(453, 50)
            Me.pnlPie.TabIndex = 1
            '
            'pnlOK
            '
            Me.pnlOK.Controls.Add(Me.btnOk)
            Me.pnlOK.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlOK.Location = New System.Drawing.Point(239, 0)
            Me.pnlOK.Name = "pnlOK"
            Me.pnlOK.Size = New System.Drawing.Size(108, 50)
            Me.pnlOK.TabIndex = 0
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(102, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(347, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(106, 50)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(0, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(102, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlDetalle
            '
            Me.pnlDetalle.BackColor = System.Drawing.Color.Transparent
            Me.pnlDetalle.Controls.Add(Me.gbrBuscarNumDoc)
            Me.pnlDetalle.Controls.Add(Me.GroupBox1)
            Me.pnlDetalle.Controls.Add(Me.Panel2)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(453, 375)
            Me.pnlDetalle.TabIndex = 0
            '
            'gbrBuscarNumDoc
            '
            Me.gbrBuscarNumDoc.BackColor = System.Drawing.Color.Transparent
            Me.gbrBuscarNumDoc.Controls.Add(Me.cbbTipoJustificacion)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label3)
            Me.gbrBuscarNumDoc.Controls.Add(Me.dtpFechaAsistencia)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label4)
            Me.gbrBuscarNumDoc.Controls.Add(Me.txtObservacion)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label13)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label8)
            Me.gbrBuscarNumDoc.Controls.Add(Me.pnlHoraInicio)
            Me.gbrBuscarNumDoc.Controls.Add(Me.pnlHoraFin)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label1)
            Me.gbrBuscarNumDoc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbrBuscarNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbrBuscarNumDoc.Location = New System.Drawing.Point(0, 210)
            Me.gbrBuscarNumDoc.Name = "gbrBuscarNumDoc"
            Me.gbrBuscarNumDoc.Size = New System.Drawing.Size(453, 165)
            Me.gbrBuscarNumDoc.TabIndex = 2
            Me.gbrBuscarNumDoc.TabStop = False
            Me.gbrBuscarNumDoc.Text = "Configura Fecha y Hora:"
            '
            'cbbTipoJustificacion
            '
            Me.cbbTipoJustificacion._NoIndica = False
            Me.cbbTipoJustificacion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoJustificacion._Todos = False
            Me.cbbTipoJustificacion._TodosMensaje = ""
            Me.cbbTipoJustificacion._Visible_Add = False
            Me.cbbTipoJustificacion._Visible_Buscar = False
            Me.cbbTipoJustificacion._Visible_Eliminar = False
            Me.cbbTipoJustificacion.CodigoPadre = -1
            Me.cbbTipoJustificacion.ComboTipo = CType(2, Short)
            Me.cbbTipoJustificacion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoJustificacion.DropDownWidth = 143
            Me.cbbTipoJustificacion.DropDownWidthAuto = False
            Me.cbbTipoJustificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbTipoJustificacion.ListaIdsParaExcluir = Nothing
            Me.cbbTipoJustificacion.Location = New System.Drawing.Point(104, 74)
            Me.cbbTipoJustificacion.Name = "cbbTipoJustificacion"
            Me.cbbTipoJustificacion.Parametro1 = -1
            Me.cbbTipoJustificacion.Parametro2 = -1
            Me.cbbTipoJustificacion.SelectedIndex = -1
            Me.cbbTipoJustificacion.SelectedValue = 0
            Me.cbbTipoJustificacion.Size = New System.Drawing.Size(343, 22)
            Me.cbbTipoJustificacion.TabIndex = 7
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(55, 74)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(46, 15)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Motivo:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpFechaAsistencia
            '
            Me.dtpFechaAsistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaAsistencia.Location = New System.Drawing.Point(104, 18)
            Me.dtpFechaAsistencia.Name = "dtpFechaAsistencia"
            Me.dtpFechaAsistencia.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaAsistencia.TabIndex = 1
            Me.dtpFechaAsistencia.Value = "/  /"
            Me.dtpFechaAsistencia.ValueLong = CType(0, Long)
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(13, 101)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(88, 16)
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "Observación:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtObservacion
            '
            Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(104, 100)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(343, 62)
            Me.txtObservacion.TabIndex = 9
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(23, 48)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(78, 16)
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "Hora Inicio :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(257, 48)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(65, 16)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Hora Fin :"
            '
            'pnlHoraInicio
            '
            Me.pnlHoraInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlHoraInicio.Controls.Add(Me.nudInicioMinuto)
            Me.pnlHoraInicio.Controls.Add(Me.nudInicioHora)
            Me.pnlHoraInicio.Controls.Add(Me.Label5)
            Me.pnlHoraInicio.Location = New System.Drawing.Point(104, 43)
            Me.pnlHoraInicio.Name = "pnlHoraInicio"
            Me.pnlHoraInicio.Size = New System.Drawing.Size(110, 28)
            Me.pnlHoraInicio.TabIndex = 3
            '
            'nudInicioMinuto
            '
            Me.nudInicioMinuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudInicioMinuto.Location = New System.Drawing.Point(61, 3)
            Me.nudInicioMinuto.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
            Me.nudInicioMinuto.Name = "nudInicioMinuto"
            Me.nudInicioMinuto.Size = New System.Drawing.Size(40, 20)
            Me.nudInicioMinuto.TabIndex = 1
            '
            'nudInicioHora
            '
            Me.nudInicioHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudInicioHora.Location = New System.Drawing.Point(8, 3)
            Me.nudInicioHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudInicioHora.Name = "nudInicioHora"
            Me.nudInicioHora.Size = New System.Drawing.Size(40, 20)
            Me.nudInicioHora.TabIndex = 0
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(47, 23)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(11, 13)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = ":"
            '
            'pnlHoraFin
            '
            Me.pnlHoraFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlHoraFin.Controls.Add(Me.nudFinMinuto)
            Me.pnlHoraFin.Controls.Add(Me.nudFinHora)
            Me.pnlHoraFin.Controls.Add(Me.Label9)
            Me.pnlHoraFin.Location = New System.Drawing.Point(334, 42)
            Me.pnlHoraFin.Name = "pnlHoraFin"
            Me.pnlHoraFin.Size = New System.Drawing.Size(113, 28)
            Me.pnlHoraFin.TabIndex = 5
            '
            'nudFinMinuto
            '
            Me.nudFinMinuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudFinMinuto.Location = New System.Drawing.Point(60, 3)
            Me.nudFinMinuto.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
            Me.nudFinMinuto.Name = "nudFinMinuto"
            Me.nudFinMinuto.Size = New System.Drawing.Size(40, 20)
            Me.nudFinMinuto.TabIndex = 1
            '
            'nudFinHora
            '
            Me.nudFinHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudFinHora.Location = New System.Drawing.Point(8, 3)
            Me.nudFinHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudFinHora.Name = "nudFinHora"
            Me.nudFinHora.Size = New System.Drawing.Size(40, 20)
            Me.nudFinHora.TabIndex = 0
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(47, 23)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(11, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = ":"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(49, 19)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(52, 16)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Fecha :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.Panel3)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 23)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(453, 187)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            '
            'Panel3
            '
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.Label2)
            Me.Panel3.Controls.Add(Me.btnCargarInterno)
            Me.Panel3.Controls.Add(Me.txtNumeroDoc)
            Me.Panel3.Controls.Add(Me.Label52)
            Me.Panel3.Controls.Add(Me.txtActividadLaboral)
            Me.Panel3.Controls.Add(Me.txtTipoDoc)
            Me.Panel3.Controls.Add(Me.Label47)
            Me.Panel3.Controls.Add(Me.txtSegundoApellido)
            Me.Panel3.Controls.Add(Me.txtPrimerApellido)
            Me.Panel3.Controls.Add(Me.Label51)
            Me.Panel3.Controls.Add(Me.Label48)
            Me.Panel3.Controls.Add(Me.txtPrenombres)
            Me.Panel3.Controls.Add(Me.Label49)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(447, 168)
            Me.Panel3.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(19, 33)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(88, 16)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Número DNI :"
            '
            'btnCargarInterno
            '
            Me.btnCargarInterno.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.Personal_information_32
            Me.btnCargarInterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnCargarInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargarInterno.ForeColor = System.Drawing.Color.Black
            Me.btnCargarInterno.Location = New System.Drawing.Point(401, 4)
            Me.btnCargarInterno.Name = "btnCargarInterno"
            Me.btnCargarInterno.Size = New System.Drawing.Size(39, 37)
            Me.btnCargarInterno.TabIndex = 0
            Me.btnCargarInterno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCargarInterno.UseVisualStyleBackColor = True
            '
            'txtNumeroDoc
            '
            Me.txtNumeroDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumeroDoc._BloquearPaste = False
            Me.txtNumeroDoc._SeleccionarTodo = False
            Me.txtNumeroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroDoc.Location = New System.Drawing.Point(161, 30)
            Me.txtNumeroDoc.Name = "txtNumeroDoc"
            Me.txtNumeroDoc.ReadOnly = True
            Me.txtNumeroDoc.Size = New System.Drawing.Size(232, 22)
            Me.txtNumeroDoc.TabIndex = 4
            Me.txtNumeroDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumeroDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label52.Location = New System.Drawing.Point(19, 7)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(114, 16)
            Me.Label52.TabIndex = 1
            Me.Label52.Text = "Tipo Documento :"
            '
            'txtActividadLaboral
            '
            Me.txtActividadLaboral._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtActividadLaboral._BloquearPaste = False
            Me.txtActividadLaboral._SeleccionarTodo = False
            Me.txtActividadLaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActividadLaboral.Location = New System.Drawing.Point(161, 138)
            Me.txtActividadLaboral.Name = "txtActividadLaboral"
            Me.txtActividadLaboral.ReadOnly = True
            Me.txtActividadLaboral.Size = New System.Drawing.Size(280, 22)
            Me.txtActividadLaboral.TabIndex = 12
            Me.txtActividadLaboral.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtActividadLaboral.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtTipoDoc
            '
            Me.txtTipoDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoDoc._BloquearPaste = False
            Me.txtTipoDoc._SeleccionarTodo = False
            Me.txtTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoDoc.Location = New System.Drawing.Point(161, 4)
            Me.txtTipoDoc.Name = "txtTipoDoc"
            Me.txtTipoDoc.ReadOnly = True
            Me.txtTipoDoc.Size = New System.Drawing.Size(232, 22)
            Me.txtTipoDoc.TabIndex = 2
            Me.txtTipoDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTipoDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label47.ForeColor = System.Drawing.Color.Black
            Me.Label47.Location = New System.Drawing.Point(19, 60)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(106, 16)
            Me.Label47.TabIndex = 5
            Me.Label47.Text = "Primer Apellido :"
            '
            'txtSegundoApellido
            '
            Me.txtSegundoApellido._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSegundoApellido._BloquearPaste = True
            Me.txtSegundoApellido._SeleccionarTodo = False
            Me.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSegundoApellido.Location = New System.Drawing.Point(161, 84)
            Me.txtSegundoApellido.Name = "txtSegundoApellido"
            Me.txtSegundoApellido.ReadOnly = True
            Me.txtSegundoApellido.Size = New System.Drawing.Size(280, 22)
            Me.txtSegundoApellido.TabIndex = 8
            Me.txtSegundoApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSegundoApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtPrimerApellido
            '
            Me.txtPrimerApellido._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPrimerApellido._BloquearPaste = True
            Me.txtPrimerApellido._SeleccionarTodo = False
            Me.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrimerApellido.Location = New System.Drawing.Point(161, 57)
            Me.txtPrimerApellido.Name = "txtPrimerApellido"
            Me.txtPrimerApellido.ReadOnly = True
            Me.txtPrimerApellido.Size = New System.Drawing.Size(280, 22)
            Me.txtPrimerApellido.TabIndex = 6
            Me.txtPrimerApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrimerApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label51.Location = New System.Drawing.Point(19, 141)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(119, 16)
            Me.Label51.TabIndex = 11
            Me.Label51.Text = "Actividad Laboral :"
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label48.Location = New System.Drawing.Point(19, 87)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(122, 16)
            Me.Label48.TabIndex = 7
            Me.Label48.Text = "Segundo Apellido :"
            '
            'txtPrenombres
            '
            Me.txtPrenombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPrenombres._BloquearPaste = True
            Me.txtPrenombres._SeleccionarTodo = False
            Me.txtPrenombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrenombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrenombres.Location = New System.Drawing.Point(161, 111)
            Me.txtPrenombres.Name = "txtPrenombres"
            Me.txtPrenombres.ReadOnly = True
            Me.txtPrenombres.Size = New System.Drawing.Size(280, 22)
            Me.txtPrenombres.TabIndex = 10
            Me.txtPrenombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrenombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label49.Location = New System.Drawing.Point(19, 114)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(94, 16)
            Me.Label49.TabIndex = 9
            Me.Label49.Text = "Pre Nombres :"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label6)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(453, 23)
            Me.Panel2.TabIndex = 0
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(134, 6)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(164, 16)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Regularizar Asistencia"
            '
            'frmRegularizarAsistencia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(453, 425)
            Me.Controls.Add(Me.pnlDetalle)
            Me.Controls.Add(Me.pnlPie)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmRegularizarAsistencia"
            Me.ShowInTaskbar = False
            Me.Text = "Regularizar Papeleta"
            Me.pnlPie.ResumeLayout(False)
            Me.pnlOK.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            Me.gbrBuscarNumDoc.ResumeLayout(False)
            Me.gbrBuscarNumDoc.PerformLayout()
            Me.pnlHoraInicio.ResumeLayout(False)
            Me.pnlHoraInicio.PerformLayout()
            CType(Me.nudInicioMinuto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudInicioHora, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlHoraFin.ResumeLayout(False)
            Me.pnlHoraFin.PerformLayout()
            CType(Me.nudFinMinuto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFinHora, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents pnlOK As System.Windows.Forms.Panel
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents gbrBuscarNumDoc As System.Windows.Forms.GroupBox
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents pnlHoraInicio As System.Windows.Forms.Panel
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents pnlHoraFin As System.Windows.Forms.Panel
        Friend WithEvents nudFinMinuto As System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFinHora As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnCargarInterno As System.Windows.Forms.Button
        Friend WithEvents txtNumeroDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label52 As System.Windows.Forms.Label
        Friend WithEvents txtActividadLaboral As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtTipoDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents txtSegundoApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPrimerApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label51 As System.Windows.Forms.Label
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents txtPrenombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label49 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaAsistencia As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents nudInicioMinuto As System.Windows.Forms.NumericUpDown
        Friend WithEvents nudInicioHora As System.Windows.Forms.NumericUpDown
        Friend WithEvents cbbTipoJustificacion As APPControls.uscComboParametrica
        Friend WithEvents Label3 As Label
    End Class
End Namespace

