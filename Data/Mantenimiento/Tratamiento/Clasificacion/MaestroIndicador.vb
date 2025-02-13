Imports System.Data
Imports System.Data.SqlClient
Namespace Clasificacion
    Public Class MaestroIndicador
        Private Shared strNameProcedure As String = "pa_tra_asi_mae_indicador"

        Public Shared Function ListarGrillaAgrupada(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entValor As Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_ind_id", SqlDbType.Int)).Value = entValor.Codigo
                    .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = entValor.FichaId
                    .Parameters.Add(New SqlParameter("@fk_var_id", SqlDbType.Int)).Value = entValor.VariableID
                    .Parameters.Add(New SqlParameter("@c_ind_des", SqlDbType.VarChar, 500)).Value = entValor.Descripcion
                    .Parameters.Add(New SqlParameter("@n_ind_num_ord", SqlDbType.Int)).Value = entValor.Secuencia

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function


        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entValor As Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_ind_id", SqlDbType.Int)).Value = entValor.Codigo
                    .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = entValor.FichaId
                    .Parameters.Add(New SqlParameter("@fk_var_id", SqlDbType.Int)).Value = entValor.VariableID
                    .Parameters.Add(New SqlParameter("@c_ind_des", SqlDbType.VarChar, 500)).Value = entValor.Descripcion
                    .Parameters.Add(New SqlParameter("@n_ind_num_ord", SqlDbType.Int)).Value = entValor.Secuencia

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(Accion As String, Opcion As String, Ent As Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE) As Integer
            Dim intCodigo As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = Accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = Opcion
                            .Parameters.Add(New SqlParameter("@pk_ind_id", SqlDbType.Int)).Value = Ent.Codigo
                            '.Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = Ent.FichaId
                            .Parameters.Add(New SqlParameter("@fk_var_id", SqlDbType.Int)).Value = Ent.VariableID
                            .Parameters.Add(New SqlParameter("@n_ind_num_ord", SqlDbType.Int)).Value = Ent.Secuencia

                            .Parameters.Add(New SqlParameter("@c_ind_des", SqlDbType.VarChar, 500)).Value = Ent.Descripcion
                            .Parameters.Add(New SqlParameter("@n_ind_ptje", SqlDbType.Int)).Value = Ent.Puntaje

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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByRef outErrSms As String) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_ind_id", SqlDbType.Int)).Value = Codigo
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
            Catch sql As SqlException
                outErrSms = sql.Message
                Return -1
            Catch ex As Exception
                outErrSms = ex.Message
                Return -1
            End Try
        End Function

    End Class
End Namespace
