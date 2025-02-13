Namespace Tratamiento.TallerAsistencia.Buscar
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscarTallerPopud
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.lblregistro = New System.Windows.Forms.Label()
            Me.pnlOK = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.pnlDatos = New System.Windows.Forms.Panel()
            Me.gbrBuscarNumDoc = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtNombreTaller = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_tal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_tal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_tip_act = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_act = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_res_con_per = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_ges_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_grup_acce_raiz = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_grup_acce = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_grup_usu = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlPie.SuspendLayout()
            Me.pnlOK.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlDatos.SuspendLayout()
            Me.gbrBuscarNumDoc.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlPie
            '
            Me.pnlPie.BackColor = System.Drawing.Color.Transparent
            Me.pnlPie.Controls.Add(Me.lblregistro)
            Me.pnlPie.Controls.Add(Me.pnlOK)
            Me.pnlPie.Controls.Add(Me.pnlSalir)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 325)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(542, 50)
            Me.pnlPie.TabIndex = 1
            '
            'lblregistro
            '
            Me.lblregistro.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblregistro.Location = New System.Drawing.Point(0, 0)
            Me.lblregistro.Name = "lblregistro"
            Me.lblregistro.Size = New System.Drawing.Size(125, 50)
            Me.lblregistro.TabIndex = 0
            Me.lblregistro.Text = "Nº Reg."
            Me.lblregistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlOK
            '
            Me.pnlOK.Controls.Add(Me.btnOk)
            Me.pnlOK.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlOK.Location = New System.Drawing.Point(328, 0)
            Me.pnlOK.Name = "pnlOK"
            Me.pnlOK.Size = New System.Drawing.Size(108, 50)
            Me.pnlOK.TabIndex = 1
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(102, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(436, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(106, 50)
            Me.pnlSalir.TabIndex = 2
            '
            'btnSalir
            '
            Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(0, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(102, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Timer1
            '
            Me.Timer1.Interval = 1000
            '
            'pnlDetalle
            '
            Me.pnlDetalle.BackColor = System.Drawing.Color.Transparent
            Me.pnlDetalle.Controls.Add(Me.dgwGrilla)
            Me.pnlDetalle.Controls.Add(Me.pnlDatos)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(542, 325)
            Me.pnlDetalle.TabIndex = 0
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.col_id_tal, Me.col_nom_tal, Me.col_nom_tip_act, Me.col_nom_act, Me.col_res_con_per, Me.col_nom_ges_pro, Me.col_grup_acce_raiz, Me.col_grup_acce, Me.col_grup_usu})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 74)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(542, 251)
            Me.dgwGrilla.TabIndex = 1
            '
            'pnlDatos
            '
            Me.pnlDatos.BackColor = System.Drawing.Color.Transparent
            Me.pnlDatos.Controls.Add(Me.gbrBuscarNumDoc)
            Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDatos.Location = New System.Drawing.Point(0, 0)
            Me.pnlDatos.Name = "pnlDatos"
            Me.pnlDatos.Size = New System.Drawing.Size(542, 74)
            Me.pnlDatos.TabIndex = 0
            '
            'gbrBuscarNumDoc
            '
            Me.gbrBuscarNumDoc.BackColor = System.Drawing.Color.Transparent
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label3)
            Me.gbrBuscarNumDoc.Controls.Add(Me.txtNombreTaller)
            Me.gbrBuscarNumDoc.Controls.Add(Me.btnBuscar)
            Me.gbrBuscarNumDoc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbrBuscarNumDoc.Location = New System.Drawing.Point(0, 0)
            Me.gbrBuscarNumDoc.Name = "gbrBuscarNumDoc"
            Me.gbrBuscarNumDoc.Size = New System.Drawing.Size(542, 74)
            Me.gbrBuscarNumDoc.TabIndex = 0
            Me.gbrBuscarNumDoc.TabStop = False
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(7, 34)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(125, 19)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Actividad Laboral :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtNombreTaller
            '
            Me.txtNombreTaller._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombreTaller._BloquearPaste = False
            Me.txtNombreTaller._SeleccionarTodo = True
            Me.txtNombreTaller.BackColor = System.Drawing.Color.White
            Me.txtNombreTaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreTaller.Location = New System.Drawing.Point(137, 30)
            Me.txtNombreTaller.MaxLength = 50
            Me.txtNombreTaller.Name = "txtNombreTaller"
            Me.txtNombreTaller.Size = New System.Drawing.Size(350, 24)
            Me.txtNombreTaller.TabIndex = 1
            Me.txtNombreTaller.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombreTaller.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'btnBuscar
            '
            Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Image = Global.SIPPOPE.My.Resources.Resources.view
            Me.btnBuscar.Location = New System.Drawing.Point(490, 18)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(46, 46)
            Me.btnBuscar.TabIndex = 6
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'col_num
            '
            Me.col_num.HeaderText = "Nº"
            Me.col_num.Name = "col_num"
            Me.col_num.ReadOnly = True
            Me.col_num.Width = 30
            '
            'col_id_tal
            '
            Me.col_id_tal.DataPropertyName = "Codigo"
            Me.col_id_tal.DividerWidth = 1
            Me.col_id_tal.HeaderText = "Codigo"
            Me.col_id_tal.Name = "col_id_tal"
            Me.col_id_tal.ReadOnly = True
            Me.col_id_tal.Visible = False
            Me.col_id_tal.Width = 75
            '
            'col_nom_tal
            '
            Me.col_nom_tal.DataPropertyName = "NombreTaller"
            Me.col_nom_tal.HeaderText = "Nombre del Taller"
            Me.col_nom_tal.Name = "col_nom_tal"
            Me.col_nom_tal.ReadOnly = True
            Me.col_nom_tal.Width = 300
            '
            'col_nom_tip_act
            '
            Me.col_nom_tip_act.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_nom_tip_act.DataPropertyName = "ActividadNombre"
            Me.col_nom_tip_act.HeaderText = "Tipo de Actividad"
            Me.col_nom_tip_act.Name = "col_nom_tip_act"
            Me.col_nom_tip_act.ReadOnly = True
            '
            'col_nom_act
            '
            Me.col_nom_act.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_nom_act.DataPropertyName = "ActividadNombre"
            Me.col_nom_act.HeaderText = "Actividad"
            Me.col_nom_act.Name = "col_nom_act"
            Me.col_nom_act.ReadOnly = True
            Me.col_nom_act.Visible = False
            '
            'col_res_con_per
            '
            Me.col_res_con_per.DataPropertyName = "NombreRespControlLab"
            Me.col_res_con_per.HeaderText = "Resp. Control Personal"
            Me.col_res_con_per.Name = "col_res_con_per"
            Me.col_res_con_per.ReadOnly = True
            Me.col_res_con_per.Visible = False
            '
            'col_nom_ges_pro
            '
            Me.col_nom_ges_pro.DataPropertyName = "NombreGestorProd"
            Me.col_nom_ges_pro.HeaderText = "Gestor de Produccion"
            Me.col_nom_ges_pro.Name = "col_nom_ges_pro"
            Me.col_nom_ges_pro.ReadOnly = True
            Me.col_nom_ges_pro.Visible = False
            '
            'col_grup_acce_raiz
            '
            Me.col_grup_acce_raiz.DataPropertyName = "GrupoUsuarioRaiz"
            Me.col_grup_acce_raiz.HeaderText = "col_grup_acce_raiz"
            Me.col_grup_acce_raiz.Name = "col_grup_acce_raiz"
            Me.col_grup_acce_raiz.ReadOnly = True
            Me.col_grup_acce_raiz.Visible = False
            '
            'col_grup_acce
            '
            Me.col_grup_acce.DataPropertyName = "GrupoAcceso"
            Me.col_grup_acce.HeaderText = "col_grup_acce"
            Me.col_grup_acce.Name = "col_grup_acce"
            Me.col_grup_acce.ReadOnly = True
            Me.col_grup_acce.Visible = False
            '
            'col_grup_usu
            '
            Me.col_grup_usu.DataPropertyName = "GrupoUsuario"
            Me.col_grup_usu.HeaderText = "col_grup_usu"
            Me.col_grup_usu.Name = "col_grup_usu"
            Me.col_grup_usu.ReadOnly = True
            Me.col_grup_usu.Visible = False
            '
            'frmBuscarTallerPopud
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(542, 375)
            Me.Controls.Add(Me.pnlDetalle)
            Me.Controls.Add(Me.pnlPie)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmBuscarTallerPopud"
            Me.ShowInTaskbar = False
            Me.Text = "Buscar Taller..."
            Me.pnlPie.ResumeLayout(False)
            Me.pnlOK.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlDatos.ResumeLayout(False)
            Me.gbrBuscarNumDoc.ResumeLayout(False)
            Me.gbrBuscarNumDoc.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents pnlDatos As System.Windows.Forms.Panel
        Friend WithEvents gbrBuscarNumDoc As System.Windows.Forms.GroupBox
        Friend WithEvents pnlOK As System.Windows.Forms.Panel
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNombreTaller As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblregistro As System.Windows.Forms.Label
        Friend WithEvents col_num As DataGridViewTextBoxColumn
        Friend WithEvents col_id_tal As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_tal As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_tip_act As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_act As DataGridViewTextBoxColumn
        Friend WithEvents col_res_con_per As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_ges_pro As DataGridViewTextBoxColumn
        Friend WithEvents col_grup_acce_raiz As DataGridViewTextBoxColumn
        Friend WithEvents col_grup_acce As DataGridViewTextBoxColumn
        Friend WithEvents col_grup_usu As DataGridViewTextBoxColumn
    End Class
End Namespace

