Namespace Registro.Siscrico.Bandas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmInternoBandaPopupV2
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
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbbBandaMiembroTipo = New APPControls.uscComboParametrica()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtobservacion = New System.Windows.Forms.TextBox()
            Me.cbbBanda = New APPControls.uscComboParametrica()
            Me.cbbBandaTipo = New APPControls.uscComboParametrica()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.uscDocJudCrea = New APPControls.Registro.Documento.uscDocJudicial()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tpDocJudCrea = New System.Windows.Forms.TabPage()
            Me.tpDocNulidad = New System.Windows.Forms.TabPage()
            Me.uscDocJudAnula = New APPControls.Registro.Documento.uscDocJudicial()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox2.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tpDocJudCrea.SuspendLayout()
            Me.tpDocNulidad.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(375, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 91
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnGrabar.Location = New System.Drawing.Point(269, 3)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(94, 40)
            Me.btnGrabar.TabIndex = 90
            Me.btnGrabar.Text = "&Aceptar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.cbbBandaMiembroTipo)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.txtobservacion)
            Me.GroupBox2.Controls.Add(Me.cbbBanda)
            Me.GroupBox2.Controls.Add(Me.cbbBandaTipo)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(6, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(474, 143)
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Vínculo con Grupo Criminal"
            '
            'cbbBandaMiembroTipo
            '
            Me.cbbBandaMiembroTipo._NoIndica = False
            Me.cbbBandaMiembroTipo._Todos = False
            Me.cbbBandaMiembroTipo._TodosMensaje = ""
            Me.cbbBandaMiembroTipo._Visible_Add = False
            Me.cbbBandaMiembroTipo._Visible_Buscar = False
            Me.cbbBandaMiembroTipo._Visible_Eliminar = False
            Me.cbbBandaMiembroTipo.CodigoPadre = -1
            Me.cbbBandaMiembroTipo.ComboTipo = Type.Combo.ComboTipo.BandaMiembroTipo
            Me.cbbBandaMiembroTipo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbBandaMiembroTipo.DropDownWidth = 325
            Me.cbbBandaMiembroTipo.DropDownWidthAuto = True
            Me.cbbBandaMiembroTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbBandaMiembroTipo.Location = New System.Drawing.Point(159, 72)
            Me.cbbBandaMiembroTipo.Name = "cbbBandaMiembroTipo"
            Me.cbbBandaMiembroTipo.Parametro1 = -1
            Me.cbbBandaMiembroTipo.Parametro2 = -1
            Me.cbbBandaMiembroTipo.SelectedIndex = -1
            Me.cbbBandaMiembroTipo.SelectedValue = 0
            Me.cbbBandaMiembroTipo.Size = New System.Drawing.Size(306, 22)
            Me.cbbBandaMiembroTipo.TabIndex = 5
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(11, 103)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(73, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "Observación :"
            '
            'txtobservacion
            '
            Me.txtobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtobservacion.Location = New System.Drawing.Point(159, 100)
            Me.txtobservacion.MaxLength = 200
            Me.txtobservacion.Multiline = True
            Me.txtobservacion.Name = "txtobservacion"
            Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtobservacion.Size = New System.Drawing.Size(306, 40)
            Me.txtobservacion.TabIndex = 7
            '
            'cbbBanda
            '
            Me.cbbBanda._NoIndica = False
            Me.cbbBanda._Todos = False
            Me.cbbBanda._TodosMensaje = ""
            Me.cbbBanda._Visible_Add = False
            Me.cbbBanda._Visible_Buscar = False
            Me.cbbBanda._Visible_Eliminar = False
            Me.cbbBanda.CodigoPadre = -1
            Me.cbbBanda.ComboTipo = Type.Combo.ComboTipo.Banda
            Me.cbbBanda.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbBanda.DropDownWidth = 325
            Me.cbbBanda.DropDownWidthAuto = True
            Me.cbbBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbBanda.Location = New System.Drawing.Point(159, 48)
            Me.cbbBanda.Name = "cbbBanda"
            Me.cbbBanda.Parametro1 = -1
            Me.cbbBanda.Parametro2 = -1
            Me.cbbBanda.SelectedIndex = -1
            Me.cbbBanda.SelectedValue = 0
            Me.cbbBanda.Size = New System.Drawing.Size(306, 22)
            Me.cbbBanda.TabIndex = 3
            '
            'cbbBandaTipo
            '
            Me.cbbBandaTipo._NoIndica = False
            Me.cbbBandaTipo._Todos = False
            Me.cbbBandaTipo._TodosMensaje = ""
            Me.cbbBandaTipo._Visible_Add = False
            Me.cbbBandaTipo._Visible_Buscar = False
            Me.cbbBandaTipo._Visible_Eliminar = False
            Me.cbbBandaTipo.CodigoPadre = -1
            Me.cbbBandaTipo.ComboTipo = Type.Combo.ComboTipo.BandaTipo
            Me.cbbBandaTipo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbBandaTipo.DropDownWidth = 325
            Me.cbbBandaTipo.DropDownWidthAuto = False
            Me.cbbBandaTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbBandaTipo.Location = New System.Drawing.Point(159, 24)
            Me.cbbBandaTipo.Name = "cbbBandaTipo"
            Me.cbbBandaTipo.Parametro1 = -1
            Me.cbbBandaTipo.Parametro2 = -1
            Me.cbbBandaTipo.SelectedIndex = -1
            Me.cbbBandaTipo.SelectedValue = 0
            Me.cbbBandaTipo.Size = New System.Drawing.Size(306, 22)
            Me.cbbBandaTipo.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(10, 53)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(138, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Nombre de la Organización:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(10, 27)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(117, 13)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Tipo  de Organización :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(10, 76)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(92, 13)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Tipo de Miembro :"
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 325
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(325, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'uscDocJudCrea
            '
            Me.uscDocJudCrea._DocumentoJudicialID = -1
            Me.uscDocJudCrea._IngresoID = -1
            Me.uscDocJudCrea._InternoID = -1
            Me.uscDocJudCrea._Penal = CType(-1, Short)
            Me.uscDocJudCrea._RegionID = CType(-1, Short)
            Me.uscDocJudCrea._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ninguno
            Me.uscDocJudCrea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscDocJudCrea.Location = New System.Drawing.Point(3, 3)
            Me.uscDocJudCrea.Name = "uscDocJudCrea"
            Me.uscDocJudCrea.Size = New System.Drawing.Size(460, 250)
            Me.uscDocJudCrea.TabIndex = 0
            Me.uscDocJudCrea.TipoAutJudicial = 1
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tpDocJudCrea)
            Me.TabControl1.Controls.Add(Me.tpDocNulidad)
            Me.TabControl1.Location = New System.Drawing.Point(6, 147)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(474, 282)
            Me.TabControl1.TabIndex = 1
            '
            'tpDocJudCrea
            '
            Me.tpDocJudCrea.Controls.Add(Me.uscDocJudCrea)
            Me.tpDocJudCrea.Location = New System.Drawing.Point(4, 22)
            Me.tpDocJudCrea.Name = "tpDocJudCrea"
            Me.tpDocJudCrea.Padding = New System.Windows.Forms.Padding(3)
            Me.tpDocJudCrea.Size = New System.Drawing.Size(466, 256)
            Me.tpDocJudCrea.TabIndex = 0
            Me.tpDocJudCrea.Text = "Documento judicial de registro"
            Me.tpDocJudCrea.UseVisualStyleBackColor = True
            '
            'tpDocNulidad
            '
            Me.tpDocNulidad.Controls.Add(Me.uscDocJudAnula)
            Me.tpDocNulidad.Location = New System.Drawing.Point(4, 22)
            Me.tpDocNulidad.Name = "tpDocNulidad"
            Me.tpDocNulidad.Padding = New System.Windows.Forms.Padding(3)
            Me.tpDocNulidad.Size = New System.Drawing.Size(466, 256)
            Me.tpDocNulidad.TabIndex = 1
            Me.tpDocNulidad.Text = "Documento judicial de nulidad"
            Me.tpDocNulidad.UseVisualStyleBackColor = True
            '
            'uscDocJudAnula
            '
            Me.uscDocJudAnula._DocumentoJudicialID = -1
            Me.uscDocJudAnula._IngresoID = -1
            Me.uscDocJudAnula._InternoID = -1
            Me.uscDocJudAnula._Penal = CType(-1, Short)
            Me.uscDocJudAnula._RegionID = CType(-1, Short)
            Me.uscDocJudAnula._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ninguno
            Me.uscDocJudAnula.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscDocJudAnula.Location = New System.Drawing.Point(3, 3)
            Me.uscDocJudAnula.Name = "uscDocJudAnula"
            Me.uscDocJudAnula.Size = New System.Drawing.Size(460, 250)
            Me.uscDocJudAnula.TabIndex = 0
            Me.uscDocJudAnula.TipoAutJudicial = 1
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 475)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(482, 42)
            Me.UscAuditUser1.TabIndex = 93
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnGrabar)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 430)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(482, 45)
            Me.Panel1.TabIndex = 94
            '
            'frmInternoBandaPopupV2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(482, 517)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.UscAuditUser1)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.GroupBox2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmInternoBandaPopupV2"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Mantenimiento Interno y Grupos Criminales"
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.tpDocJudCrea.ResumeLayout(False)
            Me.tpDocNulidad.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents cbbBanda As APPControls.uscComboParametrica
        Friend WithEvents cbbBandaTipo As APPControls.uscComboParametrica
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbBandaMiembroTipo As APPControls.uscComboParametrica
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtobservacion As System.Windows.Forms.TextBox
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents uscDocJudCrea As APPControls.Registro.Documento.uscDocJudicial
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents tpDocJudCrea As System.Windows.Forms.TabPage
        Friend WithEvents tpDocNulidad As System.Windows.Forms.TabPage
        Friend WithEvents uscDocJudAnula As APPControls.Registro.Documento.uscDocJudicial
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
    End Class
End Namespace