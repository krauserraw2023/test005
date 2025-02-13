Imports System.Data
Imports System.Data.SqlClient
Imports Type.Enumeracion.Licencia
Namespace Registro
    Public Class InternoAgraviado
        Private objEnt As Entity.Registro.Agraviado = Nothing
        Private objEntCol As Entity.Registro.AgraviadoCol = Nothing
#Region "Listar"
        
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Agraviado

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.internoAgraviado.Listar(sqlCon, "lst", "lst_mant", Codigo, _
            -1, -1, -1, -1, -1, "", 0, 0)

            objEnt = New Entity.Registro.Agraviado
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_agr_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DelitoID = sqlDr("int_del_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            '.SentenciaDocumento = sqlDr("int_sen_doc").ToString
                            '.SentenciaFecha = sqlDr("int_sen_fec").ToString
                            '.AutoridadJudicial = sqlDr("aut_jud_id").ToString
                            '.SalaJudicial = sqlDr("sal_jud_id").ToString
                            '.CadenaPerpetua = sqlDr("int_agr_cad_per").ToString
                            '.FechaIni = sqlDr("int_agr_fec_ini").ToString
                            '.FechaFin = sqlDr("int_agr_fec_fin").ToString
                            '.SentenciaAnio = sqlDr("int_sen_anio").ToString
                            '.SentenciaMes = sqlDr("int_sen_mes").ToString
                            '.SentenciaDia = sqlDr("int_sen_dia").ToString
                            .Observacion = sqlDr("int_agr_obs").ToString
                            .Estado = sqlDr("int_agr_est").ToString
                            .Audit_UsuarioCreacion = sqlDr("_usu_cre").ToString
                            .Audit_UsuarioModificacion = sqlDr("_usu_mod").ToString
                            .Audit_FechaCreacion = sqlDr("_fec_cre").ToString
                            .Audit_FechaModificacion = sqlDr("_fec_mod").ToString
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

        Public Function Listar(ByVal Codigo As Integer, _
        ByVal DelitoID As Integer, ByVal InternoID As Integer, _
        ByVal IngresoID As Integer, ByVal ExpedienteID As Integer, ByVal SentenciaID As Integer, _
        ByVal Agraviado As String) As Entity.Registro.AgraviadoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.internoAgraviado.Listar(sqlCon, "lst", "lst_mant", Codigo, _
            DelitoID, InternoID, IngresoID, ExpedienteID, SentenciaID, Agraviado, 0, 0)

            Try
                objEntCol = New Entity.Registro.AgraviadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = sqlDr("int_agr_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DelitoID = sqlDr("int_del_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            '.SentenciaDocumento = sqlDr("int_sen_doc").ToString
                            '.SentenciaFecha = sqlDr("int_sen_fec").ToString
                            '.AutoridadJudicial = sqlDr("aut_jud_id").ToString
                            '.AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                            '.SalaJudicial = sqlDr("sal_jud_id").ToString
                            '.CadenaPerpetua = sqlDr("int_agr_cad_per").ToString
                            '.FechaIni = sqlDr("int_agr_fec_ini").ToString
                            '.FechaFin = sqlDr("int_agr_fec_fin").ToString
                            '.SentenciaAnio = sqlDr("int_sen_anio").ToString
                            '.SentenciaMes = sqlDr("int_sen_mes").ToString
                            '.SentenciaDia = sqlDr("int_sen_dia").ToString
                            .Observacion = sqlDr("int_agr_obs").ToString
                            .Estado = sqlDr("int_agr_est").ToString
                            'Auditoria
                            .Audit_UsuarioCreacion = sqlDr("_usu_cre").ToString
                            .Audit_UsuarioModificacion = sqlDr("_usu_mod").ToString
                            .Audit_FechaCreacion = sqlDr("_fec_cre").ToString
                            .Audit_FechaModificacion = sqlDr("_fec_mod").ToString
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

        Public Function Listar_LM(entEnt As Entity.Registro.Agraviado) As Entity.Registro.AgraviadoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.internoAgraviado.Listar(sqlCon, "lst", "lst_mant_v2_LM", entEnt)

            Try
                objEntCol = New Entity.Registro.AgraviadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = sqlDr("int_agr_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DelitoID = sqlDr("int_del_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            .Observacion = sqlDr("int_agr_obs").ToString
                            .Estado = sqlDr("int_agr_est").ToString

                            .TipoResolucionId = sqlDr("fk_tip_res_id").ToString
                            .TipoResolucionNom = sqlDr("tip_res_nom").ToString
                            .TipoSentenciaId = sqlDr("fk_tip_sent_id").ToString
                            .TipoSentenciaNombre = sqlDr("nom_tip_sent").ToString
                            .TipoSentenciaHistoricoId = sqlDr("fk_tip_sent_hist_id").ToString
                            .TipoSentenciaHistoricoNombre = sqlDr("nom_tip_sent_hist").ToString
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id")
                            .CodigoagraviadoPad = sqlDr("fk_int_agr_pad_ref_id")
                            .DocumentoTipoID = sqlDr("doc_tip_id")
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

        Public Function Listar_ant(entEnt As Entity.Registro.Agraviado) As Entity.Registro.AgraviadoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.internoAgraviado.Listar_lm(sqlCon, "lst", "lst_mant_ant", entEnt)

            Try
                objEntCol = New Entity.Registro.AgraviadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = sqlDr("int_agr_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DelitoID = sqlDr("int_del_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            .Observacion = sqlDr("int_agr_obs").ToString
                            .Estado = sqlDr("int_agr_est").ToString

                            .TipoResolucionId = sqlDr("fk_tip_res_id").ToString
                            .TipoResolucionNom = sqlDr("tip_res_nom").ToString
                            .TipoSentenciaId = sqlDr("fk_tip_sent_id").ToString
                            .TipoSentenciaNombre = sqlDr("nom_tip_sent").ToString
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id")
                            .CodigoagraviadoPad = sqlDr("fk_int_agr_pad_ref_id")
                            .DocumentoTipoID = sqlDr("doc_tip_id")
                            .DelitoEspecificoID = sqlDr("int_del_esp_id")
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

        Public Function Listar_ant_LM(entEnt As Entity.Registro.Agraviado) As Entity.Registro.AgraviadoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.internoAgraviado.Listar_lm(sqlCon, "lst", "lst_mant_ant_LM", entEnt)

            Try
                objEntCol = New Entity.Registro.AgraviadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = sqlDr("int_agr_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DelitoID = sqlDr("int_del_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            .Observacion = sqlDr("int_agr_obs").ToString
                            .Estado = sqlDr("int_agr_est").ToString

                            .TipoResolucionId = sqlDr("fk_tip_res_id").ToString
                            .TipoResolucionNom = sqlDr("tip_res_nom").ToString
                            .TipoSentenciaId = sqlDr("fk_tip_sent_id").ToString
                            .TipoSentenciaNombre = sqlDr("nom_tip_sent").ToString
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id")
                            .CodigoagraviadoPad = sqlDr("fk_int_agr_pad_ref_id")
                            .DocumentoTipoID = sqlDr("doc_tip_id")
                            .DelitoEspecificoID = sqlDr("int_del_esp_id")
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

        Public Function Listar(entEnt As Entity.Registro.Agraviado) As Entity.Registro.AgraviadoCol
            'abc
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.internoAgraviado.Listar(sqlCon, "lst", "lst_mant2", entEnt)

            Try
                objEntCol = New Entity.Registro.AgraviadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = sqlDr("int_agr_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DelitoID = sqlDr("int_del_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            .Observacion = sqlDr("int_agr_obs").ToString
                            .Estado = sqlDr("int_agr_est").ToString
                            .TipoSentenciaId = sqlDr("fk_tip_sent_id").ToString
                            .TipoSentenciaNombre = sqlDr("nom_tip_sent").ToString
                            .TipoResolucionId = sqlDr("fk_tip_res_id").ToString
                            .TipoResolucionNom = sqlDr("tip_res_nom").ToString
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id")
                            .CodigoagraviadoPad = sqlDr("fk_int_agr_pad_ref_id")
                            .DocumentoTipoID = sqlDr("doc_tip_id")
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
        Public Function Listar2(entExpedient As Entity.Registro.Expediente) As Entity.Registro.AgraviadoCol
            'listar 4-1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.internoAgraviado.Listar2(sqlCon, "lst", "lst_mant3", entExpedient)

            Try
                objEntCol = New Entity.Registro.AgraviadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = sqlDr("int_agr_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DelitoID = sqlDr("int_del_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            '.SentenciaDocumento = sqlDr("int_sen_doc").ToString
                            '.SentenciaFecha = sqlDr("int_sen_fec").ToString
                            '.AutoridadJudicial = sqlDr("aut_jud_id").ToString
                            '.AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                            '.SalaJudicial = sqlDr("sal_jud_id").ToString
                            '.CadenaPerpetua = sqlDr("int_agr_cad_per").ToString
                            '.FechaIni = sqlDr("int_agr_fec_ini").ToString
                            '.FechaFin = sqlDr("int_agr_fec_fin").ToString
                            '.SentenciaAnio = sqlDr("int_sen_anio").ToString
                            '.SentenciaMes = sqlDr("int_sen_mes").ToString
                            '.SentenciaDia = sqlDr("int_sen_dia").ToString
                            .Observacion = sqlDr("int_agr_obs").ToString
                            .Estado = sqlDr("int_agr_est").ToString

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

        Public Function Listar_LM_v2(entExpedient As Entity.Registro.Expediente) As Entity.Registro.AgraviadoCol
            'listar 4-1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.internoAgraviado.Listar2(sqlCon, "lst", "lst_mant_lm_v3", entExpedient)

            Try
                objEntCol = New Entity.Registro.AgraviadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = sqlDr("int_agr_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DelitoID = sqlDr("int_del_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            '.SentenciaDocumento = sqlDr("int_sen_doc").ToString
                            '.SentenciaFecha = sqlDr("int_sen_fec").ToString
                            '.AutoridadJudicial = sqlDr("aut_jud_id").ToString
                            '.AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                            '.SalaJudicial = sqlDr("sal_jud_id").ToString
                            '.CadenaPerpetua = sqlDr("int_agr_cad_per").ToString
                            '.FechaIni = sqlDr("int_agr_fec_ini").ToString
                            '.FechaFin = sqlDr("int_agr_fec_fin").ToString
                            '.SentenciaAnio = sqlDr("int_sen_anio").ToString
                            '.SentenciaMes = sqlDr("int_sen_mes").ToString
                            '.SentenciaDia = sqlDr("int_sen_dia").ToString
                            .Observacion = sqlDr("int_agr_obs").ToString
                            .Estado = sqlDr("int_agr_est").ToString

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
        '/*JEU 17/12/2018 para anulacion*/
        Public Function Listar_v3(entAgraviado As Entity.Registro.Agraviado) As Entity.Registro.AgraviadoCol
            'listar 4-1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.internoAgraviado.Listar(sqlCon, "lst", "lst_mant_lm_v3", entAgraviado)

            Try
                objEntCol = New Entity.Registro.AgraviadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Agraviado
                        With objEnt
                            .Codigo = sqlDr("int_agr_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DelitoID = sqlDr("int_del_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            '.SentenciaDocumento = sqlDr("int_sen_doc").ToString
                            '.SentenciaFecha = sqlDr("int_sen_fec").ToString
                            '.AutoridadJudicial = sqlDr("aut_jud_id").ToString
                            '.AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                            '.SalaJudicial = sqlDr("sal_jud_id").ToString
                            '.CadenaPerpetua = sqlDr("int_agr_cad_per").ToString
                            '.FechaIni = sqlDr("int_agr_fec_ini").ToString
                            '.FechaFin = sqlDr("int_agr_fec_fin").ToString
                            '.SentenciaAnio = sqlDr("int_sen_anio").ToString
                            .CodigoagraviadoPad = sqlDr("fk_int_agr_pad_ref_id").ToString
                            .Observacion = sqlDr("int_agr_obs").ToString
                            .Anulacion = sqlDr("n_int_agr_est_anu").ToString
                            .Estado = sqlDr("int_agr_est").ToString
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
        Private Function Validar(objEnt As Entity.Registro.Agraviado) As Boolean
            If objEnt.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Interno [Agraviado]")
                Return False
            End If
            If Not (objEnt._TipoLicencia = enmTipoLicencia.Carceleta Or objEnt._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or objEnt._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then
                If objEnt.IngresoID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Ingreso [Agraviado]")
                    Return False
                End If
                If objEnt.PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Penal [Agraviado]")
                    Return False
                End If
            End If
            If objEnt.RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Region [Agraviado]")
                Return False
            End If
          
            Return True
        End Function

        Private Function Validar_LM(objEnt As Entity.Registro.Agraviado) As Boolean
            If objEnt.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro InternoId [Agraviado]")
                Return False
            End If
            If objEnt.IngresoInpeId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro IngresoInpeId")
                Return False
            End If
            'If objEnt.IngresoID < 1 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Ingreso [Agraviado]")
            '    Return False
            'End If
            If objEnt.RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Region [Agraviado]")
                Return False
            End If

            Return True
        End Function
#End Region
#Region "Grabar"
        
        Public Function Grabar(ByVal Codigo As Integer, ByVal InternoID As Integer, _
         ByVal IngresoID As Integer, ByVal ExpedienteID As Integer, ByVal DelitoID As Integer, _
         ByVal Agraviado As String, ByVal AnulacionID As Integer, ByVal Estado As Integer, _
         ByVal Observacion As String, IDRegion As Integer, IDPenal As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.internoAgraviado.Grabar(strAccion, strOpcion, _
            Codigo, InternoID, _
            IngresoID, ExpedienteID, DelitoID, _
            Agraviado, "", 0, -1, -1, _
            False, 0, 0, _
            1900, 0, 0, Observacion, _
            AnulacionID, _
            Estado, IDRegion, IDPenal)

            Return intValue

        End Function
        Public Function Grabar(objEnt As Entity.Registro.Agraviado) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If Validar(objEnt) = True Then
                If objEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_v2"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant_v2"
                End If

                intValue = Data.Registro.internoAgraviado.Grabar(strAccion, strOpcion, objEnt)
            Else
                Return -1
            End If
           
            Return intValue

        End Function

        Public Function Grabar_LM(objEnt As Entity.Registro.Agraviado) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            objEnt.IngresoID = -1
            If Validar_LM(objEnt) = True Then
                If objEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_LM"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant_v2"
                End If

                intValue = Data.Registro.internoAgraviado.Grabar_LM(strAccion, strOpcion, objEnt)
            Else
                Return -1
            End If

            Return intValue

        End Function
        'hnrb->24/05/2014-> anula el agraviado sin un doc de anulacion
        Public Function GrabarEstado(EntAgr As Entity.Registro.Agraviado) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_anulacion"
            intValue = Data.Registro.internoAgraviado.Grabar(strAccion, strOpcion, EntAgr)
            Return intValue
        End Function

        Public Function Grabar_Anu(ByVal objEnt As Entity.Registro.Agraviado) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_mant_anu"
            End If
            intValue = Data.Registro.internoAgraviado.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        Public Function Grabar_Anu_LM(ByVal objEnt As Entity.Registro.Agraviado) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_mant_anu"
            End If
            intValue = Data.Registro.internoAgraviado.Grabar_LM(strAccion, strOpcion, objEnt)

            Return intValue
        End Function
        
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, Optional n_FlagTransferSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.internoAgraviado.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo, n_FlagTransferSede)
            Return intValue
        End Function
#End Region
    End Class
End Namespace