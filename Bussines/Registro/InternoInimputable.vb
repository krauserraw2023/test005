Imports System.Data
Imports System.Data.SqlClient
Imports Type.Enumeracion.Licencia
Namespace Registro
    Public Class InternoInimputable
        Private objEnt As Entity.Registro.Expediente = Nothing
        Private objEntCol As Entity.Registro.ExpedienteCol = Nothing
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

        Public Function ListarF(ByVal Codigo As Integer, ByVal IngreoId As Integer, ByVal InternoId As Integer,
      ByVal AutoridadJudicialId As Integer, ByVal SalaJudicialId As Integer, ByVal ExpedienteNumero As String,
      ByVal ExpedienteFecha As Long, ByVal SituacionJuridicaId As Integer, Optional ByVal RegistroVisible As Integer = -1) As Entity.Registro.ExpedienteCol
            'Version antigua
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_grillaF", Codigo,
            IngreoId, InternoId, AutoridadJudicialId, SalaJudicialId, ExpedienteNumero, ExpedienteFecha, SituacionJuridicaId, RegistroVisible)
            Try
                objEntCol = New Entity.Registro.ExpedienteCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                            .SalaJudicialID = sqlDr("sal_jus_id").ToString
                            .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteJuez = sqlDr("int_exp_jue").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
                            .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
                            .Observacion = sqlDr("int_exp_obs").ToString
                            '/*libertad*/                            
                            .LibertadTipoID = sqlDr("tip_lib_id").ToString
                            .FechaLibertad = sqlDr("int_lib_fec").ToString
                            .Estado = sqlDr("int_exp_est").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
                            '.SentenciaConcatenado = ""
                            'auditoria
                            .Audit_UsuarioCreacion = sqlDr("_usu_cre_nom").ToString
                            .Audit_UsuarioModificacion = sqlDr("_usu_mod_nom").ToString
                            .Audit_FechaCreacion = sqlDr("_fec_cre").ToString
                            .Audit_FechaModificacion = sqlDr("_fec_mod").ToString
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
        Public Function Listar_v2(ByVal EntExp As Entity.Registro.Expediente) As Entity.Registro.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Expediente.Listar(sqlCon, "lst", "lst_mant_v2", EntExp)

            Dim objEntColtmp = New Entity.Registro.ExpedienteCol


            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Expediente
                        With objEnt
                            .Codigo = sqlDr("int_exp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
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
                            ._RegionId = sqlDr("reg_id").ToString
                            ._PenalId = sqlDr("pen_id").ToString()
                            .EstadoEjecucion = sqlDr("est_eje_trs_id").ToString()
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
                            ._RegionId = sqlDr("reg_id").ToString
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
                            .EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
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
                            '.SentenciaConcatenado = ""
                            .ExpedienteVisible = sqlDr("int_exp_visible").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .Flagrancia = sqlDr("int_exp_flag").ToString
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

#End Region

#Region "Grabar"
        Public Function Grabar(objDoc As Entity.Registro.DocumentoJudicial) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim objInim As New Entity.Registro.InternoInimputable
            With objInim
                .InternoID = objDoc.InternoId
                .IngresoID = objDoc.InternoIngresoId
                .IngresoInpeId = objDoc.IngresoInpeId
                .CreaDocJudicialId = objDoc.Codigo
                .DocumentoJudicialNum = objDoc.DocumentoNumero
                .MotivoIngresoID = objDoc.MovimientoMotivoId
                '.EstablecimientomentalId = objDoc.EstablecimientomentalId
                .EstadoEjecucion = objDoc.EstadoEjecucionId
                ._PenalId = objDoc._PenalID
                ._RegionId = objDoc._RegionID
            End With

            'If objDoc.Codigo < 1 Then
            strAccion = "ins"
            strOpcion = "ins_mant" 'referencia a version 2->hnrb
            'Else
            '    strAccion = "upd"
            '    strOpcion = "upd_mant"
            'End If

            intValue = Data.Registro.InternoInimputable.Grabar(strAccion, strOpcion, objInim)

            Return intValue
        End Function
        Public Function Grabar(objExp As Entity.Registro.Expediente) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim objInim As New Entity.Registro.InternoInimputable
            With objInim
                .InternoID = objExp.InternoID
                .IngresoID = objExp.IngresoID
                .IngresoInpeId = objExp.IngresoInpeId
                .Codigo = objExp.Codigo
                .CreaDocJudicialId = objExp.CreaDocJudicialId
                .ExpedienteNumero = objExp.ExpedienteNumero
                .DocumentoJudicialNum = ""
                .MotivoIngresoID = -1
                .EstablecimientomentalId = objExp.EstablecimientomentalId
                '.EstadoEjecucion = objExp.EstadoEjecucionId
                ._PenalId = objExp._PenalId
                ._RegionId = objExp._RegionId
            End With

            'If objDoc.Codigo < 1 Then
            strAccion = "ins"
            strOpcion = "ins_mant" 'referencia a version 2->hnrb


            intValue = Data.Registro.InternoInimputable.Grabar(strAccion, strOpcion, objInim)

            Return intValue
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, InternoId As Integer, FlagTransferenciaSede As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = "del"
            Dim strOpcion As String = "del_mant"
            intValue = Data.Registro.InternoInimputable.Eliminar(strAccion, strOpcion, Codigo, InternoId, FlagTransferenciaSede)

            Return intValue

        End Function


#End Region
    End Class
End Namespace