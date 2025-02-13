Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class Tipo
        Private Shared strNameProcedure As String = "UP_VIS_tipo"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ByVal vcodigo As Integer, _
        ByVal vnombre As String, _
        ByVal vESTADo As Integer, _
        ByVal vrequierecalendario As Integer, _
        ByVal vrequiereinterno As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@tip_id", SqlDbType.Int)).Value = vcodigo
                    .Parameters.Add(New SqlParameter("@tip_nom", SqlDbType.VarChar, 100)).Value = vnombre
                    .Parameters.Add(New SqlParameter("@tip_est", SqlDbType.Int)).Value = vESTADo
                    '.Parameters.Add(New SqlParameter("@tip_cal", SqlDbType.Int)).Value = vrequierecalendario
                    '.Parameters.Add(New SqlParameter("@tip_int", SqlDbType.Int)).Value = vrequiereinterno

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
    End Class
End Namespace

