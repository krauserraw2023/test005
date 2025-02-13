Imports System.Data
Imports System.Data.SqlClient
Namespace General
    Public Class Parametrica
        Private Shared strNameProcedure As String = "UP_GEN_Parametrica"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String,
        ByVal opcion As String, ByVal Tipo As Integer,
        ByVal Padre As Integer, Optional ByVal Parametro1 As Integer = -1,
        Optional ByVal Parametro2 As Integer = -1) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@par_typ_id", SqlDbType.Int)).Value = Tipo
                    .Parameters.Add(New SqlParameter("@par_prn_id", SqlDbType.Int)).Value = Padre
                    .Parameters.Add(New SqlParameter("@par_1", SqlDbType.Int)).Value = Parametro1
                    .Parameters.Add(New SqlParameter("@par_2", SqlDbType.Int)).Value = Parametro2

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function


        Public Shared Function ListarTratamiento(ByVal sqlCon As SqlConnection, ByVal accion As String,
      ByVal opcion As String, ByVal Padre As Integer, Optional ByVal Parametro1 As Integer = -1,
                                      Optional ByVal Parametro2 As Integer = -1) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand("usp_tra_tal_maestras", sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.SmallInt)).Value = opcion
                    .Parameters.Add(New SqlParameter("@par_prn_id", SqlDbType.Int)).Value = Padre
                    .Parameters.Add(New SqlParameter("@par_1", SqlDbType.Int)).Value = Parametro1
                    .Parameters.Add(New SqlParameter("@par_2", SqlDbType.Int)).Value = Parametro2

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

    End Class
End Namespace
