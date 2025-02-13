Imports System.Data.SqlClient

Namespace Registro.ConstanciaReclusion
    Public Class Tramite
        Private objEnt As Entity.Registro.ConstanciaReclusion.Tramite = Nothing
        Private entExpedicion As Entity.Registro.ConstanciaReclusion.Expedicion = Nothing
        Private objLista As List(Of Entity.Registro.ConstanciaReclusion.Tramite) = Nothing

#Region "Listar"
        Public Function listarGrillaTramite(objEntFiltro As Entity.Registro.ConstanciaReclusion.Tramite) As List(Of Entity.Registro.ConstanciaReclusion.Tramite)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.ConstanciaReclusion.Tramite.Listar(sqlCon, "lst", "lst_grilla_tramite", objEntFiltro)
            Try
                objLista = New List(Of Entity.Registro.ConstanciaReclusion.Tramite)
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
                        With objEnt
                            .nro = sqlDr("nro").ToString
                            .codigo = sqlDr("pk_cons_rec_tra_id").ToString
                            .idInterno = sqlDr("fk_int_id").ToString
                            .idIngresoInpe = sqlDr("fk_int_inp_id").ToString
                            .idIngreso = sqlDr("fk_int_ing_id").ToString
                            .idRegion = sqlDr("_regid").ToString
                            .RegionNombre = sqlDr("region").ToString
                            .idPenal = sqlDr("_penid").ToString
                            .penalNombre = sqlDr("penal").ToString
                            .penalTipoLicencia = sqlDr("pen_tip_lic").ToString
                            .numeroTramite = sqlDr("c_nro_tram").ToString
                            .estado = sqlDr("n_est").ToString
                            .numeroCR = sqlDr("c_nro_cr").ToString
                            .tramiteFechaRegistro = sqlDr("tra_fec_reg").ToString
                            'fecha de constancia de reclusion
                            If IsDBNull(sqlDr("f_fec_cr")) = False Then
                                .fechaCR = sqlDr("f_fec_cr").ToString
                                .fechaCRString = .fechaCR.ToShortDateString
                            End If

                            .fechaRecepcionEP = sqlDr("f_fec_rec_ep").ToString
                            .fechaRecepcionRP = sqlDr("f_fec_rec_rp").ToString
                            .documentoReferenciaTipo = sqlDr("n_tip_doc_ref").ToString
                            .serieRecibo = sqlDr("c_nro_ser").ToString
                            .documentoReferenciaNumero = sqlDr("c_nro_doc_ref").ToString
                            .tipoTramite = sqlDr("n_tip_tram").ToString
                            .idTipoSolicitante = sqlDr("fk_tip_sol_id").ToString
                            .tipoSolicitanteNombre = sqlDr("tip_aut_jud_nom").ToString
                            .distritoJudicialNombre = sqlDr("dis_jud_nom").ToString
                            .autoridadJudicialNombre = sqlDr("sal_jud_nom").ToString
                            .internoCodigoRD = sqlDr("c_res_int_cod_rp").ToString
                            .internoPrimerApellido = sqlDr("c_res_int_pri_ape").ToString
                            .internoSegundoApellido = sqlDr("c_res_int_seg_ape").ToString
                            .internoNombre = sqlDr("c_res_int_nom").ToString
                            .contadorCR = sqlDr("cant_impr")
                        End With
                        objLista.Add(objEnt)
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
            Return objLista
        End Function
        Public Function listarGrillaInterno(objEntFiltro As Entity.Registro.ConstanciaReclusion.Tramite) As List(Of Entity.Registro.ConstanciaReclusion.Tramite)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.ConstanciaReclusion.Tramite.Listar(sqlCon, "lst", "lst_grilla_interno", objEntFiltro)
            Try
                objLista = New List(Of Entity.Registro.ConstanciaReclusion.Tramite)
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
                        With objEnt
                            .nro = sqlDr("nro").ToString
                            .codigo = sqlDr("pk_cons_rec_tra_id").ToString
                            .idInterno = sqlDr("fk_int_id").ToString
                            .idIngresoInpe = sqlDr("fk_int_inp_id").ToString
                            .idIngreso = sqlDr("fk_int_ing_id").ToString
                            .idRegion = sqlDr("_regid").ToString
                            .RegionNombre = sqlDr("region").ToString
                            .idPenal = sqlDr("_penid").ToString
                            .penalNombre = sqlDr("penal").ToString
                            .numeroTramite = sqlDr("c_nro_tram").ToString
                            .tramiteFechaRegistro = sqlDr("tra_fec_reg").ToString
                            .estado = sqlDr("n_est").ToString
                            .numeroCR = sqlDr("c_nro_cr").ToString

                            'fecha de constancia de reclusion
                            If IsDBNull(sqlDr("f_fec_cr")) = False Then
                                .fechaCR = sqlDr("f_fec_cr").ToString
                                .fechaCRString = .fechaCR.ToShortDateString
                            End If

                            .fechaRecepcionEP = sqlDr("f_fec_rec_ep").ToString
                            .fechaRecepcionRP = sqlDr("f_fec_rec_rp").ToString
                            .documentoReferenciaTipo = sqlDr("n_tip_doc_ref").ToString
                            .serieRecibo = sqlDr("c_nro_ser").ToString
                            .documentoReferenciaNumero = sqlDr("c_nro_doc_ref").ToString
                            .tipoTramite = sqlDr("n_tip_tram").ToString
                            .idTipoSolicitante = sqlDr("fk_tip_sol_id").ToString
                            .tipoSolicitanteNombre = sqlDr("tip_aut_jud_nom").ToString
                            .internoCodigoRD = sqlDr("c_res_int_cod_rp").ToString
                            .internoPrimerApellido = sqlDr("c_res_int_pri_ape").ToString
                            .internoSegundoApellido = sqlDr("c_res_int_seg_ape").ToString
                            .internoNombre = sqlDr("c_res_int_nom").ToString

                            .contadorCR = sqlDr("cant_impr")
                        End With
                        objLista.Add(objEnt)
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
            Return objLista
        End Function

        Public Function listar(ByVal codigo As Integer) As Entity.Registro.ConstanciaReclusion.Tramite

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.ConstanciaReclusion.Tramite.Listar(sqlCon, "lst", "lst_mant",
                                        New Entity.Registro.ConstanciaReclusion.Tramite With {.codigo = codigo})
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
                        With objEnt
                            .codigo = sqlDr("pk_cons_rec_tra_id").ToString
                            .idInterno = sqlDr("fk_int_id").ToString
                            .internoCodigoRD = sqlDr("int_cod_rp").ToString
                            .internoApellidosyNombres = sqlDr("int_ape_nom").ToString
                            .idIngresoInpe = sqlDr("fk_int_inp_id").ToString
                            .idIngreso = sqlDr("fk_int_ing_id").ToString
                            .idRegion = sqlDr("_regid").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .idPenal = sqlDr("_penid").ToString
                            .penalNombre = sqlDr("pen_nom").ToString
                            .penalTipoLicencia = sqlDr("pen_tip_lic").ToString
                            .numeroTramite = sqlDr("c_nro_tram").ToString
                            .estado = sqlDr("n_est").ToString
                            .numeroCR = sqlDr("c_nro_cr").ToString
                            .usuarioCR = sqlDr("usu_ape_nom_cr").ToString
                            'fecha de constancia de reclusion
                            If IsDBNull(sqlDr("f_fec_cr")) = False Then
                                .fechaCR = sqlDr("f_fec_cr").ToString
                                .fechaCRString = .fechaCR.ToShortDateString
                            End If
                            .fechaRecepcionEP = sqlDr("f_fec_rec_ep").ToString
                            .fechaRecepcionRP = sqlDr("f_fec_rec_rp").ToString
                            .documentoReferenciaTipo = sqlDr("n_tip_doc_ref").ToString
                            .serieRecibo = sqlDr("c_nro_ser").ToString
                            .documentoReferenciaNumero = sqlDr("c_nro_doc_ref").ToString
                            .documentoReferenciaFecha = sqlDr("f_fec_doc_ref").ToString
                            .tipoTramite = sqlDr("n_tip_tram").ToString
                            .idTipoSolicitante = sqlDr("fk_tip_sol_id").ToString
                            .idDistritoJudicial = sqlDr("fk_dis_jud_id").ToString
                            .idAutoridadJudicial = sqlDr("fk_aut_jud_id").ToString
                            .observacion = sqlDr("c_obs").ToString
                            .observacionAnulacion = sqlDr("c_obs_anu").ToString
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

        Public Function listarResultado(ByVal codigo As Integer) As Entity.Registro.ConstanciaReclusion.Tramite

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.ConstanciaReclusion.Tramite.Listar(sqlCon, "lst", "lst_listar_resultado_cr",
                                        New Entity.Registro.ConstanciaReclusion.Tramite With {.codigo = codigo})
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
                        With objEnt
                            .codigo = sqlDr("pk_cons_rec_tra_id").ToString
                            .internoIdFotoPerfilCentro = sqlDr("fk_arc_dig_id_int_fot_pc").ToString
                            .internoFotoBase64 = sqlDr("c_res_int_fot_bas_64").ToString
                            .internoFechaIngSistPen = sqlDr("f_res_int_fec_isp").ToString
                            .internoFechaIngreso = sqlDr("f_res_int_fec_ing").ToString
                            .idDistritoJudicialResp = sqlDr("exp_dis_jud_id").ToString
                            .idSalaJudicialResp = sqlDr("exp_sal_juz_id").ToString
                            .salaJuzgadoNombre = sqlDr("exp_sal_juz_nom").ToString

                            If .salaJuzgadoNombre.Length < 1 Then
                                .salaJuzgadoNombre = "NO REGISTRA"
                            End If
                            .idExpediente = sqlDr("fk_int_exp_id").ToString
                            .expedienteNumeroResp = sqlDr("exp_num").ToString
                            If .expedienteNumeroResp.Length < 1 Then
                                .expedienteNumeroResp = "NO REGISTRA"
                            End If

                            .expedienteSecretarioResp = sqlDr("exp_sec_nom").ToString
                            If .expedienteSecretarioResp.Length < 1 Then
                                .expedienteSecretarioResp = "NO REGISTRA"
                            End If

                            .expedienteDelitoResp = sqlDr("del_nom").ToString
                            If .expedienteDelitoResp.Length < 1 Then
                                .expedienteDelitoResp = "NO REGISTRA"
                            End If

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

        Public Function listarInternoIngreso(ByVal idInterno As Integer) As Entity.Registro.ConstanciaReclusion.Tramite

            objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
            objEnt = listarDatosInterno(idInterno)

            Return objEnt
        End Function


        Private Function listarDatosIngresoExpediente(idInterno As Integer, idIngresoInpe As Integer, idIngreso As Integer) As Entity.Registro.ConstanciaReclusion.Expedicion

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.ConstanciaReclusion.Tramite.Listar(sqlCon, "lst", "lst_obtener_datos_ingreso_expediente",
                New Entity.Registro.ConstanciaReclusion.Tramite With {.idInterno = idInterno, .idIngresoInpe = idIngresoInpe, .idIngreso = idIngreso})

            entExpedicion = New Entity.Registro.ConstanciaReclusion.Expedicion

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With entExpedicion
                            .internoFechaIngSistPen = sqlDr("fec_ing_sis_pen").ToString
                            .internoFechaIngreso = sqlDr("fec_ing_ep").ToString
                            .internoCodigoRD = sqlDr("int_cod_rp").ToString
                            .internoPrimerApellido = sqlDr("int_pri_ape").ToString
                            .internoSegundoApellido = sqlDr("int_seg_ape").ToString
                            .internoNombre = sqlDr("int_nom").ToString
                            .internoNombreAsociado = sqlDr("int_nom_aso_conc").ToString

                            .internoIdFotoPerfilCentro = sqlDr("int_fot_per_ctr").ToString
                            .idExpediente = sqlDr("int_exp_id").ToString
                            .idDistritoJudicialResp = sqlDr("dis_jud_id").ToString
                            .idSalaJudicialResp = sqlDr("sal_jus_id").ToString
                            .idSalaJudicialResp = sqlDr("sal_jus_id").ToString
                            .expedienteNumeroResp = sqlDr("num_exp").ToString
                            .expedienteSitJur = sqlDr("exp_sit_jur").ToString
                            .expedienteSecretarioResp = sqlDr("int_exp_sec").ToString
                            .expedienteDelitoResp = sqlDr("int_del_nom_conc").ToString
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
            Return entExpedicion
        End Function

        Public Function listarDatosInterno(ByVal idInterno As Integer) As Entity.Registro.ConstanciaReclusion.Tramite

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.ConstanciaReclusion.Tramite.Listar(sqlCon, "lst", "lst_datos_basicos_interno",
                                        New Entity.Registro.ConstanciaReclusion.Tramite With {.idInterno = idInterno})
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
                        With objEnt
                            .idInterno = sqlDr("int_id").ToString
                            .idIngresoInpe = sqlDr("fk_ing_inp_id").ToString
                            .idIngreso = sqlDr("fk_int_ing_id").ToString
                            .internoEstado = sqlDr("int_est_id").ToString
                            .internoFechaIngreso = sqlDr("int_fec_mov").ToString
                            .internoMovimientoFechaEgreso = sqlDr("int_fec_mov_egre").ToString
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

#End Region

#Region "validar"
        Private Function validar(ent As Entity.Registro.ConstanciaReclusion.Tramite, ByRef mensajeOut As String) As Boolean
            Dim value As Boolean = False


            'validar distrito judicial
            If ent.idDistritoJudicial > 0 Then
                Dim objBssDistritoJudicial As New Bussines.Mantenimiento.AutoridadJudicial
                If objBssDistritoJudicial.validarEstadoDistiroJudicial(ent.idDistritoJudicial, mensajeOut) = False Then
                    Return value
                End If
            End If

            If ent.documentoReferenciaTipo = Type.Enumeracion.ConstanciaReclusion.enmTipoDocumento.solicitud Then
                If validarNumeroDocReferencia(ent, mensajeOut) = False Then
                    Return value
                End If
            End If

            If validarFechaMovimientoEgreso(ent, mensajeOut) = False Then
                Return value
            End If

            Return True
        End Function
        Private Function validarNumeroDocReferencia(ent As Entity.Registro.ConstanciaReclusion.Tramite, ByRef mensajeOut As String) As Boolean

            Dim value As Boolean = False
            Dim cantidadReg As Integer = -1

            cantidadReg = Data.Registro.ConstanciaReclusion.Tramite.ListarOutput("lst", "lst_val_numero_documento_referencia", ent)

            If cantidadReg > 0 Then
                mensajeOut = "El número de referencia y/o recibo ya fué registrado en la base de datos."
                Return value
            End If

            Return True

        End Function
        Public Function validarFechaMovimientoEgreso(ent As Entity.Registro.ConstanciaReclusion.Tramite, ByRef mensajeOut As String) As Boolean

            Dim value As Boolean = False
            Dim cantidadReg As Integer = -1
            Dim idIngresoInpe As Integer = -1
            Dim idIngreso As Integer = -1
            Dim movimientoFechaIngreso As Date
            Dim movimientoFechaEgreso As Date
            Dim validarMovimientoEgreso As Boolean = False

            objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
            objEnt = listarDatosInterno(ent.idInterno)

            movimientoFechaIngreso = objEnt.internoFechaIngreso

            If objEnt.internoMovimientoFechaEgreso.Trim.Length > 5 Then
                movimientoFechaEgreso = objEnt.internoMovimientoFechaEgreso
            End If

            'antes de validar si tienes un egreso, validar la fecha ultimo de ingreso vs la fecha de recepion ep.
            If movimientoFechaEgreso > movimientoFechaIngreso Then
                validarMovimientoEgreso = True
            End If

            If validarMovimientoEgreso = True Then

                If ent.idIngresoInpe > 0 Then
                    idIngresoInpe = objEnt.idIngresoInpe
                    idIngreso = -1
                Else
                    If ent.idIngreso > 0 Then
                        idIngresoInpe = -1
                        idIngreso = objEnt.idIngreso
                    End If
                End If

                'asignar con los ingresos ultimos del interno
                ent.idIngresoInpe = idIngresoInpe
                ent.idIngreso = idIngreso
                ent.fechaRecepcionEP = ent.fechaRecepcionEP.AddDays(1).AddSeconds(-1)

                ' Validar si el interno tiene un movimiento de libertdad, fuga, fallecimiento o traslado menor a la fecha de recepcion del EP
                cantidadReg = Data.Registro.ConstanciaReclusion.Tramite.ListarOutput("lst", "lst_val_fecha_mov_egreso", ent)
                If cantidadReg > 0 Then
                    mensajeOut = "No se puede registrar el tramite, porque la fecha de recepción de la solicitud es posterior al egreso del interno del E.P."
                    Return value
                End If

            End If

            Return True
        End Function

        Public Function validarInternoUltimoIngreso(ByVal idInterno As Integer, idIngresoInpeSelect As Integer, idIngresoSelect As Integer,
                                               ByRef mensajeOut As String) As Boolean

            Dim value As Boolean = False

            objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
            objEnt = listarDatosInterno(idInterno)

            If idIngresoInpeSelect > 0 And objEnt.idIngresoInpe <> idIngresoInpeSelect Then
                mensajeOut = "Solo se puede realizar el registro de constancias de reclusión, en el ultimo ingreso del interno."
                Return value
            End If

            If idIngresoSelect > 0 And objEnt.idIngreso <> idIngresoSelect Then
                mensajeOut = "Solo se puede realizar el registro de constancias de reclusión, en el ultimo ingreso del interno."
                Return value
            End If

            'validar que tenga fecha de movimiento de ingreso (pestaña movimientos)
            If objEnt.internoFechaIngreso.Length < 3 Then
                mensajeOut = "No se puede realizar el registro de la solicitud, debido a que el Interno(a) no cuenta con el registro de información válida del movimiento de ingreso. Verifique por favor!."
                Return value
            End If

            value = True
            Return value

        End Function
        Public Function fnCantidadExpedientes(idInterno As Integer, idIngresoInpe As Integer) As Integer

            Dim cantidad As Short = 0

            objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
            With objEnt
                .idInterno = idInterno
                .idIngresoInpe = idIngresoInpe
            End With

            cantidad = Data.Registro.ConstanciaReclusion.Tramite.ListarOutput("lst", "lst_val_expediente_cantidad", objEnt)

            Return cantidad

        End Function


        Public Function validarExpedienteDmpSmp(idInterno As Integer, idIngresoInpe As Integer, idIngreso As Integer,
                                                 ByRef mensajeOut As String) As Boolean

            Dim value As Boolean = False
            Dim cantidadReg As Integer = -1

            cantidadReg = Data.Registro.ConstanciaReclusion.Tramite.ListarOutput("lst", "lst_val_expediente_dmp_smp",
                            New Entity.Registro.ConstanciaReclusion.Tramite With {.idInterno = idInterno,
                                                                                .idIngresoInpe = idIngresoInpe,
                                                                                .idIngreso = idIngreso})

            If cantidadReg < 1 Then
                mensajeOut = "No se puede realizar el registro de la solicitud. Debe seleccionar de la lista de procesos:" + Chr(13) +
                    ".- El delito de mayor pena (DMP) para procesados." + Chr(13) +
                    ".- El delito de la sentencia de mayor Pena (SMP) para sentenciados." + Chr(13) +
                    "Verifique por favor!."
                Return value
            End If

            Return True
        End Function
#End Region
#Region "Funciones"
        'Private Function properCase(cadena As String, delimitador As String)

        '    Dim value As String = ""
        '    Dim listaNombres() As String

        '    listaNombres = cadena.Split(delimitador)

        '    For Each fila As String In listaNombres

        '        fila = Legolas.Components.Cadena.ProperCase(fila)

        '        If fila = "o" Or fila.Length < 1 Then
        '            Continue For
        '        End If

        '        If value.Trim.Length < 1 Then
        '            value = fila
        '        Else
        '            value = value + " o " + fila
        '        End If

        '    Next

        '    Return value
        'End Function
        Public Function getPathFoto(idTramite As Integer) As String

            Dim value As String = ""

            objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
            objEnt = listarResultado(idTramite)

            value = objEnt.internoFotoBase64

            Return value

        End Function
        Private Function fnConvertirFotoInterno(idArchivoDigital As Integer) As String

            Dim value As String = ""

            If idArchivoDigital < 1 Then
                Return value
            End If

            Dim entArchivoDigital As New Entity.Globall.ArchivoDigital
            Dim bssArchivoDigital As New Bussines.Globall.ArchivoDigital
            Dim fotoByte As Byte() = Nothing

            entArchivoDigital = bssArchivoDigital.Listar_ArchivoDigital_v2(idArchivoDigital)

            Dim pathServer As String = entArchivoDigital.RutaServidor
            Dim nombreArchivo As String = entArchivoDigital.NombreFisico

            Dim objWS As New APPWebService.ws_foto.PopeLocal
            objWS.Url = APPWebService.PathURL.WSPopeLocal

            Try
                If pathServer.Length < 1 Then
                    fotoByte = objWS.LeerImageJpg(nombreArchivo, 1) 'interno
                Else

                    If nombreArchivo.Contains("jpg") = True Then
                        nombreArchivo = nombreArchivo
                    Else
                        nombreArchivo = nombreArchivo & ".jpg"
                    End If

                    fotoByte = objWS.LeerArchivoByte(APPWebService.ws_foto.enmTipoImagen.Interno, nombreArchivo, pathServer)
                End If
            Catch ex As Exception

            End Try

            If fotoByte IsNot Nothing Then
                value = Convert.ToBase64String(fotoByte, 0, fotoByte.Length)
            End If

            Return value

        End Function
#End Region
#Region "Grabar"

        Public Function grabar(EntCons As Entity.Registro.ConstanciaReclusion.Tramite, expedienteManual As Boolean,
                               ByRef mensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If validar(EntCons, mensajeOut) = False Then
                value = -1
                Return value
            End If

            If EntCons.codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            value = Data.Registro.ConstanciaReclusion.Tramite.Grabar(strAccion, strOpcion, EntCons)

            If value > 0 Then
                value = grabarDatosExpedicion(value, EntCons.idInterno, EntCons.idIngresoInpe, EntCons.idIngreso,
                                              expedienteManual, EntCons, EntCons, mensajeOut)
            End If

            Return value

        End Function

        Public Function grabarExpedirConstancia(codigo As Integer, idInterno As Integer, idIngresoInpe As Integer, idIngreso As Integer,
                                                idRegion As Short, idPenal As Short, ByRef mensajeOut As String) As Integer

            'If validarExpedienteDmpSmp(idInterno, idIngresoInpe, idIngreso, mensajeOut) = False Then
            '    Return False
            'End If

            Dim value As Integer = -1
            'entExpedicion = New Entity.Registro.ConstanciaReclusion.Expedicion
            'entExpedicion = listarDatosIngresoExpediente(idInterno, idIngresoInpe, idIngreso)

            ''validar si el interno tien fecha de ingreso al ep.
            'If entExpedicion.internoFechaIngreso.Length < 5 Then
            '    mensajeOut = "Fecha último ingreso al E.P, debe registrar el último ingreso al E.P. en las pestaña [Movimientos del interno]"
            '    Return value
            'End If

            objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
            With objEnt
                .codigo = codigo
                .idInterno = idInterno
                .idIngresoInpe = idIngresoInpe
                .idIngreso = idIngreso
                .idRegion = idRegion
                .idPenal = idPenal
                ''datos de respuesta 
                '.internoFechaIngSistPen = entExpedicion.internoFechaIngSistPen
                '.internoFechaIngreso = entExpedicion.internoFechaIngreso
                '.internoCodigoRD = entExpedicion.internoCodigoRD
                '.internoPrimerApellido = entExpedicion.internoPrimerApellido
                '.internoSegundoApellido = entExpedicion.internoSegundoApellido
                '.internoNombre = entExpedicion.internoNombre
                '.internoNombreAsociado = entExpedicion.internoNombreAsociado
                '.internoIdFotoPerfilCentro = entExpedicion.internoIdFotoPerfilCentro
                '.internoFotoBase64 = fnConvertirFotoInterno(.internoIdFotoPerfilCentro)
                '.idExpediente = entExpedicion.idExpediente
                '.idDistritoJudicialResp = entExpedicion.idDistritoJudicialResp
                '.idSalaJudicialResp = entExpedicion.idSalaJudicialResp
                '.expedienteNumeroResp = entExpedicion.expedienteNumeroResp
                '.expedienteSitJur = entExpedicion.expedienteSitJur
                '.expedienteSecretarioResp = entExpedicion.expedienteSecretarioResp
                '.expedienteDelitoResp = entExpedicion.expedienteDelitoResp
            End With

            value = Data.Registro.ConstanciaReclusion.Tramite.Grabar("upd", "upd_emitir_constancia", objEnt)

            Return value

        End Function

        'Public Function xxxxgrabarExpedirConstanciaManual(codigo As Integer, idInterno As Integer, idIngresoInpe As Integer, idIngreso As Integer,
        '                                        idRegion As Short, idPenal As Short,
        '                                              entExpedicion As Entity.Registro.ConstanciaReclusion.Expedicion,
        '                                              ByRef mensajeOut As String) As Integer

        '    Dim value As Integer = -1
        '    Dim entExpedicionTempo As Entity.Registro.ConstanciaReclusion.Expedicion
        '    entExpedicionTempo = listarDatosIngresoExpediente(idInterno, idIngresoInpe, idIngreso)

        '    'validar si el interno tien fecha de ingreso al ep.
        '    If entExpedicionTempo.internoFechaIngreso.Length < 5 Then
        '        mensajeOut = "Fecha último ingreso al E.P, debe registrar el último ingreso al E.P. en las pestaña [Movimientos del interno]"
        '        Return value
        '    End If

        '    objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
        '    With objEnt
        '        .codigo = codigo
        '        .idInterno = idInterno
        '        .idIngresoInpe = idIngresoInpe
        '        .idIngreso = idIngreso
        '        .idRegion = idRegion
        '        .idPenal = idPenal
        '        'datos de respuesta 
        '        .internoFechaIngSistPen = entExpedicionTempo.internoFechaIngSistPen
        '        .internoFechaIngreso = entExpedicionTempo.internoFechaIngreso
        '        .internoCodigoRD = entExpedicionTempo.internoCodigoRD
        '        .internoPrimerApellido = entExpedicionTempo.internoPrimerApellido
        '        .internoSegundoApellido = entExpedicionTempo.internoSegundoApellido
        '        .internoNombre = entExpedicionTempo.internoNombre
        '        .internoNombreAsociado = entExpedicionTempo.internoNombreAsociado
        '        .internoIdFotoPerfilCentro = entExpedicionTempo.internoIdFotoPerfilCentro
        '        .internoFotoBase64 = fnConvertirFotoInterno(.internoIdFotoPerfilCentro)
        '        .idExpediente = -1
        '        .idDistritoJudicialResp = entExpedicion.idDistritoJudicialResp
        '        .idSalaJudicialResp = entExpedicion.idSalaJudicialResp
        '        .expedienteNumeroResp = entExpedicion.expedienteNumeroResp
        '        .expedienteSitJur = -1
        '        .expedienteSecretarioResp = entExpedicion.expedienteSecretarioResp
        '        .expedienteDelitoResp = entExpedicion.expedienteDelitoResp
        '    End With

        '    value = Data.Registro.ConstanciaReclusion.Tramite.Grabar("upd", "upd_emitir_constancia", objEnt)

        '    Return value

        'End Function

        Private Function grabarDatosExpedicion(codigo As Integer, idInterno As Integer, idIngresoInpe As Integer, idIngreso As Integer,
                                               expedienteManual As Boolean, entExpedienteManual As Entity.Registro.ConstanciaReclusion.Expedicion,
                                                entExpedienteTram As Entity.Registro.ConstanciaReclusion.Tramite, ByRef mensajeOut As String) As Integer

            Dim value As Integer = -1
            entExpedicion = New Entity.Registro.ConstanciaReclusion.Expedicion
            If entExpedienteTram.idRegion = 3 Then 'Region Lima
                Select Case entExpedienteTram.idPenal
                    Case -1, 33, 38, 39, 40, 41, 42, 43, 50, 52, 57, 131, 208, 212
                        idIngreso = -1
                End Select
            End If

            entExpedicion = listarDatosIngresoExpediente(idInterno, idIngresoInpe, idIngreso)

            'validar si el interno tien fecha de ingreso al ep.
            If entExpedicion.internoFechaIngreso.Length < 5 Then
                mensajeOut = "Fecha último ingreso al E.P, debe registrar el último ingreso al E.P. en las pestaña [Movimientos del interno]"
                Return value
            End If

            objEnt = New Entity.Registro.ConstanciaReclusion.Tramite
            With objEnt
                .codigo = codigo
                .idInterno = idInterno
                .idIngresoInpe = idIngresoInpe
                .idIngreso = idIngreso
                'datos de respuesta 
                .internoFechaIngSistPen = entExpedicion.internoFechaIngSistPen
                .internoFechaIngreso = entExpedicion.internoFechaIngreso
                .internoCodigoRD = entExpedicion.internoCodigoRD
                .internoPrimerApellido = entExpedicion.internoPrimerApellido
                .internoSegundoApellido = entExpedicion.internoSegundoApellido
                .internoNombre = entExpedicion.internoNombre
                .internoNombreAsociado = entExpedicion.internoNombreAsociado.Trim
                .internoIdFotoPerfilCentro = entExpedicion.internoIdFotoPerfilCentro
                .internoFotoBase64 = fnConvertirFotoInterno(.internoIdFotoPerfilCentro)

                If expedienteManual = True Then
                    .idExpediente = -1
                    .idDistritoJudicialResp = entExpedienteManual.idDistritoJudicialResp
                    .idSalaJudicialResp = entExpedienteManual.idSalaJudicialResp
                    .expedienteNumeroResp = entExpedienteManual.expedienteNumeroResp
                    .expedienteSitJur = -1
                    .expedienteSecretarioResp = entExpedienteManual.expedienteSecretarioResp
                    .expedienteDelitoResp = entExpedienteManual.expedienteDelitoResp
                Else
                    .idExpediente = entExpedicion.idExpediente
                    .idDistritoJudicialResp = entExpedicion.idDistritoJudicialResp
                    .idSalaJudicialResp = entExpedicion.idSalaJudicialResp
                    .expedienteNumeroResp = entExpedicion.expedienteNumeroResp
                    .expedienteSitJur = entExpedicion.expedienteSitJur
                    .expedienteSecretarioResp = entExpedicion.expedienteSecretarioResp
                    .expedienteDelitoResp = entExpedicion.expedienteDelitoResp
                End If

            End With

            value = Data.Registro.ConstanciaReclusion.Tramite.Grabar("upd", "upd_grabar_vista_previa", objEnt)

            Return value

        End Function


        Public Function grabarAnular(ByVal codigo As Integer, obsAnulacion As String) As Integer

            Dim value As Integer = -1

            value = Data.Registro.ConstanciaReclusion.Tramite.Grabar("upd", "upd_anular_registro",
                                                                            New Entity.Registro.ConstanciaReclusion.Tramite With {.codigo = codigo,
                                                                            .observacionAnulacion = obsAnulacion})
            Return value

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal codigo As Integer) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Registro.ConstanciaReclusion.Tramite.Eliminar(strAccion, strOpcion, codigo, Legolas.Configuration.Usuario.Codigo)
            Return Value
        End Function
#End Region
    End Class
End Namespace

