Option Explicit On
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.Management
Imports System.Drawing.Printing
Imports System.Data

Namespace Registro
    Public Class ReporteCrystal_v2
        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Private intNumCorrelativoRpt As Integer = 0
        Private intNumImpresion As Integer = 0
        Private intEstadoCertAJ As Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud
        Private Property NumeroCertificado As String = ""

        Private obj_rpt_lib As Entity.Reporte.Registro.CertificadoLibertad_v2.CertificadoLibertad
        Private obj_rpt_cert_reclu As Entity.Reporte.Registro.CertificadoReclusion_v2.CertificadoReclusion

        Public Property _CebeceraReporteId As Integer = -1
        Public Property _Filtro() As New Entity.Reporte.Registro.Filtro
        Public Property FechaHoy As DateTime = Now

#Region "Propiedades_Reporte"
        Private intReporteId As Type.Reporte.Registro = Type.Reporte.Registro.rpt
        Private ReadOnly Property ReporteID() As Integer
            Get
                Dim intCodigoReporte As Integer = -1

                intCodigoReporte = Me._ReporteId.GetHashCode

                Return intCodigoReporte
            End Get
        End Property
        Public Property _ReporteId() As Type.Reporte.Registro
            Get
                Return intReporteId
            End Get
            Set(ByVal value As Type.Reporte.Registro)
                intReporteId = value
            End Set
        End Property
        Public Property _LicenciaId As Integer = -1
        Private Property ReporteNombre() As String = ""
        Private Property ReporteNombreFisico() As String = ""
        Private Property ReporteDependencia() As String = ""
        Private Property ReporteModulo() As String = ""
        Private Property ReporteModuloVersion() As String = ""
        Private Property ReporteActa() As String = ""
        Private Property ReporteNumero() As Integer = 0
        Private Property ReporteNumeroExportacion() As Integer = 0
        Public Property ReporteOpcion As String = ""
        Private ReadOnly Property ReportePath() As String
            Get
                Return Legolas.Configuration.Path.PathReporte & "Registro\"
            End Get
        End Property
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

            Dim objEnt As New Legolas.LEntity.Globall.Reporte
            Dim objBssRpt As New Legolas.LBusiness.Globall.Reporte

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

        Private Sub VerReporte()

            If Me._Filtro.RegionID < 1 Then
                Me._Filtro.RegionNombre = "Oficina Regional de Lima"
            Else
                Me._Filtro.RegionNombre = Me._Filtro.RegionNombre
            End If

            Select Case Me.ReporteID
                Case Type.Reporte.Registro.rptCertificadoAntecedenteJudNoPPPMD_v1
                    Reporte_cert_ant_jud_no_rppmd_v1()
                    ExportarPDFToolStripMenuItem.Enabled = False

                Case Type.Reporte.Registro.rptCertificadoAntecedenteJudSiPPPMD_v1
                    Reporte_cert_ant_jud_pos_v1()
                    ExportarPDFToolStripMenuItem.Enabled = False

                Case Type.Reporte.Registro.rptCertificadoAntecedenteJudNegativo_v1
                    Reporte_cert_ant_jud_neg_v1()
                    ExportarPDFToolStripMenuItem.Enabled = False

                Case Type.Reporte.Registro.rptListaCertificadoAntecedendeJudicial_v1
                    Reporte_lista_ant_jud()

                Case Type.Reporte.Registro.rptListaHistorialAntecedendeJudicial

                    CrystalReportViewer1.AllowedExportFormats = (ViewerExportFormats.PdfFormat Or
                                                                ViewerExportFormats.WordFormat Or
                                                                ViewerExportFormats.EditableRtfFormat)
                    ExportarPDFToolStripMenuItem.Visible = False
                    mnuExportarVarios.Visible = True

                    'Me.Text = "Antecedentes Judiciales"
                    ReporteHistorialAntecedente_Provincia()

                Case Type.Reporte.Registro.rptListaHistorialAntecedendeJudicial_LM_v1
                    mnuExportarVarios.Enabled = True
                    ExportarPDFToolStripMenuItem.Enabled = True
                    ReporteHistorialAntecedentes_PLM()

                Case Type.Reporte.Registro.rpt_tupa_v0
                    Reporte_Tupa_V0()

                Case Type.Reporte.Registro.rptCertificadoAntJudPositivo_v0
                    Reporte_cert_ant_positivo_v0()

                Case Type.Reporte.Registro.rptCertificadoAntJudNoPPPMD_v0
                    Reporte_cert_ant_jud_no_rppmd_v0()

                Case Type.Reporte.Registro.rptCertificadoAntJudNegativo_v0
                    Reporte_cert_ant_jud_neg_v0()

                Case Type.Reporte.Registro.rptListaAlertaSentencia
                    Reporte_alerta_sentencia()
            End Select

        End Sub


#Region "Reporte_old_SRP"
        ''' <summary>
        ''' 11/07/2018 - hnrb
        ''' Permite imprimir directamente el reporte de antecedendes provenientes de la migracion del Sybase SRP
        ''' </summary>
        Private Sub Reporte_cert_ant_positivo_v0()
            Dim glosaStr As String = ""
            Dim nomAsoc As String = ""
            Dim regAnulado As Integer = 0

            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            ent = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Listar(Me._Filtro.DocSolicitudAntecedenteId) 'no hay necesidad de extraer info del historial de reporte dado que al finalizar el registro es bloqueado.

            If ent Is Nothing Then Exit Sub

            Dim entGlo As Entity.Globall.GlosaDocumento
            nomAsoc = ent.InternoNombresAsociados

            If nomAsoc = "" Then nomAsoc = "NO PRESENTA"

            entGlo = (New Bussines.Globall.GlosaDocumento).ListarPorCodigo(4)

            glosaStr = entGlo.Texto.Replace("{_PRM_PENAL}", ent.AmbitoNombre.ToUpper)


            rpt.Load(Me.ReportePath & "\Antecedentes\rpt_cert_ant_positivo_v0.rpt")
            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crAntecedentes").SetDataSource((New Bussines.Registro.Reporte.AntecedenteJudicialHistoricoSRP).ListarDetalleAntJudPositivo(Me._Filtro.DocSolicitudAntecedenteId))

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("p_anio", ent.Anio)
            rpt.SetParameterValue("p_cod_pen", ent.TipoAntecedenteId)
            rpt.SetParameterValue("p_num_corr", ent.NumeroCorrelativo)
            rpt.SetParameterValue("p_num_print", 0)
            rpt.SetParameterValue("p_nom_interno", ent.InternoNombreCompleto.ToUpper)
            rpt.SetParameterValue("p_solicitado_por", ent.NombreAutoridadSolicitante.ToUpper)
            If ent.TipoAutoridadJudicial = 1 Then 'autoridad judicial
                rpt.SetParameterValue("p_secre", ent.SolNombreSecretario.ToUpper)
            Else
                rpt.SetParameterValue("p_secre", "")
            End If
            If ent.Observacion = "" Then
                rpt.SetParameterValue("p_obs", "")
                rpt.SetParameterValue("p_ovs", "")
            Else
                rpt.SetParameterValue("p_obs", "Observaciones :")
                rpt.SetParameterValue("p_ovs", ent.Observacion)
            End If
            If ent.EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Anulado Then regAnulado = 1

            rpt.SetParameterValue("p_num_doc_sol", ent.DocumentoNumero.ToUpper)
            rpt.SetParameterValue("p_motivo_sol", ent.MotivoSolicitudStr)
            rpt.SetParameterValue("p_nom_asoc", nomAsoc.ToUpper)
            rpt.SetParameterValue("p_glosa", vbTab & glosaStr)
            rpt.SetParameterValue("p_registro_anulado", regAnulado)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

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
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", False)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)

            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_cert_ant_jud_no_rppmd_v0()
            Dim regAnulado As Integer = 0

            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            ent = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Listar(Me._Filtro.DocSolicitudAntecedenteId) 'no hay necesidad de extraer info del historial de reporte dado que al finalizar el registro es bloqueado.

            If ent Is Nothing Then Exit Sub

            rpt.Load(Me.ReportePath & "\Antecedentes\rpt_cert_ant_no_rppmd_v0.rpt")
            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("p_nom_interno", ent.InternoNombreCompleto.ToUpper)
            rpt.SetParameterValue("p_solicitado_por", ent.NombreAutoridadSolicitante.ToUpper)
            If ent.EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Anulado Then regAnulado = 1

            rpt.SetParameterValue("p_num_doc_sol", ent.DocumentoNumero.ToUpper)
            rpt.SetParameterValue("p_motivo_sol", ent.MotivoSolicitudStr)
            rpt.SetParameterValue("p_nom_asoc", ent.InternoNombresAsociados.ToUpper)
            rpt.SetParameterValue("p_registro_anulado", regAnulado)
            If ent.Observacion = "" Then
                rpt.SetParameterValue("p_obs", "")
                rpt.SetParameterValue("p_ovs", "")
            Else
                rpt.SetParameterValue("p_obs", "Observaciones :")
                rpt.SetParameterValue("p_ovs", ent.Observacion)
            End If
            Dim juris As String = ""
            Dim sinAj As String = ""
            Select Case ent.AmbitoJurisdiccionAut
                Case 1
                    juris = "LIMA"
                    sinAj = "NO REGISTRA ANTECEDENTES POR CALLAO"
                Case 2
                    juris = "CALLAO"
                    sinAj = "NO REGISTRA ANTECEDENTES POR LIMA"
                Case 3
                    juris = "LIMA Y CALLAO"
                    sinAj = ""
            End Select

            rpt.SetParameterValue("p_dis_jud", juris)
            rpt.SetParameterValue("p_dist_jud_nrpp", sinAj)

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
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", False)

            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_Tupa_V0()
            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente

            ent = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Listar(Me._Filtro.DocSolicitudAntecedenteId)

            If ent Is Nothing Then Exit Sub

            rpt.Load(Me.ReportePath & "\Antecedentes\rpt_tupa_v1.rpt")
            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("p_num_corr", ent.NumeroCorrelativo)
            rpt.SetParameterValue("p_ruta_imagenPF", "")
            rpt.SetParameterValue("p_anio", ent.Anio)
            rpt.SetParameterValue("p_dni", ent.InternoNumDocIdentidad)
            rpt.SetParameterValue("m_mot_sol", ent.MotivoSolicitudStr)
            rpt.SetParameterValue("p_ape_pat", ent.InternoApePaterno)
            rpt.SetParameterValue("p_ape_mat", ent.InternoApeMaterno)
            rpt.SetParameterValue("p_nom", ent.InternoNombres)

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
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", False)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)

            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_cert_ant_jud_neg_v0()
            Dim regAnulado As Integer = 0

            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            ent = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Listar(Me._Filtro.DocSolicitudAntecedenteId) 'no hay necesidad de extraer info del historial de reporte dado que al finalizar el registro es bloqueado.

            If ent Is Nothing Then Exit Sub

            rpt.Load(Me.ReportePath & "\Antecedentes\rpt_cert_ant_neg_v0.rpt")
            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("p_anio", ent.Anio)
            rpt.SetParameterValue("p_cod_pen", ent.TipoAntecedenteId)
            rpt.SetParameterValue("p_num_corr", ent.NumeroCorrelativo)
            rpt.SetParameterValue("p_num_print", 0)
            rpt.SetParameterValue("p_nom_interno", ent.InternoNombreCompleto.ToUpper)
            rpt.SetParameterValue("p_solicitado_por", ent.NombreAutoridadSolicitante.ToUpper)
            If ent.TipoAutoridadJudicial = 1 Then 'autoridad judicial
                rpt.SetParameterValue("p_secre", ent.SolNombreSecretario.ToUpper)
            Else
                rpt.SetParameterValue("p_secre", ent.SolNombreSecretario.ToUpper)
            End If
            If ent.EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Anulado Then regAnulado = 1

            rpt.SetParameterValue("p_num_doc_sol", ent.DocumentoNumero.ToUpper)
            rpt.SetParameterValue("p_motivo_sol", ent.MotivoSolicitudStr)
            rpt.SetParameterValue("p_nom_asoc", ent.InternoNombresAsociados.ToUpper)
            'rpt.SetParameterValue("p_glosa", vbTab & glosaStr)
            rpt.SetParameterValue("p_registro_anulado", regAnulado)
            If ent.Observacion = "" Then
                rpt.SetParameterValue("p_obs", "")
                rpt.SetParameterValue("p_ovs", "")
            Else
                rpt.SetParameterValue("p_obs", "Observaciones :")
                rpt.SetParameterValue("p_ovs", ent.Observacion)
            End If
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
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", False)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_alerta_sentencia()
            Dim objBss As New Bussines.Reporte.Registro
            Dim nacionalidad As String = ""

            If Me._Filtro.Nacionalidad = 1 Then 'Peruanos
                nacionalidad = "PERUANA"
            ElseIf Me._Filtro.Nacionalidad = 2 Then ' Extranjeros
                nacionalidad = "EXTRANJEROS"
            Else
                nacionalidad = "[TODOS]"
            End If

            rpt = New ReportDocument
            rpt.Load(Me.ReportePath & "\Alertas\rpt_aler_sent.rpt")

            rpt.DataSourceConnections(0).SetConnection(
                Legolas.Configuration.Data.CNServer,
                Legolas.Configuration.Data.CNDataBase,
                Legolas.Configuration.Data.CNUser,
                Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", Me.ReporteOpcion)
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFinOri)
            rpt.SetParameterValue("@fk_cab_not_sen_id", -1)
            rpt.SetParameterValue("@ver_reporte", 1)
            rpt.SetParameterValue("@nac_id", Me._Filtro.Nacionalidad)

            rpt.SetParameterValue("p_region_nom", UCase(Me._Filtro.RegionNombre))
            rpt.SetParameterValue("p_fec_ini", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio))
            rpt.SetParameterValue("p_fec_fin", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFinOri))
            rpt.SetParameterValue("p_ep", UCase(Me._Filtro.PenalNombre))
            rpt.SetParameterValue("p_titulo", UCase(nacionalidad))

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            CrystalReportViewer1.ReportSource = rpt

        End Sub
#End Region

        Private Function fn_NumeroCertificado(objEnt As Entity.Registro.Antecedente.SolicitudAntecedente) As String

            Dim value As String = ""

            If Me._Filtro.RegionID < 1 Then
                value = Legolas.Components.Cadena.Right(objEnt.Anio.ToString("00"), 2) & objEnt.TipoAntecedenteId &
                    objEnt.NumeroCorrelativo.ToString("00000") & "-" & Me.intNumImpresion
            Else
                value = objEnt.Anio & "-" & objEnt.TipoAntecedenteId & "-" & objEnt.NumeroCorrelativo.ToString("00000") & "-" & Me.intNumImpresion
            End If

            Return value
        End Function

        Private Sub Reporte_cert_ant_jud_pos_v1()

            Dim entContRpt As Entity.Reporte.Registro.AntecedenteJudicial.AntecedenteJudicial
            Dim glosaStr As String = ""
            Dim regAnulado As Integer = 0

            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            ent = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Listar(Me._Filtro.DocSolicitudAntecedenteId) 'no hay necesidad de extraer info del historial de reporte dado que al finalizar el registro es bloqueado.

            If ent Is Nothing Then Exit Sub
            Me._CebeceraReporteId = ent.ReporteCabeceraId
            Me.intEstadoCertAJ = ent.EstadoSolicitud

            Me.intNumCorrelativoRpt = ent.NumeroCorrelativo
            Me.intNumImpresion = (New Bussines.Reporte.ReporteCabecera).UltimoNumImpresion(Me._CebeceraReporteId) + 1
            Me._Filtro.InternoID = ent.InternoId
            Me._Filtro.PenalID = ent.PenalId
            Me._Filtro.RegionID = ent.RegionId

            entContRpt = (New Bussines.Registro.Reporte.AntecedenteJudicial).AntecedenteJudicialPositivo(ent.ReporteCabeceraId)
            If Not entContRpt Is Nothing Then glosaStr = entContRpt.GlosaDescripcion

            'numero de certificado
            NumeroCertificado = fn_NumeroCertificado(ent)

            rpt.Load(Me.ReportePath & "\Antecedentes\rpt_cert_ant_si_rppmd_v1.rpt")
            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.Subreports.Item("crAntecedentes").DataSourceConnections(0).SetConnection(Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase, Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("p_anio", ent.Anio)
            rpt.SetParameterValue("p_cod_pen", ent.TipoAntecedenteId)
            rpt.SetParameterValue("p_num_corr", ent.NumeroCorrelativo)
            rpt.SetParameterValue("p_num_print", Me.intNumImpresion)
            rpt.SetParameterValue("p_nom_interno", ent.InternoNombreCompleto.ToUpper)
            rpt.SetParameterValue("p_solicitado_por", ent.NombreAutoridadSolicitante.ToUpper)
            If ent.TipoAutoridadJudicial = 1 Then 'autoridad judicial
                rpt.SetParameterValue("p_secre", ent.SolNombreSecretario.ToUpper)
            Else
                rpt.SetParameterValue("p_secre", "")
            End If
            If ent.EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Anulado Then regAnulado = 1

            rpt.SetParameterValue("p_num_doc_sol", ent.DocumentoNumero.ToUpper)
            rpt.SetParameterValue("p_motivo_sol", ent.MotivoSolicitudStr)
            If ent.Observacion = "" Then
                rpt.SetParameterValue("p_obs", "")
                rpt.SetParameterValue("p_ovs", "")
            Else
                rpt.SetParameterValue("p_obs", "Observaciones :")
                rpt.SetParameterValue("p_ovs", ent.Observacion)
            End If
            rpt.SetParameterValue("p_nom_asoc", ent.InternoNombresAsociados.ToUpper)
            If ent.IncluyeAnulaciones = 1 Then
                rpt.SetParameterValue("p_incluye_anulacion", True)
            Else
                rpt.SetParameterValue("p_incluye_anulacion", 0)
            End If

            'ent.IncluyeAnulaciones 
            'Dim juris As String = ""
            'Dim sinAj As String = ""d
            'Select Case ent.AmbitoJurisdiccionAut
            '    Case 1
            '        juris = "LIMA"
            '        sinAj = "NO REGISTRA ANTECEDENTES POR CALLAO"
            '    Case 2
            '        juris = "CALLAO"
            '        sinAj = "NO REGISTRA ANTECEDENTES POR LIMA"
            '    Case 3
            '        juris = "LIMA Y CALLAO"
            '        sinAj = ""
            'End Select

            rpt.SetParameterValue("p_glosa", vbTab & glosaStr)
            rpt.SetParameterValue("p_registro_anulado", regAnulado)

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
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", False)

            rpt.SetParameterValue("@accion", "lst", "crAntecedentes")
            rpt.SetParameterValue("@opcion", "lst_det_cert_ant_jud", "crAntecedentes")
            rpt.SetParameterValue("@int_exp_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@int_sen_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@int_del_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@nac_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@cuadro", -1, "crAntecedentes")
            rpt.SetParameterValue("@fec_ini", 0, "crAntecedentes")
            rpt.SetParameterValue("@fec_fin", 0, "crAntecedentes")
            rpt.SetParameterValue("@_fecha", 0, "crAntecedentes")
            rpt.SetParameterValue("@reg_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@tip_band_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@ban_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@int_rnc_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@pen_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@int_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@int_ing_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@id", ent.Codigo, "crAntecedentes")
            rpt.SetParameterValue("@pk_rpt_cab_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@mostrar_doc_anulado", False, "crAntecedentes")
            rpt.SetParameterValue("@fk_ing_inp_id", -1, "crAntecedentes")
            rpt.SetParameterValue("@n_aut_amb", -1, "crAntecedentes")

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            rpt.SetParameterValue("p_region_nombre", Me._Filtro.RegionNombre)
            rpt.SetParameterValue("p_numero_certificado", NumeroCertificado)

            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        'reporte certificado presenta procesos pendientes con mandato de detencion
        Private Sub Reporte_cert_ant_jud_no_rppmd_v1()
            Dim entContRpt As Entity.Reporte.Registro.AntecedenteJudicial.AntecedenteJudicial
            Dim glosaStr As String = ""
            Dim regAnulado As Integer = 0

            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            ent = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Listar(Me._Filtro.DocSolicitudAntecedenteId) 'no hay necesidad de extraer info del historial de reporte dado que al finalizar el registro es bloqueado.

            If ent Is Nothing Then Exit Sub
            Me._CebeceraReporteId = ent.ReporteCabeceraId
            Me.intEstadoCertAJ = ent.EstadoSolicitud

            Me.intNumCorrelativoRpt = ent.NumeroCorrelativo
            Me.intNumImpresion = (New Bussines.Reporte.ReporteCabecera).UltimoNumImpresion(Me._CebeceraReporteId) + 1
            Me._Filtro.InternoID = ent.InternoId
            Me._Filtro.PenalID = ent.PenalId
            Me._Filtro.RegionID = ent.RegionId

            'numero de certificado
            NumeroCertificado = fn_NumeroCertificado(ent)

            entContRpt = (New Bussines.Registro.Reporte.AntecedenteJudicial).AntecedenteJudicialPositivo(ent.ReporteCabeceraId)
            If Not entContRpt Is Nothing Then glosaStr = entContRpt.GlosaDescripcion

            rpt.Load(Me.ReportePath & "\Antecedentes\rpt_cert_ant_no_rppmd_v1.rpt")
            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("p_anio", ent.Anio)
            rpt.SetParameterValue("p_cod_pen", ent.TipoAntecedenteId)
            rpt.SetParameterValue("p_num_corr", ent.NumeroCorrelativo)
            rpt.SetParameterValue("p_num_print", Me.intNumImpresion)
            rpt.SetParameterValue("p_nom_interno", ent.InternoNombreCompleto.ToUpper)
            rpt.SetParameterValue("p_solicitado_por", ent.NombreAutoridadSolicitante.ToUpper)
            If ent.TipoAutoridadJudicial = 1 Then 'autoridad judicial
                rpt.SetParameterValue("p_secre", ent.SolNombreSecretario.ToUpper)
            Else
                rpt.SetParameterValue("p_secre", "")
            End If
            If ent.EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Anulado Then regAnulado = 1

            rpt.SetParameterValue("p_num_doc_sol", ent.DocumentoNumero.ToUpper)
            rpt.SetParameterValue("p_motivo_sol", ent.MotivoSolicitudStr)
            rpt.SetParameterValue("p_nom_asoc", ent.InternoNombresAsociados.ToUpper)
            rpt.SetParameterValue("p_registro_anulado", regAnulado)
            If ent.Observacion = "" Then
                rpt.SetParameterValue("p_obs", "")
                rpt.SetParameterValue("p_ovs", "")
            Else
                rpt.SetParameterValue("p_obs", "Observaciones :")
                rpt.SetParameterValue("p_ovs", ent.Observacion)
            End If

            Dim juris As String = ""
            Dim sinAj As String = ""
            Select Case ent.AmbitoJurisdiccionAut
                Case 1
                    juris = "POR EL DISTRITO JUDICIAL: LIMA"
                    sinAj = "NO REGISTRA ANTECEDENTES POR CALLAO"
                Case 2
                    juris = "POR EL DISTRITO JUDICIAL: CALLAO"
                    sinAj = "NO REGISTRA ANTECEDENTES POR LIMA"
                Case 3
                    juris = "LIMA Y CALLAO"
                    sinAj = ""
                Case 4 'ambito penal
                    juris = "POR EL ESTABLECIMIENTO PENITENCIARIO DE: "
                    sinAj = ""
            End Select

            rpt.SetParameterValue("p_dis_jud", juris)
            rpt.SetParameterValue("p_dist_jud_nrpp", sinAj)

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
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", False)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            rpt.SetParameterValue("p_region_nombre", Me._Filtro.RegionNombre)
            rpt.SetParameterValue("p_numero_certificado", NumeroCertificado)

            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_cert_ant_jud_neg_v1()
            Dim entContRpt As Entity.Reporte.Registro.AntecedenteJudicial.AntecedenteJudicial
            Dim glosaStr As String = ""
            Dim regAnulado As Integer = 0

            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            ent = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Listar(Me._Filtro.DocSolicitudAntecedenteId) 'no hay necesidad de extraer info del historial de reporte dado que al finalizar el registro es bloqueado.

            If ent Is Nothing Then Exit Sub
            Me._CebeceraReporteId = ent.ReporteCabeceraId
            Me.intEstadoCertAJ = ent.EstadoSolicitud

            Me.intNumCorrelativoRpt = ent.NumeroCorrelativo

            If Me._CebeceraReporteId > -1 Then
                Me.intNumImpresion = (New Bussines.Reporte.ReporteCabecera).UltimoNumImpresion(Me._CebeceraReporteId) + 1
            Else
                Me.intNumImpresion = 0
            End If

            Me._Filtro.InternoID = ent.InternoId
            Me._Filtro.PenalID = ent.PenalId
            Me._Filtro.RegionID = ent.RegionId

            'numero de certificado
            NumeroCertificado = fn_NumeroCertificado(ent)

            entContRpt = (New Bussines.Registro.Reporte.AntecedenteJudicial).AntecedenteJudicialPositivo(ent.ReporteCabeceraId)
            If Not entContRpt Is Nothing Then glosaStr = entContRpt.GlosaDescripcion

            rpt.Load(Me.ReportePath & "\Antecedentes\rpt_cert_ant_neg_v1.rpt")
            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencias")

            rpt.SetParameterValue("p_anio", ent.Anio)
            rpt.SetParameterValue("p_cod_pen", ent.TipoAntecedenteId)
            rpt.SetParameterValue("p_num_corr", ent.NumeroCorrelativo)
            rpt.SetParameterValue("p_num_print", Me.intNumImpresion)
            rpt.SetParameterValue("p_nom_interno", ent.InternoNombreCompleto.ToUpper)
            rpt.SetParameterValue("p_solicitado_por", ent.NombreAutoridadSolicitante.ToUpper)
            rpt.SetParameterValue("p_secre", ent.SolNombreSecretario.ToUpper)

            If ent.EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Anulado Then regAnulado = 1

            rpt.SetParameterValue("p_num_doc_sol", ent.DocumentoNumero.ToUpper)
            rpt.SetParameterValue("p_motivo_sol", ent.MotivoSolicitudStr)
            rpt.SetParameterValue("p_nom_asoc", ent.InternoNombresAsociados.ToUpper)
            If ent.Observacion = "" Then
                rpt.SetParameterValue("p_obs", "")
                rpt.SetParameterValue("p_ovs", "")
            Else
                rpt.SetParameterValue("p_obs", "Observaciones :")
                rpt.SetParameterValue("p_ovs", ent.Observacion)
            End If
            'rpt.SetParameterValue("p_glosa", vbTab & glosaStr)
            rpt.SetParameterValue("p_registro_anulado", regAnulado)

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
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", False)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            rpt.SetParameterValue("p_region_nombre", Me._Filtro.RegionNombre)
            rpt.SetParameterValue("p_numero_certificado", NumeroCertificado)

            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub Reporte_lista_ant_jud()
            'entContRpt = (New Bussines.Reporte.AntecedenteJudicial).AntecedenteJudicialPositivo(ent.ReporteCabeceraId)
            rpt.Load(Me.ReportePath & "\Antecedentes\rpt_cert_ant_lista_v1.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_cert_ant_jus")

            rpt.SetParameterValue("@id", Me._Filtro.TipoAntecedenteId)
            rpt.SetParameterValue("@mostrar_doc_anulado", -1)
            rpt.SetParameterValue("p_fecha_ini", (New DateTime(Me._Filtro.FechaInicio)))
            rpt.SetParameterValue("p_fecha_fin", (New DateTime(Me._Filtro.FechaFin)))

            Dim tipCertAj As String = ""
            Select Case Me._Filtro.TipoAntecedenteId
                Case -1
                    tipCertAj = "POSITIVOS Y NEGATIVOS"
                Case 1
                    tipCertAj = "POSITIVOS"
                Case 2
                    tipCertAj = "NEGATIVOS"
            End Select

            rpt.SetParameterValue("p_tipo_cert_aj", Me._Filtro.TipoAntecedenteId)
            rpt.SetParameterValue("p_tipo_cert_aj", tipCertAj)


            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)

            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)


            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt
        End Sub

        Private Sub ReporteHistorialAntecedente_Provincia()

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.FichaCol
            Dim objBss As New Bussines.Reporte.Registro
            If Me._Filtro.InternoID = -1 Then Exit Sub
            objEntCol = objBss.FichaIdentificacion_Provincia(Me._Filtro.InternoID)

            Dim bss As New Bussines.Registro.Reporte.AntecedenteJudicial
            Dim list As Entity.Registro.Antecedente.DetalleAntecedenteCol

            list = bss.HistorialAntecedente(Me._Filtro.RegionID, Me._Filtro.PenalID, Me._Filtro.InternoID, Me._Filtro.MostrarDocAnulados)

            'Me._CebeceraReporteId = ent.ReporteCabeceraId
            Me.intNumImpresion = 0 ' (New Bussines.Reporte.ReporteCabecera).UltimoNumImpresion(Me._CebeceraReporteId) + 1

            rpt.Load(Me.ReportePath & "\rpt_HistorialAntecedentes.rpt")
            rpt.SetDataSource(list)

            Dim strRegionPenal As String = ""
            For Each obj As Entity.Reporte.FichaIdentificacion.Ficha In objEntCol
                rpt.SetParameterValue("p_nom_asoc", If(obj.NombresAsociados = "", "NO REGISTRA NOMBRES ASOCIADOS", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_num_print", 0) 'parametro innecesario
                rpt.SetParameterValue("p_nom_interno", obj.ApellidoPaterno & " " & obj.ApellidoMaterno & ", " & obj.Nombres)
                strRegionPenal = "Región: " & obj.LicRegionActual + Chr(13) + Chr(13) +
                                   IIf(obj.PenalActual.Length = 0, "", "Penal: " + obj.PenalActual)
                rpt.SetParameterValue("p_reg_nom", IIf(obj.LicRegionActual = "", "", obj.LicRegionActual)) ' strRegionPenal) 
                rpt.SetParameterValue("p_pen_nom", obj.PenalActual.ToUpper)
            Next
            Dim titulo As String = "ANTECEDENTES JUDICIALES"
            If Me._Filtro.MostrarDocAnulados = True Then titulo = "HISTORIAL DE ANTECEDENTES JUDICIALES"
            rpt.SetParameterValue("p_titulo", titulo)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub ReporteHistorialAntecedentes_PLM()

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.FichaCol
            Dim objBss As New Bussines.Reporte.Registro
            If Me._Filtro.InternoID = -1 Then Exit Sub
            objEntCol = objBss.FichaIdentificacion_PLM(Me._Filtro.InternoID)

            'Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            'ent = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Listar(Me._Filtro.InternoID) 'no hay necesidad de extraer info del historial de reporte dado que al finalizar el registro es bloqueado.

            Dim bss As New Bussines.Registro.Reporte.AntecedenteJudicial
            Dim list As Entity.Registro.Antecedente.DetalleAntecedenteCol

            list = bss.HistorialAntecedente_LM(Me._Filtro.InternoID, Me._Filtro.MostrarDocAnulados)

            'Me._CebeceraReporteId = ent.ReporteCabeceraId
            Me.intNumImpresion = 0 ' (New Bussines.Reporte.ReporteCabecera).UltimoNumImpresion(Me._CebeceraReporteId) + 1

            rpt.Load(Me.ReportePath & "\rpt_HistorialAntecedentes_LM.rpt")
            rpt.SetDataSource(list)

            For Each obj As Entity.Reporte.FichaIdentificacion.Ficha In objEntCol
                rpt.SetParameterValue("p_nom_asoc", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_num_print", 0) 'parametro innecesario
                rpt.SetParameterValue("p_nom_interno", obj.ApellidoPaterno & " " & obj.ApellidoMaterno & ", " & obj.Nombres)
                rpt.SetParameterValue("p_reg_nom", Me._Filtro.RegionNombre.ToUpper)
                rpt.SetParameterValue("p_pen_nom", "")
            Next
            Dim titulo As String = "ANTECEDENTES JUDICIALES"
            If Me._Filtro.MostrarDocAnulados = True Then titulo = "HISTORIAL DE ANTECEDENTES JUDICIALES"
            rpt.SetParameterValue("p_titulo", titulo)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub
#End Region

#Region "Accion"
        Private Function Validar() As Boolean
            Dim ent As New Entity.Reporte.ReporteCabecera
            Select Case ReporteID
                Case Type.Reporte.Registro.rptCertificadoReclusion_v3
                    ent.NumSerie = obj_rpt_cert_reclu.NumSerieDoc
                    ent.Anio = obj_rpt_cert_reclu.AnioDoc
                    ent.CodigoReporteId = Me._ReporteId
                    ent.NumeroImpresion = If(Me._CebeceraReporteId <= -1, 0, intNumImpresion)
                    If (New Bussines.Reporte.ReporteCabecera).Listar(ent).Count > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya existe número de documento, cambie a otro")
                        Return False
                    End If
                Case Type.Reporte.Registro.rptCertificadoLibertad_v3
                    ent.NumSerie = obj_rpt_lib.NumSerieDoc
                    ent.Anio = obj_rpt_lib.AnioDoc
                    ent.CodigoReporteId = Me._ReporteId
                    ent.NumeroImpresion = If(Me._CebeceraReporteId <= -1, 0, intNumImpresion)
                    If (New Bussines.Reporte.ReporteCabecera).Listar(ent).Count > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya existe número de documento, cambie a otro")
                        Return False
                    End If
                Case Type.Reporte.Registro.rptCertificadoAntecedenteJudNegativo_v1
                    If (New Bussines.Reporte.ReporteCabecera).UltimoNumImpresion(Me._CebeceraReporteId) = Me.intNumImpresion Then
                        Reporte_cert_ant_jud_pos_v1() 'volver a cargar el reporte con el numero actualizado y volver a imprimir (evitar concurrencia)
                    End If
                Case Type.Reporte.Registro.rptListaCertificadoAntecedendeJudicial_v1

                Case Type.Reporte.Registro.rptCertificadoAntecedenteJudSiPPPMD_v1
                    If (New Bussines.Reporte.ReporteCabecera).UltimoNumImpresion(Me._CebeceraReporteId) = Me.intNumImpresion Then
                        Reporte_cert_ant_jud_pos_v1() 'volver a cargar el reporte con el numero actualizado y volver a imprimir (evitar concurrencia)
                    End If
                Case Type.Reporte.Registro.rptCertificadoAntecedenteJudNoPPPMD_v1
                    Dim dddd As Integer
                    dddd = 0
                    'Case otros
            End Select

            'End If
            Return True
        End Function

        'Private Sub grabarRptCertLibertad_v3()
        '    Dim cab As New Bussines.Reporte.ReporteCabecera
        '    Dim ent_cab As New Entity.Reporte.ReporteCabecera
        '    Dim id As Integer = -1
        '    Dim idTmp As Integer = -1
        '    Dim outSms As String = ""
        '    With ent_cab
        '        .FechaEmision = obj_rpt_lib.FechaEmisionCertificado
        '        .Anio = obj_rpt_lib.AnioDoc
        '        .NumSerie = obj_rpt_lib.NumSerieDoc
        '        .CodigoPenal = obj_rpt_lib.CodigoPenal
        '        .NumeroImpresion = Me.intNumImpresion
        '        If Me._CebeceraReporteId = -1 Then 'nuevo 
        '            .CodigoReporteId = Me.ReporteID
        '            .CodigoId = -1
        '            .NumeroImpresion = 0
        '        Else 'impresion de reportes existentes
        '            .CodigoId = _CebeceraReporteId
        '            idTmp = Me._CebeceraReporteId
        '            .Anio = 0
        '            .NumSerie = 0
        '            .FechaEmision = 0
        '        End If
        '        .InternoId = obj_rpt_lib.InternoID
        '        .InternoIngresoId = obj_rpt_lib.InternoIngresoID
        '        .MotivoAnulacion = ""
        '        .Estado = 1
        '        .PenalId = Me._Filtro.PenalID
        '        .RegionId = Me._Filtro.RegionID
        '    End With

        '    If Me._CebeceraReporteId <= -1 Then
        '        With ent_cab
        '            .CodigoReporteId = Me.ReporteID
        '        End With
        '        id = cab.Grabar(ent_cab, False, outSms) 'impresion cabecera de reportes
        '        idTmp = id
        '        If id < 0 Then
        '            Legolas.Configuration.Aplication.MessageBox.MensajeError(outSms)
        '            Exit Sub
        '        End If
        '    End If

        '    With ent_cab
        '        .FechaEmision = obj_rpt_lib.FechaEmisionCertificado
        '        .Anio = obj_rpt_lib.AnioDoc
        '        .NumSerie = obj_rpt_lib.NumSerieDoc
        '        .NumeroImpresion = Me.intNumImpresion

        '        .CodigoReporteId = -1
        '        .CodigoId = idTmp
        '        .Anio = 0
        '        .NumSerie = 0
        '        .FechaEmision = 0

        '        .InternoId = obj_rpt_lib.InternoID
        '        .InternoIngresoId = obj_rpt_lib.InternoIngresoID
        '        .MotivoAnulacion = ""
        '        .Estado = 1
        '        .PenalId = Me._Filtro.PenalID
        '        .RegionId = Me._Filtro.RegionID
        '    End With





        '    cab.Grabar(ent_cab, False, outSms) 'insertar primera impresion

        '    If Me._CebeceraReporteId > 0 Then Exit Sub 'si es grabar impresion de registro existente no es necesario grabar detalles.

        '    Me._CebeceraReporteId = idTmp


        '    Dim bss As New Bussines.Reporte.ReporteContenido
        '    Dim ent As Entity.Reporte.ReporteContenido

        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_COD_RP" : ent.ValorStr = obj_rpt_lib.CodigoRP : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_APE_PAT" : ent.ValorStr = obj_rpt_lib.ApellidoPrimero : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_APE_MAT" : ent.ValorStr = obj_rpt_lib.ApellidoSegundo : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_NOM" : ent.ValorStr = obj_rpt_lib.PreNombres : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "PEN_NOM" : ent.ValorStr = obj_rpt_lib.PenalNombre : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "FOT_FRE_NOM" : ent.ValorStr = obj_rpt_lib.FotoPerfilCentralNombre : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "FOT_VER_ANTIGUA" : ent.ValorInt = obj_rpt_lib.FotoVersionAntigua : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "ARC_DIG_DIR" : ent.ValorStr = obj_rpt_lib.PathServerImg : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_FEC_ING" : ent.ValorStr = obj_rpt_lib.FechaIngreso : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_EXP_SAL_JUZ_ING" : ent.ValorStr = obj_rpt_lib.ExpedienteSalaJuzgado : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_EXP_NUM_ING" : ent.ValorStr = obj_rpt_lib.ExpedienteNumero : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "LIB_FEC_MOV" : ent.ValorStr = obj_rpt_lib.FechaEgreso : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "LIB_SAL_JUZ_NOM" : ent.ValorStr = obj_rpt_lib.LibertadSalaJuzgado : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "LIB_SAL_JUZ_NOM_OTRO" : ent.ValorStr = obj_rpt_lib.LibertadSalaJuzgadoOtroNombre : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "LIB_SAL_JUZ_CARGO_OTRO" : ent.ValorStr = obj_rpt_lib.LibertadSalaJuzgadoOtroCargo : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "LIB_NUM_DOC" : ent.ValorStr = obj_rpt_lib.LibertadNumeroDocumento : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "DELITOS" : ent.ValorStr = obj_rpt_lib.Delito : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "TIP_LIB_NOM" : ent.ValorStr = obj_rpt_lib.LibertadTipo : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_EXP_NUM_LIB" : ent.ValorStr = obj_rpt_lib.ExpedienteNumeroLibertad : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "NOTA" : ent.ValorStr = obj_rpt_lib.Nota : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "NOM_ASOC" : ent.ValorStr = obj_rpt_lib.NombresAsociados : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "DEL_EXP_LIB" : ent.ValorStr = obj_rpt_lib.ExpedienteDelitosStringLibetad : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_ID" : ent.ValorInt = obj_rpt_lib.InternoID : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_ING_ID" : ent.ValorInt = obj_rpt_lib.InternoIngresoID : ent.RptCabeceraId = id : bss.Grabar(ent)

        'End Sub

        'Private Sub grabarRptCertReclusion_v3()
        '    Dim cab As New Bussines.Reporte.ReporteCabecera
        '    Dim ent_cab As New Entity.Reporte.ReporteCabecera
        '    Dim id As Integer = -1
        '    Dim idTmp As Integer = -1
        '    Dim outSms As String = ""

        '    With ent_cab
        '        .FechaEmision = obj_rpt_cert_reclu.FechaEmisionCertificado
        '        .Anio = obj_rpt_cert_reclu.AnioDoc
        '        .NumSerie = obj_rpt_cert_reclu.NumSerieDoc
        '        .CodigoPenal = obj_rpt_cert_reclu.CodigoPenal
        '        .NumeroImpresion = Me.intNumImpresion
        '        If Me._CebeceraReporteId = -1 Then 'nuevo 
        '            .CodigoReporteId = Me.ReporteID
        '            .CodigoId = -1
        '            .NumeroImpresion = 0
        '        Else 'impresion de reportes existentes
        '            .CodigoId = Me._CebeceraReporteId
        '            idTmp = Me._CebeceraReporteId
        '            .Anio = 0
        '            .NumSerie = 0
        '            .FechaEmision = 0
        '        End If
        '        .InternoId = obj_rpt_cert_reclu.InternoID
        '        .InternoIngresoId = obj_rpt_cert_reclu.InternoIngresoID
        '        .MotivoAnulacion = ""
        '        .Estado = 1
        '        .PenalId = Me._Filtro.PenalID
        '        .RegionId = Me._Filtro.RegionID
        '    End With
        '    If Me._CebeceraReporteId <= -1 Then 'si es nuevo se inserta encabezado
        '        With ent_cab
        '            .CodigoReporteId = Me.ReporteID
        '        End With
        '        id = cab.Grabar(ent_cab, False, outSms) 'impresion cabecera de reportes
        '        idTmp = id
        '        If id < 0 Then
        '            Legolas.Configuration.Aplication.MessageBox.MensajeError(outSms)
        '            Exit Sub
        '        End If
        '    End If

        '    With ent_cab

        '        .FechaEmision = obj_rpt_cert_reclu.FechaEmisionCertificado
        '        .Anio = obj_rpt_cert_reclu.AnioDoc
        '        .NumSerie = obj_rpt_cert_reclu.NumSerieDoc
        '        .NumeroImpresion = Me.intNumImpresion

        '        .CodigoReporteId = -1
        '        .CodigoId = idTmp
        '        .Anio = 0
        '        .NumSerie = 0
        '        .FechaEmision = 0

        '        .InternoId = obj_rpt_cert_reclu.InternoID
        '        .InternoIngresoId = obj_rpt_cert_reclu.InternoIngresoID
        '        .MotivoAnulacion = ""
        '        .Estado = 1
        '        .PenalId = Me._Filtro.PenalID
        '        .RegionId = Me._Filtro.RegionID
        '    End With



        '    cab.Grabar(ent_cab, False, outSms) 'insertar primera impresion

        '    If Me._CebeceraReporteId > 0 Then Exit Sub 'si es grabar impresion de registro existente no es necesario grabar detalles.

        '    Me._CebeceraReporteId = idTmp


        '    Dim bss As New Bussines.Reporte.ReporteContenido
        '    Dim ent As Entity.Reporte.ReporteContenido

        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_COD_RP" : ent.ValorStr = obj_rpt_cert_reclu.CodigoRP : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_APE_PAT" : ent.ValorStr = obj_rpt_cert_reclu.ApellidoPrimero : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_APE_MAT" : ent.ValorStr = obj_rpt_cert_reclu.ApellidoSegundo : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_NOM" : ent.ValorStr = obj_rpt_cert_reclu.PreNombres : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "PEN_NOM" : ent.ValorStr = obj_rpt_cert_reclu.PenalNombre : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "FOT_FRE_NOM" : ent.ValorStr = obj_rpt_cert_reclu.FotoPerfilCentralNombre : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "FOT_VER_ANTIGUA" : ent.ValorInt = obj_rpt_cert_reclu.FotoVersionAntigua : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "ARC_DIG_DIR" : ent.ValorStr = obj_rpt_cert_reclu.PathServerImg : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "NOTA" : ent.ValorStr = obj_rpt_cert_reclu.Obs : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_ID" : ent.ValorInt = obj_rpt_cert_reclu.InternoID : ent.RptCabeceraId = id : bss.Grabar(ent)
        '    ent = New Entity.Reporte.ReporteContenido : ent.ClaveStr = "INT_ING_ID" : ent.ValorInt = obj_rpt_cert_reclu.InternoIngresoID : ent.RptCabeceraId = id : bss.Grabar(ent)

        'End Sub

        Private Sub GrabarRptCertAntecedenteJudPositivo_v1()

            Dim objBssCabRpt As New Bussines.Reporte.ReporteCabecera
            Dim objEntCabRpt As New Entity.Reporte.ReporteCabecera
            Dim intValue As Integer = -1
            Dim outSms As String = ""

            With objEntCabRpt
                .InternoId = Me._Filtro.InternoID
                .Anio = Me.FechaHoy.Year
                If Me._CebeceraReporteId > 0 Then
                    .NumSerie = 0
                Else
                    .NumSerie = Me.intNumCorrelativoRpt
                End If
                .NumeroImpresion = Me.intNumImpresion
                .FechaEmision = Me.FechaHoy.ToFileTime
                .CodigoId = Me._CebeceraReporteId
                .Estado = 1
                .CodigoReporteId = Me.ReporteID 'tipo de reporte
                .PenalId = Me._Filtro.PenalID
                .RegionId = Me._Filtro.RegionID
            End With

            intValue = objBssCabRpt.Grabar(objEntCabRpt, True, outSms)

            If intValue < 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outSms)
                Exit Sub
            End If

            If Me.intEstadoCertAJ = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Terminado Then
                intValue = -1
                outSms = ""
                intValue = (New Bussines.Registro.Antecedente.SolicitudAntecedente).CambiarEstado(Me._Filtro.DocSolicitudAntecedenteId, Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Impreso.GetHashCode, outSms)
            End If

        End Sub

        'no presenta procesos pendientes con mandato de detencion
        Private Sub grabarRptCertAntecedenteNoPresentaPPMD_v1()
            Dim cab As New Bussines.Reporte.ReporteCabecera
            Dim ent_cab As New Entity.Reporte.ReporteCabecera
            Dim id As Integer = -1
            Dim outSms As String = ""

            With ent_cab
                .InternoId = Me._Filtro.InternoID
                .Anio = Me.FechaHoy.Year
                If Me._CebeceraReporteId > 0 Then
                    .NumSerie = 0
                Else
                    .NumSerie = Me.intNumCorrelativoRpt
                End If
                .NumeroImpresion = Me.intNumImpresion
                .FechaEmision = Me.FechaHoy.ToFileTime
                .CodigoId = Me._CebeceraReporteId
                .Estado = 1
                .CodigoReporteId = Me.ReporteID 'tipo de reporte
                .PenalId = Me._Filtro.PenalID
                .RegionId = Me._Filtro.RegionID
            End With

            id = cab.Grabar(ent_cab, True, outSms)

            If id < 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outSms)
                Exit Sub
            End If

            If Me.intEstadoCertAJ = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Terminado Then
                id = -1
                outSms = ""
                id = (New Bussines.Registro.Antecedente.SolicitudAntecedente).CambiarEstado(Me._Filtro.DocSolicitudAntecedenteId, Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Impreso.GetHashCode, outSms)
            End If

        End Sub

        Private Sub grabarRptCertAntecedenteJudNegativo_v1()
            Dim cab As New Bussines.Reporte.ReporteCabecera
            Dim ent_cab As New Entity.Reporte.ReporteCabecera
            Dim id As Integer = -1
            Dim outSms As String = ""

            With ent_cab
                .InternoId = Me._Filtro.InternoID
                .Anio = Me.FechaHoy.Year
                If Me._CebeceraReporteId > 0 Then
                    .NumSerie = 0
                Else
                    .NumSerie = Me.intNumCorrelativoRpt
                End If
                .NumeroImpresion = Me.intNumImpresion
                .FechaEmision = Me.FechaHoy.ToFileTime
                .CodigoId = Me._CebeceraReporteId
                .CodigoReporteId = Me.ReporteID 'tipo de reporte
                .Estado = 1
                .PenalId = Me._Filtro.PenalID
                .RegionId = Me._Filtro.RegionID
            End With

            id = cab.Grabar(ent_cab, True, outSms)

            If id < 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outSms)
                Exit Sub
            End If

            If Me.intEstadoCertAJ = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Terminado Then
                id = -1
                outSms = ""
                id = (New Bussines.Registro.Antecedente.SolicitudAntecedente).CambiarEstado(Me._Filtro.DocSolicitudAntecedenteId, Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Impreso.GetHashCode, outSms)
            End If

        End Sub
#End Region

#Region "Otros"
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

        Private Sub ReporteCrystal_v2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Me.WindowState = FormWindowState.Maximized
        End Sub

        Private Sub ReporteCrystal_v2_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ListarPropiedadesReporte()
            Me.Text = Me.ReporteNombre

            If Me.ReporteNombre.Trim.Length < 1 Then
                Me.Text = Me._Filtro.Text
            End If

            Me.FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServer(True)
            VerReporte()

        End Sub

        Public Sub New()
            InitializeComponent()
            rpt = New ReportDocument
        End Sub

        Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
            CrystalReportViewer1.PrintReport()

            Select Case ReporteID
                Case Type.Reporte.Registro.rptCertificadoAntecedenteJudSiPPPMD_v1
                    GrabarRptCertAntecedenteJudPositivo_v1()
                Case Type.Reporte.Registro.rptCertificadoAntecedenteJudNoPPPMD_v1
                    grabarRptCertAntecedenteNoPresentaPPMD_v1()
                Case Type.Reporte.Registro.rptCertificadoAntecedenteJudNegativo_v1
                    grabarRptCertAntecedenteJudNegativo_v1()
            End Select

            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub ReporteCrystal_v2_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
            Me.Close()
        End Sub

        Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
            Me.Close()
        End Sub

        Private Sub ExportarPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarPDFToolStripMenuItem.Click
            ExportarPDF()
        End Sub

        Private Sub mnuExportWord_Click(sender As Object, e As EventArgs) Handles mnuExportarVarios.Click
            CrystalReportViewer1.ExportReport()
        End Sub
    End Class
End Namespace