Option Explicit On
Namespace Mantenimiento.Reporte.GrupoEgreso
    Public Class frmMantDetPopup
        Private objBss As Bussines.Mantenimiento.Registro.PadinCuadro13_Detalle = Nothing
        Private objEntCol As Entity.Mantenimiento.Registro.PadinCuadro13_DetalleCol = Nothing
        Private objEntEliminarCol As Entity.Mantenimiento.Registro.PadinCuadro13_DetalleCol = Nothing
#Region "Propiedades"
        Private Property TipoEgreso() As String
            Get
                Return Me.txtTipoEgreso.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtTipoEgreso.Text = value.ToUpper
            End Set
        End Property
        Private Property NombreTabla() As String
            Get
                Return Me.txtNombreTabla.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombreTabla.Text = value.ToUpper
            End Set
        End Property
        Private Property Nombre() As String
            Get
                Return Me.txtNombre.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value.ToUpper
            End Set
        End Property
        Private Property NombreDetalle() As String
            Get
                Return Me.txtNombreDet.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombreDet.Text = value.ToUpper
            End Set
        End Property
#End Region
#Region "Propiedades_Publicas"
        Public Property _VersionReporte As Short = -1
        Public Property _IDCuadro13 As Integer = -1
        Public Property _Nombre As String = ""
        Public Property _NombreDetalle As String = ""
        Public Property _TipoEgreso As String = ""
        Public Property _NombreTabla As String = ""
#End Region
#Region "Propiedades_Grilla"
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
#End Region
#Region "Listar"
        Private Sub ListarCabecera()

            If Me._IDCuadro13 < 1 Then
                Me.Close()
                Exit Sub
            End If

            Me.TipoEgreso = Me._TipoEgreso
            Me.NombreTabla = Me._NombreTabla
            Me.Nombre = Me._Nombre
            Me.NombreDetalle = Me._NombreDetalle

            ListarDetalle()

        End Sub

        Private Sub ListarDetalle()

            objEntCol = New Entity.Mantenimiento.Registro.PadinCuadro13_DetalleCol
            objBss = New Bussines.Mantenimiento.Registro.PadinCuadro13_Detalle

            Dim objEntFiltro As New Entity.Mantenimiento.Registro.PadinCuadro13_Detalle
            objEntFiltro.IDCuadro13 = Me._IDCuadro13

            objEntCol = objBss.Listar(objEntFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
            End With

            Me.lblGrillaCount.Text = Me.dgwGrilla.RowCount & ". Reg."
            objEntEliminarCol = New Entity.Mantenimiento.Registro.PadinCuadro13_DetalleCol

        End Sub
#End Region
#Region "Accion"

        Private Sub AGrabar()

            If MessageBox.Show("Desea grabar los datos",
             Legolas.Configuration.Aplication.MessageBox.MensajeTitulo,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            'eliminar los registros temporales
            For Each objFila As Entity.Mantenimiento.Registro.PadinCuadro13_Detalle In objEntEliminarCol
                objBss.Eliminar(objFila.Codigo)
            Next

            If objEntCol.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Lista vacia para guardar datos")
                Exit Sub
            End If

            Dim intValue As Integer = -1
            Dim strMensajeOut As String = ""
            Dim blnProcesoTodo As Boolean = True

            objBss = New Bussines.Mantenimiento.Registro.PadinCuadro13_Detalle

            For Each objFila As Entity.Mantenimiento.Registro.PadinCuadro13_Detalle In objEntCol
                intValue = objBss.Grabar(objFila, strMensajeOut)
                If intValue < 1 Then
                    blnProcesoTodo = False
                    MessageBox.Show(strMensajeOut, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit For
                End If
            Next

            If blnProcesoTodo = True Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region
#Region "Temporal"
        Private Sub AGrabarTemporal()

            If Me._VersionReporte < 3 Then
                MessageBox.Show("No se puede agregar registros en la version de reporte seleccionado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim frm As New Mantenimiento.Busqueda.frmMovimientoMotivoPopup
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Dim obj As New Entity.Mantenimiento.Registro.PadinCuadro13_Detalle
                With obj
                    .Codigo = -1
                    .IDCuadro13 = Me._IDCuadro13
                    .TipoMovimientoNombre = frm.GrillaTipoNombre
                    .IDMovimientoMotivo = frm.GrillaCodigo
                    .MovimientoMotivoNombre = frm.GrillaMotivoNombre
                End With

                Dim strMensajeOut As String = ""

                objBss = New Bussines.Mantenimiento.Registro.PadinCuadro13_Detalle
                If objBss.ValidarSiExistDelitoEspeEnOtroCuadro(obj.IDMovimientoMotivo, obj.MovimientoMotivoNombre, strMensajeOut) = False Then
                    MessageBox.Show(strMensajeOut, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If objEntCol.AddVal(obj) < 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Motivo ya se encuentra en la lista")
                End If

                ListarTemporal()
            End If
        End Sub
        Private Sub ListarTemporal()

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = Nothing
                .DataSource = objEntCol
            End With

            Me.lblGrillaCount.Text = Me.dgwGrilla.RowCount & ". Reg."

        End Sub

        Private Sub EliminarMasivoTemporal()

            If Me.dgwGrilla.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccionar un registro para eliminar.")
                Exit Sub
            End If

            Dim intIndex As New ArrayList
            Dim intConta As Integer = -1
            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows
                intConta += 1
                If fila.Cells("col_chk").Value = True Then
                    intIndex.Add(intConta)
                End If
            Next
            If intIndex.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccionar un registro para eliminar.")
                Exit Sub
            Else
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminarMultiple = Windows.Forms.DialogResult.Yes Then

                    For i As Integer = intIndex.Count - 1 To 0 Step -1
                        objEntEliminarCol.Add(objEntCol.PadinCuadro13_Detalle(intIndex.Item(i)))
                        objEntCol.RemoveID_(intIndex.Item(i))
                    Next
                    ListarTemporal()

                End If
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub Habilitar(ByVal vf As Boolean)

            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows
                fila.Cells("col_chk").Value = vf
            Next

        End Sub
        Private Sub ValoresxDefault()

            For i As Integer = 1 To dgwGrilla.Columns.Count - 1
                dgwGrilla.Columns(i).ReadOnly = True
            Next
        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub

        Private Sub frmUsuarioPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmUsuarioPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarCabecera()

        End Sub

        Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTodos.Click
            Me.Habilitar(Me.chkTodos.Checked)
        End Sub

        Private Sub dgwPenal_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

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

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

            EliminarMasivoTemporal()

        End Sub

        Private Sub btnAddPenal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPenal.Click

            AGrabarTemporal()

        End Sub

        Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(dgwGrilla)

        End Sub
    End Class
End Namespace


