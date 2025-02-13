Imports System.Data
Imports System.Data.SqlClient
Namespace Registro

    Public Class Interno
        Private Shared strNameProcedure As String = "UP_INT_Interno"

#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
                ByVal CodigoRP As String, ByVal TipoDocumentoID As Integer, ByVal NumeroDocumento As String, _
                ByVal ApellidoPaterno As String, _
                ByVal ApellidoMaterno As String, _
                ByVal Nombres As String, ByVal RegionID As Integer, ByVal PenalID As Integer) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 900
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = CodigoRP
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = NumeroDocumento
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = Nombres
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID

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
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, objInt As Entity.Registro.Interno) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 900
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objInt.Codigo
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInt.CodigoRP
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInt.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objInt.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@int_doc_num_aux", SqlDbType.VarChar, 50)).Value = objInt.NumeroDocumentoAux
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInt.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInt.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInt.Nombres
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objInt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objInt.PenalID

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
                                      ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal TipoInterno As Integer, ByVal CodigoRP As String, _
        ByVal ApellidoPaterno As String, _
        ByVal ApellidoMaterno As String, ByVal Apellidos As String, _
        ByVal Nombres As String, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, ByVal PenalMultiple As String, _
        ByVal SexoID As Integer, _
        ByVal FechaNac As Long, _
        ByVal NacimientoUbigeoID As Integer, ByVal NacionalidadExtranjero As Integer, _
        ByVal NacionalidadID As Integer, _
        ByVal DocumentoTipoID As Integer, _
        ByVal NumeroDocumento As String, _
        ByVal EstadoID As Integer, _
        ByVal DelitoGenericoID As Integer, _
        ByVal DelitoEspecificoID As Integer, _
        ByVal SituacionJuridicaID As Integer, _
        ByVal IngresoFechaDesde As Long, _
        ByVal IngresoFechaHasta As Long) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 900
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_tip_id", SqlDbType.Int)).Value = TipoInterno
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = Apellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = Nombres
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                    .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 250)).Value = PenalMultiple
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = SexoID
                    .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = FechaNac
                    .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = NacimientoUbigeoID
                    .Parameters.Add(New SqlParameter("@nac_ext", SqlDbType.Int)).Value = NacionalidadExtranjero
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = NacionalidadID
                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = DocumentoTipoID
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = NumeroDocumento
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = EstadoID
                    .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.Int)).Value = DelitoGenericoID
                    .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.Int)).Value = DelitoEspecificoID
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = SituacionJuridicaID
                    .Parameters.Add(New SqlParameter("@fec_ing_dsd", SqlDbType.BigInt)).Value = IngresoFechaDesde
                    .Parameters.Add(New SqlParameter("@fec_ing_hst", SqlDbType.BigInt)).Value = IngresoFechaHasta
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                              ByVal opcion As String, objEnt As Entity.Registro.Interno) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 900
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objEnt.CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 100)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 250)).Value = objEnt.PenalMultiple
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objEnt.SexoID
                    .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objEnt.FechaNacimiento
                    .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = objEnt.NacimientoUbigeoID
                    .Parameters.Add(New SqlParameter("@nac_ext", SqlDbType.Int)).Value = objEnt.NacionalidadExtranjero
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objEnt.NacionalidadID
                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                    .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.Int)).Value = objEnt.DelitoGenericoID
                    .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecificoID
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = objEnt.SituacionJuridicaId
                    .Parameters.Add(New SqlParameter("@fec_ing_dsd", SqlDbType.BigInt)).Value = objEnt.IngresoFechaDesde
                    .Parameters.Add(New SqlParameter("@fec_ing_hst", SqlDbType.BigInt)).Value = objEnt.IngresoFechaHasta
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEnt.SedeRowId
                    .Parameters.Add(New SqlParameter("@n_int_pen_bloq_id", SqlDbType.Int)).Value = objEnt.EstadoBloqueoId
                    .Parameters.Add(New SqlParameter("@c_ver_reg", SqlDbType.VarChar, 10)).Value = objEnt.VersionRegistro
                    Try
                        .Parameters.Add(New SqlParameter("@c_int_cod_uni", SqlDbType.VarChar, (20))).Value = objEnt.CodigoUnicoInterno
                        .Parameters.Add(New SqlParameter("@c_int_nom_clav", SqlDbType.VarChar, (20))).Value = objEnt.NombreClaveInterno
                    Catch ex As Exception

                    End Try
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                              ByVal opcion As String, objEnt As Entity.Registro.Interno) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 900
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objEnt.CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 100)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 250)).Value = objEnt.PenalMultiple
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objEnt.SexoID
                    .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objEnt.FechaNacimiento
                    .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = objEnt.NacimientoUbigeoID
                    .Parameters.Add(New SqlParameter("@nac_ext", SqlDbType.Int)).Value = objEnt.NacionalidadExtranjero
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objEnt.NacionalidadID
                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                    .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.Int)).Value = objEnt.DelitoGenericoID
                    .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecificoID
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = objEnt.SituacionJuridicaId
                    .Parameters.Add(New SqlParameter("@fec_ing_dsd", SqlDbType.BigInt)).Value = objEnt.IngresoFechaDesde
                    .Parameters.Add(New SqlParameter("@fec_ing_hst", SqlDbType.BigInt)).Value = objEnt.IngresoFechaHasta
                    Try
                        .Parameters.Add(New SqlParameter("@c_int_cod_uni", SqlDbType.VarChar, (20))).Value = objEnt.CodigoUnicoInterno
                        .Parameters.Add(New SqlParameter("@c_int_nom_clav", SqlDbType.VarChar, (20))).Value = objEnt.NombreClaveInterno
                    Catch ex As Exception

                    End Try
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function
#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Registro.Interno) As Integer

            'VERSION 4.5
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objInterno.Codigo
                            '.Parameters.Add(New SqlParameter("@int_tip_id", SqlDbType.Int)).Value = objInterno.TipoInterno
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInterno.CodigoRP
                            .Parameters.Add(New SqlParameter("@int_lib", SqlDbType.VarChar, 20)).Value = objInterno.Libro
                            .Parameters.Add(New SqlParameter("@int_fol", SqlDbType.VarChar, 20)).Value = objInterno.Folio
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInterno.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objInterno.SexoID
                            .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objInterno.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@ubg_pai_id", SqlDbType.Int)).Value = objInterno.NacimientoPaisID
                            .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = objInterno.NacimientoUbigeoID
                            .Parameters.Add(New SqlParameter("@ubg_nac_otro", SqlDbType.VarChar, 100)).Value = objInterno.NacimientoOtros
                            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objInterno.NacionalidadID
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInterno.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objInterno.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@ubg_id_dir", SqlDbType.Int)).Value = objInterno.DomicilioUbigeoID
                            .Parameters.Add(New SqlParameter("@int_dir_nom", SqlDbType.VarChar, 200)).Value = objInterno.Domicilio
                            .Parameters.Add(New SqlParameter("@est_civ_id", SqlDbType.Int)).Value = objInterno.EstadoCivilID
                            .Parameters.Add(New SqlParameter("@niv_aca_id", SqlDbType.Int)).Value = objInterno.NivelAcademicoID
                            .Parameters.Add(New SqlParameter("@int_hij_men", SqlDbType.Int)).Value = objInterno.HijosMenores
                            .Parameters.Add(New SqlParameter("@pro_id", SqlDbType.Int)).Value = objInterno.ProfesionID
                            .Parameters.Add(New SqlParameter("@ocu_id", SqlDbType.Int)).Value = objInterno.OcupacionID
                            .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objInterno.EstadoID
                            .Parameters.Add(New SqlParameter("@int_dis_id", SqlDbType.Int)).Value = objInterno.Discapacidad
                            .Parameters.Add(New SqlParameter("@int_com_id", SqlDbType.Int)).Value = objInterno.ComunidadAndinaID
                            .Parameters.Add(New SqlParameter("@int_com_esp_id", SqlDbType.Int)).Value = objInterno.ComunidadAndinaEspID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objInterno.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objInterno.PenalID
                            .Parameters.Add(New SqlParameter("@int_obs", SqlDbType.VarChar, 500)).Value = objInterno.Obs
                            .Parameters.Add(New SqlParameter("@int_obs_dni", SqlDbType.VarChar, 500)).Value = objInterno.Obs_DNI
                            .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = objInterno.PabellonID
                            .Parameters.Add(New SqlParameter("@pab_str", SqlDbType.VarChar, 50)).Value = objInterno.PabellonNombre
                            .Parameters.Add(New SqlParameter("@int_fec_isp", SqlDbType.BigInt)).Value = objInterno.IngresoSistemaPen
                            .Parameters.Add(New SqlParameter("@int_est_rnc", SqlDbType.BigInt)).Value = objInterno.EstadoRncID
                            .Parameters.Add(New SqlParameter("@c_ver_reg", SqlDbType.VarChar, 10)).Value = objInterno.VersionRegistro
                            '.Parameters.Add(New SqlParameter("@c_int_dec", SqlDbType.VarChar, (20))).Value = objInterno.Decadactilar

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_flg_eli", SqlDbType.Bit)).Value = objInterno.Eliminado
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

        Public Shared Function Grabar2(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Registro.Interno) As Integer

            'VERSION 5
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objInterno.Codigo
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInterno.CodigoRP
                            .Parameters.Add(New SqlParameter("@int_lib", SqlDbType.VarChar, 20)).Value = objInterno.Libro
                            .Parameters.Add(New SqlParameter("@int_fol", SqlDbType.VarChar, 20)).Value = objInterno.Folio
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInterno.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objInterno.SexoID
                            .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objInterno.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@ubg_pai_id", SqlDbType.Int)).Value = objInterno.NacimientoPaisID
                            .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = objInterno.NacimientoUbigeoID
                            .Parameters.Add(New SqlParameter("@ubg_nac_otro", SqlDbType.VarChar, 100)).Value = objInterno.NacimientoOtros
                            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objInterno.NacionalidadID
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInterno.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objInterno.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@ubg_id_dir", SqlDbType.Int)).Value = objInterno.DomicilioUbigeoID
                            .Parameters.Add(New SqlParameter("@int_dir_nom", SqlDbType.VarChar, 200)).Value = objInterno.Domicilio
                            .Parameters.Add(New SqlParameter("@est_civ_id", SqlDbType.Int)).Value = objInterno.EstadoCivilID
                            .Parameters.Add(New SqlParameter("@niv_aca_id", SqlDbType.Int)).Value = objInterno.NivelAcademicoID
                            .Parameters.Add(New SqlParameter("@int_hij_men", SqlDbType.Int)).Value = objInterno.HijosMenores
                            .Parameters.Add(New SqlParameter("@pro_id", SqlDbType.Int)).Value = objInterno.ProfesionID
                            .Parameters.Add(New SqlParameter("@ocu_id", SqlDbType.Int)).Value = objInterno.OcupacionID
                            .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objInterno.EstadoID
                            .Parameters.Add(New SqlParameter("@int_dis_id", SqlDbType.Int)).Value = objInterno.Discapacidad
                            .Parameters.Add(New SqlParameter("@int_com_id", SqlDbType.Int)).Value = objInterno.ComunidadAndinaID
                            .Parameters.Add(New SqlParameter("@int_com_esp_id", SqlDbType.Int)).Value = objInterno.ComunidadAndinaEspID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objInterno.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objInterno.PenalID
                            .Parameters.Add(New SqlParameter("@int_obs", SqlDbType.VarChar, 500)).Value = objInterno.Obs
                            .Parameters.Add(New SqlParameter("@int_obs_dni", SqlDbType.VarChar, 500)).Value = objInterno.Obs_DNI
                            .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = objInterno.PabellonID
                            .Parameters.Add(New SqlParameter("@pab_str", SqlDbType.VarChar, 50)).Value = objInterno.PabellonNombre
                            .Parameters.Add(New SqlParameter("@int_fec_isp", SqlDbType.BigInt)).Value = objInterno.IngresoSistemaPen
                            .Parameters.Add(New SqlParameter("@int_est_rnc", SqlDbType.BigInt)).Value = objInterno.EstadoRncID
                            .Parameters.Add(New SqlParameter("@c_int_dec", SqlDbType.VarChar, (20))).Value = objInterno.Decadactilar
                            .Parameters.Add(New SqlParameter("@b_int_hom", SqlDbType.Bit)).Value = objInterno.Homonimia
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objInterno.DocJudIDAux
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objInterno.IngresoID
                            .Parameters.Add(New SqlParameter("@c_ver_reg", SqlDbType.VarChar, 10)).Value = objInterno.VersionRegistro

                            .Parameters.Add(New SqlParameter("@fk_idm_nat_id", SqlDbType.Int)).Value = objInterno.IdiomaNativoId
                            .Parameters.Add(New SqlParameter("@fk_gnro_id", SqlDbType.Int)).Value = objInterno.GeneroId
                            .Parameters.Add(New SqlParameter("@c_cen_trab", SqlDbType.VarChar, (150))).Value = objInterno.CentroTrabajo
                            .Parameters.Add(New SqlParameter("@fk_rel_id", SqlDbType.Int)).Value = objInterno.ReligionId
                            .Parameters.Add(New SqlParameter("@fk_cod_fza_arm_id", SqlDbType.Int)).Value = objInterno.CodigoFuerzaArmadaId
                            .Parameters.Add(New SqlParameter("@fk_cod_ran_id", SqlDbType.Int)).Value = objInterno.CodigoRangoId
                            .Parameters.Add(New SqlParameter("@c_int_cod_uni", SqlDbType.VarChar, (20))).Value = objInterno.CodigoUnicoInterno
                            .Parameters.Add(New SqlParameter("@c_int_nom_clav", SqlDbType.VarChar, (20))).Value = objInterno.NombreClaveInterno
                            .Parameters.Add(New SqlParameter("@n_cen_men", SqlDbType.Int)).Value = objInterno.CentroReclusionMenorId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_flg_eli", SqlDbType.Bit)).Value = objInterno.Eliminado
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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Registro.Interno) As Integer

            'creado: 14-12-2016
            'grabar carceleta,orl y plm

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objInterno.Codigo
                            .Parameters.Add(New SqlParameter("@int_tip_id", SqlDbType.SmallInt)).Value = objInterno.TipoInterno
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInterno.CodigoRP
                            .Parameters.Add(New SqlParameter("@n_cen_men", SqlDbType.SmallInt)).Value = objInterno.CentroReclusionMenorId
                            .Parameters.Add(New SqlParameter("@int_lib", SqlDbType.VarChar, 20)).Value = objInterno.Libro
                            .Parameters.Add(New SqlParameter("@int_fol", SqlDbType.VarChar, 20)).Value = objInterno.Folio
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInterno.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objInterno.SexoID
                            .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objInterno.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@ubg_pai_id", SqlDbType.Int)).Value = objInterno.NacimientoPaisID
                            .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = objInterno.NacimientoUbigeoID
                            .Parameters.Add(New SqlParameter("@ubg_nac_otro", SqlDbType.VarChar, 100)).Value = objInterno.NacimientoOtros
                            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objInterno.NacionalidadID
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInterno.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objInterno.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@ubg_id_dir", SqlDbType.Int)).Value = objInterno.DomicilioUbigeoID
                            .Parameters.Add(New SqlParameter("@int_dir_nom", SqlDbType.VarChar, 200)).Value = objInterno.Domicilio
                            .Parameters.Add(New SqlParameter("@est_civ_id", SqlDbType.Int)).Value = objInterno.EstadoCivilID
                            .Parameters.Add(New SqlParameter("@niv_aca_id", SqlDbType.Int)).Value = objInterno.NivelAcademicoID
                            .Parameters.Add(New SqlParameter("@int_hij_men", SqlDbType.Int)).Value = objInterno.HijosMenores
                            .Parameters.Add(New SqlParameter("@pro_id", SqlDbType.Int)).Value = objInterno.ProfesionID
                            .Parameters.Add(New SqlParameter("@ocu_id", SqlDbType.Int)).Value = objInterno.OcupacionID
                            .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objInterno.EstadoID
                            .Parameters.Add(New SqlParameter("@int_dis_id", SqlDbType.Int)).Value = objInterno.Discapacidad
                            .Parameters.Add(New SqlParameter("@int_com_id", SqlDbType.Int)).Value = objInterno.ComunidadAndinaID
                            .Parameters.Add(New SqlParameter("@int_com_esp_id", SqlDbType.Int)).Value = objInterno.ComunidadAndinaEspID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objInterno.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objInterno.PenalID
                            .Parameters.Add(New SqlParameter("@int_obs", SqlDbType.VarChar, 500)).Value = objInterno.Obs
                            .Parameters.Add(New SqlParameter("@int_obs_dni", SqlDbType.VarChar, 500)).Value = objInterno.Obs_DNI
                            .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = objInterno.PabellonID
                            .Parameters.Add(New SqlParameter("@pab_str", SqlDbType.VarChar, 50)).Value = objInterno.PabellonNombre
                            .Parameters.Add(New SqlParameter("@int_fec_isp", SqlDbType.BigInt)).Value = objInterno.IngresoSistemaPen
                            .Parameters.Add(New SqlParameter("@int_est_rnc", SqlDbType.BigInt)).Value = objInterno.EstadoRncID
                            .Parameters.Add(New SqlParameter("@c_int_dec", SqlDbType.VarChar, (20))).Value = objInterno.Decadactilar
                            .Parameters.Add(New SqlParameter("@b_int_hom", SqlDbType.Bit)).Value = objInterno.Homonimia
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objInterno.DocJudIDAux
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objInterno.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objInterno.IngresoID
                            .Parameters.Add(New SqlParameter("@fk_idm_nat_id", SqlDbType.Int)).Value = objInterno.IdiomaNativoId
                            .Parameters.Add(New SqlParameter("@fk_gnro_id", SqlDbType.Int)).Value = objInterno.GeneroId
                            .Parameters.Add(New SqlParameter("@c_cen_trab", SqlDbType.VarChar, (150))).Value = objInterno.CentroTrabajo
                            .Parameters.Add(New SqlParameter("@fk_rel_id", SqlDbType.Int)).Value = objInterno.ReligionId
                            .Parameters.Add(New SqlParameter("@fk_cod_fza_arm_id", SqlDbType.Int)).Value = objInterno.CodigoFuerzaArmadaId
                            .Parameters.Add(New SqlParameter("@fk_cod_ran_id", SqlDbType.Int)).Value = objInterno.CodigoRangoId
                            .Parameters.Add(New SqlParameter("@c_int_cod_uni", SqlDbType.VarChar, (20))).Value = objInterno.CodigoUnicoInterno
                            .Parameters.Add(New SqlParameter("@c_int_nom_clav", SqlDbType.VarChar, (20))).Value = objInterno.NombreClaveInterno
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objInterno.SedeRowId
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objInterno.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@c_ver_reg", SqlDbType.VarChar, 10)).Value = objInterno.VersionRegistro

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_flg_eli", SqlDbType.Bit)).Value = objInterno.Eliminado
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

#End Region
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede

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
                Return -1
            End Try
        End Function

        Public Shared Function Eliminar_x_ingreso(ByVal accion As String, ByVal opcion As String, ByVal ingresoId As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = ingresoId
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede

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
                Return -1
            End Try
        End Function


    End Class
End Namespace
