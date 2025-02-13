Namespace Registro.Main.Antecedentes
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscarAntecedentesPopup
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarAntecedentesPopup))
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtInternoCod = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_aj_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_sol = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_imp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_usu = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgwGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(915, 441)
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 395)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(915, 46)
            Me.Panel2.TabIndex = 89
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(814, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 86
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(719, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.grbBuscar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(915, 121)
            Me.Panel1.TabIndex = 90
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtApePat)
            Me.GroupBox2.Controls.Add(Me.txtNombres)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.txtApeMat)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtInternoCod)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Location = New System.Drawing.Point(5, 8)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(825, 105)
            Me.GroupBox2.TabIndex = 59
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Datos de búsqueda"
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = False
            Me.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApePat.Location = New System.Drawing.Point(97, 44)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(313, 20)
            Me.txtApePat.TabIndex = 0
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNombres
            '
            Me.txtNombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombres._BloquearPaste = False
            Me.txtNombres._SeleccionarTodo = False
            Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombres.Location = New System.Drawing.Point(97, 69)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.Size = New System.Drawing.Size(710, 20)
            Me.txtNombres.TabIndex = 2
            Me.txtNombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(25, 22)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(68, 13)
            Me.Label4.TabIndex = 57
            Me.Label4.Text = "Cod. Interno:"
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = False
            Me.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApeMat.Location = New System.Drawing.Point(494, 44)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(313, 20)
            Me.txtApeMat.TabIndex = 1
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(27, 48)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(66, 13)
            Me.Label8.TabIndex = 57
            Me.Label8.Text = "Primer Apellido:"
            '
            'txtInternoCod
            '
            Me.txtInternoCod._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtInternoCod._BloquearPaste = False
            Me.txtInternoCod._SeleccionarTodo = False
            Me.txtInternoCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtInternoCod.Location = New System.Drawing.Point(97, 19)
            Me.txtInternoCod.Name = "txtInternoCod"
            Me.txtInternoCod.Size = New System.Drawing.Size(128, 20)
            Me.txtInternoCod.TabIndex = 1
            Me.txtInternoCod.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtInternoCod.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(423, 48)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(68, 13)
            Me.Label9.TabIndex = 57
            Me.Label9.Text = "Segundo Ap. :"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(35, 73)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(58, 13)
            Me.Label10.TabIndex = 57
            Me.Label10.Text = "Nombre(s):"
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(832, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(83, 121)
            Me.grbBuscar.TabIndex = 39
            Me.grbBuscar.TabStop = False
            '
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbLimpiar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 102)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(75, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'tsbLimpiar
            '
            Me.tsbLimpiar.BackColor = System.Drawing.Color.Transparent
            Me.tsbLimpiar.Image = CType(resources.GetObject("tsbLimpiar.Image"), System.Drawing.Image)
            Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiar.Name = "tsbLimpiar"
            Me.tsbLimpiar.Size = New System.Drawing.Size(75, 43)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiar.ToolTipText = "Limpiar"
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cod, Me.col_est_id, Me.col_est, Me.col_tip_aj_id, Me.col_tip, Me.col_sol_num, Me.col_fec_sol, Me.col_ape_pat, Me.col_ape_mat, Me.col_nom, Me.col_num_imp, Me.col_cod_usu, Me.col_int_cod})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 121)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(915, 274)
            Me.dgwGrilla.TabIndex = 0
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "Codigo"
            Me.col_cod.HeaderText = "Codigo"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            Me.col_cod.Visible = False
            '
            'col_est_id
            '
            Me.col_est_id.DataPropertyName = "EstadoSolicitudId"
            Me.col_est_id.DividerWidth = 1
            Me.col_est_id.HeaderText = "estadoId"
            Me.col_est_id.Name = "col_est_id"
            Me.col_est_id.ReadOnly = True
            Me.col_est_id.Visible = False
            '
            'col_est
            '
            Me.col_est.HeaderText = "Est."
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Width = 30
            '
            'col_tip_aj_id
            '
            Me.col_tip_aj_id.DataPropertyName = "TipoAntecedenteId"
            Me.col_tip_aj_id.HeaderText = "TipoCertAJId"
            Me.col_tip_aj_id.Name = "col_tip_aj_id"
            Me.col_tip_aj_id.ReadOnly = True
            Me.col_tip_aj_id.Visible = False
            '
            'col_tip
            '
            Me.col_tip.DataPropertyName = "TipoAntecedenteStr"
            Me.col_tip.HeaderText = "Tipo de antecedente"
            Me.col_tip.Name = "col_tip"
            Me.col_tip.ReadOnly = True
            '
            'col_sol_num
            '
            Me.col_sol_num.DataPropertyName = "NumSolicitudStr"
            Me.col_sol_num.HeaderText = "N° Solicitud"
            Me.col_sol_num.Name = "col_sol_num"
            Me.col_sol_num.ReadOnly = True
            '
            'col_fec_sol
            '
            Me.col_fec_sol.DataPropertyName = "FechaSolicitudStr"
            Me.col_fec_sol.HeaderText = "Fecha solicitud"
            Me.col_fec_sol.Name = "col_fec_sol"
            Me.col_fec_sol.ReadOnly = True
            Me.col_fec_sol.Width = 90
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "InternoApePaterno"
            Me.col_ape_pat.HeaderText = "Primer Apellido"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.Width = 150
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "InternoApeMaterno"
            Me.col_ape_mat.HeaderText = "Segundo Ap."
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.Width = 150
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "InternoNombres"
            Me.col_nom.HeaderText = "Nombre(s)"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Width = 150
            '
            'col_num_imp
            '
            Me.col_num_imp.DataPropertyName = "NumImpresiones"
            Me.col_num_imp.HeaderText = "N° Impr."
            Me.col_num_imp.Name = "col_num_imp"
            Me.col_num_imp.ReadOnly = True
            Me.col_num_imp.Width = 40
            '
            'col_cod_usu
            '
            Me.col_cod_usu.DataPropertyName = "UsuarioCrea"
            Me.col_cod_usu.HeaderText = "Usuario"
            Me.col_cod_usu.Name = "col_cod_usu"
            Me.col_cod_usu.ReadOnly = True
            '
            'col_int_cod
            '
            Me.col_int_cod.DataPropertyName = "InternoCodigo"
            Me.col_int_cod.HeaderText = "cod_rp"
            Me.col_int_cod.Name = "col_int_cod"
            Me.col_int_cod.ReadOnly = True
            Me.col_int_cod.Visible = False
            '
            'frmBuscarAntecedentesPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(915, 441)
            Me.KeyPreview = False
            Me.Name = "frmBuscarAntecedentesPopup"
            Me.Text = ".::. Búsqueda de antecedentes"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtInternoCod As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_aj_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_num As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_sol As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_imp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod_usu As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_cod As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace