Namespace Visita.Interno

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMant
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMant))
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.lblEtapa = New System.Windows.Forms.Label()
            Me.txtEtapa = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.chkOmitirFecha = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.chk_estado = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.Label26 = New System.Windows.Forms.Label()
            Me.lblPabellon = New System.Windows.Forms.Label()
            Me.txtCodInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaNac = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.cbbSexo = New APPControls.uscComboParametrica()
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.txtobservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tp_visita = New System.Windows.Forms.TabPage()
            Me.UscMovimientosVisitas1 = New APPControls.Visita.uscMovimientosVisitas()
            Me.tp_Sancion = New System.Windows.Forms.TabPage()
            Me.UscSancion1 = New APPControls.Visita.Interno.uscSancion()
            Me.tpAutorizacion = New System.Windows.Forms.TabPage()
            Me.UscAutorizacion1 = New APPControls.Visita.uscAutorizacion()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.UscRegionPenalLabel1 = New APPControls.uscRegionPenalLabel()
            Me.txtPabellon = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox4.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tp_visita.SuspendLayout()
            Me.tp_Sancion.SuspendLayout()
            Me.tpAutorizacion.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox4.Controls.Add(Me.txtPabellon)
            Me.GroupBox4.Controls.Add(Me.Panel3)
            Me.GroupBox4.Controls.Add(Me.lblEtapa)
            Me.GroupBox4.Controls.Add(Me.txtEtapa)
            Me.GroupBox4.Controls.Add(Me.chkOmitirFecha)
            Me.GroupBox4.Controls.Add(Me.Label7)
            Me.GroupBox4.Controls.Add(Me.Panel2)
            Me.GroupBox4.Controls.Add(Me.chk_estado)
            Me.GroupBox4.Controls.Add(Me.Label26)
            Me.GroupBox4.Controls.Add(Me.lblPabellon)
            Me.GroupBox4.Controls.Add(Me.txtCodInterno)
            Me.GroupBox4.Controls.Add(Me.dtpFechaNac)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.Label11)
            Me.GroupBox4.Controls.Add(Me.txtApePat)
            Me.GroupBox4.Controls.Add(Me.txtNumDoc)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.txtNom)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.txtApeMat)
            Me.GroupBox4.Controls.Add(Me.Label12)
            Me.GroupBox4.Controls.Add(Me.Label13)
            Me.GroupBox4.Controls.Add(Me.cbbSexo)
            Me.GroupBox4.Controls.Add(Me.cbbNacionalidad)
            Me.GroupBox4.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox4.Controls.Add(Me.txtobservacion)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox4.Location = New System.Drawing.Point(0, 37)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(846, 269)
            Me.GroupBox4.TabIndex = 36
            Me.GroupBox4.TabStop = False
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.UscFotografia_2v1)
            Me.Panel3.Location = New System.Drawing.Point(548, 17)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(150, 213)
            Me.Panel3.TabIndex = 71
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = True
            Me.UscFotografia_2v1._EnabledDobleClick = True
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = False
            Me.UscFotografia_2v1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(0, 0)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(150, 213)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 67
            '
            'lblEtapa
            '
            Me.lblEtapa.AutoSize = True
            Me.lblEtapa.Location = New System.Drawing.Point(293, 150)
            Me.lblEtapa.Name = "lblEtapa"
            Me.lblEtapa.Size = New System.Drawing.Size(41, 13)
            Me.lblEtapa.TabIndex = 70
            Me.lblEtapa.Text = "Etapa :"
            '
            'txtEtapa
            '
            Me.txtEtapa._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEtapa._BloquearPaste = False
            Me.txtEtapa._SeleccionarTodo = True
            Me.txtEtapa.Location = New System.Drawing.Point(390, 146)
            Me.txtEtapa.Name = "txtEtapa"
            Me.txtEtapa.ReadOnly = True
            Me.txtEtapa.Size = New System.Drawing.Size(143, 20)
            Me.txtEtapa.TabIndex = 69
            Me.txtEtapa.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtEtapa.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'chkOmitirFecha
            '
            Me.chkOmitirFecha.Location = New System.Drawing.Point(197, 147)
            Me.chkOmitirFecha.Name = "chkOmitirFecha"
            Me.chkOmitirFecha.Size = New System.Drawing.Size(84, 21)
            Me.chkOmitirFecha.TabIndex = 67
            Me.chkOmitirFecha.Text = "Omitir fecha"
            Me.chkOmitirFecha.UseVisualStyleBackColor = True
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(9, 191)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(73, 13)
            Me.Label7.TabIndex = 43
            Me.Label7.Text = "Observacion :"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(731, 16)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(112, 250)
            Me.Panel2.TabIndex = 13
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnSalir)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 151)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(112, 99)
            Me.Panel1.TabIndex = 17
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(7, 51)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(97, 40)
            Me.btnSalir.TabIndex = 44
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'chk_estado
            '
            Me.chk_estado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chk_estado.Checked = True
            Me.chk_estado.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chk_estado.Location = New System.Drawing.Point(548, 244)
            Me.chk_estado.Name = "chk_estado"
            Me.chk_estado.Size = New System.Drawing.Size(150, 21)
            Me.chk_estado.TabIndex = 11
            Me.chk_estado.Text = "Estado (Activo)  :"
            Me.chk_estado.UseVisualStyleBackColor = True
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(9, 17)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(82, 13)
            Me.Label26.TabIndex = 33
            Me.Label26.Text = "Codigo Interno :"
            '
            'lblPabellon
            '
            Me.lblPabellon.AutoSize = True
            Me.lblPabellon.Location = New System.Drawing.Point(293, 123)
            Me.lblPabellon.Name = "lblPabellon"
            Me.lblPabellon.Size = New System.Drawing.Size(54, 13)
            Me.lblPabellon.TabIndex = 39
            Me.lblPabellon.Text = "Pabellon :"
            '
            'txtCodInterno
            '
            Me.txtCodInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodInterno._BloquearPaste = False
            Me.txtCodInterno._SeleccionarTodo = False
            Me.txtCodInterno.Location = New System.Drawing.Point(107, 14)
            Me.txtCodInterno.Name = "txtCodInterno"
            Me.txtCodInterno.ReadOnly = True
            Me.txtCodInterno.Size = New System.Drawing.Size(84, 20)
            Me.txtCodInterno.TabIndex = 1
            Me.txtCodInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dtpFechaNac
            '
            Me.dtpFechaNac.Location = New System.Drawing.Point(107, 146)
            Me.dtpFechaNac.Name = "dtpFechaNac"
            Me.dtpFechaNac.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaNac.TabIndex = 6
            Me.dtpFechaNac.Value = "/  /"
            Me.dtpFechaNac.ValueLong = CType(0, Long)
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(9, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Primer Apellido :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(293, 95)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(75, 13)
            Me.Label11.TabIndex = 10
            Me.Label11.Text = "Nacionalidad :"
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = True
            Me.txtApePat._SeleccionarTodo = False
            Me.txtApePat.Location = New System.Drawing.Point(107, 40)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(169, 20)
            Me.txtApePat.TabIndex = 2
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(390, 66)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(143, 20)
            Me.txtNumDoc.TabIndex = 8
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(9, 73)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(96, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Segundo Apellido :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 99)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Nombres :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(9, 126)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(37, 13)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "Sexo :"
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = True
            Me.txtNom.Location = New System.Drawing.Point(107, 92)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(169, 20)
            Me.txtNom.TabIndex = 4
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(9, 150)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(69, 13)
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "Fecha Nac. :"
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = True
            Me.txtApeMat._SeleccionarTodo = False
            Me.txtApeMat.Location = New System.Drawing.Point(107, 66)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(169, 20)
            Me.txtApeMat.TabIndex = 3
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(293, 43)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(60, 13)
            Me.Label12.TabIndex = 12
            Me.Label12.Text = "Tipo Doc. :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(293, 73)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(76, 13)
            Me.Label13.TabIndex = 13
            Me.Label13.Text = "Numero Doc. :"
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
            Me.cbbSexo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbSexo.DropDownWidth = 143
            Me.cbbSexo.DropDownWidthAuto = False
            Me.cbbSexo.ListaIdsParaExcluir = Nothing
            Me.cbbSexo.Location = New System.Drawing.Point(107, 120)
            Me.cbbSexo.ModuloTratamiento = False
            Me.cbbSexo.Name = "cbbSexo"
            Me.cbbSexo.Parametro1 = -1
            Me.cbbSexo.Parametro2 = -1
            Me.cbbSexo.SelectedIndex = -1
            Me.cbbSexo.SelectedValue = 0
            Me.cbbSexo.Size = New System.Drawing.Size(169, 22)
            Me.cbbSexo.TabIndex = 5
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
            Me.cbbNacionalidad.DropDownWidth = 143
            Me.cbbNacionalidad.DropDownWidthAuto = False
            Me.cbbNacionalidad.ListaIdsParaExcluir = Nothing
            Me.cbbNacionalidad.Location = New System.Drawing.Point(390, 91)
            Me.cbbNacionalidad.ModuloTratamiento = False
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(143, 22)
            Me.cbbNacionalidad.TabIndex = 10
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
            Me.cbbTipoDoc.DropDownWidth = 143
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDoc.Location = New System.Drawing.Point(390, 40)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(143, 22)
            Me.cbbTipoDoc.TabIndex = 7
            '
            'txtobservacion
            '
            Me.txtobservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtobservacion._BloquearPaste = False
            Me.txtobservacion._SeleccionarTodo = False
            Me.txtobservacion.Location = New System.Drawing.Point(107, 188)
            Me.txtobservacion.Multiline = True
            Me.txtobservacion.Name = "txtobservacion"
            Me.txtobservacion.Size = New System.Drawing.Size(426, 66)
            Me.txtobservacion.TabIndex = 12
            Me.txtobservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtobservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tp_visita)
            Me.TabControl1.Controls.Add(Me.tp_Sancion)
            Me.TabControl1.Controls.Add(Me.tpAutorizacion)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 306)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(846, 214)
            Me.TabControl1.TabIndex = 91
            Me.TabControl1.TabStop = False
            '
            'tp_visita
            '
            Me.tp_visita.Controls.Add(Me.UscMovimientosVisitas1)
            Me.tp_visita.Location = New System.Drawing.Point(4, 22)
            Me.tp_visita.Name = "tp_visita"
            Me.tp_visita.Size = New System.Drawing.Size(838, 188)
            Me.tp_visita.TabIndex = 0
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
            Me.UscMovimientosVisitas1._VisiblePanelFiltroAnio = True
            Me.UscMovimientosVisitas1._VisitanteID = -1
            Me.UscMovimientosVisitas1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscMovimientosVisitas1.Location = New System.Drawing.Point(0, 0)
            Me.UscMovimientosVisitas1.Name = "UscMovimientosVisitas1"
            Me.UscMovimientosVisitas1.Size = New System.Drawing.Size(838, 188)
            Me.UscMovimientosVisitas1.TabIndex = 0
            '
            'tp_Sancion
            '
            Me.tp_Sancion.Controls.Add(Me.UscSancion1)
            Me.tp_Sancion.Location = New System.Drawing.Point(4, 22)
            Me.tp_Sancion.Name = "tp_Sancion"
            Me.tp_Sancion.Size = New System.Drawing.Size(838, 188)
            Me.tp_Sancion.TabIndex = 3
            Me.tp_Sancion.Text = "Sanciones"
            Me.tp_Sancion.UseVisualStyleBackColor = True
            '
            'UscSancion1
            '
            Me.UscSancion1._InternoID = -1
            Me.UscSancion1._PenalID = -1
            Me.UscSancion1._RegionID = -1
            Me.UscSancion1._VisibleGrabar = False
            Me.UscSancion1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscSancion1.Location = New System.Drawing.Point(0, 0)
            Me.UscSancion1.Name = "UscSancion1"
            Me.UscSancion1.Size = New System.Drawing.Size(838, 188)
            Me.UscSancion1.TabIndex = 0
            '
            'tpAutorizacion
            '
            Me.tpAutorizacion.Controls.Add(Me.UscAutorizacion1)
            Me.tpAutorizacion.Location = New System.Drawing.Point(4, 22)
            Me.tpAutorizacion.Name = "tpAutorizacion"
            Me.tpAutorizacion.Size = New System.Drawing.Size(838, 188)
            Me.tpAutorizacion.TabIndex = 4
            Me.tpAutorizacion.Text = "Autorizacion"
            Me.tpAutorizacion.UseVisualStyleBackColor = True
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
            Me.UscAutorizacion1.Size = New System.Drawing.Size(838, 188)
            Me.UscAutorizacion1.TabIndex = 0
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.UscRegionPenalLabel1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(846, 37)
            Me.GroupBox2.TabIndex = 92
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
            Me.UscRegionPenalLabel1.Size = New System.Drawing.Size(840, 18)
            Me.UscRegionPenalLabel1.TabIndex = 0
            Me.UscRegionPenalLabel1.UsuarioID = -1
            Me.UscRegionPenalLabel1.VersionInstalacionFile = 0
            '
            'txtPabellon
            '
            Me.txtPabellon._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPabellon._BloquearPaste = False
            Me.txtPabellon._SeleccionarTodo = True
            Me.txtPabellon.Location = New System.Drawing.Point(390, 120)
            Me.txtPabellon.Name = "txtPabellon"
            Me.txtPabellon.ReadOnly = True
            Me.txtPabellon.Size = New System.Drawing.Size(143, 20)
            Me.txtPabellon.TabIndex = 72
            Me.txtPabellon.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPabellon.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'frmMant
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(846, 520)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.GroupBox2)
            Me.Name = "frmMant"
            Me.Text = "Interno - Mantenimiento"
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tp_visita.ResumeLayout(False)
            Me.tp_Sancion.ResumeLayout(False)
            Me.tpAutorizacion.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents lblPabellon As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents txtCodInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpFechaNac As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents cbbSexo As APPControls.uscComboParametrica
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents chk_estado As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtobservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents tp_visita As System.Windows.Forms.TabPage
        Friend WithEvents tp_Sancion As System.Windows.Forms.TabPage
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents UscMovimientosVisitas1 As APPControls.Visita.uscMovimientosVisitas
        Friend WithEvents UscSancion1 As APPControls.Visita.Interno.uscSancion
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents UscRegionPenalLabel1 As APPControls.uscRegionPenalLabel
        Friend WithEvents tpAutorizacion As System.Windows.Forms.TabPage
        Friend WithEvents UscAutorizacion1 As APPControls.Visita.uscAutorizacion
        Friend WithEvents chkOmitirFecha As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents lblEtapa As System.Windows.Forms.Label
        Friend WithEvents txtEtapa As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents txtPabellon As Legolas.APPUIComponents.MyTextBox
    End Class
End Namespace
