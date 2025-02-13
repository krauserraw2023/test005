Namespace Registro.Main.Carceleta
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmTipoNacionalidad
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnSiguiente = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.RadioButton2 = New System.Windows.Forms.RadioButton()
            Me.RadioButton1 = New System.Windows.Forms.RadioButton()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(571, 186)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnSiguiente)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 138)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(571, 48)
            Me.Panel1.TabIndex = 53
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(4, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(349, 35)
            Me.Label1.TabIndex = 106
            Me.Label1.Text = "Se valida con la reniec a internos de nacionalidad Peruana, para los extranjeros " & _
        "se continuará con el registro manual."
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(463, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(105, 43)
            Me.btnCancel.TabIndex = 105
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnSiguiente
            '
            Me.btnSiguiente.BackColor = System.Drawing.Color.Transparent
            Me.btnSiguiente.Image = Global.SIPPOPE.My.Resources.Resources.next_32
            Me.btnSiguiente.Location = New System.Drawing.Point(358, 2)
            Me.btnSiguiente.Name = "btnSiguiente"
            Me.btnSiguiente.Size = New System.Drawing.Size(99, 43)
            Me.btnSiguiente.TabIndex = 1
            Me.btnSiguiente.Text = "Siguiente"
            Me.btnSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSiguiente.UseVisualStyleBackColor = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.RadioButton2)
            Me.GroupBox1.Controls.Add(Me.RadioButton1)
            Me.GroupBox1.Location = New System.Drawing.Point(96, 38)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(331, 70)
            Me.GroupBox1.TabIndex = 54
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Nacionalidad"
            '
            'RadioButton2
            '
            Me.RadioButton2.AutoSize = True
            Me.RadioButton2.Location = New System.Drawing.Point(183, 30)
            Me.RadioButton2.Name = "RadioButton2"
            Me.RadioButton2.Size = New System.Drawing.Size(72, 17)
            Me.RadioButton2.TabIndex = 1
            Me.RadioButton2.Text = "Extranjero"
            Me.RadioButton2.UseVisualStyleBackColor = True
            '
            'RadioButton1
            '
            Me.RadioButton1.AutoSize = True
            Me.RadioButton1.Checked = True
            Me.RadioButton1.Location = New System.Drawing.Point(75, 30)
            Me.RadioButton1.Name = "RadioButton1"
            Me.RadioButton1.Size = New System.Drawing.Size(65, 17)
            Me.RadioButton1.TabIndex = 0
            Me.RadioButton1.TabStop = True
            Me.RadioButton1.Text = "Peruana"
            Me.RadioButton1.UseVisualStyleBackColor = True
            '
            'frmTipoNacionalidad
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(571, 186)
            Me.Name = "frmTipoNacionalidad"
            Me.Text = ".::. Seleccione nacionalidad"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnSiguiente As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace