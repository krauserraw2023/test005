Public Class Combo
    Public Enum ComboTipo
        All = -1
        Ninguno = 0
        Sexo = 1
        TipoDoc = 2
        EstadoCivil = 3
        Nacionalidad = 4
        Pais = 5
        Departamento = 6
        Provincia = 7
        Distrito = 8
        NivelAcademico = 9
        Profesion = 10
        Ocupacion = 11
        DelitoGenerico = 12 'ver
        DelitoEspecifico = 13 'ver
        IngresoMotivo = 14 'ver
        AutorizacionJudicial = 15 'ver
        SalaJusticial = 16 'ver
        SituacionJuridica = 17 'ver
        InternoEstado = 18 'ver
        InternoDiscapacidad = 19 'ver
        ComunidadAndina = 20 'ver
        ComunidadAndinaEspecifico = 21 'ver
        TipoLibertad = 22 'ver
        Penal = 23 'ver
        Region = 24 'ver
        TipoFamilia = 25 'tipo familia
        SentenciaTipo = 26 'ver
        DelitoGenericoRpt = 27 'ver
        DelitoEspecificoRpt = 28 'ver
        MLBeneficio = 29 'ver
        MLOcupacion = 30 'ver
        MLSituacion = 31 'ver
        MLMotivo = 32 'ver
        MLPenal = 33 'ver

        Traslado = 34 'ver
        Dependencia = 35
        PenalUsuario = 36 'ver
        RegionUsuario = 37 'ver

        MLSentenciaTipo = 38 'ver
        MLEntidadTipo = 39 'ver
        MLMedidaJornada = 40 'ver
        MLPenalUsuario = 41 'ver
        VISMotivo = 42 'ver
        VISTipo = 43 'ver
        VISSancionTipo = 44 'ver
        'General - señas particulares
        SenaParticular = 45 'ver
        'General - Rasgos
        Rasgo = 46 'ver

        PenalPabellon = 47
        Biometrico = 48
        Parentesco = 49
        SentenciaSubTipoDetalle = 50 'libre
        MovimientoTipo = 51
        MovimientoMotivo = 52
        DocJudicialTipo = 53

        VIS_RetriccionTipo = 54
        MovimientoGrupo = 55
        VIS_Etapa = 56

        RegionLicencia = 57
        PenalLicencia = 58
        VIS_RegimenVisita = 59
        BandaTipo = 60
        Banda = 61
        BandaMiembroTipo = 62
        TipoAutoridadJudicial = 63
        TipoAclaratoriaExpediente = 64

        RegionLicencia_TieneSistemaVisita = 65
        PenalLicencia_TieneSistemaVisita = 66

        OdontogramaArcoDentarioTipo = 67
        OdontogramaDienteTipo = 68
        OdontogramaOclusionTipo = 69
        OdontogramaTamanioDentomaxilar = 70
        OdontogramaTamanioDiente = 71

        ClasificacionAmbito = 72 'corresponde a la tabla cla_mae_tipo_ficha
        ClasificacionTipoFicha = 73 'tabla cla_mae_ambito_clasificacion
        ClasificacionEstadoDocumento = 74 'estado de tramite del documentode clasificacion (Oficio)
        TipoAnulacion = 75 'Listar tipo de Anulaciones
        TipoAutoridadJudicialPorDescrip = 76
        Idioma = 77 'gen_idioma
        GeneroPersona = 78 'tabla c_genero
        Religion = 79
        FuerzaArmada = 80
        RangoMilitar = 81
        SolicitudSIS = 82

        RegionInpe = 87
        NumCorrelativo = 89
        seg_pqt_tipoarticulo_mae = 94
        Establecimientomental = 95
        Inimputable = 96
        TipoAutoridadJudicialSolicitante = 97
    End Enum
    Public Class Tratamiento
        Public Class Trabajo

            Public Enum TallerAsistencia
                TallerTipoActividad = 1
                TallerActividad = 2
                Talleres = 3
                tra_tal_asistencia_justificacion_mae = 4
                tra_tal_motivo_retiro_mae = 5
                tra_tal_retiro_planilla_mae = 6
            End Enum

        End Class
    End Class
    Public Enum enmTipoTexto As Short
        Ninguno = 0
        Mayuscula = 1
        Minuscula = 2
        Propio = 3
    End Enum
End Class