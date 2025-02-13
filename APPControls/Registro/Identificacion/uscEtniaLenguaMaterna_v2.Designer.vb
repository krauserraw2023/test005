Namespace Registro.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscEtniaLenguaMaterna_v2
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
            Me.grbPuebloEtnica = New System.Windows.Forms.GroupBox()
            Me.pnlPertenenciaEtnica = New System.Windows.Forms.Panel()
            Me.cbbGrupoEtnica = New APPControls.uscComboParametrica()
            Me.Label52 = New System.Windows.Forms.Label()
            Me.cbbPuebloEtnica = New APPControls.uscComboParametrica()
            Me.txtpuebloEtnicaOtro = New System.Windows.Forms.TextBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.rdbSi = New System.Windows.Forms.RadioButton()
            Me.rdbNoIndica = New System.Windows.Forms.RadioButton()
            Me.rdbNo = New System.Windows.Forms.RadioButton()
            Me.Label51 = New System.Windows.Forms.Label()
            Me.grbLenguaMaterna = New System.Windows.Forms.GroupBox()
            Me.Label53 = New System.Windows.Forms.Label()
            Me.Label54 = New System.Windows.Forms.Label()
            Me.cbbGrupoLenguaMaterna = New APPControls.uscComboParametrica()
            Me.cbbLenguaMaternaIdioma = New APPControls.uscComboParametrica()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.pnlDomicilioDel = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlDomicilioMant = New System.Windows.Forms.Panel()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.grbPuebloEtnica.SuspendLayout()
            Me.pnlPertenenciaEtnica.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grbLenguaMaterna.SuspendLayout()
            Me.pnlBotones.SuspendLayout()
            Me.pnlDomicilioDel.SuspendLayout()
            Me.pnlDomicilioMant.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbPuebloEtnica
            '
            Me.grbPuebloEtnica.Controls.Add(Me.pnlPertenenciaEtnica)
            Me.grbPuebloEtnica.Controls.Add(Me.Panel1)
            Me.grbPuebloEtnica.Controls.Add(Me.Label51)
            Me.grbPuebloEtnica.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbPuebloEtnica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbPuebloEtnica.Location = New System.Drawing.Point(0, 0)
            Me.grbPuebloEtnica.Name = "grbPuebloEtnica"
            Me.grbPuebloEtnica.Size = New System.Drawing.Size(368, 150)
            Me.grbPuebloEtnica.TabIndex = 9
            Me.grbPuebloEtnica.TabStop = False
            Me.grbPuebloEtnica.Text = "Pertenencia étnica"
            '
            'pnlPertenenciaEtnica
            '
            Me.pnlPertenenciaEtnica.Controls.Add(Me.cbbGrupoEtnica)
            Me.pnlPertenenciaEtnica.Controls.Add(Me.Label52)
            Me.pnlPertenenciaEtnica.Controls.Add(Me.cbbPuebloEtnica)
            Me.pnlPertenenciaEtnica.Controls.Add(Me.txtpuebloEtnicaOtro)
            Me.pnlPertenenciaEtnica.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlPertenenciaEtnica.Location = New System.Drawing.Point(3, 80)
            Me.pnlPertenenciaEtnica.Name = "pnlPertenenciaEtnica"
            Me.pnlPertenenciaEtnica.Size = New System.Drawing.Size(362, 66)
            Me.pnlPertenenciaEtnica.TabIndex = 47
            '
            'cbbGrupoEtnica
            '
            Me.cbbGrupoEtnica._NoIndica = False
            Me.cbbGrupoEtnica._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbGrupoEtnica._Todos = False
            Me.cbbGrupoEtnica._TodosMensaje = ""
            Me.cbbGrupoEtnica._Visible_Add = False
            Me.cbbGrupoEtnica._Visible_Buscar = False
            Me.cbbGrupoEtnica._Visible_Eliminar = False
            Me.cbbGrupoEtnica.CodigoPadre = -1
            Me.cbbGrupoEtnica.ComboTipo = CType(90, Short)
            Me.cbbGrupoEtnica.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbGrupoEtnica.DropDownWidth = 400
            Me.cbbGrupoEtnica.DropDownWidthAuto = False
            Me.cbbGrupoEtnica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbGrupoEtnica.ListaIdsParaExcluir = Nothing
            Me.cbbGrupoEtnica.Location = New System.Drawing.Point(17, 6)
            Me.cbbGrupoEtnica.ModuloTratamiento = False
            Me.cbbGrupoEtnica.Name = "cbbGrupoEtnica"
            Me.cbbGrupoEtnica.Parametro1 = -1
            Me.cbbGrupoEtnica.Parametro2 = -1
            Me.cbbGrupoEtnica.SelectedIndex = -1
            Me.cbbGrupoEtnica.SelectedValue = 0
            Me.cbbGrupoEtnica.Size = New System.Drawing.Size(330, 22)
            Me.cbbGrupoEtnica.TabIndex = 2
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label52.Location = New System.Drawing.Point(279, 41)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(68, 13)
            Me.Label52.TabIndex = 5
            Me.Label52.Text = "(Especifique)"
            '
            'cbbPuebloEtnica
            '
            Me.cbbPuebloEtnica._NoIndica = False
            Me.cbbPuebloEtnica._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPuebloEtnica._Todos = False
            Me.cbbPuebloEtnica._TodosMensaje = ""
            Me.cbbPuebloEtnica._Visible_Add = False
            Me.cbbPuebloEtnica._Visible_Buscar = False
            Me.cbbPuebloEtnica._Visible_Eliminar = False
            Me.cbbPuebloEtnica.CodigoPadre = -1
            Me.cbbPuebloEtnica.ComboTipo = CType(91, Short)
            Me.cbbPuebloEtnica.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPuebloEtnica.DropDownWidth = 277
            Me.cbbPuebloEtnica.DropDownWidthAuto = False
            Me.cbbPuebloEtnica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPuebloEtnica.ListaIdsParaExcluir = Nothing
            Me.cbbPuebloEtnica.Location = New System.Drawing.Point(17, 37)
            Me.cbbPuebloEtnica.ModuloTratamiento = False
            Me.cbbPuebloEtnica.Name = "cbbPuebloEtnica"
            Me.cbbPuebloEtnica.Parametro1 = -1
            Me.cbbPuebloEtnica.Parametro2 = -1
            Me.cbbPuebloEtnica.SelectedIndex = -1
            Me.cbbPuebloEtnica.SelectedValue = 0
            Me.cbbPuebloEtnica.Size = New System.Drawing.Size(259, 22)
            Me.cbbPuebloEtnica.TabIndex = 4
            Me.cbbPuebloEtnica.Visible = False
            '
            'txtpuebloEtnicaOtro
            '
            Me.txtpuebloEtnicaOtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtpuebloEtnicaOtro.Enabled = False
            Me.txtpuebloEtnicaOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtpuebloEtnicaOtro.Location = New System.Drawing.Point(17, 38)
            Me.txtpuebloEtnicaOtro.MaxLength = 20
            Me.txtpuebloEtnicaOtro.Name = "txtpuebloEtnicaOtro"
            Me.txtpuebloEtnicaOtro.Size = New System.Drawing.Size(259, 20)
            Me.txtpuebloEtnicaOtro.TabIndex = 42
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.rdbSi)
            Me.Panel1.Controls.Add(Me.rdbNoIndica)
            Me.Panel1.Controls.Add(Me.rdbNo)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(3, 50)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(362, 30)
            Me.Panel1.TabIndex = 46
            '
            'rdbSi
            '
            Me.rdbSi.AutoSize = True
            Me.rdbSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSi.Location = New System.Drawing.Point(18, 7)
            Me.rdbSi.Name = "rdbSi"
            Me.rdbSi.Size = New System.Drawing.Size(34, 17)
            Me.rdbSi.TabIndex = 43
            Me.rdbSi.TabStop = True
            Me.rdbSi.Text = "Si"
            Me.rdbSi.UseVisualStyleBackColor = True
            '
            'rdbNoIndica
            '
            Me.rdbNoIndica.AutoSize = True
            Me.rdbNoIndica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNoIndica.Location = New System.Drawing.Point(136, 7)
            Me.rdbNoIndica.Name = "rdbNoIndica"
            Me.rdbNoIndica.Size = New System.Drawing.Size(70, 17)
            Me.rdbNoIndica.TabIndex = 45
            Me.rdbNoIndica.TabStop = True
            Me.rdbNoIndica.Text = "No indica"
            Me.rdbNoIndica.UseVisualStyleBackColor = True
            '
            'rdbNo
            '
            Me.rdbNo.AutoSize = True
            Me.rdbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNo.Location = New System.Drawing.Point(71, 7)
            Me.rdbNo.Name = "rdbNo"
            Me.rdbNo.Size = New System.Drawing.Size(39, 17)
            Me.rdbNo.TabIndex = 44
            Me.rdbNo.TabStop = True
            Me.rdbNo.Text = "No"
            Me.rdbNo.UseVisualStyleBackColor = True
            '
            'Label51
            '
            Me.Label51.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label51.Location = New System.Drawing.Point(3, 16)
            Me.Label51.Name = "Label51"
            Me.Label51.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.Label51.Size = New System.Drawing.Size(362, 34)
            Me.Label51.TabIndex = 3
            Me.Label51.Text = "¿Por sus costumbres y antepasados se siente o considera parte de un pueblo indíge" &
    "na u originario?"
            '
            'grbLenguaMaterna
            '
            Me.grbLenguaMaterna.Controls.Add(Me.Label53)
            Me.grbLenguaMaterna.Controls.Add(Me.Label54)
            Me.grbLenguaMaterna.Controls.Add(Me.cbbGrupoLenguaMaterna)
            Me.grbLenguaMaterna.Controls.Add(Me.cbbLenguaMaternaIdioma)
            Me.grbLenguaMaterna.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbLenguaMaterna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbLenguaMaterna.Location = New System.Drawing.Point(0, 150)
            Me.grbLenguaMaterna.Name = "grbLenguaMaterna"
            Me.grbLenguaMaterna.Size = New System.Drawing.Size(368, 113)
            Me.grbLenguaMaterna.TabIndex = 10
            Me.grbLenguaMaterna.TabStop = False
            Me.grbLenguaMaterna.Text = "Lengua materna"
            '
            'Label53
            '
            Me.Label53.AutoSize = True
            Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label53.Location = New System.Drawing.Point(283, 82)
            Me.Label53.Name = "Label53"
            Me.Label53.Size = New System.Drawing.Size(68, 13)
            Me.Label53.TabIndex = 9
            Me.Label53.Text = "(Especifique)"
            '
            'Label54
            '
            Me.Label54.AutoSize = True
            Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label54.Location = New System.Drawing.Point(17, 24)
            Me.Label54.Name = "Label54"
            Me.Label54.Size = New System.Drawing.Size(282, 13)
            Me.Label54.TabIndex = 7
            Me.Label54.Text = "Lengua materna con la que aprendió a hablar en su niñez:"
            '
            'cbbGrupoLenguaMaterna
            '
            Me.cbbGrupoLenguaMaterna._NoIndica = False
            Me.cbbGrupoLenguaMaterna._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbGrupoLenguaMaterna._Todos = False
            Me.cbbGrupoLenguaMaterna._TodosMensaje = ""
            Me.cbbGrupoLenguaMaterna._Visible_Add = False
            Me.cbbGrupoLenguaMaterna._Visible_Buscar = False
            Me.cbbGrupoLenguaMaterna._Visible_Eliminar = False
            Me.cbbGrupoLenguaMaterna.CodigoPadre = -1
            Me.cbbGrupoLenguaMaterna.ComboTipo = CType(92, Short)
            Me.cbbGrupoLenguaMaterna.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbGrupoLenguaMaterna.DropDownWidth = 277
            Me.cbbGrupoLenguaMaterna.DropDownWidthAuto = False
            Me.cbbGrupoLenguaMaterna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbGrupoLenguaMaterna.ListaIdsParaExcluir = Nothing
            Me.cbbGrupoLenguaMaterna.Location = New System.Drawing.Point(21, 45)
            Me.cbbGrupoLenguaMaterna.ModuloTratamiento = False
            Me.cbbGrupoLenguaMaterna.Name = "cbbGrupoLenguaMaterna"
            Me.cbbGrupoLenguaMaterna.Parametro1 = -1
            Me.cbbGrupoLenguaMaterna.Parametro2 = -1
            Me.cbbGrupoLenguaMaterna.SelectedIndex = -1
            Me.cbbGrupoLenguaMaterna.SelectedValue = 0
            Me.cbbGrupoLenguaMaterna.Size = New System.Drawing.Size(330, 22)
            Me.cbbGrupoLenguaMaterna.TabIndex = 6
            '
            'cbbLenguaMaternaIdioma
            '
            Me.cbbLenguaMaternaIdioma._NoIndica = False
            Me.cbbLenguaMaternaIdioma._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbLenguaMaternaIdioma._Todos = False
            Me.cbbLenguaMaternaIdioma._TodosMensaje = ""
            Me.cbbLenguaMaternaIdioma._Visible_Add = False
            Me.cbbLenguaMaternaIdioma._Visible_Buscar = False
            Me.cbbLenguaMaternaIdioma._Visible_Eliminar = False
            Me.cbbLenguaMaternaIdioma.CodigoPadre = -1
            Me.cbbLenguaMaternaIdioma.ComboTipo = CType(93, Short)
            Me.cbbLenguaMaternaIdioma.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbLenguaMaternaIdioma.DropDownWidth = 277
            Me.cbbLenguaMaternaIdioma.DropDownWidthAuto = False
            Me.cbbLenguaMaternaIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbLenguaMaternaIdioma.ListaIdsParaExcluir = Nothing
            Me.cbbLenguaMaternaIdioma.Location = New System.Drawing.Point(21, 79)
            Me.cbbLenguaMaternaIdioma.ModuloTratamiento = False
            Me.cbbLenguaMaternaIdioma.Name = "cbbLenguaMaternaIdioma"
            Me.cbbLenguaMaternaIdioma.Parametro1 = -1
            Me.cbbLenguaMaternaIdioma.Parametro2 = -1
            Me.cbbLenguaMaternaIdioma.SelectedIndex = -1
            Me.cbbLenguaMaternaIdioma.SelectedValue = 0
            Me.cbbLenguaMaternaIdioma.Size = New System.Drawing.Size(259, 22)
            Me.cbbLenguaMaternaIdioma.TabIndex = 8
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.pnlDomicilioDel)
            Me.pnlBotones.Controls.Add(Me.pnlDomicilioMant)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotones.Location = New System.Drawing.Point(368, 0)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(26, 263)
            Me.pnlBotones.TabIndex = 11
            '
            'pnlDomicilioDel
            '
            Me.pnlDomicilioDel.Controls.Add(Me.btnEliminar)
            Me.pnlDomicilioDel.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDomicilioDel.Location = New System.Drawing.Point(0, 58)
            Me.pnlDomicilioDel.Name = "pnlDomicilioDel"
            Me.pnlDomicilioDel.Size = New System.Drawing.Size(26, 32)
            Me.pnlDomicilioDel.TabIndex = 96
            '
            'btnEliminar
            '
            Me.btnEliminar.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Location = New System.Drawing.Point(0, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(25, 26)
            Me.btnEliminar.TabIndex = 89
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlDomicilioMant
            '
            Me.pnlDomicilioMant.Controls.Add(Me.btnModificar)
            Me.pnlDomicilioMant.Controls.Add(Me.btnGrabar)
            Me.pnlDomicilioMant.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDomicilioMant.Location = New System.Drawing.Point(0, 0)
            Me.pnlDomicilioMant.Name = "pnlDomicilioMant"
            Me.pnlDomicilioMant.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.pnlDomicilioMant.Size = New System.Drawing.Size(26, 58)
            Me.pnlDomicilioMant.TabIndex = 95
            '
            'btnModificar
            '
            Me.btnModificar.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnModificar.Location = New System.Drawing.Point(0, 31)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(26, 26)
            Me.btnModificar.TabIndex = 92
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'btnGrabar
            '
            Me.btnGrabar.BackgroundImage = Global.APPControls.My.Resources.Resources.Diskette_32x32
            Me.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnGrabar.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnGrabar.Enabled = False
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Location = New System.Drawing.Point(0, 5)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(26, 26)
            Me.btnGrabar.TabIndex = 91
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.grbLenguaMaterna)
            Me.Panel2.Controls.Add(Me.grbPuebloEtnica)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(368, 263)
            Me.Panel2.TabIndex = 12
            '
            'uscEtniaLenguaMaterna_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.pnlBotones)
            Me.Name = "uscEtniaLenguaMaterna_v2"
            Me.Size = New System.Drawing.Size(394, 263)
            Me.grbPuebloEtnica.ResumeLayout(False)
            Me.pnlPertenenciaEtnica.ResumeLayout(False)
            Me.pnlPertenenciaEtnica.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.grbLenguaMaterna.ResumeLayout(False)
            Me.grbLenguaMaterna.PerformLayout()
            Me.pnlBotones.ResumeLayout(False)
            Me.pnlDomicilioDel.ResumeLayout(False)
            Me.pnlDomicilioMant.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grbPuebloEtnica As GroupBox
        Friend WithEvents txtpuebloEtnicaOtro As TextBox
        Friend WithEvents Label52 As Label
        Friend WithEvents cbbPuebloEtnica As uscComboParametrica
        Friend WithEvents Label51 As Label
        Friend WithEvents cbbGrupoEtnica As uscComboParametrica
        Friend WithEvents grbLenguaMaterna As GroupBox
        Friend WithEvents Label53 As Label
        Friend WithEvents cbbLenguaMaternaIdioma As uscComboParametrica
        Friend WithEvents Label54 As Label
        Friend WithEvents cbbGrupoLenguaMaterna As uscComboParametrica
        Friend WithEvents Panel1 As Panel
        Friend WithEvents rdbSi As RadioButton
        Friend WithEvents rdbNoIndica As RadioButton
        Friend WithEvents rdbNo As RadioButton
        Friend WithEvents pnlPertenenciaEtnica As Panel
        Friend WithEvents pnlBotones As Panel
        Friend WithEvents pnlDomicilioDel As Panel
        Friend WithEvents btnEliminar As Button
        Friend WithEvents pnlDomicilioMant As Panel
        Friend WithEvents btnModificar As Button
        Friend WithEvents btnGrabar As Button
        Friend WithEvents Panel2 As Panel
    End Class
End Namespace