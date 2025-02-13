Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class Visitante
        Private objEnt As Entity.Visita.Visitante = Nothing
        Private objEntCol As Entity.Visita.VisitanteCol = Nothing
#Region "Validar"
        Private Function ValidarNumeroDocumento(ByVal objEnt As Entity.Visita.Visitante) As Boolean

            Dim value As Integer = -1

            value = Data.Visita.Visitante.ListarOutput("lst", "lst_validar_numero_documento", objEnt)

            Return Not (value > 0)

        End Function
        Private Function VisitanteTieneMovimiento(intIDVisitante As Integer, intIDRegion As Short, intIDPenal As Short) As Boolean

            Dim value As Boolean = False

            objEnt = New Entity.Visita.Visitante
            With objEnt
                .Codigo = intIDVisitante
                .RegionID = intIDRegion
                .PenalID = intIDPenal
            End With

            Dim intNumReg As Integer = 0

            intNumReg = Data.Visita.Visitante.ListarOutput("lst", "val_visitante_en_movimiento", objEnt)

            If intNumReg > 0 Then
                value = True
            End If

            Return value

        End Function
#End Region
#Region "Funciones"

        Public Function ListarImagen(ByVal ArchivoDigitalID As Integer, ByVal NameFile As String, Optional ByVal PathServerImg As String = "") As Byte()

            Dim value As Byte()
            Dim intTipoArchivo As Short = 3 'visitante 

            'validar la ruta
            If NameFile.Trim = "" Then
                Return value
            End If

            Dim objWS As New APPWebService.ws_foto.PopeLocal
            objWS.Url = APPWebService.PathURL.WSPopeLocal

            'test al web service
            Try
                Dim lngFecha As Long = objWS.FechaHoy()
            Catch ex As Exception
                Return value
            End Try

            If ArchivoDigitalID < 1 Then
                'no hay foto
                Return value
            Else
                'si hay foto             
                Dim objImagenByte As Byte()
                Dim objImagenStream As New IO.MemoryStream

                Dim strFotoNameExtension As String = NameFile

                Try
                    If PathServerImg = "" Then 'si es imagen de la version anterior debe ser vacío
                        objImagenByte = objWS.LeerImageJpg(strFotoNameExtension, intTipoArchivo)
                    Else
                        objImagenByte = (New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(ArchivoDigitalID, intTipoArchivo, "")
                    End If

                    value = objImagenByte
                Catch ex As Exception
                    objImagenByte = Nothing
                End Try

            End If

            Return value

        End Function

#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.Visitante

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Visitante.Listar(sqlCon, "lst", "lst_mant", Codigo, _
            "", "", "", -1, "", "", -1, -1, -1, -1)
            objEnt = New Entity.Visita.Visitante
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("vis_id").ToString
                            .ApellidoPaterno = sqlDr("vis_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("vis_ape_mat").ToString
                            .Nombres = sqlDr("vis_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoID = sqlDr("doc_tip_id").ToString
                            .TipoDocumentoNombre = sqlDr("doc_tip_nom").ToString
                            .NumeroDocumento = sqlDr("vis_doc_num").ToString
                            .FechaNacimiento = sqlDr("vis_fec_nac").ToString
                            .Institucion = sqlDr("vis_ins_nom").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            .Observacion = sqlDr("vis_obs").ToString
                            .FotoID = sqlDr("vis_fot_id").ToString
                            .FotoName = sqlDr("vis_fot").ToString
                            '/*otros*/
                            .IDUsuarioCapturaFoto = sqlDr("f_usu_id_cap_fot").ToString
                            .IDUsuarioCapturaHuella = sqlDr("f_usu_id_cap_hue").ToString
                            .VisitanteTieneHuella = sqlDr("n_vis_has_hue").ToString
                            '/*reniec*/
                            .VisitanteValidoReniec = sqlDr("n_vis_val_rnc").ToString
                            .IDUsuarioValidacionReniec = sqlDr("f_usu_id_val_rnc").ToString
                            .FechaValidacionReniec = sqlDr("n_vis_fec_val_rnc").ToString
                            '/*penal/region*/
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            '/*datos de autoria*/
                            .IDUsuarioCreacion = sqlDr("_usu_cre").ToString
                            .FechaCreacion = sqlDr("_fec_cre").ToString
                            .IDUsuarioModificacion = sqlDr("_usu_mod").ToString
                            .FechaModificacion = sqlDr("_fec_mod").ToString
                            .IDUsuarioEliminacion = sqlDr("_usu_eli").ToString
                            .FechaEliminacion = sqlDr("_fec_eli").ToString
                            .Eliminado = sqlDr("_flg_eli").ToString
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

        Public Function ListarxNumeroDocumento(intIDTipoDocumento As Short, ByVal NumeroDocumento As String, ByVal RegionID As Integer, _
                                               ByVal PenalID As Integer) As Entity.Visita.VisitanteCol

            Dim objEntFiltro As New Entity.Visita.Visitante

            With objEntFiltro
                .TipoDocumentoID = intIDTipoDocumento
                .NumeroDocumento = NumeroDocumento
                .RegionID = RegionID
                .PenalID = PenalID
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Visitante.Listar(sqlCon, "lst", "lst_visitante_dni", objEntFiltro)

            objEntCol = New Entity.Visita.VisitanteCol

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Visitante
                        With objEnt
                            .Codigo = sqlDr("vis_id").ToString
                            .TipoDocumentoID = sqlDr("doc_tip_id").ToString
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString
                            .VisitanteValidoReniec = sqlDr("n_vis_val_rnc").ToString ' campo nuevo
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

        Public Function ListarGrilla(ByVal objEntFiltro As Entity.Visita.Visitante) As Entity.Visita.VisitanteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Visitante.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)

            objEntCol = New Entity.Visita.VisitanteCol

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Visitante
                        With objEnt
                            .Codigo = sqlDr("vis_id").ToString
                            .ApellidoPaterno = sqlDr("vis_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("vis_ape_mat").ToString
                            .Nombres = sqlDr("vis_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoID = sqlDr("doc_tip_id").ToString
                            .TipoDocumentoNombre = sqlDr("doc_tip_nom").ToString
                            .NumeroDocumento = sqlDr("vis_doc_num").ToString
                            .FechaNacimiento = sqlDr("vis_fec_nac").ToString
                            .Institucion = sqlDr("vis_ins_nom").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            .FotoID = sqlDr("vis_fot_id").ToString
                            .FotoName = sqlDr("vis_fot").ToString
                            '/*huella*/
                            .VisitanteValidoReniec = sqlDr("n_vis_val_rnc").ToString
                            .VisitanteTieneHuella = sqlDr("n_vis_has_hue").ToString
                            .HuellaTipoCapturaIzquierdo = sqlDr("n_vis_hue_tip_cap_izq").ToString
                            .HuellaIDIndiceIzquierdo = sqlDr("kf_hue_ind_izq_id").ToString
                            .HuellaIDPulgarIzquierdo = sqlDr("kf_hue_pul_izq_id").ToString

                            .HuellaTipoCapturaDerecho = sqlDr("n_vis_hue_tip_cap_der").ToString
                            .HuellaIDIndiceDerecho = sqlDr("kf_hue_ind_der_id").ToString
                            .HuellaIDPulgarDerecho = sqlDr("kf_hue_pul_der_id").ToString
                            '/*************/
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
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

        Public Function ListarGrillaPopup(ByVal objEntFiltro As Entity.Visita.Visitante) As Entity.Visita.VisitanteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Visitante.Listar(sqlCon, "lst", "lst_grilla_popup", objEntFiltro)

            objEntCol = New Entity.Visita.VisitanteCol

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Visitante
                        With objEnt
                            .Codigo = sqlDr("vis_id").ToString
                            .ApellidoPaterno = sqlDr("vis_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("vis_ape_mat").ToString
                            .Nombres = sqlDr("vis_nom").ToString
                            .TipoDocumentoID = sqlDr("doc_tip_id").ToString
                            .TipoDocumentoNombre = sqlDr("doc_tip_nom").ToString
                            .NumeroDocumento = sqlDr("vis_doc_num").ToString
                            .FotoID = sqlDr("vis_fot_id").ToString
                            .FotoName = sqlDr("vis_fot").ToString
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString
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

#Region "Listar_Huella"
        Public Function BuscarHuella(IDTemplate As Integer, IDRegion As Short, IDPenal As Short) As Integer

            Dim value As Integer = -1

            If IDTemplate < 1 Then
                Return value
            End If

            Dim strMensajeError As String = ""
            Dim intIDHuella As Integer = -1

            '1.- buscar en la tabla huella digital
            Dim objBssHueDig As New Bussines.Biometria.HuellaDigital
            Dim objEntFiltroHueDig As New Entity.Biometria.HuellaDigital

            With objEntFiltroHueDig
                .IDTemplateHuella = IDTemplate
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With

            intIDHuella = objBssHueDig.BuscarIDHuella(objEntFiltroHueDig, strMensajeError)

            '2.- buscar en la tabla visitante huella
            If intIDHuella > 0 Then

                Dim objBssHueVis As New Bussines.Biometria.VisitanteHuella
                Dim objEntFiltroHueVis As New Entity.Biometria.VisitanteHuella

                With objEntFiltroHueVis
                    .IDIndiceIzquierdo = intIDHuella
                    .IDIndiceDerecho = intIDHuella
                    .IDPulgarIzquierdo = intIDHuella
                    .IDPulgarDerecho = intIDHuella
                    .IDRegion = IDRegion
                    .IDPenal = IDPenal
                End With

                value = objBssHueVis.BuscarIDVisita(objEntFiltroHueVis, strMensajeError)

            End If

            Return value

        End Function
#End Region

#Region "Grabar"

        Public Function Grabar(ByVal objEnt As Entity.Visita.Visitante) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If ValidarNumeroDocumento(objEnt) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El numero de documento ya existe en la base de datos")
                Return intValue
            End If

            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

            End With

            intValue = Data.Visita.Visitante.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
        Public Function GrabarAutorizacion(ByVal objEnt As Entity.Visita.Visitante) As Integer

            Dim intValue As Integer = -1

            If objEnt.Codigo > 0 Then
                Dim strAccion As String = "upd"
                Dim strOpcion As String = "upd_mant_autorizacion"
                If objEnt.NumeroDocumento.Length = 0 Or objEnt.FechaNacimiento = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "No existe el numero de documento o fecha de nacimiento.")
                    Return intValue
                End If

                intValue = Data.Visita.Visitante.Grabar(strAccion, strOpcion, objEnt)
            End If

            Return intValue

        End Function
        Public Function GrabarRnc(ByVal objEnt As Entity.Visita.Visitante) As Integer

            Dim intValue As Integer = -1

            If objEnt.Codigo > 0 Then
                Dim strAccion As String = "upd"
                Dim strOpcion As String = "upd_mant"
                If objEnt.NumeroDocumento.Length = 0 Or objEnt.FechaNacimiento = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "No existe el numero de documento o fecha de nacimiento.")
                    Return intValue
                End If

                intValue = Data.Visita.Visitante.Grabar(strAccion, strOpcion, objEnt)
            End If

            Return intValue

        End Function

        Public Function GrabarFoto(ByVal objEnt As Entity.Visita.Visitante) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_captura_foto"

            value = Data.Visita.Visitante.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function

        Public Function GrabarHuella(IDVisitante As Integer, objEntHuella1 As Entity.Visita.Huella, objEntHuella2 As Entity.Visita.Huella,
                                      IDRegion As Short, IDPenal As Short, ByRef intTieneHuella As Short) As Integer

            Dim value As Integer = -1

            Dim strMensajeError As String = ""
            Dim intIDHuella1 As Integer = -1
            Dim intIDHuella2 As Integer = -1

            '1.- grabar en la tabla huella digital
            Dim objBssHueDig As New Bussines.Biometria.HuellaDigital
            Dim objEntHueDig As New Entity.Biometria.HuellaDigital

            If objEntHuella1.IDTemplate > 0 Then
                With objEntHueDig
                    .IDTemplateHuella = objEntHuella1.IDTemplate
                    .CalidadTemplateHuella = objEntHuella1.CalidadHuella
                    .IDRegion = IDRegion
                    .IDPenal = IDPenal
                End With
                intIDHuella1 = objBssHueDig.Grabar(objEntHueDig, strMensajeError)
            Else
                intIDHuella1 = objEntHuella1.IDHuella
            End If

            If objEntHuella2.IDTemplate > 0 Then
                With objEntHueDig
                    .IDTemplateHuella = objEntHuella2.IDTemplate
                    .CalidadTemplateHuella = objEntHuella2.CalidadHuella
                    .IDRegion = IDRegion
                    .IDPenal = IDPenal
                End With
                intIDHuella2 = objBssHueDig.Grabar(objEntHueDig, strMensajeError)
            Else
                intIDHuella2 = objEntHuella2.IDHuella
            End If

            '2.- grabar en la tabla visitante huella
            Dim intCodigo As Integer = -1
            Dim intTipoCapturaManoIzq As Short = -1
            Dim intTipoCapturaManoDer As Short = -1

            Dim objBssHueVis As New Bussines.Biometria.VisitanteHuella
            Dim objEntHueVis As New Entity.Biometria.VisitanteHuella

            With objEntHueVis
                .IDVisitante = IDVisitante
                .FechaCaptura = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong
                .IDUsuarioInactivaHuella = Legolas.Configuration.Usuario.Codigo

                'mano izquierda
                intTipoCapturaManoIzq = objEntHuella1.TipoCaptura
                .TipoCapturaIzquierdo = objEntHuella1.TipoCaptura
                .ObservacionIzquierdo = objEntHuella1.Observacion

                Select Case objEntHuella1.TipoDedo
                    Case Type.Enumeracion.Biometria.TipoDedo.IndiceIzquierdo
                        .IDIndiceIzquierdo = intIDHuella1
                        .CalidadIndiceIzquierdo = objEntHuella1.CalidadHuella

                    Case Type.Enumeracion.Biometria.TipoDedo.PulgarIzquierdo
                        .IDPulgarIzquierdo = intIDHuella1
                        .CalidadPulgarIzquierdo = objEntHuella1.CalidadHuella
                End Select

                'mano derecha
                intTipoCapturaManoDer = objEntHuella2.TipoCaptura

                .TipoCapturaDerecho = objEntHuella2.TipoCaptura
                .ObservacionDerecho = objEntHuella2.Observacion

                Select Case objEntHuella2.TipoDedo
                    Case Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
                        .IDIndiceDerecho = intIDHuella2
                        .CalidadIndiceDerecho = objEntHuella2.CalidadHuella

                    Case Type.Enumeracion.Biometria.TipoDedo.PulgarDerecho
                        .IDPulgarDerecho = intIDHuella2
                        .CalidadPulgarDerecho = objEntHuella2.CalidadHuella
                End Select

                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With
            intCodigo = objBssHueVis.Grabar(objEntHueVis, strMensajeError)

            '3.- grabar huella en la tabla visita
            If intCodigo > 0 Then

                intTieneHuella = Type.Enumeracion.Visita.Visitante.TieneHuella.SI

                If intTipoCapturaManoIzq = Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado _
                        Or intTipoCapturaManoIzq = Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado Then

                    If intTipoCapturaManoDer = Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado _
                        Or Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado Then

                        intTieneHuella = Type.Enumeracion.Visita.Visitante.TieneHuella.Obs

                    End If

                End If

                objEnt = New Entity.Visita.Visitante
                With objEnt
                    .Codigo = IDVisitante
                    .IDUsuarioCapturaHuella = Legolas.Configuration.Usuario.Codigo
                    .VisitanteTieneHuella = intTieneHuella
                    .RegionID = IDRegion
                    .PenalID = IDPenal
                End With

                Dim objBss As New Bussines.Visita.Visitante
                intCodigo = objBss.GrabarHuella(objEnt)
            End If

            value = intCodigo
            Return value

        End Function

        Private Function GrabarHuella(ByVal objEnt As Entity.Visita.Visitante) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_captura_huella"

            value = Data.Visita.Visitante.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function

        Public Function GrabarValidacionReniec(intIDVisita As Integer, intIDUsuarioValidacion As Integer, lngFechaValidacion As Long,
                                               TipoValidacion As Type.Enumeracion.Visita.Visitante.ValidadoServicio) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_visita_validar_reniec"

            objEnt = New Entity.Visita.Visitante
            With objEnt
                .Codigo = intIDVisita
                .VisitanteValidoReniec = TipoValidacion
                .IDUsuarioValidacionReniec = intIDUsuarioValidacion
                .FechaValidacionReniec = lngFechaValidacion
            End With

            value = Data.Visita.Visitante.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function
#End Region

#Region "Eliminar"
        Public Function Eliminar(ByVal intIDVisitante As Integer) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            value = Data.Visita.Visitante.Eliminar(strAccion, strOpcion, intIDVisitante, _
                                                      Legolas.Configuration.Usuario.Codigo)
            Return value
        End Function
        Public Function Eliminar(ByVal intIDVisitante As Integer, intIDRegion As Short, intIDPenal As Short) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            'validar si el visitante tiene movimientos
            If VisitanteTieneMovimiento(intIDVisitante, intIDRegion, intIDPenal) = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El Visitante actual no se puede eliminar, debido que tiene registros de movimientos en el modulo de visita")
                Return value
            End If

            value = Data.Visita.Visitante.Eliminar(strAccion, strOpcion, intIDVisitante, _
                                                      Legolas.Configuration.Usuario.Codigo)
            Return value
        End Function
#End Region

    End Class
End Namespace