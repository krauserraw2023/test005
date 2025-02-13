Namespace Visita.Visitante
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscar
        Inherits Legolas.APPUIComponents.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.UscFoto1 = New APPControls.Foto.uscFotografia()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.txtVisnom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtVisapemat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtVisNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtVisapepat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.rdbSexoTodos = New System.Windows.Forms.RadioButton()
            Me.rdbMuj = New System.Windows.Forms.RadioButton()
            Me.rdbHom = New System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rdbNacTodos = New System.Windows.Forms.RadioButton()
            Me.rdbExtranjero = New System.Windows.Forms.RadioButton()
            Me.rdbPeruano = New System.Windows.Forms.RadioButton()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.pnlExportar = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlModificar = New System.Windows.Forms.Panel()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.pnlNuevo = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.lblSegundo = New System.Windows.Forms.Label()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.UsrRegionPenal1 = New APPControls.usrRegionPenal()
            Me.col_vis_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nac_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_val_reniec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tiene_huella = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mano_izq = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mano_der = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_fot = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlExportar.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlModificar.SuspendLayout()
            Me.pnlNuevo.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.BackColor = System.Drawing.Color.Transparent
            Me.pnlBusqueda.Controls.Add(Me.GroupBox4)
            Me.pnlBusqueda.Controls.Add(Me.grbBuscar)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 50)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1156, 223)
            Me.pnlBusqueda.TabIndex = 73
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox4.Controls.Add(Me.Panel1)
            Me.GroupBox4.Controls.Add(Me.GroupBox8)
            Me.GroupBox4.Controls.Add(Me.GroupBox3)
            Me.GroupBox4.Controls.Add(Me.GroupBox2)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(1073, 223)
            Me.GroupBox4.TabIndex = 65
            Me.GroupBox4.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.UscFoto1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(914, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(156, 204)
            Me.Panel1.TabIndex = 68
            '
            'UscFoto1
            '
            Me.UscFoto1._CheckImagen = False
            Me.UscFoto1._EnabledDobleClick = True
            Me.UscFoto1._HasImagen = False
            Me.UscFoto1._PanelAutorizacion = False
            Me.UscFoto1._PanelCheck = True
            Me.UscFoto1.Location = New System.Drawing.Point(3, 3)
            Me.UscFoto1.Name = "UscFoto1"
            Me.UscFoto1.Size = New System.Drawing.Size(150, 198)
            Me.UscFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFoto1.TabIndex = 66
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.txtVisnom)
            Me.GroupBox8.Controls.Add(Me.Label5)
            Me.GroupBox8.Controls.Add(Me.txtVisapemat)
            Me.GroupBox8.Controls.Add(Me.Label2)
            Me.GroupBox8.Controls.Add(Me.Label4)
            Me.GroupBox8.Controls.Add(Me.txtVisNumDoc)
            Me.GroupBox8.Controls.Add(Me.txtVisapepat)
            Me.GroupBox8.Controls.Add(Me.Label1)
            Me.GroupBox8.Location = New System.Drawing.Point(10, 13)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(238, 113)
            Me.GroupBox8.TabIndex = 61
            Me.GroupBox8.TabStop = False
            '
            'txtVisnom
            '
            Me.txtVisnom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtVisnom._BloquearPaste = False
            Me.txtVisnom._SeleccionarTodo = False
            Me.txtVisnom.Location = New System.Drawing.Point(97, 87)
            Me.txtVisnom.Name = "txtVisnom"
            Me.txtVisnom.Size = New System.Drawing.Size(130, 20)
            Me.txtVisnom.TabIndex = 37
            Me.txtVisnom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtVisnom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(12, 90)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 13)
            Me.Label5.TabIndex = 39
            Me.Label5.Text = "Nombres :"
            '
            'txtVisapemat
            '
            Me.txtVisapemat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtVisapemat._BloquearPaste = False
            Me.txtVisapemat._SeleccionarTodo = False
            Me.txtVisapemat.Location = New System.Drawing.Point(97, 61)
            Me.txtVisapemat.Name = "txtVisapemat"
            Me.txtVisapemat.Size = New System.Drawing.Size(130, 20)
            Me.txtVisapemat.TabIndex = 36
            Me.txtVisapemat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtVisapemat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 64)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(77, 13)
            Me.Label2.TabIndex = 37
            Me.Label2.Text = "Ape. Materno :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(12, 14)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(76, 13)
            Me.Label4.TabIndex = 35
            Me.Label4.Text = "Numero Doc. :"
            '
            'txtVisNumDoc
            '
            Me.txtVisNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtVisNumDoc._BloquearPaste = False
            Me.txtVisNumDoc._SeleccionarTodo = False
            Me.txtVisNumDoc.Location = New System.Drawing.Point(97, 11)
            Me.txtVisNumDoc.Name = "txtVisNumDoc"
            Me.txtVisNumDoc.Size = New System.Drawing.Size(82, 20)
            Me.txtVisNumDoc.TabIndex = 34
            Me.txtVisNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtVisNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtVisapepat
            '
            Me.txtVisapepat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtVisapepat._BloquearPaste = False
            Me.txtVisapepat._SeleccionarTodo = False
            Me.txtVisapepat.Location = New System.Drawing.Point(97, 37)
            Me.txtVisapepat.Name = "txtVisapepat"
            Me.txtVisapepat.Size = New System.Drawing.Size(130, 20)
            Me.txtVisapepat.TabIndex = 35
            Me.txtVisapepat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtVisapepat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 40)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(75, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Ape. Paterno :"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.rdbSexoTodos)
            Me.GroupBox3.Controls.Add(Me.rdbMuj)
            Me.GroupBox3.Controls.Add(Me.rdbHom)
            Me.GroupBox3.Location = New System.Drawing.Point(10, 132)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(238, 40)
            Me.GroupBox3.TabIndex = 67
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Sexo"
            '
            'rdbSexoTodos
            '
            Me.rdbSexoTodos.AutoSize = True
            Me.rdbSexoTodos.Checked = True
            Me.rdbSexoTodos.Location = New System.Drawing.Point(175, 16)
            Me.rdbSexoTodos.Name = "rdbSexoTodos"
            Me.rdbSexoTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbSexoTodos.TabIndex = 2
            Me.rdbSexoTodos.TabStop = True
            Me.rdbSexoTodos.Text = "Todos"
            Me.rdbSexoTodos.UseVisualStyleBackColor = True
            '
            'rdbMuj
            '
            Me.rdbMuj.AutoSize = True
            Me.rdbMuj.Location = New System.Drawing.Point(91, 16)
            Me.rdbMuj.Name = "rdbMuj"
            Me.rdbMuj.Size = New System.Drawing.Size(62, 17)
            Me.rdbMuj.TabIndex = 1
            Me.rdbMuj.Text = "Mujeres"
            Me.rdbMuj.UseVisualStyleBackColor = True
            '
            'rdbHom
            '
            Me.rdbHom.AutoSize = True
            Me.rdbHom.Location = New System.Drawing.Point(9, 16)
            Me.rdbHom.Name = "rdbHom"
            Me.rdbHom.Size = New System.Drawing.Size(67, 17)
            Me.rdbHom.TabIndex = 0
            Me.rdbHom.Text = "Hombres"
            Me.rdbHom.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rdbNacTodos)
            Me.GroupBox2.Controls.Add(Me.rdbExtranjero)
            Me.GroupBox2.Controls.Add(Me.rdbPeruano)
            Me.GroupBox2.Location = New System.Drawing.Point(10, 177)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(238, 40)
            Me.GroupBox2.TabIndex = 66
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Nacionalidad"
            '
            'rdbNacTodos
            '
            Me.rdbNacTodos.AutoSize = True
            Me.rdbNacTodos.Checked = True
            Me.rdbNacTodos.Location = New System.Drawing.Point(175, 16)
            Me.rdbNacTodos.Name = "rdbNacTodos"
            Me.rdbNacTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbNacTodos.TabIndex = 2
            Me.rdbNacTodos.TabStop = True
            Me.rdbNacTodos.Text = "Todos"
            Me.rdbNacTodos.UseVisualStyleBackColor = True
            '
            'rdbExtranjero
            '
            Me.rdbExtranjero.AutoSize = True
            Me.rdbExtranjero.Location = New System.Drawing.Point(91, 16)
            Me.rdbExtranjero.Name = "rdbExtranjero"
            Me.rdbExtranjero.Size = New System.Drawing.Size(77, 17)
            Me.rdbExtranjero.TabIndex = 1
            Me.rdbExtranjero.Text = "Extranjeros"
            Me.rdbExtranjero.UseVisualStyleBackColor = True
            '
            'rdbPeruano
            '
            Me.rdbPeruano.AutoSize = True
            Me.rdbPeruano.Location = New System.Drawing.Point(9, 16)
            Me.rdbPeruano.Name = "rdbPeruano"
            Me.rdbPeruano.Size = New System.Drawing.Size(70, 17)
            Me.rdbPeruano.TabIndex = 0
            Me.rdbPeruano.Text = "Peruanos"
            Me.rdbPeruano.UseVisualStyleBackColor = True
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(1073, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(83, 223)
            Me.grbBuscar.TabIndex = 62
            Me.grbBuscar.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 198)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 22)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 204)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(75, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'tsbLimpiar
            '
            Me.tsbLimpiar.BackColor = System.Drawing.Color.Transparent
            Me.tsbLimpiar.Image = Global.SIPPOPE.My.Resources.Resources.replace2
            Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiar.Name = "tsbLimpiar"
            Me.tsbLimpiar.Size = New System.Drawing.Size(75, 43)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiar.ToolTipText = "Limpiar"
            '
            'Timer1
            '
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Controls.Add(Me.pnlReporte)
            Me.Panel2.Controls.Add(Me.pnlExportar)
            Me.Panel2.Controls.Add(Me.pnlEliminar)
            Me.Panel2.Controls.Add(Me.pnlModificar)
            Me.Panel2.Controls.Add(Me.pnlNuevo)
            Me.Panel2.Controls.Add(Me.lblSegundo)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 446)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1156, 48)
            Me.Panel2.TabIndex = 74
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSalir.Location = New System.Drawing.Point(486, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(95, 48)
            Me.pnlSalir.TabIndex = 86
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(2, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 40)
            Me.btnSalir.TabIndex = 66
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnReporte)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlReporte.Location = New System.Drawing.Point(391, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(95, 48)
            Me.pnlReporte.TabIndex = 85
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnReporte.Location = New System.Drawing.Point(2, 4)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(91, 40)
            Me.btnReporte.TabIndex = 81
            Me.btnReporte.Text = "&Reporte"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'pnlExportar
            '
            Me.pnlExportar.Controls.Add(Me.btnExportar)
            Me.pnlExportar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlExportar.Location = New System.Drawing.Point(296, 0)
            Me.pnlExportar.Name = "pnlExportar"
            Me.pnlExportar.Size = New System.Drawing.Size(95, 48)
            Me.pnlExportar.TabIndex = 84
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(2, 4)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 65
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(201, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(95, 48)
            Me.pnlEliminar.TabIndex = 91
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(3, 4)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(88, 40)
            Me.btnEliminar.TabIndex = 90
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlModificar
            '
            Me.pnlModificar.Controls.Add(Me.btnModificar)
            Me.pnlModificar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlModificar.Location = New System.Drawing.Point(95, 0)
            Me.pnlModificar.Name = "pnlModificar"
            Me.pnlModificar.Size = New System.Drawing.Size(106, 48)
            Me.pnlModificar.TabIndex = 83
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
            Me.btnModificar.Location = New System.Drawing.Point(2, 4)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(98, 40)
            Me.btnModificar.TabIndex = 64
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'pnlNuevo
            '
            Me.pnlNuevo.Controls.Add(Me.btnNuevo)
            Me.pnlNuevo.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlNuevo.Location = New System.Drawing.Point(0, 0)
            Me.pnlNuevo.Name = "pnlNuevo"
            Me.pnlNuevo.Size = New System.Drawing.Size(95, 48)
            Me.pnlNuevo.TabIndex = 82
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.Location = New System.Drawing.Point(2, 4)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(88, 40)
            Me.btnNuevo.TabIndex = 63
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'lblSegundo
            '
            Me.lblSegundo.AutoSize = True
            Me.lblSegundo.Location = New System.Drawing.Point(760, 31)
            Me.lblSegundo.Name = "lblSegundo"
            Me.lblSegundo.Size = New System.Drawing.Size(49, 13)
            Me.lblSegundo.TabIndex = 35
            Me.lblSegundo.Text = "00:00:00"
            Me.lblSegundo.Visible = False
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_vis_id, Me.Column4, Me.Column3, Me.col_ape_pat, Me.col_ape_mat, Me.col_nom, Me.Column5, Me.col_edad, Me.col_nac_nom, Me.col_val_reniec, Me.col_tiene_huella, Me.col_mano_izq, Me.col_mano_der, Me.col_reg_id, Me.col_vis_fot, Me.col_reg_nom, Me.col_pen_id, Me.col_pen_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 273)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1156, 173)
            Me.dgwGrilla.TabIndex = 72
            Me.dgwGrilla.VisibleCampos = False
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.UsrRegionPenal1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1156, 50)
            Me.GroupBox1.TabIndex = 75
            Me.GroupBox1.TabStop = False
            '
            'UsrRegionPenal1
            '
            Me.UsrRegionPenal1._LicenciaID = -1
            Me.UsrRegionPenal1._PenalID = 0
            Me.UsrRegionPenal1._PenalTodos = True
            Me.UsrRegionPenal1._RegionID = 0
            Me.UsrRegionPenal1._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.Usuario
            Me.UsrRegionPenal1._UsuarioID = -1
            Me.UsrRegionPenal1._WidthLabelRegion = 47
            Me.UsrRegionPenal1.BackColor = System.Drawing.Color.Transparent
            Me.UsrRegionPenal1.Location = New System.Drawing.Point(10, 17)
            Me.UsrRegionPenal1.Name = "UsrRegionPenal1"
            Me.UsrRegionPenal1.Size = New System.Drawing.Size(465, 22)
            Me.UsrRegionPenal1.TabIndex = 66
            Me.UsrRegionPenal1.WidthRegion = 224
            '
            'col_vis_id
            '
            Me.col_vis_id.DataPropertyName = "Codigo"
            Me.col_vis_id.DividerWidth = 1
            Me.col_vis_id.HeaderText = "VisitanteID"
            Me.col_vis_id.Name = "col_vis_id"
            Me.col_vis_id.ReadOnly = True
            Me.col_vis_id.Visible = False
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "TipoDocumentoNombre"
            Me.Column4.HeaderText = "Tipo Doc."
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 90
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "NumeroDocumento"
            Me.Column3.HeaderText = "N° Doc."
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 70
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_ape_pat.DividerWidth = 1
            Me.col_ape_pat.HeaderText = "Paterno"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_ape_mat.HeaderText = "Materno"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "SexoNombre"
            Me.Column5.HeaderText = "Sexo"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 50
            '
            'col_edad
            '
            Me.col_edad.DataPropertyName = "EdadString"
            Me.col_edad.HeaderText = "Edad"
            Me.col_edad.Name = "col_edad"
            Me.col_edad.ReadOnly = True
            Me.col_edad.Width = 50
            '
            'col_nac_nom
            '
            Me.col_nac_nom.DataPropertyName = "NacionalidadNombre"
            Me.col_nac_nom.HeaderText = "Nacionalidad"
            Me.col_nac_nom.Name = "col_nac_nom"
            Me.col_nac_nom.ReadOnly = True
            '
            'col_val_reniec
            '
            Me.col_val_reniec.DataPropertyName = "ValidadoReniecReadonly"
            Me.col_val_reniec.HeaderText = "Val. x Reniec"
            Me.col_val_reniec.Name = "col_val_reniec"
            Me.col_val_reniec.ReadOnly = True
            '
            'col_tiene_huella
            '
            Me.col_tiene_huella.DataPropertyName = "VisitanteTieneHuellaReadonly"
            Me.col_tiene_huella.HeaderText = "Huella"
            Me.col_tiene_huella.Name = "col_tiene_huella"
            Me.col_tiene_huella.ReadOnly = True
            Me.col_tiene_huella.Width = 60
            '
            'col_mano_izq
            '
            Me.col_mano_izq.DataPropertyName = "ManoIzquierda"
            Me.col_mano_izq.DividerWidth = 1
            Me.col_mano_izq.HeaderText = "Mano Izq."
            Me.col_mano_izq.Name = "col_mano_izq"
            Me.col_mano_izq.ReadOnly = True
            Me.col_mano_izq.Visible = False
            '
            'col_mano_der
            '
            Me.col_mano_der.DataPropertyName = "ManoDerecha"
            Me.col_mano_der.DividerWidth = 1
            Me.col_mano_der.HeaderText = "Mano Der."
            Me.col_mano_der.Name = "col_mano_der"
            Me.col_mano_der.ReadOnly = True
            Me.col_mano_der.Visible = False
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
            Me.col_reg_id.DividerWidth = 1
            Me.col_reg_id.HeaderText = "RegionID"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_vis_fot
            '
            Me.col_vis_fot.DataPropertyName = "FotoName"
            Me.col_vis_fot.DividerWidth = 1
            Me.col_vis_fot.HeaderText = "fotoname"
            Me.col_vis_fot.Name = "col_vis_fot"
            Me.col_vis_fot.ReadOnly = True
            Me.col_vis_fot.Visible = False
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "RegionNombre"
            Me.col_reg_nom.HeaderText = "Region"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            Me.col_reg_nom.Visible = False
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.DividerWidth = 1
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            Me.col_pen_nom.Visible = False
            Me.col_pen_nom.Width = 150
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1156, 494)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "frmBuscar"
            Me.Text = "Visitantes"
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlSalir.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlExportar.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlModificar.ResumeLayout(False)
            Me.pnlNuevo.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtVisNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtVisapepat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents UscFoto1 As APPControls.Foto.uscFotografia
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbSexoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbMuj As System.Windows.Forms.RadioButton
        Friend WithEvents rdbHom As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbNacTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExtranjero As System.Windows.Forms.RadioButton
        Friend WithEvents rdbPeruano As System.Windows.Forms.RadioButton
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents txtVisnom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtVisapemat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents UsrRegionPenal1 As APPControls.usrRegionPenal
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents lblSegundo As System.Windows.Forms.Label
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents pnlExportar As System.Windows.Forms.Panel
        Friend WithEvents pnlModificar As System.Windows.Forms.Panel
        Friend WithEvents pnlNuevo As System.Windows.Forms.Panel
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents col_vis_id As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As DataGridViewTextBoxColumn
        Friend WithEvents col_nom As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewTextBoxColumn
        Friend WithEvents col_edad As DataGridViewTextBoxColumn
        Friend WithEvents col_nac_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_val_reniec As DataGridViewTextBoxColumn
        Friend WithEvents col_tiene_huella As DataGridViewTextBoxColumn
        Friend WithEvents col_mano_izq As DataGridViewTextBoxColumn
        Friend WithEvents col_mano_der As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As DataGridViewTextBoxColumn
        Friend WithEvents col_vis_fot As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
    End Class
End Namespace