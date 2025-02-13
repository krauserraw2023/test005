Option Explicit On
Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion
Imports Type.Enumeracion.Licencia

Namespace Registro.Expediente.v5
    Public Class frmListaExpedientePopup
        Private objBss As Bussines.Registro.Expediente = Nothing
        Private objBssPad As Bussines.Registro.InternoExpedientePadre = Nothing
        Private objEnt As Entity.Registro.Expediente = Nothing
        Private objEntExpediente As Entity.Registro.Expediente
        Private objBssDelito As Bussines.Registro.Delito = Nothing
        Public objEntDelitoTempoCol As Entity.Registro.DelitoCol = Nothing
        Public objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol = Nothing
        Private objBssAgraviado As Bussines.Registro.InternoAgraviado = Nothing
        Private objEntPerCon As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing
        Private objEntPeriodoCondenaTempoCol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
        Private objEntDelitoCol As Entity.Registro.DelitoCol
        Private objEntAgraviadoCol As Entity.Registro.AgraviadoCol

        Dim ExpedienteTemporalCol As New Entity.Registro.ExpedienteCol

#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1

        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _IngresoID As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _TemporalNuevo As Boolean = False
        Public Property _NuevoExpediente As Boolean = False
        Public Property _SituacionJuridicaExpe As Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
        Public Property _TipoResolucion As Integer = -1
        Public Property _FechaRecep As Long = 0
        Public ReadOnly Property _EntExpediente() As Entity.Registro.Expediente
            Get
                Dim tmp As Entity.Registro.Expediente
                Try
                    tmp = objEntExpedienteTempoCol.Item(dgwExpediente.CurrentCell.RowIndex)
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return tmp
            End Get
        End Property
        Public ReadOnly Property _GrillaExpedienteIdSeleccionado() As Integer
            Get

                Return Me.GrillaExpedienteId

            End Get
        End Property
        Private ReadOnly Property GrillaExpedienteId() As Integer
            Get
                Try
                    Return dgwExpediente.SelectedRows(0).Cells("codigo").Value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Public Property _MotivoIngreso As Integer = -1
#End Region
#Region "Variables_Temporales"
        Public objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol = Nothing
        Public objEntExpedienteTempoColCopi As Entity.Registro.ExpedienteCol = Nothing
        Public objEntExpedienteTempoColCopi2 As New Entity.Registro.ExpedienteCol

#End Region
#Region "Propiedades_Publicas"
        Private blnVisibleGrabar As Boolean = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
                ShowControl()
            End Set
        End Property
        Public Property _GrillaSeleccionMultiple As Boolean = True
        Public Event _Click_EnviarColection(EntExpCol As Entity.Registro.ExpedienteCol)
#End Region
#Region "Propiedades_Expediente"
        Public Property _TipoAutJudicial() As Integer = -1
        Public Property DocJudicialID As Integer = -1
#End Region

#Region "Listar"
        Public Sub _ListarExpediente(__DocJudicialId As Integer, Optional ByVal CargarMandDetencionHistorico As Boolean = True, Optional ByVal CargarMandDetencionSoloProcesados As Boolean = False)

            Select Case Me._TipoResolucion

                Case enumTipoDocumentoJudicial.Refundicion_de_Sentencia, enumTipoDocumentoJudicial.Sumatoria_de_Sentencia,
                     enumTipoDocumentoJudicial.AcumulacionExpedientes, enumTipoDocumentoJudicial.Revocatoria_de_Libertad,
                      enumTipoDocumentoJudicial.Queda, enumTipoDocumentoJudicial.Libertad,
                     enumTipoDocumentoJudicial.Anulacion_Antecedentes
                    dgwExpediente.Columns("colu_eleg").HeaderText = ""
                    Me.ckbSeleccionar.Visible = True

                Case Else
                    dgwExpediente.Columns("colu_eleg").Visible = False
            End Select

            Select Case Me._TipoResolucion
                Case enumTipoDocumentoJudicial.Libertad, enumTipoDocumentoJudicial.Revocatoria_de_Libertad, enumTipoDocumentoJudicial.Queda,
                      enumTipoDocumentoJudicial.Anulacion_Antecedentes, enumTipoDocumentoJudicial.Notas,
                      enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental,
                      enumTipoDocumentoJudicial.Retorno_de_HospitalMental,
                     enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota

                    Me._SituacionJuridicaExpe = -1
            End Select

            objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
            objEntExpediente = New Entity.Registro.Expediente

            With objEntExpediente
                .IngresoInpeId = Me._InternoIngresoInpeId
                .IngresoID = Me._IngresoID
                .InternoID = Me._InternoID
                .SituacionJuridicaID = Me._SituacionJuridicaExpe

                '---Listar todos los expedientes
                If Me._TipoResolucion = enumTipoDocumentoJudicial.Libertad Or Me._TipoResolucion = enumTipoDocumentoJudicial.Queda Then

                    .Anulacion = enmEstadoAnulado.Anulado_parcial
                    .DocumentoTipoID = enumTipoDocumentoJudicial.Libertad

                    Select Case Me._TipoLicencia

                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                            objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaPopup_LM(objEntExpediente)

                        Case Else
                            objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaPopup(objEntExpediente)
                    End Select

                ElseIf Me._TipoResolucion = enumTipoDocumentoJudicial.Revocatoria_de_Libertad Then
                    Select Case Me._TipoLicencia
                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                            objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaRevocatoria_LM(objEntExpediente)
                        Case Else
                            objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaRevocatoria(objEntExpediente)
                    End Select
                ElseIf Me._TipoResolucion = enumTipoDocumentoJudicial.ResolucionDeclaraConsentida Then
                    Select Case Me._TipoLicencia
                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                        Case Else
                    End Select
                    objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaSentenciasNoConsentidas(objEntExpediente)
                Else

                    If Me._TipoResolucion = enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                        dgwExpediente.Columns("col_nro_ing").Visible = True
                        objEntExpediente.IngresoID = -1
                        objEntExpediente.IngresoInpeId = -1
                    End If

                    objEntExpediente.Anulacion = enmEstadoAnulado.Anulado_parcial

                    Select Case Me._TipoLicencia

                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                            objEntExpediente.IngresoNro = (New Bussines.Registro.IngresoInpe).Listar(Me._InternoIngresoInpeId).IngresoNro

                            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then

                                objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaInimputables(objEntExpediente)

                            Else
                                Select Case _TipoResolucion
                                    Case 10, 9, 28
                                        objEntExpediente.DocumentoTipoCategoria = -1
                                    Case 17, 9, 10, 11, 28, 73
                                        objEntExpediente.DocumentoTipoCategoria = 1
                                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria
                                        objEntExpediente.SituacionJuridicaID = -1
                                        objEntExpediente.DocumentoTipoCategoria = 2
                                    Case 21, 22
                                        objEntExpediente.SituacionJuridicaID = 1
                                    Case 23, 24, 25
                                        objEntExpediente.SituacionJuridicaID = 2
                                        objEntExpediente.DocumentoTipoCategoria = 2
                                    Case 20, 32
                                        objEntExpediente.SituacionJuridicaID = -1
                                        objEntExpediente.DocumentoTipoCategoria = 2
                                    Case 31, 13, 34, 71, 15
                                        objEntExpediente.SituacionJuridicaID = -1
                                        objEntExpediente.DocumentoTipoCategoria = -1
                                    Case 70
                                        .DocumentoTipoID = enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
                                End Select
                                Select Case _TipoResolucion' 
                                    Case = 14
                                        Select Case Me._MotivoIngreso
                                            Case 122
                                                objEntExpediente.SituacionJuridicaID = -1
                                                objEntExpediente.MotivoIngresoID = Me._MotivoIngreso
                                                objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarOtrosprocesos(objEntExpediente)

                                            Case 116, 117, 120, 189, 197
                                                objEntExpediente.SituacionJuridicaID = -1
                                                objEntExpediente.IngresoID = -1
                                                objEntExpediente.IngresoInpeId = -1
                                                objEntExpediente.MotivoIngresoID = Me._MotivoIngreso
                                                objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarOtrosprocesosRevocatorias(objEntExpediente)
                                            Case Else
                                                objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaPopup_LM_v2(objEntExpediente)
                                        End Select

                                    Case Else
                                        objEntExpediente.Extramuro = IIf(Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes, 1, -1)
                                        objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaPopup_LM_v2(objEntExpediente)
                                End Select
                            End If

                        Case Else

                            objEntExpediente.IngresoNro = (New Bussines.Registro.Ingreso).Listar(Me._IngresoID).IngresoNro

                            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                                objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaInimputables(objEntExpediente)
                            ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                                'TRASLADO A HOSPITAL MENTAL
                                .DocumentoTipoID = enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
                                objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaPopup(objEntExpediente)
                            ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota Then
                                ' NUEVO INTENTO DE ENVIO A HOSP MENT   e.cu.cco.
                                objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaPopup_Nuevo_OTHM(objEntExpediente)
                            Else
                                Select Case _TipoResolucion
                                    Case 10, 9, 28
                                        objEntExpediente.DocumentoTipoCategoria = -1
                                    Case 17, 9, 10, 11, 28, 73
                                        objEntExpediente.DocumentoTipoCategoria = 1
                                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria
                                        objEntExpediente.SituacionJuridicaID = -1
                                        objEntExpediente.DocumentoTipoCategoria = 2
                                    Case 21, 22
                                        objEntExpediente.SituacionJuridicaID = 1
                                    Case 23, 24, 25
                                        objEntExpediente.SituacionJuridicaID = 2
                                        objEntExpediente.DocumentoTipoCategoria = 2
                                    Case 20, 32
                                        objEntExpediente.SituacionJuridicaID = -1
                                        objEntExpediente.DocumentoTipoCategoria = 2
                                    Case 31, 13, 34, 71, 15
                                        objEntExpediente.SituacionJuridicaID = -1
                                        objEntExpediente.DocumentoTipoCategoria = -1
                                End Select

                                Select Case _TipoResolucion' 
                                    Case = 14
                                        Select Case Me._MotivoIngreso
                                            Case 122
                                                objEntExpediente.SituacionJuridicaID = -1
                                                objEntExpediente.MotivoIngresoID = Me._MotivoIngreso
                                                objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarOtrosprocesos(objEntExpediente)

                                            Case 116, 117, 120, 189, 197
                                                objEntExpediente.SituacionJuridicaID = -1
                                                objEntExpediente.IngresoID = -1
                                                objEntExpediente.IngresoInpeId = -1
                                                objEntExpediente.MotivoIngresoID = Me._MotivoIngreso
                                                objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarOtrosprocesosRevocatorias(objEntExpediente)
                                            Case Else
                                                objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaPopup(objEntExpediente)
                                        End Select

                                    Case Else
                                        objEntExpedienteTempoCol = (New Bussines.Registro.Expediente).ListarGrillaPopup(objEntExpediente)
                                End Select
                                If _TipoResolucion = 17 Then
                                    Dim expCol As New Entity.Registro.ExpedienteCol
                                    For Each exp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                                        If exp.DocumentoTipoID <> 17 Then
                                            expCol.Add(exp)
                                        End If
                                    Next
                                    objEntExpedienteTempoCol = expCol
                                End If
                            End If
                    End Select

                    If Me._TipoResolucion = enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                        Dim objEntExpedienteAuxTempoCol As New Entity.Registro.ExpedienteCol

                        For Each objexp As Entity.Registro.Expediente In objEntExpedienteTempoCol

                            If objexp.IngresoNro <= objEntExpediente.IngresoNro Then
                                objEntExpedienteAuxTempoCol.Add(objexp)
                            End If

                        Next

                        objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
                        objEntExpedienteTempoCol = objEntExpedienteAuxTempoCol
                    End If
                End If

            End With

            If Me._TipoResolucion = enumTipoDocumentoJudicial.Libertad Or
               Me._TipoResolucion = enumTipoDocumentoJudicial.Queda Then
                Dim objEntExpedienteTempoCol_Cop As New Entity.Registro.ExpedienteCol
                For Each EntLib As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    If EntLib.LibertadTipoID > 0 Then
                        If EntLib.FechaLibertad > 0 Then
                        Else
                            objEntExpedienteTempoCol_Cop.Add(EntLib)
                        End If
                    Else
                        objEntExpedienteTempoCol_Cop.Add(EntLib)
                    End If
                Next
                objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
                objEntExpedienteTempoCol = objEntExpedienteTempoCol_Cop
            End If

            If objEntExpedienteTempoCol Is Nothing Or objEntExpedienteTempoCol.Count = 0 Then
                Me._NuevoExpediente = True
                Me.DialogResult = Windows.Forms.DialogResult.OK
                'If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionDeclaraConsentida Then
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con Sentencias no Consentidas.")
                'End If
                Me.Close()

            Else
                Me.DocJudicialID = __DocJudicialId
                Temporal_ListarExpediente()
            End If
        End Sub

        Private Sub Temporal_ListarExpediente()
            With Me.dgwExpediente
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = IIf(objEntExpedienteTempoCol.Item(0) Is Nothing, Nothing, objEntExpedienteTempoCol)
                .Refresh()
                lblNroExpedientes.Text = "Expedientes " & .Rows.Count & " Reg."
            End With
        End Sub

        Private Sub TemporalCopiarPropiedades(obj As Entity.Registro.Expediente, ObjEntDestino As Entity.Registro.Expediente)
            With obj
                .Codigo = ObjEntDestino.Codigo
                .InternoID = ObjEntDestino.InternoID
                .IngresoInpeId = ObjEntDestino.IngresoInpeId
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
            End With
        End Sub
        Private Sub ListarDelitosAgraviados()
            Me.Cursor = Cursors.WaitCursor

            objEntDelitoTempoCol = New Entity.Registro.DelitoCol
            objBssDelito = New Bussines.Registro.Delito
            objEntAgraviadoTempoCol = New Entity.Registro.AgraviadoCol
            objBssAgraviado = New Bussines.Registro.InternoAgraviado

            objEntExpedienteTempoColCopi = New Entity.Registro.ExpedienteCol
            Dim objDelito As Entity.Registro.Delito

            For Each objExp As Entity.Registro.Expediente In objEntExpedienteTempoCol
                If objExp.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Or
                    objExp.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                    objExp.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Then
                    objBss = New Bussines.Registro.Expediente
                    Select Case Me._TipoLicencia
                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                            objEntExpedienteTempoColCopi = objBss.ListarExpedientexResolucion_LM(objExp.CreaDocJudicialId)
                        Case Else
                            objEntExpedienteTempoColCopi = objBss.ListarExpedientexResolucion(objExp.CreaDocJudicialId)
                    End Select
                    For Each objE As Entity.Registro.Expediente In objEntExpedienteTempoColCopi 'objEntExpedienteTempoCol_copi
                        objEntDelitoCol = New Entity.Registro.DelitoCol
                        objDelito = New Entity.Registro.Delito
                        objDelito.Codigo = -1
                        objDelito.IngresoID = objE.IngresoID
                        objDelito.IngresoInpeId = objE.IngresoInpeId
                        objDelito.InternoID = objE.InternoID
                        objDelito.ExpedienteID = objE.Codigo
                        Select Case Me._TipoLicencia
                            Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                objEntDelitoCol = objBssDelito.Listar2_LM(objDelito)
                            Case Else
                                objEntDelitoCol = objBssDelito.Listar2(objDelito)
                        End Select
                        objEntExpediente = objE
                        Dim objEntDelito_copi As New Entity.Registro.Delito
                        Dim objEntAgraviado_copi As New Entity.Registro.Agraviado

                        For Each objDel As Entity.Registro.Delito In objEntDelitoCol
                            Dim Valor As Integer = 0
                            For Each objEntDel As Entity.Registro.Delito In objEntDelitoTempoCol
                                If objDel.DelitoEspecifico = objEntDel.DelitoEspecifico Then
                                    objEntDelito_copi = objEntDel
                                    Valor = 1
                                    Exit For
                                End If
                            Next
                            Dim codExpHis As Integer = -1
                            If Valor = 0 Then
                                objDel.strCodigodelitoPad = objDel.Codigo
                                objEntDelitoTempoCol.Add(objDel)
                            ElseIf Valor = 1 Then
                                For Each ob As Entity.Registro.Delito In objEntDelitoTempoCol
                                    If objDel.DelitoEspecifico = ob.DelitoEspecifico Then
                                        Dim str As String = ob.strCodigodelitoPad
                                        str = str & "," & objDel.Codigo.ToString
                                        ob.strCodigodelitoPad = str
                                    End If
                                Next
                                codExpHis = objEntDelito_copi.ExpedienteID
                            End If
                            objDel.DelitoAuxiliar = False

                            objEntAgraviadoCol = New Entity.Registro.AgraviadoCol
                            Dim objEnt As New Entity.Registro.Agraviado
                            With objEnt
                                .Codigo = -1
                                .DelitoID = objDel.Codigo
                                .InternoID = Me._InternoID
                                .IngresoID = Me._IngresoID
                                .IngresoInpeId = Me._InternoIngresoInpeId
                                .ExpedienteID = objDel.ExpedienteID
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
                                If Valor > 0 Then
                                    objEntAgraviado.ExpedienteID = codExpHis
                                    objEntAgraviado.DelitoID = objEntDelito_copi.Codigo
                                End If
                                Dim intInd2 As Integer = 0
                                Dim valor2 As Integer = 0
                                For Each objEntAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol 'objEntAgraviadoCol_copi
                                    intInd2 = intInd2 + 1
                                    Dim ent1 As New Entity.Registro.Delito
                                    Dim ent2 As New Entity.Registro.Delito
                                    ent1 = objBssDelito.Listar(objEntAgraviado.DelitoID)
                                    ent2 = objBssDelito.Listar(objEntAgr.DelitoID)
                                    If objEntAgraviado.AgraviadoNombre = objEntAgr.AgraviadoNombre And
                                        ent1.DelitoEspecifico = ent2.DelitoEspecifico Then
                                        objEntAgraviado_copi = objEntAgr
                                        valor2 = 1
                                        Exit For
                                    End If
                                Next
                                If valor2 = 0 Then
                                    objEntAgraviadoTempoCol.Add(objEntAgraviado)
                                End If
                            Next
                        Next
                    Next
                Else
                    objEntDelitoCol = New Entity.Registro.DelitoCol
                    objDelito = New Entity.Registro.Delito
                    objDelito.Codigo = -1
                    objDelito.IngresoID = objExp.IngresoID
                    objDelito.IngresoInpeId = objExp.IngresoInpeId
                    objDelito.InternoID = objExp.InternoID
                    objDelito.ExpedienteID = objExp.Codigo
                    objDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                    If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                        Select Case Me._TipoLicencia
                            Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                objEntDelitoCol = objBssDelito.Listar2_LM(objDelito)
                            Case Else
                                objEntDelitoCol = objBssDelito.Listar2(objDelito)
                        End Select
                        objEntExpediente = objExp
                        For Each objDel As Entity.Registro.Delito In objEntDelitoCol
                            objDel.DelitoAuxiliar = False
                            objEntDelitoTempoCol.Add(objDel)
                            objEntAgraviadoCol = New Entity.Registro.AgraviadoCol
                            Dim objEnt As New Entity.Registro.Agraviado
                            With objEnt
                                .Codigo = -1
                                .DelitoID = objDel.Codigo
                                .InternoID = Me._InternoID
                                .IngresoID = objExp.IngresoID
                                .IngresoInpeId = Me._InternoIngresoInpeId
                                .ExpedienteID = objDel.ExpedienteID
                                .TipoSentenciaId = -1
                                .AgraviadoNombre = ""
                            End With
                            objEnt.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                            If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                                objEntAgraviadoCol = objBssAgraviado.Listar_LM(objEnt)
                            Else
                                objEntAgraviadoCol = objBssAgraviado.Listar(objEnt)
                            End If

                            For Each objEntAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                                objEntAgraviadoTempoCol.Add(objEntAgraviado)
                            Next
                        Next
                    Else
                        Select Case Me._TipoLicencia
                            Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                objEntDelitoCol = objBssDelito.Listar2_LM(objDelito)
                            Case Else
                                objEntDelitoCol = objBssDelito.Listar2(objDelito)
                        End Select
                        objEntExpediente = objExp
                        For Each objDel As Entity.Registro.Delito In objEntDelitoCol
                            objDel.DelitoAuxiliar = False
                            objEntDelitoTempoCol.Add(objDel)
                            objEntAgraviadoCol = New Entity.Registro.AgraviadoCol
                            Dim objAgrEnt As New Entity.Registro.Agraviado
                            With objAgrEnt
                                .Codigo = -1
                                .DelitoID = objDel.Codigo
                                .InternoID = Me._InternoID
                                .IngresoID = objDel.IngresoID '' Me._IngresoID
                                .IngresoInpeId = Me._InternoIngresoInpeId
                                .ExpedienteID = objDel.ExpedienteID
                                .TipoSentenciaId = -1
                                .AgraviadoNombre = ""
                                .Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                            End With
                            Select Case Me._TipoLicencia
                                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                                    objEntAgraviadoCol = objBssAgraviado.Listar_LM(objAgrEnt)
                                Case Else
                                    objEntAgraviadoCol = objBssAgraviado.Listar(objAgrEnt)
                            End Select
                            For Each objEntAgraviado As Entity.Registro.Agraviado In objEntAgraviadoCol
                                objEntAgraviadoTempoCol.Add(objEntAgraviado)
                            Next
                        Next
                    End If
                End If
            Next
            ''------------Insertar delitos agraviados todos y los no mencionados para anulacion-------------------------------
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                Dim objDelitoAuxCol As New Entity.Registro.DelitoCol
                Dim objPad As New Entity.Registro.InternoExpedientePadre
                Dim objPadCol As New Entity.Registro.InternoExpedientePadreCol
                objBssPad = New Bussines.Registro.InternoExpedientePadre
                objPad.InternoID = Me._InternoID
                objPadCol = objBssPad.ListarGrilla_LM(objPad)
                Dim IngresoInpeId As Integer = -1
                Dim objDelitoAuxiliarIndCol As New Entity.Registro.DelitoCol
                For Each objE As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objDelito = New Entity.Registro.Delito
                    objDelito.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                    objDelito.IngresoID = objE.IngresoID
                    objDelito.IngresoInpeId = objE.IngresoInpeId
                    objDelito.InternoID = objE.InternoID
                    Select Case Me._TipoLicencia
                        Case enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.Carceleta
                            If IngresoInpeId < 1 Then
                                IngresoInpeId = objE.IngresoInpeId
                                objDelitoAuxCol = objBssDelito.Listar_ant2_LM(objDelito)
                            Else
                                If IngresoInpeId <> objE.IngresoInpeId And IngresoInpeId > 0 Then
                                    objDelitoAuxCol = objBssDelito.Listar_ant2_LM(objDelito)
                                End If
                            End If
                        Case Else
                            objDelitoAuxCol = objBssDelito.Listar_ant2(objDelito)
                    End Select
                    For Each obj As Entity.Registro.Delito In objDelitoAuxCol  'objEntDelitoCol '
                        If objE.Codigo = obj.ExpedienteID Then
                            Dim bln As Boolean = True
                            Dim objD2 As New Entity.Registro.Delito
                            For Each objD1 As Entity.Registro.Delito In objEntDelitoTempoCol 'objEntDelitoCol
                                If objD1.Codigo = obj.Codigo Then
                                    bln = True
                                    Exit For
                                Else
                                    objD2 = objD1
                                    bln = False
                                End If
                            Next
                            If bln = False Then
                                objEntDelitoTempoCol.Add(objD2)
                            Else
                                objDelitoAuxiliarIndCol.Add(obj)
                            End If
                        Else
                            Dim bln As Boolean = False
                            Dim ExpAuxId As Integer = objE.Codigo
                            While ExpAuxId > 0
                                If ExpAuxId = obj.ExpedienteID Then
                                    For Each objD1 As Entity.Registro.Delito In objDelitoAuxiliarIndCol
                                        If objD1.CodigodelitoPad = obj.Codigo Then
                                            ExpAuxId = -1
                                            If objD1.DelitoEspecifico = obj.DelitoEspecifico Then
                                                bln = True
                                            End If
                                            Exit For
                                        End If
                                    Next
                                    If bln = False Then
                                        For Each objD1 As Entity.Registro.Delito In objEntDelitoTempoCol
                                            If obj.Codigo = objD1.Codigo Then
                                                bln = True
                                                ExpAuxId = -1
                                                Exit For
                                            End If
                                            If obj.DelitoEspecifico = objD1.DelitoEspecifico And obj.CodigodelitoPad > -1 Then
                                                bln = True
                                                ExpAuxId = -1
                                                Exit For
                                            End If
                                            If obj.DelitoEspecifico = objD1.DelitoEspecifico And obj.Codigo = objD1.CodigodelitoPad Then
                                                bln = True
                                                ExpAuxId = -1
                                                Exit For
                                            End If
                                        Next
                                        If bln = False Then ExpAuxId = -1
                                    End If
                                Else
                                    ExpAuxId = ObtenerExpedientePadreId(ExpAuxId, objPadCol)
                                    If ExpAuxId = -1 Then bln = True
                                End If
                            End While

                            If bln = False Then
                                objEntDelitoTempoCol.Add(fn_CargarDelitoHistorico(objE.Codigo, obj))
                            End If

                            objDelitoAuxiliarIndCol.Add(obj)
                        End If
                    Next

                    Dim objAgraviadoAuxiliarIndCol As New Entity.Registro.DelitoCol
                    Dim objAgraviadoTemporal2 As New Entity.Registro.AgraviadoCol
                    objAgraviadoTemporal2 = objEntAgraviadoTempoCol
                    Dim blnA As Boolean = True
                    For Each objAux As Entity.Registro.Delito In objDelitoAuxCol
                        For Each objA As Entity.Registro.Agraviado In objAgraviadoTemporal2
                            If objAux.AgraviadoId = objA.Codigo Then
                                blnA = True
                                Exit For
                            Else
                                blnA = False
                            End If
                        Next
                        If blnA = False Then
                            Dim ExpAuxId As Integer = objE.Codigo
                            While ExpAuxId > 0
                                If ExpAuxId = objAux.ExpedienteID Then
                                    Dim blnAux As Boolean = False
                                    Dim blnB As Boolean = True
                                    For Each objA As Entity.Registro.Delito In objAgraviadoAuxiliarIndCol
                                        If objAux.Codigo = objA.CodigodelitoPad Then
                                            If objAux.AgraviadoNombre = objA.AgraviadoNombre Then
                                                If objAux.DelitoEspecifico = objA.DelitoEspecifico Then
                                                    blnA = True
                                                    blnB = True
                                                    blnAux = False
                                                Else
                                                    If objAux.AgraviadoPadre = -1 And objAux.AgraviadoId = objA.AgraviadoPadre Then
                                                        blnB = False
                                                    End If
                                                End If
                                                Exit For
                                            Else
                                                blnA = False
                                                blnB = False
                                                'Exit For
                                            End If
                                        Else
                                            blnA = True
                                            blnB = False
                                        End If
                                    Next
                                    If blnA = False Then
                                        If blnB = False Then
                                            'Obtener el ultimo Delito hijo --------
                                            Dim CodigoDelitoHijoId As Integer = ObtenerUltimoDelitoHijo(objAux, objAgraviadoAuxiliarIndCol)
                                            If CodigoDelitoHijoId > 0 Then
                                                objEntAgraviadoTempoCol.Add(Cargar_AgraviadoTemporalCol(objAux, CodigoDelitoHijoId, objE))
                                            End If
                                        End If
                                        objAgraviadoAuxiliarIndCol.Add(objAux)
                                        ExpAuxId = -1
                                    Else
                                        If blnB = False Then
                                            For Each A As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                                                If A.AgraviadoNombre = objAux.AgraviadoNombre And A.DelitoEspecificoID = objAux.DelitoEspecifico Then
                                                    blnB = True
                                                    Exit For
                                                End If
                                            Next
                                            If blnB = False Then
                                                Dim CodigoDelitoHijoId As Integer = ObtenerUltimoDelitoHijo(objAux, objAgraviadoAuxiliarIndCol)
                                                If CodigoDelitoHijoId > 0 Then
                                                    objEntAgraviadoTempoCol.Add(Cargar_AgraviadoTemporalCol(objAux, CodigoDelitoHijoId, objE))
                                                End If
                                            End If
                                        End If

                                        ExpAuxId = -1
                                        Dim sw As Boolean = False
                                        For Each obj As Entity.Registro.Delito In objAgraviadoAuxiliarIndCol
                                            If obj.CreaDocJudicialId = objAux.CreaDocJudicialId And obj.DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                                                sw = True
                                            End If
                                        Next
                                        If sw = False Then objAgraviadoAuxiliarIndCol.Add(objAux)
                                    End If
                                Else
                                    ExpAuxId = ObtenerExpedientePadreId(ExpAuxId, objPadCol)
                                End If
                            End While
                        Else
                            objAgraviadoAuxiliarIndCol.Add(objAux)
                        End If
                    Next
                Next
            End If
            Me.Cursor = Cursors.Default
        End Sub
        Private Function ObtenerUltimoDelitoHijo(ObjDel As Entity.Registro.Delito, objAgraviadoAuxiliarIndCol As Entity.Registro.DelitoCol) As Integer
            Dim CodAuxId As Integer = -1
            Dim ValorId As Integer = -1

            For Each obj As Entity.Registro.Delito In objAgraviadoAuxiliarIndCol
                If ObjDel.Codigo = obj.CodigodelitoPad Then
                    If ObjDel.DelitoEspecifico = obj.DelitoEspecifico Then
                        For Each CodObj As Entity.Registro.Delito In objEntDelitoTempoCol
                            If obj.Codigo = CodObj.Codigo Then
                                ValorId = obj.Codigo
                                Return ValorId
                            End If
                        Next
                        CodAuxId = obj.Codigo
                        While CodAuxId > 0
                            Dim sw As Boolean = False
                            For Each CodObj As Entity.Registro.Delito In objAgraviadoAuxiliarIndCol
                                If CodAuxId = CodObj.CodigodelitoPad Then
                                    For Each D As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                                        If ObjDel.AgraviadoNombre = D.AgraviadoNombre Then
                                            Return -1
                                        End If
                                    Next
                                    CodAuxId = CodObj.Codigo
                                    sw = True
                                    Exit For
                                End If
                            Next
                            If sw = False Then
                                Return CodAuxId
                            End If
                        End While
                    Else
                        ValorId = ObjDel.Codigo
                        Exit For
                    End If

                End If
            Next
            If ValorId = -1 Then
                For Each D As Entity.Registro.Delito In objEntDelitoTempoCol
                    If ObjDel.Codigo = D.Codigo Then
                        ValorId = ObjDel.Codigo
                        Exit For
                    End If
                Next
            End If
            Return ValorId
        End Function
        Private Function CargarAgraviadoTemporalCol(objAux As Entity.Registro.Delito, objE As Entity.Registro.Expediente) As Entity.Registro.Agraviado
            Dim objAgr As New Entity.Registro.Agraviado
            objAgr.Codigo = objAux.AgraviadoId
            objAgr.CodigoagraviadoPad = objAux.AgraviadoPadre
            objAgr.AgraviadoNombre = objAux.AgraviadoNombre
            objAgr.Observacion = objAux.AgraviadoObservacion
            objAgr.Anulacion = objAux.AgraviadoAnulacion
            objAgr.DelitoID = objAux.Codigo
            objAgr.DelitoEspecificoID = objAux.DelitoEspecifico
            objAgr.ExpedienteID = objE.Codigo
            objAgr.InternoID = objE.InternoID
            objAgr.IngresoInpeId = objE.IngresoInpeId
            Return objAgr
        End Function
        Private Function Cargar_AgraviadoTemporalCol(objAux As Entity.Registro.Delito, DelitoAuxId As Integer, objE As Entity.Registro.Expediente) As Entity.Registro.Agraviado
            Dim objAgr As New Entity.Registro.Agraviado
            objAgr.Codigo = objAux.AgraviadoId
            objAgr.CodigoagraviadoPad = objAux.AgraviadoPadre
            objAgr.AgraviadoNombre = objAux.AgraviadoNombre
            objAgr.Observacion = objAux.AgraviadoObservacion
            objAgr.Anulacion = objAux.AgraviadoAnulacion
            objAgr.DelitoID = DelitoAuxId 'objAux.Codigo 
            objAgr.DelitoEspecificoID = objAux.DelitoEspecifico
            objAgr.PenalID = objAux.PenalID
            objAgr.RegionID = objAux.RegionID
            objAgr.ExpedienteID = objE.Codigo
            objAgr.InternoID = objE.InternoID
            objAgr.IngresoID = objE.IngresoID
            objAgr.IngresoInpeId = objE.IngresoInpeId
            objAgr.Estado = 0
            Return objAgr
        End Function
        Private Function ObtenerDelitoPadre(DelitoId As Integer, objCol As Entity.Registro.DelitoCol) As Integer
            For Each obj As Entity.Registro.Delito In objCol
                If DelitoId = obj.Codigo Then
                    Return obj.CodigodelitoPad
                    Exit For
                End If
            Next
            Return -1
        End Function
        Private Function ObtenerExpedientePadreId(expedienteId As Integer, objCol As Entity.Registro.InternoExpedientePadreCol) As Integer
            For Each obj As Entity.Registro.InternoExpedientePadre In objCol
                If expedienteId = obj.InternoExpedienteId Then
                    Return obj.InternoExpedienteRefPadreId
                    Exit For
                End If
            Next
            Return -1
        End Function
        Private Function fn_CargarDelitoHistorico(ExpedienteId As Integer, objDel As Entity.Registro.Delito) As Entity.Registro.Delito
            Dim obj As New Entity.Registro.Delito
            With objDel
                obj.Codigo = .Codigo
                obj.InternoID = .InternoID
                obj.IngresoID = .IngresoID
                obj.IngresoInpeId = .IngresoInpeId
                obj.ExpedienteID = ExpedienteId
                obj.CreaDocJudicialId = .CreaDocJudicialId
                obj.DelitoGenerico = .DelitoGenerico
                obj.DelitoEspecifico = .DelitoEspecifico
                obj.DelitoGenericoNombre = .DelitoGenericoNombre
                obj.DelitoEspecificoNombre = .DelitoEspecificoNombre
                obj.RegionID = .RegionID
                obj.PenalID = .PenalID
                obj.DelitoSentenciaMayorPena = .DelitoSentenciaMayorPena
                obj.DelitoMayorPena = .DelitoMayorPena
                obj.Observacion = .Observacion
                obj.Estado = 0
                obj.Anulacion = .Anulacion
                obj.PenalID = .PenalID
                obj.RegionID = .RegionID
            End With
            Return obj
        End Function
        Private Sub ListarTemporal()
            _ListarExpediente(Me._Codigo, True, False)
        End Sub
        Private Sub Usuario_Permiso()
            Me.btnNuevo.Visible = Me._FormEscritura
            Me.btnOk.Visible = True ' Me._FormEscritura
            Select Case Me._TipoResolucion
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionReferenciado,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota

                    btnNuevo.Visible = False
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionDeclaraConsentida
                    With dgwExpediente
                        .Columns("col_doc_num").Visible = True
                        .Columns("col_doc_fec_recep").Visible = True
                        .Columns("col_doc_fec_sent").Visible = True
                        .Columns("col_doc_aut_jud").Visible = True
                        .Columns("colu_aut_jud").Visible = False
                        .Columns("colu_sal_jud_nom").Visible = False
                    End With
                    Me.Text = "Sentencias No Consentidas"
                    lblNroExpedientes.Visible = False
                    btnNuevo.Visible = False
            End Select
        End Sub
#End Region
#Region "Accion"

        Private Sub AGrabar()
            If Validar(-1) = False Then Exit Sub
            ListarDelitosAgraviados()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Dim ValorInt As Integer = 0
        Dim objEntExpedienteTempoCol_copia As New Entity.Registro.ExpedienteCol
        Public Function Validar(IdExpe) As Boolean
            If dgwExpediente.Columns("colu_eleg").Visible = False And dgwExpediente.Rows.Count > 0 Then
                dgwExpediente.Item("colu_eleg", dgwExpediente.SelectedRows(0).Index).Value = True
            End If
            If ValorInt = 0 Then
                objEntExpedienteTempoCol_copia = objEntExpedienteTempoCol
                ValorInt = ValorInt + 1
            End If
            Dim blnValor As Boolean = False
            If Me._InternoID = -1 Then
                MsgBox("No se ha enviado el parametro DocJudicialId al objeto", MsgBoxStyle.Critical)
                blnValor = False
            ElseIf dgwExpediente.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Lista de expedientes vacia, operación cancelada")
                dgwExpediente.Focus()
                blnValor = False
            ElseIf dgwExpediente.Rows.Count > 0 Then
                ExpedienteTemporalCol = New Entity.Registro.ExpedienteCol
                Dim objExpediente As New Entity.Registro.Expediente
                Dim intConta As Integer = 0
                For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                    If dgwExpediente.Item("colu_eleg", i).Value = False Then
                        intConta = intConta + 1
                    Else
                        objExpediente = objEntExpedienteTempoCol.Expediente(i)
                        ExpedienteTemporalCol.Add(objExpediente)
                    End If
                Next
                If dgwExpediente.Rows.Count = intConta Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione al menos un expediente")
                    dgwExpediente.Focus()
                    Return False
                Else
                    objEntExpedienteTempoCol = New Entity.Registro.ExpedienteCol
                    objEntExpedienteTempoCol = ExpedienteTemporalCol
                    blnValor = True
                End If
            End If
            Dim intContaSen As Integer = 0
            If Me._TipoResolucion = enumTipoDocumentoJudicial.Integracion_Sentencia Or Me._TipoResolucion = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                   Me._TipoResolucion = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or Me._TipoResolucion = enumTipoDocumentoJudicial.AcumulacionExpedientes Then
                Dim strMensaje As String = ResolucionNombre(Me._TipoResolucion)
                Dim strMensaje2 As String = ""
                For Each obj As Entity.Registro.Expediente In ExpedienteTemporalCol
                    If obj.DocumentoTipoID = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
                     obj.DocumentoTipoID = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or
                     obj.DocumentoTipoID = enumTipoDocumentoJudicial.AcumulacionExpedientes Then
                        intContaSen = intContaSen + 1
                        strMensaje2 = ResolucionNombre(obj.DocumentoTipoID)
                        Exit For
                    End If
                Next
                If intContaSen > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La Resolucion [" & strMensaje & "] no puede referenciar a un expediente [" & strMensaje2 & "]")
                    dgwExpediente.Focus()
                    blnValor = False
                    Exit Function
                End If
            End If
            If objEntExpedienteTempoColCopi2.Count > 0 Then
                For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                    If dgwExpediente.Rows(i).Cells("colu_eleg").Value = True Then
                        For j As Integer = 0 To objEntExpedienteTempoColCopi2.Count - 1

                            If dgwExpediente.Rows(i).Cells("col_codigo").Value = objEntExpedienteTempoColCopi2.Expediente(j).Codigo Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente " & objEntExpedienteTempoColCopi2.Expediente(j).ExpedienteNumero & ", ya existe")
                                dgwExpediente.Focus()
                                blnValor = False
                                Exit Function
                                Exit For
                                Exit For
                            End If

                        Next
                    End If
                Next
            End If
            If Me._TipoResolucion = enumTipoDocumentoJudicial.Aclaratoria Or
              Me._TipoResolucion = enumTipoDocumentoJudicial.Ampliacion_Autoapertorio Or
              Me._TipoResolucion = enumTipoDocumentoJudicial.Avocamiento Or
              Me._TipoResolucion = enumTipoDocumentoJudicial.Prolongacion_Detencion Or
              Me._TipoResolucion = enumTipoDocumentoJudicial.Sentencia Or
              Me._TipoResolucion = enumTipoDocumentoJudicial.Sentencia_Aclaratoria Or
              Me._TipoResolucion = enumTipoDocumentoJudicial.Sent_Adecuacion_Pena Or
              Me._TipoResolucion = enumTipoDocumentoJudicial.Sent_Conmutacion_Pena Or
              Me._TipoResolucion = enumTipoDocumentoJudicial.Sent_Sustitucion_Pena Or
              Me._TipoResolucion = enumTipoDocumentoJudicial.Ejecutoria_Superior Or
              Me._TipoResolucion = enumTipoDocumentoJudicial.Ejecutoria_Suprema Then
                Dim strMensaje As String = ResolucionNombre(Me._TipoResolucion)
                If objEntExpedienteTempoColCopi2.Count = 0 Then
                    Dim intConta As Integer = 0
                    For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                        If dgwExpediente.Rows(i).Cells("colu_eleg").Value = True Then
                            intConta = intConta + 1
                        End If
                    Next
                    If intConta > 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de " & strMensaje & " solo permite un expediente")
                        dgwExpediente.Focus()
                        blnValor = False
                    End If
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya se agrego un expediente a la resolución")
                    dgwExpediente.Focus()
                    blnValor = False
                End If
            End If

            If (Me._TipoResolucion <> enumTipoDocumentoJudicial.Ejecutoria_Superior Or
                Me._TipoResolucion = enumTipoDocumentoJudicial.Ejecutoria_Suprema Or
                Me._TipoResolucion = enumTipoDocumentoJudicial.Sentencia_Aclaratoria) Then
                Dim strMensaje As String = ""
                Select Case Me._TipoResolucion
                    Case enumTipoDocumentoJudicial.Integracion_Sentencia
                        strMensaje = "Integracion de sentencia"
                    Case enumTipoDocumentoJudicial.Refundicion_de_Sentencia
                        strMensaje = "Refundicon de sentencia"
                    Case Else
                        strMensaje = "Resolucion"
                End Select
                Dim intConta As Integer = 0

                If intConta > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La " & strMensaje & " no puede referenciar a un expediente refundido")
                    dgwExpediente.Focus()
                    blnValor = False
                End If
            End If
            Return blnValor
        End Function
        Private Function ResolucionNombre(intResID As Integer) As String
            Dim strNombre As String = ""
            Select Case intResID
                Case enumTipoDocumentoJudicial.Aclaratoria
                    strNombre = "Aclaratoria"
                Case enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                    strNombre = "Ampliacion_Autoapertorio"
                Case enumTipoDocumentoJudicial.Avocamiento
                    strNombre = "Avocamiento"
                Case enumTipoDocumentoJudicial.Prolongacion_Detencion
                    strNombre = "Prolongacion de Detencion"
                Case enumTipoDocumentoJudicial.Sentencia
                    strNombre = "Sentencia"
                Case enumTipoDocumentoJudicial.Sentencia_Aclaratoria
                    strNombre = "Sentencia de Aclaratoria"
                Case enumTipoDocumentoJudicial.Sent_Sustitucion_Pena
                    strNombre = "Sent_Sustitucion_Pena"
                Case enumTipoDocumentoJudicial.Sent_Adecuacion_Pena
                    strNombre = "Sent_Adecuacion_Pena"
                Case enumTipoDocumentoJudicial.Sent_Sustitucion_Pena
                    strNombre = "Sent_Sustitucion_Pena"
                Case enumTipoDocumentoJudicial.Ejecutoria_Superior
                    strNombre = "Ejecutoria_Superior"
                Case enumTipoDocumentoJudicial.Ejecutoria_Suprema
                    strNombre = "Ejecutoria_Suprema"
                Case enumTipoDocumentoJudicial.AcumulacionExpedientes
                    strNombre = "Acumulacion de expedientes"
                Case enumTipoDocumentoJudicial.Integracion_Sentencia
                    strNombre = "Integracion de Sentencia"
                Case enumTipoDocumentoJudicial.Refundicion_de_Sentencia
                    strNombre = "Refundicion de Sentencia"
                Case enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                    strNombre = "Sumatoria de Sentencia"
            End Select
            Return strNombre
        End Function
        Public Function CargarExpedienteSeleccionado() As Boolean

            objEntExpedienteTempoColCopi = New Entity.Registro.ExpedienteCol
            Dim intValue As Integer = 0
            Dim blnCondicion As Boolean = False
            Dim strNumeroExpediente As String = ""
            For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                If dgwExpediente.Item("colu_eleg", i).Value = True Then
                    objEntExpedienteTempoColCopi.Add(objEntExpedienteTempoCol.Item(i))
                    For Each EntDelito As Entity.Registro.Delito In objEntDelitoTempoCol
                        If dgwExpediente.Item("col_codigo", i).Value = EntDelito.ExpedienteID Then
                            objEntDelitoTempoCol.Add(EntDelito)
                            For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                                If EntDelito.Codigo = EntAgr.DelitoID Then
                                    'objEntAgraviadoTempoCol2.Add(EntAgr)
                                End If
                            Next
                        End If
                    Next
                End If
            Next
            For Each EntCopi As Entity.Registro.Expediente In objEntExpedienteTempoColCopi
                For Each EntCopi2 As Entity.Registro.Expediente In objEntExpedienteTempoColCopi2
                    If EntCopi.ExpedienteNumero = EntCopi2.ExpedienteNumero Then
                        blnCondicion = True
                        strNumeroExpediente = EntCopi.ExpedienteNumero
                        Exit For
                        Exit For
                    End If
                Next
            Next
            If Me._GrillaSeleccionMultiple = False Then
                If objEntExpedienteTempoColCopi2.Count > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista ya posee un expediente")
                    Exit Function
                    Return False
                End If
            End If
            If blnCondicion = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente : " & strNumeroExpediente & "  ya se encuentra en la lista")
                Exit Function
                Return False
            End If
            Return True
        End Function
        Public Function CargarExpedienteSeleccionadoCheket() As Boolean

            objEntExpedienteTempoColCopi = New Entity.Registro.ExpedienteCol
            Dim intValue As Integer = 0
            Dim blnCondicion As Boolean = False
            Dim strNumeroExpediente As String = ""
            For i As Integer = 0 To dgwExpediente.Rows.Count - 1
                If dgwExpediente.Item("colu_eleg", i).Value = True Then
                    objEntExpedienteTempoColCopi.Add(objEntExpedienteTempoCol.Item(i))
                    For Each EntDelito As Entity.Registro.Delito In objEntDelitoTempoCol
                        If dgwExpediente.Item("col_codigo", i).Value = EntDelito.ExpedienteID Then
                            objEntDelitoTempoCol.Add(EntDelito)
                            For Each EntAgr As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                                If EntDelito.Codigo = EntAgr.DelitoID Then
                                    objEntAgraviadoTempoCol.Add(EntAgr)
                                End If
                            Next
                        End If
                    Next
                End If
            Next
            For Each EntCopi As Entity.Registro.Expediente In objEntExpedienteTempoColCopi
                For Each EntCopi2 As Entity.Registro.Expediente In objEntExpedienteTempoColCopi2
                    If EntCopi.ExpedienteNumero = EntCopi2.ExpedienteNumero Then
                        blnCondicion = True
                        strNumeroExpediente = EntCopi.ExpedienteNumero
                        Exit For
                        Exit For
                    End If
                Next
            Next
            If Me._GrillaSeleccionMultiple = False Then
                If objEntExpedienteTempoColCopi2.Count > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista ya posee un expediente")
                    Exit Function
                    Return False
                End If
            End If
            If blnCondicion = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente : " & strNumeroExpediente & "  ya se encuentra en la lista")
                Exit Function
                Return False
            End If
            Return True
        End Function
#End Region
#Region "Permisos"
        Private Sub ShowControl()
            Me.btnOk.Visible = Me._VisibleGrabar
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            With dgwExpediente
                .Columns("colu_num_exp").ReadOnly = True
                .Columns("colu_sit_jur").ReadOnly = True
                .Columns("colu_aut_jud").ReadOnly = True
                .Columns("colu_sal_jud_nom").ReadOnly = True
                .Columns("colu_secre").ReadOnly = True
                .VisibleCampos = False
            End With
        End Sub
#End Region

        Private Sub frmExpedientePopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmExpedientePopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            ListarTemporal()
            Usuario_Permiso()
        End Sub


        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub UscListaExpeDeResolucion1__Click_Expediente_Agregar()
            FRM_MantenimientoExpediente(True, Nothing)
        End Sub
        Public blnCondicion As Boolean = True
        Private Sub FRM_MantenimientoExpediente(ByVal Nuevo As Boolean, objEnt As Entity.Registro.Expediente)
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                    ._TemporalNuevo = True 'temporal nuevo
                Else
                    ._Codigo = objEnt.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                End If
                ._objEntExpediente = objEnt
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnCondicion = True
                    Me.Close()
                End If

            End With
        End Sub
        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            Me._NuevoExpediente = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End Sub

        Private Sub ckbSeleccionar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbSeleccionar.CheckedChanged
            With dgwExpediente
                If ckbSeleccionar.Checked = True Then
                    If .Rows.Count > 0 Then
                        For i As Integer = 0 To .Rows.Count - 1
                            .Item("colu_eleg", i).Value = True
                        Next
                    End If
                Else
                    If .Rows.Count > 0 Then
                        For i As Integer = 0 To .Rows.Count - 1
                            .Item("colu_eleg", i).Value = False
                        Next
                    End If

                End If
            End With
        End Sub
        Private Sub dgwExpediente2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellContentClick
            If Me._GrillaSeleccionMultiple = False Then
                If dgwExpediente.Columns("colu_eleg").Visible = True And dgwExpediente.Columns("colu_eleg").Index = e.ColumnIndex Then
                    For i As Integer = 0 To dgwExpediente.Rows.Count - 1 'obligar a marcar check a un solo registro (emular radio button)
                        If i <> dgwExpediente.CurrentCell.RowIndex Then
                            dgwExpediente.Item("colu_sele", i).Value = False
                        End If
                    Next
                End If
            End If
        End Sub

        Private Sub dgwExpediente2_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwExpediente.CellDoubleClick
            btnOk.PerformClick()
        End Sub
    End Class
End Namespace
