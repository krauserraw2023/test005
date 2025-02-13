Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class internoAgraviado
        Private Shared strNameProcedure As String = "UP_INT_InternoAgraviado"
#Region "Listar"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
        ByVal Codigo As Integer, _
        ByVal DelitoID As Integer, _
        ByVal InternoID As Integer, _
        ByVal IngresoID As Integer, _
        ByVal ExpedienteID As Integer, _
        ByVal SentenciaID As Integer, _
        ByVal Agraviado As String, _
        ByVal FechaIni As Long, ByVal FechaFin As Long) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = DelitoID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_agr_nom", SqlDbType.VarChar, 250)).Value = Agraviado
                    .Parameters.Add(New SqlParameter("@int_agr_fec_ini", SqlDbType.BigInt)).Value = FechaIni
                    .Parameters.Add(New SqlParameter("@int_agr_fec_fin", SqlDbType.BigInt)).Value = FechaFin

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.Agraviado) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEnt.DelitoID
                    .Parameters.Add(New SqlParameter("@int_del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecificoID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEnt.ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_agr_nom", SqlDbType.VarChar, 250)).Value = objEnt.AgraviadoNombre
                    .Parameters.Add(New SqlParameter("@int_agr_fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaIni
                    .Parameters.Add(New SqlParameter("@int_agr_fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin
                    .Parameters.Add(New SqlParameter("@n_int_agr_est_anu", SqlDbType.Int)).Value = objEnt.Anulacion
                    .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objEnt.CreaDocJudicialId
                    .Parameters.Add(New SqlParameter("@int_agr_est", SqlDbType.Int)).Value = objEnt.Estado
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar_lm(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.Agraviado) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEnt.DelitoID
                    .Parameters.Add(New SqlParameter("@int_del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecificoID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEnt.ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_agr_nom", SqlDbType.VarChar, 250)).Value = objEnt.AgraviadoNombre
                    .Parameters.Add(New SqlParameter("@int_agr_fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaIni
                    .Parameters.Add(New SqlParameter("@int_agr_fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin
                    .Parameters.Add(New SqlParameter("@n_int_agr_est_anu", SqlDbType.Int)).Value = objEnt.Anulacion
                    .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objEnt.CreaDocJudicialId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar2(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
       EntExp As Entity.Registro.Expediente) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    '.Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = Codigo
                    '.Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = DelitoID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntExp.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntExp.IngresoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = EntExp.Codigo
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.VarChar, 250)).Value = EntExp.InternoDelitoID
                    .Parameters.Add(New SqlParameter("@int_del_esp_id", SqlDbType.Int)).Value = EntExp.DelitoEspecificoID
                    .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = EntExp.CreaDocJudicialId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
#End Region

#Region "Grabar"

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
     ByVal InternoID As Integer, _
     ByVal IngresoID As Integer, _
     ByVal ExpedienteID As Integer, ByVal DelitoID As Integer, ByVal Agraviado As String, _
     ByVal SentenciaDoc As String, _
     ByVal SentenciaFecha As Long, ByVal AutoridadJudicial As Integer, ByVal SalaJudicial As Integer, _
     ByVal CadenaPerpetua As Boolean, ByVal FechaIni As Long, ByVal FechaFin As Long, _
     ByVal SentenciaAnio As Integer, ByVal SentenciaMes As Integer, _
     ByVal SentenciaDia As Integer, ByVal Observacion As String, _
     ByVal Anulacionid As Integer, _
     ByVal Estado As Integer, IDRegion As Integer, IDPenal As Integer) As Integer

            'GRABAR LA VERSION ANTIGUA

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpedienteID
                            .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = DelitoID
                            .Parameters.Add(New SqlParameter("@int_agr_nom", SqlDbType.VarChar, 250)).Value = Agraviado
                            .Parameters.Add(New SqlParameter("@int_sen_doc", SqlDbType.VarChar, 120)).Value = SentenciaDoc
                            .Parameters.Add(New SqlParameter("@int_sen_fec", SqlDbType.BigInt)).Value = SentenciaFecha
                            .Parameters.Add(New SqlParameter("@aut_sen_id", SqlDbType.Int)).Value = AutoridadJudicial
                            .Parameters.Add(New SqlParameter("@sal_jud_id", SqlDbType.Int)).Value = SalaJudicial
                            .Parameters.Add(New SqlParameter("@int_agr_cad_per", SqlDbType.Bit)).Value = CadenaPerpetua
                            .Parameters.Add(New SqlParameter("@int_agr_fec_ini", SqlDbType.BigInt)).Value = FechaIni
                            .Parameters.Add(New SqlParameter("@int_agr_fec_fin", SqlDbType.BigInt)).Value = FechaFin
                            .Parameters.Add(New SqlParameter("@int_sen_anio", SqlDbType.Int)).Value = SentenciaAnio
                            .Parameters.Add(New SqlParameter("@int_sen_mes", SqlDbType.Int)).Value = SentenciaMes
                            .Parameters.Add(New SqlParameter("@int_sen_dia", SqlDbType.Int)).Value = SentenciaDia
                            .Parameters.Add(New SqlParameter("@int_agr_obs", SqlDbType.VarChar, 2500)).Value = Observacion
                            .Parameters.Add(New SqlParameter("@n_int_agr_est_anu", SqlDbType.Int)).Value = Anulacionid
                            .Parameters.Add(New SqlParameter("@int_agr_est", SqlDbType.Int)).Value = Estado

                            .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = IDRegion
                            .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = IDPenal

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

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objEntity As Entity.Registro.Agraviado) As Integer

            'GRABA LA VERSION NUEVA

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = objEntity.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntity.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEntity.IngresoID
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEntity.ExpedienteID
                            .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEntity.DelitoID
                            .Parameters.Add(New SqlParameter("@int_agr_nom", SqlDbType.VarChar, 250)).Value = objEntity.AgraviadoNombre
                            .Parameters.Add(New SqlParameter("@int_sen_doc", SqlDbType.VarChar, 120)).Value = objEntity.SentenciaDocumento
                            .Parameters.Add(New SqlParameter("@int_sen_fec", SqlDbType.BigInt)).Value = objEntity.SentenciaFecha
                            .Parameters.Add(New SqlParameter("@aut_sen_id", SqlDbType.Int)).Value = objEntity.AutoridadJudicial
                            .Parameters.Add(New SqlParameter("@sal_jud_id", SqlDbType.Int)).Value = objEntity.SalaJudicial
                            .Parameters.Add(New SqlParameter("@int_agr_cad_per", SqlDbType.Bit)).Value = objEntity.CadenaPerpetua
                            .Parameters.Add(New SqlParameter("@int_agr_fec_ini", SqlDbType.BigInt)).Value = objEntity.FechaIni
                            .Parameters.Add(New SqlParameter("@int_agr_fec_fin", SqlDbType.BigInt)).Value = objEntity.FechaFin
                            .Parameters.Add(New SqlParameter("@int_sen_anio", SqlDbType.Int)).Value = objEntity.SentenciaAnio
                            .Parameters.Add(New SqlParameter("@int_sen_mes", SqlDbType.Int)).Value = objEntity.SentenciaMes
                            .Parameters.Add(New SqlParameter("@int_sen_dia", SqlDbType.Int)).Value = objEntity.SentenciaDia

                            .Parameters.Add(New SqlParameter("@int_agr_obs", SqlDbType.VarChar, 2500)).Value = objEntity.Observacion
                            .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objEntity.CreaDocJudicialId

                            .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objEntity.RegionID
                            .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = objEntity.PenalID

                            .Parameters.Add(New SqlParameter("@fk_tip_sent_id", SqlDbType.Int)).Value = objEntity.TipoSentenciaId
                            .Parameters.Add(New SqlParameter("@fk_tip_sent_hist_id", SqlDbType.Int)).Value = objEntity.TipoSentenciaHistoricoId  'en la version para publicar cambiar a Entity

                            .Parameters.Add(New SqlParameter("@fk_tip_res_id", SqlDbType.Int)).Value = objEntity.TipoResolucionId
                            .Parameters.Add(New SqlParameter("@n_int_agr_est_anu", SqlDbType.Int)).Value = objEntity.Anulacion
                            .Parameters.Add(New SqlParameter("@fk_int_agr_pad_ref_id", SqlDbType.Int)).Value = objEntity.CodigoagraviadoPad
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objEntity.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@int_agr_est", SqlDbType.SmallInt)).Value = objEntity.Estado

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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, objEntity As Entity.Registro.Agraviado) As Integer

            'GRABA LA VERSION NUEVA

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = objEntity.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntity.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEntity.IngresoID
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEntity.ExpedienteID
                            .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEntity.DelitoID
                            .Parameters.Add(New SqlParameter("@int_agr_nom", SqlDbType.VarChar, 250)).Value = objEntity.AgraviadoNombre
                            .Parameters.Add(New SqlParameter("@int_sen_doc", SqlDbType.VarChar, 120)).Value = objEntity.SentenciaDocumento
                            .Parameters.Add(New SqlParameter("@int_sen_fec", SqlDbType.BigInt)).Value = objEntity.SentenciaFecha
                            .Parameters.Add(New SqlParameter("@aut_sen_id", SqlDbType.Int)).Value = objEntity.AutoridadJudicial
                            .Parameters.Add(New SqlParameter("@sal_jud_id", SqlDbType.Int)).Value = objEntity.SalaJudicial
                            .Parameters.Add(New SqlParameter("@int_agr_cad_per", SqlDbType.Bit)).Value = objEntity.CadenaPerpetua
                            .Parameters.Add(New SqlParameter("@int_agr_fec_ini", SqlDbType.BigInt)).Value = objEntity.FechaIni
                            .Parameters.Add(New SqlParameter("@int_agr_fec_fin", SqlDbType.BigInt)).Value = objEntity.FechaFin
                            .Parameters.Add(New SqlParameter("@int_sen_anio", SqlDbType.Int)).Value = objEntity.SentenciaAnio
                            .Parameters.Add(New SqlParameter("@int_sen_mes", SqlDbType.Int)).Value = objEntity.SentenciaMes
                            .Parameters.Add(New SqlParameter("@int_sen_dia", SqlDbType.Int)).Value = objEntity.SentenciaDia
                            .Parameters.Add(New SqlParameter("@int_agr_obs", SqlDbType.VarChar, 2500)).Value = objEntity.Observacion
                            .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objEntity.CreaDocJudicialId
                            .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objEntity.RegionID
                            .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = objEntity.PenalID
                            .Parameters.Add(New SqlParameter("@fk_tip_res_id", SqlDbType.Int)).Value = objEntity.TipoResolucionId
                            .Parameters.Add(New SqlParameter("@fk_tip_sent_id", SqlDbType.Int)).Value = objEntity.TipoSentenciaId
                            .Parameters.Add(New SqlParameter("@fk_tip_sent_hist_id", SqlDbType.Int)).Value = objEntity.TipoSentenciaHistoricoId  'en la version para publicar cambiar a Entity

                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEntity.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEntity.SedeRowId

                            .Parameters.Add(New SqlParameter("@n_int_agr_est_anu", SqlDbType.Int)).Value = objEntity.Anulacion
                            .Parameters.Add(New SqlParameter("@fk_int_agr_pad_ref_id", SqlDbType.Int)).Value = objEntity.CodigoagraviadoPad
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objEntity.FlagTransferenciaSede

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
#End Region
#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede

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
#End Region
        
    End Class
End Namespace
