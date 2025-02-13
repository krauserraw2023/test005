Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.Tratamiento.Clasificacion
    Public Class Resultado

        Private Shared strNameProcedure As String = "pa_tra_asi_mae_ficha_resultado"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.Resultado_BE) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_fic_res_id", SqlDbType.SmallInt)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.SmallInt)).Value = objEnt.IDFicha
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(Accion As String, Opcion As String, objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.Resultado_BE) As Integer
            Dim intCodigo As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = Accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = Opcion
                            .Parameters.Add(New SqlParameter("@pk_fic_res_id", SqlDbType.SmallInt)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.SmallInt)).Value = objEnt.IDFicha
                            '.Parameters.Add(New SqlParameter("@n_num_ord", SqlDbType.Int)).Value = objEnt.NumeroOrden
                            '.Parameters.Add(ffNew SqlParameter("@c_nom", SqlDbType.VarChar, 100)).Value = objEnt.Nombre
                            .Parameters.Add(New SqlParameter("@c_des", SqlDbType.VarChar, 500)).Value = objEnt.Descripcion
                            .Parameters.Add(New SqlParameter("@b_tbl_int", SqlDbType.Bit)).Value = objEnt.TieneValorTabla
                            .Parameters.Add(New SqlParameter("@c_nom_tbl", SqlDbType.VarChar, 50)).Value = objEnt.NombreTabla

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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
                                        ByRef outErrSms As String) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_fic_res_id", SqlDbType.SmallInt)).Value = Codigo

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