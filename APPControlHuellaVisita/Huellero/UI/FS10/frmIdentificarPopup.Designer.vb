Namespace Huellero.FS10


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmIdentificarPopup
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.pnlConfiguracion = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.CBDeviceIndex = New System.Windows.Forms.ComboBox()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.btnRecapturar = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCapturarHuella = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.pbLeyendaColor = New System.Windows.Forms.PictureBox()
            Me.pbHuella = New System.Windows.Forms.PictureBox()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.pnlManoDer = New System.Windows.Forms.Panel()
            Me.lblObsManDer = New System.Windows.Forms.Label()
            Me.pnlManoDerDetalle = New System.Windows.Forms.Panel()
            Me.pbCalidadManoDer = New System.Windows.Forms.PictureBox()
            Me.chkHueDer = New System.Windows.Forms.CheckBox()
            Me.pbManoDer = New System.Windows.Forms.PictureBox()
            Me.pnlManoIzq = New System.Windows.Forms.Panel()
            Me.lblObsManIzq = New System.Windows.Forms.Label()
            Me.pnlManoIzqDetalle = New System.Windows.Forms.Panel()
            Me.pbCalidadManoIzq = New System.Windows.Forms.PictureBox()
            Me.chkHueIzq = New System.Windows.Forms.CheckBox()
            Me.pbManoIzq = New System.Windows.Forms.PictureBox()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.pnlConfiguracion.SuspendLayout()
            Me.pnlPie.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.pbLeyendaColor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbHuella, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlManoDer.SuspendLayout()
            Me.pnlManoDerDetalle.SuspendLayout()
            CType(Me.pbCalidadManoDer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbManoDer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlManoIzq.SuspendLayout()
            Me.pnlManoIzqDetalle.SuspendLayout()
            CType(Me.pbCalidadManoIzq, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbManoIzq, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblEstado
            '
            Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblEstado.Location = New System.Drawing.Point(0, 423)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(437, 18)
            Me.lblEstado.TabIndex = 3
            Me.lblEstado.Text = "Estado :"
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
            Me.pnlConfiguracion.Size = New System.Drawing.Size(437, 31)
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
            'pnlPie
            '
            Me.pnlPie.Controls.Add(Me.btnRecapturar)
            Me.pnlPie.Controls.Add(Me.btnSalir)
            Me.pnlPie.Controls.Add(Me.btnAceptar)
            Me.pnlPie.Controls.Add(Me.btnCapturarHuella)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 441)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(437, 48)
            Me.pnlPie.TabIndex = 27
            '
            'btnRecapturar
            '
            Me.btnRecapturar.Enabled = False
            Me.btnRecapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRecapturar.ForeColor = System.Drawing.Color.Black
            Me.btnRecapturar.Image = Global.APPControlHuellaVisita.My.Resources.Resources.recapturar
            Me.btnRecapturar.Location = New System.Drawing.Point(111, 3)
            Me.btnRecapturar.Name = "btnRecapturar"
            Me.btnRecapturar.Size = New System.Drawing.Size(105, 42)
            Me.btnRecapturar.TabIndex = 19
            Me.btnRecapturar.UseVisualStyleBackColor = False
            Me.btnRecapturar.Visible = False
            '
            'btnSalir
            '
            Me.btnSalir.Enabled = False
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.APPControlHuellaVisita.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(328, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(101, 42)
            Me.btnSalir.TabIndex = 3
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.APPControlHuellaVisita.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(221, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(101, 42)
            Me.btnAceptar.TabIndex = 2
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCapturarHuella
            '
            Me.btnCapturarHuella.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapturarHuella.Image = Global.APPControlHuellaVisita.My.Resources.Resources.capturar
            Me.btnCapturarHuella.Location = New System.Drawing.Point(5, 3)
            Me.btnCapturarHuella.Name = "btnCapturarHuella"
            Me.btnCapturarHuella.Size = New System.Drawing.Size(101, 42)
            Me.btnCapturarHuella.TabIndex = 18
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.pbLeyendaColor)
            Me.Panel1.Controls.Add(Me.pbHuella)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 107)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(437, 316)
            Me.Panel1.TabIndex = 28
            '
            'pbLeyendaColor
            '
            Me.pbLeyendaColor.BackColor = System.Drawing.Color.White
            Me.pbLeyendaColor.Location = New System.Drawing.Point(3, 3)
            Me.pbLeyendaColor.Name = "pbLeyendaColor"
            Me.pbLeyendaColor.Size = New System.Drawing.Size(48, 49)
            Me.pbLeyendaColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbLeyendaColor.TabIndex = 26
            Me.pbLeyendaColor.TabStop = False
            '
            'pbHuella
            '
            Me.pbHuella.BackColor = System.Drawing.Color.White
            Me.pbHuella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.pbHuella.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbHuella.Location = New System.Drawing.Point(0, 0)
            Me.pbHuella.Name = "pbHuella"
            Me.pbHuella.Size = New System.Drawing.Size(437, 316)
            Me.pbHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbHuella.TabIndex = 2
            Me.pbHuella.TabStop = False
            '
            'pnlCabecera
            '
            Me.pnlCabecera.BackColor = System.Drawing.Color.White
            Me.pnlCabecera.Controls.Add(Me.pnlManoDer)
            Me.pnlCabecera.Controls.Add(Me.pnlManoIzq)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 31)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(437, 76)
            Me.pnlCabecera.TabIndex = 29
            '
            'pnlManoDer
            '
            Me.pnlManoDer.Controls.Add(Me.lblObsManDer)
            Me.pnlManoDer.Controls.Add(Me.pnlManoDerDetalle)
            Me.pnlManoDer.Controls.Add(Me.pbManoDer)
            Me.pnlManoDer.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlManoDer.Location = New System.Drawing.Point(249, 0)
            Me.pnlManoDer.Name = "pnlManoDer"
            Me.pnlManoDer.Size = New System.Drawing.Size(188, 76)
            Me.pnlManoDer.TabIndex = 22
            '
            'lblObsManDer
            '
            Me.lblObsManDer.AutoSize = True
            Me.lblObsManDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObsManDer.Location = New System.Drawing.Point(118, 58)
            Me.lblObsManDer.Name = "lblObsManDer"
            Me.lblObsManDer.Size = New System.Drawing.Size(66, 15)
            Me.lblObsManDer.TabIndex = 27
            Me.lblObsManDer.Text = "Observado"
            Me.lblObsManDer.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.lblObsManDer.Visible = False
            '
            'pnlManoDerDetalle
            '
            Me.pnlManoDerDetalle.Controls.Add(Me.pbCalidadManoDer)
            Me.pnlManoDerDetalle.Controls.Add(Me.chkHueDer)
            Me.pnlManoDerDetalle.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlManoDerDetalle.Location = New System.Drawing.Point(-13, 0)
            Me.pnlManoDerDetalle.Name = "pnlManoDerDetalle"
            Me.pnlManoDerDetalle.Size = New System.Drawing.Size(128, 76)
            Me.pnlManoDerDetalle.TabIndex = 21
            '
            'pbCalidadManoDer
            '
            Me.pbCalidadManoDer.BackColor = System.Drawing.Color.White
            Me.pbCalidadManoDer.Location = New System.Drawing.Point(89, 2)
            Me.pbCalidadManoDer.Name = "pbCalidadManoDer"
            Me.pbCalidadManoDer.Size = New System.Drawing.Size(36, 36)
            Me.pbCalidadManoDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbCalidadManoDer.TabIndex = 26
            Me.pbCalidadManoDer.TabStop = False
            '
            'chkHueDer
            '
            Me.chkHueDer.AutoSize = True
            Me.chkHueDer.BackColor = System.Drawing.Color.White
            Me.chkHueDer.Checked = True
            Me.chkHueDer.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkHueDer.Location = New System.Drawing.Point(26, 40)
            Me.chkHueDer.Name = "chkHueDer"
            Me.chkHueDer.Size = New System.Drawing.Size(99, 17)
            Me.chkHueDer.TabIndex = 24
            Me.chkHueDer.Text = "Indice Derecho"
            Me.chkHueDer.UseVisualStyleBackColor = False
            '
            'pbManoDer
            '
            Me.pbManoDer.BackColor = System.Drawing.Color.White
            Me.pbManoDer.Dock = System.Windows.Forms.DockStyle.Right
            Me.pbManoDer.Image = Global.APPControlHuellaVisita.My.Resources.Resources.mano_derecha
            Me.pbManoDer.Location = New System.Drawing.Point(115, 0)
            Me.pbManoDer.Name = "pbManoDer"
            Me.pbManoDer.Size = New System.Drawing.Size(73, 76)
            Me.pbManoDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbManoDer.TabIndex = 5
            Me.pbManoDer.TabStop = False
            '
            'pnlManoIzq
            '
            Me.pnlManoIzq.Controls.Add(Me.lblObsManIzq)
            Me.pnlManoIzq.Controls.Add(Me.pnlManoIzqDetalle)
            Me.pnlManoIzq.Controls.Add(Me.pbManoIzq)
            Me.pnlManoIzq.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlManoIzq.Location = New System.Drawing.Point(0, 0)
            Me.pnlManoIzq.Name = "pnlManoIzq"
            Me.pnlManoIzq.Size = New System.Drawing.Size(188, 76)
            Me.pnlManoIzq.TabIndex = 21
            '
            'lblObsManIzq
            '
            Me.lblObsManIzq.AutoSize = True
            Me.lblObsManIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObsManIzq.Location = New System.Drawing.Point(4, 57)
            Me.lblObsManIzq.Name = "lblObsManIzq"
            Me.lblObsManIzq.Size = New System.Drawing.Size(66, 15)
            Me.lblObsManIzq.TabIndex = 21
            Me.lblObsManIzq.Text = "Observado"
            Me.lblObsManIzq.Visible = False
            '
            'pnlManoIzqDetalle
            '
            Me.pnlManoIzqDetalle.Controls.Add(Me.pbCalidadManoIzq)
            Me.pnlManoIzqDetalle.Controls.Add(Me.chkHueIzq)
            Me.pnlManoIzqDetalle.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlManoIzqDetalle.Location = New System.Drawing.Point(73, 0)
            Me.pnlManoIzqDetalle.Name = "pnlManoIzqDetalle"
            Me.pnlManoIzqDetalle.Size = New System.Drawing.Size(106, 76)
            Me.pnlManoIzqDetalle.TabIndex = 21
            '
            'pbCalidadManoIzq
            '
            Me.pbCalidadManoIzq.BackColor = System.Drawing.Color.White
            Me.pbCalidadManoIzq.Location = New System.Drawing.Point(3, 2)
            Me.pbCalidadManoIzq.Name = "pbCalidadManoIzq"
            Me.pbCalidadManoIzq.Size = New System.Drawing.Size(36, 36)
            Me.pbCalidadManoIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbCalidadManoIzq.TabIndex = 25
            Me.pbCalidadManoIzq.TabStop = False
            '
            'chkHueIzq
            '
            Me.chkHueIzq.AutoSize = True
            Me.chkHueIzq.BackColor = System.Drawing.Color.White
            Me.chkHueIzq.Checked = True
            Me.chkHueIzq.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkHueIzq.Location = New System.Drawing.Point(3, 40)
            Me.chkHueIzq.Name = "chkHueIzq"
            Me.chkHueIzq.Size = New System.Drawing.Size(101, 17)
            Me.chkHueIzq.TabIndex = 23
            Me.chkHueIzq.Text = "Indice Izquierdo"
            Me.chkHueIzq.UseVisualStyleBackColor = False
            '
            'pbManoIzq
            '
            Me.pbManoIzq.BackColor = System.Drawing.Color.White
            Me.pbManoIzq.Dock = System.Windows.Forms.DockStyle.Left
            Me.pbManoIzq.Image = Global.APPControlHuellaVisita.My.Resources.Resources.mano_izquierda
            Me.pbManoIzq.Location = New System.Drawing.Point(0, 0)
            Me.pbManoIzq.Name = "pbManoIzq"
            Me.pbManoIzq.Size = New System.Drawing.Size(73, 76)
            Me.pbManoIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbManoIzq.TabIndex = 6
            Me.pbManoIzq.TabStop = False
            '
            'Timer1
            '
            Me.Timer1.Interval = 500
            '
            'frmIdentificarPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(437, 489)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Controls.Add(Me.lblEstado)
            Me.Controls.Add(Me.pnlPie)
            Me.Controls.Add(Me.pnlConfiguracion)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmIdentificarPopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Captura dactilar"
            Me.pnlConfiguracion.ResumeLayout(False)
            Me.pnlConfiguracion.PerformLayout()
            Me.pnlPie.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.pbLeyendaColor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbHuella, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlManoDer.ResumeLayout(False)
            Me.pnlManoDer.PerformLayout()
            Me.pnlManoDerDetalle.ResumeLayout(False)
            Me.pnlManoDerDetalle.PerformLayout()
            CType(Me.pbCalidadManoDer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbManoDer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlManoIzq.ResumeLayout(False)
            Me.pnlManoIzq.PerformLayout()
            Me.pnlManoIzqDetalle.ResumeLayout(False)
            Me.pnlManoIzqDetalle.PerformLayout()
            CType(Me.pbCalidadManoIzq, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbManoIzq, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pbHuella As System.Windows.Forms.PictureBox
        Friend WithEvents lblEstado As System.Windows.Forms.Label
        Friend WithEvents pnlConfiguracion As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents CBDeviceIndex As System.Windows.Forms.ComboBox
        Private WithEvents pbLeyendaColor As System.Windows.Forms.PictureBox
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents btnRecapturar As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCapturarHuella As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlManoDer As System.Windows.Forms.Panel
        Friend WithEvents lblObsManDer As System.Windows.Forms.Label
        Friend WithEvents pnlManoDerDetalle As System.Windows.Forms.Panel
        Friend WithEvents pbCalidadManoDer As System.Windows.Forms.PictureBox
        Friend WithEvents chkHueDer As System.Windows.Forms.CheckBox
        Friend WithEvents pbManoDer As System.Windows.Forms.PictureBox
        Friend WithEvents pnlManoIzq As System.Windows.Forms.Panel
        Friend WithEvents lblObsManIzq As System.Windows.Forms.Label
        Friend WithEvents pnlManoIzqDetalle As System.Windows.Forms.Panel
        Friend WithEvents pbCalidadManoIzq As System.Windows.Forms.PictureBox
        Friend WithEvents chkHueIzq As System.Windows.Forms.CheckBox
        Friend WithEvents pbManoIzq As System.Windows.Forms.PictureBox
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
    End Class

End Namespace