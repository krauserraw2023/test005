Imports System.Data
Imports System.Data.SqlClient
Namespace Biometria
    Public Class InternoHuellaTratamiento
        Private objEnt As Entity.Biometria.InternoHuellaTratamiento = Nothing
        Private objEntCol As Entity.Biometria.InternoHuellaTratamientoCol = Nothing
#Region "Listar"
        
        Public Function ListarHuellaxIDInterno(intIDInterno As Integer, intIDRegion As Short, intIDPenal As Short,
                                                 ByRef out_sms As String) As Entity.Biometria.InternoHuellaTratamiento

            Dim objEntFiltro As New Entity.Biometria.InternoHuellaTratamiento
            With objEntFiltro
                .IDInterno = intIDInterno
                .IDRegion = intIDRegion
                .IDPenal = intIDPenal
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Biometria.InternoHuellaTratamiento.Listar(sqlCon, "lst", "lst_huella_por_asistencia", objEntFiltro, out_sms)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Biometria.InternoHuellaTratamiento
                        With objEnt
                            .Codigo = sqlDr("pk_int_hue_id").ToString
                            .IDInterno = sqlDr("kf_int_id").ToString
                            'izquierdo
                            .TipoCapturaIzquierdo = sqlDr("n_int_hue_tip_cap_izq").ToString
                            .IDIndiceIzquierdo = sqlDr("fk_hue_ind_izq_id").ToString
                            '.CalidadIndiceIzquierdo = sqlDr("n_vis_hue_cal_ind_izq").ToString
                            .IDPulgarIzquierdo = sqlDr("fk_hue_pul_izq_id").ToString
                            '.CalidadPulgarIzquierdo = sqlDr("n_vis_hue_cal_pul_izq").ToString
                            '.ObservacionIzquierdo = sqlDr("c_vis_hue_obs_izq").ToString
                            'derecho
                            .TipoCapturaDerecho = sqlDr("n_int_hue_tip_cap_der").ToString
                            .IDIndiceDerecho = sqlDr("fk_hue_ind_der_id").ToString
                            '.CalidadIndiceDerecho = sqlDr("n_vis_hue_cal_ind_der").ToString
                            .IDPulgarDerecho = sqlDr("fk_hue_pul_der_id").ToString
                            '.CalidadPulgarDerecho = sqlDr("n_vis_hue_cal_pul_der").ToString
                            '.ObservacionDerecho = sqlDr("c_vis_hue_obs_der").ToString
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
       
        
        Public Function BuscarIDInterno(objEntFiltro As Entity.Biometria.InternoHuellaTratamiento, ByRef out_sms As String) As Integer

            Dim value As Integer = -1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Biometria.InternoHuellaTratamiento.Listar(sqlCon, "lst", "lst_buscar_idinterno", objEntFiltro, out_sms)

            Try
                objEntCol = New Entity.Biometria.InternoHuellaTratamientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Biometria.InternoHuellaTratamiento
                        With objEnt
                            .Codigo = sqlDr("pk_int_hue_id").ToString
                            .IDInterno = sqlDr("kf_int_id").ToString
                            .IDIndiceIzquierdo = sqlDr("fk_hue_ind_izq_id").ToString
                            .IDPulgarIzquierdo = sqlDr("fk_hue_pul_izq_id").ToString
                            .IDIndiceDerecho = sqlDr("fk_hue_ind_der_id").ToString
                            .IDPulgarDerecho = sqlDr("fk_hue_pul_der_id").ToString
                            .IDRegion = sqlDr("_RegId").ToString
                            .IDPenal = sqlDr("_PenId").ToString

                            value = .IDInterno

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
        Public Function Grabar(IDInterno As Integer, objEntHuella1 As Entity.Biometria.Huella, objEntHuella2 As Entity.Biometria.Huella,
                                     IDRegion As Short, IDPenal As Short, ByRef intTieneHuella As Short) As Integer

            Dim value As Integer = -1
            Dim strMensajeError As String = ""
        
            'Grabar en la tabla Interno huella
            Dim intCodigo As Integer = -1
        
            Dim objBssHueInt As New Bussines.Biometria.InternoHuellaTratamiento
            Dim objEntHueInt As New Entity.Biometria.InternoHuellaTratamiento

            With objEntHueInt
                .IDInterno = IDInterno
                .FechaCaptura = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong
                .IDUsuarioInactivaHuella = Legolas.Configuration.Usuario.Codigo

                'Mano izquierda                
                .TipoCapturaIzquierdo = objEntHuella1.TipoCaptura
                .ObservacionIzquierdo = objEntHuella1.Observacion

                Select Case objEntHuella1.TipoDedo
                    Case Type.Enumeracion.Biometria.TipoDedo.IndiceIzquierdo
                        .IDTemplateIndiceIzquierdo = objEntHuella1.IDTemplate
                        .IDIndiceIzquierdo = objEntHuella1.IDTemplate
                        .CalidadIndiceIzquierdo = objEntHuella1.CalidadHuella

                    Case Type.Enumeracion.Biometria.TipoDedo.PulgarIzquierdo
                        .IDTemplatePulgarIzquierdo = objEntHuella1.IDTemplate
                        .IDPulgarIzquierdo = objEntHuella1.IDTemplate
                        .CalidadPulgarIzquierdo = objEntHuella1.CalidadHuella
                    Case Else
                        If objEntHuella1.IDTemplate > 0 Then
                            If objEntHuella1.EstadoDedo = 1 Then
                                .TipoCapturaIzquierdo = 2 'observado
                            ElseIf objEntHuella1.EstadoDedo = 2 Then
                                .TipoCapturaIzquierdo = 0 'amputado
                            End If
                            .IDPulgarIzquierdo = objEntHuella1.IDTemplate
                        End If
                End Select

                'Mano derecha                
                .TipoCapturaDerecho = objEntHuella2.TipoCaptura
                .ObservacionDerecho = objEntHuella2.Observacion

                Select Case objEntHuella2.TipoDedo
                    Case Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
                        .IDTemplateIndiceDerecho = objEntHuella2.IDTemplate
                        .IDIndiceDerecho = objEntHuella2.IDTemplate
                        .CalidadIndiceDerecho = objEntHuella2.CalidadHuella

                    Case Type.Enumeracion.Biometria.TipoDedo.PulgarDerecho
                        .IDTemplatePulgarDerecho = objEntHuella2.IDTemplate
                        .IDPulgarDerecho = objEntHuella2.IDTemplate
                        .CalidadPulgarDerecho = objEntHuella2.CalidadHuella
                    Case Else
                        If objEntHuella2.IDTemplate > 0 Then
                            If objEntHuella2.EstadoDedo = 1 Then
                                .TipoCapturaDerecho = 2 'observado
                            ElseIf objEntHuella2.EstadoDedo = 2 Then
                                .TipoCapturaDerecho = 0 'amputado
                            End If
                            .IDPulgarDerecho = objEntHuella2.IDTemplate
                        End If
                End Select

                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With
            intCodigo = objBssHueInt.GrabarHuella(objEntHueInt, strMensajeError)

            value = intCodigo
            Return value

        End Function
        Private Function GrabarHuella(objEntDatos As Entity.Biometria.InternoHuellaTratamiento, ByRef out_sms As String) As Integer

            Dim value As Integer = -1
            Dim err As Boolean = False
            Dim opcion As String = ""
            Dim accion As String = ""

            If objEntDatos Is Nothing Then
                out_sms = "El registro de huella del interno no puede ser nulo"
                Return value
            End If

            If objEntDatos.Codigo < 0 Then
                accion = "ins"
                opcion = "ins_mant"
            Else
                accion = "upd"
                opcion = "upd_mant"
            End If

            value = Data.Biometria.InternoHuellaTratamiento.Grabar(accion, opcion, objEntDatos, out_sms)

            Return value

        End Function

#End Region

    End Class
End Namespace