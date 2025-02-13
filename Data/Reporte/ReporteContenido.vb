Imports System.Data.SqlClient

Namespace Reporte
    Public Class ReporteContenido
        Private Shared strNameProcedure As String = "UP_RPT_ReporteContenido"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ent As Entity.Reporte.ReporteContenido) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_cont_id", SqlDbType.Int)).Value = ent.Codigo
                    .Parameters.Add(New SqlParameter("@fk_rpt_cab_id", SqlDbType.Int)).Value = ent.RptCabeceraId
                    .Parameters.Add(New SqlParameter("@c_clave", SqlDbType.VarChar, 150)).Value = ent.ClaveStr
                    .Parameters.Add(New SqlParameter("@_regId", SqlDbType.Int)).Value = ent.RegionId
                    .Parameters.Add(New SqlParameter("@_penId", SqlDbType.Int)).Value = ent.PenalId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal ent As Entity.Reporte.ReporteContenido) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_cont_id", SqlDbType.Int)).Value = ent.Codigo
                            .Parameters.Add(New SqlParameter("@fk_rpt_cab_id", SqlDbType.Int)).Value = ent.RptCabeceraId
                            .Parameters.Add(New SqlParameter("@c_clave", SqlDbType.VarChar, 150)).Value = ent.ClaveStr
                            .Parameters.Add(New SqlParameter("@c_valor", SqlDbType.VarChar, 2000)).Value = ent.ValorStr
                            .Parameters.Add(New SqlParameter("@n_valor", SqlDbType.Int)).Value = ent.ValorInt
                            .Parameters.Add(New SqlParameter("@_regId", SqlDbType.Int)).Value = ent.RegionId
                            .Parameters.Add(New SqlParameter("@_penId", SqlDbType.Int)).Value = ent.PenalId
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