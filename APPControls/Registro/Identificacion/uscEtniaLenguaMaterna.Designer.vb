Namespace Registro.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscEtniaLenguaMaterna
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
            Me.GroupBox11 = New System.Windows.Forms.GroupBox()
            Me.txtPertenenciaEtnica = New System.Windows.Forms.TextBox()
            Me.Label52 = New System.Windows.Forms.Label()
            Me.cbbPerteneciaEtnicaOtros = New APPControls.uscComboParametrica()
            Me.Label51 = New System.Windows.Forms.Label()
            Me.cbbPertenenciaEtnica = New APPControls.uscComboParametrica()
            Me.GroupBox10 = New System.Windows.Forms.GroupBox()
            Me.Label53 = New System.Windows.Forms.Label()
            Me.cbbLenguaMaternaAuxiliar = New APPControls.uscComboParametrica()
            Me.Label54 = New System.Windows.Forms.Label()
            Me.cbbLenguaMaterna = New APPControls.uscComboParametrica()
            Me.GroupBox11.SuspendLayout()
            Me.GroupBox10.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox11
            '
            Me.GroupBox11.Controls.Add(Me.txtPertenenciaEtnica)
            Me.GroupBox11.Controls.Add(Me.Label52)
            Me.GroupBox11.Controls.Add(Me.cbbPerteneciaEtnicaOtros)
            Me.GroupBox11.Controls.Add(Me.Label51)
            Me.GroupBox11.Controls.Add(Me.cbbPertenenciaEtnica)
            Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox11.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox11.Name = "GroupBox11"
            Me.GroupBox11.Size = New System.Drawing.Size(359, 110)
            Me.GroupBox11.TabIndex = 9
            Me.GroupBox11.TabStop = False
            Me.GroupBox11.Text = "Pertenencia étnica"
            '
            'txtPertenenciaEtnica
            '
            Me.txtPertenenciaEtnica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPertenenciaEtnica.Enabled = False
            Me.txtPertenenciaEtnica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPertenenciaEtnica.Location = New System.Drawing.Point(21, 78)
            Me.txtPertenenciaEtnica.MaxLength = 20
            Me.txtPertenenciaEtnica.Name = "txtPertenenciaEtnica"
            Me.txtPertenenciaEtnica.Size = New System.Drawing.Size(259, 20)
            Me.txtPertenenciaEtnica.TabIndex = 42
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label52.Location = New System.Drawing.Point(283, 81)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(68, 13)
            Me.Label52.TabIndex = 5
            Me.Label52.Text = "(Especifique)"
            '
            'cbbPerteneciaEtnicaOtros
            '
            Me.cbbPerteneciaEtnicaOtros._NoIndica = False
            Me.cbbPerteneciaEtnicaOtros._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPerteneciaEtnicaOtros._Todos = False
            Me.cbbPerteneciaEtnicaOtros._TodosMensaje = ""
            Me.cbbPerteneciaEtnicaOtros._Visible_Add = False
            Me.cbbPerteneciaEtnicaOtros._Visible_Buscar = False
            Me.cbbPerteneciaEtnicaOtros._Visible_Eliminar = False
            Me.cbbPerteneciaEtnicaOtros.CodigoPadre = -1
            Me.cbbPerteneciaEtnicaOtros.ComboTipo = CType(91, Short)
            Me.cbbPerteneciaEtnicaOtros.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPerteneciaEtnicaOtros.DropDownWidth = 277
            Me.cbbPerteneciaEtnicaOtros.DropDownWidthAuto = False
            Me.cbbPerteneciaEtnicaOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPerteneciaEtnicaOtros.ListaIdsParaExcluir = Nothing
            Me.cbbPerteneciaEtnicaOtros.Location = New System.Drawing.Point(21, 77)
            Me.cbbPerteneciaEtnicaOtros.ModuloTratamiento = False
            Me.cbbPerteneciaEtnicaOtros.Name = "cbbPerteneciaEtnicaOtros"
            Me.cbbPerteneciaEtnicaOtros.Parametro1 = -1
            Me.cbbPerteneciaEtnicaOtros.Parametro2 = -1
            Me.cbbPerteneciaEtnicaOtros.SelectedIndex = -1
            Me.cbbPerteneciaEtnicaOtros.SelectedValue = 0
            Me.cbbPerteneciaEtnicaOtros.Size = New System.Drawing.Size(259, 22)
            Me.cbbPerteneciaEtnicaOtros.TabIndex = 4
            Me.cbbPerteneciaEtnicaOtros.Visible = False
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label51.Location = New System.Drawing.Point(15, 25)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(277, 13)
            Me.Label51.TabIndex = 3
            Me.Label51.Text = "Por sus costumbres y antepasados se siente o considera:"
            '
            'cbbPertenenciaEtnica
            '
            Me.cbbPertenenciaEtnica._NoIndica = False
            Me.cbbPertenenciaEtnica._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPertenenciaEtnica._Todos = False
            Me.cbbPertenenciaEtnica._TodosMensaje = ""
            Me.cbbPertenenciaEtnica._Visible_Add = False
            Me.cbbPertenenciaEtnica._Visible_Buscar = False
            Me.cbbPertenenciaEtnica._Visible_Eliminar = False
            Me.cbbPertenenciaEtnica.CodigoPadre = -1
            Me.cbbPertenenciaEtnica.ComboTipo = CType(90, Short)
            Me.cbbPertenenciaEtnica.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPertenenciaEtnica.DropDownWidth = 400
            Me.cbbPertenenciaEtnica.DropDownWidthAuto = False
            Me.cbbPertenenciaEtnica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPertenenciaEtnica.ListaIdsParaExcluir = Nothing
            Me.cbbPertenenciaEtnica.Location = New System.Drawing.Point(21, 46)
            Me.cbbPertenenciaEtnica.ModuloTratamiento = False
            Me.cbbPertenenciaEtnica.Name = "cbbPertenenciaEtnica"
            Me.cbbPertenenciaEtnica.Parametro1 = -1
            Me.cbbPertenenciaEtnica.Parametro2 = -1
            Me.cbbPertenenciaEtnica.SelectedIndex = -1
            Me.cbbPertenenciaEtnica.SelectedValue = 0
            Me.cbbPertenenciaEtnica.Size = New System.Drawing.Size(330, 22)
            Me.cbbPertenenciaEtnica.TabIndex = 2
            '
            'GroupBox10
            '
            Me.GroupBox10.Controls.Add(Me.Label53)
            Me.GroupBox10.Controls.Add(Me.cbbLenguaMaternaAuxiliar)
            Me.GroupBox10.Controls.Add(Me.Label54)
            Me.GroupBox10.Controls.Add(Me.cbbLenguaMaterna)
            Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox10.Location = New System.Drawing.Point(0, 110)
            Me.GroupBox10.Name = "GroupBox10"
            Me.GroupBox10.Size = New System.Drawing.Size(359, 112)
            Me.GroupBox10.TabIndex = 10
            Me.GroupBox10.TabStop = False
            Me.GroupBox10.Text = "Lengua materna"
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
            'cbbLenguaMaternaAuxiliar
            '
            Me.cbbLenguaMaternaAuxiliar._NoIndica = False
            Me.cbbLenguaMaternaAuxiliar._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbLenguaMaternaAuxiliar._Todos = False
            Me.cbbLenguaMaternaAuxiliar._TodosMensaje = ""
            Me.cbbLenguaMaternaAuxiliar._Visible_Add = False
            Me.cbbLenguaMaternaAuxiliar._Visible_Buscar = False
            Me.cbbLenguaMaternaAuxiliar._Visible_Eliminar = False
            Me.cbbLenguaMaternaAuxiliar.CodigoPadre = -1
            Me.cbbLenguaMaternaAuxiliar.ComboTipo = CType(93, Short)
            Me.cbbLenguaMaternaAuxiliar.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbLenguaMaternaAuxiliar.DropDownWidth = 277
            Me.cbbLenguaMaternaAuxiliar.DropDownWidthAuto = False
            Me.cbbLenguaMaternaAuxiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbLenguaMaternaAuxiliar.ListaIdsParaExcluir = Nothing
            Me.cbbLenguaMaternaAuxiliar.Location = New System.Drawing.Point(21, 79)
            Me.cbbLenguaMaternaAuxiliar.ModuloTratamiento = False
            Me.cbbLenguaMaternaAuxiliar.Name = "cbbLenguaMaternaAuxiliar"
            Me.cbbLenguaMaternaAuxiliar.Parametro1 = -1
            Me.cbbLenguaMaternaAuxiliar.Parametro2 = -1
            Me.cbbLenguaMaternaAuxiliar.SelectedIndex = -1
            Me.cbbLenguaMaternaAuxiliar.SelectedValue = 0
            Me.cbbLenguaMaternaAuxiliar.Size = New System.Drawing.Size(259, 22)
            Me.cbbLenguaMaternaAuxiliar.TabIndex = 8
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
            'cbbLenguaMaterna
            '
            Me.cbbLenguaMaterna._NoIndica = False
            Me.cbbLenguaMaterna._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbLenguaMaterna._Todos = False
            Me.cbbLenguaMaterna._TodosMensaje = ""
            Me.cbbLenguaMaterna._Visible_Add = False
            Me.cbbLenguaMaterna._Visible_Buscar = False
            Me.cbbLenguaMaterna._Visible_Eliminar = False
            Me.cbbLenguaMaterna.CodigoPadre = -1
            Me.cbbLenguaMaterna.ComboTipo = CType(92, Short)
            Me.cbbLenguaMaterna.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbLenguaMaterna.DropDownWidth = 277
            Me.cbbLenguaMaterna.DropDownWidthAuto = False
            Me.cbbLenguaMaterna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbLenguaMaterna.ListaIdsParaExcluir = Nothing
            Me.cbbLenguaMaterna.Location = New System.Drawing.Point(21, 45)
            Me.cbbLenguaMaterna.ModuloTratamiento = False
            Me.cbbLenguaMaterna.Name = "cbbLenguaMaterna"
            Me.cbbLenguaMaterna.Parametro1 = -1
            Me.cbbLenguaMaterna.Parametro2 = -1
            Me.cbbLenguaMaterna.SelectedIndex = -1
            Me.cbbLenguaMaterna.SelectedValue = 0
            Me.cbbLenguaMaterna.Size = New System.Drawing.Size(330, 22)
            Me.cbbLenguaMaterna.TabIndex = 6
            '
            'uscEtniaLenguaMaterna
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.GroupBox10)
            Me.Controls.Add(Me.GroupBox11)
            Me.Name = "uscEtniaLenguaMaterna"
            Me.Size = New System.Drawing.Size(359, 223)
            Me.GroupBox11.ResumeLayout(False)
            Me.GroupBox11.PerformLayout()
            Me.GroupBox10.ResumeLayout(False)
            Me.GroupBox10.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents GroupBox11 As GroupBox
        Friend WithEvents txtPertenenciaEtnica As TextBox
        Friend WithEvents Label52 As Label
        Friend WithEvents cbbPerteneciaEtnicaOtros As uscComboParametrica
        Friend WithEvents Label51 As Label
        Friend WithEvents cbbPertenenciaEtnica As uscComboParametrica
        Friend WithEvents GroupBox10 As GroupBox
        Friend WithEvents Label53 As Label
        Friend WithEvents cbbLenguaMaternaAuxiliar As uscComboParametrica
        Friend WithEvents Label54 As Label
        Friend WithEvents cbbLenguaMaterna As uscComboParametrica
    End Class
End Namespace