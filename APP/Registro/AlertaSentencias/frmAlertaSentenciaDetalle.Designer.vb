Namespace Registro.AlertaSentencias
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmAlertaSentenciaDetalle
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlertaSentenciaDetalle))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBoton = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.pnlNuevoReniec = New System.Windows.Forms.Panel()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnDetalleInterno = New System.Windows.Forms.Button()
            Me.pnlVerLibro = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnFicha = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.ToolTipMensaje = New System.Windows.Forms.ToolTip(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbbCorrelativo = New System.Windows.Forms.ComboBox()
            Me.grbEstado = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbVencido = New System.Windows.Forms.RadioButton()
            Me.rdbPendiente = New System.Windows.Forms.RadioButton()
            Me.dtpFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.lblPenal = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.lblTitulosentencia = New System.Windows.Forms.Label()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.lblechavencimiento = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
            Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.dgwAlertasentencia = New Legolas.APPUIComponents.myDatagridView()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_lib = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_doc_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProlongacionIniDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SecretarioNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_not_sen_dias_res = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_not_sen_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_not_sen_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBoton.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlVerLibro.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgwAlertasentencia, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlBoton
            '
            Me.pnlBoton.Controls.Add(Me.Panel3)
            Me.pnlBoton.Controls.Add(Me.pnlNuevoReniec)
            Me.pnlBoton.Controls.Add(Me.pnlEliminar)
            Me.pnlBoton.Controls.Add(Me.pnlVerLibro)
            Me.pnlBoton.Controls.Add(Me.pnlReporte)
            Me.pnlBoton.Controls.Add(Me.pnlSalir)
            Me.pnlBoton.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBoton.Location = New System.Drawing.Point(0, 518)
            Me.pnlBoton.Name = "pnlBoton"
            Me.pnlBoton.Size = New System.Drawing.Size(1277, 45)
            Me.pnlBoton.TabIndex = 2
            '
            'Panel3
            '
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(811, 45)
            Me.Panel3.TabIndex = 0
            '
            'pnlNuevoReniec
            '
            Me.pnlNuevoReniec.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlNuevoReniec.Location = New System.Drawing.Point(811, 0)
            Me.pnlNuevoReniec.Name = "pnlNuevoReniec"
            Me.pnlNuevoReniec.Size = New System.Drawing.Size(90, 45)
            Me.pnlNuevoReniec.TabIndex = 101
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnDetalleInterno)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminar.Location = New System.Drawing.Point(901, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(92, 45)
            Me.pnlEliminar.TabIndex = 99
            '
            'btnDetalleInterno
            '
            Me.btnDetalleInterno.Image = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnDetalleInterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnDetalleInterno.Location = New System.Drawing.Point(6, 4)
            Me.btnDetalleInterno.Name = "btnDetalleInterno"
            Me.btnDetalleInterno.Size = New System.Drawing.Size(81, 39)
            Me.btnDetalleInterno.TabIndex = 69
            Me.btnDetalleInterno.Text = "Ver Interno"
            Me.btnDetalleInterno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnDetalleInterno.UseVisualStyleBackColor = True
            '
            'pnlVerLibro
            '
            Me.pnlVerLibro.Controls.Add(Me.btnExportar)
            Me.pnlVerLibro.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlVerLibro.Location = New System.Drawing.Point(993, 0)
            Me.pnlVerLibro.Name = "pnlVerLibro"
            Me.pnlVerLibro.Size = New System.Drawing.Size(100, 45)
            Me.pnlVerLibro.TabIndex = 96
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(6, 4)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 67
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnFicha)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlReporte.Location = New System.Drawing.Point(1093, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(99, 45)
            Me.pnlReporte.TabIndex = 94
            '
            'btnFicha
            '
            Me.btnFicha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFicha.Image = CType(resources.GetObject("btnFicha.Image"), System.Drawing.Image)
            Me.btnFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFicha.Location = New System.Drawing.Point(4, 4)
            Me.btnFicha.Name = "btnFicha"
            Me.btnFicha.Size = New System.Drawing.Size(90, 40)
            Me.btnFicha.TabIndex = 0
            Me.btnFicha.Text = "&Reportes"
            Me.btnFicha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnFicha.UseVisualStyleBackColor = True
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(1192, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(85, 45)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(2, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.Location = New System.Drawing.Point(106, 3)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(97, 40)
            Me.Button1.TabIndex = 66
            Me.Button1.Text = "&Salir"
            Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.grbBuscar)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1277, 191)
            Me.Panel1.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cbbCorrelativo)
            Me.GroupBox1.Controls.Add(Me.grbEstado)
            Me.GroupBox1.Controls.Add(Me.dtpFecha)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.cbbRegion)
            Me.GroupBox1.Controls.Add(Me.cbbPenal)
            Me.GroupBox1.Controls.Add(Me.lblPenal)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 30)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1123, 112)
            Me.GroupBox1.TabIndex = 17
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Filtro"
            '
            'cbbCorrelativo
            '
            Me.cbbCorrelativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbCorrelativo.FormattingEnabled = True
            Me.cbbCorrelativo.Location = New System.Drawing.Point(284, 58)
            Me.cbbCorrelativo.Name = "cbbCorrelativo"
            Me.cbbCorrelativo.Size = New System.Drawing.Size(60, 21)
            Me.cbbCorrelativo.TabIndex = 28
            '
            'grbEstado
            '
            Me.grbEstado.Controls.Add(Me.rdbTodos)
            Me.grbEstado.Controls.Add(Me.rdbVencido)
            Me.grbEstado.Controls.Add(Me.rdbPendiente)
            Me.grbEstado.Location = New System.Drawing.Point(364, 52)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(414, 54)
            Me.grbEstado.TabIndex = 27
            Me.grbEstado.TabStop = False
            Me.grbEstado.Text = "Estado de condena"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Location = New System.Drawing.Point(278, 24)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbTodos.TabIndex = 8
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "[Todos]"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbVencido
            '
            Me.rdbVencido.AutoSize = True
            Me.rdbVencido.Location = New System.Drawing.Point(147, 24)
            Me.rdbVencido.Name = "rdbVencido"
            Me.rdbVencido.Size = New System.Drawing.Size(69, 17)
            Me.rdbVencido.TabIndex = 7
            Me.rdbVencido.Text = "Vencidas"
            Me.rdbVencido.UseVisualStyleBackColor = True
            '
            'rdbPendiente
            '
            Me.rdbPendiente.AutoSize = True
            Me.rdbPendiente.Location = New System.Drawing.Point(24, 24)
            Me.rdbPendiente.Name = "rdbPendiente"
            Me.rdbPendiente.Size = New System.Drawing.Size(77, 17)
            Me.rdbPendiente.TabIndex = 6
            Me.rdbPendiente.Text = "Por vencer"
            Me.rdbPendiente.UseVisualStyleBackColor = True
            '
            'dtpFecha
            '
            Me.dtpFecha.Location = New System.Drawing.Point(177, 58)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpFecha.TabIndex = 24
            Me.dtpFecha.Value = "/  /"
            Me.dtpFecha.ValueLong = CType(0, Long)
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(35, 62)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(130, 13)
            Me.Label2.TabIndex = 23
            Me.Label2.Text = "Fecha y hora de consulta:"
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
            Me.cbbRegion.Location = New System.Drawing.Point(112, 19)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(232, 22)
            Me.cbbRegion.TabIndex = 5
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
            Me.cbbPenal.Location = New System.Drawing.Point(503, 19)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(232, 22)
            Me.cbbPenal.TabIndex = 7
            '
            'lblPenal
            '
            Me.lblPenal.AutoSize = True
            Me.lblPenal.Location = New System.Drawing.Point(372, 23)
            Me.lblPenal.Name = "lblPenal"
            Me.lblPenal.Size = New System.Drawing.Size(123, 13)
            Me.lblPenal.TabIndex = 6
            Me.lblPenal.Text = "Eestablecimiento Penal :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(10, 24)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(88, 13)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Oficina Regional:"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.lblEstado)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.lblTitulosentencia)
            Me.GroupBox2.Controls.Add(Me.lblTitulo)
            Me.GroupBox2.Controls.Add(Me.lblechavencimiento)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.GroupBox2.Location = New System.Drawing.Point(0, 142)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1123, 45)
            Me.GroupBox2.TabIndex = 15
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Datos de la cabecera"
            '
            'lblEstado
            '
            Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblEstado.Location = New System.Drawing.Point(970, 20)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(150, 15)
            Me.lblEstado.TabIndex = 34
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(804, 20)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(166, 13)
            Me.Label7.TabIndex = 33
            Me.Label7.Text = "Estado de notificación por correo:"
            '
            'lblTitulosentencia
            '
            Me.lblTitulosentencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblTitulosentencia.Location = New System.Drawing.Point(440, 20)
            Me.lblTitulosentencia.Name = "lblTitulosentencia"
            Me.lblTitulosentencia.Size = New System.Drawing.Size(360, 15)
            Me.lblTitulosentencia.TabIndex = 32
            '
            'lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.Location = New System.Drawing.Point(365, 20)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(72, 13)
            Me.lblTitulo.TabIndex = 31
            Me.lblTitulo.Text = "Nro. de Alerta"
            '
            'lblechavencimiento
            '
            Me.lblechavencimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblechavencimiento.Location = New System.Drawing.Point(268, 20)
            Me.lblechavencimiento.Name = "lblechavencimiento"
            Me.lblechavencimiento.Size = New System.Drawing.Size(90, 15)
            Me.lblechavencimiento.TabIndex = 30
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(47, 20)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(213, 13)
            Me.Label3.TabIndex = 29
            Me.Label3.Text = "Condenas con fecha de vencimiento hasta:"
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(1123, 30)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(150, 157)
            Me.grbBuscar.TabIndex = 13
            Me.grbBuscar.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 132)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(144, 22)
            Me.lblReg.TabIndex = 1
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbLimpiar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(144, 138)
            Me.ToolStrip1.TabIndex = 0
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(142, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'tsbLimpiar
            '
            Me.tsbLimpiar.BackColor = System.Drawing.Color.Transparent
            Me.tsbLimpiar.Image = CType(resources.GetObject("tsbLimpiar.Image"), System.Drawing.Image)
            Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiar.Name = "tsbLimpiar"
            Me.tsbLimpiar.Size = New System.Drawing.Size(142, 43)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiar.ToolTipText = "Limpiar"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1273, 30)
            Me.Panel2.TabIndex = 12
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(462, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(670, 16)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "LISTA DE ALERTAS POR CERCANÍA DE CUMPLIMIENTO DE CONDENA (Proyectada a 30 días)"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dgwAlertasentencia
            '
            Me.dgwAlertasentencia.AllowUserToAddRows = False
            Me.dgwAlertasentencia.AllowUserToDeleteRows = False
            Me.dgwAlertasentencia.AllowUserToResizeRows = False
            Me.dgwAlertasentencia.BackgroundColor = System.Drawing.Color.White
            Me.dgwAlertasentencia.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwAlertasentencia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwAlertasentencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwAlertasentencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.col_int_id, Me.Column4, Me.col_cod_lib, Me.Column5, Me.Column3, Me.Column6, Me.col_tip_doc_jud, Me.Column1, Me.Column10, Me.Column2, Me.ProlongacionIniDate, Me.SecretarioNombre, Me.col_not_sen_dias_res, Me.col_not_sen_est_id, Me.col_not_sen_est})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwAlertasentencia.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwAlertasentencia.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwAlertasentencia.GridColor = System.Drawing.Color.LightGray
            Me.dgwAlertasentencia.Location = New System.Drawing.Point(0, 191)
            Me.dgwAlertasentencia.MultiSelect = False
            Me.dgwAlertasentencia.Name = "dgwAlertasentencia"
            Me.dgwAlertasentencia.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwAlertasentencia.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwAlertasentencia.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwAlertasentencia.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwAlertasentencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwAlertasentencia.Size = New System.Drawing.Size(1277, 327)
            Me.dgwAlertasentencia.TabIndex = 5
            Me.dgwAlertasentencia.VisibleCampos = True
            '
            'Column7
            '
            Me.Column7.DataPropertyName = "_Region"
            Me.Column7.HeaderText = "Oficina Regional"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Width = 110
            '
            'Column8
            '
            Me.Column8.DataPropertyName = "_Penal"
            Me.Column8.HeaderText = "E.P."
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            Me.Column8.ToolTipText = "Establecimiento Penitenciario"
            Me.Column8.Width = 110
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoId"
            Me.col_int_id.HeaderText = "InternoId"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "CodigoRP"
            Me.Column4.HeaderText = "Código del interno"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 80
            '
            'col_cod_lib
            '
            Me.col_cod_lib.DataPropertyName = "ApellidoPaterno"
            Me.col_cod_lib.DividerWidth = 1
            Me.col_cod_lib.HeaderText = "Primer apellido"
            Me.col_cod_lib.Name = "col_cod_lib"
            Me.col_cod_lib.ReadOnly = True
            Me.col_cod_lib.Width = 150
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "ApellidoMaterno"
            Me.Column5.HeaderText = "Segundo apellido"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 150
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "Nombres"
            Me.Column3.HeaderText = "Pre nombres"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 150
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "Nacionalidad"
            Me.Column6.HeaderText = "Nacionalidad"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Visible = False
            Me.Column6.Width = 150
            '
            'col_tip_doc_jud
            '
            Me.col_tip_doc_jud.DataPropertyName = "DocumentoJudTipo"
            Me.col_tip_doc_jud.HeaderText = "Tipo de documento"
            Me.col_tip_doc_jud.Name = "col_tip_doc_jud"
            Me.col_tip_doc_jud.ReadOnly = True
            Me.col_tip_doc_jud.Width = 110
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "ExpedienteNumero"
            Me.Column1.HeaderText = "N° de expediente"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 150
            '
            'Column10
            '
            Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Column10.DataPropertyName = "DelitoNombre"
            Me.Column10.HeaderText = "Delito"
            Me.Column10.Name = "Column10"
            Me.Column10.ReadOnly = True
            Me.Column10.Width = 120
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "TiempoCondena"
            Me.Column2.HeaderText = "Tiempo de condena"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 150
            '
            'ProlongacionIniDate
            '
            Me.ProlongacionIniDate.DataPropertyName = "PeriodoInicialStr"
            Me.ProlongacionIniDate.HeaderText = "Fecha de inicio"
            Me.ProlongacionIniDate.Name = "ProlongacionIniDate"
            Me.ProlongacionIniDate.ReadOnly = True
            '
            'SecretarioNombre
            '
            Me.SecretarioNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.SecretarioNombre.DataPropertyName = "PeriodoFinalStr"
            Me.SecretarioNombre.HeaderText = "Fecha de vencimiento"
            Me.SecretarioNombre.Name = "SecretarioNombre"
            Me.SecretarioNombre.ReadOnly = True
            '
            'col_not_sen_dias_res
            '
            Me.col_not_sen_dias_res.DataPropertyName = "Tiemporestante"
            Me.col_not_sen_dias_res.HeaderText = "Dias restantes"
            Me.col_not_sen_dias_res.Name = "col_not_sen_dias_res"
            Me.col_not_sen_dias_res.ReadOnly = True
            Me.col_not_sen_dias_res.Width = 80
            '
            'col_not_sen_est_id
            '
            Me.col_not_sen_est_id.DataPropertyName = "EstadoId"
            Me.col_not_sen_est_id.HeaderText = "EstadoId"
            Me.col_not_sen_est_id.Name = "col_not_sen_est_id"
            Me.col_not_sen_est_id.ReadOnly = True
            Me.col_not_sen_est_id.Visible = False
            '
            'col_not_sen_est
            '
            Me.col_not_sen_est.DataPropertyName = "Estado"
            Me.col_not_sen_est.HeaderText = "Estado de condena"
            Me.col_not_sen_est.Name = "col_not_sen_est"
            Me.col_not_sen_est.ReadOnly = True
            Me.col_not_sen_est.Width = 80
            '
            'frmAlertaSentenciaDetalle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1277, 563)
            Me.Controls.Add(Me.dgwAlertasentencia)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.pnlBoton)
            Me.Name = "frmAlertaSentenciaDetalle"
            Me.Text = "Lista de sentencias por atender"
            Me.ToolTipMensaje.SetToolTip(Me, "Activar estado del Interno")
            Me.pnlBoton.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlVerLibro.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgwAlertasentencia, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBoton As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents ToolTipMensaje As System.Windows.Forms.ToolTip
        Friend WithEvents btnFicha As System.Windows.Forms.Button
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
        Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
        Friend WithEvents pnlVerLibro As Panel
        Friend WithEvents Panel3 As Panel
        Friend WithEvents pnlNuevoReniec As Panel
        Friend WithEvents pnlEliminar As Panel
        Friend WithEvents dgwAlertasentencia As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents btnExportar As Button
        Friend WithEvents btnDetalleInterno As Button
        Friend WithEvents grbBuscar As GroupBox
        Friend WithEvents lblReg As Label
        Public WithEvents ToolStrip1 As ToolStrip
        Public WithEvents tsbBuscar As ToolStripButton
        Public WithEvents tsbLimpiar As ToolStripButton
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents cbbCorrelativo As ComboBox
        Friend WithEvents grbEstado As GroupBox
        Friend WithEvents rdbTodos As RadioButton
        Friend WithEvents rdbVencido As RadioButton
        Friend WithEvents rdbPendiente As RadioButton
        Friend WithEvents dtpFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label2 As Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents lblPenal As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents lblTitulo As Label
        Friend WithEvents lblechavencimiento As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents lblEstado As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents lblTitulosentencia As Label
        Friend WithEvents Column7 As DataGridViewTextBoxColumn
        Friend WithEvents Column8 As DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_lib As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents Column6 As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_doc_jud As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents Column10 As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents ProlongacionIniDate As DataGridViewTextBoxColumn
        Friend WithEvents SecretarioNombre As DataGridViewTextBoxColumn
        Friend WithEvents col_not_sen_dias_res As DataGridViewTextBoxColumn
        Friend WithEvents col_not_sen_est_id As DataGridViewTextBoxColumn
        Friend WithEvents col_not_sen_est As DataGridViewTextBoxColumn
    End Class
End Namespace