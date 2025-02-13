Public Class Reporte
    Public Enum Visita
        rpt = -1
        rptVisitaMovimiento = 5
        rptSancionInterno = 10
        rptSancionVisitante = 11
        rptHistorialVisitante = 12
        rptHistorialInterno = 13
        rptAutorizacion = 14
        rpt_autorizacion_anexo = 18
        rpt_autorizacion_grupo = 20
        rpt_autorizacion_estadistico = 21
        rpt_siscrico_visita = 23
        rpt_visita_visitante_historial = 38
        rpt_visita_interno_historial = 39
        rpt_visita_movimientos_x_fechas = 40
        rpt_visita_resumen_movimientos_x_fechas = 41

    End Enum

    Public Enum Registro
        rpt = -1
        rptFicha = 4 'ficha de identificacion version 
        rptPapeletaExcarcelacion = 7  'Papeleta de excarcelacion 02/11/2020 J.E.U
        'crimen organizado
        rptGruposCrimenOrganizado = 15 'rpt_org_criminal -> hrosario -> add -> 21.04.2014
        rptIntPorGrupCrimOrg_X_Penal = 16 'hrosario -> add -> 21.04.2014
        rptCabecillasGrupCrim = 17 'hrosario -> add -> 21.04.2014
        rptIntPorGrupCrimOrg_X_Sede = 19 'hrosario -> add -> 21.04.2014
        rptIntPorGrupCrimOrg_Resumen = 22
        'registro
        rptFichaDecadactilar = 24
        rptContanciaReclusion2 = 25 'hnrb -> 07082014 -> constancia de reclucion version 2
        rptFichaIdentificacion = 35 'ficha de identificacion version5
        rptFichaIdentificacionCarceleta = 48
        'reniec
        rptFichaValidIntReniec = 33 'hnrb -> 07082014 -> ficha de validacion de interno - reniec
        rptListaIntValidReniec = 34 'hnrb -> 07082014 -> lista de internos validados con la reniec

        rptCertificadoLibertad2 = 36
        rptCertificadoAntecedentePenal2 = 37

        'clasificacion
        rptClasificacionFichaLegal = 38
        rptClasificacionFichaSocial = 39
        rptClasificacionFichaPsicologica = 40
        rptClasificacionFichaFinal = 41
        rptCertificadoReclusion_v3 = 42
        rptClasificacionOficioConsolidado = 43
        rptCertificadoLibertad_v3 = 44

        'antecedentes
        rptCertificadoAntecedenteJudSiPPPMD_v1 = 45 'antecedente judicial negativo
        rptCertificadoAntecedenteJudNegativo_v1 = 46 'antecedente judicial positivo
        rptListaCertificadoAntecedendeJudicial_v1 = 47
        rptFichaIdentificacionCarceleta_v1 = 47
        rptCertificadoAntecedenteJudNoPPPMD_v1 = 49 'antecedente judicial negativo
        rptFichaPenologicaCarceleta = 53
        rptListaHistorialAntecedendeJudicial_LM_v1 = 54 ' Historial antecedentes
        rpt_tupa_v0 = 59 '55,56,57,58 lo usa tratamiento
        rptCertificadoAntJudPositivo_v0 = 60
        rptCertificadoAntJudNoPPPMD_v0 = 61
        rptCertificadoAntJudNegativo_v0 = 62

        rptCertificadoReclusion_LM = 63
        rptCertificadoLibertad_LM = 64
        rptCertificadoLibertad_LM_v2 = 65

        rptFichaIdentificacion_V5 = 66
        rptClasificacionFormato06 = 67
        rptListaHistorialAntecedendeJudicial = 68

        rptListaAlertaSentencia = 69
        rptListaInternoInimputable = 70
        rptListaInternoPosibleInimputable = 71
    End Enum

    Public Enum Movimiento
        rpt = -1
        rptMovIngresosPorPenal = 26 'hnrb -> 07.08.2014 -> movimiento de ingresos x penal
        rptMovIngresosPorSede = 27 'hnrb -> 07.08.2014 -> movimiento de ingresos x sede
        rptMovLibEjecutadasPorPenal = 28 'hnrb -> 07.08.2014 -> movimiento de libertades ejecutadas x penal
        rptMovLibEjecutadasPorSede = 29 'hnrb -> 07.08.2014 -> movimiento de libertades ejecutadas x sede
        rptMovEgresosPorPenal = 30 'hnrb -> 07.08.2014 -> movimiento de egresos por penal
        rptMovEgresosPorSede = 31 'hnrb -> 07.08.2014 -> movimiento de egresos por sede
        rptMovPorInterno = 32 'hnrb -> 07.08.2014 -> movimientos x interno
        rptMovIngresoACarceleta = 50 'hnrb -> 26.02.2018 -> movimiento de ingreso a carceleta.
        rptFichaFinalGeneradas = 51 'jneu -> 26.02.2018 -> Lista de ficha final generadas.
        rptListaInternoClasifPorPenal = 52 'hnrb -> 26.02.2018 -> Lista de internos clasificados por penal
    End Enum

    Public Class Tratamiento
        Public Class Trabajo
            Public Enum TallerAsistencia
                Ninguno = 0
                rptPlanillaLaboral_v1 = 55
                rpt_mov_internoasistencia = 56
                rpt_mov_asistencia = 57
                rptPlanillaIndividual_v1 = 58
                rpt_ClasificacionRegimen = 100
                rpt_ClasificacionEtapa = 200
                rpt_ClasificacionPorRegresion = 201
                rpt_ClasificacionPorTraslado = 202
                rpt_ClasificacionEtapaordinario = 300
                rpt_ClasificacionEtapaEspecial = 400
            End Enum
        End Class
    End Class

End Class
