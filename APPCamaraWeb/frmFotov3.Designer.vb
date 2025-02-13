<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFotov3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFotov3))
        Me.pbCamaraWeb = New System.Windows.Forms.PictureBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.PicResultado = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbWebcam = New System.Windows.Forms.ComboBox()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbxFormChildContainer.SuspendLayout()
        CType(Me.pbCamaraWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxFormChildContainer
        '
        Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
        Me.gbxFormChildContainer.Controls.Add(Me.btnExportar)
        Me.gbxFormChildContainer.Controls.Add(Me.btnIniciar)
        Me.gbxFormChildContainer.Controls.Add(Me.btnCapturar)
        Me.gbxFormChildContainer.Controls.Add(Me.PicResultado)
        Me.gbxFormChildContainer.Controls.Add(Me.btnSalir)
        Me.gbxFormChildContainer.Controls.Add(Me.cbbWebcam)
        Me.gbxFormChildContainer.Controls.Add(Me.Label2)
        Me.gbxFormChildContainer.Size = New System.Drawing.Size(631, 490)
        '
        'pbCamaraWeb
        '
        Me.pbCamaraWeb.Location = New System.Drawing.Point(11, 0)
        Me.pbCamaraWeb.Name = "pbCamaraWeb"
        Me.pbCamaraWeb.Size = New System.Drawing.Size(532, 452)
        Me.pbCamaraWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCamaraWeb.TabIndex = 0
        Me.pbCamaraWeb.TabStop = False
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(537, 183)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(88, 63)
        Me.btnExportar.TabIndex = 12
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        Me.btnExportar.Visible = False
        '
        'PicResultado
        '
        Me.PicResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicResultado.Location = New System.Drawing.Point(554, 26)
        Me.PicResultado.Name = "PicResultado"
        Me.PicResultado.Size = New System.Drawing.Size(65, 68)
        Me.PicResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicResultado.TabIndex = 11
        Me.PicResultado.TabStop = False
        Me.PicResultado.Visible = False
        Me.PicResultado.WaitOnLoad = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(7, 464)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seleccionar dispositivo :"
        '
        'cbbWebcam
        '
        Me.cbbWebcam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbWebcam.FormattingEnabled = True
        Me.cbbWebcam.Location = New System.Drawing.Point(139, 460)
        Me.cbbWebcam.Name = "cbbWebcam"
        Me.cbbWebcam.Size = New System.Drawing.Size(237, 21)
        Me.cbbWebcam.TabIndex = 1
        '
        'btnCapturar
        '
        Me.btnCapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapturar.ForeColor = System.Drawing.Color.Black
        Me.btnCapturar.Image = Global.APPCamaraWeb.My.Resources.Resources._1337706653_webcam
        Me.btnCapturar.Location = New System.Drawing.Point(537, 321)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(88, 63)
        Me.btnCapturar.TabIndex = 68
        Me.btnCapturar.Text = "&Capurar"
        Me.btnCapturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCapturar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(537, 389)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 63)
        Me.btnSalir.TabIndex = 69
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.Color.Black
        Me.btnIniciar.Location = New System.Drawing.Point(537, 252)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(88, 63)
        Me.btnIniciar.TabIndex = 70
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIniciar.UseVisualStyleBackColor = True
        Me.btnIniciar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.pbCamaraWeb)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 452)
        Me.Panel1.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(96, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(339, 5)
        Me.Label3.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(97, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 5)
        Me.Label4.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(94, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(4, 452)
        Me.Label1.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(432, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(4, 452)
        Me.Label5.TabIndex = 73
        '
        'frmFotov3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 490)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFotov3"
        Me.Text = "Capturar Fotografia..."
        Me.gbxFormChildContainer.ResumeLayout(False)
        Me.gbxFormChildContainer.PerformLayout()
        CType(Me.pbCamaraWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbCamaraWeb As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbbWebcam As System.Windows.Forms.ComboBox
    Friend WithEvents PicResultado As System.Windows.Forms.PictureBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnCapturar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
