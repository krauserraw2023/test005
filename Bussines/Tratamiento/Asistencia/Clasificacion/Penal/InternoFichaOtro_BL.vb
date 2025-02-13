Imports System.Data.SqlClient
Imports Data.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class InternoFichaOtro_BL

        Private Function esValido(objEnt As InternoFichaOtro_BE, ByRef strMensajeOut As String) As Boolean
            If objEnt Is Nothing Then
                strMensajeOut = "Objeto nulo"
                Return False
            End If

            If objEnt.PenalDestinoId = -1 Then
                strMensajeOut = "Debe especificar el establecimiento destino"
                Return False
            End If

            If objEnt.FechaTraslado = 0 Then
                strMensajeOut = "Fecha de traslado no válido"
                Return False
            End If

            If objEnt.FechaResolucion = 0 Then
                strMensajeOut = "Fecha de resolución no válido"
                Return False
            End If

            If Len(objEnt.ResolAutorizacion & "") <= 4 Then
                strMensajeOut = "Número de resolución no válido"
                Return False
            End If


            objEnt.ResolAutorizacion = objEnt.ResolAutorizacion.Trim

            Return True
        End Function

        Public Function Listar(ByVal Codigo As Integer) As InternoFichaOtro_BE
            Dim objEntCol As List(Of InternoFichaOtro_BE) = New List(Of InternoFichaOtro_BE)

            Dim entFich As New InternoFichaOtro_BE
            entFich.Codigo = Codigo

            objEntCol = Listar(entFich)
            If objEntCol Is Nothing Then Return Nothing
            If objEntCol.Count = 0 Then Return Nothing

            Return objEntCol.Item(0)

        End Function

        Public Function Listar(objEntFiltro As InternoFichaOtro_BE) As List(Of InternoFichaOtro_BE)
            Dim objEntCol As New List(Of InternoFichaOtro_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = InternoFichaOtro_DA.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        Dim objEnt As New InternoFichaOtro_BE
                        With objEnt
                            .Codigo = sqlDr("pk_int_fic_otro_id").ToString
                            .CausalId = sqlDr("fk_causal_traslado_id").ToString
                            .Causal = sqlDr("c_causal").ToString
                            .ResolAutorizacion = sqlDr("c_resol_autoriza").ToString
                            .FechaResolucion = sqlDr("f_fec_resol").ToString
                            .FechaTraslado = sqlDr("f_fec_traslado").ToString
                            .RegionOrigenId = sqlDr("fk_reg_origen_id").ToString
                            .PenalOrigenId = sqlDr("fk_pen_origen_id").ToString
                            .RegionDestinoId = sqlDr("fk_reg_destino_id").ToString
                            .PenalDestinoId = sqlDr("fk_pen_destino_id").ToString
                            .RegimenId_PenalOrigen = sqlDr("regimen_id_ep_origen").ToString
                            .EtapaId_PenalOrigen = sqlDr("etapa_id_ep_origen").ToString
                            .InternoPenalFichaId = sqlDr("fk_int_pen_fic_id").ToString
                            .Piso = sqlDr("piso_nom").ToString
                            .Ambiente = sqlDr("c_ambiente").ToString
                            .Alero = sqlDr("alero_nom").ToString
                            .FechaClasificacionUbicacion = sqlDr("f_fec_clasif_ubi").ToString
                            .EstadoClasificacionUbicacionOTT = sqlDr("est_clasif_ubi").ToString
                            .Cama = sqlDr("c_cama").ToString
                            .AleroId = sqlDr("fk_alero_id").ToString
                            .PabellonId = sqlDr("fk_pab_id").ToString
                            .PabellonNombre = sqlDr("c_nom").ToString
                            '.Estado = sqlDr("n_estado").ToString
                            .IdRegion = sqlDr("_regid").ToString
                            .IdPenal = sqlDr("_penid").ToString
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


        Public Function Listar_rpt(objEntFiltro As InternoFichaOtro_BE) As List(Of InternoFichaOtro_BE)
            Dim objEntCol As New List(Of InternoFichaOtro_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = InternoFichaOtro_DA.Listar(sqlCon, "lst", "lst_mant_rpt", objEntFiltro)
            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        Dim objEnt As New InternoFichaOtro_BE
                        With objEnt
                            .Codigo = sqlDr("pk_int_fic_otro_id").ToString
                            .Causal = sqlDr("c_causal").ToString
                            .ResolAutorizacion = sqlDr("c_resol_autoriza").ToString
                            .FechaResolucion = sqlDr("f_fec_resol").ToString
                            .FechaTraslado = sqlDr("f_fec_traslado").ToString
                            .RegionOrigenId = sqlDr("fk_reg_origen_id").ToString
                            .PenalOrigenId = sqlDr("fk_pen_origen_id").ToString
                            .RegionDestinoId = sqlDr("fk_reg_destino_id").ToString
                            .PenalDestinoId = sqlDr("fk_pen_destino_id").ToString
                            .RegimenId_PenalOrigen = sqlDr("regimen_id_ep_origen").ToString
                            .EtapaId_PenalOrigen = sqlDr("etapa_id_ep_origen").ToString
                            .InternoPenalFichaId = sqlDr("fk_int_pen_fic_id").ToString
                            .Piso = sqlDr("piso_nom").ToString
                            .Ambiente = sqlDr("c_ambiente").ToString
                            .Alero = sqlDr("alero_nom").ToString
                            .FechaClasificacionUbicacion = sqlDr("f_fec_clasif_ubi").ToString
                            .EstadoClasificacionUbicacionOTT = sqlDr("est_clasif_ubi").ToString
                            .Cama = sqlDr("c_cama").ToString
                            .AleroId = sqlDr("fk_alero_id").ToString
                            .PabellonId = sqlDr("fk_pab_id").ToString
                            .PabellonNombre = sqlDr("c_nom").ToString
                            .PenalOrigenNom = sqlDr("pen_nom_origen").ToString
                            .PenalDestinoNom = sqlDr("pen_nom_destino").ToString

                            .RegimenNombre_PenalOrigen = sqlDr("regimen_origen").ToString
                            .EtapaNombre_PenalOrigen = sqlDr("etapa_origen").ToString
                            '.Estado = sqlDr("n_estado").ToString
                            .IdRegion = sqlDr("_regid").ToString
                            .IdPenal = sqlDr("_penid").ToString
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

        Public Function ListarGrilla(objEntFiltro As InternoFichaOtro_BE) As List(Of InternoFichaOtro_BE)
            Dim objEntCol As New List(Of InternoFichaOtro_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = InternoFichaOtro_DA.ListarGrilla(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        Dim objEnt As New InternoFichaOtro_BE
                        With objEnt
                            .InternoPenalFichaId = sqlDr("pk_int_pen_fic_id").ToString
                            .Causal = sqlDr("c_causal").ToString
                            .ResolAutorizacion = sqlDr("c_resol_autoriza").ToString
                            .FechaResolucion = sqlDr("f_fec_resol").ToString
                            '.FechaTraslado = sqlDr("f_fec_traslado").ToString
                            '.RegionOrigenId = sqlDr("fk_reg_origen_id").ToString
                            '.PenalOrigenId = sqlDr("fk_pen_origen_id").ToString
                            '.RegionDestinoId = sqlDr("fk_reg_destino_id").ToString
                            '.PenalDestinoId = sqlDr("fk_pen_destino_id").ToString
                            '.RegimenId_PenalOrigen = sqlDr("regimen_id_ep_origen").ToString
                            '.EtapaId_PenalOrigen = sqlDr("etapa_id_ep_origen").ToString
                            .RegimenId_Clasificacion = sqlDr("n_reg_id").ToString
                            .EtapaId_Clasificacion = sqlDr("n_etp_id").ToString
                            .NumeroClasificacion = sqlDr("n_num_cla").ToString
                            .FechaClasificacion = sqlDr("n_fec_cla").ToString
                            '.Piso = sqlDr("c_piso").ToString
                            '.Ambiente = sqlDr("c_amb").ToString
                            '.Alero = sqlDr("c_alero").ToString
                            '.Cama = sqlDr("c_cama").ToString
                            .PabellonId = sqlDr("fk_pab_id").ToString
                            .PabellonNombre = sqlDr("c_nom").ToString
                            .Estado = sqlDr("n_est").ToString
                            .EstadoClasificacionUbicacionOTT = sqlDr("est_clasif_ubi").ToString
                            '.IdRegion = sqlDr("_regid").ToString
                            '.IdPenal = sqlDr("_penid").ToString
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

        Public Function GrabarFichaClasifTralado(entIntFic As InternoFicha_BE, objEntOtro As InternoFichaOtro_BE, ByRef strMensajeOut As String) As Integer
            Dim value As Integer = -1
            Dim strOpcion As String = ""
            Dim strAccion As String = ""

            If esValido(objEntOtro, strMensajeOut) = False Then
                Return -1
            End If

            If entIntFic.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Return InternoFichaOtro_DA.GrabarFichaClasifTralado(strAccion, strOpcion, entIntFic, objEntOtro)
        End Function

        Public Function GrabarFichaRegresion(entIntFic As InternoFicha_BE, objEntOtro As InternoFichaOtro_BE, ByRef strMensajeOut As String) As Integer
            Dim value As Integer = -1
            Dim strOpcion As String = ""
            Dim strAccion As String = ""

            If esValido(objEntOtro, strMensajeOut) = False Then
                Return -1
            End If

            If entIntFic.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Return InternoFichaOtro_DA.GrabarFichaRegresion(strAccion, strOpcion, entIntFic, objEntOtro)
        End Function

        Public Function GrabarFichaUbicacion(objEntOtro As InternoFichaOtro_BE, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strOpcion As String = ""
            Dim strAccion As String = ""


            strAccion = "upd"
            strOpcion = "upd_mant_ubicacion"


            Return InternoFichaOtro_DA.Grabar(strAccion, strOpcion, objEntOtro)
        End Function

        Public Function Grabar(objEntOtro As InternoFichaOtro_BE, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strOpcion As String = ""
            Dim strAccion As String = ""

            If esValido(objEntOtro, strMensajeOut) = False Then
                Return -1
            End If

            If objEntOtro.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Return InternoFichaOtro_DA.Grabar(strAccion, strOpcion, objEntOtro)
        End Function
        Public Function GrabarEstadoUbicacion(intIDFicha As Integer, intEstado As Short, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_estado_ubi"

            Dim objEnt As New InternoFichaOtro_BE
            With objEnt
                .InternoPenalFichaId = intIDFicha
                .Estado = intEstado
            End With

            Return InternoFichaOtro_DA.Grabar(strAccion, strOpcion, objEnt)
        End Function
    End Class

End Namespace
