Option Explicit On
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports Type.Enumeracion.Licencia
Imports System.Data
Imports Bussines
Imports DataClass
Imports System.Linq
Imports System.IO
Imports Bussines.Clasificacion.Documento
Imports Bussines.Clasificacion.InternoClasificacion
Imports Type.Enumeracion.Clasificacion
Imports Type.Enumeracion.Movimiento

Namespace Registro
    Public Class ReporteCrystal
        Private Enum enmGirarHuella As Short
            Ninguno = 0
            GirarHaciaDerecha = 1
            GirarHaciaIzquierda = 2
        End Enum
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        'fdsfds
        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Private strFotoPC As String = ""
        Private strFotoPerfilDerecho As String = ""
        Private strOdontograma As String = ""

        Private strPathIzq_men As String = ""
        Private strPathIzq_anu As String = ""
        Private strPathIzq_med As String = ""
        Private strPathIzq_ind As String = ""
        Private strPathIzq_pul As String = ""
        Private strPathDer_men As String = ""
        Private strPathDer_anu As String = ""
        Private strPathDer_med As String = ""
        Private strPathDer_ind As String = ""
        Private strPathDer_pul As String = ""

#Region "Propiedades_Parametricas"
        Public Property _Filtro() As New Entity.Reporte.Registro.Filtro
#End Region
#Region "Propiedades_Reporte"
        Private intRpt As Integer = 0
        Public Property _VersionRpt As Integer
            Get
                Return intRpt
            End Get
            Set(value As Integer)
                intRpt = value
            End Set
        End Property

        Private intTipoReporte As Type.Reporte.Registro = Type.Reporte.Registro.rpt
        Private ReadOnly Property ReporteID() As Integer
            Get
                Dim intCodigoReporte As Integer = -1

                intCodigoReporte = Me._TipoReporte.GetHashCode

                Return intCodigoReporte
            End Get
        End Property
        Public Property _TipoReporte() As Type.Reporte.Registro
            Get
                Return intTipoReporte
            End Get
            Set(ByVal value As Type.Reporte.Registro)
                intTipoReporte = value
            End Set
        End Property
        Private Property ReporteNombre() As String = ""
        Private Property ReporteNombreFisico() As String = ""
        Private Property ReporteDependencia() As String = ""
        Private Property ReporteModulo() As String = ""
        Private Property ReporteModuloVersion() As String = ""
        Private Property ReporteActa() As String = ""
        Private ReadOnly Property ReportePath() As String
            Get
                Dim value As String = ""

                value = Legolas.Configuration.Path.PathReporte & "Registro\"

                value = value.Replace("\\", "\")
                Return value
            End Get
        End Property
        Public Property _pRestriccionCol() As Entity.Reporte.CertificadoLibertad.RestriccionCol = Nothing

#Region "Functions"
        Private Function FechayHora() As String

            Dim strValue As String = ""
            Dim strFecha As String = Legolas.Configuration.Aplication.FechayHora.FechaString
            Dim dteHora As Date = Now.ToShortTimeString

            dteHora = Legolas.LBusiness.Globall.DateTime.HoraServer
            strValue = strFecha & " " & dteHora.ToLongTimeString
            Return strValue

        End Function
#End Region
#End Region
#Region "Reporte"
        Private Sub ListarPropiedadesReporte()

            Dim objEnt = (New Legolas.LBusiness.Globall.Reporte).Listar(Me.ReporteID)

            With objEnt
                Me.ReporteNombre = .Nombre
                Me.ReporteNombreFisico = .NombreFisico
                Me.ReporteDependencia = .DependenciaNombre
                Me.ReporteModulo = .Modulo
                Me.ReporteModuloVersion = .Version
                Me.ReporteActa = .Acta
            End With

        End Sub

        Private Sub VerReporte()

            Dim strMensajeOut As String = ""

            Select Case Me._TipoReporte

                Case Type.Reporte.Registro.rptFichaIdentificacion_V5 'ficha de identificacion penal provincia
                    Reporte_Ficha_Identificacion_Provincia()

                Case Type.Reporte.Registro.rptFichaIdentificacionCarceleta
                    Reporte_Ficha_Identificacion_Carceleta_ORL_PLM() 'con odontograma reducido

                Case Type.Reporte.Registro.rptFichaPenologicaCarceleta
                    Reporte_Ficha_Penologica_Carceleta()

                Case Type.Reporte.Registro.rptFichaDecadactilar

                    If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        Reporte_FichaDecadactilar_LM(strMensajeOut)
                    Else
                        Reporte_FichaDecadactilar_Provincia()
                    End If

                Case Type.Reporte.Registro.rptCertificadoReclusion_LM
                    Reporte_Constancia_Reclusion_LM()

                Case Type.Reporte.Registro.rptCertificadoLibertad_LM, Type.Reporte.Registro.rptCertificadoLibertad_LM_v2
                    Reporte_Certificado_Libertad_PLM()


                Case Type.Reporte.Registro.rptCertificadoReclusion_v3
                    Reporte_Constancia_Reclusion_Provincia()

                'Case Type.Reporte.Registro.rptCertificadoLibertad2
                '    Reporte_Certificado_Libertad2()

                Case Type.Reporte.Registro.rptCertificadoLibertad_v3
                    Reporte_Certificado_Libertad_Provincia()

                Case Type.Reporte.Registro.rptPapeletaExcarcelacion
                    Reporte_Papeleta_Excarcelacion()

                Case Type.Reporte.Registro.rptClasificacionFichaLegal
                    If Me._Filtro.GrupoFichaId = 1 Then
                        Reporte_Clasificacion_Ficha_Legal_v1() 'por ahora se usa el formato de V1
                    ElseIf Me._Filtro.GrupoFichaId = 2 Then
                        Reporte_Clasificacion_Ficha_Legal_v2()
                    Else
                        'para grupo 3 no aplica
                    End If
                Case Type.Reporte.Registro.rptClasificacionFichaSocial
                    If Me._Filtro.GrupoFichaId = 1 Then
                        Reporte_Clasificacion_Ficha_Social_v1()
                    ElseIf Me._Filtro.GrupoFichaId = 2 Then
                        Reporte_Clasificacion_Ficha_Social_v2()
                    Else
                        'para grupo 3 no aplica
                    End If
                Case Type.Reporte.Registro.rptClasificacionFichaPsicologica
                    If Me._Filtro.GrupoFichaId = 1 Then
                        Reporte_Clasificacion_Ficha_Psicologica_v1() 'por ahora se usa el formato de V1
                    ElseIf Me._Filtro.GrupoFichaId = 2 Then
                        Reporte_Clasificacion_Ficha_Psicologica_v2()
                    Else
                        'para grupo 3 no aplica
                    End If
                Case Type.Reporte.Registro.rptClasificacionFichaFinal
                    Select Case Me._Filtro.GrupoFichaId
                        Case 1
                            Reporte_Clasificacion_Ficha_Final_V1() 'por ahora se usa el formato de V1
                        Case 2
                            Reporte_Clasificacion_Ficha_Final_V2()
                        Case 3
                            Reporte_Clasificacion_Ficha_Final_V3()
                        Case 4, 10 ' aplica tambien para la directiva 2023, son similares al anterior
                            Reporte_Clasificacion_Ficha_Final_V4()
                    End Select

                Case Type.Reporte.Registro.rptClasificacionOficioConsolidado
                    CrystalReportViewer1.AllowedExportFormats = (ViewerExportFormats.PdfFormat Or ViewerExportFormats.WordFormat) 'solo pdf y word

                    ExportarPDFToolStripMenuItem.Visible = False
                    mnuExportarVarios.Visible = True

                    Reporte_Clasificacion_Oficio_Consolidado()

                    'Case Type.Reporte.Registro.rptFichaPenologica_v1
                    '    Reporte_Ficha_Penologica_v1()
                    'Case Type.Reporte.Registro.rptFichaPenologica_v2
                Case Type.Reporte.Registro.rptClasificacionFormato06
                    Reporte_Clasificacion_Formato06()

                Case Type.Reporte.Registro.rptListaInternoInimputable, Type.Reporte.Registro.rptListaInternoPosibleInimputable
                    Reporte_inimputables()

            End Select

        End Sub

        Private Sub Reporte_Clasificacion_Formato06()
            rpt = New ReportDocument

            Dim obv_rtf_legal As String = ""
            Dim obv_rtf_social As String = ""
            Dim obv_rtf_psico As String = ""
            Dim sit_jur_clasif As String = ""
            Dim fecha_clasif As String = ""

            Dim ind_legal As String = ""
            Dim var_legal As String = ""
            Dim ind_social As String = ""
            Dim var_social As String = ""
            Dim ind_psicologica As String = ""
            Dim var_psicologica As String = ""

            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)

            Dim ent = objEntCol.Ficha(0)

            Dim fichasCol = (New InternoFicha_BL()).ListarFichas_x_fichaFinal(Me._Filtro.InternoFichaId)
            Dim fichasColVariables = (New InternoFicha_BL()).ListarFichaConVariableIndicador_x_fichaFinal(Me._Filtro.InternoFichaId)

            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_formato07_ET_v1.rpt")

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            For Each o As Entity.Clasificacion.InternoClasificacion.InternoFicha In fichasCol
                If o.TipoFicha = enmTipoFicha.Legal Then
                    obv_rtf_legal = o.Observacion_02_rtf
                End If
                If o.TipoFicha = enmTipoFicha.Psicologica Then
                    obv_rtf_psico = o.Observacion_02_rtf
                End If
                If o.TipoFicha = enmTipoFicha.Social Then
                    obv_rtf_social = o.Observacion_02_rtf
                End If
                If o.TipoFicha = enmTipoFicha.Final Then
                    sit_jur_clasif = If(o.InternoSituacionJuridicaId = 1, "Procesado", "Sentenciado")
                    fecha_clasif = (New DateTime().FromFileTime(o.FechaClasificacion)).ToString()
                End If
            Next

            For Each o As Entity.Clasificacion.InternoClasificacion.InternoFicha In fichasColVariables
                If o.TipoFicha = enmTipoFicha.Legal Then
                    ind_legal = (ind_legal & "<b>&diams;</b> " & o.IndicadorNombre & ".<br>").Trim()
                    var_legal = (var_legal & "<b>&diams;</b> " & o.VariableNombre & ".<br>").Trim()
                End If
                If o.TipoFicha = enmTipoFicha.Social Then
                    ind_social = (ind_social & "&diams; " & o.IndicadorNombre & ".<br>").Trim()
                    var_social = (var_social & "&diams; " & o.VariableNombre & ".<br>").Trim()
                End If
                If o.TipoFicha = enmTipoFicha.Psicologica Then
                    ind_psicologica = (ind_psicologica & "&diams; " & o.IndicadorNombre & ".<br>").Trim()
                    var_psicologica = (var_psicologica & "&diams; " & o.VariableNombre & ".<br>").Trim()
                End If
            Next
            ind_legal = ind_legal.Substring(0, ind_legal.Length - 4)
            ind_social = ind_social.Substring(0, ind_social.Length - 4)
            ind_psicologica = ind_psicologica.Substring(0, ind_psicologica.Length - 4)


            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_delitos3_LM", "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")
            rpt.SetParameterValue("@id", -1, "crDelitos")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crDelitos")
            rpt.SetParameterValue("@mostrar_doc_anulado", 0, "crDelitos")
            rpt.SetParameterValue("@fk_ing_inp_id", -1, "crDelitos")
            rpt.SetParameterValue("@n_aut_amb", -1, "crDelitos")

            rpt.SetParameterValue("p_int_nombres", ent.ApellidoPaterno & " " & ent.ApellidoMaterno & ", " & ent.Nombres)
            rpt.SetParameterValue("p_int_edad", ent.Edad)
            rpt.SetParameterValue("p_int_grad_inst", ent.GradoInstruccion)
            rpt.SetParameterValue("p_int_ocupacion", ent.Ocupacion)
            rpt.SetParameterValue("p_int_num_ing", ent.NumeroIngreso)
            rpt.SetParameterValue("p_sit_jur_clasificacion", sit_jur_clasif)
            rpt.SetParameterValue("p_obvs_legal", obv_rtf_legal)
            rpt.SetParameterValue("p_obvs_psico", obv_rtf_psico)
            rpt.SetParameterValue("p_obvs_social", obv_rtf_social)
            rpt.SetParameterValue("p_regimen", "ESPECIAL")
            rpt.SetParameterValue("p_fecha_clasificacion", fecha_clasif)
            'rpt.SetParameterValue("p_indicador_legal", ind_legal.Replace("EN CASO DE INTERNOS TRASLADADOS:", "<b>EN CASO DE INTERNOS TRASLADADOS:</b>"))
            rpt.SetParameterValue("p_variable_legal", var_legal)
            'rpt.SetParameterValue("p_indicador_psico", ind_psicologica.Replace("EN CASO DE INTERNOS TRASLADADOS:", "<b>EN CASO DE INTERNOS TRASLADADOS:</b>"))
            rpt.SetParameterValue("p_variable_psico", var_psicologica)
            'rpt.SetParameterValue("p_indicador_social", ind_social.Replace("EN CASO DE INTERNOS TRASLADADOS:", "<b>EN CASO DE INTERNOS TRASLADADOS:</b>"))
            rpt.SetParameterValue("p_variable_social", var_social)

            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_Certificado_Libertad_Provincia()

            rpt = New ReportDocument

            Dim objEntCol As New Entity.Reporte.CertificadoLibertad.CertificadoCol

            If Me._TipoLicencia = enmTipoLicencia.PenalProvincia Then
                objEntCol = (New Bussines.Reporte.Registro).CertificadoLibertad_Provincia(Me._Filtro.InternoID, _Filtro.PenalProcedencia, _Filtro.Nota, Me._pRestriccionCol)
            End If

            If objEntCol.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("El interno no cuenta con ningún registro de Libertad")
                Exit Sub
            End If
            rpt.Load(Me.ReportePath & "rpt_CertificadoLibertad_v3.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")
            For Each obj As Entity.Reporte.CertificadoLibertad.Certificado In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & "_" & obj.CodigoRP & Now.Millisecond & "PC.tmp"

                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                End If


                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ep", obj.PenalNombre)
                rpt.SetParameterValue("p_nom_interno", obj.ApellidosyPreNombres)
                rpt.SetParameterValue("p_nomb_asoc", If(obj.NombresAsociados = "", "No registra nombres asociados", obj.NombresAsociados))
                rpt.SetParameterValue("@int_ing_id", obj.InternoIngresoID)

                'datos ingreso
                rpt.SetParameterValue("p_fech_ing", obj.FechaIngresoString)
                If Trim(obj.PenalProcedencia) = "" Then
                    rpt.SetParameterValue("p_pen_procedencia", "")
                Else
                    rpt.SetParameterValue("p_pen_procedencia", ", procedente del " & obj.PenalProcedencia)
                End If
                rpt.SetParameterValue("p_orden_de", If(obj.ExpedienteSalaJuzgado.Length = 0, "[NO INDICA]", obj.ExpedienteSalaJuzgado))
                rpt.SetParameterValue("p_expe_num", If(obj.ExpedienteNumero.Length = 0, "[NO INDICA]", obj.ExpedienteNumero))

                'datos libertad
                rpt.SetParameterValue("p_fec_egreso_string", obj.FechaEgresoString)
                If obj.LibertadSalaJuzgado = "" Then
                    rpt.SetParameterValue("p_juzgado_libertad", If(obj.LibertadSalaJuzgadoCargo.Length = 0, "[NO INDICA]", obj.LibertadSalaJuzgadoCargo))
                Else
                    rpt.SetParameterValue("p_juzgado_libertad", If(obj.LibertadSalaJuzgado.Length = 0, "[NO INDICA]", obj.LibertadSalaJuzgado))
                End If
                rpt.SetParameterValue("p_num_doc_libertad", If(obj.LibertadNumeroDocumento.Length = 0, "[NO INDICA]", obj.LibertadNumeroDocumento))
                If obj.LibertadSecretario = "" Then
                    rpt.SetParameterValue("p_secre_nom_libertad", "")
                Else
                    rpt.SetParameterValue("p_secre_nom_libertad", ", Secretario " & obj.LibertadSecretario)
                End If
                rpt.SetParameterValue("p_tipo_libertad", obj.LibertadTipo)
                Dim res As String = ""
                For Each rs As Entity.Reporte.CertificadoLibertad.Restriccion In obj.Restricciones
                    res = res & rs.Descripcion & "<br>"
                Next
                rpt.SetParameterValue("p_obvs", If(obj.Nota = "", "", If(res = "", "", "<br>") & "<br>" & obj.Nota & "<br>"))
                rpt.SetParameterValue("p_restricciones", res)
                rpt.SetParameterValue("p_exp_del_lib", If(obj.ExpedienteDelitosStringLibetad.Length = 0, "[NO INDICA]", obj.ExpedienteDelitosStringLibetad))
                rpt.SetParameterValue("p_str_fec_isp", If(obj.FechaISPString.Length = 0, "[NO INDICA]", obj.FechaISPString))
                rpt.SetParameterValue("p_fech_emi", Me._Filtro.FechaEmision)
                Exit For
            Next

            rpt.SetParameterValue("p_num_cert", Me._Filtro.DocumentoNumero)

            rpt.SetParameterValue("p_fecha", Legolas.LBusiness.Globall.DateTime.FechaServer)

            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", 0)
            rpt.SetParameterValue("@fec_fin", 0)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@strNomAsoc", "")

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Papeleta_Excarcelacion()
            Dim objBss As New Bussines.Reporte.Registro
            rpt = New ReportDocument

            Dim esPLM As Boolean = False
            Dim objEntCol As New Entity.Reporte.CertificadoLibertad.CertificadoCol

            If Me._TipoLicencia = enmTipoLicencia.PenalProvincia Then
                objEntCol = objBss.CertificadoLibertad_Provincia(Me._Filtro.InternoID, _Filtro.PenalProcedencia, _Filtro.Nota, Me._pRestriccionCol)
            End If

            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                objEntCol = objBss.CertificadoLibertad_LM(Me._Filtro.InternoID, Me._Filtro.PenalID, _Filtro.PenalProcedencia, _Filtro.Nota, Me._pRestriccionCol)
                esPLM = True
                'objEntCol.Certificado(0).FotoVersionAntigua = True
            End If

            If objEntCol.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("El interno no cuenta con ningún registro de Libertad")
                Exit Sub
            End If
            rpt.Load(Me.ReportePath & "rpt_PapeletaExcarcelacion.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")
            For Each obj As Entity.Reporte.CertificadoLibertad.Certificado In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & "_" & obj.CodigoRP & Now.Millisecond & "PC.tmp"

                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)

                    If esPLM = True Then
                        Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_LM_v2, strFotoPC)
                    End If

                End If

                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ep", obj.PenalNombre)
                rpt.SetParameterValue("p_nom_interno", obj.ApellidosyPreNombres)
                rpt.SetParameterValue("p_nomb_asoc", If(obj.NombresAsociados = "", "No registra nombres asociados", obj.NombresAsociados))
                rpt.SetParameterValue("@int_ing_id", obj.InternoIngresoID)

                'datos ingreso
                rpt.SetParameterValue("p_fech_ing", obj.FechaIngresoString)
                If Trim(obj.PenalProcedencia) = "" Then
                    rpt.SetParameterValue("p_pen_procedencia", "")
                Else
                    rpt.SetParameterValue("p_pen_procedencia", ", procedente del " & obj.PenalProcedencia)
                End If
                rpt.SetParameterValue("p_orden_de", If(obj.ExpedienteSalaJuzgado.Length = 0, "[NO INDICA]", obj.ExpedienteSalaJuzgado))
                rpt.SetParameterValue("p_expe_num", If(obj.ExpedienteNumero.Length = 0, "[NO INDICA]", obj.ExpedienteNumero))

                'datos libertad
                rpt.SetParameterValue("p_fec_egreso_string", obj.FechaEgresoString)
                If obj.LibertadSalaJuzgado = "" Then
                    rpt.SetParameterValue("p_juzgado_libertad", If(obj.LibertadSalaJuzgadoCargo.Length = 0, "[NO INDICA]", obj.LibertadSalaJuzgadoCargo))
                Else
                    rpt.SetParameterValue("p_juzgado_libertad", If(obj.LibertadSalaJuzgado.Length = 0, "[NO INDICA]", obj.LibertadSalaJuzgado))
                End If
                rpt.SetParameterValue("p_num_doc_libertad", If(obj.LibertadNumeroDocumento.Length = 0, "[NO INDICA]", obj.LibertadNumeroDocumento))
                If obj.LibertadSecretario = "" Then
                    rpt.SetParameterValue("p_secre_nom_libertad", "")
                Else
                    rpt.SetParameterValue("p_secre_nom_libertad", ", Secretario " & obj.LibertadSecretario)
                End If

                rpt.SetParameterValue("p_tipo_libertad", obj.LibertadTipo)
                Dim res As String = ""
                rpt.SetParameterValue("p_obvs", If(obj.Nota = "", "", If(res = "", "", "<br>") & "<br>" & obj.Nota & "<br>"))
                rpt.SetParameterValue("p_restricciones", obj.Ciudad & ", ")
                rpt.SetParameterValue("p_exp_del_lib", If(obj.ExpedienteDelitosStringLibetad.Length = 0, "[NO INDICA]", obj.ExpedienteDelitosStringLibetad))
                rpt.SetParameterValue("p_str_fec_isp", If(obj.FechaIngresoString.Length = 0, "[NO INDICA]", obj.FechaIngresoString))
                rpt.SetParameterValue("p_fech_emi", CDate(Me._Filtro.FechaEmision).Date.ToLongDateString)
                Exit For
            Next

            rpt.SetParameterValue("p_num_cert", Me._Filtro.DocumentoNumero)

            rpt.SetParameterValue("p_fecha", Legolas.LBusiness.Globall.DateTime.FechaServer)

            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", 0)
            rpt.SetParameterValue("@fec_fin", 0)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@strNomAsoc", "")

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_FichaDecadactilar_LM(ByRef strMensajeOut As String)

            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Registro).FichaIdentificacion_PLM(Me._Filtro.InternoID)

            rpt.Load(Me.ReportePath & "rpt_ficha_decadactilar_LM.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(
                      Legolas.Configuration.Data.CNServer,
                      Legolas.Configuration.Data.CNDataBase,
                      Legolas.Configuration.Data.CNUser,
                      Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.FichaIdentificacion.Ficha In objEntCol

                '-----huella digital--------------------------------------------------------------
                Try

                    Dim entIntHuell As New Entity.Biometria.InternoHuella With {
                            .InternoId = Me._Filtro.InternoID
                        }

                    Dim entIntHuellCol = (New Bussines.Biometria.InternoHuella).Listar(entIntHuell, "")
                    If entIntHuellCol.Count > 0 Then 'significa que ya cuenta con huellas por lo tanto no es posible realizar captura decadactilar
                        entIntHuell = entIntHuellCol.InternoHuella(0)
                    End If

                    strPathIzq_men = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_men.bmp"
                    strPathIzq_anu = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_anu.bmp"
                    strPathIzq_med = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_med.bmp"
                    strPathIzq_ind = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_ind.bmp"
                    strPathIzq_pul = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_pul.bmp"
                    strPathDer_men = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_men.bmp"
                    strPathDer_anu = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_anu.bmp"
                    strPathDer_med = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_med.bmp"
                    strPathDer_ind = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_ind.bmp"
                    strPathDer_pul = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_pul.bmp"

                    Dim tbl As New DataTable("Ent_HuellasPersona")

                    tbl.Columns.Add("men_izq_img", GetType(Byte()))
                    tbl.Columns.Add("anu_izq_img", GetType(Byte()))
                    tbl.Columns.Add("med_izq_img", GetType(Byte()))
                    tbl.Columns.Add("ind_izq_img", GetType(Byte()))
                    tbl.Columns.Add("pul_izq_img", GetType(Byte()))
                    tbl.Columns.Add("men_der_img", GetType(Byte()))
                    tbl.Columns.Add("anu_der_img", GetType(Byte()))
                    tbl.Columns.Add("med_der_img", GetType(Byte()))
                    tbl.Columns.Add("ind_der_img", GetType(Byte()))
                    tbl.Columns.Add("pul_der_img", GetType(Byte()))

                    Dim row As DataRow
                    row = tbl.NewRow

                    row.Item("men_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMenIzqId, strPathIzq_men)
                    row.Item("anu_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigAnuIzqId, strPathIzq_anu)
                    row.Item("med_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMedIzqId, strPathIzq_med)
                    row.Item("ind_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigIndIzqId, strPathIzq_ind)
                    row.Item("pul_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigPulIzqId, strPathIzq_pul)
                    row.Item("men_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMenDerId, strPathDer_men)
                    row.Item("anu_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigAnuDerId, strPathDer_anu)
                    row.Item("med_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMedDerId, strPathDer_med)
                    row.Item("ind_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigIndDerId, strPathDer_ind)
                    row.Item("pul_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigPulDerId, strPathDer_pul)

                    tbl.Rows.Add(row)

                    rpt.Subreports.Item("crHuellas").SetDataSource(tbl)
                Catch ex As Exception
                    strMensajeOut = ex.Message
                End Try

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                Else
                    If obj.FotoVersionAntigua = True Then
                        Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                        Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                    Else
                        Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                        Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                    End If
                End If

                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                '/***********************************************/

                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))

                '/*mostrar las formulas decadactilar*/
                Dim decaDer As String = ""
                Dim decaIzq As String = ""
                If obj.InfoDecadactilarInt.Trim.Length = 0 Then
                    decaDer = "NR"
                    decaIzq = "NR"
                Else
                    If obj.InfoDecadactilarInt.Trim.Contains("|") = True Then
                        Dim d() As String = obj.InfoDecadactilarInt.Trim.Split("|")
                        decaIzq = d(0)
                        decaDer = d(1)
                    Else
                        decaIzq = Legolas.Components.Cadena.Left(obj.InfoDecadactilarInt, 5)
                        decaDer = Legolas.Components.Cadena.Right(obj.InfoDecadactilarInt, 5)
                    End If
                End If

                rpt.SetParameterValue("p_form_deca_der", decaDer.ToUpper)
                rpt.SetParameterValue("p_form_deca_izq", decaIzq.ToUpper)
                '/***********************************************/

                rpt.SetParameterValue("p_alias", If(Trim(obj.AliasNombres) = "", "NR", obj.AliasNombres.ToUpper))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)

                'numero de documento
                Dim strTipoyNumDoc As String = ""
                If obj.TipoDocumentoyNumero.Trim = "" Then
                    strTipoyNumDoc = "NR"
                Else
                    strTipoyNumDoc = obj.TipoDocumentoyNumero
                End If
                rpt.SetParameterValue("p_doc_identidad", strTipoyNumDoc)
                '/**********************************************/
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", If(obj.SexoNombre = "M", "MASCULINO", "FEMENINO")))
                rpt.SetParameterValue("p_edad", obj.Edad)

                'homonimia
                Dim strHononimo As String = ""
                If obj.Hononimo.Trim = "" Or obj.Hononimo.Trim = "???" Then
                    strHononimo = "NR"
                Else
                    If obj.Hononimo = True Or obj.Hononimo.ToUpper = "SI" Then
                        strHononimo = "SI"
                    Else
                        strHononimo = "NO"
                    End If
                End If
                rpt.SetParameterValue("p_homonimo", strHononimo)
                '/**********************************************/
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", obj.ApellidoPaterno & " " & obj.ApellidoMaterno.ToUpper)
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))

                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_bandas", If(obj.Bandas = "", "NR", obj.Bandas.ToUpper))

            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_delitos3_LM", "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            Dim penLicNom As String = ""
            Dim regNom As String = ""
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta
                    regNom = "Región: LIMA"
                    penLicNom = "Establecimiento: E.T.P.L"
                Case enmTipoLicencia.RegionLimaMetropolitana
                    penLicNom = "OFICINA REGIONAL DE LIMA"
                Case enmTipoLicencia.PenalLimaMetropolitana
                    regNom = "Región: LIMA"
                    penLicNom = "Penal: " & Me._Filtro.PenalNombre.ToUpper
                Case Else
                    regNom = "OFICINA REGIONAL DE LIMA"
            End Select

            rpt.SetParameterValue("p_lic_region_nom", regNom)
            rpt.SetParameterValue("p_lic_pen_nom", penLicNom)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_FichaDecadactilar_Provincia()

            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Registro).FichaIdentificacion_Provincia(Me._Filtro.InternoID)

            rpt.Load(Me.ReportePath & "rpt_ficha_decadactilar_v03.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(
                      Legolas.Configuration.Data.CNServer,
                      Legolas.Configuration.Data.CNDataBase,
                      Legolas.Configuration.Data.CNUser,
                      Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.FichaIdentificacion.Ficha In objEntCol
                '-----huella digital--------------------------------------------------------------
                Try
                    Dim entIntHuell As New Entity.Biometria.InternoHuella With {
                            .InternoId = Me._Filtro.InternoID
                        }

                    Dim entIntHuellCol = (New Bussines.Biometria.InternoHuella).Listar(entIntHuell, "")
                    If entIntHuellCol.Count > 0 Then 'significa que ya cuenta con huellas por lo tanto no es posible realizar captura decadactilar
                        entIntHuell = entIntHuellCol.InternoHuella(0)
                    End If

                    strPathIzq_men = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_men.bmp"
                    strPathIzq_anu = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_anu.bmp"
                    strPathIzq_med = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_med.bmp"
                    strPathIzq_ind = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_ind.bmp"
                    strPathIzq_pul = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_pul.bmp"
                    strPathDer_men = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_men.bmp"
                    strPathDer_anu = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_anu.bmp"
                    strPathDer_med = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_med.bmp"
                    strPathDer_ind = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_ind.bmp"
                    strPathDer_pul = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_pul.bmp"

                    Dim tbl As New DataTable("Ent_HuellasPersona")

                    tbl.Columns.Add("men_izq_img", GetType(Byte()))
                    tbl.Columns.Add("anu_izq_img", GetType(Byte()))
                    tbl.Columns.Add("med_izq_img", GetType(Byte()))
                    tbl.Columns.Add("ind_izq_img", GetType(Byte()))
                    tbl.Columns.Add("pul_izq_img", GetType(Byte()))
                    tbl.Columns.Add("men_der_img", GetType(Byte()))
                    tbl.Columns.Add("anu_der_img", GetType(Byte()))
                    tbl.Columns.Add("med_der_img", GetType(Byte()))
                    tbl.Columns.Add("ind_der_img", GetType(Byte()))
                    tbl.Columns.Add("pul_der_img", GetType(Byte()))

                    Dim row As DataRow
                    row = tbl.NewRow

                    row.Item("men_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMenIzqId, strPathIzq_men)
                    row.Item("anu_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigAnuIzqId, strPathIzq_anu)
                    row.Item("med_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMedIzqId, strPathIzq_med)
                    row.Item("ind_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigIndIzqId, strPathIzq_ind)
                    row.Item("pul_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigPulIzqId, strPathIzq_pul)
                    row.Item("men_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMenDerId, strPathDer_men)
                    row.Item("anu_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigAnuDerId, strPathDer_anu)
                    row.Item("med_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMedDerId, strPathDer_med)
                    row.Item("ind_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigIndDerId, strPathDer_ind)
                    row.Item("pul_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigPulDerId, strPathDer_pul)

                    tbl.Rows.Add(row)

                    rpt.Subreports.Item("crHuellas").SetDataSource(tbl)
                Catch ex As Exception

                End Try

                '/*listar la fotografia*/
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

                'identificar la licencia de la bd
                Dim intIDTipoLocal = (New Bussines.Sistema.Instalacion).ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
                Dim ObjBssArchDigital As New Bussines.Globall.ArchivoDigital

                Dim objFotoTempPF As Byte()
                Dim objFotoTempPI As Byte()

                Select Case intIDTipoLocal
                    Case 2 'region
                        objFotoTempPF = ObjBssArchDigital.getArchivoDigitalByte_Region(obj.FotoPerfilCentralId, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "")
                        objFotoTempPI = ObjBssArchDigital.getArchivoDigitalByte_Region(obj.FotoPerfilIzquierdoId, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "")

                        Legolas.Components.Archivo.FileCreateByte(objFotoTempPF, strFotoPC)
                        Legolas.Components.Archivo.FileCreateByte(objFotoTempPI, strFotoPerfilDerecho)

                    Case Else
                        'sede, penal 

                        If obj.FotoVersionAntigua = True Then
                            Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                            Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                        Else
                            Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                            Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                        End If

                End Select

                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                '/***********************************************/

                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))

                '/*mostrar las formulas decadactilar*/
                Dim decaDer As String = ""
                Dim decaIzq As String = ""
                If obj.InfoDecadactilarInt.Trim.Length = 0 Then
                    decaDer = "NR"
                    decaIzq = "NR"
                Else
                    If obj.InfoDecadactilarInt.Trim.Contains("|") = True Then
                        Dim d() As String = obj.InfoDecadactilarInt.Trim.Split("|")
                        decaDer = d(0)
                        decaIzq = d(1)
                    Else
                        decaIzq = Legolas.Components.Cadena.Left(obj.InfoDecadactilarInt, 5)
                        decaDer = Legolas.Components.Cadena.Right(obj.InfoDecadactilarInt, 5)
                    End If
                End If

                rpt.SetParameterValue("p_form_deca_der", decaDer.ToUpper)
                rpt.SetParameterValue("p_form_deca_izq", decaIzq.ToUpper)
                '/***********************************************/

                rpt.SetParameterValue("p_alias", If(Trim(obj.AliasNombres) = "", "NR", obj.AliasNombres.ToUpper))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)

                'numero de documento
                Dim strTipoyNumDoc As String = ""
                If obj.TipoDocumentoyNumero.Trim = "" Then
                    strTipoyNumDoc = "NR"
                Else
                    strTipoyNumDoc = obj.TipoDocumentoyNumero
                End If
                rpt.SetParameterValue("p_doc_identidad", strTipoyNumDoc)
                '/**********************************************/
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", If(obj.SexoNombre = "M", "MASCULINO", "FEMENINO")))
                rpt.SetParameterValue("p_edad", obj.Edad)

                'homonimia
                Dim strHononimo As String = ""
                If obj.Hononimo.Trim = "" Or obj.Hononimo.Trim = "???" Then
                    strHononimo = "NR"
                Else
                    If obj.Hononimo = True Or obj.Hononimo.ToUpper = "SI" Then
                        strHononimo = "SI"
                    Else
                        strHononimo = "NO"
                    End If
                End If
                rpt.SetParameterValue("p_homonimo", strHononimo)
                '/**********************************************/
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", obj.ApellidoPaterno & " " & obj.ApellidoMaterno.ToUpper)
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_bandas", If(obj.Bandas = "", "NR", obj.Bandas.ToUpper))

            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_delitos3", "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_inimputables()
            Dim titulo As String = ""
            Dim reporte As String = ""
            Dim motivoInimputable As Integer = -1
            Dim nameProcedure As String = ""
            If _TipoReporte = 70 Then 'Peruanos
                motivoInimputable = EnumMovMotivo.Inimputable
                titulo = "RELACIÓN DE INTERNOS DECLARADOS JUDICIALMENTE INIMPUTABLES"
                reporte = "rpt_ficha_inimputables"
            Else
                motivoInimputable = EnumMovMotivo.PosibleInimputable
                titulo = "RELACIÓN DE INTERNOS QUE SE ENCUENTRAN CON MEDIDA DE INTERNACIÓN PREVENTIVA (POSIBLE INIMPUTABLE)"
                reporte = "rpt_ficha_pos_inimputables"
            End If
            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or
                 Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                nameProcedure = "lst_rpt_inmp_plm"
            Else
                nameProcedure = "lst_rpt_inmp_prov"
            End If

            rpt = New ReportDocument
            rpt.Load(Me.ReportePath & "\Inimputables\" & reporte & ".rpt")

            rpt.DataSourceConnections(0).SetConnection(
                Legolas.Configuration.Data.CNServer,
                Legolas.Configuration.Data.CNDataBase,
                Legolas.Configuration.Data.CNUser,
                Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crResInimputable").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.SetParameterValue("@accion", "lst", "crResInimputable")
            rpt.SetParameterValue("@opcion", nameProcedure, "crResInimputable")
            rpt.SetParameterValue("@_RegId", Me._Filtro.RegionID, "crResInimputable")
            rpt.SetParameterValue("@_Penid", Me._Filtro.PenalID, "crResInimputable")
            rpt.SetParameterValue("@pk_inmp_id", -1, "crResInimputable")
            rpt.SetParameterValue("@int_id", -1, "crResInimputable")
            rpt.SetParameterValue("@int_ing_id", -1, "crResInimputable")
            rpt.SetParameterValue("@fk_ing_inp_id", -1, "crResInimputable")
            rpt.SetParameterValue("@int_exp_id", -1, "crResInimputable")
            rpt.SetParameterValue("@doc_jud_id", -1, "crResInimputable")
            rpt.SetParameterValue("@doc_jud_num", "", "crResInimputable")
            rpt.SetParameterValue("@int_exp_num", "", "crResInimputable")
            rpt.SetParameterValue("@inmp_mot_id", motivoInimputable, "crResInimputable")
            rpt.SetParameterValue("@inmp_est_ment_id", -1, "crResInimputable")
            rpt.SetParameterValue("@inmp_est_int_id", -1, "crResInimputable")
            rpt.SetParameterValue("@inmp_est_id", -1, "crResInimputable")
            rpt.SetParameterValue("@_sed_flg_trf", 0, "crResInimputable")
            rpt.SetParameterValue("@_usuario", -1, "crResInimputable")
            rpt.SetParameterValue("@_fecha", 0, "crResInimputable")

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", nameProcedure)
            rpt.SetParameterValue("@_RegId", Me._Filtro.RegionID)
            rpt.SetParameterValue("@_Penid", Me._Filtro.PenalID)
            rpt.SetParameterValue("@pk_inmp_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@doc_jud_id", -1)
            rpt.SetParameterValue("@doc_jud_num", "")
            rpt.SetParameterValue("@int_exp_num", "")
            rpt.SetParameterValue("@inmp_mot_id", motivoInimputable)
            rpt.SetParameterValue("@inmp_est_ment_id", -1)
            rpt.SetParameterValue("@inmp_est_int_id", -1)
            rpt.SetParameterValue("@inmp_est_id", -1)
            rpt.SetParameterValue("@_sed_flg_trf", 0)
            rpt.SetParameterValue("@_usuario", -1)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("p_region_nom", UCase(Me._Filtro.RegionNombre))
            rpt.SetParameterValue("p_ep", UCase(Me._Filtro.PenalNombre))
            rpt.SetParameterValue("p_titulo", UCase(titulo))

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            CrystalReportViewer1.ReportSource = rpt

        End Sub
#Region "Clasificacion" 'mover a directorio clasificacion
        Private Sub Reporte_Clasificacion_Ficha_Legal_v1()

            rpt = New ReportDocument


            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing

            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)
            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_ficha_legal_v0.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt.Trim = "|" Or obj.InfoDecadactilarInt.Trim = "", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))
                rpt.SetParameterValue("p_ap_pat_1", If(obj.ApellidoPaterno.Length >= 2, obj.ApellidoPaterno.ToUpper.Substring(0, 1), ""))
                rpt.SetParameterValue("p_ap_pat_2", If(obj.ApellidoPaterno.Length >= 2, obj.ApellidoPaterno.ToUpper.Substring(1, 1), ""))
                rpt.SetParameterValue("p_ap_mat_1", If(obj.ApellidoMaterno.Length >= 2, obj.ApellidoMaterno.ToUpper.Substring(0, 1), ""))
                rpt.SetParameterValue("p_ap_mat_2", If(obj.ApellidoMaterno.Length >= 2, obj.ApellidoMaterno.ToUpper.Substring(1, 1), ""))


                '-----------------------
                ent = (New InternoFicha_BL).Listar_V2(Me._Filtro.InternoFichaId)

                rpt.SetParameterValue("p_fec_clasificacion", ent.FechaClasificacionDate)
                rpt.SetParameterValue("p_obs_clasificacion", ent.Observacion)
                rpt.SetParameterValue("p_cat_clasificacion", ent.CategoriaFichaNombre)


            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            If ent.NumeroClasificacion > 0 Then
                rpt.SetParameterValue("@opcion", "lst_exp_x_ficha_clas_final", "crDelitos")
                rpt.SetParameterValue("@id", ent.FichaFinalId, "crDelitos") 'enviar el id de la ficha final con el que está asociado
                rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.InternoIngresoInpeID, "crDelitos")
            Else
                rpt.SetParameterValue("@opcion", "lst_delitos3_LM", "crDelitos")
                rpt.SetParameterValue("@id", -1, "crDelitos")
                rpt.SetParameterValue("@fk_ing_inp_id", -1, "crDelitos")
            End If


            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crDelitos")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crDelitos")
            rpt.SetParameterValue("@n_aut_amb", -1, "crDelitos")

            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_fich_clasificacion", "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_id", -1, "crResultado")
            rpt.SetParameterValue("@int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_exp_id", -1, "crResultado")
            rpt.SetParameterValue("@int_sen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_del_id", -1, "crResultado")
            rpt.SetParameterValue("@nac_id", -1, "crResultado")
            rpt.SetParameterValue("@cuadro", -1, "crResultado")
            rpt.SetParameterValue("@fec_ini", 0, "crResultado")
            rpt.SetParameterValue("@fec_fin", 0, "crResultado")
            rpt.SetParameterValue("@_fecha", 0, "crResultado")
            rpt.SetParameterValue("@reg_id", -1, "crResultado")
            rpt.SetParameterValue("@tip_band_id", -1, "crResultado")
            rpt.SetParameterValue("@ban_id", -1, "crResultado")
            rpt.SetParameterValue("@int_rnc_id", -1, "crResultado")
            rpt.SetParameterValue("@id", Me._Filtro.InternoFichaId, "crResultado")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crResultado")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crResultado")
            rpt.SetParameterValue("@fk_ing_inp_id", -1, "crResultado")
            rpt.SetParameterValue("@n_aut_amb", -1, "crResultado")

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", -1)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)


            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Clasificacion_Ficha_Legal_v2()

            rpt = New ReportDocument

            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing

            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)
            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_ficha_legal_v1.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt.Trim = "|" Or obj.InfoDecadactilarInt.Trim = "", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))


                ent = (New InternoFicha_BL).Listar_V2(Me._Filtro.InternoFichaId)

                rpt.SetParameterValue("p_fec_clasificacion", ent.FechaClasificacionDate)
                rpt.SetParameterValue("p_obs_clasificacion", ent.Observacion)
                rpt.SetParameterValue("p_cat_clasificacion", ent.CategoriaFichaNombre)


            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            If ent.NumeroClasificacion > 0 Then
                rpt.SetParameterValue("@opcion", "lst_exp_x_ficha_clas_final", "crDelitos")
                rpt.SetParameterValue("@id", ent.FichaFinalId, "crDelitos") 'en caso sea otro tipo de ficha enviar el id de la ficha final con el que está asociado
                rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.InternoIngresoInpeID, "crDelitos")
            Else
                rpt.SetParameterValue("@opcion", "lst_delitos3_LM", "crDelitos")
                rpt.SetParameterValue("@id", -1, "crDelitos")
                rpt.SetParameterValue("@fk_ing_inp_id", -1, "crDelitos")
            End If


            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crDelitos")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crDelitos")
            rpt.SetParameterValue("@n_aut_amb", -1, "crDelitos")


            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_fich_clasificacion", "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", -1, "crResultado")
            rpt.SetParameterValue("@int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@int_exp_id", -1, "crResultado")
            rpt.SetParameterValue("@int_sen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_del_id", -1, "crResultado")
            rpt.SetParameterValue("@nac_id", -1, "crResultado")
            rpt.SetParameterValue("@cuadro", -1, "crResultado")
            rpt.SetParameterValue("@fec_ini", 0, "crResultado")
            rpt.SetParameterValue("@fec_fin", 0, "crResultado")
            rpt.SetParameterValue("@_fecha", 0, "crResultado")
            rpt.SetParameterValue("@reg_id", -1, "crResultado")
            rpt.SetParameterValue("@tip_band_id", -1, "crResultado")
            rpt.SetParameterValue("@ban_id", -1, "crResultado")
            rpt.SetParameterValue("@int_rnc_id", -1, "crResultado")
            rpt.SetParameterValue("@id", Me._Filtro.InternoFichaId, "crResultado")

            'crResultado

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_Clasificacion_Ficha_Social_v1()

            rpt = New ReportDocument

            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing

            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)
            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_ficha_social_v0.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt.Trim = "|" Or obj.InfoDecadactilarInt.Trim = "", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_ap_pat_1", If(obj.ApellidoPaterno.Length >= 2, obj.ApellidoPaterno.ToUpper.Substring(0, 1), ""))
                rpt.SetParameterValue("p_ap_pat_2", If(obj.ApellidoPaterno.Length >= 2, obj.ApellidoPaterno.ToUpper.Substring(1, 1), ""))
                rpt.SetParameterValue("p_ap_mat_1", If(obj.ApellidoMaterno.Length >= 2, obj.ApellidoMaterno.ToUpper.Substring(0, 1), ""))
                rpt.SetParameterValue("p_ap_mat_2", If(obj.ApellidoMaterno.Length >= 2, obj.ApellidoMaterno.ToUpper.Substring(1, 1), ""))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))


                ent = (New InternoFicha_BL).Listar_V2(Me._Filtro.InternoFichaId)

                rpt.SetParameterValue("p_fec_clasificacion", ent.FechaClasificacionDate)
                rpt.SetParameterValue("p_obs_clasificacion", ent.Observacion)
                rpt.SetParameterValue("p_cat_clasificacion", ent.CategoriaFichaNombre)


            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            If ent.NumeroClasificacion > 0 Then
                rpt.SetParameterValue("@opcion", "lst_exp_x_ficha_clas_final", "crDelitos")
                rpt.SetParameterValue("@id", ent.FichaFinalId, "crDelitos") 'enviar el id de la ficha final con el que está asociado
                rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.InternoIngresoInpeID, "crDelitos")
            Else
                rpt.SetParameterValue("@opcion", "lst_delitos3_LM", "crDelitos")
                rpt.SetParameterValue("@id", -1, "crDelitos")
                rpt.SetParameterValue("@fk_ing_inp_id", -1, "crDelitos")
            End If


            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crDelitos")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crDelitos")
            rpt.SetParameterValue("@n_aut_amb", -1, "crDelitos")

            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_fich_clasificacion", "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_id", -1, "crResultado")
            rpt.SetParameterValue("@int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_exp_id", -1, "crResultado")
            rpt.SetParameterValue("@int_sen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_del_id", -1, "crResultado")
            rpt.SetParameterValue("@nac_id", -1, "crResultado")
            rpt.SetParameterValue("@cuadro", -1, "crResultado")
            rpt.SetParameterValue("@fec_ini", 0, "crResultado")
            rpt.SetParameterValue("@fec_fin", 0, "crResultado")
            rpt.SetParameterValue("@_fecha", 0, "crResultado")
            rpt.SetParameterValue("@reg_id", -1, "crResultado")
            rpt.SetParameterValue("@tip_band_id", -1, "crResultado")
            rpt.SetParameterValue("@ban_id", -1, "crResultado")
            rpt.SetParameterValue("@int_rnc_id", -1, "crResultado")
            rpt.SetParameterValue("@id", Me._Filtro.InternoFichaId, "crResultado")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crResultado")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crResultado")
            rpt.SetParameterValue("@fk_ing_inp_id", -1, "crResultado")
            rpt.SetParameterValue("@n_aut_amb", -1, "crResultado")

            'crResultado

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", -1)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)

            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)

            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Clasificacion_Ficha_Social_v2()

            rpt = New ReportDocument

            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing

            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)
            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_ficha_social_v1.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt.Trim = "|" Or obj.InfoDecadactilarInt.Trim = "", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))

                ent = (New InternoFicha_BL).Listar_V2(Me._Filtro.InternoFichaId)

                rpt.SetParameterValue("p_fec_clasificacion", ent.FechaClasificacionDate)
                rpt.SetParameterValue("p_obs_clasificacion", ent.Observacion)
                rpt.SetParameterValue("p_cat_clasificacion", ent.CategoriaFichaNombre)


            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            If ent.NumeroClasificacion > 0 Then
                rpt.SetParameterValue("@opcion", "lst_exp_x_ficha_clas_final", "crDelitos")
                rpt.SetParameterValue("@id", ent.FichaFinalId, "crDelitos") 'enviar el id de la ficha final con el que está asociado
                rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.InternoIngresoInpeID, "crDelitos")
            Else
                rpt.SetParameterValue("@opcion", "lst_delitos3_LM", "crDelitos")
                rpt.SetParameterValue("@id", -1, "crDelitos")
                rpt.SetParameterValue("@fk_ing_inp_id", -1, "crDelitos")
            End If


            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crDelitos")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crDelitos")
            rpt.SetParameterValue("@n_aut_amb", -1, "crDelitos")

            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_fich_clasificacion", "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_id", -1, "crResultado")
            rpt.SetParameterValue("@int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_exp_id", -1, "crResultado")
            rpt.SetParameterValue("@int_sen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_del_id", -1, "crResultado")
            rpt.SetParameterValue("@nac_id", -1, "crResultado")
            rpt.SetParameterValue("@cuadro", -1, "crResultado")
            rpt.SetParameterValue("@fec_ini", 0, "crResultado")
            rpt.SetParameterValue("@fec_fin", 0, "crResultado")
            rpt.SetParameterValue("@_fecha", 0, "crResultado")
            rpt.SetParameterValue("@reg_id", -1, "crResultado")
            rpt.SetParameterValue("@tip_band_id", -1, "crResultado")
            rpt.SetParameterValue("@ban_id", -1, "crResultado")
            rpt.SetParameterValue("@int_rnc_id", -1, "crResultado")
            rpt.SetParameterValue("@id", Me._Filtro.InternoFichaId, "crResultado")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crResultado")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crResultado")
            rpt.SetParameterValue("@fk_ing_inp_id", -1, "crResultado")
            rpt.SetParameterValue("@n_aut_amb", -1, "crResultado")
            'crResultado

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)


            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Clasificacion_Ficha_Psicologica_v1()

            rpt = New ReportDocument

            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing

            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)
            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_ficha_psicologica_v0.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt.Trim = "|" Or obj.InfoDecadactilarInt.Trim = "", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))
                rpt.SetParameterValue("p_ap_pat_1", If(obj.ApellidoPaterno.Length >= 2, obj.ApellidoPaterno.ToUpper.Substring(0, 1), ""))
                rpt.SetParameterValue("p_ap_pat_2", If(obj.ApellidoPaterno.Length >= 2, obj.ApellidoPaterno.ToUpper.Substring(1, 1), ""))
                rpt.SetParameterValue("p_ap_mat_1", If(obj.ApellidoMaterno.Length >= 2, obj.ApellidoMaterno.ToUpper.Substring(0, 1), ""))
                rpt.SetParameterValue("p_ap_mat_2", If(obj.ApellidoMaterno.Length >= 2, obj.ApellidoMaterno.ToUpper.Substring(1, 1), ""))

                ent = (New InternoFicha_BL).Listar_V2(Me._Filtro.InternoFichaId)

                rpt.SetParameterValue("p_fec_clasificacion", ent.FechaClasificacionDate)
                rpt.SetParameterValue("p_obs_clasificacion", ent.Observacion)
                rpt.SetParameterValue("p_cat_clasificacion", ent.CategoriaFichaNombre)


            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            If ent.NumeroClasificacion > 0 Then
                rpt.SetParameterValue("@opcion", "lst_exp_x_ficha_clas_final", "crDelitos")
                rpt.SetParameterValue("@id", ent.FichaFinalId, "crDelitos") 'enviar el id de la ficha final con el que está asociado
                rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.InternoIngresoInpeID, "crDelitos")
            Else
                rpt.SetParameterValue("@opcion", "lst_delitos3_LM", "crDelitos")
                rpt.SetParameterValue("@id", -1, "crDelitos")
                rpt.SetParameterValue("@fk_ing_inp_id", -1, "crDelitos")
            End If


            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crDelitos")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crDelitos")
            rpt.SetParameterValue("@n_aut_amb", -1, "crDelitos")

            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_fich_clasificacion", "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_id", -1, "crResultado")
            rpt.SetParameterValue("@int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_exp_id", -1, "crResultado")
            rpt.SetParameterValue("@int_sen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_del_id", -1, "crResultado")
            rpt.SetParameterValue("@nac_id", -1, "crResultado")
            rpt.SetParameterValue("@cuadro", -1, "crResultado")
            rpt.SetParameterValue("@fec_ini", 0, "crResultado")
            rpt.SetParameterValue("@fec_fin", 0, "crResultado")
            rpt.SetParameterValue("@_fecha", 0, "crResultado")
            rpt.SetParameterValue("@reg_id", -1, "crResultado")
            rpt.SetParameterValue("@tip_band_id", -1, "crResultado")
            rpt.SetParameterValue("@ban_id", -1, "crResultado")
            rpt.SetParameterValue("@int_rnc_id", -1, "crResultado")
            rpt.SetParameterValue("@id", Me._Filtro.InternoFichaId, "crResultado")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crResultado")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crResultado")
            rpt.SetParameterValue("@fk_ing_inp_id", -1, "crResultado")
            rpt.SetParameterValue("@n_aut_amb", -1, "crResultado")

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", -1)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)


            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt


        End Sub

        Private Sub Reporte_Clasificacion_Ficha_Psicologica_v2()

            rpt = New ReportDocument

            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing

            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)
            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_ficha_psicologica_v1.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "" Or obj.InfoDecadactilarInt = "|", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))

                ent = (New InternoFicha_BL).Listar_V2(Me._Filtro.InternoFichaId)

                rpt.SetParameterValue("p_fec_clasificacion", ent.FechaClasificacionDate)
                rpt.SetParameterValue("p_obs_clasificacion", ent.Observacion)
                rpt.SetParameterValue("p_cat_clasificacion", ent.CategoriaFichaNombre)

            Next obj
            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            If ent.NumeroClasificacion > 0 Then
                rpt.SetParameterValue("@opcion", "lst_exp_x_ficha_clas_final", "crDelitos")
                rpt.SetParameterValue("@id", ent.FichaFinalId, "crDelitos") 'enviar el id de la ficha final con el que está asociado
                rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.InternoIngresoInpeID, "crDelitos")
            Else
                rpt.SetParameterValue("@opcion", "lst_delitos3_LM", "crDelitos")
                rpt.SetParameterValue("@id", -1, "crDelitos")
                rpt.SetParameterValue("@fk_ing_inp_id", -1, "crDelitos")
            End If

            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crDelitos")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crDelitos")
            rpt.SetParameterValue("@n_aut_amb", -1, "crDelitos")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crDelitos")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crDelitos")
            rpt.SetParameterValue("@n_aut_amb", -1, "crDelitos")

            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_fich_clasificacion", "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_id", -1, "crResultado")
            rpt.SetParameterValue("@int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_exp_id", -1, "crResultado")
            rpt.SetParameterValue("@int_sen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_del_id", -1, "crResultado")
            rpt.SetParameterValue("@nac_id", -1, "crResultado")
            rpt.SetParameterValue("@cuadro", -1, "crResultado")
            rpt.SetParameterValue("@fec_ini", 0, "crResultado")
            rpt.SetParameterValue("@fec_fin", 0, "crResultado")
            rpt.SetParameterValue("@_fecha", 0, "crResultado")
            rpt.SetParameterValue("@reg_id", -1, "crResultado")
            rpt.SetParameterValue("@tip_band_id", -1, "crResultado")
            rpt.SetParameterValue("@ban_id", -1, "crResultado")
            rpt.SetParameterValue("@int_rnc_id", -1, "crResultado")
            rpt.SetParameterValue("@id", Me._Filtro.InternoFichaId, "crResultado")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crResultado")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crResultado")
            rpt.SetParameterValue("@fk_ing_inp_id", -1, "crResultado")
            rpt.SetParameterValue("@n_aut_amb", -1, "crResultado")

            'crResultado

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_Clasificacion_Ficha_Final_V1()

            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing

            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)
            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_ficha_final_v0.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "" Or obj.InfoDecadactilarInt = "|", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))
                rpt.SetParameterValue("p_ap_pat_1", If(obj.ApellidoPaterno.Length >= 2, obj.ApellidoPaterno.ToUpper.Substring(0, 1), ""))
                rpt.SetParameterValue("p_ap_pat_2", If(obj.ApellidoPaterno.Length >= 2, obj.ApellidoPaterno.ToUpper.Substring(1, 1), ""))
                rpt.SetParameterValue("p_ap_mat_1", If(obj.ApellidoMaterno.Length >= 2, obj.ApellidoMaterno.ToUpper.Substring(0, 1), ""))
                rpt.SetParameterValue("p_ap_mat_2", If(obj.ApellidoMaterno.Length >= 2, obj.ApellidoMaterno.ToUpper.Substring(1, 1), ""))

                ent = (New InternoFicha_BL).Listar_V2(Me._Filtro.InternoFichaId)

                If ent.FechaClasificacion > 0 Then
                    Dim d As DateTime = DateTime.FromFileTime(ent.FechaClasificacion)
                    rpt.SetParameterValue("p_fec_clasificacion", d)
                Else
                    rpt.SetParameterValue("p_fec_clasificacion", "")
                End If

                rpt.SetParameterValue("p_obs_clasificacion", ent.Observacion)
                rpt.SetParameterValue("p_cat_clasificacion", ent.CategoriaFichaNombre)

                rpt.SetParameterValue("p_num_clasificacion", Format(ent.NumeroClasificacion, "000"))
                rpt.SetParameterValue("p_penal_destino", ent.PenalDestinoNombre.ToUpper)


                Dim entCol As New Entity.Mantenimiento.General.RegimenPenitenciarioCol
                Try

                    entCol = (New Bussines.General.Penal).ListarRegimen(ent.RegimenPenalId)
                    rpt.SetParameterValue("p_regimen_penal", entCol.Item(0).Regimen.ToUpper)
                Catch ex As Exception
                    rpt.SetParameterValue("p_regimen_penal", "")
                End Try

            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_exp_x_ficha_clas_final", "crDelitos")
            rpt.SetParameterValue("@id", ent.Codigo, "crDelitos") 'enviar el id de la ficha final
            rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.InternoIngresoInpeID, "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crDelitos")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crDelitos")
            rpt.SetParameterValue("@n_aut_amb", -1, "crDelitos")


            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_fich_final_clasificacion", "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_id", -1, "crResultado")
            rpt.SetParameterValue("@int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_exp_id", -1, "crResultado")
            rpt.SetParameterValue("@int_sen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_del_id", -1, "crResultado")
            rpt.SetParameterValue("@nac_id", -1, "crResultado")
            rpt.SetParameterValue("@cuadro", -1, "crResultado")
            rpt.SetParameterValue("@fec_ini", 0, "crResultado")
            rpt.SetParameterValue("@fec_fin", 0, "crResultado")
            rpt.SetParameterValue("@_fecha", 0, "crResultado")
            rpt.SetParameterValue("@reg_id", -1, "crResultado")
            rpt.SetParameterValue("@tip_band_id", -1, "crResultado")
            rpt.SetParameterValue("@ban_id", -1, "crResultado")
            rpt.SetParameterValue("@int_rnc_id", -1, "crResultado")
            rpt.SetParameterValue("@id", Me._Filtro.InternoFichaId, "crResultado")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crResultado")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crResultado")
            rpt.SetParameterValue("@fk_ing_inp_id", -1, "crResultado")
            rpt.SetParameterValue("@n_aut_amb", -1, "crResultado")

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", -1)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_Clasificacion_Ficha_Final_V2()

            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing

            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)
            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_ficha_final_v1.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "" Or obj.InfoDecadactilarInt = "|", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))

                ent = (New InternoFicha_BL).Listar_V2(Me._Filtro.InternoFichaId)

                rpt.SetParameterValue("p_fec_clasificacion", ent.FechaClasificacion)
                rpt.SetParameterValue("p_obs_clasificacion", ent.Observacion)
                rpt.SetParameterValue("p_cat_clasificacion", ent.CategoriaFichaNombre)

                rpt.SetParameterValue("p_num_clasificacion", Format(ent.NumeroClasificacion, "000"))
                rpt.SetParameterValue("p_penal_destino", ent.PenalDestinoNombre.ToUpper)

                Try

                    Dim entCol = (New Bussines.General.Penal).ListarRegimen(ent.RegimenPenalId)
                    rpt.SetParameterValue("p_regimen_penal", entCol.Item(0).Regimen.ToUpper)
                Catch ex As Exception
                    rpt.SetParameterValue("p_regimen_penal", "")
                End Try

            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_exp_x_ficha_clas_final", "crDelitos")
            rpt.SetParameterValue("@id", ent.Codigo, "crDelitos") 'enviar el id de la ficha final
            rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.InternoIngresoInpeID, "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crDelitos")
            rpt.SetParameterValue("@mostrar_doc_anulado", -1, "crDelitos")
            rpt.SetParameterValue("@n_aut_amb", -1, "crDelitos")

            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_fich_final_clasificacion", "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_id", -1, "crResultado")
            rpt.SetParameterValue("@int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_exp_id", -1, "crResultado")
            rpt.SetParameterValue("@int_sen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_del_id", -1, "crResultado")
            rpt.SetParameterValue("@nac_id", -1, "crResultado")
            rpt.SetParameterValue("@cuadro", -1, "crResultado")
            rpt.SetParameterValue("@fec_ini", 0, "crResultado")
            rpt.SetParameterValue("@fec_fin", 0, "crResultado")
            rpt.SetParameterValue("@_fecha", 0, "crResultado")
            rpt.SetParameterValue("@reg_id", -1, "crResultado")
            rpt.SetParameterValue("@tip_band_id", -1, "crResultado")
            rpt.SetParameterValue("@ban_id", -1, "crResultado")
            rpt.SetParameterValue("@int_rnc_id", -1, "crResultado")
            rpt.SetParameterValue("@id", Me._Filtro.InternoFichaId, "crResultado")

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_Clasificacion_Ficha_Final_V3()
            rpt = New ReportDocument
            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing

            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)

            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_ficha_final_v2.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "" Or obj.InfoDecadactilarInt = "|", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))

                Dim _entFiltro As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                        .Codigo = Me._Filtro.InternoFichaId
                    }

                ent = (New InternoFicha_BL).Listar_v2(_entFiltro).InternoClasificacion(0)

                Dim _entSocial As New Entity.Clasificacion.InternoClasificacion.InternoFicha
                Dim _entLegal As New Entity.Clasificacion.InternoClasificacion.InternoFicha
                Dim _entPsico As New Entity.Clasificacion.InternoClasificacion.InternoFicha
                If Not ent Is Nothing Then 'obtener todas las fichas individuales
                    _entFiltro = New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                                        .FichaFinalId = ent.Codigo
                                    }

                    Dim _listFic = (New InternoFicha_BL).Listar_v2(_entFiltro)
                    For Each ob As Entity.Clasificacion.InternoClasificacion.InternoFicha In _listFic
                        If ob.TipoFicha = enmTipoFicha.Legal Then
                            _entLegal = ob
                        End If
                        If ob.TipoFicha = enmTipoFicha.Social Then
                            _entSocial = ob
                        End If
                        If ob.TipoFicha = enmTipoFicha.Psicologica Then
                            _entPsico = ob
                        End If
                    Next
                End If

                Dim d As DateTime = DateTime.FromFileTime(ent.FechaClasificacion)

                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))
                rpt.SetParameterValue("p_motiv_cambio_pen", ent.MotivoModifPenalDet.ToUpper)

                rpt.SetParameterValue("p_obs_psico", _entPsico.Observacion)
                rpt.SetParameterValue("p_obs_legal", _entLegal.Observacion)
                rpt.SetParameterValue("p_obs_social", _entSocial.Observacion)
                rpt.SetParameterValue("p_obs_clasificacion", ent.Observacion.ToUpper)

                rpt.SetParameterValue("p_num_clasificacion", Format(ent.NumeroClasificacion, "00"))
                rpt.SetParameterValue("p_penal_destino", ent.PenalDestinoNombre.ToUpper)


                Dim entCol As New Entity.Mantenimiento.General.RegimenPenitenciarioCol
                Try

                    entCol = (New Bussines.General.Penal).ListarRegimen(ent.RegimenPenalId)
                    rpt.SetParameterValue("p_regimen_penal", entCol.Item(0).Regimen.ToUpper)
                Catch ex As Exception
                    rpt.SetParameterValue("p_regimen_penal", "")
                End Try

            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_exp_x_ficha_clas_final", "crDelitos")
            rpt.SetParameterValue("@id", ent.Codigo, "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")

            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_fich_final_clasificacion_v2", "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_id", -1, "crResultado")
            rpt.SetParameterValue("@int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_exp_id", -1, "crResultado")
            rpt.SetParameterValue("@int_sen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_del_id", -1, "crResultado")
            rpt.SetParameterValue("@nac_id", -1, "crResultado")
            rpt.SetParameterValue("@cuadro", -1, "crResultado")
            rpt.SetParameterValue("@fec_ini", 0, "crResultado")
            rpt.SetParameterValue("@fec_fin", 0, "crResultado")
            rpt.SetParameterValue("@_fecha", 0, "crResultado")
            rpt.SetParameterValue("@reg_id", -1, "crResultado")
            rpt.SetParameterValue("@tip_band_id", -1, "crResultado")
            rpt.SetParameterValue("@ban_id", -1, "crResultado")
            rpt.SetParameterValue("@int_rnc_id", -1, "crResultado")
            rpt.SetParameterValue("@id", Me._Filtro.InternoFichaId, "crResultado")

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_Clasificacion_Ficha_Final_V4()

            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha = Nothing

            rpt = New ReportDocument
            Dim m As Object = Me._Filtro.InternoFichaId
            'Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_v2(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)
            Dim objEntCol = (New Bussines.Reporte.Clasificacion).DatosInterno_rpt_ETL(Me._Filtro.InternoID, Me._Filtro.InternoIngresoInpeID)

            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_ficha_final_v4.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPerfilDerecho)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "" Or obj.InfoDecadactilarInt = "|", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))

                Dim _entFiltro As New Entity.Clasificacion.InternoClasificacion.InternoFicha With {
                            .Codigo = Me._Filtro.InternoFichaId
                        }

                ent = (New InternoFicha_BL).Listar_v2(_entFiltro).InternoClasificacion(0)

                Dim _entSocial As New Entity.Clasificacion.InternoClasificacion.InternoFicha
                Dim _entLegal As New Entity.Clasificacion.InternoClasificacion.InternoFicha
                Dim _entPsico As New Entity.Clasificacion.InternoClasificacion.InternoFicha
                If Not ent Is Nothing Then 'obtener todas las fichas individuales
                    _entFiltro = New Entity.Clasificacion.InternoClasificacion.InternoFicha
                    _entFiltro.FichaFinalId = ent.Codigo
                    Dim _listFic = (New InternoFicha_BL).Listar_v2(_entFiltro)
                    For Each ob As Entity.Clasificacion.InternoClasificacion.InternoFicha In _listFic
                        If ob.TipoFicha = enmTipoFicha.Legal Then
                            _entLegal = ob
                        End If
                        If ob.TipoFicha = enmTipoFicha.Social Then
                            _entSocial = ob
                        End If
                        If ob.TipoFicha = enmTipoFicha.Psicologica Then
                            _entPsico = ob
                        End If
                    Next
                End If


                Dim d As DateTime = DateTime.FromFileTime(ent.FechaClasificacion)


                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))
                rpt.SetParameterValue("p_motiv_cambio_pen", ent.MotivoModifPenalDet.ToUpper)
                rpt.SetParameterValue("p_obs_psico", _entPsico.Observacion)
                rpt.SetParameterValue("p_obs_legal", _entLegal.Observacion)
                rpt.SetParameterValue("p_obs_social", _entSocial.Observacion)
                rpt.SetParameterValue("p_obs_clasificacion", ent.Observacion.ToUpper)
                rpt.SetParameterValue("p_num_clasificacion", Format(ent.NumeroClasificacion, "00"))
                rpt.SetParameterValue("p_penal_destino", ent.PenalDestinoNombre.ToUpper)

                Try

                    Dim entCol = (New Bussines.General.Penal).ListarRegimen(ent.RegimenPenalId)
                    rpt.SetParameterValue("p_regimen_penal", entCol.Item(0).Regimen.ToUpper)
                Catch ex As Exception
                    rpt.SetParameterValue("p_regimen_penal", "")
                End Try

            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_exp_x_ficha_clas_final", "crDelitos")
            rpt.SetParameterValue("@id", ent.Codigo, "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")

            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_fich_final_clasificacion_v4", "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_id", -1, "crResultado")
            rpt.SetParameterValue("@int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_exp_id", -1, "crResultado")
            rpt.SetParameterValue("@int_sen_id", -1, "crResultado")
            rpt.SetParameterValue("@int_del_id", -1, "crResultado")
            rpt.SetParameterValue("@nac_id", -1, "crResultado")
            rpt.SetParameterValue("@cuadro", -1, "crResultado")
            rpt.SetParameterValue("@fec_ini", 0, "crResultado")
            rpt.SetParameterValue("@fec_fin", 0, "crResultado")
            rpt.SetParameterValue("@_fecha", 0, "crResultado")
            rpt.SetParameterValue("@reg_id", -1, "crResultado")
            rpt.SetParameterValue("@tip_band_id", -1, "crResultado")
            rpt.SetParameterValue("@ban_id", -1, "crResultado")
            rpt.SetParameterValue("@int_rnc_id", -1, "crResultado")
            rpt.SetParameterValue("@id", Me._Filtro.InternoFichaId, "crResultado")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crResultado")
            rpt.SetParameterValue("@mostrar_doc_anulado", False, "crResultado")
            rpt.SetParameterValue("@fk_ing_inp_id", -1, "crResultado")
            rpt.SetParameterValue("@n_aut_amb", 0, "crResultado")

            'crResultado

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_Clasificacion_Oficio_Consolidado()

            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "Clasificacion\rpt_cla_oficio_consolidado_v1.rpt")

            rpt.DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDetDocClasificacion").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", "crDetDocClasificacion")
            rpt.SetParameterValue("@opcion", "lst_det_doc_clasificacion", "crDetDocClasificacion")
            rpt.SetParameterValue("@pen_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@int_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@int_ing_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@int_exp_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@int_sen_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@int_del_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@nac_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@cuadro", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@fec_ini", 0, "crDetDocClasificacion")
            rpt.SetParameterValue("@fec_fin", 0, "crDetDocClasificacion")
            rpt.SetParameterValue("@_fecha", 0, "crDetDocClasificacion")
            rpt.SetParameterValue("@reg_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@tip_band_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@ban_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@int_rnc_id", -1, "crDetDocClasificacion")
            rpt.SetParameterValue("@id", Me._Filtro.DocConsolidadoClasificacionId, "crDetDocClasificacion")

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")
            rpt.SetParameterValue("@int_id", -1)
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
            rpt.SetParameterValue("@int_rnc_id", -1)

            Dim ent = (New DocClasificacion_BL).Listar(Me._Filtro.DocConsolidadoClasificacionId)

            rpt.SetParameterValue("p_num_oficio", ent.NumeroDoc.ToUpper)
            rpt.SetParameterValue("p_doc_dest_nom", ent.NombreDestinoDoc.ToUpper)
            rpt.SetParameterValue("p_obs", ent.Observacion)
            rpt.SetParameterValue("p_glosa", vbTab & (New Bussines.Globall.GlosaDocumento).ListarPorCodigo(ent.GlosaDocId).Texto)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            rpt.SetParameterValue("p_fecha_oficio", ent.FechaEmisionString)
            rpt.SetParameterValue("p_oficio_derivado", If(ent.EstadoDocId = 2, True, False)) '2=derivado

            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub
#End Region

        Private Sub Reporte_Ficha_Penologica_Carceleta()

            Dim pathRpt = Me.ReportePath & "rpt_ficha_penologica_carceleta_v1.rpt"

            If System.IO.File.Exists(pathRpt) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El reporte físico no se encuentra en la ruta especificada " & Me.ReportePath & "rpt_ficha_penologica_carceleta_v1.rpt")
                Me.Close()
            End If

            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Registro).FichaIdentificacion_PLM(Me._Filtro.InternoID)
            rpt.Load(pathRpt)

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("cr_Senias_particulares").DataSourceConnections(0).SetConnection(
             Legolas.Configuration.Data.CNServer,
             Legolas.Configuration.Data.CNDataBase,
             Legolas.Configuration.Data.CNUser,
             Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.FichaIdentificacion.Ficha In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

                Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPerfilDerecho)

                'listar ultimo odontograma
                Dim entOdont As Entity.Registro.Odontograma.InternoOdontograma
                entOdont = (New Bussines.Registro.Odontograma.InternoOdontograma).ListarOdontogramaActual_LM(Me._Filtro.InternoID)
                If Not entOdont Is Nothing Then
                    Dim f As New Registro.frmPrintOdontograma
                    f._Codigo = entOdont.Codigo
                    f.ShowDialog()
                    strOdontograma = f._RutaImgOdont
                End If
                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_ruta_odontograma", strOdontograma)

                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                'rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "", "NR", obj.InfoDecadactilarInt.ToUpper))
                Dim decaDer As String = ""
                Dim decaIzq As String = ""
                If obj.InfoDecadactilarInt.Trim.Length = 0 Then
                    decaDer = "NR"
                    decaIzq = "NR"
                Else
                    If obj.InfoDecadactilarInt.Trim.Contains("|") = True Then
                        Dim d() As String = obj.InfoDecadactilarInt.Trim.Split("|")
                        decaIzq = d(0)
                        decaDer = d(1)
                    End If
                End If

                rpt.SetParameterValue("p_form_deca_red", decaDer.ToUpper)
                rpt.SetParameterValue("p_form_deca_izq", decaIzq.ToUpper)
                rpt.SetParameterValue("p_alias", If(Trim(obj.AliasNombres) = "", "NR", obj.AliasNombres.ToUpper))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_identidad", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_org_criminal", "") 'x.Bandas)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", If(obj.SexoNombre = "M", "MASCULINO", "FEMENINO")))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_otro_doc", If(obj.OtroDocumento = "", "NR", obj.OtroDocumento.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", obj.ApellidoPaterno & " " & obj.ApellidoMaterno.ToUpper)
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "", "NR", obj.Profesion.ToUpper))

                'verifica si hay rasgos
                Dim objEntRasgo As Entity.Reporte.FichaIdentificacion.Rasgos
                If obj.RasgoCol.Count < 1 Then
                    objEntRasgo = New Entity.Reporte.FichaIdentificacion.Rasgos
                Else
                    objEntRasgo = obj.RasgoCol.Rasgos(0)
                End If

                rpt.SetParameterValue("p_car_raza", If(objEntRasgo.Raza = "", "NR", objEntRasgo.Raza.ToUpper))
                rpt.SetParameterValue("p_car_forma_cara", If(objEntRasgo.FormaCara = "", "NR", objEntRasgo.FormaCara.ToUpper))
                rpt.SetParameterValue("p_car_frente", If(objEntRasgo.Frente = "", "NR", objEntRasgo.Frente.ToUpper))
                rpt.SetParameterValue("p_car_forma_ojo", If(objEntRasgo.FormaOjos = "", "NR", objEntRasgo.FormaOjos.ToUpper))
                rpt.SetParameterValue("p_car_ceja", If(objEntRasgo.Ceja = "", "NR", objEntRasgo.Ceja.ToUpper))
                rpt.SetParameterValue("p_car_tip_labio", If(objEntRasgo.TipoLabios = "", "NR", objEntRasgo.TipoLabios.ToUpper))
                rpt.SetParameterValue("p_car_linea_insercc", If(objEntRasgo.LineaInsercion = "", "NR", objEntRasgo.LineaInsercion.ToUpper))
                rpt.SetParameterValue("p_car_complex", If(objEntRasgo.Complexion = "", "NR", objEntRasgo.Complexion.ToUpper))
                rpt.SetParameterValue("p_car_talla", If(objEntRasgo.Talla = 0, "NR", objEntRasgo.Talla))
                rpt.SetParameterValue("p_car_color_cab", If(objEntRasgo.ColorCabello = "", "NR", objEntRasgo.ColorCabello.ToUpper))
                rpt.SetParameterValue("p_car_boca", If(objEntRasgo.Boca = "", "NR", objEntRasgo.Boca.ToUpper))
                rpt.SetParameterValue("p_car_tip_nariz", If(objEntRasgo.TipoNariz = "", "NR", objEntRasgo.TipoNariz.ToUpper))
                rpt.SetParameterValue("p_car_oreja", If(objEntRasgo.Oreja = "", "NR", objEntRasgo.Oreja.ToUpper))
                rpt.SetParameterValue("p_car_anom_ojos", If(objEntRasgo.AnomaliaOjos = "", "NR", objEntRasgo.AnomaliaOjos.ToUpper))
                rpt.SetParameterValue("p_car_peso", If(objEntRasgo.Peso = 0, "NR", objEntRasgo.Peso))
                rpt.SetParameterValue("p_car_menton", If(objEntRasgo.Menton = "", "NR", objEntRasgo.Menton.ToUpper))
                rpt.SetParameterValue("p_car_form_cabello", If(objEntRasgo.FormaCabello = "", "NR", objEntRasgo.FormaCabello.ToUpper))
                rpt.SetParameterValue("p_car_iris", If(objEntRasgo.Iris = "", "NR", objEntRasgo.Iris.ToUpper))
                rpt.SetParameterValue("p_car_labios", If(objEntRasgo.Labios = "", "NR", objEntRasgo.Labios.ToUpper))
                rpt.SetParameterValue("p_car_form_nariz", If(objEntRasgo.FormaNariz = "", "NR", objEntRasgo.FormaNariz.ToUpper))
                rpt.SetParameterValue("p_car_tronco", If(objEntRasgo.Tronco = "", "NR", objEntRasgo.Tronco.ToUpper))
                rpt.SetParameterValue("p_car_calvicie", If(objEntRasgo.Calvicie = "", "NR", objEntRasgo.Calvicie.ToUpper))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_bandas", If(obj.Bandas = "", "NR", obj.Bandas.ToUpper))

                '----------- odontograma -------------
                rpt.SetParameterValue("p_odt_obs", If(entOdont.Observaciones = "", "NR", entOdont.Observaciones.ToUpper))
                rpt.SetParameterValue("p_odt_especific", If(entOdont.Especificaciones = "", "NR", entOdont.Especificaciones.ToUpper))
                rpt.SetParameterValue("p_odt_dentomaxilar_id", If(entOdont.TamanioDentoMaxilarId = -1, "", entOdont.TamanioDentoMaxilarId))

                rpt.SetParameterValue("p_odt_tip_diente_id", If(entOdont.DienteTipoId = -1, "", entOdont.DienteTipoId))
                rpt.SetParameterValue("p_odt_tam_diente_id", If(entOdont.TamanioDienteId = -1, "", entOdont.TamanioDienteId))
                rpt.SetParameterValue("p_odt_oclu_id", If(entOdont.OclusionTipoId = -1, "", entOdont.OclusionTipoId))
                rpt.SetParameterValue("p_odt_tip_arc_inf", If(entOdont.ArcoDentarioInfId = -1, "", entOdont.ArcoDentarioInfId))
                rpt.SetParameterValue("p_odt_tip_arc_sup", If(entOdont.ArcoDentarioSupId = -1, "", entOdont.ArcoDentarioSupId))
                rpt.SetParameterValue("p_odt_ruga_pal_id", If(entOdont.RugaPalatinaId = -1, "", entOdont.RugaPalatinaId))
                '

                '-----huella digital--------------------------------------------------------------
                Try


                    Dim entIntHuell As New Entity.Biometria.InternoHuella With {
                            .InternoId = Me._Filtro.InternoID
                        }

                    Dim entIntHuellCol = (New Bussines.Biometria.InternoHuella).Listar(entIntHuell, "")
                    If entIntHuellCol.Count > 0 Then 'significa que ya cuenta con huellas por lo tanto no es posible realizar captura decadactilar
                        entIntHuell = entIntHuellCol.InternoHuella(0)
                    End If

                    strPathIzq_men = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_men.bmp"
                    rpt.SetParameterValue("p_path_izq_men", CargarImagenHuella(entIntHuell.HuellaDigMenIzqId, strPathIzq_men))

                    strPathIzq_anu = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_anu.bmp"
                    rpt.SetParameterValue("p_path_izq_anu", CargarImagenHuella(entIntHuell.HuellaDigAnuIzqId, strPathIzq_anu))

                    strPathIzq_med = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_med.bmp"
                    rpt.SetParameterValue("p_path_izq_med", CargarImagenHuella(entIntHuell.HuellaDigMedIzqId, strPathIzq_med))

                    strPathIzq_ind = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_ind.bmp"
                    rpt.SetParameterValue("p_path_izq_ind", CargarImagenHuella(entIntHuell.HuellaDigIndIzqId, strPathIzq_ind))

                    strPathIzq_pul = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_pul.bmp"
                    rpt.SetParameterValue("p_path_izq_pul", CargarImagenHuella(entIntHuell.HuellaDigPulIzqId, strPathIzq_pul))

                    strPathDer_men = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_men.bmp"
                    rpt.SetParameterValue("p_path_der_men", CargarImagenHuella(entIntHuell.HuellaDigMenDerId, strPathDer_men))

                    strPathDer_anu = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_anu.bmp"
                    rpt.SetParameterValue("p_path_der_anu", CargarImagenHuella(entIntHuell.HuellaDigAnuDerId, strPathDer_anu))

                    strPathDer_med = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_med.bmp"
                    rpt.SetParameterValue("p_path_der_med", CargarImagenHuella(entIntHuell.HuellaDigMedDerId, strPathDer_med))

                    strPathDer_ind = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_ind.bmp"
                    rpt.SetParameterValue("p_path_der_ind", CargarImagenHuella(entIntHuell.HuellaDigIndDerId, strPathDer_ind))

                    strPathDer_pul = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_pul.bmp"
                    rpt.SetParameterValue("p_path_der_pul", CargarImagenHuella(entIntHuell.HuellaDigPulDerId, strPathDer_pul))

                Catch ex As Exception

                End Try
            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_delitos3_LM", "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")

            '------sub reporte senias particulares-------------------------------------------------------------
            rpt.SetParameterValue("@accion", "lst", "cr_Senias_particulares")
            rpt.SetParameterValue("@opcion", "lst_senas_particulares", "cr_Senias_particulares")
            rpt.SetParameterValue("@pen_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "cr_Senias_particulares")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "cr_Senias_particulares")
            '-------------------------------------------------------------------

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)

            Dim penLicNom As String = ""
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta
                    penLicNom = "REGION: LIMA - E.T.L"
                Case enmTipoLicencia.RegionLimaMetropolitana
                    penLicNom = "OFICINA REGIONAL DE LIMA"
            End Select

            rpt.SetParameterValue("p_lic_pen_nom", penLicNom)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Ficha_Identificacion_Carceleta_ORL_PLM()

            Dim xnomrepo As String = "rpt_ficha_ident_carceleta_v2.rpt"
            'Verificar si cuenta con Odontograma antiguo
            Dim entOdontv = (New Bussines.Registro.Odontograma.InternoOdontograma).ListarOdontogramaActual_LM(Me._Filtro.InternoID)

            Using db As New DataContextDataContext(Legolas.Configuration.Data.ConexionIni)
                If (From p In db.int_mov_interno_odontograma_nts Where p.fk_int_id = Me._Filtro.InternoID And p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).Count > 0 Then
                    xnomrepo = "rpt_ficha_ident_carceleta_v2_2.rpt"
                Else
                    If entOdontv.Codigo = -1 Then
                        xnomrepo = "rpt_ficha_ident_carceleta_v2_2.rpt"
                    End If
                End If
            End Using

            Dim pathRpt = Me.ReportePath & xnomrepo
            If System.IO.File.Exists(pathRpt) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El reporte físico no se encuentra en la ruta especificada " & Me.ReportePath & xnomrepo)
                Me.Close()
            End If

            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Registro).FichaIdentificacion_PLM(Me._Filtro.InternoID)
            rpt.Load(pathRpt)

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("cr_Senias_particulares").DataSourceConnections(0).SetConnection(
             Legolas.Configuration.Data.CNServer,
             Legolas.Configuration.Data.CNDataBase,
             Legolas.Configuration.Data.CNUser,
             Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.FichaIdentificacion.Ficha In objEntCol
                '-----huella digital--------------------------------------------------------------
                Try

                    Dim entIntHuell As New Entity.Biometria.InternoHuella With {
                            .InternoId = Me._Filtro.InternoID
                        }

                    Dim entIntHuellCol = (New Bussines.Biometria.InternoHuella).Listar(entIntHuell, "")
                    If entIntHuellCol.Count > 0 Then 'significa que ya cuenta con huellas por lo tanto no es posible realizar captura decadactilar
                        entIntHuell = entIntHuellCol.InternoHuella(0)
                    End If

                    strPathIzq_men = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_men.bmp"
                    strPathIzq_anu = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_anu.bmp"
                    strPathIzq_med = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_med.bmp"
                    strPathIzq_ind = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_ind.bmp"
                    strPathIzq_pul = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_pul.bmp"
                    strPathDer_men = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_men.bmp"
                    strPathDer_anu = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_anu.bmp"
                    strPathDer_med = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_med.bmp"
                    strPathDer_ind = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_ind.bmp"
                    strPathDer_pul = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_pul.bmp"

                    Dim tbl As New DataTable("Ent_HuellasPersona")

                    tbl.Columns.Add("men_izq_img", GetType(Byte()))
                    tbl.Columns.Add("anu_izq_img", GetType(Byte()))
                    tbl.Columns.Add("med_izq_img", GetType(Byte()))
                    tbl.Columns.Add("ind_izq_img", GetType(Byte()))
                    tbl.Columns.Add("pul_izq_img", GetType(Byte()))
                    tbl.Columns.Add("men_der_img", GetType(Byte()))
                    tbl.Columns.Add("anu_der_img", GetType(Byte()))
                    tbl.Columns.Add("med_der_img", GetType(Byte()))
                    tbl.Columns.Add("ind_der_img", GetType(Byte()))
                    tbl.Columns.Add("pul_der_img", GetType(Byte()))

                    Dim row As DataRow
                    row = tbl.NewRow

                    row.Item("men_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMenIzqId, strPathIzq_men)
                    row.Item("anu_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigAnuIzqId, strPathIzq_anu)
                    row.Item("med_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMedIzqId, strPathIzq_med)
                    row.Item("ind_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigIndIzqId, strPathIzq_ind)
                    row.Item("pul_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigPulIzqId, strPathIzq_pul)
                    row.Item("men_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMenDerId, strPathDer_men)
                    row.Item("anu_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigAnuDerId, strPathDer_anu)
                    row.Item("med_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMedDerId, strPathDer_med)
                    row.Item("ind_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigIndDerId, strPathDer_ind)
                    row.Item("pul_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigPulDerId, strPathDer_pul)

                    tbl.Rows.Add(row)

                    rpt.Subreports.Item("crHuellas").SetDataSource(tbl)
                Catch ex As Exception

                End Try

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PD.tmp"

                Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                Legolas.Components.Archivo.FileCreateByte(obj.FotoBytePerfilDerecho_v2, strFotoPerfilDerecho)

                'listar ultimo odontograma
                Dim entOdont = (New Bussines.Registro.Odontograma.InternoOdontograma).ListarOdontogramaActual_LM(Me._Filtro.InternoID)

                If Not entOdont Is Nothing Then
                    Dim f As New Registro.frmPrintOdontograma_v2
                    f._Codigo = entOdont.Codigo
                    f.ShowDialog()
                    strOdontograma = f._RutaImgOdont
                End If
                Dim strPathOdonnew As String = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_odontonew.png"
                Dim xespecificaciones As String = ""
                Dim xobservaciones As String = ""
                'If entOdont.Codigo = -1 Then
                Using db As New DataContextDataContext(Legolas.Configuration.Data.ConexionIni)
                    If (From p In db.int_mov_interno_odontograma_nts Where p.fk_int_id = Me._Filtro.InternoID And p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).Count = 0 Then
                        Dim bmv As Bitmap = New Bitmap(My.Resources.Odontovacio)
                        If Not entOdont.Codigo = -1 Then
                            strPathOdonnew = strOdontograma
                        Else
                            bmv.Save(strPathOdonnew, Imaging.ImageFormat.Png)
                        End If
                    Else
                        Dim odonnew = (From p In db.int_mov_interno_odontograma_nts Where p.fk_int_id = Me._Filtro.InternoID And p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).First
                        If Not odonnew.odonto_imagen Is Nothing Then
                            Dim bm As Bitmap = New Bitmap(byteArrayToImage(odonnew.odonto_imagen.ToArray))
                            bm.Save(strPathOdonnew, Imaging.ImageFormat.Png)
                        Else
                            Dim bmv As Bitmap = New Bitmap(My.Resources.Odontovacio)
                            bmv.Save(strPathOdonnew, Imaging.ImageFormat.Png)
                        End If

                        xespecificaciones = odonnew.odonto_especificaciones
                        xobservaciones = odonnew.odonto_observaciones
                    End If
                    strOdontograma = strPathOdonnew
                    entOdont.Observaciones = xobservaciones
                    entOdont.Especificaciones = xespecificaciones
                End Using
                ' End If

                'rpt.Load(pathRpt)
                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_ruta_odontograma", strOdontograma)
                'rpt.SetParameterValue("p_ruta_odontograma", strPathOdontovacio)
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                'rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "", "NR", obj.InfoDecadactilarInt.ToUpper))
                Dim decaDer As String = ""
                Dim decaIzq As String = ""
                If obj.InfoDecadactilarInt.Trim.Length = 0 Then
                    decaDer = "NR"
                    decaIzq = "NR"
                Else
                    If obj.InfoDecadactilarInt.Trim.Contains("|") = True Then
                        Dim d() As String = obj.InfoDecadactilarInt.Trim.Split("|")
                        decaIzq = d(0)
                        decaDer = d(1)
                    End If
                End If

                rpt.SetParameterValue("p_form_deca_red", decaDer.ToUpper)
                rpt.SetParameterValue("p_form_deca_izq", decaIzq.ToUpper)
                rpt.SetParameterValue("p_alias", If(Trim(obj.AliasNombres) = "", "NR", obj.AliasNombres.ToUpper))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_identidad", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_org_criminal", "") 'x.Bandas)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", If(obj.SexoNombre = "M", "MASCULINO", "FEMENINO")))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
                rpt.SetParameterValue("p_str_homonimo", If(obj.HomonimoStr = "", "NR", obj.HomonimoStr.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", obj.ApellidoPaterno & " " & obj.ApellidoMaterno.ToUpper)
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "", "NR", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "", "NR", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "", "NR", obj.Profesion.ToUpper))

                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))

                'verifica si hay rasgos
                Dim objEntRasgo As Entity.Reporte.FichaIdentificacion.Rasgos
                If obj.RasgoCol.Count < 1 Then
                    objEntRasgo = New Entity.Reporte.FichaIdentificacion.Rasgos
                Else
                    objEntRasgo = obj.RasgoCol.Rasgos(0)
                End If

                rpt.SetParameterValue("p_car_raza", If(objEntRasgo.Raza = "", "NR", objEntRasgo.Raza.ToUpper))
                rpt.SetParameterValue("p_car_forma_cara", If(objEntRasgo.FormaCara = "", "NR", objEntRasgo.FormaCara.ToUpper))
                rpt.SetParameterValue("p_car_frente", If(objEntRasgo.Frente = "", "NR", objEntRasgo.Frente.ToUpper))
                rpt.SetParameterValue("p_car_forma_ojo", If(objEntRasgo.FormaOjos = "", "NR", objEntRasgo.FormaOjos.ToUpper))
                rpt.SetParameterValue("p_car_ceja", If(objEntRasgo.Ceja = "", "NR", objEntRasgo.Ceja.ToUpper))
                rpt.SetParameterValue("p_car_tip_labio", If(objEntRasgo.TipoLabios = "", "NR", objEntRasgo.TipoLabios.ToUpper))
                rpt.SetParameterValue("p_car_linea_insercc", If(objEntRasgo.LineaInsercion = "", "NR", objEntRasgo.LineaInsercion.ToUpper))
                rpt.SetParameterValue("p_car_complex", If(objEntRasgo.Complexion = "", "NR", objEntRasgo.Complexion.ToUpper))
                rpt.SetParameterValue("p_car_talla", If(objEntRasgo.Talla = 0, "NR", objEntRasgo.Talla))
                rpt.SetParameterValue("p_car_color_cab", If(objEntRasgo.ColorCabello = "", "NR", objEntRasgo.ColorCabello.ToUpper))
                rpt.SetParameterValue("p_car_boca", If(objEntRasgo.Boca = "", "NR", objEntRasgo.Boca.ToUpper))
                rpt.SetParameterValue("p_car_tip_nariz", If(objEntRasgo.TipoNariz = "", "NR", objEntRasgo.TipoNariz.ToUpper))
                rpt.SetParameterValue("p_car_oreja", If(objEntRasgo.Oreja = "", "NR", objEntRasgo.Oreja.ToUpper))
                rpt.SetParameterValue("p_car_anom_ojos", If(objEntRasgo.AnomaliaOjos = "", "NR", objEntRasgo.AnomaliaOjos.ToUpper))
                rpt.SetParameterValue("p_car_peso", If(objEntRasgo.Peso = 0, "NR", objEntRasgo.Peso))
                rpt.SetParameterValue("p_car_menton", If(objEntRasgo.Menton = "", "NR", objEntRasgo.Menton.ToUpper))
                rpt.SetParameterValue("p_car_form_cabello", If(objEntRasgo.FormaCabello = "", "NR", objEntRasgo.FormaCabello.ToUpper))
                rpt.SetParameterValue("p_car_iris", If(objEntRasgo.Iris = "", "NR", objEntRasgo.Iris.ToUpper))
                rpt.SetParameterValue("p_car_labios", If(objEntRasgo.Labios = "", "NR", objEntRasgo.Labios.ToUpper))
                rpt.SetParameterValue("p_car_form_nariz", If(objEntRasgo.FormaNariz = "", "NR", objEntRasgo.FormaNariz.ToUpper))
                rpt.SetParameterValue("p_car_tronco", If(objEntRasgo.Tronco = "", "NR", objEntRasgo.Tronco.ToUpper))
                rpt.SetParameterValue("p_car_calvicie", If(objEntRasgo.Calvicie = "", "NR", objEntRasgo.Calvicie.ToUpper))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_bandas", If(obj.Bandas = "", "NR", obj.Bandas.ToUpper))

                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
                '----------- odontograma -------------

                rpt.SetParameterValue("p_odt_obs", If(entOdont.Observaciones = "", "NR", entOdont.Observaciones.ToUpper))
                rpt.SetParameterValue("p_odt_especific", If(entOdont.Especificaciones = "", "NR", entOdont.Especificaciones.ToUpper))
                rpt.SetParameterValue("p_odt_dentomaxilar_id", If(entOdont.TamanioDentoMaxilarId = -1, "", entOdont.TamanioDentoMaxilarId))

                rpt.SetParameterValue("p_odt_tip_diente_id", If(entOdont.DienteTipoId = -1, "", entOdont.DienteTipoId))
                rpt.SetParameterValue("p_odt_tam_diente_id", If(entOdont.TamanioDienteId = -1, "", entOdont.TamanioDienteId))
                rpt.SetParameterValue("p_odt_oclu_id", If(entOdont.OclusionTipoId = -1, "", entOdont.OclusionTipoId))
                rpt.SetParameterValue("p_odt_tip_arc_inf", If(entOdont.ArcoDentarioInfId = -1, "", entOdont.ArcoDentarioInfId))
                rpt.SetParameterValue("p_odt_tip_arc_sup", If(entOdont.ArcoDentarioSupId = -1, "", entOdont.ArcoDentarioSupId))
                rpt.SetParameterValue("p_odt_ruga_pal_id", If(entOdont.RugaPalatinaId = -1, "", entOdont.RugaPalatinaId))
                '

            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_delitos3_LM", "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")

            '------sub reporte senias particulares-------------------------------------------------------------
            rpt.SetParameterValue("@accion", "lst", "cr_Senias_particulares")
            rpt.SetParameterValue("@opcion", "lst_senas_particulares_ult_ing_inp", "cr_Senias_particulares")
            rpt.SetParameterValue("@pen_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "cr_Senias_particulares")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "cr_Senias_particulares")
            '-------------------------------------------------------------------

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            Dim penLicNom As String = ""
            Dim regNom As String = ""
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta
                    regNom = "Región: LIMA"
                    penLicNom = "Establecimiento: E.T.P.L"
                Case enmTipoLicencia.RegionLimaMetropolitana
                    penLicNom = "OFICINA REGIONAL DE LIMA"
                Case enmTipoLicencia.PenalLimaMetropolitana
                    regNom = "Región: LIMA"
                    penLicNom = "Penal: " & Me._Filtro.PenalNombre.ToUpper
                Case Else
                    regNom = "OFICINA REGIONAL DE LIMA"
            End Select

            rpt.SetParameterValue("p_lic_region_nom", regNom)
            rpt.SetParameterValue("p_lic_pen_nom", penLicNom)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Try
                Me.CrystalReportViewer1.ReportSource = rpt
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


        End Sub
        Public Function byteArrayToImage(byteArrayIn As Byte()) As System.Drawing.Image

            Dim ms As MemoryStream = New MemoryStream(byteArrayIn)
            Dim returnImage As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
            Return returnImage
        End Function
        Private Function CargarImagenHuella(huellaTemplateId As Integer, rpathImg As String, Optional GirarHuella As enmGirarHuella = 0) As String
            If huellaTemplateId = -1 Then Return ""

            Dim bssSysBio As New APPControlHuellaVisita.Business.SysBiometria(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno)

            Dim entWsq As APPControlHuellaVisita.Entity.Ent_HuellaWSQ = Nothing
            Dim entTmpl As APPControlHuellaVisita.Entity.Ent_HuellaTemplate = Nothing

            Try
                entTmpl = bssSysBio.ListarTemplate(huellaTemplateId, "")
            Catch ex As Exception

            End Try
            If entTmpl Is Nothing Then Return ""
            Dim img As Image
            Select Case entTmpl.EstadoDedo
                Case APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Amputado
                    img = My.Resources.huella_amputada
                    Select Case GirarHuella
                        Case enmGirarHuella.GirarHaciaDerecha
                            img.RotateFlip(RotateFlipType.Rotate90FlipNone) 'para mano derecha
                        Case enmGirarHuella.GirarHaciaIzquierda
                            img.RotateFlip(RotateFlipType.Rotate270FlipNone) 'para mano izquierda 

                    End Select
                    img.Save(rpathImg)

                Case APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.NoDisponible
                    img = My.Resources.huella_observada
                    Select Case GirarHuella
                        Case enmGirarHuella.GirarHaciaDerecha
                            img.RotateFlip(RotateFlipType.Rotate90FlipNone) 'para mano derecha
                        Case enmGirarHuella.GirarHaciaIzquierda
                            img.RotateFlip(RotateFlipType.Rotate270FlipNone) 'para mano izquierda
                        Case enmGirarHuella.Ninguno

                    End Select
                    img.Save(rpathImg)
                Case Else
                    entWsq = bssSysBio.ListarWSQ_X_TemplateCod(entTmpl.Codigo, "")
                    If Not entWsq Is Nothing Then
                        System.IO.File.WriteAllBytes(rpathImg, bssSysBio.ObtenerImagenByteDesdeWSQ(entWsq.WSQFile, ""))
                        img = Image.FromFile(rpathImg)
                        Select Case GirarHuella
                            Case enmGirarHuella.GirarHaciaDerecha
                                img.RotateFlip(RotateFlipType.Rotate90FlipNone) 'para mano derecha
                                img.Save(rpathImg)
                            Case enmGirarHuella.GirarHaciaIzquierda
                                img.RotateFlip(RotateFlipType.Rotate270FlipNone) 'para mano izquierda
                                img.Save(rpathImg)
                            Case enmGirarHuella.Ninguno
                        End Select
                    Else
                        rpathImg = ""
                    End If
            End Select


            Return rpathImg
        End Function

        Private Function CargarImagenHuellaByte(huellaTemplateId As Integer, strRuta As String) As Byte()

            If huellaTemplateId = -1 Then
                Return Nothing
            End If

            Dim bssSysBio As New APPControlHuellaVisita.Business.SysBiometria(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno)

            Dim entWsq As APPControlHuellaVisita.Entity.Ent_HuellaWSQ = Nothing
            Dim entTmpl As APPControlHuellaVisita.Entity.Ent_HuellaTemplate = Nothing

            Try
                entTmpl = bssSysBio.ListarTemplate(huellaTemplateId, "")
            Catch ex As Exception

            End Try
            If entTmpl Is Nothing Then Return Nothing

            Dim img As Image = Nothing
            Select Case entTmpl.EstadoDedo
                Case APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Amputado
                    img = My.Resources.huella_amputada

                Case APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.NoDisponible
                    img = My.Resources.huella_observada

                Case Else
                    entWsq = bssSysBio.ListarWSQ_X_TemplateCod(entTmpl.Codigo, "")
                    If Not entWsq Is Nothing Then

                        If entTmpl.DispBiometricoId = 4 Then ' dispositivo Croschmat

                            Dim bitmap1 As Bitmap
                            Dim bitmap2 As Bitmap
                            Dim objByte As Byte()

                            Dim strRutaTemp As String = Legolas.Configuration.Path.PathTemp & "tmp_huella_" & Now.ToFileTime & ".bmp"
                            System.IO.File.WriteAllBytes(strRutaTemp, bssSysBio.ObtenerImagenByteDesdeWSQ(entWsq.WSQFile, ""))

                            bitmap1 = CType(Bitmap.FromFile(strRutaTemp), Bitmap)
                            bitmap2 = bitmap1

                            If bitmap2 IsNot Nothing Then
                                bitmap2.RotateFlip(RotateFlipType.Rotate180FlipY)
                            End If

                            objByte = Legolas.Components.Archivo.FileImagenConvertByte(bitmap2)
                            Legolas.Components.Archivo.FileCreateByte(objByte, strRuta)
                            Legolas.Components.Archivo.FileDelete(strRutaTemp)
                        Else
                            System.IO.File.WriteAllBytes(strRuta, bssSysBio.ObtenerImagenByteDesdeWSQ(entWsq.WSQFile, ""))
                        End If

                    End If
            End Select

            Dim bitmapBytes As Byte()
            bitmapBytes = Legolas.Components.Archivo.FileConvertByte(strRuta)

            Return bitmapBytes
        End Function

        Private Sub Reporte_Ficha_Identificacion_Provincia()

            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Registro).FichaIdentificacion_Provincia(Me._Filtro.InternoID)

            If System.IO.File.Exists(Me.ReportePath & "rpt_ficha_ident_penal_v5_1.rpt") = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El reporte físico no se encuentra en la ruta especificada " & Me.ReportePath & "rpt_ficha_ident_penal_v5_1.rpt")
                Me.Close()
            End If
            '-------------Implementacion 04112022
            Dim xnomrepo As String = "rpt_ficha_ident_penal_v5_1.rpt"

            Dim entOdontv = (New Bussines.Registro.Odontograma.InternoOdontograma).ListarOdontogramaActual(Me._Filtro.InternoID)
            Using db As New DataContextDataContext(Legolas.Configuration.Data.ConexionIni)
                If (From p In db.int_mov_interno_odontograma_nts Where p.fk_int_id = Me._Filtro.InternoID And p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).Count > 0 Then
                    xnomrepo = "rpt_ficha_ident_penal_v5_1_2.rpt"
                Else
                    If entOdontv.Codigo = -1 Then
                        xnomrepo = "rpt_ficha_ident_penal_v5_1_2.rpt"
                    End If
                End If
            End Using
            '-------------
            'rpt.Load(Me.ReportePath & "rpt_ficha_ident_penal_v5_1.rpt")
            rpt.Load(Me.ReportePath & xnomrepo)
            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crDelitos").DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("cr_Senias_particulares").DataSourceConnections(0).SetConnection(
             Legolas.Configuration.Data.CNServer,
             Legolas.Configuration.Data.CNDataBase,
             Legolas.Configuration.Data.CNUser,
             Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.FichaIdentificacion.Ficha In objEntCol
                '-----huella digital--------------------------------------------------------------
                Try

                    Dim entIntHuell As New Entity.Biometria.InternoHuella With {
                            .InternoId = Me._Filtro.InternoID
                        }

                    Dim entIntHuellCol = (New Bussines.Biometria.InternoHuella).Listar(entIntHuell, "")

                    If entIntHuellCol.Count > 0 Then 'significa que ya cuenta con huellas por lo tanto no es posible realizar captura decadactilar
                        entIntHuell = entIntHuellCol.InternoHuella(0)
                    End If

                    strPathIzq_men = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_men.bmp"
                    strPathIzq_anu = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_anu.bmp"
                    strPathIzq_med = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_med.bmp"
                    strPathIzq_ind = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_ind.bmp"
                    strPathIzq_pul = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_izq_pul.bmp"
                    strPathDer_men = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_men.bmp"
                    strPathDer_anu = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_anu.bmp"
                    strPathDer_med = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_med.bmp"
                    strPathDer_ind = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_ind.bmp"
                    strPathDer_pul = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_path_der_pul.bmp"

                    Dim tbl As New DataTable("Ent_HuellasPersona")

                    tbl.Columns.Add("men_izq_img", GetType(Byte()))
                    tbl.Columns.Add("anu_izq_img", GetType(Byte()))
                    tbl.Columns.Add("med_izq_img", GetType(Byte()))
                    tbl.Columns.Add("ind_izq_img", GetType(Byte()))
                    tbl.Columns.Add("pul_izq_img", GetType(Byte()))
                    tbl.Columns.Add("men_der_img", GetType(Byte()))
                    tbl.Columns.Add("anu_der_img", GetType(Byte()))
                    tbl.Columns.Add("med_der_img", GetType(Byte()))
                    tbl.Columns.Add("ind_der_img", GetType(Byte()))
                    tbl.Columns.Add("pul_der_img", GetType(Byte()))

                    Dim row As DataRow
                    row = tbl.NewRow

                    row.Item("men_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMenIzqId, strPathIzq_men)
                    row.Item("anu_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigAnuIzqId, strPathIzq_anu)
                    row.Item("med_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMedIzqId, strPathIzq_med)
                    row.Item("ind_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigIndIzqId, strPathIzq_ind)
                    row.Item("pul_izq_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigPulIzqId, strPathIzq_pul)
                    row.Item("men_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMenDerId, strPathDer_men)
                    row.Item("anu_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigAnuDerId, strPathDer_anu)
                    row.Item("med_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigMedDerId, strPathDer_med)
                    row.Item("ind_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigIndDerId, strPathDer_ind)
                    row.Item("pul_der_img") = CargarImagenHuellaByte(entIntHuell.HuellaDigPulDerId, strPathDer_pul)

                    tbl.Rows.Add(row)

                    rpt.Subreports.Item("crHuellas").SetDataSource(tbl)
                Catch ex As Exception

                End Try

                '/*listar la fotografia*/

                Dim intIDTipoLocal = (New Bussines.Sistema.Instalacion).ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
                Dim ObjBssArchDigital As New Bussines.Globall.ArchivoDigital
                Dim objFotoTempPF As Byte()
                Dim objFotoTempPerfilDerecho As Byte()

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPerfilDerecho = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PD.tmp"

                Select Case intIDTipoLocal
                    Case 2 'region
                        objFotoTempPF = ObjBssArchDigital.getArchivoDigitalByte_Region(obj.FotoPerfilCentralId, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "")
                        objFotoTempPerfilDerecho = ObjBssArchDigital.getArchivoDigitalByte_Region(obj.IDFotoPerfilDerecho, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "")

                        Legolas.Components.Archivo.FileCreateByte(objFotoTempPF, strFotoPC)
                        Legolas.Components.Archivo.FileCreateByte(objFotoTempPerfilDerecho, strFotoPerfilDerecho)
                    Case Else
                        'sede ,penal

                        If obj.FotoVersionAntigua = True Then
                            Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                            Legolas.Components.Archivo.FileCreateByte(obj.FotoBytePerfilDerecho, strFotoPerfilDerecho)
                        Else
                            Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                            Legolas.Components.Archivo.FileCreateByte(obj.FotoBytePerfilDerecho_v2, strFotoPerfilDerecho)
                        End If
                End Select

                'listar ultimo odontograma
                Dim entOdont = (New Bussines.Registro.Odontograma.InternoOdontograma).ListarOdontogramaActual(Me._Filtro.InternoID)
                If Not entOdont Is Nothing Then
                    Dim f As New Registro.frmPrintOdontograma_v2
                    f._Codigo = entOdont.Codigo
                    f.ShowDialog()
                    strOdontograma = f._RutaImgOdont
                End If

                '-----Nueva implementacion 04112022
                Dim strPathOdonnew As String = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "p_odontonew.png"
                Dim xespecificaciones As String = ""
                Dim xobservaciones As String = ""
                'If entOdont.Codigo = -1 Then
                Using db As New DataContextDataContext(Legolas.Configuration.Data.ConexionIni)
                    If (From p In db.int_mov_interno_odontograma_nts Where p.fk_int_id = Me._Filtro.InternoID And p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).Count = 0 Then
                        Dim bmv As Bitmap = New Bitmap(My.Resources.Odontovacio)
                        If Not entOdont.Codigo = -1 Then
                            strPathOdonnew = strOdontograma
                        Else
                            bmv.Save(strPathOdonnew, Imaging.ImageFormat.Png)
                        End If
                    Else
                        Dim odonnew = (From p In db.int_mov_interno_odontograma_nts Where p.fk_int_id = Me._Filtro.InternoID And p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).First
                        If Not odonnew.odonto_imagen Is Nothing Then
                            Dim bm As Bitmap = New Bitmap(byteArrayToImage(odonnew.odonto_imagen.ToArray))
                            bm.Save(strPathOdonnew, Imaging.ImageFormat.Png)
                        Else
                            Dim bmv As Bitmap = New Bitmap(My.Resources.Odontovacio)
                            bmv.Save(strPathOdonnew, Imaging.ImageFormat.Png)
                        End If

                        xespecificaciones = odonnew.odonto_especificaciones
                        xobservaciones = odonnew.odonto_observaciones
                    End If
                    strOdontograma = strPathOdonnew
                    entOdont.Observaciones = xobservaciones
                    entOdont.Especificaciones = xespecificaciones
                End Using
                '-------------------------

                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPerfilDerecho)
                rpt.SetParameterValue("p_ruta_odontograma", strOdontograma)
                '/*******************************************/

                '/*mostrar las formulas decadactilar*/
                Dim decaDer As String = ""
                Dim decaIzq As String = ""
                If obj.InfoDecadactilarInt.Trim.Length = 0 Then
                    decaDer = ""
                    decaIzq = ""
                Else
                    If obj.InfoDecadactilarInt.Trim.Contains("|") = True Then
                        Dim d() As String = obj.InfoDecadactilarInt.Trim.Split("|")
                        decaDer = d(0)
                        decaIzq = d(1)
                    Else
                        decaIzq = Legolas.Components.Cadena.Left(obj.InfoDecadactilarInt, 5)
                        decaDer = Legolas.Components.Cadena.Right(obj.InfoDecadactilarInt, 5)
                    End If
                End If

                rpt.SetParameterValue("p_form_deca_red", decaDer.ToUpper)
                rpt.SetParameterValue("p_form_deca_izq", decaIzq.ToUpper)
                '/***********************************************/

                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "N/R", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "N/R", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt.Trim = "" Or obj.InfoDecadactilarInt.Trim = "|", "N/R", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
                rpt.SetParameterValue("p_alias", If(Trim(obj.AliasNombres) = "", "N/R", obj.AliasNombres.ToUpper))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "N/R", obj.TipoIngreso.ToUpper))
                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "N/R", obj.FechaIngresoPenalString))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "N/R", obj.NumeroIngreso))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "N/R", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
                rpt.SetParameterValue("p_doc_identidad", obj.TipoDocumentoyNumero)
                rpt.SetParameterValue("p_org_criminal", "") 'x.Bandas)
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "N/R", If(obj.SexoNombre = "M", "MASCULINO", "FEMENINO")))
                rpt.SetParameterValue("p_edad", obj.Edad)
                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "N/R", obj.Madre.ToUpper))
                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "N/R", obj.Padre.ToUpper))
                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "N/R", obj.NumeroHijos.ToString))
                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "N/R", obj.Conyugue.ToUpper))
                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "N/R", obj.EstadoCivil.ToUpper))

                rpt.SetParameterValue("p_apellidos_interno", obj.ApellidoPaterno & " " & obj.ApellidoMaterno.ToUpper)
                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "N/R", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "N/R", obj.NacimientoDepartamento.ToUpper))
                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "N/R", obj.NacimientoDistrito.ToUpper))
                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "N/R", obj.NacimientoPais.ToUpper))
                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "N/R", obj.NacimientoProvincia.ToUpper))
                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "N/R", obj.NacimientoLugar.ToUpper))
                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "N/R", obj.DomicilioDepartamento.ToUpper))
                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "N/R", obj.DomicilioDistrito.ToUpper))
                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "N/R", obj.DomicilioProvincia.ToUpper))
                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "N/R", obj.Domicilio.ToUpper))
                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "", "N/R", obj.GradoInstruccion.ToUpper))
                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "", "N/R", obj.Ocupacion.ToUpper))
                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "", "N/R", obj.Profesion.ToUpper))
                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))

                'homonimia
                Dim strHononimo As String = ""
                If obj.Hononimo.Trim = "" Or obj.Hononimo.Trim = "???" Then
                    strHononimo = "NR"
                Else
                    If obj.Hononimo = True Or obj.Hononimo.ToUpper = "SI" Then
                        strHononimo = "SI"
                    Else
                        strHononimo = "NO"
                    End If
                End If
                rpt.SetParameterValue("p_homonimo", strHononimo)

                'verifica si hay rasgos
                Dim objEntRasgo As Entity.Reporte.FichaIdentificacion.Rasgos
                If obj.RasgoCol.Count < 1 Then
                    objEntRasgo = New Entity.Reporte.FichaIdentificacion.Rasgos
                Else
                    objEntRasgo = obj.RasgoCol.Rasgos(0)
                End If

                rpt.SetParameterValue("p_car_raza", If(objEntRasgo.Raza = "", "N/R", objEntRasgo.Raza.ToUpper))
                rpt.SetParameterValue("p_car_forma_cara", If(objEntRasgo.FormaCara = "", "N/R", objEntRasgo.FormaCara.ToUpper))
                rpt.SetParameterValue("p_car_frente", If(objEntRasgo.Frente = "", "N/R", objEntRasgo.Frente.ToUpper))
                rpt.SetParameterValue("p_car_forma_ojo", If(objEntRasgo.FormaOjos = "", "N/R", objEntRasgo.FormaOjos.ToUpper))
                rpt.SetParameterValue("p_car_ceja", If(objEntRasgo.Ceja = "", "N/R", objEntRasgo.Ceja.ToUpper))
                rpt.SetParameterValue("p_car_tip_labio", If(objEntRasgo.TipoLabios = "", "N/R", objEntRasgo.TipoLabios.ToUpper))
                rpt.SetParameterValue("p_car_linea_insercc", If(objEntRasgo.LineaInsercion = "", "N/R", objEntRasgo.LineaInsercion.ToUpper))
                rpt.SetParameterValue("p_car_complex", If(objEntRasgo.Complexion = "", "N/R", objEntRasgo.Complexion.ToUpper))
                rpt.SetParameterValue("p_car_talla", If(objEntRasgo.Talla = 0, "N/R", objEntRasgo.Talla))
                rpt.SetParameterValue("p_car_color_cab", If(objEntRasgo.ColorCabello = "", "N/R", objEntRasgo.ColorCabello.ToUpper))
                rpt.SetParameterValue("p_car_boca", If(objEntRasgo.Boca = "", "N/R", objEntRasgo.Boca.ToUpper))
                rpt.SetParameterValue("p_car_tip_nariz", If(objEntRasgo.TipoNariz = "", "N/R", objEntRasgo.TipoNariz.ToUpper))
                rpt.SetParameterValue("p_car_oreja", If(objEntRasgo.Oreja = "", "N/R", objEntRasgo.Oreja.ToUpper))
                rpt.SetParameterValue("p_car_anom_ojos", If(objEntRasgo.AnomaliaOjos = "", "N/R", objEntRasgo.AnomaliaOjos.ToUpper))
                rpt.SetParameterValue("p_car_peso", If(objEntRasgo.Peso = 0, "N/R", objEntRasgo.Peso))
                rpt.SetParameterValue("p_car_menton", If(objEntRasgo.Menton = "", "N/R", objEntRasgo.Menton.ToUpper))
                rpt.SetParameterValue("p_car_form_cabello", If(objEntRasgo.FormaCabello = "", "N/R", objEntRasgo.FormaCabello.ToUpper))
                rpt.SetParameterValue("p_car_iris", If(objEntRasgo.Iris = "", "N/R", objEntRasgo.Iris.ToUpper))
                rpt.SetParameterValue("p_car_labios", If(objEntRasgo.Labios = "", "N/R", objEntRasgo.Labios.ToUpper))
                rpt.SetParameterValue("p_car_form_nariz", If(objEntRasgo.FormaNariz = "", "N/R", objEntRasgo.FormaNariz.ToUpper))
                rpt.SetParameterValue("p_car_tronco", If(objEntRasgo.Tronco = "", "N/R", objEntRasgo.Tronco.ToUpper))
                rpt.SetParameterValue("p_car_calvicie", If(objEntRasgo.Calvicie = "", "N/R", objEntRasgo.Calvicie.ToUpper))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "N/R", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_bandas", If(obj.Bandas = "", "N/R", obj.Bandas.ToUpper))


                '----------- odontograma -------------
                rpt.SetParameterValue("p_odt_obs", If(entOdont.Observaciones = "", "NR", entOdont.Observaciones.ToUpper))
                rpt.SetParameterValue("p_odt_especific", If(entOdont.Especificaciones = "", "NR", entOdont.Especificaciones.ToUpper))
                rpt.SetParameterValue("p_odt_dentomaxilar_id", If(entOdont.TamanioDentoMaxilarId = -1, "", entOdont.TamanioDentoMaxilarId))

                rpt.SetParameterValue("p_odt_tip_diente_id", If(entOdont.DienteTipoId = -1, "", entOdont.DienteTipoId))
                rpt.SetParameterValue("p_odt_tam_diente_id", If(entOdont.TamanioDienteId = -1, "", entOdont.TamanioDienteId))
                rpt.SetParameterValue("p_odt_oclu_id", If(entOdont.OclusionTipoId = -1, "", entOdont.OclusionTipoId))
                rpt.SetParameterValue("p_odt_tip_arc_inf", If(entOdont.ArcoDentarioInfId = -1, "", entOdont.ArcoDentarioInfId))
                rpt.SetParameterValue("p_odt_tip_arc_sup", If(entOdont.ArcoDentarioSupId = -1, "", entOdont.ArcoDentarioSupId))
                rpt.SetParameterValue("p_odt_ruga_pal_id", If(entOdont.RugaPalatinaId = -1, "", entOdont.RugaPalatinaId))
            Next obj

            rpt.SetParameterValue("@accion", "lst", "crDelitos")
            rpt.SetParameterValue("@opcion", "lst_delitos3", "crDelitos")
            rpt.SetParameterValue("@pen_id", -1, "crDelitos")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "crDelitos")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "crDelitos")

            '------sub reporte senias particulares-------------------------------------------------------------
            rpt.SetParameterValue("@accion", "lst", "cr_Senias_particulares")
            rpt.SetParameterValue("@opcion", "lst_senas_particulares", "cr_Senias_particulares")
            rpt.SetParameterValue("@pen_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "cr_Senias_particulares")
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
            rpt.SetParameterValue("@int_rnc_id", -1, "cr_Senias_particulares")
            rpt.SetParameterValue("@id", -1, "cr_Senias_particulares")
            '-------------------------------------------------------------------

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
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
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_Constancia_Reclusion_Provincia()

            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Registro).ConstanciaReclusion_Provincia(Me._Filtro.InternoID, "")

            rpt.Load(Me.ReportePath & "rpt_cert_reclusion_v3.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_certificado_reclusion_expediente2")

            For Each obj As Entity.Reporte.CertificadoReclusion.Certificado In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & "_" & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                End If
                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ep", obj.PenalNombre)
                rpt.SetParameterValue("p_nom_interno", obj.ApellidosyPreNombres)
                rpt.SetParameterValue("@int_ing_id", obj.InternoIngresoID)
                rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
                rpt.SetParameterValue("p_nomb_asoc", If(obj.NombresAsociados = "", "No registra nombres asociados", obj.NombresAsociados))
                rpt.SetParameterValue("p_str_fec_isp", obj.FechaISPStr)
                Exit For
            Next

            rpt.SetParameterValue("p_num_cert", Me._Filtro.DocumentoNumero)
            'rpt.SetParameterValue("p_fech_ing", Me._Filtro.FechaIngreso)'viene de la fecha de mov de ingreso, solo en la version antigua viene por aplicativo
            rpt.SetParameterValue("p_obvs", Me._Filtro.Observacion)
            rpt.SetParameterValue("p_fecha", Legolas.LBusiness.Globall.DateTime.FechaServer)

            rpt.SetParameterValue("@pen_id", -1)

            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", 0)
            rpt.SetParameterValue("@fec_fin", 0)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@int_rnc_id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Constancia_Reclusion_LM()
            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Registro).ConstanciaReclusion_LM(Me._Filtro.InternoID, Me._Filtro.PenalID, "")

            If Me._Filtro.TipResolString = "RS_ING" Then 'por resolucion de ingreso
                rpt.Load(Me.ReportePath & "rpt_cert_reclusion_LM.rpt")
            Else 'RS_TRS por resolucion de traslado
                rpt.Load(Me.ReportePath & "rpt_cert_reclusion_x_rs_tras_LM.rpt")
            End If

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_certificado_reclusion_expediente_LM")

            For Each obj As Entity.Reporte.CertificadoReclusion.Certificado In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & "_" & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_LM_v2, strFotoPC)
                End If

                Dim penLicNom As String = ""
                Dim regNom As String = ""
                Select Case Me._TipoLicencia
                    Case enmTipoLicencia.Carceleta
                        regNom = "Región: LIMA"
                        penLicNom = "Establecimiento: E.T.P.L"
                    Case enmTipoLicencia.RegionLimaMetropolitana
                        penLicNom = "OFICINA REGIONAL DE LIMA"
                    Case enmTipoLicencia.PenalLimaMetropolitana
                        regNom = "Región: LIMA"
                        penLicNom = "Penal: " & Me._Filtro.PenalNombre.ToUpper
                    Case Else
                        regNom = "OFICINA REGIONAL DE LIMA"
                End Select

                rpt.SetParameterValue("p_lic_region_nom", regNom)
                rpt.SetParameterValue("p_lic_pen_nom", penLicNom)

                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ep", obj.PenalNombre)
                rpt.SetParameterValue("p_str_fec_isp", If(Me._Filtro.FechaISPString.Trim.Length = 0, "[NO INDICA]", Me._Filtro.FechaISPString))
                rpt.SetParameterValue("p_nom_interno", obj.ApellidosyPreNombres)
                rpt.SetParameterValue("p_nomb_asoc", If(obj.NombresAsociados = "", "No registra nombres asociados", obj.NombresAsociados))
                rpt.SetParameterValue("p_fech_ing", obj.FechaIngresStr)
                rpt.SetParameterValue("@fk_ing_inp_id", obj.IngresoInpeId)
                rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)

                If Me._Filtro.FechaISPString.Trim.Length > 4 And obj.FechaIngresStr.Length > 4 Then
                    Dim c As Date = CDate(Me._Filtro.FechaISPString)
                    Dim tt As Long = c.ToFileTime
                    If tt > obj.FechaIngreso Then 'la fecha ISP no debe ser menor la fec ing al penal
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Verifique la fecha de ingreso al sistema penitenciario con relación a la fecha de ingreso al penal, posible inconsistencia.")
                    End If
                End If

                If Me._Filtro.TipResolString = "RS_TRS" Then
                    rpt.SetParameterValue("p_num_rd", Me._Filtro.NumeroDocTrasladoStr)
                    rpt.SetParameterValue("p_pen_ori_trs", "E.P. " & Me._Filtro.PenalNomOrigenTraslado.ToUpper)
                    rpt.SetParameterValue("p_pen_des_trs", "E.P. " & Me._Filtro.PenalNomDestinoTraslado.ToUpper)
                End If
                Exit For
            Next

            rpt.SetParameterValue("p_num_cert", Me._Filtro.DocumentoNumero)
            rpt.SetParameterValue("p_obvs", Me._Filtro.Observacion)
            rpt.SetParameterValue("p_fecha", Legolas.LBusiness.Globall.DateTime.FechaServer)

            rpt.SetParameterValue("@pen_id", -1)

            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", 0)
            rpt.SetParameterValue("@fec_fin", 0)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", 0)
            rpt.SetParameterValue("@n_aut_amb", -1)
            rpt.SetParameterValue("@int_ing_id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Certificado_Libertad_PLM()

            rpt = New ReportDocument

            Dim objEntCol = (New Bussines.Reporte.Registro).CertificadoLibertad_LM(Me._Filtro.InternoID, Me._Filtro.PenalID, _Filtro.PenalProcedencia, _Filtro.Nota, Me._pRestriccionCol)

            If objEntCol.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("El interno no cuenta con ningún registro de Libertad")
                Exit Sub
            End If
            rpt.Load(Me.ReportePath & "rpt_CertificadoLibertad_LM_v2.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")
            For Each obj As Entity.Reporte.CertificadoLibertad.Certificado In objEntCol
                strFotoPC = Legolas.Configuration.Path.PathTemp & "_" & obj.CodigoRP & Now.Millisecond & "PC.tmp"

                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_LM_v2, strFotoPC)
                End If

                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)
                rpt.SetParameterValue("p_ep", obj.PenalNombre)
                rpt.SetParameterValue("p_nom_interno", obj.ApellidosyPreNombres)
                rpt.SetParameterValue("p_nomb_asoc", If(obj.NombresAsociados = "", "No registra nombres asociados", obj.NombresAsociados))
                rpt.SetParameterValue("@int_ing_id", obj.InternoIngresoID)

                rpt.SetParameterValue("p_str_fec_isp", If(objEntCol.Certificado(0).FechaIngresoInpeString.Length = 0, "[NO INDICA]", objEntCol.Certificado(0).FechaIngresoInpeString))
                rpt.SetParameterValue("p_fec_egreso_string", obj.FechaEgresoString)
                If obj.LibertadSalaJuzgado = "" Then
                    rpt.SetParameterValue("p_aut_nom_lib", If(obj.LibertadSalaJuzgadoCargo.Length = 0, "[NO INDICA]", obj.LibertadSalaJuzgadoCargo))
                Else
                    rpt.SetParameterValue("p_aut_nom_lib", If(obj.LibertadSalaJuzgado.Length = 0, "[NO INDICA]", obj.LibertadSalaJuzgado))
                End If
                rpt.SetParameterValue("p_num_doc_libertad", If(obj.LibertadNumeroDocumento.Length = 0, "[NO INDICA]", obj.LibertadNumeroDocumento))

                Dim res As String = ""
                For Each rs As Entity.Reporte.CertificadoLibertad.Restriccion In obj.Restricciones
                    res = res & rs.Descripcion & "<br>"
                Next
                rpt.SetParameterValue("p_obvs", If(obj.Nota = "", "", If(res = "", "", "<br>") & "<br>" & obj.Nota & "<br>"))
                rpt.SetParameterValue("p_restricciones", res)
                rpt.SetParameterValue("p_exp_del_lib", If(obj.ExpedienteDelitosStringLibetad.Length = 0, "[NO INDICA]", obj.ExpedienteDelitosStringLibetad))

                Exit For
            Next

            Dim penLicNom As String = ""
            Dim regNom As String = ""
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta
                    regNom = "Región: LIMA"
                    penLicNom = "Establecimiento: E.T.P.L"
                Case enmTipoLicencia.RegionLimaMetropolitana
                    penLicNom = "OFICINA REGIONAL DE LIMA"
                Case enmTipoLicencia.PenalLimaMetropolitana
                    regNom = "Región: LIMA"
                    penLicNom = "Penal: " & Me._Filtro.PenalNombre.ToUpper
                Case Else
                    regNom = "OFICINA REGIONAL DE LIMA"
            End Select
            rpt.SetParameterValue("p_lic_region_nom", regNom)
            rpt.SetParameterValue("p_lic_pen_nom", penLicNom)

            rpt.SetParameterValue("p_num_cert", Me._Filtro.DocumentoNumero)

            rpt.SetParameterValue("p_fecha", Legolas.LBusiness.Globall.DateTime.FechaServer)

            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", 0)
            rpt.SetParameterValue("@fec_fin", 0)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@strNomAsoc", "")

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()

            With Me.CrystalReportViewer1
                .ShowExportButton = False
                .ShowGroupTreeButton = False
                .ShowCloseButton = False
                .ShowParameterPanelButton = False
                .ShowRefreshButton = False
                .ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            End With

        End Sub
        Private Sub ExportarPDF()

            With Me.SaveFileDialog1
                .FileName = ""
                .Filter = "Solo PDF (*.pdf)|*.pdf"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ExportToPDF(Me.rpt, .FileName, "")
                End If

            End With

        End Sub

        Public Sub ExportToPDF(ByVal Reporte As ReportDocument, ByVal Path As String, ByVal NombreArchivo As String)

            Dim vFileName As String
            Dim diskOpts As New DiskFileDestinationOptions

            Try
                With rpt.ExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                End With

                vFileName = Path & NombreArchivo

                If Legolas.Components.Archivo.FileExiste(vFileName) Then
                    Legolas.Components.Archivo.FileDelete(vFileName)
                End If

                diskOpts.DiskFileName = vFileName
                Reporte.ExportOptions.DestinationOptions = diskOpts
                Reporte.Export()

                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#End Region
        Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
            Me.Close()
        End Sub

        Private Sub ReporteCrystal_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            rpt.Dispose()
            CrystalReportViewer1.Dispose()

            Try
                Legolas.Components.Archivo.FileDelete(strFotoPC)
                Legolas.Components.Archivo.FileDelete(strFotoPerfilDerecho)
                Legolas.Components.Archivo.FileDelete(strOdontograma)

                Legolas.Components.Archivo.FileDelete(strPathIzq_men)
                Legolas.Components.Archivo.FileDelete(strPathIzq_anu)
                Legolas.Components.Archivo.FileDelete(strPathIzq_med)
                Legolas.Components.Archivo.FileDelete(strPathIzq_ind)
                Legolas.Components.Archivo.FileDelete(strPathIzq_pul)
                Legolas.Components.Archivo.FileDelete(strPathDer_men)
                Legolas.Components.Archivo.FileDelete(strPathDer_anu)
                Legolas.Components.Archivo.FileDelete(strPathDer_med)
                Legolas.Components.Archivo.FileDelete(strPathDer_ind)
                Legolas.Components.Archivo.FileDelete(strPathDer_pul)

            Catch ex As Exception

            End Try

        End Sub

        Private Sub ReporteCrystal_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
            Me.WindowState = FormWindowState.Maximized
        End Sub

        Private Sub ReporteCrystal_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ListarPropiedadesReporte()
            Me.Text = Me.ReporteNombre
            VerReporte()
        End Sub

        Private Sub ImpirmirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImpirmirToolStripMenuItem.Click
            Me.CrystalReportViewer1.PrintReport()
        End Sub

        Private Sub ExportarPDFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarPDFToolStripMenuItem.Click
            ExportarPDF()
        End Sub

        Private Sub mnuExportarVarios_Click(sender As System.Object, e As System.EventArgs) Handles mnuExportarVarios.Click
            CrystalReportViewer1.ExportReport()
        End Sub

    End Class
End Namespace
