Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoHistorico
        '        Private objEnt As Entity.Registro.InternoHistorico = Nothing
        Private objEntCol As Entity.Registro.InternoHisCol = Nothing

#Region "Validar"
        Public Function Validar_IngresoID(objEnt As Entity.Registro.InternoHistorico) As Integer

            Dim value As Integer = 0

            value = Data.Registro.InternoHistorico.ListarOutput("lst", "lst_val_ingreso_id", objEnt)

            Return value

        End Function
        Public Function Validar_IngresoInpeID(objEnt As Entity.Registro.InternoHistorico) As Integer

            Dim value As Integer = 0

            value = Data.Registro.InternoHistorico.ListarOutput_LM("lst", "lst_val_ingreso_inpe_id", objEnt)

            Return value

        End Function
        Public Function Validar_DocumentoID(objEnt As Entity.Registro.InternoHistorico) As Integer

            Dim value As Integer = 0

            value = Data.Registro.InternoHistorico.ListarOutput("lst", "lst_val_documento_id", objEnt)

            Return value

        End Function

        Public Function Validar_DocumentoID_LM(objEnt As Entity.Registro.InternoHistorico) As Integer
            Dim value As Integer = 0
            value = Data.Registro.InternoHistorico.ListarOutput_LM("lst", "lst_val_documento_id_LM", objEnt)
            Return value
        End Function

        Public Function Validar_InternoHistoricoID(objEnt As Entity.Registro.InternoHistorico) As Integer

            Dim value As Integer = 0

            value = Data.Registro.InternoHistorico.ListarOutput("lst", "lst_val_interno_historico", objEnt)

            Return value

        End Function
        Public Function Validar_InternoHistoricoID_Anterior(objEnt As Entity.Registro.InternoHistorico) As Integer

            Dim value As Integer = 0

            value = Data.Registro.InternoHistorico.ListarOutput("lst", "lst_val_interno_historico_anterior", objEnt)

            Return value

        End Function
#End Region
#Region "Listar"

        Public Function ActualizarInternoHistorico(InternoId As Integer, IngresoId As Integer, objEntInterno As Entity.Registro.InternoHistorico) As Integer

            'permite varificar si existe registro historico relacionado con cada ingreso
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ape_nom_his2"

            Return Data.Registro.InternoHistorico.Grabar(strAccion, strOpcion, objEntInterno)
        End Function

        Public Function ActualizarInternoHistorico_LM(objEntInterno As Entity.Registro.InternoHistorico) As Integer

            'permite varificar si existe registro historico relacionado con cada ingreso
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ape_nom_his2_LM"

            Return Data.Registro.InternoHistorico.Grabar_LM(strAccion, strOpcion, objEntInterno)
        End Function

        Public Function ActualizarInternoHistoricoxDocumento(InternoId As Integer, IngresoId As Integer, objEntInterno As Entity.Registro.InternoHistorico) As Integer

            'permite varificar si existe registro historico relacionado con cada ingreso
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ape_nom_his3"

            Return Data.Registro.InternoHistorico.Grabar(strAccion, strOpcion, objEntInterno)
        End Function

        Public Function ActualizarInternoHistoricoxDocumento_LM(objEntInterno As Entity.Registro.InternoHistorico) As Integer
            'permite varificar si existe registro historico relacionado con cada ingreso
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ape_nom_his3_LM"

            Return Data.Registro.InternoHistorico.Grabar_LM(strAccion, strOpcion, objEntInterno)
        End Function

        Public Function Listar_LM(objEntHis As Entity.Registro.InternoHistorico) As Entity.Registro.InternoHistorico
            Return Listar_LM(objEntHis, "lst", "lst_mant_lm")
        End Function

        Private Function Listar_LM(objEntHis As Entity.Registro.InternoHistorico, accion As String, opcion As String) As Entity.Registro.InternoHistorico
            Dim objEnt As Entity.Registro.InternoHistorico
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoHistorico.Listar_LM(sqlCon, accion, opcion, objEntHis)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoHistorico
                        With objEnt
                            .Codigo = sqlDr("int_hist_id").ToString
                            .CentroReclusionMenorId = sqlDr("n_cen_men").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .Libro = sqlDr("int_lib").ToString
                            .Folio = sqlDr("int_fol").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .Obs_DNI = sqlDr("int_obs_dni").ToString
                            .EstadoCivilID = sqlDr("est_civ_id").ToString
                            'nacimiento
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .NacimientoPaisID = sqlDr("ubg_pai_id").ToString
                            .NacimientoUbigeoID = sqlDr("ubg_id_nac").ToString
                            .NacimientoOtros = sqlDr("ubg_nac_otro").ToString
                            'domicilio
                            .DomicilioDepartamentoNombre = sqlDr("aut_ubg_dep").ToString
                            .DomicilioProvinciaNombre = sqlDr("aut_ubg_pro").ToString
                            .DomicilioDistritoNombre = sqlDr("aut_ubg_dis").ToString
                            .DomicilioUbigeoID = sqlDr("ubg_id_dir").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            'otros
                            .NivelAcademicoID = sqlDr("niv_aca_id").ToString
                            .ProfesionID = sqlDr("pro_id").ToString
                            .OcupacionID = sqlDr("ocu_id").ToString
                            .Discapacidad = sqlDr("int_dis_id").ToString
                            .ComunidadAndinaID = sqlDr("int_com_id").ToString
                            .ComunidadAndinaEspID = sqlDr("int_com_esp_id").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/                            
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            .Decadactilar = sqlDr("c_int_dec").ToString
                            .Homonimia = sqlDr("b_int_hom").ToString
                            .Obs = sqlDr("int_obs").ToString
                            'Try
                            .IdiomaNativoId = sqlDr("fk_idm_nat_id").ToString
                            .GeneroId = sqlDr("fk_gnro_id").ToString
                            .CentroTrabajo = sqlDr("c_cen_trab").ToString
                            .ReligionId = sqlDr("fk_rel_id").ToString
                            .CodigoFuerzaArmadaId = sqlDr("fk_cod_fza_arm_id").ToString
                            .CodigoRangoId = sqlDr("fk_cod_ran_id").ToString
                            .CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                            .NombreClaveInterno = sqlDr("c_int_nom_clav").ToString

                            .IDGrupoPueblo = sqlDr("fk_grp_pbl_id").ToString
                            .IDPueblo = sqlDr("fk_pbl_id").ToString
                            .OtroPueblo = sqlDr("n_otr_pbl").ToString
                            .IDGrupoLenguaMaterna = sqlDr("fk_grp_lga_mat_id").ToString
                            .IDLenguaMaterna = sqlDr("fk_lga_mat_id").ToString
                            .IDIdioma = sqlDr("fk_idm_id").ToString
                            'Catch ex As Exception
                            'End Try
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function

        Public Function ListarUltimoHistorico_Penal_LM(intId As Integer, penId As Integer) As Entity.Registro.InternoHistorico
            Dim objEntHis As New Entity.Registro.InternoHistorico
            objEntHis.InternoID = intId
            objEntHis.PenalID = penId

            Return Listar_LM(objEntHis, "lst", "lst_val_ultimo_historico_lm")
        End Function

        Public Function ListarUltimoHistorico_region_lm(intId As Integer, idIngInpe As Integer) As Entity.Registro.InternoHistorico
            Dim objEntHis As New Entity.Registro.InternoHistorico
            objEntHis.InternoID = intId
            objEntHis.IngresoInpeId = idIngInpe

            Return Listar_LM(objEntHis, "lst", "lst_val_ultimo_historico_lm")
        End Function

        Public Function Listar(objEntHis As Entity.Registro.InternoHistorico) As Entity.Registro.InternoHistorico
            Dim objEnt As Entity.Registro.InternoHistorico
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoHistorico.Listar(sqlCon, "lst", "lst_mant_v2", objEntHis)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoHistorico
                        With objEnt
                            .Codigo = sqlDr("int_hist_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .Libro = sqlDr("int_lib").ToString
                            .Folio = sqlDr("int_fol").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .Obs_DNI = sqlDr("int_obs_dni").ToString
                            .EstadoCivilID = sqlDr("est_civ_id").ToString
                            'nacimiento
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .NacimientoPaisID = sqlDr("ubg_pai_id").ToString
                            .NacimientoUbigeoID = sqlDr("ubg_id_nac").ToString
                            .NacimientoOtros = sqlDr("ubg_nac_otro").ToString
                            'domicilio
                            .DomicilioDepartamentoNombre = sqlDr("aut_ubg_dep").ToString
                            .DomicilioProvinciaNombre = sqlDr("aut_ubg_pro").ToString
                            .DomicilioDistritoNombre = sqlDr("aut_ubg_dis").ToString
                            .DomicilioUbigeoID = sqlDr("ubg_id_dir").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            'otros
                            .NivelAcademicoID = sqlDr("niv_aca_id").ToString
                            .ProfesionID = sqlDr("pro_id").ToString
                            .OcupacionID = sqlDr("ocu_id").ToString
                            .Discapacidad = sqlDr("int_dis_id").ToString
                            .ComunidadAndinaID = sqlDr("int_com_id").ToString
                            .ComunidadAndinaEspID = sqlDr("int_com_esp_id").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/                            
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            .Decadactilar = sqlDr("c_int_dec").ToString
                            .Homonimia = sqlDr("b_int_hom").ToString
                            .Obs = sqlDr("int_obs").ToString
                            Try
                                .IdiomaNativoId = sqlDr("fk_idm_nat_id").ToString
                                .GeneroId = sqlDr("fk_gnro_id").ToString
                                .CentroTrabajo = sqlDr("c_cen_trab").ToString
                                .ReligionId = sqlDr("fk_rel_id").ToString
                                .CodigoFuerzaArmadaId = sqlDr("fk_cod_fza_arm_id").ToString
                                .CodigoRangoId = sqlDr("fk_cod_ran_id").ToString
                                .CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                                .NombreClaveInterno = sqlDr("c_int_nom_clav").ToString
                                .CentroReclusionMenorId = sqlDr("n_cen_men").ToString

                                .IDGrupoPueblo = sqlDr("fk_grp_pbl_id").ToString
                                .IDPueblo = sqlDr("fk_pbl_id").ToString
                                .OtroPueblo = sqlDr("n_otr_pbl").ToString
                                .IDGrupoLenguaMaterna = sqlDr("fk_grp_lga_mat_id").ToString
                                .IDLenguaMaterna = sqlDr("fk_lga_mat_id").ToString
                                .IDIdioma = sqlDr("fk_idm_id").ToString
                            Catch ex As Exception

                            End Try
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function

        Public Function Listar_Data_Interno(IDInternoID As Integer, IDIngreso As Integer) As Entity.Registro.InternoHistorico

            Dim value As New Entity.Registro.InternoHistorico

            Dim objEnt As New Entity.Registro.InternoHistorico

            Dim objBssInterno As New Bussines.Registro.Interno

            Dim objEntInternoFiltro_Hist As New Entity.Registro.InternoHistorico
            'Dim objEntInternoFiltro As New Entity.Registro.Interno
            Dim objEntInterno As New Entity.Registro.Interno

            objEntInternoFiltro_Hist.InternoID = IDInternoID
            objEntInternoFiltro_Hist.IngresoID = IDIngreso

            Dim intCodigo As Integer = -1

            intCodigo = Validar_InternoHistoricoID_Anterior(objEntInternoFiltro_Hist)

            If intCodigo > 0 Then
                objEntInternoFiltro_Hist.Codigo = intCodigo
                objEntInternoFiltro_Hist.InternoID = -1
                objEntInternoFiltro_Hist.IngresoID = -1
                objEnt = Listar(objEntInternoFiltro_Hist)
                Return objEnt
            Else

                'With objEntInternoFiltro
                '    .Codigo = IDInternoID
                'End With

                objEntInterno = objBssInterno.Listar_v5(IDInternoID)

            End If

            With objEntInterno
                value.Codigo = -1
                value.InternoID = .Codigo
                value.CodigoRP = .CodigoRP
                value.Libro = .Libro
                value.Folio = .Folio
                value.ApellidoPaterno = .ApellidoPaterno
                value.ApellidoMaterno = .ApellidoMaterno
                value.Nombres = .Nombres
                value.SexoID = .SexoID
                value.FechaNacimiento = .FechaNacimiento
                value.NacimientoPaisID = .NacimientoPaisID
                value.NacimientoUbigeoID = .NacimientoUbigeoID
                value.NacimientoOtros = .NacimientoOtros
                value.NacionalidadID = .NacionalidadID
                value.TipoDocumentoID = .TipoDocumentoID
                value.TipoDocumentoNombre = .TipoDocumentoNombre
                value.NumeroDocumento = .NumeroDocumento
                value.Obs_DNI = .Obs_DNI
                value.DomicilioUbigeoID = .DomicilioUbigeoID
                value.Domicilio = .Domicilio
                value.EstadoCivilID = .EstadoCivilID
                value.NivelAcademicoID = .NivelAcademicoID
                value.ProfesionID = .ProfesionID
                value.OcupacionID = .OcupacionID
                value.EstadoID = .EstadoID
                value.Discapacidad = .Discapacidad
                value.ComunidadAndinaID = .ComunidadAndinaID
                value.ComunidadAndinaEspID = .ComunidadAndinaEspID
                '/*region y penal*/
                value.RegionID = .RegionID
                value.RegionNombre = .RegionNombre
                value.PenalID = .PenalID
                value.PenalNombre = .PenalNombre
                '/*otros*/                            
                value.PabellonID = .PabellonID
                value.PabellonNombre = .PabellonNombre
                value.Decadactilar = .Decadactilar
                value.Homonimia = .Homonimia
                value.Obs = .Obs
                Try
                    value.IdiomaNativoId = .IdiomaNativoId
                    value.GeneroId = .GeneroId
                    value.CentroTrabajo = .CentroTrabajo
                    value.ReligionId = .ReligionId
                    value.CodigoFuerzaArmadaId = .CodigoFuerzaArmadaId
                    value.CodigoRangoId = .CodigoRangoId
                    value.CodigoUnicoInterno = .CodigoUnicoInterno
                    value.NombreClaveInterno = .NombreClaveInterno
                    value.CentroReclusionMenorId = .CentroReclusionMenorId
                Catch ex As Exception

                End Try
            End With

            Return value
        End Function


        Private Function Listar_Convert_Historico(objInterno As Entity.Registro.Interno) As Entity.Registro.InternoHistorico

            Dim value As New Entity.Registro.InternoHistorico

            With objInterno
                value.Codigo = -1
                value.InternoID = .Codigo
                value.CodigoRP = .CodigoRP
                value.Libro = .Libro
                value.Folio = .Folio
                value.ApellidoPaterno = .ApellidoPaterno
                value.ApellidoMaterno = .ApellidoMaterno
                value.Nombres = .Nombres
                value.SexoID = .SexoID
                value.FechaNacimiento = .FechaNacimiento
                value.NacimientoPaisID = .NacimientoPaisID
                value.NacimientoUbigeoID = .NacimientoUbigeoID
                value.NacimientoOtros = .NacimientoOtros
                value.NacionalidadID = .NacionalidadID
                value.TipoDocumentoID = .TipoDocumentoID
                value.TipoDocumentoNombre = .TipoDocumentoNombre
                value.NumeroDocumento = .NumeroDocumento
                value.Obs_DNI = .Obs_DNI
                value.DomicilioUbigeoID = .DomicilioUbigeoID
                value.Domicilio = .Domicilio
                value.EstadoCivilID = .EstadoCivilID
                value.NivelAcademicoID = .NivelAcademicoID
                value.ProfesionID = .ProfesionID
                value.OcupacionID = .OcupacionID
                value.EstadoID = .EstadoID
                value.Discapacidad = .Discapacidad
                value.ComunidadAndinaID = .ComunidadAndinaID
                value.ComunidadAndinaEspID = .ComunidadAndinaEspID
                '/*region y penal*/
                value.RegionID = .RegionID
                value.RegionNombre = .RegionNombre
                value.PenalID = .PenalID
                value.PenalNombre = .PenalNombre
                '/*otros*/                            
                value.PabellonID = .PabellonID
                value.PabellonNombre = .PabellonNombre
                value.Homonimia = .Homonimia
                value.Decadactilar = .Decadactilar
                value.Obs = .Obs
                Try
                    value.IdiomaNativoId = .IdiomaNativoId
                    value.GeneroId = .GeneroId
                    value.CentroTrabajo = .CentroTrabajo
                    value.ReligionId = .ReligionId
                    value.CodigoFuerzaArmadaId = .CodigoFuerzaArmadaId
                    value.CodigoRangoId = .CodigoRangoId
                    value.CodigoUnicoInterno = .CodigoUnicoInterno
                    value.NombreClaveInterno = .NombreClaveInterno
                    value.CentroReclusionMenorId = .CentroReclusionMenorId

                    value.IDGrupoPueblo = .PertenenciaEtnicaId
                    value.IDPueblo = .PertenenciaEtnicaDetalleId
                    value.OtroPueblo = .PertenenciaEtnicaOtros
                    value.IDGrupoLenguaMaterna = .LenguaMaternaId
                    value.IDLenguaMaterna = .LenguaMaternaDetalleId
                    value.IDIdioma = .IdiomaId
                Catch ex As Exception

                End Try
            End With

            Return value
        End Function

        Public Function Listar_Convert_Historico_LM(objInterno As Entity.Registro.Interno) As Entity.Registro.InternoHistorico

            Dim value As New Entity.Registro.InternoHistorico

            With objInterno
                value.Codigo = -1
                value.InternoID = .Codigo
                value.CodigoRP = .CodigoRP
                value.Libro = .Libro
                value.Folio = .Folio
                value.CentroReclusionMenorId = .CentroReclusionMenorId
                value.ApellidoPaterno = .ApellidoPaterno
                value.ApellidoMaterno = .ApellidoMaterno
                value.Nombres = .Nombres
                value.SexoID = .SexoID
                value.FechaNacimiento = .FechaNacimiento
                value.NacimientoPaisID = .NacimientoPaisID
                value.NacimientoUbigeoID = .NacimientoUbigeoID
                value.NacimientoOtros = .NacimientoOtros
                value.NacionalidadID = .NacionalidadID
                value.TipoDocumentoID = .TipoDocumentoID
                value.TipoDocumentoNombre = .TipoDocumentoNombre
                value.NumeroDocumento = .NumeroDocumento
                value.Obs_DNI = .Obs_DNI
                value.DomicilioUbigeoID = .DomicilioUbigeoID
                value.Domicilio = .Domicilio
                value.EstadoCivilID = .EstadoCivilID
                value.NivelAcademicoID = .NivelAcademicoID
                value.ProfesionID = .ProfesionID
                value.OcupacionID = .OcupacionID
                value.EstadoID = .EstadoID
                value.Discapacidad = .Discapacidad
                value.ComunidadAndinaID = .ComunidadAndinaID
                value.ComunidadAndinaEspID = .ComunidadAndinaEspID
                '/*region y penal*/
                value.RegionID = .RegionID
                value.RegionNombre = .RegionNombre
                value.PenalID = .PenalID
                value.PenalNombre = .PenalNombre
                '/*otros*/                            
                value.PabellonID = .PabellonID
                value.PabellonNombre = .PabellonNombre
                value.Homonimia = .Homonimia
                value.Decadactilar = .Decadactilar
                value.Obs = .Obs
                value.IdiomaNativoId = .IdiomaNativoId
                value.GeneroId = .GeneroId
                value.DomicilioDireccion = .DomicilioDireccion
                value.CentroTrabajo = .CentroTrabajo
                value.CodigoFuerzaArmadaId = .CodigoFuerzaArmadaId
                value.CodigoRangoId = .CodigoRangoId
                value.ReligionId = .ReligionId
                value.CodigoUnicoInterno = .CodigoUnicoInterno
                value.NombreClaveInterno = .NombreClaveInterno

                value.IDGrupoPueblo = .PertenenciaEtnicaId
                value.IDPueblo = .PertenenciaEtnicaDetalleId
                value.OtroPueblo = .PertenenciaEtnicaOtros
                value.IDGrupoLenguaMaterna = .LenguaMaternaId
                value.IDLenguaMaterna = .LenguaMaternaDetalleId
                value.IDIdioma = .IdiomaId
            End With

            Return value
        End Function

#End Region
#Region "Grabar"

        Public Function Grabar(objEntInterno As Entity.Registro.InternoHistorico) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntInterno.Codigo < 1 Then

                strAccion = "ins"
                strOpcion = "ins_mant"

                objEntInterno.Codigo = Validar_InternoHistoricoID(objEntInterno)

            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            value = Data.Registro.InternoHistorico.Grabar(strAccion, strOpcion, objEntInterno)

            Return value
        End Function
        Public Function GrabarV2(objEntInterno As Entity.Registro.InternoHistorico) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntInterno.Codigo < 1 Then

                strAccion = "ins"
                strOpcion = "ins_mant_v2"

                objEntInterno.Codigo = Validar_InternoHistoricoID(objEntInterno)

            Else
                strAccion = "upd"
                strOpcion = "upd_mant_v2"
            End If

            value = Data.Registro.InternoHistorico.GrabarV2(strAccion, strOpcion, objEntInterno)

            Return value
        End Function

        Public Function Grabar_LM(objEntInterno As Entity.Registro.InternoHistorico) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntInterno.Codigo < 1 Then

                strAccion = "ins"
                strOpcion = "ins_mant_LM"

                objEntInterno.Codigo = Validar_InternoHistoricoID(objEntInterno)

            Else
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            End If

            value = Data.Registro.InternoHistorico.Grabar_LM(strAccion, strOpcion, objEntInterno)

            Return value
        End Function
        Public Function GrabarV2_LM(objEntInterno As Entity.Registro.InternoHistorico) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntInterno.Codigo < 1 Then

                strAccion = "ins"
                strOpcion = "ins_mant_v2_LM"

                objEntInterno.Codigo = Validar_InternoHistoricoID(objEntInterno)

            Else
                strAccion = "upd"
                strOpcion = "upd_mant_v2_LM"
            End If

            value = Data.Registro.InternoHistorico.GrabarV2_LM(strAccion, strOpcion, objEntInterno)

            Return value
        End Function

        Public Function Grabar_Interno(IDInternoHistorico As Integer, IDIngreso As Integer, objEntInterno As Entity.Registro.Interno) As Integer
            Dim objEnt As New Entity.Registro.InternoHistorico
            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""


            strAccion = "upd"
            strOpcion = "upd_mant_v2"

            objEnt = Listar_Convert_Historico(objEntInterno)
            objEnt.Codigo = IDInternoHistorico
            objEnt.InternoID = objEntInterno.Codigo
            objEnt.IngresoID = IDIngreso

            value = Data.Registro.InternoHistorico.GrabarV2(strAccion, strOpcion, objEnt)

            Dim intIDIngreso As Integer = -1
            intIDIngreso = Validar_IngresoID(objEnt)

            If intIDIngreso = IDIngreso Then
                'actualizamos el interno

                Dim objBss As New Registro.Interno
                objBss.Grabar2(objEntInterno)
            End If

            Return value
        End Function

        ''creado 14-12-2016
        Public Function Grabar_Interno_LM(IDInternoHistorico As Integer, intIDIngresoInpe As Integer, IDIngreso As Integer, objEntInterno As Entity.Registro.Interno) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim objEnt As New Entity.Registro.InternoHistorico

            If IDInternoHistorico > 0 Then
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            Else
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            End If

            objEnt = Listar_Convert_Historico_LM(objEntInterno)
            objEnt.Codigo = IDInternoHistorico
            objEnt.InternoID = objEntInterno.Codigo
            objEnt.IngresoID = IDIngreso
            objEnt.IngresoInpeId = intIDIngresoInpe

            value = Data.Registro.InternoHistorico.GrabarV2_LM(strAccion, strOpcion, objEnt)

            Dim intIDIngresoInpeBD As Integer = -1
            intIDIngresoInpeBD = Validar_IngresoInpeID(objEnt)

            If intIDIngresoInpeBD = intIDIngresoInpe Then
                'actualizamos el interno

                Dim objBss As New Registro.Interno
                objBss.Grabar_Carceleta(objEntInterno, "")
            End If

            Return value
        End Function

        Public Function Grabar_Interno_v2_LM(IDInternoHistorico As Integer, intIDIngresoInpe As Integer, IDIngreso As Integer, objEntInterno As Entity.Registro.Interno) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim objEnt As New Entity.Registro.InternoHistorico

            If IDInternoHistorico > 0 Then
                strAccion = "upd"
                strOpcion = "upd_mant_v2_LM"
            Else
                strAccion = "ins"
                strOpcion = "ins_mant_v2_LM"
            End If

            objEnt = Listar_Convert_Historico_LM(objEntInterno)
            objEnt.Codigo = IDInternoHistorico
            objEnt.InternoID = objEntInterno.Codigo
            objEnt.IngresoID = IDIngreso
            objEnt.IngresoInpeId = intIDIngresoInpe

            value = Data.Registro.InternoHistorico.GrabarV2_LM(strAccion, strOpcion, objEnt)

            Dim intIDIngresoInpeBD As Integer = -1
            intIDIngresoInpeBD = Validar_IngresoInpeID(objEnt)

            If intIDIngresoInpeBD = intIDIngresoInpe Then
                'actualizamos el interno

                Dim objBss As New Registro.Interno
                objBss.Grabar_Carceleta(objEntInterno, "")
            End If

            Return value
        End Function

        Public Function Grabar_HistoricoCopia_LM(IDInterno As Long, IDIngresoActual As Long, IdIngresoNew As Long, IdIngresoInpeNew As Integer, _regId As Integer, _penId As Integer) As Long

            Dim value As Long = -1

            Dim objEntFiltro As New Entity.Registro.InternoHistorico

            With objEntFiltro
                .InternoID = IDInterno
                .IngresoID = IDIngresoActual
                .PenalID = _penId
            End With

            Dim objEnt As New Entity.Registro.InternoHistorico
            objEnt = Listar_LM(objEntFiltro)

            If Not objEnt Is Nothing Then 'si existe historico

                objEnt.Codigo = -1
                objEnt.IngresoID = IdIngresoNew
                objEnt.IngresoInpeId = IdIngresoInpeNew

                value = Grabar_LM(objEnt)

            Else

                Dim objEntDatosInterno As New Entity.Registro.Interno
                Dim objBssInterno As New Bussines.Registro.Interno

                objEntDatosInterno = objBssInterno.Listar_LM(IDInterno)
                Dim bss As New Bussines.Registro.InternoDatosComplementarios
                Dim obj As New Entity.Registro.InternoDatosComplementarios
                obj = bss.Listar(-1, IDInterno)
                If obj.Codigo > 0 Then
                    objEntDatosInterno.PertenenciaEtnicaId = obj.IDGrupoPueblo
                    objEntDatosInterno.PertenenciaEtnicaDetalleId = obj.IDPueblo
                    objEntDatosInterno.PertenenciaEtnicaOtros = obj.OtroPueblo
                    objEntDatosInterno.LenguaMaternaId = obj.IDGrupoLenguaMaterna
                    objEntDatosInterno.LenguaMaternaDetalleId = obj.IDLenguaMaterna
                    objEntDatosInterno.IdiomaId = obj.IDIdioma
                End If

                objEnt = New Entity.Registro.InternoHistorico
                objEnt = Listar_Convert_Historico_LM(objEntDatosInterno)

                objEnt.IngresoID = IdIngresoNew
                objEnt.IngresoInpeId = IdIngresoInpeNew
                objEnt.PenalID = _penId
                objEnt.RegionID = _regId
                value = GrabarV2_LM(objEnt)
            End If

            Return value


        End Function

        ''' <summary>
        ''' Version modificada de Grabar_HistoricoCopia(...), con la diferencia que genera el historico a partir del int_Intenro y no de InternoHistorico.
        ''' </summary>
        ''' <param name="IDInterno"></param>
        ''' <param name="IDIngresoActual"></param>
        ''' <param name="IdIngresoNew"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Grabar_HistoricoDeInterno_LM(IDInterno As Long, IdIngresoNew As Long, IdIngresoInpeNew As Integer) As Long

            Dim value As Long = -1

            'Dim objEntFiltro As New Entity.Registro.InternoHistorico

            'With objEntFiltro
            '    .InternoID = IDInterno
            '    .IngresoID = IDIngresoActual
            'End With

            'objEnt = New Entity.Registro.InternoHistorico
            'objEnt = Listar_V2(objEntFiltro)

            'If objEnt.Codigo > 0 Then

            '    objEnt.Codigo = -1
            '    objEnt.IngresoID = IdIngresoNew

            '    value = Grabar_v2(objEnt)

            'Else


            Dim objEntDatosInterno As New Entity.Registro.Interno
            Dim objBssInterno As New Bussines.Registro.Interno




            objEntDatosInterno = objBssInterno.Listar_LM(IDInterno)

            Dim objEnt As New Entity.Registro.InternoHistorico
            objEnt = Listar_Convert_Historico_LM(objEntDatosInterno)

            objEnt.IngresoID = IdIngresoNew
            objEnt.IngresoInpeId = IdIngresoInpeNew

            value = Grabar_LM(objEnt)

            'End If

            Return value


        End Function
#End Region
#Region "Eliminar"
        'Public Function Eliminar_x_IngresoId(ByVal ingresoId As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""
        '    strAccion = "del"
        '    strOpcion = "del_ingreso"
        '    intValue = Data.Registro.Interno.Eliminar_x_ingreso(strAccion, strOpcion, ingresoId, FlagTransferenciaSede)
        '    Return intValue

        'End Function

        Public Function Eliminar(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.Interno.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)
            Return intValue

        End Function


#End Region
    End Class
End Namespace
