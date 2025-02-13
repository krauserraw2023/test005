Imports System.Data
Imports System.Data.SqlClient

Namespace Registro
    Public Class AlertaSentenciaDetalle
        Private Shared strNameProcedure As String = "usp_rep_det_notificacion_sentencia"
#Region "Listar"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                       ByVal objDocJud As Entity.Registro.AlertaSentenciaDetalle) As SqlDataReader

            Dim objEntCol As Entity.Registro.AlertaSentenciaDetalleCol = Nothing
            Dim objEnt As Entity.Registro.AlertaSentenciaDetalle = Nothing
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 180 '3 minutos
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@cab_not_sen_id", SqlDbType.Int)).Value = objDocJud.Codigo
                    .Parameters.Add(New SqlParameter("@det_not_sen_id", SqlDbType.Int)).Value = objDocJud.CodigoDetalle
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objDocJud._RegionID
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objDocJud._PenalID
                    .Parameters.Add(New SqlParameter("@licenciaId", SqlDbType.Int)).Value = objDocJud._TipoLicencia
                    .Parameters.Add(New SqlParameter("@_fechastr", SqlDbType.VarChar, 20)).Value = objDocJud.FechaConsulta
                    .Parameters.Add(New SqlParameter("@n_ite", SqlDbType.Int)).Value = objDocJud.Item
                    .Parameters.Add(New SqlParameter("@estadoId", SqlDbType.Int)).Value = objDocJud.EstadoId
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

        Public Shared Function Listar2_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                       ByVal objDocJud As Entity.Registro.DocumentoJudicial) As SqlDataReader

            '27-05-2014 hnrb

            Dim objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
            Dim objEnt As Entity.Registro.DocumentoJudicial = Nothing
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 180 '3 minutos
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objDocJud.InternoId
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objDocJud.InternoIngresoId
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objDocJud.Codigo
                    .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objDocJud.DocumentoTipo
                    .Parameters.Add(New SqlParameter("@doc_subtip_id", SqlDbType.Int)).Value = objDocJud.DocumentoSubTipoId
                    .Parameters.Add(New SqlParameter("@doc_tip_cat", SqlDbType.Int)).Value = objDocJud.DocumentoCategoria
                    .Parameters.Add(New SqlParameter("@n_doc_jud_est_anu", SqlDbType.Int)).Value = objDocJud.IdDocumentoAntecedente
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objDocJud.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objDocJud._RegionID
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objDocJud._PenalID
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function
#End Region

#Region "Grabar"
        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.DocumentoJudicial) As Integer

            '22-05-2014 hnrb

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 300
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objEnt.DocumentoTipo
                            .Parameters.Add(New SqlParameter("@doc_jud_num", SqlDbType.VarChar, 500)).Value = objEnt.DocumentoNumero

                            .Parameters.Add(New SqlParameter("@doc_jud_num_aux", SqlDbType.VarChar, 500)).Value = objEnt.DocumentoNumeroTraslado
                            .Parameters.Add(New SqlParameter("@doc_jud_fec_rec", SqlDbType.BigInt)).Value = objEnt.DocumentoFechaRecepcion
                            .Parameters.Add(New SqlParameter("@doc_jud_fec", SqlDbType.BigInt)).Value = objEnt.DocumentoFecha
                            .Parameters.Add(New SqlParameter("@tip_aut_jud_id", SqlDbType.Int)).Value = objEnt.TipoAutoridadJudicial
                            .Parameters.Add(New SqlParameter("@dis_jud_id", SqlDbType.Int)).Value = objEnt.DistritoJudicial
                            .Parameters.Add(New SqlParameter("@sal_jud_id", SqlDbType.Int)).Value = objEnt.SalaJuzgado
                            .Parameters.Add(New SqlParameter("@doc_jud_jue", SqlDbType.VarChar, 200)).Value = objEnt.JuezNombre
                            .Parameters.Add(New SqlParameter("@doc_jud_sec", SqlDbType.VarChar, 500)).Value = objEnt.SecretarioNombre
                            .Parameters.Add(New SqlParameter("@doc_jud_aut_nom", SqlDbType.VarChar, 500)).Value = objEnt.AutoridadOtroNombre
                            .Parameters.Add(New SqlParameter("@doc_jud_aut_cgo", SqlDbType.VarChar, 500)).Value = objEnt.AutoridadOtroCargo
                            .Parameters.Add(New SqlParameter("@doc_jud_obs", SqlDbType.VarChar, 2500)).Value = objEnt.Observacion

                            .Parameters.Add(New SqlParameter("@doc_jud_lib", SqlDbType.VarChar, 20)).Value = objEnt.NumLibro
                            .Parameters.Add(New SqlParameter("@doc_jud_fol", SqlDbType.VarChar, 20)).Value = objEnt.NumFolio
                            .Parameters.Add(New SqlParameter("@reg_ori_id", SqlDbType.Int)).Value = objEnt.RegionOrigenId
                            .Parameters.Add(New SqlParameter("@pen_orig_id", SqlDbType.Int)).Value = objEnt.PenalOrigenId
                            .Parameters.Add(New SqlParameter("@pen_ori_otr", SqlDbType.VarChar, 200)).Value = objEnt.PenalOtroOrigenNom
                            .Parameters.Add(New SqlParameter("@reg_des_id", SqlDbType.Int)).Value = objEnt.RegionDestinoId
                            .Parameters.Add(New SqlParameter("@pen_des_id", SqlDbType.Int)).Value = objEnt.PenalDestinoid
                            .Parameters.Add(New SqlParameter("@pen_des_otr", SqlDbType.VarChar, 200)).Value = objEnt.PenalDestinoOtroNom
                            .Parameters.Add(New SqlParameter("@doc_fec_mov", SqlDbType.BigInt)).Value = objEnt.FechaMovimiento
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.InternoIngresoId
                            .Parameters.Add(New SqlParameter("@doc_subtip_id", SqlDbType.Int)).Value = objEnt.DocumentoSubTipoId
                            .Parameters.Add(New SqlParameter("@doc_jud_que_id", SqlDbType.Int)).Value = objEnt.QuedaId
                            .Parameters.Add(New SqlParameter("@n_doc_jud_est_anu", SqlDbType.Int)).Value = objEnt.IdDocumentoAntecedente
                            .Parameters.Add(New SqlParameter("@doc_jud_est_id", SqlDbType.Int)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@prol_det_ini_fec", SqlDbType.BigInt)).Value = objEnt.ProlonDetencionFechIni
                            .Parameters.Add(New SqlParameter("@prol_det_fin_fec", SqlDbType.BigInt)).Value = objEnt.ProlonDetencionFechFin
                            .Parameters.Add(New SqlParameter("@prol_det_tip_und", SqlDbType.VarChar, 50)).Value = objEnt.ProlonDetencionTipoUnidad
                            .Parameters.Add(New SqlParameter("@prol_det_cant", SqlDbType.Int)).Value = objEnt.ProlonDetencionValor
                            .Parameters.Add(New SqlParameter("@mov_mot_id", SqlDbType.Int)).Value = objEnt.MovimientoMotivoId
                            '.Parameters.Add(New SqlParameter("@mov_est_id", SqlDbType.Int)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@sent_fec", SqlDbType.BigInt)).Value = objEnt.SentenciaFecha
                            .Parameters.Add(New SqlParameter("@sent_consentida", SqlDbType.Bit)).Value = objEnt.SentenciaConsentida
                            .Parameters.Add(New SqlParameter("@sent_cad_perpet", SqlDbType.Bit)).Value = objEnt.SentenciaCadenaPerpetua
                            .Parameters.Add(New SqlParameter("@sent_tot_anio", SqlDbType.Int)).Value = objEnt.SentenciaTotalAnios
                            .Parameters.Add(New SqlParameter("@sent_tot_meses", SqlDbType.Int)).Value = objEnt.SentenciaTotalMeses
                            .Parameters.Add(New SqlParameter("@sent_tot_dias", SqlDbType.Int)).Value = objEnt.SentenciaTotalDias

                            .Parameters.Add(New SqlParameter("@c_reg_doc_jud_doc", SqlDbType.VarChar, 250)).Value = objEnt.DocumentoJudicialPenalOrigen
                            .Parameters.Add(New SqlParameter("@f_reg_doc_jud_fec_int", SqlDbType.BigInt)).Value = objEnt.FechaInternamientoPenalOrigen
                            .Parameters.Add(New SqlParameter("@f_reg_doc_jud_fec_ing", SqlDbType.BigInt)).Value = objEnt.FechaIngresoPenalOrigen
                            .Parameters.Add(New SqlParameter("@c_reg_doc_jud_obs", SqlDbType.VarChar, 2500)).Value = objEnt.ObservacionPenalOrigen
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEnt.SedeRowId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@n_mand_ing", SqlDbType.SmallInt)).Value = objEnt.MandatoDeInternamiento


                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objEnt.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt._RegionID
                            .Parameters.Add(New SqlParameter("@_penID", SqlDbType.Int)).Value = objEnt._PenalID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

        Public Shared Function Grabar2(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.DocumentoJudicial) As Integer

            '22-05-2014 hnrb

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    '                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure2, sqlCon)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objEnt.DocumentoTipo
                            .Parameters.Add(New SqlParameter("@doc_jud_num", SqlDbType.VarChar, 500)).Value = objEnt.DocumentoNumero

                            .Parameters.Add(New SqlParameter("@doc_jud_num_aux", SqlDbType.VarChar, 500)).Value = objEnt.DocumentoNumeroTraslado
                            .Parameters.Add(New SqlParameter("@doc_jud_fec_rec", SqlDbType.BigInt)).Value = objEnt.DocumentoFechaRecepcion
                            .Parameters.Add(New SqlParameter("@doc_jud_fec", SqlDbType.BigInt)).Value = objEnt.DocumentoFecha
                            .Parameters.Add(New SqlParameter("@tip_aut_jud_id", SqlDbType.Int)).Value = objEnt.TipoAutoridadJudicial
                            .Parameters.Add(New SqlParameter("@dis_jud_id", SqlDbType.Int)).Value = objEnt.DistritoJudicial
                            .Parameters.Add(New SqlParameter("@sal_jud_id", SqlDbType.Int)).Value = objEnt.SalaJuzgado
                            .Parameters.Add(New SqlParameter("@doc_jud_jue", SqlDbType.VarChar, 200)).Value = objEnt.JuezNombre
                            .Parameters.Add(New SqlParameter("@doc_jud_sec", SqlDbType.VarChar, 500)).Value = objEnt.SecretarioNombre
                            .Parameters.Add(New SqlParameter("@doc_jud_aut_nom", SqlDbType.VarChar, 500)).Value = objEnt.AutoridadOtroNombre
                            .Parameters.Add(New SqlParameter("@doc_jud_aut_cgo", SqlDbType.VarChar, 500)).Value = objEnt.AutoridadOtroCargo
                            .Parameters.Add(New SqlParameter("@doc_jud_obs", SqlDbType.VarChar, 2500)).Value = objEnt.Observacion

                            .Parameters.Add(New SqlParameter("@doc_jud_lib", SqlDbType.VarChar, 20)).Value = objEnt.NumLibro
                            .Parameters.Add(New SqlParameter("@doc_jud_fol", SqlDbType.VarChar, 20)).Value = objEnt.NumFolio
                            .Parameters.Add(New SqlParameter("@reg_ori_id", SqlDbType.Int)).Value = objEnt.RegionOrigenId
                            .Parameters.Add(New SqlParameter("@pen_orig_id", SqlDbType.Int)).Value = objEnt.PenalOrigenId
                            .Parameters.Add(New SqlParameter("@pen_ori_otr", SqlDbType.VarChar, 200)).Value = objEnt.PenalOtroOrigenNom
                            .Parameters.Add(New SqlParameter("@reg_des_id", SqlDbType.Int)).Value = objEnt.RegionDestinoId
                            .Parameters.Add(New SqlParameter("@pen_des_id", SqlDbType.Int)).Value = objEnt.PenalDestinoid
                            .Parameters.Add(New SqlParameter("@pen_des_otr", SqlDbType.VarChar, 200)).Value = objEnt.PenalDestinoOtroNom
                            .Parameters.Add(New SqlParameter("@doc_fec_mov", SqlDbType.BigInt)).Value = objEnt.FechaMovimiento
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.InternoIngresoId
                            .Parameters.Add(New SqlParameter("@doc_subtip_id", SqlDbType.Int)).Value = objEnt.DocumentoSubTipoId
                            .Parameters.Add(New SqlParameter("@n_doc_jud_est_anu", SqlDbType.Int)).Value = objEnt.IdDocumentoAntecedente
                            .Parameters.Add(New SqlParameter("@doc_jud_est_id", SqlDbType.Int)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@prol_det_ini_fec", SqlDbType.BigInt)).Value = objEnt.ProlonDetencionFechIni
                            .Parameters.Add(New SqlParameter("@prol_det_fin_fec", SqlDbType.BigInt)).Value = objEnt.ProlonDetencionFechFin
                            .Parameters.Add(New SqlParameter("@prol_det_tip_und", SqlDbType.VarChar, 50)).Value = objEnt.ProlonDetencionTipoUnidad
                            .Parameters.Add(New SqlParameter("@prol_det_cant", SqlDbType.Int)).Value = objEnt.ProlonDetencionValor
                            .Parameters.Add(New SqlParameter("@mov_mot_id", SqlDbType.Int)).Value = objEnt.MovimientoMotivoId
                            '.Parameters.Add(New SqlParameter("@mov_est_id", SqlDbType.Int)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@sent_fec", SqlDbType.BigInt)).Value = objEnt.SentenciaFecha
                            .Parameters.Add(New SqlParameter("@sent_consentida", SqlDbType.Bit)).Value = objEnt.SentenciaConsentida
                            .Parameters.Add(New SqlParameter("@sent_cad_perpet", SqlDbType.Bit)).Value = objEnt.SentenciaCadenaPerpetua
                            .Parameters.Add(New SqlParameter("@sent_tot_anio", SqlDbType.Int)).Value = objEnt.SentenciaTotalAnios
                            .Parameters.Add(New SqlParameter("@sent_tot_meses", SqlDbType.Int)).Value = objEnt.SentenciaTotalMeses
                            .Parameters.Add(New SqlParameter("@sent_tot_dias", SqlDbType.Int)).Value = objEnt.SentenciaTotalDias

                            .Parameters.Add(New SqlParameter("@c_reg_doc_jud_doc", SqlDbType.VarChar, 250)).Value = objEnt.DocumentoJudicialPenalOrigen
                            .Parameters.Add(New SqlParameter("@f_reg_doc_jud_fec_int", SqlDbType.BigInt)).Value = objEnt.FechaInternamientoPenalOrigen
                            .Parameters.Add(New SqlParameter("@f_reg_doc_jud_fec_ing", SqlDbType.BigInt)).Value = objEnt.FechaIngresoPenalOrigen
                            .Parameters.Add(New SqlParameter("@c_reg_doc_jud_obs", SqlDbType.VarChar, 2500)).Value = objEnt.ObservacionPenalOrigen

                            '.Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objEnt.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt._RegionID
                            .Parameters.Add(New SqlParameter("@_penID", SqlDbType.Int)).Value = objEnt._PenalID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.DocumentoJudicial) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objEnt.DocumentoTipo
                            .Parameters.Add(New SqlParameter("@doc_jud_num", SqlDbType.VarChar, 500)).Value = objEnt.DocumentoNumero
                            .Parameters.Add(New SqlParameter("@doc_jud_fec_rec", SqlDbType.BigInt)).Value = objEnt.DocumentoFechaRecepcion
                            .Parameters.Add(New SqlParameter("@doc_jud_fec", SqlDbType.BigInt)).Value = objEnt.DocumentoFecha
                            .Parameters.Add(New SqlParameter("@tip_aut_jud_id", SqlDbType.Int)).Value = objEnt.TipoAutoridadJudicial
                            .Parameters.Add(New SqlParameter("@dis_jud_id", SqlDbType.Int)).Value = objEnt.DistritoJudicial
                            .Parameters.Add(New SqlParameter("@sal_jud_id", SqlDbType.Int)).Value = objEnt.SalaJuzgado
                            .Parameters.Add(New SqlParameter("@doc_jud_jue", SqlDbType.VarChar, 200)).Value = objEnt.JuezNombre
                            .Parameters.Add(New SqlParameter("@doc_jud_sec", SqlDbType.VarChar, 500)).Value = objEnt.SecretarioNombre
                            .Parameters.Add(New SqlParameter("@doc_jud_aut_nom", SqlDbType.VarChar, 500)).Value = objEnt.AutoridadOtroNombre
                            .Parameters.Add(New SqlParameter("@doc_jud_aut_cgo", SqlDbType.VarChar, 500)).Value = objEnt.AutoridadOtroCargo
                            .Parameters.Add(New SqlParameter("@doc_jud_obs", SqlDbType.VarChar, 500)).Value = objEnt.Observacion

                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.InternoIngresoId

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt._RegionID
                            .Parameters.Add(New SqlParameter("@_penID", SqlDbType.Int)).Value = objEnt._PenalID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

#End Region
#Region "Elininar"
        Public Shared Function Eliminar_LM(ByVal accion As String, ByVal opcion As String,
                                 ByVal Codigo As Integer, InternoID As Integer, IngresoInpeID As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = IngresoInpeID
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String,
                                         ByVal Codigo As Integer, InternoID As Integer, IngresoID As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
#End Region

#Region "UP_REG_DOC_DocJudicialExpediente"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, accion As String, opcion As String,
                                      objEntity As Entity.Registro.DocumentoJudicial) As SqlDataReader

            'tiene que unirse con el listar normal

            Dim objEntCol As Entity.Registro.Documento.DocumentoJudicialExpedienteCol = Nothing
            Dim objEnt As Entity.Registro.Documento.DocumentoJudicialExpediente = Nothing

            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 180 '3 minutos
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objEntity.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntity.InternoId
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEntity.InternoIngresoId
                    .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objEntity.DocumentoTipo
                    .Parameters.Add(New SqlParameter("@doc_subtip_id", SqlDbType.Int)).Value = objEntity.DocumentoSubTipoId
                    .Parameters.Add(New SqlParameter("@n_doc_jud_est_anu", SqlDbType.Int)).Value = objEntity.IdDocumentoAntecedente
                    .Parameters.Add(New SqlParameter("@doc_jud_est_id", SqlDbType.Int)).Value = objEntity.Estado
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, accion As String, opcion As String,
                                      objEntity As Entity.Registro.DocumentoJudicial) As SqlDataReader

            'tiene que unirse con el listar normal

            Dim objEntCol As Entity.Registro.Documento.DocumentoJudicialExpedienteCol = Nothing
            Dim objEnt As Entity.Registro.Documento.DocumentoJudicialExpediente = Nothing

            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 180 '3 minutos
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objEntity.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntity.InternoId
                    '.Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEntity.InternoIngresoId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEntity.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objEntity.DocumentoTipo
                    .Parameters.Add(New SqlParameter("@doc_subtip_id", SqlDbType.Int)).Value = objEntity.DocumentoSubTipoId
                    .Parameters.Add(New SqlParameter("@n_doc_jud_est_anu", SqlDbType.Int)).Value = objEntity.IdDocumentoAntecedente
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

        Public Shared Function Listar_SentenciasCumplidas(ByVal sqlCon As SqlConnection, accion As String, opcion As String,
                                     objEntity As Entity.Registro.DocumentoJudicial) As SqlDataReader

            'tiene que unirse con el listar normal

            Dim objEntCol As Entity.Registro.Documento.DocumentoJudicialExpedienteCol = Nothing
            Dim objEnt As Entity.Registro.Documento.DocumentoJudicialExpediente = Nothing

            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = objEntity.ProlonDetencionFechIni
                    .Parameters.Add(New SqlParameter("@_variabletiempo", SqlDbType.Int)).Value = objEntity.ProlonDetencionValor
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEntity._RegionID
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEntity._PenalID

                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function
#End Region
    End Class
End Namespace

