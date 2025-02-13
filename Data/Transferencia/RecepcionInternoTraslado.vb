Imports System.Data.SqlClient
Namespace Transferencia
    Public Class RecepcionInternoTraslado
        Public Shared Function carceletaRecepcionTrasladoInterno(ByVal accion As String, ByVal opcion As String, internoId As Integer, regOrigenId As Integer, penOrigenId As Integer, MovimientoTrasladoId As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand("zxpdown_carceleta_interno_datos", sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = internoId
                            .Parameters.Add(New SqlParameter("@reg_ori_id", SqlDbType.Int)).Value = regOrigenId
                            .Parameters.Add(New SqlParameter("@pen_ori_id", SqlDbType.Int)).Value = penOrigenId
                            .Parameters.Add(New SqlParameter("@mov_trs_id", SqlDbType.Int)).Value = MovimientoTrasladoId
                            .Parameters.Add(New SqlParameter("@usu_id", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
    End Class
End Namespace