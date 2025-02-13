Imports System.Data
Imports System.Data.SqlClient
Namespace Biometria
    Public Class VisitanteHuella
        Private objEnt As Entity.Biometria.VisitanteHuella = Nothing
        Private objEntCol As Entity.Biometria.VisitanteHuellaCol = Nothing
#Region "Funciones"
        Public Function TieneMinimoUnaHuella(intIDVisitante As Integer, intIDRegion As Short, intIDPenal As Short) As Boolean

            Dim value As Boolean = True

            Dim blnManoIzq As Boolean = False
            Dim blnManoDer As Boolean = False

            objEnt = New Entity.Biometria.VisitanteHuella
            objEnt = ListarHuellaxIDVisitante(intIDVisitante, intIDRegion, intIDPenal, "")

            With objEnt

                'mano izquierda
                Select Case .TipoCapturaIzquierdo

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        If .IDIndiceIzquierdo > 0 Or .IDPulgarIzquierdo Then
                            blnManoIzq = True
                        End If
                End Select

                'mano derecha
                Select Case .TipoCapturaDerecho

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        If .IDIndiceDerecho > 0 Or .IDPulgarDerecho Then
                            blnManoDer = True
                        End If

                End Select

            End With

            If blnManoIzq = False And blnManoDer = False Then
                value = False
            End If

            Return value

        End Function
        Public Function NumeroRecaptura(intIDVisitante As Integer, intIDRegion As Short, intIDPenal As Short) As Short

            Dim value As Short = -1

            objEnt = New Entity.Biometria.VisitanteHuella
            objEnt = ListarHuellaxIDVisitante(intIDVisitante, intIDRegion, intIDPenal, "")

            value = objEnt.NumeroRecaptura

            Return value

        End Function
#End Region
#Region "Listar"
        Public Function Listar(Codigo As Integer, ByRef out_sms As String) As Entity.Biometria.VisitanteHuella

            Dim objEntFiltro As New Entity.Biometria.VisitanteHuella
            objEntFiltro.Codigo = Codigo

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Biometria.VisitanteHuella.Listar(sqlCon, "lst", "lst_mant", objEntFiltro, out_sms)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Biometria.VisitanteHuella
                        With objEnt
                            .Codigo = sqlDr("pk_vis_hue_id").ToString
                            .IDVisitante = sqlDr("kf_vis_id").ToString
                            .NumeroRecaptura = sqlDr("n_vis_hue_rec").ToString
                            .FechaCaptura = sqlDr("n_vis_hue_fec_cap").ToString
                            .IDUsuarioInactivaHuella = sqlDr("kf_usu_id_ina_hue").ToString
                            .UsuarioInactivaHuella = sqlDr("usu_ina_nom").ToString
                            .FechaInactivaHuella = sqlDr("n_vis_hue_fec_ina_hue").ToString
                            '/*izquierdo*/
                            .TipoCapturaIzquierdo = sqlDr("n_vis_hue_tip_cap_izq").ToString
                            .IDIndiceIzquierdo = sqlDr("kf_hue_ind_izq_id").ToString
                            .CalidadIndiceIzquierdo = sqlDr("n_vis_hue_cal_ind_izq").ToString
                            .IDPulgarIzquierdo = sqlDr("kf_hue_pul_izq_id").ToString
                            .CalidadPulgarIzquierdo = sqlDr("n_vis_hue_cal_pul_izq").ToString
                            .ObservacionIzquierdo = sqlDr("c_vis_hue_obs_izq").ToString
                            '/*derecho*/
                            .TipoCapturaDerecho = sqlDr("n_vis_hue_tip_cap_der").ToString
                            .IDIndiceDerecho = sqlDr("kf_hue_ind_der_id").ToString
                            .CalidadIndiceDerecho = sqlDr("n_vis_hue_cal_ind_der").ToString
                            .IDPulgarDerecho = sqlDr("kf_hue_pul_der_id").ToString
                            .CalidadPulgarDerecho = sqlDr("n_vis_hue_cal_pul_der").ToString
                            .ObservacionDerecho = sqlDr("c_vis_hue_obs_der").ToString

                            .Audit_UsuarioCreacion = sqlDr("usu_cre_nom").ToString
                            .IDRegion = sqlDr("_RegId").ToString
                            .IDPenal = sqlDr("_PenId").ToString

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
        Public Function ListarHuellaxIDVisitante(intIDVisitante As Integer, intIDRegion As Short, intIDPenal As Short,
                                                 ByRef out_sms As String) As Entity.Biometria.VisitanteHuella

            Dim objEntFiltro As New Entity.Biometria.VisitanteHuella
            With objEntFiltro
                .IDVisitante = intIDVisitante
                .IDRegion = intIDRegion
                .IDPenal = intIDPenal
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Biometria.VisitanteHuella.Listar(sqlCon, "lst", "lst_huella_por_visita", objEntFiltro, out_sms)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Biometria.VisitanteHuella
                        With objEnt
                            .Codigo = sqlDr("pk_vis_hue_id").ToString
                            .IDVisitante = sqlDr("kf_vis_id").ToString
                            .NumeroRecaptura = sqlDr("n_vis_hue_rec").ToString
                            'izquierdo
                            .TipoCapturaIzquierdo = sqlDr("n_vis_hue_tip_cap_izq").ToString
                            .IDIndiceIzquierdo = sqlDr("kf_hue_ind_izq_id").ToString
                            .CalidadIndiceIzquierdo = sqlDr("n_vis_hue_cal_ind_izq").ToString
                            .IDPulgarIzquierdo = sqlDr("kf_hue_pul_izq_id").ToString
                            .CalidadPulgarIzquierdo = sqlDr("n_vis_hue_cal_pul_izq").ToString
                            .ObservacionIzquierdo = sqlDr("c_vis_hue_obs_izq").ToString
                            'derecho
                            .TipoCapturaDerecho = sqlDr("n_vis_hue_tip_cap_der").ToString
                            .IDIndiceDerecho = sqlDr("kf_hue_ind_der_id").ToString
                            .CalidadIndiceDerecho = sqlDr("n_vis_hue_cal_ind_der").ToString
                            .IDPulgarDerecho = sqlDr("kf_hue_pul_der_id").ToString
                            .CalidadPulgarDerecho = sqlDr("n_vis_hue_cal_pul_der").ToString
                            .ObservacionDerecho = sqlDr("c_vis_hue_obs_der").ToString
                            '/**/
                            .IDRegion = sqlDr("_RegId").ToString
                            .IDPenal = sqlDr("_PenId").ToString
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
        Public Function Combo(intIDVisitante As Integer, intIDRegion As Short, intIDPenal As Short, ByRef out_sms As String) As Entity.Biometria.VisitanteHuellaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Biometria.VisitanteHuella
            With objEntFiltro
                .IDVisitante = intIDVisitante
                .IDRegion = intIDRegion
                .IDPenal = intIDPenal
            End With

            Dim sqlDr As SqlDataReader = Data.Biometria.VisitanteHuella.Listar(sqlCon, "lst", "lst_combo", objEntFiltro, out_sms)

            Try
                objEntCol = New Entity.Biometria.VisitanteHuellaCol
                If sqlDr.HasRows Then

                    Dim intConta As Integer = 0
                    While sqlDr.Read
                        objEnt = New Entity.Biometria.VisitanteHuella
                        With objEnt
                            .Codigo = sqlDr("pk_vis_hue_id").ToString
                            .IDVisitante = sqlDr("kf_vis_id").ToString
                            .FechaCaptura = sqlDr("n_vis_hue_fec_cap").ToString
                            .EstadoHuella = sqlDr("n_vis_hue_est").ToString
                            .IDRegion = sqlDr("_RegId").ToString
                            .IDPenal = sqlDr("_PenId").ToString

                            intConta = intConta + 1

                            If .EstadoHuella = 0 Then
                                .Item = "Captura: " & intConta & " (Inactivo)"
                            Else
                                .Item = "Captura: " & intConta & " (Activo)"
                            End If

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
        Public Function Listar_TemplateVisitasxSalir(objEntFiltro As Entity.Biometria.VisitanteHuella) As List(Of Integer)

            Dim value As New List(Of Integer)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Biometria.VisitanteHuella.Listar(sqlCon, "lst", "lst_template_visitas_x_salir", objEntFiltro, "")

            Try
                objEntCol = New Entity.Biometria.VisitanteHuellaCol
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.Biometria.VisitanteHuella

                        With objEnt

                            .IDTemplateIndiceIzquierdo = sqlDr("id_fk_tmp_ind_izq").ToString
                            .IDTemplatePulgarIzquierdo = sqlDr("id_fk_tmp_pul_izq").ToString

                            .IDTemplateIndiceDerecho = sqlDr("id_fk_tmp_ind_der").ToString
                            .IDTemplatePulgarDerecho = sqlDr("id_fk_tmp_pul_der").ToString

                            If .IDTemplateIndiceIzquierdo > 0 Then
                                value.Add(.IDTemplateIndiceIzquierdo)
                            End If

                            If .IDTemplatePulgarIzquierdo > 0 Then
                                value.Add(.IDTemplatePulgarIzquierdo)
                            End If

                            If .IDTemplateIndiceDerecho > 0 Then
                                value.Add(.IDTemplateIndiceDerecho)
                            End If

                            If .IDTemplatePulgarDerecho > 0 Then
                                value.Add(.IDTemplatePulgarDerecho)
                            End If

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

            Return value

        End Function
        Public Function BuscarIDVisita(objEntFiltro As Entity.Biometria.VisitanteHuella, ByRef out_sms As String) As Integer

            Dim value As Integer = -1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Biometria.VisitanteHuella.Listar(sqlCon, "lst", "lst_buscar_idvisita", objEntFiltro, out_sms)

            Try
                objEntCol = New Entity.Biometria.VisitanteHuellaCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Biometria.VisitanteHuella
                        With objEnt
                            .Codigo = sqlDr("pk_vis_hue_id").ToString
                            .IDVisitante = sqlDr("kf_vis_id").ToString
                            .IDIndiceIzquierdo = sqlDr("kf_hue_ind_izq_id").ToString
                            .IDPulgarIzquierdo = sqlDr("kf_hue_pul_izq_id").ToString
                            .IDIndiceDerecho = sqlDr("kf_hue_ind_der_id").ToString
                            .IDPulgarDerecho = sqlDr("kf_hue_pul_der_id").ToString
                            .IDRegion = sqlDr("_RegId").ToString
                            .IDPenal = sqlDr("_PenId").ToString

                            value = .IDVisitante

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

            Return value

        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(objEntDatos As Entity.Biometria.VisitanteHuella, ByRef out_sms As String) As Integer

            Dim value As Integer = -1
            Dim err As Boolean = False
            Dim opcion As String = ""
            Dim accion As String = ""

            If objEntDatos Is Nothing Then
                out_sms = "El registro de huella del visitante no puede ser nulo"
                Return value
            End If

            If objEntDatos.Codigo < 0 Then
                accion = "ins"
                opcion = "ins_mant"
            Else
                accion = "upd"
                opcion = "upd_mant"
            End If

            value = Data.Biometria.VisitanteHuella.Grabar(accion, opcion, objEntDatos, out_sms)

            Return value

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(Codigo As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer

            Dim value As Integer = -1

            Dim err As Boolean = False
            If Codigo < 1 Then
                out_sms = "Id del registro no válido"
                Return value
            End If

            If IdUsuario < 1 Then
                out_sms = out_sms & " Id de usuario no válido"
                Return value
            End If

            value = Data.Biometria.VisitanteHuella.Eliminar("del", "del_mant", Codigo, IdUsuario, out_sms)
            Return value

        End Function
#End Region
    End Class
End Namespace