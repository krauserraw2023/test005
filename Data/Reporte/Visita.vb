Imports System.Data
Imports System.Data.SqlClient
Namespace Reporte
    Public Class Visita
        Private Shared strNameProcedure As String = "UP_VIS_Reporte"        
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ByVal objEnt As Entity.Reporte.Visita.Filtro) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.BigInt)).Value = objEnt.VisitanteID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.BigInt)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaInicio
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = objEnt.EstadoID

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarDataSet(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ByVal objEnt As Entity.Reporte.Visita.Filtro) As DataSet

            Dim value As New DataSet
            Try
                sqlCon.Open()
                Dim sqladap As SqlDataAdapter = New SqlDataAdapter(strNameProcedure, sqlCon)
                With sqladap
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .SelectCommand.Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .SelectCommand.Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .SelectCommand.Parameters.Add(New SqlParameter("@vis_id", SqlDbType.BigInt)).Value = objEnt.VisitanteID
                    .SelectCommand.Parameters.Add(New SqlParameter("@int_id", SqlDbType.BigInt)).Value = objEnt.InternoID
                    .SelectCommand.Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaInicio
                    .SelectCommand.Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin
                    .SelectCommand.Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .SelectCommand.Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                    .SelectCommand.Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = objEnt.PabellonID
                    .SelectCommand.Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                End With
                sqladap.Fill(value, "UP_VIS_Reporte")
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return value
        End Function
    End Class
End Namespace

