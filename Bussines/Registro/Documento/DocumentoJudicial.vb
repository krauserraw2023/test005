Imports System.Data
Imports System.Data.SqlClient
Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.SubTipoDocJudicial

Namespace Registro
    Public Class DocumentoJudicial
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private bssDel As Bussines.Registro.Delito = Nothing
        Private bssAgr As Bussines.Registro.InternoAgraviado = Nothing
        Private BssPad As Bussines.Registro.InternoExpedientePadre = Nothing
        Private BssExp As Bussines.Registro.Expediente = Nothing
        Private BssDoc As Bussines.Registro.DocumentoJudicial = Nothing

        'Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#Region "Validar"
        Private Function ValidarEntrada_LM(ObjEnt As Entity.Registro.DocumentoJudicial)
            Dim Mensaje As String = ""
            If ObjEnt.InternoId < 1 Then
                Mensaje = "El paramentro del interno no ha sido enviado"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(Mensaje)
                Return False
            End If
            If ObjEnt._RegionID < 1 Then
                Mensaje = "El paramentro de la region no ha sido enviado"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(Mensaje)
                Return False
            End If

            If ObjEnt.IngresoInpeId < -1 Then
                Mensaje = "El paramentro IngresoInpeId no ha sido enviado"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(Mensaje)
                Return False
            End If
            Return True
        End Function

        Private Function ValidarEntrada(ObjEnt As Entity.Registro.DocumentoJudicial)

            Dim Mensaje As String = ""

            If ObjEnt.InternoId < 1 Then
                Mensaje = "El paramentro del interno no ha sido enviado"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(Mensaje)
                Return False
            End If

            If ObjEnt._RegionID < 1 Then
                Mensaje = "El paramentro de la region no ha sido enviado"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(Mensaje)
                Return False
            End If

            If Not (ObjEnt._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then
                If ObjEnt._PenalID < 1 Then
                    Mensaje = "El paramentro del penal no ha sido enviado"
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(Mensaje)
                    Return False
                End If
            End If

            Return True

        End Function

        Private Function validarEstadoDistritoJudicial(objEnt As Entity.Registro.DocumentoJudicial)

            Dim value As Boolean = True
            If objEnt.DistritoJudicial > 0 Then

                Dim mensajeOut As String = ""
                'Dim pasa As Boolean = True
                Dim objBssDistritoJudicial As New Bussines.Mantenimiento.AutoridadJudicial
                value = objBssDistritoJudicial.validarEstadoDistiroJudicial(objEnt.DistritoJudicial, mensajeOut)

                If value = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(mensajeOut)
                End If

            End If

            Return value
        End Function
#End Region
#Region "Funciones"
        Public Function CuentaDocumentoTipo(EnDoctReg As Entity.Registro.DocumentoJudicial) As Integer
            'jeu 04112015 actualizado
            Return Data.Registro.DocumentoJudicial.ListarOutput("lst", "lst_num_de_resol", EnDoctReg)
        End Function

        Public Function CuentaDocumentoTipo_LM(EnDoctReg As Entity.Registro.DocumentoJudicial) As Integer
            'jeu 04112015 actualizado
            Return Data.Registro.DocumentoJudicial.ListarOutput_LM("lst", "lst_num_de_resol_LM", EnDoctReg)
        End Function

        Public Function Cantidad_DocJudicial_hist(EnDoctReg As Entity.Registro.DocumentoJudicial) As Integer
            Return Data.Registro.DocumentoJudicial.ListarOutput_LM("lst", "lst_num_de_resol_hist", EnDoctReg)
        End Function
        Public Function CantidadDocumentosExpedientes_LM(int_id As Integer) As Integer
            Dim EnDoctReg As New Entity.Registro.DocumentoJudicial
            EnDoctReg.InternoId = int_id
            Return Data.Registro.DocumentoJudicial.ListarOutput_LM("lst", "lst_cant_doc_jud_LM", EnDoctReg)
        End Function
        Public Function CantidadDocumentosExpedientes(int_id As Integer, _penalId As Integer) As Integer
            Dim EnDoctReg As New Entity.Registro.DocumentoJudicial
            EnDoctReg.InternoId = int_id
            EnDoctReg._PenalID = _penalId
            Return Data.Registro.DocumentoJudicial.ListarOutput("lst", "lst_cant_doc_jud", EnDoctReg)
        End Function
#End Region
#Region "Listar"
        Public Function Listar(objDocJud As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicial
            '03112015 jeu actualiza
            '22-05-2014 hnrb

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar2(sqlCon, "lst", "lst_mant", objDocJud)
            objEnt = New Entity.Registro.DocumentoJudicial
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            '.DocumentoNumeroTraslado = sqlDr("doc_jud_num_aux").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .FechaInscripcion = sqlDr("sen_fec_ins").ToString
                            .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                            .DistritoJudicial = sqlDr("dis_jud_id").ToString
                            .SalaJuzgado = sqlDr("sal_jud_id").ToString
                            .DistritoJudNombre = sqlDr("doc_jud_nom").ToString
                            .SalaJudNombre = sqlDr("doc_jud_sal_nom").ToString
                            .JuezNombre = sqlDr("doc_jud_jue").ToString
                            .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                            .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                            .Observacion = sqlDr("doc_jud_obs").ToString
                            ._PenalID = sqlDr("_penid").ToString
                            ._RegionID = sqlDr("_regid").ToString

                            '22-05-2014
                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .RegionOrigenId = sqlDr("reg_ori_id").ToString
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .RegionDestinoId = sqlDr("reg_des_id2").ToString
                            .PenalDestinoid = sqlDr("pen_des_id").ToString
                            .PenalOtroOrigenNom = sqlDr("pen_ori_otr").ToString
                            .PenalDestinoOtroNom = sqlDr("pen_des_otr").ToString
                            .FechaMovimiento = sqlDr("doc_fec_mov").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .MovimientoMotivoId = sqlDr("mov_mot_id").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString

                            .ProlonDetencionFechIni = sqlDr("prol_det_ini_fec").ToString
                            .ProlonDetencionFechFin = sqlDr("prol_det_fin_fec").ToString
                            .ProlonDetencionTipoUnidad = sqlDr("prol_det_tip_und").ToString
                            .ProlonDetencionValor = sqlDr("prol_det_cant").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString

                            .DocumentoTipoNombre = UCase(sqlDr("doc_tip_nom").ToString)
                            .SentenciaFecha = sqlDr("sent_fec").ToString
                            .SentenciaConsentida = sqlDr("sent_consentida").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaTotalAnios = sqlDr("sent_tot_anio").ToString
                            .SentenciaTotalMeses = sqlDr("sent_tot_meses").ToString
                            .SentenciaTotalDias = sqlDr("sent_tot_dias").ToString
                            '.EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
                            '.Establecimientomental = sqlDr("fk_est_men_des").ToString
                            .Audit_FechaCreacion = sqlDr("_fec_cre").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function

        Public Function Listar_v2(EntDoc As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicial
            '03112015 jeu actualiza
            '22-05-2014 hnrb
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar2(sqlCon, "lst", "lst_mant2", EntDoc)
            objEnt = New Entity.Registro.DocumentoJudicial
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        With objEnt
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .DocumentoNumeroTraslado = sqlDr("doc_jud_num_aux").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            .DistritoJudicial = sqlDr("dis_jud_id").ToString
                            .SalaJuzgado = sqlDr("sal_jud_id").ToString
                            .JuezNombre = sqlDr("doc_jud_jue").ToString
                            .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                            .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                            .Observacion = sqlDr("doc_jud_obs").ToString
                            ._PenalID = sqlDr("_penid").ToString
                            ._RegionID = sqlDr("_regid").ToString

                            '22-05-2014
                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .RegionOrigenId = sqlDr("reg_ori_id").ToString
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .RegionDestinoId = sqlDr("reg_des_id").ToString
                            .PenalDestinoid = sqlDr("pen_des_id").ToString
                            .PenalOtroOrigenNom = sqlDr("pen_ori_otr").ToString
                            .PenalDestinoOtroNom = sqlDr("pen_des_otr").ToString

                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .MovimientoMotivoId = sqlDr("mov_mot_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .SituacionJuridicaId = sqlDr("sit_jur_id").ToString
                            If .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Then
                                .SituacionJuridicaId = sqlDr("sit_jur_id").ToString
                                .Flagrancia = sqlDr("int_exp_flag").ToString
                            End If
                            .ProlonDetencionFechIni = sqlDr("prol_det_ini_fec").ToString
                            .ProlonDetencionFechFin = sqlDr("prol_det_fin_fec").ToString
                            .ProlonDetencionTipoUnidad = sqlDr("prol_det_tip_und").ToString
                            .ProlonDetencionValor = sqlDr("prol_det_cant").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString
                            .DocumentoTipoNombre = UCase(sqlDr("doc_tip_nom").ToString)
                            .SentenciaFecha = sqlDr("sent_fec").ToString
                            .SentenciaConsentida = sqlDr("sent_consentida").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaTotalAnios = sqlDr("sent_tot_anio").ToString
                            .SentenciaTotalMeses = sqlDr("sent_tot_meses").ToString
                            .SentenciaTotalDias = sqlDr("sent_tot_dias").ToString
                            .DocumentoJudicialPenalOrigen = sqlDr("c_reg_doc_jud_doc").ToString
                            .FechaInternamientoPenalOrigen = sqlDr("f_reg_doc_jud_fec_int").ToString
                            .FechaIngresoPenalOrigen = sqlDr("f_reg_doc_jud_fec_ing").ToString
                            .ObservacionPenalOrigen = sqlDr("c_reg_doc_jud_obs").ToString
                            '-----------------------
                            If .TipoAutoridadJudicial = 1 Then
                                .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                                .DistritoJudNombre = sqlDr("doc_jud_nom").ToString
                                .SalaJudNombre = sqlDr("doc_jud_sal_nom").ToString
                                .JuezNombre = sqlDr("doc_jud_jue").ToString
                                .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            Else
                                If .TipoAutoridadJudicial = -1 Then
                                    If .DistritoJudicial > 0 Then
                                        .TipoAutoridadJudicial = 1
                                        .DistritoJudNombre = sqlDr("doc_jud_nom").ToString
                                        .SalaJudNombre = sqlDr("doc_jud_sal_nom").ToString
                                        .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                                    Else
                                        .TipoAutoridadJudicial = 2
                                        .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString

                                        .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                                        .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                                        .SalaJudNombre = .AutoridadOtroNombre & " / " & .AutoridadOtroCargo
                                        .JuezNombre = ""
                                        .SecretarioNombre = ""
                                    End If
                                Else
                                    .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                                    .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString

                                    .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                                    .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                                    .SalaJudNombre = .AutoridadOtroNombre & " / " & .AutoridadOtroCargo

                                    .JuezNombre = ""
                                    .SecretarioNombre = ""
                                End If
                            End If
                            .QuedaId = sqlDr("fk_doc_jud_id_que").ToString
                            ._Historico = sqlDr("int_ing_hist").ToString
                            .EstadoEjecucionId = sqlDr("est_eje_trs_id").ToString
                            .MovimientoId = sqlDr("int_mov_id").ToString
                            .Audit_FechaCreacion = sqlDr("_fec_cre").ToString

                            .FechaMovimiento = sqlDr("doc_fec_mov").ToString
                            .FechaInscripcion = sqlDr("sen_fec_ins").ToString
                            .fechaMovimientoEjecucion = sqlDr("fec_mov").ToString 'campo calculado de la tablla movimiento, fecha movimiento.

                            .Observacion_Queda = sqlDr("obs_queda").ToString
                            .Proceso_Pendiente_Queda = sqlDr("flg_proc_pend").ToString
                            .mov_est_id = sqlDr("mov_est_id").ToString
                            .FechaResolucion = sqlDr("sent_fresol").ToString
                            .FechaRecepcionResolucion = sqlDr("sent_frecep").ToString
                            ._FechaHistorico = sqlDr("n_fec_config_doc").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function

        Public Function Listar_v3(objDocJud As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicial
            '03112015 jeu actualiza
            '22-05-2014 hnrb

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar2(sqlCon, "lst", "lst_mant_3", objDocJud)
            objEnt = New Entity.Registro.DocumentoJudicial
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .FechaInscripcion = sqlDr("sen_fec_ins").ToString
                            .observacionEstadoEjecucion = sqlDr("est_eje_obs").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function

        Public Function Listar_v2_LM(codigo As Integer) As Entity.Registro.DocumentoJudicial
            Dim ent As New Entity.Registro.DocumentoJudicial
            ent.Codigo = codigo
            ent = Listar_v2_LM(ent)
            Return ent
        End Function

        Public Function ListarDocJud_v2_LM(EntDocJud As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicialCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar2_LM(sqlCon, "lst", "lst_mant_LM", EntDocJud)
            Dim objEntcol As New Entity.Registro.DocumentoJudicialCol

            objEnt = Nothing

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial

                        With objEnt
                            .InternoId = sqlDr("int_id").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .DocumentoNumeroTraslado = sqlDr("doc_jud_num_aux").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            .DistritoJudicial = sqlDr("dis_jud_id").ToString
                            .SalaJuzgado = sqlDr("sal_jud_id").ToString
                            .JuezNombre = sqlDr("doc_jud_jue").ToString
                            .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                            .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                            .Observacion = sqlDr("doc_jud_obs").ToString
                            ._PenalID = sqlDr("_penid").ToString
                            ._RegionID = sqlDr("_regid").ToString

                            '22-05-2014
                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .RegionOrigenId = sqlDr("reg_ori_id").ToString
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .RegionDestinoId = sqlDr("reg_des_id").ToString
                            .PenalDestinoid = sqlDr("pen_des_id").ToString
                            .PenalOtroOrigenNom = sqlDr("pen_ori_otr").ToString
                            .PenalDestinoOtroNom = sqlDr("pen_des_otr").ToString
                            .FechaMovimiento = sqlDr("doc_fec_mov").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .MovimientoMotivoId = sqlDr("mov_mot_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .SituacionJuridicaId = sqlDr("sit_jur_id").ToString
                            If .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Then
                                .SituacionJuridicaId = sqlDr("sit_jur_id").ToString
                                .Flagrancia = sqlDr("int_exp_flag").ToString
                            End If
                            .ProlonDetencionFechIni = sqlDr("prol_det_ini_fec").ToString
                            .ProlonDetencionFechFin = sqlDr("prol_det_fin_fec").ToString
                            .ProlonDetencionTipoUnidad = sqlDr("prol_det_tip_und").ToString
                            .ProlonDetencionValor = sqlDr("prol_det_cant").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString

                            .DocumentoTipoNombre = UCase(sqlDr("doc_tip_nom").ToString)
                            .SentenciaFecha = sqlDr("sent_fec").ToString
                            .SentenciaConsentida = sqlDr("sent_consentida").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaTotalAnios = sqlDr("sent_tot_anio").ToString
                            .SentenciaTotalMeses = sqlDr("sent_tot_meses").ToString
                            .SentenciaTotalDias = sqlDr("sent_tot_dias").ToString

                            .DocumentoJudicialPenalOrigen = sqlDr("c_reg_doc_jud_doc").ToString
                            .FechaInternamientoPenalOrigen = sqlDr("f_reg_doc_jud_fec_int").ToString
                            .FechaIngresoPenalOrigen = sqlDr("f_reg_doc_jud_fec_ing").ToString
                            .ObservacionPenalOrigen = sqlDr("c_reg_doc_jud_obs").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            '-----------------------
                            If .TipoAutoridadJudicial = 1 Then
                                .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                                .DistritoJudNombre = sqlDr("doc_jud_nom").ToString
                                .SalaJudNombre = sqlDr("doc_jud_sal_nom").ToString
                                .JuezNombre = sqlDr("doc_jud_jue").ToString
                                .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            Else
                                If .TipoAutoridadJudicial = -1 Then
                                    If .DistritoJudicial > 0 Then
                                        .TipoAutoridadJudicial = 1
                                        .DistritoJudNombre = sqlDr("dis_jud_nom").ToString
                                        .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                                        .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                                    Else
                                        .TipoAutoridadJudicial = 2
                                        .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString

                                        .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                                        .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                                        .SalaJudNombre = .AutoridadOtroNombre & " / " & .AutoridadOtroCargo
                                        .JuezNombre = ""
                                        .SecretarioNombre = ""
                                    End If
                                Else
                                    .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                                    .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString

                                    .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                                    .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                                    .SalaJudNombre = .AutoridadOtroNombre & " / " & .AutoridadOtroCargo

                                    .JuezNombre = ""
                                    .SecretarioNombre = ""
                                End If
                            End If
                        End With
                        objEntcol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntcol
        End Function

        Public Function ListarDocJud_x_Anulacion(IdInterno As Integer, IdIngresoInpe As Integer, IdIngreso As Integer,
                                                 IdDocumentoAntecedente As Integer) As Entity.Registro.DocumentoJudicialCol

            Dim objFiltro As New Entity.Registro.DocumentoJudicial
            With objFiltro
                .InternoId = IdInterno
                .IngresoInpeId = IdIngresoInpe
                .InternoIngresoId = IdIngreso
                .IdDocumentoAntecedente = IdDocumentoAntecedente
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar(sqlCon, "lst", "lst_listar_documentos_x_anulacion", objFiltro)
            Dim objEntcol As New Entity.Registro.DocumentoJudicialCol

            objEnt = Nothing

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial

                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                        End With
                        objEntcol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntcol
        End Function
        Public Function Listar_v2_LM(EntDoc As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicial
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar2_LM(sqlCon, "lst", "lst_mant_LM", EntDoc)

            objEnt = New Entity.Registro.DocumentoJudicial

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        With objEnt
                            .InternoId = sqlDr("int_id").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .DocumentoNumeroTraslado = sqlDr("doc_jud_num_aux").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            .DistritoJudicial = sqlDr("dis_jud_id").ToString
                            .SalaJuzgado = sqlDr("sal_jud_id").ToString
                            .JuezNombre = sqlDr("doc_jud_jue").ToString
                            .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                            .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                            .Observacion = sqlDr("doc_jud_obs").ToString
                            ._PenalID = sqlDr("_penid").ToString
                            ._RegionID = sqlDr("_regid").ToString

                            '22-05-2014
                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .RegionOrigenId = sqlDr("reg_ori_id").ToString
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .RegionDestinoId = sqlDr("reg_des_id").ToString
                            .PenalDestinoid = sqlDr("pen_des_id").ToString
                            .PenalOtroOrigenNom = sqlDr("pen_ori_otr").ToString
                            .PenalDestinoOtroNom = sqlDr("pen_des_otr").ToString
                            .FechaMovimiento = sqlDr("doc_fec_mov").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .MovimientoMotivoId = sqlDr("mov_mot_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .SituacionJuridicaId = sqlDr("sit_jur_id").ToString
                            If .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion Then
                                .SituacionJuridicaId = sqlDr("sit_jur_id").ToString
                                .Flagrancia = sqlDr("int_exp_flag").ToString
                            End If
                            .ProlonDetencionFechIni = sqlDr("prol_det_ini_fec").ToString
                            .ProlonDetencionFechFin = sqlDr("prol_det_fin_fec").ToString
                            .ProlonDetencionTipoUnidad = sqlDr("prol_det_tip_und").ToString
                            .ProlonDetencionValor = sqlDr("prol_det_cant").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString

                            .DocumentoTipoNombre = UCase(sqlDr("doc_tip_nom").ToString)
                            .SentenciaFecha = sqlDr("sent_fec").ToString
                            .SentenciaConsentida = sqlDr("sent_consentida").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaTotalAnios = sqlDr("sent_tot_anio").ToString
                            .SentenciaTotalMeses = sqlDr("sent_tot_meses").ToString
                            .SentenciaTotalDias = sqlDr("sent_tot_dias").ToString

                            .DocumentoJudicialPenalOrigen = sqlDr("c_reg_doc_jud_doc").ToString
                            .FechaInternamientoPenalOrigen = sqlDr("f_reg_doc_jud_fec_int").ToString
                            .FechaIngresoPenalOrigen = sqlDr("f_reg_doc_jud_fec_ing").ToString
                            .ObservacionPenalOrigen = sqlDr("c_reg_doc_jud_obs").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            '-----------------------
                            If .TipoAutoridadJudicial = 1 Then
                                .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                                .DistritoJudNombre = sqlDr("doc_jud_nom").ToString
                                .SalaJudNombre = sqlDr("doc_jud_sal_nom").ToString
                                .JuezNombre = sqlDr("doc_jud_jue").ToString
                                .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            Else
                                If .TipoAutoridadJudicial = -1 Then
                                    If .DistritoJudicial > 0 Then
                                        .TipoAutoridadJudicial = 1
                                        .DistritoJudNombre = sqlDr("dis_jud_nom").ToString
                                        .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                                        .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                                    Else
                                        .TipoAutoridadJudicial = 2
                                        .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString

                                        .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                                        .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                                        .SalaJudNombre = .AutoridadOtroNombre & " / " & .AutoridadOtroCargo
                                        .JuezNombre = ""
                                        .SecretarioNombre = ""
                                    End If
                                Else
                                    .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                                    .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString

                                    .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                                    .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                                    .SalaJudNombre = .AutoridadOtroNombre & " / " & .AutoridadOtroCargo

                                    .JuezNombre = ""
                                    .SecretarioNombre = ""
                                End If
                            End If
                            '.EstablecimientomentalId = sqlDr("fk_est_men_id").ToString
                            .FechaInscripcion = sqlDr("sen_fec_ins").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function

        Public Function ListarGrilla(ByVal objDocJud As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicialCol
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar2(sqlCon, "lst", "lst_grilla", objDocJud)
            Try
                objEntCol = New Entity.Registro.DocumentoJudicialCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoTipoNombre = UCase(sqlDr("doc_tip_nom").ToString)
                            .DocumentoSubTipoNombre = UCase(sqlDr("doc_subtip_nom").ToString)
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString
                            .MovimientoMotivoId = sqlDr("mov_mot_id").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString
                            .FechaMovimiento = sqlDr("doc_fec_mov").ToString
                            .DocumentoFechaMovimiento = sqlDr("doc_fec_mov").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .TipoAutoridadJudicial = (sqlDr("tip_aut_jud_id").ToString)
                            .DistritoJudicial = sqlDr("dis_jud_id").ToString
                            .SalaJuzgado = sqlDr("sal_juz_id").ToString
                            If .TipoAutoridadJudicial = 1 Then
                                .DistritoJudNombre = sqlDr("dis_jud_nom").ToString
                                .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                                .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            Else
                                If .TipoAutoridadJudicial = -1 Then
                                    If .DistritoJudicial > 0 Then
                                        .TipoAutoridadJudicial = 1
                                        .DistritoJudNombre = sqlDr("dis_jud_nom").ToString
                                        .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                                        .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                                    Else
                                        .TipoAutoridadJudicial = 2
                                        .DistritoJudNombre = sqlDr("doc_jud_aut_nom").ToString
                                        If .DistritoJudNombre = "" Then
                                            .DistritoJudNombre = "NO INDICA"
                                        End If
                                        .SalaJudNombre = sqlDr("doc_jud_aut_cgo").ToString
                                        If .SalaJudNombre = "" Then
                                            .SalaJudNombre = "NO INDICA"
                                        End If
                                        .SecretarioNombre = ""
                                    End If
                                Else
                                    'If .DistritoJudicial > 0 Then
                                    '    .TipoAutoridadJudicial = 1
                                    'Else
                                    .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                                    'End If

                                    .DistritoJudNombre = sqlDr("doc_jud_aut_nom").ToString
                                    If .DistritoJudNombre = "" Then
                                        .DistritoJudNombre = "NO INDICA"
                                    End If
                                    .SalaJudNombre = sqlDr("doc_jud_aut_cgo").ToString
                                    If .SalaJudNombre = "" Then
                                        .SalaJudNombre = "NO INDICA"
                                    End If
                                    .SecretarioNombre = ""
                                End If
                            End If
                            .fechaMovimientoEjecucion = sqlDr("mov_fec").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .ProlonDetencionFechIni = sqlDr("prol_det_ini_fec").ToString
                            .ProlonDetencionFechFin = sqlDr("prol_det_fin_fec").ToString
                            .ProlonDetencionValor = sqlDr("prol_det_cant").ToString
                            .ProlonDetencionTipoUnidad = sqlDr("prol_det_tip_und").ToString
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
                            .SentenciaFecha = sqlDr("sent_fec").ToString
                            .SentenciaTotalAnios = sqlDr("sent_tot_anio").ToString
                            .SentenciaTotalMeses = sqlDr("sent_tot_meses").ToString
                            .SentenciaTotalDias = sqlDr("sent_tot_dias").ToString
                            .TipoLibertadNom = sqlDr("tip_lib_nom").ToString
                            .TipoCategoria = sqlDr("doc_tip_cat").ToString
                            .IdDocumentoAntecedente = sqlDr("n_anu_id").ToString
                            .NumeroExpediente = sqlDr("int_ing_exp_num").ToString
                            .tipoInumputable = sqlDr("fk_mot_ing_id").ToString
                            .Observacion_Queda = sqlDr("obs_queda").ToString
                            .Proceso_Pendiente_Queda = sqlDr("flg_proc_pend").ToString
                            ._Version = sqlDr("sent_vers").ToString
                            .FechaMovimiento = sqlDr("mov_fecha").ToString
                            .EstadoEjecucionId = sqlDr("est_eje_trs_id").ToString
                            .mov_est_id = sqlDr("mov_est_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarGrilla_LM(ByVal objDocJud As Entity.Registro.DocumentoJudicial, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.Registro.DocumentoJudicialCol
            Dim opc As String = ""
            opc = "lst_grilla_sede_LM"

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlDr = Data.Registro.DocumentoJudicial.Listar2_LM(sqlCon, "lst", opc, objDocJud)

                objEntCol = New Entity.Registro.DocumentoJudicialCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoTipoNombre = UCase(sqlDr("doc_tip_nom").ToString)
                            .DocumentoSubTipoNombre = UCase(sqlDr("doc_subtip_nom").ToString)
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString
                            .MovimientoMotivoId = sqlDr("mov_mot_id").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString
                            .DocumentoFechaMovimiento = sqlDr("doc_fec_mov").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .TipoAutoridadJudicial = (sqlDr("tip_aut_jud_id").ToString)
                            .DistritoJudicial = sqlDr("dis_jud_id").ToString
                            .SalaJuzgado = sqlDr("sal_juz_id").ToString
                            If .TipoAutoridadJudicial = 1 Then
                                .DistritoJudNombre = sqlDr("dis_jud_nom").ToString
                                .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                                .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            Else
                                If .TipoAutoridadJudicial = -1 Then
                                    If .DistritoJudicial > 0 Then
                                        .TipoAutoridadJudicial = 1
                                        .DistritoJudNombre = sqlDr("dis_jud_nom").ToString
                                        .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                                        .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                                    Else
                                        .TipoAutoridadJudicial = 2
                                        .DistritoJudNombre = sqlDr("doc_jud_aut_nom").ToString
                                        .SalaJudNombre = sqlDr("doc_jud_aut_cgo").ToString
                                        Select Case .DocumentoTipo
                                            Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso,
                                                Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
                                                .DistritoJudNombre = ""
                                                .SalaJudNombre = ""
                                        End Select
                                        .SecretarioNombre = ""
                                    End If
                                Else
                                    .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                                    .DistritoJudNombre = sqlDr("doc_jud_aut_nom").ToString
                                    If .DistritoJudNombre = "" Then
                                        .DistritoJudNombre = "NO INDICA"
                                    End If
                                    .SalaJudNombre = sqlDr("doc_jud_aut_cgo").ToString
                                    If .SalaJudNombre = "" Then
                                        .SalaJudNombre = "NO INDICA"
                                    End If
                                    .SecretarioNombre = ""
                                End If
                            End If
                            .fechaMovimientoEjecucion = sqlDr("mov_fec").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .ProlonDetencionFechIni = sqlDr("prol_det_ini_fec").ToString
                            .ProlonDetencionFechFin = sqlDr("prol_det_fin_fec").ToString
                            .ProlonDetencionValor = sqlDr("prol_det_cant").ToString
                            .ProlonDetencionTipoUnidad = sqlDr("prol_det_tip_und").ToString
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
                            .SentenciaFecha = sqlDr("sent_fec").ToString
                            .SentenciaTotalAnios = sqlDr("sent_tot_anio").ToString
                            .SentenciaTotalMeses = sqlDr("sent_tot_meses").ToString
                            .SentenciaTotalDias = sqlDr("sent_tot_dias").ToString
                            .TipoLibertadNom = sqlDr("tip_lib_nom").ToString
                            .TipoCategoria = sqlDr("doc_tip_cat").ToString
                            .IdDocumentoAntecedente = sqlDr("n_anu_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .RegionNombre = ""
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .IngresoInpeNro = sqlDr("c_num_ing").ToString
                            ._PenalID = sqlDr("_penid").ToString
                            .PenalDestinoid = sqlDr("pen_des_id").ToString
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .NumeroExpediente = sqlDr("int_ing_exp_num").ToString
                            .Observacion_Queda = sqlDr("obs_queda").ToString
                            .Proceso_Pendiente_Queda = sqlDr("flg_proc_pend").ToString
                            ._Version = sqlDr("sent_vers").ToString
                            .FechaMovimiento = sqlDr("mov_fecha").ToString
                            .EstadoEjecucionId = sqlDr("est_eje_trs_id").ToString
                            .mov_est_id = sqlDr("mov_est_id").ToString
                            '._Historico = sqlDr("int_ing_hist").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarGrillaDocCarceleta_LM(ByVal objDocJud As Entity.Registro.DocumentoJudicial, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia, Optional ByVal excluirMandDeCarleta As Boolean = False) As Entity.Registro.DocumentoJudicialCol
            Dim opc As String = ""
            opc = "lst_grilla_carceleta_LM"

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlDr = Data.Registro.DocumentoJudicial.Listar2_LM(sqlCon, "lst", opc, objDocJud)

                objEntCol = New Entity.Registro.DocumentoJudicialCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoTipoNombre = UCase(sqlDr("doc_tip_nom").ToString)
                            .DocumentoSubTipoNombre = UCase(sqlDr("doc_subtip_nom").ToString)
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString
                            .MovimientoMotivoId = sqlDr("mov_mot_id").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString
                            .FechaMovimiento = sqlDr("doc_fec_mov").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .TipoAutoridadJudicial = (sqlDr("tip_aut_jud_id").ToString)
                            .DistritoJudicial = sqlDr("dis_jud_id").ToString
                            .SalaJuzgado = sqlDr("sal_juz_id").ToString
                            If .TipoAutoridadJudicial = 1 Then
                                .DistritoJudNombre = sqlDr("dis_jud_nom").ToString
                                .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                                .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            Else
                                If .TipoAutoridadJudicial = -1 Then
                                    If .DistritoJudicial > 0 Then
                                        .TipoAutoridadJudicial = 1
                                        .DistritoJudNombre = sqlDr("dis_jud_nom").ToString
                                        .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                                        .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                                    Else
                                        .TipoAutoridadJudicial = 2
                                        .DistritoJudNombre = sqlDr("doc_jud_aut_nom").ToString
                                        If .DistritoJudNombre = "" Then
                                            .DistritoJudNombre = "NO INDICA"
                                        End If
                                        .SalaJudNombre = sqlDr("doc_jud_aut_cgo").ToString
                                        If .SalaJudNombre = "" Then
                                            .SalaJudNombre = "NO INDICA"
                                        End If
                                        .SecretarioNombre = ""
                                    End If
                                Else
                                    .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                                    .DistritoJudNombre = sqlDr("doc_jud_aut_nom").ToString
                                    If .DistritoJudNombre = "" Then
                                        .DistritoJudNombre = "NO INDICA"
                                    End If
                                    .SalaJudNombre = sqlDr("doc_jud_aut_cgo").ToString
                                    If .SalaJudNombre = "" Then
                                        .SalaJudNombre = "NO INDICA"
                                    End If
                                    .SecretarioNombre = ""
                                End If
                            End If
                            .fechaMovimientoEjecucion = sqlDr("mov_fec").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .ProlonDetencionFechIni = sqlDr("prol_det_ini_fec").ToString
                            .ProlonDetencionFechFin = sqlDr("prol_det_fin_fec").ToString
                            .ProlonDetencionValor = sqlDr("prol_det_cant").ToString
                            .ProlonDetencionTipoUnidad = sqlDr("prol_det_tip_und").ToString
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
                            .SentenciaFecha = sqlDr("sent_fec").ToString
                            .SentenciaTotalAnios = sqlDr("sent_tot_anio").ToString
                            .SentenciaTotalMeses = sqlDr("sent_tot_meses").ToString
                            .SentenciaTotalDias = sqlDr("sent_tot_dias").ToString
                            .TipoLibertadNom = sqlDr("tip_lib_nom").ToString
                            .TipoCategoria = sqlDr("doc_tip_cat").ToString
                            .IdDocumentoAntecedente = sqlDr("n_anu_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .RegionNombre = ""
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .IngresoInpeNro = sqlDr("c_num_ing").ToString
                            ._PenalID = sqlDr("_penid").ToString
                        End With
                        If excluirMandDeCarleta = True And sqlDr("doc_tip_id").ToString = 35 Then
                            Continue While
                        Else
                            objEntCol.Add(objEnt)
                        End If
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarValidacion(objDocJud As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicial
            '2024 jeu
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar2(sqlCon, "lst", "lst_mant", objDocJud)
            objEnt = New Entity.Registro.DocumentoJudicial
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .FechaInscripcion = sqlDr("sen_fec_ins").ToString
                            .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                            .DistritoJudicial = sqlDr("dis_jud_id").ToString
                            .SalaJuzgado = sqlDr("sal_jud_id").ToString
                            .DistritoJudNombre = sqlDr("doc_jud_nom").ToString
                            .SalaJudNombre = sqlDr("doc_jud_sal_nom").ToString
                            .JuezNombre = sqlDr("doc_jud_jue").ToString
                            .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                            .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                            .Observacion = sqlDr("doc_jud_obs").ToString
                            ._PenalID = sqlDr("_penid").ToString
                            ._RegionID = sqlDr("_regid").ToString
                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .RegionOrigenId = sqlDr("reg_ori_id").ToString
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .RegionDestinoId = sqlDr("reg_des_id2").ToString
                            .PenalDestinoid = sqlDr("pen_des_id").ToString
                            .PenalOtroOrigenNom = sqlDr("pen_ori_otr").ToString
                            .PenalDestinoOtroNom = sqlDr("pen_des_otr").ToString
                            .FechaMovimiento = sqlDr("doc_fec_mov").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .MovimientoMotivoId = sqlDr("mov_mot_id").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoTipoNombre = UCase(sqlDr("doc_tip_nom").ToString)
                            .SentenciaFecha = sqlDr("sent_fec").ToString
                            .SentenciaConsentida = sqlDr("sent_consentida").ToString
                            .SentenciaCadenaPerpetua = sqlDr("sent_cad_perpet").ToString
                            .SentenciaTotalAnios = sqlDr("sent_tot_anio").ToString
                            .SentenciaTotalMeses = sqlDr("sent_tot_meses").ToString
                            .SentenciaTotalDias = sqlDr("sent_tot_dias").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function

#End Region
#Region "Grabar"
        Public Function Grabar(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer

            'metodo antiguo no se debe usar, jmr 15.10.2021

            If ValidarEntrada(ObjEnt) = True Then
                Dim intValue As Integer = -1
                Dim strAccion As String = ""
                Dim strOpcion As String = ""

                If ObjEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                intValue = Data.Registro.DocumentoJudicial.Grabar(strAccion, strOpcion, ObjEnt)
                Return intValue
            Else
                Return -2
            End If
        End Function

        Public Function Grabar_LM(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer

            Dim value As Integer = -1

            If ValidarEntrada_LM(ObjEnt) = True Then

                Dim strAccion As String = ""
                Dim strOpcion As String = ""

                If validarEstadoDistritoJudicial(ObjEnt) = False Then
                    Return value
                End If

                If ObjEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_sede"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant_lm"
                End If

                value = Data.Registro.DocumentoJudicial.Grabar_LM(strAccion, strOpcion, ObjEnt)

                If ObjEnt.DocumentoTipo = enumTipoDocumentoJudicial.Queda Then
                    strAccion = "upd"
                    strOpcion = "upd_mant_que"
                    ObjEnt.Codigo = value
                    Data.Registro.DocumentoJudicial.Grabar_LM(strAccion, strOpcion, ObjEnt)
                End If

            End If

            Return value

        End Function

        Public Function Grabar2(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer

            Dim value As Integer = -1

            '22-05-2014 hnrb
            If ValidarEntrada(ObjEnt) = True Then

                If validarEstadoDistritoJudicial(ObjEnt) = False Then
                    Return value
                End If

                Dim strAccion As String = ""
                Dim strOpcion As String = ""

                If ObjEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_v5"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant_v5"
                End If

                value = Data.Registro.DocumentoJudicial.Grabar2(strAccion, strOpcion, ObjEnt)

            End If

            Return value
        End Function

        Public Function GrabarV3(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer

            Dim value As Integer = -1

            If ValidarEntrada(ObjEnt) = True Then

                If validarEstadoDistritoJudicial(ObjEnt) = False Then
                    Return value
                End If

                Dim strAccion As String = ""
                Dim strOpcion As String = ""

                If ObjEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_v6"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant_v6"
                End If

                value = Data.Registro.DocumentoJudicial.GrabarV3(strAccion, strOpcion, ObjEnt)

            End If

            Return value
        End Function

        Public Function GrabarAnulacion(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer

            '22-05-2014 hnrb

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""


            strAccion = "upd"
            strOpcion = "upd_mant_anu"


            intValue = Data.Registro.DocumentoJudicial.Grabar2(strAccion, strOpcion, ObjEnt)
            Return intValue

        End Function

        Public Function GrabarAnulacion_LM(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_mant_anu"


            intValue = Data.Registro.DocumentoJudicial.Grabar_LM(strAccion, strOpcion, ObjEnt)
            Return intValue
        End Function

        Public Function GrabarQueda_LM(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_mant_que"


            intValue = Data.Registro.DocumentoJudicial.Grabar_LM(strAccion, strOpcion, ObjEnt)
            Return intValue
        End Function

        Public Function GrabarQuedaJud(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "upd"
            strOpcion = "upd_queda"
            intValue = Data.Registro.DocumentoJudicial.GrabarQuedaJud(strAccion, strOpcion, ObjEnt)
            Return intValue
        End Function
#End Region

#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, TipoDoc As Integer, SubTipoDoc As Integer, InternoID As Integer, IngresoID As Integer,
                                 Optional ByRef sms As String = "", Optional n_ActivarFlagTransferSede As Integer = 0, Optional objExpCol As Entity.Registro.ExpedienteCol = Nothing) As Integer
            Dim objEntExpCol As New Entity.Registro.ExpedienteCol
            BssDoc = New Bussines.Registro.DocumentoJudicial
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant_v5"
            '----------------- ------------------------------------------------------ ------------->

            If TipoDoc = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                BssExp = New Bussines.Registro.Expediente
                BssPad = New Bussines.Registro.InternoExpedientePadre

                objEntExpCol = BssExp.ListarExpedientexResolucion(Codigo)
                Dim ObjExpediente1 As New Entity.Registro.Expediente

                intValue = Data.Registro.DocumentoJudicial.Eliminar(strAccion, strOpcion, Codigo, InternoID, IngresoID, n_ActivarFlagTransferSede)

                BssExp.GrabarEstadoVisibilidad(ObjExpediente1.Codigo, False)
                BssExp.Eliminar(ObjExpediente1.Codigo)
                Dim EntExpPadr As New Entity.Registro.InternoExpedientePadre
                EntExpPadr.InternoExpedienteId = ObjExpediente1.Codigo

                Dim CodigoPad As Integer = BssPad.ListarGrilla(EntExpPadr).Count
                If CodigoPad > 0 Then
                    BssExp.GrabarEstadoVisibilidad(CodigoPad, True)
                End If
            ElseIf TipoDoc = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria Or
                TipoDoc = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio Then
                intValue = Data.Registro.DocumentoJudicial.Eliminar(strAccion, strOpcion, Codigo, InternoID, IngresoID, n_ActivarFlagTransferSede)
                Dim bssNA As New Bussines.Registro.NombreAsociado
                Dim bssDocNA As New Bussines.Registro.Documento.NombresAsociados
                bssDocNA.Eliminar(Codigo, InternoID, IngresoID)

            ElseIf TipoDoc = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso Then
                intValue = Data.Registro.DocumentoJudicial.Eliminar(strAccion, strOpcion, Codigo, InternoID, IngresoID, n_ActivarFlagTransferSede)
                Dim EntDoc As New Entity.Registro.DocumentoJudicial
                With EntDoc
                    .InternoId = InternoID
                    .InternoIngresoId = IngresoID
                End With
                If SubTipoDoc = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                    EntDoc.DocumentoSubTipoId = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado
                End If

                EntDoc = BssDoc.Listar_v2(EntDoc)
                ''Data.Registro.DocumentoJudicial.Eliminar(strAccion, strOpcion, Codigo, InternoID, IngresoID)
            ElseIf TipoDoc = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                intValue = Data.Registro.DocumentoJudicial.Eliminar(strAccion, strOpcion, Codigo, InternoID, IngresoID, n_ActivarFlagTransferSede)
                Dim EntDoc As New Entity.Registro.DocumentoJudicial
                With EntDoc
                    .InternoId = InternoID
                    .InternoIngresoId = IngresoID
                End With
            ElseIf TipoDoc = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then

                intValue = EliminarAntecedentesV2(Codigo, TipoDoc, SubTipoDoc, InternoID, IngresoID, sms, n_ActivarFlagTransferSede, objExpCol)
            Else
                intValue = Data.Registro.DocumentoJudicial.Eliminar(strAccion, strOpcion, Codigo, InternoID, IngresoID, n_ActivarFlagTransferSede)
                EliminarIninputables(TipoDoc, Codigo, InternoID, n_ActivarFlagTransferSede)
            End If

            Return intValue
        End Function
        Private Function EliminarAntecedentes(ByVal Codigo As Integer, TipoDoc As Integer, SubTipoDoc As Integer, InternoID As Integer, IngresoID As Integer, Optional ByRef sms As String = "", Optional n_ActivarFlagTransferSede As Integer = 0)
            BssExp = New Bussines.Registro.Expediente
            bssDel = New Bussines.Registro.Delito
            bssAgr = New Bussines.Registro.InternoAgraviado

            Dim intValue As Integer

            intValue = Data.Registro.DocumentoJudicial.Eliminar("del", "del_mant_v5", Codigo, InternoID, IngresoID, n_ActivarFlagTransferSede)

            Dim entDocJudExp As New Entity.Registro.DocumentoJudicial
            entDocJudExp.InternoId = InternoID
            entDocJudExp.InternoIngresoId = IngresoID
            Dim docJudCol As New Entity.Registro.DocumentoJudicialCol
            docJudCol = BssDoc.Listar_DocumentosJudiciales(entDocJudExp)
            Dim fechaMay As Long = 0
            Dim objDoc As New Entity.Registro.DocumentoJudicial
            For Each obj As Entity.Registro.DocumentoJudicial In docJudCol
                If obj.IdDocumentoAntecedente = Codigo Then
                    ActualizarDocumentosExpedientes(obj, InternoID)
                End If
                If obj.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    If obj.DocumentoFechaRecepcion > 0 Then
                        objDoc = New Entity.Registro.DocumentoJudicial
                        objDoc = obj
                    End If
                ElseIf (obj.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas Or
                        obj.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Traslado) And obj.IdDocumentoAntecedente = Codigo Then
                    obj.InternoId = InternoID
                    obj.IdDocumentoAntecedente = -1
                    obj.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                    BssDoc.GrabarAnulacion(obj)
                End If
            Next

            If objDoc.Codigo > 0 Then
                Dim entExpCol As New Entity.Registro.ExpedienteCol
                Dim entDelCol As New Entity.Registro.DelitoCol
                Dim entAgrCol As Entity.Registro.AgraviadoCol
                Dim objdel As New Entity.Registro.Delito
                Dim objagr As New Entity.Registro.Agraviado
                entExpCol = BssExp.ListarExpedientexResolucion(objDoc.Codigo)
                objdel.InternoID = InternoID
                objdel.IngresoID = IngresoID
                objdel.CreaDocJudicialId = objDoc.Codigo
                entDelCol = bssDel.Listar2(objdel)
                objagr.InternoID = InternoID
                objagr.IngresoID = IngresoID
                objagr.CreaDocJudicialId = objDoc.Codigo
                entAgrCol = bssAgr.Listar(objagr)
                ActualizarAnulacion(objDoc.Codigo, entExpCol, entDelCol, entAgrCol)
            Else 'Cuando ya no queda ningun documento judicial
                For Each obj As Entity.Registro.DocumentoJudicial In docJudCol
                    ActualizarDocumentosExpedientes(obj, InternoID)
                Next
            End If
            Return intValue
        End Function
        'Para provincia
        Private Function EliminarAntecedentesV2(ByVal Codigo As Integer, TipoDoc As Integer, SubTipoDoc As Integer, InternoID As Integer, IngresoID As Integer, Optional ByRef sms As String = "", Optional n_ActivarFlagTransferSede As Integer = 0, Optional objExpCol As Entity.Registro.ExpedienteCol = Nothing)
            Dim intValue As Integer
            Dim ExpId As Integer = -1
            Dim DelId As Integer = -1
            Dim AgrId As Integer = -1

            Dim objDocumentoCol As New Entity.Registro.DocumentoJudicialCol
            Dim objCol As New Entity.Registro.DocumentoJudicialCol
            Dim objExpediente As New Entity.Registro.Expediente
            Dim objExpedienteCol As New Entity.Registro.ExpedienteCol
            Dim objDelito As New Entity.Registro.Delito
            Dim objDelCol As New Entity.Registro.DelitoCol
            Dim objAgrCol As New Entity.Registro.AgraviadoCol
            BssExp = New Bussines.Registro.Expediente
            bssDel = New Bussines.Registro.Delito
            bssAgr = New Bussines.Registro.InternoAgraviado
            Dim blnValor As Boolean = False
            Dim intConta As Integer = -1
            Dim intContador As Integer = -1
            For Each objExp As Entity.Registro.Expediente In objExpCol
                ExpId = objExp.Codigo
                intConta = -1
                intContador = -1
                While ExpId > 0
                    intConta = intConta + 1
                    ''1. Saber tipo de docuemnto en expediente 
                    Dim expCol As New Entity.Registro.ExpedienteCol
                    objExpediente = New Entity.Registro.Expediente
                    objExpediente.InternoID = objExp.InternoID
                    objExpediente.Codigo = ExpId
                    expCol = BssExp.Listar_v2(objExpediente)
                    If expCol.Count > 0 Then
                        objExpediente = New Entity.Registro.Expediente
                        'Contabilizar los estados de los delitos
                        Dim contot As Integer = 0
                        Dim conpar As Integer = 0
                        Dim connor As Integer = 0
                        Select Case expCol.Expediente(0).DocumentoTipoID
                            Case 19, 28, 29
                                Dim objECol As New Entity.Registro.ExpedienteCol
                                objECol = BssExp.ListarExpedientexResolucion(expCol.Expediente(0).CreaDocJudicialId)
                                For Each Exp As Entity.Registro.Expediente In objECol
                                    Dim AuxExpId As Integer = Exp.Codigo
                                    While AuxExpId > 0
                                        objDelito.ExpedienteID = AuxExpId
                                        objDelito.InternoID = objExp.InternoID
                                        objDelCol = bssDel.Listar2(objDelito)

                                        objDelCol = bssDel.Listar2(objDelito)
                                        For Each objDel As Entity.Registro.Delito In objDelCol
                                            If objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                                                connor += 1
                                            ElseIf objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                                contot += 1
                                            Else
                                                conpar += 1
                                            End If
                                        Next
                                        If contot > 0 And conpar = 0 And connor = 0 Then
                                            objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                        ElseIf contot = 0 And conpar = 0 And connor > 0 Then
                                            objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                        Else
                                            objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                        End If
                                        'Actualizacion estado del expediente
                                        objExpediente.Codigo = AuxExpId
                                        objExpediente.InternoID = objExp.InternoID
                                        BssExp.UpdateAnulacion(objExpediente)
                                        ' obtener expediente padre
                                        Dim objpad As New Entity.Registro.InternoExpedientePadre
                                        objpad.InternoExpedienteId = objExpediente.Codigo
                                        objpad.InternoID = objExp.InternoID
                                        objpad = (New Bussines.Registro.InternoExpedientePadre).Listar(objpad)

                                        Dim objdoc As New Entity.Registro.DocumentoJudicial
                                        objExpediente = New Entity.Registro.Expediente
                                        objExpediente.Codigo = AuxExpId
                                        objExpediente.InternoID = objExp.InternoID
                                        objdoc.Codigo = (New Bussines.Registro.Expediente).Listar_v2(objExpediente).Item(0).CreaDocJudicialId
                                        objDocumentoCol.Add(objdoc)

                                        AuxExpId = objpad.InternoExpedienteRefPadreId
                                    End While
                                    If AuxExpId = -1 Then ExpId = -1
                                Next
                            Case Else
                                ''2. Listar delitos desde ExpedienteId (Limpiar anulados)
                                objExpediente.Codigo = ExpId
                                objExpediente.InternoID = objExp.InternoID

                                objDelito.ExpedienteID = ExpId
                                objDelito.InternoID = objExp.InternoID
                                objDelito.Estado = -1
                                'Realizar un proceso por expediente visible
                                If intConta = 0 Then
                                    objDelCol = bssDel.Listar2(objDelito)
                                    For Each objDel As Entity.Registro.Delito In objDelCol
                                        DelId = objDel.Codigo
                                        intContador = -1
                                        While DelId > 0
                                            intContador += 1
                                            Dim objDel1 As New Entity.Registro.Delito
                                            objDel1.Codigo = DelId
                                            objDel1.InternoID = objDel.InternoID
                                            ''-------------
                                            Dim objDelitoCol As New Entity.Registro.DelitoCol
                                            objDel1.Estado = -1
                                            objDelitoCol = bssDel.Listar2(objDel1)
                                            ''-------------
                                            Dim objAgr1 As New Entity.Registro.Agraviado
                                            objAgr1.InternoID = objExp.InternoID
                                            If objDelitoCol.Count > 0 Then
                                                'Obtener los agraviados
                                                Select Case objDelitoCol.internoDelito(0).DocumentoTipoID
                                                    Case 19, 28, 29
                                                        Dim AuxDelCol As New Entity.Registro.DelitoCol
                                                        Dim AuxDel As New Entity.Registro.Delito
                                                        AuxDel.InternoID = objDel.InternoID
                                                        AuxDel.CreaDocJudicialId = objDelitoCol.internoDelito(0).CreaDocJudicialId
                                                        AuxDelCol = bssDel.Listar2(AuxDel)
                                                        Dim intDel As Integer = -1
                                                        For Each obj As Entity.Registro.Delito In AuxDelCol
                                                            intDel = obj.Codigo
                                                            While intDel > 0
                                                                objAgr1.DelitoID = intDel
                                                                If intContador = 0 Then
                                                                    'Listar y Actualizar los agraviados padres
                                                                    objAgrCol = bssAgr.Listar_v3(objAgr1)
                                                                    For Each objAgr As Entity.Registro.Agraviado In objAgrCol
                                                                        AgrId = objAgr.Codigo
                                                                        While AgrId > 0
                                                                            objAgr1 = New Entity.Registro.Agraviado
                                                                            objAgr1.Codigo = AgrId
                                                                            objAgr1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                                                            objAgr1.InternoID = objAgr.InternoID
                                                                            bssAgr.Grabar_Anu(objAgr1)
                                                                            Dim ColAgr As New Entity.Registro.AgraviadoCol
                                                                            ColAgr = bssAgr.Listar_v3(objAgr1)
                                                                            If ColAgr.Count = 0 Then
                                                                                AgrId = -1
                                                                            Else
                                                                                AgrId = bssAgr.Listar_v3(objAgr1).Item(0).CodigoagraviadoPad
                                                                            End If
                                                                        End While
                                                                    Next
                                                                End If
                                                                'Contabilizar las anulaciones del agraviado
                                                                Dim Tot As Integer = 0
                                                                Dim Nor As Integer = 0
                                                                objAgr1.DelitoID = intDel
                                                                objAgrCol = bssAgr.Listar_v3(objAgr1)
                                                                For Each objAgr As Entity.Registro.Agraviado In objAgrCol
                                                                    If objAgr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                                                                        Nor += 1
                                                                    ElseIf objAgr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                                                        Tot += 1
                                                                    End If
                                                                Next
                                                                If Tot > 0 And Nor = 0 Then
                                                                    objDel1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                                                ElseIf Tot = 0 And Nor > 0 Then
                                                                    objDel1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                                                Else
                                                                    objDel1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                                                End If
                                                                'Actualizar estado del delito
                                                                objDel1.Codigo = intDel
                                                                bssDel.Grabar_Anu(objDel1)

                                                                'Obtener padre del delito
                                                                Dim ColDel As New Entity.Registro.DelitoCol
                                                                ColDel = bssDel.Listar2(objDel1)
                                                                If ColDel.Count = 0 Then
                                                                    intDel = -1
                                                                Else
                                                                    intDel = ColDel.internoDelito(0).CodigodelitoPad
                                                                End If
                                                            End While
                                                        Next
                                                        If intDel = -1 Then DelId = -1
                                                    Case Else
                                                        objAgr1.DelitoID = DelId
                                                        If intContador = 0 Then
                                                            'Listar y Actualizar los agraviados padres
                                                            objAgrCol = bssAgr.Listar_v3(objAgr1)
                                                            For Each objAgr As Entity.Registro.Agraviado In objAgrCol
                                                                AgrId = objAgr.Codigo
                                                                While AgrId > 0
                                                                    objAgr1 = New Entity.Registro.Agraviado
                                                                    objAgr1.Codigo = AgrId
                                                                    objAgr1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                                                    objAgr1.InternoID = objAgr.InternoID
                                                                    bssAgr.Grabar_Anu(objAgr1)
                                                                    Dim ColAgr As New Entity.Registro.AgraviadoCol
                                                                    ColAgr = bssAgr.Listar_v3(objAgr1)
                                                                    If ColAgr.Count = 0 Then
                                                                        AgrId = -1
                                                                    Else
                                                                        AgrId = bssAgr.Listar_v3(objAgr1).Item(0).CodigoagraviadoPad
                                                                    End If
                                                                End While
                                                            Next
                                                        End If
                                                        'Contabilizar las anulaciones del agraviado
                                                        Dim Tot As Integer = 0
                                                        Dim Nor As Integer = 0
                                                        objAgrCol = bssAgr.Listar_v3(objAgr1)
                                                        For Each objAgr As Entity.Registro.Agraviado In objAgrCol
                                                            If objAgr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                                                                Nor += 1
                                                            ElseIf objAgr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                                                Tot += 1
                                                            End If
                                                        Next
                                                        If Tot > 0 And Nor = 0 Then
                                                            objDel1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                                        ElseIf Tot = 0 And Nor > 0 Then
                                                            objDel1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                                        Else
                                                            objDel1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                                        End If
                                                        'Actualizar estado del delito
                                                        bssDel.Grabar_Anu(objDel1)

                                                        'Obtener padre del delito
                                                        Dim ColDel As New Entity.Registro.DelitoCol
                                                        objDel1.Estado = -1
                                                        ColDel = bssDel.Listar2(objDel1)
                                                        If ColDel.Count = 0 Then
                                                            DelId = -1
                                                        Else
                                                            DelId = ColDel.internoDelito(0).CodigodelitoPad
                                                        End If
                                                End Select
                                            End If
                                        End While
                                    Next
                                End If
                                objDelito.Estado = 0
                                objDelCol = bssDel.Listar2(objDelito)
                                For Each objDel As Entity.Registro.Delito In objDelCol
                                    If objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                                        connor += 1
                                    ElseIf objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                        contot += 1
                                    Else
                                        conpar += 1
                                    End If
                                Next
                                If contot > 0 And conpar = 0 And connor = 0 Then
                                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                ElseIf contot = 0 And conpar = 0 And connor > 0 Then
                                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                Else
                                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                End If
                                'Actualizacion estado del expediente
                                BssExp.UpdateAnulacion(objExpediente)
                                ' obtener expediente padre
                                Dim objpad As New Entity.Registro.InternoExpedientePadre
                                objpad.InternoExpedienteId = objExpediente.Codigo
                                objpad.InternoID = objExp.InternoID
                                objpad = (New Bussines.Registro.InternoExpedientePadre).Listar(objpad)

                                Dim objdoc As New Entity.Registro.DocumentoJudicial
                                objExpediente = New Entity.Registro.Expediente
                                objExpediente.Codigo = ExpId
                                objExpediente.InternoID = objExp.InternoID
                                objdoc.Codigo = (New Bussines.Registro.Expediente).Listar_v2(objExpediente).Item(0).CreaDocJudicialId
                                objDocumentoCol.Add(objdoc)

                                ExpId = objpad.InternoExpedienteRefPadreId
                        End Select
                    End If
                End While
            Next
            For Each objDoc As Entity.Registro.DocumentoJudicial In objDocumentoCol
                blnValor = True
                For Each obj As Entity.Registro.DocumentoJudicial In objCol
                    If objDoc.Codigo = obj.Codigo Then
                        blnValor = False
                        Exit For
                    End If
                Next
                If blnValor = True Then
                    objCol.Add(objDoc)

                    objExpedienteCol = BssExp.ListarExpedientexResolucion(objDoc.Codigo)
                    Dim contaTot As Integer = 0
                    Dim contaPar As Integer = 0
                    Dim contaNor As Integer = 0
                    For Each obj As Entity.Registro.Expediente In objExpedienteCol
                        If obj.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                            contaNor += 1
                        ElseIf obj.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                            contaPar += 1
                        ElseIf obj.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                            contaTot += 1
                        End If
                    Next
                    Dim objDod As New Entity.Registro.DocumentoJudicial
                    objDod.Codigo = objDoc.Codigo
                    If contaNor > 0 And contaPar = 0 And contaTot = 0 Then
                        objDod.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                    ElseIf contaNor = 0 And contaPar = 0 And contaTot > 0 Then
                        objDod.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total
                    Else
                        objDod.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial
                    End If

                    BssDoc.GrabarAnulacion(objDod)
                End If
            Next

            'LISTAR LOS DOCUMENTOS RELACIONADOS AL DOCUMENTO ANTECEDENTES
            objDocumentoCol = New Entity.Registro.DocumentoJudicialCol
            objDocumentoCol = ListarDocJud_x_Anulacion(InternoID, -1, -1, Codigo)

            For Each fila As Entity.Registro.DocumentoJudicial In objDocumentoCol
                Dim objDod As New Entity.Registro.DocumentoJudicial
                objDod.Codigo = fila.Codigo
                objDod.IdDocumentoAntecedente = -1
                objDod.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal

                BssDoc.GrabarAnulacion(objDod)
            Next
            intValue = Data.Registro.DocumentoJudicial.Eliminar("del", "del_mant_v5", Codigo, InternoID, IngresoID, n_ActivarFlagTransferSede)

            Return intValue
        End Function
        'Para ORL
        Private Function EliminarAntecedentes_LM(ByVal Codigo As Integer, TipoDoc As Integer, SubTipoDoc As Integer, InternoID As Integer, IngresoInpeID As Integer, Optional ByRef sms As String = "", Optional n_ActivarFlagTransferSede As Integer = 0, Optional objExpCol As Entity.Registro.ExpedienteCol = Nothing)
            BssExp = New Bussines.Registro.Expediente
            BssPad = New Bussines.Registro.InternoExpedientePadre
            Dim entPad As New Entity.Registro.InternoExpedientePadre
            Dim bssDel As New Bussines.Registro.Delito
            Dim bssAgr As New Bussines.Registro.InternoAgraviado
            Dim intValue As Integer

            intValue = Data.Registro.DocumentoJudicial.Eliminar("del", "del_mant_LM", Codigo, InternoID, IngresoInpeID, n_ActivarFlagTransferSede)
            '' JEU 01/07/2019 se actualiza el estado de los documentos de otros ingresos
            If intValue > 0 Then
                objEnt = New Entity.Registro.DocumentoJudicial
                objEnt.Codigo = Codigo
                objEnt.InternoId = InternoID
                objEnt.IngresoInpeId = IngresoInpeID
                Data.Registro.DocumentoJudicial.Grabar_LM("upd", "upd_estado_anu", objEnt)
            End If

            Dim objDocumentoCol As New Entity.Registro.DocumentoJudicialCol
            'Dim objCol As New Entity.Registro.DocumentoJudicialCol
            Dim entDocJudExp As New Entity.Registro.DocumentoJudicial
            entDocJudExp.InternoId = InternoID
            entDocJudExp.IngresoInpeId = IngresoInpeID
            entDocJudExp.IdDocumentoAntecedente = intValue
            Dim docJudCol As New Entity.Registro.DocumentoJudicialCol
            docJudCol = BssDoc.Listar_DocumentosJudiciales_LM(entDocJudExp)
            Dim fechaMay As Long = 0
            Dim objDoc As New Entity.Registro.DocumentoJudicial
            For Each obj As Entity.Registro.DocumentoJudicial In docJudCol
                If obj.IdDocumentoAntecedente = Codigo Then
                    ActualizarDocumentosExpedientes(obj, InternoID)
                End If
                If obj.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    If obj.DocumentoFechaRecepcion > 0 Then
                        objDoc = New Entity.Registro.DocumentoJudicial
                        objDoc = obj
                    End If
                ElseIf obj.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas And obj.IdDocumentoAntecedente = Codigo Then
                    obj.InternoId = InternoID
                    obj.IdDocumentoAntecedente = -1
                    obj.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                    obj.FlagTransferenciaSede = n_ActivarFlagTransferSede
                    BssDoc.GrabarAnulacion_LM(obj)
                End If
            Next
            If objDoc.Codigo > 0 Then
                Dim entExpCol As New Entity.Registro.ExpedienteCol
                Dim entDelCol As New Entity.Registro.DelitoCol
                Dim entAgrCol As Entity.Registro.AgraviadoCol
                Dim objdel As New Entity.Registro.Delito
                Dim objagr As New Entity.Registro.Agraviado
                entExpCol = BssExp.ListarExpedientexResolucion_LM(objDoc.Codigo)
                objdel.InternoID = InternoID
                objdel.IngresoInpeId = IngresoInpeID
                objdel.CreaDocJudicialId = objDoc.Codigo
                entDelCol = bssDel.Listar2_LM(objdel)
                objagr.InternoID = InternoID
                objdel.IngresoInpeId = IngresoInpeID
                objagr.CreaDocJudicialId = objDoc.Codigo
                entAgrCol = bssAgr.Listar_LM(objagr)
                ActualizarAnulacion_LM(objDoc.Codigo, entExpCol, entDelCol, entAgrCol)
            Else 'Cuando ya no queda ningun documento judicial
                For Each obj As Entity.Registro.DocumentoJudicial In docJudCol
                    If obj.IdDocumentoAntecedente = Codigo Then
                        obj.InternoId = InternoID
                        obj.IdDocumentoAntecedente = -1
                        obj.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                        obj.FlagTransferenciaSede = n_ActivarFlagTransferSede
                        BssDoc.GrabarAnulacion_LM(obj)
                        Dim entExpCol As New Entity.Registro.ExpedienteCol
                        Dim entExp As New Entity.Registro.Expediente
                        entExp.CreaDocJudicialId = obj.Codigo
                        entExpCol = BssExp.Listar_v2(entExp)
                        For Each exp As Entity.Registro.Expediente In entExpCol
                            exp.InternoID = InternoID
                            exp.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                            exp.FlagTransferenciaSede = n_ActivarFlagTransferSede
                            BssExp.UpdateAnulacion_LM(exp)

                            Dim entDelCol As New Entity.Registro.DelitoCol
                            Dim entDel As New Entity.Registro.Delito
                            entDel.ExpedienteID = exp.Codigo
                            entDelCol = bssDel.Listar2(entDel)
                            For Each del As Entity.Registro.Delito In entDelCol
                                del.InternoID = InternoID
                                del.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                del.FlagTransferenciaSede = n_ActivarFlagTransferSede
                                bssDel.Grabar_Anu_LM(del)

                                Dim entAgrCol As New Entity.Registro.AgraviadoCol
                                Dim entAgr As New Entity.Registro.Agraviado
                                entAgr.DelitoID = del.Codigo
                                entAgrCol = bssAgr.Listar(entAgr)
                                For Each Agr As Entity.Registro.Agraviado In entAgrCol
                                    Agr.InternoID = InternoID
                                    Agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                    Agr.FlagTransferenciaSede = n_ActivarFlagTransferSede
                                    bssAgr.Grabar_Anu_LM(Agr)
                                Next
                            Next
                        Next
                    End If
                Next
            End If

            'LISTAR LOS DOCUMENTOS RELACIONADOS AL DOCUMENTO ANTECEDENTES
            objDocumentoCol = New Entity.Registro.DocumentoJudicialCol
            objDocumentoCol = ListarDocJud_x_Anulacion(InternoID, IngresoInpeID, -1, Codigo)

            For Each fila As Entity.Registro.DocumentoJudicial In objDocumentoCol
                Dim objDod As New Entity.Registro.DocumentoJudicial
                objDod.Codigo = fila.Codigo
                objDod.IdDocumentoAntecedente = -1
                objDod.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal

                BssDoc.GrabarAnulacion(objDod)
            Next

            Return intValue
        End Function
        Private Function EliminarAntecedentesV2_LM(ByVal Codigo As Integer, TipoDoc As Integer, SubTipoDoc As Integer, InternoID As Integer, IngresoInpeID As Integer, Optional ByRef sms As String = "", Optional n_ActivarFlagTransferSede As Integer = 0, Optional objExpCol As Entity.Registro.ExpedienteCol = Nothing)
            Dim intValue As Integer = -1
            'Obtenemos los agraviados del documento de anulacion
            Dim bssAgr As New Bussines.Registro.InternoAgraviado
            Dim objExp1 As New Entity.Registro.Expediente
            objExp1.CreaDocJudicialId = Codigo
            'Paso1 
            Dim objAgrCol As New Entity.Registro.AgraviadoCol
            objAgrCol = bssAgr.Listar2(objExp1)
            Dim codigoPad As Integer = -1
            For Each objA As Entity.Registro.Agraviado In objAgrCol
                codigoPad = objA.CodigoagraviadoPad
                While codigoPad > 0
                    codigoPad = bssAgr.Listar(codigoPad).CodigoagraviadoPad
                    bssAgr.Grabar_Anu(objA)
                End While
            Next
            'Paso 2
            Dim objDelCol As New Entity.Registro.DelitoCol
            Dim bssDel As New Bussines.Registro.Delito
            objDelCol = bssDel.Listar2(Nothing)
            For Each objD As Entity.Registro.Delito In objDelCol
                codigoPad = objD.CodigodelitoPad
                While codigoPad > 0
                    codigoPad = bssDel.Listar(codigoPad).CodigodelitoPad
                    bssDel.Grabar_Anu(objD)
                End While
            Next
            'Paso 3
            BssExp = New Bussines.Registro.Expediente
            objExpCol = New Entity.Registro.ExpedienteCol
            'Dim objExp As New Entity.Registro.Expediente
            objExpCol = BssExp.Listar(objExp1)
            For Each objE As Entity.Registro.Expediente In objExpCol
                codigoPad = BssExp.Listar_v2(objE).Item(0).CodigoPadre
                While codigoPad > 0
                    Dim E As New Entity.Registro.Expediente
                    E.Codigo = codigoPad
                    BssExp.UpdateAnulacion(E)
                    codigoPad = BssExp.Listar_v2(E).Item(0).CodigoPadre
                End While
            Next
            'Paso 4 Lista documentos judiciales
            Dim objDocCol As New Entity.Registro.DocumentoJudicialCol
            Dim BssDoc As New Bussines.Registro.DocumentoJudicial
            Dim entDocJudExp As New Entity.Registro.DocumentoJudicial
            entDocJudExp.InternoId = InternoID
            entDocJudExp.IngresoInpeId = IngresoInpeID
            entDocJudExp.IdDocumentoAntecedente = Codigo
            objDocCol = BssDoc.Listar_DocumentosJudiciales_LM(entDocJudExp)
            Dim fechaMay As Long = 0

            For Each objDoc As Entity.Registro.DocumentoJudicial In objDocCol
                BssDoc.GrabarAnulacion(objDoc)
            Next

            'LISTAR LOS DOCUMENTOS RELACIONADOS AL DOCUMENTO ANTECEDENTES
            'objDocumentoCol = New Entity.Registro.DocumentoJudicialCol
            'objDocumentoCol = ListarDocJud_x_Anulacion(InternoID, IngresoInpeID, -1, Codigo)

            'For Each fila As Entity.Registro.DocumentoJudicial In objDocumentoCol
            '    Dim objDod As New Entity.Registro.DocumentoJudicial
            '    objDod.Codigo = fila.Codigo
            '    objDod.IdDocumentoAntecedente = -1
            '    objDod.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal

            '    BssDoc.GrabarAnulacion(objDod)
            'Next

            Return intValue
        End Function

        Private Sub ActualizarDocumentosExpedientes(obj As Entity.Registro.DocumentoJudicial, InternoID As Integer)
            BssExp = New Bussines.Registro.Expediente
            bssDel = New Bussines.Registro.Delito
            bssAgr = New Bussines.Registro.InternoAgraviado

            obj.InternoId = InternoID
            obj.IdDocumentoAntecedente = -1
            obj.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
            BssDoc.GrabarAnulacion(obj)
            Dim entExpCol As New Entity.Registro.ExpedienteCol
            Dim entExp As New Entity.Registro.Expediente
            entExp.CreaDocJudicialId = obj.Codigo
            entExpCol = BssExp.Listar_v2(entExp)
            For Each exp As Entity.Registro.Expediente In entExpCol
                exp.InternoID = InternoID
                exp.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                BssExp.UpdateAnulacion(exp)

                Dim entDelCol As New Entity.Registro.DelitoCol
                Dim entDel As New Entity.Registro.Delito
                entDel.ExpedienteID = exp.Codigo
                entDelCol = bssDel.Listar2(entDel)
                For Each del As Entity.Registro.Delito In entDelCol
                    del.InternoID = InternoID
                    del.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                    bssDel.Grabar_Anu(del)

                    Dim entAgrCol As New Entity.Registro.AgraviadoCol
                    Dim entAgr As New Entity.Registro.Agraviado
                    entAgr.DelitoID = del.Codigo
                    entAgrCol = bssAgr.Listar(entAgr)
                    For Each Agr As Entity.Registro.Agraviado In entAgrCol
                        Agr.InternoID = InternoID
                        Agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                        bssAgr.Grabar_Anu(Agr)
                    Next
                Next
            Next
        End Sub

        Private Sub AnulacionExpedientesHijosBucle(Index As Integer, objExpediente As Entity.Registro.Expediente, DocumentoJudicialID As Integer, TipoDocID As Integer)
            Dim objBssExp As New Bussines.Registro.Expediente
            Dim objBssExpPad As New Bussines.Registro.InternoExpedientePadre
            Dim contaT As Integer = 0
            Dim contaP As Integer = 0
            Dim contaN As Integer = 0
            Dim objBssDelito As New Bussines.Registro.Delito
            Dim entD As Entity.Registro.Delito
            Dim entDcol As Entity.Registro.DelitoCol
            Dim entPadCol As Entity.Registro.InternoExpedientePadreCol
            Dim entPad As Entity.Registro.InternoExpedientePadre
            While Index > 0
                entD = New Entity.Registro.Delito
                entD.ExpedienteID = Index
                entDcol = New Entity.Registro.DelitoCol
                entDcol = objBssDelito.Listar2(entD)
                contaT = 0
                contaP = 0
                contaN = 0

                For Each ent As Entity.Registro.Delito In entDcol
                    If ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                        contaT += 1
                    ElseIf ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                        contaN += 1
                    Else
                        contaP += 1
                    End If
                Next
                If contaP = 0 And contaN = 0 Then
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                ElseIf contaP = 0 And contaT = 0 Then
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                Else
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                End If
                objExpediente.Codigo = Index
                'objExpediente.FlagTransferenciaSede = Me.FlagTransferSede
                Index = objBssExp.UpdateAnulacion(objExpediente)
                entPadCol = New Entity.Registro.InternoExpedientePadreCol
                entPad = New Entity.Registro.InternoExpedientePadre
                entPad.InternoExpedienteId = Index
                entPadCol = objBssExpPad.ListarGrilla(entPad)
                If entPadCol.Count = 0 Then
                    Index = -1
                ElseIf entPadCol.Count = 1 Then
                    Index = entPadCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                Else
                    For Each entPad_ As Entity.Registro.InternoExpedientePadre In entPadCol
                        AnulacionExpedientesHijos(entPad_.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad_.DocJudTipoPadre)
                    Next
                    Index = -1
                End If
            End While
        End Sub

        Private Sub AnulacionExpedientesHijosBucle_LM(Index As Integer, objExpediente As Entity.Registro.Expediente, DocumentoJudicialID As Integer, TipoDocID As Integer)
            Dim objBssExp As New Bussines.Registro.Expediente
            Dim objBssExpPad As New Bussines.Registro.InternoExpedientePadre
            Dim contaT As Integer = 0
            Dim contaP As Integer = 0
            Dim contaN As Integer = 0
            Dim objBssDelito As New Bussines.Registro.Delito
            Dim entD As Entity.Registro.Delito
            Dim entDcol As Entity.Registro.DelitoCol
            Dim entPadCol As Entity.Registro.InternoExpedientePadreCol
            Dim entPad As Entity.Registro.InternoExpedientePadre
            While Index > 0
                entD = New Entity.Registro.Delito
                entD.ExpedienteID = Index
                entDcol = New Entity.Registro.DelitoCol
                entDcol = objBssDelito.Listar2_LM(entD)
                contaT = 0
                contaP = 0
                contaN = 0

                For Each ent As Entity.Registro.Delito In entDcol
                    If ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                        contaT += 1
                    ElseIf ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                        contaN += 1
                    Else
                        contaP += 1
                    End If
                Next
                If contaP = 0 And contaN = 0 Then
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                ElseIf contaP = 0 And contaT = 0 Then
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                Else
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                End If
                objExpediente.Codigo = Index
                objExpediente.FlagTransferenciaSede = 1
                Index = objBssExp.UpdateAnulacion_LM(objExpediente)
                entPadCol = New Entity.Registro.InternoExpedientePadreCol
                entPad = New Entity.Registro.InternoExpedientePadre
                entPad.InternoExpedienteId = Index
                entPadCol = objBssExpPad.ListarGrilla(entPad)
                If entPadCol.Count = 0 Then
                    Index = -1
                ElseIf entPadCol.Count = 1 Then
                    Index = entPadCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                Else
                    For Each entPad_ As Entity.Registro.InternoExpedientePadre In entPadCol
                        AnulacionExpedientesHijos_LM(entPad_.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad_.DocJudTipoPadre)
                    Next
                    Index = -1
                End If
            End While
        End Sub

        Private Sub AnulacionExpedientesHijos(IndexExpe As Integer, objExpediente As Entity.Registro.Expediente, DocumentoJudicialID As Integer, TipoDocID As Integer)
            Dim objBssDelito As New Bussines.Registro.Delito
            Dim objBssExp As New Bussines.Registro.Expediente
            Dim objExpPad As Entity.Registro.InternoExpedientePadre
            Dim objEntPadCol As Entity.Registro.InternoExpedientePadreCol
            Dim objBssExpPad As Bussines.Registro.InternoExpedientePadre
            Dim contaTot = 0, contaPar = 0, contaNor = 0
            Dim entDcol As Entity.Registro.DelitoCol
            Dim entD As Entity.Registro.Delito
            Dim contaT As Integer = 0
            Dim contaP As Integer = 0
            Dim contaN As Integer = 0
            While IndexExpe > 0
                entD = New Entity.Registro.Delito
                objExpediente.Codigo = IndexExpe
                entD.ExpedienteID = IndexExpe
                objBssExpPad = New Bussines.Registro.InternoExpedientePadre
                If TipoDocID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    entDcol = New Entity.Registro.DelitoCol
                    entDcol = objBssDelito.Listar2(entD)
                    contaT = 0
                    contaP = 0
                    contaN = 0
                    For Each ent As Entity.Registro.Delito In entDcol
                        If ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                            contaT += 1
                        ElseIf ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                            contaN += 1
                        Else
                            contaP += 1
                        End If
                    Next
                    If contaP = 0 And contaN = 0 Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                    ElseIf contaP = 0 And contaT = 0 Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                    Else
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                    End If
                    'objExpediente.FlagTransferenciaSede = Me.FlagTransferSede
                    IndexExpe = objBssExp.UpdateAnulacion(objExpediente)
                    objEntPadCol = New Entity.Registro.InternoExpedientePadreCol
                    objExpPad = New Entity.Registro.InternoExpedientePadre
                    objExpPad.InternoExpedienteId = IndexExpe
                    objEntPadCol = objBssExpPad.ListarGrilla(objExpPad)
                    If objEntPadCol.Count = 0 Then
                        IndexExpe = -1
                    ElseIf objEntPadCol.Count = 1 Then
                        IndexExpe = objEntPadCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                        TipoDocID = objEntPadCol.InternoExpedientePadre(0).DocJudTipoPadre
                    Else
                        For Each entPad As Entity.Registro.InternoExpedientePadre In objEntPadCol
                            AnulacionExpedientesHijosBucle(entPad.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad.DocJudTipoPadre)
                        Next
                        IndexExpe = -1
                    End If
                Else
                    objExpPad = New Entity.Registro.InternoExpedientePadre
                    objExpPad.InternoExpedienteId = IndexExpe
                    objExpPad.InternoID = objExpediente.InternoID
                    objEntPadCol = New Entity.Registro.InternoExpedientePadreCol
                    objEntPadCol = objBssExpPad.ListarGrilla(objExpPad)
                    If objEntPadCol.Count = 0 Then
                        IndexExpe = -1
                    ElseIf objEntPadCol.Count = 1 Then
                        IndexExpe = objEntPadCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                        TipoDocID = objEntPadCol.InternoExpedientePadre(0).DocJudTipoPadre
                    Else ' mas de un hijo
                        For Each entPad As Entity.Registro.InternoExpedientePadre In objEntPadCol
                            AnulacionExpedientesHijosBucle(entPad.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad.DocJudTipoPadre)
                        Next
                        IndexExpe = -1
                    End If
                End If
            End While
        End Sub

        Private Sub AnulacionExpedientesHijos_LM(IndexExpe As Integer, objExpediente As Entity.Registro.Expediente, DocumentoJudicialID As Integer, TipoDocID As Integer)
            Dim objBssDelito As New Bussines.Registro.Delito
            Dim objBssExp As New Bussines.Registro.Expediente
            Dim objExpPad As Entity.Registro.InternoExpedientePadre
            Dim objEntPadCol As Entity.Registro.InternoExpedientePadreCol
            Dim objBssExpPad As Bussines.Registro.InternoExpedientePadre
            Dim contaTot = 0, contaPar = 0, contaNor = 0
            Dim entDcol As Entity.Registro.DelitoCol
            Dim entD As Entity.Registro.Delito
            Dim contaT As Integer = 0
            Dim contaP As Integer = 0
            Dim contaN As Integer = 0
            While IndexExpe > 0
                entD = New Entity.Registro.Delito
                objExpediente.Codigo = IndexExpe
                entD.ExpedienteID = IndexExpe
                objBssExpPad = New Bussines.Registro.InternoExpedientePadre
                If TipoDocID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    entDcol = New Entity.Registro.DelitoCol
                    entDcol = objBssDelito.Listar2_LM(entD)
                    contaT = 0
                    contaP = 0
                    contaN = 0
                    For Each ent As Entity.Registro.Delito In entDcol
                        If ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                            contaT += 1
                        ElseIf ent.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                            contaN += 1
                        Else
                            contaP += 1
                        End If
                    Next
                    If contaP = 0 And contaN = 0 Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                    ElseIf contaP = 0 And contaT = 0 Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                    Else
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                    End If
                    objExpediente.FlagTransferenciaSede = 1
                    IndexExpe = objBssExp.UpdateAnulacion_LM(objExpediente)
                    objEntPadCol = New Entity.Registro.InternoExpedientePadreCol
                    objExpPad = New Entity.Registro.InternoExpedientePadre
                    objExpPad.InternoExpedienteId = IndexExpe
                    objEntPadCol = objBssExpPad.ListarGrilla(objExpPad)
                    If objEntPadCol.Count = 0 Then
                        IndexExpe = -1
                    ElseIf objEntPadCol.Count = 1 Then
                        IndexExpe = objEntPadCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                        TipoDocID = objEntPadCol.InternoExpedientePadre(0).DocJudTipoPadre
                    Else
                        For Each entPad As Entity.Registro.InternoExpedientePadre In objEntPadCol
                            AnulacionExpedientesHijosBucle_LM(entPad.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad.DocJudTipoPadre)
                        Next
                        IndexExpe = -1
                    End If
                Else
                    objExpPad = New Entity.Registro.InternoExpedientePadre
                    objExpPad.InternoExpedienteId = IndexExpe
                    objExpPad.InternoID = objExpediente.InternoID
                    objEntPadCol = New Entity.Registro.InternoExpedientePadreCol
                    objEntPadCol = objBssExpPad.ListarGrilla(objExpPad)
                    If objEntPadCol.Count = 0 Then
                        IndexExpe = -1
                    ElseIf objEntPadCol.Count = 1 Then
                        IndexExpe = objEntPadCol.InternoExpedientePadre(0).InternoExpedienteRefPadreId
                        TipoDocID = objEntPadCol.InternoExpedientePadre(0).DocJudTipoPadre
                    Else ' mas de un hijo
                        For Each entPad As Entity.Registro.InternoExpedientePadre In objEntPadCol
                            AnulacionExpedientesHijosBucle_LM(entPad.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad.DocJudTipoPadre)
                        Next
                        IndexExpe = -1
                    End If
                End If
            End While
        End Sub

        Private Sub ActualizarAnulacion(DocumentoJudicialID As Integer, objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol, objEntDelitoTempoCol As Entity.Registro.DelitoCol, objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol)
            Dim contaT As Integer = 0, contaP As Integer = 0, contaN As Integer = 0
            Dim objBssExpPad As New Bussines.Registro.InternoExpedientePadre
            Dim objBssExp As New Bussines.Registro.Expediente

            For Each objExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol 'Empieza el bucle para registro
                Dim IdExpedienteOrig As Integer = objExpediente.Codigo
                Dim IdDocumentoOrig As Integer = objExpediente.CreaDocJudicialId
                Dim intIdExped As Integer = -1

                If DocumentoJudicialID = IdDocumentoOrig Then
                    objExpediente.Codigo = IdExpedienteOrig
                Else
                    objBssExp.GrabarEstadoVisibilidad(objExpediente.Codigo, False)
                    objExpediente.ExpedienteVisible = 1
                    objExpediente.CreaDocJudicialId = DocumentoJudicialID
                    objExpediente.Codigo = -1
                End If
                intIdExped = objBssExp.Grabar(objExpediente)
                '<---------------ExpedientePadre------------------------------
                Dim objIntExpPad As New Entity.Registro.InternoExpedientePadre
                Dim conDel As Integer = 0, conDelAnul As Integer = 0, conDelAnulpar As Integer = 0, intIdDel As Integer = -1
                '----------------------Registrar delitos-------------------------
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                    If objExpediente.Codigo = objDel.ExpedienteID Then
                        conDel = conDel + 1
                        Dim codDelitoOri As Integer = objDel.Codigo
                        Dim docDelitoOri As Integer = objDel.CreaDocJudicialId
                        objDel.ExpedienteID = intIdExped  'referencia al nuevo expediente
                        objDel.CreaDocJudicialId = DocumentoJudicialID
                        Dim objBssDelito As New Bussines.Registro.Delito
                        Dim objBssAgraviado As New Bussines.Registro.InternoAgraviado

                        intIdDel = objBssDelito.Grabar_v2(objDel)

                        Dim intIDAgrav As Integer = -1, conAgraviados As Integer = 0, conAgraAnul As Integer = 0

                        For Each objA As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                            If objDel.Codigo = objA.DelitoID Then
                                conAgraviados = conAgraviados + 1
                                Dim codAgraviadoOri As Integer = objA.Codigo
                                Dim creaAgraviadoOri As Integer = objA.CreaDocJudicialId
                                objA.DelitoID = intIdDel
                                objA.CreaDocJudicialId = DocumentoJudicialID
                                objA.ExpedienteID = intIdExped
                                objA.TipoSentenciaId = IIf(objA.TipoSentenciaId = 0, -1, objA.TipoSentenciaId)
                                objA.TipoSentenciaHistoricoId = IIf(objA.TipoSentenciaHistoricoId = 0, -1, objA.TipoSentenciaHistoricoId)
                                objA.RegionID = objExpediente._RegionId
                                objA.PenalID = objExpediente._PenalId

                                intIDAgrav = objBssAgraviado.Grabar(objA)
                                ''''''''''''''''''''Fin de registro de Agraviados''''''''''''''''''''''''''''''''''''''''
                                While intIDAgrav > 0
                                    Dim entCol As New Entity.Registro.AgraviadoCol
                                    Dim entA As New Entity.Registro.Agraviado
                                    entA.Codigo = intIDAgrav
                                    entCol = objBssAgraviado.Listar(entA)
                                    If entCol.Item(0).CodigoagraviadoPad > 0 And entCol.Item(0).DocumentoTipoID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                        entA.Anulacion = objA.Anulacion
                                        entA.InternoID = objA.InternoID
                                        entA.Codigo = entCol.Item(0).CodigoagraviadoPad  'ent.FlagTransferenciaSede = Me.FlagTransferSede
                                        objBssAgraviado.GrabarEstado(entA)
                                    End If
                                    intIDAgrav = entCol.Item(0).CodigoagraviadoPad
                                End While
                                If objA.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                    conAgraAnul += 1
                                End If
                            End If
                        Next
                        If conAgraviados > 0 And conAgraviados = conAgraAnul Then
                            objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                        ElseIf conAgraAnul > 0 And conAgraAnul < conAgraviados Then
                            objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                        Else
                            objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                        End If
                        objDel.Codigo = intIdDel
                        intIdDel = objBssDelito.Grabar_Anu(objDel)
                        While intIdDel > 0
                            Dim entDCol As New Entity.Registro.DelitoCol
                            Dim entD As New Entity.Registro.Delito
                            entD.Codigo = intIdDel
                            entDCol = objBssDelito.Listar2(entD)
                            If entDCol.Count > 0 Then
                                If entDCol.internoDelito(0).CodigodelitoPad > 0 And entDCol.internoDelito(0).DocumentoTipoID <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                    Dim entAgrCol As New Entity.Registro.AgraviadoCol
                                    Dim entA As New Entity.Registro.Agraviado
                                    entA.DelitoID = entDCol.internoDelito(0).CodigodelitoPad
                                    entAgrCol = objBssAgraviado.Listar(entA)

                                    Dim conT As Integer = 0, conP As Integer = 0

                                    For Each agr As Entity.Registro.Agraviado In entAgrCol
                                        If agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                            conT += 1
                                        Else
                                            conP += 1
                                        End If
                                    Next
                                    If conP = 0 Then
                                        entD.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                    ElseIf conT = 0 Then
                                        conT = Type.Enumeracion.enmEstadoAnulado.Normal
                                    Else
                                        entD.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                    End If
                                    ''entD.FlagTransferenciaSede = Me.FlagTransferSede
                                    entD.InternoID = entDCol.internoDelito(0).InternoID
                                    entD.Codigo = entDCol.internoDelito(0).CodigodelitoPad
                                    objBssDelito.Grabar_Anu(entD)
                                    intIdDel = entDCol.internoDelito(0).CodigodelitoPad

                                Else 'entACol.internoDelito(0).Codigo=-1
                                    intIdDel = entDCol.internoDelito(0).CodigodelitoPad
                                End If
                            Else
                                intIdDel = -1
                            End If
                        End While
                        If objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                            conDelAnul = conDelAnul + 1
                        ElseIf objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                            conDelAnulpar = conDelAnulpar + 1
                        End If
                    End If
                Next
                If conDel > 0 And conDel = conDelAnul Then  'revisar de nuevo
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                ElseIf conDelAnul > 0 And conDelAnul < conDel Then
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                ElseIf conDelAnul = 0 And conDelAnulpar > 0 Then
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                Else
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                End If
                '*************Actualizacion anulacion Exp**********************************************
                objExpediente.Codigo = intIdExped
                intIdExped = objBssExp.UpdateAnulacion(objExpediente)

                objIntExpPad = New Entity.Registro.InternoExpedientePadre
                objIntExpPad.InternoExpedienteId = intIdExped
                objIntExpPad.InternoID = objExpediente.InternoID
                Dim entExpPadCol As New Entity.Registro.InternoExpedientePadreCol
                entExpPadCol = objBssExpPad.ListarGrilla(objIntExpPad)
                '*******Actualizar los expedientes padres*******************
                If entExpPadCol.Count > 0 Then
                    For Each entPad As Entity.Registro.InternoExpedientePadre In entExpPadCol

                        AnulacionExpedientesHijos(entPad.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad.DocJudTipoPadre)

                    Next
                End If
            Next
            '********Anular documentos**************
            Dim objDocAnuCol As New Entity.Registro.DocumentoJudicialCol
            Dim objDocAnu As New Entity.Registro.DocumentoJudicial
            Dim objExpAnuCol As Entity.Registro.ExpedienteCol
            Dim objDoc As New Entity.Registro.DocumentoJudicial

            objDocAnu.InternoId = objEntExpedienteTempoCol.Expediente(0).InternoID
            objDocAnu.InternoIngresoId = objEntExpedienteTempoCol.Expediente(0).IngresoID
            objDocAnuCol = BssDoc.ListarGrilla(objDocAnu)

            For Each objD As Entity.Registro.DocumentoJudicial In objDocAnuCol
                contaT = 0
                contaP = 0
                contaN = 0
                Dim objExpAnu As New Entity.Registro.Expediente
                objExpAnu.InternoID = objEntExpedienteTempoCol.Expediente(0).InternoID
                objExpAnu.IngresoID = objEntExpedienteTempoCol.Expediente(0).IngresoID
                objExpAnu.CreaDocJudicialId = objD.Codigo
                objExpAnuCol = New Entity.Registro.ExpedienteCol
                objExpAnuCol = objBssExp.Listar_v2(objExpAnu)
                For Each objE As Entity.Registro.Expediente In objExpAnuCol
                    If objE.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                        contaT += 1
                    ElseIf objE.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                        contaP += 1
                    Else
                        contaN += 1
                    End If
                Next

                If contaT = 0 And contaP = 0 And contaN > 0 Then
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal  'normal
                ElseIf contaT > 0 And contaP = 0 And contaN = 0 Then
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total  ' total
                ElseIf contaT = 0 And contaP > 0 Then
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial
                ElseIf contaT > 0 And contaP = 0 And contaN > 0 Then
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial
                ElseIf contaT > 0 And contaP > 0 And contaN = 0 Then
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial

                End If
                If objD.DocumentoTipo <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    If objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal Then
                        objDoc.IdDocumentoAntecedente = -1
                    Else
                        objDoc.IdDocumentoAntecedente = DocumentoJudicialID
                    End If
                Else
                    objDoc.IdDocumentoAntecedente = -1
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal  'normal
                End If
                If objD.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    If objD.Codigo = DocumentoJudicialID Then
                        objDoc.Codigo = objD.Codigo
                        BssDoc.GrabarAnulacion(objDoc)
                    End If
                ElseIf objD.DocumentoTipo <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    If objExpAnuCol.Count > 0 Then
                        objDoc.Codigo = objD.Codigo
                        BssDoc.GrabarAnulacion(objDoc)
                    End If
                End If
            Next
        End Sub

        Private Sub ActualizarAnulacion_LM(DocumentoJudicialID As Integer, objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol, objEntDelitoTempoCol As Entity.Registro.DelitoCol, objEntAgraviadoTempoCol As Entity.Registro.AgraviadoCol)
            Dim contaT As Integer = 0, contaP As Integer = 0, contaN As Integer = 0
            Dim objBssExpPad As New Bussines.Registro.InternoExpedientePadre
            Dim objBssExp As New Bussines.Registro.Expediente

            For Each objExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol 'Empieza el bucle para registro
                Dim IdExpedienteOrig As Integer = objExpediente.Codigo
                Dim IdDocumentoOrig As Integer = objExpediente.CreaDocJudicialId
                Dim intIdExped As Integer = -1

                If DocumentoJudicialID = IdDocumentoOrig Then
                    objExpediente.Codigo = IdExpedienteOrig
                Else
                    objBssExp.GrabarEstadoVisibilidad_LM(objExpediente.Codigo, True)
                    objExpediente.ExpedienteVisible = 1
                    objExpediente.CreaDocJudicialId = DocumentoJudicialID
                    objExpediente.Codigo = -1
                End If
                objExpediente.FlagTransferenciaSede = 1
                intIdExped = objBssExp.Grabar_LM(objExpediente)
                '<---------------ExpedientePadre------------------------------
                Dim objIntExpPad As New Entity.Registro.InternoExpedientePadre
                Dim conDel As Integer = 0, conDelAnul As Integer = 0, conDelAnulpar As Integer = 0, intIdDel As Integer = -1
                '----------------------Registrar delitos-------------------------
                For Each objDel As Entity.Registro.Delito In objEntDelitoTempoCol
                    If objExpediente.Codigo = objDel.ExpedienteID Then
                        conDel = conDel + 1
                        Dim codDelitoOri As Integer = objDel.Codigo
                        Dim docDelitoOri As Integer = objDel.CreaDocJudicialId
                        objDel.ExpedienteID = intIdExped  'referencia al nuevo expediente
                        objDel.CreaDocJudicialId = DocumentoJudicialID
                        objDel.FlagTransferenciaSede = 1
                        Dim objBssDelito As New Bussines.Registro.Delito
                        Dim objBssAgraviado As New Bussines.Registro.InternoAgraviado

                        intIdDel = objBssDelito.Grabar_LM(objDel)

                        Dim intIDAgrav As Integer = -1, conAgraviados As Integer = 0, conAgraAnul As Integer = 0

                        For Each objA As Entity.Registro.Agraviado In objEntAgraviadoTempoCol
                            If objDel.Codigo = objA.DelitoID Then
                                conAgraviados = conAgraviados + 1
                                Dim codAgraviadoOri As Integer = objA.Codigo
                                Dim creaAgraviadoOri As Integer = objA.CreaDocJudicialId
                                objA.DelitoID = intIdDel
                                objA.CreaDocJudicialId = DocumentoJudicialID
                                objA.ExpedienteID = intIdExped
                                objA.TipoSentenciaId = IIf(objA.TipoSentenciaId = 0, -1, objA.TipoSentenciaId)
                                objA.TipoSentenciaHistoricoId = IIf(objA.TipoSentenciaHistoricoId = 0, -1, objA.TipoSentenciaHistoricoId)
                                objA.RegionID = objExpediente._RegionId
                                objA.PenalID = objExpediente._PenalId
                                objA.FlagTransferenciaSede = 1

                                intIDAgrav = objBssAgraviado.Grabar_LM(objA)
                                ''''''''''''''''''''Fin de registro de Agraviados''''''''''''''''''''''''''''''''''''''''
                                While intIDAgrav > 0
                                    Dim entCol As New Entity.Registro.AgraviadoCol
                                    Dim entA As New Entity.Registro.Agraviado
                                    entA.Codigo = intIDAgrav
                                    entCol = objBssAgraviado.Listar(entA)
                                    If entCol.Count > 0 Then
                                        If entCol.Item(0).CodigoagraviadoPad > 0 And entCol.Item(0).DocumentoTipoID <> enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                            entA.Anulacion = objA.Anulacion
                                            entA.InternoID = objA.InternoID
                                            entA.Codigo = entCol.Item(0).CodigoagraviadoPad  'ent.FlagTransferenciaSede = Me.FlagTransferSede
                                            entA.FlagTransferenciaSede = 1
                                            objBssAgraviado.GrabarEstado(entA)
                                        End If
                                        intIDAgrav = entCol.Item(0).CodigoagraviadoPad
                                    Else
                                        intIDAgrav = -1
                                    End If
                                End While
                                If objA.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                    conAgraAnul += 1
                                End If
                            End If
                        Next
                        If conAgraviados > 0 And conAgraviados = conAgraAnul Then
                            objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                        ElseIf conAgraAnul > 0 And conAgraAnul < conAgraviados Then
                            objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                        Else
                            objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                        End If
                        objDel.Codigo = intIdDel
                        objDel.FlagTransferenciaSede = 1
                        intIdDel = objBssDelito.Grabar_Anu_LM(objDel)
                        While intIdDel > 0
                            Dim entDCol As New Entity.Registro.DelitoCol
                            Dim entD As New Entity.Registro.Delito
                            entD.Codigo = intIdDel
                            entDCol = objBssDelito.Listar2(entD)
                            If entDCol.Count > 0 Then
                                If entDCol.internoDelito(0).CodigodelitoPad > 0 And entDCol.internoDelito(0).DocumentoTipoID <> enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                                    Dim entAgrCol As New Entity.Registro.AgraviadoCol
                                    Dim entA As New Entity.Registro.Agraviado
                                    entA.DelitoID = entDCol.internoDelito(0).CodigodelitoPad
                                    entAgrCol = objBssAgraviado.Listar(entA)

                                    Dim conT As Integer = 0, conP As Integer = 0

                                    For Each agr As Entity.Registro.Agraviado In entAgrCol
                                        If agr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                            conT += 1
                                        Else
                                            conP += 1
                                        End If
                                    Next
                                    If conP = 0 Then
                                        entD.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                    ElseIf conT = 0 Then
                                        conT = Type.Enumeracion.enmEstadoAnulado.Normal
                                    Else
                                        entD.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                    End If
                                    ''entD.FlagTransferenciaSede = Me.FlagTransferSede
                                    entD.InternoID = entDCol.internoDelito(0).InternoID
                                    entD.Codigo = entDCol.internoDelito(0).CodigodelitoPad
                                    entD.FlagTransferenciaSede = 1
                                    objBssDelito.Grabar_Anu_LM(entD)
                                    intIdDel = entDCol.internoDelito(0).CodigodelitoPad

                                Else 'entACol.internoDelito(0).Codigo=-1
                                    intIdDel = entDCol.internoDelito(0).CodigodelitoPad
                                End If
                            Else
                                intIdDel = -1
                            End If
                        End While
                        If objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                            conDelAnul = conDelAnul + 1
                        ElseIf objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                            conDelAnulpar = conDelAnulpar + 1
                        End If
                    End If
                Next
                If conDel > 0 And conDel = conDelAnul Then  'revisar de nuevo
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                ElseIf conDelAnul > 0 And conDelAnul < conDel Then
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                ElseIf conDelAnul = 0 And conDelAnulpar > 0 Then
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                Else
                    objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                End If
                '*************Actualizacion anulacion Exp**********************************************
                objExpediente.Codigo = intIdExped
                objExpediente.FlagTransferenciaSede = 1
                intIdExped = objBssExp.UpdateAnulacion_LM(objExpediente)

                objIntExpPad = New Entity.Registro.InternoExpedientePadre
                objIntExpPad.InternoExpedienteId = intIdExped
                objIntExpPad.InternoID = objExpediente.InternoID
                Dim entExpPadCol As New Entity.Registro.InternoExpedientePadreCol
                entExpPadCol = objBssExpPad.ListarGrilla(objIntExpPad)
                '*******Actualizar los expedientes padres*******************
                If entExpPadCol.Count > 0 Then
                    For Each entPad As Entity.Registro.InternoExpedientePadre In entExpPadCol

                        AnulacionExpedientesHijos_LM(entPad.InternoExpedienteRefPadreId, objExpediente, DocumentoJudicialID, entPad.DocJudTipoPadre)

                    Next
                End If
            Next
            '********Anular documentos**************
            Dim objDocAnuCol As New Entity.Registro.DocumentoJudicialCol
            Dim objDocAnu As New Entity.Registro.DocumentoJudicial
            Dim objExpAnuCol As Entity.Registro.ExpedienteCol
            Dim objDoc As New Entity.Registro.DocumentoJudicial

            objDocAnu.InternoId = objEntExpedienteTempoCol.Expediente(0).InternoID
            objDocAnu.InternoIngresoId = objEntExpedienteTempoCol.Expediente(0).IngresoID
            objDocAnuCol = BssDoc.ListarGrilla(objDocAnu)

            objDoc.FlagTransferenciaSede = 1

            For Each objD As Entity.Registro.DocumentoJudicial In objDocAnuCol
                contaT = 0
                contaP = 0
                contaN = 0
                Dim objExpAnu As New Entity.Registro.Expediente
                objExpAnu.InternoID = objEntExpedienteTempoCol.Expediente(0).InternoID
                objExpAnu.IngresoID = objEntExpedienteTempoCol.Expediente(0).IngresoID
                objExpAnu.CreaDocJudicialId = objD.Codigo
                objExpAnuCol = New Entity.Registro.ExpedienteCol
                objExpAnuCol = objBssExp.Listar_v2(objExpAnu)
                For Each objE As Entity.Registro.Expediente In objExpAnuCol
                    If objE.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                        contaT += 1
                    ElseIf objE.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                        contaP += 1
                    Else
                        contaN += 1
                    End If
                Next

                If contaT = 0 And contaP = 0 And contaN > 0 Then
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal  'normal
                ElseIf contaT > 0 And contaP = 0 And contaN = 0 Then
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total  ' total
                ElseIf contaT = 0 And contaP > 0 Then
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial
                ElseIf contaT > 0 And contaP = 0 And contaN > 0 Then
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial
                ElseIf contaT > 0 And contaP > 0 And contaN = 0 Then
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial  ' parcial

                End If
                If objD.DocumentoTipo <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    If objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal Then
                        objDoc.IdDocumentoAntecedente = -1
                    Else
                        objDoc.IdDocumentoAntecedente = DocumentoJudicialID
                    End If
                Else
                    objDoc.IdDocumentoAntecedente = -1
                    objDoc.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal  'normal
                End If
                If objD.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    If objD.Codigo = DocumentoJudicialID Then
                        objDoc.Codigo = objD.Codigo
                        BssDoc.GrabarAnulacion_LM(objDoc)
                    End If
                ElseIf objD.DocumentoTipo <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    If objExpAnuCol.Count > 0 Then
                        objDoc.Codigo = objD.Codigo
                        BssDoc.GrabarAnulacion_LM(objDoc)
                    End If
                End If
            Next
        End Sub

        Public Function Eliminar_LM(ByVal Codigo As Integer, TipoDoc As Integer, SubTipoDoc As Integer, InternoID As Integer, IngresoInpeID As Integer,
                                    Optional ByRef sms As String = "", Optional n_ActivarFlagTransferSede As Integer = 0) As Integer

            Dim objEntExpCol As New Entity.Registro.ExpedienteCol
            BssDoc = New Bussines.Registro.DocumentoJudicial

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            Dim IngresoID As Integer = -1

            strAccion = "del"
            strOpcion = "del_mant_LM"
            '----------------- ------------------------------------------------------ ------------->

            Select Case TipoDoc
                Case enumTipoDocumentoJudicial.Avocamiento

                    BssExp = New Bussines.Registro.Expediente
                    BssPad = New Bussines.Registro.InternoExpedientePadre

                    objEntExpCol = BssExp.ListarExpedientexResolucion_LM(Codigo)
                    Dim ObjExpediente1 As New Entity.Registro.Expediente

                    intValue = Data.Registro.DocumentoJudicial.Eliminar_LM(strAccion, strOpcion, Codigo, InternoID, IngresoID, n_ActivarFlagTransferSede)

                    BssExp.GrabarEstadoVisibilidad_LM(ObjExpediente1.Codigo, False, n_ActivarFlagTransferSede)
                    BssExp.Eliminar_LM(ObjExpediente1.Codigo, n_ActivarFlagTransferSede)
                    Dim EntExpPadr As New Entity.Registro.InternoExpedientePadre
                    EntExpPadr.InternoExpedienteId = ObjExpediente1.Codigo

                    Dim CodigoPad As Integer = BssPad.ListarGrilla_LM(EntExpPadr).Count
                    If CodigoPad > 0 Then
                        BssExp.GrabarEstadoVisibilidad_LM(CodigoPad, True, n_ActivarFlagTransferSede)
                    End If

                Case enumTipoDocumentoJudicial.Aclaratoria, enumTipoDocumentoJudicial.Ampliacion_Autoapertorio

                    intValue = Data.Registro.DocumentoJudicial.Eliminar_LM(strAccion, strOpcion, Codigo, InternoID, IngresoInpeID, n_ActivarFlagTransferSede)
                    Dim bssNA As New Bussines.Registro.NombreAsociado
                    Dim bssDocNA As New Bussines.Registro.Documento.NombresAsociados
                    bssDocNA.Eliminar_LM(Codigo, InternoID, IngresoInpeID)

                Case enumTipoDocumentoJudicial.Sentencia

                    Dim bssNA As New Bussines.Registro.NombreAsociado
                    Dim bssDocNA As New Bussines.Registro.Documento.NombresAsociados
                    bssDocNA.EliminarDocumentoNA_LM(Codigo, InternoID, IngresoInpeID)

                    intValue = Data.Registro.DocumentoJudicial.Eliminar_LM(strAccion, strOpcion, Codigo, InternoID, IngresoInpeID, n_ActivarFlagTransferSede)

                Case enumTipoDocumentoJudicial.Ingreso

                    Dim objBssMov As New Bussines.Registro.InternoMovimiento

                    If objBssMov.movimientoReferenciadoConDocumentoJud(InternoID, IngresoInpeID, -1, Codigo) = True Then
                        sms = "No se puede eliminar el documento de ingreso, se encuentra referenciado con el movimiento del E.P. (realizado en Lima Metropolitana)."

                    Else

                        intValue = Data.Registro.DocumentoJudicial.Eliminar_LM(strAccion, strOpcion, Codigo, InternoID, IngresoID, n_ActivarFlagTransferSede)

                        Dim EntDoc As New Entity.Registro.DocumentoJudicial
                        With EntDoc
                            .InternoId = InternoID
                            .InternoIngresoId = IngresoID
                        End With

                        If SubTipoDoc = enumSubTipo.IngresoTraslado Then
                            EntDoc.DocumentoSubTipoId = enumSubTipo.IngresoTraslado
                        End If

                        EntDoc = BssDoc.Listar_v2_LM(EntDoc)
                    End If

                Case enumTipoDocumentoJudicial.Libertad

                    Dim objBssMov As New Bussines.Registro.InternoMovimiento

                    If objBssMov.movimientoReferenciadoConDocumentoJud(InternoID, IngresoInpeID, -1, Codigo) = True Then
                        sms = "No se puede eliminar el documento de libertad, se encuentra referenciado con el movimiento del E.P. (realizado en Lima Metropolitana)."
                    Else
                        intValue = Data.Registro.DocumentoJudicial.Eliminar_LM(strAccion, strOpcion, Codigo, InternoID, IngresoInpeID, n_ActivarFlagTransferSede)
                        If intValue > 0 Then
                            Data.Registro.DocumentoJudicial.Eliminar_x_Queda("del", "del_queda_lm", intValue, InternoID, IngresoID, -1)
                        End If
                        Dim EntDoc As New Entity.Registro.DocumentoJudicial
                        With EntDoc
                            .InternoId = InternoID
                            .InternoIngresoId = IngresoID
                        End With
                    End If

                Case enumTipoDocumentoJudicial.Anulacion_Antecedentes

                    intValue = EliminarAntecedentes_LM(Codigo, TipoDoc, SubTipoDoc, InternoID, IngresoInpeID, sms, n_ActivarFlagTransferSede)

                Case Else

                    intValue = Data.Registro.DocumentoJudicial.Eliminar_LM(strAccion, strOpcion, Codigo, InternoID, IngresoID, n_ActivarFlagTransferSede)
            End Select

            Return intValue
        End Function

        Private Sub EliminarIninputables(TipoDoc As Integer, Codigo As Integer, InternoID As Integer, n_ActivarFlagTransferSede As Integer)
            Select Case TipoDoc
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionConsentida,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema
                    Dim bss As New Bussines.Registro.InternoInimputable
                    bss.Eliminar(Codigo, InternoID, n_ActivarFlagTransferSede)
            End Select
        End Sub

        Private Sub LimpiarAnulaciones(Codigo As Integer, InternoID As Integer, IngresoInpeID As Integer, objExpCol As Entity.Registro.ExpedienteCol)
            Dim intConta As Integer = -1
            Dim intContador As Integer = -1
            Dim blnValor As Boolean = False
            Dim objExpediente As Entity.Registro.Expediente
            Dim objDelito As New Entity.Registro.Delito
            Dim objExpedienteCol As New Entity.Registro.ExpedienteCol
            Dim objDelCol As New Entity.Registro.DelitoCol
            Dim objAgrCol As New Entity.Registro.AgraviadoCol
            Dim ExpId As Integer = -1
            Dim DelId As Integer = -1
            Dim AgrId As Integer = -1
            Dim objCol As New Entity.Registro.DocumentoJudicialCol
            Dim objDocumentoCol As New Entity.Registro.DocumentoJudicialCol
            For Each objExp As Entity.Registro.Expediente In objExpCol
                ExpId = objExp.Codigo
                intConta = -1
                intContador = -1
                While ExpId > 0
                    intConta = intConta + 1
                    ''1. Listar delitos
                    objExpediente = New Entity.Registro.Expediente
                    objExpediente.Codigo = ExpId
                    objExpediente.InternoID = objExp.InternoID

                    objDelito.ExpedienteID = ExpId
                    objDelito.InternoID = objExp.InternoID
                    'Realizar un proceso por expediente visible
                    If intConta = 0 Then
                        objDelCol = bssDel.Listar2(objDelito)
                        For Each objDel As Entity.Registro.Delito In objDelCol
                            DelId = objDel.Codigo
                            intContador = -1
                            While DelId > 0
                                intContador += 1
                                Dim objDel1 As New Entity.Registro.Delito
                                objDel1.Codigo = DelId
                                objDel1.InternoID = objDel.InternoID
                                'obtener los agraviados
                                Dim objAgr1 As New Entity.Registro.Agraviado
                                objAgr1.DelitoID = DelId
                                objAgr1.InternoID = objExp.InternoID
                                If intContador = 0 Then
                                    'Listar y Actualizar los agraviados padres
                                    objAgrCol = bssAgr.Listar_v3(objAgr1)
                                    For Each objAgr As Entity.Registro.Agraviado In objAgrCol
                                        AgrId = objAgr.Codigo
                                        While AgrId > 0
                                            objAgr1 = New Entity.Registro.Agraviado
                                            objAgr1.Codigo = AgrId
                                            objAgr1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                            objAgr1.InternoID = objAgr.InternoID
                                            bssAgr.Grabar_Anu(objAgr1)
                                            Dim ColAgr As New Entity.Registro.AgraviadoCol
                                            ColAgr = bssAgr.Listar_v3(objAgr1)
                                            If ColAgr.Count = 0 Then
                                                AgrId = -1
                                            Else
                                                AgrId = bssAgr.Listar_v3(objAgr1).Item(0).CodigoagraviadoPad
                                            End If
                                        End While
                                    Next
                                End If
                                'Contabilizar las anulaciones del agraviado
                                Dim Tot As Integer = 0
                                Dim Nor As Integer = 0
                                objAgrCol = bssAgr.Listar_v3(objAgr1)
                                For Each objAgr As Entity.Registro.Agraviado In objAgrCol
                                    If objAgr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                                        Nor += 1
                                    ElseIf objAgr.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                                        Tot += 1
                                    End If
                                Next
                                If Tot > 0 And Nor = 0 Then
                                    objDel1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                                ElseIf Tot = 0 And Nor > 0 Then
                                    objDel1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                                Else
                                    objDel1.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                                End If
                                'Actualizar estado del delito
                                bssDel.Grabar_Anu(objDel1)

                                'Obtener padre del delito
                                Dim ColDel As New Entity.Registro.DelitoCol
                                ColDel = bssDel.Listar2(objDel1)
                                If ColDel.Count = 0 Then
                                    DelId = -1
                                Else
                                    DelId = ColDel.internoDelito(0).CodigodelitoPad
                                End If
                            End While
                        Next
                    End If
                    'Contabilizar los estados de los delitos
                    Dim contot As Integer = 0
                    Dim conpar As Integer = 0
                    Dim connor As Integer = 0
                    objDelCol = bssDel.Listar2(objDelito)
                    For Each objDel As Entity.Registro.Delito In objDelCol
                        If objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                            connor += 1
                        ElseIf objDel.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                            contot += 1
                        Else
                            conpar += 1
                        End If
                    Next
                    If contot > 0 And conpar = 0 And connor = 0 Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total
                    ElseIf contot = 0 And conpar = 0 And connor > 0 Then
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal
                    Else
                        objExpediente.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial
                    End If
                    'Actualizacion estado del expediente
                    BssExp.UpdateAnulacion(objExpediente)
                    ' obtener expediente padre
                    Dim objpad As New Entity.Registro.InternoExpedientePadre
                    objpad.InternoExpedienteId = objExpediente.Codigo
                    objpad.InternoID = objExp.InternoID
                    objpad = (New Bussines.Registro.InternoExpedientePadre).Listar(objpad)

                    If objpad.InternoExpedienteRefPadreId < 1 Then
                        ExpId = -1
                    Else
                        ExpId = objpad.InternoExpedienteRefPadreId

                        Dim objdoc2 As New Entity.Registro.DocumentoJudicial
                        objExpediente = New Entity.Registro.Expediente
                        objExpediente.Codigo = ExpId
                        objExpediente.InternoID = objExp.InternoID
                        objdoc2.Codigo = (New Bussines.Registro.Expediente).Listar_v2(objExpediente).Item(0).CreaDocJudicialId
                        objDocumentoCol.Add(objdoc2)
                    End If
                End While
            Next
            For Each objDoc1 As Entity.Registro.DocumentoJudicial In objDocumentoCol
                blnValor = True
                For Each obj As Entity.Registro.DocumentoJudicial In objCol
                    If objDoc1.Codigo = obj.Codigo Then
                        blnValor = False
                        Exit For
                    End If
                Next
                If blnValor = True Then
                    objCol.Add(objDoc1)

                    objExpedienteCol = BssExp.ListarExpedientexResolucion(objDoc1.Codigo)
                    Dim contaTot As Integer = 0
                    Dim contaPar As Integer = 0
                    Dim contaNor As Integer = 0
                    For Each obj As Entity.Registro.Expediente In objExpedienteCol
                        If obj.Anulacion = Type.Enumeracion.enmEstadoAnulado.Normal Then
                            contaNor += 1
                        ElseIf obj.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                            contaPar += 1
                        ElseIf obj.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                            contaTot += 1
                        End If
                    Next
                    Dim objDod As New Entity.Registro.DocumentoJudicial
                    objDod.Codigo = objDoc1.Codigo
                    If contaNor > 0 And contaPar = 0 And contaTot = 0 Then
                        objDod.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                    ElseIf contaNor = 0 And contaPar = 0 And contaTot > 0 Then
                        objDod.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total
                    Else
                        objDod.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_parcial
                    End If

                    BssDoc.GrabarAnulacion(objDod)
                End If
            Next

            'LISTAR LOS DOCUMENTOS RELACIONADOS AL DOCUMENTO ANTECEDENTES
            objDocumentoCol = New Entity.Registro.DocumentoJudicialCol
            objDocumentoCol = ListarDocJud_x_Anulacion(InternoID, -1, IngresoInpeID, Codigo)

            For Each fila As Entity.Registro.DocumentoJudicial In objDocumentoCol
                Dim objDod As New Entity.Registro.DocumentoJudicial
                objDod.Codigo = fila.Codigo
                objDod.IdDocumentoAntecedente = -1
                objDod.Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal

                BssDoc.GrabarAnulacion(objDod)
            Next
        End Sub

        Public Function Eliminar_x_Queda(ByVal strAccion As String, ByVal strOpcion As String, ByVal Codigo As Integer, ByVal InternoId As Integer, ByVal IngresoId As Integer, Optional n_ActivarFlagTransferSede As Integer = 0) As Integer
            Dim intValue As Integer
            intValue = Data.Registro.DocumentoJudicial.Eliminar_x_Queda(strAccion, strOpcion, Codigo, InternoId, IngresoId, n_ActivarFlagTransferSede)
            Return intValue
        End Function
#End Region

#Region "REG_DOC_DocJudicialExpediente"

        Public Function Listar_DocumentosJudicialesMovimientos_LM(objDocJudExpe As Entity.Registro.DocumentoJudicial,
                                                       Optional blnVerDocumentoAnulados As Boolean = True) As Entity.Registro.DocumentoJudicialCol
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim objEnt As Entity.Registro.DocumentoJudicial = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar_LM(sqlCon, "lst", "lst_documentosjudicialesmovimientos_LM", objDocJudExpe)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoTipoNombre = sqlDr("doc_tip_nom").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                            .DistritoJudicial = sqlDr("aut_jud_id").ToString
                            .DistritoJudNombre = sqlDr("aut_jud_nom").ToString
                            .SalaJuzgado = sqlDr("sal_jud_id").ToString
                            .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                            .JuezNombre = sqlDr("doc_jud_jue").ToString
                            .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                            .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString

                            'mostrar el origen otro, si el penal de origen es vacio
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .PenalOtroOrigenNom = sqlDr("pen_ori_otr").ToString

                            If .PenalOrigenNom.Length < 2 Then
                                .PenalOrigenNom = .PenalOtroOrigenNom
                            End If

                            'mostrar el destino otro, si el penal destino es vacio
                            .RegionDestinoId = sqlDr("reg_des_id").ToString
                            .PenalDestinoid = sqlDr("pen_des_id").ToString
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
                            .PenalDestinoOtroNom = sqlDr("pen_des_otr").ToString

                            If .PenalDestinoNom.Length < 2 Then
                                .PenalDestinoNom = .PenalDestinoOtroNom
                            End If

                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .IdDocumentoAntecedente = sqlDr("n_anu_id").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString
                        End With

                        If blnVerDocumentoAnulados = True Then
                            objEntCol.Add(objEnt)
                        Else

                            If objEnt.Estado < 3 Then 'solo los no anulados, 1=no anulado,2=parcial
                                objEntCol.Add(objEnt)
                            End If

                        End If

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
            Return objEntCol
        End Function

        Public Function Listar_DocumentosJudiciales_LM(objDocJudExpe As Entity.Registro.DocumentoJudicial,
                                                       Optional blnVerDocumentoAnulados As Boolean = True) As Entity.Registro.DocumentoJudicialCol
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim objEnt As Entity.Registro.DocumentoJudicial = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar_LM(sqlCon, "lst", "lst_grilla_documentos_judiciales_LM", objDocJudExpe)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoTipoNombre = sqlDr("doc_tip_nom").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                            .DistritoJudicial = sqlDr("aut_jud_id").ToString
                            .DistritoJudNombre = sqlDr("aut_jud_nom").ToString
                            .SalaJuzgado = sqlDr("sal_jud_id").ToString
                            .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                            .JuezNombre = sqlDr("doc_jud_jue").ToString
                            .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                            .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString

                            'mostrar el origen otro, si el penal de origen es vacio
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .PenalOtroOrigenNom = sqlDr("pen_ori_otr").ToString

                            If .PenalOrigenNom.Length < 2 Then
                                .PenalOrigenNom = .PenalOtroOrigenNom
                            End If

                            'mostrar el destino otro, si el penal destino es vacio
                            .RegionDestinoId = sqlDr("reg_des_id").ToString
                            .PenalDestinoid = sqlDr("pen_des_id").ToString
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
                            .PenalDestinoOtroNom = sqlDr("pen_des_otr").ToString

                            If .PenalDestinoNom.Length < 2 Then
                                .PenalDestinoNom = .PenalDestinoOtroNom
                            End If

                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .IdDocumentoAntecedente = sqlDr("n_anu_id").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString
                        End With

                        If blnVerDocumentoAnulados = True Then
                            objEntCol.Add(objEnt)
                        Else

                            If objEnt.Estado < 3 Then 'solo los no anulados, 1=no anulado,2=parcial
                                objEntCol.Add(objEnt)
                            End If

                        End If

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
            Return objEntCol
        End Function

        Public Function Listar_DocumentosJudiciales_LM_OTHSM(objDocJudExpe As Entity.Registro.DocumentoJudicial,
                                                       Optional blnVerDocumentoAnulados As Boolean = True) As Entity.Registro.DocumentoJudicialCol
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim objEnt As Entity.Registro.DocumentoJudicial = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar_LM(sqlCon, "lst", "lst_grilla_documentos_judiciales_LM_OTHSM", objDocJudExpe)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoTipoNombre = sqlDr("doc_tip_nom").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                            .DistritoJudicial = sqlDr("aut_jud_id").ToString
                            .DistritoJudNombre = sqlDr("aut_jud_nom").ToString
                            .SalaJuzgado = sqlDr("sal_jud_id").ToString
                            .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                            .JuezNombre = sqlDr("doc_jud_jue").ToString
                            .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                            .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString

                            'mostrar el origen otro, si el penal de origen es vacio
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .PenalOtroOrigenNom = sqlDr("pen_ori_otr").ToString

                            If .PenalOrigenNom.Length < 2 Then
                                .PenalOrigenNom = .PenalOtroOrigenNom
                            End If

                            'mostrar el destino otro, si el penal destino es vacio
                            .RegionDestinoId = sqlDr("reg_des_id").ToString
                            .PenalDestinoid = sqlDr("pen_des_id").ToString
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
                            .PenalDestinoOtroNom = sqlDr("pen_des_otr").ToString

                            If .PenalDestinoNom.Length < 2 Then
                                .PenalDestinoNom = .PenalDestinoOtroNom
                            End If

                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .IdDocumentoAntecedente = sqlDr("n_anu_id").ToString
                            .Estado = sqlDr("doc_jud_est_id").ToString
                        End With

                        If blnVerDocumentoAnulados = True Then
                            objEntCol.Add(objEnt)
                        Else

                            If objEnt.Estado < 3 Then 'solo los no anulados, 1=no anulado,2=parcial
                                objEntCol.Add(objEnt)
                            End If

                        End If

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
            Return objEntCol
        End Function

        Public Function Listar_DocumentosJudiciales(objDocJudExpe As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicialCol
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim objEnt As Entity.Registro.DocumentoJudicial = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar(sqlCon, "lst", "lst_grilla_documentos_judiciales", objDocJudExpe)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt

                            '.Codigo = sqlDr("doc_jud_exp_id").ToString
                            .Codigo = sqlDr("doc_jud_id").ToString
                            '.InternoExpedienteId = sqlDr("int_exp_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoTipoNombre = sqlDr("doc_tip_nom").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                            .DistritoJudicial = sqlDr("aut_jud_id").ToString
                            .DistritoJudNombre = sqlDr("aut_jud_nom").ToString
                            .SalaJuzgado = sqlDr("sal_jud_id").ToString
                            .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                            .JuezNombre = sqlDr("doc_jud_jue").ToString
                            .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                            .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .MovimientoMotivoId = sqlDr("mov_mot_id").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString

                            'mostrar el origen otro, si el penal de origen es vacio
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .PenalOtroOrigenNom = sqlDr("pen_ori_otr").ToString

                            If .PenalOrigenNom.Length < 2 Then
                                .PenalOrigenNom = .PenalOtroOrigenNom
                            End If

                            'mostrar el destino otro, si el penal destino es vacio
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
                            .PenalDestinoOtroNom = sqlDr("pen_des_otr").ToString

                            If .PenalDestinoNom.Length < 2 Then
                                .PenalDestinoNom = .PenalDestinoOtroNom
                            End If

                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .IdDocumentoAntecedente = sqlDr("n_anu_id").ToString

                        End With
                        objEntCol.Add(objEnt)
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
            Return objEntCol
        End Function

        Public Function Listar_DocumentosJudiciales_OTHSM(objDocJudExpe As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicialCol
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim objEnt As Entity.Registro.DocumentoJudicial = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar(sqlCon, "lst", "lst_grilla_documentos_judiciales_OTHSM", objDocJudExpe)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt

                            '.Codigo = sqlDr("doc_jud_exp_id").ToString
                            .Codigo = sqlDr("doc_jud_id").ToString
                            '.InternoExpedienteId = sqlDr("int_exp_id").ToString
                            .DocumentoTipo = sqlDr("doc_tip_id").ToString
                            .DocumentoSubTipoId = sqlDr("doc_subtip_id").ToString
                            .DocumentoTipoNombre = sqlDr("doc_tip_nom").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            .TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                            .DistritoJudicial = sqlDr("aut_jud_id").ToString
                            .DistritoJudNombre = sqlDr("aut_jud_nom").ToString
                            .SalaJuzgado = sqlDr("sal_jud_id").ToString
                            .SalaJudNombre = sqlDr("sal_jud_nom").ToString
                            .JuezNombre = sqlDr("doc_jud_jue").ToString
                            .SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .AutoridadOtroNombre = sqlDr("doc_jud_aut_nom").ToString
                            .AutoridadOtroCargo = sqlDr("doc_jud_aut_cgo").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .MovimientoMotivoId = sqlDr("mov_mot_id").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString

                            'mostrar el origen otro, si el penal de origen es vacio
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .PenalOtroOrigenNom = sqlDr("pen_ori_otr").ToString

                            If .PenalOrigenNom.Length < 2 Then
                                .PenalOrigenNom = .PenalOtroOrigenNom
                            End If

                            'mostrar el destino otro, si el penal destino es vacio
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
                            .PenalDestinoOtroNom = sqlDr("pen_des_otr").ToString

                            If .PenalDestinoNom.Length < 2 Then
                                .PenalDestinoNom = .PenalDestinoOtroNom
                            End If

                            .NumLibro = sqlDr("doc_jud_lib").ToString
                            .NumFolio = sqlDr("doc_jud_fol").ToString
                            .IdDocumentoAntecedente = sqlDr("n_anu_id").ToString

                        End With
                        objEntCol.Add(objEnt)
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
            Return objEntCol
        End Function
        Public Function Listar_DocumentosClasificacion(objDocJudExpe As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicialCol
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim objEnt As Entity.Registro.DocumentoJudicial = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar_LM(sqlCon, "lst", "lst_cla_doc_traslado", objDocJudExpe)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt

                            .Codigo = sqlDr("pk_doc_id").ToString
                            .DocumentoNumero = sqlDr("c_doc_num").ToString
                            '.TipoAutoridadJudicial = sqlDr("tip_aut_jud_id").ToString
                            '.TipoAutoridadJudicialNom = sqlDr("tip_aut_jud_nom").ToString
                            '.DistritoJudNombre = sqlDr("aut_jud_nom").ToString
                            '.SalaJudNombre = sqlDr("sal_jud_nom").ToString
                            '.JuezNombre = sqlDr("doc_jud_jue").ToString
                            '.SecretarioNombre = sqlDr("doc_jud_sec").ToString
                            .IngresoInpeId = sqlDr("pk_ing_inp_id").ToString
                            '.InternoIngresoId = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            '.DocumentoFechaRecepcion = sqlDr("doc_jud_fec_rec").ToString
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .RegionDestinoId = sqlDr("fk_reg_dest_id").ToString
                            .PenalDestinoid = sqlDr("fk_pen_dest_id").ToString
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
                            .Observacion = sqlDr("c_doc_obs").ToString
                            '.NumFolio = sqlDr("doc_jud_fol").ToString
                        End With
                        objEntCol.Add(objEnt)
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
            Return objEntCol
        End Function
#End Region

#Region "REG_DOC_Judicial_Descargados"
        Public Function ListarDocumentosDescargados(objEntFiltro As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicialCol
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar2(sqlCon, "lst", "lst_doc_descargados", objEntFiltro)

            Try

                Dim objEnt As Entity.Registro.DocumentoJudicial
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt
                            .Codigo = sqlDr("doc_desc_id").ToString
                            '. = sqlDr("doc_desc_tip").ToString
                            ' .SedeRowId = sqlDr("sed_int_id").ToString
                            .InternoId = sqlDr("int_id").ToString
                            .Observacion = sqlDr("int_cod_rp").ToString
                            .SecretarioNombre = sqlDr("int_ape_nom").ToString
                            .DocumentoTipoNombre = sqlDr("doc_tip_nom").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .SentenciaFecha = sqlDr("doc_jud_fec").ToString
                            .FechaMovimiento = sqlDr("doc_des_fec").ToString
                            .Estado = 0
                        End With
                        objEntCol.Add(objEnt)
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

            Return objEntCol
        End Function

        Public Function Grabar_Descarga(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If ObjEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_mant_descarga"
            Else
                strAccion = "ins"
                strOpcion = "int_mant_descarga"
            End If

            intValue = Data.Registro.DocumentoJudicial.Grabar(strAccion, strOpcion, ObjEnt)
            Return intValue
        End Function
#End Region

        'Protected Overrides Sub Finalize()
        '    MyBase.Finalize()
        'End Sub
    End Class
End Namespace


