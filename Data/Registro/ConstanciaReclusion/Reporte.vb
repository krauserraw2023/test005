Imports System.Data.SqlClient

Namespace Registro.ConstanciaReclusion

    Public Class Reporte
        Private Shared strNameProcedure As String = "usp_reg_rpt_constancia_reclusion"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      filtro As Entity.Registro.ConstanciaReclusion.ReporteFiltro) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_cons_rec_tra_id", SqlDbType.Int)).Value = filtro.idTramiteCR
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = filtro.idRegion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = filtro.idPenal
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.DateTime2)).Value = filtro.fechaInicio
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.DateTime2)).Value = filtro.fechaFin
                    .Parameters.Add(New SqlParameter("@id_sol_tra", SqlDbType.SmallInt)).Value = filtro.idSolicitante
                    .Parameters.Add(New SqlParameter("@tip_tram", SqlDbType.SmallInt)).Value = filtro.tipoTramite
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
    End Class
End Namespace