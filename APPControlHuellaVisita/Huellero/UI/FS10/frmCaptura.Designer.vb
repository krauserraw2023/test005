Namespace Huellero.FS10


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCaptura
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
            Me.pbHuella = New System.Windows.Forms.PictureBox()
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.pnlConfiguracion = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.CBDeviceIndex = New System.Windows.Forms.ComboBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            CType(Me.pbHuella, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlConfiguracion.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pbHuella
            '
            Me.pbHuella.BackColor = System.Drawing.Color.White
            Me.pbHuella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.pbHuella.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbHuella.Location = New System.Drawing.Point(0, 31)
            Me.pbHuella.Name = "pbHuella"
            Me.pbHuella.Size = New System.Drawing.Size(486, 362)
            Me.pbHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbHuella.TabIndex = 2
            Me.pbHuella.TabStop = False
            '
            'lblEstado
            '
            Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblEstado.Location = New System.Drawing.Point(0, 393)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(486, 18)
            Me.lblEstado.TabIndex = 3
            Me.lblEstado.Text = "Estado :"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(387, 352)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(87, 34)
            Me.Button1.TabIndex = 4
            Me.Button1.Text = "&Capturar"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'pnlConfiguracion
            '
            Me.pnlConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlConfiguracion.Controls.Add(Me.Label2)
            Me.pnlConfiguracion.Controls.Add(Me.CBDeviceIndex)
            Me.pnlConfiguracion.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlConfiguracion.Location = New System.Drawing.Point(0, 0)
            Me.pnlConfiguracion.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
            Me.pnlConfiguracion.Name = "pnlConfiguracion"
            Me.pnlConfiguracion.Size = New System.Drawing.Size(486, 31)
            Me.pnlConfiguracion.TabIndex = 8
            Me.pnlConfiguracion.Visible = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(3, 8)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(64, 13)
            Me.Label2.TabIndex = 14
            Me.Label2.Text = "Dispositivo :"
            '
            'CBDeviceIndex
            '
            Me.CBDeviceIndex.Enabled = False
            Me.CBDeviceIndex.Location = New System.Drawing.Point(71, 5)
            Me.CBDeviceIndex.Name = "CBDeviceIndex"
            Me.CBDeviceIndex.Size = New System.Drawing.Size(144, 21)
            Me.CBDeviceIndex.TabIndex = 9
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.White
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(48, 49)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 26
            Me.PictureBox1.TabStop = False
            '
            'frmCaptura
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(486, 411)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.pbHuella)
            Me.Controls.Add(Me.pnlConfiguracion)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.lblEstado)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmCaptura"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Captura dactilar"
            CType(Me.pbHuella, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlConfiguracion.ResumeLayout(False)
            Me.pnlConfiguracion.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pbHuella As System.Windows.Forms.PictureBox
        Friend WithEvents lblEstado As System.Windows.Forms.Label
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents pnlConfiguracion As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents CBDeviceIndex As System.Windows.Forms.ComboBox
        Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    End Class

End Namespace