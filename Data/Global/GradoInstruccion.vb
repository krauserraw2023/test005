Imports System.Data
Imports System.Data.SqlClient
Namespace Globall
    Public Class GradoInstruccion
        Private Shared strNameProcedure As String = "UP_GEN_gradoinstruccion"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                                ByVal objEntFiltro As Entity.Globall.GradoInstruccion) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = objEntFiltro.Codigo
                    .Parameters.Add(New SqlParameter("@cod_rnc", SqlDbType.VarChar, 100)).Value = objEntFiltro.CodigoRnc
                    .Parameters.Add(New SqlParameter("@par_nom", SqlDbType.NVarChar, 100)).Value = objEntFiltro.Nombre
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
    End Class
End Namespace
