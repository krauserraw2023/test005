Namespace Tratamiento.TallerAsistencia.Planilla

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPlanillaPopup
        Inherits Legolas.APPUIComponents.FormPopup

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanillaPopup))
            Me.Label2 = New System.Windows.Forms.Label()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtFechaprocesamiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cbbAnio = New Legolas.APPUIComponents.uscComboAnio()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cbbMes = New Legolas.APPUIComponents.uscComboMes()
            Me.grbObs = New System.Windows.Forms.GroupBox()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbTalleres = New APPControls.uscComboParametrica()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.grbObs.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotones)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(409, 272)
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(12, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(91, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Actividad laboral :"
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.pnlGrabar)
            Me.PnlBotones.Controls.Add(Me.Panel1)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 222)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(409, 50)
            Me.PnlBotones.TabIndex = 3
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnGrabar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(219, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(100, 50)
            Me.pnlGrabar.TabIndex = 95
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnGrabar.Location = New System.Drawing.Point(3, 5)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(90, 40)
            Me.btnGrabar.TabIndex = 93
            Me.btnGrabar.Text = "&Grabar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnSalir)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(319, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(90, 50)
            Me.Panel1.TabIndex = 94
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(3, 5)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(83, 40)
            Me.btnSalir.TabIndex = 91
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Panel3)
            Me.GroupBox1.Controls.Add(Me.grbObs)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(409, 222)
            Me.GroupBox1.TabIndex = 5
            Me.GroupBox1.TabStop = False
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Label2)
            Me.Panel3.Controls.Add(Me.txtFechaprocesamiento)
            Me.Panel3.Controls.Add(Me.Label7)
            Me.Panel3.Controls.Add(Me.Label9)
            Me.Panel3.Controls.Add(Me.cbbAnio)
            Me.Panel3.Controls.Add(Me.Label8)
            Me.Panel3.Controls.Add(Me.cbbMes)
            Me.Panel3.Controls.Add(Me.cbbTalleres)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(403, 128)
            Me.Panel3.TabIndex = 24
            '
            'txtFechaprocesamiento
            '
            Me.txtFechaprocesamiento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaprocesamiento._BloquearPaste = False
            Me.txtFechaprocesamiento._SeleccionarTodo = False
            Me.txtFechaprocesamiento.Location = New System.Drawing.Point(128, 94)
            Me.txtFechaprocesamiento.Name = "txtFechaprocesamiento"
            Me.txtFechaprocesamiento.ReadOnly = True
            Me.txtFechaprocesamiento.Size = New System.Drawing.Size(149, 20)
            Me.txtFechaprocesamiento.TabIndex = 26
            Me.txtFechaprocesamiento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaprocesamiento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(12, 97)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(107, 13)
            Me.Label7.TabIndex = 25
            Me.Label7.Text = "Fec. Procesamiento :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(12, 72)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(33, 13)
            Me.Label9.TabIndex = 20
            Me.Label9.Text = "Mes :"
            '
            'cbbAnio
            '
            Me.cbbAnio._Todos = False
            Me.cbbAnio.AnioFin = 2010
            Me.cbbAnio.AnioInicio = 1900
            Me.cbbAnio.Location = New System.Drawing.Point(128, 40)
            Me.cbbAnio.Name = "cbbAnio"
            Me.cbbAnio.Size = New System.Drawing.Size(149, 21)
            Me.cbbAnio.TabIndex = 17
            Me.cbbAnio.Value = -1
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(12, 45)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(32, 13)
            Me.Label8.TabIndex = 19
            Me.Label8.Text = "Año :"
            '
            'cbbMes
            '
            Me.cbbMes._Todos = False
            Me.cbbMes.Location = New System.Drawing.Point(128, 67)
            Me.cbbMes.Mes = 0
            Me.cbbMes.MesAbreviatura = False
            Me.cbbMes.Name = "cbbMes"
            Me.cbbMes.Size = New System.Drawing.Size(149, 21)
            Me.cbbMes.TabIndex = 18
            Me.cbbMes.Value = 0
            '
            'grbObs
            '
            Me.grbObs.Controls.Add(Me.txtObs)
            Me.grbObs.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.grbObs.Location = New System.Drawing.Point(3, 144)
            Me.grbObs.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
            Me.grbObs.Name = "grbObs"
            Me.grbObs.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
            Me.grbObs.Size = New System.Drawing.Size(403, 75)
            Me.grbObs.TabIndex = 23
            Me.grbObs.TabStop = False
            Me.grbObs.Text = "Observacion"
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObs.Location = New System.Drawing.Point(20, 16)
            Me.txtObs.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Size = New System.Drawing.Size(380, 56)
            Me.txtObs.TabIndex = 22
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbTalleres
            '
            Me.cbbTalleres._NoIndica = False
            Me.cbbTalleres._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTalleres._Todos = False
            Me.cbbTalleres._TodosMensaje = ""
            Me.cbbTalleres._Visible_Add = False
            Me.cbbTalleres._Visible_Buscar = False
            Me.cbbTalleres._Visible_Eliminar = False
            Me.cbbTalleres.CodigoPadre = -1
            Me.cbbTalleres.ComboTipo = CType(2, Short)
            Me.cbbTalleres.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTalleres.DropDownWidth = 143
            Me.cbbTalleres.DropDownWidthAuto = False
            Me.cbbTalleres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbTalleres.ListaIdsParaExcluir = Nothing
            Me.cbbTalleres.Location = New System.Drawing.Point(128, 13)
            Me.cbbTalleres.ModuloTratamiento = False
            Me.cbbTalleres.Name = "cbbTalleres"
            Me.cbbTalleres.Parametro1 = -1
            Me.cbbTalleres.Parametro2 = -1
            Me.cbbTalleres.SelectedIndex = -1
            Me.cbbTalleres.SelectedValue = 0
            Me.cbbTalleres.Size = New System.Drawing.Size(266, 22)
            Me.cbbTalleres.TabIndex = 162
            '
            'frmPlanillaPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(409, 272)
            Me.Name = "frmPlanillaPopup"
            Me.Text = "Generación de Planilla"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.grbObs.ResumeLayout(False)
            Me.grbObs.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents txtFechaprocesamiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cbbMes As Legolas.APPUIComponents.uscComboMes
        Friend WithEvents grbObs As System.Windows.Forms.GroupBox
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbAnio As Legolas.APPUIComponents.uscComboAnio
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents cbbTalleres As APPControls.uscComboParametrica
    End Class
End Namespace