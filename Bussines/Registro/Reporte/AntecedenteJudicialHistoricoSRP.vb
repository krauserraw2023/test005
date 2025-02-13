Imports System.Data.SqlClient
Imports Type.Enumeracion.TipoDocJudicial
Imports System.Linq

Namespace Registro.Reporte
    Public Class AntecedenteJudicialHistoricoSRP
        Public Function ListarDetalleAntJudPositivo(SolAntJudId As Integer) As Entity.Registro.Antecedente.DetalleAntecedenteCol

            Dim list As New Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim t As New DataTable
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim dr As SqlDataReader = Data.Registro.Reporte.AntecedenteJudicial.ListarDetalleCertAntJud_Sybase(sqlCon, "lst", "lst_ant_jud_historico_dato_sybase",
                                                                                                                                  SolAntJudId)
            Dim objEnt As Entity.Registro.Antecedente.DetalleAntecedente = Nothing

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

            Dim tmae As DataTable = t.DefaultView.ToTable(True, "doc_jud_id", "fec_recep_doc", "res_tipoDocNom", "res_tip_resol_id", "sent_cad_perpet", "periodo_condena",
                                                      "res_pen_des_nom", "res_doc_jud_num", "doc_jud_obs", "fecha_sent", "res_sala_jud", "res_autoridad_jud", "sent_tot_dias",
                                                      "sent_tot_meses", "sent_tot_anio", "res_pen_orig_nom", "res_mov_mot_nom",
                                                      "fec_doc", "res_tip_aut_jud_id", "doc_fec_mov", "prol_det_ini_fec",
                                                      "prol_det_fin_fec", "DocSubTipoNom", "res_tip_aut_jud", "res_nom_secre", "sent_consentida", "int_ing_nro",
                                                       "res_pen_ori_otr", "res_pen_des_otr", "fec_crea_reg", "prol_det_cant")

            For Each f As DataRow In tmae.Rows
                objEnt = New Entity.Registro.Antecedente.DetalleAntecedente

                objEnt.Codigo = f.Item("doc_jud_id")
                objEnt.Fecha = f.Item("fec_recep_doc")
                objEnt.Detalle = f.Item("res_tipoDocNom").ToString.ToUpper

                objEnt.TipoDocJudicialId = f.Item("res_tip_resol_id") ''tipo de documento judicial
                objEnt.FechaRecepDocLong = f.Item("fec_recep_doc") 'fecha de recepcion long
                objEnt.IngresoNum = f.Item("int_ing_nro")
                objEnt.FechaDocLong = f.Item("fec_doc")
                objEnt.FechaCreaReg = f.Item("fec_crea_reg")

                Dim tipoDoc As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial
                Dim head As String = ""
                Dim obs_doc As String = ""
                Dim condenas As String = ""
                Dim fecDocStr As String = ""
                Dim fecRecepDocStr As String = ""
                Dim fecMovStr As String = ""
                Dim fecProlIniStr As String = ""
                Dim fecProlFinStr As String = ""
                Dim fecSentStr As String = ""

                obs_doc = If(f("doc_jud_obs").ToString.Trim.Length > 0, vbCrLf + "OBSERVACIONES: " & f("doc_jud_obs").ToString.Trim.ToUpper, "")
                tipoDoc = Integer.Parse(f.Item("res_tip_resol_id").ToString)
                fecDocStr = If(f("fec_doc") = 0, "N/I", DateTime.FromFileTime(f("fec_doc")))
                fecRecepDocStr = If(f("fec_recep_doc") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(f.Item("fec_recep_doc")))
                fecMovStr = If(f("doc_fec_mov") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(f.Item("doc_fec_mov")))
                fecProlIniStr = If(f("prol_det_ini_fec") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(f.Item("prol_det_ini_fec")))
                fecProlFinStr = If(f("prol_det_fin_fec") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(f.Item("prol_det_fin_fec")))
                fecSentStr = If(f("fecha_sent") = 0, "N/I", Legolas.Components.FechaHora.FechaDate(f.Item("fecha_sent")))

                Select Case tipoDoc
                    Case enumTipoDocumentoJudicial.Queda
                        head = "FECHA DOC.: " & fecDocStr &
                        ", ORDENA: " & f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud") & " CON DOC. N°: " & f.Item("res_doc_jud_num") & ", SECRETARIO: " & f("res_nom_secre")
                    Case enumTipoDocumentoJudicial.Revocatoria_de_Libertad
                        head = "FECHA DOC.: " & fecDocStr &
                        ", ORDENA: " & f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud") & " CON DOC. N°: " & f.Item("res_doc_jud_num") & ", SECRETARIO: " & f("res_nom_secre")
                    Case enumTipoDocumentoJudicial.Traslado '5
                        Dim penOri As String = ""
                        Dim penDest As String = ""
                        Dim ordena As String = ""

                        If f("res_pen_orig_nom") = "" Or f("res_pen_orig_nom") = "NO INDICA" Then
                            penOri = f("res_pen_ori_otr")
                        Else
                            'If f("pen_orig_id") = 35 Then
                            '    penOri = " E.T. " & f("res_pen_orig_nom")
                            'Else
                            penOri = " E.P. " & f("res_pen_orig_nom")
                            'End If
                        End If

                        If f("res_pen_des_nom") = "" Or f("res_pen_des_nom") = "NO INDICA" Then
                            penDest = f("res_pen_des_otr")
                        Else
                            'If f("pen_des_id") = 35 Then
                            '    penDest = " E.T. " & f("res_pen_des_nom")
                            'Else
                            penDest = " E.P. " & f("res_pen_des_nom")
                            'End If
                        End If

                        ordena = f.Item("res_tip_aut_jud")


                        head = "FECHA DOC.: " & fecDocStr & " FECHA MOV: " & fecMovStr &
                        ", ORDENA: " & ordena.ToUpper & " CON DOC. N°: " & f("res_doc_jud_num") & ", POR " & f("res_mov_mot_nom") & " DE " & penOri & " A " & penDest
                    Case enumTipoDocumentoJudicial.Libertad '6
                        Dim aut As String = ""
                        Select Case f("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
                            Case Else
                                aut = "" 'f("res_aut_otro_cargo")
                        End Select
                        objEnt.Fecha = f.Item("doc_fec_mov") 'Se debe mostrar fecha de libertad del doc, solicitud ORL coordinacion Gerardo V. 15/06/2018
                        head = "FECHA DOC.: " & fecDocStr & ", TIPO LIBERTAD: " & f("res_mov_mot_nom").ToString.ToUpper & ", FECHA LIBERTAD: " & fecMovStr &
                           ", ORDENA JUZGADO/SALA: " & aut.ToUpper & ", CON DOC. N°: " & f("res_doc_jud_num") & " DE FECHA " & fecDocStr & ", SECRETARIO: " & f("res_nom_secre")
                    Case enumTipoDocumentoJudicial.Prolongacion_Detencion '10
                        head = "FECHA DOC.: " & fecDocStr &
                        ", F. INICIO: " & fecProlIniStr &
                        " F. FINAL: " & fecProlFinStr &
                        ", ORDENA: " & f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud") & " SECRETARIO: " & f("res_nom_secre") & ", CON DOC. N°: " & f.Item("res_doc_jud_num")

                    Case enumTipoDocumentoJudicial.Detencion '12
                        head = "FECHA DOC.: " & fecDocStr
                    Case enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                        head = "FECHA DOC.: " & fecDocStr &
                        ", ORDENA " & f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud") & " CON DOC. N°: " & f.Item("res_doc_jud_num")
                    Case enumTipoDocumentoJudicial.Avocamiento '9,11
                        Dim aut As String = ""
                        Select Case f("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
                            Case Else
                                aut = "" 'f("res_aut_otro_cargo")
                        End Select
                        Dim sentConsen As String = ""

                        head = "FECHA DOC.: " & fecDocStr &
                            ", ORDENA: " & aut.ToUpper & " CON OFICIO N°: " & f.Item("res_doc_jud_num") & sentConsen & ", SECRETARIO: " & f("res_nom_secre")

                    Case enumTipoDocumentoJudicial.Aclaratoria '13
                        Dim aut As String = ""
                        Select Case f("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
                            Case Else
                                aut = "" 'f("res_aut_otro_cargo")
                        End Select
                        objEnt.Detalle = "ACLARATORIA" '
                        Dim subTipNom As String = ""
                        If f.Item("DocSubTipoNom").ToString.ToUpper <> "ACLARATORIA DE EXPEDIENTE" Then
                            subTipNom = f.Item("DocSubTipoNom").ToString.ToUpper & ", "
                        End If
                        head = subTipNom & "FECHA DOC.: " & fecDocStr & "ORDENA: " & aut & " CON DOC. N° " & f.Item("res_doc_jud_num")

                    Case enumTipoDocumentoJudicial.Ingreso '14
                        objEnt.Fecha = f.Item("fec_doc") 'Se debe mostrar fecha de documento, solicitud ORL coordinacion Gerardo V. 15/06/2018
                        head = "FECHA RECEP.: " & fecRecepDocStr & " INGRESA CON OFICIO N° " & f.Item("res_doc_jud_num") & " CON DESTINO AL E.P. " & f.Item("res_pen_des_nom")
                    Case enumTipoDocumentoJudicial.Notas  ' 15 
                        Dim ordena As String = ""
                        objEnt.Detalle = f.Item("DocSubTipoNom").ToString.ToUpper

                        ordena = f.Item("res_tip_aut_jud")
                        'If f.Item("res_aut_otro_nom").ToString.Length > 0 Then
                        '    ordena = ordena & " - " & f.Item("res_aut_otro_nom")
                        'End If

                        head = "FECHA DOC.: " & fecDocStr &
                        ", COMUNICA: " & ordena & " CON DOC. N°: " & f.Item("res_doc_jud_num")
                    Case enumTipoDocumentoJudicial.Sumatoria_de_Sentencia, enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                     enumTipoDocumentoJudicial.AcumulacionExpedientes,
                     enumTipoDocumentoJudicial.Integracion_Sentencia
                        Dim aut As String = ""
                        Dim fecSent As String = ""
                        Dim sentConsen As String = ""

                        Select Case f("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
                            Case Else
                                aut = "" 'f("res_aut_otro_cargo")
                        End Select

                        If f("sent_consentida") = 1 Or f("sent_consentida") = True Then
                            sentConsen = " CONSENTIDA"
                        End If

                        fecSent = ", F. SENTENCIA: " & fecSentStr

                        head = "FECHA DOC.: " & fecDocStr &
                           ", ORDENA JUZGADO/SALA: " & aut.ToUpper & " CON DOC. N°: " & f.Item("res_doc_jud_num") & sentConsen & ", SECRETARIO: " & f("res_nom_secre") &
                           fecSent

                        If f("sent_cad_perpet") = True Then
                            condenas = "CADENA PERPETUA"
                        Else
                            condenas = "CONDENADO A " & f("sent_tot_anio") & " AÑO(S) " & f("sent_tot_meses") & " MES(ES) " & f("sent_tot_dias") & " DIAS, " & f("periodo_condena") & " "
                        End If
                        head = head & " " & condenas


                    Case enumTipoDocumentoJudicial.Sentencia, enumTipoDocumentoJudicial.Sentencia_Aclaratoria, enumTipoDocumentoJudicial.Sent_Sustitucion_Pena,
                     enumTipoDocumentoJudicial.Sent_Adecuacion_Pena, enumTipoDocumentoJudicial.Sent_Conmutacion_Pena, enumTipoDocumentoJudicial.ResolucionConsentida,
                     enumTipoDocumentoJudicial.Ejecutoria_Suprema, enumTipoDocumentoJudicial.Resolucion_Superior,
                    enumTipoDocumentoJudicial.Resolucion, enumTipoDocumentoJudicial.Resolucion, enumTipoDocumentoJudicial.Revocatoria
                        Dim aut As String = ""
                        Dim fecSent As String = ""
                        Dim sentConsen As String = ""

                        Select Case f("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
                            Case Else
                                aut = "" 'f("res_aut_otro_cargo")
                        End Select
                        If f("sent_consentida") = 1 Or f("sent_consentida") = True Then
                            sentConsen = " CONSENTIDA"
                        End If

                        fecSent = ", F. SENTENCIA: " & fecSentStr

                        head = "FECHA DOC.: " & fecDocStr &
                            ", ORDENA JUZGADO/SALA: " & aut.ToUpper & " CON DOC. N°: " & f.Item("res_doc_jud_num") & sentConsen & ", SECRETARIO: " & f("res_nom_secre") &
                           fecSent


                        If f("sent_cad_perpet") = True Then
                            condenas = "CADENA PERPETUA"
                        Else
                            condenas = "CONDENADO A " & f("sent_tot_anio") & " AÑO(S) " & f("sent_tot_meses") & " MES(ES) " & f("sent_tot_dias") & " DIAS " & f("periodo_condena") & " "
                        End If
                        head = head & " " & condenas

                    Case enumTipoDocumentoJudicial.Sent_Pena_Limitativa
                        Dim aut As String = ""
                        Dim fecSent As String = ""

                        Select Case f("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
                            Case Else
                                aut = "" ' f("res_aut_otro_cargo")
                        End Select

                        fecSent = ", F. SENTENCIA: " & fecSentStr

                        head = "FECHA DOC.: " & fecDocStr &
                            ", ORDENA JUZGADO/SALA: " & aut.ToUpper & " CON DOC. N°: " & f.Item("res_doc_jud_num") & ", SECRETARIO: " & f("res_nom_secre") &
                           fecSent & " Jornadas: " & f("prol_det_cant")

                        head = head & " " & condenas

                    Case enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD, enumTipoDocumentoJudicial.Ejecutoria_Superior
                        Dim aut As String = ""
                        Dim fecSent As String = ""

                        Select Case f("res_tip_aut_jud_id")
                            Case -1
                                aut = ""
                            Case 1
                                aut = f.Item("res_sala_jud") & " / " & f.Item("res_autoridad_jud")
                            Case Else
                                aut = "" ' f("res_aut_otro_cargo")
                        End Select

                        fecSent = ", F. SENTENCIA: " & fecSentStr

                        head = "FECHA DOC.: " & fecDocStr &
                            ", ORDENA JUZGADO/SALA: " & aut.ToUpper & " CON DOC. N°: " & f.Item("res_doc_jud_num") & ", SECRETARIO: " & f("res_nom_secre") &
                           fecSent

                        If f("sent_cad_perpet") = True Then
                            condenas = "CADENA PERPETUA"
                        Else
                            condenas = "CONDENADO A " & f("sent_tot_anio") & " AÑO(S) " & f("sent_tot_meses") & " MES(ES) " & f("sent_tot_dias") & " DIAS " & f("periodo_condena") & " "
                        End If

                        head = head & " " & condenas

                    Case enumTipoDocumentoJudicial.Anulacion_Antecedentes '34
                        'PENDIENTE
                End Select

                Dim det As DataRow()
                det = t.Select("doc_jud_id=" & objEnt.Codigo)
                Dim descrip As String = ""
                For Each d As DataRow In det
                    If tipoDoc = enumTipoDocumentoJudicial.Notas Or tipoDoc = enumTipoDocumentoJudicial.Notas_Egreso Or tipoDoc = enumTipoDocumentoJudicial.Traslado Or
                    (tipoDoc = enumTipoDocumentoJudicial.Aclaratoria And f.Item("DocSubTipoNom").ToString.ToUpper = "ACLARATORIA DE NOMBRE") Then
                        Continue For
                    End If
                    descrip = descrip & vbCrLf & "EXP. N°: " & d.Item("exp_int_ing_exp_num") & ", SALA/JUZGADO: " & d.Item("exp_sala_jud") & ", SECRETARIO: " & d.Item("int_exp_sec") & "." & vbCrLf &
                           "DELITO: " & d.Item("delitos") & ". "
                    tipoDoc = Integer.Parse(f.Item("res_tip_resol_id").ToString)
                Next

                objEnt.Descripcion = (head & " " & descrip & " " & obs_doc).ToUpper

                list.Add(objEnt)
            Next

            Dim lsNew As Entity.Registro.Antecedente.DetalleAntecedenteCol
            lsNew = OrdenarOdcJudicial(list)

            Return lsNew
        End Function
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
    End Class
End Namespace