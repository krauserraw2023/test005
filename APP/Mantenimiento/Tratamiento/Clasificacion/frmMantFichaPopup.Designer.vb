Namespace Mantenimiento.Clasificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmFichaPopup
        Inherits Legolas.APPUIComponents.FormPopup

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFichaPopup))
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tbpFicha = New System.Windows.Forms.TabPage()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dbrInactivo = New System.Windows.Forms.RadioButton()
            Me.rbdActivo = New System.Windows.Forms.RadioButton()
            Me.dtpFechaDocAprob = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtDocAprob = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumOrd = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDescripcion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbTipoFicha = New APPControls.uscComboParametrica()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbAmbitoClasificacion = New APPControls.uscComboParametrica()
            Me.tbpCatFicha = New System.Windows.Forms.TabPage()
            Me.dgwCategorizacion = New Legolas.APPUIComponents.myDatagridView()
            Me.cat_col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cat_col_fic_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cat_col_cat_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cat_col_val_min = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cat_col_val_max = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnEliminarCat = New System.Windows.Forms.Button()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.btnEditarCat = New System.Windows.Forms.Button()
            Me.btnNuevoCat = New System.Windows.Forms.Button()
            Me.tbpVarFicha = New System.Windows.Forms.TabPage()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.dgvIndicador = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ind_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ind_num_sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ind_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ind_ptje = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ind_var_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.btnEliminarIndicador = New System.Windows.Forms.Button()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.btnEditarIndicador = New System.Windows.Forms.Button()
            Me.btnNuevoIndicador = New System.Windows.Forms.Button()
            Me.lblValorText = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.dgwVariable = New Legolas.APPUIComponents.myDatagridView()
            Me.var_col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.var_col_num_ord = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.var_col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlAccionRasgo = New System.Windows.Forms.Panel()
            Me.pnlRasgosEli = New System.Windows.Forms.Panel()
            Me.btnEliminarVariable = New System.Windows.Forms.Button()
            Me.pnlRagosAdd = New System.Windows.Forms.Panel()
            Me.btnEditarVariable = New System.Windows.Forms.Button()
            Me.btnNuevoVariable = New System.Windows.Forms.Button()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.tbpResultado = New System.Windows.Forms.TabPage()
            Me.Panel11 = New System.Windows.Forms.Panel()
            Me.UscResultadoDet1 = New APPControls.Mantenimiento.Tratamiento.Clasificacion.uscResultadoDet()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Panel10 = New System.Windows.Forms.Panel()
            Me.UscResultado1 = New APPControls.Mantenimiento.Tratamiento.Clasificacion.uscResultado()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlGuardar = New System.Windows.Forms.Panel()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tbpFicha.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.tbpCatFicha.SuspendLayout()
            CType(Me.dgwCategorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.tbpVarFicha.SuspendLayout()
            Me.Panel6.SuspendLayout()
            CType(Me.dgvIndicador, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel7.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.dgwVariable, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlAccionRasgo.SuspendLayout()
            Me.pnlRasgosEli.SuspendLayout()
            Me.pnlRagosAdd.SuspendLayout()
            Me.tbpResultado.SuspendLayout()
            Me.Panel11.SuspendLayout()
            Me.Panel10.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGuardar.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.TabControl1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(761, 431)
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tbpFicha)
            Me.TabControl1.Controls.Add(Me.tbpCatFicha)
            Me.TabControl1.Controls.Add(Me.tbpVarFicha)
            Me.TabControl1.Controls.Add(Me.tbpResultado)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(761, 386)
            Me.TabControl1.TabIndex = 0
            '
            'tbpFicha
            '
            Me.tbpFicha.Controls.Add(Me.GroupBox1)
            Me.tbpFicha.Location = New System.Drawing.Point(4, 22)
            Me.tbpFicha.Name = "tbpFicha"
            Me.tbpFicha.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpFicha.Size = New System.Drawing.Size(753, 360)
            Me.tbpFicha.TabIndex = 2
            Me.tbpFicha.Text = "Datos Ficha"
            Me.tbpFicha.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Controls.Add(Me.dtpFechaDocAprob)
            Me.GroupBox1.Controls.Add(Me.txtDocAprob)
            Me.GroupBox1.Controls.Add(Me.txtNumOrd)
            Me.GroupBox1.Controls.Add(Me.txtDescripcion)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.cbbTipoFicha)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.cbbAmbitoClasificacion)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(747, 354)
            Me.GroupBox1.TabIndex = 5
            Me.GroupBox1.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dbrInactivo)
            Me.GroupBox2.Controls.Add(Me.rbdActivo)
            Me.GroupBox2.Enabled = False
            Me.GroupBox2.Location = New System.Drawing.Point(149, 63)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(235, 44)
            Me.GroupBox2.TabIndex = 17
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Estado"
            '
            'dbrInactivo
            '
            Me.dbrInactivo.AutoSize = True
            Me.dbrInactivo.Location = New System.Drawing.Point(145, 19)
            Me.dbrInactivo.Name = "dbrInactivo"
            Me.dbrInactivo.Size = New System.Drawing.Size(63, 17)
            Me.dbrInactivo.TabIndex = 0
            Me.dbrInactivo.Text = "Inactivo"
            Me.dbrInactivo.UseVisualStyleBackColor = True
            '
            'rbdActivo
            '
            Me.rbdActivo.AutoSize = True
            Me.rbdActivo.Checked = True
            Me.rbdActivo.Location = New System.Drawing.Point(51, 18)
            Me.rbdActivo.Name = "rbdActivo"
            Me.rbdActivo.Size = New System.Drawing.Size(55, 17)
            Me.rbdActivo.TabIndex = 0
            Me.rbdActivo.TabStop = True
            Me.rbdActivo.Text = "Activo"
            Me.rbdActivo.UseVisualStyleBackColor = True
            '
            'dtpFechaDocAprob
            '
            Me.dtpFechaDocAprob.Location = New System.Drawing.Point(657, 247)
            Me.dtpFechaDocAprob.Name = "dtpFechaDocAprob"
            Me.dtpFechaDocAprob.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaDocAprob.TabIndex = 16
            Me.dtpFechaDocAprob.Value = "/  /"
            Me.dtpFechaDocAprob.ValueLong = CType(0, Long)
            '
            'txtDocAprob
            '
            Me.txtDocAprob._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDocAprob._BloquearPaste = False
            Me.txtDocAprob._SeleccionarTodo = False
            Me.txtDocAprob.Location = New System.Drawing.Point(149, 247)
            Me.txtDocAprob.MaxLength = 255
            Me.txtDocAprob.Name = "txtDocAprob"
            Me.txtDocAprob.Size = New System.Drawing.Size(371, 20)
            Me.txtDocAprob.TabIndex = 15
            Me.txtDocAprob.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDocAprob.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNumOrd
            '
            Me.txtNumOrd._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumOrd._BloquearPaste = False
            Me.txtNumOrd._SeleccionarTodo = False
            Me.txtNumOrd.Location = New System.Drawing.Point(149, 167)
            Me.txtNumOrd.Name = "txtNumOrd"
            Me.txtNumOrd.ReadOnly = True
            Me.txtNumOrd.Size = New System.Drawing.Size(82, 20)
            Me.txtNumOrd.TabIndex = 15
            Me.txtNumOrd.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumOrd.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtDescripcion
            '
            Me.txtDescripcion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDescripcion._BloquearPaste = False
            Me.txtDescripcion._SeleccionarTodo = False
            Me.txtDescripcion.Location = New System.Drawing.Point(149, 220)
            Me.txtDescripcion.MaxLength = 500
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.Size = New System.Drawing.Size(592, 20)
            Me.txtDescripcion.TabIndex = 14
            Me.txtDescripcion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDescripcion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNombre
            '
            Me.txtNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombre._BloquearPaste = False
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(149, 193)
            Me.txtNombre.MaxLength = 200
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(592, 20)
            Me.txtNombre.TabIndex = 14
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbTipoFicha
            '
            Me.cbbTipoFicha._NoIndica = False
            Me.cbbTipoFicha._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoFicha._Todos = False
            Me.cbbTipoFicha._TodosMensaje = ""
            Me.cbbTipoFicha._Visible_Add = False
            Me.cbbTipoFicha._Visible_Buscar = False
            Me.cbbTipoFicha._Visible_Eliminar = False
            Me.cbbTipoFicha.CodigoPadre = -1
            Me.cbbTipoFicha.ComboTipo = Type.Combo.ComboTipo.ClasificacionTipoFicha
            Me.cbbTipoFicha.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoFicha.DropDownWidth = 238
            Me.cbbTipoFicha.DropDownWidthAuto = False
            Me.cbbTipoFicha.ListaIdsParaExcluir = Nothing
            Me.cbbTipoFicha.Location = New System.Drawing.Point(149, 141)
            Me.cbbTipoFicha.Name = "cbbTipoFicha"
            Me.cbbTipoFicha.Parametro1 = -1
            Me.cbbTipoFicha.Parametro2 = -1
            Me.cbbTipoFicha.SelectedIndex = -1
            Me.cbbTipoFicha.SelectedValue = 0
            Me.cbbTipoFicha.Size = New System.Drawing.Size(371, 22)
            Me.cbbTipoFicha.TabIndex = 13
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(540, 251)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(111, 13)
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "Fecha de documento:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(8, 249)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(136, 13)
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Documento de aprobación:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(78, 223)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(66, 13)
            Me.Label5.TabIndex = 12
            Me.Label5.Text = "Descripción:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(90, 171)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(54, 13)
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "N° Orden:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(97, 197)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(47, 13)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Nombre:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(72, 145)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(72, 13)
            Me.Label2.TabIndex = 12
            Me.Label2.Text = "Tipo de ficha:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(26, 119)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(118, 13)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Ambito de clasificación:"
            '
            'cbbAmbitoClasificacion
            '
            Me.cbbAmbitoClasificacion._NoIndica = False
            Me.cbbAmbitoClasificacion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbAmbitoClasificacion._Todos = False
            Me.cbbAmbitoClasificacion._TodosMensaje = ""
            Me.cbbAmbitoClasificacion._Visible_Add = False
            Me.cbbAmbitoClasificacion._Visible_Buscar = False
            Me.cbbAmbitoClasificacion._Visible_Eliminar = False
            Me.cbbAmbitoClasificacion.CodigoPadre = -1
            Me.cbbAmbitoClasificacion.ComboTipo = Type.Combo.ComboTipo.ClasificacionAmbito
            Me.cbbAmbitoClasificacion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbAmbitoClasificacion.DropDownWidth = 178
            Me.cbbAmbitoClasificacion.DropDownWidthAuto = False
            Me.cbbAmbitoClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbAmbitoClasificacion.ForeColor = System.Drawing.Color.Black
            Me.cbbAmbitoClasificacion.ListaIdsParaExcluir = Nothing
            Me.cbbAmbitoClasificacion.Location = New System.Drawing.Point(149, 113)
            Me.cbbAmbitoClasificacion.Name = "cbbAmbitoClasificacion"
            Me.cbbAmbitoClasificacion.Parametro1 = -1
            Me.cbbAmbitoClasificacion.Parametro2 = -1
            Me.cbbAmbitoClasificacion.SelectedIndex = -1
            Me.cbbAmbitoClasificacion.SelectedValue = 0
            Me.cbbAmbitoClasificacion.Size = New System.Drawing.Size(592, 22)
            Me.cbbAmbitoClasificacion.TabIndex = 11
            '
            'tbpCatFicha
            '
            Me.tbpCatFicha.Controls.Add(Me.dgwCategorizacion)
            Me.tbpCatFicha.Controls.Add(Me.Panel3)
            Me.tbpCatFicha.Location = New System.Drawing.Point(4, 22)
            Me.tbpCatFicha.Name = "tbpCatFicha"
            Me.tbpCatFicha.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpCatFicha.Size = New System.Drawing.Size(559, 355)
            Me.tbpCatFicha.TabIndex = 0
            Me.tbpCatFicha.Text = "Categorización de ficha"
            Me.tbpCatFicha.UseVisualStyleBackColor = True
            '
            'dgwCategorizacion
            '
            Me.dgwCategorizacion.AllowUserToAddRows = False
            Me.dgwCategorizacion.AllowUserToDeleteRows = False
            Me.dgwCategorizacion.AllowUserToResizeRows = False
            Me.dgwCategorizacion.BackgroundColor = System.Drawing.Color.White
            Me.dgwCategorizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgwCategorizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwCategorizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cat_col_codigo, Me.cat_col_fic_id, Me.cat_col_cat_nom, Me.cat_col_val_min, Me.cat_col_val_max})
            Me.dgwCategorizacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwCategorizacion.Location = New System.Drawing.Point(3, 3)
            Me.dgwCategorizacion.MultiSelect = False
            Me.dgwCategorizacion.Name = "dgwCategorizacion"
            Me.dgwCategorizacion.ReadOnly = True
            Me.dgwCategorizacion.RowHeadersVisible = False
            Me.dgwCategorizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwCategorizacion.Size = New System.Drawing.Size(520, 349)
            Me.dgwCategorizacion.TabIndex = 0
            Me.dgwCategorizacion.VisibleCampos = False
            '
            'cat_col_codigo
            '
            Me.cat_col_codigo.DataPropertyName = "Codigo"
            Me.cat_col_codigo.HeaderText = "Codigo"
            Me.cat_col_codigo.Name = "cat_col_codigo"
            Me.cat_col_codigo.ReadOnly = True
            '
            'cat_col_fic_id
            '
            Me.cat_col_fic_id.DataPropertyName = "FichaId"
            Me.cat_col_fic_id.HeaderText = "FichaId"
            Me.cat_col_fic_id.Name = "cat_col_fic_id"
            Me.cat_col_fic_id.ReadOnly = True
            Me.cat_col_fic_id.Visible = False
            '
            'cat_col_cat_nom
            '
            Me.cat_col_cat_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.cat_col_cat_nom.DataPropertyName = "CategoriaNombre"
            Me.cat_col_cat_nom.HeaderText = "Categoria"
            Me.cat_col_cat_nom.Name = "cat_col_cat_nom"
            Me.cat_col_cat_nom.ReadOnly = True
            '
            'cat_col_val_min
            '
            Me.cat_col_val_min.DataPropertyName = "ValorMinimo"
            Me.cat_col_val_min.HeaderText = "Valor Min."
            Me.cat_col_val_min.Name = "cat_col_val_min"
            Me.cat_col_val_min.ReadOnly = True
            '
            'cat_col_val_max
            '
            Me.cat_col_val_max.DataPropertyName = "ValorMaximo"
            Me.cat_col_val_max.HeaderText = "Valor Max."
            Me.cat_col_val_max.Name = "cat_col_val_max"
            Me.cat_col_val_max.ReadOnly = True
            '
            'Panel3
            '
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.Panel4)
            Me.Panel3.Controls.Add(Me.Panel5)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(523, 3)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
            Me.Panel3.Size = New System.Drawing.Size(33, 349)
            Me.Panel3.TabIndex = 93
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnEliminarCat)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Location = New System.Drawing.Point(1, 55)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(30, 37)
            Me.Panel4.TabIndex = 91
            '
            'btnEliminarCat
            '
            Me.btnEliminarCat.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminarCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarCat.Location = New System.Drawing.Point(0, 2)
            Me.btnEliminarCat.Name = "btnEliminarCat"
            Me.btnEliminarCat.Size = New System.Drawing.Size(30, 26)
            Me.btnEliminarCat.TabIndex = 89
            Me.btnEliminarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.btnEditarCat)
            Me.Panel5.Controls.Add(Me.btnNuevoCat)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel5.Location = New System.Drawing.Point(1, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(30, 55)
            Me.Panel5.TabIndex = 90
            '
            'btnEditarCat
            '
            Me.btnEditarCat.BackgroundImage = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditarCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditarCat.Location = New System.Drawing.Point(0, 28)
            Me.btnEditarCat.Name = "btnEditarCat"
            Me.btnEditarCat.Size = New System.Drawing.Size(30, 26)
            Me.btnEditarCat.TabIndex = 11
            Me.btnEditarCat.UseVisualStyleBackColor = True
            '
            'btnNuevoCat
            '
            Me.btnNuevoCat.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnNuevoCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnNuevoCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoCat.Location = New System.Drawing.Point(0, 1)
            Me.btnNuevoCat.Name = "btnNuevoCat"
            Me.btnNuevoCat.Size = New System.Drawing.Size(30, 26)
            Me.btnNuevoCat.TabIndex = 88
            Me.btnNuevoCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'tbpVarFicha
            '
            Me.tbpVarFicha.Controls.Add(Me.Panel6)
            Me.tbpVarFicha.Controls.Add(Me.Panel1)
            Me.tbpVarFicha.Location = New System.Drawing.Point(4, 22)
            Me.tbpVarFicha.Name = "tbpVarFicha"
            Me.tbpVarFicha.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpVarFicha.Size = New System.Drawing.Size(559, 355)
            Me.tbpVarFicha.TabIndex = 1
            Me.tbpVarFicha.Text = "Variables"
            Me.tbpVarFicha.UseVisualStyleBackColor = True
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.dgvIndicador)
            Me.Panel6.Controls.Add(Me.Panel7)
            Me.Panel6.Controls.Add(Me.lblValorText)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel6.Location = New System.Drawing.Point(3, 185)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.Panel6.Size = New System.Drawing.Size(553, 167)
            Me.Panel6.TabIndex = 3
            '
            'dgvIndicador
            '
            Me.dgvIndicador.AllowUserToAddRows = False
            Me.dgvIndicador.AllowUserToDeleteRows = False
            Me.dgvIndicador.AllowUserToResizeRows = False
            Me.dgvIndicador.BackgroundColor = System.Drawing.Color.White
            Me.dgvIndicador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgvIndicador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvIndicador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ind_cod, Me.col_ind_num_sec, Me.col_ind_nom, Me.col_ind_ptje, Me.col_ind_var_id})
            Me.dgvIndicador.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvIndicador.Location = New System.Drawing.Point(0, 30)
            Me.dgvIndicador.MultiSelect = False
            Me.dgvIndicador.Name = "dgvIndicador"
            Me.dgvIndicador.ReadOnly = True
            Me.dgvIndicador.RowHeadersVisible = False
            Me.dgvIndicador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvIndicador.Size = New System.Drawing.Size(520, 137)
            Me.dgvIndicador.TabIndex = 1
            Me.dgvIndicador.VisibleCampos = False
            '
            'col_ind_cod
            '
            Me.col_ind_cod.DataPropertyName = "Codigo"
            Me.col_ind_cod.HeaderText = "Codigo"
            Me.col_ind_cod.Name = "col_ind_cod"
            Me.col_ind_cod.ReadOnly = True
            Me.col_ind_cod.Visible = False
            '
            'col_ind_num_sec
            '
            Me.col_ind_num_sec.DataPropertyName = "Secuencia"
            Me.col_ind_num_sec.HeaderText = "Núm Ord."
            Me.col_ind_num_sec.Name = "col_ind_num_sec"
            Me.col_ind_num_sec.ReadOnly = True
            '
            'col_ind_nom
            '
            Me.col_ind_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_ind_nom.DataPropertyName = "Descripcion"
            Me.col_ind_nom.HeaderText = "Indicador"
            Me.col_ind_nom.Name = "col_ind_nom"
            Me.col_ind_nom.ReadOnly = True
            '
            'col_ind_ptje
            '
            Me.col_ind_ptje.DataPropertyName = "Puntaje"
            Me.col_ind_ptje.HeaderText = "Puntaje"
            Me.col_ind_ptje.Name = "col_ind_ptje"
            Me.col_ind_ptje.ReadOnly = True
            '
            'col_ind_var_id
            '
            Me.col_ind_var_id.DataPropertyName = "VariableId"
            Me.col_ind_var_id.HeaderText = "VarId"
            Me.col_ind_var_id.Name = "col_ind_var_id"
            Me.col_ind_var_id.ReadOnly = True
            Me.col_ind_var_id.Visible = False
            '
            'Panel7
            '
            Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel7.Controls.Add(Me.Panel8)
            Me.Panel7.Controls.Add(Me.Panel9)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel7.Location = New System.Drawing.Point(520, 30)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
            Me.Panel7.Size = New System.Drawing.Size(33, 137)
            Me.Panel7.TabIndex = 93
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.btnEliminarIndicador)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel8.Location = New System.Drawing.Point(1, 55)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(30, 37)
            Me.Panel8.TabIndex = 91
            '
            'btnEliminarIndicador
            '
            Me.btnEliminarIndicador.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminarIndicador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarIndicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarIndicador.Location = New System.Drawing.Point(0, 2)
            Me.btnEliminarIndicador.Name = "btnEliminarIndicador"
            Me.btnEliminarIndicador.Size = New System.Drawing.Size(30, 26)
            Me.btnEliminarIndicador.TabIndex = 89
            Me.btnEliminarIndicador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.btnEditarIndicador)
            Me.Panel9.Controls.Add(Me.btnNuevoIndicador)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel9.Location = New System.Drawing.Point(1, 0)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(30, 55)
            Me.Panel9.TabIndex = 90
            '
            'btnEditarIndicador
            '
            Me.btnEditarIndicador.BackgroundImage = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditarIndicador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditarIndicador.Location = New System.Drawing.Point(0, 28)
            Me.btnEditarIndicador.Name = "btnEditarIndicador"
            Me.btnEditarIndicador.Size = New System.Drawing.Size(30, 26)
            Me.btnEditarIndicador.TabIndex = 11
            Me.btnEditarIndicador.UseVisualStyleBackColor = True
            '
            'btnNuevoIndicador
            '
            Me.btnNuevoIndicador.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnNuevoIndicador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnNuevoIndicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoIndicador.Location = New System.Drawing.Point(0, 1)
            Me.btnNuevoIndicador.Name = "btnNuevoIndicador"
            Me.btnNuevoIndicador.Size = New System.Drawing.Size(30, 26)
            Me.btnNuevoIndicador.TabIndex = 88
            Me.btnNuevoIndicador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'lblValorText
            '
            Me.lblValorText.BackColor = System.Drawing.Color.Silver
            Me.lblValorText.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblValorText.Location = New System.Drawing.Point(0, 10)
            Me.lblValorText.Name = "lblValorText"
            Me.lblValorText.Size = New System.Drawing.Size(553, 20)
            Me.lblValorText.TabIndex = 94
            Me.lblValorText.Text = "Indicador por variable"
            Me.lblValorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.dgwVariable)
            Me.Panel1.Controls.Add(Me.pnlAccionRasgo)
            Me.Panel1.Controls.Add(Me.Label8)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(3, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(553, 182)
            Me.Panel1.TabIndex = 2
            '
            'dgwVariable
            '
            Me.dgwVariable.AllowUserToAddRows = False
            Me.dgwVariable.AllowUserToDeleteRows = False
            Me.dgwVariable.AllowUserToResizeRows = False
            Me.dgwVariable.BackgroundColor = System.Drawing.Color.White
            Me.dgwVariable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgwVariable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwVariable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.var_col_codigo, Me.var_col_num_ord, Me.var_col_nom})
            Me.dgwVariable.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwVariable.Location = New System.Drawing.Point(0, 20)
            Me.dgwVariable.MultiSelect = False
            Me.dgwVariable.Name = "dgwVariable"
            Me.dgwVariable.ReadOnly = True
            Me.dgwVariable.RowHeadersVisible = False
            Me.dgwVariable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwVariable.Size = New System.Drawing.Size(520, 162)
            Me.dgwVariable.TabIndex = 0
            Me.dgwVariable.VisibleCampos = False
            '
            'var_col_codigo
            '
            Me.var_col_codigo.DataPropertyName = "Codigo"
            Me.var_col_codigo.HeaderText = "Codigo"
            Me.var_col_codigo.Name = "var_col_codigo"
            Me.var_col_codigo.ReadOnly = True
            Me.var_col_codigo.Visible = False
            '
            'var_col_num_ord
            '
            Me.var_col_num_ord.DataPropertyName = "NumeroOrden"
            Me.var_col_num_ord.HeaderText = "Núm. Ord."
            Me.var_col_num_ord.Name = "var_col_num_ord"
            Me.var_col_num_ord.ReadOnly = True
            Me.var_col_num_ord.Width = 80
            '
            'var_col_nom
            '
            Me.var_col_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.var_col_nom.DataPropertyName = "Nombre"
            Me.var_col_nom.HeaderText = "Variable"
            Me.var_col_nom.Name = "var_col_nom"
            Me.var_col_nom.ReadOnly = True
            '
            'pnlAccionRasgo
            '
            Me.pnlAccionRasgo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlAccionRasgo.Controls.Add(Me.pnlRasgosEli)
            Me.pnlAccionRasgo.Controls.Add(Me.pnlRagosAdd)
            Me.pnlAccionRasgo.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAccionRasgo.Location = New System.Drawing.Point(520, 20)
            Me.pnlAccionRasgo.Name = "pnlAccionRasgo"
            Me.pnlAccionRasgo.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
            Me.pnlAccionRasgo.Size = New System.Drawing.Size(33, 162)
            Me.pnlAccionRasgo.TabIndex = 92
            '
            'pnlRasgosEli
            '
            Me.pnlRasgosEli.Controls.Add(Me.btnEliminarVariable)
            Me.pnlRasgosEli.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlRasgosEli.Location = New System.Drawing.Point(1, 55)
            Me.pnlRasgosEli.Name = "pnlRasgosEli"
            Me.pnlRasgosEli.Size = New System.Drawing.Size(30, 37)
            Me.pnlRasgosEli.TabIndex = 91
            '
            'btnEliminarVariable
            '
            Me.btnEliminarVariable.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminarVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarVariable.Location = New System.Drawing.Point(0, 2)
            Me.btnEliminarVariable.Name = "btnEliminarVariable"
            Me.btnEliminarVariable.Size = New System.Drawing.Size(30, 26)
            Me.btnEliminarVariable.TabIndex = 89
            Me.btnEliminarVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlRagosAdd
            '
            Me.pnlRagosAdd.Controls.Add(Me.btnEditarVariable)
            Me.pnlRagosAdd.Controls.Add(Me.btnNuevoVariable)
            Me.pnlRagosAdd.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlRagosAdd.Location = New System.Drawing.Point(1, 0)
            Me.pnlRagosAdd.Name = "pnlRagosAdd"
            Me.pnlRagosAdd.Size = New System.Drawing.Size(30, 55)
            Me.pnlRagosAdd.TabIndex = 90
            '
            'btnEditarVariable
            '
            Me.btnEditarVariable.BackgroundImage = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditarVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditarVariable.Location = New System.Drawing.Point(0, 28)
            Me.btnEditarVariable.Name = "btnEditarVariable"
            Me.btnEditarVariable.Size = New System.Drawing.Size(30, 26)
            Me.btnEditarVariable.TabIndex = 11
            Me.btnEditarVariable.UseVisualStyleBackColor = True
            '
            'btnNuevoVariable
            '
            Me.btnNuevoVariable.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnNuevoVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnNuevoVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoVariable.Location = New System.Drawing.Point(0, 1)
            Me.btnNuevoVariable.Name = "btnNuevoVariable"
            Me.btnNuevoVariable.Size = New System.Drawing.Size(30, 26)
            Me.btnNuevoVariable.TabIndex = 88
            Me.btnNuevoVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Silver
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label8.Location = New System.Drawing.Point(0, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(553, 20)
            Me.Label8.TabIndex = 93
            Me.Label8.Text = "Variables por ficha"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbpResultado
            '
            Me.tbpResultado.Controls.Add(Me.Panel11)
            Me.tbpResultado.Controls.Add(Me.Panel10)
            Me.tbpResultado.Location = New System.Drawing.Point(4, 22)
            Me.tbpResultado.Name = "tbpResultado"
            Me.tbpResultado.Size = New System.Drawing.Size(559, 355)
            Me.tbpResultado.TabIndex = 3
            Me.tbpResultado.Text = "Resultado"
            Me.tbpResultado.UseVisualStyleBackColor = True
            '
            'Panel11
            '
            Me.Panel11.Controls.Add(Me.UscResultadoDet1)
            Me.Panel11.Controls.Add(Me.Label10)
            Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel11.Location = New System.Drawing.Point(0, 154)
            Me.Panel11.Name = "Panel11"
            Me.Panel11.Size = New System.Drawing.Size(559, 201)
            Me.Panel11.TabIndex = 96
            '
            'UscResultadoDet1
            '
            Me.UscResultadoDet1._PermisoEliminar = False
            Me.UscResultadoDet1._PermisoEscritura = False
            Me.UscResultadoDet1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscResultadoDet1.Location = New System.Drawing.Point(0, 20)
            Me.UscResultadoDet1.Name = "UscResultadoDet1"
            Me.UscResultadoDet1.Size = New System.Drawing.Size(559, 181)
            Me.UscResultadoDet1.TabIndex = 1
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Silver
            Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label10.Location = New System.Drawing.Point(0, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(559, 20)
            Me.Label10.TabIndex = 95
            Me.Label10.Text = "Rangos de respuestas esperados de la ficha"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel10
            '
            Me.Panel10.Controls.Add(Me.UscResultado1)
            Me.Panel10.Controls.Add(Me.Label9)
            Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel10.Location = New System.Drawing.Point(0, 0)
            Me.Panel10.Name = "Panel10"
            Me.Panel10.Size = New System.Drawing.Size(559, 154)
            Me.Panel10.TabIndex = 95
            '
            'UscResultado1
            '
            Me.UscResultado1._PermisoEliminar = False
            Me.UscResultado1._PermisoEscritura = False
            Me.UscResultado1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscResultado1.Location = New System.Drawing.Point(0, 20)
            Me.UscResultado1.Name = "UscResultado1"
            Me.UscResultado1.Size = New System.Drawing.Size(559, 134)
            Me.UscResultado1.TabIndex = 0
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Silver
            Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label9.Location = New System.Drawing.Point(0, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(559, 20)
            Me.Label9.TabIndex = 95
            Me.Label9.Text = "Resultado esperados de la ficha"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.pnlGuardar)
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 386)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(761, 45)
            Me.Panel2.TabIndex = 4
            '
            'pnlGuardar
            '
            Me.pnlGuardar.Controls.Add(Me.btnGrabar)
            Me.pnlGuardar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGuardar.Location = New System.Drawing.Point(573, 0)
            Me.pnlGuardar.Name = "pnlGuardar"
            Me.pnlGuardar.Size = New System.Drawing.Size(93, 45)
            Me.pnlGuardar.TabIndex = 2
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
            Me.btnGrabar.Location = New System.Drawing.Point(1, 3)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(90, 40)
            Me.btnGrabar.TabIndex = 1
            Me.btnGrabar.Text = "&Grabar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(666, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(95, 45)
            Me.pnlSalir.TabIndex = 3
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(2, 2)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(90, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'frmFichaPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(761, 431)
            Me.Name = "frmFichaPopup"
            Me.Text = "Ficha de clasificación"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tbpFicha.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.tbpCatFicha.ResumeLayout(False)
            CType(Me.dgwCategorizacion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.tbpVarFicha.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            CType(Me.dgvIndicador, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel7.ResumeLayout(False)
            Me.Panel8.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.dgwVariable, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlAccionRasgo.ResumeLayout(False)
            Me.pnlRasgosEli.ResumeLayout(False)
            Me.pnlRagosAdd.ResumeLayout(False)
            Me.tbpResultado.ResumeLayout(False)
            Me.Panel11.ResumeLayout(False)
            Me.Panel10.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.pnlGuardar.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents tbpCatFicha As System.Windows.Forms.TabPage
        Friend WithEvents tbpVarFicha As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbbAmbitoClasificacion As APPControls.uscComboParametrica
        Friend WithEvents cbbTipoFicha As APPControls.uscComboParametrica
        Friend WithEvents txtDocAprob As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNumOrd As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDescripcion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dbrInactivo As System.Windows.Forms.RadioButton
        Friend WithEvents rbdActivo As System.Windows.Forms.RadioButton
        Friend WithEvents dtpFechaDocAprob As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dgwCategorizacion As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents dgvIndicador As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents dgwVariable As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents pnlAccionRasgo As System.Windows.Forms.Panel
        Friend WithEvents pnlRasgosEli As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarVariable As System.Windows.Forms.Button
        Friend WithEvents pnlRagosAdd As System.Windows.Forms.Panel
        Friend WithEvents btnEditarVariable As System.Windows.Forms.Button
        Friend WithEvents btnNuevoVariable As System.Windows.Forms.Button
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarCat As System.Windows.Forms.Button
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents btnEditarCat As System.Windows.Forms.Button
        Friend WithEvents btnNuevoCat As System.Windows.Forms.Button
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents Panel8 As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarIndicador As System.Windows.Forms.Button
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents btnEditarIndicador As System.Windows.Forms.Button
        Friend WithEvents btnNuevoIndicador As System.Windows.Forms.Button
        Friend WithEvents lblValorText As System.Windows.Forms.Label
        Friend WithEvents pnlGuardar As System.Windows.Forms.Panel
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents cat_col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cat_col_fic_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cat_col_cat_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cat_col_val_min As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cat_col_val_max As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents var_col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents var_col_num_ord As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents var_col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ind_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ind_num_sec As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ind_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ind_ptje As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ind_var_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tbpFicha As System.Windows.Forms.TabPage
        Friend WithEvents tbpResultado As System.Windows.Forms.TabPage
        Friend WithEvents Panel11 As System.Windows.Forms.Panel
        Friend WithEvents UscResultadoDet1 As APPControls.Mantenimiento.Tratamiento.Clasificacion.uscResultadoDet
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Panel10 As System.Windows.Forms.Panel
        Friend WithEvents UscResultado1 As APPControls.Mantenimiento.Tratamiento.Clasificacion.uscResultado
        Friend WithEvents Label9 As System.Windows.Forms.Label
    End Class
End Namespace