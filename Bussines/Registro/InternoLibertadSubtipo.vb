Imports System.Data
Imports System.Data.SqlClient
Imports Type.Enumeracion.Licencia
Namespace Registro
    Public Class ExpedienteLibertadSubtipo
        Private objEnt As Entity.Registro.Expediente = Nothing
        Private objExpLib As Entity.Registro.ExpedienteLibertadSubtipo = Nothing
        Private objEntCol As Entity.Registro.ExpedienteCol = Nothing
        Private objExpLibCol As Entity.Registro.ExpedienteLibertadSubtipoCol = Nothing
#Region "Listar"
        Public Function ListarF(ByVal Codigo As Integer) As Entity.Registro.Expediente

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_mantF", Codigo, -1, -1, -1, -1, "", 0, -1)

            objEnt = New Entity.Registro.Expediente
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Internamiento = sqlDr("int_exp_itn").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            '.AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                            .SalaJudicialID = sqlDr("sal_jus_id").ToString
                            '.SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                            .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                            .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            '.SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString
                            '.CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt

        End Function

        Public Function Listar(ByVal EntExp As Entity.Registro.ExpedienteLibertadSubtipo) As Entity.Registro.ExpedienteLibertadSubtipoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.ExpedienteLibertadSubtipo.Listar(sqlCon, "lst", "lst_mant", EntExp)

            Dim objEntColtmp = New Entity.Registro.ExpedienteLibertadSubtipoCol

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objExpLib = New Entity.Registro.ExpedienteLibertadSubtipo
                        With objExpLib
                            .Codigo = sqlDr("pk_int_lib_tip_id").ToString
                            .ExpedienteId = sqlDr("int_exp_id").ToString
                            .CreaDocJudicialId = sqlDr("doc_jud_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .LibertadTipoID = sqlDr("tip_ib_id").ToString
                            .LibertadSubTipoID = sqlDr("sub_tip_ib_id").ToString
                        End With
                        objEntColtmp.add(objExpLib)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return objEntColtmp

        End Function

        'Listar_v2
        Public Function Listar_v2_LM(ByVal EntExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar_LM(sqlCon, "lst", "lst_mant_LM", EntExp)

            Dim objEntColtmp = New Entity.Registro.ExpedienteCol


            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Internamiento = sqlDr("int_exp_itn").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                            .SalaJudicialID = sqlDr("sal_jus_id").ToString
                            .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                            .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                            .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .Anulacion = sqlDr("n_int_exp_est_anu")
                        End With
                        objEntColtmp.add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return objEntColtmp

        End Function

        Public Function ListarExpedientexResolucion(IdDocJud As Integer) As Entity.Registro.ExpedienteCol

            '19-06-2014->hnrb-> lista el historico de exp al que hizo referencia las resoluciones(tabla REG_DOC_DocJudicialExpediente).

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objIntExp As New Entity.Registro.Expediente
            objIntExp.AuxRefDocJudId = IdDocJud
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_grilla_exp_ref_x_docjudicial", objIntExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID > Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                    .AutoridadOtro = sqlDr("int_exp_otr_nom").ToString
                                    .AutoridadOtroCargo = sqlDr("int_exp_otr_cgo").ToString
                                Else  '.TipoAutoridadJudicialID = -1 
                                    If .AutoridadJudicialID > 0 Then
                                        .TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial
                                        .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                                        .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                        .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                        .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                        .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                        .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                                    Else
                                        .TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.OtraAutoridad
                                        .AutoridadJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                        .SalaJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                        .AutoridadOtro = sqlDr("int_exp_otr_nom").ToString
                                        .AutoridadOtroCargo = sqlDr("int_exp_otr_cgo").ToString
                                    End If
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            '.ExpedienteVisible = sqlDr("").ToString
                            '/*libertad*/  
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .LibertadTipoNom = sqlDr("tip_lib_nom").ToString
                            .LibertadSubTipoStrID = sqlDr("subtip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            '.SentenciaConcatenado = ""
                            .ExpedienteReferidoID = sqlDr("int_exp_ref").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .ResolucionID = sqlDr("n_res_id").ToString
                            .ResolucionNom = sqlDr("n_res_nom").ToString
                            .MotivoQuedaID = sqlDr("n_que_id").ToString
                            .MotivoQuedaNom = sqlDr("n_que_nom").ToString
                            .MotivoIngresoID = sqlDr("fk_mot_ing_id").ToString
                            .Inimputable = sqlDr("Inimputable").ToString
                            .EstablecimientomentalId = sqlDr("fk_est_men_des_id").ToString
                            .Establecimientomental = sqlDr("est_men_des_nom").ToString
                            .NuevoMotivoInimputableId = sqlDr("fk_nue_mot_ing_id").ToString
                            .NuevoMotivoInimputable = sqlDr("fk_nue_mot_ing").ToString
                            .NuevoEstablecimientomentalId = sqlDr("nue_est_men_des_id").ToString
                            .NuevoEstablecimientomental = sqlDr("nue_est_men_des_nom").ToString
                            ._RegionId = sqlDr("reg_id").ToString
                            ._PenalId = sqlDr("pen_id").ToString()
                            .Extramuro = sqlDr("int_ref_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarExpedientexResolucion_LM(IdDocJud As Integer) As Entity.Registro.ExpedienteCol

            '19-06-2014->hnrb-> lista el historico de exp al que hizo referencia las resoluciones(tabla REG_DOC_DocJudicialExpediente).

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objIntExp As New Entity.Registro.Expediente
            objIntExp.AuxRefDocJudId = IdDocJud
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar_LM(sqlCon, "lst", "lst_grilla_exp_ref_x_docjudicial_LM", objIntExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString

                            If .TipoAutoridadJudicialID = 1 Then
                                .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID = -1 Then
                                    If .AutoridadJudicialID > 0 Then
                                        .TipoAutoridadJudicialID = 1
                                        .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                                        .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                        .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                        .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                        .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                        .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                                    Else
                                        .TipoAutoridadJudicialID = 2
                                        .AutoridadJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                        .SalaJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                        .AutoridadOtro = sqlDr("int_exp_otr_nom").ToString
                                        .AutoridadOtroCargo = sqlDr("int_exp_otr_cgo").ToString
                                    End If
                                Else
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                    .AutoridadOtro = sqlDr("int_exp_otr_nom").ToString
                                    .AutoridadOtroCargo = sqlDr("int_exp_otr_cgo").ToString
                                End If
                            End If

                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            '/*libertad*/  
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .LibertadTipoNom = sqlDr("tip_lib_nom").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            .SentenciaConcatenado = "" ' ListadoSentenciaConcatenado_LM(.InternoID, .IngresoInpeId, .Codigo)
                            .ExpedienteReferidoID = sqlDr("int_exp_ref").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .ResolucionID = sqlDr("n_res_id").ToString
                            .ResolucionNom = sqlDr("n_res_nom").ToString
                            .MotivoQuedaID = sqlDr("n_que_id").ToString
                            .MotivoQuedaNom = sqlDr("n_que_nom").ToString
                            .MotivoIngresoID = sqlDr("fk_mot_ing_id").ToString
                            .Inimputable = sqlDr("Inimputable").ToString
                            .EstablecimientomentalId = sqlDr("fk_est_men_des_id").ToString
                            .Establecimientomental = sqlDr("est_men_des_nom").ToString
                            .NuevoMotivoInimputableId = sqlDr("fk_nue_mot_ing_id").ToString
                            .NuevoMotivoInimputable = sqlDr("fk_nue_mot_ing").ToString
                            .NuevoEstablecimientomentalId = sqlDr("nue_est_men_des_id").ToString
                            .NuevoEstablecimientomental = sqlDr("nue_est_men_des_nom").ToString
                            ._RegionId = sqlDr("reg_id").ToString
                            .Extramuro = sqlDr("int_ref_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarGrillaInimputables(entExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_grilla_Inmp", entExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt

                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 1
                                End If
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 2
                                End If
                                If .AutoridadJudicialNombre = "" Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                End If
                                If .SalaJudicialNombre = "" Then
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString

                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            '.SentenciaConcatenado = ""
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .SentenciaAnio = sqlDr("sent_tot_anio").ToString
                            .SentenciaMes = sqlDr("sent_tot_mes").ToString
                            .SentenciaDia = sqlDr("sent_tot_dias").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaFechaInicio = sqlDr("FechaInicio").ToString
                            .SentenciaFechaFinal = sqlDr("FechaFinal").ToString

                            .MotivoIngresoID = sqlDr("mov_mot_id").ToString
                            .Inimputable = sqlDr("Inimputable").ToString
                            .EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
                            .Establecimientomental = sqlDr("est_ment_des").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarGrillaPopup(entExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_grilla_popup", entExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt

                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 1
                                End If
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 2
                                End If
                                If .AutoridadJudicialNombre = "" Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                End If
                                If .SalaJudicialNombre = "" Then
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString

                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            '.SentenciaConcatenado = ""
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .MotivoIngresoID = sqlDr("mov_mot_id").ToString
                            .Inimputable = sqlDr("Inimputable").ToString
                            .EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
                            .Establecimientomental = sqlDr("est_men_des_nom").ToString
                            .SentenciaAnio = sqlDr("sent_tot_anio").ToString
                            .SentenciaMes = sqlDr("sent_tot_mes").ToString
                            .SentenciaDia = sqlDr("sent_tot_dias").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaFechaInicio = sqlDr("FechaInicio").ToString
                            .SentenciaFechaFinal = sqlDr("FechaFinal").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarGrillaPopup_LM(entExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar_LM(sqlCon, "lst", "lst_grilla_popup_LM", entExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt

                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 1
                                End If
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 2
                                End If
                                If .AutoridadJudicialNombre = "" Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                End If
                                If .SalaJudicialNombre = "" Then
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString

                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .MotivoIngresoID = sqlDr("mov_mot_id").ToString
                            .Inimputable = sqlDr("Inimputable").ToString
                            .EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
                            .Establecimientomental = sqlDr("est_men_des_nom").ToString
                            'periodo de condena
                            .SentenciaAnio = sqlDr("sent_tot_anio").ToString
                            .SentenciaMes = sqlDr("sent_tot_mes").ToString
                            .SentenciaDia = sqlDr("sent_tot_dias").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaFechaInicio = sqlDr("FechaInicio").ToString
                            .SentenciaFechaFinal = sqlDr("FechaFinal").ToString
                            '*******************************/
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .ResolucionID = sqlDr("n_int_exp_res_id").ToString
                            .ResolucionNom = sqlDr("n_int_exp_res_nom").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
        Public Function ListarGrillaPopup_LM_v2(entExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar_LM(sqlCon, "lst", "lst_grilla_popup_LM_v2", entExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt

                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            'xxx modifcar esta condicion, esta matando los registros x regularizar, debe hacerse un select, <1,1,2
                            If .AutoridadJudicialID > 0 Then
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 1
                                End If
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 2
                                End If
                                If .AutoridadJudicialNombre = "" Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                End If
                                If .SalaJudicialNombre = "" Then
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString

                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            '.SentenciaConcatenado = ""
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .ResolucionID = sqlDr("n_int_exp_res_id").ToString
                            .ResolucionNom = sqlDr("n_int_exp_res_nom").ToString

                            .MotivoIngresoID = sqlDr("mov_mot_id").ToString
                            .Inimputable = sqlDr("Inimputable").ToString
                            .EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
                            .Establecimientomental = sqlDr("est_men_des_nom").ToString

                            .SentenciaAnio = sqlDr("sent_tot_anio").ToString
                            .SentenciaMes = sqlDr("sent_tot_mes").ToString
                            .SentenciaDia = sqlDr("sent_tot_dias").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaFechaInicio = sqlDr("FechaInicio").ToString
                            .SentenciaFechaFinal = sqlDr("FechaFinal").ToString
                            .Extramuro = sqlDr("int_ref_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
        Public Function ListarGrillaRevocatoria(entExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_grilla_para_revocatoria", entExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt

                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 1
                                End If
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 2
                                End If
                                If .AutoridadJudicialNombre = "" Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                End If
                                If .SalaJudicialNombre = "" Then
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString

                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            '.SentenciaConcatenado = ""
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarGrillaRevocatoria_LM(entExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar_LM(sqlCon, "lst", "lst_grilla_para_revocatoria_LM", entExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 1
                                End If
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 2
                                End If
                                If .AutoridadJudicialNombre = "" Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                End If
                                If .SalaJudicialNombre = "" Then
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString

                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            '.SentenciaConcatenado = ""
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function Listar(objIntExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol
            Dim sqlDr As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            sqlDr = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_grilla2", objIntExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                .AutoridadOtro = sqlDr("int_exp_otr_nom").ToString
                                .AutoridadOtroCargo = sqlDr("int_exp_otr_cgo").ToString

                                .AutoridadJudicialNombre = .AutoridadOtroCargo
                                .SalaJudicialNombre = .AutoridadOtro
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .DocFechaDocRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString
                            '/*Datos del documento*/
                            .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
                            .DocumentoJudicialNum = sqlDr("doc_jud_num").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .DocumentoTipoCategoria = sqlDr("doc_tip_cat").ToString
                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .FechaLibertad = sqlDr("int_lib_fec").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CodigoPadre = sqlDr("int_ex_pad_ref_id").ToString
                            .SentenciaAnio = sqlDr("int_exp_anio_his").ToString
                            .SentenciaMes = sqlDr("int_exp_mes_his").ToString
                            .SentenciaDia = sqlDr("int_exp_dia_his").ToString
                            If .DocumentoTipoCategoria > 1 Then '/*solo para sentencias*/
                                Dim strSentencia As String = ""
                                If .DocumentoTipoCategoria = 2 Then
                                    strSentencia = " F. Sent. "
                                End If
                                .FechaSentencia = sqlDr("sent_fec").ToString
                                If .SentenciaAnio < 1 And .SentenciaMes < 1 And .SentenciaDia < 1 Then
                                    .SentenciaConcatenado = IIf(.DocumentoJudicialNum = "", "", "Doc: ") & .DocumentoJudicialNum & strSentencia & .FechaSentenciaDate
                                Else
                                    .SentenciaConcatenado = "Doc: " & .DocumentoJudicialNum & strSentencia & .FechaSentenciaDate & " (T.C " & .SentenciaAnio & " Años " & .SentenciaMes & " Meses " & .SentenciaDia & " Dias)"
                                End If
                            End If
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .MotivoIngresoID = sqlDr("mov_mot_id").ToString
                            .Inimputable = sqlDr("inimputable").ToString
                            If Not (.MotivoIngresoID = 178 Or .MotivoIngresoID = 179) Then
                                .Inimputable = "NO PERTENECE"
                            End If
                            .Extramuro = sqlDr("int_ref_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarValidar_Extramuro(entExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar_LM(sqlCon, "lst", "lst_validar_extramuro", entExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt

                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Extramuro = sqlDr("int_ref_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
        'origen Listar(...
        Public Function Listar_LM(objIntExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol
            Return Listar_LM(objIntExp, "lst", "lst_grilla2_LM")
        End Function
        Public Function Listar_LM_v2(objIntExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol
            Return Listar_LM_v2(objIntExp, "lst", "lst_grilla2_LM_v2")
        End Function

        Public Function ListarGrillaSentenciasNoConsentidas(entExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_sentencias_no_consentidas", entExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt
                            '------cabecera--------------
                            .DocumentoJudicialNum = sqlDr("doc_jud_num").ToString
                            .DocFechaDocRecepcion = sqlDr("doc_fec_rec").ToString
                            .FechaSentencia = sqlDr("doc_fec_sen").ToString
                            .DocumentoDistritoJudicial = sqlDr("doc_dis_jud").ToString
                            .DocumentoAutoridadJudicial = sqlDr("doc_aut_jud").ToString
                            '----------------------------
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 1
                                End If
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 2
                                End If
                                If .AutoridadJudicialNombre = "" Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                End If
                                If .SalaJudicialNombre = "" Then
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString

                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            '.SentenciaConcatenado = ""
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .MotivoIngresoID = sqlDr("mov_mot_id").ToString
                            .Inimputable = sqlDr("Inimputable").ToString
                            .EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
                            .Establecimientomental = sqlDr("est_men_des_nom").ToString
                            .SentenciaAnio = sqlDr("sent_tot_anio").ToString
                            .SentenciaMes = sqlDr("sent_tot_mes").ToString
                            .SentenciaDia = sqlDr("sent_tot_dias").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaFechaInicio = sqlDr("FechaInicio").ToString
                            .SentenciaFechaFinal = sqlDr("FechaFinal").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
        ''' <summary>
        ''' Retorna los expediente de todos los mandatos de detencion que corresponden al ingreso (Internamiento)
        ''' </summary>
        ''' <param name="objIntExp"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ListarMandatosCarceleta(objIntExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol
            Return Listar_LM(objIntExp, "lst", "lst_mand_carceleta")
        End Function

        Public Function ListarEgreso(ByVal Codigo As Integer) As Entity.Registro.Expediente

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_egreso",
            Codigo, -1, -1, -1, -1, "", 0, -1)

            objEnt = New Entity.Registro.Expediente
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            '/*libertad*/
                            .DistritoJudicialID = sqlDr("dis_jud_id").ToString
                            .JuzgadoID = sqlDr("juz_id").ToString
                            .AutoridadOtro = sqlDr("int_exp_otr_nom").ToString
                            .AutoridadOtroCargo = sqlDr("int_exp_otr_cgo").ToString
                            .EgresoJuez = sqlDr("int_exp_lib_jue").ToString
                            .EgresoSecretario = sqlDr("int_exp_lib_sec").ToString
                            .DocumentoLibertad = sqlDr("int_lib_doc").ToString
                            .EgresoFechaDocRecepcion = sqlDr("int_exp_lib_fec_doc_rcp").ToString
                            .DocumentoLibertadFecha = sqlDr("int_lib_doc_fec").ToString
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .FechaLibertad = sqlDr("int_lib_fec").ToString
                            .ObsLibertad = sqlDr("int_exp_obs_lib").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return objEnt

        End Function

        Private Function Listar_LM(objIntExp As Entity.Registro.Expediente, opcion As String, accion As String) As Entity.Registro.ExpedienteCol
            Dim sqlDr As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            sqlDr = Data.Registro.Expediente.Listar_LM(sqlCon, opcion, accion, objIntExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                .AutoridadOtro = sqlDr("int_exp_otr_nom").ToString
                                .AutoridadOtroCargo = sqlDr("int_exp_otr_cgo").ToString

                                .AutoridadJudicialNombre = .AutoridadOtroCargo
                                .SalaJudicialNombre = .AutoridadOtro
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .DocFechaDocRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString
                            '/*Datos del documento*/
                            .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
                            .DocumentoJudicialNum = sqlDr("doc_jud_num").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .DocumentoTipoCategoria = sqlDr("doc_tip_cat").ToString
                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .FechaLibertad = sqlDr("int_lib_fec").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CodigoPadre = sqlDr("int_ex_pad_ref_id").ToString
                            .SentenciaAnio = sqlDr("int_exp_anio_his").ToString
                            .SentenciaMes = sqlDr("int_exp_mes_his").ToString
                            .SentenciaDia = sqlDr("int_exp_dia_his").ToString
                            If .DocumentoTipoCategoria > 1 Then '/*solo para sentencias*/
                                .FechaSentencia = sqlDr("sent_fec").ToString
                                If .SentenciaAnio < 1 And .SentenciaMes < 1 And .SentenciaDia < 1 Then
                                    .SentenciaConcatenado = "Doc: " & .DocumentoJudicialNum & " F. Sent. " & .FechaSentenciaDate
                                Else
                                    .SentenciaConcatenado = "Doc: " & .DocumentoJudicialNum & " F. Sent. " & .FechaSentenciaDate & " (T.C " & .SentenciaAnio & " Años " & .SentenciaMes & " Meses " & .SentenciaDia & " Dias)"
                                End If
                            End If
                            .Anulacion = sqlDr("n_est_anu").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
        Private Function Listar_LM_v2(objIntExp As Entity.Registro.Expediente, opcion As String, accion As String) As Entity.Registro.ExpedienteCol
            Dim sqlDr As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            sqlDr = Data.Registro.Expediente.Listar_LM(sqlCon, opcion, accion, objIntExp)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                .AutoridadOtro = sqlDr("int_exp_otr_nom").ToString
                                .AutoridadOtroCargo = sqlDr("int_exp_otr_cgo").ToString

                                .AutoridadJudicialNombre = .AutoridadOtroCargo
                                .SalaJudicialNombre = .AutoridadOtro
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .DocFechaDocRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString
                            '/*Datos del documento*/
                            .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
                            .DocumentoJudicialNum = sqlDr("doc_jud_num").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .DocumentoTipoCategoria = sqlDr("doc_tip_cat").ToString
                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .FechaLibertad = sqlDr("int_lib_fec").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CodigoPadre = sqlDr("int_ex_pad_ref_id").ToString
                            .SentenciaAnio = sqlDr("int_exp_anio_his").ToString
                            .SentenciaMes = sqlDr("int_exp_mes_his").ToString
                            .SentenciaDia = sqlDr("int_exp_dia_his").ToString
                            If .DocumentoTipoCategoria > 1 Then '/*solo para sentencias*/
                                .FechaSentencia = sqlDr("sent_fec").ToString
                                If .SentenciaAnio < 1 And .SentenciaMes < 1 And .SentenciaDia < 1 Then
                                    .SentenciaConcatenado = IIf(.DocumentoJudicialNum = "", "", "Doc: ") & .DocumentoJudicialNum & IIf(.FechaSentencia = 0, "", " F. Sent. ") & .FechaSentenciaDate
                                Else
                                    .SentenciaConcatenado = "Doc: " & .DocumentoJudicialNum & " F. Sent. " & .FechaSentenciaDate & " (T.C " & .SentenciaAnio & " Años " & .SentenciaMes & " Meses " & .SentenciaDia & " Dias)"
                                End If
                            ElseIf .DocumentoTipoCategoria = 1 And .DocumentoTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                .SentenciaConcatenado = "."
                            End If
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .MotivoIngresoID = sqlDr("mov_mot_id").ToString
                            .Inimputable = sqlDr("inimputable").ToString
                            If Not (.MotivoIngresoID = 178 Or .MotivoIngresoID = 179) Then
                                .Inimputable = "NO PERTENECE"
                            End If
                            .Extramuro = sqlDr("int_ref_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
        Public Function ListarGrillaPopup_Queda_Modif(DocJud_id As Integer, id_interno As Integer, id_ingreso As Integer, id_ingreso_inpe As Integer) As Entity.Registro.ExpedienteCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar_QuedaExp(sqlCon, "lst", "lst_grilla_popup_modif", DocJud_id, id_interno, id_ingreso, id_ingreso_inpe)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        ' If objEnt_sel.Count() > 0 Then
                        'If objEnt_sel.Item(0).Codigo.ToString <> sqlDr("int_exp_id").ToString Then
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 1
                                End If
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 2
                                End If
                                If .AutoridadJudicialNombre = "" Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                End If
                                If .SalaJudicialNombre = "" Then
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString

                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            '.SentenciaConcatenado = ""
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .MotivoIngresoID = sqlDr("mov_mot_id").ToString
                            .Inimputable = sqlDr("Inimputable").ToString
                            .EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
                            .Establecimientomental = sqlDr("est_men_des_nom").ToString
                            .SentenciaAnio = sqlDr("sent_tot_anio").ToString
                            .SentenciaMes = sqlDr("sent_tot_mes").ToString
                            .SentenciaDia = sqlDr("sent_tot_dias").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaFechaInicio = sqlDr("FechaInicio").ToString
                            .SentenciaFechaFinal = sqlDr("FechaFinal").ToString
                        End With
                        objEntCol.Add(objEnt)
                        '    End If
                        'End If

                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarGrillaPopup_LM_Queda(entExp As Entity.Registro.Expediente, objEnt_lib_sel As Entity.Registro.ExpedienteCol) As Entity.Registro.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim codigo As Integer = -1
            If objEnt_lib_sel.Count > 0 Then
                codigo = objEnt_lib_sel.Item(0).Codigo
            End If
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar_Queda_LM(sqlCon, "lst", "lst_grilla_popup_LM", entExp, codigo)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        'If objEnt_sel.Count() > 0 Then
                        'If objEnt_sel.Item(0).Codigo.ToString <> sqlDr("int_exp_id").ToString Then
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 1
                                End If
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 2
                                End If
                                If .AutoridadJudicialNombre = "" Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                End If
                                If .SalaJudicialNombre = "" Then
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString

                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .MotivoIngresoID = sqlDr("mov_mot_id").ToString
                            .Inimputable = sqlDr("Inimputable").ToString
                            .EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
                            .Establecimientomental = sqlDr("est_men_des_nom").ToString
                            'periodo de condena
                            .SentenciaAnio = sqlDr("sent_tot_anio").ToString
                            .SentenciaMes = sqlDr("sent_tot_mes").ToString
                            .SentenciaDia = sqlDr("sent_tot_dias").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaFechaInicio = sqlDr("FechaInicio").ToString
                            .SentenciaFechaFinal = sqlDr("FechaFinal").ToString
                            '*******************************/
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .ResolucionID = sqlDr("n_int_exp_res_id").ToString
                            .ResolucionNom = sqlDr("n_int_exp_res_nom").ToString
                        End With
                        objEntCol.Add(objEnt)

                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarGrillaPopup_Queda(entExp As Entity.Registro.Expediente, objEnt_lib_sel As Entity.Registro.ExpedienteCol) As Entity.Registro.ExpedienteCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar_Queda(sqlCon, "lst", "lst_grilla_popup", entExp, objEnt_lib_sel.Item(0).Codigo)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        ' If objEnt_sel.Count() > 0 Then
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            If .AutoridadJudicialID > 0 Then
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 1
                                End If
                                .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                                .SalaJudicialID = sqlDr("sal_jus_id").ToString
                                .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                                .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                                .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            Else
                                If .TipoAutoridadJudicialID < 1 Then
                                    .TipoAutoridadJudicialID = 2
                                End If
                                If .AutoridadJudicialNombre = "" Then
                                    .AutoridadJudicialNombre = sqlDr("int_exp_otr_cgo").ToString
                                End If
                                If .SalaJudicialNombre = "" Then
                                    .SalaJudicialNombre = sqlDr("int_exp_otr_nom").ToString
                                End If
                            End If
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString

                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            '.SentenciaConcatenado = ""
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .MotivoIngresoID = sqlDr("mov_mot_id").ToString
                            .Inimputable = sqlDr("Inimputable").ToString
                            .EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
                            .Establecimientomental = sqlDr("est_men_des_nom").ToString
                            .SentenciaAnio = sqlDr("sent_tot_anio").ToString
                            .SentenciaMes = sqlDr("sent_tot_mes").ToString
                            .SentenciaDia = sqlDr("sent_tot_dias").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaFechaInicio = sqlDr("FechaInicio").ToString
                            .SentenciaFechaFinal = sqlDr("FechaFinal").ToString
                            ._PenalId = sqlDr("_PenId").ToString
                            ._RegionId = sqlDr("_RegId").ToString
                        End With
                        objEntCol.Add(objEnt)
                        '    End If
                        'End If

                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

#End Region
#Region "REG_DOC_DocJudicialExpediente"
        Public Function Listar(objDocJudExpe As Entity.Registro.Documento.DocumentoJudicialExpediente) As Entity.Registro.Documento.DocumentoJudicialExpedienteCol

            Dim objEntCol As New Entity.Registro.Documento.DocumentoJudicialExpedienteCol
            Dim objEnt As Entity.Registro.Documento.DocumentoJudicialExpediente = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_grilla_expedientes", objDocJudExpe)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.DocumentoJudicialExpediente
                        With objEnt
                            .IDExpediente = sqlDr("int_exp_id").ToString
                            .DocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .IDExpediente = sqlDr("int_exp_id").ToString
                            .InternoId = sqlDr("int_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
#End Region

#Region "Validar"
        Private Function ValidarInterno(ByVal InternoID As Integer) As Integer

            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0

            intValue = Data.Registro.Expediente.ListarOutput("lst", "lst_validar_interno_estado", -1,
            -1, InternoID, -1, -1, "", 0, -1, 0)

            If intValue < 1 Then

                Dim strMensaje As String = ""
                strMensaje = "No puede ingresar expedientes, cuando el Interno se encuentra con estado inactivo" _
                & Chr(13) & "De todas maneras desea ingresar el expediente del Interno"

                If MsgBox(strMensaje, 36,
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo) = MsgBoxResult.No Then
                    blnValue = False
                End If

                Return blnValue
            End If

            Return blnValue

        End Function
        Private Function ValidarFechaIngreso(ByVal InternoID As Integer, ByVal IngresoID As Integer,
        ByVal FechaLibertad As Long) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0

            intValue = Data.Registro.Expediente.ListarOutput("lst", "lst_validar_fecha_ingreso", -1,
            IngresoID, InternoID, -1, -1, "", 0, -1, FechaLibertad)

            If intValue > 0 Then
                MsgBox("La fecha de libertad es menor a la fecha de ingreso", 48,
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
                blnValue = False
                Return blnValue
            End If

            Return blnValue

        End Function
        Private Function Validar(objIntExp As Entity.Registro.Expediente) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0
            If objIntExp.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Interno no ha sido enviando...[Expediente]")
                Return False
                Exit Function
            End If
            If Not (objIntExp._TipoLicencia = enmTipoLicencia.Carceleta Or objIntExp._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or objIntExp._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then
                If objIntExp.IngresoID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Ingreso no ha sido enviando...[Expediente]")
                    Return False
                    Exit Function
                End If
            End If
            If Not (objIntExp._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then
                If objIntExp._PenalId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Penal no ha sido enviando...[Expediente]")
                    Return False
                    Exit Function
                End If
            End If
            If objIntExp._RegionId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Region no ha sido enviando...[Expediente]")
                Return False
                Exit Function
            End If

            Return blnValue

        End Function

        Private Function Validar_LM(objIntExp As Entity.Registro.Expediente) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0
            If objIntExp.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Interno no ha sido enviando...[Expediente]")
                Return False
                Exit Function
            End If
            If objIntExp.IngresoInpeId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro IngresoInpeId no ha sido enviando...[Expediente]")
                Return False
                Exit Function
            End If

            If objIntExp._RegionId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Region no ha sido enviando...[Expediente]")
                Return False
                Exit Function
            End If

            Return blnValue

        End Function
#End Region
#Region "Grabar"

        Public Function Grabar(objIntExp As Entity.Registro.Expediente) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Validar(objIntExp) = False Then
                intValue = -1
                intValue = False
                Return intValue
            End If


            If objIntExp.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2" 'referencia a version 2->hnrb
            Else
                strAccion = "upd"
                strOpcion = "upd_mant2"
            End If

            intValue = Data.Registro.Expediente.Grabar(strAccion, strOpcion, objIntExp)

            'Grabar inimputables
            Select Case objIntExp.DocumentoTipoID
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso,
                         Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia,
                         Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionConsentida,
                         Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior,
                         Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema,
                         Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental,
                         Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental,
                         Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad

                    Dim bss As New Bussines.Registro.InternoInimputable
                    If objIntExp.Codigo < 1 Then
                        objIntExp.Codigo = intValue
                    End If
                    bss.Grabar(objIntExp)
            End Select
            'Grabar Libertad Subtipo
            Select Case objIntExp.DocumentoTipoID
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                    Dim val As Integer = -1
                    objIntExp.Codigo = intValue
                    val = Data.Registro.Expediente.GrabarSubtipoLibertad(strAccion, "ins_lib_tip", objIntExp)
            End Select
            Return intValue
        End Function

        Public Function Grabar_LM(objIntExp As Entity.Registro.Expediente) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            objIntExp.IngresoID = -1

            If Validar_LM(objIntExp) = False Then
                intValue = -1
                intValue = False
                Return intValue
            End If


            If objIntExp.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant2_LM"
            End If

            intValue = Data.Registro.Expediente.Grabar_LM(strAccion, strOpcion, objIntExp)

            Return intValue
        End Function

        Public Function GrabarTipoLibertad(objIntExp As Entity.Registro.Expediente, ExpedienteId As Integer, DocumentoTipoId As Integer, objTotalCol As Entity.General.ParametricaCol) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If DocumentoTipoId = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                objExpLib = New Entity.Registro.ExpedienteLibertadSubtipo
                With objExpLib
                    .ExpedienteId = ExpedienteId
                    .CreaDocJudicialId = objIntExp.CreaDocJudicialId
                    .InternoID = objIntExp.InternoID
                    .IngresoID = objIntExp.IngresoID
                    .IngresoInpeId = objIntExp.IngresoInpeId
                    .LibertadTipoID = objIntExp.LibertadTipoID
                    ._RegionId = objIntExp._RegionId
                    ._PenalId = objIntExp._PenalId
                End With

                Dim bss As New Bussines.General.Parametrica
                Dim objSubCol As New Entity.General.ParametricaCol
                objSubCol = bss.Listar(Type.Combo.ComboTipo.TipoAclaratoriaExpediente, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad, -1, -1, False, "")

                Select Case objIntExp.LibertadTipoID
                    Case 13, 14, 160
                        For Each variable As Entity.General.Parametrica In objSubCol
                            Dim valor As Boolean = False
                            Dim var1 As Integer = variable.Codigo
                            For Each var As Entity.General.Parametrica In objTotalCol
                                If variable.Codigo = var.Codigo Then
                                    valor = True
                                    objExpLib.LibertadSubTipoID = var.Codigo
                                    objExpLib.Estado = var.estado
                                    objExpLib.Codigo = Data.Registro.ExpedienteLibertadSubtipo.ListarOutput("lst", "lst_validar_libertad_subtipo", objExpLib)

                                    If objExpLib.Codigo < 1 Then
                                        strAccion = "ins"
                                        strOpcion = "ins_lib_tip"
                                    Else
                                        strAccion = "upd"
                                        strOpcion = "upd_mant"
                                    End If

                                    intValue = Data.Registro.ExpedienteLibertadSubtipo.GrabarSubtipoLibertad(strAccion, strOpcion, objExpLib)
                                End If
                            Next
                            If valor = False Then
                                objExpLib.LibertadSubTipoID = variable.Codigo
                                objExpLib.Estado = variable.estado
                                objExpLib.Codigo = Data.Registro.ExpedienteLibertadSubtipo.ListarOutput("lst", "lst_validar_libertad_subtipo", objExpLib)

                                strAccion = "upd"
                                strOpcion = "upd_mant"
                                objExpLib.Estado = 0
                                intValue = Data.Registro.ExpedienteLibertadSubtipo.GrabarSubtipoLibertad(strAccion, strOpcion, objExpLib)
                            End If
                        Next
                    Case Else
                        strAccion = "upd"
                        strOpcion = "upd_mant"
                        Dim objCol As New Entity.Registro.ExpedienteLibertadSubtipoCol
                        objCol = Listar(objExpLib)
                        For Each obj As Entity.Registro.ExpedienteLibertadSubtipo In objCol
                            obj.Estado = 0
                            intValue = Data.Registro.ExpedienteLibertadSubtipo.GrabarSubtipoLibertad(strAccion, strOpcion, obj)
                        Next
                End Select
            End If

            Return intValue
        End Function


        Public Function Grabar(ByVal Codigo As Integer,
           ByVal SituacionJuridicaID As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_sit_juridica"

            intValue = Data.Registro.Expediente.GrabarF(strAccion, strOpcion, Codigo,
            -1, -1, 0, -1, -1, "", "", "", 0, 0, SituacionJuridicaID, 0, "",
            -1, -1, "", "", "", "", "", 0, 0, -1, 0, "", -1, -1, 1,
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function
        Public Function GrabarLibertad(ByVal Codigo As Integer,
        ByVal IngresoID As Integer,
        ByVal InternoID As Integer,
        ByVal DistritoJudicialID As Integer, ByVal SalaJuzgadoID As Integer,
        ByVal AutoridadOtro As String, ByVal AutoridadCargoOtro As String,
        ByVal Juez As String, ByVal EgresoSecretario As String, ByVal DocumentoLibertad As String,
        ByVal EgresoFechaDocRecepcion As Long, ByVal DocLibFecha As Long,
        ByVal TipoLibertad As Integer, ByVal FechaLibertad As Long, ByVal ObsLibertad As String, RegionId As Integer, PenalID As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If ValidarInterno(InternoID) = False Then
                intValue = -1
                intValue = False
                Return intValue
            End If

            If FechaLibertad > 0 Then
                If ValidarFechaIngreso(InternoID, IngresoID, FechaLibertad) = False Then
                    intValue = -1
                    intValue = False
                    Return intValue
                End If
            End If

            strAccion = "upd"
            strOpcion = "upd_egreso"

            intValue = Data.Registro.Expediente.Grabar(strAccion, strOpcion, Codigo,
            IngresoID,
            InternoID,
            False, -1, -1, "", "", "", 0, 0, -1, "",
            DistritoJudicialID, SalaJuzgadoID, AutoridadOtro, AutoridadCargoOtro,
            Juez, EgresoSecretario, DocumentoLibertad, EgresoFechaDocRecepcion, DocLibFecha,
            TipoLibertad, FechaLibertad, ObsLibertad, RegionId, PenalID, 1,
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function

        Public Function ActualizarSentenciaMayorPena(objIntExp As Entity.Registro.Expediente) As Integer
            Dim intValue As Integer = -1
            If objIntExp.InternoID = -1 Then
                Return -1
            End If
            intValue = Data.Registro.Expediente.Grabar("upd", "upd_sentencia_mayor_pena", objIntExp)
            Return intValue
        End Function

        Public Function ActualizarSentenciaMayorPena_LM(objIntExp As Entity.Registro.Expediente) As Integer
            Dim intValue As Integer = -1
            If objIntExp.InternoID = -1 Then
                Return -1
            End If
            intValue = Data.Registro.Expediente.Grabar("upd", "upd_sentencia_mayor_pena_LM", objIntExp)
            Return intValue
        End Function

        Public Function UpdateAnulacion(objIntExp As Entity.Registro.Expediente) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntExp.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_anu"
            End If

            intValue = Data.Registro.Expediente.Grabar(strAccion, strOpcion, objIntExp)

            Return intValue
        End Function

        Public Function UpdateAnulacion_LM(objIntExp As Entity.Registro.Expediente) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntExp.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_anu"
            End If

            intValue = Data.Registro.Expediente.Grabar_LM(strAccion, strOpcion, objIntExp)

            Return intValue
        End Function
        Public Function UpdateAnulacionTotal_LM(objIntExp As Entity.Registro.Expediente) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntExp.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_anu_tot"
            End If

            intValue = Data.Registro.Expediente.Grabar_LM(strAccion, strOpcion, objIntExp)

            Return intValue
        End Function

        Public Function UpdateDmpSmp(objIntExp As Entity.Registro.Expediente) As Integer

            Dim intValue As Integer = -1

            If objIntExp.Codigo > 0 Then
                Dim strAccion As String = "upd"
                Dim strOpcion As String = "upd_dmp_smp"

                intValue = Data.Registro.Expediente.Grabar(strAccion, strOpcion, objIntExp)
            End If
            Return intValue
        End Function
        '18-06-2014-> hnrb
        Public Function GrabarEstadoVisibilidad(ExpeId As Integer, RegistroVisible As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "upd"
            strOpcion = "upd_estado_visibilidad_exp"
            Dim entExp As New Entity.Registro.Expediente
            entExp.Codigo = ExpeId
            entExp.ExpedienteVisible = RegistroVisible
            intValue = Data.Registro.Expediente.Grabar(strAccion, strOpcion, entExp)

            Return intValue
        End Function
        Public Function GrabarEstadoVisibilidad_LM(ExpeId As Integer, RegistroVisible As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "upd"
            strOpcion = "upd_estado_visibilidad_exp"
            Dim entExp As New Entity.Registro.Expediente
            entExp.Codigo = ExpeId
            entExp.ExpedienteVisible = RegistroVisible
            entExp.FlagTransferenciaSede = FlagTransferenciaSede
            intValue = Data.Registro.Expediente.Grabar_LM(strAccion, strOpcion, entExp)

            Return intValue
        End Function
        Public Function GrabarQuedaExp(objIntExp As Entity.Registro.ExpedienteCol, Exp_Jud_Id As Integer) As Integer
            Dim intValue As Integer
            intValue = Data.Registro.Expediente.GrabarQuedaExp("ins", "ins_queda_exp", objIntExp, Exp_Jud_Id)
            Return intValue
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.Expediente.Eliminar(strAccion, strOpcion, Codigo, FlagTransferenciaSede)

            Return intValue

        End Function
        Public Function Eliminar2(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.Expediente.Eliminar(strAccion, strOpcion, Codigo, FlagTransferenciaSede)

            Return intValue

        End Function
        Public Function Eliminar_LM(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant_LM"
            intValue = Data.Registro.Expediente.Eliminar(strAccion, strOpcion, Codigo, FlagTransferenciaSede)

            Return intValue

        End Function
        Public Function EliminarQuedaExp(Exp_Jud_Id As Integer) As Integer
            Dim intValue As Integer
            intValue = Data.Registro.Expediente.EliminarQuedaExp("del", "del_queda_exp", Exp_Jud_Id)
            Return intValue
        End Function
#End Region
    End Class
End Namespace