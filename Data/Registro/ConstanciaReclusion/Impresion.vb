Imports System.Data
Imports System.Data.SqlClient
Namespace Registro.ConstanciaReclusion
    Public Class Impresion
        Private Shared strNameProcedure As String = "usp_reg_cons_reclu_mov_impresion"

#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String,
                                                  objEntFiltro As Entity.Registro.ConstanciaReclusion.Impresion) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@fk_cons_rec_tra_id", SqlDbType.Int)).Value = objEntFiltro.codigoCR

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intValue = .Parameters("@variable_out").Value
                            Return intValue
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      objEntFiltro As Entity.Registro.ConstanciaReclusion.Impresion) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@fk_cons_rec_tra_id", SqlDbType.Int)).Value = objEntFiltro.codigoCR
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEntFiltro.idRegion
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEntFiltro.idPenal
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
#End Region
#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Registro.ConstanciaReclusion.Impresion) As Integer

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@fk_cons_rec_tra_id", SqlDbType.Int)).Value = objEnt.codigoCR
                            .Parameters.Add(New SqlParameter("@n_item", SqlDbType.Int)).Value = objEnt.item
                            .Parameters.Add(New SqlParameter("@c_mot_imp", SqlDbType.VarChar, 100)).Value = objEnt.motivoImpresion
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.idRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt.idPenal
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.DateTime2)).Value = DateTime.Today
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            Return .Parameters("@variable_out").Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
    End Class
#End Region
End Namespace

