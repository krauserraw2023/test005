Namespace Registro.Resoluciones.v5

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscResolucionesDetalle
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
            Me.gbRegionPenal = New System.Windows.Forms.GroupBox()
            Me.cbbPenalDestino = New APPControls.uscComboParametrica()
            Me.cbbRegionDestino = New APPControls.uscComboParametrica()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblMovMotivo = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.cbbMovMotivo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.cbbMovTipo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.gbRegionPenal.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbRegionPenal
            '
            Me.gbRegionPenal.Controls.Add(Me.cbbPenalDestino)
            Me.gbRegionPenal.Controls.Add(Me.cbbRegionDestino)
            Me.gbRegionPenal.Controls.Add(Me.Label4)
            Me.gbRegionPenal.Controls.Add(Me.Label9)
            Me.gbRegionPenal.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gbRegionPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRegionPenal.Location = New System.Drawing.Point(0, 58)
            Me.gbRegionPenal.Name = "gbRegionPenal"
            Me.gbRegionPenal.Size = New System.Drawing.Size(341, 50)
            Me.gbRegionPenal.TabIndex = 4
            Me.gbRegionPenal.TabStop = False
            Me.gbRegionPenal.Text = "Destino"
            '
            'cbbPenalDestino
            '
            Me.cbbPenalDestino._NoIndica = False
            Me.cbbPenalDestino._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenalDestino._Todos = False
            Me.cbbPenalDestino._TodosMensaje = ""
            Me.cbbPenalDestino._Visible_Add = False
            Me.cbbPenalDestino._Visible_Buscar = False
            Me.cbbPenalDestino._Visible_Eliminar = False
            Me.cbbPenalDestino.CodigoPadre = -1
            Me.cbbPenalDestino.ComboTipo = CType(23, Short)
            Me.cbbPenalDestino.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenalDestino.DropDownWidth = 259
            Me.cbbPenalDestino.DropDownWidthAuto = False
            Me.cbbPenalDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPenalDestino.ListaIdsParaExcluir = Nothing
            Me.cbbPenalDestino.Location = New System.Drawing.Point(200, 16)
            Me.cbbPenalDestino.ModuloTratamiento = False
            Me.cbbPenalDestino.Name = "cbbPenalDestino"
            Me.cbbPenalDestino.Parametro1 = -1
            Me.cbbPenalDestino.Parametro2 = -1
            Me.cbbPenalDestino.SelectedIndex = -1
            Me.cbbPenalDestino.SelectedValue = 0
            Me.cbbPenalDestino.Size = New System.Drawing.Size(135, 22)
            Me.cbbPenalDestino.TabIndex = 3
            Me.cbbPenalDestino.verToolTipItemSeleccionado = False
            '
            'cbbRegionDestino
            '
            Me.cbbRegionDestino._NoIndica = False
            Me.cbbRegionDestino._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegionDestino._Todos = False
            Me.cbbRegionDestino._TodosMensaje = ""
            Me.cbbRegionDestino._Visible_Add = False
            Me.cbbRegionDestino._Visible_Buscar = False
            Me.cbbRegionDestino._Visible_Eliminar = False
            Me.cbbRegionDestino.CodigoPadre = -1
            Me.cbbRegionDestino.ComboTipo = CType(24, Short)
            Me.cbbRegionDestino.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegionDestino.DropDownWidth = 259
            Me.cbbRegionDestino.DropDownWidthAuto = False
            Me.cbbRegionDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegionDestino.ListaIdsParaExcluir = Nothing
            Me.cbbRegionDestino.Location = New System.Drawing.Point(65, 16)
            Me.cbbRegionDestino.ModuloTratamiento = False
            Me.cbbRegionDestino.Name = "cbbRegionDestino"
            Me.cbbRegionDestino.Parametro1 = -1
            Me.cbbRegionDestino.Parametro2 = -1
            Me.cbbRegionDestino.SelectedIndex = -1
            Me.cbbRegionDestino.SelectedValue = 0
            Me.cbbRegionDestino.Size = New System.Drawing.Size(98, 22)
            Me.cbbRegionDestino.TabIndex = 1
            Me.cbbRegionDestino.verToolTipItemSeleccionado = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(3, 21)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(44, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Región:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(162, 21)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(37, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Penal:"
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(341, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "DATOS DEL INGRESO"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblMovMotivo
            '
            Me.lblMovMotivo.AutoSize = True
            Me.lblMovMotivo.Location = New System.Drawing.Point(2, 39)
            Me.lblMovMotivo.Name = "lblMovMotivo"
            Me.lblMovMotivo.Size = New System.Drawing.Size(59, 13)
            Me.lblMovMotivo.TabIndex = 2
            Me.lblMovMotivo.Text = "Modalidad:"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.cbbMovMotivo)
            Me.Panel1.Controls.Add(Me.cbbMovTipo)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.gbRegionPenal)
            Me.Panel1.Controls.Add(Me.lblMovMotivo)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(3, 34)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(341, 108)
            Me.Panel1.TabIndex = 1
            '
            'cbbMovMotivo
            '
            Me.cbbMovMotivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbMovMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMovMotivo.FormattingEnabled = True
            Me.cbbMovMotivo.Location = New System.Drawing.Point(65, 35)
            Me.cbbMovMotivo.Name = "cbbMovMotivo"
            Me.cbbMovMotivo.Size = New System.Drawing.Size(270, 21)
            Me.cbbMovMotivo.TabIndex = 3
            '
            'cbbMovTipo
            '
            Me.cbbMovTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMovTipo.FormattingEnabled = True
            Me.cbbMovTipo.Location = New System.Drawing.Point(65, 4)
            Me.cbbMovTipo.Name = "cbbMovTipo"
            Me.cbbMovTipo.Size = New System.Drawing.Size(270, 21)
            Me.cbbMovTipo.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(3, 6)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(64, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Movimiento:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Panel1)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(347, 145)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'uscResolucionesDetalle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "uscResolucionesDetalle"
            Me.Size = New System.Drawing.Size(347, 145)
            Me.gbRegionPenal.ResumeLayout(False)
            Me.gbRegionPenal.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblMovMotivo As System.Windows.Forms.Label
        'Friend WithEvents cbbMovMotivo As APPControls.uscComboParametrica
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents gbRegionPenal As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Protected WithEvents cbbMovTipo As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents cbbPenalDestino As APPControls.uscComboParametrica
        Friend WithEvents cbbRegionDestino As APPControls.uscComboParametrica
        Protected WithEvents cbbMovMotivo As Legolas.APPUIComponents.MyComboBox
    End Class
End Namespace