Option Explicit On
Imports System.Data.SqlClient
Imports Type.Enumeracion.TipoDocJudicial
Imports System.Linq
Imports Bussines.Registro.Documento

Namespace Registro.Reporte
    Public Class AntecedenteJudicial


        Public Function AntecedenteJudicialPositivo(CabeceraRptId As Integer) As Entity.Reporte.Registro.AntecedenteJudicial.AntecedenteJudicial

            Dim objEnt As Entity.Reporte.Registro.AntecedenteJudicial.AntecedenteJudicial
            Dim t_rpt_cont As New DataTable

            t_rpt_cont = Data.Reporte.Registro.Listar("lst", "lst_rpt_contenido_hist", CabeceraRptId)

            objEnt = New Entity.Reporte.Registro.AntecedenteJudicial.AntecedenteJudicial
            With objEnt
                .GlosaDescripcion = LeerValorCadena("GLOSA_CERT_AJ", t_rpt_cont)
            End With

            Return objEnt

        End Function

        Public Function HistorialAntecedente(intIDRegion As Short, intIDPenal As Short, IdInterno As Integer, blnMostrarDocAnulados As Boolean) As Entity.Registro.Antecedente.DetalleAntecedenteCol

            'JMR, 13.08.2020
            'jmr, 28/09/2020
            Dim list As New Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim dt As New DataTable

            Dim intMostrarDocAnu As Short = 0
            If blnMostrarDocAnulados = True Then
                intMostrarDocAnu = 1
            End If

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim dr As SqlDataReader = Data.Registro.Reporte.HistorialAntecedente.Listar(sqlCon, "lst", "lst_historial_antecedente_provincia", intIDRegion, intIDPenal, IdInterno,
                                                                                       intMostrarDocAnu)

            Try
                If dr.HasRows Then
                    dt.Load(dr)
                Else
                    Return list
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                dr.Dispose()
                dr.Close()
                dr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return generarAntecedente(dt, blnMostrarDocAnulados)

        End Function
        Public Function HistorialAntecedente_LM(IdInterno As Integer, blnMostrarAnulados As Boolean) As Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim list As New Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim dt As New DataTable
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim intMostrarDocAnulados As Short = 0
            If blnMostrarAnulados = True Then
                intMostrarDocAnulados = 1
            End If

            Dim dr As SqlDataReader = Data.Registro.Reporte.HistorialAntecedente.Listar(sqlCon, "lst", "lst_historial_antecedente_LM", -1, -1, IdInterno, intMostrarDocAnulados)

            Dim objEnt As Entity.Registro.Antecedente.DetalleAntecedente = Nothing

            Try
                If dr.HasRows Then
                    dt.Load(dr)
                Else
                    Return list
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                dr.Dispose()
                dr.Close()
                dr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return generarAntecedente(dt, blnMostrarAnulados)

        End Function

        Private Function LeerValorCadena(Clave As String, t As DataTable) As String
            For Each f As DataRow In t.Rows
                If f("c_clave") = Clave Then Return f("c_valor")
            Next
            Return ""
        End Function

        'Private Function LeerValorNumerico(Clave As String, t As DataTable) As Integer
        '    For Each f As DataRow In t.Rows
        '        If f("c_clave") = Clave Then Return f("n_valor")
        '    Next
        '    Return 0
        'End Function
#Region "Procesar_Antecedente"
        Private Function OrdenarOdcJudicial(list As Entity.Registro.Antecedente.DetalleAntecedenteCol) As Entity.Registro.Antecedente.DetalleAntecedenteCol

            Dim l2 As New Entity.Registro.Antecedente.DetalleAntecedenteCol
            For Each o As Entity.Registro.Antecedente.DetalleAntecedente In list
                Select Case o.TipoDocJudicialId
                    Case enumTipoDocumentoJudicial.Detencion
                        o.NumOrden = 1
                    Case enumTipoDocumentoJudicial.DetencionCarceleta = 35
                        o.NumOrden = 2
                    Case enumTipoDocumentoJudicial.Internamiento, enumTipoDocumentoJudicial.Ingreso
                        o.NumOrden = 3
                    Case enumTipoDocumentoJudicial.Rectificacion_Nombres
                        o.NumOrden = 4
                    Case enumTipoDocumentoJudicial.Anulacion_Nombres
                        o.NumOrden = 5
                    Case enumTipoDocumentoJudicial.Notas
                        o.NumOrden = 6
                    Case enumTipoDocumentoJudicial.Traslado
                        o.NumOrden = 7
                    Case enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                        o.NumOrden = 8
                    Case enumTipoDocumentoJudicial.Prolongacion_Detencion
                        o.NumOrden = 9
                    Case enumTipoDocumentoJudicial.Aclaratoria
                        o.NumOrden = 10
                    Case enumTipoDocumentoJudicial.Avocamiento
                        o.NumOrden = 11
                    Case enumTipoDocumentoJudicial.Conducciones
                        o.NumOrden = 12
                    Case enumTipoDocumentoJudicial.AcumulacionExpedientes
                        o.NumOrden = 14
                    Case enumTipoDocumentoJudicial.Sentencia
                        o.NumOrden = 15
                    Case enumTipoDocumentoJudicial.Nota_Sentencia
                        o.NumOrden = 16
                    Case enumTipoDocumentoJudicial.Sentencia_Aclaratoria
                        o.NumOrden = 17
                    Case enumTipoDocumentoJudicial.Refundicion_de_Sentencia
                        o.NumOrden = 18
                    Case enumTipoDocumentoJudicial.Integracion_Sentencia
                        o.NumOrden = 19
                    Case enumTipoDocumentoJudicial.Ejecutoria_Suprema
                        o.NumOrden = 20
                    Case enumTipoDocumentoJudicial.Ejecutoria_Superior
                        o.NumOrden = 21
                    Case enumTipoDocumentoJudicial.Sent_Sustitucion_Pena
                        o.NumOrden = 22
                    Case enumTipoDocumentoJudicial.Sent_Adecuacion_Pena
                        o.NumOrden = 23
                    Case enumTipoDocumentoJudicial.Sent_Conmutacion_Pena
                        o.NumOrden = 24
                    Case enumTipoDocumentoJudicial.ResolucionConsentida
                        o.NumOrden = 25
                    Case enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                        o.NumOrden = 26
                    Case enumTipoDocumentoJudicial.Resolucion
                        o.NumOrden = 27
                    Case enumTipoDocumentoJudicial.Resolucion_Superior
                        o.NumOrden = 28
                    Case enumTipoDocumentoJudicial.Sent_Pena_Limitativa
                        o.NumOrden = 29
                    Case enumTipoDocumentoJudicial.Revocatoria
                        o.NumOrden = 30
                    Case enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD
                        o.NumOrden = 31
                    Case enumTipoDocumentoJudicial.Anulacion_Antecedentes
                        o.NumOrden = 32
                    Case enumTipoDocumentoJudicial.Libertad
                        o.NumOrden = 33
                    Case enumTipoDocumentoJudicial.Revocatoria_de_Libertad
                        o.NumOrden = 34
                    Case enumTipoDocumentoJudicial.Notas_Egreso
                        o.NumOrden = 35
                    Case enumTipoDocumentoJudicial.Queda
                        o.NumOrden = 36
                    Case enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
                        o.NumOrden = 37
                End Select
            Next

            'Dim result = From d As Entity.Registro.Antecedente.DetalleAntecedente In list Order By d.IngresoNum, d.FechaRecepDocLong, d.NumOrden, d.FechaDocLong
            Dim result = From d As Entity.Registro.Antecedente.DetalleAntecedente In list Order By d.IngresoNum, d.FechaRecepDocLong, d.FechaCreaReg ' d.FechaDocLong
            For Each obj As Entity.Registro.Antecedente.DetalleAntecedente In result
                l2.Add(obj)
            Next
            'ordenar por fecha y puntaje
            Return l2
        End Function
        Public Function generarAntecedente(dt As DataTable, blnMostrarDocAnulados As Boolean) As Entity.Registro.Antecedente.DetalleAntecedenteCol

            Dim listaDocumentos As New Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim objEnt As Entity.Registro.Antecedente.DetalleAntecedente = Nothing

            Dim dtDocumentos As DataTable = dt.DefaultView.ToTable(True, "doc_jud_id", "fec_recep_doc", "res_tipoDocNom", "res_tip_resol_id", "sent_cad_perpet",
                                                                   "periodo_condena",
                                                      "res_pen_des_nom", "res_doc_jud_num", "res_doc_jud_num_aux", "doc_jud_obs", "fecha_sent", "res_sala_jud", "res_autoridad_jud",
                                                      "sent_tot_dias", "sent_tot_meses", "sent_tot_anio", "res_pen_orig_nom", "res_pen_ori_otr", "res_mov_mot_nom",
                                                      "prol_det_tip_und",
                                                      "fec_doc", "res_tip_aut_jud_id", "res_aut_otro_cargo", "doc_fec_mov", "prol_det_ini_fec",
                                                      "res_pen_des_otr",
                                                      "prol_det_fin_fec", "DocSubTipoNom", "res_tip_aut_jud", "res_nom_secre", "sent_consentida",
                                                      "fec_doc_lon", "int_ing_nro", "fec_ing_sis_pen",
                                                      "reg_ori_id", "pen_orig_id", "reg_des_id", "pen_des_id", "fec_crea_reg", "prol_det_cant",
                                                      "res_aut_otro_nom",
                                                      "doc_jud_est_id", "int_ing_id", "doc_subtip_id", "fk_ing_inp_id", "doc_anu", "fk_mot_ing_id", "mov_mot_id",
                                                      "cen_sal_men_nom", "est_eje_trs_id", "sen_fec_ins", "obs_queda", "flg_proc_pend",
                                                      "int_exp_id", "docjud_queda", "sent_fresol", "est_eje_obs", "mov_est_id", "est_eje_mov", "sent_vers")

            Dim blnNoMostrarDocumento As Boolean = True

            For Each fila As DataRow In dtDocumentos.Rows
                objEnt = New Entity.Registro.Antecedente.DetalleAntecedente

                objEnt.Codigo = fila.Item("doc_jud_id")

                If objEnt.Codigo = 2405731 Then
                    Console.WriteLine(objEnt.Codigo)
                End If

                objEnt.Fecha = fila.Item("fec_recep_doc")
                objEnt.TipoDocJudicialId = fila.Item("res_tip_resol_id")

                objEnt.Detalle = fila.Item("res_tipoDocNom").ToString.ToUpper & " " & vbCrLf & fila.Item("doc_anu").ToString.ToUpper

                objEnt.FechaRecepDocLong = fila.Item("fec_recep_doc")
                objEnt.IngresoNum = fila.Item("int_ing_nro")
                objEnt.FechaDocLong = fila.Item("fec_doc_lon")
                objEnt.FechaCreaReg = fila.Item("fec_crea_reg")

                Dim tipoDoc As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial
                Dim head As String = ""
                Dim headQ As String = ""
                Dim obs_doc As String = ""
                Dim obs_doc_queda As String = ""
                Dim fecSentStr As String = "" 'fecha de sentencia
                Dim condenas As String = ""
                Dim fecDocStr As String = ""
                Dim fecRecepDocStr As String = ""
                Dim fecProlIniStr As String = ""
                Dim fecProlFinStr As String = ""
                Dim fecMovStr As String = ""
                Dim fecInscripcion As String = ""
                Dim intDocumentoAnuladoEstado As Short = -1
                Dim intIDIngresoID As Integer = -1
                Dim intIDSubTipoDocumento As Integer = -1
                Dim DocJud As Integer = -1

                blnNoMostrarDocumento = True

                obs_doc = If(fila("doc_jud_obs").ToString.Trim.Length > 0, vbCrLf + "OBSERVACIONES: " & fila("doc_jud_obs").ToString.Trim.ToUpper, "")
                obs_doc_queda = If(fila("flg_proc_pend").ToString = "1", If(fila("obs_queda").ToString.Trim.Length > 0, fila("obs_queda").ToString.Trim.ToUpper, ""), "") 'vbCrLf
                tipoDoc = Integer.Parse(fila.Item("res_tip_resol_id").ToString)
                fecDocStr = If(fila("fec_doc") = "", "N/I", fila("fec_doc"))
                fecRecepDocStr = If(fila("fec_recep_doc") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(fila.Item("fec_recep_doc")))
                fecMovStr = If(fila("doc_fec_mov") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(fila.Item("doc_fec_mov")))
                fecInscripcion = If(fila("sen_fec_ins") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(fila.Item("sen_fec_ins")))
                fecProlIniStr = If(fila("prol_det_ini_fec") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(fila.Item("prol_det_ini_fec")))
                fecProlFinStr = If(fila("prol_det_fin_fec") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(fila.Item("prol_det_fin_fec")))
                fecSentStr = If(fila("fecha_sent") = 0, "", DateTime.FromFileTime(fila("fecha_sent")))
                intDocumentoAnuladoEstado = fila.Item("doc_jud_est_id")
                intIDIngresoID = fila.Item("int_ing_id")
                intIDSubTipoDocumento = fila.Item("doc_subtip_id")
                DocJud = fila.Item("doc_jud_id")

                Dim nombreSubTipoDocumento As String = fila("DocSubTipoNom").ToString

                Select Case tipoDoc
                    Case enumTipoDocumentoJudicial.Queda
                        head = "FECHA DOC.: " & fecDocStr &
                        ", ORDENA: " & fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud") & " CON DOC. N°: " & fila.Item("res_doc_jud_num") & ", SECRETARIO: " & fila("res_nom_secre")

                    Case enumTipoDocumentoJudicial.Revocatoria_de_Libertad
                        head = "FECHA DOC.: " & fecDocStr &
                        ", ORDENA: " & fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud") & " CON DOC. N°: " & fila.Item("res_doc_jud_num") & ", SECRETARIO: " & fila("res_nom_secre")

                    Case enumTipoDocumentoJudicial.Traslado
                        Dim penOri As String = ""
                        Dim penDest As String = ""
                        Dim ordena As String = ""
                        If fila("res_pen_orig_nom") = "" Or fila("res_pen_orig_nom") = "NO INDICA" Then
                            penOri = fila("res_pen_ori_otr")
                        Else
                            If fila("pen_orig_id") = 35 Then
                                penOri = " E.T.P. " & fila("res_pen_orig_nom")
                            Else
                                penOri = " E.P. " & fila("res_pen_orig_nom")
                            End If
                        End If

                        If fila("res_pen_des_nom") = "" Or fila("res_pen_des_nom") = "NO INDICA" Then
                            penDest = fila("res_pen_des_otr")
                        Else
                            If fila("pen_des_id") = 35 Then
                                penDest = " E.T.P " & fila("res_pen_des_nom")
                            Else
                                penDest = " E.P. " & fila("res_pen_des_nom")
                            End If
                        End If

                        ordena = fila.Item("res_tip_aut_jud")
                        If fila.Item("res_aut_otro_nom").ToString.Length > 0 Then
                            ordena = ordena & " - " & fila.Item("res_aut_otro_nom")
                        End If

                        head = "FECHA DOC.: " & fecDocStr & " FECHA MOV: " & fecMovStr &
                        ", ORDENA: " & ordena.ToUpper & ", CON RD N°: " & fila("res_doc_jud_num_aux") & ", DOC. N°: " & fila("res_doc_jud_num") & ", POR " & fila("res_mov_mot_nom") & " DE " & penOri & " A " & penDest

                    Case enumTipoDocumentoJudicial.Libertad

                        Dim autoridadNombre As String = ""
                        Dim idTipoProceso As Short = fila("fk_mot_ing_id")

                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                autoridadNombre = ""
                            Case 1
                                autoridadNombre = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                            Case Else
                                autoridadNombre = fila("res_aut_otro_cargo")
                        End Select

                        If fila("est_eje_trs_id") = 3 Then
                        Else
                            objEnt.Fecha = fila.Item("sen_fec_ins")
                        End If

                        head = "FECHA DOC.: " & fecDocStr & ", FECHA INS.: " & fecInscripcion &
                           ", AUT. JUDICIAL: " & autoridadNombre.ToUpper & ", CON DOC. N°: " & fila("res_doc_jud_num") & " DE FECHA " & fecDocStr &
                           ", SECRETARIO: " & fila("res_nom_secre")

                        condenas = fila("sent_tot_anio")
                        If condenas.Trim > 0 Then
                            condenas = fnSentenciaCondenadoDeclarado(idTipoProceso) & fila("sent_tot_anio") & " AÑO(S) " & fila("sent_tot_meses") &
                                " MES(ES) " & fila("sent_tot_dias") & " DIAS " & fila("periodo_condena") & "."
                            head = head & ", " & condenas
                        Else
                            head = head & ". "
                        End If

                        Dim drDetalleQ As DataRow()
                        drDetalleQ = dt.Select("tip_act=99 and docjud_queda=" & DocJud)

                        Dim descripQ As String = ""
                        Dim strTipLibQ As String = ""
                        Dim objExpeSumatoriaQ As New ArrayList
                        Dim it As Integer = 0
                        headQ = vbCrLf & vbCrLf & "QUEDA POR TENER PENDIENTE LOS SIGUIENTES PROCESOS:" & vbCrLf

                        For Each objFilaQ As DataRow In drDetalleQ
                            it = it + 1
                            fecDocStr = If(objFilaQ.Item("fec_doc") = "", "N/I", objFilaQ.Item("fec_doc"))

                            headQ = headQ & "(" & it & ")" & " N° EXP: " & objFilaQ.Item("exp_int_ing_exp_num") & " | " & objFilaQ.Item("exp_sala_jud") & " | " & objFilaQ.Item("exp_autoridad_jud") & vbCrLf
                            'it = it + 1
                        Next

                        If it = 0 Then
                            If obs_doc_queda = "" Then
                                headQ = ""
                            End If
                        End If

                    Case enumTipoDocumentoJudicial.Prolongacion_Detencion '10
                        Dim strTip As String = ""

                        If fila.Item("prol_det_cant") > 0 Then
                            If fila.Item("prol_det_tip_und") = "A" Then strTip = ", Tiempo prolongación: " & fila.Item("prol_det_cant") & " Año(s)"
                            If fila.Item("prol_det_tip_und") = "M" Then strTip = ", Tiempo prolongación: " & fila.Item("prol_det_cant") & " Mes(es)"
                            If fila.Item("prol_det_tip_und") = "D" Then strTip = ", Tiempo prolongación: " & fila.Item("prol_det_cant") & " Dia(s)"
                        End If

                        head = "FECHA DOC.: " & fecDocStr & ", F. INICIO: " & fecProlIniStr & " F. FINAL: " & fecProlFinStr & strTip &
                        ", ORDENA: " & fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud") & " SECRETARIO: " & fila("res_nom_secre") & ", CON DOC. N°: " & fila.Item("res_doc_jud_num")

                    Case enumTipoDocumentoJudicial.Detencion, enumTipoDocumentoJudicial.DetencionReferenciado  '12,66,31


                        head = "DOC. N°: " & fila.Item("res_doc_jud_num") & ", FECHA DOC.: " & fecDocStr &
                       ", AUT. JUDICIAL: " & fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud") & ", SECRETARIO: " & fila("res_nom_secre") & "."

                    Case enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                        head = "FECHA DOC.: " & fecDocStr &
                        ", ORDENA " & fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud") & " CON DOC. N°: " & fila.Item("res_doc_jud_num")

                    Case enumTipoDocumentoJudicial.Avocamiento
                        Dim aut As String = ""
                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                            Case Else
                                aut = fila("res_aut_otro_cargo")
                        End Select
                        Dim sentConsen As String = ""

                        head = "FECHA DOC.: " & fecDocStr &
                            ", ORDENA: " & aut.ToUpper & " CON OFICIO N°: " & fila.Item("res_doc_jud_num") & sentConsen & ", SECRETARIO: " & fila("res_nom_secre")

                    Case enumTipoDocumentoJudicial.Aclaratoria
                        Dim aut As String = ""
                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                            Case Else
                                aut = fila("res_aut_otro_cargo")
                        End Select

                        objEnt.Detalle = "ACLARATORIA" & " " & vbCrLf & fila.Item("doc_anu").ToString.ToUpper

                        Dim subTipNom As String = ""
                        If fila.Item("DocSubTipoNom").ToString.ToUpper <> "ACLARATORIA DE EXPEDIENTE" Then
                            subTipNom = fila.Item("DocSubTipoNom").ToString.ToUpper & ", "
                        End If
                        head = subTipNom & "FECHA DOC.: " & fecDocStr & "ORDENA: " & aut & " CON DOC. N° " & fila.Item("res_doc_jud_num")

                    Case enumTipoDocumentoJudicial.Ingreso

                        'jmr.27.01.2022, la reunion de fecha 27.01.2022 con DRP y ORL, se quedo que el ingreso, siempre debe mostrar 
                        objEnt.Fecha = fila.Item("fec_ing_sis_pen") 'Se debe mostrar fecha de documento, solicitud ORL coordinacion Gerardo V. 15/06/2018

                        Dim idTipoProceso As Short = fila("fk_mot_ing_id")

                        Select Case intIDSubTipoDocumento
                            Case 28 'ingreso x traslado
                                objEnt.Detalle = "INGRESO POR TRASLADO"

                                Dim strProcedente As String = ""

                                If fila("pen_orig_id") = 35 Then 'carceleta
                                    strProcedente = "PROCEDENTE DEL E.T.P.: "
                                Else
                                    strProcedente = "PROCEDENTE DEL E.P. : "
                                End If

                                head = "Motivo de traslado: " & fila.Item("DocSubTipoNom").ToString.ToUpper & ", N° R.D.: " &
                                    fila.Item("res_doc_jud_num") & ", F. R.D.: " & fecDocStr & ". " & strProcedente & fila.Item("res_pen_orig_nom") & "."

                            Case Else

                                Dim documentoSubTipo As String = fila.Item("DocSubTipoNom").ToString.ToUpper

                                If documentoSubTipo.Length > 1 Then
                                    documentoSubTipo = fila.Item("DocSubTipoNom").ToString.ToUpper & ", "
                                Else
                                    documentoSubTipo = ""
                                End If

                                head = documentoSubTipo & "FECHA DOC.: " & fecDocStr & " INGRESA CON OFICIO N° " &
                                    fila.Item("res_doc_jud_num") & ", CON DESTINO AL E.P. " & fila.Item("res_pen_des_nom") & "."
                        End Select

                        condenas = fila("sent_tot_anio")
                        If condenas.Trim > 0 Then
                            condenas = fnSentenciaCondenadoDeclarado(idTipoProceso) & fila("sent_tot_anio") & " AÑO(S) " & fila("sent_tot_meses") & " MES(ES) " & fila("sent_tot_dias") & " DIAS " & fila("periodo_condena") & " "
                            head = head & " " & condenas
                        End If

                        Select Case intDocumentoAnuladoEstado
                            Case 3 'anulado total 

                                If blnMostrarDocAnulados = False Then
                                    head = "POR PROCESO ANULADO"

                                    'evaluar si el documento de ingreso se debe mostrar, cuando todos sus documentos judiciales se encuentren anulado 
                                    Dim dtDocumentoJud As DataTable
                                    Dim drDocumentosxIngreso As DataRow()

                                    dtDocumentoJud = dtDocumentos 'Movimientos por Ingreso
                                    drDocumentosxIngreso = dtDocumentoJud.Select("int_ing_id=" & intIDIngresoID)

                                    If drDocumentosxIngreso.Count < 2 Then
                                        blnNoMostrarDocumento = False
                                    End If

                                End If

                        End Select

                    Case enumTipoDocumentoJudicial.Notas  ' 15 
                        Dim ordena As String = ""

                        objEnt.Detalle = fila.Item("DocSubTipoNom").ToString.ToUpper & " " & vbCrLf & fila.Item("doc_anu").ToString.ToUpper

                        ordena = fila.Item("res_tip_aut_jud")
                        If fila("res_tip_aut_jud_id") = 1 Then
                            ordena = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                        Else
                            ordena = ordena & " - " & fila.Item("res_aut_otro_nom")
                        End If

                        head = "FECHA DOC.: " & fecDocStr &
                        ", COMUNICA: " & ordena & " CON DOC. N°: " & fila.Item("res_doc_jud_num")

                        condenas = fila("sent_tot_anio")
                        If condenas.Trim > 0 Then
                            condenas = "CONDENADO A " & fila("sent_tot_anio") & " AÑO(S) " & fila("sent_tot_meses") & " MES(ES) " & fila("sent_tot_dias") & " DIAS " & fila("periodo_condena") & " "
                            head = head & " " & condenas
                        End If

                    Case enumTipoDocumentoJudicial.Sumatoria_de_Sentencia, enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                         enumTipoDocumentoJudicial.AcumulacionExpedientes,
                        enumTipoDocumentoJudicial.Integracion_Sentencia

                        Dim autoridadNombre As String = ""
                        Dim fecSent As String = ""
                        Dim sentConsen As String = ""

                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                autoridadNombre = ""
                            Case 1
                                autoridadNombre = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                            Case Else
                                autoridadNombre = fila("res_aut_otro_cargo")
                        End Select

                        If fila("sent_consentida") = 1 Or fila("sent_consentida") = True Then
                            sentConsen = " CONSENTIDA"
                        End If

                        If fila.Item("fecha_sent") = 0 Then
                            fecSent = ", F. SENTENCIA: "
                        Else
                            fecSent = ", F. SENTENCIA: " & Legolas.Components.FechaHora.FechaDate(fila.Item("fecha_sent"))
                        End If

                        head = "FECHA DOC.: " & fecDocStr &
                            ", AUT. JUDICIAL: " & autoridadNombre.ToUpper & " CON DOC. N°: " & fila.Item("res_doc_jud_num") & sentConsen & ", SECRETARIO: " & fila("res_nom_secre") &
                           fecSent

                        If fila("sent_cad_perpet").ToString = True Or fila("sent_cad_perpet").ToString = 1 Then
                            condenas = "CONDENADO A CADENA PERPETUA"
                        Else
                            condenas = "CONDENADO A " & fila("sent_tot_anio") & " AÑO(S) " & fila("sent_tot_meses") & " MES(ES) " & fila("sent_tot_dias") & " DIAS, " & fila("periodo_condena") & " "
                        End If
                        head = head & " " & condenas

                    Case enumTipoDocumentoJudicial.Sentencia, enumTipoDocumentoJudicial.ResolucionConsentida, enumTipoDocumentoJudicial.Ejecutoria_Superior,
                        enumTipoDocumentoJudicial.Ejecutoria_Suprema

                        Dim aut As String = ""
                        Dim sentConsen As String = ""
                        Dim fecSent As String = ""
                        Dim idTipoProceso As Short = fila("fk_mot_ing_id")

                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                            Case Else
                                aut = fila("res_aut_otro_cargo")
                        End Select

                        If fila("sent_consentida") = 1 Or fila("sent_consentida") = True Then
                            sentConsen = " CONSENTIDA"
                        End If

                        If fila.Item("fecha_sent") = 0 Then
                            fecSent = ", F. SENTENCIA: "
                        Else
                            fecSent = ", F. SENTENCIA: " & Legolas.Components.FechaHora.FechaDate(fila.Item("fecha_sent"))
                        End If

                        head = "FECHA DOC.: " & fecDocStr &
                            ", AUT. JUDICIAL: " & aut.ToUpper & ", CON DOC. N°: " & fila.Item("res_doc_jud_num") & IIf(fila.Item("sent_vers") = "V2", "", sentConsen) & ", SECRETARIO: " & fila("res_nom_secre") &
                           fecSent & ", "

                        If fila("sent_cad_perpet").ToString = True Or fila("sent_cad_perpet").ToString = 1 Then
                            condenas = "CONDENADO A CADENA PERPETUA"
                        Else
                            condenas = fnSentenciaCondenadoDeclarado(idTipoProceso) & fila("sent_tot_anio") & " AÑO(S) " & fila("sent_tot_meses") &
                                " MES(ES) " & fila("sent_tot_dias") & " DIAS " & fila("periodo_condena") & "."
                        End If

                        head = head & " " & condenas

                    Case enumTipoDocumentoJudicial.Sentencia_Aclaratoria, enumTipoDocumentoJudicial.Sent_Sustitucion_Pena,
                        enumTipoDocumentoJudicial.Sent_Adecuacion_Pena, enumTipoDocumentoJudicial.Resolucion_Superior,
                        enumTipoDocumentoJudicial.Resolucion, enumTipoDocumentoJudicial.Revocatoria

                        Dim aut As String = ""
                        Dim sentConsen As String = ""
                        Dim fecSent As String = ""

                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                            Case Else
                                aut = fila("res_aut_otro_cargo")
                        End Select

                        If fila("sent_consentida") = 1 Or fila("sent_consentida") = True Then
                            sentConsen = " CONSENTIDA"
                        End If

                        fecSent = IIf(tipoDoc = enumTipoDocumentoJudicial.Resolucion, ", F. RESOLUCIÓN: ", ", F. SENTENCIA: ")
                        If fila.Item("fecha_sent") <> 0 Then
                            fecSent = fecSent & Legolas.Components.FechaHora.FechaDate(fila.Item("fecha_sent"))
                        End If

                        head = "FECHA DOC.: " & fecDocStr &
                            ", AUT. JUDICIAL: " & aut.ToUpper & ", CON DOC. N°: " & fila.Item("res_doc_jud_num") & sentConsen & ", SECRETARIO: " & fila("res_nom_secre") &
                           fecSent

                        If fila("sent_cad_perpet").ToString = True Or fila("sent_cad_perpet").ToString = 1 Then
                            condenas = "CONDENADO A CADENA PERPETUA"
                        Else
                            condenas = "CONDENADO A " & fila("sent_tot_anio") & " AÑO(S) " & fila("sent_tot_meses") & " MES(ES) " & fila("sent_tot_dias") & " DIAS " & fila("periodo_condena") & " "
                        End If

                        head = head & " " & condenas

                    Case enumTipoDocumentoJudicial.Sent_Conmutacion_Pena
                        Dim aut As String = ""
                        Dim sentConsen As String = ""
                        Dim fecSent As String = ""
                        Dim EtuiquetaDoc As String = ""
                        Dim secretario As String = ""

                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                                secretario = ", SECRETARIO: " & fila("res_nom_secre")
                            Case Else
                                aut = fila("res_aut_otro_cargo")
                                secretario = ""
                        End Select

                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                EtuiquetaDoc = ""
                            Case 1
                                EtuiquetaDoc = " CON DOC. N°: "
                            Case Else
                                EtuiquetaDoc = ", RESOLUCIÓN SUPREMA N°: "
                        End Select

                        If fila("sent_consentida") = 1 Or fila("sent_consentida") = True Then
                            sentConsen = " CONSENTIDA"
                        End If
                        If fila.Item("fecha_sent") = 0 Then
                            fecSent = ", F. SENTENCIA: "
                        Else
                            fecSent = ", F. SENTENCIA: " & Legolas.Components.FechaHora.FechaDate(fila.Item("fecha_sent"))
                        End If
                        head = "FECHA PUBLICACIÓN: " & fecDocStr &
                            ", AUTORIDAD QUE CONCEDE : " & aut.ToUpper & EtuiquetaDoc & fila.Item("res_doc_jud_num") & sentConsen & secretario

                        If fila("sent_cad_perpet").ToString = True Or fila("sent_cad_perpet").ToString = 1 Then
                            condenas = ", CONDENADO A CADENA PERPETUA"
                        Else
                            condenas = ", PENA CONMUTADA: DE " & fila("sent_tot_anio") & " AÑO(S) " & fila("sent_tot_meses") & " MES(ES) " & fila("sent_tot_dias") & " DIA(S) DE PPL" & ", VENCIMIENTO DE LA PENA : " & fila("periodo_condena") & " "
                        End If
                        head = head & " " & condenas

                    Case enumTipoDocumentoJudicial.Sent_Pena_Limitativa
                        Dim aut As String = ""
                        Dim fecSent As String = ""

                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                            Case Else
                                aut = fila("res_aut_otro_cargo")
                        End Select

                        If fila.Item("fecha_sent") = 0 Then
                            fecSent = ", F. SENTENCIA: "
                        Else
                            fecSent = ", F. SENTENCIA: " & Legolas.Components.FechaHora.FechaDate(fila.Item("fecha_sent"))
                        End If

                        head = "FECHA DOC.: " & fecDocStr &
                            ", ORDENA JUZGADO/SALA: " & aut.ToUpper & " CON DOC. N°: " & fila.Item("res_doc_jud_num") & ", SECRETARIO: " & fila("res_nom_secre") &
                           fecSent & " Jornadas: " & fila("prol_det_cant")

                        head = head & " " & condenas

                    Case enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD

                        Dim aut As String = ""
                        Dim fecSent As String = ""
                        Dim strSentenciaConsentida As String = ""

                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                            Case Else
                                aut = fila("res_aut_otro_cargo")
                        End Select

                        If fila("sent_consentida") = 1 Or fila("sent_consentida") = True Then
                            strSentenciaConsentida = " CONSENTIDA"
                        End If

                        'jmr, 13.08.2020
                        If fila.Item("fecha_sent") > 0 Then
                            fecSent = ", F. SENTENCIA: " & Legolas.Components.FechaHora.FechaDate(fila.Item("fecha_sent"))
                        Else
                            fecSent = ", F. SENTENCIA:"
                        End If

                        head = "FECHA DOC.: " & fecDocStr &
                            ", ORDENA JUZGADO/SALA: " & aut.ToUpper & " CON DOC. N°: " & fila.Item("res_doc_jud_num") & strSentenciaConsentida &
                            ", SECRETARIO: " & fila("res_nom_secre") & fecSent

                        If fila("sent_cad_perpet").ToString = True Or fila("sent_cad_perpet").ToString = 1 Then
                            condenas = "CONDENADO A CADENA PERPETUA"
                        Else
                            condenas = "CONDENADO A " & fila("sent_tot_anio") & " AÑO(S) " & fila("sent_tot_meses") & " MES(ES) " & fila("sent_tot_dias") & " DIAS " & fila("periodo_condena") & " "
                        End If

                        head = head & " " & condenas

                    Case enumTipoDocumentoJudicial.Anulacion_Antecedentes '34
                        'jmr, 09/12/2021

                        Dim nombreAutoridad As String = ""
                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                nombreAutoridad = ""
                            Case 1
                                nombreAutoridad = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                            Case Else
                                nombreAutoridad = fila("res_aut_otro_cargo")
                        End Select

                        Dim sentenciaConsentida As String = ""

                        If fila("sent_consentida") = 1 Or fila("sent_consentida") = True Then
                            sentenciaConsentida = " CONSENTIDA"
                        End If

                        head = "FECHA DOC.: " & fecDocStr &
                            ", ORDENA JUZGADO/SALA: " & nombreAutoridad.ToUpper & " CON DOC. N°: " & fila.Item("res_doc_jud_num") & sentenciaConsentida &
                            ", SECRETARIO: " & fila("res_nom_secre") & "." & fila.Item("doc_anu").ToString.ToUpper

                        head = head & " " & "Tipo de Anulación: " & nombreSubTipoDocumento & "."

                    Case enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental, enumTipoDocumentoJudicial.Retorno_de_HospitalMental

                        Dim autoridadNombre As String = ""
                        Dim sentenciaConsentidaNombre As String = ""
                        Dim fechaSentencia As String = ""
                        Dim idTipoProceso As Short = fila("fk_mot_ing_id")

                        Select Case fila("res_tip_aut_jud_id")
                            Case -1
                                autoridadNombre = ""
                            Case 1
                                autoridadNombre = fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                            Case Else
                                autoridadNombre = fila("res_aut_otro_cargo")
                        End Select

                        If objEnt.Fecha = 0 Then objEnt.Fecha = fila.Item("sen_fec_ins")

                        If fila("sent_consentida") = 1 Or fila("sent_consentida") = True Then
                            sentenciaConsentidaNombre = " CONSENTIDA"
                        End If

                        If fila.Item("fecha_sent") = 0 Then
                            fechaSentencia = ", F. SENTENCIA: "
                        Else
                            fechaSentencia = ", F. SENTENCIA: " & Legolas.Components.FechaHora.FechaDate(fila.Item("fecha_sent"))
                        End If

                        head = "FECHA DOC.: " & fecDocStr &
                            ", AUT. JUDICIAL: " & autoridadNombre.ToUpper & ", CON DOC. N°: " & fila.Item("res_doc_jud_num") & sentenciaConsentidaNombre & ", SECRETARIO: " & fila("res_nom_secre") &
                           fechaSentencia

                        If fila("sent_cad_perpet").ToString = True Or fila("sent_cad_perpet").ToString = 1 Then
                            condenas = "CONDENADO A CADENA PERPETUA"
                        Else
                            condenas = fnSentenciaCondenadoDeclarado(idTipoProceso) & fila("sent_tot_anio") & " AÑO(S) " &
                                fila("sent_tot_meses") & " MES(ES) " & fila("sent_tot_dias") & " DIAS " & fila("periodo_condena") & "."
                        End If

                        head = head & " " & condenas
                    Case enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota

                        Dim idTipoProceso As Short = fila("fk_mot_ing_id")

                        objEnt.Fecha = fila.Item("sen_fec_ins")
                        If fila.Item("est_eje_mov") = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.Ejecutado Then
                            objEnt.Fecha = fila.Item("doc_fec_mov")
                        End If

                        head = "FECHA DOC.: " & fecDocStr & ", CON DOC. N°: " & fila("res_doc_jud_num")
                    Case enumTipoDocumentoJudicial.OtroProceso
                        head = "MOTIVO: " & fila.Item("res_mov_mot_nom") & ", " & "Nº DE OFICIO: " & fila.Item("res_doc_jud_num") &
                                ", FECHA DOC.: " & fecDocStr & ", AUT. JUDICIAL: " & fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud") &
                                ", SECRETARIO: " & fila("res_nom_secre") & "."
                    Case enumTipoDocumentoJudicial.ResolucionDeclaraConsentida
                        head = "FECHA OFICIO: " & fecDocStr &
                        ", AUT. JUDICIAL: " & fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud")
                    Case Else
                        head = "FECHA DOC.: " & fecDocStr &
                        ", ORDENA: " & fila.Item("res_sala_jud") & " / " & fila.Item("res_autoridad_jud") & " CON DOC. N°: " & fila.Item("res_doc_jud_num") & ", SECRETARIO: " & fila("res_nom_secre")
                End Select


                '/*****************************************EXPEDIENTES - DETALLE*********************************************************************/
                Dim drDetalle As DataRow()
                drDetalle = dt.Select("doc_jud_id=" & objEnt.Codigo)

                Dim descrip As String = ""
                Dim strTipLib As String = ""
                Dim objExpeSumatoria As New ArrayList

                For Each objFila As DataRow In drDetalle
                    Select Case tipoDoc
                        Case 6, 26
                        Case Else
                            If objFila.Item("tip_act") = 99 Then Continue For
                    End Select
                    Select Case tipoDoc
                        Case enumTipoDocumentoJudicial.Ingreso

                            Select Case intDocumentoAnuladoEstado
                                Case 3 'anulado
                                    If blnMostrarDocAnulados = False Then
                                        descrip = ""
                                    Else
                                        descrip = descrip & vbCrLf & "REF. EXP. N°: " & objFila.Item("exp_int_ing_exp_num") & ", SALA/JUZGADO: " &
                                        objFila.Item("exp_sala_jud") & ", SECRETARIO: " & objFila.Item("int_exp_sec") & objFila.Item("declara_exp_sent") &
                                        strTipLib & "." & vbCrLf &
                                               "DELITO: " & objFila.Item("delitos") & ". "
                                    End If
                                Case Else
                                    Dim ExpAnu As String = objFila.Item("doc_anu")
                                    If ExpAnu = "(ANULADO)" Then
                                        Continue For
                                    Else
                                        descrip = descrip & vbCrLf & "REF. EXP. N°: " & objFila.Item("exp_int_ing_exp_num") & ", SALA/JUZGADO: " &
                                        objFila.Item("exp_sala_jud") & ", SECRETARIO: " & objFila.Item("int_exp_sec") & objFila.Item("declara_exp_sent") &
                                        strTipLib & "." & vbCrLf &
                                               "DELITO: " & objFila.Item("delitos") & ". "
                                        ' objEnt.Detalle = ""
                                    End If
                            End Select

                        Case enumTipoDocumentoJudicial.Aclaratoria
                            If fila.Item("DocSubTipoNom").ToString.ToUpper <> "ACLARATORIA DE NOMBRE" Then

                                descrip = descrip & vbCrLf & "REF. EXP. N°: " & objFila.Item("exp_int_ing_exp_num") & ", SALA/JUZGADO: " & objFila.Item("exp_sala_jud") & ", SECRETARIO: " & objFila.Item("int_exp_sec") & objFila.Item("declara_exp_sent") & strTipLib & "." & vbCrLf &
                                                 "DELITO: " & objFila.Item("delitos") & ". "
                            End If

                        Case enumTipoDocumentoJudicial.Libertad

                            Dim idTipoProceso As Short = fila("fk_mot_ing_id")
                            Dim idEstadoEjecucion As Short = objFila.Item("est_eje_trs_id")
                            Dim fechaMovimiento As Long = 0

                            Dim estadoEjecucionNombre As String = fnEstadoEjecucionDocumento(idEstadoEjecucion)

                            If idEstadoEjecucion = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.Ejecutado Then
                                fechaMovimiento = objFila.Item("doc_fec_mov")
                            End If

                            Dim datosInimputables As String = ""

                            If idTipoProceso = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.PosibleInimputable Or
                                idTipoProceso = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable Then

                                If fechaMovimiento < 1 Then
                                    fechaMovimiento = objFila.Item("fec_recep_doc")
                                    If fila("flg_proc_pend").ToString = 1 Then
                                        datosInimputables = datosInimputables
                                    Else
                                        Dim destino As String = objFila.Item("cen_sal_men_nom")
                                        If objFila.Item("cen_sal_men_nom") = "TRATAMIENTO AMBULATORIO" Then
                                            destino = ", Con " & objFila.Item("cen_sal_men_nom")
                                        Else
                                            destino = ", DESTINO: " & objFila.Item("cen_sal_men_nom")
                                        End If
                                        Dim estado As String = IIf(idEstadoEjecucion = 4, "", ", ESTADO: " & estadoEjecucionNombre)
                                        datosInimputables = destino & estado
                                    End If
                                End If
                            Else
                                If fechaMovimiento > 0 Then
                                    datosInimputables = IIf(fila("flg_proc_pend").ToString = "0", "", ", ESTADO: " & estadoEjecucionNombre)
                                Else
                                    If fila("flg_proc_pend").ToString = 1 Then
                                        datosInimputables = IIf(fila("flg_proc_pend").ToString = "0", "", ", ESTADO: " & estadoEjecucionNombre)
                                    End If
                                End If
                            End If
                            Dim var As String = objFila.Item("prol_det_tip_und").ToString.ToUpper
                            var = IIf(var.Length = 0, "", " (") & var & IIf(var.Length = 0, "", ")")
                            strTipLib = ", TIPO LIBERTAD: " & objFila.Item("tipolibertadExp").ToString.ToUpper & var

                            descrip = descrip & vbCrLf & "REF. EXP. N°: " & objFila.Item("exp_int_ing_exp_num") & ", SALA/JUZGADO: " &
                                objFila.Item("exp_sala_jud") & ", SECRETARIO: " & objFila.Item("int_exp_sec") & objFila.Item("declara_exp_sent") &
                                strTipLib & datosInimputables & ". " & vbCrLf & "DELITO: " & objFila.Item("delitos") & ". "

                        Case enumTipoDocumentoJudicial.Detencion,
                         enumTipoDocumentoJudicial.DetencionReferenciado
                            If objFila.Item("res_tip_resol_id").ToString() <> 99 Then
                                descrip = descrip & vbCrLf & "DELITO: " & objFila.Item("delitos") & ". "
                            End If
                        Case enumTipoDocumentoJudicial.Ejecutoria_Suprema,
                                enumTipoDocumentoJudicial.Sentencia,
                                enumTipoDocumentoJudicial.Sentencia_Aclaratoria,
                                enumTipoDocumentoJudicial.Sent_Adecuacion_Pena,
                                enumTipoDocumentoJudicial.Sent_Conmutacion_Pena,
                                enumTipoDocumentoJudicial.Ejecutoria_Superior,
                                enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD,
                                enumTipoDocumentoJudicial.Integracion_Sentencia,
                                enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                                enumTipoDocumentoJudicial.Resolucion,
                                enumTipoDocumentoJudicial.Resolucion_Superior,
                                enumTipoDocumentoJudicial.Revocatoria,
                                enumTipoDocumentoJudicial.Sent_Pena_Limitativa,
                                enumTipoDocumentoJudicial.Sent_Sustitucion_Pena

                            If objFila.Item("docjud_queda") > 0 Then Continue For

                            descrip = descrip & vbCrLf & "REF. EXP. N°: " & objFila.Item("exp_int_ing_exp_num") & ", SALA/JUZGADO: " & objFila.Item("exp_sala_jud") & ", SECRETARIO: " & objFila.Item("int_exp_sec") & objFila.Item("declara_exp_sent") & strTipLib & "." & vbCrLf &
                         "DELITO: " & objFila.Item("delitos_sent") & ". "
                            If tipoDoc = enumTipoDocumentoJudicial.Sentencia Then
                                If fila.Item("sent_vers") = "V2" Then
                                    If fila.Item("sent_consentida") = 1 Then
                                        descrip = descrip & vbCrLf &
                                    "SENTENCIA DECLARADA CONSENTIDA CON RESOLUCIÓN N°: " & IIf(fila.Item("res_doc_jud_num_aux") = "", "No indica", fila.Item("res_doc_jud_num_aux")) & " DE FECHA: " & IIf(fila.Item("sent_FRESOL") = "", "No indica", fila.Item("sent_FRESOL"))
                                    ElseIf fila.Item("sent_consentida") = 0 Then
                                        descrip = descrip & vbCrLf &
                                    "NOTA: PENDIENTE DE LA RESOLUCIÓN QUE DECLARA CONSENTIDA O EJECUTORIADA"
                                    End If
                                End If
                            End If
                        Case enumTipoDocumentoJudicial.Sumatoria_de_Sentencia

                            Dim blnRegistrar As Boolean = True

                            If objExpeSumatoria.Count > 0 Then
                                For Each strNumeroExp As String In objExpeSumatoria
                                    If strNumeroExp.ToUpper = objFila.Item("exp_int_ing_exp_num").ToString.ToUpper Then
                                        blnRegistrar = False
                                        Exit For
                                    End If
                                Next
                            End If

                            If blnRegistrar = True Then
                                descrip = descrip & vbCrLf & "REF. EXP. N°: " & objFila.Item("exp_int_ing_exp_num") & ", SALA/JUZGADO: " & objFila.Item("exp_sala_jud") & ", SECRETARIO: " & objFila.Item("int_exp_sec") & objFila.Item("declara_exp_sent") & strTipLib & "." & vbCrLf &
                         "DELITO: " & objFila.Item("delitos_sent") & ". "

                                objExpeSumatoria.Add(objFila.Item("exp_int_ing_exp_num"))
                            End If

                        Case enumTipoDocumentoJudicial.Notas, enumTipoDocumentoJudicial.Traslado
                            'SIN REFRENCIA DE EXPEDIENTES

                        Case enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental, enumTipoDocumentoJudicial.Retorno_de_HospitalMental,
                             enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota

                            Dim idEstadoEjecucion As Short = objFila.Item("est_eje_trs_id")
                            Dim fecha As Long = objFila.Item("fec_recep_doc")

                            Dim estadoEjecucionNombre As String = fnEstadoEjecucionMovimiento(idEstadoEjecucion, fila("mov_est_id"), fila("est_eje_mov"), fila("est_eje_obs"))

                            If idEstadoEjecucion = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.Ejecutado Then
                                fecha = objFila.Item("doc_fec_mov")
                            End If
                            descrip = descrip & vbCrLf & "EXPEDIENTE N°: " & objFila.Item("exp_int_ing_exp_num") & '--comentado--", FECHA DE EJECUCIÓN: " & Legolas.Components.FechaHora.FechaDate(fecha) & 
                                ", DESTINO: " & objFila.Item("cen_sal_men_nom") & ", ESTADO: " &
                            estadoEjecucionNombre & "."

                        Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OtroProceso
                            Dim tiempodecondena As String = objFila.Item("sent_tot_anio") & " Año(s) | " & objFila.Item("sent_tot_meses") & " Mes(es) | " & objFila.Item("sent_tot_dias") & " Dia(s) "
                            Dim periodocondena As String = objFila.Item("periodo_condena")


                            If fila("sent_cad_perpet").ToString = True Or fila("sent_cad_perpet").ToString = 1 Then
                                tiempodecondena = ", CONDENADO A CADENA PERPETUA"
                            Else
                                Select Case fila.Item("mov_mot_id")
                                    Case 124, 196 ' Por sentencia / Adelanto de fallo
                                        tiempodecondena = ", CONDENADO A: " & tiempodecondena & periodocondena
                                    Case 178
                                        tiempodecondena = ", DURACIÓN DE LA MEDIDA DE SEGURIDAD DE INTERNACIÓN: " & tiempodecondena & periodocondena
                                    Case Else
                                        tiempodecondena = ""
                                End Select
                            End If

                            descrip = descrip & vbCrLf & "EXP. N°: " & objFila.Item("exp_int_ing_exp_num") & tiempodecondena &
                                     ", DELITO: " & objFila.Item("delitos") & ". "
                        Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionDeclaraConsentida
                            head = head & ", EXP. N°: " & objFila.Item("exp_int_ing_exp_num") &
                                ", Nº RESOLUCIÓN: " & IIf(objFila.Item("res_doc_jud_num_aux") = "", "No indica", objFila.Item("res_doc_jud_num_aux")) &
                                ", FECHA RESOLUCIÓN: " & IIf(objFila.Item("sent_fresol") = "", "No indica", objFila.Item("sent_fresol")) &
                                "."
                        Case Else
                            If objFila.Item("docjud_queda") > 0 Then Continue For
                            descrip = descrip & vbCrLf & "REF. EXP. N°: " & objFila.Item("exp_int_ing_exp_num") & ", SALA/JUZGADO: " & objFila.Item("exp_sala_jud") & ", SECRETARIO: " & objFila.Item("int_exp_sec") & objFila.Item("declara_exp_sent") & strTipLib & "." & vbCrLf &
                                                   "DELITO: " & objFila.Item("delitos") & ". "
                    End Select

                    tipoDoc = Integer.Parse(fila.Item("res_tip_resol_id").ToString)
                Next

                If blnNoMostrarDocumento = True Then

                    If tipoDoc = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso And intDocumentoAnuladoEstado = Type.Enumeracion.enmEstadoDocumentoAnulado.Anulado_total Then
                        Dim conAnu As Integer = 0
                        For Each f As DataRow In dtDocumentos.Rows
                            If fila("fk_ing_inp_id") = f("fk_ing_inp_id") Then
                                conAnu += 1
                            End If
                        Next
                        If conAnu < 2 Then
                            Continue For
                        End If
                    End If

                    objEnt.Descripcion = (head & " " & descrip & " " & obs_doc & " " & headQ & " " & obs_doc_queda).ToUpper
                    objEnt.DocJudicialEstadoId = fila.Item("doc_jud_est_id")
                    objEnt.IngresoInpeId = fila.Item("fk_ing_inp_id")

                    'agregar solo documentos, que no se repiten
                    Dim existeDocumento As Boolean = False
                    For Each objFila As Entity.Registro.Antecedente.DetalleAntecedente In listaDocumentos
                        If objFila.Codigo = objEnt.Codigo Then
                            existeDocumento = True
                            Exit For
                        End If
                    Next

                    'si no existe el documento agregar
                    If existeDocumento = False Then
                        listaDocumentos.Add(objEnt)
                    End If

                End If

            Next

            Dim listaOrdenada As Entity.Registro.Antecedente.DetalleAntecedenteCol
            listaOrdenada = OrdenarOdcJudicial(listaDocumentos)

            Return listaOrdenada

        End Function
        Private Function fnEstadoEjecucionDocumento(idEstadoEjecucion As Short) As String

            Dim value As String = ""

            Select Case idEstadoEjecucion
                Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.EnDesarrollo,
                     Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.Apto

                    'value = "EN DESARROLLO"
                    'value = "APTO PARA EL REGISTRO DE EGRESO"
                    value = "PENDIENTE DE EJECUCIÓN"

                Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.Ejecutado

                    value = "EJECUTADO"
                    'fecha = objFila.Item("doc_fec_mov")

                Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion1

                    value = "NO EJECUTADO/Por no ser recibido en hospital mental destino"

                Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion2

                    value = "NO EJECUTADO/Por orden judicial"

                Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion3

                    value = "NO EJECUTADO/Pendiente de ejecución, por tener otros procesos vigentes."

            End Select

            Return value.ToUpper

        End Function

        Private Function fnSentenciaCondenadoDeclarado(idTipoProceso As Short) As String
            Dim value As String

            Select Case idTipoProceso
                Case Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable
                    value = "Declarado Inimputable con medida de seguridad de internación a: "

                Case Else
                    value = "Condenado A: "
            End Select

            Return value.ToUpper

        End Function

        Private Function fnEstadoEjecucionMovimiento(idEstadoEjecucion As Short,
                                                  idEstadoMovimiento As Short,
                                                  idEstadoEjecucionMovimiento As Short,
                                                  observacionEstadoNoEjecutado As String) As String

            Dim value As String = ""
            observacionEstadoNoEjecutado = IIf(Len(observacionEstadoNoEjecutado) > 0, observacionEstadoNoEjecutado, "N/I")
            Select Case idEstadoEjecucion
                'Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.EnDesarrollo
                '    value = "EN DESARROLLO"
                Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.EnDesarrollo, Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.Apto
                    value = "PENDIENTE DE EJECUCIÓN" '"APTO PARA EL REGISTRO DE EGRESO"
                Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.Ejecutado

                    If (idEstadoMovimiento = 3 And idEstadoEjecucionMovimiento = 1) Then 'Or idEstadoEjecucion = 3 Then
                        value = "EJECUTADO" & ", DETALLE DE EJECUCIÓN: " & observacionEstadoNoEjecutado
                    Else
                        If idEstadoEjecucionMovimiento = 2 Then
                            value = "EGRESO TEMPORAL" & ", DETALLE DE EGRESO:  " & observacionEstadoNoEjecutado
                        Else
                            value = "EJECUTADO"
                        End If
                    End If
            End Select

            If idEstadoEjecucion <> 3 Then
                ' VALIDAR MOVIMIENTO CUANDO NO ES ACEPTADO
                Select Case idEstadoEjecucionMovimiento
                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion1

                        value = "NO EJECUTADO/Por no ser recibido en hospital de salud mental por falta de cupo" &
                            IIf(Len(observacionEstadoNoEjecutado) > 0, " (" & observacionEstadoNoEjecutado & ")", "")

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion2

                        value = "NO EJECUTADO/Por orden judicial" &
                            IIf(Len(observacionEstadoNoEjecutado) > 0, " (" & observacionEstadoNoEjecutado & ")", "")

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion3

                        value = "NO EJECUTADO/Pendiente de ejecución, por tener otros procesos vigentes." &
                            IIf(Len(observacionEstadoNoEjecutado) > 0, " (" & observacionEstadoNoEjecutado & ")", "")

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion4

                        value = "NO EJECUTADO/Otros." &
                            IIf(Len(observacionEstadoNoEjecutado) > 0, " (" & observacionEstadoNoEjecutado & ")", "")
                End Select
            End If

            Return value.ToUpper

        End Function
#End Region
    End Class
End Namespace