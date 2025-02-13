Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmEstadoNoEjecutadoPopup
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoNoEjecutadoPopup))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.rbOpcion2 = New System.Windows.Forms.RadioButton()
            Me.rbOpcion1 = New System.Windows.Forms.RadioButton()
            Me.gbInimputable = New System.Windows.Forms.GroupBox()
            Me.rbOpcion4 = New System.Windows.Forms.RadioButton()
            Me.txtObsEstadoEjecucion = New System.Windows.Forms.TextBox()
            Me.rbPendienteEjec = New System.Windows.Forms.RadioButton()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.gbInimputable.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.Controls.Add(Me.btnAceptar)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 230)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(355, 51)
            Me.Panel1.TabIndex = 105
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(119, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(101, 42)
            Me.btnAceptar.TabIndex = 5
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(223, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(101, 42)
            Me.btnCancel.TabIndex = 6
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'rbOpcion2
            '
            Me.rbOpcion2.AutoSize = True
            Me.rbOpcion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbOpcion2.Location = New System.Drawing.Point(18, 42)
            Me.rbOpcion2.Name = "rbOpcion2"
            Me.rbOpcion2.Size = New System.Drawing.Size(106, 17)
            Me.rbOpcion2.TabIndex = 1
            Me.rbOpcion2.Text = "Por orden judicial"
            Me.rbOpcion2.UseVisualStyleBackColor = True
            '
            'rbOpcion1
            '
            Me.rbOpcion1.AutoSize = True
            Me.rbOpcion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbOpcion1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.rbOpcion1.Location = New System.Drawing.Point(18, 19)
            Me.rbOpcion1.Name = "rbOpcion1"
            Me.rbOpcion1.Size = New System.Drawing.Size(327, 17)
            Me.rbOpcion1.TabIndex = 0
            Me.rbOpcion1.Text = "Por no ser recibido en hospital de salud mental por falta de cupo"
            Me.rbOpcion1.UseVisualStyleBackColor = True
            '
            'gbInimputable
            '
            Me.gbInimputable.BackColor = System.Drawing.Color.White
            Me.gbInimputable.Controls.Add(Me.rbOpcion4)
            Me.gbInimputable.Controls.Add(Me.txtObsEstadoEjecucion)
            Me.gbInimputable.Controls.Add(Me.rbPendienteEjec)
            Me.gbInimputable.Controls.Add(Me.rbOpcion1)
            Me.gbInimputable.Controls.Add(Me.rbOpcion2)
            Me.gbInimputable.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbInimputable.Location = New System.Drawing.Point(0, 40)
            Me.gbInimputable.Name = "gbInimputable"
            Me.gbInimputable.Size = New System.Drawing.Size(355, 190)
            Me.gbInimputable.TabIndex = 110
            Me.gbInimputable.TabStop = False
            Me.gbInimputable.Text = "Seleccione"
            '
            'rbOpcion4
            '
            Me.rbOpcion4.AutoSize = True
            Me.rbOpcion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbOpcion4.Location = New System.Drawing.Point(18, 63)
            Me.rbOpcion4.Name = "rbOpcion4"
            Me.rbOpcion4.Size = New System.Drawing.Size(50, 17)
            Me.rbOpcion4.TabIndex = 2
            Me.rbOpcion4.Text = "Otros"
            Me.rbOpcion4.UseVisualStyleBackColor = True
            '
            'txtObsEstadoEjecucion
            '
            Me.txtObsEstadoEjecucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObsEstadoEjecucion.Location = New System.Drawing.Point(18, 112)
            Me.txtObsEstadoEjecucion.Multiline = True
            Me.txtObsEstadoEjecucion.Name = "txtObsEstadoEjecucion"
            Me.txtObsEstadoEjecucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObsEstadoEjecucion.Size = New System.Drawing.Size(325, 71)
            Me.txtObsEstadoEjecucion.TabIndex = 4
            '
            'rbPendienteEjec
            '
            Me.rbPendienteEjec.AutoSize = True
            Me.rbPendienteEjec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPendienteEjec.Location = New System.Drawing.Point(18, 85)
            Me.rbPendienteEjec.Name = "rbPendienteEjec"
            Me.rbPendienteEjec.Size = New System.Drawing.Size(303, 17)
            Me.rbPendienteEjec.TabIndex = 3
            Me.rbPendienteEjec.Text = "Pendiente de ejecución, por tener otros procesos vigentes."
            Me.rbPendienteEjec.UseVisualStyleBackColor = True
            '
            'lblTitulo
            '
            Me.lblTitulo.BackColor = System.Drawing.Color.White
            Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.lblTitulo.Size = New System.Drawing.Size(355, 40)
            Me.lblTitulo.TabIndex = 111
            Me.lblTitulo.Text = "Estado de Ejecucion: PENDIENTE DE EJECUCIÓN"
            Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmEstadoNoEjecutadoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(355, 281)
            Me.Controls.Add(Me.gbInimputable)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.lblTitulo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmEstadoNoEjecutadoPopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Estado de Ejecución"
            Me.Panel1.ResumeLayout(False)
            Me.gbInimputable.ResumeLayout(False)
            Me.gbInimputable.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As Panel
        Friend WithEvents rbOpcion2 As RadioButton
        Friend WithEvents rbOpcion1 As RadioButton
        Friend WithEvents gbInimputable As GroupBox
        Friend WithEvents lblTitulo As Label
        Friend WithEvents btnAceptar As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents rbPendienteEjec As RadioButton
        Friend WithEvents txtObsEstadoEjecucion As TextBox
        Friend WithEvents rbOpcion4 As RadioButton
    End Class

End Namespace