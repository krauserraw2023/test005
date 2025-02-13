Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoHistorico
        Private Shared strNameProcedure As String = "UP_INT_InternoHistorico"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.InternoHistorico) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_hist_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID

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


        Public Shared Function ListarOutput_LM(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.InternoHistorico) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_hist_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
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
        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                              ByVal opcion As String, _
              objEnt As Entity.Registro.InternoHistorico) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_hist_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                              ByVal opcion As String, _
              objEnt As Entity.Registro.InternoHistorico) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_hist_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function
#End Region
#Region "Grabar"
      
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Registro.InternoHistorico) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objInterno.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objInterno.IngresoID                            
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInterno.CodigoRP
                            .Parameters.Add(New SqlParameter("@int_lib", SqlDbType.VarChar, 20)).Value = objInterno.Libro
                            .Parameters.Add(New SqlParameter("@int_fol", SqlDbType.VarChar, 20)).Value = objInterno.Folio
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInterno.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objInterno.SexoID
                            'nacimiento
                            .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objInterno.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@ubg_pai_id", SqlDbType.Int)).Value = objInterno.NacimientoPaisID
                            .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = objInterno.NacimientoUbigeoID
                            .Parameters.Add(New SqlParameter("@ubg_nac_otro", SqlDbType.VarChar, 100)).Value = objInterno.NacimientoOtros
                            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objInterno.NacionalidadID
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInterno.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objInterno.NumeroDocumento

                            'domicilio
                            .Parameters.Add(New SqlParameter("@ubg_id_dir", SqlDbType.Int)).Value = objInterno.DomicilioUbigeoID
                            .Parameters.Add(New SqlParameter("@aut_ubg_dep", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioDepartamentoNombre
                            .Parameters.Add(New SqlParameter("@aut_ubg_pro", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioProvinciaNombre
                            .Parameters.Add(New SqlParameter("@aut_ubg_dis", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioDistritoNombre
                            .Parameters.Add(New SqlParameter("@int_dir_nom", SqlDbType.VarChar, 200)).Value = objInterno.Domicilio

                            .Parameters.Add(New SqlParameter("@est_civ_id", SqlDbType.Int)).Value = objInterno.EstadoCivilID
                            .Parameters.Add(New SqlParameter("@niv_aca_id", SqlDbType.Int)).Value = objInterno.NivelAcademicoID
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
                            .Parameters.Add(New SqlParameter("@c_int_dec", SqlDbType.VarChar, (20))).Value = objInterno.Decadactilar
                            .Parameters.Add(New SqlParameter("@b_int_hom", SqlDbType.Bit)).Value = objInterno.Homonimia
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objInterno.DocJudIDAux

                            .Parameters.Add(New SqlParameter("@fk_idm_nat_id", SqlDbType.Int)).Value = objInterno.IdiomaNativoId
                            .Parameters.Add(New SqlParameter("@fk_gnro_id", SqlDbType.Int)).Value = objInterno.GeneroId
                            .Parameters.Add(New SqlParameter("@c_cen_trab", SqlDbType.VarChar, (150))).Value = objInterno.CentroTrabajo
                            .Parameters.Add(New SqlParameter("@fk_rel_id", SqlDbType.Int)).Value = objInterno.ReligionId
                            .Parameters.Add(New SqlParameter("@fk_cod_fza_arm_id", SqlDbType.Int)).Value = objInterno.CodigoFuerzaArmadaId
                            .Parameters.Add(New SqlParameter("@fk_cod_ran_id", SqlDbType.Int)).Value = objInterno.CodigoRangoId
                            .Parameters.Add(New SqlParameter("@c_int_cod_uni", SqlDbType.VarChar, (20))).Value = objInterno.CodigoUnicoInterno
                            .Parameters.Add(New SqlParameter("@c_int_nom_clav", SqlDbType.VarChar, (20))).Value = objInterno.NombreClaveInterno
                            .Parameters.Add(New SqlParameter("@n_cen_men", SqlDbType.Int)).Value = objInterno.CentroReclusionMenorId
                            'poblacion etnica
                            .Parameters.Add(New SqlParameter("@fk_grp_pbl_id", SqlDbType.Int)).Value = objInterno.IDGrupoPueblo
                            .Parameters.Add(New SqlParameter("@fk_pbl_id", SqlDbType.Int)).Value = objInterno.IDPueblo
                            .Parameters.Add(New SqlParameter("@n_otr_pbl", SqlDbType.VarChar, (100))).Value = objInterno.OtroPueblo
                            .Parameters.Add(New SqlParameter("@fk_grp_lga_mat_id", SqlDbType.Int)).Value = objInterno.IDGrupoLenguaMaterna
                            .Parameters.Add(New SqlParameter("@fk_lga_mat_id", SqlDbType.Int)).Value = objInterno.IDLenguaMaterna
                            .Parameters.Add(New SqlParameter("@fk_idm_id", SqlDbType.Int)).Value = objInterno.IDIdioma
                            '******************
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

        Public Shared Function GrabarV2(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Registro.InternoHistorico) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objInterno.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objInterno.IngresoID
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInterno.CodigoRP
                            .Parameters.Add(New SqlParameter("@int_lib", SqlDbType.VarChar, 20)).Value = objInterno.Libro
                            .Parameters.Add(New SqlParameter("@int_fol", SqlDbType.VarChar, 20)).Value = objInterno.Folio
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInterno.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objInterno.SexoID
                            'nacimiento
                            .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objInterno.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@ubg_pai_id", SqlDbType.Int)).Value = objInterno.NacimientoPaisID
                            .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = objInterno.NacimientoUbigeoID
                            .Parameters.Add(New SqlParameter("@ubg_nac_otro", SqlDbType.VarChar, 100)).Value = objInterno.NacimientoOtros
                            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objInterno.NacionalidadID
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInterno.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objInterno.NumeroDocumento

                            'domicilio
                            .Parameters.Add(New SqlParameter("@ubg_id_dir", SqlDbType.Int)).Value = objInterno.DomicilioUbigeoID
                            .Parameters.Add(New SqlParameter("@aut_ubg_dep", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioDepartamentoNombre
                            .Parameters.Add(New SqlParameter("@aut_ubg_pro", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioProvinciaNombre
                            .Parameters.Add(New SqlParameter("@aut_ubg_dis", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioDistritoNombre
                            .Parameters.Add(New SqlParameter("@int_dir_nom", SqlDbType.VarChar, 200)).Value = objInterno.Domicilio

                            .Parameters.Add(New SqlParameter("@est_civ_id", SqlDbType.Int)).Value = objInterno.EstadoCivilID
                            .Parameters.Add(New SqlParameter("@niv_aca_id", SqlDbType.Int)).Value = objInterno.NivelAcademicoID
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
                            .Parameters.Add(New SqlParameter("@c_int_dec", SqlDbType.VarChar, (20))).Value = objInterno.Decadactilar
                            .Parameters.Add(New SqlParameter("@b_int_hom", SqlDbType.Bit)).Value = objInterno.Homonimia
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objInterno.DocJudIDAux

                            .Parameters.Add(New SqlParameter("@fk_idm_nat_id", SqlDbType.Int)).Value = objInterno.IdiomaNativoId
                            .Parameters.Add(New SqlParameter("@fk_gnro_id", SqlDbType.Int)).Value = objInterno.GeneroId
                            .Parameters.Add(New SqlParameter("@c_cen_trab", SqlDbType.VarChar, (150))).Value = objInterno.CentroTrabajo
                            .Parameters.Add(New SqlParameter("@fk_rel_id", SqlDbType.Int)).Value = objInterno.ReligionId
                            .Parameters.Add(New SqlParameter("@fk_cod_fza_arm_id", SqlDbType.Int)).Value = objInterno.CodigoFuerzaArmadaId
                            .Parameters.Add(New SqlParameter("@fk_cod_ran_id", SqlDbType.Int)).Value = objInterno.CodigoRangoId
                            .Parameters.Add(New SqlParameter("@c_int_cod_uni", SqlDbType.VarChar, (20))).Value = objInterno.CodigoUnicoInterno
                            .Parameters.Add(New SqlParameter("@c_int_nom_clav", SqlDbType.VarChar, (20))).Value = objInterno.NombreClaveInterno
                            .Parameters.Add(New SqlParameter("@n_cen_men", SqlDbType.Int)).Value = objInterno.CentroReclusionMenorId

                            .Parameters.Add(New SqlParameter("@fk_grp_pbl_id", SqlDbType.Int)).Value = objInterno.IDGrupoPueblo
                            .Parameters.Add(New SqlParameter("@fk_pbl_id", SqlDbType.Int)).Value = objInterno.IDPueblo
                            .Parameters.Add(New SqlParameter("@n_otr_pbl", SqlDbType.VarChar, 100)).Value = objInterno.OtroPueblo
                            .Parameters.Add(New SqlParameter("@fk_grp_lga_mat_id", SqlDbType.Int)).Value = objInterno.IDGrupoLenguaMaterna
                            .Parameters.Add(New SqlParameter("@fk_lga_mat_id", SqlDbType.Int)).Value = objInterno.IDLenguaMaterna
                            .Parameters.Add(New SqlParameter("@fk_idm_id", SqlDbType.Int)).Value = objInterno.IDIdioma

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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Registro.InternoHistorico) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objInterno.InternoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objInterno.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objInterno.IngresoID
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInterno.CodigoRP
                            .Parameters.Add(New SqlParameter("@int_lib", SqlDbType.VarChar, 20)).Value = objInterno.Libro
                            .Parameters.Add(New SqlParameter("@int_fol", SqlDbType.VarChar, 20)).Value = objInterno.Folio
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInterno.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objInterno.SexoID
                            .Parameters.Add(New SqlParameter("@n_cen_men", SqlDbType.SmallInt)).Value = objInterno.CentroReclusionMenorId
                            'nacimiento
                            .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objInterno.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@ubg_pai_id", SqlDbType.Int)).Value = objInterno.NacimientoPaisID
                            .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = objInterno.NacimientoUbigeoID
                            .Parameters.Add(New SqlParameter("@ubg_nac_otro", SqlDbType.VarChar, 100)).Value = objInterno.NacimientoOtros
                            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objInterno.NacionalidadID
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInterno.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objInterno.NumeroDocumento

                            'domicilio
                            .Parameters.Add(New SqlParameter("@ubg_id_dir", SqlDbType.Int)).Value = objInterno.DomicilioUbigeoID
                            .Parameters.Add(New SqlParameter("@aut_ubg_dep", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioDepartamentoNombre
                            .Parameters.Add(New SqlParameter("@aut_ubg_pro", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioProvinciaNombre
                            .Parameters.Add(New SqlParameter("@aut_ubg_dis", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioDistritoNombre
                            .Parameters.Add(New SqlParameter("@int_dir_nom", SqlDbType.VarChar, 200)).Value = objInterno.Domicilio

                            .Parameters.Add(New SqlParameter("@est_civ_id", SqlDbType.Int)).Value = objInterno.EstadoCivilID
                            .Parameters.Add(New SqlParameter("@niv_aca_id", SqlDbType.Int)).Value = objInterno.NivelAcademicoID
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
                            .Parameters.Add(New SqlParameter("@c_int_dec", SqlDbType.VarChar, (20))).Value = objInterno.Decadactilar
                            .Parameters.Add(New SqlParameter("@b_int_hom", SqlDbType.Bit)).Value = objInterno.Homonimia
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objInterno.DocJudIDAux
                            .Parameters.Add(New SqlParameter("@fk_idm_nat_id", SqlDbType.Int)).Value = objInterno.IdiomaNativoId
                            .Parameters.Add(New SqlParameter("@fk_gnro_id", SqlDbType.Int)).Value = objInterno.GeneroId
                            .Parameters.Add(New SqlParameter("@c_cen_trab", SqlDbType.VarChar, (150))).Value = objInterno.CentroTrabajo
                            .Parameters.Add(New SqlParameter("@fk_rel_id", SqlDbType.Int)).Value = objInterno.ReligionId
                            .Parameters.Add(New SqlParameter("@fk_cod_fza_arm_id", SqlDbType.Int)).Value = objInterno.CodigoFuerzaArmadaId
                            .Parameters.Add(New SqlParameter("@fk_cod_ran_id", SqlDbType.Int)).Value = objInterno.CodigoRangoId
                            .Parameters.Add(New SqlParameter("@c_int_cod_uni", SqlDbType.VarChar, (20))).Value = objInterno.CodigoUnicoInterno
                            .Parameters.Add(New SqlParameter("@c_int_nom_clav", SqlDbType.VarChar, (20))).Value = objInterno.NombreClaveInterno

                            'poblacion etnica
                            .Parameters.Add(New SqlParameter("@fk_grp_pbl_id", SqlDbType.Int)).Value = objInterno.IDGrupoPueblo
                            .Parameters.Add(New SqlParameter("@fk_pbl_id", SqlDbType.Int)).Value = objInterno.IDPueblo
                            .Parameters.Add(New SqlParameter("@n_otr_pbl", SqlDbType.VarChar, (100))).Value = objInterno.OtroPueblo
                            .Parameters.Add(New SqlParameter("@fk_grp_lga_mat_id", SqlDbType.Int)).Value = objInterno.IDGrupoLenguaMaterna
                            .Parameters.Add(New SqlParameter("@fk_lga_mat_id", SqlDbType.Int)).Value = objInterno.IDLenguaMaterna
                            .Parameters.Add(New SqlParameter("@fk_idm_id", SqlDbType.Int)).Value = objInterno.IDIdioma
                            '******************
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objInterno.FlagTransferenciaSede
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


        Public Shared Function GrabarV2_LM(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Registro.InternoHistorico) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objInterno.InternoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objInterno.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objInterno.IngresoID
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInterno.CodigoRP
                            .Parameters.Add(New SqlParameter("@int_lib", SqlDbType.VarChar, 20)).Value = objInterno.Libro
                            .Parameters.Add(New SqlParameter("@int_fol", SqlDbType.VarChar, 20)).Value = objInterno.Folio
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInterno.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objInterno.SexoID
                            .Parameters.Add(New SqlParameter("@n_cen_men", SqlDbType.SmallInt)).Value = objInterno.CentroReclusionMenorId
                            'nacimiento
                            .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objInterno.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@ubg_pai_id", SqlDbType.Int)).Value = objInterno.NacimientoPaisID
                            .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = objInterno.NacimientoUbigeoID
                            .Parameters.Add(New SqlParameter("@ubg_nac_otro", SqlDbType.VarChar, 100)).Value = objInterno.NacimientoOtros
                            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objInterno.NacionalidadID
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInterno.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objInterno.NumeroDocumento

                            'domicilio
                            .Parameters.Add(New SqlParameter("@ubg_id_dir", SqlDbType.Int)).Value = objInterno.DomicilioUbigeoID
                            .Parameters.Add(New SqlParameter("@aut_ubg_dep", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioDepartamentoNombre
                            .Parameters.Add(New SqlParameter("@aut_ubg_pro", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioProvinciaNombre
                            .Parameters.Add(New SqlParameter("@aut_ubg_dis", SqlDbType.VarChar, 100)).Value = objInterno.DomicilioDistritoNombre
                            .Parameters.Add(New SqlParameter("@int_dir_nom", SqlDbType.VarChar, 200)).Value = objInterno.Domicilio

                            .Parameters.Add(New SqlParameter("@est_civ_id", SqlDbType.Int)).Value = objInterno.EstadoCivilID
                            .Parameters.Add(New SqlParameter("@niv_aca_id", SqlDbType.Int)).Value = objInterno.NivelAcademicoID
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
                            .Parameters.Add(New SqlParameter("@c_int_dec", SqlDbType.VarChar, (20))).Value = objInterno.Decadactilar
                            .Parameters.Add(New SqlParameter("@b_int_hom", SqlDbType.Bit)).Value = objInterno.Homonimia
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objInterno.DocJudIDAux
                            .Parameters.Add(New SqlParameter("@fk_idm_nat_id", SqlDbType.Int)).Value = objInterno.IdiomaNativoId
                            .Parameters.Add(New SqlParameter("@fk_gnro_id", SqlDbType.Int)).Value = objInterno.GeneroId
                            .Parameters.Add(New SqlParameter("@c_cen_trab", SqlDbType.VarChar, (150))).Value = objInterno.CentroTrabajo
                            .Parameters.Add(New SqlParameter("@fk_rel_id", SqlDbType.Int)).Value = objInterno.ReligionId
                            .Parameters.Add(New SqlParameter("@fk_cod_fza_arm_id", SqlDbType.Int)).Value = objInterno.CodigoFuerzaArmadaId
                            .Parameters.Add(New SqlParameter("@fk_cod_ran_id", SqlDbType.Int)).Value = objInterno.CodigoRangoId
                            .Parameters.Add(New SqlParameter("@c_int_cod_uni", SqlDbType.VarChar, (20))).Value = objInterno.CodigoUnicoInterno
                            .Parameters.Add(New SqlParameter("@c_int_nom_clav", SqlDbType.VarChar, (20))).Value = objInterno.NombreClaveInterno

                            .Parameters.Add(New SqlParameter("@fk_grp_pbl_id", SqlDbType.Int)).Value = objInterno.IDGrupoPueblo
                            .Parameters.Add(New SqlParameter("@fk_pbl_id", SqlDbType.Int)).Value = objInterno.IDPueblo
                            .Parameters.Add(New SqlParameter("@n_otr_pbl", SqlDbType.VarChar, 100)).Value = objInterno.OtroPueblo
                            .Parameters.Add(New SqlParameter("@fk_grp_lga_mat_id", SqlDbType.Int)).Value = objInterno.IDGrupoLenguaMaterna
                            .Parameters.Add(New SqlParameter("@fk_lga_mat_id", SqlDbType.Int)).Value = objInterno.IDLenguaMaterna
                            .Parameters.Add(New SqlParameter("@fk_idm_id", SqlDbType.Int)).Value = objInterno.IDIdioma

                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objInterno.FlagTransferenciaSede
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
#End Region

    End Class
End Namespace
