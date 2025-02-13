Imports System.Data
Imports System.Data.SqlClient
Namespace Reporte
    Public Class Visita
    
        Public Function VisitaMovimiento(ByVal objEntFiltro As Entity.Reporte.Visita.Filtro) As Entity.Reporte.Visita.MovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Visita.Listar(sqlCon, "lst", "lst_rpt_visita", _
            objEntFiltro)

            Dim objEntCol As New Entity.Reporte.Visita.MovimientoCol
            Dim objEnt As Entity.Reporte.Visita.Movimiento


            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Visita.Movimiento
                        With objEnt
                            .FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("vis_doc_num").ToString
                            .Sexo = sqlDr("sex_id").ToString
                            .VisitanteApePaterno = sqlDr("vis_ape_pat").ToString
                            .VisitanteApeMaterno = sqlDr("vis_ape_mat").ToString
                            .VisitanteNombres = sqlDr("vis_nom").ToString
                            .VisitaApellidosyNombres = sqlDr("vis_ape_nom").ToString
                            .FechaNacimiento = sqlDr("vis_fec_nac").ToString
                            .ParentescoNombre = sqlDr("par_nom").ToString
                            .InternoApePaterno = sqlDr("int_ape_pat").ToString
                            .InternoApeMaterno = sqlDr("int_ape_mat").ToString
                            .InternoNombres = sqlDr("int_nom").ToString
                            .InternoApellidosyNombres = sqlDr("int_ape_nom").ToString
                            .TipoVisitaNombre = sqlDr("tip_nom").ToString
                            .FechaMov = sqlDr("mov_fec_ing").ToString
                            .HoraIngreso = sqlDr("mov_hor_ing").ToString
                            .HoraSalida = sqlDr("mov_hor_sal").ToString
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
        Public Function SancionInternos(ByVal objEntFiltro As Entity.Reporte.Visita.Filtro) As Entity.Reporte.Visita.SancionInternoCol


            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Visita.Listar(sqlCon, "lst", "lst_rpt_sancion_internos", _
           objEntFiltro)

            Dim objEntCol As New Entity.Reporte.Visita.SancionInternoCol
            Dim objEnt As Entity.Reporte.Visita.SancionInterno = Nothing

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Visita.SancionInterno
                        With objEnt
                            .Penal = sqlDr("pen_nom").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            .FechaSancion = sqlDr("int_san_fec").ToString
                            .FechaSancionIni = sqlDr("int_san_ini").ToString
                            .FechaSancionFin = sqlDr("int_san_fin").ToString
                            .Motivo = sqlDr("san_tip_nom").ToString
                            .Documento = sqlDr("int_san_doc").ToString
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
        Public Function SancionVisitantes(ByVal objEntFiltro As Entity.Reporte.Visita.Filtro) As Entity.Reporte.Visita.SancionInternoCol


            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Visita.Listar(sqlCon, "lst", "lst_rpt_sancion_visitantes", _
            objEntFiltro)

            Dim objEntCol As New Entity.Reporte.Visita.SancionInternoCol
            Dim objEnt As Entity.Reporte.Visita.SancionInterno = Nothing

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Visita.SancionInterno
                        With objEnt
                            .Penal = sqlDr("pen_nom").ToString
                            .NumeroDocumento = sqlDr("vis_doc_num").ToString
                            .ApellidoPaterno = sqlDr("vis_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("vis_ape_mat").ToString
                            .Nombres = sqlDr("vis_nom").ToString
                            .FechaSancion = sqlDr("fec_san").ToString
                            .FechaSancionIni = sqlDr("fec_san_ini").ToString
                            .FechaSancionFin = sqlDr("fec_san_fin").ToString
                            .Motivo = sqlDr("san_tip_nom").ToString
                            .Documento = sqlDr("san_doc").ToString
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
        Public Function HistorialVisitante(ByVal objEntFiltro As Entity.Reporte.Visita.Filtro) As Entity.Reporte.Visita.HistorialVisitanteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Visita.Listar(sqlCon, "lst", "lst_rpt_historial_visitante", objEntFiltro)

            Dim objEntCol As New Entity.Reporte.Visita.HistorialVisitanteCol
            Dim objEnt As Entity.Reporte.Visita.HistorialVisitante = Nothing

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Visita.HistorialVisitante
                        With objEnt
                            '.FechaHoy = Legolas.Configuration.Aplication.FechayHora.FechaLong
                            'parametricas
                            .Par_Region = sqlDr("lic_reg_nom").ToString
                            .Par_Penal = sqlDr("lic_pen_nom").ToString                            
                            '/*datos*/                            
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("vis_doc_num").ToString
                            .ApellidoPaterno = sqlDr("vis_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("vis_ape_mat").ToString
                            .Nombres = sqlDr("vis_nom").ToString
                            '/*interno*/
                            .TipoInterno = sqlDr("n_mov_tip_int").ToString
                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString
                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString

                            If .TipoInterno = 1 Then
                                .InternoApellidosyNombres = sqlDr("int_ape_nom").ToString
                            Else
                                .InternoApellidosyNombres = sqlDr("int_ape_nom").ToString & " (PJ)"
                            End If

                            '/*movimiento*/
                            .NumeroPase = sqlDr("pas_num").ToString
                            .Parentesco = sqlDr("par_nom").ToString
                            .FechaIngreso = sqlDr("mov_fec_ing").ToString
                            .HoraIngreso = sqlDr("mov_hor_ing").ToString
                            .FechaSalida = sqlDr("mov_fec_sal").ToString
                            .HoraSalida = sqlDr("mov_hor_sal").ToString
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
        Public Function HistorialInterno(ByVal objEntFiltro As Entity.Reporte.Visita.Filtro) As Entity.Reporte.Visita.HistorialInternoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Visita.Listar(sqlCon, "lst", "lst_rpt_historial_interno", objEntFiltro)

            Dim objEntCol As New Entity.Reporte.Visita.HistorialInternoCol
            Dim objEnt As Entity.Reporte.Visita.HistorialInterno = Nothing

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Visita.HistorialInterno
                        With objEnt
                            .LicenciaRegion = sqlDr("lic_reg_nom").ToString
                            .LicenciaPenal = sqlDr("lic_pen_nom").ToString
                            '/*datos*/                            
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            'mov                   
                            .NumeroPase = sqlDr("pas_num").ToString
                            '.VisitantePrimerApellido = sqlDr("int_ape_pat").ToString
                            '.VisitanteSegundoApellido = sqlDr("int_ape_mat").ToString
                            '.VisitantePreNombres = sqlDr("int_nom").ToString
                            .VisitanteApellidosyNombres = sqlDr("vis_ape_nom").ToString
                            .Parentesco = sqlDr("par_nom").ToString
                            .FechaIngreso = sqlDr("mov_fec_ing").ToString
                            .HoraIngreso = sqlDr("mov_hor_ing").ToString
                            .FechaSalida = sqlDr("mov_fec_sal").ToString
                            .HoraSalida = sqlDr("mov_hor_sal").ToString

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
        Public Function Autorizacion(ByVal objEntFiltro As Entity.Reporte.Visita.Filtro) As DataSet

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim value As DataSet = Data.Reporte.Visita.ListarDataSet(sqlCon, "lst", "lst_rpt_autorizacion", objEntFiltro)

            Return value

        End Function
    End Class
End Namespace

