Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoBanda
        Private Shared strNameProcedure As String = "pa_reg_mov_internobanda"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
                                            InternoId As Integer, BandaId As Integer) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ban_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoId
                            .Parameters.Add(New SqlParameter("@ban_id", SqlDbType.Int)).Value = BandaId                            

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
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
                                            objEnt As Entity.Registro.InternoBanda) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ban_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@ban_id", SqlDbType.Int)).Value = objEnt.BandaID

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objEntIntBan As Entity.Registro.InternoBanda) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_ban_id", SqlDbType.Int)).Value = objEntIntBan.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntIntBan.InternoID
                    .Parameters.Add(New SqlParameter("@ban_id", SqlDbType.Int)).Value = objEntIntBan.BandaID

                    '.Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEntIntBan.RegioID
                    '.Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEntIntBan.PenalID


                    '.Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 120)).Value = objEntIntBan.CodigoInterno
                    '.Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 120)).Value = objEntIntBan.ApePatInterno
                    '.Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 120)).Value = objEntIntBan.ApeMatInterno
                    '.Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 120)).Value = objEntIntBan.NombresInterno

                    '.Parameters.Add(New SqlParameter("@ban_mie_tip_id", SqlDbType.Int)).Value = objEntIntBan.BandaMiembroTipoID
                    '.Parameters.Add(New SqlParameter("@int_ban_est", SqlDbType.Int)).Value = objEntIntBan.Estado
                    '.Parameters.Add(New SqlParameter("@tip_band_id", SqlDbType.Int)).Value = objEntIntBan.BandaTipoID

                    '.Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEntIntBan.IngresoID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar2(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objEntIntBan As Entity.Registro.InternoBanda) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_ban_id", SqlDbType.Int)).Value = objEntIntBan.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntIntBan.InternoID
                    .Parameters.Add(New SqlParameter("@ban_id", SqlDbType.Int)).Value = objEntIntBan.BandaID

                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEntIntBan.RegioID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEntIntBan.PenalID


                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 120)).Value = objEntIntBan.CodigoInterno
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 120)).Value = objEntIntBan.ApePatInterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 120)).Value = objEntIntBan.ApeMatInterno
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 120)).Value = objEntIntBan.NombresInterno

                    .Parameters.Add(New SqlParameter("@int_ban_est", SqlDbType.Int)).Value = objEntIntBan.Estado
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEntIntBan.IngresoID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objEntIntBan As Entity.Registro.InternoBanda) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_ban_id", SqlDbType.Int)).Value = objEntIntBan.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntIntBan.InternoID
                    .Parameters.Add(New SqlParameter("@ban_id", SqlDbType.Int)).Value = objEntIntBan.BandaID

                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEntIntBan.RegioID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEntIntBan.PenalID
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEntIntBan.SedeRowId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEntIntBan.IngresoInpeID


                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 120)).Value = objEntIntBan.CodigoInterno
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 120)).Value = objEntIntBan.ApePatInterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 120)).Value = objEntIntBan.ApeMatInterno
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 120)).Value = objEntIntBan.NombresInterno

                    .Parameters.Add(New SqlParameter("@int_ban_est", SqlDbType.Int)).Value = objEntIntBan.Estado
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEntIntBan.IngresoID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objIntBanda As Entity.Registro.InternoBanda) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ban_id", SqlDbType.Int)).Value = objIntBanda.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntBanda.InternoID
                           .Parameters.Add(New SqlParameter("@int_ape_nom", SqlDbType.VarChar, 120)).Value = objIntBanda.InternoApeNombres
                            .Parameters.Add(New SqlParameter("@ban_id", SqlDbType.Int)).Value = objIntBanda.BandaID

                            .Parameters.Add(New SqlParameter("@int_ban_est", SqlDbType.Int)).Value = objIntBanda.Estado                            
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objIntBanda.RegioID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objIntBanda.PenalID

                            .Parameters.Add(New SqlParameter("@int_ban_obs", SqlDbType.VarChar, 200)).Value = objIntBanda.Observacion
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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, ByVal objIntBanda As Entity.Registro.InternoBanda) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ban_id", SqlDbType.Int)).Value = objIntBanda.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntBanda.InternoID
                            .Parameters.Add(New SqlParameter("@int_ape_nom", SqlDbType.VarChar, 120)).Value = objIntBanda.InternoApeNombres
                            .Parameters.Add(New SqlParameter("@ban_id", SqlDbType.Int)).Value = objIntBanda.BandaID
                            .Parameters.Add(New SqlParameter("@int_ban_est", SqlDbType.Int)).Value = objIntBanda.Estado
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntBanda.IngresoID
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objIntBanda.RegioID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objIntBanda.PenalID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntBanda.IngresoInpeID
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objIntBanda.SedeRowId
                           
                            .Parameters.Add(New SqlParameter("@int_ban_obs", SqlDbType.VarChar, 200)).Value = objIntBanda.Observacion
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

        Public Shared Function Grabar2(ByVal accion As String, ByVal opcion As String, ByVal objIntBanda As Entity.Registro.InternoBanda) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ban_id", SqlDbType.Int)).Value = objIntBanda.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntBanda.InternoID
                            .Parameters.Add(New SqlParameter("@int_ape_nom", SqlDbType.VarChar, 120)).Value = objIntBanda.InternoApeNombres
                            
                            .Parameters.Add(New SqlParameter("@ban_id", SqlDbType.Int)).Value = objIntBanda.BandaID
                            .Parameters.Add(New SqlParameter("@int_ban_est", SqlDbType.Int)).Value = objIntBanda.Estado                            
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntBanda.IngresoID

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objIntBanda.RegioID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objIntBanda.PenalID

                            .Parameters.Add(New SqlParameter("@int_ban_obs", SqlDbType.VarChar, 200)).Value = objIntBanda.Observacion
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
                            .Parameters.Add(New SqlParameter("@int_ban_id", SqlDbType.Int)).Value = Codigo

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
