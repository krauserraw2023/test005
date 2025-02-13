Namespace Sistema.Seguridad.Usuario
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCambiarClave
        Inherits Legolas.APPUIComponents.Form

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
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtClaveOld = New System.Windows.Forms.TextBox()
            Me.txtClave = New System.Windows.Forms.TextBox()
            Me.txtReClave = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(14, 22)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(100, 13)
            Me.Label3.TabIndex = 192
            Me.Label3.Text = "Contraseña Actual :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(14, 94)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(114, 13)
            Me.Label2.TabIndex = 191
            Me.Label2.Text = "Confirmar Contraseña :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(14, 68)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(102, 13)
            Me.Label1.TabIndex = 190
            Me.Label1.Text = "Contraseña Nueva :"
            '
            'txtClaveOld
            '
            Me.txtClaveOld.Location = New System.Drawing.Point(147, 19)
            Me.txtClaveOld.MaxLength = 50
            Me.txtClaveOld.Name = "txtClaveOld"
            Me.txtClaveOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtClaveOld.Size = New System.Drawing.Size(158, 20)
            Me.txtClaveOld.TabIndex = 193
            Me.txtClaveOld.UseSystemPasswordChar = True
            '
            'txtClave
            '
            Me.txtClave.Location = New System.Drawing.Point(147, 63)
            Me.txtClave.MaxLength = 50
            Me.txtClave.Name = "txtClave"
            Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtClave.Size = New System.Drawing.Size(158, 20)
            Me.txtClave.TabIndex = 194
            Me.txtClave.UseSystemPasswordChar = True
            '
            'txtReClave
            '
            Me.txtReClave.Location = New System.Drawing.Point(147, 89)
            Me.txtReClave.MaxLength = 50
            Me.txtReClave.Name = "txtReClave"
            Me.txtReClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtReClave.Size = New System.Drawing.Size(158, 20)
            Me.txtReClave.TabIndex = 195
            Me.txtReClave.UseSystemPasswordChar = True
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.SystemColors.Control
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label5.Location = New System.Drawing.Point(13, 47)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(300, 3)
            Me.Label5.TabIndex = 196
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtClaveOld)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtReClave)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtClave)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(322, 131)
            Me.GroupBox1.TabIndex = 197
            Me.GroupBox1.TabStop = False
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.SystemColors.Control
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label4.Location = New System.Drawing.Point(13, 117)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(300, 3)
            Me.Label4.TabIndex = 197
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnSalir.Location = New System.Drawing.Point(177, 149)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(105, 40)
            Me.btnSalir.TabIndex = 199
            Me.btnSalir.Text = "&Cancelar"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(66, 149)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(105, 40)
            Me.btnOk.TabIndex = 198
            Me.btnOk.Text = "&Confirmar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnOk.UseVisualStyleBackColor = True
            '
            'frmCambiarClave
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(344, 196)
            Me.Controls.Add(Me.btnSalir)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmCambiarClave"
            Me.ShowInTaskbar = False
            Me.Text = "Cambiar Clave"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtClaveOld As System.Windows.Forms.TextBox
        Friend WithEvents txtClave As System.Windows.Forms.TextBox
        Friend WithEvents txtReClave As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button

    End Class
End Namespace

