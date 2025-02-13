<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCheckSemanaDia
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.chk_lunes = New System.Windows.Forms.CheckBox()
        Me.chk_martes = New System.Windows.Forms.CheckBox()
        Me.chk_miercoles = New System.Windows.Forms.CheckBox()
        Me.chk_jueves = New System.Windows.Forms.CheckBox()
        Me.chk_viernes = New System.Windows.Forms.CheckBox()
        Me.chk_sabado = New System.Windows.Forms.CheckBox()
        Me.chk_domingo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chk_lunes
        '
        Me.chk_lunes.AutoSize = True
        Me.chk_lunes.Location = New System.Drawing.Point(4, 4)
        Me.chk_lunes.Name = "chk_lunes"
        Me.chk_lunes.Size = New System.Drawing.Size(55, 17)
        Me.chk_lunes.TabIndex = 0
        Me.chk_lunes.Tag = "1"
        Me.chk_lunes.Text = "Lunes"
        Me.chk_lunes.UseVisualStyleBackColor = True
        '
        'chk_martes
        '
        Me.chk_martes.AutoSize = True
        Me.chk_martes.Location = New System.Drawing.Point(63, 4)
        Me.chk_martes.Name = "chk_martes"
        Me.chk_martes.Size = New System.Drawing.Size(58, 17)
        Me.chk_martes.TabIndex = 1
        Me.chk_martes.Tag = "2"
        Me.chk_martes.Text = "Martes"
        Me.chk_martes.UseVisualStyleBackColor = True
        '
        'chk_miercoles
        '
        Me.chk_miercoles.AutoSize = True
        Me.chk_miercoles.Location = New System.Drawing.Point(124, 4)
        Me.chk_miercoles.Name = "chk_miercoles"
        Me.chk_miercoles.Size = New System.Drawing.Size(71, 17)
        Me.chk_miercoles.TabIndex = 2
        Me.chk_miercoles.Text = "Miercoles"
        Me.chk_miercoles.UseVisualStyleBackColor = True
        '
        'chk_jueves
        '
        Me.chk_jueves.AutoSize = True
        Me.chk_jueves.Location = New System.Drawing.Point(198, 4)
        Me.chk_jueves.Name = "chk_jueves"
        Me.chk_jueves.Size = New System.Drawing.Size(60, 17)
        Me.chk_jueves.TabIndex = 3
        Me.chk_jueves.Text = "Jueves"
        Me.chk_jueves.UseVisualStyleBackColor = True
        '
        'chk_viernes
        '
        Me.chk_viernes.AutoSize = True
        Me.chk_viernes.Location = New System.Drawing.Point(261, 4)
        Me.chk_viernes.Name = "chk_viernes"
        Me.chk_viernes.Size = New System.Drawing.Size(61, 17)
        Me.chk_viernes.TabIndex = 4
        Me.chk_viernes.Tag = "5"
        Me.chk_viernes.Text = "Viernes"
        Me.chk_viernes.UseVisualStyleBackColor = True
        '
        'chk_sabado
        '
        Me.chk_sabado.AutoSize = True
        Me.chk_sabado.Location = New System.Drawing.Point(325, 4)
        Me.chk_sabado.Name = "chk_sabado"
        Me.chk_sabado.Size = New System.Drawing.Size(63, 17)
        Me.chk_sabado.TabIndex = 5
        Me.chk_sabado.Tag = "6"
        Me.chk_sabado.Text = "Sabado"
        Me.chk_sabado.UseVisualStyleBackColor = True
        '
        'chk_domingo
        '
        Me.chk_domingo.AutoSize = True
        Me.chk_domingo.Location = New System.Drawing.Point(393, 4)
        Me.chk_domingo.Name = "chk_domingo"
        Me.chk_domingo.Size = New System.Drawing.Size(68, 17)
        Me.chk_domingo.TabIndex = 6
        Me.chk_domingo.Tag = "7"
        Me.chk_domingo.Text = "Domingo"
        Me.chk_domingo.UseVisualStyleBackColor = True
        '
        'usrCheckSemanaDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chk_domingo)
        Me.Controls.Add(Me.chk_sabado)
        Me.Controls.Add(Me.chk_viernes)
        Me.Controls.Add(Me.chk_jueves)
        Me.Controls.Add(Me.chk_miercoles)
        Me.Controls.Add(Me.chk_martes)
        Me.Controls.Add(Me.chk_lunes)
        Me.Name = "usrCheckSemanaDia"
        Me.Size = New System.Drawing.Size(464, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_lunes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_martes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_miercoles As System.Windows.Forms.CheckBox
    Friend WithEvents chk_jueves As System.Windows.Forms.CheckBox
    Friend WithEvents chk_viernes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_sabado As System.Windows.Forms.CheckBox
    Friend WithEvents chk_domingo As System.Windows.Forms.CheckBox

End Class
