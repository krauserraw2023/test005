Namespace Registro.Sentencias
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscDetallRegistroSentencia_v2
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlTituloExpediente = New System.Windows.Forms.Panel()
            Me.pnlExpeMant = New System.Windows.Forms.Panel()
            Me.btnAddExp = New System.Windows.Forms.Button()
            Me.btnEditExpe = New System.Windows.Forms.Button()
            Me.pnlAnularExpediente = New System.Windows.Forms.Panel()
            Me.btnEliminarExp = New System.Windows.Forms.Button()
            Me.lblNroExpedientes = New System.Windows.Forms.Label()
            Me.pnlInmpMant = New System.Windows.Forms.Panel()
            Me.lblEstablecimientomental = New System.Windows.Forms.Label()
            Me.btnInimputable = New System.Windows.Forms.Button()
            Me.pnlTiempoConde = New System.Windows.Forms.Panel()
            Me.gbDuracioncondena = New System.Windows.Forms.GroupBox()
            Me.rbtCadenaperpetua = New System.Windows.Forms.RadioButton()
            Me.rbtTemporal = New System.Windows.Forms.RadioButton()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtMeses = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtAnios = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDias = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.gbComputo = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpFechaFinal = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.pnlAgravMant = New System.Windows.Forms.Panel()
            Me.btnEditPerCond = New System.Windows.Forms.Button()
            Me.btnAddPerCond = New System.Windows.Forms.Button()
            Me.pnlMantBotPeriCondena = New System.Windows.Forms.Panel()
            Me.pnlEliminarAgraviado = New System.Windows.Forms.Panel()
            Me.btnDelPerCond = New System.Windows.Forms.Button()
            Me.dgvPeriodoCondena = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ped_cond_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.pnlMantBotAgraviados = New System.Windows.Forms.Panel()
            Me.btnAddDelito = New System.Windows.Forms.Button()
            Me.btnEditDelito = New System.Windows.Forms.Button()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.btnDelDelito = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.dgwExpediente = New Legolas.APPUIComponents.myDatagridView()
            Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_exp_ref = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jdu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sit_jur = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_aut_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_secre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_eliminar = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_id_tip_imim = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_cen_sal_men = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.dgwDelito = New System.Windows.Forms.DataGridView()
            Me.col_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_tip_sen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_sent = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_btn = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_agrav_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_delito_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_del_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlTituloExpediente.SuspendLayout()
            Me.pnlExpeMant.SuspendLayout()
            Me.pnlAnularExpediente.SuspendLayout()
            Me.pnlInmpMant.SuspendLayout()
            Me.pnlTiempoConde.SuspendLayout()
            Me.gbDuracioncondena.SuspendLayout()
            Me.gbComputo.SuspendLayout()
            Me.pnlAgravMant.SuspendLayout()
            Me.pnlMantBotPeriCondena.SuspendLayout()
            Me.pnlEliminarAgraviado.SuspendLayout()
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.pnlMantBotAgraviados.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.Panel5.SuspendLayout()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel7.SuspendLayout()
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlTituloExpediente
            '
            Me.pnlTituloExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTituloExpediente.Controls.Add(Me.pnlExpeMant)
            Me.pnlTituloExpediente.Controls.Add(Me.pnlAnularExpediente)
            Me.pnlTituloExpediente.Controls.Add(Me.lblNroExpedientes)
            Me.pnlTituloExpediente.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTituloExpediente.Location = New System.Drawing.Point(0, 0)
            Me.pnlTituloExpediente.Name = "pnlTituloExpediente"
            Me.pnlTituloExpediente.Size = New System.Drawing.Size(570, 28)
            Me.pnlTituloExpediente.TabIndex = 0
            '
            'pnlExpeMant
            '
            Me.pnlExpeMant.Controls.Add(Me.btnAddExp)
            Me.pnlExpeMant.Controls.Add(Me.btnEditExpe)
            Me.pnlExpeMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExpeMant.Location = New System.Drawing.Point(395, 0)
            Me.pnlExpeMant.Name = "pnlExpeMant"
            Me.pnlExpeMant.Size = New System.Drawing.Size(139, 26)
            Me.pnlExpeMant.TabIndex = 1
            '
            'btnAddExp
            '
            Me.btnAddExp.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddExp.Location = New System.Drawing.Point(79, 1)
            Me.btnAddExp.Name = "btnAddExp"
            Me.btnAddExp.Size = New System.Drawing.Size(30, 24)
            Me.btnAddExp.TabIndex = 0
            Me.btnAddExp.UseVisualStyleBackColor = True
            '
            'btnEditExpe
            '
            Me.btnEditExpe.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditExpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditExpe.Location = New System.Drawing.Point(109, 1)
            Me.btnEditExpe.Name = "btnEditExpe"
            Me.btnEditExpe.Size = New System.Drawing.Size(30, 24)
            Me.btnEditExpe.TabIndex = 1
            Me.btnEditExpe.UseVisualStyleBackColor = True
            '
            'pnlAnularExpediente
            '
            Me.pnlAnularExpediente.Controls.Add(Me.btnEliminarExp)
            Me.pnlAnularExpediente.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAnularExpediente.Location = New System.Drawing.Point(534, 0)
            Me.pnlAnularExpediente.Name = "pnlAnularExpediente"
            Me.pnlAnularExpediente.Size = New System.Drawing.Size(34, 26)
            Me.pnlAnularExpediente.TabIndex = 2
            '
            'btnEliminarExp
            '
            Me.btnEliminarExp.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarExp.Location = New System.Drawing.Point(2, 1)
            Me.btnEliminarExp.Name = "btnEliminarExp"
            Me.btnEliminarExp.Size = New System.Drawing.Size(30, 24)
            Me.btnEliminarExp.TabIndex = 0
            Me.btnEliminarExp.UseVisualStyleBackColor = True
            '
            'lblNroExpedientes
            '
            Me.lblNroExpedientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblNroExpedientes.AutoSize = True
            Me.lblNroExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroExpedientes.Location = New System.Drawing.Point(0, 6)
            Me.lblNroExpedientes.Name = "lblNroExpedientes"
            Me.lblNroExpedientes.Size = New System.Drawing.Size(126, 13)
            Me.lblNroExpedientes.TabIndex = 0
            Me.lblNroExpedientes.Text = "Expedientes : 0 Reg."
            '
            'pnlInmpMant
            '
            Me.pnlInmpMant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlInmpMant.Controls.Add(Me.lblEstablecimientomental)
            Me.pnlInmpMant.Controls.Add(Me.btnInimputable)
            Me.pnlInmpMant.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlInmpMant.Location = New System.Drawing.Point(0, 0)
            Me.pnlInmpMant.Name = "pnlInmpMant"
            Me.pnlInmpMant.Size = New System.Drawing.Size(231, 27)
            Me.pnlInmpMant.TabIndex = 3
            Me.pnlInmpMant.Visible = False
            '
            'lblEstablecimientomental
            '
            Me.lblEstablecimientomental.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblEstablecimientomental.AutoSize = True
            Me.lblEstablecimientomental.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstablecimientomental.Location = New System.Drawing.Point(30, 6)
            Me.lblEstablecimientomental.Name = "lblEstablecimientomental"
            Me.lblEstablecimientomental.Size = New System.Drawing.Size(164, 13)
            Me.lblEstablecimientomental.TabIndex = 19
            Me.lblEstablecimientomental.Text = "Establecimiento de salud mental: "
            Me.lblEstablecimientomental.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnInimputable
            '
            Me.btnInimputable.BackgroundImage = Global.APPControls.My.Resources.Resources.hospital
            Me.btnInimputable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnInimputable.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnInimputable.Location = New System.Drawing.Point(196, 0)
            Me.btnInimputable.Name = "btnInimputable"
            Me.btnInimputable.Size = New System.Drawing.Size(33, 25)
            Me.btnInimputable.TabIndex = 18
            Me.ToolTip1.SetToolTip(Me.btnInimputable, "Agregar información sobre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el lugar donde deberia cumplir la medida" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de seguridad" &
        ".")
            Me.btnInimputable.UseVisualStyleBackColor = True
            '
            'pnlTiempoConde
            '
            Me.pnlTiempoConde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlTiempoConde.Controls.Add(Me.gbDuracioncondena)
            Me.pnlTiempoConde.Controls.Add(Me.pnlInmpMant)
            Me.pnlTiempoConde.Controls.Add(Me.gbComputo)
            Me.pnlTiempoConde.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlTiempoConde.Location = New System.Drawing.Point(570, 0)
            Me.pnlTiempoConde.Name = "pnlTiempoConde"
            Me.pnlTiempoConde.Size = New System.Drawing.Size(235, 136)
            Me.pnlTiempoConde.TabIndex = 2
            '
            'gbDuracioncondena
            '
            Me.gbDuracioncondena.Controls.Add(Me.rbtCadenaperpetua)
            Me.gbDuracioncondena.Controls.Add(Me.rbtTemporal)
            Me.gbDuracioncondena.Controls.Add(Me.Label8)
            Me.gbDuracioncondena.Controls.Add(Me.txtMeses)
            Me.gbDuracioncondena.Controls.Add(Me.Label4)
            Me.gbDuracioncondena.Controls.Add(Me.txtAnios)
            Me.gbDuracioncondena.Controls.Add(Me.txtDias)
            Me.gbDuracioncondena.Controls.Add(Me.Label7)
            Me.gbDuracioncondena.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbDuracioncondena.Location = New System.Drawing.Point(0, 27)
            Me.gbDuracioncondena.Name = "gbDuracioncondena"
            Me.gbDuracioncondena.Size = New System.Drawing.Size(231, 55)
            Me.gbDuracioncondena.TabIndex = 9
            Me.gbDuracioncondena.TabStop = False
            Me.gbDuracioncondena.Text = "Duración de la condena"
            '
            'rbtCadenaperpetua
            '
            Me.rbtCadenaperpetua.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.rbtCadenaperpetua.AutoSize = True
            Me.rbtCadenaperpetua.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtCadenaperpetua.Location = New System.Drawing.Point(15, 33)
            Me.rbtCadenaperpetua.Name = "rbtCadenaperpetua"
            Me.rbtCadenaperpetua.Size = New System.Drawing.Size(93, 16)
            Me.rbtCadenaperpetua.TabIndex = 7
            Me.rbtCadenaperpetua.Text = "Cadena perpetua"
            Me.rbtCadenaperpetua.UseVisualStyleBackColor = True
            '
            'rbtTemporal
            '
            Me.rbtTemporal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.rbtTemporal.AutoSize = True
            Me.rbtTemporal.Checked = True
            Me.rbtTemporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtTemporal.Location = New System.Drawing.Point(15, 15)
            Me.rbtTemporal.Name = "rbtTemporal"
            Me.rbtTemporal.Size = New System.Drawing.Size(61, 16)
            Me.rbtTemporal.TabIndex = 6
            Me.rbtTemporal.TabStop = True
            Me.rbtTemporal.Text = "Temporal"
            Me.rbtTemporal.UseVisualStyleBackColor = True
            '
            'Label8
            '
            Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(197, 15)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(24, 12)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Dias"
            '
            'txtMeses
            '
            Me.txtMeses._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMeses._BloquearPaste = False
            Me.txtMeses._SeleccionarTodo = False
            Me.txtMeses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMeses.Location = New System.Drawing.Point(163, 29)
            Me.txtMeses.MaxLength = 3
            Me.txtMeses.Name = "txtMeses"
            Me.txtMeses.Size = New System.Drawing.Size(24, 20)
            Me.txtMeses.TabIndex = 3
            Me.txtMeses.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMeses.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(126, 15)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(27, 12)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Años"
            '
            'txtAnios
            '
            Me.txtAnios._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAnios._BloquearPaste = False
            Me.txtAnios._SeleccionarTodo = False
            Me.txtAnios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtAnios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnios.Location = New System.Drawing.Point(128, 29)
            Me.txtAnios.MaxLength = 2
            Me.txtAnios.Name = "txtAnios"
            Me.txtAnios.Size = New System.Drawing.Size(24, 20)
            Me.txtAnios.TabIndex = 1
            Me.txtAnios.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAnios.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtDias
            '
            Me.txtDias._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDias._BloquearPaste = False
            Me.txtDias._SeleccionarTodo = False
            Me.txtDias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDias.Location = New System.Drawing.Point(197, 29)
            Me.txtDias.MaxLength = 5
            Me.txtDias.Name = "txtDias"
            Me.txtDias.Size = New System.Drawing.Size(24, 20)
            Me.txtDias.TabIndex = 5
            Me.txtDias.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDias.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(157, 16)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(34, 12)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "Meses"
            '
            'gbComputo
            '
            Me.gbComputo.Controls.Add(Me.Label10)
            Me.gbComputo.Controls.Add(Me.dtpFechaInicio)
            Me.gbComputo.Controls.Add(Me.dtpFechaFinal)
            Me.gbComputo.Controls.Add(Me.Label6)
            Me.gbComputo.Controls.Add(Me.pnlAgravMant)
            Me.gbComputo.Controls.Add(Me.pnlMantBotPeriCondena)
            Me.gbComputo.Controls.Add(Me.dgvPeriodoCondena)
            Me.gbComputo.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gbComputo.Location = New System.Drawing.Point(0, 82)
            Me.gbComputo.Name = "gbComputo"
            Me.gbComputo.Size = New System.Drawing.Size(231, 50)
            Me.gbComputo.TabIndex = 8
            Me.gbComputo.TabStop = False
            Me.gbComputo.Text = "Cómputo"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(147, 14)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(38, 12)
            Me.Label10.TabIndex = 10
            Me.Label10.Text = "F. vcto:"
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaInicio.Location = New System.Drawing.Point(53, 27)
            Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInicio.TabIndex = 9
            Me.dtpFechaInicio.Value = "/  /"
            Me.dtpFechaInicio.ValueLong = CType(0, Long)
            '
            'dtpFechaFinal
            '
            Me.dtpFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFinal.Location = New System.Drawing.Point(145, 27)
            Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaFinal.Name = "dtpFechaFinal"
            Me.dtpFechaFinal.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFinal.TabIndex = 11
            Me.dtpFechaFinal.Value = "/  /"
            Me.dtpFechaFinal.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(55, 14)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(41, 12)
            Me.Label6.TabIndex = 8
            Me.Label6.Text = "F. Inicio:"
            '
            'pnlAgravMant
            '
            Me.pnlAgravMant.Controls.Add(Me.btnEditPerCond)
            Me.pnlAgravMant.Controls.Add(Me.btnAddPerCond)
            Me.pnlAgravMant.Location = New System.Drawing.Point(192, 22)
            Me.pnlAgravMant.Name = "pnlAgravMant"
            Me.pnlAgravMant.Size = New System.Drawing.Size(34, 52)
            Me.pnlAgravMant.TabIndex = 3
            Me.pnlAgravMant.Visible = False
            '
            'btnEditPerCond
            '
            Me.btnEditPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditPerCond.Location = New System.Drawing.Point(2, 24)
            Me.btnEditPerCond.Name = "btnEditPerCond"
            Me.btnEditPerCond.Size = New System.Drawing.Size(30, 26)
            Me.btnEditPerCond.TabIndex = 1
            Me.btnEditPerCond.UseVisualStyleBackColor = True
            '
            'btnAddPerCond
            '
            Me.btnAddPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddPerCond.Location = New System.Drawing.Point(2, 0)
            Me.btnAddPerCond.Name = "btnAddPerCond"
            Me.btnAddPerCond.Size = New System.Drawing.Size(30, 24)
            Me.btnAddPerCond.TabIndex = 0
            Me.btnAddPerCond.UseVisualStyleBackColor = True
            Me.btnAddPerCond.Visible = False
            '
            'pnlMantBotPeriCondena
            '
            Me.pnlMantBotPeriCondena.Controls.Add(Me.pnlEliminarAgraviado)
            Me.pnlMantBotPeriCondena.Location = New System.Drawing.Point(6, 36)
            Me.pnlMantBotPeriCondena.Name = "pnlMantBotPeriCondena"
            Me.pnlMantBotPeriCondena.Size = New System.Drawing.Size(34, 38)
            Me.pnlMantBotPeriCondena.TabIndex = 7
            Me.pnlMantBotPeriCondena.Visible = False
            '
            'pnlEliminarAgraviado
            '
            Me.pnlEliminarAgraviado.Controls.Add(Me.btnDelPerCond)
            Me.pnlEliminarAgraviado.Location = New System.Drawing.Point(3, 6)
            Me.pnlEliminarAgraviado.Name = "pnlEliminarAgraviado"
            Me.pnlEliminarAgraviado.Size = New System.Drawing.Size(34, 26)
            Me.pnlEliminarAgraviado.TabIndex = 2
            '
            'btnDelPerCond
            '
            Me.btnDelPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelPerCond.Location = New System.Drawing.Point(3, 3)
            Me.btnDelPerCond.Name = "btnDelPerCond"
            Me.btnDelPerCond.Size = New System.Drawing.Size(31, 24)
            Me.btnDelPerCond.TabIndex = 3
            Me.btnDelPerCond.UseVisualStyleBackColor = True
            '
            'dgvPeriodoCondena
            '
            Me.dgvPeriodoCondena.AllowUserToAddRows = False
            Me.dgvPeriodoCondena.AllowUserToDeleteRows = False
            Me.dgvPeriodoCondena.AllowUserToResizeRows = False
            Me.dgvPeriodoCondena.BackgroundColor = System.Drawing.Color.White
            Me.dgvPeriodoCondena.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPeriodoCondena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPeriodoCondena.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ped_cond_item, Me.col_cod, Me.col_ini, Me.col_fin, Me.col_doc_jud_id, Me.col_eliminado})
            Me.dgvPeriodoCondena.GridColor = System.Drawing.Color.LightGray
            Me.dgvPeriodoCondena.Location = New System.Drawing.Point(195, 19)
            Me.dgvPeriodoCondena.MultiSelect = False
            Me.dgvPeriodoCondena.Name = "dgvPeriodoCondena"
            Me.dgvPeriodoCondena.ReadOnly = True
            Me.dgvPeriodoCondena.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvPeriodoCondena.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvPeriodoCondena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgvPeriodoCondena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPeriodoCondena.Size = New System.Drawing.Size(29, 23)
            Me.dgvPeriodoCondena.TabIndex = 2
            Me.dgvPeriodoCondena.Visible = False
            Me.dgvPeriodoCondena.VisibleCampos = True
            '
            'col_ped_cond_item
            '
            Me.col_ped_cond_item.DataPropertyName = "PeriodoCondenaItem"
            Me.col_ped_cond_item.DividerWidth = 1
            Me.col_ped_cond_item.HeaderText = "PerCondItem"
            Me.col_ped_cond_item.Name = "col_ped_cond_item"
            Me.col_ped_cond_item.ReadOnly = True
            Me.col_ped_cond_item.Visible = False
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "Codigo"
            Me.col_cod.HeaderText = "Codigo"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            Me.col_cod.Visible = False
            Me.col_cod.Width = 50
            '
            'col_ini
            '
            Me.col_ini.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_ini.DataPropertyName = "FechaInicioString"
            DataGridViewCellStyle1.Format = "d"
            DataGridViewCellStyle1.NullValue = "00/00/0000"
            Me.col_ini.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_ini.HeaderText = "F. Inicio"
            Me.col_ini.Name = "col_ini"
            Me.col_ini.ReadOnly = True
            '
            'col_fin
            '
            Me.col_fin.DataPropertyName = "FechaFinString"
            DataGridViewCellStyle2.Format = "d"
            DataGridViewCellStyle2.NullValue = "00/00/0000"
            Me.col_fin.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_fin.HeaderText = "F. vcto."
            Me.col_fin.Name = "col_fin"
            Me.col_fin.ReadOnly = True
            Me.col_fin.Width = 85
            '
            'col_doc_jud_id
            '
            Me.col_doc_jud_id.DataPropertyName = "DocJudicialId"
            Me.col_doc_jud_id.DividerWidth = 1
            Me.col_doc_jud_id.HeaderText = "DocJudId"
            Me.col_doc_jud_id.Name = "col_doc_jud_id"
            Me.col_doc_jud_id.ReadOnly = True
            Me.col_doc_jud_id.Visible = False
            Me.col_doc_jud_id.Width = 30
            '
            'col_eliminado
            '
            Me.col_eliminado.DataPropertyName = "FlgEliminado"
            Me.col_eliminado.DividerWidth = 1
            Me.col_eliminado.HeaderText = "Eliminado"
            Me.col_eliminado.Name = "col_eliminado"
            Me.col_eliminado.ReadOnly = True
            Me.col_eliminado.Visible = False
            '
            'Panel3
            '
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.pnlMantBotAgraviados)
            Me.Panel3.Controls.Add(Me.Panel6)
            Me.Panel3.Controls.Add(Me.Label1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(805, 22)
            Me.Panel3.TabIndex = 0
            '
            'pnlMantBotAgraviados
            '
            Me.pnlMantBotAgraviados.Controls.Add(Me.btnAddDelito)
            Me.pnlMantBotAgraviados.Controls.Add(Me.btnEditDelito)
            Me.pnlMantBotAgraviados.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlMantBotAgraviados.Location = New System.Drawing.Point(701, 0)
            Me.pnlMantBotAgraviados.Name = "pnlMantBotAgraviados"
            Me.pnlMantBotAgraviados.Size = New System.Drawing.Size(65, 20)
            Me.pnlMantBotAgraviados.TabIndex = 1
            '
            'btnAddDelito
            '
            Me.btnAddDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddDelito.Location = New System.Drawing.Point(2, -3)
            Me.btnAddDelito.Name = "btnAddDelito"
            Me.btnAddDelito.Size = New System.Drawing.Size(30, 24)
            Me.btnAddDelito.TabIndex = 0
            Me.btnAddDelito.UseVisualStyleBackColor = True
            '
            'btnEditDelito
            '
            Me.btnEditDelito.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditDelito.Location = New System.Drawing.Point(34, -3)
            Me.btnEditDelito.Name = "btnEditDelito"
            Me.btnEditDelito.Size = New System.Drawing.Size(30, 24)
            Me.btnEditDelito.TabIndex = 1
            Me.btnEditDelito.UseVisualStyleBackColor = True
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.btnDelDelito)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel6.Location = New System.Drawing.Point(766, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(37, 20)
            Me.Panel6.TabIndex = 2
            '
            'btnDelDelito
            '
            Me.btnDelDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelDelito.Location = New System.Drawing.Point(3, -3)
            Me.btnDelDelito.Name = "btnDelDelito"
            Me.btnDelDelito.Size = New System.Drawing.Size(30, 24)
            Me.btnDelDelito.TabIndex = 0
            Me.btnDelDelito.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(115, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Delitos/Agraviados"
            '
            'Panel5
            '
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.dgwExpediente)
            Me.Panel5.Controls.Add(Me.pnlTituloExpediente)
            Me.Panel5.Controls.Add(Me.pnlTiempoConde)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel5.Location = New System.Drawing.Point(0, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(807, 138)
            Me.Panel5.TabIndex = 0
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.AllowUserToDeleteRows = False
            Me.dgwExpediente.AllowUserToResizeRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            Me.dgwExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sel, Me.col_exp_ref, Me.col_item, Me.codigo, Me.col_doc_jdu_id, Me.col_num_exp, Me.col_sit_jur, Me.col_aut_jud, Me.col_sal_jud, Me.col_secre, Me.col_flag, Me.col_eliminar, Me.col_id_tip_imim, Me.col_id_cen_sal_men})
            Me.dgwExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwExpediente.GridColor = System.Drawing.Color.LightGray
            Me.dgwExpediente.Location = New System.Drawing.Point(0, 28)
            Me.dgwExpediente.MultiSelect = False
            Me.dgwExpediente.Name = "dgwExpediente"
            Me.dgwExpediente.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwExpediente.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwExpediente.Size = New System.Drawing.Size(570, 108)
            Me.dgwExpediente.TabIndex = 1
            Me.dgwExpediente.VisibleCampos = True
            '
            'col_sel
            '
            Me.col_sel.HeaderText = "Elegir"
            Me.col_sel.Name = "col_sel"
            Me.col_sel.Visible = False
            Me.col_sel.Width = 40
            '
            'col_exp_ref
            '
            Me.col_exp_ref.DataPropertyName = "ExpedienteRefIcon"
            Me.col_exp_ref.HeaderText = "Ref."
            Me.col_exp_ref.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_exp_ref.Name = "col_exp_ref"
            Me.col_exp_ref.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_exp_ref.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_exp_ref.Width = 26
            '
            'col_item
            '
            Me.col_item.DataPropertyName = "ExpedienteItem"
            Me.col_item.HeaderText = "ExpeItem"
            Me.col_item.Name = "col_item"
            Me.col_item.Visible = False
            Me.col_item.Width = 25
            '
            'codigo
            '
            Me.codigo.DataPropertyName = "Codigo"
            Me.codigo.DividerWidth = 1
            Me.codigo.HeaderText = "Codigo"
            Me.codigo.Name = "codigo"
            Me.codigo.ReadOnly = True
            Me.codigo.Visible = False
            '
            'col_doc_jdu_id
            '
            Me.col_doc_jdu_id.DataPropertyName = "CreaDocJudicialId"
            Me.col_doc_jdu_id.DividerWidth = 1
            Me.col_doc_jdu_id.HeaderText = "DocJudicialId"
            Me.col_doc_jdu_id.Name = "col_doc_jdu_id"
            Me.col_doc_jdu_id.ReadOnly = True
            Me.col_doc_jdu_id.Visible = False
            '
            'col_num_exp
            '
            Me.col_num_exp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_num_exp.DataPropertyName = "ExpedienteNumero"
            Me.col_num_exp.HeaderText = "N° Exp."
            Me.col_num_exp.Name = "col_num_exp"
            Me.col_num_exp.ReadOnly = True
            '
            'col_sit_jur
            '
            Me.col_sit_jur.DataPropertyName = "SituacionJuridicaNombre"
            Me.col_sit_jur.HeaderText = "Sit. Juridica"
            Me.col_sit_jur.Name = "col_sit_jur"
            Me.col_sit_jur.ReadOnly = True
            Me.col_sit_jur.Visible = False
            Me.col_sit_jur.Width = 50
            '
            'col_aut_jud
            '
            Me.col_aut_jud.DataPropertyName = "AutoridadJudicialNombre"
            Me.col_aut_jud.HeaderText = "Distrito Judicial"
            Me.col_aut_jud.Name = "col_aut_jud"
            Me.col_aut_jud.ReadOnly = True
            Me.col_aut_jud.Width = 230
            '
            'col_sal_jud
            '
            Me.col_sal_jud.DataPropertyName = "SalaJudicialNombre"
            Me.col_sal_jud.HeaderText = "Aut. Judicial"
            Me.col_sal_jud.Name = "col_sal_jud"
            Me.col_sal_jud.ReadOnly = True
            Me.col_sal_jud.Width = 230
            '
            'col_secre
            '
            Me.col_secre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_secre.DataPropertyName = "ExpedienteSecretario"
            Me.col_secre.HeaderText = "Secretario"
            Me.col_secre.Name = "col_secre"
            Me.col_secre.ReadOnly = True
            '
            'col_flag
            '
            Me.col_flag.DataPropertyName = "Flagrancia"
            Me.col_flag.HeaderText = "C.F."
            Me.col_flag.Name = "col_flag"
            Me.col_flag.Width = 30
            '
            'col_eliminar
            '
            Me.col_eliminar.DataPropertyName = "Eliminar"
            Me.col_eliminar.HeaderText = ""
            Me.col_eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_eliminar.Name = "col_eliminar"
            Me.col_eliminar.ReadOnly = True
            Me.col_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_eliminar.Visible = False
            Me.col_eliminar.Width = 35
            '
            'col_id_tip_imim
            '
            Me.col_id_tip_imim.DataPropertyName = "MotivoIngresoID"
            Me.col_id_tip_imim.HeaderText = "MotivoIngresoID"
            Me.col_id_tip_imim.Name = "col_id_tip_imim"
            Me.col_id_tip_imim.Visible = False
            '
            'col_id_cen_sal_men
            '
            Me.col_id_cen_sal_men.DataPropertyName = "EstablecimientomentalId"
            Me.col_id_cen_sal_men.HeaderText = "EstablecimientomentalId"
            Me.col_id_cen_sal_men.Name = "col_id_cen_sal_men"
            Me.col_id_cen_sal_men.Visible = False
            '
            'Panel7
            '
            Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel7.Controls.Add(Me.dgwDelito)
            Me.Panel7.Controls.Add(Me.Panel3)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel7.Location = New System.Drawing.Point(0, 138)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(807, 160)
            Me.Panel7.TabIndex = 1
            '
            'dgwDelito
            '
            Me.dgwDelito.AllowUserToAddRows = False
            Me.dgwDelito.AllowUserToDeleteRows = False
            Me.dgwDelito.AllowUserToResizeRows = False
            Me.dgwDelito.BackgroundColor = System.Drawing.Color.White
            Me.dgwDelito.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwDelito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDelito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nro, Me.col_int_del_id, Me.col_exp_id, Me.col_exp_item, Me.col_del_item, Me.col_del_esp_nom, Me.col_agrav, Me.col_id_tip_sen, Me.col_tip_sent, Me.col_agr_btn, Me.col_agrav_cod, Me.col_agrav_item, Me.col_agr_delito_item, Me.col_agr_exp_item, Me.col_del_obs, Me.col_nom_del_gen})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwDelito.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgwDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDelito.GridColor = System.Drawing.Color.LightGray
            Me.dgwDelito.Location = New System.Drawing.Point(0, 22)
            Me.dgwDelito.MultiSelect = False
            Me.dgwDelito.Name = "dgwDelito"
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwDelito.RowHeadersVisible = False
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDelito.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgwDelito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDelito.Size = New System.Drawing.Size(805, 136)
            Me.dgwDelito.TabIndex = 2
            '
            'col_nro
            '
            Me.col_nro.FillWeight = 150.0!
            Me.col_nro.Frozen = True
            Me.col_nro.HeaderText = "N°"
            Me.col_nro.Name = "col_nro"
            Me.col_nro.Width = 30
            '
            'col_int_del_id
            '
            Me.col_int_del_id.DataPropertyName = "Codigo"
            Me.col_int_del_id.HeaderText = "InternoDelitoId"
            Me.col_int_del_id.Name = "col_int_del_id"
            Me.col_int_del_id.ReadOnly = True
            Me.col_int_del_id.Visible = False
            Me.col_int_del_id.Width = 10
            '
            'col_exp_id
            '
            Me.col_exp_id.DataPropertyName = "ExpedienteId"
            Me.col_exp_id.HeaderText = "ExpeId"
            Me.col_exp_id.Name = "col_exp_id"
            Me.col_exp_id.ReadOnly = True
            Me.col_exp_id.Visible = False
            Me.col_exp_id.Width = 20
            '
            'col_exp_item
            '
            Me.col_exp_item.DataPropertyName = "ExpedienteItem"
            Me.col_exp_item.HeaderText = "ExpedienteItem"
            Me.col_exp_item.Name = "col_exp_item"
            Me.col_exp_item.ReadOnly = True
            Me.col_exp_item.Visible = False
            Me.col_exp_item.Width = 20
            '
            'col_del_item
            '
            Me.col_del_item.DataPropertyName = "DelitoItem"
            Me.col_del_item.HeaderText = "DelitoItem"
            Me.col_del_item.Name = "col_del_item"
            Me.col_del_item.ReadOnly = True
            Me.col_del_item.Visible = False
            Me.col_del_item.Width = 20
            '
            'col_del_esp_nom
            '
            Me.col_del_esp_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_del_esp_nom.DataPropertyName = "DelitoEspecificoNombre"
            Me.col_del_esp_nom.FillWeight = 69.16167!
            Me.col_del_esp_nom.HeaderText = "Delito Especifico"
            Me.col_del_esp_nom.Name = "col_del_esp_nom"
            Me.col_del_esp_nom.ReadOnly = True
            '
            'col_agrav
            '
            Me.col_agrav.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_agrav.FillWeight = 69.16167!
            Me.col_agrav.HeaderText = "Agraviado"
            Me.col_agrav.Name = "col_agrav"
            Me.col_agrav.ReadOnly = True
            '
            'col_id_tip_sen
            '
            Me.col_id_tip_sen.DataPropertyName = "TipoResolucionId"
            Me.col_id_tip_sen.HeaderText = "IDTipoSentencia"
            Me.col_id_tip_sen.Name = "col_id_tip_sen"
            Me.col_id_tip_sen.Visible = False
            '
            'col_tip_sent
            '
            Me.col_tip_sent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_tip_sent.DataPropertyName = "TipoResolucionNom"
            Me.col_tip_sent.FillWeight = 161.6767!
            Me.col_tip_sent.HeaderText = "Tipo de Sentencia"
            Me.col_tip_sent.Name = "col_tip_sent"
            Me.col_tip_sent.ReadOnly = True
            Me.col_tip_sent.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_tip_sent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_tip_sent.Width = 150
            '
            'col_agr_btn
            '
            Me.col_agr_btn.HeaderText = ""
            Me.col_agr_btn.Image = Global.APPControls.My.Resources.Resources.flechacombo
            Me.col_agr_btn.Name = "col_agr_btn"
            Me.col_agr_btn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_agr_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_agr_btn.Width = 20
            '
            'col_agrav_cod
            '
            Me.col_agrav_cod.HeaderText = "AgraviadoCodigo"
            Me.col_agrav_cod.Name = "col_agrav_cod"
            Me.col_agrav_cod.Visible = False
            Me.col_agrav_cod.Width = 25
            '
            'col_agrav_item
            '
            Me.col_agrav_item.HeaderText = "AgraviadoItem"
            Me.col_agrav_item.Name = "col_agrav_item"
            Me.col_agrav_item.ReadOnly = True
            Me.col_agrav_item.Visible = False
            Me.col_agrav_item.Width = 25
            '
            'col_agr_delito_item
            '
            Me.col_agr_delito_item.HeaderText = "AgraviadoDelitoItem"
            Me.col_agr_delito_item.Name = "col_agr_delito_item"
            Me.col_agr_delito_item.Visible = False
            Me.col_agr_delito_item.Width = 25
            '
            'col_agr_exp_item
            '
            Me.col_agr_exp_item.HeaderText = "AgraviadoExpItem"
            Me.col_agr_exp_item.Name = "col_agr_exp_item"
            Me.col_agr_exp_item.Visible = False
            Me.col_agr_exp_item.Width = 25
            '
            'col_del_obs
            '
            Me.col_del_obs.DataPropertyName = "Observacion"
            Me.col_del_obs.HeaderText = "Observacion"
            Me.col_del_obs.Name = "col_del_obs"
            Me.col_del_obs.ReadOnly = True
            Me.col_del_obs.Visible = False
            Me.col_del_obs.Width = 90
            '
            'col_nom_del_gen
            '
            Me.col_nom_del_gen.DataPropertyName = "DelitoGenericoNombre"
            Me.col_nom_del_gen.DividerWidth = 1
            Me.col_nom_del_gen.HeaderText = "Delito Generico"
            Me.col_nom_del_gen.Name = "col_nom_del_gen"
            Me.col_nom_del_gen.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.col_nom_del_gen.Visible = False
            Me.col_nom_del_gen.Width = 300
            '
            'DataGridViewImageColumn1
            '
            Me.DataGridViewImageColumn1.HeaderText = ""
            Me.DataGridViewImageColumn1.Image = Global.APPControls.My.Resources.Resources.flechacombo
            Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
            Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewImageColumn1.Width = 20
            '
            'uscDetallRegistroSentencia_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel7)
            Me.Controls.Add(Me.Panel5)
            Me.Name = "uscDetallRegistroSentencia_v2"
            Me.Size = New System.Drawing.Size(807, 298)
            Me.pnlTituloExpediente.ResumeLayout(False)
            Me.pnlTituloExpediente.PerformLayout()
            Me.pnlExpeMant.ResumeLayout(False)
            Me.pnlAnularExpediente.ResumeLayout(False)
            Me.pnlInmpMant.ResumeLayout(False)
            Me.pnlInmpMant.PerformLayout()
            Me.pnlTiempoConde.ResumeLayout(False)
            Me.gbDuracioncondena.ResumeLayout(False)
            Me.gbDuracioncondena.PerformLayout()
            Me.gbComputo.ResumeLayout(False)
            Me.gbComputo.PerformLayout()
            Me.pnlAgravMant.ResumeLayout(False)
            Me.pnlMantBotPeriCondena.ResumeLayout(False)
            Me.pnlEliminarAgraviado.ResumeLayout(False)
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.pnlMantBotAgraviados.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel7.ResumeLayout(False)
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlTiempoConde As System.Windows.Forms.Panel
        Friend WithEvents dgvPeriodoCondena As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents btnEditPerCond As System.Windows.Forms.Button
        Friend WithEvents btnAddPerCond As System.Windows.Forms.Button
        Friend WithEvents pnlEliminarAgraviado As System.Windows.Forms.Panel
        Friend WithEvents btnDelPerCond As System.Windows.Forms.Button
        Friend WithEvents pnlTituloExpediente As System.Windows.Forms.Panel
        Friend WithEvents lblNroExpedientes As System.Windows.Forms.Label
        Friend WithEvents btnEditExpe As System.Windows.Forms.Button
        Friend WithEvents pnlAnularExpediente As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarExp As System.Windows.Forms.Button
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents pnlMantBotAgraviados As System.Windows.Forms.Panel
        Friend WithEvents btnAddDelito As System.Windows.Forms.Button
        Friend WithEvents btnEditDelito As System.Windows.Forms.Button
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents btnDelDelito As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents pnlExpeMant As System.Windows.Forms.Panel
        Friend WithEvents btnAddExp As System.Windows.Forms.Button
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents dgwExpediente As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents dgwDelito As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
        Friend WithEvents col_nro As DataGridViewTextBoxColumn
        Friend WithEvents col_int_del_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_agrav As DataGridViewTextBoxColumn
        Friend WithEvents col_id_tip_sen As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_sent As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_btn As DataGridViewImageColumn
        Friend WithEvents col_agrav_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_agrav_item As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_delito_item As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_exp_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_obs As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_del_gen As DataGridViewTextBoxColumn
        Friend WithEvents gbComputo As GroupBox
        Friend WithEvents col_ped_cond_item As DataGridViewTextBoxColumn
        Friend WithEvents col_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_ini As DataGridViewTextBoxColumn
        Friend WithEvents col_fin As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_eliminado As DataGridViewTextBoxColumn
        Friend WithEvents pnlMantBotPeriCondena As Panel
        Friend WithEvents pnlAgravMant As Panel
        Friend WithEvents col_sel As DataGridViewCheckBoxColumn
        Friend WithEvents col_exp_ref As DataGridViewImageColumn
        Friend WithEvents col_item As DataGridViewTextBoxColumn
        Friend WithEvents codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jdu_id As DataGridViewTextBoxColumn
        Friend WithEvents col_num_exp As DataGridViewTextBoxColumn
        Friend WithEvents col_sit_jur As DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud As DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud As DataGridViewTextBoxColumn
        Friend WithEvents col_secre As DataGridViewTextBoxColumn
        Friend WithEvents col_flag As DataGridViewCheckBoxColumn
        Friend WithEvents col_eliminar As DataGridViewImageColumn
        Friend WithEvents col_id_tip_imim As DataGridViewTextBoxColumn
        Friend WithEvents col_id_cen_sal_men As DataGridViewTextBoxColumn
        Friend WithEvents pnlInmpMant As Panel
        Friend WithEvents btnInimputable As Button
        Friend WithEvents gbDuracioncondena As GroupBox
        Friend WithEvents rbtCadenaperpetua As RadioButton
        Friend WithEvents rbtTemporal As RadioButton
        Friend WithEvents Label8 As Label
        Friend WithEvents txtMeses As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents txtAnios As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDias As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents dtpFechaFinal As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblEstablecimientomental As Label
        Friend WithEvents ToolTip1 As ToolTip
    End Class
End Namespace