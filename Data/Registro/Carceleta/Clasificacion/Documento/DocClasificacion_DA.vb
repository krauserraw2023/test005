Imports System.Data.SqlClient

Namespace Registro.Carceleta.Clasificacion.Documento
    'tra_asi_mov_documento
    Public Class DocClasificacion_DA
        Private Shared strNameProcedure As String = "pa_tra_asi_mov_documento"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entDocClas As Entity.Clasificacion.Documento.DocClasificacion) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_doc_id", SqlDbType.Int)).Value = entDocClas.Codigo
                    .Parameters.Add(New SqlParameter("@n_doc_anio", SqlDbType.Int)).Value = entDocClas.AnioDoc
                    .Parameters.Add(New SqlParameter("@n_doc_corr", SqlDbType.Int)).Value = entDocClas.CorrelativoDoc
                    .Parameters.Add(New SqlParameter("@c_doc_num", SqlDbType.VarChar, 200)).Value = entDocClas.NumeroDoc
                    .Parameters.Add(New SqlParameter("@c_doc_obs", SqlDbType.VarChar, 2000)).Value = entDocClas.Observacion
                    .Parameters.Add(New SqlParameter("@fk_est_doc", SqlDbType.Int)).Value = entDocClas.EstadoDocId
                    .Parameters.Add(New SqlParameter("@n_doc_fec_emi", SqlDbType.BigInt)).Value = entDocClas.FechaEmision
                    .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = entDocClas.RegionId
                    .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = entDocClas.PenalId

                    .Parameters.Add(New SqlParameter("@fec_emision_ini", SqlDbType.BigInt)).Value = entDocClas.FechaEmisionDesde
                    .Parameters.Add(New SqlParameter("@fec_emision_fin", SqlDbType.BigInt)).Value = entDocClas.FechaEmisionHasta


                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, NumeroDoc As String) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@c_doc_num", SqlDbType.VarChar, 200)).Value = NumeroDoc

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
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_doc_id", SqlDbType.Int)).Value = Codigo
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
                                      ByVal entDocClas As Entity.Clasificacion.Documento.DocClasificacion) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_doc_id", SqlDbType.Int)).Value = entDocClas.Codigo
                            .Parameters.Add(New SqlParameter("@n_doc_anio", SqlDbType.Int)).Value = entDocClas.AnioDoc
                            .Parameters.Add(New SqlParameter("@n_doc_corr", SqlDbType.Int)).Value = entDocClas.CorrelativoDoc
                            .Parameters.Add(New SqlParameter("@c_doc_num", SqlDbType.VarChar, 200)).Value = entDocClas.NumeroDoc
                            .Parameters.Add(New SqlParameter("@c_doc_obs", SqlDbType.VarChar, 2000)).Value = entDocClas.Observacion
                            .Parameters.Add(New SqlParameter("@fk_est_doc", SqlDbType.Int)).Value = entDocClas.EstadoDocId
                            .Parameters.Add(New SqlParameter("@n_doc_fec_emi", SqlDbType.BigInt)).Value = entDocClas.FechaEmision

                            .Parameters.Add(New SqlParameter("@fk_glo_doc_id", SqlDbType.Int)).Value = entDocClas.GlosaDocId
                            .Parameters.Add(New SqlParameter("@c_doc_dest_nom", SqlDbType.VarChar, 400)).Value = entDocClas.NombreDestinoDoc

                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = entDocClas.RegionId
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = entDocClas.PenalId

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