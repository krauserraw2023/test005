Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmOrdenTrasladoHospital
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.PnlBotonesGrabar = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtObsLib = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlTitulo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tbp01 = New System.Windows.Forms.TabPage()
            Me.UscExpeDeResolucion = New APPControls.Registro.Documento.uscExpeDeResolucion()
            Me.tbp02 = New System.Windows.Forms.TabPage()
            Me.UscQueda1 = New APPControls.uscQueda()
            Me.tbp03 = New System.Windows.Forms.TabPage()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_fec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_grp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_tip_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_mot_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_fec_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_fec_rec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_Justificación = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.UscResolAclaratoriaExpe1 = New APPControls.Registro.Resoluciones.uscResolAclaratoriaExpe()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotonesGrabar.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlTitulo.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tbp01.SuspendLayout()
            Me.tbp02.SuspendLayout()
            Me.tbp03.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.TabControl1)
            Me.gbxFormChildContainer.Controls.Add(Me.UscResolAclaratoriaExpe1)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlTitulo)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlCabecera)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(965, 605)
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlBotonesGrabar)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 564)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(965, 41)
            Me.PnlInferior.TabIndex = 4
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(770, 41)
            Me.UscAuditUser1.TabIndex = 0
            '
            'PnlBotonesGrabar
            '
            Me.PnlBotonesGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlBotonesGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotonesGrabar.Location = New System.Drawing.Point(770, 0)
            Me.PnlBotonesGrabar.Name = "PnlBotonesGrabar"
            Me.PnlBotonesGrabar.Size = New System.Drawing.Size(95, 41)
            Me.PnlBotonesGrabar.TabIndex = 1
            '
            'btnAceptar
            '
            Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(0, 0)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(95, 41)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(865, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(100, 41)
            Me.PnlBotones.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(0, 0)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(100, 41)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlCabecera
            '
            Me.pnlCabecera.BackColor = System.Drawing.Color.Transparent
            Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlCabecera.Controls.Add(Me.lblCodInterno)
            Me.pnlCabecera.Controls.Add(Me.Label5)
            Me.pnlCabecera.Controls.Add(Me.lblInterno)
            Me.pnlCabecera.Controls.Add(Me.Label4)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(965, 22)
            Me.pnlCabecera.TabIndex = 0
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(868, 3)
            Me.lblCodInterno.Name = "lblCodInterno"
            Me.lblCodInterno.Size = New System.Drawing.Size(82, 13)
            Me.lblCodInterno.TabIndex = 3
            Me.lblCodInterno.Text = "lblCodInterno"
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(810, 3)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(50, 13)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Código:"
            '
            'lblInterno
            '
            Me.lblInterno.AutoSize = True
            Me.lblInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInterno.Location = New System.Drawing.Point(68, 3)
            Me.lblInterno.Name = "lblInterno"
            Me.lblInterno.Size = New System.Drawing.Size(60, 13)
            Me.lblInterno.TabIndex = 1
            Me.lblInterno.Text = "lblInterno"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(7, 3)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(66, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Interno(a):"
            '
            'txtObsLib
            '
            Me.txtObsLib._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObsLib._BloquearPaste = False
            Me.txtObsLib._SeleccionarTodo = False
            Me.txtObsLib.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtObsLib.BackColor = System.Drawing.SystemColors.Window
            Me.txtObsLib.Location = New System.Drawing.Point(110, 142)
            Me.txtObsLib.MaxLength = 500
            Me.txtObsLib.Multiline = True
            Me.txtObsLib.Name = "txtObsLib"
            Me.txtObsLib.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObsLib.Size = New System.Drawing.Size(533, 312)
            Me.txtObsLib.TabIndex = 9
            Me.txtObsLib.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObsLib.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlTitulo
            '
            Me.pnlTitulo.Controls.Add(Me.Label1)
            Me.pnlTitulo.Controls.Add(Me.lblTitulo)
            Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitulo.Location = New System.Drawing.Point(0, 22)
            Me.pnlTitulo.Name = "pnlTitulo"
            Me.pnlTitulo.Size = New System.Drawing.Size(965, 23)
            Me.pnlTitulo.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(0, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(965, 3)
            Me.Label1.TabIndex = 1
            '
            'lblTitulo
            '
            Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(965, 18)
            Me.lblTitulo.TabIndex = 0
            Me.lblTitulo.Text = "ORDEN DE TRASLADO A HOSPITAL DE SALUD MENTAL"
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.tbp01)
            Me.TabControl1.Controls.Add(Me.tbp02)
            Me.TabControl1.Controls.Add(Me.tbp03)
            Me.TabControl1.Location = New System.Drawing.Point(12, 256)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(950, 290)
            Me.TabControl1.TabIndex = 6
            '
            'tbp01
            '
            Me.tbp01.Controls.Add(Me.UscExpeDeResolucion)
            Me.tbp01.Location = New System.Drawing.Point(4, 22)
            Me.tbp01.Name = "tbp01"
            Me.tbp01.Padding = New System.Windows.Forms.Padding(3)
            Me.tbp01.Size = New System.Drawing.Size(942, 264)
            Me.tbp01.TabIndex = 0
            Me.tbp01.Text = "Expediente"
            Me.tbp01.UseVisualStyleBackColor = True
            '
            'UscExpeDeResolucion
            '
            Me.UscExpeDeResolucion._CadenaPerpetua = False
            Me.UscExpeDeResolucion._DocumentoJudicialExpedienteID = -1
            Me.UscExpeDeResolucion._DocumentoJudicialID = -1
            Me.UscExpeDeResolucion._Documentos_sin_mov = False
            Me.UscExpeDeResolucion._FechaMovimiento = CType(0, Long)
            Me.UscExpeDeResolucion._FormEliminar = False
            Me.UscExpeDeResolucion._FormEscritura = False
            Me.UscExpeDeResolucion._InternoID = -1
            Me.UscExpeDeResolucion._InternoIngresoID = -1
            Me.UscExpeDeResolucion._InternoIngresoInpeId = -1
            Me.UscExpeDeResolucion._PenalID = -1
            Me.UscExpeDeResolucion._PermisoEliminar = False
            Me.UscExpeDeResolucion._RegionID = -1
            Me.UscExpeDeResolucion._SubTipo = -1
            Me.UscExpeDeResolucion._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscExpeDeResolucion._TipoResolucion = -1
            Me.UscExpeDeResolucion._TotalAnhos = "0"
            Me.UscExpeDeResolucion._TotalDias = "0"
            Me.UscExpeDeResolucion._TotalMes = "0"
            Me.UscExpeDeResolucion._VariableMov = 0
            Me.UscExpeDeResolucion._VisibleControlExpediente = False
            Me.UscExpeDeResolucion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UscExpeDeResolucion.chk_Queda = False
            Me.UscExpeDeResolucion.Estado_Documento_Judicial_exp = -1
            Me.UscExpeDeResolucion.Location = New System.Drawing.Point(10, 6)
            Me.UscExpeDeResolucion.Name = "UscExpeDeResolucion"
            Me.UscExpeDeResolucion.Size = New System.Drawing.Size(936, 255)
            Me.UscExpeDeResolucion.TabIndex = 3
            '
            'tbp02
            '
            Me.tbp02.Controls.Add(Me.UscQueda1)
            Me.tbp02.Location = New System.Drawing.Point(4, 22)
            Me.tbp02.Name = "tbp02"
            Me.tbp02.Padding = New System.Windows.Forms.Padding(3)
            Me.tbp02.Size = New System.Drawing.Size(942, 264)
            Me.tbp02.TabIndex = 1
            Me.tbp02.Text = "Expediente Pendiente"
            Me.tbp02.UseVisualStyleBackColor = True
            '
            'UscQueda1
            '
            Me.UscQueda1._Cantidad_queda = 0
            Me.UscQueda1._Codigo = -1
            Me.UscQueda1._DocumentoJudicialExpedienteID = -1
            Me.UscQueda1._DocumentoJudicialID = -1
            Me.UscQueda1._Documentos_sin_mov = False
            Me.UscQueda1._DocumentoTipo = -1
            Me.UscQueda1._fechaejecucionMov = Nothing
            Me.UscQueda1._FechaMovimiento = CType(0, Long)
            Me.UscQueda1._FechaRecep = CType(0, Long)
            Me.UscQueda1._GrillaSeleccionMultiple = True
            Me.UscQueda1._IngresoID = -1
            Me.UscQueda1._InternoID = -1
            Me.UscQueda1._InternoIngresoInpeId = -1
            Me.UscQueda1._NuevoExpediente = False
            Me.UscQueda1._PenalID = -1
            Me.UscQueda1._RegionID = -1
            Me.UscQueda1._SituacionJuridicaExpe = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
            Me.UscQueda1._SubTipo = -1
            Me.UscQueda1._TemporalNuevo = False
            Me.UscQueda1._TipoAutJudicial = -1
            Me.UscQueda1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscQueda1._TipoResolucion = -1
            Me.UscQueda1._VisibleControlExpediente = False
            Me.UscQueda1._VisibleGrabar = False
            Me.UscQueda1.DocJudicialID = -1
            Me.UscQueda1.Location = New System.Drawing.Point(-1, 5)
            Me.UscQueda1.Name = "UscQueda1"
            Me.UscQueda1.SalaJuzgado = -1
            Me.UscQueda1.Size = New System.Drawing.Size(937, 295)
            Me.UscQueda1.TabIndex = 3
            Me.UscQueda1.TipoAutoridadJudicial = -1
            '
            'tbp03
            '
            Me.tbp03.Controls.Add(Me.dgwGrilla)
            Me.tbp03.Location = New System.Drawing.Point(4, 22)
            Me.tbp03.Name = "tbp03"
            Me.tbp03.Padding = New System.Windows.Forms.Padding(3)
            Me.tbp03.Size = New System.Drawing.Size(942, 264)
            Me.tbp03.TabIndex = 2
            Me.tbp03.Text = "Movimientos"
            Me.tbp03.UseVisualStyleBackColor = True
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pen_nom, Me.col_mov_fec, Me.col_mov_grp_nom, Me.col_mov_tip_nom, Me.col_mov_mot_nom, Me.col_num_doc, Me.col_mov_fec_doc, Me.col_mov_fec_rec, Me.col_est_nom, Me.col_Justificación})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(3, 3)
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
            Me.dgwGrilla.Size = New System.Drawing.Size(936, 277)
            Me.dgwGrilla.TabIndex = 1
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "NombrePenal"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            Me.col_pen_nom.Visible = False
            '
            'col_mov_fec
            '
            Me.col_mov_fec.DataPropertyName = "Fecha"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.col_mov_fec.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_mov_fec.HeaderText = "Fecha Movimiento"
            Me.col_mov_fec.Name = "col_mov_fec"
            Me.col_mov_fec.ReadOnly = True
            Me.col_mov_fec.ToolTipText = "Fecha del Movimiento"
            Me.col_mov_fec.Width = 120
            '
            'col_mov_grp_nom
            '
            Me.col_mov_grp_nom.DataPropertyName = "MovimientoGrupoNombre"
            Me.col_mov_grp_nom.HeaderText = "Tipo"
            Me.col_mov_grp_nom.Name = "col_mov_grp_nom"
            Me.col_mov_grp_nom.ReadOnly = True
            Me.col_mov_grp_nom.ToolTipText = "Grupo Movimiento"
            Me.col_mov_grp_nom.Width = 30
            '
            'col_mov_tip_nom
            '
            Me.col_mov_tip_nom.DataPropertyName = "MovimientoTipoNombre"
            Me.col_mov_tip_nom.HeaderText = "Movimiento"
            Me.col_mov_tip_nom.Name = "col_mov_tip_nom"
            Me.col_mov_tip_nom.ReadOnly = True
            Me.col_mov_tip_nom.ToolTipText = "Tipo de Movimiento"
            Me.col_mov_tip_nom.Width = 170
            '
            'col_mov_mot_nom
            '
            Me.col_mov_mot_nom.DataPropertyName = "MovimientoMotivoNombre"
            Me.col_mov_mot_nom.HeaderText = "Motivo "
            Me.col_mov_mot_nom.Name = "col_mov_mot_nom"
            Me.col_mov_mot_nom.ReadOnly = True
            Me.col_mov_mot_nom.ToolTipText = "Motivo del Movimiento"
            Me.col_mov_mot_nom.Width = 170
            '
            'col_num_doc
            '
            Me.col_num_doc.DataPropertyName = "DocumJudicialNum"
            Me.col_num_doc.HeaderText = "Nº de Documento"
            Me.col_num_doc.Name = "col_num_doc"
            Me.col_num_doc.ReadOnly = True
            Me.col_num_doc.ToolTipText = "Número de Documento"
            Me.col_num_doc.Width = 140
            '
            'col_mov_fec_doc
            '
            Me.col_mov_fec_doc.DataPropertyName = "DocumJudicialFecha"
            Me.col_mov_fec_doc.HeaderText = "Fecha Documento"
            Me.col_mov_fec_doc.Name = "col_mov_fec_doc"
            Me.col_mov_fec_doc.ReadOnly = True
            Me.col_mov_fec_doc.ToolTipText = "Fecha de Documento"
            Me.col_mov_fec_doc.Width = 75
            '
            'col_mov_fec_rec
            '
            Me.col_mov_fec_rec.DataPropertyName = "DocumJudicialFecharecepcion"
            Me.col_mov_fec_rec.HeaderText = "Fecha Recepción"
            Me.col_mov_fec_rec.Name = "col_mov_fec_rec"
            Me.col_mov_fec_rec.ReadOnly = True
            Me.col_mov_fec_rec.ToolTipText = "Fecha de Recepción"
            Me.col_mov_fec_rec.Width = 75
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "EstadoNombre"
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            Me.col_est_nom.ToolTipText = "Estado de Movimiento"
            Me.col_est_nom.Width = 90
            '
            'col_Justificación
            '
            Me.col_Justificación.DataPropertyName = "TipoJustificacion"
            Me.col_Justificación.HeaderText = "Justificación"
            Me.col_Justificación.Name = "col_Justificación"
            Me.col_Justificación.ReadOnly = True
            Me.col_Justificación.ToolTipText = "Justuficación"
            Me.col_Justificación.Width = 150
            '
            'UscResolAclaratoriaExpe1
            '
            Me.UscResolAclaratoriaExpe1._blnNuevo = False
            Me.UscResolAclaratoriaExpe1._CodDocJud = -1
            Me.UscResolAclaratoriaExpe1._Codigo = -1
            Me.UscResolAclaratoriaExpe1._DocSubTipoID = -1
            Me.UscResolAclaratoriaExpe1._DocumentoTipo = -1
            Me.UscResolAclaratoriaExpe1._fechaejecucionMov = ""
            Me.UscResolAclaratoriaExpe1._InternoID = -1
            Me.UscResolAclaratoriaExpe1._InternoIngresoId = -1
            Me.UscResolAclaratoriaExpe1._InternoIngresoInpeId = -1
            Me.UscResolAclaratoriaExpe1._PenalID = -1
            Me.UscResolAclaratoriaExpe1._PermisoEliminar = False
            Me.UscResolAclaratoriaExpe1._Proceso_Pendiente_queda = -1
            Me.UscResolAclaratoriaExpe1._RegionID = -1
            Me.UscResolAclaratoriaExpe1._TipoAclaratoria = -1
            Me.UscResolAclaratoriaExpe1._TipoAclaratoriaCon = False
            Me.UscResolAclaratoriaExpe1._TipoAclaratoriaSeleccionado = -1
            Me.UscResolAclaratoriaExpe1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscResolAclaratoriaExpe1.ApellidoMaternoNA = ""
            Me.UscResolAclaratoriaExpe1.ApellidoPaternoNA = ""
            Me.UscResolAclaratoriaExpe1.AutoridadJuzgadonombre = ""
            Me.UscResolAclaratoriaExpe1.DistritoJudicial = 0
            Me.UscResolAclaratoriaExpe1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscResolAclaratoriaExpe1.Estado_Documento_Judicial = -1
            Me.UscResolAclaratoriaExpe1.FechaInscripcion = CType(0, Long)
            Me.UscResolAclaratoriaExpe1.FechaMovimiento = CType(0, Long)
            Me.UscResolAclaratoriaExpe1.idEstadoTraslado = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.EnDesarrollo
            Me.UscResolAclaratoriaExpe1.JuezNombre = ""
            Me.UscResolAclaratoriaExpe1.Location = New System.Drawing.Point(0, 45)
            Me.UscResolAclaratoriaExpe1.MovimientoMotivoId = -1
            Me.UscResolAclaratoriaExpe1.Name = "UscResolAclaratoriaExpe1"
            Me.UscResolAclaratoriaExpe1.NombresNA = ""
            Me.UscResolAclaratoriaExpe1.observacionEstEjecucion = Nothing
            Me.UscResolAclaratoriaExpe1.SalaJuzgado = 0
            Me.UscResolAclaratoriaExpe1.SalaJuzgadonombre = ""
            Me.UscResolAclaratoriaExpe1.SecretarioNombre = ""
            Me.UscResolAclaratoriaExpe1.Size = New System.Drawing.Size(965, 205)
            Me.UscResolAclaratoriaExpe1.TabIndex = 2
            Me.UscResolAclaratoriaExpe1.ValorEli = False
            Me.UscResolAclaratoriaExpe1.ValorRef = False
            Me.UscResolAclaratoriaExpe1.ValorVal = False
            '
            'frmOrdenTrasladoHospital
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(965, 605)
            Me.Name = "frmOrdenTrasladoHospital"
            Me.Text = "Orden de Traslado"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotonesGrabar.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.pnlTitulo.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tbp01.ResumeLayout(False)
            Me.tbp02.ResumeLayout(False)
            Me.tbp03.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents lblCodInterno As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblInterno As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtObsLib As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PnlBotonesGrabar As System.Windows.Forms.Panel
        Friend WithEvents UscResolAclaratoriaExpe1 As APPControls.Registro.Resoluciones.uscResolAclaratoriaExpe
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents tbp01 As TabPage
        Friend WithEvents UscExpeDeResolucion As APPControls.Registro.Documento.uscExpeDeResolucion
        Friend WithEvents tbp02 As TabPage
        Friend WithEvents UscQueda1 As APPControls.uscQueda
        Friend WithEvents tbp03 As TabPage
        Friend WithEvents dgwGrilla As DataGridView
        Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_mov_fec As DataGridViewTextBoxColumn
        Friend WithEvents col_mov_grp_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_mov_tip_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_mov_mot_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_mov_fec_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_mov_fec_rec As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_Justificación As DataGridViewTextBoxColumn
    End Class

End Namespace