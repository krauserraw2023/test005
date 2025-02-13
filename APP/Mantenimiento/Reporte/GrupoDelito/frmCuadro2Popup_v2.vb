Option Explicit On
Namespace Mantenimiento.Reporte
    Public Class frmCuadro2Popup_v2
        Private objBss As Bussines.Mantenimiento.Reportecuadro2 = Nothing
        Private objEnt As Entity.Mantenimiento.ReporteCuadro2 = Nothing
        Private objBssCuadroDelDet As Bussines.Mantenimiento.General.Reportecuadro2_Detalle = Nothing

        Private objEntDetEliCol As Entity.Mantenimiento.General.ReporteCuadro2_DetalleCol = Nothing
        Private objEntDetCol As Entity.Mantenimiento.General.ReporteCuadro2_DetalleCol = Nothing
#Region "Propiedades"


        Private Property DelGenerico() As String
            Get
                Return Me.txtDelGene.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDelGene.Text = value.ToUpper
            End Set
        End Property
        Private Property DelEspecifico() As String
            Get
                Return Me.txtDelEsp.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDelEsp.Text = value.ToUpper
            End Set
        End Property
        Private Property IDDelitoGenerico() As Integer = -1
#End Region
#Region "Propiedades_Publicas"
        Public Property _IDCuadroDelito() As Integer = -1
        Public Property _VersionReporte As Short = -1
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Listar"
        Private Sub ListarCabecera()

            If Me._IDCuadroDelito < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Mantenimiento.Reportecuadro2
            objEnt = New Entity.Mantenimiento.ReporteCuadro2

            objEnt = objBss.Listar(Me._IDCuadroDelito)

            With objEnt
                Me.IDDelitoGenerico = .GenericoID
                Me.DelGenerico = .Generico
                Me.DelEspecifico = .Especifico
            End With

            ListarDetalle()

        End Sub

        Private Sub ListarDetalle()

            objEntDetCol = New Entity.Mantenimiento.General.ReporteCuadro2_DetalleCol
            objBss = New Bussines.Mantenimiento.Reportecuadro2

            objBssCuadroDelDet = New Bussines.Mantenimiento.General.Reportecuadro2_Detalle
            Dim entObj As New Entity.Mantenimiento.General.ReporteCuadro2_Detalle
            entObj.IDCuadroDelito = Me._IDCuadroDelito
            objEntDetCol = objBssCuadroDelDet.Listar(entObj)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntDetCol
            End With

            Me.lblGrillaCount.Text = Me.dgwGrilla.RowCount & ". Reg."
            objEntDetEliCol = New Entity.Mantenimiento.General.ReporteCuadro2_DetalleCol

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
            For Each objEnt As Entity.Mantenimiento.General.ReporteCuadro2_Detalle In objEntDetEliCol
                objBssCuadroDelDet.Eliminar(objEnt.Codigo)
            Next

            If objEntDetCol.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Lista vacia para guardar datos")
                Exit Sub
            End If

            Dim intValue As Integer = -1
            Dim strMensajeOut As String = ""
            Dim blnProcesoTodo As Boolean = True
            objBssCuadroDelDet = New Bussines.Mantenimiento.General.Reportecuadro2_Detalle

            For Each objEntDet As Entity.Mantenimiento.General.ReporteCuadro2_Detalle In objEntDetCol
                intValue = objBssCuadroDelDet.Grabar(objEntDet, strMensajeOut)
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

            'If Me._VersionReporte < 3 Then
            '    MessageBox.Show("No se puede agregar registros en la version de reporte seleccionado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
            'End If

            Dim frm As New Mantenimiento.Busqueda.frmDelitoPopup
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Dim obj As New Entity.Mantenimiento.General.ReporteCuadro2_Detalle
                With obj
                    .Codigo = -1
                    .IDCuadroDelito = Me._IDCuadroDelito
                    .Articulo = frm.GrillaDelitoArticuloNombre
                    .IDDelitoEspecifico = frm.GrillaDelitoEspecificoID
                    .NombreEspecifico = frm.GrillaDelitoEspecificoNombre
                    .Generico = frm.GrillaDelitoGenericoNombre
                    .Capitulo = frm.GrillaDelitoCapitulo
                    .Seccion = frm.GrillaDelitoSeccion
                    .EstadoNombre = frm.GrillaDelitoEstadoNombre
                End With

                Dim strMensajeOut As String = ""
                objBssCuadroDelDet = New Bussines.Mantenimiento.General.Reportecuadro2_Detalle
                If objBssCuadroDelDet.ValidarSiExistDelitoEspeEnOtroCuadro(obj.IDDelitoEspecifico, obj.NombreEspecifico, Me._VersionReporte, strMensajeOut) = False Then
                    MessageBox.Show(strMensajeOut, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If objEntDetCol.AddVal(obj) < 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El delito ya se encuentra en la lista")
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
                .DataSource = objEntDetCol
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
                        objEntDetEliCol.Add(objEntDetCol.Reportecuadro2_Detalle(intIndex.Item(i)))
                        objEntDetCol.RemoveID_(intIndex.Item(i))
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

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

            EliminarMasivoTemporal()

        End Sub

        Private Sub btnAddPenal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPenal.Click

            AGrabarTemporal()

        End Sub

        Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
            Legolas.Components.ExportarGrillaExcel.Exportar(dgwGrilla)
        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then
                        .Cursor = Cursors.WaitCursor
                        objEntDetCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                        .Cursor = Cursors.Default
                    End If
                End With

            Catch ex As Exception

            End Try

        End Sub
    End Class
End Namespace


