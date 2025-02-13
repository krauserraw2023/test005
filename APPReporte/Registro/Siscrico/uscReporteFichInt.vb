Imports Microsoft.Reporting.WinForms
Imports CrystalDecisions.CrystalReports.Engine

Namespace Registro.Siscrico
    Public Class uscReporte
        '/*parametricas reporte*/
        'Private p_Correlativo() As Microsoft.Reporting.WinForms.ReportParameter 'correlativo
        'Private p_FechaEmision() As Microsoft.Reporting.WinForms.ReportParameter 'fecha emision
        'Private p_NumeroDoc() As Microsoft.Reporting.WinForms.ReportParameter 'numero doc     
        '/**/
        Private blnRep As Boolean = False
        Private frmLoad As Load.frmLoad = Nothing
        Private objEntCol As Object = Nothing
        Private objBssRpt As Legolas.LBusiness.Globall.Reporte


        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Private strFotoPC As String = ""
        Private strFotoPI As String = ""

#Region "Enum"
        Public Enum EnmTipoReporte
            rpt = -1
            rptFichaInterno = 4
            rptCertificadoReclusion = 6
            rptPapeletaExcarcelacion = 7
            rptCertificadoLibertad = 8
            rptHistorialAntecedentes = 9
        End Enum
        Public Enum EnmNaciolidad
            Todos = -1
            Nacional = 1
            Extranjeros = 2
        End Enum
#End Region
#Region "Propiedades_Reporte"
        Private intTipoReporte As EnmTipoReporte = EnmTipoReporte.rpt
        Private strReporteModulo As String = ""
        Private strReporteNombre As String = ""
        Private strReporteNombreFisico As String = ""
        Private strReporteActa As String = ""
        Private strReporteDependencia As String = ""
        Private strReporteModuloVersion As String = ""
        Private intReporteNumero As Integer = 0
        Private intReporteNumeroExportacion As Integer = 0
        Private ReadOnly Property ReporteID() As Integer
            Get
                Dim intCodigoReporte As Integer = -1

                intCodigoReporte = Me._pReporteTipo.GetHashCode

                Return intCodigoReporte
            End Get
        End Property
        Public Property _pReporteTipo() As EnmTipoReporte
            Get
                Return intTipoReporte
            End Get
            Set(ByVal value As EnmTipoReporte)
                intTipoReporte = value
            End Set
        End Property

        Private Property ReporteModulo() As String
            Get
                Return strReporteModulo
            End Get
            Set(ByVal value As String)
                strReporteModulo = value
            End Set
        End Property
        Private Property ReporteModuloVersion() As String
            Get
                Return strReporteModuloVersion
            End Get
            Set(ByVal value As String)
                strReporteModuloVersion = value
            End Set
        End Property

        Private Property ReporteNombre() As String
            Get
                Return strReporteNombre
            End Get
            Set(ByVal value As String)
                strReporteNombre = value
            End Set
        End Property
        Private Property ReporteNombreFisico() As String
            Get
                Return strReporteNombreFisico
            End Get
            Set(ByVal value As String)
                strReporteNombreFisico = value
            End Set
        End Property
        Private ReadOnly Property ReporteNombreFisicoPath() As String
            Get
                Dim strValue As String = ""
                Dim strNumero As String = ""

                If Me.ReporteNumero > 0 Then
                    strNumero = Me.ReporteNumeroString(False)
                Else
                    strNumero = Me.ReporteNumeroExportacionString(False)
                End If
                strValue = Legolas.Configuration.Path.PathTemp & Me.ReporteNombreFisico
                strValue = strValue & "."
                strValue = strValue & strNumero
                strValue = strValue & ".pdf"
                Return strValue
            End Get

        End Property
        Private Property ReporteActa() As String
            Get
                Return strReporteActa
            End Get
            Set(ByVal value As String)
                strReporteActa = value
            End Set
        End Property
        Private Property ReporteDependencia() As String
            Get
                Return strReporteDependencia
            End Get
            Set(ByVal value As String)
                strReporteDependencia = value
            End Set
        End Property
        Private Function FechayHora() As String

            Dim strValue As String = ""
            Dim strFecha As String = Legolas.Configuration.Aplication.FechayHora.FechaString
            Dim dteHora As Date = Now.ToShortTimeString

            dteHora = Legolas.LBusiness.Globall.DateTime.HoraServer
            strValue = strFecha & " " & dteHora.ToLongTimeString
            Return strValue

        End Function
        Private Property ReporteNumero() As Integer
            Get
                Return intReporteNumero
            End Get
            Set(ByVal value As Integer)
                intReporteNumero = value
            End Set
        End Property
        Private Function ReporteNumeroString(Optional ByVal VisibleTexto As Boolean = True) As String

            Dim value As String = ""

            If VisibleTexto = True Then
                value = "Nro. Impresión: " & Me.ReporteNumero.ToString("000000")
            Else
                value = Me.ReporteNumero.ToString("000000")
            End If

            Return value

        End Function
        Private Property ReporteNumeroExportacion() As Integer
            Get
                Return intReporteNumeroExportacion
            End Get
            Set(ByVal value As Integer)
                intReporteNumeroExportacion = value
            End Set
        End Property
        Private Function ReporteNumeroExportacionString(Optional ByVal VisibleTexto As Boolean = True) As String

            Dim value As String = ""

            If VisibleTexto = True Then
                value = "Nro. Exportación: " & Me.ReporteNumeroExportacion.ToString("000000")
            Else
                value = Me.ReporteNumeroExportacion.ToString("000000")
            End If

            Return value

        End Function
        'Private ReadOnly Property ReportePath() As String
        '    Get
        '        'Return Legolas.Configuration.Path.PathReporte & "Registro\"
        '        Dim value As String = ""
        '        Select Case Legolas.Components.PC.PCNombre.ToUpper
        '            Case "00110-13", "00110-27"
        '                value = My.Application.Info.DirectoryPath & "\Registro\"
        '            Case Else
        '                value = Legolas.Configuration.Path.PathReporte & "Registro\"
        '        End Select
        '        Return value
        '    End Get
        'End Property

        Private ReadOnly Property ReportePath() As String
            Get
                Dim value As String = ""
                Select Case Legolas.Components.PC.PCNombre.ToUpper

                    Case "00110-13", "00110-27"

                        If Legolas.Components.Archivo.DirectorioExiste(My.Application.Info.DirectoryPath & "\Registro\") = True Then
                            value = My.Application.Info.DirectoryPath & "\Registro\"
                        Else
                            value = Legolas.Configuration.Path.PathReporte & "Registro\"
                        End If

                    Case Else
                        value = Legolas.Configuration.Path.PathReporte & "Registro\"
                End Select
                Return value
            End Get
        End Property

#End Region
#Region "Propiedades"
        'Private intpRegionID As Integer = -1

        Public Property _pInternoID() As Long = -1
        Public Property _pPenalID() As Integer = -1

        Public Property Nacionalidad() As EnmNaciolidad = EnmNaciolidad.Todos

        Public ReadOnly Property NacionalidadTitulo() As String
            Get
                Dim strValue As String = ""

                Select Case Me.Nacionalidad
                    Case EnmNaciolidad.Nacional
                        strValue = "Peruanos"
                    Case EnmNaciolidad.Extranjeros
                        strValue = "Extranjeros"
                    Case EnmNaciolidad.Todos
                        strValue = "Peruanos y Extranjeros"
                End Select
                Return strValue
            End Get
        End Property
        Public Property FechaIni() As Long = 0
        Public Property FechaFin() As Long = 0
        Public Property Filtro() As String = ""

        Public Property _CambiarEstadoImpresion() As Boolean
            Get
                Return CrystalReportViewer1.ShowPrintButton
            End Get
            Set(value As Boolean)
                CrystalReportViewer1.ShowPrintButton = value
            End Set
        End Property
#End Region
#Region "Propiedades_Parametricas"
        Private strpCorrelativo As String = ""
        Private strpNumeroDoc As String = ""
        Private strpFechaEmision As String = ""
        Private strpObservacion1 As String = ""
        Private strpObservacion2 As String = ""
        Private objRestriccionCol As Entity.Reporte.CertificadoLibertad.RestriccionCol = Nothing
        Public Property _pCorrelativo() As String
            Get
                Return strpCorrelativo
            End Get
            Set(ByVal value As String)
                strpCorrelativo = value
            End Set
        End Property
        Public Property _pNumeroDoc() As String
            Get
                Return strpNumeroDoc
            End Get
            Set(ByVal value As String)
                strpNumeroDoc = value
            End Set
        End Property
        Public Property _pFechaEmision() As String
            Get
                Return strpFechaEmision
            End Get
            Set(ByVal value As String)
                strpFechaEmision = value
            End Set
        End Property
        Public Property _pObservacion1() As String
            Get
                Return strpObservacion1
            End Get
            Set(ByVal value As String)
                strpObservacion1 = value
            End Set
        End Property
        Public Property _pObservacion2() As String
            Get
                Return strpObservacion2
            End Get
            Set(ByVal value As String)
                strpObservacion2 = value
            End Set
        End Property
        Public Property _pRestriccionCol() As Entity.Reporte.CertificadoLibertad.RestriccionCol
            Get
                Return objRestriccionCol
            End Get
            Set(ByVal value As Entity.Reporte.CertificadoLibertad.RestriccionCol)
                objRestriccionCol = value
            End Set
        End Property
#End Region
#Region "Reporte"
        Private Sub ListarPropiedadesReporte()
            Dim objEnt As New Legolas.LEntity.Globall.Reporte
            objBssRpt = New Legolas.LBusiness.Globall.Reporte

            objEnt = objBssRpt.Listar(Me.ReporteID)

            With objEnt
                Me.ReporteNombre = .Nombre
                Me.ReporteNombreFisico = .NombreFisico
                Me.ReporteDependencia = .DependenciaNombre
                Me.ReporteModulo = .Modulo
                Me.ReporteModuloVersion = .Version
                Me.ReporteActa = .Acta
            End With

        End Sub
        Private Function Listar() As Boolean
            Dim objBss As New Bussines.Reporte.Registro
            ' ''Select Case Me._pReporteTipo
            ' ''    Case EnmTipoReporte.rptFichaInterno
            objEntCol = New Entity.Reporte.FichaIdentificacion.FichaCol
            objEntCol = objBss.FichaIdentificacion_Provincia(Me._pInternoID)
            ' ''End Select
            Return True
        End Function

        Private Sub ReporteFichaInterno(Optional ByVal Impresion As Boolean = False,
           Optional ByVal ExportarPDF As Boolean = False)

            Me.Text = "Reporte - Ficha"

            Dim objBss As New Bussines.Reporte.Registro
            rpt = New ReportDocument

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.FichaCol
            objEntCol = objBss.FichaIdentificacion_Provincia(_pInternoID)
            rpt.Load(Me.ReportePath & "rpt_ficha_identificacion.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("cr_Senias_particulares").DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.FichaIdentificacion.Ficha In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
                End If

                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)

                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", UCase(obj.NombresAsociados)))
                'rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", UCase(obj.SituacionJuridicaNombre)))
                'rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "", "NR", UCase(obj.InfoDecadactilarInt)))
                rpt.SetParameterValue("p_alias", If(Trim(obj.AliasNombres) = "", "NR", UCase(obj.AliasNombres)))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", UCase(obj.PenalActual)))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_identidad", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_org_criminal", "") 'x.Bandas)
                rpt.SetParameterValue("p_sexo", UCase(obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", UCase(obj.Madre)))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", UCase(obj.Padre)))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", UCase(obj.Conyugue)))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", UCase(obj.EstadoCivil)))
                rpt.SetParameterValue("p_otro_doc", If(obj.OtroDocumento = "", "NR", UCase(obj.OtroDocumento)))
                rpt.SetParameterValue("p_apellidos_interno", obj.ApellidoPaterno & " " & UCase(obj.ApellidoMaterno))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", UCase(obj.Nacionalidad)))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", UCase(obj.NacimientoDepartamento)))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", UCase(obj.NacimientoDistrito)))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", UCase(obj.NacimientoPais)))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", UCase(obj.NacimientoProvincia)))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", UCase(obj.NacimientoLugar)))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", UCase(obj.DomicilioDepartamento)))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", UCase(obj.DomicilioDistrito)))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", UCase(obj.DomicilioProvincia)))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", UCase(obj.Domicilio)))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "", "NR", UCase(obj.GradoInstruccion)))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "", "NR", UCase(obj.Ocupacion)))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "", "NR", UCase(obj.Profesion)))

                'verifica si hay rasgos
                Dim objEntRasgo As Entity.Reporte.FichaIdentificacion.Rasgos
                If obj.RasgoCol.Count < 1 Then
                    objEntRasgo = New Entity.Reporte.FichaIdentificacion.Rasgos
                Else
                    objEntRasgo = obj.RasgoCol.Rasgos(0)
                End If

                rpt.SetParameterValue("p_car_raza", If(objEntRasgo.Raza = "", "NR", UCase(objEntRasgo.Raza)))
                rpt.SetParameterValue("p_car_forma_cara", If(objEntRasgo.FormaCara = "", "NR", UCase(objEntRasgo.FormaCara)))
                rpt.SetParameterValue("p_car_frente", If(objEntRasgo.Frente = "", "NR", UCase(objEntRasgo.Frente)))
                rpt.SetParameterValue("p_car_forma_ojo", If(objEntRasgo.FormaOjos = "", "NR", UCase(objEntRasgo.FormaOjos)))
                rpt.SetParameterValue("p_car_ceja", If(objEntRasgo.Ceja = "", "NR", UCase(objEntRasgo.Ceja)))
                rpt.SetParameterValue("p_car_tip_labio", If(objEntRasgo.TipoLabios = "", "NR", UCase(objEntRasgo.TipoLabios)))
                rpt.SetParameterValue("p_car_linea_insercc", If(objEntRasgo.LineaInsercion = "", "NR", UCase(objEntRasgo.LineaInsercion)))
                rpt.SetParameterValue("p_car_complex", If(objEntRasgo.Complexion = "", "NR", UCase(objEntRasgo.Complexion)))
                rpt.SetParameterValue("p_car_talla", If(objEntRasgo.Talla = 0, "NR", objEntRasgo.Talla))
                rpt.SetParameterValue("p_car_color_cab", If(objEntRasgo.ColorCabello = "", "NR", UCase(objEntRasgo.ColorCabello)))
                rpt.SetParameterValue("p_car_boca", If(objEntRasgo.Boca = "", "NR", UCase(objEntRasgo.Boca)))
                rpt.SetParameterValue("p_car_tip_nariz", If(objEntRasgo.TipoNariz = "", "NR", UCase(objEntRasgo.TipoNariz)))
                rpt.SetParameterValue("p_car_oreja", If(objEntRasgo.Oreja = "", "NR", UCase(objEntRasgo.Oreja)))
                rpt.SetParameterValue("p_car_anom_ojos", If(objEntRasgo.AnomaliaOjos = "", "NR", UCase(objEntRasgo.AnomaliaOjos)))
                rpt.SetParameterValue("p_car_peso", If(objEntRasgo.Peso = 0, "NR", objEntRasgo.Peso))
                rpt.SetParameterValue("p_car_menton", If(objEntRasgo.Menton = "", "NR", UCase(objEntRasgo.Menton)))
                rpt.SetParameterValue("p_car_form_cabello", If(objEntRasgo.FormaCabello = "", "NR", UCase(objEntRasgo.FormaCabello)))
                rpt.SetParameterValue("p_car_iris", If(objEntRasgo.Iris = "", "NR", UCase(objEntRasgo.Iris)))
                rpt.SetParameterValue("p_car_labios", If(objEntRasgo.Labios = "", "NR", UCase(objEntRasgo.Labios)))
                rpt.SetParameterValue("p_car_form_nariz", If(objEntRasgo.FormaNariz = "", "NR", UCase(objEntRasgo.FormaNariz)))
                rpt.SetParameterValue("p_car_tronco", If(objEntRasgo.Tronco = "", "NR", UCase(objEntRasgo.Tronco)))
                rpt.SetParameterValue("p_car_calvicie", If(objEntRasgo.Calvicie = "", "NR", UCase(objEntRasgo.Calvicie)))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", UCase(obj.Nombres)))

            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_delitos3", "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", _pInternoID, "crDelitos")
            rpt.SetParameterValue("@int_ing_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_exp_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_sen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_del_id", -1, "crDelitos")
            rpt.SetParameterValue("@nac_id", -1, "crDelitos")
            rpt.SetParameterValue("@cuadro", -1, "crDelitos")
            rpt.SetParameterValue("@fec_ini", 0, "crDelitos")
            rpt.SetParameterValue("@fec_fin", 0, "crDelitos")
            rpt.SetParameterValue("@_fecha", 0, "crDelitos")
            rpt.SetParameterValue("@reg_id", -1, "crDelitos")
            rpt.SetParameterValue("@tip_band_id", -1, "crDelitos")
            rpt.SetParameterValue("@ban_id", -1, "crDelitos")
            rpt.SetParameterValue("@strNomAsoc", "", "crDelitos")

            '------sub reporte senias particulares-------------------------------------------------------------
            rpt.SetParameterValue("@accion", "lst", "cr_Senias_particulares")
            rpt.SetParameterValue("@opcion", "lst_senas_particulares", "cr_Senias_particulares")
            rpt.SetParameterValue("@pen_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@int_id", _pInternoID, "cr_Senias_particulares")
            rpt.SetParameterValue("@int_ing_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@int_exp_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@int_sen_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@int_del_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@nac_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@cuadro", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@fec_ini", 0, "cr_Senias_particulares")
            rpt.SetParameterValue("@fec_fin", 0, "cr_Senias_particulares")
            rpt.SetParameterValue("@_fecha", 0, "cr_Senias_particulares")
            rpt.SetParameterValue("@reg_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@tip_band_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@ban_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@strNomAsoc", "", "cr_Senias_particulares")
            '-------------------------------------------------------------------


            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")
            rpt.SetParameterValue("@int_id", _pInternoID)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", 0)
            rpt.SetParameterValue("@fec_fin", 0)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            ' rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@strNomAsoc", "")
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            ' rpt.SetParameterValue("p_bandas", "")

            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub VerReporte(Optional ByVal Impresion As Boolean = False,
        Optional ByVal Oficina As String = "", Optional ByVal ExportarPDF As Boolean = False)
            'Select Case Me._pReporteTipo

            '    Case EnmTipoReporte.rptFichaInterno
            '        If blnRep = True Then
            Listar()
            ReporteFichaInterno(Impresion, ExportarPDF)
            '        End If
            'End Select
        End Sub
#End Region
#Region "Impresion"
        'Private Sub Exportar(ByVal PathFile As String)

        '    Dim warnings As Warning() = Nothing
        '    Dim streamids As String() = Nothing
        '    Dim mimeType As String = Nothing
        '    Dim encoding As String = Nothing
        '    Dim extension As String = Nothing
        '    Dim bytPDF As Byte()

        '    bytPDF = Me.ReportViewer1.LocalReport.Render("PDF", Nothing, mimeType, encoding, extension, streamids, warnings)
        '    Legolas.Components.Archivo.FileCreateByte(bytPDF, PathFile)

        'End Sub
        Private Function SetDefPrinter(ByVal sNombreImpresora As String) As Boolean
            'Parámetro especifica nombre de impresora para poner por defecto.
            'La pongo por defecto y la quito.

            Dim WshNetwork As Object
            Dim pd As New Printing.PrintDocument

            WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")

            Try
                WshNetwork.SetDefaultPrinter(sNombreImpresora)
                pd.PrinterSettings.PrinterName = sNombreImpresora
                If pd.PrinterSettings.IsValid Then
                    Return True
                Else
                    WshNetwork.SetDefaultPrinter(sNombreImpresora)
                    Return False
                End If
            Catch exptd As Exception
                'WshNetwork.SetDefaultPrinter(sNombreImpresora)
                Return False
            Finally
                WshNetwork = Nothing
                pd = Nothing
            End Try

        End Function
        Private Sub GenerarCabecera(Optional ByVal ExportarPDF As Boolean = False, Optional ByVal Ruta As String = "")

            Dim strRuta As String = ""
            VerReporte(True, ExportarPDF)

            If ExportarPDF = True Then
                strRuta = Ruta
            Else
                strRuta = Legolas.Configuration.Path.PathTemp & Me.ReporteNombreFisico & ".pdf"
            End If

            'Exportar(strRuta)

        End Sub




#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            ListarPropiedadesReporte()
            Me.ReporteModuloVersion = Legolas.Configuration.Aplication.VersionString
        End Sub
        Public Sub InicializarReporte()
            ValoresxDefault()
            VerReporte()
            'ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            'ReportViewer1.ZoomMode = ZoomMode.Percent
        End Sub

        Public Function ImprimirFicha() As Boolean
            Dim v As Boolean = False
            Try
                rpt.PrintToPrinter(1, False, 0, 0)
                v = True
            Catch ex As Exception
                v = False
            End Try
            Return v
        End Function

        Public Sub ExportarFichaPDF(RutaArchivo As String)
            'Dim warnings As Warning() = Nothing
            'Dim streamids As String() = Nothing
            'Dim mimeType As String = Nothing
            'Dim encoding As String = Nothing
            'Dim extension As String = Nothing
            'Dim bytPDF As Byte()

            'bytPDF = Me.ReportViewer1.LocalReport.Render("PDF", Nothing, mimeType, encoding, extension, streamids, warnings)
            'Legolas.Components.Archivo.FileCreateByte(bytPDF, RutaArchivo)
            'bytPDF = Nothing
        End Sub
#End Region
    End Class

End Namespace