Namespace Sistema
    Public Class frmBuscar
        Private objBss As Bussines.Sistema.Instalacion = Nothing
        Private objEntCol As Entity.Sistema.InstalacionCol = Nothing
#Region "Propiedades"
        Private Property Nombre() As String
            Get
                Return Me.txtNombre.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
        Private Property RegionID() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private intNumeroReg As Integer = 0
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private Property NumeroReg() As Integer
            Get
                Return intNumeroReg
            End Get
            Set(ByVal value As Integer)
                intNumeroReg = value
                ListarNumeroReg()
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub Combo()

            Me.cbbRegion._Todos = True
            Me.cbbRegion.LoadUsc()
        End Sub
#End Region
#Region "Listar"
        Private Sub ListarNumeroReg()

            Dim strValue As String = ""
            lblReg.Text = Me.NumeroReg & " Reg."

        End Sub
        Private Sub Buscar()

            objBss = New Bussines.Sistema.Instalacion
            'objEntCol = New Entity.Sistema.InstalacionCol

            objEntCol = objBss.Listar(-1, Me.Nombre, "", 0, Me.RegionID, False, False, "", "")

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.NumeroReg = .RowCount
            End With


        End Sub
#End Region
#Region "Accion"
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                objBss = New Bussines.Sistema.Instalacion
                Dim intValue As Integer = -1
                intValue = objBss.Eliminar(Me.GrillaCodigo)

                If intValue > 0 Then
                    Buscar()
                End If

            End If
        End Sub
        Private Sub AMantenimiento(ByVal Nuevo As Boolean)

            Dim frm As New Sistema.frmMant
            With frm

                If Nuevo = True Then
                    .Codigo = -1
                Else
                    .Codigo = Me.GrillaCodigo
                End If

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Buscar()
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        'Private Sub FormActualizarLicencia()

        '    Me.Cursor = Cursors.WaitCursor

        '    Dim frm As New Mantenimiento.frmActualizarWeb
        '    With frm
        '        ._ActualizarLicencia()                
        '    End With

        '    Me.Cursor = Cursors.Default

        'End Sub

        Private Sub ValoresxDefault()
            Combo()

            Me.col_fec.Tag = "fecha"
        End Sub
#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            AMantenimiento(True)

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            If Me.GrillaCodigo > 0 Then
                AMantenimiento(False)
            End If

        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
            AEliminar()
        End Sub

        Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized

        End Sub

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then
                        .Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                        .Cursor = Cursors.Default
                    End If
                End With

            Catch ex As Exception

            End Try

        End Sub


        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 Then
                AMantenimiento(False)
            End If
        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If
        End Sub

        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex
                    Case .Columns("col_fec").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                            'e.Value = DateTime.FromFileTime(e.Value).ToShortDateString
                        Else
                            e.Value = ""
                        End If
                End Select
            End With

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub

        

    End Class
End Namespace
