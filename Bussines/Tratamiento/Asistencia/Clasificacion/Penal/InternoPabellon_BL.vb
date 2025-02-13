Imports System.Data.SqlClient
Imports Data.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal

    Public Class InternoPabellon_BL
        Private objEnt As InternoPabellon_BE = Nothing
        Private objEntLista As List(Of InternoPabellon_BE) = Nothing

#Region "Funciones"
        Public Function fn_ObtenerEstado(intCodigo As Integer) As Short

            Dim value As Short = -1
            objEnt = New InternoPabellon_BE
            objEnt = Listar(intCodigo)

            With objEnt
                value = .Estado
            End With

            Return value

        End Function
        Public Function fn_ObtenerIDFichaRegimen(intCodigo As Integer) As Integer

            Dim value As Short = -1
            objEnt = New InternoPabellon_BE

            objEnt = Listar(intCodigo)

            With objEnt
                value = .IDFichaRegimen
            End With

            Return value

        End Function
        Public Function fn_ObtenerIDFichaEtapa(intCodigo As Integer) As Integer

            Dim value As Short = -1
            objEnt = New InternoPabellon_BE

            objEnt = Listar(intCodigo)

            With objEnt
                value = .IDFichaEtapa
            End With

            Return value

        End Function

        Public Function fn_ObtenerIDCodigo(intIDFichaFinalEtapa As Integer) As Integer

            Dim value As Short = -1

            objEntLista = New List(Of InternoPabellon_BE)
            Dim objEntFiltro As New InternoPabellon_BE

            With objEntFiltro
                .IDFichaEtapa = intIDFichaFinalEtapa
            End With

            objEntLista = ListarGrilla(objEntFiltro)

            For Each objFila As InternoPabellon_BE In objEntLista
                value = objFila.Codigo
            Next

            Return value

        End Function

#End Region

#Region "Listar"
        Public Function ListarClasificacionMaxActual(IntIngInpe As Integer) As InternoPabellon_BE
            Dim ls As List(Of InternoPabellon_BE)
            Dim objEntFiltro As New InternoPabellon_BE()
            objEntFiltro.IDIngresoInpe = IntIngInpe

            ls = ListarGrilla(objEntFiltro)

            If ls.Count = 0 Then Return Nothing

            Dim max As Integer = ls.Item(0).Codigo

            For Each o As InternoPabellon_BE In ls
                If o.Codigo > max Then
                    max = o.Codigo
                End If
            Next

            For Each o As InternoPabellon_BE In ls
                If o.Codigo = max Then
                    Return o
                End If
            Next
        End Function
        Public Function Listar(intCodigo As Integer) As InternoPabellon_BE

            Dim objEntFiltro As New InternoPabellon_BE
            With objEntFiltro
                .Codigo = intCodigo
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = InternoPabellon_DA.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New InternoPabellon_BE
                        With objEnt
                            .Codigo = sqlDr("pk_int_pab_id").ToString
                            .IDInterno = sqlDr("fk_int_id").ToString
                            .IDIngreso = sqlDr("fk_int_ing_id").ToString
                            .NumeroClasificacionRegimen = sqlDr("n_num_cla_regimen").ToString
                            .NumeroClasificacionEtapa = sqlDr("n_num_cla_etapa").ToString
                            .FechaClasificacionRegimen = sqlDr("n_fec_cla_regimen").ToString
                            .FechaClasificacionEtapa = sqlDr("n_fec_cla_etapa").ToString
                            .TipoProcesoClasificacion = sqlDr("c_tip_proc_clasif").ToString
                            .IDSituacionJuridica = sqlDr("n_sit_jur_id").ToString
                            .IDFichaRegimen = sqlDr("fk_int_pen_fic_id_reg").ToString
                            .IDRegimen = sqlDr("n_reg_int_id").ToString
                            .IDFichaEtapa = sqlDr("fk_int_pen_fic_id_etp").ToString
                            .IDEtapa = sqlDr("n_etp_int_id").ToString
                            .IDPabellon = sqlDr("fk_pab_id").ToString
                            .PabellonNombre = sqlDr("pab_nom").ToString
                            .Piso = sqlDr("c_pis").ToString
                            .Ambiente = sqlDr("c_amb").ToString
                            .Ala = sqlDr("c_ale").ToString
                            .Cama = sqlDr("c_cam").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .Estado = sqlDr("n_est").ToString
                            .IDRegion = sqlDr("_regid").ToString
                            .IDPenal = sqlDr("_penid").ToString
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
        Public Function ListarGrilla(objEntFiltro As InternoPabellon_BE) As List(Of InternoPabellon_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = InternoPabellon_DA.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objEntLista = New List(Of InternoPabellon_BE)

                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New InternoPabellon_BE
                        With objEnt
                            .Codigo = sqlDr("pk_int_pab_id").ToString
                            .IDInterno = sqlDr("fk_int_id").ToString
                            .IDIngreso = sqlDr("fk_int_ing_id").ToString
                            .IDIngresoInpe = sqlDr("fk_ing_inp_id").ToString
                            .NumeroClasificacionRegimen = sqlDr("n_num_cla_regimen").ToString
                            .NumeroClasificacionEtapa = sqlDr("n_num_cla_etapa").ToString
                            .FechaClasificacionRegimen = sqlDr("n_fec_cla_regimen").ToString
                            .FechaClasificacionEtapa = sqlDr("n_fec_cla_etapa").ToString
                            .TipoProcesoClasificacion = sqlDr("c_tip_proc_clasif").ToString
                            .IDSituacionJuridica = sqlDr("n_sit_jur_id").ToString
                            .IDFichaRegimen = sqlDr("fk_int_pen_fic_id_reg").ToString
                            .IDFichaEtapa = sqlDr("fk_int_pen_fic_id_etp").ToString
                            .IDRegimen = sqlDr("n_reg_int_id").ToString
                            .IDEtapa = sqlDr("n_etp_int_id").ToString
                            .IDPabellon = sqlDr("fk_pab_id").ToString
                            .PabellonNombre = sqlDr("pab_nom").ToString
                            .Estado = sqlDr("n_est").ToString

                            .Piso = sqlDr("c_pis").ToString
                            .Ambiente = sqlDr("c_amb").ToString
                            .Ala = sqlDr("c_ale").ToString
                            .Cama = sqlDr("c_cam").ToString
                            .AlaId = sqlDr("fk_ala_id").ToString
                            .Observacion = sqlDr("c_obs").ToString
                        End With
                        objEntLista.Add(objEnt)
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
            Return objEntLista
        End Function
        Public Function ListarClasificacionPendiente_LM(objEntFiltro As InternoPabellon_BE) As InternoPabellon_BE

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = InternoPabellon_DA.Listar(sqlCon, "lst", "lst_clasificacion_activo_LM", objEntFiltro)
            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New InternoPabellon_BE
                        With objEnt
                            .Codigo = sqlDr("pk_int_pab_id").ToString
                            .IDInterno = sqlDr("fk_int_id").ToString
                            .IDIngreso = sqlDr("fk_int_ing_id").ToString
                            .IDIngresoInpe = sqlDr("fk_ing_inp_id").ToString
                            .NumeroClasificacionRegimen = sqlDr("n_num_cla_regimen").ToString
                            .NumeroClasificacionEtapa = sqlDr("n_num_cla_etapa").ToString
                            .FechaClasificacionRegimen = sqlDr("n_fec_cla_regimen").ToString
                            .FechaClasificacionEtapa = sqlDr("n_fec_cla_etapa").ToString
                            .TipoProcesoClasificacion = sqlDr("c_tip_proc_clasif").ToString
                            .IDSituacionJuridica = sqlDr("n_sit_jur_id").ToString
                            .IDRegimen = sqlDr("n_reg_int_id").ToString
                            .IDEtapa = sqlDr("n_etp_int_id").ToString

                            .Estado = sqlDr("n_est").ToString
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
        Public Function ListarClasificacionPendiente(objEntFiltro As InternoPabellon_BE) As InternoPabellon_BE

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = InternoPabellon_DA.Listar(sqlCon, "lst", "lst_clasificacion_activo", objEntFiltro)
            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New InternoPabellon_BE
                        With objEnt
                            .Codigo = sqlDr("pk_int_pab_id").ToString
                            .IDInterno = sqlDr("fk_int_id").ToString
                            .IDIngreso = sqlDr("fk_int_ing_id").ToString
                            .IDIngresoInpe = sqlDr("fk_ing_inp_id").ToString
                            .NumeroClasificacionRegimen = sqlDr("n_num_cla_regimen").ToString
                            .NumeroClasificacionEtapa = sqlDr("n_num_cla_etapa").ToString
                            .FechaClasificacionRegimen = sqlDr("n_fec_cla_regimen").ToString
                            .FechaClasificacionEtapa = sqlDr("n_fec_cla_etapa").ToString
                            .TipoProcesoClasificacion = sqlDr("c_tip_proc_clasif").ToString
                            .IDSituacionJuridica = sqlDr("n_sit_jur_id").ToString
                            .IDRegimen = sqlDr("n_reg_int_id").ToString
                            .IDEtapa = sqlDr("n_etp_int_id").ToString
                            .IDFichaRegimen = sqlDr("fk_int_pen_fic_id_reg").ToString
                            .Estado = sqlDr("n_est").ToString
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
#End Region

#Region "Grabar"
        Public Function ActualizarRegimen(objEnt As InternoPabellon_BE, ByRef strMensajeOut As String) As Integer

            Return InternoPabellon_DA.Grabar("upd", "upd_regimen", objEnt)

        End Function

        Public Function Grabar(objEnt As InternoPabellon_BE, ByRef strMensajeOut As String) As Integer

            Dim strAccion As String
            Dim strOpcion As String

            If objEnt.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Return InternoPabellon_DA.Grabar(strAccion, strOpcion, objEnt)

        End Function

        ''' <summary>
        ''' Actualiza tabla tra_asi_mov_interno_pabellon etapa.
        ''' Funciona para prov y LM
        ''' 17/11/2023 hnrb
        ''' </summary>
        ''' <param name="objEnt"></param>
        ''' <param name="strMensajeOut"></param>
        ''' <returns></returns>
        Public Function ActualizarEtapa(objEnt As InternoPabellon_BE, ByRef strMensajeOut As String) As Integer

            Dim strAccion As String
            Dim strOpcion As String

            If objEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_etapa"
            End If

            Return InternoPabellon_DA.Grabar(strAccion, strOpcion, objEnt)

        End Function

        Private Function GrabarFichaClasificacion_LM(intIDCodigo As Integer, intIDFichaRegimen As Integer, intRegimen As Short, intIDFichaEtapa As Integer, intEtapa As Short,
                                                   PabellonId As Integer, ing_inp_id As Integer, ByRef strMensajeOut As String) As Integer

            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_ficha_clasificacion_LM"

            objEnt = New InternoPabellon_BE
            With objEnt
                .Codigo = intIDCodigo
                .IDFichaRegimen = intIDFichaRegimen
                .IDRegimen = intRegimen
                .IDEtapa = intEtapa
                .IDFichaEtapa = intIDFichaEtapa
                .IDPabellon = PabellonId
                .IDIngresoInpe = ing_inp_id
            End With

            Return InternoPabellon_DA.Grabar(strAccion, strOpcion, objEnt)

        End Function
        Private Function GrabarFichaClasificacion_PROV_v2(intIDCodigo As Integer, intIDFichaRegimen As Integer, intRegimen As Short, intIDFichaEtapa As Integer, intEtapa As Short,
                                                   PabellonId As Integer, int_ing_id As Integer, ByRef strMensajeOut As String) As Integer


            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_ficha_clasificacion_v2"

            objEnt = New InternoPabellon_BE
            With objEnt
                .Codigo = intIDCodigo
                .IDFichaRegimen = intIDFichaRegimen
                .IDRegimen = intRegimen
                .IDEtapa = intEtapa
                .IDFichaEtapa = intIDFichaEtapa
                .IDPabellon = PabellonId
                .IDIngreso = int_ing_id
            End With

            Return InternoPabellon_DA.Grabar(strAccion, strOpcion, objEnt)

        End Function
        Private Function GrabarFichaClasificacion_PROV(intIDCodigo As Integer, intIDFichaRegimen As Integer, intRegimen As Short, intIDFichaEtapa As Integer, intEtapa As Short,
                                                   PabellonId As Integer, ByRef strMensajeOut As String) As Integer

            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_ficha_clasificacion"

            objEnt = New InternoPabellon_BE
            With objEnt
                .Codigo = intIDCodigo
                .IDFichaRegimen = intIDFichaRegimen
                .IDRegimen = intRegimen
                .IDEtapa = intEtapa
                .IDFichaEtapa = intIDFichaEtapa
                .IDPabellon = PabellonId
            End With

            Return InternoPabellon_DA.Grabar(strAccion, strOpcion, objEnt)

        End Function
        Public Function GrabarFichaClasificacionRegimen(intIDCodigo As Integer, intIDFichaRegimen As Integer, ByRef strMensajeOut As String) As Integer

            Return GrabarFichaClasificacion_PROV(intIDCodigo, intIDFichaRegimen, -1, -1, -1, -1, strMensajeOut)

        End Function
        Public Function GrabarRegimen_LM(intIDCodigo As Integer, ing_inp_id As Integer, ByRef strMensajeOut As String) As Integer

            Dim intIDFichaRegimen As Integer = Listar(intIDCodigo).IDFichaRegimen
            Dim intRegimen As Short = (New InternoFicha_BL()).Listar(intIDFichaRegimen).InternoIDRegimen

            Return GrabarFichaClasificacion_LM(intIDCodigo, intIDFichaRegimen, intRegimen, -1, -1, -1, ing_inp_id, strMensajeOut)
        End Function
        Public Function GrabarRegimen_PROV_v2(intIDCodigo As Integer, int_ing_id As Integer, ByRef strMensajeOut As String) As Integer

            Dim intIDFichaRegimen As Integer = Listar(intIDCodigo).IDFichaRegimen
            Dim intRegimen As Short = (New InternoFicha_BL()).Listar(intIDFichaRegimen).InternoIDRegimen

            Return GrabarFichaClasificacion_PROV_v2(intIDCodigo, intIDFichaRegimen, intRegimen, -1, -1, -1, int_ing_id, strMensajeOut)
        End Function
        Public Function GrabarRegimen_PROV(intIDCodigo As Integer, ByRef strMensajeOut As String) As Integer

            Dim intIDFichaRegimen As Integer = Listar(intIDCodigo).IDFichaRegimen
            Dim intRegimen As Short = (New InternoFicha_BL()).Listar(intIDFichaRegimen).InternoIDRegimen

            Return GrabarFichaClasificacion_PROV(intIDCodigo, intIDFichaRegimen, intRegimen, -1, -1, -1, strMensajeOut)
        End Function

        Public Function GrabarFichaClasificacionEtapa(intIDCodigo As Integer, intIDFichaEtapa As Integer, PabellonId As Integer, ByRef strMensajeOut As String) As Integer

            objEnt = New InternoPabellon_BE
            objEnt = Listar(intIDCodigo)

            Return GrabarFichaClasificacion_PROV(intIDCodigo, objEnt.IDFichaRegimen, objEnt.IDRegimen, intIDFichaEtapa, -1, PabellonId, strMensajeOut)
        End Function


        Public Function GrabarPabellon(objEnt As InternoPabellon_BE, ByRef strMensajeOut As String) As Integer

            Dim objEntPabellon As InternoPabellon_BE = Listar(objEnt.Codigo)

            With objEntPabellon
                .AlaId = objEnt.AlaId
                .Ambiente = objEnt.Ambiente
                .Cama = objEnt.Cama
                .Observacion = objEnt.Observacion
            End With

            Return Grabar(objEntPabellon, strMensajeOut)

        End Function

        Public Function GrabarEstado(intCodigo As Integer, intEstado As Short, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_estado"

            objEnt = New InternoPabellon_BE
            With objEnt
                .Codigo = intCodigo
                .Estado = intEstado
            End With

            value = InternoPabellon_DA.Grabar(strAccion, strOpcion, objEnt)

            Return value
        End Function
#End Region


    End Class

End Namespace
