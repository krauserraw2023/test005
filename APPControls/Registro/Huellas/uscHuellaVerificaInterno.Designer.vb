<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscHuellaVerificaInterno
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
        Me.dgwGrilla = New System.Windows.Forms.DataGridView()
        Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_est_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UscCapturaUniDactilar1 = New APPControlHuellaVisita.uscCapturaMonoDactilar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbNacional = New System.Windows.Forms.RadioButton()
        Me.rbRegional = New System.Windows.Forms.RadioButton()
        Me.rbPenal = New System.Windows.Forms.RadioButton()
        Me.cbbTipoDoc = New APPControls.uscComboParametrica()
        Me.txtNumDocIdent = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgwGrilla
        '
        Me.dgwGrilla.AllowUserToAddRows = False
        Me.dgwGrilla.AllowUserToDeleteRows = False
        Me.dgwGrilla.AllowUserToResizeRows = False
        Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
        Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_id, Me.col_cod_rp, Me.col_nom, Me.col_ape, Me.col_sex, Me.col_fec_nac, Me.col_reg, Me.col_reg_id, Me.col_pen_id, Me.col_pen, Me.col_est_int, Me.col_est_id})
        Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwGrilla.Location = New System.Drawing.Point(0, 440)
        Me.dgwGrilla.Name = "dgwGrilla"
        Me.dgwGrilla.ReadOnly = True
        Me.dgwGrilla.RowHeadersVisible = False
        Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwGrilla.Size = New System.Drawing.Size(867, 161)
        Me.dgwGrilla.TabIndex = 5
        '
        'col_int_id
        '
        Me.col_int_id.DataPropertyName = "Codigo"
        Me.col_int_id.HeaderText = "InternoId"
        Me.col_int_id.Name = "col_int_id"
        Me.col_int_id.ReadOnly = True
        Me.col_int_id.Visible = False
        '
        'col_cod_rp
        '
        Me.col_cod_rp.DataPropertyName = "CodigoRP"
        Me.col_cod_rp.HeaderText = "CodigoRP"
        Me.col_cod_rp.Name = "col_cod_rp"
        Me.col_cod_rp.ReadOnly = True
        Me.col_cod_rp.Width = 80
        '
        'col_nom
        '
        Me.col_nom.DataPropertyName = "Nombres"
        Me.col_nom.HeaderText = "Nombres"
        Me.col_nom.Name = "col_nom"
        Me.col_nom.ReadOnly = True
        Me.col_nom.Width = 150
        '
        'col_ape
        '
        Me.col_ape.DataPropertyName = "Apellidos"
        Me.col_ape.HeaderText = "Apellidos"
        Me.col_ape.Name = "col_ape"
        Me.col_ape.ReadOnly = True
        Me.col_ape.Width = 150
        '
        'col_sex
        '
        Me.col_sex.DataPropertyName = "SexoNombre"
        Me.col_sex.HeaderText = "Sexo"
        Me.col_sex.Name = "col_sex"
        Me.col_sex.ReadOnly = True
        Me.col_sex.Width = 50
        '
        'col_fec_nac
        '
        Me.col_fec_nac.DataPropertyName = "FechaNacimientoString"
        Me.col_fec_nac.HeaderText = "Fecha Nac."
        Me.col_fec_nac.Name = "col_fec_nac"
        Me.col_fec_nac.ReadOnly = True
        '
        'col_reg
        '
        Me.col_reg.DataPropertyName = "RegionNombre"
        Me.col_reg.HeaderText = "Región"
        Me.col_reg.Name = "col_reg"
        Me.col_reg.ReadOnly = True
        '
        'col_reg_id
        '
        Me.col_reg_id.DataPropertyName = "RegionId"
        Me.col_reg_id.HeaderText = "RegionId"
        Me.col_reg_id.Name = "col_reg_id"
        Me.col_reg_id.ReadOnly = True
        Me.col_reg_id.Visible = False
        '
        'col_pen_id
        '
        Me.col_pen_id.DataPropertyName = "PenalId"
        Me.col_pen_id.HeaderText = "PenalId"
        Me.col_pen_id.Name = "col_pen_id"
        Me.col_pen_id.ReadOnly = True
        Me.col_pen_id.Visible = False
        '
        'col_pen
        '
        Me.col_pen.DataPropertyName = "PenalNombre"
        Me.col_pen.HeaderText = "Penal"
        Me.col_pen.Name = "col_pen"
        Me.col_pen.ReadOnly = True
        '
        'col_est_int
        '
        Me.col_est_int.DataPropertyName = "EstadoNombre"
        Me.col_est_int.HeaderText = "Estado"
        Me.col_est_int.Name = "col_est_int"
        Me.col_est_int.ReadOnly = True
        Me.col_est_int.Width = 65
        '
        'col_est_id
        '
        Me.col_est_id.DataPropertyName = "EstadoId"
        Me.col_est_id.HeaderText = "EstadoId"
        Me.col_est_id.Name = "col_est_id"
        Me.col_est_id.ReadOnly = True
        Me.col_est_id.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.UscCapturaUniDactilar1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(867, 387)
        Me.Panel2.TabIndex = 7
        '
        'UscCapturaUniDactilar1
        '
        Me.UscCapturaUniDactilar1.BackColor = System.Drawing.Color.Transparent
        Me.UscCapturaUniDactilar1.Location = New System.Drawing.Point(2, 0)
        Me.UscCapturaUniDactilar1.Name = "UscCapturaUniDactilar1"
        Me.UscCapturaUniDactilar1.Size = New System.Drawing.Size(867, 385)
        Me.UscCapturaUniDactilar1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResultado)
        Me.GroupBox1.Controls.Add(Me.cbbTipoDoc)
        Me.GroupBox1.Controls.Add(Me.txtNumDocIdent)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnVerificar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 387)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 53)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Verificación biométrica"
        '
        'lblResultado
        '
        Me.lblResultado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultado.Location = New System.Drawing.Point(547, 22)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(181, 19)
        Me.lblResultado.TabIndex = 19
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbNacional)
        Me.GroupBox2.Controls.Add(Me.rbRegional)
        Me.GroupBox2.Controls.Add(Me.rbPenal)
        Me.GroupBox2.Location = New System.Drawing.Point(307, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 37)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ambito de verificación"
        Me.GroupBox2.Visible = False
        '
        'rbNacional
        '
        Me.rbNacional.AutoSize = True
        Me.rbNacional.Enabled = False
        Me.rbNacional.Location = New System.Drawing.Point(22, 17)
        Me.rbNacional.Name = "rbNacional"
        Me.rbNacional.Size = New System.Drawing.Size(67, 17)
        Me.rbNacional.TabIndex = 2
        Me.rbNacional.Text = "Nacional"
        Me.rbNacional.UseVisualStyleBackColor = True
        '
        'rbRegional
        '
        Me.rbRegional.AutoSize = True
        Me.rbRegional.Enabled = False
        Me.rbRegional.Location = New System.Drawing.Point(107, 17)
        Me.rbRegional.Name = "rbRegional"
        Me.rbRegional.Size = New System.Drawing.Size(67, 17)
        Me.rbRegional.TabIndex = 1
        Me.rbRegional.Text = "Regional"
        Me.rbRegional.UseVisualStyleBackColor = True
        '
        'rbPenal
        '
        Me.rbPenal.AutoSize = True
        Me.rbPenal.Checked = True
        Me.rbPenal.Location = New System.Drawing.Point(197, 19)
        Me.rbPenal.Name = "rbPenal"
        Me.rbPenal.Size = New System.Drawing.Size(14, 13)
        Me.rbPenal.TabIndex = 0
        Me.rbPenal.TabStop = True
        Me.rbPenal.UseVisualStyleBackColor = True
        '
        'cbbTipoDoc
        '
        Me.cbbTipoDoc._NoIndica = False
        Me.cbbTipoDoc._Todos = False
        Me.cbbTipoDoc._TodosMensaje = ""
        Me.cbbTipoDoc._Visible_Add = False
        Me.cbbTipoDoc._Visible_Buscar = False
        Me.cbbTipoDoc._Visible_Eliminar = False
        Me.cbbTipoDoc.CodigoPadre = -1
        Me.cbbTipoDoc.ComboTipo = Type.Combo.ComboTipo.TipoDoc
        Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
        Me.cbbTipoDoc.DropDownWidth = 150
        Me.cbbTipoDoc.DropDownWidthAuto = False
        Me.cbbTipoDoc.Location = New System.Drawing.Point(175, 13)
        Me.cbbTipoDoc.Name = "cbbTipoDoc"
        Me.cbbTipoDoc.Parametro1 = -1
        Me.cbbTipoDoc.Parametro2 = -1
        Me.cbbTipoDoc.SelectedIndex = -1
        Me.cbbTipoDoc.SelectedValue = 0
        Me.cbbTipoDoc.Size = New System.Drawing.Size(110, 22)
        Me.cbbTipoDoc.TabIndex = 17
        '
        'txtNumDocIdent
        '
        Me.txtNumDocIdent.Location = New System.Drawing.Point(291, 14)
        Me.txtNumDocIdent.MaxLength = 30
        Me.txtNumDocIdent.Name = "txtNumDocIdent"
        Me.txtNumDocIdent.Size = New System.Drawing.Size(183, 20)
        Me.txtNumDocIdent.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo y núm. de doc. identidad:"
        '
        'btnVerificar
        '
        Me.btnVerificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerificar.BackColor = System.Drawing.SystemColors.Control
        Me.btnVerificar.Image = Global.APPControls.My.Resources.Resources.verificar_biometria_32x32
        Me.btnVerificar.Location = New System.Drawing.Point(734, 9)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(132, 42)
        Me.btnVerificar.TabIndex = 0
        Me.btnVerificar.Text = "Iniciar verificación"
        Me.btnVerificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerificar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 440)
        Me.Panel1.TabIndex = 7
        '
        'uscHuellaVerificaInterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgwGrilla)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uscHuellaVerificaInterno"
        Me.Size = New System.Drawing.Size(867, 601)
        CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UscCapturaUniDactilar1 As APPControlHuellaVisita.uscCapturaMonoDactilar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNacional As System.Windows.Forms.RadioButton
    Friend WithEvents rbRegional As System.Windows.Forms.RadioButton
    Friend WithEvents rbPenal As System.Windows.Forms.RadioButton
    Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
    Friend WithEvents txtNumDocIdent As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cod_rp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ape As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fec_nac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_reg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_pen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_est_int As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_est_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblResultado As System.Windows.Forms.Label

End Class
