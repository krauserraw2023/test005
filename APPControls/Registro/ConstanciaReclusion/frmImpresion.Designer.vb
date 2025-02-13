Namespace Registro.ConstanciaReclusion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmImpresion
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtNumeroCR = New System.Windows.Forms.TextBox()
            Me.txtNumeroTramite = New System.Windows.Forms.TextBox()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_imp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgwGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotones)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(529, 212)
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.Panel2)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 158)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(529, 54)
            Me.PnlBotones.TabIndex = 39
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(423, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(106, 54)
            Me.Panel2.TabIndex = 32
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(3, 6)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 31
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_item, Me.col_usuario, Me.Column1, Me.col_fec_imp})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 32)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(529, 126)
            Me.dgwGrilla.TabIndex = 40
            Me.dgwGrilla.VisibleCampos = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label11)
            Me.Panel1.Controls.Add(Me.txtNumeroCR)
            Me.Panel1.Controls.Add(Me.txtNumeroTramite)
            Me.Panel1.Controls.Add(Me.lblDistrito)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(529, 32)
            Me.Panel1.TabIndex = 41
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.Location = New System.Drawing.Point(238, 10)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(93, 13)
            Me.Label11.TabIndex = 111
            Me.Label11.Text = "N° de Constancia:"
            '
            'txtNumeroCR
            '
            Me.txtNumeroCR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCR.Location = New System.Drawing.Point(335, 6)
            Me.txtNumeroCR.MaxLength = 120
            Me.txtNumeroCR.Name = "txtNumeroCR"
            Me.txtNumeroCR.ReadOnly = True
            Me.txtNumeroCR.Size = New System.Drawing.Size(120, 20)
            Me.txtNumeroCR.TabIndex = 110
            '
            'txtNumeroTramite
            '
            Me.txtNumeroTramite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroTramite.Location = New System.Drawing.Point(90, 6)
            Me.txtNumeroTramite.MaxLength = 120
            Me.txtNumeroTramite.Name = "txtNumeroTramite"
            Me.txtNumeroTramite.ReadOnly = True
            Me.txtNumeroTramite.Size = New System.Drawing.Size(120, 20)
            Me.txtNumeroTramite.TabIndex = 3
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(12, 9)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(72, 13)
            Me.lblDistrito.TabIndex = 1
            Me.lblDistrito.Text = "N° de Trámite"
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "codigo"
            Me.col_codigo.HeaderText = "codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            Me.col_codigo.Width = 5
            '
            'col_item
            '
            Me.col_item.DataPropertyName = "item"
            Me.col_item.HeaderText = "N°. Impr."
            Me.col_item.Name = "col_item"
            Me.col_item.ReadOnly = True
            Me.col_item.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_item.Width = 40
            '
            'col_usuario
            '
            Me.col_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_usuario.DataPropertyName = "usuario"
            DataGridViewCellStyle1.Format = "d"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.col_usuario.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_usuario.HeaderText = "Apellidos y Nombres del Usuario"
            Me.col_usuario.Name = "col_usuario"
            Me.col_usuario.ReadOnly = True
            Me.col_usuario.ToolTipText = "Apellidos y Nombres del Usuario"
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "motivoImpresion"
            Me.Column1.HeaderText = "Motivo Re-impresión"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 130
            '
            'col_fec_imp
            '
            Me.col_fec_imp.DataPropertyName = "fechaImpresion"
            Me.col_fec_imp.HeaderText = "Fecha Re-impresión"
            Me.col_fec_imp.Name = "col_fec_imp"
            Me.col_fec_imp.ReadOnly = True
            Me.col_fec_imp.ToolTipText = "Fecha de expedición de la Constancia de Reclusión"
            Me.col_fec_imp.Width = 130
            '
            'frmImpresion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(529, 212)
            Me.Name = "frmImpresion"
            Me.Text = "Registro de Impresiones"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents PnlBotones As Panel
        Friend WithEvents btnCancel As Button
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel1 As Panel
        Friend WithEvents lblDistrito As Label
        Friend WithEvents txtNumeroTramite As TextBox
        Friend WithEvents Label11 As Label
        Friend WithEvents txtNumeroCR As TextBox
        Friend WithEvents Panel2 As Panel
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_item As DataGridViewTextBoxColumn
        Friend WithEvents col_usuario As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_imp As DataGridViewTextBoxColumn
    End Class

End Namespace
