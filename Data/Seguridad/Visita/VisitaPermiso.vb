Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class VisitaPermiso
        Private Shared strNameProcedure As String = "UP_VIS_VisitaPermiso"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal CODIGO As Integer, _
        ByVal VisitanteId As Integer, _
        ByVal InternoId As Integer, _
        ByVal FechaDesde As Long, _
        ByVal FechaHasta As Long, _
        ByVal Documento As String, _
        ByVal EstadoId As Integer _
        ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@vis_per_id", SqlDbType.Int)).Value = CODIGO
                    .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = VisitanteId
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoId
                    .Parameters.Add(New SqlParameter("@vis_per_fec_dsd", SqlDbType.BigInt)).Value = FechaDesde
                    .Parameters.Add(New SqlParameter("@vis_per_fec_hst", SqlDbType.BigInt)).Value = FechaHasta
                    .Parameters.Add(New SqlParameter("@vis_per_doc", SqlDbType.VarChar, 50)).Value = Documento
                    .Parameters.Add(New SqlParameter("@vis_per_est", SqlDbType.Int)).Value = EstadoId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal CODIGO As Integer, _
        ByVal VisitanteId As Integer, _
        ByVal InternoId As Integer, _
        ByVal FechaDesde As Long, _
        ByVal FechaHasta As Long, _
        ByVal Documento As String, _
        ByVal EstadoId As Integer _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_per_id", SqlDbType.Int)).Value = CODIGO
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = VisitanteId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoId
                            .Parameters.Add(New SqlParameter("@vis_per_fec_dsd", SqlDbType.BigInt)).Value = FechaDesde
                            .Parameters.Add(New SqlParameter("@vis_per_fec_hst", SqlDbType.BigInt)).Value = FechaHasta
                            .Parameters.Add(New SqlParameter("@vis_per_doc", SqlDbType.VarChar, 50)).Value = Documento
                            .Parameters.Add(New SqlParameter("@vis_per_est", SqlDbType.Int)).Value = EstadoId

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
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal CODIGO As Integer, _
        ByVal VisitanteId As Integer, _
        ByVal InternoId As Integer, _
        ByVal FechaDesde As Long, _
        ByVal FechaHAsta As Long, _
        ByVal Documento As String, _
       ByVal ParentescoId As Integer, _
         ByVal EstadoId As Integer, _
         ByVal MotivoId As Integer, _
         ByVal TipoId As Integer, _
         ByVal PabellonId As Integer, _
        ByVal REgionID As Integer, _
        ByVal PenalId As Integer, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_per_id", SqlDbType.Int)).Value = CODIGO
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = VisitanteId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoId
                            .Parameters.Add(New SqlParameter("@vis_per_fec_dsd", SqlDbType.BigInt)).Value = FechaDesde
                            .Parameters.Add(New SqlParameter("@vis_per_fec_hst", SqlDbType.BigInt)).Value = FechaHAsta
                            .Parameters.Add(New SqlParameter("@vis_per_doc", SqlDbType.VarChar, 50)).Value = Documento
                            .Parameters.Add(New SqlParameter("@vis_per_est", SqlDbType.Int)).Value = EstadoId


                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = ParentescoId
                            .Parameters.Add(New SqlParameter("@tip_id", SqlDbType.Int)).Value = TipoId
                            .Parameters.Add(New SqlParameter("@mot_id", SqlDbType.Int)).Value = MotivoId
                            .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = PabellonId


                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = REgionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = PenalId




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
                            .Parameters.Add(New SqlParameter("@vis_per_id", SqlDbType.Int)).Value = Codigo

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