Imports System.Data.SqlClient

Namespace Registro.Carceleta.Clasificacion.Documento
    'tabla tra_asi_mov_det_documento
    Public Class DetDocClasificacion_DA
        Private Shared strNameProcedure As String = "pa_tra_asi_mov_det_documento"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entDetDocClas As Entity.Clasificacion.Documento.DetDocClasificacion) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_det_doc_id", SqlDbType.Int)).Value = entDetDocClas.Codigo
                    .Parameters.Add(New SqlParameter("@fk_doc_id", SqlDbType.Int)).Value = entDetDocClas.DocClasificacionId
                    .Parameters.Add(New SqlParameter("@fk_int_fic_id", SqlDbType.Int)).Value = entDetDocClas.InternoFichaId
                    .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = entDetDocClas.RegionId
                    .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = entDetDocClas.PenalId
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 240 '4 min
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_det_doc_id", SqlDbType.Int)).Value = Codigo
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

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                      ByVal entDetDocClas As Entity.Clasificacion.Documento.DetDocClasificacion) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_det_doc_id", SqlDbType.Int)).Value = entDetDocClas.Codigo
                            .Parameters.Add(New SqlParameter("@fk_doc_id", SqlDbType.Int)).Value = entDetDocClas.DocClasificacionId
                            .Parameters.Add(New SqlParameter("@fk_int_fic_id", SqlDbType.Int)).Value = entDetDocClas.InternoFichaId
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = entDetDocClas.RegionId
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = entDetDocClas.PenalId

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
            End Try
        End Function
    End Class
End Namespace