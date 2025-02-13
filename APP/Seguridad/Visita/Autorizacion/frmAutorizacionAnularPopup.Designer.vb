Namespace Visita.Autorizacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmAutorizacionAnularPopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dtpFechaDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtIntApeNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox3)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel4)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(580, 466)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnOK)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(380, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(200, 49)
            Me.Panel1.TabIndex = 87
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(102, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 86
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(2, 4)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 85
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 417)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(580, 49)
            Me.Panel2.TabIndex = 0
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.dgwGrilla)
            Me.GroupBox3.Controls.Add(Me.Panel5)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox3.Location = New System.Drawing.Point(0, 102)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(580, 315)
            Me.GroupBox3.TabIndex = 87
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Seleccione los visitantes"
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.col_id, Me.Column1, Me.Column4, Me.Column2, Me.Column3})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(3, 16)
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(574, 243)
            Me.dgwGrilla.TabIndex = 86
            Me.dgwGrilla.VisibleCampos = False
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "SeleccionarCheck"
            Me.Column5.HeaderText = ""
            Me.Column5.Name = "Column5"
            Me.Column5.Width = 35
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "VisitanteID"
            Me.Column1.HeaderText = "VisitanteID"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Visible = False
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "VisitanteApeNom"
            Me.Column4.HeaderText = "Visitante"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 250
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "ParentescoID"
            Me.Column2.HeaderText = "ParentescoID"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Visible = False
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "Parentesco"
            Me.Column3.HeaderText = "Parentesco"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 150
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.txtObs)
            Me.Panel5.Controls.Add(Me.Label7)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(3, 259)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(574, 53)
            Me.Panel5.TabIndex = 87
            '
            'txtObs
            '
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObs.Location = New System.Drawing.Point(95, 0)
            Me.txtObs.MaxLength = 500
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Size = New System.Drawing.Size(479, 53)
            Me.txtObs.TabIndex = 84
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label7.Location = New System.Drawing.Point(0, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(95, 53)
            Me.Label7.TabIndex = 85
            Me.Label7.Text = "Observacion :"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.Label3)
            Me.Panel4.Controls.Add(Me.dtpFechaDoc)
            Me.Panel4.Controls.Add(Me.txtDoc)
            Me.Panel4.Controls.Add(Me.Label5)
            Me.Panel4.Controls.Add(Me.Label6)
            Me.Panel4.Controls.Add(Me.txtIntApeNom)
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(580, 102)
            Me.Panel4.TabIndex = 88
            '
            'Label3
            '
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label3.Location = New System.Drawing.Point(12, 32)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(540, 3)
            Me.Label3.TabIndex = 89
            '
            'dtpFechaDoc
            '
            Me.dtpFechaDoc.Location = New System.Drawing.Point(153, 68)
            Me.dtpFechaDoc.Name = "dtpFechaDoc"
            Me.dtpFechaDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaDoc.TabIndex = 88
            Me.dtpFechaDoc.Value = "/  /"
            Me.dtpFechaDoc.ValueLong = CType(0, Long)
            '
            'txtDoc
            '
            Me.txtDoc._BloquearPaste = False
            Me.txtDoc._SeleccionarTodo = False
            Me.txtDoc.Location = New System.Drawing.Point(153, 42)
            Me.txtDoc.Name = "txtDoc"
            Me.txtDoc.Size = New System.Drawing.Size(386, 20)
            Me.txtDoc.TabIndex = 87
            Me.txtDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(59, 45)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(68, 13)
            Me.Label5.TabIndex = 86
            Me.Label5.Text = "Documento :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(61, 68)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(69, 13)
            Me.Label6.TabIndex = 83
            Me.Label6.Text = "Fecha Doc. :"
            '
            'txtIntApeNom
            '
            Me.txtIntApeNom._BloquearPaste = False
            Me.txtIntApeNom._SeleccionarTodo = False
            Me.txtIntApeNom.Location = New System.Drawing.Point(64, 6)
            Me.txtIntApeNom.Name = "txtIntApeNom"
            Me.txtIntApeNom.ReadOnly = True
            Me.txtIntApeNom.Size = New System.Drawing.Size(475, 20)
            Me.txtIntApeNom.TabIndex = 82
            Me.txtIntApeNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtIntApeNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 13)
            Me.Label2.TabIndex = 81
            Me.Label2.Text = "Interno :"
            '
            'frmAutorizacionAnularPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(580, 466)
            Me.Name = "frmAutorizacionAnularPopup"
            Me.Text = "Anular Autorizacion"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtIntApeNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label

    End Class
End Namespace