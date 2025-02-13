Option Explicit On
Imports System.Data.SqlClient
Imports System.Linq
Imports Type.Enumeracion.TipoDocJudicial

Namespace Registro.Antecedente
    Public Class SolicitudAntecedente

#Region "Funciones"

        ''' <summary>
        ''' Autor: Hugo N. Rosario
        ''' Fecha:22/02/2018
        ''' Verifica la persona tiene antecedente negativo
        ''' </summary>
        ''' <param name="internoId"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function EsAntecedenteNegativo(internoId As Integer) As Boolean
            Dim antecedenteNegativo As Boolean = False

            Dim valor As Integer = -1

            valor = Data.Registro.Reporte.AntecedenteJudicial.ListarOutput("lst", "es_antecedente_negativo", internoId, 3) '3 = lima y callao
            If valor > 0 Then 'si tiene antecedente
                antecedenteNegativo = False
            Else 'no tiene antecedente
                antecedenteNegativo = True
            End If

            Return antecedenteNegativo
        End Function


        ''' <summary>
        ''' Verifica si posee procesos pendientes con mandato de detencion
        ''' </summary>
        ''' <param name="internoId"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function RegistraProcesoPendienteConMD(internoId As Integer, ambJur As Type.Enumeracion.AntecedenteJudicial.enmAmbitoJurisdiccionAutJud) As Boolean
            Dim v As Boolean = False
            Dim registraProcesos As Boolean = False

            Dim valor As Integer = -1

            valor = Data.Registro.Reporte.AntecedenteJudicial.ListarOutput("lst", "registra_proc_pend_con_md", internoId, ambJur) '3 = lima y callao
            If valor > 0 Then 'si tiene procesos pend
                registraProcesos = True
            Else 'no tiene procesos
                registraProcesos = False
            End If

            Return registraProcesos
            Return v
        End Function

#End Region

#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Antecedente.SolicitudAntecedente
            Dim objEnt As New Entity.Registro.Antecedente.SolicitudAntecedente
            Dim list As Entity.Registro.Antecedente.SolicitudAntecedenteCol

            objEnt.Codigo = Codigo
            list = Listar(objEnt)

            Return If(list.Count > 0, list.SolicitudAntecedente(0), Nothing)
        End Function


        ''' <summary>
        ''' Autor: Hugo N. Rosario
        ''' Fecha:19-10-2016
        ''' Retorna los antecedentes del interno hasta la fecha actual
        ''' </summary>
        ''' <param name="IdInterno">Id del interno</param>
        ''' <returns>Lista de detalles de antecedentes</returns>
        ''' 
        Public Function ListarDetalleAntecedentePositivo_LM(IdInterno As Integer, ambitoAutJud As Integer, Optional ByVal MostrarAnulaciones As Boolean = False) As Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim list As New Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim t As New DataTable
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim dr As SqlDataReader

            Dim docAnulados As Short = 0
            If MostrarAnulaciones = True Then
                docAnulados = 1
            End If

            If MostrarAnulaciones = True Then
                dr = Data.Registro.Reporte.AntecedenteJudicial.ListarDetalleAntecedenteTemp(sqlCon, "lst", "lst_antecedente_judicial_con_anulacion_v1_LM",
                                                                                                                   IdInterno, ambitoAutJud, docAnulados)
            Else
                dr = Data.Registro.Reporte.AntecedenteJudicial.ListarDetalleAntecedenteTemp(sqlCon, "lst", "lst_antecedente_judicial_v1_LM",
                                                                                                                   IdInterno, ambitoAutJud, docAnulados)
            End If

            Try
                If dr.HasRows Then
                    t.Load(dr)
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

            Dim objBss As New Bussines.Registro.Reporte.AntecedenteJudicial
            Dim lsNew As Entity.Registro.Antecedente.DetalleAntecedenteCol

            lsNew = objBss.generarAntecedente(t, MostrarAnulaciones)

            Return lsNew



            'For Each f As DataRow In tmae.Rows
            '    Dim objEnt As New Entity.Registro.Antecedente.DetalleAntecedente

            '    objEnt.Codigo = f.Item("doc_jud_id")
            '    objEnt.Fecha = f.Item("fec_recep_doc")
            '    objEnt.Detalle = f.Item("res_tipoDocNom").ToString.ToUpper & " " & vbCrLf & f.Item("doc_anu").ToString.ToUpper

            '    objEnt.TipoDocJudicialId = f.Item("res_tip_resol_id") ''tipo de documento judicial
            '    objEnt.FechaRecepDocLong = f.Item("fec_recep_doc") 'fecha de recepcion long
            '    'objEnt.IngresoNum = f.Item("int_ing_nro")
            '    objEnt.FechaDocLong = f.Item("fec_doc_lon")
            '    objEnt.FechaCreaReg = f.Item("fec_crea_reg")

            '    Dim tipoDoc As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial
            '    Dim head As String = ""
            '    Dim obs_doc As String = ""
            '    Dim fecSentStr As String = "" 'fecha de sentencia
            '    Dim condenas As String = ""
            '    Dim fecDocStr As String = ""
            '    Dim fecRecepDocStr As String = ""
            '    Dim fecProlIniStr As String = ""
            '    Dim fecProlFinStr As String = ""
            '    Dim fecMovStr As String = ""

            '    obs_doc = If(f("doc_jud_obs").ToString.Trim.Length > 0, vbCrLf + "OBSERVACIONES: " & f("doc_jud_obs").ToString.Trim.ToUpper, "")
            '    tipoDoc = Integer.Parse(f.Item("res_tip_resol_id").ToString)
            '    fecDocStr = If(f("fec_doc") = "", "N/I", f("fec_doc"))
            '    fecRecepDocStr = If(f("fec_recep_doc") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(f.Item("fec_recep_doc")))
            '    fecMovStr = If(f("doc_fec_mov") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(f.Item("doc_fec_mov")))
            '    fecProlIniStr = If(f("prol_det_ini_fec") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(f.Item("prol_det_ini_fec")))
            '    fecProlFinStr = If(f("prol_det_fin_fec") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(f.Item("prol_det_fin_fec")))
            '    fecSentStr = If(f("fecha_sent") = 0, "", DateTime.FromFileTime(f("fecha_sent")))

            '    Select Case tipoDoc
            '        Case enumTipoDocumentoJudicial.Queda
            '            head = "FECHA DOC.: " & fecDocStr &
            '                ", ORDENA: " & f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud") & " CON DOC. N°: " & f.Item("res_doc_jud_num") & ", SECRETARIO: " & f("res_nom_secre")
            '        Case enumTipoDocumentoJudicial.Revocatoria_de_Libertad
            '            head = "FECHA DOC.: " & fecDocStr &
            '                ", ORDENA: " & f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud") & " CON DOC. N°: " & f.Item("res_doc_jud_num") & ", SECRETARIO: " & f("res_nom_secre")
            '        Case enumTipoDocumentoJudicial.Traslado '5
            '            Dim penOri As String = ""
            '            Dim penDest As String = ""
            '            Dim ordena As String = ""

            '            If f("res_pen_orig_nom") = "" Or f("res_pen_orig_nom") = "NO INDICA" Then
            '                penOri = f("res_pen_ori_otr")
            '            Else
            '                If f("pen_orig_id") = 35 Then
            '                    penOri = " E.T. " & f("res_pen_orig_nom")
            '                Else
            '                    penOri = " E.P. " & f("res_pen_orig_nom")
            '                End If
            '            End If

            '            If f("res_pen_des_nom") = "" Or f("res_pen_des_nom") = "NO INDICA" Then
            '                penDest = f("res_pen_des_otr")
            '            Else
            '                If f("pen_des_id") = 35 Then
            '                    penDest = " E.T. " & f("res_pen_des_nom")
            '                Else
            '                    penDest = " E.P. " & f("res_pen_des_nom")
            '                End If
            '            End If

            '            ordena = f.Item("res_tip_aut_jud")
            '            If f.Item("res_aut_otro_nom").ToString.Length > 0 Then
            '                ordena = ordena & " - " & f.Item("res_aut_otro_nom")
            '            End If

            '            head = "FECHA DOC.: " & fecDocStr & " FECHA MOV: " & fecMovStr &
            '                ", ORDENA: " & ordena.ToUpper & " CON DOC. N°: " & f("res_doc_jud_num") & ", POR " & f("res_mov_mot_nom") & " DE " & penOri & " A " & penDest
            '        Case enumTipoDocumentoJudicial.Libertad '6
            '            Dim aut As String = ""
            '            Select Case f("res_tip_aut_jud_id")
            '                Case -1
            '                    aut = ""
            '                Case 1
            '                    aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
            '                Case Else
            '                    aut = f("res_aut_otro_cargo")
            '            End Select
            '            objEnt.Fecha = f.Item("doc_fec_mov") 'Se debe mostrar fecha de libertad del doc, solicitud ORL coordinacion Gerardo V. 15/06/2018
            '            head = "FECHA DOC.: " & fecDocStr & ", FECHA LIBERTAD: " & fecMovStr &
            '                   ", ORDENA JUZGADO/SALA: " & aut.ToUpper & ", CON DOC. N°: " & f("res_doc_jud_num") & " DE FECHA " & fecDocStr & ", SECRETARIO: " & f("res_nom_secre")
            '        Case enumTipoDocumentoJudicial.Prolongacion_Detencion '10
            '            Dim strTip As String = ""

            '            If f.Item("prol_det_cant") > 0 Then
            '                If f.Item("prol_det_tip_und") = "A" Then strTip = ", Tiempo prolongación: " & f.Item("prol_det_cant") & " Año(s)"
            '                If f.Item("prol_det_tip_und") = "M" Then strTip = ", Tiempo prolongación: " & f.Item("prol_det_cant") & " Mes(es)"
            '                If f.Item("prol_det_tip_und") = "D" Then strTip = ", Tiempo prolongación: " & f.Item("prol_det_cant") & " Dia(s)"
            '            End If

            '            head = "FECHA DOC.: " & fecDocStr & ", F. INICIO: " & fecProlIniStr & " F. FINAL: " & fecProlFinStr & strTip &
            '                ", ORDENA: " & f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud") & " SECRETARIO: " & f("res_nom_secre") & ", CON DOC. N°: " & f.Item("res_doc_jud_num")

            '        Case enumTipoDocumentoJudicial.Detencion, enumTipoDocumentoJudicial.DetencionReferenciado  '12,66
            '            head = "FECHA DOC.: " & fecDocStr &
            '            ", ORDENA JUZGADO/SALA: " & f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud") & ", CON DOC. N°: " & f.Item("res_doc_jud_num") & ", SECRETARIO: " & f("res_nom_secre")
            '        Case enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
            '            head = "FECHA DOC.: " & fecDocStr &
            '                ", ORDENA " & f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud") & " CON DOC. N°: " & f.Item("res_doc_jud_num")
            '        Case enumTipoDocumentoJudicial.Avocamiento '9,11
            '            Dim aut As String = ""
            '            Select Case f("res_tip_aut_jud_id")
            '                Case -1
            '                    aut = ""
            '                Case 1
            '                    aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
            '                Case Else
            '                    aut = f("res_aut_otro_cargo")
            '            End Select
            '            Dim sentConsen As String = ""

            '            head = "FECHA DOC.: " & fecDocStr &
            '                    ", ORDENA: " & aut.ToUpper & " CON OFICIO N°: " & f.Item("res_doc_jud_num") & sentConsen & ", SECRETARIO: " & f("res_nom_secre")
            '        Case enumTipoDocumentoJudicial.Aclaratoria '13
            '            Dim aut As String = ""
            '            Select Case f("res_tip_aut_jud_id")
            '                Case -1
            '                    aut = ""
            '                Case 1
            '                    aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
            '                Case Else
            '                    aut = f("res_aut_otro_cargo")
            '            End Select
            '            objEnt.Detalle = "ACLARATORIA" & " " & vbCrLf & f.Item("doc_anu").ToString.ToUpper
            '            Dim subTipNom As String = ""
            '            If f.Item("DocSubTipoNom").ToString.ToUpper <> "ACLARATORIA DE EXPEDIENTE" Then
            '                subTipNom = f.Item("DocSubTipoNom").ToString.ToUpper & ", "
            '            End If
            '            head = subTipNom & "FECHA DOC.: " & fecDocStr & "ORDENA: " & aut & " CON DOC. N° " & f.Item("res_doc_jud_num")

            '        Case enumTipoDocumentoJudicial.Ingreso '14
            '            If f.Item("doc_jud_est_id") = 3 Then
            '                objEnt.Fecha = f.Item("fec_doc_lon") 'Se debe mostrar fecha de documento, solicitud ORL coordinacion Gerardo V. 15/06/2018
            '                head = "FECHA RECEP.: " & fecRecepDocStr & " INGRESA CON OFICIO N° " & f.Item("res_doc_jud_num") + Chr(13) +
            '                                      "(PROCESO ANULADO)" & " CON DESTINO AL E.P. " & f.Item("res_pen_des_nom")
            '            Else
            '                objEnt.Fecha = f.Item("fec_doc_lon") 'Se debe mostrar fecha de documento, solicitud ORL coordinacion Gerardo V. 15/06/2018
            '                head = "FECHA RECEP.: " & fecRecepDocStr & " INGRESA CON OFICIO N° " & f.Item("res_doc_jud_num") & " CON DESTINO AL E.P. " & f.Item("res_pen_des_nom")
            '            End If
            '        Case enumTipoDocumentoJudicial.Notas  ' 15 
            '            Dim ordena As String = ""
            '            objEnt.Detalle = f.Item("DocSubTipoNom").ToString.ToUpper & " " & vbCrLf & f.Item("doc_anu").ToString.ToUpper

            '            ordena = f.Item("res_tip_aut_jud")
            '            If f("res_tip_aut_jud_id") = 1 Then
            '                ordena = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
            '            Else
            '                ordena = ordena & " - " & f.Item("res_aut_otro_nom")
            '            End If

            '            head = "FECHA DOC.: " & fecDocStr &
            '                ", COMUNICA: " & ordena & " CON DOC. N°: " & f.Item("res_doc_jud_num")
            '        Case enumTipoDocumentoJudicial.Sumatoria_de_Sentencia, enumTipoDocumentoJudicial.Refundicion_de_Sentencia, enumTipoDocumentoJudicial.AcumulacionExpedientes,
            '             enumTipoDocumentoJudicial.Integracion_Sentencia
            '            Dim aut As String = ""
            '            Dim fecSent As String = ""
            '            Dim sentConsen As String = ""

            '            Select Case f("res_tip_aut_jud_id")
            '                Case -1
            '                    aut = ""
            '                Case 1
            '                    aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
            '                Case Else
            '                    aut = f("res_aut_otro_cargo")
            '            End Select

            '            If f("sent_consentida") = 1 Or f("sent_consentida") = True Then
            '                sentConsen = " CONSENTIDA"
            '            End If

            '            If f.Item("fecha_sent") = 0 Then
            '                fecSent = ", F. SENTENCIA: "
            '            Else
            '                fecSent = ", F. SENTENCIA: " & Legolas.Components.FechaHora.FechaDate(f.Item("fecha_sent"))
            '            End If

            '            head = "FECHA DOC.: " & fecDocStr &
            '                   ", ORDENA JUZGADO/SALA: " & aut.ToUpper & " CON DOC. N°: " & f.Item("res_doc_jud_num") & sentConsen & ", SECRETARIO: " & f("res_nom_secre") &
            '                   fecSent

            '            If f("sent_cad_perpet") = True Then
            '                condenas = "CADENA PERPETUA"
            '            Else
            '                condenas = "CONDENADO A " & f("sent_tot_anio") & " AÑO(S) " & f("sent_tot_meses") & " MES(ES) " & f("sent_tot_dias") & " DIAS, " & f("periodo_condena") & " "
            '            End If
            '            head = head & " " & condenas

            '        Case enumTipoDocumentoJudicial.Sentencia, enumTipoDocumentoJudicial.Sentencia_Aclaratoria, enumTipoDocumentoJudicial.Sent_Sustitucion_Pena,
            '             enumTipoDocumentoJudicial.Sent_Adecuacion_Pena, enumTipoDocumentoJudicial.Sent_Conmutacion_Pena, enumTipoDocumentoJudicial.ResolucionConsentida,
            '             enumTipoDocumentoJudicial.Ejecutoria_Suprema, enumTipoDocumentoJudicial.Resolucion_Superior,
            '            enumTipoDocumentoJudicial.Resolucion, enumTipoDocumentoJudicial.Resolucion, enumTipoDocumentoJudicial.Revocatoria
            '            Dim aut As String = ""
            '            Dim fecSent As String = ""
            '            Dim sentConsen As String = ""

            '            Select Case f("res_tip_aut_jud_id")
            '                Case -1
            '                    aut = ""
            '                Case 1
            '                    aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
            '                Case Else
            '                    aut = f("res_aut_otro_cargo")
            '            End Select
            '            If f("sent_consentida") = 1 Or f("sent_consentida") = True Then
            '                sentConsen = " CONSENTIDA"
            '            End If

            '            If f.Item("fecha_sent") = 0 Then
            '                fecSent = ", F. SENTENCIA: "
            '            Else
            '                fecSent = ", F. SENTENCIA: " & Legolas.Components.FechaHora.FechaDate(f.Item("fecha_sent"))
            '            End If

            '            head = "FECHA DOC.: " & fecDocStr &
            '                    ", ORDENA JUZGADO/SALA: " & aut.ToUpper & " CON DOC. N°: " & f.Item("res_doc_jud_num") & sentConsen & ", SECRETARIO: " & f("res_nom_secre") &
            '                   fecSent


            '            If f("sent_cad_perpet") = 1 Or f("sent_cad_perpet") = True Then
            '                condenas = "CADENA PERPETUA"
            '            Else
            '                condenas = "CONDENADO A " & f("sent_tot_anio") & " AÑO(S) " & f("sent_tot_meses") & " MES(ES) " & f("sent_tot_dias") & " DIAS " & f("periodo_condena") & " "
            '            End If
            '            head = head & " " & condenas

            '        Case enumTipoDocumentoJudicial.Sent_Pena_Limitativa
            '            Dim aut As String = ""
            '            Dim fecSent As String = ""

            '            Select Case f("res_tip_aut_jud_id")
            '                Case -1
            '                    aut = ""
            '                Case 1
            '                    aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
            '                Case Else
            '                    aut = f("res_aut_otro_cargo")
            '            End Select

            '            If f.Item("fecha_sent") = 0 Then
            '                fecSent = ", F. SENTENCIA: "
            '            Else
            '                fecSent = ", F. SENTENCIA: " & Legolas.Components.FechaHora.FechaDate(f.Item("fecha_sent"))
            '            End If

            '            head = "FECHA DOC.: " & fecDocStr &
            '                    ", ORDENA JUZGADO/SALA: " & aut.ToUpper & " CON DOC. N°: " & f.Item("res_doc_jud_num") & ", SECRETARIO: " & f("res_nom_secre") &
            '                   fecSent & " Jornadas: " & f("prol_det_cant")

            '            head = head & " " & condenas

            '        Case enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD, enumTipoDocumentoJudicial.Ejecutoria_Superior
            '            Dim aut As String = ""
            '            Dim fecSent As String = ""

            '            Select Case f("res_tip_aut_jud_id")
            '                Case -1
            '                    aut = ""
            '                Case 1
            '                    aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
            '                Case Else
            '                    aut = f("res_aut_otro_cargo")
            '            End Select

            '            If f.Item("fecha_sent") = 0 Then
            '                fecSent = ", F. SENTENCIA: "
            '            Else
            '                fecSent = ", F. SENTENCIA: " & Legolas.Components.FechaHora.FechaDate(f.Item("fecha_sent"))
            '            End If

            '            head = "FECHA DOC.: " & fecDocStr &
            '                    ", ORDENA JUZGADO/SALA: " & aut.ToUpper & " CON DOC. N°: " & f.Item("res_doc_jud_num") & ", SECRETARIO: " & f("res_nom_secre") &
            '                   fecSent

            '            If f("sent_cad_perpet") = True Then
            '                condenas = "CADENA PERPETUA"
            '            Else
            '                condenas = "CONDENADO A " & f("sent_tot_anio") & " AÑO(S) " & f("sent_tot_meses") & " MES(ES) " & f("sent_tot_dias") & " DIAS " & f("periodo_condena") & " "
            '            End If

            '            head = head & " " & condenas

            '        Case enumTipoDocumentoJudicial.Anulacion_Antecedentes '34
            '            objEnt.Detalle = f.Item("res_tipoDocNom").ToString.ToUpper
            '            head = "TIPO: " & f.Item("DocSubTipoNom").ToString.ToUpper & ", FECHA DOC.: " & fecDocStr &
            '                ", ORDENA: " & f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud") & " CON DOC. N°: " & f.Item("res_doc_jud_num") &
            '                ", SECRETARIO: " & f("res_nom_secre") & "." & vbCrLf & f.Item("doc_anu").ToString.ToUpper
            '    End Select

            '    Dim det As DataRow()
            '    det = t.Select("doc_jud_id=" & objEnt.Codigo)
            '    Dim descrip As String = ""
            '    For Each d As DataRow In det
            '        If tipoDoc = enumTipoDocumentoJudicial.Notas Or tipoDoc = enumTipoDocumentoJudicial.Notas_Egreso Or tipoDoc = enumTipoDocumentoJudicial.Traslado Or
            '            (tipoDoc = enumTipoDocumentoJudicial.Aclaratoria And f.Item("DocSubTipoNom").ToString.ToUpper = "ACLARATORIA DE NOMBRE") Then
            '            Continue For
            '        End If
            '        Dim strTipLib As String = ""
            '        If tipoDoc = 6 Then
            '            strTipLib = ", TIPO LIBERTAD: " & d.Item("tipolibertadExp").ToString.ToUpper
            '        End If
            '        If (tipoDoc = 14 And f.Item("doc_jud_est_id") = 3) Then
            '        Else
            '            If tipoDoc = enumTipoDocumentoJudicial.Ejecutoria_Suprema Or tipoDoc = enumTipoDocumentoJudicial.Sentencia Or tipoDoc = enumTipoDocumentoJudicial.Sentencia_Aclaratoria Or
            '                tipoDoc = enumTipoDocumentoJudicial.Sent_Adecuacion_Pena Or tipoDoc = enumTipoDocumentoJudicial.Sent_Conmutacion_Pena Or tipoDoc = enumTipoDocumentoJudicial.Ejecutoria_Superior Or
            '                tipoDoc = enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD Or tipoDoc = enumTipoDocumentoJudicial.Integracion_Sentencia Or tipoDoc = enumTipoDocumentoJudicial.Refundicion_de_Sentencia Or
            '                tipoDoc = enumTipoDocumentoJudicial.Resolucion Or tipoDoc = enumTipoDocumentoJudicial.Resolucion_Superior Or tipoDoc = enumTipoDocumentoJudicial.Revocatoria Or
            '                tipoDoc = enumTipoDocumentoJudicial.Sent_Pena_Limitativa Or tipoDoc = enumTipoDocumentoJudicial.Sumatoria_de_Sentencia Or tipoDoc = enumTipoDocumentoJudicial.Sent_Sustitucion_Pena Then

            '                descrip = descrip & vbCrLf & "EXP. N°: " & d.Item("exp_int_ing_exp_num") & ", SALA/JUZGADO: " & d.Item("exp_sala_jud") & ", SECRETARIO: " & d.Item("int_exp_sec") & d.Item("declara_exp_sent") & strTipLib & "." & vbCrLf &
            '                         "DELITO: " & d.Item("delitos_sent") & ". "
            '            Else

            '                descrip = descrip & vbCrLf & "EXP. N°: " & d.Item("exp_int_ing_exp_num") & ", SALA/JUZGADO: " & d.Item("exp_sala_jud") & ", SECRETARIO: " & d.Item("int_exp_sec") & d.Item("declara_exp_sent") & strTipLib & "." & vbCrLf &
            '                          "DELITO: " & d.Item("delitos") & ". "
            '            End If

            '        End If

            '        tipoDoc = Integer.Parse(f.Item("res_tip_resol_id").ToString)
            '    Next

            '    objEnt.Descripcion = (head & " " & descrip & " " & obs_doc).ToUpper

            '    objEnt.DocJudicialEstadoId = f.Item("doc_jud_est_id")
            '    objEnt.IngresoInpeId = f.Item("fk_ing_inp_id")
            '    list.Add(objEnt)
            'Next

            ''agregar ingresoInpe en una lista (sin repetir)
            'Dim listIngInp As New List(Of Integer)
            'For Each ent As Entity.Registro.Antecedente.DetalleAntecedente In list
            '    listIngInp.Add(ent.IngresoInpeId)
            'Next

            'Dim lst = listIngInp.Distinct

            ''si existe una sola resol (anulado) por ingreso, limpiar
            'For Each n_ingInpId As Integer In lst
            '    Dim existeOtroDoc As Boolean = False
            '    Dim limpiarLista As Boolean = True

            '    Dim tmpList = From d As Entity.Registro.Antecedente.DetalleAntecedente In list Where d.IngresoInpeId = n_ingInpId 'listar x ingresoInpe

            '    For Each ent As Entity.Registro.Antecedente.DetalleAntecedente In tmpList
            '        If ent.TipoDocJudicialId <> 14 And n_ingInpId = ent.IngresoInpeId Then '
            '            existeOtroDoc = True
            '            Exit For
            '        End If
            '    Next

            '    If existeOtroDoc = False Then
            '        For Each ent As Entity.Registro.Antecedente.DetalleAntecedente In tmpList
            '            If ent.TipoDocJudicialId = 14 And ent.DocJudicialEstadoId <> 3 And ent.IngresoInpeId = n_ingInpId Then '
            '                limpiarLista = False
            '            End If
            '        Next

            '        If limpiarLista = True Then

            '            While True 'eliminar todo del ingresoInpe actual
            '                Dim llegoAlFinal As Boolean = True
            '                For i As Integer = 0 To list.Count - 1
            '                    If list.DetalleAntecedente(i).IngresoInpeId = n_ingInpId Then
            '                        list.RemoveAt(i)
            '                        llegoAlFinal = False
            '                        Exit For
            '                    End If
            '                Next
            '                If llegoAlFinal = True Then
            '                    Exit While
            '                End If
            '            End While

            '        End If

            '    End If
            'Next

            'Dim lsNew As Entity.Registro.Antecedente.DetalleAntecedenteCol
            'lsNew = OrdenarOdcJudicial(list)

            'Return lsNew
        End Function

        ''' <summary>
        ''' Autor: Hugo N. Rosario
        ''' Fecha:09/07/2018
        ''' Retorna los antecedentes del interno desde el historico de datos migrados, solo válido para registros migrados del SRP Sybase.
        ''' </summary>
        ''' <param name="SolAntJudId"></param>
        ''' <returns></returns>


        Public Function ListarGrilla(ByVal Ent As Entity.Registro.Antecedente.SolicitudAntecedente) As Entity.Registro.Antecedente.SolicitudAntecedenteCol
            Dim list As New Entity.Registro.Antecedente.SolicitudAntecedenteCol
            Dim objEnt As Entity.Registro.Antecedente.SolicitudAntecedente

            Ent.FechaHasta = If(Ent.FechaHasta <> 0, System.DateTime.FromFileTime(Ent.FechaHasta).AddDays(1).ToFileTime, 0) 'a las 00H:00M:00S del dia siguiente

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim dr As SqlDataReader = Data.Registro.Antecedente.SolicitudAntecedente.Listar(sqlCon, "lst", "lst_grilla", Ent)

            Try
                If dr.HasRows Then
                    While dr.Read
                        objEnt = New Entity.Registro.Antecedente.SolicitudAntecedente
                        With objEnt
                            .Codigo = dr("pk_sol_ant_id").ToString
                            .Anio = dr("n_num_anio").ToString
                            .NumeroCorrelativo = dr("n_num_corr").ToString
                            '.CodigoPenal = dr("n_pen_cod").ToString
                            .MotivoSolicitudStr = dr("mot_sol_ant").ToString
                            .FechaSolicitud = dr("n_fec_sol").ToString
                            .EstadoSolicitudId = dr("n_est_id").ToString
                            .DocumentoFecha = dr("n_fec_doc").ToString
                            .DocumentoNumero = dr("c_num_doc").ToString
                            .TipoAntecedenteId = dr("n_tip_cert_id").ToString
                            .NumImpresiones = dr("num_print").ToString
                            '.MotivoSolicitudId = dr("fk_mot_sol_aj_id").ToString
                            '.TipoAutoridadJudicial = dr("fk_tip_aut_jud_id").ToString
                            '.SolDistritoJudicialId = dr("fk_dis_jud_id").ToString
                            '.SolSalaJudicialId = dr("fk_sal_jud_id").ToString
                            '.SolNombreJuez = dr("c_doc_jud_jue").ToString
                            '.SolNombreSecretario = dr("c_doc_jud_sec").ToString
                            '.SolNombreEntidad = dr("c_nom_ent").ToString
                            '.Observacion = dr("c_obs").ToString
                            '.RegionId = dr("regid").ToString
                            '.PenalId = dr("penid").ToString
                            .InternoApePaterno = dr("sc_int_ape_pat").ToString
                            .InternoApeMaterno = dr("c_int_ape_mat").ToString
                            .InternoNombres = dr("c_int_nom").ToString
                            .UsuarioCrea = dr("usu_cre").ToString
                            '.InternoCodigo = dr("c_int_cod").ToString
                            '.InternoNombresAsociados = dr("c_int_nom_aso").ToString
                            '.InternoId = dr("int_id").ToString
                        End With
                        list.Add(objEnt)
                    End While
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
            Return list
        End Function

        Public Function ListarGrilla_LM(ByVal Ent As Entity.Registro.Antecedente.SolicitudAntecedente) As Entity.Registro.Antecedente.SolicitudAntecedenteCol
            Dim list As New Entity.Registro.Antecedente.SolicitudAntecedenteCol
            Dim objEnt As Entity.Registro.Antecedente.SolicitudAntecedente

            Ent.FechaHasta = If(Ent.FechaHasta <> 0, System.DateTime.FromFileTime(Ent.FechaHasta).AddDays(1).ToFileTime, 0) 'a las 00H:00M:00S del dia siguiente

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim dr As SqlDataReader = Data.Registro.Antecedente.SolicitudAntecedente.Listar(sqlCon, "lst", "lst_grilla_lm", Ent)

            Try
                If dr.HasRows Then
                    While dr.Read
                        objEnt = New Entity.Registro.Antecedente.SolicitudAntecedente
                        With objEnt
                            .Codigo = dr("pk_sol_ant_id").ToString
                            .Anio = dr("n_num_anio").ToString
                            .NumeroCorrelativo = dr("n_num_corr").ToString
                            '.CodigoPenal = dr("n_pen_cod").ToString
                            .MotivoSolicitudStr = dr("mot_sol_ant").ToString
                            .FechaSolicitud = dr("n_fec_sol").ToString
                            .EstadoSolicitudId = dr("n_est_id").ToString
                            .DocumentoFecha = dr("n_fec_doc").ToString
                            .DocumentoNumero = dr("c_num_doc").ToString
                            .TipoAntecedenteId = dr("n_tip_cert_id").ToString
                            .NumImpresiones = dr("num_print").ToString
                            .SolicitantePenalId = dr("fk_sol_pen_id").ToString
                            .SolicitanteRegionId = dr("fk_sol_reg_id").ToString
                            '.MotivoSolicitudId = dr("fk_mot_sol_aj_id").ToString
                            '.TipoAutoridadJudicial = dr("fk_tip_aut_jud_id").ToString
                            '.SolDistritoJudicialId = dr("fk_dis_jud_id").ToString
                            '.SolSalaJudicialId = dr("fk_sal_jud_id").ToString
                            '.SolNombreJuez = dr("c_doc_jud_jue").ToString
                            '.SolNombreSecretario = dr("c_doc_jud_sec").ToString
                            '.SolNombreEntidad = dr("c_nom_ent").ToString
                            '.Observacion = dr("c_obs").ToString
                            '.RegionId = dr("regid").ToString
                            '.PenalId = dr("penid").ToString
                            .InternoApePaterno = dr("sc_int_ape_pat").ToString
                            .InternoApeMaterno = dr("c_int_ape_mat").ToString
                            .InternoNombres = dr("c_int_nom").ToString
                            .UsuarioCrea = dr("usu_cre").ToString
                            .AmbitoJurisdiccionAut = dr("n_amb_jur_aut_id").ToString
                            .DataHistoricaMigracion = dr("b_data_migra").ToString
                            '.InternoCodigo = dr("c_int_cod").ToString
                            '.InternoNombresAsociados = dr("c_int_nom_aso").ToString
                            '.InternoId = dr("int_id").ToString
                            .IncluyeAnulaciones = dr("n_inc_anu").ToString
                        End With
                        list.Add(objEnt)
                    End While
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
            Return list
        End Function

        Public Function Listar(ByVal Ent As Entity.Registro.Antecedente.SolicitudAntecedente) As Entity.Registro.Antecedente.SolicitudAntecedenteCol
            Dim list As New Entity.Registro.Antecedente.SolicitudAntecedenteCol
            Dim objEnt As Entity.Registro.Antecedente.SolicitudAntecedente

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim dr As SqlDataReader = Data.Registro.Antecedente.SolicitudAntecedente.Listar(sqlCon, "lst", "lst_mant", Ent)
            Try
                If dr.HasRows Then
                    While dr.Read
                        objEnt = New Entity.Registro.Antecedente.SolicitudAntecedente
                        With objEnt
                            .Codigo = dr("pk_sol_ant_id").ToString
                            .Anio = dr("n_num_anio").ToString
                            .DocumentoFecha = dr("n_fec_doc").ToString
                            .DocumentoNumero = dr("c_num_doc").ToString
                            '.CodigoPenal = dr("n_pen_cod").ToString
                            .NumeroCorrelativo = dr("n_num_corr").ToString
                            .FechaSolicitud = dr("n_fec_sol").ToString
                            .EstadoSolicitudId = dr("n_est_id").ToString
                            .MotivoSolicitudId = dr("fk_mot_sol_aj_id").ToString
                            .TipoAutoridadJudicial = dr("fk_tip_aut_jud_id").ToString
                            .TipoAntecedenteId = dr("n_tip_cert_id").ToString
                            .AmbitoJurisdiccionAut = dr("n_amb_jur_aut_id").ToString
                            .GlosaDocId = dr("fk_glo_doc_id").ToString
                            .SolDistritoJudicialId = dr("fk_dis_jud_id").ToString
                            .SolSalaJudicialId = dr("fk_sal_jud_id").ToString
                            .SolNombreJuez = dr("c_doc_jud_jue").ToString
                            .SolNombreSecretario = dr("c_doc_jud_sec").ToString
                            .SolNombreEntidad = dr("c_nom_ent").ToString
                            .Observacion = dr("c_obs").ToString
                            .ReporteCabeceraId = dr("fk_rpt_cab_id").ToString
                            .SolicitantePenalId = dr("fk_sol_pen_id").ToString
                            .SolicitanteRegionId = dr("fk_sol_reg_id").ToString
                            .PenalNom = dr("pen_nom").ToString
                            .InternoApePaterno = dr("sc_int_ape_pat").ToString
                            .InternoApeMaterno = dr("c_int_ape_mat").ToString
                            .InternoNombres = dr("c_int_nom").ToString
                            .InternoCodigo = dr("c_int_cod").ToString
                            .InternoNombresAsociados = dr("c_int_nom_aso").ToString
                            .InternoId = dr("int_id").ToString
                            .NombreAutoridadSolicitante = dr("aut_sol_nom").ToString.ToUpper
                            .MotivoSolicitudStr = dr("mot_sol").ToString.ToUpper
                            .InternoTipoDocIdentidad = dr("c_int_tip_doc_id").ToString
                            .InternoNumDocIdentidad = dr("c_int_num_doc").ToString
                            .IncluyeAnulaciones = dr("n_inc_anu").ToString
                            .RegionId = dr("_regid").ToString
                            .PenalId = dr("_penid").ToString
                        End With
                        list.Add(objEnt)
                    End While
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
            Return list
        End Function

        Public Function ListarGrilla_Penal(ByVal objEntFiltro As Entity.Registro.Antecedente.SolicitudAntecedente) As Entity.Registro.Antecedente.SolicitudAntecedenteCol

            Dim objEntCol As New Entity.Registro.Antecedente.SolicitudAntecedenteCol

            objEntFiltro.FechaHasta = If(objEntFiltro.FechaHasta <> 0, System.DateTime.FromFileTime(objEntFiltro.FechaHasta).AddDays(1).ToFileTime, 0) 'a las 00H:00M:00S del dia siguiente

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim dr As SqlDataReader = Data.Registro.Antecedente.SolicitudAntecedente.Listar(sqlCon, "lst", "lst_grilla_penal", objEntFiltro)
            Dim objEnt As Entity.Registro.Antecedente.SolicitudAntecedente

            Try
                If dr.HasRows Then
                    While dr.Read
                        objEnt = New Entity.Registro.Antecedente.SolicitudAntecedente
                        With objEnt
                            .Codigo = dr("pk_sol_ant_id").ToString
                            .Anio = dr("n_num_anio").ToString
                            .NumeroCorrelativo = dr("n_num_corr").ToString
                            .MotivoSolicitudStr = dr("mot_sol_ant").ToString
                            .FechaSolicitud = dr("n_fec_sol").ToString
                            .EstadoSolicitudId = dr("n_est_id").ToString
                            .DocumentoFecha = dr("n_fec_doc").ToString
                            .DocumentoNumero = dr("c_num_doc").ToString
                            .TipoAntecedenteId = dr("n_tip_cert_id").ToString
                            .NumImpresiones = dr("num_print").ToString
                            .SolicitantePenalId = dr("fk_sol_pen_id").ToString
                            .SolicitanteRegionId = dr("fk_sol_reg_id").ToString
                            .RegionId = dr("reg_id").ToString
                            .RegionNombre = dr("reg_nom").ToString
                            .InternoApePaterno = dr("sc_int_ape_pat").ToString
                            .InternoApeMaterno = dr("c_int_ape_mat").ToString
                            .InternoNombres = dr("c_int_nom").ToString
                            .UsuarioCrea = dr("usu_cre").ToString
                            .AmbitoJurisdiccionAut = dr("n_amb_jur_aut_id").ToString
                            .DataHistoricaMigracion = dr("b_data_migra").ToString
                            .IncluyeAnulaciones = dr("n_inc_anu").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
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
            Return objEntCol
        End Function

        Public Function ListarDocumentoJudiciales_Penal(intIDRegion As Short, intIDpenal As Short, intIDInterno As Integer,
                                                        ByVal MostrarAnulaciones As Boolean) As Entity.Registro.Antecedente.DetalleAntecedenteCol

            'jmr, 21.04.2020, listar los documentos judiciales del interno, para los penales de provincia.
            'jmr, 22.06.2020

            Dim list As New Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim t As New DataTable
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim dr As SqlDataReader
            Dim intMostrarDocAnu As Short = 0

            If MostrarAnulaciones = True Then
                intMostrarDocAnu = 1
            End If

            dr = Data.Registro.Reporte.HistorialAntecedente.Listar(sqlCon, "lst", "lst_historial_antecedente_provincia", intIDRegion, intIDpenal, intIDInterno, intMostrarDocAnu)

            Try
                If dr.HasRows Then
                    t.Load(dr)
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

            Dim lsNew As Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim objBss As New Bussines.Registro.Reporte.AntecedenteJudicial

            lsNew = objBss.generarAntecedente(t, MostrarAnulaciones)

            Return lsNew
        End Function
#End Region

        'Private Function OrdenarOdcJudicial(list As Entity.Registro.Antecedente.DetalleAntecedenteCol) As Entity.Registro.Antecedente.DetalleAntecedenteCol

        '    Dim l2 As New Entity.Registro.Antecedente.DetalleAntecedenteCol
        '    For Each o As Entity.Registro.Antecedente.DetalleAntecedente In list
        '        Select Case o.TipoDocJudicialId
        '            Case enumTipoDocumentoJudicial.Detencion
        '                o.NumOrden = 1
        '            Case enumTipoDocumentoJudicial.DetencionCarceleta = 35
        '                o.NumOrden = 2
        '            Case enumTipoDocumentoJudicial.Internamiento, enumTipoDocumentoJudicial.Ingreso
        '                o.NumOrden = 3
        '            Case enumTipoDocumentoJudicial.Rectificacion_Nombres
        '                o.NumOrden = 4
        '            Case enumTipoDocumentoJudicial.Anulacion_Nombres
        '                o.NumOrden = 5
        '            Case enumTipoDocumentoJudicial.Notas
        '                o.NumOrden = 6
        '            Case enumTipoDocumentoJudicial.Traslado
        '                o.NumOrden = 7
        '            Case enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
        '                o.NumOrden = 8
        '            Case enumTipoDocumentoJudicial.Prolongacion_Detencion
        '                o.NumOrden = 9
        '            Case enumTipoDocumentoJudicial.Aclaratoria
        '                o.NumOrden = 10
        '            Case enumTipoDocumentoJudicial.Avocamiento
        '                o.NumOrden = 11
        '            Case enumTipoDocumentoJudicial.Conducciones
        '                o.NumOrden = 12
        '            Case enumTipoDocumentoJudicial.AcumulacionExpedientes
        '                o.NumOrden = 14
        '            Case enumTipoDocumentoJudicial.Sentencia
        '                o.NumOrden = 15
        '            Case enumTipoDocumentoJudicial.Nota_Sentencia
        '                o.NumOrden = 16
        '            Case enumTipoDocumentoJudicial.Sentencia_Aclaratoria
        '                o.NumOrden = 17
        '            Case enumTipoDocumentoJudicial.Refundicion_de_Sentencia
        '                o.NumOrden = 18
        '            Case enumTipoDocumentoJudicial.Integracion_Sentencia
        '                o.NumOrden = 19
        '            Case enumTipoDocumentoJudicial.Ejecutoria_Suprema
        '                o.NumOrden = 20
        '            Case enumTipoDocumentoJudicial.Ejecutoria_Superior
        '                o.NumOrden = 21
        '            Case enumTipoDocumentoJudicial.Sent_Sustitucion_Pena
        '                o.NumOrden = 22
        '            Case enumTipoDocumentoJudicial.Sent_Adecuacion_Pena
        '                o.NumOrden = 23
        '            Case enumTipoDocumentoJudicial.Sent_Conmutacion_Pena
        '                o.NumOrden = 24
        '            Case enumTipoDocumentoJudicial.ResolucionConsentida
        '                o.NumOrden = 25
        '            Case enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
        '                o.NumOrden = 26
        '            Case enumTipoDocumentoJudicial.Resolucion
        '                o.NumOrden = 27
        '            Case enumTipoDocumentoJudicial.Resolucion_Superior
        '                o.NumOrden = 28
        '            Case enumTipoDocumentoJudicial.Sent_Pena_Limitativa
        '                o.NumOrden = 29
        '            Case enumTipoDocumentoJudicial.Revocatoria
        '                o.NumOrden = 30
        '            Case enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD
        '                o.NumOrden = 31
        '            Case enumTipoDocumentoJudicial.Anulacion_Antecedentes
        '                o.NumOrden = 32
        '            Case enumTipoDocumentoJudicial.Libertad
        '                o.NumOrden = 33
        '            Case enumTipoDocumentoJudicial.Revocatoria_de_Libertad
        '                o.NumOrden = 34
        '            Case enumTipoDocumentoJudicial.Notas_Egreso
        '                o.NumOrden = 35
        '            Case enumTipoDocumentoJudicial.Queda
        '                o.NumOrden = 36
        '        End Select
        '    Next

        '    'Dim result = From d As Entity.Registro.Antecedente.DetalleAntecedente In list Order By d.IngresoNum, d.FechaRecepDocLong, d.NumOrden, d.FechaDocLong
        '    Dim result = From d As Entity.Registro.Antecedente.DetalleAntecedente In list Order By d.IngresoNum, d.FechaRecepDocLong, d.FechaCreaReg ' d.FechaDocLong
        '    For Each obj As Entity.Registro.Antecedente.DetalleAntecedente In result
        '        l2.Add(obj)
        '    Next
        '    'ordenar por fecha y puntaje
        '    Return l2
        'End Function

#Region "Accion"
        Private Function Validar(ent As Entity.Registro.Antecedente.SolicitudAntecedente, ByRef outSMS As String) As Boolean
            Dim v As Boolean = True
            Dim sms As String = ""

            If ent.InternoCodigo.Trim.Length = 0 And ent.InternoId > 0 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "Código de interno no válido"
            If ent.TipoAutoridadJudicial = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "Falta seleccionar el tipo de autoridad"

            If ent.FechaSolicitud > Now.ToFileTime Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "Fecha de solicitud no puede ser futuro"
            If ent.DocumentoFecha > Now.ToFileTime Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "La fecha del documento no puede ser futuro"

            If ent.MotivoSolicitudId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "Falta seleccionar el motivo de solicitud"
            'If ent.PenalId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "PenalId incorrecto"
            'If ent.RegionId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "RegionId incorrecto"
            If ent.Codigo > 0 Then 'si modificar
                If ent.Anio = 0 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "Año incorrecto"
                If ent.NumeroCorrelativo = 0 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "Correlativo de solicitud incorrecto"
            End If

            If sms.Length > 0 Then
                v = False
                outSMS = sms
            End If


            Return v
        End Function

        Public Function Grabar(ent As Entity.Registro.Antecedente.SolicitudAntecedente, ByRef outSMS As String) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Validar(ent, outSMS) = False Then Return -1

            If ent.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.Antecedente.SolicitudAntecedente.Grabar(strAccion, strOpcion, ent, outSMS)

            Return intValue

        End Function

        Public Function CambiarEstado(intCodigo As Integer, intIDEstado As Integer, ByRef outSMS As String, Optional ByVal strMotivoAnulacion As String = "",
                                      Optional ByVal lngFechaAnulacion As Long = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_estado"

            Dim objEnt As New Entity.Registro.Antecedente.SolicitudAntecedente
            objEnt.Codigo = intCodigo
            objEnt.EstadoSolicitudId = intIDEstado

            'si es anulacion de registro
            If intIDEstado = 3 Then
                objEnt.MotivoAnulacion = strMotivoAnulacion
                objEnt.FechaAnulacion = lngFechaAnulacion
            End If

            intValue = Data.Registro.Antecedente.SolicitudAntecedente.Grabar(strAccion, strOpcion, objEnt, outSMS)

            Return intValue

        End Function

        Public Function VicularConReporte(Codigo As Integer, CabeceraReporteId As Integer, ByRef outSMS As String) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_vinc_reporte"

            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            ent.Codigo = Codigo
            ent.ReporteCabeceraId = CabeceraReporteId

            intValue = Data.Registro.Antecedente.SolicitudAntecedente.Grabar(strAccion, strOpcion, ent, outSMS)

            Return intValue

        End Function

        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            If Codigo = -1 Then Return -1

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.Antecedente.SolicitudAntecedente.Eliminar(strAccion, strOpcion, Codigo)

            Return intValue
        End Function
#End Region

    End Class
End Namespace