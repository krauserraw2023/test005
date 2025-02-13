Namespace Registro.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscGradosAcademicos
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
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.pnlGradAcadDel = New System.Windows.Forms.Panel()
        Me.btnEliminarGradAcad = New System.Windows.Forms.Button()
        Me.pnlGradAcadMant = New System.Windows.Forms.Panel()
        Me.btnModGradAca = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgwGradoInst = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro_inpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_grad_ins = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBotones.SuspendLayout()
            Me.pnlGradAcadDel.SuspendLayout()
            Me.pnlGradAcadMant.SuspendLayout()
            CType(Me.dgwGradoInst, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.pnlGradAcadDel)
            Me.pnlBotones.Controls.Add(Me.pnlGradAcadMant)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotones.Location = New System.Drawing.Point(463, 0)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(26, 197)
            Me.pnlBotones.TabIndex = 2
            '
            'pnlGradAcadDel
            '
            Me.pnlGradAcadDel.Controls.Add(Me.btnEliminarGradAcad)
            Me.pnlGradAcadDel.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlGradAcadDel.Location = New System.Drawing.Point(0, 53)
            Me.pnlGradAcadDel.Name = "pnlGradAcadDel"
            Me.pnlGradAcadDel.Size = New System.Drawing.Size(26, 32)
            Me.pnlGradAcadDel.TabIndex = 96
            '
            'btnEliminarGradAcad
            '
            Me.btnEliminarGradAcad.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarGradAcad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarGradAcad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarGradAcad.Location = New System.Drawing.Point(0, 0)
            Me.btnEliminarGradAcad.Name = "btnEliminarGradAcad"
            Me.btnEliminarGradAcad.Size = New System.Drawing.Size(25, 26)
            Me.btnEliminarGradAcad.TabIndex = 89
            Me.btnEliminarGradAcad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlGradAcadMant
            '
            Me.pnlGradAcadMant.Controls.Add(Me.btnModGradAca)
            Me.pnlGradAcadMant.Controls.Add(Me.btnAgregar)
            Me.pnlGradAcadMant.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlGradAcadMant.Location = New System.Drawing.Point(0, 0)
            Me.pnlGradAcadMant.Name = "pnlGradAcadMant"
            Me.pnlGradAcadMant.Size = New System.Drawing.Size(26, 53)
            Me.pnlGradAcadMant.TabIndex = 95
            '
            'btnModGradAca
            '
            Me.btnModGradAca.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModGradAca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnModGradAca.Location = New System.Drawing.Point(0, 26)
            Me.btnModGradAca.Name = "btnModGradAca"
            Me.btnModGradAca.Size = New System.Drawing.Size(25, 26)
            Me.btnModGradAca.TabIndex = 92
            Me.btnModGradAca.UseVisualStyleBackColor = True
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
            'dgwGradoInst
            '
            Me.dgwGradoInst.AllowUserToAddRows = False
            Me.dgwGradoInst.AllowUserToDeleteRows = False
            Me.dgwGradoInst.AllowUserToResizeRows = False
            Me.dgwGradoInst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGradoInst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pen_id, Me.col_codigo, Me.col_num_ing, Me.col_ing_nro_inpe, Me.col_grad_ins})
            Me.dgwGradoInst.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGradoInst.Location = New System.Drawing.Point(0, 0)
            Me.dgwGradoInst.MultiSelect = False
            Me.dgwGradoInst.Name = "dgwGradoInst"
            Me.dgwGradoInst.ReadOnly = True
            Me.dgwGradoInst.RowHeadersVisible = False
            Me.dgwGradoInst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGradoInst.Size = New System.Drawing.Size(463, 197)
            Me.dgwGradoInst.TabIndex = 3
            '
            'DataGridViewImageColumn1
            '
            Me.DataGridViewImageColumn1.HeaderText = ""
            Me.DataGridViewImageColumn1.Image = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
            Me.DataGridViewImageColumn1.Width = 30
            '
            'DataGridViewImageColumn2
            '
            Me.DataGridViewImageColumn2.HeaderText = ""
            Me.DataGridViewImageColumn2.Image = Global.APPControls.My.Resources.Resources.delete_32
            Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
            Me.DataGridViewImageColumn2.Width = 30
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
        Me.col_ing_nro_inpe.ReadOnly = true
        Me.col_ing_nro_inpe.Width = 50
        '
        'col_grad_ins
        '
        Me.col_grad_ins.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_grad_ins.DataPropertyName = "GradoInstruccionStr"
        Me.col_grad_ins.HeaderText = "Grado"
        Me.col_grad_ins.Name = "col_grad_ins"
        Me.col_grad_ins.ReadOnly = true
        '
        'uscGradosAcademicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgwGradoInst)
        Me.Controls.Add(Me.pnlBotones)
        Me.Name = "uscGradosAcademicos"
        Me.Size = New System.Drawing.Size(489, 197)
        Me.pnlBotones.ResumeLayout(false)
        Me.pnlGradAcadDel.ResumeLayout(false)
        Me.pnlGradAcadMant.ResumeLayout(false)
        CType(Me.dgwGradoInst,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents dgwGradoInst As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents pnlGradAcadMant As System.Windows.Forms.Panel
        Friend WithEvents btnModGradAca As System.Windows.Forms.Button
        Friend WithEvents pnlGradAcadDel As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarGradAcad As System.Windows.Forms.Button
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro_inpe As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_grad_ins As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace