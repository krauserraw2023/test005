Namespace Tratamiento.TallerAsistencia.Control
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmRegistrarFaltas
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
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.pnlOK = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.gbrBuscarNumDoc = New System.Windows.Forms.GroupBox()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.lblObservacion = New System.Windows.Forms.Label()
            Me.pnlDocumento = New System.Windows.Forms.Panel()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpFechaDocumento = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblFechaFin = New System.Windows.Forms.Label()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
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
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.cbbTipoJustificacion = New APPControls.uscComboParametrica()
            Me.pnlPie.SuspendLayout()
            Me.pnlOK.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.gbrBuscarNumDoc.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.pnlDocumento.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlPie
            '
            Me.pnlPie.BackColor = System.Drawing.Color.Transparent
            Me.pnlPie.Controls.Add(Me.pnlOK)
            Me.pnlPie.Controls.Add(Me.pnlSalir)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 405)
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
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(453, 405)
            Me.pnlDetalle.TabIndex = 0
            '
            'gbrBuscarNumDoc
            '
            Me.gbrBuscarNumDoc.BackColor = System.Drawing.Color.Transparent
            Me.gbrBuscarNumDoc.Controls.Add(Me.Panel5)
            Me.gbrBuscarNumDoc.Controls.Add(Me.pnlDocumento)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Panel1)
            Me.gbrBuscarNumDoc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbrBuscarNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbrBuscarNumDoc.Location = New System.Drawing.Point(0, 187)
            Me.gbrBuscarNumDoc.Name = "gbrBuscarNumDoc"
            Me.gbrBuscarNumDoc.Size = New System.Drawing.Size(453, 218)
            Me.gbrBuscarNumDoc.TabIndex = 2
            Me.gbrBuscarNumDoc.TabStop = False
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.txtObservacion)
            Me.Panel5.Controls.Add(Me.lblObservacion)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(3, 139)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(447, 76)
            Me.Panel5.TabIndex = 2
            '
            'txtObservacion
            '
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(130, 0)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(317, 76)
            Me.txtObservacion.TabIndex = 1
            '
            'lblObservacion
            '
            Me.lblObservacion.AutoSize = True
            Me.lblObservacion.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObservacion.Location = New System.Drawing.Point(0, 0)
            Me.lblObservacion.Name = "lblObservacion"
            Me.lblObservacion.Size = New System.Drawing.Size(130, 16)
            Me.lblObservacion.TabIndex = 0
            Me.lblObservacion.Text = " Observación:             "
            Me.lblObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlDocumento
            '
            Me.pnlDocumento.Controls.Add(Me.Label7)
            Me.pnlDocumento.Controls.Add(Me.dtpFechaDocumento)
            Me.pnlDocumento.Controls.Add(Me.txtDocumento)
            Me.pnlDocumento.Controls.Add(Me.Label8)
            Me.pnlDocumento.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDocumento.Location = New System.Drawing.Point(3, 84)
            Me.pnlDocumento.Name = "pnlDocumento"
            Me.pnlDocumento.Size = New System.Drawing.Size(447, 55)
            Me.pnlDocumento.TabIndex = 1
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(4, 6)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(101, 16)
            Me.Label7.TabIndex = 0
            Me.Label7.Text = "Nº Documento :"
            '
            'dtpFechaDocumento
            '
            Me.dtpFechaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDocumento.Location = New System.Drawing.Point(129, 30)
            Me.dtpFechaDocumento.Name = "dtpFechaDocumento"
            Me.dtpFechaDocumento.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaDocumento.TabIndex = 3
            Me.dtpFechaDocumento.Value = "/  /"
            Me.dtpFechaDocumento.ValueLong = CType(0, Long)
            '
            'txtDocumento
            '
            Me.txtDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDocumento._BloquearPaste = False
            Me.txtDocumento._SeleccionarTodo = False
            Me.txtDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDocumento.Location = New System.Drawing.Point(129, 3)
            Me.txtDocumento.Name = "txtDocumento"
            Me.txtDocumento.Size = New System.Drawing.Size(309, 22)
            Me.txtDocumento.TabIndex = 1
            Me.txtDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(4, 33)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(78, 16)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Fecha doc :"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.cbbTipoJustificacion)
            Me.Panel1.Controls.Add(Me.lblFecha)
            Me.Panel1.Controls.Add(Me.dtpFechaInicio)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.lblFechaFin)
            Me.Panel1.Controls.Add(Me.dtpFechaFin)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(3, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(447, 68)
            Me.Panel1.TabIndex = 0
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecha.Location = New System.Drawing.Point(4, 42)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(86, 16)
            Me.lblFecha.TabIndex = 3
            Me.lblFecha.Text = "Fecha inicio :"
            Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaInicio.Location = New System.Drawing.Point(129, 39)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInicio.TabIndex = 4
            Me.dtpFechaInicio.Value = "/  /"
            Me.dtpFechaInicio.ValueLong = CType(0, Long)
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(4, 14)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(51, 16)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Motivo:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFechaFin
            '
            Me.lblFechaFin.AutoSize = True
            Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaFin.Location = New System.Drawing.Point(276, 42)
            Me.lblFechaFin.Name = "lblFechaFin"
            Me.lblFechaFin.Size = New System.Drawing.Size(68, 16)
            Me.lblFechaFin.TabIndex = 5
            Me.lblFechaFin.Text = "Fecha fin :"
            Me.lblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFin.Location = New System.Drawing.Point(354, 40)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 6
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.Panel3)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
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
            Me.btnCargarInterno.Location = New System.Drawing.Point(398, 4)
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
            Me.txtNumeroDoc.Location = New System.Drawing.Point(158, 30)
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
            Me.txtActividadLaboral.Location = New System.Drawing.Point(158, 138)
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
            Me.txtTipoDoc.Location = New System.Drawing.Point(158, 4)
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
            Me.txtSegundoApellido.Location = New System.Drawing.Point(158, 84)
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
            Me.txtPrimerApellido.Location = New System.Drawing.Point(158, 57)
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
            Me.txtPrenombres.Location = New System.Drawing.Point(158, 111)
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
            Me.cbbTipoJustificacion.Location = New System.Drawing.Point(129, 9)
            Me.cbbTipoJustificacion.ModuloTratamiento = False
            Me.cbbTipoJustificacion.Name = "cbbTipoJustificacion"
            Me.cbbTipoJustificacion.Parametro1 = -1
            Me.cbbTipoJustificacion.Parametro2 = -1
            Me.cbbTipoJustificacion.SelectedIndex = -1
            Me.cbbTipoJustificacion.SelectedValue = 0
            Me.cbbTipoJustificacion.Size = New System.Drawing.Size(309, 22)
            Me.cbbTipoJustificacion.TabIndex = 1
            '
            'frmRegistrarFaltas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(453, 455)
            Me.Controls.Add(Me.pnlDetalle)
            Me.Controls.Add(Me.pnlPie)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmRegistrarFaltas"
            Me.ShowInTaskbar = False
            Me.Text = "Justificar Inasistencia"
            Me.pnlPie.ResumeLayout(False)
            Me.pnlOK.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            Me.gbrBuscarNumDoc.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.pnlDocumento.ResumeLayout(False)
            Me.pnlDocumento.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents pnlOK As System.Windows.Forms.Panel
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents gbrBuscarNumDoc As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
        Friend WithEvents dtpFechaDocumento As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label8 As Label
        Friend WithEvents txtDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As Label
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblFechaFin As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblObservacion As Label
        Friend WithEvents txtObservacion As TextBox
        Friend WithEvents lblFecha As Label
        Friend WithEvents Panel5 As Panel
        Friend WithEvents pnlDocumento As Panel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents cbbTipoJustificacion As APPControls.uscComboParametrica
    End Class
End Namespace

