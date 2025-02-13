Namespace Registro.Main.Antecedentes
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscaInternoPopup
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
            Me.components = New System.ComponentModel.Container()
            Me.dgwInternos = New System.Windows.Forms.DataGridView()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtCodInterno = New System.Windows.Forms.TextBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNombres = New System.Windows.Forms.TextBox()
            Me.txtApeMat = New System.Windows.Forms.TextBox()
            Me.txtApePat = New System.Windows.Forms.TextBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lblTotalFila = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblInternoSel = New System.Windows.Forms.Label()
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.rdbPD = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbPF = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbPI = New Legolas.APPUIComponents.myRadioButton()
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.gbxFormChildContainer.SuspendLayout()
            CType(Me.dgwInternos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgwInternos)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(874, 494)
            '
            'dgwInternos
            '
            Me.dgwInternos.AllowUserToAddRows = False
            Me.dgwInternos.AllowUserToDeleteRows = False
            Me.dgwInternos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwInternos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_id, Me.col_cod, Me.col_ape_pat, Me.col_ape_mat, Me.col_nom, Me.col_est_int})
            Me.dgwInternos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwInternos.Location = New System.Drawing.Point(0, 91)
            Me.dgwInternos.MultiSelect = False
            Me.dgwInternos.Name = "dgwInternos"
            Me.dgwInternos.ReadOnly = True
            Me.dgwInternos.RowHeadersVisible = False
            Me.dgwInternos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwInternos.Size = New System.Drawing.Size(700, 357)
            Me.dgwInternos.TabIndex = 0
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "Codigo"
            Me.col_int_id.HeaderText = "InternoId"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "CodigoRP"
            Me.col_cod.HeaderText = "Cod. Interno"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_ape_pat.HeaderText = "Primer Apellido"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.Width = 150
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_ape_mat.HeaderText = "Segundo Ap."
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.Width = 150
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Width = 200
            '
            'col_est_int
            '
            Me.col_est_int.DataPropertyName = "EstadoNombreReadonly"
            Me.col_est_int.HeaderText = "Estado"
            Me.col_est_int.Name = "col_est_int"
            Me.col_est_int.ReadOnly = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtCodInterno)
            Me.GroupBox1.Controls.Add(Me.btnBuscar)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtNombres)
            Me.GroupBox1.Controls.Add(Me.txtApeMat)
            Me.GroupBox1.Controls.Add(Me.txtApePat)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(874, 91)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Criterio de búsqueda"
            '
            'txtCodInterno
            '
            Me.txtCodInterno.Location = New System.Drawing.Point(116, 16)
            Me.txtCodInterno.Name = "txtCodInterno"
            Me.txtCodInterno.Size = New System.Drawing.Size(152, 20)
            Me.txtCodInterno.TabIndex = 9
            '
            'btnBuscar
            '
            Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnBuscar.Image = Global.SIPPOPE.My.Resources.Resources.view
            Me.btnBuscar.Location = New System.Drawing.Point(791, 15)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(80, 66)
            Me.btnBuscar.TabIndex = 3
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(32, 20)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(78, 13)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Código interno:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(435, 44)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(68, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Segundo Ap.:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(32, 68)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(58, 13)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Nombre(s):"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(32, 44)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(66, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Primer Ap.:"
            '
            'txtNombres
            '
            Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombres.Location = New System.Drawing.Point(115, 65)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.Size = New System.Drawing.Size(669, 20)
            Me.txtNombres.TabIndex = 2
            '
            'txtApeMat
            '
            Me.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApeMat.Location = New System.Drawing.Point(509, 41)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(275, 20)
            Me.txtApeMat.TabIndex = 1
            '
            'txtApePat
            '
            Me.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApePat.Location = New System.Drawing.Point(115, 41)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(275, 20)
            Me.txtApePat.TabIndex = 0
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.lblTotalFila)
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 448)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(874, 46)
            Me.Panel2.TabIndex = 88
            '
            'lblTotalFila
            '
            Me.lblTotalFila.AutoSize = True
            Me.lblTotalFila.Location = New System.Drawing.Point(3, 1)
            Me.lblTotalFila.Name = "lblTotalFila"
            Me.lblTotalFila.Size = New System.Drawing.Size(126, 13)
            Me.lblTotalFila.TabIndex = 87
            Me.lblTotalFila.Text = "Total filas encontradas: 0"
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(773, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 86
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(678, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 85
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.lblInternoSel)
            Me.Panel1.Controls.Add(Me.lblCodInterno)
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.UscFotografia_2v1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(700, 91)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(174, 357)
            Me.Panel1.TabIndex = 89
            '
            'lblInternoSel
            '
            Me.lblInternoSel.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblInternoSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInternoSel.Location = New System.Drawing.Point(0, 294)
            Me.lblInternoSel.Name = "lblInternoSel"
            Me.lblInternoSel.Size = New System.Drawing.Size(174, 60)
            Me.lblInternoSel.TabIndex = 91
            Me.lblInternoSel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(0, 268)
            Me.lblCodInterno.Name = "lblCodInterno"
            Me.lblCodInterno.Size = New System.Drawing.Size(174, 26)
            Me.lblCodInterno.TabIndex = 91
            Me.lblCodInterno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.rdbPD)
            Me.Panel4.Controls.Add(Me.rdbPF)
            Me.Panel4.Controls.Add(Me.rdbPI)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Location = New System.Drawing.Point(0, 245)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(174, 23)
            Me.Panel4.TabIndex = 92
            '
            'rdbPD
            '
            Me.rdbPD.AutoSize = True
            Me.rdbPD.Location = New System.Drawing.Point(111, 3)
            Me.rdbPD.Name = "rdbPD"
            Me.rdbPD.Size = New System.Drawing.Size(40, 17)
            Me.rdbPD.TabIndex = 2
            Me.rdbPD.Text = "PD"
            Me.rdbPD.UseVisualStyleBackColor = True
            '
            'rdbPF
            '
            Me.rdbPF.AutoSize = True
            Me.rdbPF.Checked = True
            Me.rdbPF.Location = New System.Drawing.Point(69, 3)
            Me.rdbPF.Name = "rdbPF"
            Me.rdbPF.Size = New System.Drawing.Size(38, 17)
            Me.rdbPF.TabIndex = 1
            Me.rdbPF.TabStop = True
            Me.rdbPF.Text = "PF"
            Me.rdbPF.UseVisualStyleBackColor = True
            '
            'rdbPI
            '
            Me.rdbPI.AutoSize = True
            Me.rdbPI.Location = New System.Drawing.Point(30, 3)
            Me.rdbPI.Name = "rdbPI"
            Me.rdbPI.Size = New System.Drawing.Size(35, 17)
            Me.rdbPI.TabIndex = 0
            Me.rdbPI.Text = "PI"
            Me.rdbPI.UseVisualStyleBackColor = True
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = False
            Me.UscFotografia_2v1._EnabledDobleClick = True
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = True
            Me.UscFotografia_2v1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(0, 0)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(174, 245)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 93
            '
            'Timer1
            '
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'frmBuscaInternoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(874, 494)
            Me.Name = "frmBuscaInternoPopup"
            Me.Text = "Buscar interno"
            Me.gbxFormChildContainer.ResumeLayout(False)
            CType(Me.dgwInternos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwInternos As System.Windows.Forms.DataGridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNombres As System.Windows.Forms.TextBox
        Friend WithEvents txtApeMat As System.Windows.Forms.TextBox
        Friend WithEvents txtApePat As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblInternoSel As System.Windows.Forms.Label
        Friend WithEvents lblCodInterno As System.Windows.Forms.Label
        Friend WithEvents lblTotalFila As System.Windows.Forms.Label
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents rdbPD As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbPF As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbPI As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtCodInterno As System.Windows.Forms.TextBox
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    End Class
End Namespace