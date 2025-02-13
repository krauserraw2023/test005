Imports System.Data.SqlClient

Namespace Reporte
    Public Class ReporteTipo
        Private Shared strNameProcedure As String = "UP_RPT_ReporteTipo"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ent As Entity.Reporte.ReporteTipo) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_rpt_tip_id", SqlDbType.Int)).Value = ent.Codigo
                    .Parameters.Add(New SqlParameter("@c_nom", SqlDbType.VarChar, 300)).Value = ent.NombreTipo

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
    End Class
End Namespace