<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscProgramacionOrdinario
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
        Me.components = New System.ComponentModel.Container()
        Me.grbUser = New System.Windows.Forms.GroupBox()
        Me.pnlUsc = New System.Windows.Forms.Panel()
        Me.grbDuracion = New System.Windows.Forms.GroupBox()
        Me.txtDuracion = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.rdbDefinirHora = New System.Windows.Forms.RadioButton()
        Me.rdbTodoelDia = New System.Windows.Forms.RadioButton()
        Me.pnlHoraFin = New System.Windows.Forms.Panel()
        Me.nudFinMinuto = New System.Windows.Forms.NumericUpDown()
        Me.nudFinHora = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlHoraInicio = New System.Windows.Forms.Panel()
        Me.nudInicioMinuto = New System.Windows.Forms.NumericUpDown()
        Me.nudInicioHora = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlConfigurarParentesco = New System.Windows.Forms.Panel()
        Me.grbParentesco = New System.Windows.Forms.GroupBox()
        Me.pnlIncluye = New System.Windows.Forms.Panel()
        Me.pnlAbogado = New System.Windows.Forms.Panel()
        Me.chkIncluyeAbogado = New System.Windows.Forms.CheckBox()
        Me.pnlAmigos = New System.Windows.Forms.Panel()
        Me.chkIncluyeAmigos = New System.Windows.Forms.CheckBox()
        Me.pnlConyugue = New System.Windows.Forms.Panel()
        Me.chkIncluyeConyugue = New System.Windows.Forms.CheckBox()
        Me.grbEdad = New System.Windows.Forms.GroupBox()
        Me.pnlEdad = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbEdadIni = New Legolas.APPUIComponents.MyComboBox(Me.components)
        Me.cbbEdadFin = New Legolas.APPUIComponents.MyComboBox(Me.components)
        Me.chkHabRangoEdades = New System.Windows.Forms.CheckBox()
        Me.pnlParentesco = New System.Windows.Forms.Panel()
        Me.grbAfinidad = New System.Windows.Forms.GroupBox()
        Me.pnlFamiliarAfinidad = New System.Windows.Forms.Panel()
        Me.cbbGradoAfinidad = New Legolas.APPUIComponents.MyComboBox(Me.components)
        Me.nupFamiliarAfinidadCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkFamiliarAfinidad = New System.Windows.Forms.CheckBox()
        Me.grbConsanguidad = New System.Windows.Forms.GroupBox()
        Me.pnlFamiliaresConsanguidad = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbbGradoConsanguidad = New Legolas.APPUIComponents.MyComboBox(Me.components)
        Me.nupFamiliarConsanguidadCantidad = New System.Windows.Forms.NumericUpDown()
        Me.chkFamiliarConsanguidad = New System.Windows.Forms.CheckBox()
        Me.pnlLimite = New System.Windows.Forms.Panel()
        Me.chkHabilitarlimite = New System.Windows.Forms.CheckBox()
        Me.nudLimiteVisitantes = New System.Windows.Forms.NumericUpDown()
        Me.grbOpciones = New System.Windows.Forms.GroupBox()
        Me.chkRegistradoPreviamente = New System.Windows.Forms.CheckBox()
        Me.grbUser.SuspendLayout()
        Me.pnlUsc.SuspendLayout()
        Me.grbDuracion.SuspendLayout()
        Me.pnlHoraFin.SuspendLayout()
        CType(Me.nudFinMinuto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFinHora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHoraInicio.SuspendLayout()
        CType(Me.nudInicioMinuto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInicioHora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConfigurarParentesco.SuspendLayout()
        Me.grbParentesco.SuspendLayout()
        Me.pnlIncluye.SuspendLayout()
        Me.pnlAbogado.SuspendLayout()
        Me.pnlAmigos.SuspendLayout()
        Me.pnlConyugue.SuspendLayout()
        Me.grbEdad.SuspendLayout()
        Me.pnlEdad.SuspendLayout()
        Me.pnlParentesco.SuspendLayout()
        Me.grbAfinidad.SuspendLayout()
        Me.pnlFamiliarAfinidad.SuspendLayout()
        CType(Me.nupFamiliarAfinidadCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbConsanguidad.SuspendLayout()
        Me.pnlFamiliaresConsanguidad.SuspendLayout()
        CType(Me.nupFamiliarConsanguidadCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLimite.SuspendLayout()
        CType(Me.nudLimiteVisitantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbUser
        '
        Me.grbUser.BackColor = System.Drawing.Color.Transparent
        Me.grbUser.Controls.Add(Me.pnlUsc)
        Me.grbUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbUser.Location = New System.Drawing.Point(0, 0)
        Me.grbUser.Name = "grbUser"
        Me.grbUser.Size = New System.Drawing.Size(435, 452)
        Me.grbUser.TabIndex = 72
        Me.grbUser.TabStop = False
        '
        'pnlUsc
        '
        Me.pnlUsc.Controls.Add(Me.grbDuracion)
        Me.pnlUsc.Controls.Add(Me.pnlConfigurarParentesco)
        Me.pnlUsc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUsc.Location = New System.Drawing.Point(3, 16)
        Me.pnlUsc.Name = "pnlUsc"
        Me.pnlUsc.Size = New System.Drawing.Size(429, 433)
        Me.pnlUsc.TabIndex = 71
        '
        'grbDuracion
        '
        Me.grbDuracion.Controls.Add(Me.txtDuracion)
        Me.grbDuracion.Controls.Add(Me.rdbDefinirHora)
        Me.grbDuracion.Controls.Add(Me.rdbTodoelDia)
        Me.grbDuracion.Controls.Add(Me.pnlHoraFin)
        Me.grbDuracion.Controls.Add(Me.pnlHoraInicio)
        Me.grbDuracion.Controls.Add(Me.Label2)
        Me.grbDuracion.Controls.Add(Me.Label15)
        Me.grbDuracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbDuracion.Location = New System.Drawing.Point(296, 0)
        Me.grbDuracion.Name = "grbDuracion"
        Me.grbDuracion.Size = New System.Drawing.Size(133, 433)
        Me.grbDuracion.TabIndex = 12
        Me.grbDuracion.TabStop = False
        Me.grbDuracion.Text = "Hora/Duracion"
        '
        'txtDuracion
        '
        Me.txtDuracion._BloquearPaste = False
        Me.txtDuracion._SeleccionarTodo = False
        Me.txtDuracion.Location = New System.Drawing.Point(66, 194)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.ReadOnly = True
        Me.txtDuracion.Size = New System.Drawing.Size(37, 20)
        Me.txtDuracion.TabIndex = 93
        Me.txtDuracion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtDuracion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'rdbDefinirHora
        '
        Me.rdbDefinirHora.AutoSize = True
        Me.rdbDefinirHora.Checked = True
        Me.rdbDefinirHora.Location = New System.Drawing.Point(9, 42)
        Me.rdbDefinirHora.Name = "rdbDefinirHora"
        Me.rdbDefinirHora.Size = New System.Drawing.Size(81, 17)
        Me.rdbDefinirHora.TabIndex = 92
        Me.rdbDefinirHora.TabStop = True
        Me.rdbDefinirHora.Text = "Definir Hora"
        Me.rdbDefinirHora.UseVisualStyleBackColor = True
        '
        'rdbTodoelDia
        '
        Me.rdbTodoelDia.AutoSize = True
        Me.rdbTodoelDia.Location = New System.Drawing.Point(9, 20)
        Me.rdbTodoelDia.Name = "rdbTodoelDia"
        Me.rdbTodoelDia.Size = New System.Drawing.Size(78, 17)
        Me.rdbTodoelDia.TabIndex = 91
        Me.rdbTodoelDia.Text = "Todo el dia"
        Me.rdbTodoelDia.UseVisualStyleBackColor = True
        '
        'pnlHoraFin
        '
        Me.pnlHoraFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHoraFin.Controls.Add(Me.nudFinMinuto)
        Me.pnlHoraFin.Controls.Add(Me.nudFinHora)
        Me.pnlHoraFin.Controls.Add(Me.Label8)
        Me.pnlHoraFin.Controls.Add(Me.Label9)
        Me.pnlHoraFin.Location = New System.Drawing.Point(8, 131)
        Me.pnlHoraFin.Name = "pnlHoraFin"
        Me.pnlHoraFin.Size = New System.Drawing.Size(105, 51)
        Me.pnlHoraFin.TabIndex = 89
        '
        'nudFinMinuto
        '
        Me.nudFinMinuto.Location = New System.Drawing.Point(56, 20)
        Me.nudFinMinuto.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudFinMinuto.Name = "nudFinMinuto"
        Me.nudFinMinuto.Size = New System.Drawing.Size(40, 20)
        Me.nudFinMinuto.TabIndex = 90
        '
        'nudFinHora
        '
        Me.nudFinHora.Location = New System.Drawing.Point(9, 20)
        Me.nudFinHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudFinHora.Name = "nudFinHora"
        Me.nudFinHora.Size = New System.Drawing.Size(40, 20)
        Me.nudFinHora.TabIndex = 89
        Me.nudFinHora.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Hora Fin :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = ":"
        '
        'pnlHoraInicio
        '
        Me.pnlHoraInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHoraInicio.Controls.Add(Me.nudInicioMinuto)
        Me.pnlHoraInicio.Controls.Add(Me.nudInicioHora)
        Me.pnlHoraInicio.Controls.Add(Me.Label13)
        Me.pnlHoraInicio.Controls.Add(Me.Label1)
        Me.pnlHoraInicio.Location = New System.Drawing.Point(8, 71)
        Me.pnlHoraInicio.Name = "pnlHoraInicio"
        Me.pnlHoraInicio.Size = New System.Drawing.Size(105, 51)
        Me.pnlHoraInicio.TabIndex = 13
        '
        'nudInicioMinuto
        '
        Me.nudInicioMinuto.Location = New System.Drawing.Point(56, 20)
        Me.nudInicioMinuto.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudInicioMinuto.Name = "nudInicioMinuto"
        Me.nudInicioMinuto.Size = New System.Drawing.Size(40, 20)
        Me.nudInicioMinuto.TabIndex = 90
        '
        'nudInicioHora
        '
        Me.nudInicioHora.Location = New System.Drawing.Point(9, 20)
        Me.nudInicioHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudInicioHora.Name = "nudInicioHora"
        Me.nudInicioHora.Size = New System.Drawing.Size(40, 20)
        Me.nudInicioHora.TabIndex = 89
        Me.nudInicioHora.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 13)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Hora Inicio :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Duracion :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(8, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 13)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "(*) Expresado en minutos"
        '
        'pnlConfigurarParentesco
        '
        Me.pnlConfigurarParentesco.Controls.Add(Me.grbParentesco)
        Me.pnlConfigurarParentesco.Controls.Add(Me.grbOpciones)
        Me.pnlConfigurarParentesco.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlConfigurarParentesco.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigurarParentesco.Name = "pnlConfigurarParentesco"
        Me.pnlConfigurarParentesco.Size = New System.Drawing.Size(296, 433)
        Me.pnlConfigurarParentesco.TabIndex = 88
        '
        'grbParentesco
        '
        Me.grbParentesco.Controls.Add(Me.pnlIncluye)
        Me.grbParentesco.Controls.Add(Me.grbEdad)
        Me.grbParentesco.Controls.Add(Me.pnlParentesco)
        Me.grbParentesco.Controls.Add(Me.pnlLimite)
        Me.grbParentesco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbParentesco.Location = New System.Drawing.Point(0, 32)
        Me.grbParentesco.Name = "grbParentesco"
        Me.grbParentesco.Size = New System.Drawing.Size(296, 401)
        Me.grbParentesco.TabIndex = 9
        Me.grbParentesco.TabStop = False
        Me.grbParentesco.Text = "Limite de visitantes/Parentesco"
        '
        'pnlIncluye
        '
        Me.pnlIncluye.Controls.Add(Me.pnlAbogado)
        Me.pnlIncluye.Controls.Add(Me.pnlAmigos)
        Me.pnlIncluye.Controls.Add(Me.pnlConyugue)
        Me.pnlIncluye.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlIncluye.Location = New System.Drawing.Point(3, 269)
        Me.pnlIncluye.Name = "pnlIncluye"
        Me.pnlIncluye.Size = New System.Drawing.Size(290, 78)
        Me.pnlIncluye.TabIndex = 94
        '
        'pnlAbogado
        '
        Me.pnlAbogado.Controls.Add(Me.chkIncluyeAbogado)
        Me.pnlAbogado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAbogado.Location = New System.Drawing.Point(0, 48)
        Me.pnlAbogado.Name = "pnlAbogado"
        Me.pnlAbogado.Size = New System.Drawing.Size(290, 24)
        Me.pnlAbogado.TabIndex = 96
        '
        'chkIncluyeAbogado
        '
        Me.chkIncluyeAbogado.AutoSize = True
        Me.chkIncluyeAbogado.Location = New System.Drawing.Point(6, 3)
        Me.chkIncluyeAbogado.Name = "chkIncluyeAbogado"
        Me.chkIncluyeAbogado.Size = New System.Drawing.Size(125, 17)
        Me.chkIncluyeAbogado.TabIndex = 86
        Me.chkIncluyeAbogado.Text = "Incluye abogado (as)"
        Me.chkIncluyeAbogado.UseVisualStyleBackColor = True
        '
        'pnlAmigos
        '
        Me.pnlAmigos.Controls.Add(Me.chkIncluyeAmigos)
        Me.pnlAmigos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAmigos.Location = New System.Drawing.Point(0, 24)
        Me.pnlAmigos.Name = "pnlAmigos"
        Me.pnlAmigos.Size = New System.Drawing.Size(290, 24)
        Me.pnlAmigos.TabIndex = 95
        '
        'chkIncluyeAmigos
        '
        Me.chkIncluyeAmigos.AutoSize = True
        Me.chkIncluyeAmigos.Location = New System.Drawing.Point(6, 4)
        Me.chkIncluyeAmigos.Name = "chkIncluyeAmigos"
        Me.chkIncluyeAmigos.Size = New System.Drawing.Size(116, 17)
        Me.chkIncluyeAmigos.TabIndex = 85
        Me.chkIncluyeAmigos.Text = "Incluye amigos (as)"
        Me.chkIncluyeAmigos.UseVisualStyleBackColor = True
        '
        'pnlConyugue
        '
        Me.pnlConyugue.Controls.Add(Me.chkIncluyeConyugue)
        Me.pnlConyugue.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConyugue.Location = New System.Drawing.Point(0, 0)
        Me.pnlConyugue.Name = "pnlConyugue"
        Me.pnlConyugue.Size = New System.Drawing.Size(290, 24)
        Me.pnlConyugue.TabIndex = 94
        '
        'chkIncluyeConyugue
        '
        Me.chkIncluyeConyugue.AutoSize = True
        Me.chkIncluyeConyugue.Location = New System.Drawing.Point(6, 4)
        Me.chkIncluyeConyugue.Name = "chkIncluyeConyugue"
        Me.chkIncluyeConyugue.Size = New System.Drawing.Size(188, 17)
        Me.chkIncluyeConyugue.TabIndex = 80
        Me.chkIncluyeConyugue.Text = "Incluye conyugue o Concubina (o)"
        Me.chkIncluyeConyugue.UseVisualStyleBackColor = True
        '
        'grbEdad
        '
        Me.grbEdad.Controls.Add(Me.pnlEdad)
        Me.grbEdad.Controls.Add(Me.chkHabRangoEdades)
        Me.grbEdad.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbEdad.Location = New System.Drawing.Point(3, 195)
        Me.grbEdad.Name = "grbEdad"
        Me.grbEdad.Size = New System.Drawing.Size(290, 74)
        Me.grbEdad.TabIndex = 95
        Me.grbEdad.TabStop = False
        '
        'pnlEdad
        '
        Me.pnlEdad.Controls.Add(Me.Label10)
        Me.pnlEdad.Controls.Add(Me.Label3)
        Me.pnlEdad.Controls.Add(Me.cbbEdadIni)
        Me.pnlEdad.Controls.Add(Me.cbbEdadFin)
        Me.pnlEdad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEdad.Enabled = False
        Me.pnlEdad.Location = New System.Drawing.Point(3, 33)
        Me.pnlEdad.Name = "pnlEdad"
        Me.pnlEdad.Size = New System.Drawing.Size(284, 38)
        Me.pnlEdad.TabIndex = 91
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(152, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Fin :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Inicio :"
        '
        'cbbEdadIni
        '
        Me.cbbEdadIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbEdadIni.FormattingEnabled = True
        Me.cbbEdadIni.Location = New System.Drawing.Point(49, 9)
        Me.cbbEdadIni.Name = "cbbEdadIni"
        Me.cbbEdadIni.Size = New System.Drawing.Size(72, 21)
        Me.cbbEdadIni.TabIndex = 94
        '
        'cbbEdadFin
        '
        Me.cbbEdadFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbEdadFin.FormattingEnabled = True
        Me.cbbEdadFin.Location = New System.Drawing.Point(189, 9)
        Me.cbbEdadFin.Name = "cbbEdadFin"
        Me.cbbEdadFin.Size = New System.Drawing.Size(72, 21)
        Me.cbbEdadFin.TabIndex = 99
        '
        'chkHabRangoEdades
        '
        Me.chkHabRangoEdades.AutoSize = True
        Me.chkHabRangoEdades.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkHabRangoEdades.Location = New System.Drawing.Point(3, 16)
        Me.chkHabRangoEdades.Name = "chkHabRangoEdades"
        Me.chkHabRangoEdades.Size = New System.Drawing.Size(284, 17)
        Me.chkHabRangoEdades.TabIndex = 100
        Me.chkHabRangoEdades.Text = "Habilitar rango de edades"
        Me.chkHabRangoEdades.UseVisualStyleBackColor = True
        '
        'pnlParentesco
        '
        Me.pnlParentesco.Controls.Add(Me.grbAfinidad)
        Me.pnlParentesco.Controls.Add(Me.grbConsanguidad)
        Me.pnlParentesco.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlParentesco.Enabled = False
        Me.pnlParentesco.Location = New System.Drawing.Point(3, 43)
        Me.pnlParentesco.Name = "pnlParentesco"
        Me.pnlParentesco.Size = New System.Drawing.Size(290, 152)
        Me.pnlParentesco.TabIndex = 13
        '
        'grbAfinidad
        '
        Me.grbAfinidad.Controls.Add(Me.pnlFamiliarAfinidad)
        Me.grbAfinidad.Controls.Add(Me.chkFamiliarAfinidad)
        Me.grbAfinidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbAfinidad.Location = New System.Drawing.Point(0, 74)
        Me.grbAfinidad.Name = "grbAfinidad"
        Me.grbAfinidad.Size = New System.Drawing.Size(290, 74)
        Me.grbAfinidad.TabIndex = 14
        Me.grbAfinidad.TabStop = False
        '
        'pnlFamiliarAfinidad
        '
        Me.pnlFamiliarAfinidad.Controls.Add(Me.cbbGradoAfinidad)
        Me.pnlFamiliarAfinidad.Controls.Add(Me.nupFamiliarAfinidadCantidad)
        Me.pnlFamiliarAfinidad.Controls.Add(Me.Label4)
        Me.pnlFamiliarAfinidad.Controls.Add(Me.Label7)
        Me.pnlFamiliarAfinidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFamiliarAfinidad.Enabled = False
        Me.pnlFamiliarAfinidad.Location = New System.Drawing.Point(3, 33)
        Me.pnlFamiliarAfinidad.Name = "pnlFamiliarAfinidad"
        Me.pnlFamiliarAfinidad.Size = New System.Drawing.Size(284, 38)
        Me.pnlFamiliarAfinidad.TabIndex = 91
        '
        'cbbGradoAfinidad
        '
        Me.cbbGradoAfinidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbGradoAfinidad.FormattingEnabled = True
        Me.cbbGradoAfinidad.Location = New System.Drawing.Point(144, 11)
        Me.cbbGradoAfinidad.Name = "cbbGradoAfinidad"
        Me.cbbGradoAfinidad.Size = New System.Drawing.Size(117, 21)
        Me.cbbGradoAfinidad.TabIndex = 89
        '
        'nupFamiliarAfinidadCantidad
        '
        Me.nupFamiliarAfinidadCantidad.Location = New System.Drawing.Point(49, 12)
        Me.nupFamiliarAfinidadCantidad.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nupFamiliarAfinidadCantidad.Name = "nupFamiliarAfinidadCantidad"
        Me.nupFamiliarAfinidadCantidad.Size = New System.Drawing.Size(40, 20)
        Me.nupFamiliarAfinidadCantidad.TabIndex = 91
        Me.nupFamiliarAfinidadCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Cant. :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(94, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Grado :"
        '
        'chkFamiliarAfinidad
        '
        Me.chkFamiliarAfinidad.AutoSize = True
        Me.chkFamiliarAfinidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkFamiliarAfinidad.Location = New System.Drawing.Point(3, 16)
        Me.chkFamiliarAfinidad.Name = "chkFamiliarAfinidad"
        Me.chkFamiliarAfinidad.Size = New System.Drawing.Size(284, 17)
        Me.chkFamiliarAfinidad.TabIndex = 73
        Me.chkFamiliarAfinidad.Text = "Familiares por afinidad"
        Me.chkFamiliarAfinidad.UseVisualStyleBackColor = True
        '
        'grbConsanguidad
        '
        Me.grbConsanguidad.Controls.Add(Me.pnlFamiliaresConsanguidad)
        Me.grbConsanguidad.Controls.Add(Me.chkFamiliarConsanguidad)
        Me.grbConsanguidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbConsanguidad.Location = New System.Drawing.Point(0, 0)
        Me.grbConsanguidad.Name = "grbConsanguidad"
        Me.grbConsanguidad.Size = New System.Drawing.Size(290, 74)
        Me.grbConsanguidad.TabIndex = 13
        Me.grbConsanguidad.TabStop = False
        '
        'pnlFamiliaresConsanguidad
        '
        Me.pnlFamiliaresConsanguidad.Controls.Add(Me.Label5)
        Me.pnlFamiliaresConsanguidad.Controls.Add(Me.Label6)
        Me.pnlFamiliaresConsanguidad.Controls.Add(Me.cbbGradoConsanguidad)
        Me.pnlFamiliaresConsanguidad.Controls.Add(Me.nupFamiliarConsanguidadCantidad)
        Me.pnlFamiliaresConsanguidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFamiliaresConsanguidad.Enabled = False
        Me.pnlFamiliaresConsanguidad.Location = New System.Drawing.Point(3, 33)
        Me.pnlFamiliaresConsanguidad.Name = "pnlFamiliaresConsanguidad"
        Me.pnlFamiliaresConsanguidad.Size = New System.Drawing.Size(284, 38)
        Me.pnlFamiliaresConsanguidad.TabIndex = 91
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Cant. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Grado :"
        '
        'cbbGradoConsanguidad
        '
        Me.cbbGradoConsanguidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbGradoConsanguidad.FormattingEnabled = True
        Me.cbbGradoConsanguidad.Location = New System.Drawing.Point(144, 12)
        Me.cbbGradoConsanguidad.Name = "cbbGradoConsanguidad"
        Me.cbbGradoConsanguidad.Size = New System.Drawing.Size(117, 21)
        Me.cbbGradoConsanguidad.TabIndex = 88
        '
        'nupFamiliarConsanguidadCantidad
        '
        Me.nupFamiliarConsanguidadCantidad.Location = New System.Drawing.Point(48, 12)
        Me.nupFamiliarConsanguidadCantidad.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nupFamiliarConsanguidadCantidad.Name = "nupFamiliarConsanguidadCantidad"
        Me.nupFamiliarConsanguidadCantidad.Size = New System.Drawing.Size(40, 20)
        Me.nupFamiliarConsanguidadCantidad.TabIndex = 90
        Me.nupFamiliarConsanguidadCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkFamiliarConsanguidad
        '
        Me.chkFamiliarConsanguidad.AutoSize = True
        Me.chkFamiliarConsanguidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkFamiliarConsanguidad.Location = New System.Drawing.Point(3, 16)
        Me.chkFamiliarConsanguidad.Name = "chkFamiliarConsanguidad"
        Me.chkFamiliarConsanguidad.Size = New System.Drawing.Size(284, 17)
        Me.chkFamiliarConsanguidad.TabIndex = 73
        Me.chkFamiliarConsanguidad.Text = "Familiares por consanguinidad"
        Me.chkFamiliarConsanguidad.UseVisualStyleBackColor = True
        '
        'pnlLimite
        '
        Me.pnlLimite.Controls.Add(Me.chkHabilitarlimite)
        Me.pnlLimite.Controls.Add(Me.nudLimiteVisitantes)
        Me.pnlLimite.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLimite.Location = New System.Drawing.Point(3, 16)
        Me.pnlLimite.Name = "pnlLimite"
        Me.pnlLimite.Size = New System.Drawing.Size(290, 27)
        Me.pnlLimite.TabIndex = 92
        '
        'chkHabilitarlimite
        '
        Me.chkHabilitarlimite.AutoSize = True
        Me.chkHabilitarlimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHabilitarlimite.Location = New System.Drawing.Point(6, 4)
        Me.chkHabilitarlimite.Name = "chkHabilitarlimite"
        Me.chkHabilitarlimite.Size = New System.Drawing.Size(205, 17)
        Me.chkHabilitarlimite.TabIndex = 87
        Me.chkHabilitarlimite.Text = "Habilitar limite de visitantes por interno"
        Me.chkHabilitarlimite.UseVisualStyleBackColor = True
        '
        'nudLimiteVisitantes
        '
        Me.nudLimiteVisitantes.Location = New System.Drawing.Point(225, 3)
        Me.nudLimiteVisitantes.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudLimiteVisitantes.Name = "nudLimiteVisitantes"
        Me.nudLimiteVisitantes.Size = New System.Drawing.Size(40, 20)
        Me.nudLimiteVisitantes.TabIndex = 86
        '
        'grbOpciones
        '
        Me.grbOpciones.Controls.Add(Me.chkRegistradoPreviamente)
        Me.grbOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbOpciones.Location = New System.Drawing.Point(0, 0)
        Me.grbOpciones.Name = "grbOpciones"
        Me.grbOpciones.Size = New System.Drawing.Size(296, 32)
        Me.grbOpciones.TabIndex = 11
        Me.grbOpciones.TabStop = False
        '
        'chkRegistradoPreviamente
        '
        Me.chkRegistradoPreviamente.AutoSize = True
        Me.chkRegistradoPreviamente.Checked = True
        Me.chkRegistradoPreviamente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRegistradoPreviamente.Location = New System.Drawing.Point(9, 11)
        Me.chkRegistradoPreviamente.Name = "chkRegistradoPreviamente"
        Me.chkRegistradoPreviamente.Size = New System.Drawing.Size(243, 17)
        Me.chkRegistradoPreviamente.TabIndex = 86
        Me.chkRegistradoPreviamente.Text = "El visitante debe estar previamente autorizado"
        Me.chkRegistradoPreviamente.UseVisualStyleBackColor = True
        '
        'uscProgramacionOrdinario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grbUser)
        Me.Name = "uscProgramacionOrdinario"
        Me.Size = New System.Drawing.Size(435, 452)
        Me.grbUser.ResumeLayout(False)
        Me.pnlUsc.ResumeLayout(False)
        Me.grbDuracion.ResumeLayout(False)
        Me.grbDuracion.PerformLayout()
        Me.pnlHoraFin.ResumeLayout(False)
        Me.pnlHoraFin.PerformLayout()
        CType(Me.nudFinMinuto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFinHora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHoraInicio.ResumeLayout(False)
        Me.pnlHoraInicio.PerformLayout()
        CType(Me.nudInicioMinuto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInicioHora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConfigurarParentesco.ResumeLayout(False)
        Me.grbParentesco.ResumeLayout(False)
        Me.pnlIncluye.ResumeLayout(False)
        Me.pnlAbogado.ResumeLayout(False)
        Me.pnlAbogado.PerformLayout()
        Me.pnlAmigos.ResumeLayout(False)
        Me.pnlAmigos.PerformLayout()
        Me.pnlConyugue.ResumeLayout(False)
        Me.pnlConyugue.PerformLayout()
        Me.grbEdad.ResumeLayout(False)
        Me.grbEdad.PerformLayout()
        Me.pnlEdad.ResumeLayout(False)
        Me.pnlEdad.PerformLayout()
        Me.pnlParentesco.ResumeLayout(False)
        Me.grbAfinidad.ResumeLayout(False)
        Me.grbAfinidad.PerformLayout()
        Me.pnlFamiliarAfinidad.ResumeLayout(False)
        Me.pnlFamiliarAfinidad.PerformLayout()
        CType(Me.nupFamiliarAfinidadCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbConsanguidad.ResumeLayout(False)
        Me.grbConsanguidad.PerformLayout()
        Me.pnlFamiliaresConsanguidad.ResumeLayout(False)
        Me.pnlFamiliaresConsanguidad.PerformLayout()
        CType(Me.nupFamiliarConsanguidadCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLimite.ResumeLayout(False)
        Me.pnlLimite.PerformLayout()
        CType(Me.nudLimiteVisitantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbOpciones.ResumeLayout(False)
        Me.grbOpciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbUser As System.Windows.Forms.GroupBox
    Friend WithEvents pnlUsc As System.Windows.Forms.Panel
    Friend WithEvents chkRegistradoPreviamente As System.Windows.Forms.CheckBox
    Friend WithEvents grbParentesco As System.Windows.Forms.GroupBox
    Friend WithEvents pnlLimite As System.Windows.Forms.Panel
    Friend WithEvents chkHabilitarlimite As System.Windows.Forms.CheckBox
    Friend WithEvents nudLimiteVisitantes As System.Windows.Forms.NumericUpDown
    Friend WithEvents grbDuracion As System.Windows.Forms.GroupBox
    Friend WithEvents txtDuracion As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents rdbDefinirHora As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTodoelDia As System.Windows.Forms.RadioButton
    Friend WithEvents pnlHoraFin As System.Windows.Forms.Panel
    Friend WithEvents nudFinMinuto As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFinHora As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnlHoraInicio As System.Windows.Forms.Panel
    Friend WithEvents nudInicioMinuto As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudInicioHora As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents pnlConfigurarParentesco As System.Windows.Forms.Panel
    Friend WithEvents grbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents pnlParentesco As System.Windows.Forms.Panel
    Friend WithEvents chkIncluyeAbogado As System.Windows.Forms.CheckBox
    Friend WithEvents chkIncluyeConyugue As System.Windows.Forms.CheckBox
    Friend WithEvents chkIncluyeAmigos As System.Windows.Forms.CheckBox
    Friend WithEvents grbAfinidad As System.Windows.Forms.GroupBox
    Friend WithEvents pnlFamiliarAfinidad As System.Windows.Forms.Panel
    Friend WithEvents cbbGradoAfinidad As Legolas.APPUIComponents.MyComboBox
    Friend WithEvents nupFamiliarAfinidadCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkFamiliarAfinidad As System.Windows.Forms.CheckBox
    Friend WithEvents grbConsanguidad As System.Windows.Forms.GroupBox
    Friend WithEvents pnlFamiliaresConsanguidad As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbbGradoConsanguidad As Legolas.APPUIComponents.MyComboBox
    Friend WithEvents nupFamiliarConsanguidadCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkFamiliarConsanguidad As System.Windows.Forms.CheckBox
    Friend WithEvents pnlAbogado As System.Windows.Forms.Panel
    Friend WithEvents pnlAmigos As System.Windows.Forms.Panel
    Friend WithEvents pnlConyugue As System.Windows.Forms.Panel
    Friend WithEvents pnlIncluye As System.Windows.Forms.Panel
    Friend WithEvents grbEdad As System.Windows.Forms.GroupBox
    Friend WithEvents pnlEdad As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbbEdadIni As Legolas.APPUIComponents.MyComboBox
    Friend WithEvents cbbEdadFin As Legolas.APPUIComponents.MyComboBox
    Friend WithEvents chkHabRangoEdades As System.Windows.Forms.CheckBox

End Class
