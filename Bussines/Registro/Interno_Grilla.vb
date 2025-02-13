Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
  
    Public Class Interno_Grilla
        Private objEnt As Entity.Registro.Interno = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing

        Dim objEntMovCol As Entity.Registro.InternoMovimientoCol = Nothing
        Dim objEntMov As Entity.Registro.InternoMovimiento = Nothing

        Private objEntFiltro As Entity.Registro.Interno_Grilla = Nothing                
        Private strSqlMasivo As New System.Text.StringBuilder
        Private IDInternoString As String = ""

        
#Region "Listar_Movimientos"

        Public Function ListarGrillaMovimientosCarceleta(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoMovimientoCol
            'jmr-07.02.2017

            'fecha de inicio y fecha fin
            With objEntFiltro
                .FechaIngresoIni = Legolas.Components.FechaHora.FechaTimeLong(.FechaIngresoIni, "00:00:00")
                .FechaIngresoFin = Legolas.Components.FechaHora.FechaTimeLong(.FechaIngresoFin, "23:59:59")
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar_Carceleta(sqlCon, "lst", "lst_grilla_movimiento_carceleta",
                                                                                      objEntFiltro)
            Try

                objEntMovCol = New Entity.Registro.InternoMovimientoCol

                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEntMov = New Entity.Registro.InternoMovimiento

                        With objEntMov
                            .Codigo = sqlDr("mov_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            '/*movimiento*/
                            .Fecha = sqlDr("mov_fec").ToString
                            .MovimientoGrupoID = sqlDr("mov_grp_id").ToString
                            If .MovimientoGrupoID = 1 Then
                                .MovimientoGrupoNombre = "I"
                            Else
                                .MovimientoGrupoNombre = "E"
                            End If
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .MovimientoTipoNombre = sqlDr("mov_tip_nom").ToString
                            .MovimientoMotivoNombre = sqlDr("mov_mot_nom").ToString
                            .MovimientoTipoNombre = Legolas.Components.Cadena.ProperCase(.MovimientoTipoNombre & "/ " & .MovimientoMotivoNombre)

                            '/*judicial*/
                            .DocumJudicialNum = sqlDr("doc_jud_num").ToString
                            .TipoAutoridadJudicialID = sqlDr("doc_jud_tip_aut_id").ToString

                            If .TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                .AutoridadJudicialNombre = sqlDr("sal_jud_nom").ToString
                            Else

                                .DocJudJuez = sqlDr("doc_jud_jue").ToString
                                .DocJudSecretario = sqlDr("doc_jud_sec").ToString
                                Dim strvalor As String = ""
                                If .DocJudJuez <> "" And .DocJudSecretario <> "" Then
                                    strvalor = " / "
                                End If
                                .AutoridadJudicialNombre = .DocJudJuez & strvalor & .DocJudSecretario
                            End If

                            '/*clasificacion*/
                            .ClasificacionNumero = sqlDr("num_cla").ToString
                            .ClasificacionFecha = sqlDr("fec_cla").ToString
                            .ClasificacionPenalNombre = sqlDr("pen_nom_cla").ToString
                            .ClasificacionPenalOficio = sqlDr("ofi_cla").ToString
                            '/**/

                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString

                        End With

                        'filtro x tipo de clasificacion
                        Select Case objEntFiltro.TipoClasificacion
                            Case 0
                                If objEntMov.ClasificacionFecha < 1 Then
                                    objEntMovCol.Add(objEntMov)
                                End If
                            Case 1
                                If objEntMov.ClasificacionFecha > 0 Then
                                    objEntMovCol.Add(objEntMov)
                                End If
                            Case Else
                                objEntMovCol.Add(objEntMov)
                        End Select

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

            Return objEntMovCol

        End Function



        Public Function ListarGrillaMovimientoPLM(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoMovimientoCol

            'version orl
            'fecha de inicio y fecha fin
            With objEntFiltro
                .FechaIngresoIni = Legolas.Components.FechaHora.FechaTimeLong(.FechaIngresoIni, "00:00:00")
                .FechaIngresoFin = Legolas.Components.FechaHora.FechaTimeLong(.FechaIngresoFin, "23:59:59")
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_movimiento_grilla_plm", objEntFiltro)

            objEntMovCol = New Entity.Registro.InternoMovimientoCol

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEntMov = New Entity.Registro.InternoMovimiento
                        With objEntMov
                            .Codigo = sqlDr("mov_id").ToString
                            .RegionNombre = sqlDr("Region").ToString
                            .PenalNombre = sqlDr("Penal").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .Fecha = sqlDr("mov_fec").ToString
                            .FechaISP = sqlDr("int_ing_fec_isp").ToString
                            .MovimientoGrupoID = sqlDr("mov_grp_id").ToString
                            If .MovimientoGrupoID = 1 Then
                                .MovimientoGrupoNombre = "I"
                            Else
                                .MovimientoGrupoNombre = "E"
                            End If
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .MovimientoTipoNombre = sqlDr("mov_tip_nom").ToString
                            .MovimientoMotivoNombre = sqlDr("mov_mot_nom").ToString
                            .MovimientoTipoNombre = Legolas.Components.Cadena.ProperCase(.MovimientoTipoNombre & "/ " & .MovimientoMotivoNombre)
                            .DocumJudicialNum = sqlDr("doc_jud_num").ToString
                            .TipoAutoridadJudicialID = sqlDr("doc_jud_tip_aut_id").ToString
                            If .TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                .AutoridadJudicialNombre = sqlDr("sal_jud_nom").ToString
                            Else

                                .DocJudJuez = sqlDr("doc_jud_jue").ToString
                                .DocJudSecretario = sqlDr("doc_jud_sec").ToString
                                Dim strvalor As String = ""
                                If .DocJudJuez <> "" And .DocJudSecretario <> "" Then
                                    strvalor = " / "
                                End If
                                .AutoridadJudicialNombre = .DocJudJuez & strvalor & .DocJudSecretario
                            End If
                            .OrigenNombre = sqlDr("mov_pen_org").ToString
                            If .OrigenNombre = "" Then
                                .OrigenNombre = ""
                                If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Or _
                                   .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                                    .OrigenNombre = sqlDr("mov_org_otr").ToString
                                End If
                            Else
                                .OrigenNombre = "E.P. " & .OrigenNombre
                            End If
                            .DestinoNombre = sqlDr("mov_pen_des").ToString
                            If .DestinoNombre = "" Then
                                .DestinoNombre = ""
                                If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Or _
                                    .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                                    .DestinoNombre = sqlDr("mov_des_otr").ToString
                                End If
                            Else
                                .DestinoNombre = "E.P. " & .DestinoNombre
                            End If
                            '.MovimientoRetorno = sqlDr("int_mov_ret").ToString'02-04-2018 en region ya no es necesario para condc
                            .DelitoEspecificoNombre = sqlDr("int_del_esp_nom").ToString
                            .EstadoID = sqlDr("mov_est_id").ToString

                            '/*clasificacion*/
                            '.ClasificacionNumero = sqlDr("num_cla").ToString
                            '.ClasificacionFecha = sqlDr("fec_cla").ToString
                            '.ClasificacionPenalNombre = sqlDr("pen_nom_cla").ToString
                            '.ClasificacionPenalOficio = sqlDr("ofi_cla").ToString
                            '/**/

                        End With
                        objEntMovCol.Add(objEntMov)
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
            Return objEntMovCol
        End Function

        Public Function ListarGrillaMovimiento(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoMovimientoCol

            'version 5.0 pucallpa 
            'fecha de inicio y fecha fin
            With objEntFiltro
                .FechaIngresoIni = Legolas.Components.FechaHora.FechaTimeLong(.FechaIngresoIni, "00:00:00")
                .FechaIngresoFin = Legolas.Components.FechaHora.FechaTimeLong(.FechaIngresoFin, "23:59:59")
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_movimiento_grilla", objEntFiltro)

            objEntMovCol = New Entity.Registro.InternoMovimientoCol

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEntMov = New Entity.Registro.InternoMovimiento
                        With objEntMov
                            .Codigo = sqlDr("mov_id").ToString
                            .RegionNombre = sqlDr("Region").ToString
                            .PenalNombre = sqlDr("Penal").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .Sexo = sqlDr("int_sex").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .Fecha = sqlDr("mov_fec").ToString
                            .FechaISP = sqlDr("int_ing_fec_isp").ToString
                            .MovimientoGrupoID = sqlDr("mov_grp_id").ToString
                            If .MovimientoGrupoID = 1 Then
                                .MovimientoGrupoNombre = "I"
                            Else
                                .MovimientoGrupoNombre = "E"
                            End If
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .MovimientoTipoNombre = sqlDr("mov_tip_nom").ToString
                            .MovimientoMotivoNombre = sqlDr("mov_mot_nom").ToString
                            .LibertadSubtipo = sqlDr("lib_sub_tip_nom").ToString
                            Dim var As String = .LibertadSubtipo
                            var = IIf(var.Length = 0, "", " (") & var & IIf(var.Length = 0, "", ")")
                            .MovimientoTipoNombre = Legolas.Components.Cadena.ProperCase(.MovimientoTipoNombre & "/ " & .MovimientoMotivoNombre & var)
                            .DocumJudicialNum = sqlDr("doc_jud_num").ToString
                            .TipoAutoridadJudicialID = sqlDr("doc_jud_tip_aut_id").ToString
                            If .TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                .AutoridadJudicialNombre = sqlDr("mov_sal_juz_nom").ToString
                                '+ "/" + sqlDr("mov_dis_jud_nom").ToString
                            Else

                                .DocJudJuez = sqlDr("doc_jud_jue").ToString
                                .DocJudSecretario = sqlDr("doc_jud_sec").ToString
                                Dim strvalor As String = ""
                                If .DocJudJuez <> "" And .DocJudSecretario <> "" Then
                                    strvalor = " / "
                                End If
                                .AutoridadJudicialNombre = .DocJudJuez & strvalor & .DocJudSecretario
                            End If
                            .OrigenNombre = sqlDr("mov_pen_org").ToString
                            If .OrigenNombre = "" Then
                                .OrigenNombre = ""
                                If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Or _
                                   .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                                    .OrigenNombre = sqlDr("mov_org_otr").ToString
                                End If
                            Else
                                .OrigenNombre = "E.P. " & .OrigenNombre
                            End If
                            .DestinoNombre = sqlDr("mov_pen_des").ToString
                            If .DestinoNombre = "" Then
                                .DestinoNombre = ""
                                If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Or _
                                    .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                                    .DestinoNombre = sqlDr("mov_des_otr").ToString
                                End If
                            Else
                                .DestinoNombre = "E.P. " & .DestinoNombre
                            End If
                            .MovimientoRetorno = sqlDr("int_mov_ret").ToString
                            .DelitoGenericoNombre = sqlDr("int_del_gen_nom").ToString
                            .DelitoEspecificoNombre = sqlDr("int_del_esp_nom").ToString
                            ._PenalID = sqlDr("_penid").ToString
                            .EstadoID = sqlDr("mov_est_id").ToString
                        End With
                        objEntMovCol.Add(objEntMov)
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
            Return objEntMovCol
        End Function

#End Region
#Region "Listar_Busqueda_Interno_Popup"
        Public Function ListarInternoBusqueda(ByVal objEntFiltro As Entity.Registro.Interno_Grilla, blnMostrarNombresAsociados As Boolean) As Entity.Registro.InternoCol

            'jmr-06.06.2017

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_grilla_interno_busqueda", _
                                                                                      objEntFiltro)

            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno

                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            '/*otros*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .EstadoID = sqlDr("int_est_id").ToString
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

            If blnMostrarNombresAsociados = True Then

                Dim objEntNA As Entity.Registro.InternoCol = Nothing
                Dim objEntColReturn As New Entity.Registro.InternoCol

                'llenar nombres asociados
                objEntColReturn = LlenarNombresAsociados(objEntCol, objEntFiltro.IDRegion, objEntFiltro.IDPenal)

                Return objEntColReturn

            Else
                Return objEntCol
            End If

        End Function

        Public Function ListarNivelNacional_LM_Carceleta(objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoCol
            Dim list As New Entity.Registro.InternoCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar_Carceleta(sqlCon, "lst", "lst_interno_a_nivel_nac_carceleta", objEntFiltro)

            Try
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
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .VersionRegistro = sqlDr("c_ver_reg").ToString.ToUpper
                        End With
                        list.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try
            Return list
        End Function

        Public Function ListarInternoBusqueda(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoCol


            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_buscar_interno", objEntFiltro)
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
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .EstadoID = sqlDr("int_est_id").ToString

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

#Region "ListarGrilla_Nombres_Asociados"

        Public Function Listar(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoCol

            'jmr-23.07.2014
            'jmr-24.05.2016

            'VERSION 4.5
            'mejorar el rendimiento de la busqueda por nombres asociados version 02

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            'Dim sqlDr As SqlDataReader = Data.Registro.Interno.ListarNombresAsociados_v2(sqlCon, "lst", "lst_grilla_asociado2", _
            '                                                                          objEntFiltro)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_grilla_asociado2", _
                                                                                      objEntFiltro)

            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno

                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*otros*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .EstadoID = sqlDr("int_est_id").ToString
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            .DMP = sqlDr("int_DMP").ToString
                            .SMP = sqlDr("int_SMP").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString
                            '-------campos de nueva version----------------
                            .EstadoEspecificoID = sqlDr("n_int_est_esp").ToString
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

            Dim objEntNA As Entity.Registro.InternoCol = Nothing
            Dim objEntColReturn As New Entity.Registro.InternoCol
            ''
            'llenar nombres asociados
            objEntColReturn = LlenarNombresAsociados(objEntCol, objEntFiltro.IDRegion, objEntFiltro.IDPenal)

            'filtrar por fecha de ingreso del interno, del ultimo internamiento
            If objEntFiltro.FechaIngresoIni > 0 Or objEntFiltro.FechaIngresoFin > 0 Then

                objEntNA = New Entity.Registro.InternoCol
                objEntNA = objEntColReturn

                objEntColReturn = FiltrarPorFechaIngreso(objEntNA, objEntFiltro.FechaIngresoIni, _
                                                        objEntFiltro.FechaIngresoFin, _
                                                        objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            End If

            'filtrar por delito generico y especifico
            If objEntFiltro.IDDelitoGenerico > 0 Or objEntFiltro.IDDelitoEspecifico > 0 Then

                objEntNA = New Entity.Registro.InternoCol
                objEntNA = objEntColReturn

                objEntColReturn = FiltrarPorDelitos(objEntNA, objEntFiltro.IDDelitoGenerico, _
                                                        objEntFiltro.IDDelitoEspecifico, _
                                                        objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            End If

            'filtrar por situacion juridica del ultimo internamiento
            If objEntFiltro.IDSituacionJuridica > 0 Then

                objEntNA = New Entity.Registro.InternoCol
                objEntNA = objEntColReturn

                objEntColReturn = FiltrarPorSituacionJuridica(objEntNA, _
                                                        objEntFiltro.IDSituacionJuridica, _
                                                        objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            End If

            Return objEntColReturn

        End Function

        Public Function Listar_v5(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoCol

            'jmr-23.07.2014
            'jmr-24.05.2016--mejorar el rendimiento de la busqueda por nombres asociados version 02
            'VERSION 5

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim intNumRamdon As New Random()
            Dim intValRandon As Integer = intNumRamdon.Next(1, 1200)
            Dim lngCola As Long = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia + Legolas.Configuration.Usuario.Codigo + Now.ToFileTime + intValRandon


            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_grilla_asociado2", _
                                                                                      objEntFiltro)
            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno

                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*otros*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .EstadoID = sqlDr("int_est_id").ToString
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            .DMP = sqlDr("int_DMP").ToString
                            .SMP = sqlDr("int_SMP").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString
                            '-------campos de nueva version----------------
                            .EstadoEspecificoID = sqlDr("n_int_est_esp").ToString
                        End With
                        objEntCol.Add(objEnt)

                        'grabar los internos filtrados en internogrilla
                        'habilitar mas adelenate
                        'InsertInternoGrilla(lngCola, objEnt.Codigo, Legolas.Configuration.Usuario.Codigo) 'agregar registros a la cola de busqueda

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

            Dim objEntNA As Entity.Registro.InternoCol = Nothing
            Dim objEntColReturn As New Entity.Registro.InternoCol

            'llenar nombres asociados
            objEntColReturn = LlenarNombresAsociados_v2(objEntCol, objEntFiltro.IDRegion, objEntFiltro.IDPenal)

            'filtrar por fecha de ingreso del interno, del ultimo internamiento
            If objEntFiltro.FechaIngresoIni > 0 Or objEntFiltro.FechaIngresoFin > 0 Then

                objEntNA = New Entity.Registro.InternoCol
                objEntNA = objEntColReturn

                objEntColReturn = FiltrarPorFechaIngreso(objEntNA, objEntFiltro.FechaIngresoIni, _
                                                        objEntFiltro.FechaIngresoFin, _
                                                        objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            End If

            'filtrar por delito generico y especifico
            If objEntFiltro.IDDelitoGenerico > 0 Or objEntFiltro.IDDelitoEspecifico > 0 Then

                objEntNA = New Entity.Registro.InternoCol
                objEntNA = objEntColReturn

                objEntColReturn = FiltrarPorDelitos(objEntNA, objEntFiltro.IDDelitoGenerico, _
                                                        objEntFiltro.IDDelitoEspecifico, _
                                                        objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            End If

            'filtrar por situacion juridica del ultimo internamiento
            If objEntFiltro.IDSituacionJuridica > 0 Then

                objEntNA = New Entity.Registro.InternoCol
                objEntNA = objEntColReturn

                objEntColReturn = FiltrarPorSituacionJuridica_v5(objEntNA, _
                                                        objEntFiltro.IDSituacionJuridica, _
                                                        objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            End If

            Return objEntColReturn

        End Function

        Public Function Listar_sis(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoCol

            'jmr-07/09/2017

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.SedeCentral.Listar(sqlCon, "lst", "lst_grilla_asociado_sis",
                                                                                  objEntFiltro)
            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno

                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*otros*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .EstadoID = sqlDr("int_est_id").ToString
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            .DMP = sqlDr("int_DMP").ToString
                            .SMP = sqlDr("int_SMP").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString
                            .EstadoAfiliacionID = sqlDr("n_afi_est_id").ToString
                            '-------campos de nueva version----------------
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

            Dim objEntNA As Entity.Registro.InternoCol = Nothing
            Dim objEntColReturn As New Entity.Registro.InternoCol

            'llenar nombres asociados
            objEntColReturn = LlenarNombresAsociadosSIS(objEntCol, objEntFiltro.IDRegion, objEntFiltro.IDPenal)

            'filtrar por fecha de ingreso del interno, del ultimo internamiento
            If objEntFiltro.FechaIngresoIni > 0 Or objEntFiltro.FechaIngresoFin > 0 Then

                objEntNA = New Entity.Registro.InternoCol
                objEntNA = objEntColReturn

                objEntColReturn = FiltrarPorFechaIngreso(objEntNA, objEntFiltro.FechaIngresoIni,
                                                        objEntFiltro.FechaIngresoFin,
                                                        objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            End If

            'filtrar por delito generico y especifico
            If objEntFiltro.IDDelitoGenerico > 0 Or objEntFiltro.IDDelitoEspecifico > 0 Then

                objEntNA = New Entity.Registro.InternoCol
                objEntNA = objEntColReturn

                objEntColReturn = FiltrarPorDelitos(objEntNA, objEntFiltro.IDDelitoGenerico,
                                                        objEntFiltro.IDDelitoEspecifico,
                                                        objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            End If

            'filtrar por situacion juridica del ultimo internamiento
            If objEntFiltro.IDSituacionJuridica > 0 Then

                objEntNA = New Entity.Registro.InternoCol
                objEntNA = objEntColReturn

                objEntColReturn = FiltrarPorSituacionJuridica_v5(objEntNA,
                                                        objEntFiltro.IDSituacionJuridica,
                                                        objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            End If

            Return objEntColReturn

        End Function

        Public Function Listar_PLM(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoCol

            'jmr-23.07.2014
            'jmr-24.05.2016
            'mejorar el rendimiento de la busqueda por nombres asociados version 02
            'creado: 10/04/2017 -> se agrego busqueda por nombre clave, codigo unico de interno.
            'VERSION PLM

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim intNumRamdon As New Random()
            Dim intValRandon As Integer = intNumRamdon.Next(1, 1200)
            Dim lngCola As Long = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana + Legolas.Configuration.Usuario.Codigo + Now.ToFileTime + intValRandon

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_grilla_limametropolitana", _
                                                                                      objEntFiltro)

            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno

                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .RowID = sqlDr("_RowId").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .VersionRegistro = sqlDr("c_ver_reg").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString                            
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*otros*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .EstadoBloqueoId = sqlDr("n_int_pen_bloq_id").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString                           
                            .EstadoRncID = sqlDr("int_est_rnc").ToString
                            .CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                            .NombreClaveInterno = sqlDr("c_int_nom_clav").ToString
                            .TrasladadoDeCarceleta = sqlDr("n_car_est_trs_id").ToString                            
                            .EstadoEspecificoID = sqlDr("n_int_est_esp").ToString
                        End With
                        objEntCol.Add(objEnt)

                        ''grabar los internos filtrados en internogrilla
                        generarInsertBusqueda(lngCola, objEnt.Codigo, Legolas.Configuration.Usuario.Codigo) 'agregar registros a la cola de busqueda

                    End While
                End If
            Catch ex As Exception
                DeleteInternoGrilla(lngCola) 'eliminar los registros de la cola de busqueda
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Dim objEntColReturn As New Entity.Registro.InternoCol

            'verificar que el resultado de busqueda traiga mas de un registro
            If Not objEntCol Is Nothing Then
                If objEntCol.Count > 0 Then

                    '/**********listar nombres asociados********/                    
                    InsertMasivoInternoGrilla(strSqlMasivo.ToString())

                    Dim objEntNomAsocCol As New Entity.Registro.Interno_Grilla.NombresAsociadosCol
                    objEntNomAsocCol = BuscarNombresAsociados(lngCola, objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                    '/*****************************************/

                    objEntColReturn = Listar_RegionLimaCarceletaPLM_Join(objEntCol, objEntNomAsocCol)

                    Dim objEntNA As Entity.Registro.InternoCol = Nothing

                    'filtrar por delito generico y especifico
                    If objEntFiltro.IDDelitoGenerico > 0 Or objEntFiltro.IDDelitoEspecifico > 0 Then

                        objEntNA = New Entity.Registro.InternoCol
                        objEntNA = objEntColReturn

                        objEntColReturn = FiltrarxDelitos_LM(objEntNA, lngCola, objEntFiltro.IDDelitoGenerico,
                                                                objEntFiltro.IDDelitoEspecifico,
                                                                objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                    End If

                    'filtrar por situacion juridica, expedientes visibles
                    If objEntFiltro.IDSituacionJuridica > 0 Then

                        objEntNA = New Entity.Registro.InternoCol
                        objEntNA = objEntColReturn

                        objEntColReturn = FiltrarxSituacionJuridica_LM(objEntNA, lngCola, objEntFiltro.IDSituacionJuridica,
                                                                objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                    End If

                    'filtrar por nombre del alias
                    If objEntFiltro.InternoAlias.Length > 1 Then

                        objEntNA = New Entity.Registro.InternoCol
                        objEntNA = objEntColReturn

                        objEntColReturn = FiltrarxAlias_LM(objEntNA, lngCola, objEntFiltro.InternoAlias, objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                    End If

                End If
            End If

            DeleteInternoGrilla(lngCola) 'eliminar los registros de la cola de busqueda

            Return objEntColReturn

        End Function

        Public Function Listar_Carceleta(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoCol

            'VERSION CARCELETA
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim intNumRamdon As New Random()
            Dim intValRandon As Integer = intNumRamdon.Next(1, 1200)
            Dim lngCola As Long = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta + Legolas.Configuration.Usuario.Codigo + Now.ToFileTime + intValRandon

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar_Carceleta(sqlCon, "lst", "lst_grilla_carceleta",
                                                                                      objEntFiltro)

            Try
                objEntCol = New Entity.Registro.InternoCol
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno

                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            '.CodigoUnicoInterno =
                            '.NombreClaveInterno =
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*otros*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            .DMP = sqlDr("int_DMP").ToString
                            .SMP = sqlDr("int_SMP").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString

                            .EstadoEspecificoID = sqlDr("n_int_est_esp").ToString
                            .CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                            .NombreClaveInterno = sqlDr("c_int_nom_clav").ToString
                            .TrasladadoDeCarceleta = sqlDr("n_car_est_trs_id").ToString

                            '-------evaluar estado ----------------

                            .EstadoID = sqlDr("int_est_id").ToString
                            If .EstadoID = 1 Then 'solo si está activo se evalua
                                If .TrasladadoDeCarceleta < 0 Then
                                    .EstadoID = sqlDr("n_int_est_esp").ToString
                                Else
                                    If .TrasladadoDeCarceleta = 1 Then
                                        .EstadoID = 0
                                    Else
                                        .EstadoID = 1
                                    End If
                                End If
                            End If

                        End With
                        objEntCol.Add(objEnt)
                        'grabar los internos filtrados en internogrilla
                        generarInsertBusqueda(lngCola, objEnt.Codigo, Legolas.Configuration.Usuario.Codigo) 'agregar registros a la cola de busqueda
                    End While
                End If
            Catch ex As Exception
                DeleteInternoGrilla(lngCola) 'eliminar los registros de la cola de busqueda
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Dim objEntColReturn As New Entity.Registro.InternoCol

            'verificar que el resultado de busqueda traiga mas de un registro
            If Not objEntCol Is Nothing Then
                If objEntCol.Count > 0 Then

                    '/**********listar nombres asociados********/
                    InsertMasivoInternoGrilla(strSqlMasivo.ToString())

                    Dim objEntNomAsocCol As New Entity.Registro.Interno_Grilla.NombresAsociadosCol
                    objEntNomAsocCol = BuscarNombresAsociados(lngCola, objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                    '/*****************************************/
                    objEntColReturn = Listar_RegionLimaCarceletaPLM_Join(objEntCol, objEntNomAsocCol)
                    DeleteInternoGrilla(lngCola) 'eliminar los registros de la cola de busqueda

                    Dim objEntNA As Entity.Registro.InternoCol = Nothing

                    'filtrar por delito generico y especifico
                    If objEntFiltro.IDDelitoGenerico > 0 Or objEntFiltro.IDDelitoEspecifico > 0 Then

                        objEntNA = New Entity.Registro.InternoCol
                        objEntNA = objEntColReturn

                        objEntColReturn = FiltrarPorDelitos(objEntNA, objEntFiltro.IDDelitoGenerico,
                                                                objEntFiltro.IDDelitoEspecifico,
                                                                objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                    End If

                    'filtrar por situacion juridica del ultimo internamiento
                    If objEntFiltro.IDSituacionJuridica > 0 Then

                        objEntNA = New Entity.Registro.InternoCol
                        objEntNA = objEntColReturn

                        objEntColReturn = FiltrarPorSituacionJuridica(objEntNA,
                                                                objEntFiltro.IDSituacionJuridica,
                                                                objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                    End If

                End If
            End If

            Return objEntColReturn

        End Function

        Public Function Listar_SedeCentral(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoCol

            'jmr-02.04.2020    
            'select exclusivo para el form de busqueda de la sede central

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntNombreAsociadoCol As New Entity.Registro.Interno_Grilla.NombresAsociadosCol

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.SedeCentral.Listar(sqlCon, "lst", "lst_grilla_busqueda_internos",
                                                                                      objEntFiltro)
            Try
                objEntCol = New Entity.Registro.InternoCol

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .RowID = sqlDr("_RowId").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .VersionRegistro = sqlDr("c_ver_reg").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*otros*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PenalTipoLicencia = sqlDr("pen_tip_lic").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .EstadoID = sqlDr("int_est_id").ToString
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If

                'siguiente tabla
                sqlDr.NextResult()

                Dim objEntNombreAsociado As Entity.Registro.Interno_Grilla.NombresAsociados = Nothing

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEntNombreAsociado = New Entity.Registro.Interno_Grilla.NombresAsociados
                        With objEntNombreAsociado
                            .Codigo = sqlDr("int_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Principal = sqlDr("int_aso_pri").ToString
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString
                            .Estado = sqlDr("int_aso_est").ToString
                        End With
                        objEntNombreAsociadoCol.Add(objEntNombreAsociado)
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

            Dim objEntColReturn As New Entity.Registro.InternoCol

            'verificar que el resultado de busqueda traiga mas de un registro
            If Not objEntCol Is Nothing Then
                If objEntCol.Count > 0 Then

                    objEntColReturn = Listar_SedeCentral_Join(objEntCol, objEntNombreAsociadoCol)

                    Dim objEntNA As Entity.Registro.InternoCol = Nothing

                    'filtrar por situacion juridica del ultimo internamiento
                    If objEntFiltro.IDSituacionJuridica > 0 Then

                        objEntNA = New Entity.Registro.InternoCol
                        objEntNA = objEntColReturn

                        objEntColReturn = FiltrarxSituacionJuridica_SedeCentral(objEntNA, objEntFiltro.IDSituacionJuridica,
                                                                objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                    End If

                End If
            End If

            Return objEntColReturn

        End Function
#End Region

#Region "ListarGrilla_Nombres_Asociados_Visita"
        Public Function Listar_Grilla_Visita_Interno(strOpcion As String, ByVal objEntFiltro As Entity.Visita.Interno) As Entity.Visita.InternoCol

            'jmr-26.03.2019
            Dim objEntCol As Entity.Visita.InternoCol
            Dim objEnt As Entity.Visita.Interno

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim intNumRamdon As New Random()
            Dim intValRandon As Integer = intNumRamdon.Next(1, 1200)
            Dim lngCola As Long = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia + Legolas.Configuration.Usuario.Codigo + Now.ToFileTime + intValRandon

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.ListarVisita(sqlCon, "lst", strOpcion,
                                                                                      objEntFiltro)
            'Data.Registro.InternoGrilla.Listar_RegionLima
            Try
                objEntCol = New Entity.Visita.InternoCol
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Visita.Interno

                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .RowID = sqlDr("_RowId").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .VersionRegistro = sqlDr("c_ver_reg").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString

                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .Nacionalidad = sqlDr("nac_nom").ToString

                            .EtapaID = sqlDr("etp_id").ToString
                            .EtapaNombre = sqlDr("etp_nom").ToString
                            If .EtapaID < 1 Then
                                .EtapaNombre = "S/E"
                            End If
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_nom").ToString
                            '/*region-penal*/
                            .IDRegion = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .IDPenal = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                        End With
                        objEntCol.Add(objEnt)
                        'grabar los internos filtrados en internogrilla
                        generarInsertBusqueda(lngCola, objEnt.Codigo, Legolas.Configuration.Usuario.Codigo) 'agregar registros a la cola de busqueda

                    End While
                End If
            Catch ex As Exception
                DeleteInternoGrilla(lngCola) 'eliminar los registros de la cola de busqueda
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Dim objEntColReturn As New Entity.Visita.InternoCol

            'verificar que el resultado de busqueda traiga mas de un registro
            If Not objEntCol Is Nothing Then
                If objEntCol.Count > 0 Then

                    '/**********listar nombres asociados********/
                    InsertMasivoInternoGrilla(strSqlMasivo.ToString())
                    Dim objEntNomAsocCol As New Entity.Registro.Interno_Grilla.NombresAsociadosCol
                    objEntNomAsocCol = BuscarNombresAsociados(lngCola, objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                    '/*****************************************/
                    objEntColReturn = Listar_Visita_Interno_Join(objEntCol, objEntNomAsocCol)
                    DeleteInternoGrilla(lngCola) 'eliminar los registros de la cola de busqueda

                End If
            End If

            Return objEntColReturn

        End Function

#End Region
#Region "Listar_Interno_NombreAsociado_Join"
        Private Function Listarv5_Join(ByVal objEntListaInternoCol As Entity.Registro.InternoCol,
                                                     objEntNomAsoCol As Entity.Registro.Interno_Grilla.NombresAsociadosCol) As Entity.Registro.InternoCol

            Dim value As New Entity.Registro.InternoCol

            Dim objEntAll As New Entity.Registro.Interno

            For Each objEnt As Entity.Registro.Interno In objEntListaInternoCol

                objEntAll = New Entity.Registro.Interno
                With objEntAll
                    .Codigo = objEnt.Codigo
                    .CodigoRP = objEnt.CodigoRP
                    .IngresoID = objEnt.IngresoID
                    .CodigoPadre = 0
                    .ApellidoPaterno = objEnt.ApellidoPaterno
                    .ApellidoMaterno = objEnt.ApellidoMaterno
                    .Nombres = objEnt.Nombres
                    .SexoID = objEnt.SexoID
                    .TipoDocumentoNombre = objEnt.TipoDocumentoNombre
                    .NumeroDocumento = objEnt.NumeroDocumento
                    .FechaNacimiento = objEnt.FechaNacimiento
                    .NacionalidadNombre = objEnt.NacionalidadNombre
                    '/*alias*/
                    .InternoAlias = objEnt.InternoAlias
                    '/*otros*/
                    .PabellonNombre = objEnt.PabellonNombre
                    .RegionID = objEnt.RegionID
                    .RegionNombre = objEnt.RegionNombre
                    .PenalID = objEnt.PenalID
                    .PenalNombre = objEnt.PenalNombre
                    '/*estado*/
                    .EstadoID = objEnt.EstadoID
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    'fotos
                    .FotoPerfilIzquierdo = objEnt.FotoPerfilIzquierdo
                    .FotoPerfilFrente = objEnt.FotoPerfilFrente
                    .FotoPerfilDerecho = objEnt.FotoPerfilDerecho
                    .DMP = objEnt.DMP
                    .SMP = objEnt.SMP
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    .SituacionJuridicaNom = objEnt.SituacionJuridicaNom
                    .EstadoRncID = objEnt.EstadoRncID
                    .EstadoEspecificoID = objEnt.EstadoEspecificoID
                    .FechaIngreso = objEnt.FechaIngreso
                End With

                value.Add(objEntAll)

                For Each objEntNA As Entity.Registro.Interno_Grilla.NombresAsociados In objEntNomAsoCol
                    If objEnt.Codigo = objEntNA.InternoID Then
                        objEntAll = New Entity.Registro.Interno
                        With objEntAll
                            .CodigoPadre = 1
                            .Codigo = objEntNA.InternoID
                            .ApellidoPaterno = objEntNA.ApellidoPaterno
                            .ApellidoMaterno = objEntNA.ApellidoMaterno
                            .Nombres = objEntNA.Nombres
                        End With
                        value.Add(objEntAll)
                    End If
                Next
            Next
            Return value
        End Function

        Private Function Listar_RegionLimaCarceletaPLM_Join(ByVal objEntListaInternoCol As Entity.Registro.InternoCol,
                                                         objEntNomAsoCol As Entity.Registro.Interno_Grilla.NombresAsociadosCol) As Entity.Registro.InternoCol

            Dim objEntAll As Entity.Registro.Interno
            Dim value As New Entity.Registro.InternoCol

            For Each objEnt As Entity.Registro.Interno In objEntListaInternoCol

                objEntAll = New Entity.Registro.Interno
                With objEntAll
                    .Codigo = objEnt.Codigo
                    .CodigoRP = objEnt.CodigoRP
                    .IngresoID = objEnt.IngresoID
                    .CodigoPadre = 0
                    .RowID = objEnt.RowID
                    .SedeRowId = objEnt.SedeRowId
                    .VersionRegistro = objEnt.VersionRegistro
                    'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                    .ApellidoPaterno = objEnt.ApellidoPaterno
                    .ApellidoMaterno = objEnt.ApellidoMaterno
                    .Nombres = objEnt.Nombres
                    .SexoID = objEnt.SexoID
                    .TipoDocumentoNombre = objEnt.TipoDocumentoNombre
                    .NumeroDocumento = objEnt.NumeroDocumento
                    .FechaNacimiento = objEnt.FechaNacimiento
                    .NacionalidadNombre = objEnt.NacionalidadNombre
                    '/*alias*/
                    .InternoAlias = objEnt.InternoAlias
                    '/*otros*/
                    .PabellonNombre = objEnt.PabellonNombre
                    .RegionID = objEnt.RegionID
                    .RegionNombre = objEnt.RegionNombre
                    .PenalID = objEnt.PenalID
                    .PenalNombre = objEnt.PenalNombre
                    '/*estado*/
                    .EstadoBloqueoId = objEnt.EstadoBloqueoId
                    .EstadoID = objEnt.EstadoID
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    'fotos
                    .FotoPerfilIzquierdo = objEnt.FotoPerfilIzquierdo
                    .FotoPerfilFrente = objEnt.FotoPerfilFrente
                    .FotoPerfilDerecho = objEnt.FotoPerfilDerecho
                    .DMP = objEnt.DMP
                    .SMP = objEnt.SMP
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    .SituacionJuridicaNom = objEnt.SituacionJuridicaNom
                    .EstadoRncID = objEnt.EstadoRncID
                    .EstadoEspecificoID = objEnt.EstadoEspecificoID
                    .FechaIngreso = objEnt.FechaIngreso

                    .IdiomaNativoId = objEnt.IdiomaNativoId
                    .GeneroId = objEnt.GeneroId
                    .CentroTrabajo = objEnt.CentroTrabajo
                    .ReligionId = objEnt.ReligionId
                    .CodigoFuerzaArmadaId = objEnt.CodigoFuerzaArmadaId
                    .CodigoRangoId = objEnt.CodigoRangoId
                    .CodigoUnicoInterno = objEnt.CodigoUnicoInterno
                    .NombreClaveInterno = objEnt.NombreClaveInterno

                    .TrasladadoDeCarceleta = objEnt.TrasladadoDeCarceleta
                End With

                value.Add(objEntAll)

                For Each objEntNA As Entity.Registro.Interno_Grilla.NombresAsociados In objEntNomAsoCol
                    If objEnt.Codigo = objEntNA.InternoID Then
                        objEntAll = New Entity.Registro.Interno
                        With objEntAll
                            .CodigoPadre = 1
                            .Codigo = objEntNA.InternoID
                            .ApellidoPaterno = objEntNA.ApellidoPaterno
                            .ApellidoMaterno = objEntNA.ApellidoMaterno
                            .Nombres = objEntNA.Nombres
                        End With
                        value.Add(objEntAll)
                    End If
                Next
            Next
            Return value
        End Function

        Private Function Listar_SedeCentral_Join(ByVal objEntListaInternoCol As Entity.Registro.InternoCol,
                                                         objEntNomAsoCol As Entity.Registro.Interno_Grilla.NombresAsociadosCol) As Entity.Registro.InternoCol

            Dim objEntAll As Entity.Registro.Interno
            Dim value As New Entity.Registro.InternoCol

            For Each objEnt As Entity.Registro.Interno In objEntListaInternoCol

                objEntAll = New Entity.Registro.Interno
                With objEntAll
                    .Codigo = objEnt.Codigo
                    .CodigoRP = objEnt.CodigoRP
                    .IngresoID = objEnt.IngresoID
                    .CodigoPadre = 0
                    .RowID = objEnt.RowID
                    .SedeRowId = objEnt.SedeRowId
                    .VersionRegistro = objEnt.VersionRegistro
                    'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx                    
                    .ApellidoPaterno = objEnt.ApellidoPaterno
                    .ApellidoMaterno = objEnt.ApellidoMaterno
                    .Nombres = objEnt.Nombres
                    .SexoID = objEnt.SexoID
                    .TipoDocumentoNombre = objEnt.TipoDocumentoNombre
                    .NumeroDocumento = objEnt.NumeroDocumento
                    .FechaNacimiento = objEnt.FechaNacimiento
                    .NacionalidadNombre = objEnt.NacionalidadNombre
                    '/*alias*/
                    .InternoAlias = objEnt.InternoAlias
                    '/*otros*/
                    .PabellonNombre = objEnt.PabellonNombre
                    .RegionID = objEnt.RegionID
                    .RegionNombre = objEnt.RegionNombre
                    .PenalID = objEnt.PenalID
                    .PenalNombre = objEnt.PenalNombre
                    .PenalTipoLicencia = objEnt.PenalTipoLicencia
                    '/*estado*/
                    .EstadoID = objEnt.EstadoID
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    'fotos
                    .FotoPerfilIzquierdo = objEnt.FotoPerfilIzquierdo
                    .FotoPerfilFrente = objEnt.FotoPerfilFrente
                    .FotoPerfilDerecho = objEnt.FotoPerfilDerecho
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    .SituacionJuridicaNom = objEnt.SituacionJuridicaNom
                    .EstadoRncID = objEnt.EstadoRncID
                    .FechaIngreso = objEnt.FechaIngreso
                End With

                value.Add(objEntAll)

                For Each objEntNA As Entity.Registro.Interno_Grilla.NombresAsociados In objEntNomAsoCol
                    If objEnt.Codigo = objEntNA.InternoID Then
                        objEntAll = New Entity.Registro.Interno
                        With objEntAll
                            .CodigoPadre = 1
                            .Codigo = objEntNA.InternoID
                            .ApellidoPaterno = objEntNA.ApellidoPaterno
                            .ApellidoMaterno = objEntNA.ApellidoMaterno
                            .Nombres = objEntNA.Nombres
                        End With
                        value.Add(objEntAll)
                    End If
                Next
            Next
            Return value
        End Function

        Private Function LlenarNombresAsociados(ByVal objEntListaInternoCol As Entity.Registro.InternoCol, ByVal RegionID As Integer,
                                       ByVal PenalID As Integer) As Entity.Registro.InternoCol

            'recorre los id de los internos filtrados
            IDInternoString = ""
            For Each interno As Entity.Registro.Interno In objEntListaInternoCol
                IDInternoString = IDInternoString & interno.Codigo & ","
            Next
            If IDInternoString.Length > 0 Then
                IDInternoString = IDInternoString.Substring(0, IDInternoString.Length - 1)
            End If

            'buscar en la bd los nombres asociados del filtrado
            objEntFiltro = New Entity.Registro.Interno_Grilla

            With objEntFiltro
                .IDInternoString = IDInternoString
                .NombreAsociadoPrincipal = 0 'solo asociados
                .NombreAsociadoEstado = 1 'estado activos
                .IDRegion = RegionID
                .IDPenal = PenalID
            End With
            '/********************************************************/

            'coleccion de nombres asociados
            Dim objEntColNA As New Entity.Registro.Interno_Grilla.NombresAsociadosCol
            objEntColNA = Listar_NombresAsociados(objEntFiltro)

            Dim objEntAll As Entity.Registro.Interno
            Dim value As New Entity.Registro.InternoCol

            For Each objEnt As Entity.Registro.Interno In objEntListaInternoCol

                objEntAll = New Entity.Registro.Interno
                With objEntAll
                    .Codigo = objEnt.Codigo
                    .CodigoRP = objEnt.CodigoRP
                    .IngresoID = objEnt.IngresoID
                    .CodigoPadre = 0
                    .ApellidoPaterno = objEnt.ApellidoPaterno
                    .ApellidoMaterno = objEnt.ApellidoMaterno
                    .Nombres = objEnt.Nombres
                    .SexoID = objEnt.SexoID
                    .TipoDocumentoNombre = objEnt.TipoDocumentoNombre
                    .NumeroDocumento = objEnt.NumeroDocumento
                    .FechaNacimiento = objEnt.FechaNacimiento
                    .NacionalidadNombre = objEnt.NacionalidadNombre
                    '/*alias*/
                    .InternoAlias = objEnt.InternoAlias
                    '/*otros*/
                    .PabellonNombre = objEnt.PabellonNombre
                    .RegionID = objEnt.RegionID
                    .RegionNombre = objEnt.RegionNombre
                    .PenalID = objEnt.PenalID
                    .PenalNombre = objEnt.PenalNombre
                    '/*estado*/
                    .EstadoID = objEnt.EstadoID
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    'fotos
                    .FotoPerfilIzquierdo = objEnt.FotoPerfilIzquierdo
                    .FotoPerfilFrente = objEnt.FotoPerfilFrente
                    .FotoPerfilDerecho = objEnt.FotoPerfilDerecho
                    .DMP = objEnt.DMP
                    .SMP = objEnt.SMP
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    .SituacionJuridicaNom = objEnt.SituacionJuridicaNom
                    .EstadoRncID = objEnt.EstadoRncID
                    .EstadoEspecificoID = objEnt.EstadoEspecificoID
                    .FechaIngreso = objEnt.FechaIngreso
                End With

                value.Add(objEntAll)

                For Each objEntNA As Entity.Registro.Interno_Grilla.NombresAsociados In objEntColNA
                    If objEnt.Codigo = objEntNA.InternoID Then
                        objEntAll = New Entity.Registro.Interno
                        With objEntAll
                            .CodigoPadre = 1
                            .Codigo = objEntNA.InternoID
                            .ApellidoPaterno = objEntNA.ApellidoPaterno
                            .ApellidoMaterno = objEntNA.ApellidoMaterno
                            .Nombres = objEntNA.Nombres
                        End With
                        value.Add(objEntAll)
                    End If
                Next
            Next
            Return value
        End Function

        Private Function LlenarNombresAsociadosSIS(ByVal objEntListaInternoCol As Entity.Registro.InternoCol, ByVal RegionID As Integer,
                                     ByVal PenalID As Integer) As Entity.Registro.InternoCol

            'recorre los id de los internos filtrados
            IDInternoString = ""
            For Each interno As Entity.Registro.Interno In objEntListaInternoCol
                IDInternoString = IDInternoString & interno.Codigo & ","
            Next
            If IDInternoString.Length > 0 Then
                IDInternoString = IDInternoString.Substring(0, IDInternoString.Length - 1)
            End If

            'buscar en la bd los nombres asociados del filtrado
            objEntFiltro = New Entity.Registro.Interno_Grilla

            With objEntFiltro
                .IDInternoString = IDInternoString
                .NombreAsociadoPrincipal = 0 'solo asociados
                .NombreAsociadoEstado = 1 'estado activos
                .IDRegion = RegionID
                .IDPenal = PenalID
            End With
            '/********************************************************/

            'coleccion de nombres asociados
            Dim objEntColNA As New Entity.Registro.Interno_Grilla.NombresAsociadosCol
            objEntColNA = Listar_NombresAsociados(objEntFiltro)

            Dim objEntAll As Entity.Registro.Interno
            Dim value As New Entity.Registro.InternoCol

            For Each objEnt As Entity.Registro.Interno In objEntListaInternoCol

                objEntAll = New Entity.Registro.Interno
                With objEntAll
                    .Codigo = objEnt.Codigo
                    .CodigoRP = objEnt.CodigoRP
                    .IngresoID = objEnt.IngresoID
                    .CodigoPadre = 0
                    .ApellidoPaterno = objEnt.ApellidoPaterno
                    .ApellidoMaterno = objEnt.ApellidoMaterno
                    .Nombres = objEnt.Nombres
                    .SexoID = objEnt.SexoID
                    .TipoDocumentoNombre = objEnt.TipoDocumentoNombre
                    .NumeroDocumento = objEnt.NumeroDocumento
                    .FechaNacimiento = objEnt.FechaNacimiento
                    .NacionalidadNombre = objEnt.NacionalidadNombre
                    '/*alias*/
                    .InternoAlias = objEnt.InternoAlias
                    '/*otros*/
                    .PabellonNombre = objEnt.PabellonNombre
                    .RegionID = objEnt.RegionID
                    .RegionNombre = objEnt.RegionNombre
                    .PenalID = objEnt.PenalID
                    .PenalNombre = objEnt.PenalNombre
                    '/*estado*/
                    .EstadoID = objEnt.EstadoID
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    'fotos
                    .FotoPerfilIzquierdo = objEnt.FotoPerfilIzquierdo
                    .FotoPerfilFrente = objEnt.FotoPerfilFrente
                    .FotoPerfilDerecho = objEnt.FotoPerfilDerecho
                    .DMP = objEnt.DMP
                    .SMP = objEnt.SMP
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    .SituacionJuridicaNom = objEnt.SituacionJuridicaNom
                    .EstadoRncID = objEnt.EstadoRncID
                    .EstadoEspecificoID = objEnt.EstadoEspecificoID
                    .FechaIngreso = objEnt.FechaIngreso
                    .EstadoAfiliacionID = objEnt.EstadoAfiliacionID
                End With

                value.Add(objEntAll)

                For Each objEntNA As Entity.Registro.Interno_Grilla.NombresAsociados In objEntColNA
                    If objEnt.Codigo = objEntNA.InternoID Then
                        objEntAll = New Entity.Registro.Interno
                        With objEntAll
                            .CodigoPadre = 1
                            .Codigo = objEntNA.InternoID
                            .ApellidoPaterno = objEntNA.ApellidoPaterno
                            .ApellidoMaterno = objEntNA.ApellidoMaterno
                            .Nombres = objEntNA.Nombres
                        End With
                        value.Add(objEntAll)
                    End If
                Next
            Next
            Return value
        End Function

        Private Function LlenarNombresAsociados_v2(ByVal objEntListaInternoCol As Entity.Registro.InternoCol, ByVal RegionID As Integer,
                                       ByVal PenalID As Integer) As Entity.Registro.InternoCol
            '------ 24/04/2017 ----- se agrego campos como codigo unico interno, nombre clave, cod fuerza armada, etc.
            'recorre los id de los internos filtrados
            IDInternoString = ""
            For Each interno As Entity.Registro.Interno In objEntListaInternoCol
                IDInternoString = IDInternoString & interno.Codigo & ","
            Next
            If IDInternoString.Length > 0 Then
                IDInternoString = IDInternoString.Substring(0, IDInternoString.Length - 1)
            End If

            'buscar en la bd los nombres asociados del filtrado
            objEntFiltro = New Entity.Registro.Interno_Grilla

            With objEntFiltro
                .IDInternoString = IDInternoString
                .NombreAsociadoPrincipal = 0 'solo asociados
                .NombreAsociadoEstado = 1 'estado activos
                .IDRegion = RegionID
                .IDPenal = PenalID
            End With
            '/********************************************************/

            'coleccion de nombres asociados
            Dim objEntColNA As New Entity.Registro.Interno_Grilla.NombresAsociadosCol
            objEntColNA = Listar_NombresAsociados(objEntFiltro)

            Dim objEntAll As Entity.Registro.Interno
            Dim value As New Entity.Registro.InternoCol

            For Each objEnt As Entity.Registro.Interno In objEntListaInternoCol

                objEntAll = New Entity.Registro.Interno
                With objEntAll
                    .Codigo = objEnt.Codigo
                    .CodigoRP = objEnt.CodigoRP
                    .IngresoID = objEnt.IngresoID
                    .CodigoPadre = 0
                    .ApellidoPaterno = objEnt.ApellidoPaterno
                    .ApellidoMaterno = objEnt.ApellidoMaterno
                    .Nombres = objEnt.Nombres
                    .SexoID = objEnt.SexoID
                    .TipoDocumentoNombre = objEnt.TipoDocumentoNombre
                    .NumeroDocumento = objEnt.NumeroDocumento
                    .FechaNacimiento = objEnt.FechaNacimiento
                    .NacionalidadNombre = objEnt.NacionalidadNombre
                    '/*alias*/
                    .InternoAlias = objEnt.InternoAlias
                    '/*otros*/
                    .PabellonNombre = objEnt.PabellonNombre
                    .RegionID = objEnt.RegionID
                    .RegionNombre = objEnt.RegionNombre
                    .PenalID = objEnt.PenalID
                    .PenalNombre = objEnt.PenalNombre
                    '/*estado*/
                    .EstadoID = objEnt.EstadoID
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    'fotos
                    .FotoPerfilIzquierdo = objEnt.FotoPerfilIzquierdo
                    .FotoPerfilFrente = objEnt.FotoPerfilFrente
                    .FotoPerfilDerecho = objEnt.FotoPerfilDerecho
                    .DMP = objEnt.DMP
                    .SMP = objEnt.SMP
                    .SituacionJuridicaId = objEnt.SituacionJuridicaId
                    .SituacionJuridicaNom = objEnt.SituacionJuridicaNom
                    .EstadoRncID = objEnt.EstadoRncID
                    .EstadoEspecificoID = objEnt.EstadoEspecificoID
                    .FechaIngreso = objEnt.FechaIngreso

                    .IdiomaNativoId = objEnt.IdiomaNativoId
                    .GeneroId = objEnt.GeneroId
                    .CentroTrabajo = objEnt.CentroTrabajo
                    .ReligionId = objEnt.ReligionId
                    .CodigoFuerzaArmadaId = objEnt.CodigoFuerzaArmadaId
                    .CodigoRangoId = objEnt.CodigoRangoId
                    .CodigoUnicoInterno = objEnt.CodigoUnicoInterno
                    .NombreClaveInterno = objEnt.NombreClaveInterno

                    .TrasladadoDeCarceleta = objEnt.TrasladadoDeCarceleta
                End With

                value.Add(objEntAll)

                For Each objEntNA As Entity.Registro.Interno_Grilla.NombresAsociados In objEntColNA
                    If objEnt.Codigo = objEntNA.InternoID Then
                        objEntAll = New Entity.Registro.Interno
                        With objEntAll
                            .CodigoPadre = 1
                            .Codigo = objEntNA.InternoID
                            .ApellidoPaterno = objEntNA.ApellidoPaterno
                            .ApellidoMaterno = objEntNA.ApellidoMaterno
                            .Nombres = objEntNA.Nombres
                            .PenalID = objEntNA.PenalID
                            .RegionID = objEntNA.RegionID
                        End With
                        value.Add(objEntAll)
                    End If
                Next
            Next
            Return value
        End Function

        Private Function Listar_Visita_Interno_Join(ByVal objEntListaInternoCol As Entity.Visita.InternoCol,
                                                         objEntNomAsoCol As Entity.Registro.Interno_Grilla.NombresAsociadosCol) As Entity.Visita.InternoCol

            Dim objEntAll As Entity.Visita.Interno
            Dim value As New Entity.Visita.InternoCol

            For Each objEnt As Entity.Visita.Interno In objEntListaInternoCol

                objEntAll = New Entity.Visita.Interno
                With objEntAll
                    .Codigo = objEnt.Codigo
                    .RowID = objEnt.RowID
                    .SedeRowId = objEnt.SedeRowId
                    .VersionRegistro = objEnt.VersionRegistro
                    .CodigoPadre = 0
                    'datos
                    .CodigoRP = objEnt.CodigoRP
                    .TipoDocumentoID = objEnt.TipoDocumentoID
                    .TipoDocumentoNombre = objEnt.TipoDocumentoNombre
                    .NumeroDocumento = objEnt.NumeroDocumento
                    .ApellidoPaterno = objEnt.ApellidoPaterno
                    .ApellidoMaterno = objEnt.ApellidoMaterno
                    .Nombres = objEnt.Nombres
                    .SexoID = objEnt.SexoID
                    .FechaNacimiento = objEnt.FechaNacimiento
                    .NacionalidadID = objEnt.NacionalidadID
                    .Nacionalidad = objEnt.Nacionalidad
                    .EtapaID = objEnt.EtapaID
                    .EtapaNombre = objEnt.EtapaNombre
                    .PabellonID = objEnt.PabellonID
                    .PabellonNombre = objEnt.PabellonNombre
                    'region - penal
                    .IDRegion = objEnt.IDRegion
                    .RegionNombre = objEnt.RegionNombre
                    .IDPenal = objEnt.IDPenal
                    .PenalNombre = objEnt.PenalNombre
                    .EstadoID = objEnt.EstadoID
                    '.EstadoNombre = objEnt.EstadoNombre
                End With

                value.Add(objEntAll)

                For Each objEntNA As Entity.Registro.Interno_Grilla.NombresAsociados In objEntNomAsoCol
                    If objEnt.Codigo = objEntNA.InternoID Then
                        objEntAll = New Entity.Visita.Interno
                        With objEntAll
                            .CodigoPadre = 1
                            .Codigo = objEntNA.InternoID
                            .ApellidoPaterno = objEntNA.ApellidoPaterno
                            .ApellidoMaterno = objEntNA.ApellidoMaterno
                            .Nombres = objEntNA.Nombres
                        End With
                        value.Add(objEntAll)
                    End If
                Next
            Next
            Return value
        End Function


#End Region
#Region "Filtros"
        Private Function FiltrarPorFechaIngreso(ByVal objEntListadoInternosCol As Entity.Registro.InternoCol,
                                             ByVal FechaInicio As Long, ByVal FechaFin As Long,
                                             ByVal RegionID As Integer, ByVal PenalID As Integer) As Entity.Registro.InternoCol

            'buscar en la bd por las fechas de ingreso del filtrado
            objEntFiltro = New Entity.Registro.Interno_Grilla

            With objEntFiltro
                .FechaIngresoIni = FechaInicio
                .FechaIngresoFin = If(FechaFin <> 0, System.DateTime.FromFileTime(FechaFin).AddDays(1).ToFileTime, 0) 'a las 00H:00M:00S del dia siguiente
                .IDRegion = RegionID
                .IDPenal = PenalID
            End With

            Dim objEntInternoFechaIngCol As New Entity.Registro.Interno_Grilla.InternoIngresoCol
            objEntInternoFechaIngCol = Listar_InternoIngreso(objEntFiltro)
            '/*************************************************************/

            '/*eliminar los internos que no cumplen con las fechas del filtrado*/
            Dim value As New Entity.Registro.InternoCol

            For Each objItem As Entity.Registro.Interno In objEntListadoInternosCol
                value.Add(objItem)
            Next

            Dim blnEliminar As Boolean = False
            For Each obj As Entity.Registro.Interno In objEntListadoInternosCol

                blnEliminar = True

                For Each obj2 As Entity.Registro.Interno_Grilla.InternoIngreso In objEntInternoFechaIngCol

                    If obj.Codigo = obj2.InternoID Then
                        blnEliminar = False
                        Exit For
                    Else
                        blnEliminar = True
                    End If
                Next

                If blnEliminar = True Then
                    value.Remove(obj)
                End If

            Next

            Return value

        End Function

        Private Function FiltrarPorDelitos(ByVal objEntListaInternosCol As Entity.Registro.InternoCol,
                                               ByVal DelitoGenericoID As Integer, ByVal DelitoEspecificoID As Integer,
                                               ByVal RegionID As Integer, ByVal PenalID As Integer) As Entity.Registro.InternoCol

            'bsucar en la bd de datos los delitos del filtrado
            objEntFiltro = New Entity.Registro.Interno_Grilla

            With objEntFiltro
                .IDDelitoGenerico = DelitoGenericoID
                .IDDelitoEspecifico = DelitoEspecificoID
                .IDRegion = RegionID
                .IDPenal = PenalID
            End With

            Dim objEntInternoDelitoCol As New Entity.Registro.DelitoCol
            objEntInternoDelitoCol = Listar_InternoDelito(objEntFiltro)

            '/*****************************************************************/

            '/*eliminar los internos que no cumplen con los delitos filtrados*/
            Dim value As New Entity.Registro.InternoCol

            For Each objItem As Entity.Registro.Interno In objEntListaInternosCol
                value.Add(objItem)
            Next

            Dim blnEliminar As Boolean = False
            For Each obj As Entity.Registro.Interno In objEntListaInternosCol

                blnEliminar = True

                For Each obj2 As Entity.Registro.Interno_Grilla.InternoDelito In objEntInternoDelitoCol

                    If obj.Codigo = obj2.InternoID Then
                        blnEliminar = False
                        Exit For
                    Else
                        blnEliminar = True
                    End If
                Next

                If blnEliminar = True Then
                    value.Remove(obj)
                End If

            Next

            Return value

        End Function

        Private Function FiltrarPorSituacionJuridica(ByVal ListadoInternosCol As Entity.Registro.InternoCol,
                                               ByVal IDSituacionJuridica As Integer, ByVal IDRegion As Integer, ByVal IDPenal As Integer) As Entity.Registro.InternoCol


            Dim objEntInternoIngresoCol As New Entity.Registro.Interno_Grilla.InternoIngresoCol
            objEntFiltro = New Entity.Registro.Interno_Grilla

            IDInternoString = fn_InternoIDSplit(ListadoInternosCol)

            With objEntFiltro
                .IDInternoString = IDInternoString
                .IDSituacionJuridica = IDSituacionJuridica
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With
            objEntInternoIngresoCol = Listar_InternoIngreso_SituacionJuridica(objEntFiltro)

            '/*copia de la lista de internos*/
            Dim objEntInternoCopiaCol As New Entity.Registro.InternoCol

            For Each objItem As Entity.Registro.Interno In ListadoInternosCol
                objEntInternoCopiaCol.Add(objItem)
            Next

            '/*recorres todos los expedientes de la bd de para obtener un solo interno y su situacion juridica actual */
            Dim intIDInterno As Integer = -1
            Dim objEntInternoCol_ParaIngreso As New Entity.Registro.InternoCol
            Dim objEntInterno_ParaIngreso As Entity.Registro.Interno = Nothing

            For Each objEntItemIngreso As Entity.Registro.Interno_Grilla.InternoIngreso In objEntInternoIngresoCol

                If intIDInterno = objEntItemIngreso.InternoID Then

                Else
                    '/*agregar al trabajador con su situacion actual*/
                    objEntInterno_ParaIngreso = New Entity.Registro.Interno
                    With objEntInterno_ParaIngreso
                        .Codigo = objEntItemIngreso.InternoID
                        .SituacionJuridicaId = CalcularSitucacionJuridica(objEntItemIngreso.InternoID, objEntInternoIngresoCol)
                    End With
                    objEntInternoCol_ParaIngreso.Add(objEntInterno_ParaIngreso)
                    intIDInterno = objEntItemIngreso.InternoID
                End If

            Next

            '/*copiar en un nuevo objeto, los internos que cumplan con el filtro de situacion juridica*/
            Dim objEntInternoCol_SitJur As New Entity.Registro.InternoCol
            For Each objEnt As Entity.Registro.Interno In objEntInternoCol_ParaIngreso

                If objEnt.SituacionJuridicaId = IDSituacionJuridica Then
                    objEntInternoCol_SitJur.Add(objEnt)
                End If

            Next

            Dim blnEliminar As Boolean = False
            For Each objItemInterno As Entity.Registro.Interno In ListadoInternosCol

                blnEliminar = True

                For Each objItemIternoSitJur As Entity.Registro.Interno In objEntInternoCol_SitJur

                    If objItemInterno.Codigo = objItemIternoSitJur.Codigo Then
                        blnEliminar = False
                        Exit For
                    Else
                        blnEliminar = True
                    End If
                Next

                If blnEliminar = True Then
                    objEntInternoCopiaCol.Remove(objItemInterno)
                End If

            Next

            Return objEntInternoCopiaCol

        End Function

        Private Function FiltrarPorSituacionJuridica_v5(ByVal ListadoInternosCol As Entity.Registro.InternoCol,
                                              ByVal IDSituacionJuridica As Integer, ByVal IDRegion As Integer, ByVal IDPenal As Integer) As Entity.Registro.InternoCol


            Dim objEntInternoIngresoCol As New Entity.Registro.Interno_Grilla.InternoIngresoCol
            objEntFiltro = New Entity.Registro.Interno_Grilla

            With objEntFiltro
                .IDInternoString = IDInternoString
                .IDSituacionJuridica = IDSituacionJuridica
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With
            objEntInternoIngresoCol = Listar_InternoIngreso_SituacionJuridica_v5(objEntFiltro)

            '/*copia de la lista de internos*/
            Dim objEntInternoCopiaCol As New Entity.Registro.InternoCol

            For Each objItem As Entity.Registro.Interno In ListadoInternosCol
                objEntInternoCopiaCol.Add(objItem)
            Next

            '/*recorres todos los expedientes de la bd de para obtener un solo interno y su situacion juridica actual */
            Dim intIDInterno As Integer = -1
            Dim objEntInternoCol_ParaIngreso As New Entity.Registro.InternoCol
            Dim objEntInterno_ParaIngreso As Entity.Registro.Interno = Nothing

            For Each objEntItemIngreso As Entity.Registro.Interno_Grilla.InternoIngreso In objEntInternoIngresoCol

                If intIDInterno = objEntItemIngreso.InternoID Then

                Else
                    '/*agregar al trabajador con su situacion actual*/
                    objEntInterno_ParaIngreso = New Entity.Registro.Interno
                    With objEntInterno_ParaIngreso
                        .Codigo = objEntItemIngreso.InternoID
                        .SituacionJuridicaId = CalcularSitucacionJuridica(objEntItemIngreso.InternoID, objEntInternoIngresoCol)
                    End With
                    objEntInternoCol_ParaIngreso.Add(objEntInterno_ParaIngreso)
                    intIDInterno = objEntItemIngreso.InternoID
                End If

            Next

            '/*copiar en un nuevo objeto, los internos que cumplan con el filtro de situacion juridica*/
            Dim objEntInternoCol_SitJur As New Entity.Registro.InternoCol
            For Each objEnt As Entity.Registro.Interno In objEntInternoCol_ParaIngreso

                If objEnt.SituacionJuridicaId = IDSituacionJuridica Then
                    objEntInternoCol_SitJur.Add(objEnt)
                End If

            Next

            Dim blnEliminar As Boolean = False
            For Each objItemInterno As Entity.Registro.Interno In ListadoInternosCol

                blnEliminar = True

                For Each objItemIternoSitJur As Entity.Registro.Interno In objEntInternoCol_SitJur

                    If objItemInterno.Codigo = objItemIternoSitJur.Codigo Then
                        blnEliminar = False
                        Exit For
                    Else
                        blnEliminar = True
                    End If
                Next

                If blnEliminar = True Then
                    objEntInternoCopiaCol.Remove(objItemInterno)
                End If

            Next

            Return objEntInternoCopiaCol

        End Function

        Private Function FiltrarxSituacionJuridica_SedeCentral(ByVal ListadoInternosCol As Entity.Registro.InternoCol,
                                                                ByVal IDSituacionJuridica As Integer, ByVal IDRegion As Integer,
                                                               ByVal IDPenal As Integer) As Entity.Registro.InternoCol


            Dim objEntInternoIngresoCol As New Entity.Registro.Interno_Grilla.InternoIngresoCol
            objEntFiltro = New Entity.Registro.Interno_Grilla

            'recorre los id de los internos filtrados
            IDInternoString = ""
            For Each interno As Entity.Registro.Interno In ListadoInternosCol
                IDInternoString = IDInternoString & interno.Codigo & ","
            Next
            If IDInternoString.Length > 0 Then
                IDInternoString = IDInternoString.Substring(0, IDInternoString.Length - 1)
            End If

            With objEntFiltro
                .IDInternoString = IDInternoString
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With
            objEntInternoIngresoCol = Listar_InternoxSituacionJuridica_SedeCentral(objEntFiltro)

            '/*copia de la lista de internos*/
            Dim objEntInternoCopiaCol As New Entity.Registro.InternoCol

            For Each objItem As Entity.Registro.Interno In ListadoInternosCol
                objEntInternoCopiaCol.Add(objItem)
            Next

            '/*recorres todos los expedientes de la bd de para obtener un solo interno y su situacion juridica actual */
            Dim intIDInterno As Integer = -1
            Dim objEntInternoCol_ParaIngreso As New Entity.Registro.InternoCol
            Dim objEntInterno_ParaIngreso As Entity.Registro.Interno = Nothing

            For Each objEntItemIngreso As Entity.Registro.Interno_Grilla.InternoIngreso In objEntInternoIngresoCol

                If intIDInterno = objEntItemIngreso.InternoID Then

                Else
                    '/*agregar al trabajador con su situacion actual*/
                    objEntInterno_ParaIngreso = New Entity.Registro.Interno
                    With objEntInterno_ParaIngreso
                        .Codigo = objEntItemIngreso.InternoID
                        .SituacionJuridicaId = CalcularSitucacionJuridica(objEntItemIngreso.InternoID, objEntInternoIngresoCol)
                    End With
                    objEntInternoCol_ParaIngreso.Add(objEntInterno_ParaIngreso)
                    intIDInterno = objEntItemIngreso.InternoID
                End If

            Next

            '/*copiar en un nuevo objeto, los internos que cumplan con el filtro de situacion juridica*/
            Dim objEntInternoCol_SitJur As New Entity.Registro.InternoCol
            For Each objEnt As Entity.Registro.Interno In objEntInternoCol_ParaIngreso

                If objEnt.SituacionJuridicaId = IDSituacionJuridica Then
                    objEntInternoCol_SitJur.Add(objEnt)
                End If

            Next

            Dim blnEliminar As Boolean = False
            For Each objItemInterno As Entity.Registro.Interno In ListadoInternosCol

                blnEliminar = True

                For Each objItemIternoSitJur As Entity.Registro.Interno In objEntInternoCol_SitJur

                    If objItemInterno.Codigo = objItemIternoSitJur.Codigo Then
                        blnEliminar = False
                        Exit For
                    Else
                        blnEliminar = True
                    End If
                Next

                If blnEliminar = True Then
                    objEntInternoCopiaCol.Remove(objItemInterno)
                End If

            Next

            Return objEntInternoCopiaCol

        End Function

        Private Function FiltrarxDelitos_LM(ByVal objEntListaInterno As Entity.Registro.InternoCol,
                                               intNumeroCola As Long,
                                               ByVal IDDelitoGenerico As Integer, ByVal IDDelitoEspecifico As Integer,
                                               ByVal IDRegion As Short, ByVal IDPenal As Short) As Entity.Registro.InternoCol

            'jmr, 07.01.2019
            'utilizable para carceleta, region lima y plm

            objEntFiltro = New Entity.Registro.Interno_Grilla
            With objEntFiltro
                .NCola = intNumeroCola
                .IDDelitoGenerico = IDDelitoGenerico
                .IDDelitoEspecifico = IDDelitoEspecifico
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With

            Dim strMensaje As String = ""
            Dim objEntResultFiltro As New List(Of Entity.Registro.Interno_Grilla.FiltroDelito)

            objEntResultFiltro = Listar_Filtro_Delito_LM(objEntFiltro, strMensaje)

            '/*copia de la lista de internos*/
            Dim objEntListaInternoCopia As New Entity.Registro.InternoCol

            For Each objItem As Entity.Registro.Interno In objEntListaInterno
                objEntListaInternoCopia.Add(objItem)
            Next

            Dim blnEliminar As Boolean = False
            For Each obj As Entity.Registro.Interno In objEntListaInterno

                blnEliminar = True

                For Each obj2 As Entity.Registro.Interno_Grilla.FiltroDelito In objEntResultFiltro

                    If obj.Codigo = obj2.IDInterno Then
                        blnEliminar = False
                        Exit For
                    Else
                        blnEliminar = True
                    End If
                Next

                If blnEliminar = True Then
                    objEntListaInternoCopia.Remove(obj)
                End If

            Next

            Return objEntListaInternoCopia

        End Function
        Private Function FiltrarxSituacionJuridica_LM(ByVal objEntListaInterno As Entity.Registro.InternoCol,
                                                        intNumeroCola As Long, ByVal intIDSituacionJuridica As Integer,
                                                        ByVal intIDRegion As Integer, ByVal intIDPenal As Integer) As Entity.Registro.InternoCol

            'jmr, 07.01.2019
            'utilizable para carceleta, region lima y plm

            objEntFiltro = New Entity.Registro.Interno_Grilla
            With Me.objEntFiltro
                .NCola = intNumeroCola
                .IDSituacionJuridica = intIDSituacionJuridica
                .IDRegion = intIDRegion
                .IDPenal = intIDPenal
            End With

            Dim strMensaje As String = ""
            Dim objEntResultFiltro As New List(Of Entity.Registro.Interno_Grilla.FiltroSituacionJuridica)

            objEntResultFiltro = Listar_Filtro_InternoxSituacionJuridica_LM(Me.objEntFiltro, strMensaje)

            '/*1.- recorres todos los expedientes de los internos, para filtrar x la situacion juridica filtarda*/
            Dim intIDInterno As Integer = -1
            Dim objEntResultFiltro2 As New List(Of Entity.Registro.Interno_Grilla.FiltroSituacionJuridica)

            For Each obj As Entity.Registro.Interno_Grilla.FiltroSituacionJuridica In objEntResultFiltro

                If intIDInterno = obj.IDInterno Then

                Else
                    '/*agregar al trabajador con su situacion actual*/
                    Dim objEntSitJur As New Entity.Registro.Interno_Grilla.FiltroSituacionJuridica
                    With objEntSitJur
                        .IDInterno = obj.IDInterno
                        .IDSitucionJuridica = fn_SitucacionJuridicaInterno(obj.IDInterno, objEntResultFiltro)
                    End With

                    'si la sijur, cumple con el filtro se agrega a la lista, caso contario queda exluida
                    If objEntSitJur.IDSitucionJuridica = intIDSituacionJuridica Then
                        objEntResultFiltro2.Add(objEntSitJur)
                    End If

                    intIDInterno = obj.IDInterno
                End If

            Next

            '/*2.- copia de la lista de internos*/
            Dim objEntListaInternoCopia As New Entity.Registro.InternoCol

            For Each objItem As Entity.Registro.Interno In objEntListaInterno
                objEntListaInternoCopia.Add(objItem)
            Next

            '3.- eliminar los internos que no corresponden con el filtro.
            Dim blnEliminar As Boolean = False
            For Each obj As Entity.Registro.Interno In objEntListaInterno

                blnEliminar = True

                For Each obj2 As Entity.Registro.Interno_Grilla.FiltroSituacionJuridica In objEntResultFiltro2

                    If obj.Codigo = obj2.IDInterno Then
                        blnEliminar = False
                        Exit For
                    Else
                        blnEliminar = True
                    End If
                Next

                If blnEliminar = True Then
                    objEntListaInternoCopia.Remove(obj)
                End If

            Next

            Return objEntListaInternoCopia

        End Function
        Private Function FiltrarxAlias_LM(ByVal objEntListaInterno As Entity.Registro.InternoCol,
                                       intNumeroCola As Long, ByVal strNombreAlias As String,
                                       ByVal IDRegion As Integer, ByVal IDPenal As Integer) As Entity.Registro.InternoCol

            'jmr, 07.01.2019
            'utilizable para carceleta, region lima y penale de lima metropolitana

            objEntFiltro = New Entity.Registro.Interno_Grilla
            With objEntFiltro
                .NCola = intNumeroCola
                .InternoAlias = strNombreAlias
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With

            Dim strMensaje As String = ""
            Dim objEntListaAlias As New List(Of Entity.Registro.Interno_Grilla.FiltroAlias)

            objEntListaAlias = Listar_Filtro_InternoxAlias_LM(objEntFiltro, strMensaje)

            '/*copia de la lista de internos*/
            Dim objEntListaInternoCopia As New Entity.Registro.InternoCol

            For Each objItem As Entity.Registro.Interno In objEntListaInterno
                objEntListaInternoCopia.Add(objItem)
            Next

            Dim blnEliminar As Boolean = False
            For Each obj As Entity.Registro.Interno In objEntListaInterno

                blnEliminar = True

                For Each obj2 As Entity.Registro.Interno_Grilla.FiltroAlias In objEntListaAlias

                    If obj.Codigo = obj2.IDInterno Then
                        blnEliminar = False
                        Exit For
                    Else
                        blnEliminar = True
                    End If
                Next

                If blnEliminar = True Then
                    objEntListaInternoCopia.Remove(obj)
                End If

            Next

            Return objEntListaInternoCopia

        End Function

#End Region
#Region "Business_Filtros"
        Public Function ListarNombresAsociados(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.Interno_Grilla.NombresAsociadosCol

            Return Listar_NombresAsociados(objEntFiltro)

        End Function
        Private Function Listar_NombresAsociados(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.Interno_Grilla.NombresAsociadosCol

            Dim value As New Entity.Registro.Interno_Grilla.NombresAsociadosCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_grilla_nombres_asociados", objEntFiltro)

            Try

                Dim objEnt As Entity.Registro.Interno_Grilla.NombresAsociados = Nothing

                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno_Grilla.NombresAsociados
                        With objEnt
                            .Codigo = sqlDr("int_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Principal = sqlDr("int_aso_pri").ToString
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString
                            .Estado = sqlDr("int_aso_est").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .RegionID = sqlDr("_RegId").ToString
                        End With
                        value.Add(objEnt)
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

            Return value

        End Function

        Private Function Listar_InternoIngreso(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.Interno_Grilla.InternoIngresoCol

            Dim value As New Entity.Registro.Interno_Grilla.InternoIngresoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            'Dim sqlDr As SqlDataReader = Data.Registro.Interno.ListarNombresAsociados_v2(sqlCon, "lst", "lst_grilla_fecha_ingreso", objEntFiltro)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_grilla_fecha_ingreso", objEntFiltro)

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt = New Entity.Registro.Interno_Grilla.InternoIngreso
                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                        End With
                        value.Add(objEnt)
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
            Return value

        End Function

        Private Function Listar_InternoDelito(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.Interno_Grilla.InternoDelitoCol

            Dim value As New Entity.Registro.Interno_Grilla.InternoDelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_grilla_delito", objEntFiltro)

            Dim objEnt As Entity.Registro.Interno_Grilla.InternoDelito = Nothing

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno_Grilla.InternoDelito
                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                        End With
                        value.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return value
        End Function

        Private Function Listar_InternoIngreso_SituacionJuridica(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.Interno_Grilla.InternoIngresoCol

            Dim value As New Entity.Registro.Interno_Grilla.InternoIngresoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            'Dim sqlDr As SqlDataReader = Data.Registro.Interno.ListarNombresAsociados_v2(sqlCon, "lst", "lst_grilla_situacion_juridica", objEntFiltro)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_grilla_situacion_juridica", objEntFiltro)

            Dim objEnt As Entity.Registro.Interno_Grilla.InternoIngreso = Nothing

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno_Grilla.InternoIngreso
                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                        End With
                        value.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return value
        End Function

        Private Function Listar_InternoIngreso_SituacionJuridica_v5(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.Interno_Grilla.InternoIngresoCol

            Dim value As New Entity.Registro.Interno_Grilla.InternoIngresoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_grilla_situacion_juridica_v5", objEntFiltro)

            Dim objEnt As Entity.Registro.Interno_Grilla.InternoIngreso = Nothing

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno_Grilla.InternoIngreso
                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                        End With
                        value.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return value
        End Function



        Private Function Listar_InternoxSituacionJuridica_SedeCentral(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.Interno_Grilla.InternoIngresoCol

            Dim value As New Entity.Registro.Interno_Grilla.InternoIngresoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.SedeCentral.Listar(sqlCon, "lst", "lst_grilla_situacion_juridica", objEntFiltro)

            Dim objEnt As Entity.Registro.Interno_Grilla.InternoIngreso = Nothing

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno_Grilla.InternoIngreso
                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                        End With
                        value.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return value
        End Function

        Private Function Listar_Filtro_Delito_LM(ByVal objEntFiltro As Entity.Registro.Interno_Grilla,
                                                     ByRef strMensaje As String) As List(Of Entity.Registro.Interno_Grilla.FiltroDelito)

            'jmr, 07.01.2019
            'utilizable para carceleta, region lima y plm

            Dim value As New List(Of Entity.Registro.Interno_Grilla.FiltroDelito)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_filtrar_delito_lm", objEntFiltro)

            Dim objEnt As Entity.Registro.Interno_Grilla.FiltroDelito = Nothing

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno_Grilla.FiltroDelito
                        With objEnt
                            .IDInterno = sqlDr("int_id").ToString
                            .IDDelitoGenerico = sqlDr("int_del_gen_id").ToString
                            .IDDelitoEspecifico = sqlDr("int_del_esp_id").ToString
                        End With
                        value.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                strMensaje = ex.Message
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return value
        End Function
        Private Function Listar_Filtro_InternoxSituacionJuridica_LM(ByVal objEntFiltro As Entity.Registro.Interno_Grilla,
                                                     ByRef strMensaje As String) As List(Of Entity.Registro.Interno_Grilla.FiltroSituacionJuridica)

            'jmr, 07.01.2019
            'utilizable para carceleta, region lima y plm

            Dim value As New List(Of Entity.Registro.Interno_Grilla.FiltroSituacionJuridica)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_filtrar_situacion_juridica_lm", objEntFiltro)

            Dim objEnt As Entity.Registro.Interno_Grilla.FiltroSituacionJuridica = Nothing

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno_Grilla.FiltroSituacionJuridica
                        With objEnt
                            .IDInterno = sqlDr("int_id").ToString
                            .IDSitucionJuridica = sqlDr("sit_jur_id").ToString
                        End With
                        value.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                strMensaje = ex.Message
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return value
        End Function
        Private Function Listar_Filtro_InternoxAlias_LM(ByVal objEntFiltro As Entity.Registro.Interno_Grilla,
                                                     ByRef strMensaje As String) As List(Of Entity.Registro.Interno_Grilla.FiltroAlias)

            'jmr, 07.01.2019
            'utilizable para carceleta, region lima y plm

            Dim value As New List(Of Entity.Registro.Interno_Grilla.FiltroAlias)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar(sqlCon, "lst", "lst_filtrar_alias_lm", objEntFiltro)

            Dim objEnt As Entity.Registro.Interno_Grilla.FiltroAlias = Nothing

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno_Grilla.FiltroAlias
                        With objEnt
                            .IDInterno = sqlDr("int_id").ToString
                            .Nombre = sqlDr("int_ali_nom").ToString
                        End With
                        value.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                strMensaje = ex.Message
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return value
        End Function
#End Region
#Region "Nueva_Version"
        Private Function BuscarNombresAsociados(lngCIDCola As Long,
                                                ByVal RegionID As Integer, ByVal PenalID As Integer) As Entity.Registro.Interno_Grilla.NombresAsociadosCol

            Dim value As New Entity.Registro.Interno_Grilla.NombresAsociadosCol

            'buscar en la bd los nombres asociados del filtrado
            objEntFiltro = New Entity.Registro.Interno_Grilla

            With objEntFiltro
                .NCola = lngCIDCola
                .IDRegion = RegionID
                .IDPenal = PenalID
            End With

            value = Listar_NombresAsociados_TInternoGrilla(objEntFiltro)

            Return value

        End Function

        Private Function Listar_NombresAsociados_TInternoGrilla(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.Interno_Grilla.NombresAsociadosCol

            Dim value As New Entity.Registro.Interno_Grilla.NombresAsociadosCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.Listar (sqlCon, "lst", "lst_nombres_asociados", objEntFiltro)

            Try

                Dim objEnt As Entity.Registro.Interno_Grilla.NombresAsociados = Nothing

                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno_Grilla.NombresAsociados
                        With objEnt
                            .Codigo = sqlDr("int_aso_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Principal = sqlDr("int_aso_pri").ToString
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString
                            .Estado = sqlDr("int_aso_est").ToString
                        End With
                        value.Add(objEnt)
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

            Return value

        End Function

        Private Sub generarInsertBusqueda(lngCola As Long, intIDInterno As Integer, intIDUsuario As Integer)

            With strSqlMasivo
                .AppendLine("insert into reg_mov_interno_grilla (n_cola,int_id,usu_id) values (" & lngCola & "," & intIDInterno & "," & intIDUsuario & ")")
            End With

        End Sub
        Private Function InsertMasivoInternoGrilla(strSql As String) As Integer

            Dim value As Integer = 0

            value = Data.Registro.InternoGrilla.Grabar(strSql)

            Return value

        End Function

        Private Sub DeleteInternoGrilla(lngCola As Long)

            Dim value As Integer = -1
            value = Data.Registro.InternoGrilla.Eliminar(lngCola)

        End Sub
#End Region
#Region "Funciones"
        Private Function CalcularSitucacionJuridica(IDInterno As Long, ObjEntIngresoCol As Entity.Registro.Interno_Grilla.InternoIngresoCol) As Integer

            Dim value As Integer = -1

            Dim intCountProc As Integer = 0
            Dim intCoutSent As Integer = 0

            For Each objEnt As Entity.Registro.Interno_Grilla.InternoIngreso In ObjEntIngresoCol

                If objEnt.InternoID = IDInterno Then
                    Select Case objEnt.SituacionJuridicaID
                        Case 1
                            intCountProc = intCountProc + 1
                        Case 2
                            intCoutSent = intCoutSent + 1
                    End Select
                End If

            Next

            If intCountProc > 0 And intCoutSent < 1 Then value = 1
            If intCountProc < 1 And intCoutSent > 0 Then value = 2
            If intCountProc > 0 And intCoutSent > 0 Then value = 3

            Return value

        End Function
        Private Function fn_SitucacionJuridicaInterno(intIDInterno As Long, ObjEntListaSitJur As List(Of Entity.Registro.Interno_Grilla.FiltroSituacionJuridica)) As Short

            Dim value As Short = -1

            Dim intCountProc As Short = 0
            Dim intCoutSent As Short = 0

            For Each objEnt As Entity.Registro.Interno_Grilla.FiltroSituacionJuridica In ObjEntListaSitJur

                If objEnt.IDInterno = intIDInterno Then
                    Select Case objEnt.IDSitucionJuridica
                        Case 1
                            intCountProc = intCountProc + 1
                        Case 2
                            intCoutSent = intCoutSent + 1
                    End Select
                End If

            Next

            If intCountProc > 0 And intCoutSent < 1 Then value = 1
            If intCountProc < 1 And intCoutSent > 0 Then value = 2
            If intCountProc > 0 And intCoutSent > 0 Then value = 3

            Return value

        End Function
        Private Function fn_InternoIDSplit(objCol As Entity.Registro.InternoCol) As String

            'recorre los id de los internos filtrados
            Dim value As String = ""
            For Each objEntInterno As Entity.Registro.Interno In objCol
                value = value & objEntInterno.Codigo & ","
            Next
            If value.Length > 0 Then
                value = value.Substring(0, value.Length - 1)
            End If

            Return value

        End Function
#End Region

        Public Class RegionLima

            Private objEnt As Entity.Registro.Interno = Nothing
            Private objEntCol As Entity.Registro.InternoCol = Nothing
            Private objEntFiltro As Entity.Registro.Interno_Grilla = Nothing
            Private objEntMovCol As Entity.Registro.InternoMovimientoCol = Nothing
            Private objEntMov As Entity.Registro.InternoMovimiento = Nothing

            Private objBss As Bussines.Registro.Interno_Grilla = Nothing

            Private strSqlMasivo As New System.Text.StringBuilder

            Public Function ListarGrillaMovimientoRL(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoMovimientoCol

                'version orl
                'fecha de inicio y fecha fin
                With objEntFiltro
                    .FechaIngresoIni = Legolas.Components.FechaHora.FechaTimeLong(.FechaIngresoIni, "00:00:00")
                    .FechaIngresoFin = Legolas.Components.FechaHora.FechaTimeLong(.FechaIngresoFin, "23:59:59")
                End With

                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

                Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.RegionLima.Listar(sqlCon, "lst", "lst_movimiento_grilla_lm", objEntFiltro)

                objEntMovCol = New Entity.Registro.InternoMovimientoCol

                Try

                    If sqlDr.HasRows Then
                        While sqlDr.Read
                            objEntMov = New Entity.Registro.InternoMovimiento
                            With objEntMov
                                .Codigo = sqlDr("mov_id").ToString
                                .RegionNombre = sqlDr("Region").ToString
                                .PenalNombre = sqlDr("Penal").ToString
                                .InternoID = sqlDr("int_id").ToString
                                .IngresoID = sqlDr("int_ing_id").ToString
                                .CodigoRP = sqlDr("int_cod_rp").ToString
                                .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                                .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                                .Nombres = sqlDr("int_nom").ToString
                                .Sexo = sqlDr("int_sex").ToString
                                .IngresoNro = sqlDr("int_ing_nro").ToString
                                .Fecha = sqlDr("mov_fec").ToString
                                .FechaCreaRegistro = sqlDr("_fec_cre").ToString
                                .FechaISP = sqlDr("int_ing_fec_isp").ToString
                                .MovimientoGrupoID = sqlDr("mov_grp_id").ToString
                                If .MovimientoGrupoID = 1 Then
                                    .MovimientoGrupoNombre = "I"
                                Else
                                    .MovimientoGrupoNombre = "E"
                                End If
                                .NacionalidadNombre = sqlDr("nac_nom").ToString
                                .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                                .MovimientoTipoNombre = sqlDr("mov_tip_nom").ToString
                                .MovimientoMotivoNombre = sqlDr("mov_mot_nom").ToString
                                .MovimientoTipoNombre = Legolas.Components.Cadena.ProperCase(.MovimientoTipoNombre & "/ " & .MovimientoMotivoNombre)
                                .DocumJudicialNum = sqlDr("doc_jud_num").ToString
                                .TipoAutoridadJudicialID = sqlDr("doc_jud_tip_aut_id").ToString
                                If .TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                    .AutoridadJudicialNombre = sqlDr("sal_jud_nom").ToString
                                Else

                                    .DocJudJuez = sqlDr("doc_jud_jue").ToString
                                    .DocJudSecretario = sqlDr("doc_jud_sec").ToString
                                    Dim strvalor As String = ""
                                    If .DocJudJuez <> "" And .DocJudSecretario <> "" Then
                                        strvalor = " / "
                                    End If
                                    .AutoridadJudicialNombre = .DocJudJuez & strvalor & .DocJudSecretario
                                End If
                                .OrigenNombre = sqlDr("mov_pen_org").ToString
                                If .OrigenNombre = "" Then
                                    .OrigenNombre = ""
                                    If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Or
                                   .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                                        .OrigenNombre = sqlDr("mov_org_otr").ToString
                                    End If
                                Else
                                    .OrigenNombre = "E.P. " & .OrigenNombre
                                End If
                                .DestinoNombre = sqlDr("mov_pen_des").ToString
                                If .DestinoNombre = "" Then
                                    .DestinoNombre = ""
                                    If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Or
                                    .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                                        .DestinoNombre = sqlDr("mov_des_otr").ToString
                                    End If
                                Else
                                    .DestinoNombre = "E.P. " & .DestinoNombre
                                End If
                                .EstadoID = sqlDr("mov_est_id").ToString
                                '.MovimientoRetorno = sqlDr("int_mov_ret").ToString'02-04-2018 en region ya no es necesario para condc
                                '.DelitoEspecificoNombre = sqlDr("int_del_esp_nom").ToString
                                '.FechaRegistro = sqlDr("_fec_cre").ToString

                                '/*clasificacion*/
                                .ClasificacionNumero = sqlDr("num_cla").ToString
                                .ClasificacionFecha = sqlDr("fec_cla").ToString
                                .ClasificacionPenalNombre = sqlDr("pen_nom_cla").ToString
                                .ClasificacionPenalOficio = sqlDr("ofi_cla").ToString
                                '/**/

                            End With
                            objEntMovCol.Add(objEntMov)
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
                Return objEntMovCol
            End Function

            Public Function Listar(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.InternoCol

                'jmr-23.07.2014
                'jmr-24.05.2016 xxx
                'mejorar el rendimiento de la busqueda por nombres asociados version 02
                'creado: 10/04/2017 -> se agrego busqueda por nombre clave, codigo unico de interno.
                'VERSION ORL

                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

                Dim intNumRamdon As New Random()
                Dim intValRandon As Integer = intNumRamdon.Next(1, 1200)
                Dim lngCola As Long = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana + Legolas.Configuration.Usuario.Codigo + Now.ToFileTime + intValRandon

                Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.RegionLima.Listar(sqlCon, "lst", "lst_grilla_regionlima",
                                                                                          objEntFiltro)

                Try
                    objEntCol = New Entity.Registro.InternoCol
                    If sqlDr.HasRows Then

                        While sqlDr.Read
                            objEnt = New Entity.Registro.Interno

                            With objEnt
                                .Codigo = sqlDr("int_id").ToString
                                .RowID = sqlDr("_RowId").ToString
                                .SedeRowId = sqlDr("_sed_rowid").ToString
                                .VersionRegistro = sqlDr("c_ver_reg").ToString
                                .CodigoRP = sqlDr("int_cod_rp").ToString
                                .CodigoPadre = sqlDr("int_pdr").ToString
                                .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                                .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                                .Nombres = sqlDr("int_nom").ToString
                                .SexoID = sqlDr("sex_id").ToString
                                .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                                .NumeroDocumento = sqlDr("int_doc_num").ToString
                                .FechaNacimiento = sqlDr("int_fec_nac").ToString
                                .NacionalidadNombre = sqlDr("nac_nom").ToString
                                '/*alias*/
                                .InternoAlias = sqlDr("ali_nom").ToString
                                '/*otros*/
                                .RegionID = sqlDr("reg_id").ToString
                                .RegionNombre = sqlDr("reg_nom").ToString
                                .PenalID = sqlDr("pen_id").ToString
                                .PenalNombre = sqlDr("pen_nom").ToString
                                .PabellonNombre = sqlDr("pab_str").ToString
                                '/*estado*/
                                .EstadoID = sqlDr("int_est_id").ToString
                                .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                                .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                                .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                                .DMP = sqlDr("int_DMP").ToString
                                .SMP = sqlDr("int_SMP").ToString
                                .EstadoRncID = sqlDr("int_est_rnc").ToString

                                .CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                                .NombreClaveInterno = sqlDr("c_int_nom_clav").ToString
                                .TrasladadoDeCarceleta = sqlDr("n_car_est_trs_id").ToString
                                '-------campos de nueva version----------------
                                .EstadoEspecificoID = sqlDr("n_int_est_esp").ToString
                            End With
                            objEntCol.Add(objEnt)

                            'grabar los internos filtrados en internogrilla                            
                            generarInsertBusqueda(lngCola, objEnt.Codigo, Legolas.Configuration.Usuario.Codigo) 'agregar registros a la cola de busqueda                            

                        End While
                    End If
                Catch ex As Exception
                    objBss = New Bussines.Registro.Interno_Grilla
                    objBss.DeleteInternoGrilla(lngCola) 'eliminar los registros de la cola de busqueda
                    Throw New Exception(ex.ToString)
                Finally
                    sqlDr.Dispose()
                    sqlDr.Close()
                    sqlDr = Nothing

                    sqlCon.Dispose()
                    sqlCon.Close()
                    sqlCon = Nothing
                End Try

                Dim objEntColReturn As New Entity.Registro.InternoCol

                'verificar que el resultado de busqueda traiga mas de un registro
                If Not objEntCol Is Nothing Then
                    If objEntCol.Count > 0 Then

                        '/**********listar nombres asociados********/
                        objBss = New Bussines.Registro.Interno_Grilla
                        objBss.InsertMasivoInternoGrilla(strSqlMasivo.ToString())
                        Dim objEntNomAsocCol As New Entity.Registro.Interno_Grilla.NombresAsociadosCol

                        objBss = New Bussines.Registro.Interno_Grilla
                        objEntNomAsocCol = objBss.BuscarNombresAsociados(lngCola, objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                        '/*****************************************/
                        objBss = New Bussines.Registro.Interno_Grilla
                        objEntColReturn = objBss.Listar_RegionLimaCarceletaPLM_Join(objEntCol, objEntNomAsocCol)
                        objBss = New Bussines.Registro.Interno_Grilla
                        objBss.DeleteInternoGrilla(lngCola) 'eliminar los registros de la cola de busqueda

                        Dim objEntNA As Entity.Registro.InternoCol = Nothing

                        'filtrar por delito generico y especifico
                        If objEntFiltro.IDDelitoGenerico > 0 Or objEntFiltro.IDDelitoEspecifico > 0 Then

                            objEntNA = New Entity.Registro.InternoCol
                            objEntNA = objEntColReturn

                            objEntColReturn = FiltrarPorDelitos(objEntNA, objEntFiltro.IDDelitoGenerico,
                                                                    objEntFiltro.IDDelitoEspecifico,
                                                                    objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                        End If

                        'filtrar por situacion juridica del ultimo internamiento
                        If objEntFiltro.IDSituacionJuridica > 0 Then

                            objEntNA = New Entity.Registro.InternoCol
                            objEntNA = objEntColReturn

                            objEntColReturn = FiltrarPorSituacionJuridica(objEntNA,
                                                                    objEntFiltro.IDSituacionJuridica,
                                                                    objEntFiltro.IDRegion, objEntFiltro.IDPenal)
                        End If

                    End If
                End If

                Return objEntColReturn

            End Function

            Private Sub generarInsertBusqueda(lngCola As Long, intIDInterno As Integer, intIDUsuario As Integer)

                With strSqlMasivo
                    .AppendLine("insert into reg_mov_interno_grilla (n_cola,int_id,usu_id) values (" & lngCola & "," & intIDInterno & "," & intIDUsuario & ")")
                End With
            End Sub

            Public Function ListarInternoBusquedaAntecedente(ByVal objEntFiltro As Entity.Registro.Interno_Grilla, blnCoincidenciaTotal As Boolean) As Entity.Registro.InternoCol

                'hrb,05.04.2018
                'jeu 28.06.2019
                'jmr 11.03.2020                

                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.RegionLima.Listar(sqlCon, "lst", "lst_grilla_interno_popup",
                                                                                      objEntFiltro)
                Try
                    objEntCol = New Entity.Registro.InternoCol
                    If sqlDr.HasRows Then

                        While sqlDr.Read
                            objEnt = New Entity.Registro.Interno

                            With objEnt
                                .Codigo = sqlDr("int_id").ToString
                                .CodigoRP = sqlDr("int_cod_rp").ToString
                                '.CodigoPadre = sqlDr("int_pdr").ToString
                                .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                                .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                                .Nombres = sqlDr("int_nom").ToString
                                .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                                .NumeroDocumento = sqlDr("int_doc_num").ToString
                                '/*otros*/
                                .RegionID = sqlDr("reg_id").ToString
                                .RegionNombre = sqlDr("reg_nom").ToString
                                .PenalID = sqlDr("pen_id").ToString
                                .PenalNombre = sqlDr("pen_nom").ToString
                                '/*estado*/
                                .EstadoID = sqlDr("int_est_id").ToString
                            End With

                            If blnCoincidenciaTotal = True Then

                                If objEntFiltro.PrimerApellido.Trim = objEnt.ApellidoPaterno.Trim Then
                                    If objEntFiltro.SegundoApellido.Trim = objEnt.ApellidoMaterno.Trim Then

                                        If objEntFiltro.PreNombres.Trim = objEnt.Nombres.Trim Then
                                            objEntCol.Add(objEnt)
                                        End If
                                    End If
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

            Private Function FiltrarPorDelitos(ByVal objEntListaInternosCol As Entity.Registro.InternoCol,
                                               ByVal DelitoGenericoID As Integer, ByVal DelitoEspecificoID As Integer,
                                               ByVal RegionID As Integer, ByVal PenalID As Integer) As Entity.Registro.InternoCol

                'bsucar en la bd de datos los delitos del filtrado
                objEntFiltro = New Entity.Registro.Interno_Grilla

                With objEntFiltro
                    .IDDelitoGenerico = DelitoGenericoID
                    .IDDelitoEspecifico = DelitoEspecificoID
                    .IDRegion = RegionID
                    .IDPenal = PenalID
                End With

                Dim objEntInternoDelitoCol As New Entity.Registro.DelitoCol
                objEntInternoDelitoCol = Listar_InternoDelito(objEntFiltro)

                '/*****************************************************************/

                '/*eliminar los internos que no cumplen con los delitos filtrados*/
                Dim value As New Entity.Registro.InternoCol

                For Each objItem As Entity.Registro.Interno In objEntListaInternosCol
                    value.Add(objItem)
                Next

                Dim blnEliminar As Boolean = False
                For Each obj As Entity.Registro.Interno In objEntListaInternosCol

                    blnEliminar = True

                    For Each obj2 As Entity.Registro.Interno_Grilla.InternoDelito In objEntInternoDelitoCol

                        If obj.Codigo = obj2.InternoID Then
                            blnEliminar = False
                            Exit For
                        Else
                            blnEliminar = True
                        End If
                    Next

                    If blnEliminar = True Then
                        value.Remove(obj)
                    End If

                Next

                Return value

            End Function
            Private Function FiltrarPorSituacionJuridica(ByVal ListadoInternosCol As Entity.Registro.InternoCol,
                                               ByVal IDSituacionJuridica As Integer, ByVal IDRegion As Integer, ByVal IDPenal As Integer) As Entity.Registro.InternoCol


                Dim strIDInternoString As String = ""
                Dim objEntInternoIngresoCol As New Entity.Registro.Interno_Grilla.InternoIngresoCol
                objEntFiltro = New Entity.Registro.Interno_Grilla
                objBss = New Bussines.Registro.Interno_Grilla

                strIDInternoString = objBss.fn_InternoIDSplit(ListadoInternosCol)

                With objEntFiltro
                    .IDInternoString = strIDInternoString
                    .IDSituacionJuridica = IDSituacionJuridica
                    .IDRegion = IDRegion
                    .IDPenal = IDPenal
                End With
                objEntInternoIngresoCol = Listar_InternoIngreso_SituacionJuridica(objEntFiltro)

                '/*copia de la lista de internos*/
                Dim objEntInternoCopiaCol As New Entity.Registro.InternoCol

                For Each objItem As Entity.Registro.Interno In ListadoInternosCol
                    objEntInternoCopiaCol.Add(objItem)
                Next

                '/*recorres todos los expedientes de la bd de para obtener un solo interno y su situacion juridica actual */
                Dim intIDInterno As Integer = -1
                Dim objEntInternoCol_ParaIngreso As New Entity.Registro.InternoCol
                Dim objEntInterno_ParaIngreso As Entity.Registro.Interno = Nothing

                For Each objEntItemIngreso As Entity.Registro.Interno_Grilla.InternoIngreso In objEntInternoIngresoCol

                    If intIDInterno = objEntItemIngreso.InternoID Then

                    Else
                        '/*agregar al trabajador con su situacion actual*/
                        objEntInterno_ParaIngreso = New Entity.Registro.Interno
                        objBss = New Bussines.Registro.Interno_Grilla
                        With objEntInterno_ParaIngreso
                            .Codigo = objEntItemIngreso.InternoID
                            .SituacionJuridicaId = objBss.CalcularSitucacionJuridica(objEntItemIngreso.InternoID, objEntInternoIngresoCol)
                        End With
                        objEntInternoCol_ParaIngreso.Add(objEntInterno_ParaIngreso)
                        intIDInterno = objEntItemIngreso.InternoID
                    End If

                Next

                '/*copiar en un nuevo objeto, los internos que cumplan con el filtro de situacion juridica*/
                Dim objEntInternoCol_SitJur As New Entity.Registro.InternoCol
                For Each objEnt As Entity.Registro.Interno In objEntInternoCol_ParaIngreso

                    If objEnt.SituacionJuridicaId = IDSituacionJuridica Then
                        objEntInternoCol_SitJur.Add(objEnt)
                    End If

                Next

                Dim blnEliminar As Boolean = False
                For Each objItemInterno As Entity.Registro.Interno In ListadoInternosCol

                    blnEliminar = True

                    For Each objItemIternoSitJur As Entity.Registro.Interno In objEntInternoCol_SitJur

                        If objItemInterno.Codigo = objItemIternoSitJur.Codigo Then
                            blnEliminar = False
                            Exit For
                        Else
                            blnEliminar = True
                        End If
                    Next

                    If blnEliminar = True Then
                        objEntInternoCopiaCol.Remove(objItemInterno)
                    End If

                Next

                Return objEntInternoCopiaCol

            End Function

            Private Function Listar_InternoDelito(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.Interno_Grilla.InternoDelitoCol

                Dim value As New Entity.Registro.Interno_Grilla.InternoDelitoCol

                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.RegionLima.Listar(sqlCon, "lst", "lst_grilla_delito", objEntFiltro)

                Dim objEnt As Entity.Registro.Interno_Grilla.InternoDelito = Nothing

                Try

                    If sqlDr.HasRows Then
                        While sqlDr.Read
                            objEnt = New Entity.Registro.Interno_Grilla.InternoDelito
                            With objEnt
                                .InternoID = sqlDr("int_id").ToString
                            End With
                            value.Add(objEnt)
                        End While
                    End If
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                    Throw New Exception(ex.ToString)
                Finally
                    sqlDr.Dispose()
                    sqlDr.Close()
                    sqlDr = Nothing
                    sqlCon.Dispose()
                    sqlCon.Close()
                    sqlCon = Nothing
                End Try
                Return value
            End Function
            Private Function Listar_InternoIngreso_SituacionJuridica(ByVal objEntFiltro As Entity.Registro.Interno_Grilla) As Entity.Registro.Interno_Grilla.InternoIngresoCol

                Dim value As New Entity.Registro.Interno_Grilla.InternoIngresoCol

                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim sqlDr As SqlDataReader = Data.Registro.InternoGrilla.RegionLima.Listar(sqlCon, "lst", "lst_grilla_situacion_juridica", objEntFiltro)

                Dim objEnt As Entity.Registro.Interno_Grilla.InternoIngreso = Nothing

                Try

                    If sqlDr.HasRows Then
                        While sqlDr.Read
                            objEnt = New Entity.Registro.Interno_Grilla.InternoIngreso
                            With objEnt
                                .InternoID = sqlDr("int_id").ToString
                                .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            End With
                            value.Add(objEnt)
                        End While
                    End If
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                    Throw New Exception(ex.ToString)
                Finally
                    sqlDr.Dispose()
                    sqlDr.Close()
                    sqlDr = Nothing
                    sqlCon.Dispose()
                    sqlCon.Close()
                    sqlCon = Nothing
                End Try
                Return value
            End Function
        End Class
    End Class
End Namespace
