Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class Movimiento
        Private objEnt As Entity.Visita.Movimiento = Nothing
        Private objEntCol As Entity.Visita.MovimientoCol = Nothing
#Region "Functions"
        Public Shared Function Return_VisitanteID(ByVal MovimientoID As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Visita.Movimiento.ListarOutput("lst", "lst_visitante_id", MovimientoID, -1, "", -1, _
                                                           0, 0, -1, -1)

            Return value

        End Function
        Public Shared Function Return_InternoID(ByVal MovimientoID As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Visita.Movimiento.ListarOutput("lst", "lst_interno_id", MovimientoID, -1, "", -1, _
                                                           0, 0, -1, -1)

            Return value

        End Function
        Public Shared Function Return_IDInternoPJ(ByVal intIDMovimiento As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Visita.Movimiento.ListarOutput("lst", "lst_idinternopj", intIDMovimiento, -1, "", -1, _
                                                           0, 0, -1, -1)

            Return value

        End Function
#End Region
#Region "Validar"
        Public Function ValidarDobleIngresoVisitante(ByVal VisitanteID As Integer, _
                                                     ByVal FechaIngreso As Long, ByVal RegionID As Integer, _
                                                     ByVal PenalID As Integer) As Boolean


            Dim value As Boolean = False
            Dim intCount As Integer = 0

            intCount = Data.Visita.Movimiento.ListarOutput("val", "val_doble_ingreso", -1, VisitanteID, "", -1, _
                                                           FechaIngreso, 0, RegionID, PenalID)
            If intCount > 0 Then
                value = True
            End If

            Return value

        End Function
        Public Function ValidarNumeroPase(ByVal NumeroPase As String, ByVal FechaIngreso As Long, ByVal RegionID As Integer, _
                                          ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = False
            Dim intCount As Integer = 0

            intCount = Data.Visita.Movimiento.ListarOutput("val", "val_numero_pase", -1, -1, NumeroPase, -1, _
                                                           FechaIngreso, 0, RegionID, PenalID)
            If intCount > 0 Then
                value = True
            End If

            Return value

        End Function
        Public Shared Function ValidarNumeroVisitas(ByVal RegionID As Integer, ByVal PenalID As Integer, _
                                                    ByVal Fecha As Long, ByVal InternoID As Integer, _
                                                    ByVal ParentescoTipo As Integer, ByVal RegimenVisitaID As Integer, _
                                                    ByVal TipoVisitaID As Integer) As Integer

            Dim value As Integer = 0

            Dim objEntFiltro As New Entity.Visita.Movimiento
            With objEntFiltro
                .RegionID = RegionID
                .PenalID = PenalID
                .FechaIngreso = Fecha
                .InternoID = InternoID
                .ParentescoTipo = ParentescoTipo
                .RegimenVisitaID = RegimenVisitaID
                .TipoID = TipoVisitaID
            End With

            value = Data.Visita.Movimiento.ListarOutput("val", "val_count_visitas_x_interno", objEntFiltro)

            Return value

        End Function
#End Region
#Region "Listar"

        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.Movimiento

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", "lst_mant", _
                       Codigo, -1, -1, "", "", "", "", "", -1, "", "", "", "", "", "", "", 0, 0, -1, -1, -1, -1, _
                       "", -1, -1, -1, -1, -1)

            objEnt = New Entity.Visita.Movimiento

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .VisitaID = sqlDr("vis_id").ToString
                            .TipoInterno = sqlDr("n_mov_tip_int").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IDInternoPJ = sqlDr("kf_int_id_pj").ToString
                            .FechaIngreso = sqlDr("mov_fec_ing").ToString
                            .HoraIngreso = sqlDr("mov_hor_ing").ToString
                            .FechaSalida = sqlDr("mov_fec_sal").ToString
                            .HoraSalida = sqlDr("mov_hor_sal").ToString
                            '.EstadoId = sqlDr("mov_est_id").ToString
                            .MenoresCantidad = sqlDr("mov_vis_men_cnt").ToString
                            .MenoresTipo = sqlDr("mov_vis_men_tip").ToString
                            .PabellonID = sqlDr("pab_id").ToString
                            .TipoID = sqlDr("tip_id").ToString
                            '.MotivoID = sqlDr("mot_id").ToString
                            .ParentescoID = sqlDr("par_id").ToString
                            .PaseNumero = sqlDr("pas_num").ToString
                            .TipoIngresoPor = sqlDr("n_mov_tip_ing_por").ToString
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

        Public Function ListarGrillaMonitoreo(ByVal ObjEntFiltro As Entity.Visita.Movimiento) As Entity.Visita.MovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", "lst_grilla_movimiento_monitoreo", _
           ObjEntFiltro)

            Try
                objEntCol = New Entity.Visita.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.Visita.Movimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .MovimientoPadre = sqlDr("mov_prn_id").ToString
                            .MenoresTipo = sqlDr("mov_vis_men_tip").ToString
                            'visita
                            .VisitaID = sqlDr("vis_id").ToString
                            .VisitanteTipoDocumento = sqlDr("doc_tip_nom").ToString
                            .VisitanteNumeroDocumento = sqlDr("vis_doc_num").ToString
                            .VisitanteApePaterno = sqlDr("vis_ape_pat").ToString
                            .VisitanteApeMaterno = sqlDr("vis_ape_mat").ToString
                            .VisitanteNombres = sqlDr("vis_nom").ToString
                            .VisitanteApellidosyNombres = sqlDr("vis_ape_nom").ToString
                            .VisitanteSexoID = sqlDr("sex_id").ToString
                            .VisitanteFechaNacimiento = sqlDr("vis_fec_nac").ToString
                            .VisitanteFotoName = sqlDr("vis_fot").ToString
                            'interno
                            .TipoInterno = sqlDr("n_mov_tip_int").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IDInternoPJ = sqlDr("kf_int_id_pj").ToString

                            .InternoApePaterno = sqlDr("int_ape_pat").ToString
                            .InternoApeMaterno = sqlDr("int_ape_mat").ToString
                            .InternoNombres = sqlDr("int_nom").ToString
                            .InternoApellidosyNombres = sqlDr("int_ape_nom").ToString

                            'movimiento
                            .PaseNumero = sqlDr("pas_num").ToString
                            .ParentescoID = sqlDr("par_id").ToString
                            .ParentescoNombre = sqlDr("par_nom").ToString
                            '/**/
                            .FechaIngreso = sqlDr("mov_fec_ing").ToString
                            .HoraIngreso = sqlDr("mov_hor_ing").ToString
                            .FechaSalida = sqlDr("mov_fec_sal").ToString
                            .HoraSalida = sqlDr("mov_hor_sal").ToString
                            .MenoresCantidad = sqlDr("mov_vis_men_cnt").ToString
                            '/**/                            
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_nom").ToString
                            .RegimenVisitaID = sqlDr("reg_vis_id").ToString
                            .TipoID = sqlDr("tip_id").ToString
                            .TipoNombre = sqlDr("tip_nom").ToString.ToUpper
                            .EtapaNombre = sqlDr("etp_nom").ToString.ToUpper
                            If .EtapaNombre.Trim = "" Then
                                .EtapaNombre = "S/E"
                            End If
                            .Observacion = sqlDr("mov_obs").ToString
                            '/**/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*auditoria
                            .VisitanteValidadoReniec = sqlDr("mov_vis_val_rnc").ToString
                            .TipoIngresoPor = sqlDr("mov_vis_ing_por").ToString
                            .NumeroRecaptura = sqlDr("n_mov_num_rec_hue").ToString
                            .Audit_UsuarioCreacion = sqlDr("aud_usu_cre").ToString
                            .Audit_FechaCreacion = sqlDr("aud_fec_cre").ToString
                            .UsuarioAutorizaSalida = sqlDr("usu_ape_nom_aut_sal").ToString
                            .TipoSalidaPor = sqlDr("mov_vis_tip_sal").ToString
                            .UsuarioAutorizaSalidaSinHuella = sqlDr("usu_ape_nom_aut_sal_sin_hue").ToString
                            .ObservacionSalida = sqlDr("mov_obs_sal").ToString
                            'formato cadena
                            .VisitanteApellidosyNombres = Legolas.Components.Cadena.ProperCase(.VisitanteApellidosyNombres)

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
        Public Function ListarGrillaMovimiento(ByVal ObjEntFiltro As Entity.Visita.Movimiento) As Entity.Visita.MovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", "lst_grilla_movimiento", _
            ObjEntFiltro)

            Try
                objEntCol = New Entity.Visita.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.Visita.Movimiento
                        With objEnt

                            .Codigo = sqlDr("mov_id").ToString
                            .MovimientoPadre = sqlDr("mov_prn_id").ToString
                            .MenoresTipo = sqlDr("mov_vis_men_tip").ToString
                            'visita
                            .VisitaID = sqlDr("vis_id").ToString
                            'interno
                            .TipoInterno = sqlDr("n_mov_tip_int").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IDInternoPJ = sqlDr("kf_int_id_pj").ToString

                            Select Case .MenoresTipo
                                Case 1 'mayor

                                    Select Case .MovimientoPadre
                                        Case 0, -1
                                            'visita
                                            .VisitanteTipoDocumento = sqlDr("doc_tip_nom").ToString
                                            .VisitanteNumeroDocumento = sqlDr("vis_doc_num").ToString
                                            .VisitanteApePaterno = sqlDr("vis_ape_pat").ToString
                                            .VisitanteApeMaterno = sqlDr("vis_ape_mat").ToString
                                            .VisitanteNombres = sqlDr("vis_nom").ToString
                                            .VisitanteApellidosyNombres = sqlDr("vis_ape_nom").ToString
                                            .VisitanteSexoID = sqlDr("sex_id").ToString
                                            .VisitanteFechaNacimiento = sqlDr("vis_fec_nac").ToString
                                            .VisitanteFotoName = sqlDr("vis_fot").ToString
                                            'movimiento
                                            .PaseNumero = sqlDr("pas_num").ToString
                                        Case Else

                                    End Select

                                    'interno
                                    .InternoApePaterno = sqlDr("int_ape_pat").ToString
                                    .InternoApeMaterno = sqlDr("int_ape_mat").ToString
                                    .InternoNombres = sqlDr("int_nom").ToString
                                    .InternoApellidosyNombres = sqlDr("int_ape_nom").ToString


                                Case 2 'niño

                                    'visita
                                    .VisitanteTipoDocumento = sqlDr("doc_tip_nom").ToString
                                    .VisitanteNumeroDocumento = sqlDr("vis_doc_num").ToString
                                    .VisitanteApePaterno = sqlDr("vis_ape_pat").ToString
                                    .VisitanteApeMaterno = sqlDr("vis_ape_mat").ToString
                                    .VisitanteNombres = sqlDr("vis_nom").ToString
                                    .VisitanteApellidosyNombres = sqlDr("vis_ape_nom").ToString
                                    .VisitanteSexoID = sqlDr("sex_id").ToString
                                    .VisitanteFechaNacimiento = sqlDr("vis_fec_nac").ToString
                                    .VisitanteFotoName = sqlDr("vis_fot").ToString
                            End Select

                            'movimiento
                            .VisitanteValidadoReniec = sqlDr("mov_vis_val_rnc").ToString
                            .TipoIngresoPor = sqlDr("mov_vis_ing_por").ToString
                            .NumeroRecaptura = sqlDr("n_mov_num_rec_hue").ToString
                            .Audit_UsuarioCreacion = sqlDr("aud_usu_cre").ToString
                            .UsuarioAutorizaSalida = sqlDr("usu_ape_nom_aut_sal").ToString
                            .TipoSalidaPor = sqlDr("mov_vis_tip_sal").ToString
                            .UsuarioAutorizaSalidaSinHuella = sqlDr("usu_ape_nom_aut_sal_sin_hue").ToString
                            .ObservacionSalida = sqlDr("mov_obs_sal").ToString

                            .ParentescoID = sqlDr("par_id").ToString
                            .ParentescoNombre = sqlDr("par_nom").ToString
                            .FechaIngreso = sqlDr("mov_fec_ing").ToString
                            .HoraIngreso = sqlDr("mov_hor_ing").ToString
                            .FechaSalida = sqlDr("mov_fec_sal").ToString
                            .HoraSalida = sqlDr("mov_hor_sal").ToString
                            .MenoresCantidad = sqlDr("mov_vis_men_cnt").ToString
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_nom").ToString
                            .RegimenVisitaID = sqlDr("reg_vis_id").ToString
                            .TipoID = sqlDr("tip_id").ToString
                            .TipoNombre = sqlDr("tip_nom").ToString.ToUpper

                            .EtapaNombre = sqlDr("etp_nom").ToString.ToUpper
                            If .EtapaNombre.Trim = "" Then
                                .EtapaNombre = "S/E"
                            End If
                            .Observacion = sqlDr("mov_obs").ToString

                            'formato cadena
                            .VisitanteApellidosyNombres = Legolas.Components.Cadena.ProperCase(.VisitanteApellidosyNombres)
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

        Public Function ListarVisitaFueraFecha(ByVal RegionID As Integer, ByVal PenalID As Integer) As Entity.Visita.MovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", "lst_grilla_sin_salida", _
             -1, -1, _
             -1, "", "", "", "", "", _
             -1, "", "", "", "", "", "", "", _
             0, _
             0, _
             -1, _
             -1, _
             -1, _
             -1, _
             "", _
             -1, -1, -1, RegionID, PenalID)

            Try
                objEntCol = New Entity.Visita.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Movimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            'visita
                            .VisitaID = sqlDr("vis_id").ToString
                            .VisitanteApePaterno = sqlDr("vis_ape_pat").ToString
                            .VisitanteApeMaterno = sqlDr("vis_ape_mat").ToString
                            .VisitanteNombres = sqlDr("vis_nom").ToString
                            .VisitanteApellidosyNombres = sqlDr("vis_ape_nom").ToString
                            'interno
                            .InternoID = sqlDr("int_id").ToString
                            .InternoApePaterno = sqlDr("int_ape_pat").ToString
                            .InternoApeMaterno = sqlDr("int_ape_mat").ToString
                            .InternoNombres = sqlDr("int_nom").ToString
                            .InternoApellidosyNombres = sqlDr("int_ape_nom").ToString
                            'fecha ingreso
                            .FechaIngreso = sqlDr("mov_fec_ing").ToString
                            .HoraIngreso = sqlDr("mov_hor_ing").ToString
                            .PaseNumero = sqlDr("pas_num").ToString
                            .MenoresCantidad = sqlDr("mov_vis_men_cnt").ToString
                            .MenoresTipo = sqlDr("mov_vis_men_tip").ToString

                            'formato cadena
                            .VisitanteApellidosyNombres = Legolas.Components.Cadena.ProperCase(.VisitanteApellidosyNombres)

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

        Public Function ListarMovimientoFaltaSalida_v2(IDMovimiento As Integer, ByVal VisitanteID As Integer, ByVal FechaIngreso As Long, _
                                               ByVal RegionID As Integer, ByVal PenalID As Integer) As Entity.Visita.MovimientoCol

            '17.08.2015-jmondalgo

            objEnt = New Entity.Visita.Movimiento
            With objEnt
                .Codigo = IDMovimiento
                .VisitaID = VisitanteID
                .FechaInicio = FechaIngreso
                .RegionID = RegionID
                .PenalID = PenalID
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", "lst_movimiento_falta_salida", objEnt)

            Try
                objEntCol = New Entity.Visita.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Movimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .MovimientoPadre = sqlDr("mov_prn_id").ToString
                            .FechaIngreso = sqlDr("mov_fec_ing").ToString
                            .HoraIngreso = sqlDr("mov_hor_ing").ToString
                            .MenoresCantidad = sqlDr("mov_vis_men_cnt").ToString
                            .TipoID = sqlDr("tip_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
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

        Public Function ListarMovimientoFaltaHoraVerificacion(IDMovimiento As Integer, _
                                                       ByVal VisitanteID As Integer, ByVal FechaIngreso As Long, _
                                               ByVal RegionID As Integer, ByVal PenalID As Integer) As Entity.Visita.MovimientoCol

            '12.08.2015-jmondalgo

            objEnt = New Entity.Visita.Movimiento
            With objEnt
                .Codigo = IDMovimiento
                .VisitaID = VisitanteID
                .FechaInicio = FechaIngreso
                .RegionID = RegionID
                .PenalID = PenalID
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", "lst_movimiento_falta_hora_verificacion", objEnt)

            Try
                objEntCol = New Entity.Visita.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Movimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .MovimientoPadre = sqlDr("mov_prn_id").ToString
                            .VisitaID = sqlDr("vis_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FechaIngreso = sqlDr("mov_fec_ing").ToString
                            .HoraIngreso = sqlDr("mov_hor_ing").ToString
                            .MenoresTipo = sqlDr("mov_vis_men_tip").ToString
                            .MenoresCantidad = sqlDr("mov_vis_men_cnt").ToString
                            .RegimenVisitaID = sqlDr("reg_vis_id").ToString
                            .TipoID = sqlDr("tip_id").ToString
                            .ParentescoID = sqlDr("par_id").ToString
                            .ParentescoNombre = sqlDr("par_nom").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
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
        Public Function ListarMovimiento(ByVal InternoID As Integer, IDInternoPJ As Integer, ByVal VisitanteID As Integer, _
                                         ByVal lngFechaInicio As Long, _
                                         ByVal lngFechaFin As Long, _
        ByVal RegionID As Integer, ByVal PenalID As Integer) As Entity.Visita.MovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Visita.Movimiento
            With objEntFiltro
                .InternoID = InternoID
                .IDInternoPJ = IDInternoPJ
                .VisitaID = VisitanteID
                .FechaInicio = lngFechaInicio
                .FechaFin = lngFechaFin
                .RegionID = RegionID
                .PenalID = PenalID
            End With


            Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)

            'Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", "lst_grilla", _
            '-1, -1, _
            'VisitanteID, "", "", "", "", "", _
            'InternoID, "", "", "", "", "", "", "", _
            'FechaIngreso, _
            'FechaSalida, _
            '-1, _
            '-1, _
            '-1, _
            '-1, _
            '"", _
            '-1, -1, -1, RegionID, PenalID)

            Try
                objEntCol = New Entity.Visita.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Movimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            'visita
                            .VisitaID = sqlDr("vis_id").ToString
                            .VisitanteApePaterno = sqlDr("vis_ape_pat").ToString
                            .VisitanteApeMaterno = sqlDr("vis_ape_mat").ToString
                            .VisitanteNombres = sqlDr("vis_nom").ToString
                            .VisitanteApellidosyNombres = sqlDr("vis_ape_nom").ToString
                            'interno
                            .TipoInterno = sqlDr("n_mov_tip_int").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IDInternoPJ = sqlDr("kf_int_id_pj").ToString
                            .InternoApePaterno = sqlDr("int_ape_pat").ToString
                            .InternoApeMaterno = sqlDr("int_ape_mat").ToString
                            .InternoNombres = sqlDr("int_nom").ToString

                            If .TipoInterno = 1 Then
                                .InternoApellidosyNombres = sqlDr("int_ape_nom").ToString
                            Else
                                .InternoApellidosyNombres = sqlDr("int_ape_nom").ToString & " (PJ)"
                            End If

                            'fecha ingreso
                            .FechaIngreso = sqlDr("mov_fec_ing").ToString
                            .HoraIngreso = sqlDr("mov_hor_ing").ToString
                            .HoraSalida = sqlDr("mov_hor_sal").ToString
                            .FechaSalida = sqlDr("mov_fec_sal").ToString
                            .PaseNumero = sqlDr("pas_num").ToString
                            .MenoresCantidad = sqlDr("mov_vis_men_cnt").ToString
                            .MenoresTipo = sqlDr("mov_vis_men_tip").ToString
                            .ParentescoID = sqlDr("par_id").ToString
                            .ParentescoNombre = sqlDr("par_nom").ToString
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
        Public Function ListarMovimientoHijos(ByVal MovimientoPadre As Integer) As Entity.Visita.MovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEnt = New Entity.Visita.Movimiento
            With objEnt
                .MovimientoPadre = MovimientoPadre
            End With

            Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", "lst_movimientos_hijos", objEnt)

            Try
                objEntCol = New Entity.Visita.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Movimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .MovimientoPadre = sqlDr("mov_prn_id").ToString
                            .VisitaID = sqlDr("vis_id").ToString
                            .VisitanteApePaterno = sqlDr("vis_ape_pat").ToString
                            .VisitanteApeMaterno = sqlDr("vis_ape_mat").ToString
                            .VisitanteNombres = sqlDr("vis_ape_pat").ToString
                            .VisitanteApellidosyNombres = sqlDr("vis_ape_nom").ToString
                            .VisitanteFechaNacimiento = sqlDr("vis_fec_nac").ToString
                            .VisitanteFotoName = sqlDr("vis_fot").ToString
                            '.InternoID = sqlDr("int_id").ToString
                            '.InternoApePaterno = sqlDr("int_ape_pat").ToString
                            '.InternoApeMaterno = sqlDr("int_ape_mat").ToString
                            '.InternoNombres = sqlDr("int_nom").ToString
                            '.FechaIngreso = sqlDr("mov_fec_ing").ToString
                            '.HoraIngreso = sqlDr("mov_hor_ing").ToString
                            '.FechaSalida = sqlDr("mov_fec_sal").ToString
                            '.HoraSalida = sqlDr("mov_hor_sal").ToString
                            ''.EstadoID = sqlDr("mov_est_id").ToString
                            '.MenoresCantidad = sqlDr("mov_vis_men_cnt").ToString
                            .MenoresTipo = sqlDr("mov_vis_men_tip").ToString
                            '.PabellonID = sqlDr("pab_id").ToString
                            '.TipoID = sqlDr("tip_id").ToString
                            ''.MotivoID = sqlDr("mot_id").ToString
                            ''.MotivoNombre = sqlDr("mot_nom").ToString
                            .ParentescoID = sqlDr("par_id").ToString
                            .ParentescoNombre = sqlDr("par_nom").ToString
                            '.PaseNumero = sqlDr("pas_num").ToString
                        End With

                        If objEnt.MenoresTipo = 2 Then 'menores de edad
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
        Public Function ListarMovimientoHijos_v2(ByVal MovimientoPadre As Integer) As Entity.Visita.MovimientoCol

            '12.08.2015-jmondalgo

            objEnt = New Entity.Visita.Movimiento
            With objEnt
                .MovimientoPadre = MovimientoPadre
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", "lst_movimientos_hijos", objEnt)

            Try
                objEntCol = New Entity.Visita.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Movimiento
                        With objEnt
                            .Codigo = sqlDr("mov_id").ToString
                            .MovimientoPadre = sqlDr("mov_prn_id").ToString
                            'visitante
                            .VisitaID = sqlDr("vis_id").ToString
                            .VisitanteApePaterno = sqlDr("vis_ape_pat").ToString
                            .VisitanteApeMaterno = sqlDr("vis_ape_mat").ToString
                            .VisitanteNombres = sqlDr("vis_ape_pat").ToString
                            .VisitanteApellidosyNombres = sqlDr("vis_ape_nom").ToString
                            .VisitanteFechaNacimiento = sqlDr("vis_fec_nac").ToString
                            .VisitanteFotoName = sqlDr("vis_fot").ToString
                            .IDFotoVisitante = sqlDr("vis_fot_id").ToString
                            'interno
                            '.InternoID = sqlDr("int_id").ToString
                            '.InternoApePaterno = sqlDr("int_ape_pat").ToString
                            '.InternoApeMaterno = sqlDr("int_ape_mat").ToString
                            '.InternoNombres = sqlDr("int_nom").ToString
                            ''movimiento
                            '.FechaIngreso = sqlDr("mov_fec_ing").ToString
                            '.HoraIngreso = sqlDr("mov_hor_ing").ToString
                            '.FechaSalida = sqlDr("mov_fec_sal").ToString
                            '.HoraSalida = sqlDr("mov_hor_sal").ToString
                            '.MenoresCantidad = sqlDr("mov_vis_men_cnt").ToString
                            '.MenoresTipo = sqlDr("mov_vis_men_tip").ToString
                            '.PabellonID = sqlDr("pab_id").ToString
                            '.TipoID = sqlDr("tip_id").ToString
                            .ParentescoID = sqlDr("par_id").ToString
                            .ParentescoNombre = sqlDr("par_nom").ToString
                            '.PaseNumero = sqlDr("pas_num").ToString
                        End With

                        If objEnt.MenoresTipo = 2 Then 'menores de edad
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
#End Region
#Region "ListarNombreAsociado"
        Public Function ListarInternoHistoricoNA(objEntFiltro As Entity.Visita.Movimiento) As Entity.Visita.MovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Visita.Movimiento.Listar(sqlCon, "lst", _
            "lst_grilla_interno_historico", objEntFiltro)

            Try
                objEntCol = New Entity.Visita.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Movimiento
                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString
                            .InternoApePaterno = sqlDr("int_ape_pat").ToString
                            .InternoApeMaterno = sqlDr("int_ape_mat").ToString
                            .InternoNombres = sqlDr("int_nom").ToString
                            .InternoSitJuridica = sqlDr("sit_jur_nom").ToString
                            .ParentescoID = sqlDr("par_id").ToString
                            .ParentescoNombre = sqlDr("par_nom").ToString
                            .InternoEstado = sqlDr("int_est_id").ToString
                            '/**/
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
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

            'Return objEntCol
            Dim objValue As New Entity.Visita.MovimientoCol

            'llenar nombres asociados
            objValue = ListarNombresAsociadosAll(objEntCol, objEntFiltro.RegionID, objEntFiltro.PenalID)

            Return objValue

        End Function
        Private Function ListarNombresAsociadosAll(ByVal objEntCol As Entity.Visita.MovimientoCol, ByVal RegionID As Integer, _
                                       ByVal PenalID As Integer) As Entity.Visita.MovimientoCol

            'recorre los id de los internos filtrados
            Dim CadID As String = ""
            For Each interno As Entity.Visita.Movimiento In objEntCol
                CadID = CadID & interno.InternoID & ","
            Next
            If CadID.Length > 0 Then
                CadID = CadID.Substring(0, CadID.Length - 1)
            End If

            'filtro de nombres asociados
            Dim objEntFiltroNA As New Entity.Registro.NombreAsociado
            Dim objEntColNA As New Entity.Registro.NombreAsociadoCol
            Dim objBss As New Bussines.Registro.NombreAsociado

            With objEntFiltroNA
                .InternoIDString = CadID
                .Principal = 0 'solo asociados
                .Estado = 1 'estado activos
                .RegionID = RegionID
                .PenalID = PenalID
            End With

            objEntColNA = objBss.Listar_Grilla_v2(objEntFiltroNA)

            '/**/
            Dim objEntAll As Entity.Visita.Movimiento
            Dim objEntColAll As New Entity.Visita.MovimientoCol

            For Each obj As Entity.Visita.Movimiento In objEntCol

                objEntAll = New Entity.Visita.Movimiento
                With objEntAll
                    .InternoCodigoPadre = 0
                    .InternoID = obj.InternoID
                    .InternoCodigo = obj.InternoCodigo
                    .InternoApePaterno = obj.InternoApePaterno
                    .InternoApeMaterno = obj.InternoApeMaterno
                    .InternoNombres = obj.InternoNombres
                    .ParentescoID = obj.ParentescoID
                    .ParentescoNombre = obj.ParentescoNombre
                    .InternoEstado = obj.InternoEstado
                    '/**/
                    .RegionID = obj.RegionID
                    .PenalID = obj.PenalID
                End With

                objEntColAll.Add(objEntAll)

                For Each obj2 As Entity.Registro.NombreAsociado In objEntColNA

                    If obj.InternoID = obj2.InternoID Then

                        objEntAll = New Entity.Visita.Movimiento
                        With objEntAll
                            .InternoCodigoPadre = 1
                            .InternoID = obj2.InternoID
                            .InternoApePaterno = obj2.ApellidoPaterno
                            .InternoApeMaterno = obj2.ApellidoMaterno
                            .InternoNombres = obj2.Nombres
                            '/**/
                            .RegionID = obj.RegionID
                            .PenalID = obj.PenalID
                        End With
                        objEntColAll.Add(objEntAll)
                    End If
                Next
            Next
            Return objEntColAll
        End Function
#End Region
#Region "Grabar"

        Public Function GrabarSalida_v2(ByVal Codigo As Integer, ByVal FechaSalida As Long, _
        ByVal HoraSalida As String) As Integer

            'eliminar, despues de implementar el grabar huella 
            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_salida"

            objEnt = New Entity.Visita.Movimiento
            With objEnt
                .Codigo = Codigo
                .FechaSalida = FechaSalida
                .HoraSalida = HoraSalida
            End With

            value = Data.Visita.Movimiento.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function
        Public Function GrabarSalida_v3(ByVal Codigo As Integer, ByVal FechaSalida As Long, _
        ByVal HoraSalida As String, IDUsuario_AutorizaSalida As Integer, ObsSalida As String, TipoSalidaPor As Short, IDUsuario_AutorizaSalidaHuella As Integer) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_salida_huella"

            objEnt = New Entity.Visita.Movimiento
            With objEnt
                .Codigo = Codigo
                .FechaSalida = FechaSalida
                .HoraSalida = HoraSalida
                .IDUsuarioAutorizaSalida = IDUsuario_AutorizaSalida
                .ObservacionSalida = ObsSalida
                .TipoSalidaPor = TipoSalidaPor
                .IDUsuarioAutorizaSalidaSinHuella = IDUsuario_AutorizaSalidaHuella
            End With

            value = Data.Visita.Movimiento.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function
        Public Function GrabarFechaHoraVerificacion(ByVal Codigo As Integer, ByVal FechaVerificacion As Long, _
        ByVal HoraVerificacion As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_fecha_hora_verificacion"

            objEnt = New Entity.Visita.Movimiento
            With objEnt
                .Codigo = Codigo
                .FechaVerificacion = FechaVerificacion
                .HoraVerificacion = HoraVerificacion
            End With

            value = Data.Visita.Movimiento.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function

        Public Function Grabar(ByVal objEnt As Entity.Visita.Movimiento) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With objEnt

                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                intValue = Data.Visita.Movimiento.Grabar(strAccion, strOpcion, objEnt)
            End With


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
            intValue = Data.Visita.Movimiento.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue

        End Function
#End Region



    End Class
End Namespace