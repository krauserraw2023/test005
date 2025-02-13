Namespace Registro.PenalLM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscMovDetalle
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
            Me.pnlUserControl = New System.Windows.Forms.Panel()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblEtiquetaObservacion = New System.Windows.Forms.Label()
            Me.PnlOrigenDestino = New System.Windows.Forms.Panel()
            Me.txtOtroLugar = New System.Windows.Forms.TextBox()
            Me.pnlCaborigendestino = New System.Windows.Forms.Panel()
            Me.cbbPeriodo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.lblOrigenDestino = New System.Windows.Forms.Label()
            Me.dtpFecharetorno = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblFecharetorno = New System.Windows.Forms.Label()
            Me.rdbSinorigen = New Legolas.APPUIComponents.myRadioButton()
            Me.txtdias = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.rdbOtroLugar = New Legolas.APPUIComponents.myRadioButton()
            Me.lblTiemposalida = New System.Windows.Forms.Label()
            Me.rdbPenal = New Legolas.APPUIComponents.myRadioButton()
            Me.lblRegion = New System.Windows.Forms.Label()
            Me.lblPenal = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.PnlEncabezado = New System.Windows.Forms.Panel()
            Me.cbbMovMotivo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.nudMinutos = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.TextBox1 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox1 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.nudHora = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.object_360a1154_2066_4230_84c4_54434ae312f8 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbEstado = New System.Windows.Forms.ComboBox()
            Me.txtMovimientoGrupo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMovimientoTipo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.lblIngresoSalida = New System.Windows.Forms.Label()
            Me.dtpFechaMov = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblMovTipo = New System.Windows.Forms.Label()
            Me.lblfecha = New System.Windows.Forms.Label()
            Me.lblSubmotivo = New System.Windows.Forms.Label()
            Me.lblMotivoTraslado = New System.Windows.Forms.Label()
            Me.pnlUserControl.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.PnlOrigenDestino.SuspendLayout()
            Me.pnlCaborigendestino.SuspendLayout()
            Me.PnlEncabezado.SuspendLayout()
            Me.nudMinutos.SuspendLayout()
            Me.nudHora.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlUserControl
            '
            Me.pnlUserControl.Controls.Add(Me.txtObservacion)
            Me.pnlUserControl.Controls.Add(Me.Panel1)
            Me.pnlUserControl.Controls.Add(Me.PnlOrigenDestino)
            Me.pnlUserControl.Controls.Add(Me.PnlEncabezado)
            Me.pnlUserControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlUserControl.Location = New System.Drawing.Point(0, 0)
            Me.pnlUserControl.Name = "pnlUserControl"
            Me.pnlUserControl.Size = New System.Drawing.Size(658, 175)
            Me.pnlUserControl.TabIndex = 0
            '
            'txtObservacion
            '
            Me.txtObservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = False
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Location = New System.Drawing.Point(107, 116)
            Me.txtObservacion.MaxLength = 2500
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(551, 59)
            Me.txtObservacion.TabIndex = 3
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.lblEtiquetaObservacion)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel1.Location = New System.Drawing.Point(0, 116)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(107, 59)
            Me.Panel1.TabIndex = 2
            '
            'lblEtiquetaObservacion
            '
            Me.lblEtiquetaObservacion.AutoSize = True
            Me.lblEtiquetaObservacion.Location = New System.Drawing.Point(5, 6)
            Me.lblEtiquetaObservacion.Name = "lblEtiquetaObservacion"
            Me.lblEtiquetaObservacion.Size = New System.Drawing.Size(70, 26)
            Me.lblEtiquetaObservacion.TabIndex = 0
            Me.lblEtiquetaObservacion.Text = "Observación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Movimiento :"
            '
            'PnlOrigenDestino
            '
            Me.PnlOrigenDestino.Controls.Add(Me.txtOtroLugar)
            Me.PnlOrigenDestino.Controls.Add(Me.pnlCaborigendestino)
            Me.PnlOrigenDestino.Controls.Add(Me.lblRegion)
            Me.PnlOrigenDestino.Controls.Add(Me.lblPenal)
            Me.PnlOrigenDestino.Controls.Add(Me.cbbPenal)
            Me.PnlOrigenDestino.Controls.Add(Me.cbbRegion)
            Me.PnlOrigenDestino.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlOrigenDestino.Location = New System.Drawing.Point(0, 62)
            Me.PnlOrigenDestino.Name = "PnlOrigenDestino"
            Me.PnlOrigenDestino.Size = New System.Drawing.Size(658, 54)
            Me.PnlOrigenDestino.TabIndex = 1
            '
            'txtOtroLugar
            '
            Me.txtOtroLugar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtroLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtOtroLugar.Location = New System.Drawing.Point(107, 29)
            Me.txtOtroLugar.MaxLength = 120
            Me.txtOtroLugar.Name = "txtOtroLugar"
            Me.txtOtroLugar.Size = New System.Drawing.Size(551, 20)
            Me.txtOtroLugar.TabIndex = 5
            '
            'pnlCaborigendestino
            '
            Me.pnlCaborigendestino.Controls.Add(Me.cbbPeriodo)
            Me.pnlCaborigendestino.Controls.Add(Me.lblOrigenDestino)
            Me.pnlCaborigendestino.Controls.Add(Me.dtpFecharetorno)
            Me.pnlCaborigendestino.Controls.Add(Me.lblFecharetorno)
            Me.pnlCaborigendestino.Controls.Add(Me.rdbSinorigen)
            Me.pnlCaborigendestino.Controls.Add(Me.txtdias)
            Me.pnlCaborigendestino.Controls.Add(Me.rdbOtroLugar)
            Me.pnlCaborigendestino.Controls.Add(Me.lblTiemposalida)
            Me.pnlCaborigendestino.Controls.Add(Me.rdbPenal)
            Me.pnlCaborigendestino.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCaborigendestino.Location = New System.Drawing.Point(0, 0)
            Me.pnlCaborigendestino.Name = "pnlCaborigendestino"
            Me.pnlCaborigendestino.Size = New System.Drawing.Size(658, 25)
            Me.pnlCaborigendestino.TabIndex = 0
            '
            'cbbPeriodo
            '
            Me.cbbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPeriodo.FormattingEnabled = True
            Me.cbbPeriodo.Items.AddRange(New Object() {"dias", "horas", "mn"})
            Me.cbbPeriodo.Location = New System.Drawing.Point(445, 3)
            Me.cbbPeriodo.Name = "cbbPeriodo"
            Me.cbbPeriodo.Size = New System.Drawing.Size(42, 21)
            Me.cbbPeriodo.TabIndex = 6
            '
            'lblOrigenDestino
            '
            Me.lblOrigenDestino.AutoSize = True
            Me.lblOrigenDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOrigenDestino.Location = New System.Drawing.Point(4, 6)
            Me.lblOrigenDestino.Name = "lblOrigenDestino"
            Me.lblOrigenDestino.Size = New System.Drawing.Size(85, 13)
            Me.lblOrigenDestino.TabIndex = 0
            Me.lblOrigenDestino.Text = "Origen/Destino :"
            '
            'dtpFecharetorno
            '
            Me.dtpFecharetorno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpFecharetorno.Location = New System.Drawing.Point(569, 2)
            Me.dtpFecharetorno.Name = "dtpFecharetorno"
            Me.dtpFecharetorno.Size = New System.Drawing.Size(84, 21)
            Me.dtpFecharetorno.TabIndex = 8
            Me.dtpFecharetorno.Value = "/  /"
            Me.dtpFecharetorno.ValueLong = CType(0, Long)
            '
            'lblFecharetorno
            '
            Me.lblFecharetorno.AutoSize = True
            Me.lblFecharetorno.Location = New System.Drawing.Point(495, 6)
            Me.lblFecharetorno.Name = "lblFecharetorno"
            Me.lblFecharetorno.Size = New System.Drawing.Size(70, 13)
            Me.lblFecharetorno.TabIndex = 7
            Me.lblFecharetorno.Text = "Fec. retorno :"
            '
            'rdbSinorigen
            '
            Me.rdbSinorigen.AutoSize = True
            Me.rdbSinorigen.Location = New System.Drawing.Point(245, 4)
            Me.rdbSinorigen.Name = "rdbSinorigen"
            Me.rdbSinorigen.Size = New System.Drawing.Size(74, 17)
            Me.rdbSinorigen.TabIndex = 3
            Me.rdbSinorigen.Text = "Sin Origen"
            Me.rdbSinorigen.UseVisualStyleBackColor = True
            '
            'txtdias
            '
            Me.txtdias._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtdias._BloquearPaste = False
            Me.txtdias._SeleccionarTodo = False
            Me.txtdias.BackColor = System.Drawing.Color.White
            Me.txtdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtdias.Location = New System.Drawing.Point(414, 3)
            Me.txtdias.MaxLength = 2
            Me.txtdias.Name = "txtdias"
            Me.txtdias.Size = New System.Drawing.Size(27, 20)
            Me.txtdias.TabIndex = 5
            Me.txtdias.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtdias.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'rdbOtroLugar
            '
            Me.rdbOtroLugar.AutoSize = True
            Me.rdbOtroLugar.Location = New System.Drawing.Point(165, 4)
            Me.rdbOtroLugar.Name = "rdbOtroLugar"
            Me.rdbOtroLugar.Size = New System.Drawing.Size(75, 17)
            Me.rdbOtroLugar.TabIndex = 2
            Me.rdbOtroLugar.Text = "Otro Lugar"
            Me.rdbOtroLugar.UseVisualStyleBackColor = True
            '
            'lblTiemposalida
            '
            Me.lblTiemposalida.AutoSize = True
            Me.lblTiemposalida.Location = New System.Drawing.Point(319, 6)
            Me.lblTiemposalida.Name = "lblTiemposalida"
            Me.lblTiemposalida.Size = New System.Drawing.Size(93, 13)
            Me.lblTiemposalida.TabIndex = 4
            Me.lblTiemposalida.Text = "Tiempo de salida :"
            '
            'rdbPenal
            '
            Me.rdbPenal.AutoSize = True
            Me.rdbPenal.Checked = True
            Me.rdbPenal.Location = New System.Drawing.Point(107, 4)
            Me.rdbPenal.Name = "rdbPenal"
            Me.rdbPenal.Size = New System.Drawing.Size(52, 17)
            Me.rdbPenal.TabIndex = 1
            Me.rdbPenal.TabStop = True
            Me.rdbPenal.Text = "Penal"
            Me.rdbPenal.UseVisualStyleBackColor = True
            '
            'lblRegion
            '
            Me.lblRegion.AutoSize = True
            Me.lblRegion.Location = New System.Drawing.Point(5, 31)
            Me.lblRegion.Name = "lblRegion"
            Me.lblRegion.Size = New System.Drawing.Size(44, 13)
            Me.lblRegion.TabIndex = 1
            Me.lblRegion.Text = "Región:"
            '
            'lblPenal
            '
            Me.lblPenal.AutoSize = True
            Me.lblPenal.Location = New System.Drawing.Point(386, 31)
            Me.lblPenal.Name = "lblPenal"
            Me.lblPenal.Size = New System.Drawing.Size(37, 13)
            Me.lblPenal.TabIndex = 3
            Me.lblPenal.Text = "Penal:"
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
            Me.cbbPenal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbPenal.CodigoPadre = -1
            Me.cbbPenal.ComboTipo = Type.Combo.ComboTipo.Penal
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 325
            Me.cbbPenal.DropDownWidthAuto = True
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(447, 29)
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(206, 22)
            Me.cbbPenal.TabIndex = 4
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
            Me.cbbRegion.ComboTipo = Type.Combo.ComboTipo.Region
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 325
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(108, 29)
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(267, 22)
            Me.cbbRegion.TabIndex = 2
            '
            'PnlEncabezado
            '
            Me.PnlEncabezado.Controls.Add(Me.cbbMovMotivo)
            Me.PnlEncabezado.Controls.Add(Me.nudMinutos)
            Me.PnlEncabezado.Controls.Add(Me.nudHora)
            Me.PnlEncabezado.Controls.Add(Me.Label1)
            Me.PnlEncabezado.Controls.Add(Me.cbbEstado)
            Me.PnlEncabezado.Controls.Add(Me.txtMovimientoGrupo)
            Me.PnlEncabezado.Controls.Add(Me.txtMovimientoTipo)
            Me.PnlEncabezado.Controls.Add(Me.lblEstado)
            Me.PnlEncabezado.Controls.Add(Me.lblIngresoSalida)
            Me.PnlEncabezado.Controls.Add(Me.dtpFechaMov)
            Me.PnlEncabezado.Controls.Add(Me.lblMovTipo)
            Me.PnlEncabezado.Controls.Add(Me.lblfecha)
            Me.PnlEncabezado.Controls.Add(Me.lblSubmotivo)
            Me.PnlEncabezado.Controls.Add(Me.lblMotivoTraslado)
            Me.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlEncabezado.Location = New System.Drawing.Point(0, 0)
            Me.PnlEncabezado.Name = "PnlEncabezado"
            Me.PnlEncabezado.Size = New System.Drawing.Size(658, 62)
            Me.PnlEncabezado.TabIndex = 0
            '
            'cbbMovMotivo
            '
            Me.cbbMovMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMovMotivo.FormattingEnabled = True
            Me.cbbMovMotivo.Location = New System.Drawing.Point(447, 10)
            Me.cbbMovMotivo.Name = "cbbMovMotivo"
            Me.cbbMovMotivo.Size = New System.Drawing.Size(206, 21)
            Me.cbbMovMotivo.TabIndex = 15
            '
            'nudMinutos
            '
            Me.nudMinutos._Formato = "00"
            Me.nudMinutos._Increment = 1
            Me.nudMinutos._Maximum = 59
            Me.nudMinutos._Minimum = 0
            Me.nudMinutos._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudMinutos._Value = 0
            Me.nudMinutos.Controls.Add(Me.TextBox1)
            Me.nudMinutos.Controls.Add(Me.MyTextBox1)
            Me.nudMinutos.Controls.Add(Me.MyTextBox2)
            Me.nudMinutos.Location = New System.Drawing.Point(175, 32)
            Me.nudMinutos.Name = "nudMinutos"
            Me.nudMinutos.Size = New System.Drawing.Size(35, 20)
            Me.nudMinutos.TabIndex = 10
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
            Me.TextBox1.Text = "00"
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
            'nudHora
            '
            Me.nudHora._Formato = "00"
            Me.nudHora._Increment = 1
            Me.nudHora._Maximum = 23
            Me.nudHora._Minimum = 0
            Me.nudHora._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudHora._Value = 8
            Me.nudHora.Controls.Add(Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41)
            Me.nudHora.Controls.Add(Me.object_360a1154_2066_4230_84c4_54434ae312f8)
            Me.nudHora.Controls.Add(Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004)
            Me.nudHora.Location = New System.Drawing.Point(134, 32)
            Me.nudHora.Name = "nudHora"
            Me.nudHora.Size = New System.Drawing.Size(35, 20)
            Me.nudHora.TabIndex = 8
            '
            'object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41
            '
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41._BloquearPaste = False
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41._SeleccionarTodo = False
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Location = New System.Drawing.Point(2, 3)
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Name = "object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41"
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Size = New System.Drawing.Size(14, 13)
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.TabIndex = 0
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Text = "08"
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'object_360a1154_2066_4230_84c4_54434ae312f8
            '
            Me.object_360a1154_2066_4230_84c4_54434ae312f8._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_360a1154_2066_4230_84c4_54434ae312f8._BloquearPaste = False
            Me.object_360a1154_2066_4230_84c4_54434ae312f8._SeleccionarTodo = False
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Location = New System.Drawing.Point(2, 3)
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Name = "object_360a1154_2066_4230_84c4_54434ae312f8"
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Size = New System.Drawing.Size(14, 13)
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.TabIndex = 0
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Text = "5"
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004
            '
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004._BloquearPaste = False
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004._SeleccionarTodo = False
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Location = New System.Drawing.Point(2, 3)
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Name = "object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004"
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Size = New System.Drawing.Size(14, 13)
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.TabIndex = 0
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Text = "5"
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label1.Location = New System.Drawing.Point(0, 59)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(658, 3)
            Me.Label1.TabIndex = 0
            '
            'cbbEstado
            '
            Me.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbEstado.FormattingEnabled = True
            Me.cbbEstado.Location = New System.Drawing.Point(279, 34)
            Me.cbbEstado.Name = "cbbEstado"
            Me.cbbEstado.Size = New System.Drawing.Size(100, 21)
            Me.cbbEstado.TabIndex = 12
            '
            'txtMovimientoGrupo
            '
            Me.txtMovimientoGrupo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMovimientoGrupo._BloquearPaste = False
            Me.txtMovimientoGrupo._SeleccionarTodo = False
            Me.txtMovimientoGrupo.BackColor = System.Drawing.SystemColors.Control
            Me.txtMovimientoGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMovimientoGrupo.Location = New System.Drawing.Point(49, 9)
            Me.txtMovimientoGrupo.MaxLength = 2
            Me.txtMovimientoGrupo.Name = "txtMovimientoGrupo"
            Me.txtMovimientoGrupo.ReadOnly = True
            Me.txtMovimientoGrupo.Size = New System.Drawing.Size(84, 20)
            Me.txtMovimientoGrupo.TabIndex = 1
            Me.txtMovimientoGrupo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtMovimientoGrupo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtMovimientoTipo
            '
            Me.txtMovimientoTipo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMovimientoTipo._BloquearPaste = False
            Me.txtMovimientoTipo._SeleccionarTodo = False
            Me.txtMovimientoTipo.BackColor = System.Drawing.SystemColors.Control
            Me.txtMovimientoTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMovimientoTipo.Location = New System.Drawing.Point(279, 9)
            Me.txtMovimientoTipo.MaxLength = 2
            Me.txtMovimientoTipo.Name = "txtMovimientoTipo"
            Me.txtMovimientoTipo.ReadOnly = True
            Me.txtMovimientoTipo.Size = New System.Drawing.Size(100, 20)
            Me.txtMovimientoTipo.TabIndex = 3
            Me.txtMovimientoTipo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtMovimientoTipo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblEstado
            '
            Me.lblEstado.AutoSize = True
            Me.lblEstado.Location = New System.Drawing.Point(214, 38)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(43, 13)
            Me.lblEstado.TabIndex = 11
            Me.lblEstado.Text = "Estado:"
            '
            'lblIngresoSalida
            '
            Me.lblIngresoSalida.AutoSize = True
            Me.lblIngresoSalida.Location = New System.Drawing.Point(6, 11)
            Me.lblIngresoSalida.Name = "lblIngresoSalida"
            Me.lblIngresoSalida.Size = New System.Drawing.Size(31, 13)
            Me.lblIngresoSalida.TabIndex = 0
            Me.lblIngresoSalida.Text = "Tipo:"
            '
            'dtpFechaMov
            '
            Me.dtpFechaMov.Location = New System.Drawing.Point(49, 32)
            Me.dtpFechaMov.Name = "dtpFechaMov"
            Me.dtpFechaMov.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaMov.TabIndex = 7
            Me.dtpFechaMov.Value = "/  /"
            Me.dtpFechaMov.ValueLong = CType(0, Long)
            '
            'lblMovTipo
            '
            Me.lblMovTipo.AutoSize = True
            Me.lblMovTipo.Location = New System.Drawing.Point(214, 11)
            Me.lblMovTipo.Name = "lblMovTipo"
            Me.lblMovTipo.Size = New System.Drawing.Size(64, 13)
            Me.lblMovTipo.TabIndex = 2
            Me.lblMovTipo.Text = "Movimiento:"
            '
            'lblfecha
            '
            Me.lblfecha.AutoSize = True
            Me.lblfecha.Location = New System.Drawing.Point(6, 30)
            Me.lblfecha.Name = "lblfecha"
            Me.lblfecha.Size = New System.Drawing.Size(39, 26)
            Me.lblfecha.TabIndex = 6
            Me.lblfecha.Text = "Fec. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y hora:"
            '
            'lblSubmotivo
            '
            Me.lblSubmotivo.AutoSize = True
            Me.lblSubmotivo.Location = New System.Drawing.Point(386, 13)
            Me.lblSubmotivo.Name = "lblSubmotivo"
            Me.lblSubmotivo.Size = New System.Drawing.Size(62, 13)
            Me.lblSubmotivo.TabIndex = 13
            Me.lblSubmotivo.Text = "Modalidad :"
            '
            'lblMotivoTraslado
            '
            Me.lblMotivoTraslado.AutoSize = True
            Me.lblMotivoTraslado.Location = New System.Drawing.Point(167, 36)
            Me.lblMotivoTraslado.Name = "lblMotivoTraslado"
            Me.lblMotivoTraslado.Size = New System.Drawing.Size(10, 13)
            Me.lblMotivoTraslado.TabIndex = 9
            Me.lblMotivoTraslado.Text = ":"
            '
            'uscMovDetalle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.pnlUserControl)
            Me.Name = "uscMovDetalle"
            Me.Size = New System.Drawing.Size(658, 175)
            Me.pnlUserControl.ResumeLayout(False)
            Me.pnlUserControl.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.PnlOrigenDestino.ResumeLayout(False)
            Me.PnlOrigenDestino.PerformLayout()
            Me.pnlCaborigendestino.ResumeLayout(False)
            Me.pnlCaborigendestino.PerformLayout()
            Me.PnlEncabezado.ResumeLayout(False)
            Me.PnlEncabezado.PerformLayout()
            Me.nudMinutos.ResumeLayout(False)
            Me.nudMinutos.PerformLayout()
            Me.nudHora.ResumeLayout(False)
            Me.nudHora.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlUserControl As System.Windows.Forms.Panel
        Friend WithEvents PnlEncabezado As System.Windows.Forms.Panel
        Friend WithEvents lblEtiquetaObservacion As System.Windows.Forms.Label
        Friend WithEvents PnlOrigenDestino As System.Windows.Forms.Panel
        Friend WithEvents lblOrigenDestino As System.Windows.Forms.Label
        Friend WithEvents lblRegion As System.Windows.Forms.Label
        Friend WithEvents rdbPenal As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents lblPenal As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents rdbOtroLugar As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents txtOtroLugar As System.Windows.Forms.TextBox
        Friend WithEvents rdbSinorigen As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents lblTiemposalida As System.Windows.Forms.Label
        Friend WithEvents cbbPeriodo As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents dtpFecharetorno As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblFecharetorno As System.Windows.Forms.Label
        Friend WithEvents txtdias As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlCaborigendestino As System.Windows.Forms.Panel
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbbEstado As System.Windows.Forms.ComboBox
        Friend WithEvents nudMinutos As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents TextBox1 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox1 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents nudHora As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents object_360a1154_2066_4230_84c4_54434ae312f8 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblMotivoTraslado As System.Windows.Forms.Label
        Friend WithEvents txtMovimientoGrupo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMovimientoTipo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblEstado As System.Windows.Forms.Label
        Friend WithEvents lblIngresoSalida As System.Windows.Forms.Label
        Friend WithEvents dtpFechaMov As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblMovTipo As System.Windows.Forms.Label
        Friend WithEvents lblfecha As System.Windows.Forms.Label
        Friend WithEvents lblSubmotivo As System.Windows.Forms.Label
        Protected WithEvents cbbMovMotivo As Legolas.APPUIComponents.MyComboBox

    End Class
End Namespace