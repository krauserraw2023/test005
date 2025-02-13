Option Explicit On
Namespace Registro.Sentencias
    Public Class uscDetallResolucionIntegracionSent

        '/*bussiness*/
        Private objBssExpediente As Bussines.Registro.Expediente
        Private objBssPerCon As Bussines.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
        Private objBssExpedientePad As Bussines.Registro.InternoExpedientePadre
        '/*entitys*/
        Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing
        Private objEntExpediente As Entity.Registro.Expediente = Nothing
        Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objEntDelito As Entity.Registro.Delito = Nothing
        Private objEntAgraviado As Entity.Registro.Agraviado = Nothing
        Private objEntAgraviadoAux As Entity.Registro.AgraviadoCol = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Public _blnCadenaPerpetua As Boolean = False

#Region "Eventos"
        Public Event _Click_Expediente_Agregar()
        Public Event _Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)

        Public Event _Click_PeriodoCondena_Agregar()
        Public Event _Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)

        Public Event _Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol)
        Public Event _Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)

#End Region
#Region "Propiedades"
        Dim bolEdicionActivo As Boolean = False
        Private _btnAgregarPerido As Boolean = True
        Public Property btnAgregarPerido() As Boolean
            Get
                Return _btnAgregarPerido
            End Get
            Set(ByVal value As Boolean)
                btnAddPerCond.Enabled = value
                btnEditPerCond.Enabled = value
                btnDelPerCond.Enabled = value
            End Set
        End Property
        Private _btnCajasPeriodo As Boolean = False
        Public Property btnCajasPeriodo() As Boolean
            Get
                Return _btnCajasPeriodo
            End Get
            Set(ByVal value As Boolean)
                txtAnios.ReadOnly = value
                txtMeses.ReadOnly = value
                txtDias.ReadOnly = value

                txtAnios.Text = 0
                txtMeses.Text = 0
                txtDias.Text = 0
            End Set
        End Property
        Public Property _TotalAnhos() As Integer
            Get
                Try
                    Return txtAnios.Text
                Catch ex As Exception
                    Return 0
                End Try
            End Get
            Set(ByVal value As Integer)
                txtAnios.Text = value
            End Set
        End Property
        Public Property _TotalMes() As Integer
            Get
                Try
                    Return txtMeses.Text
                Catch ex As Exception
                    Return 0
                End Try
            End Get
            Set(ByVal value As Integer)
                txtMeses.Text = value
            End Set
        End Property
        Public Property _TotalDias() As Integer
            Get
                Try
                    Return txtDias.Text
                Catch ex As Exception
                    Return 0
                End Try
            End Get
            Set(ByVal value As Integer)
                txtDias.Text = value
            End Set
        End Property
        Public ReadOnly Property GrillaNroRegistroPeriodocondena() As Integer
            Get
                Try
                    Return dgvPeriodoCondNueva.Rows.Count
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
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
        Private Property blnEliminarColection As Boolean = False
        Private Property blnEliminarDelitoColec As Boolean = False
        Private Property blnEliminarAgraviadoColec As Boolean = False
        Private Property intCodigoExpediente As Integer = -1
        Public ReadOnly Property _GrillaDelito_ExpItem() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_exp_item").Value
                Catch ex As Exception
                    Return 0
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
                    Return dgvPeriodoCondena.SelectedRows(0).Cells("codigo").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaPeriodoCondenaItem() As Integer
            Get
                Try
                    Return dgvPeriodoCondena.SelectedRows(0).Cells("col_ped_cond_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaPeriodoCondenaNueItem() As Integer
            Get
                Try
                    Return dgvPeriodoCondNueva.SelectedRows(0).Cells("col_ped_cond_item").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property GrillaPeriodoCondenaItem_() As Integer
            Get
                Try
                    Return dgvPeriodoCondNueva.SelectedRows(0).Cells("col_ped_cond_item_").Value
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


        Private ReadOnly Property GrillaDocumentoJudID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value
                Catch ex As Exception
                    Return -1
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

        Private objEntDelitoIndc As New Entity.Registro.Delito
        Private objEntDelitoIndcCol As New Entity.Registro.DelitoCol
        Private objEntDelitoIndcCol2 As New Entity.Registro.DelitoCol
        Private objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol = Nothing
        Private objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing

        Private objEntAgraviadoTempoColGrilla As Entity.Registro.AgraviadoCol = Nothing
        Private objEntAgraviadosIndcCol As New Entity.Registro.AgraviadoCol
        Private objEntAgraviadosIndcCol2 As New Entity.Registro.AgraviadoCol
        Private objEntAgraviadosIndcCol3 As New Entity.Registro.AgraviadoCol
        Private objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
#Region "Listar"
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
        Private Sub Temporal_ListarDelitos(objEntExpediente As Entity.Registro.Expediente)
            If objEntDelitoTempoColGrilla Is Nothing Then
                objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
            End If
            If objEntExpediente Is Nothing Then
                'nada
            Else
                objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
                For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
                    If objEntExpediente.Codigo = obj.ExpedienteID Then
                        If obj.ExpedienteID > 0 Then

                            objEntDelito = New Entity.Registro.Delito
                            Temporal_DelitoCopiarPropiedades(objEntDelito, obj)


                            objEntDelito.ExpedienteItem = objEntExpediente.ExpedienteItem
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
                bolEdicionActivo = False 'levantar
                dgwDelito.RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoColGrilla
                    Temporal_ListarAgraviados(objDel)
                    For Each objAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoColGrilla
                        f = dgwDelito.Rows(dgwDelito.Rows.Add())
                        f.Cells("col_int_del_id").Value = objDel.Codigo
                        f.Cells("col_exp_id").Value = objDel.ExpedienteID
                        f.Cells("col_exp_item").Value = objDel.ExpedienteItem
                        f.Cells("col_del_item").Value = objDel.DelitoItem
                        f.Cells("col_del_esp_id").Value = objDel.DelitoEspecifico
                        f.Cells("col_del_esp_nom").Value = objDel.DelitoEspecificoNombre
                        f.Cells("col_del_gen_id").Value = objDel.DelitoGenerico
                        f.Cells("col_nom_del_gen").Value = objDel.DelitoGenericoNombre
                        f.Cells("col_del_obs").Value = objAgr.Observacion

                        f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaId

                        f.Cells("col_agrav_cod").Value = objAgr.Codigo
                        f.Cells("col_agrav_item").Value = objAgr.AgraviadoItem
                        f.Cells("col_agr_delito_item").Value = objAgr.DelitoItem
                        f.Cells("col_agr_exp_item").Value = objAgr.ExpedienteItem
                        f.Cells("col_agrav").Value = objAgr.AgraviadoNombre
                        f.Cells("col_agr_obs").Value = objAgr.Observacion
                    Next
                Next

                'listar_PeriodoCondena()
                bolEdicionActivo = True
            End If
        End Sub
        Private Sub Temporal_ListarDelitos2(objEntExpediente As Entity.Registro.Expediente)
            If objEntDelitoTempoColGrilla Is Nothing Then
                objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
            End If
            If objEntExpediente Is Nothing Then
                'nada
            Else
                'objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
                For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
                    If objEntExpediente.Codigo = obj.ExpedienteID Then
                        If obj.ExpedienteID > 0 Then

                            objEntDelito = New Entity.Registro.Delito
                            Temporal_DelitoCopiarPropiedades(objEntDelito, obj)


                            objEntDelito.ExpedienteItem = objEntExpediente.ExpedienteItem
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
                bolEdicionActivo = False 'levantar
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoColGrilla
                    Temporal_ListarAgraviados(objDel)
                    For Each objAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoColGrilla
                        f = dgwDelito.Rows(dgwDelito.Rows.Add())
                        f.Cells("col_int_del_id").Value = objDel.Codigo
                        f.Cells("col_exp_id").Value = objDel.ExpedienteID
                        f.Cells("col_exp_item").Value = objDel.ExpedienteItem
                        f.Cells("col_del_item").Value = objDel.DelitoItem
                        f.Cells("col_del_esp_id").Value = objDel.DelitoEspecifico
                        f.Cells("col_del_esp_nom").Value = objDel.DelitoEspecificoNombre
                        f.Cells("col_del_gen_id").Value = objDel.DelitoGenerico
                        f.Cells("col_nom_del_gen").Value = objDel.DelitoGenericoNombre
                        f.Cells("col_del_obs").Value = objDel.Observacion

                        f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaId

                        f.Cells("col_agrav_cod").Value = objAgr.Codigo
                        f.Cells("col_agrav_item").Value = objAgr.AgraviadoItem
                        f.Cells("col_agr_delito_item").Value = objAgr.DelitoItem
                        f.Cells("col_agr_exp_item").Value = objAgr.ExpedienteItem
                        f.Cells("col_agrav").Value = objAgr.AgraviadoNombre
                        f.Cells("col_agr_obs").Value = objAgr.Observacion
                        f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaId
                    Next
                Next

                'listar_PeriodoCondena()
                bolEdicionActivo = True
                objEntDelitoTempoCol = objEntDelitoTempoColGrilla
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
#End Region
#Region "Eliminar"
        Private Sub Temporal_EliminarExpediente_Delito_Agraviado(SelectExpediente As Boolean, SelectDelito As Boolean, SelectAgraviado As Boolean)
            Dim intCodigoExpediente As Integer = Me.GrillaExpedienteID

            If intCodigoExpediente > 0 Then
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                objEntExpPadre.InternoExpedienteId = intCodigoExpediente
                objEntExpPadre.IngresoID = Me._InternoIngresoId
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
                    If Me._GrillaExpedienteID > 0 And (Me._DocumentoJudicialID = Me.GrillaDocumentoJudID) Then
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

            If Me._GrillaExpedienteID > 0 And (Me._DocumentoJudicialID = Me.GrillaDocumentoJudID) Then
                For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1
                    If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then
                        objEntDelitoIndc.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                        objEntDelitoIndcCol.Add(objEntDelitoIndc)
                        objEntDelitoTempoCol.Delete(i)
                    End If
                Next
            Else
                For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1

                    If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then
                        Dim intCodigo As Integer = objEntDelitoTempoCol.Item(i).Codigo
                        objEntDelitoIndc.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                        objEntDelitoIndcCol.Add(objEntDelitoIndc)
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
                If Me.GrillaExpedienteID > 0 And (Me._DocumentoJudicialID = Me.GrillaDocumentoJudID) Then
                    blnEliminarColection = True

                    Dim Exp_ent As New Entity.Registro.Expediente
                    Exp_ent.Codigo = intCodigo
                    objEntExpedienteIndc.Add(Exp_ent)

                End If
                objEntExpedienteTempoCol.Remove(Me.GrillaExpedienteIndex)

                Temporal_ListarExpediente()
                Temporal_ListarDelitos(Nothing)
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
#End Region
#Region "Grabar"
        Private Sub Temporal_Grabar_Expediente_Delito_Agraviado2(objEntExpedienteCol As Entity.Registro.ExpedienteCol, objEntDelitoCol As Entity.Registro.DelitoCol,
                                                                objEntAgraviadoCol As Entity.Registro.AgraviadoCol)
            objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
            objEntAgraviadoTempoColGrilla = New Entity.Registro.AgraviadoCol
            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol
                objEntExpediente._RegionId = Me._RegionID
                objEntExpediente._PenalId = Me._PenalID
                Temporal_GrabarExpediente(objEntExpediente)
            Next
            Dim i As Integer = -1
            Dim j As Integer = -1
            For Each EntDel As Entity.Registro.Delito In objEntDelitoCol
                i = i + 1
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadoCol
                    j = j + 1

                Next
            Next
            Dim objEntPeriodoAuxTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
            Dim intContador As Integer = dgvPeriodoCondena.Rows.Count
            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol
                objEntPerCon.DocJudicialId = objEntExpediente.CreaDocJudicialId
                objEntPeriodoAuxTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)
                If objEntPeriodoCondenaTempoCol.Count = 0 Then
                    For Each EntPer As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoAuxTempoCol
                        intContador = intContador + 1
                        EntPer.PeriodoCondenaItem = intContador
                        objEntPeriodoCondenaTempoCol.Add(EntPer)
                    Next
                Else
                    For Each EntPer As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoAuxTempoCol 'indexar cada expediente
                        intContador = intContador + 1
                        EntPer.PeriodoCondenaItem = intContador
                        objEntPeriodoCondenaTempoCol.Add(EntPer)
                    Next
                End If
            Next


            Temporal_ListarExpediente()
            With dgwDelito
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntDelitoTempoColGrilla
            End With
        End Sub
        Public Sub _Temporal_Grabar_Expediente_Delito_Agraviado(objEnt As Entity.Registro.ExpedienteCol, objEntDel As Entity.Registro.DelitoCol, objEntAgr As Entity.Registro.AgraviadoCol)
            If ValidarTipoResolucion(Me._TipoResolucion) = True Then
                If dgwExpediente.Rows.Count = 0 Then
                    If objEnt.Count = 1 Then
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

                Temporal_Grabar_Expediente_Delito_Agraviado(objEnt, objEntDel, objEntAgr)

                Temporal_ListarExpediente()
                Temporal_ListarDelitos(objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
            End If
            dgwExpediente_CellClick(Nothing, Nothing)
        End Sub
        Private ContaExtra As Integer = -1
        Private Sub Temporal_Grabar_Expediente_Delito_Agraviado(objEntExpedienteCol As Entity.Registro.ExpedienteCol, objEntDelitoCol As Entity.Registro.DelitoCol,
                                                                objEntAgraviadoCol As Entity.Registro.AgraviadoCol)

            Dim entExpColAcum As New Entity.Registro.ExpedienteCol
            Dim objBssExp As New Bussines.Registro.Expediente
            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol
                objEntExpediente._RegionId = Me._RegionID
                objEntExpediente._PenalId = Me._PenalID

                If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                   objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                    ContaExtra = ContaExtra + 1
                    objEntExpediente.Codigo = 999999 + ContaExtra
                End If
                Temporal_GrabarExpediente(objEntExpediente)
                If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                   objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                    Dim objEntExpedienteCol2 As New Entity.Registro.ExpedienteCol
                    entExpColAcum = New Entity.Registro.ExpedienteCol
                    objBssExp = New Bussines.Registro.Expediente
                    objEntExpedienteCol2 = objBssExp.ListarExpedientexResolucion(objEntExpediente.CreaDocJudicialId)
                    For Each objEnt2 As Entity.Registro.Expediente In objEntExpedienteCol2
                        entExpColAcum.Add(objEnt2)
                        For Each objDelito As Entity.Registro.Delito In objEntDelitoCol

                            If objEnt2.Codigo = objDelito.ExpedienteID Then
                                objDelito.ExpedienteID = objEntExpediente.Codigo
                                objEnt2.ExpedienteItem = objEntExpediente.ExpedienteItem
                                objDelito.ExpedienteItem = objEntExpediente.ExpedienteItem
                                'grabar delitos
                                Temporal_GrabarDelito(objEnt2, objDelito, Nothing)
                            End If
                            For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                                objAgraviado.ExpedienteID = objEntExpediente.Codigo
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
                            objDelito.DelitoItem = Temporal_GrabarDelito(objEntExpediente, objDelito, Nothing)
                            For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                                If objDelito.Codigo = objAgraviado.DelitoID Then
                                    objAgraviado.ExpedienteItem = objEntExpediente.ExpedienteItem
                                    objAgraviado.DelitoItem = objDelito.DelitoItem
                                    Temporal_GrabarAgraviado(objDelito, objAgraviado)
                                End If
                            Next
                        End If
                    Next
                End If
            Next


            Temporal_ListarExpediente()
            objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol
                Temporal_ListarDelitos(objEntExpediente)
            Next


        End Sub

        Public Sub _Temporal_GrabarPeriodoCondena(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Temporal_GrabarPeriodoCondena(objEnt)
        End Sub
        Public Sub _Temporal_GrabarPeriodoNuevaCondena(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Temporal_GrabarPeriodoCondenaNuevo(objEnt)
        End Sub
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
            listar_PeriodoCondenaNuevo()
        End Sub
        Dim objEntPeriodoCondenaNuevaTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
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
            listar_PeriodoCondenaNuevo()
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
        Private Function TemporalPeriodoSentenciaItemMaximo() As Integer
            Dim intNumero As Integer = 0
            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaNuevaTempoCol
                If obj.PeriodoCondenaItem > intNumero Then intNumero = obj.PeriodoCondenaItem
            Next
            Return intNumero
        End Function
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
            dgwExpediente_CellClick(Nothing, Nothing)
        End Sub
        Private Function Temporal_GrabarExpediente(objEnt As Entity.Registro.Expediente) As Integer

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
            Return objEnt.ExpedienteItem
            'Temporal_ListarExpediente()
        End Function
        Private Sub Temporal_ExpedienteCopiarPropiedades(objEntOrigen As Entity.Registro.Expediente, ObjEntDestino As Entity.Registro.Expediente)
            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
                .TipoAutoridadJudicialID = .TipoAutoridadJudicialID
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
            End With

        End Sub
        Private Function TemporalExpedienteItemMaximo(objEntCol As Entity.Registro.ExpedienteCol) As Integer
            Dim intNumero As Integer = 0
            For Each obj As Entity.Registro.Expediente In objEntCol
                If obj.ExpedienteItem > intNumero Then intNumero = obj.ExpedienteItem
            Next
            Return intNumero
        End Function
        Public Sub EliminarPeriodo()
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia Then
                For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                    obj.FlgEliminado = 1
                Next
                dgvPeriodoCondena.DataSource = Nothing
            Else
                For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaNuevaTempoCol
                    obj.FlgEliminado = 1
                Next
                dgvPeriodoCondNueva.DataSource = Nothing
            End If

        End Sub
#End Region
#Region "Delito"
        Public Sub _Temporal_GrabarDelito(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntAgraviadoCol As Entity.Registro.AgraviadoCol, objAgr_Ind As Entity.Registro.AgraviadoCol)
            Temporal_GrabarDelito(objEntExpediente, objEntDelito, objEntAgraviadoCol)
            Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
        End Sub
        Private objEntDelitoFiltraCol As New Entity.Registro.DelitoCol
        Private Function Temporal_GrabarDelito(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito,
                                                  objEntAgraviadoCol As Entity.Registro.AgraviadoCol) As Integer

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
            Return objEntDelito.DelitoItem
        End Function
        Private Sub Temporal_DelitoCopiarPropiedades(objEntOrigen As Entity.Registro.Delito, ObjEntDestino As Entity.Registro.Delito)
            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
                .CreaDocJudicialId = ObjEntDestino.CreaDocJudicialId
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
                    objEnt.ExpedienteItem = objEnt.ExpedienteItem
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
        Public Sub _ListarExpediente(DocumentoJudicialID As Integer,
                                     Optional ByVal CargarMandDetencionHistorico As Boolean = True,
                                     Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False)

            col_tip_sent.DataSource = (New Bussines.General.Parametrica).Listar(Type.Combo.ComboTipo.TipoAclaratoriaExpediente, 17, 17, -1, True, "[Seleccionar]")
            col_tip_sent.DisplayMember = "nombre"
            col_tip_sent.ValueMember = "codigo"
            Me.col_tip_sent.DropDownWidth = 200

            If Me._DocumentoJudicialID < 1 Then 'si es nuevo y se muestra los checkeds
                'nada
                dgwExpediente.Columns("col_exp_ref").Visible = False
            Else
                lblTiempoCondena.Text = "Detalle de Fechas"
                dgvPeriodoCondNueva.Visible = True
                Dim objEntExpedienteColTmp As New Entity.Registro.ExpedienteCol
                Dim objEntDelitoColTmp As New Entity.Registro.DelitoCol
                Dim objEntAgraviadoCol As New Entity.Registro.AgraviadoCol
                objBssDelito = New Bussines.Registro.Delito
                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                objEntExpedienteColTmp = (New Bussines.Registro.Expediente).ListarExpedientexResolucion(Me._DocumentoJudicialID)
                '--------

                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteColTmp

                    objEntExpediente.ExpedienteItem = Temporal_GrabarExpediente(objEntExpediente)

                    Dim objDel As New Entity.Registro.Delito
                    objDel.InternoID = Me._InternoId
                    objDel.IngresoID = Me._InternoIngresoId
                    objDel.ExpedienteID = objEntExpediente.Codigo
                    objEntDelitoColTmp = objBssDelito.Listar2(objDel)

                    For Each objEntDelito As Entity.Registro.Delito In objEntDelitoColTmp

                        Dim DelitoItem As Integer = Temporal_GrabarDelito(objEntExpediente, objEntDelito, Nothing)
                        objEntAgraviadoCol = New Entity.Registro.AgraviadoCol
                        Dim objEnt As New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = -1
                            .DelitoID = objEntDelito.Codigo
                            .InternoID = Me._InternoId
                            .IngresoID = Me._InternoIngresoId
                            .ExpedienteID = objEntDelito.ExpedienteID
                            .TipoSentenciaId = -1
                            .AgraviadoNombre = ""
                        End With
                        objEntAgraviadoCol = objBssAgraviado.Listar(objEnt)

                        For Each objEntAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            objEntAgraviado.ExpedienteItem = objEntExpediente.ExpedienteItem
                            objEntAgraviado.DelitoItem = DelitoItem
                            Temporal_GrabarAgraviado(objEntDelito, objEntAgraviado)
                        Next

                    Next

                Next
                '____________
                objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                objEntPerCon.DocJudicialId = DocumentoJudicialID
                objEntPerCon.RegionId = Me._RegionID
                objEntPerCon.PenalId = Me._PenalID
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    objEntPerCon.PenalId = -1
                End If
                objEntPeriodoCondenaNuevaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)
                For i As Integer = 0 To objEntPeriodoCondenaNuevaTempoCol.Count - 1 'indexar cada expediente
                    objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
                Next

                listar_PeriodoCondenaNuevo()
                If Me._DocumentoJudicialID < 1 Then
                    listar_PeriodoCondena()
                Else
                    listar_PeriodoCondena_Mod()
                End If
                Temporal_ListarExpediente()
                If objEntExpedienteTempoCol.Count > 0 Then
                    Temporal_ListarDelitos(objEntExpedienteTempoCol.Expediente(dgwExpediente.SelectedRows(0).Index))
                End If

                'If ValidarExpedienteReferenciado(6) = False Then
                '    Me.txtAnios.ReadOnly = True
                '    Me.txtMeses.ReadOnly = True
                '    Me.txtDias.ReadOnly = True
                'End If

            End If

            bolEdicionActivo = True
        End Sub
        Private Sub ACopiarPropiedades(nuevo As Boolean, DocJudicial As Entity.Registro.DocumentoJudicial)

            Dim f As DataGridViewRow
            dgwDelito.Rows.Clear()
            bolEdicionActivo = False 'levantar
            For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                Temporal_ListarAgraviados(objDel)
                For Each objAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoColGrilla
                    f = dgwDelito.Rows(dgwDelito.Rows.Add())
                    f.Cells("col_int_del_id").Value = objDel.Codigo
                    f.Cells("col_exp_id").Value = objDel.ExpedienteID
                    f.Cells("col_exp_item").Value = objDel.ExpedienteItem
                    f.Cells("col_del_item").Value = objDel.DelitoItem
                    f.Cells("col_del_esp_id").Value = objDel.DelitoEspecifico
                    f.Cells("col_del_esp_nom").Value = objDel.DelitoEspecificoNombre
                    f.Cells("col_del_gen_id").Value = objDel.DelitoGenerico
                    f.Cells("col_nom_del_gen").Value = objDel.DelitoGenericoNombre
                    f.Cells("col_del_obs").Value = objDel.Observacion

                    f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaId

                    f.Cells("col_agrav_cod").Value = objAgr.Codigo
                    f.Cells("col_agrav_item").Value = objAgr.AgraviadoItem
                    f.Cells("col_agr_delito_item").Value = objAgr.DelitoItem
                    f.Cells("col_agr_exp_item").Value = objAgr.ExpedienteItem
                    f.Cells("col_agrav").Value = objAgr.AgraviadoNombre
                    f.Cells("col_agr_obs").Value = objAgr.Observacion
                    f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaId
                Next
            Next
            'Next
            Dim objExpediente As New Entity.Registro.Expediente
            Dim EntGrillaDelito As New Entity.Registro.DelitoCol
            Dim EntGrillaAgraviado As New Entity.Registro.AgraviadoCol
            objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
            With objExpediente
                .Codigo = -1
                .ExpedienteVisible = 1
                .InternoID = Me._InternoId
                .IngresoID = Me._InternoIngresoId  'reseteamos el numero ingreso del nuevo objeto expe al num ing actual
                .CreaDocJudicialId = DocJudicial.Codigo
                .ExpedienteNumero = DocJudicial.DocumentoNumero
                .AutoridadJudicialID = DocJudicial.DistritoJudicial
                .SalaJudicialID = DocJudicial.SalaJuzgado
                .ExpedienteJuez = DocJudicial.JuezNombre
                .ExpedienteSecretario = DocJudicial.SecretarioNombre
                .ExpedienteFechaDocRecepcion = DocJudicial.DocumentoFechaRecepcion
                .ExpedienteFecha = DocJudicial.DocumentoFecha
                .SituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
                .Observacion = DocJudicial.Observacion
                .ExpedienteItem = 1
            End With
            objEntExpedienteTempoCol.Add(objExpediente)
            For i As Integer = 0 To dgwDelito.Rows.Count - 1
                If EntGrillaDelito.Count = 0 Then
                    Dim EntDel_ As New Entity.Registro.Delito
                    Dim EntAgr_ As New Entity.Registro.Agraviado
                    With EntDel_
                        .Codigo = -1 'dgwDelito.Item("col_int_del_id", i).Value
                        .InternoID = Me._InternoId
                        .IngresoID = Me._InternoIngresoId
                        .DelitoEspecifico = dgwDelito.Item("col_del_esp_id", i).Value
                        .DelitoEspecificoNombre = dgwDelito.Item("col_del_esp_nom", i).Value
                        .DelitoGenerico = dgwDelito.Item("col_del_gen_id", i).Value
                        .Observacion = dgwDelito.Item("col_del_obs", i).Value
                        .AgraviadoNombre = dgwDelito.Item("col_agrav", i).Value
                        .DelitoItem = i + 1
                        .ExpedienteItem = 1
                    End With
                    EntGrillaDelito.Add(EntDel_)
                    With EntAgr_
                        .Codigo = -1 'dgwDelito.Item("col_agrav_cod", i).Value
                        .AgraviadoNombre = dgwDelito.Item("col_agrav", i).Value
                        .Observacion = dgwDelito.Item("col_agr_obs", i).Value
                        .TipoSentenciaId = dgwDelito.Item("col_tip_sent", i).Value
                        .DelitoItem = i + 1
                        .AgraviadoItem = i + 1
                        .ExpedienteItem = 1
                    End With
                    EntGrillaAgraviado.Add(EntAgr_)
                Else
                    Dim intValor As Integer = 0
                    For Each EntCom As Entity.Registro.Delito In EntGrillaDelito
                        If EntCom.DelitoEspecifico = dgwDelito.Item("col_del_esp_id", i).Value And
                           EntCom.AgraviadoNombre = dgwDelito.Item("col_agrav", i).Value Then
                            intValor = intValor + 1
                            Exit For
                        End If
                    Next
                    If intValor = 0 Then
                        Dim EntDel_ As New Entity.Registro.Delito
                        Dim EntAgr_ As New Entity.Registro.Agraviado
                        With EntDel_
                            .Codigo = -1 'dgwDelito.Item("col_int_del_id", i).Value
                            .InternoID = Me._InternoId
                            .IngresoID = Me._InternoIngresoId
                            .DelitoEspecifico = dgwDelito.Item("col_del_esp_id", i).Value
                            .DelitoEspecificoNombre = dgwDelito.Item("col_del_esp_nom", i).Value
                            .DelitoGenerico = dgwDelito.Item("col_del_gen_id", i).Value
                            .Observacion = dgwDelito.Item("col_del_obs", i).Value
                            .AgraviadoNombre = dgwDelito.Item("col_agrav", i).Value
                            .DelitoItem = i + 1
                            .ExpedienteItem = 1
                        End With
                        EntGrillaDelito.Add(EntDel_)
                        With EntAgr_
                            .Codigo = -1 'dgwDelito.Item("col_agrav_cod", i).Value
                            .AgraviadoNombre = dgwDelito.Item("col_agrav", i).Value
                            .Observacion = dgwDelito.Item("col_agr_obs", i).Value
                            .TipoSentenciaId = dgwDelito.Item("col_tip_sent", i).Value
                            .DelitoItem = i + 1
                            .AgraviadoItem = i + 1
                            .ExpedienteItem = 1
                        End With
                        EntGrillaAgraviado.Add(EntAgr_)
                    End If
                End If
            Next
            objEntDelitoTempoCol = EntGrillaDelito
            objEntAgraviadoTempoCol = EntGrillaAgraviado
            blnJuntaExp = True
            AGrabar(True, DocJudicial)
        End Sub
#End Region
#Region "Accion"
        Public Sub _Grabar(Nuevo As Boolean, DocumentoJudicial As Entity.Registro.DocumentoJudicial)
            EliminarExpedienteBD()
            AGrabar(Nuevo, DocumentoJudicial)
        End Sub
        Dim blnJuntaExp As Boolean = False
        Dim EntExpPad_Col As New Entity.Registro.ExpedienteCol
        Private Sub AGrabar(Nuevo As Boolean, DocJudicial As Entity.Registro.DocumentoJudicial)
            '------- grabar periodo de sentencia ----------> HNRB
            If blnJuntaExp = False Then
                objBssPerCon = New Bussines.Registro.Documento.PeriodoCondenaSentencia
                For Each entPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaNuevaTempoCol
                    entPerCond.DocJudicialId = DocJudicial.Codigo
                    entPerCond.InternoId = Me._InternoId
                    entPerCond.IngresoId = Me._InternoIngresoId
                    entPerCond.IngresoInpeId = Me._InternoIngresoInpeId
                    entPerCond.FlagTransferenciaSede = Me.FlagTransferSede
                    entPerCond.PenalId = Me._PenalID
                    entPerCond.RegionId = Me._RegionID
                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                        If entPerCond.FlgEliminado = True Then
                            If entPerCond.Codigo > 0 Then objBssPerCon.Eliminar(entPerCond.Codigo, Me.FlagTransferSede)
                        Else
                            objBssPerCon.Grabar_LM(entPerCond)
                        End If
                    Else
                        If entPerCond.FlgEliminado = True Then
                            If entPerCond.Codigo > 0 Then objBssPerCon.Eliminar(entPerCond.Codigo, Me.FlagTransferSede)
                        Else
                            objBssPerCon.Grabar(entPerCond)
                        End If
                    End If
                Next
            End If
            '--------------Grabar Expediente-------------------------------
            objBssExpediente = New Bussines.Registro.Expediente
            Dim objBssIntExpPad As New Bussines.Registro.InternoExpedientePadre
            Dim ent_ As New Entity.Registro.Expediente

            For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol
                Dim intExpedienteId As Integer = -1
                Dim ExpedienteOrigID As Integer = objExpediente.Codigo
                Dim DocumentoOrigID As Integer = objExpediente.CreaDocJudicialId

                With objExpediente
                    If Nuevo = True Then
                        If .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                         .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                            ent_ = New Entity.Registro.Expediente
                            ent_.CreaDocJudicialId = objExpediente.CreaDocJudicialId
                            Dim entCol As New Entity.Registro.ExpedienteCol
                            entCol = objBssExpediente.Listar_v2(ent_)
                            For Each ent__ As Entity.Registro.Expediente In entCol
                                objBssExpediente.GrabarEstadoVisibilidad(ent__.Codigo, False, Me.FlagTransferSede)
                            Next
                        Else
                            If ExpedienteOrigID > 0 Then objBssExpediente.GrabarEstadoVisibilidad(ExpedienteOrigID, False, Me.FlagTransferSede) 'ocultamos el original
                            .Codigo = -1
                        End If
                    Else

                        If (ExpedienteOrigID < 1 Or (ExpedienteOrigID > 0 And DocumentoOrigID <> DocJudicial.Codigo)) Then
                            objBssExpediente.GrabarEstadoVisibilidad(ExpedienteOrigID, False, Me.FlagTransferSede) 'ocultamos el original
                            .Codigo = -1
                        End If

                    End If
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .CreaDocJudicialId = DocJudicial.Codigo
                    .SituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
                    .ExpedienteVisible = 1
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                End With
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    intExpedienteId = objBssExpediente.Grabar_LM(objExpediente)
                Else
                    intExpedienteId = objBssExpediente.Grabar(objExpediente)
                End If

                If blnJuntaExp = False Then
                    Dim Ent As New Entity.Registro.Expediente
                    Ent.Codigo = intExpedienteId
                    EntExpPad_Col.Add(Ent)
                End If
                '---------------ExpedientePadre------------------------------
                Dim objIntExpPad As New Entity.Registro.InternoExpedientePadre
                With objIntExpPad
                    .InternoExpedienteId = intExpedienteId
                    .InternoExpedienteRefPadreId = ExpedienteOrigID   'intIdExpePadId
                    .InternoID = Me._InternoId
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .DocJudicialID = DocJudicial.Codigo
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                End With
                If Nuevo = True Then
                    If objExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                        objExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                        ent_ = New Entity.Registro.Expediente
                        ent_.CreaDocJudicialId = ExpedienteOrigID
                        For Each ent__ As Entity.Registro.Expediente In objBssExpediente.Listar_v2(ent_)
                            objIntExpPad.InternoExpedienteRefPadreId = ent__.Codigo
                            objBssIntExpPad.Grabar(objIntExpPad) 'guardar en BD
                        Next
                    Else
                        If ExpedienteOrigID > 0 And DocumentoOrigID <> DocJudicial.Codigo Then
                            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                                objBssIntExpPad.Grabar_LM(objIntExpPad) 'guardar en BD
                            Else
                                objBssIntExpPad.Grabar(objIntExpPad) 'guardar en BD
                            End If
                        End If
                    End If
                Else
                    If ExpedienteOrigID > 0 And DocumentoOrigID <> DocJudicial.Codigo Then
                        If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                            objBssIntExpPad.Grabar_LM(objIntExpPad) 'guardar en BD
                        Else
                            objBssIntExpPad.Grabar(objIntExpPad) 'guardar en BD
                        End If
                    End If
                End If

                Dim intIdDel As Integer = -1
                Dim intIdAgrav As Integer = -1
                '----------------------Registrar delitos-------------------------
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol 'objEntDelitoTempoColGrilla  'objEntDelitoTempoCol
                    If objExpediente.ExpedienteItem = objDel.ExpedienteItem Then
                        Dim codigoDelitoOri As Integer = objDel.Codigo
                        Dim creaDelitoOri As Integer = objDel.CreaDocJudicialId
                        objBssDelito = New Bussines.Registro.Delito
                        If Nuevo = True Then
                            objDel.Codigo = -1
                        Else
                            If codigoDelitoOri > 0 And creaDelitoOri <> DocJudicial.Codigo Then
                                objDel.Codigo = -1
                            End If
                        End If
                        objDel.ExpedienteID = intExpedienteId   'referencia al nuevo expediente
                        objDel.CreaDocJudicialId = DocJudicial.Codigo
                        objDel.InternoID = Me._InternoId
                        objDel.IngresoID = Me._InternoIngresoId
                        objDel.IngresoInpeId = Me._InternoIngresoInpeId
                        objDel.FlagTransferenciaSede = Me.FlagTransferSede
                        objDel.RegionID = Me._RegionID
                        objDel.PenalID = Me._PenalID
                        If codigoDelitoOri > 0 And creaDelitoOri <> DocJudicial.Codigo Then
                            objDel.CodigodelitoPad = codigoDelitoOri
                        End If
                        If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                            intIdDel = objBssDelito.Grabar_LM(objDel) 'Grabar Delitos
                        Else
                            intIdDel = objBssDelito.Grabar_v2(objDel) 'Grabar Delitos
                        End If

                        For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                            If objDel.DelitoItem = obj.DelitoItem Then
                                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                                Dim codigoAgraviadoOri As Integer = obj.Codigo
                                Dim creaAgraviadoOri As Integer = obj.CreaDocJudicialId
                                If Nuevo = True Then
                                    obj.Codigo = -1
                                Else
                                    If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocJudicial.Codigo Then
                                        obj.Codigo = -1
                                    End If
                                End If
                                obj.DelitoID = intIdDel
                                obj.ExpedienteID = intExpedienteId
                                obj.CreaDocJudicialId = DocJudicial.Codigo
                                obj.InternoID = Me._InternoId
                                obj.IngresoID = Me._InternoIngresoId
                                obj.IngresoInpeId = Me._InternoIngresoInpeId
                                obj.FlagTransferenciaSede = Me.FlagTransferSede
                                obj.RegionID = Me._RegionID
                                obj.PenalID = Me._PenalID
                                obj.TipoSentenciaId = IIf(obj.TipoSentenciaId = 0, -1, obj.TipoSentenciaId)
                                obj.TipoSentenciaHistoricoId = IIf(obj.TipoSentenciaId = 0, -1, obj.TipoSentenciaId)
                                If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocJudicial.Codigo Then 'creaAgraviadoOri
                                    obj.CodigoagraviadoPad = codigoAgraviadoOri
                                End If
                                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                                    intIdAgrav = objBssAgraviado.Grabar_LM(obj)
                                Else
                                    intIdAgrav = objBssAgraviado.Grabar(obj)
                                End If
                            End If
                        Next
                    End If
                Next

            Next
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
            If Me.dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La sentencia debe tener por lo menos un expediente")
                Return False
            End If
            If Me.dgwDelito.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Debe registrarse por lo menos un delito / agraviado")
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
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia Then
                If Me.dgwExpediente.Rows.Count < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La sentencia debe tener por lo menos 1 expediente")
                    Return False
                End If
            Else
                If Me.dgwExpediente.Rows.Count < 2 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La sentencia debe tener por lo menos 2 expedientes")
                    Return False
                End If
            End If

            If Me._DocumentoJudicialID < 1 Then
                Dim ExpNumero As String = ""
                Dim FilaExp_ As Integer = 0
                Dim FilaDel_ As Integer = 0
                'Validar expediente delito
                For j As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                    FilaExp_ = 0
                    ExpNumero = objEntExpedienteTempoCol.Expediente(j).ExpedienteNumero
                    For k As Integer = 0 To objEntDelitoTempoCol.Count - 1
                        If objEntDelitoTempoCol.Item(k).ExpedienteItem = objEntExpedienteTempoCol.Expediente(j).ExpedienteItem Then
                            FilaExp_ = FilaExp_ + 1
                        End If
                    Next
                    If FilaExp_ = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente: [" & ExpNumero & "] debe tener por lo menos un delito")
                        Return False
                    End If
                Next
            End If
            Dim contaRes As Integer = 0
            Dim contaResPos As Integer = 0
            Dim valor As Boolean = False
            Dim strNombreAgraviado As String = ""
            Dim strNombreDelito As String = ""
            Dim strNombreExpediente As String = ""
            For Each Ent1 As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                If Ent1.TipoSentenciaId < 1 Then
                    contaRes = contaRes + 1
                    strNombreAgraviado = Ent1.AgraviadoNombre
                    For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                        If Ent1.DelitoItem = objDel.DelitoItem Then
                            strNombreDelito = objDel.DelitoEspecificoNombre
                            For Each objExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                                If objDel.ExpedienteItem = objExp.ExpedienteItem Then
                                    strNombreExpediente = objExp.ExpedienteNumero
                                    Exit For
                                End If
                            Next
                            Exit For
                        End If
                    Next
                    Exit For
                Else
                    contaResPos = contaResPos + 1
                End If
            Next
            If objEntAgraviadoTempoCol.Count <> contaResPos Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente [" & strNombreExpediente & "]" + Chr(13) +
                                                                        "Delito [" & strNombreDelito & "]" + Chr(13) +
                                                                        "Agraviado [" & strNombreAgraviado & "]" + Chr(13) +
                                                                        "Seleccionar tipo de sentencia!!!")
                Return False
            End If
            '-------------------------
            Dim blnValorTxt As Boolean = False
            Dim blnValorDgv As Boolean = False
            If (txtAnios.Text = "0" Or txtAnios.Text = "") And (txtMeses.Text = "0" Or txtMeses.Text = "") And (txtDias.Text = "0" Or txtDias.Text = "") Then
                blnValorTxt = True
            End If
            If dgvPeriodoCondNueva.Rows.Count = 0 Then
                blnValorDgv = True
            Else
                Dim Valorfalse As Integer = 0
                For i As Integer = 0 To dgvPeriodoCondNueva.Rows.Count - 1
                    If dgvPeriodoCondNueva.Item("col_eliminado_", i).Value = True Then
                        Valorfalse = Valorfalse + 1
                    End If
                Next
                If Valorfalse = dgvPeriodoCondNueva.Rows.Count Then
                    blnValorDgv = True
                End If
            End If

            If _blnCadenaPerpetua = False Then
                If blnValorTxt = True And blnValorDgv = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar tiempo de condena o Periodo de condena")
                    txtAnios.Focus()
                    Return False
                End If
            End If
            '--------------------
            Return True
        End Function
        Private Function ValidarTipoResolucion(Valor As Integer) As Boolean
            Dim ListaTipo = {Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia}
            For Each Codigo As Integer In ListaTipo
                If Valor = Codigo Then
                    If Valor = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia Then
                        Return False
                    End If

                    Return True
                End If
            Next
            Return False
        End Function

        Public Sub EliminarExpedienteBD()
            If blnEliminarColection = True Then
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
            If blnEliminarDelitoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol2
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
                For Each EntDel As Entity.Registro.Delito In objEntDelitoIndcCol2
                    AEliminarDelitoBD(EntDel.Codigo)
                Next
            End If
            If blnEliminarAgraviadoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol3
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
            End If
        End Sub

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
        Public Function ValidarPeriodoCondena() As String
            objBssPerCon = New Bussines.Registro.Documento.PeriodoCondenaSentencia
            Return objBssPerCon.Validar(txtAnios.Text, txtMeses.Text, txtDias.Text, objEntPeriodoCondenaNuevaTempoCol)
        End Function
#End Region
#Region "Otros"


        Private Sub listar_PeriodoCondena()
            Panel12.Visible = True
            Dim objEntPeriodoAuxTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
            Dim intContador As Integer = dgvPeriodoCondena.Rows.Count

            objEntPerCon.DocJudicialId = Me.GrillaExpedienteSelect.CreaDocJudicialId

            objEntPeriodoAuxTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)

            objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            For Each EntPer As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoAuxTempoCol
                intContador = intContador + 1
                EntPer.PeriodoCondenaItem = intContador
                objEntPeriodoCondenaTempoCol.Add(EntPer)
            Next
            With dgvPeriodoCondena
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntPeriodoCondenaTempoCol  'IIf(objEntExpedienteTempoCol.Expediente(0) Is Nothing, Nothing, objEntExpedienteTempoCol)
            End With
            For i As Integer = 0 To dgvPeriodoCondena.Rows.Count - 1
                Me.dgvPeriodoCondena.CurrentCell = Nothing 'artificio para que no genere excepcion (bug de control)
                If dgvPeriodoCondena.Item("col_eliminado", i).Value = True Then Me.dgvPeriodoCondena.Rows(i).Visible = False
            Next
        End Sub
        Private Sub listar_PeriodoCondena_Mod()
            Dim entDocJud As New Entity.Registro.DocumentoJudicial
            Dim entExpedienteCol As New Entity.Registro.ExpedienteCol
            Dim objEntPeriodoAuxTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            Dim intContador As Integer = dgvPeriodoCondena.Rows.Count
            If Me._DocumentoJudicialID = Me.GrillaDocumentoJudID Then
                Dim objExpPad As New Entity.Registro.InternoExpedientePadre
                Dim objExpPadCol As New Entity.Registro.InternoExpedientePadreCol
                objExpPad.InternoExpedienteId = Me._GrillaExpedienteID
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                objExpPadCol = objBssExpedientePad.ListarGrilla(objExpPad)

                objBssExpediente = New Bussines.Registro.Expediente

                If objExpPadCol Is Nothing Or objExpPadCol.Count = 0 Then
                    txtAnios2.Text = ""
                    txtMeses2.Text = ""
                    txtDias2.Text = ""
                    With dgvPeriodoCondena
                        .DataSource = Nothing
                        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False
                        .DataSource = Nothing
                    End With
                Else
                    If entExpedienteCol.Count > 0 Then
                        Dim entExp As New Entity.Registro.Expediente
                        entExp.Codigo = objExpPadCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                        entExpedienteCol = objBssExpediente.Listar_v2(entExp)
                        objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia

                        objEntPerCon.DocJudicialId = entExpedienteCol.Expediente(0).CreaDocJudicialId
                        Dim ExpedienteID As Integer = entExpedienteCol.Expediente(0).Codigo

                        objBss = New Bussines.Registro.DocumentoJudicial
                        entDocJud.Codigo = entExpedienteCol.Expediente(0).CreaDocJudicialId
                        entDocJud = objBss.Listar_v2(entDocJud)
                        objEntPerCon.DocJudicialId = entExpedienteCol.Expediente(0).CreaDocJudicialId
                    End If

                    objEntPeriodoAuxTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)
                    objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
                    For Each EntPer As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoAuxTempoCol
                        intContador = intContador + 1
                        EntPer.PeriodoCondenaItem = intContador
                        objEntPeriodoCondenaTempoCol.Add(EntPer)
                    Next
                    txtAnios2.Text = entDocJud.SentenciaTotalAnios
                    txtMeses2.Text = entDocJud.SentenciaTotalMeses
                    txtDias2.Text = entDocJud.SentenciaTotalDias
                    With dgvPeriodoCondena
                        .DataSource = Nothing
                        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False
                        .DataSource = objEntPeriodoCondenaTempoCol
                    End With
                End If
                For i As Integer = 0 To dgvPeriodoCondena.Rows.Count - 1
                    Me.dgvPeriodoCondena.CurrentCell = Nothing 'artificio para que no genere excepcion (bug de control)
                    If dgvPeriodoCondena.Item("col_eliminado", i).Value = True Then Me.dgvPeriodoCondena.Rows(i).Visible = False
                Next
            Else
                If Me.GrillaDocumentoJudID < 1 Then
                    txtAnios2.Text = ""
                    txtMeses2.Text = ""
                    txtDias2.Text = ""
                    With dgvPeriodoCondena
                        .DataSource = Nothing
                        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False
                        .DataSource = Nothing
                    End With
                    Exit Sub
                End If
                entDocJud.Codigo = Me.GrillaDocumentoJudID
                objBss = New Bussines.Registro.DocumentoJudicial
                entDocJud = objBss.Listar(entDocJud)
                objEntPerCon.DocJudicialId = (Me.GrillaDocumentoJudID)
                objEntPeriodoAuxTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)
                objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
                For Each EntPer As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoAuxTempoCol
                    intContador = intContador + 1
                    EntPer.PeriodoCondenaItem = intContador
                    objEntPeriodoCondenaTempoCol.Add(EntPer)
                Next
                txtAnios2.Text = entDocJud.SentenciaTotalAnios
                txtMeses2.Text = entDocJud.SentenciaTotalMeses
                txtDias2.Text = entDocJud.SentenciaTotalDias

                With dgvPeriodoCondena
                    .DataSource = Nothing
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = objEntPeriodoCondenaTempoCol
                End With
                For i As Integer = 0 To dgvPeriodoCondena.Rows.Count - 1
                    Me.dgvPeriodoCondena.CurrentCell = Nothing 'artificio para que no genere excepcion (bug de control)
                    If dgvPeriodoCondena.Item("col_eliminado", i).Value = True Then Me.dgvPeriodoCondena.Rows(i).Visible = False
                Next

            End If

        End Sub

        Private Sub listar_PeriodoCondenaNuevo()
            With dgvPeriodoCondNueva
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntPeriodoCondenaNuevaTempoCol 'IIf(objEntExpedienteTempoCol.Expediente(0) Is Nothing, Nothing, objEntExpedienteTempoCol)
            End With
            For i As Integer = 0 To dgvPeriodoCondNueva.Rows.Count - 1
                Me.dgvPeriodoCondNueva.CurrentCell = Nothing 'artificio para que no genere excepcion (bug de control)
                If dgvPeriodoCondNueva.Item("col_eliminado_", i).Value = True Then Me.dgvPeriodoCondNueva.Rows(i).Visible = False
            Next
        End Sub

        Private Sub ValoresxDefault()
            objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
            objEntDelitoTempoCol = New Entity.Registro.DelitoCol
            objEntAgraviadoTempoCol = New Entity.Registro.AgraviadoCol
            objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            dgwExpediente.Columns("col_exp_ref").ReadOnly = True
        End Sub

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
                    Case 7
                        strMensaje = " [Operación cancelada]"
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
#End Region

        Private Sub dgwExpediente_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellClick
            If dgwExpediente.Rows.Count > 0 Then
                Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
                If Me._DocumentoJudicialID < 1 Then
                    ListarTiempoCondena()
                    listar_PeriodoCondena()
                Else
                    listar_PeriodoCondena_Mod()
                End If
            End If
        End Sub
        Private Sub ListarTiempoCondena()
            If dgwExpediente.Rows.Count > 0 And Me.GrillaExpedienteSelect.CreaDocJudicialId > 0 Then
                Dim EntDocJud As New Entity.Registro.DocumentoJudicial
                Dim objBss As New Bussines.Registro.DocumentoJudicial
                EntDocJud.Codigo = Me.GrillaExpedienteSelect.CreaDocJudicialId
                EntDocJud = objBss.Listar_v2(EntDocJud)
                txtAnios2.Text = EntDocJud.SentenciaTotalAnios
                txtMeses2.Text = EntDocJud.SentenciaTotalMeses
                txtDias2.Text = EntDocJud.SentenciaTotalDias
            Else
                txtAnios2.Text = ""
                txtMeses2.Text = ""
                txtDias2.Text = ""
            End If
        End Sub
        Private Sub btnEditPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnEditPerCond.Click
            If dgvPeriodoCondNueva.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione un periodo de condena para modificar")
                Exit Sub
            End If
            If dgvPeriodoCondNueva.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione un periodo de condena para modificar")
                Exit Sub
            End If
            For i As Integer = 0 To objEntPeriodoCondenaNuevaTempoCol.Count - 1
                If Me.GrillaPeriodoCondenaItem_ = objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                    RaiseEvent _Click_PeriodoCondena_Editar(objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i))
                    Exit For
                End If
            Next
        End Sub
        Private Sub btnDelPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnDelPerCond.Click
            If dgvPeriodoCondNueva.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista no posee registros para elimimar")
                Exit Sub
            End If
            If dgvPeriodoCondNueva.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para eliminar")
                Exit Sub
            End If
            If Me._DocumentoJudicialID > 1 Then
                If ValidarExpedienteReferenciado(5) = False Then
                    Exit Sub
                End If
            End If
            If Legolas.Configuration.Aplication.MessageBox.Question("¿Esta Seguro de eliminar el periodo de condena seleccionado?") = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To objEntPeriodoCondenaNuevaTempoCol.Count - 1
                    If Me.GrillaPeriodoCondenaItem_ = objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                        objEntPeriodoCondenaNuevaTempoCol.Remove(i)
                        listar_PeriodoCondenaNuevo()
                        Exit For
                    End If
                Next
            End If
        End Sub
        Private Sub btnAddPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPerCond.Click
            If Me._DocumentoJudicialID > 1 Then
                If ValidarExpedienteReferenciado(4) = False Then
                    Exit Sub
                End If
            End If
            RaiseEvent _Click_PeriodoCondena_Agregar()
        End Sub
        Private Sub dgwExpediente_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellDoubleClick
            btnEditExpe_Click(Nothing, Nothing)
        End Sub
        Private Sub btnEditExpe_Click(sender As System.Object, e As System.EventArgs) Handles btnEditExpe.Click
            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe existir al menos un expediente para modificar.")
                Exit Sub
            End If
            RaiseEvent _Click_Expediente_Editar(Me.objEntExpedienteTempoCol.Expediente(Me.dgwExpediente.SelectedRows(0).Index))
        End Sub
        Private Sub btnEliminarExp_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarExp.Click
            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista no posee registros para elimimar")
                Exit Sub
            End If
            Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)
            If dgwExpediente.Rows.Count = 0 Then
                dgvPeriodoCondena.DataSource = Nothing
                txtAnios2.Text = ""
                txtMeses2.Text = ""
                txtDias2.Text = ""
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
        Private Sub btnAddAgrav_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAgrav.Click
            If Me._DocumentoJudicialID > 0 Then
                If ValidarExpedienteReferenciado(2) = False Then
                    Exit Sub
                End If
            End If
            If dgwExpediente.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe existir al menos un expediente para ingresar un delito.")
                Exit Sub
            End If
            bolEdicionActivo = False
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

        Private Sub dgwDelito_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellClick
            If dgwDelito.Rows.Count > 0 Then
                Dim abc As Integer = dgwDelito.SelectedRows(0).Cells("col_tip_sent").Value
            End If
        End Sub
        Private Sub dgwDelito_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellDoubleClick
            Dim columnIndex As Integer = e.ColumnIndex
            ' Obtenemos el nombre de la columna
            ' correspondiente a la celda
            '
            Dim columnName As String = dgwDelito.Columns.Item(columnIndex).Name
            If columnName = "col_tip_sent" Or columnName = "col_tip_sent" Then
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
        End Sub

        Private Sub dgvPeriodoCondNueva_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPeriodoCondNueva.CellDoubleClick
            If dgvPeriodoCondNueva.Rows.Count < 1 Then Exit Sub
            btnEditPerCond_Click(Nothing, Nothing)
        End Sub

        Private Sub uscDetallResolucionIntegracionSent_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            dgwExpediente.VisibleCampos = False
            dgwExpediente.Columns("col_flag").ReadOnly = True
            dgvPeriodoCondNueva.VisibleCampos = False
            dgvPeriodoCondena.VisibleCampos = False
            txtAnios.Text = ""
            txtMeses.Text = ""
            txtDias.Text = ""
        End Sub

        Private Sub dgwExpediente_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellContentClick

        End Sub

        Private Sub dgwExpediente_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyDown
            If e.KeyCode = Keys.Delete Then

                e.Handled = True

                Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)
                If dgwExpediente.Rows.Count = 0 Then
                    dgvPeriodoCondena.DataSource = Nothing
                    txtAnios2.Text = ""
                    txtMeses2.Text = ""
                    txtDias2.Text = ""
                End If


            End If
        End Sub

        Private Sub dgwDelito_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellContentClick

        End Sub

        Private Sub dgwDelito_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwDelito.KeyDown
            If e.KeyCode = Keys.Delete Then

                e.Handled = True

                If dgwDelito.Rows.Count = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista no posee registros para elimimar")
                    Exit Sub
                End If
                bolEdicionActivo = False
                Temporal_EliminarExpediente_Delito_Agraviado(False, True, False)
                dgwExpediente_CellClick(Nothing, Nothing)
                bolEdicionActivo = True
            End If
        End Sub

        Private Sub dgvPeriodoCondNueva_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPeriodoCondNueva.CellContentClick

        End Sub

        Private Sub dgvPeriodoCondNueva_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvPeriodoCondNueva.KeyDown
            If e.KeyCode = Keys.Delete Then

                e.Handled = True

                If dgvPeriodoCondNueva.Rows.Count = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista no posee registros para elimimar")
                    Exit Sub
                End If
                If dgvPeriodoCondNueva.CurrentRow Is Nothing Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para eliminar")
                    Exit Sub
                End If
                If Legolas.Configuration.Aplication.MessageBox.Question("¿Esta Seguro de eliminar el periodo de condena seleccionado?") = Windows.Forms.DialogResult.Yes Then
                    For i As Integer = 0 To objEntPeriodoCondenaNuevaTempoCol.Count - 1
                        If Me.GrillaPeriodoCondenaItem_ = objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                            objEntPeriodoCondenaNuevaTempoCol.Remove(i)
                            listar_PeriodoCondenaNuevo()
                            Exit For
                        End If
                    Next
                End If
            End If
        End Sub



        Private Sub dgwExpediente_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyUp
            If dgwExpediente.Rows.Count > 0 Then
                Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
                If Me._DocumentoJudicialID < 1 Then
                    ListarTiempoCondena()
                    listar_PeriodoCondena()
                Else
                    listar_PeriodoCondena_Mod()
                End If
            End If
        End Sub

        Private Sub dgwDelito_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwDelito.KeyUp
            If dgwDelito.Rows.Count > 0 Then
                Dim abc As Integer = dgwDelito.SelectedRows(0).Cells("col_tip_sent").Value
            End If
        End Sub

        Private Sub txtAnios_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnios.TextChanged
        End Sub
        Private Sub txtMeses_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMeses.TextChanged
        End Sub
        Private Sub txtDias_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDias.TextChanged
        End Sub
    End Class
End Namespace