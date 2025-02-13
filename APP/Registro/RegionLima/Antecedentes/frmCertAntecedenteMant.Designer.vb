Namespace Registro.Main.Antecedentes
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmCertAntecedenteMant
        Inherits Legolas.APPUIComponents.Form

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertAntecedenteMant))
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.pnlImprimir = New System.Windows.Forms.Panel()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnDetalleAJ = New System.Windows.Forms.Button()
            Me.txtNomInt = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApeMatInt = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApePatInt = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNomAsociados = New System.Windows.Forms.Label()
            Me.txtCodRPInterno = New System.Windows.Forms.Label()
            Me.btnBuscarInterno = New System.Windows.Forms.Button()
            Me.chRegistroDirecto = New System.Windows.Forms.CheckBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtEstado = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtObs = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbAutJudicial = New APPControls.Busqueda.uscComboSala()
            Me.cbbDistritoJud = New APPControls.uscComboParametrica()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumSolicitud = New System.Windows.Forms.Label()
            Me.lblFecSolicitud = New System.Windows.Forms.Label()
            Me.cboGlosa = New System.Windows.Forms.ComboBox()
            Me.btnDetalle = New System.Windows.Forms.Button()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.cbbRegion1 = New APPControls.uscComboParametrica()
            Me.cbbMotivoSolicitud = New System.Windows.Forms.ComboBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.lblPenal = New System.Windows.Forms.Label()
            Me.cbbTipoAutJud = New APPControls.uscComboParametrica()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.dtpFechaDocumento = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtEntidadSolicitante = New System.Windows.Forms.TextBox()
            Me.lblRegion = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.pnlJurisdiccion = New System.Windows.Forms.Panel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbbRegionJurisdiccion = New APPControls.uscComboParametrica()
            Me.cbbJurisDet = New System.Windows.Forms.ComboBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.pnlShowAnulados = New System.Windows.Forms.GroupBox()
            Me.chkShowAnulados = New System.Windows.Forms.CheckBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.Panel2.SuspendLayout()
            Me.pnlImprimir.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlJurisdiccion.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlShowAnulados.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.UscAuditUser1)
            Me.Panel2.Controls.Add(Me.pnlImprimir)
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 480)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1001, 47)
            Me.Panel2.TabIndex = 6
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(714, 47)
            Me.UscAuditUser1.TabIndex = 6
            '
            'pnlImprimir
            '
            Me.pnlImprimir.Controls.Add(Me.btnReporte)
            Me.pnlImprimir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlImprimir.Location = New System.Drawing.Point(714, 0)
            Me.pnlImprimir.Name = "pnlImprimir"
            Me.pnlImprimir.Size = New System.Drawing.Size(91, 47)
            Me.pnlImprimir.TabIndex = 2
            '
            'btnReporte
            '
            Me.btnReporte.Enabled = False
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.Location = New System.Drawing.Point(1, 3)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 40)
            Me.btnReporte.TabIndex = 68
            Me.btnReporte.Text = "&Reportes"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnReporte, "Permite ver la vista previa del antecedente solo despues de finalizar el registro" &
        ".")
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnSalir)
            Me.pnlGrabarDatos.Controls.Add(Me.btnOk)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(805, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(196, 47)
            Me.pnlGrabarDatos.TabIndex = 0
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(97, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(95, 40)
            Me.btnSalir.TabIndex = 67
            Me.btnSalir.TabStop = False
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnOk.Location = New System.Drawing.Point(2, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.TabStop = False
            Me.btnOk.Text = "&Grabar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.btnDetalleAJ)
            Me.GroupBox1.Controls.Add(Me.txtNomInt)
            Me.GroupBox1.Controls.Add(Me.txtApeMatInt)
            Me.GroupBox1.Controls.Add(Me.txtApePatInt)
            Me.GroupBox1.Controls.Add(Me.txtNomAsociados)
            Me.GroupBox1.Controls.Add(Me.txtCodRPInterno)
            Me.GroupBox1.Controls.Add(Me.btnBuscarInterno)
            Me.GroupBox1.Controls.Add(Me.chRegistroDirecto)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1001, 116)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Interno"
            '
            'btnDetalleAJ
            '
            Me.btnDetalleAJ.BackColor = System.Drawing.Color.White
            Me.btnDetalleAJ.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.eye_32x32
            Me.btnDetalleAJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDetalleAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDetalleAJ.Location = New System.Drawing.Point(356, 18)
            Me.btnDetalleAJ.Name = "btnDetalleAJ"
            Me.btnDetalleAJ.Size = New System.Drawing.Size(26, 26)
            Me.btnDetalleAJ.TabIndex = 69
            Me.ToolTip1.SetToolTip(Me.btnDetalleAJ, "Vista previa del detalle de antecedente.")
            Me.btnDetalleAJ.UseVisualStyleBackColor = False
            Me.btnDetalleAJ.Visible = False
            '
            'txtNomInt
            '
            Me.txtNomInt._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNomInt._BloquearPaste = False
            Me.txtNomInt._SeleccionarTodo = False
            Me.txtNomInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNomInt.Location = New System.Drawing.Point(84, 91)
            Me.txtNomInt.Name = "txtNomInt"
            Me.txtNomInt.ReadOnly = True
            Me.txtNomInt.Size = New System.Drawing.Size(433, 21)
            Me.txtNomInt.TabIndex = 68
            Me.txtNomInt.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNomInt.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtApeMatInt
            '
            Me.txtApeMatInt._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMatInt._BloquearPaste = False
            Me.txtApeMatInt._SeleccionarTodo = False
            Me.txtApeMatInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApeMatInt.Location = New System.Drawing.Point(84, 69)
            Me.txtApeMatInt.Name = "txtApeMatInt"
            Me.txtApeMatInt.ReadOnly = True
            Me.txtApeMatInt.Size = New System.Drawing.Size(433, 21)
            Me.txtApeMatInt.TabIndex = 67
            Me.txtApeMatInt.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMatInt.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtApePatInt
            '
            Me.txtApePatInt._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePatInt._BloquearPaste = False
            Me.txtApePatInt._SeleccionarTodo = False
            Me.txtApePatInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApePatInt.Location = New System.Drawing.Point(84, 47)
            Me.txtApePatInt.Name = "txtApePatInt"
            Me.txtApePatInt.ReadOnly = True
            Me.txtApePatInt.Size = New System.Drawing.Size(433, 21)
            Me.txtApePatInt.TabIndex = 66
            Me.txtApePatInt.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePatInt.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNomAsociados
            '
            Me.txtNomAsociados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.txtNomAsociados.Location = New System.Drawing.Point(536, 27)
            Me.txtNomAsociados.Name = "txtNomAsociados"
            Me.txtNomAsociados.Size = New System.Drawing.Size(459, 86)
            Me.txtNomAsociados.TabIndex = 65
            '
            'txtCodRPInterno
            '
            Me.txtCodRPInterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCodRPInterno.Location = New System.Drawing.Point(433, 23)
            Me.txtCodRPInterno.Name = "txtCodRPInterno"
            Me.txtCodRPInterno.Size = New System.Drawing.Size(84, 22)
            Me.txtCodRPInterno.TabIndex = 64
            Me.txtCodRPInterno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnBuscarInterno
            '
            Me.btnBuscarInterno.Image = Global.SIPPOPE.My.Resources.Resources.view
            Me.btnBuscarInterno.Location = New System.Drawing.Point(83, 9)
            Me.btnBuscarInterno.Name = "btnBuscarInterno"
            Me.btnBuscarInterno.Size = New System.Drawing.Size(90, 38)
            Me.btnBuscarInterno.TabIndex = 1
            Me.btnBuscarInterno.Text = "&Buscar"
            Me.btnBuscarInterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscarInterno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnBuscarInterno.UseVisualStyleBackColor = True
            '
            'chRegistroDirecto
            '
            Me.chRegistroDirecto.AutoSize = True
            Me.chRegistroDirecto.BackColor = System.Drawing.Color.Silver
            Me.chRegistroDirecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chRegistroDirecto.Location = New System.Drawing.Point(179, 19)
            Me.chRegistroDirecto.Name = "chRegistroDirecto"
            Me.chRegistroDirecto.Size = New System.Drawing.Size(117, 17)
            Me.chRegistroDirecto.TabIndex = 63
            Me.chRegistroDirecto.Text = "Registro manual"
            Me.ToolTip1.SetToolTip(Me.chRegistroDirecto, "Permite registrar los datos directamente")
            Me.chRegistroDirecto.UseVisualStyleBackColor = False
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(536, 11)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(104, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Nombres Asociados:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(386, 28)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(43, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Código:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(16, 95)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(58, 13)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Nombre(s):"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 73)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(78, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Segundo Ape.:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(14, 52)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Primer Ape.:"
            '
            'lblTitulo
            '
            Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(755, 24)
            Me.lblTitulo.TabIndex = 0
            Me.lblTitulo.Text = "CERTIFICADO NO REG. PROC. PENDIENTES CON MANDATO DE DETENCION"
            Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(745, 14)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(43, 13)
            Me.Label7.TabIndex = 1
            Me.Label7.Text = "Estado:"
            '
            'txtEstado
            '
            Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEstado.Location = New System.Drawing.Point(792, 10)
            Me.txtEstado.Name = "txtEstado"
            Me.txtEstado.ReadOnly = True
            Me.txtEstado.Size = New System.Drawing.Size(201, 20)
            Me.txtEstado.TabIndex = 2
            Me.txtEstado.TabStop = False
            Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.Panel5)
            Me.GroupBox2.Controls.Add(Me.Panel1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(0, 216)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1001, 263)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.Panel3)
            Me.Panel5.Controls.Add(Me.Label17)
            Me.Panel5.Controls.Add(Me.PnlAutoridadJudicial)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(3, 134)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(995, 126)
            Me.Panel5.TabIndex = 22
            '
            'Panel3
            '
            Me.Panel3.BackColor = System.Drawing.Color.Transparent
            Me.Panel3.Controls.Add(Me.txtObs)
            Me.Panel3.Controls.Add(Me.Label19)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 46)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(995, 80)
            Me.Panel3.TabIndex = 61
            '
            'txtObs
            '
            Me.txtObs.Dock = System.Windows.Forms.DockStyle.Right
            Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObs.Location = New System.Drawing.Point(112, 0)
            Me.txtObs.MaxLength = 400
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(883, 80)
            Me.txtObs.TabIndex = 1
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(4, 3)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(81, 13)
            Me.Label19.TabIndex = 60
            Me.Label19.Text = "Observaciones:"
            '
            'Label17
            '
            Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(695, 109)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(158, 13)
            Me.Label17.TabIndex = 19
            Me.Label17.Text = "Cantidad máxima de caracteres:"
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.BackColor = System.Drawing.Color.Transparent
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.cbbAutJudicial)
            Me.PnlAutoridadJudicial.Controls.Add(Me.cbbDistritoJud)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblDistrito)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label15)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(0, 0)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(995, 46)
            Me.PnlAutoridadJudicial.TabIndex = 20
            Me.PnlAutoridadJudicial.Visible = False
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Location = New System.Drawing.Point(111, 23)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(384, 20)
            Me.txtSecretario.TabIndex = 13
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbAutJudicial
            '
            Me.cbbAutJudicial._DistritoJudicialID = -1
            Me.cbbAutJudicial._SalaJuzgadoID = 0
            Me.cbbAutJudicial._SalaJuzgadoID_Seleccionado = -1
            Me.cbbAutJudicial.Location = New System.Drawing.Point(597, 1)
            Me.cbbAutJudicial.Name = "cbbAutJudicial"
            Me.cbbAutJudicial.Size = New System.Drawing.Size(392, 21)
            Me.cbbAutJudicial.TabIndex = 1
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
            Me.cbbDistritoJud.ComboTipo = CType(15, Short)
            Me.cbbDistritoJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDistritoJud.DropDownWidth = 325
            Me.cbbDistritoJud.DropDownWidthAuto = False
            Me.cbbDistritoJud.ListaIdsParaExcluir = Nothing
            Me.cbbDistritoJud.Location = New System.Drawing.Point(112, 1)
            Me.cbbDistritoJud.ModuloTratamiento = False
            Me.cbbDistritoJud.Name = "cbbDistritoJud"
            Me.cbbDistritoJud.Parametro1 = -1
            Me.cbbDistritoJud.Parametro2 = -1
            Me.cbbDistritoJud.SelectedIndex = -1
            Me.cbbDistritoJud.SelectedValue = 0
            Me.cbbDistritoJud.Size = New System.Drawing.Size(383, 22)
            Me.cbbDistritoJud.TabIndex = 0
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(4, 5)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 8
            Me.lblDistrito.Text = "Distrito Judicial :"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(4, 27)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(61, 13)
            Me.Label15.TabIndex = 12
            Me.Label15.Text = "Secretario :"
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(528, 5)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(67, 13)
            Me.lblSala.TabIndex = 10
            Me.lblSala.Text = "Aut. Judicial:"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.txtNumDocumento)
            Me.Panel1.Controls.Add(Me.txtNumSolicitud)
            Me.Panel1.Controls.Add(Me.lblFecSolicitud)
            Me.Panel1.Controls.Add(Me.cboGlosa)
            Me.Panel1.Controls.Add(Me.btnDetalle)
            Me.Panel1.Controls.Add(Me.Label12)
            Me.Panel1.Controls.Add(Me.cbbRegion1)
            Me.Panel1.Controls.Add(Me.cbbMotivoSolicitud)
            Me.Panel1.Controls.Add(Me.Label11)
            Me.Panel1.Controls.Add(Me.cbbPenal)
            Me.Panel1.Controls.Add(Me.lblPenal)
            Me.Panel1.Controls.Add(Me.cbbTipoAutJud)
            Me.Panel1.Controls.Add(Me.Label8)
            Me.Panel1.Controls.Add(Me.Label9)
            Me.Panel1.Controls.Add(Me.dtpFechaDocumento)
            Me.Panel1.Controls.Add(Me.Label10)
            Me.Panel1.Controls.Add(Me.Label14)
            Me.Panel1.Controls.Add(Me.Label13)
            Me.Panel1.Controls.Add(Me.txtEntidadSolicitante)
            Me.Panel1.Controls.Add(Me.lblRegion)
            Me.Panel1.Controls.Add(Me.Label18)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(3, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(995, 118)
            Me.Panel1.TabIndex = 19
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(111, 49)
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.Size = New System.Drawing.Size(189, 20)
            Me.txtNumDocumento.TabIndex = 0
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNumSolicitud
            '
            Me.txtNumSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtNumSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumSolicitud.Location = New System.Drawing.Point(112, 12)
            Me.txtNumSolicitud.Name = "txtNumSolicitud"
            Me.txtNumSolicitud.Size = New System.Drawing.Size(128, 21)
            Me.txtNumSolicitud.TabIndex = 61
            '
            'lblFecSolicitud
            '
            Me.lblFecSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFecSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecSolicitud.Location = New System.Drawing.Point(352, 12)
            Me.lblFecSolicitud.Name = "lblFecSolicitud"
            Me.lblFecSolicitud.Size = New System.Drawing.Size(144, 21)
            Me.lblFecSolicitud.TabIndex = 61
            '
            'cboGlosa
            '
            Me.cboGlosa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboGlosa.FormattingEnabled = True
            Me.cboGlosa.Location = New System.Drawing.Point(597, 49)
            Me.cboGlosa.Name = "cboGlosa"
            Me.cboGlosa.Size = New System.Drawing.Size(95, 21)
            Me.cboGlosa.TabIndex = 99
            Me.cboGlosa.TabStop = False
            Me.cboGlosa.Visible = False
            '
            'btnDetalle
            '
            Me.btnDetalle.BackgroundImage = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDetalle.Location = New System.Drawing.Point(691, 48)
            Me.btnDetalle.Name = "btnDetalle"
            Me.btnDetalle.Size = New System.Drawing.Size(25, 23)
            Me.btnDetalle.TabIndex = 59
            Me.btnDetalle.TabStop = False
            Me.btnDetalle.UseVisualStyleBackColor = True
            Me.btnDetalle.Visible = False
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(561, 54)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(37, 13)
            Me.Label12.TabIndex = 58
            Me.Label12.Text = "Glosa:"
            Me.Label12.Visible = False
            '
            'cbbRegion1
            '
            Me.cbbRegion1._NoIndica = False
            Me.cbbRegion1._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegion1._Todos = False
            Me.cbbRegion1._TodosMensaje = ""
            Me.cbbRegion1._Visible_Add = False
            Me.cbbRegion1._Visible_Buscar = False
            Me.cbbRegion1._Visible_Eliminar = False
            Me.cbbRegion1.CodigoPadre = -1
            Me.cbbRegion1.ComboTipo = CType(-1, Short)
            Me.cbbRegion1.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion1.DropDownWidth = 217
            Me.cbbRegion1.DropDownWidthAuto = False
            Me.cbbRegion1.ListaIdsParaExcluir = Nothing
            Me.cbbRegion1.Location = New System.Drawing.Point(112, 95)
            Me.cbbRegion1.ModuloTratamiento = False
            Me.cbbRegion1.Name = "cbbRegion1"
            Me.cbbRegion1.Parametro1 = -1
            Me.cbbRegion1.Parametro2 = -1
            Me.cbbRegion1.SelectedIndex = -1
            Me.cbbRegion1.SelectedValue = 0
            Me.cbbRegion1.Size = New System.Drawing.Size(384, 22)
            Me.cbbRegion1.TabIndex = 4
            '
            'cbbMotivoSolicitud
            '
            Me.cbbMotivoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMotivoSolicitud.FormattingEnabled = True
            Me.cbbMotivoSolicitud.Location = New System.Drawing.Point(597, 72)
            Me.cbbMotivoSolicitud.Name = "cbbMotivoSolicitud"
            Me.cbbMotivoSolicitud.Size = New System.Drawing.Size(392, 21)
            Me.cbbMotivoSolicitud.TabIndex = 3
            Me.ToolTip1.SetToolTip(Me.cbbMotivoSolicitud, "Para seleccionar el motivo, primero selecione la entidad solicitante")
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(511, 76)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(83, 13)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Motivo solicitud:"
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
            Me.cbbPenal.Location = New System.Drawing.Point(597, 95)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(392, 22)
            Me.cbbPenal.TabIndex = 5
            '
            'lblPenal
            '
            Me.lblPenal.AutoSize = True
            Me.lblPenal.Location = New System.Drawing.Point(557, 99)
            Me.lblPenal.Name = "lblPenal"
            Me.lblPenal.Size = New System.Drawing.Size(37, 13)
            Me.lblPenal.TabIndex = 2
            Me.lblPenal.Text = "Penal:"
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
            Me.cbbTipoAutJud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbTipoAutJud.ListaIdsParaExcluir = Nothing
            Me.cbbTipoAutJud.Location = New System.Drawing.Point(112, 72)
            Me.cbbTipoAutJud.ModuloTratamiento = False
            Me.cbbTipoAutJud.Name = "cbbTipoAutJud"
            Me.cbbTipoAutJud.Parametro1 = -1
            Me.cbbTipoAutJud.Parametro2 = -1
            Me.cbbTipoAutJud.SelectedIndex = -1
            Me.cbbTipoAutJud.SelectedValue = 0
            Me.cbbTipoAutJud.Size = New System.Drawing.Size(384, 22)
            Me.cbbTipoAutJud.TabIndex = 2
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(30, 16)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(78, 13)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "N° Solicitud:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(248, 15)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(99, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Fecha Solicitud:"
            '
            'dtpFechaDocumento
            '
            Me.dtpFechaDocumento.Location = New System.Drawing.Point(413, 48)
            Me.dtpFechaDocumento.Name = "dtpFechaDocumento"
            Me.dtpFechaDocumento.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaDocumento.TabIndex = 1
            Me.dtpFechaDocumento.Value = "/  /"
            Me.dtpFechaDocumento.ValueLong = CType(0, Long)
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(4, 76)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(96, 13)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Entidad solicitante:"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(314, 52)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(96, 13)
            Me.Label14.TabIndex = 2
            Me.Label14.Text = "Fecha documento:"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(31, 53)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(78, 13)
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "N° documento:"
            '
            'txtEntidadSolicitante
            '
            Me.txtEntidadSolicitante.Location = New System.Drawing.Point(112, 95)
            Me.txtEntidadSolicitante.Name = "txtEntidadSolicitante"
            Me.txtEntidadSolicitante.Size = New System.Drawing.Size(384, 20)
            Me.txtEntidadSolicitante.TabIndex = 16
            Me.txtEntidadSolicitante.TabStop = False
            '
            'lblRegion
            '
            Me.lblRegion.AutoSize = True
            Me.lblRegion.Location = New System.Drawing.Point(4, 98)
            Me.lblRegion.Name = "lblRegion"
            Me.lblRegion.Size = New System.Drawing.Size(104, 13)
            Me.lblRegion.TabIndex = 2
            Me.lblRegion.Text = "Descripción entidad:"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(-8, 33)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(1051, 13)
            Me.Label18.TabIndex = 60
            Me.Label18.Text = resources.GetString("Label18.Text")
            '
            'pnlJurisdiccion
            '
            Me.pnlJurisdiccion.BackColor = System.Drawing.Color.Transparent
            Me.pnlJurisdiccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlJurisdiccion.Controls.Add(Me.Label6)
            Me.pnlJurisdiccion.Controls.Add(Me.cbbRegionJurisdiccion)
            Me.pnlJurisdiccion.Controls.Add(Me.cbbJurisDet)
            Me.pnlJurisdiccion.Controls.Add(Me.Label20)
            Me.pnlJurisdiccion.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlJurisdiccion.Location = New System.Drawing.Point(0, 60)
            Me.pnlJurisdiccion.Name = "pnlJurisdiccion"
            Me.pnlJurisdiccion.Size = New System.Drawing.Size(1001, 40)
            Me.pnlJurisdiccion.TabIndex = 0
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(109, 12)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(41, 13)
            Me.Label6.TabIndex = 5
            Me.Label6.Text = "Región"
            '
            'cbbRegionJurisdiccion
            '
            Me.cbbRegionJurisdiccion._NoIndica = False
            Me.cbbRegionJurisdiccion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegionJurisdiccion._Todos = False
            Me.cbbRegionJurisdiccion._TodosMensaje = ""
            Me.cbbRegionJurisdiccion._Visible_Add = False
            Me.cbbRegionJurisdiccion._Visible_Buscar = False
            Me.cbbRegionJurisdiccion._Visible_Eliminar = False
            Me.cbbRegionJurisdiccion.CodigoPadre = -1
            Me.cbbRegionJurisdiccion.ComboTipo = CType(37, Short)
            Me.cbbRegionJurisdiccion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegionJurisdiccion.DropDownWidth = 178
            Me.cbbRegionJurisdiccion.DropDownWidthAuto = False
            Me.cbbRegionJurisdiccion.Enabled = False
            Me.cbbRegionJurisdiccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegionJurisdiccion.ListaIdsParaExcluir = Nothing
            Me.cbbRegionJurisdiccion.Location = New System.Drawing.Point(154, 8)
            Me.cbbRegionJurisdiccion.ModuloTratamiento = False
            Me.cbbRegionJurisdiccion.Name = "cbbRegionJurisdiccion"
            Me.cbbRegionJurisdiccion.Parametro1 = -1
            Me.cbbRegionJurisdiccion.Parametro2 = -1
            Me.cbbRegionJurisdiccion.SelectedIndex = -1
            Me.cbbRegionJurisdiccion.SelectedValue = 0
            Me.cbbRegionJurisdiccion.Size = New System.Drawing.Size(333, 22)
            Me.cbbRegionJurisdiccion.TabIndex = 0
            '
            'cbbJurisDet
            '
            Me.cbbJurisDet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbJurisDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbJurisDet.FormattingEnabled = True
            Me.cbbJurisDet.Items.AddRange(New Object() {"", "Lima", "Callao", "Lima y Callao"})
            Me.cbbJurisDet.Location = New System.Drawing.Point(496, 8)
            Me.cbbJurisDet.Name = "cbbJurisDet"
            Me.cbbJurisDet.Size = New System.Drawing.Size(499, 23)
            Me.cbbJurisDet.TabIndex = 1
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(20, 12)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(85, 13)
            Me.Label20.TabIndex = 0
            Me.Label20.Text = "JURISDICCION:"
            '
            'Panel4
            '
            Me.Panel4.BackColor = System.Drawing.Color.Transparent
            Me.Panel4.Controls.Add(Me.Label7)
            Me.Panel4.Controls.Add(Me.lblTitulo)
            Me.Panel4.Controls.Add(Me.pnlShowAnulados)
            Me.Panel4.Controls.Add(Me.txtEstado)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(1001, 60)
            Me.Panel4.TabIndex = 10
            '
            'pnlShowAnulados
            '
            Me.pnlShowAnulados.Controls.Add(Me.chkShowAnulados)
            Me.pnlShowAnulados.Location = New System.Drawing.Point(278, 28)
            Me.pnlShowAnulados.Name = "pnlShowAnulados"
            Me.pnlShowAnulados.Size = New System.Drawing.Size(257, 28)
            Me.pnlShowAnulados.TabIndex = 100
            Me.pnlShowAnulados.TabStop = False
            Me.pnlShowAnulados.Visible = False
            '
            'chkShowAnulados
            '
            Me.chkShowAnulados.AutoSize = True
            Me.chkShowAnulados.BackColor = System.Drawing.Color.Transparent
            Me.chkShowAnulados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkShowAnulados.Location = New System.Drawing.Point(39, 8)
            Me.chkShowAnulados.Name = "chkShowAnulados"
            Me.chkShowAnulados.Size = New System.Drawing.Size(193, 19)
            Me.chkShowAnulados.TabIndex = 0
            Me.chkShowAnulados.Text = "Antecedentes con anulaciones"
            Me.chkShowAnulados.UseVisualStyleBackColor = False
            '
            'Panel6
            '
            Me.Panel6.BackColor = System.Drawing.Color.Transparent
            Me.Panel6.Controls.Add(Me.GroupBox1)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Location = New System.Drawing.Point(0, 100)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(1001, 116)
            Me.Panel6.TabIndex = 11
            '
            'frmCertAntecedenteMant
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1001, 527)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.Panel6)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.pnlJurisdiccion)
            Me.Controls.Add(Me.Panel4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmCertAntecedenteMant"
            Me.Text = "Emisión de antecedentes"
            Me.Panel2.ResumeLayout(False)
            Me.pnlImprimir.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlJurisdiccion.ResumeLayout(False)
            Me.pnlJurisdiccion.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.pnlShowAnulados.ResumeLayout(False)
            Me.pnlShowAnulados.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtEstado As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents dtpFechaDocumento As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtEntidadSolicitante As System.Windows.Forms.TextBox
        Friend WithEvents lblRegion As System.Windows.Forms.Label
        Friend WithEvents txtObs As System.Windows.Forms.TextBox
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents cbbAutJudicial As APPControls.Busqueda.uscComboSala
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents cbbDistritoJud As APPControls.uscComboParametrica
        Friend WithEvents cbbTipoAutJud As APPControls.uscComboParametrica
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents cbbMotivoSolicitud As System.Windows.Forms.ComboBox
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents pnlImprimir As System.Windows.Forms.Panel
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents pnlGrabarDatos As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents lblPenal As System.Windows.Forms.Label
        Friend WithEvents cboGlosa As System.Windows.Forms.ComboBox
        Friend WithEvents btnDetalle As System.Windows.Forms.Button
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion1 As APPControls.uscComboParametrica
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents chRegistroDirecto As System.Windows.Forms.CheckBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents pnlJurisdiccion As System.Windows.Forms.Panel
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents cbbJurisDet As System.Windows.Forms.ComboBox
        Friend WithEvents cbbRegionJurisdiccion As APPControls.uscComboParametrica
        Friend WithEvents txtNumSolicitud As System.Windows.Forms.Label
        Friend WithEvents lblFecSolicitud As System.Windows.Forms.Label
        Friend WithEvents btnBuscarInterno As System.Windows.Forms.Button
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtCodRPInterno As System.Windows.Forms.Label
        Friend WithEvents txtNomAsociados As System.Windows.Forms.Label
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents txtApeMatInt As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApePatInt As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNomInt As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents btnDetalleAJ As Button
        Friend WithEvents pnlShowAnulados As GroupBox
        Friend WithEvents chkShowAnulados As CheckBox
    End Class
End Namespace