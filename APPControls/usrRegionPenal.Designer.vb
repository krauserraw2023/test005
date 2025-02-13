<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrRegionPenal
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlRegion = New System.Windows.Forms.Panel()
        Me.cbbRegion = New APPControls.uscComboParametrica()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.pnpenal = New System.Windows.Forms.Panel()
        Me.cbbPenal = New APPControls.uscComboParametrica()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlRegion.SuspendLayout()
        Me.pnpenal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRegion
        '
        Me.pnlRegion.Controls.Add(Me.cbbRegion)
        Me.pnlRegion.Controls.Add(Me.lblRegion)
        Me.pnlRegion.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRegion.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegion.Name = "pnlRegion"
        Me.pnlRegion.Size = New System.Drawing.Size(224, 22)
        Me.pnlRegion.TabIndex = 0
        '
        'cbbRegion
        '
        Me.cbbRegion._NoIndica = False
        Me.cbbRegion._Todos = False
        Me.cbbRegion._TodosMensaje = ""
        Me.cbbRegion._Visible_Add = False
        Me.cbbRegion._Visible_Buscar = False
        Me.cbbRegion._Visible_Eliminar = False
        Me.cbbRegion.CodigoPadre = -1
        Me.cbbRegion.ComboTipo = Type.Combo.ComboTipo.RegionUsuario
        Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
        Me.cbbRegion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbbRegion.DropDownWidth = 177
        Me.cbbRegion.DropDownWidthAuto = False
        Me.cbbRegion.Location = New System.Drawing.Point(47, 0)
        Me.cbbRegion.Name = "cbbRegion"
        Me.cbbRegion.Parametro1 = -1
        Me.cbbRegion.Parametro2 = -1
        Me.cbbRegion.SelectedIndex = -1
        Me.cbbRegion.SelectedValue = 0
        Me.cbbRegion.Size = New System.Drawing.Size(177, 22)
        Me.cbbRegion.TabIndex = 56
        '
        'lblRegion
        '
        Me.lblRegion.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblRegion.Location = New System.Drawing.Point(0, 0)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(47, 22)
        Me.lblRegion.TabIndex = 0
        Me.lblRegion.Text = "Región :"
        Me.lblRegion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnpenal
        '
        Me.pnpenal.Controls.Add(Me.cbbPenal)
        Me.pnpenal.Controls.Add(Me.Label3)
        Me.pnpenal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnpenal.Location = New System.Drawing.Point(224, 0)
        Me.pnpenal.Name = "pnpenal"
        Me.pnpenal.Size = New System.Drawing.Size(241, 22)
        Me.pnpenal.TabIndex = 1
        '
        'cbbPenal
        '
        Me.cbbPenal._NoIndica = False
        Me.cbbPenal._Todos = False
        Me.cbbPenal._TodosMensaje = ""
        Me.cbbPenal._Visible_Add = False
        Me.cbbPenal._Visible_Buscar = False
        Me.cbbPenal._Visible_Eliminar = False
        Me.cbbPenal.CodigoPadre = -1
        Me.cbbPenal.ComboTipo = Type.Combo.ComboTipo.PenalUsuario
        Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
        Me.cbbPenal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbbPenal.DropDownWidth = 201
        Me.cbbPenal.DropDownWidthAuto = False
        Me.cbbPenal.Location = New System.Drawing.Point(40, 0)
        Me.cbbPenal.Name = "cbbPenal"
        Me.cbbPenal.Parametro1 = -1
        Me.cbbPenal.Parametro2 = -1
        Me.cbbPenal.SelectedIndex = -1
        Me.cbbPenal.SelectedValue = 0
        Me.cbbPenal.Size = New System.Drawing.Size(201, 22)
        Me.cbbPenal.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Penal :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usrRegionPenal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnpenal)
        Me.Controls.Add(Me.pnlRegion)
        Me.Name = "usrRegionPenal"
        Me.Size = New System.Drawing.Size(465, 22)
        Me.pnlRegion.ResumeLayout(False)
        Me.pnpenal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlRegion As System.Windows.Forms.Panel
    Friend WithEvents pnpenal As System.Windows.Forms.Panel
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbbRegion As APPControls.uscComboParametrica
    Friend WithEvents cbbPenal As APPControls.uscComboParametrica

End Class
