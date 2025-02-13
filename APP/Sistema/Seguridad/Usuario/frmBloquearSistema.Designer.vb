Namespace Sistema.Seguridad.Usuario
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBloquearSistema
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
            Me.components = New System.ComponentModel.Container()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtClave = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtUsuarioLogin = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(10, 131)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(67, 13)
            Me.Label3.TabIndex = 192
            Me.Label3.Text = "Contraseña :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(10, 61)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(328, 13)
            Me.Label2.TabIndex = 191
            Me.Label2.Text = "El sistema ha sido bloqueado por el usuario actual, ingrese la clave. "
            '
            'txtClave
            '
            Me.txtClave._BloquearPaste = False
            Me.txtClave._SeleccionarTodo = False
            Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtClave.Location = New System.Drawing.Point(111, 123)
            Me.txtClave.MaxLength = 50
            Me.txtClave.Name = "txtClave"
            Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtClave.Size = New System.Drawing.Size(197, 26)
            Me.txtClave.TabIndex = 193
            Me.txtClave.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtClave.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.txtClave.UseSystemPasswordChar = True
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.SystemColors.Control
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label5.Location = New System.Drawing.Point(11, 47)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(334, 3)
            Me.Label5.TabIndex = 196
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.txtUsuarioLogin)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtClave)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(357, 162)
            Me.GroupBox1.TabIndex = 197
            Me.GroupBox1.TabStop = False
            '
            'txtUsuarioLogin
            '
            Me.txtUsuarioLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUsuarioLogin.Location = New System.Drawing.Point(111, 90)
            Me.txtUsuarioLogin.MaxLength = 50
            Me.txtUsuarioLogin.Name = "txtUsuarioLogin"
            Me.txtUsuarioLogin.ReadOnly = True
            Me.txtUsuarioLogin.Size = New System.Drawing.Size(197, 26)
            Me.txtUsuarioLogin.TabIndex = 199
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(10, 96)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(49, 13)
            Me.Label4.TabIndex = 198
            Me.Label4.Text = "Usuario :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(79, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(190, 24)
            Me.Label1.TabIndex = 197
            Me.Label1.Text = "Sistema Bloqueado"
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(264, 193)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(105, 40)
            Me.btnSalir.TabIndex = 199
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(156, 193)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(105, 40)
            Me.btnOk.TabIndex = 198
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnOk.UseVisualStyleBackColor = True
            '
            'frmBloquearSistema
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(379, 251)
            Me.ControlBox = False
            Me.Controls.Add(Me.btnSalir)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmBloquearSistema"
            Me.ShowInTaskbar = False
            Me.Text = "Bloquear Sistema..."
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtClave As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtUsuarioLogin As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label

    End Class
End Namespace

