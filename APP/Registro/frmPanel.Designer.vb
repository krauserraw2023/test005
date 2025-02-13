Namespace Registro
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPanel
        Inherits Legolas.APPUIComponents.Form

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPanel))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnVer = New System.Windows.Forms.Button()
            Me.cbbpenal = New APPControls.uscComboParametrica()
            Me.cbbregion = New APPControls.uscComboParametrica()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgwsituacion = New System.Windows.Forms.DataGridView()
            Me.col_sex_sit = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sex_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mix = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sindata = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.dgwnroingreso = New System.Windows.Forms.DataGridView()
            Me.col_pel_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pel_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pel_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pel_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pel_3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pel_sindata = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.dgwPELIGROsidad = New System.Windows.Forms.DataGridView()
            Me.col_sex_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.dgwcapacidad = New System.Windows.Forms.DataGridView()
            Me.col_par_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_par_tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_par_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_par_cap = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_par_act = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgwingresos = New System.Windows.Forms.DataGridView()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mot_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.dte_ingresohasta = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dte_ingresodesde = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.txtcompletos = New System.Windows.Forms.TextBox()
            Me.txtincompletos = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.GroupBox10 = New System.Windows.Forms.GroupBox()
            Me.txttotal = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtmujer = New System.Windows.Forms.TextBox()
            Me.txthombre = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.lbltime = New System.Windows.Forms.Label()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.pnlTablero1 = New System.Windows.Forms.Panel()
            Me.grbDelito = New System.Windows.Forms.GroupBox()
            Me.grbNac = New System.Windows.Forms.GroupBox()
            Me.dgwnacionalidad = New System.Windows.Forms.DataGridView()
            Me.col_nac_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nac_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_hom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_muj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tot = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtNacHom = New System.Windows.Forms.TextBox()
            Me.txtNacMuj = New System.Windows.Forms.TextBox()
            Me.txtNacTot = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtnacionalidad = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtextranjero = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtperuana = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.pnlCuerpo = New System.Windows.Forms.Panel()
            Me.pnlIngreso = New System.Windows.Forms.Panel()
            Me.grnIngreso = New System.Windows.Forms.GroupBox()
            Me.pnlTablero = New System.Windows.Forms.Panel()
            Me.pnlTablero2 = New System.Windows.Forms.Panel()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgwsituacion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            CType(Me.dgwnroingreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgwPELIGROsidad, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox5.SuspendLayout()
            CType(Me.dgwcapacidad, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgwingresos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.GroupBox10.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlTablero1.SuspendLayout()
            Me.grbNac.SuspendLayout()
            CType(Me.dgwnacionalidad, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlCuerpo.SuspendLayout()
            Me.pnlIngreso.SuspendLayout()
            Me.grnIngreso.SuspendLayout()
            Me.pnlTablero.SuspendLayout()
            Me.pnlTablero2.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnVer)
            Me.GroupBox1.Controls.Add(Me.cbbpenal)
            Me.GroupBox1.Controls.Add(Me.cbbregion)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(511, 70)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "BUSQUEDA POR PENAL"
            '
            'btnVer
            '
            Me.btnVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnVer.Image = CType(resources.GetObject("btnVer.Image"), System.Drawing.Image)
            Me.btnVer.Location = New System.Drawing.Point(335, 13)
            Me.btnVer.Name = "btnVer"
            Me.btnVer.Size = New System.Drawing.Size(95, 51)
            Me.btnVer.TabIndex = 94
            Me.btnVer.Text = "&Mostrar"
            Me.btnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'cbbpenal
            '
            Me.cbbpenal._NoIndica = False
            Me.cbbpenal._Todos = False
            Me.cbbpenal._TodosMensaje = ""
            Me.cbbpenal._Visible_Add = False
            Me.cbbpenal._Visible_Buscar = False
            Me.cbbpenal._Visible_Eliminar = False
            Me.cbbpenal.CodigoPadre = -1
            Me.cbbpenal.ComboTipo = Type.Combo.ComboTipo.PenalUsuario
            Me.cbbpenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Mayuscula
            Me.cbbpenal.DropDownWidth = 268
            Me.cbbpenal.DropDownWidthAuto = False
            Me.cbbpenal.Location = New System.Drawing.Point(61, 44)
            Me.cbbpenal.Name = "cbbpenal"
            Me.cbbpenal.Parametro1 = -1
            Me.cbbpenal.Parametro2 = -1
            Me.cbbpenal.SelectedIndex = -1
            Me.cbbpenal.SelectedValue = 0
            Me.cbbpenal.Size = New System.Drawing.Size(268, 22)
            Me.cbbpenal.TabIndex = 4
            '
            'cbbregion
            '
            Me.cbbregion._NoIndica = False
            Me.cbbregion._Todos = False
            Me.cbbregion._TodosMensaje = ""
            Me.cbbregion._Visible_Add = False
            Me.cbbregion._Visible_Buscar = False
            Me.cbbregion._Visible_Eliminar = False
            Me.cbbregion.CodigoPadre = -1
            Me.cbbregion.ComboTipo = Type.Combo.ComboTipo.RegionUsuario
            Me.cbbregion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Mayuscula
            Me.cbbregion.DropDownWidth = 268
            Me.cbbregion.DropDownWidthAuto = False
            Me.cbbregion.Location = New System.Drawing.Point(61, 20)
            Me.cbbregion.Name = "cbbregion"
            Me.cbbregion.Parametro1 = -1
            Me.cbbregion.Parametro2 = -1
            Me.cbbregion.SelectedIndex = -1
            Me.cbbregion.SelectedValue = 0
            Me.cbbregion.Size = New System.Drawing.Size(268, 22)
            Me.cbbregion.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(7, 49)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(40, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Penal :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Región :"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dgwsituacion)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.GroupBox2.Location = New System.Drawing.Point(0, 130)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(260, 90)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "POR SITUACION JURIDICA :"
            '
            'dgwsituacion
            '
            Me.dgwsituacion.AllowUserToAddRows = False
            Me.dgwsituacion.AllowUserToDeleteRows = False
            Me.dgwsituacion.AllowUserToResizeRows = False
            Me.dgwsituacion.BackgroundColor = System.Drawing.Color.White
            Me.dgwsituacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwsituacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sex_sit, Me.col_sex_nom, Me.col_pro, Me.col_sen, Me.col_mix, Me.col_sindata})
            Me.dgwsituacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwsituacion.Location = New System.Drawing.Point(3, 16)
            Me.dgwsituacion.Name = "dgwsituacion"
            Me.dgwsituacion.ReadOnly = True
            Me.dgwsituacion.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            Me.dgwsituacion.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwsituacion.Size = New System.Drawing.Size(254, 71)
            Me.dgwsituacion.TabIndex = 0
            '
            'col_sex_sit
            '
            Me.col_sex_sit.DataPropertyName = "sex_id"
            Me.col_sex_sit.HeaderText = "sex_id"
            Me.col_sex_sit.Name = "col_sex_sit"
            Me.col_sex_sit.ReadOnly = True
            Me.col_sex_sit.Visible = False
            '
            'col_sex_nom
            '
            Me.col_sex_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_sex_nom.DataPropertyName = "sex_nom"
            Me.col_sex_nom.HeaderText = "Sexo"
            Me.col_sex_nom.Name = "col_sex_nom"
            Me.col_sex_nom.ReadOnly = True
            Me.col_sex_nom.Width = 56
            '
            'col_pro
            '
            Me.col_pro.DataPropertyName = "proc"
            Me.col_pro.HeaderText = "Proc."
            Me.col_pro.Name = "col_pro"
            Me.col_pro.ReadOnly = True
            Me.col_pro.Width = 60
            '
            'col_sen
            '
            Me.col_sen.DataPropertyName = "sent"
            Me.col_sen.HeaderText = "Sent."
            Me.col_sen.Name = "col_sen"
            Me.col_sen.ReadOnly = True
            Me.col_sen.Width = 60
            '
            'col_mix
            '
            Me.col_mix.DataPropertyName = "mixto"
            Me.col_mix.HeaderText = "Proc-Sent"
            Me.col_mix.Name = "col_mix"
            Me.col_mix.ReadOnly = True
            Me.col_mix.Width = 60
            '
            'col_sindata
            '
            Me.col_sindata.DataPropertyName = "sindata"
            Me.col_sindata.HeaderText = "Sin Dato"
            Me.col_sindata.Name = "col_sindata"
            Me.col_sindata.ReadOnly = True
            Me.col_sindata.Visible = False
            Me.col_sindata.Width = 50
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.dgwnroingreso)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.GroupBox3.Location = New System.Drawing.Point(0, 220)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(260, 90)
            Me.GroupBox3.TabIndex = 2
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "POR PELIGROSIDAD :"
            '
            'dgwnroingreso
            '
            Me.dgwnroingreso.AllowUserToAddRows = False
            Me.dgwnroingreso.AllowUserToDeleteRows = False
            Me.dgwnroingreso.AllowUserToResizeRows = False
            Me.dgwnroingreso.BackgroundColor = System.Drawing.Color.White
            Me.dgwnroingreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwnroingreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pel_id, Me.col_pel_nom, Me.col_pel_1, Me.col_pel_2, Me.col_pel_3, Me.col_pel_sindata})
            Me.dgwnroingreso.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwnroingreso.Location = New System.Drawing.Point(3, 16)
            Me.dgwnroingreso.Name = "dgwnroingreso"
            Me.dgwnroingreso.ReadOnly = True
            Me.dgwnroingreso.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            Me.dgwnroingreso.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwnroingreso.Size = New System.Drawing.Size(254, 71)
            Me.dgwnroingreso.TabIndex = 0
            '
            'col_pel_id
            '
            Me.col_pel_id.DataPropertyName = "col_sex_pel"
            Me.col_pel_id.HeaderText = "pel_id"
            Me.col_pel_id.Name = "col_pel_id"
            Me.col_pel_id.ReadOnly = True
            Me.col_pel_id.Visible = False
            '
            'col_pel_nom
            '
            Me.col_pel_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_pel_nom.DataPropertyName = "sex_nom"
            Me.col_pel_nom.HeaderText = "Sexo"
            Me.col_pel_nom.Name = "col_pel_nom"
            Me.col_pel_nom.ReadOnly = True
            Me.col_pel_nom.Width = 56
            '
            'col_pel_1
            '
            Me.col_pel_1.DataPropertyName = "minima"
            Me.col_pel_1.HeaderText = "Mínima"
            Me.col_pel_1.Name = "col_pel_1"
            Me.col_pel_1.ReadOnly = True
            Me.col_pel_1.Width = 60
            '
            'col_pel_2
            '
            Me.col_pel_2.DataPropertyName = "mediana"
            Me.col_pel_2.HeaderText = "Mediana"
            Me.col_pel_2.Name = "col_pel_2"
            Me.col_pel_2.ReadOnly = True
            Me.col_pel_2.Width = 60
            '
            'col_pel_3
            '
            Me.col_pel_3.DataPropertyName = "maxima"
            Me.col_pel_3.HeaderText = "Máxima"
            Me.col_pel_3.Name = "col_pel_3"
            Me.col_pel_3.ReadOnly = True
            Me.col_pel_3.Width = 60
            '
            'col_pel_sindata
            '
            Me.col_pel_sindata.DataPropertyName = "sindata"
            Me.col_pel_sindata.HeaderText = "Sin Dato"
            Me.col_pel_sindata.Name = "col_pel_sindata"
            Me.col_pel_sindata.ReadOnly = True
            Me.col_pel_sindata.Visible = False
            Me.col_pel_sindata.Width = 60
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.dgwPELIGROsidad)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.GroupBox4.Location = New System.Drawing.Point(0, 310)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(260, 90)
            Me.GroupBox4.TabIndex = 3
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "POR Nº INGRESOS :"
            '
            'dgwPELIGROsidad
            '
            Me.dgwPELIGROsidad.AllowUserToAddRows = False
            Me.dgwPELIGROsidad.AllowUserToDeleteRows = False
            Me.dgwPELIGROsidad.AllowUserToResizeRows = False
            Me.dgwPELIGROsidad.BackgroundColor = System.Drawing.Color.White
            Me.dgwPELIGROsidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwPELIGROsidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sex_ing, Me.col_ing_nom, Me.col_ing_1, Me.col_ing_2, Me.col_ing_4})
            Me.dgwPELIGROsidad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwPELIGROsidad.Location = New System.Drawing.Point(3, 16)
            Me.dgwPELIGROsidad.Name = "dgwPELIGROsidad"
            Me.dgwPELIGROsidad.ReadOnly = True
            Me.dgwPELIGROsidad.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            Me.dgwPELIGROsidad.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwPELIGROsidad.Size = New System.Drawing.Size(254, 71)
            Me.dgwPELIGROsidad.TabIndex = 0
            '
            'col_sex_ing
            '
            Me.col_sex_ing.DataPropertyName = "sex_id"
            Me.col_sex_ing.HeaderText = "sex_id"
            Me.col_sex_ing.Name = "col_sex_ing"
            Me.col_sex_ing.ReadOnly = True
            Me.col_sex_ing.Visible = False
            '
            'col_ing_nom
            '
            Me.col_ing_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_ing_nom.DataPropertyName = "sex_nom"
            Me.col_ing_nom.HeaderText = "Sexo"
            Me.col_ing_nom.Name = "col_ing_nom"
            Me.col_ing_nom.ReadOnly = True
            Me.col_ing_nom.Width = 56
            '
            'col_ing_1
            '
            Me.col_ing_1.DataPropertyName = "uno"
            Me.col_ing_1.HeaderText = "Primario"
            Me.col_ing_1.Name = "col_ing_1"
            Me.col_ing_1.ReadOnly = True
            Me.col_ing_1.Width = 60
            '
            'col_ing_2
            '
            Me.col_ing_2.DataPropertyName = "dos"
            Me.col_ing_2.HeaderText = "2 - 3"
            Me.col_ing_2.Name = "col_ing_2"
            Me.col_ing_2.ReadOnly = True
            Me.col_ing_2.Width = 60
            '
            'col_ing_4
            '
            Me.col_ing_4.DataPropertyName = "cuatro"
            Me.col_ing_4.HeaderText = "4 - +"
            Me.col_ing_4.Name = "col_ing_4"
            Me.col_ing_4.ReadOnly = True
            Me.col_ing_4.Width = 60
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.dgwcapacidad)
            Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(260, 130)
            Me.GroupBox5.TabIndex = 4
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "CAPACIDAD TOTAL"
            '
            'dgwcapacidad
            '
            Me.dgwcapacidad.AllowUserToAddRows = False
            Me.dgwcapacidad.AllowUserToDeleteRows = False
            Me.dgwcapacidad.AllowUserToResizeRows = False
            Me.dgwcapacidad.BackgroundColor = System.Drawing.Color.White
            Me.dgwcapacidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwcapacidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_par_id, Me.col_par_tip, Me.col_par_nom, Me.col_par_cap, Me.col_par_act})
            Me.dgwcapacidad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwcapacidad.Location = New System.Drawing.Point(3, 16)
            Me.dgwcapacidad.Name = "dgwcapacidad"
            Me.dgwcapacidad.ReadOnly = True
            Me.dgwcapacidad.RowHeadersVisible = False
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            Me.dgwcapacidad.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgwcapacidad.Size = New System.Drawing.Size(254, 111)
            Me.dgwcapacidad.TabIndex = 0
            '
            'col_par_id
            '
            Me.col_par_id.DataPropertyName = "par_id"
            Me.col_par_id.HeaderText = "ParId"
            Me.col_par_id.Name = "col_par_id"
            Me.col_par_id.ReadOnly = True
            Me.col_par_id.Visible = False
            '
            'col_par_tip
            '
            Me.col_par_tip.DataPropertyName = "par_tip"
            Me.col_par_tip.HeaderText = "Tipo"
            Me.col_par_tip.Name = "col_par_tip"
            Me.col_par_tip.ReadOnly = True
            Me.col_par_tip.Visible = False
            '
            'col_par_nom
            '
            Me.col_par_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_par_nom.DataPropertyName = "par_nom"
            Me.col_par_nom.HeaderText = "Local"
            Me.col_par_nom.Name = "col_par_nom"
            Me.col_par_nom.ReadOnly = True
            '
            'col_par_cap
            '
            Me.col_par_cap.DataPropertyName = "capacidad"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.col_par_cap.DefaultCellStyle = DataGridViewCellStyle4
            Me.col_par_cap.HeaderText = "Cap."
            Me.col_par_cap.Name = "col_par_cap"
            Me.col_par_cap.ReadOnly = True
            Me.col_par_cap.Width = 50
            '
            'col_par_act
            '
            Me.col_par_act.DataPropertyName = "actual"
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.col_par_act.DefaultCellStyle = DataGridViewCellStyle5
            Me.col_par_act.HeaderText = "Actual"
            Me.col_par_act.Name = "col_par_act"
            Me.col_par_act.ReadOnly = True
            Me.col_par_act.Width = 50
            '
            'dgwingresos
            '
            Me.dgwingresos.AllowUserToAddRows = False
            Me.dgwingresos.AllowUserToDeleteRows = False
            Me.dgwingresos.AllowUserToResizeRows = False
            Me.dgwingresos.BackgroundColor = System.Drawing.Color.White
            Me.dgwingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwingresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_id, Me.col_int_cod_rp, Me.col_ape_nom, Me.col_fec_ing, Me.col_mot_id, Me.col_pen_nom})
            Me.dgwingresos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwingresos.Location = New System.Drawing.Point(3, 43)
            Me.dgwingresos.Name = "dgwingresos"
            Me.dgwingresos.ReadOnly = True
            Me.dgwingresos.RowHeadersVisible = False
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            Me.dgwingresos.RowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwingresos.Size = New System.Drawing.Size(476, 354)
            Me.dgwingresos.TabIndex = 0
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "int_id"
            Me.col_int_id.HeaderText = "InternoId"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_int_cod_rp
            '
            Me.col_int_cod_rp.DataPropertyName = "int_cod_rp"
            Me.col_int_cod_rp.HeaderText = "Id del Interno"
            Me.col_int_cod_rp.Name = "col_int_cod_rp"
            Me.col_int_cod_rp.ReadOnly = True
            Me.col_int_cod_rp.Width = 90
            '
            'col_ape_nom
            '
            Me.col_ape_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_ape_nom.DataPropertyName = "ape_nom"
            Me.col_ape_nom.HeaderText = "Apellidos y Nombres"
            Me.col_ape_nom.Name = "col_ape_nom"
            Me.col_ape_nom.ReadOnly = True
            Me.col_ape_nom.Width = 116
            '
            'col_fec_ing
            '
            Me.col_fec_ing.DataPropertyName = "int_ing_fec"
            Me.col_fec_ing.HeaderText = "Fecha Ingreso"
            Me.col_fec_ing.Name = "col_fec_ing"
            Me.col_fec_ing.ReadOnly = True
            Me.col_fec_ing.Width = 80
            '
            'col_mot_id
            '
            Me.col_mot_id.DataPropertyName = "mot_nom"
            Me.col_mot_id.HeaderText = "Modalidad"
            Me.col_mot_id.Name = "col_mot_id"
            Me.col_mot_id.ReadOnly = True
            Me.col_mot_id.Width = 120
            '
            'col_pen_nom
            '
            Me.col_pen_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_pen_nom.DataPropertyName = "pen_nom"
            Me.col_pen_nom.HeaderText = "Destino"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.dte_ingresohasta)
            Me.Panel1.Controls.Add(Me.Label6)
            Me.Panel1.Controls.Add(Me.dte_ingresodesde)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(3, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(476, 27)
            Me.Panel1.TabIndex = 1
            '
            'dte_ingresohasta
            '
            Me.dte_ingresohasta.Location = New System.Drawing.Point(345, 3)
            Me.dte_ingresohasta.Name = "dte_ingresohasta"
            Me.dte_ingresohasta.Size = New System.Drawing.Size(84, 21)
            Me.dte_ingresohasta.TabIndex = 5
            Me.dte_ingresohasta.Value = "/  /"
            Me.dte_ingresohasta.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(301, 6)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(41, 13)
            Me.Label6.TabIndex = 4
            Me.Label6.Text = "Hasta :"
            '
            'dte_ingresodesde
            '
            Me.dte_ingresodesde.Location = New System.Drawing.Point(200, 3)
            Me.dte_ingresodesde.Name = "dte_ingresodesde"
            Me.dte_ingresodesde.Size = New System.Drawing.Size(84, 21)
            Me.dte_ingresodesde.TabIndex = 3
            Me.dte_ingresodesde.Value = "/  /"
            Me.dte_ingresodesde.ValueLong = CType(0, Long)
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(158, 6)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 13)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Desde :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(114, 6)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(40, 13)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Buscar"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(4, 6)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(104, 13)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Lista de Ingresos"
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.txtcompletos)
            Me.GroupBox9.Controls.Add(Me.txtincompletos)
            Me.GroupBox9.Controls.Add(Me.Label11)
            Me.GroupBox9.Controls.Add(Me.Label10)
            Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox9.Location = New System.Drawing.Point(803, 0)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(232, 70)
            Me.GroupBox9.TabIndex = 8
            Me.GroupBox9.TabStop = False
            Me.GroupBox9.Text = "INFORMACION DEL SISTEMA"
            '
            'txtcompletos
            '
            Me.txtcompletos.Location = New System.Drawing.Point(116, 43)
            Me.txtcompletos.Name = "txtcompletos"
            Me.txtcompletos.Size = New System.Drawing.Size(75, 20)
            Me.txtcompletos.TabIndex = 3
            Me.txtcompletos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtincompletos
            '
            Me.txtincompletos.Location = New System.Drawing.Point(116, 20)
            Me.txtincompletos.Name = "txtincompletos"
            Me.txtincompletos.Size = New System.Drawing.Size(75, 20)
            Me.txtincompletos.TabIndex = 2
            Me.txtincompletos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(7, 47)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(90, 13)
            Me.Label11.TabIndex = 1
            Me.Label11.Text = "Datos Completos "
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(7, 23)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(98, 13)
            Me.Label10.TabIndex = 0
            Me.Label10.Text = "Datos Incompletos "
            '
            'GroupBox10
            '
            Me.GroupBox10.Controls.Add(Me.txttotal)
            Me.GroupBox10.Controls.Add(Me.Label14)
            Me.GroupBox10.Controls.Add(Me.txtmujer)
            Me.GroupBox10.Controls.Add(Me.txthombre)
            Me.GroupBox10.Controls.Add(Me.Label12)
            Me.GroupBox10.Controls.Add(Me.Label13)
            Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox10.Location = New System.Drawing.Point(511, 0)
            Me.GroupBox10.Name = "GroupBox10"
            Me.GroupBox10.Size = New System.Drawing.Size(292, 70)
            Me.GroupBox10.TabIndex = 9
            Me.GroupBox10.TabStop = False
            '
            'txttotal
            '
            Me.txttotal.AutoSize = True
            Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txttotal.Location = New System.Drawing.Point(7, 34)
            Me.txttotal.Name = "txttotal"
            Me.txttotal.Size = New System.Drawing.Size(90, 26)
            Me.txttotal.TabIndex = 9
            Me.txttotal.Text = "000000"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(9, 11)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(88, 13)
            Me.Label14.TabIndex = 8
            Me.Label14.Text = "POB. ACTUAL"
            '
            'txtmujer
            '
            Me.txtmujer.Location = New System.Drawing.Point(200, 43)
            Me.txtmujer.Name = "txtmujer"
            Me.txtmujer.Size = New System.Drawing.Size(75, 20)
            Me.txtmujer.TabIndex = 7
            Me.txtmujer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txthombre
            '
            Me.txthombre.Location = New System.Drawing.Point(200, 20)
            Me.txthombre.Name = "txthombre"
            Me.txthombre.Size = New System.Drawing.Size(75, 20)
            Me.txthombre.TabIndex = 6
            Me.txthombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(118, 47)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(71, 13)
            Me.Label12.TabIndex = 5
            Me.Label12.Text = "Total Mujeres"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(118, 23)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(76, 13)
            Me.Label13.TabIndex = 4
            Me.Label13.Text = "Total Hombres"
            '
            'lbltime
            '
            Me.lbltime.AutoSize = True
            Me.lbltime.Location = New System.Drawing.Point(1188, 740)
            Me.lbltime.Name = "lbltime"
            Me.lbltime.Size = New System.Drawing.Size(45, 13)
            Me.lbltime.TabIndex = 10
            Me.lbltime.Text = "Label15"
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.GroupBox1)
            Me.pnlCabecera.Controls.Add(Me.GroupBox10)
            Me.pnlCabecera.Controls.Add(Me.GroupBox9)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(1035, 70)
            Me.pnlCabecera.TabIndex = 11
            '
            'pnlTablero1
            '
            Me.pnlTablero1.Controls.Add(Me.GroupBox5)
            Me.pnlTablero1.Controls.Add(Me.GroupBox2)
            Me.pnlTablero1.Controls.Add(Me.GroupBox3)
            Me.pnlTablero1.Controls.Add(Me.GroupBox4)
            Me.pnlTablero1.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlTablero1.Location = New System.Drawing.Point(0, 0)
            Me.pnlTablero1.Name = "pnlTablero1"
            Me.pnlTablero1.Size = New System.Drawing.Size(260, 400)
            Me.pnlTablero1.TabIndex = 12
            '
            'grbDelito
            '
            Me.grbDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbDelito.Location = New System.Drawing.Point(0, 268)
            Me.grbDelito.Name = "grbDelito"
            Me.grbDelito.Size = New System.Drawing.Size(293, 132)
            Me.grbDelito.TabIndex = 6
            Me.grbDelito.TabStop = False
            Me.grbDelito.Text = "POR DELITOS"
            '
            'grbNac
            '
            Me.grbNac.Controls.Add(Me.dgwnacionalidad)
            Me.grbNac.Controls.Add(Me.Panel3)
            Me.grbNac.Controls.Add(Me.Panel2)
            Me.grbNac.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbNac.Location = New System.Drawing.Point(0, 0)
            Me.grbNac.Name = "grbNac"
            Me.grbNac.Size = New System.Drawing.Size(293, 268)
            Me.grbNac.TabIndex = 5
            Me.grbNac.TabStop = False
            Me.grbNac.Text = "POR NACIONALIDAD"
            '
            'dgwnacionalidad
            '
            Me.dgwnacionalidad.AllowUserToAddRows = False
            Me.dgwnacionalidad.AllowUserToDeleteRows = False
            Me.dgwnacionalidad.AllowUserToResizeRows = False
            Me.dgwnacionalidad.BackgroundColor = System.Drawing.Color.White
            Me.dgwnacionalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwnacionalidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nac_id, Me.col_nac_nom, Me.col_hom, Me.col_muj, Me.col_tot})
            Me.dgwnacionalidad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwnacionalidad.Location = New System.Drawing.Point(3, 44)
            Me.dgwnacionalidad.Name = "dgwnacionalidad"
            Me.dgwnacionalidad.ReadOnly = True
            Me.dgwnacionalidad.RowHeadersVisible = False
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            Me.dgwnacionalidad.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgwnacionalidad.Size = New System.Drawing.Size(287, 199)
            Me.dgwnacionalidad.TabIndex = 0
            '
            'col_nac_id
            '
            Me.col_nac_id.DataPropertyName = "nac_id"
            Me.col_nac_id.HeaderText = "nac_id"
            Me.col_nac_id.Name = "col_nac_id"
            Me.col_nac_id.ReadOnly = True
            Me.col_nac_id.Visible = False
            '
            'col_nac_nom
            '
            Me.col_nac_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_nac_nom.DataPropertyName = "nac_nom"
            Me.col_nac_nom.HeaderText = "Nacionalidad"
            Me.col_nac_nom.Name = "col_nac_nom"
            Me.col_nac_nom.ReadOnly = True
            '
            'col_hom
            '
            Me.col_hom.DataPropertyName = "hombres"
            Me.col_hom.HeaderText = "Hom."
            Me.col_hom.Name = "col_hom"
            Me.col_hom.ReadOnly = True
            Me.col_hom.Width = 60
            '
            'col_muj
            '
            Me.col_muj.DataPropertyName = "mujeres"
            Me.col_muj.HeaderText = "Muj."
            Me.col_muj.Name = "col_muj"
            Me.col_muj.ReadOnly = True
            Me.col_muj.Width = 60
            '
            'col_tot
            '
            Me.col_tot.DataPropertyName = "total"
            Me.col_tot.HeaderText = "Total"
            Me.col_tot.Name = "col_tot"
            Me.col_tot.ReadOnly = True
            Me.col_tot.Width = 60
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.txtNacHom)
            Me.Panel3.Controls.Add(Me.txtNacMuj)
            Me.Panel3.Controls.Add(Me.txtNacTot)
            Me.Panel3.Controls.Add(Me.Label17)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel3.Location = New System.Drawing.Point(3, 243)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(287, 22)
            Me.Panel3.TabIndex = 2
            '
            'txtNacHom
            '
            Me.txtNacHom.BackColor = System.Drawing.Color.White
            Me.txtNacHom.Dock = System.Windows.Forms.DockStyle.Right
            Me.txtNacHom.Location = New System.Drawing.Point(102, 0)
            Me.txtNacHom.Name = "txtNacHom"
            Me.txtNacHom.ReadOnly = True
            Me.txtNacHom.Size = New System.Drawing.Size(65, 20)
            Me.txtNacHom.TabIndex = 5
            Me.txtNacHom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNacMuj
            '
            Me.txtNacMuj.BackColor = System.Drawing.Color.White
            Me.txtNacMuj.Dock = System.Windows.Forms.DockStyle.Right
            Me.txtNacMuj.Location = New System.Drawing.Point(167, 0)
            Me.txtNacMuj.Name = "txtNacMuj"
            Me.txtNacMuj.ReadOnly = True
            Me.txtNacMuj.Size = New System.Drawing.Size(60, 20)
            Me.txtNacMuj.TabIndex = 3
            Me.txtNacMuj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNacTot
            '
            Me.txtNacTot.BackColor = System.Drawing.Color.White
            Me.txtNacTot.Dock = System.Windows.Forms.DockStyle.Right
            Me.txtNacTot.Location = New System.Drawing.Point(227, 0)
            Me.txtNacTot.Name = "txtNacTot"
            Me.txtNacTot.ReadOnly = True
            Me.txtNacTot.Size = New System.Drawing.Size(60, 20)
            Me.txtNacTot.TabIndex = 1
            Me.txtNacTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(18, 4)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(37, 13)
            Me.Label17.TabIndex = 0
            Me.Label17.Text = "Total :"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.txtnacionalidad)
            Me.Panel2.Controls.Add(Me.Label9)
            Me.Panel2.Controls.Add(Me.txtextranjero)
            Me.Panel2.Controls.Add(Me.Label8)
            Me.Panel2.Controls.Add(Me.txtperuana)
            Me.Panel2.Controls.Add(Me.Label7)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(3, 16)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(287, 28)
            Me.Panel2.TabIndex = 1
            '
            'txtnacionalidad
            '
            Me.txtnacionalidad.Location = New System.Drawing.Point(243, 3)
            Me.txtnacionalidad.Name = "txtnacionalidad"
            Me.txtnacionalidad.Size = New System.Drawing.Size(39, 20)
            Me.txtnacionalidad.TabIndex = 5
            Me.txtnacionalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(206, 6)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(36, 13)
            Me.Label9.TabIndex = 4
            Me.Label9.Text = "N/E  :"
            '
            'txtextranjero
            '
            Me.txtextranjero.Location = New System.Drawing.Point(164, 2)
            Me.txtextranjero.Name = "txtextranjero"
            Me.txtextranjero.Size = New System.Drawing.Size(39, 20)
            Me.txtextranjero.TabIndex = 3
            Me.txtextranjero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(98, 6)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(65, 13)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Extranjeros :"
            '
            'txtperuana
            '
            Me.txtperuana.Location = New System.Drawing.Point(57, 3)
            Me.txtperuana.Name = "txtperuana"
            Me.txtperuana.Size = New System.Drawing.Size(39, 20)
            Me.txtperuana.TabIndex = 1
            Me.txtperuana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(2, 6)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(53, 13)
            Me.Label7.TabIndex = 0
            Me.Label7.Text = "Peruana :"
            '
            'pnlCuerpo
            '
            Me.pnlCuerpo.BackColor = System.Drawing.Color.Transparent
            Me.pnlCuerpo.Controls.Add(Me.pnlIngreso)
            Me.pnlCuerpo.Controls.Add(Me.pnlTablero)
            Me.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCuerpo.Location = New System.Drawing.Point(0, 70)
            Me.pnlCuerpo.Name = "pnlCuerpo"
            Me.pnlCuerpo.Size = New System.Drawing.Size(1035, 400)
            Me.pnlCuerpo.TabIndex = 13
            '
            'pnlIngreso
            '
            Me.pnlIngreso.Controls.Add(Me.grnIngreso)
            Me.pnlIngreso.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlIngreso.Location = New System.Drawing.Point(553, 0)
            Me.pnlIngreso.Name = "pnlIngreso"
            Me.pnlIngreso.Size = New System.Drawing.Size(482, 400)
            Me.pnlIngreso.TabIndex = 14
            '
            'grnIngreso
            '
            Me.grnIngreso.Controls.Add(Me.dgwingresos)
            Me.grnIngreso.Controls.Add(Me.Panel1)
            Me.grnIngreso.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grnIngreso.Location = New System.Drawing.Point(0, 0)
            Me.grnIngreso.Name = "grnIngreso"
            Me.grnIngreso.Size = New System.Drawing.Size(482, 400)
            Me.grnIngreso.TabIndex = 2
            Me.grnIngreso.TabStop = False
            '
            'pnlTablero
            '
            Me.pnlTablero.BackColor = System.Drawing.Color.Transparent
            Me.pnlTablero.Controls.Add(Me.pnlTablero2)
            Me.pnlTablero.Controls.Add(Me.pnlTablero1)
            Me.pnlTablero.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlTablero.Location = New System.Drawing.Point(0, 0)
            Me.pnlTablero.Name = "pnlTablero"
            Me.pnlTablero.Size = New System.Drawing.Size(553, 400)
            Me.pnlTablero.TabIndex = 14
            '
            'pnlTablero2
            '
            Me.pnlTablero2.BackColor = System.Drawing.Color.Transparent
            Me.pnlTablero2.Controls.Add(Me.grbDelito)
            Me.pnlTablero2.Controls.Add(Me.grbNac)
            Me.pnlTablero2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlTablero2.Location = New System.Drawing.Point(260, 0)
            Me.pnlTablero2.Name = "pnlTablero2"
            Me.pnlTablero2.Size = New System.Drawing.Size(293, 400)
            Me.pnlTablero2.TabIndex = 13
            '
            'frmPanel
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1035, 470)
            Me.Controls.Add(Me.pnlCuerpo)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Controls.Add(Me.lbltime)
            Me.Name = "frmPanel"
            Me.Text = "Panel"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgwsituacion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            CType(Me.dgwnroingreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            CType(Me.dgwPELIGROsidad, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox5.ResumeLayout(False)
            CType(Me.dgwcapacidad, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgwingresos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.GroupBox10.ResumeLayout(False)
            Me.GroupBox10.PerformLayout()
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlTablero1.ResumeLayout(False)
            Me.grbNac.ResumeLayout(False)
            CType(Me.dgwnacionalidad, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlCuerpo.ResumeLayout(False)
            Me.pnlIngreso.ResumeLayout(False)
            Me.grnIngreso.ResumeLayout(False)
            Me.pnlTablero.ResumeLayout(False)
            Me.pnlTablero2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cbbpenal As APPControls.uscComboParametrica
        Friend WithEvents cbbregion As APPControls.uscComboParametrica
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwsituacion As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwnroingreso As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwPELIGROsidad As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwcapacidad As System.Windows.Forms.DataGridView
        Friend WithEvents dgwingresos As System.Windows.Forms.DataGridView
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents dte_ingresohasta As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dte_ingresodesde As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents txtcompletos As System.Windows.Forms.TextBox
        Friend WithEvents txtincompletos As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
        Friend WithEvents txtmujer As System.Windows.Forms.TextBox
        Friend WithEvents txthombre As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txttotal As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents lbltime As System.Windows.Forms.Label
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlTablero1 As System.Windows.Forms.Panel
        Friend WithEvents grbDelito As System.Windows.Forms.GroupBox
        'Friend WithEvents treedelitos As Infragistics.Win.UltraWinTree.UltraTree
        Friend WithEvents grbNac As System.Windows.Forms.GroupBox
        Friend WithEvents dgwnacionalidad As System.Windows.Forms.DataGridView
        Friend WithEvents col_nac_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nac_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_hom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_muj As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tot As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents txtnacionalidad As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtextranjero As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtperuana As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_cod_rp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mot_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlCuerpo As System.Windows.Forms.Panel
        Friend WithEvents pnlIngreso As System.Windows.Forms.Panel
        Friend WithEvents pnlTablero As System.Windows.Forms.Panel
        Friend WithEvents pnlTablero2 As System.Windows.Forms.Panel
        Friend WithEvents grnIngreso As System.Windows.Forms.GroupBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents txtNacHom As System.Windows.Forms.TextBox
        Friend WithEvents txtNacMuj As System.Windows.Forms.TextBox
        Friend WithEvents txtNacTot As System.Windows.Forms.TextBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents col_par_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_par_tip As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_par_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_par_cap As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_par_act As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sex_sit As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sex_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pro As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sen As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mix As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sindata As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pel_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pel_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pel_1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pel_2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pel_3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pel_sindata As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sex_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnVer As System.Windows.Forms.Button
    End Class
End Namespace

