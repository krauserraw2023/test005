Option Explicit On
Imports System.ComponentModel.Design
Imports System.Linq
Imports Bussines.General
Imports Bussines.Visita

Namespace Registro.Sentencias
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
        Private objBssPad As New Bussines.Estadistica.PadinDelito
#Region "Eventos"
        Public Event _Click_Expediente_Agregar()
        Public Event _Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)

        Public Event _Click_PeriodoCondena_Agregar()
        Public Event _Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)

        Public Event _Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol)
        Public Event _Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)
        Public Event _click_VerResoluciones(Tipo As String)
        Public Event _click_ActivarContolExtramuro()
#End Region
#Region "Variables"
        Private esInimputable As Boolean = False
#End Region
#Region "Propiedades"
        Dim bolEdicionActivo As Boolean = False
        Private Property cadenaPerpetua As Boolean
            Get
                Return Me.rbCadenaperpetua.Checked
            End Get
            Set(value As Boolean)
                Me.rbCadenaperpetua.Checked = value
            End Set
        End Property
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
        Public Property btnAgregar() As Boolean
            Get
                Return Me.btnAddPerCond.Enabled
            End Get
            Set(ByVal value As Boolean)
                btnAddPerCond.Enabled = value
            End Set
        End Property
        Public Property btnModificar() As Boolean
            Get
                Return Me.btnEditPerCond.Enabled
            End Get
            Set(ByVal value As Boolean)
                btnEditPerCond.Enabled = value
            End Set
        End Property
        Public Property btnEliminar() As Boolean
            Get
                Return Me.btnDelPerCond.Enabled
            End Get
            Set(ByVal value As Boolean)
                btnDelPerCond.Enabled = value
            End Set
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
        Public Property _TituloPeriodocondena As String = ""
        Public Property _TipoSentenciaId As Integer = -1
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
        Public ReadOnly Property GrillaNroRegistroPeriodocondena() As Integer
            Get
                Try
                    Return dgvPeriodoCondNueva.Rows.Count
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
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
                    Return dgvPeriodoCondNueva.SelectedRows(0).Cells("col_ped_cond_item_").Value
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

        Public ReadOnly Property GrillaResolucionID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_exp_res_id").Value
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
        Public Sub ActualizarResolucion(ResolucionID As Integer, ResolucionNom As String)
            dgwExpediente.SelectedRows(0).Cells("col_exp_res_id").Value = ResolucionID
            dgwExpediente.SelectedRows(0).Cells("col_exp_res_nom").Value = ResolucionNom
            If dgwDelito.RowCount > 0 Then
                For i As Integer = 0 To dgwDelito.RowCount - 1
                    dgwDelito.Item("col_tip_reso_id", i).Value = ResolucionID
                    dgwDelito.Item("col_tip_reso", i).Value = ResolucionNom
                Next
            End If
        End Sub
        Public Sub ActualizarTipoSentencia(ResolucionID As Integer, ResolucionNom As String)
            dgwDelito.SelectedRows(0).Cells("col_tip_sent_id").Value = ResolucionID
            dgwDelito.SelectedRows(0).Cells("col_tip_sent").Value = ResolucionNom

            For Each agr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                If agr.AgraviadoItem = Me._GrillaAgraviado_Item Then
                    agr.TipoSentenciaId = ResolucionID
                    Exit For
                End If
            Next

        End Sub
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
        Public ReadOnly Property _GrillaAgraviadoId() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_agrav_cod").Value
                Catch ex As Exception
                    Return 0
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaAgraviado_Item() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_agrav_item").Value
                Catch ex As Exception
                    Return 0
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaAgraviadoDelito_Item() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_agr_delito_item").Value
                Catch ex As Exception
                    Return 0
                End Try
            End Get
        End Property

#End Region
#Region "Propiedades_Retorno"
        Public ReadOnly Property _getIdTipoInimputable As Short
            Get
                Return Me.grillaIdTipoInimputable
            End Get
        End Property
        Public ReadOnly Property _getCadenaperpetua As Boolean
            Get
                Return Me.cadenaPerpetua
            End Get
        End Property
#End Region
#Region "Temporales"

        Public objEntPeriodoCondenaTempoCol As Entity.Registro.Documento.PeriodoCondenaSentenciaCol = Nothing

        Public objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol = Nothing
        Private objEntExpedienteIndc As New Entity.Registro.ExpedienteCol

        Public objEntAgraviadoTempoColGrilla As Entity.Registro.AgraviadoCol = Nothing
        Public objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
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
            listarGrillaPeriodoCondenaNuevo()
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
            listarGrillaPeriodoCondenaNuevo()
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
        Private Sub listarGrillaPeriodoCondena()

            With dgvPeriodoCondena
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntPeriodoCondenaTempoCol
            End With

            For i As Integer = 0 To dgvPeriodoCondena.Rows.Count - 1
                Me.dgvPeriodoCondena.CurrentCell = Nothing 'artificio para que no genere excepcion (bug de control)
                If dgvPeriodoCondena.Item("col_eliminado", i).Value = True Then Me.dgvPeriodoCondena.Rows(i).Visible = False
            Next
        End Sub
        Public Sub _listarGrillaPeriodoCondenaNuevo(strFechaInicio As String, strFechaFinal As String)
            objEntPeriodoCondenaNuevaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol

            Dim pos As Integer = -1
            Dim FechaInicio As String() = strFechaInicio.Split(",")

            For Each fecha As String In FechaInicio
                pos += 1

                If pos Mod 2 = 0 Then
                    objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                    If fecha = "" Then
                        fecha = 0
                    End If
                    objEntPerCon.FechaInicio = fecha
                Else
                    objEntPerCon.FechaFin = fecha
                    objEntPerCon.RegionId = Me._RegionID
                    objEntPerCon.PenalId = Me._PenalID
                    objEntPeriodoCondenaNuevaTempoCol.Add(objEntPerCon)
                End If
            Next

            With dgvPeriodoCondNueva
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = Nothing
                .DataSource = IIf(objEntPeriodoCondenaNuevaTempoCol.Count < 1, Nothing, objEntPeriodoCondenaNuevaTempoCol)
            End With
            For i As Integer = 0 To dgvPeriodoCondNueva.Rows.Count - 1
                Me.dgvPeriodoCondNueva.CurrentCell = Nothing 'artificio para que no genere excepcion (bug de control)
                'If dgvPeriodoCondNueva.Item("col_eliminado", i).Value = True Then Me.dgvPeriodoCondNueva.Rows(i).Visible = False
            Next
        End Sub

        Private Sub listarGrillaPeriodoCondenaNuevo()

            If objEntPeriodoCondenaNuevaTempoCol Is Nothing Then
                objEntPeriodoCondenaNuevaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            End If

            With dgvPeriodoCondNueva
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = Nothing
                .DataSource = IIf(objEntPeriodoCondenaNuevaTempoCol.Count < 1, Nothing, objEntPeriodoCondenaNuevaTempoCol)
            End With

            For i As Integer = 0 To dgvPeriodoCondNueva.Rows.Count - 1
                Me.dgvPeriodoCondNueva.CurrentCell = Nothing 'artificio para que no genere excepcion (bug de control)
                If dgvPeriodoCondNueva.Item("col_eliminado_", i).Value = True Then Me.dgvPeriodoCondNueva.Rows(i).Visible = False
            Next
        End Sub

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
                objEntExpediente.ResolucionID = -1
                objEntExpediente.ResolucionNom = ""
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

                            'cargar los registros de agraviados
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

                        'cargar los registros de agraviados, x refrencia, 1ra vez
                        For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            If objDelito.Codigo = objAgraviado.DelitoID Then

                                objAgraviado.TipoResolucionId = -1
                                objAgraviado.TipoResolucionNom = ""
                                'objAgraviado.TipoSentenciaId = -1

                                objAgraviado.ExpedienteItem = objEntExpediente.ExpedienteItem
                                objAgraviado.DelitoItem = objDelito.DelitoItem
                                Temporal_GrabarAgraviado(objDelito, objAgraviado)
                            End If
                        Next

                    Next
                End If
            Next
            Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))

            '****************listar periodo de condena**************
            If objEntExpedienteCol Is Nothing Then Exit Sub
            objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
            objEntPerCon.DocJudicialId = objEntExpedienteCol.Expediente(0).CreaDocJudicialId

            objEntPeriodoCondenaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon) 'no LM
            If objEntExpedienteCol.Item(0).DocumentoTipoID = 25 Then  'cuando es conmutacion
                If objEntPeriodoCondenaTempoCol.Count > 1 Then
                    objEntPerCon.Tipo = 1
                    objEntPeriodoCondenaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar_V2(objEntPerCon)
                End If
            End If
            'For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1 'indexar cada expediente
            '    objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
            'Next
            listarGrillaPeriodoCondena()

            If Me._DocumentoJudicialID < 1 Then
                Dim entDocJud As New Entity.Registro.DocumentoJudicial
                objBss = New Bussines.Registro.DocumentoJudicial
                entDocJud.Codigo = objEntExpedienteCol.Expediente(0).CreaDocJudicialId ' Me._GrillaDocumentoJudID
                entDocJud = objBss.Listar(entDocJud)
                Me.txtAnios2.Text = entDocJud.SentenciaTotalAnios
                Me.txtMeses2.Text = entDocJud.SentenciaTotalMeses
                Me.txtDias2.Text = entDocJud.SentenciaTotalDias
                Select Case Me._TipoResolucion
                    Case 21, 22 'Ejecutorias
                        Me.txtAnios.Text = entDocJud.SentenciaTotalAnios
                        Me.txtMeses.Text = entDocJud.SentenciaTotalMeses
                        Me.txtDias.Text = entDocJud.SentenciaTotalDias
                        objEntPeriodoCondenaNuevaTempoCol = objEntPeriodoCondenaTempoCol
                        With dgvPeriodoCondNueva
                            .DataSource = Nothing
                            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                            .AllowUserToResizeRows = False
                            .AutoGenerateColumns = False
                            .DataSource = objEntPeriodoCondenaTempoCol
                        End With
                        For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                            dtpFechaInicio.ValueLong = obj.FechaInicio
                            dtpFechaFinal.ValueLong = obj.FechaFin
                        Next
                End Select
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
            If Not (objEntExpediente Is Nothing) Then

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
                        f.Cells("col_tip_reso_id").Value = objAgr.TipoResolucionId
                        f.Cells("col_tip_reso").Value = objAgr.TipoResolucionNom
                        If dgwDelito.Columns("col_sent_hist").Visible = True Then
                            f.Cells("col_tip_sent_id").Value = -1
                            f.Cells("col_tip_sent").Value = ""
                            f.Cells("col_sen_his_id").Value = objAgr.TipoSentenciaId
                            f.Cells("col_sent_hist").Value = objAgr.TipoSentenciaNombre
                            objAgr.TipoSentenciaHistoricoId = objAgr.TipoSentenciaId
                            objAgr.TipoSentenciaHistoricoNombre = objAgr.TipoSentenciaNombre
                        Else
                            f.Cells("col_tip_sent_id").Value = objAgr.TipoSentenciaId
                            f.Cells("col_tip_sent").Value = objAgr.TipoSentenciaNombre
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
        Private Sub Temporal_EliminarExpediente_Delito_Agraviado(SelectExpediente As Boolean, SelectDelito As Boolean,
                                                                 ByRef eliminoAgraviado As Boolean)

            eliminoAgraviado = False
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

                    'eliminar el agraviado / delito / Expediente
                    Temporal_EliminarExpedienteAgraviado()
                    Temporal_EliminarExpedienteDelito()
                    Temporal_EliminarExpediente()

                    TemporalEliminarPeriodo()
                    eliminoAgraviado = True
                End If
            End If
            If SelectDelito = True Then
                strMensaje = "Esta seguro de eliminar el delito, se eliminara sus agraviado !!!"
                Dim intCodigoDelito As Integer = Me.GrillaDelitoID
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then

                    'eliminar el agraviado
                    Temporal_EliminarDelitoAgraviado()
                    Temporal_EliminarDelito()
                    eliminoAgraviado = True
                End If
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

            If Me._DocumentoJudicialID > 0 And Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                If intCodigo > 0 Then
                    blnEliminarDelitoColec = True
                    EntDel.Codigo = intCodigo
                    objEntDelitoIndcCol2.Add(EntDel)
                End If
            ElseIf Me._DocumentoJudicialID = -1 Then

            End If
            objEntDelitoTempoCol.Remove(Me.GrillaDelitoIndex)

        End Sub

        Private Sub Temporal_EliminarExpedienteAgraviado()
            Dim AgraviadosIndc As New Entity.Registro.Agraviado
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemExpediente = objEntAgraviadoTempoCol.Item(i).ExpedienteItem Then
                    If Me._GrillaExpedienteID > 0 Then
                        If Me._DocumentoJudicialID > 0 And Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                            blnEliminarColection = True
                            AgraviadosIndc.Codigo = objEntAgraviadoTempoCol.Item(i).Codigo
                            objEntAgraviadosIndcCol.Add(AgraviadosIndc)
                        ElseIf Me._DocumentoJudicialID = -1 Then
                            AgraviadosIndc.Codigo = objEntAgraviadoTempoCol.Item(i).Codigo
                        End If
                    End If
                    objEntAgraviadoTempoCol.Remove(i)
                    'objEntAgraviadoTempoColGrilla.Remove(i)
                End If
            Next
        End Sub

        Private Sub Temporal_EliminarExpedienteDelito()
            Dim DelitoIndc As New Entity.Registro.Delito
            If Me._GrillaExpedienteID > 0 Then
                For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1
                    If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then

                        DelitoIndc.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                        objEntDelitoIndcCol.Add(DelitoIndc)
                        objEntDelitoTempoCol.Remove(i)
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

        Private Sub TemporalEliminarPeriodo()
            For i As Integer = 0 To dgvPeriodoCondena.Rows.Count - 1
                dgvPeriodoCondena.Item("col_eliminado", i).Value = True
            Next
            txtAnios2.Text = 0
            txtMeses2.Text = 0
            txtDias2.Text = 0
            listarGrillaPeriodoCondena()
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
                .ResolucionID = ObjEntDestino.ResolucionID
                .ResolucionNom = ObjEntDestino.ResolucionNom
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
                .TipoResolucionId = ObjEntDestino.TipoResolucionId
                .TipoResolucionNom = ObjEntDestino.TipoResolucionNom
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

        Public Sub _ListarExpediente(objDocJudicial As Entity.Registro.DocumentoJudicial, Optional ByVal CargarMandDetencionHistorico As Boolean = True,
                                     Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False)

            Me._Load()

            If Me._DocumentoJudicialID < 1 Then 'si es nuevo y se muestra los checkeds
                dgwExpediente.Columns("col_exp_ref").Visible = False
                Exit Sub
            End If

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
                Select Case objEntExpediente.DocumentoTipoID
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema,
                        Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Resolucion
                        Me._Extramuro = objEntExpediente.Extramuro
                End Select

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
                        If objEntAgraviado.TipoResolucionId = 27 Then
                            btnAddPerCond.Enabled = False
                            btnEditPerCond.Enabled = False
                            btnDelPerCond.Enabled = False
                            txtAnios.ReadOnly = True
                            txtMeses.ReadOnly = True
                            txtDias.ReadOnly = True
                        End If
                    Next

                Next
            Next

            Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(0))

            '------------------------------ HNRB -------------------------------------->
            '/*periodo de condena*/
            objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
            objEntPerCon.DocJudicialId = objDocJudicial.Codigo ' DocumentoJudicialID
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                objEntPerCon.PenalId = -1
            End If

            objEntPeriodoCondenaNuevaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon) 'no es necesario LM

            For i As Integer = 0 To objEntPeriodoCondenaNuevaTempoCol.Count - 1 'indexar cada expediente
                objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
                dtpFechaInicio.ValueLong = objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).FechaInicio
                dtpFechaFinal.ValueLong = objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).FechaFin
            Next

            listarGrillaPeriodoCondenaNuevo()

            With objDocJudicial
                Me._TotalAnhos = .SentenciaTotalAnios
                Me._TotalMes = .SentenciaTotalMeses
                Me._TotalDias = .SentenciaTotalDias
                Me.cadenaPerpetua = .SentenciaCadenaPerpetua
            End With

            '' <-----------Periodo de condena anterior---------------------------------------------------------------
            If Not (objEntExpedienteColTmp.Expediente(0) Is Nothing) Then

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

                'If objEntExpPadre.DocJudPadre > objEntExpPadre.DocJudicialID Then
                'End If
                objEntPerCon.DocJudicialId = objEntExpPadre.DocJudPadre

                If objEntPerCon.DocJudicialId > 0 Then
                    objEntPeriodoCondenaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon) 'no es necesario LM
                    For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1 'indexar cada expediente
                        objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
                    Next
                End If

                listarGrillaPeriodoCondena()

                'Tiempo de condena anterior
                If objEntExpPadre.DocJudicialID > 0 Then
                    objBss = New Bussines.Registro.DocumentoJudicial
                    Dim objEnt2 As New Entity.Registro.DocumentoJudicial
                    objEnt2.Codigo = objEntExpPadre.DocJudPadre
                    objEnt2 = objBss.Listar(objEnt2) 'no necesario LM
                    With objEnt2
                        Me.txtAnios2.Text = .SentenciaTotalAnios
                        Me.txtMeses2.Text = .SentenciaTotalMeses
                        Me.txtDias2.Text = .SentenciaTotalDias
                    End With
                Else
                    Me.txtAnios2.Text = ""
                    Me.txtMeses2.Text = ""
                    Me.txtDias2.Text = ""
                End If

            End If

            _actualizarDatosInimputable(Me.grillaIdTipoInimputable > 0)
            If Me._TipoResolucion = 21 Or Me._TipoResolucion = 22 Then
                lblCondenaAnterior.Text = "Duración de la condena (Sentencia)"
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
        Public Function ValidarPeriodoCondena() As String
            Dim valor As String = ""
            Dim fecIniciostring As String = dtpFechaInicio.Value
            Dim fecFinalstring As String = dtpFechaFinal.Value

            If dtpFechaInicio.ValueLong > 0 And Not (IsDate(fecIniciostring)) Then
                valor = "El periodo de condena no tiene un formato de fecha correcta, modifique o elimine el registro"
            End If
            If dtpFechaFinal.ValueLong > 0 And Not (IsDate(fecFinalstring)) Then
                valor = "El periodo de condena no tiene un formato de fecha correcta, modifique o elimine el registro"
            End If
            Return valor
            'objBssPerCon = New Bussines.Registro.Documento.PeriodoCondenaSentencia
            'Return objBssPerCon.Validar(txtAnios.Text, txtMeses.Text, txtDias.Text, objEntPeriodoCondenaNuevaTempoCol)
        End Function
        Public Sub _actualizarDatosInimputable(esInimputable As Boolean)

            Me.esInimputable = esInimputable

            If esInimputable = False Then
                gbDuracioncondena.Text = "Duración de la condena"
                gbComputo.Text = "Cómputo"
                lblCondenaAnterior.Text = "Duración de la condena anterior"
                pnlInmpMant.Visible = False
                ActualizarDatosTipoInimputable(Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.NoPertenece, -1)
            Else
                gbDuracioncondena.Text = "Duración de la medida de seguridad"
                gbComputo.Text = "Cómputo de medida de seguridad"
                lblCondenaAnterior.Text = "Duración de la medida de seguridad anterior"
                pnlInmpMant.Visible = True
                Dim idCentroSalud As Short = -1
                If Me.grillaIdCentroSalud > 0 Then
                    idCentroSalud = Me.grillaIdCentroSalud
                End If

                ActualizarDatosTipoInimputable(Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable, idCentroSalud)
            End If

            Me._TituloPeriodocondena = gbComputo.Text
        End Sub
#End Region
#Region "Accion"

        Public Sub _Grabar(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDocJud As Entity.Registro.DocumentoJudicial)
            EliminarExpedienteBD()
            AGrabar(DocumentoJudicialID, Nuevo, EntDocJud)
        End Sub
        Private Sub AGrabar(DocumentoJudicialID As Integer, Nuevo As Boolean, EntDocJud As Entity.Registro.DocumentoJudicial)

            objBssPerCon = New Bussines.Registro.Documento.PeriodoCondenaSentencia

            Dim entPerCondAux As New Entity.Registro.Documento.PeriodoCondenaSentencia
            With entPerCondAux
                .DocJudicialId = DocumentoJudicialID
                .InternoId = Me._InternoId
                .IngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .FlagTransferenciaSede = Me.FlagTransferSede
                .Anio = IIf(Me.txtAnios.Text.Length = 0, 0, Me.txtAnios.Text)
                .Mes = IIf(Me.txtMeses.Text.Length = 0, 0, Me.txtMeses.Text)
                .Dia = IIf(Me.txtDias.Text.Length = 0, 0, Me.txtDias.Text)
                .FechaInicio = Me.dtpFechaInicio.ValueLong
                .FechaFin = Me.dtpFechaFinal.ValueLong
                .RegionId = Me._RegionID
                .PenalId = Me._PenalID
            End With
            For Each entPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaNuevaTempoCol
                With entPerCond
                    .DocJudicialId = DocumentoJudicialID
                    .InternoId = Me._InternoId
                    .IngresoId = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .Anio = IIf(Me.txtAnios.Text.Length = 0, 0, Me.txtAnios.Text)
                    .Mes = IIf(Me.txtMeses.Text.Length = 0, 0, Me.txtMeses.Text)
                    .Dia = IIf(Me.txtDias.Text.Length = 0, 0, Me.txtDias.Text)
                    .FechaInicio = Me.dtpFechaInicio.ValueLong
                    .FechaFin = Me.dtpFechaFinal.ValueLong
                End With
                Select Case Me._TipoLicencia
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                        If entPerCond.FlgEliminado = True Then
                            If entPerCond.Codigo > 0 Then objBssPerCon.Eliminar(entPerCond.Codigo, Me.FlagTransferSede)
                        Else
                            If Nuevo = True Then entPerCond.Codigo = -1
                            objBssPerCon.Grabar_LM(entPerCond)
                        End If
                    Case Else
                        If entPerCond.FlgEliminado = True Then
                            If entPerCond.Codigo > 0 Then objBssPerCon.Eliminar(entPerCond.Codigo, Me.FlagTransferSede)
                        Else
                            If Nuevo = True Then entPerCond.Codigo = -1
                            If (dtpFechaInicio.ValueLong > 0 Or dtpFechaFinal.ValueLong > 0) Then
                                objBssPerCon.Grabar(entPerCond)
                            End If
                        End If
                End Select
            Next
            If objEntPeriodoCondenaNuevaTempoCol.Count = 0 And (dtpFechaInicio.ValueLong > 0 Or dtpFechaFinal.ValueLong > 0) Then
                Select Case Me._TipoLicencia
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                        objBssPerCon.Grabar_LM(entPerCondAux)
                    Case Else
                        objBssPerCon.Grabar(entPerCondAux)
                End Select
            End If
            '---------Grabar expediente------------------------------------
            objBssExp = New Bussines.Registro.Expediente
            objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre

            For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol
                Dim ExpedienteOrigID As Integer = objExpediente.Codigo
                Dim DocumentoOrigID As Integer = objExpediente.CreaDocJudicialId
                Dim DocumentoTipoOrigID As Integer = objExpediente.DocumentoTipoID
                Dim intIdExpediente As Integer = -1
                With objExpediente
                    If Nuevo = True Then
                        If .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
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
                    Select Case _TipoResolucion
                        Case 17, 21, 22, 72
                            .SituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
                    End Select
                    .ExpedienteVisible = 1
                    .CreaDocJudicialId = DocumentoJudicialID
                    .ResolucionNom = objExpediente.ResolucionNom
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                    .Extramuro = EntDocJud.Extramuro
                    Select Case Me._TipoLicencia
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                            intIdExpediente = objBssExp.Grabar_LM(objExpediente)
                        Case Else
                            intIdExpediente = objBssExp.Grabar(objExpediente)
                    End Select
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
                               .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                                DocumentoTipoOrigID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                                DocumentoTipoOrigID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then

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
                                If objIntExpPad.InternoExpedienteRefPadreId > 0 Then
                                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                                        objBssExpedientePad.Grabar_LM(objIntExpPad)
                                    Else
                                        objBssExpedientePad.Grabar(objIntExpPad)
                                    End If
                                End If
                            End If
                        Else
                            If .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                               .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                               DocumentoTipoOrigID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                               DocumentoTipoOrigID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then

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
                        objBssPad.GrabarPadinDelito(objDel, objExpediente, Nuevo, intIdDel)

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
                If Me.grillaIdCentroSalud < 1 Then
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
                    'Exit For
                End If
                If dgwDelito.Item("col_tip_sent_id", i).Value < 1 Then
                    strNombreDelito = dgwDelito.Item("col_del_esp_nom", i).Value
                    SenDel = True
                    Exit For
                End If
            Next
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior And Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                    Select Case dgwExpediente.Item("col_exp_res_id", i).Value
                        Case 39, 40, 41, 42
                        Case Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar el tipo de resolucion.")
                            dgwExpediente.Focus()
                            Return False
                    End Select
                Next
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema And Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                    Select Case dgwExpediente.Item("col_exp_res_id", i).Value
                        Case 24, 41, 43
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
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar tipo de sentencia en el delito [" & strNombreDelito & "]")
                dgwExpediente.Focus()
                Return False
            End If
            Dim blnValorTxt As Boolean = False
            Dim blnValorDgv As Boolean = False
            If (txtAnios.Text = "0" Or txtAnios.Text = "") And (txtMeses.Text = "0" Or txtMeses.Text = "") And (txtDias.Text = "0" Or txtDias.Text = "") Then
                '  blnValorTxt = True
            End If
            If dgvPeriodoCondNueva.Rows.Count = 0 Then
                '  blnValorDgv = True
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
                            EntExpedienteAux.InternoID = Me._InternoId
                            EntExpedienteAux.IngresoID = Me._InternoIngresoId
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
        Public Sub EliminarPeriodo()
            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaNuevaTempoCol
                obj.FlgEliminado = 1
            Next
            dgvPeriodoCondNueva.DataSource = Nothing
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
        Private Function ValidarEliminar(Codigo As Integer) As Boolean
            For Each EntVal As Entity.Registro.Expediente In objEntExpedienteTempoCol
                If Codigo = EntVal.Codigo Then
                    Return False
                    Exit For
                End If
            Next
            Return True
        End Function
        Private Sub ActualizarDatosTipoInimputable(idTipoInimputable As Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente,
                                                idCentroSaludMental As Short)

            Select Case Me._TipoResolucion
                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Sentencia,
                     Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.SentenciaConsentida,
                     Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.EjecutoriaSuprema,
                     Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.EjecutoriaSuperior,
                     Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Resolucion

                    If dgwExpediente.RowCount > 0 Then
                        dgwExpediente.SelectedRows(0).Cells("col_id_tip_imim").Value = idTipoInimputable
                        dgwExpediente.SelectedRows(0).Cells("col_id_cen_sal_men").Value = idCentroSaludMental

                        objEntExpedienteTempoCol.Item(0).MotivoIngresoID = idTipoInimputable
                        objEntExpedienteTempoCol.Item(0).EstablecimientomentalId = idCentroSaludMental
                    End If

            End Select

        End Sub

        Private Sub eliminarRegistroAgraviado()

            If dgwDelito.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista no posee registros para elimimar")
                Exit Sub
            End If

            Dim eliminoAgraviado As Boolean = False

            bolEdicionActivo = False
            Temporal_EliminarExpediente_Delito_Agraviado(False, True, eliminoAgraviado)

            If eliminoAgraviado = True Then
                dgwExpediente_CellClick(Nothing, Nothing)
            End If

            bolEdicionActivo = True

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
            'If e.RowIndex = -1 Then Exit Sub
            'If dgwExpediente.Columns(e.ColumnIndex).Name = "col_exp_res_btn" Then
            '    RaiseEvent _click_VerResoluciones("EXP")
            'Else
            If dgwExpediente.Rows.Count > 0 Then
                Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
            End If
            'End If
        End Sub

        Private Sub btnDelPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnDelPerCond.Click
            If dgvPeriodoCondNueva.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para eliminar")
                btnAddPerCond.Focus()
                Exit Sub
            End If
            If dgvPeriodoCondNueva.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para eliminar")
                Exit Sub
            End If
            If Me._DocumentoJudicialID > 0 Then
                If ValidarExpedienteReferenciado(5) = False Then
                    Exit Sub
                End If
            End If
            If Legolas.Configuration.Aplication.MessageBox.Question("¿Esta Seguro de eliminar el periodo de condena seleccionado?") = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To objEntPeriodoCondenaNuevaTempoCol.Count - 1
                    If Me.GrillaPeriodoCondenaItem_ = objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                        objEntPeriodoCondenaNuevaTempoCol.Remove(i)
                        listarGrillaPeriodoCondenaNuevo()
                        Exit For
                    End If
                Next
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

            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione registro a modificar")
                Exit Sub
            End If

            RaiseEvent _Click_Expediente_Editar(Me.objEntExpedienteTempoCol.Expediente(Me.dgwExpediente.SelectedRows(0).Index))
        End Sub
        Private Sub btnEliminarExp_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarExp.Click
            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar un expediente.")
                Exit Sub
            End If
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

            eliminarRegistroAgraviado()

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
                    'If entAgrav.AgraviadoItem = dgwDelito.Item("col_agrav_item", e.RowIndex).Value Then entAgrav.TipoSentenciaId = dgwDelito.Item("col_tip_sent", e.RowIndex).Value
                Next
                RaiseEvent _click_ActivarContolExtramuro()
            End If

            If dgwDelito.Columns(e.ColumnIndex).Name = "col_tip_reso" Then
                For Each entAgrav As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If entAgrav.AgraviadoItem = dgwDelito.Item("col_agrav_item", e.RowIndex).Value Then
                        entAgrav.TipoResolucionId = dgwDelito.Item("col_tip_reso_id", e.RowIndex).Value
                        entAgrav.TipoResolucionNom = dgwDelito.Item("col_tip_reso", e.RowIndex).Value
                    End If
                Next
            End If
        End Sub

        Private Sub dgvPeriodoCondNueva_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPeriodoCondNueva.CellDoubleClick

            If dgvPeriodoCondNueva.Rows.Count > 0 Then
                If btnEditPerCond.Enabled = True Then
                    btnEditPerCond.PerformClick()
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe archivos para modificar")
            End If
        End Sub

        Private Sub dgwExpediente_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            If e.ColumnIndex = -1 Or e.RowIndex = -1 Or bolEdicionActivo = False Then Exit Sub

            If dgwExpediente.Columns(e.ColumnIndex).Name = "col_exp_res" Then
                For Each entExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If entExp.ExpedienteItem = dgwExpediente.Item("col_item", e.RowIndex).Value Then entExp.ResolucionNom = dgwExpediente.Item("col_exp_res", e.RowIndex).Value
                    If dgwDelito.Rows.Count > 0 Then
                        For i As Integer = 0 To dgwDelito.Rows.Count - 1
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
            dgwExpediente.Columns("col_exp_res_nom").ReadOnly = True
            dgwExpediente.Columns("col_flag").ReadOnly = True
            dgwExpediente.VisibleCampos = False
            dgvPeriodoCondNueva.VisibleCampos = False
            dgvPeriodoCondena.VisibleCampos = False
            Dim bssPar As New Bussines.General.Parametrica
            Dim Valorcombo As Integer = -1
            Select Case Me._TipoResolucion
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior,
                    Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema

                    Me.col_exp_res_nom.Visible = True
                    Me.col_exp_res_btn.Visible = True
                    'Me.col_tip_reso.ReadOnly = True
                    Me.btnInimputable2.Visible = False

                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionConsentida
                    Me.col_exp_res_nom.Visible = False
                    Me.col_exp_res_btn.Visible = False
                    lblResolucion.Visible = False
                    cbbResolucion.Visible = False
                    dgwDelito.Columns("col_tip_reso").Visible = False

                    Me.btnInimputable2.Visible = True

                Case Else
                    Me.col_exp_res_nom.Visible = False
                    Me.col_exp_res_btn.Visible = False

                    lblResolucion.Visible = False
                    cbbResolucion.Visible = False
                    dgwDelito.Columns("col_tip_reso").Visible = False
                    Valorcombo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipoCombo.Ejecutorias
                    Me.btnInimputable2.Visible = False
            End Select

            'Me.col_tip_sent.DataSource = bssPar.Listar(Type.Combo.ComboTipo.TipoAclaratoriaExpediente, Type.Enumeracion.SubTipoDocJudicial.enumSubTipoCombo.Sentencias, Type.Enumeracion.SubTipoDocJudicial.enumSubTipoCombo.Sentencias, -1, True, "[Seleccionar]")
            'Me.col_tip_sent.DisplayMember = "nombre"
            'Me.col_tip_sent.ValueMember = "codigo"
            'Me.col_tip_sent.Width = 150
            'Me.col_tip_sent.DropDownWidth = 250
            'Me.txtAnios2.Text = ""
            'Me.txtMeses2.Text = ""
            'Me.txtDias2.Text = ""
        End Sub
        Private Sub cbbResolucion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbResolucion.SelectedIndexChanged
            If dgwDelito.Rows.Count > 0 Then
                For i As Integer = 0 To dgwDelito.Rows.Count - 1
                    dgwDelito.Item("col_tip_reso", i).Value = cbbResolucion.SelectedValue
                Next
            End If
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
                eliminarRegistroAgraviado()
            End If
        End Sub


        Private Sub dgvPeriodoCondNueva_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvPeriodoCondNueva.KeyDown
            If e.KeyCode = Keys.Delete Then

                e.Handled = True



                If dgvPeriodoCondNueva.Rows.Count < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para eliminar")
                    Exit Sub
                End If
                If dgvPeriodoCondNueva.CurrentRow Is Nothing Then
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
                'Exit Sub 'para jhon, VERIFICAR SI ES dgvPeriodoCondena.Rows.Count o dgvPeriodoCondNueva.Rows.Count
                If Legolas.Configuration.Aplication.MessageBox.Question("¿Esta Seguro de eliminar el periodo de condena seleccionado?") = Windows.Forms.DialogResult.Yes Then
                    For i As Integer = 0 To objEntPeriodoCondenaNuevaTempoCol.Count - 1
                        If Me.GrillaPeriodoCondenaItem_ = objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                            objEntPeriodoCondenaNuevaTempoCol.Remove(i)
                            listarGrillaPeriodoCondenaNuevo()
                            Exit For
                        End If
                    Next
                End If
            End If
        End Sub
        Private Sub btnAddPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPerCond.Click

            If Me._DocumentoJudicialID > 0 And Me.grillaIdTipoInimputable < 1 Then 'agrego e.c.c..
                If ValidarExpedienteReferenciado(4) = False Then
                    Exit Sub
                End If
            End If
            RaiseEvent _Click_PeriodoCondena_Agregar()
        End Sub

        Private Sub btnEditPerCond_Click(sender As System.Object, e As System.EventArgs) Handles btnEditPerCond.Click
            If dgvPeriodoCondNueva.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para modificar")
                Exit Sub
            End If
            If dgvPeriodoCondNueva.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar periodo de condena para modificar")
                Exit Sub
            End If
            Dim intConta As Integer = 0
            If Me._DocumentoJudicialID > 0 Then
                For Each EntExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If EntExp.ExpedienteReferido = True Then
                        intConta = intConta + 1
                    End If
                Next
            End If
            For i As Integer = 0 To objEntPeriodoCondenaNuevaTempoCol.Count - 1
                If Me.GrillaPeriodoCondenaItem_ = objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem Then
                    If intConta > 0 Then
                        objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i).ValorRef = True
                    End If
                    RaiseEvent _Click_PeriodoCondena_Editar(objEntPeriodoCondenaNuevaTempoCol.PeriodoCondenaSentencia(i))
                    Exit For
                End If
            Next
        End Sub

        Private Sub dgwExpediente_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellContentClick
            If e.RowIndex = -1 Then Exit Sub
            If dgwExpediente.Columns(e.ColumnIndex).Name = "col_exp_res_btn" Then
                RaiseEvent _click_VerResoluciones("EXP")
            Else
                If dgwExpediente.Rows.Count > 0 Then
                    Temporal_ListarDelitos(Me.objEntExpedienteTempoCol.Item(dgwExpediente.SelectedRows(0).Index))
                End If
            End If
        End Sub

        Private Sub rbtTemporal_CheckedChanged(sender As Object, e As EventArgs) Handles rbTemporal.CheckedChanged
            If rbTemporal.Checked = True Then
                Me.txtAnios.Enabled = True
                Me.txtMeses.Enabled = True
                Me.txtDias.Enabled = True
                Me.txtAnios.Text = 0
                Me.txtMeses.Text = 0
                Me.txtDias.Text = 0
                Me.txtAnios.Focus()
            End If
            If rbCadenaperpetua.Checked = True Then
                Me.txtAnios.Text = ""
                Me.txtMeses.Text = ""
                Me.txtDias.Text = ""
                Me.txtAnios.Enabled = False
                Me.txtMeses.Enabled = False
                Me.txtDias.Enabled = False
            End If
        End Sub

        Private Sub btnInimputable_Click(sender As Object, e As EventArgs) Handles btnInimputable.Click


            If Me.dgwExpediente.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha encontrado ningún registro para agregar los datos")
                Exit Sub
            End If

            Dim idTipoInimputable As Short = Me.grillaIdTipoInimputable
            Dim idCentroSaludMental As Short = Me.grillaIdCentroSalud

            FrmAgregarInimputable(idTipoInimputable, idCentroSaludMental)

        End Sub

        Private Sub dgwDelito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDelito.CellContentClick
            If e.RowIndex = -1 Then Exit Sub
            If dgwDelito.Columns(e.ColumnIndex).Name = "col_agr_btn" Then
                RaiseEvent _click_VerResoluciones("DEL")
            End If
        End Sub

        Private Sub dgvPeriodoCondNueva_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeriodoCondNueva.CellContentClick

        End Sub

        Private Sub dgwDelito_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)

            ' If dgwDelito.Columns(e.ColumnIndex).Name = "col_tip_sent" Then
            RaiseEvent _click_ActivarContolExtramuro()
            ' End If
        End Sub

        Private Sub dgwExpediente_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub btnInimputable2_Click(sender As Object, e As EventArgs) Handles btnInimputable2.Click

        End Sub

    End Class
End Namespace