Namespace Visita.Movimiento


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDetalle
        Inherits Legolas.APPUIComponents.Form

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalle))
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.UscFotoMenor = New APPControls.Foto.uscFotografia()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.lblTipoDoc = New System.Windows.Forms.Label()
            Me.lblEdad = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblSexo = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblNac = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblNom = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblApeMat = New System.Windows.Forms.Label()
            Me.lblApePat = New System.Windows.Forms.Label()
            Me.lblNumDoc = New System.Windows.Forms.Label()
            Me.pnlFotoVisitante = New System.Windows.Forms.Panel()
            Me.UscFotografia1 = New APPControls.Foto.uscFotografia()
            Me.grbDatosInterno = New System.Windows.Forms.GroupBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lblIntEdad = New System.Windows.Forms.Label()
            Me.lblIntSexo = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.lblIntNumDoc = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.txtIntTipoDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtIntNacionalidad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtIntApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtIntApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtIntNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlFotoInterno = New System.Windows.Forms.Panel()
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.dgwMovi = New Legolas.APPUIComponents.myDatagridView()
            Me.col_mov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_id_pdr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_men_tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pas_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_hor_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_hor_sal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_sal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_min_per = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fot_vis = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_men_can = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ico_nin_men = New System.Windows.Forms.DataGridViewImageColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_sal = New System.Windows.Forms.DataGridViewImageColumn()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgwMenores = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_apenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_par = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_fot_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ver_fot = New System.Windows.Forms.DataGridViewImageColumn()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.UscMovimientosVisitas2 = New APPControls.Visita.uscMovimientosVisitas()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.UscMovimientosVisitas1 = New APPControls.Visita.uscMovimientosVisitas()
            Me.GroupBox1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlFotoVisitante.SuspendLayout()
            Me.grbDatosInterno.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlFotoInterno.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            CType(Me.dgwMovi, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgwMenores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage3.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Panel1)
            Me.GroupBox1.Controls.Add(Me.pnlFotoVisitante)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(450, 215)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Datos del Visitante"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.UscFotoMenor)
            Me.Panel1.Controls.Add(Me.Label9)
            Me.Panel1.Controls.Add(Me.lblTipoDoc)
            Me.Panel1.Controls.Add(Me.lblEdad)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.Label7)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.Label6)
            Me.Panel1.Controls.Add(Me.lblSexo)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.lblNac)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.lblNom)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.lblApeMat)
            Me.Panel1.Controls.Add(Me.lblApePat)
            Me.Panel1.Controls.Add(Me.lblNumDoc)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(153, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(294, 196)
            Me.Panel1.TabIndex = 7
            '
            'UscFotoMenor
            '
            Me.UscFotoMenor._CheckImagen = True
            Me.UscFotoMenor._EnabledDobleClick = True
            Me.UscFotoMenor._HasImagen = False
            Me.UscFotoMenor._PanelAutorizacion = False
            Me.UscFotoMenor._PanelCheck = True
            Me.UscFotoMenor.Location = New System.Drawing.Point(128, 159)
            Me.UscFotoMenor.Name = "UscFotoMenor"
            Me.UscFotoMenor.Size = New System.Drawing.Size(150, 172)
            Me.UscFotoMenor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
            Me.UscFotoMenor.TabIndex = 69
            Me.UscFotoMenor.Visible = False
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(144, 7)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(51, 13)
            Me.Label9.TabIndex = 27
            Me.Label9.Text = "N° Doc. :"
            '
            'lblTipoDoc
            '
            Me.lblTipoDoc.BackColor = System.Drawing.SystemColors.Control
            Me.lblTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipoDoc.Location = New System.Drawing.Point(84, 5)
            Me.lblTipoDoc.Name = "lblTipoDoc"
            Me.lblTipoDoc.Size = New System.Drawing.Size(54, 22)
            Me.lblTipoDoc.TabIndex = 26
            Me.lblTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblEdad
            '
            Me.lblEdad.BackColor = System.Drawing.SystemColors.Control
            Me.lblEdad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEdad.Location = New System.Drawing.Point(223, 123)
            Me.lblEdad.Name = "lblEdad"
            Me.lblEdad.Size = New System.Drawing.Size(55, 22)
            Me.lblEdad.TabIndex = 25
            Me.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(154, 128)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(38, 13)
            Me.Label1.TabIndex = 24
            Me.Label1.Text = "Edad :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(3, 104)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(75, 13)
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Nacionalidad :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 7)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Tipo Doc. :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(3, 128)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(37, 13)
            Me.Label6.TabIndex = 15
            Me.Label6.Text = "Sexo :"
            '
            'lblSexo
            '
            Me.lblSexo.BackColor = System.Drawing.SystemColors.Control
            Me.lblSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSexo.Location = New System.Drawing.Point(84, 123)
            Me.lblSexo.Name = "lblSexo"
            Me.lblSexo.Size = New System.Drawing.Size(68, 22)
            Me.lblSexo.TabIndex = 23
            Me.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(3, 80)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 13)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "Nombres :"
            '
            'lblNac
            '
            Me.lblNac.BackColor = System.Drawing.SystemColors.Control
            Me.lblNac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNac.Location = New System.Drawing.Point(84, 99)
            Me.lblNac.Name = "lblNac"
            Me.lblNac.Size = New System.Drawing.Size(194, 22)
            Me.lblNac.TabIndex = 22
            Me.lblNac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(1, 56)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(77, 13)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Segundo Ape. :"
            '
            'lblNom
            '
            Me.lblNom.BackColor = System.Drawing.SystemColors.Control
            Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNom.Location = New System.Drawing.Point(84, 75)
            Me.lblNom.Name = "lblNom"
            Me.lblNom.Size = New System.Drawing.Size(194, 22)
            Me.lblNom.TabIndex = 21
            Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(3, 33)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(75, 13)
            Me.Label3.TabIndex = 9
            Me.Label3.Text = "Primer Ape. :"
            '
            'lblApeMat
            '
            Me.lblApeMat.BackColor = System.Drawing.SystemColors.Control
            Me.lblApeMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblApeMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApeMat.Location = New System.Drawing.Point(84, 51)
            Me.lblApeMat.Name = "lblApeMat"
            Me.lblApeMat.Size = New System.Drawing.Size(194, 22)
            Me.lblApeMat.TabIndex = 20
            Me.lblApeMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblApePat
            '
            Me.lblApePat.BackColor = System.Drawing.SystemColors.Control
            Me.lblApePat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblApePat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApePat.Location = New System.Drawing.Point(84, 28)
            Me.lblApePat.Name = "lblApePat"
            Me.lblApePat.Size = New System.Drawing.Size(194, 22)
            Me.lblApePat.TabIndex = 19
            Me.lblApePat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblNumDoc
            '
            Me.lblNumDoc.BackColor = System.Drawing.SystemColors.Control
            Me.lblNumDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumDoc.Location = New System.Drawing.Point(201, 5)
            Me.lblNumDoc.Name = "lblNumDoc"
            Me.lblNumDoc.Size = New System.Drawing.Size(77, 22)
            Me.lblNumDoc.TabIndex = 17
            Me.lblNumDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlFotoVisitante
            '
            Me.pnlFotoVisitante.Controls.Add(Me.UscFotografia1)
            Me.pnlFotoVisitante.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlFotoVisitante.Location = New System.Drawing.Point(3, 16)
            Me.pnlFotoVisitante.Name = "pnlFotoVisitante"
            Me.pnlFotoVisitante.Size = New System.Drawing.Size(150, 196)
            Me.pnlFotoVisitante.TabIndex = 18
            '
            'UscFotografia1
            '
            Me.UscFotografia1._CheckImagen = True
            Me.UscFotografia1._EnabledDobleClick = True
            Me.UscFotografia1._HasImagen = False
            Me.UscFotografia1._PanelAutorizacion = False
            Me.UscFotografia1._PanelCheck = False
            Me.UscFotografia1.Location = New System.Drawing.Point(0, 0)
            Me.UscFotografia1.Name = "UscFotografia1"
            Me.UscFotografia1.Size = New System.Drawing.Size(150, 190)
            Me.UscFotografia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.UscFotografia1.TabIndex = 6
            '
            'grbDatosInterno
            '
            Me.grbDatosInterno.Controls.Add(Me.Panel2)
            Me.grbDatosInterno.Controls.Add(Me.pnlFotoInterno)
            Me.grbDatosInterno.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbDatosInterno.Location = New System.Drawing.Point(471, 0)
            Me.grbDatosInterno.Name = "grbDatosInterno"
            Me.grbDatosInterno.Size = New System.Drawing.Size(450, 215)
            Me.grbDatosInterno.TabIndex = 17
            Me.grbDatosInterno.TabStop = False
            Me.grbDatosInterno.Text = "Datos del Interno"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.lblIntEdad)
            Me.Panel2.Controls.Add(Me.lblIntSexo)
            Me.Panel2.Controls.Add(Me.Label10)
            Me.Panel2.Controls.Add(Me.lblIntNumDoc)
            Me.Panel2.Controls.Add(Me.Label11)
            Me.Panel2.Controls.Add(Me.Label8)
            Me.Panel2.Controls.Add(Me.Label22)
            Me.Panel2.Controls.Add(Me.txtIntTipoDoc)
            Me.Panel2.Controls.Add(Me.txtIntNacionalidad)
            Me.Panel2.Controls.Add(Me.Label20)
            Me.Panel2.Controls.Add(Me.Label19)
            Me.Panel2.Controls.Add(Me.txtIntApePat)
            Me.Panel2.Controls.Add(Me.Label15)
            Me.Panel2.Controls.Add(Me.txtIntApeMat)
            Me.Panel2.Controls.Add(Me.Label18)
            Me.Panel2.Controls.Add(Me.txtIntNom)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(153, 16)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(294, 196)
            Me.Panel2.TabIndex = 18
            '
            'lblIntEdad
            '
            Me.lblIntEdad.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntEdad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntEdad.Location = New System.Drawing.Point(223, 123)
            Me.lblIntEdad.Name = "lblIntEdad"
            Me.lblIntEdad.Size = New System.Drawing.Size(55, 22)
            Me.lblIntEdad.TabIndex = 46
            Me.lblIntEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblIntSexo
            '
            Me.lblIntSexo.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntSexo.Location = New System.Drawing.Point(84, 123)
            Me.lblIntSexo.Name = "lblIntSexo"
            Me.lblIntSexo.Size = New System.Drawing.Size(68, 22)
            Me.lblIntSexo.TabIndex = 45
            Me.lblIntSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(144, 7)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(51, 13)
            Me.Label10.TabIndex = 44
            Me.Label10.Text = "N° Doc. :"
            '
            'lblIntNumDoc
            '
            Me.lblIntNumDoc.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntNumDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntNumDoc.Location = New System.Drawing.Point(201, 5)
            Me.lblIntNumDoc.Name = "lblIntNumDoc"
            Me.lblIntNumDoc.Size = New System.Drawing.Size(77, 22)
            Me.lblIntNumDoc.TabIndex = 43
            Me.lblIntNumDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(3, 104)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(75, 13)
            Me.Label11.TabIndex = 42
            Me.Label11.Text = "Nacionalidad :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(3, 128)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(37, 13)
            Me.Label8.TabIndex = 40
            Me.Label8.Text = "Sexo :"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(3, 7)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(60, 13)
            Me.Label22.TabIndex = 39
            Me.Label22.Text = "Tipo Doc. :"
            '
            'txtIntTipoDoc
            '
            Me.txtIntTipoDoc._BloquearPaste = False
            Me.txtIntTipoDoc._SeleccionarTodo = True
            Me.txtIntTipoDoc.Location = New System.Drawing.Point(84, 5)
            Me.txtIntTipoDoc.Name = "txtIntTipoDoc"
            Me.txtIntTipoDoc.ReadOnly = True
            Me.txtIntTipoDoc.Size = New System.Drawing.Size(54, 20)
            Me.txtIntTipoDoc.TabIndex = 17
            Me.txtIntTipoDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIntTipoDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtIntNacionalidad
            '
            Me.txtIntNacionalidad._BloquearPaste = False
            Me.txtIntNacionalidad._SeleccionarTodo = True
            Me.txtIntNacionalidad.Location = New System.Drawing.Point(84, 99)
            Me.txtIntNacionalidad.Name = "txtIntNacionalidad"
            Me.txtIntNacionalidad.ReadOnly = True
            Me.txtIntNacionalidad.Size = New System.Drawing.Size(194, 20)
            Me.txtIntNacionalidad.TabIndex = 23
            Me.txtIntNacionalidad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIntNacionalidad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(3, 33)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(75, 13)
            Me.Label20.TabIndex = 9
            Me.Label20.Text = "Primer Ape. :"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(3, 56)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(77, 13)
            Me.Label19.TabIndex = 10
            Me.Label19.Text = "Segundo Ape. :"
            '
            'txtIntApePat
            '
            Me.txtIntApePat._BloquearPaste = False
            Me.txtIntApePat._SeleccionarTodo = True
            Me.txtIntApePat.Location = New System.Drawing.Point(84, 28)
            Me.txtIntApePat.Name = "txtIntApePat"
            Me.txtIntApePat.ReadOnly = True
            Me.txtIntApePat.Size = New System.Drawing.Size(194, 20)
            Me.txtIntApePat.TabIndex = 19
            Me.txtIntApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIntApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(153, 128)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(38, 13)
            Me.Label15.TabIndex = 28
            Me.Label15.Text = "Edad :"
            '
            'txtIntApeMat
            '
            Me.txtIntApeMat._BloquearPaste = False
            Me.txtIntApeMat._SeleccionarTodo = True
            Me.txtIntApeMat.Location = New System.Drawing.Point(84, 51)
            Me.txtIntApeMat.Name = "txtIntApeMat"
            Me.txtIntApeMat.ReadOnly = True
            Me.txtIntApeMat.Size = New System.Drawing.Size(194, 20)
            Me.txtIntApeMat.TabIndex = 20
            Me.txtIntApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIntApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(3, 80)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(55, 13)
            Me.Label18.TabIndex = 13
            Me.Label18.Text = "Nombres :"
            '
            'txtIntNom
            '
            Me.txtIntNom._BloquearPaste = False
            Me.txtIntNom._SeleccionarTodo = True
            Me.txtIntNom.Location = New System.Drawing.Point(84, 75)
            Me.txtIntNom.Name = "txtIntNom"
            Me.txtIntNom.ReadOnly = True
            Me.txtIntNom.Size = New System.Drawing.Size(194, 20)
            Me.txtIntNom.TabIndex = 21
            Me.txtIntNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIntNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'pnlFotoInterno
            '
            Me.pnlFotoInterno.Controls.Add(Me.UscFotografia_2v1)
            Me.pnlFotoInterno.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlFotoInterno.Location = New System.Drawing.Point(3, 16)
            Me.pnlFotoInterno.Name = "pnlFotoInterno"
            Me.pnlFotoInterno.Size = New System.Drawing.Size(150, 196)
            Me.pnlFotoInterno.TabIndex = 100
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = True
            Me.UscFotografia_2v1._EnabledDobleClick = True
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = False
            Me.UscFotografia_2v1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(0, 0)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(150, 196)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 71
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Panel4)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel3.Location = New System.Drawing.Point(0, 509)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(921, 42)
            Me.Panel3.TabIndex = 18
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnSalir)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel4.Location = New System.Drawing.Point(827, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(94, 42)
            Me.Panel4.TabIndex = 0
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(3, 2)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 40)
            Me.btnSalir.TabIndex = 72
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.GroupBox1)
            Me.pnlCabecera.Controls.Add(Me.grbDatosInterno)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(921, 215)
            Me.pnlCabecera.TabIndex = 19
            '
            'dgwMovi
            '
            Me.dgwMovi.AllowUserToAddRows = False
            Me.dgwMovi.AllowUserToDeleteRows = False
            Me.dgwMovi.AllowUserToResizeRows = False
            Me.dgwMovi.BackgroundColor = System.Drawing.Color.White
            Me.dgwMovi.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwMovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwMovi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_mov_id, Me.col_mov_id_pdr, Me.col_men_tip, Me.col_int_id, Me.col_vis_id, Me.col_pas_num, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn13, Me.col_fec_ing, Me.col_hor_ing, Me.col_hor_sal, Me.col_fec_sal, Me.col_min_per, Me.col_fot_vis, Me.col_men_can, Me.col_ico_nin_men, Me.Column7, Me.col_reg_sal})
            Me.dgwMovi.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgwMovi.GridColor = System.Drawing.Color.LightGray
            Me.dgwMovi.Location = New System.Drawing.Point(3, 3)
            Me.dgwMovi.MultiSelect = False
            Me.dgwMovi.Name = "dgwMovi"
            Me.dgwMovi.ReadOnly = True
            Me.dgwMovi.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwMovi.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwMovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwMovi.Size = New System.Drawing.Size(907, 129)
            Me.dgwMovi.TabIndex = 20
            Me.dgwMovi.VisibleCampos = True
            '
            'col_mov_id
            '
            Me.col_mov_id.DataPropertyName = "Codigo"
            Me.col_mov_id.DividerWidth = 1
            Me.col_mov_id.HeaderText = "Movimiento"
            Me.col_mov_id.Name = "col_mov_id"
            Me.col_mov_id.ReadOnly = True
            Me.col_mov_id.Visible = False
            '
            'col_mov_id_pdr
            '
            Me.col_mov_id_pdr.DataPropertyName = "MovimientoPadre"
            Me.col_mov_id_pdr.DividerWidth = 1
            Me.col_mov_id_pdr.HeaderText = "MovimientoIDPadre"
            Me.col_mov_id_pdr.Name = "col_mov_id_pdr"
            Me.col_mov_id_pdr.ReadOnly = True
            Me.col_mov_id_pdr.Visible = False
            '
            'col_men_tip
            '
            Me.col_men_tip.DataPropertyName = "MenoresTipo"
            Me.col_men_tip.DividerWidth = 1
            Me.col_men_tip.HeaderText = "MenoresTipo"
            Me.col_men_tip.Name = "col_men_tip"
            Me.col_men_tip.ReadOnly = True
            Me.col_men_tip.Visible = False
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_vis_id
            '
            Me.col_vis_id.DataPropertyName = "VisitaID"
            Me.col_vis_id.DividerWidth = 1
            Me.col_vis_id.HeaderText = "VisitanteID"
            Me.col_vis_id.Name = "col_vis_id"
            Me.col_vis_id.ReadOnly = True
            Me.col_vis_id.Visible = False
            '
            'col_pas_num
            '
            Me.col_pas_num.DataPropertyName = "PaseNumero"
            Me.col_pas_num.HeaderText = "Pase"
            Me.col_pas_num.Name = "col_pas_num"
            Me.col_pas_num.ReadOnly = True
            Me.col_pas_num.Width = 50
            '
            'DataGridViewTextBoxColumn14
            '
            Me.DataGridViewTextBoxColumn14.DataPropertyName = "ParentescoNombre"
            Me.DataGridViewTextBoxColumn14.HeaderText = "Paren. / Visita"
            Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
            Me.DataGridViewTextBoxColumn14.ReadOnly = True
            Me.DataGridViewTextBoxColumn14.ToolTipText = "Parentesco / Tipo Visita"
            Me.DataGridViewTextBoxColumn14.Width = 120
            '
            'DataGridViewTextBoxColumn15
            '
            Me.DataGridViewTextBoxColumn15.DataPropertyName = "MotivoNombre"
            Me.DataGridViewTextBoxColumn15.DividerWidth = 1
            Me.DataGridViewTextBoxColumn15.HeaderText = "Motivo"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.ReadOnly = True
            Me.DataGridViewTextBoxColumn15.Visible = False
            '
            'DataGridViewTextBoxColumn13
            '
            Me.DataGridViewTextBoxColumn13.DataPropertyName = "PabellonNombre"
            Me.DataGridViewTextBoxColumn13.DividerWidth = 1
            Me.DataGridViewTextBoxColumn13.HeaderText = "Pabellon"
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            Me.DataGridViewTextBoxColumn13.ReadOnly = True
            Me.DataGridViewTextBoxColumn13.Visible = False
            Me.DataGridViewTextBoxColumn13.Width = 80
            '
            'col_fec_ing
            '
            Me.col_fec_ing.DataPropertyName = "FechaIngreso"
            DataGridViewCellStyle1.Format = "d"
            Me.col_fec_ing.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_fec_ing.HeaderText = "Fecha Ing."
            Me.col_fec_ing.Name = "col_fec_ing"
            Me.col_fec_ing.ReadOnly = True
            Me.col_fec_ing.Width = 85
            '
            'col_hor_ing
            '
            Me.col_hor_ing.DataPropertyName = "HoraIngreso"
            Me.col_hor_ing.HeaderText = "Hora Ing."
            Me.col_hor_ing.Name = "col_hor_ing"
            Me.col_hor_ing.ReadOnly = True
            Me.col_hor_ing.Width = 80
            '
            'col_hor_sal
            '
            Me.col_hor_sal.DataPropertyName = "HoraSalida"
            Me.col_hor_sal.HeaderText = "Hora Sal."
            Me.col_hor_sal.Name = "col_hor_sal"
            Me.col_hor_sal.ReadOnly = True
            Me.col_hor_sal.Width = 80
            '
            'col_fec_sal
            '
            Me.col_fec_sal.DataPropertyName = "FechaSalida"
            DataGridViewCellStyle2.Format = "d"
            Me.col_fec_sal.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_fec_sal.HeaderText = "Fecha Sal."
            Me.col_fec_sal.Name = "col_fec_sal"
            Me.col_fec_sal.ReadOnly = True
            Me.col_fec_sal.Width = 85
            '
            'col_min_per
            '
            Me.col_min_per.DataPropertyName = "Permanencia"
            Me.col_min_per.HeaderText = "Perman."
            Me.col_min_per.Name = "col_min_per"
            Me.col_min_per.ReadOnly = True
            Me.col_min_per.ToolTipText = "Tiempo de permanencia"
            Me.col_min_per.Width = 60
            '
            'col_fot_vis
            '
            Me.col_fot_vis.DataPropertyName = "VisitanteFotoName"
            Me.col_fot_vis.DividerWidth = 1
            Me.col_fot_vis.HeaderText = "FotoVisitante"
            Me.col_fot_vis.Name = "col_fot_vis"
            Me.col_fot_vis.ReadOnly = True
            Me.col_fot_vis.Visible = False
            '
            'col_men_can
            '
            Me.col_men_can.DataPropertyName = "MenoresCantidadString"
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.col_men_can.DefaultCellStyle = DataGridViewCellStyle3
            Me.col_men_can.HeaderText = "Cant. Men."
            Me.col_men_can.Name = "col_men_can"
            Me.col_men_can.ReadOnly = True
            Me.col_men_can.ToolTipText = "Cantidad de Menores"
            Me.col_men_can.Width = 50
            '
            'col_ico_nin_men
            '
            Me.col_ico_nin_men.DataPropertyName = "IconoMenor"
            Me.col_ico_nin_men.HeaderText = "Men."
            Me.col_ico_nin_men.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_ico_nin_men.Name = "col_ico_nin_men"
            Me.col_ico_nin_men.ReadOnly = True
            Me.col_ico_nin_men.ToolTipText = "El visitante viene acompañado de menor(es) de edad"
            Me.col_ico_nin_men.Width = 35
            '
            'Column7
            '
            Me.Column7.DataPropertyName = "Observacion"
            Me.Column7.HeaderText = "Observacion"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Visible = False
            '
            'col_reg_sal
            '
            Me.col_reg_sal.HeaderText = "Sal."
            Me.col_reg_sal.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_reg_sal.Name = "col_reg_sal"
            Me.col_reg_sal.ReadOnly = True
            Me.col_reg_sal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_reg_sal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_reg_sal.ToolTipText = "Registrar Salida"
            Me.col_reg_sal.Visible = False
            Me.col_reg_sal.Width = 35
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 215)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(921, 294)
            Me.TabControl1.TabIndex = 22
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.GroupBox2)
            Me.TabPage1.Controls.Add(Me.dgwMovi)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(913, 268)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Movimiento"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dgwMenores)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(3, 132)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(907, 133)
            Me.GroupBox2.TabIndex = 22
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Registro de Menores de Edad"
            '
            'dgwMenores
            '
            Me.dgwMenores.AllowUserToAddRows = False
            Me.dgwMenores.AllowUserToDeleteRows = False
            Me.dgwMenores.AllowUserToResizeRows = False
            Me.dgwMenores.BackgroundColor = System.Drawing.Color.White
            Me.dgwMenores.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwMenores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwMenores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_vis_apenom, Me.col_vis_edad, Me.col_vis_par, Me.col_vis_fot_nom, Me.col_ver_fot})
            Me.dgwMenores.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwMenores.Location = New System.Drawing.Point(3, 16)
            Me.dgwMenores.Name = "dgwMenores"
            Me.dgwMenores.ReadOnly = True
            Me.dgwMenores.RowHeadersVisible = False
            Me.dgwMenores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwMenores.Size = New System.Drawing.Size(901, 114)
            Me.dgwMenores.TabIndex = 8
            Me.dgwMenores.VisibleCampos = False
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "MovimientoID"
            Me.col_id.HeaderText = "MovimientoID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_vis_apenom
            '
            Me.col_vis_apenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_vis_apenom.DataPropertyName = "VisitanteApellidosyNombres"
            Me.col_vis_apenom.HeaderText = "Apellidos y Nombres"
            Me.col_vis_apenom.Name = "col_vis_apenom"
            Me.col_vis_apenom.ReadOnly = True
            Me.col_vis_apenom.Width = 458
            '
            'col_vis_edad
            '
            Me.col_vis_edad.DataPropertyName = "VisitanteEdadFecNac"
            Me.col_vis_edad.HeaderText = "Edad"
            Me.col_vis_edad.Name = "col_vis_edad"
            Me.col_vis_edad.ReadOnly = True
            Me.col_vis_edad.Width = 50
            '
            'col_vis_par
            '
            Me.col_vis_par.DataPropertyName = "ParentescoNombre"
            Me.col_vis_par.HeaderText = "Parentesco"
            Me.col_vis_par.Name = "col_vis_par"
            Me.col_vis_par.ReadOnly = True
            '
            'col_vis_fot_nom
            '
            Me.col_vis_fot_nom.DataPropertyName = "VisitanteFotoName"
            Me.col_vis_fot_nom.HeaderText = "VisitanteFotoName"
            Me.col_vis_fot_nom.Name = "col_vis_fot_nom"
            Me.col_vis_fot_nom.ReadOnly = True
            Me.col_vis_fot_nom.Visible = False
            '
            'col_ver_fot
            '
            Me.col_ver_fot.HeaderText = "Ver"
            Me.col_ver_fot.Image = Global.SIPPOPE.My.Resources.Resources._1337706653_webcam
            Me.col_ver_fot.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_ver_fot.Name = "col_ver_fot"
            Me.col_ver_fot.ReadOnly = True
            Me.col_ver_fot.ToolTipText = "Haga click para ver la fotografia del menor"
            Me.col_ver_fot.Width = 35
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.UscMovimientosVisitas2)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Size = New System.Drawing.Size(913, 268)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Historial del Visitante"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'UscMovimientosVisitas2
            '
            Me.UscMovimientosVisitas2._InternoID = -1
            Me.UscMovimientosVisitas2._PenalID = -1
            Me.UscMovimientosVisitas2._RegionID = -1
            Me.UscMovimientosVisitas2._TipoBusqueda = APPControls.Visita.uscMovimientosVisitas.enmTipo.Ninguno
            Me.UscMovimientosVisitas2._VisibleCountInterno = False
            Me.UscMovimientosVisitas2._VisibleCountVisitante = False
            Me.UscMovimientosVisitas2._VisiblePanelCount = False
            Me.UscMovimientosVisitas2._VisiblePanelFiltro = False
            Me.UscMovimientosVisitas2._VisiblePanelFiltroAnio = False
            Me.UscMovimientosVisitas2._VisitanteID = -1
            Me.UscMovimientosVisitas2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscMovimientosVisitas2.Location = New System.Drawing.Point(0, 0)
            Me.UscMovimientosVisitas2.Name = "UscMovimientosVisitas2"
            Me.UscMovimientosVisitas2.Size = New System.Drawing.Size(913, 268)
            Me.UscMovimientosVisitas2.TabIndex = 1
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.UscMovimientosVisitas1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(913, 268)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Historial del Interno"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'UscMovimientosVisitas1
            '
            Me.UscMovimientosVisitas1._InternoID = -1
            Me.UscMovimientosVisitas1._PenalID = -1
            Me.UscMovimientosVisitas1._RegionID = -1
            Me.UscMovimientosVisitas1._TipoBusqueda = APPControls.Visita.uscMovimientosVisitas.enmTipo.Ninguno
            Me.UscMovimientosVisitas1._VisibleCountInterno = False
            Me.UscMovimientosVisitas1._VisibleCountVisitante = False
            Me.UscMovimientosVisitas1._VisiblePanelCount = False
            Me.UscMovimientosVisitas1._VisiblePanelFiltro = False
            Me.UscMovimientosVisitas1._VisiblePanelFiltroAnio = False
            Me.UscMovimientosVisitas1._VisitanteID = -1
            Me.UscMovimientosVisitas1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscMovimientosVisitas1.Location = New System.Drawing.Point(3, 3)
            Me.UscMovimientosVisitas1.Name = "UscMovimientosVisitas1"
            Me.UscMovimientosVisitas1.Size = New System.Drawing.Size(907, 262)
            Me.UscMovimientosVisitas1.TabIndex = 1
            '
            'frmDetalle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(921, 551)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Controls.Add(Me.Panel3)
            Me.Name = "frmDetalle"
            Me.Text = "Monitoreo - Detalle"
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlFotoVisitante.ResumeLayout(False)
            Me.grbDatosInterno.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlFotoInterno.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            CType(Me.dgwMovi, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgwMenores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblNumDoc As System.Windows.Forms.Label
        Friend WithEvents lblApePat As System.Windows.Forms.Label
        Friend WithEvents lblApeMat As System.Windows.Forms.Label
        Friend WithEvents lblNom As System.Windows.Forms.Label
        Friend WithEvents lblNac As System.Windows.Forms.Label
        Friend WithEvents lblSexo As System.Windows.Forms.Label
        Friend WithEvents UscFotografia1 As APPControls.Foto.uscFotografia
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblEdad As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents grbDatosInterno As System.Windows.Forms.GroupBox
        Friend WithEvents pnlFotoInterno As System.Windows.Forms.Panel
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents txtIntTipoDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtIntNacionalidad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents txtIntNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents txtIntApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtIntApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents pnlFotoVisitante As System.Windows.Forms.Panel
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents dgwMovi As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents UscMovimientosVisitas1 As APPControls.Visita.uscMovimientosVisitas
        Friend WithEvents UscMovimientosVisitas2 As APPControls.Visita.uscMovimientosVisitas
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwMenores As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents lblIntEdad As System.Windows.Forms.Label
        Friend WithEvents lblIntSexo As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents lblIntNumDoc As System.Windows.Forms.Label
        Friend WithEvents col_mov_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mov_id_pdr As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_men_tip As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pas_num As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_hor_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_hor_sal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_sal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_min_per As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fot_vis As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_men_can As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ico_nin_men As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_sal As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_apenom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_edad As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_par As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_fot_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ver_fot As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents UscFotoMenor As APPControls.Foto.uscFotografia
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v

    End Class
End Namespace