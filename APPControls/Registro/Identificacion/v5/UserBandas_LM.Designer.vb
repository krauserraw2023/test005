Namespace Registro.Identificacion.v5
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UserBandas_LM
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserBandas_LM))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlCabeceraAlias = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pnlBandaAdd = New System.Windows.Forms.Panel()
            Me.btnModBanda = New System.Windows.Forms.Button()
            Me.btnAddBanda = New System.Windows.Forms.Button()
            Me.pnlBandasEliminar = New System.Windows.Forms.Panel()
            Me.btnEliBanda = New System.Windows.Forms.Button()
            Me.dgwMovbandas = New System.Windows.Forms.DataGridView()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_ban_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_inpe_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_inpe_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlCabeceraAlias.SuspendLayout()
            Me.pnlBandaAdd.SuspendLayout()
            Me.pnlBandasEliminar.SuspendLayout()
            CType(Me.dgwMovbandas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlCabeceraAlias
            '
            Me.pnlCabeceraAlias.Controls.Add(Me.Label1)
            Me.pnlCabeceraAlias.Controls.Add(Me.pnlBandaAdd)
            Me.pnlCabeceraAlias.Controls.Add(Me.pnlBandasEliminar)
            Me.pnlCabeceraAlias.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabeceraAlias.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabeceraAlias.Name = "pnlCabeceraAlias"
            Me.pnlCabeceraAlias.Size = New System.Drawing.Size(805, 40)
            Me.pnlCabeceraAlias.TabIndex = 6
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 15)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(49, 13)
            Me.Label1.TabIndex = 92
            Me.Label1.Text = "Bandas"
            '
            'pnlBandaAdd
            '
            Me.pnlBandaAdd.Controls.Add(Me.btnModBanda)
            Me.pnlBandaAdd.Controls.Add(Me.btnAddBanda)
            Me.pnlBandaAdd.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBandaAdd.Location = New System.Drawing.Point(520, 0)
            Me.pnlBandaAdd.Name = "pnlBandaAdd"
            Me.pnlBandaAdd.Size = New System.Drawing.Size(196, 40)
            Me.pnlBandaAdd.TabIndex = 91
            '
            'btnModBanda
            '
            Me.btnModBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModBanda.Image = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModBanda.Location = New System.Drawing.Point(101, 0)
            Me.btnModBanda.Name = "btnModBanda"
            Me.btnModBanda.Size = New System.Drawing.Size(90, 40)
            Me.btnModBanda.TabIndex = 89
            Me.btnModBanda.Text = "Modificar"
            Me.btnModBanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAddBanda
            '
            Me.btnAddBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddBanda.Image = CType(resources.GetObject("btnAddBanda.Image"), System.Drawing.Image)
            Me.btnAddBanda.Location = New System.Drawing.Point(5, 0)
            Me.btnAddBanda.Name = "btnAddBanda"
            Me.btnAddBanda.Size = New System.Drawing.Size(88, 40)
            Me.btnAddBanda.TabIndex = 88
            Me.btnAddBanda.Text = "&Agregar"
            Me.btnAddBanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlBandasEliminar
            '
            Me.pnlBandasEliminar.Controls.Add(Me.btnEliBanda)
            Me.pnlBandasEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBandasEliminar.Location = New System.Drawing.Point(716, 0)
            Me.pnlBandasEliminar.Name = "pnlBandasEliminar"
            Me.pnlBandasEliminar.Size = New System.Drawing.Size(89, 40)
            Me.pnlBandasEliminar.TabIndex = 90
            '
            'btnEliBanda
            '
            Me.btnEliBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliBanda.Image = CType(resources.GetObject("btnEliBanda.Image"), System.Drawing.Image)
            Me.btnEliBanda.Location = New System.Drawing.Point(1, 0)
            Me.btnEliBanda.Name = "btnEliBanda"
            Me.btnEliBanda.Size = New System.Drawing.Size(88, 40)
            Me.btnEliBanda.TabIndex = 90
            Me.btnEliBanda.Text = "&Eliminar"
            Me.btnEliBanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'dgwMovbandas
            '
            Me.dgwMovbandas.AllowUserToAddRows = False
            Me.dgwMovbandas.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwMovbandas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwMovbandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwMovbandas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pen_id, Me.col_mov_ban_id, Me.DataGridViewTextBoxColumn15, Me.col_ing_id, Me.col_ing_nro, Me.col_ing_inpe_id, Me.col_ing_inpe_nro, Me.DataGridViewTextBoxColumn19, Me.col_obs})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwMovbandas.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwMovbandas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwMovbandas.GridColor = System.Drawing.Color.LightGray
            Me.dgwMovbandas.Location = New System.Drawing.Point(0, 40)
            Me.dgwMovbandas.MultiSelect = False
            Me.dgwMovbandas.Name = "dgwMovbandas"
            Me.dgwMovbandas.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwMovbandas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwMovbandas.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwMovbandas.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwMovbandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwMovbandas.Size = New System.Drawing.Size(805, 332)
            Me.dgwMovbandas.TabIndex = 7
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.HeaderText = "PenalId"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_mov_ban_id
            '
            Me.col_mov_ban_id.DataPropertyName = "Codigo"
            Me.col_mov_ban_id.HeaderText = "MovBandaID"
            Me.col_mov_ban_id.Name = "col_mov_ban_id"
            Me.col_mov_ban_id.ReadOnly = True
            Me.col_mov_ban_id.Visible = False
            '
            'DataGridViewTextBoxColumn15
            '
            Me.DataGridViewTextBoxColumn15.DataPropertyName = "InternoID"
            Me.DataGridViewTextBoxColumn15.HeaderText = "InternoID"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.ReadOnly = True
            Me.DataGridViewTextBoxColumn15.Visible = False
            '
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "IngresoInpeId"
            Me.col_ing_id.HeaderText = "IngresoID"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
            '
            'col_ing_nro
            '
            Me.col_ing_nro.DataPropertyName = "IngresoNro"
            Me.col_ing_nro.HeaderText = "Nro Ingreso "
            Me.col_ing_nro.Name = "col_ing_nro"
            Me.col_ing_nro.ReadOnly = True
            Me.col_ing_nro.ToolTipText = "Número de ingreso al penal"
            Me.col_ing_nro.Width = 45
            '
            'col_ing_inpe_id
            '
            Me.col_ing_inpe_id.DataPropertyName = "IngresoInpeId"
            Me.col_ing_inpe_id.HeaderText = "IngresoInpeId"
            Me.col_ing_inpe_id.Name = "col_ing_inpe_id"
            Me.col_ing_inpe_id.ReadOnly = True
            Me.col_ing_inpe_id.Visible = False
            '
            'col_ing_inpe_nro
            '
            Me.col_ing_inpe_nro.DataPropertyName = "IngresoInpeNro"
            Me.col_ing_inpe_nro.HeaderText = "Nro Ingreso"
            Me.col_ing_inpe_nro.Name = "col_ing_inpe_nro"
            Me.col_ing_inpe_nro.ReadOnly = True
            Me.col_ing_inpe_nro.ToolTipText = "Número de ingreso al inpe"
            Me.col_ing_inpe_nro.Width = 45
            '
            'DataGridViewTextBoxColumn19
            '
            Me.DataGridViewTextBoxColumn19.DataPropertyName = "BandaNombre"
            Me.DataGridViewTextBoxColumn19.HeaderText = "Banda"
            Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
            Me.DataGridViewTextBoxColumn19.ReadOnly = True
            Me.DataGridViewTextBoxColumn19.Width = 180
            '
            'col_obs
            '
            Me.col_obs.DataPropertyName = "Observacion"
            Me.col_obs.HeaderText = "Observacion"
            Me.col_obs.Name = "col_obs"
            Me.col_obs.ReadOnly = True
            Me.col_obs.Width = 200
            '
            'UserBandas_LM
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwMovbandas)
            Me.Controls.Add(Me.pnlCabeceraAlias)
            Me.Name = "UserBandas_LM"
            Me.Size = New System.Drawing.Size(805, 372)
            Me.pnlCabeceraAlias.ResumeLayout(False)
            Me.pnlCabeceraAlias.PerformLayout()
            Me.pnlBandaAdd.ResumeLayout(False)
            Me.pnlBandasEliminar.ResumeLayout(False)
            CType(Me.dgwMovbandas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlCabeceraAlias As System.Windows.Forms.Panel
        Friend WithEvents pnlBandaAdd As System.Windows.Forms.Panel
        Friend WithEvents btnModBanda As System.Windows.Forms.Button
        Friend WithEvents btnAddBanda As System.Windows.Forms.Button
        Friend WithEvents pnlBandasEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliBanda As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgwMovbandas As System.Windows.Forms.DataGridView
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mov_ban_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_inpe_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_inpe_nro As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_obs As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace