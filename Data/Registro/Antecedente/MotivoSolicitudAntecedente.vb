Imports System.Data.SqlClient

Namespace Registro.Antecedente
    Public Class MotivoSolicitudAntecedente
        Private Shared strNameProcedure As String = "pa_anj_mae_motivo_solicitud"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                            objEnt As Entity.Registro.Antecedente.MotivoSolicitudAntecedente) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = "lst"
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = "lst_mant"
                    .Parameters.Add(New SqlParameter("@pk_mot_sol_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@tip_aut_jud_id", SqlDbType.Int)).Value = objEnt.TipoAutoridadJudicialId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try

            Return sqlReader

        End Function
    End Class
End Namespace