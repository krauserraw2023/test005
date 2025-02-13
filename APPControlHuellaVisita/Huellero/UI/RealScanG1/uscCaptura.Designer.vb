<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscCaptura
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.pbHuella = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlConfiguracion = New System.Windows.Forms.Panel()
        Me.CBDeviceIndex = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConfiguracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbHuella
        '
        Me.pbHuella.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbHuella.Location = New System.Drawing.Point(0, 31)
        Me.pbHuella.Name = "pbHuella"
        Me.pbHuella.Size = New System.Drawing.Size(338, 332)
        Me.pbHuella.TabIndex = 11
        Me.pbHuella.TabStop = False
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
        'pnlConfiguracion
        '
        Me.pnlConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlConfiguracion.Controls.Add(Me.Label2)
        Me.pnlConfiguracion.Controls.Add(Me.CBDeviceIndex)
        Me.pnlConfiguracion.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfiguracion.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfiguracion.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.pnlConfiguracion.Name = "pnlConfiguracion"
        Me.pnlConfiguracion.Size = New System.Drawing.Size(338, 31)
        Me.pnlConfiguracion.TabIndex = 13
        Me.pnlConfiguracion.Visible = False
        '
        'CBDeviceIndex
        '
        Me.CBDeviceIndex.Enabled = False
        Me.CBDeviceIndex.Location = New System.Drawing.Point(71, 5)
        Me.CBDeviceIndex.Name = "CBDeviceIndex"
        Me.CBDeviceIndex.Size = New System.Drawing.Size(144, 21)
        Me.CBDeviceIndex.TabIndex = 9
        '
        'lblEstado
        '
        Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblEstado.Location = New System.Drawing.Point(0, 363)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(338, 18)
        Me.lblEstado.TabIndex = 12
        Me.lblEstado.Text = "Estado :"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'uscCaptura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.pbHuella)
        Me.Controls.Add(Me.pnlConfiguracion)
        Me.Controls.Add(Me.lblEstado)
        Me.Name = "uscCaptura"
        Me.Size = New System.Drawing.Size(338, 381)
        CType(Me.pbHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConfiguracion.ResumeLayout(False)
        Me.pnlConfiguracion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbHuella As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlConfiguracion As System.Windows.Forms.Panel
    Friend WithEvents CBDeviceIndex As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
