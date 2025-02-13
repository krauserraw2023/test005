Namespace Registro.Movimientos.Carceleta
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmInternamiento
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.grpMovimiento = New System.Windows.Forms.GroupBox()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblEtiquetaObservacion = New System.Windows.Forms.Label()
            Me.PnlEncabezado = New System.Windows.Forms.Panel()
            Me.cbbMovMotivo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.nudMinutos = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.TextBox1 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox1 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox3 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.nudHora = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.object_360a1154_2066_4230_84c4_54434ae312f8 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbEstado = New System.Windows.Forms.ComboBox()
            Me.txtMovimientoGrupo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMovimientoTipo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.lblIngresoSalida = New System.Windows.Forms.Label()
            Me.dtpFechaMov = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblMovTipo = New System.Windows.Forms.Label()
            Me.lblfecha = New System.Windows.Forms.Label()
            Me.lblSubmotivo = New System.Windows.Forms.Label()
            Me.lblMotivoTraslado = New System.Windows.Forms.Label()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.grpDocumentoJudicial = New System.Windows.Forms.GroupBox()
            Me.UscDelito1 = New APPControls.Registro.Documento.uscDelito()
            Me.UscMovExpediente1 = New APPControls.Registro.Movimiento.Carceleta.uscMovExpedienteCarceleta()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.grpMovimiento.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.PnlEncabezado.SuspendLayout()
            Me.nudMinutos.SuspendLayout()
            Me.nudHora.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.grpDocumentoJudicial.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grpDocumentoJudicial)
            Me.gbxFormChildContainer.Controls.Add(Me.grpMovimiento)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(682, 478)
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
            'grpMovimiento
            '
            Me.grpMovimiento.Controls.Add(Me.txtObservacion)
            Me.grpMovimiento.Controls.Add(Me.Panel1)
            Me.grpMovimiento.Controls.Add(Me.PnlEncabezado)
            Me.grpMovimiento.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpMovimiento.Location = New System.Drawing.Point(0, 0)
            Me.grpMovimiento.Name = "grpMovimiento"
            Me.grpMovimiento.Size = New System.Drawing.Size(682, 176)
            Me.grpMovimiento.TabIndex = 0
            Me.grpMovimiento.TabStop = False
            Me.grpMovimiento.Text = "Movimiento"
            '
            'txtObservacion
            '
            Me.txtObservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = False
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(110, 78)
            Me.txtObservacion.MaxLength = 2500
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(569, 95)
            Me.txtObservacion.TabIndex = 7
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.lblEtiquetaObservacion)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel1.Location = New System.Drawing.Point(3, 78)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(107, 95)
            Me.Panel1.TabIndex = 6
            '
            'lblEtiquetaObservacion
            '
            Me.lblEtiquetaObservacion.AutoSize = True
            Me.lblEtiquetaObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiquetaObservacion.Location = New System.Drawing.Point(5, 6)
            Me.lblEtiquetaObservacion.Name = "lblEtiquetaObservacion"
            Me.lblEtiquetaObservacion.Size = New System.Drawing.Size(70, 26)
            Me.lblEtiquetaObservacion.TabIndex = 0
            Me.lblEtiquetaObservacion.Text = "Observación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Movimiento :"
            '
            'PnlEncabezado
            '
            Me.PnlEncabezado.Controls.Add(Me.cbbMovMotivo)
            Me.PnlEncabezado.Controls.Add(Me.nudMinutos)
            Me.PnlEncabezado.Controls.Add(Me.nudHora)
            Me.PnlEncabezado.Controls.Add(Me.Label1)
            Me.PnlEncabezado.Controls.Add(Me.cbbEstado)
            Me.PnlEncabezado.Controls.Add(Me.txtMovimientoGrupo)
            Me.PnlEncabezado.Controls.Add(Me.txtMovimientoTipo)
            Me.PnlEncabezado.Controls.Add(Me.lblEstado)
            Me.PnlEncabezado.Controls.Add(Me.lblIngresoSalida)
            Me.PnlEncabezado.Controls.Add(Me.dtpFechaMov)
            Me.PnlEncabezado.Controls.Add(Me.lblMovTipo)
            Me.PnlEncabezado.Controls.Add(Me.lblfecha)
            Me.PnlEncabezado.Controls.Add(Me.lblSubmotivo)
            Me.PnlEncabezado.Controls.Add(Me.lblMotivoTraslado)
            Me.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlEncabezado.Location = New System.Drawing.Point(3, 16)
            Me.PnlEncabezado.Name = "PnlEncabezado"
            Me.PnlEncabezado.Size = New System.Drawing.Size(676, 62)
            Me.PnlEncabezado.TabIndex = 4
            '
            'cbbMovMotivo
            '
            Me.cbbMovMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMovMotivo.DropDownWidth = 250
            Me.cbbMovMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbMovMotivo.FormattingEnabled = True
            Me.cbbMovMotivo.Location = New System.Drawing.Point(447, 9)
            Me.cbbMovMotivo.Name = "cbbMovMotivo"
            Me.cbbMovMotivo.Size = New System.Drawing.Size(224, 21)
            Me.cbbMovMotivo.TabIndex = 16
            '
            'nudMinutos
            '
            Me.nudMinutos._Formato = "00"
            Me.nudMinutos._Increment = 1
            Me.nudMinutos._Maximum = 59
            Me.nudMinutos._Minimum = 0
            Me.nudMinutos._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudMinutos._Value = 0
            Me.nudMinutos.Controls.Add(Me.TextBox1)
            Me.nudMinutos.Controls.Add(Me.MyTextBox1)
            Me.nudMinutos.Controls.Add(Me.MyTextBox2)
            Me.nudMinutos.Controls.Add(Me.MyTextBox3)
            Me.nudMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudMinutos.Location = New System.Drawing.Point(175, 32)
            Me.nudMinutos.Name = "nudMinutos"
            Me.nudMinutos.Size = New System.Drawing.Size(35, 20)
            Me.nudMinutos.TabIndex = 10
            '
            'TextBox1
            '
            Me.TextBox1._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.TextBox1._BloquearPaste = False
            Me.TextBox1._SeleccionarTodo = False
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox1.Location = New System.Drawing.Point(2, 3)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(15, 13)
            Me.TextBox1.TabIndex = 0
            Me.TextBox1.Text = "00"
            Me.TextBox1.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.TextBox1.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox1
            '
            Me.MyTextBox1._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox1._BloquearPaste = False
            Me.MyTextBox1._SeleccionarTodo = False
            Me.MyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox1.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox1.Name = "MyTextBox1"
            Me.MyTextBox1.Size = New System.Drawing.Size(14, 13)
            Me.MyTextBox1.TabIndex = 0
            Me.MyTextBox1.Text = "00"
            Me.MyTextBox1.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox1.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox2
            '
            Me.MyTextBox2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox2._BloquearPaste = False
            Me.MyTextBox2._SeleccionarTodo = False
            Me.MyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox2.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox2.Name = "MyTextBox2"
            Me.MyTextBox2.Size = New System.Drawing.Size(14, 13)
            Me.MyTextBox2.TabIndex = 0
            Me.MyTextBox2.Text = "5"
            Me.MyTextBox2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox3
            '
            Me.MyTextBox3._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox3._BloquearPaste = False
            Me.MyTextBox3._SeleccionarTodo = False
            Me.MyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox3.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox3.Name = "MyTextBox3"
            Me.MyTextBox3.Size = New System.Drawing.Size(14, 13)
            Me.MyTextBox3.TabIndex = 0
            Me.MyTextBox3.Text = "5"
            Me.MyTextBox3.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox3.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'nudHora
            '
            Me.nudHora._Formato = "00"
            Me.nudHora._Increment = 1
            Me.nudHora._Maximum = 23
            Me.nudHora._Minimum = 0
            Me.nudHora._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudHora._Value = 8
            Me.nudHora.Controls.Add(Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218)
            Me.nudHora.Controls.Add(Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41)
            Me.nudHora.Controls.Add(Me.object_360a1154_2066_4230_84c4_54434ae312f8)
            Me.nudHora.Controls.Add(Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004)
            Me.nudHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudHora.Location = New System.Drawing.Point(134, 32)
            Me.nudHora.Name = "nudHora"
            Me.nudHora.Size = New System.Drawing.Size(35, 20)
            Me.nudHora.TabIndex = 8
            '
            'object_a58f24ac_f027_4be8_b38d_dc8c35edd218
            '
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218._BloquearPaste = False
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218._SeleccionarTodo = False
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218.Location = New System.Drawing.Point(2, 3)
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218.Name = "object_a58f24ac_f027_4be8_b38d_dc8c35edd218"
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218.Size = New System.Drawing.Size(15, 13)
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218.TabIndex = 0
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218.Text = "08"
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_a58f24ac_f027_4be8_b38d_dc8c35edd218.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41
            '
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41._BloquearPaste = False
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41._SeleccionarTodo = False
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Location = New System.Drawing.Point(2, 3)
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Name = "object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41"
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Size = New System.Drawing.Size(14, 13)
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.TabIndex = 0
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Text = "08"
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'object_360a1154_2066_4230_84c4_54434ae312f8
            '
            Me.object_360a1154_2066_4230_84c4_54434ae312f8._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_360a1154_2066_4230_84c4_54434ae312f8._BloquearPaste = False
            Me.object_360a1154_2066_4230_84c4_54434ae312f8._SeleccionarTodo = False
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Location = New System.Drawing.Point(2, 3)
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Name = "object_360a1154_2066_4230_84c4_54434ae312f8"
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Size = New System.Drawing.Size(14, 13)
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.TabIndex = 0
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Text = "5"
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004
            '
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004._BloquearPaste = False
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004._SeleccionarTodo = False
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Location = New System.Drawing.Point(2, 3)
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Name = "object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004"
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Size = New System.Drawing.Size(14, 13)
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.TabIndex = 0
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Text = "5"
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label1.Location = New System.Drawing.Point(0, 59)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(676, 3)
            Me.Label1.TabIndex = 0
            '
            'cbbEstado
            '
            Me.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbEstado.FormattingEnabled = True
            Me.cbbEstado.Location = New System.Drawing.Point(279, 34)
            Me.cbbEstado.Name = "cbbEstado"
            Me.cbbEstado.Size = New System.Drawing.Size(100, 21)
            Me.cbbEstado.TabIndex = 12
            '
            'txtMovimientoGrupo
            '
            Me.txtMovimientoGrupo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMovimientoGrupo._BloquearPaste = False
            Me.txtMovimientoGrupo._SeleccionarTodo = False
            Me.txtMovimientoGrupo.BackColor = System.Drawing.SystemColors.Control
            Me.txtMovimientoGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMovimientoGrupo.Location = New System.Drawing.Point(49, 9)
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
            Me.txtMovimientoTipo.Location = New System.Drawing.Point(279, 9)
            Me.txtMovimientoTipo.MaxLength = 2
            Me.txtMovimientoTipo.Name = "txtMovimientoTipo"
            Me.txtMovimientoTipo.ReadOnly = True
            Me.txtMovimientoTipo.Size = New System.Drawing.Size(100, 20)
            Me.txtMovimientoTipo.TabIndex = 3
            Me.txtMovimientoTipo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtMovimientoTipo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblEstado
            '
            Me.lblEstado.AutoSize = True
            Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstado.Location = New System.Drawing.Point(214, 38)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(43, 13)
            Me.lblEstado.TabIndex = 11
            Me.lblEstado.Text = "Estado:"
            '
            'lblIngresoSalida
            '
            Me.lblIngresoSalida.AutoSize = True
            Me.lblIngresoSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIngresoSalida.Location = New System.Drawing.Point(6, 11)
            Me.lblIngresoSalida.Name = "lblIngresoSalida"
            Me.lblIngresoSalida.Size = New System.Drawing.Size(31, 13)
            Me.lblIngresoSalida.TabIndex = 0
            Me.lblIngresoSalida.Text = "Tipo:"
            '
            'dtpFechaMov
            '
            Me.dtpFechaMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaMov.Location = New System.Drawing.Point(49, 32)
            Me.dtpFechaMov.Name = "dtpFechaMov"
            Me.dtpFechaMov.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaMov.TabIndex = 7
            Me.dtpFechaMov.Value = "/  /"
            Me.dtpFechaMov.ValueLong = CType(0, Long)
            '
            'lblMovTipo
            '
            Me.lblMovTipo.AutoSize = True
            Me.lblMovTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMovTipo.Location = New System.Drawing.Point(214, 11)
            Me.lblMovTipo.Name = "lblMovTipo"
            Me.lblMovTipo.Size = New System.Drawing.Size(64, 13)
            Me.lblMovTipo.TabIndex = 2
            Me.lblMovTipo.Text = "Movimiento:"
            '
            'lblfecha
            '
            Me.lblfecha.AutoSize = True
            Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblfecha.Location = New System.Drawing.Point(6, 30)
            Me.lblfecha.Name = "lblfecha"
            Me.lblfecha.Size = New System.Drawing.Size(39, 26)
            Me.lblfecha.TabIndex = 6
            Me.lblfecha.Text = "Fec. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y hora:"
            '
            'lblSubmotivo
            '
            Me.lblSubmotivo.AutoSize = True
            Me.lblSubmotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubmotivo.Location = New System.Drawing.Point(385, 13)
            Me.lblSubmotivo.Name = "lblSubmotivo"
            Me.lblSubmotivo.Size = New System.Drawing.Size(62, 13)
            Me.lblSubmotivo.TabIndex = 13
            Me.lblSubmotivo.Text = "Modalidad :"
            '
            'lblMotivoTraslado
            '
            Me.lblMotivoTraslado.AutoSize = True
            Me.lblMotivoTraslado.Location = New System.Drawing.Point(167, 36)
            Me.lblMotivoTraslado.Name = "lblMotivoTraslado"
            Me.lblMotivoTraslado.Size = New System.Drawing.Size(11, 13)
            Me.lblMotivoTraslado.TabIndex = 9
            Me.lblMotivoTraslado.Text = ":"
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlInferior.Location = New System.Drawing.Point(3, 254)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(676, 45)
            Me.PnlInferior.TabIndex = 101
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(476, 45)
            Me.UscAuditUser1.TabIndex = 2
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(476, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(200, 45)
            Me.PnlBotones.TabIndex = 1
            '
            'grpDocumentoJudicial
            '
            Me.grpDocumentoJudicial.Controls.Add(Me.UscDelito1)
            Me.grpDocumentoJudicial.Controls.Add(Me.UscMovExpediente1)
            Me.grpDocumentoJudicial.Controls.Add(Me.PnlInferior)
            Me.grpDocumentoJudicial.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpDocumentoJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpDocumentoJudicial.Location = New System.Drawing.Point(0, 176)
            Me.grpDocumentoJudicial.Name = "grpDocumentoJudicial"
            Me.grpDocumentoJudicial.Size = New System.Drawing.Size(682, 302)
            Me.grpDocumentoJudicial.TabIndex = 1
            Me.grpDocumentoJudicial.TabStop = False
            Me.grpDocumentoJudicial.Text = "Documento Judicial"
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
            Me.UscDelito1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscDelito1.Location = New System.Drawing.Point(3, 123)
            Me.UscDelito1.Name = "UscDelito1"
            Me.UscDelito1.Size = New System.Drawing.Size(676, 131)
            Me.UscDelito1.TabIndex = 1
            '
            'UscMovExpediente1
            '
            Me.UscMovExpediente1._DocumentoJudicialID = -1
            Me.UscMovExpediente1._ExpedienteID = -1
            Me.UscMovExpediente1._GrillaExpId = -1
            Me.UscMovExpediente1._IngresoID = -1
            Me.UscMovExpediente1._InternoID = -1
            Me.UscMovExpediente1._InternoIngresoInpeId = -1
            Me.UscMovExpediente1._ListaExpedienteOKID = Nothing
            Me.UscMovExpediente1._ListaExpedienteTotalID = Nothing
            Me.UscMovExpediente1._ListaExpNoEliminados = Nothing
            Me.UscMovExpediente1._ListaExpOK_IN = Nothing
            Me.UscMovExpediente1._ListaExpOK_OUT = Nothing
            Me.UscMovExpediente1._MovimientoID = -1
            Me.UscMovExpediente1._MovimientoTipoID = -1
            Me.UscMovExpediente1._RetornaOKEliminado = False
            Me.UscMovExpediente1._TipoListado = ""
            Me.UscMovExpediente1._VisibleColumna = False
            Me.UscMovExpediente1._VisibleGrabar = False
            Me.UscMovExpediente1.AutoScroll = True
            Me.UscMovExpediente1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscMovExpediente1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscMovExpediente1.Location = New System.Drawing.Point(3, 16)
            Me.UscMovExpediente1.Name = "UscMovExpediente1"
            Me.UscMovExpediente1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.UscMovExpediente1.Size = New System.Drawing.Size(676, 107)
            Me.UscMovExpediente1.TabIndex = 0
            '
            'frmInternamiento
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(682, 478)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmInternamiento"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Internamiento"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.grpMovimiento.ResumeLayout(False)
            Me.grpMovimiento.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.PnlEncabezado.ResumeLayout(False)
            Me.PnlEncabezado.PerformLayout()
            Me.nudMinutos.ResumeLayout(False)
            Me.nudMinutos.PerformLayout()
            Me.nudHora.ResumeLayout(False)
            Me.nudHora.PerformLayout()
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.grpDocumentoJudicial.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents grpMovimiento As System.Windows.Forms.GroupBox
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents grpDocumentoJudicial As System.Windows.Forms.GroupBox
        Friend WithEvents UscDelito1 As APPControls.Registro.Documento.uscDelito
        Friend WithEvents UscMovExpediente1 As APPControls.Registro.Movimiento.Carceleta.uscMovExpedienteCarceleta
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblEtiquetaObservacion As System.Windows.Forms.Label
        Friend WithEvents PnlEncabezado As System.Windows.Forms.Panel
        Protected WithEvents cbbMovMotivo As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents nudMinutos As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents TextBox1 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox1 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox3 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents nudHora As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents object_a58f24ac_f027_4be8_b38d_dc8c35edd218 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents object_360a1154_2066_4230_84c4_54434ae312f8 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbbEstado As System.Windows.Forms.ComboBox
        Friend WithEvents txtMovimientoGrupo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMovimientoTipo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblEstado As System.Windows.Forms.Label
        Friend WithEvents lblIngresoSalida As System.Windows.Forms.Label
        Friend WithEvents dtpFechaMov As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblMovTipo As System.Windows.Forms.Label
        Friend WithEvents lblfecha As System.Windows.Forms.Label
        Friend WithEvents lblSubmotivo As System.Windows.Forms.Label
        Friend WithEvents lblMotivoTraslado As System.Windows.Forms.Label

    End Class
End Namespace

