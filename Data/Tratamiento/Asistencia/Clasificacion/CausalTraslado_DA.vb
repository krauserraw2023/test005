Imports Entity.Tratamiento.Asistencia.Clasificacion
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal
Imports System.Data.SqlClient

Namespace Tratamiento.Asistencia.Clasificacion


    Public Class CausalTraslado_DA
        Private Shared strNameProcedure As String = "usp_tra_asi_mae_causal_traslado"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal strAccion As String, ByVal strOpcion As String,
                                      objEnt As CausalTraslado_BE) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                    .Parameters.Add(New SqlParameter("@pk_causal_traslado_id", SqlDbType.Int)).Value = objEnt.Codigo
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function
    End Class
End Namespace