Namespace Registro.RegionLima.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmSelectInternoPopup
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.pnBotones = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.rdbInterno = New System.Windows.Forms.RadioButton()
            Me.rdbInternoFuera = New System.Windows.Forms.RadioButton()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.pnBotones.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.rdbInternoFuera)
            Me.gbxFormChildContainer.Controls.Add(Me.rdbInterno)
            Me.gbxFormChildContainer.Controls.Add(Me.PictureBox2)
            Me.gbxFormChildContainer.Controls.Add(Me.PictureBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.pnBotones)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(386, 219)
            '
            'pnBotones
            '
            Me.pnBotones.BackColor = System.Drawing.Color.Transparent
            Me.pnBotones.Controls.Add(Me.pnlGrabar)
            Me.pnBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnBotones.Location = New System.Drawing.Point(0, 174)
            Me.pnBotones.Name = "pnBotones"
            Me.pnBotones.Size = New System.Drawing.Size(386, 45)
            Me.pnBotones.TabIndex = 21
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnOK)
            Me.pnlGrabar.Controls.Add(Me.btnCancelar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(196, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(190, 45)
            Me.pnlGrabar.TabIndex = 4
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOK.Location = New System.Drawing.Point(1, 2)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(90, 40)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnOK.UseVisualStyleBackColor = True
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancelar.Location = New System.Drawing.Point(92, 2)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(90, 40)
            Me.btnCancelar.TabIndex = 1
            Me.btnCancelar.Text = "&Cancelar"
            Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = Global.SIPPOPE.My.Resources.Resources.images
            Me.PictureBox1.Location = New System.Drawing.Point(49, 12)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(101, 111)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 22
            Me.PictureBox1.TabStop = False
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = Global.SIPPOPE.My.Resources.Resources.pawn_glass_green
            Me.PictureBox2.Location = New System.Drawing.Point(223, 12)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(101, 111)
            Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox2.TabIndex = 23
            Me.PictureBox2.TabStop = False
            '
            'rdbInterno
            '
            Me.rdbInterno.AutoSize = True
            Me.rdbInterno.Checked = True
            Me.rdbInterno.Location = New System.Drawing.Point(63, 129)
            Me.rdbInterno.Name = "rdbInterno"
            Me.rdbInterno.Size = New System.Drawing.Size(58, 17)
            Me.rdbInterno.TabIndex = 24
            Me.rdbInterno.TabStop = True
            Me.rdbInterno.Text = "Interno"
            Me.rdbInterno.UseVisualStyleBackColor = True
            '
            'rdbInternoFuera
            '
            Me.rdbInternoFuera.AutoSize = True
            Me.rdbInternoFuera.Location = New System.Drawing.Point(196, 129)
            Me.rdbInternoFuera.Name = "rdbInternoFuera"
            Me.rdbInternoFuera.Size = New System.Drawing.Size(168, 17)
            Me.rdbInternoFuera.TabIndex = 25
            Me.rdbInternoFuera.Text = "No registra ingreso en el penal"
            Me.rdbInternoFuera.UseVisualStyleBackColor = True
            '
            'frmSelectInternoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(386, 219)
            Me.ControlBox = False
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmSelectInternoPopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Seleccione..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbxFormChildContainer.PerformLayout()
            Me.pnBotones.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnBotones As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents rdbInternoFuera As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInterno As System.Windows.Forms.RadioButton
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents btnCancelar As System.Windows.Forms.Button

    End Class

End Namespace