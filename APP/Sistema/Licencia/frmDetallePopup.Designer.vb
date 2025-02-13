Namespace Sistema
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDetallePopup
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.txtRegion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.chkEscritura = New System.Windows.Forms.CheckBox()
            Me.chkLectura = New System.Windows.Forms.CheckBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtRegion
            '
            Me.txtRegion._BloquearPaste = False
            Me.txtRegion._SeleccionarTodo = False
            Me.txtRegion.Location = New System.Drawing.Point(65, 12)
            Me.txtRegion.Name = "txtRegion"
            Me.txtRegion.Size = New System.Drawing.Size(201, 20)
            Me.txtRegion.TabIndex = 0
            Me.txtRegion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRegion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtPenal
            '
            Me.txtPenal._BloquearPaste = False
            Me.txtPenal._SeleccionarTodo = False
            Me.txtPenal.Location = New System.Drawing.Point(65, 38)
            Me.txtPenal.Name = "txtPenal"
            Me.txtPenal.Size = New System.Drawing.Size(201, 20)
            Me.txtPenal.TabIndex = 1
            Me.txtPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'chkEscritura
            '
            Me.chkEscritura.AutoSize = True
            Me.chkEscritura.Location = New System.Drawing.Point(143, 68)
            Me.chkEscritura.Name = "chkEscritura"
            Me.chkEscritura.Size = New System.Drawing.Size(67, 17)
            Me.chkEscritura.TabIndex = 69
            Me.chkEscritura.Text = "Escritura"
            Me.chkEscritura.UseVisualStyleBackColor = True
            '
            'chkLectura
            '
            Me.chkLectura.AutoSize = True
            Me.chkLectura.Location = New System.Drawing.Point(65, 68)
            Me.chkLectura.Name = "chkLectura"
            Me.chkLectura.Size = New System.Drawing.Size(62, 17)
            Me.chkLectura.TabIndex = 70
            Me.chkLectura.Text = "Lectura"
            Me.chkLectura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkLectura.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 15)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
            Me.Label1.TabIndex = 71
            Me.Label1.Text = "Region :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 41)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(40, 13)
            Me.Label2.TabIndex = 72
            Me.Label2.Text = "Penal :"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnOk)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 103)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(274, 45)
            Me.Panel1.TabIndex = 73
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(172, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 70
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(74, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 69
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'frmDetallePopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(274, 148)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.chkLectura)
            Me.Controls.Add(Me.chkEscritura)
            Me.Controls.Add(Me.txtPenal)
            Me.Controls.Add(Me.txtRegion)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmDetallePopup"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Mantenimiento"
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtRegion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents chkEscritura As System.Windows.Forms.CheckBox
        Friend WithEvents chkLectura As System.Windows.Forms.CheckBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button

    End Class
End Namespace

