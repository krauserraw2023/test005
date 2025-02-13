Namespace Visita.Visitante


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmExtraordinarioMenoresPopup
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlGrilla = New System.Windows.Forms.Panel()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_aut_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_vis_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eda = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_par_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_par_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlGrilla.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.pnlGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(617, 285)
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.lblReg)
            Me.Panel2.Controls.Add(Me.Panel3)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 235)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(617, 50)
            Me.Panel2.TabIndex = 65
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblReg.Location = New System.Drawing.Point(0, 0)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(75, 50)
            Me.lblReg.TabIndex = 106
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnAceptar)
            Me.Panel3.Controls.Add(Me.btnCancel)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(396, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(221, 50)
            Me.Panel3.TabIndex = 105
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(3, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(105, 43)
            Me.btnAceptar.TabIndex = 103
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(112, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(105, 43)
            Me.btnCancel.TabIndex = 104
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlGrilla
            '
            Me.pnlGrilla.Controls.Add(Me.dgwGrilla)
            Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrilla.Location = New System.Drawing.Point(0, 0)
            Me.pnlGrilla.Name = "pnlGrilla"
            Me.pnlGrilla.Size = New System.Drawing.Size(617, 235)
            Me.pnlGrilla.TabIndex = 68
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_aut_id, Me.col_det_id, Me.col_chk, Me.col_vis_id, Me.col_tip_doc, Me.Column1, Me.col_num_doc, Me.col_ape, Me.col_ape_nom, Me.col_nom, Me.col_eda, Me.col_par_id, Me.col_par_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(617, 235)
            Me.dgwGrilla.TabIndex = 39
            '
            'col_aut_id
            '
            Me.col_aut_id.DataPropertyName = "Codigo"
            Me.col_aut_id.DividerWidth = 1
            Me.col_aut_id.HeaderText = "CodigoID"
            Me.col_aut_id.Name = "col_aut_id"
            Me.col_aut_id.ReadOnly = True
            Me.col_aut_id.Visible = False
            '
            'col_det_id
            '
            Me.col_det_id.DataPropertyName = "CalendarioDetalleID"
            Me.col_det_id.HeaderText = "CalendarioDetalleID"
            Me.col_det_id.Name = "col_det_id"
            Me.col_det_id.Visible = False
            '
            'col_chk
            '
            Me.col_chk.HeaderText = ""
            Me.col_chk.Name = "col_chk"
            Me.col_chk.Visible = False
            Me.col_chk.Width = 35
            '
            'col_vis_id
            '
            Me.col_vis_id.DataPropertyName = "VisitanteID"
            Me.col_vis_id.HeaderText = "VisitanteID"
            Me.col_vis_id.Name = "col_vis_id"
            Me.col_vis_id.Visible = False
            '
            'col_tip_doc
            '
            Me.col_tip_doc.DataPropertyName = "IDTipoDocumentoVisitante"
            Me.col_tip_doc.HeaderText = "IDTipoDocumentoVisitante"
            Me.col_tip_doc.Name = "col_tip_doc"
            Me.col_tip_doc.Visible = False
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "VisitanteTipoDocumentoNombre"
            Me.Column1.HeaderText = "Tipo Doc."
            Me.Column1.Name = "Column1"
            '
            'col_num_doc
            '
            Me.col_num_doc.DataPropertyName = "VisitanteNumeroDocumento"
            Me.col_num_doc.HeaderText = "Num. Doc."
            Me.col_num_doc.Name = "col_num_doc"
            Me.col_num_doc.ReadOnly = True
            '
            'col_ape
            '
            Me.col_ape.DataPropertyName = "VisitantePrimerApe"
            Me.col_ape.HeaderText = "Primer Apellido"
            Me.col_ape.Name = "col_ape"
            Me.col_ape.ReadOnly = True
            Me.col_ape.Width = 120
            '
            'col_ape_nom
            '
            Me.col_ape_nom.DataPropertyName = "VisitanteSegundoApe"
            Me.col_ape_nom.HeaderText = "Segundo Apellido"
            Me.col_ape_nom.Name = "col_ape_nom"
            Me.col_ape_nom.Width = 120
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "VisitanteNombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Width = 120
            '
            'col_eda
            '
            Me.col_eda.DataPropertyName = "VisitanteEdad"
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.col_eda.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_eda.HeaderText = "Edad"
            Me.col_eda.Name = "col_eda"
            Me.col_eda.Width = 50
            '
            'col_par_id
            '
            Me.col_par_id.DataPropertyName = "ParentescoID"
            Me.col_par_id.HeaderText = "ParentescoID"
            Me.col_par_id.Name = "col_par_id"
            Me.col_par_id.Visible = False
            '
            'col_par_nom
            '
            Me.col_par_nom.DataPropertyName = "Parentesco"
            Me.col_par_nom.HeaderText = "Parentesco"
            Me.col_par_nom.Name = "col_par_nom"
            Me.col_par_nom.Visible = False
            '
            'frmExtraordinarioMenoresPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(617, 285)
            Me.Name = "frmExtraordinarioMenoresPopup"
            Me.Text = "Visitantes Menores de Edad Autorizados - Extraordinario"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.pnlGrilla.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents pnlGrilla As System.Windows.Forms.Panel
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents col_aut_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_vis_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_eda As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_par_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_par_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace