Imports System.Data.SqlClient

Namespace Tratamiento.TallerAsistencia
    Public Class TallerMae
        Private Shared strNameProcedure As String = "usp_tra_tal_taller_mae"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Tratamiento.TallerAsistencia.TallerMae) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion                    
                    .Parameters.Add(New SqlParameter("@pk_tra_tal_id", SqlDbType.Int)).Value = objEnt.Codigo

                    .Parameters.Add(New SqlParameter("@c_tra_tal_nom", SqlDbType.VarChar, 50)).Value = objEnt.NombreTaller
                    .Parameters.Add(New SqlParameter("@fk_tra_tal_tip_act_id", SqlDbType.Int)).Value = objEnt.TipoActividadId
                    .Parameters.Add(New SqlParameter("@fk_tra_tal_act_id", SqlDbType.Int)).Value = objEnt.ActividadId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
    End Class
End Namespace