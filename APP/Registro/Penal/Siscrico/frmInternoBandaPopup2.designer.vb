Namespace Registro.Siscrico
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmInternoBandaPopup2
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
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnLoadGrupCrim = New Legolas.APPUIComponents.myButton()
            Me.txtobservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtEstIntegrante = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNomBand = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtTipBand = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbBandaMiembroTipo = New APPControls.uscComboParametrica()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.MyComboBox3 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.MyComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.MyComboBox2 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label11 = New System.Windows.Forms.Label()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbbNroIngresos = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.btnCargarInterno = New Legolas.APPUIComponents.myButton()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtApeNomInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.txtEst = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDocIdent = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtCodInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.uscDocJudCrea = New APPControls.Registro.Documento.uscDocJudicial()
            Me.tpDocNulidad = New System.Windows.Forms.TabPage()
            Me.uscDocJudAnula = New APPControls.Registro.Documento.uscDocJudicial()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.cbbBandaMiembroTipo.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.cbbPenal.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.tpDocNulidad.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.TabControl1)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox3)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.btnCancel)
            Me.gbxFormChildContainer.Controls.Add(Me.btnGrabar)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(602, 583)
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnLoadGrupCrim)
            Me.GroupBox2.Controls.Add(Me.txtobservacion)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.txtEstIntegrante)
            Me.GroupBox2.Controls.Add(Me.txtNomBand)
            Me.GroupBox2.Controls.Add(Me.txtTipBand)
            Me.GroupBox2.Controls.Add(Me.cbbBandaMiembroTipo)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Location = New System.Drawing.Point(8, 109)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(587, 150)
            Me.GroupBox2.TabIndex = 91
            Me.GroupBox2.TabStop = False
            '
            'btnLoadGrupCrim
            '
            Me.btnLoadGrupCrim.Image = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnLoadGrupCrim.Location = New System.Drawing.Point(559, 32)
            Me.btnLoadGrupCrim.Name = "btnLoadGrupCrim"
            Me.btnLoadGrupCrim.Size = New System.Drawing.Size(22, 22)
            Me.btnLoadGrupCrim.TabIndex = 104
            Me.btnLoadGrupCrim.UseVisualStyleBackColor = True
            '
            'txtobservacion
            '
            Me.txtobservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtobservacion._BloquearPaste = False
            Me.txtobservacion._SeleccionarTodo = False
            Me.txtobservacion.Location = New System.Drawing.Point(159, 107)
            Me.txtobservacion.MaxLength = 50
            Me.txtobservacion.Multiline = True
            Me.txtobservacion.Name = "txtobservacion"
            Me.txtobservacion.Size = New System.Drawing.Size(421, 35)
            Me.txtobservacion.TabIndex = 103
            Me.txtobservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtobservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(10, 87)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(94, 13)
            Me.Label12.TabIndex = 102
            Me.Label12.Text = "Estado Integrante:"
            '
            'txtEstIntegrante
            '
            Me.txtEstIntegrante._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstIntegrante._BloquearPaste = True
            Me.txtEstIntegrante._SeleccionarTodo = False
            Me.txtEstIntegrante.Location = New System.Drawing.Point(159, 83)
            Me.txtEstIntegrante.Name = "txtEstIntegrante"
            Me.txtEstIntegrante.ReadOnly = True
            Me.txtEstIntegrante.Size = New System.Drawing.Size(119, 20)
            Me.txtEstIntegrante.TabIndex = 101
            Me.txtEstIntegrante.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtEstIntegrante.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtNomBand
            '
            Me.txtNomBand._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNomBand._BloquearPaste = True
            Me.txtNomBand._SeleccionarTodo = False
            Me.txtNomBand.Location = New System.Drawing.Point(159, 34)
            Me.txtNomBand.Name = "txtNomBand"
            Me.txtNomBand.ReadOnly = True
            Me.txtNomBand.Size = New System.Drawing.Size(421, 20)
            Me.txtNomBand.TabIndex = 70
            Me.txtNomBand.Text = "[SELECCIONE]"
            Me.txtNomBand.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNomBand.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtTipBand
            '
            Me.txtTipBand._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipBand._BloquearPaste = True
            Me.txtTipBand._SeleccionarTodo = False
            Me.txtTipBand.Location = New System.Drawing.Point(159, 10)
            Me.txtTipBand.Name = "txtTipBand"
            Me.txtTipBand.ReadOnly = True
            Me.txtTipBand.Size = New System.Drawing.Size(422, 20)
            Me.txtTipBand.TabIndex = 69
            Me.txtTipBand.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTipBand.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'cbbBandaMiembroTipo
            '
            Me.cbbBandaMiembroTipo._NoIndica = False
            Me.cbbBandaMiembroTipo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbBandaMiembroTipo._Todos = False
            Me.cbbBandaMiembroTipo._TodosMensaje = ""
            Me.cbbBandaMiembroTipo._Visible_Add = False
            Me.cbbBandaMiembroTipo._Visible_Buscar = False
            Me.cbbBandaMiembroTipo._Visible_Eliminar = False
            Me.cbbBandaMiembroTipo.CodigoPadre = -1
            Me.cbbBandaMiembroTipo.ComboTipo = CType(62, Short)
            Me.cbbBandaMiembroTipo.Controls.Add(Me.ComboBox1)
            Me.cbbBandaMiembroTipo.Controls.Add(Me.MyComboBox3)
            Me.cbbBandaMiembroTipo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Mayuscula
            Me.cbbBandaMiembroTipo.DropDownWidth = 325
            Me.cbbBandaMiembroTipo.DropDownWidthAuto = True
            Me.cbbBandaMiembroTipo.ListaIdsParaExcluir = Nothing
            Me.cbbBandaMiembroTipo.Location = New System.Drawing.Point(159, 58)
            Me.cbbBandaMiembroTipo.ModuloTratamiento = False
            Me.cbbBandaMiembroTipo.Name = "cbbBandaMiembroTipo"
            Me.cbbBandaMiembroTipo.Parametro1 = -1
            Me.cbbBandaMiembroTipo.Parametro2 = -1
            Me.cbbBandaMiembroTipo.SelectedIndex = -1
            Me.cbbBandaMiembroTipo.SelectedValue = 0
            Me.cbbBandaMiembroTipo.Size = New System.Drawing.Size(422, 22)
            Me.cbbBandaMiembroTipo.TabIndex = 68
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 325
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(422, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'MyComboBox3
            '
            Me.MyComboBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox3.DropDownWidth = 325
            Me.MyComboBox3.FormattingEnabled = True
            Me.MyComboBox3.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox3.Name = "MyComboBox3"
            Me.MyComboBox3.Size = New System.Drawing.Size(422, 21)
            Me.MyComboBox3.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(10, 107)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(73, 13)
            Me.Label2.TabIndex = 66
            Me.Label2.Text = "Observación :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 37)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(148, 13)
            Me.Label1.TabIndex = 48
            Me.Label1.Text = "Nombre Banda/Organización:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(10, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(135, 13)
            Me.Label3.TabIndex = 17
            Me.Label3.Text = "Tipo Banda/Organización :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(10, 62)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(92, 13)
            Me.Label4.TabIndex = 19
            Me.Label4.Text = "Tipo de Miembro :"
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(499, 541)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 95
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnGrabar.Location = New System.Drawing.Point(401, 541)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(94, 40)
            Me.btnGrabar.TabIndex = 94
            Me.btnGrabar.Text = "&Aceptar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Label10)
            Me.GroupBox3.Controls.Add(Me.cbbPenal)
            Me.GroupBox3.Controls.Add(Me.Label11)
            Me.GroupBox3.Controls.Add(Me.cbbRegion)
            Me.GroupBox3.Location = New System.Drawing.Point(7, -3)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(587, 37)
            Me.GroupBox3.TabIndex = 100
            Me.GroupBox3.TabStop = False
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(6, 17)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(44, 13)
            Me.Label10.TabIndex = 94
            Me.Label10.Text = "Región:"
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
            Me.cbbPenal.Controls.Add(Me.MyComboBox1)
            Me.cbbPenal.Controls.Add(Me.MyComboBox2)
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 238
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(345, 12)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(238, 22)
            Me.cbbPenal.TabIndex = 97
            '
            'MyComboBox1
            '
            Me.MyComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox1.DropDownWidth = 238
            Me.MyComboBox1.FormattingEnabled = True
            Me.MyComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox1.Name = "MyComboBox1"
            Me.MyComboBox1.Size = New System.Drawing.Size(238, 21)
            Me.MyComboBox1.TabIndex = 2
            '
            'MyComboBox2
            '
            Me.MyComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox2.DropDownWidth = 238
            Me.MyComboBox2.FormattingEnabled = True
            Me.MyComboBox2.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox2.Name = "MyComboBox2"
            Me.MyComboBox2.Size = New System.Drawing.Size(238, 21)
            Me.MyComboBox2.TabIndex = 2
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(303, 16)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(37, 13)
            Me.Label11.TabIndex = 94
            Me.Label11.Text = "Penal:"
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
            Me.cbbRegion.DropDownWidth = 178
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(55, 12)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(233, 22)
            Me.cbbRegion.TabIndex = 96
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cbbNroIngresos)
            Me.GroupBox1.Controls.Add(Me.btnCargarInterno)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.txtApeNomInterno)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Controls.Add(Me.txtEst)
            Me.GroupBox1.Controls.Add(Me.txtDocIdent)
            Me.GroupBox1.Controls.Add(Me.txtCodInterno)
            Me.GroupBox1.Location = New System.Drawing.Point(7, 26)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(587, 86)
            Me.GroupBox1.TabIndex = 99
            Me.GroupBox1.TabStop = False
            '
            'cbbNroIngresos
            '
            Me.cbbNroIngresos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbNroIngresos.FormattingEnabled = True
            Me.cbbNroIngresos.Location = New System.Drawing.Point(512, 62)
            Me.cbbNroIngresos.Name = "cbbNroIngresos"
            Me.cbbNroIngresos.Size = New System.Drawing.Size(71, 21)
            Me.cbbNroIngresos.TabIndex = 43
            '
            'btnCargarInterno
            '
            Me.btnCargarInterno.Image = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnCargarInterno.Location = New System.Drawing.Point(257, 12)
            Me.btnCargarInterno.Name = "btnCargarInterno"
            Me.btnCargarInterno.Size = New System.Drawing.Size(22, 22)
            Me.btnCargarInterno.TabIndex = 42
            Me.btnCargarInterno.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(435, 64)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(73, 13)
            Me.Label5.TabIndex = 36
            Me.Label5.Text = "Núm. Ingreso:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(428, 15)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(78, 13)
            Me.Label9.TabIndex = 36
            Me.Label9.Text = "Estado interno:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(10, 66)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(118, 13)
            Me.Label8.TabIndex = 36
            Me.Label8.Text = "Documento Indentidad:"
            '
            'txtApeNomInterno
            '
            Me.txtApeNomInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeNomInterno._BloquearPaste = True
            Me.txtApeNomInterno._SeleccionarTodo = True
            Me.txtApeNomInterno.BackColor = System.Drawing.SystemColors.Control
            Me.txtApeNomInterno.Location = New System.Drawing.Point(159, 38)
            Me.txtApeNomInterno.Name = "txtApeNomInterno"
            Me.txtApeNomInterno.ReadOnly = True
            Me.txtApeNomInterno.Size = New System.Drawing.Size(423, 20)
            Me.txtApeNomInterno.TabIndex = 38
            Me.txtApeNomInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApeNomInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(10, 44)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(108, 13)
            Me.Label7.TabIndex = 34
            Me.Label7.Text = "Apellidos y Nombres :"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(10, 18)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(82, 13)
            Me.Label26.TabIndex = 41
            Me.Label26.Text = "Código Interno :"
            '
            'txtEst
            '
            Me.txtEst._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEst._BloquearPaste = True
            Me.txtEst._SeleccionarTodo = True
            Me.txtEst.BackColor = System.Drawing.SystemColors.Control
            Me.txtEst.Location = New System.Drawing.Point(512, 11)
            Me.txtEst.Name = "txtEst"
            Me.txtEst.ReadOnly = True
            Me.txtEst.Size = New System.Drawing.Size(70, 20)
            Me.txtEst.TabIndex = 37
            Me.txtEst.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtEst.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtDocIdent
            '
            Me.txtDocIdent._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDocIdent._BloquearPaste = True
            Me.txtDocIdent._SeleccionarTodo = True
            Me.txtDocIdent.BackColor = System.Drawing.SystemColors.Control
            Me.txtDocIdent.Location = New System.Drawing.Point(159, 62)
            Me.txtDocIdent.Name = "txtDocIdent"
            Me.txtDocIdent.ReadOnly = True
            Me.txtDocIdent.Size = New System.Drawing.Size(270, 20)
            Me.txtDocIdent.TabIndex = 37
            Me.txtDocIdent.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDocIdent.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtCodInterno
            '
            Me.txtCodInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodInterno._BloquearPaste = False
            Me.txtCodInterno._SeleccionarTodo = True
            Me.txtCodInterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCodInterno.Location = New System.Drawing.Point(159, 13)
            Me.txtCodInterno.Name = "txtCodInterno"
            Me.txtCodInterno.ReadOnly = True
            Me.txtCodInterno.Size = New System.Drawing.Size(98, 20)
            Me.txtCodInterno.TabIndex = 37
            Me.txtCodInterno.Text = "[SELECCIONE]"
            Me.txtCodInterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtCodInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.tpDocNulidad)
            Me.TabControl1.Location = New System.Drawing.Point(8, 262)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(587, 276)
            Me.TabControl1.TabIndex = 102
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.uscDocJudCrea)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(579, 250)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Documento judicial de registro"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'uscDocJudCrea
            '
            Me.uscDocJudCrea._DocumentoJudicialID = -1
            Me.uscDocJudCrea._IngresoID = -1
            Me.uscDocJudCrea._IngresoInpeID = -1
            Me.uscDocJudCrea._InternoID = -1
            Me.uscDocJudCrea._Penal = CType(-1, Short)
            Me.uscDocJudCrea._RegionID = CType(-1, Short)
            Me.uscDocJudCrea._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ninguno
            Me.uscDocJudCrea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscDocJudCrea.Location = New System.Drawing.Point(3, 3)
            Me.uscDocJudCrea.Name = "uscDocJudCrea"
            Me.uscDocJudCrea.Size = New System.Drawing.Size(573, 244)
            Me.uscDocJudCrea.TabIndex = 102
            Me.uscDocJudCrea.TipoAutJudicial = 1
            Me.uscDocJudCrea.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tpDocNulidad
            '
            Me.tpDocNulidad.Controls.Add(Me.uscDocJudAnula)
            Me.tpDocNulidad.Location = New System.Drawing.Point(4, 22)
            Me.tpDocNulidad.Name = "tpDocNulidad"
            Me.tpDocNulidad.Padding = New System.Windows.Forms.Padding(3)
            Me.tpDocNulidad.Size = New System.Drawing.Size(579, 250)
            Me.tpDocNulidad.TabIndex = 1
            Me.tpDocNulidad.Text = "Documento judicial de nulidad"
            Me.tpDocNulidad.UseVisualStyleBackColor = True
            '
            'uscDocJudAnula
            '
            Me.uscDocJudAnula._DocumentoJudicialID = -1
            Me.uscDocJudAnula._IngresoID = -1
            Me.uscDocJudAnula._IngresoInpeID = -1
            Me.uscDocJudAnula._InternoID = -1
            Me.uscDocJudAnula._Penal = CType(-1, Short)
            Me.uscDocJudAnula._RegionID = CType(-1, Short)
            Me.uscDocJudAnula._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ninguno
            Me.uscDocJudAnula.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscDocJudAnula.Location = New System.Drawing.Point(3, 3)
            Me.uscDocJudAnula.Name = "uscDocJudAnula"
            Me.uscDocJudAnula.Size = New System.Drawing.Size(573, 244)
            Me.uscDocJudAnula.TabIndex = 1
            Me.uscDocJudAnula.TipoAutJudicial = 1
            Me.uscDocJudAnula.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'frmInternoBandaPopup2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(602, 583)
            Me.Name = "frmInternoBandaPopup2"
            Me.Text = "Mantenimiento Interno y Grupos Criminales"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.cbbBandaMiembroTipo.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.cbbPenal.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.tpDocNulidad.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents MyComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox2 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnCargarInterno As Legolas.APPUIComponents.myButton
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtApeNomInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents txtEst As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDocIdent As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtCodInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNomBand As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtTipBand As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbBandaMiembroTipo As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox3 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtEstIntegrante As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents txtobservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents uscDocJudCrea As APPControls.Registro.Documento.uscDocJudicial
        Friend WithEvents tpDocNulidad As System.Windows.Forms.TabPage
        Friend WithEvents uscDocJudAnula As APPControls.Registro.Documento.uscDocJudicial
        Friend WithEvents btnLoadGrupCrim As Legolas.APPUIComponents.myButton
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cbbNroIngresos As Legolas.APPUIComponents.MyComboBox
    End Class
End Namespace