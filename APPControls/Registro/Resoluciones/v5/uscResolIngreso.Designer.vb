Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscResolIngreso
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
            Me.components = New System.ComponentModel.Container()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtFolio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtLibro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblFechadocumento = New System.Windows.Forms.Label()
            Me.lblDocumento = New System.Windows.Forms.Label()
            Me.txtNumOficio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblFecharecepcion = New System.Windows.Forms.Label()
            Me.pnlObs = New System.Windows.Forms.Panel()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.pnlMotivo = New System.Windows.Forms.Panel()
            Me.cbbMotivo = New APPControls.uscComboParametrica()
            Me.lblMovTraslado = New System.Windows.Forms.Label()
            Me.Panel2.SuspendLayout()
            Me.pnlObs.SuspendLayout()
            Me.pnlMotivo.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.dtpDocJudFecRecep)
            Me.Panel2.Controls.Add(Me.txtFolio)
            Me.Panel2.Controls.Add(Me.txtLibro)
            Me.Panel2.Controls.Add(Me.dtpDocJudFecha)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.lblFechadocumento)
            Me.Panel2.Controls.Add(Me.lblDocumento)
            Me.Panel2.Controls.Add(Me.txtNumOficio)
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.lblFecharecepcion)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(422, 80)
            Me.Panel2.TabIndex = 0
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(113, 58)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'txtFolio
            '
            Me.txtFolio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFolio._BloquearPaste = False
            Me.txtFolio._SeleccionarTodo = False
            Me.txtFolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtFolio.Location = New System.Drawing.Point(358, 58)
            Me.txtFolio.MaxLength = 4
            Me.txtFolio.Name = "txtFolio"
            Me.txtFolio.Size = New System.Drawing.Size(60, 20)
            Me.txtFolio.TabIndex = 9
            Me.txtFolio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFolio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtLibro
            '
            Me.txtLibro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtLibro._BloquearPaste = False
            Me.txtLibro._SeleccionarTodo = False
            Me.txtLibro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtLibro.Location = New System.Drawing.Point(358, 33)
            Me.txtLibro.MaxLength = 20
            Me.txtLibro.Name = "txtLibro"
            Me.txtLibro.Size = New System.Drawing.Size(60, 20)
            Me.txtLibro.TabIndex = 7
            Me.txtLibro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtLibro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(113, 33)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(313, 61)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(32, 13)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Folio:"
            '
            'lblFechadocumento
            '
            Me.lblFechadocumento.AutoSize = True
            Me.lblFechadocumento.Location = New System.Drawing.Point(2, 36)
            Me.lblFechadocumento.Name = "lblFechadocumento"
            Me.lblFechadocumento.Size = New System.Drawing.Size(66, 13)
            Me.lblFechadocumento.TabIndex = 2
            Me.lblFechadocumento.Text = "Fecha Doc.:"
            '
            'lblDocumento
            '
            Me.lblDocumento.AutoSize = True
            Me.lblDocumento.Location = New System.Drawing.Point(2, 12)
            Me.lblDocumento.Name = "lblDocumento"
            Me.lblDocumento.Size = New System.Drawing.Size(83, 13)
            Me.lblDocumento.TabIndex = 0
            Me.lblDocumento.Text = "N° Documento :"
            Me.lblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtNumOficio
            '
            Me.txtNumOficio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumOficio._BloquearPaste = False
            Me.txtNumOficio._SeleccionarTodo = False
            Me.txtNumOficio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtNumOficio.Location = New System.Drawing.Point(113, 9)
            Me.txtNumOficio.MaxLength = 120
            Me.txtNumOficio.Name = "txtNumOficio"
            Me.txtNumOficio.Size = New System.Drawing.Size(306, 20)
            Me.txtNumOficio.TabIndex = 1
            Me.txtNumOficio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumOficio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(313, 36)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(33, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "Libro:"
            '
            'lblFecharecepcion
            '
            Me.lblFecharecepcion.AutoSize = True
            Me.lblFecharecepcion.Location = New System.Drawing.Point(2, 61)
            Me.lblFecharecepcion.Name = "lblFecharecepcion"
            Me.lblFecharecepcion.Size = New System.Drawing.Size(104, 13)
            Me.lblFecharecepcion.TabIndex = 4
            Me.lblFecharecepcion.Text = "Fecha Recep. Doc.:"
            '
            'pnlObs
            '
            Me.pnlObs.Controls.Add(Me.txtObservacion)
            Me.pnlObs.Controls.Add(Me.Label10)
            Me.pnlObs.Controls.Add(Me.pnlMotivo)
            Me.pnlObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlObs.Location = New System.Drawing.Point(0, 80)
            Me.pnlObs.Name = "pnlObs"
            Me.pnlObs.Size = New System.Drawing.Size(422, 61)
            Me.pnlObs.TabIndex = 1
            '
            'txtObservacion
            '
            Me.txtObservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = True
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Location = New System.Drawing.Point(113, 23)
            Me.txtObservacion.MaxLength = 2500
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(309, 38)
            Me.txtObservacion.TabIndex = 4
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label10
            '
            Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label10.Location = New System.Drawing.Point(0, 23)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(113, 38)
            Me.Label10.TabIndex = 3
            Me.Label10.Text = "Observaciones:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlMotivo
            '
            Me.pnlMotivo.Controls.Add(Me.cbbMotivo)
            Me.pnlMotivo.Controls.Add(Me.lblMovTraslado)
            Me.pnlMotivo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlMotivo.Location = New System.Drawing.Point(0, 0)
            Me.pnlMotivo.Name = "pnlMotivo"
            Me.pnlMotivo.Size = New System.Drawing.Size(422, 23)
            Me.pnlMotivo.TabIndex = 0
            Me.pnlMotivo.Visible = False
            '
            'cbbMotivo
            '
            Me.cbbMotivo._NoIndica = False
            Me.cbbMotivo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbMotivo._Todos = False
            Me.cbbMotivo._TodosMensaje = ""
            Me.cbbMotivo._Visible_Add = False
            Me.cbbMotivo._Visible_Buscar = False
            Me.cbbMotivo._Visible_Eliminar = False
            Me.cbbMotivo.CodigoPadre = -1
            Me.cbbMotivo.ComboTipo = CType(52, Short)
            Me.cbbMotivo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbMotivo.DropDownWidth = 325
            Me.cbbMotivo.DropDownWidthAuto = True
            Me.cbbMotivo.ListaIdsParaExcluir = Nothing
            Me.cbbMotivo.Location = New System.Drawing.Point(113, 1)
            Me.cbbMotivo.ModuloTratamiento = False
            Me.cbbMotivo.Name = "cbbMotivo"
            Me.cbbMotivo.Parametro1 = -1
            Me.cbbMotivo.Parametro2 = -1
            Me.cbbMotivo.SelectedIndex = -1
            Me.cbbMotivo.SelectedValue = 0
            Me.cbbMotivo.Size = New System.Drawing.Size(305, 22)
            Me.cbbMotivo.TabIndex = 1
            Me.cbbMotivo.verToolTipItemSeleccionado = False
            '
            'lblMovTraslado
            '
            Me.lblMovTraslado.AutoSize = True
            Me.lblMovTraslado.Location = New System.Drawing.Point(3, 3)
            Me.lblMovTraslado.Name = "lblMovTraslado"
            Me.lblMovTraslado.Size = New System.Drawing.Size(45, 13)
            Me.lblMovTraslado.TabIndex = 0
            Me.lblMovTraslado.Text = "Motivo :"
            '
            'uscResolIngreso
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlObs)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "uscResolIngreso"
            Me.Size = New System.Drawing.Size(422, 141)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlObs.ResumeLayout(False)
            Me.pnlObs.PerformLayout()
            Me.pnlMotivo.ResumeLayout(False)
            Me.pnlMotivo.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblFechadocumento As System.Windows.Forms.Label
        Friend WithEvents lblDocumento As System.Windows.Forms.Label
        Friend WithEvents lblFecharecepcion As System.Windows.Forms.Label
        Friend WithEvents txtNumOficio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtFolio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtLibro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlObs As System.Windows.Forms.Panel
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents pnlMotivo As Panel
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label10 As Label
        Friend WithEvents cbbMotivo As uscComboParametrica
        Friend WithEvents lblMovTraslado As Label
    End Class
End Namespace