Option Explicit On
Imports System.Data.SqlClient
Namespace Transferencia

    Public Class Monitoreo
        Private Shared strNameProcedure As String = "UP_TRA_MonitoreoPenal"
        Public Shared Function Grabar(strCNBD As String, ByVal accion As String, ByVal opcion As String,
                                      intIDRegion As Short, intIDPenal As Short, intBloqueo As Short, ByRef strMensajeOut As String) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(strCNBD)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 60 * 5
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = intIDRegion
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = intIDPenal
                            .Parameters.Add(New SqlParameter("@bloq_tranfer", SqlDbType.SmallInt)).Value = intBloqueo

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_out").Value
                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                strMensajeOut = ex.Message.ToString
                Return -1
            End Try
        End Function
    End Class
End Namespace