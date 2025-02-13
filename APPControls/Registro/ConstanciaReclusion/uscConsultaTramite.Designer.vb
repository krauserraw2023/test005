Namespace Registro.ConsultaReclusion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscConsultaTramite
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtNumeroRef = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbTipoEstado = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.cbbTipoDocumentoRef = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.cbbtipoFechas = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtCodigoInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtnombreInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApellidosInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbTipSolicitante = New APPControls.uscComboParametrica()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.col_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_idInterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_idIngresoInpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_idIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_region = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_Penal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_tip_lic = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_Tram = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_rec_ep = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_rec_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_sol = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_tram = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_recibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_solicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_codigo_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_nom_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_cr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_cr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cant_impr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nro, Me.col_codigo, Me.col_idInterno, Me.col_idIngresoInpe, Me.col_idIngreso, Me.col_id_region, Me.col_reg_nom, Me.col_id_Penal, Me.col_pen_nom, Me.col_pen_tip_lic, Me.col_num_Tram, Me.Column1, Me.col_fec_rec_ep, Me.col_fec_rec_rp, Me.col_tip_sol, Me.col_tip_tram, Me.col_num_recibo, Me.col_tip_solicitante, Me.col_codigo_rp, Me.col_ape_nom_int, Me.col_num_cr, Me.col_fec_cr, Me.col_est, Me.col_est_nom, Me.col_cant_impr})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 114)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1266, 518)
            Me.dgwGrilla.TabIndex = 5
            Me.dgwGrilla.VisibleCampos = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtNumeroRef)
            Me.GroupBox1.Controls.Add(Me.cbbTipoEstado)
            Me.GroupBox1.Controls.Add(Me.cbbTipoDocumentoRef)
            Me.GroupBox1.Controls.Add(Me.cbbtipoFechas)
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.dtpFechaIni)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.cbbTipSolicitante)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.cbbPenal)
            Me.GroupBox1.Controls.Add(Me.cbbRegion)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.Label28)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1266, 114)
            Me.GroupBox1.TabIndex = 60
            Me.GroupBox1.TabStop = False
            '
            'txtNumeroRef
            '
            Me.txtNumeroRef._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumeroRef._BloquearPaste = False
            Me.txtNumeroRef._SeleccionarTodo = False
            Me.txtNumeroRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroRef.Location = New System.Drawing.Point(708, 46)
            Me.txtNumeroRef.MaxLength = 10
            Me.txtNumeroRef.Name = "txtNumeroRef"
            Me.txtNumeroRef.Size = New System.Drawing.Size(156, 20)
            Me.txtNumeroRef.TabIndex = 7
            Me.txtNumeroRef.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumeroRef.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbTipoEstado
            '
            Me.cbbTipoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTipoEstado.FormattingEnabled = True
            Me.cbbTipoEstado.Location = New System.Drawing.Point(708, 73)
            Me.cbbTipoEstado.Name = "cbbTipoEstado"
            Me.cbbTipoEstado.Size = New System.Drawing.Size(154, 21)
            Me.cbbTipoEstado.TabIndex = 8
            '
            'cbbTipoDocumentoRef
            '
            Me.cbbTipoDocumentoRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTipoDocumentoRef.FormattingEnabled = True
            Me.cbbTipoDocumentoRef.Location = New System.Drawing.Point(708, 19)
            Me.cbbTipoDocumentoRef.Name = "cbbTipoDocumentoRef"
            Me.cbbTipoDocumentoRef.Size = New System.Drawing.Size(154, 21)
            Me.cbbTipoDocumentoRef.TabIndex = 6
            '
            'cbbtipoFechas
            '
            Me.cbbtipoFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbtipoFechas.FormattingEnabled = True
            Me.cbbtipoFechas.Location = New System.Drawing.Point(434, 21)
            Me.cbbtipoFechas.Name = "cbbtipoFechas"
            Me.cbbtipoFechas.Size = New System.Drawing.Size(154, 21)
            Me.cbbtipoFechas.TabIndex = 3
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.txtCodigoInterno)
            Me.GroupBox2.Controls.Add(Me.txtnombreInterno)
            Me.GroupBox2.Controls.Add(Me.txtApellidosInterno)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Location = New System.Drawing.Point(875, 11)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(297, 95)
            Me.GroupBox2.TabIndex = 78
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Datos del interno"
            '
            'txtCodigoInterno
            '
            Me.txtCodigoInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodigoInterno._BloquearPaste = False
            Me.txtCodigoInterno._SeleccionarTodo = False
            Me.txtCodigoInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoInterno.Location = New System.Drawing.Point(99, 19)
            Me.txtCodigoInterno.MaxLength = 10
            Me.txtCodigoInterno.Name = "txtCodigoInterno"
            Me.txtCodigoInterno.Size = New System.Drawing.Size(126, 20)
            Me.txtCodigoInterno.TabIndex = 9
            Me.txtCodigoInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodigoInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtnombreInterno
            '
            Me.txtnombreInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtnombreInterno._BloquearPaste = False
            Me.txtnombreInterno._SeleccionarTodo = True
            Me.txtnombreInterno.Location = New System.Drawing.Point(99, 67)
            Me.txtnombreInterno.Name = "txtnombreInterno"
            Me.txtnombreInterno.Size = New System.Drawing.Size(186, 20)
            Me.txtnombreInterno.TabIndex = 11
            Me.txtnombreInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtnombreInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApellidosInterno
            '
            Me.txtApellidosInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidosInterno._BloquearPaste = False
            Me.txtApellidosInterno._SeleccionarTodo = True
            Me.txtApellidosInterno.Location = New System.Drawing.Point(99, 43)
            Me.txtApellidosInterno.Name = "txtApellidosInterno"
            Me.txtApellidosInterno.Size = New System.Drawing.Size(186, 20)
            Me.txtApellidosInterno.TabIndex = 10
            Me.txtApellidosInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidosInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.BackColor = System.Drawing.Color.Transparent
            Me.Label14.Location = New System.Drawing.Point(15, 69)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(52, 13)
            Me.Label14.TabIndex = 30
            Me.Label14.Text = "Nombres:"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.BackColor = System.Drawing.Color.Transparent
            Me.Label13.Location = New System.Drawing.Point(15, 45)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(52, 13)
            Me.Label13.TabIndex = 29
            Me.Label13.Text = "Apellidos:"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.BackColor = System.Drawing.Color.Transparent
            Me.Label12.Location = New System.Drawing.Point(14, 22)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(76, 13)
            Me.Label12.TabIndex = 28
            Me.Label12.Text = "Código Interno"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(613, 79)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(93, 13)
            Me.Label7.TabIndex = 77
            Me.Label7.Text = "Estado de Trámite"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(613, 50)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(92, 13)
            Me.Label4.TabIndex = 76
            Me.Label4.Text = "N° de Documento"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(613, 23)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(86, 13)
            Me.Label3.TabIndex = 72
            Me.Label3.Text = "Tipo Documento"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Location = New System.Drawing.Point(434, 75)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 5
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(372, 79)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(41, 13)
            Me.Label6.TabIndex = 71
            Me.Label6.Text = "Hasta :"
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Location = New System.Drawing.Point(434, 48)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 4
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(369, 50)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 13)
            Me.Label5.TabIndex = 70
            Me.Label5.Text = "Desde :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(369, 23)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(64, 13)
            Me.Label2.TabIndex = 66
            Me.Label2.Text = "Por Fechas:"
            '
            'cbbTipSolicitante
            '
            Me.cbbTipSolicitante._NoIndica = False
            Me.cbbTipSolicitante._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipSolicitante._Todos = False
            Me.cbbTipSolicitante._TodosMensaje = ""
            Me.cbbTipSolicitante._Visible_Add = False
            Me.cbbTipSolicitante._Visible_Buscar = False
            Me.cbbTipSolicitante._Visible_Eliminar = False
            Me.cbbTipSolicitante.CodigoPadre = -1
            Me.cbbTipSolicitante.ComboTipo = CType(17, Short)
            Me.cbbTipSolicitante.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipSolicitante.DropDownWidth = 325
            Me.cbbTipSolicitante.DropDownWidthAuto = False
            Me.cbbTipSolicitante.ListaIdsParaExcluir = Nothing
            Me.cbbTipSolicitante.Location = New System.Drawing.Point(100, 75)
            Me.cbbTipSolicitante.ModuloTratamiento = False
            Me.cbbTipSolicitante.Name = "cbbTipSolicitante"
            Me.cbbTipSolicitante.Parametro1 = -1
            Me.cbbTipSolicitante.Parametro2 = -1
            Me.cbbTipSolicitante.SelectedIndex = -1
            Me.cbbTipSolicitante.SelectedValue = 0
            Me.cbbTipSolicitante.Size = New System.Drawing.Size(247, 22)
            Me.cbbTipSolicitante.TabIndex = 2
            Me.cbbTipSolicitante.verToolTipItemSeleccionado = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 79)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(59, 13)
            Me.Label1.TabIndex = 64
            Me.Label1.Text = "Solicitante:"
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
            Me.cbbPenal.DropDownWidth = 217
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(100, 47)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(247, 22)
            Me.cbbPenal.TabIndex = 1
            Me.cbbPenal.verToolTipItemSeleccionado = False
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
            Me.cbbRegion.DropDownWidth = 217
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(100, 19)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(247, 22)
            Me.cbbRegion.TabIndex = 0
            Me.cbbRegion.verToolTipItemSeleccionado = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(11, 50)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(92, 13)
            Me.Label11.TabIndex = 60
            Me.Label11.Text = "Est. Penitenciario:"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(11, 23)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(88, 13)
            Me.Label28.TabIndex = 61
            Me.Label28.Text = "Oficina Regional:"
            '
            'col_nro
            '
            Me.col_nro.DataPropertyName = "nro"
            Me.col_nro.HeaderText = "N°"
            Me.col_nro.Name = "col_nro"
            Me.col_nro.ReadOnly = True
            Me.col_nro.Visible = False
            Me.col_nro.Width = 20
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "codigo"
            Me.col_codigo.HeaderText = "codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            Me.col_codigo.Width = 5
            '
            'col_idInterno
            '
            Me.col_idInterno.DataPropertyName = "idInterno"
            Me.col_idInterno.HeaderText = "InternoID"
            Me.col_idInterno.Name = "col_idInterno"
            Me.col_idInterno.ReadOnly = True
            Me.col_idInterno.Visible = False
            '
            'col_idIngresoInpe
            '
            Me.col_idIngresoInpe.DataPropertyName = "idIngresoInpe"
            Me.col_idIngresoInpe.HeaderText = "InpeIng"
            Me.col_idIngresoInpe.Name = "col_idIngresoInpe"
            Me.col_idIngresoInpe.ReadOnly = True
            Me.col_idIngresoInpe.Visible = False
            Me.col_idIngresoInpe.Width = 5
            '
            'col_idIngreso
            '
            Me.col_idIngreso.DataPropertyName = "idIngreso"
            Me.col_idIngreso.HeaderText = "IngresoID"
            Me.col_idIngreso.Name = "col_idIngreso"
            Me.col_idIngreso.ReadOnly = True
            Me.col_idIngreso.Visible = False
            Me.col_idIngreso.Width = 5
            '
            'col_id_region
            '
            Me.col_id_region.DataPropertyName = "idRegion"
            Me.col_id_region.HeaderText = "IDRegion"
            Me.col_id_region.Name = "col_id_region"
            Me.col_id_region.ReadOnly = True
            Me.col_id_region.Visible = False
            Me.col_id_region.Width = 50
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "RegionNombre"
            Me.col_reg_nom.HeaderText = "Oficina Regional"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            Me.col_reg_nom.Visible = False
            Me.col_reg_nom.Width = 150
            '
            'col_id_Penal
            '
            Me.col_id_Penal.DataPropertyName = "idPenal"
            Me.col_id_Penal.HeaderText = "IDPenal"
            Me.col_id_Penal.Name = "col_id_Penal"
            Me.col_id_Penal.ReadOnly = True
            Me.col_id_Penal.Visible = False
            Me.col_id_Penal.Width = 50
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_pen_nom.HeaderText = "Establecimiento Penitenciario"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            Me.col_pen_nom.Visible = False
            Me.col_pen_nom.Width = 150
            '
            'col_pen_tip_lic
            '
            Me.col_pen_tip_lic.DataPropertyName = "penalTipoLicencia"
            Me.col_pen_tip_lic.HeaderText = "penalTipoLicencia"
            Me.col_pen_tip_lic.Name = "col_pen_tip_lic"
            Me.col_pen_tip_lic.ReadOnly = True
            Me.col_pen_tip_lic.Visible = False
            '
            'col_num_Tram
            '
            Me.col_num_Tram.DataPropertyName = "numeroTramite"
            Me.col_num_Tram.HeaderText = "N°. de trámite"
            Me.col_num_Tram.Name = "col_num_Tram"
            Me.col_num_Tram.ReadOnly = True
            Me.col_num_Tram.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_num_Tram.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_num_Tram.Width = 90
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "tramiteFechaRegistro"
            Me.Column1.HeaderText = "Fec.  y hora Registro Tramite"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 110
            '
            'col_fec_rec_ep
            '
            Me.col_fec_rec_ep.DataPropertyName = "fechaRecepcionEP"
            Me.col_fec_rec_ep.HeaderText = "F. recep. del requerimiento en el EP"
            Me.col_fec_rec_ep.Name = "col_fec_rec_ep"
            Me.col_fec_rec_ep.ReadOnly = True
            Me.col_fec_rec_ep.ToolTipText = "F. recep. del requerimiento en el EP"
            Me.col_fec_rec_ep.Width = 80
            '
            'col_fec_rec_rp
            '
            Me.col_fec_rec_rp.DataPropertyName = "fechaRecepcionRP"
            Me.col_fec_rec_rp.DividerWidth = 1
            Me.col_fec_rec_rp.HeaderText = "F. recep. del requerimiento en el RP"
            Me.col_fec_rec_rp.Name = "col_fec_rec_rp"
            Me.col_fec_rec_rp.ReadOnly = True
            Me.col_fec_rec_rp.ToolTipText = "F. recep. del requerimiento en el RP"
            Me.col_fec_rec_rp.Width = 80
            '
            'col_tip_sol
            '
            Me.col_tip_sol.DataPropertyName = "documentoReferenciaTipoNombre"
            Me.col_tip_sol.DividerWidth = 1
            Me.col_tip_sol.HeaderText = "Ref. del documento por el cual se hace el requerimiento"
            Me.col_tip_sol.Name = "col_tip_sol"
            Me.col_tip_sol.ReadOnly = True
            Me.col_tip_sol.ToolTipText = "Ref. del documento por el cual se hace el requerimiento"
            Me.col_tip_sol.Width = 200
            '
            'col_tip_tram
            '
            Me.col_tip_tram.DataPropertyName = "tipoTramite "
            Me.col_tip_tram.HeaderText = "Tipo Tramite"
            Me.col_tip_tram.Name = "col_tip_tram"
            Me.col_tip_tram.ReadOnly = True
            Me.col_tip_tram.Visible = False
            Me.col_tip_tram.Width = 5
            '
            'col_num_recibo
            '
            Me.col_num_recibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_num_recibo.DataPropertyName = "serieNumeroRecibo"
            Me.col_num_recibo.DividerWidth = 1
            Me.col_num_recibo.HeaderText = "N° recibo de pago"
            Me.col_num_recibo.Name = "col_num_recibo"
            Me.col_num_recibo.ReadOnly = True
            Me.col_num_recibo.ToolTipText = "Número de recibo de pago del Interno"
            Me.col_num_recibo.Width = 74
            '
            'col_tip_solicitante
            '
            Me.col_tip_solicitante.DataPropertyName = "solicitanteNombre"
            Me.col_tip_solicitante.HeaderText = "Solicitante"
            Me.col_tip_solicitante.Name = "col_tip_solicitante"
            Me.col_tip_solicitante.ReadOnly = True
            Me.col_tip_solicitante.ToolTipText = "Tipo de Solicitante"
            Me.col_tip_solicitante.Width = 350
            '
            'col_codigo_rp
            '
            Me.col_codigo_rp.DataPropertyName = "internoCodigoRD"
            Me.col_codigo_rp.HeaderText = "Código del Interno"
            Me.col_codigo_rp.Name = "col_codigo_rp"
            Me.col_codigo_rp.ReadOnly = True
            Me.col_codigo_rp.ToolTipText = "Código del Interno"
            Me.col_codigo_rp.Width = 80
            '
            'col_ape_nom_int
            '
            Me.col_ape_nom_int.DataPropertyName = "getInternoApellidosNombre"
            DataGridViewCellStyle2.Format = "d"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.col_ape_nom_int.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_ape_nom_int.HeaderText = "Apellidos y Nombres del Interno"
            Me.col_ape_nom_int.Name = "col_ape_nom_int"
            Me.col_ape_nom_int.ReadOnly = True
            Me.col_ape_nom_int.ToolTipText = "Apellidos y Nombres del Interno"
            Me.col_ape_nom_int.Width = 300
            '
            'col_num_cr
            '
            Me.col_num_cr.DataPropertyName = "numeroCR"
            Me.col_num_cr.HeaderText = "N° CR"
            Me.col_num_cr.Name = "col_num_cr"
            Me.col_num_cr.ReadOnly = True
            Me.col_num_cr.ToolTipText = "Número de Constancia de Reclusion"
            Me.col_num_cr.Width = 90
            '
            'col_fec_cr
            '
            Me.col_fec_cr.DataPropertyName = "fechaCR"
            Me.col_fec_cr.HeaderText = "F. Expedición de CR"
            Me.col_fec_cr.Name = "col_fec_cr"
            Me.col_fec_cr.ReadOnly = True
            Me.col_fec_cr.ToolTipText = "Fecha de expedición de la Constancia de Reclusión"
            Me.col_fec_cr.Width = 110
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "estado"
            Me.col_est.HeaderText = "estadoID"
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Visible = False
            Me.col_est.Width = 5
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "estadoNombre"
            Me.col_est_nom.HeaderText = "Estado Trámite"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            '
            'col_cant_impr
            '
            Me.col_cant_impr.DataPropertyName = "contadorCR"
            Me.col_cant_impr.HeaderText = "Cant. Imp."
            Me.col_cant_impr.Name = "col_cant_impr"
            Me.col_cant_impr.ReadOnly = True
            Me.col_cant_impr.Width = 60
            '
            'uscConsultaTramite
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "uscConsultaTramite"
            Me.Size = New System.Drawing.Size(1266, 632)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents cbbPenal As uscComboParametrica
        Friend WithEvents cbbRegion As uscComboParametrica
        Friend WithEvents Label11 As Label
        Friend WithEvents Label28 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents cbbTipSolicitante As uscComboParametrica
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label5 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents txtnombreInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApellidosInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label14 As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents Label12 As Label
        Protected WithEvents cbbtipoFechas As Legolas.APPUIComponents.MyComboBox
        Protected WithEvents cbbTipoEstado As Legolas.APPUIComponents.MyComboBox
        Protected WithEvents cbbTipoDocumentoRef As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents txtNumeroRef As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtCodigoInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents col_nro As DataGridViewTextBoxColumn
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_idInterno As DataGridViewTextBoxColumn
        Friend WithEvents col_idIngresoInpe As DataGridViewTextBoxColumn
        Friend WithEvents col_idIngreso As DataGridViewTextBoxColumn
        Friend WithEvents col_id_region As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_id_Penal As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_tip_lic As DataGridViewTextBoxColumn
        Friend WithEvents col_num_Tram As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_rec_ep As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_rec_rp As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_sol As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_tram As DataGridViewTextBoxColumn
        Friend WithEvents col_num_recibo As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_solicitante As DataGridViewTextBoxColumn
        Friend WithEvents col_codigo_rp As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_nom_int As DataGridViewTextBoxColumn
        Friend WithEvents col_num_cr As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_cr As DataGridViewTextBoxColumn
        Friend WithEvents col_est As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_cant_impr As DataGridViewTextBoxColumn
    End Class

End Namespace