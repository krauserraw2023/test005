Imports System.Data
Imports System.Data.SqlClient
Namespace Registro.Carceleta.Clasificacion.InternoClasificacion
    Public Class InternoAgraviado_DA
        Private Shared strNameProcedure As String = "pa_tra_asi_mov_internoagraviado"
#Region "Listar"

        'Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objEnt As Entity.Clasificacion.InternoClasificacion.Agraviado) As SqlDataReader

        '    Dim sqlReader As SqlDataReader = Nothing
        '    Try
        '        sqlCon.Open()
        '        Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '        With sqlCmd
        '            .CommandType = CommandType.StoredProcedure
        '            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '            .Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = objEnt.Codigo
        '            .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEnt.DelitoID
        '            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
        '            '.Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
        '            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEnt.ExpedienteID
        '            .Parameters.Add(New SqlParameter("@int_agr_nom", SqlDbType.VarChar, 250)).Value = objEnt.AgraviadoNombre
        '            .Parameters.Add(New SqlParameter("@int_agr_fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaIni
        '            .Parameters.Add(New SqlParameter("@int_agr_fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin

        '        End With
        '        sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
        '    Catch ex As SqlException
        '        Throw New Exception(ex.Message)
        '    End Try
        '    Return sqlReader
        'End Function

#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objEntity As Entity.Clasificacion.InternoClasificacion.Agraviado) As Integer
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
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEntity.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEntity.ExpedienteID
                            .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEntity.DelitoID
                            .Parameters.Add(New SqlParameter("@int_agr_nom", SqlDbType.VarChar, 250)).Value = objEntity.AgraviadoNombre
                            .Parameters.Add(New SqlParameter("@sal_jud_id", SqlDbType.Int)).Value = objEntity.SalaJudicial
                            .Parameters.Add(New SqlParameter("@int_agr_cad_per", SqlDbType.Bit)).Value = objEntity.CadenaPerpetua
                            .Parameters.Add(New SqlParameter("@int_agr_fec_ini", SqlDbType.BigInt)).Value = objEntity.FechaIni
                            .Parameters.Add(New SqlParameter("@int_agr_fec_fin", SqlDbType.BigInt)).Value = objEntity.FechaFin
                            .Parameters.Add(New SqlParameter("@fk_int_fic_id", SqlDbType.Int)).Value = objEntity.FichaFinalId

                            .Parameters.Add(New SqlParameter("@int_agr_obs", SqlDbType.VarChar, 2500)).Value = objEntity.Observacion

                            .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objEntity.RegionID
                            .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = objEntity.PenalID

                            .Parameters.Add(New SqlParameter("@fk_tip_sent_id", SqlDbType.Int)).Value = objEntity.TipoSentenciaId
                            .Parameters.Add(New SqlParameter("@fk_tip_sent_hist_id", SqlDbType.Int)).Value = objEntity.TipoSentenciaHistoricoId
                            .Parameters.Add(New SqlParameter("@fk_tip_res_id", SqlDbType.Int)).Value = objEntity.TipoResolucionId

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
#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
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

    End Class
End Namespace
