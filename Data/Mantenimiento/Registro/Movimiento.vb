Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.Registro
    Public Class Movimiento
        Private Shared strNameProcedure As String = "UP_INT_Movimiento"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
               objEnt As Entity.Mantenimiento.Registro.Movimiento) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@lic_ins_id", SqlDbType.Int)).Value = objEnt.IDTipoLicencia
                    .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.Int)).Value = objEnt.MovimientoTipoID
                    .Parameters.Add(New SqlParameter("@fil_nom", SqlDbType.VarChar, 100)).Value = objEnt.MovimientoMotivoNombre

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
    End Class
End Namespace
