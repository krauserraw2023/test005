Namespace Registro.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDomicilioPopup
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblNroIngreso = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtReferencia = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtDireccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.cbbDomicilioDist = New System.Windows.Forms.ComboBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.cbbDomicilioProv = New System.Windows.Forms.ComboBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.cbbDomicilioDepa = New System.Windows.Forms.ComboBox()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(444, 215)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 169)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(444, 46)
            Me.Panel1.TabIndex = 1
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOK)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(252, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(192, 46)
            Me.Panel2.TabIndex = 7
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(95, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 97
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(1, 3)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 96
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.lblNroIngreso)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.txtReferencia)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.txtDireccion)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.Label15)
            Me.GroupBox2.Controls.Add(Me.cbbDomicilioDist)
            Me.GroupBox2.Controls.Add(Me.Label16)
            Me.GroupBox2.Controls.Add(Me.cbbDomicilioProv)
            Me.GroupBox2.Controls.Add(Me.Label17)
            Me.GroupBox2.Controls.Add(Me.cbbDomicilioDepa)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(444, 169)
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Dirección"
            '
            'lblNroIngreso
            '
            Me.lblNroIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNroIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroIngreso.Location = New System.Drawing.Point(89, 16)
            Me.lblNroIngreso.Name = "lblNroIngreso"
            Me.lblNroIngreso.Size = New System.Drawing.Size(205, 20)
            Me.lblNroIngreso.TabIndex = 9
            Me.lblNroIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(6, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(60, 13)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "N° Ingreso:"
            '
            'txtReferencia
            '
            Me.txtReferencia._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtReferencia._BloquearPaste = False
            Me.txtReferencia._SeleccionarTodo = False
            Me.txtReferencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReferencia.Location = New System.Drawing.Point(89, 140)
            Me.txtReferencia.Name = "txtReferencia"
            Me.txtReferencia.Size = New System.Drawing.Size(349, 20)
            Me.txtReferencia.TabIndex = 7
            Me.txtReferencia.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtReferencia.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 144)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(62, 13)
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "Referencia:"
            '
            'txtDireccion
            '
            Me.txtDireccion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDireccion._BloquearPaste = False
            Me.txtDireccion._SeleccionarTodo = False
            Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(89, 116)
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(349, 20)
            Me.txtDireccion.TabIndex = 7
            Me.txtDireccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDireccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(6, 118)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(55, 13)
            Me.Label14.TabIndex = 6
            Me.Label14.Text = "Dirección:"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New System.Drawing.Point(6, 95)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(45, 13)
            Me.Label15.TabIndex = 4
            Me.Label15.Text = "Distrito :"
            '
            'cbbDomicilioDist
            '
            Me.cbbDomicilioDist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDomicilioDist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbDomicilioDist.FormattingEnabled = True
            Me.cbbDomicilioDist.Location = New System.Drawing.Point(89, 91)
            Me.cbbDomicilioDist.Name = "cbbDomicilioDist"
            Me.cbbDomicilioDist.Size = New System.Drawing.Size(349, 21)
            Me.cbbDomicilioDist.TabIndex = 5
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(6, 68)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(57, 13)
            Me.Label16.TabIndex = 2
            Me.Label16.Text = "Provincia :"
            '
            'cbbDomicilioProv
            '
            Me.cbbDomicilioProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDomicilioProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbDomicilioProv.FormattingEnabled = True
            Me.cbbDomicilioProv.Location = New System.Drawing.Point(89, 65)
            Me.cbbDomicilioProv.Name = "cbbDomicilioProv"
            Me.cbbDomicilioProv.Size = New System.Drawing.Size(349, 21)
            Me.cbbDomicilioProv.TabIndex = 3
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(6, 43)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(80, 13)
            Me.Label17.TabIndex = 0
            Me.Label17.Text = "Departamento :"
            '
            'cbbDomicilioDepa
            '
            Me.cbbDomicilioDepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDomicilioDepa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbDomicilioDepa.FormattingEnabled = True
            Me.cbbDomicilioDepa.Location = New System.Drawing.Point(89, 40)
            Me.cbbDomicilioDepa.Name = "cbbDomicilioDepa"
            Me.cbbDomicilioDepa.Size = New System.Drawing.Size(349, 21)
            Me.cbbDomicilioDepa.TabIndex = 1
            '
            'frmDomicilioPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(444, 215)
            Me.Name = "frmDomicilioPopup"
            Me.Text = "Mantenimiento de domicilio"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtDireccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents cbbDomicilioDist As System.Windows.Forms.ComboBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents cbbDomicilioProv As System.Windows.Forms.ComboBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents cbbDomicilioDepa As System.Windows.Forms.ComboBox
        Friend WithEvents txtReferencia As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblNroIngreso As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
    End Class
End Namespace
