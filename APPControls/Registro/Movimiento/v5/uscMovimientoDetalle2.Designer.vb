Namespace Registro

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscMovimientoDetalle2
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
            Me.components = New System.ComponentModel.Container()
            Me.gbRegionPenal = New System.Windows.Forms.GroupBox()
            Me.cbbRegionIngreso = New APPControls.uscComboParametrica()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbbPenalIngreso = New APPControls.uscComboParametrica()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFechaMov = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblfecha = New System.Windows.Forms.Label()
            Me.lblMovMotivo = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.cbbMovMotivoTraslado = New APPControls.uscComboParametrica()
            Me.txtMovimiento = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbMovMotivo = New APPControls.uscComboParametrica()
            Me.nudMinutos = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.nudHora = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.lblMovTraslado = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.gbRegionPenal.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbRegionPenal
            '
            Me.gbRegionPenal.Controls.Add(Me.cbbRegionIngreso)
            Me.gbRegionPenal.Controls.Add(Me.Label3)
            Me.gbRegionPenal.Controls.Add(Me.Label4)
            Me.gbRegionPenal.Controls.Add(Me.cbbPenalIngreso)
            Me.gbRegionPenal.Controls.Add(Me.Label9)
            Me.gbRegionPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRegionPenal.Location = New System.Drawing.Point(0, 97)
            Me.gbRegionPenal.Name = "gbRegionPenal"
            Me.gbRegionPenal.Size = New System.Drawing.Size(341, 32)
            Me.gbRegionPenal.TabIndex = 8
            Me.gbRegionPenal.TabStop = False
            Me.gbRegionPenal.Visible = False
            '
            'cbbRegionIngreso
            '
            Me.cbbRegionIngreso._NoIndica = False
            Me.cbbRegionIngreso._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegionIngreso._Todos = False
            Me.cbbRegionIngreso._TodosMensaje = ""
            Me.cbbRegionIngreso._Visible_Add = False
            Me.cbbRegionIngreso._Visible_Buscar = False
            Me.cbbRegionIngreso._Visible_Eliminar = False
            Me.cbbRegionIngreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbRegionIngreso.CodigoPadre = -1
            Me.cbbRegionIngreso.ComboTipo = CType(24, Short)
            Me.cbbRegionIngreso.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegionIngreso.DropDownWidth = 325
            Me.cbbRegionIngreso.DropDownWidthAuto = False
            Me.cbbRegionIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegionIngreso.ListaIdsParaExcluir = Nothing
            Me.cbbRegionIngreso.Location = New System.Drawing.Point(99, 9)
            Me.cbbRegionIngreso.ModuloTratamiento = False
            Me.cbbRegionIngreso.Name = "cbbRegionIngreso"
            Me.cbbRegionIngreso.Parametro1 = -1
            Me.cbbRegionIngreso.Parametro2 = -1
            Me.cbbRegionIngreso.SelectedIndex = -1
            Me.cbbRegionIngreso.SelectedValue = 0
            Me.cbbRegionIngreso.Size = New System.Drawing.Size(101, 22)
            Me.cbbRegionIngreso.TabIndex = 1
            Me.cbbRegionIngreso.verToolTipItemSeleccionado = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(1, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(44, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Origen"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(52, 13)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(44, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Región:"
            '
            'cbbPenalIngreso
            '
            Me.cbbPenalIngreso._NoIndica = False
            Me.cbbPenalIngreso._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenalIngreso._Todos = False
            Me.cbbPenalIngreso._TodosMensaje = ""
            Me.cbbPenalIngreso._Visible_Add = False
            Me.cbbPenalIngreso._Visible_Buscar = False
            Me.cbbPenalIngreso._Visible_Eliminar = False
            Me.cbbPenalIngreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbPenalIngreso.CodigoPadre = -1
            Me.cbbPenalIngreso.ComboTipo = CType(23, Short)
            Me.cbbPenalIngreso.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenalIngreso.DropDownWidth = 325
            Me.cbbPenalIngreso.DropDownWidthAuto = True
            Me.cbbPenalIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPenalIngreso.ListaIdsParaExcluir = Nothing
            Me.cbbPenalIngreso.Location = New System.Drawing.Point(237, 9)
            Me.cbbPenalIngreso.ModuloTratamiento = False
            Me.cbbPenalIngreso.Name = "cbbPenalIngreso"
            Me.cbbPenalIngreso.Parametro1 = -1
            Me.cbbPenalIngreso.Parametro2 = -1
            Me.cbbPenalIngreso.SelectedIndex = -1
            Me.cbbPenalIngreso.SelectedValue = 0
            Me.cbbPenalIngreso.Size = New System.Drawing.Size(101, 22)
            Me.cbbPenalIngreso.TabIndex = 3
            Me.cbbPenalIngreso.verToolTipItemSeleccionado = False
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(200, 13)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(37, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Penal:"
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(341, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "DATOS DEL MOVIMIENTO FISICO"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dtpFechaMov
            '
            Me.dtpFechaMov.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpFechaMov.Location = New System.Drawing.Point(99, 52)
            Me.dtpFechaMov.Name = "dtpFechaMov"
            Me.dtpFechaMov.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaMov.TabIndex = 5
            Me.dtpFechaMov.Value = "/  /"
            Me.dtpFechaMov.ValueLong = CType(0, Long)
            '
            'lblfecha
            '
            Me.lblfecha.AutoSize = True
            Me.lblfecha.Location = New System.Drawing.Point(1, 56)
            Me.lblfecha.Name = "lblfecha"
            Me.lblfecha.Size = New System.Drawing.Size(83, 13)
            Me.lblfecha.TabIndex = 4
            Me.lblfecha.Text = "Fec. de ingreso:"
            '
            'lblMovMotivo
            '
            Me.lblMovMotivo.AutoSize = True
            Me.lblMovMotivo.Location = New System.Drawing.Point(1, 31)
            Me.lblMovMotivo.Name = "lblMovMotivo"
            Me.lblMovMotivo.Size = New System.Drawing.Size(95, 13)
            Me.lblMovMotivo.TabIndex = 2
            Me.lblMovMotivo.Text = "Motivo de Ingreso:"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.cbbMovMotivoTraslado)
            Me.Panel1.Controls.Add(Me.gbRegionPenal)
            Me.Panel1.Controls.Add(Me.txtMovimiento)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.dtpFechaMov)
            Me.Panel1.Controls.Add(Me.cbbMovMotivo)
            Me.Panel1.Controls.Add(Me.nudMinutos)
            Me.Panel1.Controls.Add(Me.nudHora)
            Me.Panel1.Controls.Add(Me.lblfecha)
            Me.Panel1.Controls.Add(Me.lblMovMotivo)
            Me.Panel1.Controls.Add(Me.lblMovTraslado)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(3, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(341, 129)
            Me.Panel1.TabIndex = 1
            '
            'cbbMovMotivoTraslado
            '
            Me.cbbMovMotivoTraslado._NoIndica = False
            Me.cbbMovMotivoTraslado._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbMovMotivoTraslado._Todos = False
            Me.cbbMovMotivoTraslado._TodosMensaje = ""
            Me.cbbMovMotivoTraslado._Visible_Add = False
            Me.cbbMovMotivoTraslado._Visible_Buscar = False
            Me.cbbMovMotivoTraslado._Visible_Eliminar = False
            Me.cbbMovMotivoTraslado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbMovMotivoTraslado.CodigoPadre = -1
            Me.cbbMovMotivoTraslado.ComboTipo = CType(52, Short)
            Me.cbbMovMotivoTraslado.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbMovMotivoTraslado.DropDownWidth = 325
            Me.cbbMovMotivoTraslado.DropDownWidthAuto = True
            Me.cbbMovMotivoTraslado.ListaIdsParaExcluir = Nothing
            Me.cbbMovMotivoTraslado.Location = New System.Drawing.Point(99, 76)
            Me.cbbMovMotivoTraslado.ModuloTratamiento = False
            Me.cbbMovMotivoTraslado.Name = "cbbMovMotivoTraslado"
            Me.cbbMovMotivoTraslado.Parametro1 = -1
            Me.cbbMovMotivoTraslado.Parametro2 = -1
            Me.cbbMovMotivoTraslado.SelectedIndex = -1
            Me.cbbMovMotivoTraslado.SelectedValue = 0
            Me.cbbMovMotivoTraslado.Size = New System.Drawing.Size(239, 22)
            Me.cbbMovMotivoTraslado.TabIndex = 10
            Me.cbbMovMotivoTraslado.verToolTipItemSeleccionado = False
            Me.cbbMovMotivoTraslado.Visible = False
            '
            'txtMovimiento
            '
            Me.txtMovimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtMovimiento.Location = New System.Drawing.Point(99, 3)
            Me.txtMovimiento.Name = "txtMovimiento"
            Me.txtMovimiento.ReadOnly = True
            Me.txtMovimiento.Size = New System.Drawing.Size(239, 20)
            Me.txtMovimiento.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(1, 6)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(64, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Movimiento:"
            '
            'cbbMovMotivo
            '
            Me.cbbMovMotivo._NoIndica = False
            Me.cbbMovMotivo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbMovMotivo._Todos = False
            Me.cbbMovMotivo._TodosMensaje = ""
            Me.cbbMovMotivo._Visible_Add = False
            Me.cbbMovMotivo._Visible_Buscar = False
            Me.cbbMovMotivo._Visible_Eliminar = False
            Me.cbbMovMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbMovMotivo.CodigoPadre = -1
            Me.cbbMovMotivo.ComboTipo = CType(52, Short)
            Me.cbbMovMotivo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbMovMotivo.DropDownWidth = 325
            Me.cbbMovMotivo.DropDownWidthAuto = True
            Me.cbbMovMotivo.ListaIdsParaExcluir = Nothing
            Me.cbbMovMotivo.Location = New System.Drawing.Point(99, 27)
            Me.cbbMovMotivo.ModuloTratamiento = False
            Me.cbbMovMotivo.Name = "cbbMovMotivo"
            Me.cbbMovMotivo.Parametro1 = -1
            Me.cbbMovMotivo.Parametro2 = -1
            Me.cbbMovMotivo.SelectedIndex = -1
            Me.cbbMovMotivo.SelectedValue = 0
            Me.cbbMovMotivo.Size = New System.Drawing.Size(239, 22)
            Me.cbbMovMotivo.TabIndex = 3
            Me.cbbMovMotivo.verToolTipItemSeleccionado = False
            '
            'nudMinutos
            '
            Me.nudMinutos._Formato = "0"
            Me.nudMinutos._Increment = 1
            Me.nudMinutos._Maximum = 100
            Me.nudMinutos._Minimum = 0
            Me.nudMinutos._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudMinutos._Value = 5
            Me.nudMinutos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.nudMinutos.Location = New System.Drawing.Point(229, 52)
            Me.nudMinutos.Name = "nudMinutos"
            Me.nudMinutos.Size = New System.Drawing.Size(34, 20)
            Me.nudMinutos.TabIndex = 7
            '
            'nudHora
            '
            Me.nudHora._Formato = "0"
            Me.nudHora._Increment = 1
            Me.nudHora._Maximum = 100
            Me.nudHora._Minimum = 0
            Me.nudHora._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudHora._Value = 5
            Me.nudHora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.nudHora.Location = New System.Drawing.Point(186, 52)
            Me.nudHora.Name = "nudHora"
            Me.nudHora.Size = New System.Drawing.Size(34, 20)
            Me.nudHora.TabIndex = 6
            '
            'lblMovTraslado
            '
            Me.lblMovTraslado.AutoSize = True
            Me.lblMovTraslado.Location = New System.Drawing.Point(1, 80)
            Me.lblMovTraslado.Name = "lblMovTraslado"
            Me.lblMovTraslado.Size = New System.Drawing.Size(101, 13)
            Me.lblMovTraslado.TabIndex = 9
            Me.lblMovTraslado.Text = "Motivo de Traslado:"
            Me.lblMovTraslado.Visible = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Panel1)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(347, 148)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "DATOS DEL MOVIMIENTO FISICO"
            '
            'uscMovimientoDetalle2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "uscMovimientoDetalle2"
            Me.Size = New System.Drawing.Size(347, 148)
            Me.gbRegionPenal.ResumeLayout(False)
            Me.gbRegionPenal.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblMovMotivo As System.Windows.Forms.Label
        Friend WithEvents dtpFechaMov As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblfecha As System.Windows.Forms.Label
        Friend WithEvents cbbMovMotivo As APPControls.uscComboParametrica
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents gbRegionPenal As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbRegionIngreso As APPControls.uscComboParametrica
        Friend WithEvents cbbPenalIngreso As APPControls.uscComboParametrica
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents nudMinutos As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents nudHora As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents txtMovimiento As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents cbbMovMotivoTraslado As uscComboParametrica
        Friend WithEvents lblMovTraslado As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents ToolTip1 As ToolTip
    End Class
End Namespace