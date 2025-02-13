Imports Type.Enumeracion.TipoDocJudicial
Namespace Registro.Sentencias
    Public Class uscDetallRegistroSentencia_v2
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
        Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing
        '/*Entitys temporal*/
        Private objEntExpedienteIndCol As Entity.Registro.ExpedienteCol
        Private objEntExpedienteInd As Entity.Registro.Expediente

        Private objEntDelitoIndc As Entity.Registro.Delito
        Private objEntDelitoIndcCol As Entity.Registro.DelitoCol

        Private objEntAgraviadosIndc As Entity.Registro.Agraviado
        Private objEntAgraviadosIndcCol As Entity.Registro.AgraviadoCol
        Private objBssExp As Bussines.Registro.Expediente
        Private objBssPad As New Bussines.Estadistica.PadinDelito

#Region "Eventos"
        Public Event _Click_Expediente_Agregar()
        Public Event _Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)

        Public Event _Click_PeriodoCondena_Agregar()
        Public Event _Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)

        Public Event _Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol)
        Public Event _Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)
        Public Event _click_VerSubtipoDocumentoJud()

#End Region
#Region "Variables"
        Private bolEdicionActivo As Boolean = False
        Private blnEliminarColection As Boolean = False
        Private blnEliminarDelitoColec As Boolean = False
        Private blnEliminarAgraviadoColec As Boolean = False
        Private esInimputable As Boolean = False
#End Region

#Region "Propiedades_Retorno"
        Public ReadOnly Property _getIdTipoInimputable As Short
            Get
                Return Me.grillaIdTipoInimputable
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
        '/* variables externas*/
        Public Property _TotalAnhos() As String
            Get
                Try
                    Return txtAnios.Text
                Catch ex As Exception
                    Return ""
                End Try
            End Get
            Set(ByVal value As String)
                txtAnios.Text = value
            End Set
        End Property
        Public Property _TotalMes() As String
            Get
                Try
                    Return txtMeses.Text
                Catch ex As Exception
                    Return ""
                End Try
            End Get
            Set(ByVal value As String)
                txtMeses.Text = value
            End Set
        End Property
        Public Property _TotalDias() As String
            Get
                Try
                    Return txtDias.Text
                Catch ex As Exception
                    Return ""
                End Try
            End Get
            Set(ByVal value As String)
                txtDias.Text = value
            End Set
        End Property
        Public ReadOnly Property GrillaNroRegistroPeriodocondena() As Integer
            Get
                Try
                    Return dgvPeriodoCondena.Rows.Count
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
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
        Public _blnCadenaPerpetua As Boolean = False
        Public ReadOnly Property _CadenaPerpetua() As Boolean
            Get
                Try
                    Return rbtCadenaperpetua.Checked
                Catch ex As Exception
                    Return False
                End Try
            End Get
        End Property
        Public _TituloPeriodoCondena As String = ""
        Public Property _Extramuro As Integer = -1
        Public Property _ExpedienteReferenciado As Integer = -1
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

        Private ReadOnly Property grillaIdCentroSalud As Short
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_id_cen_sal_men").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property grillaIdTipoInimputable As Short
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_id_tip_imim").Value
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
            End Set
        End Property

        Public Sub EliminarPeriodo()
            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                obj.FlgEliminado = 1
            Next
            dgvPeriodoCondena.DataSource = Nothing
        End Sub
#End Region
#Region "Propiedades_Retorno"
        Public ReadOnly Property _getIdCentroSaludMental As Integer
            Get
                Return Me.grillaIdCentroSalud
            End Get
        End Property
#End Region
#Region "Temporales"
        Public objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol = Nothing
        Private objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing
        Private objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
        Private objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol = Nothing
        Public objEntAgraviadoTempoColGrilla As Entity.Registro.AgraviadoCol = Nothing
        Public objEntPeriodoCondenaTempoCol As Entity.Registro.Documento.PeriodoCondenaSentenciaCol = Nothing

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
                If objEntExpediente.DocumentoTipoID = 19 Or objEntExpediente.DocumentoTipoID = 28 Or objEntExpediente.DocumentoTipoID = 29 Then
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

            Temporal_ListarExpediente()
            Temporal_ListarDelitos(Nothing)
            Temporal_ListarAgraviados(Nothing)

        End Sub

        Public Sub _Temporal_GrabarPeriodoCondena(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Temporal_GrabarPeriodoCondena(objEnt)
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
                    objEnt.DocJudicialId = Me._DocumentoJudicialID
                    objEnt.RegionId = Me._RegionID
                    objEnt.PenalId = Me._PenalID
                    objEnt.PeriodoCondenaItem = TemporalPeriodoSentenciaItemMaximo() + 1
                    objEntPeriodoCondenaTempoCol.Add(objEnt)
                End If
            End If
            Listar_PeriodoCondena()
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
            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                If obj.PeriodoCondenaItem > intNumero Then intNumero = obj.PeriodoCondenaItem
            Next
            Return intNumero
        End Function

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
                        f.Cells("col_id_tip_sen").Value = objAgr.TipoSentenciaId
                        f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaNombre
                        f.Cells("col_agrav_cod").Value = objAgr.Codigo
                        f.Cells("col_agrav_item").Value = objAgr.AgraviadoItem
                        f.Cells("col_agr_delito_item").Value = objAgr.DelitoItem
                        f.Cells("col_agr_exp_item").Value = objAgr.ExpedienteItem
                        f.Cells("col_agrav").Value = objAgr.AgraviadoNombre

                    Next
                Next
                bolEdicionActivo = True
            End If
            For i As Integer = 0 To dgwDelito.Rows.Count - 1
                dgwDelito.Item("col_nro", i).Value = i + 1
            Next
        End Sub
        Private Sub Temporal_ListarAgraviados(objEntDelito As Entity.Registro.Delito)
            If objEntDelito Is Nothing Then Exit Sub

            objEntAgraviadoTempoColGrilla = New Entity.Registro.AgraviadoCol
            For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                'PENDIENTEHNRB VERIFICAR SI CODIGO ALTERNATIVO FUNCIONA

                If obj.DelitoItem = objEntDelito.DelitoItem Then
                    objEntAgraviado = New Entity.Registro.Agraviado
                    Temporal_AgraviadoCopiarPropiedades(objEntAgraviado, obj)
                    objEntAgraviadoTempoColGrilla.Add(obj)
                End If
            Next

        End Sub
#Region "Eliminar"
        Private Sub Temporal_EliminarExpediente_Delito_Agraviado(SelectExpediente As Boolean, SelectDelito As Boolean, SelectAgraviado As Boolean)
            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un expediente para eliminar.")
                btnAddExp.Focus()
                Exit Sub
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            bolEdicionActivo = False
            objEntAgraviadosIndcCol = New Entity.Registro.AgraviadoCol
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
            Dim intIndice As Integer = -1
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                intIndice = i
                If Me._GrillaItemAgraviado = objEntAgraviadoTempoCol.Item(i).AgraviadoItem Then
                    intIndice = i
                    If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                        blnEliminarAgraviadoColec = True
                        Dim intCodigo As Integer = objEntAgraviadoTempoCol.Item(i).Codigo
                        If intCodigo > 0 Then
                            Dim AgrEnt As New Entity.Registro.Agraviado
                            AgrEnt.Codigo = intCodigo
                            objEntAgraviadosIndcCol.Add(AgrEnt)
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
            If Me.dgwDelito.RowCount > 0 Then
                If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                    blnEliminarDelitoColec = True
                    objEntDelitoIndcCol = New Entity.Registro.DelitoCol
                    objEntDelitoIndc = New Entity.Registro.Delito
                    Dim intCodigo As Integer = Me.GrillaDelitoID
                    objEntDelitoIndc.Codigo = intCodigo
                    objEntDelitoIndcCol.Add(objEntDelitoIndc)
                End If
                objEntDelitoTempoCol.Remove(Me.GrillaDelitoIndex)
            End If

        End Sub

        Private Sub Temporal_EliminarExpedienteAgraviado()
            objEntAgraviadosIndcCol = New Entity.Registro.AgraviadoCol
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemExpediente = objEntAgraviadoTempoCol.Item(i).ExpedienteItem Then
                    If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                        objEntAgraviadosIndc = New Entity.Registro.Agraviado
                        blnEliminarAgraviadoColec = True
                        objEntAgraviadosIndc.Codigo = objEntAgraviadoTempoCol.Item(i).Codigo
                        objEntAgraviadosIndcCol.Add(objEntAgraviadosIndc)
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
                        objEntDelitoIndcCol = New Entity.Registro.DelitoCol
                        objEntDelitoIndc = New Entity.Registro.Delito
                        Dim intCodigo As Integer = objEntDelitoTempoCol.Item(i).Codigo
                        objEntDelitoIndc.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                        objEntDelitoIndcCol.Add(objEntDelitoIndc)
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
                        objEntExpedienteIndCol = New Entity.Registro.ExpedienteCol
                        objEntExpedienteInd = New Entity.Registro.Expediente
                        objEntExpedienteInd.Codigo = intCodigo
                        objEntExpedienteIndCol.Add(objEntExpedienteInd)
                    End If
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

        Public strMensaje As String = ""
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

            'validar el centro de salud de inimputable
            If esInimputable = True Then
                If Me.grillaIdCentroSalud < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar el establecimiento de salud mental.")
                    Return False
                End If
            End If

            Dim FilaDel_ As Integer
            Dim DelNombre As String = ""
            For k As Integer = 0 To objEntDelitoTempoCol.Count - 1
                FilaDel_ = 0
                DelNombre = objEntDelitoTempoCol.Item(k).DelitoEspecificoNombre
                For l As Integer = 0 To objEntAgraviadoTempoCol.Count - 1
                    If objEntDelitoTempoCol.Delito(k).DelitoItem = objEntAgraviadoTempoCol.Item(l).DelitoItem Then
                        FilaDel_ = FilaDel_ + 1
                    End If
                Next
                If FilaDel_ = 0 Then
                    Exit For
                End If
            Next

            Dim TipSen_ As Integer = 0
            Dim Conta As Integer = 0
            For Each entAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                Conta = Conta + 1
                If entAgr.TipoSentenciaId < 1 Then
                    TipSen_ = TipSen_ + 1
                End If
            Next
            If (TipSen_ = 0 And Conta = 0) Or (TipSen_ > 0 And Conta > 0) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El delito / agraviado debe tener un tipo de sentencia")
                dgwDelito.Focus()
                Return False
            End If

            strMensaje = ""
            Select Case Me._TipoResolucion
                Case 17, 27, 21, 22
                    Dim blnTiempoCondena As Boolean = False
                    Dim blnPeriodoCondena As Boolean = False
                    If (txtAnios.Text = "0" Or txtAnios.Text = "") And (txtMeses.Text = "0" Or txtMeses.Text = "") And (txtDias.Text = "0" Or txtDias.Text = "") Then
                        blnTiempoCondena = True
                    End If
                    If dgvPeriodoCondena.Rows.Count = 0 Then
                        blnPeriodoCondena = True
                    Else
                        Dim Valorfalse As Integer = 0
                        For i As Integer = 0 To dgvPeriodoCondena.Rows.Count - 1
                            If dgvPeriodoCondena.Item("col_eliminado", i).Value = True Then
                                Valorfalse = Valorfalse + 1
                            End If
                        Next
                        If Valorfalse = dgvPeriodoCondena.Rows.Count Then
                            blnPeriodoCondena = True
                        End If
                    End If
                    If Me._CadenaPerpetua = False Then
                        If blnTiempoCondena = True And blnPeriodoCondena = True Then
                            If esInimputable = True Then
                                strMensaje = "No ha ingresado el Tiempo ni Periodo de condena" + Chr(13) +
                                             "de todas maneras..." + Chr(13) + " " + Chr(13) +
                                              "Desea guardar los datos"
                            Else
                                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionConsentida Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar tiempo de condena o Periodo de condena")
                                    txtAnios.Focus()
                                    Return False
                                End If
                            End If
                        End If
                    End If
            End Select

            ValidarRevocatoriaLibertadV2()
            Return True
        End Function
        Public entMov As Entity.Registro.InternoMovimiento
        Private blnValorLib As Boolean = False
        Private bssMov As Bussines.Registro.InternoMovimiento
        Private EntExpedienteAux As Entity.Registro.Expediente
        Private blnCondicionLib As Boolean = False
        Public Function ValidarRevocatoriaLibertadV2() As Boolean
            Select Case Me._TipoResolucion
                Case enumTipoDocumentoJudicial.Traslado, enumTipoDocumentoJudicial.Notas,
                     enumTipoDocumentoJudicial.Libertad, enumTipoDocumentoJudicial.Queda,
                     enumTipoDocumentoJudicial.Revocatoria_de_Libertad
                    Exit Function
            End Select
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                Exit Function
            End If
            blnValorLib = False
            entMov = New Entity.Registro.InternoMovimiento
            entMov.InternoID = Me._InternoId
            entMov.IngresoID = Me._InternoIngresoId
            entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
            bssMov = New Bussines.Registro.InternoMovimiento
            entMov = bssMov.Listar(entMov)
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

            strMensaje = "Existe un 'movimiento de libertad', Si hace click en :" + Chr(13) +
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
                    If EntExpedienteAux.Codigo > 0 And ent_.Codigo < 1 Then
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

                For Each ent_ As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    EntExpedienteAux = New Entity.Registro.Expediente
                    Dim codigo As Integer = ent_.Codigo
                    While codigo > 0
                        objEntExpPadre.InternoExpedienteRefPadreId = codigo
                        Dim padre As New Entity.Registro.InternoExpedientePadre
                        padre = objBssExpedientePad.Listar(objEntExpPadre)
                        If padre.InternoExpedienteId > 0 Then
                            EntExpedienteAux.Codigo = padre.InternoExpedienteId
                        End If
                        codigo = padre.InternoExpedienteId
                    End While
                    If EntExpedienteAux Is Nothing Then
                        blnValor = True
                        Exit For
                    ElseIf EntExpedienteAux.Codigo > 0 Then
                        EntExpedienteAux = New Entity.Registro.Expediente
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

        Public Function ValidarPeriodoCondena() As String
            objBssPerCon = New Bussines.Registro.Documento.PeriodoCondenaSentencia
            Return objBssPerCon.Validar(txtAnios.Text, txtMeses.Text, txtDias.Text, objEntPeriodoCondenaTempoCol)
        End Function
        Public Sub _actualizarDatosInimputable(esInimputable As Boolean)

            Me.esInimputable = esInimputable

            Dim idCentroSalud As Short = -1
            If Me.grillaIdCentroSalud > 0 Then
                idCentroSalud = Me.grillaIdCentroSalud
            End If

            If esInimputable = True Then
                Me.gbDuracioncondena.Text = "Duración de la medida de seguridad"
                Me.gbComputo.Text = "Cómputo de la medida de seguridad"
                pnlInmpMant.Visible = True
                gbComputo.Size = New Size(231, 50)
                actualizarDatosTipoInimputable(Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable, idCentroSalud)
            Else
                Me.gbDuracioncondena.Text = "Duración de la condena"
                Me.gbComputo.Text = "Cómputo"
                pnlInmpMant.Visible = False
                gbComputo.Size = New Size(231, 65)
                actualizarDatosTipoInimputable(Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.NoPertenece, idCentroSalud)
            End If

            Me._TituloPeriodoCondena = gbComputo.Text

        End Sub

        Public Sub EliminarExpedienteBD()
            If blnEliminarColection = True Then
                If ValidarEliminar(objEntExpedienteIndCol.Expediente(0).Codigo) = True Then
                    For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                        AEliminarAgraviadoBD(EntAgr.Codigo)
                    Next
                    For Each EntDel As Entity.Registro.Delito In objEntDelitoIndcCol
                        AEliminarDelitoBD(EntDel.Codigo)
                    Next
                    For Each EntExp As Entity.Registro.Expediente In objEntExpedienteIndCol
                        AEliminarExpedienteBD(EntExp.Codigo)
                    Next
                End If
            End If
            If blnEliminarDelitoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
                For Each EntDel As Entity.Registro.Delito In objEntDelitoIndcCol
                    AEliminarDelitoBD(EntDel.Codigo)
                Next
            End If
            If blnEliminarAgraviadoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadosIndcCol
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
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
            'validar si el delito ya esta seleccionado, cambiar por id
            'If objEntDelito.DelitoAuxiliar = True Then
            '    For i As Integer = 0 To dgwDelito.Rows.Count - 1
            '        If objEntDelito.DelitoEspecificoNombre = dgwDelito.Item("col_del_esp_nom", i).Value Then
            '            Legolas.Configuration.Aplication.MessageBox.Exclamation("El delito ya existe en la lista, no podra ser agregado.")
            '            Exit Sub
            '        End If
            '    Next
            'End If
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
            'dgwExpediente_CellClick(Nothing, Nothing)
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
                .TipoSentenciaNombre = ObjEntDestino.TipoSentenciaNombre
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

        Public Sub _ListarExpediente(ObjDocJudicial As Entity.Registro.DocumentoJudicial, intIDDocumentoJudTipo As Short, Optional ByVal CargarMandDetencionHistorico As Boolean = True,
                                     Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False)
            gbComputo.Size = New Size(231, 65)
            txtAnios.Text = ""
            txtMeses.Text = ""
            txtDias.Text = ""
            If Me._DocumentoJudicialID < 1 Then 'si es nuevo y se muestra los checkeds
                dgwExpediente.Columns("col_exp_ref").Visible = False
                'nada
            Else
                Dim objEntExpedienteColTmp As New Entity.Registro.ExpedienteCol
                Dim objEntDelitoColTmp As New Entity.Registro.DelitoCol
                Dim objEntAgraviadoCol As New Entity.Registro.AgraviadoCol
                objBssDelito = New Bussines.Registro.Delito
                objBssAgraviado = New Bussines.Registro.InternoAgraviado

                objEntExpedienteColTmp = (New Bussines.Registro.Expediente).ListarExpedientexResolucion(Me._DocumentoJudicialID)

                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteColTmp
                    If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Pena_Limitativa Then Me._Extramuro = objEntExpediente.Extramuro
                    Select Case objEntExpediente.DocumentoTipoID
                        Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Pena_Limitativa,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Resolucion
                            Me._Extramuro = objEntExpediente.Extramuro
                    End Select
                    Temporal_GrabarExpediente(objEntExpediente)
                    Dim objDel As New Entity.Registro.Delito
                    objDel.InternoID = Me._InternoId
                    objDel.IngresoID = Me._InternoIngresoId
                    objDel.ExpedienteID = objEntExpediente.Codigo
                    objEntDelitoColTmp = objBssDelito.Listar2(objDel)

                    For Each objEntDelito As Entity.Registro.Delito In objEntDelitoColTmp

                        Temporal_GrabarDelito(objEntExpediente, objEntDelito, Nothing)
                        Dim objent_ As New Entity.Registro.Agraviado
                        With objent_
                            .Codigo = -1
                            .DelitoID = objEntDelito.Codigo
                            .InternoID = Me._InternoId
                            .IngresoID = Me._InternoIngresoId
                            .ExpedienteID = objEntExpediente.Codigo
                            .TipoSentenciaId = -1
                            .AgraviadoNombre = ""
                        End With
                        objEntAgraviadoCol = objBssAgraviado.Listar(objent_)

                        For Each objEntAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            objEntDelito.DelitoAuxiliar = False
                            Temporal_GrabarAgraviado(objEntDelito, objEntAgraviado)
                        Next

                    Next

                Next
                '------------------------------ HNRB -------------------------------------->
                objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                objEntPerCon.DocJudicialId = ObjDocJudicial.Codigo ' DocumentoJudicialID
                objEntPerCon.RegionId = Me._RegionID
                objEntPerCon.PenalId = Me._PenalID
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    objEntPerCon.PenalId = -1
                End If
                objEntPeriodoCondenaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)
                For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1 'indexar cada expediente
                    objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
                Next
                '<--------------------------------------------------------------------------
                dgwExpediente_CellClick(Nothing, Nothing)

                With ObjDocJudicial
                    Me._TotalAnhos = .SentenciaTotalAnios
                    Me._TotalMes = .SentenciaTotalMeses
                    Me._TotalDias = .SentenciaTotalDias
                End With
            End If
            Listar_PeriodoCondena()
            bolEdicionActivo = True
            'If Me._DocumentoJudicialID > 0 Then
            '    If ValidarExpedienteReferenciado(6) = False Then
            '        Me.txtAnios.ReadOnly = True
            '        Me.txtMeses.ReadOnly = True
            '        Me.txtDias.ReadOnly = True
            '    End If
            'End If
        End Sub
        Private Sub Listar_PeriodoCondena()
            If objEntPeriodoCondenaTempoCol Is Nothing Then
                objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            End If
            'With dgvPeriodoCondena
            '    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            '    .AllowUserToResizeRows = False
            '    .AutoGenerateColumns = False
            '    .DataSource = Nothing
            '    .DataSource = IIf(objEntPeriodoCondenaTempoCol.Count < 1, Nothing, objEntPeriodoCondenaTempoCol)
            'End With
            For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1
                'Me.dgvPeriodoCondena.CurrentCell = Nothing 'artificio para que no genere excepcion (bug de control)
                'If dgvPeriodoCondena.Item("col_eliminado", i).Value = True Then Me.dgvPeriodoCondena.Rows(i).Visible = False
                dtpFechaInicio.ValueLong = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(0).FechaInicio
                dtpFechaFinal.ValueLong = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).FechaFin
            Next
        End Sub
        Public Sub Listar_PeriodoCondena(strFechaInicio As String, strFechaFinal As String)
            objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
            Dim pos As Integer = -1
            Dim FechaInicio As String() = strFechaInicio.Split(",")
            If strFechaInicio.Length = 0 Then
                objEntPerCon.FechaInicio = 0
            Else
                dtpFechaInicio.ValueLong = strFechaInicio
            End If
            If strFechaFinal.Length = 0 Then
                objEntPerCon.FechaFin = 0
            Else
                dtpFechaFinal.ValueLong = strFechaFinal
            End If

            With dgvPeriodoCondena
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = Nothing
                .DataSource = IIf(objEntPeriodoCondenaTempoCol.Count < 1, Nothing, objEntPeriodoCondenaTempoCol)
            End With
            For i As Integer = 0 To dgvPeriodoCondena.Rows.Count - 1
                Me.dgvPeriodoCondena.CurrentCell = Nothing 'artificio para que no genere excepcion (bug de control)
                If dgvPeriodoCondena.Item("col_eliminado", i).Value = True Then Me.dgvPeriodoCondena.Rows(i).Visible = False
            Next
        End Sub
#End Region
#Region "Validar"
        Private Function ValidarTipoResolucion(Valor As Integer) As Boolean
            Dim ListaTipo = {Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia}
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
                        strMensaje = "[Operación cancelada]"
                End Select

                Dim intValor As Integer = 0
                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    If objEntExpediente.Codigo > 0 Then
                        objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                        objEntExpPadre.InternoID = objEntExpediente.InternoID
                        If objBssExpedientePad.ExisteExpedienteHijo(objEntExpPadre) > 0 Then
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

        Public Sub _Grabar(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDoc As Entity.Registro.DocumentoJudicial)
            EliminarExpedienteBD()
            AGrabar(DocumentoJudicialID, Nuevo, EntDoc)
        End Sub
        Private Sub AGrabar(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDoc As Entity.Registro.DocumentoJudicial)
            '------- Grabar periodo de sentencia ----------> HNRB
            objBssPerCon = New Bussines.Registro.Documento.PeriodoCondenaSentencia
            For Each entPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                With entPerCond
                    .DocJudicialId = DocumentoJudicialID
                    .InternoId = Me._InternoId
                    .IngresoId = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .Anio = IIf(Me.txtAnios.Text.Length = 0, 0, Me.txtAnios.Text)
                    .Mes = IIf(Me.txtMeses.Text.Length = 0, 0, Me.txtMeses.Text)
                    .Dia = IIf(Me.txtDias.Text.Length = 0, 0, Me.txtDias.Text)
                    .FechaInicio = dtpFechaInicio.ValueLong
                    .FechaFin = dtpFechaFinal.ValueLong
                End With
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
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
            If (dtpFechaInicio.ValueLong > 0 Or dtpFechaFinal.ValueLong > 0) And objEntPeriodoCondenaTempoCol.Count = 0 Then
                Dim entPerCond As New Entity.Registro.Documento.PeriodoCondenaSentencia
                With entPerCond
                    .DocJudicialId = DocumentoJudicialID
                    .InternoId = Me._InternoId
                    .IngresoId = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .Anio = IIf(Me.txtAnios.Text.Length = 0, 0, Me.txtAnios.Text)
                    .Mes = IIf(Me.txtMeses.Text.Length = 0, 0, Me.txtMeses.Text)
                    .Dia = IIf(Me.txtDias.Text.Length = 0, 0, Me.txtDias.Text)
                    .FechaInicio = dtpFechaInicio.ValueLong
                    .FechaFin = dtpFechaFinal.ValueLong
                    .RegionId = Me._RegionID
                    .PenalId = Me._PenalID
                End With
                objEntPeriodoCondenaTempoCol.Add(entPerCond)
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    objBssPerCon.Grabar_LM(entPerCond)
                Else
                    objBssPerCon.Grabar(entPerCond)
                End If
            End If
            '-------Grabar expediente--------------------------------------
            objBssExp = New Bussines.Registro.Expediente
            Dim objBssIntExpPad As New Bussines.Registro.InternoExpedientePadre

            For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol
                Dim DocumentoOrigID As Integer = objExpediente.CreaDocJudicialId
                Dim ExpedienteOrigID As Integer = objExpediente.Codigo
                Dim DocumentotipoOrigId As Integer = objExpediente.DocumentoTipoID
                Dim intIdExpediente As Integer = -1

                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia Then
                    If EntDoc.SituacionJuridicaId > 0 Then
                        objExpediente.SituacionJuridicaID = EntDoc.SituacionJuridicaId
                    End If
                End If
                With objExpediente
                    If Nuevo = True Then
                        If objExpediente.Codigo > 0 And objExpediente.CreaDocJudicialId > 0 Then objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                        .Codigo = -1
                    Else
                        If (ExpedienteOrigID < 1 Or (ExpedienteOrigID > 0 And DocumentoOrigID <> DocumentoJudicialID)) Then
                            objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede)
                            .Codigo = -1
                        End If
                    End If
                    .ExpedienteVisible = 1
                    .CreaDocJudicialId = DocumentoJudicialID
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    ._TipoLicencia = Me._TipoLicencia
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .Extramuro = EntDoc.Extramuro
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                End With
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                    intIdExpediente = objBssExp.Grabar_LM(objExpediente)
                Else
                    objExpediente.DocumentoTipoID = Me._TipoResolucion
                    intIdExpediente = objBssExp.Grabar(objExpediente)
                End If
                '<---------------ExpedientePadre------------------------------
                Dim objIntExpPad As New Entity.Registro.InternoExpedientePadre
                With objIntExpPad
                    .InternoID = Me._InternoId
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .InternoExpedienteId = intIdExpediente
                    .InternoExpedienteRefPadreId = ExpedienteOrigID
                    .DocJudicialID = DocumentoJudicialID
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                    .FlagTransferenciaSede = Me.FlagTransferSede
                End With
                If Nuevo = True Then
                    Select Case DocumentotipoOrigId
                        Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                            For Each obj As Entity.Registro.Expediente In entExpColAcum
                                objBssExp.GrabarEstadoVisibilidad(obj.Codigo, False, Me.FlagTransferSede)
                                objIntExpPad.InternoExpedienteRefPadreId = obj.Codigo
                                objBssIntExpPad.Grabar(objIntExpPad)
                            Next
                        Case Else
                            If objExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                               objExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                               objExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                For Each obj As Entity.Registro.Expediente In entExpColAcum
                                    objBssExp.GrabarEstadoVisibilidad(obj.Codigo, False, Me.FlagTransferSede)
                                    objIntExpPad.InternoExpedienteRefPadreId = obj.Codigo
                                    objBssIntExpPad.Grabar(objIntExpPad)
                                Next
                            Else
                                If ExpedienteOrigID > 0 And DocumentoOrigID <> DocumentoJudicialID Then
                                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                                        objBssIntExpPad.Grabar_LM(objIntExpPad)
                                    Else
                                        objBssIntExpPad.Grabar(objIntExpPad) 'guardar en BD
                                    End If
                                End If
                            End If
                    End Select
                Else
                    If (ExpedienteOrigID < 1 Or (ExpedienteOrigID > 0 And DocumentoJudicialID <> DocumentoOrigID)) Then
                        objIntExpPad.InternoExpedienteId = intIdExpediente
                        objIntExpPad.InternoExpedienteRefPadreId = ExpedienteOrigID
                        If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                            objBssIntExpPad.Grabar_LM(objIntExpPad)
                        Else
                            objBssIntExpPad.Grabar(objIntExpPad)
                        End If
                    End If
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
                            If Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso Then
                                objDel.Codigo = -1
                            End If
                        Else
                            If objDel.Codigo > 0 And creaDelitoOri <> DocumentoJudicialID Then
                                objDel.Codigo = -1
                            End If
                        End If
                        objDel.ExpedienteID = intIdExpediente  'referencia al nuevo expediente
                        objDel.CreaDocJudicialId = DocumentoJudicialID
                        objDel.InternoID = Me._InternoId
                        objDel.IngresoID = Me._InternoIngresoId
                        objDel.IngresoInpeId = Me._InternoIngresoInpeId
                        objDel._TipoLicencia = Me._TipoLicencia
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
                                    If Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso Then
                                        obj.Codigo = -1
                                    End If
                                Else
                                    If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                        obj.Codigo = -1
                                    End If
                                End If
                                obj.DelitoID = intIdDel
                                obj.CreaDocJudicialId = DocumentoJudicialID
                                obj.ExpedienteID = intIdExpediente
                                obj.InternoID = Me._InternoId
                                obj.IngresoID = Me._InternoIngresoId
                                obj.IngresoInpeId = Me._InternoIngresoInpeId
                                obj._TipoLicencia = Me._TipoLicencia
                                obj.FlagTransferenciaSede = Me.FlagTransferSede
                                obj.RegionID = Me._RegionID
                                obj.PenalID = Me._PenalID
                                obj.TipoSentenciaId = IIf(obj.TipoSentenciaId = 0, -1, obj.TipoSentenciaId)
                                obj.TipoSentenciaHistoricoId = IIf(obj.TipoSentenciaHistoricoId = 0, -1, obj.TipoSentenciaHistoricoId)
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
                        objBssPad.GrabarPadinDelito(objDel, objExpediente, Nuevo, intIdDel)

                    End If
                Next
            Next
            If blnCondicionLib = True Then
                bssMov = New Bussines.Registro.InternoMovimiento
                entMov = New Entity.Registro.InternoMovimiento
                entMov.InternoID = Me._InternoId
                entMov.IngresoID = Me._InternoIngresoId
                entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                entMov = bssMov.Listar(entMov)
                bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
            End If
        End Sub

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

        Private Sub actualizarDatosTipoInimputable(idTipoInimputable As Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente,
                                                idCentroSaludMental As Short)

            Select Case Me._TipoResolucion
                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Sentencia

                    If dgwExpediente.RowCount > 0 Then

                        dgwExpediente.SelectedRows(0).Cells("col_id_tip_imim").Value = idTipoInimputable
                        dgwExpediente.SelectedRows(0).Cells("col_id_cen_sal_men").Value = idCentroSaludMental

                        objEntExpedienteTempoCol.Item(0).MotivoIngresoID = idTipoInimputable
                        objEntExpedienteTempoCol.Item(0).EstablecimientomentalId = idCentroSaludMental
                    End If

            End Select

        End Sub
        Public Sub _actualizarDatosInimputablesDesdeSentencia(idCentroSaludMental As Short)

            actualizarDatosTipoInimputable(Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable,
                                           idCentroSaludMental)

        End Sub
#End Region
#Region "Formularios"
        Private Sub FrmAgregarInimputable(idTipoInimputable As Short, idCentroSaludMental As Short)

            If idTipoInimputable = -1 Then
                idTipoInimputable = 0
            End If

            Dim frm As New Registro.Expediente.frmDatosInimputablesPopup
            With frm
                'frm.blnReferenciado = IIf(UscExpeDeResolucionIng1.intReferenciado = 0, False, True)                
                ._idTipoDocumentoJudicial = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Sentencia
                ._idTipoImimputable = idTipoInimputable
                ._idCentroSaludMental = idCentroSaludMental
                If .ShowDialog = DialogResult.OK Then
                    actualizarDatosTipoInimputable(._getIdInimputable, ._getIdCentroSaludMental)

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
        Private Sub ElimanarPeriodoCondena()
            If dgvPeriodoCondena.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un periodo de condena para eliminar")
                Exit Sub
            End If
            If dgvPeriodoCondena.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para eliminar")
                Exit Sub
            End If
            If Me._DocumentoJudicialID > 0 Then
                Dim intConta As Integer = 0
                For Each EntExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If EntExp.ExpedienteReferido = True Then
                        intConta = intConta + 1
                    End If
                Next
                If intConta > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede eliminar el periodo de condena, porque el expediente ya ha sido referenciado")
                    Exit Sub
                End If
            End If
            If Legolas.Configuration.Aplication.MessageBox.Question("¿Esta Seguro de eliminar el periodo de condena seleccionado?") = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1
                    If Me.GrillaPeriodoCondenaItem = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                        objEntPeriodoCondenaTempoCol.Remove(i)
                        Listar_PeriodoCondena()
                        Exit For
                    End If
                Next
            End If
        End Sub
        Public Sub ActualizarCombo(intCodigo As Integer, strNombre As String)

            dgwDelito.SelectedRows(0).Cells("col_id_tip_sen").Value = intCodigo
            dgwDelito.SelectedRows(0).Cells("col_tip_sent").Value = strNombre

        End Sub
        Public Sub CargarCadenaPerpetua(blnValor As Boolean)
            If blnValor = True Then
                Me.rbtCadenaperpetua.Checked = blnValor
            End If
        End Sub
#End Region

        Private Sub dgwExpediente_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            If dgwExpediente.Rows.Count > 0 Then
                Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
            End If
        End Sub

        Private Sub dgvPeriodoCondena_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPeriodoCondena.CellDoubleClick
            If dgvPeriodoCondena.Rows.Count < 1 Then Exit Sub
            btnEditPerCond_Click(Nothing, Nothing)
        End Sub

        Private Sub btnEditPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnEditPerCond.Click

            If dgvPeriodoCondena.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para modificar")
                Exit Sub
            End If
            If dgvPeriodoCondena.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para modificar")
                Exit Sub
            End If
            Dim intConta As Integer = 0

            For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1
                If Me.GrillaPeriodoCondenaItem = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                    If intConta > 0 Then
                        objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).ValorRef = True
                    End If
                    RaiseEvent _Click_PeriodoCondena_Editar(objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i))
                    Exit For
                End If
            Next
        End Sub

        Private Sub btnDelPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnDelPerCond.Click
            If dgvPeriodoCondena.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un periodo de condena para eliminar")
                Exit Sub
            End If
            If Me._DocumentoJudicialID > 0 Then
                If ValidarExpedienteReferenciado(5) = False Then
                    Exit Sub
                End If
            End If
            If dgvPeriodoCondena.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para eliminar")
                Exit Sub
            End If
            If Legolas.Configuration.Aplication.MessageBox.Question("¿Esta Seguro de eliminar el periodo de condena seleccionado?") = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1
                    If Me.GrillaPeriodoCondenaItem = objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                        objEntPeriodoCondenaTempoCol.Remove(i)
                        Listar_PeriodoCondena()
                        Exit For
                    End If
                Next
            End If
        End Sub

        Private Sub btnAddPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPerCond.Click
            If Me._DocumentoJudicialID > 0 And Me.grillaIdTipoInimputable < 1 Then
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

            If dgwExpediente.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione registro a modificar")
                Exit Sub
            End If

            RaiseEvent _Click_Expediente_Editar(Me.objEntExpedienteTempoCol.Expediente(Me.dgwExpediente.SelectedRows(0).Index))
        End Sub

        Private Sub btnEliminarExp_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarExp.Click

            Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)

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

            If dgwDelito.Columns(e.ColumnIndex).Name = "col_tip_sent" Then
                For Each entAgrav As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If entAgrav.AgraviadoItem = dgwDelito.Item("col_agrav_item", e.RowIndex).Value Then
                        entAgrav.TipoSentenciaId = dgwDelito.Item("col_id_tip_sen", e.RowIndex).Value
                    End If
                Next
            End If
        End Sub

        Private Sub uscDetallRegistroSentencia_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            dgwExpediente.VisibleCampos = False
            dgwExpediente.Columns("col_flag").ReadOnly = True
            dgvPeriodoCondena.VisibleCampos = False

            'deshabilitar los controles de mantenimiento 
            Select Case Me._TipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    Me.pnlExpeMant.Visible = False
                    Me.pnlMantBotAgraviados.Visible = False
                    Me.pnlMantBotPeriCondena.Visible = False
            End Select

        End Sub

        Private Sub dgwExpediente_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)

            If e.KeyCode = Keys.Delete Then

                e.Handled = True

                Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)

            End If


        End Sub

        Private Sub dgwDelito_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Delete Then
                e.Handled = True
                btnEditDelito.PerformClick()
            End If

        End Sub


        Private Sub dgvPeriodoCondena_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvPeriodoCondena.KeyDown
            If e.KeyCode = Keys.Delete Then

                e.Handled = True

                ElimanarPeriodoCondena()

            End If

        End Sub

        Private Sub dgwExpediente_RowStateChanged(sender As Object, e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs)
            If dgwExpediente.Rows.Count > 0 Then
                Temporal_ListarDelitos(Me.GrillaExpedienteSelect)
            End If
        End Sub

        Private Sub txtAnios_Click(sender As Object, e As System.EventArgs) Handles txtAnios.Click
            txtAnios.Focus()
        End Sub

        Private Sub txtAnios_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnios.KeyPress
            If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
                e.Handled = True
            End If
        End Sub

        Private Sub btnAddExp_Click(sender As System.Object, e As System.EventArgs) Handles btnAddExp.Click
            If Me._DocumentoJudicialID > 1 Then
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

        Private Sub dgwDelito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDelito.CellContentClick
            If e.RowIndex = -1 Then Exit Sub
            If dgwDelito.Columns(e.ColumnIndex).Name = "col_agr_btn" Then
                RaiseEvent _click_VerSubtipoDocumentoJud()
            End If
        End Sub

        Private Sub rbtTemporal_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTemporal.CheckedChanged, rbtCadenaperpetua.CheckedChanged
            Dim blnValor As Boolean = rbtTemporal.Checked
            If rbtTemporal.Checked = True Then
                txtAnios.Text = 0
                txtMeses.Text = 0
                txtDias.Text = 0
                txtAnios.Focus()
            Else
                txtAnios.Text = ""
                txtMeses.Text = ""
                txtDias.Text = ""
            End If
            txtAnios.Enabled = blnValor
            txtMeses.Enabled = blnValor
            txtDias.Enabled = blnValor
            'Me._blnCadenaPerpetua = Not (blnValor)
            txtAnios.ReadOnly = Not (blnValor)
            txtMeses.ReadOnly = Not (blnValor)
            txtDias.ReadOnly = Not (blnValor)
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

        Private Sub txtMeses_TextChanged(sender As Object, e As EventArgs) Handles txtMeses.TextChanged

        End Sub
    End Class
End Namespace