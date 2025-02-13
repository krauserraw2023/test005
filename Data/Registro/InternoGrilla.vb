Imports System.Data
Imports System.Data.SqlClient
Namespace Registro

    Public Class InternoGrilla

        Private Shared strNameProcedure As String = "UP_INT_Interno_Grilla"
        Private Shared strNameProcedureCarceleta As String = "UP_INT_Interno_Grilla_Carceleta"


#Region "Listar"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ByVal objEnt As Entity.Registro.Interno_Grilla) As SqlDataReader

            'jmr, 07.01.2019
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 900
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@int_id_str", SqlDbType.VarChar)).Value = objEnt.IDInternoString
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.IDInterno
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.InternoCodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.PrimerApellido
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.SegundoApellido
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.PreNombres
                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.SmallInt)).Value = objEnt.IDTipoDocIdentidad
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objEnt.InternoNumeroDocumento
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.SmallInt)).Value = objEnt.IDSexo
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.SmallInt)).Value = objEnt.IDNacionalidad
                    .Parameters.Add(New SqlParameter("@nac_ext", SqlDbType.SmallInt)).Value = objEnt.NacionalidadExtranjero

                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.SmallInt)).Value = objEnt.IDInternoEstado
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.SmallInt)).Value = objEnt.IDSituacionJuridica
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                    .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 500)).Value = objEnt.IDPenalString
                    .Parameters.Add(New SqlParameter("@n_car_est_trs_id", SqlDbType.SmallInt)).Value = objEnt.TrasladadoDeCarceleta
                    .Parameters.Add(New SqlParameter("@est_int_car", SqlDbType.SmallInt)).Value = objEnt.EstadoInternoCarceletaId
                    .Parameters.Add(New SqlParameter("@n_cola", SqlDbType.BigInt)).Value = objEnt.NCola
                    .Parameters.Add(New SqlParameter("@int_nom_ali", SqlDbType.VarChar, 50)).Value = objEnt.InternoAlias

                    'nombres asociados
                    .Parameters.Add(New SqlParameter("@int_aso_pri", SqlDbType.SmallInt)).Value = objEnt.NombreAsociadoPrincipal
                    .Parameters.Add(New SqlParameter("@int_aso_est", SqlDbType.SmallInt)).Value = objEnt.NombreAsociadoEstado

                    .Parameters.Add(New SqlParameter("@reg_cla_id", SqlDbType.SmallInt)).Value = objEnt.IDRegionClasif
                    .Parameters.Add(New SqlParameter("@pen_cla_id", SqlDbType.SmallInt)).Value = objEnt.IDPenalClasif

                    '/*movimiento*/
                    .Parameters.Add(New SqlParameter("@mov_grp_id", SqlDbType.SmallInt)).Value = objEnt.IDGrupoMovimiento
                    .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.SmallInt)).Value = objEnt.IDTipoMovimiento
                    .Parameters.Add(New SqlParameter("@mov_mot_id", SqlDbType.SmallInt)).Value = objEnt.IDMotivoMovimiento
                    .Parameters.Add(New SqlParameter("@mov_est_id", SqlDbType.SmallInt)).Value = objEnt.IDMovimientoEstado

                    '/*fecha ini y fin*/
                    .Parameters.Add(New SqlParameter("@tip_fec", SqlDbType.SmallInt)).Value = objEnt.TipoFecha
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaIngresoIni
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaIngresoFin
                    'afiliacion
                    .Parameters.Add(New SqlParameter("@n_afi_est_id", SqlDbType.SmallInt)).Value = objEnt.IDAfiliacion

                    'delito
                    .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.SmallInt)).Value = objEnt.IDDelitoGenerico
                    .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.SmallInt)).Value = objEnt.IDDelitoEspecifico

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

        Public Shared Function Listar_Carceleta(ByVal sqlCon As SqlConnection, ByVal accion As String,
        ByVal opcion As String, ByVal objEnt As Entity.Registro.Interno_Grilla) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedureCarceleta, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 900
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.InternoCodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.PrimerApellido
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.SegundoApellido
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.PreNombres
                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.SmallInt)).Value = objEnt.IDTipoDocIdentidad
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.InternoNumeroDocumento
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.SmallInt)).Value = objEnt.IDSexo
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.SmallInt)).Value = objEnt.IDNacionalidad
                    .Parameters.Add(New SqlParameter("@nac_ext", SqlDbType.SmallInt)).Value = objEnt.NacionalidadExtranjero
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.SmallInt)).Value = objEnt.IDInternoEstado
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                    .Parameters.Add(New SqlParameter("@est_int_car", SqlDbType.SmallInt)).Value = objEnt.IDMotivoMovimiento
                    .Parameters.Add(New SqlParameter("@int_nom_ali", SqlDbType.VarChar, 50)).Value = objEnt.InternoAlias

                    'movimiento
                    .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.SmallInt)).Value = objEnt.IDTipoMovimiento
                    .Parameters.Add(New SqlParameter("@tip_fec", SqlDbType.SmallInt)).Value = objEnt.TipoFecha
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaIngresoIni
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaIngresoFin

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

#End Region
#Region "Listar_Visita"
        Public Shared Function ListarVisita(ByVal sqlCon As SqlConnection, ByVal accion As String,
                                      ByVal opcion As String, ByVal objEnt As Entity.Visita.Interno) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand("usp_int_interno_grilla_visita", sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.CodigoRP
                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.SmallInt)).Value = objEnt.TipoDocumentoID
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                    .Parameters.Add(New SqlParameter("@etp_id", SqlDbType.SmallInt)).Value = objEnt.EtapaID
                    .Parameters.Add(New SqlParameter("@pab_nom", SqlDbType.VarChar, 20)).Value = objEnt.PabellonNombre
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.SmallInt)).Value = objEnt.EstadoID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function
#End Region
#Region "Grabar"
        Public Shared Function Grabar(strSql As String) As Integer

            Dim value As Integer = -1

            Try

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.Text
                            .CommandTimeout = 60 * 5 'minutos

                            sqlCon.Open()
                            value = .ExecuteNonQuery()

                            Return value

                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try

        End Function
#End Region
#Region "Eliminar"
        Public Shared Function Eliminar(lngCola As Long) As Integer

            Try
                Dim strSql As String = ""

                Dim value As Integer = -1
                strSql = "delete from reg_mov_interno_grilla where n_cola=@n_cola"

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.Text
                            .Parameters.Add(New SqlParameter("@n_cola", SqlDbType.BigInt)).Value = lngCola
                            
                            sqlCon.Open()
                            value = .ExecuteNonQuery()
                            'If value > 0 Then                                
                            '    Dim dt_ind As DataTable = Listar.EjecutarSQL(sqlCon, "select @@identity")
                            '    value = dt_ind.Rows(0).Item(0)
                            'End If
                            Return value

                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try

        End Function
#End Region
        Public Class RegionLima
            Private Shared strNameProcedure As String = "UP_INT_Interno_Grilla_RegionLima"

            Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                          ByVal objEnt As Entity.Registro.Interno_Grilla) As SqlDataReader

                Dim sqlReader As SqlDataReader = Nothing
                Try
                    sqlCon.Open()
                    Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                    With sqlCmd
                        .CommandType = CommandType.StoredProcedure
                        .CommandTimeout = 900
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                        .Parameters.Add(New SqlParameter("@int_id_str", SqlDbType.VarChar)).Value = objEnt.IDInternoString
                        .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.InternoCodigoRP
                        .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.PrimerApellido
                        .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.SegundoApellido
                        .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                        .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.PreNombres
                        .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.SmallInt)).Value = objEnt.IDTipoDocIdentidad
                        .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objEnt.InternoNumeroDocumento
                        .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.SmallInt)).Value = objEnt.IDSexo
                        .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.SmallInt)).Value = objEnt.IDNacionalidad
                        .Parameters.Add(New SqlParameter("@nac_ext", SqlDbType.SmallInt)).Value = objEnt.NacionalidadExtranjero
                        .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.SmallInt)).Value = objEnt.IDInternoEstado
                        .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                        .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                        .Parameters.Add(New SqlParameter("@c_int_nom_clav", SqlDbType.VarChar, 50)).Value = objEnt.InternoAlias
                        .Parameters.Add(New SqlParameter("@int_nom_ali", SqlDbType.VarChar, 50)).Value = objEnt.InternoAlias
                        '/*movimiento*/
                        .Parameters.Add(New SqlParameter("@mov_grp_id", SqlDbType.SmallInt)).Value = objEnt.IDGrupoMovimiento
                        .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.SmallInt)).Value = objEnt.IDTipoMovimiento
                        .Parameters.Add(New SqlParameter("@mov_mot_id", SqlDbType.SmallInt)).Value = objEnt.IDMotivoMovimiento
                        .Parameters.Add(New SqlParameter("@mov_est_id", SqlDbType.SmallInt)).Value = objEnt.IDMovimientoEstado '--e.c.cc.
                        '/*fecha ini y fin*/
                        .Parameters.Add(New SqlParameter("@tip_fec", SqlDbType.SmallInt)).Value = objEnt.TipoFecha
                        .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaIngresoIni
                        .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaIngresoFin
                        .Parameters.Add(New SqlParameter("@n_car_est_trs_id", SqlDbType.SmallInt)).Value = objEnt.TrasladadoDeCarceleta
                        .Parameters.Add(New SqlParameter("@reg_cla_id", SqlDbType.SmallInt)).Value = objEnt.IDRegionClasif
                        .Parameters.Add(New SqlParameter("@pen_cla_id", SqlDbType.SmallInt)).Value = objEnt.IDPenalClasif

                        'delito
                        .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.SmallInt)).Value = objEnt.IDDelitoGenerico
                        .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.SmallInt)).Value = objEnt.IDDelitoEspecifico

                    End With

                    sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
                Catch ex As SqlException
                    Throw New Exception(ex.Message)
                End Try
                Return sqlReader

            End Function
        End Class

        Public Class SedeCentral
            Private Shared strNameProcedure As String = "UP_INT_Interno_Grilla_Sede"
            Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                               ByVal objEnt As Entity.Registro.Interno_Grilla) As SqlDataReader

                Dim sqlReader As SqlDataReader = Nothing
                Try
                    sqlCon.Open()
                    Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                    With sqlCmd
                        .CommandType = CommandType.StoredProcedure
                        .CommandTimeout = 900
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                        .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.InternoCodigoRP
                        .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.PrimerApellido
                        .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.SegundoApellido
                        .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                        .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.PreNombres
                        .Parameters.Add(New SqlParameter("@int_nom_ali", SqlDbType.VarChar, 50)).Value = objEnt.InternoAlias
                        .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.SmallInt)).Value = objEnt.IDTipoDocIdentidad
                        .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objEnt.InternoNumeroDocumento
                        .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.SmallInt)).Value = objEnt.IDSexo
                        .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.SmallInt)).Value = objEnt.IDNacionalidad
                        .Parameters.Add(New SqlParameter("@nac_ext", SqlDbType.SmallInt)).Value = objEnt.NacionalidadExtranjero

                        .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.SmallInt)).Value = objEnt.IDInternoEstado
                        .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                        .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                        .Parameters.Add(New SqlParameter("@int_id_str", SqlDbType.VarChar)).Value = objEnt.IDInternoString
                        .Parameters.Add(New SqlParameter("@n_cola", SqlDbType.BigInt)).Value = objEnt.NCola

                    End With
                    sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
                Catch ex As SqlException
                    Throw New Exception(ex.Message)
                End Try
                Return sqlReader

            End Function
        End Class
    End Class
End Namespace