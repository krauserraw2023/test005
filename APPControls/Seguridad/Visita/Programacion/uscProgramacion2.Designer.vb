Namespace Visita.Programacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscProgramacion2
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.grbEtapa = New System.Windows.Forms.GroupBox()
            Me.pnlUserControl = New System.Windows.Forms.Panel()
            Me.UscProgramacionOrdinario1 = New APPControls.uscProgramacionOrdinario()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.UscFrecuencia1 = New APPControls.uscFrecuencia()
            Me.gb_SelectEtapa = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cbbEtapa = New APPControls.uscComboParametrica()
            Me.gbSexo = New System.Windows.Forms.GroupBox()
            Me.rdbSexoAmbos = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbMujeres = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbHombres = New Legolas.APPUIComponents.myRadioButton()
            Me.gbSelectInterno = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UscLabelBusqueda1 = New APPControls.uscLabelBusqueda()
            Me.pnlVisitaExtraordinario = New System.Windows.Forms.Panel()
            Me.btnAddAutorizacion = New System.Windows.Forms.Button()
            Me.btnAnularAutorizacion = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.UscAutorizacionGrilla1 = New APPControls.Visita.Autorizacion.uscAutorizacionGrilla()
            Me.pnlVisitaNormal = New System.Windows.Forms.Panel()
            Me.pnlVisita = New System.Windows.Forms.Panel()
            Me.grbEtapa.SuspendLayout()
            Me.pnlUserControl.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.gb_SelectEtapa.SuspendLayout()
            Me.gbSexo.SuspendLayout()
            Me.gbSelectInterno.SuspendLayout()
            Me.pnlVisitaExtraordinario.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.pnlVisitaNormal.SuspendLayout()
            Me.pnlVisita.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbEtapa
            '
            Me.grbEtapa.Controls.Add(Me.pnlUserControl)
            Me.grbEtapa.Controls.Add(Me.GroupBox6)
            Me.grbEtapa.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbEtapa.Location = New System.Drawing.Point(235, 0)
            Me.grbEtapa.Name = "grbEtapa"
            Me.grbEtapa.Size = New System.Drawing.Size(476, 652)
            Me.grbEtapa.TabIndex = 11
            Me.grbEtapa.TabStop = False
            Me.grbEtapa.Text = "Etapa A"
            '
            'pnlUserControl
            '
            Me.pnlUserControl.Controls.Add(Me.UscProgramacionOrdinario1)
            Me.pnlUserControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlUserControl.Location = New System.Drawing.Point(3, 196)
            Me.pnlUserControl.Name = "pnlUserControl"
            Me.pnlUserControl.Size = New System.Drawing.Size(470, 453)
            Me.pnlUserControl.TabIndex = 12
            '
            'UscProgramacionOrdinario1
            '
            Me.UscProgramacionOrdinario1._Duracion = 0
            Me.UscProgramacionOrdinario1._EdadFin = CType(-1, Short)
            Me.UscProgramacionOrdinario1._EdadIni = CType(-1, Short)
            Me.UscProgramacionOrdinario1._FamiliarAfinidad = False
            Me.UscProgramacionOrdinario1._FamiliarAfinidadCantidad = 0
            Me.UscProgramacionOrdinario1._FamiliarAfinidadGrado = -1
            Me.UscProgramacionOrdinario1._FamiliarConsaguidad = False
            Me.UscProgramacionOrdinario1._FamiliarConsanguidadCantidad = 0
            Me.UscProgramacionOrdinario1._FamiliarConsanguidadGrado = -1
            Me.UscProgramacionOrdinario1._HabilitarRangoEdades = False
            Me.UscProgramacionOrdinario1._HoraMinutoFin = 480
            Me.UscProgramacionOrdinario1._HoraMinutoInicio = 480
            Me.UscProgramacionOrdinario1._IncluyeAbogados = False
            Me.UscProgramacionOrdinario1._IncluyeAmigos = False
            Me.UscProgramacionOrdinario1._IncluyeConyugueConcubina = False
            Me.UscProgramacionOrdinario1._LimiteVisita = False
            Me.UscProgramacionOrdinario1._LimiteVisitaCantidad = 1
            Me.UscProgramacionOrdinario1._RegistradoPreviamente = False
            Me.UscProgramacionOrdinario1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscProgramacionOrdinario1.Location = New System.Drawing.Point(0, 0)
            Me.UscProgramacionOrdinario1.Name = "UscProgramacionOrdinario1"
            Me.UscProgramacionOrdinario1.Size = New System.Drawing.Size(470, 394)
            Me.UscProgramacionOrdinario1.TabIndex = 0
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.UscFrecuencia1)
            Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox6.Location = New System.Drawing.Point(3, 16)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(470, 180)
            Me.GroupBox6.TabIndex = 11
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Frecuencia de visitas"
            '
            'UscFrecuencia1
            '
            Me.UscFrecuencia1._Anio = -1
            Me.UscFrecuencia1._DiaSemanaDomingo = False
            Me.UscFrecuencia1._DiaSemanaJueves = False
            Me.UscFrecuencia1._DiaSemanaLunes = False
            Me.UscFrecuencia1._DiaSemanaMartes = False
            Me.UscFrecuencia1._DiaSemanaMiercoles = False
            Me.UscFrecuencia1._DiaSemanaSabado = False
            Me.UscFrecuencia1._DiaSemanaViernes = False
            Me.UscFrecuencia1._FechaFin = CType(0, Long)
            Me.UscFrecuencia1._FechaInicio = CType(0, Long)
            Me.UscFrecuencia1._Frecuencia = 1
            Me.UscFrecuencia1._FrecuenciaRepeticion = 0
            Me.UscFrecuencia1._Indeterminado = False
            Me.UscFrecuencia1._MensualDiaSemanaID = Nothing
            Me.UscFrecuencia1._MensualDiasID = Nothing
            Me.UscFrecuencia1._MensualElID = Nothing
            Me.UscFrecuencia1._MensualMesID = Nothing
            Me.UscFrecuencia1._MensualMesTipo = -1
            Me.UscFrecuencia1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFrecuencia1.Location = New System.Drawing.Point(3, 16)
            Me.UscFrecuencia1.Name = "UscFrecuencia1"
            Me.UscFrecuencia1.Size = New System.Drawing.Size(464, 161)
            Me.UscFrecuencia1.TabIndex = 12
            '
            'gb_SelectEtapa
            '
            Me.gb_SelectEtapa.Controls.Add(Me.Label3)
            Me.gb_SelectEtapa.Controls.Add(Me.cbbEtapa)
            Me.gb_SelectEtapa.Dock = System.Windows.Forms.DockStyle.Top
            Me.gb_SelectEtapa.Location = New System.Drawing.Point(0, 0)
            Me.gb_SelectEtapa.Name = "gb_SelectEtapa"
            Me.gb_SelectEtapa.Size = New System.Drawing.Size(235, 107)
            Me.gb_SelectEtapa.TabIndex = 12
            Me.gb_SelectEtapa.TabStop = False
            Me.gb_SelectEtapa.Text = "Etapa"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(7, 35)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(117, 13)
            Me.Label3.TabIndex = 83
            Me.Label3.Text = "Seleccione una etapa :"
            '
            'cbbEtapa
            '
            Me.cbbEtapa._NoIndica = False
            Me.cbbEtapa._Todos = False
            Me.cbbEtapa._TodosMensaje = ""
            Me.cbbEtapa._Visible_Add = False
            Me.cbbEtapa._Visible_Buscar = False
            Me.cbbEtapa._Visible_Eliminar = False
            Me.cbbEtapa.CodigoPadre = 1
            Me.cbbEtapa.ComboTipo = Type.Combo.ComboTipo.Ninguno
            Me.cbbEtapa.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbEtapa.DropDownWidth = 123
            Me.cbbEtapa.DropDownWidthAuto = False
            Me.cbbEtapa.Location = New System.Drawing.Point(9, 54)
            Me.cbbEtapa.Name = "cbbEtapa"
            Me.cbbEtapa.Parametro1 = -1
            Me.cbbEtapa.Parametro2 = -1
            Me.cbbEtapa.SelectedIndex = -1
            Me.cbbEtapa.SelectedValue = 0
            Me.cbbEtapa.Size = New System.Drawing.Size(188, 22)
            Me.cbbEtapa.TabIndex = 3
            '
            'gbSexo
            '
            Me.gbSexo.Controls.Add(Me.rdbSexoAmbos)
            Me.gbSexo.Controls.Add(Me.rdbMujeres)
            Me.gbSexo.Controls.Add(Me.rdbHombres)
            Me.gbSexo.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbSexo.Location = New System.Drawing.Point(0, 107)
            Me.gbSexo.Name = "gbSexo"
            Me.gbSexo.Size = New System.Drawing.Size(235, 89)
            Me.gbSexo.TabIndex = 71
            Me.gbSexo.TabStop = False
            Me.gbSexo.Text = "Sexo"
            '
            'rdbSexoAmbos
            '
            Me.rdbSexoAmbos.AutoSize = True
            Me.rdbSexoAmbos.Location = New System.Drawing.Point(42, 65)
            Me.rdbSexoAmbos.Name = "rdbSexoAmbos"
            Me.rdbSexoAmbos.Size = New System.Drawing.Size(57, 17)
            Me.rdbSexoAmbos.TabIndex = 63
            Me.rdbSexoAmbos.TabStop = True
            Me.rdbSexoAmbos.Text = "Ambos"
            Me.rdbSexoAmbos.UseVisualStyleBackColor = True
            '
            'rdbMujeres
            '
            Me.rdbMujeres.AutoSize = True
            Me.rdbMujeres.Location = New System.Drawing.Point(42, 42)
            Me.rdbMujeres.Name = "rdbMujeres"
            Me.rdbMujeres.Size = New System.Drawing.Size(62, 17)
            Me.rdbMujeres.TabIndex = 62
            Me.rdbMujeres.TabStop = True
            Me.rdbMujeres.Text = "Mujeres"
            Me.rdbMujeres.UseVisualStyleBackColor = True
            '
            'rdbHombres
            '
            Me.rdbHombres.AutoSize = True
            Me.rdbHombres.Checked = True
            Me.rdbHombres.Location = New System.Drawing.Point(42, 19)
            Me.rdbHombres.Name = "rdbHombres"
            Me.rdbHombres.Size = New System.Drawing.Size(67, 17)
            Me.rdbHombres.TabIndex = 61
            Me.rdbHombres.TabStop = True
            Me.rdbHombres.Text = "Hombres"
            Me.rdbHombres.UseVisualStyleBackColor = True
            '
            'gbSelectInterno
            '
            Me.gbSelectInterno.Controls.Add(Me.Label1)
            Me.gbSelectInterno.Controls.Add(Me.UscLabelBusqueda1)
            Me.gbSelectInterno.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbSelectInterno.Location = New System.Drawing.Point(0, 0)
            Me.gbSelectInterno.Name = "gbSelectInterno"
            Me.gbSelectInterno.Size = New System.Drawing.Size(235, 107)
            Me.gbSelectInterno.TabIndex = 72
            Me.gbSelectInterno.TabStop = False
            Me.gbSelectInterno.Text = "Interno"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 34)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(102, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Seleccione Interno :"
            '
            'UscLabelBusqueda1
            '
            Me.UscLabelBusqueda1._Codigo = 0
            Me.UscLabelBusqueda1._Value = "[SELECCIONE]"
            Me.UscLabelBusqueda1._Visible_Add = False
            Me.UscLabelBusqueda1._Visible_Buscar = True
            Me.UscLabelBusqueda1._Visible_Eliminar = False
            Me.UscLabelBusqueda1.Location = New System.Drawing.Point(9, 49)
            Me.UscLabelBusqueda1.Name = "UscLabelBusqueda1"
            Me.UscLabelBusqueda1.Size = New System.Drawing.Size(223, 21)
            Me.UscLabelBusqueda1.TabIndex = 8
            '
            'pnlVisitaExtraordinario
            '
            Me.pnlVisitaExtraordinario.Controls.Add(Me.btnAddAutorizacion)
            Me.pnlVisitaExtraordinario.Controls.Add(Me.btnAnularAutorizacion)
            Me.pnlVisitaExtraordinario.Controls.Add(Me.GroupBox1)
            Me.pnlVisitaExtraordinario.Controls.Add(Me.gbSelectInterno)
            Me.pnlVisitaExtraordinario.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlVisitaExtraordinario.Location = New System.Drawing.Point(0, 0)
            Me.pnlVisitaExtraordinario.Name = "pnlVisitaExtraordinario"
            Me.pnlVisitaExtraordinario.Size = New System.Drawing.Size(235, 652)
            Me.pnlVisitaExtraordinario.TabIndex = 73
            '
            'btnAddAutorizacion
            '
            Me.btnAddAutorizacion.Image = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddAutorizacion.Location = New System.Drawing.Point(132, 383)
            Me.btnAddAutorizacion.Name = "btnAddAutorizacion"
            Me.btnAddAutorizacion.Size = New System.Drawing.Size(97, 40)
            Me.btnAddAutorizacion.TabIndex = 75
            Me.btnAddAutorizacion.Text = "Agregar Visitante"
            Me.btnAddAutorizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAddAutorizacion.UseVisualStyleBackColor = True
            '
            'btnAnularAutorizacion
            '
            Me.btnAnularAutorizacion.Image = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnAnularAutorizacion.Location = New System.Drawing.Point(2, 383)
            Me.btnAnularAutorizacion.Name = "btnAnularAutorizacion"
            Me.btnAnularAutorizacion.Size = New System.Drawing.Size(97, 40)
            Me.btnAnularAutorizacion.TabIndex = 74
            Me.btnAnularAutorizacion.Text = "Eliminar Visitante"
            Me.btnAnularAutorizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAnularAutorizacion.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.UscAutorizacionGrilla1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 107)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(235, 273)
            Me.GroupBox1.TabIndex = 73
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Autorizacion"
            '
            'UscAutorizacionGrilla1
            '
            Me.UscAutorizacionGrilla1._IDCalendarioDetalle = -1
            Me.UscAutorizacionGrilla1._IDInterno = -1
            Me.UscAutorizacionGrilla1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAutorizacionGrilla1.Location = New System.Drawing.Point(3, 16)
            Me.UscAutorizacionGrilla1.Name = "UscAutorizacionGrilla1"
            Me.UscAutorizacionGrilla1.Size = New System.Drawing.Size(229, 254)
            Me.UscAutorizacionGrilla1.TabIndex = 14
            '
            'pnlVisitaNormal
            '
            Me.pnlVisitaNormal.Controls.Add(Me.gbSexo)
            Me.pnlVisitaNormal.Controls.Add(Me.gb_SelectEtapa)
            Me.pnlVisitaNormal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlVisitaNormal.Location = New System.Drawing.Point(0, 0)
            Me.pnlVisitaNormal.Name = "pnlVisitaNormal"
            Me.pnlVisitaNormal.Size = New System.Drawing.Size(235, 652)
            Me.pnlVisitaNormal.TabIndex = 13
            '
            'pnlVisita
            '
            Me.pnlVisita.Controls.Add(Me.pnlVisitaNormal)
            Me.pnlVisita.Controls.Add(Me.pnlVisitaExtraordinario)
            Me.pnlVisita.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlVisita.Location = New System.Drawing.Point(0, 0)
            Me.pnlVisita.Name = "pnlVisita"
            Me.pnlVisita.Size = New System.Drawing.Size(235, 652)
            Me.pnlVisita.TabIndex = 13
            '
            'uscProgramacion2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.grbEtapa)
            Me.Controls.Add(Me.pnlVisita)
            Me.Name = "uscProgramacion2"
            Me.Size = New System.Drawing.Size(711, 652)
            Me.grbEtapa.ResumeLayout(False)
            Me.pnlUserControl.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.gb_SelectEtapa.ResumeLayout(False)
            Me.gb_SelectEtapa.PerformLayout()
            Me.gbSexo.ResumeLayout(False)
            Me.gbSexo.PerformLayout()
            Me.gbSelectInterno.ResumeLayout(False)
            Me.gbSelectInterno.PerformLayout()
            Me.pnlVisitaExtraordinario.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.pnlVisitaNormal.ResumeLayout(False)
            Me.pnlVisita.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbEtapa As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents gb_SelectEtapa As System.Windows.Forms.GroupBox
        Friend WithEvents UscFrecuencia1 As APPControls.uscFrecuencia
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cbbEtapa As APPControls.uscComboParametrica
        Friend WithEvents pnlUserControl As System.Windows.Forms.Panel
        Friend WithEvents UscProgramacionOrdinario1 As APPControls.uscProgramacionOrdinario
        Friend WithEvents gbSexo As System.Windows.Forms.GroupBox
        Friend WithEvents rdbMujeres As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbHombres As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbSexoAmbos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents gbSelectInterno As System.Windows.Forms.GroupBox
        Friend WithEvents UscLabelBusqueda1 As APPControls.uscLabelBusqueda
        Friend WithEvents pnlVisitaExtraordinario As System.Windows.Forms.Panel
        Friend WithEvents pnlVisitaNormal As System.Windows.Forms.Panel
        Friend WithEvents pnlVisita As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents UscAutorizacionGrilla1 As APPControls.Visita.Autorizacion.uscAutorizacionGrilla
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnAddAutorizacion As System.Windows.Forms.Button
        Friend WithEvents btnAnularAutorizacion As System.Windows.Forms.Button
        'Friend WithEvents UscProgramacion1 As APPControls.uscFrecuencia

    End Class
End Namespace