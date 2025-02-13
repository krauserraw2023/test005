Namespace Registro.Reniec
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscValidacionDatosReniecV2
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.grpDatosReniec = New System.Windows.Forms.GroupBox()
            Me.cbbHistorial = New System.Windows.Forms.ComboBox()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtPadre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label43 = New System.Windows.Forms.Label()
            Me.txtTalla = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMadre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtEstadoCivil = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlFotoVis = New System.Windows.Forms.Panel()
            Me.picFoto = New System.Windows.Forms.PictureBox()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.txtGradoInstruccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label38 = New System.Windows.Forms.Label()
            Me.lblApellidoCasada = New System.Windows.Forms.Label()
            Me.txtApellidoCasada = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechaNac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSexo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox12 = New System.Windows.Forms.GroupBox()
            Me.txtUbigeo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtUbigeoDireccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.grpNacimientoReniec = New System.Windows.Forms.GroupBox()
            Me.txtUbigeoNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label46 = New System.Windows.Forms.Label()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtPrimerApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.txtPrenombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label51 = New System.Windows.Forms.Label()
            Me.txtSegundoApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label52 = New System.Windows.Forms.Label()
            Me.Label53 = New System.Windows.Forms.Label()
            Me.txtDigitoVeri = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDni = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.grpMensaje = New System.Windows.Forms.GroupBox()
            Me.dgwGrillaDetalle = New Legolas.APPUIComponents.myDatagridView()
            Me.col_int_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_aso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_reg_na = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_rnc_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_val_na = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.grpDatosReniec.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.pnlFotoVis.SuspendLayout()
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox12.SuspendLayout()
            Me.grpNacimientoReniec.SuspendLayout()
            Me.grpMensaje.SuspendLayout()
            CType(Me.dgwGrillaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grpDatosReniec
            '
            Me.grpDatosReniec.Controls.Add(Me.cbbHistorial)
            Me.grpDatosReniec.Controls.Add(Me.GroupBox9)
            Me.grpDatosReniec.Location = New System.Drawing.Point(1, 0)
            Me.grpDatosReniec.Name = "grpDatosReniec"
            Me.grpDatosReniec.Size = New System.Drawing.Size(469, 348)
            Me.grpDatosReniec.TabIndex = 0
            Me.grpDatosReniec.TabStop = False
            Me.grpDatosReniec.Text = "                                                                   DATOS RENIEC"
            '
            'cbbHistorial
            '
            Me.cbbHistorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbHistorial.FormattingEnabled = True
            Me.cbbHistorial.Location = New System.Drawing.Point(0, 2)
            Me.cbbHistorial.Name = "cbbHistorial"
            Me.cbbHistorial.Size = New System.Drawing.Size(122, 21)
            Me.cbbHistorial.TabIndex = 0
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.Label3)
            Me.GroupBox9.Controls.Add(Me.txtPadre)
            Me.GroupBox9.Controls.Add(Me.Label43)
            Me.GroupBox9.Controls.Add(Me.txtTalla)
            Me.GroupBox9.Controls.Add(Me.txtMadre)
            Me.GroupBox9.Controls.Add(Me.txtEstadoCivil)
            Me.GroupBox9.Controls.Add(Me.pnlFotoVis)
            Me.GroupBox9.Controls.Add(Me.Label44)
            Me.GroupBox9.Controls.Add(Me.txtGradoInstruccion)
            Me.GroupBox9.Controls.Add(Me.Label38)
            Me.GroupBox9.Controls.Add(Me.lblApellidoCasada)
            Me.GroupBox9.Controls.Add(Me.txtApellidoCasada)
            Me.GroupBox9.Controls.Add(Me.txtFechaNac)
            Me.GroupBox9.Controls.Add(Me.txtSexo)
            Me.GroupBox9.Controls.Add(Me.GroupBox12)
            Me.GroupBox9.Controls.Add(Me.grpNacimientoReniec)
            Me.GroupBox9.Controls.Add(Me.Label47)
            Me.GroupBox9.Controls.Add(Me.txtPrimerApellido)
            Me.GroupBox9.Controls.Add(Me.Label49)
            Me.GroupBox9.Controls.Add(Me.Label50)
            Me.GroupBox9.Controls.Add(Me.txtPrenombres)
            Me.GroupBox9.Controls.Add(Me.Label51)
            Me.GroupBox9.Controls.Add(Me.txtSegundoApellido)
            Me.GroupBox9.Controls.Add(Me.Label52)
            Me.GroupBox9.Controls.Add(Me.Label53)
            Me.GroupBox9.Controls.Add(Me.txtDigitoVeri)
            Me.GroupBox9.Controls.Add(Me.txtDni)
            Me.GroupBox9.Controls.Add(Me.Label2)
            Me.GroupBox9.Controls.Add(Me.Label48)
            Me.GroupBox9.Controls.Add(Me.Label37)
            Me.GroupBox9.Location = New System.Drawing.Point(3, 11)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(464, 333)
            Me.GroupBox9.TabIndex = 0
            Me.GroupBox9.TabStop = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(200, 315)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(18, 12)
            Me.Label3.TabIndex = 26
            Me.Label3.Text = "cm"
            '
            'txtPadre
            '
            Me.txtPadre._BloquearPaste = False
            Me.txtPadre._SeleccionarTodo = False
            Me.txtPadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPadre.Location = New System.Drawing.Point(311, 262)
            Me.txtPadre.Name = "txtPadre"
            Me.txtPadre.ReadOnly = True
            Me.txtPadre.Size = New System.Drawing.Size(150, 20)
            Me.txtPadre.TabIndex = 19
            Me.txtPadre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPadre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label43
            '
            Me.Label43.AutoSize = True
            Me.Label43.Location = New System.Drawing.Point(221, 265)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(41, 13)
            Me.Label43.TabIndex = 18
            Me.Label43.Text = "Padre :"
            '
            'txtTalla
            '
            Me.txtTalla._BloquearPaste = False
            Me.txtTalla._SeleccionarTodo = False
            Me.txtTalla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTalla.Location = New System.Drawing.Point(172, 311)
            Me.txtTalla.Name = "txtTalla"
            Me.txtTalla.ReadOnly = True
            Me.txtTalla.Size = New System.Drawing.Size(28, 20)
            Me.txtTalla.TabIndex = 25
            Me.txtTalla.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTalla.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtMadre
            '
            Me.txtMadre._BloquearPaste = False
            Me.txtMadre._SeleccionarTodo = False
            Me.txtMadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMadre.Location = New System.Drawing.Point(311, 286)
            Me.txtMadre.Name = "txtMadre"
            Me.txtMadre.ReadOnly = True
            Me.txtMadre.Size = New System.Drawing.Size(150, 20)
            Me.txtMadre.TabIndex = 21
            Me.txtMadre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMadre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtEstadoCivil
            '
            Me.txtEstadoCivil._BloquearPaste = True
            Me.txtEstadoCivil._SeleccionarTodo = False
            Me.txtEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEstadoCivil.Location = New System.Drawing.Point(311, 237)
            Me.txtEstadoCivil.Name = "txtEstadoCivil"
            Me.txtEstadoCivil.ReadOnly = True
            Me.txtEstadoCivil.Size = New System.Drawing.Size(150, 20)
            Me.txtEstadoCivil.TabIndex = 17
            Me.txtEstadoCivil.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstadoCivil.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'pnlFotoVis
            '
            Me.pnlFotoVis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlFotoVis.Controls.Add(Me.picFoto)
            Me.pnlFotoVis.Location = New System.Drawing.Point(4, 41)
            Me.pnlFotoVis.Name = "pnlFotoVis"
            Me.pnlFotoVis.Size = New System.Drawing.Size(207, 265)
            Me.pnlFotoVis.TabIndex = 29
            '
            'picFoto
            '
            Me.picFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.picFoto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.picFoto.Image = Global.APPControls.My.Resources.Resources.sin_fotografia
            Me.picFoto.Location = New System.Drawing.Point(0, 0)
            Me.picFoto.Name = "picFoto"
            Me.picFoto.Size = New System.Drawing.Size(203, 261)
            Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picFoto.TabIndex = 22
            Me.picFoto.TabStop = False
            '
            'Label44
            '
            Me.Label44.AutoSize = True
            Me.Label44.Location = New System.Drawing.Point(221, 291)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(43, 13)
            Me.Label44.TabIndex = 20
            Me.Label44.Text = "Madre :"
            '
            'txtGradoInstruccion
            '
            Me.txtGradoInstruccion._BloquearPaste = False
            Me.txtGradoInstruccion._SeleccionarTodo = False
            Me.txtGradoInstruccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtGradoInstruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGradoInstruccion.Location = New System.Drawing.Point(311, 311)
            Me.txtGradoInstruccion.Name = "txtGradoInstruccion"
            Me.txtGradoInstruccion.ReadOnly = True
            Me.txtGradoInstruccion.Size = New System.Drawing.Size(150, 18)
            Me.txtGradoInstruccion.TabIndex = 28
            Me.txtGradoInstruccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtGradoInstruccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Location = New System.Drawing.Point(221, 313)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(56, 13)
            Me.Label38.TabIndex = 27
            Me.Label38.Text = "Grad. Inst."
            '
            'lblApellidoCasada
            '
            Me.lblApellidoCasada.AutoSize = True
            Me.lblApellidoCasada.Location = New System.Drawing.Point(1, 307)
            Me.lblApellidoCasada.Name = "lblApellidoCasada"
            Me.lblApellidoCasada.Size = New System.Drawing.Size(46, 26)
            Me.lblApellidoCasada.TabIndex = 22
            Me.lblApellidoCasada.Text = "Ape. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Casada:"
            Me.lblApellidoCasada.Visible = False
            '
            'txtApellidoCasada
            '
            Me.txtApellidoCasada._BloquearPaste = True
            Me.txtApellidoCasada._SeleccionarTodo = False
            Me.txtApellidoCasada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApellidoCasada.Location = New System.Drawing.Point(48, 310)
            Me.txtApellidoCasada.Name = "txtApellidoCasada"
            Me.txtApellidoCasada.ReadOnly = True
            Me.txtApellidoCasada.Size = New System.Drawing.Size(91, 20)
            Me.txtApellidoCasada.TabIndex = 23
            Me.txtApellidoCasada.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApellidoCasada.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            Me.txtApellidoCasada.Visible = False
            '
            'txtFechaNac
            '
            Me.txtFechaNac._BloquearPaste = False
            Me.txtFechaNac._SeleccionarTodo = False
            Me.txtFechaNac.Location = New System.Drawing.Point(310, 109)
            Me.txtFechaNac.Name = "txtFechaNac"
            Me.txtFechaNac.ReadOnly = True
            Me.txtFechaNac.Size = New System.Drawing.Size(70, 20)
            Me.txtFechaNac.TabIndex = 11
            Me.txtFechaNac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaNac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSexo
            '
            Me.txtSexo._BloquearPaste = True
            Me.txtSexo._SeleccionarTodo = False
            Me.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSexo.Location = New System.Drawing.Point(416, 110)
            Me.txtSexo.Name = "txtSexo"
            Me.txtSexo.ReadOnly = True
            Me.txtSexo.Size = New System.Drawing.Size(44, 20)
            Me.txtSexo.TabIndex = 13
            Me.txtSexo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSexo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'GroupBox12
            '
            Me.GroupBox12.Controls.Add(Me.txtUbigeo)
            Me.GroupBox12.Controls.Add(Me.txtUbigeoDireccion)
            Me.GroupBox12.Location = New System.Drawing.Point(219, 172)
            Me.GroupBox12.Name = "GroupBox12"
            Me.GroupBox12.Size = New System.Drawing.Size(245, 65)
            Me.GroupBox12.TabIndex = 15
            Me.GroupBox12.TabStop = False
            Me.GroupBox12.Text = "Ubigeo Departamento / Provincia / Distrito :"
            '
            'txtUbigeo
            '
            Me.txtUbigeo._BloquearPaste = False
            Me.txtUbigeo._SeleccionarTodo = False
            Me.txtUbigeo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbigeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbigeo.Location = New System.Drawing.Point(6, 16)
            Me.txtUbigeo.Name = "txtUbigeo"
            Me.txtUbigeo.ReadOnly = True
            Me.txtUbigeo.Size = New System.Drawing.Size(237, 18)
            Me.txtUbigeo.TabIndex = 0
            Me.txtUbigeo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtUbigeo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtUbigeoDireccion
            '
            Me.txtUbigeoDireccion._BloquearPaste = False
            Me.txtUbigeoDireccion._SeleccionarTodo = False
            Me.txtUbigeoDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbigeoDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbigeoDireccion.Location = New System.Drawing.Point(6, 40)
            Me.txtUbigeoDireccion.Name = "txtUbigeoDireccion"
            Me.txtUbigeoDireccion.ReadOnly = True
            Me.txtUbigeoDireccion.Size = New System.Drawing.Size(237, 18)
            Me.txtUbigeoDireccion.TabIndex = 1
            Me.txtUbigeoDireccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtUbigeoDireccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'grpNacimientoReniec
            '
            Me.grpNacimientoReniec.Controls.Add(Me.txtUbigeoNacimiento)
            Me.grpNacimientoReniec.Controls.Add(Me.Label46)
            Me.grpNacimientoReniec.Location = New System.Drawing.Point(217, 131)
            Me.grpNacimientoReniec.Name = "grpNacimientoReniec"
            Me.grpNacimientoReniec.Size = New System.Drawing.Size(245, 40)
            Me.grpNacimientoReniec.TabIndex = 14
            Me.grpNacimientoReniec.TabStop = False
            Me.grpNacimientoReniec.Text = "Lugar de Nacimiento:     "
            '
            'txtUbigeoNacimiento
            '
            Me.txtUbigeoNacimiento._BloquearPaste = False
            Me.txtUbigeoNacimiento._SeleccionarTodo = False
            Me.txtUbigeoNacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbigeoNacimiento.Location = New System.Drawing.Point(6, 15)
            Me.txtUbigeoNacimiento.Name = "txtUbigeoNacimiento"
            Me.txtUbigeoNacimiento.ReadOnly = True
            Me.txtUbigeoNacimiento.Size = New System.Drawing.Size(237, 20)
            Me.txtUbigeoNacimiento.TabIndex = 0
            Me.txtUbigeoNacimiento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtUbigeoNacimiento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
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
            Me.Label47.Location = New System.Drawing.Point(221, 42)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(82, 13)
            Me.Label47.TabIndex = 4
            Me.Label47.Text = "Primer Apellido :"
            '
            'txtPrimerApellido
            '
            Me.txtPrimerApellido._BloquearPaste = True
            Me.txtPrimerApellido._SeleccionarTodo = False
            Me.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrimerApellido.Location = New System.Drawing.Point(310, 39)
            Me.txtPrimerApellido.Name = "txtPrimerApellido"
            Me.txtPrimerApellido.ReadOnly = True
            Me.txtPrimerApellido.Size = New System.Drawing.Size(150, 20)
            Me.txtPrimerApellido.TabIndex = 5
            Me.txtPrimerApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrimerApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Location = New System.Drawing.Point(221, 89)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(74, 13)
            Me.Label49.TabIndex = 8
            Me.Label49.Text = "Pre Nombres :"
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Location = New System.Drawing.Point(380, 113)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(37, 13)
            Me.Label50.TabIndex = 12
            Me.Label50.Text = "Sexo :"
            '
            'txtPrenombres
            '
            Me.txtPrenombres._BloquearPaste = True
            Me.txtPrenombres._SeleccionarTodo = False
            Me.txtPrenombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrenombres.Location = New System.Drawing.Point(310, 86)
            Me.txtPrenombres.Name = "txtPrenombres"
            Me.txtPrenombres.ReadOnly = True
            Me.txtPrenombres.Size = New System.Drawing.Size(150, 20)
            Me.txtPrenombres.TabIndex = 9
            Me.txtPrenombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrenombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Location = New System.Drawing.Point(221, 113)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(69, 13)
            Me.Label51.TabIndex = 10
            Me.Label51.Text = "Fecha Nac. :"
            '
            'txtSegundoApellido
            '
            Me.txtSegundoApellido._BloquearPaste = True
            Me.txtSegundoApellido._SeleccionarTodo = False
            Me.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSegundoApellido.Location = New System.Drawing.Point(310, 61)
            Me.txtSegundoApellido.Name = "txtSegundoApellido"
            Me.txtSegundoApellido.ReadOnly = True
            Me.txtSegundoApellido.Size = New System.Drawing.Size(150, 20)
            Me.txtSegundoApellido.TabIndex = 7
            Me.txtSegundoApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSegundoApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Location = New System.Drawing.Point(221, 18)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(47, 13)
            Me.Label52.TabIndex = 0
            Me.Label52.Text = "N° DNI :"
            '
            'Label53
            '
            Me.Label53.AutoSize = True
            Me.Label53.Location = New System.Drawing.Point(221, 240)
            Me.Label53.Name = "Label53"
            Me.Label53.Size = New System.Drawing.Size(67, 13)
            Me.Label53.TabIndex = 16
            Me.Label53.Text = "Estado civil :"
            '
            'txtDigitoVeri
            '
            Me.txtDigitoVeri._BloquearPaste = False
            Me.txtDigitoVeri._SeleccionarTodo = False
            Me.txtDigitoVeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDigitoVeri.Location = New System.Drawing.Point(435, 14)
            Me.txtDigitoVeri.Name = "txtDigitoVeri"
            Me.txtDigitoVeri.ReadOnly = True
            Me.txtDigitoVeri.Size = New System.Drawing.Size(25, 21)
            Me.txtDigitoVeri.TabIndex = 3
            Me.txtDigitoVeri.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDigitoVeri.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtDni
            '
            Me.txtDni._BloquearPaste = False
            Me.txtDni._SeleccionarTodo = False
            Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDni.Location = New System.Drawing.Point(310, 14)
            Me.txtDni.Name = "txtDni"
            Me.txtDni.ReadOnly = True
            Me.txtDni.Size = New System.Drawing.Size(115, 21)
            Me.txtDni.TabIndex = 1
            Me.txtDni.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDni.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(424, 16)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(14, 18)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "-"
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Location = New System.Drawing.Point(221, 66)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(90, 13)
            Me.Label48.TabIndex = 6
            Me.Label48.Text = "Segundo Apellido"
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.Location = New System.Drawing.Point(138, 313)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(36, 13)
            Me.Label37.TabIndex = 24
            Me.Label37.Text = "Talla :"
            '
            'grpMensaje
            '
            Me.grpMensaje.BackColor = System.Drawing.Color.Transparent
            Me.grpMensaje.Controls.Add(Me.dgwGrillaDetalle)
            Me.grpMensaje.Location = New System.Drawing.Point(3, 343)
            Me.grpMensaje.Name = "grpMensaje"
            Me.grpMensaje.Size = New System.Drawing.Size(464, 60)
            Me.grpMensaje.TabIndex = 1
            Me.grpMensaje.TabStop = False
            '
            'dgwGrillaDetalle
            '
            Me.dgwGrillaDetalle.AllowUserToAddRows = False
            Me.dgwGrillaDetalle.AllowUserToDeleteRows = False
            Me.dgwGrillaDetalle.AllowUserToResizeRows = False
            Me.dgwGrillaDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgwGrillaDetalle.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrillaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_num, Me.col_ape_pat, Me.col_int_id, Me.col_nom_aso_id, Me.col_ape_mat, Me.col_nom, Me.col_fec_reg_na, Me.col_rnc_obs, Me.col_val_na})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaDetalle.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrillaDetalle.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaDetalle.Location = New System.Drawing.Point(3, 10)
            Me.dgwGrillaDetalle.MultiSelect = False
            Me.dgwGrillaDetalle.Name = "dgwGrillaDetalle"
            Me.dgwGrillaDetalle.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrillaDetalle.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaDetalle.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrillaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaDetalle.Size = New System.Drawing.Size(459, 45)
            Me.dgwGrillaDetalle.TabIndex = 0
            Me.dgwGrillaDetalle.VisibleCampos = False
            '
            'col_int_num
            '
            Me.col_int_num.DividerWidth = 1
            Me.col_int_num.HeaderText = "Tipo Verific."
            Me.col_int_num.Name = "col_int_num"
            Me.col_int_num.ReadOnly = True
            Me.col_int_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_int_num.Width = 92
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_ape_pat.HeaderText = "Fec. Validac."
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ape_pat.Width = 96
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "Codigo"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "Fec. Insc."
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_int_id.Width = 67
            '
            'col_nom_aso_id
            '
            Me.col_nom_aso_id.DataPropertyName = "Codigo"
            Me.col_nom_aso_id.DividerWidth = 1
            Me.col_nom_aso_id.HeaderText = "Fec. Emis."
            Me.col_nom_aso_id.Name = "col_nom_aso_id"
            Me.col_nom_aso_id.ReadOnly = True
            Me.col_nom_aso_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_nom_aso_id.Width = 67
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_ape_mat.HeaderText = "Estado"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ape_mat.Width = 75
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Restricc."
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_nom.Width = 60
            '
            'col_fec_reg_na
            '
            Me.col_fec_reg_na.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_fec_reg_na.DataPropertyName = "FechaRegNomAsoDate"
            Me.col_fec_reg_na.HeaderText = "Fec.Registro"
            Me.col_fec_reg_na.Name = "col_fec_reg_na"
            Me.col_fec_reg_na.ReadOnly = True
            Me.col_fec_reg_na.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_fec_reg_na.Visible = False
            '
            'col_rnc_obs
            '
            Me.col_rnc_obs.HeaderText = "Observacion"
            Me.col_rnc_obs.Name = "col_rnc_obs"
            Me.col_rnc_obs.ReadOnly = True
            Me.col_rnc_obs.Visible = False
            '
            'col_val_na
            '
            Me.col_val_na.HeaderText = "ValidacioNA"
            Me.col_val_na.Name = "col_val_na"
            Me.col_val_na.ReadOnly = True
            Me.col_val_na.Visible = False
            '
            'uscValidacionDatosReniecV2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.grpDatosReniec)
            Me.Controls.Add(Me.grpMensaje)
            Me.Name = "uscValidacionDatosReniecV2"
            Me.Size = New System.Drawing.Size(473, 405)
            Me.grpDatosReniec.ResumeLayout(False)
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.pnlFotoVis.ResumeLayout(False)
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox12.ResumeLayout(False)
            Me.GroupBox12.PerformLayout()
            Me.grpNacimientoReniec.ResumeLayout(False)
            Me.grpNacimientoReniec.PerformLayout()
            Me.grpMensaje.ResumeLayout(False)
            CType(Me.dgwGrillaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grpDatosReniec As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents txtFechaNac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents txtTalla As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtGradoInstruccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents txtSexo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
        Friend WithEvents txtUbigeo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtUbigeoDireccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents grpNacimientoReniec As System.Windows.Forms.GroupBox
        Friend WithEvents txtUbigeoNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label46 As System.Windows.Forms.Label
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents txtPrimerApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDni As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents Label49 As System.Windows.Forms.Label
        Friend WithEvents Label50 As System.Windows.Forms.Label
        Friend WithEvents txtPrenombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label51 As System.Windows.Forms.Label
        Friend WithEvents txtSegundoApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label52 As System.Windows.Forms.Label
        Friend WithEvents Label53 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtDigitoVeri As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblApellidoCasada As System.Windows.Forms.Label
        Friend WithEvents txtApellidoCasada As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlFotoVis As System.Windows.Forms.Panel
        Friend WithEvents txtEstadoCivil As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label43 As System.Windows.Forms.Label
        Friend WithEvents txtMadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label44 As System.Windows.Forms.Label
        Friend WithEvents picFoto As System.Windows.Forms.PictureBox
        Friend WithEvents grpMensaje As System.Windows.Forms.GroupBox
        Friend WithEvents cbbHistorial As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dgwGrillaDetalle As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_int_num As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom_aso_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_reg_na As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_rnc_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_val_na As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace
