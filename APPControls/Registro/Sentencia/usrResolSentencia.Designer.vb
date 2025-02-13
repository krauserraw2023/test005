Namespace Registro.Sentencia
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class usrResolSentencia
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.pnlObsInimputable = New System.Windows.Forms.Panel()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.pnlInimputables = New System.Windows.Forms.Panel()
            Me.rdbNo = New System.Windows.Forms.RadioButton()
            Me.rdbSi = New System.Windows.Forms.RadioButton()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.chkCadenaPerpetua = New System.Windows.Forms.CheckBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.pnlJornadas = New System.Windows.Forms.Panel()
            Me.ckbExtramuro = New System.Windows.Forms.CheckBox()
            Me.lbletiqueta = New System.Windows.Forms.Label()
            Me.txtCant = New Legolas.APPUIComponents.MyTextBox()
            Me.lblJornadas = New System.Windows.Forms.Label()
            Me.pnlFechaSentencia = New System.Windows.Forms.Panel()
            Me.chkConsentida = New System.Windows.Forms.CheckBox()
            Me.lblConsentida = New System.Windows.Forms.Label()
            Me.pnlCondena = New System.Windows.Forms.Panel()
            Me.lblFecSentencia = New System.Windows.Forms.Label()
            Me.dtpFecSentencia = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.pnlSemicabecera = New System.Windows.Forms.Panel()
            Me.grbAutoridad = New System.Windows.Forms.GroupBox()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.UscComboDistritoJudicial1 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox()
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.grbCabecera = New System.Windows.Forms.GroupBox()
            Me.txtFolio = New Legolas.APPUIComponents.MyTextBox()
            Me.txtLibro = New Legolas.APPUIComponents.MyTextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpFechRecepDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtResolucion = New Legolas.APPUIComponents.MyTextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpFechDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblResolucion = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtNumOficio = New Legolas.APPUIComponents.MyTextBox()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2 = New Legolas.APPUIComponents.MyComboBox()
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb = New Legolas.APPUIComponents.MyComboBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip()
            Me.Panel5.SuspendLayout()
            Me.pnlPie.SuspendLayout()
            Me.pnlObsInimputable.SuspendLayout()
            Me.pnlInimputables.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlJornadas.SuspendLayout()
            Me.pnlFechaSentencia.SuspendLayout()
            Me.pnlSemicabecera.SuspendLayout()
            Me.grbAutoridad.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.grbCabecera.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.pnlPie)
            Me.Panel5.Controls.Add(Me.pnlSemicabecera)
            Me.Panel5.Controls.Add(Me.pnlCabecera)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(0, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(701, 212)
            Me.Panel5.TabIndex = 0
            '
            'pnlPie
            '
            Me.pnlPie.Controls.Add(Me.pnlObsInimputable)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlPie.Location = New System.Drawing.Point(0, 120)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(701, 92)
            Me.pnlPie.TabIndex = 2
            '
            'pnlObsInimputable
            '
            Me.pnlObsInimputable.Controls.Add(Me.txtObservacion)
            Me.pnlObsInimputable.Controls.Add(Me.pnlInimputables)
            Me.pnlObsInimputable.Controls.Add(Me.Label3)
            Me.pnlObsInimputable.Controls.Add(Me.Panel3)
            Me.pnlObsInimputable.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlObsInimputable.Location = New System.Drawing.Point(0, 0)
            Me.pnlObsInimputable.Name = "pnlObsInimputable"
            Me.pnlObsInimputable.Size = New System.Drawing.Size(701, 92)
            Me.pnlObsInimputable.TabIndex = 0
            '
            'txtObservacion
            '
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Location = New System.Drawing.Point(92, 33)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(380, 59)
            Me.txtObservacion.TabIndex = 2
            '
            'pnlInimputables
            '
            Me.pnlInimputables.Controls.Add(Me.rdbNo)
            Me.pnlInimputables.Controls.Add(Me.rdbSi)
            Me.pnlInimputables.Controls.Add(Me.Label2)
            Me.pnlInimputables.Controls.Add(Me.chkCadenaPerpetua)
            Me.pnlInimputables.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlInimputables.Location = New System.Drawing.Point(472, 33)
            Me.pnlInimputables.Name = "pnlInimputables"
            Me.pnlInimputables.Size = New System.Drawing.Size(229, 59)
            Me.pnlInimputables.TabIndex = 3
            '
            'rdbNo
            '
            Me.rdbNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.rdbNo.AutoSize = True
            Me.rdbNo.Checked = True
            Me.rdbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNo.Location = New System.Drawing.Point(165, 33)
            Me.rdbNo.Name = "rdbNo"
            Me.rdbNo.Size = New System.Drawing.Size(37, 16)
            Me.rdbNo.TabIndex = 3
            Me.rdbNo.TabStop = True
            Me.rdbNo.Text = "NO"
            Me.rdbNo.UseVisualStyleBackColor = True
            '
            'rdbSi
            '
            Me.rdbSi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.rdbSi.AutoSize = True
            Me.rdbSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSi.Location = New System.Drawing.Point(116, 33)
            Me.rdbSi.Name = "rdbSi"
            Me.rdbSi.Size = New System.Drawing.Size(32, 16)
            Me.rdbSi.TabIndex = 2
            Me.rdbSi.Text = "SI"
            Me.rdbSi.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(31, 3)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(195, 26)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Inimputable (Con medidas de seguridad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Internación)"
            '
            'chkCadenaPerpetua
            '
            Me.chkCadenaPerpetua.AutoSize = True
            Me.chkCadenaPerpetua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkCadenaPerpetua.Location = New System.Drawing.Point(34, 32)
            Me.chkCadenaPerpetua.Name = "chkCadenaPerpetua"
            Me.chkCadenaPerpetua.Size = New System.Drawing.Size(40, 17)
            Me.chkCadenaPerpetua.TabIndex = 1
            Me.chkCadenaPerpetua.Text = "CP"
            Me.chkCadenaPerpetua.UseVisualStyleBackColor = True
            Me.chkCadenaPerpetua.Visible = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Location = New System.Drawing.Point(0, 33)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(92, 17)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "   Observación :   "
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label3.UseCompatibleTextRendering = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.pnlJornadas)
            Me.Panel3.Controls.Add(Me.pnlFechaSentencia)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(701, 33)
            Me.Panel3.TabIndex = 0
            '
            'pnlJornadas
            '
            Me.pnlJornadas.Controls.Add(Me.ckbExtramuro)
            Me.pnlJornadas.Controls.Add(Me.lbletiqueta)
            Me.pnlJornadas.Controls.Add(Me.txtCant)
            Me.pnlJornadas.Controls.Add(Me.lblJornadas)
            Me.pnlJornadas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlJornadas.Location = New System.Drawing.Point(390, 0)
            Me.pnlJornadas.Name = "pnlJornadas"
            Me.pnlJornadas.Size = New System.Drawing.Size(311, 33)
            Me.pnlJornadas.TabIndex = 1
            Me.pnlJornadas.Visible = False
            '
            'ckbExtramuro
            '
            Me.ckbExtramuro.AutoSize = True
            Me.ckbExtramuro.Dock = System.Windows.Forms.DockStyle.Right
            Me.ckbExtramuro.Location = New System.Drawing.Point(155, 0)
            Me.ckbExtramuro.Name = "ckbExtramuro"
            Me.ckbExtramuro.Size = New System.Drawing.Size(156, 33)
            Me.ckbExtramuro.TabIndex = 3
            Me.ckbExtramuro.Text = "Proceso/Sentencia sin " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "privación de libertad en EP." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            Me.ToolTip1.SetToolTip(Me.ckbExtramuro, "Proceso/Sentencia sin privación de libertad en E.P.")
            Me.ckbExtramuro.UseVisualStyleBackColor = True
            '
            'lbletiqueta
            '
            Me.lbletiqueta.AutoSize = True
            Me.lbletiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbletiqueta.Location = New System.Drawing.Point(3, 5)
            Me.lbletiqueta.Name = "lbletiqueta"
            Me.lbletiqueta.Size = New System.Drawing.Size(121, 26)
            Me.lbletiqueta.TabIndex = 0
            Me.lbletiqueta.Text = "Prestación de Servicios " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             a Comunitarios :"
            Me.lbletiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtCant
            '
            Me.txtCant._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCant._BloquearPaste = False
            Me.txtCant._SeleccionarTodo = False
            Me.txtCant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtCant.Location = New System.Drawing.Point(199, 8)
            Me.txtCant.Name = "txtCant"
            Me.txtCant.Size = New System.Drawing.Size(26, 20)
            Me.txtCant.TabIndex = 1
            Me.txtCant.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtCant.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'lblJornadas
            '
            Me.lblJornadas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblJornadas.AutoSize = True
            Me.lblJornadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblJornadas.Location = New System.Drawing.Point(226, 9)
            Me.lblJornadas.Name = "lblJornadas"
            Me.lblJornadas.Size = New System.Drawing.Size(50, 13)
            Me.lblJornadas.TabIndex = 2
            Me.lblJornadas.Text = "Jornadas"
            '
            'pnlFechaSentencia
            '
            Me.pnlFechaSentencia.AutoScroll = True
            Me.pnlFechaSentencia.Controls.Add(Me.chkConsentida)
            Me.pnlFechaSentencia.Controls.Add(Me.lblConsentida)
            Me.pnlFechaSentencia.Controls.Add(Me.pnlCondena)
            Me.pnlFechaSentencia.Controls.Add(Me.lblFecSentencia)
            Me.pnlFechaSentencia.Controls.Add(Me.dtpFecSentencia)
            Me.pnlFechaSentencia.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlFechaSentencia.Location = New System.Drawing.Point(0, 0)
            Me.pnlFechaSentencia.Name = "pnlFechaSentencia"
            Me.pnlFechaSentencia.Size = New System.Drawing.Size(390, 33)
            Me.pnlFechaSentencia.TabIndex = 0
            '
            'chkConsentida
            '
            Me.chkConsentida.AutoSize = True
            Me.chkConsentida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkConsentida.Location = New System.Drawing.Point(97, 7)
            Me.chkConsentida.Name = "chkConsentida"
            Me.chkConsentida.Size = New System.Drawing.Size(79, 17)
            Me.chkConsentida.TabIndex = 2
            Me.chkConsentida.Text = "Consentida"
            Me.chkConsentida.UseVisualStyleBackColor = True
            '
            'lblConsentida
            '
            Me.lblConsentida.AutoSize = True
            Me.lblConsentida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConsentida.ForeColor = System.Drawing.Color.Black
            Me.lblConsentida.Location = New System.Drawing.Point(1, 6)
            Me.lblConsentida.Name = "lblConsentida"
            Me.lblConsentida.Size = New System.Drawing.Size(72, 17)
            Me.lblConsentida.TabIndex = 0
            Me.lblConsentida.Text = "   Sentencia :"
            Me.lblConsentida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblConsentida.UseCompatibleTextRendering = True
            '
            'pnlCondena
            '
            Me.pnlCondena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCondena.Location = New System.Drawing.Point(92, 4)
            Me.pnlCondena.Name = "pnlCondena"
            Me.pnlCondena.Size = New System.Drawing.Size(120, 23)
            Me.pnlCondena.TabIndex = 1
            '
            'lblFecSentencia
            '
            Me.lblFecSentencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblFecSentencia.AutoSize = True
            Me.lblFecSentencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecSentencia.Location = New System.Drawing.Point(218, 9)
            Me.lblFecSentencia.Name = "lblFecSentencia"
            Me.lblFecSentencia.Size = New System.Drawing.Size(73, 13)
            Me.lblFecSentencia.TabIndex = 3
            Me.lblFecSentencia.Text = "F. Sentencia :"
            '
            'dtpFecSentencia
            '
            Me.dtpFecSentencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpFecSentencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecSentencia.Location = New System.Drawing.Point(293, 5)
            Me.dtpFecSentencia.Name = "dtpFecSentencia"
            Me.dtpFecSentencia.Size = New System.Drawing.Size(84, 21)
            Me.dtpFecSentencia.TabIndex = 4
            Me.dtpFecSentencia.Value = "/  /"
            Me.dtpFecSentencia.ValueLong = CType(0, Long)
            '
            'pnlSemicabecera
            '
            Me.pnlSemicabecera.Controls.Add(Me.grbAutoridad)
            Me.pnlSemicabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSemicabecera.Location = New System.Drawing.Point(0, 54)
            Me.pnlSemicabecera.Name = "pnlSemicabecera"
            Me.pnlSemicabecera.Size = New System.Drawing.Size(701, 66)
            Me.pnlSemicabecera.TabIndex = 1
            '
            'grbAutoridad
            '
            Me.grbAutoridad.Controls.Add(Me.PnlAutoridadJudicial)
            Me.grbAutoridad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAutoridad.Location = New System.Drawing.Point(0, 0)
            Me.grbAutoridad.Name = "grbAutoridad"
            Me.grbAutoridad.Size = New System.Drawing.Size(701, 66)
            Me.grbAutoridad.TabIndex = 0
            Me.grbAutoridad.TabStop = False
            Me.grbAutoridad.Text = "Autoridad"
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboDistritoJudicial1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboSala1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtJuez)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblDistrito)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label11)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(3, 16)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(695, 48)
            Me.PnlAutoridadJudicial.TabIndex = 0
            '
            'UscComboDistritoJudicial1
            '
            Me.UscComboDistritoJudicial1._DropDownWidthAuto = False
            Me.UscComboDistritoJudicial1._selectedValue = 0
            Me.UscComboDistritoJudicial1._Todos = False
            Me.UscComboDistritoJudicial1._TodosMensaje = ""
            Me.UscComboDistritoJudicial1._visibleBuscar = True
            Me.UscComboDistritoJudicial1.Location = New System.Drawing.Point(90, 2)
            Me.UscComboDistritoJudicial1.Name = "UscComboDistritoJudicial1"
            Me.UscComboDistritoJudicial1.Size = New System.Drawing.Size(282, 21)
            Me.UscComboDistritoJudicial1.TabIndex = 1
            '
            'UscComboSala1
            '
            Me.UscComboSala1._DistritoJudicialID = -1
            Me.UscComboSala1._DropDownWidthAuto = False
            Me.UscComboSala1._SalaJuzgadoID = 0
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala1._Todos = False
            Me.UscComboSala1._TodosMensaje = ""
            Me.UscComboSala1._visibleBuscar = True
            Me.UscComboSala1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UscComboSala1.Location = New System.Drawing.Point(459, 1)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(231, 21)
            Me.UscComboSala1.TabIndex = 3
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(459, 24)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(231, 20)
            Me.txtSecretario.TabIndex = 7
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtJuez.Location = New System.Drawing.Point(90, 24)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(282, 20)
            Me.txtJuez.TabIndex = 5
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(4, 7)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 0
            Me.lblDistrito.Text = "Distrito Judicial :"
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(4, 27)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(35, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Juez :"
            '
            'lblSala
            '
            Me.lblSala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(386, 7)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 2
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'Label11
            '
            Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(386, 27)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 13)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Secretario :"
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.grbCabecera)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(701, 54)
            Me.pnlCabecera.TabIndex = 0
            '
            'grbCabecera
            '
            Me.grbCabecera.Controls.Add(Me.txtFolio)
            Me.grbCabecera.Controls.Add(Me.txtLibro)
            Me.grbCabecera.Controls.Add(Me.Label8)
            Me.grbCabecera.Controls.Add(Me.Label7)
            Me.grbCabecera.Controls.Add(Me.dtpFechRecepDoc)
            Me.grbCabecera.Controls.Add(Me.txtResolucion)
            Me.grbCabecera.Controls.Add(Me.Label12)
            Me.grbCabecera.Controls.Add(Me.dtpFechDoc)
            Me.grbCabecera.Controls.Add(Me.lblResolucion)
            Me.grbCabecera.Controls.Add(Me.Label9)
            Me.grbCabecera.Controls.Add(Me.txtNumOficio)
            Me.grbCabecera.Controls.Add(Me.Label30)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbCabecera.Location = New System.Drawing.Point(0, 0)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(701, 54)
            Me.grbCabecera.TabIndex = 0
            Me.grbCabecera.TabStop = False
            '
            'txtFolio
            '
            Me.txtFolio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFolio._BloquearPaste = False
            Me.txtFolio._SeleccionarTodo = False
            Me.txtFolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtFolio.Location = New System.Drawing.Point(637, 31)
            Me.txtFolio.MaxLength = 4
            Me.txtFolio.Name = "txtFolio"
            Me.txtFolio.Size = New System.Drawing.Size(61, 20)
            Me.txtFolio.TabIndex = 11
            Me.txtFolio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFolio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtLibro
            '
            Me.txtLibro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtLibro._BloquearPaste = False
            Me.txtLibro._SeleccionarTodo = False
            Me.txtLibro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtLibro.Location = New System.Drawing.Point(637, 8)
            Me.txtLibro.MaxLength = 20
            Me.txtLibro.Name = "txtLibro"
            Me.txtLibro.Size = New System.Drawing.Size(61, 20)
            Me.txtLibro.TabIndex = 9
            Me.txtLibro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtLibro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label8
            '
            Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(595, 34)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(32, 13)
            Me.Label8.TabIndex = 10
            Me.Label8.Text = "Folio:"
            '
            'Label7
            '
            Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(595, 11)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(33, 13)
            Me.Label7.TabIndex = 8
            Me.Label7.Text = "Libro:"
            '
            'dtpFechRecepDoc
            '
            Me.dtpFechRecepDoc.Location = New System.Drawing.Point(291, 32)
            Me.dtpFechRecepDoc.Name = "dtpFechRecepDoc"
            Me.dtpFechRecepDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechRecepDoc.TabIndex = 5
            Me.dtpFechRecepDoc.Value = "/  /"
            Me.dtpFechRecepDoc.ValueLong = CType(0, Long)
            '
            'txtResolucion
            '
            Me.txtResolucion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtResolucion._BloquearPaste = False
            Me.txtResolucion._SeleccionarTodo = False
            Me.txtResolucion.Location = New System.Drawing.Point(462, 8)
            Me.txtResolucion.MaxLength = 120
            Me.txtResolucion.Name = "txtResolucion"
            Me.txtResolucion.Size = New System.Drawing.Size(189, 20)
            Me.txtResolucion.TabIndex = 7
            Me.txtResolucion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtResolucion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.ToolTip1.SetToolTip(Me.txtResolucion, "N° de Resolución Inimputable")
            Me.txtResolucion.Visible = False
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(210, 35)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(77, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "F. Recepción :"
            '
            'dtpFechDoc
            '
            Me.dtpFechDoc.Location = New System.Drawing.Point(93, 32)
            Me.dtpFechDoc.Name = "dtpFechDoc"
            Me.dtpFechDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechDoc.TabIndex = 3
            Me.dtpFechDoc.Value = "/  /"
            Me.dtpFechDoc.ValueLong = CType(0, Long)
            '
            'lblResolucion
            '
            Me.lblResolucion.AutoSize = True
            Me.lblResolucion.Location = New System.Drawing.Point(388, 10)
            Me.lblResolucion.Name = "lblResolucion"
            Me.lblResolucion.Size = New System.Drawing.Size(63, 26)
            Me.lblResolucion.TabIndex = 6
            Me.lblResolucion.Text = "N° de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Resolución:"
            Me.lblResolucion.Visible = False
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(12, 36)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(80, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "F. Documento :"
            '
            'txtNumOficio
            '
            Me.txtNumOficio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumOficio._BloquearPaste = False
            Me.txtNumOficio._SeleccionarTodo = False
            Me.txtNumOficio.Location = New System.Drawing.Point(93, 8)
            Me.txtNumOficio.MaxLength = 120
            Me.txtNumOficio.Name = "txtNumOficio"
            Me.txtNumOficio.Size = New System.Drawing.Size(282, 20)
            Me.txtNumOficio.TabIndex = 1
            Me.txtNumOficio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumOficio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(12, 12)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(83, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N° Documento :"
            '
            'object_54cb3d30_851e_467f_b037_d3de6ef8c4c2
            '
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.DropDownWidth = 325
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.FormattingEnabled = True
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Location = New System.Drawing.Point(0, 0)
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Name = "object_54cb3d30_851e_467f_b037_d3de6ef8c4c2"
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Size = New System.Drawing.Size(388, 21)
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.TabIndex = 2
            '
            'object_a2eed2a7_9942_4461_8690_c4ded575d9fb
            '
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.DropDownWidth = 325
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.FormattingEnabled = True
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Location = New System.Drawing.Point(0, 0)
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Name = "object_a2eed2a7_9942_4461_8690_c4ded575d9fb"
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Size = New System.Drawing.Size(388, 21)
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.TabIndex = 2
            '
            'usrResolSentencia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel5)
            Me.Name = "usrResolSentencia"
            Me.Size = New System.Drawing.Size(701, 212)
            Me.Panel5.ResumeLayout(False)
            Me.pnlPie.ResumeLayout(False)
            Me.pnlObsInimputable.ResumeLayout(False)
            Me.pnlObsInimputable.PerformLayout()
            Me.pnlInimputables.ResumeLayout(False)
            Me.pnlInimputables.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.pnlJornadas.ResumeLayout(False)
            Me.pnlJornadas.PerformLayout()
            Me.pnlFechaSentencia.ResumeLayout(False)
            Me.pnlFechaSentencia.PerformLayout()
            Me.pnlSemicabecera.ResumeLayout(False)
            Me.grbAutoridad.ResumeLayout(False)
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.pnlCabecera.ResumeLayout(False)
            Me.grbCabecera.ResumeLayout(False)
            Me.grbCabecera.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents grbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents txtFolio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtLibro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpFechRecepDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpFechDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtNumOficio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents grbAutoridad As System.Windows.Forms.GroupBox
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents object_54cb3d30_851e_467f_b037_d3de6ef8c4c2 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents object_a2eed2a7_9942_4461_8690_c4ded575d9fb As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents UscComboSala1 As Busqueda.uscComboSala
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents pnlSemicabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents lblSala As Label
        Friend WithEvents pnlObsInimputable As Panel
        Friend WithEvents rdbNo As RadioButton
        Friend WithEvents txtResolucion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents rdbSi As RadioButton
        Friend WithEvents lblResolucion As Label
        Friend WithEvents chkCadenaPerpetua As CheckBox
        Friend WithEvents UscComboDistritoJudicial1 As Busqueda.uscComboDistritoJudicial
        Friend WithEvents Panel3 As Panel
        Friend WithEvents pnlFechaSentencia As Panel
        Friend WithEvents chkConsentida As CheckBox
        Friend WithEvents lblFecSentencia As Label
        Friend WithEvents dtpFecSentencia As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label2 As Label
        Friend WithEvents pnlJornadas As Panel
        Friend WithEvents lbletiqueta As Label
        Friend WithEvents txtCant As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblJornadas As Label
        Friend WithEvents lblConsentida As Label
        Friend WithEvents pnlCondena As Panel
        Friend WithEvents ckbExtramuro As CheckBox
        Friend WithEvents Label3 As Label
        Friend WithEvents pnlInimputables As Panel
        Friend WithEvents txtObservacion As TextBox
    End Class
End Namespace