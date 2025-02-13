Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento
    Public Class AutoridadJudicial
        Private Shared strNameProcedure As String = "UP_INT_AutoridadJudicial"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.General.Parametrica) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@par_nom", SqlDbType.VarChar, 255)).Value = objEnt.Nombre
                    .Parameters.Add(New SqlParameter("@n_est", SqlDbType.SmallInt)).Value = objEnt.estado
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
    End Class
End Namespace

