Imports System.Data
Imports System.Data.SqlClient
Imports Data.Registro.Carceleta.Clasificacion.InternoClasificacion
Namespace Clasificacion.InternoClasificacion
    Public Class Expediente_BL
        Private objEnt As Entity.Clasificacion.InternoClasificacion.Expediente = Nothing
        Private objEntCol As Entity.Clasificacion.InternoClasificacion.ExpedienteCol = Nothing

#Region "Listar"




        'Public Function Listar_v2(ByVal EntExp As Entity.Clasificacion.InternoClasificacion.Expediente) As Entity.Clasificacion.InternoClasificacion.ExpedienteCol

        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '    Dim sqlDr As SqlDataReader = Expediente.Listar(sqlCon, "lst", "lst_mant_v2", EntExp)

        '    Dim objEntColtmp = New Entity.Clasificacion.InternoClasificacion.ExpedienteCol

        '    Try
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Clasificacion.InternoClasificacion.Expediente
        '                With objEnt
        '                    .Codigo = sqlDr("int_exp_id").ToString
        '                    .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
        '                    .InternoID = sqlDr("int_id").ToString
        '                    .Internamiento = sqlDr("int_exp_itn").ToString
        '                    .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
        '                    .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
        '                    .SalaJudicialID = sqlDr("sal_jus_id").ToString
        '                    .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
        '                    .ExpedienteJuez = sqlDr("int_exp_jue").ToString
        '                    .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
        '                    .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
        '                    .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
        '                    .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
        '                    .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
        '                    .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
        '                    .Observacion = sqlDr("int_exp_obs").ToString
        '                    .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
        '                End With
        '                objEntColtmp.add(objEnt)
        '            End While
        '        End If
        '    Catch ex As Exception
        '        Throw New Exception(ex.ToString)
        '    Finally
        '        sqlDr.Dispose()
        '        sqlDr.Close()
        '        sqlDr = Nothing
        '        sqlCon.Dispose()
        '        sqlCon.Close()
        '        sqlCon = Nothing
        '    End Try

        '    Return objEntColtmp

        'End Function

        'Public Function Listar(objIntExp As Entity.Clasificacion.InternoClasificacion.Expediente) As Entity.Clasificacion.InternoClasificacion.ExpedienteCol
        '    Dim sqlDr As SqlDataReader = Nothing
        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '    sqlDr = Expediente.Listar(sqlCon, "lst", "lst_grilla2", objIntExp)
        '    Try
        '        objEntCol = New Entity.Clasificacion.InternoClasificacion.ExpedienteCol
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Clasificacion.InternoClasificacion.Expediente
        '                With objEnt
        '                    .Codigo = sqlDr("int_exp_id").ToString
        '                    .InternoID = sqlDr("int_id").ToString
        '                    .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
        '                    .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
        '                    If .AutoridadJudicialID > 0 Then
        '                        .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
        '                        .SalaJudicialID = sqlDr("sal_jus_id").ToString
        '                        .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
        '                        .ExpedienteJuez = sqlDr("int_exp_jue").ToString
        '                        .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
        '                    Else
        '                        .AutoridadOtro = sqlDr("int_exp_otr_nom").ToString
        '                        .AutoridadOtroCargo = sqlDr("int_exp_otr_cgo").ToString

        '                        .AutoridadJudicialNombre = .AutoridadOtroCargo
        '                        .SalaJudicialNombre = .AutoridadOtro
        '                    End If
        '                    .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
        '                    .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
        '                    .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
        '                    .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
        '                    .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
        '                    .Flagrancia = sqlDr("int_exp_flag").ToString
        '                    .Observacion = sqlDr("int_exp_obs").ToString
        '                    '/*libertad*/                            

        '                    .Estado = sqlDr("int_exp_est").ToString
        '                    .Principal = sqlDr("int_exp_pri").ToString
        '                    .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
        '                    .ExpedienteVisible = sqlDr("int_exp_visible").ToString
        '                    .SentenciaAnio = sqlDr("int_exp_anio_his").ToString
        '                    .SentenciaMes = sqlDr("int_exp_mes_his").ToString
        '                    .SentenciaDia = sqlDr("int_exp_dia_his").ToString
        '                    .DocumentoJudicialNum = sqlDr("doc_jud_num").ToString
        '                    .DocumentoTipoID = sqlDr("doc_tip_id").ToString
        '                    .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
        '                End With
        '                objEntCol.Add(objEnt)
        '            End While
        '        End If
        '    Catch ex As Exception
        '        Throw New Exception(ex.ToString)
        '    Finally

        '        sqlCon.Dispose()
        '        sqlCon.Close()
        '        sqlCon = Nothing
        '    End Try
        '    Return objEntCol
        'End Function

        'Public Function Listar_LM(objIntExp As Entity.Clasificacion.InternoClasificacion.Expediente) As Entity.Clasificacion.InternoClasificacion.ExpedienteCol
        '    Dim sqlDr As SqlDataReader = Nothing
        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '    sqlDr = Expediente.Listar(sqlCon, "lst", "lst_grilla2", objIntExp)
        '    Try
        '        objEntCol = New Entity.Clasificacion.InternoClasificacion.ExpedienteCol
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Clasificacion.InternoClasificacion.Expediente
        '                With objEnt
        '                    .Codigo = sqlDr("int_exp_id").ToString
        '                    .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
        '                    .InternoID = sqlDr("int_id").ToString
        '                    .TipoAutoridadJudicialID = sqlDr("tip_aut_jud_id").ToString
        '                    .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
        '                    If .AutoridadJudicialID > 0 Then
        '                        .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
        '                        .SalaJudicialID = sqlDr("sal_jus_id").ToString
        '                        .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
        '                        .ExpedienteJuez = sqlDr("int_exp_jue").ToString
        '                        .ExpedienteSecretario = sqlDr("int_exp_sec").ToString
        '                    Else
        '                        .AutoridadOtro = sqlDr("int_exp_otr_nom").ToString
        '                        .AutoridadOtroCargo = sqlDr("int_exp_otr_cgo").ToString

        '                        .AutoridadJudicialNombre = .AutoridadOtroCargo
        '                        .SalaJudicialNombre = .AutoridadOtro
        '                    End If
        '                    .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
        '                    .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
        '                    .ExpedienteFechaDocRecepcion = sqlDr("int_exp_fec_doc_rcp").ToString
        '                    .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
        '                    .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
        '                    .Flagrancia = sqlDr("int_exp_flag").ToString
        '                    .Observacion = sqlDr("int_exp_obs").ToString
        '                    '/*libertad*/                            

        '                    .Estado = sqlDr("int_exp_est").ToString
        '                    .Principal = sqlDr("int_exp_pri").ToString
        '                    .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
        '                    .ExpedienteVisible = sqlDr("int_exp_visible").ToString
        '                    .SentenciaAnio = sqlDr("int_exp_anio_his").ToString
        '                    .SentenciaMes = sqlDr("int_exp_mes_his").ToString
        '                    .SentenciaDia = sqlDr("int_exp_dia_his").ToString
        '                    .DocumentoJudicialNum = sqlDr("doc_jud_num").ToString
        '                    .DocumentoTipoID = sqlDr("doc_tip_id").ToString
        '                    .DocumentoJudicialID = sqlDr("doc_jud_id").ToString
        '                End With
        '                objEntCol.Add(objEnt)
        '            End While
        '        End If
        '    Catch ex As Exception
        '        Throw New Exception(ex.ToString)
        '    Finally

        '        sqlCon.Dispose()
        '        sqlCon.Close()
        '        sqlCon = Nothing
        '    End Try
        '    Return objEntCol
        'End Function

#End Region


#Region "Validar"


        Private Function Validar(objIntExp As Entity.Clasificacion.InternoClasificacion.Expediente) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0
            If objIntExp.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Interno no ha sido enviando...[Expediente]")
                Return False
                Exit Function
            End If
            If objIntExp.IngresoInpeId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Ingreso no ha sido enviando...[Expediente]")
                Return False
                Exit Function
            End If

            If objIntExp._RegioId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Region no ha sido enviando...[Expediente]")
                Return False
                Exit Function
            End If

            If objIntExp._PenalId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Penal no ha sido enviando...[Expediente]")
                Return False
                Exit Function
            End If
            Return blnValue

        End Function
#End Region
#Region "Grabar"

        'Public Function ActualizarSentenciaMayorPena(objIntExp As Entity.Clasificacion.InternoClasificacion.Expediente) As Integer
        '    Dim intValue As Integer = -1
        '    If objIntExp.InternoID = -1 Then
        '        Return -1
        '    End If
        '    intValue = Expediente_DA.Grabar("upd", "upd_sentencia_mayor_pena", objIntExp)
        '    Return intValue
        'End Function
        Public Function Grabar(objIntExp As Entity.Clasificacion.InternoClasificacion.Expediente) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Validar(objIntExp) = False Then
                intValue = -1
                intValue = False
                Return intValue
            End If

            'If FechaLibertad > 0 Then
            '    If ValidarFechaIngreso(InternoID, IngresoID, FechaLibertad) = False Then
            '        intValue = -1
            '        intValue = False
            '        Return intValue
            '    End If
            'End If

            If objIntExp.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant" 'referencia a version 2->hnrb
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Expediente_DA.Grabar(strAccion, strOpcion, objIntExp)

            Return intValue
        End Function
        '18-06-2014-> hnrb
        'Public Function GrabarEstadoVisibilidad(ExpeId As Integer, RegistroVisible As Boolean) As Integer
        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""
        '    strAccion = "upd"
        '    strOpcion = "upd_estado_visibilidad_exp"
        '    Dim entExp As New Entity.Clasificacion.InternoClasificacion.Expediente
        '    entExp.Codigo = ExpeId
        '    entExp.ExpedienteVisible = RegistroVisible
        '    intValue = Expediente_DA.Grabar(strAccion, strOpcion, entExp)

        '    Return intValue
        'End Function
#End Region
#Region "Eliminar"
        'Public Function Eliminar(ByVal Codigo As Integer) As Integer

        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""
        '    strAccion = "del"
        '    strOpcion = "del_mant"
        '    intValue = Expediente_DA.Eliminar(strAccion, strOpcion, Codigo,
        '    Legolas.Configuration.Usuario.Codigo)

        '    Return intValue

        'End Function
        'Public Function Eliminar2(ByVal Codigo As Integer) As Integer

        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""
        '    strAccion = "del"
        '    strOpcion = "del_mant_v2"
        '    intValue = Expediente_DA.Eliminar(strAccion, strOpcion, Codigo,
        '    Legolas.Configuration.Usuario.Codigo)

        '    Return intValue

        'End Function
#End Region
    End Class
End Namespace