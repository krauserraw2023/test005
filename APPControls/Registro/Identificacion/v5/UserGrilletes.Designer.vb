﻿Namespace Registro.Identificacion.v5
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscGrilletes
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscGrilletes))
            Me.dgwGrillete = New System.Windows.Forms.DataGridView()
            Me.pnlCabeceraAlias = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pnlAliasAdd = New System.Windows.Forms.Panel()
            Me.btnModGrilletes = New System.Windows.Forms.Button()
            Me.btnAddGrilletes = New System.Windows.Forms.Button()
            Me.pnlAliasEliminar = New System.Windows.Forms.Panel()
            Me.btnEliGrilletes = New System.Windows.Forms.Button()
            Me.col_ali_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro_inpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_ben = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgwGrillete, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlCabeceraAlias.SuspendLayout()
            Me.pnlAliasAdd.SuspendLayout()
            Me.pnlAliasEliminar.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrillete
            '
            Me.dgwGrillete.AllowUserToAddRows = False
            Me.dgwGrillete.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillete.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrillete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ali_id, Me.DataGridViewTextBoxColumn15, Me.col_ing_nro, Me.col_ing_nro_inpe, Me.col_ing_id, Me.DataGridViewTextBoxColumn19, Me.col_fec_ini, Me.col_fec_fin, Me.col_tip_ben})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillete.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrillete.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillete.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillete.Location = New System.Drawing.Point(0, 40)
            Me.dgwGrillete.MultiSelect = False
            Me.dgwGrillete.Name = "dgwGrillete"
            Me.dgwGrillete.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillete.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrillete.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillete.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrillete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillete.Size = New System.Drawing.Size(805, 332)
            Me.dgwGrillete.TabIndex = 5
            '
            'pnlCabeceraAlias
            '
            Me.pnlCabeceraAlias.Controls.Add(Me.Label1)
            Me.pnlCabeceraAlias.Controls.Add(Me.pnlAliasAdd)
            Me.pnlCabeceraAlias.Controls.Add(Me.pnlAliasEliminar)
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
            Me.Label1.Location = New System.Drawing.Point(6, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(53, 13)
            Me.Label1.TabIndex = 93
            Me.Label1.Text = "Grilletes"
            '
            'pnlAliasAdd
            '
            Me.pnlAliasAdd.Controls.Add(Me.btnModGrilletes)
            Me.pnlAliasAdd.Controls.Add(Me.btnAddGrilletes)
            Me.pnlAliasAdd.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAliasAdd.Location = New System.Drawing.Point(520, 0)
            Me.pnlAliasAdd.Name = "pnlAliasAdd"
            Me.pnlAliasAdd.Size = New System.Drawing.Size(196, 40)
            Me.pnlAliasAdd.TabIndex = 91
            '
            'btnModGrilletes
            '
            Me.btnModGrilletes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModGrilletes.Image = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModGrilletes.Location = New System.Drawing.Point(101, 0)
            Me.btnModGrilletes.Name = "btnModGrilletes"
            Me.btnModGrilletes.Size = New System.Drawing.Size(90, 40)
            Me.btnModGrilletes.TabIndex = 89
            Me.btnModGrilletes.Text = "Modificar"
            Me.btnModGrilletes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAddGrilletes
            '
            Me.btnAddGrilletes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddGrilletes.Image = CType(resources.GetObject("btnAddGrilletes.Image"), System.Drawing.Image)
            Me.btnAddGrilletes.Location = New System.Drawing.Point(5, 0)
            Me.btnAddGrilletes.Name = "btnAddGrilletes"
            Me.btnAddGrilletes.Size = New System.Drawing.Size(88, 40)
            Me.btnAddGrilletes.TabIndex = 88
            Me.btnAddGrilletes.Text = "&Agregar"
            Me.btnAddGrilletes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlAliasEliminar
            '
            Me.pnlAliasEliminar.Controls.Add(Me.btnEliGrilletes)
            Me.pnlAliasEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAliasEliminar.Location = New System.Drawing.Point(716, 0)
            Me.pnlAliasEliminar.Name = "pnlAliasEliminar"
            Me.pnlAliasEliminar.Size = New System.Drawing.Size(89, 40)
            Me.pnlAliasEliminar.TabIndex = 90
            '
            'btnEliGrilletes
            '
            Me.btnEliGrilletes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliGrilletes.Image = CType(resources.GetObject("btnEliGrilletes.Image"), System.Drawing.Image)
            Me.btnEliGrilletes.Location = New System.Drawing.Point(1, 0)
            Me.btnEliGrilletes.Name = "btnEliGrilletes"
            Me.btnEliGrilletes.Size = New System.Drawing.Size(88, 40)
            Me.btnEliGrilletes.TabIndex = 90
            Me.btnEliGrilletes.Text = "&Eliminar"
            Me.btnEliGrilletes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'col_ali_id
            '
            Me.col_ali_id.DataPropertyName = "Codigo"
            Me.col_ali_id.HeaderText = "ID"
            Me.col_ali_id.Name = "col_ali_id"
            Me.col_ali_id.ReadOnly = True
            Me.col_ali_id.Visible = False
            '
            'DataGridViewTextBoxColumn15
            '
            Me.DataGridViewTextBoxColumn15.DataPropertyName = "InternoID"
            Me.DataGridViewTextBoxColumn15.HeaderText = "InternoID"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.ReadOnly = True
            Me.DataGridViewTextBoxColumn15.Visible = False
            '
            'col_ing_nro
            '
            Me.col_ing_nro.DataPropertyName = "IngresoNro"
            Me.col_ing_nro.HeaderText = "Nro Ingreso "
            Me.col_ing_nro.Name = "col_ing_nro"
            Me.col_ing_nro.ReadOnly = True
            Me.col_ing_nro.ToolTipText = "Ingreso Penal"
            Me.col_ing_nro.Width = 60
            '
            'col_ing_nro_inpe
            '
            Me.col_ing_nro_inpe.DataPropertyName = "IngresoNroInpe"
            Me.col_ing_nro_inpe.HeaderText = "Nro Ingreso"
            Me.col_ing_nro_inpe.Name = "col_ing_nro_inpe"
            Me.col_ing_nro_inpe.ReadOnly = True
            Me.col_ing_nro_inpe.ToolTipText = "Ingreso Inpe"
            Me.col_ing_nro_inpe.Width = 50
            '
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "IngresoID"
            Me.col_ing_id.HeaderText = "IngresoID"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
            '
            'DataGridViewTextBoxColumn19
            '
            Me.DataGridViewTextBoxColumn19.DataPropertyName = "Nombres"
            Me.DataGridViewTextBoxColumn19.HeaderText = "Nº de Documento"
            Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
            Me.DataGridViewTextBoxColumn19.ReadOnly = True
            Me.DataGridViewTextBoxColumn19.Width = 180
            '
            'col_fec_ini
            '
            Me.col_fec_ini.HeaderText = "Fecha Inicio"
            Me.col_fec_ini.Name = "col_fec_ini"
            Me.col_fec_ini.ReadOnly = True
            '
            'col_fec_fin
            '
            Me.col_fec_fin.HeaderText = "Fecha Fin"
            Me.col_fec_fin.Name = "col_fec_fin"
            Me.col_fec_fin.ReadOnly = True
            '
            'col_tip_ben
            '
            Me.col_tip_ben.HeaderText = "Tipo de Beneficio"
            Me.col_tip_ben.Name = "col_tip_ben"
            Me.col_tip_ben.ReadOnly = True
            Me.col_tip_ben.Width = 150
            '
            'uscGrilletes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrillete)
            Me.Controls.Add(Me.pnlCabeceraAlias)
            Me.Name = "uscGrilletes"
            Me.Size = New System.Drawing.Size(805, 372)
            CType(Me.dgwGrillete, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlCabeceraAlias.ResumeLayout(False)
            Me.pnlCabeceraAlias.PerformLayout()
            Me.pnlAliasAdd.ResumeLayout(False)
            Me.pnlAliasEliminar.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrillete As System.Windows.Forms.DataGridView
        Friend WithEvents pnlCabeceraAlias As System.Windows.Forms.Panel
        Friend WithEvents pnlAliasAdd As System.Windows.Forms.Panel
        Friend WithEvents btnModGrilletes As System.Windows.Forms.Button
        Friend WithEvents btnAddGrilletes As System.Windows.Forms.Button
        Friend WithEvents pnlAliasEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliGrilletes As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents col_ali_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro_inpe As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ini As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_fin As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_ben As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace
