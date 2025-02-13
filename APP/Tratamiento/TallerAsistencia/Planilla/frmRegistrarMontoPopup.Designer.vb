Namespace Tratamiento.TallerAsistencia.Planilla
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmRegistromonto
        Inherits Legolas.APPUIComponents.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.gbrBuscarNumDoc = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.pnlPie.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.gbrBuscarNumDoc.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlPie
            '
            Me.pnlPie.BackColor = System.Drawing.Color.Transparent
            Me.pnlPie.Controls.Add(Me.btnSalir)
            Me.pnlPie.Controls.Add(Me.btnOk)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 75)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(259, 35)
            Me.pnlPie.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Location = New System.Drawing.Point(173, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(81, 28)
            Me.btnSalir.TabIndex = 1
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Location = New System.Drawing.Point(89, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(81, 28)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Timer1
            '
            Me.Timer1.Interval = 1000
            '
            'pnlDetalle
            '
            Me.pnlDetalle.BackColor = System.Drawing.Color.Transparent
            Me.pnlDetalle.Controls.Add(Me.gbrBuscarNumDoc)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(259, 75)
            Me.pnlDetalle.TabIndex = 0
            '
            'gbrBuscarNumDoc
            '
            Me.gbrBuscarNumDoc.BackColor = System.Drawing.Color.Transparent
            Me.gbrBuscarNumDoc.Controls.Add(Me.txtTotal)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label1)
            Me.gbrBuscarNumDoc.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbrBuscarNumDoc.Location = New System.Drawing.Point(0, 0)
            Me.gbrBuscarNumDoc.Name = "gbrBuscarNumDoc"
            Me.gbrBuscarNumDoc.Size = New System.Drawing.Size(259, 103)
            Me.gbrBuscarNumDoc.TabIndex = 0
            Me.gbrBuscarNumDoc.TabStop = False
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(11, 28)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(54, 21)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Monto :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtTotal
            '
            Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.Location = New System.Drawing.Point(71, 19)
            Me.txtTotal.MaxLength = 7
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(179, 38)
            Me.txtTotal.TabIndex = 1
            Me.txtTotal.Text = "0.00"
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'frmRegistromonto
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(259, 110)
            Me.Controls.Add(Me.pnlDetalle)
            Me.Controls.Add(Me.pnlPie)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmRegistromonto"
            Me.ShowInTaskbar = False
            Me.Text = "Ingresar Monto..."
            Me.pnlPie.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            Me.gbrBuscarNumDoc.ResumeLayout(False)
            Me.gbrBuscarNumDoc.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents gbrBuscarNumDoc As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtTotal As TextBox
    End Class
End Namespace

