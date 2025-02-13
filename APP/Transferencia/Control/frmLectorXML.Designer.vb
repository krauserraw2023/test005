Namespace Transferencia.Control
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmLectorXML
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLectorXML))
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tabDetalleXML = New System.Windows.Forms.TabPage()
            Me.dgwVisorTabla = New Legolas.APPUIComponents.myDatagridView()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.cboTablas = New System.Windows.Forms.ComboBox()
            Me.lblTotalRegistros = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.tabVisorXML = New System.Windows.Forms.TabPage()
            Me.txtVisorXML = New System.Windows.Forms.RichTextBox()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.cmdFormatearXML = New System.Windows.Forms.Button()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.txtCodigoActivaTrf = New System.Windows.Forms.RichTextBox()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.lblTotalTablas = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblNombreArchivo = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tabDetalleXML.SuspendLayout()
            CType(Me.dgwVisorTabla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.tabVisorXML.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.TabControl1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(873, 474)
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tabDetalleXML)
            Me.TabControl1.Controls.Add(Me.tabVisorXML)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 31)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(873, 395)
            Me.TabControl1.TabIndex = 1
            '
            'tabDetalleXML
            '
            Me.tabDetalleXML.Controls.Add(Me.dgwVisorTabla)
            Me.tabDetalleXML.Controls.Add(Me.Panel1)
            Me.tabDetalleXML.Location = New System.Drawing.Point(4, 22)
            Me.tabDetalleXML.Name = "tabDetalleXML"
            Me.tabDetalleXML.Padding = New System.Windows.Forms.Padding(3)
            Me.tabDetalleXML.Size = New System.Drawing.Size(865, 369)
            Me.tabDetalleXML.TabIndex = 0
            Me.tabDetalleXML.Text = "Detalle Tablas"
            Me.tabDetalleXML.UseVisualStyleBackColor = True
            '
            'dgwVisorTabla
            '
            Me.dgwVisorTabla.AllowUserToAddRows = False
            Me.dgwVisorTabla.AllowUserToDeleteRows = False
            Me.dgwVisorTabla.AllowUserToResizeRows = False
            Me.dgwVisorTabla.BackgroundColor = System.Drawing.Color.White
            Me.dgwVisorTabla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwVisorTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwVisorTabla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwVisorTabla.Location = New System.Drawing.Point(3, 30)
            Me.dgwVisorTabla.Name = "dgwVisorTabla"
            Me.dgwVisorTabla.RowHeadersVisible = False
            Me.dgwVisorTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwVisorTabla.Size = New System.Drawing.Size(859, 336)
            Me.dgwVisorTabla.TabIndex = 2
            Me.dgwVisorTabla.VisibleCampos = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.cboTablas)
            Me.Panel1.Controls.Add(Me.lblTotalRegistros)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(3, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(859, 27)
            Me.Panel1.TabIndex = 0
            '
            'cboTablas
            '
            Me.cboTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboTablas.FormattingEnabled = True
            Me.cboTablas.Location = New System.Drawing.Point(2, 3)
            Me.cboTablas.Name = "cboTablas"
            Me.cboTablas.Size = New System.Drawing.Size(458, 21)
            Me.cboTablas.TabIndex = 3
            '
            'lblTotalRegistros
            '
            Me.lblTotalRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblTotalRegistros.Location = New System.Drawing.Point(559, 7)
            Me.lblTotalRegistros.Name = "lblTotalRegistros"
            Me.lblTotalRegistros.Size = New System.Drawing.Size(64, 15)
            Me.lblTotalRegistros.TabIndex = 0
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(462, 8)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(92, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Total registros:"
            '
            'tabVisorXML
            '
            Me.tabVisorXML.Controls.Add(Me.txtVisorXML)
            Me.tabVisorXML.Controls.Add(Me.Panel4)
            Me.tabVisorXML.Location = New System.Drawing.Point(4, 22)
            Me.tabVisorXML.Name = "tabVisorXML"
            Me.tabVisorXML.Padding = New System.Windows.Forms.Padding(3)
            Me.tabVisorXML.Size = New System.Drawing.Size(865, 369)
            Me.tabVisorXML.TabIndex = 1
            Me.tabVisorXML.Text = "Visor XML plano"
            Me.tabVisorXML.UseVisualStyleBackColor = True
            '
            'txtVisorXML
            '
            Me.txtVisorXML.BackColor = System.Drawing.Color.White
            Me.txtVisorXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtVisorXML.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtVisorXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtVisorXML.ForeColor = System.Drawing.Color.Black
            Me.txtVisorXML.Location = New System.Drawing.Point(3, 28)
            Me.txtVisorXML.Name = "txtVisorXML"
            Me.txtVisorXML.ReadOnly = True
            Me.txtVisorXML.Size = New System.Drawing.Size(859, 338)
            Me.txtVisorXML.TabIndex = 2
            Me.txtVisorXML.Text = ""
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.cmdFormatearXML)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Location = New System.Drawing.Point(3, 3)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(859, 25)
            Me.Panel4.TabIndex = 3
            '
            'cmdFormatearXML
            '
            Me.cmdFormatearXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmdFormatearXML.Enabled = False
            Me.cmdFormatearXML.Location = New System.Drawing.Point(736, 1)
            Me.cmdFormatearXML.Name = "cmdFormatearXML"
            Me.cmdFormatearXML.Size = New System.Drawing.Size(119, 21)
            Me.cmdFormatearXML.TabIndex = 0
            Me.cmdFormatearXML.Text = "Mostrar texto XML"
            Me.cmdFormatearXML.UseVisualStyleBackColor = True
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.txtCodigoActivaTrf)
            Me.TabPage1.Controls.Add(Me.Panel5)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(865, 369)
            Me.TabPage1.TabIndex = 2
            Me.TabPage1.Text = "Script activación de transferencia"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'txtCodigoActivaTrf
            '
            Me.txtCodigoActivaTrf.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtCodigoActivaTrf.Location = New System.Drawing.Point(3, 36)
            Me.txtCodigoActivaTrf.Name = "txtCodigoActivaTrf"
            Me.txtCodigoActivaTrf.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
            Me.txtCodigoActivaTrf.Size = New System.Drawing.Size(859, 330)
            Me.txtCodigoActivaTrf.TabIndex = 1
            Me.txtCodigoActivaTrf.Text = ""
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.Button1)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel5.Location = New System.Drawing.Point(3, 3)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(859, 33)
            Me.Panel5.TabIndex = 0
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(753, 6)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(101, 21)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Generar"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnExportar)
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 426)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(873, 48)
            Me.Panel2.TabIndex = 76
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(674, 5)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(94, 40)
            Me.btnExportar.TabIndex = 99
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(771, 5)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(95, 40)
            Me.btnSalir.TabIndex = 98
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.lblTotalTablas)
            Me.Panel3.Controls.Add(Me.Label5)
            Me.Panel3.Controls.Add(Me.lblNombreArchivo)
            Me.Panel3.Controls.Add(Me.Label1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(873, 31)
            Me.Panel3.TabIndex = 2
            '
            'lblTotalTablas
            '
            Me.lblTotalTablas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblTotalTablas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalTablas.Location = New System.Drawing.Point(389, 7)
            Me.lblTotalTablas.Name = "lblTotalTablas"
            Me.lblTotalTablas.Size = New System.Drawing.Size(78, 16)
            Me.lblTotalTablas.TabIndex = 1
            Me.lblTotalTablas.Text = "0"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(305, 9)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(69, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Total Tablas:"
            '
            'lblNombreArchivo
            '
            Me.lblNombreArchivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNombreArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreArchivo.Location = New System.Drawing.Point(71, 7)
            Me.lblNombreArchivo.Name = "lblNombreArchivo"
            Me.lblNombreArchivo.Size = New System.Drawing.Size(228, 16)
            Me.lblNombreArchivo.TabIndex = 1
            Me.lblNombreArchivo.Text = "."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(11, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(46, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Archivo:"
            '
            'frmLectorXML
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(873, 474)
            Me.Name = "frmLectorXML"
            Me.Text = "Lector de archivos de transferencia XML"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tabDetalleXML.ResumeLayout(False)
            CType(Me.dgwVisorTabla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.tabVisorXML.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents tabDetalleXML As System.Windows.Forms.TabPage
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents tabVisorXML As System.Windows.Forms.TabPage
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents lblTotalTablas As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblNombreArchivo As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblTotalRegistros As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtVisorXML As System.Windows.Forms.RichTextBox
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents cmdFormatearXML As System.Windows.Forms.Button
        Friend WithEvents cboTablas As System.Windows.Forms.ComboBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents dgwVisorTabla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents txtCodigoActivaTrf As System.Windows.Forms.RichTextBox
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Button1 As System.Windows.Forms.Button
    End Class
End Namespace