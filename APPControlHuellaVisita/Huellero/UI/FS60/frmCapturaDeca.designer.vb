<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapturaDeca
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAbortar = New System.Windows.Forms.Button()
        Me.btnAmputado = New System.Windows.Forms.Button()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.uscPulIzq = New APPControlHuellaVisita.uscThumbFinger()
        Me.uscIndIzq = New APPControlHuellaVisita.uscThumbFinger()
        Me.uscMedIzq = New APPControlHuellaVisita.uscThumbFinger()
        Me.uscPulDer = New APPControlHuellaVisita.uscThumbFinger()
        Me.uscAnuIzq = New APPControlHuellaVisita.uscThumbFinger()
        Me.uscIndDer = New APPControlHuellaVisita.uscThumbFinger()
        Me.uscMenIzq = New APPControlHuellaVisita.uscThumbFinger()
        Me.uscMenDer = New APPControlHuellaVisita.uscThumbFinger()
        Me.uscAnuDer = New APPControlHuellaVisita.uscThumbFinger()
        Me.uscMedDer = New APPControlHuellaVisita.uscThumbFinger()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pbBloque3 = New System.Windows.Forms.PictureBox()
        Me.pbBloque2 = New System.Windows.Forms.PictureBox()
        Me.pbBloque1 = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.PBox_Huellas = New System.Windows.Forms.PictureBox()
        Me.tmrControlPulsacion = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.pbBloque3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBloque2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBloque1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBox_Huellas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnAbortar)
        Me.Panel1.Controls.Add(Me.btnAmputado)
        Me.Panel1.Controls.Add(Me.btnCapturar)
        Me.Panel1.Controls.Add(Me.btnSiguiente)
        Me.Panel1.Controls.Add(Me.btnAnterior)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 538)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 40)
        Me.Panel1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Image = Global.APPControlHuellaVisita.My.Resources.Resources.Circle_Yellow16x16
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(160, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "      (3) Calidad baja"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Image = Global.APPControlHuellaVisita.My.Resources.Resources.Circle_Red16x16
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(49, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "      (2) Calidad media"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Image = Global.APPControlHuellaVisita.My.Resources.Resources.Circle_Green16x16
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(48, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "      (1) Calidad alta"
        '
        'btnAbortar
        '
        Me.btnAbortar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnAbortar.Enabled = False
        Me.btnAbortar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAbortar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbortar.ForeColor = System.Drawing.Color.White
        Me.btnAbortar.Location = New System.Drawing.Point(503, 0)
        Me.btnAbortar.Name = "btnAbortar"
        Me.btnAbortar.Size = New System.Drawing.Size(131, 39)
        Me.btnAbortar.TabIndex = 9
        Me.btnAbortar.Text = "Cancelar captura"
        Me.btnAbortar.UseVisualStyleBackColor = False
        '
        'btnAmputado
        '
        Me.btnAmputado.BackColor = System.Drawing.SystemColors.Control
        Me.btnAmputado.Image = Global.APPControlHuellaVisita.My.Resources.Resources.configurar
        Me.btnAmputado.Location = New System.Drawing.Point(2, 0)
        Me.btnAmputado.Name = "btnAmputado"
        Me.btnAmputado.Size = New System.Drawing.Size(42, 40)
        Me.btnAmputado.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnAmputado, "Permite configurar los dedos amputados previa a la captura")
        Me.btnAmputado.UseVisualStyleBackColor = False
        '
        'btnCapturar
        '
        Me.btnCapturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCapturar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapturar.ForeColor = System.Drawing.Color.White
        Me.btnCapturar.Location = New System.Drawing.Point(353, 0)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(151, 39)
        Me.btnCapturar.TabIndex = 6
        Me.btnCapturar.Text = "Iniciar captura"
        Me.ToolTip1.SetToolTip(Me.btnCapturar, "Permite iniciar captura o capturar huella..... alternativamente ud. puede utiliza" &
        "r la tecla CONTROL presionando doble pulsacion rápida.")
        Me.btnCapturar.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.DarkGray
        Me.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSiguiente.FlatAppearance.BorderSize = 2
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.Black
        Me.btnSiguiente.Image = Global.APPControlHuellaVisita.My.Resources.Resources.next_32
        Me.btnSiguiente.Location = New System.Drawing.Point(633, 0)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(81, 39)
        Me.btnSiguiente.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnSiguiente, "Siguiente bloque de captura")
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.DarkGray
        Me.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAnterior.FlatAppearance.BorderSize = 2
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.Color.Black
        Me.btnAnterior.Image = Global.APPControlHuellaVisita.My.Resources.Resources.back_32
        Me.btnAnterior.Location = New System.Drawing.Point(273, 0)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(81, 39)
        Me.btnAnterior.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnAnterior, "Bloque anterior de captura")
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.APPControlHuellaVisita.My.Resources.Resources.Delete_32_2_
        Me.btnCancelar.Location = New System.Drawing.Point(873, 0)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(97, 40)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.APPControlHuellaVisita.My.Resources.Resources.Drive___USB_32
        Me.btnAceptar.Location = New System.Drawing.Point(776, 0)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(97, 40)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Grabar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
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
        Me.Panel2.Location = New System.Drawing.Point(9, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 263)
        Me.Panel2.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(234, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 24)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "DERECHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 24)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "IZQUIERDA"
        '
        'usc_der_men
        '
        Me.usc_der_men.BackColor = System.Drawing.Color.Gray
        Me.usc_der_men.Location = New System.Drawing.Point(341, 65)
        Me.usc_der_men.Name = "usc_der_men"
        Me.usc_der_men.Size = New System.Drawing.Size(26, 53)
        Me.usc_der_men.TabIndex = 41
        Me.usc_der_men.Visible = False
        '
        'usc_der_anu
        '
        Me.usc_der_anu.BackColor = System.Drawing.Color.Gray
        Me.usc_der_anu.Location = New System.Drawing.Point(305, 25)
        Me.usc_der_anu.Name = "usc_der_anu"
        Me.usc_der_anu.Size = New System.Drawing.Size(29, 53)
        Me.usc_der_anu.TabIndex = 40
        Me.usc_der_anu.Visible = False
        '
        'usc_der_med
        '
        Me.usc_der_med.BackColor = System.Drawing.Color.Gray
        Me.usc_der_med.Location = New System.Drawing.Point(270, 5)
        Me.usc_der_med.Name = "usc_der_med"
        Me.usc_der_med.Size = New System.Drawing.Size(29, 53)
        Me.usc_der_med.TabIndex = 39
        Me.usc_der_med.Visible = False
        '
        'usc_der_ind
        '
        Me.usc_der_ind.BackColor = System.Drawing.Color.Gray
        Me.usc_der_ind.Location = New System.Drawing.Point(234, 23)
        Me.usc_der_ind.Name = "usc_der_ind"
        Me.usc_der_ind.Size = New System.Drawing.Size(29, 53)
        Me.usc_der_ind.TabIndex = 38
        Me.usc_der_ind.Visible = False
        '
        'usc_der_pul
        '
        Me.usc_der_pul.BackColor = System.Drawing.Color.Gray
        Me.usc_der_pul.Location = New System.Drawing.Point(197, 106)
        Me.usc_der_pul.Name = "usc_der_pul"
        Me.usc_der_pul.Size = New System.Drawing.Size(28, 48)
        Me.usc_der_pul.TabIndex = 37
        Me.usc_der_pul.Visible = False
        '
        'usc_izq_pul
        '
        Me.usc_izq_pul.BackColor = System.Drawing.Color.Gray
        Me.usc_izq_pul.Location = New System.Drawing.Point(151, 106)
        Me.usc_izq_pul.Name = "usc_izq_pul"
        Me.usc_izq_pul.Size = New System.Drawing.Size(28, 47)
        Me.usc_izq_pul.TabIndex = 36
        Me.usc_izq_pul.Visible = False
        '
        'usc_izq_ind
        '
        Me.usc_izq_ind.BackColor = System.Drawing.Color.Gray
        Me.usc_izq_ind.Location = New System.Drawing.Point(115, 24)
        Me.usc_izq_ind.Name = "usc_izq_ind"
        Me.usc_izq_ind.Size = New System.Drawing.Size(29, 53)
        Me.usc_izq_ind.TabIndex = 35
        '
        'usc_izq_med
        '
        Me.usc_izq_med.BackColor = System.Drawing.Color.Gray
        Me.usc_izq_med.Location = New System.Drawing.Point(78, 4)
        Me.usc_izq_med.Name = "usc_izq_med"
        Me.usc_izq_med.Size = New System.Drawing.Size(28, 53)
        Me.usc_izq_med.TabIndex = 34
        '
        'usc_izq_anu
        '
        Me.usc_izq_anu.BackColor = System.Drawing.Color.Gray
        Me.usc_izq_anu.Location = New System.Drawing.Point(44, 24)
        Me.usc_izq_anu.Name = "usc_izq_anu"
        Me.usc_izq_anu.Size = New System.Drawing.Size(28, 53)
        Me.usc_izq_anu.TabIndex = 33
        '
        'usc_izq_men
        '
        Me.usc_izq_men.BackColor = System.Drawing.Color.Gray
        Me.usc_izq_men.Location = New System.Drawing.Point(10, 65)
        Me.usc_izq_men.Name = "usc_izq_men"
        Me.usc_izq_men.Size = New System.Drawing.Size(25, 53)
        Me.usc_izq_men.TabIndex = 32
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.White
        Me.PictureBox12.Image = Global.APPControlHuellaVisita.My.Resources.Resources.mano_izquierda03
        Me.PictureBox12.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(187, 258)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 5
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.White
        Me.PictureBox13.Image = Global.APPControlHuellaVisita.My.Resources.Resources.mano_derecha03
        Me.PictureBox13.Location = New System.Drawing.Point(189, 2)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(187, 258)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 5
        Me.PictureBox13.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Mano derecho"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Mano izquierdo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 266)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(391, 234)
        Me.TabControl1.TabIndex = 36
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.uscPulIzq)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.uscIndIzq)
        Me.TabPage1.Controls.Add(Me.uscMedIzq)
        Me.TabPage1.Controls.Add(Me.uscPulDer)
        Me.TabPage1.Controls.Add(Me.uscAnuIzq)
        Me.TabPage1.Controls.Add(Me.uscIndDer)
        Me.TabPage1.Controls.Add(Me.uscMenIzq)
        Me.TabPage1.Controls.Add(Me.uscMenDer)
        Me.TabPage1.Controls.Add(Me.uscAnuDer)
        Me.TabPage1.Controls.Add(Me.uscMedDer)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(383, 208)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Capturas segmentadas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'uscPulIzq
        '
        Me.uscPulIzq._AnchoImgPixel = 0
        Me.uscPulIzq._Codigo = -1
        Me.uscPulIzq._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
        Me.uscPulIzq._Foco = False
        Me.uscPulIzq._FocoEnceder = False
        Me.uscPulIzq._FocoError = False
        Me.uscPulIzq._ImagenHuellaByte = Nothing
        Me.uscPulIzq._IndiceCalidad = -1
        Me.uscPulIzq._LargoImgPixel = 0
        Me.uscPulIzq._NumeroDocIdentidad = ""
        Me.uscPulIzq._Observacion = ""
        Me.uscPulIzq._TemplateANSI = Nothing
        Me.uscPulIzq._TemplateISO = Nothing
        Me.uscPulIzq._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.PulgarIzquierdo
        Me.uscPulIzq._TipoDispostivo = CType(-1, Short)
        Me.uscPulIzq._TipoDocIdentidad = -1
        Me.uscPulIzq._VisiblechkHuellaNoDisponible = False
        Me.uscPulIzq._Wsq = Nothing
        Me.uscPulIzq.BackColor = System.Drawing.Color.DarkGray
        Me.uscPulIzq.Location = New System.Drawing.Point(305, 20)
        Me.uscPulIzq.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.uscPulIzq.Name = "uscPulIzq"
        Me.uscPulIzq.Padding = New System.Windows.Forms.Padding(1)
        Me.uscPulIzq.Size = New System.Drawing.Size(74, 76)
        Me.uscPulIzq.TabIndex = 23
        '
        'uscIndIzq
        '
        Me.uscIndIzq._AnchoImgPixel = 0
        Me.uscIndIzq._Codigo = -1
        Me.uscIndIzq._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
        Me.uscIndIzq._Foco = False
        Me.uscIndIzq._FocoEnceder = False
        Me.uscIndIzq._FocoError = False
        Me.uscIndIzq._ImagenHuellaByte = Nothing
        Me.uscIndIzq._IndiceCalidad = -1
        Me.uscIndIzq._LargoImgPixel = 0
        Me.uscIndIzq._NumeroDocIdentidad = ""
        Me.uscIndIzq._Observacion = ""
        Me.uscIndIzq._TemplateANSI = Nothing
        Me.uscIndIzq._TemplateISO = Nothing
        Me.uscIndIzq._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.IndiceIzquierdo
        Me.uscIndIzq._TipoDispostivo = CType(-1, Short)
        Me.uscIndIzq._TipoDocIdentidad = -1
        Me.uscIndIzq._VisiblechkHuellaNoDisponible = False
        Me.uscIndIzq._Wsq = Nothing
        Me.uscIndIzq.BackColor = System.Drawing.Color.DarkGray
        Me.uscIndIzq.Location = New System.Drawing.Point(230, 20)
        Me.uscIndIzq.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.uscIndIzq.Name = "uscIndIzq"
        Me.uscIndIzq.Padding = New System.Windows.Forms.Padding(1)
        Me.uscIndIzq.Size = New System.Drawing.Size(74, 76)
        Me.uscIndIzq.TabIndex = 25
        '
        'uscMedIzq
        '
        Me.uscMedIzq._AnchoImgPixel = 0
        Me.uscMedIzq._Codigo = -1
        Me.uscMedIzq._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
        Me.uscMedIzq._Foco = False
        Me.uscMedIzq._FocoEnceder = False
        Me.uscMedIzq._FocoError = False
        Me.uscMedIzq._ImagenHuellaByte = Nothing
        Me.uscMedIzq._IndiceCalidad = -1
        Me.uscMedIzq._LargoImgPixel = 0
        Me.uscMedIzq._NumeroDocIdentidad = ""
        Me.uscMedIzq._Observacion = ""
        Me.uscMedIzq._TemplateANSI = Nothing
        Me.uscMedIzq._TemplateISO = Nothing
        Me.uscMedIzq._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.MedioIzquierdo
        Me.uscMedIzq._TipoDispostivo = CType(-1, Short)
        Me.uscMedIzq._TipoDocIdentidad = -1
        Me.uscMedIzq._VisiblechkHuellaNoDisponible = False
        Me.uscMedIzq._Wsq = Nothing
        Me.uscMedIzq.BackColor = System.Drawing.Color.DarkGray
        Me.uscMedIzq.Location = New System.Drawing.Point(155, 20)
        Me.uscMedIzq.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.uscMedIzq.Name = "uscMedIzq"
        Me.uscMedIzq.Padding = New System.Windows.Forms.Padding(1)
        Me.uscMedIzq.Size = New System.Drawing.Size(74, 76)
        Me.uscMedIzq.TabIndex = 27
        '
        'uscPulDer
        '
        Me.uscPulDer._AnchoImgPixel = 0
        Me.uscPulDer._Codigo = -1
        Me.uscPulDer._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
        Me.uscPulDer._Foco = False
        Me.uscPulDer._FocoEnceder = False
        Me.uscPulDer._FocoError = False
        Me.uscPulDer._ImagenHuellaByte = Nothing
        Me.uscPulDer._IndiceCalidad = -1
        Me.uscPulDer._LargoImgPixel = 0
        Me.uscPulDer._NumeroDocIdentidad = ""
        Me.uscPulDer._Observacion = ""
        Me.uscPulDer._TemplateANSI = Nothing
        Me.uscPulDer._TemplateISO = Nothing
        Me.uscPulDer._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.PulgarDerecho
        Me.uscPulDer._TipoDispostivo = CType(-1, Short)
        Me.uscPulDer._TipoDocIdentidad = -1
        Me.uscPulDer._VisiblechkHuellaNoDisponible = False
        Me.uscPulDer._Wsq = Nothing
        Me.uscPulDer.BackColor = System.Drawing.Color.DarkGray
        Me.uscPulDer.Location = New System.Drawing.Point(5, 121)
        Me.uscPulDer.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.uscPulDer.Name = "uscPulDer"
        Me.uscPulDer.Padding = New System.Windows.Forms.Padding(1)
        Me.uscPulDer.Size = New System.Drawing.Size(74, 76)
        Me.uscPulDer.TabIndex = 29
        '
        'uscAnuIzq
        '
        Me.uscAnuIzq._AnchoImgPixel = 0
        Me.uscAnuIzq._Codigo = -1
        Me.uscAnuIzq._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
        Me.uscAnuIzq._Foco = False
        Me.uscAnuIzq._FocoEnceder = False
        Me.uscAnuIzq._FocoError = False
        Me.uscAnuIzq._ImagenHuellaByte = Nothing
        Me.uscAnuIzq._IndiceCalidad = -1
        Me.uscAnuIzq._LargoImgPixel = 0
        Me.uscAnuIzq._NumeroDocIdentidad = ""
        Me.uscAnuIzq._Observacion = ""
        Me.uscAnuIzq._TemplateANSI = Nothing
        Me.uscAnuIzq._TemplateISO = Nothing
        Me.uscAnuIzq._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.AnularIzquierdo
        Me.uscAnuIzq._TipoDispostivo = CType(-1, Short)
        Me.uscAnuIzq._TipoDocIdentidad = -1
        Me.uscAnuIzq._VisiblechkHuellaNoDisponible = False
        Me.uscAnuIzq._Wsq = Nothing
        Me.uscAnuIzq.BackColor = System.Drawing.Color.DarkGray
        Me.uscAnuIzq.Location = New System.Drawing.Point(80, 20)
        Me.uscAnuIzq.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.uscAnuIzq.Name = "uscAnuIzq"
        Me.uscAnuIzq.Padding = New System.Windows.Forms.Padding(1)
        Me.uscAnuIzq.Size = New System.Drawing.Size(74, 76)
        Me.uscAnuIzq.TabIndex = 26
        '
        'uscIndDer
        '
        Me.uscIndDer._AnchoImgPixel = 0
        Me.uscIndDer._Codigo = -1
        Me.uscIndDer._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
        Me.uscIndDer._Foco = False
        Me.uscIndDer._FocoEnceder = False
        Me.uscIndDer._FocoError = False
        Me.uscIndDer._ImagenHuellaByte = Nothing
        Me.uscIndDer._IndiceCalidad = -1
        Me.uscIndDer._LargoImgPixel = 0
        Me.uscIndDer._NumeroDocIdentidad = ""
        Me.uscIndDer._Observacion = ""
        Me.uscIndDer._TemplateANSI = Nothing
        Me.uscIndDer._TemplateISO = Nothing
        Me.uscIndDer._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.IndiceDerecho
        Me.uscIndDer._TipoDispostivo = CType(-1, Short)
        Me.uscIndDer._TipoDocIdentidad = -1
        Me.uscIndDer._VisiblechkHuellaNoDisponible = False
        Me.uscIndDer._Wsq = Nothing
        Me.uscIndDer.BackColor = System.Drawing.Color.DarkGray
        Me.uscIndDer.Location = New System.Drawing.Point(80, 121)
        Me.uscIndDer.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.uscIndDer.Name = "uscIndDer"
        Me.uscIndDer.Padding = New System.Windows.Forms.Padding(1)
        Me.uscIndDer.Size = New System.Drawing.Size(74, 76)
        Me.uscIndDer.TabIndex = 31
        '
        'uscMenIzq
        '
        Me.uscMenIzq._AnchoImgPixel = 0
        Me.uscMenIzq._Codigo = -1
        Me.uscMenIzq._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
        Me.uscMenIzq._Foco = False
        Me.uscMenIzq._FocoEnceder = False
        Me.uscMenIzq._FocoError = False
        Me.uscMenIzq._ImagenHuellaByte = Nothing
        Me.uscMenIzq._IndiceCalidad = -1
        Me.uscMenIzq._LargoImgPixel = 0
        Me.uscMenIzq._NumeroDocIdentidad = ""
        Me.uscMenIzq._Observacion = ""
        Me.uscMenIzq._TemplateANSI = Nothing
        Me.uscMenIzq._TemplateISO = Nothing
        Me.uscMenIzq._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.MeniqueIzquierdo
        Me.uscMenIzq._TipoDispostivo = CType(-1, Short)
        Me.uscMenIzq._TipoDocIdentidad = -1
        Me.uscMenIzq._VisiblechkHuellaNoDisponible = False
        Me.uscMenIzq._Wsq = Nothing
        Me.uscMenIzq.BackColor = System.Drawing.Color.DarkGray
        Me.uscMenIzq.Location = New System.Drawing.Point(5, 20)
        Me.uscMenIzq.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.uscMenIzq.Name = "uscMenIzq"
        Me.uscMenIzq.Padding = New System.Windows.Forms.Padding(1)
        Me.uscMenIzq.Size = New System.Drawing.Size(74, 76)
        Me.uscMenIzq.TabIndex = 24
        '
        'uscMenDer
        '
        Me.uscMenDer._AnchoImgPixel = 0
        Me.uscMenDer._Codigo = -1
        Me.uscMenDer._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
        Me.uscMenDer._Foco = False
        Me.uscMenDer._FocoEnceder = False
        Me.uscMenDer._FocoError = False
        Me.uscMenDer._ImagenHuellaByte = Nothing
        Me.uscMenDer._IndiceCalidad = -1
        Me.uscMenDer._LargoImgPixel = 0
        Me.uscMenDer._NumeroDocIdentidad = ""
        Me.uscMenDer._Observacion = ""
        Me.uscMenDer._TemplateANSI = Nothing
        Me.uscMenDer._TemplateISO = Nothing
        Me.uscMenDer._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.MeniqueDerecho
        Me.uscMenDer._TipoDispostivo = CType(-1, Short)
        Me.uscMenDer._TipoDocIdentidad = -1
        Me.uscMenDer._VisiblechkHuellaNoDisponible = False
        Me.uscMenDer._Wsq = Nothing
        Me.uscMenDer.BackColor = System.Drawing.Color.DarkGray
        Me.uscMenDer.Location = New System.Drawing.Point(305, 121)
        Me.uscMenDer.Margin = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.uscMenDer.Name = "uscMenDer"
        Me.uscMenDer.Padding = New System.Windows.Forms.Padding(1)
        Me.uscMenDer.Size = New System.Drawing.Size(74, 76)
        Me.uscMenDer.TabIndex = 28
        '
        'uscAnuDer
        '
        Me.uscAnuDer._AnchoImgPixel = 0
        Me.uscAnuDer._Codigo = -1
        Me.uscAnuDer._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
        Me.uscAnuDer._Foco = False
        Me.uscAnuDer._FocoEnceder = False
        Me.uscAnuDer._FocoError = False
        Me.uscAnuDer._ImagenHuellaByte = Nothing
        Me.uscAnuDer._IndiceCalidad = -1
        Me.uscAnuDer._LargoImgPixel = 0
        Me.uscAnuDer._NumeroDocIdentidad = ""
        Me.uscAnuDer._Observacion = ""
        Me.uscAnuDer._TemplateANSI = Nothing
        Me.uscAnuDer._TemplateISO = Nothing
        Me.uscAnuDer._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.AnularDerecho
        Me.uscAnuDer._TipoDispostivo = CType(-1, Short)
        Me.uscAnuDer._TipoDocIdentidad = -1
        Me.uscAnuDer._VisiblechkHuellaNoDisponible = False
        Me.uscAnuDer._Wsq = Nothing
        Me.uscAnuDer.BackColor = System.Drawing.Color.DarkGray
        Me.uscAnuDer.Location = New System.Drawing.Point(230, 121)
        Me.uscAnuDer.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.uscAnuDer.Name = "uscAnuDer"
        Me.uscAnuDer.Padding = New System.Windows.Forms.Padding(1)
        Me.uscAnuDer.Size = New System.Drawing.Size(74, 76)
        Me.uscAnuDer.TabIndex = 30
        '
        'uscMedDer
        '
        Me.uscMedDer._AnchoImgPixel = 0
        Me.uscMedDer._Codigo = -1
        Me.uscMedDer._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
        Me.uscMedDer._Foco = False
        Me.uscMedDer._FocoEnceder = False
        Me.uscMedDer._FocoError = False
        Me.uscMedDer._ImagenHuellaByte = Nothing
        Me.uscMedDer._IndiceCalidad = -1
        Me.uscMedDer._LargoImgPixel = 0
        Me.uscMedDer._NumeroDocIdentidad = ""
        Me.uscMedDer._Observacion = ""
        Me.uscMedDer._TemplateANSI = Nothing
        Me.uscMedDer._TemplateISO = Nothing
        Me.uscMedDer._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.MedioDerecho
        Me.uscMedDer._TipoDispostivo = CType(-1, Short)
        Me.uscMedDer._TipoDocIdentidad = -1
        Me.uscMedDer._VisiblechkHuellaNoDisponible = False
        Me.uscMedDer._Wsq = Nothing
        Me.uscMedDer.BackColor = System.Drawing.Color.DarkGray
        Me.uscMedDer.Location = New System.Drawing.Point(155, 121)
        Me.uscMedDer.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.uscMedDer.Name = "uscMedDer"
        Me.uscMedDer.Padding = New System.Windows.Forms.Padding(1)
        Me.uscMedDer.Size = New System.Drawing.Size(74, 76)
        Me.uscMedDer.TabIndex = 32
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.pbBloque3)
        Me.TabPage2.Controls.Add(Me.pbBloque2)
        Me.TabPage2.Controls.Add(Me.pbBloque1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(383, 208)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bloques de captura"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'pbBloque3
        '
        Me.pbBloque3.BackColor = System.Drawing.Color.White
        Me.pbBloque3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbBloque3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBloque3.Location = New System.Drawing.Point(109, 111)
        Me.pbBloque3.Name = "pbBloque3"
        Me.pbBloque3.Size = New System.Drawing.Size(165, 95)
        Me.pbBloque3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBloque3.TabIndex = 2
        Me.pbBloque3.TabStop = False
        '
        'pbBloque2
        '
        Me.pbBloque2.BackColor = System.Drawing.Color.White
        Me.pbBloque2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbBloque2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBloque2.Location = New System.Drawing.Point(192, 3)
        Me.pbBloque2.Name = "pbBloque2"
        Me.pbBloque2.Size = New System.Drawing.Size(178, 106)
        Me.pbBloque2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBloque2.TabIndex = 1
        Me.pbBloque2.TabStop = False
        '
        'pbBloque1
        '
        Me.pbBloque1.BackColor = System.Drawing.Color.White
        Me.pbBloque1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbBloque1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBloque1.Location = New System.Drawing.Point(12, 3)
        Me.pbBloque1.Name = "pbBloque1"
        Me.pbBloque1.Size = New System.Drawing.Size(178, 106)
        Me.pbBloque1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBloque1.TabIndex = 0
        Me.pbBloque1.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.BackColor = System.Drawing.Color.White
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMessage.Location = New System.Drawing.Point(2, 499)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(387, 36)
        Me.lblMessage.TabIndex = 37
        '
        'PBox_Huellas
        '
        Me.PBox_Huellas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBox_Huellas.BackColor = System.Drawing.Color.White
        Me.PBox_Huellas.Location = New System.Drawing.Point(395, 0)
        Me.PBox_Huellas.Name = "PBox_Huellas"
        Me.PBox_Huellas.Size = New System.Drawing.Size(575, 535)
        Me.PBox_Huellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBox_Huellas.TabIndex = 35
        Me.PBox_Huellas.TabStop = False
        '
        'tmrControlPulsacion
        '
        Me.tmrControlPulsacion.Interval = 10
        '
        'frmCapturaDeca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 578)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PBox_Huellas)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "frmCapturaDeca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Captura por esquema 4 izq. - 4 der. - 2 pulgares"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.pbBloque3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBloque2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBloque1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBox_Huellas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents uscPulDer As uscThumbFinger
    Friend WithEvents uscIndDer As uscThumbFinger
    Friend WithEvents uscMedDer As uscThumbFinger
    Friend WithEvents uscAnuDer As uscThumbFinger
    Friend WithEvents uscMenIzq As uscThumbFinger
    Friend WithEvents uscAnuIzq As uscThumbFinger
    Friend WithEvents uscMedIzq As uscThumbFinger
    Friend WithEvents uscIndIzq As uscThumbFinger
    Friend WithEvents uscPulIzq As uscThumbFinger
    Friend WithEvents uscMenDer As uscThumbFinger
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PBox_Huellas As System.Windows.Forms.PictureBox
    Friend WithEvents btnCapturar As System.Windows.Forms.Button
    Friend WithEvents btnAmputado As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents pbBloque3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBloque2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBloque1 As System.Windows.Forms.PictureBox
    Friend WithEvents usc_izq_men As uscIconFinger
    Friend WithEvents usc_der_men As uscIconFinger
    Friend WithEvents usc_der_anu As uscIconFinger
    Friend WithEvents usc_der_med As uscIconFinger
    Friend WithEvents usc_der_ind As uscIconFinger
    Friend WithEvents usc_der_pul As uscIconFinger
    Friend WithEvents usc_izq_pul As uscIconFinger
    Friend WithEvents usc_izq_ind As uscIconFinger
    Friend WithEvents usc_izq_med As uscIconFinger
    Friend WithEvents usc_izq_anu As uscIconFinger
    Friend WithEvents btnAbortar As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tmrControlPulsacion As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
