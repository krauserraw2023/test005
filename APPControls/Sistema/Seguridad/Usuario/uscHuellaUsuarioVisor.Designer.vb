Namespace Sistema.Seguridad.Usuario
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscHuellaUsuarioVisor
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
            Me.btnCapturarHuellaIzq = New System.Windows.Forms.Button()
            Me.btnCapturarHuellaDer = New System.Windows.Forms.Button()
            Me.PictureBox13 = New System.Windows.Forms.PictureBox()
            Me.PictureBox12 = New System.Windows.Forms.PictureBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.uscHuelIIzq = New APPControlHuellaVisita.uscThumbFinger()
            Me.uscHuellDer = New APPControlHuellaVisita.uscThumbFinger()
            Me.usc_der_men = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_der_anu = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_der_med = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_der_ind = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_der_pul = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_izq_pul = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_izq_ind = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_izq_med = New APPControlHuellaVisita.uscIconFinger()
            Me.ucs_izq_anu = New APPControlHuellaVisita.uscIconFinger()
            Me.usc_izq_men = New APPControlHuellaVisita.uscIconFinger()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnCapturarHuellaIzq
            '
            Me.btnCapturarHuellaIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapturarHuellaIzq.Image = Global.APPControls.My.Resources.Resources.capturar
            Me.btnCapturarHuellaIzq.Location = New System.Drawing.Point(184, 175)
            Me.btnCapturarHuellaIzq.Name = "btnCapturarHuellaIzq"
            Me.btnCapturarHuellaIzq.Size = New System.Drawing.Size(99, 39)
            Me.btnCapturarHuellaIzq.TabIndex = 8
            Me.btnCapturarHuellaIzq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'btnCapturarHuellaDer
            '
            Me.btnCapturarHuellaDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapturarHuellaDer.Image = Global.APPControls.My.Resources.Resources.capturar
            Me.btnCapturarHuellaDer.Location = New System.Drawing.Point(606, 175)
            Me.btnCapturarHuellaDer.Name = "btnCapturarHuellaDer"
            Me.btnCapturarHuellaDer.Size = New System.Drawing.Size(99, 39)
            Me.btnCapturarHuellaDer.TabIndex = 105
            Me.btnCapturarHuellaDer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'PictureBox13
            '
            Me.PictureBox13.BackColor = System.Drawing.Color.White
            Me.PictureBox13.Image = Global.APPControls.My.Resources.Resources.mano_derecha03
            Me.PictureBox13.Location = New System.Drawing.Point(425, 0)
            Me.PictureBox13.Name = "PictureBox13"
            Me.PictureBox13.Size = New System.Drawing.Size(181, 215)
            Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox13.TabIndex = 5
            Me.PictureBox13.TabStop = False
            '
            'PictureBox12
            '
            Me.PictureBox12.BackColor = System.Drawing.Color.White
            Me.PictureBox12.Image = Global.APPControls.My.Resources.Resources.mano_izquierda03
            Me.PictureBox12.Location = New System.Drawing.Point(3, 2)
            Me.PictureBox12.Name = "PictureBox12"
            Me.PictureBox12.Size = New System.Drawing.Size(181, 215)
            Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox12.TabIndex = 5
            Me.PictureBox12.TabStop = False
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.uscHuelIIzq)
            Me.Panel2.Controls.Add(Me.btnCapturarHuellaIzq)
            Me.Panel2.Controls.Add(Me.btnCapturarHuellaDer)
            Me.Panel2.Controls.Add(Me.uscHuellDer)
            Me.Panel2.Controls.Add(Me.usc_der_men)
            Me.Panel2.Controls.Add(Me.usc_der_anu)
            Me.Panel2.Controls.Add(Me.usc_der_med)
            Me.Panel2.Controls.Add(Me.usc_der_ind)
            Me.Panel2.Controls.Add(Me.usc_der_pul)
            Me.Panel2.Controls.Add(Me.usc_izq_pul)
            Me.Panel2.Controls.Add(Me.usc_izq_ind)
            Me.Panel2.Controls.Add(Me.usc_izq_med)
            Me.Panel2.Controls.Add(Me.ucs_izq_anu)
            Me.Panel2.Controls.Add(Me.usc_izq_men)
            Me.Panel2.Controls.Add(Me.PictureBox12)
            Me.Panel2.Controls.Add(Me.PictureBox13)
            Me.Panel2.Location = New System.Drawing.Point(16, 27)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(765, 221)
            Me.Panel2.TabIndex = 108
            '
            'uscHuelIIzq
            '
            Me.uscHuelIIzq._AnchoImgPixel = 0
            Me.uscHuelIIzq._Codigo = -1
            Me.uscHuelIIzq._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscHuelIIzq._Foco = False
            Me.uscHuelIIzq._FocoEnceder = False
            Me.uscHuelIIzq._FocoError = False
            Me.uscHuelIIzq._ImagenHuellaByte = Nothing
            Me.uscHuelIIzq._IndiceCalidad = -1
            Me.uscHuelIIzq._LargoImgPixel = 0
            Me.uscHuelIIzq._NumeroDocIdentidad = ""
            Me.uscHuelIIzq._Observacion = ""
            Me.uscHuelIIzq._TemplateANSI = Nothing
            Me.uscHuelIIzq._TemplateISO = Nothing
            Me.uscHuelIIzq._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.IndiceIzquierdo
            Me.uscHuelIIzq._TipoDispostivo = CType(-1, Short)
            Me.uscHuelIIzq._TipoDocIdentidad = -1
            Me.uscHuelIIzq._VisiblechkHuellaNoDisponible = False
            Me.uscHuelIIzq._Wsq = Nothing
            Me.uscHuelIIzq.BackColor = System.Drawing.Color.DarkGray
            Me.uscHuelIIzq.Location = New System.Drawing.Point(184, 2)
            Me.uscHuelIIzq.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.uscHuelIIzq.Name = "uscHuelIIzq"
            Me.uscHuelIIzq.Padding = New System.Windows.Forms.Padding(1)
            Me.uscHuelIIzq.Size = New System.Drawing.Size(153, 173)
            Me.uscHuelIIzq.TabIndex = 106
            '
            'uscHuellDer
            '
            Me.uscHuellDer._AnchoImgPixel = 0
            Me.uscHuellDer._Codigo = -1
            Me.uscHuellDer._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscHuellDer._Foco = False
            Me.uscHuellDer._FocoEnceder = False
            Me.uscHuellDer._FocoError = False
            Me.uscHuellDer._ImagenHuellaByte = Nothing
            Me.uscHuellDer._IndiceCalidad = -1
            Me.uscHuellDer._LargoImgPixel = 0
            Me.uscHuellDer._NumeroDocIdentidad = ""
            Me.uscHuellDer._Observacion = ""
            Me.uscHuellDer._TemplateANSI = Nothing
            Me.uscHuellDer._TemplateISO = Nothing
            Me.uscHuellDer._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.MeniqueDerecho
            Me.uscHuellDer._TipoDispostivo = CType(-1, Short)
            Me.uscHuellDer._TipoDocIdentidad = -1
            Me.uscHuellDer._VisiblechkHuellaNoDisponible = False
            Me.uscHuellDer._Wsq = Nothing
            Me.uscHuellDer.BackColor = System.Drawing.Color.DarkGray
            Me.uscHuellDer.Location = New System.Drawing.Point(606, 0)
            Me.uscHuellDer.Margin = New System.Windows.Forms.Padding(6, 3, 0, 3)
            Me.uscHuellDer.Name = "uscHuellDer"
            Me.uscHuellDer.Padding = New System.Windows.Forms.Padding(1)
            Me.uscHuellDer.Size = New System.Drawing.Size(153, 175)
            Me.uscHuellDer.TabIndex = 107
            '
            'usc_der_men
            '
            Me.usc_der_men.BackColor = System.Drawing.Color.Gray
            Me.usc_der_men.Location = New System.Drawing.Point(564, 51)
            Me.usc_der_men.Name = "usc_der_men"
            Me.usc_der_men.Size = New System.Drawing.Size(26, 42)
            Me.usc_der_men.TabIndex = 41
            Me.usc_der_men.Tag = "10"
            '
            'usc_der_anu
            '
            Me.usc_der_anu.BackColor = System.Drawing.Color.Gray
            Me.usc_der_anu.Location = New System.Drawing.Point(534, 16)
            Me.usc_der_anu.Name = "usc_der_anu"
            Me.usc_der_anu.Size = New System.Drawing.Size(27, 46)
            Me.usc_der_anu.TabIndex = 40
            Me.usc_der_anu.Tag = "9"
            '
            'usc_der_med
            '
            Me.usc_der_med.BackColor = System.Drawing.Color.Gray
            Me.usc_der_med.Location = New System.Drawing.Point(504, 2)
            Me.usc_der_med.Name = "usc_der_med"
            Me.usc_der_med.Size = New System.Drawing.Size(26, 46)
            Me.usc_der_med.TabIndex = 39
            Me.usc_der_med.Tag = "8"
            '
            'usc_der_ind
            '
            Me.usc_der_ind.BackColor = System.Drawing.Color.Gray
            Me.usc_der_ind.Location = New System.Drawing.Point(473, 17)
            Me.usc_der_ind.Name = "usc_der_ind"
            Me.usc_der_ind.Size = New System.Drawing.Size(26, 46)
            Me.usc_der_ind.TabIndex = 38
            Me.usc_der_ind.Tag = "7"
            Me.usc_der_ind.Visible = False
            '
            'usc_der_pul
            '
            Me.usc_der_pul.BackColor = System.Drawing.Color.Gray
            Me.usc_der_pul.Location = New System.Drawing.Point(442, 85)
            Me.usc_der_pul.Name = "usc_der_pul"
            Me.usc_der_pul.Size = New System.Drawing.Size(26, 41)
            Me.usc_der_pul.TabIndex = 37
            Me.usc_der_pul.Tag = "6"
            '
            'usc_izq_pul
            '
            Me.usc_izq_pul.BackColor = System.Drawing.Color.Gray
            Me.usc_izq_pul.Location = New System.Drawing.Point(140, 87)
            Me.usc_izq_pul.Name = "usc_izq_pul"
            Me.usc_izq_pul.Size = New System.Drawing.Size(25, 40)
            Me.usc_izq_pul.TabIndex = 36
            Me.usc_izq_pul.Tag = "5"
            '
            'usc_izq_ind
            '
            Me.usc_izq_ind.BackColor = System.Drawing.Color.Gray
            Me.usc_izq_ind.Location = New System.Drawing.Point(109, 17)
            Me.usc_izq_ind.Name = "usc_izq_ind"
            Me.usc_izq_ind.Size = New System.Drawing.Size(27, 46)
            Me.usc_izq_ind.TabIndex = 35
            Me.usc_izq_ind.Tag = "4"
            Me.usc_izq_ind.Visible = False
            '
            'usc_izq_med
            '
            Me.usc_izq_med.BackColor = System.Drawing.Color.Gray
            Me.usc_izq_med.Location = New System.Drawing.Point(78, 4)
            Me.usc_izq_med.Name = "usc_izq_med"
            Me.usc_izq_med.Size = New System.Drawing.Size(27, 46)
            Me.usc_izq_med.TabIndex = 34
            Me.usc_izq_med.Tag = "3"
            '
            'ucs_izq_anu
            '
            Me.ucs_izq_anu.BackColor = System.Drawing.Color.Gray
            Me.ucs_izq_anu.Location = New System.Drawing.Point(48, 19)
            Me.ucs_izq_anu.Name = "ucs_izq_anu"
            Me.ucs_izq_anu.Size = New System.Drawing.Size(27, 46)
            Me.ucs_izq_anu.TabIndex = 33
            Me.ucs_izq_anu.Tag = "2"
            '
            'usc_izq_men
            '
            Me.usc_izq_men.BackColor = System.Drawing.Color.Gray
            Me.usc_izq_men.Location = New System.Drawing.Point(20, 52)
            Me.usc_izq_men.Name = "usc_izq_men"
            Me.usc_izq_men.Size = New System.Drawing.Size(24, 46)
            Me.usc_izq_men.TabIndex = 32
            Me.usc_izq_men.Tag = "1"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Black
            Me.Label9.Location = New System.Drawing.Point(174, 265)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(105, 13)
            Me.Label9.TabIndex = 111
            Me.Label9.Text = "Indice de calidad"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Image = Global.APPControls.My.Resources.Resources.Circle_Yellow16x16
            Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label8.Location = New System.Drawing.Point(498, 265)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(98, 13)
            Me.Label8.TabIndex = 110
            Me.Label8.Text = "      (3) Calidad baja"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Image = Global.APPControls.My.Resources.Resources.Circle_Red16x16
            Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label7.Location = New System.Drawing.Point(386, 265)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(106, 13)
            Me.Label7.TabIndex = 108
            Me.Label7.Text = "      (2) Calidad media"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Image = Global.APPControls.My.Resources.Resources.Circle_Green16x16
            Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label4.Location = New System.Drawing.Point(285, 265)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(95, 13)
            Me.Label4.TabIndex = 109
            Me.Label4.Text = "      (1) Calidad alta"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.DimGray
            Me.Label2.Location = New System.Drawing.Point(484, 183)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(69, 17)
            Me.Label2.TabIndex = 109
            Me.Label2.Text = "Derecha"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.DimGray
            Me.Label1.Location = New System.Drawing.Point(53, 182)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(75, 17)
            Me.Label1.TabIndex = 108
            Me.Label1.Text = "Izquierda"
            '
            'uscHuellaUsuarioVisor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Label4)
            Me.Name = "uscHuellaUsuarioVisor"
            Me.Size = New System.Drawing.Size(787, 309)
            CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents btnCapturarHuellaIzq As Button
        Friend WithEvents btnCapturarHuellaDer As Button
        Friend WithEvents PictureBox13 As PictureBox
        Friend WithEvents PictureBox12 As PictureBox
        Friend WithEvents usc_izq_men As APPControlHuellaVisita.uscIconFinger
        Friend WithEvents ucs_izq_anu As APPControlHuellaVisita.uscIconFinger
        Friend WithEvents usc_izq_med As APPControlHuellaVisita.uscIconFinger
        Friend WithEvents usc_izq_ind As APPControlHuellaVisita.uscIconFinger
        Friend WithEvents usc_izq_pul As APPControlHuellaVisita.uscIconFinger
        Friend WithEvents usc_der_pul As APPControlHuellaVisita.uscIconFinger
        Friend WithEvents usc_der_ind As APPControlHuellaVisita.uscIconFinger
        Friend WithEvents usc_der_med As APPControlHuellaVisita.uscIconFinger
        Friend WithEvents usc_der_anu As APPControlHuellaVisita.uscIconFinger
        Friend WithEvents usc_der_men As APPControlHuellaVisita.uscIconFinger
        Friend WithEvents Panel2 As Panel
        Friend WithEvents uscHuelIIzq As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents uscHuellDer As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents Label9 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
    End Class
End Namespace