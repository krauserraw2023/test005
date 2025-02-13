Option Explicit On
Imports System.Data.SqlClient

Namespace Registro.Antecedente
    Public Class DetalleAntecedente
        Private Shared strNameProcedure As String = "pa_anj_mov_det_antecedente"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                            objEnt As Entity.Registro.Antecedente.DetalleAntecedente) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = "lst"
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = "lst_mant"
                    .Parameters.Add(New SqlParameter("@pk_det_aj", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_sol_ant_id", SqlDbType.Int)).Value = objEnt.SolicitudAntecedenteId
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt.PenalId
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.RegionId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try

            Return sqlReader

        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Registro.Antecedente.DetalleAntecedente, ByRef outSMS As String) As Integer
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_det_aj", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@n_fec_res", SqlDbType.BigInt)).Value = objEnt.Fecha
                            .Parameters.Add(New SqlParameter("@c_detalle", SqlDbType.VarChar, 100)).Value = objEnt.Detalle
                            .Parameters.Add(New SqlParameter("@c_decripcion", SqlDbType.VarChar)).Value = objEnt.Descripcion
                            .Parameters.Add(New SqlParameter("@fk_sol_ant_id", SqlDbType.Int)).Value = objEnt.SolicitudAntecedenteId
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objEnt.RegionId
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objEnt.PenalId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            Return .Parameters("@variable_out").Value
                        End With
                    End Using

                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
    End Class
End Namespace