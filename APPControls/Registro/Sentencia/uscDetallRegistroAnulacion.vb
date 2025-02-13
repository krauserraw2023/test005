Option Explicit On
Imports System.Data
Imports System.Linq
Imports Type.Enumeracion.TipoDocJudicial
Namespace Registro.Sentencia

    Public Class uscDetallRegistroAnulacion
        '/*bussiness*/
        ' Private objBssExpediente As Bussines.Registro.Expediente
        Private objBssExp As Bussines.Registro.Expediente
        '      Private objBssPerCon As Bussines.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
        Private objBssExpPad As Bussines.Registro.InternoExpedientePadre
        '/*entitys*/
        Private objEntExpediente As Entity.Registro.Expediente = Nothing
        '     Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objEntDelito As Entity.Registro.Delito = Nothing
        Private objEntAgraviado As Entity.Registro.Agraviado = Nothing
        Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing
        Private objEntExpPadreCol As Entity.Registro.InternoExpedientePadreCol = Nothing
        '/*Entitys temporal*/
        Private objEntExpedienteIndcCol As New Entity.Registro.ExpedienteCol
        Private objEntDelitoIndcCol As New Entity.Registro.DelitoCol
        Private objEntAgraviadosIndcCol As New Entity.Registro.AgraviadoCol

#Region "Eventos"
        Public Event _Click_Expediente_Agregar()
        Public Event _Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)

        Public Event _Click_PeriodoCondena_Agregar()
        Public Event _Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)

        Public Event _Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol)
        Public Event _Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)
        Public Event _Click_Documentos_Agregar()
        Public Event _FocusFechaRecep()
        Public Event VerDocumentoJudicial(TipForm As Integer, SubTipForm As Integer, Codigo As Integer)
#End Region
#Region "Variables"
        Private bolEdicionActivo As Boolean = False
        Private blnEliminarColection As Boolean = False
        Private blnEliminarDocumentos As Boolean = False
        Private blnEliminarDelitoColec As Boolean = False
        Private blnEliminarAgraviadoColec As Boolean = False
#End Region
#Region "Propiedades_Parametricas"
        Public Property _DocumentoJudicialID As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId As Integer = -1
        Public Property _InternoIngresoId As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        '/*revisar*/
        Public Property _PermisoEliminar() As Boolean = False
        Public Property _TipoResolucion As Integer = -1
        Public Property _ExpIDCopi As Integer = -1
        Public ReadOnly Property _GrillaDelito_ExpItem() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_exp_item").Value
                Catch ex As Exception
                    Return 0
                End Try
            End Get
        End Property
        Public ReadOnly Property GrillaDocumentoID() As Integer
            Get
                Try
                    Return dgvListarDocumentos.SelectedRows(0).Cells("col_doc_jud_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property GrillaDocumentoJudicialID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property

        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property
#End Region
#Region "Propiedades_Grilla"
        Public ReadOnly Property _RetornarLista_DocJudicialExpedientes() As Entity.Registro.ExpedienteCol
            Get
                Dim objEntColAux As New Entity.Registro.ExpedienteCol
                If Me._DocumentoJudicialID = -1 Then 'si es nuevo RESOLUCION 
                    For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                        objEntColAux.Add(objEntExpedienteTempoCol.Expediente(i))
                    Next
                    Return objEntColAux
                Else 'si es editar resolucion
                    Return objEntExpedienteTempoCol
                End If
            End Get
        End Property

        '********************** HNRB
        Private ReadOnly Property GrillaPeriodoCondenaCodigo() As Integer
            Get
                Try
                    Return dgvListarDocumentos.SelectedRows(0).Cells("codigo").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaPeriodoCondenaItem() As Integer
            Get
                Try
                    Return dgvListarDocumentos.SelectedRows(0).Cells("col_ped_cond_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteSelect() As Entity.Registro.Expediente
            Get
                objEntExpediente = New Entity.Registro.Expediente

                For Each objExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If Me._GrillaItemExpediente = objExp.ExpedienteItem Then
                        objEntExpediente = objExp
                        Exit For
                    End If
                Next

                Return objEntExpediente

            End Get
        End Property
        Public ReadOnly Property _GrillaExpedienteID() As Integer
            Get

                Return Me.GrillaExpedienteID

            End Get
        End Property
        Public ReadOnly Property _GrillaDelitoID() As Integer
            Get
                Return Me.GrillaDelitoID
            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("codigo").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaDelitoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwDelito
                        intValue = .SelectedRows(0).Cells("col_int_del_id").Value

                        If intValue = -1 Then intValue = 0
                    End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property _GrillaItemExpediente() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaItemDelito() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_del_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _Grilla_NroRegistroExpediente As Integer
            Get
                Try
                    Return dgwExpediente.Rows.Count
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _Grilla_NroRegistroDelito As Integer
            Get
                Try
                    Return dgwDelito.Rows.Count
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaItemAgraviado() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_agrav_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property GrillaTipoDocumento() As Integer
            Get
                Try
                    Return dgvListarDocumentos.SelectedRows(0).Cells("col_doc_tip_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property GrillaSubTipoDocumento() As Integer
            Get
                Try
                    Return dgvListarDocumentos.SelectedRows(0).Cells("col_doc_sub_tip_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property GrillaCodigoDocumento() As Integer
            Get
                Try
                    Return dgvListarDocumentos.SelectedRows(0).Cells("col_doc_jud_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property GrillaExpedienteRefID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_exp_ref_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
#End Region
#Region "Propiedades_Grilla_Select"
        Private ReadOnly Property GrillaExpedienteIndex() As Integer
            Get
                Return Me.dgwExpediente.SelectedRows(0).Index
            End Get
        End Property
        Private ReadOnly Property GrillaDelitoIndex() As Integer
            Get
                Dim value As Integer = -1

                For i As Integer = 0 To objEntDelitoTempoCol.Count - 1
                    If Me.GrillaExpedienteID = objEntDelitoTempoCol.Delito(i).ExpedienteID Then
                        If Me._GrillaItemDelito = objEntDelitoTempoCol.Delito(i).DelitoItem Then
                            value = i
                            Exit For
                        End If
                    End If
                Next
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaDelitoSelect() As Entity.Registro.Delito
            Get
                objEntDelito = New Entity.Registro.Delito

                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                    If Me._GrillaItemDelito = objDel.DelitoItem Then
                        objEntDelito = objDel
                        Exit For
                    End If
                Next

                Return objEntDelito

            End Get
        End Property
        Private ReadOnly Property Grilla_Agraviados_Delito_Select() As Entity.Registro.AgraviadoCol
            Get

                Dim value As New Entity.Registro.AgraviadoCol

                If dgwDelito.Rows.Count > 0 Then

                    For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If Me._GrillaItemDelito = objAgraviado.DelitoItem Then
                            value.Add(objAgraviado)
                        End If
                    Next
                End If
                Return value
            End Get
        End Property

        Private _btnAgregarPerido As Boolean = True
        Public Property btnAgregarPerido() As Boolean
            Get
                Return _btnAgregarPerido
            End Get
            Set(ByVal value As Boolean)

            End Set
        End Property
        Private _btnCajasPeriodo As Boolean = False
        Public Property btnCajasPeriodo() As Boolean
            Get
                Return _btnCajasPeriodo
            End Get
            Set(ByVal value As Boolean)

            End Set
        End Property

        Public _blnCadenaPerpetua As Boolean = False

#End Region
#Region "Temporales"
        Public objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol = Nothing
        Private objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing
        Private objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
        Private objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol = Nothing
        Private objEntAgraviadoTempoColGrilla As Entity.Registro.AgraviadoCol = Nothing

        Public Sub _Temporal_Grabar_Expediente_Delito_Agraviado(objEnt As Entity.Registro.ExpedienteCol, objEntDel As Entity.Registro.DelitoCol, objEntAgr As Entity.Registro.AgraviadoCol)
            If chkLista.Checked = True Then
                chkLista.Checked = False
                lblDelitosAgraviados.Text = "Delitos/Agraviados"
            End If
            If ValidarTipoResolucion(Me._TipoResolucion) = True Then
                If dgwExpediente.Rows.Count = 0 Then
                    If objEnt.Count = 1 Then
                        intContadorLoad += 1
                        Temporal_Grabar_Expediente_Delito_Agraviado(objEnt, objEntDel, objEntAgr)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion  solo puede cargar un expediente.")
                        Exit Sub
                    End If
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion solo puede tener un expediente.")
                    Exit Sub
                End If
            Else
                intContadorLoad += 1
                Temporal_Grabar_Expediente_Delito_Agraviado(objEnt, objEntDel, objEntAgr)
            End If

            dgwExpediente_CellClick(Nothing, Nothing)
        End Sub
        Private entExpColAcum As New Entity.Registro.ExpedienteCol
        Private Sub Temporal_Grabar_Expediente_Delito_Agraviado(objEntExpedienteCol As Entity.Registro.ExpedienteCol, objEntDelitoCol As Entity.Registro.DelitoCol,
                                                                objEntAgraviadoCol As Entity.Registro.AgraviadoCol)

            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol

                objEntExpediente._RegionId = Me._RegionID
                objEntExpediente._PenalId = Me._PenalID
                If objEntExpediente.DocumentoTipoID = 19 Or objEntExpediente.DocumentoTipoID = 28 Or objEntExpediente.DocumentoTipoID = 29 Then
                    objEntExpediente.Codigo = 999999
                End If
                Temporal_GrabarExpediente(objEntExpediente)
                If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                    objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                    objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Then
                    Dim objEntExpedienteCol2 As New Entity.Registro.ExpedienteCol
                    entExpColAcum = New Entity.Registro.ExpedienteCol
                    objBssExp = New Bussines.Registro.Expediente
                    objEntExpedienteCol2 = objBssExp.ListarExpedientexResolucion(objEntExpediente.CreaDocJudicialId)
                    For Each objEnt2 As Entity.Registro.Expediente In objEntExpedienteCol2
                        entExpColAcum.Add(objEnt2)
                        For Each objDelito As Entity.Registro.Delito In objEntDelitoCol

                            If objEnt2.Codigo = objDelito.ExpedienteID Then
                                objDelito.ExpedienteID = 999999
                                objEnt2.ExpedienteItem = objEntExpediente.ExpedienteItem
                                objDelito.ExpedienteItem = objEntExpediente.ExpedienteItem
                                'grabar delitos
                                Temporal_GrabarDelito(objEnt2, objDelito, Nothing)
                            End If
                            For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                                objAgraviado.ExpedienteID = 999999
                                If objDelito.Codigo = objAgraviado.DelitoID Then

                                    objAgraviado.ExpedienteItem = objEntExpediente.ExpedienteItem
                                    objAgraviado.DelitoItem = objDelito.DelitoItem
                                    'grabar agraviados
                                    Temporal_GrabarAgraviado(objDelito, objAgraviado)

                                End If
                            Next
                        Next
                    Next
                Else
                    For Each objDelito As Entity.Registro.Delito In objEntDelitoCol

                        If objEntExpediente.Codigo = objDelito.ExpedienteID Then
                            objDelito.ExpedienteItem = objEntExpediente.ExpedienteItem
                            Temporal_GrabarDelito(objEntExpediente, objDelito, Nothing)

                            For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                                If objDelito.Codigo = objAgraviado.DelitoID Then
                                    objAgraviado.ExpedienteItem = objEntExpediente.ExpedienteItem
                                    If objDelito.DelitoItem = -1 Then
                                        objDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoCol)
                                    End If
                                    objAgraviado.DelitoItem = objDelito.DelitoItem
                                    Temporal_GrabarAgraviado(objDelito, objAgraviado)
                                Else
                                    If Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                        If objDelito.DelitoEspecifico = objAgraviado.DelitoEspecificoID Then
                                            objAgraviado.ExpedienteItem = objEntExpediente.ExpedienteItem
                                            objAgraviado.DelitoItem = objDelito.DelitoItem
                                            objAgraviado.DelitoID = objDelito.Codigo
                                            objAgraviado.ExpedienteID = objDelito.ExpedienteID
                                            objAgraviado.CreaDocJudicialId = objDelito.CreaDocJudicialId
                                            Temporal_GrabarAgraviado(objDelito, objAgraviado)
                                        End If
                                    End If
                                End If
                            Next
                        End If

                    Next
                End If
            Next
            Temporal_ListarExpediente()
            Temporal_ListarDelitos(Nothing)
            Temporal_ListarAgraviadosBD(Nothing)
        End Sub
        Public objEntcolT As New Entity.Registro.DocumentoJudicialCol
        Public Sub _Temporal_Grabar_Documentos(objEntcol As Entity.Registro.DocumentoJudicialCol)
            If Not (objDocumJudicialCol Is Nothing) Then
                objEntcolT = objDocumJudicialCol
            End If
            If objEntcolT Is Nothing Then
                objEntcolT = New Entity.Registro.DocumentoJudicialCol
            End If
            For Each ent As Entity.Registro.DocumentoJudicial In objEntcol
                objEntcolT.Add(ent)
            Next
            Temporal_ListarDocumentos(objEntcolT)

        End Sub



        Private Sub Temporal_GrabarListaExpediente(objEntTemCol As Entity.Registro.ExpedienteCol)
            If Not objEntTemCol Is Nothing Then
                For Each objEntExp As Entity.Registro.Expediente In objEntTemCol
                    objEntExp._RegionId = Me._RegionID
                    objEntExp._PenalId = Me._PenalID
                    objEntExp.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                    objEntExpedienteTempoCol.Add(objEntExp)
                Next
                Temporal_ListarExpediente()
            End If
        End Sub

        Private Sub Temporal_ListarDocumentos(objEntCol As Entity.Registro.DocumentoJudicialCol)
            With Me.dgvListarDocumentos
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                .Refresh()
                'lblNroExpedientes.Text = "Documentos " & .Rows.Count & " Reg."
            End With
            objDocumJudicialCol = objEntCol
        End Sub
        Private Sub Temporal_ListarExpediente()
            With Me.dgwExpediente
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = IIf(objEntExpedienteTempoCol.Expediente(0) Is Nothing, Nothing, objEntExpedienteTempoCol)
                .Refresh()
                lblNroExpedientes.Text = "Expedientes " & .Rows.Count & " Reg."
            End With
        End Sub
        Private intContadorLoad As Integer = -1
        Private Sub Temporal_ListarDelitos(objEntExpediente As Entity.Registro.Expediente)
            If objEntExpediente Is Nothing Then
                'nada
            Else
                objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
                For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
                    If obj.ExpedienteID = objEntExpediente.Codigo Then
                        If obj.ExpedienteID > 0 Then
                            objEntDelito = New Entity.Registro.Delito
                            Temporal_DelitoCopiarPropiedades(objEntDelito, obj)
                            objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                            objEntDelitoTempoColGrilla.Add(objEntDelito)
                        Else
                            If objEntExpediente.ExpedienteItem = obj.ExpedienteItem Then
                                objEntDelito = New Entity.Registro.Delito
                                Temporal_DelitoCopiarPropiedades(objEntDelito, obj)
                                objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                                objEntDelitoTempoColGrilla.Add(objEntDelito)
                            End If
                        End If
                    End If
                Next

                '----------------------------------------------------------------------------------->>
                Dim f As DataGridViewRow
                dgwDelito.Rows.Clear()
                bolEdicionActivo = False
                dgwDelito.RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                objBssExpPad = New Bussines.Registro.InternoExpedientePadre
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoColGrilla
                    Temporal_ListarAgraviados(objDel)
                    For Each objAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoColGrilla
                        f = dgwDelito.Rows(dgwDelito.Rows.Add())
                        f.Cells("col_int_del_id").Value = objDel.Codigo
                        f.Cells("col_exp_id").Value = objDel.ExpedienteID
                        f.Cells("col_exp_item").Value = objDel.ExpedienteItem
                        f.Cells("col_del_item").Value = objDel.DelitoItem
                        f.Cells("col_del_esp_nom").Value = objDel.DelitoEspecificoNombre
                        f.Cells("col_nom_del_gen").Value = objDel.DelitoGenericoNombre
                        f.Cells("col_del_obs").Value = objAgr.Observacion
                        f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaId
                        f.Cells("col_agrav_cod").Value = objAgr.Codigo
                        f.Cells("col_agrav_item").Value = objAgr.AgraviadoItem
                        f.Cells("col_agr_delito_item").Value = objAgr.DelitoItem
                        f.Cells("col_agr_exp_item").Value = objAgr.ExpedienteItem
                        f.Cells("col_agrav").Value = objAgr.AgraviadoNombre
                        f.Cells("col_est_anu").Value = objAgr.Anulacion
                        If objAgr.AnulacionAux = True Then
                            f.ReadOnly = True
                            f.DefaultCellStyle.BackColor = Color.Red
                        End If
                        If Me._DocumentoJudicialID > 0 Then
                            If objAgr.intContador = 0 Then
                                If Me._DocumentoJudicialID = objAgr.CreaDocJudicialId Then
                                    If Me.GrillaExpedienteRefID > 0 Then
                                        f.ReadOnly = True
                                    Else
                                        Dim entAgr As New Entity.Registro.Agraviado
                                        Dim entAgrCol As New Entity.Registro.AgraviadoCol
                                        entAgr.Codigo = objAgr.CodigoagraviadoPad

                                        If entAgr.Codigo > 0 Then

                                            entAgrCol = objBssAgraviado.Listar(entAgr)
                                            Dim entPad As New Entity.Registro.InternoExpedientePadre
                                            entPad.InternoExpedienteId = objAgr.ExpedienteID
                                            entPad.InternoID = objAgr.InternoID
                                            Dim expHijoID As Integer = objBssExpPad.ExisteExpedienteHijo(entPad)
                                            If entAgrCol.Count > 0 Then

                                                If objAgr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total And entAgrCol.Item(0).Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total And
                                                    entAgrCol.Item(0).DocumentoTipoID = 34 And expHijoID > 0 Then
                                                    f.ReadOnly = True
                                                    f.DefaultCellStyle.BackColor = Color.Red
                                                    objAgr.AnulacionAux = True
                                                End If
                                            End If
                                        End If

                                    End If
                                End If
                            End If
                        End If
                    Next
                Next
                bolEdicionActivo = True
            End If

        End Sub
        Private Sub Temporal_ListarAgraviados(objEntDelito As Entity.Registro.Delito)
            If objEntDelito Is Nothing Then Exit Sub

            objEntAgraviadoTempoColGrilla = New Entity.Registro.AgraviadoCol
            For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                If obj.DelitoItem = objEntDelito.DelitoItem Then
                    objEntAgraviado = New Entity.Registro.Agraviado
                    Temporal_AgraviadoCopiarPropiedades(objEntAgraviado, obj)
                    objEntAgraviadoTempoColGrilla.Add(obj)
                End If
            Next

        End Sub
        Private Sub Temporal_ListarAgraviadosBD(objEntDelito As Entity.Registro.Delito)
            Dim intInd As Integer = -1
            For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                intInd = intInd + 1
                If obj.CreaDocJudicialId > 0 Then
                    If obj.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                        'dgwDelito.Rows(intInd).ReadOnly = True
                        'dgwDelito.Rows(intInd).DefaultCellStyle.BackColor = Color.Red
                        obj.AnulacionAux = True
                    End If
                End If

            Next
        End Sub
#Region "Eliminar"
        Private Sub Temporal_EliminarExpediente_Delito_Agraviado(SelectExpediente As Boolean, SelectDelito As Boolean, SelectAgraviado As Boolean)
            bolEdicionActivo = False
            If Me._DocumentoJudicialID > 0 Then
                objBssExpPad = New Bussines.Registro.InternoExpedientePadre
                objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                objEntExpPadre.InternoExpedienteId = Me.GrillaExpedienteID
                Dim blnValor As Boolean = objBssExpPad.ValidarExpediente(objEntExpPadre)
                If blnValor = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente seleccionado no se puede eliminar, ya ha sido referenciado")
                    Exit Sub
                End If
            End If
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Esta seguro de sacar de la lista, el expediente, delitos y agraviado.") = DialogResult.Yes Then
                Temporal_EliminarExpedienteAgraviado()
                'eliminar el delito
                Temporal_EliminarExpedienteDelito()
                'eliminar el expediente
                Temporal_EliminarExpediente()
            End If
        End Sub
        Private Sub Temporal_EliminarExpedienteAgraviado()
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaExpedienteID = objEntAgraviadoTempoCol.Item(i).ExpedienteID Then
                    If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                        blnEliminarAgraviadoColec = True
                        objEntAgraviado = New Entity.Registro.Agraviado
                        objEntAgraviado.Codigo = objEntAgraviadoTempoCol.Item(i).Codigo
                        objEntAgraviadosIndcCol.Add(objEntAgraviado)
                    End If
                    objEntAgraviadoTempoCol.Remove(i)
                End If
            Next
        End Sub
        Private Sub Temporal_EliminarExpedienteDelito()
            For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then
                    If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                        blnEliminarDelitoColec = True
                        objEntDelito = New Entity.Registro.Delito
                        objEntDelito.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                        objEntDelitoIndcCol.Add(objEntDelito)
                    End If
                    objEntDelitoTempoCol.Delete(i)
                End If
            Next
            dgwExpediente_CellClick(Nothing, Nothing)
            dgwDelito.Refresh()
        End Sub
        Private Sub Temporal_EliminarExpediente()
            If Me.dgwExpediente.RowCount > 0 Then
                Dim intCodigo As Integer = Me.GrillaExpedienteID
                If Me.GrillaExpedienteID > 0 Then
                    If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                        blnEliminarColection = True
                        objEntExpediente = New Entity.Registro.Expediente
                        objEntExpediente.Codigo = Me._DocumentoJudicialID
                        objEntExpediente.Codigo = intCodigo
                        objEntExpedienteIndcCol.Add(objEntExpediente)
                    End If
                End If
                objEntExpedienteTempoCol.Remove(Me.GrillaExpedienteIndex)
                Temporal_ListarExpediente()
                Temporal_ListarDelitos(Nothing)
                dgwExpediente_CellClick(Nothing, Nothing)
            End If
        End Sub
        Dim objDocEliCol As New Entity.Registro.DocumentoJudicialCol

        Private Sub Temporal_EliminarDocumento()
            If dgvListarDocumentos.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un documento para eliminar.")
                btnAddExp.Focus()
            Else
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Esta seguro de sacar el documento de la lista.") = DialogResult.Yes Then
                    Dim abc As Integer = dgvListarDocumentos.SelectedRows(0).Index
                    'objEntcolT.RemoveAt(dgvListarDocumentos.SelectedRows(0).Index)
                    If Me._DocumentoJudicialID > 0 Then
                        objDocEliCol.Add(objDocumJudicialCol.DocumentoJudicial(dgvListarDocumentos.SelectedRows(0).Index))
                        blnEliminarDocumentos = True
                    End If
                    objDocumJudicialCol.RemoveAt(dgvListarDocumentos.SelectedRows(0).Index)
                    Temporal_ListarDocumentos(objDocumJudicialCol) 'objEntcolT
                End If
            End If
        End Sub
        Dim intPadre As Integer = -1
        Private Function ValidarExpedientePadreBD() As Boolean
            Dim objBssPad As Bussines.Registro.InternoExpedientePadre
            objBssExp = New Bussines.Registro.Expediente
            Dim EntColPad As New Entity.Registro.InternoExpedientePadreCol
            Dim ListaExpediente As New Entity.Registro.Expediente
            objBssPad = New Bussines.Registro.InternoExpedientePadre
            Dim EntExp As New Entity.Registro.InternoExpedientePadre
            EntExp.Codigo = Me._GrillaExpedienteID
            EntExp.InternoID = Me._InternoId
            EntColPad = objBssPad.ListarGrilla(EntExp)
            Dim blnSwitch As Boolean = False
            For Each EntCodi As Entity.Registro.InternoExpedientePadre In EntColPad
                If EntExp.Codigo = EntCodi.InternoExpedienteRefPadreId Then
                    intPadre = EntCodi.InternoExpedienteRefPadreId
                    blnSwitch = True
                    Exit For
                End If
            Next
            If blnSwitch = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente no puede ser elimando, ha sido referenciado.")
                blnSwitch = False
            End If
            Return blnSwitch
        End Function
        Public Function Validar() As Boolean
            If Me._Grilla_NroRegistroExpediente = 0 Then
                If Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion debe tener por lo menos un expediente")
                    Return False
                End If
            End If
            If Me._Grilla_NroRegistroDelito = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion debe tener por lo menos un delito")
                Return False
            End If

            Dim intConta As Integer = -1
            Dim intExped As Integer = -1
            Dim intConNormal As Integer = 0
            Dim intConTotal As Integer = 0
            Dim conExped As Integer = 0
            Dim blnAnul As Boolean = False
            Dim NumeroExp As String = ""
            For Each Agr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                intConta += 1
                If intConta = 0 Then
                    intExped = Agr.ExpedienteID
                End If
                If Agr.ExpedienteID = intExped Then
                    conExped += 1
                    If Agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total And Agr.AnulacionAux = False Then
                        intConTotal += 1
                    Else
                        intConNormal += 1
                    End If
                Else
                    If conExped = intConNormal Then
                        blnAnul = True
                        Exit For
                    End If
                    intExped = Agr.ExpedienteID
                    conExped = 0
                    intConNormal = 0
                    If Agr.ExpedienteID = intExped Then
                        conExped += 1
                        If Agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total And Agr.AnulacionAux = False Then
                            intConTotal += 1
                        Else
                            intConNormal += 1
                        End If
                    End If
                End If
                If objEntAgraviadoTempoCol.Count = intConta + 1 Then
                    If conExped = intConNormal Then
                        blnAnul = True
                        Exit For
                    End If
                End If
            Next
            If blnAnul = True Then
                For i As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                    If intExped = objEntExpedienteTempoCol.Expediente(i).Codigo Then
                        NumeroExp = objEntExpedienteTempoCol.Expediente(i).ExpedienteNumero
                        Exit For
                    End If
                Next
                If Me._DocumentoJudicialID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente : " & NumeroExp & "  debe tener por lo menos un agraviado anulado.")
                    Return False
                End If
                For i As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                    If intExped = objEntExpedienteTempoCol.Expediente(i).Codigo Then
                        NumeroExp = objEntExpedienteTempoCol.Expediente(i).ExpedienteNumero
                        Exit For
                    End If
                Next
                Dim intContaAnu As Integer = 0
                For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    For Each Agr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If obj.Codigo = Agr.ExpedienteID Then
                            If Agr.Anulacion = 0 Then
                                intContaAnu += 1
                            End If
                        End If
                    Next
                    If objEntAgraviadoTempoCol.Count = intContaAnu And objEntAgraviadoTempoCol.Count > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente : " & obj.ExpedienteNumero & "  debe tener por lo menos un agraviado anulado.")
                        Return False
                        Exit For
                    End If
                Next
            End If
            Return True
        End Function

        Public Sub EliminarExpedienteBD(DocumentoAnuId As Integer)
            If blnEliminarColection = True Then
                Dim objAgraviadoAuxCol As New Entity.Registro.AgraviadoCol
                Dim CodAgraviado As Integer = -1
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                    CodAgraviado = EntAgr.Codigo
                    While CodAgraviado > 0
                        objEntAgraviado = New Entity.Registro.Agraviado
                        objEntAgraviado.InternoID = Me._InternoId
                        objEntAgraviado.Codigo = CodAgraviado
                        objEntAgraviado.Anulacion = 0
                        objBssAgraviado.Grabar_Anu_LM(objEntAgraviado)
                        CodAgraviado = objBssAgraviado.Listar_v3(objEntAgraviado).Item(0).CodigoagraviadoPad
                    End While
                Next
                Dim objExpCol As Entity.Registro.ExpedienteCol
                Dim objDelCol As Entity.Registro.DelitoCol
                Dim objAgrCol As Entity.Registro.AgraviadoCol
                Dim AuxIngresoId As Integer

                Dim objExpedientesAuxCol As New Entity.Registro.ExpedienteCol
                Dim CodOriginalExpedienteId As Integer = -1
                Dim CodExpediente As Integer = -1
                For Each EntExp As Entity.Registro.Expediente In objEntExpedienteIndcCol
                    CodOriginalExpedienteId = EntExp.Codigo
                    objExpedientesAuxCol.Add(EntExp)
                    CodExpediente = EntExp.Codigo
                    AuxIngresoId = EntExp.IngresoInpeId
                    While CodExpediente > 0
                        objDelCol = New Entity.Registro.DelitoCol
                        objEntDelito = New Entity.Registro.Delito
                        objEntDelito.InternoID = Me._InternoId
                        objEntDelito.ExpedienteID = CodExpediente
                        objDelCol = objBssDelito.Listar2_LM(objEntDelito)

                        Dim conDelNor As Integer = 0, conDelPar As Integer = 0, conDelTot As Integer = 0
                        For Each objDel As Entity.Registro.Delito In objDelCol
                            AuxIngresoId = objDel.IngresoInpeId
                            objAgrCol = New Entity.Registro.AgraviadoCol
                            objEntAgraviado = New Entity.Registro.Agraviado
                            objEntAgraviado.InternoID = Me._InternoId
                            objEntAgraviado.DelitoID = objDel.Codigo
                            objAgrCol = objBssAgraviado.Listar_LM(objEntAgraviado)

                            Dim conAgrNor As Integer = 0, conAgrPar As Integer = 0, conAgrTot As Integer = 0
                            For Each objAgr As Entity.Registro.Agraviado In objAgrCol
                                If objAgr.Anulacion = 2 Then
                                    conAgrTot += 1
                                Else
                                    conAgrNor += 1
                                End If
                            Next
                            If conAgrTot > 0 And conAgrNor = 0 Then
                                objDel.Anulacion = 2
                                conDelTot += 1
                            ElseIf conAgrTot = 0 And conAgrNor > 0 Then
                                objDel.Anulacion = 0
                                conDelNor += 1
                            Else
                                objDel.Anulacion = 1
                                conDelPar += 1
                            End If
                            objBssDelito.Grabar_Anu(objDel)
                        Next
                        If conDelTot > 0 And conDelPar = 0 And conDelNor = 0 Then
                            EntExp.Anulacion = 2
                        ElseIf conDelTot = 0 And conDelPar = 0 And conDelNor > 0 Then
                            EntExp.Anulacion = 0
                        Else
                            EntExp.Anulacion = 1
                        End If
                        objBssExp = New Bussines.Registro.Expediente
                        EntExp.Codigo = CodExpediente
                        objBssExp.UpdateAnulacion_LM(EntExp)
                        objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                        objEntExpPadre.InternoExpedienteId = CodExpediente
                        CodExpediente = objBssExpPad.Listar_LM(objEntExpPadre).InternoExpedienteRefPadreId
                    End While
                Next
                objEntDocCol = New Entity.Registro.DocumentoJudicialCol
                objDocumJudicial = New Entity.Registro.DocumentoJudicial
                objDocumJudicial.InternoId = Me._InternoId
                objDocumJudicial.IngresoInpeId = AuxIngresoId
                objEntDocCol = bssDoc.ListarDocJud_v2_LM(objDocumJudicial)
                For Each obj As Entity.Registro.DocumentoJudicial In objEntDocCol
                    If obj.DocumentoTipo <> 34 Then
                        contaN = 0
                        contaP = 0
                        contaT = 0
                        objEntExpediente = New Entity.Registro.Expediente
                        objExpCol = New Entity.Registro.ExpedienteCol
                        objExpCol = objBssExp.ListarExpedientexResolucion(obj.Codigo)
                        For Each EntExp As Entity.Registro.Expediente In objExpCol
                            If EntExp.Anulacion = 0 Then
                                contaN += 1
                            ElseIf EntExp.Anulacion = 1 Then
                                contaP += 1
                            ElseIf EntExp.Anulacion = 2 Then
                                contaT += 1
                            End If
                        Next
                        If contaT > 0 And contaP = 0 And contaN = 0 Then
                            obj.Estado = 3
                            obj.IdDocumentoAntecedente = DocumentoAnuId
                        ElseIf contaT = 0 And contaP = 0 And contaN > 0 Then
                            obj.IdDocumentoAntecedente = -1
                            obj.Estado = 1
                        Else
                            obj.Estado = 2
                            obj.IdDocumentoAntecedente = DocumentoAnuId
                        End If
                        bssDoc.GrabarAnulacion(obj)
                    End If
                Next
                '---------------------------------------------------------------
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
                For Each EntDel As Entity.Registro.Delito In objEntDelitoIndcCol
                    AEliminarDelitoBD(EntDel.Codigo)
                Next
                For Each EntExp As Entity.Registro.Expediente In objExpedientesAuxCol
                    ''EntExp.Codigo
                    AEliminarExpedienteBD(CodOriginalExpedienteId)

                Next
                blnEliminarColection = False
            End If
            If blnEliminarDocumentos = True Then
                For Each EntAgr As Entity.Registro.DocumentoJudicial In objDocEliCol
                    With EntAgr
                        ._RegionID = Me._RegionID
                        ._PenalID = Me._PenalID
                        .InternoId = Me._InternoId
                        .IdDocumentoAntecedente = -1
                        .Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                    End With
                    bssDoc.GrabarAnulacion(EntAgr)
                Next
                blnEliminarDocumentos = False
            End If
        End Sub
#End Region
#Region "Grabar"
#Region "Expediente"
        Public Sub _Temporal_GrabarExpediente(objEnt As Entity.Registro.Expediente)

            If objEnt.Nuevo = False Then
                If ValidarTipoResolucion(Me._TipoResolucion) = True Then
                    If dgwExpediente.Rows.Count = 0 Then
                        Temporal_GrabarExpediente(objEnt)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion solo puede tener un expediente.")
                        Exit Sub
                    End If
                End If
            End If
            Temporal_GrabarExpediente(objEnt)
        End Sub
        Private Sub Temporal_GrabarExpediente(objEnt As Entity.Registro.Expediente)
            'si el temporal ya existe 
            If objEnt.ExpedienteItem > 0 Then
                For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If obj.ExpedienteItem = objEnt.ExpedienteItem Then
                        Temporal_ExpedienteCopiarPropiedades(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                'si el temporal es nuevo
                objEnt._RegionId = Me._RegionID
                objEnt._PenalId = Me._PenalID
                objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                objEntExpedienteTempoCol.Add(objEnt)
            End If
            Temporal_ListarExpediente()
        End Sub
        Private Sub Temporal_GrabarDocumentos(objEntcol As Entity.Registro.DocumentoJudicialCol)

            Temporal_ListarDocumentos(objEntcol)

        End Sub
        Private Sub Temporal_ExpedienteCopiarPropiedades(objEntOrigen As Entity.Registro.Expediente, ObjEntDestino As Entity.Registro.Expediente)
            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
                .AutoridadJudicialID = ObjEntDestino.AutoridadJudicialID
                .AutoridadJudicialNombre = ObjEntDestino.AutoridadJudicialNombre
                .SalaJudicialID = ObjEntDestino.SalaJudicialID
                .SalaJudicialNombre = ObjEntDestino.SalaJudicialNombre
                .ExpedienteJuez = ObjEntDestino.ExpedienteJuez
                .ExpedienteSecretario = ObjEntDestino.ExpedienteSecretario
                .ExpedienteNumero = ObjEntDestino.ExpedienteNumero
                .ExpedienteFechaDocRecepcion = ObjEntDestino.ExpedienteFechaDocRecepcion
                .ExpedienteFecha = ObjEntDestino.ExpedienteFecha
                .SituacionJuridicaNombre = ObjEntDestino.SituacionJuridicaNombre
                .SituacionJuridicaID = ObjEntDestino.SituacionJuridicaID
                .Observacion = ObjEntDestino.Observacion
                .LibertadTipoID = ObjEntDestino.LibertadTipoID
                .Flagrancia = ObjEntDestino.Flagrancia
            End With

        End Sub
        Private Function TemporalExpedienteItemMaximo(objEntCol As Entity.Registro.ExpedienteCol) As Integer
            Dim intNumero As Integer = 0
            For Each obj As Entity.Registro.Expediente In objEntCol
                If obj.ExpedienteItem > intNumero Then intNumero = obj.ExpedienteItem
            Next
            Return intNumero
        End Function
#End Region
#Region "Delito"
        Public Sub _Temporal_GrabarDelito(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntAgraviadoCol As Entity.Registro.AgraviadoCol)

            Temporal_GrabarDelito(objEntExpediente, objEntDelito, objEntAgraviadoCol)
            Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))

        End Sub
        Private Sub Temporal_GrabarDelito(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito,
                                                  objEntAgraviadoCol As Entity.Registro.AgraviadoCol)

            If objEntDelito.Codigo > 0 Then
                'si el delito viene de la bd 
                If objEntDelito.DelitoItem > 0 Then
                    'actualiza agraviados
                    For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
                        If obj.Codigo = objEntDelito.Codigo Then
                            Temporal_DelitoCopiarPropiedades(obj, objEntDelito)
                            Exit For
                        End If
                    Next
                Else
                    objEntDelito.ExpedienteItem = objEntExpediente.ExpedienteItem
                    objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol) + 1
                    objEntDelitoTempoCol.Add(objEntDelito)
                End If
                If Not objEntAgraviadoCol Is Nothing Then
                    For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                        Temporal_GrabarAgraviado(objEntDelito, objAgraviado)
                    Next
                End If
            Else
                'si el temporal ya existe 
                If objEntDelito.DelitoItem > 0 Then

                    For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
                        If obj.DelitoItem = objEntDelito.DelitoItem Then
                            Temporal_DelitoCopiarPropiedades(obj, objEntDelito)
                            Exit For
                        End If
                    Next

                    'actualiza agraviados
                    For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                        Temporal_GrabarAgraviado(objEntDelito, objAgraviado)
                    Next

                Else
                    'si el temporal es nuevo
                    objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                    objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol) + 1
                    objEntDelitoTempoCol.Add(objEntDelito)

                    'actualiza agraviados
                    If Not objEntAgraviadoCol Is Nothing Then

                        For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            Temporal_GrabarAgraviado(objEntDelito, objAgraviado)
                        Next

                    End If

                End If

            End If

        End Sub
        Private Sub Temporal_DelitoCopiarPropiedades(objEntOrigen As Entity.Registro.Delito, ObjEntDestino As Entity.Registro.Delito)
            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
                .ExpedienteID = ObjEntDestino.ExpedienteID
                .ExpedienteItem = ObjEntDestino.ExpedienteItem
                .DelitoItem = ObjEntDestino.DelitoItem
                '/*campos*/
                .DelitoGenerico = ObjEntDestino.DelitoGenerico
                .DelitoGenericoNombre = ObjEntDestino.DelitoGenericoNombre
                .DelitoEspecifico = ObjEntDestino.DelitoEspecifico
                .DelitoEspecificoNombre = ObjEntDestino.DelitoEspecificoNombre
                .Estado = ObjEntDestino.Estado
                .Observacion = ObjEntDestino.Observacion
                .TipoSentenciaId = ObjEntDestino.TipoSentenciaId

            End With
        End Sub
        Private Function TemporalDelitoItemMaximo(objEntCol As Entity.Registro.DelitoCol) As Integer
            Dim intNumero As Integer = 0

            For Each obj As Entity.Registro.Delito In objEntCol
                If obj.DelitoItem > intNumero Then intNumero = obj.DelitoItem
            Next
            Return intNumero
        End Function
        Private Sub Temporal_Delito_Modificar()
            If dgwDelito.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe registro seleccionado para modificar.")
                Exit Sub
            End If

            Me.GrillaDelitoSelect.DelitoItem = Me._GrillaItemDelito
            Me.GrillaDelitoSelect.ExpedienteItem = Me._GrillaItemExpediente

            RaiseEvent _Click_Delito_Editar(Me.objEntExpedienteTempoCol.Item(Me.GrillaExpedienteIndex), Me.GrillaDelitoSelect, Me.Grilla_Agraviados_Delito_Select, objEntDelitoTempoColGrilla)

        End Sub
#End Region
#Region "Agraviado"
        Public Sub _Temporal_GrabarAgraviado(objEnt As Entity.Registro.Agraviado)
            Temporal_GrabarAgraviado(Nothing, objEnt)
        End Sub
        Private Sub Temporal_GrabarAgraviado(objEntDelito As Entity.Registro.Delito, objEnt As Entity.Registro.Agraviado)
            If objEnt.Codigo > 0 Then
                'si el registro esta en la base de datos
                If objEnt.AgraviadoItem > 0 Then
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If obj.Codigo = objEnt.Codigo Then
                            Temporal_AgraviadoCopiarPropiedades(obj, objEnt)
                            Exit For
                        End If
                    Next
                Else
                    'objEntAgraviado = New Entity.Registro.Agraviado
                    objEnt.DelitoItem = objEntDelito.DelitoItem
                    objEnt.ExpedienteItem = objEntDelito.ExpedienteItem
                    objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol) + 1
                    objEntAgraviadoTempoCol.Add(objEnt)
                End If
            Else 'si el temporal ya existe 
                If objEnt.AgraviadoItem > 0 Then
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If obj.AgraviadoItem = objEnt.AgraviadoItem Then
                            Temporal_AgraviadoCopiarPropiedades(obj, objEnt)
                            Exit For
                        End If
                    Next
                Else
                    'si el temporal es nuevo
                    objEnt.DelitoItem = objEntDelito.DelitoItem
                    objEnt.ExpedienteItem = Me._GrillaItemExpediente
                    objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol) + 1
                    objEntAgraviadoTempoCol.Add(objEnt)
                End If

            End If
        End Sub

        Private Sub Temporal_AgraviadoCopiarPropiedades(objEntOrigen As Entity.Registro.Agraviado, ObjEntDestino As Entity.Registro.Agraviado)
            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
                .ExpedienteID = ObjEntDestino.ExpedienteID
                .DelitoID = ObjEntDestino.DelitoID
                .AgraviadoItem = ObjEntDestino.AgraviadoItem
                .DelitoItem = ObjEntDestino.DelitoItem
                .ExpedienteItem = ObjEntDestino.ExpedienteItem
                .TipoSentenciaId = ObjEntDestino.TipoSentenciaId
                '/*campos*/
                .AgraviadoNombre = ObjEntDestino.AgraviadoNombre
                .Observacion = ObjEntDestino.Observacion
                .Estado = ObjEntDestino.Estado
                .FlgEliminado = ObjEntDestino.FlgEliminado
                .Anulacion = ObjEntDestino.Anulacion
            End With
        End Sub
        Private Function TemporalAgraviadoItemMaximo(objEntCol As Entity.Registro.AgraviadoCol) As Integer
            Dim intNumero As Integer = 0
            For Each obj As Entity.Registro.Agraviado In objEntCol
                If obj.AgraviadoItem > intNumero Then intNumero = obj.AgraviadoItem
            Next
            Return intNumero
        End Function
#End Region
#End Region
#End Region

#Region "Listar"

        Public Sub _ListarExpediente(DocumentoJudicialID As Integer, Optional ByVal CargarMandDetencionHistorico As Boolean = True,
                                     Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False)
            Me.col_tip_sent.DataSource = (New Bussines.General.Parametrica).Listar(Type.Combo.ComboTipo.TipoAclaratoriaExpediente, 17, 17, -1, True, "[Seleccionar]")
            Me.col_tip_sent.DisplayMember = "nombre"
            Me.col_tip_sent.ValueMember = "codigo"
            Me.col_tip_sent.DropDownWidth = 200

            Dim objReg As New Entity.Registro.Documento.DocumentoJudicialExpediente
            Dim objRegCol As New Entity.Registro.Documento.DocumentoJudicialExpedienteCol
            Dim objRegCol1 As New Entity.Registro.Documento.DocumentoJudicialExpedienteCol

            If Me._DocumentoJudicialID < 1 Then 'si es nuevo y se muestra los checkeds
                dgwExpediente.Columns("col_exp_ref").Visible = False
            Else
                Dim objEntExpedienteColTmp As New Entity.Registro.ExpedienteCol
                Dim objEntDelitoColTmp As New Entity.Registro.DelitoCol
                Dim objEntAgraviadoCol As New Entity.Registro.AgraviadoCol
                objBssDelito = New Bussines.Registro.Delito
                objBssAgraviado = New Bussines.Registro.InternoAgraviado

                Dim entDel As Entity.Registro.Delito
                Dim objent_ As Entity.Registro.Agraviado

                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                    objEntExpedienteColTmp = (New Bussines.Registro.Expediente).ListarExpedientexResolucion_LM(Me._DocumentoJudicialID)
                Else
                    objEntExpedienteColTmp = (New Bussines.Registro.Expediente).ListarExpedientexResolucion(Me._DocumentoJudicialID)
                End If

                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteColTmp

                    Temporal_GrabarExpediente(objEntExpediente)
                    entDel = New Entity.Registro.Delito
                    entDel.InternoID = Me._InternoId
                    entDel.ExpedienteID = objEntExpediente.Codigo
                    entDel.Anulacion = 0
                    entDel.Estado = -1
                    objEntDelitoColTmp = objBssDelito.Listar2(entDel)
                    For Each objEntDelito As Entity.Registro.Delito In objEntDelitoColTmp
                        Temporal_GrabarDelito(objEntExpediente, objEntDelito, Nothing)
                        objent_ = New Entity.Registro.Agraviado
                        With objent_
                            .Codigo = -1
                            .DelitoID = objEntDelito.Codigo
                            .InternoID = Me._InternoId
                            '.IngresoID = Me._InternoIngresoId
                            .ExpedienteID = objEntExpediente.Codigo
                            .TipoSentenciaId = -1
                            .AgraviadoNombre = ""
                        End With
                        objent_.Anulacion = 0
                        objent_.Estado = -1
                        objEntAgraviadoCol = objBssAgraviado.Listar(objent_)

                        For Each objEntAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            objEntDelito.DelitoAuxiliar = False
                            Temporal_GrabarAgraviado(objEntDelito, objEntAgraviado)
                        Next

                    Next
                    Temporal_ListarDelitos(objEntExpediente)
                Next
                dgwExpediente_CellClick(Nothing, Nothing) 'comnetado x jmr, xq al parecer hace los mismo que 
                '<--------------------------------------------------------------------------
                bssDoc = New Bussines.Registro.DocumentoJudicial
                objDocumJudicial = New Entity.Registro.DocumentoJudicial
                objDocumJudicial.IdDocumentoAntecedente = DocumentoJudicialID
                objDocumJudicial.InternoId = Me._InternoId
                Dim objDocumJudicialCol2 As New Entity.Registro.DocumentoJudicialCol
                objDocumJudicialCol = New Entity.Registro.DocumentoJudicialCol

                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    objDocumJudicialCol2 = bssDoc.Listar_DocumentosJudicialesMovimientos_LM(objDocumJudicial)
                Else
                    objDocumJudicialCol2 = bssDoc.Listar_DocumentosJudiciales(objDocumJudicial)
                End If
                If objDocumJudicialCol2.Count > 0 Then
                    For Each obj As Entity.Registro.DocumentoJudicial In objDocumJudicialCol2
                        If obj.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas Or
                            obj.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Traslado Then
                            objDocumJudicialCol.Add(obj)
                            Select Case obj.DocumentoTipo
                                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                                    obj.DocumentoTipoNombre = obj.DocumentoTipoNombre & "/" & obj.MovimientoMotivoNom
                            End Select
                        End If
                    Next
                    Temporal_ListarDocumentos(objDocumJudicialCol)
                End If
            End If

        End Sub

#End Region
        Private objDocumJudicialCol As Entity.Registro.DocumentoJudicialCol
        Private objDocumJudicial As New Entity.Registro.DocumentoJudicial
#Region "Validar"
        Private Function ValidarTipoResolucion(Valor As Integer) As Boolean
            Dim ListaTipo = {Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes}
            For Each Codigo As Integer In ListaTipo
                If Valor = Codigo Then
                    Return False
                    Exit For
                    Exit Function
                End If
            Next
            Return True
        End Function
        Public Function ValidarExpedienteReferenciado(Condicion As String) As Boolean
            If Me._DocumentoJudicialID > 0 Then
                Dim strMensaje As String = ""
                Dim intValorpadre As Integer = 0
                objBssExpPad = New Bussines.Registro.InternoExpedientePadre
                Select Case Condicion
                    Case 1
                        strMensaje = "no se puede agregar expedientes"
                    Case 2
                        strMensaje = "no se puede agregar delitos"
                    Case 3
                        strMensaje = "no se puede agregar agraviados"
                    Case 4
                        strMensaje = "no se puede agregar [Tiempo de condena] o [Periodo de condena]"
                    Case 5
                        strMensaje = "no se puede eliminar [Tiempo de condena] o [Periodo de condena]"
                    Case 6
                        strMensaje = "VAL"
                    Case 7
                        strMensaje = "[Operación cancelada]"
                End Select

                Dim intValor As Integer = 0
                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    If objEntExpediente.Codigo > 0 Then
                        objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                        If objBssExpPad.ExisteExpedienteHijo(objEntExpPadre) > 0 Then
                            intValor = intValor + 1
                        End If
                    End If
                Next
                If intValor > 0 Then
                    If strMensaje <> "VAL" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado," & strMensaje)
                    End If
                    Return False
                End If
            End If
            Return True
        End Function
#End Region
#Region "Accion"
        Private bssDoc As New Bussines.Registro.DocumentoJudicial
        Public Sub _Grabar(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDoc As Entity.Registro.DocumentoJudicial)

            EliminarExpedienteBD(DocumentoJudicialID)
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                AGrabar_LM(DocumentoJudicialID, Nuevo, EntDoc)
            Else
                AGrabar(DocumentoJudicialID, Nuevo, EntDoc)
            End If
            AGrabarDocumento(DocumentoJudicialID, Nuevo, EntDoc)

        End Sub

        Private Sub AGrabar(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDoc As Entity.Registro.DocumentoJudicial)
            objBssExpPad = New Bussines.Registro.InternoExpedientePadre
            objBssExp = New Bussines.Registro.Expediente
            objBssAgraviado = New Bussines.Registro.InternoAgraviado

            objEntAgraviado = New Entity.Registro.Agraviado
            objEntAgraviado.InternoID = EntDoc.InternoId
            objEntAgraviado.Anulacion = -1
            objEntAgraviadosIndcCol = objBssAgraviado.Listar_ant(objEntAgraviado)
            objEntExpPadre = New Entity.Registro.InternoExpedientePadre
            objEntExpPadre.InternoID = EntDoc.InternoId
            'Esto es para Provincia y PLM
            objEntExpPadreCol = objBssExpPad.ListarGrilla_LM(objEntExpPadre)

            For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol 'Empieza el bucle para registro
                Dim IdExpedienteOrig As Integer = objExpediente.Codigo
                Dim IdDocumentoOrig As Integer = objExpediente.CreaDocJudicialId
                Dim intIdExped As Integer = -1
                If Nuevo = True Then
                    If objExpediente.Codigo > 0 And objExpediente.CreaDocJudicialId > 0 Then objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                    With objExpediente
                        .ExpedienteVisible = 1
                        .CreaDocJudicialId = DocumentoJudicialID
                        .Codigo = -1
                    End With
                Else
                    If DocumentoJudicialID = IdDocumentoOrig Then
                        objExpediente.Codigo = IdExpedienteOrig
                    Else
                        objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede)
                        objExpediente.ExpedienteVisible = 1
                        objExpediente.CreaDocJudicialId = DocumentoJudicialID
                        objExpediente.Codigo = -1
                    End If
                End If
                If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                    objExpediente.FlagTransferenciaSede = Me.FlagTransferSede
                    intIdExped = objBssExp.Grabar_LM(objExpediente)
                Else
                    'Revisar
                    intIdExped = objBssExp.Grabar(objExpediente)
                End If
                '<---------------ExpedientePadre------------------------------
                Dim objIntExpPad As New Entity.Registro.InternoExpedientePadre
                With objIntExpPad
                    .InternoID = Me._InternoId
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .InternoExpedienteId = intIdExped
                    .InternoExpedienteRefPadreId = IdExpedienteOrig
                    .DocJudicialID = DocumentoJudicialID
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                    .FlagTransferenciaSede = Me.FlagTransferSede
                End With
                If Nuevo = True Then
                    If objExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                      objExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                      objExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                        objExpediente.Codigo = -1
                        objExpediente.CreaDocJudicialId = IdDocumentoOrig
                        Dim objExp_Col As Entity.Registro.ExpedienteCol = objBssExp.Listar_v2(objExpediente)
                        For Each obj As Entity.Registro.Expediente In objExp_Col
                            objBssExp.GrabarEstadoVisibilidad(obj.Codigo, False, Me.FlagTransferSede)
                            objIntExpPad.InternoExpedienteRefPadreId = obj.Codigo
                            If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                                objBssExpPad.Grabar_LM(objIntExpPad) 'guardar en BD
                            Else
                                objBssExpPad.Grabar(objIntExpPad) 'guardar en BD
                            End If
                        Next
                    Else
                        If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                            objBssExpPad.Grabar_LM(objIntExpPad) 'guardar en BD
                        Else
                            'Revisar
                            objBssExpPad.Grabar(objIntExpPad) 'guardar en BD
                        End If
                    End If
                Else
                    If DocumentoJudicialID <> IdDocumentoOrig Then
                        objIntExpPad.InternoExpedienteRefPadreId = IdExpedienteOrig  ' solo para la resolucion de ingreso
                        objBssExpPad.Grabar(objIntExpPad)
                    End If
                End If

                Dim conDel As Integer = 0, conDelAnul As Integer = 0, conDelAnulpar As Integer = 0, intIdDel As Integer = -1
                '----------------------Registrar delitos-------------------------
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                    objDel.FlagTransferenciaSede = Me.FlagTransferSede
                    If objExpediente.ExpedienteItem = objDel.ExpedienteItem Then
                        conDel = conDel + 1
                        Dim codDelitoOri As Integer = objDel.Codigo
                        Dim docDelitoOri As Integer = objDel.CreaDocJudicialId
                        objDel.ExpedienteID = intIdExped  'referencia al nuevo expediente
                        objDel.CreaDocJudicialId = DocumentoJudicialID
                        objBssDelito = New Bussines.Registro.Delito
                        objBssAgraviado = New Bussines.Registro.InternoAgraviado
                        If Nuevo = True Then
                            objDel.Codigo = -1
                        Else
                            If objDel.Codigo > 0 And objDel.CreaDocJudicialId <> DocumentoJudicialID Then
                                objDel.Codigo = -1
                            End If
                        End If
                        If codDelitoOri > 0 And docDelitoOri <> DocumentoJudicialID Then
                            objDel.CodigodelitoPad = codDelitoOri
                        End If

                        If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                            objDel.IngresoInpeId = objExpediente.IngresoInpeId
                            intIdDel = objBssDelito.Grabar_LM(objDel) 'guardar en BD
                        Else
                            intIdDel = objBssDelito.Grabar_v2(objDel) 'guardar en BD
                            If objDel.Estado = 0 Then
                                objDel.Codigo = intIdDel
                                intIdDel = objBssDelito.Grabar_v2(objDel)
                            End If
                        End If

                        Dim intIDAgrav As Integer = -1, conAgraviados As Integer = 0, conAgraAnul As Integer = 0

                        For Each objA As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                            objA.FlagTransferenciaSede = Me.FlagTransferSede
                            If objDel.DelitoItem = objA.DelitoItem Then
                                conAgraviados = conAgraviados + 1
                                Dim codAgraviadoOri As Integer = objA.Codigo
                                Dim creaAgraviadoOri As Integer = objA.CreaDocJudicialId
                                objA.DelitoID = intIdDel
                                objA.CreaDocJudicialId = DocumentoJudicialID
                                objA.ExpedienteID = intIdExped
                                objA.TipoSentenciaId = IIf(objA.TipoSentenciaId = 0, -1, objA.TipoSentenciaId)
                                objA.TipoSentenciaHistoricoId = IIf(objA.TipoSentenciaHistoricoId = 0, -1, objA.TipoSentenciaHistoricoId)
                                objA.RegionID = Me._RegionID
                                objA.PenalID = Me._PenalID
                                If Nuevo = True Then
                                    objA.Codigo = -1
                                Else
                                    If objA.Codigo > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                        objA.Codigo = -1
                                    End If
                                End If
                                If codAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                    objA.CodigoagraviadoPad = codAgraviadoOri
                                End If

                                If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                                    objA.IngresoInpeId = objExpediente.IngresoInpeId
                                    intIDAgrav = objBssAgraviado.Grabar_LM(objA) 'guardar en BD
                                Else
                                    intIDAgrav = objBssAgraviado.Grabar(objA) 'guardar en BD
                                    If objA.Estado = 0 Then
                                        objA.Codigo = intIDAgrav
                                        objBssAgraviado.Grabar(objA)
                                    End If
                                End If
                                ''''''''''''''''''''Fin de registro de Agraviados--''IMPLEMENTACION JEU 21/11/2018''''''''''''''''''''''''''''''''''''''''
                                Dim ExpedienteAuxiliar As Integer = objA.ExpedienteID
                                If Me.GrillaExpedienteRefID < 1 Then
                                    'Dim intIDAgravAux As Integer = objA.CodigoagraviadoPad
                                    Dim entA As Entity.Registro.Agraviado = Nothing
                                    Dim AgraviadoTipoDoc As Integer = objA.DocumentoTipoID
                                    Dim AgraviadoPadreId As Integer = objA.CodigoagraviadoPad
                                    intIDAgrav = AgraviadoPadreId

                                    While intIDAgrav > 0
                                        entA = New Entity.Registro.Agraviado
                                        Dim obj As Entity.Registro.Agraviado = ObtenerAgraviadoCodigo(intIDAgrav, 1, objA.AgraviadoNombre, ExpedienteAuxiliar, objDel.DelitoEspecifico, AgraviadoPadreId)
                                        entA.Anulacion = objA.Anulacion
                                        entA.Codigo = intIDAgrav
                                        If obj.DocumentoTipoID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                            objBssAgraviado.GrabarEstado(entA)
                                            GrabarAgraviadoTemporalEstado(intIDAgrav, objA.Anulacion)
                                        End If
                                        ExpedienteAuxiliar = obj.ExpedienteID
                                        ExpedienteAuxiliar = ObtenerExpedientePadreId(ExpedienteAuxiliar)
                                        If ExpedienteAuxiliar > 0 Then
                                            Dim obj1 As Entity.Registro.Agraviado = ObtenerAgraviadoCodigo(intIDAgrav, 3, objA.AgraviadoNombre, ExpedienteAuxiliar, objDel.DelitoEspecifico, AgraviadoPadreId)
                                            intIDAgrav = obj1.Codigo
                                            AgraviadoTipoDoc = obj1.DocumentoTipoID
                                            AgraviadoPadreId = obj1.CodigoagraviadoPad
                                            ExpedienteAuxiliar = obj1.ExpedienteID
                                            If intIDAgrav > 0 Then
                                                intIDAgrav = intIDAgrav
                                            Else
                                                Dim ExpedientePadreId As Integer = ObtenerExpedientePadreId(ExpedienteAuxiliar)
                                                If ExpedientePadreId > 0 Then
                                                    obj = New Entity.Registro.Agraviado
                                                    obj = ObtenerAgraviadoCodigo(-1, 3, objA.AgraviadoNombre, ExpedientePadreId, objDel.DelitoEspecifico, objA.CodigoagraviadoPad)
                                                    intIDAgrav = obj.Codigo
                                                    AgraviadoTipoDoc = obj.DocumentoTipoID
                                                    If intIDAgrav > 0 Then
                                                        intIDAgrav = intIDAgrav
                                                    Else
                                                        Dim valor As Integer = ExpedientePadreId
                                                        While valor > 0 Or intIDAgrav > 0
                                                            ExpedientePadreId = ObtenerExpedientePadreId(valor)
                                                            obj = New Entity.Registro.Agraviado
                                                            obj = ObtenerAgraviadoCodigo(-1, 3, objA.AgraviadoNombre, ExpedientePadreId, objDel.DelitoEspecifico, objA.CodigoagraviadoPad)
                                                            intIDAgrav = obj.Codigo
                                                            AgraviadoTipoDoc = obj.DocumentoTipoID
                                                            If intIDAgrav > 0 Then
                                                                intIDAgrav = intIDAgrav
                                                                valor = -1
                                                                intIDAgrav = -1
                                                            Else
                                                                valor = ObtenerExpedientePadreId(valor) ' ExpedientePadreId
                                                                If valor = -1 Then
                                                                    intIDAgrav = -1
                                                                End If
                                                            End If
                                                        End While
                                                    End If
                                                Else
                                                    intIDAgrav = -1
                                                End If
                                            End If
                                        Else
                                            intIDAgrav = -1
                                        End If
                                    End While
                                    If objA.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                        conAgraAnul += 1
                                    End If
                                End If
                            End If
                        Next
                        If Me.GrillaExpedienteRefID < 1 Then
                            If conAgraviados > 0 And conAgraviados = conAgraAnul Then
                                objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                            ElseIf conAgraAnul > 0 And conAgraAnul < conAgraviados Then
                                objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                            Else
                                objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                            End If
                            objDel.Codigo = intIdDel
                            If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                                intIdDel = objBssDelito.Grabar_Anu_LM(objDel) 'guardar en BD
                            Else
                                intIdDel = objBssDelito.Grabar_Anu(objDel) 'guardar en BD
                            End If
                            '''''''''''Actualizar JEU 20042022''''''''''''''''
                            While intIdDel > 0
                                Dim entDCol As New Entity.Registro.DelitoCol
                                Dim entD As New Entity.Registro.Delito
                                entD.Codigo = intIdDel
                                entD.Estado = -1
                                entDCol = objBssDelito.Listar2(entD)
                                If entDCol.Count > 0 Then
                                    If entDCol.internoDelito(0).DocumentoTipoID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                        Select Case entDCol.internoDelito(0).DocumentoTipoID
                                            Case 19.28, 29
                                                entD = New Entity.Registro.Delito
                                                entD.InternoID = entDCol.internoDelito(0).InternoID
                                                entD.CreaDocJudicialId = entDCol.internoDelito(0).CreaDocJudicialId
                                                Dim entObjCol As Entity.Registro.DelitoCol = objBssDelito.Listar2(entD)
                                                For Each d As Entity.Registro.Delito In entObjCol
                                                    Dim delitoAux As Integer = d.Codigo
                                                    While delitoAux > 0
                                                        Dim entAgrCol As New Entity.Registro.AgraviadoCol
                                                        Dim entA As New Entity.Registro.Agraviado
                                                        entA.InternoID = entDCol.internoDelito(0).InternoID
                                                        entA.DelitoID = delitoAux  'entDCol.internoDelito(0).CodigodelitoPad
                                                        entAgrCol = objBssAgraviado.Listar(entA)

                                                        Dim conT As Integer = 0, conP As Integer = 0
                                                        For Each agr As Entity.Registro.Agraviado In entAgrCol
                                                            If agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                                                conT += 1
                                                            Else
                                                                conP += 1
                                                            End If
                                                        Next
                                                        If conP = 0 Then
                                                            entD.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                                        ElseIf conT = 0 Then
                                                            conT = Type.Enumeracion.enmEstadoAnulado.Normal
                                                        Else
                                                            entD.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                                        End If
                                                        ''entD.FlagTransferenciaSede = Me.FlagTransferSede
                                                        entD.InternoID = entDCol.internoDelito(0).InternoID
                                                        entD.Codigo = delitoAux '' entDCol.internoDelito(0).CodigodelitoPad

                                                        If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                                                            entD.FlagTransferenciaSede = Me.FlagTransferSede
                                                            objBssDelito.Grabar_Anu_LM(entD)
                                                        Else
                                                            objBssDelito.Grabar_Anu(entD)
                                                        End If

                                                        entD.Codigo = delitoAux
                                                        entD.CreaDocJudicialId = -1
                                                        Dim Col As New Entity.Registro.DelitoCol
                                                        Col = objBssDelito.Listar2(entD)
                                                        If Col.Count > 0 Then
                                                            delitoAux = Col.internoDelito(0).CodigodelitoPad
                                                        Else
                                                            delitoAux = -1
                                                        End If
                                                    End While
                                                    If delitoAux = -1 Then intIdDel = -1
                                                Next
                                            Case Else
                                                Dim entAgrCol As New Entity.Registro.AgraviadoCol
                                                Dim entA As New Entity.Registro.Agraviado
                                                entA.DelitoID = entDCol.internoDelito(0).Codigo
                                                entAgrCol = objBssAgraviado.Listar(entA)

                                                Dim conT As Integer = 0, conP As Integer = 0
                                                For Each agr As Entity.Registro.Agraviado In entAgrCol
                                                    If agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                                        conT += 1
                                                    Else
                                                        conP += 1
                                                    End If
                                                Next
                                                If conP = 0 Then
                                                    entD.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                                ElseIf conT = 0 Then
                                                    conT = Type.Enumeracion.enmEstadoAnulado.Normal
                                                Else
                                                    entD.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                                End If
                                                ''entD.FlagTransferenciaSede = Me.FlagTransferSede
                                                Dim obj As New Entity.Registro.Delito
                                                obj.Anulacion = entD.Anulacion
                                                obj.InternoID = entDCol.internoDelito(0).InternoID
                                                obj.Codigo = entDCol.internoDelito(0).Codigo

                                                If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                                                    entD.FlagTransferenciaSede = Me.FlagTransferSede
                                                    objBssDelito.Grabar_Anu_LM(obj)
                                                Else
                                                    objBssDelito.Grabar_Anu(obj)
                                                End If

                                                intIdDel = entDCol.internoDelito(0).CodigodelitoPad
                                        End Select
                                    Else 'entACol.internoDelito(0).Codigo=-1
                                        intIdDel = entDCol.internoDelito(0).CodigodelitoPad
                                    End If
                                Else
                                    intIdDel = -1
                                End If
                            End While
                            If objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                conDelAnul = conDelAnul + 1
                            ElseIf objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                                conDelAnulpar = conDelAnulpar + 1
                            End If
                        End If
                    End If
                Next
                If Me.GrillaExpedienteRefID < 1 Then
                    If conDel > 0 And conDel = conDelAnul Then  'revisar de nuevo
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                    ElseIf conDelAnul > 0 And conDelAnul < conDel Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                    ElseIf conDelAnul = 0 And conDelAnulpar > 0 Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                    Else
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                    End If
                    '*************Actualizacion anulacion Exp**********************************************
                    objExpediente.Codigo = intIdExped
                    intIdExped = objBssExp.UpdateAnulacion(objExpediente)

                    objIntExpPad = New Entity.Registro.InternoExpedientePadre
                    objIntExpPad.InternoExpedienteId = intIdExped
                    objIntExpPad.InternoID = Me._InternoId
                    Dim entExpPadCol As New Entity.Registro.InternoExpedientePadreCol
                    entExpPadCol = objBssExpPad.ListarGrilla(objIntExpPad)
                    '*******Actualizar los expedientes padres*******************
                    If entExpPadCol.Count > 0 Then
                        For Each entPad As Entity.Registro.InternoExpedientePadre In entExpPadCol

                            AnulacionExpedientesHijos(entPad.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad.DocJudTipoPadre)
                        Next
                    End If
                End If
            Next
            If Me.GrillaExpedienteRefID < 1 Then
                '********Anular documentos**************
                Dim objDocAnuCol As New Entity.Registro.DocumentoJudicialCol
                Dim objDocAnu As New Entity.Registro.DocumentoJudicial
                Dim objExpAnuCol As Entity.Registro.ExpedienteCol
                Dim objDoc As New Entity.Registro.DocumentoJudicial

                objDocAnu.InternoId = Me._InternoId
                objDocAnu.InternoIngresoId = Me._InternoIngresoId

                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or
                   Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                   Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                    objDocAnu.IngresoInpeId = Me._InternoIngresoInpeId
                    objDocAnuCol = bssDoc.ListarGrilla(objDocAnu)
                Else
                    objDocAnu.IngresoInpeId = -1
                    objDocAnuCol = bssDoc.ListarGrilla(objDocAnu)
                End If
                For Each objD As Entity.Registro.DocumentoJudicial In objDocAnuCol
                    contaT = 0
                    contaP = 0
                    contaN = 0
                    Dim objExpAnu As New Entity.Registro.Expediente
                    objExpAnu.InternoID = Me._InternoId
                    objExpAnu.IngresoID = -1 'Me._InternoIngresoId
                    objExpAnu.CreaDocJudicialId = objD.Codigo
                    objExpAnuCol = New Entity.Registro.ExpedienteCol
                    objExpAnuCol = objBssExp.Listar_v2(objExpAnu)
                    For Each objE As Entity.Registro.Expediente In objExpAnuCol
                        If objE.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                            If (objD.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes) Then
                                objBssExp.UpdateDmpSmp(objE)
                            End If
                            contaT += 1
                        ElseIf objE.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                            If (objD.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes) Then
                                objBssExp.UpdateDmpSmp(objE)
                            End If
                            contaP += 1
                        Else
                            contaN += 1
                        End If
                        If objD.InternoIngresoId <> objE.IngresoID And objD.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then

                            Dim ExpedienteIdAux As Integer = objE.Codigo
                            While ExpedienteIdAux > 0
                                objEntExpediente = New Entity.Registro.Expediente
                                objEntExpediente.InternoID = Me._InternoId
                                objEntExpediente.Codigo = ExpedienteIdAux
                                Dim objExpCol As Entity.Registro.ExpedienteCol = objBssExp.Listar_v2(objEntExpediente)
                                If objExpCol.Count > 0 Then
                                    If objExpCol.Expediente(0).DocumentoTipoID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                        objEntExpediente = New Entity.Registro.Expediente
                                        objEntExpediente.InternoID = objEntExpPadre.InternoID
                                        objEntExpediente.CreaDocJudicialId = objEntExpPadre.DocJudPadre
                                        Dim objCol As Entity.Registro.ExpedienteCol = objBssExp.Listar_v2(objEntExpediente)

                                        Dim T As Integer = 0
                                        Dim P As Integer = 0
                                        Dim N As Integer = 0
                                        For Each ent As Entity.Registro.Expediente In objCol
                                            If ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                                T = T + 1
                                            ElseIf ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                                                P = P + 1
                                            Else
                                                N = N + 1
                                            End If
                                        Next
                                        If T = 0 And P = 0 And N > 0 Then
                                            objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal  'normal
                                        ElseIf T > 0 And P = 0 And N = 0 Then
                                            objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total  ' total
                                        Else
                                            objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial
                                        End If
                                        'update
                                        Dim objDocAux As New Entity.Registro.DocumentoJudicial
                                        objDocAux.Codigo = objEntExpPadre.DocJudPadre
                                        objDocAux.Estado = objDoc.Estado
                                        ''Revisar urgente
                                        ''If objE.DocumentoTipoID <> 34 Then
                                        bssDoc.GrabarAnulacion(objDocAux)
                                        ''End If
                                    End If
                                    'Verificar si el expediente tiene padre 
                                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                                    objEntExpPadre.InternoExpedienteId = ExpedienteIdAux
                                    objEntExpPadre.InternoID = Me._InternoId
                                    objEntExpPadre = objBssExpPad.Listar(objEntExpPadre)
                                    If objEntExpPadre.InternoExpedienteRefPadreId > 0 Then
                                        ExpedienteIdAux = objEntExpPadre.InternoExpedienteRefPadreId
                                    Else
                                        ExpedienteIdAux = -1
                                    End If
                                End If
                            End While
                        End If
                    Next
                    If contaT = 0 And contaP = 0 And contaN > 0 Then
                        objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal  'normal
                    ElseIf contaT > 0 And contaP = 0 And contaN = 0 Then
                        objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total  ' total
                    ElseIf contaT = 0 And contaP > 0 Then
                        objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial
                    ElseIf contaT > 0 And contaP = 0 And contaN > 0 Then
                        objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial
                    ElseIf contaT > 0 And contaP > 0 And contaN = 0 Then
                        objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial
                    End If

                    If objD.DocumentoTipo <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                        If objDoc.Estado > Type.Enumeracion.enmEstadoDocumentoAnulado.Normal Then
                            objDoc.IdDocumentoAntecedente = DocumentoJudicialID
                        Else
                            objDoc.IdDocumentoAntecedente = -1
                        End If
                    Else
                        objDoc.IdDocumentoAntecedente = -1
                        objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal  'normal
                    End If
                    objDoc.FlagTransferenciaSede = Me.FlagTransferSede
                    If objD.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                        If objD.Codigo = Me._DocumentoJudicialID Then
                            objDoc.Codigo = objD.Codigo
                            If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                                bssDoc.GrabarAnulacion_LM(objDoc) 'guardar en BD
                            Else
                                bssDoc.GrabarAnulacion(objDoc) 'guardar en BD
                            End If
                        End If
                    Else
                        If objExpAnuCol.Count > 0 Then
                            objDoc.Codigo = objD.Codigo
                            If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                                bssDoc.GrabarAnulacion_LM(objDoc) 'guardar en BD
                            Else
                                bssDoc.GrabarAnulacion(objDoc) 'guardar en BD
                            End If
                        End If
                    End If
                Next
            End If
        End Sub
        Private Sub AGrabar_LM(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDoc As Entity.Registro.DocumentoJudicial)

            objBssExpPad = New Bussines.Registro.InternoExpedientePadre
            objBssExp = New Bussines.Registro.Expediente
            objBssAgraviado = New Bussines.Registro.InternoAgraviado

            objEntAgraviadosIndcCol = New Entity.Registro.AgraviadoCol
            objEntExpPadreCol = New Entity.Registro.InternoExpedientePadreCol

            objEntAgraviado = New Entity.Registro.Agraviado
            objEntAgraviado.InternoID = EntDoc.InternoId
            objEntAgraviado.Anulacion = -1
            objEntAgraviadosIndcCol = objBssAgraviado.Listar_ant_LM(objEntAgraviado)
            objEntExpPadre = New Entity.Registro.InternoExpedientePadre
            objEntExpPadre.InternoID = EntDoc.InternoId
            'Esto es para Provincia y PLM
            objEntExpPadreCol = objBssExpPad.ListarGrilla_LM(objEntExpPadre)

            For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol 'Empieza el bucle para registro
                Dim IdExpedienteOrig As Integer = objExpediente.Codigo
                Dim IdDocumentoOrig As Integer = objExpediente.CreaDocJudicialId
                Dim intIdExped As Integer = -1

                With objExpediente
                    If DocumentoJudicialID = IdDocumentoOrig Then
                        .Codigo = IdExpedienteOrig
                    Else
                        If .Codigo > 0 And .CreaDocJudicialId > 0 Then objBssExp.GrabarEstadoVisibilidad(.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                        .ExpedienteVisible = 1
                        .CreaDocJudicialId = DocumentoJudicialID
                        .Codigo = -1
                    End If
                End With

                If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                    objExpediente.FlagTransferenciaSede = Me.FlagTransferSede
                    intIdExped = objBssExp.Grabar_LM(objExpediente)
                Else
                    intIdExped = objBssExp.Grabar(objExpediente)
                End If
                '<---------------ExpedientePadre------------------------------
                Dim objIntExpPad As New Entity.Registro.InternoExpedientePadre
                With objIntExpPad
                    .InternoID = Me._InternoId
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .InternoExpedienteId = intIdExped
                    .InternoExpedienteRefPadreId = IdExpedienteOrig
                    .DocJudicialID = DocumentoJudicialID
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                    .FlagTransferenciaSede = Me.FlagTransferSede
                End With
                If Nuevo = True Then
                    Select Case objExpediente.DocumentoTipoID
                        Case enumTipoDocumentoJudicial.AcumulacionExpedientes,
                             enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                             enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                            objExpediente.Codigo = -1
                            objExpediente.CreaDocJudicialId = IdDocumentoOrig
                            Dim objExp_Col As Entity.Registro.ExpedienteCol = objBssExp.Listar_v2(objExpediente)
                            For Each obj As Entity.Registro.Expediente In objExp_Col
                                objBssExp.GrabarEstadoVisibilidad(obj.Codigo, False, Me.FlagTransferSede)
                                objIntExpPad.InternoExpedienteRefPadreId = obj.Codigo
                                If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                                    objBssExpPad.Grabar_LM(objIntExpPad) 'guardar en BD
                                Else
                                    objBssExpPad.Grabar(objIntExpPad) 'guardar en BD
                                End If
                            Next
                        Case Else
                            If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                                objBssExpPad.Grabar_LM(objIntExpPad) 'guardar en BD
                                objEntExpPadreCol.Add(objIntExpPad)
                            Else
                                objBssExpPad.Grabar(objIntExpPad) 'guardar en BD
                            End If
                    End Select

                Else
                    If DocumentoJudicialID <> IdDocumentoOrig Then
                        objIntExpPad.InternoExpedienteRefPadreId = IdExpedienteOrig  ' solo para la resolucion de ingreso
                        objBssExpPad.Grabar(objIntExpPad)
                        objEntExpPadreCol.Add(objIntExpPad)
                    End If
                End If

                Dim conDel As Integer = 0, conDelAnul As Integer = 0, conDelAnulpar As Integer = 0, intIdDel As Integer = -1
                '----------------------Registrar delitos-------------------------
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                    objDel.FlagTransferenciaSede = Me.FlagTransferSede
                    If objExpediente.ExpedienteItem = objDel.ExpedienteItem Then
                        conDel = conDel + 1
                        Dim codDelitoOri As Integer = objDel.Codigo
                        Dim docDelitoOri As Integer = objDel.CreaDocJudicialId
                        objDel.ExpedienteID = intIdExped  'referencia al nuevo expediente
                        objDel.CreaDocJudicialId = DocumentoJudicialID
                        objBssDelito = New Bussines.Registro.Delito
                        objBssAgraviado = New Bussines.Registro.InternoAgraviado
                        If Nuevo = True Then
                            objDel.Codigo = -1
                        Else
                            If objDel.Codigo > 0 And docDelitoOri <> DocumentoJudicialID Then
                                objDel.Codigo = -1
                            End If
                        End If
                        If codDelitoOri > 0 And docDelitoOri <> DocumentoJudicialID Then
                            objDel.CodigodelitoPad = codDelitoOri
                        End If

                        objDel.IngresoInpeId = objExpediente.IngresoInpeId
                        intIdDel = objBssDelito.Grabar_LM(objDel) 'guardar en BD PLM

                        Dim intIDAgrav As Integer = -1, conAgraviados As Integer = 0, conAgraAnul As Integer = 0
                        If Me.GrillaExpedienteRefID < 1 Then
                            For Each objA As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                                objA.FlagTransferenciaSede = Me.FlagTransferSede
                                If objDel.DelitoItem = objA.DelitoItem Then
                                    conAgraviados = conAgraviados + 1
                                    Dim codAgraviadoOri As Integer = objA.Codigo
                                    Dim creaAgraviadoOri As Integer = objA.CreaDocJudicialId
                                    objA.DelitoID = intIdDel
                                    objA.CreaDocJudicialId = DocumentoJudicialID
                                    objA.ExpedienteID = intIdExped
                                    objA.TipoSentenciaId = IIf(objA.TipoSentenciaId = 0, -1, objA.TipoSentenciaId)
                                    objA.TipoSentenciaHistoricoId = IIf(objA.TipoSentenciaHistoricoId = 0, -1, objA.TipoSentenciaHistoricoId)
                                    objA.RegionID = Me._RegionID
                                    objA.PenalID = Me._PenalID
                                    If Nuevo = True Then
                                        objA.Codigo = -1
                                    Else
                                        If objA.Codigo > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                            objA.Codigo = -1
                                        End If
                                    End If
                                    If codAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                        objA.CodigoagraviadoPad = codAgraviadoOri
                                    End If

                                    objA.IngresoInpeId = objExpediente.IngresoInpeId
                                    intIDAgrav = objBssAgraviado.Grabar_LM(objA) 'guardar en BD
                                    Dim obj As New Entity.Registro.Agraviado
                                    obj = objA
                                    obj.Codigo = intIDAgrav
                                    objEntAgraviadosIndcCol.Add(obj)
                                    ''-----------------Fin de registro de Agraviados--''IMPLEMENTACION JEU 21/11/2018''''''''''''''''''''''''''''''''''''''''
                                    Dim ExpedienteAuxiliar As Integer = objA.ExpedienteID
                                    Dim AgraviadoTipoDoc As Integer = objA.DocumentoTipoID
                                    Dim AgraviadoPadreId As Integer = objA.CodigoagraviadoPad
                                    intIDAgrav = AgraviadoPadreId
                                    While intIDAgrav > 0
                                        Dim entA As New Entity.Registro.Agraviado
                                        Dim AgraviadoId As Integer = intIDAgrav
                                        If AgraviadoId > 0 Then
                                            obj = New Entity.Registro.Agraviado
                                            obj = ObtenerAgraviadoCodigo(intIDAgrav, 1, objA.AgraviadoNombre, ExpedienteAuxiliar, objDel.DelitoEspecifico, AgraviadoPadreId)
                                            entA.Anulacion = objA.Anulacion
                                            entA.Codigo = AgraviadoId
                                            If obj.DocumentoTipoID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                                objBssAgraviado.GrabarEstado(entA)
                                                GrabarAgraviadoTemporalEstado(AgraviadoId, objA.Anulacion)
                                            End If
                                            ExpedienteAuxiliar = obj.ExpedienteID
                                            ExpedienteAuxiliar = ObtenerExpedientePadreId(ExpedienteAuxiliar)
                                            If ExpedienteAuxiliar > 0 Then
                                                Dim obj1 As Entity.Registro.Agraviado = ObtenerAgraviadoCodigo(intIDAgrav, 3, objA.AgraviadoNombre, ExpedienteAuxiliar, objDel.DelitoEspecifico, AgraviadoPadreId)
                                                AgraviadoId = obj1.Codigo
                                                AgraviadoTipoDoc = obj1.DocumentoTipoID
                                                AgraviadoPadreId = obj1.CodigoagraviadoPad
                                                ExpedienteAuxiliar = obj1.ExpedienteID
                                                If AgraviadoId > 0 Then
                                                    intIDAgrav = AgraviadoId
                                                Else
                                                    Dim ExpedientePadreId As Integer = ObtenerExpedientePadreId(ExpedienteAuxiliar)
                                                    If ExpedientePadreId > 0 Then
                                                        obj = New Entity.Registro.Agraviado
                                                        obj = ObtenerAgraviadoCodigo(-1, 3, objA.AgraviadoNombre, ExpedientePadreId, objDel.DelitoEspecifico, objA.CodigoagraviadoPad)
                                                        AgraviadoId = obj.Codigo
                                                        AgraviadoTipoDoc = obj.DocumentoTipoID
                                                        If AgraviadoId > 0 Then
                                                            intIDAgrav = AgraviadoId
                                                        Else
                                                            Dim valor As Integer = ExpedientePadreId
                                                            While valor > 0 Or AgraviadoId > 0
                                                                ExpedientePadreId = ObtenerExpedientePadreId(valor)
                                                                obj = New Entity.Registro.Agraviado
                                                                obj = ObtenerAgraviadoCodigo(-1, 3, objA.AgraviadoNombre, ExpedientePadreId, objDel.DelitoEspecifico, objA.CodigoagraviadoPad)
                                                                AgraviadoId = obj.Codigo
                                                                AgraviadoTipoDoc = obj.DocumentoTipoID
                                                                If AgraviadoId > 0 Then
                                                                    intIDAgrav = AgraviadoId
                                                                    valor = -1
                                                                    AgraviadoId = -1
                                                                Else
                                                                    valor = ObtenerExpedientePadreId(valor) ' ExpedientePadreId
                                                                    If valor = -1 Then
                                                                        intIDAgrav = -1
                                                                    End If
                                                                End If
                                                            End While
                                                        End If
                                                    Else
                                                        intIDAgrav = -1
                                                    End If
                                                End If
                                            Else
                                                intIDAgrav = -1
                                            End If
                                        Else
                                            intIDAgrav = -1
                                        End If
                                    End While
                                    If objA.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                        conAgraAnul += 1
                                    End If
                                End If
                            Next
                            '-----------------------------------------
                            If conAgraviados > 0 And conAgraviados = conAgraAnul Then
                                objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                            ElseIf conAgraAnul > 0 And conAgraAnul < conAgraviados Then
                                objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                            Else
                                objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                            End If
                            objDel.Codigo = intIdDel
                            If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                                intIdDel = objBssDelito.Grabar_Anu_LM(objDel) 'guardar en BD
                            Else
                                intIdDel = objBssDelito.Grabar_Anu(objDel) 'guardar en BD
                            End If
                            ''-----------------------------------------
                            Dim objDelColAux As New Entity.Registro.DelitoCol
                            Dim EstadoAnuId As Integer = objDel.Anulacion
                            Dim ob As New Entity.Registro.Delito
                            Select Case objExpediente.DocumentoTipoID

                                Case enumTipoDocumentoJudicial.Refundicion_de_Sentencia, enumTipoDocumentoJudicial.Sumatoria_de_Sentencia, enumTipoDocumentoJudicial.AcumulacionExpedientes
                                    Dim strCodigosDelitos() As String = (objDel.strCodigodelitoPad).Split(",")
                                    For i As Integer = 0 To strCodigosDelitos.Length - 1
                                        ob = New Entity.Registro.Delito
                                        ob.Codigo = strCodigosDelitos(i)
                                        objDelColAux.Add(ob)
                                    Next
                                Case Else
                                    intIdDel = objDel.CodigodelitoPad
                                    ob = New Entity.Registro.Delito
                                    ob.Codigo = intIdDel
                                    objDelColAux.Add(ob)
                            End Select
                            ''-----------------------------------------
                            For Each objDelAux As Entity.Registro.Delito In objDelColAux
                                intIdDel = objDelAux.Codigo
                                While intIdDel > 0
                                    Dim codDelito = -1, codDelitoPadre = -1
                                    Dim entDCol As New Entity.Registro.DelitoCol
                                    objEntDelito = New Entity.Registro.Delito
                                    objEntDelito.Codigo = intIdDel
                                    entDCol = objBssDelito.Listar2_LM(objEntDelito)

                                    Dim entAgrCol As New Entity.Registro.AgraviadoCol
                                    objEntAgraviado = New Entity.Registro.Agraviado
                                    If entDCol.Count > 0 Then
                                        Select Case entDCol.internoDelito(0).DocumentoTipoID
                                            Case enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                                                 enumTipoDocumentoJudicial.Sumatoria_de_Sentencia,
                                                 enumTipoDocumentoJudicial.AcumulacionExpedientes
                                                codDelito = -1
                                                codDelitoPadre = -1
                                                Dim entAuxiliarCol As New Entity.Registro.DelitoCol
                                                objEntDelito = New Entity.Registro.Delito
                                                objEntDelito.CreaDocJudicialId = entDCol.internoDelito(0).CreaDocJudicialId
                                                entAuxiliarCol = objBssDelito.Listar2_LM(objEntDelito)
                                                For Each oD As Entity.Registro.Delito In entAuxiliarCol
                                                    intIdDel = oD.Codigo
                                                    While intIdDel > 0
                                                        Dim entD2Col As New Entity.Registro.DelitoCol
                                                        objEntDelito = New Entity.Registro.Delito
                                                        objEntDelito.Codigo = intIdDel
                                                        entD2Col = objBssDelito.Listar2_LM(objEntDelito)
                                                        Dim codigo As Integer = entD2Col.internoDelito(0).Codigo

                                                        objEntAgraviado.DelitoEspecificoID = oD.DelitoEspecifico
                                                        objEntAgraviado.DelitoID = codigo
                                                        entAgrCol = objBssAgraviado.Listar_v3(objEntAgraviado)

                                                        Dim conT As Integer = 0, conN As Integer = 0
                                                        For Each agr As Entity.Registro.Agraviado In entAgrCol
                                                            If agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                                                conT += 1
                                                            Else
                                                                conN += 1
                                                            End If
                                                        Next
                                                        If entAgrCol.Count = 0 Then '(conT=0,conN=0)
                                                            objEntDelito.Anulacion = -1
                                                        ElseIf conN = 0 And conT > 0 Then
                                                            objEntDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                                        ElseIf conN > 0 And conT = 0 Then
                                                            objEntDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                                        Else
                                                            objEntDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                                        End If
                                                        objEntDelito.InternoID = Me._InternoId
                                                        objEntDelito.Codigo = intIdDel
                                                        'Grabar delito
                                                        objEntDelito.FlagTransferenciaSede = Me.FlagTransferSede
                                                        objBssDelito.Grabar_Anu_LM(objEntDelito)
                                                        intIdDel = entD2Col.internoDelito(0).CodigodelitoPad
                                                    End While
                                                Next
                                            Case Else
                                                If entDCol.internoDelito(0).Codigo > 0 Then ' And entDCol.internoDelito(0).DocumentoTipoID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                                    objEntAgraviado.DelitoEspecificoID = entDCol.internoDelito(0).DelitoEspecifico
                                                    objEntAgraviado.DelitoID = entDCol.internoDelito(0).Codigo
                                                    entAgrCol = objBssAgraviado.Listar_v3(objEntAgraviado)

                                                    If entAgrCol.Count = 0 Then
                                                        codDelito = entDCol.internoDelito(0).Codigo
                                                        codDelitoPadre = entDCol.internoDelito(0).CodigodelitoPad

                                                        objEntDelito.Anulacion = EstadoAnuId
                                                        objEntDelito.InternoID = Me._InternoId
                                                        objEntDelito.Codigo = codDelito

                                                        EstadoAnuId = entDCol.internoDelito(0).Anulacion
                                                    Else
                                                        codDelito = entDCol.internoDelito(0).Codigo
                                                        codDelitoPadre = entDCol.internoDelito(0).CodigodelitoPad
                                                        EstadoAnuId = entDCol.internoDelito(0).Anulacion

                                                        Dim conT As Integer = 0, conN As Integer = 0
                                                        For Each agr As Entity.Registro.Agraviado In entAgrCol
                                                            If agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                                                conT += 1
                                                            Else
                                                                conN += 1
                                                            End If
                                                        Next
                                                        If entAgrCol.Count = 0 Then '(conT=0,conN=0)
                                                            objEntDelito.Anulacion = -1
                                                        ElseIf conN = 0 And conT > 0 Then
                                                            objEntDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                                        ElseIf conN > 0 And conT = 0 Then
                                                            objEntDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                                        Else
                                                            objEntDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                                        End If
                                                        objEntDelito.InternoID = Me._InternoId
                                                        objEntDelito.Codigo = codDelito
                                                    End If
                                                    'Grabar delito
                                                    objEntDelito.FlagTransferenciaSede = Me.FlagTransferSede
                                                    objBssDelito.Grabar_Anu_LM(objEntDelito)
                                                    intIdDel = codDelitoPadre

                                                Else 'entACol.internoDelito(0).Codigo=-1
                                                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                                                    objEntExpPadre.InternoExpedienteId = entDCol.internoDelito(0).ExpedienteID
                                                    objEntExpPadre.InternoID = Me._InternoId
                                                    objEntExpPadre.IngresoInpeId = objExpediente.IngresoInpeId
                                                    Dim expId As Integer = objBssExpPad.Listar_LM(objEntExpPadre).InternoExpedienteRefPadreId
                                                    If expId > 0 Then
                                                        objDel = New Entity.Registro.Delito
                                                        objDel.DelitoEspecifico = entDCol.internoDelito(0).DelitoEspecifico
                                                        objDel.ExpedienteID = entDCol.internoDelito(0).ExpedienteID
                                                        objDel = objBssDelito.Listar2_LM(objDel).internoDelito(0)
                                                        codDelito = objDel.Codigo
                                                        codDelitoPadre = objDel.CodigodelitoPad
                                                        intIdDel = entDCol.internoDelito(0).CodigodelitoPad

                                                        entAgrCol = New Entity.Registro.AgraviadoCol
                                                        objEntAgraviado = New Entity.Registro.Agraviado
                                                        objEntAgraviado.DelitoEspecificoID = entDCol.internoDelito(0).DelitoEspecifico
                                                        objEntAgraviado.DelitoID = codDelito
                                                        entAgrCol = objBssAgraviado.Listar_v3(objEntAgraviado)

                                                        If entAgrCol.Count > 0 Then
                                                            Dim conT As Integer = 0, conP As Integer = 0

                                                            For Each agr As Entity.Registro.Agraviado In entAgrCol
                                                                If agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                                                    conT += 1
                                                                Else
                                                                    conP += 1
                                                                End If
                                                            Next
                                                            If conP = 0 Then
                                                                objEntDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                                            ElseIf conT = 0 Then
                                                                conT = Type.Enumeracion.enmEstadoAnulado.Normal
                                                            Else
                                                                objEntDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                                            End If
                                                            objEntDelito.InternoID = Me._InternoId
                                                            objEntDelito.Codigo = codDelito
                                                            objEntDelito.FlagTransferenciaSede = Me.FlagTransferSede
                                                            objBssDelito.Grabar_Anu_LM(objEntDelito)

                                                            intIdDel = codDelitoPadre
                                                        Else
                                                            intIdDel = -1
                                                        End If
                                                    Else
                                                        intIdDel = -1
                                                    End If
                                                End If
                                        End Select
                                    Else
                                        intIdDel = -1
                                    End If
                                End While
                            Next
                            If objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                conDelAnul = conDelAnul + 1
                            ElseIf objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                                conDelAnulpar = conDelAnulpar + 1
                            End If
                        End If
                    End If
                Next
                If Me.GrillaExpedienteRefID < 1 Then
                    If conDel > 0 And conDel = conDelAnul Then  'revisar de nuevo
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                    ElseIf conDelAnul > 0 And conDelAnul < conDel Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                    ElseIf conDelAnul = 0 And conDelAnulpar > 0 Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                    Else
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                    End If
                    '*************Actualizacion anulacion Exp**********************************************
                    objExpediente.Codigo = intIdExped
                    intIdExped = objBssExp.UpdateAnulacion(objExpediente)

                    objIntExpPad = New Entity.Registro.InternoExpedientePadre
                    objIntExpPad.InternoExpedienteId = intIdExped
                    objIntExpPad.InternoID = Me._InternoId
                    Dim entExpPadCol As New Entity.Registro.InternoExpedientePadreCol
                    entExpPadCol = objBssExpPad.ListarGrilla(objIntExpPad)
                    '*******Actualizar los expedientes padres*******************
                    If entExpPadCol.Count > 0 Then
                        For Each entPad As Entity.Registro.InternoExpedientePadre In entExpPadCol

                            AnulacionExpedientesHijos(entPad.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad.DocJudTipoPadre)
                        Next
                    End If
                End If
            Next
            If Me.GrillaExpedienteRefID < 1 Then
                '********Anular Documentos Judiciales**************
                Dim objExpAnuCol As New Entity.Registro.ExpedienteCol
                Dim objDoc As New Entity.Registro.DocumentoJudicial
                Dim objExpAnu As New Entity.Registro.Expediente
                Dim objEntExpedienteCol As New Entity.Registro.ExpedienteCol

                objExpAnu.InternoID = Me._InternoId
                objExpAnu.CreaDocJudicialId = DocumentoJudicialID
                objExpAnuCol = objBssExp.Listar_v2(objExpAnu)

                For Each objE As Entity.Registro.Expediente In objExpAnuCol
                    Dim valor As Integer = objE.Codigo
                    While valor > 0
                        objEntExpPadreCol = New Entity.Registro.InternoExpedientePadreCol
                        objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                        objEntExpPadre.InternoExpedienteId = valor
                        objEntExpPadreCol = objBssExpPad.ListarGrilla_LM(objEntExpPadre)
                        If objEntExpPadreCol.Count = 1 Then
                            objEntExpediente = New Entity.Registro.Expediente
                            objEntExpediente.CreaDocJudicialId = objEntExpPadreCol.InternoExpedientePadre(0).DocJudPadre
                            objEntExpediente.DocumentoTipoID = objEntExpPadreCol.InternoExpedientePadre(0).DocJudTipoPadre
                            valor = objEntExpPadreCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                            If objEntExpediente.CreaDocJudicialId = -1 Then Continue While
                            objEntExpedienteCol.Add(objEntExpediente)
                        ElseIf objEntExpPadreCol.Count > 1 Then
                            For Each obj As Entity.Registro.InternoExpedientePadre In objEntExpPadreCol
                                objEntExpediente = New Entity.Registro.Expediente
                                objEntExpediente.CreaDocJudicialId = obj.DocJudPadre
                                objEntExpediente.DocumentoTipoID = obj.DocJudTipoPadre
                                Dim subValor As Integer = obj.InternoExpedienteRefPadreId
                                objEntExpedienteCol.Add(objEntExpediente)
                                ''---------------------------------------
                                While subValor > 0
                                    objEntExpPadreCol = New Entity.Registro.InternoExpedientePadreCol
                                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                                    objEntExpPadre.InternoExpedienteId = subValor
                                    objEntExpPadreCol = objBssExpPad.ListarGrilla_LM(objEntExpPadre)
                                    If objEntExpPadreCol.Count = 1 Then
                                        objEntExpediente = New Entity.Registro.Expediente
                                        objEntExpediente.CreaDocJudicialId = objEntExpPadreCol.InternoExpedientePadre(0).DocJudPadre
                                        objEntExpediente.DocumentoTipoID = objEntExpPadreCol.InternoExpedientePadre(0).DocJudTipoPadre
                                        subValor = objEntExpPadreCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                                        objEntExpedienteCol.Add(objEntExpediente)
                                    ElseIf objEntExpPadreCol.Count > 1 Then
                                        For Each obj1 As Entity.Registro.InternoExpedientePadre In objEntExpPadreCol
                                            objEntExpediente = New Entity.Registro.Expediente
                                            objEntExpediente.CreaDocJudicialId = obj1.DocJudPadre
                                            objEntExpediente.DocumentoTipoID = obj1.DocJudTipoPadre
                                            Dim subValor3 As Integer = obj1.InternoExpedienteRefPadreId
                                            objEntExpedienteCol.Add(objEntExpediente)
                                            ''-----------------------------
                                            While subValor3 > 0
                                                Dim objEntExpPadreCol2 As New Entity.Registro.InternoExpedientePadreCol
                                                objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                                                objEntExpPadre.InternoExpedienteId = subValor3
                                                objEntExpPadreCol2 = objBssExpPad.ListarGrilla_LM(objEntExpPadre)
                                                If objEntExpPadreCol2.Count = 1 Then
                                                    objEntExpediente = New Entity.Registro.Expediente
                                                    objEntExpediente.CreaDocJudicialId = objEntExpPadreCol2.InternoExpedientePadre(0).DocJudPadre
                                                    objEntExpediente.DocumentoTipoID = objEntExpPadreCol2.InternoExpedientePadre(0).DocJudTipoPadre
                                                    subValor3 = objEntExpPadreCol2.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                                                    objEntExpedienteCol.Add(objEntExpediente)
                                                Else
                                                    subValor3 = -1
                                                    subValor = subValor3
                                                    valor = subValor
                                                End If
                                            End While
                                        Next
                                    Else
                                        subValor = -1
                                        valor = subValor
                                    End If
                                End While
                            Next
                        Else
                            valor = -1
                        End If
                    End While
                Next
                For Each objE1 As Entity.Registro.Expediente In objEntExpedienteCol
                    contaT = 0
                    contaP = 0
                    contaN = 0
                    Dim DocumentoTipo As Integer = objE1.DocumentoTipoID
                    objExpAnuCol = New Entity.Registro.ExpedienteCol
                    objExpAnuCol = objBssExp.ListarExpedientexResolucion(objE1.CreaDocJudicialId)
                    For Each objE As Entity.Registro.Expediente In objExpAnuCol
                        If objE.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                            contaT += 1
                        ElseIf objE.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                            contaP += 1
                        Else
                            contaN += 1
                        End If
                    Next
                    If contaT = 0 And contaP = 0 And contaN > 0 Then
                        objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal  'normal
                    ElseIf contaT > 0 And contaP = 0 And contaN = 0 Then
                        objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total  ' total
                    ElseIf contaT = 0 And contaP > 0 Then
                        objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial
                    ElseIf contaT > 0 And ((contaP = 0 And contaN > 0) Or (contaP > 0 And contaN = 0)) Then
                        objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial
                    End If

                    If DocumentoTipo <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                        If objDoc.Estado <> Type.Enumeracion.enmEstadoDocumentoAnulado.Normal Then
                            objDoc.IdDocumentoAntecedente = DocumentoJudicialID
                        End If
                        objDoc.Codigo = objE1.CreaDocJudicialId
                        bssDoc.GrabarAnulacion_LM(objDoc) 'guardar en BD
                    End If
                Next


            End If
        End Sub

        Private Function ObtenerAgraviadoCodigo(intIDAgrav As Integer, condicion As Integer, nombre As String, expedienteId As Integer, especificoId As Integer, CodigoPadre As Integer) As Entity.Registro.Agraviado
            Dim value As New Entity.Registro.Agraviado
            If condicion = 3 Then
                Dim blnvalor As Boolean = True
                For Each obj As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                    If obj.AgraviadoNombre = nombre And obj.ExpedienteID = expedienteId And obj.DelitoEspecificoID = especificoId Then
                        value = obj
                        blnvalor = False
                        Exit For
                    End If
                Next
                If CodigoPadre > 0 And blnvalor = True Then
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                        If obj.Codigo = CodigoPadre And obj.DelitoEspecificoID = especificoId Then 'And obj.ExpedienteID = expedienteId
                            value = obj
                            blnvalor = False
                            Exit For
                        End If
                    Next
                End If
            Else
                For Each obj As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                    If obj.Codigo = intIDAgrav Then
                        If condicion = 1 Then
                            value = obj
                        ElseIf condicion = 2 Then
                            value = obj
                        End If
                        Exit For
                    End If
                Next
            End If
            Return value
        End Function
        Private Function ObtenerExpedientePadreId(expedienteId As Integer) As Integer
            Dim value As Integer = -1
            If expedienteId > 0 Then
                For Each f As Entity.Registro.InternoExpedientePadre In objEntExpPadreCol
                    If f.InternoExpedienteId = expedienteId Then
                        value = f.InternoExpedienteRefPadreId
                        Exit For
                    End If
                Next
            End If
            Return value
        End Function
        Private Function GrabarAgraviadoTemporalEstado(AgraviadoId As Integer, estadoId As Integer) As Integer
            Dim value As Integer = -1
            If AgraviadoId > 0 Then
                For Each f As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                    If f.Codigo = AgraviadoId Then
                        f.Estado = estadoId
                        value = AgraviadoId
                        Exit For
                    End If
                Next
            End If
            Return value
        End Function
        Dim contaT As Integer = 0, contaP As Integer = 0, contaN As Integer = 0
        Private Sub AnulacionExpedientesHijos(IndexExpe As Integer, objExpediente As Entity.Registro.Expediente, DocumentoJudicialID As Integer, TipoDocID As Integer)
            Dim objExpPad As Entity.Registro.InternoExpedientePadre
            Dim objEntPadCol As Entity.Registro.InternoExpedientePadreCol
            Dim contaTot = 0, contaPar = 0, contaNor = 0
            Dim entDcol As Entity.Registro.DelitoCol
            Dim entD As Entity.Registro.Delito

            While IndexExpe > 0
                entD = New Entity.Registro.Delito
                objExpediente.Codigo = IndexExpe
                entD.ExpedienteID = IndexExpe

                If TipoDocID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    entDcol = New Entity.Registro.DelitoCol
                    entDcol = objBssDelito.Listar2(entD)
                    contaT = 0
                    contaP = 0
                    contaN = 0
                    For Each ent As Entity.Registro.Delito In entDcol
                        If ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                            contaT += 1
                        ElseIf ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                            contaN += 1
                        Else
                            contaP += 1
                        End If
                    Next
                    If contaP = 0 And contaN = 0 Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                    ElseIf contaP = 0 And contaT = 0 Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                    Else
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                    End If
                    'objExpediente.FlagTransferenciaSede = Me.FlagTransferSede
                    IndexExpe = objBssExp.UpdateAnulacion(objExpediente)

                    objEntPadCol = New Entity.Registro.InternoExpedientePadreCol
                    objExpPad = New Entity.Registro.InternoExpedientePadre
                    objExpPad.InternoExpedienteId = IndexExpe
                    objEntPadCol = objBssExpPad.ListarGrilla(objExpPad)
                    If objEntPadCol.Count = 0 Then
                        IndexExpe = -1
                    ElseIf objEntPadCol.Count = 1 Then
                        IndexExpe = objEntPadCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                        TipoDocID = objEntPadCol.InternoExpedientePadre(0).DocJudTipoPadre
                    Else
                        For Each entPad As Entity.Registro.InternoExpedientePadre In objEntPadCol
                            AnulacionExpedientesHijosBucle(entPad.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad.DocJudTipoPadre)
                        Next
                        IndexExpe = -1
                    End If
                Else
                    objExpPad = New Entity.Registro.InternoExpedientePadre
                    objExpPad.InternoExpedienteId = IndexExpe
                    objExpPad.InternoID = Me._InternoId
                    objEntPadCol = New Entity.Registro.InternoExpedientePadreCol
                    objEntPadCol = objBssExpPad.ListarGrilla(objExpPad)
                    If objEntPadCol.Count = 0 Then
                        IndexExpe = -1
                    ElseIf objEntPadCol.Count = 1 Then
                        IndexExpe = objEntPadCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                        TipoDocID = objEntPadCol.InternoExpedientePadre(0).DocJudTipoPadre
                    Else ' mas de un hijo
                        For Each entPad As Entity.Registro.InternoExpedientePadre In objEntPadCol
                            AnulacionExpedientesHijosBucle(entPad.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad.DocJudTipoPadre)
                        Next
                        IndexExpe = -1
                    End If
                End If
            End While
        End Sub
        Private Sub AnulacionExpedientesHijosBucle(Index As Integer, objExpediente As Entity.Registro.Expediente, DocumentoJudicialID As Integer, TipoDocID As Integer)
            Dim entD As Entity.Registro.Delito
            Dim entDcol As Entity.Registro.DelitoCol
            Dim entPadCol As Entity.Registro.InternoExpedientePadreCol
            Dim entPad As Entity.Registro.InternoExpedientePadre
            While Index > 0
                entD = New Entity.Registro.Delito
                entD.ExpedienteID = Index
                entDcol = New Entity.Registro.DelitoCol
                entDcol = objBssDelito.Listar2(entD)
                contaT = 0
                contaP = 0
                contaN = 0

                For Each ent As Entity.Registro.Delito In entDcol
                    If ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                        contaT += 1
                    ElseIf ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                        contaN += 1
                    Else
                        contaP += 1
                    End If
                Next
                If contaP = 0 And contaN = 0 Then
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                ElseIf contaP = 0 And contaT = 0 Then
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                Else
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                End If
                objExpediente.Codigo = Index
                'objExpediente.FlagTransferenciaSede = Me.FlagTransferSede
                Index = objBssExp.UpdateAnulacion(objExpediente)
                entPadCol = New Entity.Registro.InternoExpedientePadreCol
                entPad = New Entity.Registro.InternoExpedientePadre
                entPad.InternoExpedienteId = Index
                entPadCol = objBssExpPad.ListarGrilla(entPad)
                If entPadCol.Count = 0 Then
                    Index = -1
                ElseIf entPadCol.Count = 1 Then
                    Index = entPadCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                Else
                    For Each entPad_ As Entity.Registro.InternoExpedientePadre In entPadCol
                        AnulacionExpedientesHijos(entPad_.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad_.DocJudTipoPadre)
                    Next
                    Index = -1
                End If
            End While
        End Sub

        Private Sub AGrabarDocumento(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDoc As Entity.Registro.DocumentoJudicial)
            If Not (objDocumJudicialCol Is Nothing) Then
                bssDoc = New Bussines.Registro.DocumentoJudicial
                For Each obj As Entity.Registro.DocumentoJudicial In objDocumJudicialCol
                    Select Case obj.DocumentoTipo
                        Case 5, 15
                            objDocumJudicial = New Entity.Registro.DocumentoJudicial
                            With objDocumJudicial
                                .FlagTransferenciaSede = Me.FlagTransferSede
                                .IdDocumentoAntecedente = DocumentoJudicialID
                                .Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total
                                .Codigo = obj.Codigo
                                .InternoId = Me._InternoId
                                .InternoIngresoId = Me._InternoIngresoId
                                ._RegionID = Me._RegionID
                                ._PenalID = Me._PenalID
                            End With
                            bssDoc.GrabarAnulacion(objDocumJudicial)
                    End Select
                Next
            End If
        End Sub
        Private Function AEliminarDocumentoBD(Codigo As Integer) As Integer
            Dim value As Integer = -1
            If Codigo > 0 Then
                Dim bss As New Bussines.Registro.DocumentoJudicial
                value = bss.Eliminar(Codigo, -1, -1, -1, -1, "", Me.FlagTransferSede)
            End If
            Return value

        End Function
        Private Function AEliminarAgraviadoBD(Codigo As Integer) As Integer
            Dim value As Integer = -1
            If Codigo > 0 Then
                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                value = objBssAgraviado.Eliminar(Codigo, Me.FlagTransferSede)
            End If
            Return value

        End Function
        Private Function AEliminarDelitoBD(Codigo As Integer) As Integer
            Dim value As Integer = -1
            If Codigo > 0 Then value = (New Bussines.Registro.Delito).Eliminar2(Codigo, Me.FlagTransferSede)
            Return value
        End Function

        Private Function AEliminarExpedienteBD(Codigo As Integer) As Integer
            'falta referenciar al padre
            Dim CodigoPadreId As Integer = -1
            If Codigo > 0 Then
                objBssExpPad = New Bussines.Registro.InternoExpedientePadre
                objBssExp = New Bussines.Registro.Expediente

                Dim obj As New Entity.Registro.InternoExpedientePadre
                obj.InternoExpedienteId = Codigo
                obj.InternoID = Me._InternoId
                CodigoPadreId = objBssExpPad.Listar_LM(obj).InternoExpedienteRefPadreId

                objBssExp.Eliminar2(Codigo, Me.FlagTransferSede)
                If CodigoPadreId > 0 Then
                    objBssExp.GrabarEstadoVisibilidad(CodigoPadreId, 1, Me.FlagTransferSede)
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    objEntExpPadre.InternoExpedienteRefPadreId = CodigoPadreId
                    objBssExpPad.Eliminar(objEntExpPadre, Me.FlagTransferSede)
                End If
            End If
            Return CodigoPadreId

        End Function

#End Region

#Region "Otros"
        Private Sub ValoresxDefault()
            objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
            objEntDelitoTempoCol = New Entity.Registro.DelitoCol
            objEntAgraviadoTempoCol = New Entity.Registro.AgraviadoCol
        End Sub

#End Region

        Private Sub dgwExpediente_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellClick
            If dgwExpediente.Rows.Count > 0 Then

                Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))

            End If
        End Sub
        Private Sub dgwExpediente_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellDoubleClick
            btnEditExpe_Click(Nothing, Nothing)
        End Sub

        Private Sub btnEditExpe_Click(sender As System.Object, e As System.EventArgs) Handles btnEditExpe.Click
            If dgwExpediente.Rows.Count = 0 Then Exit Sub
            RaiseEvent _Click_Expediente_Editar(Me.objEntExpedienteTempoCol.Expediente(Me.dgwExpediente.SelectedRows(0).Index))
        End Sub

        Private Sub btnEliminarExp_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarExp.Click
            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un expediente para eliminar.")
                btnAddExp.Focus()
            End If
            Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)
            If chkLista.Checked = True Then
                chkLista.Checked = False
                lblDelitosAgraviados.Text = "Delitos/Agraviados"
            End If
        End Sub

        Private Sub btnAddExp_Click(sender As System.Object, e As System.EventArgs) Handles btnAddExp.Click
            If Me._DocumentoJudicialID > 1 Then
                If ValidarExpedienteReferenciado(1) = False Then
                    Exit Sub
                End If
            End If
            RaiseEvent _Click_Expediente_Agregar()
        End Sub

        Private Sub btnAddDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnAddDelito.Click
            If Me._DocumentoJudicialID > 1 Then
                If ValidarExpedienteReferenciado(2) = False Then
                    Exit Sub
                End If
            End If
            If dgwExpediente.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe existir al menos un expediente para ingresar un delito.")
                Exit Sub
            End If
            bolEdicionActivo = False
            If objEntDelitoTempoColGrilla Is Nothing Then
                objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
            End If
            RaiseEvent _Click_Delito_Agregar(objEntExpedienteTempoCol.Item(Me.dgwExpediente.SelectedRows(0).Index), objEntDelitoTempoColGrilla)

            bolEdicionActivo = True
        End Sub

        Private Sub btnDelDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnDelDelito.Click
            If dgwDelito.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un delito para eliminar.")
                btnAddDelito.Focus()
            End If
            Temporal_EliminarExpediente_Delito_Agraviado(False, True, False)
            dgwExpediente_CellClick(Nothing, Nothing)
            bolEdicionActivo = True
        End Sub

        Private Sub btnEditDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnEditDelito.Click
            bolEdicionActivo = False
            Temporal_Delito_Modificar()
            bolEdicionActivo = True
        End Sub

        Private Sub dgwDelito_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellClick
            If dgwDelito.Columns(e.ColumnIndex).Name = "col_est_anu" Then
                For Each entAgrav As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If entAgrav.AgraviadoItem = dgwDelito.SelectedRows(0).Cells("col_agrav_item").Value Then
                        If entAgrav.AnulacionAux = True Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El agraviado esta anulado, por un expediente.")
                        ElseIf Me.GrillaExpedienteRefID > 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El agraviado / delito, ha sido referenciado por un expediente.")
                        Else
                            entAgrav.Anulacion = IIf(dgwDelito.Item("col_est_anu", e.RowIndex).Value = True, Type.Enumeracion.enmEstadoAnulado.Anulado_total, Type.Enumeracion.enmEstadoAnulado.Normal)
                        End If

                    End If
                Next
            End If
        End Sub

        Private Sub dgwDelito_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellDoubleClick
            Dim columnIndex As Integer = e.ColumnIndex
            ' Obtenemos el nombre de la columna
            ' correspondiente a la celda
            Dim columnName As String = dgwDelito.Columns.Item(columnIndex).Name
            If columnName = "col_tip_sent" Or columnName = "col_tip_sent" Then
            Else
                btnEditDelito_Click(Nothing, Nothing)
            End If
        End Sub

        Public Sub New()
            InitializeComponent()
            ValoresxDefault()
        End Sub

        Private Sub dgwDelito_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellValueChanged
            If e.ColumnIndex = -1 Or e.RowIndex = -1 Or bolEdicionActivo = False Then Exit Sub
            With dgwDelito
                If dgwDelito.Columns(e.ColumnIndex).Name = "col_tip_sent" Then
                    For Each entAgrav As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If entAgrav.AgraviadoItem = dgwDelito.Item("col_agrav_item", e.RowIndex).Value Then entAgrav.TipoSentenciaId = dgwDelito.Item("col_tip_sent", e.RowIndex).Value
                    Next
                End If
                If dgwDelito.Columns(e.ColumnIndex).Name = "col_nro" Then
                    For Each entAgrav As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If entAgrav.AgraviadoItem = dgwDelito.Item("col_agrav_item", e.RowIndex).Value Then entAgrav.Anulacion = dgwDelito.Item("col_nro", e.RowIndex).Value
                    Next
                End If
                If .Columns(e.ColumnIndex).Name = "col_est_anu" Then
                    For Each entAgrav As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If entAgrav.AgraviadoItem = .Item("col_agrav_item", e.RowIndex).Value Then
                            If Me.GrillaExpedienteRefID < 1 Then
                                entAgrav.Anulacion = IIf(.Item("col_est_anu", e.RowIndex).Value = True, Type.Enumeracion.enmEstadoAnulado.Anulado_total, Type.Enumeracion.enmEstadoAnulado.Normal)
                            End If
                        End If
                    Next
                End If
            End With
        End Sub


        Private Sub dgwExpediente_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyDown

            If e.KeyCode = Keys.Delete Then

                e.Handled = True

                Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)

            End If

        End Sub

        Private Sub dgwDelito_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwDelito.KeyDown
            If e.KeyCode = Keys.Delete Then
                e.Handled = True
                btnEditDelito.PerformClick()
            End If

        End Sub

        Private Sub dgwExpediente_RowStateChanged(sender As Object, e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgwExpediente.RowStateChanged
            If dgwExpediente.Rows.Count > 0 Then
                'Temporal_ListarDelitos(Me.GrillaExpedienteSelect)
            End If
        End Sub

        Private Sub btnAgregarDocumentos_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarDocumentos.Click
            RaiseEvent _Click_Documentos_Agregar()
        End Sub


        Private Sub btnElimarOtros_Click(sender As System.Object, e As System.EventArgs) Handles btnElimarOtros.Click

            Temporal_EliminarDocumento()

        End Sub
        Dim objEntDocCol As Entity.Registro.DocumentoJudicialCol

        Private Sub VerListaDetalle()
            '----------------Datos basicos------------
            Dim blnValue As Boolean = chkLista.Checked
            dgwDelito.Visible = Not (blnValue)
            tvExpe.Visible = blnValue
            btnEditDelito.Visible = Not (blnValue)
            If chkLista.Checked = True Then
                lblDelitosAgraviados.Text = "Detalle de documentos :"
            Else
                lblDelitosAgraviados.Text = "Delitos/Agraviados"
            End If
            '------------Llenado del Treview
            Dim parentnode As TreeNode
            Dim childnode As TreeNode
            Dim childnodeDel As TreeNode
            tvExpe.Nodes.Clear()
            ''''''''''''''''''objEntDocCol = New Entity.Registro.DocumentoJudicialCol
            Dim objEnt As New Entity.Registro.DocumentoJudicial
            Dim objExpediente_Col As New Entity.Registro.ExpedienteCol

            Dim CodigoExpediente As Integer = Me.GrillaExpedienteID
            Dim CodigoDocumento As Integer = Me.GrillaDocumentoJudicialID
            While CodigoExpediente > 0
                Dim objExpediente As New Entity.Registro.Expediente
                objExpediente.Codigo = CodigoExpediente
                objExpediente.CreaDocJudicialId = CodigoDocumento
                objExpediente_Col.Add(objExpediente)
                Dim objPad As New Entity.Registro.InternoExpedientePadre
                objPad.InternoExpedienteId = CodigoExpediente
                objPad.InternoExpedienteRefPadreId = -1
                objPad.DocJudicialID = -1
                objPad = (New Bussines.Registro.InternoExpedientePadre).Listar(objPad)
                CodigoExpediente = objPad.InternoExpedienteRefPadreId
                If CodigoExpediente > 0 Then
                    Dim exp As New Entity.Registro.Expediente
                    exp.Codigo = CodigoExpediente
                    CodigoDocumento = (New Bussines.Registro.Expediente).Listar_v2(exp).Expediente(0).CreaDocJudicialId
                End If
            End While

            For Each objEntExp As Entity.Registro.Expediente In objExpediente_Col
                Dim objdoc As New Entity.Registro.DocumentoJudicial
                objdoc.Codigo = objEntExp.CreaDocJudicialId
                objEnt = bssDoc.ListarGrilla(objdoc).DocumentoJudicial(0)
                parentnode = New TreeNode("DOC. JUDIC. : " & " " & IIf(objEnt.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, objEnt.fechaMovimientoEjecucionString.PadRight(20), objEnt.DocumentoFechaRecepDate.PadRight(20)) & " " & objEnt.DocumentoNumero.PadRight(20) & " " & objEnt.DistritoJudNombre.PadRight(20) & objEnt.SalaJudNombre.PadRight(30))
                parentnode.Name = objEntExp.Codigo
                parentnode.ForeColor = Color.DarkBlue
                'parentnode.StateImageIndex = 0
                tvExpe.Nodes.Add(parentnode)

                'Listar Expedientes
                Dim objExp As New Entity.Registro.Expediente
                Dim objExpCol As New Entity.Registro.ExpedienteCol
                Dim objExp1 As New Entity.Registro.Expediente
                objExp1.CreaDocJudicialId = objEntExp.CreaDocJudicialId
                objExpCol = (New Bussines.Registro.Expediente).Listar_v2(objExp1)


                For Each objExp In objExpCol
                    childnode = parentnode.Nodes.Add("EXPEDIENTE :" & " " & UCase(objExp.ExpedienteNumero) & " (" & UCase(objExp.SalaJudicialNombre) & ")")
                    childnode.Name = objEntExp.Codigo
                    childnode.ForeColor = Color.Green
                    childnode.StateImageIndex = 0

                    Dim objDel As New Entity.Registro.Delito
                    Dim objDelCol As New Entity.Registro.DelitoCol
                    Dim objDel1 As New Entity.Registro.Delito
                    objDel1.ExpedienteID = objExp.Codigo
                    objDel1.InternoID = Me._InternoId
                    objDelCol = (New Bussines.Registro.Delito).Listar2(objDel1)
                    For Each objDel In objDelCol
                        childnodeDel = childnode.Nodes.Add(UCase(objDel.DelitoEspecificoNombre))
                        childnodeDel.ForeColor = Color.Maroon

                        Dim objEntColAg As New Entity.Registro.AgraviadoCol
                        Dim objEnt_ As New Entity.Registro.Agraviado
                        objEnt_.DelitoID = objDel.Codigo
                        objEnt_.Anulacion = -1
                        objEntColAg = (New Bussines.Registro.InternoAgraviado).Listar(objEnt_)
                        For Each objEntAg As Entity.Registro.Agraviado In objEntColAg
                            childnodeDel.Nodes.Add(UCase(objEntAg.AgraviadoNombre)).Name = objEntExp.Codigo
                        Next
                    Next
                Next
            Next
        End Sub


        Private Sub chkLista_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkLista.CheckedChanged

            VerListaDetalle()

        End Sub


        Private Sub btnEditDocumentos_Click(sender As System.Object, e As System.EventArgs) Handles btnEditDocumentos.Click

            RaiseEvent VerDocumentoJudicial(Me.GrillaTipoDocumento, Me.GrillaSubTipoDocumento, Me.GrillaCodigoDocumento)

        End Sub


        Private Sub dgwDelito_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dgwDelito.KeyPress
            If Me.GrillaExpedienteRefID > 0 Then
                dgwDelito.SelectedRows(0).Cells("col_est_anu").Value = False
            End If
        End Sub

    End Class
End Namespace