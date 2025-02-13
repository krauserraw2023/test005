<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscFrecuencia
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
        Me.rdbDiariamente = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rdbMensualmente = New System.Windows.Forms.RadioButton()
        Me.rdbSemanalmente = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pnlMensualmente = New System.Windows.Forms.Panel()
        Me.cbbAnio = New Legolas.APPUIComponents.uscComboAnio()
        Me.btnMeses = New Legolas.APPUIComponents.myButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rdbDias = New System.Windows.Forms.RadioButton()
        Me.rdbEl = New System.Windows.Forms.RadioButton()
        Me.txtMes = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.pnlDias = New System.Windows.Forms.Panel()
        Me.btnDias = New Legolas.APPUIComponents.myButton()
        Me.txtDias = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.pnlElDia = New System.Windows.Forms.Panel()
        Me.btnDiaSemana = New Legolas.APPUIComponents.myButton()
        Me.txtDiaSemana = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.btnEl = New Legolas.APPUIComponents.myButton()
        Me.txtEl = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.pnlDiariamente = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nupRepetirDia = New System.Windows.Forms.NumericUpDown()
        Me.pnlSemanalmente = New System.Windows.Forms.Panel()
        Me.chkDomingo = New Legolas.APPUIComponents.myCheckBox(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkMartes = New Legolas.APPUIComponents.myCheckBox(Me.components)
        Me.chkSabado = New Legolas.APPUIComponents.myCheckBox(Me.components)
        Me.chkMiercoles = New Legolas.APPUIComponents.myCheckBox(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkLunes = New Legolas.APPUIComponents.myCheckBox(Me.components)
        Me.chkViernes = New Legolas.APPUIComponents.myCheckBox(Me.components)
        Me.chkJueves = New Legolas.APPUIComponents.myCheckBox(Me.components)
        Me.nupRepetirSemana = New System.Windows.Forms.NumericUpDown()
        Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkIndeterminado = New Legolas.APPUIComponents.myCheckBox(Me.components)
        Me.pnlFecha = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        Me.pnlMensualmente.SuspendLayout()
        Me.pnlDias.SuspendLayout()
        Me.pnlElDia.SuspendLayout()
        Me.pnlDiariamente.SuspendLayout()
        CType(Me.nupRepetirDia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSemanalmente.SuspendLayout()
        CType(Me.nupRepetirSemana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbDiariamente
        '
        Me.rdbDiariamente.AutoSize = True
        Me.rdbDiariamente.Location = New System.Drawing.Point(14, 22)
        Me.rdbDiariamente.Name = "rdbDiariamente"
        Me.rdbDiariamente.Size = New System.Drawing.Size(81, 17)
        Me.rdbDiariamente.TabIndex = 78
        Me.rdbDiariamente.Text = "Diariamente"
        Me.rdbDiariamente.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Fec. Inicio :"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(118, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(3, 160)
        Me.Label8.TabIndex = 74
        '
        'rdbMensualmente
        '
        Me.rdbMensualmente.AutoSize = True
        Me.rdbMensualmente.Location = New System.Drawing.Point(14, 68)
        Me.rdbMensualmente.Name = "rdbMensualmente"
        Me.rdbMensualmente.Size = New System.Drawing.Size(94, 17)
        Me.rdbMensualmente.TabIndex = 72
        Me.rdbMensualmente.Text = "Mensualmente"
        Me.rdbMensualmente.UseVisualStyleBackColor = True
        '
        'rdbSemanalmente
        '
        Me.rdbSemanalmente.AutoSize = True
        Me.rdbSemanalmente.Checked = True
        Me.rdbSemanalmente.Location = New System.Drawing.Point(14, 45)
        Me.rdbSemanalmente.Name = "rdbSemanalmente"
        Me.rdbSemanalmente.Size = New System.Drawing.Size(95, 17)
        Me.rdbSemanalmente.TabIndex = 71
        Me.rdbSemanalmente.TabStop = True
        Me.rdbSemanalmente.Text = "Semanalmente"
        Me.rdbSemanalmente.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pnlMensualmente)
        Me.GroupBox2.Controls.Add(Me.pnlDiariamente)
        Me.GroupBox2.Controls.Add(Me.pnlSemanalmente)
        Me.GroupBox2.Location = New System.Drawing.Point(127, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 113)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        '
        'pnlMensualmente
        '
        Me.pnlMensualmente.Controls.Add(Me.cbbAnio)
        Me.pnlMensualmente.Controls.Add(Me.btnMeses)
        Me.pnlMensualmente.Controls.Add(Me.Label11)
        Me.pnlMensualmente.Controls.Add(Me.rdbDias)
        Me.pnlMensualmente.Controls.Add(Me.rdbEl)
        Me.pnlMensualmente.Controls.Add(Me.txtMes)
        Me.pnlMensualmente.Controls.Add(Me.pnlDias)
        Me.pnlMensualmente.Controls.Add(Me.pnlElDia)
        Me.pnlMensualmente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMensualmente.Location = New System.Drawing.Point(3, 16)
        Me.pnlMensualmente.Name = "pnlMensualmente"
        Me.pnlMensualmente.Size = New System.Drawing.Size(308, 94)
        Me.pnlMensualmente.TabIndex = 81
        '
        'cbbAnio
        '
        Me.cbbAnio._Todos = False
        Me.cbbAnio.AnioFin = 2010
        Me.cbbAnio.AnioInicio = 1900
        Me.cbbAnio.Location = New System.Drawing.Point(86, 6)
        Me.cbbAnio.Name = "cbbAnio"
        Me.cbbAnio.Size = New System.Drawing.Size(83, 21)
        Me.cbbAnio.TabIndex = 93
        Me.cbbAnio.Value = -1
        '
        'btnMeses
        '
        Me.btnMeses.Image = Global.APPControls.My.Resources.Resources.flechacombo
        Me.btnMeses.Location = New System.Drawing.Point(262, 7)
        Me.btnMeses.Name = "btnMeses"
        Me.btnMeses.Size = New System.Drawing.Size(21, 21)
        Me.btnMeses.TabIndex = 84
        Me.btnMeses.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Año/Meses :"
        '
        'rdbDias
        '
        Me.rdbDias.AutoSize = True
        Me.rdbDias.Checked = True
        Me.rdbDias.Location = New System.Drawing.Point(14, 36)
        Me.rdbDias.Name = "rdbDias"
        Me.rdbDias.Size = New System.Drawing.Size(54, 17)
        Me.rdbDias.TabIndex = 67
        Me.rdbDias.TabStop = True
        Me.rdbDias.Text = "Días :"
        Me.rdbDias.UseVisualStyleBackColor = True
        '
        'rdbEl
        '
        Me.rdbEl.AutoSize = True
        Me.rdbEl.Enabled = False
        Me.rdbEl.Location = New System.Drawing.Point(14, 62)
        Me.rdbEl.Name = "rdbEl"
        Me.rdbEl.Size = New System.Drawing.Size(40, 17)
        Me.rdbEl.TabIndex = 68
        Me.rdbEl.Text = "El :"
        Me.rdbEl.UseVisualStyleBackColor = True
        '
        'txtMes
        '
        Me.txtMes._BloquearPaste = False
        Me.txtMes._SeleccionarTodo = False
        Me.txtMes.Location = New System.Drawing.Point(172, 7)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.ReadOnly = True
        Me.txtMes.Size = New System.Drawing.Size(111, 20)
        Me.txtMes.TabIndex = 82
        Me.txtMes.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtMes.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'pnlDias
        '
        Me.pnlDias.BackColor = System.Drawing.SystemColors.Control
        Me.pnlDias.Controls.Add(Me.btnDias)
        Me.pnlDias.Controls.Add(Me.txtDias)
        Me.pnlDias.Location = New System.Drawing.Point(86, 34)
        Me.pnlDias.Name = "pnlDias"
        Me.pnlDias.Size = New System.Drawing.Size(200, 22)
        Me.pnlDias.TabIndex = 91
        '
        'btnDias
        '
        Me.btnDias.Image = Global.APPControls.My.Resources.Resources.flechacombo
        Me.btnDias.Location = New System.Drawing.Point(176, 0)
        Me.btnDias.Name = "btnDias"
        Me.btnDias.Size = New System.Drawing.Size(21, 21)
        Me.btnDias.TabIndex = 86
        Me.btnDias.UseVisualStyleBackColor = True
        '
        'txtDias
        '
        Me.txtDias._BloquearPaste = False
        Me.txtDias._SeleccionarTodo = False
        Me.txtDias.Location = New System.Drawing.Point(0, 0)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.ReadOnly = True
        Me.txtDias.Size = New System.Drawing.Size(197, 20)
        Me.txtDias.TabIndex = 85
        Me.txtDias.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtDias.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'pnlElDia
        '
        Me.pnlElDia.BackColor = System.Drawing.SystemColors.Control
        Me.pnlElDia.Controls.Add(Me.btnDiaSemana)
        Me.pnlElDia.Controls.Add(Me.txtDiaSemana)
        Me.pnlElDia.Controls.Add(Me.btnEl)
        Me.pnlElDia.Controls.Add(Me.txtEl)
        Me.pnlElDia.Location = New System.Drawing.Point(86, 62)
        Me.pnlElDia.Name = "pnlElDia"
        Me.pnlElDia.Size = New System.Drawing.Size(200, 22)
        Me.pnlElDia.TabIndex = 92
        '
        'btnDiaSemana
        '
        Me.btnDiaSemana.Image = Global.APPControls.My.Resources.Resources.flechacombo
        Me.btnDiaSemana.Location = New System.Drawing.Point(176, 0)
        Me.btnDiaSemana.Name = "btnDiaSemana"
        Me.btnDiaSemana.Size = New System.Drawing.Size(21, 21)
        Me.btnDiaSemana.TabIndex = 90
        Me.btnDiaSemana.UseVisualStyleBackColor = True
        '
        'txtDiaSemana
        '
        Me.txtDiaSemana._BloquearPaste = False
        Me.txtDiaSemana._SeleccionarTodo = False
        Me.txtDiaSemana.Location = New System.Drawing.Point(86, 0)
        Me.txtDiaSemana.Name = "txtDiaSemana"
        Me.txtDiaSemana.ReadOnly = True
        Me.txtDiaSemana.Size = New System.Drawing.Size(111, 20)
        Me.txtDiaSemana.TabIndex = 89
        Me.txtDiaSemana.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtDiaSemana.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'btnEl
        '
        Me.btnEl.Image = Global.APPControls.My.Resources.Resources.flechacombo
        Me.btnEl.Location = New System.Drawing.Point(62, 0)
        Me.btnEl.Name = "btnEl"
        Me.btnEl.Size = New System.Drawing.Size(21, 21)
        Me.btnEl.TabIndex = 88
        Me.btnEl.UseVisualStyleBackColor = True
        '
        'txtEl
        '
        Me.txtEl._BloquearPaste = False
        Me.txtEl._SeleccionarTodo = False
        Me.txtEl.Location = New System.Drawing.Point(0, 0)
        Me.txtEl.Name = "txtEl"
        Me.txtEl.ReadOnly = True
        Me.txtEl.Size = New System.Drawing.Size(83, 20)
        Me.txtEl.TabIndex = 87
        Me.txtEl.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtEl.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'pnlDiariamente
        '
        Me.pnlDiariamente.Controls.Add(Me.Label1)
        Me.pnlDiariamente.Controls.Add(Me.Label2)
        Me.pnlDiariamente.Controls.Add(Me.nupRepetirDia)
        Me.pnlDiariamente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDiariamente.Location = New System.Drawing.Point(3, 16)
        Me.pnlDiariamente.Name = "pnlDiariamente"
        Me.pnlDiariamente.Size = New System.Drawing.Size(308, 94)
        Me.pnlDiariamente.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "días"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Repetir cada :"
        '
        'nupRepetirDia
        '
        Me.nupRepetirDia.Location = New System.Drawing.Point(102, 14)
        Me.nupRepetirDia.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nupRepetirDia.Name = "nupRepetirDia"
        Me.nupRepetirDia.Size = New System.Drawing.Size(39, 20)
        Me.nupRepetirDia.TabIndex = 87
        Me.nupRepetirDia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pnlSemanalmente
        '
        Me.pnlSemanalmente.Controls.Add(Me.chkDomingo)
        Me.pnlSemanalmente.Controls.Add(Me.Label5)
        Me.pnlSemanalmente.Controls.Add(Me.chkMartes)
        Me.pnlSemanalmente.Controls.Add(Me.chkSabado)
        Me.pnlSemanalmente.Controls.Add(Me.chkMiercoles)
        Me.pnlSemanalmente.Controls.Add(Me.Label6)
        Me.pnlSemanalmente.Controls.Add(Me.chkLunes)
        Me.pnlSemanalmente.Controls.Add(Me.chkViernes)
        Me.pnlSemanalmente.Controls.Add(Me.chkJueves)
        Me.pnlSemanalmente.Controls.Add(Me.nupRepetirSemana)
        Me.pnlSemanalmente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSemanalmente.Location = New System.Drawing.Point(3, 16)
        Me.pnlSemanalmente.Name = "pnlSemanalmente"
        Me.pnlSemanalmente.Size = New System.Drawing.Size(308, 94)
        Me.pnlSemanalmente.TabIndex = 80
        '
        'chkDomingo
        '
        Me.chkDomingo.AutoSize = True
        Me.chkDomingo.Location = New System.Drawing.Point(154, 67)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(68, 17)
        Me.chkDomingo.TabIndex = 85
        Me.chkDomingo.Text = "Domingo"
        Me.chkDomingo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Repetir cada :"
        '
        'chkMartes
        '
        Me.chkMartes.AutoSize = True
        Me.chkMartes.Location = New System.Drawing.Point(82, 40)
        Me.chkMartes.Name = "chkMartes"
        Me.chkMartes.Size = New System.Drawing.Size(58, 17)
        Me.chkMartes.TabIndex = 80
        Me.chkMartes.Text = "Martes"
        Me.chkMartes.UseVisualStyleBackColor = True
        '
        'chkSabado
        '
        Me.chkSabado.AutoSize = True
        Me.chkSabado.Location = New System.Drawing.Point(82, 67)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(63, 17)
        Me.chkSabado.TabIndex = 84
        Me.chkSabado.Text = "Sabado"
        Me.chkSabado.UseVisualStyleBackColor = True
        '
        'chkMiercoles
        '
        Me.chkMiercoles.AutoSize = True
        Me.chkMiercoles.Location = New System.Drawing.Point(154, 40)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(71, 17)
        Me.chkMiercoles.TabIndex = 81
        Me.chkMiercoles.Text = "Miercoles"
        Me.chkMiercoles.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(150, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "semanas en :"
        '
        'chkLunes
        '
        Me.chkLunes.AutoSize = True
        Me.chkLunes.Location = New System.Drawing.Point(5, 40)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(55, 17)
        Me.chkLunes.TabIndex = 79
        Me.chkLunes.Text = "Lunes"
        Me.chkLunes.UseVisualStyleBackColor = True
        '
        'chkViernes
        '
        Me.chkViernes.AutoSize = True
        Me.chkViernes.Location = New System.Drawing.Point(5, 67)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(61, 17)
        Me.chkViernes.TabIndex = 83
        Me.chkViernes.Text = "Viernes"
        Me.chkViernes.UseVisualStyleBackColor = True
        '
        'chkJueves
        '
        Me.chkJueves.AutoSize = True
        Me.chkJueves.Location = New System.Drawing.Point(234, 40)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(60, 17)
        Me.chkJueves.TabIndex = 82
        Me.chkJueves.Text = "Jueves"
        Me.chkJueves.UseVisualStyleBackColor = True
        '
        'nupRepetirSemana
        '
        Me.nupRepetirSemana.Location = New System.Drawing.Point(101, 10)
        Me.nupRepetirSemana.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nupRepetirSemana.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupRepetirSemana.Name = "nupRepetirSemana"
        Me.nupRepetirSemana.Size = New System.Drawing.Size(39, 20)
        Me.nupRepetirSemana.TabIndex = 88
        Me.nupRepetirSemana.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(70, 3)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaInicio.TabIndex = 76
        Me.dtpFechaInicio.Value = "/  /"
        Me.dtpFechaInicio.ValueLong = CType(0, Long)
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(224, 3)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaFin.TabIndex = 80
        Me.dtpFechaFin.Value = "/  /"
        Me.dtpFechaFin.ValueLong = CType(0, Long)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Fecha Fin :"
        '
        'chkIndeterminado
        '
        Me.chkIndeterminado.AutoSize = True
        Me.chkIndeterminado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIndeterminado.Location = New System.Drawing.Point(215, 27)
        Me.chkIndeterminado.Name = "chkIndeterminado"
        Me.chkIndeterminado.Size = New System.Drawing.Size(93, 17)
        Me.chkIndeterminado.TabIndex = 81
        Me.chkIndeterminado.Text = "Indeterminado"
        Me.chkIndeterminado.UseVisualStyleBackColor = True
        '
        'pnlFecha
        '
        Me.pnlFecha.Controls.Add(Me.dtpFechaInicio)
        Me.pnlFecha.Controls.Add(Me.dtpFechaFin)
        Me.pnlFecha.Controls.Add(Me.chkIndeterminado)
        Me.pnlFecha.Controls.Add(Me.Label3)
        Me.pnlFecha.Controls.Add(Me.Label9)
        Me.pnlFecha.Location = New System.Drawing.Point(128, 119)
        Me.pnlFecha.Name = "pnlFecha"
        Me.pnlFecha.Size = New System.Drawing.Size(316, 46)
        Me.pnlFecha.TabIndex = 82
        '
        'uscFrecuencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlFecha)
        Me.Controls.Add(Me.rdbDiariamente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rdbMensualmente)
        Me.Controls.Add(Me.rdbSemanalmente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "uscFrecuencia"
        Me.Size = New System.Drawing.Size(444, 174)
        Me.GroupBox2.ResumeLayout(False)
        Me.pnlMensualmente.ResumeLayout(False)
        Me.pnlMensualmente.PerformLayout()
        Me.pnlDias.ResumeLayout(False)
        Me.pnlDias.PerformLayout()
        Me.pnlElDia.ResumeLayout(False)
        Me.pnlElDia.PerformLayout()
        Me.pnlDiariamente.ResumeLayout(False)
        Me.pnlDiariamente.PerformLayout()
        CType(Me.nupRepetirDia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSemanalmente.ResumeLayout(False)
        Me.pnlSemanalmente.PerformLayout()
        CType(Me.nupRepetirSemana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFecha.ResumeLayout(False)
        Me.pnlFecha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbDiariamente As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rdbMensualmente As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSemanalmente As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdbEl As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDias As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkLunes As Legolas.APPUIComponents.myCheckBox
    Friend WithEvents chkMartes As Legolas.APPUIComponents.myCheckBox
    Friend WithEvents chkMiercoles As Legolas.APPUIComponents.myCheckBox
    Friend WithEvents chkJueves As Legolas.APPUIComponents.myCheckBox
    Friend WithEvents chkDomingo As Legolas.APPUIComponents.myCheckBox
    Friend WithEvents chkSabado As Legolas.APPUIComponents.myCheckBox
    Friend WithEvents chkViernes As Legolas.APPUIComponents.myCheckBox
    Friend WithEvents pnlDiariamente As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlSemanalmente As System.Windows.Forms.Panel
    Friend WithEvents pnlMensualmente As System.Windows.Forms.Panel
    Friend WithEvents nupRepetirDia As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupRepetirSemana As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtMes As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents btnMeses As Legolas.APPUIComponents.myButton
    Friend WithEvents btnEl As Legolas.APPUIComponents.myButton
    Friend WithEvents btnDias As Legolas.APPUIComponents.myButton
    Friend WithEvents txtDias As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents txtEl As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents btnDiaSemana As Legolas.APPUIComponents.myButton
    Friend WithEvents txtDiaSemana As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents pnlDias As System.Windows.Forms.Panel
    Friend WithEvents pnlElDia As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkIndeterminado As Legolas.APPUIComponents.myCheckBox
    Friend WithEvents cbbAnio As Legolas.APPUIComponents.uscComboAnio
    Friend WithEvents pnlFecha As System.Windows.Forms.Panel

End Class
