Namespace Visita.Autorizacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmAutorizacionPopup
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtIntApeNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.UscLabelBusqueda1 = New APPControls.uscLabelBusqueda()
            Me.txtDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbbParentesco = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox2)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(557, 353)
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(19, 28)
            Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 16)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Visitante :"
            '
            'txtIntApeNom
            '
            Me.txtIntApeNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIntApeNom._BloquearPaste = False
            Me.txtIntApeNom._SeleccionarTodo = False
            Me.txtIntApeNom.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtIntApeNom.Location = New System.Drawing.Point(4, 19)
            Me.txtIntApeNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtIntApeNom.Name = "txtIntApeNom"
            Me.txtIntApeNom.ReadOnly = True
            Me.txtIntApeNom.Size = New System.Drawing.Size(532, 22)
            Me.txtIntApeNom.TabIndex = 1
            Me.txtIntApeNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtIntApeNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'UscLabelBusqueda1
            '
            Me.UscLabelBusqueda1._Codigo = 0
            Me.UscLabelBusqueda1._Value = "[SELECCIONE]"
            Me.UscLabelBusqueda1._Visible_Add = False
            Me.UscLabelBusqueda1._Visible_Buscar = True
            Me.UscLabelBusqueda1._Visible_Eliminar = False
            Me.UscLabelBusqueda1.Enabled = False
            Me.UscLabelBusqueda1.Location = New System.Drawing.Point(140, 23)
            Me.UscLabelBusqueda1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.UscLabelBusqueda1.Name = "UscLabelBusqueda1"
            Me.UscLabelBusqueda1.Size = New System.Drawing.Size(388, 21)
            Me.UscLabelBusqueda1.TabIndex = 6
            '
            'txtDoc
            '
            Me.txtDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDoc._BloquearPaste = False
            Me.txtDoc._SeleccionarTodo = False
            Me.txtDoc.Location = New System.Drawing.Point(140, 90)
            Me.txtDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtDoc.Name = "txtDoc"
            Me.txtDoc.Size = New System.Drawing.Size(180, 22)
            Me.txtDoc.TabIndex = 81
            Me.txtDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(19, 94)
            Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(82, 16)
            Me.Label5.TabIndex = 80
            Me.Label5.Text = "Documento :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(328, 94)
            Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(82, 16)
            Me.Label6.TabIndex = 77
            Me.Label6.Text = "Fecha Doc. :"
            '
            'dtpFechaDoc
            '
            Me.dtpFechaDoc.Location = New System.Drawing.Point(416, 90)
            Me.dtpFechaDoc.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.dtpFechaDoc.Name = "dtpFechaDoc"
            Me.dtpFechaDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaDoc.TabIndex = 76
            Me.dtpFechaDoc.Value = "/  /"
            Me.dtpFechaDoc.ValueLong = CType(0, Long)
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Location = New System.Drawing.Point(140, 126)
            Me.txtObs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtObs.MaxLength = 500
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Size = New System.Drawing.Size(387, 79)
            Me.txtObs.TabIndex = 78
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(19, 126)
            Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(90, 16)
            Me.Label7.TabIndex = 79
            Me.Label7.Text = "Observacion :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(19, 60)
            Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(82, 16)
            Me.Label8.TabIndex = 84
            Me.Label8.Text = "Parentesco :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtIntApeNom)
            Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
            Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.GroupBox1.Size = New System.Drawing.Size(540, 49)
            Me.GroupBox1.TabIndex = 85
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Interno"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.UscLabelBusqueda1)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.txtObs)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtDoc)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.dtpFechaDoc)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.cbbParentesco)
            Me.GroupBox2.Location = New System.Drawing.Point(4, 55)
            Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.GroupBox2.Size = New System.Drawing.Size(540, 224)
            Me.GroupBox2.TabIndex = 86
            Me.GroupBox2.TabStop = False
            '
            'cbbParentesco
            '
            Me.cbbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbParentesco.FormattingEnabled = True
            Me.cbbParentesco.Location = New System.Drawing.Point(140, 57)
            Me.cbbParentesco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbbParentesco.Name = "cbbParentesco"
            Me.cbbParentesco.Size = New System.Drawing.Size(387, 24)
            Me.cbbParentesco.TabIndex = 87
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnOK)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(290, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(267, 60)
            Me.Panel1.TabIndex = 87
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(136, 5)
            Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(129, 49)
            Me.btnCancel.TabIndex = 86
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(3, 5)
            Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(125, 49)
            Me.btnOK.TabIndex = 85
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 293)
            Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(557, 60)
            Me.Panel2.TabIndex = 0
            '
            'frmAutorizacionPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.ClientSize = New System.Drawing.Size(557, 353)
            Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
            Me.Name = "frmAutorizacionPopup"
            Me.Text = "Actualizar Autorizacion"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtIntApeNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents UscLabelBusqueda1 As APPControls.uscLabelBusqueda
        Friend WithEvents txtDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents cbbParentesco As Legolas.APPUIComponents.MyComboBox

    End Class
End Namespace