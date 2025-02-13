Namespace Registro.Odontograma
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscOdontogramaMain_LM
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscOdontogramaMain_LM))
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.dgwOdontograma = New Legolas.APPUIComponents.myDatagridView()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro_inpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_reg_odt = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlAccionFotografia = New System.Windows.Forms.Panel()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminarOdont = New System.Windows.Forms.Button()
            Me.pnlAdd = New System.Windows.Forms.Panel()
            Me.btnModificarOdont = New System.Windows.Forms.Button()
            Me.btnAgregarOdont = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.AxCtlOdon1 = New AxCTLODONLib.AxCtlOdon()
            Me.Panel4.SuspendLayout()
            CType(Me.dgwOdontograma, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlAccionFotografia.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlAdd.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.AxCtlOdon1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel4
            '
            Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel4.Controls.Add(Me.dgwOdontograma)
            Me.Panel4.Controls.Add(Me.pnlAccionFotografia)
            Me.Panel4.Location = New System.Drawing.Point(599, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(252, 500)
            Me.Panel4.TabIndex = 4
            '
            'dgwOdontograma
            '
            Me.dgwOdontograma.AllowUserToAddRows = False
            Me.dgwOdontograma.AllowUserToDeleteRows = False
            Me.dgwOdontograma.AllowUserToResizeRows = False
            Me.dgwOdontograma.BackgroundColor = System.Drawing.Color.White
            Me.dgwOdontograma.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwOdontograma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwOdontograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwOdontograma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_num_ing, Me.col_ing_nro_inpe, Me.col_fec_reg_odt, Me.col_int_id, Me.col_ing_id, Me.col_pen_id, Me.col_reg_id})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwOdontograma.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwOdontograma.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgwOdontograma.Location = New System.Drawing.Point(0, 29)
            Me.dgwOdontograma.MultiSelect = False
            Me.dgwOdontograma.Name = "dgwOdontograma"
            Me.dgwOdontograma.ReadOnly = True
            Me.dgwOdontograma.RowHeadersVisible = False
            Me.dgwOdontograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwOdontograma.Size = New System.Drawing.Size(252, 468)
            Me.dgwOdontograma.TabIndex = 0
            Me.dgwOdontograma.VisibleCampos = False
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            '
            'col_num_ing
            '
            Me.col_num_ing.DataPropertyName = "NumeroIngreso"
            Me.col_num_ing.HeaderText = "N° Ing."
            Me.col_num_ing.Name = "col_num_ing"
            Me.col_num_ing.ReadOnly = True
            Me.col_num_ing.Width = 45
            '
            'col_ing_nro_inpe
            '
            Me.col_ing_nro_inpe.DataPropertyName = "IngresoNroInpe"
            Me.col_ing_nro_inpe.HeaderText = "N° Ing."
            Me.col_ing_nro_inpe.Name = "col_ing_nro_inpe"
            Me.col_ing_nro_inpe.ReadOnly = True
            Me.col_ing_nro_inpe.Width = 50
            '
            'col_fec_reg_odt
            '
            Me.col_fec_reg_odt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_fec_reg_odt.DataPropertyName = "FechaRegistroDate"
            Me.col_fec_reg_odt.HeaderText = "Fecha Registro"
            Me.col_fec_reg_odt.Name = "col_fec_reg_odt"
            Me.col_fec_reg_odt.ReadOnly = True
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoId"
            Me.col_int_id.HeaderText = "InternoId"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "IngresoId"
            Me.col_ing_id.HeaderText = "IngresoId"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalId"
            Me.col_pen_id.HeaderText = "PenalId"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionId"
            Me.col_reg_id.HeaderText = "RegionId"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'pnlAccionFotografia
            '
            Me.pnlAccionFotografia.Controls.Add(Me.pnlEliminar)
            Me.pnlAccionFotografia.Controls.Add(Me.pnlAdd)
            Me.pnlAccionFotografia.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccionFotografia.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccionFotografia.Name = "pnlAccionFotografia"
            Me.pnlAccionFotografia.Size = New System.Drawing.Size(252, 29)
            Me.pnlAccionFotografia.TabIndex = 1
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminarOdont)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(63, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(32, 29)
            Me.pnlEliminar.TabIndex = 1
            '
            'btnEliminarOdont
            '
            Me.btnEliminarOdont.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarOdont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarOdont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEliminarOdont.Location = New System.Drawing.Point(1, 1)
            Me.btnEliminarOdont.Name = "btnEliminarOdont"
            Me.btnEliminarOdont.Size = New System.Drawing.Size(29, 26)
            Me.btnEliminarOdont.TabIndex = 2
            Me.btnEliminarOdont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminarOdont.UseVisualStyleBackColor = True
            '
            'pnlAdd
            '
            Me.pnlAdd.Controls.Add(Me.btnModificarOdont)
            Me.pnlAdd.Controls.Add(Me.btnAgregarOdont)
            Me.pnlAdd.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlAdd.Location = New System.Drawing.Point(0, 0)
            Me.pnlAdd.Name = "pnlAdd"
            Me.pnlAdd.Size = New System.Drawing.Size(63, 29)
            Me.pnlAdd.TabIndex = 1
            '
            'btnModificarOdont
            '
            Me.btnModificarOdont.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificarOdont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnModificarOdont.Location = New System.Drawing.Point(33, 1)
            Me.btnModificarOdont.Name = "btnModificarOdont"
            Me.btnModificarOdont.Size = New System.Drawing.Size(29, 26)
            Me.btnModificarOdont.TabIndex = 11
            Me.btnModificarOdont.UseVisualStyleBackColor = True
            '
            'btnAgregarOdont
            '
            Me.btnAgregarOdont.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregarOdont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAgregarOdont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAgregarOdont.Location = New System.Drawing.Point(3, 1)
            Me.btnAgregarOdont.Name = "btnAgregarOdont"
            Me.btnAgregarOdont.Size = New System.Drawing.Size(29, 26)
            Me.btnAgregarOdont.TabIndex = 0
            Me.btnAgregarOdont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregarOdont.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.AxCtlOdon1)
            Me.Panel1.Enabled = False
            Me.Panel1.Location = New System.Drawing.Point(-1, -1)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(599, 499)
            Me.Panel1.TabIndex = 5
            '
            'AxCtlOdon1
            '
            Me.AxCtlOdon1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.AxCtlOdon1.Enabled = True
            Me.AxCtlOdon1.Location = New System.Drawing.Point(0, 0)
            Me.AxCtlOdon1.Name = "AxCtlOdon1"
            Me.AxCtlOdon1.OcxState = CType(resources.GetObject("AxCtlOdon1.OcxState"), System.Windows.Forms.AxHost.State)
            Me.AxCtlOdon1.Size = New System.Drawing.Size(599, 499)
            Me.AxCtlOdon1.TabIndex = 0
            '
            'uscOdontogramaMain_LM
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Panel4)
            Me.Name = "uscOdontogramaMain_LM"
            Me.Size = New System.Drawing.Size(854, 500)
            Me.Panel4.ResumeLayout(False)
            CType(Me.dgwOdontograma, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlAccionFotografia.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlAdd.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.AxCtlOdon1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents dgwOdontograma As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlAccionFotografia As System.Windows.Forms.Panel
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarOdont As System.Windows.Forms.Button
        Friend WithEvents pnlAdd As System.Windows.Forms.Panel
        Friend WithEvents btnModificarOdont As System.Windows.Forms.Button
        Friend WithEvents btnAgregarOdont As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro_inpe As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_reg_odt As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents AxCtlOdon1 As AxCTLODONLib.AxCtlOdon

    End Class
End Namespace