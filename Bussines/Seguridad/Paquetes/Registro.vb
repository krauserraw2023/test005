Imports System.Data
Imports System.Data.SqlClient
Namespace Seguridad.Paquetes
    Public Class Registro
        Private objEnt As Entity.Seguridad.Paquetes.Registro = Nothing
        Private objEntCol As Entity.Seguridad.Paquetes.RegistroCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Seguridad.Paquetes.Registro

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Seguridad.Paquetes.Registro
            objEntFiltro.codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Seguridad.Paquetes.Registro.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            objEnt = New Entity.Seguridad.Paquetes.Registro
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .codigo = sqlDr("pk_reg_pqt_id").ToString
                            .idVisita = sqlDr("fk_vis_id").ToString
                            .visitaApellidosNombres = sqlDr("c_vis_ape_nom").ToString
                            .visitaNumeroDocumento = sqlDr("c_vis_num_doc").ToString
                            .idInterno = sqlDr("fk_int_id").ToString
                            .internoApellidosNombres = sqlDr("c_int_ape_nom").ToString
                            .idParentesco = sqlDr("fk_par_id").ToString
                            .fechaRegistro = sqlDr("f_fec_reg").ToString
                            .tipoPresentacion = sqlDr("n_tip_pre").ToString
                            .idTipoArticulo = sqlDr("fk_tip_art_id").ToString
                            .peso = sqlDr("n_pes").ToString
                            .numeroElementos = sqlDr("n_num_ele").ToString
                            .observacion = sqlDr("c_obs").ToString
                            .idFotoPaquete = sqlDr("fk_fot_pqt_id").ToString
                            .nombreFotoPaquete = sqlDr("c_nom_arc_fot").ToString
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
        Public Function listarGrilla(ByVal objEntFiltro As Entity.Seguridad.Paquetes.Registro) As Entity.Seguridad.Paquetes.RegistroCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            'aplicar el filtro x fechas y horas
            Dim fechaInicio As Date = objEntFiltro.fechaInicio
            Dim fechaFin As Date = objEntFiltro.fechaFin

            objEntFiltro.fechaInicio = fechaInicio.Day & "/" & fechaInicio.Month & "/" & fechaInicio.Year & " 00:00:00"
            objEntFiltro.fechaFin = fechaFin.Day & "/" & fechaFin.Month & "/" & fechaFin.Year & " 23:59:59"
            '/****************************/

            Dim sqlDr As SqlDataReader = Data.Seguridad.Paquetes.Registro.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)

            Try
                objEntCol = New Entity.Seguridad.Paquetes.RegistroCol
                If sqlDr.HasRows Then

                    Dim fechaHoy As Long = Legolas.LBusiness.Globall.DateTime.FechaServerLong

                    While sqlDr.Read
                        objEnt = New Entity.Seguridad.Paquetes.Registro
                        With objEnt
                            .codigo = sqlDr("pk_reg_pqt_id").ToString
                            .fechaRegistro = sqlDr("f_fec_reg").ToString
                            .idVisita = sqlDr("fk_vis_id").ToString
                            .visitaApellidosNombres = sqlDr("c_vis_ape_nom").ToString
                            .visitaTipoDocumento = sqlDr("c_vis_tip_doc").ToString
                            .visitaNumeroDocumento = sqlDr("c_vis_num_doc").ToString
                            .visitaSexoNombre = sqlDr("c_vis_sex").ToString
                            'visita edad
                            .visitaFechaNacimiento = sqlDr("n_vis_fec_nac").ToString
                            If .visitaFechaNacimiento > 0 Then
                                Dim edad As Short = Legolas.Components.FechaHora.FechaCalcularAnio(.visitaFechaNacimiento, fechaHoy, True)
                                .visitaEdad = edad
                            Else
                                .visitaEdad = ""
                            End If
                            .visitaFotoNombre = sqlDr("vis_fot").ToString
                            '/***************************************/                            
                            .nombreParentesco = sqlDr("c_par_nom").ToString
                            'datos del interno
                            .tipoInterno = sqlDr("n_tip_int").ToString
                            .idInterno = sqlDr("fk_int_id").ToString
                            .idInternoPJ = sqlDr("fk_int_id_pj").ToString
                            If .tipoInterno = 2 Then 'interno pj
                                .internoApellidosNombres = sqlDr("c_int_ape_nom").ToString + " (PJ)"
                            Else
                                .internoApellidosNombres = sqlDr("c_int_ape_nom").ToString
                            End If
                            '/****************************/
                            .tipoPaqueteNombre = sqlDr("tip_paq_nom").ToString
                            .tipoPresentacionNombre = sqlDr("c_tip_pre_nom").ToString
                            .tipoArticuloNombre = sqlDr("c_tip_art_nom").ToString
                            .peso = sqlDr("n_pes").ToString
                            .numeroElementos = sqlDr("n_num_ele").ToString
                            .entregaDinero = sqlDr("b_env_din").ToString
                            .montoDinero = sqlDr("n_mon_din").ToString
                            .entregaMedicamento = sqlDr("b_env_med").ToString
                            .autorizacionNumDoc = sqlDr("c_aut_num_doc").ToString

                            'fecha de documento de autorizacion
                            If IsDBNull(sqlDr("f_fec_doc")) = False Then
                                Dim fechaDoc As Date = sqlDr("f_fec_doc").ToString
                                .autorizacionFechaDocString = fechaDoc.ToShortDateString
                            End If

                            .observacion = sqlDr("c_obs").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .idFotoPaquete = sqlDr("fk_fot_pqt_id").ToString
                        End With

                        '/*filtro entrega de dinero*/
                        Dim seInsertaDinero As Boolean = False
                        If objEntFiltro.filtroEntregaDinero = 0 And objEnt.entregaDinero = False Then
                            seInsertaDinero = True
                        End If

                        If objEntFiltro.filtroEntregaDinero = 1 And objEnt.entregaDinero = True Then
                            seInsertaDinero = True
                        End If

                        If objEntFiltro.filtroEntregaDinero = -1 Then
                            seInsertaDinero = True
                        End If

                        '/*filtro entrega de medicamentos*/
                        Dim seInsertaMedicamento As Boolean = False
                        If objEntFiltro.filtroEntregaMedicamento = 0 And objEnt.entregaMedicamento = False Then
                            seInsertaMedicamento = True
                        End If

                        If objEntFiltro.filtroEntregaMedicamento = 1 And objEnt.entregaMedicamento = True Then
                            seInsertaMedicamento = True
                        End If

                        If objEntFiltro.filtroEntregaMedicamento = -1 Then
                            seInsertaMedicamento = True
                        End If

                        If seInsertaDinero = True And seInsertaMedicamento = True Then
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
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Seguridad.Paquetes.Registro) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            With objEnt
                If .codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If
            End With
            Value = Data.Seguridad.Paquetes.Registro.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(codigo As Integer) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Seguridad.Paquetes.Registro.Eliminar(strAccion, strOpcion, codigo, Legolas.Configuration.Usuario.Codigo)
            Return Value
        End Function
#End Region
    End Class
End Namespace