<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapturaMonoDac
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usc_der_men = New APPControlHuellaVisita.uscIconFinger()
        Me.usc_der_anu = New APPControlHuellaVisita.uscIconFinger()
        Me.chkAmputado = New System.Windows.Forms.CheckBox()
        Me.usc_der_med = New APPControlHuellaVisita.uscIconFinger()
        Me.usc_der_ind = New APPControlHuellaVisita.uscIconFinger()
        Me.usc_der_pul = New APPControlHuellaVisita.uscIconFinger()
        Me.usc_izq_pul = New APPControlHuellaVisita.uscIconFinger()
        Me.usc_izq_med = New APPControlHuellaVisita.uscIconFinger()
        Me.ucs_izq_anu = New APPControlHuellaVisita.uscIconFinger()
        Me.usc_izq_men = New APPControlHuellaVisita.uscIconFinger()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.btnAbortarCap = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHardware = New System.Windows.Forms.Label()
        Me.lblFilmware = New System.Windows.Forms.Label()
        Me.lblScanner = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PBox_PreviewHuellas = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrControlPulsacion = New System.Windows.Forms.Timer(Me.components)
        Me.uscHuellaThumb = New APPControlHuellaVisita.uscThumbFinger()
        Me.usc_izq_ind = New APPControlHuellaVisita.uscIconFinger()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PBox_PreviewHuellas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.usc_izq_ind)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.usc_der_men)
        Me.Panel2.Controls.Add(Me.usc_der_anu)
        Me.Panel2.Controls.Add(Me.chkAmputado)
        Me.Panel2.Controls.Add(Me.usc_der_med)
        Me.Panel2.Controls.Add(Me.usc_der_ind)
        Me.Panel2.Controls.Add(Me.usc_der_pul)
        Me.Panel2.Controls.Add(Me.usc_izq_pul)
        Me.Panel2.Controls.Add(Me.usc_izq_med)
        Me.Panel2.Controls.Add(Me.ucs_izq_anu)
        Me.Panel2.Controls.Add(Me.usc_izq_men)
        Me.Panel2.Controls.Add(Me.PictureBox12)
        Me.Panel2.Controls.Add(Me.PictureBox13)
        Me.Panel2.Location = New System.Drawing.Point(1, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 191)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 22)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Derecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Izquierda"
        '
        'usc_der_men
        '
        Me.usc_der_men.BackColor = System.Drawing.Color.Gray
        Me.usc_der_men.Location = New System.Drawing.Point(295, 49)
        Me.usc_der_men.Name = "usc_der_men"
        Me.usc_der_men.Size = New System.Drawing.Size(23, 46)
        Me.usc_der_men.TabIndex = 41
        Me.usc_der_men.Visible = False
        '
        'usc_der_anu
        '
        Me.usc_der_anu.BackColor = System.Drawing.Color.Gray
        Me.usc_der_anu.Location = New System.Drawing.Point(268, 16)
        Me.usc_der_anu.Name = "usc_der_anu"
        Me.usc_der_anu.Size = New System.Drawing.Size(25, 46)
        Me.usc_der_anu.TabIndex = 40
        Me.usc_der_anu.Visible = False
        '
        'chkAmputado
        '
        Me.chkAmputado.AutoSize = True
        Me.chkAmputado.Location = New System.Drawing.Point(125, 135)
        Me.chkAmputado.Name = "chkAmputado"
        Me.chkAmputado.Size = New System.Drawing.Size(102, 17)
        Me.chkAmputado.TabIndex = 26
        Me.chkAmputado.Text = "Dedo amputado"
        Me.chkAmputado.UseVisualStyleBackColor = True
        '
        'usc_der_med
        '
        Me.usc_der_med.BackColor = System.Drawing.Color.Gray
        Me.usc_der_med.Location = New System.Drawing.Point(239, 3)
        Me.usc_der_med.Name = "usc_der_med"
        Me.usc_der_med.Size = New System.Drawing.Size(26, 46)
        Me.usc_der_med.TabIndex = 39
        Me.usc_der_med.Visible = False
        '
        'usc_der_ind
        '
        Me.usc_der_ind.BackColor = System.Drawing.Color.Gray
        Me.usc_der_ind.Location = New System.Drawing.Point(211, 16)
        Me.usc_der_ind.Name = "usc_der_ind"
        Me.usc_der_ind.Size = New System.Drawing.Size(25, 46)
        Me.usc_der_ind.TabIndex = 38
        Me.usc_der_ind.Visible = False
        '
        'usc_der_pul
        '
        Me.usc_der_pul.BackColor = System.Drawing.Color.Gray
        Me.usc_der_pul.Location = New System.Drawing.Point(183, 80)
        Me.usc_der_pul.Name = "usc_der_pul"
        Me.usc_der_pul.Size = New System.Drawing.Size(24, 41)
        Me.usc_der_pul.TabIndex = 37
        Me.usc_der_pul.Visible = False
        '
        'usc_izq_pul
        '
        Me.usc_izq_pul.BackColor = System.Drawing.Color.Gray
        Me.usc_izq_pul.Location = New System.Drawing.Point(130, 82)
        Me.usc_izq_pul.Name = "usc_izq_pul"
        Me.usc_izq_pul.Size = New System.Drawing.Size(25, 40)
        Me.usc_izq_pul.TabIndex = 36
        Me.usc_izq_pul.Visible = False
        '
        'usc_izq_med
        '
        Me.usc_izq_med.BackColor = System.Drawing.Color.Gray
        Me.usc_izq_med.Location = New System.Drawing.Point(73, 2)
        Me.usc_izq_med.Name = "usc_izq_med"
        Me.usc_izq_med.Size = New System.Drawing.Size(25, 46)
        Me.usc_izq_med.TabIndex = 34
        Me.usc_izq_med.Visible = False
        '
        'ucs_izq_anu
        '
        Me.ucs_izq_anu.BackColor = System.Drawing.Color.Gray
        Me.ucs_izq_anu.Location = New System.Drawing.Point(45, 17)
        Me.ucs_izq_anu.Name = "ucs_izq_anu"
        Me.ucs_izq_anu.Size = New System.Drawing.Size(26, 46)
        Me.ucs_izq_anu.TabIndex = 33
        Me.ucs_izq_anu.Visible = False
        '
        'usc_izq_men
        '
        Me.usc_izq_men.BackColor = System.Drawing.Color.Gray
        Me.usc_izq_men.Location = New System.Drawing.Point(20, 47)
        Me.usc_izq_men.Name = "usc_izq_men"
        Me.usc_izq_men.Size = New System.Drawing.Size(24, 46)
        Me.usc_izq_men.TabIndex = 32
        Me.usc_izq_men.Visible = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.White
        Me.PictureBox12.Image = Global.APPControlHuellaVisita.My.Resources.Resources.mano_izquierda03
        Me.PictureBox12.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(174, 201)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 5
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.White
        Me.PictureBox13.Image = Global.APPControlHuellaVisita.My.Resources.Resources.mano_derecha03
        Me.PictureBox13.Location = New System.Drawing.Point(166, 2)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(171, 201)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 5
        Me.PictureBox13.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMessage.Location = New System.Drawing.Point(0, 431)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(841, 18)
        Me.lblMessage.TabIndex = 26
        '
        'btnCapturar
        '
        Me.btnCapturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCapturar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapturar.ForeColor = System.Drawing.Color.White
        Me.btnCapturar.Location = New System.Drawing.Point(229, 239)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(110, 40)
        Me.btnCapturar.TabIndex = 1
        Me.btnCapturar.Text = "Iniciar captura"
        Me.ToolTip1.SetToolTip(Me.btnCapturar, "Permite iniciar captura o capturar huella..... alternativamente ud. puede utiliza" &
        "r la tecla CONTROL presionando doble pulsacion rápida.")
        Me.btnCapturar.UseVisualStyleBackColor = False
        '
        'btnAbortarCap
        '
        Me.btnAbortarCap.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnAbortarCap.Enabled = False
        Me.btnAbortarCap.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAbortarCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbortarCap.ForeColor = System.Drawing.Color.White
        Me.btnAbortarCap.Location = New System.Drawing.Point(229, 279)
        Me.btnAbortarCap.Name = "btnAbortarCap"
        Me.btnAbortarCap.Size = New System.Drawing.Size(110, 39)
        Me.btnAbortarCap.TabIndex = 28
        Me.btnAbortarCap.Text = "Cancelar captura"
        Me.btnAbortarCap.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblHardware)
        Me.Panel1.Controls.Add(Me.lblFilmware)
        Me.Panel1.Controls.Add(Me.lblScanner)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 449)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 53)
        Me.Panel1.TabIndex = 0
        '
        'lblHardware
        '
        Me.lblHardware.AutoSize = True
        Me.lblHardware.Location = New System.Drawing.Point(7, 38)
        Me.lblHardware.Name = "lblHardware"
        Me.lblHardware.Size = New System.Drawing.Size(56, 13)
        Me.lblHardware.TabIndex = 32
        Me.lblHardware.Text = "Hardware:"
        '
        'lblFilmware
        '
        Me.lblFilmware.AutoSize = True
        Me.lblFilmware.Location = New System.Drawing.Point(6, 21)
        Me.lblFilmware.Name = "lblFilmware"
        Me.lblFilmware.Size = New System.Drawing.Size(51, 13)
        Me.lblFilmware.TabIndex = 31
        Me.lblFilmware.Text = "Filmware:"
        '
        'lblScanner
        '
        Me.lblScanner.AutoSize = True
        Me.lblScanner.Location = New System.Drawing.Point(7, 4)
        Me.lblScanner.Name = "lblScanner"
        Me.lblScanner.Size = New System.Drawing.Size(50, 13)
        Me.lblScanner.TabIndex = 30
        Me.lblScanner.Text = "Scanner:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.APPControlHuellaVisita.My.Resources.Resources.Drive___USB_32
        Me.btnAceptar.Location = New System.Drawing.Point(646, 6)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(97, 41)
        Me.btnAceptar.TabIndex = 29
        Me.btnAceptar.Text = "Grabar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.APPControlHuellaVisita.My.Resources.Resources.Delete_32_2_
        Me.btnCancelar.Location = New System.Drawing.Point(743, 6)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(97, 41)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(231, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Indice de calidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Image = Global.APPControlHuellaVisita.My.Resources.Resources.Circle_Yellow16x16
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(233, 412)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "      (3) Calidad baja"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Image = Global.APPControlHuellaVisita.My.Resources.Resources.Circle_Red16x16
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(233, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "      (2) Calidad media"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Image = Global.APPControlHuellaVisita.My.Resources.Resources.Circle_Green16x16
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(233, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "      (1) Calidad alta"
        '
        'PBox_PreviewHuellas
        '
        Me.PBox_PreviewHuellas.BackColor = System.Drawing.Color.White
        Me.PBox_PreviewHuellas.Location = New System.Drawing.Point(342, 3)
        Me.PBox_PreviewHuellas.Name = "PBox_PreviewHuellas"
        Me.PBox_PreviewHuellas.Size = New System.Drawing.Size(498, 428)
        Me.PBox_PreviewHuellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBox_PreviewHuellas.TabIndex = 1
        Me.PBox_PreviewHuellas.TabStop = False
        '
        'tmrControlPulsacion
        '
        Me.tmrControlPulsacion.Interval = 10
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
        Me.uscHuellaThumb._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.MeniqueIzquierdo
        Me.uscHuellaThumb._TipoDispostivo = CType(-1, Short)
        Me.uscHuellaThumb._TipoDocIdentidad = -1
        Me.uscHuellaThumb._VisiblechkHuellaNoDisponible = True
        Me.uscHuellaThumb._Wsq = Nothing
        Me.uscHuellaThumb.BackColor = System.Drawing.Color.DarkGray
        Me.uscHuellaThumb.Location = New System.Drawing.Point(2, 197)
        Me.uscHuellaThumb.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.uscHuellaThumb.Name = "uscHuellaThumb"
        Me.uscHuellaThumb.Padding = New System.Windows.Forms.Padding(1)
        Me.uscHuellaThumb.Size = New System.Drawing.Size(226, 234)
        Me.uscHuellaThumb.TabIndex = 25
        '
        'usc_izq_ind
        '
        Me.usc_izq_ind.BackColor = System.Drawing.Color.Gray
        Me.usc_izq_ind.Location = New System.Drawing.Point(100, 14)
        Me.usc_izq_ind.Name = "usc_izq_ind"
        Me.usc_izq_ind.Size = New System.Drawing.Size(28, 46)
        Me.usc_izq_ind.TabIndex = 42
        Me.usc_izq_ind.Visible = False
        '
        'frmCapturaMonoDac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 502)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAbortarCap)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCapturar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.uscHuellaThumb)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PBox_PreviewHuellas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frmCapturaMonoDac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura monodactilar"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBox_PreviewHuellas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBox_PreviewHuellas As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents usc_der_men As uscIconFinger
    Friend WithEvents usc_der_anu As uscIconFinger
    Friend WithEvents usc_der_med As uscIconFinger
    Friend WithEvents usc_der_ind As uscIconFinger
    Friend WithEvents usc_der_pul As uscIconFinger
    Friend WithEvents usc_izq_pul As uscIconFinger
    Friend WithEvents usc_izq_med As uscIconFinger
    Friend WithEvents ucs_izq_anu As uscIconFinger
    Friend WithEvents usc_izq_men As uscIconFinger
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents uscHuellaThumb As uscThumbFinger
    Friend WithEvents chkAmputado As System.Windows.Forms.CheckBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCapturar As System.Windows.Forms.Button
    Friend WithEvents btnAbortarCap As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblScanner As System.Windows.Forms.Label
    Friend WithEvents lblFilmware As System.Windows.Forms.Label
    Friend WithEvents lblHardware As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tmrControlPulsacion As System.Windows.Forms.Timer
    Friend WithEvents usc_izq_ind As uscIconFinger
End Class
