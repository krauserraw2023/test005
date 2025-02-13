Option Explicit On
Imports System.Data.SqlClient
Namespace Transferencia
    Public Class BandejaQuery
        Private Shared strNameProcedure As String = "usp_TRA_BandejaQuery"
        Public Shared Function Grabar(strCNBD As String, ByVal accion As String, ByVal opcion As String,
                                  objEnt As Entity.Transferencia.BandejaQuery, ByRef strMensajeOut As String) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(strCNBD)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 60 * 5
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_pen_ban_qry", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@fk_pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                            .Parameters.Add(New SqlParameter("@fk_tra_id", SqlDbType.Int)).Value = objEnt.IDArchivoTransfer
                            .Parameters.Add(New SqlParameter("@c_trs_nom_arc", SqlDbType.VarChar, 100)).Value = objEnt.ArchivoTransferNombre
                            .Parameters.Add(New SqlParameter("@n_trs_arc_cor", SqlDbType.Int)).Value = objEnt.ArchivoTrasnferNumero
                            .Parameters.Add(New SqlParameter("@n_tip_bd", SqlDbType.SmallInt)).Value = objEnt.TipoBD
                            .Parameters.Add(New SqlParameter("@c_qry", SqlDbType.VarChar, 0)).Value = objEnt.Query
                            .Parameters.Add(New SqlParameter("@n_est", SqlDbType.SmallInt)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo

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