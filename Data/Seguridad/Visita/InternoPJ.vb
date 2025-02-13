Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class InternoPJ
        Private Shared strNameProcedure As String = "UP_vis_mov_internopj"

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
                                            ByVal objEntFiltro As Entity.Visita.InternoPJ) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_pj", SqlDbType.Int)).Value = objEntFiltro.Codigo

                            .Parameters.Add(New SqlParameter("@kf_tip_doc_id", SqlDbType.SmallInt)).Value = objEntFiltro.IDTipoDocumento
                            .Parameters.Add(New SqlParameter("@c_int_pj_num_doc", SqlDbType.VarChar, 50)).Value = objEntFiltro.NumeroDocumento

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEntFiltro.IDRegion
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEntFiltro.IDPenal

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
        ByVal opcion As String, ByVal objEntFiltro As Entity.Visita.InternoPJ) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_int_pj", SqlDbType.Int)).Value = objEntFiltro.Codigo
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEntFiltro.IDRegion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEntFiltro.IDPenal

                    .Parameters.Add(New SqlParameter("@c_int_pj_pri_ape", SqlDbType.VarChar, 100)).Value = objEntFiltro.PrimerApellido
                    .Parameters.Add(New SqlParameter("@c_int_pj_seg_ape", SqlDbType.VarChar, 100)).Value = objEntFiltro.SegundoApellido
                    .Parameters.Add(New SqlParameter("@c_int_pj_pre_nom", SqlDbType.VarChar, 100)).Value = objEntFiltro.PreNombres
                    .Parameters.Add(New SqlParameter("@n_int_pj_est", SqlDbType.SmallInt)).Value = objEntFiltro.Estado

                    .Parameters.Add(New SqlParameter("@ape_nom", SqlDbType.VarChar, 100)).Value = objEntFiltro.Apellidos

                    .Parameters.Add(New SqlParameter("@kf_tip_doc_id", SqlDbType.SmallInt)).Value = objEntFiltro.IDTipoDocumento
                    .Parameters.Add(New SqlParameter("@c_int_pj_num_doc", SqlDbType.VarChar, 50)).Value = objEntFiltro.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@kf_pab_id", SqlDbType.Int)).Value = objEntFiltro.IDPabellon

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, _
                                      ByVal objEnt As Entity.Visita.InternoPJ) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_int_pj", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@c_int_pj_pri_ape", SqlDbType.VarChar, 100)).Value = objEnt.PrimerApellido
                            .Parameters.Add(New SqlParameter("@c_int_pj_seg_ape", SqlDbType.VarChar, 100)).Value = objEnt.SegundoApellido
                            .Parameters.Add(New SqlParameter("@c_int_pj_pre_nom", SqlDbType.VarChar, 100)).Value = objEnt.PreNombres
                            .Parameters.Add(New SqlParameter("@n_int_pj_sex", SqlDbType.SmallInt)).Value = objEnt.Sexo
                            .Parameters.Add(New SqlParameter("@n_int_pj_fec_nac", SqlDbType.BigInt)).Value = objEnt.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@kf_tip_doc_id", SqlDbType.SmallInt)).Value = objEnt.IDTipoDocumento
                            .Parameters.Add(New SqlParameter("@c_int_pj_num_doc", SqlDbType.VarChar, 100)).Value = objEnt.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@kf_nac_id", SqlDbType.Int)).Value = objEnt.IDNacionalidad
                            .Parameters.Add(New SqlParameter("@kf_pab_id", SqlDbType.Int)).Value = objEnt.IDPabellon
                            .Parameters.Add(New SqlParameter("@n_int_pj_fec_ing", SqlDbType.BigInt)).Value = objEnt.FechaIngreso
                            .Parameters.Add(New SqlParameter("@n_int_pj_fec_egr", SqlDbType.BigInt)).Value = objEnt.FechaEgreso
                            .Parameters.Add(New SqlParameter("@n_int_pj_est", SqlDbType.SmallInt)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@c_int_pj_obs", SqlDbType.VarChar, 500)).Value = objEnt.Observacion

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal

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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_pj", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
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
