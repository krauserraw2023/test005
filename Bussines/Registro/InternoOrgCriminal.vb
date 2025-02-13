Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoOrgCriminal
        Private objEnt As Entity.Registro.InternoOrgCriminal = Nothing
        Private objEntCol As Entity.Registro.InternoOrgCriminalCol = Nothing
#Region "Validar"
        Public Function ValidarInterno(ByVal objIntBanda As Entity.Registro.InternoOrgCriminal) As Boolean
            Dim intValue As Integer = -1

            If objIntBanda.Codigo > 0 Then 'edicion
                intValue = Data.Registro.InternoOrgCriminal.ListarOutput("lst", "lst_validar_upd", objIntBanda.Codigo, objIntBanda.InternoID, objIntBanda.BandaID, objIntBanda.BandaMiembroTipoID)
            Else 'nuevo
                intValue = Data.Registro.InternoOrgCriminal.ListarOutput("lst", "lst_validar_ins", objIntBanda.Codigo, objIntBanda.InternoID, objIntBanda.BandaID, objIntBanda.BandaMiembroTipoID)
            End If

            If intValue <> 0 Then
                Return False
            End If

            Return True
        End Function

        Public Function ValidarInterno_LM(ByVal objIntBanda As Entity.Registro.InternoOrgCriminal) As Boolean
            Dim intValue As Integer = -1

            If objIntBanda.Codigo > 0 Then 'edicion
                intValue = Data.Registro.InternoOrgCriminal.ListarOutput("lst", "lst_validar_upd", objIntBanda.Codigo, objIntBanda.InternoID, objIntBanda.BandaID, objIntBanda.BandaMiembroTipoID)
            Else 'nuevo
                intValue = Data.Registro.InternoOrgCriminal.ListarOutput("lst", "lst_validar_ins", objIntBanda.Codigo, objIntBanda.InternoID, objIntBanda.BandaID, objIntBanda.BandaMiembroTipoID)
            End If

            If intValue <> 0 Then
                Return False
            End If

            Return True
        End Function
#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.InternoOrgCriminal
            Dim ObjEntIntSiscrico As New Entity.Registro.InternoOrgCriminal
            ObjEntIntSiscrico.Codigo = Codigo
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoOrgCriminal.Listar(sqlCon, "lst", "lst_mant", ObjEntIntSiscrico)
            objEnt = New Entity.Registro.InternoOrgCriminal
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ban_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .BandaTipoID = sqlDr("ban_tip_id").ToString
                            .BandaID = sqlDr("ban_id").ToString
                            .BandaMiembroTipoID = sqlDr("ban_mie_tip_id").ToString
                            .Estado = sqlDr("int_ban_est").ToString
                            .DocJudicialID_Crea = sqlDr("crea_doc_jud_id").ToString
                            .DocJudicialID_Anula = sqlDr("anul_doc_jud_id").ToString

                            .Observacion = sqlDr("int_ban_obs").ToString

                            .RegioID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString

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

        Public Function Listar2(ByVal Codigo As Integer) As Entity.Registro.InternoOrgCriminal
            Dim ObjEntIntSiscrico As New Entity.Registro.InternoOrgCriminal
            ObjEntIntSiscrico.Codigo = Codigo
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoOrgCriminal.Listar(sqlCon, "lst", "lst_mant_v5", ObjEntIntSiscrico)
            objEnt = New Entity.Registro.InternoOrgCriminal
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ban_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .BandaTipoID = sqlDr("ban_tip_id").ToString
                            .BandaID = sqlDr("ban_id").ToString
                            .BandaMiembroTipoID = sqlDr("ban_mie_tip_id").ToString
                            .Estado = sqlDr("int_ban_est").ToString
                            .DocJudicialID_Crea = sqlDr("crea_doc_jud_id").ToString
                            .DocJudicialID_Anula = sqlDr("anul_doc_jud_id").ToString

                            .Observacion = sqlDr("int_ban_obs").ToString

                            .RegioID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            '.IngresoNro = sqlDr("int_ing_nro").ToString

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

        Function ListarInternosConSiscrico(objIntSisc As Entity.Registro.InternoOrgCriminal) As Entity.Registro.InternoOrgCriminalCol

            'creado: 22/09/2015
            'por: HNRB
            'Retorna la lista de todos los interno que pertenecen a siscrico

            Dim listIntBand As New Entity.Registro.InternoOrgCriminalCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoOrgCriminal.Listar(sqlCon, "lst", "lst_interno_con_siscrico", objIntSisc)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoOrgCriminal
                        With objEnt
                            .CodigoInterno = sqlDr("int_cod_rp").ToString
                            .InternoID = sqlDr("int_id").ToString
                        End With
                        listIntBand.Add(objEnt)
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
            Return listIntBand
        End Function

        Public Function ListarIntegrantesBanda(IntBand As Entity.Registro.InternoOrgCriminal) As Entity.Registro.InternoOrgCriminalCol

            'creado 06.04.2014 hnrb

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoOrgCriminal.Listar(sqlCon, "lst", "lst_integrantes_banda", IntBand)
            Try
                objEntCol = New Entity.Registro.InternoOrgCriminalCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoOrgCriminal
                        With objEnt

                            '...........................
                            .CodigoInterno = sqlDr("int_cod_rp").ToString
                            .ApePatInterno = sqlDr("int_ape_pat").ToString
                            .ApeMatInterno = sqlDr("int_ape_mat").ToString
                            .NombresInterno = sqlDr("int_nom").ToString
                            .TipoDocIdent = sqlDr("tip_doc_nom").ToString
                            .NumDocIdentInt = sqlDr("int_doc_num").ToString
                            .FecNacInt = sqlDr("int_fec_nac")
                            .NacionalidadInt = sqlDr("nac_nom").ToString
                            .BandaMiembroTipoNombre = sqlDr("ban_miem_tip").ToString
                            .Codigo = sqlDr("int_ban_id").ToString
                            .DocJudicialID_Crea = sqlDr("crea_doc_jud_id").ToString
                            .DocJudicialID_Anula = sqlDr("anul_doc_jud_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .BandaNombre = sqlDr("ban_nom").ToString
                            .BandaTipoNombre = sqlDr("ban_tip_nom").ToString
                            .BandaID = sqlDr("ban_id").ToString

                            .DocJudDistNom = sqlDr("dist_jud_nom").ToString
                            .DocJudSalaNom = sqlDr("sal_jud_nom").ToString
                            .DocJudNum = sqlDr("doc_jud_num").ToString
                            .FechDocJud = sqlDr("doc_jud_fec").ToString
                            .DocJudSecre = sqlDr("doc_jud_sec").ToString
                            .RegioID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .RegionNom = sqlDr("reg_nom").ToString
                            .PenalNom = sqlDr("pen_nom").ToString

                            .Estado = sqlDr("int_ban_est").ToString
                          

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

        Public Function ListarIntegrantesBanda2(IntBand As Entity.Registro.InternoOrgCriminal) As Entity.Registro.InternoOrgCriminalCol

            'creado 06.02.2015 jeu
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoOrgCriminal.Listar2(sqlCon, "lst", "lst_integrantes_banda2", IntBand)
            Try
                objEntCol = New Entity.Registro.InternoOrgCriminalCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoOrgCriminal
                        With objEnt

                            '...........................
                            .CodigoInterno = sqlDr("int_cod_rp").ToString
                            .ApePatInterno = sqlDr("int_ape_pat").ToString
                            .ApeMatInterno = sqlDr("int_ape_mat").ToString
                            .NombresInterno = sqlDr("int_nom").ToString
                            .TipoDocIdent = sqlDr("tip_doc_nom").ToString
                            .NumDocIdentInt = sqlDr("int_doc_num").ToString
                            .FecNacInt = sqlDr("int_fec_nac")
                            .NacionalidadInt = sqlDr("nac_nom").ToString
                            .BandaMiembroTipoNombre = sqlDr("ban_miem_tip").ToString
                            .Codigo = sqlDr("int_ban_id").ToString
                            .DocJudicialID_Crea = sqlDr("crea_doc_jud_id").ToString
                            .DocJudicialID_Anula = sqlDr("anul_doc_jud_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .BandaNombre = sqlDr("ban_nom").ToString
                            .BandaTipoNombre = sqlDr("ban_tip_nom").ToString
                            .BandaID = sqlDr("ban_id").ToString
                            .DocJudSalaID = sqlDr("sal_jud_id").ToString
                            .DocJudDistNom = sqlDr("dist_jud_nom").ToString
                            .DocJudSalaNom = sqlDr("sal_jud_nom").ToString
                            If .DocJudSalaID < 1 Then
                                .DocJudDistNom = sqlDr("doc_jud_aut_nom").ToString
                                .DocJudSalaNom = sqlDr("doc_jud_aut_cgo").ToString
                            End If
                            .DocJudNum = sqlDr("doc_jud_num").ToString
                            .FechDocJud = sqlDr("doc_jud_fec").ToString
                            .DocJudSecre = sqlDr("doc_jud_sec").ToString
                            .RegioID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .RegionNom = sqlDr("reg_nom").ToString
                            .PenalNom = sqlDr("pen_nom").ToString

                            .Estado = sqlDr("int_ban_est").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString

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

        Public Function Listar_LM(ByVal Codigo As Integer) As Entity.Registro.InternoOrgCriminal
            Dim ObjEntIntSiscrico As New Entity.Registro.InternoOrgCriminal
            ObjEntIntSiscrico.Codigo = Codigo
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoOrgCriminal.Listar_LM(sqlCon, "lst", "lst_mant_lm", ObjEntIntSiscrico)
            objEnt = New Entity.Registro.InternoOrgCriminal
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ban_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .BandaTipoID = sqlDr("ban_tip_id").ToString
                            .BandaID = sqlDr("ban_id").ToString
                            .BandaMiembroTipoID = sqlDr("ban_mie_tip_id").ToString
                            .Estado = sqlDr("int_ban_est").ToString
                            .DocJudicialID_Crea = sqlDr("crea_doc_jud_id").ToString
                            .DocJudicialID_Anula = sqlDr("anul_doc_jud_id").ToString

                            .Observacion = sqlDr("int_ban_obs").ToString
                            .IngresoInpeID = sqlDr("fk_ing_inp_id").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .RegioID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            '.IngresoNro = sqlDr("int_ing_nro").ToString

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

        Public Function Listar_LM(ObjEntIntSiscrico As Entity.Registro.InternoOrgCriminal) As Entity.Registro.InternoOrgCriminalCol
            Dim objCol As New Entity.Registro.InternoOrgCriminalCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoOrgCriminal.Listar_LM(sqlCon, "lst", "lst_mant_lm", ObjEntIntSiscrico)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoOrgCriminal
                        With objEnt
                            .Codigo = sqlDr("int_ban_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeID = sqlDr("fk_ing_inp_id").ToString
                            .BandaTipoID = sqlDr("ban_tip_id").ToString
                            .BandaID = sqlDr("ban_id").ToString
                            .BandaMiembroTipoID = sqlDr("ban_mie_tip_id").ToString
                            .Estado = sqlDr("int_ban_est").ToString
                            .DocJudicialID_Crea = sqlDr("crea_doc_jud_id").ToString
                            .DocJudicialID_Anula = sqlDr("anul_doc_jud_id").ToString

                            .Observacion = sqlDr("int_ban_obs").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .RegioID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            '.IngresoNro = sqlDr("int_ing_nro").ToString

                        End With
                        objCol.Add(objEnt)
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
            Return objCol
        End Function

        Public Function ListarIntegrantesBandaGrilla_LM(ObjEntIntSiscrico As Entity.Registro.InternoOrgCriminal, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.Registro.InternoOrgCriminalCol
            Dim opc As String = ""
            Select Case TipoLic
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    opc = "lst_integrantes_banda_sede_lm"
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    opc = "lst_integrantes_banda_penal_lm"
            End Select

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoOrgCriminal.Listar_LM(sqlCon, "lst", opc, ObjEntIntSiscrico)
            Try
                objEntCol = New Entity.Registro.InternoOrgCriminalCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoOrgCriminal
                        With objEnt

                            '...........................
                            .CodigoInterno = sqlDr("int_cod_rp").ToString
                            .ApePatInterno = sqlDr("int_ape_pat").ToString
                            .ApeMatInterno = sqlDr("int_ape_mat").ToString
                            .NombresInterno = sqlDr("int_nom").ToString
                            .TipoDocIdent = sqlDr("tip_doc_nom").ToString
                            .NumDocIdentInt = sqlDr("int_doc_num").ToString
                            .FecNacInt = sqlDr("int_fec_nac")
                            .NacionalidadInt = sqlDr("nac_nom").ToString
                            .BandaMiembroTipoNombre = sqlDr("ban_miem_tip").ToString
                            .Codigo = sqlDr("int_ban_id").ToString
                            .DocJudicialID_Crea = sqlDr("crea_doc_jud_id").ToString
                            .DocJudicialID_Anula = sqlDr("anul_doc_jud_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .BandaNombre = sqlDr("ban_nom").ToString
                            .BandaTipoNombre = sqlDr("ban_tip_nom").ToString
                            .BandaID = sqlDr("ban_id").ToString
                            .DocJudSalaID = sqlDr("sal_jud_id").ToString
                            .DocJudDistNom = sqlDr("dist_jud_nom").ToString
                            .DocJudSalaNom = sqlDr("sal_jud_nom").ToString
                            If .DocJudSalaID < 1 Then
                                .DocJudDistNom = sqlDr("doc_jud_aut_nom").ToString
                                .DocJudSalaNom = sqlDr("doc_jud_aut_cgo").ToString
                            End If
                            .DocJudNum = sqlDr("doc_jud_num").ToString
                            .FechDocJud = sqlDr("doc_jud_fec").ToString
                            .DocJudSecre = sqlDr("doc_jud_sec").ToString
                            .RegioID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .RegionNom = sqlDr("reg_nom").ToString
                            .PenalNom = sqlDr("pen_nom").ToString

                            .Estado = sqlDr("int_ban_est").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .IngresoInpeNro = sqlDr("int_inpe_ing_nro").ToString
                            .IngresoInpeID = sqlDr("fk_ing_inp_id").ToString
                            .BandaMiembroTipoID = sqlDr("ban_mie_tip_id").ToString
                            .Observacion = sqlDr("int_ban_obs").ToString
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
#Region "Grabar"
        Public Function Grabar(ByVal objIntBanda As Entity.Registro.InternoOrgCriminal) As Integer

            'If ValidarInterno(objIntBanda) = False Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
            '       "El interno ya pertenece a esta banda")
            '    Return -1
            'End If

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntBanda.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoOrgCriminal.Grabar(strAccion, strOpcion, objIntBanda)

            Return intValue
        End Function
        Public Function Grabar2(ByVal objIntBanda As Entity.Registro.InternoOrgCriminal) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntBanda.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_v2"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_v5"
            End If

            intValue = Data.Registro.InternoOrgCriminal.Grabar2(strAccion, strOpcion, objIntBanda)

            Return intValue
        End Function

        Public Function Grabar_LM(ByVal objIntBanda As Entity.Registro.InternoOrgCriminal) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntBanda.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_sede"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_v5"
            End If

            intValue = Data.Registro.InternoOrgCriminal.Grabar_LM(strAccion, strOpcion, objIntBanda)

            Return intValue
        End Function


        Public Function GrabarEstado(ByVal Codigo As Integer, ByVal Estado As Integer, IdDocJudAnulacion As Integer) As Integer
            Dim objEnt As New Entity.Registro.InternoOrgCriminal
            objEnt.Codigo = Codigo
            objEnt.Estado = Estado
            objEnt.DocJudicialID_Anula = IdDocJudAnulacion

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_estado"

            intValue = Data.Registro.InternoOrgCriminal.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.InternoOrgCriminal.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
#End Region


    End Class
End Namespace
