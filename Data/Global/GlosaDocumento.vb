Imports System.Data.SqlClient

Namespace Globall
    Public Class GlosaDocumento
        Private Shared strNameProcedure As String = "pa_gen_mae_glosa_doc"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ent As Entity.Globall.GlosaDocumento) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_glo_doc_id", SqlDbType.Int)).Value = ent.Codigo
                    .Parameters.Add(New SqlParameter("@c_glo_desc", SqlDbType.VarChar, 300)).Value = ent.DescripcionCorta
                    .Parameters.Add(New SqlParameter("@c_glo_text", SqlDbType.Text)).Value = ent.Texto
                    .Parameters.Add(New SqlParameter("@n_glo_est_id", SqlDbType.Int)).Value = ent.EstadoId
                    .Parameters.Add(New SqlParameter("@fk_tip_glo_doc_id", SqlDbType.Int)).Value = ent.TipoGlosaId
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function
    End Class
End Namespace