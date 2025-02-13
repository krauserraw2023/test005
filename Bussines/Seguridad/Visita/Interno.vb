Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class Interno
        Private objEnt As Entity.Visita.Interno = Nothing
        Private objEntCol As Entity.Visita.InternoCol = Nothing

#Region "Functions"
        Public Function ListarIDString(ByVal CodigoRP As String, ByVal RegionID As Integer, ByVal PenalID As Integer) As Integer

            Dim value As Integer = -1

            objEnt = New Entity.Visita.Interno

            With objEnt
                .CodigoRP = CodigoRP
                .IDRegion = RegionID
                .IDPenal = PenalID
            End With

            value = Data.Visita.Interno.ListarOutput("lst", "lst_id_str", objEnt)

            Return value

        End Function
#End Region
#Region "Validar"
        Public Function ValidarNumeroDocumento(ByVal objEntFiltro As Entity.Visita.Interno) As Boolean

            Dim value As Boolean = True

            If objEntFiltro.NumeroDocumento.Length > 1 Then
                Dim intvalue As Integer = 0
                intvalue = Data.Visita.Interno.ListarOutput("lst", "lst_val_numero_documento", objEntFiltro)

                If intvalue > 0 Then
                    value = False
                End If
            End If

            Return value

        End Function
        Public Function ValidarApellidosyNombres(ByVal objEntFiltro As Entity.Visita.Interno) As Boolean

            Dim value As Boolean = True
            Dim intvalue As Integer = 0

            intvalue = Data.Visita.Interno.ListarOutput("lst", "lst_val_apellidos_nombres", objEntFiltro)

            If intvalue > 0 Then
                value = False
            End If

            Return value

        End Function
#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.Interno

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Visita.Interno
            objEntFiltro.Codigo = Codigo

            Dim sqlDr As SqlDataReader = Data.Visita.Interno.Listar(sqlCon, "lst", "", objEntFiltro)

            objEnt = New Entity.Visita.Interno
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
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
                            .EstadoID = sqlDr("int_est_id").ToString
                            .Obs = sqlDr("int_obs").ToString
                            '/*otros*/
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_nom").ToString
                            .VisitaSancion = sqlDr("int_vis_san").ToString
                            .SituacionJuridica = sqlDr("sit_jur_nom").ToString
                            ''/*region y penal*/
                            '.RegionID = sqlDr("reg_id").ToString
                            '.RegionNombre = sqlDr("reg_nom").ToString
                            '.PenalID = sqlDr("pen_id").ToString
                            '.PenalNombre = sqlDr("pen_nom").ToString                            
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
        Public Function Listar2(ByVal Codigo As Integer) As Entity.Visita.Interno

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Visita.Interno
            objEntFiltro.Codigo = Codigo

            'seleccionar la opcion correspondiente a la licencia
            Dim strOpcion As String = ""
            Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                Case 1 'sede central
                    strOpcion = "lst_mant_sede_plm"
                Case Else
                    strOpcion = "lst_mant2"
            End Select

            Dim sqlDr As SqlDataReader = Data.Visita.Interno.Listar(sqlCon, "lst", strOpcion, objEntFiltro)

            objEnt = New Entity.Visita.Interno
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
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

                            'estado
                            .EstadoID = sqlDr("int_est_id").ToString
                            If .EstadoID < 1 Then
                                .EstadoID = 0
                            End If

                            .Obs = sqlDr("int_obs").ToString
                            '/*otros*/
                            .PabellonID = sqlDr("pab_id").ToString

                            If .PabellonID > 0 Then
                                .PabellonNombre = sqlDr("pab_nom").ToString
                            Else
                                .PabellonNombre = sqlDr("pab_nom_Reg").ToString
                            End If

                            .VisitaSancion = sqlDr("int_vis_san").ToString
                            .SituacionJuridica = sqlDr("sit_jur_nom").ToString
                            .EtapaID = sqlDr("etp_id").ToString
                            .EtapaNombre = sqlDr("etp_nom").ToString
                            '/*region y penal*/
                            .IDRegion = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .IDPenal = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
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
        Public Function ListarGrilla(ByVal objEntFiltro As Entity.Visita.Interno) As Entity.Visita.InternoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Visita.Interno.Listar(sqlCon, "lst", "lst_visita_interno", objEntFiltro)

            Try
                objEntCol = New Entity.Visita.InternoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Interno
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
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
                            '/*otros*/
                            .VisitaSancion = sqlDr("int_vis_san").ToString
                            .SituacionJuridica = sqlDr("sit_jur_nom").ToString
                            '/*penal*/
                            .IDRegion = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .IDPenal = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .Obs = sqlDr("int_obs").ToString
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
#Region "ListarNombresAsociados"

        Public Function ListarGrillaNombresAsociados(ByVal objEntFiltro As Entity.Visita.Interno) As Entity.Visita.InternoCol

            Dim objBss As New Registro.Interno_Grilla
            Dim objEntCol As New Entity.Visita.InternoCol

            Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                Case 1 'sede central

                    If objEntFiltro.IDRegion = 3 Then 'penales de la region lima

                        Dim intIDTipoLicenciaPenal As Short = -1
                        Dim objBssPenal As New Bussines.General.Penal
                        intIDTipoLicenciaPenal = objBssPenal.fnTipoLicencia(objEntFiltro.IDPenal)

                        Select Case intIDTipoLicenciaPenal
                            Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                                objEntCol = objBss.Listar_Grilla_Visita_Interno("lst_grilla_interno_visita_plm", objEntFiltro)
                            Case Else
                                objEntCol = objBss.Listar_Grilla_Visita_Interno("lst_grilla_interno_visita", objEntFiltro)
                        End Select

                    Else
                        objEntCol = objBss.Listar_Grilla_Visita_Interno("lst_grilla_interno_visita", objEntFiltro)
                    End If

                Case Else
                    objEntCol = objBss.Listar_Grilla_Visita_Interno("lst_grilla_interno_visita", objEntFiltro)
            End Select

            Return objEntCol

        End Function

#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Visita.Interno) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_visita_lite"

                    If ValidarNumeroDocumento(objEnt) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "El numero de documento que esta ingresando, ya existe en la base de datos")
                        Return intValue
                    End If

                    If ValidarApellidosyNombres(objEnt) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Los apellidos y nombres que esta ingresando, ya existe en la base de datos")
                        Return intValue
                    End If

                Else
                    strAccion = "upd"
                    strOpcion = "upd_visita_lite"
                End If
            End With


            intValue = Data.Visita.Interno.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
        Public Function Grabar2(ByVal objEnt As Entity.Visita.Interno) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If ValidarApellidosyNombres(objEnt) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Los apellidos y nombres que esta ingresando, ya existe en la base de datos")
                Return intValue
            End If

            If ValidarNumeroDocumento(objEnt) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "El numero de documento que esta ingresando, ya existe en la base de datos")
                Return intValue
            End If

            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_visita_lite2"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_visita_lite2"
                End If
            End With

            intValue = Data.Visita.Interno.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
        Public Function GrabarLite(ByVal objEnt As Entity.Visita.Interno) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = "ins"
            Dim strOpcion As String = "ins_visita_lite"

            Value = Data.Visita.Interno.Grabar(strAccion, strOpcion, objEnt)

            Return Value

        End Function
        Public Function GrabarPabellon(ByVal objEnt As Entity.Visita.Interno) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_visita_lite_pabellon2"

            value = Data.Visita.Interno.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function
        Public Function InactivarInterno(ByVal intIDInterno As Integer) As Integer

            Dim value As Integer = -1

            value = GrabarEstadoInterno(intIDInterno, 0) 'baja

            Return value

        End Function
        Public Function ActivarInterno(intIDInterno As Integer, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1

            objEnt = New Entity.Visita.Interno
            objEnt = Listar2(intIDInterno)

            If Not objEnt Is Nothing Then

                If objEnt.EstadoID = 1 Then 'alta
                    strMensajeOut = "El interno seleccionado ya se encuentra Activo"
                    Return value
                Else
                    value = GrabarEstadoInterno(intIDInterno, 1) 'baja
                End If
            End If

            Return value

        End Function
        Private Function GrabarEstadoInterno(ByVal intIDInterno As Integer, intEstado As Short) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_interno_estado"

            objEnt = New Entity.Visita.Interno
            With objEnt
                .Codigo = intIDInterno
                .EstadoID = intEstado
            End With

            intValue = Data.Visita.Interno.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
#End Region

    End Class
End Namespace