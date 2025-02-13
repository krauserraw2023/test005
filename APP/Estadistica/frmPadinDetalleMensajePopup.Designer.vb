Namespace Estadistica


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmPadinDetalleMensajePopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPadinDetalleMensajePopup))
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnDetalleInterno = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.dgvMensaje = New System.Windows.Forms.DataGridView()
            Me.col_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            CType(Me.dgvMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotones)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(292, 286)
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnDetalleInterno)
            Me.PnlBotones.Controls.Add(Me.btnSalir)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 244)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(292, 42)
            Me.PnlBotones.TabIndex = 3
            '
            'btnDetalleInterno
            '
            Me.btnDetalleInterno.Image = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnDetalleInterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnDetalleInterno.Location = New System.Drawing.Point(115, 2)
            Me.btnDetalleInterno.Name = "btnDetalleInterno"
            Me.btnDetalleInterno.Size = New System.Drawing.Size(81, 39)
            Me.btnDetalleInterno.TabIndex = 92
            Me.btnDetalleInterno.Text = "Ver Interno"
            Me.btnDetalleInterno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnDetalleInterno.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(210, 2)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(75, 40)
            Me.btnSalir.TabIndex = 91
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'dgvMensaje
            '
            Me.dgvMensaje.AllowUserToAddRows = False
            Me.dgvMensaje.AllowUserToResizeColumns = False
            Me.dgvMensaje.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvMensaje.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvMensaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMensaje.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nro, Me.col_nombre})
            Me.dgvMensaje.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvMensaje.Location = New System.Drawing.Point(0, 0)
            Me.dgvMensaje.MultiSelect = False
            Me.dgvMensaje.Name = "dgvMensaje"
            Me.dgvMensaje.ReadOnly = True
            Me.dgvMensaje.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvMensaje.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgvMensaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMensaje.Size = New System.Drawing.Size(292, 189)
            Me.dgvMensaje.TabIndex = 4
            '
            'col_nro
            '
            Me.col_nro.HeaderText = "Nº"
            Me.col_nro.Name = "col_nro"
            Me.col_nro.ReadOnly = True
            Me.col_nro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_nro.Width = 25
            '
            'col_nombre
            '
            Me.col_nombre.HeaderText = "Mensaje"
            Me.col_nombre.Name = "col_nombre"
            Me.col_nombre.ReadOnly = True
            Me.col_nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_nombre.Width = 300
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(292, 55)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      El interno seleccionado, presenta los " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      siguientes campos vacios :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(292, 55)
            Me.Panel1.TabIndex = 92
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.dgvMensaje)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(0, 55)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(292, 189)
            Me.Panel2.TabIndex = 93
            '
            'frmPadinDetalleMensajePopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(292, 286)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "frmPadinDetalleMensajePopup"
            Me.Text = "Observacion PADIN."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            CType(Me.dgvMensaje, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgvMensaje As System.Windows.Forms.DataGridView
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents col_nro As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnDetalleInterno As System.Windows.Forms.Button

    End Class
End Namespace