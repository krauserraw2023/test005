Imports System.Data.SqlClient
Namespace Seguridad.Paquetes
    Public Class ArchivoDigital
        Private Shared strNameProcedure As String = "usp_seg_pqt_archivodigital"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      entArchDig As Entity.Seguridad.Paquetes.ArchivoDigital) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_arc_dig_id", SqlDbType.Int)).Value = entArchDig.codigo
                    .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = entArchDig.idRegion
                    .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = entArchDig.idPenal
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal entArchDig As Entity.Seguridad.Paquetes.ArchivoDigital) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_arc_dig_id", SqlDbType.Int)).Value = entArchDig.codigo
                            .Parameters.Add(New SqlParameter("@n_anio", SqlDbType.SmallInt)).Value = entArchDig.anio
                            .Parameters.Add(New SqlParameter("@n_mes", SqlDbType.SmallInt)).Value = entArchDig.mes
                            .Parameters.Add(New SqlParameter("@n_mes_cor", SqlDbType.SmallInt)).Value = entArchDig.mesCorrelativo
                            .Parameters.Add(New SqlParameter("@c_pc_mac", SqlDbType.VarChar, 20)).Value = entArchDig.pcMac
                            .Parameters.Add(New SqlParameter("@c_pc_nom", SqlDbType.VarChar, 20)).Value = entArchDig.pcNombre
                            .Parameters.Add(New SqlParameter("@c_pc_ip", SqlDbType.VarChar, 20)).Value = entArchDig.pcIP
                            .Parameters.Add(New SqlParameter("@b_arc_byte", SqlDbType.VarBinary, -1)).Value = entArchDig.archivoByte
                            .Parameters.Add(New SqlParameter("@c_nom_fis", SqlDbType.VarChar, 100)).Value = entArchDig.nombreFisico
                            .Parameters.Add(New SqlParameter("@c_arc_ext", SqlDbType.VarChar, 6)).Value = entArchDig.extension
                            .Parameters.Add(New SqlParameter("@n_arc_pes", SqlDbType.Int)).Value = entArchDig.pesoByte
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = entArchDig.idRegion
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = entArchDig.idPenal

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