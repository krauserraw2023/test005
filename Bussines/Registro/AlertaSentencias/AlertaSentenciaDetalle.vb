Imports System.Data
Imports System.Data.SqlClient
Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.SubTipoDocJudicial

Namespace Registro
    Public Class AlertaSentenciaDetalle
        Private objEnt As Entity.Registro.AlertaSentenciaDetalle = Nothing

#Region "Funciones"
        Public Function CuentaDocumentoTipo(EnDoctReg As Entity.Registro.DocumentoJudicial) As Integer
            'jeu 04112015 actualizado
            Return Data.Registro.DocumentoJudicial.ListarOutput("lst", "lst_num_de_resol", EnDoctReg)
        End Function

        Public Function CuentaDocumentoTipo_LM(EnDoctReg As Entity.Registro.DocumentoJudicial) As Integer
            'jeu 04112015 actualizado
            Return Data.Registro.DocumentoJudicial.ListarOutput_LM("lst", "lst_num_de_resol_LM", EnDoctReg)
        End Function

        Public Function UltimFechacModificacionDocJudicial_LM(int_id As Integer) As Long
            Dim EnDoctReg As New Entity.Registro.DocumentoJudicial
            EnDoctReg.InternoId = int_id
            Return Data.Registro.DocumentoJudicial.ListarOutput_LM("lst", "lst_max_fec_mod_doc_jud_LM", EnDoctReg)
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

        Public Function Listar(objDocJud As Entity.Registro.AlertaSentenciaDetalle) As Entity.Registro.AlertaSentenciaDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntCol As New Entity.Registro.AlertaSentenciaDetalleCol
            Dim sqlDr As SqlDataReader = Data.Registro.AlertaSentenciaDetalle.Listar(sqlCon, "lst", "lst_aler_sent_det", objDocJud)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.AlertaSentenciaDetalle
                        With objEnt
                            .Codigo = sqlDr("pk_det_not_sen_id").ToString
                            .CodigoDetalle = sqlDr("fk_cab_not_sen_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .Nacionalidad = sqlDr("PAR_NOM").ToString
                            .FechaIngresoISP = sqlDr("f_fec_ing_pen").ToString
                            .FechaIngresoPenal = sqlDr("f_fec_sis_pen").ToString
                            .DocumentoJudTipo = sqlDr("doc_tip_nom").ToString
                            .ExpedienteNumero = sqlDr("int_exp_num").ToString
                            '.DelitoId = sqlDr("fk_del_esp_id").ToString
                            .DelitoNombre = sqlDr("del_esp_nom").ToString
                            .CondenaAnios = sqlDr("n_per_tie_con_anio").ToString
                            .CondenaMeses = sqlDr("n_per_tie_con_mes").ToString
                            .CondenaDias = sqlDr("n_per_tie_con_dia").ToString
                            .PeriodoInicial = sqlDr("f_fec_con_ini").ToString
                            .PeriodoFinal = sqlDr("f_fec_con_fin").ToString

                            .Tiemporestante = sqlDr("n_dia_res").ToString
                            ' .FechaConsulta = sqlDr("cab_not_sen_fec").ToString
                            .Titulo = sqlDr("c_num").ToString
                            ._Penal = sqlDr("Penal").ToString
                            ._Region = sqlDr("Region").ToString
                            .EstadoCabId = sqlDr("n_est").ToString
                            .EstadoId = sqlDr("n_est_sent").ToString
                            .Estado = sqlDr("c_est_sent").ToString
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

        Public Function Listar_bus(objDocJud As Entity.Registro.AlertaSentenciaDetalle) As Entity.Registro.AlertaSentenciaDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntCol As New Entity.Registro.AlertaSentenciaDetalleCol
            Dim sqlDr As SqlDataReader = Data.Registro.AlertaSentenciaDetalle.Listar(sqlCon, "lst", "lst_aler_sent_det_bus", objDocJud)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.AlertaSentenciaDetalle
                        With objEnt
                            .Codigo = sqlDr("pk_det_not_sen_id").ToString
                            .CodigoDetalle = sqlDr("fk_cab_not_sen_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .Nacionalidad = sqlDr("PAR_NOM").ToString
                            If Not (sqlDr("f_fec_sis_pen").ToString = "") Then
                                .FechaIngresoISP = sqlDr("f_fec_sis_pen").ToString
                            End If
                            If Not (sqlDr("f_fec_ing_pen").ToString = "") Then
                                .FechaIngresoPenal = sqlDr("f_fec_ing_pen").ToString
                            End If
                            .DocumentoJudTipo = sqlDr("doc_tip_nom").ToString
                            .ExpedienteNumero = sqlDr("int_exp_num").ToString
                            '.DelitoId = sqlDr("fk_del_esp_id").ToString
                            .DelitoNombre = sqlDr("del_esp_nom").ToString
                            .CondenaAnios = sqlDr("n_per_tie_con_anio").ToString
                            .CondenaMeses = sqlDr("n_per_tie_con_mes").ToString
                            .CondenaDias = sqlDr("n_per_tie_con_dia").ToString
                            .PeriodoInicial = sqlDr("f_fec_con_ini").ToString
                            .PeriodoFinal = sqlDr("f_fec_con_fin").ToString
                            .Tiemporestante = sqlDr("n_dia_res").ToString
                            '.Tiemporestante = sqlDr("n_dia_res").ToString
                            .Titulo = sqlDr("c_num").ToString
                            ._Penal = sqlDr("Penal").ToString
                            ._Region = sqlDr("Region").ToString
                            .EstadoCabId = sqlDr("n_est").ToString
                            .EstadoId = sqlDr("n_est_sent").ToString
                            .Estado = sqlDr("c_est_sent").ToString
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


#End Region
#Region "Grabar"
        Public Function Grabar(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer
            'If ValidarEntrada(ObjEnt) = True Then
            '    Dim intValue As Integer = -1
            '    Dim strAccion As String = ""
            '    Dim strOpcion As String = ""

            '    If ObjEnt.Codigo < 1 Then
            '        strAccion = "ins"
            '        strOpcion = "ins_mant"
            '    Else
            '        strAccion = "upd"
            '        strOpcion = "upd_mant"
            '    End If

            '    intValue = Data.Registro.DocumentoJudicial.Grabar(strAccion, strOpcion, ObjEnt)
            '    Return intValue
            'Else
            '    Return -2
            'End If
        End Function

        Public Function Grabar_LM(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer

            'If ValidarEntrada_LM(ObjEnt) = True Then
            '    Dim intValue As Integer = -1
            '    Dim strAccion As String = ""
            '    Dim strOpcion As String = ""
            '    'ObjEnt.InternoIngresoId = -1

            '    If ObjEnt.Codigo < 1 Then
            '        strAccion = "ins"
            '        strOpcion = "ins_mant_sede"
            '    Else
            '        strAccion = "upd"
            '        strOpcion = "upd_mant_lm"
            '    End If

            '    intValue = Data.Registro.DocumentoJudicial.Grabar_LM(strAccion, strOpcion, ObjEnt)

            '    If ObjEnt.DocumentoTipo = enumTipoDocumentoJudicial.Queda Then
            '        strAccion = "upd"
            '        strOpcion = "upd_mant_que"
            '        ObjEnt.Codigo = intValue
            '        Data.Registro.DocumentoJudicial.Grabar_LM(strAccion, strOpcion, ObjEnt)
            '    End If

            '    Return intValue
            'End If
        End Function

        Public Function Grabar2(ObjEnt As Entity.Registro.DocumentoJudicial) As Integer
            '22-05-2014 hnrb
            'If ValidarEntrada(ObjEnt) = True Then
            '    Dim intValue As Integer = -1
            '    Dim strAccion As String = ""
            '    Dim strOpcion As String = ""


            '    If ObjEnt.Codigo < 1 Then
            '        strAccion = "ins"
            '        strOpcion = "ins_mant_v5"
            '    Else
            '        strAccion = "upd"
            '        strOpcion = "upd_mant_v5"
            '    End If
            '    intValue = Data.Registro.DocumentoJudicial.Grabar2(strAccion, strOpcion, ObjEnt)
            '    Return intValue

            'Else
            '    Return -2
            'End If
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
#End Region

#Region "Eliminar"


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
            ' objDocAnuCol = BssDoc.ListarGrilla(objDocAnu)

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
                        GrabarAnulacion(objDoc)
                    End If
                ElseIf objD.DocumentoTipo <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes Then
                    If objExpAnuCol.Count > 0 Then
                        objDoc.Codigo = objD.Codigo
                        GrabarAnulacion(objDoc)
                    End If
                End If
            Next
        End Sub

#End Region

#Region "REG_DOC_DocJudicialExpediente"
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
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .PenalOrigenId = sqlDr("pen_orig_id").ToString
                            .RegionDestinoId = sqlDr("reg_des_id").ToString
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
                            .PenalDestinoid = sqlDr("pen_des_id").ToString
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
                            .MovimientoMotivoNom = sqlDr("mov_mot_nom").ToString
                            .PenalOrigenNom = sqlDr("pen_orig_nom").ToString
                            .PenalDestinoNom = sqlDr("pen_des_nom").ToString
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
#Region "Sentencias"
        Public Function Listar_SentenciasxCumplir(objDocJudExpe As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicialCol
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim objEnt As Entity.Registro.DocumentoJudicial = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar_SentenciasCumplidas(sqlCon, "lst", "lst_sentencias_x_cumplir", objDocJudExpe)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt
                            .DocumentoNumeroTraslado = sqlDr("Codigo").ToString
                            .AutoridadOtroNombre = sqlDr("ApellidoPaterno").ToString
                            .AutoridadOtroCargo = sqlDr("ApellidoMaterno").ToString
                            .DistritoJudNombre = sqlDr("Nombre").ToString
                            .DocumentoNumero = sqlDr("Expediente").ToString
                            .Observacion = sqlDr("Tiempodecondena").ToString ''& " a " & sqlDr("sent_tot_meses").ToString & " m " & sqlDr("sent_tot_dias").ToString & " d"
                            .ProlonDetencionFechIni = sqlDr("Fecha_inicio").ToString
                            .ProlonDetencionFechFin = sqlDr("Fecha_final").ToString

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
        Public Function Listar_SentenciasVencidas(objDocJudExpe As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicialCol
            Dim objEntCol As New Entity.Registro.DocumentoJudicialCol
            Dim objEnt As Entity.Registro.DocumentoJudicial = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar_SentenciasCumplidas(sqlCon, "lst", "lst_sentencias_vencidas", objDocJudExpe)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoJudicial
                        With objEnt
                            .DocumentoNumeroTraslado = sqlDr("Codigo").ToString
                            .AutoridadOtroNombre = sqlDr("ApellidoPaterno").ToString
                            .AutoridadOtroCargo = sqlDr("ApellidoMaterno").ToString
                            .DistritoJudNombre = sqlDr("Nombre").ToString
                            .DocumentoNumero = sqlDr("Expediente").ToString
                            .Observacion = sqlDr("Tiempodecondena").ToString ''& " a " & sqlDr("sent_tot_meses").ToString & " m " & sqlDr("sent_tot_dias").ToString & " d"
                            .ProlonDetencionFechIni = sqlDr("Fecha_inicio").ToString
                            .ProlonDetencionFechFin = sqlDr("Fecha_final").ToString

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


        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
    End Class
End Namespace


