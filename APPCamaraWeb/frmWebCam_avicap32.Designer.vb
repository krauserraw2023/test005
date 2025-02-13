<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebCam_avicap32
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWebCam_avicap32))
        Me.picCaptura = New System.Windows.Forms.PictureBox()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lstDispositivos = New System.Windows.Forms.ListBox()
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picCaptura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCaptura
        '
        Me.picCaptura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCaptura.BackColor = System.Drawing.Color.Transparent
        Me.picCaptura.InitialImage = Nothing
        Me.picCaptura.Location = New System.Drawing.Point(0, 6)
        Me.picCaptura.Name = "picCaptura"
        Me.picCaptura.Size = New System.Drawing.Size(519, 452)
        Me.picCaptura.TabIndex = 1
        Me.picCaptura.TabStop = False
        '
        'btnCapturar
        '
        Me.btnCapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapturar.ForeColor = System.Drawing.Color.Black
        Me.btnCapturar.Image = Global.APPCamaraWeb.My.Resources.Resources._1337706653_webcam
        Me.btnCapturar.Location = New System.Drawing.Point(536, 320)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(88, 63)
        Me.btnCapturar.TabIndex = 70
        Me.btnCapturar.Text = "&Capurar"
        Me.btnCapturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCapturar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(536, 388)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 63)
        Me.btnSalir.TabIndex = 71
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lstDispositivos
        '
        Me.lstDispositivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDispositivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstDispositivos.Location = New System.Drawing.Point(245, 86)
        Me.lstDispositivos.Name = "lstDispositivos"
        Me.lstDispositivos.Size = New System.Drawing.Size(88, 212)
        Me.lstDispositivos.TabIndex = 72
        '
        'sfdImage
        '
        Me.sfdImage.FileName = "Webcam1"
        Me.sfdImage.Filter = "Bitmap|*.bmp"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(96, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(339, 5)
        Me.Label3.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(97, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 5)
        Me.Label4.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(94, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(4, 452)
        Me.Label1.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(432, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(4, 452)
        Me.Label5.TabIndex = 77
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(536, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 63)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "&Iniciar >>>"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'frmWebCam_avicap32
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 459)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCapturar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.picCaptura)
        Me.Controls.Add(Me.lstDispositivos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWebCam_avicap32"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capturar Fotografia..."
        CType(Me.picCaptura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picCaptura As Windows.Forms.PictureBox
    Friend WithEvents btnCapturar As Windows.Forms.Button
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents lstDispositivos As Windows.Forms.ListBox
    Friend WithEvents sfdImage As Windows.Forms.SaveFileDialog
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
