Namespace Visita.Visitante
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantenimiento
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimiento))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCapurar = New System.Windows.Forms.Button()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlFotografia = New System.Windows.Forms.Panel()
            Me.UscFoto1 = New APPControls.Foto.uscFotografia()
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.chkOmitirFecha = New System.Windows.Forms.CheckBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaNac = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbSexo = New APPControls.uscComboParametrica()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.MyComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlCambioSexo = New System.Windows.Forms.Panel()
            Me.btnCambiarSexo = New System.Windows.Forms.Button()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.UscVistaHuella1 = New APPControls.Visita.Visitante.uscVistaHuella()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tp_visita = New System.Windows.Forms.TabPage()
            Me.UscMovimientosVisitas1 = New APPControls.Visita.uscMovimientosVisitas()
            Me.tp_sancion2 = New System.Windows.Forms.TabPage()
            Me.UscSancionv21 = New APPControls.Visita.Visitante.uscSancionv2()
            Me.tp_restriccion = New System.Windows.Forms.TabPage()
            Me.UscVisitanteRestriccion1 = New APPControls.Visita.Visitante.uscVisitanteRestriccion()
            Me.tp_Autorizacion = New System.Windows.Forms.TabPage()
            Me.UscAutorizacion1 = New APPControls.Visita.uscAutorizacion()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.UscDateTimePicker3 = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.UscDateTimePicker4 = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.object_638216b9_92f7_4395_95d3_cc6178ae24ef = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.UscRegionPenalLabel1 = New APPControls.uscRegionPenalLabel()
            Me.GroupBox1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlFotografia.SuspendLayout()
            Me.cbbSexo.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlCambioSexo.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tp_visita.SuspendLayout()
            Me.tp_sancion2.SuspendLayout()
            Me.tp_restriccion.SuspendLayout()
            Me.tp_Autorizacion.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.Panel1)
            Me.GroupBox1.Controls.Add(Me.Panel2)
            Me.GroupBox1.Controls.Add(Me.UscVistaHuella1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 37)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1273, 270)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCapurar)
            Me.Panel1.Controls.Add(Me.txtNumDoc)
            Me.Panel1.Controls.Add(Me.pnlFotografia)
            Me.Panel1.Controls.Add(Me.cbbNacionalidad)
            Me.Panel1.Controls.Add(Me.chkOmitirFecha)
            Me.Panel1.Controls.Add(Me.Label10)
            Me.Panel1.Controls.Add(Me.Label9)
            Me.Panel1.Controls.Add(Me.cbbTipoDoc)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.txtApePat)
            Me.Panel1.Controls.Add(Me.dtpFechaNac)
            Me.Panel1.Controls.Add(Me.txtApeMat)
            Me.Panel1.Controls.Add(Me.cbbSexo)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.Label7)
            Me.Panel1.Controls.Add(Me.txtNom)
            Me.Panel1.Controls.Add(Me.Label6)
            Me.Panel1.Location = New System.Drawing.Point(6, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(488, 248)
            Me.Panel1.TabIndex = 0
            '
            'btnCapurar
            '
            Me.btnCapurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnCapurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapurar.ForeColor = System.Drawing.Color.Black
            Me.btnCapurar.Image = Global.SIPPOPE.My.Resources.Resources._1337706653_webcam
            Me.btnCapurar.Location = New System.Drawing.Point(111, 207)
            Me.btnCapurar.Name = "btnCapurar"
            Me.btnCapurar.Size = New System.Drawing.Size(50, 38)
            Me.btnCapurar.TabIndex = 83
            Me.btnCapurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCapurar.UseVisualStyleBackColor = True
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = True
            Me.txtNumDoc._SeleccionarTodo = True
            Me.txtNumDoc.BackColor = System.Drawing.Color.White
            Me.txtNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumDoc.ForeColor = System.Drawing.Color.Black
            Me.txtNumDoc.Location = New System.Drawing.Point(265, 11)
            Me.txtNumDoc.MaxLength = 8
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(135, 35)
            Me.txtNumDoc.TabIndex = 5
            Me.txtNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'pnlFotografia
            '
            Me.pnlFotografia.Controls.Add(Me.UscFoto1)
            Me.pnlFotografia.Location = New System.Drawing.Point(6, 6)
            Me.pnlFotografia.Name = "pnlFotografia"
            Me.pnlFotografia.Size = New System.Drawing.Size(161, 199)
            Me.pnlFotografia.TabIndex = 86
            '
            'UscFoto1
            '
            Me.UscFoto1._CheckImagen = True
            Me.UscFoto1._EnabledDobleClick = True
            Me.UscFoto1._HasImagen = False
            Me.UscFoto1._PanelAutorizacion = False
            Me.UscFoto1._PanelCheck = False
            Me.UscFoto1.BackColor = System.Drawing.SystemColors.Control
            Me.UscFoto1.Location = New System.Drawing.Point(5, 4)
            Me.UscFoto1.Name = "UscFoto1"
            Me.UscFoto1.Size = New System.Drawing.Size(150, 190)
            Me.UscFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.UscFoto1.TabIndex = 0
            Me.UscFoto1.TabStop = False
            '
            'cbbNacionalidad
            '
            Me.cbbNacionalidad._NoIndica = False
            Me.cbbNacionalidad._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbNacionalidad._Todos = False
            Me.cbbNacionalidad._TodosMensaje = ""
            Me.cbbNacionalidad._Visible_Add = False
            Me.cbbNacionalidad._Visible_Buscar = False
            Me.cbbNacionalidad._Visible_Eliminar = False
            Me.cbbNacionalidad.CodigoPadre = -1
            Me.cbbNacionalidad.ComboTipo = CType(4, Short)
            Me.cbbNacionalidad.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNacionalidad.DropDownWidth = 81
            Me.cbbNacionalidad.DropDownWidthAuto = True
            Me.cbbNacionalidad.ListaIdsParaExcluir = Nothing
            Me.cbbNacionalidad.Location = New System.Drawing.Point(265, 153)
            Me.cbbNacionalidad.ModuloTratamiento = False
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(84, 22)
            Me.cbbNacionalidad.TabIndex = 11
            Me.cbbNacionalidad.verToolTipItemSeleccionado = False
            '
            'chkOmitirFecha
            '
            Me.chkOmitirFecha.Location = New System.Drawing.Point(358, 168)
            Me.chkOmitirFecha.Name = "chkOmitirFecha"
            Me.chkOmitirFecha.Size = New System.Drawing.Size(85, 37)
            Me.chkOmitirFecha.TabIndex = 85
            Me.chkOmitirFecha.Text = "Omitir fecha nacimiento"
            Me.chkOmitirFecha.UseVisualStyleBackColor = True
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(182, 22)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(61, 13)
            Me.Label10.TabIndex = 3
            Me.Label10.Text = "Num Doc. :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(182, 55)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(75, 13)
            Me.Label9.TabIndex = 9
            Me.Label9.Text = "Ape. Paterno :"
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc._NoIndica = False
            Me.cbbTipoDoc._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoDoc._Todos = False
            Me.cbbTipoDoc._TodosMensaje = ""
            Me.cbbTipoDoc._Visible_Add = False
            Me.cbbTipoDoc._Visible_Buscar = False
            Me.cbbTipoDoc._Visible_Eliminar = False
            Me.cbbTipoDoc.CodigoPadre = -1
            Me.cbbTipoDoc.ComboTipo = CType(2, Short)
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 95
            Me.cbbTipoDoc.DropDownWidthAuto = True
            Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDoc.Location = New System.Drawing.Point(406, 14)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(67, 22)
            Me.cbbTipoDoc.TabIndex = 6
            Me.cbbTipoDoc.verToolTipItemSeleccionado = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(182, 80)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(77, 13)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Ape. Materno :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(182, 182)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(66, 13)
            Me.Label1.TabIndex = 82
            Me.Label1.Text = "Fecha Nac :"
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = True
            Me.txtApePat.Location = New System.Drawing.Point(265, 52)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(208, 20)
            Me.txtApePat.TabIndex = 7
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'dtpFechaNac
            '
            Me.dtpFechaNac.Location = New System.Drawing.Point(265, 177)
            Me.dtpFechaNac.Name = "dtpFechaNac"
            Me.dtpFechaNac.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaNac.TabIndex = 12
            Me.dtpFechaNac.Value = "/  /"
            Me.dtpFechaNac.ValueLong = CType(0, Long)
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = True
            Me.txtApeMat.Location = New System.Drawing.Point(265, 76)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(208, 20)
            Me.txtApeMat.TabIndex = 8
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'cbbSexo
            '
            Me.cbbSexo._NoIndica = False
            Me.cbbSexo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbSexo._Todos = False
            Me.cbbSexo._TodosMensaje = ""
            Me.cbbSexo._Visible_Add = False
            Me.cbbSexo._Visible_Buscar = False
            Me.cbbSexo._Visible_Eliminar = False
            Me.cbbSexo.CodigoPadre = -1
            Me.cbbSexo.ComboTipo = CType(1, Short)
            Me.cbbSexo.Controls.Add(Me.ComboBox1)
            Me.cbbSexo.Controls.Add(Me.MyComboBox1)
            Me.cbbSexo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbSexo.DropDownWidth = 81
            Me.cbbSexo.DropDownWidthAuto = False
            Me.cbbSexo.ListaIdsParaExcluir = Nothing
            Me.cbbSexo.Location = New System.Drawing.Point(265, 124)
            Me.cbbSexo.ModuloTratamiento = False
            Me.cbbSexo.Name = "cbbSexo"
            Me.cbbSexo.Parametro1 = -1
            Me.cbbSexo.Parametro2 = -1
            Me.cbbSexo.SelectedIndex = -1
            Me.cbbSexo.SelectedValue = 0
            Me.cbbSexo.Size = New System.Drawing.Size(84, 22)
            Me.cbbSexo.TabIndex = 10
            Me.cbbSexo.verToolTipItemSeleccionado = False
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 81
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(84, 21)
            Me.ComboBox1.TabIndex = 0
            '
            'MyComboBox1
            '
            Me.MyComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox1.DropDownWidth = 81
            Me.MyComboBox1.FormattingEnabled = True
            Me.MyComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox1.Name = "MyComboBox1"
            Me.MyComboBox1.Size = New System.Drawing.Size(84, 21)
            Me.MyComboBox1.TabIndex = 2
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(182, 104)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 13)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "Nombres :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(182, 153)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(75, 13)
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Nacionalidad :"
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = True
            Me.txtNom.Location = New System.Drawing.Point(265, 100)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(208, 20)
            Me.txtNom.TabIndex = 9
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(182, 127)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(37, 13)
            Me.Label6.TabIndex = 15
            Me.Label6.Text = "Sexo :"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Panel2.Controls.Add(Me.pnlCambioSexo)
            Me.Panel2.Controls.Add(Me.pnlGrabar)
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(1158, 16)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(112, 251)
            Me.Panel2.TabIndex = 84
            '
            'pnlCambioSexo
            '
            Me.pnlCambioSexo.Controls.Add(Me.btnCambiarSexo)
            Me.pnlCambioSexo.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlCambioSexo.Location = New System.Drawing.Point(0, 116)
            Me.pnlCambioSexo.Name = "pnlCambioSexo"
            Me.pnlCambioSexo.Size = New System.Drawing.Size(112, 45)
            Me.pnlCambioSexo.TabIndex = 19
            Me.pnlCambioSexo.Visible = False
            '
            'btnCambiarSexo
            '
            Me.btnCambiarSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCambiarSexo.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnCambiarSexo.Location = New System.Drawing.Point(7, 3)
            Me.btnCambiarSexo.Name = "btnCambiarSexo"
            Me.btnCambiarSexo.Size = New System.Drawing.Size(97, 40)
            Me.btnCambiarSexo.TabIndex = 15
            Me.btnCambiarSexo.Text = "&Cambiar Sexo"
            Me.btnCambiarSexo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCambiarSexo.UseVisualStyleBackColor = True
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnGrabar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlGrabar.Location = New System.Drawing.Point(0, 161)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(112, 45)
            Me.pnlGrabar.TabIndex = 17
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnGrabar.Location = New System.Drawing.Point(7, 3)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(97, 40)
            Me.btnGrabar.TabIndex = 15
            Me.btnGrabar.Text = "&Grabar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlSalir.Location = New System.Drawing.Point(0, 206)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(112, 45)
            Me.pnlSalir.TabIndex = 18
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(7, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(97, 40)
            Me.btnSalir.TabIndex = 44
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'UscVistaHuella1
            '
            Me.UscVistaHuella1._IDPenal = CType(-1, Short)
            Me.UscVistaHuella1._IDRegion = CType(-1, Short)
            Me.UscVistaHuella1._IDVisitante = -1
            Me.UscVistaHuella1.Location = New System.Drawing.Point(500, 16)
            Me.UscVistaHuella1.Name = "UscVistaHuella1"
            Me.UscVistaHuella1.Size = New System.Drawing.Size(713, 248)
            Me.UscVistaHuella1.TabIndex = 87
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tp_visita)
            Me.TabControl1.Controls.Add(Me.tp_sancion2)
            Me.TabControl1.Controls.Add(Me.tp_restriccion)
            Me.TabControl1.Controls.Add(Me.tp_Autorizacion)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 307)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1273, 303)
            Me.TabControl1.TabIndex = 90
            Me.TabControl1.TabStop = False
            '
            'tp_visita
            '
            Me.tp_visita.Controls.Add(Me.UscMovimientosVisitas1)
            Me.tp_visita.Location = New System.Drawing.Point(4, 22)
            Me.tp_visita.Name = "tp_visita"
            Me.tp_visita.Size = New System.Drawing.Size(1265, 277)
            Me.tp_visita.TabIndex = 2
            Me.tp_visita.Text = "Visitas"
            Me.tp_visita.UseVisualStyleBackColor = True
            '
            'UscMovimientosVisitas1
            '
            Me.UscMovimientosVisitas1._IDInternoPJ = -1
            Me.UscMovimientosVisitas1._InternoID = -1
            Me.UscMovimientosVisitas1._PenalID = -1
            Me.UscMovimientosVisitas1._RegionID = -1
            Me.UscMovimientosVisitas1._TipoBusqueda = APPControls.Visita.uscMovimientosVisitas.enmTipo.Ninguno
            Me.UscMovimientosVisitas1._VisibleCountInterno = False
            Me.UscMovimientosVisitas1._VisibleCountVisitante = False
            Me.UscMovimientosVisitas1._VisiblePanelCount = False
            Me.UscMovimientosVisitas1._VisiblePanelFiltro = False
            Me.UscMovimientosVisitas1._VisiblePanelFiltroAnio = False
            Me.UscMovimientosVisitas1._VisitanteID = -1
            Me.UscMovimientosVisitas1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscMovimientosVisitas1.Location = New System.Drawing.Point(0, 0)
            Me.UscMovimientosVisitas1.Name = "UscMovimientosVisitas1"
            Me.UscMovimientosVisitas1.Size = New System.Drawing.Size(1265, 277)
            Me.UscMovimientosVisitas1.TabIndex = 0
            '
            'tp_sancion2
            '
            Me.tp_sancion2.Controls.Add(Me.UscSancionv21)
            Me.tp_sancion2.Location = New System.Drawing.Point(4, 22)
            Me.tp_sancion2.Name = "tp_sancion2"
            Me.tp_sancion2.Size = New System.Drawing.Size(1265, 277)
            Me.tp_sancion2.TabIndex = 5
            Me.tp_sancion2.Text = "Sancion"
            Me.tp_sancion2.UseVisualStyleBackColor = True
            '
            'UscSancionv21
            '
            Me.UscSancionv21._PenalID = -1
            Me.UscSancionv21._RegionID = -1
            Me.UscSancionv21._VisibleGrabar = False
            Me.UscSancionv21._VisiblePanelBotones = False
            Me.UscSancionv21._VisitanteID = -1
            Me.UscSancionv21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscSancionv21.Location = New System.Drawing.Point(0, 0)
            Me.UscSancionv21.Name = "UscSancionv21"
            Me.UscSancionv21.Size = New System.Drawing.Size(1265, 277)
            Me.UscSancionv21.TabIndex = 0
            '
            'tp_restriccion
            '
            Me.tp_restriccion.Controls.Add(Me.UscVisitanteRestriccion1)
            Me.tp_restriccion.Location = New System.Drawing.Point(4, 22)
            Me.tp_restriccion.Name = "tp_restriccion"
            Me.tp_restriccion.Size = New System.Drawing.Size(1265, 277)
            Me.tp_restriccion.TabIndex = 0
            Me.tp_restriccion.Text = "Restriccion"
            '
            'UscVisitanteRestriccion1
            '
            Me.UscVisitanteRestriccion1._PenalID = -1
            Me.UscVisitanteRestriccion1._RegionID = -1
            Me.UscVisitanteRestriccion1._VisibleGrabar = False
            Me.UscVisitanteRestriccion1._VisitanteID = -1
            Me.UscVisitanteRestriccion1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscVisitanteRestriccion1.Location = New System.Drawing.Point(0, 0)
            Me.UscVisitanteRestriccion1.Name = "UscVisitanteRestriccion1"
            Me.UscVisitanteRestriccion1.Size = New System.Drawing.Size(1265, 277)
            Me.UscVisitanteRestriccion1.TabIndex = 0
            '
            'tp_Autorizacion
            '
            Me.tp_Autorizacion.Controls.Add(Me.UscAutorizacion1)
            Me.tp_Autorizacion.Location = New System.Drawing.Point(4, 22)
            Me.tp_Autorizacion.Name = "tp_Autorizacion"
            Me.tp_Autorizacion.Size = New System.Drawing.Size(1265, 277)
            Me.tp_Autorizacion.TabIndex = 4
            Me.tp_Autorizacion.Text = "Autorizacion"
            Me.tp_Autorizacion.UseVisualStyleBackColor = True
            '
            'UscAutorizacion1
            '
            Me.UscAutorizacion1._AutorizavionVista = Type.Enumeracion.Visita.AutorizacionVista.Interno
            Me.UscAutorizacion1._InternoID = -1
            Me.UscAutorizacion1._VisibleBotonAdd = False
            Me.UscAutorizacion1._visibleCabecera = False
            Me.UscAutorizacion1._VisitanteID = -1
            Me.UscAutorizacion1.BackColor = System.Drawing.Color.Transparent
            Me.UscAutorizacion1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAutorizacion1.Location = New System.Drawing.Point(0, 0)
            Me.UscAutorizacion1.Name = "UscAutorizacion1"
            Me.UscAutorizacion1.Size = New System.Drawing.Size(1265, 277)
            Me.UscAutorizacion1.TabIndex = 1
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(656, 19)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 4
            Me.Button1.Text = "Buscar"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(248, 19)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(41, 13)
            Me.Label8.TabIndex = 3
            Me.Label8.Text = "Hasta :"
            '
            'UscDateTimePicker3
            '
            Me.UscDateTimePicker3.Location = New System.Drawing.Point(312, 19)
            Me.UscDateTimePicker3.Name = "UscDateTimePicker3"
            Me.UscDateTimePicker3.Size = New System.Drawing.Size(84, 21)
            Me.UscDateTimePicker3.TabIndex = 2
            Me.UscDateTimePicker3.Value = "/  /"
            Me.UscDateTimePicker3.ValueLong = CType(0, Long)
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(56, 19)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(44, 13)
            Me.Label11.TabIndex = 1
            Me.Label11.Text = "Desde :"
            '
            'UscDateTimePicker4
            '
            Me.UscDateTimePicker4.Location = New System.Drawing.Point(115, 19)
            Me.UscDateTimePicker4.Name = "UscDateTimePicker4"
            Me.UscDateTimePicker4.Size = New System.Drawing.Size(84, 21)
            Me.UscDateTimePicker4.TabIndex = 0
            Me.UscDateTimePicker4.Value = "/  /"
            Me.UscDateTimePicker4.ValueLong = CType(0, Long)
            '
            'object_638216b9_92f7_4395_95d3_cc6178ae24ef
            '
            Me.object_638216b9_92f7_4395_95d3_cc6178ae24ef.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_638216b9_92f7_4395_95d3_cc6178ae24ef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_638216b9_92f7_4395_95d3_cc6178ae24ef.DropDownWidth = 81
            Me.object_638216b9_92f7_4395_95d3_cc6178ae24ef.FormattingEnabled = True
            Me.object_638216b9_92f7_4395_95d3_cc6178ae24ef.Location = New System.Drawing.Point(0, 0)
            Me.object_638216b9_92f7_4395_95d3_cc6178ae24ef.Name = "object_638216b9_92f7_4395_95d3_cc6178ae24ef"
            Me.object_638216b9_92f7_4395_95d3_cc6178ae24ef.Size = New System.Drawing.Size(84, 21)
            Me.object_638216b9_92f7_4395_95d3_cc6178ae24ef.TabIndex = 0
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.UscRegionPenalLabel1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1273, 37)
            Me.GroupBox2.TabIndex = 91
            Me.GroupBox2.TabStop = False
            '
            'UscRegionPenalLabel1
            '
            Me.UscRegionPenalLabel1._Penalid = -1
            Me.UscRegionPenalLabel1._PenalNombre = "************"
            Me.UscRegionPenalLabel1._RegionId = -1
            Me.UscRegionPenalLabel1._RegionNombre = "************"
            Me.UscRegionPenalLabel1._WidthRegion = 250
            Me.UscRegionPenalLabel1.BackColor = System.Drawing.Color.Transparent
            Me.UscRegionPenalLabel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscRegionPenalLabel1.Location = New System.Drawing.Point(3, 16)
            Me.UscRegionPenalLabel1.Margin = New System.Windows.Forms.Padding(1)
            Me.UscRegionPenalLabel1.Name = "UscRegionPenalLabel1"
            Me.UscRegionPenalLabel1.Size = New System.Drawing.Size(1267, 18)
            Me.UscRegionPenalLabel1.TabIndex = 0
            Me.UscRegionPenalLabel1.UsuarioID = -1
            Me.UscRegionPenalLabel1.VersionInstalacionFile = 0
            '
            'frmMantenimiento
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1273, 610)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.GroupBox2)
            Me.Name = "frmMantenimiento"
            Me.Text = "Visitantes - Mantenimiento "
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlFotografia.ResumeLayout(False)
            Me.cbbSexo.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.pnlCambioSexo.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tp_visita.ResumeLayout(False)
            Me.tp_sancion2.ResumeLayout(False)
            Me.tp_restriccion.ResumeLayout(False)
            Me.tp_Autorizacion.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaNac As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents UscFoto1 As APPControls.Foto.uscFotografia
        Friend WithEvents cbbSexo As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents tp_restriccion As System.Windows.Forms.TabPage
        Friend WithEvents tp_visita As System.Windows.Forms.TabPage
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents UscDateTimePicker3 As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents UscDateTimePicker4 As Legolas.APPUIComponents.uscDateTimePicker
        'Friend WithEvents UscVisitanteMovimiento1 As APPControls.Visita.uscVisitaMovimiento
        'Friend WithEvents UscVisitantePermiso1 As APPControls.Visita.Visitante.uscPermiso
        Friend WithEvents UscRegionPenalLabel1 As APPControls.uscRegionPenalLabel
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents object_638216b9_92f7_4395_95d3_cc6178ae24ef As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnCapurar As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents UscMovimientosVisitas1 As APPControls.Visita.uscMovimientosVisitas
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents UscVisitanteRestriccion1 As APPControls.Visita.Visitante.uscVisitanteRestriccion
        Friend WithEvents chkOmitirFecha As System.Windows.Forms.CheckBox
        Friend WithEvents tp_Autorizacion As System.Windows.Forms.TabPage
        Friend WithEvents UscAutorizacion1 As APPControls.Visita.uscAutorizacion
        Friend WithEvents pnlFotografia As System.Windows.Forms.Panel
        Friend WithEvents UscVistaHuella1 As APPControls.Visita.Visitante.uscVistaHuella
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents tp_sancion2 As System.Windows.Forms.TabPage
        Friend WithEvents UscSancionv21 As APPControls.Visita.Visitante.uscSancionv2
        Friend WithEvents pnlCambioSexo As Panel
        Friend WithEvents btnCambiarSexo As Button
    End Class
End Namespace