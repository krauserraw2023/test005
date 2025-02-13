Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.Registro
    Public Class PadinCuadro13_Detalle
        Private Shared strNameProcedure As String = "usp_reg_pad_Cuadro013_Detalle"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Mantenimiento.Registro.PadinCuadro13_Detalle) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_cua_13_det_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_cua_13_id", SqlDbType.Int)).Value = objEnt.IDCuadro13
                    .Parameters.Add(New SqlParameter("@fk_mov_mot_id", SqlDbType.Int)).Value = objEnt.IDMovimientoMotivo
                    .Parameters.Add(New SqlParameter("@c_tip_egr_nom", SqlDbType.VarChar, 200)).Value = objEnt.MovimientoMotivoNombre
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Mantenimiento.Registro.PadinCuadro13_Detalle) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_cua_13_det_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_cua_13_id", SqlDbType.Int)).Value = objEnt.IDCuadro13
                            .Parameters.Add(New SqlParameter("@fk_mov_mot_id", SqlDbType.Int)).Value = objEnt.IDMovimientoMotivo
                            .Parameters.Add(New SqlParameter("@c_tip_egr_nom", SqlDbType.VarChar, 200)).Value = objEnt.MovimientoMotivoNombre

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
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Mantenimiento.Registro.PadinCuadro13_Detalle) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_cua_13_det_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_cua_13_id", SqlDbType.Int)).Value = objEnt.IDCuadro13
                            .Parameters.Add(New SqlParameter("@fk_mov_mot_id", SqlDbType.Int)).Value = objEnt.IDMovimientoMotivo
                            .Parameters.Add(New SqlParameter("@c_tip_egr_nom", SqlDbType.VarChar, 200)).Value = objEnt.MovimientoMotivoNombre

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_cua_13_det_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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