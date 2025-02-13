Imports System.Data.SqlClient

Namespace General
    Public Class TipoDocumento
        Private Shared strNameProcedure As String = "UP_GEN_DocumentoTipo"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
                                            ByVal Codigo As Integer, ByVal CodigoString As String) As Integer

            Dim value As Integer = -1

            Try

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@par_cod", SqlDbType.VarChar, 5)).Value = CodigoString

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            'value = .ExecuteScalar().ToString
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_out").Value
                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return value

        End Function

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal TipDocId As Integer) As String

            Dim value As String = ""

            Try

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.VarChar, 5)).Value = TipDocId

                            .Parameters.Add(New SqlParameter("@variable_str_out", SqlDbType.VarChar, 100))
                            .Parameters("@variable_str_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_str_out").Value
                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return value

        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                           ByVal opcion As String) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
    End Class

End Namespace
