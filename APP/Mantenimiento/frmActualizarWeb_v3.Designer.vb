
Namespace Mantenimiento


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmActualizarWeb_v3
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
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.chkUsuario = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.chkLicencia = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.chkModulo = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.btnCancelar = New Legolas.APPUIComponents.myButton()
            Me.btnAceptar = New Legolas.APPUIComponents.myButton()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel4)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(302, 144)
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.GroupBox2)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(302, 110)
            Me.Panel2.TabIndex = 2
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.chkUsuario)
            Me.GroupBox2.Controls.Add(Me.chkLicencia)
            Me.GroupBox2.Controls.Add(Me.chkModulo)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(302, 110)
            Me.GroupBox2.TabIndex = 9
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Parametricas Sistema"
            '
            'chkUsuario
            '
            Me.chkUsuario.AutoSize = True
            Me.chkUsuario.Location = New System.Drawing.Point(12, 79)
            Me.chkUsuario.Name = "chkUsuario"
            Me.chkUsuario.Size = New System.Drawing.Size(111, 17)
            Me.chkUsuario.TabIndex = 5
            Me.chkUsuario.Text = "Actualizar Usuario"
            Me.chkUsuario.UseVisualStyleBackColor = True
            '
            'chkLicencia
            '
            Me.chkLicencia.AutoSize = True
            Me.chkLicencia.Location = New System.Drawing.Point(12, 23)
            Me.chkLicencia.Name = "chkLicencia"
            Me.chkLicencia.Size = New System.Drawing.Size(115, 17)
            Me.chkLicencia.TabIndex = 2
            Me.chkLicencia.Text = "Actualizar Licencia"
            Me.chkLicencia.UseVisualStyleBackColor = True
            '
            'chkModulo
            '
            Me.chkModulo.AutoSize = True
            Me.chkModulo.Location = New System.Drawing.Point(12, 50)
            Me.chkModulo.Name = "chkModulo"
            Me.chkModulo.Size = New System.Drawing.Size(110, 17)
            Me.chkModulo.TabIndex = 4
            Me.chkModulo.Text = "Actualizar Modulo"
            Me.chkModulo.UseVisualStyleBackColor = True
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.Panel5)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel4.Location = New System.Drawing.Point(0, 110)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(302, 34)
            Me.Panel4.TabIndex = 11
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.btnCancelar)
            Me.Panel5.Controls.Add(Me.btnAceptar)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel5.Location = New System.Drawing.Point(139, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(163, 34)
            Me.Panel5.TabIndex = 9
            '
            'btnCancelar
            '
            Me.btnCancelar.Location = New System.Drawing.Point(84, 6)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
            Me.btnCancelar.TabIndex = 7
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'btnAceptar
            '
            Me.btnAceptar.Location = New System.Drawing.Point(3, 6)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
            Me.btnAceptar.TabIndex = 8
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'frmActualizarWeb_v3
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(302, 144)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmActualizarWeb_v3"
            Me.Text = "Actualizacion de ..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents chkLicencia As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents btnCancelar As Legolas.APPUIComponents.myButton
        Friend WithEvents btnAceptar As Legolas.APPUIComponents.myButton
        Friend WithEvents chkModulo As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents chkUsuario As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    End Class
End Namespace