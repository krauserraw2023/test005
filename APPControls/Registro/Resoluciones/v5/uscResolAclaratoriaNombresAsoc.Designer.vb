<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscResolAclaratoriaNombresAsoc
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grbNombreAso = New System.Windows.Forms.GroupBox()
        Me.dgwNomAsoc = New System.Windows.Forms.DataGridView()
        Me.pnlNombresAsoc = New System.Windows.Forms.Panel()
        Me.grbBotMantNomAsoc = New System.Windows.Forms.GroupBox()
        Me.btnDelNomAsociado = New System.Windows.Forms.Button()
        Me.btnAgregarNomAsoc = New System.Windows.Forms.Button()
        Me.btnAulNomAsociado = New System.Windows.Forms.Button()
        Me.btnEditarNomAsoc = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom_asoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_nom_prin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_int_nom_aso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_elimina = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_accion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ape_pat2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ape_mat2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom_aclara = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_prin2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grbNombreAso.SuspendLayout()
        CType(Me.dgwNomAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNombresAsoc.SuspendLayout()
        Me.grbBotMantNomAsoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbNombreAso
        '
        Me.grbNombreAso.Controls.Add(Me.dgwNomAsoc)
        Me.grbNombreAso.Dock = System.Windows.Forms.DockStyle.Left
        Me.grbNombreAso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbNombreAso.Location = New System.Drawing.Point(0, 0)
        Me.grbNombreAso.Name = "grbNombreAso"
        Me.grbNombreAso.Size = New System.Drawing.Size(732, 128)
        Me.grbNombreAso.TabIndex = 0
        Me.grbNombreAso.TabStop = False
        Me.grbNombreAso.Text = "Nombres Asociados"
        '
        'dgwNomAsoc
        '
        Me.dgwNomAsoc.AllowUserToAddRows = False
        Me.dgwNomAsoc.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgwNomAsoc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwNomAsoc.BackgroundColor = System.Drawing.Color.White
        Me.dgwNomAsoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwNomAsoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_nom_asoc, Me.DataGridViewTextBoxColumn3, Me.col_sel, Me.col_nom_prin, Me.col_ape_pat, Me.col_ape_mat, Me.col_nom, Me.DataGridViewTextBoxColumn7, Me.col_est_id, Me.DataGridViewCheckBoxColumn3, Me.col_int_nom_aso_id, Me.col_elimina, Me.name1, Me.col_accion, Me.col_ape_pat2, Me.col_ape_mat2, Me.col_nom2, Me.col_nom_aclara, Me.col_prin2})
        Me.dgwNomAsoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwNomAsoc.GridColor = System.Drawing.Color.LightGray
        Me.dgwNomAsoc.Location = New System.Drawing.Point(3, 16)
        Me.dgwNomAsoc.MultiSelect = False
        Me.dgwNomAsoc.Name = "dgwNomAsoc"
        Me.dgwNomAsoc.RowHeadersVisible = False
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgwNomAsoc.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgwNomAsoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwNomAsoc.Size = New System.Drawing.Size(726, 109)
        Me.dgwNomAsoc.TabIndex = 1
        '
        'pnlNombresAsoc
        '
        Me.pnlNombresAsoc.Controls.Add(Me.grbBotMantNomAsoc)
        Me.pnlNombresAsoc.Location = New System.Drawing.Point(732, 0)
        Me.pnlNombresAsoc.Name = "pnlNombresAsoc"
        Me.pnlNombresAsoc.Size = New System.Drawing.Size(45, 128)
        Me.pnlNombresAsoc.TabIndex = 0
        '
        'grbBotMantNomAsoc
        '
        Me.grbBotMantNomAsoc.Controls.Add(Me.btnDelNomAsociado)
        Me.grbBotMantNomAsoc.Controls.Add(Me.btnAgregarNomAsoc)
        Me.grbBotMantNomAsoc.Controls.Add(Me.btnAulNomAsociado)
        Me.grbBotMantNomAsoc.Controls.Add(Me.btnEditarNomAsoc)
        Me.grbBotMantNomAsoc.Dock = System.Windows.Forms.DockStyle.Left
        Me.grbBotMantNomAsoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbBotMantNomAsoc.Location = New System.Drawing.Point(0, 0)
        Me.grbBotMantNomAsoc.Name = "grbBotMantNomAsoc"
        Me.grbBotMantNomAsoc.Size = New System.Drawing.Size(39, 128)
        Me.grbBotMantNomAsoc.TabIndex = 1
        Me.grbBotMantNomAsoc.TabStop = False
        '
        'btnDelNomAsociado
        '
        Me.btnDelNomAsociado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelNomAsociado.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
        Me.btnDelNomAsociado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDelNomAsociado.Location = New System.Drawing.Point(3, 90)
        Me.btnDelNomAsociado.Name = "btnDelNomAsociado"
        Me.btnDelNomAsociado.Size = New System.Drawing.Size(26, 25)
        Me.btnDelNomAsociado.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnDelNomAsociado, "Eliminar accion")
        Me.btnDelNomAsociado.UseVisualStyleBackColor = True
        '
        'btnAgregarNomAsoc
        '
        Me.btnAgregarNomAsoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarNomAsoc.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
        Me.btnAgregarNomAsoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarNomAsoc.Location = New System.Drawing.Point(3, 8)
        Me.btnAgregarNomAsoc.Name = "btnAgregarNomAsoc"
        Me.btnAgregarNomAsoc.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarNomAsoc.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnAgregarNomAsoc, "Agregar Nombre asociado")
        Me.btnAgregarNomAsoc.UseVisualStyleBackColor = True
        '
        'btnAulNomAsociado
        '
        Me.btnAulNomAsociado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAulNomAsociado.BackgroundImage = Global.APPControls.My.Resources.Resources.anular2
        Me.btnAulNomAsociado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAulNomAsociado.Location = New System.Drawing.Point(3, 62)
        Me.btnAulNomAsociado.Name = "btnAulNomAsociado"
        Me.btnAulNomAsociado.Size = New System.Drawing.Size(26, 25)
        Me.btnAulNomAsociado.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnAulNomAsociado, "Anular Nombre asociado")
        Me.btnAulNomAsociado.UseVisualStyleBackColor = True
        '
        'btnEditarNomAsoc
        '
        Me.btnEditarNomAsoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarNomAsoc.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
        Me.btnEditarNomAsoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEditarNomAsoc.Location = New System.Drawing.Point(3, 35)
        Me.btnEditarNomAsoc.Name = "btnEditarNomAsoc"
        Me.btnEditarNomAsoc.Size = New System.Drawing.Size(26, 25)
        Me.btnEditarNomAsoc.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnEditarNomAsoc, "Editar Nombre asociado")
        Me.btnEditarNomAsoc.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'col_codigo
        '
        Me.col_codigo.DataPropertyName = "Codigo"
        Me.col_codigo.HeaderText = "DocNombreAsociadoID"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.ReadOnly = True
        Me.col_codigo.Visible = False
        Me.col_codigo.Width = 40
        '
        'col_nom_asoc
        '
        Me.col_nom_asoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_nom_asoc.DataPropertyName = "ApellidosyNombres"
        Me.col_nom_asoc.HeaderText = "Nombres"
        Me.col_nom_asoc.Name = "col_nom_asoc"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "InternoID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "InternoID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'col_sel
        '
        Me.col_sel.HeaderText = ""
        Me.col_sel.Name = "col_sel"
        Me.col_sel.Visible = False
        Me.col_sel.Width = 30
        '
        'col_nom_prin
        '
        Me.col_nom_prin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_nom_prin.DataPropertyName = "PrincipalBol"
        Me.col_nom_prin.HeaderText = "Principal"
        Me.col_nom_prin.Name = "col_nom_prin"
        Me.col_nom_prin.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_nom_prin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_nom_prin.Visible = False
        Me.col_nom_prin.Width = 50
        '
        'col_ape_pat
        '
        Me.col_ape_pat.DataPropertyName = "NAPaterno"
        Me.col_ape_pat.HeaderText = "Apellido Paterno"
        Me.col_ape_pat.Name = "col_ape_pat"
        Me.col_ape_pat.ReadOnly = True
        Me.col_ape_pat.Visible = False
        Me.col_ape_pat.Width = 180
        '
        'col_ape_mat
        '
        Me.col_ape_mat.DataPropertyName = "NAMAterno"
        Me.col_ape_mat.HeaderText = "Apellido Materno"
        Me.col_ape_mat.Name = "col_ape_mat"
        Me.col_ape_mat.ReadOnly = True
        Me.col_ape_mat.Visible = False
        Me.col_ape_mat.Width = 180
        '
        'col_nom
        '
        Me.col_nom.DataPropertyName = "NANombres"
        Me.col_nom.HeaderText = "Nombres"
        Me.col_nom.Name = "col_nom"
        Me.col_nom.ReadOnly = True
        Me.col_nom.Visible = False
        Me.col_nom.Width = 180
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Principal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Principal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 90
        '
        'col_est_id
        '
        Me.col_est_id.DataPropertyName = "NAEstado"
        Me.col_est_id.HeaderText = "EstadoID"
        Me.col_est_id.Name = "col_est_id"
        Me.col_est_id.Visible = False
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "RegularizarNombreAsociado"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "col_regularizar"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Visible = False
        '
        'col_int_nom_aso_id
        '
        Me.col_int_nom_aso_id.DataPropertyName = "InternoNombreAsociadoID"
        Me.col_int_nom_aso_id.HeaderText = "NomAsocIdFk"
        Me.col_int_nom_aso_id.Name = "col_int_nom_aso_id"
        Me.col_int_nom_aso_id.Visible = False
        Me.col_int_nom_aso_id.Width = 45
        '
        'col_elimina
        '
        Me.col_elimina.HeaderText = "Elimado"
        Me.col_elimina.Name = "col_elimina"
        Me.col_elimina.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_elimina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_elimina.Visible = False
        Me.col_elimina.Width = 50
        '
        'name1
        '
        Me.name1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.name1.DataPropertyName = "NAEstadoOri"
        Me.name1.HeaderText = "AccionID"
        Me.name1.Name = "name1"
        Me.name1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.name1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name1.Visible = False
        '
        'col_accion
        '
        Me.col_accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_accion.DataPropertyName = "EstadoNombre"
        Me.col_accion.HeaderText = "Accion"
        Me.col_accion.Name = "col_accion"
        Me.col_accion.Width = 80
        '
        'col_ape_pat2
        '
        Me.col_ape_pat2.DataPropertyName = "NAPaterno2"
        Me.col_ape_pat2.HeaderText = "ApellidoPaterno2"
        Me.col_ape_pat2.Name = "col_ape_pat2"
        Me.col_ape_pat2.Visible = False
        '
        'col_ape_mat2
        '
        Me.col_ape_mat2.DataPropertyName = "NAMAterno2"
        Me.col_ape_mat2.HeaderText = "ApellidoMaterno2"
        Me.col_ape_mat2.Name = "col_ape_mat2"
        Me.col_ape_mat2.Visible = False
        '
        'col_nom2
        '
        Me.col_nom2.DataPropertyName = "NAEstado"
        Me.col_nom2.HeaderText = "Nombres2"
        Me.col_nom2.Name = "col_nom2"
        Me.col_nom2.Visible = False
        '
        'col_nom_aclara
        '
        Me.col_nom_aclara.DataPropertyName = "ApellidosyNombres2"
        Me.col_nom_aclara.HeaderText = "Nombres y Apellidos (Aclaratoria)"
        Me.col_nom_aclara.Name = "col_nom_aclara"
        Me.col_nom_aclara.Width = 320
        '
        'col_prin2
        '
        Me.col_prin2.DataPropertyName = "PrincipalBol2"
        Me.col_prin2.HeaderText = "Principal2"
        Me.col_prin2.Name = "col_prin2"
        Me.col_prin2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_prin2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_prin2.Visible = False
        Me.col_prin2.Width = 50
        '
        'uscResolAclaratoriaNombresAsoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grbNombreAso)
        Me.Controls.Add(Me.pnlNombresAsoc)
        Me.Name = "uscResolAclaratoriaNombresAsoc"
        Me.Size = New System.Drawing.Size(777, 128)
        Me.grbNombreAso.ResumeLayout(False)
        CType(Me.dgwNomAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNombresAsoc.ResumeLayout(False)
        Me.grbBotMantNomAsoc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbNombreAso As System.Windows.Forms.GroupBox
    Friend WithEvents dgwNomAsoc As System.Windows.Forms.DataGridView
    Friend WithEvents pnlNombresAsoc As System.Windows.Forms.Panel
    Friend WithEvents btnDelNomAsociado As System.Windows.Forms.Button
    Friend WithEvents btnEditarNomAsoc As System.Windows.Forms.Button
    Friend WithEvents btnAgregarNomAsoc As System.Windows.Forms.Button
    Friend WithEvents btnAulNomAsociado As System.Windows.Forms.Button
    Friend WithEvents grbBotMantNomAsoc As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents col_codigo As DataGridViewTextBoxColumn
    Friend WithEvents col_nom_asoc As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents col_sel As DataGridViewCheckBoxColumn
    Friend WithEvents col_nom_prin As DataGridViewCheckBoxColumn
    Friend WithEvents col_ape_pat As DataGridViewTextBoxColumn
    Friend WithEvents col_ape_mat As DataGridViewTextBoxColumn
    Friend WithEvents col_nom As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents col_est_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents col_int_nom_aso_id As DataGridViewTextBoxColumn
    Friend WithEvents col_elimina As DataGridViewCheckBoxColumn
    Friend WithEvents name1 As DataGridViewTextBoxColumn
    Friend WithEvents col_accion As DataGridViewTextBoxColumn
    Friend WithEvents col_ape_pat2 As DataGridViewTextBoxColumn
    Friend WithEvents col_ape_mat2 As DataGridViewTextBoxColumn
    Friend WithEvents col_nom2 As DataGridViewTextBoxColumn
    Friend WithEvents col_nom_aclara As DataGridViewTextBoxColumn
    Friend WithEvents col_prin2 As DataGridViewCheckBoxColumn
End Class
