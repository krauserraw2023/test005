Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class Interno_GrillaNominal
        Private objEnt As Entity.Registro.Interno = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal TipoInterno As Integer, ByVal CodigoRP As String,
            ByVal ApellidoPaterno As String,
            ByVal ApellidoMaterno As String,
            ByVal Nombres As String,
            ByVal RegionID As Integer,
            ByVal PenalID As Integer, ByVal PenalMultiple As String,
            ByVal SexoID As Integer,
            ByVal NacionalidadID As Integer,
            ByVal EstadoID As Integer,
            ByVal SituacionJuridicaID As Integer
            ) As Entity.Registro.InternoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla_Nominal.Listar(sqlCon, "lst", "lst_Interno",
            -1, CodigoRP, ApellidoPaterno, ApellidoMaterno, Nombres, RegionID, PenalID,
            PenalMultiple, SexoID, NacionalidadID,
            EstadoID, SituacionJuridicaID)

            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno

                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            '.SexoNombre = sqlDr("sex_nom").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            .EstadoCivilNombre = sqlDr("est_civ_nom").ToString
                            .NivelAcademicoNombre = sqlDr("niv_aca_nom").ToString
                            .OcupacionNombre = sqlDr("ocu_nom").ToString
                            .ProfesionNombre = sqlDr("pro_nom").ToString
                            .ComunidadAndinaNombre = sqlDr("com_and_nom").ToString
                            '/*familia*/
                            .Padre = sqlDr("pad_nom").ToString
                            .Madre = sqlDr("mad_nom").ToString
                            .Conyugue = sqlDr("cyg_nom").ToString
                            '/*ubigeo*/
                            .Departamento = sqlDr("dep_nom").ToString
                            .Provincia = sqlDr("prv_nom").ToString
                            .Distrito = sqlDr("dis_nom").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            .IngresoNumero = sqlDr("num_ing").ToString
                            .SituacionJuridicaNom = sqlDr("sit_jur_nom").ToString
                            .MotivoIngresoNombre = sqlDr("int_mot_nom").ToString
                            .FechaIngreso = sqlDr("int_ing_fec").ToString
                            '/*delito*/
                            .DelitoGenerico = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("del_esp_nom").ToString
                            '/*expediente*/
                            .DistritoJudicial = sqlDr("aut_jud_nom").ToString
                            .Juzgado = sqlDr("sal_jud_nom").ToString
                            '/*sentencia*/
                            .AutoridadSentencia = sqlDr("sen_dis_jud_nom").ToString
                            .SalaSentencia = sqlDr("sen_sal_jud_nom").ToString
                            .DocumentoSentencia = sqlDr("sen_doc").ToString
                            .FechaSentencia = sqlDr("sen_fec").ToString
                            .SentenciaAnio = sqlDr("sen_anio").ToString
                            .SentenciaMes = sqlDr("sen_mes").ToString
                            .SentenciaDia = sqlDr("sen_dia").ToString
                            '/*libertad*/
                            .LibertadDistritoJudicialNombre = sqlDr("lib_dis_jud_nom").ToString
                            .LibertadJuzgadoNombre = sqlDr("lib_sal_jud_nom").ToString
                            .DocumentoLibertad = sqlDr("lib_doc").ToString
                            .TipoLibertad = sqlDr("lib_tip_nom").ToString
                            .FechaLibertad = sqlDr("lib_fec").ToString
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*estado*/
                            .EstadoNom = sqlDr("int_est_nom").ToString

                            '.PabellonId = sqlDr("pab_id").ToString
                            '.PabellonNombre = sqlDr("pab_nom").ToString

                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            .DMP = sqlDr("int_dmp").ToString
                            .SMP = sqlDr("int_smp").ToString
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

            Return Listar2Ingreso(objEntCol, RegionID, PenalID)

        End Function

        Private Function Listar2Ingreso(ByVal InternoDatos As Entity.Registro.InternoCol, ByVal RegionID As Integer,
                                       ByVal PenalID As Integer) As Entity.Registro.InternoCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla_Nominal.Listar(sqlCon, "lst", "lst_InternoIngreso", -1,
            "", "", "", "", RegionID, PenalID, "", -1, -1, -1, -1)

            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNumero = sqlDr("int_ing_nro").ToString
                            '.SituacionJuridicaNom = sqlDr("sit_jur_nom").ToString
                            .MotivoIngresoID = sqlDr("ing_mot_id").ToString
                            .MotivoIngresoNombre = sqlDr("int_mot_nom").ToString
                            .FechaIngreso = sqlDr("int_ing_fec").ToString
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

            For Each obj As Entity.Registro.Interno In InternoDatos
                For Each objIngreso As Entity.Registro.Interno In objEntCol
                    If obj.Codigo = objIngreso.Codigo Then
                        obj.IngresoID = objIngreso.IngresoID
                        obj.IngresoNumero = objIngreso.IngresoNumero
                        'obj.SituacionJuridicaNom = strSitJur
                        obj.MotivoIngresoID = objIngreso.MotivoIngresoID
                        obj.MotivoIngresoNombre = objIngreso.MotivoIngresoNombre
                        obj.FechaIngreso = objIngreso.FechaIngreso
                        Exit For
                    End If
                Next
            Next
            'Return InternoDatos
            Return Listar2Expediente(InternoDatos, RegionID, PenalID)
        End Function

        Private Function Listar2Expediente(ByVal InternoDatos As Entity.Registro.InternoCol, ByVal RegionID As Integer,
                                       ByVal PenalID As Integer) As Entity.Registro.InternoCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla_Nominal.Listar(sqlCon, "lst", "lst_InternoExpediente", -1,
            "", "", "", "", RegionID, PenalID, "", -1, -1, -1, -1)

            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno

                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DistritoJudicial = sqlDr("aut_jud_nom").ToString
                            .Juzgado = sqlDr("sal_jud_nom").ToString
                            .LibertadDistritoJudicialNombre = sqlDr("lib_dis_jud_nom").ToString
                            .LibertadJuzgadoNombre = sqlDr("lib_sal_jud_nom").ToString
                            .DocumentoLibertad = sqlDr("lib_doc").ToString
                            .TipoLibertad = sqlDr("lib_tip_nom").ToString
                            .FechaLibertad = sqlDr("lib_fec").ToString

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

            For Each obj As Entity.Registro.Interno In InternoDatos
                For Each objExpediente As Entity.Registro.Interno In objEntCol
                    If obj.Codigo = objExpediente.Codigo And obj.IngresoID = objExpediente.IngresoID Then
                        obj.ExpedienteID = objExpediente.ExpedienteID
                        obj.DistritoJudicial = objExpediente.DistritoJudicial
                        obj.Juzgado = objExpediente.Juzgado
                        obj.LibertadDistritoJudicialNombre = objExpediente.LibertadDistritoJudicialNombre
                        obj.LibertadJuzgadoNombre = objExpediente.LibertadJuzgadoNombre
                        obj.DocumentoLibertad = objExpediente.DocumentoLibertad
                        obj.TipoLibertad = objExpediente.TipoLibertad
                        obj.FechaLibertad = objExpediente.FechaLibertad

                        Exit For
                    End If
                Next
            Next
            'Return InternoDatos
            Return Listar2Delito(InternoDatos, RegionID, PenalID)

        End Function
        Private Function Listar2Delito(ByVal InternoDatos As Entity.Registro.InternoCol, ByVal RegionID As Integer,
                                       ByVal PenalID As Integer) As Entity.Registro.InternoCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla_Nominal.Listar(sqlCon, "lst", "lst_InternoDelito", -1,
            "", "", "", "", RegionID, PenalID, "", -1, -1, -1, -1)

            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno

                        With objEnt
                            '/*ingreso*/
                            '.CodigoPadre = sqlDr("int_id").ToString
                            .Codigo = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .DelitoID = sqlDr("int_del_id").ToString
                            .DelitoGenerico = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("del_esp_nom").ToString
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

            For Each obj As Entity.Registro.Interno In InternoDatos
                For Each objDelito As Entity.Registro.Interno In objEntCol
                    If obj.Codigo = objDelito.Codigo And obj.IngresoID = objDelito.IngresoID And obj.ExpedienteID = objDelito.ExpedienteID Then
                        obj.ExpedienteID = objDelito.ExpedienteID
                        obj.DelitoID = objDelito.DelitoID
                        obj.DelitoGenerico = objDelito.DelitoGenerico
                        obj.DelitoEspecifico = objDelito.DelitoEspecifico
                        Exit For
                    End If
                Next
            Next
            'Return InternoDatos
            Return Listar2Sentencia(InternoDatos, RegionID, PenalID)
        End Function
        Private Function Listar2Sentencia(ByVal InternoDatos As Entity.Registro.InternoCol, ByVal RegionID As Integer,
                                       ByVal PenalID As Integer) As Entity.Registro.InternoCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla_Nominal.Listar(sqlCon, "lst", "lst_InternoSentencia", -1,
             "", "", "", "", RegionID, PenalID, "", -1, -1, -1, -1)

            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno

                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .SentenciaID = sqlDr("int_sen_id").ToString
                            .AutoridadSentencia = sqlDr("sen_dis_jud_nom").ToString
                            .SalaSentencia = sqlDr("sen_sal_jud_nom").ToString
                            .DocumentoSentencia = sqlDr("sen_doc").ToString
                            .FechaSentencia = sqlDr("sen_fec").ToString
                            .SentenciaAnio = sqlDr("sen_anio").ToString
                            .SentenciaMes = sqlDr("sen_mes").ToString
                            .SentenciaDia = sqlDr("sen_dia").ToString
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

            For Each obj As Entity.Registro.Interno In InternoDatos
                For Each objSentencia As Entity.Registro.Interno In objEntCol
                    If obj.Codigo = objSentencia.Codigo And obj.IngresoID = objSentencia.IngresoID And obj.ExpedienteID = objSentencia.ExpedienteID Then
                        obj.ExpedienteID = objSentencia.ExpedienteID
                        obj.SentenciaID = objSentencia.SentenciaID
                        obj.AutoridadSentencia = objSentencia.AutoridadSentencia
                        obj.SalaSentencia = objSentencia.SalaSentencia
                        obj.DocumentoSentencia = objSentencia.DocumentoSentencia
                        obj.FechaSentencia = objSentencia.FechaSentencia
                        obj.SentenciaAnio = objSentencia.SentenciaAnio
                        obj.SentenciaMes = objSentencia.SentenciaMes
                        obj.SentenciaDia = objSentencia.SentenciaDia
                        Exit For
                    End If
                Next
            Next
            'Return InternoDatos
            Return Listar2SituacionJuridica(InternoDatos, RegionID, PenalID)
        End Function
        Private Function Listar2SituacionJuridica(ByVal InternoDatos As Entity.Registro.InternoCol, ByVal RegionID As Integer,
                                       ByVal PenalID As Integer) As Entity.Registro.InternoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla_Nominal.Listar(sqlCon, "lst", "lst_expediente_ingreso", -1,
            "", "", "", "", RegionID, PenalID, "", -1, -1, -1, -1)

            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .SituacionJuridicaId = sqlDr("sit_jur_id")
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

            Dim intCountProc As Integer = 0
            Dim intCoutSent As Integer = 0
            Dim intSitJurID As Integer = -1
            Dim strSitJur As String = ""
            Dim blnPaso As Boolean = False

            For Each obj As Entity.Registro.Interno In InternoDatos

                intCountProc = 0
                intCoutSent = 0
                blnPaso = False

                For Each objSitJur As Entity.Registro.Interno In objEntCol

                    If obj.Codigo = objSitJur.Codigo And obj.IngresoID = objSitJur.IngresoID Then
                        Select Case objSitJur.SituacionJuridicaId
                            Case 1
                                intCountProc = intCountProc + 1
                            Case 2
                                intCoutSent = intCoutSent + 1
                        End Select
                        blnPaso = True
                    End If
                Next

                If blnPaso = True Then
                    If intCountProc > 0 And intCoutSent < 1 Then
                        intSitJurID = 1
                        strSitJur = "PROCES."
                    End If

                    If intCountProc < 1 And intCoutSent > 0 Then
                        intSitJurID = 2
                        strSitJur = "SENTEN."
                    End If

                    If intCountProc > 0 And intCoutSent > 0 Then
                        intSitJurID = 3
                        strSitJur = "SENT/PROC"
                    End If
                    obj.SituacionJuridicaId = intSitJurID
                    obj.SituacionJuridicaNom = strSitJur

                End If

            Next

            Return InternoDatos
        End Function
#End Region
    End Class
End Namespace