Option Explicit On
Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.SubTipoDocJudicial
Imports Type.Enumeracion.Licencia
Imports Ionic.Zip
Imports System.Xml
Imports Bussines.Registro

Namespace Registro.Documento
    Public Class uscExpeDeResolucion
        '/*bussiness*/
        Private objBssExpedientePad As Bussines.Registro.InternoExpedientePadre = Nothing
        Private objBssExpediente As Bussines.Registro.Expediente = Nothing
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
        '/*entitys*/
        Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing
        Private objEntExpediente As Entity.Registro.Expediente = Nothing
        Private objEntDelito As Entity.Registro.Delito = Nothing
        Private objEntAgraviado As Entity.Registro.Agraviado = Nothing
        Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objEntPeriodoCondenaTempoCol As Entity.Registro.Documento.PeriodoCondenaSentenciaCol = Nothing
        Private objBssExp As Bussines.Registro.Expediente
        Private objBssDoc As Bussines.Registro.DocumentoJudicial
        Private bssMov As Bussines.Registro.InternoMovimiento

        Private Property blnEliminarColection As Boolean = False
        Private Property blnEliminarDelitoColec As Boolean = False
        Private Property blnEliminarAgraviadoColec As Boolean = False
        Private Property intCodigoExpediente As Integer = -1
        Private Property intCodigoDelito As Integer = -1
        Private Property Nuevo As Boolean = False
        Private Property blnAccionEditar As Boolean = False
        Private Property blnAccionEliminar As Boolean = False
        Public Property chk_Queda As Boolean = False
        Public Property Estado_Documento_Judicial_exp As Integer = -1
#Region "Eventos"

        Public Event _Click_Expediente_Agregar()
        Public Event _Click_Expediente_Eliminar()
        Public Event _Click_Expediente_Editar(objEntExpediente As Entity.Registro.Expediente)

        Public Event _Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol)
        Public Event _Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol)

        Public Event _Click_Agraviado_Agregar(objEntDelito As Entity.Registro.Delito)
        Public Event _Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado)
        Public Event _CargarFormularioMovimientoLibertad(ExpCol As Entity.Registro.ExpedienteCol, TipoLibertad As Integer, nuevo As Boolean)

        Public Event _Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
        Public Event _Click_PeriodoCondena_Agregar()
        Public Event _Click_Inimputable(esInimputable As Boolean)

        Public Event _click_VerLibertades()
        Public Event _click_VerMotivoQueda()

#End Region
#Region "Variables"
        Public grabarMovimientoLibertad As Boolean = False
#End Region
#Region "Propiedades_Parametricas"
        Public Property _DocumentoJudicialID As Integer = -1
        Public Property _DocumentoJudicialExpedienteID As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _InternoIngresoID As Integer = -1
        '/*revisar*/
        Public Property _PermisoEliminar() As Boolean = False
        Public Property _TipoResolucion As Integer = -1
        Public Property _SubTipo As Integer = -1
        Public Property _Documentos_sin_mov As Boolean = False
        Public Property _VisibleControlExpediente As Boolean = False
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Public Property _FechaMovimiento As Long = 0
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                    v = 1
                End If
                Return v
            End Get
        End Property
        Private ObjTotalCol As New Entity.General.ParametricaCol
        Public Sub ActualizarLibertad(LibertadID As Integer, LibertadNom As String, Optional ByVal ObjCol As Entity.General.ParametricaCol = Nothing)
            dgwExpediente.SelectedRows(0).Cells("col_tip_lib_id").Value = LibertadID
            dgwExpediente.SelectedRows(0).Cells("col_tip_lib").Value = LibertadNom
            Select Case LibertadID
                Case 187, 157, 70
                    rbTratamientoAmbulatorio.Checked = False
                    rbInternacion.Checked = False
                    rbTratamientoAmbulatorio.Enabled = False
                    rbInternacion.Enabled = False
                    If _getEsInimputable = False Then
                        pnlDuracionCondena.Visible = False
                    End If
                Case 176, 26  'Ininputables
                    pnlDuracionCondena.Visible = True

                    rbInternacion.Checked = True
                    rbTratamientoAmbulatorio.Enabled = True
                    rbInternacion.Enabled = Enabled = True
                Case Else
                    rbInternacion.Checked = True
                    rbTratamientoAmbulatorio.Enabled = True
                    rbInternacion.Enabled = True
                    If _getEsInimputable = False Then
                        pnlDuracionCondena.Visible = False
                    End If
            End Select

            If ObjCol Is Nothing Then Exit Sub
            If ObjCol.Count = 0 Then Exit Sub

            Dim SubTipoId As String = ""
            Dim SubTipo As String = ""
            Dim conta As Integer = 0
            ObjTotalCol = ObjCol
            For Each obj As Entity.General.Parametrica In ObjCol
                If conta = 0 Then
                    SubTipoId = obj.Codigo
                    SubTipo = obj.Nombre
                Else
                    SubTipoId = SubTipoId & "|" & obj.Codigo
                    SubTipo = SubTipo & "|" & obj.Nombre
                End If
                conta += 1
            Next
            dgwExpediente.SelectedRows(0).Cells("col_subtip_lib_id").Value = SubTipoId
            dgwExpediente.SelectedRows(0).Cells("col_subtip_lib").Value = SubTipo

            objEntExpedienteTempoCol.Item(0).LibertadSubTipoStrID = SubTipoId
            objEntExpedienteTempoCol.Item(0).LibertadSubTipo = SubTipo
        End Sub
        Public Sub ActualizarResolucion(ResolucionID As Integer, ResolucionNom As String)
            dgwExpediente.SelectedRows(0).Cells("col_mot_que_id").Value = ResolucionID
            dgwExpediente.SelectedRows(0).Cells("col_mot_que").Value = ResolucionNom
        End Sub
        Private Sub ActualizarDatosTipoInimputable(idTipoInimputable As Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente,
                                                  nombreTipoIminputable As String,
                                                idCentroSaludMental As Short, nombreSaludMental As String)


            Select Case Me._TipoResolucion
                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital,
                     Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Libertad

                    dgwExpediente.SelectedRows(0).Cells("col_tip_exp_inim").Value = idTipoInimputable
                    dgwExpediente.SelectedRows(0).Cells("col_exp_inmp").Value = nombreTipoIminputable
                    dgwExpediente.SelectedRows(0).Cells("col_est_men_id").Value = idCentroSaludMental
                    dgwExpediente.SelectedRows(0).Cells("col_est_men_des").Value = nombreSaludMental

                    objEntExpedienteTempoCol.Item(0).MotivoIngresoID = idTipoInimputable
                    objEntExpedienteTempoCol.Item(0).EstablecimientomentalId = idCentroSaludMental

                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.RetornoTrasladoHospital

                    dgwExpediente.SelectedRows(0).Cells("col_conclu_id").Value = idTipoInimputable
                    dgwExpediente.SelectedRows(0).Cells("col_exp_conclu").Value = nombreTipoIminputable

                    dgwExpediente.SelectedRows(0).Cells("col_est_men_nue_des_id").Value = idCentroSaludMental
                    dgwExpediente.SelectedRows(0).Cells("col_est_men_nue_des").Value = nombreSaludMental

                    objEntExpedienteTempoCol.Item(0).NuevoMotivoInimputableId = idTipoInimputable
                    objEntExpedienteTempoCol.Item(0).NuevoMotivoInimputable = nombreTipoIminputable

                    objEntExpedienteTempoCol.Item(0).NuevoEstablecimientomentalId = idCentroSaludMental
                    objEntExpedienteTempoCol.Item(0).NuevoEstablecimientomental = nombreSaludMental

            End Select

        End Sub
#End Region
#Region "Propiedades_UserControl"
        Private bln_FormEscritura As Boolean = False
        Private bln_FormEliminar As Boolean = False
        Public Property _FormEscritura As Boolean
            Get
                Return bln_FormEscritura
            End Get
            Set(value As Boolean)

                bln_FormEscritura = value

                If bln_FormEscritura = True Then

                    Select Case Config.Licencia.LicenciaTipo
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                            bln_FormEscritura = False
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                            Select Case Config.Usuario.NivelUsuario
                                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                                    Select Case Config.Usuario.PerfilUsuario
                                        Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                             bln_FormEscritura = True
                                    End Select

                                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                                    bln_FormEscritura = True

                            End Select
                    End Select

                End If

                Me.pnlEscrituraExpe.Visible = bln_FormEscritura
                Me.pnlEscrituraDelito.Visible = bln_FormEscritura
                Me.pnlEscrituraAgrav.Visible = bln_FormEscritura
            End Set

        End Property
        Public Property _FormEliminar As Boolean
            Get
                Return bln_FormEliminar
            End Get
            Set(value As Boolean)

                bln_FormEliminar = value

                If bln_FormEliminar = True Then

                    Select Case Config.Licencia.LicenciaTipo
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                            bln_FormEliminar = False
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                            Select Case Config.Usuario.NivelUsuario
                                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                                    Select Case Config.Usuario.PerfilUsuario
                                        Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                             bln_FormEliminar = True
                                    End Select

                                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                                    bln_FormEliminar = True

                            End Select
                    End Select

                End If

                Me.pnlEliminarExpe.Visible = bln_FormEliminar
                Me.pnlEliminarDelito.Visible = bln_FormEliminar
                Me.pnlEliminarAgraviado.Visible = bln_FormEliminar
            End Set
        End Property

#End Region
#Region "Propiedades_Retorno"
        Public ReadOnly Property _getEsInimputable As Boolean
            Get
                Select Case Me.grillaIdTipoInimputable
                    Case Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable,
                         Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.PosibleInimputable,
                         176, -1
                        Return True
                    Case Else
                        Return False
                End Select
            End Get

        End Property
        Public ReadOnly Property _getCentroSaludMentalNombre As String
            Get
                Return Me.grillaCentroSaludMentalNombre
            End Get
        End Property
#End Region
#Region "Propiedades_Grilla"
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
        Public ReadOnly Property _GrillaAgraviadoID() As Integer
            Get

                Return Me.GrillaAgraviadoID

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
        Private ReadOnly Property GrillaDocJudicialID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property

        Public ReadOnly Property GrillaReferenciado() As Boolean
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_exp_ref_val").Value
                Catch ex As Exception
                    Return False
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
        Private ReadOnly Property GrillaDelitoDodJudID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwDelito
                        intValue = .SelectedRows(0).Cells("col_doc_jud_id").Value

                        If intValue = -1 Then intValue = 0
                    End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaAgraviadoID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwAgraviados
                        value = .SelectedRows(0).Cells("col_agr_id").Value
                    End With
                Catch ex As Exception
                    Return -1
                End Try
                Return value
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
                    Return dgwAgraviados.SelectedRows(0).Cells("col_agr_item").Value
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
        Public ReadOnly Property _Grilla_NroRegistroAgraviado As Integer
            Get
                Try
                    Return dgwAgraviados.Rows.Count
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaSalaJudicialID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_sal_jud_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaDelitoEspecificoID() As Integer
            Get
                Try
                    Return dgwDelito.SelectedRows(0).Cells("col_del_esp_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaLibertadTipoID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_tip_lib_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaLibertadSubTipoID() As String
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_subtip_lib_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _GrillaMotivoQuedaID() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_mot_que_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property grillaIdCentroSalud As Short
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_est_men_id").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property grillaIdTipoInimputable As Short
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_tip_exp_inim").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property grillaCentroSaludMentalNombre As String
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("col_est_men_des").Value
                Catch ex As Exception
                    Return ""
                End Try
            End Get
        End Property

#End Region
#Region "Propiedades_Grilla_Select"
        Private ReadOnly Property GrillaExpedienteIndex() As Integer
            Get
                Dim value As Integer = -1
                If dgwExpediente.Rows.Count > 0 Then
                    For i As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                        If Me._GrillaItemExpediente = objEntExpedienteTempoCol.Expediente(i).ExpedienteItem Then
                            value = i
                            Exit For
                        End If
                    Next
                End If
                Return value
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
        Private ReadOnly Property GrillaAgraviadoIndex() As Integer
            Get

                Dim value As Integer = -1
                For i As Integer = 0 To objEntAgraviadoTempoCol.Count - 1
                    If Me._GrillaItemAgraviado = objEntAgraviadoTempoCol.Item(i).AgraviadoItem Then
                        value = i
                        Exit For
                    End If
                Next
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteSelect() As Entity.Registro.Expediente
            Get
                objEntExpediente = New Entity.Registro.Expediente

                For Each objExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If Me._GrillaItemExpediente = objExp.ExpedienteItem Then
                        objEntExpediente = objExp '
                        Exit For
                    End If
                Next

                Return objEntExpediente

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
        Private ReadOnly Property GrilllaAgraviadoSelect() As Entity.Registro.Agraviado
            Get

                objEntAgraviado = New Entity.Registro.Agraviado

                For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    If Me._GrillaItemAgraviado = objAgraviado.AgraviadoItem Then
                        objEntAgraviado = objAgraviado
                        Exit For
                    End If
                Next

                Return objEntAgraviado

            End Get
        End Property
        Private ReadOnly Property Grilla_Agraviados_Delito_Select() As Entity.Registro.AgraviadoCol
            Get

                Dim value As New Entity.Registro.AgraviadoCol

                If dgwAgraviados.Rows.Count > 0 Then

                    For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If Me._GrillaItemDelito = objAgraviado.DelitoItem Then
                            value.Add(objAgraviado)
                        End If
                    Next
                End If
                Return value

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
#End Region
#Region "Propiedades_Duracion_Condena"
        Public intReferenciado As Integer = 0

#End Region
#Region "Propiedades_PeriodoCondena"
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
        Public Property _CadenaPerpetua() As Boolean
            Get
                Try
                    Return rbCadenaperpetua.Checked
                Catch ex As Exception
                    Return False
                End Try
            End Get
            Set(value As Boolean)
                Me.rbCadenaperpetua.Checked = value
            End Set
        End Property
#End Region
#Region "Temporal"
        Public objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol = Nothing
        Public objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing
        Public objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
        Private objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol = Nothing
        Public objEntAgraviadoTempoColGrilla As Entity.Registro.AgraviadoCol = Nothing
        Private objEntExpedienteCol As Entity.Registro.ExpedienteCol = Nothing
#Region "Listar"
        Private Sub Temporal_ListarExpediente()
            Try
                With Me.dgwExpediente
                    .DataSource = Nothing
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    If objEntExpedienteTempoCol Is Nothing Or objEntExpedienteTempoCol.Count = 0 Then
                        .DataSource = Nothing
                    Else
                        .DataSource = objEntExpedienteTempoCol
                    End If
                    .Refresh()
                    lblNroExpedientes.Text = "Expedientes " & .Rows.Count & " Reg."
                    For i As Integer = 0 To .Rows.Count - 1
                        .Item("col_num", i).Value = i + 1
                    Next
                End With
            Catch ex As Exception

            End Try

        End Sub
        Private Sub Temporal_ListarExpediente2()
            With Me.dgwExpediente
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntExpedienteTempoCol
                .Refresh()
                lblNroExpedientes.Text = "Expedientes " & .Rows.Count & " Reg."
                For i As Integer = 0 To .Rows.Count - 1
                    .Item("col_num", i).Value = i + 1
                Next
            End With

        End Sub
        Private Sub Temporal_ListarDelitos(objEntExpediente As Entity.Registro.Expediente)
            If objEntExpediente Is Nothing Then
                If dgwDelito.Rows.Count > 0 Then
                    dgwDelitos_CellClick(Nothing, Nothing)
                End If
            Else
                objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
                For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol

                    If obj.ExpedienteID = objEntExpediente.Codigo Then
                        If obj.ExpedienteID > 0 Then

                            objEntDelito = New Entity.Registro.Delito
                            Temporal_DelitoCopiarPropiedades(objEntDelito, obj)

                            If objEntExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                               objEntExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                                objEntExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Then

                                objEntDelito.ExpedienteItem = obj.ExpedienteItem
                            End If

                            objEntDelitoTempoColGrilla.Add(objEntDelito)

                        Else
                            If objEntExpediente.ExpedienteItem = obj.ExpedienteItem Then
                                objEntDelito = New Entity.Registro.Delito
                                Temporal_DelitoCopiarPropiedades(objEntDelito, obj)
                                objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                                objEntDelitoTempoColGrilla.Add(objEntDelito)
                            End If
                        End If
                    ElseIf Me._TipoResolucion = enumTipoDocumentoJudicial.Avocamiento Then
                        objEntDelito = New Entity.Registro.Delito
                        Temporal_DelitoCopiarPropiedades(objEntDelito, obj)

                        objEntDelito.ExpedienteItem = IIf(Me._SubTipo = enumSubTipo.IngresoTraslado, objEntExpediente.ExpedienteItem, Me._GrillaItemExpediente)

                        objEntDelitoTempoColGrilla.Add(objEntDelito)
                    End If
                Next

                With Me.dgwDelito
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = Nothing
                    .DataSource = objEntDelitoTempoColGrilla
                    lblNrodelitos.Text = "Delito(s) " & .Rows.Count & " Reg."
                End With
                dgwDelitos_CellClick(Nothing, Nothing)
            End If
        End Sub
        Private Sub Temporal_ListarDelitos2()
            objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol

            For Each obj As Entity.Registro.Delito In objEntDelitoTempoCol
                'If obj.ExpedienteID = objEntExpediente.Codigo Then
                If obj.Codigo > 0 Then

                    objEntDelito = New Entity.Registro.Delito
                    Temporal_DelitoCopiarPropiedades(objEntDelito, obj)
                    'objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                    objEntDelitoTempoColGrilla.Add(objEntDelito)

                Else
                    'If objEntExpediente. = obj.ExpedienteItem Then
                    objEntDelito = New Entity.Registro.Delito
                    Temporal_DelitoCopiarPropiedades(objEntDelito, obj)
                    'objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                    objEntDelitoTempoColGrilla.Add(objEntDelito)
                    'End If
                End If
                'End If
            Next

            With Me.dgwDelito
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = Nothing
                .DataSource = objEntDelitoTempoColGrilla
                lblNrodelitos.Text = "Delito(s) " & .Rows.Count & " Reg."
            End With
            dgwDelitos_CellClick(Nothing, Nothing)

        End Sub
        Private Sub Temporal_ListarAgraviados()

            If objEntDelito Is Nothing Then
                'nada
            Else

                objEntAgraviadoTempoColGrilla = New Entity.Registro.AgraviadoCol

                For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol

                    If obj.Codigo > 0 Then
                        Dim abc As Integer = objEntDelitoTempoCol.Count

                        If Me._GrillaDelitoID = obj.DelitoID Then
                            objEntAgraviado = New Entity.Registro.Agraviado
                            Temporal_AgraviadoCopiarPropiedades(objEntAgraviado, obj)
                            If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                              objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                              objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Then
                                objEntAgraviado.ExpedienteItem = objEntDelito.ExpedienteItem
                            Else
                                objEntAgraviado.ExpedienteItem = Me._GrillaItemExpediente
                            End If

                            objEntAgraviadoTempoColGrilla.Add(objEntAgraviado)
                        End If
                    Else
                        If obj.DelitoItem = Me._GrillaItemDelito Then
                            objEntAgraviado = New Entity.Registro.Agraviado
                            Temporal_AgraviadoCopiarPropiedades(objEntAgraviado, obj)
                            objEntAgraviadoTempoColGrilla.Add(objEntAgraviado)
                        End If
                    End If

                Next

                With Me.dgwAgraviados
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = Nothing
                    .DataSource = objEntAgraviadoTempoColGrilla
                    Me.lblNroAgraviados.Text = "Agraviado(s) " & .Rows.Count & " Reg."
                    .Refresh()
                End With
            End If
        End Sub
#End Region
#Region "Grabar"
#Region "Expediente"
        Public ExpAvocamientoAux As New Entity.Registro.Expediente
        Public ValorOK As Boolean = False
        Public Sub _Temporal_GrabarExpediente(objEnt As Entity.Registro.Expediente)
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                ExpAvocamientoAux = objEnt
            End If
            Dim blnNumeroExp As Boolean = False
            If objEnt.Nuevo Then
                For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                    If dgwExpediente.Item("col_num_exp", i).Value = objEnt.ExpedienteNumero Then
                        blnNumeroExp = True
                        Exit For
                    End If
                Next
            End If
            If blnNumeroExp = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Este numero de expediente ya existe en la lista.")
                Exit Sub
            End If

            Dim strMensaje As String = ""
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria Or
                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio Or
                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Or
                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion Then
                If dgwExpediente.Rows.Count = 0 Then
                    Temporal_GrabarExpediente(objEnt)
                Else
                    If objEnt.Nuevo = True Then
                        Select Case Me._TipoResolucion
                            Case Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                                strMensaje = "Aclaratoria"
                            Case Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                                strMensaje = "Ampliacion_Autoapertorio"
                            Case Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                                strMensaje = "Avocamiento"
                            Case Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion
                                strMensaje = "Prolongacion_Detencion"
                        End Select
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de " & strMensaje & ", ya posee un expediente.")
                        Exit Sub
                    Else
                        If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                            Temporal_GrabarExpediente(objEnt)
                        Else
                            Temporal_GrabarExpediente(objEnt)
                        End If
                    End If
                End If
            Else
                Temporal_GrabarExpediente(objEnt)
                blnAccionEditar = True
            End If
        End Sub
        Private Function Temporal_GrabarExpediente(objEnt As Entity.Registro.Expediente) As Integer
            If objEnt.LibertadTipoID = 0 Then objEnt.LibertadTipoID = -1

            mostrarDatosInimputables(objEnt.MotivoIngresoID)

            If objEnt.Codigo > 0 Then
                'si es un registro de base de datos
                If objEnt.ExpedienteItem > 0 Then
                    For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol
                        If obj.Codigo = objEnt.Codigo Then
                            Temporal_ExpedienteCopiarPropiedades(obj, objEnt)
                            Exit For
                        End If
                    Next
                Else
                    objEntExpediente = New Entity.Registro.Expediente
                    objEnt._RegionId = Me._RegionID
                    objEnt._PenalId = Me._PenalID
                    objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                    objEntExpedienteTempoCol.Add(objEnt)
                End If
            Else
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
                    objEntExpediente = New Entity.Registro.Expediente
                    objEnt._RegionId = Me._RegionID
                    objEnt._PenalId = Me._PenalID
                    objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                    objEntExpedienteTempoCol.Add(objEnt)
                End If
            End If

            Temporal_ListarExpediente()
            Return objEnt.ExpedienteItem
        End Function
        Private Sub Temporal_GrabarExpediente2(objEnt As Entity.Registro.Expediente)
            If objEnt.Codigo > 0 Then
                'si es un registro de base de datos
                If objEnt.ExpedienteItem > 0 Then
                    For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol
                        If obj.Codigo = objEnt.Codigo Then
                            Temporal_ExpedienteCopiarPropiedades(obj, objEnt)
                            Exit For
                        End If
                    Next
                Else
                    objEntExpediente = New Entity.Registro.Expediente
                    objEnt._RegionId = Me._RegionID
                    objEnt._PenalId = Me._PenalID
                    objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                    objEntExpedienteTempoCol.Add(objEnt)
                End If
            Else
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
                    objEntExpediente = New Entity.Registro.Expediente
                    objEnt._RegionId = Me._RegionID
                    objEnt._PenalId = Me._PenalID
                    objEnt.ExpedienteItem = TemporalExpedienteItemMaximo(objEntExpedienteTempoCol) + 1
                    objEntExpedienteTempoCol.Add(objEnt)
                End If
            End If
            Temporal_ListarExpediente2()
        End Sub
        Public _EstablecimientomentalId As Integer = -1
        Private Sub Temporal_ExpedienteCopiarPropiedades(objEntOrigen As Entity.Registro.Expediente, ObjEntDestino As Entity.Registro.Expediente)

            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
                'campos
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
                .Flagrancia = ObjEntDestino.Flagrancia
                .Observacion = ObjEntDestino.Observacion
                .LibertadTipoID = ObjEntDestino.LibertadTipoID
                .LibertadAuxiliarID = ObjEntDestino.LibertadAuxiliarID
                .LibertadTipoNom = ObjEntDestino.LibertadTipoNom
                .LibertadTipoID = ObjEntDestino.LibertadTipoID
                .LibertadSubTipoID = ObjEntDestino.LibertadSubTipoID
                .LibertadSubTipo = ObjEntDestino.LibertadSubTipo
                .MotivoIngresoID = ObjEntDestino.MotivoIngresoID
                .EstablecimientomentalId = ObjEntDestino.EstablecimientomentalId
                Me._EstablecimientomentalId = ObjEntDestino.EstablecimientomentalId
                .NuevoMotivoInimputableId = ObjEntDestino.NuevoMotivoInimputableId
                .NuevoEstablecimientomentalId = ObjEntDestino.NuevoEstablecimientomentalId
            End With

        End Sub
        Private Function TemporalExpedienteItemMaximo(objEntCol As Entity.Registro.ExpedienteCol) As Integer
            Dim value As Integer = 0
            Dim intNumero As Integer = 0

            For Each obj As Entity.Registro.Expediente In objEntCol
                If obj.ExpedienteItem > intNumero Then
                    intNumero = obj.ExpedienteItem
                    value = intNumero
                End If
            Next

            Return value
        End Function
#End Region
#Region "Delito"
        Public Sub _Temporal_GrabarDelito(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntAgraviadoCol As Entity.Registro.AgraviadoCol, objAgr_Ind As Entity.Registro.AgraviadoCol)
            EliminarAgraviado_desde_Delito(objAgr_Ind)
            Temporal_GrabarDelito(objEntExpediente, objEntDelito, objEntAgraviadoCol)
        End Sub
        Private objEntExpediente_copi As Entity.Registro.Expediente
        Private Sub Temporal_GrabarDelito(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito,
                                           objEntAgraviadoCol As Entity.Registro.AgraviadoCol)
            If objEntDelito.Codigo > 0 Then
                'si el delito viene de la bd 
                If objEntDelito.DelitoItem > 0 Then
                    'actualiza agraviados
                    For Each obj As Entity.Registro.Delito In objEntDelitoTempoColGrilla
                        If obj.Codigo = objEntDelito.Codigo Then
                            Temporal_DelitoCopiarPropiedades(obj, objEntDelito)
                            Exit For
                        End If
                    Next
                Else
                    objEntDelito.ExpedienteItem = objEntExpediente.ExpedienteItem ' objEntDelito.ExpedienteItem
                    objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol) + 1
                    objEntDelitoTempoCol.Add(objEntDelito)
                End If
                If objEntAgraviadoCol Is Nothing Then
                    'nada
                Else
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
                    If objEntAgraviadoCol Is Nothing = False Then
                        For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                            Temporal_GrabarAgraviado(objEntDelito, objAgraviado)
                        Next
                    End If
                End If
            End If
            If Me._TipoResolucion = enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Or
               (Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionReferenciado And Me._VisibleControlExpediente = False) Then
                Temporal_ListarDelitos2()
            Else
                If Me._TipoResolucion = enumTipoDocumentoJudicial.Avocamiento Then
                    Temporal_ListarDelitos(objEntExpediente)
                Else
                    'objEntExpediente_copi = New Entity.Registro.Expediente
                    'objEntExpediente_copi = objEntExpediente
                    dgwExpediente_CellClick(Nothing, Nothing)
                End If
            End If
        End Sub
        Private Function Temporal_GrabarDelito_Int(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito,
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

                    objEntDelito.ExpedienteItem = objEntDelito.ExpedienteItem
                    objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol) + 1
                    objEntDelitoTempoCol.Add(objEntDelito)
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

                Else
                    'si el temporal es nuevo
                    ' objEntDelito = New Entity.Registro.Delito
                    objEntDelito.ExpedienteItem = Me._GrillaItemExpediente
                    objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol) + 1
                    objEntDelitoTempoCol.Add(objEntDelito)

                End If
            End If

            dgwExpediente_CellClick(Nothing, Nothing)

            Return objEntDelito.DelitoItem

        End Function
        Dim objEntDelitoTempoCol_CopiaAvocat As New Entity.Registro.DelitoCol
        Private Sub Temporal_GrabarDelito2(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito,
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
                    'objEntDelito = New Entity.Registro.Delito
                    objEntDelito.ExpedienteItem = 1
                    objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol_CopiaAvocat) + 1
                    objEntDelitoTempoCol_CopiaAvocat.Add(objEntDelito)
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
                    ' objEntDelito = New Entity.Registro.Delito
                    objEntDelito.ExpedienteItem = 1
                    objEntDelito.DelitoItem = TemporalDelitoItemMaximo(objEntDelitoTempoCol_CopiaAvocat) + 1
                    objEntDelitoTempoCol_CopiaAvocat.Add(objEntDelito)
                    'actualiza agraviados
                    'If objEntAgraviadoCol Is Nothing = False Then
                    '    For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                    '        Temporal_GrabarAgraviado(objEntDelito, objAgraviado)
                    '    Next
                    'End If
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
                .CreaDocJudicialId = ObjEntDestino.CreaDocJudicialId
            End With
        End Sub
        Private Function TemporalDelitoItemMaximo(objEntCol As Entity.Registro.DelitoCol) As Integer

            Dim value As Integer = 0
            Dim intNumero As Integer = 0

            For Each obj As Entity.Registro.Delito In objEntCol
                'intNumero = obj.DelitoItem
                If obj.DelitoItem > intNumero Then
                    intNumero = obj.DelitoItem
                    value = intNumero
                End If
            Next

            Return value
        End Function
        Private Sub Temporal_Delito_Modificar()

            If dgwDelito.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un delito para modificar.")
                Exit Sub
            End If

            Me.GrillaDelitoSelect.DelitoItem = Me._GrillaItemDelito
            Me.GrillaDelitoSelect.ExpedienteItem = Me._GrillaItemExpediente
            For i As Integer = 0 To objEntDelitoTempoColGrilla.Count - 1
                objEntDelitoTempoColGrilla.internoDelito(i).Auxiliar = False
                If objEntDelitoTempoColGrilla.internoDelito(i).DelitoEspecifico = Me._GrillaDelitoEspecificoID Then
                    objEntDelitoTempoColGrilla.internoDelito(i).Auxiliar = True
                End If
            Next
            Dim usr As New APPControls.Busqueda.UscComboDelito
            'usr._DelitoGenericoID = Me.GrillaDelitoSelect.DelitoGenerico
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Then
                RaiseEvent _Click_Delito_Editar(Nothing, Me.GrillaDelitoSelect, Me.Grilla_Agraviados_Delito_Select, objEntDelitoTempoColGrilla)
            Else
                Dim abc As Integer = objEntDelitoTempoCol.Count
                RaiseEvent _Click_Delito_Editar(Me.objEntExpedienteTempoCol.Item(Me.GrillaExpedienteIndex), Me.GrillaDelitoSelect, Me.Grilla_Agraviados_Delito_Select, objEntDelitoTempoColGrilla)
            End If

        End Sub
#End Region
#Region "Agraviado"
        Public Sub _Temporal_GrabarAgraviado(objEnt As Entity.Registro.Agraviado)

            Temporal_GrabarAgraviado(objEntDelitoTempoCol.Delito(Me.GrillaDelitoIndex), objEnt)

        End Sub
        Private objEntDelito_copy As Entity.Registro.Delito
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
                    objEnt.ExpedienteItem = objEntDelito.ExpedienteItem ' Me._GrillaItemExpediente '  objEntDelito.ExpedienteItem
                    objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol) + 1
                    objEntAgraviadoTempoCol.Add(objEnt)
                End If
            Else
                'si el temporal ya existe ''''''''''''''''''''''EL ULTIMO ELIMINA REVISAR
                If objEnt.AgraviadoItem > 0 Then
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If obj.AgraviadoItem = objEnt.AgraviadoItem Then
                            Temporal_AgraviadoCopiarPropiedades(obj, objEnt)
                            Exit For
                        End If
                    Next
                Else
                    'si el temporal es nuevo
                    'objEntAgraviado = New Entity.Registro.Agraviado
                    Dim strNombre As String = ""
                    Dim blnValor As Boolean = False
                    For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If EntAgr.DelitoItem = objEnt.DelitoItem Then
                            If EntAgr.AgraviadoNombre = objEnt.AgraviadoNombre Then
                                strNombre = objEnt.AgraviadoNombre
                                blnValor = True
                            End If
                        End If
                    Next
                    If blnValor = True Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El agraviado : " & strNombre & ", ya se encuentra la lista ")
                        Exit Sub
                    Else
                        objEnt.DelitoItem = objEntDelito.DelitoItem
                        objEnt.ExpedienteItem = Me._GrillaItemExpediente
                        objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol) + 1
                        objEntAgraviadoTempoCol.Add(objEnt)
                    End If
                End If

            End If

            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                dgwDelitos_CellClick(Nothing, Nothing)
            Else
                objEntDelito_copy = New Entity.Registro.Delito
                objEntDelito_copy = objEntDelito
                dgwDelitos_CellClick(Nothing, Nothing)
            End If
        End Sub
        Private Sub Temporal_GrabarAgraviado_Int(objEntDelito As Entity.Registro.Delito, objEnt As Entity.Registro.Agraviado)

            If objEnt.Codigo > 0 Then
                'si el registro esta en la base de datos
                If objEnt.AgraviadoItem > 0 Then
                    'For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                    '    If obj.Codigo = objEnt.Codigo Then
                    '        Temporal_AgraviadoCopiarPropiedades(obj, objEnt)
                    '        Exit For
                    '    End If
                    'Next
                Else
                    objEnt.DelitoItem = objEnt.DelitoItem
                    objEnt.ExpedienteItem = objEnt.ExpedienteItem ' Me._GrillaItemExpediente '  objEntDelito.ExpedienteItem
                    objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol) + 1
                    objEntAgraviadoTempoCol.Add(objEnt)
                End If
            Else
                'si el temporal ya existe ''''''''''''''''''''''EL ULTIMO ELIMINA REVISAR
                If objEnt.AgraviadoItem > 0 Then
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If obj.AgraviadoItem = objEnt.AgraviadoItem Then
                            Temporal_AgraviadoCopiarPropiedades(obj, objEnt)
                            Exit For
                        End If
                    Next
                Else
                    'si el temporal es nuevo
                    'objEntAgraviado = New Entity.Registro.Agraviado

                    objEnt.DelitoItem = objEntDelito.DelitoItem
                    objEnt.ExpedienteItem = Me._GrillaItemExpediente
                    objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol) + 1
                    objEntAgraviadoTempoCol.Add(objEnt)

                End If

            End If


        End Sub
        Private objEntAgraviadoTempoCol_Avocat As New Entity.Registro.AgraviadoCol
        Private Sub Temporal_GrabarAgraviado2(objEntDelito As Entity.Registro.Delito, objEnt As Entity.Registro.Agraviado)
            If objEnt.Codigo > 0 Then
                'si el registro esta en la base de datos
                If objEnt.AgraviadoItem > 0 Then
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If obj.Codigo = objEnt.Codigo Then
                            Temporal_AgraviadoCopiarPropiedades2(obj, objEnt)
                            Exit For
                        End If
                    Next
                Else
                    'objEntAgraviado = New Entity.Registro.Agraviado
                    objEnt.DelitoItem = objEntDelito.DelitoItem
                    objEnt.ExpedienteItem = objEntDelito.ExpedienteItem
                    objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol_Avocat) + 1
                    objEntAgraviadoTempoCol_Avocat.Add(objEnt)
                End If
            Else
                'si el temporal ya existe ''''''''''''''''''''''EL ULTIMO ELIMINA REVISAR
                If objEnt.AgraviadoItem > 0 Then
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If obj.AgraviadoItem = objEnt.AgraviadoItem Then
                            Temporal_AgraviadoCopiarPropiedades2(obj, objEnt)
                            Exit For
                        End If
                    Next
                Else
                    'si el temporal es nuevo
                    'objEntAgraviado = New Entity.Registro.Agraviado
                    objEnt.DelitoItem = objEntDelito.DelitoItem
                    objEnt.ExpedienteItem = 1
                    objEnt.AgraviadoItem = TemporalAgraviadoItemMaximo(objEntAgraviadoTempoCol_Avocat) + 1
                    objEntAgraviadoTempoCol_Avocat.Add(objEnt)
                End If
            End If
        End Sub
        Private Sub Temporal_AgraviadoCopiarPropiedades2(objEntOrigen As Entity.Registro.Agraviado, ObjEntDestino As Entity.Registro.Agraviado)
            With objEntOrigen
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoID = ObjEntDestino.IngresoID
                .ExpedienteID = ObjEntDestino.ExpedienteID
                .DelitoID = ObjEntDestino.DelitoID
                .AgraviadoItem = ObjEntDestino.AgraviadoItem
                .DelitoItem = ObjEntDestino.DelitoItem
                .ExpedienteItem = ObjEntDestino.ExpedienteItem
                '/*campos*/
                .AgraviadoNombre = ObjEntDestino.AgraviadoNombre
                .Observacion = ObjEntDestino.Observacion
                .Estado = ObjEntDestino.Estado
            End With
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
                '/*campos*/
                .AgraviadoNombre = ObjEntDestino.AgraviadoNombre
                .Observacion = ObjEntDestino.Observacion
                .Estado = ObjEntDestino.Estado
                .CreaDocJudicialId = ObjEntDestino.CreaDocJudicialId
            End With
        End Sub
        Private Function TemporalAgraviadoItemMaximo(objEntCol As Entity.Registro.AgraviadoCol) As Integer

            Dim value As Integer = 0
            Dim intNumero As Integer = 0

            For Each obj As Entity.Registro.Agraviado In objEntCol

                If obj.AgraviadoItem > intNumero Then
                    intNumero = obj.AgraviadoItem
                    value = intNumero
                End If

            Next
            Return value
        End Function
        Private Sub Temporal_Modificar_Agraviado()

            If dgwAgraviados.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un agraviado para modificar.")
                Exit Sub
            End If
            blnVaorAgr = False
            RaiseEvent _Click_Agraviado_Editar(Me.GrillaDelitoSelect, Me.GrilllaAgraviadoSelect)

        End Sub
#End Region
#Region "Otros"
        Public Sub _Temporal_Grabar_Expediente_Delito_Agraviado(objEnt As Entity.Registro.ExpedienteCol, objEntDel As Entity.Registro.DelitoCol, objEntAgr As Entity.Registro.AgraviadoCol)
            Dim strMensaje As String = ""
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria Or
               Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio Or
               Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Or
               Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion Then
                Select Case Me._TipoResolucion
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                        strMensaje = "Aclaratoria"
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                        strMensaje = "Ampliacion_Autoapertorio"
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                        ExpAvocamientoAux = objEnt.Expediente(0)
                        strMensaje = "Avocamiento"
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion
                        strMensaje = "Prolongacion_Detencion"
                End Select
                If dgwExpediente.Rows.Count = 0 Then
                    If objEnt.Count = 1 Then
                        Temporal_Grabar_Expediente_Delito_Agraviado(objEnt, objEntDel, objEntAgr)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de " & strMensaje & ", solo puede cargar un expediente.")
                        objEnt = Nothing
                        objEntDel = Nothing
                        objEntAgr = Nothing
                        Exit Sub
                    End If
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de " & strMensaje & ", ya posee un expediente.")
                    objEnt = Nothing
                    objEntDel = Nothing
                    objEntAgr = Nothing
                    Exit Sub
                End If
            Else
                Temporal_Grabar_Expediente_Delito_Agraviado(objEnt, objEntDel, objEntAgr)
                blnAccionEditar = True
            End If

            If Me._DocumentoJudicialID > 0 Then
                objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                objEntPerCon.DocJudicialId = Me._DocumentoJudicialID
                objEntPeriodoCondenaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)

                For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1 'indexar cada expediente
                    objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
                Next

            End If

        End Sub
        Private entExpColAcum As Entity.Registro.ExpedienteCol
        Private Sub Temporal_Grabar_Expediente_Delito_Agraviado(objEntExpedienteCol As Entity.Registro.ExpedienteCol, objEntDelitoCol As Entity.Registro.DelitoCol,
                                                                objEntAgraviadoCol As Entity.Registro.AgraviadoCol)

            entExpColAcum = New Entity.Registro.ExpedienteCol
            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol
                Dim ItemExpediente As Integer = 0
                objEntExpediente._RegionId = Me._RegionID
                objEntExpediente._PenalId = Me._PenalID
                Dim entDelitoCol_cop As New Entity.Registro.DelitoCol
                'grabar expedientes
                If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                    objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                                     objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Then
                    objEntExpediente.Codigo = objEntExpediente.CreaDocJudicialId
                End If
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                    If Nuevo = True Then
                        objEntExpediente.LibertadAuxiliarID = objEntExpediente.LibertadTipoID
                        objEntExpediente.LibertadTipoID = -1
                    End If
                End If
                ItemExpediente = Temporal_GrabarExpediente(objEntExpediente)
                If objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                   objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                                      objEntExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Then
                    Dim objEntExpedienteCol2 As New Entity.Registro.ExpedienteCol
                    objBssExp = New Bussines.Registro.Expediente
                    objEntExpedienteCol2 = objBssExp.ListarExpedientexResolucion(objEntExpediente.CreaDocJudicialId)
                    For Each objEnt2 As Entity.Registro.Expediente In objEntExpedienteCol2
                        entExpColAcum.Add(objEnt2)
                        For Each objDelito As Entity.Registro.Delito In objEntDelitoCol
                            Dim ItemDelito As Integer = -1
                            If objEnt2.Codigo = objDelito.ExpedienteID And objDelito.CreaDocJudicialId = objEntExpediente.Codigo Then
                                objDelito.ExpedienteItem = ItemExpediente
                                objDelito.ExpedienteID = objEntExpediente.CreaDocJudicialId
                                objDelito.CreaDocJudicialId = objEntExpediente.CreaDocJudicialId

                                ItemDelito = Temporal_GrabarDelito_Int(objEnt2, objDelito, Nothing)
                                For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol

                                    If objDelito.Codigo = objAgraviado.DelitoID And objAgraviado.AgraviadoItem < 1 Then
                                        objAgraviado.ExpedienteID = objEntExpediente.CreaDocJudicialId
                                        objAgraviado.ExpedienteItem = ItemExpediente  ' objDelito.ExpedienteItem  'Me._GrillaItemExpediente  'objEntExpediente.ExpedienteItem
                                        objAgraviado.DelitoItem = ItemDelito
                                        'grabar agraviados
                                        objAgraviado.CreaDocJudicialId = objEntExpediente.CreaDocJudicialId
                                        Temporal_GrabarAgraviado_Int(objDelito, objAgraviado)
                                    End If
                                Next
                            End If
                        Next
                    Next
                Else
                    For Each objDelito As Entity.Registro.Delito In objEntDelitoCol
                        If objEntExpediente.Codigo = objDelito.ExpedienteID Then

                            objDelito.ExpedienteItem = objEntExpediente.ExpedienteItem
                            'grabar delitos
                            Temporal_GrabarDelito(objEntExpediente, objDelito, Nothing)
                            For Each objAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                                If objDelito.Codigo = objAgraviado.DelitoID Then

                                    objAgraviado.ExpedienteItem = objEntExpediente.ExpedienteItem
                                    objAgraviado.DelitoItem = objDelito.DelitoItem
                                    'grabar agraviados de forma Temporal
                                    Temporal_GrabarAgraviado(objDelito, objAgraviado)

                                End If
                            Next
                        End If
                    Next
                End If
            Next

            Temporal_ListarExpediente()
            Temporal_ListarDelitos(Nothing)
            Temporal_ListarAgraviados()

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
                        strMensaje = "No se puede modificar el documento porque forma parte del expediente"
                    Case 7
                        strMensaje = " [Operación cancelada]"
                    Case 8
                        strMensaje = "no se puede eliminar expedientes"
                    Case 9
                        strMensaje = "no se puede eliminar delitos"
                    Case 10
                        strMensaje = "no se puede eliminar agraviados"
                End Select
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                    For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol
                        objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                        If objEntExpediente.Codigo > 0 Then
                            objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo ' Me.ExpedienteCodAux
                            Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
                            If blnValor = False Then
                                intValorpadre = intValorpadre + 1
                            End If
                        End If
                    Next
                Else
                    For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol
                        objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                        If objEntExpediente.Codigo > 0 And objEntExpediente.CreaDocJudicialId = Me._DocumentoJudicialID Then
                            objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                            Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
                            If blnValor = False Then
                                intValorpadre = intValorpadre + 1
                            End If
                        End If
                    Next
                End If

                If intValorpadre > 0 Then
                    If Me._TipoResolucion = enumTipoDocumentoJudicial.Ingreso Then
                        If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                            objBssDoc = New Bussines.Registro.DocumentoJudicial
                            Dim ent As New Entity.Registro.DocumentoJudicial
                            Dim entCol As New Entity.Registro.DocumentoJudicialCol
                            ent.IngresoInpeId = Me._InternoIngresoInpeId
                            ent.InternoId = Me._InternoID
                            entCol = objBssDoc.ListarDocJud_v2_LM(ent)
                            Dim conDoc As Integer = 0
                            For Each obj As Entity.Registro.DocumentoJudicial In entCol
                                If obj.DocumentoTipo = 14 Or obj.DocumentoTipo = 35 Then
                                    conDoc += 1
                                End If
                            Next
                            If entCol.Count <= 2 Then
                                Return True
                            End If
                        End If
                    End If
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado," & strMensaje)
                    Return False
                End If
            End If
            Return True
        End Function
#End Region
#End Region
#Region "Eliminar"
        Private Sub Temporal_EliminarExpediente_Delito_Agraviado(SelectExpediente As Boolean, SelectDelito As Boolean, SelectAgraviado As Boolean)

            blnAccionEliminar = False
            intCodigoExpediente = Me.GrillaExpedienteID
            If intCodigoExpediente > 0 Then

                If Me._DocumentoJudicialID > 0 Then
                    Dim intValor As Integer = -1

                    If SelectExpediente = True Then
                        intValor = 8
                    ElseIf SelectDelito = True Then
                        intValor = 9
                    Else
                        intValor = 10
                    End If

                    If ValidarExpedienteReferenciado(intValor) = False Then
                        Exit Sub
                    End If

                End If

            End If

            Dim strMensaje As String = ""
            If SelectExpediente = True Then
                strMensaje = "Esta seguro de eliminar el expediente, delitos y agraviado, una vez eliminado no se podra recuperar la información"

                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then

                    If intCodigoExpediente > 0 Then

                        If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                            blnEliminarColection = True

                            TemporalEliminarPeriodo()
                            Temporal_EliminarExpedienteAgraviado()  'eliminar el agraviado
                            Temporal_EliminarExpedienteDelito() 'eliminar el delito
                            Temporal_EliminarExpediente() 'eliminar el expediente
                        Else

                            TemporalEliminarPeriodo()
                            Temporal_EliminarExpedienteAgraviado2() 'eliminar el agraviado
                            Temporal_EliminarExpedienteDelito2() 'eliminar el delito
                            Temporal_EliminarExpediente2()  'eliminar el expediente

                        End If
                    Else 'ELIMINAR SOLO LOS TEMPORALES
                        TemporalEliminarPeriodo()
                        Temporal_EliminarExpedienteAgraviado2() 'eliminar el agraviado
                        Temporal_EliminarExpedienteDelito2() 'eliminar el delito
                        Temporal_EliminarExpediente2() 'eliminar el expediente
                    End If
                    blnAccionEliminar = True

                    '***********ELIMINAR TEMPORALES DE QUEDA*************************************************
                    RaiseEvent _Click_Expediente_Eliminar()
                End If
            End If

            If SelectDelito = True Then
                strMensaje = "Esta seguro de eliminar el delito, se eliminara sus agraviado "
                intCodigoDelito = Me.GrillaDelitoID

                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then

                    If intCodigoExpediente > 0 Then

                        If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then
                            objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                            objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                            objEntExpPadre.InternoExpedienteId = intCodigoExpediente
                            Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)

                            If blnValor = False Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente seleccionado no se puede eliminar, ya ha sido referenciado")
                                Exit Sub
                            End If

                            blnEliminarDelitoColec = True
                            'eliminar el agraviado
                            Temporal_EliminarDelitoAgraviado()
                            Temporal_EliminarDelito()
                        Else
                            Temporal_EliminarDelitoAgraviado()
                            Temporal_EliminarDelito()
                        End If

                    Else 'ELIMINAR SOLO LOS TEMPORALES
                        Temporal_EliminarDelitoAgraviado()
                        Temporal_EliminarDelito()
                    End If

                End If
            End If

            If SelectAgraviado = True Then

                If dgwAgraviados.Rows.Count = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un agraviado para eliminar.")
                Else
                    strMensaje = "Esta seguro de eliminar el agraviado "

                    If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then
                        Temporal_EliminarAgraviado()

                        If intCodigoExpediente > 0 Then

                            If Me._DocumentoJudicialID = Me.dgwExpediente.SelectedRows(0).Cells("col_doc_jdu_id").Value Then

                                blnEliminarAgraviadoColec = True
                                'eliminar el agraviado
                                Temporal_EliminarAgraviado()
                            Else
                                Temporal_EliminarAgraviado()
                            End If

                        Else 'ELIMINAR SOLO LOS TEMPORALES
                            Temporal_EliminarAgraviado()
                        End If

                    End If
                End If
            End If
        End Sub
        Private Sub Temporal_EliminarAgraviado()
            If Me.dgwAgraviados.RowCount > 0 Then
                Dim intCodigo As Integer = Me.GrillaAgraviadoID
                Dim AgrInd As New Entity.Registro.Agraviado
                AgrInd.Codigo = intCodigo
                AgraviadosIndcCol3.Add(AgrInd)
                objEntAgraviadoTempoCol.Remove(Me.GrillaAgraviadoIndex)
            End If
        End Sub
        Private Sub Temporal_EliminarDelitoAgraviado()
            Dim intIndice As Integer = -1
            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemDelito = objEntAgraviadoTempoCol.Item(i).DelitoItem Then
                    intIndice = i
                    Dim intCodigo As Integer = objEntAgraviadoTempoCol.Item(i).Codigo
                    Dim AgrEnt As New Entity.Registro.Agraviado
                    If Me._DocumentoJudicialID > 0 Then
                        If Me._DocumentoJudicialID = objEntAgraviadoTempoCol.Item(i).CreaDocJudicialId Then
                            AgrEnt.Codigo = intCodigo
                            'AgraviadosIndcCol2.Add(AgraviadosIndc)
                            AgraviadosIndcCol2.Add(AgrEnt)
                        End If
                    End If
                    objEntAgraviadoTempoCol.Remove(intIndice)
                End If
            Next
            If _TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Then
                Temporal_ListarAgraviados()
            End If
        End Sub
        Dim DelitoIndColec As New Entity.Registro.DelitoCol
        Private Sub Temporal_EliminarDelito()
            If Me.dgwDelito.RowCount > 0 Then
                Dim intCodigo As Integer = Me.GrillaDelitoID
                Dim Del_Ind As New Entity.Registro.Delito
                If Me._DocumentoJudicialID > 0 Then
                    If Me._DocumentoJudicialID = Me.GrillaDelitoDodJudID Then
                        Del_Ind.Codigo = intCodigo
                        DelitoIndcCol2.Add(Del_Ind)
                    End If
                End If
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Then
                    objEntDelitoTempoCol.Remove(Me.GrillaDelitoIndex)
                    Temporal_ListarDelitos2()
                Else
                    objEntDelitoTempoCol.Remove(Me.GrillaDelitoIndex)
                End If
            End If

        End Sub
        Private Sub Temporal_EliminarExpedienteAgraviado2()

            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemExpediente = objEntAgraviadoTempoCol.Item(i).ExpedienteItem Then
                    objEntAgraviadoTempoCol.Remove(i)
                End If
            Next

            dgwDelitos_CellClick(Nothing, Nothing)
        End Sub
        Private AgraviadosIndcCol As New Entity.Registro.AgraviadoCol
        Private AgraviadosIndcCol2 As New Entity.Registro.AgraviadoCol
        Private AgraviadosIndcCol3 As New Entity.Registro.AgraviadoCol
        Private AgraviadosIndc As New Entity.Registro.Agraviado
        Private DelitoIndcCol As New Entity.Registro.DelitoCol
        Private DelitoIndcCol2 As New Entity.Registro.DelitoCol
        Private DelitoIndc As New Entity.Registro.Delito
        Private ExpedienteIndc As New Entity.Registro.ExpedienteCol
        Private Sub Temporal_EliminarExpedienteAgraviado()

            For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemExpediente = objEntAgraviadoTempoCol.Item(i).ExpedienteItem Then
                    If Me._GrillaExpedienteID > 0 And Me._DocumentoJudicialID = Me.GrillaDocJudicialID Then
                        AgraviadosIndc = New Entity.Registro.Agraviado
                        AgraviadosIndc.Codigo = objEntAgraviadoTempoCol.Item(i).Codigo
                        AgraviadosIndcCol.Add(AgraviadosIndc)
                    End If
                    objEntAgraviadoTempoCol.Remove(i)
                End If
            Next

            dgwDelitos_CellClick(Nothing, Nothing)
        End Sub
        Private Sub Temporal_EliminarExpedienteDelito()
            If Me._GrillaExpedienteID > 0 Then
                For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1
                    If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then
                        If Me._DocumentoJudicialID = Me.GrillaDocJudicialID Then
                            DelitoIndc = New Entity.Registro.Delito
                            DelitoIndc.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                            DelitoIndcCol.Add(DelitoIndc)
                        End If
                        objEntDelitoTempoCol.Delete(i)
                    End If
                Next
            Else
                For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1
                    If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then
                        DelitoIndc.Codigo = objEntDelitoTempoCol.Item(i).Codigo
                        DelitoIndcCol.Add(DelitoIndc)
                        objEntDelitoTempoCol.Delete(i)
                    End If
                Next
            End If
            dgwExpediente_CellClick(Nothing, Nothing)
            dgwDelito.Refresh()
        End Sub
        Private Sub Temporal_EliminarExpedienteDelito2()
            For i As Integer = objEntDelitoTempoCol.Count - 1 To 0 Step -1
                If Me._GrillaItemExpediente = objEntDelitoTempoCol.Item(i).ExpedienteItem Then

                    Dim intCodigo As Integer = objEntDelitoTempoCol.Item(i).Codigo
                    'AEliminarDelitoBD(intCodigo)
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
                    Dim Exp_ent As New Entity.Registro.Expediente
                    Exp_ent.Codigo = intCodigo
                    ExpedienteIndc.Add(Exp_ent)
                    objEntExpedienteTempoCol.Remove(Me.GrillaExpedienteIndex)
                Else
                    objEntExpedienteTempoCol.Remove(Me.GrillaExpedienteIndex)
                End If
                Temporal_ListarExpediente()
                Temporal_ListarDelitos(Nothing)
                dgwExpediente_CellClick(Nothing, Nothing)
            End If
        End Sub
        Private Sub Temporal_EliminarExpediente2()
            If Me.dgwExpediente.RowCount > 0 Then
                Dim intCodigo As Integer = Me.GrillaExpedienteID

                objEntExpedienteTempoCol.Remove(Me.GrillaExpedienteIndex)
                Temporal_ListarExpediente()
                Temporal_ListarDelitos(Nothing)
                dgwExpediente_CellClick(Nothing, Nothing)
                mostrarDatosInimputables(-1)
            End If
        End Sub
        Public Sub EliminarAgraviado_desde_Delito(EntAgrCol_Ind As Entity.Registro.AgraviadoCol)
            If Me.dgwAgraviados.RowCount > 0 Then
                For i As Integer = objEntAgraviadoTempoCol.Count - 1 To 0 Step -1
                    For Each EntAgr_Ind As Entity.Registro.Agraviado In EntAgrCol_Ind ' AgraviadosIndcCol3
                        If objEntAgraviadoTempoCol.Item(i).Codigo = EntAgr_Ind.Codigo Then
                            AgraviadosIndcCol3.Add(EntAgr_Ind)
                            objEntAgraviadoTempoCol.Remove(i)
                            blnEliminarAgraviadoColec = True
                        End If
                    Next
                Next
            End If
            ' 'dgwDelitos_CellClick(Nothing, Nothing)
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
            EntExp.InternoID = Me._InternoID
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
                blnSwitch = False
            End If
            Return blnSwitch
        End Function
        Private Sub TemporalEliminarPeriodo()
            eliminarTiempoCondena()

            For i As Integer = 0 To dgvPeriodoCondena.Rows.Count - 1
                dgvPeriodoCondena.Item("col_eliminado", i).Value = True
            Next

            listarGrillaPeriodoCondena()
        End Sub
#End Region

#End Region
#Region "Listar"
        Dim objEntDelitoCol As Entity.Registro.DelitoCol
        Dim objEntAgraviadoCol As Entity.Registro.AgraviadoCol
        Public CodExpedientePadre As Integer
        Public CodExpedienteReferenciado As Integer
        Public Sub _ListarExpediente(objDocJud As Entity.Registro.DocumentoJudicial, Optional ByVal CargarMandDetencionHistorico As Boolean = True,
                                     Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False)
            Try
                fn_OcultarColumnas()

                If Me._DocumentoJudicialID < 1 Then 'si es nuevo y se muestra los checkeds
                    dgwExpediente.Columns("col_exp_ref").Visible = False
                    mostrarDatosInimputables(-1)
                Else
                    objEntExpedienteCol = New Entity.Registro.ExpedienteCol
                    objEntDelitoCol = New Entity.Registro.DelitoCol
                    objEntAgraviadoCol = New Entity.Registro.AgraviadoCol

                    objBssExp = New Bussines.Registro.Expediente
                    objBssDelito = New Bussines.Registro.Delito
                    objBssAgraviado = New Bussines.Registro.InternoAgraviado

                    If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                        Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        objEntExpedienteCol = objBssExp.ListarExpedientexResolucion_LM(Me._DocumentoJudicialID)
                    Else
                        objEntExpedienteCol = objBssExp.ListarExpedientexResolucion(Me._DocumentoJudicialID)
                    End If

                    For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol
                        If objEntExpediente.EstablecimientomentalId = 16 Then ' Tratamiento ambulatorio
                            rbTratamientoAmbulatorio.Checked = True
                        End If
                        Select Case Me._TipoResolucion
                            Case enumTipoDocumentoJudicial.Detencion, enumTipoDocumentoJudicial.DetencionCarceleta, enumTipoDocumentoJudicial.DetencionReferenciado
                                If objEntExpediente.ExpedienteReferidoID > 0 Then
                                    lblExpedienteReferenciado.Visible = True
                                    lblExpedienteReferenciado.Text = "Expediente referenciado"
                                    CodExpedienteReferenciado = objEntExpediente.ExpedienteReferidoID
                                Else
                                    lblExpedienteReferenciado.Visible = False
                                End If
                                objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                                objEntExpPadre.InternoID = Me._InternoID
                                objEntExpPadre.DocJudicialID = Me._DocumentoJudicialID
                                objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                                Select Case Me._TipoLicencia
                                    Case enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana
                                        CodExpedientePadre = objBssExpedientePad.ListarGrilla_LM(objEntExpPadre).Count
                                    Case Else
                                        CodExpedientePadre = objBssExpedientePad.ListarGrilla(objEntExpPadre).Count
                                End Select
                        End Select
                        Temporal_GrabarExpediente(objEntExpediente)

                        'ver datos de inimputables
                        mostrarDatosInimputables(objEntExpediente.MotivoIngresoID)

                        Dim objDelito As New Entity.Registro.Delito
                        objDelito.Codigo = -1
                        objDelito.IngresoInpeId = Me._InternoIngresoInpeId
                        objDelito.IngresoID = Me._InternoIngresoID
                        objDelito.InternoID = Me._InternoID
                        objDelito.ExpedienteID = objEntExpediente.Codigo
                        objDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal

                        If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or
                            Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                            objEntDelitoCol = objBssDelito.Listar2_LM(objDelito)
                        Else
                            objEntDelitoCol = objBssDelito.Listar2(objDelito)
                        End If


                        For Each objEntDelito As Entity.Registro.Delito In objEntDelitoCol
                            objEntDelito.DelitoAuxiliar = False
                            Temporal_GrabarDelito(objEntExpediente, objEntDelito, Nothing)

                            Dim objAgr As New Entity.Registro.Agraviado
                            With objAgr
                                .Codigo = -1
                                .DelitoID = objEntDelito.Codigo
                                .InternoID = Me._InternoID
                                .IngresoInpeId = Me._InternoIngresoInpeId
                                .IngresoID = Me._InternoIngresoID
                                .ExpedienteID = objEntDelito.ExpedienteID
                                .TipoSentenciaId = -1
                                .AgraviadoNombre = ""
                            End With
                            objAgr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal

                            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                                objEntAgraviadoCol = objBssAgraviado.Listar_LM(objAgr)
                            Else
                                objEntAgraviadoCol = objBssAgraviado.Listar(objAgr)
                            End If

                            For Each objEntAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                                Temporal_GrabarAgraviado(objEntDelito, objEntAgraviado)
                            Next

                        Next
                    Next
                    Temporal_ListarExpediente()
                    If Me._SubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                        blnValorDel = True
                        blnValorExp = True
                        Me.dgwExpediente_CellClick(Nothing, Nothing)
                        Me.dgwDelito.Rows(0).Selected = True
                        Me.dgwDelitos_CellClick(Nothing, Nothing)
                    End If

                    '------------------------------ HNRB -------------------------------------->
                    objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
                    objEntPerCon.DocJudicialId = objDocJud.Codigo
                    objEntPerCon.RegionId = Me._RegionID
                    objEntPerCon.PenalId = Me._PenalID
                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                        objEntPerCon.PenalId = -1
                    End If
                    objEntPeriodoCondenaTempoCol = (New Bussines.Registro.Documento.PeriodoCondenaSentencia).Listar(objEntPerCon)
                    For i As Integer = 0 To objEntPeriodoCondenaTempoCol.Count - 1 'indexar cada expediente
                        objEntPeriodoCondenaTempoCol.PeriodoCondenaSentencia(i).PeriodoCondenaItem = i + 1
                    Next
                    listarGrillaPeriodoCondena()

                    With objDocJud
                        Me._TotalAnhos = .SentenciaTotalAnios
                        Me._TotalMes = .SentenciaTotalMeses
                        Me._TotalDias = .SentenciaTotalDias
                    End With
                    '<--------------------------------------------------------------------------
                    intReferenciado = 0
                    For Each objE As Entity.Registro.Expediente In objEntExpedienteCol
                        If objE.ExpedienteReferidoID > 0 Then
                            intReferenciado = objE.ExpedienteReferidoID
                            Me.rbTemporal.Enabled = False
                            Me.rbCadenaperpetua.Enabled = False
                            txtAnios.ReadOnly = True
                            txtMeses.ReadOnly = True
                            txtDias.ReadOnly = True
                        End If
                    Next

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Public ExpedienteCodAux As Integer = 0
        Public EntExpedienteAux As Entity.Registro.Expediente = Nothing
        Public EntExpedienteAvocam As Entity.Registro.Expediente
        Dim objEntExpedienteCol2 As New Entity.Registro.ExpedienteCol
        Dim CodigoMayor As Integer = -1
        Public Sub _ListarExpedientePadre(DocumentoJudicialID As Integer, Optional ByVal CargarMandDetencionHistorico As Boolean = True,
                                     Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False)
            Dim objEntExpedientePad_ As New Entity.Registro.InternoExpedientePadre
            Dim objBssExpedientePad As New Bussines.Registro.InternoExpedientePadre
            objBssExpediente = New Bussines.Registro.Expediente

            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Then
                pnlCabExpediente.Visible = False
                dgwExpediente.Visible = False
            End If
            If Me._DocumentoJudicialID > 0 Then 'si es nuevo y se muestra los checkeds
                Dim intValor As Integer = 0

                Dim objEntDelitoCol As New Entity.Registro.DelitoCol
                Dim objEntAgraviadoCol As New Entity.Registro.AgraviadoCol
                objBssDelito = New Bussines.Registro.Delito
                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                Select Case Me._TipoLicencia
                    Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                        objEntExpedienteCol2 = (New Bussines.Registro.Expediente).ListarExpedientexResolucion_LM(Me._DocumentoJudicialID)
                    Case Else
                        objEntExpedienteCol2 = (New Bussines.Registro.Expediente).ListarExpedientexResolucion(Me._DocumentoJudicialID)
                End Select

                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol2
                    If objEntExpediente.Codigo > CodigoMayor Then
                        CodigoMayor = objEntExpediente.Codigo
                    End If
                Next
                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol2
                    If objEntExpediente.Codigo = CodigoMayor Then
                        EntExpedienteAvocam = New Entity.Registro.Expediente
                        Temporal_GrabarExpediente(objEntExpediente)
                        Dim objDelito As New Entity.Registro.Delito
                        objDelito.Codigo = -1
                        objDelito.IngresoID = Me._InternoIngresoID
                        objDelito.IngresoInpeId = Me._InternoIngresoInpeId
                        objDelito.InternoID = Me._InternoID
                        objDelito.ExpedienteID = objEntExpediente.Codigo
                        Select Case Me._TipoLicencia
                            Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                objEntDelitoCol = objBssDelito.Listar2_LM(objDelito)
                            Case Else
                                objEntDelitoCol = objBssDelito.Listar2(objDelito)
                        End Select

                        For Each objEntDelito As Entity.Registro.Delito In objEntDelitoCol
                            objEntDelito.DelitoAuxiliar = False
                            Temporal_GrabarDelito(objEntExpediente, objEntDelito, Nothing)
                            Dim objEnt As New Entity.Registro.Agraviado
                            With objEnt
                                .Codigo = -1
                                .DelitoID = objEntDelito.Codigo
                                .InternoID = Me._InternoID
                                .IngresoInpeId = Me._InternoIngresoInpeId
                                .IngresoID = Me._InternoIngresoID
                                .ExpedienteID = objEntExpediente.Codigo
                                .TipoSentenciaId = -1
                                .AgraviadoNombre = ""
                            End With
                            Select Case Me._TipoLicencia
                                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                    objEntAgraviadoCol = objBssAgraviado.Listar_LM(objEnt)
                                Case Else
                                    objEntAgraviadoCol = objBssAgraviado.Listar(objEnt)
                            End Select

                            For Each objEntAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                                Temporal_GrabarAgraviado(objEntDelito, objEntAgraviado)
                            Next
                        Next
                        EntExpedienteAvocam = objEntExpediente
                    Else
                        Me.ExpedienteCodAux = objEntExpediente.Codigo
                        Me.EntExpedienteAux = objEntExpediente
                    End If
                Next
                If Not (EntExpedienteAux Is Nothing) Then
                    With dgwExpediente
                        CodigoExpedienteAux = EntExpedienteAux.Codigo
                        .Item("col_aut_jud", 0).Value = EntExpedienteAux.AutoridadJudicialNombre
                        .Item("col_sal_jud", 0).Value = EntExpedienteAux.SalaJudicialNombre
                        .Item("col_juez_nom", 0).Value = EntExpedienteAux.ExpedienteJuez
                        .Item("col_secre", 0).Value = EntExpedienteAux.ExpedienteSecretario
                    End With
                    Me.dgwExpediente_CellClick(Nothing, Nothing)
                End If
            End If
        End Sub
        Dim CodigoExpedienteAux As Integer = -1
#End Region
#Region "Periodo_Condena"

        Private Function TemporalPeriodoSentenciaItemMaximo() As Integer
            Dim intNumero As Integer = 0

            If objEntPeriodoCondenaTempoCol Is Nothing Then
                objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            End If

            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                If obj.PeriodoCondenaItem > intNumero Then intNumero = obj.PeriodoCondenaItem
            Next
            Return intNumero
        End Function
        Private Sub listarGrillaPeriodoCondena()

            If objEntPeriodoCondenaTempoCol Is Nothing Then
                objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            End If
            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                dtpFechaInicio.ValueLong = obj.FechaInicio
                dtpFechaFinal.ValueLong = obj.FechaFin
            Next
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
        Public Sub Listar_PeriodoCondena(strFechaInicio As String, strFechaFinal As String)
            objEntPeriodoCondenaTempoCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia

            'Dim pos As Integer = -1
            'Dim FechaInicio As String() = strFechaInicio.Split(",")

            If strFechaInicio.Length = 0 Then
                dtpFechaInicio.ValueLong = 0
            Else
                dtpFechaInicio.ValueLong = strFechaInicio
            End If
            If strFechaFinal.Length = 0 Then
                dtpFechaFinal.ValueLong = 0
            Else
                dtpFechaFinal.ValueLong = strFechaFinal
            End If
            'objEntPerCon.FechaFin = strFechaFinal
            'dtpFechaFinal.ValueLong = objEntPerCon.FechaFin
            'For Each fecha As String In FechaInicio
            '    pos += 1
            '    If pos Mod 2 = 0 Then
            '        objEntPerCon = New Entity.Registro.Documento.PeriodoCondenaSentencia
            '        If fecha = "" Then
            '            fecha = 0
            '        End If
            '        objEntPerCon.FechaInicio = fecha
            '        dtpFechaInicio.ValueLong = objEntPerCon.FechaInicio
            '    Else
            '        objEntPerCon.FechaFin = fecha
            '        dtpFechaFinal.ValueLong = objEntPerCon.FechaFin
            '        objEntPerCon.RegionId = Me._RegionID
            '        objEntPerCon.PenalId = Me._PenalID
            '        objEntPeriodoCondenaTempoCol.Add(objEntPerCon)
            '    End If
            'Next

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
            listarGrillaPeriodoCondena()
        End Sub
        Private Sub grabarBDPeriodoCondena(idDocumentoJudicial As Integer, objListaPeriodoCondena As Entity.Registro.Documento.PeriodoCondenaSentenciaCol)

            If objEntPeriodoCondenaTempoCol Is Nothing Then
                Exit Sub
            End If

            Dim objBssPerCon As New Bussines.Registro.Documento.PeriodoCondenaSentencia
            For Each entPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia In objEntPeriodoCondenaTempoCol
                With entPerCond
                    .DocJudicialId = idDocumentoJudicial
                    .InternoId = Me._InternoID
                    .IngresoId = Me._InternoIngresoID
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .FechaInicio = Me.dtpFechaInicio.ValueLong
                    .FechaFin = Me.dtpFechaFinal.ValueLong
                End With

                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then

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
            If objEntPeriodoCondenaTempoCol.Count = 0 Then
                If Me.dtpFechaInicio.ValueLong > 0 Or Me.dtpFechaFinal.ValueLong > 0 Then
                    Dim entPerCond As New Entity.Registro.Documento.PeriodoCondenaSentencia
                    With entPerCond
                        .DocJudicialId = idDocumentoJudicial
                        .InternoId = Me._InternoID
                        .IngresoId = Me._InternoIngresoID
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        .FechaInicio = Me.dtpFechaInicio.ValueLong
                        .FechaFin = Me.dtpFechaFinal.ValueLong
                        .PenalId = Me._PenalID
                        .RegionId = Me._RegionID
                    End With
                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then

                        If entPerCond.FlgEliminado = True Then
                            If entPerCond.Codigo > 0 Then objBssPerCon.Eliminar(entPerCond.Codigo, Me.FlagTransferSede)
                        Else
                            objBssPerCon.Grabar_LM(entPerCond)
                            ' objEntPeriodoCondenaTempoCol.Add(entPerCond)
                        End If

                    Else
                        If entPerCond.FlgEliminado = True Then
                            If entPerCond.Codigo > 0 Then objBssPerCon.Eliminar(entPerCond.Codigo, Me.FlagTransferSede)
                        Else
                            objBssPerCon.Grabar(entPerCond)
                            ' objEntPeriodoCondenaTempoCol.Add(entPerCond)
                        End If
                    End If
                End If
            End If
        End Sub
#End Region
#Region "Accion"
        Public _EntExpAvocat As New Entity.Registro.Expediente
        Public Sub _Grabar(DocumentoJudicialID As Integer, Nuevo As Boolean, Optional TipoLibertadID As Short = -1, Optional TipoDocumento As Short = -1)
            EliminarExpedienteBD()
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                    AGrabar_LM(DocumentoJudicialID, Nuevo, TipoLibertadID, TipoDocumento)
                Case Else
                    AGrabar(DocumentoJudicialID, Nuevo, TipoLibertadID, TipoDocumento)
            End Select
        End Sub

        Private Sub AGrabar_LM(DocumentoJudicialID As Integer, Nuevo As Boolean, Optional TipoLibertadID As Short = -1, Optional TipoDocumento As Short = -1)

            objBssDoc = New Bussines.Registro.DocumentoJudicial
            objBssExp = New Bussines.Registro.Expediente
            objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
            objBssDelito = New Bussines.Registro.Delito
            objBssAgraviado = New Bussines.Registro.InternoAgraviado
            bssMov = New Bussines.Registro.InternoMovimiento

            'Recorrer expedientes y grabar
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                GrabarAvocamiento_LM(DocumentoJudicialID, Nuevo)
            Else

                grabarBDPeriodoCondena(DocumentoJudicialID, objEntPeriodoCondenaTempoCol)

                For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol

                    If _getEsInimputable = True And rbTratamientoAmbulatorio.Checked = True Then
                        _EstablecimientomentalId = 16 'Tratamiento ambulatorio
                        objExpediente.EstablecimientomentalId = 16
                    End If

                    Dim ExpedienteOrigId As Integer = objExpediente.Codigo
                    Dim DocumentoOrigId As Integer = objExpediente.CreaDocJudicialId
                    Dim intIdExpe As Integer = -1
                    With objExpediente
                        If Nuevo = True Then
                            With objExpediente
                                If objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                                   objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                                   objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                    Dim entExpCol As New Entity.Registro.ExpedienteCol
                                    entExpCol = objBssExp.ListarExpedientexResolucion_LM(objExpediente.CreaDocJudicialId)
                                    For Each objExp As Entity.Registro.Expediente In entExpCol
                                        objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, Me.FlagTransferSede)
                                    Next
                                Else
                                    If .Codigo > 0 Then objBssExp.GrabarEstadoVisibilidad(.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                                End If
                                .Codigo = -1
                                .ExpedienteVisible = 1
                            End With
                        Else
                            If ExpedienteOrigId > 0 And DocumentoOrigId <> DocumentoJudicialID Then
                                If objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                                    objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                                    objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                    Dim entExpCol As New Entity.Registro.ExpedienteCol
                                    entExpCol = objBssExp.ListarExpedientexResolucion_LM(objExpediente.CreaDocJudicialId)
                                    For Each objExp As Entity.Registro.Expediente In entExpCol
                                        objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, FlagTransferSede)
                                    Next
                                    .Codigo = -1
                                Else
                                    objBssExp.GrabarEstadoVisibilidad(.Codigo, False, FlagTransferSede)
                                    .Codigo = -1
                                End If
                                objExpediente.ExpedienteVisible = 1
                            Else
                                If objExpediente.Codigo < 1 Then
                                    objExpediente.ExpedienteVisible = 1
                                End If
                            End If
                        End If
                        If TipoDocumento = enumTipoDocumentoJudicial.Revocatoria_de_Libertad Then
                            objExpediente.LibertadTipoID = -1
                        End If
                        .InternoID = Me._InternoID
                        .IngresoID = Me._InternoIngresoID  'reseteamos el numero ingreso del nuevo objeto expe al num ing actual
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .CreaDocJudicialId = DocumentoJudicialID
                        objExpediente.FlagTransferenciaSede = Me.FlagTransferSede
                    End With
                    intIdExpe = objBssExp.Grabar_LM(objExpediente)
                    ' GrabarSubTipoLibertad
                    Dim bss As New Bussines.Registro.ExpedienteLibertadSubtipo
                    bss.GrabarTipoLibertad(objExpediente, intIdExpe, Me._TipoResolucion, Me.ObjTotalCol)
                    '----------------------Padre------------------------------------
                    If intIdExpe > 0 Then
                        Dim objIntExpPad As New Entity.Registro.InternoExpedientePadre
                        With objIntExpPad
                            .InternoID = Me._InternoID
                            .IngresoID = -1 'Me._InternoIngresoID
                            .IngresoInpeId = Me._InternoIngresoInpeId
                            .DocJudicialID = DocumentoJudicialID
                            .InternoExpedienteId = intIdExpe
                            .InternoExpedienteRefPadreId = ExpedienteOrigId
                            .FlagTransferenciaSede = Me.FlagTransferSede
                            ._RegionId = Me._RegionID
                            ._PenalId = Me._PenalID
                        End With
                        '---------------ExpedientePadre------------------------------
                        If Nuevo = True Then
                            If objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                               objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                               objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                Dim entExpColPad As New Entity.Registro.ExpedienteCol
                                entExpColPad = objBssExp.ListarExpedientexResolucion_LM(ExpedienteOrigId)
                                For Each objExp As Entity.Registro.Expediente In entExpColPad
                                    For Each obj As Entity.Registro.Expediente In entExpColAcum
                                        If objExp.Codigo = obj.Codigo Then
                                            objBssExp.GrabarEstadoVisibilidad(obj.Codigo, False, Me.FlagTransferSede)
                                            objIntExpPad.InternoExpedienteRefPadreId = obj.Codigo
                                            objBssExpedientePad.Grabar_LM(objIntExpPad)
                                        End If

                                    Next
                                Next
                            Else
                                If ExpedienteOrigId > 0 Then
                                    objBssExpedientePad.Grabar_LM(objIntExpPad) 'guardar en BD
                                End If
                            End If
                        Else
                            If ExpedienteOrigId < 1 Or (ExpedienteOrigId > 0 And DocumentoOrigId <> DocumentoJudicialID) Then
                                If objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                                   objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                                   objExpediente.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                    Dim entExpColPad As New Entity.Registro.ExpedienteCol
                                    entExpColPad = objBssExp.ListarExpedientexResolucion_LM(ExpedienteOrigId)
                                    For Each objExp As Entity.Registro.Expediente In entExpColPad
                                        objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, Me.FlagTransferSede)
                                        objIntExpPad.InternoExpedienteRefPadreId = objExp.Codigo
                                        objBssExpedientePad.Grabar_LM(objIntExpPad)
                                    Next
                                Else
                                    objIntExpPad.InternoExpedienteId = intIdExpe
                                    objIntExpPad.InternoExpedienteRefPadreId = ExpedienteOrigId
                                    objBssExpedientePad.Grabar_LM(objIntExpPad)
                                End If
                            End If
                        End If
                    End If

                    objBssExp.UpdateEstadoEjecucionLib(intIdExpe, objExpediente, Me._TipoResolucion)

                    Dim intIdDel As Integer = -1
                    Dim intIdAgrav As Integer = -1
                    '----------------------Registrar delitos-------------------------

                    For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                        Dim codigoDelitoOri As Integer = objDel.Codigo
                        Dim creaDelitoOri As Integer = objDel.CreaDocJudicialId
                        If objExpediente.ExpedienteItem = objDel.ExpedienteItem Then
                            If Nuevo = True Then
                                objDel.Codigo = -1
                            Else
                                If codigoDelitoOri > 0 And creaDelitoOri <> DocumentoJudicialID Then
                                    objDel.Codigo = -1
                                End If
                            End If
                            objDel.ExpedienteID = intIdExpe  'referencia al nuevo expediente
                            objDel.CreaDocJudicialId = DocumentoJudicialID
                            objDel.InternoID = Me._InternoID
                            objDel.IngresoID = -1 'Me._InternoIngresoID
                            objDel.IngresoInpeId = Me._InternoIngresoInpeId
                            objDel.FlagTransferenciaSede = Me.FlagTransferSede
                            objDel.RegionID = Me._RegionID
                            objDel.PenalID = Me._PenalID

                            If codigoDelitoOri > 0 And creaDelitoOri <> DocumentoJudicialID Then objDel.CodigodelitoPad = codigoDelitoOri

                            intIdDel = objBssDelito.Grabar_LM(objDel)

                            For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                                Dim codigoAgraviadoOri As Integer = obj.Codigo
                                Dim creaAgraviadoOri As Integer = obj.CreaDocJudicialId

                                If objDel.DelitoItem = obj.DelitoItem Then
                                    If Nuevo = True Then
                                        obj.Codigo = -1
                                    Else
                                        If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                            obj.Codigo = -1
                                        End If
                                    End If
                                    obj.DelitoID = intIdDel
                                    obj.CreaDocJudicialId = DocumentoJudicialID
                                    obj.ExpedienteID = intIdExpe
                                    obj.InternoID = Me._InternoID
                                    obj.IngresoID = -1 'Me._InternoIngresoID
                                    obj.IngresoInpeId = Me._InternoIngresoInpeId
                                    obj.FlagTransferenciaSede = Me.FlagTransferSede
                                    obj.RegionID = Me._RegionID
                                    obj.PenalID = Me._PenalID

                                    If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then obj.CodigoagraviadoPad = codigoAgraviadoOri

                                    intIdAgrav = objBssAgraviado.Grabar_LM(obj)
                                End If
                            Next
                        End If
                    Next
                    objExpediente.Codigo = intIdExpe
                Next
            End If
            If Me._TipoResolucion = enumTipoDocumentoJudicial.Libertad And Me._Documentos_sin_mov = False Then
                If Me.grabarMovimientoLibertad = True Then
                    Dim EntMov As New Entity.Registro.InternoMovimiento
                    With EntMovimiento
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        .InternoID = Me._InternoID
                        .IngresoID = Me._InternoIngresoID
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        ._RegionID = Me._RegionID
                        ._PenalID = Me._PenalID
                        .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso
                        .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                        .EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                        EntMov = bssMov.Listar_LM(EntMovimiento)
                        If EntMov.Codigo > 0 Then
                            .Fecha = EntMov.Fecha
                            .MovimientoMotivoID = EntMov.MovimientoMotivoID
                            .Observacion = EntMov.Observacion
                            EntMovimiento.Codigo = EntMov.Codigo
                        End If
                        .DocumJudicialID = DocumentoJudicialID
                        '------------------
                        Dim entDocJud As New Entity.Registro.DocumentoJudicial
                        entDocJud.Codigo = DocumentoJudicialID
                        entDocJud = objBssDoc.Listar_v2(entDocJud)
                        .DocumJudicialNum = entDocJud.DocumentoNumero
                        .DocumJudicialFecha = entDocJud.DocumentoFecha
                        .DocumJudicialFecharecepcion = entDocJud.DocumentoFechaRecepcion
                        .TipoAutoridadJudicialID = entDocJud.TipoAutoridadJudicial
                        .AutoridadJudicialID = entDocJud.DistritoJudicial
                        .SalaJudicialID = entDocJud.SalaJuzgado
                        .DocJudJuez = entDocJud.JuezNombre
                        .DocJudSecretario = entDocJud.SecretarioNombre
                        .RegionOrigenID = Me._RegionID
                        .PenalOrigenID = Me._PenalID
                        .RegionDestinoID = entDocJud.RegionDestinoId
                        .PenalDestinoID = entDocJud.PenalDestinoid
                    End With
                    bssMov.Grabar_LM(EntMovimiento)
                End If
            ElseIf Me._TipoResolucion = enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
               Me._TipoResolucion = enumTipoDocumentoJudicial.Queda Then
                If blnCondicionLib = True Then
                    entMov = New Entity.Registro.InternoMovimiento
                    entMov.InternoID = Me._InternoID
                    entMov.IngresoID = Me._InternoIngresoID
                    entMov.IngresoInpeId = Me._InternoIngresoInpeId
                    entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                    entMov = bssMov.Listar(entMov)
                    'Legolas.Configuration.Aplication.MessageBox.Exclamation("pendienteh") 'pendientehnrb analizar
                    bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
                End If
            Else
                If blnCondicionLib = True Then
                    entMov = New Entity.Registro.InternoMovimiento
                    With entMov
                        .InternoID = Me._InternoID
                        .IngresoID = Me._InternoIngresoID
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                    End With
                    entMov = bssMov.Listar(entMov)
                    'Legolas.Configuration.Aplication.MessageBox.Exclamation("pendienteh") 'pendientehnrb analizar
                    bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
                End If
            End If
        End Sub
        Private Sub AGrabar(DocumentoJudicialID As Integer, Nuevo As Boolean, Optional TipoLibertadID As Short = -1, Optional TipoDocumento As Short = -1)

            objBssExp = New Bussines.Registro.Expediente
            objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
            Dim intIdExped As Integer = -1

            'Recorrer expedientes y grabar
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                GrabarAvocamiento(DocumentoJudicialID, Nuevo)
            Else
                grabarBDPeriodoCondena(DocumentoJudicialID, objEntPeriodoCondenaTempoCol)

                For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol
                    Dim CodExpedienteOrig As Integer = objExpediente.Codigo
                    Dim CodDocumentoOrig As Integer = objExpediente.CreaDocJudicialId
                    Dim CodDocumentoTipoOrig As Integer = objExpediente.DocumentoTipoID
                    intIdExped = -1

                    If _getEsInimputable = 1 And rbTratamientoAmbulatorio.Checked = True Then
                        _EstablecimientomentalId = 16 'Tratamiento ambulatorio
                    End If

                    With objExpediente
                        If Nuevo = True Then
                            If .DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                               .DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                               .DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then

                                Dim entExpCol As New Entity.Registro.ExpedienteCol
                                entExpCol = objBssExp.ListarExpedientexResolucion(objExpediente.CreaDocJudicialId)
                                For Each objExp As Entity.Registro.Expediente In entExpCol
                                    objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, Me.FlagTransferSede)
                                Next
                            Else
                                If objExpediente.Codigo > 0 Then objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                            End If
                            .Codigo = -1
                        Else
                            If CodExpedienteOrig > 0 And CodDocumentoOrig <> DocumentoJudicialID Then
                                If .DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                                                                           .DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                                      .DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                                    Dim entExpCol As New Entity.Registro.ExpedienteCol
                                    entExpCol = objBssExp.ListarExpedientexResolucion(objExpediente.CreaDocJudicialId)
                                    For Each objExp As Entity.Registro.Expediente In entExpCol
                                        objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, FlagTransferSede)
                                    Next
                                Else
                                    objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, FlagTransferSede)
                                End If
                                .Codigo = -1
                            End If
                        End If
                        '-----Datos del Expediente
                        .ExpedienteVisible = 1
                        .IngresoID = Me._InternoIngresoID  'reseteamos el numero ingreso del nuevo objeto expe al num ing actual
                        .CreaDocJudicialId = DocumentoJudicialID
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        If TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
                           TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                            .LibertadTipoID = -1
                        End If
                    End With

                    intIdExped = objBssExp.Grabar(objExpediente)
                    ' GrabarSubTipoLibertad
                    Dim bss As New Bussines.Registro.ExpedienteLibertadSubtipo
                    bss.GrabarTipoLibertad(objExpediente, intIdExped, Me._TipoResolucion, Me.ObjTotalCol)
                    '----------------------Padre------------------------------------
                    If intIdExped > 0 Then
                        Dim objExpedientePad As New Entity.Registro.InternoExpedientePadre
                        With objExpedientePad
                            .InternoID = Me._InternoID
                            .IngresoID = Me._InternoIngresoID
                            .DocJudicialID = DocumentoJudicialID
                            .InternoExpedienteId = intIdExped
                            .InternoExpedienteRefPadreId = CodExpedienteOrig
                            .FlagTransferenciaSede = Me.FlagTransferSede
                            ._RegionId = Me._RegionID
                            ._PenalId = Me._PenalID
                        End With
                        '<---------------ExpedientePadre------------------------------
                        With objExpediente
                            If .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                               .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                               .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                               CodDocumentoTipoOrig = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                               CodDocumentoTipoOrig = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                               CodDocumentoTipoOrig = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then

                                If (Nuevo = True And CodExpedienteOrig > 0) Or
                                    (Nuevo = False And (CodExpedienteOrig < 1 Or (CodExpedienteOrig > 0 And CodDocumentoOrig <> DocumentoJudicialID))) Then
                                    Dim entExpCol As New Entity.Registro.ExpedienteCol
                                    entExpCol = objBssExp.ListarExpedientexResolucion(CodDocumentoOrig)
                                    For Each objExp As Entity.Registro.Expediente In entExpCol
                                        objBssExp.GrabarEstadoVisibilidad(objExp.Codigo, False, FlagTransferSede)
                                        objExpedientePad.InternoExpedienteRefPadreId = objExp.Codigo
                                        objBssExpedientePad.Grabar(objExpedientePad)
                                    Next
                                End If
                            Else
                                If (Nuevo = True And CodExpedienteOrig > 0) Or
                                   (Nuevo = False And (CodExpedienteOrig < 1 Or (CodExpedienteOrig > 0 And CodDocumentoOrig <> DocumentoJudicialID))) Then
                                    objBssExpedientePad.Grabar(objExpedientePad) 'guardar en BD
                                End If
                            End If
                        End With
                    End If

                    objBssExp.UpdateEstadoEjecucionLib(intIdExped, objExpediente, Me._TipoResolucion)

                    Dim intIdDel As Integer = -1
                    Dim intIdAgrav As Integer = -1
                    '----------------------Registrar delitos-------------------------
                    For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                        If objExpediente.ExpedienteItem = objDel.ExpedienteItem Then
                            objBssDelito = New Bussines.Registro.Delito
                            Dim codigoDelitoOri As Integer = objDel.Codigo
                            Dim creaDelitoOri As Integer = objDel.CreaDocJudicialId
                            If Nuevo = True Then
                                objDel.Codigo = -1
                            Else
                                If codigoDelitoOri > 0 And creaDelitoOri <> DocumentoJudicialID Then
                                    objDel.Codigo = -1
                                End If
                            End If
                            objDel.ExpedienteID = intIdExped  'referencia al nuevo expediente
                            objDel.CreaDocJudicialId = DocumentoJudicialID
                            objDel.InternoID = Me._InternoID
                            objDel.IngresoID = Me._InternoIngresoID
                            objDel.FlagTransferenciaSede = Me.FlagTransferSede
                            objDel.RegionID = Me._RegionID
                            objDel.PenalID = Me._PenalID
                            If codigoDelitoOri > 0 And creaDelitoOri <> DocumentoJudicialID Then
                                objDel.CodigodelitoPad = codigoDelitoOri
                            End If
                            intIdDel = objBssDelito.Grabar_v2(objDel)

                            For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                                If objDel.DelitoItem = obj.DelitoItem Then
                                    Dim codigoAgraviadoOri As Integer = obj.Codigo
                                    Dim creaAgraviadoOri As Integer = obj.CreaDocJudicialId
                                    objBssAgraviado = New Bussines.Registro.InternoAgraviado
                                    If Nuevo = True Then
                                        obj.Codigo = -1
                                    Else
                                        If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                            obj.Codigo = -1
                                        End If
                                    End If
                                    obj.DelitoID = intIdDel
                                    obj.CreaDocJudicialId = DocumentoJudicialID
                                    obj.ExpedienteID = intIdExped
                                    obj.InternoID = Me._InternoID
                                    obj.IngresoID = Me._InternoIngresoID
                                    obj.FlagTransferenciaSede = Me.FlagTransferSede
                                    obj.RegionID = Me._RegionID
                                    obj.PenalID = Me._PenalID
                                    If codigoAgraviadoOri > 0 And creaAgraviadoOri <> DocumentoJudicialID Then
                                        obj.CodigoagraviadoPad = codigoAgraviadoOri
                                    End If
                                    intIdAgrav = objBssAgraviado.Grabar(obj)
                                End If
                            Next
                        End If
                    Next
                    objExpediente.Codigo = intIdExped
                Next
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad And Me._Documentos_sin_mov = False Then
                If Me.grabarMovimientoLibertad = True Then
                    Select Case Me._GrillaLibertadTipoID
                        Case 176 'excento de responsabilidad penal
                            Exit Sub
                    End Select
                    Dim bssMovimiento As New Bussines.Registro.InternoMovimiento
                    Dim EntMov As New Entity.Registro.InternoMovimiento
                    With EntMovimiento
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        .InternoID = Me._InternoID
                        .IngresoID = Me._InternoIngresoID
                        ._RegionID = Me._RegionID
                        ._PenalID = Me._PenalID
                        .MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso
                        .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                        .EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                        EntMov = bssMovimiento.Listar(EntMovimiento)
                        ' If EntMov.Codigo > 0 Then
                        .Fecha = Me._FechaMovimiento
                        .MovimientoMotivoID = objEntExpedienteTempoCol.Item(0).LibertadTipoID ' EntMov.MovimientoMotivoID
                        .Observacion = EntMov.Observacion
                        EntMovimiento.Codigo = EntMov.Codigo
                        'End If
                        .DocumJudicialID = DocumentoJudicialID
                        '------------------
                        objBssDoc = New Bussines.Registro.DocumentoJudicial
                        Dim entDocJud As New Entity.Registro.DocumentoJudicial
                        entDocJud.Codigo = DocumentoJudicialID
                        entDocJud = objBssDoc.Listar_v2(entDocJud)
                        .DocumJudicialNum = entDocJud.DocumentoNumero
                        .DocumJudicialFecha = entDocJud.DocumentoFecha
                        .DocumJudicialFecharecepcion = entDocJud.DocumentoFechaRecepcion
                        .TipoAutoridadJudicialID = entDocJud.TipoAutoridadJudicial
                        .AutoridadJudicialID = entDocJud.DistritoJudicial
                        .SalaJudicialID = entDocJud.SalaJuzgado
                        .DocJudJuez = entDocJud.JuezNombre
                        .DocJudSecretario = entDocJud.SecretarioNombre
                        .RegionOrigenID = Me._RegionID
                        .PenalOrigenID = Me._PenalID
                        .RegionDestinoID = entDocJud.RegionDestinoId
                        .PenalDestinoID = entDocJud.PenalDestinoid
                        If entDocJud.EstadoEjecucionId = 3 Then
                            .EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado
                            .Fecha = entDocJud.FechaMovimiento
                        End If
                    End With
                    bssMovimiento.Grabar(EntMovimiento)
                Else
                    Dim objExp As New Entity.Registro.Expediente
                    objExp.Codigo = intIdExped
                    objBssExp.UpdateDmpSmp(objExp)
                End If
            ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
               Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda Then
                If blnCondicionLib = True Then
                    bssMov = New Bussines.Registro.InternoMovimiento
                    entMov = New Entity.Registro.InternoMovimiento
                    entMov.InternoID = Me._InternoID
                    entMov.IngresoID = Me._InternoIngresoID
                    entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                    entMov = bssMov.Listar(entMov)
                    bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
                End If
            Else
                If blnCondicionLib = True Then
                    bssMov = New Bussines.Registro.InternoMovimiento
                    entMov = New Entity.Registro.InternoMovimiento
                    entMov.InternoID = Me._InternoID
                    entMov.IngresoID = Me._InternoIngresoID
                    entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                    entMov = bssMov.Listar(entMov)
                    bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
                End If
            End If
        End Sub

        Private Sub GrabarAvocamiento(DocumentoJudicialID As Integer, Nuevo As Boolean)
            objBssExp = New Bussines.Registro.Expediente
            objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre

            Dim intIdExpe As Integer = -1
            Dim intIdExpePad As Integer = -1
            ''-------------
            Dim CodigoMayor As Integer = -1
            If Nuevo = False Then
                If objEntExpedienteCol2.Count > 0 Then
                    For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol2
                        If objEntExpediente.Codigo > CodigoMayor Then
                            CodigoMayor = objEntExpediente.Codigo
                        End If
                    Next
                Else
                    Nuevo = True
                End If
            End If
            ''-------------
            If Nuevo = True Then
                For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol
                    Dim CodExpedienteOrig As Integer = objExpediente.Codigo
                    Dim CodDocumentoOrig As Integer = objExpediente.CreaDocJudicialId
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    With objExpediente
                        .CreaDocJudicialId = DocumentoJudicialID
                        .IngresoID = Me._InternoIngresoID
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        ._RegionId = Me._RegionID
                        ._PenalId = Me._PenalID
                    End With
                    With objEntExpPadre
                        .DocJudicialID = DocumentoJudicialID
                        .InternoID = Me._InternoID
                        .IngresoID = Me._InternoIngresoID
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        ._RegionId = Me._RegionID
                        ._PenalId = Me._PenalID
                    End With
                    If objExpediente.Codigo < 1 Then
                        With objExpediente
                            ''''REGISTRAR 1ER EXPEDIENTE AVOCADO 
                            .ExpedienteVisible = 0
                            intIdExpe = objBssExp.Grabar(objExpediente)
                            intIdExpePad = intIdExpe
                            GuardarAvocamientoDelitoAgraviado(DocumentoJudicialID, CodExpedienteOrig, intIdExpe, objExpediente)
                            ''''REGISTRAR 2do EXPEDIENTE AVOCADO 
                            .ExpedienteVisible = 1
                            .AutoridadJudicialID = _EntExpAvocat.AutoridadJudicialID
                            .AutoridadJudicialNombre = _EntExpAvocat.AutoridadJudicialNombre
                            .SalaJudicialID = _EntExpAvocat.SalaJudicialID
                            .SalaJudicialNombre = _EntExpAvocat.SalaJudicialNombre
                            .ExpedienteJuez = _EntExpAvocat.ExpedienteJuez
                            .ExpedienteSecretario = _EntExpAvocat.ExpedienteSecretario

                            intIdExpe = objBssExp.Grabar(objExpediente)
                            GuardarAvocamientoDelitoAgraviado(DocumentoJudicialID, CodExpedienteOrig, intIdExpe, objExpediente)
                        End With
                        With objEntExpPadre
                            .InternoExpedienteId = intIdExpe
                            .InternoExpedienteRefPadreId = intIdExpePad
                            objBssExpedientePad.Grabar_LM(objEntExpPadre)
                        End With
                    Else 'NUEVO=FALSE y el Expediente existe
                        ''Registrar Primer expediente
                        If objExpediente.DocumentoTipoID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Then
                            If objExpediente.Codigo > 0 And CodDocumentoOrig <> DocumentoJudicialID Then objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                        End If
                        With objExpediente
                            .Codigo = -1
                            .ExpedienteVisible = 0
                            intIdExpe = objBssExp.Grabar(objExpediente)
                            intIdExpePad = intIdExpe
                            GuardarAvocamientoDelitoAgraviado(DocumentoJudicialID, CodExpedienteOrig, intIdExpe, objExpediente)
                        End With
                        With objEntExpPadre
                            .InternoExpedienteId = intIdExpe
                            If objExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Then
                                Dim ExpCol As New Entity.Registro.ExpedienteCol
                                ExpCol = objBssExp.ListarExpedientexResolucion(CodDocumentoOrig)
                                For Each ent As Entity.Registro.Expediente In ExpCol
                                    objBssExp.GrabarEstadoVisibilidad(ent.Codigo, False, Me.FlagTransferSede)
                                    objEntExpPadre.InternoExpedienteRefPadreId = ent.Codigo
                                    objBssExpedientePad.Grabar(objEntExpPadre)
                                Next
                            Else
                                .InternoExpedienteRefPadreId = CodExpedienteOrig
                                objBssExpedientePad.Grabar(objEntExpPadre)
                            End If
                        End With
                        ''Registrar Segundo expediente
                        With objExpediente
                            .Codigo = -1
                            .ExpedienteVisible = 1
                            'Cargar datos de avocamiento
                            .AutoridadJudicialID = _EntExpAvocat.AutoridadJudicialID
                            .AutoridadJudicialNombre = _EntExpAvocat.AutoridadJudicialNombre
                            .SalaJudicialID = _EntExpAvocat.SalaJudicialID
                            .SalaJudicialNombre = _EntExpAvocat.SalaJudicialNombre
                            .ExpedienteJuez = _EntExpAvocat.ExpedienteJuez
                            .ExpedienteSecretario = _EntExpAvocat.ExpedienteSecretario

                            intIdExpe = objBssExp.Grabar(objExpediente)
                            objExpediente.CreaDocJudicialId = CodDocumentoOrig
                            GuardarAvocamientoDelitoAgraviado(DocumentoJudicialID, CodExpedienteOrig, intIdExpe, objExpediente)
                        End With
                        With objEntExpPadre
                            .InternoExpedienteId = intIdExpe
                            .InternoExpedienteRefPadreId = intIdExpePad
                            objBssExpedientePad.Grabar(objEntExpPadre)
                        End With
                    End If
                Next
            Else  'Nuevo=False
                Dim posExp As Integer = -1
                For Each objExpediente As Entity.Registro.Expediente In objEntExpedienteCol2
                    Dim codigoExpedienteOrig As Integer = objExpediente.Codigo
                    Dim codigoDocumentoOrig As Integer = objExpediente.CreaDocJudicialId
                    With objExpediente
                        If objExpediente.Codigo < CodigoMayor Then 'Primer expediente
                            .ExpedienteVisible = 0
                            .IngresoInpeId = Me._InternoIngresoInpeId
                            .FlagTransferenciaSede = Me.FlagTransferSede
                            ._RegionId = Me._RegionID
                            ._PenalId = Me._PenalID
                            posExp = 0
                        Else
                            If codigoExpedienteOrig > 0 And codigoDocumentoOrig <> DocumentoJudicialID Then
                                .Codigo = -1
                            End If
                            .ExpedienteVisible = 1
                            .AutoridadJudicialID = _EntExpAvocat.AutoridadJudicialID
                            .AutoridadJudicialNombre = _EntExpAvocat.AutoridadJudicialNombre
                            .SalaJudicialID = _EntExpAvocat.SalaJudicialID
                            .SalaJudicialNombre = _EntExpAvocat.SalaJudicialNombre
                            .ExpedienteJuez = _EntExpAvocat.ExpedienteJuez
                            .ExpedienteSecretario = _EntExpAvocat.ExpedienteSecretario
                            posExp = 1
                        End If
                    End With
                    intIdExpe = objBssExp.Grabar(objExpediente)
                    GuardarAvocamientoDelitoAgraviadoUpd(DocumentoJudicialID, codigoExpedienteOrig, intIdExpe, objExpediente, posExp)
                Next
            End If
        End Sub
        Private Sub GrabarAvocamiento_LM(DocumentoJudicialID As Integer, Nuevo As Boolean)
            objBssExp = New Bussines.Registro.Expediente
            objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre

            Dim intIdExpe As Integer = -1
            Dim intIdExpePad As Integer = -1
            ''-------------
            Dim CodigoMayor As Integer = -1
            If Nuevo = False Then
                If objEntExpedienteCol2.Count > 0 Then
                    For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteCol2
                        If objEntExpediente.Codigo > CodigoMayor Then
                            CodigoMayor = objEntExpediente.Codigo
                        End If
                    Next
                Else
                    Nuevo = True
                End If
            End If
            ''-------------
            If Nuevo = True Then
                For Each objExpediente As Entity.Registro.Expediente In Me.objEntExpedienteTempoCol
                    Dim CodExpedienteOrig As Integer = objExpediente.Codigo
                    Dim CodDocumentoOrig As Integer = objExpediente.CreaDocJudicialId
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    With objExpediente
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .CreaDocJudicialId = DocumentoJudicialID
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        ._RegionId = Me._RegionID
                        ._PenalId = Me._PenalID
                    End With
                    With objEntExpPadre
                        .DocJudicialID = DocumentoJudicialID
                        .InternoID = Me._InternoID
                        .IngresoID = Me._InternoIngresoID
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        ._RegionId = Me._RegionID
                        ._PenalId = Me._PenalID
                    End With
                    If objExpediente.Codigo < 1 Then
                        With objExpediente
                            ''''REGISTRAR 1ER EXPEDIENTE AVOCADO 
                            .ExpedienteVisible = 0
                            intIdExpe = objBssExp.Grabar_LM(objExpediente)
                            intIdExpePad = intIdExpe
                            GuardarAvocamientoDelitoAgraviado(DocumentoJudicialID, CodExpedienteOrig, intIdExpe, objExpediente)
                            ''''REGISTRAR 2do EXPEDIENTE AVOCADO 
                            .ExpedienteVisible = 1
                            .AutoridadJudicialID = _EntExpAvocat.AutoridadJudicialID
                            .AutoridadJudicialNombre = _EntExpAvocat.AutoridadJudicialNombre
                            .SalaJudicialID = _EntExpAvocat.SalaJudicialID
                            .SalaJudicialNombre = _EntExpAvocat.SalaJudicialNombre
                            .ExpedienteJuez = _EntExpAvocat.ExpedienteJuez
                            .ExpedienteSecretario = _EntExpAvocat.ExpedienteSecretario

                            intIdExpe = objBssExp.Grabar_LM(objExpediente)
                            GuardarAvocamientoDelitoAgraviado(DocumentoJudicialID, CodExpedienteOrig, intIdExpe, objExpediente)
                        End With
                        With objEntExpPadre
                            .InternoExpedienteId = intIdExpe
                            .InternoExpedienteRefPadreId = intIdExpePad
                            objBssExpedientePad.Grabar_LM(objEntExpPadre)
                        End With
                    Else 'NUEVO=FALSE y el Expediente existe
                        ''Registrar Primer expediente
                        If objExpediente.DocumentoTipoID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Then
                            If objExpediente.Codigo > 0 And CodDocumentoOrig <> DocumentoJudicialID Then objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False, Me.FlagTransferSede) 'ocultamos el original
                        End If
                        With objExpediente
                            .Codigo = -1
                            .ExpedienteVisible = 0
                            intIdExpe = objBssExp.Grabar_LM(objExpediente)
                            intIdExpePad = intIdExpe
                            GuardarAvocamientoDelitoAgraviado(DocumentoJudicialID, CodExpedienteOrig, intIdExpe, objExpediente)
                        End With
                        With objEntExpPadre
                            .InternoExpedienteId = intIdExpe
                            If objExpediente.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes Then
                                Dim ExpCol As New Entity.Registro.ExpedienteCol
                                ExpCol = objBssExp.ListarExpedientexResolucion(CodDocumentoOrig)
                                For Each ent As Entity.Registro.Expediente In ExpCol
                                    objBssExp.GrabarEstadoVisibilidad(ent.Codigo, False, Me.FlagTransferSede)
                                    objEntExpPadre.InternoExpedienteRefPadreId = ent.Codigo
                                    objBssExpedientePad.Grabar_LM(objEntExpPadre)
                                Next
                            Else
                                .InternoExpedienteRefPadreId = CodExpedienteOrig
                                objBssExpedientePad.Grabar_LM(objEntExpPadre)
                            End If
                        End With
                        ''Registrar Segundo expediente
                        With objExpediente
                            .Codigo = -1
                            .ExpedienteVisible = 1
                            'Cargar datos de avocamiento
                            .AutoridadJudicialID = _EntExpAvocat.AutoridadJudicialID
                            .AutoridadJudicialNombre = _EntExpAvocat.AutoridadJudicialNombre
                            .SalaJudicialID = _EntExpAvocat.SalaJudicialID
                            .SalaJudicialNombre = _EntExpAvocat.SalaJudicialNombre
                            .ExpedienteJuez = _EntExpAvocat.ExpedienteJuez
                            .ExpedienteSecretario = _EntExpAvocat.ExpedienteSecretario

                            intIdExpe = objBssExp.Grabar_LM(objExpediente)
                            objExpediente.CreaDocJudicialId = CodDocumentoOrig
                            GuardarAvocamientoDelitoAgraviado(DocumentoJudicialID, CodExpedienteOrig, intIdExpe, objExpediente)
                        End With
                        With objEntExpPadre
                            .InternoExpedienteId = intIdExpe
                            .InternoExpedienteRefPadreId = intIdExpePad
                            objBssExpedientePad.Grabar_LM(objEntExpPadre)
                        End With
                    End If
                Next
            Else  ''------------NUEVO=FALSE--------------------
                Dim PosExp As Integer = -1
                For Each objExpediente As Entity.Registro.Expediente In objEntExpedienteCol2
                    Dim codigoExpedienteOrig As Integer = objExpediente.Codigo
                    Dim codigoDocumentoOrig As Integer = objExpediente.CreaDocJudicialId
                    With objExpediente
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        If objExpediente.Codigo < CodigoMayor Then 'Primer expediente
                            .ExpedienteVisible = 0
                            .IngresoInpeId = Me._InternoIngresoInpeId
                            ._RegionId = Me._RegionID
                            ._PenalId = Me._PenalID
                            PosExp = 0
                        Else
                            If codigoExpedienteOrig > 0 And codigoDocumentoOrig <> DocumentoJudicialID Then
                                .Codigo = -1
                            End If
                            .ExpedienteVisible = 1
                            .AutoridadJudicialID = _EntExpAvocat.AutoridadJudicialID
                            .AutoridadJudicialNombre = _EntExpAvocat.AutoridadJudicialNombre
                            .SalaJudicialID = _EntExpAvocat.SalaJudicialID
                            .SalaJudicialNombre = _EntExpAvocat.SalaJudicialNombre
                            .ExpedienteJuez = _EntExpAvocat.ExpedienteJuez
                            .ExpedienteSecretario = _EntExpAvocat.ExpedienteSecretario
                            PosExp = 1
                            intIdExpe = objBssExp.Grabar_LM(objExpediente)
                            GuardarAvocamientoDelitoAgraviadoUpd(DocumentoJudicialID, codigoExpedienteOrig, intIdExpe, objExpediente, PosExp)
                        End If
                    End With
                Next
            End If
        End Sub

        Private Sub GuardarAvocamientoDelitoAgraviado(DocumentoJudicialID As Integer, ExpedienteCodigo As Integer,
                                                     intIdExpe As Integer, objExpediente As Entity.Registro.Expediente)
            Dim intIdDel As Integer = -1
            Dim intIdAgrav As Integer = -1
            '----------------------Registrar delitos-------------------------
            For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol

                If objExpediente.ExpedienteItem = objDel.ExpedienteItem Then
                    Dim codDelitoOrig As Integer = objDel.Codigo
                    Dim creaDelitoOrig As Integer = objDel.CreaDocJudicialId
                    objBssDelito = New Bussines.Registro.Delito
                    If Nuevo = True Then
                        objDel.Codigo = -1
                        objDel.CodigodelitoPad = codDelitoOrig
                    Else
                        If codDelitoOrig > 0 And creaDelitoOrig = DocumentoJudicialID Then
                            objDel.Codigo = -1
                        End If
                    End If
                    objDel.ExpedienteID = intIdExpe  'referencia al nuevo expediente
                    objDel.CreaDocJudicialId = DocumentoJudicialID
                    objDel.InternoID = Me._InternoID
                    objDel.IngresoID = Me._InternoIngresoID
                    objDel.IngresoInpeId = Me._InternoIngresoInpeId
                    objDel.FlagTransferenciaSede = Me.FlagTransferSede
                    objDel.RegionID = Me._RegionID
                    objDel.PenalID = Me._PenalID
                    If codDelitoOrig > 0 And creaDelitoOrig <> objExpediente.CreaDocJudicialId Then
                        objDel.CodigodelitoPad = codDelitoOrig
                    End If
                    Select Case Me._TipoLicencia
                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                            intIdDel = objBssDelito.Grabar_LM(objDel)
                        Case Else
                            intIdDel = objBssDelito.Grabar_v2(objDel)
                    End Select
                    objDel.Codigo = intIdDel
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If objDel.DelitoItem = obj.DelitoItem Then
                            Dim codAgraviadoOrig As Integer = obj.Codigo
                            Dim creaAgraviadoOrig As Integer = obj.CreaDocJudicialId
                            objBssAgraviado = New Bussines.Registro.InternoAgraviado

                            If Nuevo = True Then
                                obj.Codigo = -1
                                obj.CodigoagraviadoPad = codAgraviadoOrig
                            Else
                                If codAgraviadoOrig > 0 And creaAgraviadoOrig <> DocumentoJudicialID Then
                                    obj.Codigo = -1
                                End If
                            End If
                            obj.DelitoID = intIdDel
                            obj.CreaDocJudicialId = DocumentoJudicialID
                            obj.ExpedienteID = intIdExpe
                            obj.InternoID = Me._InternoID
                            obj.IngresoID = Me._InternoIngresoID
                            obj.IngresoInpeId = Me._InternoIngresoInpeId
                            obj.FlagTransferenciaSede = Me.FlagTransferSede
                            obj.RegionID = Me._RegionID
                            obj.PenalID = Me._PenalID
                            If codAgraviadoOrig > 0 And creaDelitoOrig <> objExpediente.CreaDocJudicialId Then
                                obj.CodigoagraviadoPad = codAgraviadoOrig
                            End If
                            Select Case Me._TipoLicencia
                                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                    intIdAgrav = objBssAgraviado.Grabar_LM(obj)
                                Case Else
                                    intIdAgrav = objBssAgraviado.Grabar(obj)
                            End Select
                            obj.Codigo = intIdAgrav
                        End If
                    Next
                End If
            Next
        End Sub
        Private Sub GuardarAvocamientoDelitoAgraviadoUpd(DocumentoJudicialID As Integer, ExpedienteCodigo As Integer,
                                                     intIdExpe As Integer, objExpediente As Entity.Registro.Expediente, num As Integer)
            Dim intIdDel As Integer = -1
            Dim intIdAgrav As Integer = -1
            objBssAgraviado = New Bussines.Registro.InternoAgraviado
            objBssDelito = New Bussines.Registro.Delito
            '----------------------Registrar delitos-------------------------
            For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                Dim codDelitoOrig As Integer = objDel.Codigo
                Dim creaDelitoOrig As Integer = objDel.CreaDocJudicialId
                If objExpediente.Codigo = objDel.ExpedienteID Then
                    objDel.ExpedienteID = objExpediente.Codigo
                    objDel.CreaDocJudicialId = DocumentoJudicialID
                    objDel.InternoID = Me._InternoID
                    objDel.IngresoInpeId = Me._InternoIngresoInpeId
                    objDel.IngresoID = Me._InternoIngresoID
                    objDel.FlagTransferenciaSede = Me.FlagTransferSede
                    objDel.RegionID = Me._RegionID
                    objDel.PenalID = Me._PenalID
                    Select Case Me._TipoLicencia
                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                            intIdDel = objBssDelito.Grabar_LM(objDel)
                        Case Else
                            intIdDel = objBssDelito.Grabar_v2(objDel)
                    End Select
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If objDel.DelitoItem = obj.DelitoItem Then
                            obj.FlagTransferenciaSede = Me.FlagTransferSede
                            obj.DelitoID = intIdDel
                            obj.CreaDocJudicialId = DocumentoJudicialID
                            obj.ExpedienteID = objExpediente.Codigo
                            obj.InternoID = Me._InternoID
                            obj.IngresoID = Me._InternoIngresoID
                            obj.IngresoInpeId = Me._InternoIngresoInpeId
                            obj.RegionID = Me._RegionID
                            obj.PenalID = Me._PenalID
                            Select Case Me._TipoLicencia
                                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                    intIdAgrav = objBssAgraviado.Grabar_LM(obj)
                                Case Else
                                    intIdAgrav = objBssAgraviado.Grabar(obj)
                            End Select
                        End If
                    Next
                Else
                    If num = 1 Then
                        If codDelitoOrig > 0 And objDel.CodigodelitoPad = -1 Then
                            objDel.CodigodelitoPad = codDelitoOrig
                            objDel.Codigo = -1
                        End If
                    End If
                    If codDelitoOrig > 0 And creaDelitoOrig <> DocumentoJudicialID Then
                        objDel.Codigo = -1
                    End If
                    'objDel.ExpedienteID = intIdExpe  'referencia al nuevo expediente
                    objDel.ExpedienteID = objExpediente.Codigo
                    objDel.CreaDocJudicialId = DocumentoJudicialID
                    objDel.InternoID = Me._InternoID
                    objDel.IngresoID = Me._InternoIngresoID
                    objDel.IngresoInpeId = Me._InternoIngresoInpeId
                    objDel.FlagTransferenciaSede = Me.FlagTransferSede
                    objDel.RegionID = Me._RegionID
                    objDel.PenalID = Me._PenalID
                    If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        Dim objAux As New Entity.Registro.Delito
                        objAux = objDel
                        objAux.Codigo = objDel.CodigodelitoPad
                        intIdDel = objBssDelito.Grabar_LM(objDel)
                    Else
                        intIdDel = objBssDelito.Grabar_v2(objDel)
                    End If
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If objDel.DelitoItem = obj.DelitoItem Then
                            Dim codAgraviadoOrig As Integer = obj.Codigo
                            Dim creaAgraviadoOrig As Integer = obj.CreaDocJudicialId
                            If num = 1 Then
                                If codAgraviadoOrig > 0 And obj.CodigoagraviadoPad = -1 Then
                                    obj.CodigoagraviadoPad = codAgraviadoOrig
                                    obj.Codigo = -1
                                End If
                            End If
                            If codAgraviadoOrig > 0 And creaAgraviadoOrig <> DocumentoJudicialID Then
                                obj.Codigo = -1
                            End If
                            obj.DelitoID = intIdDel
                            obj.CreaDocJudicialId = DocumentoJudicialID
                            obj.ExpedienteID = objExpediente.Codigo
                            obj.InternoID = Me._InternoID
                            obj.IngresoID = Me._InternoIngresoID
                            obj.IngresoInpeId = Me._InternoIngresoInpeId  ' objExpediente.IngresoInpeId
                            obj.FlagTransferenciaSede = Me.FlagTransferSede
                            obj.RegionID = Me._RegionID
                            obj.PenalID = Me._PenalID
                            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                                Dim objA As New Entity.Registro.Agraviado
                                If num = 0 Then
                                    objA = obj
                                    objA.Codigo = obj.CodigoagraviadoPad
                                    intIdAgrav = objBssAgraviado.Grabar_LM(objA)
                                Else
                                    intIdAgrav = objBssAgraviado.Grabar_LM(obj)
                                    '  obj.Codigo = intIdAgrav
                                End If
                            Else
                                intIdAgrav = objBssAgraviado.Grabar(obj)
                            End If
                        End If
                    Next
                End If
            Next
        End Sub
        Public EntMovimiento As New Entity.Registro.InternoMovimiento
        Public entMov As Entity.Registro.InternoMovimiento
        Private blnCondicionLib As Boolean = False
        Public Function GenerarMovimientoLibertad() As Boolean
            objBssExpediente = New Bussines.Registro.Expediente
            bssMov = New Bussines.Registro.InternoMovimiento

            blnCondicionLib = False
            Dim objExp As New Entity.Registro.Expediente
            Dim objEntExpedienteTempoCol_Aux1 As New Entity.Registro.ExpedienteCol
            Dim objEntExpedienteTempoCol_Aux2 As New Entity.Registro.ExpedienteCol
            objExp.InternoID = Me._InternoID
            objExp.IngresoInpeId = Me._InternoIngresoInpeId
            objExp.IngresoID = Me._InternoIngresoID
            objExp.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEntExpedienteTempoCol_Aux1 = (New Bussines.Registro.Expediente).ListarGrillaPopup_LM(objExp)
            Else
                objEntExpedienteTempoCol_Aux1 = (New Bussines.Registro.Expediente).ListarGrillaPopup(objExp)
            End If


            Dim ContaLib As Integer = 0
            Dim ContaLibExp As Integer = 0
            Dim blnEdic As Boolean = False
            For Each EntExp As Entity.Registro.Expediente In objEntExpedienteTempoCol_Aux1
                If EntExp.LibertadTipoID < 1 Then 'exp sin libertad 
                    ContaLib = ContaLib + 1
                    objEntExpedienteTempoCol_Aux2.Add(EntExp)
                End If
            Next
            Dim intContaNuevosLib As Integer = 0
            For Each objLib As Entity.Registro.Expediente In objEntExpedienteTempoCol_Aux2
                For Each EntTem As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If objLib.Codigo = EntTem.Codigo And EntTem.LibertadTipoID > 0 Then
                        intContaNuevosLib = intContaNuevosLib + 1
                    End If
                Next
            Next

            entMov = New Entity.Registro.InternoMovimiento
            entMov.InternoID = Me._InternoID
            entMov.IngresoInpeId = Me._InternoIngresoInpeId
            entMov.IngresoID = Me._InternoIngresoID
            entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                entMov = bssMov.Listar_LM(entMov)
            Else
                entMov = bssMov.Listar(entMov)
            End If

            Dim Valor As Integer = 0
            Dim ExpTem As Integer = 0
            Dim entExpCol_edi As New Entity.Registro.ExpedienteCol
            If Me._DocumentoJudicialID > 0 Then

                If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    entExpCol_edi = objBssExpediente.ListarExpedientexResolucion_LM(Me._DocumentoJudicialID)
                Else
                    entExpCol_edi = objBssExpediente.ListarExpedientexResolucion(Me._DocumentoJudicialID)
                End If
            End If

            Dim ContaEdic As Integer = 0
            For Each Entidad2_ As Entity.Registro.Expediente In objEntExpedienteTempoCol
                Dim ind As Integer = 0

                If Me._DocumentoJudicialID < 1 Then
                    If Entidad2_.LibertadTipoID > 0 Then
                        ContaLibExp = ContaLibExp + 1
                    End If
                Else
                    For Each obj As Entity.Registro.Expediente In entExpCol_edi
                        If obj.Codigo = Entidad2_.Codigo Then
                            ContaEdic = ContaEdic + 1
                        End If
                    Next
                    If ContaEdic = entExpCol_edi.Count Then
                        blnEdic = True
                    End If
                    If Entidad2_.LibertadTipoID > 0 Then
                        ContaLibExp = ContaLibExp + 1
                    End If
                End If
                If Entidad2_.SituacionJuridicaID = 2 Then
                    Valor = ind
                End If
                '
            Next

            Dim strMensajePendientes As String = "El interno CUENTA con procesos pendientes vigentes registrados en el sistema." + Chr(13) +
                                                 "Sirvase ha validar con los archivos fisicos y las registros integros en el sistema." + Chr(13) +
                                                 " " + Chr(13) +
                                                 "¿De todas maneras, desea guardar los datos?"

            Dim strMensaje As String = "Existe un 'Movimiento de libertad'." + Chr(13) +
                               "Si hace click en :" + Chr(13) +
                               "[Si] el sistema actualizara el movimiento de libertad, con el" + Chr(13) +
                               "      documento libertad seleccionado." + Chr(13) +
                               "[No] el proceso seguira con el movimiento de libertad existente."

            Dim strMensajeNew As String = "El interno NO CUENTA con procesos pendientes vigentes." + Chr(13) +
                                          "Sirvase ha validar con los archivos físicos y los registros íntegros en el sistema." + Chr(13) + Chr(13) +
                                          "¿De todas maneras, desea guardar los datos?"

            Dim mensajeGeneraMovimiento As String = Chr(13) + "--> Se generará un movimiento de libertad con el estado pendiente."

            If Me._getEsInimputable = False Then
                strMensajeNew = strMensajeNew + mensajeGeneraMovimiento
            End If

            If Me._DocumentoJudicialID > 0 Then
                If (blnAccionEditar = True Or blnAccionEliminar = True) Or entMov.Codigo < 1 Then
                    If objEntExpedienteTempoCol_Aux2.Count = intContaNuevosLib And blnEdic = True Then
                        If entMov.Codigo < 1 Then
                            blnCondicionLib = True
                            If Legolas.Configuration.Aplication.MessageBox.Question(strMensajeNew) = DialogResult.Yes Then
                                grabarMovimientoLibertad = Not _getEsInimputable
                                Orden_ = True
                            End If
                            Return Orden_
                        Else
                            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then
                                blnCondicionLib = True
                                grabarMovimientoLibertad = Not _getEsInimputable
                                Orden_ = True
                                Return Orden_
                            Else
                                blnCondicionLib = False
                            End If
                        End If
                        Return True
                    End If
                End If
                Return True
            Else  'El documento judicial es nuevo ó -1
                entMov.DocumJudicialID = Me._DocumentoJudicialID

                If objEntExpedienteTempoCol_Aux1.Count = 0 Then
                    Return Orden_
                ElseIf ContaLib > 0 And ContaLib = intContaNuevosLib Then
                    If entMov.Codigo < 1 Then
                        If Me._GrillaLibertadTipoID = 176 Then
                            strMensajeNew = "El interno NO CUENTA con procesos pendientes vigentes." + Chr(13) +
                                           "Sirvase ha validar con los archivos físicos y los registros íntegros en el sistema." + Chr(13) +
                                           " " + Chr(13) +
"¿De todas maneras, desea guardar los datos?"

                        End If
                        If Legolas.Configuration.Aplication.MessageBox.Question(strMensajeNew) = DialogResult.Yes Then
                            grabarMovimientoLibertad = Not _getEsInimputable
                            Orden_ = True
                        End If
                        Return Orden_
                    Else
                        If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then
                            blnCondicionLib = True
                            Return Orden_
                        Else
                            blnCondicionLib = False
                        End If
                        Return True
                    End If
                ElseIf ContaLib = 0 And ContaLibExp = objEntExpedienteTempoCol.Count Then
                    If entMov.Codigo < 1 Then
                        If Legolas.Configuration.Aplication.MessageBox.Question(strMensajeNew) = DialogResult.Yes Then
                            grabarMovimientoLibertad = Not _getEsInimputable
                            Orden_ = True
                        End If
                        Return Orden_
                    Else
                        If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then
                            blnCondicionLib = True
                            grabarMovimientoLibertad = Not _getEsInimputable
                            Orden_ = True
                            Return Orden_
                        Else
                            blnCondicionLib = False
                        End If
                        Return True
                    End If

                Else
                    If Legolas.Configuration.Aplication.MessageBox.Question(strMensajePendientes) = DialogResult.Yes Then
                        Orden_ = True
                    Else
                        Return False
                    End If

                    Return True
                End If
            End If

        End Function
        Public Orden_ As Boolean = False
        Public Property _VariableMov As Integer = 0

        Private Function AEliminarAgraviadoBD(Codigo As Integer) As Integer

            Dim value As Integer = -1
            If Codigo > 0 Then
                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                value = objBssAgraviado.Eliminar(Codigo, Me.FlagTransferSede)
            End If
            Return value

        End Function
        Private Function AEliminarAgraviadoBD2(Codigo As Integer) As Integer

            Dim value As Integer = -1
            If Codigo > 0 Then
                objBssAgraviado = New Bussines.Registro.InternoAgraviado
                value = objBssAgraviado.Eliminar(Codigo, Me.FlagTransferSede)
            End If
            Return value

        End Function

        Private Function AEliminarDelitoBD(Codigo As Integer) As Integer
            Dim value As Integer = -1
            If Codigo > 0 Then
                objBssDelito = New Bussines.Registro.Delito
                value = objBssDelito.Eliminar2(Codigo, Me.FlagTransferSede)
            End If
            Return value

        End Function

        Private Function AEliminarExpedienteBD(Codigo As Integer) As Integer

            Dim value As Integer = -1
            If Codigo > 0 Then
                Dim CodExpedienteHij As Integer = -1
                Dim entPad As New Entity.Registro.InternoExpedientePadre
                objBssExpediente = New Bussines.Registro.Expediente

                If Me._TipoResolucion = enumTipoDocumentoJudicial.Libertad Or Me._TipoResolucion = enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
                      Me._TipoResolucion = enumTipoDocumentoJudicial.Queda Then
                    'objBssExpediente.GrabarEstadoVisibilidad(Codigo, False, Me.FlagTransferSede)
                    entPad.InternoID = Me._InternoID
                    entPad.InternoExpedienteId = Codigo
                    CodExpedienteHij = objBssExpedientePad.Listar(entPad).InternoExpedienteRefPadreId
                ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                    entPad.InternoID = Me._InternoID
                    entPad.InternoExpedienteId = Codigo
                    CodExpedienteHij = objBssExpedientePad.Listar(entPad).InternoExpedienteRefPadreId
                End If
                Select Case Me._TipoLicencia
                    Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                        value = objBssExpediente.Eliminar_LM(Codigo, Me.FlagTransferSede)
                    Case Else
                        value = objBssExpediente.Eliminar2(Codigo, Me.FlagTransferSede)
                End Select
                If value > 0 Then
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    If Me._TipoResolucion = enumTipoDocumentoJudicial.Libertad Or Me._TipoResolucion = enumTipoDocumentoJudicial.Revocatoria_de_Libertad Or
                      Me._TipoResolucion = enumTipoDocumentoJudicial.Queda Then

                        Dim ObjPad As New Entity.Registro.InternoExpedientePadre
                        ObjPad.InternoExpedienteId = Codigo
                        ObjPad.InternoID = Me._InternoID
                        ObjPad.IngresoInpeId = Me._InternoIngresoInpeId
                        intPadre = objBssExpedientePad.Listar_LM(ObjPad).Codigo
                        objBssExpedientePad.Eliminar(intPadre, Me.FlagTransferSede)

                        objBssExpediente.GrabarEstadoVisibilidad_LM(CodExpedienteHij, 1, Me.FlagTransferSede)
                        '------------------------------------------------------------
                        Dim objExpPadre As New Entity.Registro.InternoExpedientePadre
                        Dim objExpPadreCol As New Entity.Registro.InternoExpedientePadreCol
                        objExpPadre.InternoExpedienteId = value
                        If objExpPadre.InternoID > 0 Then
                            Select Case Me._TipoLicencia
                                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                    objExpPadreCol = objBssExpedientePad.ListarGrilla_LM(objExpPadre)
                                Case Else
                                    objExpPadreCol = objBssExpedientePad.ListarGrilla(objExpPadre)
                            End Select
                            For Each obj As Entity.Registro.InternoExpedientePadre In objExpPadreCol
                                objBssExpediente.GrabarEstadoVisibilidad(obj.InternoExpedienteRefPadreId, True, Me.FlagTransferSede)
                            Next
                        End If
                    ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                        value = objBssExpediente.Eliminar2(CodExpedienteHij, Me.FlagTransferSede)
                        Dim bssDel As New Bussines.Registro.Delito
                        Dim bssAgr As New Bussines.Registro.InternoAgraviado
                        Dim entDelCol As New Entity.Registro.DelitoCol
                        Dim entDel As New Entity.Registro.Delito

                        entDel.InternoID = Me._InternoID
                        entDel.ExpedienteID = CodExpedienteHij
                        entDelCol = bssDel.Listar2(entDel)
                        For Each objD As Entity.Registro.Delito In entDelCol
                            bssDel.Eliminar2(objD.Codigo, Me.FlagTransferSede)

                            Dim entAgrCol As New Entity.Registro.AgraviadoCol
                            Dim entAgr As New Entity.Registro.Agraviado

                            entAgr.InternoID = Me._InternoID
                            entAgr.DelitoID = objD.Codigo
                            entAgrCol = bssAgr.Listar(entAgr)
                            For Each objA As Entity.Registro.Agraviado In entAgrCol
                                bssAgr.Eliminar(objA.Codigo, Me.FlagTransferSede)
                            Next
                        Next
                    Else
                        objBssExpedientePad.Eliminar(intPadre, Me.FlagTransferSede)
                        objBssExpediente.GrabarEstadoVisibilidad(intPadre, False, Me.FlagTransferSede)
                    End If
                End If
            End If
            Return value

        End Function

        Private Sub AnularDelito()

            If dgwDelito.Rows.Count < 1 Then Exit Sub

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
                If Me._DocumentoJudicialID > -1 Then
                    Dim objBss As New Bussines.Registro.Delito
                    If objBss.GrabarEstado(Me._GrillaDelitoID, 0, Me.FlagTransferSede) = -1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("Error: No es posible anular el delito seleccionado, Consulte con el administrador del sistema")
                        Exit Sub
                    End If
                End If
                objEntExpedienteTempoCol.Item(dgwExpediente.CurrentCell.RowIndex).ListaDelitos.Item(dgwDelito.CurrentCell.RowIndex).Estado = Type.Enumeracion.EstadoNulidadRegistro.EnumEstadoNulidadRegistro.Anulado
                'ListarDelitos()
                Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria")
            End If
        End Sub

        Private Sub AnularAgraviado()
            If dgwAgraviados.Rows.Count < 1 Then Exit Sub

            Dim dlgPregunta As DialogResult
            Dim strPregunta As String = "¿Esta Seguro de anular el Agraviado seleccionado?"
            Dim strTitulo As String = "INPE - SIP-POPE"

            dlgPregunta = MessageBox.Show(strPregunta, strTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dlgPregunta = DialogResult.Yes Then
                If Me._DocumentoJudicialID > -1 Then
                    Dim objBss As New Bussines.Registro.InternoAgraviado
                    Dim objEnt As New Entity.Registro.Agraviado
                    objEnt.FlagTransferenciaSede = Me.FlagTransferSede
                    objEnt.Codigo = Me.GrillaAgraviadoID
                    objEnt.Estado = 0
                    If objBss.GrabarEstado(objEnt) = -1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("Error: No es posible anular el agraviado seleccionado, Consulte con el administrador del sistema")
                        Exit Sub
                    End If
                End If
                objEntExpedienteTempoCol.Item(dgwExpediente.CurrentCell.RowIndex).ListaDelitos.Item(dgwDelito.CurrentCell.RowIndex).ListaAgraviados.Item(dgwAgraviados.CurrentCell.RowIndex).Estado = Type.Enumeracion.EstadoNulidadRegistro.EnumEstadoNulidadRegistro.Anulado
                'ListarAgraviado()
                Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria")
            End If
        End Sub

        Public Sub EliminarExpedienteBD()
            If blnEliminarColection = True Then
                If ValidarEliminar(ExpedienteIndc.Expediente(0).Codigo) = True Then
                    For Each EntAgr As Entity.Registro.Agraviado In AgraviadosIndcCol
                        AEliminarAgraviadoBD(EntAgr.Codigo)
                    Next
                    For Each EntDel As Entity.Registro.Delito In DelitoIndcCol
                        AEliminarDelitoBD(EntDel.Codigo)
                    Next
                    For Each EntExp As Entity.Registro.Expediente In ExpedienteIndc
                        AEliminarExpedienteBD(EntExp.Codigo)
                    Next
                End If
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                    objEntExpedienteCol2 = New Entity.Registro.ExpedienteCol
                End If
            End If
            If blnEliminarDelitoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In AgraviadosIndcCol2
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
                For Each EntDel As Entity.Registro.Delito In DelitoIndcCol2
                    AEliminarDelitoBD(EntDel.Codigo)
                Next
            End If
            If blnEliminarAgraviadoColec = True Then
                For Each EntAgr As Entity.Registro.Agraviado In AgraviadosIndcCol3
                    AEliminarAgraviadoBD(EntAgr.Codigo)
                Next
            End If
        End Sub
        Private Function ValidarEliminar(Codigo As Integer) As Boolean
            For Each EntVal As Entity.Registro.Expediente In objEntExpedienteTempoCol
                If Codigo = EntVal.Codigo Then
                    Return False
                    Exit For
                End If
            Next
            Return True
        End Function

        Public Sub AGrabar(_Codigo As Integer, intIdExpe As Integer, nuevo As Boolean)
            EliminarExpedienteBD()
            Grabar(_Codigo, intIdExpe, nuevo)
        End Sub

        Private Sub Grabar(_Codigo As Integer, intIdExpe As Integer, nuevo As Boolean)
            Dim intIdDel As Integer = -1
            Dim intIdAgrav As Integer = -1
            If nuevo = True Then
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                    Dim CodDelOrig As Integer = objDel.Codigo
                    objDel.FlagTransferenciaSede = Me.FlagTransferSede
                    objDel.Codigo = -1  'reseteamos la copia del objeto para insertar como nuevo
                    objDel.ExpedienteID = intIdExpe 'referencia al nuevo expediente
                    objDel.CreaDocJudicialId = _Codigo
                    objDel.InternoID = Me._InternoID
                    objDel.IngresoInpeId = Me._InternoIngresoInpeId
                    objDel.IngresoID = Me._InternoIngresoID
                    objDel.RegionID = Me._RegionID
                    objDel.PenalID = Me._PenalID
                    objDel.CodigodelitoPad = CodDelOrig
                    Select Case Me._TipoLicencia
                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                            intIdDel = (New Bussines.Registro.Delito).Grabar_LM(objDel)
                        Case Else
                            intIdDel = (New Bussines.Registro.Delito).Grabar_v2(objDel)
                    End Select
                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        Dim CodAgrOrig As Integer = obj.Codigo
                        obj.FlagTransferenciaSede = Me.FlagTransferSede
                        If objDel.DelitoItem = obj.DelitoItem Then
                            'obj.Codigo = True
                            obj.DelitoID = intIdDel
                            obj.CreaDocJudicialId = _Codigo
                            obj.ExpedienteID = intIdExpe
                            obj.IngresoInpeId = Me._InternoIngresoInpeId
                            obj.IngresoID = Me._InternoIngresoID
                            obj.InternoID = Me._InternoID
                            obj.RegionID = Me._RegionID
                            obj.PenalID = Me._PenalID
                            obj.CodigoagraviadoPad = CodAgrOrig
                            obj.Codigo = -1 'reseteamos
                            Select Case Me._TipoLicencia
                                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                    intIdAgrav = (New Bussines.Registro.InternoAgraviado).Grabar_LM(obj)
                                Case Else
                                    intIdAgrav = (New Bussines.Registro.InternoAgraviado).Grabar(obj)
                            End Select
                        End If
                    Next
                Next
            Else
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                    'objDel.Codigo = -1  'reseteamos la copia del objeto para insertar como nuevo
                    'objDel.ExpedienteID = intIdExpe 'referencia al nuevo expediente
                    objDel.FlagTransferenciaSede = Me.FlagTransferSede
                    objDel.CreaDocJudicialId = _Codigo
                    objDel.InternoID = Me._InternoID
                    objDel.IngresoInpeId = Me._InternoIngresoInpeId
                    objDel.IngresoID = Me._InternoIngresoID
                    objDel.RegionID = Me._RegionID
                    objDel.PenalID = Me._PenalID

                    If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                        Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                        Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        intIdDel = (New Bussines.Registro.Delito).Grabar_LM(objDel)
                    Else
                        intIdDel = (New Bussines.Registro.Delito).Grabar_v2(objDel)
                    End If

                    For Each obj As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                        If objDel.DelitoItem = obj.DelitoItem Then
                            'obj.Codigo = -1
                            obj.FlagTransferenciaSede = Me.FlagTransferSede
                            obj.DelitoID = intIdDel
                            obj.CreaDocJudicialId = _Codigo
                            'obj.ExpedienteID =
                            obj.IngresoInpeId = Me._InternoIngresoInpeId
                            obj.IngresoID = Me._InternoIngresoID
                            obj.InternoID = Me._InternoID
                            obj.RegionID = Me._RegionID
                            obj.PenalID = Me._PenalID
                            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                                intIdAgrav = (New Bussines.Registro.InternoAgraviado).Grabar_LM(obj)
                            Else
                                intIdAgrav = (New Bussines.Registro.InternoAgraviado).Grabar(obj)
                            End If

                        End If
                    Next
                Next
            End If
            If blnCondicionLib = True Then
                bssMov = New Bussines.Registro.InternoMovimiento
                entMov = New Entity.Registro.InternoMovimiento
                entMov.InternoID = Me._InternoID
                entMov.IngresoInpeId = Me._InternoIngresoInpeId
                entMov.IngresoID = Me._InternoIngresoID
                entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                entMov = bssMov.Listar(entMov)
                bssMov.Eliminar(entMov.Codigo, entMov.IngresoID, Me.FlagTransferSede)
            End If
        End Sub

        Public Function ValidarRevocatoriaLibertad() As Boolean
            bssMov = New Bussines.Registro.InternoMovimiento
            Dim intConta As Integer = 0
            Dim intContaLib As Integer = 0
            Dim strMensaje As String = "Desea guardar los datos"
            Dim objEntExpedienteCol_rev As New Entity.Registro.ExpedienteCol
            Dim objExp As New Entity.Registro.Expediente
            objExp.InternoID = Me._InternoID
            objExp.IngresoID = Me._InternoIngresoID

            Dim entMov As New Entity.Registro.InternoMovimiento

            entMov.InternoID = Me._InternoID
            entMov.IngresoID = Me._InternoIngresoID
            entMov.IngresoInpeId = Me._InternoIngresoInpeId
            entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                entMov = bssMov.Listar_LM(entMov)
            Else
                entMov = bssMov.Listar(entMov)
            End If

            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria_de_Libertad Then
                strMensaje = "Este documento revocara los Expedientes con libertad existentes," + Chr(13) +
                               "Existe un [movimiento de libertad], desea eliminarlo." + Chr(13) +
                               "Si hace click en :" + Chr(13) +
                               "[ SI ] El movimiento de libertad se eliminara." + Chr(13) +
                               "[NO] el proceso seguira con el movimiento de libertad existente."
            End If

            If Me._DocumentoJudicialID > 0 Then
                If entMov Is Nothing Then
                    If (blnAccionEditar = True Or blnAccionEliminar = True) Then
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then
                            blnCondicionLib = True
                        End If
                        Return blnCondicionLib
                    End If
                Else
                    If (blnAccionEditar = True Or blnAccionEliminar = True) And entMov.Codigo > 0 Then
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then
                            blnCondicionLib = True
                        End If
                        Return blnCondicionLib
                    End If
                End If
            Else
                If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    strMensaje = "Este documento revocara los Expedientes referenciados con libertad.."
                    If Me._TipoResolucion = 26 Then
                    Else
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then
                            blnCondicionLib = True
                        End If
                    End If
                    Return blnCondicionLib
                Else
                    If entMov.Codigo > 0 Then
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then
                            blnCondicionLib = True
                        End If
                        Return blnCondicionLib
                    End If
                End If
            End If
            Return True
        End Function
        Public Sub VerExpedienteControl()
            If Me._VisibleControlExpediente = False Then
                Me.pnlCabExpediente.Visible = False
                Me.dgwExpediente.Visible = False
                Me.SplitContainer2.Panel1Collapsed = True
            Else
                Me.SplitContainer2.Panel1Collapsed = False
                Me.SplitContainer2.Panel2Collapsed = False

                'Me._VisiblePanelMantExpediente = True
                Me.pnlCabExpediente.Visible = True
                Me.dgwExpediente.Visible = True

                Panel2.Visible = True
                dgwDelito.Visible = True
                Panel3.Visible = True
                dgwAgraviados.Visible = True
            End If
        End Sub
        Public Sub LimpiarExpediendeDelitoGrilla()
            objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
            objEntDelitoCol = New Entity.Registro.DelitoCol
            objEntDelitoTempoCol = New Entity.Registro.DelitoCol
            objEntAgraviadoCol = New Entity.Registro.AgraviadoCol
            objEntAgraviadoTempoCol = New Entity.Registro.AgraviadoCol
            dgwExpediente.DataSource = Nothing
            dgwDelito.DataSource = Nothing
            dgwAgraviados.DataSource = Nothing
        End Sub
        Private Sub eliminarTiempoCondena()

            Me._TotalAnhos = ""
            Me._TotalMes = ""
            Me._TotalDias = ""
            Me.rbTemporal.Checked = True

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
                ._idTipoDocumentoJudicial = Me._TipoResolucion
                ._idTipoImimputable = idTipoInimputable
                ._idCentroSaludMental = idCentroSaludMental

                If .ShowDialog = DialogResult.OK Then

                    mostrarDatosInimputables(._getIdInimputable)
                    ActualizarDatosTipoInimputable(._getIdInimputable, ._getNombreTipoInimputable,
                                                                       ._getIdCentroSaludMental, ._getCentroSaludMentalNombre)

                    RaiseEvent _Click_Inimputable(Me._getEsInimputable)
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
            objEntDelitoTempoCol = New Entity.Registro.DelitoCol
            objEntAgraviadoTempoCol = New Entity.Registro.AgraviadoCol

            With dgwExpediente
                .Columns("col_num_exp").ReadOnly = True
                .Columns("col_sit_jur").ReadOnly = True
                .Columns("col_aut_jud").ReadOnly = True
                .Columns("col_sal_jud").ReadOnly = True
                .Columns("col_secre").ReadOnly = True
                .Columns("col_tip_lib").Visible = False
            End With

        End Sub
        Public Function Validar(Suptipo As Integer) As Boolean
            If Me._Documentos_sin_mov = True Then
                If Not (Me._TipoResolucion = enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionReferenciado Or
                   (Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria And Me._SubTipo = 2)) Then
                    If objEntExpedienteTempoCol.Count = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe ingresar por lo menos un expediente")
                        dgwExpediente.Focus()
                        Return False
                    End If
                End If
                If Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionReferenciado Then
                    If Me._DocumentoJudicialID > 0 And Me._Grilla_NroRegistroExpediente = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar el expediente")
                        dgwExpediente.Focus()
                        Return False
                    End If
                End If
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda Then
                    For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol
                        If obj.MotivoQuedaID < 1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar motivo de Queda")
                            dgwExpediente.Focus()
                            Return False
                        End If
                    Next
                End If
                Return True
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionReferenciado Then
                If Me._DocumentoJudicialID < 1 Then
                    If Me._VisibleControlExpediente = True And Me._Grilla_NroRegistroExpediente = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar el expediente")
                        dgwExpediente.Focus()
                        Return False
                    End If
                End If
            End If
            If Me._DocumentoJudicialID > 0 And
                (Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Or
                 Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Or
                 Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta) Then
                Dim Valor As Integer = 0
                For Each obj As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If obj.ExpedienteReferidoID = 1 Then
                        Valor = Valor + 1
                        Exit For
                    End If
                Next
                If Valor > 0 Then
                    Dim strMensaje As String = ""
                    Select Case _TipoResolucion
                        Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                            strMensaje = "Avocamiento"
                        Case enumTipoDocumentoJudicial.Detencion, enumTipoDocumentoJudicial.DetencionCarceleta
                            strMensaje = "Detención"

                    End Select
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de [" & strMensaje & "] no puede ser modificada," + Chr(13) +
                                                                            "posee un expediente referenciado.")
                    Return False
                End If
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria Then
                If Suptipo = 2 Then
                    Return True
                End If
            End If
            Dim DelNombre As String = ""
            If Me._Grilla_NroRegistroExpediente = 0 Then
                If Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion And Me._TipoResolucion <> enumTipoDocumentoJudicial.DetencionCarceleta And
                   (Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionReferenciado And Me._VisibleControlExpediente = False) Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion debe tener por lo menos un expediente")
                    Return False
                End If
            End If
            'Validar expedientes visibles
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Or
               Me._SubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Or
               Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Or
                (Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionReferenciado And Me._VisibleControlExpediente = False) Then
                If objEntDelitoTempoCol.Count = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente debe tener por lo menos un delito")
                    Return False
                End If
                Dim conDel As Integer = 0
                For i As Integer = 0 To objEntDelitoTempoCol.Count - 1
                    conDel = 0
                    DelNombre = objEntDelitoTempoCol.Item(i).DelitoEspecificoNombre
                    For j As Integer = 0 To objEntAgraviadoTempoCol.Count - 1
                        DelNombre = objEntDelitoTempoCol.Item(i).DelitoEspecificoNombre
                        If objEntDelitoTempoCol.Item(i).DelitoItem = objEntAgraviadoTempoCol.Item(j).DelitoItem Then
                            conDel = conDel + 1
                        End If
                    Next
                    If conDel = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El Delito: [" & DelNombre & ":" & "] debe tener por lo menos un agraviado")
                        Return False
                    End If
                Next
            Else

                Dim ExpNumero As String = ""
                Dim FilaExp_ As Integer = 0
                Dim FilaDel_ As Integer = 0
                'Validar expediente delito or  
                For j As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                    FilaExp_ = 0
                    ExpNumero = objEntExpedienteTempoCol.Expediente(j).ExpedienteNumero
                    For k As Integer = 0 To objEntDelitoTempoCol.Count - 1
                        ExpNumero = objEntExpedienteTempoCol.Expediente(j).ExpedienteNumero
                        If objEntDelitoTempoCol.Item(k).ExpedienteItem = objEntExpedienteTempoCol.Expediente(j).ExpedienteItem Then
                            FilaExp_ = FilaExp_ + 1
                        End If
                    Next
                    If FilaExp_ = 0 Then
                        Exit For
                    End If
                Next
                If FilaExp_ = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente: [" & ExpNumero & "] debe tener por lo menos un delito")
                    Return False
                End If
                'Validar agraviados
                Dim ind1 As Integer = -1
                Dim ExpNumero2 As String = ""
                For k As Integer = 0 To objEntDelitoTempoCol.Count - 1
                    FilaDel_ = 0
                    'DelNombre = objEntDelitoTempoCol.Item(k).DelitoEspecificoNombre
                    If objEntAgraviadoTempoCol.Count = 0 Then
                        ind1 = k
                    Else
                        For l As Integer = 0 To objEntAgraviadoTempoCol.Count - 1
                            If objEntDelitoTempoCol.Delito(k).DelitoItem = objEntAgraviadoTempoCol.Item(l).DelitoItem Then
                                FilaDel_ = FilaDel_ + 1
                            Else
                                ind1 = k
                            End If
                        Next
                    End If
                    If FilaDel_ = 0 Then
                        For j As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                            If objEntDelitoTempoCol.Delito(ind1).ExpedienteItem = objEntExpedienteTempoCol.Item(j).ExpedienteItem Then
                                DelNombre = objEntDelitoTempoCol.Delito(ind1).DelitoEspecificoNombre
                                ExpNumero2 = objEntExpedienteTempoCol.Item(j).ExpedienteNumero
                                Exit For
                            End If
                        Next
                        Exit For
                        Exit For
                    End If
                Next
                If FilaDel_ = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Expediente: [" & ExpNumero2 & "] / Delito: [" & DelNombre & ":" & "] debe tener por lo menos un agraviado")
                    Return False
                End If

                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                    Dim TipLib As Integer = 0
                    Dim TipLib_ As Integer = 1
                    Dim pos As Integer = -1
                    Dim strNumero As String = ""
                    For Each entExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                        If entExp.LibertadTipoID < 1 Then
                            TipLib_ = TipLib_ + 1
                            TipLib = 0
                        Else
                            TipLib = 1
                        End If
                        pos = pos + 1
                        strNumero = entExp.ExpedienteNumero
                        If TipLib * TipLib_ = 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente " & strNumero & " debe tener un tipo de libertad")
                            dgwExpediente.Rows(pos).Selected = True
                            Return False
                            Exit For
                        End If
                    Next
                    If Me._GrillaLibertadTipoID = 176 Or Me._GrillaLibertadTipoID = 26 Then
                        If Me._getEsInimputable = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar el proceso como Inimputable, el tipo de libertad: " + Chr(13) +
                            objEntExpedienteTempoCol.Item(0).LibertadTipoNom)
                            Return False
                        End If
                    End If
                End If

                'validar centro de salud
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                    strMensaje = ""
                    Dim conInm As Integer = 0
                    Dim conNoInm As Integer = 0

                    Dim bss As New Bussines.Registro.Expediente
                    Dim obj As New Entity.Registro.Expediente
                    Dim objCol As New Entity.Registro.ExpedienteCol
                    obj.InternoID = Me._InternoID
                    obj.IngresoID = Me._InternoIngresoID
                    objCol = bss.ListarGrillaPopup(obj)

                    For Each entExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                        If entExp.EstablecimientomentalId < 1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar el establecimiento de salud mental de destino.")
                            Return False
                        End If
                    Next
                    For Each entExp As Entity.Registro.Expediente In objCol
                        If entExp.MotivoIngresoID = 178 Or entExp.MotivoIngresoID = 179 Then
                            conInm += 1
                        Else
                            conNoInm += 1
                        End If
                    Next
                    If objCol.Count > 1 And conNoInm > 0 Then
                        strMensaje = "El interno CUENTA con procesos pendientes vigentes registrados en el sistema." + Chr(13) +
                                         "Sirvase validar con los archivos físicos y los registros integros en el sistema." + Chr(13) +
                                         " " + Chr(13) + "¿De todas maneras desea guardar los datos?"
                    Else
                        strMensaje = "El interno NO CUENTA con procesos pendientes vigentes." + Chr(13) +
                                          "Sirvase ha validar con los archivos físicos y los registros íntegros en el sistema." + Chr(13) + Chr(13) +
                                          "¿De todas maneras, desea guardar los datos?"
                    End If
                    Return True
                End If

                'validar centro de salud
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                    strMensaje = ""
                    Dim conInm As Integer = 0
                    Dim conNoInm As Integer = 0

                    Dim bss As New Bussines.Registro.Expediente
                    Dim obj As New Entity.Registro.Expediente
                    Dim objCol As New Entity.Registro.ExpedienteCol
                    obj.InternoID = Me._InternoID
                    obj.IngresoID = Me._InternoIngresoID
                    objCol = bss.ListarGrillaPopup(obj)

                    For Each entExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                        If entExp.NuevoMotivoInimputableId < 1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar el motivo de conlusión.")
                            Return False
                        End If
                        If entExp.NuevoEstablecimientomentalId < 1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar el nuevo establecimiento de salud mental de destino.")
                            Return False
                        End If
                    Next

                    Return True
                End If
            End If

            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                If dgwExpediente.Item("col_sal_jud_id", 0).Value < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente no refiere una autoridad judicial, ingresar sala judicial")
                    Return False
                End If
            End If
            ''//j.e.u 24/06/2019 cambio realizado para la ORL no validar movimientos de libertad
            If Me._TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana Then
                ValidarRevocatoriaLibertadV2()
            End If
            If blnValorLib = True Then
                Return False
            End If

            Return True
        End Function
        Public strMensaje As String = ""
        Public Function ValidarDocumento(Suptipo As Integer) As Boolean
            Dim DelNombre As String = ""
            Dim ExpNumero As String = ""
            Dim FilaExp_ As Integer = 0
            Dim FilaDel_ As Integer = 0
            'Validar expediente delito or  
            For j As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                FilaExp_ = 0
                ExpNumero = objEntExpedienteTempoCol.Expediente(j).ExpedienteNumero
                For k As Integer = 0 To objEntDelitoTempoCol.Count - 1
                    'ExpNumero = objEntExpedienteTempoCol.Expediente(j).ExpedienteNumero
                    If objEntDelitoTempoCol.Item(k).ExpedienteItem = objEntExpedienteTempoCol.Expediente(j).ExpedienteItem Then
                        FilaExp_ = FilaExp_ + 1
                    End If
                Next
                If FilaExp_ = 0 Then
                    Exit For
                End If
            Next
            If FilaExp_ = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente: [" & ExpNumero & "] debe tener por lo menos un delito")
                Return False
            End If
            'Validar agraviados
            Dim ind1 As Integer = -1
            'For j As Integer = 0 To objEntExpedienteTempoCol.Count - 1
            'ind1 = ind1 + 1
            Dim ExpNumero2 As String = ""
            For k As Integer = 0 To objEntDelitoTempoCol.Count - 1
                FilaDel_ = 0
                'DelNombre = objEntDelitoTempoCol.Item(k).DelitoEspecificoNombre
                If objEntAgraviadoTempoCol.Count = 0 Then
                    ind1 = k
                Else
                    For l As Integer = 0 To objEntAgraviadoTempoCol.Count - 1
                        If objEntDelitoTempoCol.Delito(k).DelitoItem = objEntAgraviadoTempoCol.Item(l).DelitoItem Then
                            FilaDel_ = FilaDel_ + 1
                        Else
                            ind1 = k
                        End If
                    Next
                End If
                If FilaDel_ = 0 Then
                    For j As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                        If objEntDelitoTempoCol.Delito(ind1).ExpedienteItem = objEntExpedienteTempoCol.Item(j).ExpedienteItem Then
                            DelNombre = objEntDelitoTempoCol.Delito(ind1).DelitoEspecificoNombre
                            ExpNumero2 = objEntExpedienteTempoCol.Item(j).ExpedienteNumero
                            Exit For
                        End If
                    Next
                    Exit For
                    Exit For
                End If
            Next
            If FilaDel_ = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Expediente: [" & ExpNumero2 & "] / Delito: [" & DelNombre & ":" & "] debe tener por lo menos un agraviado")
                Return False
            End If

            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                Dim pos As Integer = -1
                Dim strNumero As String = ""
                For i As Integer = 0 To objEntExpedienteTempoCol.Count - 1
                    If objEntExpedienteTempoCol.Item(i).LibertadTipoID < 1 Then
                        strNumero = objEntExpedienteTempoCol.Item(i).ExpedienteNumero
                        pos = i
                        Exit For
                    End If
                Next
                If strNumero.Length > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente " & strNumero & " debe tener un tipo de libertad")
                    dgwExpediente.Rows(pos).Selected = True
                    Return False
                End If
            End If
            Return True
        End Function
        Public Sub ValidarCreacionQueda()
            Dim contaLib As Integer = 0
            Dim ExpQuedaCol As New Entity.Registro.ExpedienteCol
            For Each objExp As Entity.Registro.Expediente In objEntExpedienteCol
                If objExp.LibertadTipoID < 1 Then
                    ExpQuedaCol.Add(objExp)
                End If
            Next
            If ExpQuedaCol.Count > 0 Then

            End If
        End Sub

        Private blnValorLib As Boolean = False
        Public Function ValidarRevocatoriaLibertadV2() As Boolean
            Select Case Me._TipoResolucion
                Case enumTipoDocumentoJudicial.Traslado, enumTipoDocumentoJudicial.Notas, enumTipoDocumentoJudicial.Revocatoria_de_Libertad,
                     enumTipoDocumentoJudicial.Libertad, enumTipoDocumentoJudicial.Queda
                    Exit Function
            End Select
            blnValorLib = False
            entMov = New Entity.Registro.InternoMovimiento
            entMov.InternoID = Me._InternoID
            entMov.IngresoInpeId = Me._InternoIngresoInpeId
            entMov.IngresoID = Me._InternoIngresoID
            entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
            bssMov = New Bussines.Registro.InternoMovimiento
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                    entMov = bssMov.Listar_LM(entMov)
                Case Else
                    entMov = bssMov.Listar(entMov)
            End Select

            If entMov Is Nothing OrElse entMov.Codigo < 1 Then Exit Function 'hnrb 27/04/2018

            Dim intConta As Integer = 0
            Dim intContaLib As Integer = 0
            Dim strMensaje As String = ""
            Dim objEntExpedienteCol_rev As New Entity.Registro.ExpedienteCol
            Dim objExp As New Entity.Registro.Expediente
            objExp.InternoID = Me._InternoID
            objExp.IngresoInpeId = Me._InternoIngresoInpeId
            objExp.IngresoID = Me._InternoIngresoID

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

                        If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                            Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                            Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                            padre = objBssExpedientePad.Listar_LM(objEntExpPadre)
                        Else
                            padre = objBssExpedientePad.Listar(objEntExpPadre)
                        End If

                        If padre.InternoExpedienteId > 0 Then
                            EntExpedienteAux.Codigo = padre.InternoExpedienteId
                        End If
                        index = padre.InternoExpedienteId
                    End While
                    If EntExpedienteAux.Codigo > 0 And ent_.Codigo < 1 Then
                        If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                            Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                            Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                            EntExpedienteAux = objBssExp.Listar_LM(EntExpedienteAux).Expediente(0)
                        Else
                            EntExpedienteAux = objBssExp.Listar(EntExpedienteAux).Expediente(0)
                        End If

                        If EntExpedienteAux.LibertadTipoID < 1 Then
                            blnValor = True
                            Exit For
                        End If
                    ElseIf EntExpedienteAux.Codigo = -1 And ent_.LibertadTipoID < 1 Then
                        blnValor = True
                        Exit For
                    ElseIf EntExpedienteAux.Codigo = -1 And Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
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
                Select Case Me._TipoResolucion
                    Case enumTipoDocumentoJudicial.Detencion, enumTipoDocumentoJudicial.DetencionReferenciado, enumTipoDocumentoJudicial.DetencionCarceleta
                        If objEntExpedienteCol Is Nothing Then
                            'blnValor = True
                            objEntExpedienteCol = objEntExpedienteTempoCol
                        Else
                            objEntExpedienteTempoCol = objEntExpedienteCol
                        End If
                End Select
                For Each ent_ As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    EntExpedienteAux = New Entity.Registro.Expediente
                    Dim index As Integer = ent_.Codigo
                    While index > 0
                        objEntExpPadre.InternoExpedienteRefPadreId = index
                        Dim padre As New Entity.Registro.InternoExpedientePadre
                        Select Case Me._TipoLicencia
                            Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                padre = objBssExpedientePad.Listar_LM(objEntExpPadre)
                            Case Else
                                padre = objBssExpedientePad.Listar(objEntExpPadre)
                        End Select

                        If padre.InternoExpedienteId > 0 Then EntExpedienteAux.Codigo = padre.InternoExpedienteId

                        index = padre.InternoExpedienteId
                    End While
                    If EntExpedienteAux.Codigo > 0 Then
                        Select Case Me._TipoLicencia
                            Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                EntExpedienteAux = objBssExp.Listar_LM(EntExpedienteAux).Expediente(0)
                            Case Else
                                EntExpedienteAux = objBssExp.Listar(EntExpedienteAux).Expediente(0)
                        End Select

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
        Public Function ValidarLibertadV2() As Boolean

            blnValorLib = False
            entMov = New Entity.Registro.InternoMovimiento
            entMov.InternoID = Me._InternoID
            entMov.IngresoInpeId = Me._InternoIngresoInpeId
            entMov.IngresoID = Me._InternoIngresoID
            entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
            bssMov = New Bussines.Registro.InternoMovimiento

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                entMov = bssMov.Listar_LM(entMov)
            Else
                entMov = bssMov.Listar(entMov)
            End If

            If entMov.Codigo < 1 Then Exit Function

            Dim intConta As Integer = 0
            Dim intContaLib As Integer = 0
            Dim strMensaje As String = ""
            Dim objEntExpedienteCol_rev As New Entity.Registro.ExpedienteCol
            Dim objExp As New Entity.Registro.Expediente
            objExp.InternoID = Me._InternoID
            objExp.IngresoInpeId = Me._InternoIngresoInpeId
            objExp.IngresoID = Me._InternoIngresoID

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
                        If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                            Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                            Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                            padre = objBssExpedientePad.Listar_LM(objEntExpPadre)
                        Else
                            padre = objBssExpedientePad.Listar(objEntExpPadre)
                        End If

                        If padre.InternoExpedienteId > 0 Then
                            EntExpedienteAux.Codigo = padre.InternoExpedienteId
                        End If
                        index = padre.InternoExpedienteId
                    End While
                    If EntExpedienteAux.Codigo > 0 Then
                        If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                            Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                            Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                            EntExpedienteAux = objBssExp.Listar_LM(EntExpedienteAux).Expediente(0)
                        Else
                            EntExpedienteAux = objBssExp.Listar(EntExpedienteAux).Expediente(0)
                        End If

                        If EntExpedienteAux.LibertadTipoID < 1 Then
                            blnValor = True
                            Exit For
                        End If
                    ElseIf EntExpedienteAux.Codigo = -1 Then
                        blnValor = True
                        Exit For
                    End If
                Next
                If entMov.Codigo > 0 And blnValor = True Then
                    blnCondicionLib = True
                Else
                    blnCondicionLib = False
                End If
            Else
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Then
                    If objEntExpedienteCol Is Nothing Then
                        blnValor = True
                    Else
                        objEntExpedienteTempoCol = objEntExpedienteCol
                    End If

                End If
                For Each ent_ As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                    EntExpedienteAux = New Entity.Registro.Expediente
                    Dim index As Integer = ent_.Codigo
                    While index > 0
                        objEntExpPadre.InternoExpedienteRefPadreId = index
                        Dim padre As New Entity.Registro.InternoExpedientePadre
                        If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                            Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                            Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                            padre = objBssExpedientePad.Listar_LM(objEntExpPadre)
                        Else
                            padre = objBssExpedientePad.Listar(objEntExpPadre)
                        End If

                        If padre.InternoExpedienteId > 0 Then
                            EntExpedienteAux.Codigo = padre.InternoExpedienteId
                        End If
                        index = padre.InternoExpedienteId
                    End While
                    If EntExpedienteAux.Codigo > 0 Then
                        If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                            Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                            Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                            EntExpedienteAux = objBssExp.Listar_LM(EntExpedienteAux).Expediente(0)
                        Else
                            EntExpedienteAux = objBssExp.Listar(EntExpedienteAux).Expediente(0)
                        End If
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
        Private Sub fn_OcultarColumnas()
            If Me._SubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                dgwExpediente.Columns("col_num").Visible = False
            Else
                dgwExpediente.Columns("col_num").ReadOnly = True
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                With dgwExpediente
                    .Columns("col_tip_lib").Visible = True
                    .Columns("col_exp_btn").Visible = True
                End With
            ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda Then
                With dgwExpediente
                    .Columns("col_mot_que").Visible = True
                    .Columns("col_exp_btn").Visible = True
                End With
            ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Or
                    (Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionReferenciado And Me._VisibleControlExpediente = False) Then
                Me.pnlCabExpediente.Visible = False
                Me.dgwExpediente.Visible = False
                Me.SplitContainer2.Panel1Collapsed = True

            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                With dgwExpediente
                    .Columns("col_secre").Visible = False
                    .Columns("col_flag").Visible = False
                    .Columns("col_est_men_des").Visible = True
                    .Columns("col_est_men_des").Width = 190
                    .Columns("col_exp_inmp").Visible = True
                    .Columns("col_exp_inmp").Width = 190
                End With
                Me.pnlExpePermisos.Visible = True
                Me.pnlEscrituraExpe.Visible = True
                Me.pnlDelitoPermisos.Visible = True
                Me.pnlAgravPermisos.Visible = True

                Me.btnInimputable2.Visible = True
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                With dgwExpediente
                    .Columns("col_sal_jud").Width = 160
                    .Columns("col_aut_jud").Width = 90
                    .Columns("col_secre").Visible = False
                    .Columns("col_flag").Visible = False
                    .Columns("col_est_men_des").Visible = True
                    .Columns("col_exp_inmp").Visible = True
                    .Columns("col_exp_conclu").Visible = True
                    .Columns("col_est_men_nue_des").Visible = True
                End With
                Me.pnlExpePermisos.Visible = True
                Me.pnlEscrituraExpe.Visible = True
                Me.pnlDelitoPermisos.Visible = True
                Me.pnlAgravPermisos.Visible = True
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota Then
                With dgwExpediente
                    .Columns("col_secre").Visible = False
                    .Columns("col_flag").Visible = False
                    .Columns("col_est_men_des").Visible = True
                    .Columns("col_est_men_des").Width = 190
                    .Columns("col_exp_inmp").Visible = True
                    .Columns("col_exp_inmp").Width = 190
                    .Columns("col_num").Visible = True

                End With
                Me.pnlExpePermisos.Visible = True
                Me.pnlEscrituraExpe.Visible = True
                Me.pnlDelitoPermisos.Visible = False
                Me.pnlAgravPermisos.Visible = False
            End If
        End Sub

        Private Sub verCamposInimputables(vf As Boolean, idTipoInimputable As Short)

            Me.col_est_men_des.Visible = vf
            Me.col_exp_inmp.Visible = vf
            Me.col_exp_inmp.Width = 190

            If vf = True Then
                Select Case idTipoInimputable
                    Case Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable

                        Me.pnlDuracionCondena.Visible = vf
                        Me.gbDuracioncondena.Text = "Duración de la medida de seguridad"
                        Me.gbComputo.Text = "Cómputo de la medida de seguridad"
                        If Me._TipoResolucion = 70 Then gbExentoInimputable.Visible = False
                    Case Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.PosibleInimputable

                        Me.pnlDuracionCondena.Visible = False
                End Select
            Else
                Me.pnlDuracionCondena.Visible = vf
            End If

        End Sub
        Private Sub mostrarDatosInimputables(idTipoInimputable As Short)

            Dim verBotonImimputable As Boolean = False

            Select Case Me._TipoResolucion

                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Libertad

                    If idTipoInimputable = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable Or
                        idTipoInimputable = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.PosibleInimputable Then
                        verCamposInimputables(True, idTipoInimputable)
                    Else
                        verCamposInimputables(False, idTipoInimputable)
                    End If

                    verBotonImimputable = True

                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital,
                     Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.RetornoTrasladoHospital
                    verCamposInimputables(True, idTipoInimputable)
                    verBotonImimputable = True

            End Select

            Me.btnInimputable.Visible = verBotonImimputable

        End Sub
#End Region
        Sub New()
            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            ValoresxDefault()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        End Sub


        Private Sub btnAddDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnAddDelito.Click
            If Me._DocumentoJudicialID > 1 Then
                If ValidarExpedienteReferenciado(2) = False Then
                    Exit Sub
                End If
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Or Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Or
                (Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionReferenciado And Me._VisibleControlExpediente = False) Then
                If objEntDelitoTempoColGrilla Is Nothing Then
                    objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
                End If
                RaiseEvent _Click_Delito_Agregar(Nothing, objEntDelitoTempoColGrilla)
            Else
                If dgwExpediente.Rows.Count < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe existir al menos un expediente para ingresar un delito.")
                    Exit Sub
                End If
                If objEntDelitoTempoColGrilla Is Nothing Then
                    objEntDelitoTempoColGrilla = New Entity.Registro.DelitoCol
                End If
                RaiseEvent _Click_Delito_Agregar(objEntExpedienteTempoCol.Item(Me.dgwExpediente.SelectedRows(0).Index), objEntDelitoTempoColGrilla)
            End If
            dgwDelitos_CellClick(Nothing, Nothing)

        End Sub
        Private Sub btnDelDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnDelDelito.Click
            If dgwDelito.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un delito para eliminar.")
                Exit Sub
            Else
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No puedes eliminar delitos en un Documento de Orden de Traslado")
                    Exit Sub
                Else
                    Temporal_EliminarExpediente_Delito_Agraviado(False, True, False)
                    dgwExpediente_CellClick(Nothing, Nothing)
                End If
            End If
        End Sub
        Public blnVaorAgr As Boolean = False
        Private Sub btnAddAgrav_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAgrav.Click
            blnVaorAgr = True
            If Me._DocumentoJudicialID > 1 Then
                If ValidarExpedienteReferenciado(3) = False Then
                    Exit Sub
                End If
            End If
            If dgwDelito.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe existir al menos un delito registrado para ingresar un agraviado.")
                Exit Sub
            End If
            RaiseEvent _Click_Agraviado_Agregar(Me.GrillaDelitoSelect)
        End Sub

        Private Sub btnDelAgrav_Click(sender As System.Object, e As System.EventArgs) Handles btnDelAgrav.Click
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No puedes eliminar agraviados en un Documento de Orden de Traslado")
                Exit Sub
            Else
                Temporal_EliminarExpediente_Delito_Agraviado(False, False, True)
                dgwDelitos_CellClick(Nothing, Nothing)
            End If
        End Sub

        Private Sub btnEditDelito_Click(sender As System.Object, e As System.EventArgs) Handles btnEditDelito.Click
            Temporal_Delito_Modificar()
            dgwDelitos_CellClick(Nothing, Nothing)
        End Sub

        Private Sub btnEditAgrav_Click(sender As System.Object, e As System.EventArgs) Handles btnEditAgrav.Click

            Temporal_Modificar_Agraviado()

        End Sub

        Private Sub btnAddExp_Click(sender As System.Object, e As System.EventArgs) Handles btnAddExp.Click
            If ValidarExpedienteReferenciado(1) = False Then
                Exit Sub
            End If
            Select Case Me._TipoResolucion
                Case enumTipoDocumentoJudicial.Revocatoria_de_Libertad, enumTipoDocumentoJudicial.Queda
                Case Else
                    If dgwExpediente.RowCount > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo puede registrar un proceso. Si hay otro documento de internamiento registrar de manera independiente.")
                        Exit Sub
                    End If
            End Select
            Me.Nuevo = True
            RaiseEvent _Click_Expediente_Agregar()
        End Sub
        Private Sub btnEditExpe_Click(sender As System.Object, e As System.EventArgs) Handles btnEditExpe.Click
            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un expediente para modificar.")
                Exit Sub
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                ExpAvocamientoAux.Codigo = CodigoMayor
                RaiseEvent _Click_Expediente_Editar(ExpAvocamientoAux)
            Else
                RaiseEvent _Click_Expediente_Editar(Me.objEntExpedienteTempoCol.Item(Me.dgwExpediente.SelectedRows(0).Index))
            End If
        End Sub

        Private Sub btnDelExp_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarExp.Click

            If dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un expediente para eliminar.")
                Exit Sub
            End If

            Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)

            RaiseEvent _Click_Inimputable(Me._getEsInimputable)

        End Sub

        Private Sub dgwDelitos_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            btnEditDelito.PerformClick()
        End Sub
        Private blnValorDel As Boolean = False
        Private blnValorExp As Boolean = False
        Private Sub dgwDelitos_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            If blnValorDel = False Then
                If Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion And Me._TipoResolucion <> enumTipoDocumentoJudicial.DetencionCarceleta Then
                    If dgwDelito.Rows.Count < 1 Then
                        dgwAgraviados.DataSource = Nothing
                        Exit Sub
                    End If
                End If
                If dgwDelito.Rows.Count > 0 Then
                    If Me._SubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                        Temporal_ListarAgraviados()
                    Else
                        Temporal_ListarAgraviados()
                    End If
                End If
            Else
                Temporal_ListarAgraviados()
                blnValorDel = False
            End If
        End Sub

        Private Sub uscExpeDeResolucion_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            If Me._TipoResolucion = enumTipoDocumentoJudicial.Detencion Or
                Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionReferenciado Or
                Me._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta Then

                Me.pnlCabExpediente.Visible = False
                Me.dgwExpediente.Visible = False
            End If

            'ocultar los controles de accion, cuando la licencia sea plm
            Select Case Config.Licencia.LicenciaTipo
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    If Me._TipoResolucion = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital Then
                        Me.pnlExpePermisos.Visible = True
                        Me.pnlDelitoPermisos.Visible = True
                        Me.pnlAgravPermisos.Visible = True
                    Else
                        Me.pnlExpePermisos.Visible = False
                        Me.pnlDelitoPermisos.Visible = False
                        Me.pnlAgravPermisos.Visible = False
                    End If
            End Select

            Me.dgwExpediente.Columns("col_exp_ref").ReadOnly = True
            Me.dgwExpediente.VisibleCampos = False
            Me.dgwAgraviados.VisibleCampos = False
            Me.dgwExpediente.Columns("col_flag").ReadOnly = True
            Me.btnInimputable2.Visible = False

        End Sub

        Dim bolEdicionActivo As Boolean = False


        Private Sub dgwExpediente_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyDown

            If e.KeyCode = Keys.Delete Then
                If dgwExpediente.Rows.Count = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Lista vacia para eliminar expedientes.")
                    Exit Sub
                End If
                Temporal_EliminarExpediente_Delito_Agraviado(True, False, False)
            End If
        End Sub

        Private Sub dgwDelito_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwDelito.KeyDown
            If e.KeyCode = Keys.Delete Then

                e.Handled = True
                If dgwDelito.Rows.Count = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Lista vacia para eliminar delito.")
                    Exit Sub
                Else
                    Temporal_EliminarExpediente_Delito_Agraviado(False, True, False)
                    dgwExpediente_CellClick(Nothing, Nothing)
                End If
            End If
        End Sub

        Private Sub dgwAgraviados_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwDelito.KeyDown

            If e.KeyCode = Keys.Delete Then
                e.Handled = True
                Temporal_EliminarExpediente_Delito_Agraviado(False, False, True)
                dgwDelitos_CellClick(Nothing, Nothing)
            End If

        End Sub

        Private Sub dgwExpediente_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwExpediente.KeyUp
            If dgwExpediente.Rows.Count > 0 Then
                Temporal_ListarDelitos(Me.GrillaExpedienteSelect)
            End If
        End Sub

        Private Sub dgwDelito_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellClick

            Temporal_ListarAgraviados()

        End Sub

        Private Sub dgwDelito_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDelito.CellDoubleClick

            btnEditDelito_Click(sender, e)

        End Sub

        Private Sub dgwAgraviados_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwAgraviados.CellContentClick

        End Sub

        Private Sub dgwExpediente_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellClick
            If dgwExpediente.Rows.Count > 0 Then

                If blnValorExp = False Then
                    If Me._SubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                        Temporal_ListarDelitos(IIf((Me.GrillaExpedienteSelect).ExpedienteItem < 1, objEntExpediente_copi, Me.GrillaExpedienteSelect)) ' )
                    Else
                        Temporal_ListarDelitos(Me.GrillaExpedienteSelect)
                    End If
                Else
                    Temporal_ListarDelitos(objEntExpedienteTempoCol.Expediente(0))
                    blnValorExp = False
                End If

            End If
        End Sub
        Private Sub dgwExpediente_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellContentClick
            'dgwExpediente_CellClick(Nothing, Nothing)
            If e.RowIndex = -1 Then Exit Sub
            If dgwExpediente.Columns(e.ColumnIndex).Name = "col_exp_btn" Then
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                    RaiseEvent _click_VerLibertades()
                ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda Then
                    RaiseEvent _click_VerMotivoQueda()
                End If
            End If
        End Sub


        Private Sub dgwExpediente_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellDoubleClick
            Dim columnIndex As Integer = e.ColumnIndex
            ' Obtenemos el nombre de la columna
            ' correspondiente a la celda
            '
            Dim columnName As String = dgwExpediente.Columns.Item(columnIndex).Name
            If columnName = "col_tip_lib" Then
            Else
                btnEditExpe_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub dgwAgraviados_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwAgraviados.CellDoubleClick
            If dgwAgraviados.Rows.Count < 1 Then Exit Sub

            If btnEditAgrav.Enabled = True Then
                btnEditAgrav_Click(Nothing, Nothing)
            End If
        End Sub


        Private Sub dgwDelito_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwDelito.KeyUp
            If Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion And Me._TipoResolucion <> enumTipoDocumentoJudicial.DetencionCarceleta Then
                If dgwDelito.Rows.Count < 1 Then
                    dgwAgraviados.DataSource = Nothing
                    Exit Sub
                End If
            End If
            If dgwDelito.Rows.Count > 0 Then
                Temporal_ListarAgraviados()
            End If
        End Sub

        Private Sub dgwDelito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDelito.CellContentClick

        End Sub

        Private Sub pnlExpePermisos_Paint(sender As Object, e As PaintEventArgs) Handles pnlExpePermisos.Paint

        End Sub

        Private Sub btnInimputable2_Click(sender As Object, e As EventArgs) Handles btnInimputable2.Click

            If Me.dgwExpediente.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha encontrado ningún registro para agregar los datos")
                Exit Sub
            End If

            Dim idTipoInimputable As Short = Me.grillaIdTipoInimputable
            Dim idCentroSaludMental As Short = Me.grillaIdCentroSalud

            FrmAgregarInimputable(idTipoInimputable, idCentroSaludMental)

        End Sub

        Private Sub btnAddPerCond_Click(sender As Object, e As EventArgs) Handles btnAddPerCond.Click

            If intReferenciado > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede agregar periodo de condena, porque el expediente esta referenciado")
                Exit Sub
            End If

            RaiseEvent _Click_PeriodoCondena_Agregar()
        End Sub

        Private Sub btnEditPerCond_Click(sender As Object, e As EventArgs) Handles btnEditPerCond.Click


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

        Private Sub btnDelPerCond_Click(sender As Object, e As EventArgs) Handles btnDelPerCond.Click

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
                        listarGrillaPeriodoCondena()
                        Exit For
                    End If
                Next
            End If

        End Sub

        Private Sub rbTemporal_CheckedChanged(sender As Object, e As EventArgs) Handles rbTemporal.CheckedChanged, rbCadenaperpetua.CheckedChanged

            Dim blnValor As Boolean = rbTemporal.Checked
            If rbTemporal.Checked = True Then
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

            Dim idTipoInimputable As Short = Me.grillaIdTipoInimputable
            Dim idCentroSaludMental As Short = Me.grillaIdCentroSalud

            FrmAgregarInimputable(idTipoInimputable, idCentroSaludMental)
        End Sub

        Private Sub rbInternacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbInternacion.CheckedChanged

        End Sub

        Private Sub rbTratamientoAmbulatorio_CheckedChanged(sender As Object, e As EventArgs) Handles rbTratamientoAmbulatorio.CheckedChanged
            If Me._TipoResolucion = 70 Then Exit Sub
            If rbTratamientoAmbulatorio.Checked = True Then
                btnInimputable.Enabled = False
                gbDuracioncondena.Enabled = False
                gbComputo.Enabled = False
                txtAnios.Text = 0
                txtMeses.Text = 0
                txtDias.Text = 0
                dtpFechaInicio.ValueLong = 0
                dtpFechaFinal.ValueLong = 0
            Else
                gbDuracioncondena.Enabled = True
                gbComputo.Enabled = True
                btnInimputable.Enabled = True
            End If
        End Sub
    End Class
End Namespace