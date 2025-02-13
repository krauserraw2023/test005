Imports System.Data.SqlClient

Namespace Reporte
    Public Class ReporteCabecera
        Private Shared strNameProcedure As String = "UP_RPT_ReporteCabecera"

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ReporteId As Integer, Anio As Integer) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@fk_rpt_id", SqlDbType.Int)).Value = ReporteId
                            .Parameters.Add(New SqlParameter("@n_anio", SqlDbType.Int)).Value = Anio

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

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, CabeceraReporteId As Integer) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_rpt_cab_id", SqlDbType.Int)).Value = CabeceraReporteId

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

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ent As Entity.Reporte.ReporteCabecera) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_rpt_cab_id", SqlDbType.Int)).Value = ent.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = ent.InternoId
                    .Parameters.Add(New SqlParameter("@n_anio", SqlDbType.Int)).Value = ent.Anio
                    .Parameters.Add(New SqlParameter("@n_num", SqlDbType.Int)).Value = ent.NumSerie
                    .Parameters.Add(New SqlParameter("@n_num_print", SqlDbType.Int)).Value = ent.NumeroImpresion
                    .Parameters.Add(New SqlParameter("@fk_rpt_id", SqlDbType.Int)).Value = ent.CodigoReporteId
                    .Parameters.Add(New SqlParameter("@fk_rpt_cab_id", SqlDbType.Int)).Value = ent.CodigoId
                    .Parameters.Add(New SqlParameter("@_regId", SqlDbType.Int)).Value = ent.RegionId
                    .Parameters.Add(New SqlParameter("@_penId", SqlDbType.Int)).Value = ent.PenalId
                    .Parameters.Add(New SqlParameter("@tip_rpt_id", SqlDbType.Int)).Value = ent.TipoReporteId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal ent As Entity.Reporte.ReporteCabecera) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_rpt_cab_id", SqlDbType.Int)).Value = ent.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = ent.InternoId
                            .Parameters.Add(New SqlParameter("@n_anio", SqlDbType.Int)).Value = ent.Anio
                            .Parameters.Add(New SqlParameter("@n_num", SqlDbType.Int)).Value = ent.NumSerie
                            .Parameters.Add(New SqlParameter("@n_num_print", SqlDbType.Int)).Value = ent.NumeroImpresion
                            .Parameters.Add(New SqlParameter("@n_fec_emi", SqlDbType.BigInt)).Value = ent.FechaEmision
                            .Parameters.Add(New SqlParameter("@fk_rpt_id", SqlDbType.Int)).Value = ent.CodigoReporteId
                            .Parameters.Add(New SqlParameter("@fk_rpt_cab_id", SqlDbType.Int)).Value = ent.CodigoId
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