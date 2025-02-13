Namespace Visita.Huella


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmIdentificarPopup
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
            Me.pbManoIzq = New System.Windows.Forms.PictureBox()
            Me.pbManoDer = New System.Windows.Forms.PictureBox()
            Me.pbHuella = New System.Windows.Forms.PictureBox()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.lblLeyenda = New System.Windows.Forms.Label()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.btnRecapturar = New System.Windows.Forms.Button()
            Me.btnCapturarHuella = New System.Windows.Forms.Button()
            Me.chkHueIzq = New System.Windows.Forms.CheckBox()
            Me.chkHueDer = New System.Windows.Forms.CheckBox()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.pnlManoDer = New System.Windows.Forms.Panel()
            Me.lblObsManDer = New System.Windows.Forms.Label()
            Me.pnlManoDerDetalle = New System.Windows.Forms.Panel()
            Me.pbCalidadManoDer = New System.Windows.Forms.PictureBox()
            Me.pnlManoIzq = New System.Windows.Forms.Panel()
            Me.lblObsManIzq = New System.Windows.Forms.Label()
            Me.pnlManoIzqDetalle = New System.Windows.Forms.Panel()
            Me.pbCalidadManoIzq = New System.Windows.Forms.PictureBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.UscCaptura1 = New APPControlHuellaVisita.uscCaptura()
            Me.gbxFormChildContainer.SuspendLayout()
            CType(Me.pbManoIzq, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbManoDer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbHuella, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlPie.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlManoDer.SuspendLayout()
            Me.pnlManoDerDetalle.SuspendLayout()
            CType(Me.pbCalidadManoDer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlManoIzq.SuspendLayout()
            Me.pnlManoIzqDetalle.SuspendLayout()
            CType(Me.pbCalidadManoIzq, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlCabecera)
            Me.gbxFormChildContainer.Controls.Add(Me.lblLeyenda)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlPie)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(437, 489)
            '
            'pbManoIzq
            '
            Me.pbManoIzq.BackColor = System.Drawing.Color.White
            Me.pbManoIzq.Dock = System.Windows.Forms.DockStyle.Left
            Me.pbManoIzq.ErrorImage = Global.APPControls.My.Resources.Resources.huella_x
            Me.pbManoIzq.Image = Global.APPControls.My.Resources.Resources.mano_izquierda
            Me.pbManoIzq.Location = New System.Drawing.Point(0, 0)
            Me.pbManoIzq.Name = "pbManoIzq"
            Me.pbManoIzq.Size = New System.Drawing.Size(73, 76)
            Me.pbManoIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbManoIzq.TabIndex = 6
            Me.pbManoIzq.TabStop = False
            '
            'pbManoDer
            '
            Me.pbManoDer.BackColor = System.Drawing.Color.White
            Me.pbManoDer.Dock = System.Windows.Forms.DockStyle.Right
            Me.pbManoDer.ErrorImage = Global.APPControls.My.Resources.Resources.huella_x
            Me.pbManoDer.Image = Global.APPControls.My.Resources.Resources.mano_derecha
            Me.pbManoDer.Location = New System.Drawing.Point(115, 0)
            Me.pbManoDer.Name = "pbManoDer"
            Me.pbManoDer.Size = New System.Drawing.Size(73, 76)
            Me.pbManoDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbManoDer.TabIndex = 5
            Me.pbManoDer.TabStop = False
            '
            'pbHuella
            '
            Me.pbHuella.BackColor = System.Drawing.Color.White
            Me.pbHuella.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbHuella.Image = Global.APPControls.My.Resources.Resources.huella_lupa
            Me.pbHuella.Location = New System.Drawing.Point(0, 0)
            Me.pbHuella.Name = "pbHuella"
            Me.pbHuella.Size = New System.Drawing.Size(437, 345)
            Me.pbHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbHuella.TabIndex = 0
            Me.pbHuella.TabStop = False
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(221, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(101, 42)
            Me.btnAceptar.TabIndex = 2
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnSalir
            '
            Me.btnSalir.Enabled = False
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.APPControls.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(328, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(101, 42)
            Me.btnSalir.TabIndex = 3
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'lblLeyenda
            '
            Me.lblLeyenda.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblLeyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLeyenda.Location = New System.Drawing.Point(0, 421)
            Me.lblLeyenda.Name = "lblLeyenda"
            Me.lblLeyenda.Size = New System.Drawing.Size(437, 20)
            Me.lblLeyenda.TabIndex = 21
            Me.lblLeyenda.Text = "Iniciando equipo, espere..."
            Me.lblLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.pnlPie.TabIndex = 22
            '
            'btnRecapturar
            '
            Me.btnRecapturar.Enabled = False
            Me.btnRecapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRecapturar.ForeColor = System.Drawing.Color.Black
            Me.btnRecapturar.Image = Global.APPControls.My.Resources.Resources.recapturar
            Me.btnRecapturar.Location = New System.Drawing.Point(111, 3)
            Me.btnRecapturar.Name = "btnRecapturar"
            Me.btnRecapturar.Size = New System.Drawing.Size(105, 42)
            Me.btnRecapturar.TabIndex = 19
            Me.btnRecapturar.UseVisualStyleBackColor = False
            Me.btnRecapturar.Visible = False
            '
            'btnCapturarHuella
            '
            Me.btnCapturarHuella.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapturarHuella.Image = Global.APPControls.My.Resources.Resources.capturar
            Me.btnCapturarHuella.Location = New System.Drawing.Point(5, 3)
            Me.btnCapturarHuella.Name = "btnCapturarHuella"
            Me.btnCapturarHuella.Size = New System.Drawing.Size(101, 42)
            Me.btnCapturarHuella.TabIndex = 18
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
            'pnlCabecera
            '
            Me.pnlCabecera.BackColor = System.Drawing.Color.White
            Me.pnlCabecera.Controls.Add(Me.pnlManoDer)
            Me.pnlCabecera.Controls.Add(Me.pnlManoIzq)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(437, 76)
            Me.pnlCabecera.TabIndex = 26
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
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.UscCaptura1)
            Me.Panel3.Controls.Add(Me.pbHuella)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 76)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(437, 345)
            Me.Panel3.TabIndex = 27
            '
            'UscCaptura1
            '
            Me.UscCaptura1._CalidadIndiceHuellaCapturada = APPControlHuellaVisita.Type.Enumeracion.IndiceCalidadHuella.NoEspecificado
            Me.UscCaptura1._ImagenHuella = Nothing
            Me.UscCaptura1._MostrarLeyenda = False
            Me.UscCaptura1._TemplateANSI = Nothing
            Me.UscCaptura1._TemplateSUPREMA = Nothing
            Me.UscCaptura1._WSQ = Nothing
            Me.UscCaptura1.BackColor = System.Drawing.Color.White
            Me.UscCaptura1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscCaptura1.Location = New System.Drawing.Point(0, 0)
            Me.UscCaptura1.Name = "UscCaptura1"
            Me.UscCaptura1.Size = New System.Drawing.Size(437, 345)
            Me.UscCaptura1.TabIndex = 20
            '
            'frmIdentificarPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(437, 489)
            Me.Name = "frmIdentificarPopup"
            Me.Text = "Proceso de Verificacion de Huella Digital"
            Me.gbxFormChildContainer.ResumeLayout(False)
            CType(Me.pbManoIzq, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbManoDer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbHuella, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlPie.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlManoDer.ResumeLayout(False)
            Me.pnlManoDer.PerformLayout()
            Me.pnlManoDerDetalle.ResumeLayout(False)
            Me.pnlManoDerDetalle.PerformLayout()
            CType(Me.pbCalidadManoDer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlManoIzq.ResumeLayout(False)
            Me.pnlManoIzq.PerformLayout()
            Me.pnlManoIzqDetalle.ResumeLayout(False)
            Me.pnlManoIzqDetalle.PerformLayout()
            CType(Me.pbCalidadManoIzq, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pbHuella As System.Windows.Forms.PictureBox
        Friend WithEvents pbManoDer As System.Windows.Forms.PictureBox
        Friend WithEvents pbManoIzq As System.Windows.Forms.PictureBox
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents UscCaptura1 As APPControlHuellaVisita.uscCaptura
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents lblLeyenda As System.Windows.Forms.Label
        Friend WithEvents btnCapturarHuella As System.Windows.Forms.Button
        Friend WithEvents chkHueIzq As System.Windows.Forms.CheckBox
        Friend WithEvents chkHueDer As System.Windows.Forms.CheckBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlManoDer As System.Windows.Forms.Panel
        Friend WithEvents pbCalidadManoDer As System.Windows.Forms.PictureBox
        Friend WithEvents pnlManoIzq As System.Windows.Forms.Panel
        Friend WithEvents pbCalidadManoIzq As System.Windows.Forms.PictureBox
        Friend WithEvents pnlManoDerDetalle As System.Windows.Forms.Panel
        Friend WithEvents pnlManoIzqDetalle As System.Windows.Forms.Panel
        Friend WithEvents btnRecapturar As System.Windows.Forms.Button
        Friend WithEvents lblObsManDer As System.Windows.Forms.Label
        Friend WithEvents lblObsManIzq As System.Windows.Forms.Label
    End Class

End Namespace