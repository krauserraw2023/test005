Namespace Registro.Main


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscBusquedaMovimiento
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.gbdatosbasicos = New System.Windows.Forms.GroupBox()
            Me.txtApellidoMaterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApellidoPaterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtCodigoRp = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.gbMotivo = New System.Windows.Forms.GroupBox()
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.cbbEstado = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.cbbMovimientoTipo = New APPControls.uscComboParametrica()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.cbbMovimientomotivo = New APPControls.uscComboParametrica()
            Me.gbFechamovimiento = New System.Windows.Forms.GroupBox()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.gbTipoingreso = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbEgresos = New System.Windows.Forms.RadioButton()
            Me.rdbIngresos = New System.Windows.Forms.RadioButton()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_reg_id_mov = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id_mov = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_mov = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_isp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox4.SuspendLayout()
            Me.gbdatosbasicos.SuspendLayout()
            Me.gbMotivo.SuspendLayout()
            Me.gbFechamovimiento.SuspendLayout()
            Me.gbTipoingreso.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.gbdatosbasicos)
            Me.GroupBox4.Controls.Add(Me.gbMotivo)
            Me.GroupBox4.Controls.Add(Me.gbFechamovimiento)
            Me.GroupBox4.Controls.Add(Me.gbTipoingreso)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.GroupBox4.Size = New System.Drawing.Size(1010, 113)
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Buscar por:"
            '
            'gbdatosbasicos
            '
            Me.gbdatosbasicos.Controls.Add(Me.txtApellidoMaterno)
            Me.gbdatosbasicos.Controls.Add(Me.txtNombres)
            Me.gbdatosbasicos.Controls.Add(Me.txtApellidoPaterno)
            Me.gbdatosbasicos.Controls.Add(Me.txtCodigoRp)
            Me.gbdatosbasicos.Controls.Add(Me.Label20)
            Me.gbdatosbasicos.Controls.Add(Me.Label21)
            Me.gbdatosbasicos.Controls.Add(Me.Label22)
            Me.gbdatosbasicos.Controls.Add(Me.Label23)
            Me.gbdatosbasicos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbdatosbasicos.Location = New System.Drawing.Point(487, 13)
            Me.gbdatosbasicos.Name = "gbdatosbasicos"
            Me.gbdatosbasicos.Size = New System.Drawing.Size(520, 97)
            Me.gbdatosbasicos.TabIndex = 4
            Me.gbdatosbasicos.TabStop = False
            '
            'txtApellidoMaterno
            '
            Me.txtApellidoMaterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidoMaterno._BloquearPaste = False
            Me.txtApellidoMaterno._SeleccionarTodo = True
            Me.txtApellidoMaterno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer))
            Me.txtApellidoMaterno.Location = New System.Drawing.Point(104, 52)
            Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
            Me.txtApellidoMaterno.Size = New System.Drawing.Size(140, 20)
            Me.txtApellidoMaterno.TabIndex = 21
            Me.txtApellidoMaterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidoMaterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtNombres
            '
            Me.txtNombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombres._BloquearPaste = False
            Me.txtNombres._SeleccionarTodo = True
            Me.txtNombres.Location = New System.Drawing.Point(104, 74)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.Size = New System.Drawing.Size(140, 20)
            Me.txtNombres.TabIndex = 23
            Me.txtNombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApellidoPaterno
            '
            Me.txtApellidoPaterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidoPaterno._BloquearPaste = False
            Me.txtApellidoPaterno._SeleccionarTodo = True
            Me.txtApellidoPaterno.Location = New System.Drawing.Point(104, 31)
            Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
            Me.txtApellidoPaterno.Size = New System.Drawing.Size(140, 20)
            Me.txtApellidoPaterno.TabIndex = 19
            Me.txtApellidoPaterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidoPaterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtCodigoRp
            '
            Me.txtCodigoRp._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodigoRp._BloquearPaste = False
            Me.txtCodigoRp._SeleccionarTodo = True
            Me.txtCodigoRp.ForeColor = System.Drawing.Color.Black
            Me.txtCodigoRp.Location = New System.Drawing.Point(104, 9)
            Me.txtCodigoRp.Name = "txtCodigoRp"
            Me.txtCodigoRp.Size = New System.Drawing.Size(87, 20)
            Me.txtCodigoRp.TabIndex = 17
            Me.txtCodigoRp.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodigoRp.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(9, 78)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(55, 13)
            Me.Label20.TabIndex = 22
            Me.Label20.Text = "Nombres :"
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(9, 56)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(93, 13)
            Me.Label21.TabIndex = 20
            Me.Label21.Text = "Segundo Apellido:"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(9, 35)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(82, 13)
            Me.Label22.TabIndex = 18
            Me.Label22.Text = "Primer Apellido :"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(9, 12)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(82, 13)
            Me.Label23.TabIndex = 16
            Me.Label23.Text = "Codigo Interno :"
            '
            'gbMotivo
            '
            Me.gbMotivo.Controls.Add(Me.lblEstado)
            Me.gbMotivo.Controls.Add(Me.cbbEstado)
            Me.gbMotivo.Controls.Add(Me.cbbMovimientoTipo)
            Me.gbMotivo.Controls.Add(Me.Label27)
            Me.gbMotivo.Controls.Add(Me.Label25)
            Me.gbMotivo.Controls.Add(Me.cbbMovimientomotivo)
            Me.gbMotivo.Dock = System.Windows.Forms.DockStyle.Left
            Me.gbMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbMotivo.Location = New System.Drawing.Point(284, 13)
            Me.gbMotivo.Name = "gbMotivo"
            Me.gbMotivo.Size = New System.Drawing.Size(203, 97)
            Me.gbMotivo.TabIndex = 2
            Me.gbMotivo.TabStop = False
            '
            'lblEstado
            '
            Me.lblEstado.AutoSize = True
            Me.lblEstado.Location = New System.Drawing.Point(8, 72)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(70, 13)
            Me.lblEstado.TabIndex = 25
            Me.lblEstado.Text = "Estado Mov.:"
            '
            'cbbEstado
            '
            Me.cbbEstado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbEstado.DropDownWidth = 300
            Me.cbbEstado.FormattingEnabled = True
            Me.cbbEstado.Location = New System.Drawing.Point(78, 69)
            Me.cbbEstado.Name = "cbbEstado"
            Me.cbbEstado.Size = New System.Drawing.Size(108, 21)
            Me.cbbEstado.TabIndex = 26
            '
            'cbbMovimientoTipo
            '
            Me.cbbMovimientoTipo._NoIndica = False
            Me.cbbMovimientoTipo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbMovimientoTipo._Todos = False
            Me.cbbMovimientoTipo._TodosMensaje = "[Todos]"
            Me.cbbMovimientoTipo._Visible_Add = False
            Me.cbbMovimientoTipo._Visible_Buscar = False
            Me.cbbMovimientoTipo._Visible_Eliminar = False
            Me.cbbMovimientoTipo.CodigoPadre = -1
            Me.cbbMovimientoTipo.ComboTipo = CType(51, Short)
            Me.cbbMovimientoTipo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbMovimientoTipo.DropDownWidth = 209
            Me.cbbMovimientoTipo.DropDownWidthAuto = True
            Me.cbbMovimientoTipo.ListaIdsParaExcluir = Nothing
            Me.cbbMovimientoTipo.Location = New System.Drawing.Point(78, 15)
            Me.cbbMovimientoTipo.ModuloTratamiento = False
            Me.cbbMovimientoTipo.Name = "cbbMovimientoTipo"
            Me.cbbMovimientoTipo.Parametro1 = -1
            Me.cbbMovimientoTipo.Parametro2 = -1
            Me.cbbMovimientoTipo.SelectedIndex = -1
            Me.cbbMovimientoTipo.SelectedValue = 0
            Me.cbbMovimientoTipo.Size = New System.Drawing.Size(108, 22)
            Me.cbbMovimientoTipo.TabIndex = 1
            Me.cbbMovimientoTipo.verToolTipItemSeleccionado = False
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(8, 46)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(62, 13)
            Me.Label27.TabIndex = 2
            Me.Label27.Text = "Modalidad :"
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(8, 18)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(67, 13)
            Me.Label25.TabIndex = 0
            Me.Label25.Text = "Movimiento :"
            '
            'cbbMovimientomotivo
            '
            Me.cbbMovimientomotivo._NoIndica = False
            Me.cbbMovimientomotivo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbMovimientomotivo._Todos = False
            Me.cbbMovimientomotivo._TodosMensaje = "[Todos]"
            Me.cbbMovimientomotivo._Visible_Add = False
            Me.cbbMovimientomotivo._Visible_Buscar = False
            Me.cbbMovimientomotivo._Visible_Eliminar = False
            Me.cbbMovimientomotivo.CodigoPadre = -1
            Me.cbbMovimientomotivo.ComboTipo = CType(52, Short)
            Me.cbbMovimientomotivo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbMovimientomotivo.DropDownWidth = 209
            Me.cbbMovimientomotivo.DropDownWidthAuto = True
            Me.cbbMovimientomotivo.ListaIdsParaExcluir = Nothing
            Me.cbbMovimientomotivo.Location = New System.Drawing.Point(78, 42)
            Me.cbbMovimientomotivo.ModuloTratamiento = False
            Me.cbbMovimientomotivo.Name = "cbbMovimientomotivo"
            Me.cbbMovimientomotivo.Parametro1 = -1
            Me.cbbMovimientomotivo.Parametro2 = -1
            Me.cbbMovimientomotivo.SelectedIndex = -1
            Me.cbbMovimientomotivo.SelectedValue = 0
            Me.cbbMovimientomotivo.Size = New System.Drawing.Size(108, 22)
            Me.cbbMovimientomotivo.TabIndex = 3
            Me.cbbMovimientomotivo.verToolTipItemSeleccionado = False
            '
            'gbFechamovimiento
            '
            Me.gbFechamovimiento.Controls.Add(Me.dtpFechaFin)
            Me.gbFechamovimiento.Controls.Add(Me.dtpFechaIni)
            Me.gbFechamovimiento.Controls.Add(Me.Label17)
            Me.gbFechamovimiento.Controls.Add(Me.Label18)
            Me.gbFechamovimiento.Dock = System.Windows.Forms.DockStyle.Left
            Me.gbFechamovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFechamovimiento.Location = New System.Drawing.Point(122, 13)
            Me.gbFechamovimiento.Name = "gbFechamovimiento"
            Me.gbFechamovimiento.Size = New System.Drawing.Size(162, 97)
            Me.gbFechamovimiento.TabIndex = 1
            Me.gbFechamovimiento.TabStop = False
            Me.gbFechamovimiento.Text = "Fecha de movimiento"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFin.Location = New System.Drawing.Point(56, 53)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 3
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaIni.Location = New System.Drawing.Point(56, 21)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 1
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(6, 57)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(41, 13)
            Me.Label17.TabIndex = 2
            Me.Label17.Text = "Hasta :"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(3, 25)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(44, 13)
            Me.Label18.TabIndex = 0
            Me.Label18.Text = "Desde :"
            '
            'gbTipoingreso
            '
            Me.gbTipoingreso.Controls.Add(Me.rdbTodos)
            Me.gbTipoingreso.Controls.Add(Me.rdbEgresos)
            Me.gbTipoingreso.Controls.Add(Me.rdbIngresos)
            Me.gbTipoingreso.Dock = System.Windows.Forms.DockStyle.Left
            Me.gbTipoingreso.Location = New System.Drawing.Point(3, 13)
            Me.gbTipoingreso.Name = "gbTipoingreso"
            Me.gbTipoingreso.Size = New System.Drawing.Size(119, 97)
            Me.gbTipoingreso.TabIndex = 0
            Me.gbTipoingreso.TabStop = False
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbTodos.Location = New System.Drawing.Point(25, 70)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbTodos.TabIndex = 2
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "[Todos]"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbEgresos
            '
            Me.rdbEgresos.AutoSize = True
            Me.rdbEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbEgresos.Location = New System.Drawing.Point(25, 41)
            Me.rdbEgresos.Name = "rdbEgresos"
            Me.rdbEgresos.Size = New System.Drawing.Size(63, 17)
            Me.rdbEgresos.TabIndex = 1
            Me.rdbEgresos.Text = "Egresos"
            Me.rdbEgresos.UseVisualStyleBackColor = True
            '
            'rdbIngresos
            '
            Me.rdbIngresos.AutoSize = True
            Me.rdbIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbIngresos.Location = New System.Drawing.Point(25, 12)
            Me.rdbIngresos.Name = "rdbIngresos"
            Me.rdbIngresos.Size = New System.Drawing.Size(65, 17)
            Me.rdbIngresos.TabIndex = 0
            Me.rdbIngresos.Text = "Ingresos"
            Me.rdbIngresos.UseVisualStyleBackColor = True
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_reg_id_mov, Me.col_pen_id_mov, Me.DataGridViewCheckBoxColumn2, Me.col_fec_mov, Me.col_int_id, Me.col_int_ing, Me.DataGridViewTextBoxColumn4, Me.col_sex, Me.col_ape_nom, Me.DataGridViewTextBoxColumn15, Me.col_mov_est, Me.DataGridViewTextBoxColumn9, Me.col_fec_isp, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.col_del_gen, Me.col_del_esp_nom, Me.col_pen_id})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 113)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1010, 340)
            Me.dgwGrilla.TabIndex = 2
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_reg_id_mov
            '
            Me.col_reg_id_mov.DataPropertyName = "RegionNombre"
            Me.col_reg_id_mov.HeaderText = "Region"
            Me.col_reg_id_mov.Name = "col_reg_id_mov"
            Me.col_reg_id_mov.ReadOnly = True
            Me.col_reg_id_mov.Visible = False
            Me.col_reg_id_mov.Width = 120
            '
            'col_pen_id_mov
            '
            Me.col_pen_id_mov.DataPropertyName = "PenalNombre"
            Me.col_pen_id_mov.HeaderText = "Penal"
            Me.col_pen_id_mov.Name = "col_pen_id_mov"
            Me.col_pen_id_mov.ReadOnly = True
            Me.col_pen_id_mov.Visible = False
            Me.col_pen_id_mov.Width = 110
            '
            'DataGridViewCheckBoxColumn2
            '
            Me.DataGridViewCheckBoxColumn2.DataPropertyName = "MovimientoGrupoNombre"
            Me.DataGridViewCheckBoxColumn2.HeaderText = "Tipo"
            Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
            Me.DataGridViewCheckBoxColumn2.ReadOnly = True
            Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewCheckBoxColumn2.Width = 32
            '
            'col_fec_mov
            '
            Me.col_fec_mov.DataPropertyName = "Fecha"
            Me.col_fec_mov.HeaderText = "F. de movimiento"
            Me.col_fec_mov.Name = "col_fec_mov"
            Me.col_fec_mov.ReadOnly = True
            Me.col_fec_mov.ToolTipText = "Fecha y hora del movimiento"
            Me.col_fec_mov.Width = 120
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_int_ing
            '
            Me.col_int_ing.DataPropertyName = "IngresoID"
            Me.col_int_ing.DividerWidth = 1
            Me.col_int_ing.HeaderText = "IngresoID"
            Me.col_int_ing.Name = "col_int_ing"
            Me.col_int_ing.ReadOnly = True
            Me.col_int_ing.Visible = False
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "CodigoRP"
            Me.DataGridViewTextBoxColumn4.DividerWidth = 1
            Me.DataGridViewTextBoxColumn4.HeaderText = "Codigo"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Width = 80
            '
            'col_sex
            '
            Me.col_sex.DataPropertyName = "Sexo"
            Me.col_sex.HeaderText = "Sexo"
            Me.col_sex.Name = "col_sex"
            Me.col_sex.ReadOnly = True
            Me.col_sex.Width = 80
            '
            'col_ape_nom
            '
            Me.col_ape_nom.DataPropertyName = "GrillaApellidosNombres"
            Me.col_ape_nom.DividerWidth = 1
            Me.col_ape_nom.HeaderText = "Apellidos y Nombre(s)"
            Me.col_ape_nom.Name = "col_ape_nom"
            Me.col_ape_nom.ReadOnly = True
            Me.col_ape_nom.Width = 200
            '
            'DataGridViewTextBoxColumn15
            '
            Me.DataGridViewTextBoxColumn15.DataPropertyName = "NacionalidadNombre"
            Me.DataGridViewTextBoxColumn15.HeaderText = "Nacionalidad"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.ReadOnly = True
            Me.DataGridViewTextBoxColumn15.Width = 70
            '
            'col_mov_est
            '
            Me.col_mov_est.DataPropertyName = "EstadoNombre"
            Me.col_mov_est.HeaderText = "Estado Mov."
            Me.col_mov_est.Name = "col_mov_est"
            Me.col_mov_est.ReadOnly = True
            Me.col_mov_est.Visible = False
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.DataPropertyName = "IngresoNro"
            Me.DataGridViewTextBoxColumn9.HeaderText = "Nº Ing."
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.ReadOnly = True
            Me.DataGridViewTextBoxColumn9.Width = 63
            '
            'col_fec_isp
            '
            Me.col_fec_isp.DataPropertyName = "FechaISP"
            Me.col_fec_isp.HeaderText = "F. Ing. Sist. Penitenc."
            Me.col_fec_isp.Name = "col_fec_isp"
            Me.col_fec_isp.ReadOnly = True
            Me.col_fec_isp.Width = 131
            '
            'DataGridViewTextBoxColumn11
            '
            Me.DataGridViewTextBoxColumn11.DataPropertyName = "MovimientoTipoNombre"
            Me.DataGridViewTextBoxColumn11.HeaderText = "Movimiento / Modalidad"
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.ReadOnly = True
            Me.DataGridViewTextBoxColumn11.Width = 150
            '
            'DataGridViewTextBoxColumn12
            '
            Me.DataGridViewTextBoxColumn12.DataPropertyName = "MovimientoRetorno"
            Me.DataGridViewTextBoxColumn12.HeaderText = "R."
            Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
            Me.DataGridViewTextBoxColumn12.ReadOnly = True
            Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewTextBoxColumn12.ToolTipText = "R=Retorno Indica si el movimiento es con retorno"
            Me.DataGridViewTextBoxColumn12.Width = 27
            '
            'DataGridViewTextBoxColumn13
            '
            Me.DataGridViewTextBoxColumn13.DataPropertyName = "OrigenNombre"
            Me.DataGridViewTextBoxColumn13.HeaderText = "Origen"
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            Me.DataGridViewTextBoxColumn13.ReadOnly = True
            Me.DataGridViewTextBoxColumn13.Width = 95
            '
            'DataGridViewTextBoxColumn14
            '
            Me.DataGridViewTextBoxColumn14.DataPropertyName = "DestinoNombre"
            DataGridViewCellStyle2.Format = "d"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle2
            Me.DataGridViewTextBoxColumn14.HeaderText = "Destino"
            Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
            Me.DataGridViewTextBoxColumn14.ReadOnly = True
            Me.DataGridViewTextBoxColumn14.Width = 95
            '
            'DataGridViewTextBoxColumn16
            '
            Me.DataGridViewTextBoxColumn16.DataPropertyName = "AutoridadJudicialNombre"
            Me.DataGridViewTextBoxColumn16.HeaderText = "Autoridad"
            Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
            Me.DataGridViewTextBoxColumn16.ReadOnly = True
            Me.DataGridViewTextBoxColumn16.Width = 120
            '
            'DataGridViewTextBoxColumn17
            '
            Me.DataGridViewTextBoxColumn17.DataPropertyName = "DocumJudicialNum"
            Me.DataGridViewTextBoxColumn17.HeaderText = "Nº Expediente / Oficio"
            Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
            Me.DataGridViewTextBoxColumn17.ReadOnly = True
            Me.DataGridViewTextBoxColumn17.Width = 150
            '
            'col_del_gen
            '
            Me.col_del_gen.DataPropertyName = "DelitoGenericoNombre"
            Me.col_del_gen.HeaderText = "Delito Genérico"
            Me.col_del_gen.Name = "col_del_gen"
            Me.col_del_gen.ReadOnly = True
            Me.col_del_gen.Width = 110
            '
            'col_del_esp_nom
            '
            Me.col_del_esp_nom.DataPropertyName = "DelitoEspecificoNombre"
            Me.col_del_esp_nom.HeaderText = "Delito"
            Me.col_del_esp_nom.Name = "col_del_esp_nom"
            Me.col_del_esp_nom.ReadOnly = True
            Me.col_del_esp_nom.Width = 150
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "_PenalID"
            Me.col_pen_id.DividerWidth = 1
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'uscBusquedaMovimiento
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.GroupBox4)
            Me.Name = "uscBusquedaMovimiento"
            Me.Size = New System.Drawing.Size(1010, 453)
            Me.GroupBox4.ResumeLayout(False)
            Me.gbdatosbasicos.ResumeLayout(False)
            Me.gbdatosbasicos.PerformLayout()
            Me.gbMotivo.ResumeLayout(False)
            Me.gbMotivo.PerformLayout()
            Me.gbFechamovimiento.ResumeLayout(False)
            Me.gbFechamovimiento.PerformLayout()
            Me.gbTipoingreso.ResumeLayout(False)
            Me.gbTipoingreso.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents gbMotivo As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents gbFechamovimiento As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbEgresos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbIngresos As System.Windows.Forms.RadioButton
        Friend WithEvents gbTipoingreso As System.Windows.Forms.GroupBox
        Friend WithEvents cbbMovimientoTipo As APPControls.uscComboParametrica
        Friend WithEvents cbbMovimientomotivo As APPControls.uscComboParametrica
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents gbdatosbasicos As System.Windows.Forms.GroupBox
        Friend WithEvents txtApellidoMaterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApellidoPaterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtCodigoRp As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents lblEstado As Label
        Protected WithEvents cbbEstado As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents col_reg_id_mov As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id_mov As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_mov As DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_int_ing As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents col_sex As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_nom As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
        Friend WithEvents col_mov_est As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_isp As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewCheckBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
        Friend WithEvents col_del_gen As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
    End Class
End Namespace