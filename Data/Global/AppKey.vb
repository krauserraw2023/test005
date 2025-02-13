Imports System.Data
Imports System.Data.SqlClient
Namespace General
    Public Class AppKey
        Private Shared strNameProcedure As String = "UP_SYS_WinApp"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal Modulo As Integer, _
        ByVal Key As String, _
        ByVal Valor As String, _
        ByVal ValorIng As Long, _
        ByVal Descripcion As String _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@win_app_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@win_app_mod", SqlDbType.Int)).Value = Modulo
                            .Parameters.Add(New SqlParameter("@win_app_key", SqlDbType.VarChar, 255)).Value = Key
                            .Parameters.Add(New SqlParameter("@win_app_val", SqlDbType.VarChar, 255)).Value = Valor
                            .Parameters.Add(New SqlParameter("@win_app_val_int", SqlDbType.BigInt)).Value = ValorIng
                            .Parameters.Add(New SqlParameter("@win_app_des", SqlDbType.VarChar, 255)).Value = Descripcion

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intValue = .Parameters("@variable_out").Value
                            Return intValue
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal Modulo As Integer, _
        ByVal Key As String, _
        ByVal Valor As String, _
        ByVal ValorIng As Long, _
        ByVal Descripcion As String _
        ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@win_app_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@win_app_mod", SqlDbType.Int)).Value = Modulo
                    .Parameters.Add(New SqlParameter("@win_app_key", SqlDbType.VarChar, 255)).Value = Key
                    .Parameters.Add(New SqlParameter("@win_app_val", SqlDbType.VarChar, 255)).Value = Valor
                    .Parameters.Add(New SqlParameter("@win_app_val_int", SqlDbType.BigInt)).Value = ValorIng
                    .Parameters.Add(New SqlParameter("@win_app_des", SqlDbType.VarChar, 255)).Value = Descripcion
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal Modulo As Integer, _
        ByVal Key As String, _
        ByVal Valor As String, _
        ByVal ValorIng As Long, _
        ByVal Descripcion As String, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@win_app_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@win_app_mod", SqlDbType.Int)).Value = Modulo
                            .Parameters.Add(New SqlParameter("@win_app_key", SqlDbType.VarChar, 255)).Value = Key
                            .Parameters.Add(New SqlParameter("@win_app_val", SqlDbType.VarChar, 255)).Value = Valor
                            .Parameters.Add(New SqlParameter("@win_app_val_int", SqlDbType.BigInt)).Value = ValorIng
                            .Parameters.Add(New SqlParameter("@win_app_des", SqlDbType.VarChar, 255)).Value = Descripcion

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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@win_app_id", SqlDbType.Int)).Value = Codigo

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
    End Class
End Namespace
