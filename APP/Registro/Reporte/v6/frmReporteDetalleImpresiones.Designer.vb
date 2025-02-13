Namespace Registro.Reporte.V6
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReporteDetalleImpresiones
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteDetalleImpresiones))
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.dgwDetallePrint = New System.Windows.Forms.DataGridView()
            Me.col_num_ord = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_print = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_usu = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.dgwDetallePrint, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgwDetallePrint)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel5)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(536, 272)
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.lblTotal)
            Me.Panel5.Controls.Add(Me.Label1)
            Me.Panel5.Controls.Add(Me.Panel1)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(0, 227)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(536, 45)
            Me.Panel5.TabIndex = 101
            '
            'lblTotal
            '
            Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblTotal.Location = New System.Drawing.Point(107, 13)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(49, 18)
            Me.lblTotal.TabIndex = 101
            Me.lblTotal.Text = "..."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(9, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(93, 13)
            Me.Label1.TabIndex = 100
            Me.Label1.Text = "Total Impresiones:"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnSalir)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(440, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(96, 45)
            Me.Panel1.TabIndex = 99
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(1, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(93, 39)
            Me.btnSalir.TabIndex = 1
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'dgwDetallePrint
            '
            Me.dgwDetallePrint.AllowUserToAddRows = False
            Me.dgwDetallePrint.AllowUserToDeleteRows = False
            Me.dgwDetallePrint.AllowUserToResizeColumns = False
            Me.dgwDetallePrint.AllowUserToResizeRows = False
            Me.dgwDetallePrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDetallePrint.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num_ord, Me.col_fec_print, Me.col_usu})
            Me.dgwDetallePrint.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDetallePrint.Location = New System.Drawing.Point(0, 0)
            Me.dgwDetallePrint.MultiSelect = False
            Me.dgwDetallePrint.Name = "dgwDetallePrint"
            Me.dgwDetallePrint.ReadOnly = True
            Me.dgwDetallePrint.RowHeadersVisible = False
            Me.dgwDetallePrint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDetallePrint.Size = New System.Drawing.Size(536, 227)
            Me.dgwDetallePrint.TabIndex = 102
            '
            'col_num_ord
            '
            Me.col_num_ord.DataPropertyName = "NumOrden"
            Me.col_num_ord.HeaderText = "N°"
            Me.col_num_ord.Name = "col_num_ord"
            Me.col_num_ord.ReadOnly = True
            Me.col_num_ord.Width = 30
            '
            'col_fec_print
            '
            Me.col_fec_print.DataPropertyName = "FechaEmisionStr"
            Me.col_fec_print.HeaderText = "Fecha Impresión"
            Me.col_fec_print.Name = "col_fec_print"
            Me.col_fec_print.ReadOnly = True
            Me.col_fec_print.Width = 200
            '
            'col_usu
            '
            Me.col_usu.DataPropertyName = "LoginUsuario"
            Me.col_usu.HeaderText = "Usuario"
            Me.col_usu.Name = "col_usu"
            Me.col_usu.ReadOnly = True
            Me.col_usu.Width = 300
            '
            'frmReporteDetalleImpresiones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(536, 272)
            Me.Name = "frmReporteDetalleImpresiones"
            Me.Text = "Detalle de impresiones"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            CType(Me.dgwDetallePrint, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwDetallePrint As System.Windows.Forms.DataGridView
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents col_num_ord As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_print As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_usu As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace