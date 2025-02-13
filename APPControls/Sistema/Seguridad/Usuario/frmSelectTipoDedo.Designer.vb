<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectTipoDedo
    Inherits System.Windows.Forms.Form

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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdbMed_izq = New System.Windows.Forms.RadioButton()
        Me.rdbPul_izq = New System.Windows.Forms.RadioButton()
        Me.rdbInd_izq = New System.Windows.Forms.RadioButton()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdbPul_der = New System.Windows.Forms.RadioButton()
        Me.rdbInd_der = New System.Windows.Forms.RadioButton()
        Me.rdbMed_der = New System.Windows.Forms.RadioButton()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(273, 250)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 30)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(187, 250)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(81, 30)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Seleccione tipo de dedo."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.rdbMed_izq)
        Me.Panel1.Controls.Add(Me.rdbPul_izq)
        Me.Panel1.Controls.Add(Me.rdbInd_izq)
        Me.Panel1.Controls.Add(Me.PictureBox12)
        Me.Panel1.Location = New System.Drawing.Point(3, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 215)
        Me.Panel1.TabIndex = 13
        '
        'rdbMed_izq
        '
        Me.rdbMed_izq.AutoSize = True
        Me.rdbMed_izq.Location = New System.Drawing.Point(82, 9)
        Me.rdbMed_izq.Name = "rdbMed_izq"
        Me.rdbMed_izq.Size = New System.Drawing.Size(14, 13)
        Me.rdbMed_izq.TabIndex = 11
        Me.rdbMed_izq.UseVisualStyleBackColor = True
        '
        'rdbPul_izq
        '
        Me.rdbPul_izq.AutoSize = True
        Me.rdbPul_izq.Location = New System.Drawing.Point(143, 92)
        Me.rdbPul_izq.Name = "rdbPul_izq"
        Me.rdbPul_izq.Size = New System.Drawing.Size(14, 13)
        Me.rdbPul_izq.TabIndex = 11
        Me.rdbPul_izq.UseVisualStyleBackColor = True
        '
        'rdbInd_izq
        '
        Me.rdbInd_izq.AutoSize = True
        Me.rdbInd_izq.Checked = True
        Me.rdbInd_izq.Location = New System.Drawing.Point(112, 23)
        Me.rdbInd_izq.Name = "rdbInd_izq"
        Me.rdbInd_izq.Size = New System.Drawing.Size(14, 13)
        Me.rdbInd_izq.TabIndex = 11
        Me.rdbInd_izq.TabStop = True
        Me.rdbInd_izq.UseVisualStyleBackColor = True
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.White
        Me.PictureBox12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox12.Image = Global.APPControls.My.Resources.Resources.mano_izquierda03
        Me.PictureBox12.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(181, 215)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 6
        Me.PictureBox12.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.rdbPul_der)
        Me.Panel2.Controls.Add(Me.rdbInd_der)
        Me.Panel2.Controls.Add(Me.rdbMed_der)
        Me.Panel2.Controls.Add(Me.PictureBox13)
        Me.Panel2.Location = New System.Drawing.Point(173, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 215)
        Me.Panel2.TabIndex = 14
        '
        'rdbPul_der
        '
        Me.rdbPul_der.AutoSize = True
        Me.rdbPul_der.Location = New System.Drawing.Point(24, 93)
        Me.rdbPul_der.Name = "rdbPul_der"
        Me.rdbPul_der.Size = New System.Drawing.Size(14, 13)
        Me.rdbPul_der.TabIndex = 10
        Me.rdbPul_der.UseVisualStyleBackColor = True
        '
        'rdbInd_der
        '
        Me.rdbInd_der.AutoSize = True
        Me.rdbInd_der.Checked = True
        Me.rdbInd_der.Location = New System.Drawing.Point(55, 21)
        Me.rdbInd_der.Name = "rdbInd_der"
        Me.rdbInd_der.Size = New System.Drawing.Size(14, 13)
        Me.rdbInd_der.TabIndex = 9
        Me.rdbInd_der.TabStop = True
        Me.rdbInd_der.UseVisualStyleBackColor = True
        '
        'rdbMed_der
        '
        Me.rdbMed_der.AutoSize = True
        Me.rdbMed_der.Location = New System.Drawing.Point(85, 8)
        Me.rdbMed_der.Name = "rdbMed_der"
        Me.rdbMed_der.Size = New System.Drawing.Size(14, 13)
        Me.rdbMed_der.TabIndex = 8
        Me.rdbMed_der.UseVisualStyleBackColor = True
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.White
        Me.PictureBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox13.Image = Global.APPControls.My.Resources.Resources.mano_derecha03
        Me.PictureBox13.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(181, 215)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 7
        Me.PictureBox13.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(51, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Izquierda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(59, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Derecha"
        '
        'frmSelectTipoDedo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 284)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSelectTipoDedo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".::."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdbMed_izq As RadioButton
    Friend WithEvents rdbInd_izq As RadioButton
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdbInd_der As RadioButton
    Friend WithEvents rdbMed_der As RadioButton
    Friend WithEvents rdbPul_izq As RadioButton
    Friend WithEvents rdbPul_der As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
