Imports System.Data
Imports System.Data.SqlClient
Namespace Clasificacion
    Public Class MaestroTipoFicha
        Private Shared strNameProcedure As String = "pa_tra_asi_mae_tipo_ficha"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ent As Entity.Registro.Carceleta.Clasificacion.MaestroTipoFicha_BE) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_tip_fic_id", SqlDbType.Int)).Value = ent.Codigo
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function


    End Class
End Namespace
