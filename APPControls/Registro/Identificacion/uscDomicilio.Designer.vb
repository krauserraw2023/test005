Namespace Registro.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscDomicilio
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
            Me.dgvDomicilio = New System.Windows.Forms.DataGridView()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.pnlDomicilioDel = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlDomicilioMant = New System.Windows.Forms.Panel()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro_inpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dir = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ubi_dist = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgvDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBotones.SuspendLayout()
            Me.pnlDomicilioDel.SuspendLayout()
            Me.pnlDomicilioMant.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvDomicilio
            '
            Me.dgvDomicilio.AllowUserToAddRows = False
            Me.dgvDomicilio.AllowUserToDeleteRows = False
            Me.dgvDomicilio.AllowUserToResizeRows = False
            Me.dgvDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDomicilio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pen_id, Me.col_codigo, Me.col_num_ing, Me.col_ing_nro_inpe, Me.col_dir, Me.col_ubi_dist})
            Me.dgvDomicilio.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDomicilio.Location = New System.Drawing.Point(0, 0)
            Me.dgvDomicilio.MultiSelect = False
            Me.dgvDomicilio.Name = "dgvDomicilio"
            Me.dgvDomicilio.ReadOnly = True
            Me.dgvDomicilio.RowHeadersVisible = False
            Me.dgvDomicilio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDomicilio.Size = New System.Drawing.Size(505, 197)
            Me.dgvDomicilio.TabIndex = 5
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.pnlDomicilioDel)
            Me.pnlBotones.Controls.Add(Me.pnlDomicilioMant)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotones.Location = New System.Drawing.Point(505, 0)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(26, 197)
            Me.pnlBotones.TabIndex = 4
            '
            'pnlDomicilioDel
            '
            Me.pnlDomicilioDel.Controls.Add(Me.btnEliminar)
            Me.pnlDomicilioDel.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDomicilioDel.Location = New System.Drawing.Point(0, 53)
            Me.pnlDomicilioDel.Name = "pnlDomicilioDel"
            Me.pnlDomicilioDel.Size = New System.Drawing.Size(26, 32)
            Me.pnlDomicilioDel.TabIndex = 96
            '
            'btnEliminar
            '
            Me.btnEliminar.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Location = New System.Drawing.Point(0, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(25, 26)
            Me.btnEliminar.TabIndex = 89
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlDomicilioMant
            '
            Me.pnlDomicilioMant.Controls.Add(Me.btnModificar)
            Me.pnlDomicilioMant.Controls.Add(Me.btnAgregar)
            Me.pnlDomicilioMant.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDomicilioMant.Location = New System.Drawing.Point(0, 0)
            Me.pnlDomicilioMant.Name = "pnlDomicilioMant"
            Me.pnlDomicilioMant.Size = New System.Drawing.Size(26, 53)
            Me.pnlDomicilioMant.TabIndex = 95
            '
            'btnModificar
            '
            Me.btnModificar.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnModificar.Location = New System.Drawing.Point(0, 26)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(25, 26)
            Me.btnModificar.TabIndex = 92
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'btnAgregar
            '
            Me.btnAgregar.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar.Location = New System.Drawing.Point(0, 1)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(25, 26)
            Me.btnAgregar.TabIndex = 91
            Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalId"
            Me.col_pen_id.HeaderText = "PenalId"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Id"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            Me.col_codigo.Width = 20
            '
            'col_num_ing
            '
            Me.col_num_ing.DataPropertyName = "NumIngreso"
            Me.col_num_ing.HeaderText = "N° Ing"
            Me.col_num_ing.Name = "col_num_ing"
            Me.col_num_ing.ReadOnly = True
            Me.col_num_ing.Width = 50
            '
            'col_ing_nro_inpe
            '
            Me.col_ing_nro_inpe.DataPropertyName = "IngresoNroInpe"
            Me.col_ing_nro_inpe.HeaderText = "N° Ing"
            Me.col_ing_nro_inpe.Name = "col_ing_nro_inpe"
            Me.col_ing_nro_inpe.ReadOnly = True
            Me.col_ing_nro_inpe.Width = 50
            '
            'col_dir
            '
            Me.col_dir.DataPropertyName = "Direccion"
            Me.col_dir.HeaderText = "Dirección"
            Me.col_dir.Name = "col_dir"
            Me.col_dir.ReadOnly = True
            Me.col_dir.Width = 230
            '
            'col_ubi_dist
            '
            Me.col_ubi_dist.DataPropertyName = "UbigeoDireccion"
            Me.col_ubi_dist.HeaderText = "Departamento/Provincia/Distrito"
            Me.col_ubi_dist.Name = "col_ubi_dist"
            Me.col_ubi_dist.ReadOnly = True
            Me.col_ubi_dist.Width = 200
            '
            'uscDomicilio
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgvDomicilio)
            Me.Controls.Add(Me.pnlBotones)
            Me.Name = "uscDomicilio"
            Me.Size = New System.Drawing.Size(531, 197)
            CType(Me.dgvDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBotones.ResumeLayout(False)
            Me.pnlDomicilioDel.ResumeLayout(False)
            Me.pnlDomicilioMant.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvDomicilio As System.Windows.Forms.DataGridView
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents pnlDomicilioDel As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents pnlDomicilioMant As System.Windows.Forms.Panel
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro_inpe As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_dir As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ubi_dist As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace