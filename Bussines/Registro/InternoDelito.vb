Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Imports Type.Enumeracion.Licencia
Namespace Registro
    Public Class Delito
        Private objEnt As Entity.Registro.Delito = Nothing
        Private objEntCol As Entity.Registro.DelitoCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Delito

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar(sqlCon, "lst", "lst_mant", _
            Codigo, -1, -1, -1, -1, -1)
            objEnt = New Entity.Registro.Delito
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_del_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .DelitoGenerico = sqlDr("int_del_gen_id").ToString
                            .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
                            .DelitoEspecificoEstado = sqlDr("del_esp_est").ToString
                            .Observacion = sqlDr("int_del_obs").ToString
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
            End Try

            Return objEnt
        End Function

        Public Function Listar(ByVal DelitoID As Integer, _
        ByVal IngresoID As Integer, _
        ByVal InternoID As Integer, ByVal ExpedienteID As Integer, _
        ByVal DelitoGenericoID As Integer, _
        ByVal DelitoEspecificoID As Integer) As Entity.Registro.DelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar(sqlCon, "lst", "lst_mant", DelitoID, _
            IngresoID, _
            InternoID, ExpedienteID, _
            DelitoGenericoID, _
            DelitoEspecificoID)

            Try
                objEntCol = New Entity.Registro.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Delito
                        With objEnt
                            .Codigo = sqlDr("int_del_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .DelitoGenerico = sqlDr("int_del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .Estado = sqlDr("int_del_est").ToString
                            .DelitoMayorPena = sqlDr("int_del_dmp").ToString
                            .DelitoSentenciaMayorPena = sqlDr("int_del_sen_dmp").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Observacion = sqlDr("int_del_obs").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
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
                Dim s As String = ""
                s = ex.Message
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

        Public Function Listar_LM(ByVal DelitoID As Integer, _
        ByVal IngresoID As Integer, _
        ByVal IngresoInpeID As Integer, _
        ByVal InternoID As Integer, ByVal ExpedienteID As Integer, _
        ByVal DelitoGenericoID As Integer, _
        ByVal DelitoEspecificoID As Integer) As Entity.Registro.DelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar_LM(sqlCon, "lst", "lst_mant_lm", DelitoID, _
            IngresoID, IngresoInpeID, _
            InternoID, ExpedienteID, _
            DelitoGenericoID, _
            DelitoEspecificoID)

            Try
                objEntCol = New Entity.Registro.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Delito
                        With objEnt
                            .Codigo = sqlDr("int_del_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .DelitoGenerico = sqlDr("int_del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .Estado = sqlDr("int_del_est").ToString
                            .DelitoMayorPena = sqlDr("int_del_dmp").ToString
                            .DelitoSentenciaMayorPena = sqlDr("int_del_sen_dmp").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Observacion = sqlDr("int_del_obs").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
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
                Dim s As String = ""
                s = ex.Message
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

        Public Function Listar2(objDelito As Entity.Registro.Delito) As Entity.Registro.DelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar(sqlCon, "lst", "lst_mant2",objDelito)

            Try
                objEntCol = New Entity.Registro.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Delito
                        With objEnt
                            .Codigo = sqlDr("int_del_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .DelitoGenerico = sqlDr("int_del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .Estado = sqlDr("int_del_est").ToString
                            .DelitoMayorPena = sqlDr("int_del_dmp").ToString
                            .DelitoSentenciaMayorPena = sqlDr("int_del_sen_dmp").ToString
                            .DelitoArticulo = sqlDr("del_art_nom_cor").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Observacion = sqlDr("int_del_obs").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .CodigodelitoPad = sqlDr("fk_int_del_pad_ref_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .DocumentoTipoPadID = sqlDr("pad_doc_tip_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

            End Try
            Return objEntCol
        End Function

        'Listar2 '
        Public Function Listar2_LM(objDelito As Entity.Registro.Delito) As Entity.Registro.DelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar_LM(sqlCon, "lst", "lst_mant_v2_LM", objDelito)

            Try
                objEntCol = New Entity.Registro.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Delito
                        With objEnt
                            .Codigo = sqlDr("int_del_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .DelitoGenerico = sqlDr("int_del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .Estado = sqlDr("int_del_est").ToString
                            .DelitoMayorPena = sqlDr("int_del_dmp").ToString
                            .DelitoSentenciaMayorPena = sqlDr("int_del_sen_dmp").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Observacion = sqlDr("int_del_obs").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .CodigodelitoPad = sqlDr("fk_int_del_pad_ref_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .DocumentoTipoPadID = sqlDr("doc_tip_pad_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

            End Try
            Return objEntCol
        End Function
        'Listar2 '
        Public Function Listar_ant_LM(objDelito As Entity.Registro.Delito) As Entity.Registro.DelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar_LM(sqlCon, "lst", "lst_mant_ant_LM", objDelito)

            Try
                objEntCol = New Entity.Registro.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Delito
                        With objEnt
                            .Codigo = sqlDr("int_del_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .DelitoGenerico = sqlDr("int_del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .Estado = sqlDr("int_del_est").ToString
                            .DelitoMayorPena = sqlDr("int_del_dmp").ToString
                            .DelitoSentenciaMayorPena = sqlDr("int_del_sen_dmp").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Expedientenumero = sqlDr("int_ing_exp_num").ToString
                            .Observacion = sqlDr("int_del_obs").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .Anulacion = sqlDr("n_est_anu").ToString
                            .CodigodelitoPad = sqlDr("fk_int_del_pad_ref_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

            End Try
            Return objEntCol
        End Function
        Public Function Listar_ant2(objDelito As Entity.Registro.Delito) As Entity.Registro.DelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar_LM(sqlCon, "lst", "lst_mant_ant2", objDelito)

            Try
                objEntCol = New Entity.Registro.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Delito
                        With objEnt
                            .Codigo = sqlDr("int_del_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .DelitoGenerico = sqlDr("int_del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .Estado = sqlDr("int_del_est").ToString
                            .DelitoMayorPena = sqlDr("int_del_dmp").ToString
                            .DelitoSentenciaMayorPena = sqlDr("int_del_sen_dmp").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Expedientenumero = sqlDr("int_ing_exp_num").ToString
                            .Observacion = sqlDr("int_del_obs").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .Anulacion = sqlDr("n_int_del_est_anu").ToString
                            .CodigodelitoPad = sqlDr("fk_int_del_pad_ref_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .AgraviadoId = sqlDr("int_agr_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            .AgraviadoObservacion = sqlDr("int_agr_obs").ToString
                            .AgraviadoPadre = sqlDr("fk_int_agr_pad_ref_id").ToString
                            .AgraviadoAnulacion = sqlDr("n_int_agr_est_anu").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

            End Try
            Return objEntCol
        End Function
        Public Function Listar_ant2_LM(objDelito As Entity.Registro.Delito) As Entity.Registro.DelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar_LM(sqlCon, "lst", "lst_mant_ant2_LM", objDelito)

            Try
                objEntCol = New Entity.Registro.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Delito
                        With objEnt
                            .Codigo = sqlDr("int_del_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .DelitoGenerico = sqlDr("int_del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .Estado = sqlDr("int_del_est").ToString
                            .DelitoMayorPena = sqlDr("int_del_dmp").ToString
                            .DelitoSentenciaMayorPena = sqlDr("int_del_sen_dmp").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Expedientenumero = sqlDr("int_ing_exp_num").ToString
                            .Observacion = sqlDr("int_del_obs").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .Anulacion = sqlDr("n_int_del_est_anu").ToString
                            .CodigodelitoPad = sqlDr("fk_int_del_pad_ref_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .AgraviadoId = sqlDr("int_agr_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            .AgraviadoObservacion = sqlDr("int_agr_obs").ToString
                            .AgraviadoPadre = sqlDr("fk_int_agr_pad_ref_id").ToString
                            .AgraviadoAnulacion = sqlDr("n_int_agr_est_anu").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

            End Try
            Return objEntCol
        End Function
        Public Function Listar_DelitosMayorPena(objDelito As Entity.Registro.Delito) As Entity.Registro.DelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar_LM(sqlCon, "lst", "lst_mant_ant2_LM", objDelito)

            Try
                objEntCol = New Entity.Registro.DelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Delito
                        With objEnt
                            .Codigo = sqlDr("int_del_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .DelitoGenerico = sqlDr("int_del_gen_id").ToString
                            .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .Estado = sqlDr("int_del_est").ToString
                            .DelitoMayorPena = sqlDr("int_del_dmp").ToString
                            .DelitoSentenciaMayorPena = sqlDr("int_del_sen_dmp").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Expedientenumero = sqlDr("int_ing_exp_num").ToString
                            .Observacion = sqlDr("int_del_obs").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
                            .Anulacion = sqlDr("n_int_del_est_anu").ToString
                            .CodigodelitoPad = sqlDr("fk_int_del_pad_ref_id").ToString
                            .DocumentoTipoID = sqlDr("doc_tip_id").ToString
                            .AgraviadoId = sqlDr("int_agr_id").ToString
                            .AgraviadoNombre = sqlDr("int_agr_nom").ToString
                            .AgraviadoObservacion = sqlDr("int_agr_obs").ToString
                            .AgraviadoPadre = sqlDr("fk_int_agr_pad_ref_id").ToString
                            .AgraviadoAnulacion = sqlDr("n_int_agr_est_anu").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

            End Try
            Return objEntCol
        End Function

#End Region
#Region "Validar"
        Private Function Validar(objEnt As Entity.Registro.Delito) As Boolean
            If objEnt.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Interno [Delito]")
                Return False
            End If
            If Not (objEnt._TipoLicencia = enmTipoLicencia.Carceleta Or objEnt._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or objEnt._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then
                If objEnt.IngresoID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Ingreso [Delito]")
                    Return False
                End If
            End If
            If objEnt.RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Region [Delito]")
                Return False
            End If
  
            Return True
        End Function

        Private Function Validar_LM(objEnt As Entity.Registro.Delito) As Boolean
            If objEnt.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Interno [Delito]")
                Return False
            End If
            If objEnt.IngresoInpeId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Ingreso [Delito]")
                Return False
            End If
            If objEnt.RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Region [Delito]")
                Return False
            End If
            Return True
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Registro.Delito) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If Validar(objEnt) = True Then
                If objEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If
                intValue = Data.Registro.InternoDelito.Grabar(strAccion, strOpcion, objEnt)
            Else
                Return -2
            End If
            Return intValue
        End Function

        Public Function Grabar_v2(ByVal objEnt As Entity.Registro.Delito) As Integer

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
                intValue = Data.Registro.InternoDelito.Grabar_V2(strAccion, strOpcion, objEnt)
            Else
                Return -2
            End If
            Return intValue
        End Function

        'Grabar_v2
        Public Function Grabar_LM(ByVal objEnt As Entity.Registro.Delito) As Integer

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
                    strOpcion = "upd_mant_v2_LM"
                End If
                intValue = Data.Registro.InternoDelito.Grabar_LM(strAccion, strOpcion, objEnt)
            Else
                Return -2
            End If
            Return intValue
        End Function

        Public Function Grabar_Anu(ByVal objEnt As Entity.Registro.Delito) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_mant_anu"
            End If
            intValue = Data.Registro.InternoDelito.Grabar_V2(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        Public Function Grabar_Anu_LM(ByVal objEnt As Entity.Registro.Delito) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_mant_anu"
            End If
            intValue = Data.Registro.InternoDelito.Grabar_LM(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        Public Function ActualizarDelitoMayorPena(ByVal objEnt As Entity.Registro.Delito) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_delito_mayor_pena" 'se llama a parte del store de INTERNODELITO
            End If

            intValue = Data.Registro.InternoDelito.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function


        Public Function ActualizarDelitoMayorPena_LM(ByVal objEnt As Entity.Registro.Delito) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_delito_mayor_pena_LM" 'se llama a parte del store de INTERNODELITO
            End If

            intValue = Data.Registro.InternoDelito.Grabar_LM(strAccion, strOpcion, objEnt)

            Return intValue
        End Function


        Public Function ActualizarSentenciaMayorPena(ByVal objEnt As Entity.Registro.Delito) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_sentencia_mayor_pena" 'se llama a parte del store de INTERNODELITO
            End If

            intValue = Data.Registro.InternoDelito.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        Public Function ActualizarSentenciaMayorPena_v5(ByVal objEnt As Entity.Registro.Delito) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_sentencia_mayor_pena_v5" 'se llama a parte del store de INTERNODELITO
            End If

            intValue = Data.Registro.InternoDelito.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        'ActualizarSentenciaMayorPena_v5
        Public Function ActualizarSentenciaMayorPena_LM(ByVal objEnt As Entity.Registro.Delito) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_sentencia_mayor_pena_LM" 'se llama a parte del store de INTERNODELITO
            End If

            intValue = Data.Registro.InternoDelito.Grabar_LM(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        Public Function GrabarEstado(ByVal Codigo As Integer, ByVal Estado As Integer, Optional n_FlagTransferSede As Integer = 0) As Integer

            'hnrb->24/05/2014-> anula el delito sin un doc de anulacion

            Dim intValue As Integer = -1
            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_anulacion"
            Dim entDel As New Entity.Registro.Delito
            entDel.Codigo = Codigo
            entDel.Estado = Estado
            'entDel.FlagTransferenciaSede = n_FlagTransferSede
            intValue = Data.Registro.InternoDelito.Grabar(strAccion, strOpcion, entDel)
            Return intValue
        End Function

        Public Sub GrabarPadinDelito(ObjDel As Entity.Registro.Delito, intIdDel As Integer)

            Dim bss As New Bussines.Estadistica.PadinDelito
            Dim obj As New Entity.Estadistica.PadinDelito
            With ObjDel
                obj.InternoDelitoId = intIdDel
                obj.InternoId = .InternoID
                obj.IngresoId = .IngresoID
                obj.DelitoEspecificoNombre = .DelitoEspecificoNombre
                obj.DelitoGenericoNombre = .DelitoGenericoNombre
                obj.ExpedienteNumero = .Expedientenumero
                obj.DocumentoJudicialId = .CreaDocJudicialId
                obj.RegionID = .RegionID
                obj.PenalID = .PenalID
            End With
            If ObjDel.DelitoMayorPena = True Then
                obj.TipoSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
                obj.DelitoMayorPena = True
                bss.Grabar(obj)
            End If
            If ObjDel.DelitoSentenciaMayorPena = True Then
                obj.TipoSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
                obj.DelitoSentenciaMayorPena = True
                bss.Grabar(obj)
            End If

        End Sub

#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, Optional n_FlagTransferSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.InternoDelito.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo, n_FlagTransferSede)

            Return intValue

        End Function
        Public Function Eliminar2(ByVal Codigo As Integer, Optional n_FlagTransferSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant_v2"
            intValue = Data.Registro.InternoDelito.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo, n_FlagTransferSede)

            Return intValue

        End Function
#End Region
    End Class
End Namespace