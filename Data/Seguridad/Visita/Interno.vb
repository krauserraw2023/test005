Imports System.Data
Imports System.Data.SqlClient

Namespace Visita
    Public Class Interno
        Private Shared strNameProcedure As String = "UP_VIS_Interno"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
                                            ByVal objEntFiltro As Entity.Visita.Interno) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntFiltro.Codigo
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objEntFiltro.CodigoRP
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objEntFiltro.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objEntFiltro.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objEntFiltro.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objEntFiltro.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 100)).Value = objEntFiltro.Nombres
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEntFiltro.IDRegion
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEntFiltro.IDPenal

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ByVal objEntFiltro As Entity.Visita.Interno) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntFiltro.Codigo
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEntFiltro.CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEntFiltro.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEntFiltro.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEntFiltro.Apellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEntFiltro.Nombres
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objEntFiltro.EstadoID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEntFiltro.IDRegion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEntFiltro.IDPenal

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, _
                                      ByVal objEnt As Entity.Visita.Interno) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.CodigoRP
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 60)).Value = objEnt.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 60)).Value = objEnt.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 60)).Value = objEnt.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objEnt.SexoID
                            .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objEnt.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objEnt.NacionalidadID
                            .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = objEnt.PabellonID
                            .Parameters.Add(New SqlParameter("@pab_str", SqlDbType.VarChar, 50)).Value = objEnt.PabellonNombre
                            .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                            .Parameters.Add(New SqlParameter("@int_obs", SqlDbType.VarChar, 500)).Value = objEnt.Obs
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.IDPenal

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = objEnt.Audit_FechaLong
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
#End Region

    End Class
End Namespace
