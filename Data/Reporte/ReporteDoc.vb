Imports System.Data.SqlClient

Namespace Reporte
    Public Class ReporteDoc
        Private Shared strNameProcedure As String = "UP_RPT_Reporte"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ent As Entity.Reporte.ReporteDoc) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@rpt_id", SqlDbType.Int)).Value = ent.Codigo
                    .Parameters.Add(New SqlParameter("@fk_rpt_tip_id", SqlDbType.Int)).Value = ent.TipoReporteId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

    End Class
End Namespace