Imports System.Data.SqlClient
Namespace Globall
    Public Class ArchivoDigitalizado
        Private Shared strNameProcedure As String = "pa_glo_mov_arch_digitalizado"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entArchDig As Entity.Globall.ArchivoDigitalizado) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_arc_dig_id", SqlDbType.Int)).Value = entArchDig.Codigo
                    .Parameters.Add(New SqlParameter("@n_arc_dig_tip_id", SqlDbType.Int)).Value = entArchDig.TipoArchivoDigital
                    .Parameters.Add(New SqlParameter("@fk_reg_tbl_id", SqlDbType.Int)).Value = entArchDig.IdRegistroForaneo
                    .Parameters.Add(New SqlParameter("@c_arc_dig_nom_fis", SqlDbType.VarChar, 100)).Value = entArchDig.NombreArchivo
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = entArchDig.SedeRowId
                    .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = entArchDig.RegionId
                    .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = entArchDig.PenalId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal entArchDig As Entity.Globall.ArchivoDigitalizado) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_arc_dig_id", SqlDbType.Int)).Value = entArchDig.Codigo
                            .Parameters.Add(New SqlParameter("@n_arc_dig_tip_id", SqlDbType.Int)).Value = entArchDig.TipoArchivoDigital
                            .Parameters.Add(New SqlParameter("@fk_reg_tbl_id", SqlDbType.Int)).Value = entArchDig.IdRegistroForaneo
                            .Parameters.Add(New SqlParameter("@n_arc_dig_anio", SqlDbType.SmallInt)).Value = entArchDig.Anio
                            .Parameters.Add(New SqlParameter("@n_arc_dig_mes", SqlDbType.Int)).Value = entArchDig.Mes
                            .Parameters.Add(New SqlParameter("@c_arc_dig_pc_mac", SqlDbType.VarChar, 20)).Value = entArchDig.Mac
                            .Parameters.Add(New SqlParameter("@c_arc_dig_pc", SqlDbType.VarChar, 20)).Value = entArchDig.NombrePc
                            .Parameters.Add(New SqlParameter("@c_arc_dig_ip", SqlDbType.VarChar, 20)).Value = entArchDig.Ip
                            .Parameters.Add(New SqlParameter("@b_arch_dig_byte", SqlDbType.VarBinary, entArchDig.ArchivoDigitalByte.Length + 10)).Value = entArchDig.ArchivoDigitalByte
                            .Parameters.Add(New SqlParameter("@c_arc_dig_nom_fis", SqlDbType.VarChar, 100)).Value = entArchDig.NombreArchivo
                            .Parameters.Add(New SqlParameter("@c_arc_dig_ext", SqlDbType.VarChar, 6)).Value = entArchDig.Extension
                            .Parameters.Add(New SqlParameter("@n_arc_dig_pes", SqlDbType.Int)).Value = entArchDig.PesoByte
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = entArchDig.SedeRowId 'sdffsdsfdsfd
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = entArchDig.RegionId
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = entArchDig.PenalId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
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
                            .Parameters.Add(New SqlParameter("pk_arc_dig_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
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
            End Try
        End Function
    End Class
End Namespace