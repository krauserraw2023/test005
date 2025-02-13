Namespace Registro.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscIdiomaInterno
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
            Me.dgvIdiomas = New System.Windows.Forms.DataGridView()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.pnlIdiomaDel = New System.Windows.Forms.Panel()
            Me.btnEliminarRasgo = New System.Windows.Forms.Button()
            Me.pnlIdiomaMant = New System.Windows.Forms.Panel()
            Me.btnAgregarIdioma = New System.Windows.Forms.Button()
            Me.btnModRasgo = New System.Windows.Forms.Button()
            Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_idioma_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nro_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro_inpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_idioma = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_idi_dom_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_niv_dom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgvIdiomas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBotones.SuspendLayout()
            Me.pnlIdiomaDel.SuspendLayout()
            Me.pnlIdiomaMant.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvIdiomas
            '
            Me.dgvIdiomas.AllowUserToAddRows = False
            Me.dgvIdiomas.AllowUserToDeleteRows = False
            Me.dgvIdiomas.AllowUserToResizeRows = False
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvIdiomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvIdiomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pen_id, Me.col_id, Me.col_idioma_id, Me.col_nro_ing, Me.col_ing_nro_inpe, Me.col_idioma, Me.col_idi_dom_id, Me.col_niv_dom})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvIdiomas.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvIdiomas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvIdiomas.Location = New System.Drawing.Point(0, 0)
            Me.dgvIdiomas.MultiSelect = False
            Me.dgvIdiomas.Name = "dgvIdiomas"
            Me.dgvIdiomas.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvIdiomas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvIdiomas.RowHeadersVisible = False
            Me.dgvIdiomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvIdiomas.Size = New System.Drawing.Size(434, 237)
            Me.dgvIdiomas.TabIndex = 0
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.pnlIdiomaDel)
            Me.pnlBotones.Controls.Add(Me.pnlIdiomaMant)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotones.Location = New System.Drawing.Point(434, 0)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(26, 237)
            Me.pnlBotones.TabIndex = 1
            '
            'pnlIdiomaDel
            '
            Me.pnlIdiomaDel.Controls.Add(Me.btnEliminarRasgo)
            Me.pnlIdiomaDel.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlIdiomaDel.Location = New System.Drawing.Point(0, 53)
            Me.pnlIdiomaDel.Name = "pnlIdiomaDel"
            Me.pnlIdiomaDel.Size = New System.Drawing.Size(26, 27)
            Me.pnlIdiomaDel.TabIndex = 93
            '
            'btnEliminarRasgo
            '
            Me.btnEliminarRasgo.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarRasgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarRasgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarRasgo.Location = New System.Drawing.Point(0, 0)
            Me.btnEliminarRasgo.Name = "btnEliminarRasgo"
            Me.btnEliminarRasgo.Size = New System.Drawing.Size(25, 26)
            Me.btnEliminarRasgo.TabIndex = 89
            Me.btnEliminarRasgo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlIdiomaMant
            '
            Me.pnlIdiomaMant.Controls.Add(Me.btnAgregarIdioma)
            Me.pnlIdiomaMant.Controls.Add(Me.btnModRasgo)
            Me.pnlIdiomaMant.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlIdiomaMant.Location = New System.Drawing.Point(0, 0)
            Me.pnlIdiomaMant.Name = "pnlIdiomaMant"
            Me.pnlIdiomaMant.Size = New System.Drawing.Size(26, 53)
            Me.pnlIdiomaMant.TabIndex = 94
            '
            'btnAgregarIdioma
            '
            Me.btnAgregarIdioma.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregarIdioma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAgregarIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarIdioma.Location = New System.Drawing.Point(0, 1)
            Me.btnAgregarIdioma.Name = "btnAgregarIdioma"
            Me.btnAgregarIdioma.Size = New System.Drawing.Size(25, 26)
            Me.btnAgregarIdioma.TabIndex = 91
            Me.btnAgregarIdioma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnModRasgo
            '
            Me.btnModRasgo.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModRasgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnModRasgo.Location = New System.Drawing.Point(0, 26)
            Me.btnModRasgo.Name = "btnModRasgo"
            Me.btnModRasgo.Size = New System.Drawing.Size(25, 26)
            Me.btnModRasgo.TabIndex = 92
            Me.btnModRasgo.UseVisualStyleBackColor = True
            '
            'DataGridViewImageColumn1
            '
            Me.DataGridViewImageColumn1.HeaderText = ""
            Me.DataGridViewImageColumn1.Image = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
            Me.DataGridViewImageColumn1.ReadOnly = True
            Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewImageColumn1.Width = 30
            '
            'DataGridViewImageColumn2
            '
            Me.DataGridViewImageColumn2.HeaderText = ""
            Me.DataGridViewImageColumn2.Image = Global.APPControls.My.Resources.Resources.delete_32
            Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
            Me.DataGridViewImageColumn2.ReadOnly = True
            Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
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
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "id"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 20
            '
            'col_idioma_id
            '
            Me.col_idioma_id.DataPropertyName = "IdiomaId"
            Me.col_idioma_id.HeaderText = "IdiomaId"
            Me.col_idioma_id.Name = "col_idioma_id"
            Me.col_idioma_id.ReadOnly = True
            Me.col_idioma_id.Visible = False
            Me.col_idioma_id.Width = 20
            '
            'col_nro_ing
            '
            Me.col_nro_ing.DataPropertyName = "NumIngreso"
            Me.col_nro_ing.HeaderText = "N° Ing"
            Me.col_nro_ing.Name = "col_nro_ing"
            Me.col_nro_ing.ReadOnly = True
            Me.col_nro_ing.Width = 50
            '
            'col_ing_nro_inpe
            '
            Me.col_ing_nro_inpe.DataPropertyName = "IngresoNroInpe"
            Me.col_ing_nro_inpe.HeaderText = "N° Ing"
            Me.col_ing_nro_inpe.Name = "col_ing_nro_inpe"
            Me.col_ing_nro_inpe.ReadOnly = True
            Me.col_ing_nro_inpe.Width = 50
            '
            'col_idioma
            '
            Me.col_idioma.DataPropertyName = "IdiomaStr"
            Me.col_idioma.HeaderText = "Idioma"
            Me.col_idioma.Name = "col_idioma"
            Me.col_idioma.ReadOnly = True
            Me.col_idioma.Width = 200
            '
            'col_idi_dom_id
            '
            Me.col_idi_dom_id.DataPropertyName = "NivelDominioId"
            Me.col_idi_dom_id.HeaderText = "DominioIdiomaId"
            Me.col_idi_dom_id.Name = "col_idi_dom_id"
            Me.col_idi_dom_id.ReadOnly = True
            Me.col_idi_dom_id.Visible = False
            '
            'col_niv_dom
            '
            Me.col_niv_dom.DataPropertyName = "NivelDominioStr"
            Me.col_niv_dom.HeaderText = "Dominio"
            Me.col_niv_dom.Name = "col_niv_dom"
            Me.col_niv_dom.ReadOnly = True
            '
            'uscIdiomaInterno
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgvIdiomas)
            Me.Controls.Add(Me.pnlBotones)
            Me.Name = "uscIdiomaInterno"
            Me.Size = New System.Drawing.Size(460, 237)
            CType(Me.dgvIdiomas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBotones.ResumeLayout(False)
            Me.pnlIdiomaDel.ResumeLayout(False)
            Me.pnlIdiomaMant.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvIdiomas As System.Windows.Forms.DataGridView
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnAgregarIdioma As System.Windows.Forms.Button
        Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents btnModRasgo As System.Windows.Forms.Button
        Friend WithEvents pnlIdiomaDel As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarRasgo As System.Windows.Forms.Button
        Friend WithEvents pnlIdiomaMant As System.Windows.Forms.Panel
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_idioma_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nro_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro_inpe As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_idioma As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_idi_dom_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_niv_dom As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace