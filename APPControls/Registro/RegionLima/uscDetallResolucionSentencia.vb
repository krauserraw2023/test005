Namespace Registro.RegionLima
    Public Class uscDetallResolucionSentencia
        '/*bussiness*/
        Private objBssExpediente As Bussines.Registro.Expediente
        Private objBssPerCon As Bussines.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
        Private objBssExpedientePad As Bussines.Registro.InternoExpedientePadre
        '/*entitys*/
        Private objEntExpediente As Entity.Registro.Expediente = Nothing
        Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objEntDelito As Entity.Registro.Delito = Nothing
        Private objEntAgraviado As Entity.Registro.Agraviado = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing
        Private objEntPeriodoCondenaNuevaTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
        Public _blnCadenaPerpetua As Boolean = False

#Region "Eventos"
        Friend _TotalAnhos As Integer

        Public Event _Click_Expediente_Agregar()
        Public Event _Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)

        Public Event _Click_PeriodoCondena_Agregar()
        Public Event _Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)

        Public Event _Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol)
        Public Event _Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)
        Public Event _click_VerResoluciones()
#End Region
#Region "Variables"
        Public esInimputable As Boolean = False
#End Region
#Region "Propiedades"
        Dim bolEdicionActivo As Boolean = False
     Public ReadOnly Property GrillaResolucionID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_exp_res_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public Property _Documentos_sin_mov As Boolean = False
        Public Property _Extramuro As Integer = -1
#End Region
#Region "Propiedades_Parametricas"
        Public Property _DocumentoJudicialID As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId As Integer = -1
        Public Property _InternoIngresoId As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        '/*revisar*/        
        Public Property _TipoResolucion As Integer = -1

        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property
        Public Sub ActualizarResolucion(ResolucionID As Integer, ResolucionNom As String)
            dgwExpediente.SelectedRows(0).Cells("col_exp_res_id").Value = ResolucionID
            dgwExpediente.SelectedRows(0).Cells("col_exp_res_nom").Value = ResolucionNom
            If dgwDelito.RowCount > 0 Then
                For i As Integer = 0 To dgwDelito.RowCount - 1
                    dgwDelito.SelectedRows(i).Cells("col_tip_reso_id").Value = ResolucionID
                    dgwDelito.SelectedRows(i).Cells("col_tip_reso").Value = ResolucionNom
                Next
            End If
        End Sub
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
        'Public ReadOnly Property GrillaNroRegistroPeriodocondena() As Integer
        '    Get
        '        Try
        '            Return dgvPeriodoCondNueva.Rows.Count
        '        Catch ex As Exception
        '            Return -1
        '        End Try
        '    End Get
        'End Property
        'Private ReadOnly Property GrillaPeriodoCondenaCodigo() As Integer
        '    Get
        '        Try
        '            Return dgvPeriodoCondena.SelectedRows(0).Cells("codigo").Value
        '        Catch ex As Exception
        '            Return -1
        '        End Try
        '    End Get
        'End Property
        'Private ReadOnly Property GrillaPeriodoCondenaItem() As Integer
        '    Get
        '        Try
        '            Return dgvPeriodoCondNueva.SelectedRows(0).Cells("col_ped_cond_item_").Value
        '        Catch ex As Exception
        '            Return -1
        '        End Try
        '    End Get
        'End Property
        'Private ReadOnly Property GrillaPeriodoCondenaItem_() As Integer
        '    Get
        '        Try
        '            Return dgvPeriodoCondNueva.SelectedRows(0).Cells("col_ped_cond_item_").Value
        '        Catch ex As Exception
        '            Return -1
        '        End Try
        '    End Get
        'End Property

        Public ReadOnly Property _GrillaDocumentoJudID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value
                Catch ex As Exception
                    Return -1
                End Try

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
        Public ReadOnly Property _GrillaDelito_ExpItem() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_exp_item").Value
                Catch ex As Exception
                    Return 0
                End Try
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
        Public ReadOnly Property _GrillaItemAgraviado() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_agrav_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _grillaIdCentroSalud As Short
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_id_cen_sal_men").Value
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
#End Region
#Region "Temporales"

        Public objEntPeriodoCondenaTempoCol As Entity.Registro.Documento.PeriodoCondenaSentenciaCol = Nothing

        Public objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol = Nothing
        Private objEntExpedienteIndc As New Entity.Registro.ExpedienteCol

        Private objEntAgraviadoTempoColGrilla As Entity.Registro.AgraviadoCol = Nothing
        Private objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
        Private objEntAgraviadosIndcCol As New Entity.Registro.AgraviadoCol
        Private objEntAgraviadosIndcCol2 As New Entity.Registro.AgraviadoCol

        Private objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol = Nothing
        Private objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing
        Private objEntDelitoIndcCol As New Entity.Registro.DelitoCol
        Private objEntDelitoIndcCol2 As New Entity.Registro.DelitoCol

        Private blnEliminarDelitoColec As Boolean = False
        Private blnEliminarColection As Boolean = False

        Private Sub Temporal_GrabarPeriodoCondena(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            If objEnt.Codigo > 0 Then
                'nada
            Else
                If objEnt.PeriodoCondenaItem > 0 Then
                    For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In Me.objEntPeriodoCondenaTempoCol
                        If obj.PeriodoCondenaItem = objEnt.PeriodoCondenaItem Then
                            objEnt = obj.Copiar_PeriodoCondenaSentencia()
                            Exit For
                        End If
                    Next
                Else
                    'si el temporal es nuevo
                    Me.objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                    objEnt.RegionId = Me._RegionID
                    objEnt.PenalId = Me._PenalID
                    objEnt.PeriodoCondenaItem = TemporalPeriodoSentenciaItemMaximo() + 1
                    objEntPeriodoCondenaTempoCol.Add(objEnt)
                End If
            End If
            'listar_PeriodoCondenaNuevo()
        End Sub

        Private Sub Temporal_GrabarPeriodoCondenaNuevo(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            If objEnt.Codigo > 0 Then
                'nada
            Else
                If objEnt.PeriodoCondenaItem > 0 Then
                    For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In Me.objEntPeriodoCondenaTempoCol
                        If obj.PeriodoCondenaItem = objEnt.PeriodoCondenaItem Then
                            objEnt = obj.Copiar_PeriodoCondenaSentencia()
                            Exit For
                        End If
                    Next
                Else
                    'si el temporal es nuevo
                    Me.objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                    objEnt.RegionId = Me._RegionID
                    objEnt.PenalId = Me._PenalID
                    objEnt.PeriodoCondenaItem = TemporalPeriodoSentenciaItemMaximo() + 1
                    objEntPeriodoCondenaNuevaTempoCol.Add(objEnt)
                End If
            End If
            'listar_PeriodoCondenaNuevo()
        End Sub

        Private Sub Temporal_GrabarListaExpediente(objEntTemCol As Entity.Registro.ExpedienteCol)
            If Not objEntTemCol Is Nothing Then
                For Each objEntExp As Entity.Registro.Expediente In objEntTemCol
                    objEntExp._RegionId = Me._RegionID
                    objEntExp._PenalId = Me._PenalID
                    objEntExp.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                    'objEntExp.Resolucion = 22
                    objEntExpedienteTempoCol.Add(objEntExp)
                Next
                Temporal_ListarExpediente()
            End If
        End Sub

        Private Function TemporalPeriodoSentenciaItemMaximo() As Integer
            Dim intNumero As Integer = 0
            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaNuevaTempoCol
                If obj.PeriodoCondenaItem > intNumero Then intNumero = obj.PeriodoCondenaItem
            Next
            Return intNumero
        End Function



        Public Sub _Temporal_Grabar_Expediente_Delito_Agraviado(objEnt As Entity.Registro.ExpedienteCol, objEntDel As Entity.Registro.DelitoCol, objEntAgr As Entity.Registro.AgraviadoCol)
            If dgwExpediente.Rows.Count = 0 Then

                Temporal_Grabar_Expediente_Delito_Agraviado(objEnt, objEntDel, objEntAgr)

            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion solo puede tener un expediente")
                Exit Sub
            End If
            dgwExpediente_CellClick(Nothing, Nothing)
        End Sub
        Private entExpColAcum As New Entity.Registro.ExpedienteCol
        Private Sub Temporal_Grabar_Expediente_Delito_Agraviado(objEntExpedienteCol As Entity.Registro.ExpedienteCol, objEntDelitoCol As Entity.Registro.DelitoCol,
                                                                objEntAgraviadoCol As Entity.Registro.AgraviadoCol)

            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol

                objEntExpediente._RegionId = Me._RegionID
                objEntExpediente._PenalId = Me._PenalID
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD Or
                    Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD_Consentida Then
                    objEntExpediente.ResolucionID = 39
                    objEntExpediente.ResolucionNom = "CONFIRMAR LA SENTENCIA"
                End If
                If objEntExpediente.DocumentoTipoID = 19 Or objEntExpediente.DocumentoTipoID = 29 Then
                    objEntExpediente.Codigo = 999999
                End If
                Temporal_GrabarExpediente(objEntExpediente)
                If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                   objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                    Dim objEntExpedienteCol2 As New Entity.Registro.ExpedienteCol
                    entExpColAcum = New Entity.Registro.ExpedienteCol
                    objBssExpediente = New Bussines.Registro.Expediente

                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                        Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                        objEntExpedienteCol2 = objBssExpediente.ListarExpedientexResolucion_LM(objEntExpediente.CreaDocJudicialId)
                    Else
                        objEntExpedienteCol2 = objBssExpediente.ListarExpedientexResolucion(objEntExpediente.CreaDocJudicialId)
                    End If

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
                        End If

                        For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            If objDelito.Codigo = objAgraviado.DelitoID Then
                                objAgraviado.ExpedienteItem = objEntExpediente.ExpedienteItem
                                objAgraviado.DelitoItem = objDelito.DelitoItem
                                Temporal_GrabarAgraviado(objDelito, objAgraviado)
                            End If
                        Next

                    Next
                End If

            Next
            Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
            If objEntExpedienteCol.Expediente(0) Is Nothing Then
                'nada
            Else
                If Me._DocumentoJudicialID < 1 Then
                    Dim entDocJud As New Entity.Registro.DocumentoJudicial
                    objBss = New Bussines.Registro.DocumentoJudicial
                    entDocJud.Codigo = Me._GrillaDocumentoJudID
                    entDocJud = objBss.Listar(entDocJud)
                End If

            End If
        End Sub

        Private Sub Temporal_ListarExpediente()

            With Me.dgwExpediente
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = IIf(objEntExpedienteTempoCol Is Nothing, Nothing, objEntExpedienteTempoCol)
                .Refresh()
                lblNroExpedientes.Text = "Expedientes " & .Rows.Count & " Reg."
            End With

        End Sub
        Private Sub ListarExpedienteTipoResolucion()
            If objEntExpedienteTempoCol.Expediente(0).Nuevo = False Then
                dgwExpediente.Rows(0).Cells("col_exp_res").Value = objEntAgraviadoTempoCol.Item(0).TipoResolucionId
            End If
        End Sub
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
                        If Me._DocumentoJudicialID < 1 Then
                            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD Or
                               Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD_Consentida Then
                                f.Cells("col_tip_reso_id").Value = 39
                                f.Cells("col_tip_reso").Value = "CONFIRMAR LA SENTENCIA"
                            Else
                                f.Cells("col_tip_reso_id").Value = objAgr.TipoResolucionId
                                f.Cells("col_tip_reso").Value = objAgr.TipoResolucionNom
                            End If
                            f.Cells("col_tip_sent").Value = -1
                            f.Cells("col_sent_hist").Value = objAgr.TipoSentenciaNombre
                        Else
                            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD Or
                                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD_Consentida Then
                                f.Cells("col_tip_reso_id").Value = 39
                                f.Cells("col_tip_reso").Value = "CONFIRMAR LA SENTENCIA"
                            Else
                                f.Cells("col_tip_reso_id").Value = objAgr.TipoResolucionId
                                f.Cells("col_tip_reso").Value = objAgr.TipoResolucionNom
                            End If
                            f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaId
                        End If
                        f.Cells("col_agrav_cod").Value = objAgr.Codigo
                        f.Cells("col_agrav_item").Value = objAgr.AgraviadoItem
                        f.Cells("col_agr_delito_item").Value = objAgr.DelitoItem
                        f.Cells("col_agr_exp_item").Value = objAgr.ExpedienteItem
                        f.Cells("col_agrav").Value = objAgr.AgraviadoNombre
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
#Region "Eliminar"
        Private Sub Temporal_EliminarExpediente_Delito_Agraviado(SelectExpediente As Boolean, SelectDelito As Boolean, SelectAgraviado As Boolean)
            Dim intCodigoExpediente As Integer = Me.GrillaExpedienteID
            If Me._DocumentoJudicialID > 0 Then
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                objEntExpPadre.InternoExpedienteId = intCodigoExpediente
                Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
                If blnValor = False Then
                    If SelectExpediente = True Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente seleccionado no se puede eliminar, ya ha sido referenciado")
                    ElseIf SelectDelito = True Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El delito seleccionado no se puede eliminar, ya ha sido referenciado")
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El agraviado seleccionado no se puede eliminar, ya ha sido referenciado")
                    End If
                    Exit Sub
                End If
            End If
            Dim strMensaje As String = ""
            If SelectExpediente = True Then
                strMensaje = "Esta seguro de eliminar el expediente, delitos y agraviado, una vez eliminado no se podra recuperar la información"
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then

                    'eliminar el agraviado
                    Temporal_EliminarExpedienteAgraviado()
                    'eliminar el delito
                    Temporal_EliminarExpedienteDelito()
                    'eliminar el expediente
                    Temporal_EliminarExpediente()

                    'TemporalEliminarPeriodo()

                End If
            End If
            If SelectDelito = True Then
                strMensaje = "Esta seguro de eliminar el delito, se eliminara sus agraviado !!!"
                Dim intCodigoDelito As Integer = Me.GrillaDelitoID
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then

                    'eliminar el agraviado
                    Temporal_EliminarDelitoAgraviado()
                    Temporal_EliminarDelito()

                End If
            End If
            If SelectAgraviado = True Then
            End If
        End Sub

        Private Sub Temporal_EliminarDelitoAgraviado()
            Dim EntAgr As New Entity.Registro.Agraviado
            Dim intIndice As Integer = -1
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemAgraviado = objEntAgraviadoTempoCol.Item(i).AgraviadoItem Then
                    intIndice = i
                    Dim intCodigo As Integer = objEntAgraviadoTempoCol.Item(i).Codigo

                    If objEntAgraviadoTempoCol.Item(i).Codigo > 0 Then
                        If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                            EntAgr.Codigo = intCodigo
                            blnEliminarDelitoColec = True
                            objEntAgraviadosIndcCol2.Add(EntAgr)
                        End If
                    End If
                    objEntAgraviadoTempoCol.Remove(intIndice)
                End If
            Next
        End Sub

        Private Sub Temporal_EliminarDelito()
            Dim intConta As Integer = 0
            For Each objagr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                If objagr.DelitoItem = Me._GrillaItemDelito Then
                    intConta = intConta + 1
                End If
            Next
            If intConta > 0 Then
                Exit Sub
            End If
            Dim intCodigo As Integer = Me.GrillaDelitoID
            Dim EntDel As New Entity.Registro.Delito

            If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                If intCodigo > 0 Then
                    blnEliminarDelitoColec = True
                    EntDel.Codigo = intCodigo
                    objEntDelitoIndcCol2.Add(EntDel)
                End If
            End If
            objEntDelitoTempoCol.Remove(Me.GrillaDelitoIndex)

        End Sub

        Private Sub Temporal_EliminarExpedienteAgraviado()
            Dim AgraviadosIndc As New Entity.Registro.Agraviado
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemExpediente = objEntAgraviadoTempoCol.Item(i).ExpedienteItem Then
                    If Me._GrillaExpedienteID > 0 Then
                        If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                            blnEliminarColection = True
                            AgraviadosIndc.Codigo = objEntAgraviadoTempoCol.Item(i).Codigo
                            objEntAgraviadosIndcCol.Add(AgraviadosIndc)
                        End If
                    End If
                    objEntAgraviadoTempoCol.Remove(i)
                End If
            Next
            'dgwDelito_CellContentClick(Nothing, Nothing)
        End Sub

        Private Sub Temporal_EliminarExpedienteDelito()
            Dim DelitoIndc As New Entity.Registro.Delito
            If Me._GrillaExpedienteID > 0 Then
                For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1
                    If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then

                        DelitoIndc.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                        objEntDelitoIndcCol.Add(DelitoIndc)
                        objEntDelitoTempoCol.Delete(i)
                    End If
                Next
            Else
                For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1

                    If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then
                        Dim intCodigo As Integer = objEntDelitoTempoCol.Item(i).Codigo
                        DelitoIndc.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                        objEntDelitoIndcCol.Add(DelitoIndc)
                        objEntDelitoTempoCol.Delete(i)
                    End If
                Next
            End If
            dgwExpediente_CellClick(Nothing, Nothing)
            dgwDelito.Refresh()


        End Sub

        Private Sub Temporal_EliminarExpediente()
            If Me.dgwExpediente.RowCount > 0 Then
                Dim intCodigo As Integer = Me.GrillaExpedienteID
                If Me.GrillaExpedienteID > 0 Then
                    Dim Exp_ent As New Entity.Registro.Expediente
                    Exp_ent.Codigo = intCodigo
                    objEntExpedienteIndc.Add(Exp_ent)
                    objEntExpedienteTempoCol.Remove(Me.GrillaExpedienteIndex)
                    'End If
                Else
                    objEntExpedienteTempoCol.Remove(Me.GrillaExpedienteIndex)
                End If
                Temporal_ListarExpediente()
                'Temporal_ListarDelitos(Nothing)
                dgwExpediente_CellClick(Nothing, Nothing)
            End If
        End Sub


        Dim intPadre As Integer = -1
        Private Function ValidarExpedientePadreBD() As Boolean
            Dim objBssPad As Bussines.Registro.InternoExpedientePadre
            objBssExpediente = New Bussines.Registro.Expediente
            Dim EntColPad As New Entity.Registro.InternoExpedientePadreCol
            Dim ListaExpediente As New Entity.Registro.Expediente
            objBssPad = New Bussines.Registro.InternoExpedientePadre
            Dim EntExp As New Entity.Registro.InternoExpedientePadre
            EntExp.Codigo = Me._GrillaExpedienteID
            EntExp.InternoID = Me._InternoId
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                EntColPad = objBssPad.ListarGrilla_LM(EntExp)
            Else
                EntColPad = objBssPad.ListarGrilla(EntExp)
            End If

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
#End Region
#Region "Grabar"
        Public Sub _Temporal_GrabarPeriodoCondena(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Temporal_GrabarPeriodoCondena(objEnt)
        End Sub
        Public Sub _Temporal_GrabarPeriodoNuevaCondena(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Temporal_GrabarPeriodoCondenaNuevo(objEnt)
        End Sub
#Region "Expediente"
        Public Sub _Temporal_GrabarExpediente(objEnt As Entity.Registro.Expediente)

            Temporal_GrabarExpediente(objEnt)

        End Sub
        Private Sub Temporal_GrabarExpediente(objEnt As Entity.Registro.Expediente)
            'si el temporal ya existe 
            Dim f As New DataGridView
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD Or
                    Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD_Consentida Then
                objEnt.ResolucionID = 39
                objEnt.ResolucionNom = "CONFIRMAR LA SENTENCIA"
            End If
            If objEnt.ExpedienteItem > 0 Then
                For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If obj.ExpedienteItem = objEnt.ExpedienteItem Then
                        Temporal_ExpedienteCopiarPropiedades(obj, objEnt)
                        Exit For
                    End If
                Next
            Else
                'si el temporal es nuevo
                'objEnt.Resolucion = 22
                objEnt._RegionId = Me._RegionID
                objEnt._PenalId = Me._PenalID
                objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                objEntExpedienteTempoCol.Add(objEnt)

            End If

            Temporal_ListarExpediente()
        End Sub
        Private Sub Temporal_ExpedienteCopiarPropiedades(objEntOrigen As Entity.Registro.Expediente, ObjEntDestino As Entity.Registro.Expediente)

            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
                .IngresoInpeId = ObjEntDestino.IngresoInpeId
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

                .Flagrancia = ObjEntDestino.Flagrancia
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD Or
                   Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD_Consentida Then
                    .ResolucionID = 39
                    .ResolucionNom = "CONFIRMAR LA SENTENCIA"
                Else
                    .ResolucionID = ObjEntDestino.ResolucionID
                    .ResolucionNom = ObjEntDestino.ResolucionNom
                End If
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
            'validar si el delito ya esta seleccionado, cambiar por id
            For i As Integer = 0 To dgwDelito.Rows.Count - 1
                If objEntDelito.Codigo < -1 Then 'PENDIENTEHNB verificar condicion 
                    If objEntDelito.DelitoEspecificoNombre = dgwDelito.Item("col_del_esp_nom", i).Value Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El delito ya existe en la lista, no podra ser agregado.")
                        Exit Sub
                    End If
                End If
            Next
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
                .IngresoInpeId = ObjEntDestino.IngresoInpeId
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

            RaiseEvent _Click_Delito_Editar(Me.objEntExpedienteTempoCol.Item(Me.GrillaExpedienteIndex), Me.GrillaDelitoSelect, Me.Grilla_Agraviados_Delito_Select, Me.objEntDelitoTempoColGrilla)

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
                    'objEnt.TipoResolucionId = 22
                    objEntAgraviadoTempoCol.Add(objEnt)
                End If

            End If
        End Sub

        Private Sub Temporal_AgraviadoCopiarPropiedades(objEntOrigen As Entity.Registro.Agraviado, ObjEntDestino As Entity.Registro.Agraviado)
            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
                .IngresoInpeId = ObjEntDestino.IngresoInpeId
                .ExpedienteID = ObjEntDestino.ExpedienteID
                .DelitoID = ObjEntDestino.DelitoID
                .AgraviadoItem = ObjEntDestino.AgraviadoItem
                .DelitoItem = ObjEntDestino.DelitoItem
                .ExpedienteItem = ObjEntDestino.ExpedienteItem
                .TipoSentenciaId = ObjEntDestino.TipoSentenciaId
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD Then
                    .TipoResolucionId = 39
                    .TipoResolucionNom = "CONFIRMA LA SENTENCIA"
                Else
                    .TipoResolucionId = ObjEntDestino.TipoResolucionId
                    .TipoResolucionNom = ObjEntDestino.TipoResolucionNom
                End If
                '/*campos*/
                .AgraviadoNombre = ObjEntDestino.AgraviadoNombre
                .Observacion = ObjEntDestino.Observacion
                .Estado = ObjEntDestino.Estado
                .FlgEliminado = ObjEntDestino.FlgEliminado
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
            Me._Load()

            If Me._DocumentoJudicialID < 1 Then 'si es nuevo y se muestra los checkeds
                dgwExpediente.Columns("col_exp_ref").Visible = False
            Else
                Me.dgwDelito.Columns("col_sent_hist").Visible = False
                Me.dgwDelito.Columns("col_tip_sent").HeaderText = "Tipo de Sentencia"
                Dim objEntExpedienteColTmp As New Entity.Registro.ExpedienteCol
                Dim objEntDelitoColTmp As New Entity.Registro.DelitoCol
                Dim objEntAgraviadoCol As New Entity.Registro.AgraviadoCol
                objBssDelito = New Bussines.Registro.Delito
                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                    objEntExpedienteColTmp = (New Bussines.Registro.Expediente).ListarExpedientexResolucion_LM(Me._DocumentoJudicialID)
                Else
                    objEntExpedienteColTmp = (New Bussines.Registro.Expediente).ListarExpedientexResolucion(Me._DocumentoJudicialID)
                End If

                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteColTmp
                    If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Pena_Limitativa Then Me._Extramuro = objEntExpediente.Extramuro
                    Temporal_GrabarExpediente(objEntExpediente)

                    Dim objDel As New Entity.Registro.Delito
                    objDel.InternoID = Me._InternoId
                    objDel.IngresoID = Me._InternoIngresoId
                    objDel.IngresoInpeId = Me._InternoIngresoInpeId
                    objDel.ExpedienteID = objEntExpediente.Codigo
                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                        Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or
                        Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                        objEntDelitoColTmp = objBssDelito.Listar2_LM(objDel)
                    Else
                        objEntDelitoColTmp = objBssDelito.Listar2(objDel)
                    End If


                    For Each objEntDelito As Entity.Registro.Delito In objEntDelitoColTmp

                        Temporal_GrabarDelito(objEntExpediente, objEntDelito, Nothing)
                        Dim objEnt As New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = -1
                            .DelitoID = objEntDelito.Codigo
                            .InternoID = Me._InternoId
                            .IngresoID = Me._InternoIngresoId
                            .IngresoInpeId = Me._InternoIngresoInpeId
                            .ExpedienteID = objEntDelito.ExpedienteID
                            .TipoSentenciaId = -1
                            .AgraviadoNombre = ""
                        End With
                        If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                            Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or
                            Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                            objEntAgraviadoCol = objBssAgraviado.Listar_LM(objEnt)
                        Else
                            objEntAgraviadoCol = objBssAgraviado.Listar(objEnt)
                        End If

                        For Each objEntAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            Temporal_GrabarAgraviado(objEntDelito, objEntAgraviado)

                        Next

                    Next
                Next
                Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(0))

                '------------------------------ HNRB -------------------------------------->
                objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                objEntPerCon.DocJudicialId = DocumentoJudicialID
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    objEntPerCon.PenalId = -1
                End If
                objEntPeriodoCondenaNuevaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon) 'no es necesario LM
                For i As Integer = 0 To objEntPeriodoCondenaNuevaTempoCol.Count - 1 'indexar cada expediente
                    objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
                Next
                'listar_PeriodoCondenaNuevo()
                objEnt = New Entity.Registro.DocumentoJudicial
                objBss = New Bussines.Registro.DocumentoJudicial
                objEnt.Codigo = DocumentoJudicialID
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    objEnt = objBss.Listar_v2_LM(objEnt)
                Else
                    objEnt = objBss.Listar_v2(objEnt)
                End If


                'With objEnt
                '    Me._TotalAnhos = .SentenciaTotalAnios
                '    Me._TotalMes = .SentenciaTotalMeses
                '    Me._TotalDias = .SentenciaTotalDias
                'End With
                '' <-----------Periodo de condena anterior---------------------------------------------------------------
                If objEntExpedienteColTmp.Expediente(0) Is Nothing Then
                    '    'nada
                Else
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    objEntExpPadre.InternoExpedienteId = objEntExpedienteColTmp.Expediente(0).Codigo

                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                        Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                        Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                        objEntExpPadre = objBssExpedientePad.Listar_LM(objEntExpPadre)
                    Else
                        objEntExpPadre = objBssExpedientePad.Listar(objEntExpPadre)
                    End If

                    objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                    objEntPerCon.DocJudicialId = objEntExpPadre.DocJudPadre
                    If objEntPerCon.DocJudicialId > 0 Then
                        objEntPeriodoCondenaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon) 'no es necesario LM
                        For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1 'indexar cada expediente
                            objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
                        Next
                    End If
                    If objEntExpPadre.DocJudPadre > 1 Then
                        Dim objEnt2 As New Entity.Registro.DocumentoJudicial
                        objEnt2.Codigo = objEntExpPadre.DocJudPadre
                        objEnt2 = objBss.Listar(objEnt2) 'no necesario LM
                        'With objEnt2
                        '    Me.txtAnios2.Text = .SentenciaTotalAnios
                        '    Me.txtMeses2.Text = .SentenciaTotalMeses
                        '    Me.txtDias2.Text = .SentenciaTotalDias
                        'End With
                    Else
                        'Me.txtAnios2.Text = ""
                        'Me.txtMeses2.Text = ""
                        'Me.txtDias2.Text = ""
                    End If
                    'listar_PeriodoCondena()
                End If


                If ValidarExpedienteReferenciado(6) = False Then
                    'Me.txtAnios.ReadOnly = True
                    'Me.txtMeses.ReadOnly = True
                    'Me.txtDias.ReadOnly = True
                End If
            End If
        End Sub
#End Region
#Region "Validar"
        Public Function ValidarExpedienteReferenciado(Condicion As String) As Boolean
            If Me._DocumentoJudicialID > 0 Then
                Dim strMensaje As String = ""
                Dim intValorpadre As Integer = 0
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
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
                        'Case 7
                        '    strMensaje = " [Operación cancelada]"
                End Select
                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    If objEntExpediente.Codigo > 0 Then
                        objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                        Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
                        If blnValor = False Then
                            intValorpadre = intValorpadre + 1
                        End If
                    End If
                Next
                If intValorpadre > 0 Then
                    If strMensaje <> "VAL" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado," & strMensaje)

                    End If
                    Return False
                End If
            End If
            Return True
        End Function
        'Public Function ValidarPeriodoCondena() As String
        '    objBssPerCon = New Bussines.Registro.Documento.PeriodoCondenaSentencia
        '    Return objBssPerCon.Validar(txtAnios.Text, txtMeses.Text, txtDias.Text, objEntPeriodoCondenaNuevaTempoCol)
        'End Function
#End Region
#Region "Accion"

        Public Sub _Grabar(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDocJud As Entity.Registro.DocumentoJudicial)
            EliminarExpedienteBD()
            AGrabar(DocumentoJudicialID, Nuevo, EntDocJud)
        End Sub
        Private Sub AGrabar(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDocJud As Entity.Registro.DocumentoJudicial)

            '---------Grabar expediente------------------------------------
            objBssExp = New Bussines.Registro.Expediente
            objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre

            For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol
                Dim ExpedienteOrigID As Integer = objExpediente.Codigo
                Dim DocumentoOrigID As Integer = objExpediente.CreaDocJudicialId
                Dim intIdExpediente As Integer = -1
                With objExpediente
                    If Nuevo = True Then
                        If .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                            .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia Or
                            .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                            Dim ent_ As New Entity.Registro.Expediente
                            ent_.CreaDocJudicialId = DocumentoOrigID
                            For Each obj As Entity.Registro.Expediente In objBssExpediente.Listar_v2(ent_) 'no LM
                                objBssExp.GrabarEstadoVisibilidad(obj.Codigo, False, Me.FlagTransferSede)
                            Next
                        Else
                            If ExpedienteOrigID > 0 Then
                                If objExpediente.Codigo > 0 And objExpediente.CreaDocJudicialId > 0 Then objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                            End If
                        End If
                        .Codigo = -1
                    Else
                        If .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                           .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia Or
                           .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                            Dim ent_ As New Entity.Registro.Expediente
                            ent_.CreaDocJudicialId = DocumentoOrigID
                            For Each obj As Entity.Registro.Expediente In objBssExpediente.Listar_v2(ent_)
                                objBssExp.GrabarEstadoVisibilidad(obj.Codigo, False, Me.FlagTransferSede)
                            Next
                            objExpediente.Codigo = -1
                        Else
                            If ExpedienteOrigID > 0 And DocumentoOrigID <> DocumentoJudicialID Then
                                objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, FlagTransferSede)
                                objExpediente.Codigo = -1
                            End If
                        End If
                    End If
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .SituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
                    .ExpedienteVisible = 1
                    .CreaDocJudicialId = DocumentoJudicialID
                    .ResolucionNom = objExpediente.ResolucionNom
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .Extramuro = EntDocJud.Extramuro
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                        Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                        Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                        intIdExpediente = objBssExp.Grabar_LM(objExpediente)
                    Else
                        intIdExpediente = objBssExp.Grabar(objExpediente)
                    End If
                End With
                '---------------ExpedientePadre------------------------------
                If intIdExpediente > 0 Then
                    Dim objIntExpPad As New Entity.Registro.InternoExpedientePadre
                    With objIntExpPad
                        .InternoExpedienteId = intIdExpediente
                        .InternoExpedienteRefPadreId = ExpedienteOrigID
                        .InternoID = Me._InternoId
                        .IngresoID = Me._InternoIngresoId
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .DocJudicialID = DocumentoJudicialID
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        ._RegionId = Me._RegionID
                        ._PenalId = Me._PenalID
                    End With
                    With objExpediente
                        If Nuevo = True Then
                            If .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                               .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                               .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                Dim ent_ As New Entity.Registro.Expediente
                                Dim entCol As New Entity.Registro.ExpedienteCol

                                ent_.CreaDocJudicialId = DocumentoOrigID
                                entCol = objBssExpediente.Listar_v2(ent_) 'no LM
                                For Each obj As Entity.Registro.Expediente In entCol
                                    objIntExpPad.InternoExpedienteRefPadreId = obj.Codigo
                                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                                        objBssExpedientePad.Grabar_LM(objIntExpPad)
                                    Else
                                        objBssExpedientePad.Grabar(objIntExpPad)
                                    End If
                                Next
                            Else
                                If ExpedienteOrigID > 0 Then
                                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                                        objBssExpedientePad.Grabar_LM(objIntExpPad)
                                    Else
                                        objBssExpedientePad.Grabar(objIntExpPad)
                                    End If
                                End If
                            End If
                        Else
                            If .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or _
                               .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia Or _
                               .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                Dim ent_ As New Entity.Registro.Expediente
                                ent_.CreaDocJudicialId = DocumentoOrigID
                                '
                                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                                    For Each obj As Entity.Registro.Expediente In objBssExpediente.Listar_v2_LM(ent_) '
                                        objIntExpPad.InternoExpedienteRefPadreId = obj.Codigo
                                        objBssExpedientePad.Grabar_LM(objIntExpPad)
                                    Next
                                Else
                                    For Each obj As Entity.Registro.Expediente In objBssExpediente.Listar_v2(ent_) '
                                        objIntExpPad.InternoExpedienteRefPadreId = obj.Codigo
                                        objBssExpedientePad.Grabar(objIntExpPad)
                                    Next
                                End If
                            Else
                                If (ExpedienteOrigID < 1 Or (ExpedienteOrigID > 0 And DocumentoJudicialID <> DocumentoOrigID)) Then
                                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                                        objBssExpedientePad.Grabar_LM(objIntExpPad)
                                    Else
                                        objBssExpedientePad.Grabar(objIntExpPad)
                                    End If
                                End If
                            End If
                        End If
                    End With
                End If

                Dim intIdDel As Integer = -1
                Dim intIdAgrav As Integer = -1
                '----------------------Registrar delitos-------------------------

                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                    Dim codigoDelitoOri As Integer = objDel.Codigo
                    Dim creaDelitoOri As Integer = objDel.CreaDocJudicialId
                    If objExpediente.ExpedienteItem = objDel.ExpedienteItem Then
                        objBssDelito = New Bussines.Registro.Delito
                        If Nuevo = True Then
                            objDel.Codigo = -1
                        Else
                            If codigoDelitoOri > 0 And DocumentoJudicialID <> creaDelitoOri Then
                                objDel.Codigo = -1
                            End If
                        End If
                        objDel.ExpedienteID = intIdExpediente  'referencia al nuevo expediente
                        objDel.CreaDocJudicialId = DocumentoJudicialID
                        objDel.InternoID = Me._InternoId
                        objDel.IngresoID = Me._InternoIngresoId
                        objDel.IngresoInpeId = Me._InternoIngresoInpeId
                        objDel.FlagTransferenciaSede = Me.FlagTransferSede
                        objDel.RegionID = Me._RegionID
                        objDel.PenalID = Me._PenalID
                        If codigoDelitoOri > 0 And creaDelitoOri <> DocumentoJudicialID Then
                            objDel.CodigodelitoPad = codigoDelitoOri
                        End If
                        If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                            intIdDel = objBssDelito.Grabar_LM(objDel)
                        Else
                            intIdDel = objBssDelito.Grabar_v2(objDel)
                        End If

                        For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                            Dim codigoAgraviadoOri As Integer = obj.Codigo
                            Dim creaAgraviadoOri As Integer = obj.CreaDocJudicialId
                            If objDel.DelitoItem = obj.DelitoItem Then
                                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                                If Nuevo = True Then
                                    obj.Codigo = -1
                                Else
                                    If (codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID) Then
                                        obj.Codigo = -1
                                    End If
                                End If
                                obj.DelitoID = intIdDel
                                obj.CreaDocJudicialId = DocumentoJudicialID
                                obj.ExpedienteID = intIdExpediente
                                obj.InternoID = Me._InternoId
                                obj.IngresoID = Me._InternoIngresoId
                                obj.IngresoInpeId = EntDocJud.IngresoInpeId
                                obj.FlagTransferenciaSede = Me.FlagTransferSede
                                obj.RegionID = Me._RegionID
                                obj.PenalID = Me._PenalID

                                If _TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria Then
                                    obj.TipoSentenciaId = IIf(obj.TipoSentenciaId = 0, -1, obj.TipoSentenciaId)
                                    obj.TipoSentenciaHistoricoId = IIf(obj.TipoSentenciaId = 0, -1, obj.TipoSentenciaId)
                                Else
                                    obj.TipoSentenciaId = IIf(obj.TipoSentenciaId = 0, -1, obj.TipoSentenciaId)
                                    obj.TipoSentenciaHistoricoId = IIf(obj.TipoSentenciaHistoricoId = 0, -1, obj.TipoSentenciaHistoricoId)
                                    obj.TipoResolucionId = IIf(obj.TipoResolucionId = 0, -1, obj.TipoResolucionId)
                                End If
                                If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                    obj.CodigoagraviadoPad = codigoAgraviadoOri
                                End If
                                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                                    intIdAgrav = objBssAgraviado.Grabar_LM(obj)
                                Else
                                    intIdAgrav = objBssAgraviado.Grabar(obj)
                                End If
                            End If
                        Next
                    End If
                Next
            Next
            If blnCondicionLib = True Then
                bssMov = New Bussines.Registro.InternoMovimiento
                entMov.InternoID = Me._InternoId
                entMov.IngresoID = Me._InternoIngresoId
                entMov.IngresoInpeId = Me._InternoIngresoInpeId
                entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad

                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    entMov = bssMov.Listar_LM(entMov)
                    bssMov.Eliminar_LM(entMov.Codigo, -1, entMov.IngresoInpeId, Me.FlagTransferSede)
                Else
                    entMov = bssMov.Listar(entMov)
                    bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
                End If
            End If
        End Sub
        Public Sub EliminarExpedienteBD()
            If blnEliminarColection = True Then
                If ValidarEliminar(objEntExpedienteIndc.Expediente(0).Codigo) = True Then
                    For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                        AEliminarAgraviadoBD(EntAgr.Codigo)
                    Next
                    For Each EntDel As Entity.Registro.Delito In objEntDelitoIndcCol
                        AEliminarDelitoBD(EntDel.Codigo)
                    Next
                    For Each EntExp As Entity.Registro.Expediente In objEntExpedienteIndc
                        AEliminarExpedienteBD(EntExp.Codigo)
                    Next
                End If
            End If
            If blnEliminarDelitoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol2
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
                For Each EntDel As Entity.Registro.Delito In objEntDelitoIndcCol2
                    AEliminarDelitoBD(EntDel.Codigo)
                Next
            End If
        End Sub
        Private Function Validar(IDExpediente As Integer) As Boolean
            If Me._InternoId = -1 Then
                MsgBox("No se ha enviado el parametro DocJudicialId al objeto", MsgBoxStyle.Critical)
                Return False
            End If
            If Me._RegionID = -1 Then
                MsgBox("No se ha enviado el parametro RegionID al objeto", MsgBoxStyle.Critical)
                Return False
            End If
            If Me._PenalID = -1 Then
                MsgBox("No se ha enviado el parametro PenalID al objeto", MsgBoxStyle.Critical)
                Return False
            End If
            'verificar si existe duplicados
            For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                If dgwExpediente.Item("col_expe_id", i).Value = IDExpediente Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Operación cancelada, el expediente ya se encuentra anexada")
                    Return False
                End If
            Next
            Return True
        End Function
        Public Function Validar() As Boolean

            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion por lo menos debe tener un expediente")
                Return False
            End If

            If dgwDelito.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Expediente por lo menos debe tener un delito / agraviado")
                Return False
            End If

            'validar el centro de salud de inimputable
            If esInimputable = True Then
                If Me._grillaIdCentroSalud < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar Establecimiento mental ó [NO INDICA]")
                    Return False
                End If
            End If

            Dim ResExp As Boolean = False
            Dim SenDel As Boolean = False
            Dim strNombreDelito As String = ""
            For i As Integer = 0 To dgwDelito.Rows.Count - 1
                If dgwDelito.Item("col_tip_reso_id", i).Value < 1 Then
                    strNombreDelito = dgwDelito.Item("col_del_esp_nom", i).Value
                    ResExp = True
                    Exit For
                End If
                If dgwDelito.Item("col_tip_sent", i).Value < 1 Then
                    strNombreDelito = dgwDelito.Item("col_del_esp_nom", i).Value
                    SenDel = True
                    Exit For
                End If
            Next
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD Then
                For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                    Select Case dgwExpediente.Item("col_exp_res_id", i).Value
                        Case 39 'confirmar la sentencia
                        Case Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar nuevo tipo de resolucion.")
                            dgwExpediente.Focus()
                            Return False
                    End Select
                Next
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior Or
                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema Then
                If ResExp = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar tipo de resolucion en el delito [" & strNombreDelito & "]")
                    dgwExpediente.Focus()
                    Return False
                End If
            End If
            If SenDel = True Then
                Select Case Me._TipoResolucion
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Pena_Limitativa,
                        Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD,
                         Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD_Consentida
                    Case Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar tipo de sentencia en el delito [" & strNombreDelito & "]")
                        dgwExpediente.Focus()
                        Return False
                End Select
            End If
            Dim blnValorTxt As Boolean = False
            Dim blnValorDgv As Boolean = False

            ValidarRevocatoriaLibertadV2()
            If blnValorLib = True Then
                Return False
            End If
            Return True
        End Function
        Private blnValorLib As Boolean = False
        Private entMov As Entity.Registro.InternoMovimiento
        Private bssMov As Bussines.Registro.InternoMovimiento
        Private EntExpedienteAux As Entity.Registro.Expediente
        Private blnCondicionLib As Boolean = False
        Private objBssExp As Bussines.Registro.Expediente
        Public Function ValidarRevocatoriaLibertadV2() As Boolean
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Traslado Or
                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas Or
                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Or
                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda Then
                blnValorLib = False
                Exit Function
            End If
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                blnValorLib = False
                Exit Function
            End If
            blnValorLib = False
            entMov = New Entity.Registro.InternoMovimiento
            entMov.InternoID = Me._InternoId
            entMov.IngresoID = Me._InternoIngresoId
            entMov.IngresoInpeId = Me._InternoIngresoInpeId
            entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
            bssMov = New Bussines.Registro.InternoMovimiento
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                entMov = bssMov.Listar_LM(entMov)
            Else
                entMov = bssMov.Listar(entMov)
            End If
            If entMov Is Nothing Then
                Exit Function
            End If
            If entMov.Codigo < 1 Then
                Exit Function
            End If

            Dim intConta As Integer = 0
            Dim intContaLib As Integer = 0
            Dim strMensaje As String = ""
            Dim objEntExpedienteCol_rev As New Entity.Registro.ExpedienteCol
            Dim objExp As New Entity.Registro.Expediente
            objExp.InternoID = Me._InternoId
            objExp.IngresoID = Me._InternoIngresoId
            objExp.IngresoInpeId = Me._InternoIngresoInpeId

            strMensaje = "Existe un [movimiento de libertad], Si hace click en :" + Chr(13) +
                         " " + Chr(13) +
                         "[Aceptar] El movimiento de libertad se eliminara." + Chr(13) +
                         "[Cancelar] el proceso sera cancelado."

            Dim blnValor As Boolean = False
            objBssExp = New Bussines.Registro.Expediente
            If Me._DocumentoJudicialID > 0 Then
                For Each ent_ As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    EntExpedienteAux = New Entity.Registro.Expediente


                    Dim index As Integer = ent_.Codigo
                    While index > 0
                        objEntExpPadre.InternoExpedienteRefPadreId = index
                        Dim padre As New Entity.Registro.InternoExpedientePadre
                        padre = objBssExpedientePad.Listar(objEntExpPadre)
                        If padre.InternoExpedienteId > 0 Then
                            EntExpedienteAux.Codigo = padre.InternoExpedienteId
                        End If
                        index = padre.InternoExpedienteId
                    End While
                    If EntExpedienteAux.Codigo > 0 Then
                        EntExpedienteAux = objBssExp.Listar(EntExpedienteAux).Expediente(0)
                        If EntExpedienteAux.LibertadTipoID < 1 Then
                            blnValor = True
                            Exit For
                        End If
                    ElseIf EntExpedienteAux.Codigo = -1 And ent_.LibertadTipoID < 1 Then
                        blnValor = True
                        Exit For
                    End If
                Next
                If entMov.Codigo > 0 And blnValor = True Then
                    If MessageBox.Show(strMensaje, "Inpe - SIP-POPE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        blnCondicionLib = True
                    Else
                        blnCondicionLib = False
                        blnValorLib = True
                    End If
                Else
                    blnCondicionLib = False
                End If
            Else
                'If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Then
                '    If objEntExpedienteCol Is Nothing Then
                '        blnValor = True
                '    Else
                '        objEntExpedienteTempoCol = objEntExpedienteCol
                '    End If
                'End If
                For Each ent_ As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    EntExpedienteAux = New Entity.Registro.Expediente
                    Dim index As Integer = ent_.Codigo
                    While index > 0
                        objEntExpPadre.InternoExpedienteRefPadreId = index
                        Dim padre As New Entity.Registro.InternoExpedientePadre
                        padre = objBssExpedientePad.Listar(objEntExpPadre)
                        If padre.InternoExpedienteId > 0 Then
                            EntExpedienteAux.Codigo = padre.InternoExpedienteId
                        End If
                        index = padre.InternoExpedienteId
                    End While
                    If EntExpedienteAux.Codigo > 0 Then
                        EntExpedienteAux = objBssExp.Listar(EntExpedienteAux).Expediente(0)
                        If EntExpedienteAux.LibertadTipoID < 1 Then
                            blnValor = True
                            Exit For
                        End If
                    ElseIf EntExpedienteAux.Codigo = -1 And ent_.LibertadTipoID < 1 Then
                        blnValor = True
                        Exit For
                    End If
                Next
                If entMov.Codigo > 0 And blnValor = True Then
                    If MessageBox.Show(strMensaje, "Inpe - SIP-POPE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        blnCondicionLib = True
                        blnValorLib = False
                    Else
                        blnCondicionLib = False
                        blnValorLib = True
                    End If
                Else
                    blnCondicionLib = False
                End If
            End If
            Return blnCondicionLib
        End Function
      
        Private Function AEliminarAgraviadoBD(Codigo As Integer) As Integer
            Dim value As Integer = -1
            If Codigo > 0 Then value = (New Bussines.Registro.InternoAgraviado).Eliminar(Codigo, Me.FlagTransferSede)
            Return value
        End Function

        Private Function AEliminarDelitoBD(Codigo As Integer) As Integer
            Dim value As Integer = -1
            If Codigo > 0 Then value = (New Bussines.Registro.Delito).Eliminar2(Codigo, Me.FlagTransferSede)
            Return value
        End Function

        Private Function AEliminarExpedienteBD(Codigo As Integer) As Integer
            'falta referenciar al padre
            Dim value As Integer = -1
            If Codigo > 0 Then
                objBssExpediente = New Bussines.Registro.Expediente
                value = objBssExpediente.Eliminar2(Codigo, Me.FlagTransferSede)
                If value > 0 Then
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    objBssExpedientePad.Eliminar(intPadre, Me.FlagTransferSede)
                    objBssExpediente.GrabarEstadoVisibilidad(intPadre, True, Me.FlagTransferSede)
                End If
            End If
            Return value

        End Function
        Private Function ValidarEliminar(Codigo As Integer) As Boolean
            For Each EntVal As Entity.Registro.Expediente In objEntExpedienteTempoCol
                If Codigo = EntVal.Codigo Then
                    Return False
                    Exit For
                End If
            Next
            Return True
        End Function
        Public Sub ActualizarDatosTipoInimputable(idTipoInimputable As Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente,
                                                idCentroSaludMental As Short)

            Select Case Me._TipoResolucion
                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Sentencia

                    dgwExpediente.SelectedRows(0).Cells("col_id_tip_imim").Value = idTipoInimputable
                    dgwExpediente.SelectedRows(0).Cells("col_id_cen_sal_men").Value = idCentroSaludMental

                    objEntExpedienteTempoCol.Item(0).MotivoIngresoID = idTipoInimputable
                    objEntExpedienteTempoCol.Item(0).EstablecimientomentalId = idCentroSaludMental

            End Select

        End Sub
        Public Sub actualizarDatosInimputable(esInimputable As Boolean)

            Me.esInimputable = esInimputable

            If esInimputable = True Then
                'Me.gbDuracioncondena.Text = "Duración de la medida de seguridad"
                'Me.gbComputo.Text = "Cómputo de la medida de seguridad"

                ActualizarDatosTipoInimputable(Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable, -1)
            Else
                'Me.gbDuracioncondena.Text = "Duración de la condena"
                'Me.gbComputo.Text = "Cómputo"

                ActualizarDatosTipoInimputable(Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.NoPertenece, -1)
            End If

            'Me._TituloPeriodoCondena = gbComputo.Text

        End Sub
#End Region
#Region "Formularios"
        Private Sub FrmAgregarInimputable(idTipoInimputable As Short, idCentroSaludMental As Short)

            Dim frm As New Registro.Expediente.frmDatosInimputablesPopup
            With frm
                'frm.blnReferenciado = IIf(UscExpeDeResolucionIng1.intReferenciado = 0, False, True)                
                ._idTipoDocumentoJudicial = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Sentencia
                ._idTipoImimputable = idTipoInimputable
                ._idCentroSaludMental = idCentroSaludMental
                If .ShowDialog = DialogResult.OK Then
                    ActualizarDatosTipoInimputable(._getIdInimputable, ._getIdCentroSaludMental)

                End If
            End With

        End Sub
#End Region
#Region "Otros"

        Private Sub ValoresxDefault()
            objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
            objEntDelitoTempoCol = New Entity.Registro.DelitoCol
            objEntAgraviadoTempoCol = New Entity.Registro.AgraviadoCol
            objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
        End Sub

#End Region

        Private Sub dgwExpediente_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellClick
            If dgwExpediente.Rows.Count > 0 Then
                Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
            End If
        End Sub

      
        Private Sub dgwExpediente_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellDoubleClick
            Dim columnIndex As Integer = e.ColumnIndex
            ' Obtenemos el nombre de la columna
            ' correspondiente a la celda
            Dim columnName As String = dgwExpediente.Columns.Item(columnIndex).Name
            If columnName = "col_exp_res" Or columnName = "col_exp_res" Then
            Else
                btnEditExpe_Click(Nothing, Nothing)
            End If
        End Sub
        Private Sub btnEditExpe_Click(sender As System.Object, e As System.EventArgs) Handles btnEditExpe.Click
            If dgwExpediente.Rows.Count = 0 Then Exit Sub
            RaiseEvent _Click_Expediente_Editar(Me.objEntExpedienteTempoCol.Expediente(Me.dgwExpediente.SelectedRows(0).Index))
        End Sub
        Private Sub btnEliminarExp_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarExp.Click
            Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)
        End Sub
        Private Sub btnAddExp_Click(sender As System.Object, e As System.EventArgs) Handles btnAddExp.Click
            If Me._DocumentoJudicialID > 0 Then
                If ValidarExpedienteReferenciado(1) = False Then
                    Exit Sub
                End If
            End If
            If dgwExpediente.Rows.Count > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion solo puede tener un expediente")
                Exit Sub
            End If

            RaiseEvent _Click_Expediente_Agregar()
        End Sub
        Private Sub btnAddAgrav_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAgrav.Click
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
        Private Sub btnDelAgrav_Click(sender As System.Object, e As System.EventArgs) Handles btnDelAgrav.Click
            If dgwDelito.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista no posee registros para elimimar")
                Exit Sub
            End If
            bolEdicionActivo = False
            Temporal_EliminarExpediente_Delito_Agraviado(False, True, False)
            dgwExpediente_CellClick(Nothing, Nothing)
            bolEdicionActivo = True
        End Sub
        Private Sub btnEditDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnEditDelito.Click
            bolEdicionActivo = False
            Temporal_Delito_Modificar()
            bolEdicionActivo = True
        End Sub

        Private Sub dgwDelito_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellDoubleClick
            Dim columnIndex As Integer = e.ColumnIndex
            ' Obtenemos el nombre de la columna
            ' correspondiente a la celda
            '
            Dim columnName As String = dgwDelito.Columns.Item(columnIndex).Name
            If columnName = "col_tip_reso" Or columnName = "col_tip_sent" Then
            Else
                btnEditDelito_Click(Nothing, Nothing)
            End If
        End Sub

        Public Sub New()
            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            ValoresxDefault()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        End Sub

        Private Sub dgwDelito_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellValueChanged
            If e.ColumnIndex = -1 Or e.RowIndex = -1 Or bolEdicionActivo = False Then Exit Sub

            If dgwDelito.Columns(e.ColumnIndex).Name = "col_tip_sent" Then
                For Each entAgrav As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If entAgrav.AgraviadoItem = dgwDelito.Item("col_agrav_item", e.RowIndex).Value Then entAgrav.TipoSentenciaId = dgwDelito.Item("col_tip_sent", e.RowIndex).Value
                Next
            End If

            If dgwDelito.Columns(e.ColumnIndex).Name = "col_tip_reso" Then
                For Each entAgrav As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If entAgrav.AgraviadoItem = dgwDelito.Item("col_agrav_item", e.RowIndex).Value Then
                        entAgrav.TipoResolucionId = dgwDelito.Item("col_tip_reso_id", e.RowIndex).Value
                    End If
                Next
            End If
        End Sub

        Private Sub dgwExpediente_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellContentClick
            dgwExpediente_CellClick(Nothing, Nothing)
            If e.RowIndex = -1 Then Exit Sub
            If dgwExpediente.Columns(e.ColumnIndex).Name = "col_exp_res_btn" Then
                RaiseEvent _click_VerResoluciones()
                For Each entExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    entExp.ResolucionID = dgwExpediente.Item("col_exp_res_id", e.RowIndex).Value
                Next
            End If
        End Sub

     

        Private Sub dgwExpediente_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellValueChanged
            If e.ColumnIndex = -1 Or e.RowIndex = -1 Or bolEdicionActivo = False Then Exit Sub

            If dgwExpediente.Columns(e.ColumnIndex).Name = "col_exp_res" Then
                For Each entExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If entExp.ExpedienteItem = dgwExpediente.Item("col_item", e.RowIndex).Value Then entExp.ResolucionNom = dgwExpediente.Item("col_exp_res", e.RowIndex).Value
                    entExp.ResolucionID = dgwExpediente.Item("col_exp_res_id", e.RowIndex).Value
                    If dgwDelito.Rows.Count > 0 Then
                        For i As Integer = 0 To dgwDelito.Rows.Count - 1
                            dgwDelito.Rows(i).Cells("col_tip_reso_ID").Value = entExp.ResolucionID
                            dgwDelito.Rows(i).Cells("col_tip_reso").Value = entExp.ResolucionNom
                        Next
                    End If
                Next
            End If
        End Sub

        Private Sub uscDetallResolucionEjecutoria_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        End Sub
        Public Sub _Load()
            dgwExpediente.Columns("col_exp_ref").ReadOnly = True
            dgwExpediente.Columns("col_flag").ReadOnly = True
            dgwExpediente.VisibleCampos = False
            Dim bssPar As New Bussines.General.Parametrica
            Select Case Me._TipoResolucion
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Pena_Limitativa
                    Me.col_exp_res_nom.Visible = False
                    Me.col_tip_reso.Visible = False
            End Select

            Me.col_tip_sent.DataSource = bssPar.Listar(Type.Combo.ComboTipo.TipoAclaratoriaExpediente, Type.Enumeracion.SubTipoDocJudicial.enumSubTipoCombo.Sentencias, Type.Enumeracion.SubTipoDocJudicial.enumSubTipoCombo.Sentencias, -1, True, "[Seleccionar]")
            Me.col_tip_sent.DisplayMember = "nombre"
            Me.col_tip_sent.ValueMember = "codigo"
            Me.col_tip_sent.Width = 150
            Me.col_tip_sent.DropDownWidth = 250

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

                If dgwDelito.Rows.Count = 0 Then Exit Sub
                bolEdicionActivo = False
                Temporal_EliminarExpediente_Delito_Agraviado(False, True, False)
                dgwExpediente_CellClick(Nothing, Nothing)
                bolEdicionActivo = True

            End If
        End Sub

        Private Sub dgwDelito_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellContentClick

        End Sub

        Private Sub btnInimputable_Click(sender As Object, e As EventArgs) Handles btnInimputable.Click

            If Me.dgwExpediente.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha encontrado ningún registro para agregar los datos")
                Exit Sub
            End If

            Dim idTipoInimputable As Short = dgwExpediente.SelectedRows(0).Cells("col_id_tip_imim").Value
            Dim idCentroSaludMental As Short = dgwExpediente.SelectedRows(0).Cells("col_id_cen_sal_men").Value

            FrmAgregarInimputable(idTipoInimputable, idCentroSaludMental)

        End Sub
    End Class
End Namespace