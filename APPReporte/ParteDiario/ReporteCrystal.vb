Imports CrystalDecisions.CrystalReports 'borrar
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows 'borrar
Namespace ParteDiario
    Public Class ReporteCrystal
        'Private rpt As ReportDocument = Nothing
        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
#Region "Propiedades_Filtro"
        Private Property IDParteDiario As Integer = -1
        Private Property PenalNombre As String = ""
        Private Property NumeroParteDiario As String = ""
        Private Property Destinatario As String = ""
        Private Property Remitente As String = ""
        Private Property Asunto As String = ""
        Private Property Fecha As String = ""
        Private Property Presentacion As String = ""
        Private Property RelevoInicio As String = ""
        Private Property TieneMovPobInfantil As Boolean = False
#End Region
#Region "Propiedades_Reporte"
        Private intTipoReporte As Type.Reporte.Visita = Type.Reporte.Visita.rpt
        Private ReadOnly Property ReporteID() As Integer
            Get
                Dim intCodigoReporte As Integer = -1

                intCodigoReporte = Me._TipoReporte.GetHashCode

                Return intCodigoReporte
            End Get
        End Property
        Public Property _TipoReporte() As Type.Reporte.Visita
            Get
                Return intTipoReporte
            End Get
            Set(ByVal value As Type.Reporte.Visita)
                intTipoReporte = value
            End Set
        End Property
        Private Property ReporteNombre() As String = ""
        Private Property ReporteNombreFisico() As String = ""
        Private Property ReporteDependencia() As String = ""
        Private Property ReporteModulo() As String = ""
        Private Property ReporteModuloVersion() As String = ""
        Private Property ReporteActa() As String = ""
        Private Property ReporteNumero() As Integer = 0
        Private Property ReporteNumeroExportacion() As Integer = 0
        Private ReadOnly Property ReportePath() As String
            Get
                Dim value As String = ""

                value = Legolas.Configuration.Path.PathReporte & "ParteDiario\"

                Return value
            End Get
        End Property
#Region "Functions"
        Public Sub _fn_PasarParametros(intIDParteDiario As Integer, blnTieneMovPobInfantil As Boolean)


            Me.IDParteDiario = intIDParteDiario       
            Me.TieneMovPobInfantil = blnTieneMovPobInfantil

        End Sub

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

            'Select Case Me._TipoReporte

            '    Case Type.Reporte.Visita.rptAutorizacion
            '        Reporte_Autorizacion()

            '    Case Type.Reporte.Visita.rpt_autorizacion_anexo
            '        Reporte_AutorizacionAnexo()

            '    Case Type.Reporte.Visita.rpt_autorizacion_grupo
            '        Reporte_AutorizacionGrupo()

            '    Case Type.Reporte.Visita.rpt_autorizacion_estadistico
            '        Reporte_AutorizacionEstadistico()

            '    Case Type.Reporte.Visita.rpt_siscrico_visita
            '        Reporte_SicricoVisita()

            '    Case Type.Reporte.Visita.rpt_visita_interno_historial

            '        Reporte_InternoHistorial()

            '    Case Type.Reporte.Visita.rpt_visita_visitante_historial

            '        Reporte_VisitanteHistorial()

            '    Case Type.Reporte.Visita.rpt_visita_movimientos_x_fechas

            '        Reporte_Movimientos_X_Fechas()

            '    Case Type.Reporte.Visita.rpt_visita_resumen_movimientos_x_fechas

            '        Reporte_Movimientos_Resumen_X_Fechas()

            'End Select

            Reporte_ParteDiario()

        End Sub

        Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)

            Dim myTables As Tables = myReportDocument.Database.Tables
            For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables

                Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
                myTableLogonInfo.ConnectionInfo = myConnectionInfo
                myTable.ApplyLogOnInfo(myTableLogonInfo)
            Next

        End Sub

        Private Sub Reporte_ParteDiario()

            Dim strSubReportePerSer As String = "sr_personal_servicio"
            Dim strSubReportePerSerAsi As String = "sr_personal_servicio_asistencia"
            Dim strSRPerSerAnexo As String = "sr_personal_servicio_anexo"
            Dim strSRMovPobCuadro As String = "sr_mov_pob_cuadro"
            Dim strSRMovPobIngresos As String = "sr_mov_pob_ingresos"
            Dim strSRMovPobEgresos As String = "sr_mov_pob_egresos"
            Dim strSRHospitalizados As String = "sr_hospitalizados"
            Dim strSRArrestoDom As String = "sr_arresto_domiciliario"
            Dim strSRMovPobInfantil As String = "sr_pob_infantil"

            Dim strSRDiliCuadroResumen As String = "sr_dil_cua_resumen"
            Dim strSRDiliHospRecibidos As String = "sr_dil_hos_recibidos"
            Dim strSRDiliHospActuales As String = "sr_dil_hospitalizados"
            Dim strSRDiliCentroSalud As String = "sr_dil_centro_salud"
            Dim strSRDiliJudicial As String = "sr_dil_judiciales"
            Dim strSRDiliTopico As String = "sr_dil_topico"

            Dim strSRClasificacion As String = "sr_cla_reu_clasificacion"
            Dim strSRReubicacion As String = "sr_cla_reu_reubicacion"

            Dim strSRAlimentos As String = "sr_alimentos"
            Dim strSROcurrencias As String = "sr_ocurrencia"

            Dim strSRRolSerDiurnoSeg As String = "sr_rol_ser_diurno_seguridad"
            Dim strSRRolSerNocturno As String = "sr_rol_ser_nocturno"
            Dim strSRRolCusHospitalarias As String = "sr_rol_per_cus_hospitalarias"

            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_parte_diario.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "rpt_parte_diario")
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario)
            ''/*paramateros de sistema*/
            rpt.SetParameterValue("p_version", "VERSION 1")
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            '/*paremetros del reporte*/
            rpt.SetParameterValue("p_num_pd", Me.NumeroParteDiario)
            rpt.SetParameterValue("p_destinatario", Me.Destinatario)
            rpt.SetParameterValue("p_penal", Me.PenalNombre)
            rpt.SetParameterValue("p_remitente", Me.Remitente)
            rpt.SetParameterValue("p_remitente_cargo", "xxxxx")
            rpt.SetParameterValue("p_asunto", Me.Asunto)
            rpt.SetParameterValue("p_fecha_pd", Me.Fecha)
            rpt.SetParameterValue("p_ocultar_pob_inf", Me.TieneMovPobInfantil)

            '2.- personal de servicio
            '2.1.- cuadro de personal
            rpt.Subreports.Item(strSubReportePerSer).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSubReportePerSer)
            rpt.SetParameterValue("@opcion", "rpt_pd_personal_servicio_cuadro", strSubReportePerSer)
            rpt.SetParameterValue("@reg_id", -1, strSubReportePerSer)
            rpt.SetParameterValue("@pen_id", -1, strSubReportePerSer)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSubReportePerSer)

            '2.2- personal de servicio asistencia
            rpt.Subreports.Item(strSubReportePerSerAsi).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSubReportePerSerAsi)
            rpt.SetParameterValue("@opcion", "rpt_pd_personal_asistencia", strSubReportePerSerAsi)
            rpt.SetParameterValue("@reg_id", -1, strSubReportePerSerAsi)
            rpt.SetParameterValue("@pen_id", -1, strSubReportePerSerAsi)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSubReportePerSerAsi)

            '2.3- personal anexo
            rpt.Subreports.Item(strSRPerSerAnexo).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRPerSerAnexo)
            rpt.SetParameterValue("@opcion", "rpt_pd_personal_anexo", strSRPerSerAnexo)
            rpt.SetParameterValue("@reg_id", -1, strSRPerSerAnexo)
            rpt.SetParameterValue("@pen_id", -1, strSRPerSerAnexo)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRPerSerAnexo)

            '3- movimiento poblacional
            '3.1- cuadro resumen
            rpt.Subreports.Item(strSRMovPobCuadro).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRMovPobCuadro)
            rpt.SetParameterValue("@opcion", "rpt_pd_movimiento_poblacional_cuadro", strSRMovPobCuadro)
            rpt.SetParameterValue("@reg_id", -1, strSRMovPobCuadro)
            rpt.SetParameterValue("@pen_id", -1, strSRMovPobCuadro)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRMovPobCuadro)

            '3.2- ingresos
            rpt.Subreports.Item(strSRMovPobIngresos).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRMovPobIngresos)
            rpt.SetParameterValue("@opcion", "rpt_pd_ingresos", strSRMovPobIngresos)
            rpt.SetParameterValue("@reg_id", -1, strSRMovPobIngresos)
            rpt.SetParameterValue("@pen_id", -1, strSRMovPobIngresos)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRMovPobIngresos)

            '3.3- egresos
            rpt.Subreports.Item(strSRMovPobEgresos).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRMovPobEgresos)
            rpt.SetParameterValue("@opcion", "rpt_pd_egresos", strSRMovPobEgresos)
            rpt.SetParameterValue("@reg_id", -1, strSRMovPobEgresos)
            rpt.SetParameterValue("@pen_id", -1, strSRMovPobEgresos)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRMovPobEgresos)

            '3.4- hospitalizados
            rpt.Subreports.Item(strSRHospitalizados).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRHospitalizados)
            rpt.SetParameterValue("@opcion", "rpt_pd_hospitalizados", strSRHospitalizados)
            rpt.SetParameterValue("@reg_id", -1, strSRHospitalizados)
            rpt.SetParameterValue("@pen_id", -1, strSRHospitalizados)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRHospitalizados)

            '3.5- arresto domiciliario
            rpt.Subreports.Item(strSRArrestoDom).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRArrestoDom)
            rpt.SetParameterValue("@opcion", "rpt_pd_arresto_domiciliario", strSRArrestoDom)
            rpt.SetParameterValue("@reg_id", -1, strSRArrestoDom)
            rpt.SetParameterValue("@pen_id", -1, strSRArrestoDom)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRArrestoDom)

            '3.6- movimiento poblacion infantil
            rpt.Subreports.Item(strSRMovPobInfantil).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRMovPobInfantil)
            rpt.SetParameterValue("@opcion", "rpt_pd_mov_pob_infantil_cuadro_resumen", strSRMovPobInfantil)
            rpt.SetParameterValue("@reg_id", -1, strSRMovPobInfantil)
            rpt.SetParameterValue("@pen_id", -1, strSRMovPobInfantil)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRMovPobInfantil)

            '4.- diligencias
            'cuadro resumen
            rpt.Subreports.Item(strSRDiliCuadroResumen).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRDiliCuadroResumen)
            rpt.SetParameterValue("@opcion", "rpt_pd_diligencias_cuadro_resumen", strSRDiliCuadroResumen)
            rpt.SetParameterValue("@reg_id", -1, strSRDiliCuadroResumen)
            rpt.SetParameterValue("@pen_id", -1, strSRDiliCuadroResumen)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRDiliCuadroResumen)

            '4.1- diligencias hospitalizados
            rpt.Subreports.Item(strSRDiliHospRecibidos).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRDiliHospRecibidos)
            rpt.SetParameterValue("@opcion", "rpt_pd_dil_hospitalizados_recibidos", strSRDiliHospRecibidos)
            rpt.SetParameterValue("@reg_id", -1, strSRDiliHospRecibidos)
            rpt.SetParameterValue("@pen_id", -1, strSRDiliHospRecibidos)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRDiliHospRecibidos)

            '4.2- diligencias hospitalizados
            rpt.Subreports.Item(strSRDiliHospActuales).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRDiliHospActuales)
            rpt.SetParameterValue("@opcion", "rpt_pd_dil_hospitalizados_actuales", strSRDiliHospActuales)
            rpt.SetParameterValue("@reg_id", -1, strSRDiliHospActuales)
            rpt.SetParameterValue("@pen_id", -1, strSRDiliHospActuales)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRDiliHospActuales)

            '4.3- diligencias centro salud
            rpt.Subreports.Item(strSRDiliCentroSalud).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRDiliCentroSalud)
            rpt.SetParameterValue("@opcion", "rpt_pd_diligencias_centro_salud", strSRDiliCentroSalud)
            rpt.SetParameterValue("@reg_id", -1, strSRDiliCentroSalud)
            rpt.SetParameterValue("@pen_id", -1, strSRDiliCentroSalud)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRDiliCentroSalud)

            '4.4- diligencias judiciales
            rpt.Subreports.Item(strSRDiliJudicial).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRDiliJudicial)
            rpt.SetParameterValue("@opcion", "rpt_pd_diligencias_judiciales", strSRDiliJudicial)
            rpt.SetParameterValue("@reg_id", -1, strSRDiliJudicial)
            rpt.SetParameterValue("@pen_id", -1, strSRDiliJudicial)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRDiliJudicial)

            '4.5- diligencias topicos
            rpt.Subreports.Item(strSRDiliTopico).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRDiliTopico)
            rpt.SetParameterValue("@opcion", "rpt_pd_diligencias_topico", strSRDiliTopico)
            rpt.SetParameterValue("@reg_id", -1, strSRDiliTopico)
            rpt.SetParameterValue("@pen_id", -1, strSRDiliTopico)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRDiliTopico)

            '5- clasificacion y reubicacion
            '5.1- clasificacion
            rpt.Subreports.Item(strSRClasificacion).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRClasificacion)
            rpt.SetParameterValue("@opcion", "rpt_pd_clasificacion", strSRClasificacion)
            rpt.SetParameterValue("@reg_id", -1, strSRClasificacion)
            rpt.SetParameterValue("@pen_id", -1, strSRClasificacion)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRClasificacion)

            '5.2- reubicacion
            rpt.Subreports.Item(strSRReubicacion).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRReubicacion)
            rpt.SetParameterValue("@opcion", "rpt_pd_reubicacion", strSRReubicacion)
            rpt.SetParameterValue("@reg_id", -1, strSRReubicacion)
            rpt.SetParameterValue("@pen_id", -1, strSRReubicacion)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRReubicacion)

            '6- alimentos
            rpt.Subreports.Item(strSRAlimentos).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRAlimentos)
            rpt.SetParameterValue("@opcion", "rpt_pd_alimentacion", strSRAlimentos)
            rpt.SetParameterValue("@reg_id", -1, strSRAlimentos)
            rpt.SetParameterValue("@pen_id", -1, strSRAlimentos)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRAlimentos)
            rpt.SetParameterValue("p_ocultar_ali", Me.TieneMovPobInfantil, strSRAlimentos)

            '7- ocurrencias
            rpt.Subreports.Item(strSROcurrencias).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSROcurrencias)
            rpt.SetParameterValue("@opcion", "rpt_pd_ocurrencia", strSROcurrencias)
            rpt.SetParameterValue("@reg_id", -1, strSROcurrencias)
            rpt.SetParameterValue("@pen_id", -1, strSROcurrencias)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSROcurrencias)

            '8.- rol de servicio
            '8.1.-personal de servicio diruno
            rpt.Subreports.Item(strSRRolSerDiurnoSeg).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRRolSerDiurnoSeg)
            rpt.SetParameterValue("@opcion", "rpt_pd_puesto_servicio_diurno_seguridad", strSRRolSerDiurnoSeg)
            rpt.SetParameterValue("@reg_id", -1, strSRRolSerDiurnoSeg)
            rpt.SetParameterValue("@pen_id", -1, strSRRolSerDiurnoSeg)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRRolSerDiurnoSeg)

            '8.2.- servicio nocturno
            rpt.Subreports.Item(strSRRolSerNocturno).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRRolSerNocturno)
            rpt.SetParameterValue("@opcion", "rpt_pd_puesto_servicio_nocturno", strSRRolSerNocturno)
            rpt.SetParameterValue("@reg_id", -1, strSRRolSerNocturno)
            rpt.SetParameterValue("@pen_id", -1, strSRRolSerNocturno)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRRolSerNocturno)

            '8.3.- custodios hospitalarias
            rpt.Subreports.Item(strSRRolCusHospitalarias).DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", strSRRolCusHospitalarias)
            rpt.SetParameterValue("@opcion", "rpt_pd_diligencias_custodios", strSRRolCusHospitalarias)
            rpt.SetParameterValue("@reg_id", -1, strSRRolCusHospitalarias)
            rpt.SetParameterValue("@pen_id", -1, strSRRolCusHospitalarias)
            rpt.SetParameterValue("@fk_par_dia_id", Me.IDParteDiario, strSRRolCusHospitalarias)

            CrystalReportViewer1.ReportSource = rpt

            'relevo(fin)
            'Siendo las 08.10 horas de la mañana se procede a realizar el relevo correspondiente con el(la) Alcaide entrante del Grupo N° 02 Tca. 
            'Sofia Ruiz Gonzales, con una poblacion Penal de 267 (Doscientos sesenta y siete) internas fiscamente presentes y 13 (trece) menores.

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
        Private Sub ExportarExcel()

            With Me.SaveFileDialog1
                .FileName = ""
                .Filter = "Solo PDF (*.xls)|*.xls"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ExportToExcel(Me.rpt, .FileName, "")
                End If

            End With

        End Sub
        Private Sub ExportToPDF(ByVal Reporte As ReportDocument, ByVal Path As String, ByVal NombreArchivo As String)

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
        Private Sub ExportToExcel(ByVal Reporte As ReportDocument, ByVal Path As String, ByVal NombreArchivo As String)

            Dim vFileName As String
            Dim diskOpts As New DiskFileDestinationOptions

            Try
                With rpt.ExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.Excel
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

        Private Sub PermisosUsuario()

            Me.ExportarAExcelToolStripMenuItem.Visible = False

            If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                Me.ExportarAExcelToolStripMenuItem.Visible = True
            End If

        End Sub
#End Region

        Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click

            Me.Close()

        End Sub

        Private Sub ReporteCrystal_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

            rpt.Dispose()
            CrystalReportViewer1.Dispose()

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

        Private Sub ExportarAExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarAExcelToolStripMenuItem.Click
            ExportarExcel()
        End Sub
    End Class
End Namespace
