Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscPeriodoDetencion
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
            Me.gbPrisionpreventiva = New System.Windows.Forms.GroupBox()
            Me.cbbUnidad = New System.Windows.Forms.ComboBox()
            Me.dtpFechFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblCantidad = New System.Windows.Forms.Label()
            Me.txtCant = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblFecfin = New System.Windows.Forms.Label()
            Me.lblUnidad = New System.Windows.Forms.Label()
            Me.lblFecini = New System.Windows.Forms.Label()
            Me.dtpFechIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.pnlPrincipal = New System.Windows.Forms.Panel()
            Me.gbPrisionpreventiva.SuspendLayout()
            Me.pnlPrincipal.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbPrisionpreventiva
            '
            Me.gbPrisionpreventiva.Controls.Add(Me.cbbUnidad)
            Me.gbPrisionpreventiva.Controls.Add(Me.dtpFechFin)
            Me.gbPrisionpreventiva.Controls.Add(Me.lblCantidad)
            Me.gbPrisionpreventiva.Controls.Add(Me.txtCant)
            Me.gbPrisionpreventiva.Controls.Add(Me.lblFecfin)
            Me.gbPrisionpreventiva.Controls.Add(Me.lblUnidad)
            Me.gbPrisionpreventiva.Controls.Add(Me.lblFecini)
            Me.gbPrisionpreventiva.Controls.Add(Me.dtpFechIni)
            Me.gbPrisionpreventiva.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbPrisionpreventiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbPrisionpreventiva.Location = New System.Drawing.Point(0, 0)
            Me.gbPrisionpreventiva.Name = "gbPrisionpreventiva"
            Me.gbPrisionpreventiva.Size = New System.Drawing.Size(236, 136)
            Me.gbPrisionpreventiva.TabIndex = 0
            Me.gbPrisionpreventiva.TabStop = False
            Me.gbPrisionpreventiva.Text = "Tipo de ampliación"
            '
            'cbbUnidad
            '
            Me.cbbUnidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbUnidad.FormattingEnabled = True
            Me.cbbUnidad.Items.AddRange(New Object() {"", "DIA", "MES", "AÑO"})
            Me.cbbUnidad.Location = New System.Drawing.Point(128, 103)
            Me.cbbUnidad.Name = "cbbUnidad"
            Me.cbbUnidad.Size = New System.Drawing.Size(40, 21)
            Me.cbbUnidad.TabIndex = 3
            '
            'dtpFechFin
            '
            Me.dtpFechFin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpFechFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechFin.Location = New System.Drawing.Point(128, 53)
            Me.dtpFechFin.Name = "dtpFechFin"
            Me.dtpFechFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechFin.TabIndex = 7
            Me.dtpFechFin.Value = "/  /"
            Me.dtpFechFin.ValueLong = CType(0, Long)
            '
            'lblCantidad
            '
            Me.lblCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblCantidad.AutoSize = True
            Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidad.Location = New System.Drawing.Point(39, 80)
            Me.lblCantidad.Name = "lblCantidad"
            Me.lblCantidad.Size = New System.Drawing.Size(42, 13)
            Me.lblCantidad.TabIndex = 0
            Me.lblCantidad.Text = "Tiempo"
            '
            'txtCant
            '
            Me.txtCant._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCant._BloquearPaste = False
            Me.txtCant._SeleccionarTodo = False
            Me.txtCant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCant.Location = New System.Drawing.Point(128, 78)
            Me.txtCant.MaxLength = 4
            Me.txtCant.Name = "txtCant"
            Me.txtCant.Size = New System.Drawing.Size(40, 20)
            Me.txtCant.TabIndex = 1
            Me.txtCant.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCant.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'lblFecfin
            '
            Me.lblFecfin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblFecfin.AutoSize = True
            Me.lblFecfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecfin.Location = New System.Drawing.Point(39, 57)
            Me.lblFecfin.Name = "lblFecfin"
            Me.lblFecfin.Size = New System.Drawing.Size(41, 13)
            Me.lblFecfin.TabIndex = 6
            Me.lblFecfin.Text = "F. Final"
            '
            'lblUnidad
            '
            Me.lblUnidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblUnidad.AutoSize = True
            Me.lblUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnidad.Location = New System.Drawing.Point(39, 105)
            Me.lblUnidad.Name = "lblUnidad"
            Me.lblUnidad.Size = New System.Drawing.Size(41, 13)
            Me.lblUnidad.TabIndex = 2
            Me.lblUnidad.Text = "Unidad"
            '
            'lblFecini
            '
            Me.lblFecini.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblFecini.AutoSize = True
            Me.lblFecini.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecini.Location = New System.Drawing.Point(39, 33)
            Me.lblFecini.Name = "lblFecini"
            Me.lblFecini.Size = New System.Drawing.Size(46, 13)
            Me.lblFecini.TabIndex = 4
            Me.lblFecini.Text = "F. Inicial"
            '
            'dtpFechIni
            '
            Me.dtpFechIni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpFechIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechIni.Location = New System.Drawing.Point(128, 28)
            Me.dtpFechIni.Name = "dtpFechIni"
            Me.dtpFechIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechIni.TabIndex = 5
            Me.dtpFechIni.Value = "/  /"
            Me.dtpFechIni.ValueLong = CType(0, Long)
            '
            'pnlPrincipal
            '
            Me.pnlPrincipal.Controls.Add(Me.gbPrisionpreventiva)
            Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
            Me.pnlPrincipal.Name = "pnlPrincipal"
            Me.pnlPrincipal.Size = New System.Drawing.Size(236, 136)
            Me.pnlPrincipal.TabIndex = 0
            '
            'uscPeriodoDetencion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlPrincipal)
            Me.Name = "uscPeriodoDetencion"
            Me.Size = New System.Drawing.Size(236, 136)
            Me.gbPrisionpreventiva.ResumeLayout(False)
            Me.gbPrisionpreventiva.PerformLayout()
            Me.pnlPrincipal.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents gbPrisionpreventiva As GroupBox
        Friend WithEvents cbbUnidad As ComboBox
        Friend WithEvents txtCant As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblFecfin As Label
        Friend WithEvents lblCantidad As Label
        Friend WithEvents lblUnidad As Label
        Friend WithEvents lblFecini As Label
        Friend WithEvents dtpFechFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpFechIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents pnlPrincipal As Panel
    End Class
End Namespace