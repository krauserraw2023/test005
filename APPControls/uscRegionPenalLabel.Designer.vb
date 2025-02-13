<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscRegionPenalLabel
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
        Me.lbl_penal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_region = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlRegion = New System.Windows.Forms.Panel()
        Me.pnlPenal = New System.Windows.Forms.Panel()
        Me.pnlRegion.SuspendLayout()
        Me.pnlPenal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_penal
        '
        Me.lbl_penal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_penal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_penal.Location = New System.Drawing.Point(70, 0)
        Me.lbl_penal.Name = "lbl_penal"
        Me.lbl_penal.Size = New System.Drawing.Size(221, 21)
        Me.lbl_penal.TabIndex = 8
        Me.lbl_penal.Text = "[Penal]"
        Me.lbl_penal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Penal :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_region
        '
        Me.lbl_region.BackColor = System.Drawing.Color.Transparent
        Me.lbl_region.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_region.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_region.Location = New System.Drawing.Point(69, 0)
        Me.lbl_region.Name = "lbl_region"
        Me.lbl_region.Size = New System.Drawing.Size(160, 21)
        Me.lbl_region.TabIndex = 5
        Me.lbl_region.Text = "[Region]"
        Me.lbl_region.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Región :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlRegion
        '
        Me.pnlRegion.BackColor = System.Drawing.Color.Transparent
        Me.pnlRegion.Controls.Add(Me.lbl_region)
        Me.pnlRegion.Controls.Add(Me.Label1)
        Me.pnlRegion.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRegion.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegion.Name = "pnlRegion"
        Me.pnlRegion.Size = New System.Drawing.Size(229, 21)
        Me.pnlRegion.TabIndex = 9
        '
        'pnlPenal
        '
        Me.pnlPenal.BackColor = System.Drawing.Color.Transparent
        Me.pnlPenal.Controls.Add(Me.lbl_penal)
        Me.pnlPenal.Controls.Add(Me.Label4)
        Me.pnlPenal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPenal.Location = New System.Drawing.Point(229, 0)
        Me.pnlPenal.Name = "pnlPenal"
        Me.pnlPenal.Size = New System.Drawing.Size(291, 21)
        Me.pnlPenal.TabIndex = 10
        '
        'uscRegionPenalLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnlPenal)
        Me.Controls.Add(Me.pnlRegion)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "uscRegionPenalLabel"
        Me.Size = New System.Drawing.Size(520, 21)
        Me.pnlRegion.ResumeLayout(False)
        Me.pnlPenal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_penal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_region As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlRegion As System.Windows.Forms.Panel
    Friend WithEvents pnlPenal As System.Windows.Forms.Panel

End Class
