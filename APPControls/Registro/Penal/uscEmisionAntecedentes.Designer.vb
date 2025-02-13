Namespace Penal

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscEmisionAntecedentes
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
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.rbNoProPendMD = New System.Windows.Forms.RadioButton()
            Me.drbPositivo = New System.Windows.Forms.RadioButton()
            Me.rdbTodosTipAnt = New System.Windows.Forms.RadioButton()
            Me.rdbNegativo = New System.Windows.Forms.RadioButton()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbAnulado = New System.Windows.Forms.RadioButton()
            Me.rdbImpreso = New System.Windows.Forms.RadioButton()
            Me.rdbTerminado = New System.Windows.Forms.RadioButton()
            Me.rdbPendiente = New System.Windows.Forms.RadioButton()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.txtApePatCAJ = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaFinCAJ = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtNombresCAJ = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtApeMatCAJ = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label21 = New System.Windows.Forms.Label()
            Me.dtpFechaIniCAJ = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtInternoCodCAJ = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.txtDocSolicitudCAJ = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dgwGrillaCAJ = New Legolas.APPUIComponents.myDatagridView()
            Me.col_cod_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_id_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_aj_id_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_num_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_sol_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_imp_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_usu_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dat_hist_migra = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel6.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            CType(Me.dgwGrillaCAJ, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.GroupBox4)
            Me.Panel6.Controls.Add(Me.GroupBox5)
            Me.Panel6.Controls.Add(Me.GroupBox9)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Location = New System.Drawing.Point(0, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(1196, 109)
            Me.Panel6.TabIndex = 2
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.rbNoProPendMD)
            Me.GroupBox4.Controls.Add(Me.drbPositivo)
            Me.GroupBox4.Controls.Add(Me.rdbTodosTipAnt)
            Me.GroupBox4.Controls.Add(Me.rdbNegativo)
            Me.GroupBox4.Location = New System.Drawing.Point(3, 5)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(444, 36)
            Me.GroupBox4.TabIndex = 65
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Tipo antecedente"
            '
            'rbNoProPendMD
            '
            Me.rbNoProPendMD.AutoSize = True
            Me.rbNoProPendMD.Location = New System.Drawing.Point(13, 13)
            Me.rbNoProPendMD.Name = "rbNoProPendMD"
            Me.rbNoProPendMD.Size = New System.Drawing.Size(124, 17)
            Me.rbNoProPendMD.TabIndex = 4
            Me.rbNoProPendMD.TabStop = True
            Me.rbNoProPendMD.Text = "No Registra P.P.M.D"
            Me.rbNoProPendMD.UseVisualStyleBackColor = True
            '
            'drbPositivo
            '
            Me.drbPositivo.AutoSize = True
            Me.drbPositivo.Location = New System.Drawing.Point(164, 13)
            Me.drbPositivo.Name = "drbPositivo"
            Me.drbPositivo.Size = New System.Drawing.Size(62, 17)
            Me.drbPositivo.TabIndex = 2
            Me.drbPositivo.TabStop = True
            Me.drbPositivo.Text = "Positivo"
            Me.drbPositivo.UseVisualStyleBackColor = True
            '
            'rdbTodosTipAnt
            '
            Me.rdbTodosTipAnt.AutoSize = True
            Me.rdbTodosTipAnt.Checked = True
            Me.rdbTodosTipAnt.Location = New System.Drawing.Point(360, 13)
            Me.rdbTodosTipAnt.Name = "rdbTodosTipAnt"
            Me.rdbTodosTipAnt.Size = New System.Drawing.Size(61, 17)
            Me.rdbTodosTipAnt.TabIndex = 1
            Me.rdbTodosTipAnt.TabStop = True
            Me.rdbTodosTipAnt.Text = "[Todos]"
            Me.rdbTodosTipAnt.UseVisualStyleBackColor = True
            '
            'rdbNegativo
            '
            Me.rdbNegativo.AutoSize = True
            Me.rdbNegativo.Location = New System.Drawing.Point(263, 13)
            Me.rdbNegativo.Name = "rdbNegativo"
            Me.rdbNegativo.Size = New System.Drawing.Size(68, 17)
            Me.rdbNegativo.TabIndex = 0
            Me.rdbNegativo.TabStop = True
            Me.rdbNegativo.Text = "Negativo"
            Me.rdbNegativo.UseVisualStyleBackColor = True
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.rdbTodos)
            Me.GroupBox5.Controls.Add(Me.rdbAnulado)
            Me.GroupBox5.Controls.Add(Me.rdbImpreso)
            Me.GroupBox5.Controls.Add(Me.rdbTerminado)
            Me.GroupBox5.Controls.Add(Me.rdbPendiente)
            Me.GroupBox5.Location = New System.Drawing.Point(640, 7)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(400, 36)
            Me.GroupBox5.TabIndex = 64
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Estado"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Location = New System.Drawing.Point(311, 15)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbTodos.TabIndex = 4
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "[Todos]"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbAnulado
            '
            Me.rdbAnulado.AutoSize = True
            Me.rdbAnulado.Location = New System.Drawing.Point(239, 15)
            Me.rdbAnulado.Name = "rdbAnulado"
            Me.rdbAnulado.Size = New System.Drawing.Size(64, 17)
            Me.rdbAnulado.TabIndex = 3
            Me.rdbAnulado.Text = "Anulado"
            Me.rdbAnulado.UseVisualStyleBackColor = True
            '
            'rdbImpreso
            '
            Me.rdbImpreso.AutoSize = True
            Me.rdbImpreso.Location = New System.Drawing.Point(168, 15)
            Me.rdbImpreso.Name = "rdbImpreso"
            Me.rdbImpreso.Size = New System.Drawing.Size(62, 17)
            Me.rdbImpreso.TabIndex = 2
            Me.rdbImpreso.Text = "Impreso"
            Me.rdbImpreso.UseVisualStyleBackColor = True
            '
            'rdbTerminado
            '
            Me.rdbTerminado.AutoSize = True
            Me.rdbTerminado.Location = New System.Drawing.Point(85, 15)
            Me.rdbTerminado.Name = "rdbTerminado"
            Me.rdbTerminado.Size = New System.Drawing.Size(75, 17)
            Me.rdbTerminado.TabIndex = 1
            Me.rdbTerminado.Text = "Terminado"
            Me.rdbTerminado.UseVisualStyleBackColor = True
            '
            'rdbPendiente
            '
            Me.rdbPendiente.AutoSize = True
            Me.rdbPendiente.Location = New System.Drawing.Point(5, 15)
            Me.rdbPendiente.Name = "rdbPendiente"
            Me.rdbPendiente.Size = New System.Drawing.Size(73, 17)
            Me.rdbPendiente.TabIndex = 0
            Me.rdbPendiente.Text = "Pendiente"
            Me.rdbPendiente.UseVisualStyleBackColor = True
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.txtApePatCAJ)
            Me.GroupBox9.Controls.Add(Me.dtpFechaFinCAJ)
            Me.GroupBox9.Controls.Add(Me.Label17)
            Me.GroupBox9.Controls.Add(Me.Label18)
            Me.GroupBox9.Controls.Add(Me.Label19)
            Me.GroupBox9.Controls.Add(Me.txtNombresCAJ)
            Me.GroupBox9.Controls.Add(Me.Label20)
            Me.GroupBox9.Controls.Add(Me.txtApeMatCAJ)
            Me.GroupBox9.Controls.Add(Me.Label21)
            Me.GroupBox9.Controls.Add(Me.dtpFechaIniCAJ)
            Me.GroupBox9.Controls.Add(Me.txtInternoCodCAJ)
            Me.GroupBox9.Controls.Add(Me.Label22)
            Me.GroupBox9.Controls.Add(Me.Label23)
            Me.GroupBox9.Controls.Add(Me.txtDocSolicitudCAJ)
            Me.GroupBox9.Location = New System.Drawing.Point(5, 40)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(1036, 62)
            Me.GroupBox9.TabIndex = 59
            Me.GroupBox9.TabStop = False
            Me.GroupBox9.Text = "Datos de búsqueda"
            '
            'txtApePatCAJ
            '
            Me.txtApePatCAJ._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePatCAJ._BloquearPaste = False
            Me.txtApePatCAJ._SeleccionarTodo = False
            Me.txtApePatCAJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApePatCAJ.Location = New System.Drawing.Point(100, 15)
            Me.txtApePatCAJ.Name = "txtApePatCAJ"
            Me.txtApePatCAJ.Size = New System.Drawing.Size(209, 20)
            Me.txtApePatCAJ.TabIndex = 13
            Me.txtApePatCAJ.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePatCAJ.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dtpFechaFinCAJ
            '
            Me.dtpFechaFinCAJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFinCAJ.Location = New System.Drawing.Point(873, 37)
            Me.dtpFechaFinCAJ.Name = "dtpFechaFinCAJ"
            Me.dtpFechaFinCAJ.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFinCAJ.TabIndex = 24
            Me.dtpFechaFinCAJ.Value = "/  /"
            Me.dtpFechaFinCAJ.ValueLong = CType(0, Long)
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(327, 41)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(69, 13)
            Me.Label17.TabIndex = 57
            Me.Label17.Text = "N° Doc. Sol.:"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(836, 41)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(16, 13)
            Me.Label18.TabIndex = 58
            Me.Label18.Text = "---"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(632, 41)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(97, 13)
            Me.Label19.TabIndex = 57
            Me.Label19.Text = "F. Solicitud desde :"
            '
            'txtNombresCAJ
            '
            Me.txtNombresCAJ._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombresCAJ._BloquearPaste = False
            Me.txtNombresCAJ._SeleccionarTodo = False
            Me.txtNombresCAJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombresCAJ.Location = New System.Drawing.Point(733, 15)
            Me.txtNombresCAJ.Name = "txtNombresCAJ"
            Me.txtNombresCAJ.Size = New System.Drawing.Size(224, 20)
            Me.txtNombresCAJ.TabIndex = 2
            Me.txtNombresCAJ.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombresCAJ.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(28, 41)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(68, 13)
            Me.Label20.TabIndex = 57
            Me.Label20.Text = "Cod. Interno:"
            '
            'txtApeMatCAJ
            '
            Me.txtApeMatCAJ._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMatCAJ._BloquearPaste = False
            Me.txtApeMatCAJ._SeleccionarTodo = False
            Me.txtApeMatCAJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApeMatCAJ.Location = New System.Drawing.Point(400, 15)
            Me.txtApeMatCAJ.Name = "txtApeMatCAJ"
            Me.txtApeMatCAJ.Size = New System.Drawing.Size(209, 20)
            Me.txtApeMatCAJ.TabIndex = 1
            Me.txtApeMatCAJ.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMatCAJ.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(30, 19)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(61, 13)
            Me.Label21.TabIndex = 57
            Me.Label21.Text = "Primer Ap. :"
            '
            'dtpFechaIniCAJ
            '
            Me.dtpFechaIniCAJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaIniCAJ.Location = New System.Drawing.Point(733, 37)
            Me.dtpFechaIniCAJ.Name = "dtpFechaIniCAJ"
            Me.dtpFechaIniCAJ.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIniCAJ.TabIndex = 23
            Me.dtpFechaIniCAJ.Value = "/  /"
            Me.dtpFechaIniCAJ.ValueLong = CType(0, Long)
            '
            'txtInternoCodCAJ
            '
            Me.txtInternoCodCAJ._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtInternoCodCAJ._BloquearPaste = False
            Me.txtInternoCodCAJ._SeleccionarTodo = False
            Me.txtInternoCodCAJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtInternoCodCAJ.Location = New System.Drawing.Point(100, 38)
            Me.txtInternoCodCAJ.Name = "txtInternoCodCAJ"
            Me.txtInternoCodCAJ.Size = New System.Drawing.Size(128, 20)
            Me.txtInternoCodCAJ.TabIndex = 3
            Me.txtInternoCodCAJ.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtInternoCodCAJ.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(329, 19)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(75, 13)
            Me.Label22.TabIndex = 57
            Me.Label22.Text = "Segundo Ap. :"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(671, 19)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(58, 13)
            Me.Label23.TabIndex = 57
            Me.Label23.Text = "Nombre(s):"
            '
            'txtDocSolicitudCAJ
            '
            Me.txtDocSolicitudCAJ._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDocSolicitudCAJ._BloquearPaste = False
            Me.txtDocSolicitudCAJ._SeleccionarTodo = False
            Me.txtDocSolicitudCAJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDocSolicitudCAJ.Location = New System.Drawing.Point(400, 38)
            Me.txtDocSolicitudCAJ.Name = "txtDocSolicitudCAJ"
            Me.txtDocSolicitudCAJ.Size = New System.Drawing.Size(209, 20)
            Me.txtDocSolicitudCAJ.TabIndex = 4
            Me.txtDocSolicitudCAJ.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDocSolicitudCAJ.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dgwGrillaCAJ
            '
            Me.dgwGrillaCAJ.AllowUserToAddRows = False
            Me.dgwGrillaCAJ.AllowUserToDeleteRows = False
            Me.dgwGrillaCAJ.AllowUserToResizeRows = False
            Me.dgwGrillaCAJ.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaCAJ.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaCAJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaCAJ.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cod_caj, Me.col_est_id_caj, Me.col_est_caj, Me.col_tip_aj_id_caj, Me.col_tip_caj, Me.Column1, Me.col_sol_num_caj, Me.col_fec_sol_caj, Me.col_ape_pat_caj, Me.col_ape_mat_caj, Me.col_nom_caj, Me.col_num_imp_caj, Me.col_cod_usu_caj, Me.col_dat_hist_migra, Me.col_reg_id, Me.col_reg_nom})
            Me.dgwGrillaCAJ.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaCAJ.Location = New System.Drawing.Point(0, 109)
            Me.dgwGrillaCAJ.MultiSelect = False
            Me.dgwGrillaCAJ.Name = "dgwGrillaCAJ"
            Me.dgwGrillaCAJ.ReadOnly = True
            Me.dgwGrillaCAJ.RowHeadersVisible = False
            Me.dgwGrillaCAJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaCAJ.Size = New System.Drawing.Size(1196, 337)
            Me.dgwGrillaCAJ.TabIndex = 77
            Me.dgwGrillaCAJ.VisibleCampos = False
            '
            'col_cod_caj
            '
            Me.col_cod_caj.DataPropertyName = "Codigo"
            Me.col_cod_caj.HeaderText = "Codigo"
            Me.col_cod_caj.Name = "col_cod_caj"
            Me.col_cod_caj.ReadOnly = True
            Me.col_cod_caj.Visible = False
            '
            'col_est_id_caj
            '
            Me.col_est_id_caj.DataPropertyName = "EstadoSolicitudId"
            Me.col_est_id_caj.DividerWidth = 1
            Me.col_est_id_caj.HeaderText = "IDEstado"
            Me.col_est_id_caj.Name = "col_est_id_caj"
            Me.col_est_id_caj.ReadOnly = True
            Me.col_est_id_caj.Visible = False
            '
            'col_est_caj
            '
            Me.col_est_caj.HeaderText = "Est."
            Me.col_est_caj.Name = "col_est_caj"
            Me.col_est_caj.ReadOnly = True
            Me.col_est_caj.Width = 30
            '
            'col_tip_aj_id_caj
            '
            Me.col_tip_aj_id_caj.DataPropertyName = "TipoAntecedenteId"
            Me.col_tip_aj_id_caj.HeaderText = "IDTipoAnteJud"
            Me.col_tip_aj_id_caj.Name = "col_tip_aj_id_caj"
            Me.col_tip_aj_id_caj.ReadOnly = True
            Me.col_tip_aj_id_caj.Visible = False
            '
            'col_tip_caj
            '
            Me.col_tip_caj.DataPropertyName = "TipoAntecedenteStr"
            Me.col_tip_caj.HeaderText = "Tipo de antecedente"
            Me.col_tip_caj.Name = "col_tip_caj"
            Me.col_tip_caj.ReadOnly = True
            Me.col_tip_caj.Width = 150
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "DocumentoNumero"
            Me.Column1.HeaderText = "Numero Doc."
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 120
            '
            'col_sol_num_caj
            '
            Me.col_sol_num_caj.DataPropertyName = "getNumeroSolicitudPenal"
            Me.col_sol_num_caj.HeaderText = "N° Solicitud"
            Me.col_sol_num_caj.Name = "col_sol_num_caj"
            Me.col_sol_num_caj.ReadOnly = True
            '
            'col_fec_sol_caj
            '
            Me.col_fec_sol_caj.DataPropertyName = "FechaSolicitudStr"
            Me.col_fec_sol_caj.HeaderText = "Fecha solicitud"
            Me.col_fec_sol_caj.Name = "col_fec_sol_caj"
            Me.col_fec_sol_caj.ReadOnly = True
            Me.col_fec_sol_caj.Width = 90
            '
            'col_ape_pat_caj
            '
            Me.col_ape_pat_caj.DataPropertyName = "InternoApePaterno"
            Me.col_ape_pat_caj.HeaderText = "Primer Ap."
            Me.col_ape_pat_caj.Name = "col_ape_pat_caj"
            Me.col_ape_pat_caj.ReadOnly = True
            Me.col_ape_pat_caj.Width = 150
            '
            'col_ape_mat_caj
            '
            Me.col_ape_mat_caj.DataPropertyName = "InternoApeMaterno"
            Me.col_ape_mat_caj.HeaderText = "Segundo Ap."
            Me.col_ape_mat_caj.Name = "col_ape_mat_caj"
            Me.col_ape_mat_caj.ReadOnly = True
            Me.col_ape_mat_caj.Width = 150
            '
            'col_nom_caj
            '
            Me.col_nom_caj.DataPropertyName = "InternoNombres"
            Me.col_nom_caj.HeaderText = "Nombre(s)"
            Me.col_nom_caj.Name = "col_nom_caj"
            Me.col_nom_caj.ReadOnly = True
            Me.col_nom_caj.Width = 150
            '
            'col_num_imp_caj
            '
            Me.col_num_imp_caj.DataPropertyName = "NumImpresiones"
            Me.col_num_imp_caj.HeaderText = "N° Impr."
            Me.col_num_imp_caj.Name = "col_num_imp_caj"
            Me.col_num_imp_caj.ReadOnly = True
            Me.col_num_imp_caj.Width = 40
            '
            'col_cod_usu_caj
            '
            Me.col_cod_usu_caj.DataPropertyName = "UsuarioCrea"
            Me.col_cod_usu_caj.HeaderText = "Usuario"
            Me.col_cod_usu_caj.Name = "col_cod_usu_caj"
            Me.col_cod_usu_caj.ReadOnly = True
            Me.col_cod_usu_caj.Width = 190
            '
            'col_dat_hist_migra
            '
            Me.col_dat_hist_migra.DataPropertyName = "DataHistoricaMigracion"
            Me.col_dat_hist_migra.HeaderText = "DataHistorica"
            Me.col_dat_hist_migra.Name = "col_dat_hist_migra"
            Me.col_dat_hist_migra.ReadOnly = True
            Me.col_dat_hist_migra.Visible = False
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionId"
            Me.col_reg_id.HeaderText = "IDRegion"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "RegionNombre"
            Me.col_reg_nom.HeaderText = "RegionNombre"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            Me.col_reg_nom.Visible = False
            '
            'uscEmisionAntecedentes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrillaCAJ)
            Me.Controls.Add(Me.Panel6)
            Me.Name = "uscEmisionAntecedentes"
            Me.Size = New System.Drawing.Size(1196, 446)
            Me.Panel6.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            CType(Me.dgwGrillaCAJ, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel6 As Panel
        Friend WithEvents GroupBox4 As GroupBox
        Friend WithEvents rbNoProPendMD As RadioButton
        Friend WithEvents drbPositivo As RadioButton
        Friend WithEvents rdbTodosTipAnt As RadioButton
        Friend WithEvents rdbNegativo As RadioButton
        Friend WithEvents GroupBox5 As GroupBox
        Friend WithEvents rdbTodos As RadioButton
        Friend WithEvents rdbAnulado As RadioButton
        Friend WithEvents rdbImpreso As RadioButton
        Friend WithEvents rdbTerminado As RadioButton
        Friend WithEvents rdbPendiente As RadioButton
        Friend WithEvents GroupBox9 As GroupBox
        Friend WithEvents txtApePatCAJ As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpFechaFinCAJ As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label17 As Label
        Friend WithEvents Label18 As Label
        Friend WithEvents Label19 As Label
        Friend WithEvents txtNombresCAJ As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label20 As Label
        Friend WithEvents txtApeMatCAJ As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label21 As Label
        Friend WithEvents dtpFechaIniCAJ As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtInternoCodCAJ As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label22 As Label
        Friend WithEvents Label23 As Label
        Friend WithEvents txtDocSolicitudCAJ As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dgwGrillaCAJ As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_cod_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_est_id_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_est_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_aj_id_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_caj As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents col_sol_num_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_sol_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_num_imp_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_usu_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_dat_hist_migra As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As DataGridViewTextBoxColumn
    End Class
End Namespace