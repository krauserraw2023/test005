Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoReniecError
        Private Shared strNombreProcedure As String = "UP_RNC_MensajeError"
#Region "Listar"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                  ByVal opcion As String, Codigo As Integer) As SqlDataReader
            'usar entity
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                'Dim intValue As Integer = -1
                Dim sqlCmd As SqlCommand = New SqlCommand(strNombreProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@msj_err_cod", SqlDbType.Int)).Value = Codigo
                    '.Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.Nombre
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function
#End Region
    End Class

End Namespace
