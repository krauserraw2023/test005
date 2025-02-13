Namespace Registro.RegionLima.Identificacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmNombreAsociadoPopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNombreAsociadoPopup))
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtMotivo = New System.Windows.Forms.TextBox()
            Me.txtDocRef = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.gbTiponombre = New System.Windows.Forms.GroupBox()
            Me.rdbAsociado = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbPrincipal = New Legolas.APPUIComponents.myRadioButton()
            Me.Panel11 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtApePaterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApeMaterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.gbTiponombre.SuspendLayout()
            Me.Panel11.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox4)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(403, 309)
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtMotivo)
            Me.GroupBox4.Controls.Add(Me.txtDocRef)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.Panel1)
            Me.GroupBox4.Controls.Add(Me.gbTiponombre)
            Me.GroupBox4.Controls.Add(Me.Panel11)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.txtApePaterno)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Controls.Add(Me.txtNombre)
            Me.GroupBox4.Controls.Add(Me.txtApeMaterno)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(403, 309)
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            '
            'txtMotivo
            '
            Me.txtMotivo.Location = New System.Drawing.Point(111, 110)
            Me.txtMotivo.MaxLength = 500
            Me.txtMotivo.Multiline = True
            Me.txtMotivo.Name = "txtMotivo"
            Me.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtMotivo.Size = New System.Drawing.Size(280, 55)
            Me.txtMotivo.TabIndex = 11
            '
            'txtDocRef
            '
            Me.txtDocRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDocRef.Location = New System.Drawing.Point(111, 87)
            Me.txtDocRef.MaxLength = 100
            Me.txtDocRef.Name = "txtDocRef"
            Me.txtDocRef.Size = New System.Drawing.Size(280, 20)
            Me.txtDocRef.TabIndex = 10
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(15, 113)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(45, 13)
            Me.Label5.TabIndex = 9
            Me.Label5.Text = "Motivo :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(15, 90)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(91, 13)
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "Documento Ref. :"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.pnlSalir)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(3, 206)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(397, 50)
            Me.Panel1.TabIndex = 7
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnAceptar)
            Me.Panel4.Controls.Add(Me.btnCancelar)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel4.Location = New System.Drawing.Point(117, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(183, 50)
            Me.Panel4.TabIndex = 0
            '
            'btnAceptar
            '
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAceptar.Location = New System.Drawing.Point(2, 4)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(85, 41)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'btnCancelar
            '
            Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancelar.Location = New System.Drawing.Point(89, 4)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(91, 41)
            Me.btnCancelar.TabIndex = 1
            Me.btnCancelar.Text = "&Cancelar"
            Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(300, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(97, 50)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(3, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(90, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'gbTiponombre
            '
            Me.gbTiponombre.Controls.Add(Me.rdbAsociado)
            Me.gbTiponombre.Controls.Add(Me.rdbPrincipal)
            Me.gbTiponombre.Location = New System.Drawing.Point(111, 167)
            Me.gbTiponombre.Name = "gbTiponombre"
            Me.gbTiponombre.Size = New System.Drawing.Size(280, 38)
            Me.gbTiponombre.TabIndex = 6
            Me.gbTiponombre.TabStop = False
            Me.gbTiponombre.Text = "Tipo de nombre"
            '
            'rdbAsociado
            '
            Me.rdbAsociado.AutoSize = True
            Me.rdbAsociado.Checked = True
            Me.rdbAsociado.Location = New System.Drawing.Point(154, 16)
            Me.rdbAsociado.Name = "rdbAsociado"
            Me.rdbAsociado.Size = New System.Drawing.Size(69, 17)
            Me.rdbAsociado.TabIndex = 1
            Me.rdbAsociado.TabStop = True
            Me.rdbAsociado.Text = "Asociado"
            Me.rdbAsociado.UseVisualStyleBackColor = True
            '
            'rdbPrincipal
            '
            Me.rdbPrincipal.AutoSize = True
            Me.rdbPrincipal.Location = New System.Drawing.Point(48, 16)
            Me.rdbPrincipal.Name = "rdbPrincipal"
            Me.rdbPrincipal.Size = New System.Drawing.Size(65, 17)
            Me.rdbPrincipal.TabIndex = 0
            Me.rdbPrincipal.Text = "Principal"
            Me.rdbPrincipal.UseVisualStyleBackColor = True
            '
            'Panel11
            '
            Me.Panel11.Controls.Add(Me.UscAuditUser1)
            Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel11.Location = New System.Drawing.Point(3, 256)
            Me.Panel11.Name = "Panel11"
            Me.Panel11.Size = New System.Drawing.Size(397, 50)
            Me.Panel11.TabIndex = 8
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(15, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(90, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Primer Apellido :"
            '
            'txtApePaterno
            '
            Me.txtApePaterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePaterno._BloquearPaste = True
            Me.txtApePaterno._SeleccionarTodo = False
            Me.txtApePaterno.Location = New System.Drawing.Point(111, 19)
            Me.txtApePaterno.Name = "txtApePaterno"
            Me.txtApePaterno.Size = New System.Drawing.Size(280, 20)
            Me.txtApePaterno.TabIndex = 1
            Me.txtApePaterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePaterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(15, 44)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(92, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Segundo Apellido:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(15, 67)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Nombres :"
            '
            'txtNombre
            '
            Me.txtNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombre._BloquearPaste = True
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(111, 64)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(280, 20)
            Me.txtNombre.TabIndex = 5
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApeMaterno
            '
            Me.txtApeMaterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMaterno._BloquearPaste = True
            Me.txtApeMaterno._SeleccionarTodo = False
            Me.txtApeMaterno.Location = New System.Drawing.Point(111, 41)
            Me.txtApeMaterno.Name = "txtApeMaterno"
            Me.txtApeMaterno.Size = New System.Drawing.Size(280, 20)
            Me.txtApeMaterno.TabIndex = 3
            Me.txtApeMaterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMaterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(397, 50)
            Me.UscAuditUser1.TabIndex = 0
            '
            'frmNombreAsociadoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(403, 309)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmNombreAsociadoPopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Nombres Asociados"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.gbTiponombre.ResumeLayout(False)
            Me.gbTiponombre.PerformLayout()
            Me.Panel11.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtApePaterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApeMaterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents gbTiponombre As System.Windows.Forms.GroupBox
        Friend WithEvents rdbAsociado As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbPrincipal As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents Panel11 As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents txtMotivo As TextBox
        Friend WithEvents txtDocRef As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents Label4 As Label
    End Class
End Namespace