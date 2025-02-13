Namespace Registro.Reniec
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscValidacionDatosInternoV2
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgwGrillaNombresAsociados = New Legolas.APPUIComponents.myDatagridView()
            Me.col_nom_asoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.grpDatosInterno = New System.Windows.Forms.GroupBox()
            Me.lblHistorial = New System.Windows.Forms.Label()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.lblMedida = New System.Windows.Forms.Label()
            Me.txtEstadoCivil = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtConyuge = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMadre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtPadre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label42 = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.txtEstatura = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label43 = New System.Windows.Forms.Label()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.txtGradoInstruccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label38 = New System.Windows.Forms.Label()
            Me.txtfechanac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSexo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox12 = New System.Windows.Forms.GroupBox()
            Me.txtUbigeoDomicilio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDireccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox14 = New System.Windows.Forms.GroupBox()
            Me.txtNacimientoUbigeo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label46 = New System.Windows.Forms.Label()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtApePaterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.txtNombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label51 = New System.Windows.Forms.Label()
            Me.txtApeMaterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblNombreDocumento = New System.Windows.Forms.Label()
            Me.Label53 = New System.Windows.Forms.Label()
            Me.txtNumeroDni = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlFotoVis = New System.Windows.Forms.Panel()
            Me.picFoto = New System.Windows.Forms.PictureBox()
            Me.grpNombreAsociados = New System.Windows.Forms.GroupBox()
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.DescargarFotografiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblError = New System.Windows.Forms.Label()
            CType(Me.dgwGrillaNombresAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpDatosInterno.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.GroupBox12.SuspendLayout()
            Me.GroupBox14.SuspendLayout()
            Me.pnlFotoVis.SuspendLayout()
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpNombreAsociados.SuspendLayout()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrillaNombresAsociados
            '
            Me.dgwGrillaNombresAsociados.AllowUserToAddRows = False
            Me.dgwGrillaNombresAsociados.AllowUserToDeleteRows = False
            Me.dgwGrillaNombresAsociados.AllowUserToResizeRows = False
            Me.dgwGrillaNombresAsociados.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaNombresAsociados.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaNombresAsociados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwGrillaNombresAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaNombresAsociados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nom_asoc})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaNombresAsociados.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgwGrillaNombresAsociados.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaNombresAsociados.Location = New System.Drawing.Point(3, 10)
            Me.dgwGrillaNombresAsociados.MultiSelect = False
            Me.dgwGrillaNombresAsociados.Name = "dgwGrillaNombresAsociados"
            Me.dgwGrillaNombresAsociados.ReadOnly = True
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaNombresAsociados.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwGrillaNombresAsociados.RowHeadersVisible = False
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaNombresAsociados.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgwGrillaNombresAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaNombresAsociados.Size = New System.Drawing.Size(457, 42)
            Me.dgwGrillaNombresAsociados.TabIndex = 0
            Me.dgwGrillaNombresAsociados.VisibleCampos = False
            '
            'col_nom_asoc
            '
            Me.col_nom_asoc.HeaderText = "Nombres Asociados "
            Me.col_nom_asoc.Name = "col_nom_asoc"
            Me.col_nom_asoc.ReadOnly = True
            Me.col_nom_asoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_nom_asoc.Width = 450
            '
            'grpDatosInterno
            '
            Me.grpDatosInterno.Controls.Add(Me.lblHistorial)
            Me.grpDatosInterno.Controls.Add(Me.GroupBox9)
            Me.grpDatosInterno.Location = New System.Drawing.Point(1, -1)
            Me.grpDatosInterno.Name = "grpDatosInterno"
            Me.grpDatosInterno.Size = New System.Drawing.Size(463, 350)
            Me.grpDatosInterno.TabIndex = 0
            Me.grpDatosInterno.TabStop = False
            Me.grpDatosInterno.Text = "                                                       DATOS DEL INTERNO"
            '
            'lblHistorial
            '
            Me.lblHistorial.AutoSize = True
            Me.lblHistorial.BackColor = System.Drawing.Color.Transparent
            Me.lblHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHistorial.Location = New System.Drawing.Point(399, 5)
            Me.lblHistorial.Name = "lblHistorial"
            Me.lblHistorial.Size = New System.Drawing.Size(61, 13)
            Me.lblHistorial.TabIndex = 1
            Me.lblHistorial.Text = "Historial :"
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.lblError)
            Me.GroupBox9.Controls.Add(Me.lblMedida)
            Me.GroupBox9.Controls.Add(Me.txtEstadoCivil)
            Me.GroupBox9.Controls.Add(Me.txtConyuge)
            Me.GroupBox9.Controls.Add(Me.txtMadre)
            Me.GroupBox9.Controls.Add(Me.txtPadre)
            Me.GroupBox9.Controls.Add(Me.Label42)
            Me.GroupBox9.Controls.Add(Me.Label37)
            Me.GroupBox9.Controls.Add(Me.txtEstatura)
            Me.GroupBox9.Controls.Add(Me.Label43)
            Me.GroupBox9.Controls.Add(Me.Label44)
            Me.GroupBox9.Controls.Add(Me.txtGradoInstruccion)
            Me.GroupBox9.Controls.Add(Me.Label38)
            Me.GroupBox9.Controls.Add(Me.txtfechanac)
            Me.GroupBox9.Controls.Add(Me.txtSexo)
            Me.GroupBox9.Controls.Add(Me.GroupBox12)
            Me.GroupBox9.Controls.Add(Me.GroupBox14)
            Me.GroupBox9.Controls.Add(Me.Label47)
            Me.GroupBox9.Controls.Add(Me.txtApePaterno)
            Me.GroupBox9.Controls.Add(Me.Label48)
            Me.GroupBox9.Controls.Add(Me.Label49)
            Me.GroupBox9.Controls.Add(Me.Label50)
            Me.GroupBox9.Controls.Add(Me.txtNombres)
            Me.GroupBox9.Controls.Add(Me.Label51)
            Me.GroupBox9.Controls.Add(Me.txtApeMaterno)
            Me.GroupBox9.Controls.Add(Me.lblNombreDocumento)
            Me.GroupBox9.Controls.Add(Me.Label53)
            Me.GroupBox9.Controls.Add(Me.txtNumeroDni)
            Me.GroupBox9.Controls.Add(Me.pnlFotoVis)
            Me.GroupBox9.Location = New System.Drawing.Point(3, 11)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(456, 336)
            Me.GroupBox9.TabIndex = 0
            Me.GroupBox9.TabStop = False
            '
            'lblMedida
            '
            Me.lblMedida.AutoSize = True
            Me.lblMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMedida.Location = New System.Drawing.Point(281, 316)
            Me.lblMedida.Name = "lblMedida"
            Me.lblMedida.Size = New System.Drawing.Size(18, 12)
            Me.lblMedida.TabIndex = 24
            Me.lblMedida.Text = "cm"
            '
            'txtEstadoCivil
            '
            Me.txtEstadoCivil._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstadoCivil._BloquearPaste = True
            Me.txtEstadoCivil._SeleccionarTodo = False
            Me.txtEstadoCivil.Location = New System.Drawing.Point(89, 239)
            Me.txtEstadoCivil.Name = "txtEstadoCivil"
            Me.txtEstadoCivil.ReadOnly = True
            Me.txtEstadoCivil.Size = New System.Drawing.Size(150, 20)
            Me.txtEstadoCivil.TabIndex = 15
            Me.txtEstadoCivil.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstadoCivil.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtConyuge
            '
            Me.txtConyuge._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtConyuge._BloquearPaste = True
            Me.txtConyuge._SeleccionarTodo = False
            Me.txtConyuge.Location = New System.Drawing.Point(360, 311)
            Me.txtConyuge.Name = "txtConyuge"
            Me.txtConyuge.ReadOnly = True
            Me.txtConyuge.Size = New System.Drawing.Size(91, 20)
            Me.txtConyuge.TabIndex = 26
            Me.txtConyuge.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtConyuge.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtMadre
            '
            Me.txtMadre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMadre._BloquearPaste = True
            Me.txtMadre._SeleccionarTodo = False
            Me.txtMadre.Location = New System.Drawing.Point(89, 288)
            Me.txtMadre.Name = "txtMadre"
            Me.txtMadre.ReadOnly = True
            Me.txtMadre.Size = New System.Drawing.Size(150, 20)
            Me.txtMadre.TabIndex = 19
            Me.txtMadre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtMadre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtPadre
            '
            Me.txtPadre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPadre._BloquearPaste = True
            Me.txtPadre._SeleccionarTodo = False
            Me.txtPadre.Location = New System.Drawing.Point(89, 264)
            Me.txtPadre.Name = "txtPadre"
            Me.txtPadre.ReadOnly = True
            Me.txtPadre.Size = New System.Drawing.Size(150, 20)
            Me.txtPadre.TabIndex = 17
            Me.txtPadre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtPadre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label42
            '
            Me.Label42.AutoSize = True
            Me.Label42.Location = New System.Drawing.Point(303, 315)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New System.Drawing.Size(55, 13)
            Me.Label42.TabIndex = 25
            Me.Label42.Text = "Conyuge :"
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.Location = New System.Drawing.Point(219, 315)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(33, 13)
            Me.Label37.TabIndex = 22
            Me.Label37.Text = "Talla:"
            '
            'txtEstatura
            '
            Me.txtEstatura._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstatura._BloquearPaste = False
            Me.txtEstatura._SeleccionarTodo = False
            Me.txtEstatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEstatura.Location = New System.Drawing.Point(252, 313)
            Me.txtEstatura.Name = "txtEstatura"
            Me.txtEstatura.ReadOnly = True
            Me.txtEstatura.Size = New System.Drawing.Size(28, 20)
            Me.txtEstatura.TabIndex = 23
            Me.txtEstatura.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstatura.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label43
            '
            Me.Label43.AutoSize = True
            Me.Label43.Location = New System.Drawing.Point(2, 269)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(41, 13)
            Me.Label43.TabIndex = 16
            Me.Label43.Text = "Padre :"
            '
            'Label44
            '
            Me.Label44.AutoSize = True
            Me.Label44.Location = New System.Drawing.Point(2, 293)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(43, 13)
            Me.Label44.TabIndex = 18
            Me.Label44.Text = "Madre :"
            '
            'txtGradoInstruccion
            '
            Me.txtGradoInstruccion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtGradoInstruccion._BloquearPaste = False
            Me.txtGradoInstruccion._SeleccionarTodo = False
            Me.txtGradoInstruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGradoInstruccion.Location = New System.Drawing.Point(89, 313)
            Me.txtGradoInstruccion.Name = "txtGradoInstruccion"
            Me.txtGradoInstruccion.ReadOnly = True
            Me.txtGradoInstruccion.Size = New System.Drawing.Size(130, 18)
            Me.txtGradoInstruccion.TabIndex = 21
            Me.txtGradoInstruccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtGradoInstruccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Location = New System.Drawing.Point(2, 315)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(65, 13)
            Me.Label38.TabIndex = 20
            Me.Label38.Text = "Grado Inst. :"
            '
            'txtfechanac
            '
            Me.txtfechanac._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtfechanac._BloquearPaste = True
            Me.txtfechanac._SeleccionarTodo = False
            Me.txtfechanac.Location = New System.Drawing.Point(89, 113)
            Me.txtfechanac.Name = "txtfechanac"
            Me.txtfechanac.ReadOnly = True
            Me.txtfechanac.Size = New System.Drawing.Size(65, 20)
            Me.txtfechanac.TabIndex = 9
            Me.txtfechanac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtfechanac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtSexo
            '
            Me.txtSexo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSexo._BloquearPaste = True
            Me.txtSexo._SeleccionarTodo = False
            Me.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSexo.Location = New System.Drawing.Point(196, 113)
            Me.txtSexo.Name = "txtSexo"
            Me.txtSexo.ReadOnly = True
            Me.txtSexo.Size = New System.Drawing.Size(43, 20)
            Me.txtSexo.TabIndex = 11
            Me.txtSexo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSexo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'GroupBox12
            '
            Me.GroupBox12.Controls.Add(Me.txtUbigeoDomicilio)
            Me.GroupBox12.Controls.Add(Me.txtDireccion)
            Me.GroupBox12.Location = New System.Drawing.Point(2, 175)
            Me.GroupBox12.Name = "GroupBox12"
            Me.GroupBox12.Size = New System.Drawing.Size(240, 62)
            Me.GroupBox12.TabIndex = 13
            Me.GroupBox12.TabStop = False
            Me.GroupBox12.Text = "Ubigeo  Departamento / Provincia / Distrito :"
            '
            'txtUbigeoDomicilio
            '
            Me.txtUbigeoDomicilio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtUbigeoDomicilio._BloquearPaste = False
            Me.txtUbigeoDomicilio._SeleccionarTodo = False
            Me.txtUbigeoDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbigeoDomicilio.Location = New System.Drawing.Point(8, 16)
            Me.txtUbigeoDomicilio.Name = "txtUbigeoDomicilio"
            Me.txtUbigeoDomicilio.ReadOnly = True
            Me.txtUbigeoDomicilio.Size = New System.Drawing.Size(229, 18)
            Me.txtUbigeoDomicilio.TabIndex = 0
            Me.txtUbigeoDomicilio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtUbigeoDomicilio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtDireccion
            '
            Me.txtDireccion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDireccion._BloquearPaste = False
            Me.txtDireccion._SeleccionarTodo = False
            Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(8, 39)
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.ReadOnly = True
            Me.txtDireccion.Size = New System.Drawing.Size(229, 18)
            Me.txtDireccion.TabIndex = 1
            Me.txtDireccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDireccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'GroupBox14
            '
            Me.GroupBox14.Controls.Add(Me.txtNacimientoUbigeo)
            Me.GroupBox14.Controls.Add(Me.Label46)
            Me.GroupBox14.Location = New System.Drawing.Point(4, 135)
            Me.GroupBox14.Name = "GroupBox14"
            Me.GroupBox14.Size = New System.Drawing.Size(238, 40)
            Me.GroupBox14.TabIndex = 12
            Me.GroupBox14.TabStop = False
            Me.GroupBox14.Text = "Lugar de Nacimiento :"
            '
            'txtNacimientoUbigeo
            '
            Me.txtNacimientoUbigeo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNacimientoUbigeo._BloquearPaste = False
            Me.txtNacimientoUbigeo._SeleccionarTodo = False
            Me.txtNacimientoUbigeo.Location = New System.Drawing.Point(6, 15)
            Me.txtNacimientoUbigeo.Name = "txtNacimientoUbigeo"
            Me.txtNacimientoUbigeo.ReadOnly = True
            Me.txtNacimientoUbigeo.Size = New System.Drawing.Size(229, 20)
            Me.txtNacimientoUbigeo.TabIndex = 0
            Me.txtNacimientoUbigeo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNacimientoUbigeo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label46
            '
            Me.Label46.AutoSize = True
            Me.Label46.Location = New System.Drawing.Point(15, 17)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New System.Drawing.Size(0, 13)
            Me.Label46.TabIndex = 1
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.ForeColor = System.Drawing.Color.Black
            Me.Label47.Location = New System.Drawing.Point(2, 44)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(82, 13)
            Me.Label47.TabIndex = 2
            Me.Label47.Text = "Primer Apellido :"
            '
            'txtApePaterno
            '
            Me.txtApePaterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePaterno._BloquearPaste = True
            Me.txtApePaterno._SeleccionarTodo = False
            Me.txtApePaterno.Location = New System.Drawing.Point(89, 41)
            Me.txtApePaterno.Name = "txtApePaterno"
            Me.txtApePaterno.ReadOnly = True
            Me.txtApePaterno.Size = New System.Drawing.Size(150, 20)
            Me.txtApePaterno.TabIndex = 3
            Me.txtApePaterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePaterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Location = New System.Drawing.Point(2, 68)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(90, 13)
            Me.Label48.TabIndex = 4
            Me.Label48.Text = "Segundo Apellido"
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Location = New System.Drawing.Point(2, 93)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(74, 13)
            Me.Label49.TabIndex = 6
            Me.Label49.Text = "Pre Nombres :"
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Location = New System.Drawing.Point(157, 116)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(37, 13)
            Me.Label50.TabIndex = 10
            Me.Label50.Text = "Sexo :"
            '
            'txtNombres
            '
            Me.txtNombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombres._BloquearPaste = True
            Me.txtNombres._SeleccionarTodo = False
            Me.txtNombres.Location = New System.Drawing.Point(89, 90)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.ReadOnly = True
            Me.txtNombres.Size = New System.Drawing.Size(150, 20)
            Me.txtNombres.TabIndex = 7
            Me.txtNombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Location = New System.Drawing.Point(2, 115)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(69, 13)
            Me.Label51.TabIndex = 8
            Me.Label51.Text = "Fecha Nac. :"
            '
            'txtApeMaterno
            '
            Me.txtApeMaterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMaterno._BloquearPaste = True
            Me.txtApeMaterno._SeleccionarTodo = False
            Me.txtApeMaterno.Location = New System.Drawing.Point(89, 65)
            Me.txtApeMaterno.Name = "txtApeMaterno"
            Me.txtApeMaterno.ReadOnly = True
            Me.txtApeMaterno.Size = New System.Drawing.Size(150, 20)
            Me.txtApeMaterno.TabIndex = 5
            Me.txtApeMaterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMaterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'lblNombreDocumento
            '
            Me.lblNombreDocumento.AutoSize = True
            Me.lblNombreDocumento.Location = New System.Drawing.Point(2, 20)
            Me.lblNombreDocumento.Name = "lblNombreDocumento"
            Me.lblNombreDocumento.Size = New System.Drawing.Size(47, 13)
            Me.lblNombreDocumento.TabIndex = 0
            Me.lblNombreDocumento.Text = "Nº DNI :"
            '
            'Label53
            '
            Me.Label53.AutoSize = True
            Me.Label53.Location = New System.Drawing.Point(2, 245)
            Me.Label53.Name = "Label53"
            Me.Label53.Size = New System.Drawing.Size(67, 13)
            Me.Label53.TabIndex = 14
            Me.Label53.Text = "Estado civil :"
            '
            'txtNumeroDni
            '
            Me.txtNumeroDni._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumeroDni._BloquearPaste = False
            Me.txtNumeroDni._SeleccionarTodo = False
            Me.txtNumeroDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroDni.Location = New System.Drawing.Point(89, 16)
            Me.txtNumeroDni.Name = "txtNumeroDni"
            Me.txtNumeroDni.ReadOnly = True
            Me.txtNumeroDni.Size = New System.Drawing.Size(115, 21)
            Me.txtNumeroDni.TabIndex = 1
            Me.txtNumeroDni.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumeroDni.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'pnlFotoVis
            '
            Me.pnlFotoVis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlFotoVis.Controls.Add(Me.picFoto)
            Me.pnlFotoVis.Location = New System.Drawing.Point(242, 41)
            Me.pnlFotoVis.Name = "pnlFotoVis"
            Me.pnlFotoVis.Size = New System.Drawing.Size(210, 269)
            Me.pnlFotoVis.TabIndex = 27
            '
            'picFoto
            '
            Me.picFoto.BackColor = System.Drawing.Color.White
            Me.picFoto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.picFoto.Image = Global.APPControls.My.Resources.Resources.sin_foto
            Me.picFoto.Location = New System.Drawing.Point(0, 0)
            Me.picFoto.Name = "picFoto"
            Me.picFoto.Size = New System.Drawing.Size(206, 265)
            Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picFoto.TabIndex = 20
            Me.picFoto.TabStop = False
            '
            'grpNombreAsociados
            '
            Me.grpNombreAsociados.Controls.Add(Me.dgwGrillaNombresAsociados)
            Me.grpNombreAsociados.Location = New System.Drawing.Point(1, 345)
            Me.grpNombreAsociados.Name = "grpNombreAsociados"
            Me.grpNombreAsociados.Size = New System.Drawing.Size(463, 50)
            Me.grpNombreAsociados.TabIndex = 1
            Me.grpNombreAsociados.TabStop = False
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DescargarFotografiaToolStripMenuItem})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(184, 26)
            '
            'DescargarFotografiaToolStripMenuItem
            '
            Me.DescargarFotografiaToolStripMenuItem.Name = "DescargarFotografiaToolStripMenuItem"
            Me.DescargarFotografiaToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
            Me.DescargarFotografiaToolStripMenuItem.Text = "Descargar Fotografia"
            '
            'lblError
            '
            Me.lblError.AutoSize = True
            Me.lblError.Location = New System.Drawing.Point(241, 27)
            Me.lblError.Name = "lblError"
            Me.lblError.Size = New System.Drawing.Size(10, 13)
            Me.lblError.TabIndex = 21
            Me.lblError.Text = "."
            '
            'uscValidacionDatosInternoV2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.Controls.Add(Me.grpDatosInterno)
            Me.Controls.Add(Me.grpNombreAsociados)
            Me.Name = "uscValidacionDatosInternoV2"
            Me.Size = New System.Drawing.Size(464, 398)
            CType(Me.dgwGrillaNombresAsociados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpDatosInterno.ResumeLayout(False)
            Me.grpDatosInterno.PerformLayout()
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.GroupBox12.ResumeLayout(False)
            Me.GroupBox12.PerformLayout()
            Me.GroupBox14.ResumeLayout(False)
            Me.GroupBox14.PerformLayout()
            Me.pnlFotoVis.ResumeLayout(False)
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpNombreAsociados.ResumeLayout(False)
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrillaNombresAsociados As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents grpDatosInterno As System.Windows.Forms.GroupBox
        Friend WithEvents txtEstadoCivil As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents txtEstatura As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtGradoInstruccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents Label42 As System.Windows.Forms.Label
        Friend WithEvents Label43 As System.Windows.Forms.Label
        Friend WithEvents Label44 As System.Windows.Forms.Label
        Friend WithEvents txtSexo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
        Friend WithEvents txtUbigeoDomicilio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDireccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNacimientoUbigeo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label46 As System.Windows.Forms.Label
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents txtApePaterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents Label49 As System.Windows.Forms.Label
        Friend WithEvents Label50 As System.Windows.Forms.Label
        Friend WithEvents txtNombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label51 As System.Windows.Forms.Label
        Friend WithEvents txtApeMaterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblNombreDocumento As System.Windows.Forms.Label
        Friend WithEvents Label53 As System.Windows.Forms.Label
        Friend WithEvents txtNumeroDni As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtfechanac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlFotoVis As System.Windows.Forms.Panel
        Friend WithEvents picFoto As System.Windows.Forms.PictureBox
        Friend WithEvents txtConyuge As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblMedida As System.Windows.Forms.Label
        Friend WithEvents lblHistorial As System.Windows.Forms.Label
        Friend WithEvents grpNombreAsociados As System.Windows.Forms.GroupBox
        Friend WithEvents col_nom_asoc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
        Friend WithEvents DescargarFotografiaToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents lblError As Label
    End Class
End Namespace
