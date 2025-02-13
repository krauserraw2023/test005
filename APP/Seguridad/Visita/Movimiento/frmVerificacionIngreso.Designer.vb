Namespace Visita.Movimiento


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVerificacionIngreso
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerificacionIngreso))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.grbVisitante = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.lblVisFechaNac = New System.Windows.Forms.Label()
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
            Me.Label14 = New System.Windows.Forms.Label()
            Me.UscFotografia1 = New APPControls.Foto.uscFotografia()
            Me.grbDatosInterno = New System.Windows.Forms.GroupBox()
            Me.pnlDatosInterno = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.lblEtapa = New System.Windows.Forms.Label()
            Me.lblPabellon = New System.Windows.Forms.Label()
            Me.lblIntEdad = New System.Windows.Forms.Label()
            Me.lblIntSexo = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.lblIntNumDoc = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.lblIntTipoDoc = New System.Windows.Forms.Label()
            Me.lblIntApePat = New System.Windows.Forms.Label()
            Me.lblIntApeMat = New System.Windows.Forms.Label()
            Me.lblIntNom = New System.Windows.Forms.Label()
            Me.lblIntNacionalidad = New System.Windows.Forms.Label()
            Me.lblInternoFecNac = New System.Windows.Forms.Label()
            Me.lblIntPabellon = New System.Windows.Forms.Label()
            Me.lblInternoEtapa = New System.Windows.Forms.Label()
            Me.pnlFotoInterno = New System.Windows.Forms.Panel()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.pnlTituloVisitaAdmin = New System.Windows.Forms.Panel()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.pnlCuerpo = New System.Windows.Forms.Panel()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtBuscarNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label13 = New System.Windows.Forms.Label()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnNuevoMov = New System.Windows.Forms.Button()
            Me.pnlHora = New System.Windows.Forms.Panel()
            Me.lblHoraVerificacion = New System.Windows.Forms.Label()
            Me.lblHora = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.gbRegioPenal = New System.Windows.Forms.GroupBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.UsrRegionPenal1 = New APPControls.usrRegionPenal()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.lblFechaHoy = New System.Windows.Forms.Label()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.pnlMenores = New System.Windows.Forms.Panel()
            Me.gbrMenores = New System.Windows.Forms.GroupBox()
            Me.UscFotografia3 = New APPControls.Foto.uscFotografia()
            Me.dgwMenores = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_apenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_par = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fot_vis_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_fot_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ver_fot = New System.Windows.Forms.DataGridViewImageColumn()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblParentesco = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.grbVisitante.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlFotoVisitante.SuspendLayout()
            Me.grbDatosInterno.SuspendLayout()
            Me.pnlDatosInterno.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlFotoInterno.SuspendLayout()
            Me.pnlTituloVisitaAdmin.SuspendLayout()
            Me.pnlCuerpo.SuspendLayout()
            Me.pnlPie.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlHora.SuspendLayout()
            Me.gbRegioPenal.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.pnlMenores.SuspendLayout()
            Me.gbrMenores.SuspendLayout()
            CType(Me.dgwMenores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbVisitante
            '
            Me.grbVisitante.BackColor = System.Drawing.SystemColors.Control
            Me.grbVisitante.Controls.Add(Me.Panel1)
            Me.grbVisitante.Controls.Add(Me.pnlFotoVisitante)
            Me.grbVisitante.Dock = System.Windows.Forms.DockStyle.Left
            Me.grbVisitante.Location = New System.Drawing.Point(0, 0)
            Me.grbVisitante.Name = "grbVisitante"
            Me.grbVisitante.Size = New System.Drawing.Size(490, 298)
            Me.grbVisitante.TabIndex = 0
            Me.grbVisitante.TabStop = False
            Me.grbVisitante.Text = "Datos del Visitante"
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.Label17)
            Me.Panel1.Controls.Add(Me.lblVisFechaNac)
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
            Me.Panel1.Location = New System.Drawing.Point(191, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(296, 279)
            Me.Panel1.TabIndex = 0
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(3, 125)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(48, 13)
            Me.Label17.TabIndex = 28
            Me.Label17.Text = "F. Nac. :"
            '
            'lblVisFechaNac
            '
            Me.lblVisFechaNac.BackColor = System.Drawing.SystemColors.Control
            Me.lblVisFechaNac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblVisFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVisFechaNac.Location = New System.Drawing.Point(84, 120)
            Me.lblVisFechaNac.Name = "lblVisFechaNac"
            Me.lblVisFechaNac.Size = New System.Drawing.Size(68, 22)
            Me.lblVisFechaNac.TabIndex = 29
            Me.lblVisFechaNac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(156, 10)
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
            Me.lblTipoDoc.Size = New System.Drawing.Size(70, 22)
            Me.lblTipoDoc.TabIndex = 26
            Me.lblTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblEdad
            '
            Me.lblEdad.BackColor = System.Drawing.SystemColors.Control
            Me.lblEdad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEdad.Location = New System.Drawing.Point(220, 120)
            Me.lblEdad.Name = "lblEdad"
            Me.lblEdad.Size = New System.Drawing.Size(70, 22)
            Me.lblEdad.TabIndex = 25
            Me.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(156, 125)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(38, 13)
            Me.Label1.TabIndex = 24
            Me.Label1.Text = "Edad :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(3, 102)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(75, 13)
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Nacionalidad :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 10)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Tipo Doc. :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(2, 147)
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
            Me.lblSexo.Location = New System.Drawing.Point(84, 143)
            Me.lblSexo.Name = "lblSexo"
            Me.lblSexo.Size = New System.Drawing.Size(206, 22)
            Me.lblSexo.TabIndex = 23
            Me.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(3, 79)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(74, 13)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "Pre Nombres :"
            '
            'lblNac
            '
            Me.lblNac.BackColor = System.Drawing.SystemColors.Control
            Me.lblNac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNac.Location = New System.Drawing.Point(84, 97)
            Me.lblNac.Name = "lblNac"
            Me.lblNac.Size = New System.Drawing.Size(206, 22)
            Me.lblNac.TabIndex = 22
            Me.lblNac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(1, 55)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(81, 13)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Segundo Ape. :"
            '
            'lblNom
            '
            Me.lblNom.BackColor = System.Drawing.SystemColors.Control
            Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNom.Location = New System.Drawing.Point(84, 74)
            Me.lblNom.Name = "lblNom"
            Me.lblNom.Size = New System.Drawing.Size(206, 22)
            Me.lblNom.TabIndex = 21
            Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(3, 32)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(67, 13)
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
            Me.lblApeMat.Size = New System.Drawing.Size(206, 22)
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
            Me.lblApePat.Size = New System.Drawing.Size(206, 22)
            Me.lblApePat.TabIndex = 19
            Me.lblApePat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblNumDoc
            '
            Me.lblNumDoc.BackColor = System.Drawing.SystemColors.Control
            Me.lblNumDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumDoc.Location = New System.Drawing.Point(220, 5)
            Me.lblNumDoc.Name = "lblNumDoc"
            Me.lblNumDoc.Size = New System.Drawing.Size(70, 22)
            Me.lblNumDoc.TabIndex = 17
            Me.lblNumDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlFotoVisitante
            '
            Me.pnlFotoVisitante.Controls.Add(Me.Label14)
            Me.pnlFotoVisitante.Controls.Add(Me.UscFotografia1)
            Me.pnlFotoVisitante.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlFotoVisitante.Location = New System.Drawing.Point(3, 16)
            Me.pnlFotoVisitante.Name = "pnlFotoVisitante"
            Me.pnlFotoVisitante.Size = New System.Drawing.Size(188, 279)
            Me.pnlFotoVisitante.TabIndex = 18
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.Transparent
            Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label14.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.Red
            Me.Label14.Location = New System.Drawing.Point(0, 257)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(188, 22)
            Me.Label14.TabIndex = 70
            Me.Label14.Text = "VISITANTE"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'UscFotografia1
            '
            Me.UscFotografia1._CheckImagen = True
            Me.UscFotografia1._EnabledDobleClick = False
            Me.UscFotografia1._HasImagen = False
            Me.UscFotografia1._PanelAutorizacion = False
            Me.UscFotografia1._PanelCheck = False
            Me.UscFotografia1.Location = New System.Drawing.Point(0, 0)
            Me.UscFotografia1.Name = "UscFotografia1"
            Me.UscFotografia1.Size = New System.Drawing.Size(185, 248)
            Me.UscFotografia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia1.TabIndex = 19
            '
            'grbDatosInterno
            '
            Me.grbDatosInterno.BackColor = System.Drawing.SystemColors.Control
            Me.grbDatosInterno.Controls.Add(Me.pnlDatosInterno)
            Me.grbDatosInterno.Controls.Add(Me.pnlTituloVisitaAdmin)
            Me.grbDatosInterno.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbDatosInterno.Location = New System.Drawing.Point(518, 0)
            Me.grbDatosInterno.Name = "grbDatosInterno"
            Me.grbDatosInterno.Size = New System.Drawing.Size(490, 298)
            Me.grbDatosInterno.TabIndex = 17
            Me.grbDatosInterno.TabStop = False
            Me.grbDatosInterno.Text = "Datos del Interno"
            '
            'pnlDatosInterno
            '
            Me.pnlDatosInterno.Controls.Add(Me.Panel2)
            Me.pnlDatosInterno.Controls.Add(Me.pnlFotoInterno)
            Me.pnlDatosInterno.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDatosInterno.Location = New System.Drawing.Point(3, 16)
            Me.pnlDatosInterno.Name = "pnlDatosInterno"
            Me.pnlDatosInterno.Size = New System.Drawing.Size(484, 279)
            Me.pnlDatosInterno.TabIndex = 99
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Panel2.Controls.Add(Me.Label24)
            Me.Panel2.Controls.Add(Me.lblEtapa)
            Me.Panel2.Controls.Add(Me.lblPabellon)
            Me.Panel2.Controls.Add(Me.lblIntEdad)
            Me.Panel2.Controls.Add(Me.lblIntSexo)
            Me.Panel2.Controls.Add(Me.Label10)
            Me.Panel2.Controls.Add(Me.lblIntNumDoc)
            Me.Panel2.Controls.Add(Me.Label11)
            Me.Panel2.Controls.Add(Me.Label8)
            Me.Panel2.Controls.Add(Me.Label22)
            Me.Panel2.Controls.Add(Me.Label20)
            Me.Panel2.Controls.Add(Me.Label19)
            Me.Panel2.Controls.Add(Me.Label15)
            Me.Panel2.Controls.Add(Me.Label18)
            Me.Panel2.Controls.Add(Me.lblIntTipoDoc)
            Me.Panel2.Controls.Add(Me.lblIntApePat)
            Me.Panel2.Controls.Add(Me.lblIntApeMat)
            Me.Panel2.Controls.Add(Me.lblIntNom)
            Me.Panel2.Controls.Add(Me.lblIntNacionalidad)
            Me.Panel2.Controls.Add(Me.lblInternoFecNac)
            Me.Panel2.Controls.Add(Me.lblIntPabellon)
            Me.Panel2.Controls.Add(Me.lblInternoEtapa)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(190, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(294, 279)
            Me.Panel2.TabIndex = 18
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Location = New System.Drawing.Point(1, 114)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(69, 13)
            Me.Label24.TabIndex = 128
            Me.Label24.Text = "Fecha Nac. :"
            '
            'lblEtapa
            '
            Me.lblEtapa.AutoSize = True
            Me.lblEtapa.Location = New System.Drawing.Point(1, 179)
            Me.lblEtapa.Name = "lblEtapa"
            Me.lblEtapa.Size = New System.Drawing.Size(41, 13)
            Me.lblEtapa.TabIndex = 125
            Me.lblEtapa.Text = "Etapa :"
            '
            'lblPabellon
            '
            Me.lblPabellon.AutoSize = True
            Me.lblPabellon.Location = New System.Drawing.Point(1, 157)
            Me.lblPabellon.Name = "lblPabellon"
            Me.lblPabellon.Size = New System.Drawing.Size(54, 13)
            Me.lblPabellon.TabIndex = 123
            Me.lblPabellon.Text = "Pabellon :"
            '
            'lblIntEdad
            '
            Me.lblIntEdad.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntEdad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntEdad.Location = New System.Drawing.Point(219, 110)
            Me.lblIntEdad.Name = "lblIntEdad"
            Me.lblIntEdad.Size = New System.Drawing.Size(70, 20)
            Me.lblIntEdad.TabIndex = 46
            Me.lblIntEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblIntSexo
            '
            Me.lblIntSexo.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntSexo.Location = New System.Drawing.Point(84, 131)
            Me.lblIntSexo.Name = "lblIntSexo"
            Me.lblIntSexo.Size = New System.Drawing.Size(205, 22)
            Me.lblIntSexo.TabIndex = 45
            Me.lblIntSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(160, 8)
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
            Me.lblIntNumDoc.Location = New System.Drawing.Point(219, 5)
            Me.lblIntNumDoc.Name = "lblIntNumDoc"
            Me.lblIntNumDoc.Size = New System.Drawing.Size(70, 20)
            Me.lblIntNumDoc.TabIndex = 43
            Me.lblIntNumDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(3, 92)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(75, 13)
            Me.Label11.TabIndex = 42
            Me.Label11.Text = "Nacionalidad :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(1, 136)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(37, 13)
            Me.Label8.TabIndex = 40
            Me.Label8.Text = "Sexo :"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(3, 8)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(60, 13)
            Me.Label22.TabIndex = 39
            Me.Label22.Text = "Tipo Doc. :"
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(3, 29)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(67, 13)
            Me.Label20.TabIndex = 9
            Me.Label20.Text = "Primer Ape. :"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(3, 50)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(81, 13)
            Me.Label19.TabIndex = 10
            Me.Label19.Text = "Segundo Ape. :"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(160, 114)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(38, 13)
            Me.Label15.TabIndex = 28
            Me.Label15.Text = "Edad :"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(3, 72)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(74, 13)
            Me.Label18.TabIndex = 13
            Me.Label18.Text = "Pre Nombres :"
            '
            'lblIntTipoDoc
            '
            Me.lblIntTipoDoc.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntTipoDoc.Location = New System.Drawing.Point(84, 5)
            Me.lblIntTipoDoc.Name = "lblIntTipoDoc"
            Me.lblIntTipoDoc.Size = New System.Drawing.Size(70, 20)
            Me.lblIntTipoDoc.TabIndex = 129
            Me.lblIntTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblIntApePat
            '
            Me.lblIntApePat.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntApePat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntApePat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntApePat.Location = New System.Drawing.Point(84, 26)
            Me.lblIntApePat.Name = "lblIntApePat"
            Me.lblIntApePat.Size = New System.Drawing.Size(205, 20)
            Me.lblIntApePat.TabIndex = 130
            Me.lblIntApePat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblIntApeMat
            '
            Me.lblIntApeMat.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntApeMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntApeMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntApeMat.Location = New System.Drawing.Point(84, 47)
            Me.lblIntApeMat.Name = "lblIntApeMat"
            Me.lblIntApeMat.Size = New System.Drawing.Size(205, 20)
            Me.lblIntApeMat.TabIndex = 131
            Me.lblIntApeMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblIntNom
            '
            Me.lblIntNom.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntNom.Location = New System.Drawing.Point(84, 68)
            Me.lblIntNom.Name = "lblIntNom"
            Me.lblIntNom.Size = New System.Drawing.Size(205, 20)
            Me.lblIntNom.TabIndex = 132
            Me.lblIntNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblIntNacionalidad
            '
            Me.lblIntNacionalidad.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntNacionalidad.Location = New System.Drawing.Point(84, 89)
            Me.lblIntNacionalidad.Name = "lblIntNacionalidad"
            Me.lblIntNacionalidad.Size = New System.Drawing.Size(205, 20)
            Me.lblIntNacionalidad.TabIndex = 133
            Me.lblIntNacionalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblInternoFecNac
            '
            Me.lblInternoFecNac.BackColor = System.Drawing.SystemColors.Control
            Me.lblInternoFecNac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblInternoFecNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInternoFecNac.Location = New System.Drawing.Point(84, 110)
            Me.lblInternoFecNac.Name = "lblInternoFecNac"
            Me.lblInternoFecNac.Size = New System.Drawing.Size(70, 20)
            Me.lblInternoFecNac.TabIndex = 134
            Me.lblInternoFecNac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblIntPabellon
            '
            Me.lblIntPabellon.BackColor = System.Drawing.SystemColors.Control
            Me.lblIntPabellon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblIntPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntPabellon.Location = New System.Drawing.Point(84, 154)
            Me.lblIntPabellon.Name = "lblIntPabellon"
            Me.lblIntPabellon.Size = New System.Drawing.Size(205, 20)
            Me.lblIntPabellon.TabIndex = 135
            Me.lblIntPabellon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblInternoEtapa
            '
            Me.lblInternoEtapa.BackColor = System.Drawing.SystemColors.Control
            Me.lblInternoEtapa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblInternoEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInternoEtapa.Location = New System.Drawing.Point(84, 175)
            Me.lblInternoEtapa.Name = "lblInternoEtapa"
            Me.lblInternoEtapa.Size = New System.Drawing.Size(205, 20)
            Me.lblInternoEtapa.TabIndex = 136
            Me.lblInternoEtapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlFotoInterno
            '
            Me.pnlFotoInterno.Controls.Add(Me.Label16)
            Me.pnlFotoInterno.Controls.Add(Me.UscFotografia_2v1)
            Me.pnlFotoInterno.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlFotoInterno.Location = New System.Drawing.Point(0, 0)
            Me.pnlFotoInterno.Name = "pnlFotoInterno"
            Me.pnlFotoInterno.Size = New System.Drawing.Size(190, 279)
            Me.pnlFotoInterno.TabIndex = 100
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.Transparent
            Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.ForeColor = System.Drawing.Color.Red
            Me.Label16.Location = New System.Drawing.Point(0, 257)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(190, 22)
            Me.Label16.TabIndex = 71
            Me.Label16.Text = "INTERNO"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'pnlTituloVisitaAdmin
            '
            Me.pnlTituloVisitaAdmin.Controls.Add(Me.Label26)
            Me.pnlTituloVisitaAdmin.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlTituloVisitaAdmin.Location = New System.Drawing.Point(3, 16)
            Me.pnlTituloVisitaAdmin.Name = "pnlTituloVisitaAdmin"
            Me.pnlTituloVisitaAdmin.Size = New System.Drawing.Size(484, 279)
            Me.pnlTituloVisitaAdmin.TabIndex = 35
            '
            'Label26
            '
            Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label26.Location = New System.Drawing.Point(0, 0)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(484, 279)
            Me.Label26.TabIndex = 72
            Me.Label26.Text = "[VISITA ADMINISTRATIVA]"
            Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlCuerpo
            '
            Me.pnlCuerpo.BackColor = System.Drawing.Color.Transparent
            Me.pnlCuerpo.Controls.Add(Me.grbDatosInterno)
            Me.pnlCuerpo.Controls.Add(Me.grbVisitante)
            Me.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCuerpo.Location = New System.Drawing.Point(0, 103)
            Me.pnlCuerpo.Name = "pnlCuerpo"
            Me.pnlCuerpo.Size = New System.Drawing.Size(1008, 298)
            Me.pnlCuerpo.TabIndex = 19
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(4, 26)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(60, 13)
            Me.Label12.TabIndex = 0
            Me.Label12.Text = "Tipo Doc. :"
            '
            'txtBuscarNumDoc
            '
            Me.txtBuscarNumDoc._BloquearPaste = False
            Me.txtBuscarNumDoc._SeleccionarTodo = True
            Me.txtBuscarNumDoc.BackColor = System.Drawing.Color.White
            Me.txtBuscarNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscarNumDoc.Location = New System.Drawing.Point(279, 12)
            Me.txtBuscarNumDoc.MaxLength = 8
            Me.txtBuscarNumDoc.Name = "txtBuscarNumDoc"
            Me.txtBuscarNumDoc.Size = New System.Drawing.Size(171, 38)
            Me.txtBuscarNumDoc.TabIndex = 3
            Me.txtBuscarNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtBuscarNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtBuscarNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(202, 25)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(73, 16)
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "Num Doc. :"
            '
            'pnlPie
            '
            Me.pnlPie.BackColor = System.Drawing.Color.Transparent
            Me.pnlPie.Controls.Add(Me.Panel3)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 512)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(1008, 50)
            Me.pnlPie.TabIndex = 45
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnOk)
            Me.Panel3.Controls.Add(Me.btnCancel)
            Me.Panel3.Controls.Add(Me.btnNuevoMov)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(700, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(308, 50)
            Me.Panel3.TabIndex = 109
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(93, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(102, 40)
            Me.btnOk.TabIndex = 3
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(197, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(102, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnNuevoMov
            '
            Me.btnNuevoMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoMov.Image = CType(resources.GetObject("btnNuevoMov.Image"), System.Drawing.Image)
            Me.btnNuevoMov.Location = New System.Drawing.Point(3, 4)
            Me.btnNuevoMov.Name = "btnNuevoMov"
            Me.btnNuevoMov.Size = New System.Drawing.Size(88, 40)
            Me.btnNuevoMov.TabIndex = 75
            Me.btnNuevoMov.Text = "&Nuevo"
            Me.btnNuevoMov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevoMov.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevoMov.UseVisualStyleBackColor = True
            '
            'pnlHora
            '
            Me.pnlHora.Controls.Add(Me.lblHoraVerificacion)
            Me.pnlHora.Controls.Add(Me.lblHora)
            Me.pnlHora.Controls.Add(Me.Label21)
            Me.pnlHora.Controls.Add(Me.Label23)
            Me.pnlHora.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlHora.Location = New System.Drawing.Point(279, 16)
            Me.pnlHora.Name = "pnlHora"
            Me.pnlHora.Size = New System.Drawing.Size(239, 92)
            Me.pnlHora.TabIndex = 110
            Me.pnlHora.Visible = False
            '
            'lblHoraVerificacion
            '
            Me.lblHoraVerificacion.AutoSize = True
            Me.lblHoraVerificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblHoraVerificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHoraVerificacion.Location = New System.Drawing.Point(104, 35)
            Me.lblHoraVerificacion.Name = "lblHoraVerificacion"
            Me.lblHoraVerificacion.Size = New System.Drawing.Size(130, 33)
            Me.lblHoraVerificacion.TabIndex = 34
            Me.lblHoraVerificacion.Text = "15:00:00"
            '
            'lblHora
            '
            Me.lblHora.AutoSize = True
            Me.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHora.Location = New System.Drawing.Point(104, 0)
            Me.lblHora.Name = "lblHora"
            Me.lblHora.Size = New System.Drawing.Size(130, 33)
            Me.lblHora.TabIndex = 32
            Me.lblHora.Text = "15:00:00"
            '
            'Label21
            '
            Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(1, 1)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(100, 30)
            Me.Label21.TabIndex = 28
            Me.Label21.Text = "Hora Ingreso :"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label23
            '
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(1, 37)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(100, 33)
            Me.Label23.TabIndex = 33
            Me.Label23.Text = "Hora Ingreso Verificacion :"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'gbRegioPenal
            '
            Me.gbRegioPenal.BackColor = System.Drawing.SystemColors.Control
            Me.gbRegioPenal.Controls.Add(Me.Label25)
            Me.gbRegioPenal.Controls.Add(Me.UsrRegionPenal1)
            Me.gbRegioPenal.Controls.Add(Me.Label27)
            Me.gbRegioPenal.Controls.Add(Me.lblFechaHoy)
            Me.gbRegioPenal.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbRegioPenal.Location = New System.Drawing.Point(0, 0)
            Me.gbRegioPenal.Name = "gbRegioPenal"
            Me.gbRegioPenal.Size = New System.Drawing.Size(1008, 42)
            Me.gbRegioPenal.TabIndex = 0
            Me.gbRegioPenal.TabStop = False
            '
            'Label25
            '
            Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label25.Location = New System.Drawing.Point(454, 14)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(3, 25)
            Me.Label25.TabIndex = 1
            '
            'UsrRegionPenal1
            '
            Me.UsrRegionPenal1._LicenciaID = -1
            Me.UsrRegionPenal1._PenalID = 0
            Me.UsrRegionPenal1._PenalTodos = True
            Me.UsrRegionPenal1._RegionID = 0
            Me.UsrRegionPenal1._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.Usuario
            Me.UsrRegionPenal1._UsuarioID = -1
            Me.UsrRegionPenal1._WidthLabelRegion = 66
            Me.UsrRegionPenal1.BackColor = System.Drawing.Color.Transparent
            Me.UsrRegionPenal1.Location = New System.Drawing.Point(3, 16)
            Me.UsrRegionPenal1.Name = "UsrRegionPenal1"
            Me.UsrRegionPenal1.Size = New System.Drawing.Size(444, 22)
            Me.UsrRegionPenal1.TabIndex = 1
            Me.UsrRegionPenal1.WidthRegion = 170
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(460, 20)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(43, 13)
            Me.Label27.TabIndex = 7
            Me.Label27.Text = "Fecha :"
            '
            'lblFechaHoy
            '
            Me.lblFechaHoy.BackColor = System.Drawing.SystemColors.Control
            Me.lblFechaHoy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblFechaHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaHoy.Location = New System.Drawing.Point(528, 16)
            Me.lblFechaHoy.Name = "lblFechaHoy"
            Me.lblFechaHoy.Size = New System.Drawing.Size(250, 22)
            Me.lblFechaHoy.TabIndex = 2
            Me.lblFechaHoy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlCabecera
            '
            Me.pnlCabecera.BackColor = System.Drawing.SystemColors.Control
            Me.pnlCabecera.Controls.Add(Me.GroupBox1)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 42)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(1008, 61)
            Me.pnlCabecera.TabIndex = 47
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.btnBuscar)
            Me.GroupBox1.Controls.Add(Me.Label12)
            Me.GroupBox1.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.txtBuscarNumDoc)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1008, 55)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'btnBuscar
            '
            Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Image = Global.SIPPOPE.My.Resources.Resources.view
            Me.btnBuscar.Location = New System.Drawing.Point(450, 12)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(40, 39)
            Me.btnBuscar.TabIndex = 4
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc._NoIndica = False
            Me.cbbTipoDoc._Todos = False
            Me.cbbTipoDoc._TodosMensaje = ""
            Me.cbbTipoDoc._Visible_Add = False
            Me.cbbTipoDoc._Visible_Buscar = False
            Me.cbbTipoDoc._Visible_Eliminar = False
            Me.cbbTipoDoc.CodigoPadre = -1
            Me.cbbTipoDoc.ComboTipo = Type.Combo.ComboTipo.Ninguno
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 150
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.Location = New System.Drawing.Point(70, 22)
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(103, 22)
            Me.cbbTipoDoc.TabIndex = 1
            '
            'pnlMenores
            '
            Me.pnlMenores.Controls.Add(Me.gbrMenores)
            Me.pnlMenores.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlMenores.Location = New System.Drawing.Point(0, 401)
            Me.pnlMenores.Name = "pnlMenores"
            Me.pnlMenores.Size = New System.Drawing.Size(487, 111)
            Me.pnlMenores.TabIndex = 30
            Me.pnlMenores.Visible = False
            '
            'gbrMenores
            '
            Me.gbrMenores.Controls.Add(Me.UscFotografia3)
            Me.gbrMenores.Controls.Add(Me.dgwMenores)
            Me.gbrMenores.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbrMenores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbrMenores.Location = New System.Drawing.Point(0, 0)
            Me.gbrMenores.Name = "gbrMenores"
            Me.gbrMenores.Size = New System.Drawing.Size(487, 111)
            Me.gbrMenores.TabIndex = 4
            Me.gbrMenores.TabStop = False
            Me.gbrMenores.Text = "Visitantes Menores de edad"
            '
            'UscFotografia3
            '
            Me.UscFotografia3._CheckImagen = True
            Me.UscFotografia3._EnabledDobleClick = True
            Me.UscFotografia3._HasImagen = False
            Me.UscFotografia3._PanelAutorizacion = False
            Me.UscFotografia3._PanelCheck = False
            Me.UscFotografia3.Location = New System.Drawing.Point(331, 53)
            Me.UscFotografia3.Name = "UscFotografia3"
            Me.UscFotografia3.Size = New System.Drawing.Size(116, 42)
            Me.UscFotografia3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia3.TabIndex = 73
            Me.UscFotografia3.Visible = False
            '
            'dgwMenores
            '
            Me.dgwMenores.AllowUserToAddRows = False
            Me.dgwMenores.AllowUserToDeleteRows = False
            Me.dgwMenores.AllowUserToResizeRows = False
            Me.dgwMenores.BackgroundColor = System.Drawing.Color.White
            Me.dgwMenores.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwMenores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwMenores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwMenores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_vis_apenom, Me.col_vis_edad, Me.col_vis_par, Me.col_fot_vis_id, Me.col_vis_fot_nom, Me.col_ver_fot})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwMenores.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwMenores.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwMenores.Location = New System.Drawing.Point(3, 16)
            Me.dgwMenores.Name = "dgwMenores"
            Me.dgwMenores.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwMenores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwMenores.RowHeadersVisible = False
            Me.dgwMenores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwMenores.Size = New System.Drawing.Size(481, 92)
            Me.dgwMenores.TabIndex = 7
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
            Me.col_vis_apenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_vis_apenom.DataPropertyName = "VisitanteApellidosyNombres"
            Me.col_vis_apenom.HeaderText = "Apellidos y Nombres"
            Me.col_vis_apenom.Name = "col_vis_apenom"
            Me.col_vis_apenom.ReadOnly = True
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
            'col_fot_vis_id
            '
            Me.col_fot_vis_id.DataPropertyName = "IDFotoVisitante"
            Me.col_fot_vis_id.HeaderText = "IDFoto"
            Me.col_fot_vis_id.Name = "col_fot_vis_id"
            Me.col_fot_vis_id.ReadOnly = True
            Me.col_fot_vis_id.Visible = False
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
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.lblParentesco)
            Me.GroupBox2.Controls.Add(Me.pnlHora)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(487, 401)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(521, 111)
            Me.GroupBox2.TabIndex = 48
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Datos del movimiento"
            '
            'lblParentesco
            '
            Me.lblParentesco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblParentesco.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblParentesco.Location = New System.Drawing.Point(3, 16)
            Me.lblParentesco.Name = "lblParentesco"
            Me.lblParentesco.Size = New System.Drawing.Size(276, 92)
            Me.lblParentesco.TabIndex = 111
            Me.lblParentesco.Text = "[PARENTESCO]"
            Me.lblParentesco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Timer1
            '
            Me.Timer1.Interval = 1000
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = True
            Me.UscFotografia_2v1._EnabledDobleClick = True
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = False
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(1, 0)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(185, 248)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 74
            '
            'frmVerificacionIngreso
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(1008, 562)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.pnlMenores)
            Me.Controls.Add(Me.pnlCuerpo)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Controls.Add(Me.gbRegioPenal)
            Me.Controls.Add(Me.pnlPie)
            Me.Name = "frmVerificacionIngreso"
            Me.Text = "Verificacion de Ingreso al Penal"
            Me.grbVisitante.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlFotoVisitante.ResumeLayout(False)
            Me.grbDatosInterno.ResumeLayout(False)
            Me.pnlDatosInterno.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlFotoInterno.ResumeLayout(False)
            Me.pnlTituloVisitaAdmin.ResumeLayout(False)
            Me.pnlCuerpo.ResumeLayout(False)
            Me.pnlPie.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.pnlHora.ResumeLayout(False)
            Me.pnlHora.PerformLayout()
            Me.gbRegioPenal.ResumeLayout(False)
            Me.gbRegioPenal.PerformLayout()
            Me.pnlCabecera.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.pnlMenores.ResumeLayout(False)
            Me.gbrMenores.ResumeLayout(False)
            CType(Me.dgwMenores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbVisitante As System.Windows.Forms.GroupBox
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
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblEdad As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents grbDatosInterno As System.Windows.Forms.GroupBox
        Friend WithEvents pnlFotoInterno As System.Windows.Forms.Panel
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents pnlFotoVisitante As System.Windows.Forms.Panel
        Friend WithEvents pnlCuerpo As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents lblIntEdad As System.Windows.Forms.Label
        Friend WithEvents lblIntSexo As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents lblIntNumDoc As System.Windows.Forms.Label
        Friend WithEvents UsrRegionPenal1 As APPControls.usrRegionPenal
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents txtBuscarNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents lblVisFechaNac As System.Windows.Forms.Label
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents lblEtapa As System.Windows.Forms.Label
        Friend WithEvents lblPabellon As System.Windows.Forms.Label
        Friend WithEvents gbRegioPenal As System.Windows.Forms.GroupBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlHora As System.Windows.Forms.Panel
        Friend WithEvents lblHoraVerificacion As System.Windows.Forms.Label
        Friend WithEvents lblHora As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents lblFechaHoy As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents lblIntTipoDoc As System.Windows.Forms.Label
        Friend WithEvents lblIntApePat As System.Windows.Forms.Label
        Friend WithEvents lblIntApeMat As System.Windows.Forms.Label
        Friend WithEvents lblIntNom As System.Windows.Forms.Label
        Friend WithEvents lblIntNacionalidad As System.Windows.Forms.Label
        Friend WithEvents lblInternoFecNac As System.Windows.Forms.Label
        Friend WithEvents lblIntPabellon As System.Windows.Forms.Label
        Friend WithEvents lblInternoEtapa As System.Windows.Forms.Label
        Friend WithEvents pnlMenores As System.Windows.Forms.Panel
        Friend WithEvents gbrMenores As System.Windows.Forms.GroupBox
        Friend WithEvents dgwMenores As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents btnNuevoMov As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents pnlTituloVisitaAdmin As System.Windows.Forms.Panel
        Friend WithEvents lblParentesco As System.Windows.Forms.Label
        Friend WithEvents pnlDatosInterno As System.Windows.Forms.Panel
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_apenom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_edad As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_par As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fot_vis_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_fot_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ver_fot As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents UscFotografia1 As APPControls.Foto.uscFotografia
        Friend WithEvents UscFotografia3 As APPControls.Foto.uscFotografia
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v

    End Class
End Namespace