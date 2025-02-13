Namespace Visita.Visitante


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscSancionv2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlAdd = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.lblNroReg = New System.Windows.Forms.Label()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_est = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nro_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_cre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_anu = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_anu_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_ori_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_env_sed = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_rec_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlAdd.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlBotones.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlAdd
            '
            Me.pnlAdd.Controls.Add(Me.Panel2)
            Me.pnlAdd.Controls.Add(Me.Panel1)
            Me.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAdd.Location = New System.Drawing.Point(969, 0)
            Me.pnlAdd.Name = "pnlAdd"
            Me.pnlAdd.Size = New System.Drawing.Size(223, 56)
            Me.pnlAdd.TabIndex = 12
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnAnular)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(106, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(110, 56)
            Me.Panel2.TabIndex = 13
            '
            'btnAnular
            '
            Me.btnAnular.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnAnular.Location = New System.Drawing.Point(6, 9)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(97, 40)
            Me.btnAnular.TabIndex = 12
            Me.btnAnular.Text = "Anular"
            Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAnular.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnAgregar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(106, 56)
            Me.Panel1.TabIndex = 13
            '
            'btnAgregar
            '
            Me.btnAgregar.Image = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregar.Location = New System.Drawing.Point(3, 9)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(97, 40)
            Me.btnAgregar.TabIndex = 11
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.lblNroReg)
            Me.pnlBotones.Controls.Add(Me.pnlAdd)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBotones.Location = New System.Drawing.Point(0, 0)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(1192, 56)
            Me.pnlBotones.TabIndex = 13
            '
            'lblNroReg
            '
            Me.lblNroReg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblNroReg.AutoSize = True
            Me.lblNroReg.Location = New System.Drawing.Point(4, 18)
            Me.lblNroReg.Name = "lblNroReg"
            Me.lblNroReg.Size = New System.Drawing.Size(54, 13)
            Me.lblNroReg.TabIndex = 13
            Me.lblNroReg.Text = "lblNroReg"
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_est, Me.col_est_nom, Me.col_est_id, Me.col_id, Me.col_nro_doc, Me.col_apellidos, Me.col_nombres, Me.col_fec_ini, Me.col_fec_fin, Me.col_documento, Me.Column1, Me.col_fec_cre, Me.DataGridViewTextBoxColumn4, Me.col_fec_anu, Me.col_anu_nom, Me.col_pen_id, Me.col_pen_ori_id, Me.Column5, Me.col_fec_env_sed, Me.col_fec_rec_des})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 56)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1192, 202)
            Me.dgwGrilla.TabIndex = 42
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "Estado"
            Me.col_est.DividerWidth = 1
            Me.col_est.HeaderText = ""
            Me.col_est.Name = "col_est"
            Me.col_est.Visible = False
            Me.col_est.Width = 35
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "EstadoNombre"
            Me.col_est_nom.DividerWidth = 1
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.Width = 75
            '
            'col_est_id
            '
            Me.col_est_id.DataPropertyName = "EstadoID"
            Me.col_est_id.DividerWidth = 1
            Me.col_est_id.HeaderText = "EstadoID"
            Me.col_est_id.Name = "col_est_id"
            Me.col_est_id.Visible = False
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.DividerWidth = 1
            Me.col_id.HeaderText = "VisitanteSancionID"
            Me.col_id.Name = "col_id"
            Me.col_id.Visible = False
            '
            'col_nro_doc
            '
            Me.col_nro_doc.DataPropertyName = "NumeroDocumento"
            Me.col_nro_doc.DividerWidth = 1
            Me.col_nro_doc.HeaderText = "Numero Documento"
            Me.col_nro_doc.Name = "col_nro_doc"
            Me.col_nro_doc.Visible = False
            '
            'col_apellidos
            '
            Me.col_apellidos.DataPropertyName = "ApellidoPaterno"
            Me.col_apellidos.DividerWidth = 1
            Me.col_apellidos.HeaderText = "Apellidos"
            Me.col_apellidos.Name = "col_apellidos"
            Me.col_apellidos.Visible = False
            '
            'col_nombres
            '
            Me.col_nombres.DataPropertyName = "Nombres"
            Me.col_nombres.DividerWidth = 1
            Me.col_nombres.HeaderText = "Nombres"
            Me.col_nombres.Name = "col_nombres"
            Me.col_nombres.Visible = False
            '
            'col_fec_ini
            '
            Me.col_fec_ini.DataPropertyName = "FechaInicio"
            Me.col_fec_ini.HeaderText = "F. Inicio"
            Me.col_fec_ini.Name = "col_fec_ini"
            Me.col_fec_ini.ReadOnly = True
            Me.col_fec_ini.Width = 80
            '
            'col_fec_fin
            '
            Me.col_fec_fin.DataPropertyName = "FechaFin"
            Me.col_fec_fin.HeaderText = "F. Fin"
            Me.col_fec_fin.Name = "col_fec_fin"
            Me.col_fec_fin.ReadOnly = True
            Me.col_fec_fin.Width = 80
            '
            'col_documento
            '
            Me.col_documento.DataPropertyName = "Documento"
            Me.col_documento.HeaderText = "N° Documento"
            Me.col_documento.Name = "col_documento"
            Me.col_documento.ReadOnly = True
            Me.col_documento.Width = 130
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "TipoSancionNombre"
            Me.Column1.HeaderText = "Motivo sancion"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 150
            '
            'col_fec_cre
            '
            Me.col_fec_cre.DataPropertyName = "FechaCreacion"
            Me.col_fec_cre.HeaderText = "F. Registro"
            Me.col_fec_cre.Name = "col_fec_cre"
            Me.col_fec_cre.Width = 150
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "UsuarioCreacionNombres"
            Me.DataGridViewTextBoxColumn4.HeaderText = "Usuario Creacion"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Visible = False
            Me.DataGridViewTextBoxColumn4.Width = 170
            '
            'col_fec_anu
            '
            Me.col_fec_anu.DataPropertyName = "FechaAnulacion"
            Me.col_fec_anu.HeaderText = "F. Anulacion"
            Me.col_fec_anu.Name = "col_fec_anu"
            Me.col_fec_anu.Width = 150
            '
            'col_anu_nom
            '
            Me.col_anu_nom.DataPropertyName = "UsuarioAnulacionNombres"
            Me.col_anu_nom.HeaderText = "Usuario Anulacion"
            Me.col_anu_nom.Name = "col_anu_nom"
            Me.col_anu_nom.Visible = False
            Me.col_anu_nom.Width = 170
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.DividerWidth = 1
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.Visible = False
            '
            'col_pen_ori_id
            '
            Me.col_pen_ori_id.DataPropertyName = "IDPenalOrigen"
            Me.col_pen_ori_id.DividerWidth = 1
            Me.col_pen_ori_id.HeaderText = "IDPenalOrigen"
            Me.col_pen_ori_id.Name = "col_pen_ori_id"
            Me.col_pen_ori_id.Visible = False
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "RegionPenalOrigen"
            Me.Column5.HeaderText = "Penal de Origen"
            Me.Column5.Name = "Column5"
            Me.Column5.Width = 180
            '
            'col_fec_env_sed
            '
            Me.col_fec_env_sed.DataPropertyName = "FechaSede"
            Me.col_fec_env_sed.HeaderText = "F. Registro Sede"
            Me.col_fec_env_sed.Name = "col_fec_env_sed"
            Me.col_fec_env_sed.Width = 150
            '
            'col_fec_rec_des
            '
            Me.col_fec_rec_des.DataPropertyName = "FechaDestino"
            Me.col_fec_rec_des.HeaderText = "F. Recep. Penal"
            Me.col_fec_rec_des.Name = "col_fec_rec_des"
            Me.col_fec_rec_des.Width = 150
        '
        'uscSancionv2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgwGrilla)
        Me.Controls.Add(Me.pnlBotones)
        Me.Name = "uscSancionv2"
        Me.Size = New System.Drawing.Size(1192, 258)
        Me.pnlAdd.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.pnlBotones.ResumeLayout(false)
        Me.pnlBotones.PerformLayout
        CType(Me.dgwGrilla,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
        Friend WithEvents pnlAdd As System.Windows.Forms.Panel
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnAnular As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblNroReg As System.Windows.Forms.Label
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_est As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_est_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nro_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nombres As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ini As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_fin As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_documento As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_cre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_anu As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_anu_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_ori_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_env_sed As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_rec_des As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace