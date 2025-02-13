Namespace Tratamiento.AfiliacionSIS
    'jgjg

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReniec
        Inherits System.Windows.Forms.Form

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReniec))
            Me.pnlListaNombres = New System.Windows.Forms.Panel()
            Me.grpDatosReniec = New System.Windows.Forms.GroupBox()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.txtPadre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label43 = New System.Windows.Forms.Label()
            Me.txtMadre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtEstadoCivil = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlFotoVis = New System.Windows.Forms.Panel()
            Me.picFoto = New System.Windows.Forms.PictureBox()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtFechaNac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSexo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.grpNacimientoReniec = New System.Windows.Forms.GroupBox()
            Me.txtUbigeoNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label46 = New System.Windows.Forms.Label()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtPrimerApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.txtPrenombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label51 = New System.Windows.Forms.Label()
            Me.txtSegundoApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label52 = New System.Windows.Forms.Label()
            Me.Label53 = New System.Windows.Forms.Label()
            Me.txtDigitoVeri = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDni = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.GroupBox12 = New System.Windows.Forms.GroupBox()
            Me.txtUbigeo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtUbigeoDireccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlListaNombres.SuspendLayout()
            Me.grpDatosReniec.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.pnlFotoVis.SuspendLayout()
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpNacimientoReniec.SuspendLayout()
            Me.pnlBotones.SuspendLayout()
            Me.GroupBox12.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlListaNombres
            '
            Me.pnlListaNombres.BackColor = System.Drawing.Color.Transparent
            Me.pnlListaNombres.Controls.Add(Me.grpDatosReniec)
            Me.pnlListaNombres.Controls.Add(Me.pnlBotones)
            Me.pnlListaNombres.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlListaNombres.Location = New System.Drawing.Point(0, 0)
            Me.pnlListaNombres.Name = "pnlListaNombres"
            Me.pnlListaNombres.Size = New System.Drawing.Size(503, 392)
            Me.pnlListaNombres.TabIndex = 16
            '
            'grpDatosReniec
            '
            Me.grpDatosReniec.Controls.Add(Me.GroupBox9)
            Me.grpDatosReniec.Location = New System.Drawing.Point(2, 5)
            Me.grpDatosReniec.Name = "grpDatosReniec"
            Me.grpDatosReniec.Size = New System.Drawing.Size(498, 336)
            Me.grpDatosReniec.TabIndex = 1
            Me.grpDatosReniec.TabStop = False
            Me.grpDatosReniec.Text = "                          DATOS RENIEC"
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.GroupBox12)
            Me.GroupBox9.Controls.Add(Me.txtPadre)
            Me.GroupBox9.Controls.Add(Me.Label43)
            Me.GroupBox9.Controls.Add(Me.txtMadre)
            Me.GroupBox9.Controls.Add(Me.txtEstadoCivil)
            Me.GroupBox9.Controls.Add(Me.pnlFotoVis)
            Me.GroupBox9.Controls.Add(Me.Label44)
            Me.GroupBox9.Controls.Add(Me.Label2)
            Me.GroupBox9.Controls.Add(Me.txtFechaNac)
            Me.GroupBox9.Controls.Add(Me.txtSexo)
            Me.GroupBox9.Controls.Add(Me.grpNacimientoReniec)
            Me.GroupBox9.Controls.Add(Me.Label47)
            Me.GroupBox9.Controls.Add(Me.txtPrimerApellido)
            Me.GroupBox9.Controls.Add(Me.Label48)
            Me.GroupBox9.Controls.Add(Me.Label49)
            Me.GroupBox9.Controls.Add(Me.Label50)
            Me.GroupBox9.Controls.Add(Me.txtPrenombres)
            Me.GroupBox9.Controls.Add(Me.Label51)
            Me.GroupBox9.Controls.Add(Me.txtSegundoApellido)
            Me.GroupBox9.Controls.Add(Me.Label52)
            Me.GroupBox9.Controls.Add(Me.Label53)
            Me.GroupBox9.Controls.Add(Me.txtDigitoVeri)
            Me.GroupBox9.Controls.Add(Me.txtDni)
            Me.GroupBox9.Location = New System.Drawing.Point(5, 11)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(488, 320)
            Me.GroupBox9.TabIndex = 0
            Me.GroupBox9.TabStop = False
            '
            'txtPadre
            '
            Me.txtPadre._BloquearPaste = False
            Me.txtPadre._SeleccionarTodo = False
            Me.txtPadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPadre.Location = New System.Drawing.Point(317, 271)
            Me.txtPadre.Name = "txtPadre"
            Me.txtPadre.ReadOnly = True
            Me.txtPadre.Size = New System.Drawing.Size(150, 20)
            Me.txtPadre.TabIndex = 25
            Me.txtPadre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPadre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label43
            '
            Me.Label43.AutoSize = True
            Me.Label43.Location = New System.Drawing.Point(222, 276)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(41, 13)
            Me.Label43.TabIndex = 24
            Me.Label43.Text = "Padre :"
            '
            'txtMadre
            '
            Me.txtMadre._BloquearPaste = False
            Me.txtMadre._SeleccionarTodo = False
            Me.txtMadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMadre.Location = New System.Drawing.Point(317, 295)
            Me.txtMadre.Name = "txtMadre"
            Me.txtMadre.ReadOnly = True
            Me.txtMadre.Size = New System.Drawing.Size(150, 20)
            Me.txtMadre.TabIndex = 27
            Me.txtMadre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMadre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtEstadoCivil
            '
            Me.txtEstadoCivil._BloquearPaste = True
            Me.txtEstadoCivil._SeleccionarTodo = False
            Me.txtEstadoCivil.Location = New System.Drawing.Point(317, 248)
            Me.txtEstadoCivil.Name = "txtEstadoCivil"
            Me.txtEstadoCivil.ReadOnly = True
            Me.txtEstadoCivil.Size = New System.Drawing.Size(150, 20)
            Me.txtEstadoCivil.TabIndex = 23
            Me.txtEstadoCivil.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstadoCivil.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'pnlFotoVis
            '
            Me.pnlFotoVis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlFotoVis.Controls.Add(Me.picFoto)
            Me.pnlFotoVis.Location = New System.Drawing.Point(4, 47)
            Me.pnlFotoVis.Name = "pnlFotoVis"
            Me.pnlFotoVis.Size = New System.Drawing.Size(212, 269)
            Me.pnlFotoVis.TabIndex = 35
            '
            'picFoto
            '
            Me.picFoto.BackColor = System.Drawing.Color.PaleGoldenrod
            Me.picFoto.BackgroundImage = CType(resources.GetObject("picFoto.BackgroundImage"), System.Drawing.Image)
            Me.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.picFoto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.picFoto.Location = New System.Drawing.Point(0, 0)
            Me.picFoto.Name = "picFoto"
            Me.picFoto.Size = New System.Drawing.Size(208, 265)
            Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picFoto.TabIndex = 22
            Me.picFoto.TabStop = False
            '
            'Label44
            '
            Me.Label44.AutoSize = True
            Me.Label44.Location = New System.Drawing.Point(222, 300)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(43, 13)
            Me.Label44.TabIndex = 26
            Me.Label44.Text = "Madre :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(425, 13)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(14, 18)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "-"
            '
            'txtFechaNac
            '
            Me.txtFechaNac._BloquearPaste = False
            Me.txtFechaNac._SeleccionarTodo = False
            Me.txtFechaNac.Location = New System.Drawing.Point(317, 118)
            Me.txtFechaNac.Name = "txtFechaNac"
            Me.txtFechaNac.ReadOnly = True
            Me.txtFechaNac.Size = New System.Drawing.Size(70, 20)
            Me.txtFechaNac.TabIndex = 17
            Me.txtFechaNac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaNac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSexo
            '
            Me.txtSexo._BloquearPaste = True
            Me.txtSexo._SeleccionarTodo = False
            Me.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSexo.Location = New System.Drawing.Point(428, 119)
            Me.txtSexo.MaxLength = 3
            Me.txtSexo.Name = "txtSexo"
            Me.txtSexo.ReadOnly = True
            Me.txtSexo.Size = New System.Drawing.Size(39, 20)
            Me.txtSexo.TabIndex = 19
            Me.txtSexo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSexo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'grpNacimientoReniec
            '
            Me.grpNacimientoReniec.Controls.Add(Me.txtUbigeoNacimiento)
            Me.grpNacimientoReniec.Controls.Add(Me.Label46)
            Me.grpNacimientoReniec.Location = New System.Drawing.Point(220, 143)
            Me.grpNacimientoReniec.Name = "grpNacimientoReniec"
            Me.grpNacimientoReniec.Size = New System.Drawing.Size(261, 40)
            Me.grpNacimientoReniec.TabIndex = 20
            Me.grpNacimientoReniec.TabStop = False
            Me.grpNacimientoReniec.Text = "Lugar de Nacimiento :"
            '
            'txtUbigeoNacimiento
            '
            Me.txtUbigeoNacimiento._BloquearPaste = False
            Me.txtUbigeoNacimiento._SeleccionarTodo = False
            Me.txtUbigeoNacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbigeoNacimiento.Location = New System.Drawing.Point(10, 15)
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
            Me.Label47.Location = New System.Drawing.Point(222, 42)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(82, 13)
            Me.Label47.TabIndex = 8
            Me.Label47.Text = "Primer Apellido :"
            '
            'txtPrimerApellido
            '
            Me.txtPrimerApellido._BloquearPaste = True
            Me.txtPrimerApellido._SeleccionarTodo = False
            Me.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrimerApellido.Location = New System.Drawing.Point(317, 39)
            Me.txtPrimerApellido.Name = "txtPrimerApellido"
            Me.txtPrimerApellido.ReadOnly = True
            Me.txtPrimerApellido.Size = New System.Drawing.Size(150, 20)
            Me.txtPrimerApellido.TabIndex = 9
            Me.txtPrimerApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrimerApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Location = New System.Drawing.Point(222, 71)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(96, 13)
            Me.Label48.TabIndex = 10
            Me.Label48.Text = "Segundo Apellido :"
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Location = New System.Drawing.Point(222, 95)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(74, 13)
            Me.Label49.TabIndex = 14
            Me.Label49.Text = "Pre Nombres :"
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Location = New System.Drawing.Point(388, 122)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(37, 13)
            Me.Label50.TabIndex = 18
            Me.Label50.Text = "Sexo :"
            '
            'txtPrenombres
            '
            Me.txtPrenombres._BloquearPaste = True
            Me.txtPrenombres._SeleccionarTodo = False
            Me.txtPrenombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrenombres.Location = New System.Drawing.Point(317, 92)
            Me.txtPrenombres.Name = "txtPrenombres"
            Me.txtPrenombres.ReadOnly = True
            Me.txtPrenombres.Size = New System.Drawing.Size(150, 20)
            Me.txtPrenombres.TabIndex = 15
            Me.txtPrenombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrenombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Location = New System.Drawing.Point(224, 122)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(69, 13)
            Me.Label51.TabIndex = 16
            Me.Label51.Text = "Fecha Nac. :"
            '
            'txtSegundoApellido
            '
            Me.txtSegundoApellido._BloquearPaste = True
            Me.txtSegundoApellido._SeleccionarTodo = False
            Me.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSegundoApellido.Location = New System.Drawing.Point(317, 66)
            Me.txtSegundoApellido.Name = "txtSegundoApellido"
            Me.txtSegundoApellido.ReadOnly = True
            Me.txtSegundoApellido.Size = New System.Drawing.Size(150, 20)
            Me.txtSegundoApellido.TabIndex = 11
            Me.txtSegundoApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSegundoApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Location = New System.Drawing.Point(222, 19)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(72, 13)
            Me.Label52.TabIndex = 2
            Me.Label52.Text = "Numero DNI :"
            '
            'Label53
            '
            Me.Label53.AutoSize = True
            Me.Label53.Location = New System.Drawing.Point(222, 251)
            Me.Label53.Name = "Label53"
            Me.Label53.Size = New System.Drawing.Size(67, 13)
            Me.Label53.TabIndex = 22
            Me.Label53.Text = "Estado civil :"
            '
            'txtDigitoVeri
            '
            Me.txtDigitoVeri._BloquearPaste = False
            Me.txtDigitoVeri._SeleccionarTodo = False
            Me.txtDigitoVeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDigitoVeri.Location = New System.Drawing.Point(440, 10)
            Me.txtDigitoVeri.Name = "txtDigitoVeri"
            Me.txtDigitoVeri.ReadOnly = True
            Me.txtDigitoVeri.Size = New System.Drawing.Size(27, 22)
            Me.txtDigitoVeri.TabIndex = 5
            Me.txtDigitoVeri.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDigitoVeri.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtDni
            '
            Me.txtDni._BloquearPaste = False
            Me.txtDni._SeleccionarTodo = False
            Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDni.Location = New System.Drawing.Point(317, 10)
            Me.txtDni.Name = "txtDni"
            Me.txtDni.ReadOnly = True
            Me.txtDni.Size = New System.Drawing.Size(105, 22)
            Me.txtDni.TabIndex = 3
            Me.txtDni.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDni.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.btnCancel)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBotones.Location = New System.Drawing.Point(0, 343)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(503, 49)
            Me.pnlBotones.TabIndex = 0
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(403, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(90, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox12
            '
            Me.GroupBox12.Controls.Add(Me.txtUbigeo)
            Me.GroupBox12.Controls.Add(Me.txtUbigeoDireccion)
            Me.GroupBox12.Location = New System.Drawing.Point(220, 184)
            Me.GroupBox12.Name = "GroupBox12"
            Me.GroupBox12.Size = New System.Drawing.Size(265, 63)
            Me.GroupBox12.TabIndex = 36
            Me.GroupBox12.TabStop = False
            Me.GroupBox12.Text = "Ubigeo Departamento/Provincia/Distrito :"
            '
            'txtUbigeo
            '
            Me.txtUbigeo._BloquearPaste = False
            Me.txtUbigeo._SeleccionarTodo = False
            Me.txtUbigeo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbigeo.Location = New System.Drawing.Point(11, 15)
            Me.txtUbigeo.Name = "txtUbigeo"
            Me.txtUbigeo.ReadOnly = True
            Me.txtUbigeo.Size = New System.Drawing.Size(237, 20)
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
            Me.txtUbigeoDireccion.Location = New System.Drawing.Point(11, 41)
            Me.txtUbigeoDireccion.Name = "txtUbigeoDireccion"
            Me.txtUbigeoDireccion.ReadOnly = True
            Me.txtUbigeoDireccion.Size = New System.Drawing.Size(237, 18)
            Me.txtUbigeoDireccion.TabIndex = 1
            Me.txtUbigeoDireccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtUbigeoDireccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'frmReniec
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(503, 392)
            Me.Controls.Add(Me.pnlListaNombres)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmReniec"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Datos de Reniec"
            Me.pnlListaNombres.ResumeLayout(False)
            Me.grpDatosReniec.ResumeLayout(False)
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.pnlFotoVis.ResumeLayout(False)
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpNacimientoReniec.ResumeLayout(False)
            Me.grpNacimientoReniec.PerformLayout()
            Me.pnlBotones.ResumeLayout(False)
            Me.GroupBox12.ResumeLayout(False)
            Me.GroupBox12.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlListaNombres As System.Windows.Forms.Panel
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents grpDatosReniec As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents txtPadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label43 As System.Windows.Forms.Label
        Friend WithEvents txtMadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtEstadoCivil As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlFotoVis As System.Windows.Forms.Panel
        Friend WithEvents picFoto As System.Windows.Forms.PictureBox
        Friend WithEvents Label44 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtFechaNac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSexo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents grpNacimientoReniec As System.Windows.Forms.GroupBox
        Friend WithEvents txtUbigeoNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label46 As System.Windows.Forms.Label
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents txtPrimerApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents Label49 As System.Windows.Forms.Label
        Friend WithEvents Label50 As System.Windows.Forms.Label
        Friend WithEvents txtPrenombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label51 As System.Windows.Forms.Label
        Friend WithEvents txtSegundoApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label52 As System.Windows.Forms.Label
        Friend WithEvents Label53 As System.Windows.Forms.Label
        Friend WithEvents txtDigitoVeri As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDni As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
        Friend WithEvents txtUbigeo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtUbigeoDireccion As Legolas.APPUIComponents.MyTextBox

    End Class
End Namespace