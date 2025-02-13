Imports System.Net.Security
Imports System.Web.Services.Description
Imports Bussines.Clasificacion.Documento
Imports Bussines.Clasificacion.InternoClasificacion
Imports Type.Enumeracion.Clasificacion

Namespace Registro.Carceleta.Clasificacion.Documento
    Public Class frmBuscarDocClasificacion
        Private intIndiceFilaSel As Integer = -1 'variable para capturar la fila seleccionada

#Region "Propiedades buscar"
        Private Property RegionID() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Public ReadOnly Property RegionNombre() As String
            Get
                Return Me.cbbRegion.Text
            End Get
        End Property
        Private Property PenalID() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Public ReadOnly Property PenalNombre() As String
            Get
                Return Me.cbbPenal.Text.Trim
            End Get
        End Property
        Private Property FechaIni() As Long
            Get
                Return dtpFechaIni.ValueLong
            End Get
            Set(value As Long)
                dtpFechaIni.ValueLong = value
            End Set
        End Property
        Private Property FechaFin As Long
            Get
                Return dtpFechaFin.ValueLong
            End Get
            Set(value As Long)
                dtpFechaFin.ValueLong = value
            End Set
        End Property
        Private Property NumeroDoc As String
            Get
                Return txtNumDoc.Text
            End Get
            Set(value As String)
                txtNumDoc.Text = value
            End Set
        End Property
        Private Property EstadoTramiteDoc As Integer
            Get
                Try
                    Return Me.cboEstado.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cboEstado.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Propiedades_Documento"
        Private Property DocumentoClasifRegionId() As Integer = -1
        Private Property DocumentoClasifRegionNombre() As String = ""
        Private Property DocumentoClasifPenalId() As Integer = -1
        Private Property DocumentoClasifPenalNombre() As String = ""
#End Region
#Region "Propiedades_GrillaDocumento"
        Private ReadOnly Property GrillaCodigo As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = Me.dgwDocumentos.Item("col_cod", dgwDocumentos.CurrentRow.Index).Value '.SelectedRows(0).Cells("col_cod").Value
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaEstadoTramite As enmEstadoTramiteDoc
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwDocumentos
                        intValue = .SelectedRows(0).Cells("col_est_tram_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaNumDoc As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwDocumentos
                        intValue = .SelectedRows(0).Cells("col_num_doc").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFechaEmision As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwDocumentos
                        intValue = .SelectedRows(0).Cells("col_fec_emi").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboRegion()

            If Configuracion.Licencia.Codigo = 1 Then 'sede central

                With Me.cbbRegion
                    .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                    ._Todos = True
                    .Parametro1 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With

                Me.RegionID = 3 'region lima
            End If

        End Sub

        Private Sub ComboPenal()

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                With Me.cbbPenal
                    ._Todos = True
                    .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                    .CodigoPadre = Me.RegionID
                    .Parametro1 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With
                Me.PenalID = 35 'carcelta de lima 
            End If
        End Sub

#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            ComboRegion()
            ComboPenal()

            With Me.cboEstado
                ._Todos = True
                .LoadUsc()
            End With

            Me.cbbRegion.Enabled = False
            Me.cbbPenal.Enabled = False

        End Sub

        Private Sub FRM_Mantenimiento(ByVal Nuevo As Boolean)
            Dim frm As New frmMantDocClasificacion

            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                    ._RegionId = Me.DocumentoClasifRegionId
                    ._RegionNombre = Me.DocumentoClasifRegionNombre
                    ._PenalId = Me.DocumentoClasifPenalId
                    ._PenalNombre = Me.DocumentoClasifPenalNombre
                Else
                    If Me.GrillaCodigo < 0 Then Exit Sub
                    ._Codigo = Me.GrillaCodigo
                    intIndiceFilaSel = dgwDocumentos.CurrentRow.Index
                End If
                ._FormEscritura = Me._FormEscritura
                If frm.ShowDialog = vbOK Then
                    If Nuevo = False Then
                        Try
                            dgwDocumentos.Rows(intIndiceFilaSel).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                            dgwDocumentos.CurrentCell = dgwDocumentos.Rows(intIndiceFilaSel).Cells("col_anio")
                        Catch ex As Exception
                        End Try
                    Else
                        Dim col = (New DocClasificacion_BL).ListarUltimosRegistros
                        col.Sort("Codigo")

                        dgwDocumentos.DataSource = col

                        lblCantReg.Text = dgwDocumentos.Rows.Count & " Reg."
                        If dgwDocumentos.Rows.Count <= 0 Then dgvDetalle.DataSource = Nothing

                        ColumnasVisible()
                        CambiarColorTextoAnulado()

                        Try
                            dgwDocumentos.Rows(dgwDocumentos.Rows.Count - 1).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                            dgwDocumentos.CurrentCell = dgwDocumentos.Rows(dgwDocumentos.Rows.Count - 1).Cells("col_anio")
                        Catch ex As Exception
                        End Try
                        CargarDetalleDocumento()
                    End If
                End If
            End With

        End Sub

        Private Sub CambiarColorTextoAnulado()
            If dgwDocumentos.Rows.Count = 0 Then Exit Sub

            For i As Integer = 0 To Me.dgwDocumentos.Rows.Count - 1
                Select Case dgwDocumentos.Item("col_est_tram_id", i).Value
                    Case enmEstadoTramiteDoc.Anulado 'cambiar color texto si es registro anulado
                        dgwDocumentos.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(207, 148, 149)
                    Case enmEstadoTramiteDoc.Pendiente
                        dgwDocumentos.Rows(i).Cells("col_est").Style.BackColor = Color.FromArgb(255, 214, 140)
                    Case Else
                        dgwDocumentos.Rows(i).DefaultCellStyle.BackColor = Color.White
                End Select
            Next
        End Sub

        Private Sub UsuarioPermisos()
            Me.pnlBotonGrabar.Visible = Me._FormEscritura
            Me.pnlBotonReporte.Visible = Me._FormReporte
            Me.pnlEliminar.Visible = Me._FormEliminar
        End Sub
#End Region
#Region "Listar"
        Private Sub ColumnasVisible()
            Me.col_pen_nom.Visible = If(Me.PenalID > 0, False, True)
        End Sub

        Private Sub ListarDocumentos()
            Dim ent As New Entity.Clasificacion.Documento.DocClasificacion With {
                        .FechaEmisionDesde = Me.FechaIni,
                        .FechaEmisionHasta = Me.FechaFin,
                        .NumeroDoc = Me.NumeroDoc,
                        .PenalId = Me.PenalID,
                        .RegionId = Me.RegionID,
                        .EstadoDocId = Me.EstadoTramiteDoc
                    }

            dgwDocumentos.DataSource = (New DocClasificacion_BL).Listar(ent)

            lblCantReg.Text = dgwDocumentos.Rows.Count & " Reg."
            If dgwDocumentos.Rows.Count <= 0 Then dgvDetalle.DataSource = Nothing
            ColumnasVisible()
            CambiarColorTextoAnulado()
        End Sub

        Private Sub ListarDocumentosInicial()


            Dim ent As New Entity.Clasificacion.Documento.DocClasificacion
            ent.FechaEmisionDesde = CDate(Now.Day & "/" & Now.Month & "/" & Now.Year).ToFileTime
            ent.FechaEmisionHasta = CDate(Now.Day & "/" & Now.Month & "/" & Now.Year).ToFileTime
            ent.NumeroDoc = Me.NumeroDoc
            ent.PenalId = Me.PenalID
            ent.RegionId = Me.RegionID
            ent.EstadoDocId = Me.EstadoTramiteDoc

            Dim lst1 = (New DocClasificacion_BL).Listar(ent) 'lista para registros de hoy

            ent = New Entity.Clasificacion.Documento.DocClasificacion
            ent.FechaEmisionDesde = 0
            ent.FechaEmisionHasta = CDate(Now.Day & "/" & Now.Month & "/" & Now.Year).AddDays(-1).ToFileTime 'hasta un dia antes
            ent.NumeroDoc = ""
            ent.PenalId = Me.PenalID
            ent.RegionId = Me.RegionID
            ent.EstadoDocId = 1 'pendientes

            Dim lst2 = (New DocClasificacion_BL).Listar(ent) 'lista por estado ('lista para todos los pendientes excepto las de hoy)

            For Each obj As Entity.Clasificacion.Documento.DocClasificacion In lst1
                lst2.Add(obj)
            Next

            dgwDocumentos.DataSource = lst2

            lblCantReg.Text = dgwDocumentos.Rows.Count & " Reg."
            If dgwDocumentos.Rows.Count <= 0 Then dgvDetalle.DataSource = Nothing

            ColumnasVisible()
            CambiarColorTextoAnulado()

        End Sub

        Private Sub ListarDetalle()
            Dim det As New Entity.Clasificacion.Documento.DetDocClasificacion With {
                                .DocClasificacionId = GrillaCodigo
                            }

            Dim entCol = (New DetDocClasificacion_BL).Listar(det)
            entCol.Sort("PenalDestinoNombre")
            dgvDetalle.DataSource = entCol
            lblReg.Text = entCol.Count & " Reg."
        End Sub

        Private Sub CargarDetalleDocumento()
            ListarDetalle()
            Select Case Me.GrillaEstadoTramite
                Case enmEstadoTramiteDoc.Anulado
                    btnEliminar.Text = "Anular"
                    btnEliminar.Enabled = False
                    btnEliminar.Image = SIPPOPE.My.Resources.Resources.anular2
                Case enmEstadoTramiteDoc.Derivado
                    btnEliminar.Text = "Anular"
                    btnEliminar.Enabled = True
                    btnEliminar.Image = SIPPOPE.My.Resources.Resources.anular2
                Case Else
                    btnEliminar.Text = "Eliminar"
                    btnEliminar.Enabled = True
                    btnEliminar.Image = SIPPOPE.My.Resources.Resources.delete_32
            End Select
        End Sub
#End Region
#Region "Accion"
        Private Sub btnGenMov_Click(sender As Object, e As EventArgs) Handles btnGenMov.Click
            If Me.GrillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el documento en la grilla superior.")
                Exit Sub
            End If

            'verificar si al menos un interno tiene movimiento de salida de carceleta que referencia al documento
            Dim EntMov As New Entity.Registro.InternoMovimiento With {
                    .DocumJudicialNum = Me.GrillaNumDoc,
                    ._PenalID = 35,
                    .MovimientoGrupoID = 2,'egreso
                    .MovimientoTipoID = 8'conduccion por clasificacion
                }

            Dim objEnt = (New Bussines.Registro.InternoMovimiento).Listar_LM_MovRefenciaOficioClasificacion(EntMov)

            If Not objEnt Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Information("Esta acción ya no es necesaria para el oficio seleccionado, los internos ya se encuentran en las badejas de entrada de los penales.")
                Exit Sub
            End If

            Dim ent = (New DocClasificacion_BL).Listar(Me.GrillaCodigo)
            If ent.EstadoDocId <> enmEstadoTramiteDoc.Derivado Then
                Legolas.Configuration.Aplication.MessageBox.Information("Opción válida solo para oficios derivados.")
                Exit Sub
            End If

            If GenerarMovTrasladoSalida_ETL(ent) Then
                Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria, se enviaron todos los internos del oficio a los penales.")
            Else
                Legolas.Configuration.Aplication.MessageBox.Information("No se pudo enviar los internos del oficio a las bandejas de los penales, por favor intentelo más tarde.")
            End If
        End Sub

        Private Function DerivarDocumento() As Boolean

            If Me.GrillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el documento en la grilla superior.")
                Return False
            End If

            Dim outSms As String = ""
            Dim ent = (New DocClasificacion_BL).Listar(Me.GrillaCodigo)

            If ent.EstadoDocId = enmEstadoTramiteDoc.Anulado Then
                Legolas.Configuration.Aplication.MessageBox.Information("El documento se encuentra anulado.")
                Return False
            End If

            If ent.EstadoDocId = enmEstadoTramiteDoc.Derivado Then
                Legolas.Configuration.Aplication.MessageBox.Information("El documento ya ha sido derivado.")
                Return False
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Está seguro de derivar el documento Número " & Me.GrillaNumDoc & " con fecha de emisión " & Me.GrillaFechaEmision & "?") = Windows.Forms.DialogResult.Yes Then
                ent.EstadoDocId = enmEstadoTramiteDoc.Derivado

                If (New DocClasificacion_BL).Grabar(ent, outSms) = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Error, No se pudo derivar el documento " & outSms)
                    Return False
                Else
                    'generacion automatico de movimiento de traslado por conduccion (artificio hasta generar modulo para seguridad)
                    Dim rs As Boolean = GenerarMovTrasladoSalida_ETL(ent)

                    If rs = False Then
                        Threading.Thread.Sleep(9000) 'en caso el error sea por sobrecarga de servidor, se espera nueve segundo para un nuevo intento
                        rs = GenerarMovTrasladoSalida_ETL(ent)
                    End If

                    If rs = True Then
                        Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria.")
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Information("Ocurrió un error y no pudo generar movimiento de traslado, intentelo nuevamente " &
                                                                        "caso contrario por favor contactese con el administrador del sistema para informar del hecho.")
                    End If
                End If

                intIndiceFilaSel = dgwDocumentos.CurrentRow.Index
                ListarDocumentos()
                Try
                    dgwDocumentos.Rows(intIndiceFilaSel).Selected = True
                    dgwDocumentos.CurrentCell = dgwDocumentos.Item(1, intIndiceFilaSel)
                Catch ex As Exception
                End Try
                dgwDocumentos_CellClick(Nothing, Nothing)
                intIndiceFilaSel = -1
            End If
        End Function

        Private Function GenerarMovTrasladoSalida_ETL(ent As Entity.Clasificacion.Documento.DocClasificacion) As Boolean

            'Return IIf((New Bussines.Registro.InternoMovimiento).Insertar_MovimientosDeEgresoPorClasificacion_ETL(ent.Codigo) > 0, True, False)

            Dim lstMov = New List(Of Entity.Registro.InternoMovimiento)

            Dim detDoc As New Entity.Clasificacion.Documento.DetDocClasificacion With {
                                .DocClasificacionId = ent.Codigo
                            }

            Try
                For Each obj As Entity.Clasificacion.Documento.DetDocClasificacion In (New DetDocClasificacion_BL).Listar(detDoc)
                    Dim ficha = (New InternoFicha_BL).Listar_V2(obj.InternoFichaId)

                    Dim entIng As New Entity.Registro.Ingreso With {
                                .IngresoInpeId = ficha.IngresoInpeId,
                                .RegionID = 3,
                                .PenalID = 35
                                }

                    entIng = (New Bussines.Registro.Ingreso).Listar_LM(entIng).Item(0)

                    Dim entMov As New Entity.Registro.InternoMovimiento With {
                         .InternoID = obj.InternoId,
                        .IngresoInpeId = ficha.IngresoInpeId,
                        .MovimientoTipoID = 8, 'egreso por conduccion de clasificacion
                        .MovimientoMotivoID = 148, 'conduccion por clasificacion
                        .MovimientoGrupoID = 2, 'egreso
                        .IngresoID = entIng.Codigo,
                        .EstadoID = 3, 'mov terminado
                        .Fecha = Now.ToFileTime, ' Me.FechaRegistroMovimiento
                        .RegionOrigenID = 3,
                        .PenalOrigenID = 35,
                        .RegionDestinoID = ficha.RegionDestinoId,
                        .PenalDestinoID = ficha.PenalDestinoId,
                        ._RegionID = 3, 'region lima
                        ._PenalID = 35, 'carceleta
                        .DocumJudicialID = ent.Codigo,
                        .DocumJudicialNum = ent.NumeroDoc,
                        .DocumJudicialFecha = ent.FechaEmision,
                        .DocumJudicialFecharecepcion = ent.FechaEmision,
                        .TipoAutoridadJudicialID = 2
                        }

                    lstMov.Add(entMov)

                Next

                Return (New Bussines.Registro.InternoMovimiento).Insertar_MovimientosDeEgresoPorClasificacion_Carceleta(lstMov)

            Catch ex As Exception
                Return False
            End Try

        End Function


        Private Function EliminarDocumento() As Boolean
            If dgwDocumentos.Rows.Count = 0 Then Return False

            Dim bolResultado As Boolean = False
            Dim outSms As String = ""
            Dim ent = (New DocClasificacion_BL).Listar(Me.GrillaCodigo)

            If btnEliminar.Text = "Eliminar" Then
                If Legolas.Configuration.Aplication.MessageBox.Question("Está seguro de eliminar el documento con Número " & Me.GrillaNumDoc & " con fecha de emisión " & Me.GrillaFechaEmision & "?") = Windows.Forms.DialogResult.Yes Then
                    Dim id As Integer = (New DocClasificacion_BL).Eliminar(Me.GrillaCodigo, outSms)
                    If id = -1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("Error, No se pudo eliminar el documento " & outSms)
                        bolResultado = False
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria.")
                        bolResultado = True
                    End If
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible anular el documento derivado, si es realmente necesario anular comuniquese con el administrador del sistema.")
                bolResultado = False
                'If Legolas.Configuration.Aplication.MessageBox.Question("Está seguro de anular el documento con Número " & Me.GrillaNumDoc & " con fecha de emisión " & Me.GrillaFechaEmision & "?") = Windows.Forms.DialogResult.Yes Then
                '    ent.EstadoDocId = Type.Enumeracion.Clasificacion.enmEstadoTramiteDoc.Anulado
                '    Dim id As Integer = (New DocClasificacion).Grabar(ent, outSms)
                '    If id = -1 Then
                '        Legolas.Configuration.Aplication.MessageBox.MensajeError("Error, No se pudo eliminar el documento " & outSms)
                '        bolResultado = False
                '    Else
                '        Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria.")
                '        bolResultado = True
                '    End If
                'End If
            End If

            If bolResultado = True Then
                intIndiceFilaSel = dgwDocumentos.CurrentRow.Index
                ListarDocumentos()
                If dgwDocumentos.Rows.Count > 0 Then dgwDocumentos_CellClick(Nothing, Nothing)
                intIndiceFilaSel = -1
            End If
            Return bolResultado
        End Function

        Private Sub NuevoDocumento()
            If Me.PenalID <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("No ha pasado el parametro penal.")
                Exit Sub
            End If
            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                Me.DocumentoClasifRegionId = Me.RegionID
                Me.DocumentoClasifRegionNombre = Me.RegionNombre
                Me.DocumentoClasifPenalId = Me.PenalID
                Me.DocumentoClasifPenalNombre = Me.PenalNombre
                FRM_Mantenimiento(True)
            Else
                Dim frm As New frmPenalPopup
                With frm

                    .BRegion = Me.RegionID
                    .BPenal = Me.PenalID

                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.DocumentoClasifRegionId = .RegionID
                        Me.DocumentoClasifRegionNombre = .RegionNombre
                        Me.DocumentoClasifPenalId = .PenalID
                        Me.DocumentoClasifPenalNombre = .PenalNombre
                        FRM_Mantenimiento(True)
                    End If
                End With
            End If
        End Sub

#End Region
        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            NuevoDocumento()
        End Sub

        Private Sub frmBuscarDocClasificacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            dgwDocumentos.AutoGenerateColumns = False
            dgvDetalle.AutoGenerateColumns = False
            ValoresxDefault()
        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            ListarDocumentos()
            If dgwDocumentos.Rows.Count > 0 Then ListarDetalle()
        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
            FRM_Mantenimiento(False)
        End Sub

        Private Sub dgwDocumentos_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDocumentos.CellClick
            CargarDetalleDocumento()
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            Me.ComboPenal()
        End Sub

        Private Sub cbbPenal__SelectedIndexChanged() Handles cbbPenal._SelectedIndexChanged
            ColumnasVisible()
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub dgwDocumentos_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDocumentos.CellDoubleClick
            btnModificar_Click(Nothing, Nothing)
        End Sub


        Private Sub txtNumDoc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDoc.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then ListarDocumentos()
        End Sub

        Private Sub btnDerivar_Click(sender As System.Object, e As System.EventArgs) Handles btnDerivar.Click
            If dgwDocumentos.Rows.Count = 0 Then Exit Sub

            DerivarDocumento()
        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
            EliminarDocumento()
        End Sub

        Private Sub dgwDocumentos_ColumnHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwDocumentos.ColumnHeaderMouseClick
            CambiarColorTextoAnulado()
        End Sub

        Private Sub btnOficioConsolidado_Click(sender As System.Object, e As System.EventArgs) Handles btnOficioConsolidado.Click
            If dgwDocumentos.Rows.Count = 0 Then Exit Sub

            Dim frm As New APPReporte.Registro.ReporteCrystal
            With frm
                ._TipoReporte = Type.Reporte.Registro.rptClasificacionOficioConsolidado
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                '._Filtro.InternoID = Me.InternoID
                ._Filtro.DocConsolidadoClasificacionId = Me.GrillaCodigo
                .ShowDialog()
            End With
        End Sub

        Private Sub frmBuscarDocClasificacion_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Me.WindowState = FormWindowState.Maximized
            dtpFechaIni.ValueLong = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            dtpFechaFin.ValueLong = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            UsuarioPermisos()
            ListarDocumentosInicial()
        End Sub

        Private Sub dgwDocumentos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwDocumentos.KeyDown
            If e.KeyCode = Keys.Enter Then e.SuppressKeyPress = True
        End Sub


    End Class
End Namespace