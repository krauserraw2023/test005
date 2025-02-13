Namespace Registro.PenalLM.Movimientos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMovimientoLibertadPLM
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
            Me.grpMovimiento = New System.Windows.Forms.GroupBox()
            Me.uscMovDet = New APPControls.Registro.uscMovimientoDetalle()
            Me.btnCargarDocumento = New Legolas.APPUIComponents.myButton()
            Me.gbReferenciar = New System.Windows.Forms.GroupBox()
            Me.rdbSi = New System.Windows.Forms.RadioButton()
            Me.rdbNo = New System.Windows.Forms.RadioButton()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.PnlTipoAutJud = New System.Windows.Forms.Panel()
            Me.cbbDistritoJud = New APPControls.uscComboParametrica()
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblSala = New System.Windows.Forms.Label()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.lblSecretario = New System.Windows.Forms.Label()
            Me.txtOtraAutoridadCargo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblDistritoJudicial = New System.Windows.Forms.Label()
            Me.cbbTipoAutJud = New APPControls.uscComboParametrica()
            Me.lblJuez = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtOtraAutoridadNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.UscDelito1 = New APPControls.Registro.Documento.uscDelito()
            Me.UscMovExpediente1 = New APPControls.Registro.uscMovExpediente()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.grpMovimiento.SuspendLayout()
            Me.gbReferenciar.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.PnlTipoAutJud.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.TabControl1)
            Me.gbxFormChildContainer.Controls.Add(Me.gbReferenciar)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.grpMovimiento)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(663, 449)
            '
            'grpMovimiento
            '
            Me.grpMovimiento.Controls.Add(Me.uscMovDet)
            Me.grpMovimiento.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpMovimiento.Location = New System.Drawing.Point(0, 0)
            Me.grpMovimiento.Name = "grpMovimiento"
            Me.grpMovimiento.Size = New System.Drawing.Size(663, 185)
            Me.grpMovimiento.TabIndex = 0
            Me.grpMovimiento.TabStop = False
            Me.grpMovimiento.Text = "Movimiento"
            '
            'uscMovDet
            '
            Me.uscMovDet._blnNuevo = False
            Me.uscMovDet._blnVisiblecbbMotivo = True
            Me.uscMovDet._blnVisiblelblMotivo = True
            Me.uscMovDet._blnVisibleOrigenDestino = True
            Me.uscMovDet._CargarExpedientes = -1
            Me.uscMovDet._Codigo = 0
            Me.uscMovDet._Documentos_sin_mov = False
            Me.uscMovDet._DocumentoTipoId = -1
            Me.uscMovDet._DocumJudicialD = -1
            Me.uscMovDet._Establecimientomental = ""
            Me.uscMovDet._EstablecimientomentalId = -1
            Me.uscMovDet._EstadoEjecucionMovimientoOriginal = -1
            Me.uscMovDet._FechaMovimiento = CType(0, Long)
            Me.uscMovDet._IngresoID = -1
            Me.uscMovDet._intCondicionGrupo = -1
            Me.uscMovDet._InternoID = -1
            Me.uscMovDet._InternoIngresoInpeId = -1
            Me.uscMovDet._MovimientoTipoID = -1
            Me.uscMovDet._PenalDestinoID = -1
            Me.uscMovDet._PenalID = 0
            Me.uscMovDet._PenalID1 = -1
            Me.uscMovDet._PenalID2 = -1
            Me.uscMovDet._PenalMovID = 0
            Me.uscMovDet._PenalOrigenID = -1
            Me.uscMovDet._RegionDestinoID = -1
            Me.uscMovDet._RegionID = 0
            Me.uscMovDet._RegionMovID = 0
            Me.uscMovDet._RegionOrigenID = -1
            Me.uscMovDet._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.uscMovDet._uscEscritura = False
            Me.uscMovDet.BackColor = System.Drawing.Color.Transparent
            Me.uscMovDet.DocJudicialReferencia_OTHSM = -1
            Me.uscMovDet.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscMovDet.DocumentoRetornoID = -1
            Me.uscMovDet.Enabletcontrol = False
            Me.uscMovDet.Estado_Ejecucion_Ejecutado = -1
            Me.uscMovDet.EstadoAuxID = 0
            Me.uscMovDet.EstadoID = 0
            Me.uscMovDet.estadoMovimientoNombre = "EN DESARROLLO"
            Me.uscMovDet.EstadoTramite = ""
            Me.uscMovDet.EstadoTramiteID = -1
            Me.uscMovDet.FechaInscripcionLibertad = CType(0, Long)
            Me.uscMovDet.Location = New System.Drawing.Point(3, 16)
            Me.uscMovDet.Movimiento_Observacion_Estado_Ejecucion_MD = Nothing
            Me.uscMovDet.MovimientoGrupo = 0
            Me.uscMovDet.MovimientoGrupoNom = ""
            Me.uscMovDet.MovimientoMotivo = 0
            Me.uscMovDet.MovimientoMotivoId = -1
            Me.uscMovDet.MovimientoMotivoIngreso = 0
            Me.uscMovDet.MovimientoMotivoNombre = ""
            Me.uscMovDet.MovimientoTipo = 0
            Me.uscMovDet.Name = "uscMovDet"
            Me.uscMovDet.Observacion = ""
            Me.uscMovDet.OtroLugar = ""
            Me.uscMovDet.Size = New System.Drawing.Size(657, 166)
            Me.uscMovDet.TabIndex = 0
            '
            'btnCargarDocumento
            '
            Me.btnCargarDocumento.Image = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnCargarDocumento.Location = New System.Drawing.Point(239, 7)
            Me.btnCargarDocumento.Name = "btnCargarDocumento"
            Me.btnCargarDocumento.Size = New System.Drawing.Size(22, 22)
            Me.btnCargarDocumento.TabIndex = 7
            Me.btnCargarDocumento.UseVisualStyleBackColor = True
            '
            'gbReferenciar
            '
            Me.gbReferenciar.Controls.Add(Me.rdbSi)
            Me.gbReferenciar.Controls.Add(Me.btnCargarDocumento)
            Me.gbReferenciar.Controls.Add(Me.rdbNo)
            Me.gbReferenciar.Controls.Add(Me.Label3)
            Me.gbReferenciar.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbReferenciar.Location = New System.Drawing.Point(0, 185)
            Me.gbReferenciar.Name = "gbReferenciar"
            Me.gbReferenciar.Size = New System.Drawing.Size(663, 31)
            Me.gbReferenciar.TabIndex = 1
            Me.gbReferenciar.TabStop = False
            '
            'rdbSi
            '
            Me.rdbSi.AutoSize = True
            Me.rdbSi.Checked = True
            Me.rdbSi.Enabled = False
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
            Me.rdbNo.Enabled = False
            Me.rdbNo.Location = New System.Drawing.Point(146, 11)
            Me.rdbNo.Name = "rdbNo"
            Me.rdbNo.Size = New System.Drawing.Size(41, 17)
            Me.rdbNo.TabIndex = 2
            Me.rdbNo.Text = "NO"
            Me.rdbNo.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(12, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(126, 13)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Referenciar Documento :"
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 216)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(663, 191)
            Me.TabControl1.TabIndex = 2
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.PnlInferior)
            Me.TabPage1.Controls.Add(Me.PnlTipoAutJud)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(655, 165)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Datos del documento"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(3, 117)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(649, 45)
            Me.PnlInferior.TabIndex = 3
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(449, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(200, 45)
            Me.PnlBotones.TabIndex = 1
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(3, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(93, 40)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(98, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlTipoAutJud
            '
            Me.PnlTipoAutJud.Controls.Add(Me.cbbDistritoJud)
            Me.PnlTipoAutJud.Controls.Add(Me.txtJuez)
            Me.PnlTipoAutJud.Controls.Add(Me.txtSecretario)
            Me.PnlTipoAutJud.Controls.Add(Me.lblSala)
            Me.PnlTipoAutJud.Controls.Add(Me.UscComboSala1)
            Me.PnlTipoAutJud.Controls.Add(Me.lblSecretario)
            Me.PnlTipoAutJud.Controls.Add(Me.txtOtraAutoridadCargo)
            Me.PnlTipoAutJud.Controls.Add(Me.lblDistritoJudicial)
            Me.PnlTipoAutJud.Controls.Add(Me.cbbTipoAutJud)
            Me.PnlTipoAutJud.Controls.Add(Me.lblJuez)
            Me.PnlTipoAutJud.Controls.Add(Me.Label2)
            Me.PnlTipoAutJud.Controls.Add(Me.Label30)
            Me.PnlTipoAutJud.Controls.Add(Me.Label12)
            Me.PnlTipoAutJud.Controls.Add(Me.txtNumDocumento)
            Me.PnlTipoAutJud.Controls.Add(Me.Label6)
            Me.PnlTipoAutJud.Controls.Add(Me.dtpDocJudFecRecep)
            Me.PnlTipoAutJud.Controls.Add(Me.dtpDocJudFecha)
            Me.PnlTipoAutJud.Controls.Add(Me.txtOtraAutoridadNombre)
            Me.PnlTipoAutJud.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PnlTipoAutJud.Location = New System.Drawing.Point(3, 3)
            Me.PnlTipoAutJud.Name = "PnlTipoAutJud"
            Me.PnlTipoAutJud.Size = New System.Drawing.Size(649, 159)
            Me.PnlTipoAutJud.TabIndex = 0
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
            Me.cbbDistritoJud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbbDistritoJud.CodigoPadre = -1
            Me.cbbDistritoJud.ComboTipo = CType(15, Short)
            Me.cbbDistritoJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDistritoJud.DropDownWidth = 325
            Me.cbbDistritoJud.DropDownWidthAuto = False
            Me.cbbDistritoJud.Enabled = False
            Me.cbbDistritoJud.ListaIdsParaExcluir = Nothing
            Me.cbbDistritoJud.Location = New System.Drawing.Point(98, 60)
            Me.cbbDistritoJud.ModuloTratamiento = False
            Me.cbbDistritoJud.Name = "cbbDistritoJud"
            Me.cbbDistritoJud.Parametro1 = -1
            Me.cbbDistritoJud.Parametro2 = -1
            Me.cbbDistritoJud.SelectedIndex = -1
            Me.cbbDistritoJud.SelectedValue = 0
            Me.cbbDistritoJud.Size = New System.Drawing.Size(222, 22)
            Me.cbbDistritoJud.TabIndex = 0
            Me.cbbDistritoJud.verToolTipItemSeleccionado = False
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtJuez.Location = New System.Drawing.Point(98, 88)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.ReadOnly = True
            Me.txtJuez.Size = New System.Drawing.Size(221, 20)
            Me.txtJuez.TabIndex = 4
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(397, 88)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.ReadOnly = True
            Me.txtSecretario.Size = New System.Drawing.Size(249, 20)
            Me.txtSecretario.TabIndex = 6
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(325, 64)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 1
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'UscComboSala1
            '
            Me.UscComboSala1._DistritoJudicialID = -1
            Me.UscComboSala1._DropDownWidthAuto = False
            Me.UscComboSala1._SalaJuzgadoID = 0
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala1._Todos = False
            Me.UscComboSala1._TodosMensaje = ""
            Me.UscComboSala1._visibleBuscar = True
            Me.UscComboSala1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UscComboSala1.Enabled = False
            Me.UscComboSala1.Location = New System.Drawing.Point(398, 60)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(248, 21)
            Me.UscComboSala1.TabIndex = 2
            '
            'lblSecretario
            '
            Me.lblSecretario.AutoSize = True
            Me.lblSecretario.Location = New System.Drawing.Point(326, 91)
            Me.lblSecretario.Name = "lblSecretario"
            Me.lblSecretario.Size = New System.Drawing.Size(61, 13)
            Me.lblSecretario.TabIndex = 5
            Me.lblSecretario.Text = "Secretario :"
            '
            'txtOtraAutoridadCargo
            '
            Me.txtOtraAutoridadCargo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadCargo._BloquearPaste = False
            Me.txtOtraAutoridadCargo._SeleccionarTodo = False
            Me.txtOtraAutoridadCargo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadCargo.Location = New System.Drawing.Point(98, 88)
            Me.txtOtraAutoridadCargo.Name = "txtOtraAutoridadCargo"
            Me.txtOtraAutoridadCargo.ReadOnly = True
            Me.txtOtraAutoridadCargo.Size = New System.Drawing.Size(548, 20)
            Me.txtOtraAutoridadCargo.TabIndex = 3
            Me.txtOtraAutoridadCargo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtOtraAutoridadCargo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblDistritoJudicial
            '
            Me.lblDistritoJudicial.AutoSize = True
            Me.lblDistritoJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDistritoJudicial.Location = New System.Drawing.Point(1, 63)
            Me.lblDistritoJudicial.Name = "lblDistritoJudicial"
            Me.lblDistritoJudicial.Size = New System.Drawing.Size(95, 13)
            Me.lblDistritoJudicial.TabIndex = 0
            Me.lblDistritoJudicial.Text = "Nombre Autoridad:"
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
            Me.cbbTipoAutJud.ComboTipo = CType(63, Short)
            Me.cbbTipoAutJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoAutJud.DropDownWidth = 325
            Me.cbbTipoAutJud.DropDownWidthAuto = False
            Me.cbbTipoAutJud.Enabled = False
            Me.cbbTipoAutJud.ListaIdsParaExcluir = Nothing
            Me.cbbTipoAutJud.Location = New System.Drawing.Point(98, 32)
            Me.cbbTipoAutJud.ModuloTratamiento = False
            Me.cbbTipoAutJud.Name = "cbbTipoAutJud"
            Me.cbbTipoAutJud.Parametro1 = -1
            Me.cbbTipoAutJud.Parametro2 = -1
            Me.cbbTipoAutJud.SelectedIndex = -1
            Me.cbbTipoAutJud.SelectedValue = 0
            Me.cbbTipoAutJud.Size = New System.Drawing.Size(222, 22)
            Me.cbbTipoAutJud.TabIndex = 7
            Me.cbbTipoAutJud.verToolTipItemSeleccionado = False
            '
            'lblJuez
            '
            Me.lblJuez.AutoSize = True
            Me.lblJuez.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblJuez.Location = New System.Drawing.Point(1, 90)
            Me.lblJuez.Name = "lblJuez"
            Me.lblJuez.Size = New System.Drawing.Size(63, 13)
            Me.lblJuez.TabIndex = 2
            Me.lblJuez.Text = "Cargo Aut. :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(1, 35)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(93, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "Tipo de autoridad:"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(1, 11)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(83, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N° Documento :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(490, 11)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(72, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fec. Recep. :"
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(98, 8)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.ReadOnly = True
            Me.txtNumDocumento.Size = New System.Drawing.Size(222, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(343, 11)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(60, 13)
            Me.Label6.TabIndex = 2
            Me.Label6.Text = "Fec. Doc. :"
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(563, 7)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(404, 7)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'txtOtraAutoridadNombre
            '
            Me.txtOtraAutoridadNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadNombre._BloquearPaste = False
            Me.txtOtraAutoridadNombre._SeleccionarTodo = False
            Me.txtOtraAutoridadNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadNombre.Location = New System.Drawing.Point(98, 61)
            Me.txtOtraAutoridadNombre.Name = "txtOtraAutoridadNombre"
            Me.txtOtraAutoridadNombre.ReadOnly = True
            Me.txtOtraAutoridadNombre.Size = New System.Drawing.Size(548, 20)
            Me.txtOtraAutoridadNombre.TabIndex = 1
            Me.txtOtraAutoridadNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtOtraAutoridadNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.UscDelito1)
            Me.TabPage2.Controls.Add(Me.UscMovExpediente1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(559, 142)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Datos del Expediente"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'UscDelito1
            '
            Me.UscDelito1._ExpedienteID = -1
            Me.UscDelito1._IngresoID = -1
            Me.UscDelito1._IngresoInpeId = -1
            Me.UscDelito1._InternoID = -1
            Me.UscDelito1._TipoDocumentoID = -1
            Me.UscDelito1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscDelito1._TipoMovimineto = -1
            Me.UscDelito1.AutoScroll = True
            Me.UscDelito1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscDelito1.Location = New System.Drawing.Point(3, 92)
            Me.UscDelito1.Name = "UscDelito1"
            Me.UscDelito1.Size = New System.Drawing.Size(553, 47)
            Me.UscDelito1.TabIndex = 47
            '
            'UscMovExpediente1
            '
            Me.UscMovExpediente1._CargarExpedientes = False
            Me.UscMovExpediente1._DocumentoJudicialID = -1
            Me.UscMovExpediente1._ExpedienteID = -1
            Me.UscMovExpediente1._GrillaExpId = -1
            Me.UscMovExpediente1._IngresoID = -1
            Me.UscMovExpediente1._InternoID = -1
            Me.UscMovExpediente1._InternoIngresoInpeId = -1
            Me.UscMovExpediente1._ListaCopy = Nothing
            Me.UscMovExpediente1._ListaExpedienteId = Nothing
            Me.UscMovExpediente1._ListaExpedienteOKID = Nothing
            Me.UscMovExpediente1._ListaExpedienteTotalID = Nothing
            Me.UscMovExpediente1._ListaExpNoEliminados = Nothing
            Me.UscMovExpediente1._ListaExpOK_IN = Nothing
            Me.UscMovExpediente1._ListaExpOK_OUT = Nothing
            Me.UscMovExpediente1._MovimientoID = -1
            Me.UscMovExpediente1._MovimientoTipoID = -1
            Me.UscMovExpediente1._RetornaOKEliminado = False
            Me.UscMovExpediente1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscMovExpediente1._TipoListado = ""
            Me.UscMovExpediente1._VisibleColumna = False
            Me.UscMovExpediente1._VisibleGrabar = False
            Me.UscMovExpediente1.AutoScroll = True
            Me.UscMovExpediente1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscMovExpediente1.GrillaCountExp = 0
            Me.UscMovExpediente1.Location = New System.Drawing.Point(3, 3)
            Me.UscMovExpediente1.Name = "UscMovExpediente1"
            Me.UscMovExpediente1.Size = New System.Drawing.Size(553, 89)
            Me.UscMovExpediente1.TabIndex = 46
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 407)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(663, 42)
            Me.UscAuditUser1.TabIndex = 3
            '
            'frmMovimientoLibertadPLM
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(663, 449)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMovimientoLibertadPLM"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Libertad"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.grpMovimiento.ResumeLayout(False)
            Me.gbReferenciar.ResumeLayout(False)
            Me.gbReferenciar.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.PnlTipoAutJud.ResumeLayout(False)
            Me.PnlTipoAutJud.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grpMovimiento As System.Windows.Forms.GroupBox
        Friend WithEvents uscMovDet As APPControls.Registro.uscMovimientoDetalle
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents btnCargarDocumento As Legolas.APPUIComponents.myButton
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents Label30 As Label
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents Label12 As Label
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents UscDelito1 As APPControls.Registro.Documento.uscDelito
        Friend WithEvents UscMovExpediente1 As APPControls.Registro.uscMovExpediente
        Friend WithEvents gbReferenciar As GroupBox
        Friend WithEvents rdbSi As RadioButton
        Friend WithEvents rdbNo As RadioButton
        Friend WithEvents Label3 As Label
        Friend WithEvents PnlTipoAutJud As Panel
        Friend WithEvents cbbTipoAutJud As APPControls.uscComboParametrica
        Friend WithEvents Label2 As Label
        Friend WithEvents txtOtraAutoridadCargo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtOtraAutoridadNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistritoJudicial As Label
        Friend WithEvents lblJuez As Label
        Friend WithEvents UscComboSala1 As APPControls.Busqueda.uscComboSala
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblSala As Label
        Friend WithEvents lblSecretario As Label
        Friend WithEvents PnlInferior As Panel
        Friend WithEvents PnlBotones As Panel
        Friend WithEvents btnAceptar As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents cbbDistritoJud As APPControls.uscComboParametrica
    End Class
End Namespace

