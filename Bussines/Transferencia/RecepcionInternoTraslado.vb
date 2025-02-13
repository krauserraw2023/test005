Imports System.Data.SqlClient
Imports System.Linq

Namespace Transferencia
    Public Class RecepcionInternoTraslado
        Private Property CNBDHuellaVisita As String = ""
        Private Property PenalId As Integer = -1
        Private Property RegionId As Integer = -1

        Public Sub New(strCNBDHuellaVisita As String, intIDRegion As Short, intIDPenal As Short)

            Me.CNBDHuellaVisita = strCNBDHuellaVisita
            Me.PenalId = intIDPenal
            Me.RegionId = intIDRegion
        End Sub

        Public Function RecepcionTrasladoIntCarceleta(internoIdSede As Integer, movSedeId As Integer, movRegOrigenId As Integer, movPenOrigenId As Integer, penId As Integer, regId As Integer, ByRef outSMS As String) As Integer
            Dim strLog As String = "RecepcionInternoTraslado/RecepcionTrasladoIntCarceleta"
            Dim n_interno_id As Integer = -1
            Dim n_IngresoInpeId As Integer = -1
            Dim n_IngresoId As Integer = -1
            Dim tblIngresoInpe As DataTable
            Dim rowUltimoIngreso() As DataRow

            Dim dt As DataSet
            Dim ws As New APPWebService.ws_pope_sede_plm_carceleta.Carceleta
            ws.Url = APPWebService.PathURL.ws_sede_plm_carceleta
            Try
                ws._test()
            Catch ex As Exception
                outSMS = "El servicio " & ws.Url & " no se encuentra disponible." & vbCrLf & outSMS
                Return -1
            End Try
            Try
                dt = ws.ListarDetPaqueteEPLimMet(internoIdSede)
            Catch ex As Exception
                Type.LogSIP.getLog.Debug(strLog, "Error en ListarDetPaqueteEPLimMet(), " & ex.ToString)
                Legolas.Configuration.Aplication.MessageBox.MensajeError("El servicio presenta ciertos problemas de comunicación, intentelo mas tarde.")
                Return -1
            End Try

            If dt Is Nothing Then
                'Type.LogSIP.getLog.Debug(strLog, "Error en ListarDetPaqueteEPLimMet() retorna nulo.")
                Legolas.Configuration.Aplication.MessageBox.MensajeError("El servicio presenta ciertos problemas de comunicación, intentelo mas tarde, Objeto dataset devuelto por el servidor NULO.")
                Return -1
            End If

            n_interno_id = DescargarDataEPLM(dt, n_IngresoInpeId, n_IngresoId, outSMS)
            tblIngresoInpe = dt.Tables("int_mov_interno_ingreso_inpe")


            rowUltimoIngreso = tblIngresoInpe.Select("pk_ing_inp_id = " & tblIngresoInpe.Rows(0).Item("id_ult_ing_inp"))

            If n_interno_id = -1 Then
                If outSMS.Length > 2 Then outSMS = "No se pudo descargar los datos. " & vbCrLf & outSMS
                Return -1
            End If

            'confirmar recepcion de interno
            Dim idConfirma As Integer = -1
            'Type.LogSIP.getLog.Debug(strLog, "Confirmando recepcion traslado ...ws.ConfirmarRecepTraslado(...)")
            idConfirma = ws.ConfirmarRecepTraslado(internoIdSede, movSedeId)

            If idConfirma = -1 Then idConfirma = ws.ConfirmarRecepTraslado(internoIdSede, movSedeId) 'segundo intento

            If idConfirma > 0 Then 'crear mov de traslado.
                'Type.LogSIP.getLog.Debug(strLog, "ws.ConfirmarRecepTraslado(...) ejecutado con exito.")
                Dim t As DataTable
                t = dt.Tables("tbl_Util_internomovimiento")

                Dim entMov As New Entity.Registro.InternoMovimiento
                Dim entMovCol As New Entity.Registro.InternoMovimientoCol
                Dim newReg As Boolean = True
                entMov.MovimientoGrupoID = 1 'ingreso
                entMov.IngresoInpeId = n_IngresoInpeId
                entMov.IngresoID = n_IngresoId
                entMov.InternoID = n_interno_id
                entMov.DocumJudicialNum = t.Rows(0).Item("doc_trs_num")
                entMovCol = (New Bussines.Registro.InternoMovimiento).Listar_LM_v2(entMov)
                If entMovCol.Count > 0 Then
                    entMov = entMovCol.InternoMovimiento(0)
                    newReg = False
                Else
                    newReg = True
                End If

                With entMov
                    .MovimientoGrupoID = 1 'ingreso 
                    .MovimientoTipoID = t.Rows(0).Item("mov_tip_id")
                    .MovimientoMotivoID = t.Rows(0).Item("mov_mot_id")
                    .TipoAutoridadJudicialID = t.Rows(0).Item("doc_jud_tip_aut_id")
                    .AutoridadJudicialID = t.Rows(0).Item("doc_jud_aut_id")
                    .SalaJudicialID = t.Rows(0).Item("doc_jud_sal_id")
                    .DocumJudicialNum = t.Rows(0).Item("doc_trs_num")
                    .DocumJudicialFecha = t.Rows(0).Item("fec_doc") 'fecha del documento
                    .DocumJudicialFecharecepcion = Now.ToFileTime 'fecha de recepcion del documento
                    .DocJudJuez = t.Rows(0).Item("doc_jud_jue")
                    .DocJudSecretario = t.Rows(0).Item("doc_jud_sec")
                    .InternoID = n_interno_id
                    .IngresoInpeId = n_IngresoInpeId
                    .IngresoID = n_IngresoId
                    .EstadoID = 1 'pendiente
                    ._PenalID = penId
                    ._RegionID = regId
                    .RegionOrigenID = movRegOrigenId
                    .PenalOrigenID = movPenOrigenId
                    .PenalDestinoID = penId
                    .RegionDestinoID = regId
                    .Fecha = Now.ToFileTime
                End With

                Dim cmd As New SqlCommand
                Dim strSQL As String = ""

                If newReg = True Then
                    strSQL = "INSERT INTO INT_InternoMovimiento (
	                            int_id,
	                            int_ing_id,
	                            fk_ing_inp_id,
	                            doc_jud_id,
	                            mov_grp_id,
	                            mov_tip_id,
	                            mov_mot_id,
	                            mov_sub_mot_id,
	                            doc_jud_num,
	                            doc_jud_fec_rec,
	                            doc_jud_fec,
	                            doc_jud_tip_aut_id,
	                            doc_jud_aut_id,
	                            doc_jud_sal_id,
	                            doc_jud_jue,
	                            doc_jud_sec,
	                            mov_fec,
	                            mov_reg_org_id,
	                            mov_pen_org,
	                            mov_reg_des_id,
	                            mov_pen_des,
	                            mov_org_otr,
	                            mov_des_otr,
	                            mov_est_id,
	                            mov_per_val,
	                            mov_per_tip,
	                            mov_fec_ret,
	                            mov_fec_fall,
	                            mov_obs,
	                            mov_est_des_id,
	                            _usu_cre,
	                            _fec_cre,
	                            _usu_mod,
	                            _fec_mod,
	                            _usu_eli,
	                            _fec_eli,
	                            _flg_eli,
	                            _arc_nom,
	                            _regid,
	                            _penid,
	                            _flg_trf,
	                            _fec_proc_trf
                            )values(
	                            @int_id,
	                            @int_ing_id,
	                            @fk_ing_inp_id,
	                            @doc_jud_id,
	                            @mov_grp_id,
	                            @mov_tip_id,
	                            @mov_mot_id,
	                            @mov_sub_mot_id,
	                            @doc_jud_num,
	                            @doc_jud_fec_rec,
	                            @doc_jud_fec,
	                            @doc_jud_tip_aut_id,
	                            @doc_jud_aut_id,
	                            @doc_jud_sal_id,
	                            @doc_jud_jue,
	                            @doc_jud_sec,
	                            @mov_fec,
	                            @mov_reg_org_id,
	                            @mov_pen_org,
	                            @mov_reg_des_id,
	                            @mov_pen_des,
	                            @mov_org_otr,
	                            @mov_des_otr,
	                            @mov_est_id,
	                            @mov_per_val,
	                            @mov_per_tip,
	                            @mov_fec_ret,
	                            @mov_fec_fall,
	                            @mov_obs,
	                            @mov_est_des_id,
	                            @_usu_cre,
	                            @_fec_cre,
	                            @_usu_mod,
	                            @_fec_mod,
	                            @_usu_eli,
	                            @_fec_eli,
	                            @_flg_eli,
	                            @_arc_nom,
	                            @_regid,
	                            @_penid,
	                            @_flg_trf,
	                            @_fec_proc_trf
                            ); select scope_identity()"
                Else
                    cmd.Parameters.Add(New SqlParameter("@mov_id", entMov.Codigo))
                    strSQL = "update INT_InternoMovimiento set
	                            mov_id = @mov_id,
	                            int_id = @int_id,
	                            int_ing_id = @int_ing_id,
	                            fk_ing_inp_id = @fk_ing_inp_id,
	                            doc_jud_id = @doc_jud_id,
	                            mov_grp_id = @mov_grp_id,
	                            mov_tip_id = @mov_tip_id,
	                            mov_mot_id = @mov_mot_id,
	                            mov_sub_mot_id = @mov_sub_mot_id,
	                            doc_jud_num = @doc_jud_num,
	                            doc_jud_fec_rec = @doc_jud_fec_rec,
	                            doc_jud_fec = @doc_jud_fec,
	                            doc_jud_tip_aut_id = @doc_jud_tip_aut_id,
	                            doc_jud_aut_id = @doc_jud_aut_id,
	                            doc_jud_sal_id = @doc_jud_sal_id,
	                            doc_jud_jue = @doc_jud_jue,
	                            doc_jud_sec = @doc_jud_sec,
	                            mov_fec = @mov_fec,
	                            mov_reg_org_id = @mov_reg_org_id,
	                            mov_pen_org = @mov_pen_org,
	                            mov_reg_des_id = @mov_reg_des_id,
	                            mov_pen_des = @mov_pen_des,
	                            mov_org_otr = @mov_org_otr,
	                            mov_des_otr = @mov_des_otr,
	                            mov_est_id = @mov_est_id,
	                            mov_per_val = @mov_per_val,
	                            mov_per_tip = @mov_per_tip,
	                            mov_fec_ret = @mov_fec_ret,
	                            mov_fec_fall = @mov_fec_fall,
	                            mov_obs = @mov_obs,
	                            mov_est_des_id = @mov_est_des_id,
	                            _usu_cre = @_usu_cre,
	                            _fec_cre = @_fec_cre,
	                            _usu_mod = @_usu_mod,
	                            _fec_mod = @_fec_mod,
	                            _usu_eli = @_usu_eli,
	                            _fec_eli = @_fec_eli,
	                            _flg_eli = @_flg_eli,
	                            _arc_nom = @_arc_nom,
	                            _regid = @_regid,
	                            _penid = @_penid,
	                            _flg_trf = @_flg_trf,
	                            _fec_proc_trf = @_fec_proc_trf
                            where 
	                            mov_id = @mov_id; select " & entMov.Codigo
                End If

                cmd.Parameters.Add(New SqlParameter("@int_id", n_interno_id))
                cmd.Parameters.Add(New SqlParameter("@int_ing_id", n_IngresoId))
                cmd.Parameters.Add(New SqlParameter("@fk_ing_inp_id", n_IngresoInpeId))
                cmd.Parameters.Add(New SqlParameter("@doc_jud_id", -1))
                cmd.Parameters.Add(New SqlParameter("@mov_grp_id", 1))
                cmd.Parameters.Add(New SqlParameter("@mov_tip_id", entMov.MovimientoTipoID))
                cmd.Parameters.Add(New SqlParameter("@mov_mot_id", entMov.MovimientoMotivoID))
                cmd.Parameters.Add(New SqlParameter("@mov_sub_mot_id", -1))
                cmd.Parameters.Add(New SqlParameter("@doc_jud_num", entMov.DocumJudicialNum))
                cmd.Parameters.Add(New SqlParameter("@doc_jud_fec_rec", entMov.DocumJudicialFecharecepcion))
                cmd.Parameters.Add(New SqlParameter("@doc_jud_fec", entMov.DocumJudicialFecha))
                cmd.Parameters.Add(New SqlParameter("@doc_jud_tip_aut_id", entMov.TipoAutoridadJudicialID))
                cmd.Parameters.Add(New SqlParameter("@doc_jud_aut_id", entMov.AutoridadJudicialID))
                cmd.Parameters.Add(New SqlParameter("@doc_jud_sal_id", entMov.SalaJudicialID))
                cmd.Parameters.Add(New SqlParameter("@doc_jud_jue", entMov.DocJudJuez))
                cmd.Parameters.Add(New SqlParameter("@doc_jud_sec", entMov.DocJudSecretario))
                cmd.Parameters.Add(New SqlParameter("@mov_fec", Now.ToFileTime))
                cmd.Parameters.Add(New SqlParameter("@mov_reg_org_id", entMov.RegionOrigenID))
                cmd.Parameters.Add(New SqlParameter("@mov_pen_org", entMov.PenalOrigenID))
                cmd.Parameters.Add(New SqlParameter("@mov_reg_des_id", entMov.RegionDestinoID))
                cmd.Parameters.Add(New SqlParameter("@mov_pen_des", entMov.PenalDestinoID))
                cmd.Parameters.Add(New SqlParameter("@mov_org_otr", ""))
                cmd.Parameters.Add(New SqlParameter("@mov_des_otr", ""))
                cmd.Parameters.Add(New SqlParameter("@mov_est_id", 1))
                cmd.Parameters.Add(New SqlParameter("@mov_per_val", 0))
                cmd.Parameters.Add(New SqlParameter("@mov_per_tip", ""))
                cmd.Parameters.Add(New SqlParameter("@mov_fec_ret", 0))
                cmd.Parameters.Add(New SqlParameter("@mov_fec_fall", 0))
                cmd.Parameters.Add(New SqlParameter("@mov_obs", ""))
                cmd.Parameters.Add(New SqlParameter("@mov_est_des_id", -1))
                cmd.Parameters.Add(New SqlParameter("@_usu_cre", rowUltimoIngreso(0).Item("_usu_cre")))
                cmd.Parameters.Add(New SqlParameter("@_fec_cre", rowUltimoIngreso(0).Item("_fec_cre")))
                cmd.Parameters.Add(New SqlParameter("@_usu_mod", rowUltimoIngreso(0).Item("_usu_cre")))
                cmd.Parameters.Add(New SqlParameter("@_fec_mod", rowUltimoIngreso(0).Item("_fec_cre")))
                cmd.Parameters.Add(New SqlParameter("@_usu_eli", -1))
                cmd.Parameters.Add(New SqlParameter("@_fec_eli", 0))
                cmd.Parameters.Add(New SqlParameter("@_flg_eli", 0))
                cmd.Parameters.Add(New SqlParameter("@_arc_nom", ""))
                cmd.Parameters.Add(New SqlParameter("@_regid", regId))
                cmd.Parameters.Add(New SqlParameter("@_penid", penId))
                cmd.Parameters.Add(New SqlParameter("@_flg_trf", 1))
                cmd.Parameters.Add(New SqlParameter("@_fec_proc_trf", 0))

                Dim id As Integer = -1

                id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD_v2(strSQL, cmd, 0, outSMS)

                'Type.LogSIP.getLog.Debug(strLog, "Grabar_LM(...) de movimiento, Id=" & id)

            End If

            Return n_interno_id
        End Function

        Public Function RecepcionTrasladoIntSedeCentral_a_Provincia(InternoLocalId As Integer, internoIdSede As Integer, movSedeId As Integer, movRegOrigenId As Integer, movPenOrigenId As Integer, penId As Integer, regId As Integer, ByRef outSMS As String) As Integer
            Dim strLog As String = "RecepcionInternoTraslado/RecepcionTrasladoIntCarceleta"
            Dim n_interno_id As Integer = -1

            Dim dt As DataSet
            Dim ws As New APPWebService.ws_pope_sede_plm_carceleta.Carceleta
            ws.Url = APPWebService.PathURL.ws_sede_plm_carceleta
            Try
                ws._test()
            Catch ex As Exception
                outSMS = "El servicio " & ws.Url & " no se encuentra disponible." & vbCrLf & outSMS
                Return -1
            End Try
            Try
                dt = ws.ListarDetPaqueteEPLimMet(internoIdSede)
            Catch ex As Exception
                Type.LogSIP.getLog.Debug(strLog, "Error en ListarDetPaqueteEPLimMet(), " & ex.ToString)
                Legolas.Configuration.Aplication.MessageBox.MensajeError("El servicio presenta ciertos problemas de comunicación, intentelo mas tarde.")
                Return -1
            End Try

            If dt Is Nothing Then
                'Type.LogSIP.getLog.Debug(strLog, "Error en ListarDetPaqueteEPLimMet() retorna nulo.")
                Legolas.Configuration.Aplication.MessageBox.MensajeError("El servicio presenta ciertos problemas de comunicación, intentelo mas tarde, Objeto dataset devuelto por el servidor NULO.")
                Return -1
            End If
            Dim dts As DataTable = dt.Tables("mov_template_huella")

            If Not dts Is Nothing Then


                n_interno_id = DescargarDataSEDE_a_Provincia(InternoLocalId, dt, penId, regId, outSMS)

            End If

            Return n_interno_id
        End Function

        ''' <summary>
        ''' Operacion encargada de la recepcion de internos por traslado en carceleta provenientes de otros penales
        ''' de lima metropolitana.
        ''' </summary>
        ''' <param name="InternoId"></param>
        ''' <param name="regOrigenId"></param>
        ''' <param name="penOrigenId"></param>
        ''' <param name="MovimientoTrasladoId"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function RecepcionIntTrasladoOrigenEPLM(InternoId As Integer, regOrigenId As Integer, penOrigenId As Integer, MovimientoTrasladoId As Integer)
            Return Data.Transferencia.RecepcionInternoTraslado.carceletaRecepcionTrasladoInterno("upd", "rcp_trs_int_carceleta", InternoId, regOrigenId, penOrigenId, MovimientoTrasladoId)
        End Function

        ''' <summary>
        ''' Retorna datos basicos del interno desde la sede central x id del interno de la sede
        ''' </summary>
        ''' <param name="regOrigenId"></param>
        ''' <param name="penIdOrigen"></param>
        ''' <param name="intIDinternoSede"></param>
        ''' <param name="strMensajeOut"></param>
        ''' <returns></returns>
        Public Function Grabar_DatosBasicosInternoSede_PLM(intIDinternoSede As Integer, ByRef strMensajeOut As String) As Integer

            Dim n_interno_id As Integer = -1
            Dim n_IngresoInpeId As Integer = -1
            Dim n_IngresoId As Integer = -1

            Dim dt As DataSet
            Dim ws As New APPWebService.ws_pope_sede_plm_carceleta.Carceleta
            ws.Url = APPWebService.PathURL.ws_sede_plm_carceleta

            dt = ws.ListarDatBasicoInterno(intIDinternoSede)
            If dt Is Nothing OrElse dt.Tables.Count = 0 Then
                strMensajeOut = "El servicio presenta ciertos problemas de comunicación, intentelo mas tarde."
                Return -1
            End If
            '---------------------------------------------------------------------------

            n_interno_id = GrabarInternoDatoBasico_PLM(dt.Tables("int_interno"))

            Return n_interno_id
        End Function
        Public Function RecepcionTrasladoOrigenEPProv(internoIdSede As Integer, ByRef outSMS As String) As Integer
            'Dim objEntFiltro As New APPWebService.ws_pope_sede_plm_Interno.DTO_Interno
            'objEntFiltro.Codigo = internoIdSede
            'objEntFiltro.IngresoID = -1
            'objEntFiltro.IngresoInpeId = -1

            '----------------------------- conexion a la sede por ws -------------------
            Dim n_interno_id As Integer = -1
            Dim n_IngresoInpeId As Integer = -1
            Dim n_IngresoId As Integer = -1

            Dim dt As DataSet
            Dim ws As New APPWebService.ws_pope_sede_plm_carceleta.Carceleta
            ws.Url = APPWebService.PathURL.ws_sede_plm_carceleta

            dt = ws.ListarDetPaqIntEPProv(internoIdSede)
            If dt Is Nothing OrElse dt.Tables.Count = 0 Then
                outSMS = "El servicio presenta ciertos problemas de comunicación, intentelo mas tarde."
                Return -1
            End If
            '---------------------------------------------------------------------------

            n_interno_id = GrabarInterno(dt.Tables("int_interno"))

            Dim ingInpId As Integer = -1 'registrar internoIngreso, IngresoInpe, movimiento x traslado
            'ingInpId = GenerarIngresoXTraslado(regOrigenId, penIdOrigen, n_interno_id, True, outSMS)

            'GrabarFamiliar(n_interno_id, ingInpId, dt.Tables("INT_InternoFamiliar"))
            'GrabarAlias(n_interno_id, ingInpId, dt.Tables("INT_InternoAlias"))
            'GrabarRasgo(n_interno_id, ingInpId, dt.Tables("INT_InternoRasgo"))
            'GrabarDomicilio(n_interno_id, ingInpId, dt.Tables("int_mov_interno_domicilio"))
            'GrabarIdioma(n_interno_id, ingInpId, dt.Tables("int_mov_interno_idioma"))
            'GrabarGradoInstruccion(n_interno_id, ingInpId, dt.Tables("int_mov_interno_grado_ins"))
            'GrabarSeniaParticular(n_interno_id, ingInpId, dt.Tables("INT_InternoSenaParticular"))
            'GrabarNomAsociado(n_interno_id, ingInpId, dt.Tables("INT_InternoNombreAsociado"))
            'GrabarBanda(n_interno_id, ingInpId, dt.Tables("reg_mov_internobanda"))
            'GrabarOdontograma(n_interno_id, ingInpId, dt.Tables("int_mov_interno_odontograma"), dt.Tables("glo_mov_arch_digitalizado"))

            Return n_interno_id
        End Function
#Region "insert_datos_origen_carceleta"
        Private Function GrabarInterno(t As DataTable) As Integer
            Dim bss As New Bussines.Registro.Interno

            Dim obEntInternoOrigen As New Entity.Registro.Interno
            With obEntInternoOrigen
                .CodigoRP = t.Rows(0).Item("int_cod_rp")
                .CodigoUnicoInterno = t.Rows(0).Item("c_int_cod_uni")
                .CodigoUnicoInternoId = t.Rows(0).Item("fk_int_cod_uni_id")
                .NombreClaveInterno = t.Rows(0).Item("c_int_nom_clav")
                .Folio = t.Rows(0).Item("int_fol")
                .Libro = t.Rows(0).Item("int_lib")
                .ApellidoPaterno = t.Rows(0).Item("int_ape_pat")
                .ApellidoMaterno = t.Rows(0).Item("int_ape_mat")
                .Nombres = t.Rows(0).Item("int_nom")
                .SexoID = t.Rows(0).Item("sex_id")
                .FechaNacimiento = t.Rows(0).Item("int_fec_nac")
                .NacionalidadID = t.Rows(0).Item("nac_id")
                .NacimientoPaisID = t.Rows(0).Item("ubg_pai_id")
                .NacimientoUbigeoID = t.Rows(0).Item("ubg_id_nac")
                .NacimientoOtros = t.Rows(0).Item("ubg_nac_otro")
                .TipoDocumentoID = t.Rows(0).Item("tip_doc_id")
                .NumeroDocumento = t.Rows(0).Item("int_doc_num")
                .DomicilioUbigeoID = t.Rows(0).Item("ubg_id_dir")
                .Domicilio = t.Rows(0).Item("int_dir_nom")
                .Obs_DNI = t.Rows(0).Item("int_obs_dni")
                .EstadoCivilID = t.Rows(0).Item("est_civ_id")
                .NivelAcademicoID = t.Rows(0).Item("niv_aca_id")
                .ProfesionID = t.Rows(0).Item("pro_id")
                .OcupacionID = t.Rows(0).Item("ocu_id")
                .Discapacidad = t.Rows(0).Item("int_dis_id")
                .ComunidadAndinaID = t.Rows(0).Item("int_com_id")
                .ComunidadAndinaEspID = t.Rows(0).Item("int_com_esp_id")
                .Obs = t.Rows(0).Item("int_obs")
                .Decadactilar = t.Rows(0).Item("c_int_dec")
                .Homonimia = t.Rows(0).Item("b_int_hom")
                .GeneroId = t.Rows(0).Item("fk_gnro_id")
                .ReligionId = t.Rows(0).Item("fk_rel_id")
                .CentroTrabajo = t.Rows(0).Item("c_cen_trab")
                .CodigoFuerzaArmadaId = t.Rows(0).Item("fk_cod_fza_arm_id")
                .CodigoRangoId = t.Rows(0).Item("fk_cod_ran_id")
                .IdiomaNativoId = t.Rows(0).Item("fk_idm_nat_id")
                .FechaISP = t.Rows(0).Item("int_fec_isp")
                .VersionRegistro = t.Rows(0).Item("c_ver_reg")
                .EstadoID = 1
                .RegionID = Me.RegionId
                .PenalID = Me.PenalId
                .EstadoEspecificoID = 1 'recluido
                .EstadoRncID = -1
                .VersionRegistro = "V6_LM"
            End With

            Dim idInterno As Integer = -1
            Dim outSMS As String = ""
            idInterno = (New Bussines.Registro.Interno).Grabar_PLM(obEntInternoOrigen, outSMS)
            If idInterno <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(outSMS)
                Return -1
            End If


            Return idInterno
        End Function
        Private Function GrabarInternoDatoBasico_PLM(t As DataTable) As Integer
            Dim bss As New Bussines.Registro.Interno

            Dim obEntInternoOrigen As New Entity.Registro.Interno
            With obEntInternoOrigen
                .CodigoRP = t.Rows(0).Item("int_cod_rp")
                .ApellidoPaterno = t.Rows(0).Item("int_ape_pat")
                .ApellidoMaterno = t.Rows(0).Item("int_ape_mat")
                .Nombres = t.Rows(0).Item("int_nom")
                .SexoID = t.Rows(0).Item("sex_id")
                .FechaNacimiento = t.Rows(0).Item("int_fec_nac")
                .NacionalidadID = t.Rows(0).Item("nac_id")
                .NacimientoPaisID = t.Rows(0).Item("ubg_pai_id")
                .NacimientoUbigeoID = t.Rows(0).Item("ubg_id_nac")
                .TipoDocumentoID = t.Rows(0).Item("tip_doc_id")
                .NumeroDocumento = t.Rows(0).Item("int_doc_num")
                .DomicilioUbigeoID = t.Rows(0).Item("ubg_id_dir")
                .EstadoID = t.Rows(0).Item("int_est_id")

                .RegionID = Me.RegionId
                .PenalID = Me.PenalId
                .SedeRowId = t.Rows(0).Item("_sed_rowid")

                'If blnInternodeEsPLM = True Then
                '    '.VersionRegistro = t.Rows(0).Item("c_ver_reg")
                '    .SedeRowId = t.Rows(0).Item("_sed_rowid")
                'Else
                '    '.VersionRegistro = ""
                '    .SedeRowId = -1
                'End If

            End With

            Dim idInterno As Integer = -1
            Dim outSMS As String = ""
            idInterno = (New Bussines.Registro.Interno).Grabar_DatoBasic_PLM(obEntInternoOrigen) 'grabar como V5_LP para posterior sincronizacion
            If idInterno <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(outSMS)
                Return -1
            End If

            Return idInterno
        End Function
        Private Function GrabarInternoDatoBasico_Sede_Provincia(t As DataTable, PenalId As Integer, RegionId As Integer) As Integer
            Dim bss As New Bussines.Registro.Interno

            Dim obEntInternoOrigen As New Entity.Registro.Interno
            With obEntInternoOrigen
                .CodigoRP = t.Rows(0).Item("int_cod_rp")
                .ApellidoPaterno = t.Rows(0).Item("int_ape_pat")
                .ApellidoMaterno = t.Rows(0).Item("int_ape_mat")
                .Nombres = t.Rows(0).Item("int_nom")
                .SexoID = t.Rows(0).Item("sex_id")
                .FechaNacimiento = t.Rows(0).Item("int_fec_nac")
                .NacionalidadID = t.Rows(0).Item("nac_id")
                .NacimientoPaisID = t.Rows(0).Item("ubg_pai_id")
                .NacimientoUbigeoID = t.Rows(0).Item("ubg_id_nac")
                .TipoDocumentoID = t.Rows(0).Item("tip_doc_id")
                .NumeroDocumento = t.Rows(0).Item("int_doc_num")
                .DomicilioUbigeoID = t.Rows(0).Item("ubg_id_dir")
                .EstadoID = 0
                .RegionID = RegionId
                .PenalID = PenalId
                .VersionRegistro = ""
            End With

            Dim idInterno As Integer = -1
            Dim outSMS As String = ""
            idInterno = (New Bussines.Registro.Interno).Grabar2(obEntInternoOrigen) 'grabar como V5_LP para posterior sincronizacion
            If idInterno <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(outSMS)
                Return -1
            End If

            Return idInterno
        End Function
#End Region

#Region "insert_datos_origen_carceleta"
        Private Function DescargarDataEPLM(ds As DataSet, ByRef outIngInpeIdNew As Integer, ByRef outIngId As Integer, ByRef outSMS As String) As Integer
            Dim strLog As String = "RecepcionInternoTraslado/DescargarDataEPLM"
            Dim n_intId As Integer = -1
            Dim n_InpeIngId As Integer = -1
            Dim n_ingId As Integer = -1
            Dim id As Integer = -1
            'Type.LogSIP.getLog.Debug(strLog, "Dentro de DescargarDataEPLM(...)")
            n_intId = GrabarInterno(ds.Tables("int_interno"), outSMS)
            If n_intId = -1 Then Return -1

            n_InpeIngId = GrabarIngresoInpe(ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, outSMS)
            If n_InpeIngId = -1 Then Return -1

            n_ingId = GrabarInternoIngreso(ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, n_InpeIngId, outSMS)
            If n_ingId = -1 Then Return -1

            '----- grabar datos complementarios
            If ProcesaTablaOtros(ds.Tables("INT_InternoAlias"), ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, n_InpeIngId, n_ingId, outSMS) < 0 Then Return -1
            If ProcesaTablaOtros(ds.Tables("INT_InternoRasgo"), ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, n_InpeIngId, n_ingId, outSMS) < 0 Then Return -1
            If ProcesaTablaOtros(ds.Tables("int_mov_interno_domicilio"), ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, n_InpeIngId, n_ingId, outSMS) < 0 Then Return -1
            If ProcesaTablaOtros(ds.Tables("int_mov_interno_idioma"), ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, n_InpeIngId, n_ingId, outSMS) < 0 Then Return -1
            If ProcesaTablaOtros(ds.Tables("int_mov_interno_grado_ins"), ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, n_InpeIngId, n_ingId, outSMS) < 0 Then Return -1
            If ProcesaTablaOtros(ds.Tables("INT_InternoSenaParticular"), ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, n_InpeIngId, n_ingId, outSMS) < 0 Then Return -1
            If ProcesaTablaOtros(ds.Tables("INT_InternoFamiliar"), ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, n_InpeIngId, n_ingId, outSMS) < 0 Then Return -1

            If GrabarOdontograma(ds.Tables("int_mov_interno_odontograma"), ds.Tables("glo_mov_arch_digitalizado_odontograma"), n_intId, n_InpeIngId, n_ingId, outSMS) = -1 Then Return -1
            If ProcesaTablaOtros(ds.Tables("reg_mov_internobanda"), ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, n_InpeIngId, n_ingId, outSMS) < 0 Then Return -1
            If ProcesaTablaOtros(ds.Tables("INT_InternoNombreAsociado"), ds.Tables("int_mov_interno_ingreso_inpe"), n_intId, n_InpeIngId, n_ingId, outSMS) < 0 Then Return -1
            If GrabarOrgCriminal(ds.Tables("REG_DOC_Judicial_Siscrico"), ds.Tables("INT_InternoBanda"), n_intId, ds.Tables("int_mov_interno_ingreso_inpe"), n_ingId, n_InpeIngId, outSMS) = -1 Then Return -1

            'id = GrabarDocumentoDigitalizado(ds.Tables("int_mov_doc_digital"), ds.Tables("glo_mov_arch_digitalizado_doc_digital"), n_intId, n_InpeIngId, n_ingId, outSMS)
            'If id = -1 Then
            '    id = (New Bussines.Registro.Ingreso).Eliminar_v2_LM(entTmp)
            '    Return -1
            'End If

            'id = GrabarMandatoDet(ds.Tables("MandatoDetencion"), ds.Tables("INT_InternoExpediente"), ds.Tables("INT_InternoExpedientePadre"), ds.Tables("INT_InternoDelito"), ds.Tables("INT_InternoAgraviado"), n_intId, n_InpeIngId, n_ingId, outSMS)
            'If id = -1 Then Return -1

            If GrabarGloArchivoDigital_InternoFoto(ds.Tables("GLO_ArchivoDigital_Interno"), ds.Tables("INT_InternoFoto"), n_intId, n_InpeIngId, n_ingId, outSMS) = -1 Then Return -1
            If GrabarValidacionInternoReniec(ds.Tables("GLO_ArchivoDigital_Reniec"), ds.Tables("INT_InternoRENIEC"), ds.Tables("GLO_ArchivoDigital_Interno"), n_intId, n_InpeIngId, n_ingId, outSMS) = -1 Then Return -1
            If GrabarReniecNomAsoc(ds.Tables("INT_InternoRENIEC"), ds.Tables("INT_InternoReniec_NomAsoc"), ds.Tables("INT_InternoNombreAsociado"), n_intId, n_InpeIngId, n_ingId, outSMS) = -1 Then Return -1
            If GrabarTemplateHuella(ds.Tables("mov_template_huella"), n_intId, outSMS) = -1 Then Return -1
            If GrabarWSQHuella(ds.Tables("mov_huella_wsq"), ds.Tables("mov_template_huella"), outSMS) = -1 Then Return -1
            If GrabarInternoHuella(ds.Tables("mov_interno_huella"), ds.Tables("mov_template_huella"), n_intId, outSMS) = -1 Then Return -1

            ' Asegúrate de que el DataTable contenga datos
            If ds.Tables("Table24").Rows.Count > 0 And ds.Tables("Table25").Rows.Count > 0 Then
                ' Obtener la primera fila (ya que es un solo registro)
                'TABLAS DE XML DE ODONTOGRAMAS NUEVO
                Dim fila As DataRow = ds.Tables("Table24").Rows(0)
                Dim fila_det As DataRow = ds.Tables("Table25").Rows(0)

                ' Obtener el valor del campo int_mov_interno_odontograma_nts_det
                Dim XMLint_mov_interno_odontograma_nts_det As String = fila_det("int_mov_interno_odontograma_nts_det").ToString()
                Dim XMLint_mov_interno_odontograma_nts As String = fila("int_mov_interno_odontograma_nts").ToString()

                If GrabarOdontogramaNuevo(XMLint_mov_interno_odontograma_nts, XMLint_mov_interno_odontograma_nts_det, n_intId, n_InpeIngId, n_ingId) = -1 Then Return -1
            End If

            outIngId = n_ingId
            outIngInpeIdNew = n_InpeIngId
            Return n_intId
        End Function

        Private Function DescargarDataSEDE_a_Provincia(n_intId As Integer, ds As DataSet, PenalId As Integer, RegionId As Integer, ByRef outSMS As String) As Integer
            Dim strLog As String = "RecepcionInternoTraslado/DescargarDataEPLM"
            Dim id As Integer = -1
            n_intId = GrabarInternoDatoBasico_Sede_Provincia(ds.Tables("int_interno"), PenalId, RegionId)
            If n_intId = -1 Then Return -1
            '----- grabar datos complementarios
            If GrabarTemplateHuellaProv(ds.Tables("mov_template_huella"), n_intId, PenalId, RegionId, outSMS) = -1 Then Return -1
            If GrabarWSQHuellaProv(ds.Tables("mov_huella_wsq"), ds.Tables("mov_template_huella"), n_intId, PenalId, RegionId, outSMS) = -1 Then Return -1
            If GrabarInternoHuellaProv(ds.Tables("mov_interno_huella"), ds.Tables("mov_template_huella"), n_intId, PenalId, RegionId, outSMS) = -1 Then Return -1

            Return n_intId
        End Function

        Private Function GrabarValidacionInternoReniec(ByRef tblGloArchivoDigital_Reniec As DataTable, ByRef tblInternoReniec As DataTable, ByRef tblGloArchDigital_IntFoto As DataTable, n_int_id As Integer, n_inpe_ing_id As Integer, n_ingId As Integer, ByRef outSms As String) As Integer
            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim c_nomColPK As String = ""
            Dim tblTablaBD As DataTable = Nothing
            Dim newRow As Dictionary(Of String, Object) = Nothing

            If Not tblGloArchivoDigital_Reniec Is Nothing AndAlso tblGloArchivoDigital_Reniec.Rows.Count > 0 Then

                c_nomColPK = tblGloArchivoDigital_Reniec.Rows(0).Item("key_name")

                c_nombTabla = "GLO_ArchivoDigital" ' tblMand.Rows(0).Item("tabla") 
                tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

                Try
                    For Each f As DataRow In tblGloArchivoDigital_Reniec.Rows

                        newRow = New Dictionary(Of String, Object)()

                        For Each colDB As DataColumn In tblTablaBD.Columns
                            If tblGloArchivoDigital_Reniec.Columns.Contains(colDB.ColumnName) = False Then Continue For
                            If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                            If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                            If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "_regid" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "_penid" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For

                            Select Case f(colDB.ColumnName).ToString.ToLower
                                Case "false"
                                    newRow.Add(colDB.ColumnName, 0)
                                Case "true"
                                    newRow.Add(colDB.ColumnName, 1)
                                Case Else
                                    Select Case colDB.DataType.Name
                                        Case Else
                                            newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                    End Select
                            End Select

                        Next

                        Dim strColum As String = ""
                        Dim strValor As String = ""
                        Dim strUpdate As String = ""

                        For Each k As KeyValuePair(Of String, Object) In newRow
                            strColum = strColum & ", " & k.Key
                            strValor = strValor & ", " & k.Value 'para el insert
                            strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                        Next
                        strColum = strColum.Substring(1, strColum.Length - 1)
                        strValor = strValor.Substring(1, strValor.Length - 1)
                        strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                        Dim strSQL As String = ""
                        Dim n_idTablaLocal As Integer = -1
                        n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                        If n_idTablaLocal = -1 Then
                            strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                        Else
                            strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                        End If

                        id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(strSQL, 0, "")

                        If n_idTablaLocal = -1 Then 'solo guardar foto fisico al ser insert
                            Dim by_Foto As Byte() = Nothing
                            Try
                                by_Foto = (New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(f.Item("_sed_rowid"), 4, outSms, True)
                                If by_Foto Is Nothing Then 'segundo intento
                                    'outSms = "No se pudo descargar la foto del perfil izquierdo desde la sede central, " & outSms
                                    outSms = ""
                                Else
                                    If f.Item("arc_dig_pth_ser").ToString.Length > 0 Then
                                        APPWebService.Fotografia.SubirFotoByte_v2(by_Foto,
                                                                                  f.Item("arc_dig_nom_fis"),
                                                                                  f.Item("arc_dig_ext"),
                                                                                  f.Item("arc_dig_pth_ser"),
                                                                                  APPWebService.Fotografia.enmDirectotioTipo.Reniec,
                                                                                  outSms)
                                    End If
                                End If
                            Catch ex As Exception
                                Dim s As String
                                s = ""
                            End Try
                        End If

                        f.Item("_rowid") = id
                        f.AcceptChanges()
                        tblGloArchivoDigital_Reniec.AcceptChanges()
                    Next

                Catch ex As Exception
                    outSms = outSms & ex.Message
                    Return -1
                End Try

            End If

            '**************************************************************************************************************************************************

            If tblInternoReniec Is Nothing OrElse tblInternoReniec.Rows.Count = 0 Then Return 0
            id = -1
            Dim tmpId As Integer = -1
            newRow = Nothing
            c_nomColPK = tblInternoReniec.Rows(0).Item("key_name")

            c_nombTabla = "INT_InternoRENIEC"
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

            For Each f As DataRow In tblInternoReniec.Rows
                newRow = New Dictionary(Of String, Object)()
                Try

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblInternoReniec.Columns.Contains(colDB.ColumnName) = False Then Continue For

                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then newRow.Add(colDB.ColumnName, n_inpe_ing_id) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "reg_id" Or colDB.ColumnName.ToLower.Trim = "_regid" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "pen_id" Or colDB.ColumnName.ToLower.Trim = "_penid" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "fot_rnc" And f.Item("fot_rnc") > 0 Then
                            Dim filas As DataRow()
                            filas = tblGloArchivoDigital_Reniec.Select("arc_dig_id=" & f.Item("fot_rnc"))
                            f.Item("fot_rnc") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            tmpId = f.Item("fot_rnc")
                            f.AcceptChanges()

                        End If

                        If colDB.ColumnName.ToLower.Trim = "fot_int" And f.Item("fot_int") > 0 Then
                            Dim filas As DataRow()
                            filas = tblGloArchDigital_IntFoto.Select("arc_dig_id=" & f.Item("fot_int"))
                            f.Item("fot_int") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                        End Select
                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(strSQL, 0, outSms)
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblGloArchivoDigital_Reniec.AcceptChanges()

                    'update a GloArchivoDigital
                    If tmpId > 0 Then
                        strSQL = "Update GLO_ArchivoDigital set int_id=" & id & " where arc_dig_id = " & tmpId
                        id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(strSQL, 0, outSms)
                    End If

                Catch ex As Exception
                    outSms = outSms & ex.Message
                    Return -1
                End Try
            Next
            tblInternoReniec.AcceptChanges()


            Return 0
        End Function

        Private Function GrabarGloArchivoDigital_InternoFoto(ByRef tblGloArchDigital_IntFoto As DataTable, ByRef tblIntFoto As DataTable, n_int_id As Integer, n_inpe_ing_id As Integer, n_ingId As Integer, ByRef outSms As String) As Integer
            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim c_nomColPK As String = ""
            Dim tblTablaBD As DataTable = Nothing
            Dim newRow As Dictionary(Of String, Object) = Nothing
            'Dim ultIngInpeSedeId As Integer = -1
            'ultIngInpeSedeId = tblIngInpe.Rows(0).Item("id_ult_ing_inp")


            If Not tblGloArchDigital_IntFoto Is Nothing AndAlso tblGloArchDigital_IntFoto.Rows.Count > 0 Then

                c_nomColPK = tblGloArchDigital_IntFoto.Rows(0).Item("key_name")

                c_nombTabla = "GLO_ArchivoDigital" ' tblMand.Rows(0).Item("tabla") 
                tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

                Try
                    For Each f As DataRow In tblGloArchDigital_IntFoto.Rows

                        newRow = New Dictionary(Of String, Object)()

                        For Each colDB As DataColumn In tblTablaBD.Columns
                            If tblGloArchDigital_IntFoto.Columns.Contains(colDB.ColumnName) = False Then Continue For
                            If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                            If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                            If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                            'If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For

                            If colDB.ColumnName.ToLower.Trim = "_regid" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "_penid" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For

                            Select Case f(colDB.ColumnName).ToString.ToLower
                                Case "false"
                                    newRow.Add(colDB.ColumnName, 0)
                                Case "true"
                                    newRow.Add(colDB.ColumnName, 1)
                                Case Else
                                    newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                            End Select
                        Next

                        Dim strColum As String = ""
                        Dim strValor As String = ""
                        Dim strUpdate As String = ""

                        For Each k As KeyValuePair(Of String, Object) In newRow
                            strColum = strColum & ", " & k.Key
                            strValor = strValor & ", " & k.Value 'para el insert
                            strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                        Next
                        strColum = strColum.Substring(1, strColum.Length - 1)
                        strValor = strValor.Substring(1, strValor.Length - 1)
                        strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                        Dim strSQL As String = ""
                        Dim n_idTablaLocal As Integer = -1
                        n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                        If n_idTablaLocal = -1 Then
                            strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                        Else
                            strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                        End If

                        id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(strSQL, 0, "")

                        If n_idTablaLocal = -1 Then 'solo guardar foto fisico al ser insert
                            Dim by_Foto As Byte() = Nothing
                            Try
                                by_Foto = (New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(f.Item("_sed_rowid"), 1, outSms, True)
                                If by_Foto Is Nothing Then
                                    outSms = ""
                                Else
                                    If f.Item("arc_dig_pth_ser").ToString.Length > 0 Then
                                        APPWebService.Fotografia.SubirFotoByte_v2(by_Foto,
                                                                                  f.Item("arc_dig_nom_fis"),
                                                                                  f.Item("arc_dig_ext"),
                                                                                  f.Item("arc_dig_pth_ser"),
                                                                                  APPWebService.Fotografia.enmDirectotioTipo.Interno,
                                                                                  outSms)
                                    End If
                                End If
                                'guardar foto en directorio ---------------------------------------------
                            Catch ex As Exception
                                Dim s As String
                                s = ""
                            End Try
                        End If

                        f.Item("_rowid") = id
                        f.AcceptChanges()
                        tblGloArchDigital_IntFoto.AcceptChanges()
                    Next

                Catch ex As Exception
                    outSms = outSms & ex.Message
                    Return -1
                End Try

            End If

            '**************************************************************************************************************************************************

            If tblIntFoto Is Nothing OrElse tblIntFoto.Rows.Count = 0 Then Return 0
            id = -1
            newRow = Nothing
            c_nomColPK = tblIntFoto.Rows(0).Item("key_name")

            c_nombTabla = tblIntFoto.Rows(0).Item("tabla")
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

            For Each f As DataRow In tblIntFoto.Rows
                newRow = New Dictionary(Of String, Object)()
                Try

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblIntFoto.Columns.Contains(colDB.ColumnName) = False Then Continue For

                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For

                        'If f.Item("fk_ing_inp_id") = ultIngInpeSedeId Then
                        '    If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then newRow.Add(colDB.ColumnName, n_inp_ing_id) : Continue For
                        '    If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For
                        '    If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                        '    If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For
                        'Else
                        '    If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then
                        '        If f.Item("fk_ing_inp_id") > 0 Then
                        '            Dim idIngInpId As Integer = -1
                        '            idIngInpId = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", f.Item("fk_ing_inp_id"), 0, outSms)
                        '            f.Item("fk_ing_inp_id") = idIngInpId
                        '            f.AcceptChanges()
                        '        End If

                        '        newRow.Add(colDB.ColumnName, f.Item("fk_ing_inp_id"))
                        '        Continue For
                        '    End If
                        '    If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, -1) : Continue For 'artificio ingresoId -1
                        '    If colDB.ColumnName.ToLower.Trim = "_flg_trf" Then newRow.Add(colDB.ColumnName, 0) : Continue For 'no debe transferir
                        '    If colDB.ColumnName.ToLower.Trim = "_arc_nom" Then newRow.Add(colDB.ColumnName, "'NO_TRANSFER_REG'") : Continue For
                        'End If

                        If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then newRow.Add(colDB.ColumnName, n_inpe_ing_id) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "reg_id" Or colDB.ColumnName.ToLower.Trim = "_regid" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "pen_id" Or colDB.ColumnName.ToLower.Trim = "_penid" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For


                        If colDB.ColumnName.ToLower.Trim = "int_fot_per_izq" And f.Item("int_fot_per_izq") > 0 Then
                            Dim filas As DataRow()
                            filas = tblGloArchDigital_IntFoto.Select("arc_dig_id=" & f.Item("int_fot_per_izq"))
                            f.Item("int_fot_per_izq") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "int_fot_per_fre" And f.Item("int_fot_per_fre") > 0 Then
                            Dim filas As DataRow()
                            filas = tblGloArchDigital_IntFoto.Select("arc_dig_id=" & f.Item("int_fot_per_fre"))
                            f.Item("int_fot_per_fre") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "int_fot_per_der" And f.Item("int_fot_per_der") > 0 Then
                            Dim filas As DataRow()
                            filas = tblGloArchDigital_IntFoto.Select("arc_dig_id=" & f.Item("int_fot_per_der"))
                            f.Item("int_fot_per_der") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        Dim cad As String = ""
                                        cad = "CAST(N'' AS xml).value('xs:base64Binary(""" & Convert.ToBase64String(f(colDB.ColumnName)) & """)', 'varbinary(max)')"
                                        'newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & f(colDB.ColumnName) & """)', 'varbinary(max)')")
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select
                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(strSQL, 0, outSms)

                Catch ex As Exception
                    outSms = outSms & ex.Message
                    Return -1
                End Try
            Next
            tblIntFoto.AcceptChanges()


            Return 0
        End Function

        Private Function GrabarInternoHuella(tblInternoHuella As DataTable, tblTemplateHuella As DataTable, n_int_id As Integer, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarInternoHuella"
            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim tblTablaBD As DataTable = Nothing
            Dim newRow As Dictionary(Of String, Object)


            If tblInternoHuella Is Nothing OrElse tblInternoHuella.Rows.Count = 0 Then Return 0

            Dim c_nomColPK As String = tblInternoHuella.Rows(0).Item("key_name")

            c_nombTabla = "mov_interno_huella"
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

            newRow = New Dictionary(Of String, Object)()
            Try
                For Each f As DataRow In tblInternoHuella.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblInternoHuella.Columns.Contains(colDB.ColumnName) = False Then Continue For

                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Men_Izq_id".ToLower And f.Item("fk_hue_Men_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Men_Izq_id"))
                            f.Item("fk_hue_Men_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Anu_Izq_id".ToLower And f.Item("fk_hue_Anu_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Anu_Izq_id"))
                            f.Item("fk_hue_Anu_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Med_Izq_id".ToLower And f.Item("fk_hue_Med_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Med_Izq_id"))
                            f.Item("fk_hue_Med_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Ind_Izq_id".ToLower And f.Item("fk_hue_Ind_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Ind_Izq_id"))
                            f.Item("fk_hue_Ind_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Pul_Izq_id".ToLower And f.Item("fk_hue_Pul_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Pul_Izq_id"))
                            f.Item("fk_hue_Pul_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Men_Der_id".ToLower And f.Item("fk_hue_Men_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Men_Der_id"))
                            f.Item("fk_hue_Men_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Anu_Der_id".ToLower And f.Item("fk_hue_Anu_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Anu_Der_id"))
                            f.Item("fk_hue_Anu_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Med_Der_id".ToLower And f.Item("fk_hue_Med_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Med_Der_id"))
                            f.Item("fk_hue_Med_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Ind_Der_id".ToLower And f.Item("fk_hue_Ind_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Ind_Der_id"))
                            f.Item("fk_hue_Ind_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Pul_Der_id".ToLower And f.Item("fk_hue_Pul_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Pul_Der_id"))
                            f.Item("fk_hue_Pul_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & f(colDB.ColumnName) & """)', 'varbinary(max)')")
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(strSQL, 0, "")
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblInternoHuella.AcceptChanges()
                Next
            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try
            Return id
        End Function
        Private Function GrabarInternoHuellaProv(tblInternoHuella As DataTable, tblTemplateHuella As DataTable, n_int_id As Integer, PenalLocalId As Integer, RegionLocalId As Integer, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarInternoHuella"
            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim tblTablaBD As DataTable = Nothing
            Dim newRow As Dictionary(Of String, Object)


            If tblInternoHuella Is Nothing OrElse tblInternoHuella.Rows.Count = 0 Then Return 0

            Dim c_nomColPK As String = tblInternoHuella.Rows(0).Item("key_name")

            c_nombTabla = "mov_interno_huella"
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

            newRow = New Dictionary(Of String, Object)()
            Try
                For Each f As DataRow In tblInternoHuella.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblInternoHuella.Columns.Contains(colDB.ColumnName) = False Then Continue For

                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Men_Izq_id".ToLower And f.Item("fk_hue_Men_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Men_Izq_id"))
                            f.Item("fk_hue_Men_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Anu_Izq_id".ToLower And f.Item("fk_hue_Anu_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Anu_Izq_id"))
                            f.Item("fk_hue_Anu_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Med_Izq_id".ToLower And f.Item("fk_hue_Med_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Med_Izq_id"))
                            f.Item("fk_hue_Med_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Ind_Izq_id".ToLower And f.Item("fk_hue_Ind_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Ind_Izq_id"))
                            f.Item("fk_hue_Ind_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Pul_Izq_id".ToLower And f.Item("fk_hue_Pul_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Pul_Izq_id"))
                            f.Item("fk_hue_Pul_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Men_Der_id".ToLower And f.Item("fk_hue_Men_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Men_Der_id"))
                            f.Item("fk_hue_Men_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Anu_Der_id".ToLower And f.Item("fk_hue_Anu_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Anu_Der_id"))
                            f.Item("fk_hue_Anu_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Med_Der_id".ToLower And f.Item("fk_hue_Med_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Med_Der_id"))
                            f.Item("fk_hue_Med_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Ind_Der_id".ToLower And f.Item("fk_hue_Ind_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Ind_Der_id"))
                            f.Item("fk_hue_Ind_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Pul_Der_id".ToLower And f.Item("fk_hue_Pul_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Pul_Der_id"))
                            f.Item("fk_hue_Pul_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, RegionLocalId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, PenalLocalId) : Continue For

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & f(colDB.ColumnName) & """)', 'varbinary(max)')")
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(strSQL, 0, "")
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblInternoHuella.AcceptChanges()
                Next
            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try
            Return id
        End Function
        Private Function GrabarWSQHuella(tblWSQHuella As DataTable, tblTemplateHuella As DataTable, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarWSQHuella"
            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim tblTablaBD As DataTable = Nothing
            Dim newRow As Dictionary(Of String, Object)


            If tblWSQHuella Is Nothing OrElse tblWSQHuella.Rows.Count = 0 Then Return 0

            Dim c_nomColPK As String = tblWSQHuella.Rows(0).Item("key_name")

            c_nombTabla = "mov_huella_wsq"
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, 0, "")

            newRow = New Dictionary(Of String, Object)()
            Try
                For Each f As DataRow In tblWSQHuella.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblWSQHuella.Columns.Contains(colDB.ColumnName) = False Then Continue For

                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        'If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                        'If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then newRow.Add(colDB.ColumnName, n_inpe_ing_id) : Continue For
                        'If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "fk_tmp_id" And f.Item("fk_tmp_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_tmp_id"))
                            f.Item("fk_tmp_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        Try
                                            newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & Convert.ToBase64String(f(colDB.ColumnName)) & """)', 'varbinary(max)')")
                                        Catch ex As Exception
                                            newRow.Add(colDB.ColumnName, "null")
                                        End Try
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeHuellaInternoBD(Me.CNBDHuellaVisita, strSQL, 0, "")
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblWSQHuella.AcceptChanges()
                Next
            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try
            Return id
        End Function
        Private Function GrabarWSQHuellaProv(tblWSQHuella As DataTable, tblTemplateHuella As DataTable, InternoLocalId As Integer, PenalLocalId As Integer, RegionLocalId As Integer, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarWSQHuella"
            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim tblTablaBD As DataTable = Nothing
            Dim newRow As Dictionary(Of String, Object)


            If tblWSQHuella Is Nothing OrElse tblWSQHuella.Rows.Count = 0 Then Return 0

            Dim c_nomColPK As String = tblWSQHuella.Rows(0).Item("key_name")

            c_nombTabla = "mov_huella_wsq"
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, 0, "")

            newRow = New Dictionary(Of String, Object)()
            Try
                For Each f As DataRow In tblWSQHuella.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblWSQHuella.Columns.Contains(colDB.ColumnName) = False Then Continue For

                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        'If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                        'If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then newRow.Add(colDB.ColumnName, n_inpe_ing_id) : Continue For
                        'If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "fk_tmp_id" And f.Item("fk_tmp_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_tmp_id"))
                            f.Item("fk_tmp_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, RegionLocalId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, PenalLocalId) : Continue For

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        Try
                                            newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & Convert.ToBase64String(f(colDB.ColumnName)) & """)', 'varbinary(max)')")
                                        Catch ex As Exception
                                            newRow.Add(colDB.ColumnName, "null")
                                        End Try
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeHuellaInternoBD(Me.CNBDHuellaVisita, strSQL, 0, "")
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblWSQHuella.AcceptChanges()
                Next
            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try
            Return id
        End Function
        Private Function GrabarTemplateHuella(tblTemplateHuella As DataTable, n_int_id As Integer, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarTemplateHuella"
            If tblTemplateHuella Is Nothing OrElse tblTemplateHuella.Rows.Count = 0 Then Return 0

            Dim id As Integer = -1

            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim c_nomColPK As String = tblTemplateHuella.Rows(0).Item("key_name")

            Dim tblTablaBD As DataTable = Nothing
            c_nombTabla = "mov_template_huella" ' tblMand.Rows(0).Item("tabla")
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, 0, "")

            Dim newRow As Dictionary(Of String, Object)

            Try
                For Each f As DataRow In tblTemplateHuella.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblTemplateHuella.Columns.Contains(colDB.ColumnName) = False Then Continue For
                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        'If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For


                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        Try
                                            newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & Convert.ToBase64String(f(colDB.ColumnName)) & """)', 'varbinary(max)')")
                                        Catch ex As Exception
                                            newRow.Add(colDB.ColumnName, "null")
                                        End Try
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeHuellaInternoBD(Me.CNBDHuellaVisita, strSQL, 0, "")
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblTemplateHuella.AcceptChanges()
                Next

            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try
            Return id
        End Function
        Private Function GrabarTemplateHuellaProv(tblTemplateHuella As DataTable, n_int_id As Integer, PenalLocalId As Integer, RegionLocalId As Integer, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarTemplateHuella"
            If tblTemplateHuella Is Nothing OrElse tblTemplateHuella.Rows.Count = 0 Then Return 0

            Dim id As Integer = -1

            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim c_nomColPK As String = tblTemplateHuella.Rows(0).Item("key_name")

            Dim tblTablaBD As DataTable = Nothing
            c_nombTabla = "mov_template_huella" ' tblMand.Rows(0).Item("tabla")
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, 0, "")

            Dim newRow As Dictionary(Of String, Object)

            Try
                For Each f As DataRow In tblTemplateHuella.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblTemplateHuella.Columns.Contains(colDB.ColumnName) = False Then Continue For
                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        'If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, RegionLocalId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, PenalLocalId) : Continue For


                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        Try
                                            newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & Convert.ToBase64String(f(colDB.ColumnName)) & """)', 'varbinary(max)')")
                                        Catch ex As Exception
                                            newRow.Add(colDB.ColumnName, "null")
                                        End Try
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeHuellaInternoBD(Me.CNBDHuellaVisita, strSQL, 0, "")
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblTemplateHuella.AcceptChanges()
                Next

            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try
            Return id
        End Function
        Private Function GrabarInterno(tblInterno As DataTable, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarInterno"

            If tblInterno Is Nothing OrElse tblInterno.Rows.Count = 0 Then
                outSms = "No existe nungún registro de interno para descargar."
                Return -1
            End If
            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim c_nomColPK As String = tblInterno.Rows(0).Item("key_name")

            Dim tblTablaBD As DataTable = Nothing
            c_nombTabla = tblInterno.Rows(0).Item("tabla")
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

            Dim newRow As Dictionary(Of String, Object)
            Try
                For Each f As DataRow In tblInterno.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblInterno.Columns.Contains(colDB.ColumnName) = False Then Continue For
                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primaria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "int_est_id" Then Continue For 'artificio para activar al interno posteriormente

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & f(colDB.ColumnName) & """)', 'varbinary(max)')")
                                    Case Else
                                        newRow.Add(colDB.ColumnName, f(colDB.ColumnName).ToString.Replace("'", ""))
                                End Select
                        End Select
                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    Dim cmd As New SqlCommand

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", @" & k.Key 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = @" & k.Key 'para el update
                        cmd.Parameters.Add(New SqlParameter("@" & k.Key, k.Value))
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    'si no encuentra por SedRowId buscar por otros datos
                    If n_idTablaLocal = -1 Then
                        Dim ent As New Entity.Registro.Interno
                        Dim entCol As New Entity.Registro.InternoCol
                        Dim bss As New Bussines.Registro.Interno

                        ent.CodigoRP = f.Item("int_cod_rp")
                        ent.ApellidoPaterno = Trim(f.Item("int_ape_pat"))
                        ent.ApellidoMaterno = Trim(f.Item("int_ape_mat"))
                        ent.Nombres = Trim(f.Item("int_nom"))
                        ent.TipoDocumentoID = f.Item("tip_doc_id")
                        ent.NumeroDocumento = Trim(f.Item("int_doc_num"))
                        ent.FechaNacimiento = f.Item("int_fec_nac")

                        entCol = bss.Listar_LM(ent)

                        If entCol.Count > 0 AndAlso entCol.Item(0).SedeRowId = -1 Then
                            n_idTablaLocal = entCol.Item(0).Codigo
                        End If
                    End If

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ",int_est_id) VALUES (" & strValor & ",1); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & ",int_est_id=1 WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD_v2(strSQL, cmd, 0, outSms)
                Next
            Catch ex As Exception
                Type.LogSIP.getLog.ErrorCritico(strLog, "Excepcion: " & ex.ToString)
                outSms = outSms & ex.Message
                Return -1
            End Try

            Return id
        End Function

        Private Function GrabarIngresoInpe(tblIngresoInpe As DataTable, n_int_id As Integer, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarIngresoInpe"
            If tblIngresoInpe Is Nothing OrElse tblIngresoInpe.Rows.Count = 0 Then
                outSms = "El interno no cuenta con ingreso INPE"
                Return -1
            End If

            Dim c_nombTabla As String = ""
            Dim n_ingPenIdLocal As Integer = -1
            Dim n_idIngPenTmp As Integer = -1
            Dim c_nomColPK As String = tblIngresoInpe.Rows(0).Item("key_name")

            Dim tblTablaBD As DataTable = Nothing
            c_nombTabla = tblIngresoInpe.Rows(0).Item("tabla")
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

            Dim newRow As Dictionary(Of String, Object)

            For Each f As DataRow In tblIngresoInpe.Rows

                newRow = New Dictionary(Of String, Object)()

                For Each colTablaBD As DataColumn In tblTablaBD.Columns
                    If tblIngresoInpe.Columns.Contains(colTablaBD.ColumnName) = False Then Continue For
                    If c_nomColPK.ToLower = colTablaBD.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                    If colTablaBD.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                    If colTablaBD.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colTablaBD.ColumnName, n_int_id) : Continue For
                    If colTablaBD.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colTablaBD.ColumnName, -1) : Continue For

                    If f.Item("id_ult_ing_inp") = f.Item("_sed_rowid") Then
                        If colTablaBD.ColumnName.ToLower.Trim = "_regid" Or colTablaBD.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colTablaBD.ColumnName, Me.RegionId) : Continue For
                        If colTablaBD.ColumnName.ToLower.Trim = "_penid" Or colTablaBD.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colTablaBD.ColumnName, Me.PenalId) : Continue For
                    Else
                        If colTablaBD.ColumnName.ToLower.Trim = "_flg_trf" Then newRow.Add(colTablaBD.ColumnName, 0) : Continue For 'no debe transferir
                        If colTablaBD.ColumnName.ToLower.Trim = "_arc_nom" Then newRow.Add(colTablaBD.ColumnName, "NO_TRANSFER_REG") : Continue For
                    End If

                    Select Case f(colTablaBD.ColumnName).ToString.ToLower
                        Case "false"
                            newRow.Add(colTablaBD.ColumnName, 0)
                        Case "true"
                            newRow.Add(colTablaBD.ColumnName, 1)
                        Case Else
                            Select Case colTablaBD.DataType.Name
                                Case "Byte[]"
                                    newRow.Add(colTablaBD.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & f(colTablaBD.ColumnName) & """)', 'varbinary(max)')")
                                Case Else
                                    newRow.Add(colTablaBD.ColumnName, f(colTablaBD.ColumnName).ToString.Replace("'", ""))
                            End Select
                    End Select

                Next

                Dim strColum As String = ""
                Dim strValor As String = ""
                Dim strUpdate As String = ""

                Dim cmd As New SqlCommand

                For Each k As KeyValuePair(Of String, Object) In newRow
                    strColum = strColum & ", " & k.Key
                    strValor = strValor & ", @" & k.Key 'para el insert
                    strUpdate = strUpdate & ", " & k.Key & " = @" & k.Key 'para el update
                    cmd.Parameters.Add(New SqlParameter("@" & k.Key, k.Value))
                Next
                strColum = strColum.Substring(1, strColum.Length - 1)
                strValor = strValor.Substring(1, strValor.Length - 1)
                strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                Dim strSQL As String = ""
                Dim n_idTablaLocal As Integer = -1
                n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                If n_idTablaLocal = -1 Then
                    strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                Else
                    strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                End If

                n_idIngPenTmp = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD_v2(strSQL, cmd, 0, outSms)

                If n_idTablaLocal > 0 Then 'si ya se encuentra registrado el ingresoInpe en la Bd local

                    Dim tblMov As DataTable
                    tblMov = Bussines.Globall.UtilAccesoBD.EjecutarSqlToTable_PopeBD("select top 1 * from INT_InternoMovimiento where fk_ing_inp_id = " & n_idIngPenTmp, outSms)
                    If Not tblMov Is Nothing Then 'si cuenta con algun movimiento, 
                        If tblMov.Rows.Count > 0 Then
                            strSQL = "update int_mov_interno_ingreso_inpe set _regid=" & Me.RegionId & ",_penid=" & Me.PenalId & ",_arc_nom='' where pk_ing_inp_id=" & n_idIngPenTmp
                            Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(strSQL, -1, "")
                        End If
                    End If
                End If

                If n_idIngPenTmp = -1 Then
                    Return -1
                End If

                f.Item("_RowId") = n_idIngPenTmp
                f.AcceptChanges()
                tblIngresoInpe.AcceptChanges()

                If f.Item("id_ult_ing_inp") = f.Item("_sed_rowid") Then 'si el registro es el ultimo ingresoInpe del interno capturar el idlocal de ingresoInpe
                    n_ingPenIdLocal = n_idIngPenTmp
                End If
            Next

            Return n_ingPenIdLocal
        End Function

        Private Function GrabarInternoIngreso(tblIngresoInpe As DataTable, n_int_id As Integer, n_inpe_ing_id As Integer, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarInternoIngreso"
            Dim blnCondicion As Boolean = False

            Dim bssIntHist As New Bussines.Registro.InternoHistorico
            Dim objBss As Bussines.Registro.Ingreso = Nothing
            Dim objEnt As Entity.Registro.Ingreso = Nothing
            Dim tmpEntIng As Entity.Registro.Ingreso
            Dim rowUltimoIngreso() As DataRow

            objBss = New Bussines.Registro.Ingreso
            objEnt = New Entity.Registro.Ingreso

            Dim intValue As Integer = -1

            tmpEntIng = objBss.ListarUltimoIngreso_LM(n_int_id)

            If Not tmpEntIng Is Nothing Then
                If tmpEntIng.IngresoInpeId = n_inpe_ing_id Then
                    intValue = tmpEntIng.Codigo
                    'actualizar internoHistorico

                    Dim objEntDatosInterno As New Entity.Registro.Interno
                    Dim objBssInterno As New Bussines.Registro.Interno

                    objEntDatosInterno = objBssInterno.Listar_LM(n_int_id)

                    Dim objEntIH As New Entity.Registro.InternoHistorico
                    Dim objEntIH_filtro As Entity.Registro.InternoHistorico

                    objEntIH_filtro = bssIntHist.ListarUltimoHistorico_Penal_LM(n_int_id, Me.PenalId)

                    objEntIH = bssIntHist.Listar_Convert_Historico_LM(objEntDatosInterno)
                    If Not objEntIH_filtro Is Nothing Then
                        objEntIH.Codigo = objEntIH_filtro.Codigo
                    End If
                    objEntIH.IngresoID = intValue
                    objEntIH.IngresoInpeId = n_inpe_ing_id

                    bssIntHist.Grabar_LM(objEntIH)

                    Return intValue
                End If
            End If

            rowUltimoIngreso = tblIngresoInpe.Select("pk_ing_inp_id = " & tblIngresoInpe.Rows(0).Item("id_ult_ing_inp"))

            'Dim tblMov As DataTable
            'tblMov = Bussines.Globall.UtilAccesoBD.EjecutarSqlToTable_PopeBD("select top 1 * from int_internoingreso where _flg_eli=0 and int_ing_nro=0 and isnull(fk_ing_inp_id,-1)=-1 and int_id= " & n_int_id, outSms)
            'If tblMov.Rows.Count > 0 Then
            '    Dim ss As String
            '    Dim idIng As Integer = -1
            '    ss = "update int_internoingreso set reg_id=" & Me.RegionId & " , pen_id=" & Me.PenalId & " , int_ing_nro= " & tblIngresoInpe.Rows(0).Item("c_num_ing") & ", int_ing_fec_isp=" & tblIngresoInpe.Rows(0).Item("n_fec_ing_inp") & ", ing_mot_id=" & rowUltimoIngreso(0).Item("fk_ing_mot_id") &
            '        ", int_ing_fec=" & Now.ToFileTime & ", fk_ing_inp_id=" & n_inpe_ing_id & ",  _PenId=" & Me.PenalId & ", _flg_trf=1  where int_ing_id = " & tblMov.Rows(0).Item("int_ing_id") & "; select " & tblMov.Rows(0).Item("int_ing_id")
            '    ss = ss
            '    idIng = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(ss, -1, "")
            '    If idIng > 0 Then
            '        Dim entHis As New Entity.Registro.InternoHistorico
            '        Dim bssHist As New Bussines.Registro.InternoHistorico
            '        entHis.IngresoID = idIng
            '        entHis = bssHist.Listar_LM(entHis)

            '        If entHis Is Nothing Then
            '            Dim intValueHis As Integer = -1
            '            intValueHis = (New Bussines.Registro.InternoHistorico).Grabar_HistoricoDeInterno_LM(n_int_id, idIng, n_inpe_ing_id)
            '        End If

            '        Return idIng
            '    End If
            'End If

            Dim lngIDIngreso As Long = -1
            Dim strSQL As String = ""
            Dim cmd As New SqlCommand

            strSQL = "insert into INT_InternoIngreso(
	                    int_id,
	                    reg_id,
	                    pen_id,
	                    int_ing_nro,
	                    int_ing_fec_isp,
	                    int_ing_doc,
	                    int_ing_doc_fec_rcp,
	                    int_ing_doc_fec,
	                    ing_mot_id,
	                    int_ing_fec,
	                    tip_lib_doc,
	                    int_ing_lib_doc_fec,
	                    tip_lib_id,
	                    tip_lib_fec,
	                    int_ing_obs,
	                    _usu_cre,
	                    _fec_cre,
	                    _usu_mod,
	                    _fec_mod,
	                    _usu_eli,
	                    _fec_eli,
	                    _flg_eli,
	                    _arc_nom,
	                    _RegId,
	                    _PenId,
	                    _RowId,
	                    _flg_trf,
	                    int_ing_est,
	                    _fec_proc_trf,
	                    fk_ing_inp_id,
	                    fk_mov_tip_id
                    ) values (
	                    @int_id,
	                    @reg_id,
	                    @pen_id,
	                    @int_ing_nro,
	                    @int_ing_fec_isp,
	                    @int_ing_doc,
	                    @int_ing_doc_fec_rcp,
	                    @int_ing_doc_fec,
	                    @ing_mot_id,
	                    @int_ing_fec,
	                    @tip_lib_doc,
	                    @int_ing_lib_doc_fec,
	                    @tip_lib_id,
	                    @tip_lib_fec,
	                    @int_ing_obs,
	                    @_usu_cre,
	                    @_fec_cre,
	                    @_usu_mod,
	                    @_fec_mod,
	                    @_usu_eli,
	                    @_fec_eli,
	                    @_flg_eli,
	                    @_arc_nom,
	                    @_RegId,
	                    @_PenId,
	                    @_RowId,
	                    @_flg_trf,
	                    @int_ing_est,
	                    @_fec_proc_trf,
	                    @fk_ing_inp_id,
	                    @fk_mov_tip_id
                    ); select scope_identity()"


            cmd.Parameters.Add(New SqlParameter("@int_id", n_int_id))
            cmd.Parameters.Add(New SqlParameter("@reg_id", Me.RegionId))
            cmd.Parameters.Add(New SqlParameter("@pen_id", Me.PenalId))
            cmd.Parameters.Add(New SqlParameter("@int_ing_nro", tblIngresoInpe.Rows(0).Item("c_num_ing")))
            cmd.Parameters.Add(New SqlParameter("@int_ing_fec_isp", tblIngresoInpe.Rows(0).Item("n_fec_ing_inp")))
            cmd.Parameters.Add(New SqlParameter("@int_ing_doc", ""))
            cmd.Parameters.Add(New SqlParameter("@int_ing_doc_fec_rcp", 0))
            cmd.Parameters.Add(New SqlParameter("@int_ing_doc_fec", 0))
            cmd.Parameters.Add(New SqlParameter("@ing_mot_id", rowUltimoIngreso(0).Item("fk_ing_mot_id")))
            cmd.Parameters.Add(New SqlParameter("@int_ing_fec", Now.ToFileTime))
            cmd.Parameters.Add(New SqlParameter("@tip_lib_doc", ""))
            cmd.Parameters.Add(New SqlParameter("@int_ing_lib_doc_fec", 0))
            cmd.Parameters.Add(New SqlParameter("@tip_lib_id", -1))
            cmd.Parameters.Add(New SqlParameter("@tip_lib_fec", 0))
            cmd.Parameters.Add(New SqlParameter("@int_ing_obs", ""))
            cmd.Parameters.Add(New SqlParameter("@_usu_cre", rowUltimoIngreso(0).Item("_usu_cre")))
            cmd.Parameters.Add(New SqlParameter("@_fec_cre", rowUltimoIngreso(0).Item("_fec_cre")))
            cmd.Parameters.Add(New SqlParameter("@_usu_mod", rowUltimoIngreso(0).Item("_usu_cre")))
            cmd.Parameters.Add(New SqlParameter("@_fec_mod", rowUltimoIngreso(0).Item("_fec_cre")))
            cmd.Parameters.Add(New SqlParameter("@_usu_eli", -1))
            cmd.Parameters.Add(New SqlParameter("@_fec_eli", 0))
            cmd.Parameters.Add(New SqlParameter("@_flg_eli", 0))
            cmd.Parameters.Add(New SqlParameter("@_arc_nom", ""))
            cmd.Parameters.Add(New SqlParameter("@_RegId", Me.RegionId))
            cmd.Parameters.Add(New SqlParameter("@_PenId", Me.PenalId))
            cmd.Parameters.Add(New SqlParameter("@_RowId", -1))
            cmd.Parameters.Add(New SqlParameter("@_flg_trf", 1))
            cmd.Parameters.Add(New SqlParameter("@int_ing_est", 1))
            cmd.Parameters.Add(New SqlParameter("@_fec_proc_trf", 0))
            cmd.Parameters.Add(New SqlParameter("@fk_ing_inp_id", n_inpe_ing_id))
            cmd.Parameters.Add(New SqlParameter("@fk_mov_tip_id", -1))


            intValue = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD_v2(strSQL, cmd, 0, outSms)

            If intValue > 0 Then
                Dim intValueHis As Integer = -1
                intValueHis = (New Bussines.Registro.InternoHistorico).Grabar_HistoricoDeInterno_LM(n_int_id, intValue, n_inpe_ing_id)
            End If

            Return intValue
        End Function

        Private Function GrabarOrgCriminal(tblDocJud As DataTable, tblOrgCrim As DataTable, n_int_id As Integer, tblIngInpe As DataTable, n_ingId As Integer, n_inp_ing_id As Integer, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarOrgCriminal"
            If tblOrgCrim Is Nothing OrElse tblOrgCrim.Rows.Count = 0 Then Return 0

            Dim ultIngInpeSedeId As Integer = -1

            ultIngInpeSedeId = tblIngInpe.Rows(0).Item("id_ult_ing_inp")

            Dim id As Integer = -1
            Dim newRow As Dictionary(Of String, Object)
            Dim c_nombTabla As String = ""
            Dim c_nomColPK As String
            Dim tblTablaBD As DataTable = Nothing

            If Not tblDocJud Is Nothing AndAlso tblDocJud.Rows.Count > 0 Then
                c_nomColPK = tblDocJud.Rows(0).Item("key_name")

                c_nombTabla = "REG_DOC_Judicial" ' tblMand.Rows(0).Item("tabla")
                tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

                Try
                    For Each f As DataRow In tblDocJud.Rows

                        newRow = New Dictionary(Of String, Object)()

                        For Each colDB As DataColumn In tblTablaBD.Columns
                            If tblDocJud.Columns.Contains(colDB.ColumnName) = False Then Continue For
                            If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                            If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                            If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For

                            'If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then
                            '    Dim filas As DataRow()
                            '    filas = tblIngInpe.Select("pk_ing_inp_id=" & f.Item("fk_ing_inp_id"))
                            '    f.Item("fk_ing_inp_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            '    f.AcceptChanges()

                            '    newRow.Add(colDB.ColumnName, If(filas.Count > 0, filas(0).Item("_rowid"), -1))
                            '    Continue For
                            'End If

                            If f.Item("fk_ing_inp_id") = ultIngInpeSedeId Then
                                If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then newRow.Add(colDB.ColumnName, n_inp_ing_id) : Continue For
                                If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For
                                If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                                If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For
                            Else
                                If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then
                                    If f.Item("fk_ing_inp_id") > 0 Then
                                        Dim filas As DataRow()
                                        filas = tblIngInpe.Select("pk_ing_inp_id=" & f.Item("fk_ing_inp_id"))
                                        f.Item("fk_ing_inp_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                                        f.AcceptChanges()
                                    End If

                                    newRow.Add(colDB.ColumnName, f.Item("fk_ing_inp_id"))
                                    Continue For
                                End If
                                If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, -1) : Continue For 'artificio ingresoId -1
                                If colDB.ColumnName.ToLower.Trim = "_flg_trf" Then newRow.Add(colDB.ColumnName, 0) : Continue For 'no debe transferir
                                If colDB.ColumnName.ToLower.Trim = "_arc_nom" Then newRow.Add(colDB.ColumnName, "'NO_TRANSFER_REG'") : Continue For
                            End If


                            If colDB.ColumnName.ToLower.Trim = "fk_doc_jud_id_anu" And f.Item("fk_doc_jud_id_anu") > 0 Then
                                Dim filas As DataRow()
                                filas = tblDocJud.Select("doc_jud_id=" & f.Item("fk_doc_jud_id_anu"))
                                f.Item("fk_doc_jud_id_anu") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            End If

                            Select Case f(colDB.ColumnName).ToString.ToLower
                                Case "false"
                                    newRow.Add(colDB.ColumnName, 0)
                                Case "true"
                                    newRow.Add(colDB.ColumnName, 1)
                                Case Else
                                    Select Case colDB.DataType.Name
                                        Case "Byte[]"
                                            newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & f(colDB.ColumnName) & """)', 'varbinary(max)')")
                                        Case Else
                                            newRow.Add(colDB.ColumnName, f(colDB.ColumnName).ToString.Replace("'", ""))
                                    End Select
                            End Select
                        Next

                        Dim strColum As String = ""
                        Dim strValor As String = ""
                        Dim strUpdate As String = ""

                        Dim cmd As New SqlCommand

                        For Each k As KeyValuePair(Of String, Object) In newRow
                            strColum = strColum & ", " & k.Key
                            strValor = strValor & ", @" & k.Key 'para el insert
                            strUpdate = strUpdate & ", " & k.Key & " = @" & k.Key 'para el update
                            cmd.Parameters.Add(New SqlParameter("@" & k.Key, k.Value))
                        Next
                        strColum = strColum.Substring(1, strColum.Length - 1)
                        strValor = strValor.Substring(1, strValor.Length - 1)
                        strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                        Dim strSQL As String = ""
                        Dim n_idTablaLocal As Integer = -1
                        n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                        If n_idTablaLocal = -1 Then
                            strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                        Else
                            strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                        End If

                        id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD_v2(strSQL, cmd, 0, outSms)

                        f.Item("_rowid") = id
                        f.AcceptChanges()
                        tblDocJud.AcceptChanges()
                    Next
                Catch ex As Exception
                    outSms = outSms & ex.Message
                    Return -1
                End Try
            End If

            '--------------------------- org criminal - Interno ------------------
            If tblOrgCrim Is Nothing Then Exit Function
            c_nomColPK = tblOrgCrim.Rows(0).Item("key_name")

            tblTablaBD = Nothing
            c_nombTabla = tblOrgCrim.Rows(0).Item("tabla")
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

            newRow = New Dictionary(Of String, Object)()
            Try
                For Each f As DataRow In tblOrgCrim.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblOrgCrim.Columns.Contains(colDB.ColumnName) = False Then Continue For

                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For

                        If f.Item("fk_ing_inp_id") = ultIngInpeSedeId Then
                            If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then newRow.Add(colDB.ColumnName, n_inp_ing_id) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For
                        Else
                            If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then
                                If f.Item("fk_ing_inp_id") > 0 Then
                                    Dim filas As DataRow()
                                    filas = tblIngInpe.Select("pk_ing_inp_id=" & f.Item("fk_ing_inp_id"))
                                    f.Item("fk_ing_inp_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                                    f.AcceptChanges()
                                End If

                                newRow.Add(colDB.ColumnName, f.Item("fk_ing_inp_id"))
                                Continue For
                            End If
                            If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, -1) : Continue For 'artificio ingresoId -1
                            If colDB.ColumnName.ToLower.Trim = "_flg_trf" Then newRow.Add(colDB.ColumnName, 0) : Continue For 'no debe transferir
                            If colDB.ColumnName.ToLower.Trim = "_arc_nom" Then newRow.Add(colDB.ColumnName, "'NO_TRANSFER_REG'") : Continue For
                        End If

                        If colDB.ColumnName.ToLower.Trim = "crea_doc_jud_id" And f.Item("crea_doc_jud_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblDocJud.Select("doc_jud_id=" & f.Item("crea_doc_jud_id"))
                            f.Item("crea_doc_jud_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "anul_doc_jud_id" And f.Item("anul_doc_jud_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblDocJud.Select("doc_jud_id=" & f.Item("anul_doc_jud_id"))
                            f.Item("anul_doc_jud_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & f(colDB.ColumnName) & """)', 'varbinary(max)')")
                                    Case Else
                                        newRow.Add(colDB.ColumnName, f(colDB.ColumnName).ToString.Replace("'", ""))
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    Dim cmd As New SqlCommand

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", @" & k.Key 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = @" & k.Key 'para el update
                        cmd.Parameters.Add(New SqlParameter("@" & k.Key, k.Value))
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD_v2(strSQL, cmd, 0, outSms)

                    If id = -1 Then Return -1
                Next
            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try

            Return 0
        End Function

        Private Function GrabarOdontograma(tblOdont As DataTable, tblArchDig As DataTable, n_int_id As Integer, n_id_ingreso_inpe As Integer, n_ingreso_Id As Integer, ByRef outSms As String) As Boolean
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarOdontograma"
            If tblOdont Is Nothing Then Return 0

            For Each f As DataRow In tblOdont.Rows
                Dim id As Integer = -1
                Dim regNuevo As Boolean = True
                Dim ent As New Entity.Registro.Odontograma.InternoOdontograma
                Try
                    With ent
                        .InternoId = n_int_id
                        .Observaciones = f.Item("c_int_odn_obs") 'Me.Observaciones
                        .Especificaciones = f.Item("c_int_odn_esp") 'Me.Especificaciones
                        .OclusionTipoId = f.Item("fk_ocl_tip_id") 'Me.TipoOclusion
                        .DienteTipoId = f.Item("fk_die_tip_id") ' Me.TipoDiente
                        .TamanioDienteId = f.Item("fk_tam_die_id") ' Me.TamanioDiente
                        .TamanioDentoMaxilarId = f.Item("fk_tam_dmx_id") ' Me.TamanioDentomaxilar
                        .RugaPalatinaId = f.Item("fk_rug_pal_id") ' Me.RugaPalatina
                        .ArcoDentarioSupId = f.Item("fk_arc_dnt_tip_sup_id") ' Me.ArcoDentarioSup
                        .ArcoDentarioInfId = f.Item("fk_arc_dnt_tip_inf_id") 'Me.ArcoDentarioInf
                        .RegionId = Me.RegionId
                        .PenalId = Me.PenalId
                        .SedeRowId = f.Item("_sed_rowid")
                        '.IngresoId = n_ingreso_Id
                        .IngresoInpeId = n_id_ingreso_inpe
                    End With

                    Dim strSQL As String = ""
                    Dim cmd As New SqlCommand
                    Dim entTmp As New Entity.Registro.Odontograma.InternoOdontograma
                    Dim entTmpCol As New Entity.EntityCol(Of Entity.Registro.Odontograma.InternoOdontograma)
                    entTmp.SedeRowId = f.Item("_sed_rowid")
                    entTmpCol = (New Bussines.Registro.Odontograma.InternoOdontograma).Listar(entTmp)

                    If entTmpCol.Count > 0 Then
                        ent.Codigo = entTmpCol.Entity(0).Codigo
                        regNuevo = False
                        cmd.Parameters.Add(New SqlParameter("@pk_int_odn_id", ent.Codigo))
                        strSQL = "update int_mov_interno_odontograma set
	                                fk_int_id = @fk_int_id,
	                                fk_int_ing_id = @fk_int_ing_id,
	                                fk_ing_inp_id = @fk_ing_inp_id,
	                                c_int_odn_obs = @c_int_odn_obs,
	                                c_int_odn_esp = @c_int_odn_esp,
	                                fk_arc_dnt_tip_sup_id = @fk_arc_dnt_tip_sup_id,
	                                fk_arc_dnt_tip_inf_id = @fk_arc_dnt_tip_inf_id,
	                                fk_tam_dmx_id = @fk_tam_dmx_id,
	                                fk_tam_die_id = @fk_tam_die_id,
	                                fk_die_tip_id = @fk_die_tip_id,
	                                fk_ocl_tip_id = @fk_ocl_tip_id,
	                                fk_rug_pal_id = @fk_rug_pal_id,
	                                _usu_cre = @_usu_cre,
	                                _fec_cre = @_fec_cre,
	                                _usu_mod = @_usu_mod,
	                                _fec_mod = @_fec_mod,
	                                _usu_eli = @_usu_eli,
	                                _fec_eli = @_fec_eli,
	                                _flg_eli = @_flg_eli,
	                                _arc_nom = @_arc_nom,
	                                _RegId = @_RegId,
	                                _PenId = @_PenId,
	                                _sed_rowid = @_sed_rowid,
	                                _flg_trf = @_flg_trf,
	                                _sed_flg_trf = @_sed_flg_trf
                                where 
	                                pk_int_odn_id = @pk_int_odn_id;

                                ; select " & ent.Codigo
                    Else
                        regNuevo = True
                        strSQL = "insert into int_mov_interno_odontograma(
	                                fk_int_id,
	                                fk_int_ing_id,
	                                fk_ing_inp_id,
	                                c_int_odn_obs,
	                                c_int_odn_esp,
	                                fk_arc_dnt_tip_sup_id,
	                                fk_arc_dnt_tip_inf_id,
	                                fk_tam_dmx_id,
	                                fk_tam_die_id,
	                                fk_die_tip_id,
	                                fk_ocl_tip_id,
	                                fk_rug_pal_id,
	                                _usu_cre,
	                                _fec_cre,
	                                _usu_mod,
	                                _fec_mod,
	                                _usu_eli,
	                                _fec_eli,
	                                _flg_eli,
	                                _arc_nom,
	                                _RegId,
	                                _PenId,
	                                _sed_rowid,
	                                _flg_trf,
	                                _sed_flg_trf
                                )
                                values
                                (
	                                @fk_int_id,
	                                @fk_int_ing_id,
	                                @fk_ing_inp_id,
	                                @c_int_odn_obs,
	                                @c_int_odn_esp,
	                                @fk_arc_dnt_tip_sup_id,
	                                @fk_arc_dnt_tip_inf_id,
	                                @fk_tam_dmx_id,
	                                @fk_tam_die_id,
	                                @fk_die_tip_id,
	                                @fk_ocl_tip_id,
	                                @fk_rug_pal_id,
	                                @_usu_cre,
	                                @_fec_cre,
	                                @_usu_mod,
	                                @_fec_mod,
	                                @_usu_eli,
	                                @_fec_eli,
	                                @_flg_eli,
	                                @_arc_nom,
	                                @_RegId,
	                                @_PenId,
	                                @_sed_rowid,
	                                @_flg_trf,
	                                @_sed_flg_trf
                                )
                                ; select scope_identity()"
                    End If

                    cmd.Parameters.Add(New SqlParameter("@fk_int_id", ent.InternoId))
                    cmd.Parameters.Add(New SqlParameter("@fk_int_ing_id", n_ingreso_Id))
                    cmd.Parameters.Add(New SqlParameter("@fk_ing_inp_id", n_id_ingreso_inpe))
                    cmd.Parameters.Add(New SqlParameter("@c_int_odn_obs", ent.Observaciones))
                    cmd.Parameters.Add(New SqlParameter("@c_int_odn_esp", ent.Especificaciones))
                    cmd.Parameters.Add(New SqlParameter("@fk_arc_dnt_tip_sup_id", ent.ArcoDentarioSupId))
                    cmd.Parameters.Add(New SqlParameter("@fk_arc_dnt_tip_inf_id", ent.ArcoDentarioInfId))
                    cmd.Parameters.Add(New SqlParameter("@fk_tam_dmx_id", ent.TamanioDentoMaxilarId))
                    cmd.Parameters.Add(New SqlParameter("@fk_tam_die_id", ent.TamanioDienteId))
                    cmd.Parameters.Add(New SqlParameter("@fk_die_tip_id", ent.DienteTipoId))
                    cmd.Parameters.Add(New SqlParameter("@fk_ocl_tip_id", ent.OclusionTipoId))
                    cmd.Parameters.Add(New SqlParameter("@fk_rug_pal_id", ent.RugaPalatinaId))
                    cmd.Parameters.Add(New SqlParameter("@_usu_cre", f.Item("_usu_cre")))
                    cmd.Parameters.Add(New SqlParameter("@_fec_cre", f.Item("_fec_cre")))
                    cmd.Parameters.Add(New SqlParameter("@_usu_mod", f.Item("_usu_mod")))
                    cmd.Parameters.Add(New SqlParameter("@_fec_mod", f.Item("_fec_mod")))
                    cmd.Parameters.Add(New SqlParameter("@_usu_eli", f.Item("_usu_eli")))
                    cmd.Parameters.Add(New SqlParameter("@_fec_eli", f.Item("_fec_eli")))
                    cmd.Parameters.Add(New SqlParameter("@_flg_eli", f.Item("_flg_eli")))
                    cmd.Parameters.Add(New SqlParameter("@_arc_nom", ""))
                    cmd.Parameters.Add(New SqlParameter("@_RegId", Me.RegionId))
                    cmd.Parameters.Add(New SqlParameter("@_PenId", Me.PenalId))
                    cmd.Parameters.Add(New SqlParameter("@_sed_rowid", f.Item("_sed_rowid")))
                    cmd.Parameters.Add(New SqlParameter("@_flg_trf", 1))
                    cmd.Parameters.Add(New SqlParameter("@_sed_flg_trf", 0))

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD_v2(strSQL, cmd, 0, outSms)

                    ' Type.LogSIP.getLog.Debug(strLog, "grabando Grabar(...) Odontograma id=" & id)
                    If id = -1 Then Return id
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblOdont.AcceptChanges()
                Catch ex As Exception
                    outSms = "Error: " & ex.ToString & ", no se guardó el registro de la tabla remoto int_mov_interno_odontograma, Id remoto pk_int_odn_id=" _
                                                                           & f.Item("pk_int_odn_id") & ", tome nota y comunique a soporte para su asistencia y su ingreso manual."
                    Return -1
                End Try
            Next

            For Each f As DataRow In tblArchDig.Rows
                Dim id As Integer = -1
                Dim entAD As New Entity.Globall.ArchivoDigitalizado
                Try
                    With entAD
                        .ArchivoDigitalByte = f.Item("b_arch_dig_byte")
                        .Extension = "rar"
                        If f.Item("fk_reg_tbl_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblOdont.Select("pk_int_odn_id=" & f.Item("fk_reg_tbl_id"))
                            .IdRegistroForaneo = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                        End If
                        .Ip = Legolas.Components.PC.GetIP
                        .Mac = Legolas.Components.PC.GetMAC
                        .NombrePc = Legolas.Components.PC.PCNombre
                        .RegionId = Me.RegionId
                        .PenalId = Me.PenalId
                        .PesoByte = f.Item("n_arc_dig_pes")
                        .TipoArchivoDigital = 1 'odontograma
                        .SedeRowId = f.Item("_sed_rowid")
                    End With

                    Dim strSQL As String = ""
                    Dim cmd As New SqlCommand
                    Dim entTmp As New Entity.Globall.ArchivoDigitalizado
                    Dim entTmpCol As New Entity.Globall.ArchivoDigitalizadoCol
                    entTmp.SedeRowId = f.Item("_sed_rowid")
                    entTmp.TipoArchivoDigital = 1 'odontograma
                    entTmpCol = (New Bussines.Globall.ArchivoDigitalizado).Listar(entTmp)

                    If entTmpCol.Count > 0 Then
                        entAD.Codigo = entTmpCol.Archivodigital(0).Codigo
                        cmd.Parameters.Add(New SqlParameter("@pk_arc_dig_id", entAD.Codigo))
                        strSQL = "update glo_mov_arch_digitalizado set
	                                n_arc_dig_tip_id =@n_arc_dig_tip_id ,
	                                fk_reg_tbl_id	   =@fk_reg_tbl_id	   ,
	                                n_arc_dig_anio   =@n_arc_dig_anio   ,
	                                n_arc_dig_mes	   =@n_arc_dig_mes	   ,
	                                c_arc_dig_pc_mac =@c_arc_dig_pc_mac ,
	                                c_arc_dig_pc	   =@c_arc_dig_pc	   ,
	                                c_arc_dig_ip	   =@c_arc_dig_ip	   ,
	                                b_arch_dig_byte  =@b_arch_dig_byte  ,
	                                c_arc_dig_nom_fis=@c_arc_dig_nom_fis,
	                                c_arc_dig_ext	   =@c_arc_dig_ext	   ,
	                                n_arc_dig_pes	   =@n_arc_dig_pes	   ,
	                                _usu_cre		   =@_usu_cre		   ,
	                                _fec_cre		   =@_fec_cre		   ,
	                                _usu_mod		   =@_usu_mod		   ,
	                                _fec_mod		   =@_fec_mod		   ,
	                                _usu_eli		   =@_usu_eli		   ,
	                                _fec_eli		   =@_fec_eli		   ,
	                                _flg_eli		   =@_flg_eli		   ,
	                                _arc_nom		   =@_arc_nom		   ,
	                                _regid		   =@_regid		   ,
	                                _penid		   =@_penid		   ,
	                                _rowid		   =@_rowid		   ,
	                                _sed_rowid	   =@_sed_rowid	   ,
	                                _flg_trf		   =@_flg_trf		   ,
	                                _sed_flg_trf=@_sed_flg_trf
                                where pk_arc_dig_id=@pk_arc_dig_id; select " & entAD.Codigo
                    Else
                        strSQL = "insert into glo_mov_arch_digitalizado(
	                                n_arc_dig_tip_id,
	                                fk_reg_tbl_id,
	                                n_arc_dig_anio,
	                                n_arc_dig_mes,
	                                c_arc_dig_pc_mac,
	                                c_arc_dig_pc,
	                                c_arc_dig_ip,
	                                b_arch_dig_byte,
	                                c_arc_dig_nom_fis,
	                                c_arc_dig_ext,
	                                n_arc_dig_pes,
	                                _usu_cre,
	                                _fec_cre,
	                                _usu_mod,
	                                _fec_mod,
	                                _usu_eli,
	                                _fec_eli,
	                                _flg_eli,
	                                _arc_nom,
	                                _regid,
	                                _penid,
	                                _rowid,
	                                _sed_rowid,
	                                _flg_trf,
	                                _sed_flg_trf)
                                values(
	                                @n_arc_dig_tip_id,
	                                @fk_reg_tbl_id,
	                                @n_arc_dig_anio,
	                                @n_arc_dig_mes,
	                                @c_arc_dig_pc_mac,
	                                @c_arc_dig_pc,
	                                @c_arc_dig_ip,
	                                @b_arch_dig_byte,
	                                @c_arc_dig_nom_fis,
	                                @c_arc_dig_ext,
	                                @n_arc_dig_pes,
	                                @_usu_cre,
	                                @_fec_cre,
	                                @_usu_mod,
	                                @_fec_mod,
	                                @_usu_eli,
	                                @_fec_eli,
	                                @_flg_eli,
	                                @_arc_nom,
	                                @_regid,
	                                @_penid,
	                                @_rowid,
	                                @_sed_rowid,
	                                @_flg_trf,
	                                @_sed_flg_trf
                                ); select scope_identity()"
                    End If

                    cmd.Parameters.Add(New SqlParameter("@n_arc_dig_tip_id", 1))
                    cmd.Parameters.Add(New SqlParameter("@fk_reg_tbl_id", entAD.IdRegistroForaneo))
                    cmd.Parameters.Add(New SqlParameter("@n_arc_dig_anio", f.Item("n_arc_dig_anio")))
                    cmd.Parameters.Add(New SqlParameter("@n_arc_dig_mes", f.Item("n_arc_dig_mes")))
                    cmd.Parameters.Add(New SqlParameter("@c_arc_dig_pc_mac", Legolas.Components.PC.GetMAC))
                    cmd.Parameters.Add(New SqlParameter("@c_arc_dig_pc", Legolas.Components.PC.PCNombre))
                    cmd.Parameters.Add(New SqlParameter("@c_arc_dig_ip", Legolas.Components.PC.GetIP))
                    cmd.Parameters.Add(New SqlParameter("@b_arch_dig_byte", If(entAD.ArchivoDigitalByte Is Nothing, System.Data.SqlTypes.SqlBinary.Null, entAD.ArchivoDigitalByte)))
                    cmd.Parameters.Add(New SqlParameter("@c_arc_dig_nom_fis", f.Item("c_arc_dig_nom_fis")))
                    cmd.Parameters.Add(New SqlParameter("@c_arc_dig_ext", "rar"))
                    cmd.Parameters.Add(New SqlParameter("@n_arc_dig_pes", f.Item("n_arc_dig_pes")))
                    cmd.Parameters.Add(New SqlParameter("@_usu_cre", f.Item("_usu_cre")))
                    cmd.Parameters.Add(New SqlParameter("@_fec_cre", f.Item("_fec_cre")))
                    cmd.Parameters.Add(New SqlParameter("@_usu_mod", f.Item("_usu_mod")))
                    cmd.Parameters.Add(New SqlParameter("@_fec_mod", f.Item("_fec_mod")))
                    cmd.Parameters.Add(New SqlParameter("@_usu_eli", f.Item("_usu_eli")))
                    cmd.Parameters.Add(New SqlParameter("@_fec_eli", f.Item("_fec_eli")))
                    cmd.Parameters.Add(New SqlParameter("@_flg_eli", f.Item("_flg_eli")))
                    cmd.Parameters.Add(New SqlParameter("@_arc_nom", ""))
                    cmd.Parameters.Add(New SqlParameter("@_regid", Me.RegionId))
                    cmd.Parameters.Add(New SqlParameter("@_penid", Me.PenalId))
                    cmd.Parameters.Add(New SqlParameter("@_rowid", -1))
                    cmd.Parameters.Add(New SqlParameter("@_sed_rowid", entAD.SedeRowId))
                    cmd.Parameters.Add(New SqlParameter("@_flg_trf", 1))
                    cmd.Parameters.Add(New SqlParameter("@_sed_flg_trf", 0))

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD_v2(strSQL, cmd, 0, outSms)
                Catch ex As Exception
                    outSms = "Error: " & ex.ToString & ", no se guardó el registro de la tabla remoto glo_mov_arch_digitalizado, Id sede pk_arc_dig_id=" _
                                                                           & f.Item("pk_arc_dig_id") & ", tome nota y contactese a soporte para su asistencia."
                    Return -1
                End Try
            Next

            Return 0
        End Function

        Private Function GrabarOdontogramaNuevo(XMLint_mov_interno_odontograma_nts As String, XMLint_mov_interno_odontograma_nts_det As String, fk_int_id As String, fk_ing_inp_id As String, fk_int_ing_id As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarInternoHuella"
            Dim nombreProcedimiento As String = "pa_int_mov_odontograma_nts"

            ' Crear el comando
            Dim cmd As New SqlCommand()
            cmd.CommandText = nombreProcedimiento
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar los parámetros necesarios
            cmd.Parameters.AddWithValue("@xml_odontograma", XMLint_mov_interno_odontograma_nts)
            cmd.Parameters.AddWithValue("@xml_odontograma_det", XMLint_mov_interno_odontograma_nts_det)
            cmd.Parameters.AddWithValue("@fk_int_id", fk_int_id)
            cmd.Parameters.AddWithValue("@fk_ing_inp_id", fk_ing_inp_id)
            cmd.Parameters.AddWithValue("@fk_int_ing_id", fk_int_ing_id)

            ' Agregar el parámetro OUTPUT para el mensaje de salida
            Dim outputParam As New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300)
            outputParam.Direction = ParameterDirection.Output
            cmd.Parameters.Add(outputParam)

            ' Variables para manejar el estado del error y los mensajes de salida
            Dim estadoError As Integer
            Dim outSMS As String = String.Empty
            Dim resultado As Integer

            Try
                ' Llamar al método para ejecutar el procedimiento almacenado
                resultado = Bussines.Globall.UtilAccesoBD.EjecutarProcedimientoAlmacenado(nombreProcedimiento, cmd, estadoError, outSMS)

                ' Obtener el mensaje de salida del parámetro OUTPUT
                outSMS = cmd.Parameters("@str_out_sms").Value.ToString()

                ' Verificar el resultado y manejar los errores si es necesario
                If estadoError = -1 Then
                    ' Manejar el error, por ejemplo, mostrar el mensaje de error
                    Return -1
                End If
            Catch ex As Exception
                outSMS = "Error: " & ex.Message.ToString()
                Return -1
            End Try

            ' Opcional: mostrar el mensaje de salida si no hay error
            'If Not String.IsNullOrEmpty(outSMS) Then
            '    MessageBox.Show("Mensaje de salida: " & outSMS)
            'End If

            Return resultado
        End Function
        Private Function GrabarReniecNomAsoc(tblRnc As DataTable, tblRncNomAsoc As DataTable, tblNomAsoc As DataTable, n_int_id As Integer, n_inpe_ing_id As Integer, n_ingId As Integer, ByRef outSms As String) As Integer

            If tblRnc Is Nothing OrElse tblRnc.Rows.Count = 0 Then Return 0

            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim c_nomColPK As String = tblRnc.Rows(0).Item("key_name")
            Dim tblTablaBD As DataTable = Nothing
            Dim newRow As Dictionary(Of String, Object)
            '---------------- tabla InternoReniecNomAsoc------------------------------------
            If tblRncNomAsoc Is Nothing OrElse tblRncNomAsoc.Rows.Count = 0 Then Return 0

            c_nomColPK = tblRncNomAsoc.Rows(0).Item("key_name")

            tblTablaBD = Nothing
            c_nombTabla = tblRncNomAsoc.Rows(0).Item("tabla")
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

            Try
                For Each f As DataRow In tblRncNomAsoc.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblRncNomAsoc.Columns.Contains(colDB.ColumnName) = False Then Continue For

                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then newRow.Add(colDB.ColumnName, n_inpe_ing_id) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "n_fk_int_rnc_id" And f.Item("n_fk_int_rnc_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblRnc.Select("int_rnc_id=" & f.Item("n_fk_int_rnc_id"))
                            f.Item("n_fk_int_rnc_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "n_fk_int_aso_id" And f.Item("n_fk_int_aso_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblNomAsoc.Select("int_aso_id=" & f.Item("n_fk_int_aso_id"))
                            f.Item("n_fk_int_aso_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & f(colDB.ColumnName) & """)', 'varbinary(max)')")
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(strSQL, 0, "")
                    If id = -1 Then Return -1
                Next
            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try
            Return 0
        End Function

        Private Function ProcesaTablaOtros(tbl As DataTable, tblIngInpe As DataTable, n_int_id As Integer, n_inp_ing_id As Integer, n_ingId As Integer, ByRef outSms As String)

            Dim ListSqlP As Dictionary(Of String, Object)

            Dim strLog As String = "Business/RecepcionInternoTraslado/ProcesaTablaOtros"
            If tbl Is Nothing OrElse tbl.Rows.Count = 0 Then Return 0

            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim ultIngInpeSedeId As Integer = -1

            ultIngInpeSedeId = tblIngInpe.Rows(0).Item("id_ult_ing_inp")

            Try
                Dim c_nomColPK As String = tbl.Rows(0).Item("key_name")

                Dim tblTablaBD As DataTable = Nothing
                c_nombTabla = tbl.Rows(0).Item("tabla")
                tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

                Dim newRow As Dictionary(Of String, Object)

                For Each f As DataRow In tbl.Rows
                    ListSqlP = New Dictionary(Of String, Object)

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tbl.Columns.Contains(colDB.ColumnName) = False Then Continue For
                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For

                        'si corresponde al ultimo ingresInpe actualizar penId caso contrario no actualizar, debe quedarse con sus mismo penId origen
                        If f.Item("fk_ing_inp_id") = ultIngInpeSedeId Then
                            If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then newRow.Add(colDB.ColumnName, n_inp_ing_id) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                            If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For
                        Else
                            If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then
                                If f.Item("fk_ing_inp_id") > 0 Then
                                    Dim filas As DataRow()
                                    filas = tblIngInpe.Select("pk_ing_inp_id=" & f.Item("fk_ing_inp_id"))
                                    f.Item("fk_ing_inp_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                                    f.AcceptChanges()

                                    'Dim idIngInpId As Integer = -1
                                    'idIngInpId = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", f.Item("fk_ing_inp_id"), 0, outSms)
                                    'f.Item("fk_ing_inp_id") = idIngInpId
                                    'f.AcceptChanges()
                                End If

                                newRow.Add(colDB.ColumnName, f.Item("fk_ing_inp_id"))
                                Continue For
                            End If
                            If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, -1) : Continue For 'artificio ingresoId -1
                            If colDB.ColumnName.ToLower.Trim = "_flg_trf" Then newRow.Add(colDB.ColumnName, 0) : Continue For 'no debe transferir
                            If colDB.ColumnName.ToLower.Trim = "_arc_nom" Then newRow.Add(colDB.ColumnName, "NO_TRANSFER_REG") : Continue For
                        End If

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                newRow.Add(colDB.ColumnName, f(colDB.ColumnName))
                        End Select
                    Next

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        ListSqlP.Add(k.Key, k.Value)
                    Next

                    Dim n_idTablaLocal As Integer = -1

                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        id = ExecuteInsert(ListSqlP, c_nombTabla)
                    Else
                        id = ExecuteUpdate(ListSqlP, c_nombTabla, c_nomColPK, n_idTablaLocal)
                    End If

                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tbl.AcceptChanges()
                Next
            Catch ex As Exception
                Type.LogSIP.getLog.Debug(strLog, "Excepcion: " & ex.ToString)
                id = -1
            End Try

            'If id < 0 Then
            '    Dim entTmp As New Entity.Registro.Ingreso
            '    entTmp.Codigo = n_ingId
            '    entTmp.InternoID = n_int_id
            '    id = (New Bussines.Registro.Ingreso).Eliminar_LM(entTmp)
            '    id = -1
            'End If

            Return id
        End Function

        Private Function ExecuteInsert(lstSqlPar As Dictionary(Of String, Object), nomTabla As String) As Integer
            Dim cmd As New SqlCommand
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim id As Integer = -1

            Dim strColum As String = ""
            Dim strValor As String = ""

            For Each k As KeyValuePair(Of String, Object) In lstSqlPar
                strColum = strColum & ", " & k.Key 'concatena todas las columnas de la tabla: col01, col02, col03,...,col(n)
                strValor = strValor & ", @" & k.Key 'para el insert
                cmd.Parameters.Add(New SqlParameter("@" & k.Key, k.Value))
            Next

            strColum = strColum.Substring(1, strColum.Length - 1)
            strValor = strValor.Substring(1, strValor.Length - 1)

            Try
                cmd.CommandText = "INSERT INTO " & nomTabla & "(" & strColum & ") VALUES (" & strValor & ");select scope_identity();"
                cmd.Connection = sqlCon
                cmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                id = cmd.ExecuteScalar()
            Catch ex As Exception
                id = -1
            Finally
                sqlCon.Close()
                cmd.Dispose()
            End Try

            Return id

        End Function

        Private Function ExecuteUpdate(lstSqlPar As Dictionary(Of String, Object), nomTabla As String, nomPkTabla As String, valorPkTabla As Integer) As Integer
            Dim cmd As New SqlCommand
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim id As Integer = -1

            Dim strUpdate As String = ""

            For Each k As KeyValuePair(Of String, Object) In lstSqlPar
                strUpdate = strUpdate & ", " & k.Key & " = @" & k.Key
                cmd.Parameters.Add(New SqlParameter("@" & k.Key, k.Value))
            Next

            strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

            cmd.Parameters.Add(New SqlParameter("@" & nomPkTabla, valorPkTabla))
            Try
                cmd.CommandText = "UPDATE " & nomTabla & " SET " & strUpdate & " WHERE " & nomPkTabla & " = @" & nomPkTabla & "; select " & valorPkTabla & ";"
                cmd.Connection = sqlCon
                cmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                id = cmd.ExecuteScalar()
            Catch ex As Exception
                id = -1
            Finally
                sqlCon.Close()
                cmd.Dispose()
            End Try

            Return id

        End Function

#End Region

#Region "Validaciones"

#End Region

    End Class
End Namespace
