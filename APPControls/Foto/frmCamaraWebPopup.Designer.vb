Namespace Foto
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCamaraWebPopup
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCamaraWebPopup))
            Me.PicResultado = New System.Windows.Forms.PictureBox()
            Me.WebCam1 = New WebCAM.WebCam()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            CType(Me.PicResultado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.btnGrabar)
            Me.gbxFormChildContainer.Controls.Add(Me.btnSalir)
            Me.gbxFormChildContainer.Controls.Add(Me.Label4)
            Me.gbxFormChildContainer.Controls.Add(Me.Label3)
            Me.gbxFormChildContainer.Controls.Add(Me.Label2)
            Me.gbxFormChildContainer.Controls.Add(Me.Label1)
            Me.gbxFormChildContainer.Controls.Add(Me.PicResultado)
            Me.gbxFormChildContainer.Controls.Add(Me.WebCam1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(630, 459)
            '
            'PicResultado
            '
            Me.PicResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PicResultado.Location = New System.Drawing.Point(638, 6)
            Me.PicResultado.Name = "PicResultado"
            Me.PicResultado.Size = New System.Drawing.Size(532, 452)
            Me.PicResultado.TabIndex = 19
            Me.PicResultado.TabStop = False
            '
            'WebCam1
            '
            Me.WebCam1.BackColor = System.Drawing.Color.Transparent
            Me.WebCam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.WebCam1.Imagen = Nothing
            Me.WebCam1.Location = New System.Drawing.Point(0, 6)
            Me.WebCam1.MilisegundosCaptura = 100
            Me.WebCam1.Name = "WebCam1"
            Me.WebCam1.Size = New System.Drawing.Size(532, 452)
            Me.WebCam1.TabIndex = 18
            '
            'Timer1
            '
            Me.Timer1.Interval = 120
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Red
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Location = New System.Drawing.Point(436, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(4, 452)
            Me.Label1.TabIndex = 23
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Red
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label2.Location = New System.Drawing.Point(98, 7)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(4, 452)
            Me.Label2.TabIndex = 24
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Red
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label3.Location = New System.Drawing.Point(101, 454)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(339, 5)
            Me.Label3.TabIndex = 25
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Red
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label4.Location = New System.Drawing.Point(101, 7)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(339, 5)
            Me.Label4.TabIndex = 26
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.ForeColor = System.Drawing.Color.Black
            Me.btnGrabar.Image = Global.APPControls.My.Resources.Resources._1337706653_webcam
            Me.btnGrabar.Location = New System.Drawing.Point(535, 327)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(88, 63)
            Me.btnGrabar.TabIndex = 68
            Me.btnGrabar.Text = "&Capurar"
            Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(535, 395)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 63)
            Me.btnSalir.TabIndex = 69
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'frmCamaraWebPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(630, 459)
            Me.Name = "frmCamaraWebPopup"
            Me.Text = "Camara Web..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            CType(Me.PicResultado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PicResultado As System.Windows.Forms.PictureBox
        Friend WithEvents WebCam1 As WebCAM.WebCam
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
    End Class
End Namespace