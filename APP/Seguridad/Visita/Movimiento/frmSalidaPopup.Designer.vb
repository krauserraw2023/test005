Namespace Visita.Movimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmSalidaPopup
        Inherits Legolas.APPUIComponents.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.pnlAddObs = New System.Windows.Forms.Panel()
            Me.btnObs = New System.Windows.Forms.Button()
            Me.pnlHora = New System.Windows.Forms.Panel()
            Me.lblHoraSal = New System.Windows.Forms.Label()
            Me.lblHora = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.pnlOK = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.pnlCancelar = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.grbDatos = New System.Windows.Forms.GroupBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.lblNumPase = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblNumDoc = New System.Windows.Forms.Label()
            Me.lblTipDoc = New System.Windows.Forms.Label()
            Me.lblApePat = New System.Windows.Forms.Label()
            Me.lblApeMat = New System.Windows.Forms.Label()
            Me.lblNom = New System.Windows.Forms.Label()
            Me.lblNac = New System.Windows.Forms.Label()
            Me.lblSexo = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.pnlFotografia = New System.Windows.Forms.Panel()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UscFotoMenor = New APPControls.Foto.uscFotografia()
            Me.UscFotografia1 = New APPControls.Foto.uscFotografia()
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.pnlDatos = New System.Windows.Forms.Panel()
            Me.gbrMenores = New System.Windows.Forms.GroupBox()
            Me.dgwMenores = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_apenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_par = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_fot_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ver_fot = New System.Windows.Forms.DataGridViewImageColumn()
            Me.gbrBuscarNumDoc = New System.Windows.Forms.GroupBox()
            Me.cbbTipoDoc = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtBuscarNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlPie.SuspendLayout()
            Me.pnlAddObs.SuspendLayout()
            Me.pnlHora.SuspendLayout()
            Me.pnlOK.SuspendLayout()
            Me.pnlCancelar.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.grbDatos.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.pnlFotografia.SuspendLayout()
            Me.pnlDatos.SuspendLayout()
            Me.gbrMenores.SuspendLayout()
            CType(Me.dgwMenores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbrBuscarNumDoc.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label14
            '
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(-2, 3)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(52, 41)
            Me.Label14.TabIndex = 30
            Me.Label14.Text = "H. Ing. :"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlPie
            '
            Me.pnlPie.BackColor = System.Drawing.Color.Transparent
            Me.pnlPie.Controls.Add(Me.pnlAddObs)
            Me.pnlPie.Controls.Add(Me.pnlHora)
            Me.pnlPie.Controls.Add(Me.pnlOK)
            Me.pnlPie.Controls.Add(Me.pnlCancelar)
            Me.pnlPie.Controls.Add(Me.pnlSalir)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 427)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(926, 50)
            Me.pnlPie.TabIndex = 28
            '
            'pnlAddObs
            '
            Me.pnlAddObs.Controls.Add(Me.btnObs)
            Me.pnlAddObs.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlAddObs.Location = New System.Drawing.Point(363, 0)
            Me.pnlAddObs.Name = "pnlAddObs"
            Me.pnlAddObs.Size = New System.Drawing.Size(46, 50)
            Me.pnlAddObs.TabIndex = 40
            Me.pnlAddObs.Visible = False
            '
            'btnObs
            '
            Me.btnObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnObs.Image = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnObs.Location = New System.Drawing.Point(3, 4)
            Me.btnObs.Name = "btnObs"
            Me.btnObs.Size = New System.Drawing.Size(40, 40)
            Me.btnObs.TabIndex = 35
            Me.btnObs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlHora
            '
            Me.pnlHora.Controls.Add(Me.lblHoraSal)
            Me.pnlHora.Controls.Add(Me.lblHora)
            Me.pnlHora.Controls.Add(Me.Label14)
            Me.pnlHora.Controls.Add(Me.Label8)
            Me.pnlHora.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlHora.Location = New System.Drawing.Point(0, 0)
            Me.pnlHora.Name = "pnlHora"
            Me.pnlHora.Size = New System.Drawing.Size(363, 50)
            Me.pnlHora.TabIndex = 29
            '
            'lblHoraSal
            '
            Me.lblHoraSal.AutoSize = True
            Me.lblHoraSal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblHoraSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHoraSal.Location = New System.Drawing.Point(228, 7)
            Me.lblHoraSal.Name = "lblHoraSal"
            Me.lblHoraSal.Size = New System.Drawing.Size(130, 33)
            Me.lblHoraSal.TabIndex = 33
            Me.lblHoraSal.Text = "15:00:00"
            '
            'lblHora
            '
            Me.lblHora.AutoSize = True
            Me.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHora.Location = New System.Drawing.Point(47, 7)
            Me.lblHora.Name = "lblHora"
            Me.lblHora.Size = New System.Drawing.Size(130, 33)
            Me.lblHora.TabIndex = 31
            Me.lblHora.Text = "15:00:00"
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(177, 3)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(60, 41)
            Me.Label8.TabIndex = 32
            Me.Label8.Text = "H. Sal. :"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlOK
            '
            Me.pnlOK.Controls.Add(Me.btnOk)
            Me.pnlOK.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlOK.Location = New System.Drawing.Point(606, 0)
            Me.pnlOK.Name = "pnlOK"
            Me.pnlOK.Size = New System.Drawing.Size(108, 50)
            Me.pnlOK.TabIndex = 34
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(102, 40)
            Me.btnOk.TabIndex = 35
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlCancelar
            '
            Me.pnlCancelar.Controls.Add(Me.btnCancel)
            Me.pnlCancelar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlCancelar.Location = New System.Drawing.Point(714, 0)
            Me.pnlCancelar.Name = "pnlCancelar"
            Me.pnlCancelar.Size = New System.Drawing.Size(106, 50)
            Me.pnlCancelar.TabIndex = 36
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(1, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(102, 40)
            Me.btnCancel.TabIndex = 37
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(820, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(106, 50)
            Me.pnlSalir.TabIndex = 38
            '
            'btnSalir
            '
            Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(0, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(102, 40)
            Me.btnSalir.TabIndex = 39
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grbDatos
            '
            Me.grbDatos.Controls.Add(Me.Label11)
            Me.grbDatos.Controls.Add(Me.lblNumPase)
            Me.grbDatos.Controls.Add(Me.Label7)
            Me.grbDatos.Controls.Add(Me.Label6)
            Me.grbDatos.Controls.Add(Me.Label5)
            Me.grbDatos.Controls.Add(Me.Label4)
            Me.grbDatos.Controls.Add(Me.Label3)
            Me.grbDatos.Controls.Add(Me.Label2)
            Me.grbDatos.Controls.Add(Me.lblNumDoc)
            Me.grbDatos.Controls.Add(Me.lblTipDoc)
            Me.grbDatos.Controls.Add(Me.lblApePat)
            Me.grbDatos.Controls.Add(Me.lblApeMat)
            Me.grbDatos.Controls.Add(Me.lblNom)
            Me.grbDatos.Controls.Add(Me.lblNac)
            Me.grbDatos.Controls.Add(Me.lblSexo)
            Me.grbDatos.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbDatos.Location = New System.Drawing.Point(0, 50)
            Me.grbDatos.Name = "grbDatos"
            Me.grbDatos.Size = New System.Drawing.Size(321, 270)
            Me.grbDatos.TabIndex = 12
            Me.grbDatos.TabStop = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(12, 225)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(63, 16)
            Me.Label11.TabIndex = 26
            Me.Label11.Text = "N° Pase :"
            '
            'lblNumPase
            '
            Me.lblNumPase.BackColor = System.Drawing.SystemColors.Control
            Me.lblNumPase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNumPase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumPase.Location = New System.Drawing.Point(12, 241)
            Me.lblNumPase.Name = "lblNumPase"
            Me.lblNumPase.Size = New System.Drawing.Size(191, 22)
            Me.lblNumPase.TabIndex = 27
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(12, 178)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(95, 16)
            Me.Label7.TabIndex = 22
            Me.Label7.Text = "Nacionalidad :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(221, 178)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(45, 16)
            Me.Label6.TabIndex = 24
            Me.Label6.Text = "Sexo :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(12, 135)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(70, 16)
            Me.Label5.TabIndex = 20
            Me.Label5.Text = "Nombres :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(12, 92)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(94, 16)
            Me.Label4.TabIndex = 18
            Me.Label4.Text = "Segundo Ape. :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(12, 50)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(92, 16)
            Me.Label3.TabIndex = 16
            Me.Label3.Text = "Primer Ape. :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(12, 10)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(73, 16)
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "Num Doc. :"
            '
            'lblNumDoc
            '
            Me.lblNumDoc.BackColor = System.Drawing.SystemColors.Control
            Me.lblNumDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumDoc.Location = New System.Drawing.Point(12, 26)
            Me.lblNumDoc.Name = "lblNumDoc"
            Me.lblNumDoc.Size = New System.Drawing.Size(114, 22)
            Me.lblNumDoc.TabIndex = 14
            '
            'lblTipDoc
            '
            Me.lblTipDoc.BackColor = System.Drawing.SystemColors.Control
            Me.lblTipDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblTipDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipDoc.Location = New System.Drawing.Point(132, 26)
            Me.lblTipDoc.Name = "lblTipDoc"
            Me.lblTipDoc.Size = New System.Drawing.Size(180, 22)
            Me.lblTipDoc.TabIndex = 15
            '
            'lblApePat
            '
            Me.lblApePat.BackColor = System.Drawing.SystemColors.Control
            Me.lblApePat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblApePat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApePat.Location = New System.Drawing.Point(12, 68)
            Me.lblApePat.Name = "lblApePat"
            Me.lblApePat.Size = New System.Drawing.Size(300, 22)
            Me.lblApePat.TabIndex = 17
            '
            'lblApeMat
            '
            Me.lblApeMat.BackColor = System.Drawing.SystemColors.Control
            Me.lblApeMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblApeMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApeMat.Location = New System.Drawing.Point(12, 112)
            Me.lblApeMat.Name = "lblApeMat"
            Me.lblApeMat.Size = New System.Drawing.Size(300, 22)
            Me.lblApeMat.TabIndex = 19
            '
            'lblNom
            '
            Me.lblNom.BackColor = System.Drawing.SystemColors.Control
            Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNom.Location = New System.Drawing.Point(12, 151)
            Me.lblNom.Name = "lblNom"
            Me.lblNom.Size = New System.Drawing.Size(300, 22)
            Me.lblNom.TabIndex = 21
            '
            'lblNac
            '
            Me.lblNac.BackColor = System.Drawing.SystemColors.Control
            Me.lblNac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNac.Location = New System.Drawing.Point(12, 197)
            Me.lblNac.Name = "lblNac"
            Me.lblNac.Size = New System.Drawing.Size(191, 22)
            Me.lblNac.TabIndex = 23
            '
            'lblSexo
            '
            Me.lblSexo.BackColor = System.Drawing.SystemColors.Control
            Me.lblSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSexo.Location = New System.Drawing.Point(226, 197)
            Me.lblSexo.Name = "lblSexo"
            Me.lblSexo.Size = New System.Drawing.Size(86, 22)
            Me.lblSexo.TabIndex = 25
            '
            'Timer1
            '
            Me.Timer1.Interval = 1000
            '
            'pnlDetalle
            '
            Me.pnlDetalle.BackColor = System.Drawing.Color.Transparent
            Me.pnlDetalle.Controls.Add(Me.pnlFotografia)
            Me.pnlDetalle.Controls.Add(Me.pnlDatos)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(926, 427)
            Me.pnlDetalle.TabIndex = 0
            '
            'pnlFotografia
            '
            Me.pnlFotografia.BackColor = System.Drawing.SystemColors.Control
            Me.pnlFotografia.Controls.Add(Me.Label9)
            Me.pnlFotografia.Controls.Add(Me.Label1)
            Me.pnlFotografia.Controls.Add(Me.UscFotoMenor)
            Me.pnlFotografia.Controls.Add(Me.UscFotografia1)
            Me.pnlFotografia.Controls.Add(Me.UscFotografia_2v1)
            Me.pnlFotografia.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlFotografia.Location = New System.Drawing.Point(321, 0)
            Me.pnlFotografia.Name = "pnlFotografia"
            Me.pnlFotografia.Size = New System.Drawing.Size(605, 427)
            Me.pnlFotografia.TabIndex = 1
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Red
            Me.Label9.Location = New System.Drawing.Point(303, 389)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(297, 31)
            Me.Label9.TabIndex = 6
            Me.Label9.Text = "INTERNO(A)"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.Red
            Me.Label1.Location = New System.Drawing.Point(3, 389)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(297, 31)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "VISITANTE"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'UscFotoMenor
            '
            Me.UscFotoMenor._CheckImagen = True
            Me.UscFotoMenor._EnabledDobleClick = True
            Me.UscFotoMenor._HasImagen = False
            Me.UscFotoMenor._PanelAutorizacion = False
            Me.UscFotoMenor._PanelCheck = True
            Me.UscFotoMenor.Location = New System.Drawing.Point(74, 328)
            Me.UscFotoMenor.Name = "UscFotoMenor"
            Me.UscFotoMenor.Size = New System.Drawing.Size(134, 41)
            Me.UscFotoMenor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
            Me.UscFotoMenor.TabIndex = 4
            Me.UscFotoMenor.Visible = False
            '
            'UscFotografia1
            '
            Me.UscFotografia1._CheckImagen = True
            Me.UscFotografia1._EnabledDobleClick = False
            Me.UscFotografia1._HasImagen = False
            Me.UscFotografia1._PanelAutorizacion = False
            Me.UscFotografia1._PanelCheck = False
            Me.UscFotografia1.Location = New System.Drawing.Point(3, 2)
            Me.UscFotografia1.Name = "UscFotografia1"
            Me.UscFotografia1.Size = New System.Drawing.Size(297, 388)
            Me.UscFotografia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia1.TabIndex = 2
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = True
            Me.UscFotografia_2v1._EnabledDobleClick = False
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = False
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(303, 2)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(302, 386)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 72
            '
            'pnlDatos
            '
            Me.pnlDatos.BackColor = System.Drawing.Color.Transparent
            Me.pnlDatos.Controls.Add(Me.gbrMenores)
            Me.pnlDatos.Controls.Add(Me.grbDatos)
            Me.pnlDatos.Controls.Add(Me.gbrBuscarNumDoc)
            Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlDatos.Location = New System.Drawing.Point(0, 0)
            Me.pnlDatos.Name = "pnlDatos"
            Me.pnlDatos.Size = New System.Drawing.Size(321, 427)
            Me.pnlDatos.TabIndex = 7
            '
            'gbrMenores
            '
            Me.gbrMenores.Controls.Add(Me.dgwMenores)
            Me.gbrMenores.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbrMenores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbrMenores.Location = New System.Drawing.Point(0, 320)
            Me.gbrMenores.Name = "gbrMenores"
            Me.gbrMenores.Size = New System.Drawing.Size(321, 107)
            Me.gbrMenores.TabIndex = 26
            Me.gbrMenores.TabStop = False
            Me.gbrMenores.Text = "Visitantes Menores de edad"
            Me.gbrMenores.Visible = False
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
            Me.dgwMenores.Size = New System.Drawing.Size(315, 88)
            Me.dgwMenores.TabIndex = 27
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
            'gbrBuscarNumDoc
            '
            Me.gbrBuscarNumDoc.BackColor = System.Drawing.Color.Transparent
            Me.gbrBuscarNumDoc.Controls.Add(Me.cbbTipoDoc)
            Me.gbrBuscarNumDoc.Controls.Add(Me.btnBuscar)
            Me.gbrBuscarNumDoc.Controls.Add(Me.txtBuscarNumDoc)
            Me.gbrBuscarNumDoc.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbrBuscarNumDoc.Location = New System.Drawing.Point(0, 0)
            Me.gbrBuscarNumDoc.Name = "gbrBuscarNumDoc"
            Me.gbrBuscarNumDoc.Size = New System.Drawing.Size(321, 50)
            Me.gbrBuscarNumDoc.TabIndex = 8
            Me.gbrBuscarNumDoc.TabStop = False
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTipoDoc.DropDownWidth = 220
            Me.cbbTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbTipoDoc.FormattingEnabled = True
            Me.cbbTipoDoc.Location = New System.Drawing.Point(12, 14)
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Size = New System.Drawing.Size(76, 28)
            Me.cbbTipoDoc.TabIndex = 103
            '
            'btnBuscar
            '
            Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Image = Global.SIPPOPE.My.Resources.Resources.view
            Me.btnBuscar.Location = New System.Drawing.Point(272, 9)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(40, 39)
            Me.btnBuscar.TabIndex = 11
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'txtBuscarNumDoc
            '
            Me.txtBuscarNumDoc._BloquearPaste = False
            Me.txtBuscarNumDoc._SeleccionarTodo = True
            Me.txtBuscarNumDoc.BackColor = System.Drawing.Color.White
            Me.txtBuscarNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscarNumDoc.Location = New System.Drawing.Point(92, 9)
            Me.txtBuscarNumDoc.MaxLength = 50
            Me.txtBuscarNumDoc.Name = "txtBuscarNumDoc"
            Me.txtBuscarNumDoc.Size = New System.Drawing.Size(180, 38)
            Me.txtBuscarNumDoc.TabIndex = 10
            Me.txtBuscarNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtBuscarNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtBuscarNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'frmSalidaPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(926, 477)
            Me.Controls.Add(Me.pnlDetalle)
            Me.Controls.Add(Me.pnlPie)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmSalidaPopup"
            Me.ShowInTaskbar = False
            Me.Text = "Ingresar Salida "
            Me.pnlPie.ResumeLayout(False)
            Me.pnlAddObs.ResumeLayout(False)
            Me.pnlHora.ResumeLayout(False)
            Me.pnlHora.PerformLayout()
            Me.pnlOK.ResumeLayout(False)
            Me.pnlCancelar.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.grbDatos.ResumeLayout(False)
            Me.grbDatos.PerformLayout()
            Me.pnlDetalle.ResumeLayout(False)
            Me.pnlFotografia.ResumeLayout(False)
            Me.pnlDatos.ResumeLayout(False)
            Me.gbrMenores.ResumeLayout(False)
            CType(Me.dgwMenores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbrBuscarNumDoc.ResumeLayout(False)
            Me.gbrBuscarNumDoc.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents grbDatos As System.Windows.Forms.GroupBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblHora As System.Windows.Forms.Label
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents lblHoraSal As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents dgwMenores As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents UscFotografia1 As APPControls.Foto.uscFotografia
        Friend WithEvents pnlHora As System.Windows.Forms.Panel
        Friend WithEvents pnlFotografia As System.Windows.Forms.Panel
        Friend WithEvents pnlDatos As System.Windows.Forms.Panel
        Friend WithEvents gbrBuscarNumDoc As System.Windows.Forms.GroupBox
        Friend WithEvents txtBuscarNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlOK As System.Windows.Forms.Panel
        Friend WithEvents lblNumDoc As System.Windows.Forms.Label
        Friend WithEvents lblTipDoc As System.Windows.Forms.Label
        Friend WithEvents lblApePat As System.Windows.Forms.Label
        Friend WithEvents lblApeMat As System.Windows.Forms.Label
        Friend WithEvents lblNom As System.Windows.Forms.Label
        Friend WithEvents lblNac As System.Windows.Forms.Label
        Friend WithEvents lblSexo As System.Windows.Forms.Label
        Friend WithEvents gbrMenores As System.Windows.Forms.GroupBox
        Friend WithEvents UscFotoMenor As APPControls.Foto.uscFotografia
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_apenom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_edad As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_par As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_fot_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ver_fot As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlCancelar As System.Windows.Forms.Panel
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents pnlAddObs As System.Windows.Forms.Panel
        Friend WithEvents btnObs As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents lblNumPase As System.Windows.Forms.Label
        Friend WithEvents cbbTipoDoc As Legolas.APPUIComponents.MyComboBox

    End Class
End Namespace

