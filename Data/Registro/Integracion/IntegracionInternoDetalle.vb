Imports System.Data.SqlClient

Namespace Registro.Integracion
    Public Class IntegracionInternoDetalle
        Private Shared strNameProcedure As String = "pa_int_mov_integracion_interno_det"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      objEnt As Entity.Registro.Integracion.IntegracionInternoDetalle) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_reg_det_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_reg_id", SqlDbType.Int)).Value = objEnt.IntegracionInternoId
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.InternoRegionId
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.InternoPenalId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(sqlCmd As SqlCommand, ByVal accion As String, ByVal opcion As String,
                                       ByVal objEnt As Entity.Registro.Integracion.IntegracionInternoDetalle) As Integer

            Dim intCodigo As Integer = -1

            Try
                With sqlCmd
                    .CommandText = strNameProcedure
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_reg_det_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_reg_id", SqlDbType.Int)).Value = objEnt.IntegracionInternoId
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                    .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 300)).Value = objEnt.Observacion
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.InternoRegionId
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.InternoPenalId
                    .Parameters.Add(New SqlParameter("@fk_int_cod_uni_id", SqlDbType.Int)).Value = objEnt.CodigoUnicoInternoId



                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .ExecuteNonQuery()
                    intCodigo = .Parameters("@variable_out").Value

                End With
            Catch ex As Exception
            End Try

            Return intCodigo
        End Function

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByRef outSms As String) As Integer
            Dim intCodigo As Integer = -1

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_reg_det_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return intCodigo
        End Function
    End Class
End Namespace