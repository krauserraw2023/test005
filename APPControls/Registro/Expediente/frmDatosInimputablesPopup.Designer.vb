Namespace Registro.Expediente
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmDatosInimputablesPopup
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosInimputablesPopup))
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.rbPosibleInim = New System.Windows.Forms.RadioButton()
            Me.rbInimputable = New System.Windows.Forms.RadioButton()
            Me.rbNoPertenece = New System.Windows.Forms.RadioButton()
            Me.gbInimputable = New System.Windows.Forms.GroupBox()
            Me.cbbEstablecimientomental = New APPControls.uscComboParametrica()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel1.SuspendLayout()
            Me.gbInimputable.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(166, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(95, 40)
            Me.btnAceptar.TabIndex = 98
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancelar)
            Me.Panel1.Controls.Add(Me.btnAceptar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 163)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(388, 45)
            Me.Panel1.TabIndex = 105
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancelar.Location = New System.Drawing.Point(266, 3)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(95, 40)
            Me.btnCancelar.TabIndex = 99
            Me.btnCancelar.Text = "&Cancelar"
            Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.Location = New System.Drawing.Point(14, 17)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(352, 13)
            Me.lblTitulo.TabIndex = 103
            Me.lblTitulo.Text = "Establecimiento de salud mental donde cumplirá la medida de seguridad *"
            '
            'rbPosibleInim
            '
            Me.rbPosibleInim.AutoSize = True
            Me.rbPosibleInim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPosibleInim.Location = New System.Drawing.Point(21, 42)
            Me.rbPosibleInim.Name = "rbPosibleInim"
            Me.rbPosibleInim.Size = New System.Drawing.Size(299, 17)
            Me.rbPosibleInim.TabIndex = 108
            Me.rbPosibleInim.Text = "INTERNACIÓN PREVENTIVA (POSIBLE INIMPUTABLE)"
            Me.rbPosibleInim.UseVisualStyleBackColor = True
            '
            'rbInimputable
            '
            Me.rbInimputable.AutoSize = True
            Me.rbInimputable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbInimputable.Location = New System.Drawing.Point(21, 19)
            Me.rbInimputable.Name = "rbInimputable"
            Me.rbInimputable.Size = New System.Drawing.Size(354, 17)
            Me.rbInimputable.TabIndex = 107
            Me.rbInimputable.Text = "POR MEDIDA DE SEGURIDAD DE INTERNACIÓN (INIMPUTABLE)"
            Me.rbInimputable.UseVisualStyleBackColor = True
            '
            'rbNoPertenece
            '
            Me.rbNoPertenece.AutoSize = True
            Me.rbNoPertenece.Checked = True
            Me.rbNoPertenece.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNoPertenece.Location = New System.Drawing.Point(21, 65)
            Me.rbNoPertenece.Name = "rbNoPertenece"
            Me.rbNoPertenece.Size = New System.Drawing.Size(109, 17)
            Me.rbNoPertenece.TabIndex = 109
            Me.rbNoPertenece.TabStop = True
            Me.rbNoPertenece.Text = "NO PERTENECE"
            Me.rbNoPertenece.UseVisualStyleBackColor = True
            '
            'gbInimputable
            '
            Me.gbInimputable.Controls.Add(Me.rbInimputable)
            Me.gbInimputable.Controls.Add(Me.rbNoPertenece)
            Me.gbInimputable.Controls.Add(Me.rbPosibleInim)
            Me.gbInimputable.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbInimputable.Location = New System.Drawing.Point(0, 0)
            Me.gbInimputable.Name = "gbInimputable"
            Me.gbInimputable.Size = New System.Drawing.Size(388, 93)
            Me.gbInimputable.TabIndex = 110
            Me.gbInimputable.TabStop = False
            Me.gbInimputable.Text = "Seleccione"
            '
            'cbbEstablecimientomental
            '
            Me.cbbEstablecimientomental._NoIndica = False
            Me.cbbEstablecimientomental._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbEstablecimientomental._Todos = False
            Me.cbbEstablecimientomental._TodosMensaje = ""
            Me.cbbEstablecimientomental._Visible_Add = False
            Me.cbbEstablecimientomental._Visible_Buscar = False
            Me.cbbEstablecimientomental._Visible_Eliminar = False
            Me.cbbEstablecimientomental.CodigoPadre = -1
            Me.cbbEstablecimientomental.ComboTipo = CType(25, Short)
            Me.cbbEstablecimientomental.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbEstablecimientomental.DropDownWidth = 300
            Me.cbbEstablecimientomental.DropDownWidthAuto = False
            Me.cbbEstablecimientomental.ListaIdsParaExcluir = Nothing
            Me.cbbEstablecimientomental.Location = New System.Drawing.Point(17, 35)
            Me.cbbEstablecimientomental.ModuloTratamiento = False
            Me.cbbEstablecimientomental.Name = "cbbEstablecimientomental"
            Me.cbbEstablecimientomental.Parametro1 = -1
            Me.cbbEstablecimientomental.Parametro2 = -1
            Me.cbbEstablecimientomental.SelectedIndex = -1
            Me.cbbEstablecimientomental.SelectedValue = 0
            Me.cbbEstablecimientomental.Size = New System.Drawing.Size(344, 22)
            Me.cbbEstablecimientomental.TabIndex = 106
            Me.cbbEstablecimientomental.verToolTipItemSeleccionado = False
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.cbbEstablecimientomental)
            Me.Panel2.Controls.Add(Me.lblTitulo)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(0, 93)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(388, 70)
            Me.Panel2.TabIndex = 111
            '
            'frmDatosInimputablesPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(388, 208)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.gbInimputable)
            Me.Controls.Add(Me.Panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmDatosInimputablesPopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Registro sobre..."
            Me.Panel1.ResumeLayout(False)
            Me.gbInimputable.ResumeLayout(False)
            Me.gbInimputable.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents btnAceptar As Button
        Friend WithEvents Panel1 As Panel
        Friend WithEvents lblTitulo As Label
        Friend WithEvents cbbEstablecimientomental As APPControls.uscComboParametrica
        Friend WithEvents btnCancelar As Button
        Friend WithEvents rbPosibleInim As RadioButton
        Friend WithEvents rbInimputable As RadioButton
        Friend WithEvents rbNoPertenece As RadioButton
        Friend WithEvents gbInimputable As GroupBox
        Friend WithEvents Panel2 As Panel
    End Class
End Namespace