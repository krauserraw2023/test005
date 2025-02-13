Namespace Registro.Main


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscBusquedaCarceleta
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.gbBusqueda = New System.Windows.Forms.GroupBox()
            Me.grbEstado = New System.Windows.Forms.GroupBox()
            Me.rdbEstadoTodos = New System.Windows.Forms.RadioButton()
            Me.rdbInactivo = New System.Windows.Forms.RadioButton()
            Me.rdbActivo = New System.Windows.Forms.RadioButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.grbClasificacion = New System.Windows.Forms.GroupBox()
            Me.rdbClasificacionTodos = New System.Windows.Forms.RadioButton()
            Me.rdbPorClasificar = New System.Windows.Forms.RadioButton()
            Me.rdbClasificados = New System.Windows.Forms.RadioButton()
            Me.grbFiltro = New System.Windows.Forms.GroupBox()
            Me.txtNombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtApellidos = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.rdbFClasificacion = New System.Windows.Forms.RadioButton()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.rdbFIngreso = New System.Windows.Forms.RadioButton()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.grbTipoMov = New System.Windows.Forms.GroupBox()
            Me.rdbMovTodos = New System.Windows.Forms.RadioButton()
            Me.rdbTraslado = New System.Windows.Forms.RadioButton()
            Me.rdbNuevo = New System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_reg_id_mov = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id_mov = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_mov = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_cla = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_des_clas = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_cla = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlCabecera.SuspendLayout()
            Me.gbBusqueda.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.grbClasificacion.SuspendLayout()
            Me.grbFiltro.SuspendLayout()
            Me.grbTipoMov.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.gbBusqueda)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(963, 150)
            Me.pnlCabecera.TabIndex = 5
            '
            'gbBusqueda
            '
            Me.gbBusqueda.Controls.Add(Me.grbEstado)
            Me.gbBusqueda.Controls.Add(Me.GroupBox1)
            Me.gbBusqueda.Controls.Add(Me.Label1)
            Me.gbBusqueda.Controls.Add(Me.grbClasificacion)
            Me.gbBusqueda.Controls.Add(Me.grbFiltro)
            Me.gbBusqueda.Controls.Add(Me.grbTipoMov)
            Me.gbBusqueda.Controls.Add(Me.GroupBox2)
            Me.gbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.gbBusqueda.Name = "gbBusqueda"
            Me.gbBusqueda.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.gbBusqueda.Size = New System.Drawing.Size(963, 150)
            Me.gbBusqueda.TabIndex = 0
            Me.gbBusqueda.TabStop = False
            '
            'grbEstado
            '
            Me.grbEstado.Controls.Add(Me.rdbEstadoTodos)
            Me.grbEstado.Controls.Add(Me.rdbInactivo)
            Me.grbEstado.Controls.Add(Me.rdbActivo)
            Me.grbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbEstado.Location = New System.Drawing.Point(856, 15)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(103, 86)
            Me.grbEstado.TabIndex = 41
            Me.grbEstado.TabStop = False
            Me.grbEstado.Text = "Estado"
            '
            'rdbEstadoTodos
            '
            Me.rdbEstadoTodos.AutoSize = True
            Me.rdbEstadoTodos.Checked = True
            Me.rdbEstadoTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbEstadoTodos.Location = New System.Drawing.Point(8, 64)
            Me.rdbEstadoTodos.Name = "rdbEstadoTodos"
            Me.rdbEstadoTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbEstadoTodos.TabIndex = 8
            Me.rdbEstadoTodos.TabStop = True
            Me.rdbEstadoTodos.Text = "[Todos]"
            Me.rdbEstadoTodos.UseVisualStyleBackColor = True
            '
            'rdbInactivo
            '
            Me.rdbInactivo.AutoSize = True
            Me.rdbInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbInactivo.Location = New System.Drawing.Point(8, 41)
            Me.rdbInactivo.Name = "rdbInactivo"
            Me.rdbInactivo.Size = New System.Drawing.Size(63, 17)
            Me.rdbInactivo.TabIndex = 7
            Me.rdbInactivo.Text = "Inactivo"
            Me.rdbInactivo.UseVisualStyleBackColor = True
            '
            'rdbActivo
            '
            Me.rdbActivo.AutoSize = True
            Me.rdbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbActivo.Location = New System.Drawing.Point(8, 19)
            Me.rdbActivo.Name = "rdbActivo"
            Me.rdbActivo.Size = New System.Drawing.Size(55, 17)
            Me.rdbActivo.TabIndex = 6
            Me.rdbActivo.Text = "Activo"
            Me.rdbActivo.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cbbNacionalidad)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Location = New System.Drawing.Point(620, 108)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(340, 38)
            Me.GroupBox1.TabIndex = 38
            Me.GroupBox1.TabStop = False
            '
            'cbbNacionalidad
            '
            Me.cbbNacionalidad._NoIndica = False
            Me.cbbNacionalidad._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbNacionalidad._Todos = False
            Me.cbbNacionalidad._TodosMensaje = ""
            Me.cbbNacionalidad._Visible_Add = False
            Me.cbbNacionalidad._Visible_Buscar = False
            Me.cbbNacionalidad._Visible_Eliminar = False
            Me.cbbNacionalidad.CodigoPadre = -1
            Me.cbbNacionalidad.ComboTipo = CType(4, Short)
            Me.cbbNacionalidad.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNacionalidad.DropDownWidth = 143
            Me.cbbNacionalidad.DropDownWidthAuto = False
            Me.cbbNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbNacionalidad.ListaIdsParaExcluir = Nothing
            Me.cbbNacionalidad.Location = New System.Drawing.Point(87, 12)
            Me.cbbNacionalidad.ModuloTratamiento = False
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(250, 22)
            Me.cbbNacionalidad.TabIndex = 35
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(6, 16)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(75, 13)
            Me.Label13.TabIndex = 36
            Me.Label13.Text = "Nacionalidad :"
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Location = New System.Drawing.Point(7, 107)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(958, 3)
            Me.Label1.TabIndex = 37
            '
            'grbClasificacion
            '
            Me.grbClasificacion.Controls.Add(Me.rdbClasificacionTodos)
            Me.grbClasificacion.Controls.Add(Me.rdbPorClasificar)
            Me.grbClasificacion.Controls.Add(Me.rdbClasificados)
            Me.grbClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbClasificacion.Location = New System.Drawing.Point(752, 15)
            Me.grbClasificacion.Name = "grbClasificacion"
            Me.grbClasificacion.Size = New System.Drawing.Size(98, 86)
            Me.grbClasificacion.TabIndex = 5
            Me.grbClasificacion.TabStop = False
            '
            'rdbClasificacionTodos
            '
            Me.rdbClasificacionTodos.AutoSize = True
            Me.rdbClasificacionTodos.Checked = True
            Me.rdbClasificacionTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbClasificacionTodos.Location = New System.Drawing.Point(7, 62)
            Me.rdbClasificacionTodos.Name = "rdbClasificacionTodos"
            Me.rdbClasificacionTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbClasificacionTodos.TabIndex = 2
            Me.rdbClasificacionTodos.TabStop = True
            Me.rdbClasificacionTodos.Text = "[Todos]"
            Me.rdbClasificacionTodos.UseVisualStyleBackColor = True
            '
            'rdbPorClasificar
            '
            Me.rdbPorClasificar.AutoSize = True
            Me.rdbPorClasificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPorClasificar.Location = New System.Drawing.Point(6, 39)
            Me.rdbPorClasificar.Name = "rdbPorClasificar"
            Me.rdbPorClasificar.Size = New System.Drawing.Size(86, 17)
            Me.rdbPorClasificar.TabIndex = 1
            Me.rdbPorClasificar.Text = "Por Clasificar"
            Me.rdbPorClasificar.UseVisualStyleBackColor = True
            '
            'rdbClasificados
            '
            Me.rdbClasificados.AutoSize = True
            Me.rdbClasificados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbClasificados.Location = New System.Drawing.Point(6, 16)
            Me.rdbClasificados.Name = "rdbClasificados"
            Me.rdbClasificados.Size = New System.Drawing.Size(81, 17)
            Me.rdbClasificados.TabIndex = 0
            Me.rdbClasificados.Text = "Clasificados"
            Me.rdbClasificados.UseVisualStyleBackColor = True
            '
            'grbFiltro
            '
            Me.grbFiltro.Controls.Add(Me.txtNombres)
            Me.grbFiltro.Controls.Add(Me.dtpFechaFin)
            Me.grbFiltro.Controls.Add(Me.Label20)
            Me.grbFiltro.Controls.Add(Me.txtApellidos)
            Me.grbFiltro.Controls.Add(Me.rdbFClasificacion)
            Me.grbFiltro.Controls.Add(Me.Label17)
            Me.grbFiltro.Controls.Add(Me.Label22)
            Me.grbFiltro.Controls.Add(Me.rdbFIngreso)
            Me.grbFiltro.Controls.Add(Me.Label18)
            Me.grbFiltro.Controls.Add(Me.dtpFechaInicio)
            Me.grbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbFiltro.Location = New System.Drawing.Point(121, 15)
            Me.grbFiltro.Name = "grbFiltro"
            Me.grbFiltro.Size = New System.Drawing.Size(625, 86)
            Me.grbFiltro.TabIndex = 4
            Me.grbFiltro.TabStop = False
            '
            'txtNombres
            '
            Me.txtNombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombres._BloquearPaste = False
            Me.txtNombres._SeleccionarTodo = True
            Me.txtNombres.Location = New System.Drawing.Point(442, 57)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.Size = New System.Drawing.Size(177, 20)
            Me.txtNombres.TabIndex = 7
            Me.txtNombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFin.Location = New System.Drawing.Point(330, 22)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 3
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(381, 60)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(55, 13)
            Me.Label20.TabIndex = 6
            Me.Label20.Text = "Nombres :"
            '
            'txtApellidos
            '
            Me.txtApellidos._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidos._BloquearPaste = False
            Me.txtApellidos._SeleccionarTodo = True
            Me.txtApellidos.Location = New System.Drawing.Point(71, 54)
            Me.txtApellidos.Name = "txtApellidos"
            Me.txtApellidos.Size = New System.Drawing.Size(304, 20)
            Me.txtApellidos.TabIndex = 3
            Me.txtApellidos.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidos.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'rdbFClasificacion
            '
            Me.rdbFClasificacion.AutoSize = True
            Me.rdbFClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbFClasificacion.Location = New System.Drawing.Point(91, 23)
            Me.rdbFClasificacion.Name = "rdbFClasificacion"
            Me.rdbFClasificacion.Size = New System.Drawing.Size(96, 17)
            Me.rdbFClasificacion.TabIndex = 1
            Me.rdbFClasificacion.Text = "F. Clasificación"
            Me.rdbFClasificacion.UseVisualStyleBackColor = True
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(313, 26)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(15, 13)
            Me.Label17.TabIndex = 2
            Me.Label17.Text = "al"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(10, 57)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(55, 13)
            Me.Label22.TabIndex = 2
            Me.Label22.Text = "Apellidos :"
            '
            'rdbFIngreso
            '
            Me.rdbFIngreso.AutoSize = True
            Me.rdbFIngreso.Checked = True
            Me.rdbFIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbFIngreso.Location = New System.Drawing.Point(13, 23)
            Me.rdbFIngreso.Name = "rdbFIngreso"
            Me.rdbFIngreso.Size = New System.Drawing.Size(72, 17)
            Me.rdbFIngreso.TabIndex = 0
            Me.rdbFIngreso.TabStop = True
            Me.rdbFIngreso.Text = "F. Ingreso"
            Me.rdbFIngreso.UseVisualStyleBackColor = True
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(193, 26)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(29, 13)
            Me.Label18.TabIndex = 0
            Me.Label18.Text = "Del :"
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaInicio.Location = New System.Drawing.Point(228, 22)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInicio.TabIndex = 1
            Me.dtpFechaInicio.Value = "/  /"
            Me.dtpFechaInicio.ValueLong = CType(0, Long)
            '
            'grbTipoMov
            '
            Me.grbTipoMov.Controls.Add(Me.rdbMovTodos)
            Me.grbTipoMov.Controls.Add(Me.rdbTraslado)
            Me.grbTipoMov.Controls.Add(Me.rdbNuevo)
            Me.grbTipoMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbTipoMov.Location = New System.Drawing.Point(6, 11)
            Me.grbTipoMov.Name = "grbTipoMov"
            Me.grbTipoMov.Size = New System.Drawing.Size(109, 90)
            Me.grbTipoMov.TabIndex = 0
            Me.grbTipoMov.TabStop = False
            Me.grbTipoMov.Text = "Ingreso a E.T."
            '
            'rdbMovTodos
            '
            Me.rdbMovTodos.AutoSize = True
            Me.rdbMovTodos.Checked = True
            Me.rdbMovTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbMovTodos.Location = New System.Drawing.Point(12, 67)
            Me.rdbMovTodos.Name = "rdbMovTodos"
            Me.rdbMovTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbMovTodos.TabIndex = 2
            Me.rdbMovTodos.TabStop = True
            Me.rdbMovTodos.Text = "[Todos]"
            Me.rdbMovTodos.UseVisualStyleBackColor = True
            '
            'rdbTraslado
            '
            Me.rdbTraslado.AutoSize = True
            Me.rdbTraslado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbTraslado.Location = New System.Drawing.Point(12, 44)
            Me.rdbTraslado.Name = "rdbTraslado"
            Me.rdbTraslado.Size = New System.Drawing.Size(71, 17)
            Me.rdbTraslado.TabIndex = 1
            Me.rdbTraslado.Text = "Traslados"
            Me.rdbTraslado.UseVisualStyleBackColor = True
            '
            'rdbNuevo
            '
            Me.rdbNuevo.AutoSize = True
            Me.rdbNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNuevo.Location = New System.Drawing.Point(12, 21)
            Me.rdbNuevo.Name = "rdbNuevo"
            Me.rdbNuevo.Size = New System.Drawing.Size(62, 17)
            Me.rdbNuevo.TabIndex = 0
            Me.rdbNuevo.Text = "Nuevos"
            Me.rdbNuevo.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.cbbRegion)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.cbbPenal)
            Me.GroupBox2.Controls.Add(Me.Label34)
            Me.GroupBox2.Location = New System.Drawing.Point(6, 108)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(608, 38)
            Me.GroupBox2.TabIndex = 39
            Me.GroupBox2.TabStop = False
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
            Me.cbbRegion.ComboTipo = CType(37, Short)
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 178
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(60, 12)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(244, 22)
            Me.cbbRegion.TabIndex = 7
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(47, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Región :"
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
            Me.cbbPenal.CodigoPadre = -1
            Me.cbbPenal.ComboTipo = CType(36, Short)
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 238
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(365, 12)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(240, 22)
            Me.cbbPenal.TabIndex = 9
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Location = New System.Drawing.Point(311, 16)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(51, 13)
            Me.Label34.TabIndex = 8
            Me.Label34.Text = "Penales :"
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_reg_id_mov, Me.col_pen_id_mov, Me.DataGridViewCheckBoxColumn2, Me.col_fec_mov, Me.col_int_id, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn9, Me.col_fec_cla, Me.col_pen_des_clas, Me.DataGridViewTextBoxColumn16, Me.col_exp, Me.col_doc_cla})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 150)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(963, 303)
            Me.dgwGrilla.TabIndex = 4
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
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "IngresoID"
            Me.DataGridViewTextBoxColumn3.DividerWidth = 1
            Me.DataGridViewTextBoxColumn3.HeaderText = "IngresoID"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Visible = False
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "CodigoRP"
            Me.DataGridViewTextBoxColumn4.DividerWidth = 1
            Me.DataGridViewTextBoxColumn4.HeaderText = "Código"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Width = 80
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.DataGridViewTextBoxColumn7.DataPropertyName = "GrillaApellidosNombres"
            Me.DataGridViewTextBoxColumn7.DividerWidth = 1
            Me.DataGridViewTextBoxColumn7.HeaderText = "Apellidos y Nombre(s)"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            Me.DataGridViewTextBoxColumn7.Width = 123
            '
            'DataGridViewTextBoxColumn15
            '
            Me.DataGridViewTextBoxColumn15.DataPropertyName = "NacionalidadNombre"
            Me.DataGridViewTextBoxColumn15.HeaderText = "Nacionalidad"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.ReadOnly = True
            Me.DataGridViewTextBoxColumn15.Width = 70
            '
            'DataGridViewTextBoxColumn11
            '
            Me.DataGridViewTextBoxColumn11.DataPropertyName = "MovimientoTipoNombre"
            Me.DataGridViewTextBoxColumn11.HeaderText = "Movimiento / Modalidad"
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.ReadOnly = True
            Me.DataGridViewTextBoxColumn11.Width = 150
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.DataPropertyName = "IngresoNro"
            Me.DataGridViewTextBoxColumn9.HeaderText = "Nº Ing."
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.ReadOnly = True
            Me.DataGridViewTextBoxColumn9.Width = 63
            '
            'col_fec_cla
            '
            Me.col_fec_cla.DataPropertyName = "ClasificacionFecha"
            DataGridViewCellStyle1.Format = "d"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.col_fec_cla.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_fec_cla.HeaderText = "F. Clasificación"
            Me.col_fec_cla.Name = "col_fec_cla"
            Me.col_fec_cla.ReadOnly = True
            Me.col_fec_cla.Width = 110
            Me.col_fec_cla.Visible = False
            '
            'col_pen_des_clas
            '
            Me.col_pen_des_clas.DataPropertyName = "ClasificacionPenalNombre"
            DataGridViewCellStyle2.Format = "d"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.col_pen_des_clas.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_pen_des_clas.HeaderText = "Penal Clasif. (Destino)"
            Me.col_pen_des_clas.Name = "col_pen_des_clas"
            Me.col_pen_des_clas.ReadOnly = True
            Me.col_pen_des_clas.Width = 150
            Me.col_pen_des_clas.Visible = False
            '
            'DataGridViewTextBoxColumn16
            '
            Me.DataGridViewTextBoxColumn16.DataPropertyName = "AutoridadJudicialNombre"
            Me.DataGridViewTextBoxColumn16.HeaderText = "Autoridad"
            Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
            Me.DataGridViewTextBoxColumn16.ReadOnly = True
            Me.DataGridViewTextBoxColumn16.Width = 150
            '
            'col_exp
            '
            Me.col_exp.DataPropertyName = "DocumJudicialNum"
            Me.col_exp.HeaderText = "Nº Expediente / Oficio"
            Me.col_exp.Name = "col_exp"
            Me.col_exp.ReadOnly = True
            Me.col_exp.Width = 150
            '
            'col_doc_cla
            '
            Me.col_doc_cla.DataPropertyName = "ClasificacionPenalOficio"
            Me.col_doc_cla.HeaderText = "ClasificacionPenalOficio"
            Me.col_doc_cla.Name = "col_doc_cla"
            Me.col_doc_cla.ReadOnly = True
            Me.col_doc_cla.Visible = False
            '
            'uscBusquedaCarceleta
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Name = "uscBusquedaCarceleta"
            Me.Size = New System.Drawing.Size(963, 453)
            Me.pnlCabecera.ResumeLayout(False)
            Me.gbBusqueda.ResumeLayout(False)
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.grbClasificacion.ResumeLayout(False)
            Me.grbClasificacion.PerformLayout()
            Me.grbFiltro.ResumeLayout(False)
            Me.grbFiltro.PerformLayout()
            Me.grbTipoMov.ResumeLayout(False)
            Me.grbTipoMov.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents grbTipoMov As System.Windows.Forms.GroupBox
        Friend WithEvents rdbMovTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbTraslado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbNuevo As System.Windows.Forms.RadioButton
        Friend WithEvents txtNombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApellidos As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents grbFiltro As System.Windows.Forms.GroupBox
        Friend WithEvents rdbFClasificacion As System.Windows.Forms.RadioButton
        Friend WithEvents rdbFIngreso As System.Windows.Forms.RadioButton
        Friend WithEvents grbClasificacion As System.Windows.Forms.GroupBox
        Friend WithEvents rdbClasificacionTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbPorClasificar As System.Windows.Forms.RadioButton
        Friend WithEvents rdbClasificados As System.Windows.Forms.RadioButton
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents grbEstado As System.Windows.Forms.GroupBox
        Friend WithEvents rdbEstadoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInactivo As System.Windows.Forms.RadioButton
        Friend WithEvents rdbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents col_reg_id_mov As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id_mov As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_mov As DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_cla As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_des_clas As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
        Friend WithEvents col_exp As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_cla As DataGridViewTextBoxColumn
    End Class
End Namespace