Namespace Mantenimiento.Tratamiento.Clasificacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscResultadoDet
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
            Me.pnlRagosAdd = New System.Windows.Forms.Panel()
            Me.btnEditarVariable = New System.Windows.Forms.Button()
            Me.btnNuevoVariable = New System.Windows.Forms.Button()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.pnlAccionRasgo = New System.Windows.Forms.Panel()
            Me.pnlRasgosEli = New System.Windows.Forms.Panel()
            Me.btnEliminarVariable = New System.Windows.Forms.Button()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.var_col_num_ord = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.var_col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlRagosAdd.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlAccionRasgo.SuspendLayout()
            Me.pnlRasgosEli.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRagosAdd
            '
            Me.pnlRagosAdd.Controls.Add(Me.btnEditarVariable)
            Me.pnlRagosAdd.Controls.Add(Me.btnNuevoVariable)
            Me.pnlRagosAdd.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlRagosAdd.Location = New System.Drawing.Point(1, 0)
            Me.pnlRagosAdd.Name = "pnlRagosAdd"
            Me.pnlRagosAdd.Size = New System.Drawing.Size(30, 55)
            Me.pnlRagosAdd.TabIndex = 90
            '
            'btnEditarVariable
            '
            Me.btnEditarVariable.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditarVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditarVariable.Location = New System.Drawing.Point(0, 28)
            Me.btnEditarVariable.Name = "btnEditarVariable"
            Me.btnEditarVariable.Size = New System.Drawing.Size(30, 26)
            Me.btnEditarVariable.TabIndex = 11
            Me.btnEditarVariable.UseVisualStyleBackColor = True
            '
            'btnNuevoVariable
            '
            Me.btnNuevoVariable.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnNuevoVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnNuevoVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoVariable.Location = New System.Drawing.Point(0, 1)
            Me.btnNuevoVariable.Name = "btnNuevoVariable"
            Me.btnNuevoVariable.Size = New System.Drawing.Size(30, 26)
            Me.btnNuevoVariable.TabIndex = 88
            Me.btnNuevoVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.var_col_num_ord, Me.Column1, Me.Column2, Me.var_col_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(503, 237)
            Me.dgwGrilla.TabIndex = 95
            Me.dgwGrilla.VisibleCampos = False
            '
            'pnlAccionRasgo
            '
            Me.pnlAccionRasgo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlAccionRasgo.Controls.Add(Me.pnlRasgosEli)
            Me.pnlAccionRasgo.Controls.Add(Me.pnlRagosAdd)
            Me.pnlAccionRasgo.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAccionRasgo.Location = New System.Drawing.Point(503, 0)
            Me.pnlAccionRasgo.Name = "pnlAccionRasgo"
            Me.pnlAccionRasgo.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
            Me.pnlAccionRasgo.Size = New System.Drawing.Size(33, 237)
            Me.pnlAccionRasgo.TabIndex = 96
            '
            'pnlRasgosEli
            '
            Me.pnlRasgosEli.Controls.Add(Me.btnEliminarVariable)
            Me.pnlRasgosEli.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlRasgosEli.Location = New System.Drawing.Point(1, 55)
            Me.pnlRasgosEli.Name = "pnlRasgosEli"
            Me.pnlRasgosEli.Size = New System.Drawing.Size(30, 37)
            Me.pnlRasgosEli.TabIndex = 91
            '
            'btnEliminarVariable
            '
            Me.btnEliminarVariable.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarVariable.Location = New System.Drawing.Point(0, 2)
            Me.btnEliminarVariable.Name = "btnEliminarVariable"
            Me.btnEliminarVariable.Size = New System.Drawing.Size(30, 26)
            Me.btnEliminarVariable.TabIndex = 89
            Me.btnEliminarVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'var_col_num_ord
            '
            Me.var_col_num_ord.DataPropertyName = "NumeroOrden"
            Me.var_col_num_ord.HeaderText = "Núm. Ord."
            Me.var_col_num_ord.Name = "var_col_num_ord"
            Me.var_col_num_ord.ReadOnly = True
            Me.var_col_num_ord.Width = 80
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "PuntajeInicial"
            Me.Column1.HeaderText = "De"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 50
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "PuntajeFinal"
            Me.Column2.HeaderText = "A"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 50
            '
            'var_col_nom
            '
            Me.var_col_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.var_col_nom.DataPropertyName = "Nombre"
            Me.var_col_nom.HeaderText = "Nombre"
            Me.var_col_nom.Name = "var_col_nom"
            Me.var_col_nom.ReadOnly = True
            '
            'uscResultadoDet
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlAccionRasgo)
            Me.Name = "uscResultadoDet"
            Me.Size = New System.Drawing.Size(536, 237)
            Me.pnlRagosAdd.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlAccionRasgo.ResumeLayout(False)
            Me.pnlRasgosEli.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnNuevoVariable As System.Windows.Forms.Button
        Friend WithEvents pnlRagosAdd As System.Windows.Forms.Panel
        Friend WithEvents btnEditarVariable As System.Windows.Forms.Button
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents btnEliminarVariable As System.Windows.Forms.Button
        Friend WithEvents pnlAccionRasgo As System.Windows.Forms.Panel
        Friend WithEvents pnlRasgosEli As System.Windows.Forms.Panel
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents var_col_num_ord As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents var_col_nom As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace