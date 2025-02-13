Namespace Huellero.FS10
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscValidarHuellaBasic
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lblCalidad = New System.Windows.Forms.Label()
            Me.PBox_PreviewHuellas = New System.Windows.Forms.PictureBox()
            Me.btnCapturar = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.rbIndDer = New System.Windows.Forms.RadioButton()
            Me.rbMenDer = New System.Windows.Forms.RadioButton()
            Me.rbAnuDer = New System.Windows.Forms.RadioButton()
            Me.rbMedDer = New System.Windows.Forms.RadioButton()
            Me.rbPulDer = New System.Windows.Forms.RadioButton()
            Me.rbPulIzq = New System.Windows.Forms.RadioButton()
            Me.rbIndIzq = New System.Windows.Forms.RadioButton()
            Me.rbMedIzq = New System.Windows.Forms.RadioButton()
            Me.rbAnuIzq = New System.Windows.Forms.RadioButton()
            Me.rbMenIzq = New System.Windows.Forms.RadioButton()
            Me.usc_der_men = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_der_anu = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_der_med = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_der_ind = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_der_pul = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_izq_pul = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_izq_ind = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_izq_med = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_izq_anu = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_izq_men = New APPControlHuellaVisita.uscIconFinger()
            Me.PictureBox12 = New System.Windows.Forms.PictureBox()
            Me.PictureBox13 = New System.Windows.Forms.PictureBox()
            Me.uscHuellaThumb = New APPControlHuellaVisita.uscThumbFinger()
            Me.Panel2.SuspendLayout()
            CType(Me.PBox_PreviewHuellas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.lblCalidad)
            Me.Panel2.Controls.Add(Me.PBox_PreviewHuellas)
            Me.Panel2.Controls.Add(Me.btnCapturar)
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.rbIndDer)
            Me.Panel2.Controls.Add(Me.rbMenDer)
            Me.Panel2.Controls.Add(Me.rbAnuDer)
            Me.Panel2.Controls.Add(Me.rbMedDer)
            Me.Panel2.Controls.Add(Me.rbPulDer)
            Me.Panel2.Controls.Add(Me.rbPulIzq)
            Me.Panel2.Controls.Add(Me.rbIndIzq)
            Me.Panel2.Controls.Add(Me.rbMedIzq)
            Me.Panel2.Controls.Add(Me.rbAnuIzq)
            Me.Panel2.Controls.Add(Me.rbMenIzq)
            Me.Panel2.Controls.Add(Me.usc_der_men)
            Me.Panel2.Controls.Add(Me.usc_der_anu)
            Me.Panel2.Controls.Add(Me.usc_der_med)
            Me.Panel2.Controls.Add(Me.usc_der_ind)
            Me.Panel2.Controls.Add(Me.usc_der_pul)
            Me.Panel2.Controls.Add(Me.usc_izq_pul)
            Me.Panel2.Controls.Add(Me.usc_izq_ind)
            Me.Panel2.Controls.Add(Me.usc_izq_med)
            Me.Panel2.Controls.Add(Me.usc_izq_anu)
            Me.Panel2.Controls.Add(Me.usc_izq_men)
            Me.Panel2.Controls.Add(Me.PictureBox12)
            Me.Panel2.Controls.Add(Me.PictureBox13)
            Me.Panel2.Controls.Add(Me.uscHuellaThumb)
            Me.Panel2.Location = New System.Drawing.Point(3, 3)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(472, 197)
            Me.Panel2.TabIndex = 27
            '
            'lblCalidad
            '
            Me.lblCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCalidad.Location = New System.Drawing.Point(158, 3)
            Me.lblCalidad.Name = "lblCalidad"
            Me.lblCalidad.Size = New System.Drawing.Size(24, 24)
            Me.lblCalidad.TabIndex = 50
            Me.lblCalidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'PBox_PreviewHuellas
            '
            Me.PBox_PreviewHuellas.BackColor = System.Drawing.Color.White
            Me.PBox_PreviewHuellas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PBox_PreviewHuellas.Location = New System.Drawing.Point(156, 1)
            Me.PBox_PreviewHuellas.Margin = New System.Windows.Forms.Padding(2)
            Me.PBox_PreviewHuellas.Name = "PBox_PreviewHuellas"
            Me.PBox_PreviewHuellas.Size = New System.Drawing.Size(138, 157)
            Me.PBox_PreviewHuellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PBox_PreviewHuellas.TabIndex = 49
            Me.PBox_PreviewHuellas.TabStop = False
            '
            'btnCapturar
            '
            Me.btnCapturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
            Me.btnCapturar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
            Me.btnCapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapturar.ForeColor = System.Drawing.Color.White
            Me.btnCapturar.Location = New System.Drawing.Point(191, 162)
            Me.btnCapturar.Name = "btnCapturar"
            Me.btnCapturar.Size = New System.Drawing.Size(70, 33)
            Me.btnCapturar.TabIndex = 47
            Me.btnCapturar.Text = "Iniciar"
            Me.btnCapturar.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.DimGray
            Me.Label2.Location = New System.Drawing.Point(354, 162)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(69, 17)
            Me.Label2.TabIndex = 44
            Me.Label2.Text = "Derecha"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.DimGray
            Me.Label1.Location = New System.Drawing.Point(27, 160)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(75, 17)
            Me.Label1.TabIndex = 43
            Me.Label1.Text = "Izquierda"
            '
            'rbIndDer
            '
            Me.rbIndDer.AutoSize = True
            Me.rbIndDer.BackColor = System.Drawing.Color.Gray
            Me.rbIndDer.Location = New System.Drawing.Point(352, 25)
            Me.rbIndDer.Name = "rbIndDer"
            Me.rbIndDer.Size = New System.Drawing.Size(14, 13)
            Me.rbIndDer.TabIndex = 42
            Me.rbIndDer.UseVisualStyleBackColor = False
            Me.rbIndDer.Visible = False
            '
            'rbMenDer
            '
            Me.rbMenDer.AutoSize = True
            Me.rbMenDer.BackColor = System.Drawing.Color.Gray
            Me.rbMenDer.Location = New System.Drawing.Point(433, 59)
            Me.rbMenDer.Name = "rbMenDer"
            Me.rbMenDer.Size = New System.Drawing.Size(14, 13)
            Me.rbMenDer.TabIndex = 31
            Me.rbMenDer.UseVisualStyleBackColor = False
            Me.rbMenDer.Visible = False
            '
            'rbAnuDer
            '
            Me.rbAnuDer.AutoSize = True
            Me.rbAnuDer.BackColor = System.Drawing.Color.Gray
            Me.rbAnuDer.Location = New System.Drawing.Point(408, 26)
            Me.rbAnuDer.Name = "rbAnuDer"
            Me.rbAnuDer.Size = New System.Drawing.Size(14, 13)
            Me.rbAnuDer.TabIndex = 31
            Me.rbAnuDer.UseVisualStyleBackColor = False
            Me.rbAnuDer.Visible = False
            '
            'rbMedDer
            '
            Me.rbMedDer.AutoSize = True
            Me.rbMedDer.BackColor = System.Drawing.Color.Gray
            Me.rbMedDer.Location = New System.Drawing.Point(381, 11)
            Me.rbMedDer.Name = "rbMedDer"
            Me.rbMedDer.Size = New System.Drawing.Size(14, 13)
            Me.rbMedDer.TabIndex = 31
            Me.rbMedDer.UseVisualStyleBackColor = False
            Me.rbMedDer.Visible = False
            '
            'rbPulDer
            '
            Me.rbPulDer.AutoSize = True
            Me.rbPulDer.BackColor = System.Drawing.Color.Gray
            Me.rbPulDer.Location = New System.Drawing.Point(325, 87)
            Me.rbPulDer.Name = "rbPulDer"
            Me.rbPulDer.Size = New System.Drawing.Size(14, 13)
            Me.rbPulDer.TabIndex = 31
            Me.rbPulDer.UseVisualStyleBackColor = False
            Me.rbPulDer.Visible = False
            '
            'rbPulIzq
            '
            Me.rbPulIzq.AutoSize = True
            Me.rbPulIzq.BackColor = System.Drawing.Color.Gray
            Me.rbPulIzq.Location = New System.Drawing.Point(114, 87)
            Me.rbPulIzq.Name = "rbPulIzq"
            Me.rbPulIzq.Size = New System.Drawing.Size(14, 13)
            Me.rbPulIzq.TabIndex = 31
            Me.rbPulIzq.UseVisualStyleBackColor = False
            Me.rbPulIzq.Visible = False
            '
            'rbIndIzq
            '
            Me.rbIndIzq.AutoSize = True
            Me.rbIndIzq.BackColor = System.Drawing.Color.Gray
            Me.rbIndIzq.Checked = True
            Me.rbIndIzq.Location = New System.Drawing.Point(87, 26)
            Me.rbIndIzq.Name = "rbIndIzq"
            Me.rbIndIzq.Size = New System.Drawing.Size(14, 13)
            Me.rbIndIzq.TabIndex = 31
            Me.rbIndIzq.TabStop = True
            Me.rbIndIzq.UseVisualStyleBackColor = False
            Me.rbIndIzq.Visible = False
            '
            'rbMedIzq
            '
            Me.rbMedIzq.AutoSize = True
            Me.rbMedIzq.BackColor = System.Drawing.Color.Gray
            Me.rbMedIzq.Location = New System.Drawing.Point(60, 11)
            Me.rbMedIzq.Name = "rbMedIzq"
            Me.rbMedIzq.Size = New System.Drawing.Size(14, 13)
            Me.rbMedIzq.TabIndex = 31
            Me.rbMedIzq.UseVisualStyleBackColor = False
            Me.rbMedIzq.Visible = False
            '
            'rbAnuIzq
            '
            Me.rbAnuIzq.AutoSize = True
            Me.rbAnuIzq.BackColor = System.Drawing.Color.Gray
            Me.rbAnuIzq.Location = New System.Drawing.Point(34, 28)
            Me.rbAnuIzq.Name = "rbAnuIzq"
            Me.rbAnuIzq.Size = New System.Drawing.Size(14, 13)
            Me.rbAnuIzq.TabIndex = 31
            Me.rbAnuIzq.UseVisualStyleBackColor = False
            Me.rbAnuIzq.Visible = False
            '
            'rbMenIzq
            '
            Me.rbMenIzq.AutoSize = True
            Me.rbMenIzq.BackColor = System.Drawing.Color.Gray
            Me.rbMenIzq.Location = New System.Drawing.Point(7, 56)
            Me.rbMenIzq.Name = "rbMenIzq"
            Me.rbMenIzq.Size = New System.Drawing.Size(14, 13)
            Me.rbMenIzq.TabIndex = 31
            Me.rbMenIzq.UseVisualStyleBackColor = False
            Me.rbMenIzq.Visible = False
            '
            'usc_der_men
            '
            Me.usc_der_men.BackColor = System.Drawing.Color.Gray
            Me.usc_der_men.Location = New System.Drawing.Point(428, 48)
            Me.usc_der_men.Name = "usc_der_men"
            Me.usc_der_men.Size = New System.Drawing.Size(23, 46)
            Me.usc_der_men.TabIndex = 41
            Me.usc_der_men.Visible = False
            '
            'usc_der_anu
            '
            Me.usc_der_anu.BackColor = System.Drawing.Color.Gray
            Me.usc_der_anu.Location = New System.Drawing.Point(401, 16)
            Me.usc_der_anu.Name = "usc_der_anu"
            Me.usc_der_anu.Size = New System.Drawing.Size(24, 46)
            Me.usc_der_anu.TabIndex = 40
            Me.usc_der_anu.Visible = False
            '
            'usc_der_med
            '
            Me.usc_der_med.BackColor = System.Drawing.Color.Gray
            Me.usc_der_med.Location = New System.Drawing.Point(375, 2)
            Me.usc_der_med.Name = "usc_der_med"
            Me.usc_der_med.Size = New System.Drawing.Size(23, 46)
            Me.usc_der_med.TabIndex = 39
            Me.usc_der_med.Visible = False
            '
            'usc_der_ind
            '
            Me.usc_der_ind.BackColor = System.Drawing.Color.Gray
            Me.usc_der_ind.Location = New System.Drawing.Point(347, 16)
            Me.usc_der_ind.Name = "usc_der_ind"
            Me.usc_der_ind.Size = New System.Drawing.Size(23, 46)
            Me.usc_der_ind.TabIndex = 38
            Me.usc_der_ind.Visible = False
            '
            'usc_der_pul
            '
            Me.usc_der_pul.BackColor = System.Drawing.Color.Gray
            Me.usc_der_pul.Location = New System.Drawing.Point(320, 79)
            Me.usc_der_pul.Name = "usc_der_pul"
            Me.usc_der_pul.Size = New System.Drawing.Size(23, 37)
            Me.usc_der_pul.TabIndex = 37
            Me.usc_der_pul.Visible = False
            '
            'usc_izq_pul
            '
            Me.usc_izq_pul.BackColor = System.Drawing.Color.Gray
            Me.usc_izq_pul.Location = New System.Drawing.Point(109, 79)
            Me.usc_izq_pul.Name = "usc_izq_pul"
            Me.usc_izq_pul.Size = New System.Drawing.Size(24, 35)
            Me.usc_izq_pul.TabIndex = 36
            Me.usc_izq_pul.Visible = False
            '
            'usc_izq_ind
            '
            Me.usc_izq_ind.BackColor = System.Drawing.Color.Gray
            Me.usc_izq_ind.Location = New System.Drawing.Point(81, 17)
            Me.usc_izq_ind.Name = "usc_izq_ind"
            Me.usc_izq_ind.Size = New System.Drawing.Size(24, 46)
            Me.usc_izq_ind.TabIndex = 35
            Me.usc_izq_ind.Visible = False
            '
            'usc_izq_med
            '
            Me.usc_izq_med.BackColor = System.Drawing.Color.Gray
            Me.usc_izq_med.Location = New System.Drawing.Point(54, 3)
            Me.usc_izq_med.Name = "usc_izq_med"
            Me.usc_izq_med.Size = New System.Drawing.Size(23, 46)
            Me.usc_izq_med.TabIndex = 34
            Me.usc_izq_med.Visible = False
            '
            'usc_izq_anu
            '
            Me.usc_izq_anu.BackColor = System.Drawing.Color.Gray
            Me.usc_izq_anu.Location = New System.Drawing.Point(28, 16)
            Me.usc_izq_anu.Name = "usc_izq_anu"
            Me.usc_izq_anu.Size = New System.Drawing.Size(23, 46)
            Me.usc_izq_anu.TabIndex = 33
            Me.usc_izq_anu.Visible = False
            '
            'usc_izq_men
            '
            Me.usc_izq_men.BackColor = System.Drawing.Color.Gray
            Me.usc_izq_men.Location = New System.Drawing.Point(2, 47)
            Me.usc_izq_men.Name = "usc_izq_men"
            Me.usc_izq_men.Size = New System.Drawing.Size(22, 46)
            Me.usc_izq_men.TabIndex = 32
            Me.usc_izq_men.Visible = False
            '
            'PictureBox12
            '
            Me.PictureBox12.BackColor = System.Drawing.Color.White
            Me.PictureBox12.Image = Global.APPControlHuellaVisita.My.Resources.Resources.mano_izquierda03
            Me.PictureBox12.Location = New System.Drawing.Point(-16, 2)
            Me.PictureBox12.Name = "PictureBox12"
            Me.PictureBox12.Size = New System.Drawing.Size(168, 193)
            Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox12.TabIndex = 5
            Me.PictureBox12.TabStop = False
            '
            'PictureBox13
            '
            Me.PictureBox13.BackColor = System.Drawing.Color.White
            Me.PictureBox13.Image = Global.APPControlHuellaVisita.My.Resources.Resources.mano_derecha03
            Me.PictureBox13.Location = New System.Drawing.Point(301, 2)
            Me.PictureBox13.Name = "PictureBox13"
            Me.PictureBox13.Size = New System.Drawing.Size(168, 193)
            Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox13.TabIndex = 5
            Me.PictureBox13.TabStop = False
            '
            'uscHuellaThumb
            '
            Me.uscHuellaThumb._AnchoImgPixel = 0
            Me.uscHuellaThumb._Codigo = -1
            Me.uscHuellaThumb._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscHuellaThumb._Foco = False
            Me.uscHuellaThumb._FocoEnceder = False
            Me.uscHuellaThumb._FocoError = False
            Me.uscHuellaThumb._ImagenHuellaByte = Nothing
            Me.uscHuellaThumb._IndiceCalidad = -1
            Me.uscHuellaThumb._LargoImgPixel = 0
            Me.uscHuellaThumb._NumeroDocIdentidad = ""
            Me.uscHuellaThumb._Observacion = ""
            Me.uscHuellaThumb._TemplateANSI = Nothing
            Me.uscHuellaThumb._TemplateISO = Nothing
            Me.uscHuellaThumb._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.IndiceDerecho
            Me.uscHuellaThumb._TipoDispostivo = CType(-1, Short)
            Me.uscHuellaThumb._TipoDocIdentidad = -1
            Me.uscHuellaThumb._VisiblechkHuellaNoDisponible = False
            Me.uscHuellaThumb._Wsq = Nothing
            Me.uscHuellaThumb.BackColor = System.Drawing.Color.DarkGray
            Me.uscHuellaThumb.Location = New System.Drawing.Point(157, 1)
            Me.uscHuellaThumb.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.uscHuellaThumb.Name = "uscHuellaThumb"
            Me.uscHuellaThumb.Padding = New System.Windows.Forms.Padding(1)
            Me.uscHuellaThumb.Size = New System.Drawing.Size(137, 157)
            Me.uscHuellaThumb.TabIndex = 46
            Me.uscHuellaThumb.Visible = False
            '
            'uscValidarHuellaBasic
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel2)
            Me.Name = "uscValidarHuellaBasic"
            Me.Size = New System.Drawing.Size(474, 202)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            CType(Me.PBox_PreviewHuellas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel2 As Windows.Forms.Panel
        Friend WithEvents Label2 As Windows.Forms.Label
        Friend WithEvents Label1 As Windows.Forms.Label
        Friend WithEvents rbIndDer As Windows.Forms.RadioButton
        Friend WithEvents rbAnuDer As Windows.Forms.RadioButton
        Friend WithEvents rbMedDer As Windows.Forms.RadioButton
        Friend WithEvents rbIndIzq As Windows.Forms.RadioButton
        Friend WithEvents usc_izq_pul As uscIconFinger
        Friend WithEvents usc_izq_ind As uscIconFinger
        Friend WithEvents usc_izq_med As uscIconFinger
        Friend WithEvents usc_izq_anu As uscIconFinger
        Friend WithEvents usc_izq_men As uscIconFinger
        Friend WithEvents PictureBox12 As Windows.Forms.PictureBox
        Friend WithEvents PictureBox13 As Windows.Forms.PictureBox
        Friend WithEvents uscHuellaThumb As uscThumbFinger
        Friend WithEvents rbMenDer As Windows.Forms.RadioButton
        Friend WithEvents rbPulDer As Windows.Forms.RadioButton
        Friend WithEvents rbPulIzq As Windows.Forms.RadioButton
        Friend WithEvents rbMedIzq As Windows.Forms.RadioButton
        Friend WithEvents rbAnuIzq As Windows.Forms.RadioButton
        Friend WithEvents rbMenIzq As Windows.Forms.RadioButton
        Friend WithEvents btnCapturar As Windows.Forms.Button
        Friend WithEvents usc_der_men As uscIconFinger
        Friend WithEvents usc_der_anu As uscIconFinger
        Friend WithEvents usc_der_med As uscIconFinger
        Friend WithEvents usc_der_ind As uscIconFinger
        Friend WithEvents usc_der_pul As uscIconFinger
        Private WithEvents PBox_PreviewHuellas As Windows.Forms.PictureBox
        Friend WithEvents lblCalidad As Windows.Forms.Label
    End Class
End Namespace