Namespace Tratamiento.Asistencia.Clasificacion.Penal

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmUbi_ClasifEtapa
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.components = New System.ComponentModel.Container()
            Me.PnlBotonesPrincipal = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnFinalizar = New System.Windows.Forms.Button()
            Me.btnGrabarClasificacion = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.gbDatosFicha = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.txtCama = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.txtAmbiente = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtAlero = New System.Windows.Forms.Label()
            Me.btnAlero = New System.Windows.Forms.Button()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.txtPiso = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.lblPabellon = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.lblEtapa = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.lblRegimen = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblFechaClasificacion = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblSituacionJuridica = New System.Windows.Forms.Label()
            Me.txtNumClasificacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label13 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.PnlBotonesPrincipal.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.gbDatosFicha.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'PnlBotonesPrincipal
            '
            Me.PnlBotonesPrincipal.Controls.Add(Me.Panel2)
            Me.PnlBotonesPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotonesPrincipal.Location = New System.Drawing.Point(0, 297)
            Me.PnlBotonesPrincipal.Name = "PnlBotonesPrincipal"
            Me.PnlBotonesPrincipal.Size = New System.Drawing.Size(874, 43)
            Me.PnlBotonesPrincipal.TabIndex = 5
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnFinalizar)
            Me.Panel2.Controls.Add(Me.btnGrabarClasificacion)
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(601, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(273, 43)
            Me.Panel2.TabIndex = 3
            '
            'btnFinalizar
            '
            Me.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFinalizar.Image = Global.APPControls.My.Resources.Resources.candado
            Me.btnFinalizar.Location = New System.Drawing.Point(0, 1)
            Me.btnFinalizar.Name = "btnFinalizar"
            Me.btnFinalizar.Size = New System.Drawing.Size(89, 40)
            Me.btnFinalizar.TabIndex = 98
            Me.btnFinalizar.Text = "Finalizar"
            Me.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnFinalizar, "Permite finalizar la ficha, posterior a ello ya no podrá modificar el registro.")
            '
            'btnGrabarClasificacion
            '
            Me.btnGrabarClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabarClasificacion.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnGrabarClasificacion.Location = New System.Drawing.Point(90, 1)
            Me.btnGrabarClasificacion.Name = "btnGrabarClasificacion"
            Me.btnGrabarClasificacion.Size = New System.Drawing.Size(89, 40)
            Me.btnGrabarClasificacion.TabIndex = 1
            Me.btnGrabarClasificacion.Text = "&Guardar"
            Me.btnGrabarClasificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnGrabarClasificacion, "Permite grabar los datos antes de finalizar la ficha.")
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(180, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(89, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlDetalle
            '
            Me.pnlDetalle.Controls.Add(Me.gbDatosFicha)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(874, 297)
            Me.pnlDetalle.TabIndex = 100
            '
            'gbDatosFicha
            '
            Me.gbDatosFicha.Controls.Add(Me.Panel1)
            Me.gbDatosFicha.Controls.Add(Me.Panel9)
            Me.gbDatosFicha.Controls.Add(Me.Panel8)
            Me.gbDatosFicha.Controls.Add(Me.Panel7)
            Me.gbDatosFicha.Controls.Add(Me.Panel6)
            Me.gbDatosFicha.Controls.Add(Me.Panel5)
            Me.gbDatosFicha.Controls.Add(Me.Panel4)
            Me.gbDatosFicha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbDatosFicha.Location = New System.Drawing.Point(0, 0)
            Me.gbDatosFicha.Name = "gbDatosFicha"
            Me.gbDatosFicha.Size = New System.Drawing.Size(874, 297)
            Me.gbDatosFicha.TabIndex = 99
            Me.gbDatosFicha.TabStop = False
            Me.gbDatosFicha.Text = "DATOS DE LA UBICACION DEL PABELLON"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.txtObs)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(296, 156)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(575, 137)
            Me.Panel1.TabIndex = 105
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtObs.BackColor = System.Drawing.Color.White
            Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObs.Location = New System.Drawing.Point(95, 8)
            Me.txtObs.MaxLength = 600
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(471, 126)
            Me.txtObs.TabIndex = 102
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(13, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(70, 13)
            Me.Label1.TabIndex = 29
            Me.Label1.Text = "Observación:"
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.txtCama)
            Me.Panel9.Controls.Add(Me.Label15)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel9.Location = New System.Drawing.Point(296, 128)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(575, 28)
            Me.Panel9.TabIndex = 104
            '
            'txtCama
            '
            Me.txtCama._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCama._BloquearPaste = False
            Me.txtCama._SeleccionarTodo = False
            Me.txtCama.BackColor = System.Drawing.Color.White
            Me.txtCama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCama.Location = New System.Drawing.Point(95, 5)
            Me.txtCama.MaxLength = 100
            Me.txtCama.Name = "txtCama"
            Me.txtCama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtCama.Size = New System.Drawing.Size(214, 20)
            Me.txtCama.TabIndex = 102
            Me.txtCama.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCama.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(13, 8)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(37, 13)
            Me.Label15.TabIndex = 29
            Me.Label15.Text = "Cama:"
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.txtAmbiente)
            Me.Panel8.Controls.Add(Me.Label10)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel8.Location = New System.Drawing.Point(296, 100)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(575, 28)
            Me.Panel8.TabIndex = 103
            '
            'txtAmbiente
            '
            Me.txtAmbiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtAmbiente.Location = New System.Drawing.Point(95, 4)
            Me.txtAmbiente.MaxLength = 100
            Me.txtAmbiente.Name = "txtAmbiente"
            Me.txtAmbiente.Size = New System.Drawing.Size(214, 20)
            Me.txtAmbiente.TabIndex = 30
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(13, 8)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(54, 13)
            Me.Label10.TabIndex = 29
            Me.Label10.Text = "Ambiente:"
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.Label14)
            Me.Panel7.Controls.Add(Me.txtAlero)
            Me.Panel7.Controls.Add(Me.btnAlero)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel7.Location = New System.Drawing.Point(296, 72)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(575, 28)
            Me.Panel7.TabIndex = 102
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(13, 8)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(28, 13)
            Me.Label14.TabIndex = 29
            Me.Label14.Text = "Ala :"
            '
            'txtAlero
            '
            Me.txtAlero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.txtAlero.Location = New System.Drawing.Point(95, 3)
            Me.txtAlero.Name = "txtAlero"
            Me.txtAlero.Size = New System.Drawing.Size(213, 20)
            Me.txtAlero.TabIndex = 104
            Me.txtAlero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnAlero
            '
            Me.btnAlero.BackgroundImage = Global.APPControls.My.Resources.Resources._1345240399_search_button
            Me.btnAlero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAlero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAlero.Location = New System.Drawing.Point(308, 3)
            Me.btnAlero.Name = "btnAlero"
            Me.btnAlero.Size = New System.Drawing.Size(28, 26)
            Me.btnAlero.TabIndex = 105
            Me.btnAlero.UseVisualStyleBackColor = True
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.txtPiso)
            Me.Panel6.Controls.Add(Me.Label12)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Location = New System.Drawing.Point(296, 44)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(575, 28)
            Me.Panel6.TabIndex = 101
            '
            'txtPiso
            '
            Me.txtPiso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.txtPiso.Location = New System.Drawing.Point(95, 3)
            Me.txtPiso.Name = "txtPiso"
            Me.txtPiso.Size = New System.Drawing.Size(214, 20)
            Me.txtPiso.TabIndex = 104
            Me.txtPiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(13, 8)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(33, 13)
            Me.Label12.TabIndex = 29
            Me.Label12.Text = "Piso :"
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.lblPabellon)
            Me.Panel5.Controls.Add(Me.Label7)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel5.Location = New System.Drawing.Point(296, 16)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(575, 28)
            Me.Panel5.TabIndex = 100
            '
            'lblPabellon
            '
            Me.lblPabellon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPabellon.ForeColor = System.Drawing.Color.Black
            Me.lblPabellon.Location = New System.Drawing.Point(95, 5)
            Me.lblPabellon.Name = "lblPabellon"
            Me.lblPabellon.Size = New System.Drawing.Size(213, 18)
            Me.lblPabellon.TabIndex = 30
            Me.lblPabellon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(13, 7)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(54, 13)
            Me.Label7.TabIndex = 29
            Me.Label7.Text = "Pabellón :"
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.lblEstado)
            Me.Panel4.Controls.Add(Me.Label21)
            Me.Panel4.Controls.Add(Me.lblEtapa)
            Me.Panel4.Controls.Add(Me.Label19)
            Me.Panel4.Controls.Add(Me.lblRegimen)
            Me.Panel4.Controls.Add(Me.Label17)
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Controls.Add(Me.lblFechaClasificacion)
            Me.Panel4.Controls.Add(Me.Label4)
            Me.Panel4.Controls.Add(Me.lblSituacionJuridica)
            Me.Panel4.Controls.Add(Me.txtNumClasificacion)
            Me.Panel4.Controls.Add(Me.Label13)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel4.Location = New System.Drawing.Point(3, 16)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(293, 278)
            Me.Panel4.TabIndex = 99
            '
            'lblEstado
            '
            Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstado.ForeColor = System.Drawing.Color.Black
            Me.lblEstado.Location = New System.Drawing.Point(119, 126)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(164, 18)
            Me.lblEstado.TabIndex = 35
            Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(13, 129)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(43, 13)
            Me.Label21.TabIndex = 34
            Me.Label21.Text = "Estado:"
            '
            'lblEtapa
            '
            Me.lblEtapa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtapa.ForeColor = System.Drawing.Color.Black
            Me.lblEtapa.Location = New System.Drawing.Point(119, 103)
            Me.lblEtapa.Name = "lblEtapa"
            Me.lblEtapa.Size = New System.Drawing.Size(164, 18)
            Me.lblEtapa.TabIndex = 33
            Me.lblEtapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(13, 106)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(38, 13)
            Me.Label19.TabIndex = 32
            Me.Label19.Text = "Etapa:"
            '
            'lblRegimen
            '
            Me.lblRegimen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegimen.ForeColor = System.Drawing.Color.Black
            Me.lblRegimen.Location = New System.Drawing.Point(119, 80)
            Me.lblRegimen.Name = "lblRegimen"
            Me.lblRegimen.Size = New System.Drawing.Size(164, 18)
            Me.lblRegimen.TabIndex = 31
            Me.lblRegimen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(13, 82)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(52, 13)
            Me.Label17.TabIndex = 30
            Me.Label17.Text = "Régimen:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(13, 11)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(84, 13)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "N° Clasificación:"
            '
            'lblFechaClasificacion
            '
            Me.lblFechaClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblFechaClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaClasificacion.ForeColor = System.Drawing.Color.Black
            Me.lblFechaClasificacion.Location = New System.Drawing.Point(119, 57)
            Me.lblFechaClasificacion.Name = "lblFechaClasificacion"
            Me.lblFechaClasificacion.Size = New System.Drawing.Size(164, 18)
            Me.lblFechaClasificacion.TabIndex = 29
            Me.lblFechaClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(13, 59)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(102, 13)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Fecha Clasificación:"
            '
            'lblSituacionJuridica
            '
            Me.lblSituacionJuridica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblSituacionJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSituacionJuridica.ForeColor = System.Drawing.Color.Black
            Me.lblSituacionJuridica.Location = New System.Drawing.Point(119, 33)
            Me.lblSituacionJuridica.Name = "lblSituacionJuridica"
            Me.lblSituacionJuridica.Size = New System.Drawing.Size(164, 18)
            Me.lblSituacionJuridica.TabIndex = 27
            Me.lblSituacionJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtNumClasificacion
            '
            Me.txtNumClasificacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumClasificacion._BloquearPaste = False
            Me.txtNumClasificacion._SeleccionarTodo = False
            Me.txtNumClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumClasificacion.ForeColor = System.Drawing.Color.Black
            Me.txtNumClasificacion.Location = New System.Drawing.Point(119, 6)
            Me.txtNumClasificacion.MaxLength = 2
            Me.txtNumClasificacion.Name = "txtNumClasificacion"
            Me.txtNumClasificacion.ReadOnly = True
            Me.txtNumClasificacion.Size = New System.Drawing.Size(58, 21)
            Me.txtNumClasificacion.TabIndex = 22
            Me.txtNumClasificacion.Text = "0"
            Me.txtNumClasificacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumClasificacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(13, 35)
            Me.Label13.Margin = New System.Windows.Forms.Padding(0)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(96, 13)
            Me.Label13.TabIndex = 28
            Me.Label13.Text = "Situación Juridica :"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmUbi_ClasifEtapa
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(874, 340)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlDetalle)
            Me.Controls.Add(Me.PnlBotonesPrincipal)
            Me.Name = "frmUbi_ClasifEtapa"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = ".::. Ubicación"
            Me.PnlBotonesPrincipal.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            Me.gbDatosFicha.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel9.ResumeLayout(False)
            Me.Panel9.PerformLayout()
            Me.Panel8.ResumeLayout(False)
            Me.Panel8.PerformLayout()
            Me.Panel7.ResumeLayout(False)
            Me.Panel7.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents PnlBotonesPrincipal As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents btnFinalizar As Button
        Friend WithEvents btnGrabarClasificacion As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents pnlDetalle As Panel
        Friend WithEvents gbDatosFicha As GroupBox
        Friend WithEvents Panel1 As Panel
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Panel9 As Panel
        Friend WithEvents txtCama As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label15 As Label
        Friend WithEvents Panel8 As Panel
        Friend WithEvents btnAlero As Button
        Friend WithEvents txtAlero As Label
        Friend WithEvents Label14 As Label
        Friend WithEvents Panel7 As Panel
        Friend WithEvents Label10 As Label
        Friend WithEvents Panel6 As Panel
        Friend WithEvents txtPiso As Label
        Friend WithEvents Label12 As Label
        Friend WithEvents Panel5 As Panel
        Friend WithEvents lblPabellon As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Panel4 As Panel
        Friend WithEvents lblEstado As Label
        Friend WithEvents Label21 As Label
        Friend WithEvents lblEtapa As Label
        Friend WithEvents Label19 As Label
        Friend WithEvents lblRegimen As Label
        Friend WithEvents Label17 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents lblFechaClasificacion As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents lblSituacionJuridica As Label
        Friend WithEvents txtNumClasificacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label13 As Label
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents txtAmbiente As TextBox
    End Class

End Namespace