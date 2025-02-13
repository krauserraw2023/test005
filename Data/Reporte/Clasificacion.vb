Imports System.Data.SqlClient

Namespace Reporte
    Public Class Clasificacion
        Private Shared strNameProcedure As String = "UP_INT_Reporte"
        Public Shared Function Listar(sqlCon As SqlConnection, accion As String, opcion As String,
                                    InternoID As Long, IngresoInpeID As Long) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 60 * 4 'segundos x minutos
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.BigInt)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.BigInt)).Value = IngresoInpeID

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(strNameProcedure As String, sqlCon As SqlConnection, accion As String, opcion As String,
                                    InternoID As Long, IngresoId As Long) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 60 * 4 'segundos x minutos
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.BigInt)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.BigInt)).Value = IngresoId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar_LM(strNameProcedure As String, sqlCon As SqlConnection, accion As String, opcion As String,
                                    InternoID As Long, IngresoInpeID As Long) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 60 * 4 'segundos x minutos
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.BigInt)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.BigInt)).Value = IngresoInpeID

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
    End Class
End Namespace

