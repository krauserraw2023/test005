Namespace Registro.Carceleta.Movimientos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMovimientoConduccionClasificacion
        Inherits Legolas.APPUIComponents.FormPopup

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pnlUserControl = New System.Windows.Forms.Panel()
            Me.pnlOrigenObservacion = New System.Windows.Forms.Panel()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblEtiquetaObservacion = New System.Windows.Forms.Label()
            Me.PnlOrigenDestino = New System.Windows.Forms.Panel()
            Me.lblRegion = New System.Windows.Forms.Label()
            Me.lblPenal = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.grpDocumentoJudicial = New System.Windows.Forms.GroupBox()
            Me.PnlOtraAutoridad = New System.Windows.Forms.Panel()
            Me.txtOtraAutoridadCargo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtOtraAutoridadNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbSala = New APPControls.Busqueda.uscComboSala()
            Me.cbbDistritoJud = New APPControls.uscComboParametrica()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.PnlTipoAutJud = New System.Windows.Forms.Panel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbbTipoAutJud = New APPControls.uscComboParametrica()
            Me.pnlDocumento = New System.Windows.Forms.Panel()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.grpEncabezado = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbMovestado = New System.Windows.Forms.ComboBox()
            Me.nudMinutos = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.nudHora = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.lblMotivoTraslado = New System.Windows.Forms.Label()
            Me.gbReferenciar = New System.Windows.Forms.GroupBox()
            Me.rdbSi = New System.Windows.Forms.RadioButton()
            Me.rdbNo = New System.Windows.Forms.RadioButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnCargarDocumento = New Legolas.APPUIComponents.myButton()
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.dtpFechaMov = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblfecha = New System.Windows.Forms.Label()
            Me.txtMovimientoGrupo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMovimientoTipo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblIngresoSalida = New System.Windows.Forms.Label()
            Me.lblMovTipo = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.pnlUserControl.SuspendLayout()
            Me.pnlOrigenObservacion.SuspendLayout()
            Me.PnlOrigenDestino.SuspendLayout()
            Me.grpDocumentoJudicial.SuspendLayout()
            Me.PnlOtraAutoridad.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.PnlTipoAutJud.SuspendLayout()
            Me.pnlDocumento.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.grpEncabezado.SuspendLayout()
            Me.gbReferenciar.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.pnlUserControl)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(690, 400)
            '
            'pnlUserControl
            '
            Me.pnlUserControl.Controls.Add(Me.pnlOrigenObservacion)
            Me.pnlUserControl.Controls.Add(Me.PnlOrigenDestino)
            Me.pnlUserControl.Controls.Add(Me.grpDocumentoJudicial)
            Me.pnlUserControl.Controls.Add(Me.PnlBotones)
            Me.pnlUserControl.Controls.Add(Me.PnlInferior)
            Me.pnlUserControl.Controls.Add(Me.grpEncabezado)
            Me.pnlUserControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlUserControl.Location = New System.Drawing.Point(0, 0)
            Me.pnlUserControl.Name = "pnlUserControl"
            Me.pnlUserControl.Size = New System.Drawing.Size(690, 400)
            Me.pnlUserControl.TabIndex = 0
            '
            'pnlOrigenObservacion
            '
            Me.pnlOrigenObservacion.Controls.Add(Me.txtObservacion)
            Me.pnlOrigenObservacion.Controls.Add(Me.lblEtiquetaObservacion)
            Me.pnlOrigenObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlOrigenObservacion.Location = New System.Drawing.Point(0, 245)
            Me.pnlOrigenObservacion.Name = "pnlOrigenObservacion"
            Me.pnlOrigenObservacion.Size = New System.Drawing.Size(690, 65)
            Me.pnlOrigenObservacion.TabIndex = 2
            '
            'txtObservacion
            '
            Me.txtObservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = False
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Location = New System.Drawing.Point(0, 20)
            Me.txtObservacion.MaxLength = 2500
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(690, 45)
            Me.txtObservacion.TabIndex = 1
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'lblEtiquetaObservacion
            '
            Me.lblEtiquetaObservacion.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblEtiquetaObservacion.Location = New System.Drawing.Point(0, 0)
            Me.lblEtiquetaObservacion.Name = "lblEtiquetaObservacion"
            Me.lblEtiquetaObservacion.Size = New System.Drawing.Size(690, 20)
            Me.lblEtiquetaObservacion.TabIndex = 0
            Me.lblEtiquetaObservacion.Text = "Observación del Movimiento :"
            Me.lblEtiquetaObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PnlOrigenDestino
            '
            Me.PnlOrigenDestino.Controls.Add(Me.lblRegion)
            Me.PnlOrigenDestino.Controls.Add(Me.lblPenal)
            Me.PnlOrigenDestino.Controls.Add(Me.cbbPenal)
            Me.PnlOrigenDestino.Controls.Add(Me.cbbRegion)
            Me.PnlOrigenDestino.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlOrigenDestino.Location = New System.Drawing.Point(0, 213)
            Me.PnlOrigenDestino.Name = "PnlOrigenDestino"
            Me.PnlOrigenDestino.Size = New System.Drawing.Size(690, 32)
            Me.PnlOrigenDestino.TabIndex = 0
            '
            'lblRegion
            '
            Me.lblRegion.AutoSize = True
            Me.lblRegion.Location = New System.Drawing.Point(15, 9)
            Me.lblRegion.Name = "lblRegion"
            Me.lblRegion.Size = New System.Drawing.Size(44, 13)
            Me.lblRegion.TabIndex = 0
            Me.lblRegion.Text = "Región:"
            '
            'lblPenal
            '
            Me.lblPenal.AutoSize = True
            Me.lblPenal.Location = New System.Drawing.Point(361, 9)
            Me.lblPenal.Name = "lblPenal"
            Me.lblPenal.Size = New System.Drawing.Size(37, 13)
            Me.lblPenal.TabIndex = 2
            Me.lblPenal.Text = "Penal:"
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
            Me.cbbPenal.ComboTipo = CType(0, Short)
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 255
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(426, 5)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(255, 22)
            Me.cbbPenal.TabIndex = 13
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
            Me.cbbRegion.ComboTipo = CType(0, Short)
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 223
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(105, 5)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(245, 22)
            Me.cbbRegion.TabIndex = 12
            '
            'grpDocumentoJudicial
            '
            Me.grpDocumentoJudicial.Controls.Add(Me.PnlOtraAutoridad)
            Me.grpDocumentoJudicial.Controls.Add(Me.PnlAutoridadJudicial)
            Me.grpDocumentoJudicial.Controls.Add(Me.PnlTipoAutJud)
            Me.grpDocumentoJudicial.Controls.Add(Me.pnlDocumento)
            Me.grpDocumentoJudicial.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpDocumentoJudicial.Location = New System.Drawing.Point(0, 85)
            Me.grpDocumentoJudicial.Name = "grpDocumentoJudicial"
            Me.grpDocumentoJudicial.Size = New System.Drawing.Size(690, 128)
            Me.grpDocumentoJudicial.TabIndex = 1
            Me.grpDocumentoJudicial.TabStop = False
            Me.grpDocumentoJudicial.Text = "Documento Judicial :"
            '
            'PnlOtraAutoridad
            '
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadCargo)
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadNombre)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label4)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label5)
            Me.PnlOtraAutoridad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PnlOtraAutoridad.Location = New System.Drawing.Point(3, 129)
            Me.PnlOtraAutoridad.Name = "PnlOtraAutoridad"
            Me.PnlOtraAutoridad.Size = New System.Drawing.Size(684, 0)
            Me.PnlOtraAutoridad.TabIndex = 3
            '
            'txtOtraAutoridadCargo
            '
            Me.txtOtraAutoridadCargo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadCargo._BloquearPaste = False
            Me.txtOtraAutoridadCargo._SeleccionarTodo = False
            Me.txtOtraAutoridadCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadCargo.Location = New System.Drawing.Point(102, 24)
            Me.txtOtraAutoridadCargo.Name = "txtOtraAutoridadCargo"
            Me.txtOtraAutoridadCargo.Size = New System.Drawing.Size(576, 20)
            Me.txtOtraAutoridadCargo.TabIndex = 3
            Me.txtOtraAutoridadCargo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtOtraAutoridadCargo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtOtraAutoridadNombre
            '
            Me.txtOtraAutoridadNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadNombre._BloquearPaste = False
            Me.txtOtraAutoridadNombre._SeleccionarTodo = False
            Me.txtOtraAutoridadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadNombre.Location = New System.Drawing.Point(102, 2)
            Me.txtOtraAutoridadNombre.Name = "txtOtraAutoridadNombre"
            Me.txtOtraAutoridadNombre.Size = New System.Drawing.Size(576, 20)
            Me.txtOtraAutoridadNombre.TabIndex = 1
            Me.txtOtraAutoridadNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtOtraAutoridadNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(4, 6)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(98, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Nombre Autoridad :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(4, 28)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(63, 13)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Cargo Aut. :"
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtJuez)
            Me.PnlAutoridadJudicial.Controls.Add(Me.cbbSala)
            Me.PnlAutoridadJudicial.Controls.Add(Me.cbbDistritoJud)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblDistrito)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label3)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label11)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(3, 78)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(684, 51)
            Me.PnlAutoridadJudicial.TabIndex = 3
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(423, 26)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(255, 20)
            Me.txtSecretario.TabIndex = 6
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Location = New System.Drawing.Point(102, 26)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(245, 20)
            Me.txtJuez.TabIndex = 4
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbSala
            '
            Me.cbbSala._DistritoJudicialID = -1
            Me.cbbSala._SalaJuzgadoID = 0
            Me.cbbSala._SalaJuzgadoID_Seleccionado = -1
            Me.cbbSala.Location = New System.Drawing.Point(423, 3)
            Me.cbbSala.Name = "cbbSala"
            Me.cbbSala.Size = New System.Drawing.Size(255, 21)
            Me.cbbSala.TabIndex = 12
            '
            'cbbDistritoJud
            '
            Me.cbbDistritoJud._NoIndica = False
            Me.cbbDistritoJud._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbDistritoJud._Todos = False
            Me.cbbDistritoJud._TodosMensaje = ""
            Me.cbbDistritoJud._Visible_Add = False
            Me.cbbDistritoJud._Visible_Buscar = False
            Me.cbbDistritoJud._Visible_Eliminar = False
            Me.cbbDistritoJud.CodigoPadre = -1
            Me.cbbDistritoJud.ComboTipo = CType(0, Short)
            Me.cbbDistritoJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDistritoJud.DropDownWidth = 245
            Me.cbbDistritoJud.DropDownWidthAuto = False
            Me.cbbDistritoJud.ListaIdsParaExcluir = Nothing
            Me.cbbDistritoJud.Location = New System.Drawing.Point(102, 3)
            Me.cbbDistritoJud.ModuloTratamiento = False
            Me.cbbDistritoJud.Name = "cbbDistritoJud"
            Me.cbbDistritoJud.Parametro1 = -1
            Me.cbbDistritoJud.Parametro2 = -1
            Me.cbbDistritoJud.SelectedIndex = -1
            Me.cbbDistritoJud.SelectedValue = 0
            Me.cbbDistritoJud.Size = New System.Drawing.Size(245, 22)
            Me.cbbDistritoJud.TabIndex = 13
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(4, 7)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 0
            Me.lblDistrito.Text = "Distrito Judicial :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(4, 31)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(35, 13)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Juez :"
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(355, 7)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 1
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(355, 31)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 13)
            Me.Label11.TabIndex = 5
            Me.Label11.Text = "Secretario :"
            '
            'PnlTipoAutJud
            '
            Me.PnlTipoAutJud.Controls.Add(Me.Label6)
            Me.PnlTipoAutJud.Controls.Add(Me.cbbTipoAutJud)
            Me.PnlTipoAutJud.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlTipoAutJud.Location = New System.Drawing.Point(3, 48)
            Me.PnlTipoAutJud.Name = "PnlTipoAutJud"
            Me.PnlTipoAutJud.Size = New System.Drawing.Size(684, 30)
            Me.PnlTipoAutJud.TabIndex = 2
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(3, 7)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(93, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Tipo de autoridad:"
            '
            'cbbTipoAutJud
            '
            Me.cbbTipoAutJud._NoIndica = False
            Me.cbbTipoAutJud._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoAutJud._Todos = False
            Me.cbbTipoAutJud._TodosMensaje = ""
            Me.cbbTipoAutJud._Visible_Add = False
            Me.cbbTipoAutJud._Visible_Buscar = False
            Me.cbbTipoAutJud._Visible_Eliminar = False
            Me.cbbTipoAutJud.CodigoPadre = -1
            Me.cbbTipoAutJud.ComboTipo = CType(0, Short)
            Me.cbbTipoAutJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoAutJud.DropDownWidth = 245
            Me.cbbTipoAutJud.DropDownWidthAuto = False
            Me.cbbTipoAutJud.ListaIdsParaExcluir = Nothing
            Me.cbbTipoAutJud.Location = New System.Drawing.Point(102, 5)
            Me.cbbTipoAutJud.ModuloTratamiento = False
            Me.cbbTipoAutJud.Name = "cbbTipoAutJud"
            Me.cbbTipoAutJud.Parametro1 = -1
            Me.cbbTipoAutJud.Parametro2 = -1
            Me.cbbTipoAutJud.SelectedIndex = -1
            Me.cbbTipoAutJud.SelectedValue = 0
            Me.cbbTipoAutJud.Size = New System.Drawing.Size(245, 22)
            Me.cbbTipoAutJud.TabIndex = 12
            '
            'pnlDocumento
            '
            Me.pnlDocumento.Controls.Add(Me.Label30)
            Me.pnlDocumento.Controls.Add(Me.dtpDocJudFecha)
            Me.pnlDocumento.Controls.Add(Me.Label12)
            Me.pnlDocumento.Controls.Add(Me.dtpDocJudFecRecep)
            Me.pnlDocumento.Controls.Add(Me.txtNumDocumento)
            Me.pnlDocumento.Controls.Add(Me.Label7)
            Me.pnlDocumento.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDocumento.Location = New System.Drawing.Point(3, 16)
            Me.pnlDocumento.Name = "pnlDocumento"
            Me.pnlDocumento.Size = New System.Drawing.Size(684, 32)
            Me.pnlDocumento.TabIndex = 0
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(4, 11)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(83, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N° Documento :"
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(423, 7)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(514, 11)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(72, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fec. Recep. :"
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(591, 6)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(102, 7)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.Size = New System.Drawing.Size(245, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(355, 11)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(60, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "Fec. Doc. :"
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 310)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(690, 45)
            Me.PnlBotones.TabIndex = 3
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(489, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(94, 40)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(588, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 355)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(690, 45)
            Me.PnlInferior.TabIndex = 101
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(690, 45)
            Me.UscAuditUser1.TabIndex = 0
            '
            'grpEncabezado
            '
            Me.grpEncabezado.Controls.Add(Me.Label2)
            Me.grpEncabezado.Controls.Add(Me.cbbMovestado)
            Me.grpEncabezado.Controls.Add(Me.nudMinutos)
            Me.grpEncabezado.Controls.Add(Me.nudHora)
            Me.grpEncabezado.Controls.Add(Me.lblMotivoTraslado)
            Me.grpEncabezado.Controls.Add(Me.gbReferenciar)
            Me.grpEncabezado.Controls.Add(Me.lblEstado)
            Me.grpEncabezado.Controls.Add(Me.dtpFechaMov)
            Me.grpEncabezado.Controls.Add(Me.lblfecha)
            Me.grpEncabezado.Controls.Add(Me.txtMovimientoGrupo)
            Me.grpEncabezado.Controls.Add(Me.txtMovimientoTipo)
            Me.grpEncabezado.Controls.Add(Me.lblIngresoSalida)
            Me.grpEncabezado.Controls.Add(Me.lblMovTipo)
            Me.grpEncabezado.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpEncabezado.Location = New System.Drawing.Point(0, 0)
            Me.grpEncabezado.Name = "grpEncabezado"
            Me.grpEncabezado.Size = New System.Drawing.Size(690, 85)
            Me.grpEncabezado.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label2.Location = New System.Drawing.Point(0, 82)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(690, 3)
            Me.Label2.TabIndex = 0
            '
            'cbbMovestado
            '
            Me.cbbMovestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMovestado.FormattingEnabled = True
            Me.cbbMovestado.Location = New System.Drawing.Point(357, 32)
            Me.cbbMovestado.Name = "cbbMovestado"
            Me.cbbMovestado.Size = New System.Drawing.Size(184, 21)
            Me.cbbMovestado.TabIndex = 11
            '
            'nudMinutos
            '
            Me.nudMinutos._Formato = "0"
            Me.nudMinutos._Increment = 1
            Me.nudMinutos._Maximum = 100
            Me.nudMinutos._Minimum = 0
            Me.nudMinutos._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudMinutos._Value = 5
            Me.nudMinutos.Location = New System.Drawing.Point(196, 31)
            Me.nudMinutos.Name = "nudMinutos"
            Me.nudMinutos.Size = New System.Drawing.Size(34, 20)
            Me.nudMinutos.TabIndex = 7
            '
            'nudHora
            '
            Me.nudHora._Formato = "0"
            Me.nudHora._Increment = 1
            Me.nudHora._Maximum = 100
            Me.nudHora._Minimum = 0
            Me.nudHora._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudHora._Value = 5
            Me.nudHora.Location = New System.Drawing.Point(156, 31)
            Me.nudHora.Name = "nudHora"
            Me.nudHora.Size = New System.Drawing.Size(34, 20)
            Me.nudHora.TabIndex = 6
            '
            'lblMotivoTraslado
            '
            Me.lblMotivoTraslado.AutoSize = True
            Me.lblMotivoTraslado.Location = New System.Drawing.Point(188, 36)
            Me.lblMotivoTraslado.Name = "lblMotivoTraslado"
            Me.lblMotivoTraslado.Size = New System.Drawing.Size(10, 13)
            Me.lblMotivoTraslado.TabIndex = 11
            Me.lblMotivoTraslado.Text = ":"
            '
            'gbReferenciar
            '
            Me.gbReferenciar.Controls.Add(Me.rdbSi)
            Me.gbReferenciar.Controls.Add(Me.rdbNo)
            Me.gbReferenciar.Controls.Add(Me.Label1)
            Me.gbReferenciar.Controls.Add(Me.btnCargarDocumento)
            Me.gbReferenciar.Location = New System.Drawing.Point(3, 48)
            Me.gbReferenciar.Name = "gbReferenciar"
            Me.gbReferenciar.Size = New System.Drawing.Size(264, 31)
            Me.gbReferenciar.TabIndex = 12
            Me.gbReferenciar.TabStop = False
            '
            'rdbSi
            '
            Me.rdbSi.AutoSize = True
            Me.rdbSi.Checked = True
            Me.rdbSi.Location = New System.Drawing.Point(195, 11)
            Me.rdbSi.Name = "rdbSi"
            Me.rdbSi.Size = New System.Drawing.Size(35, 17)
            Me.rdbSi.TabIndex = 2
            Me.rdbSi.TabStop = True
            Me.rdbSi.Text = "SI"
            Me.rdbSi.UseVisualStyleBackColor = True
            '
            'rdbNo
            '
            Me.rdbNo.AutoSize = True
            Me.rdbNo.Location = New System.Drawing.Point(146, 11)
            Me.rdbNo.Name = "rdbNo"
            Me.rdbNo.Size = New System.Drawing.Size(41, 17)
            Me.rdbNo.TabIndex = 2
            Me.rdbNo.Text = "NO"
            Me.rdbNo.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(5, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(126, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Referenciar Documento :"
            '
            'btnCargarDocumento
            '
            Me.btnCargarDocumento.Image = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnCargarDocumento.Location = New System.Drawing.Point(236, 8)
            Me.btnCargarDocumento.Name = "btnCargarDocumento"
            Me.btnCargarDocumento.Size = New System.Drawing.Size(22, 22)
            Me.btnCargarDocumento.TabIndex = 3
            Me.btnCargarDocumento.UseVisualStyleBackColor = True
            '
            'lblEstado
            '
            Me.lblEstado.AutoSize = True
            Me.lblEstado.Location = New System.Drawing.Point(286, 36)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(43, 13)
            Me.lblEstado.TabIndex = 10
            Me.lblEstado.Text = "Estado:"
            '
            'dtpFechaMov
            '
            Me.dtpFechaMov.Location = New System.Drawing.Point(71, 31)
            Me.dtpFechaMov.Name = "dtpFechaMov"
            Me.dtpFechaMov.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaMov.TabIndex = 5
            Me.dtpFechaMov.Value = "/  /"
            Me.dtpFechaMov.ValueLong = CType(0, Long)
            '
            'lblfecha
            '
            Me.lblfecha.AutoSize = True
            Me.lblfecha.Location = New System.Drawing.Point(5, 35)
            Me.lblfecha.Name = "lblfecha"
            Me.lblfecha.Size = New System.Drawing.Size(63, 13)
            Me.lblfecha.TabIndex = 4
            Me.lblfecha.Text = "Fec. y hora:"
            '
            'txtMovimientoGrupo
            '
            Me.txtMovimientoGrupo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMovimientoGrupo._BloquearPaste = False
            Me.txtMovimientoGrupo._SeleccionarTodo = False
            Me.txtMovimientoGrupo.BackColor = System.Drawing.SystemColors.Control
            Me.txtMovimientoGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMovimientoGrupo.Location = New System.Drawing.Point(70, 5)
            Me.txtMovimientoGrupo.MaxLength = 2
            Me.txtMovimientoGrupo.Name = "txtMovimientoGrupo"
            Me.txtMovimientoGrupo.ReadOnly = True
            Me.txtMovimientoGrupo.Size = New System.Drawing.Size(84, 20)
            Me.txtMovimientoGrupo.TabIndex = 1
            Me.txtMovimientoGrupo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtMovimientoGrupo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtMovimientoTipo
            '
            Me.txtMovimientoTipo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMovimientoTipo._BloquearPaste = False
            Me.txtMovimientoTipo._SeleccionarTodo = False
            Me.txtMovimientoTipo.BackColor = System.Drawing.SystemColors.Control
            Me.txtMovimientoTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMovimientoTipo.Location = New System.Drawing.Point(357, 5)
            Me.txtMovimientoTipo.MaxLength = 2
            Me.txtMovimientoTipo.Name = "txtMovimientoTipo"
            Me.txtMovimientoTipo.ReadOnly = True
            Me.txtMovimientoTipo.Size = New System.Drawing.Size(184, 20)
            Me.txtMovimientoTipo.TabIndex = 3
            Me.txtMovimientoTipo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtMovimientoTipo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblIngresoSalida
            '
            Me.lblIngresoSalida.AutoSize = True
            Me.lblIngresoSalida.Location = New System.Drawing.Point(5, 7)
            Me.lblIngresoSalida.Name = "lblIngresoSalida"
            Me.lblIngresoSalida.Size = New System.Drawing.Size(31, 13)
            Me.lblIngresoSalida.TabIndex = 0
            Me.lblIngresoSalida.Text = "Tipo:"
            '
            'lblMovTipo
            '
            Me.lblMovTipo.AutoSize = True
            Me.lblMovTipo.Location = New System.Drawing.Point(286, 7)
            Me.lblMovTipo.Name = "lblMovTipo"
            Me.lblMovTipo.Size = New System.Drawing.Size(64, 13)
            Me.lblMovTipo.TabIndex = 2
            Me.lblMovTipo.Text = "Movimiento:"
            '
            'frmMovimientoConduccionClasificacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(690, 400)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMovimientoConduccionClasificacion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Conducción por Clasificacion"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.pnlUserControl.ResumeLayout(False)
            Me.pnlOrigenObservacion.ResumeLayout(False)
            Me.pnlOrigenObservacion.PerformLayout()
            Me.PnlOrigenDestino.ResumeLayout(False)
            Me.PnlOrigenDestino.PerformLayout()
            Me.grpDocumentoJudicial.ResumeLayout(False)
            Me.PnlOtraAutoridad.ResumeLayout(False)
            Me.PnlOtraAutoridad.PerformLayout()
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.PnlTipoAutJud.ResumeLayout(False)
            Me.PnlTipoAutJud.PerformLayout()
            Me.pnlDocumento.ResumeLayout(False)
            Me.pnlDocumento.PerformLayout()
            Me.PnlBotones.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.grpEncabezado.ResumeLayout(False)
            Me.grpEncabezado.PerformLayout()
            Me.gbReferenciar.ResumeLayout(False)
            Me.gbReferenciar.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlUserControl As System.Windows.Forms.Panel
        Friend WithEvents pnlOrigenObservacion As System.Windows.Forms.Panel
        Friend WithEvents lblEtiquetaObservacion As System.Windows.Forms.Label
        Friend WithEvents PnlOrigenDestino As System.Windows.Forms.Panel
        Friend WithEvents lblRegion As System.Windows.Forms.Label
        Friend WithEvents lblPenal As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents grpEncabezado As System.Windows.Forms.Panel
        Friend WithEvents cbbMovestado As System.Windows.Forms.ComboBox
        Friend WithEvents nudMinutos As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents nudHora As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents lblMotivoTraslado As System.Windows.Forms.Label
        Friend WithEvents gbReferenciar As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnCargarDocumento As Legolas.APPUIComponents.myButton
        Friend WithEvents lblEstado As System.Windows.Forms.Label
        Friend WithEvents dtpFechaMov As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblfecha As System.Windows.Forms.Label
        Friend WithEvents txtMovimientoGrupo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMovimientoTipo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblIngresoSalida As System.Windows.Forms.Label
        Friend WithEvents lblMovTipo As System.Windows.Forms.Label
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents rdbSi As System.Windows.Forms.RadioButton
        Friend WithEvents rdbNo As System.Windows.Forms.RadioButton
        Friend WithEvents grpDocumentoJudicial As System.Windows.Forms.GroupBox
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents cbbSala As APPControls.Busqueda.uscComboSala
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents cbbDistritoJud As APPControls.uscComboParametrica
        Friend WithEvents PnlOtraAutoridad As System.Windows.Forms.Panel
        Friend WithEvents txtOtraAutoridadCargo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtOtraAutoridadNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents PnlTipoAutJud As System.Windows.Forms.Panel
        Friend WithEvents cbbTipoAutJud As APPControls.uscComboParametrica
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents pnlDocumento As System.Windows.Forms.Panel
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
    End Class
End Namespace

