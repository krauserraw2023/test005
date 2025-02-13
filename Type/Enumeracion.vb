Public Class Enumeracion
    Public Enum enmTipoAutoridadJudicial
        Ninguno = 0
        autoridadJudicial = 1
        directorEP = 6
        ministerioPublico = 9
        poderJudicial = 15
        presidenteCTP = 17
        propioInterno = 18
        minjus = 19
    End Enum

    Public Class Tratamiento
        Public Enum enmMotivoDetallePlanilla As Short
            Falta = 0 'F
            Asistio = 1 'A
            'Faltas justificadas
            OmisionMarcado = 2
            Diligenciashospitalarias = 3 'f
            Diligenciasjudiciales = 4 'f
            Tratamientopenitenciario = 5
            Atenciónmédica = 6
            Entrevistaabogado = 7
            Faltadisciplinaria = 8
            'Retiro de Taller
            Libertad = 9 'L
            SancionDisciplinaria = 10 'S
            Faltas02Consecutivas = 11
            Faltas04InjustificadasMes = 12
            Endeudamiento = 13
            Traslado = 14
            SolicitudInterno = 15
            Feriado = 16 'X
            DiaNoLaboral = 16  'X
        End Enum
        Public Enum enmMotivoRetiro
            Libertad = 1
            FaltaDisciplinaria = 2
            SancionDisciplinaria = 3
            FaltaConseInjus02 = 4
            FaltaConseInjus04 = 5
            PorEndeudamiento = 6
            Traslado = 7
            SolicitudInterno = 8
        End Enum
    End Class
    Public Enum enmDominioIdioma As Short
        Ninguno = -1
        Basico = 1
        Intermedio = 2
        Avanzado = 3
    End Enum
    Public Enum enmTipoDocumento
        Ninguno = 0
        LE = 1 'libreta electoral
        LM = 2 'libreta militar
        CE = 3 'carne de extranjeria
        PAS = 4 'pasaporte
        PN = 6 'partida nacimiento
        DNI = 10
        CC = 13 'credencial consular
        PTP = 16 'permiso temporal de permiso
        CPP = 17 'carné permiso temporal de permiso
    End Enum

    Public Class Parentesco
        Public Enum TipoVisita
            Ninguno = 0
            Familiares = 1
            Administrativa = 2
            MenoresEdad = 3
        End Enum
        Public Enum TipoGrado
            Ninguno = 0
            Consanguinidad = 1
            Afinidad = 2
        End Enum

        Public Enum ParentescoID
            Ninguno = 0
            Padre = 1
            Madre = 2
            Conyugue = 3
            Abuel0 = 5
            Amigo = 8
            Conviviente = 10
            Yerno = 14
            Nuera = 15
            Suegr0 = 16
            Abogado = 18
            Bisabuel0 = 29
            Abuel0Conyuge = 31
            TutorHijosMenores = 35
            Observado = 36
        End Enum
        Public Enum ParentescoGrupo
            Ninguno = 0
            Familiares = 1
            Abogado = 2
            FamiliaresAbogado = 3
        End Enum
    End Class

    Public Class Biometria
        Public Enum TipoHuellas As Short
            Ninguno = 0
            Interno = 1 'huella de internos
            Visitante = 2 'huella de visitante
        End Enum
        Public Enum TipoDedo As Short
            Ninguno = 0
            MeniqueIzquierdo = 1
            AnularIzquierdo = 2
            MedioIzquierdo = 3
            IndiceIzquierdo = 4
            PulgarIzquierdo = 5
            PulgarDerecho = 6
            IndiceDerecho = 7
            MedioDerecho = 8
            AnularDerecho = 9
            MeniqueDerecho = 10
        End Enum
        Public Enum CalidadHuella As Short
            NoEspecificado = -1
            MuyAlta = 1
            Alta = 2
            Media = 3
            Baja = 4
            MuyBaja = 5
        End Enum
        Public Enum enumTipoDispositivo As Short
            Ninguno = 0
            RealScanG1 = 1
            FutronicFS10 = 2
        End Enum
    End Class

    Public Class Visita

        Public Class Visitante

            Public Enum Focus
                Ninguno = 0
                NumeroDocumento = 1
                FechaNacimiento = 2
            End Enum

            Public Enum ValidadoServicio As Short
                SinValidar = 0
                ReniecValidado = 1
                Diferencias = 2
                MigracionesValidado = 11
                ReniecValidado5111 = 5111
                ReniecValidado5114 = 5114
            End Enum
            Public Enum TieneHuella As Short
                Ninguno = 0
                SI = 1
                Obs = 2
            End Enum

            Public Enum TipoCapturaHuella
                Amputado = 0
                Normal = 1
                Observado = 2
            End Enum
        End Class

        Public Enum EnumTipo
            Ninguno = 0
            Penal = 1
            Aministrativa = 2
            RegistroPaquetes = 3
        End Enum
        Public Enum Sancion
            Ninguno = 0
            Interno = 1
            Visitante = 2
        End Enum
        Public Enum Frecuencia
            Ninguno = -1
            Diario = 1
            Semanal = 2
            Mensual = 3
        End Enum
        Public Enum ProgramacionMensual
            Meses = 1
            Dias = 2
            El = 3
            DiaSemana = 4
        End Enum
        Public Enum RegimenVisita
            Ninguno = -1
            RegimenOrdinario = 1
            RegimenCerradoEspecial = 2
            RegimenOrdinario_RegimenCerradoEspecial = 3
            Administrativa = 4
            PoderJudicial = 5
        End Enum
        Public Enum TipoVisita
            Ninguno = -1
            Ordinario = 2
            Intimas = 5
            Extraordinario = 10
            MenorEdad = 11
            Abogado = 12
            Etapas = 13
        End Enum
        Public Enum CalendarioValidacion
            Ninguno = 0
            Sexo = 1
            FechaInicio = 2
            FechaFin = 3
            DiaSemana = 4
            Mes = 5
            MesDias = 6
            HoraInicio = 7
            HoraFin = 8
            CountInternoMovimiento = 9
            CountInternoMovimientoConsanguidad = 10
            GradoConsanguidad = 11
            CountInternoMovimientoAfinidad = 12
            GradoAfinidad = 13
            IncluyeConyugue = 14
            IncluyeAmigo = 15
            VisitanteAutorizado = 16
            IncluyeAbogado = 17
            EdadInicio = 18
            EdadFin = 19
        End Enum

        Public Enum AutorizacionTipo
            Autorizado = 1
            Anulacion = 2
            Extraordinario = 99
        End Enum

        Public Enum AutorizacionVista
            Interno = 1
            Visitante = 2
        End Enum

        Public Class Movimiento
            Public Enum IngresoPor As Short
                Ninguno = 0
                CapturaHuella = 1
                VerificacionHuella = 2
                HuellaObs = 3
                Recaptura = 4
                VerificacionHuellaRecaptura = 5
                HuellaObsRecaptura = 6
            End Enum
            Public Enum SalidaPor As Short
                Masivo = 0
                DNI = 1
                Huella = 2
            End Enum

        End Class

    End Class

    Public Class Movimiento
        Public Enum EnumTipoAutoridad
            AutoridadJudicial = 1
            OtraAutoridad = 2
            NoEspecificado = 3 'debe ser cero
            DireccionRegional = 4
            Inpe = 5
            DireccionPenal = 6
            ComisionDeIndultos = 7
            ForoMilitar = 8
            MinisterioPublico = 9
            PoliciaNacional = 10
            Congreso = 11
            DefensoriaDelPueblo = 12
            Contraloria = 13
            PresidenteDeLaRepublica = 16
        End Enum

        Public Enum EnumMovGrupo
            Ingreso = 1
            Egreso = 2
        End Enum

        Public Enum EnumMovTipo
            Internamiento = 1
            Traslado = 2
            Libertad = 3
            Fuga = 4
            Fallecimiento = 5
            Conducciones = 6
            IngresoPLD = 7
            ConduccionClasificacion = 8
            TrasladoHospitalmental = 9
            RetornodeHospitalmental = 10
        End Enum

        Public Enum EnumMovMotivo
            Ninguno = -1
            NuevoIngreso = 1
            IngresoRevocatoria = 2
            IngresoTraslado = 3
            IngresoPrisionPreventiva = 113
            IngresoReincidencia = 115
            IngresoSentencia = 124
            IngresoReiterante = 129

            Inimputable = 178
            PosibleInimputable = 179
            Por_Medida_De_Seguridad_De_Internación = 180
            Internación_Preventiva_Posible_Inimputable = 181
            Adelanto_de_fallo = 196
        End Enum

        Public Enum EnumRegDocTipo
            Traslado = 5
            Libertad = 6
            Internamiento = 14
            'Traslado = 2
            'Fuga = 4
            'Fallecimiento = 5
            'Conducciones = 6
        End Enum
        Public Enum EnumRegSubDocTipo As Short

            Fuga = 7
            Fallecimiento = 6
            'Conducciones = 6
        End Enum
        Public Enum EnumEstadoTramite As Short
            Pendiente = 1
            En_proceso = 2
            Terminado = 3
        End Enum
        Public Enum enmEstadoMovimiento As Short
            Pendiente = 1
            EnProceso = 2
            Terminado = 3
            EnDesarrollo = 4
            EgresoTemporal = 5
            EgresoDifinitivo = 6
            NoEjecutadoOpcion1 = 41
            NoEjecutadoOpcion2 = 42
            NoEjecutadoOpcion3 = 43
            NoEjecutadoOpcion4 = 44
        End Enum
    End Class

    Public Class SituacionJuridica 'debe eliminarse 
        Public Enum EnumSituacionJuridica
            Ninguno = 0
            Procesado = 1
            Sentenciado = 2
            Procesado_Sentenciado = 3
        End Enum
    End Class

    Public Class Padin
        Public Enum EnumPadinEstado
            Pendiente = 1
            Procesado = 2
            EnviadoRegion = 3
            EnviadoSCentral = 4
            Anulado = 5
            RecepcionRegion = 6
        End Enum
        Public Enum EnumTipoMovimiento
            Ingresos = 1
            Egresos = 2
            PoblacioActiva = 3
        End Enum
    End Class

    Public Class Usuario
        Public Enum EnumTipoUsuario
            Penal = 1
            Regional = 2
            Nacional = 3
        End Enum
        Public Enum EnumDependencia
            Ninguno = 0
            SistemasInformacion = 1
            RegistroPenitenciario = 2
            UnidadEstadistica = 3
            MedioLibre = 4
            SeguridadPenitenciaria = 5
            Direccion = 6 'director de penal
            TratamientoPenitenciario = 7
            Psicologo = 8
            Legal = 9 'asesor legal (abogado)
            Social = 10 'asistente social
            Odontologo = 11 'medico/tecnico odontologo
            JefeSeguridad = 12
            JefeGrupoSeguridad = 13
            SubDirector = 14
            SecretariaJuntaClasificacion = 15
            RegistroAntecedentes = 16
            RegistroIgresoDetenciones = 17
            RegistroSentenciasLibertades = 18
            DireccionRegistroPenitenciario = 20
            '***perfiles clasificacion de pabellones***
            JefeJTCyLegal = 21
            JefeJTCyPsicologo = 22
            JefeJTCySocial = 23
            JefeJTCyLegalPsicologoSocial = 24
            'JefeTratamientoyLegal = 25
            'JefeTratamientoyPsicologo = 26
            'JefeTratamientoySocial = 27
            'JefeTratamientoJefeJuntaTecnicaClasificacionyLegal = 28
            'JefeTratamientoJefeJuntaTecnicaClasificacionySocial = 29
            'JefeTratamientoJefeJuntaTecnicaClasificacionyPsicologo = 30
            GabineteIdentificacionOdontologo = 31
            JefeTratamientoPenitenciario = 32
        End Enum
    End Class

    Public Class ArchivoDigital
        Public Enum TipoImagen
            Ninguno = 0
            Interno = 1
            Personal = 2
            Visitante = 3
            Reniec = 4
            Reniec_Sybase = 5
            Odontograma = 6
        End Enum
    End Class

    Public Class DocumentoJudicial

        Public Enum enmTipoDocumento As Short
            Ninguno = 0
            Traslado = 5
            Libertad = 6
            Ingreso = 14
            Sentencia = 17
            EjecutoriaSuprema = 21
            EjecutoriaSuperior = 22
            SentenciaConsentida = 27
            Resolucion = 31
            OrdenTrasladoHospital = 70
            RetornoTrasladoHospital = 71
            OrdenTrasladoHospital_Nota = 74
        End Enum

        Public Enum enmSubTipoDocumento As Short
            Ninguno = 0
            Aclaratoria_de_Expediente = 1
            Aclaratoria_de_Nombre = 2
            Fallecimiento = 6
            Fuga = 7
            Aclaratoria_de_ExpedienteNombres = 3
            NuevoIngreso = 26
            IngresoRevocatoria = 27
            IngresoTraslado = 28
            IngresoPrisionPreventiva = 29
            InternamientoReferenciado = 30
            IngresoReincidencia = 38
            IngresoSentencia = 90
            Nota_de_Sentencia = 8
            Adelanto_de_Fallo = 82
            ProyeccionVencimientoCondena = 93
        End Enum

        Public Enum enmEstadoEjecucion As Short
            EnDesarrollo = 1
            Apto = 2
            Ejecutado = 3
            NoEjecutado = 4
            NoEjecutadoOpcion1 = 41
            NoEjecutadoOpcion2 = 42
            NoEjecutadoOpcion3 = 43
            NoEjecutadoOpcion4 = 44
        End Enum
        Public Class Expediente
            Public Enum enmTipoAutoridadJudicial
                Ninguno = 0
                AutoridadJudicial = 1
            End Enum

            Public Enum enmTipoExpediente
                NoPertenece = 0
                Inimputable = 178
                PosibleInimputable = 179
            End Enum
        End Class

    End Class

    Public Class TipoDocJudicial 'jmr, debe eliminarse, usar DocumentoJudicial.enmTipoDocumento
        Public Enum enumTipoDocumentoJudicial
            Ninguno = 0
            Rectificacion_Nombres = 1
            Anulacion_Nombres = 2
            Notas_Egreso = 3
            Internamiento = 4
            Traslado = 5
            Libertad = 6
            Conducciones = 7
            Siscrico = 8

            Avocamiento = 9
            Prolongacion_Detencion = 10
            Ampliacion_Autoapertorio = 11
            Detencion = 12
            Aclaratoria = 13
            Ingreso = 14
            Notas = 15
            'Sentencia
            Nota_Sentencia = 16
            Sentencia = 17
            Sentencia_Aclaratoria = 18
            Refundicion_de_Sentencia = 19
            Integracion_Sentencia = 20
            Ejecutoria_Suprema = 21
            Ejecutoria_Superior = 22
            Sent_Sustitucion_Pena = 23
            Sent_Adecuacion_Pena = 24
            Sent_Conmutacion_Pena = 25
            Queda = 26
            ResolucionConsentida = 27
            AcumulacionExpedientes = 28
            Sumatoria_de_Sentencia = 29
            'Prision_Preventiva = 30
            Revocatoria_de_Libertad = 30
            Resolucion = 31
            Resolucion_Superior = 32
            Sent_Pena_Limitativa = 33
            Anulacion_Antecedentes = 34
            DetencionCarceleta = 35
            EjecutoriaSuperiorPLD = 36
            Revocatoria = 37
            DetencionReferenciado = 66
            Adecuacion_Prision_Preventiva = 67
            Prolongacion_Prision_Preventiva = 68
            EjecutoriaSuperiorPLD_Consentida = 69

            OrdenTraslado_HospitalMental = 70
            Retorno_de_HospitalMental = 71
            ResolucionDeclaraConsentida = 72
            OtroProceso = 73
            OrdenTraslado_HospitalMental_Nota = 74
        End Enum
        Public Enum enumCategoria
            Ninguno = 0
            Resolucion = 1
            Sentencia = 2
            Libertad = 3
        End Enum
    End Class
    Public Class SubTipoDocJudicial 'jmr, debe eliminarse, usar DocumentoJudicial.enmSubTipoDocumento
        Public Enum enumSubTipo
            Aclaratoria_de_Expediente = 1
            Aclaratoria_de_Nombre = 2
            Fallecimiento = 6
            Fuga = 7
            Aclaratoria_de_ExpedienteNombres = 3
            NuevoIngreso = 26
            IngresoRevocatoria = 27
            IngresoTraslado = 28
            IngresoPrisionPreventiva = 29
            InternamientoReferenciado = 30
            IngresoReincidencia = 38
            IngresoSentencia = 90
            Nota_de_Sentencia = 8
            Adelanto_de_Fallo = 82
            ProyeccionVencimientoCondena = 93

            'Inimputables = 95
            'PosibleInimputable = 96
        End Enum
        Public Enum enumSubTipoCombo
            Ninguno = 0
            Sentencias = 17
            Ejecutorias = 21
            EjecutoriaSuperior = 22
            Anulaciones = 34
            EjecutoriaSentenciaPLD = 36
        End Enum
        Public Enum enumAccion
            Ninguno = -1
            Anulado = 0
            Aclarado = 1
            Aniadido = 2  ' Añadido

        End Enum
        Public Enum enumListar
            Ingreso = 1
            Egreso = 2
            Aclarados = 3
            Sentencia = 4
            Todos = 5 ' 
        End Enum
    End Class
    'Public Class enumExpediente
    '    Public Enum Libertad_sin_Movimiento 'Libertades que no generan Movimiento
    '        ArrestoDomiciliario = 19
    '        Impunibilidad = 64
    '    End Enum
    'End Class
    Public Class Auditoria
        Public Enum EnumTipTabla As Integer
            Ninguno = 0
            INT_Movimiento = 1
            REG_DOC_Judicial = 2
            INT_InternoExpediente = 3
            INT_InternoDelito = 4
            INT_InternoAgraviado = 5
            INT_InternoRasgo = 6
            INT_InternoSenaParticular = 7
            INT_InternoFoto = 8
            INT_InternoIngreso = 9
            INT_InternoFamiliares = 10
            INT_InternoAlias = 11
            INT_Interno = 12
            INT_InternoNombreAsociado = 13
            INT_InternoHistorico = 14
            INT_InternoClasificacion = 15 'correspondiente con la tabla cla_mov_interno_clasificacion
            INT_InternoFichaClasificacion = 16 'correspondiente con la tabla cla_mov_interno_ficha
            reg_mov_internobanda = 17
            TRA_ASI_MOV_DOCUMENTO = 18 'Tabla de documento de derivacion de internos clasificados
            INT_Internobanda = 19
            INT_InternoReniec = 20
            int_mov_interno_odontograma = 21
            int_mov_interno_ingreso_inpe = 22
            ANJ_MOV_SolicitudAntecedente = 23
            tra_asi_mov_interno_penal_ficha = 24
            tra_asi_mov_interno_pabellon = 25
            reg_cons_reclu_mov_tramite = 26
        End Enum
    End Class
    Public Class TipoTabla 'debe eliminarse
        Public Enum EnumTipTabla As Integer
            Ninguno = 0
            INT_Movimiento = 1
            REG_DOC_Judicial = 2
            INT_InternoExpediente = 3
            INT_InternoDelito = 4
            INT_InternoAgraviado = 5
            INT_InternoRasgo = 6
            INT_InternoSenaParticular = 7
            INT_InternoFoto = 8
            INT_InternoIngreso = 9
            INT_InternoFamiliares = 10
            INT_InternoAlias = 11
            INT_Interno = 12
            INT_InternoNombreAsociado = 13
            INT_InternoHistorico = 14
            'INT_InternoClasificacion = 15 'correspondiente con la tabla cla_mov_interno_clasificacion
            INT_InternoFichaClasificacion = 15 'correspondiente con la tabla cla_mov_interno_ficha
            reg_mov_internobanda = 17
            TRA_ASI_MOV_DOCUMENTO = 18 'Tabla de documento de derivacion de internos clasificados
            INT_Internobanda = 19
            INT_InternoReniec = 20
            'ya no agregar mas registro, agregar al type Auditoria.EnumTipTabla
        End Enum
    End Class
    Public Class EstadoNulidadRegistro 'debe eliminarse
        Public Enum EnumEstadoNulidadRegistro As Integer
            No_Determinado = -1
            Anulado = 0
            Activo = 1
        End Enum
    End Class
    Public Class Reniec
        Public Enum EnmTipoValidacion As Short
            Ninguna = -1
            DNI = 1
            DatosPrincipales = 2
            NombreAsociado = 3
        End Enum
        Public Enum EnmTipoResultado As Short

            Validado = 1
            Observado = 2
            No_Encontrado = 3
        End Enum
    End Class
    Public Class Interno
        Public Enum EnmEstado As Short
            Activo = 1
            Inactivo = 0
        End Enum
        Public Enum EnmEstadoEspecifico As Short
            Ninguna = 0
            Recluido = 1
            Fuga = 2
            Fallecido = 3
            En_Conduccion = 4
            Con_Libertad = 5
            Con_Traslado = 6
            Pendiente_de_Egreso = 7
        End Enum
        Public Enum EnumSituacionJuridica
            Ninguno = 0
            Procesado = 1
            Sentenciado = 2
            Procesado_Sentenciado = 3
        End Enum
        Public Enum enmTipoInterno As Short
            Ninguno = 0
            Interno = 1
            MedioLibre = 2
            InternoExterno = 3
        End Enum
    End Class
    Public Class EstadoEspecificoInterno 'debe eliminarse
        Public Enum EnmEstadoEspecifico As Short
            Ninguna = 0
            Recluido = 1
            Fuga = 2
            Fallecido = 3
            En_Conduccion = 4
            Con_Libertad = 5
            En_Traslado = 6
            Pendiente_de_Egreso = 7
        End Enum
    End Class
    Public Class NombreAsociado
        Public Enum EnmTipo As Short
            Principal = 1
            Asociado = 0
        End Enum
    End Class
    Public Class Licencia
        Public Enum enmTipoLicencia As Short  'relacionado con la tabla penal campo n_pen_tip_lic (penal tipo licencia)
            Ninguno = 0
            PenalProvincia = 1 'penal provincia 
            RegionProvincia = 2 'region provincia
            Sede = 3 'sede central
            PenalLimaMetropolitana = 4
            RegionLimaMetropolitana = 5
            Carceleta = 6
            PenalLimaProvincia = 7
            MedioLibreLimaMetropolitana = 8
        End Enum
        Public Enum enmTipoDocumento
            Documentos = 1
            Movimientos = 2
        End Enum
    End Class
    Public Class Clasificacion
        Public Enum enmTipoFicha
            Ninguno = -1
            Legal = 1
            Social = 2
            Psicologica = 3
            Final = 4
        End Enum
        Public Enum enmEstadoRegistroFicha
            Ninguno = -1 'ninguno
            Pendiente = 0 'ficha aun en proceso, puede ser modificado la ficha pero solo por el usuario indicado
            Finalizado = 1 'el usuario ha finalizado ya no es posible modificar la ficha a menos que sea desblodueado.
            Bloqueado = 2 'en este estado ya no es posible modificar la ficha.
        End Enum
        Public Enum enmEstadoTramiteDoc
            Pendiente = 1
            Derivado = 2
            Anulado = 3
        End Enum
        Public Enum enmAmbitoClasificacion
            Carceleta = 1
            RegimenCerradoOrdinario = 2
            RegimenCerradoEspecial = 3
        End Enum
        Public Enum enmGrupoClasificacion
            ClasificacionEtapa = 5
            ClasificacionPenales = 6
        End Enum
    End Class
    Public Class Odontograma
        Public Enum enmRugaPalatina
            No_Registra = -1
            Tipo_I = 1
            Tipo_II = 2
            Tipo_III = 3
            Tipo_IV = 4
        End Enum
        Public Enum enmArcoDentario
            No_Registra = -1
            Ovoide = 1
            Triangular = 2
            Cuadrado = 3
        End Enum
    End Class
    Public Enum enmEstadoDocumentoAnulado
        Normal = 1
        Anulado_parcial = 2
        Anulado_total = 3
    End Enum
    Public Enum enmEstadoAnulado
        Normal = 0
        Anulado_parcial = 1
        Anulado_total = 2
    End Enum

    Public Class AntecedenteJudicial
        Public Enum enmEstadoSolicitud As Integer
            Pendiente = 0
            Terminado = 1
            Impreso = 2
            Anulado = 3
        End Enum
        Public Enum enmAmbitoJurisdiccionAutJud
            Ninguno = -1
            Lima = 1
            Callao = 2
            Lima_Y_Callao = 3 'artificio temporal
            Penal = 4 'ambito penal provincia
        End Enum
        Public Enum enmTipoCertificadoAntecedenteJudicial
            Ninguno = -1
            CertificadoAntecedenteNegativo = 1
            CertificadoAntecedenteNoRegistraPPMD = 2 'no registra procesos pendientes con mandato de detencion
            CertificadoAntecedenteSiRegistraPPMD = 3 'si registra procesos pendientes con mandato de detencion
        End Enum
    End Class

    Public Enum TipoGlosa
        ConsolidadoDocClasificacion = 1
        AntecedenteJudicialNoRPPMD = 2 'no registra procesos pendiente con mandato de detencion
        AntecedenteJudicialNegativo = 3
        AntecedenteJudicialRPPMD = 4


    End Enum

    Public Class ParteDiario
        Public Enum enmEstadoPD As Short
            Todos = -1
            Inicial = 1
            Pendiente = 2
            Terminado = 3
        End Enum

        Public Enum enmTipoMovimiento As Short
            Ninguno = -1
            Ingresos = 1
            Egresos = 2
            Diligencias = 3
            ClasifReubi = 4
            PobInfantil = 5
            Alimentacion = 6
        End Enum

        Public Enum enmSubTipoMovimiento As Short
            Ninguno = -1
            Nuevo = 1
            TrasladoIngreso = 2
            Libertad = 3
            Fuga = 4
            Fallecimiento = 5
            TrasladoEgreso = 6
            ArrestoDomiciliario = 7
            Hospitalizacion = 8
            DiligCentroSalud = 9
            DiligJudiciales = 10
            DiligTopicos = 11
            Clasificacion = 12
            Reubicacion = 13
            IngresoPobInfantil = 14
            EgresoPobInfantil = 15
            AlimentacionPerSeryAnexo = 16
            AlimentacionPope = 17
            AlimentacionPopeInfantil = 18
            HospitalizacionRecibido = 19
        End Enum

        Public Enum enmTipoCustodio As Short
            Ninguno = -1
            INPE = 1
            PNP = 2
        End Enum

        Public Enum enmDiligenciaTipoUbicacion As Short
            Ninguno = -1
            Interno = 1
            Externo = 2
        End Enum
        Public Enum enmDiligenciaMovimientoTipo As Short
            Ninguno = -1
            Entrada = 1
            Salida = 2
        End Enum

        Public Enum enmOcurrenciaRelevancia
            Ninguno = -1
            Baja = 1
            Media = 2
            Alta = 3
        End Enum
        Public Enum enmAuditoriaTabla
            Ninguno = -1
            seg_pd_mov_documento = 1
            seg_pd_mov_internomovimiento = 2
            seg_pd_mov_internoarrestodomiciliario = 3
            seg_pd_mov_internodiligencia = 4
            seg_pd_mov_internoclasifreubicacion = 5
            seg_pd_det_poblacioninfantil = 6
            seg_pd_mov_alimentacion = 7
            seg_pd_mov_ocurrencia = 8
            seg_pd_mov_personalasistencia = 9
            seg_pd_mov_personalservicio = 10
        End Enum
    End Class

    Public Enum enmTipoDelito
        Delitos = 1
        Faltas = 3
    End Enum

    Public Class ConstanciaReclusion
        Public Enum enmEstado As Short
            ninguno = 0
            pendiente = 1
            atendido = 2
            anulado = 3
        End Enum
        Public Enum enmTipoDocumento As Short
            solicitud = 1
            memorando = 2
            oficio = 3
        End Enum
        Public Enum enmReporte As Short
            ninguno = 0
            constanciaReclusion = 1
            expedicionConstancias = 2
            expedicionConstanciaGrupo = 3
        End Enum
        'Public Enum enmValidacionDocumentoPLM As Short
        '    ninguno = 0
        '    ingreso = 1
        '    traslado = 2
        'End Enum
    End Class
    Public Class Modulo
        Public Enum enmModulo As Short  'relacionado con el Modulo del sistema
            Ninguno = 0
            RegistroProvincia = 1 'penal provincia 
            RegistroProvinciaV2 = 31 'region provincia
            'Sede = 3 'sede central
            'PenalLimaMetropolitana = 4
            'RegionLimaMetropolitana = 5
            'Carceleta = 6
            'PenalLimaProvincia = 7
        End Enum
    End Class
End Class
