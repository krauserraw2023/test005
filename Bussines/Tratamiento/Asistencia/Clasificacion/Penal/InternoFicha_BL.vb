Imports System.Data.SqlClient
Imports Data.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class InternoFicha_BL
        Private objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE = Nothing
        Private objEntCol As List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE) = Nothing

#Region "Listar"

        Public Function ListarGrillaEtapa(objEntFiltro As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE) As List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE)

            Dim objBssInternoPabellon As New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoPabellon_BL
            Dim objEntFiltroInternoPabellon As New Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoPabellon_BE
            Dim objEntListaInternoPabellon As New List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoPabellon_BE)
            Dim objListaArray As New ArrayList

            With objEntFiltroInternoPabellon
                .IDInterno = objEntFiltro.IDInterno
                .IDIngreso = objEntFiltro.IDInternoIngreso
                .IDIngresoInpe = objEntFiltro.IDInternoIngresoInpe
                .IDRegion = objEntFiltro.IDRegion
                .IDPenal = objEntFiltro.IDPenal
                .Estado = 2 'finalizado
            End With

            objEntListaInternoPabellon = objBssInternoPabellon.ListarGrilla(objEntFiltroInternoPabellon)

            If Not objEntListaInternoPabellon Is Nothing Then
                If objEntListaInternoPabellon.Count > 0 Then

                    'obtener todas las fichas de etapa en el estado finalizado
                    For Each objFila As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoPabellon_BE In objEntListaInternoPabellon
                        If objFila.IDFichaEtapa > 0 Then
                            objListaArray.Add(objFila.IDFichaEtapa)
                        End If
                    Next
                End If
            End If

            Dim value As New List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE)

            'si hay fichas de etapas en la bd
            If objListaArray.Count > 0 Then
                objEntCol = New List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE)
                objEntCol = ListarGrilla(objEntFiltro)

                For Each objFilaPadre As Integer In objListaArray

                    For Each objFilaHijo As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE In objEntCol

                        If objFilaPadre = objFilaHijo.Codigo Then
                            value.Add(objFilaHijo)
                        End If

                        If objFilaPadre = objFilaHijo.CodigoPadre Then
                            value.Add(objFilaHijo)
                        End If

                    Next
                Next

            End If

            Return value

        End Function

        Public Function ListarGrilla(objEntFiltro As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE) As List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_DA.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objEntCol = New List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE)
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE
                        With objEnt
                            .Codigo = sqlDr("pk_int_pen_fic_id").ToString
                            .CodigoPadre = sqlDr("fk_int_pen_fic_id").ToString
                            .IDInterno = sqlDr("fk_int_id").ToString
                            .IDInternoIngreso = sqlDr("fk_int_ing_id").ToString
                            .IDInternoIngresoInpe = sqlDr("fk_ing_inp_id").ToString
                            .IDFicha = sqlDr("fk_fic_id").ToString
                            .IDFichaTipo = sqlDr("pk_tip_fic_id").ToString
                            .FichaNombre = sqlDr("fic_nom").ToString '                            
                            .FichaTipoNumOrden = sqlDr("n_num_ord").ToString
                            .FichaGrupo = sqlDr("n_grp_sec").ToString
                            .NumeroClasificacion = sqlDr("n_num_cla").ToString
                            .FechaClasificacion = sqlDr("n_fec_cla").ToString
                            .InternoIDSituacionJuridica = sqlDr("n_sit_jur_id").ToString
                            .Puntaje = sqlDr("n_pun").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .Estado = sqlDr("n_est").ToString
                            'datos del interno
                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString
                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoNombres = sqlDr("int_nom").ToString
                            .InternoIngresoNro = sqlDr("int_ing_nro").ToString
                        End With

                        If objEntFiltro.FichaGrupoLista.Length > 1 Then
                            If objEntFiltro.FichaGrupoLista.Contains(Me.objEnt.FichaGrupo) = True Then
                                objEntCol.Add(objEnt)
                            End If
                        Else
                            objEntCol.Add(objEnt)
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

        Public Function Listar(ByVal Codigo As Integer) As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE

            Dim entFich As New Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE
            entFich.Codigo = Codigo

            objEntCol = Listar(entFich)
            If objEntCol Is Nothing Then Return Nothing
            If objEntCol.Count = 0 Then Return Nothing

            Return objEntCol.Item(0)

        End Function

        Public Function Listar(objEntFiltro As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE) As List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_DA.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            Try
                objEntCol = New List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE)
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE
                        With objEnt
                            .Codigo = sqlDr("pk_int_pen_fic_id").ToString
                            .CodigoPadre = sqlDr("fk_int_pen_fic_id").ToString
                            .IDInterno = sqlDr("fk_int_id").ToString
                            .IDInternoIngreso = sqlDr("fk_int_ing_id").ToString
                            .IDInternoIngresoInpe = sqlDr("fk_ing_inp_id").ToString
                            .IDFicha = sqlDr("fk_fic_id").ToString
                            .IDFichaTipo = sqlDr("fk_tip_fic_id").ToString
                            .FichaNombre = sqlDr("c_fic_nom").ToString
                            .NumeroClasificacion = sqlDr("n_num_cla").ToString
                            .FechaClasificacion = sqlDr("n_fec_cla").ToString
                            .FechaInicioRegimen = sqlDr("n_fech_ini_regimen").ToString
                            .FechaInicioEtapa = sqlDr("n_fech_ini_etapa").ToString
                            .InternoIDSituacionJuridica = sqlDr("n_sit_jur_id").ToString
                            .Puntaje = sqlDr("n_pun").ToString
                            .InternoIDRegimen = sqlDr("n_reg_id").ToString
                            .InternoIDEtapa = sqlDr("n_etp_id").ToString
                            .Estado = sqlDr("n_est").ToString
                            .MotivoCambio = sqlDr("c_mot_cam_res").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PerteneceOrgCriminal = sqlDr("c_pert_org_crim").ToString
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
#Region "Funciones"
        Public Function fnObtenerIDPadre(intCodigo As Integer) As Integer

            Dim value As Integer = -1

            Dim objEntFiltro As New Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE
            With objEntFiltro
                .Codigo = intCodigo
            End With

            Try
                value = ListarGrilla(objEntFiltro).Item(0).CodigoPadre
            Catch ex As Exception

            End Try

            Return value

        End Function
        Public Function fnObtenerEstado(intCodigo As Integer) As Short

            Dim value As Integer = -1

            Dim objEntFiltro As New Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE
            With objEntFiltro
                .Codigo = intCodigo
            End With

            Try
                value = ListarGrilla(objEntFiltro).Item(0).Estado
            Catch ex As Exception

            End Try

            Return value

        End Function
#End Region
#Region "Grabar"
        Public Function GrabarCodigoPadre(intIDInterno As Integer, intIDIngreso As Integer, intIngresoInpe As Integer, intNumeroCla As Short, intGrupo As Short, intIDFichaFinal As Integer,
                                                          ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1

            Dim objEntFiltro As New Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE
            objEntCol = New List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE)

            With objEntFiltro
                .IDInterno = intIDInterno
                .IDInternoIngreso = intIDIngreso
                .IDInternoIngresoInpe = intIngresoInpe
                .NumeroClasificacion = intNumeroCla
                .FichaGrupo = intGrupo
            End With
            objEntCol = Listar(objEntFiltro)

            For Each objFila As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE In objEntCol

                If objFila.Codigo <> intIDFichaFinal Then
                    objFila.CodigoPadre = intIDFichaFinal
                    value = Data.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_DA.Grabar("upd", "upd_codigo_padre", objFila)
                End If

            Next

            Return value

        End Function
        Public Function Grabar(objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE, ByRef strMensajeOut As String) As Integer
            Dim value As Integer = -1
            Dim strOpcion As String = ""
            Dim strAccion As String = ""

            If objEnt.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            value = InternoFicha_DA.Grabar(strAccion, strOpcion, objEnt)
            '---------- generar copia de expedientes,delitos, agraviados pertenecientes al ingreso actual ---------------------------

            If objEnt.IDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                Dim lstExt As Entity.Registro.ExpedienteCol
                Dim expEnt As New Entity.Registro.Expediente
                expEnt.IngresoID = objEnt.IDInternoIngreso
                expEnt.InternoID = objEnt.IDInterno
                If objEnt.Codigo < 0 Then
                    'pendientehnrb xxxxxxxxxxxxxxx 11/01/2024
                    lstExt = (New Bussines.Registro.Expediente).Listar_v2(expEnt)
                    'For Each exp As Entity.Registro.Expediente In lstExt
                    '    If exp.CreaDocJudicialId = -1 Then Continue For

                    '    Dim reg As New Entity.Registro.DocumentoJudicial
                    '    reg.Codigo = exp.CreaDocJudicialId
                    '    reg = (New Bussines.Registro.DocumentoJudicial).Listar_v2(reg)
                    '    'pendientehnrb xxxxxxxxxxxxxxx 11/01/2024 analizar DetencionCarceleta se debe o no incluir para provincia
                    '    If exp.ExpedienteVisible = 0 Or reg.DocumentoTipo <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionCarceleta Then Continue For
                    '    Dim claExp As New Entity.Clasificacion.InternoClasificacion.Expediente
                    '    With claExp
                    '        .AutoridadJudicialID = exp.AutoridadJudicialID
                    '        .AutoridadOtro = exp.AutoridadOtro
                    '        .AutoridadOtroCargo = exp.AutoridadOtroCargo
                    '        .FichaFinalId = value
                    '        .CreaDocJudicialId = exp.CreaDocJudicialId
                    '        .DistritoJudicialID = exp.DistritoJudicialID
                    '        .DocumentoJudicialID = exp.DocumentoJudicialID
                    '        .DocumentoJudicialNum = exp.DocumentoJudicialNum
                    '        .DocumentoTipoID = exp.DocumentoTipoID
                    '        .Estado = exp.Estado
                    '        .ExpedienteFecha = exp.ExpedienteFecha
                    '        .ExpedienteFechaDocRecepcion = exp.ExpedienteFechaDocRecepcion
                    '        .ExpedienteJuez = exp.ExpedienteJuez
                    '        .ExpedienteNumero = exp.ExpedienteNumero
                    '        .ExpedienteSecretario = exp.ExpedienteSecretario
                    '        .Flagrancia = exp.Flagrancia
                    '        .int_sen_pad = exp.int_sen_pad
                    '        .InternoID = objEnt.IDInterno
                    '        .JuzgadoID = exp.JuzgadoID
                    '        .Observacion = exp.Observacion
                    '        .SalaJudicialID = exp.SalaJudicialID
                    '        .SalaJudicialNombre = exp.SalaJudicialNombre
                    '        .Principal = exp.Principal
                    '        .SentenciaPrincipal = exp.SentenciaPrincipal
                    '        .SituacionJuridicaID = exp.SituacionJuridicaID
                    '        .TipoAutoridadJudicialID = exp.TipoAutoridadJudicialID
                    '        .IngresoInpeId = objEnt.IDInternoIngresoInpe
                    '        .IngresoID = objEnt.IDInternoIngreso
                    '        ._PenalId = objEnt.IDPenal
                    '        ._RegioId = objEnt.IDRegion
                    '    End With
                    '    Dim idClaExp As Integer = -1
                    '    idClaExp = (New Bussines.Clasificacion.InternoClasificacion.Expediente).Grabar(claExp)

                    '    Dim lstDelCol As Entity.Registro.DelitoCol
                    '    Dim entDel As New Entity.Registro.Delito
                    '    entDel.ExpedienteID = exp.Codigo
                    '    entDel.InternoID = objEnt.IDInterno
                    '    lstDelCol = (New Bussines.Registro.Delito).Listar2_LM(entDel)
                    '    For Each d As Entity.Registro.Delito In lstDelCol
                    '        Dim del As New Entity.Clasificacion.InternoClasificacion.Delito
                    '        With del
                    '            .FichaFinalId = value
                    '            .ExpedienteID = idClaExp
                    '            .IngresoID = objEnt.IDInternoIngreso
                    '            .IngresoInpeId = objEnt.IDInternoIngresoInpe
                    '            .InternoID = objEnt.IDInterno
                    '            .DelitoGenerico = d.DelitoGenerico
                    '            .DelitoEspecifico = d.DelitoEspecifico
                    '            .DelitoEspecificoEstado = d.DelitoEspecificoEstado
                    '            .Observacion = d.Observacion
                    '            .DelitoMayorPena = d.DelitoMayorPena
                    '            .DelitoSentenciaMayorPena = d.DelitoSentenciaMayorPena
                    '            .Estado = d.Estado
                    '            .TipoSentenciaId = d.TipoSentenciaId
                    '            .CreaDocJudicialId = d.CreaDocJudicialId
                    '            .DelitoTitulo = d.DelitoTitulo
                    '            .DelitoTipoID = d.DelitoTipoID
                    '            .ExpedienteItem = d.ExpedienteItem
                    '            .DelitoAuxiliar = d.DelitoAuxiliar
                    '            .DocJudID = d.DocJudID
                    '            .Auxiliar = d.Auxiliar
                    '            .RegionID = objEnt.IDRegion
                    '            .PenalID = objEnt.IDPenal
                    '        End With
                    '        Dim idClaDel As Integer = -1
                    '        idClaDel = (New Bussines.Clasificacion.InternoClasificacion.Delito).Grabar_v2(del)

                    '        Dim lstAgravCol As Entity.Registro.AgraviadoCol
                    '        Dim entAgrav As New Entity.Registro.Agraviado
                    '        entAgrav.DelitoID = d.Codigo
                    '        entAgrav.ExpedienteID = exp.Codigo
                    '        entAgrav.InternoID = objEnt.IDInterno
                    '        lstAgravCol = (New Bussines.Registro.InternoAgraviado).Listar(entAgrav)
                    '        For Each a As Entity.Registro.Agraviado In lstAgravCol
                    '            Dim agra As New Entity.Clasificacion.InternoClasificacion.Agraviado
                    '            With agra
                    '                .FichaFinalId = value
                    '                .ExpedienteID = idClaExp
                    '                .DelitoID = idClaDel
                    '                .InternoID = objEnt.IDInterno
                    '                .IngresoID = objEnt.IDInternoIngreso
                    '                .IngresoInpeId = objEnt.IDInternoIngresoInpe
                    '                .AgraviadoNombre = a.AgraviadoNombre
                    '                .Observacion = a.Observacion
                    '                .Estado = a.Estado
                    '                .TipoSentenciaId = a.TipoSentenciaId
                    '                .TipoSentenciaHistoricoId = a.TipoSentenciaHistoricoId
                    '                .TipoResolucionId = a.TipoResolucionId
                    '                .RegionID = objEnt.IDRegion
                    '                .PenalID = objEnt.IDPenal
                    '            End With
                    '            Dim idClaAgrav As Integer = -1
                    '            idClaAgrav = (New Bussines.Clasificacion.InternoClasificacion.InternoAgraviado).Grabar(agra)
                    '        Next
                    '    Next
                    'Next
                End If
            End If

            Return value
        End Function


        Public Function Grabar_LM(objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = If(objEnt.Codigo = -1, "ins", "upd")
            Dim strOpcion As String = If(objEnt.Codigo = -1, "ins_mant", "upd_mant")

            value = InternoFicha_DA.Grabar(strAccion, strOpcion, objEnt)
            '---------- generar copia de expedientes,delitos, agraviados pertenecientes al ingreso actual ---------------------------
            If objEnt.IDFichaTipo = Type.Enumeracion.Clasificacion.enmTipoFicha.Final Then
                Dim expEnt As New Entity.Registro.Expediente With {
                    .IngresoInpeId = objEnt.IDInternoIngresoInpe,
                    .InternoID = objEnt.IDInterno
                    }
                If objEnt.Codigo < 0 Then
                    Dim lstExt As Entity.Registro.ExpedienteCol = (New Bussines.Registro.Expediente).Listar_ExpParaClaFicacion_LM(expEnt)
                    For Each exp As Entity.Registro.Expediente In lstExt

                        If exp.CreaDocJudicialId = -1 Then Continue For
                        If exp.ExpedienteVisible = 0 Then Continue For
                        Dim claExp As New Entity.Clasificacion.InternoClasificacion.Expediente With {
                            .AutoridadJudicialID = exp.AutoridadJudicialID,
                            .AutoridadOtro = exp.AutoridadOtro,
                            .AutoridadOtroCargo = exp.AutoridadOtroCargo,
                            .FichaFinalId = value,
                            .CreaDocJudicialId = exp.CreaDocJudicialId,
                            .DistritoJudicialID = exp.DistritoJudicialID,
                            .DocumentoJudicialID = exp.DocumentoJudicialID,
                            .DocumentoJudicialNum = exp.DocumentoJudicialNum,
                            .DocumentoTipoID = exp.DocumentoTipoID,
                            .Estado = exp.Estado,
                            .ExpedienteFecha = exp.ExpedienteFecha,
                            .ExpedienteFechaDocRecepcion = exp.ExpedienteFechaDocRecepcion,
                            .ExpedienteJuez = exp.ExpedienteJuez,
                            .ExpedienteNumero = exp.ExpedienteNumero,
                            .ExpedienteSecretario = exp.ExpedienteSecretario,
                            .Flagrancia = exp.Flagrancia,
                            .int_sen_pad = exp.int_sen_pad,
                            .InternoID = objEnt.IDInterno,
                            .JuzgadoID = exp.JuzgadoID,
                            .Observacion = exp.Observacion,
                            .SalaJudicialID = exp.SalaJudicialID,
                            .SalaJudicialNombre = exp.SalaJudicialNombre,
                            .Principal = exp.Principal,
                            .SentenciaPrincipal = exp.SentenciaPrincipal,
                            .SituacionJuridicaID = exp.SituacionJuridicaID,
                            .TipoAutoridadJudicialID = exp.TipoAutoridadJudicialID,
                            .IngresoInpeId = objEnt.IDInternoIngresoInpe,
                            ._PenalId = objEnt.IDPenal,
                            ._RegioId = objEnt.IDRegion
                        }

                        Dim idClaExp As Integer = (New Bussines.Clasificacion.InternoClasificacion.Expediente_BL).Grabar(claExp)

                        Dim entDel As New Entity.Registro.Delito With {
                            .ExpedienteID = exp.Codigo,
                            .InternoID = objEnt.IDInterno
                        }
                        Dim lstDelCol As Entity.Registro.DelitoCol = (New Bussines.Registro.Delito).Listar2_LM(entDel)
                        For Each d As Entity.Registro.Delito In lstDelCol
                            Dim del As New Entity.Clasificacion.InternoClasificacion.Delito With {
                                .FichaFinalId = value,
                                .ExpedienteID = idClaExp,
                                .IngresoInpeId = objEnt.IDInternoIngresoInpe,
                                .InternoID = objEnt.IDInterno,
                                .DelitoGenerico = d.DelitoGenerico,
                                .DelitoEspecifico = d.DelitoEspecifico,
                                .DelitoEspecificoEstado = d.DelitoEspecificoEstado,
                                .Observacion = d.Observacion,
                                .DelitoMayorPena = d.DelitoMayorPena,
                                .DelitoSentenciaMayorPena = d.DelitoSentenciaMayorPena,
                                .Estado = d.Estado,
                                .TipoSentenciaId = d.TipoSentenciaId,
                                .CreaDocJudicialId = d.CreaDocJudicialId,
                                .DelitoTitulo = d.DelitoTitulo,
                                .DelitoTipoID = d.DelitoTipoID,
                                .ExpedienteItem = d.ExpedienteItem,
                                .DelitoAuxiliar = d.DelitoAuxiliar,
                                .DocJudID = d.DocJudID,
                                .Auxiliar = d.Auxiliar,
                                .RegionID = objEnt.IDRegion,
                                .PenalID = objEnt.IDPenal
                            }

                            Dim idClaDel As Integer = (New Bussines.Clasificacion.InternoClasificacion.InternoDelito_BL).Grabar_v2(del)

                            Dim entAgrav As New Entity.Registro.Agraviado With {
                                        .DelitoID = d.Codigo,
                                        .ExpedienteID = exp.Codigo,
                                        .InternoID = objEnt.IDInterno
                                        }
                            Dim lstAgrav As Entity.Registro.AgraviadoCol = (New Bussines.Registro.InternoAgraviado).Listar(entAgrav)
                            For Each a As Entity.Registro.Agraviado In lstAgrav
                                Dim agra As New Entity.Clasificacion.InternoClasificacion.Agraviado With {
                                    .FichaFinalId = value,
                                    .ExpedienteID = idClaExp,
                                    .DelitoID = idClaDel,
                                    .InternoID = objEnt.IDInterno,
                                    .IngresoInpeId = objEnt.IDInternoIngresoInpe,
                                    .AgraviadoNombre = a.AgraviadoNombre,
                                    .Observacion = a.Observacion,
                                    .Estado = a.Estado,
                                    .TipoSentenciaId = a.TipoSentenciaId,
                                    .TipoSentenciaHistoricoId = a.TipoSentenciaHistoricoId,
                                    .TipoResolucionId = a.TipoResolucionId,
                                    .RegionID = objEnt.IDRegion,
                                    .PenalID = objEnt.IDPenal
                                }
                                Dim idClaAgrav As Integer = (New Bussines.Clasificacion.InternoClasificacion.InternoAgraviado_BL).Grabar(agra)

                            Next
                        Next
                    Next
                End If
            End If
            Return value
        End Function
        Public Function GrabarEstado(intIDFicha As Integer, intEstado As Short, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_estado"

            objEnt = New Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE
            With objEnt
                .Codigo = intIDFicha
                .Estado = intEstado
            End With

            value = Data.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_DA.Grabar(strAccion, strOpcion, objEnt)

            Return value
        End Function
#End Region
    End Class

End Namespace
