Namespace Tratamiento.TallerAsistencia
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmInscripcionTaller
        Inherits Legolas.APPUIComponents.FormPopup

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInscripcionTaller))
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtNombreTaller = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label66 = New System.Windows.Forms.Label()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtActividad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtRespSupervisor = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtGrupoAcceso = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtGrupoUsuario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtRespGestTaller = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.dtpFechaInscripcion = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSegundoApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumeroDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label65 = New System.Windows.Forms.Label()
            Me.btnCargarInterno = New System.Windows.Forms.Button()
            Me.txtFechaIngreso = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblFechaIngreso = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtCodigo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtNacionalidad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtFechaNac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSexo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtPrimerApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.txtPrenombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label51 = New System.Windows.Forms.Label()
            Me.Label52 = New System.Windows.Forms.Label()
            Me.txtTipoDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtRaizGrupoUsuario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label11 = New System.Windows.Forms.Label()
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox2)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel9)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(749, 495)
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.Black
            Me.Label10.Location = New System.Drawing.Point(24, 84)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(100, 15)
            Me.Label10.TabIndex = 153
            Me.Label10.Text = "Gestor de Taller :"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.ForeColor = System.Drawing.Color.Black
            Me.Label23.Location = New System.Drawing.Point(19, 62)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(105, 15)
            Me.Label23.TabIndex = 147
            Me.Label23.Text = "Tipo de Actividad :"
            '
            'Label20
            '
            Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(3, 16)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(743, 16)
            Me.Label20.TabIndex = 137
            Me.Label20.Text = "ASIGNACION DE ACTIVIDAD LABORAL"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtNombreTaller
            '
            Me.txtNombreTaller._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombreTaller._BloquearPaste = False
            Me.txtNombreTaller._SeleccionarTodo = False
            Me.txtNombreTaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreTaller.Location = New System.Drawing.Point(125, 36)
            Me.txtNombreTaller.Name = "txtNombreTaller"
            Me.txtNombreTaller.ReadOnly = True
            Me.txtNombreTaller.Size = New System.Drawing.Size(587, 21)
            Me.txtNombreTaller.TabIndex = 152
            Me.txtNombreTaller.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombreTaller.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label66
            '
            Me.Label66.AutoSize = True
            Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label66.ForeColor = System.Drawing.Color.Black
            Me.Label66.Location = New System.Drawing.Point(18, 38)
            Me.Label66.Name = "Label66"
            Me.Label66.Size = New System.Drawing.Size(106, 15)
            Me.Label66.TabIndex = 153
            Me.Label66.Text = "Actividad Laboral :"
            '
            'btnBuscar
            '
            Me.btnBuscar.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.view
            Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Location = New System.Drawing.Point(711, 25)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(33, 33)
            Me.btnBuscar.TabIndex = 154
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'txtActividad
            '
            Me.txtActividad._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtActividad._BloquearPaste = False
            Me.txtActividad._SeleccionarTodo = False
            Me.txtActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActividad.Location = New System.Drawing.Point(125, 59)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.ReadOnly = True
            Me.txtActividad.Size = New System.Drawing.Size(619, 21)
            Me.txtActividad.TabIndex = 156
            Me.txtActividad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtActividad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnBuscar)
            Me.GroupBox1.Controls.Add(Me.txtRespSupervisor)
            Me.GroupBox1.Controls.Add(Me.txtActividad)
            Me.GroupBox1.Controls.Add(Me.txtGrupoAcceso)
            Me.GroupBox1.Controls.Add(Me.txtRaizGrupoUsuario)
            Me.GroupBox1.Controls.Add(Me.txtGrupoUsuario)
            Me.GroupBox1.Controls.Add(Me.txtRespGestTaller)
            Me.GroupBox1.Controls.Add(Me.Label20)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.txtNombreTaller)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Label23)
            Me.GroupBox1.Controls.Add(Me.Label66)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(749, 154)
            Me.GroupBox1.TabIndex = 157
            Me.GroupBox1.TabStop = False
            '
            'txtRespSupervisor
            '
            Me.txtRespSupervisor._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtRespSupervisor._BloquearPaste = False
            Me.txtRespSupervisor._SeleccionarTodo = False
            Me.txtRespSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRespSupervisor.Location = New System.Drawing.Point(467, 82)
            Me.txtRespSupervisor.Name = "txtRespSupervisor"
            Me.txtRespSupervisor.ReadOnly = True
            Me.txtRespSupervisor.Size = New System.Drawing.Size(277, 21)
            Me.txtRespSupervisor.TabIndex = 158
            Me.txtRespSupervisor.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRespSupervisor.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtGrupoAcceso
            '
            Me.txtGrupoAcceso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtGrupoAcceso._BloquearPaste = False
            Me.txtGrupoAcceso._SeleccionarTodo = False
            Me.txtGrupoAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGrupoAcceso.Location = New System.Drawing.Point(125, 128)
            Me.txtGrupoAcceso.Name = "txtGrupoAcceso"
            Me.txtGrupoAcceso.ReadOnly = True
            Me.txtGrupoAcceso.Size = New System.Drawing.Size(618, 21)
            Me.txtGrupoAcceso.TabIndex = 156
            Me.txtGrupoAcceso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtGrupoAcceso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtGrupoUsuario
            '
            Me.txtGrupoUsuario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtGrupoUsuario._BloquearPaste = False
            Me.txtGrupoUsuario._SeleccionarTodo = False
            Me.txtGrupoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGrupoUsuario.Location = New System.Drawing.Point(467, 105)
            Me.txtGrupoUsuario.Name = "txtGrupoUsuario"
            Me.txtGrupoUsuario.ReadOnly = True
            Me.txtGrupoUsuario.Size = New System.Drawing.Size(276, 21)
            Me.txtGrupoUsuario.TabIndex = 156
            Me.txtGrupoUsuario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtGrupoUsuario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtRespGestTaller
            '
            Me.txtRespGestTaller._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtRespGestTaller._BloquearPaste = False
            Me.txtRespGestTaller._SeleccionarTodo = False
            Me.txtRespGestTaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRespGestTaller.Location = New System.Drawing.Point(125, 82)
            Me.txtRespGestTaller.Name = "txtRespGestTaller"
            Me.txtRespGestTaller.ReadOnly = True
            Me.txtRespGestTaller.Size = New System.Drawing.Size(232, 21)
            Me.txtRespGestTaller.TabIndex = 156
            Me.txtRespGestTaller.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRespGestTaller.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Black
            Me.Label9.Location = New System.Drawing.Point(376, 109)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(90, 15)
            Me.Label9.TabIndex = 153
            Me.Label9.Text = "Grupo Usuario:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.Black
            Me.Label8.Location = New System.Drawing.Point(38, 131)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(86, 15)
            Me.Label8.TabIndex = 153
            Me.Label8.Text = "Grupo Acceso:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.Location = New System.Drawing.Point(392, 85)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(71, 15)
            Me.Label6.TabIndex = 157
            Me.Label6.Text = "Supervisor :"
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnGrabar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(572, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(97, 44)
            Me.pnlGrabar.TabIndex = 155
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnGrabar.Location = New System.Drawing.Point(3, 2)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(88, 40)
            Me.btnGrabar.TabIndex = 39
            Me.btnGrabar.Text = "&Grabar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.pnlGrabar)
            Me.Panel9.Controls.Add(Me.btnSalir)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel9.Location = New System.Drawing.Point(0, 451)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(749, 44)
            Me.Panel9.TabIndex = 40
            '
            'btnSalir
            '
            Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(669, 0)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 44)
            Me.btnSalir.TabIndex = 67
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Panel1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 154)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(749, 297)
            Me.GroupBox2.TabIndex = 158
            Me.GroupBox2.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.dtpFechaInscripcion)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.Label7)
            Me.Panel1.Controls.Add(Me.txtObservacion)
            Me.Panel1.Controls.Add(Me.txtSegundoApellido)
            Me.Panel1.Controls.Add(Me.txtNumeroDoc)
            Me.Panel1.Controls.Add(Me.UscFotografia_2v1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.btnCargarInterno)
            Me.Panel1.Controls.Add(Me.txtFechaIngreso)
            Me.Panel1.Controls.Add(Me.lblFechaIngreso)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.txtCodigo)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.txtNacionalidad)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.txtFechaNac)
            Me.Panel1.Controls.Add(Me.txtSexo)
            Me.Panel1.Controls.Add(Me.Label47)
            Me.Panel1.Controls.Add(Me.txtPrimerApellido)
            Me.Panel1.Controls.Add(Me.Label48)
            Me.Panel1.Controls.Add(Me.Label49)
            Me.Panel1.Controls.Add(Me.Label50)
            Me.Panel1.Controls.Add(Me.txtPrenombres)
            Me.Panel1.Controls.Add(Me.Label51)
            Me.Panel1.Controls.Add(Me.Label52)
            Me.Panel1.Controls.Add(Me.txtTipoDoc)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(3, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(743, 278)
            Me.Panel1.TabIndex = 156
            '
            'dtpFechaInscripcion
            '
            Me.dtpFechaInscripcion.Location = New System.Drawing.Point(340, 249)
            Me.dtpFechaInscripcion.Name = "dtpFechaInscripcion"
            Me.dtpFechaInscripcion.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInscripcion.TabIndex = 154
            Me.dtpFechaInscripcion.Value = "/  /"
            Me.dtpFechaInscripcion.ValueLong = CType(0, Long)
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(240, 250)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(85, 15)
            Me.Label1.TabIndex = 153
            Me.Label1.Text = "F. Inscripción :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.Black
            Me.Label7.Location = New System.Drawing.Point(230, 196)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(81, 15)
            Me.Label7.TabIndex = 155
            Me.Label7.Text = "Observación :"
            '
            'txtObservacion
            '
            Me.txtObservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = False
            Me.txtObservacion.BackColor = System.Drawing.SystemColors.Control
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(340, 193)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(400, 43)
            Me.txtObservacion.TabIndex = 156
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSegundoApellido
            '
            Me.txtSegundoApellido._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSegundoApellido._BloquearPaste = True
            Me.txtSegundoApellido._SeleccionarTodo = False
            Me.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSegundoApellido.Location = New System.Drawing.Point(340, 97)
            Me.txtSegundoApellido.Name = "txtSegundoApellido"
            Me.txtSegundoApellido.ReadOnly = True
            Me.txtSegundoApellido.Size = New System.Drawing.Size(399, 21)
            Me.txtSegundoApellido.TabIndex = 105
            Me.txtSegundoApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSegundoApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtNumeroDoc
            '
            Me.txtNumeroDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumeroDoc._BloquearPaste = False
            Me.txtNumeroDoc._SeleccionarTodo = False
            Me.txtNumeroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroDoc.Location = New System.Drawing.Point(575, 49)
            Me.txtNumeroDoc.Name = "txtNumeroDoc"
            Me.txtNumeroDoc.ReadOnly = True
            Me.txtNumeroDoc.Size = New System.Drawing.Size(164, 21)
            Me.txtNumeroDoc.TabIndex = 116
            Me.txtNumeroDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumeroDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label65)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(743, 20)
            Me.Panel2.TabIndex = 156
            '
            'Label65
            '
            Me.Label65.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label65.Location = New System.Drawing.Point(0, 0)
            Me.Label65.Name = "Label65"
            Me.Label65.Size = New System.Drawing.Size(743, 16)
            Me.Label65.TabIndex = 1
            Me.Label65.Text = "DATOS DEL INTERNO"
            Me.Label65.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnCargarInterno
            '
            Me.btnCargarInterno.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.Personal_information_32
            Me.btnCargarInterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnCargarInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargarInterno.ForeColor = System.Drawing.Color.Black
            Me.btnCargarInterno.Location = New System.Drawing.Point(462, 20)
            Me.btnCargarInterno.Name = "btnCargarInterno"
            Me.btnCargarInterno.Size = New System.Drawing.Size(39, 29)
            Me.btnCargarInterno.TabIndex = 99
            Me.btnCargarInterno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCargarInterno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCargarInterno.UseVisualStyleBackColor = True
            '
            'txtFechaIngreso
            '
            Me.txtFechaIngreso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaIngreso._BloquearPaste = False
            Me.txtFechaIngreso._SeleccionarTodo = False
            Me.txtFechaIngreso.BackColor = System.Drawing.SystemColors.Control
            Me.txtFechaIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaIngreso.Location = New System.Drawing.Point(636, 145)
            Me.txtFechaIngreso.Name = "txtFechaIngreso"
            Me.txtFechaIngreso.ReadOnly = True
            Me.txtFechaIngreso.Size = New System.Drawing.Size(104, 21)
            Me.txtFechaIngreso.TabIndex = 128
            Me.txtFechaIngreso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaIngreso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblFechaIngreso
            '
            Me.lblFechaIngreso.AutoSize = True
            Me.lblFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaIngreso.Location = New System.Drawing.Point(543, 148)
            Me.lblFechaIngreso.Name = "lblFechaIngreso"
            Me.lblFechaIngreso.Size = New System.Drawing.Size(91, 15)
            Me.lblFechaIngreso.TabIndex = 127
            Me.lblFechaIngreso.Text = "Fecha Ingreso :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(230, 29)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(52, 15)
            Me.Label4.TabIndex = 122
            Me.Label4.Text = "Código :"
            '
            'txtCodigo
            '
            Me.txtCodigo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodigo._BloquearPaste = False
            Me.txtCodigo._SeleccionarTodo = False
            Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigo.Location = New System.Drawing.Point(340, 25)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.ReadOnly = True
            Me.txtCodigo.Size = New System.Drawing.Size(120, 21)
            Me.txtCodigo.TabIndex = 123
            Me.txtCodigo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodigo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(504, 52)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(68, 15)
            Me.Label3.TabIndex = 115
            Me.Label3.Text = "Núm. Doc.:"
            '
            'txtNacionalidad
            '
            Me.txtNacionalidad._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNacionalidad._BloquearPaste = False
            Me.txtNacionalidad._SeleccionarTodo = False
            Me.txtNacionalidad.BackColor = System.Drawing.SystemColors.Control
            Me.txtNacionalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNacionalidad.Location = New System.Drawing.Point(340, 169)
            Me.txtNacionalidad.Name = "txtNacionalidad"
            Me.txtNacionalidad.ReadOnly = True
            Me.txtNacionalidad.Size = New System.Drawing.Size(399, 21)
            Me.txtNacionalidad.TabIndex = 113
            Me.txtNacionalidad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNacionalidad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(230, 172)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(86, 15)
            Me.Label5.TabIndex = 112
            Me.Label5.Text = "Nacionalidad :"
            '
            'txtFechaNac
            '
            Me.txtFechaNac._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaNac._BloquearPaste = False
            Me.txtFechaNac._SeleccionarTodo = False
            Me.txtFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaNac.Location = New System.Drawing.Point(340, 145)
            Me.txtFechaNac.Name = "txtFechaNac"
            Me.txtFechaNac.ReadOnly = True
            Me.txtFechaNac.Size = New System.Drawing.Size(104, 21)
            Me.txtFechaNac.TabIndex = 109
            Me.txtFechaNac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaNac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSexo
            '
            Me.txtSexo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSexo._BloquearPaste = True
            Me.txtSexo._SeleccionarTodo = False
            Me.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSexo.Location = New System.Drawing.Point(503, 145)
            Me.txtSexo.MaxLength = 3
            Me.txtSexo.Name = "txtSexo"
            Me.txtSexo.ReadOnly = True
            Me.txtSexo.Size = New System.Drawing.Size(33, 21)
            Me.txtSexo.TabIndex = 111
            Me.txtSexo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSexo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label47.ForeColor = System.Drawing.Color.Black
            Me.Label47.Location = New System.Drawing.Point(230, 76)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(97, 15)
            Me.Label47.TabIndex = 102
            Me.Label47.Text = "Primer Apellido :"
            '
            'txtPrimerApellido
            '
            Me.txtPrimerApellido._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPrimerApellido._BloquearPaste = True
            Me.txtPrimerApellido._SeleccionarTodo = False
            Me.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrimerApellido.Location = New System.Drawing.Point(340, 73)
            Me.txtPrimerApellido.Name = "txtPrimerApellido"
            Me.txtPrimerApellido.ReadOnly = True
            Me.txtPrimerApellido.Size = New System.Drawing.Size(399, 21)
            Me.txtPrimerApellido.TabIndex = 103
            Me.txtPrimerApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrimerApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label48.Location = New System.Drawing.Point(230, 100)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(110, 15)
            Me.Label48.TabIndex = 104
            Me.Label48.Text = "Segundo Apellido :"
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label49.Location = New System.Drawing.Point(230, 124)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(86, 15)
            Me.Label49.TabIndex = 106
            Me.Label49.Text = "Pre Nombres :"
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label50.Location = New System.Drawing.Point(460, 148)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(41, 15)
            Me.Label50.TabIndex = 110
            Me.Label50.Text = "Sexo :"
            '
            'txtPrenombres
            '
            Me.txtPrenombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPrenombres._BloquearPaste = True
            Me.txtPrenombres._SeleccionarTodo = False
            Me.txtPrenombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrenombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrenombres.Location = New System.Drawing.Point(340, 121)
            Me.txtPrenombres.Name = "txtPrenombres"
            Me.txtPrenombres.ReadOnly = True
            Me.txtPrenombres.Size = New System.Drawing.Size(399, 21)
            Me.txtPrenombres.TabIndex = 107
            Me.txtPrenombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrenombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label51.Location = New System.Drawing.Point(230, 148)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(75, 15)
            Me.Label51.TabIndex = 108
            Me.Label51.Text = "Fecha Nac. :"
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label52.Location = New System.Drawing.Point(230, 52)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(98, 15)
            Me.Label52.TabIndex = 100
            Me.Label52.Text = "Tipo Doc. Ident. :"
            '
            'txtTipoDoc
            '
            Me.txtTipoDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoDoc._BloquearPaste = False
            Me.txtTipoDoc._SeleccionarTodo = False
            Me.txtTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoDoc.Location = New System.Drawing.Point(340, 49)
            Me.txtTipoDoc.Name = "txtTipoDoc"
            Me.txtTipoDoc.ReadOnly = True
            Me.txtTipoDoc.Size = New System.Drawing.Size(159, 21)
            Me.txtTipoDoc.TabIndex = 101
            Me.txtTipoDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTipoDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.Gray
            Me.Label2.Location = New System.Drawing.Point(233, 232)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(523, 15)
            Me.Label2.TabIndex = 158
            Me.Label2.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------------"
            '
            'txtRaizGrupoUsuario
            '
            Me.txtRaizGrupoUsuario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtRaizGrupoUsuario._BloquearPaste = False
            Me.txtRaizGrupoUsuario._SeleccionarTodo = False
            Me.txtRaizGrupoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRaizGrupoUsuario.Location = New System.Drawing.Point(125, 105)
            Me.txtRaizGrupoUsuario.Name = "txtRaizGrupoUsuario"
            Me.txtRaizGrupoUsuario.ReadOnly = True
            Me.txtRaizGrupoUsuario.Size = New System.Drawing.Size(232, 21)
            Me.txtRaizGrupoUsuario.TabIndex = 156
            Me.txtRaizGrupoUsuario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRaizGrupoUsuario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.Black
            Me.Label11.Location = New System.Drawing.Point(6, 108)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(118, 15)
            Me.Label11.TabIndex = 153
            Me.Label11.Text = "Raiz Grupo Usuario:"
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = True
            Me.UscFotografia_2v1._EnabledDobleClick = True
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = False
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(2, 20)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(225, 253)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 157
            '
            'frmInscripcionTaller
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(749, 495)
            Me.ControlBox = False
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmInscripcionTaller"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Inscripcion en Taller - Nuevo"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.pnlGrabar.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub


        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtActividad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents Label66 As System.Windows.Forms.Label
        Friend WithEvents txtNombreTaller As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtRespSupervisor As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtRespGestTaller As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaInscripcion As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label65 As System.Windows.Forms.Label
        Friend WithEvents btnCargarInterno As System.Windows.Forms.Button
        Friend WithEvents txtFechaIngreso As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNumeroDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNacionalidad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtFechaNac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSexo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents txtPrimerApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents Label49 As System.Windows.Forms.Label
        Friend WithEvents Label50 As System.Windows.Forms.Label
        Friend WithEvents txtPrenombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label51 As System.Windows.Forms.Label
        Friend WithEvents txtSegundoApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label52 As System.Windows.Forms.Label
        Friend WithEvents txtTipoDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents txtGrupoAcceso As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtGrupoUsuario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label9 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents txtRaizGrupoUsuario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label11 As Label
    End Class

End Namespace