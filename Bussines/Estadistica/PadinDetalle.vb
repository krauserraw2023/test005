Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Linq

Namespace Estadistica
    Public Class PadinDetalle
        Private objEnt As Entity.Estadistica.PadinDetalle = Nothing
        Private objEntCol As Entity.Estadistica.PadinDetalleCol = Nothing
        Dim intIndColor As Integer = 1

        Private tblDatos As New Dictionary(Of String, DataTable)

#Region "Concatenar"
        Private Function ConcatenarIdsInterno(objEntColInterno As Entity.Estadistica.PadinDetalleCol) As String
            'para listar internos unicos no repetidos
            Dim b = From x As Entity.Estadistica.PadinDetalle In objEntColInterno
                    Group x By x.InternoID Into Total = Group
                    Select InternoID, Total
            Dim ids As String = ""
            For Each vv As Object In b
                ids = ids & "," & vv.InternoID
            Next
            If ids.Trim.Length > 0 Then ids = ids.Substring(1, ids.Length - 1)
            Return ids
        End Function

        Private Function ConcatenarIdsIngreso(objEntColInterno As Entity.Estadistica.PadinDetalleCol) As String

            Dim b = From x As Entity.Estadistica.PadinDetalle In objEntColInterno
                    Group x By x.IngresoID Into Total = Group
                    Select IngresoID, Total
            Dim ids As String = ""
            For Each vv As Object In b

                ids = ids & "," & vv.IngresoID
            Next
            If ids.Trim.Length > 0 Then ids = ids.Substring(1, ids.Length - 1)
            Return ids
        End Function

        Private Function ConcatenarIdsTraslado(objEntColInterno As Entity.Estadistica.PadinDetalleCol) As String
            Dim b = From x As Entity.Estadistica.PadinDetalle In objEntColInterno
                    Group x By x.TrasladoId Into Total = Group
                    Select TrasladoId, Total
            Dim ids As String = ""
            For Each vv As Object In b

                ids = ids & "," & vv.TrasladoId

            Next
            If ids.Trim.Length > 0 Then ids = ids.Substring(1, ids.Length - 1)
            Return ids
        End Function

        Private Function ConcatenarIdsEgresoTraslado(objEntColInterno As Entity.Estadistica.PadinDetalleCol) As String
            Dim b = From x As Entity.Estadistica.PadinDetalle In objEntColInterno
                    Where x.EgresoTrasladoId <> -1
                    Group x By x.EgresoTrasladoId Into Total = Group
                    Select EgresoTrasladoId, Total
            Dim ids As String = ""
            For Each vv As Object In b
                ids = ids & "," & vv.EgresoTrasladoId
            Next
            If ids.Trim.Length > 0 Then ids = ids.Substring(1, ids.Length - 1)
            Return ids
        End Function

        Private Function ConcatenarIdsEgresoExpediente(objEntColInterno As Entity.Estadistica.PadinDetalleCol) As String
            Dim b = From x As Entity.Estadistica.PadinDetalle In objEntColInterno
                    Where x.ExpedienteLibertarID <> -1
                    Group x By x.ExpedienteLibertarID Into Total = Group
                    Select ExpedienteLibertarID, Total
            Dim ids As String = ""
            For Each vv As Object In b
                ids = ids & "," & vv.ExpedienteLibertarID
            Next
            If ids.Trim.Length > 0 Then ids = ids.Substring(1, ids.Length - 1)
            Return ids
        End Function

        Private Function ConcatenarIdsMovimientos(objEntColInterno As Entity.Estadistica.PadinDetalleCol) As String

            Dim b = From x As Entity.Estadistica.PadinDetalle In objEntColInterno
                    Group x By x.IDMovimiento Into Total = Group
                    Select IDMovimiento, Total
            Dim ids As String = ""
            For Each vv As Object In b

                ids = ids & "," & vv.IDMovimiento

            Next
            If ids.Trim.Length > 0 Then ids = ids.Substring(1, ids.Length - 1)
            Return ids
        End Function

        Private Function ConcatenarIdsEgresoMovimientos(objEntColInterno As Entity.Estadistica.PadinDetalleCol) As String
            Dim b = From x As Entity.Estadistica.PadinDetalle In objEntColInterno
                    Where x.IDMovimientoEgreso <> -1
                    Group x By x.IDMovimientoEgreso Into Total = Group
                    Select IDMovimientoEgreso, Total
            Dim ids As String = ""
            For Each vv As Object In b
                ids = ids & "," & vv.IDMovimientoEgreso
            Next
            If ids.Trim.Length > 0 Then ids = ids.Substring(1, ids.Length - 1)
            Return ids
        End Function

        Private Function ConcatenarIdsDocumentosIngresos(objEntColInterno As Entity.Estadistica.PadinDetalleCol) As String
            Dim b = From x As Entity.Estadistica.PadinDetalle In objEntColInterno
                    Where x.IDDocumentoIngreso <> -1
                    Group x By x.IDDocumentoIngreso Into Total = Group
                    Select IDDocumentoIngreso, Total
            Dim ids As String = ""
            For Each vv As Object In b
                ids = ids & "," & vv.IDDocumentoIngreso
            Next
            If ids.Trim.Length > 0 Then ids = ids.Substring(1, ids.Length - 1)
            Return ids
        End Function

        Private Function ConcatenarIdsDocumentosEgresos(objEntColInterno As Entity.Estadistica.PadinDetalleCol) As String
            Dim b = From x As Entity.Estadistica.PadinDetalle In objEntColInterno
                    Where x.IDDocumentoEgreso <> -1
                    Group x By x.IDDocumentoEgreso Into Total = Group
                    Select IDDocumentoEgreso, Total
            Dim ids As String = ""
            For Each vv As Object In b
                ids = ids & "," & vv.IDDocumentoEgreso
            Next
            If ids.Trim.Length > 0 Then ids = ids.Substring(1, ids.Length - 1)
            Return ids
        End Function
#End Region

#Region "Listar"

        Private Function ReprocesarSentencia(datos As DataTable) As DataTable
            Dim value As New DataTable
            Dim bssPadinDet As New Bussines.Estadistica.PadinDetalle
            Dim entPadinDet As Entity.Estadistica.PadinDetalle
            Dim entPadinDet2 As Entity.Estadistica.PadinDetalle
            For Each fila As DataRow In datos.Rows

                Select Case fila.Item("doc_tip_cat")
                    Case 3 ' Se refiere al tipo de categoria para los documentos de (Libertad, Revocatoria libertad, Queda)
                        Select Case fila.Item("doc_tip_id")
                            Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                                'transformas la data
                                entPadinDet = New Entity.Estadistica.PadinDetalle
                                entPadinDet.ExpedienteID = fila.Item("int_exp_id")
                                entPadinDet2 = New Entity.Estadistica.PadinDetalle
                                entPadinDet2 = bssPadinDet.ListarDatosExpedienteHijo(entPadinDet)
                                If entPadinDet2 Is Nothing Then
                                    'la data pasa directo
                                Else
                                    fila.Item("int_sen_id") = entPadinDet2.SentenciaID
                                    fila.Item("int_exp_id") = entPadinDet2.SentenciaExpedienteID
                                    fila.Item("int_sen_exp_num") = entPadinDet2.SentenciaDocumento
                                    fila.Item("int_sen_fec") = entPadinDet2.SentenciaFecha
                                    'fila.Item("dis_jud_id") = entPadinDet2.SentenciaDistritoJudicial
                                    fila.Item("aut_jud_nom") = entPadinDet2.SentenciaDistritoJudicial
                                    'fila.Item("int_sen_id") = entPadinDet2.SentenciaSalaJuzgado
                                    fila.Item("sal_jud_nom") = entPadinDet2.SentenciaSalaJuzgado
                                    'fila.Item("int_sen_doc_fec_rcp") = entPadinDet2.SentenciaExpedienteID
                                    fila.Item("int_sen_fec") = entPadinDet2.SentenciaFecha
                                    fila.Item("int_sen_cad_per") = entPadinDet2.SentenciaCadenaPerpetua
                                    fila.Item("int_sen_anio") = entPadinDet2.SentenciaPenaImpuestaAnio
                                    fila.Item("int_sen_mes") = entPadinDet2.SentenciaPenaImpuestaMes
                                    fila.Item("int_sen_dia") = entPadinDet2.SentenciaPenaImpuestaDia
                                    fila.Item("int_sen_fec_ini") = entPadinDet2.SentenciaFechaIni
                                    fila.Item("int_sen_fec_fin") = entPadinDet2.SentenciaFechaFin
                                    fila.Item("int_del_id") = entPadinDet2.SentenciaDelitoID
                                    'fila.Item("int_del_gen_id") = entPadinDet2.SentenciaDelitoID
                                    fila.Item("int_del_gen_nom") = entPadinDet2.SentenciaDelitoGenerico
                                    fila.Item("int_del_esp_id") = entPadinDet2.SentenciaDelitoEspecificoID
                                    fila.Item("int_del_esp_nom") = entPadinDet2.SentenciaDelitoEspecifico

                                    fila.Item("int_sen_obs") = entPadinDet2.SentenciaObs
                                End If
                            Case Else
                                'la data pasa directo
                        End Select
                    Case Else
                        'la data pasa directo
                End Select
                'value.Rows.Add(fila)
            Next

            Return datos
        End Function

        Public Function Listar(ByVal Codigo As Long,
        ByVal PadinID As Integer,
        ByVal RegionID As Integer,
        ByVal PenalID As Integer,
        ByVal InternoID As Integer,
        ByVal CodigoInterno As String, ByVal ApellidosyNombresAsociados As String) As Entity.Estadistica.PadinDetalleCol

            'version old del pope
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listar(sqlCon, "lst", "lst_grilla", Codigo,
            PadinID, RegionID, PenalID, InternoID, -1, -1, -1, CodigoInterno, ApellidosyNombresAsociados, -1, 0, 0)


            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle
                        With objEnt
                            .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                            .PadinCorrela = sqlDr("pad_cor").ToString
                            .Codigo = sqlDr("pad_det_id").ToString
                            .PadinID = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PenalCodigo = sqlDr("pad_det_cod_pen").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .Anio = Legolas.Components.FechaHora.FechaAnio(.FechaCorte)
                            .MesNombre = Legolas.Components.FechaHora.FechaMesNombre(.FechaCorte)
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("pad_det_int_cod").ToString

                            'interno
                            .InternoTipoDocumento = sqlDr("pad_det_int_tip_doc").ToString
                            .InternoNumeroDocumento = sqlDr("pad_det_int_num_doc").ToString
                            .InternoPrimerApellido = sqlDr("pad_det_int_pri_ape").ToString
                            .InternoSegundoApellido = sqlDr("pad_det_int_seg_ape").ToString
                            .InternoPreNombres = sqlDr("pad_det_int_pre_nom").ToString
                            .InternoNombresAsociados = sqlDr("pad_det_int_nom_aso").ToString
                            .InternoAlias = sqlDr("pad_det_int_ali").ToString
                            .InternoClasificacion = sqlDr("pad_det_int_cla").ToString
                            '.InternoPabellon = sqlDr("pad_det_int_pab").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("pad_det_int_sex").ToString
                            .InternoFechaNacimiento = sqlDr("pad_det_int_fec_nac").ToString
                            .InternoNacimientoPais = sqlDr("pad_det_int_nac_pai").ToString
                            .InternoNacimientoDepartamento = sqlDr("pad_det_int_nac_dep").ToString
                            .InternoNacimientoProvincia = sqlDr("pad_det_int_nac_pro").ToString
                            .InternoNacimientoDistrito = sqlDr("pad_det_int_nac_dis").ToString
                            .InternoNacionalidad = sqlDr("pad_det_int_nac").ToString
                            .InternoNumeroHijo = sqlDr("pad_det_int_num_hij").ToString
                            .InternoEstadoCivil = sqlDr("pad_det_int_est_civ").ToString
                            .InternoGradoInstruccion = sqlDr("pad_det_int_grd_ins").ToString
                            .InternoOcupacionGenerico = sqlDr("pad_det_int_ocu_gen").ToString
                            .InternoOcupacionEspecifico = sqlDr("pad_det_int_ocu_esp").ToString
                            .InternoComunidaNativa = sqlDr("pad_det_int_com_nat").ToString
                            .InternoDiscapacidad = sqlDr("pad_det_int_dis").ToString
                            .InternoPadre = sqlDr("pad_det_int_pad").ToString
                            .InternoMadre = sqlDr("pad_det_int_mad").ToString
                            .InternoDomicilio = sqlDr("pad_det_int_dom").ToString
                            .InternoDomicilioDepartamento = sqlDr("pad_det_int_dom_dep").ToString
                            .InternoDomicilioProvincia = sqlDr("pad_det_int_dom_pro").ToString
                            .InternoDomicilioDistrito = sqlDr("pad_det_int_dom_dis").ToString
                            .InternoFiliacionPolitica = sqlDr("pad_det_int_fil_pol").ToString
                            .InternoEstadoID = sqlDr("int_est_id").ToString

                            'ingreso
                            .FechaISP = sqlDr("pad_det_fec_isp").ToString
                            .FechaIngresoPenal = sqlDr("pad_det_fec_ing_pen").ToString
                            .IngresoNumero = sqlDr("pad_det_num_ing").ToString
                            .IngresoMotivo = sqlDr("pad_det_ing_mot").ToString
                            .IngresoOrigen = sqlDr("pad_det_ing_org").ToString
                            .IngresoDocumento = sqlDr("pad_det_ing_doc").ToString
                            .IngresoMotivoTraslado = sqlDr("pad_det_ing_mot_trs").ToString
                            .IngresoSituacionJuridicaID = sqlDr("pad_det_ing_sit_jur_id").ToString
                            .IngresoSituacionJuridica = sqlDr("pad_det_ing_sit_jur").ToString

                            'delito
                            .DelitoGenerico = sqlDr("pad_det_del_gen").ToString.ToUpper
                            .DelitoEspecifico = sqlDr("pad_det_del_esp").ToString.ToUpper
                            .DelitoOtros = sqlDr("pad_det_del_otr").ToString.ToUpper
                            .DelitoAgraviados = sqlDr("pad_det_del_agr").ToString.ToUpper

                            'expediente
                            .ExpedienteDistritoJudicial = sqlDr("pad_det_exp_dis_jud").ToString.ToUpper
                            .ExpedienteSalaJuzgado = sqlDr("pad_det_exp_sal_juz").ToString.ToUpper
                            .ExpedienteJuez = sqlDr("pad_det_exp_jue").ToString.ToUpper
                            .ExpedienteSecretario = sqlDr("pad_det_exp_sec").ToString.ToUpper
                            .ExpedienteNumero = sqlDr("pad_det_exp_num").ToString
                            .ExpedienteSituacionJuridicaID = sqlDr("pad_det_exp_sit_jur_id").ToString
                            .ExpedienteNumeroOtros = sqlDr("pad_det_exp_num_otr").ToString.ToUpper

                            'sentencia
                            .SentenciaFecha = sqlDr("pad_det_sen_fec").ToString
                            .SentenciaDistritoJudicial = sqlDr("pad_det_sen_dis_jud").ToString.ToUpper
                            .SentenciaSalaJuzgado = sqlDr("pad_det_sen_sal_juz").ToString.ToUpper
                            .SentenciaDocumento = sqlDr("pad_det_sen_doc").ToString
                            .SentenciaDelitoGenerico = sqlDr("pad_det_sen_del_gen").ToString.ToUpper
                            .SentenciaDelitoEspecifico = sqlDr("pad_det_sen_del_esp").ToString.ToUpper
                            .SentenciaPenaImpuestaAnio = sqlDr("pad_det_sen_pen_imp_anio").ToString
                            .SentenciaPenaImpuestaMes = sqlDr("pad_det_sen_pen_imp_mes").ToString
                            .SentenciaPenaImpuestaDia = sqlDr("pad_det_sen_pen_imp_dia").ToString
                            .SentenciaFechaIni = sqlDr("pad_det_sen_pen_fec_ini").ToString
                            .SentenciaFechaFin = sqlDr("pad_det_sen_pen_fec_fin").ToString
                            .SentenciaObs = sqlDr("pad_det_sen_obs").ToString.ToUpper

                            'egreso
                            .EgresoFecha = sqlDr("pad_det_egr_fec").ToString
                            .EgresoTipo = sqlDr("pad_det_egr_tip").ToString.ToUpper
                            .EgresoTipoMotivo = sqlDr("pad_det_egr_lib_trs").ToString.ToUpper
                            .EgresoDestino = sqlDr("pad_det_egr_des").ToString.ToUpper
                            .EgresoDistritoJudicial = sqlDr("pad_det_egr_dis_jud").ToString.ToUpper
                            .EgresoDocumentoLibertad = sqlDr("pad_det_egr_doc_lib").ToString.ToUpper
                            .EgresoDocumento = sqlDr("pad_det_egr_doc").ToString.ToUpper
                            .EgresoSecretario = sqlDr("pad_det_egr_sec").ToString.ToUpper
                            .EgresoJuez = sqlDr("pad_det_egr_jue").ToString.ToUpper
                            .EgresoSalaJuzgado = sqlDr("pad_det_egr_sal_juz").ToString.ToUpper
                            .EgresoObservacion = sqlDr("pad_det_egr_obs").ToString.ToUpper

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

        Public Function ListarPoblacionActiva(entPadDet As Entity.Estadistica.PadinDetalle) As Entity.Estadistica.PadinDetalleCol

            'version old del pope
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listarv2(sqlCon, "lst", "lst_grilla_poblacion_activa", entPadDet)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle
                        With objEnt
                            .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                            .PadinCorrela = sqlDr("pad_cor").ToString
                            .Codigo = sqlDr("pad_det_id").ToString
                            .PadinID = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PenalCodigo = sqlDr("pad_det_cod_pen").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .Anio = Legolas.Components.FechaHora.FechaAnio(.FechaCorte)
                            .MesNombre = Legolas.Components.FechaHora.FechaMesNombre(.FechaCorte)
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("pad_det_int_cod").ToString

                            'organizacion criminal
                            .GruposDelictivosOtros = sqlDr("grup_del_nom").ToString.ToUpper
                            .OrgCriminalFormaParte = sqlDr("org_crim_pert").ToString
                            .OrgCriminalNombre = sqlDr("org_crim_nom").ToString.ToUpper
                            .OrgCriminalCondicion = sqlDr("org_crim_cond").ToString.ToUpper
                            .DelitoFlagrante = sqlDr("int_del_flag").ToString.ToUpper

                            'interno
                            .InternoTipoDocumento = sqlDr("pad_det_int_tip_doc").ToString
                            .InternoNumeroDocumento = sqlDr("pad_det_int_num_doc").ToString
                            .InternoPrimerApellido = sqlDr("pad_det_int_pri_ape").ToString
                            .InternoSegundoApellido = sqlDr("pad_det_int_seg_ape").ToString
                            .InternoPreNombres = sqlDr("pad_det_int_pre_nom").ToString
                            .InternoNombresAsociados = sqlDr("pad_det_int_nom_aso").ToString
                            .InternoAlias = sqlDr("pad_det_int_ali").ToString
                            .InternoClasificacion = sqlDr("pad_det_int_cla").ToString
                            .InternoPabellon = sqlDr("pad_det_int_pab").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("pad_det_int_sex").ToString
                            .InternoFechaNacimiento = sqlDr("pad_det_int_fec_nac").ToString
                            .InternoNacimientoPais = sqlDr("pad_det_int_nac_pai").ToString
                            .InternoNacimientoDepartamento = sqlDr("pad_det_int_nac_dep").ToString
                            .InternoNacimientoProvincia = sqlDr("pad_det_int_nac_pro").ToString
                            .InternoNacimientoDistrito = sqlDr("pad_det_int_nac_dis").ToString
                            .InternoNacionalidad = sqlDr("pad_det_int_nac").ToString
                            .InternoNumeroHijo = sqlDr("pad_det_int_num_hij").ToString
                            .InternoEstadoCivil = sqlDr("pad_det_int_est_civ").ToString
                            .InternoGradoInstruccion = sqlDr("pad_det_int_grd_ins").ToString
                            .InternoOcupacionGenerico = sqlDr("pad_det_int_ocu_gen").ToString
                            .InternoOcupacionEspecifico = sqlDr("pad_det_int_ocu_esp").ToString
                            .InternoComunidaNativa = sqlDr("pad_det_int_com_nat").ToString
                            .InternoDiscapacidad = sqlDr("pad_det_int_dis").ToString
                            .InternoPadre = sqlDr("pad_det_int_pad").ToString
                            .InternoMadre = sqlDr("pad_det_int_mad").ToString
                            .InternoDomicilio = sqlDr("pad_det_int_dom").ToString
                            .InternoDomicilioDepartamento = sqlDr("pad_det_int_dom_dep").ToString
                            .InternoDomicilioProvincia = sqlDr("pad_det_int_dom_pro").ToString
                            .InternoDomicilioDistrito = sqlDr("pad_det_int_dom_dis").ToString
                            .InternoFiliacionPolitica = sqlDr("pad_det_int_fil_pol").ToString
                            .InternoEstadoID = 1 ' sqlDr("int_est_id").ToString

                            'ingreso
                            .FechaISP = sqlDr("pad_det_fec_isp").ToString
                            .FechaIngresoPenal = sqlDr("pad_det_fec_ing_pen").ToString
                            .IngresoNumero = sqlDr("pad_det_num_ing").ToString
                            .IngresoMotivo = sqlDr("pad_det_ing_mot").ToString
                            .IngresoOrigen = sqlDr("pad_det_ing_org").ToString
                            .IngresoDocumento = sqlDr("pad_det_ing_doc").ToString
                            .IngresoMotivoTraslado = sqlDr("pad_det_ing_mot_trs").ToString
                            .IngresoSituacionJuridicaID = sqlDr("pad_det_ing_sit_jur_id").ToString
                            .IngresoSituacionJuridica = sqlDr("pad_det_ing_sit_jur").ToString

                            'delito
                            .DelitoGenerico = sqlDr("pad_det_del_gen").ToString.ToUpper
                            .DelitoEspecifico = sqlDr("pad_det_del_esp").ToString.ToUpper
                            ' .DelitoArticulo = sqlDr("del_art_nom").ToString.ToUpper
                            .DelitoOtros = sqlDr("pad_det_del_otr").ToString.ToUpper
                            .DelitoAgraviados = sqlDr("pad_det_del_agr").ToString.ToUpper

                            .DelitoEspecificoGrupo = sqlDr("grup_del_esp_exp").ToString.ToUpper

                            'expediente
                            .ExpedienteDistritoJudicial = sqlDr("pad_det_exp_dis_jud").ToString.ToUpper
                            .ExpedienteSalaJuzgado = sqlDr("pad_det_exp_sal_juz").ToString.ToUpper
                            .ExpedienteJuez = sqlDr("pad_det_exp_jue").ToString.ToUpper
                            .ExpedienteSecretario = sqlDr("pad_det_exp_sec").ToString.ToUpper
                            .ExpedienteNumero = sqlDr("pad_det_exp_num").ToString
                            .ExpedienteSituacionJuridicaID = sqlDr("pad_det_exp_sit_jur_id").ToString
                            ' .ExpedienteSituacionJuridica = sqlDr("pad_det_exp_sit_jur").ToString.ToUpper
                            .ExpedienteNumeroOtros = sqlDr("pad_det_exp_num_otr").ToString.ToUpper

                            'sentencia
                            .SentenciaFecha = sqlDr("pad_det_sen_fec").ToString
                            .SentenciaDistritoJudicial = sqlDr("pad_det_sen_dis_jud").ToString.ToUpper
                            .SentenciaSalaJuzgado = sqlDr("pad_det_sen_sal_juz").ToString.ToUpper
                            .SentenciaSalaJuzgado = IIf(.SentenciaDistritoJudicial = "", "", .SentenciaDistritoJudicial & "/") & .SentenciaSalaJuzgado
                            .SentenciaDocumento = sqlDr("pad_det_sen_doc").ToString
                            .SentenciaDelitoGenerico = sqlDr("pad_det_sen_del_gen").ToString.ToUpper
                            .SentenciaDelitoEspecifico = sqlDr("pad_det_sen_del_esp").ToString.ToUpper

                            .SentenciaDelitoEspecificoGrupo = sqlDr("grup_del_esp_sent").ToString.ToUpper

                            .SentenciaPenaImpuestaAnio = sqlDr("pad_det_sen_pen_imp_anio").ToString
                            .SentenciaPenaImpuestaMes = sqlDr("pad_det_sen_pen_imp_mes").ToString
                            .SentenciaPenaImpuestaDia = sqlDr("pad_det_sen_pen_imp_dia").ToString
                            .SentenciaFechaIni = sqlDr("pad_det_sen_pen_fec_ini").ToString
                            .SentenciaFechaFin = sqlDr("pad_det_sen_pen_fec_fin").ToString
                            .SentenciaObs = sqlDr("pad_det_sen_obs").ToString.ToUpper

                            'egreso
                            .EgresoFecha = sqlDr("pad_det_egr_fec").ToString
                            .EgresoTipo = sqlDr("pad_det_egr_tip").ToString.ToUpper
                            .EgresoTipoMotivo = sqlDr("pad_det_egr_lib_trs").ToString.ToUpper
                            .EgresoDestino = sqlDr("pad_det_egr_des").ToString.ToUpper
                            .EgresoDistritoJudicial = sqlDr("pad_det_egr_dis_jud").ToString.ToUpper
                            .EgresoDocumentoLibertad = sqlDr("pad_det_egr_doc_lib").ToString.ToUpper
                            .EgresoDocumento = sqlDr("pad_det_egr_doc").ToString.ToUpper
                            .EgresoSecretario = sqlDr("pad_det_egr_sec").ToString.ToUpper
                            .EgresoJuez = sqlDr("pad_det_egr_jue").ToString.ToUpper
                            .EgresoSalaJuzgado = sqlDr("pad_det_egr_sal_juz").ToString.ToUpper
                            .EgresoObservacion = sqlDr("pad_det_egr_obs").ToString.ToUpper
                            'otros
                            .PadinTipoMovimiento = sqlDr("n_pad_det_tip_mov").ToString.ToUpper
                        End With
                        objEntCol.Add(objEnt)
                    End While

                    objEntCol = PintarColeccion(objEntCol)
                    objEntCol = ListarObservacionPadinActivos(objEntCol)

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

        Public Function ListarPoblacionActiva_v2(entPadDet As Entity.Estadistica.PadinDetalle) As Entity.Estadistica.PadinDetalleCol

            'version old del pope
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listarv2(sqlCon, "lst", "lst_grilla_poblacion_activa_v2", entPadDet)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle
                        With objEnt

                            .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                            .PadinCorrela = sqlDr("pad_cor").ToString
                            .Codigo = sqlDr("pad_det_id").ToString
                            .PadinID = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PenalCodigo = sqlDr("pad_det_cod_pen").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .Anio = Legolas.Components.FechaHora.FechaAnio(.FechaCorte)
                            .MesNombre = Legolas.Components.FechaHora.FechaMesNombre(.FechaCorte)
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("pad_det_int_cod").ToString

                            'organizacion criminal
                            .GruposDelictivosOtros = sqlDr("grup_del_nom").ToString.ToUpper
                            .OrgCriminalFormaParte = sqlDr("org_crim_pert").ToString
                            .OrgCriminalNombre = sqlDr("org_crim_nom").ToString.ToUpper
                            .OrgCriminalCondicion = sqlDr("org_crim_cond").ToString.ToUpper
                            .DelitoFlagrante = sqlDr("int_del_flag").ToString.ToUpper

                            'interno
                            .InternoTipoDocumento = sqlDr("pad_det_int_tip_doc").ToString
                            .InternoNumeroDocumento = sqlDr("pad_det_int_num_doc").ToString
                            .InternoPrimerApellido = sqlDr("pad_det_int_pri_ape").ToString
                            .InternoSegundoApellido = sqlDr("pad_det_int_seg_ape").ToString
                            .InternoPreNombres = sqlDr("pad_det_int_pre_nom").ToString
                            .InternoNombresAsociados = sqlDr("pad_det_int_nom_aso").ToString
                            .InternoAlias = sqlDr("pad_det_int_ali").ToString
                            .InternoClasificacion = sqlDr("pad_det_int_cla").ToString
                            .InternoPabellon = sqlDr("pad_det_int_pab").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("pad_det_int_sex").ToString
                            .InternoFechaNacimiento = sqlDr("pad_det_int_fec_nac").ToString
                            .InternoNacimientoPais = sqlDr("pad_det_int_nac_pai").ToString
                            .InternoNacimientoDepartamento = sqlDr("pad_det_int_nac_dep").ToString
                            .InternoNacimientoProvincia = sqlDr("pad_det_int_nac_pro").ToString
                            .InternoNacimientoDistrito = sqlDr("pad_det_int_nac_dis").ToString
                            .InternoNacionalidad = sqlDr("pad_det_int_nac").ToString
                            .InternoNumeroHijo = sqlDr("pad_det_int_num_hij").ToString
                            .InternoEstadoCivil = sqlDr("pad_det_int_est_civ").ToString
                            .InternoGradoInstruccion = sqlDr("pad_det_int_grd_ins").ToString
                            .InternoOcupacionGenerico = sqlDr("pad_det_int_ocu_gen").ToString
                            .InternoOcupacionEspecifico = sqlDr("pad_det_int_ocu_esp").ToString
                            .InternoComunidaNativa = sqlDr("pad_det_int_com_nat").ToString
                            .InternoDiscapacidad = sqlDr("pad_det_int_dis").ToString
                            .InternoPadre = sqlDr("pad_det_int_pad").ToString
                            .InternoMadre = sqlDr("pad_det_int_mad").ToString
                            .InternoDomicilio = sqlDr("pad_det_int_dom").ToString
                            .InternoDomicilioDepartamento = sqlDr("pad_det_int_dom_dep").ToString
                            .InternoDomicilioProvincia = sqlDr("pad_det_int_dom_pro").ToString
                            .InternoDomicilioDistrito = sqlDr("pad_det_int_dom_dis").ToString
                            .InternoFiliacionPolitica = sqlDr("pad_det_int_fil_pol").ToString
                            .InternoGenero = sqlDr("pad_gen_nom").ToString
                            .InternoPerteneciaEtnica = sqlDr("pad_pert_etn").ToString
                            .InternoLenguaMaterna = sqlDr("pad_leng_mat").ToString
                            .InternoLibro = sqlDr("pad_det_lib").ToString
                            .InternoFolio = sqlDr("pad_det_fol").ToString
                            .InternoEstadoID = 1 ' sqlDr("int_est_id").ToString

                            'ingreso
                            .FechaISP = sqlDr("pad_det_fec_isp").ToString
                            .FechaIngresoPenal = sqlDr("pad_det_fec_ing_pen").ToString
                            .IngresoNumero = sqlDr("pad_det_num_ing").ToString
                            .IngresoMotivo = sqlDr("pad_det_ing_mot").ToString
                            .IngresoOrigen = sqlDr("pad_det_ing_org").ToString
                            .IngresoDocumento = sqlDr("pad_det_ing_doc").ToString
                            .IngresoMotivoTraslado = sqlDr("pad_det_ing_mot_trs").ToString
                            .IngresoSituacionJuridicaID = sqlDr("pad_det_ing_sit_jur_id").ToString
                            .IngresoSituacionJuridica = sqlDr("pad_det_ing_sit_jur").ToString

                            'delito
                            .DelitoGenerico = sqlDr("pad_det_del_gen").ToString.ToUpper
                            .DelitoEspecifico = sqlDr("pad_det_del_esp").ToString.ToUpper
                            .DelitoArticulo = sqlDr("del_art_nom").ToString.ToUpper
                            .DelitoTipo = sqlDr("del_tip_nom").ToString.ToUpper
                            .DelitoOtros = sqlDr("pad_det_del_otr").ToString.ToUpper
                            .DelitoAgraviados = sqlDr("pad_det_del_agr").ToString.ToUpper

                            .DelitoEspecificoGrupo = sqlDr("grup_del_esp_exp").ToString.ToUpper

                            'expediente
                            .ExpedienteDistritoJudicial = sqlDr("pad_det_exp_dis_jud").ToString.ToUpper
                            .ExpedienteSalaJuzgado = sqlDr("pad_det_exp_sal_juz").ToString.ToUpper
                            .ExpedienteJuez = sqlDr("pad_det_exp_jue").ToString.ToUpper
                            .ExpedienteSecretario = sqlDr("pad_det_exp_sec").ToString.ToUpper
                            .ExpedienteNumero = sqlDr("pad_det_exp_num").ToString
                            .ExpedienteSituacionJuridicaID = sqlDr("pad_det_exp_sit_jur_id").ToString
                            .ExpedienteSituacionJuridica = sqlDr("pad_det_exp_sit_jur").ToString.ToUpper
                            .ExpedienteNumeroOtros = sqlDr("pad_det_exp_num_otr").ToString.ToUpper

                            'sentencia
                            .SentenciaFecha = sqlDr("pad_det_sen_fec").ToString
                            .SentenciaDistritoJudicial = sqlDr("pad_det_sen_dis_jud").ToString.ToUpper
                            .SentenciaSalaJuzgado = sqlDr("pad_det_sen_sal_juz").ToString.ToUpper
                            .SentenciaSalaJuzgado = IIf(.SentenciaDistritoJudicial = "", "", .SentenciaDistritoJudicial & "/") & .SentenciaSalaJuzgado
                            .SentenciaDocumento = sqlDr("pad_det_sen_doc").ToString
                            'Sentencia Primera y segunda instancia
                            .SentenciaPIFecha = sqlDr("pad_det_sen_fec").ToString
                            .SentenciaPIDistritoJudicial = sqlDr("pad_det_sen_pi_dis_jud").ToString.ToUpper
                            .SentenciaPISalaJuzgado = sqlDr("pad_det_sen_pi_sal_juz").ToString.ToUpper
                            .SentenciaPIExpedienteNumero = sqlDr("pad_det_sen_pi_doc").ToString.ToUpper
                            .SentenciaDocumento = .SentenciaPIExpedienteNumero
                            .SentenciaSIDistritoJudicial = sqlDr("pad_det_sen_si_dis_jud").ToString.ToUpper
                            .SentenciaSISalaJuzgado = sqlDr("pad_det_sen_si_sal_juz").ToString.ToUpper
                            .SentenciaSIExpedienteNumero = sqlDr("pad_det_sen_si_doc").ToString.ToUpper

                            .SentenciaDelitoGenerico = sqlDr("pad_det_sen_del_gen").ToString.ToUpper
                            .SentenciaDelitoEspecifico = sqlDr("pad_det_sen_del_esp").ToString.ToUpper
                            .SentenciaDelitoEspecificoGrupo = sqlDr("grup_del_esp_sent").ToString.ToUpper

                            .SentenciaPenaImpuestaAnio = sqlDr("pad_det_sen_pen_imp_anio").ToString
                            .SentenciaPenaImpuestaMes = sqlDr("pad_det_sen_pen_imp_mes").ToString
                            .SentenciaPenaImpuestaDia = sqlDr("pad_det_sen_pen_imp_dia").ToString
                            .SentenciaFechaIni = sqlDr("pad_det_sen_pen_fec_ini").ToString
                            .SentenciaFechaFin = sqlDr("pad_det_sen_pen_fec_fin").ToString
                            .SentenciaObs = sqlDr("pad_det_sen_obs").ToString.ToUpper

                            'egreso
                            .EgresoFecha = sqlDr("pad_det_egr_fec").ToString
                            .EgresoTipo = sqlDr("pad_det_egr_tip").ToString.ToUpper
                            .EgresoTipoMotivo = sqlDr("pad_det_egr_lib_trs").ToString.ToUpper
                            .EgresoDestino = sqlDr("pad_det_egr_des").ToString.ToUpper
                            .EgresoDistritoJudicial = sqlDr("pad_det_egr_dis_jud").ToString.ToUpper
                            .EgresoDocumentoLibertad = sqlDr("pad_det_egr_doc_lib").ToString.ToUpper
                            .EgresoDocumento = sqlDr("pad_det_egr_doc").ToString.ToUpper
                            .EgresoSecretario = sqlDr("pad_det_egr_sec").ToString.ToUpper
                            .EgresoJuez = sqlDr("pad_det_egr_jue").ToString.ToUpper
                            .EgresoSalaJuzgado = sqlDr("pad_det_egr_sal_juz").ToString.ToUpper
                            .EgresoObservacion = sqlDr("pad_det_egr_obs").ToString.ToUpper
                            'otros
                            .PadinTipoMovimiento = sqlDr("n_pad_det_tip_mov").ToString.ToUpper
                            .Inimputable = sqlDr("pad_det_inmp").ToString.ToUpper
                            .EstablecimientoMental = sqlDr("pad_est_men_des").ToString.ToUpper
                        End With
                        objEntCol.Add(objEnt)
                    End While

                    objEntCol = PintarColeccion(objEntCol)
                    objEntCol = ListarObservacionPadinActivos(objEntCol)

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


        Private Function ListarPoblacionIngresos(entObj As Entity.Estadistica.PadinDetalle) As Entity.Estadistica.PadinDetalleCol

            'version old del pope
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listarv2(sqlCon, "lst", "lst_grilla_poblacion_ingresos", entObj)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle
                        With objEnt
                            .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                            .PadinCorrela = sqlDr("pad_cor").ToString
                            .Codigo = sqlDr("pad_det_id").ToString
                            .PadinID = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PenalCodigo = sqlDr("pad_det_cod_pen").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .Anio = Legolas.Components.FechaHora.FechaAnio(.FechaCorte)
                            .MesNombre = Legolas.Components.FechaHora.FechaMesNombre(.FechaCorte)
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("pad_det_int_cod").ToString

                            'organizacion criminal
                            .GruposDelictivosOtros = sqlDr("grup_del_nom").ToString.ToUpper
                            .OrgCriminalFormaParte = sqlDr("org_crim_pert").ToString
                            .OrgCriminalNombre = sqlDr("org_crim_nom").ToString.ToUpper
                            .OrgCriminalCondicion = sqlDr("org_crim_cond").ToString.ToUpper
                            .DelitoFlagrante = sqlDr("int_del_flag").ToString.ToUpper

                            'interno
                            .InternoTipoDocumento = sqlDr("pad_det_int_tip_doc").ToString
                            .InternoNumeroDocumento = sqlDr("pad_det_int_num_doc").ToString
                            .InternoPrimerApellido = sqlDr("pad_det_int_pri_ape").ToString
                            .InternoSegundoApellido = sqlDr("pad_det_int_seg_ape").ToString
                            .InternoPreNombres = sqlDr("pad_det_int_pre_nom").ToString
                            .InternoNombresAsociados = sqlDr("pad_det_int_nom_aso").ToString
                            .InternoAlias = sqlDr("pad_det_int_ali").ToString
                            .InternoClasificacion = sqlDr("pad_det_int_cla").ToString
                            .InternoPabellon = sqlDr("pad_det_int_pab").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("pad_det_int_sex").ToString
                            .InternoFechaNacimiento = sqlDr("pad_det_int_fec_nac").ToString
                            .InternoNacimientoPais = sqlDr("pad_det_int_nac_pai").ToString
                            .InternoNacimientoDepartamento = sqlDr("pad_det_int_nac_dep").ToString
                            .InternoNacimientoProvincia = sqlDr("pad_det_int_nac_pro").ToString
                            .InternoNacimientoDistrito = sqlDr("pad_det_int_nac_dis").ToString
                            .InternoNacionalidad = sqlDr("pad_det_int_nac").ToString
                            .InternoNumeroHijo = sqlDr("pad_det_int_num_hij").ToString
                            .InternoEstadoCivil = sqlDr("pad_det_int_est_civ").ToString
                            .InternoGradoInstruccion = sqlDr("pad_det_int_grd_ins").ToString
                            .InternoOcupacionGenerico = sqlDr("pad_det_int_ocu_gen").ToString
                            .InternoOcupacionEspecifico = sqlDr("pad_det_int_ocu_esp").ToString
                            .InternoComunidaNativa = sqlDr("pad_det_int_com_nat").ToString
                            .InternoDiscapacidad = sqlDr("pad_det_int_dis").ToString
                            .InternoPadre = sqlDr("pad_det_int_pad").ToString
                            .InternoMadre = sqlDr("pad_det_int_mad").ToString
                            .InternoDomicilio = sqlDr("pad_det_int_dom").ToString
                            .InternoDomicilioDepartamento = sqlDr("pad_det_int_dom_dep").ToString
                            .InternoDomicilioProvincia = sqlDr("pad_det_int_dom_pro").ToString
                            .InternoDomicilioDistrito = sqlDr("pad_det_int_dom_dis").ToString
                            .InternoFiliacionPolitica = sqlDr("pad_det_int_fil_pol").ToString
                            .InternoEstadoID = 1 ' sqlDr("int_est_id").ToString

                            'ingreso
                            .FechaISP = sqlDr("pad_det_fec_isp").ToString
                            .FechaIngresoPenal = sqlDr("pad_det_fec_ing_pen").ToString
                            .IngresoNumero = sqlDr("pad_det_num_ing").ToString
                            .IngresoMotivo = sqlDr("pad_det_ing_mot").ToString
                            .IngresoOrigen = sqlDr("pad_det_ing_org").ToString
                            .IngresoDocumento = sqlDr("pad_det_ing_doc").ToString
                            .IngresoMotivoTraslado = sqlDr("pad_det_ing_mot_trs").ToString
                            .IngresoSituacionJuridicaID = sqlDr("pad_det_ing_sit_jur_id").ToString
                            .IngresoSituacionJuridica = sqlDr("pad_det_ing_sit_jur").ToString

                            'delito
                            .DelitoGenerico = sqlDr("pad_det_del_gen").ToString.ToUpper
                            .DelitoEspecifico = sqlDr("pad_det_del_esp").ToString.ToUpper
                            .DelitoOtros = sqlDr("pad_det_del_otr").ToString.ToUpper
                            .DelitoAgraviados = sqlDr("pad_det_del_agr").ToString.ToUpper

                            'expediente
                            .ExpedienteDistritoJudicial = sqlDr("pad_det_exp_dis_jud").ToString.ToUpper
                            .ExpedienteSalaJuzgado = sqlDr("pad_det_exp_sal_juz").ToString.ToUpper
                            .ExpedienteJuez = sqlDr("pad_det_exp_jue").ToString.ToUpper
                            .ExpedienteSecretario = sqlDr("pad_det_exp_sec").ToString.ToUpper
                            .ExpedienteNumero = sqlDr("pad_det_exp_num").ToString
                            .ExpedienteSituacionJuridicaID = sqlDr("pad_det_exp_sit_jur_id").ToString
                            .ExpedienteSituacionJuridica = sqlDr("pad_det_exp_sit_jur").ToString.ToUpper
                            .ExpedienteNumeroOtros = sqlDr("pad_det_exp_num_otr").ToString.ToUpper

                            '. = sqlDr("pad_det_exp_flgate").ToString

                            'sentencia
                            .SentenciaFecha = sqlDr("pad_det_sen_fec").ToString
                            .SentenciaDistritoJudicial = sqlDr("pad_det_sen_dis_jud").ToString.ToUpper
                            .SentenciaSalaJuzgado = sqlDr("pad_det_sen_sal_juz").ToString.ToUpper
                            .SentenciaSalaJuzgado = IIf(.SentenciaDistritoJudicial = "", "", .SentenciaDistritoJudicial & "/") & .SentenciaSalaJuzgado
                            .SentenciaDocumento = sqlDr("pad_det_sen_doc").ToString
                            .SentenciaDelitoGenerico = sqlDr("pad_det_sen_del_gen").ToString.ToUpper
                            .SentenciaDelitoEspecifico = sqlDr("pad_det_sen_del_esp").ToString.ToUpper
                            .SentenciaPenaImpuestaAnio = sqlDr("pad_det_sen_pen_imp_anio").ToString
                            .SentenciaPenaImpuestaMes = sqlDr("pad_det_sen_pen_imp_mes").ToString
                            .SentenciaPenaImpuestaDia = sqlDr("pad_det_sen_pen_imp_dia").ToString
                            .SentenciaFechaIni = sqlDr("pad_det_sen_pen_fec_ini").ToString
                            .SentenciaFechaFin = sqlDr("pad_det_sen_pen_fec_fin").ToString
                            .SentenciaObs = sqlDr("pad_det_sen_obs").ToString.ToUpper

                            'egreso
                            .EgresoFecha = sqlDr("pad_det_egr_fec").ToString
                            .EgresoTipo = sqlDr("pad_det_egr_tip").ToString.ToUpper
                            .EgresoTipoMotivo = sqlDr("pad_det_egr_lib_trs").ToString.ToUpper
                            .EgresoDestino = sqlDr("pad_det_egr_des").ToString.ToUpper
                            .EgresoDistritoJudicial = sqlDr("pad_det_egr_dis_jud").ToString.ToUpper
                            .EgresoDocumentoLibertad = sqlDr("pad_det_egr_doc_lib").ToString.ToUpper
                            .EgresoDocumento = sqlDr("pad_det_egr_doc").ToString.ToUpper
                            .EgresoSecretario = sqlDr("pad_det_egr_sec").ToString.ToUpper
                            .EgresoJuez = sqlDr("pad_det_egr_jue").ToString.ToUpper
                            .EgresoSalaJuzgado = sqlDr("pad_det_egr_sal_juz").ToString.ToUpper
                            .EgresoObservacion = sqlDr("pad_det_egr_obs").ToString.ToUpper

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
        Private Function ListarPoblacionIngresos_v2(entObj As Entity.Estadistica.PadinDetalle) As Entity.Estadistica.PadinDetalleCol

            'version old del pope
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listarv2(sqlCon, "lst", "lst_grilla_poblacion_ingresos_v2", entObj)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle
                        With objEnt
                            .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                            .PadinCorrela = sqlDr("pad_cor").ToString
                            .Codigo = sqlDr("pad_det_id").ToString
                            .PadinID = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PenalCodigo = sqlDr("pad_det_cod_pen").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .Anio = Legolas.Components.FechaHora.FechaAnio(.FechaCorte)
                            .MesNombre = Legolas.Components.FechaHora.FechaMesNombre(.FechaCorte)
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("pad_det_int_cod").ToString

                            'organizacion criminal
                            .GruposDelictivosOtros = sqlDr("grup_del_nom").ToString.ToUpper
                            .OrgCriminalFormaParte = sqlDr("org_crim_pert").ToString
                            .OrgCriminalNombre = sqlDr("org_crim_nom").ToString.ToUpper
                            .OrgCriminalCondicion = sqlDr("org_crim_cond").ToString.ToUpper
                            .DelitoFlagrante = sqlDr("int_del_flag").ToString.ToUpper

                            'interno
                            .InternoTipoDocumento = sqlDr("pad_det_int_tip_doc").ToString
                            .InternoNumeroDocumento = sqlDr("pad_det_int_num_doc").ToString
                            .InternoPrimerApellido = sqlDr("pad_det_int_pri_ape").ToString
                            .InternoSegundoApellido = sqlDr("pad_det_int_seg_ape").ToString
                            .InternoPreNombres = sqlDr("pad_det_int_pre_nom").ToString
                            .InternoNombresAsociados = sqlDr("pad_det_int_nom_aso").ToString
                            .InternoAlias = sqlDr("pad_det_int_ali").ToString
                            .InternoClasificacion = sqlDr("pad_det_int_cla").ToString
                            .InternoPabellon = sqlDr("pad_det_int_pab").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("pad_det_int_sex").ToString
                            .InternoFechaNacimiento = sqlDr("pad_det_int_fec_nac").ToString
                            .InternoNacimientoPais = sqlDr("pad_det_int_nac_pai").ToString
                            .InternoNacimientoDepartamento = sqlDr("pad_det_int_nac_dep").ToString
                            .InternoNacimientoProvincia = sqlDr("pad_det_int_nac_pro").ToString
                            .InternoNacimientoDistrito = sqlDr("pad_det_int_nac_dis").ToString
                            .InternoNacionalidad = sqlDr("pad_det_int_nac").ToString
                            .InternoNumeroHijo = sqlDr("pad_det_int_num_hij").ToString
                            .InternoEstadoCivil = sqlDr("pad_det_int_est_civ").ToString
                            .InternoGradoInstruccion = sqlDr("pad_det_int_grd_ins").ToString
                            .InternoOcupacionGenerico = sqlDr("pad_det_int_ocu_gen").ToString
                            .InternoOcupacionEspecifico = sqlDr("pad_det_int_ocu_esp").ToString
                            .InternoComunidaNativa = sqlDr("pad_det_int_com_nat").ToString
                            .InternoDiscapacidad = sqlDr("pad_det_int_dis").ToString
                            .InternoPadre = sqlDr("pad_det_int_pad").ToString
                            .InternoMadre = sqlDr("pad_det_int_mad").ToString
                            .InternoDomicilio = sqlDr("pad_det_int_dom").ToString
                            .InternoDomicilioDepartamento = sqlDr("pad_det_int_dom_dep").ToString
                            .InternoDomicilioProvincia = sqlDr("pad_det_int_dom_pro").ToString
                            .InternoDomicilioDistrito = sqlDr("pad_det_int_dom_dis").ToString
                            .InternoFiliacionPolitica = sqlDr("pad_det_int_fil_pol").ToString
                            .InternoGenero = sqlDr("pad_gen_nom").ToString
                            .InternoPerteneciaEtnica = sqlDr("pad_pert_etn").ToString
                            .InternoLenguaMaterna = sqlDr("pad_leng_mat").ToString
                            .InternoLibro = sqlDr("pad_det_lib").ToString
                            .InternoFolio = sqlDr("pad_det_fol").ToString
                            .InternoEstadoID = 1 ' sqlDr("int_est_id").ToString

                            'ingreso
                            .FechaISP = sqlDr("pad_det_fec_isp").ToString
                            .FechaIngresoPenal = sqlDr("pad_det_fec_ing_pen").ToString
                            .IngresoNumero = sqlDr("pad_det_num_ing").ToString
                            .IngresoMotivo = sqlDr("pad_det_ing_mot").ToString
                            .IngresoOrigen = sqlDr("pad_det_ing_org").ToString
                            .IngresoDocumento = sqlDr("pad_det_ing_doc").ToString
                            .IngresoMotivoTraslado = sqlDr("pad_det_ing_mot_trs").ToString
                            .IngresoSituacionJuridicaID = sqlDr("pad_det_ing_sit_jur_id").ToString
                            .IngresoSituacionJuridica = sqlDr("pad_det_ing_sit_jur").ToString

                            'delito
                            .DelitoGenerico = sqlDr("pad_det_del_gen").ToString.ToUpper
                            .DelitoEspecifico = sqlDr("pad_det_del_esp").ToString.ToUpper
                            .DelitoArticulo = sqlDr("del_art_nom").ToString.ToUpper
                            .DelitoTipo = sqlDr("del_tip_nom").ToString.ToUpper
                            .DelitoOtros = sqlDr("pad_det_del_otr").ToString.ToUpper
                            .DelitoAgraviados = sqlDr("pad_det_del_agr").ToString.ToUpper

                            'expediente
                            .ExpedienteDistritoJudicial = sqlDr("pad_det_exp_dis_jud").ToString.ToUpper
                            .ExpedienteSalaJuzgado = sqlDr("pad_det_exp_sal_juz").ToString.ToUpper
                            .ExpedienteJuez = sqlDr("pad_det_exp_jue").ToString.ToUpper
                            .ExpedienteSecretario = sqlDr("pad_det_exp_sec").ToString.ToUpper
                            .ExpedienteNumero = sqlDr("pad_det_exp_num").ToString
                            .ExpedienteSituacionJuridicaID = sqlDr("pad_det_exp_sit_jur_id").ToString
                            .ExpedienteSituacionJuridica = sqlDr("pad_det_exp_sit_jur").ToString.ToUpper
                            .ExpedienteNumeroOtros = sqlDr("pad_det_exp_num_otr").ToString.ToUpper

                            '. = sqlDr("pad_det_exp_flgate").ToString

                            'sentencia
                            .SentenciaDistritoJudicial = sqlDr("pad_det_sen_dis_jud").ToString.ToUpper
                            .SentenciaSalaJuzgado = sqlDr("pad_det_sen_sal_juz").ToString.ToUpper
                            .SentenciaSalaJuzgado = IIf(.SentenciaDistritoJudicial = "", "", .SentenciaDistritoJudicial & "/") & .SentenciaSalaJuzgado
                            .SentenciaDocumento = sqlDr("pad_det_sen_doc").ToString
                            .SentenciaDelitoGenerico = sqlDr("pad_det_sen_del_gen").ToString.ToUpper
                            .SentenciaDelitoEspecifico = sqlDr("pad_det_sen_del_esp").ToString.ToUpper
                            .SentenciaPenaImpuestaAnio = sqlDr("pad_det_sen_pen_imp_anio").ToString
                            .SentenciaPenaImpuestaMes = sqlDr("pad_det_sen_pen_imp_mes").ToString
                            .SentenciaPenaImpuestaDia = sqlDr("pad_det_sen_pen_imp_dia").ToString
                            .SentenciaFechaIni = sqlDr("pad_det_sen_pen_fec_ini").ToString
                            .SentenciaFechaFin = sqlDr("pad_det_sen_pen_fec_fin").ToString
                            .SentenciaObs = sqlDr("pad_det_sen_obs").ToString.ToUpper

                            'Sentencia otros
                            .SentenciaPIFecha = sqlDr("pad_det_sen_fec").ToString
                            .SentenciaPIDistritoJudicial = sqlDr("pad_det_sen_pi_dis_jud").ToString.ToUpper
                            .SentenciaPISalaJuzgado = sqlDr("pad_det_sen_pi_sal_juz").ToString.ToUpper
                            .SentenciaPIExpedienteNumero = sqlDr("pad_det_sen_pi_doc").ToString.ToUpper
                            .SentenciaSIDistritoJudicial = sqlDr("pad_det_sen_si_dis_jud").ToString.ToUpper
                            .SentenciaSISalaJuzgado = sqlDr("pad_det_sen_si_sal_juz").ToString.ToUpper
                            .SentenciaSIExpedienteNumero = sqlDr("pad_det_sen_si_doc").ToString.ToUpper

                            'egreso
                            .EgresoFecha = sqlDr("pad_det_egr_fec").ToString
                            .EgresoTipo = sqlDr("pad_det_egr_tip").ToString.ToUpper
                            .EgresoTipoMotivo = sqlDr("pad_det_egr_lib_trs").ToString.ToUpper
                            .EgresoDestino = sqlDr("pad_det_egr_des").ToString.ToUpper
                            .EgresoDistritoJudicial = sqlDr("pad_det_egr_dis_jud").ToString.ToUpper
                            .EgresoDocumentoLibertad = sqlDr("pad_det_egr_doc_lib").ToString.ToUpper
                            .EgresoDocumento = sqlDr("pad_det_egr_doc").ToString.ToUpper
                            .EgresoSecretario = sqlDr("pad_det_egr_sec").ToString.ToUpper
                            .EgresoJuez = sqlDr("pad_det_egr_jue").ToString.ToUpper
                            .EgresoSalaJuzgado = sqlDr("pad_det_egr_sal_juz").ToString.ToUpper
                            .EgresoObservacion = sqlDr("pad_det_egr_obs").ToString.ToUpper

                            .Inimputable = sqlDr("pad_det_inmp").ToString.ToUpper
                            .EstablecimientoMental = sqlDr("pad_est_men_des").ToString.ToUpper
                        End With
                        objEntCol.Add(objEnt)
                    End While
                    objEntCol = PintarColeccion(objEntCol)
                    objEntCol = ListarObservacionPadinActivos(objEntCol)
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

        Private Function ListarPoblacionEgresos(entObj As Entity.Estadistica.PadinDetalle) As Entity.Estadistica.PadinDetalleCol

            'version old del pope
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listarv2(sqlCon, "lst", "lst_grilla_poblacion_egresos", entObj)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle
                        With objEnt
                            .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                            .PadinCorrela = sqlDr("pad_cor").ToString
                            .Codigo = sqlDr("pad_det_id").ToString
                            .PadinID = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PenalCodigo = sqlDr("pad_det_cod_pen").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .Anio = Legolas.Components.FechaHora.FechaAnio(.FechaCorte)
                            .MesNombre = Legolas.Components.FechaHora.FechaMesNombre(.FechaCorte)
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("pad_det_int_cod").ToString

                            'organizacion criminal
                            .GruposDelictivosOtros = sqlDr("grup_del_nom").ToString.ToUpper
                            .OrgCriminalFormaParte = sqlDr("org_crim_pert").ToString
                            .OrgCriminalNombre = sqlDr("org_crim_nom").ToString.ToUpper
                            .OrgCriminalCondicion = sqlDr("org_crim_cond").ToString.ToUpper
                            .DelitoFlagrante = sqlDr("int_del_flag").ToString.ToUpper

                            'interno
                            .InternoTipoDocumento = sqlDr("pad_det_int_tip_doc").ToString
                            .InternoNumeroDocumento = sqlDr("pad_det_int_num_doc").ToString
                            .InternoPrimerApellido = sqlDr("pad_det_int_pri_ape").ToString
                            .InternoSegundoApellido = sqlDr("pad_det_int_seg_ape").ToString
                            .InternoPreNombres = sqlDr("pad_det_int_pre_nom").ToString
                            .InternoNombresAsociados = sqlDr("pad_det_int_nom_aso").ToString
                            .InternoAlias = sqlDr("pad_det_int_ali").ToString
                            .InternoClasificacion = sqlDr("pad_det_int_cla").ToString
                            .InternoPabellon = sqlDr("pad_det_int_pab").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("pad_det_int_sex").ToString
                            .InternoFechaNacimiento = sqlDr("pad_det_int_fec_nac").ToString
                            .InternoNacimientoPais = sqlDr("pad_det_int_nac_pai").ToString
                            .InternoNacimientoDepartamento = sqlDr("pad_det_int_nac_dep").ToString
                            .InternoNacimientoProvincia = sqlDr("pad_det_int_nac_pro").ToString
                            .InternoNacimientoDistrito = sqlDr("pad_det_int_nac_dis").ToString
                            .InternoNacionalidad = sqlDr("pad_det_int_nac").ToString
                            .InternoNumeroHijo = sqlDr("pad_det_int_num_hij").ToString
                            .InternoEstadoCivil = sqlDr("pad_det_int_est_civ").ToString
                            .InternoGradoInstruccion = sqlDr("pad_det_int_grd_ins").ToString
                            .InternoOcupacionGenerico = sqlDr("pad_det_int_ocu_gen").ToString
                            .InternoOcupacionEspecifico = sqlDr("pad_det_int_ocu_esp").ToString
                            .InternoComunidaNativa = sqlDr("pad_det_int_com_nat").ToString
                            .InternoDiscapacidad = sqlDr("pad_det_int_dis").ToString
                            .InternoPadre = sqlDr("pad_det_int_pad").ToString
                            .InternoMadre = sqlDr("pad_det_int_mad").ToString
                            .InternoDomicilio = sqlDr("pad_det_int_dom").ToString
                            .InternoDomicilioDepartamento = sqlDr("pad_det_int_dom_dep").ToString
                            .InternoDomicilioProvincia = sqlDr("pad_det_int_dom_pro").ToString
                            .InternoDomicilioDistrito = sqlDr("pad_det_int_dom_dis").ToString
                            .InternoFiliacionPolitica = sqlDr("pad_det_int_fil_pol").ToString
                            .InternoEstadoID = sqlDr("int_est_id").ToString

                            'ingreso
                            .FechaISP = sqlDr("pad_det_fec_isp").ToString
                            .FechaIngresoPenal = sqlDr("pad_det_fec_ing_pen").ToString
                            .IngresoNumero = sqlDr("pad_det_num_ing").ToString
                            .IngresoMotivo = sqlDr("pad_det_ing_mot").ToString
                            .IngresoOrigen = sqlDr("pad_det_ing_org").ToString
                            .IngresoDocumento = sqlDr("pad_det_ing_doc").ToString
                            .IngresoMotivoTraslado = sqlDr("pad_det_ing_mot_trs").ToString
                            .IngresoSituacionJuridicaID = sqlDr("pad_det_ing_sit_jur_id").ToString
                            .IngresoSituacionJuridica = sqlDr("pad_det_ing_sit_jur").ToString

                            'delito
                            .DelitoGenerico = sqlDr("pad_det_del_gen").ToString.ToUpper
                            .DelitoEspecifico = sqlDr("pad_det_del_esp").ToString.ToUpper
                            .DelitoOtros = sqlDr("pad_det_del_otr").ToString.ToUpper
                            .DelitoAgraviados = sqlDr("pad_det_del_agr").ToString.ToUpper

                            'expediente
                            .ExpedienteDistritoJudicial = sqlDr("pad_det_exp_dis_jud").ToString.ToUpper
                            .ExpedienteSalaJuzgado = sqlDr("pad_det_exp_sal_juz").ToString.ToUpper
                            .ExpedienteJuez = sqlDr("pad_det_exp_jue").ToString.ToUpper
                            .ExpedienteSecretario = sqlDr("pad_det_exp_sec").ToString.ToUpper
                            .ExpedienteNumero = sqlDr("pad_det_exp_num").ToString
                            .ExpedienteSituacionJuridicaID = sqlDr("pad_det_exp_sit_jur_id").ToString
                            .ExpedienteSituacionJuridica = sqlDr("pad_det_exp_sit_jur").ToString.ToUpper
                            .ExpedienteNumeroOtros = sqlDr("pad_det_exp_num_otr").ToString.ToUpper
                            '. = sqlDr("pad_det_exp_flgate").ToString

                            'sentencia
                            .SentenciaFecha = sqlDr("pad_det_sen_fec").ToString
                            .SentenciaDistritoJudicial = sqlDr("pad_det_sen_dis_jud").ToString.ToUpper
                            .SentenciaSalaJuzgado = sqlDr("pad_det_sen_sal_juz").ToString.ToUpper
                            .SentenciaSalaJuzgado = IIf(.SentenciaDistritoJudicial = "", "", .SentenciaDistritoJudicial & "/") & .SentenciaSalaJuzgado
                            .SentenciaDocumento = sqlDr("pad_det_sen_doc").ToString
                            .SentenciaDelitoGenerico = sqlDr("pad_det_sen_del_gen").ToString.ToUpper
                            .SentenciaDelitoEspecifico = sqlDr("pad_det_sen_del_esp").ToString.ToUpper
                            .SentenciaPenaImpuestaAnio = sqlDr("pad_det_sen_pen_imp_anio").ToString
                            .SentenciaPenaImpuestaMes = sqlDr("pad_det_sen_pen_imp_mes").ToString
                            .SentenciaPenaImpuestaDia = sqlDr("pad_det_sen_pen_imp_dia").ToString
                            .SentenciaFechaIni = sqlDr("pad_det_sen_pen_fec_ini").ToString
                            .SentenciaFechaFin = sqlDr("pad_det_sen_pen_fec_fin").ToString
                            .SentenciaObs = sqlDr("pad_det_sen_obs").ToString.ToUpper

                            'egreso
                            .EgresoFecha = sqlDr("pad_det_egr_fec").ToString
                            .EgresoTipoID = sqlDr("pad_det_egr_tip_id").ToString.ToUpper
                            .EgresoTipo = sqlDr("pad_det_egr_tip").ToString.ToUpper
                            .EgresoTipoMotivo = sqlDr("pad_det_egr_lib_trs").ToString.ToUpper
                            .EgresoTipoMotivoID = sqlDr("pad_det_egr_tip_mov_id").ToString.ToUpper
                            .EgresoDestino = sqlDr("pad_det_egr_des").ToString.ToUpper
                            .EgresoDistritoJudicial = sqlDr("pad_det_egr_dis_jud").ToString.ToUpper
                            .EgresoDocumentoLibertad = sqlDr("pad_det_egr_doc_lib").ToString.ToUpper
                            .EgresoDocumento = sqlDr("pad_det_egr_doc").ToString.ToUpper
                            .EgresoSecretario = sqlDr("pad_det_egr_sec").ToString.ToUpper
                            .EgresoJuez = sqlDr("pad_det_egr_jue").ToString.ToUpper
                            .EgresoSecretario = IIf(.EgresoSecretario = "", "", .EgresoSecretario & " / ") & .EgresoJuez
                            .EgresoSalaJuzgado = sqlDr("pad_det_egr_sal_juz").ToString.ToUpper
                            .EgresoObservacion = sqlDr("pad_det_egr_obs").ToString.ToUpper

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

        Private Function ListarPoblacionEgresos_v2(entObj As Entity.Estadistica.PadinDetalle) As Entity.Estadistica.PadinDetalleCol

            'version old del pope
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listarv2(sqlCon, "lst", "lst_grilla_poblacion_egresos_v2", entObj)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle
                        With objEnt
                            .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                            .PadinCorrela = sqlDr("pad_cor").ToString
                            .Codigo = sqlDr("pad_det_id").ToString
                            .PadinID = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PenalCodigo = sqlDr("pad_det_cod_pen").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .Anio = Legolas.Components.FechaHora.FechaAnio(.FechaCorte)
                            .MesNombre = Legolas.Components.FechaHora.FechaMesNombre(.FechaCorte)
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("pad_det_int_cod").ToString

                            'organizacion criminal
                            .GruposDelictivosOtros = sqlDr("grup_del_nom").ToString.ToUpper
                            .OrgCriminalFormaParte = sqlDr("org_crim_pert").ToString
                            .OrgCriminalNombre = sqlDr("org_crim_nom").ToString.ToUpper
                            .OrgCriminalCondicion = sqlDr("org_crim_cond").ToString.ToUpper
                            .DelitoFlagrante = sqlDr("int_del_flag").ToString.ToUpper

                            'interno
                            .InternoTipoDocumento = sqlDr("pad_det_int_tip_doc").ToString
                            .InternoNumeroDocumento = sqlDr("pad_det_int_num_doc").ToString
                            .InternoPrimerApellido = sqlDr("pad_det_int_pri_ape").ToString
                            .InternoSegundoApellido = sqlDr("pad_det_int_seg_ape").ToString
                            .InternoPreNombres = sqlDr("pad_det_int_pre_nom").ToString
                            .InternoNombresAsociados = sqlDr("pad_det_int_nom_aso").ToString
                            .InternoAlias = sqlDr("pad_det_int_ali").ToString
                            .InternoClasificacion = sqlDr("pad_det_int_cla").ToString
                            .InternoPabellon = sqlDr("pad_det_int_pab").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("pad_det_int_sex").ToString
                            .InternoFechaNacimiento = sqlDr("pad_det_int_fec_nac").ToString
                            .InternoNacimientoPais = sqlDr("pad_det_int_nac_pai").ToString
                            .InternoNacimientoDepartamento = sqlDr("pad_det_int_nac_dep").ToString
                            .InternoNacimientoProvincia = sqlDr("pad_det_int_nac_pro").ToString
                            .InternoNacimientoDistrito = sqlDr("pad_det_int_nac_dis").ToString
                            .InternoNacionalidad = sqlDr("pad_det_int_nac").ToString
                            .InternoNumeroHijo = sqlDr("pad_det_int_num_hij").ToString
                            .InternoEstadoCivil = sqlDr("pad_det_int_est_civ").ToString
                            .InternoGradoInstruccion = sqlDr("pad_det_int_grd_ins").ToString
                            .InternoOcupacionGenerico = sqlDr("pad_det_int_ocu_gen").ToString
                            .InternoOcupacionEspecifico = sqlDr("pad_det_int_ocu_esp").ToString
                            .InternoComunidaNativa = sqlDr("pad_det_int_com_nat").ToString
                            .InternoDiscapacidad = sqlDr("pad_det_int_dis").ToString
                            .InternoPadre = sqlDr("pad_det_int_pad").ToString
                            .InternoMadre = sqlDr("pad_det_int_mad").ToString
                            .InternoDomicilio = sqlDr("pad_det_int_dom").ToString
                            .InternoDomicilioDepartamento = sqlDr("pad_det_int_dom_dep").ToString
                            .InternoDomicilioProvincia = sqlDr("pad_det_int_dom_pro").ToString
                            .InternoDomicilioDistrito = sqlDr("pad_det_int_dom_dis").ToString
                            .InternoFiliacionPolitica = sqlDr("pad_det_int_fil_pol").ToString
                            .InternoGenero = sqlDr("pad_gen_nom").ToString
                            .InternoPerteneciaEtnica = sqlDr("pad_pert_etn").ToString
                            .InternoLenguaMaterna = sqlDr("pad_leng_mat").ToString
                            .InternoLibro = sqlDr("pad_det_lib").ToString
                            .InternoFolio = sqlDr("pad_det_fol").ToString
                            .InternoEstadoID = sqlDr("int_est_id").ToString

                            'ingreso
                            .FechaISP = sqlDr("pad_det_fec_isp").ToString
                            .FechaIngresoPenal = sqlDr("pad_det_fec_ing_pen").ToString
                            .IngresoNumero = sqlDr("pad_det_num_ing").ToString
                            .IngresoMotivo = sqlDr("pad_det_ing_mot").ToString
                            .IngresoOrigen = sqlDr("pad_det_ing_org").ToString
                            .IngresoDocumento = sqlDr("pad_det_ing_doc").ToString
                            .IngresoMotivoTraslado = sqlDr("pad_det_ing_mot_trs").ToString
                            .IngresoSituacionJuridicaID = sqlDr("pad_det_ing_sit_jur_id").ToString
                            .IngresoSituacionJuridica = sqlDr("pad_det_ing_sit_jur").ToString

                            'Sentencia otros
                            .SentenciaPIFecha = sqlDr("pad_det_sen_fec").ToString
                            .SentenciaPIDistritoJudicial = sqlDr("pad_det_sen_pi_dis_jud").ToString.ToUpper
                            .SentenciaPISalaJuzgado = sqlDr("pad_det_sen_pi_sal_juz").ToString.ToUpper
                            .SentenciaPIExpedienteNumero = sqlDr("pad_det_sen_pi_doc").ToString.ToUpper
                            .SentenciaSIDistritoJudicial = sqlDr("pad_det_sen_si_dis_jud").ToString.ToUpper
                            .SentenciaSISalaJuzgado = sqlDr("pad_det_sen_si_sal_juz").ToString.ToUpper
                            .SentenciaSIExpedienteNumero = sqlDr("pad_det_sen_si_doc").ToString.ToUpper

                            'delito
                            .DelitoGenerico = sqlDr("pad_det_del_gen").ToString.ToUpper
                            .DelitoEspecifico = sqlDr("pad_det_del_esp").ToString.ToUpper
                            .DelitoArticulo = sqlDr("del_art_nom").ToString.ToUpper
                            .DelitoTipo = sqlDr("del_tip_nom").ToString.ToUpper
                            .DelitoOtros = sqlDr("pad_det_del_otr").ToString.ToUpper
                            .DelitoAgraviados = sqlDr("pad_det_del_agr").ToString.ToUpper

                            'expediente
                            .ExpedienteDistritoJudicial = sqlDr("pad_det_exp_dis_jud").ToString.ToUpper
                            .ExpedienteSalaJuzgado = sqlDr("pad_det_exp_sal_juz").ToString.ToUpper
                            .ExpedienteJuez = sqlDr("pad_det_exp_jue").ToString.ToUpper
                            .ExpedienteSecretario = sqlDr("pad_det_exp_sec").ToString.ToUpper
                            .ExpedienteNumero = sqlDr("pad_det_exp_num").ToString
                            .ExpedienteSituacionJuridicaID = sqlDr("pad_det_exp_sit_jur_id").ToString
                            .ExpedienteSituacionJuridica = sqlDr("pad_det_exp_sit_jur").ToString.ToUpper
                            .ExpedienteNumeroOtros = sqlDr("pad_det_exp_num_otr").ToString.ToUpper
                            '. = sqlDr("pad_det_exp_flgate").ToString

                            'sentencia
                            '.SentenciaFecha = sqlDr("pad_det_sen_fec").ToString
                            .SentenciaDistritoJudicial = sqlDr("pad_det_sen_dis_jud").ToString.ToUpper
                            .SentenciaSalaJuzgado = sqlDr("pad_det_sen_sal_juz").ToString.ToUpper
                            .SentenciaSalaJuzgado = IIf(.SentenciaDistritoJudicial = "", "", .SentenciaDistritoJudicial & "/") & .SentenciaSalaJuzgado
                            .SentenciaDocumento = sqlDr("pad_det_sen_doc").ToString
                            .SentenciaDelitoGenerico = sqlDr("pad_det_sen_del_gen").ToString.ToUpper
                            .SentenciaDelitoEspecifico = sqlDr("pad_det_sen_del_esp").ToString.ToUpper
                            .SentenciaPenaImpuestaAnio = sqlDr("pad_det_sen_pen_imp_anio").ToString
                            .SentenciaPenaImpuestaMes = sqlDr("pad_det_sen_pen_imp_mes").ToString
                            .SentenciaPenaImpuestaDia = sqlDr("pad_det_sen_pen_imp_dia").ToString
                            .SentenciaFechaIni = sqlDr("pad_det_sen_pen_fec_ini").ToString
                            .SentenciaFechaFin = sqlDr("pad_det_sen_pen_fec_fin").ToString
                            .SentenciaObs = sqlDr("pad_det_sen_obs").ToString.ToUpper

                            'egreso
                            .EgresoFecha = sqlDr("pad_det_egr_fec").ToString
                            .EgresoTipoID = sqlDr("pad_det_egr_tip_id").ToString.ToUpper
                            .EgresoTipo = sqlDr("pad_det_egr_tip").ToString.ToUpper
                            .EgresoTipoMotivo = sqlDr("pad_det_egr_lib_trs").ToString.ToUpper
                            .EgresoTipoMotivoID = sqlDr("pad_det_egr_tip_mov_id").ToString.ToUpper
                            .EgresoDestino = sqlDr("pad_det_egr_des").ToString.ToUpper
                            .EgresoDistritoJudicial = sqlDr("pad_det_egr_dis_jud").ToString.ToUpper
                            .EgresoDocumentoLibertad = sqlDr("pad_det_egr_doc_lib").ToString.ToUpper
                            .EgresoDocumento = sqlDr("pad_det_egr_doc").ToString.ToUpper
                            .EgresoSecretario = sqlDr("pad_det_egr_sec").ToString.ToUpper
                            .EgresoJuez = sqlDr("pad_det_egr_jue").ToString.ToUpper
                            .EgresoSalaJuzgado = sqlDr("pad_det_egr_sal_juz").ToString.ToUpper
                            .EgresoObservacion = sqlDr("pad_det_egr_obs").ToString.ToUpper

                            .Inimputable = sqlDr("pad_det_inmp").ToString.ToUpper
                            .EstablecimientoMental = sqlDr("pad_est_men_des").ToString.ToUpper
                        End With
                        objEntCol.Add(objEnt)
                    End While
                    objEntCol = PintarColeccion(objEntCol)
                    objEntCol = ListarObservacionPadinActivos(objEntCol)
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


        Public Function ListarIngresoEgreso(objFiltro As Entity.Estadistica.PadinDetalle) As List(Of Entity.Estadistica.PadinDetalleCol)

            Dim objLista As New List(Of Entity.Estadistica.PadinDetalleCol)
            Dim objColIngreso As New Entity.Estadistica.PadinDetalleCol
            objFiltro.Codigo = -1
            objFiltro.PadinDetalleVisible = -1
            objFiltro.PadinTipoMovimiento = 1

            objColIngreso = ListarPoblacionIngresos_v2(objFiltro)

            Dim intIDinterno As Integer = -1

            Dim objInternoRepIngCol As New Entity.Estadistica.PadinDetalleCol

            For Each obj As Entity.Estadistica.PadinDetalle In objColIngreso
                Dim intCountInterno As Integer = 0
                For Each obj2 As Entity.Estadistica.PadinDetalle In objColIngreso
                    If obj.InternoID = obj2.InternoID And obj2.InternoLeido <> 1 Then
                        obj2.InternoLeido = 1
                        intCountInterno += 1
                    End If
                Next
                If intCountInterno > 1 Then
                    objInternoRepIngCol.Add(obj)
                End If
            Next


            Dim objColor As System.Drawing.Color
            For Each obj As Entity.Estadistica.PadinDetalle In objInternoRepIngCol
                objColor = PaletaColores(intIndColor)
                For Each obj2 As Entity.Estadistica.PadinDetalle In objColIngreso
                    If obj.InternoID = obj2.InternoID Then
                        obj2.InternoColor = objColor
                    End If
                Next
                intIndColor += 1
            Next
            objLista.Add(objColIngreso)

            '********Egreso**************************************
            Dim objColEgreso As New Entity.Estadistica.PadinDetalleCol
            objFiltro.PadinDetalleVisible = -1
            objFiltro.PadinTipoMovimiento = 2 'egreso

            objColEgreso = ListarPoblacionEgresos_v2(objFiltro)

            Dim objInternoRepEgrCol As New Entity.Estadistica.PadinDetalleCol

            For Each ent As Entity.Estadistica.PadinDetalle In objColEgreso
                Dim intCountInterno As Integer = 0
                For Each ent2 As Entity.Estadistica.PadinDetalle In objColEgreso
                    If ent.InternoID = ent2.InternoID And ent2.InternoLeido <> 1 Then
                        ent2.InternoLeido = 1
                        intCountInterno += 1
                    End If
                Next
                If intCountInterno > 1 Then
                    objInternoRepEgrCol.Add(ent)
                End If
            Next

            For Each obj As Entity.Estadistica.PadinDetalle In objInternoRepEgrCol
                objColor = PaletaColores(intIndColor)

                For Each obj2 As Entity.Estadistica.PadinDetalle In objInternoRepIngCol
                    If obj.InternoID = obj2.InternoID Then
                        obj.InternoColor = obj2.InternoColor
                        'Else
                        '    objColor = PaletaColores(intIndColor)
                        '    'obj.InternoColor = objColor
                        '    intIndColor += 1
                    End If
                Next
                'End If
            Next
            For Each obj As Entity.Estadistica.PadinDetalle In objInternoRepEgrCol
                For Each obj1 As Entity.Estadistica.PadinDetalle In objColEgreso
                    If obj.InternoID = obj1.InternoID Then
                        obj1.InternoColor = obj.InternoColor
                    End If
                Next

            Next


            objLista.Add(objColEgreso)

            Return objLista

        End Function

        Public Function ListarObservacionPadinActivos(objEntCol As Entity.Estadistica.PadinDetalleCol) As Entity.Estadistica.PadinDetalleCol

            Dim strMensaje As String = ""

            For Each obj As Entity.Estadistica.PadinDetalle In objEntCol

                strMensaje = ""
                With obj
                    If .InternoSexo.Trim = "" Then
                        strMensaje = strMensaje & "* Sexo."
                    End If

                    If .InternoFechaNacimiento = 0 Then
                        strMensaje = strMensaje & "* Fecha de nacimiento."
                    End If

                    If .InternoEstadoCivil = "" Then
                        strMensaje = strMensaje & "* Estado civil."
                    End If

                    If .InternoGradoInstruccion = "" Then
                        strMensaje = strMensaje & "* Grado de instruccíon."
                    End If

                    If .InternoOcupacionEspecifico = "" Then
                        strMensaje = strMensaje & "* Ocupación específica."
                    End If

                    If .IngresoNumero = 0 Then
                        strMensaje = strMensaje & "* Nro de ingreso [0]."
                    End If

                    If .FechaIngresoPenal = 0 Then
                        strMensaje = strMensaje & "* Fecha de ingreso al penal."
                    End If

                    If .FechaISP = 0 Then
                        strMensaje = strMensaje & "* Fecha de ingreso al sistema penitenciario."
                    End If

                    If .IngresoSituacionJuridica.Trim = "" Then
                        strMensaje = strMensaje & "* Situación juridica."
                    End If

                    If .InternoNacimientoPais.Trim = "" Then
                        strMensaje = strMensaje & "* País de nacimiento."
                    End If

                    If .InternoNacionalidad.Trim = "" Then
                        strMensaje = strMensaje & "* Nacionalidad."
                    End If

                    If .IngresoSituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado And .DelitoGenerico.Trim = "" Then
                        strMensaje = strMensaje & "* No ha elegido el delito de mayor pena."
                    End If

                    If (.IngresoSituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado Or
                       .IngresoSituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado_Sentenciado) _
                       And .SentenciaDelitoGenerico = "" Then
                        strMensaje = strMensaje & "* No ha elegido la sentencia de mayor Pena."
                    End If

                    obj.ObservacionRegistro = strMensaje
                    obj.ObservacionExcel = IIf(strMensaje.Length = 0, "NO", "SI")
                End With

            Next

            Return objEntCol

        End Function

        Public Function ListarObservacionPadin(objEntCol As Entity.Estadistica.PadinDetalleCol) As Entity.Estadistica.PadinDetalleCol

            Dim strMensaje As String = ""

            objEntCol = ListarObservacionPadinActivos(objEntCol)

            For Each obj As Entity.Estadistica.PadinDetalle In objEntCol

                strMensaje = obj.ObservacionRegistro

                With obj

                    If .IngresoDocumento.Trim.Length < 3 Then
                        strMensaje = strMensaje & "* Documento de ingreso."
                    End If

                    If .IngresoMotivo.Trim.Length < 3 Then
                        strMensaje = strMensaje & "* Motivo de ingreso."
                    End If

                    'If .IngresoSituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado And .DelitoGenerico.Trim = "" Then
                    '    strMensaje = strMensaje & "* No ha elegido el delito de mayor pena."
                    'End If


                    'If (.IngresoSituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado Or _
                    '   .IngresoSituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado_Sentenciado) And .SentenciaDelitoGenerico = "" Then
                    '    strMensaje = strMensaje & "* No ha elegido la sentencia de mayor Pena."
                    'End If

                    If .IngresoSituacionJuridicaID = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado Then

                        If .SentenciaDocumento.Trim <> "" Then

                            If .SentenciaPenaImpuestaAnio < 1 And .SentenciaPenaImpuestaMes < 1 And .SentenciaPenaImpuestaDia < 1 Then
                                strMensaje = strMensaje & "* No ha ingresado la pena de la sentencia (Año-Mes-Dia)."
                            End If

                        Else
                            strMensaje = strMensaje & "* No ha ingresado el documento de sentencia"
                        End If

                    End If

                    If .EgresoFecha > 0 And .EgresoTipoID < 1 Then
                        strMensaje = strMensaje & "* No ha ingresado el tipo de libertad."
                    End If

                End With

                obj.ObservacionRegistro = strMensaje
                obj.ObservacionExcel = IIf(strMensaje.Length = 0, "NO", "SI")
            Next

            Return objEntCol

        End Function
#Region "Ingreso"

        Public Function ListarIngreso_tmp(ByVal IngresoId As Integer, ByVal TrasladoId As Integer, ByVal FechaInicio As Long, ByVal FechaFin As Long) As Entity.Estadistica.PadinDetalle
            If TrasladoId > 0 Then IngresoId = -1

            Dim t As DataTable
            Dim filas As DataRow()
            If TrasladoId > 0 Then
                t = tblDatos("tblIngresoPorTraslado")
                filas = t.Select("codigo=" & TrasladoId & " and fec_ing<=" & FechaFin)
            Else
                t = tblDatos("tblIngreso")
                filas = t.Select("codigo=" & IngresoId & " and fec_ing<=" & FechaFin)
            End If

            objEnt = New Entity.Estadistica.PadinDetalle

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        .IngresoID = f("int_ing_id").ToString
                        .FechaISP = f("int_ing_fec_isp").ToString
                        .FechaIngresoPenal = f("int_ing_fec").ToString
                        .IngresoNumero = f("int_ing_nro").ToString
                        .IngresoMotivo = f("ing_mot_nom").ToString.ToUpper
                        .IngresoOrigen = f("ing_org_nom").ToString.ToUpper
                        .IngresoDocumento = f("int_ing_doc").ToString
                        .IngresoMotivoTraslado = f("ing_mot_trs_nom").ToString.ToUpper
                    End With
                Next
            End If
            Return objEnt
        End Function
        Public Function ListarIngreso_tmp_v5(ByVal MovimientoId As Integer, ByVal FechaFin As Long) As Entity.Estadistica.PadinDetalle

            Dim t As DataTable
            Dim filas As DataRow()

            t = tblDatos("tblIngreso")  'Movimientos por Ingreso
            filas = t.Select("codigo=" & MovimientoId & " and mov_fec<=" & FechaFin)

            objEnt = New Entity.Estadistica.PadinDetalle

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        .IngresoID = f("int_ing_id").ToString
                        .IngresoNumero = f("int_ing_nro").ToString
                        .FechaISP = f("int_ing_fec_isp").ToString
                        .FechaIngresoPenal = f("mov_fec").ToString
                        .IngresoMotivo = f("ing_mot_nom").ToString.ToUpper
                        .IngresoOrigen = f("ing_org_nom").ToString.ToUpper
                        .IngresoDocumento = f("int_ing_doc").ToString
                        .IDDocumentoIngreso = f("int_ing_doc_id").ToString
                        .IngresoMotivoTraslado = f("ing_mot_trs_nom").ToString.ToUpper
                        .ExpedienteTipoAutoridadID = f("tip_aut_id").ToString.ToUpper
                        .ExpedienteDistritoJudicial = f("dis_jud_nom").ToString.ToUpper
                        .ExpedienteSalaJuzgado = f("sal_jud_nom").ToString.ToUpper
                        .ExpedienteJuez = f("jue_nom").ToString.ToUpper
                        .ExpedienteSecretario = f("sec_nom").ToString.ToUpper
                        .IngresoTipoMovimientoID = f("mov_tip_id").ToString.ToUpper
                    End With
                Next
            End If
            Return objEnt
        End Function

        Public Function ListarIngreso_tmp_v6(ByVal MovimientoId As Integer, ByVal FechaFin As Long) As Entity.Estadistica.PadinDetalle

            Dim t As DataTable
            Dim filas As DataRow()

            t = tblDatos("tblIngreso")  'Movimientos por Ingreso
            filas = t.Select("codigo=" & MovimientoId & " and mov_fec<=" & FechaFin)

            objEnt = New Entity.Estadistica.PadinDetalle

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        .IngresoID = f("int_ing_id").ToString
                        .IngresoNumero = f("int_ing_nro").ToString
                        .FechaISP = f("int_ing_fec_isp").ToString
                        .FechaIngresoPenal = f("mov_fec").ToString
                        .IngresoSubMotivoId = f("mov_sub_mot_id").ToString.ToUpper
                        .IngresoMotivo = f("ing_mot_nom").ToString.ToUpper
                        .IngresoMotivoTraslado = f("ing_mot_trs_nom").ToString.ToUpper
                        If .IngresoSubMotivoId = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado Then
                            .IngresoMotivo = "Ingreso por Traslado"
                            If f("ing_mot_trs_nom").ToString.ToUpper = "INGRESO POR TRASLADO" Then
                                .IngresoMotivoTraslado = ""
                            End If
                        End If
                        .IngresoOrigen = f("ing_org_nom").ToString.ToUpper
                        .IngresoDocumento = f("int_ing_doc").ToString
                        .ExpedienteID = f("int_ing_doc_id").ToString
                        .ExpedienteNumero = f("int_exp_num").ToString
                        .ExpedienteDistritoJudicial = f("dis_jud_nom").ToString.ToUpper
                        .ExpedienteSalaJuzgado = f("sal_jud_nom").ToString.ToUpper
                        .ExpedienteJuez = f("jue_nom").ToString.ToUpper
                        .ExpedienteSecretario = f("sec_nom").ToString.ToUpper
                        .ExpedienteSituacionJuridicaID = f("sit_jur_id").ToString.ToUpper
                        .IngresoTipoMovimientoID = f("mov_tip_id").ToString.ToUpper
                        .FechaRecepcion = f("doc_jud_fec_rec").ToString.ToUpper
                    End With
                Next
            End If
            Return objEnt
        End Function

        Public Function ListarIngreso_v2(ByVal InternoID As Integer, ByVal FechaInicio As Long, ByVal FechaFin As Long) As Entity.Estadistica.PadinDetalle

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listar(sqlCon, "lst", "lst_ingreso_v2", -1,
                                                                              -1, -1, -1, InternoID, -1, -1, -1, "", "",
                                                                             -1, FechaInicio, FechaFin)
            'nueva version pope

            objEnt = New Entity.Estadistica.PadinDetalle
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong

                            .IngresoID = sqlDr("int_ing_id").ToString
                            .FechaISP = sqlDr("int_ing_fec_isp").ToString
                            .FechaIngresoPenal = sqlDr("mov_fec").ToString
                            .IngresoNumero = sqlDr("int_ing_nro").ToString
                            .IngresoMotivo = sqlDr("ing_mot_nom").ToString.ToUpper
                            .IngresoOrigen = sqlDr("ing_org_nom").ToString.ToUpper
                            .IngresoDocumento = sqlDr("int_ing_doc").ToString.ToUpper
                            .IngresoMotivoTraslado = sqlDr("ing_mot_trs_nom").ToString.ToUpper
                            .IngresoDelitosSegunMandatoDet = sqlDr("del_seg_mand").ToString.ToUpper
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

        Public Function ListarIngresoSituacionJuridicaID_v2(ByVal InternoID As Integer,
                                               ByVal IngresoID As Integer) As Integer

            'nueva version pope

            Dim value As Integer = -1

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listar(sqlCon, "lst", "lst_expediente_ingreso_v2",
                                                                                -1,
                                                                                -1, -1, -1, InternoID,
                                                                                IngresoID, -1, -1, "", "", -1, 0, 0)
            Dim strConcatenar As String = ""
            Dim intCountProc As Integer = 0
            Dim intCoutSent As Integer = 0

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            Select Case sqlDr("sit_jur_id").ToString
                                Case 1
                                    intCountProc = intCountProc + 1
                                Case 2
                                    intCoutSent = intCoutSent + 1
                            End Select

                        End With
                    End While

                    If intCountProc > 0 And intCoutSent < 1 Then value = 1
                    If intCountProc < 1 And intCoutSent > 0 Then value = 2
                    If intCountProc > 0 And intCoutSent > 0 Then value = 3
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

            Return value

        End Function
        Public Function ListarIngresoSituacionJuridicaID_tmp_v6(ByVal InternoID As Integer, ByVal IngresoID As Integer, ExpedienteId As Integer, ExpedienteNum As String, FechaRecep As Long, FechaCorte As Long, TipoMov As Integer) As Integer
            Dim t As DataTable
            Dim filas As DataRow()
            Dim value As Integer = -1
            objEnt = New Entity.Estadistica.PadinDetalle
            'If InternoID = 1287794 Then MsgBox(InternoID)
            Dim intCountProc As Integer = 0
            Dim intCoutSent As Integer = 0
            Dim objExpCol As New Entity.Registro.ExpedienteCol
            Dim blnValue As Boolean = False

            ExpedienteNum = ExpedienteNum.Replace("'", "")

            If TipoMov = 1 Then
                t = tblDatos("tblInternoOtrosExpediente")
                If ExpedienteNum = "" Then
                    filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and doc_jud_fec_rec=" & FechaRecep, " int_ing_exp_num, int_exp_id desc") ' & " and int_ing_exp_num='" & ExpedienteNum.Trim() & "'")
                Else
                    filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and doc_jud_fec_rec=" & FechaRecep & " and int_ing_exp_num='" & ExpedienteNum & "'") ' & " and int_ing_exp_num='" & ExpedienteNum.Trim() & "'")
                End If

                If filas.Count > 0 Then
                    Dim numero As String = ""
                    For Each f As System.Data.DataRow In filas
                        If f("int_ing_exp_num").ToString <> numero Then
                            numero = f("int_ing_exp_num").ToString
                            Select Case f("pad_det_exp_sit_jur_id").ToString
                                Case 1
                                    intCountProc = intCountProc + 1
                                Case 2
                                    intCoutSent = intCoutSent + 1
                                    If ExpedienteNum <> "" Then
                                        Exit For
                                    End If
                            End Select
                        End If
                    Next
                    If intCountProc > 0 And intCoutSent < 1 Then value = 1
                    If intCountProc < 1 And intCoutSent > 0 Then value = 2
                    If intCountProc > 0 And intCoutSent > 0 Then value = 3
                End If
                Return value
            Else '2,3
                t = tblDatos("tblInternoSituacionJuridica")
                If TipoMov = 2 Then
                    If ExpedienteId > 0 Then
                        filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_id=" & ExpedienteId)
                    Else
                        filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and n_int_exp_est_anu <> 2")
                    End If
                Else
                    filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_visible=1 and isnull(tip_lib_id,-1)<1 and n_int_exp_est_anu <> 2", " int_exp_visible desc, doc_jud_fec_rec desc")

                    If filas.Count = 0 And TipoMov > 1 Then
                        filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_visible=1 and n_int_exp_est_anu <> 2", " doc_jud_fec_rec desc")
                    End If
                End If
            End If
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    If f("int_exp_visible").ToString = 1 Then
                        If f("doc_jud_fec_rec").ToString > FechaCorte Then
                            Dim ExpedientePadreId As Integer = f("hijo").ToString
                            While ExpedientePadreId > 0
                                Dim filAux As DataRow()
                                filAux = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_id=" & ExpedientePadreId)
                                If filAux.Count > 0 Then
                                    If filAux(0).Item("doc_jud_fec_rec").ToString > FechaCorte Then
                                        ExpedientePadreId = filAux(0).Item("hijo").ToString
                                    Else
                                        With objEnt
                                            Select Case filAux(0).Item("pad_det_exp_sit_jur_id").ToString
                                                Case 1
                                                    intCountProc = intCountProc + 1
                                                    ExpedientePadreId = -1
                                                Case 2
                                                    intCoutSent = intCoutSent + 1
                                                    ExpedientePadreId = -1
                                            End Select
                                        End With
                                    End If
                                Else
                                    ExpedientePadreId = -1
                                End If
                            End While
                        Else
                            With objEnt
                                Select Case f("pad_det_exp_sit_jur_id").ToString
                                    Case 1
                                        intCountProc = intCountProc + 1
                                    Case 2
                                        intCoutSent = intCoutSent + 1
                                End Select
                            End With
                        End If
                        blnValue = True
                    ElseIf f("int_exp_visible").ToString = 1 Then
                        If TipoMov = 3 And f("hijo").ToString > 0 Then
                            Dim objExp As New Entity.Registro.Expediente
                            objExp.CodigoPadre = f("hijo").ToString
                            objExpCol.Add(objExp)
                        ElseIf TipoMov = 2 And f("int_exp_pri_sen").ToString = True Then
                            Select Case f("pad_det_exp_sit_jur_id").ToString
                                Case 1
                                    intCountProc = intCountProc + 1
                                Case 2
                                    intCoutSent = intCoutSent + 1
                            End Select
                        End If
                    End If
                Next
                If blnValue = False Then
                    If objExpCol.Count > 0 Then
                        t = tblDatos("tblInternoOtrosExpediente")
                        Dim objSitJurCol As New Entity.Registro.ExpedienteCol
                        For Each obj As Entity.Registro.Expediente In objExpCol
                            Dim ExpAux = obj.CodigoPadre
                            While ExpAux > 0
                                filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_id=" & ExpAux)
                                For Each f As System.Data.DataRow In filas
                                    If f("doc_jud_fec_rec").ToString <= FechaCorte Then
                                        Dim obj1 As New Entity.Registro.Expediente
                                        obj1.SituacionJuridicaID = f("pad_det_exp_sit_jur_id")
                                        objSitJurCol.Add(obj1)
                                        ExpAux = -1
                                        Exit For
                                    Else
                                        ExpAux = f("int_ex_pad_ref_id").ToString
                                    End If
                                Next
                            End While
                        Next
                        For Each obj As Entity.Registro.Expediente In objSitJurCol
                            Select Case obj.SituacionJuridicaID
                                Case 1
                                    intCountProc = intCountProc + 1
                                Case 2
                                    intCoutSent = intCoutSent + 1
                            End Select
                        Next
                    Else
                        If TipoMov = 2 Then
                            For Each f As System.Data.DataRow In filas
                                If f("int_exp_visible").ToString = 1 And f("doc_jud_fec_rec").ToString <= FechaCorte Then
                                    Select Case f("pad_det_exp_sit_jur_id").ToString
                                        Case 1
                                            intCountProc = intCountProc + 1
                                        Case 2
                                            intCoutSent = intCoutSent + 1
                                    End Select
                                ElseIf ExpedienteId > 0 And f("int_exp_visible").ToString = 0 And f("doc_jud_fec_rec").ToString <= FechaCorte Then
                                    Select Case f("pad_det_exp_sit_jur_id").ToString
                                        Case 1
                                            intCountProc = intCountProc + 1
                                        Case 2
                                            intCoutSent = intCoutSent + 1
                                    End Select
                                End If
                            Next
                        End If
                    End If
                End If
                If intCountProc > 0 And intCoutSent < 1 Then value = 1
                If intCountProc < 1 And intCoutSent > 0 Then value = 2
                If intCountProc > 0 And intCoutSent > 0 Then value = 3
            End If
            Return value
        End Function

        Public Function ListarIngresoSituacionJuridicaID_tmp_v5(ByVal InternoID As Integer, ByVal IngresoID As Integer, FechaFin As Long, TipoMov As Integer) As Integer
            Dim t As DataTable = tblDatos("tblInternoSituacionJuridica")
            Dim filas As DataRow()
            Dim value As Integer = -1

            objEnt = New Entity.Estadistica.PadinDetalle
            ' TipoMov
            filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_fec_doc_rcp<=" & FechaFin &
                             " and ((tip_lib_id<1) or (isnull(tip_lib_id,-1)>0 and not(tip_lib_id=12 and int_lib_fec<=" & FechaFin & ")))")

            If filas.Count = 0 Then
                filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_fec_doc_rcp <= " & FechaFin &
                                 " and ((tip_lib_id<1) or (tip_lib_id>0 ))")
            End If
            Dim intCountProc As Integer = 0
            Dim intCoutSent As Integer = 0
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        Select Case f("pad_det_exp_sit_jur_id").ToString
                            Case 1
                                intCountProc = intCountProc + 1
                            Case 2
                                intCoutSent = intCoutSent + 1
                        End Select
                    End With
                Next
                If intCountProc > 0 And intCoutSent < 1 Then value = 1
                If intCountProc < 1 And intCoutSent > 0 Then value = 2
                If intCountProc > 0 And intCoutSent > 0 Then value = 3
            End If
            Return value
        End Function
        Public Function ListarIngresoSituacionJuridicaID_tmp(ByVal InternoID As Integer, ByVal IngresoID As Integer, FechaFin As Long, TipoMov As Integer) As Integer
            Dim t As DataTable = tblDatos("tblInternoSituacionJuridica")
            Dim filas As DataRow()
            Dim value As Integer = -1
            objEnt = New Entity.Estadistica.PadinDetalle


            filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_fec_doc_rcp <= " & FechaFin & " and ((tip_lib_id=-1) or (isnull(tip_lib_id,-1)>1 and not(tip_lib_id=2 and int_lib_fec<=" & FechaFin & ")))")


            If filas.Count = 0 Then
                filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_fec_doc_rcp <= " & FechaFin & " and ((tip_lib_id=-1) or (tip_lib_id>1 ))")
            End If

            Dim intCountProc As Integer = 0
            Dim intCoutSent As Integer = 0
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        Select Case f("pad_det_exp_sit_jur_id").ToString
                            Case 1
                                intCountProc = intCountProc + 1
                            Case 2
                                intCoutSent = intCoutSent + 1
                        End Select
                    End With
                Next
                If intCountProc > 0 And intCoutSent < 1 Then value = 1
                If intCountProc < 1 And intCoutSent > 0 Then value = 2
                If intCountProc > 0 And intCoutSent > 0 Then value = 3
            End If
            Return value
        End Function

        Public Function ListarIngresoSituacionJuridica(ByVal SituacionJuridicaID As Integer) As String

            Dim value As String = ""

            Select Case SituacionJuridicaID
                Case 1
                    value = "Procesado"
                Case 2
                    value = "Sentenciado"
                Case 3
                    value = "Sentenciado/Procesado"
            End Select

            Return value.ToUpper

        End Function

#End Region
#Region "Expediente"
        Public Function ListarExpediente_tmp(ByVal InternoID As Integer, ByVal IngresoID As Integer, trasladoId As Integer, ByVal FechaInicio As Long, ByVal FechaFin As Long) As Entity.Estadistica.PadinDetalle
            Dim t As DataTable = tblDatos("tblInternoExpediente")


            Dim filas As DataRow()

            objEnt = New Entity.Estadistica.PadinDetalle

            filas = t.Select("int_exp_pri=1 and int_id=" & InternoID & " and int_exp_fec_doc_rcp<=" & FechaFin & If(IngresoID = -1, "", " and int_ing_id=" & IngresoID))

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .ExpedienteID = f("int_exp_id").ToString
                        .ExpedienteDistritoJudicial = f("aut_jud_nom").ToString.ToUpper
                        .ExpedienteSalaJuzgado = f("sal_jus_nom").ToString.ToUpper
                        .ExpedienteJuez = f("int_exp_jue").ToString.ToUpper
                        .ExpedienteSecretario = f("int_exp_sec").ToString.ToUpper
                        .ExpedienteNumero = f("int_ing_exp_num").ToString
                        .ExpedienteSituacionJuridicaID = f("pad_det_exp_sit_jur_id").ToString
                        .ExpedienteSituacionJuridica = f("pad_det_exp_sit_jur").ToString.ToUpper
                        .ExpedienteFlagrancia = f("pad_det_exp_fla").ToString.ToUpper
                    End With
                Next
            ElseIf trasladoId > 0 Then 'traslado
                t = tblDatos("tblIngresoPorTraslado")
                filas = t.Select("codigo=" & trasladoId)
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .ExpedienteDistritoJudicial = f("aut_jud_nom").ToString.ToUpper
                        .ExpedienteSalaJuzgado = f("sal_jus_nom").ToString.ToUpper
                        .ExpedienteJuez = f("int_trs_jue").ToString.ToUpper
                        .ExpedienteSecretario = f("int_trs_sec").ToString.ToUpper
                        .ExpedienteNumero = f("int_trs_exp").ToString
                    End With
                Next
            End If
            Return objEnt
        End Function
        Public Function ListarExpedienteIngreso_tmp_v5(ByVal InternoID As Integer, ByVal IngresoID As Integer, DocumentoID As Integer, ByVal FechaFin As Long) As Entity.Estadistica.PadinDetalle

            Dim t As DataTable = tblDatos("tblInternoExpedienteInternamiento")

            Dim filas As DataRow()

            objEnt = New Entity.Estadistica.PadinDetalle

            filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & "  and crea_doc_jud_id=" & DocumentoID) ' & "  and int_exp_fec_doc_rcp<=" & FechaFin)

            Dim strConcatenar As String = ""
            Dim blnFlagrancia As Boolean = False
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .ExpedienteID = f("int_exp_id").ToString
                        .ExpedienteNumero = f("int_ing_exp_num").ToString
                        .ExpedienteFlagrancia = f("pad_det_exp_fla").ToString.ToUpper

                        strConcatenar = strConcatenar & .ExpedienteNumero & ", "
                        If .ExpedienteFlagrancia = True Then
                            blnFlagrancia = True
                        End If
                    End With
                Next

                strConcatenar = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)

            End If
            objEnt.ExpedienteNumero = strConcatenar
            objEnt.ExpedienteFlagrancia = blnFlagrancia
            Return objEnt
        End Function

        Public Function ListarExpedienteIngreso_tmp_v6(ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal FechaFin As Long, PadinTipoMov As Integer) As Entity.Estadistica.PadinDetalle

            Dim t As DataTable = tblDatos("tblInternoExpedienteInternamiento")

            Dim filas As DataRow()

            objEnt = New Entity.Estadistica.PadinDetalle
            If PadinTipoMov = 1 Then
                filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and doc_tip_id =14 and doc_jud_fec_rec<=" & FechaFin, "int_exp_visible desc, doc_jud_fec_rec desc") ' & "  and int_exp_fec_doc_rcp<=" & FechaFin)
            Else
                filas = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_pri=1 and n_int_exp_est_anu<>2 and doc_jud_fec_rec<=" & FechaFin, "int_exp_visible desc, doc_jud_fec_rec desc") ' & "  and int_exp_fec_doc_rcp<=" & FechaFin)
            End If

            Dim strConcatenar As String = ""
            Dim blnFlagrancia As Boolean = False
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        If PadinTipoMov = 3 And f("tip_lib_id").ToString() > 1 Then
                            If f("doc_tip_id").ToString <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso Then
                                If f("doc_fec_mov").ToString <= FechaFin Then
                                    Dim fil As DataRow()
                                    Dim ExpPadId As Integer = f("int_ex_pad_ref_id").ToString
                                    Dim doc_tip_id As Integer = -1
                                    If ExpPadId = -1 Then Exit For
                                    While ExpPadId > 0
                                        fil = t.Select("int_id=" & InternoID & " and int_ing_id=" & IngresoID & " and int_exp_id=" & ExpPadId, "int_exp_visible desc, doc_jud_fec_rec desc")
                                        ExpPadId = -1
                                        For Each f1 As System.Data.DataRow In fil
                                            ExpPadId = f1("int_ex_pad_ref_id").ToString
                                            doc_tip_id = f1("doc_tip_id").ToString
                                            If doc_tip_id = 14 Then
                                                .ExpedienteID = f1("int_exp_id").ToString
                                                .ExpedienteNumero = f1("int_ing_exp_num").ToString
                                                .ExpedienteFlagrancia = f1("pad_det_exp_fla").ToString.ToUpper
                                                If .ExpedienteFlagrancia = True Then blnFlagrancia = True
                                                .ExpedienteDistritoJudicial = f1("dis_jud_nom").ToString
                                                .ExpedienteSalaJuzgado = f1("sal_jud_nom").ToString
                                                .ExpedienteJuez = f1("jue_nom").ToString
                                                .ExpedienteSecretario = f1("sec_nom").ToString
                                                .FechaRecepcion = f1("doc_jud_fec_rec").ToString
                                                .ExpedienteSituacionJuridicaID = f1("sit_jur_id").ToString
                                                Select Case .ExpedienteSituacionJuridicaID
                                                    Case 1
                                                        .ExpedienteSituacionJuridica = "PROC."
                                                    Case 2
                                                        .ExpedienteSituacionJuridica = "SENT."
                                                End Select
                                                Return objEnt
                                            End If
                                        Next
                                    End While
                                    Exit For
                                End If
                            End If
                        End If
                        .ExpedienteID = f("int_exp_id").ToString
                        .ExpedienteNumero = f("int_ing_exp_num").ToString
                        .ExpedienteFlagrancia = f("pad_det_exp_fla").ToString.ToUpper
                        If .ExpedienteFlagrancia = True Then blnFlagrancia = True
                        .ExpedienteDistritoJudicial = f("dis_jud_nom").ToString
                        .ExpedienteSalaJuzgado = f("sal_jud_nom").ToString
                        .ExpedienteJuez = f("jue_nom").ToString
                        .ExpedienteSecretario = f("sec_nom").ToString
                        .FechaRecepcion = f("doc_jud_fec_rec").ToString
                        .ExpedienteSituacionJuridicaID = f("sit_jur_id").ToString
                        Select Case .ExpedienteSituacionJuridicaID
                            Case 1
                                .ExpedienteSituacionJuridica = "PROC."
                            Case 2
                                .ExpedienteSituacionJuridica = "SENT."
                        End Select
                        If (f("int_exp_visible").ToString = True) Then
                            Exit For
                        End If
                        If (f("int_exp_pri").ToString = True) Then
                            Exit For
                        End If
                    End With
                Next
            End If
            ' objEnt.ExpedienteNumero = strConcatenar
            objEnt.ExpedienteFlagrancia = blnFlagrancia
            Return objEnt
        End Function


        Public Function ListarSiscrico_tmp_v5(ByVal InternoID As Integer) As Entity.Estadistica.PadinDetalle

            Dim t As DataTable = tblDatos("tblInternoSiscrico")

            Dim filas As DataRow()

            objEnt = New Entity.Estadistica.PadinDetalle

            filas = t.Select("int_id=" & InternoID)

            Dim strGrupo As String = ""
            Dim strCondicion As String = ""

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .OrgCriminalNombre = f("ban_nom").ToString
                        .OrgCriminalCondicion = f("ban_mie_tip_nom").ToString
                        .OrgCriminalFormaParte = True

                        strGrupo = strGrupo & .OrgCriminalNombre & ","
                        strCondicion = strCondicion & .OrgCriminalCondicion & ","

                    End With
                Next

                strGrupo = Legolas.Components.Cadena.Left(strGrupo, strGrupo.Length - 2)

                If strCondicion.Trim.Length > 1 Then
                    strCondicion = Legolas.Components.Cadena.Left(strCondicion, strCondicion.Length - 1)
                End If

            End If
            objEnt.OrgCriminalNombre = strGrupo
            objEnt.OrgCriminalCondicion = strCondicion

            Return objEnt
        End Function
        Public Function ListarExpediente_v2(ByVal InternoID As Integer,
                                         ByVal IngresoID As Integer, ByVal FechaInicio As Long, ByVal FechaFin As Long) As Entity.Estadistica.PadinDetalle

            'nueva version pope
            '25/05/2015 -> hnrb

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listar(sqlCon, "lst", "lst_expediente_v2", -1,
                                                                              -1, -1, -1, InternoID,
                                                                              IngresoID, -1, -1, "", "", -1, FechaInicio, FechaFin)
            objEnt = New Entity.Estadistica.PadinDetalle
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt

                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .ExpedienteDistritoJudicial = sqlDr("aut_jud_nom").ToString.ToUpper
                            .ExpedienteSalaJuzgado = sqlDr("sal_jus_nom").ToString.ToUpper
                            .ExpedienteJuez = sqlDr("int_exp_jue").ToString.ToUpper
                            .ExpedienteSecretario = sqlDr("int_exp_sec").ToString.ToUpper
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteSituacionJuridicaID = sqlDr("pad_det_exp_sit_jur_id").ToString
                            .ExpedienteSituacionJuridica = sqlDr("pad_det_exp_sit_jur").ToString.ToUpper
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

        Public Function ListarExpedientesOtros_tmp(ByVal InternoID As Long, ByVal IngresoID As Integer,
                                                                ByVal ExpedienteID As Long, ByVal FechaInicio As Long,
                                                                ByVal FechaFin As Long) As String

            Dim t As DataTable = tblDatos("tblInternoExpediente")
            Dim filas As DataRow()

            Dim value As String = ""

            Dim strConcatenar As String = ""
            Dim intExpedienteID As Integer = -1
            Dim strNumero As String = ""
            Dim strAutJud As String = ""
            Dim strSitJur As String = ""
            Dim strDelitos As String = ""

            'objEnt = New Entity.Estadistica.PadinDetalle
            Dim s As String = ""
            s = "int_ing_id=" & IngresoID & " and int_exp_fec_doc_rcp<=" & FechaFin & " and int_exp_id<>" & ExpedienteID
            filas = t.Select(s)

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    intExpedienteID = f("int_exp_id").ToString
                    strNumero = f("int_ing_exp_num").ToString
                    Select Case f("pad_det_exp_sit_jur_id").ToString
                        Case 1
                            strSitJur = "PROC"
                        Case 2
                            strSitJur = "SENT"
                    End Select

                    strDelitos = ListarDelitosString_tmp(InternoID, IngresoID, intExpedienteID)

                    If strDelitos <> "" Then
                        If strDelitos.ToString.Length > 3 Then
                            strDelitos = " [" & strDelitos & "]"
                        Else
                            strDelitos = ""
                        End If
                        strConcatenar = strConcatenar & strNumero & " " & "(" & strSitJur & ")" & strDelitos & " | "
                    End If
                Next
                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 3)
            End If

            Return value.ToUpper
        End Function
        Dim intConta As Integer = 0
        Public Function ListarExpedientesOtros_tmp_v5(ByVal InternoID As Long, ByVal IngresoID As Integer,
                                                                ByVal ExpedienteID As Long,
                                                                ByVal FechaFin As Long) As String
            Dim t As DataTable = tblDatos("tblInternoOtrosExpediente")
            Dim filas As DataRow()

            Dim value As String = ""

            Dim strConcatenar As String = ""
            Dim intExpedienteID As Integer = -1
            Dim strNumero As String = ""
            Dim strFechaRecep As String = ""
            Dim strAutJud As String = ""
            Dim strSitJur As String = ""
            Dim strDelitos As String = ""

            'objEnt = New Entity.Estadistica.PadinDetalle
            Dim s As String = ""
            intConta = 0

            s = "int_ing_id=" & IngresoID & " and int_exp_fec_doc_rcp<=" & FechaFin & " and int_exp_pri=0 and int_exp_visible=1"

            filas = t.Select(s)

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    intConta += 1
                    intExpedienteID = f("int_exp_id").ToString
                    strNumero = f("int_ing_exp_num").ToString
                    strFechaRecep = Legolas.Components.FechaHora.FechaDate(f("int_exp_fec_doc_rcp").ToString)
                    strAutJud = f("int_exp_aut_nom").ToString
                    Select Case f("pad_det_exp_sit_jur_id").ToString
                        Case 1
                            strSitJur = "PROC"
                        Case 2
                            strSitJur = "SENT"
                    End Select

                    strDelitos = ListarDelitosString_tmp(InternoID, IngresoID, intExpedienteID)

                    'If strDelitos <> "" Then
                    'If strDelitos.ToString.Length > 3 Then
                    '    strDelitos = " [" & strDelitos & "]"
                    'Else
                    '    strDelitos = ""
                    'End If
                    strConcatenar = strConcatenar & "(" & intConta & ") " & strFechaRecep & " | " & strAutJud & " | " & strNumero & " | " & strDelitos & " | " & strSitJur & " " + Chr(13)
                    'End If
                Next
                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 3)
            End If

            Return value.ToUpper
        End Function

        Public Function ListarExpedientesOtros_tmp_v6(ByVal InternoID As Long, ByVal IngresoID As Integer,
                                                                ByVal ExpedienteID As Long,
                                                                ByVal FechaFin As Long, ExpedienteNum As String, ByVal FechaRecep As Long,
                                                                ByVal PadinMov As Integer) As String

            Dim t As DataTable = tblDatos("tblInternoOtrosExpediente")
            Dim filas As DataRow()

            Dim value As String = ""

            Dim strConcatenar As String = ""
            Dim intExpedienteID As Integer = -1
            Dim strNumero As String = ""
            Dim strFechaRecep As String = ""
            Dim strAutJud As String = ""
            Dim strSitJur As String = ""
            Dim strDelitos As String = ""

            Dim s As String = ""
            intConta = 0

            ExpedienteNum = ExpedienteNum.Replace("'", "")

            If PadinMov = 1 Then
                s = "int_ing_id=" & IngresoID & " and doc_jud_fec_rec=" & FechaRecep & " and int_exp_id<>" & ExpedienteID & " and int_ing_exp_num<>'" & ExpedienteNum & "'"
            Else
                s = "int_ing_id=" & IngresoID & " And int_exp_visible=1 And isnull(n_int_exp_est_anu,0) <> 2 And int_exp_pri=0 And isnull(tip_lib_id,-1)<1 And int_exp_fec_doc_rcp<=" & FechaFin '' & " And n_int_exp_est_anu<2 And tip_lib_id<1"
            End If
            filas = t.Select(s)
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    intConta += 1
                    intExpedienteID = f("int_exp_id").ToString
                    strNumero = f("int_ing_exp_num").ToString
                    strFechaRecep = Legolas.Components.FechaHora.FechaDate(f("int_exp_fec_doc_rcp").ToString)
                    strAutJud = f("int_exp_aut_nom").ToString
                    Select Case f("pad_det_exp_sit_jur_id").ToString
                        Case 1
                            strSitJur = "PROC."
                        Case 2
                            strSitJur = "SENT."
                    End Select

                    strDelitos = ListarDelitosString_tmp(InternoID, IngresoID, intExpedienteID)

                    strConcatenar = strConcatenar & "(" & intConta & ") " & strFechaRecep & " | " & strAutJud & " | " & strNumero & " | " & strDelitos & " | " & strSitJur & " " + Chr(13)
                Next
                value = strConcatenar
            End If
            Return value.ToUpper
        End Function

        Public Function ListarIninputables_tmp_v6(ByVal InternoID As Long, ByVal IngresoID As Integer,
                                                                ByVal ExpedienteID As Long,
                                                                ByVal FechaFin As Long, ByVal FechaRecep As Long,
                                                                ByVal PadinMov As Integer) As Entity.Estadistica.PadinDetalle

            Dim objEnt As New Entity.Estadistica.PadinDetalle

            Dim t As DataTable = tblDatos("tblInternoInimputable")
            Dim filas As DataRow()

            filas = t.Select("int_ing_id=" & IngresoID & " and int_id=" & InternoID, " int_exp_fec_doc_rcp desc")

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    If f("inmp_est_id").ToString() = 1 Then
                        objEnt.Inimputable = "Inimputable (Con medidas de seguridad de internación)"
                        objEnt.EstablecimientoMental = f("inmp_est_men_nom").ToString()
                        Exit For
                    End If
                    If f("inmp_est_id").ToString() = 2 Then
                        'If objEnt.Inimputable.Length = 0 Then
                        objEnt.Inimputable = "Con internación preventiva (posible inimputable)"
                        objEnt.EstablecimientoMental = f("inmp_est_men_nom").ToString()
                        'End If
                    End If
                Next
            Else
                objEnt.Inimputable = "No pertenece"
            End If
            Return objEnt
        End Function

        Public Function ListarExpedientesOtros_v2(ByVal InternoID As Long, ByVal IngresoID As Integer,
                                                                ByVal ExpedienteID As Long, ByVal FechaInicio As Long,
                                                                ByVal FechaFin As Long) As String
            'nueva version pope
            '25/05/2015 -> hnrb

            Dim value As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listar(sqlCon, "lst",
                                                                                    "lst_expedientes_otros_v2",
            -1, -1, -1, -1, InternoID, IngresoID, ExpedienteID, -1, "", "", -1, FechaInicio, FechaFin)

            objEntCol = New Entity.Estadistica.PadinDetalleCol


            Dim strConcatenar As String = ""
            Dim intExpedienteID As Integer = -1
            Dim strNumero As String = ""
            Dim strSitJur As String = ""
            Dim strDelitos As String = ""

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        intExpedienteID = sqlDr("int_exp_id").ToString
                        strNumero = sqlDr("int_ing_exp_num").ToString

                        Select Case sqlDr("sit_jur_id").ToString
                            Case 1
                                strSitJur = "PROC"
                            Case 2
                                strSitJur = "SENT"
                        End Select

                        strDelitos = ListarDelitosString(InternoID, IngresoID, intExpedienteID)

                        If strDelitos.ToString.Length > 3 Then
                            strDelitos = " [" & strDelitos & "]"
                        Else
                            strDelitos = ""
                        End If

                        strConcatenar = strConcatenar & strNumero & " " & "(" & strSitJur & ")" & strDelitos & " | "

                    End While

                End If

                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 3)

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

            Return value.ToUpper

        End Function

        Public Function ListarSentenciaOtros(ByVal InternoID As Long, ByVal IngresoID As Integer,
                                                                SentenciaId As Integer) As String
            'nueva version            '25/05/2015 -> hnrb
            If SentenciaId = -1 Then Return ""
            Dim value As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listar_v2(sqlCon, "lst", "lst_sentencia_otros",
            -1, -1, -1, -1, InternoID, IngresoID, -1, -1, "", "", 0, 0, SentenciaId)

            objEntCol = New Entity.Estadistica.PadinDetalleCol


            Dim strConcatenar As String = ""
            Dim intExpedienteID As Integer = -1
            Dim strNumero As String = ""
            Dim strDelitos As String = ""
            Dim strAutJud As String = ""
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim lstExp As Entity.Registro.ExpedienteCol

                        lstExp = (New Bussines.Registro.Expediente).ListarExpedientexResolucion(sqlDr("doc_jud_id").ToString)
                        For Each o As Entity.Registro.Expediente In lstExp
                            intExpedienteID = o.Codigo
                            strNumero = o.ExpedienteNumero
                            strAutJud = o.AutoridadJudicialNombre

                            strDelitos = ListarDelitosString(InternoID, IngresoID, intExpedienteID)

                            If strDelitos.ToString.Length > 3 Then
                                strDelitos = " [" & strDelitos & "]"
                            Else
                                strDelitos = ""
                            End If

                            strConcatenar = strConcatenar & strNumero & ", " & strAutJud & " " & strDelitos & " | "
                        Next

                    End While

                End If

                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 3)

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

            Return value.ToUpper

        End Function

#End Region
#Region "Delitos"
        Public Function ListarDelitoMayorPena_tmp(ByVal InternoID As Integer, ByVal IngresoID As Integer, ExpId As Integer) As Entity.Estadistica.PadinDetalle
            Dim t As DataTable = tblDatos("tblInternoDelito")
            Dim filas As DataRow()
            filas = t.Select("int_del_dmp=1 And int_id=" & InternoID & " And int_ing_id=" & IngresoID & " And int_exp_id=" & ExpId)

            objEnt = New Entity.Estadistica.PadinDetalle
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .DelitoID = f("int_del_id").ToString
                        .DelitoGenericoID = f("int_del_gen_id").ToString
                        .DelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                        .DelitoEspecificoID = f("int_del_esp_id").ToString
                        .DelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper
                    End With
                Next
            End If

            Return objEnt
        End Function
        Dim valFecha As Long = 0
        Dim IntDelId As Integer = -1
        Dim blnVal As Boolean = False
        Public Function ListarDelitoMayorPena_tmp_v5(ByVal InternoID As Integer, ByVal IngresoID As Integer, Optional FecRecep As Long = 0) As Entity.Estadistica.PadinDetalle
            Dim t As DataTable = tblDatos("tblInternoDelito")
            Dim filas As DataRow()
            filas = t.Select("int_id=" & InternoID & " And int_ing_id=" & IngresoID) ' & " And int_del_dmp=1")

            objEnt = New Entity.Estadistica.PadinDetalle
            If filas.Count > 0 Then
                valFecha = 0
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        'valFecha = 0
                        If f("int_doc_fec_rec").ToString <= FecRecep And f("int_del_dmp").ToString = 1 Then
                            .DelitoID = f("int_del_id").ToString
                            .DelitoGenericoID = f("int_del_gen_id").ToString
                            .DelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                            .DelitoEspecificoID = f("int_del_esp_id").ToString
                            .DelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper
                            Exit For
                        ElseIf f("int_del_dmp").ToString = 0 Then
                            If f("int_doc_fec_rec").ToString > valFecha Then
                                valFecha = f("int_doc_fec_rec").ToString
                                .DelitoID = f("int_del_id").ToString
                                .DelitoGenericoID = f("int_del_gen_id").ToString
                                .DelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                                .DelitoEspecificoID = f("int_del_esp_id").ToString
                                .DelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper
                            End If
                        End If
                    End With
                Next
            End If
            Return objEnt
        End Function

        Public Function ListarDelitoMayorPena_tmp_v6(ByVal InternoID As Integer, ByVal IngresoID As Integer, FecRecep As Long, ExpedienteId As Integer, Optional PadinMov As Integer = -1) As Entity.Estadistica.PadinDetalle

            Dim t As DataTable = tblDatos("tblInternoDelito")
            Dim filas As DataRow()

            If PadinMov = 1 Then
                filas = t.Select("int_id=" & InternoID & " And int_exp_id=" & ExpedienteId, " int_del_dmp Desc")
                objEnt = New Entity.Estadistica.PadinDetalle
                If filas.Count > 0 Then
                    For Each f As System.Data.DataRow In filas
                        With objEnt
                            If f("int_doc_fec_rec").ToString <= FecRecep And f("int_del_dmp").ToString = 1 Then
                                .DelitoID = f("int_del_id").ToString
                                .DelitoGenericoID = f("int_del_gen_id").ToString
                                .DelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                                .DelitoEspecificoID = f("int_del_esp_id").ToString
                                .DelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper
                            ElseIf f("int_del_dmp").ToString = 0 Then
                                .DelitoID = f("int_del_id").ToString
                                .DelitoGenericoID = f("int_del_gen_id").ToString
                                .DelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                                .DelitoEspecificoID = f("int_del_esp_id").ToString
                                .DelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper
                            End If
                            Exit For
                        End With
                    Next
                End If
            Else
                filas = t.Select("int_id=" & InternoID & " And int_ing_id=" & IngresoID & " And int_del_dmp=1 and n_int_exp_est_anu <> (2)", " int_exp_visible desc, int_doc_fec_rec desc")
                objEnt = New Entity.Estadistica.PadinDetalle
                If filas.Count > 0 Then
                    For Each f As System.Data.DataRow In filas
                        With objEnt
                            If f("int_doc_fec_rec").ToString <= FecRecep And f("int_exp_visible").ToString = 1 And f("int_del_dmp").ToString = 1 Then
                                .DelitoID = f("int_del_id").ToString
                                .DelitoGenericoID = f("int_del_gen_id").ToString
                                .DelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                                .DelitoEspecificoID = f("int_del_esp_id").ToString
                                .DelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper
                                Exit For
                            ElseIf f("int_del_dmp").ToString = 1 Then
                                .DelitoID = f("int_del_id").ToString
                                .DelitoGenericoID = f("int_del_gen_id").ToString
                                .DelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                                .DelitoEspecificoID = f("int_del_esp_id").ToString
                                .DelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper
                                Exit For
                            End If
                        End With
                    Next
                End If
            End If

            Return objEnt
        End Function


        Private Function ListarDelitosString_tmp(ByVal InternoID As Integer,
                                    ByVal IngresoID As Integer, ByVal ExpedienteID As Integer) As String

            Dim value As String = ""
            Try

                objEntCol = New Entity.Estadistica.PadinDetalleCol
                objEntCol = ListarDelitos_tmp(InternoID, IngresoID, ExpedienteID)

                Dim strConcatenar As String = ""
                For Each obj As Entity.Estadistica.PadinDetalle In objEntCol
                    strConcatenar = strConcatenar & obj.DelitoEspecifico & ", "
                Next

                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)
            Catch ex As Exception

            End Try

            Return value.ToUpper
        End Function

        Private Function ListarDelitosString(ByVal InternoID As Integer,
                                    ByVal IngresoID As Integer, ByVal ExpedienteID As Integer) As String

            Dim value As String = ""
            Try

                objEntCol = New Entity.Estadistica.PadinDetalleCol
                objEntCol = ListarDelitos(InternoID, IngresoID, ExpedienteID)

                Dim strConcatenar As String = ""
                For Each obj As Entity.Estadistica.PadinDetalle In objEntCol
                    strConcatenar = strConcatenar & obj.DelitoEspecifico & ", "
                Next

                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)
            Catch ex As Exception

            End Try


            Return value.ToUpper

        End Function

        Private Function ListarDelitos_tmp(ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal ExpedienteID As Integer) As Entity.Estadistica.PadinDetalleCol
            'Leer los delitos para los otros procesos
            Dim t As DataTable = tblDatos("tblInternoOtrosDelito") ''tblInternoDelito
            Dim filas As DataRow()
            filas = t.Select("int_id=" & InternoID & " And int_ing_id=" & IngresoID & " And int_exp_id=" & ExpedienteID)
            objEntCol = New Entity.Estadistica.PadinDetalleCol

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    objEnt = New Entity.Estadistica.PadinDetalle
                    With objEnt
                        .DelitoID = f("int_del_id").ToString
                        .DelitoGenericoID = f("int_del_gen_id").ToString
                        .DelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                        .DelitoEspecificoID = f("int_del_esp_id").ToString
                        .DelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper
                    End With
                    objEntCol.Add(objEnt)
                Next
            End If

            Return objEntCol
        End Function

        Private Function ListarDelitos(ByVal InternoID As Integer,
                                    ByVal IngresoID As Integer, ByVal ExpedienteID As Integer) As Entity.Estadistica.PadinDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listar(sqlCon, "lst", "lst_delito", -1,
                                                                              -1, -1, -1, InternoID,
                                                                              IngresoID, ExpedienteID, -1, "", "", -1, 0, 0)
            objEntCol = New Entity.Estadistica.PadinDetalleCol

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            .DelitoID = sqlDr("int_del_id").ToString
                            .DelitoGenericoID = sqlDr("int_del_gen_id").ToString
                            .DelitoGenerico = sqlDr("int_del_gen_nom").ToString.ToUpper
                            .DelitoEspecificoID = sqlDr("int_del_esp_id").ToString
                            .DelitoEspecifico = sqlDr("int_del_esp_nom").ToString.ToUpper
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

        Public Function ListarDelitosExpediente_tmp(ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal ExpedienteID As Integer) As String
            Dim value As String = ""
            Dim t As DataTable = tblDatos("tblInternoDelito")
            Dim filas As DataRow()
            filas = t.Select("int_del_dmp=0 And int_exp_id=" & ExpedienteID)

            Dim strConcatenar As String = ""
            objEnt = New Entity.Estadistica.PadinDetalle
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        strConcatenar = strConcatenar & f("int_del_esp_nom").ToString & ", "
                    End With
                Next
                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)
            End If
            Return value.ToUpper
        End Function
        Public Function ListarOtrosDelitosExpediente_tmp_v5(ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal ExpedienteID As Integer) As String
            Dim value As String = ""
            Dim t As DataTable = tblDatos("tblInternoOtrosDelito")
            Dim filas As DataRow()
            filas = t.Select("int_exp_pri=1 And int_del_dmp=0 And int_ing_id=" & IngresoID)

            Dim strConcatenar As String = ""
            objEnt = New Entity.Estadistica.PadinDetalle
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        strConcatenar = strConcatenar & f("int_del_esp_nom").ToString & ", "
                    End With
                Next
                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)
            End If
            Return value.ToUpper
        End Function

        Public Function ListarOtrosDelitosExpediente_tmp_v6(ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal ExpedienteID As Integer, PadinMov As Integer) As String
            Dim value As String = ""
            If ExpedienteID < 1 Then Return value
            Dim t As DataTable = tblDatos("tblInternoOtrosDelito")
            Dim filas As DataRow()
            Dim strConcatenar As String = ""
            objEnt = New Entity.Estadistica.PadinDetalle

            If PadinMov = 1 Then
                filas = t.Select("int_exp_id=" & ExpedienteID, " int_del_dmp desc,int_exp_id asc")
                If filas.Count > 0 Then
                    Dim conta As Integer = 0
                    For Each f As System.Data.DataRow In filas
                        If conta > 0 Then
                            strConcatenar = strConcatenar & f("int_del_esp_nom").ToString & ", "
                        End If
                        conta = conta + 1
                    Next
                    value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)

                End If
            Else
                filas = t.Select("int_exp_pri=1 And int_del_dmp=0 And int_exp_visible=1 and n_int_del_est_anu in (0,1) and int_ing_id=" & IngresoID)

                If filas.Count > 0 Then
                    For Each f As System.Data.DataRow In filas
                        With objEnt
                            strConcatenar = strConcatenar & f("int_del_esp_nom").ToString & ", "
                        End With
                    Next
                    value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)
                End If
            End If

            Return value.ToUpper
        End Function

        Public Function ListarDelitosExpediente(ByVal InternoID As Integer,
                                               ByVal IngresoID As Integer, ByVal ExpedienteID As Integer) As String

            Dim value As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listar(sqlCon, "lst", "lst_delito_expediente",
                                                                                -1,
                                                                                -1, -1, -1, InternoID,
                                                                                IngresoID, ExpedienteID, -1, "", "", -1, 0, 0)
            Dim strConcatenar As String = ""
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            strConcatenar = strConcatenar & sqlDr("int_del_esp_nom").ToString & ", "
                        End With
                    End While

                    value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)

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

            Return value.ToUpper

        End Function

        Public Function ListarDelitoAgraviados_tmp(ByVal DelitoID As Integer) As String

            Dim value As String = ""
            Dim t As DataTable = tblDatos("tblInternoAgraviado")
            Dim filas As DataRow()
            filas = t.Select("int_del_id=" & DelitoID)

            Dim strNombre As String = ""
            Dim strConcatenar As String = ""
            objEnt = New Entity.Estadistica.PadinDetalle
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        strNombre = f("int_agr_nom").ToString
                        If strNombre.Trim <> "" Then strConcatenar = strConcatenar & strNombre & ", "
                    End With
                Next
                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)
            End If
            Return value.ToUpper
        End Function

        Public Function ListarDelitoAgraviados_tmp_v5(ByVal DelitoID As Integer) As String

            Dim value As String = ""
            Dim t As DataTable = tblDatos("tblInternoAgraviado")
            Dim filas As DataRow()
            filas = t.Select("int_del_id=" & DelitoID)

            Dim strNombre As String = ""
            Dim strConcatenar As String = ""
            objEnt = New Entity.Estadistica.PadinDetalle
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        strNombre = f("int_agr_nom").ToString
                        If strNombre.Trim <> "" Then strConcatenar = strConcatenar & strNombre & ", "
                    End With
                Next
                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)
            End If
            Return value.ToUpper
        End Function

        Public Function ListarDelitoAgraviados_tmp_v6(ByVal DelitoID As Integer) As String

            Dim value As String = ""
            Dim t As DataTable = tblDatos("tblInternoAgraviado")
            Dim filas As DataRow()
            filas = t.Select("int_del_id=" & DelitoID)

            Dim strNombre As String = ""
            Dim strConcatenar As String = ""
            objEnt = New Entity.Estadistica.PadinDetalle
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        strNombre = f("int_agr_nom").ToString
                        If strNombre.Trim <> "" Then strConcatenar = strConcatenar & strNombre & ", "
                    End With
                Next
                value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)
            End If
            Return value.ToUpper
        End Function


        Public Function ListarDelitoAgraviados(ByVal InternoID As Long, ByVal IngresoID As Integer,
                                                                ByVal ExpedienteID As Long,
                                                                ByVal DelitoID As Integer) As String

            Dim Value As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listar(sqlCon, "lst",
                                                                                    "lst_delitos_agraviados",
            -1, -1, -1, -1, InternoID, IngresoID, ExpedienteID, DelitoID, "", "", -1, 0, 0)

            Dim strConcatenar As String = ""
            Dim strNombre As String = ""

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        strNombre = sqlDr("int_agr_nom").ToString
                        If strNombre.Trim <> "" Then strConcatenar = strConcatenar & strNombre & ", "
                    End While
                    Value = Legolas.Components.Cadena.Left(strConcatenar, strConcatenar.Length - 2)
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

            Return Value.ToUpper

        End Function
#End Region
        Public Function NumeroHijo(InternoID As Integer) As Integer
            Dim objEntCol As New Entity.Registro.FamiliarCol
            Dim t As DataTable = tblDatos("tblInternoFamiliar")
            Dim filas As DataRow()
            filas = t.Select("int_id=" & InternoID & " And int_fam_tip_id=4") ' and int_fam_hij_rec>0 and int_fam_fec_nac>0 and anios<18")
            Return filas.Count
        End Function

        Public Function ListarFamilia_tmp(ByVal InternoID As Integer, ByVal FechaInicio As Long) As Entity.Registro.FamiliarCol
            Dim objEntCol As New Entity.Registro.FamiliarCol
            Dim objEnt As Entity.Registro.Familiar

            Dim t As DataTable = tblDatos("tblInternoFamiliar")
            Dim filas As DataRow()
            filas = t.Select("int_id=" & InternoID & " and int_fam_fec_nac>=" & FechaInicio & " and int_fam_tip_id=4")
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    objEnt = New Entity.Registro.Familiar
                    With objEnt
                        .Codigo = f("int_fam_id").ToString
                        .InternoID = f("int_id").ToString
                        .FamiliarTipoID = f("int_fam_tip_id").ToString
                        '.FamiliarTipoNombre = sqlDr("int_fam_tip_nom").ToString
                        .ApellidoPaterno = f("int_fam_ape_pat").ToString
                        .ApellidoMaterno = f("int_fam_ape_mat").ToString
                        .Nombres = f("int_fam_nom").ToString
                        .Sexo = f("sex_id").ToString
                        .SexoNombre = f("sex_nom").ToString
                        .FechaNacimiento = f("int_fam_fec_nac").ToString
                        .Vive = f("int_fam_viv").ToString
                        .HijoReclucido = f("int_fam_hij_rec").ToString
                    End With
                    objEntCol.Add(objEnt)
                Next
            End If
            Return objEntCol
        End Function

        Public Function ListarSentencia_tmp(ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal FechaInicio As Long, ByVal FechaFin As Long) As Entity.Estadistica.PadinDetalle

            Dim t As DataTable = tblDatos("tblSentencia")
            Dim filas As DataRow()
            filas = t.Select("int_ing_id=" & IngresoID & " and int_sen_doc_fec_rcp <=" & FechaFin)

            Dim intMaxNumDias As Integer = 30
            Dim intMaxNumMeses As Integer = 12

            Dim intDias As Integer = 0
            Dim intMeses As Integer = 0
            Dim intAnio As Integer = 0

            objEnt = New Entity.Estadistica.PadinDetalle
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .SentenciaID = f("int_sen_id").ToString
                        .SentenciaExpedienteID = f("int_exp_id").ToString
                        .SentenciaFecha = f("int_sen_fec").ToString
                        .SentenciaDistritoJudicial = f("aut_jud_nom").ToString.ToUpper
                        .SentenciaSalaJuzgado = f("sal_jud_nom").ToString.ToUpper
                        .SentenciaDocumento = f("int_sen_exp_num").ToString
                        .SentenciaCadenaPerpetua = f("int_sen_cad_per").ToString
                        .SentenciaPenaImpuestaAnio = f("int_sen_anio").ToString
                        .SentenciaPenaImpuestaMes = f("int_sen_mes").ToString
                        .SentenciaPenaImpuestaDia = f("int_sen_dia").ToString

                        intAnio = .SentenciaPenaImpuestaAnio
                        intMeses = .SentenciaPenaImpuestaMes
                        intDias = .SentenciaPenaImpuestaDia

                        If intDias >= 30 Then
                            intMeses = (intDias \ intMaxNumDias) + intMeses
                            intDias = intDias - ((intDias \ intMaxNumDias) * intMaxNumDias)
                        End If
                        If intMeses >= 12 Then
                            intAnio = (intMeses \ intMaxNumMeses) + intAnio
                            intMeses = intMeses - ((intMeses \ intMaxNumMeses) * intMaxNumMeses)
                        End If

                        .SentenciaPenaImpuestaAnio = intAnio
                        .SentenciaPenaImpuestaMes = intMeses
                        .SentenciaPenaImpuestaDia = intDias

                        .SentenciaFechaIni = f("int_sen_fec_ini").ToString
                        .SentenciaFechaFin = f("int_sen_fec_fin").ToString
                        .SentenciaObs = f("int_sen_obs").ToString.ToUpper
                        'sentencia delito
                        .SentenciaDelitoID = f("int_del_id").ToString
                        .SentenciaDelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                        .SentenciaDelitoEspecificoID = f("int_del_esp_id").ToString
                        .SentenciaDelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper
                    End With
                Next
            End If

            Return objEnt
        End Function

        Public Function ListarSentencia_tmp_v5(ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal FechaFin As Long) As Entity.Estadistica.PadinDetalle

            Dim t As DataTable = tblDatos("tblSentencia")
            Dim filas As DataRow()

            Dim strSorter As String = " int_sen_doc_fec_rcp asc"
            filas = t.Select(" int_ing_id=" & IngresoID & " and int_sen_doc_fec_rcp <=" & FechaFin, strSorter)

            Dim intMaxNumDias As Integer = 30
            Dim intMaxNumMeses As Integer = 12

            Dim intDias As Integer = 0
            Dim intMeses As Integer = 0
            Dim intAnio As Integer = 0

            objEnt = New Entity.Estadistica.PadinDetalle
            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .SentenciaID = f("int_sen_id").ToString
                        .SentenciaExpedienteID = f("int_exp_id").ToString
                        .SentenciaFecha = f("int_sen_fec").ToString
                        .SentenciaDistritoJudicial = f("aut_jud_nom").ToString.ToUpper
                        .SentenciaSalaJuzgado = f("sal_jud_nom").ToString.ToUpper
                        .SentenciaDocumento = f("int_sen_exp_num").ToString
                        .SentenciaCadenaPerpetua = f("int_sen_cad_per").ToString
                        .SentenciaPenaImpuestaAnio = f("int_sen_anio").ToString
                        .SentenciaPenaImpuestaMes = f("int_sen_mes").ToString
                        .SentenciaPenaImpuestaDia = f("int_sen_dia").ToString

                        intAnio = .SentenciaPenaImpuestaAnio
                        intMeses = .SentenciaPenaImpuestaMes
                        intDias = .SentenciaPenaImpuestaDia

                        If intDias >= 30 Then
                            intMeses = (intDias \ intMaxNumDias) + intMeses
                            intDias = intDias - ((intDias \ intMaxNumDias) * intMaxNumDias)
                        End If
                        If intMeses >= 12 Then
                            intAnio = (intMeses \ intMaxNumMeses) + intAnio
                            intMeses = intMeses - ((intMeses \ intMaxNumMeses) * intMaxNumMeses)
                        End If

                        .SentenciaPenaImpuestaAnio = intAnio
                        .SentenciaPenaImpuestaMes = intMeses
                        .SentenciaPenaImpuestaDia = intDias

                        .SentenciaFechaIni = f("int_sen_fec_ini").ToString
                        .SentenciaFechaFin = f("int_sen_fec_fin").ToString
                        .SentenciaObs = f("int_sen_obs").ToString.ToUpper
                        'sentencia delito
                        .SentenciaDelitoID = f("int_del_id").ToString
                        .SentenciaDelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                        .SentenciaDelitoEspecificoID = f("int_del_esp_id").ToString
                        .SentenciaDelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper
                    End With
                Next
            End If

            Return objEnt
        End Function
        Public Function ListarSentencia_tmp_v6(ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal FechaFin As Long) As Entity.Estadistica.PadinDetalle

            Dim t As DataTable = tblDatos("tblSentencia")
            Dim filas As DataRow()

            Dim strSorter As String = " int_sen_doc_fec_rcp desc"
            filas = t.Select(" int_ing_id=" & IngresoID & " and int_sen_doc_fec_rcp <=" & FechaFin, strSorter)

            Dim intMaxNumDias As Integer = 30
            Dim intMaxNumMeses As Integer = 12

            Dim intDias As Integer = 0
            Dim intMeses As Integer = 0
            Dim intAnio As Integer = 0
            Dim fecini As Long = 0
            Dim fecfin As Long = 0

            objEnt = New Entity.Estadistica.PadinDetalle
            If filas.Count > 0 Then
                Dim contador As Integer = 0
                Dim DocJudId As Integer = -1
                Dim DocTipId As Integer = -1
                Dim ExpedienteNum As String = ""
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        If contador = 0 Then
                            .SentenciaID = f("int_sen_id").ToString
                            .SentenciaExpedienteID = f("int_exp_id").ToString
                            .SentenciaFecha = f("int_sen_fec").ToString
                            .SentenciaDistritoJudicial = f("aut_jud_nom").ToString.ToUpper
                            .SentenciaSalaJuzgado = f("sal_jud_nom").ToString.ToUpper
                            .SentenciaDocumento = f("int_sen_exp_num").ToString
                            .SentenciaCadenaPerpetua = f("int_sen_cad_per").ToString
                            .SentenciaObs = f("int_sen_obs").ToString.ToUpper
                            'sentencia delito
                            .SentenciaDelitoID = f("int_del_id").ToString
                            .SentenciaDelitoGenerico = f("int_del_gen_nom").ToString.ToUpper
                            .SentenciaDelitoEspecificoID = f("int_del_esp_id").ToString
                            .SentenciaDelitoEspecifico = f("int_del_esp_nom").ToString.ToUpper

                            .SentenciaPenaImpuestaAnio = f("int_sen_anio").ToString
                            .SentenciaPenaImpuestaMes = f("int_sen_mes").ToString
                            .SentenciaPenaImpuestaDia = f("int_sen_dia").ToString
                            intAnio = .SentenciaPenaImpuestaAnio
                            intMeses = .SentenciaPenaImpuestaMes
                            intDias = .SentenciaPenaImpuestaDia
                            If intDias >= 30 Then
                                intMeses = (intDias \ intMaxNumDias) + intMeses
                                intDias = intDias - ((intDias \ intMaxNumDias) * intMaxNumDias)
                            End If
                            If intMeses >= 12 Then
                                intAnio = (intMeses \ intMaxNumMeses) + intAnio
                                intMeses = intMeses - ((intMeses \ intMaxNumMeses) * intMaxNumMeses)
                            End If
                            .SentenciaPenaImpuestaAnio = intAnio
                            .SentenciaPenaImpuestaMes = intMeses
                            .SentenciaPenaImpuestaDia = intDias

                            .SentenciaFechaIni = f("int_sen_fec_ini").ToString
                            .SentenciaFechaFin = f("int_sen_fec_fin").ToString
                            fecini = .SentenciaFechaIni
                            fecfin = .SentenciaFechaFin
                            DocTipId = f("doc_tip_id").ToString
                            DocJudId = .SentenciaID
                            ExpedienteNum = .SentenciaDocumento
                        Else
                            '/*----------Para el caso de Ejecutorias-----*/
                            If DocJudId = f("int_sen_id").ToString Then
                                If (f("int_sen_fec_ini").ToString > fecini) Then
                                    .SentenciaFechaIni = f("int_sen_fec_ini").ToString
                                    fecini = .SentenciaFechaIni
                                End If
                                If (f("int_sen_fec_fin").ToString > fecfin) Then
                                    .SentenciaFechaFin = f("int_sen_fec_fin").ToString
                                    fecfin = .SentenciaFechaFin
                                End If
                            Else
                                If ExpedienteNum.Trim = f("int_sen_exp_num").ToString.Trim Then
                                    If fecini = 0 And fecfin = 0 And intAnio = 0 And intMeses = 0 And intDias = 0 Then
                                        Select Case DocTipId
                                            Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior,
                                                 Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema
                                                .SentenciaPenaImpuestaAnio = f("int_sen_anio").ToString
                                                .SentenciaPenaImpuestaMes = f("int_sen_mes").ToString
                                                .SentenciaPenaImpuestaDia = f("int_sen_dia").ToString
                                                intAnio = .SentenciaPenaImpuestaAnio
                                                intMeses = .SentenciaPenaImpuestaMes
                                                intDias = .SentenciaPenaImpuestaDia
                                                If intDias >= 30 Then
                                                    intMeses = (intDias \ intMaxNumDias) + intMeses
                                                    intDias = intDias - ((intDias \ intMaxNumDias) * intMaxNumDias)
                                                End If
                                                If intMeses >= 12 Then
                                                    intAnio = (intMeses \ intMaxNumMeses) + intAnio
                                                    intMeses = intMeses - ((intMeses \ intMaxNumMeses) * intMaxNumMeses)
                                                End If
                                                .SentenciaPenaImpuestaAnio = intAnio
                                                .SentenciaPenaImpuestaMes = intMeses
                                                .SentenciaPenaImpuestaDia = intDias

                                                .SentenciaFechaIni = f("int_sen_fec_ini").ToString
                                                .SentenciaFechaFin = f("int_sen_fec_fin").ToString
                                                Exit For
                                        End Select
                                    End If
                                End If
                            End If
                        End If
                    End With
                    contador += 1
                Next
            End If

            Return objEnt
        End Function
        Dim intAnio As Integer = 0
        Dim intMeses As Integer = 0
        Dim intDias As Integer = 0
        Dim intMaxNumAnio As Integer = 0
        Dim intMaxNumMeses As Integer = 12
        Dim intMaxNumDias As Integer = 30
        Dim FecInicio As Long = 0
        Dim FecFinal As Long = 0
        Dim DocTipInstanciaSup As Integer = -1
        Public Function ListarSentencias_tmp_v6(ByVal InternoID As Integer, ByVal IngresoID As Integer, ByVal FechaFin As Long, SitJuridica As Integer, FechaRecepcion As Long, PadMov As Integer) As Entity.Estadistica.PadinDetalle
            objEnt = New Entity.Estadistica.PadinDetalle

            If PadMov = 1 And SitJuridica = 1 Then
                Return objEnt
            End If
            Dim t As DataTable = tblDatos("tblSentencia")
            Dim filas As DataRow()

            If PadMov = 2 Then
                filas = t.Select("int_ing_id=" & IngresoID & " and int_sen_doc_fec_rcp <=" & FechaFin, "int_sen_doc_fec_rcp desc, int_sen_id desc, int_del_sen_dmp desc")
            ElseIf PadMov = 3 Then
                filas = t.Select("int_ing_id=" & IngresoID & " and int_exp_pri_sen=1 and tip_lib_id<1 and n_int_exp_est_anu<>2 and int_sen_doc_fec_rcp <=" & FechaFin, "int_sen_doc_fec_rcp desc, int_sen_id desc, int_del_sen_dmp desc")
            Else
                filas = t.Select("int_ing_id=" & IngresoID & " and int_sen_doc_fec_rcp =" & FechaRecepcion, "int_sen_doc_fec_rcp desc, int_sen_id desc, int_del_sen_dmp desc")
            End If

            DocTipInstanciaSup = -1
            Dim ExpedientePadreId As Integer = -1

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    Select Case f("doc_tip_id").ToString
                        Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                            If PadMov = 3 Then Exit For
                        Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
                        Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia,
                             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionConsentida
                            If PadMov = 3 Then
                                Dim aaa As Integer = f("int_exp_hij_id").ToString
                                Dim bbb As Integer = f("int_exp_pad_id").ToString
                                Dim fec As String = f("int_sen_doc_fec_rcp").ToString
                                Dim tip As Integer = f("tip_lib_id").ToString
                                'Primera instancia
                                If f("int_exp_hij_id").ToString > 0 And PadMov > 1 Then
                                    Dim ExpedienteAux As Integer = f("int_exp_hij_id").ToString
                                    While ExpedienteAux > 0
                                        Dim fil As DataRow()
                                        fil = t.Select("int_exp_id=" & ExpedienteAux & " and int_sen_doc_fec_rcp<=" & FechaFin)
                                        If fil.Count > 0 Then
                                            If fil(0)("tip_lib_id").ToString > 0 Then
                                                If (fil(0)("doc_tip_id").ToString = 6 And fil(0)("doc_fec_mov").ToString <= FechaFin) Then
                                                    Continue For
                                                Else
                                                    ExpedienteAux = fil(0)("int_exp_hij_id").ToString()
                                                End If
                                            Else
                                                ExpedienteAux = fil(0)("int_exp_hij_id").ToString()
                                            End If
                                        Else
                                            ExpedienteAux = -1
                                        End If
                                    End While
                                End If
                                If f("int_exp_pad_id").ToString > 0 And PadMov > 1 Then
                                    Dim ExpedienteAux As Integer = f("int_exp_pad_id").ToString
                                    While ExpedienteAux > 0
                                        Dim fil As DataRow()
                                        fil = t.Select("int_exp_id=" & ExpedienteAux & " and int_sen_doc_fec_rcp<=" & FechaFin)
                                        If fil.Count > 0 Then
                                            If fil(0)("tip_lib_id").ToString > 0 Then
                                                Continue For
                                            Else
                                                ExpedienteAux = fil(0)("int_exp_pad_id").ToString()
                                            End If
                                        Else
                                            ExpedienteAux = -1
                                        End If
                                    End While
                                End If
                            ElseIf PadMov = 1 Then
                                If f("int_exp_visible").ToString = 0 Or f("int_del_sen_dmp").ToString = False Then
                                    Continue For
                                End If
                            End If

                            With objEnt
                                .SentenciaID = f("int_sen_id").ToString
                                .SentenciaExpedienteID = f("int_exp_id").ToString
                                .SentenciaPIFecha = f("int_sen_fec").ToString
                                .SentenciaPIDistritoJudicial = f("aut_jud_nom").ToString.ToUpper
                                .SentenciaPISalaJuzgado = f("sal_jud_nom").ToString.ToUpper
                                .SentenciaPIExpedienteNumero = f("int_sen_exp_num").ToString
                                If DocTipInstanciaSup = -1 Then
                                    .SentenciaCadenaPerpetua = f("int_sen_cad_per").ToString
                                    .SentenciaObs = f("int_sen_obs").ToString
                                    'tiempo condena
                                    .SentenciaPenaImpuestaAnio = f("int_sen_anio").ToString
                                    .SentenciaPenaImpuestaMes = f("int_sen_mes").ToString
                                    .SentenciaPenaImpuestaDia = f("int_sen_dia").ToString
                                    intAnio = .SentenciaPenaImpuestaAnio
                                    intMeses = .SentenciaPenaImpuestaMes
                                    intDias = .SentenciaPenaImpuestaDia
                                    If intDias >= 30 Then
                                        intMeses = (intDias \ intMaxNumDias) + intMeses
                                        intDias = intDias - ((intDias \ intMaxNumDias) * intMaxNumDias)
                                    End If
                                    If intMeses >= 12 Then
                                        intAnio = (intMeses \ intMaxNumMeses) + intAnio
                                        intMeses = intMeses - ((intMeses \ intMaxNumMeses) * intMaxNumMeses)
                                    End If
                                    .SentenciaPenaImpuestaAnio = intAnio
                                    .SentenciaPenaImpuestaMes = intMeses
                                    .SentenciaPenaImpuestaDia = intDias
                                    .SentenciaFechaIni = f("int_sen_fec_ini").ToString
                                    .SentenciaFechaFin = f("int_sen_fec_fin").ToString
                                    'Delitos
                                    If f("int_del_sen_dmp").ToString = True Then
                                        .SentenciaDelitoID = f("int_del_gen_id").ToString
                                        .SentenciaDelitoGenerico = f("int_del_gen_nom").ToString
                                        .SentenciaDelitoEspecificoID = f("int_del_esp_id").ToString
                                        .SentenciaDelitoEspecifico = f("int_del_esp_nom").ToString
                                        Exit For
                                    End If
                                Else 'Cuando existe segunda instancia
                                    'Periodo
                                    If FecInicio = 0 And FecFinal = 0 And
                                       intAnio = 0 And intMeses = 0 And intDias = 0 And intDias = 0 Then
                                        Select Case DocTipInstanciaSup
                                            Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior,
                                                 Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema

                                                .SentenciaPenaImpuestaAnio = f("int_sen_anio").ToString
                                                .SentenciaPenaImpuestaMes = f("int_sen_mes").ToString
                                                .SentenciaPenaImpuestaDia = f("int_sen_dia").ToString
                                                intAnio = .SentenciaPenaImpuestaAnio
                                                intMeses = .SentenciaPenaImpuestaMes
                                                intDias = .SentenciaPenaImpuestaDia
                                                If intDias >= 30 Then
                                                    intMeses = (intDias \ intMaxNumDias) + intMeses
                                                    intDias = intDias - ((intDias \ intMaxNumDias) * intMaxNumDias)
                                                End If
                                                If intMeses >= 12 Then
                                                    intAnio = (intMeses \ intMaxNumMeses) + intAnio
                                                    intMeses = intMeses - ((intMeses \ intMaxNumMeses) * intMaxNumMeses)
                                                End If
                                                .SentenciaPenaImpuestaAnio = intAnio
                                                .SentenciaPenaImpuestaMes = intMeses
                                                .SentenciaPenaImpuestaDia = intDias
                                                .SentenciaFechaIni = f("int_sen_fec_ini").ToString
                                                .SentenciaFechaFin = f("int_sen_fec_fin").ToString
                                                Exit For
                                        End Select
                                    End If
                                End If
                            End With
                        Case Else   'Instancia superior
                            Select Case f("doc_tip_id").ToString
                                Case 34
                                Case Else
                                    If DocTipInstanciaSup < 1 Then
                                        If PadMov = 3 Then
                                            If f("int_exp_hij_id").ToString > 0 And PadMov > 1 Then
                                                Dim ExpedienteAux As Integer = f("int_exp_hij_id").ToString
                                                While ExpedienteAux > 0
                                                    Dim fil As DataRow()
                                                    fil = t.Select("int_exp_id=" & ExpedienteAux & " and int_sen_doc_fec_rcp<=" & FechaFin)
                                                    If fil.Count > 0 Then
                                                        If fil(0)("tip_lib_id").ToString > 0 Then
                                                            If (fil(0)("doc_tip_id").ToString = 6 And fil(0)("doc_fec_mov").ToString <= FechaFin) Then
                                                                Continue For
                                                            Else
                                                                ExpedienteAux = fil(0)("int_exp_hij_id").ToString()
                                                            End If
                                                        Else
                                                            ExpedienteAux = fil(0)("int_exp_hij_id").ToString()
                                                        End If
                                                    Else
                                                        ExpedienteAux = -1
                                                    End If
                                                End While
                                            End If
                                            If f("int_exp_pad_id").ToString > 0 And PadMov > 1 Then
                                                Dim ExpedienteAux As Integer = f("int_exp_pad_id").ToString
                                                While ExpedienteAux > 0
                                                    Dim fil As DataRow()
                                                    fil = t.Select("int_exp_id=" & ExpedienteAux & " and int_sen_doc_fec_rcp<=" & FechaFin)
                                                    If fil.Count > 0 Then
                                                        If fil(0)("tip_lib_id").ToString > 0 Then
                                                            Continue For
                                                        Else
                                                            ExpedienteAux = fil(0)("int_exp_pad_id").ToString()
                                                        End If
                                                    Else
                                                        ExpedienteAux = -1
                                                    End If
                                                End While
                                            End If
                                        End If
                                        With objEnt
                                            .SentenciaSIDistritoJudicial = f("aut_jud_nom").ToString.ToUpper
                                            .SentenciaSISalaJuzgado = f("sal_jud_nom").ToString.ToUpper
                                            .SentenciaCadenaPerpetua = f("int_sen_cad_per").ToString
                                            .SentenciaObs = f("int_sen_obs").ToString
                                            .SentenciaSIExpedienteNumero = f("int_sen_exp_num").ToString
                                            If f("doc_tip_id").ToString = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema Then
                                                .SentenciaSIExpedienteNumero = f("int_sen_doc_num").ToString
                                            End If
                                            .SentenciaPenaImpuestaAnio = f("int_sen_anio").ToString
                                            .SentenciaPenaImpuestaMes = f("int_sen_mes").ToString
                                            .SentenciaPenaImpuestaDia = f("int_sen_dia").ToString
                                            intAnio = .SentenciaPenaImpuestaAnio
                                            intMeses = .SentenciaPenaImpuestaMes
                                            intDias = .SentenciaPenaImpuestaDia
                                            If intDias >= 30 Then
                                                intMeses = (intDias \ intMaxNumDias) + intMeses
                                                intDias = intDias - ((intDias \ intMaxNumDias) * intMaxNumDias)
                                            End If
                                            If intMeses >= 12 Then
                                                intAnio = (intMeses \ intMaxNumMeses) + intAnio
                                                intMeses = intMeses - ((intMeses \ intMaxNumMeses) * intMaxNumMeses)
                                            End If
                                            .SentenciaPenaImpuestaAnio = intAnio
                                            .SentenciaPenaImpuestaMes = intMeses
                                            .SentenciaPenaImpuestaDia = intDias
                                            .SentenciaFechaIni = f("int_sen_fec_ini").ToString
                                            .SentenciaFechaFin = f("int_sen_fec_fin").ToString
                                            FecInicio = .SentenciaFechaIni
                                            FecFinal = .SentenciaFechaFin
                                            ExpedientePadreId = f("int_exp_pad_id").ToString
                                        End With
                                        With objEnt
                                            'Delitos
                                            If (f("int_del_sen_dmp").ToString = True And DocTipInstanciaSup < 1) Then
                                                .SentenciaDelitoID = f("int_del_gen_id").ToString
                                                .SentenciaDelitoGenerico = f("int_del_gen_nom").ToString
                                                .SentenciaDelitoEspecificoID = f("int_del_esp_id").ToString
                                                .SentenciaDelitoEspecifico = f("int_del_esp_nom").ToString
                                            End If
                                        End With
                                    End If
                                    DocTipInstanciaSup = f("doc_tip_id").ToString
                            End Select
                    End Select
                Next
                With objEnt
                    If objEnt.SentenciaID < 1 And DocTipInstanciaSup > 0 Then
                        If DocTipInstanciaSup = 19 Or DocTipInstanciaSup = 29 Then
                            filas = t.Select("int_ing_id=" & IngresoID & " and doc_tip_id in (19,29) and tip_lib_id<1 and int_sen_doc_fec_rcp <=" & FechaFin, "int_sen_doc_fec_rcp desc, int_sen_id desc, int_del_sen_dmp desc")
                            For Each f As System.Data.DataRow In filas
                                If ExpedientePadreId < 1 Then
                                    ExpedientePadreId = f("int_exp_pad_id").ToString
                                End If
                            Next
                        End If
                        While ExpedientePadreId > 0
                            filas = t.Select("int_ing_id=" & IngresoID & " and int_exp_id=" & ExpedientePadreId & " and tip_lib_id<1 and int_sen_doc_fec_rcp <=" & FechaFin, "int_sen_doc_fec_rcp desc, int_sen_id desc")
                            If filas.Count > 0 Then
                                For Each f As System.Data.DataRow In filas
                                    Select Case f("doc_tip_id").ToString
                                        Case 17, 27
                                            .SentenciaID = f("int_sen_id").ToString
                                            .SentenciaExpedienteID = f("int_exp_id").ToString
                                            .SentenciaPIFecha = f("int_sen_fec").ToString
                                            .SentenciaPIDistritoJudicial = f("aut_jud_nom").ToString.ToUpper
                                            .SentenciaPISalaJuzgado = f("sal_jud_nom").ToString.ToUpper
                                            .SentenciaPIExpedienteNumero = f("int_sen_exp_num").ToString
                                            ExpedientePadreId = -1
                                        Case Else
                                            ExpedientePadreId = f("int_exp_pad_id").ToString
                                    End Select
                                Next
                            Else
                                ExpedientePadreId = -1
                            End If
                        End While
                    ElseIf objEnt.SentenciaID < 1 And objEnt.SentenciaDelitoID < 1 Then
                        For Each f As System.Data.DataRow In filas
                            If f("int_exp_pri_sen").ToString = True And f("int_del_sen_dmp").ToString = True Then
                                .SentenciaDelitoID = f("int_del_gen_id").ToString
                                .SentenciaDelitoGenerico = f("int_del_gen_nom").ToString
                                .SentenciaDelitoEspecificoID = f("int_del_esp_id").ToString
                                .SentenciaDelitoEspecifico = f("int_del_esp_nom").ToString
                                Select Case f("doc_tip_id").ToString
                                    Case 26, 34, 6
                                        Dim fil As DataRow()
                                        Dim intVal As Integer = f("int_exp_pad_id").ToString
                                        While intVal > 0
                                            fil = t.Select("int_exp_id=" & intVal & " and int_sen_doc_fec_rcp<=" & FechaFin)
                                            If fil.Count > 0 Then
                                                Select Case fil(0)("doc_tip_id").ToString
                                                    Case 17, 27
                                                        objEnt.SentenciaID = fil(0)("int_sen_id").ToString
                                                        objEnt.SentenciaExpedienteID = fil(0)("int_exp_id").ToString
                                                        objEnt.SentenciaPIFecha = fil(0)("int_sen_fec").ToString
                                                        objEnt.SentenciaPIDistritoJudicial = fil(0)("aut_jud_nom").ToString.ToUpper
                                                        objEnt.SentenciaPISalaJuzgado = fil(0)("sal_jud_nom").ToString.ToUpper
                                                        objEnt.SentenciaPIExpedienteNumero = fil(0)("int_sen_exp_num").ToString
                                                        If DocTipInstanciaSup < 1 Then
                                                            objEnt.SentenciaCadenaPerpetua = fil(0)("int_sen_cad_per").ToString
                                                            objEnt.SentenciaObs = fil(0)("int_sen_obs").ToString
                                                            'tiempo condena
                                                            objEnt.SentenciaPenaImpuestaAnio = fil(0)("int_sen_anio").ToString
                                                            objEnt.SentenciaPenaImpuestaMes = fil(0)("int_sen_mes").ToString
                                                            objEnt.SentenciaPenaImpuestaDia = fil(0)("int_sen_dia").ToString
                                                            intAnio = objEnt.SentenciaPenaImpuestaAnio
                                                            intMeses = objEnt.SentenciaPenaImpuestaMes
                                                            intDias = objEnt.SentenciaPenaImpuestaDia
                                                            If intDias >= 30 Then
                                                                intMeses = (intDias \ intMaxNumDias) + intMeses
                                                                intDias = intDias - ((intDias \ intMaxNumDias) * intMaxNumDias)
                                                            End If
                                                            If intMeses >= 12 Then
                                                                intAnio = (intMeses \ intMaxNumMeses) + intAnio
                                                                intMeses = intMeses - ((intMeses \ intMaxNumMeses) * intMaxNumMeses)
                                                            End If
                                                            objEnt.SentenciaPenaImpuestaAnio = intAnio
                                                            objEnt.SentenciaPenaImpuestaMes = intMeses
                                                            objEnt.SentenciaPenaImpuestaDia = intDias
                                                            objEnt.SentenciaFechaIni = fil(0)("int_sen_fec_ini").ToString
                                                            objEnt.SentenciaFechaFin = fil(0)("int_sen_fec_fin").ToString
                                                        End If
                                                        Exit For
                                                    Case 18, 19, 20, 21, 22, 23, 24, 25, 26, 28, 29, 31, 32, 33, 37
                                                        intVal = fil(0)("int_exp_pad_id").ToString
                                                        Dim TipDoc As Integer = fil(0)("doc_tip_id").ToString
                                                        While TipDoc = 26 'Queda
                                                            fil = t.Select("int_exp_id=" & intVal & " and int_sen_doc_fec_rcp<=" & FechaFin)
                                                            If fil.Count = 0 Then
                                                                TipDoc = -1
                                                                intVal = -1
                                                            Else
                                                                TipDoc = fil(0)("doc_tip_id").ToString
                                                                intVal = fil(0)("int_exp_pad_id").ToString
                                                            End If
                                                        End While

                                                        If DocTipInstanciaSup < 1 And TipDoc > 0 Then
                                                            DocTipInstanciaSup = fil(0)("doc_tip_id").ToString
                                                            .SentenciaSIDistritoJudicial = fil(0)("aut_jud_nom").ToString.ToUpper
                                                            .SentenciaSISalaJuzgado = fil(0)("sal_jud_nom").ToString.ToUpper
                                                            .SentenciaCadenaPerpetua = fil(0)("int_sen_cad_per").ToString
                                                            .SentenciaObs = fil(0)("int_sen_obs").ToString
                                                            .SentenciaSIExpedienteNumero = fil(0)("int_sen_exp_num").ToString
                                                            If fil(0)("doc_tip_id").ToString = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema Then
                                                                .SentenciaSIExpedienteNumero = fil(0)("int_sen_doc_num").ToString
                                                            End If
                                                            objEnt.SentenciaCadenaPerpetua = fil(0)("int_sen_cad_per").ToString
                                                            objEnt.SentenciaObs = fil(0)("int_sen_obs").ToString
                                                            'tiempo condena
                                                            objEnt.SentenciaPenaImpuestaAnio = fil(0)("int_sen_anio").ToString
                                                            objEnt.SentenciaPenaImpuestaMes = fil(0)("int_sen_mes").ToString
                                                            objEnt.SentenciaPenaImpuestaDia = fil(0)("int_sen_dia").ToString
                                                            intAnio = objEnt.SentenciaPenaImpuestaAnio
                                                            intMeses = objEnt.SentenciaPenaImpuestaMes
                                                            intDias = objEnt.SentenciaPenaImpuestaDia
                                                            If intDias >= 30 Then
                                                                intMeses = (intDias \ intMaxNumDias) + intMeses
                                                                intDias = intDias - ((intDias \ intMaxNumDias) * intMaxNumDias)
                                                            End If
                                                            If intMeses >= 12 Then
                                                                intAnio = (intMeses \ intMaxNumMeses) + intAnio
                                                                intMeses = intMeses - ((intMeses \ intMaxNumMeses) * intMaxNumMeses)
                                                            End If
                                                            objEnt.SentenciaPenaImpuestaAnio = intAnio
                                                            objEnt.SentenciaPenaImpuestaMes = intMeses
                                                            objEnt.SentenciaPenaImpuestaDia = intDias
                                                            objEnt.SentenciaFechaIni = fil(0)("int_sen_fec_ini").ToString
                                                            objEnt.SentenciaFechaFin = fil(0)("int_sen_fec_fin").ToString
                                                        End If
                                                    Case 34
                                                        intVal = fil(0)("int_exp_pad_id").ToString
                                                    Case Else
                                                        intVal = -1
                                                End Select
                                            Else
                                                intVal = -1
                                            End If
                                        End While
                                End Select
                            End If
                        Next
                    End If
                End With

            End If
            Return objEnt
        End Function

        Public Function ListarEgreso_tmp(IdIntresoXTraslado As Integer, ExpedienteId As Integer) As Entity.Estadistica.PadinDetalle
            Dim t As DataTable
            Dim filas As DataRow()
            If IdIntresoXTraslado > 0 Then
                t = tblDatos("tblEgresoPorTraslado")
                filas = t.Select(" codigo=" & IdIntresoXTraslado)
            Else
                t = tblDatos("tblEgresoPorExpediente")
                filas = t.Select(" egr_id=" & ExpedienteId)
            End If

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .EgresoFecha = f("egr_fec").ToString
                        .EgresoTipoID = f("egr_tip_id").ToString
                        .EgresoTipo = f("egr_tip_nom").ToString
                        .EgresoTipoMotivoID = f("egr_tip_mov_id").ToString
                        .EgresoTipoMotivo = f("egr_tip_mov_nom").ToString.ToUpper
                        .EgresoDestino = f("egr_des_nom").ToString.ToUpper
                        .EgresoDistritoJudicial = f("dis_jud_nom").ToString.ToUpper
                        .EgresoSalaJuzgado = f("sal_juz_nom").ToString.ToUpper
                        .EgresoJuez = f("egr_jue").ToString.ToUpper
                        .EgresoSecretario = f("egr_sec").ToString.ToUpper
                        .EgresoDocumentoLibertad = f("int_ing_exp_num").ToString
                        .EgresoDocumento = f("egr_doc").ToString
                        .EgresoObservacion = f("egr_obs").ToString.ToUpper
                    End With
                Next
            End If
            Return objEnt
        End Function

        Public Function ListarEgreso_tmp_v5(IdIntresoXTraslado As Integer, ExpedienteId As Integer, TipoDetallSal As Integer) As Entity.Estadistica.PadinDetalle
            Dim t As DataTable
            Dim filas As DataRow()

            t = tblDatos("tblEgresoMovimiento")
            filas = t.Select(" codigo=" & IdIntresoXTraslado)

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .EgresoFecha = f("egr_fec").ToString
                        .EgresoTipoID = f("egr_tip_id").ToString
                        .EgresoTipo = f("egr_tip_nom").ToString
                        .EgresoTipoMotivoID = f("egr_tip_mov_id").ToString
                        .EgresoTipoMotivo = f("egr_tip_mov_nom").ToString.ToUpper
                        .EgresoDestino = f("egr_des_nom").ToString.ToUpper
                        .EgresoTipoAutoridadID = f("doc_jud_tip_aut_id").ToString.ToUpper
                        .EgresoDistritoJudicial = f("dis_jud_nom").ToString.ToUpper
                        .EgresoSalaJuzgado = f("sal_juz_nom").ToString.ToUpper
                        .EgresoJuez = f("egr_jue").ToString.ToUpper
                        .EgresoSecretario = f("egr_sec").ToString.ToUpper
                        .EgresoOtroNombre = f("egr_sec").ToString.ToUpper
                        .EgresoOtraAutoridad = f("egr_sec").ToString.ToUpper
                        .EgresoDocumentoLibertad = f("int_ing_exp_num").ToString
                        .EgresoDocumento = f("egr_doc").ToString
                        .EgresoObservacion = f("egr_obs").ToString.ToUpper
                        .TipoMovimientoID = f("mov_tip_id").ToString
                    End With
                Next
            End If
            Return objEnt
        End Function

        Public Function ListarEgreso_tmp_v6(IdIntresoXTraslado As Integer, ExpedienteId As Integer, TipoDetallSal As Integer) As Entity.Estadistica.PadinDetalle
            Dim t As DataTable
            Dim filas As DataRow()

            t = tblDatos("tblEgresoMovimiento")
            filas = t.Select(" codigo=" & IdIntresoXTraslado)

            If filas.Count > 0 Then
                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .EgresoFecha = f("egr_fec").ToString
                        .EgresoTipoID = f("egr_tip_id").ToString
                        .EgresoTipo = f("egr_tip_nom").ToString
                        .EgresoTipoMotivoID = f("egr_tip_mov_id").ToString
                        .LibertadSubtipoNom = f("sub_tip_lib_nom").ToString.ToUpper
                        Dim var As String = .LibertadSubtipoNom
                        .EgresoTipoMotivo = f("egr_tip_mov_nom").ToString.ToUpper & IIf(var.Length = 0, "", " (") & var & IIf(var.Length = 0, "", ")")
                        .EgresoDestino = f("egr_des_nom").ToString.ToUpper
                        .EgresoTipoAutoridadID = f("doc_jud_tip_aut_id").ToString.ToUpper
                        .EgresoDistritoJudicial = f("dis_jud_nom").ToString.ToUpper
                        .EgresoSalaJuzgado = f("sal_juz_nom").ToString.ToUpper
                        .EgresoJuez = f("egr_jue").ToString.ToUpper
                        .EgresoSecretario = f("egr_sec").ToString.ToUpper
                        .EgresoOtroNombre = f("egr_sec").ToString.ToUpper
                        .EgresoOtraAutoridad = f("egr_sec").ToString.ToUpper
                        .EgresoDocumentoLibertad = f("int_ing_exp_num").ToString
                        .EgresoDocumento = f("egr_doc").ToString
                        '.EgresoDocumentoRD = f("egr_doc_aux").ToString
                        .EgresoObservacion = f("egr_obs").ToString.ToUpper
                        .TipoMovimientoID = f("mov_tip_id").ToString
                    End With
                Next
            End If
            Return objEnt
        End Function

        Public Function ListarExpedientesEgreso_tmp_v5(DocumentoId As Integer) As Entity.Estadistica.PadinDetalle
            Dim t As DataTable
            Dim filas As DataRow()

            t = tblDatos("tblExpedienteEgreso")
            filas = t.Select(" codigo=" & DocumentoId)

            Dim strExpedientes As String = ""
            If filas.Count > 0 Then

                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .EgresoDocumentoLibertad = f("int_ing_exp_num").ToString
                        strExpedientes = strExpedientes & .EgresoDocumentoLibertad & ","
                    End With
                    strExpedientes = Legolas.Components.Cadena.Left(strExpedientes, strExpedientes.Length - 2)
                Next
            End If
            Return objEnt
        End Function
        Public Function ListarExpedientesEgreso_tmp_v6(DocumentoId As Integer) As Entity.Estadistica.PadinDetalle
            Dim t As DataTable
            Dim filas As DataRow()

            t = tblDatos("tblExpedienteEgreso")
            filas = t.Select(" codigo=" & DocumentoId, " int_exp_pri_sen")

            Dim strExpedientes As String = ""
            If filas.Count > 0 Then

                For Each f As System.Data.DataRow In filas
                    With objEnt
                        .IDExpedienteEgreso = f("int_exp_id").ToString
                        .EgresoDocumentoLibertad = f("int_ing_exp_num").ToString
                        strExpedientes = strExpedientes & .EgresoDocumentoLibertad & ","
                    End With
                    strExpedientes = Legolas.Components.Cadena.Left(strExpedientes, strExpedientes.Length - 2)
                Next
            End If
            Return objEnt
        End Function

        Private Function ListarNombresAsociados_tmp(ByVal InternoID As Integer) As String
            Dim t As DataTable = tblDatos("tblNombresAsociados")

            Dim strValue As String = ""
            Dim strReturn As String = ""

            If t.Select("int_id=" & InternoID).Count > 0 Then
                For Each f As System.Data.DataRow In t.Select("int_id=" & InternoID)
                    strValue = strValue & f("int_aso_ape_pat").ToString & " " & f("int_aso_ape_mat").ToString & ", " & f("int_aso_nom").ToString & " o "
                Next
                strReturn = Legolas.Components.Cadena.Left(strValue, strValue.Length - 3)
            Else
                strReturn = ""
            End If
            Return strReturn.ToUpper
        End Function

        Private Function ListarAlias_tmp(ByVal InternoID As Integer) As String
            Dim t As DataTable = tblDatos("tblInternoAlias")

            Dim strValue As String = ""
            Dim strReturn As String = ""

            Dim strNombre As String = ""

            If t.Select("int_id=" & InternoID).Count > 0 Then
                For Each f As System.Data.DataRow In t.Select("int_id=" & InternoID)
                    strNombre = f("int_ali_nom").ToString
                    strValue = strValue & strNombre & ", "
                Next
                strReturn = Legolas.Components.Cadena.Left(strValue, strValue.Length - 2)
            Else
                strReturn = ""
            End If
            Return strReturn.ToUpper
        End Function

        Public Function ListarDatosExpedienteHijo(obj As Entity.Estadistica.PadinDetalle) As Entity.Estadistica.PadinDetalle

            'version old del pope
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.ListarExpedienteHijo(sqlCon, "lst", "lst_exp_hij", obj)

            Try
                'objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle
                        With objEnt

                            'sentencia
                            .SentenciaID = sqlDr("int_sen_id").ToString
                            .SentenciaFecha = sqlDr("sent_fec").ToString
                            .SentenciaDistritoJudicial = sqlDr("aut_jud_nom").ToString.ToUpper
                            .SentenciaSalaJuzgado = sqlDr("sal_jud_nom").ToString.ToUpper
                            .SentenciaExpedienteID = sqlDr("int_exp_id").ToString
                            .SentenciaDocumento = sqlDr("int_sen_exp_num").ToString
                            .SentenciaDelitoGenerico = sqlDr("int_del_gen_nom").ToString.ToUpper
                            .SentenciaDelitoEspecifico = sqlDr("int_del_esp_nom").ToString.ToUpper
                            .SentenciaPenaImpuestaAnio = sqlDr("int_sen_anio").ToString
                            .SentenciaPenaImpuestaMes = sqlDr("int_sen_mes").ToString
                            .SentenciaPenaImpuestaDia = sqlDr("int_sen_dia").ToString
                            .SentenciaFecha = sqlDr("int_sen_fec_ini").ToString
                            .SentenciaFechaIni = sqlDr("int_sen_fec_ini").ToString
                            .SentenciaFechaFin = sqlDr("int_sen_fec_fin").ToString
                            .SentenciaObs = sqlDr("int_sen_obs").ToString.ToUpper


                        End With
                        'objEntCol.Add(objEnt)
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
#End Region

#Region "Listar_Datos_Complementarios"
        Public Sub DatosComplementarios(PadinID As Integer, RegionID As Integer, PenalID As Integer, FechaIni As Long, FechaFin As Long, PadinVisible As Integer, PadinTipoMov As Integer, ByRef objEntColInterno As Entity.Estadistica.PadinDetalleCol)

            Dim idsInterno As String = ""
            Dim idsIngreso As String = ""
            Dim idsTraslados As String = ""

            Dim idsEgresoTraslados As String = ""
            Dim idsEgresoExpediente As String = ""

            Dim objBssPadinDetalle As Bussines.Estadistica.PadinDetalle = Nothing
            Dim objEntPadinDetalleTemp As Entity.Estadistica.PadinDetalle = Nothing

            '/*interno familia*/
            Dim objBssFamilia As New Bussines.Registro.Familiar
            Dim objEntColFamilia As New Entity.Registro.FamiliarCol

            '/*padin detalle familia*/
            Dim objBssPadinDetalleFam As Bussines.Estadistica.PadinDetalleFamilia = Nothing
            Dim objEntPadinDetalleFam As Entity.Estadistica.PadinDetalleFamilia = Nothing
            Dim objEntPadinDetalleColFam As Entity.Estadistica.PadinDetalleFamiliaCol = Nothing

            objEntPadinDetalleColFam = New Entity.Estadistica.PadinDetalleFamiliaCol

            idsInterno = ConcatenarIdsInterno(objEntColInterno)
            idsIngreso = ConcatenarIdsIngreso((objEntColInterno))
            idsTraslados = ConcatenarIdsTraslado((objEntColInterno))

            idsEgresoTraslados = ConcatenarIdsEgresoTraslado((objEntColInterno))
            idsEgresoExpediente = ConcatenarIdsEgresoExpediente((objEntColInterno))


            tblDatos = Data.Estadistica.PadinDetalle.ListarDatosComplementarios("lst", "datos_complementarios", idsInterno, idsIngreso, idsTraslados,
                                                                                idsEgresoTraslados, idsEgresoExpediente, FechaFin)



            For Each objEntInterno As Entity.Estadistica.PadinDetalle In objEntColInterno



                With objEntInterno
                    .Codigo = -1
                    If .InternoSexo.ToUpper = "" Then
                    ElseIf .InternoSexo.ToUpper = "MASCULINO" Then
                        .InternoSexo = "M"
                    Else
                        .InternoSexo = "F"
                    End If
                    .PadinID = PadinID
                    .RegionID = RegionID
                    .PenalID = PenalID
                    .FechaCorte = FechaFin
                    .InternoNombresAsociados = ListarNombresAsociados_tmp(objEntInterno.InternoID)
                    .InternoAlias = ListarAlias_tmp(objEntInterno.InternoID)
                    If objEntInterno.InternoTipoDocumentoID <= 0 Then .InternoTipoDocumento = "INDOCUMENTADO"

                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = ListarIngreso_tmp(.IngresoID, .TrasladoId, FechaIni, FechaFin)
                    .IngresoID = objEntPadinDetalleTemp.IngresoID
                    .FechaISP = objEntPadinDetalleTemp.FechaISP
                    .IngresoNumero = objEntPadinDetalleTemp.IngresoNumero
                    .IngresoMotivo = objEntPadinDetalleTemp.IngresoMotivo     ' objEntPadinDetalleTemp.IngresoMotivo
                    .IngresoOrigen = objEntPadinDetalleTemp.IngresoOrigen
                    .IngresoDocumento = objEntPadinDetalleTemp.IngresoDocumento
                    .IngresoMotivoTraslado = objEntPadinDetalleTemp.IngresoMotivoTraslado
                    .FechaIngresoPenal = objEntPadinDetalleTemp.FechaIngresoPenal

                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = DatosComplementarios_Siscrico(.InternoID, FechaFin)

                    .GruposDelictivosOtros = objEntPadinDetalleTemp.GruposDelictivosOtros
                    .OrgCriminalFormaParte = objEntPadinDetalleTemp.OrgCriminalFormaParte
                    .OrgCriminalCondicion = objEntPadinDetalleTemp.OrgCriminalCondicion
                    .OrgCriminalNombre = objEntPadinDetalleTemp.OrgCriminalNombre

                    .IngresoSituacionJuridicaID = ListarIngresoSituacionJuridicaID_tmp(.InternoID, .IngresoID, FechaFin, PadinTipoMov)
                    .IngresoSituacionJuridica = ListarIngresoSituacionJuridica(.IngresoSituacionJuridicaID)
                    .InternoNumeroHijo = NumeroHijo(.InternoID)
                    '/*expediente*/

                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = ListarExpediente_tmp(.InternoID, .IngresoID, .TrasladoId, FechaIni, FechaFin)

                    .ExpedienteID = objEntPadinDetalleTemp.ExpedienteID
                    .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                    .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                    .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                    .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                    .ExpedienteSituacionJuridicaID = objEntPadinDetalleTemp.ExpedienteSituacionJuridicaID
                    .ExpedienteSituacionJuridica = objEntPadinDetalleTemp.ExpedienteSituacionJuridica
                    .ExpedienteNumero = objEntPadinDetalleTemp.ExpedienteNumero
                    .DelitoFlagrante = objEntPadinDetalleTemp.ExpedienteFlagrancia

                    .ExpedienteNumeroOtros = ListarExpedientesOtros_tmp(.InternoID, .IngresoID, .ExpedienteID, FechaIni, FechaFin)

                    '/*delitos*/
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle

                    objEntPadinDetalleTemp = ListarDelitoMayorPena_tmp(.InternoID, .IngresoID, .ExpedienteID)

                    .DelitoID = objEntPadinDetalleTemp.DelitoID
                    .DelitoGenericoID = objEntPadinDetalleTemp.DelitoGenericoID
                    .DelitoGenerico = objEntPadinDetalleTemp.DelitoGenerico
                    .DelitoEspecificoID = objEntPadinDetalleTemp.DelitoEspecificoID
                    .DelitoEspecifico = objEntPadinDetalleTemp.DelitoEspecifico
                    .DelitoOtros = ListarDelitosExpediente_tmp(.InternoID, .IngresoID, .ExpedienteID)
                    .DelitoAgraviados = ListarDelitoAgraviados_tmp(.DelitoID)


                    '/*sentencia*/
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = ListarSentencia_tmp(.InternoID, .IngresoID, FechaIni, FechaFin)

                    .SentenciaID = objEntPadinDetalleTemp.SentenciaID
                    .SentenciaExpedienteID = objEntPadinDetalleTemp.SentenciaExpedienteID
                    .SentenciaDocumento = objEntPadinDetalleTemp.SentenciaDocumento
                    .SentenciaFecha = objEntPadinDetalleTemp.SentenciaFecha
                    .SentenciaDistritoJudicial = objEntPadinDetalleTemp.SentenciaDistritoJudicial
                    .SentenciaSalaJuzgado = objEntPadinDetalleTemp.SentenciaSalaJuzgado
                    .SentenciaDocumento = objEntPadinDetalleTemp.SentenciaDocumento
                    .SentenciaCadenaPerpetua = objEntPadinDetalleTemp.SentenciaCadenaPerpetua

                    If .SentenciaCadenaPerpetua = True Then
                        .SentenciaPenaImpuestaAnio = 500 'cadena perpetua
                    Else
                        .SentenciaPenaImpuestaAnio = objEntPadinDetalleTemp.SentenciaPenaImpuestaAnio
                    End If

                    .SentenciaPenaImpuestaMes = objEntPadinDetalleTemp.SentenciaPenaImpuestaMes
                    .SentenciaPenaImpuestaDia = objEntPadinDetalleTemp.SentenciaPenaImpuestaDia

                    .SentenciaFechaIni = objEntPadinDetalleTemp.SentenciaFechaIni
                    .SentenciaFechaFin = objEntPadinDetalleTemp.SentenciaFechaFin
                    .SentenciaObs = objEntPadinDetalleTemp.SentenciaObs
                    .SentenciaDelitoID = objEntPadinDetalleTemp.SentenciaDelitoID
                    .SentenciaDelitoGenerico = objEntPadinDetalleTemp.SentenciaDelitoGenerico
                    .SentenciaDelitoEspecificoID = objEntPadinDetalleTemp.SentenciaDelitoEspecificoID
                    .SentenciaDelitoEspecifico = objEntPadinDetalleTemp.SentenciaDelitoEspecifico

                    'egreso
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle

                    If .PadinTipoMovimiento = 2 Then
                        objEntPadinDetalleTemp = ListarEgreso_tmp(.EgresoTrasladoId, .ExpedienteLibertarID)
                        .EgresoDestino = objEntPadinDetalleTemp.EgresoDestino
                        .EgresoDistritoJudicial = objEntPadinDetalleTemp.EgresoDistritoJudicial
                        .EgresoSalaJuzgado = objEntPadinDetalleTemp.EgresoSalaJuzgado
                        .EgresoJuez = objEntPadinDetalleTemp.EgresoJuez
                        .EgresoSecretario = objEntPadinDetalleTemp.EgresoSecretario
                        .EgresoFecha = objEntPadinDetalleTemp.EgresoFecha
                        .EgresoObservacion = objEntPadinDetalleTemp.EgresoObservacion


                        .EgresoTipoID = objEntPadinDetalleTemp.EgresoTipoID
                        .EgresoTipo = objEntPadinDetalleTemp.EgresoTipo
                        .EgresoTipoMotivoID = objEntPadinDetalleTemp.EgresoTipoMotivoID
                        .EgresoTipoMotivo = objEntPadinDetalleTemp.EgresoTipoMotivo
                        .EgresoDocumentoLibertad = objEntPadinDetalleTemp.EgresoDocumentoLibertad
                        .EgresoDocumento = objEntPadinDetalleTemp.EgresoDocumento

                    End If

                    '/*detalle familia*/
                    If .InternoNumeroHijo > 0 Then
                        objEntColFamilia = ListarFamilia_tmp(.InternoID, DateAdd(DateInterval.Year, -3, Legolas.Configuration.Aplication.FechayHora.FechaDate).ToFileTime)

                        For Each obj As Entity.Registro.Familiar In objEntColFamilia
                            objEntPadinDetalleFam = New Entity.Estadistica.PadinDetalleFamilia
                            With objEntPadinDetalleFam
                                .Codigo = -1
                                .PadinID = PadinID
                                .RegionID = RegionID
                                .PenalID = PenalID
                                .InternoID = objEntInterno.InternoID
                                .PrimerApellido = obj.ApellidoPaterno
                                .SegundoApellido = obj.ApellidoMaterno
                                .PreNombres = obj.Nombres
                                .FechaNacimiento = obj.FechaNacimiento
                                .SexoID = obj.Sexo
                                .SexoNombre = obj.SexoNombre
                                .Vive = obj.Vive
                                .Recluido = obj.HijoReclucido
                            End With
                            objEntPadinDetalleColFam.Add(objEntPadinDetalleFam)
                        Next

                    End If
                End With

            Next

            For Each obj As Entity.Estadistica.PadinDetalle In objEntColInterno
                obj.PadinDetalleVisible = PadinVisible
                obj.PadinTipoMovimiento = PadinTipoMov
                obj.Codigo = Grabar_v1_2(obj)
            Next

            'grabar padin detalle familia
            objBssPadinDetalleFam = New Bussines.Estadistica.PadinDetalleFamilia

            For Each obj As Entity.Estadistica.PadinDetalleFamilia In objEntPadinDetalleColFam
                objBssPadinDetalleFam.Grabar(obj)
            Next
            'xxxxxxxxxxxxxx
        End Sub

        Public Sub DatosComplementarios_v5(PadinID As Integer, RegionID As Integer, PenalID As Integer, FechaIni As Long, FechaFin As Long,
                                           PadinVisible As Integer, PadinTipoMov As Integer, intVersionReporte As Short,
                                           ByRef objEntColInterno As Entity.Estadistica.PadinDetalleCol)
            Dim idsInterno As String = ""
            Dim idsIngreso As String = ""
            Dim idsMovimientos As String = ""

            Dim idsMovimientosEgreso As String = ""
            Dim idsDocumentoIngreso As String = ""
            Dim idsDocumentoEgreso As String = ""

            Dim objBssPadinDetalle As Bussines.Estadistica.PadinDetalle = Nothing
            Dim objEntPadinDetalleTemp As Entity.Estadistica.PadinDetalle = Nothing

            '/*interno familia*/
            Dim objBssFamilia As New Bussines.Registro.Familiar
            Dim objEntColFamilia As New Entity.Registro.FamiliarCol

            '/*padin detalle familia*/
            Dim objBssPadinDetalleFam As Bussines.Estadistica.PadinDetalleFamilia = Nothing
            Dim objEntPadinDetalleFam As Entity.Estadistica.PadinDetalleFamilia = Nothing
            Dim objEntPadinDetalleColFam As Entity.Estadistica.PadinDetalleFamiliaCol = Nothing
            Dim intIDInterno As Integer = -1
            Try

                objEntPadinDetalleColFam = New Entity.Estadistica.PadinDetalleFamiliaCol

                idsInterno = ConcatenarIdsInterno(objEntColInterno)


                idsIngreso = ConcatenarIdsIngreso((objEntColInterno))

                idsMovimientos = ConcatenarIdsMovimientos((objEntColInterno))
                idsMovimientosEgreso = ConcatenarIdsEgresoMovimientos((objEntColInterno))

                idsDocumentoIngreso = ConcatenarIdsDocumentosIngresos((objEntColInterno))
                idsDocumentoEgreso = ConcatenarIdsDocumentosEgresos((objEntColInterno))


                tblDatos = Data.Estadistica.PadinDetalle.ListarDatosComplementarios_v5("lst", "datos_complementarios_v5", idsInterno, idsIngreso, idsMovimientos,
                                                                                       idsMovimientosEgreso, idsDocumentoIngreso, idsDocumentoEgreso, FechaFin)


                '/*reprocesar los documentos de libertad, pasaran a sentencia */
                Dim t As DataTable
                t = tblDatos("tblSentencia")
                If t.Rows.Count > 0 Then
                    tblDatos("tblSentencia") = ReprocesarSentencia(t)
                End If
                '**/

                For Each objEntInterno As Entity.Estadistica.PadinDetalle In objEntColInterno

                    intIDInterno = objEntInterno.InternoID

                    With objEntInterno
                        .Codigo = -1
                        If .InternoSexo.ToUpper = "" Then
                        ElseIf .InternoSexo.ToUpper = "MASCULINO" Then
                            .InternoSexo = "M"
                        Else
                            .InternoSexo = "F"
                        End If
                        .PadinID = PadinID
                        .RegionID = RegionID
                        .PenalID = PenalID
                        .FechaCorte = FechaFin

                        If objEntInterno.InternoTipoDocumentoID <= 0 Then .InternoTipoDocumento = "INDOCUMENTADO"
                        .InternoNumeroHijo = NumeroHijo(.InternoID)

                        '/*Concatenar nombres asociados*/
                        .InternoNombresAsociados = ListarNombresAsociados_tmp(objEntInterno.InternoID)

                        '/*Concatenar alias*/
                        .InternoAlias = ListarAlias_tmp(objEntInterno.InternoID)

                        '/*Siscrico*/

                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarSiscrico_tmp_v5(.InternoID)

                        .OrgCriminalNombre = objEntPadinDetalleTemp.OrgCriminalNombre
                        .OrgCriminalCondicion = objEntPadinDetalleTemp.OrgCriminalCondicion
                        .OrgCriminalFormaParte = objEntPadinDetalleTemp.OrgCriminalFormaParte

                        '/*Situacion juridica*/                  
                        .IngresoSituacionJuridicaID = ListarIngresoSituacionJuridicaID_tmp_v5(.InternoID, .IngresoID, FechaFin, PadinTipoMov)

                        If intVersionReporte = 3 Then 'version del reporte padin
                            If .IngresoSituacionJuridicaID = 3 Then 'sentenciado/procesado
                                .IngresoSituacionJuridicaID = 2 'sentenciado
                            End If
                        End If
                        .IngresoSituacionJuridica = ListarIngresoSituacionJuridica(.IngresoSituacionJuridicaID)

                        '/*Datos del ingreso*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle

                        objEntPadinDetalleTemp = ListarIngreso_tmp_v5(.IDMovimiento, FechaFin)

                        .IngresoID = objEntPadinDetalleTemp.IngresoID
                        .FechaISP = objEntPadinDetalleTemp.FechaISP
                        .IngresoNumero = objEntPadinDetalleTemp.IngresoNumero
                        .IngresoMotivo = objEntPadinDetalleTemp.IngresoMotivo
                        .IngresoOrigen = objEntPadinDetalleTemp.IngresoOrigen
                        .IngresoDocumento = objEntPadinDetalleTemp.IngresoDocumento
                        .IngresoMotivoTraslado = objEntPadinDetalleTemp.IngresoMotivoTraslado
                        .FechaIngresoPenal = objEntPadinDetalleTemp.FechaIngresoPenal
                        .IngresoTipoMovimientoID = objEntPadinDetalleTemp.IngresoTipoMovimientoID
                        '/**/

                        If objEntPadinDetalleTemp.IngresoTipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                            If objEntPadinDetalleTemp.ExpedienteTipoAutoridadID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                                .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                                .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                                .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                            Else
                                .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSecretario & "/" & objEntPadinDetalleTemp.ExpedienteJuez
                            End If
                        Else
                            .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                            .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                            .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                            .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                        End If
                        .IDDocumentoIngreso = objEntPadinDetalleTemp.IDDocumentoIngreso
                        '/*Expediente del internamiento*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarExpedienteIngreso_tmp_v5(.InternoID, .IngresoID, .IDDocumentoIngreso, FechaFin)
                        '.ExpedienteID = objEntPadinDetalleTemp.ExpedienteID
                        .ExpedienteNumero = objEntPadinDetalleTemp.ExpedienteNumero
                        .DelitoFlagrante = objEntPadinDetalleTemp.ExpedienteFlagrancia

                        '/*Otros expedientes con checked=0*/
                        .ExpedienteNumeroOtros = ListarExpedientesOtros_tmp_v5(.InternoID, .IngresoID, .ExpedienteID, FechaFin)

                        ''/*Delitos*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarDelitoMayorPena_tmp_v5(.InternoID, .IngresoID, FechaFin)

                        .DelitoID = objEntPadinDetalleTemp.DelitoID
                        .DelitoGenericoID = objEntPadinDetalleTemp.DelitoGenericoID
                        .DelitoGenerico = objEntPadinDetalleTemp.DelitoGenerico
                        .DelitoEspecificoID = objEntPadinDetalleTemp.DelitoEspecificoID
                        .DelitoEspecifico = objEntPadinDetalleTemp.DelitoEspecifico

                        '/*Otros Delitos*/   Esta opcion ha sido ocultada 04/05/2021
                        .DelitoOtros = ListarOtrosDelitosExpediente_tmp_v5(.InternoID, .IngresoID, .ExpedienteID)

                        '/*Agraviados*/
                        .DelitoAgraviados = ListarDelitoAgraviados_tmp_v5(.DelitoID)

                        ''/*Datos de sentencia*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarSentencia_tmp_v5(.InternoID, .IngresoID, FechaFin)

                        .SentenciaID = objEntPadinDetalleTemp.SentenciaID
                        .SentenciaExpedienteID = objEntPadinDetalleTemp.SentenciaExpedienteID
                        .SentenciaDocumento = objEntPadinDetalleTemp.SentenciaDocumento
                        .SentenciaFecha = objEntPadinDetalleTemp.SentenciaFecha
                        .SentenciaDistritoJudicial = objEntPadinDetalleTemp.SentenciaDistritoJudicial
                        .SentenciaSalaJuzgado = objEntPadinDetalleTemp.SentenciaSalaJuzgado
                        '.SentenciaDocumento  = objEntPadinDetalleTemp.SentenciaDocumento
                        .SentenciaCadenaPerpetua = objEntPadinDetalleTemp.SentenciaCadenaPerpetua

                        If .SentenciaCadenaPerpetua = True Then
                            .SentenciaPenaImpuestaAnio = 500 'cadena perpetua
                        Else
                            .SentenciaPenaImpuestaAnio = objEntPadinDetalleTemp.SentenciaPenaImpuestaAnio
                        End If

                        .SentenciaPenaImpuestaMes = objEntPadinDetalleTemp.SentenciaPenaImpuestaMes
                        .SentenciaPenaImpuestaDia = objEntPadinDetalleTemp.SentenciaPenaImpuestaDia

                        .SentenciaFechaIni = objEntPadinDetalleTemp.SentenciaFechaIni
                        .SentenciaFechaFin = objEntPadinDetalleTemp.SentenciaFechaFin
                        .SentenciaObs = objEntPadinDetalleTemp.SentenciaObs
                        .SentenciaDelitoID = objEntPadinDetalleTemp.SentenciaDelitoID
                        .SentenciaDelitoGenerico = objEntPadinDetalleTemp.SentenciaDelitoGenerico
                        .SentenciaDelitoEspecificoID = objEntPadinDetalleTemp.SentenciaDelitoEspecificoID
                        .SentenciaDelitoEspecifico = objEntPadinDetalleTemp.SentenciaDelitoEspecifico

                        ''/*Datos de sentencia otra instancia*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarSentencia_tmp_v6(.InternoID, .IngresoID, FechaFin)

                        .SentenciaPIFecha = objEntPadinDetalleTemp.SentenciaPIFecha
                        .SentenciaPIDistritoJudicial = objEntPadinDetalleTemp.SentenciaPIDistritoJudicial
                        .SentenciaPISalaJuzgado = objEntPadinDetalleTemp.SentenciaPISalaJuzgado
                        .SentenciaPIExpedienteNumero = objEntPadinDetalleTemp.SentenciaPIExpedienteNumero
                        .SentenciaSIDistritoJudicial = objEntPadinDetalleTemp.SentenciaSIDistritoJudicial
                        .SentenciaSISalaJuzgado = objEntPadinDetalleTemp.SentenciaSISalaJuzgado
                        .SentenciaSIExpedienteNumero = objEntPadinDetalleTemp.SentenciaSIExpedienteNumero

                        '/*Datos del movimiento egreso*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        If .PadinTipoMovimiento = Type.Enumeracion.Padin.EnumTipoMovimiento.Egresos Then
                            objEntPadinDetalleTemp = ListarEgreso_tmp_v5(.IDMovimientoEgreso, .ExpedienteLibertarID, .TipoDetalleMovimientoSal)

                            .EgresoDestino = objEntPadinDetalleTemp.EgresoDestino
                            .EgresoDistritoJudicial = objEntPadinDetalleTemp.EgresoDistritoJudicial
                            .EgresoSalaJuzgado = objEntPadinDetalleTemp.EgresoSalaJuzgado
                            If objEntPadinDetalleTemp.EgresoTipoAutoridadID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                .EgresoJuez = objEntPadinDetalleTemp.EgresoJuez
                                .EgresoSecretario = objEntPadinDetalleTemp.EgresoSecretario
                            Else
                                .EgresoJuez = ""
                                .EgresoSecretario = ""
                                .EgresoOtroNombre = objEntPadinDetalleTemp.EgresoOtroNombre
                                .EgresoOtraAutoridad = objEntPadinDetalleTemp.EgresoOtraAutoridad
                            End If
                            .EgresoFecha = objEntPadinDetalleTemp.EgresoFecha
                            .EgresoObservacion = objEntPadinDetalleTemp.EgresoObservacion
                            .EgresoTipoID = objEntPadinDetalleTemp.EgresoTipoID
                            .EgresoTipo = objEntPadinDetalleTemp.EgresoTipo
                            .EgresoTipoMotivoID = objEntPadinDetalleTemp.EgresoTipoMotivoID
                            .EgresoTipoMotivo = objEntPadinDetalleTemp.EgresoTipoMotivo
                            .EgresoDocumento = objEntPadinDetalleTemp.EgresoDocumento
                            .TipoMovimientoID = objEntPadinDetalleTemp.TipoMovimientoID
                            '/*Datos del expediente de libertad egreso*/
                            If .TipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then
                                objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                                objEntPadinDetalleTemp = ListarExpedientesEgreso_tmp_v5(.IDDocumentoEgreso)
                                .EgresoDocumentoLibertad = objEntPadinDetalleTemp.EgresoDocumentoLibertad
                            Else
                                .EgresoDocumentoLibertad = .ExpedienteNumero
                            End If
                        End If

                        '/*detalle familia*/
                        If .InternoNumeroHijo > 0 Then
                            objEntColFamilia = ListarFamilia_tmp(.InternoID, DateAdd(DateInterval.Year, -3, Legolas.Configuration.Aplication.FechayHora.FechaDate).ToFileTime)

                            For Each obj As Entity.Registro.Familiar In objEntColFamilia
                                objEntPadinDetalleFam = New Entity.Estadistica.PadinDetalleFamilia
                                With objEntPadinDetalleFam
                                    .Codigo = -1
                                    .PadinID = PadinID
                                    .RegionID = RegionID
                                    .PenalID = PenalID
                                    .InternoID = objEntInterno.InternoID
                                    .PrimerApellido = obj.ApellidoPaterno
                                    .SegundoApellido = obj.ApellidoMaterno
                                    .PreNombres = obj.Nombres
                                    .FechaNacimiento = obj.FechaNacimiento
                                    .SexoID = obj.Sexo
                                    .SexoNombre = obj.SexoNombre
                                    .Vive = obj.Vive
                                    .Recluido = obj.HijoReclucido
                                End With
                                objEntPadinDetalleColFam.Add(objEntPadinDetalleFam)
                            Next

                        End If
                    End With

                Next

                For Each obj As Entity.Estadistica.PadinDetalle In objEntColInterno
                    obj.PadinDetalleVisible = PadinVisible
                    obj.PadinTipoMovimiento = PadinTipoMov
                    obj.Codigo = Grabar_v2(obj)
                Next

                'grabar padin detalle familia
                objBssPadinDetalleFam = New Bussines.Estadistica.PadinDetalleFamilia

                For Each obj As Entity.Estadistica.PadinDetalleFamilia In objEntPadinDetalleColFam
                    objBssPadinDetalleFam.Grabar(obj)
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message & " --- " & intIDInterno)
            End Try
        End Sub

        Public Sub DatosComplementarios_v6(PadinID As Integer, RegionID As Integer, PenalID As Integer, FechaIni As Long, FechaFin As Long,
                                           PadinVisible As Integer, PadinTipoMov As Integer, intVersionReporte As Short,
                                           ByRef objEntColInterno As Entity.Estadistica.PadinDetalleCol)
            Dim idsInterno As String = ""
            Dim idsIngreso As String = ""
            Dim idsMovimientos As String = ""

            Dim idsMovimientosEgreso As String = ""
            Dim idsDocumentoIngreso As String = ""
            Dim idsDocumentoEgreso As String = ""

            Dim objBssPadinDetalle As Bussines.Estadistica.PadinDetalle = Nothing
            Dim objEntPadinDetalleTemp As Entity.Estadistica.PadinDetalle = Nothing

            '/*interno familia*/
            Dim objBssFamilia As New Bussines.Registro.Familiar
            Dim objEntColFamilia As New Entity.Registro.FamiliarCol

            '/*padin detalle familia*/
            Dim objBssPadinDetalleFam As Bussines.Estadistica.PadinDetalleFamilia = Nothing
            Dim objEntPadinDetalleFam As Entity.Estadistica.PadinDetalleFamilia = Nothing
            Dim objEntPadinDetalleColFam As Entity.Estadistica.PadinDetalleFamiliaCol = Nothing
            Dim intIDInterno As Integer = -1
            Try

                objEntPadinDetalleColFam = New Entity.Estadistica.PadinDetalleFamiliaCol

                idsInterno = ConcatenarIdsInterno(objEntColInterno)


                idsIngreso = ConcatenarIdsIngreso((objEntColInterno))

                idsMovimientos = ConcatenarIdsMovimientos((objEntColInterno))
                idsMovimientosEgreso = ConcatenarIdsEgresoMovimientos((objEntColInterno))

                idsDocumentoIngreso = "" ' ConcatenarIdsDocumentosIngresos((objEntColInterno))
                idsDocumentoEgreso = ConcatenarIdsDocumentosEgresos((objEntColInterno))


                tblDatos = Data.Estadistica.PadinDetalle.ListarDatosComplementarios_v6("lst", "datos_complementarios_v6", idsInterno, idsIngreso, idsMovimientos,
                                                                                       idsMovimientosEgreso, idsDocumentoIngreso, idsDocumentoEgreso, FechaFin)

                For Each objEntInterno As Entity.Estadistica.PadinDetalle In objEntColInterno

                    intIDInterno = objEntInterno.InternoID

                    If intIDInterno = 146554 Then
                        Dim h As Integer = 100 * 100
                        'MsgBox(intIDInterno)
                    End If

                    With objEntInterno
                        .Codigo = -1
                        If .InternoSexo.ToUpper = "MASCULINO" Then
                            .InternoSexo = "M"
                        Else
                            .InternoSexo = "F"
                        End If
                        .PadinID = PadinID
                        .RegionID = RegionID
                        .PenalID = PenalID
                        .FechaCorte = FechaFin

                        If objEntInterno.InternoTipoDocumentoID <= 0 Then .InternoTipoDocumento = "INDOCUMENTADO"
                        .InternoNumeroHijo = NumeroHijo(.InternoID)

                        '/*Concatenar nombres asociados*/
                        .InternoNombresAsociados = ListarNombresAsociados_tmp(objEntInterno.InternoID)

                        '/*Concatenar alias*/
                        .InternoAlias = ListarAlias_tmp(objEntInterno.InternoID)

                        '/*Siscrico*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarSiscrico_tmp_v5(.InternoID)

                        .OrgCriminalNombre = objEntPadinDetalleTemp.OrgCriminalNombre
                        .OrgCriminalCondicion = objEntPadinDetalleTemp.OrgCriminalCondicion
                        .OrgCriminalFormaParte = objEntPadinDetalleTemp.OrgCriminalFormaParte

                        '/*Datos del ingreso*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarIngreso_tmp_v6(.IDMovimiento, FechaFin)

                        .IngresoID = objEntPadinDetalleTemp.IngresoID
                        .FechaISP = objEntPadinDetalleTemp.FechaISP
                        .IngresoNumero = objEntPadinDetalleTemp.IngresoNumero
                        .IngresoMotivo = objEntPadinDetalleTemp.IngresoMotivo
                        .IngresoOrigen = objEntPadinDetalleTemp.IngresoOrigen
                        .IngresoMotivoTraslado = objEntPadinDetalleTemp.IngresoMotivoTraslado
                        .FechaIngresoPenal = objEntPadinDetalleTemp.FechaIngresoPenal
                        .IngresoDocumento = objEntPadinDetalleTemp.IngresoDocumento
                        .IngresoTipoMovimientoID = objEntPadinDetalleTemp.IngresoTipoMovimientoID
                        '.IDDocumentoIngreso = objEntPadinDetalleTemp.IDDocumentoIngreso
                        If PadinTipoMov = 1 Then
                            .ExpedienteID = objEntPadinDetalleTemp.ExpedienteID
                            .ExpedienteNumero = objEntPadinDetalleTemp.ExpedienteNumero
                            .IngresoSituacionJuridicaID = objEntPadinDetalleTemp.ExpedienteSituacionJuridicaID
                            .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                            .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                            .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                            .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                            .FechaRecepcion = objEntPadinDetalleTemp.FechaRecepcion
                        End If
                        If objEntPadinDetalleTemp.IngresoTipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                            If objEntPadinDetalleTemp.ExpedienteTipoAutoridadID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                                .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                                .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                                .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                            Else
                                .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSecretario & IIf(objEntPadinDetalleTemp.ExpedienteSecretario.Length = 0, "", IIf(objEntPadinDetalleTemp.ExpedienteJuez.Length = 0, "", "/" & objEntPadinDetalleTemp.ExpedienteJuez))
                            End If
                        Else
                            .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                            .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                            .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                            .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                        End If
                        'If .InternoID = 106030 Then MsgBox(.InternoID)
                        '/*-----Expediente del internamiento---------*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarExpedienteIngreso_tmp_v6(.InternoID, .IngresoID, FechaFin, PadinTipoMov)
                        .DelitoFlagrante = objEntPadinDetalleTemp.ExpedienteFlagrancia
                        'datos de la autoridad judicial
                        If PadinTipoMov = 1 Then
                            If .IngresoSituacionJuridicaID = 3 Then
                                .ExpedienteSituacionJuridicaID = ListarIngresoSituacionJuridicaID_tmp_v6(.InternoID, .IngresoID, .ExpedienteID, .ExpedienteNumero, .FechaRecepcion, FechaFin, PadinTipoMov)
                            Else
                                .ExpedienteSituacionJuridicaID = .IngresoSituacionJuridicaID
                            End If
                            If .ExpedienteID < 1 Then
                                .ExpedienteID = objEntPadinDetalleTemp.ExpedienteID
                                .ExpedienteNumero = objEntPadinDetalleTemp.ExpedienteNumero
                                .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                                .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                                .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                                .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                                .ExpedienteSituacionJuridicaID = objEntPadinDetalleTemp.ExpedienteSituacionJuridicaID
                                .ExpedienteSituacionJuridica = objEntPadinDetalleTemp.ExpedienteSituacionJuridica
                                .FechaRecepcion = objEntPadinDetalleTemp.FechaRecepcion
                            End If
                        Else
                            .ExpedienteID = objEntPadinDetalleTemp.ExpedienteID
                            .ExpedienteNumero = objEntPadinDetalleTemp.ExpedienteNumero
                            .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                            .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                            .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                            .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                            .ExpedienteSituacionJuridicaID = objEntPadinDetalleTemp.ExpedienteSituacionJuridicaID
                            .ExpedienteSituacionJuridica = objEntPadinDetalleTemp.ExpedienteSituacionJuridica
                            .FechaRecepcion = objEntPadinDetalleTemp.FechaRecepcion
                        End If
                        '/*Situacion juridica*/  
                        If PadinTipoMov <> 2 Then
                            .IngresoSituacionJuridicaID = ListarIngresoSituacionJuridicaID_tmp_v6(.InternoID, .IngresoID, .ExpedienteID, "", .FechaRecepcion, FechaFin, PadinTipoMov)
                            If intVersionReporte = 3 Then 'version del reporte padin, proceso de la unidad de estadistica.
                                If .IngresoSituacionJuridicaID = 3 Then 'sentenciado/procesado
                                    .IngresoSituacionJuridicaID = 2 'sentenciado
                                End If
                            End If
                            .IngresoSituacionJuridica = ListarIngresoSituacionJuridica(.IngresoSituacionJuridicaID)
                        End If
                        ''/*Delitos*/
                        If .ExpedienteID > 0 Then
                            objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                            objEntPadinDetalleTemp = ListarDelitoMayorPena_tmp_v6(.InternoID, .IngresoID, FechaFin, .ExpedienteID, PadinTipoMov)
                            .DelitoID = objEntPadinDetalleTemp.DelitoID
                            .DelitoGenericoID = objEntPadinDetalleTemp.DelitoGenericoID
                            .DelitoGenerico = objEntPadinDetalleTemp.DelitoGenerico
                            .DelitoEspecificoID = objEntPadinDetalleTemp.DelitoEspecificoID
                            .DelitoEspecifico = objEntPadinDetalleTemp.DelitoEspecifico
                        End If
                        '/*Otros Delitos*/   actualizada 04/05/2021
                        .DelitoOtros = ListarOtrosDelitosExpediente_tmp_v6(.InternoID, .IngresoID, .ExpedienteID, PadinTipoMov)
                        '/*Agraviados*/
                        .DelitoAgraviados = ListarDelitoAgraviados_tmp_v5(.DelitoID)
                        '/*Otros expedientes con checked=0*/
                        .ExpedienteNumeroOtros = ListarExpedientesOtros_tmp_v6(.InternoID, .IngresoID, .ExpedienteID, FechaFin, .ExpedienteNumero, .FechaRecepcion, PadinTipoMov)

                        ''/*Datos de sentencia*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        If .IngresoSituacionJuridicaID = -1 And PadinTipoMov = 3 Then
                        Else
                            objEntPadinDetalleTemp = ListarSentencias_tmp_v6(.InternoID, .IngresoID, FechaFin, .IngresoSituacionJuridicaID, .FechaRecepcion, PadinTipoMov)
                            .SentenciaID = objEntPadinDetalleTemp.SentenciaID
                            .SentenciaExpedienteID = objEntPadinDetalleTemp.SentenciaExpedienteID
                            .SentenciaDocumento = objEntPadinDetalleTemp.SentenciaDocumento
                            .SentenciaDistritoJudicial = objEntPadinDetalleTemp.SentenciaDistritoJudicial
                            .SentenciaSalaJuzgado = objEntPadinDetalleTemp.SentenciaSalaJuzgado

                            .SentenciaPIFecha = objEntPadinDetalleTemp.SentenciaPIFecha
                            .SentenciaPIDistritoJudicial = objEntPadinDetalleTemp.SentenciaPIDistritoJudicial
                            .SentenciaPISalaJuzgado = objEntPadinDetalleTemp.SentenciaPISalaJuzgado
                            .SentenciaPIExpedienteNumero = objEntPadinDetalleTemp.SentenciaPIExpedienteNumero
                            .SentenciaSIDistritoJudicial = objEntPadinDetalleTemp.SentenciaSIDistritoJudicial
                            .SentenciaSISalaJuzgado = objEntPadinDetalleTemp.SentenciaSISalaJuzgado
                            .SentenciaSIExpedienteNumero = objEntPadinDetalleTemp.SentenciaSIExpedienteNumero
                            'periodos de condena
                            .SentenciaCadenaPerpetua = objEntPadinDetalleTemp.SentenciaCadenaPerpetua
                            If .SentenciaCadenaPerpetua = True Then
                                .SentenciaPenaImpuestaAnio = 500 'cadena perpetua
                                .SentenciaFechaIni = 0
                                .SentenciaFechaFin = 0
                            Else
                                .SentenciaPenaImpuestaAnio = objEntPadinDetalleTemp.SentenciaPenaImpuestaAnio
                                .SentenciaFechaIni = objEntPadinDetalleTemp.SentenciaFechaIni
                                .SentenciaFechaFin = objEntPadinDetalleTemp.SentenciaFechaFin
                            End If
                            .SentenciaPenaImpuestaMes = objEntPadinDetalleTemp.SentenciaPenaImpuestaMes
                            .SentenciaPenaImpuestaDia = objEntPadinDetalleTemp.SentenciaPenaImpuestaDia
                            .SentenciaObs = objEntPadinDetalleTemp.SentenciaObs

                            .SentenciaDelitoID = objEntPadinDetalleTemp.SentenciaDelitoID
                            .SentenciaDelitoGenerico = objEntPadinDetalleTemp.SentenciaDelitoGenerico
                            .SentenciaDelitoEspecificoID = objEntPadinDetalleTemp.SentenciaDelitoEspecificoID
                            .SentenciaDelitoEspecifico = objEntPadinDetalleTemp.SentenciaDelitoEspecifico
                            '.SentenciaDocumento  = objEntPadinDetalleTemp.SentenciaDocumento
                        End If
                        '/*Interno Inimputables*/
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarIninputables_tmp_v6(.InternoID, .IngresoID, .ExpedienteID, FechaFin, 0, PadinTipoMov)
                        .Inimputable = objEntPadinDetalleTemp.Inimputable
                        .EstablecimientoMental = objEntPadinDetalleTemp.EstablecimientoMental
                        '/*Datos del movimiento egreso*/
                        If .PadinTipoMovimiento = Type.Enumeracion.Padin.EnumTipoMovimiento.Egresos Then
                            objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                            objEntPadinDetalleTemp = ListarEgreso_tmp_v6(.IDMovimientoEgreso, .ExpedienteLibertarID, .TipoDetalleMovimientoSal)

                            .EgresoDestino = objEntPadinDetalleTemp.EgresoDestino
                            .EgresoDistritoJudicial = objEntPadinDetalleTemp.EgresoDistritoJudicial
                            .EgresoSalaJuzgado = objEntPadinDetalleTemp.EgresoSalaJuzgado
                            If objEntPadinDetalleTemp.EgresoTipoAutoridadID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                .EgresoJuez = objEntPadinDetalleTemp.EgresoJuez
                                .EgresoSecretario = objEntPadinDetalleTemp.EgresoSecretario
                            Else
                                .EgresoJuez = ""
                                .EgresoSecretario = ""
                                .EgresoOtroNombre = objEntPadinDetalleTemp.EgresoOtroNombre
                                .EgresoOtraAutoridad = objEntPadinDetalleTemp.EgresoOtraAutoridad
                            End If
                            .EgresoFecha = objEntPadinDetalleTemp.EgresoFecha
                            .EgresoObservacion = objEntPadinDetalleTemp.EgresoObservacion
                            .EgresoTipoID = objEntPadinDetalleTemp.EgresoTipoID
                            .EgresoTipo = objEntPadinDetalleTemp.EgresoTipo
                            .EgresoTipoMotivoID = objEntPadinDetalleTemp.EgresoTipoMotivoID
                            .EgresoTipoMotivo = objEntPadinDetalleTemp.EgresoTipoMotivo
                            .TipoMovimientoID = objEntPadinDetalleTemp.TipoMovimientoID
                            '/*Datos del expediente de libertad egreso*/
                            If .TipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then
                                objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                                objEntPadinDetalleTemp = ListarExpedientesEgreso_tmp_v6(.IDDocumentoEgreso)
                                .EgresoDocumentoLibertad = objEntPadinDetalleTemp.EgresoDocumentoLibertad
                                .EgresoDocumento = objEntPadinDetalleTemp.EgresoDocumento
                                .IDExpedienteEgreso = objEntPadinDetalleTemp.IDExpedienteEgreso
                            Else
                                .EgresoDocumentoLibertad = objEntPadinDetalleTemp.EgresoDocumentoRD
                                If (.EgresoDocumentoLibertad.Length = 0) Then
                                    .EgresoDocumentoLibertad = objEntPadinDetalleTemp.EgresoDocumento
                                End If
                            End If
                            Dim abc As String = .IDExpedienteEgreso
                            .IngresoSituacionJuridicaID = ListarIngresoSituacionJuridicaID_tmp_v6(.InternoID, .IngresoID, .IDExpedienteEgreso, "", .FechaRecepcion, FechaFin, PadinTipoMov)
                            .IngresoSituacionJuridica = ListarIngresoSituacionJuridica(.IngresoSituacionJuridicaID)
                        End If

                        '/*detalle familia*/
                        If .InternoNumeroHijo > 0 Then
                            objEntColFamilia = ListarFamilia_tmp(.InternoID, DateAdd(DateInterval.Year, -3, Legolas.Configuration.Aplication.FechayHora.FechaDate).ToFileTime)

                            For Each obj As Entity.Registro.Familiar In objEntColFamilia
                                objEntPadinDetalleFam = New Entity.Estadistica.PadinDetalleFamilia
                                With objEntPadinDetalleFam
                                    .Codigo = -1
                                    .PadinID = PadinID
                                    .RegionID = RegionID
                                    .PenalID = PenalID
                                    .InternoID = objEntInterno.InternoID
                                    .PrimerApellido = obj.ApellidoPaterno
                                    .SegundoApellido = obj.ApellidoMaterno
                                    .PreNombres = obj.Nombres
                                    .FechaNacimiento = obj.FechaNacimiento
                                    .SexoID = obj.Sexo
                                    .SexoNombre = obj.SexoNombre
                                    .Vive = obj.Vive
                                    .Recluido = obj.HijoReclucido
                                End With
                                objEntPadinDetalleColFam.Add(objEntPadinDetalleFam)
                            Next

                        End If
                    End With

                Next

                For Each obj As Entity.Estadistica.PadinDetalle In objEntColInterno
                    If obj.InternoID = 103839 Then
                        ' MsgBox(obj.InternoID)
                    End If
                    obj.PadinDetalleVisible = PadinVisible
                    obj.PadinTipoMovimiento = PadinTipoMov
                    obj.Codigo = Grabar_v2(obj)
                Next

                'grabar padin detalle familia
                objBssPadinDetalleFam = New Bussines.Estadistica.PadinDetalleFamilia

                For Each obj As Entity.Estadistica.PadinDetalleFamilia In objEntPadinDetalleColFam
                    objBssPadinDetalleFam.Grabar(obj)
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message & " --- " & "TipoMov: " & PadinTipoMov & " --- InternoId: " & intIDInterno)
            End Try
        End Sub

        Public Function DatosComplementarios_Siscrico(InterId As Integer, FechaFin As Long) As Entity.Estadistica.PadinDetalle
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalle.Listar_v2(sqlCon, "lst", "lst_datos_organizacion_criminal_v1", -1, -1, -1, -1, InterId, -1, -1, -1, "", "", 0, FechaFin, -1)
            objEnt = New Entity.Estadistica.PadinDetalle
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .OrgCriminalFormaParte = sqlDr("pert_org_crim").ToString
                            .OrgCriminalCondicion = sqlDr("cond_en_org_crim").ToString
                            .OrgCriminalNombre = sqlDr("org_crim_nom").ToString
                            .GruposDelictivosOtros = sqlDr("grup_delictivos").ToString
                            .DelitoFlagrante = sqlDr("int_del_flag").ToString
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

        Public Sub DatosComplementarios_plm(PadinID As Integer, RegionID As Integer, PenalID As Integer, FechaIni As Long, FechaFin As Long,
                                            PadinVisible As Integer, PadinTipoMov As Integer, intVersionReporte As Short,
                                            ByRef objEntColInterno As Entity.Estadistica.PadinDetalleCol, ByRef strMensajeOut As String)

            Dim idsInterno As String = ""
            Dim idsIngreso As String = ""
            Dim idsMovimientos As String = ""

            Dim idsMovimientosEgreso As String = ""
            Dim idsDocumentoIngreso As String = ""
            Dim idsDocumentoEgreso As String = ""

            Dim objBssPadinDetalle As Bussines.Estadistica.PadinDetalle = Nothing
            Dim objEntPadinDetalleTemp As Entity.Estadistica.PadinDetalle = Nothing

            '/*interno familia*/
            Dim objBssFamilia As New Bussines.Registro.Familiar
            Dim objEntColFamilia As New Entity.Registro.FamiliarCol

            '/*padin detalle familia*/
            Dim objBssPadinDetalleFam As Bussines.Estadistica.PadinDetalleFamilia = Nothing
            Dim objEntPadinDetalleFam As Entity.Estadistica.PadinDetalleFamilia = Nothing
            Dim objEntPadinDetalleColFam As Entity.Estadistica.PadinDetalleFamiliaCol = Nothing

            objEntPadinDetalleColFam = New Entity.Estadistica.PadinDetalleFamiliaCol

            idsInterno = ConcatenarIdsInterno(objEntColInterno)
            idsIngreso = ConcatenarIdsIngreso((objEntColInterno))

            idsMovimientos = ConcatenarIdsMovimientos((objEntColInterno))
            idsMovimientosEgreso = ConcatenarIdsEgresoMovimientos((objEntColInterno))

            idsDocumentoIngreso = ConcatenarIdsDocumentosIngresos((objEntColInterno))
            idsDocumentoEgreso = ConcatenarIdsDocumentosEgresos((objEntColInterno))

            Try
                tblDatos = Data.Estadistica.PadinDetalle.ListarDatosComplementarios_plm("lst", "datos_complementarios_plm", idsInterno, idsIngreso, idsMovimientos,
                                                                                   idsMovimientosEgreso, idsDocumentoIngreso, idsDocumentoEgreso, FechaFin)
            Catch ex As Exception
                strMensajeOut = ex.Message
                Exit Sub
            End Try

            '/*reprocesar los documentos de libertad, pasaran a sentencia */
            Dim t As DataTable
            t = tblDatos("tblSentencia")
            If t.Rows.Count > 0 Then
                tblDatos("tblSentencia") = ReprocesarSentencia(t)
            End If
            '**/

            For Each objEntInterno As Entity.Estadistica.PadinDetalle In objEntColInterno

                If objEntInterno.InternoID = 35953 Then
                    objEntInterno.InternoSexo = "M"
                End If

                With objEntInterno
                    .Codigo = -1

                    If .InternoSexo.ToUpper = "" Then
                    ElseIf .InternoSexo.ToUpper = "MASCULINO" Then
                        .InternoSexo = "M"
                    Else
                        .InternoSexo = "F"
                    End If

                    .PadinID = PadinID
                    .RegionID = RegionID
                    .PenalID = PenalID
                    .FechaCorte = FechaFin

                    If objEntInterno.InternoTipoDocumentoID <= 0 Then
                        .InternoTipoDocumento = "INDOCUMENTADO"
                    End If

                    .InternoNumeroHijo = NumeroHijo(.InternoID)

                    '/*Concatenar nombres asociados*/
                    .InternoNombresAsociados = ListarNombresAsociados_tmp(objEntInterno.InternoID)

                    '/*Concatenar alias*/
                    .InternoAlias = ListarAlias_tmp(objEntInterno.InternoID)

                    '/*Siscrico*/

                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = ListarSiscrico_tmp_v5(.InternoID)

                    .OrgCriminalNombre = objEntPadinDetalleTemp.OrgCriminalNombre
                    .OrgCriminalCondicion = objEntPadinDetalleTemp.OrgCriminalCondicion
                    .OrgCriminalFormaParte = objEntPadinDetalleTemp.OrgCriminalFormaParte

                    '/*Situacion juridica*/                  
                    .IngresoSituacionJuridicaID = ListarIngresoSituacionJuridicaID_tmp_v5(.InternoID, .IngresoID, FechaFin, PadinTipoMov)

                    If intVersionReporte = 3 Then 'version del reporte padin
                        If .IngresoSituacionJuridicaID = 3 Then 'sentenciado/procesado
                            .IngresoSituacionJuridicaID = 2 'sentenciado
                        End If
                    End If
                    .IngresoSituacionJuridica = ListarIngresoSituacionJuridica(.IngresoSituacionJuridicaID)

                    '/*Datos del ingreso*/
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle

                    objEntPadinDetalleTemp = ListarIngreso_tmp_v5(.IDMovimiento, FechaFin)

                    .IngresoID = objEntPadinDetalleTemp.IngresoID
                    .FechaISP = objEntPadinDetalleTemp.FechaISP
                    .IngresoNumero = objEntPadinDetalleTemp.IngresoNumero
                    .IngresoMotivo = objEntPadinDetalleTemp.IngresoMotivo
                    .IngresoOrigen = objEntPadinDetalleTemp.IngresoOrigen
                    .IngresoDocumento = objEntPadinDetalleTemp.IngresoDocumento
                    .IngresoMotivoTraslado = objEntPadinDetalleTemp.IngresoMotivoTraslado
                    .FechaIngresoPenal = objEntPadinDetalleTemp.FechaIngresoPenal
                    .IngresoTipoMovimientoID = objEntPadinDetalleTemp.IngresoTipoMovimientoID
                    '/**/

                    If objEntPadinDetalleTemp.IngresoTipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                        If objEntPadinDetalleTemp.ExpedienteTipoAutoridadID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                            .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                            .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                            .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                            .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                        Else
                            .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSecretario & IIf(objEntPadinDetalleTemp.ExpedienteSecretario.Length = 0, "", IIf(objEntPadinDetalleTemp.ExpedienteJuez.Length = 0, "", "/" & objEntPadinDetalleTemp.ExpedienteJuez))
                        End If
                    Else
                        .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                        .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                        .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                        .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                    End If
                    .IDDocumentoIngreso = objEntPadinDetalleTemp.IDDocumentoIngreso
                    '/*Expediente del internamiento*/
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = ListarExpedienteIngreso_tmp_v5(.InternoID, .IngresoID, .IDDocumentoIngreso, FechaFin)
                    '.ExpedienteID = objEntPadinDetalleTemp.ExpedienteID
                    .ExpedienteNumero = objEntPadinDetalleTemp.ExpedienteNumero
                    .DelitoFlagrante = objEntPadinDetalleTemp.ExpedienteFlagrancia

                    '/*Otros expedientes con checked=0*/
                    .ExpedienteNumeroOtros = ListarExpedientesOtros_tmp_v5(.InternoID, .IngresoID, .ExpedienteID, FechaFin)

                    ''/*Delitos*/
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = ListarDelitoMayorPena_tmp_v5(.InternoID, .IngresoID, FechaFin)

                    .DelitoID = objEntPadinDetalleTemp.DelitoID
                    .DelitoGenericoID = objEntPadinDetalleTemp.DelitoGenericoID
                    .DelitoGenerico = objEntPadinDetalleTemp.DelitoGenerico
                    .DelitoEspecificoID = objEntPadinDetalleTemp.DelitoEspecificoID
                    .DelitoEspecifico = objEntPadinDetalleTemp.DelitoEspecifico

                    '/*Otros Delitos*/
                    .DelitoOtros = ListarOtrosDelitosExpediente_tmp_v5(.InternoID, .IngresoID, .ExpedienteID)

                    '/*Agraviados*/
                    .DelitoAgraviados = ListarDelitoAgraviados_tmp_v5(.DelitoID)

                    ''/*Datos de sentencia*/
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = ListarSentencia_tmp_v5(.InternoID, .IngresoID, FechaFin)

                    .SentenciaID = objEntPadinDetalleTemp.SentenciaID
                    .SentenciaExpedienteID = objEntPadinDetalleTemp.SentenciaExpedienteID
                    .SentenciaDocumento = objEntPadinDetalleTemp.SentenciaDocumento
                    .SentenciaFecha = objEntPadinDetalleTemp.SentenciaFecha
                    .SentenciaDistritoJudicial = objEntPadinDetalleTemp.SentenciaDistritoJudicial
                    .SentenciaSalaJuzgado = objEntPadinDetalleTemp.SentenciaSalaJuzgado
                    .SentenciaDocumento = objEntPadinDetalleTemp.SentenciaDocumento
                    .SentenciaCadenaPerpetua = objEntPadinDetalleTemp.SentenciaCadenaPerpetua

                    If .SentenciaCadenaPerpetua = True Then
                        .SentenciaPenaImpuestaAnio = 500 'cadena perpetua
                    Else
                        .SentenciaPenaImpuestaAnio = objEntPadinDetalleTemp.SentenciaPenaImpuestaAnio
                    End If

                    .SentenciaPenaImpuestaMes = objEntPadinDetalleTemp.SentenciaPenaImpuestaMes
                    .SentenciaPenaImpuestaDia = objEntPadinDetalleTemp.SentenciaPenaImpuestaDia

                    .SentenciaFechaIni = objEntPadinDetalleTemp.SentenciaFechaIni
                    .SentenciaFechaFin = objEntPadinDetalleTemp.SentenciaFechaFin
                    .SentenciaObs = objEntPadinDetalleTemp.SentenciaObs
                    .SentenciaDelitoID = objEntPadinDetalleTemp.SentenciaDelitoID
                    .SentenciaDelitoGenerico = objEntPadinDetalleTemp.SentenciaDelitoGenerico
                    .SentenciaDelitoEspecificoID = objEntPadinDetalleTemp.SentenciaDelitoEspecificoID
                    .SentenciaDelitoEspecifico = objEntPadinDetalleTemp.SentenciaDelitoEspecifico

                    ''/*Datos de sentencia otra instancia*/
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    ' objEntPadinDetalleTemp = ListarSentenciaOtros_tmp_v5(.InternoID, .IngresoID, FechaFin)

                    .SentenciaPIFecha = objEntPadinDetalleTemp.SentenciaPIFecha
                    .SentenciaPIDistritoJudicial = objEntPadinDetalleTemp.SentenciaPIDistritoJudicial
                    .SentenciaPISalaJuzgado = objEntPadinDetalleTemp.SentenciaPISalaJuzgado
                    .SentenciaPIExpedienteNumero = objEntPadinDetalleTemp.SentenciaPIExpedienteNumero
                    .SentenciaSIDistritoJudicial = objEntPadinDetalleTemp.SentenciaSIDistritoJudicial
                    .SentenciaSISalaJuzgado = objEntPadinDetalleTemp.SentenciaSISalaJuzgado
                    .SentenciaSIExpedienteNumero = objEntPadinDetalleTemp.SentenciaSIExpedienteNumero

                    '/*Datos del movimiento egreso*/
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    If .PadinTipoMovimiento = Type.Enumeracion.Padin.EnumTipoMovimiento.Egresos Then
                        objEntPadinDetalleTemp = ListarEgreso_tmp_v5(.IDMovimientoEgreso, .ExpedienteLibertarID, .TipoDetalleMovimientoSal)

                        .EgresoDestino = objEntPadinDetalleTemp.EgresoDestino
                        .EgresoDistritoJudicial = objEntPadinDetalleTemp.EgresoDistritoJudicial
                        .EgresoSalaJuzgado = objEntPadinDetalleTemp.EgresoSalaJuzgado
                        If objEntPadinDetalleTemp.EgresoTipoAutoridadID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                            .EgresoJuez = objEntPadinDetalleTemp.EgresoJuez
                            .EgresoSecretario = objEntPadinDetalleTemp.EgresoSecretario
                        Else
                            .EgresoJuez = ""
                            .EgresoSecretario = ""
                            .EgresoOtroNombre = objEntPadinDetalleTemp.EgresoOtroNombre
                            .EgresoOtraAutoridad = objEntPadinDetalleTemp.EgresoOtraAutoridad
                        End If
                        .EgresoFecha = objEntPadinDetalleTemp.EgresoFecha
                        .EgresoObservacion = objEntPadinDetalleTemp.EgresoObservacion
                        .EgresoTipoID = objEntPadinDetalleTemp.EgresoTipoID
                        .EgresoTipo = objEntPadinDetalleTemp.EgresoTipo
                        .EgresoTipoMotivoID = objEntPadinDetalleTemp.EgresoTipoMotivoID
                        .EgresoTipoMotivo = objEntPadinDetalleTemp.EgresoTipoMotivo
                        .EgresoDocumento = objEntPadinDetalleTemp.EgresoDocumento
                        .TipoMovimientoID = objEntPadinDetalleTemp.TipoMovimientoID
                        '/*Datos del expediente de libertad egreso*/
                        If .TipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then
                            objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                            objEntPadinDetalleTemp = ListarExpedientesEgreso_tmp_v5(.IDDocumentoEgreso)
                            .EgresoDocumentoLibertad = objEntPadinDetalleTemp.EgresoDocumentoLibertad
                        Else
                            .EgresoDocumentoLibertad = .ExpedienteNumero
                        End If
                    End If

                    '/*detalle familia*/
                    If .InternoNumeroHijo > 0 Then
                        objEntColFamilia = ListarFamilia_tmp(.InternoID, DateAdd(DateInterval.Year, -3, Legolas.Configuration.Aplication.FechayHora.FechaDate).ToFileTime)

                        For Each obj As Entity.Registro.Familiar In objEntColFamilia
                            objEntPadinDetalleFam = New Entity.Estadistica.PadinDetalleFamilia
                            With objEntPadinDetalleFam
                                .Codigo = -1
                                .PadinID = PadinID
                                .RegionID = RegionID
                                .PenalID = PenalID
                                .InternoID = objEntInterno.InternoID
                                .PrimerApellido = obj.ApellidoPaterno
                                .SegundoApellido = obj.ApellidoMaterno
                                .PreNombres = obj.Nombres
                                .FechaNacimiento = obj.FechaNacimiento
                                .SexoID = obj.Sexo
                                .SexoNombre = obj.SexoNombre
                                .Vive = obj.Vive
                                .Recluido = obj.HijoReclucido
                            End With
                            objEntPadinDetalleColFam.Add(objEntPadinDetalleFam)
                        Next

                    End If
                End With

            Next

            For Each obj As Entity.Estadistica.PadinDetalle In objEntColInterno
                obj.PadinDetalleVisible = PadinVisible
                obj.PadinTipoMovimiento = PadinTipoMov
                obj.Codigo = Grabar_v2(obj)
            Next

            'grabar padin detalle familia
            objBssPadinDetalleFam = New Bussines.Estadistica.PadinDetalleFamilia

            For Each obj As Entity.Estadistica.PadinDetalleFamilia In objEntPadinDetalleColFam
                objBssPadinDetalleFam.Grabar(obj)
            Next

        End Sub

        Public Sub DatosComplementarios_plm_v6(PadinID As Integer, RegionID As Integer, PenalID As Integer, FechaIni As Long, FechaFin As Long,
                                            PadinVisible As Integer, PadinTipoMov As Integer, intVersionReporte As Short,
                                            ByRef objEntColInterno As Entity.Estadistica.PadinDetalleCol, ByRef strMensajeOut As String)

            Dim idsInterno As String = ""
            Dim idsIngreso As String = ""
            Dim idsMovimientos As String = ""

            Dim idsMovimientosEgreso As String = ""
            Dim idsDocumentoIngreso As String = ""
            Dim idsDocumentoEgreso As String = ""

            Dim objBssPadinDetalle As Bussines.Estadistica.PadinDetalle = Nothing
            Dim objEntPadinDetalleTemp As Entity.Estadistica.PadinDetalle = Nothing

            '/*interno familia*/
            Dim objBssFamilia As New Bussines.Registro.Familiar
            Dim objEntColFamilia As New Entity.Registro.FamiliarCol

            '/*padin detalle familia*/
            Dim objBssPadinDetalleFam As Bussines.Estadistica.PadinDetalleFamilia = Nothing
            Dim objEntPadinDetalleFam As Entity.Estadistica.PadinDetalleFamilia = Nothing
            Dim objEntPadinDetalleColFam As Entity.Estadistica.PadinDetalleFamiliaCol = Nothing

            objEntPadinDetalleColFam = New Entity.Estadistica.PadinDetalleFamiliaCol

            idsInterno = ConcatenarIdsInterno(objEntColInterno)
            idsIngreso = ConcatenarIdsIngreso((objEntColInterno))

            idsMovimientos = ConcatenarIdsMovimientos((objEntColInterno))
            idsMovimientosEgreso = ConcatenarIdsEgresoMovimientos((objEntColInterno))

            idsDocumentoIngreso = ConcatenarIdsDocumentosIngresos((objEntColInterno))
            idsDocumentoEgreso = ConcatenarIdsDocumentosEgresos((objEntColInterno))

            Try
                tblDatos = Data.Estadistica.PadinDetalle.ListarDatosComplementarios_plm_v6("lst", "datos_complementarios_plm_v6", idsInterno, idsIngreso, idsMovimientos,
                                                                                   idsMovimientosEgreso, idsDocumentoIngreso, idsDocumentoEgreso, FechaFin)
            Catch ex As Exception
                strMensajeOut = ex.Message
                Exit Sub
            End Try

            For Each objEntInterno As Entity.Estadistica.PadinDetalle In objEntColInterno

                'If objEntInterno.InternoID = 8545 Then MsgBox(objEntInterno.InternoID)
                With objEntInterno
                    .Codigo = -1

                    If .InternoSexo.ToUpper = "" Then
                    ElseIf .InternoSexo.ToUpper = "MASCULINO" Then
                        .InternoSexo = "M"
                    Else
                        .InternoSexo = "F"
                    End If

                    .PadinID = PadinID
                    .RegionID = RegionID
                    .PenalID = PenalID
                    .FechaCorte = FechaFin

                    If objEntInterno.InternoTipoDocumentoID <= 0 Then
                        .InternoTipoDocumento = "INDOCUMENTADO"
                    End If

                    .InternoNumeroHijo = NumeroHijo(.InternoID)

                    '/*Concatenar nombres asociados*/
                    .InternoNombresAsociados = ListarNombresAsociados_tmp(objEntInterno.InternoID)

                    '/*Concatenar alias*/
                    .InternoAlias = ListarAlias_tmp(objEntInterno.InternoID)

                    '/*Siscrico*/

                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = ListarSiscrico_tmp_v5(.InternoID)

                    .OrgCriminalNombre = objEntPadinDetalleTemp.OrgCriminalNombre
                    .OrgCriminalCondicion = objEntPadinDetalleTemp.OrgCriminalCondicion
                    .OrgCriminalFormaParte = objEntPadinDetalleTemp.OrgCriminalFormaParte

                    '/*Datos del ingreso*/
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = ListarIngreso_tmp_v6(.IDMovimiento, FechaFin)

                    .IngresoID = objEntPadinDetalleTemp.IngresoID
                    .FechaISP = objEntPadinDetalleTemp.FechaISP
                    .IngresoNumero = objEntPadinDetalleTemp.IngresoNumero
                    .IngresoMotivo = objEntPadinDetalleTemp.IngresoMotivo
                    .IngresoOrigen = objEntPadinDetalleTemp.IngresoOrigen
                    .IngresoDocumento = objEntPadinDetalleTemp.IngresoDocumento
                    .IngresoMotivoTraslado = objEntPadinDetalleTemp.IngresoMotivoTraslado
                    .FechaIngresoPenal = objEntPadinDetalleTemp.FechaIngresoPenal
                    .IngresoTipoMovimientoID = objEntPadinDetalleTemp.IngresoTipoMovimientoID
                    If PadinTipoMov = 1 Then
                        .ExpedienteID = objEntPadinDetalleTemp.ExpedienteID
                        .ExpedienteNumero = objEntPadinDetalleTemp.ExpedienteNumero
                        .IngresoSituacionJuridicaID = objEntPadinDetalleTemp.ExpedienteSituacionJuridicaID
                        .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                        .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                        .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                        .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                        .FechaRecepcion = objEntPadinDetalleTemp.FechaRecepcion
                    End If

                    If objEntPadinDetalleTemp.IngresoTipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                        If objEntPadinDetalleTemp.ExpedienteTipoAutoridadID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                            .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                            .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                            .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                            .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                        Else
                            .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSecretario & IIf(objEntPadinDetalleTemp.ExpedienteSecretario.Length = 0, "", IIf(objEntPadinDetalleTemp.ExpedienteJuez.Length = 0, "", "/" & objEntPadinDetalleTemp.ExpedienteJuez))
                        End If
                    Else
                        .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                        .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                        .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                        .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                    End If
                    '.IDDocumentoIngreso = objEntPadinDetalleTemp.IDDocumentoIngreso
                    '/*Expediente del internamiento*/
                    objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                    objEntPadinDetalleTemp = ListarExpedienteIngreso_tmp_v6(.InternoID, .IngresoID, FechaFin, PadinTipoMov)
                    .DelitoFlagrante = objEntPadinDetalleTemp.ExpedienteFlagrancia
                    'datos de la autoridad judicial
                    If PadinTipoMov = 1 Then
                        If .IngresoSituacionJuridicaID = 3 Then
                            .ExpedienteSituacionJuridicaID = ListarIngresoSituacionJuridicaID_tmp_v6(.InternoID, .IngresoID, .ExpedienteID, .ExpedienteNumero, .FechaRecepcion, FechaFin, PadinTipoMov)
                        Else
                            .ExpedienteSituacionJuridicaID = .IngresoSituacionJuridicaID
                        End If
                        If .ExpedienteID < 1 Then
                            .ExpedienteID = objEntPadinDetalleTemp.ExpedienteID
                            .ExpedienteNumero = objEntPadinDetalleTemp.ExpedienteNumero
                            .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                            .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                            .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                            .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                            .FechaRecepcion = objEntPadinDetalleTemp.FechaRecepcion
                            .ExpedienteSituacionJuridicaID = objEntPadinDetalleTemp.ExpedienteSituacionJuridicaID
                            .ExpedienteSituacionJuridica = objEntPadinDetalleTemp.ExpedienteSituacionJuridica
                        End If
                    Else
                        .ExpedienteID = objEntPadinDetalleTemp.ExpedienteID
                        .ExpedienteNumero = objEntPadinDetalleTemp.ExpedienteNumero
                        .ExpedienteDistritoJudicial = objEntPadinDetalleTemp.ExpedienteDistritoJudicial
                        .ExpedienteSalaJuzgado = objEntPadinDetalleTemp.ExpedienteSalaJuzgado
                        .ExpedienteJuez = objEntPadinDetalleTemp.ExpedienteJuez
                        .ExpedienteSecretario = objEntPadinDetalleTemp.ExpedienteSecretario
                        .ExpedienteSituacionJuridicaID = objEntPadinDetalleTemp.ExpedienteSituacionJuridicaID
                        .ExpedienteSituacionJuridica = objEntPadinDetalleTemp.ExpedienteSituacionJuridica
                        .FechaRecepcion = objEntPadinDetalleTemp.FechaRecepcion
                    End If
                    '/*Situacion juridica*/  
                    If PadinTipoMov <> 2 Then
                        .IngresoSituacionJuridicaID = ListarIngresoSituacionJuridicaID_tmp_v6(.InternoID, .IngresoID, .ExpedienteID, "", .FechaRecepcion, FechaFin, PadinTipoMov)
                        If intVersionReporte = 3 Then 'version del reporte padin
                            If .IngresoSituacionJuridicaID = 3 Then 'sentenciado/procesado
                                .IngresoSituacionJuridicaID = 2 'sentenciado
                            End If
                        End If
                        .IngresoSituacionJuridica = ListarIngresoSituacionJuridica(.IngresoSituacionJuridicaID)
                    End If
                    ''/*Delitos*/
                    If .ExpedienteID > 0 Then
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarDelitoMayorPena_tmp_v6(.InternoID, .IngresoID, FechaFin, .ExpedienteID, PadinTipoMov)
                        .DelitoID = objEntPadinDetalleTemp.DelitoID
                        .DelitoGenericoID = objEntPadinDetalleTemp.DelitoGenericoID
                        .DelitoGenerico = objEntPadinDetalleTemp.DelitoGenerico
                        .DelitoEspecificoID = objEntPadinDetalleTemp.DelitoEspecificoID
                        .DelitoEspecifico = objEntPadinDetalleTemp.DelitoEspecifico
                    End If
                    '/*Otros Delitos*/   actualizada 04/05/2021
                    .DelitoOtros = ListarOtrosDelitosExpediente_tmp_v6(.InternoID, .IngresoID, .ExpedienteID, PadinTipoMov)
                    '/*Agraviados*/
                    .DelitoAgraviados = ListarDelitoAgraviados_tmp_v6(.DelitoID)
                    '/*Otros expedientes con checked=0*/
                    .ExpedienteNumeroOtros = ListarExpedientesOtros_tmp_v6(.InternoID, .IngresoID, .ExpedienteID, FechaFin, .ExpedienteNumero, .FechaRecepcion, PadinTipoMov)

                    ''/*Datos de sentencia*/
                    If .IngresoSituacionJuridicaID < 1 And PadinTipoMov = 3 Then
                    Else
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarSentencias_tmp_v6(.InternoID, .IngresoID, FechaFin, .IngresoSituacionJuridicaID, .FechaRecepcion, PadinTipoMov)

                        .SentenciaID = objEntPadinDetalleTemp.SentenciaID
                        .SentenciaExpedienteID = objEntPadinDetalleTemp.SentenciaExpedienteID
                        .SentenciaDocumento = objEntPadinDetalleTemp.SentenciaDocumento

                        .SentenciaDistritoJudicial = objEntPadinDetalleTemp.SentenciaDistritoJudicial
                        .SentenciaSalaJuzgado = objEntPadinDetalleTemp.SentenciaSalaJuzgado
                        .SentenciaDocumento = objEntPadinDetalleTemp.SentenciaDocumento
                        .SentenciaPIFecha = objEntPadinDetalleTemp.SentenciaPIFecha

                        .SentenciaPIDistritoJudicial = objEntPadinDetalleTemp.SentenciaPIDistritoJudicial
                        .SentenciaPISalaJuzgado = objEntPadinDetalleTemp.SentenciaPISalaJuzgado
                        .SentenciaPIExpedienteNumero = objEntPadinDetalleTemp.SentenciaPIExpedienteNumero
                        .SentenciaSIDistritoJudicial = objEntPadinDetalleTemp.SentenciaSIDistritoJudicial
                        .SentenciaSISalaJuzgado = objEntPadinDetalleTemp.SentenciaSISalaJuzgado
                        .SentenciaSIExpedienteNumero = objEntPadinDetalleTemp.SentenciaSIExpedienteNumero

                        'periodos de condena
                        .SentenciaCadenaPerpetua = objEntPadinDetalleTemp.SentenciaCadenaPerpetua
                        If .SentenciaCadenaPerpetua = True Then
                            .SentenciaPenaImpuestaAnio = 500 'cadena perpetua
                        Else
                            .SentenciaPenaImpuestaAnio = objEntPadinDetalleTemp.SentenciaPenaImpuestaAnio
                        End If

                        .SentenciaPenaImpuestaMes = objEntPadinDetalleTemp.SentenciaPenaImpuestaMes
                        .SentenciaPenaImpuestaDia = objEntPadinDetalleTemp.SentenciaPenaImpuestaDia

                        .SentenciaFechaIni = objEntPadinDetalleTemp.SentenciaFechaIni
                        .SentenciaFechaFin = objEntPadinDetalleTemp.SentenciaFechaFin
                        .SentenciaObs = objEntPadinDetalleTemp.SentenciaObs
                        .SentenciaDelitoID = objEntPadinDetalleTemp.SentenciaDelitoID
                        .SentenciaDelitoGenerico = objEntPadinDetalleTemp.SentenciaDelitoGenerico
                        .SentenciaDelitoEspecificoID = objEntPadinDetalleTemp.SentenciaDelitoEspecificoID
                        .SentenciaDelitoEspecifico = objEntPadinDetalleTemp.SentenciaDelitoEspecifico

                    End If

                    '/*Datos del movimiento egreso*/
                    If .PadinTipoMovimiento = Type.Enumeracion.Padin.EnumTipoMovimiento.Egresos Then
                        objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                        objEntPadinDetalleTemp = ListarEgreso_tmp_v6(.IDMovimientoEgreso, .ExpedienteLibertarID, .TipoDetalleMovimientoSal)

                        .EgresoDestino = objEntPadinDetalleTemp.EgresoDestino
                        .EgresoDistritoJudicial = objEntPadinDetalleTemp.EgresoDistritoJudicial
                        .EgresoSalaJuzgado = objEntPadinDetalleTemp.EgresoSalaJuzgado
                        If objEntPadinDetalleTemp.EgresoTipoAutoridadID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                            .EgresoJuez = objEntPadinDetalleTemp.EgresoJuez
                            .EgresoSecretario = objEntPadinDetalleTemp.EgresoSecretario
                        Else
                            .EgresoJuez = ""
                            .EgresoSecretario = ""
                            .EgresoOtroNombre = objEntPadinDetalleTemp.EgresoOtroNombre
                            .EgresoOtraAutoridad = objEntPadinDetalleTemp.EgresoOtraAutoridad
                        End If
                        .EgresoFecha = objEntPadinDetalleTemp.EgresoFecha
                        .EgresoObservacion = objEntPadinDetalleTemp.EgresoObservacion
                        .EgresoTipoID = objEntPadinDetalleTemp.EgresoTipoID
                        .EgresoTipo = objEntPadinDetalleTemp.EgresoTipo
                        .EgresoTipoMotivoID = objEntPadinDetalleTemp.EgresoTipoMotivoID
                        .EgresoTipoMotivo = objEntPadinDetalleTemp.EgresoTipoMotivo
                        .EgresoDocumento = objEntPadinDetalleTemp.EgresoDocumento
                        .TipoMovimientoID = objEntPadinDetalleTemp.TipoMovimientoID
                        '/*Datos del expediente de libertad egreso*/
                        If .TipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then
                            objEntPadinDetalleTemp = New Entity.Estadistica.PadinDetalle
                            objEntPadinDetalleTemp = ListarExpedientesEgreso_tmp_v6(.IDDocumentoEgreso)
                            .EgresoDocumentoLibertad = objEntPadinDetalleTemp.EgresoDocumentoLibertad
                            .EgresoDocumento = objEntPadinDetalleTemp.EgresoDocumento
                            .IDExpedienteEgreso = objEntPadinDetalleTemp.IDExpedienteEgreso
                        Else
                            .EgresoDocumentoLibertad = objEntPadinDetalleTemp.EgresoDocumentoRD
                            If (.EgresoDocumentoLibertad.Length = 0) Then
                                .EgresoDocumentoLibertad = objEntPadinDetalleTemp.EgresoDocumento
                            End If
                        End If
                        .IngresoSituacionJuridicaID = ListarIngresoSituacionJuridicaID_tmp_v6(.InternoID, .IngresoID, .IDExpedienteEgreso, "", .FechaRecepcion, FechaFin, PadinTipoMov)
                        .IngresoSituacionJuridica = ListarIngresoSituacionJuridica(.IngresoSituacionJuridicaID)
                    End If

                    '/*detalle familia*/
                    If .InternoNumeroHijo > 0 Then
                        objEntColFamilia = ListarFamilia_tmp(.InternoID, DateAdd(DateInterval.Year, -3, Legolas.Configuration.Aplication.FechayHora.FechaDate).ToFileTime)

                        For Each obj As Entity.Registro.Familiar In objEntColFamilia
                            objEntPadinDetalleFam = New Entity.Estadistica.PadinDetalleFamilia
                            With objEntPadinDetalleFam
                                .Codigo = -1
                                .PadinID = PadinID
                                .RegionID = RegionID
                                .PenalID = PenalID
                                .InternoID = objEntInterno.InternoID
                                .PrimerApellido = obj.ApellidoPaterno
                                .SegundoApellido = obj.ApellidoMaterno
                                .PreNombres = obj.Nombres
                                .FechaNacimiento = obj.FechaNacimiento
                                .SexoID = obj.Sexo
                                .SexoNombre = obj.SexoNombre
                                .Vive = obj.Vive
                                .Recluido = obj.HijoReclucido
                            End With
                            objEntPadinDetalleColFam.Add(objEntPadinDetalleFam)
                        Next

                    End If
                End With

            Next

            For Each obj As Entity.Estadistica.PadinDetalle In objEntColInterno
                obj.PadinDetalleVisible = PadinVisible
                obj.PadinTipoMovimiento = PadinTipoMov
                obj.Codigo = Grabar_v2(obj)
            Next

            'grabar padin detalle familia
            objBssPadinDetalleFam = New Bussines.Estadistica.PadinDetalleFamilia

            For Each obj As Entity.Estadistica.PadinDetalleFamilia In objEntPadinDetalleColFam
                objBssPadinDetalleFam.Grabar(obj)
            Next

        End Sub

#End Region

#Region "Grabar"

        Public Function Grabar_v1_2(ByVal Obj As Entity.Estadistica.PadinDetalle) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With Obj
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_v1_2"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                intValue = Data.Estadistica.PadinDetalle.Grabar_v1_2(strAccion, strOpcion, Obj)
            End With

            Return intValue

        End Function

        Public Function Grabar_v2(ByVal Obj As Entity.Estadistica.PadinDetalle) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With Obj
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_v2_2"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                intValue = Data.Estadistica.PadinDetalle.Grabar_v2(strAccion, strOpcion, Obj)
            End With

            Return intValue

        End Function


        'Public Function Grabar(ByVal Obj As Entity.Estadistica.PadinDetalle) As Integer

        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""

        '    With Obj

        '        If .Codigo < 1 Then
        '            strAccion = "ins"
        '            strOpcion = "ins_mant"
        '        Else
        '            strAccion = "upd"
        '            strOpcion = "upd_mant"
        '        End If

        '        intValue = Data.Estadistica.PadinDetalle.Grabar(strAccion, strOpcion, .Codigo, _
        '        .PadinID, _
        '        .RegionID, _
        '        .PenalID, _
        '        .PenalCodigo, _
        '        .FechaCorte, _
        '        .InternoID, _
        '        .InternoCodigo, _
        '        .InternoTipoDocumentoID, _
        '        .InternoTipoDocumento, _
        '        .InternoNumeroDocumento, _
        '        .InternoPrimerApellido, _
        '        .InternoSegundoApellido, _
        '        .InternoPreNombres, _
        '        .InternoNombresAsociados, _
        '        .InternoAlias, _
        '        .InternoClasificacion, _
        '        .InternoPabellon, _
        '        .FechaISP, _
        '        .FechaIngresoPenal, _
        '        .IngresoNumero, _
        '        .IngresoSituacionJuridicaID, _
        '        .IngresoSituacionJuridica, _
        '        .DelitoGenericoID, _
        '        .DelitoGenerico, _
        '        .DelitoEspecificoID, _
        '        .DelitoEspecifico, _
        '        .DelitoOtros, _
        '        .DelitoAgraviados, _
        '        .ExpedienteDistritoJudicial, _
        '        .ExpedienteSalaJuzgado, _
        '        .ExpedienteJuez, _
        '        .ExpedienteSecretario, _
        '        .ExpedienteNumero, _
        '        .ExpedienteSituacionJuridicaID, _
        '        .ExpedienteSituacionJuridica, _
        '        .ExpedienteNumeroOtros, _
        '        .SentenciaFecha, _
        '        .SentenciaDistritoJudicial, _
        '        .SentenciaSalaJuzgado, _
        '        .SentenciaDocumento, _
        '        .SentenciaDelitoGenerico, _
        '        .SentenciaDelitoEspecificoID, _
        '        .SentenciaDelitoEspecifico, _
        '        .SentenciaPenaImpuestaAnio, _
        '        .SentenciaPenaImpuestaMes, _
        '        .SentenciaPenaImpuestaDia, _
        '        .SentenciaFechaIni, _
        '        .SentenciaFechaFin, _
        '        .SentenciaObs, _
        '        .IngresoMotivo, _
        '        .IngresoOrigen, _
        '        .IngresoDocumento, _
        '        .IngresoMotivoTraslado, _
        '        .InternoFechaNacimiento, _
        '        .InternoSexoID, _
        '        .InternoSexo, _
        '        .InternoNacimientoPaisID, _
        '        .InternoNacimientoPais, _
        '        .InternoNacimientoDepartamento, _
        '        .InternoNacimientoProvincia, _
        '        .InternoNacimientoDistrito, _
        '        .InternoNacionalidad, _
        '        .InternoNumeroHijo, _
        '        .InternoEstadoCivilID, .InternoEstadoCivil, _
        '        .InternoGradoInstruccionID, .InternoGradoInstruccion, _
        '        .InternoOcupacionGenericoID, .InternoOcupacionGenerico, _
        '        .InternoOcupacionEspecifico, _
        '        .InternoComunidaGenericaID, .InternoComunidaNativa, _
        '        .InternoDiscapacidadID, .InternoDiscapacidad, _
        '        .InternoPadre, _
        '        .InternoMadre, _
        '        .InternoDomicilio, _
        '        .InternoDomicilioDepartamento, _
        '        .InternoDomicilioProvincia, _
        '        .InternoDomicilioDistrito, _
        '        .InternoFiliacionPolitica, _
        '        .EgresoFecha, _
        '        .EgresoTipoID, .EgresoTipo, _
        '        .EgresoTipoMotivoID, .EgresoTipoMotivo, _
        '        .EgresoDestino, _
        '        .EgresoDistritoJudicial, _
        '        .EgresoDocumentoLibertad, _
        '        .EgresoDocumento, _
        '        .EgresoJuez, _
        '        .EgresoSecretario, _
        '        .EgresoSalaJuzgado, _
        '        .EgresoObservacion, _
        '        .InternoEstadoID, _
        '        Legolas.Configuration.Usuario.Codigo)
        '    End With

        '    Return intValue

        'End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Long, ByVal Usuario As Integer) As Long
            Return Data.Estadistica.PadinDetalle.Eliminar("del", "del_mant", Codigo, Usuario)
        End Function
#End Region

#Region "Otros"
        Private Function PintarColeccion(objColecction As Entity.Estadistica.PadinDetalleCol) As Entity.Estadistica.PadinDetalleCol
            Dim value As Entity.Estadistica.PadinDetalleCol

            Dim intIDinterno As Integer = -1

            Dim objInternoCol As New Entity.Estadistica.PadinDetalleCol

            For Each obj As Entity.Estadistica.PadinDetalle In objColecction

                Dim intCountInterno As Integer = 0
                For Each obj2 As Entity.Estadistica.PadinDetalle In objColecction
                    If obj.InternoID = obj2.InternoID And obj2.InternoLeido <> 1 Then
                        obj2.InternoLeido = 1
                        intCountInterno += 1
                    End If
                Next
                If intCountInterno > 1 Then
                    objInternoCol.Add(obj)
                End If
            Next

            Dim objColor As System.Drawing.Color
            For Each obj As Entity.Estadistica.PadinDetalle In objInternoCol
                objColor = PaletaColores(intIndColor)
                For Each obj2 As Entity.Estadistica.PadinDetalle In objColecction
                    If obj.InternoID = obj2.InternoID Then
                        obj2.InternoColor = objColor
                    End If
                Next
                intIndColor += 1
            Next
            value = objColecction

            Return value
        End Function

        Private Function PaletaColores(NumeroColor As Integer) As Color

            Dim value As Color

            Select Case NumeroColor
                Case 1
                    value = Color.Aquamarine
                Case 2
                    value = Color.SandyBrown()
                Case 3
                    value = Color.Khaki()
                Case 4
                    value = Color.FromArgb(170, 161, 142)
                Case 5
                    value = Color.Coral()
                Case 6
                    value = Color.LightSkyBlue()
                Case 7
                    value = Color.FromArgb(232, 123, 148)
                Case 8
                    value = Color.FromArgb(165, 133, 200)
                Case 9
                    value = Color.GreenYellow()
                Case 10
                    value = Color.FromArgb(252, 174, 158)
                Case 11
                    value = Color.FromArgb(185, 194, 211)
                Case 12
                    value = Color.LightGreen()
                Case 13
                    value = Color.DarkKhaki()
                Case 14
                    value = Color.CornflowerBlue
                Case 15
                    value = Color.Pink()
                Case 16
                    value = Color.FromArgb(202, 240, 226)
                Case 17
                    value = Color.Violet()

                Case Else
                    'value = Color.White
                    Dim lSup As Integer = 255
                    Dim lInf As Integer = 100

                    value = Color.FromArgb((lSup - lInf) * Rnd() + lInf, (lSup - lInf) * Rnd() + lInf, (lSup - lInf) * Rnd() + lInf)

            End Select

            Return value
        End Function

        Public Function ObtenerColor() As Color
            intIndColor += 1
            Return PaletaColores(intIndColor)
        End Function
#End Region

    End Class
End Namespace