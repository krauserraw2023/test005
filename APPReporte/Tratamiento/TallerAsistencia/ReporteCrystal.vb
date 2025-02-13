Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal
Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Registro.Carceleta.Clasificacion
Imports Type.Enumeracion.Clasificacion

Namespace Tratamiento.TallerAsistencia
    Public Class ReporteCrystal
        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Private strFotoPC As String = ""
        Private strFotoPI As String = ""
#Region "Propiedades_Parametricas"
        Public Property _Filtro() As New Entity.Reporte.Tratamiento.Filtro
#End Region
#Region "Propiedades_Reporte"
        Private intTipoReporte As Type.Reporte.Movimiento = Type.Reporte.Movimiento.rpt
        Private ReadOnly Property ReporteID() As Integer
            Get
                Return Me._TipoReporte.GetHashCode
            End Get
        End Property
        Public Property _TipoReporte() As Type.Reporte.Tratamiento.Trabajo.TallerAsistencia
            Get
                Return intTipoReporte
            End Get
            Set(ByVal value As Type.Reporte.Tratamiento.Trabajo.TallerAsistencia)
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
                Return Legolas.Configuration.Path.PathReporte & "Tratamiento\"
            End Get
        End Property
#Region "Functions"
        Private Function FechayHora() As String
            Dim dteHora As Date = Legolas.LBusiness.Globall.DateTime.HoraServer
            Return Legolas.Configuration.Aplication.FechayHora.FechaString & " " & dteHora.ToLongTimeString
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
            Select Case _TipoReporte
                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaLaboral_v1
                    Reporte_PlanillaLaboral_v1()

                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_mov_internoasistencia
                    Reporte_AsistenciaInterno()

                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaIndividual_v1
                    Reporte_PlanillaIndividual()

                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionRegimen
                    Me.Text = "Ficha de clasificacion para determinacion de regimen penitenciario"
                    If _Filtro.IngresoInpeId > 0 Then
                        Reporte_Clasificacion_Regimen_LM()
                    Else
                        Reporte_Clasificacion_Regimen_PROV()
                    End If

                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionEtapa
                    Me.Text = "Ficha de clasificacion para determinacion de etapa en el regimen penitenciario cerrado"
                    If _Filtro.IngresoInpeId > 0 Then
                        Reporte_Clasificacion_Etapa_LM()
                    Else
                        Reporte_Clasificacion_Etapa_PROV()
                    End If

                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionPorRegresion
                    If _Filtro.IngresoInpeId > 0 Then
                        Reporte_Clasificacion_Por_Regresion_LM()
                    Else
                        Reporte_Clasificacion_Por_Regresion_PROV()
                    End If

                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionPorTraslado
                    If _Filtro.IngresoInpeId > 0 Then
                        Reporte_Clasificacion_Por_Traslado_LM()
                    Else
                        Reporte_Clasificacion_Por_Traslado_PROV()
                    End If

            End Select

        End Sub

        Private Sub Reporte_PlanillaLaboral_v1()
            rpt = New ReportDocument

            Dim entCab As New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
            Dim entCabCol As New Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol

            entCab.Codigo = Me._Filtro.IdAux
            entCabCol = (New Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera).Listar(entCab)

            If entCabCol.Count = 0 Then Exit Sub

            entCab = entCabCol.Item(0)

            Dim entTaller As Entity.Tratamiento.TallerAsistencia.TallerMae
            entTaller = (New Bussines.Tratamiento.TallerAsistencia.TallerMae).Listar(entCab.IDTaller)

            rpt.Load(Me.ReportePath & "rpt_planilla_taller_v1.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_planilla_taller")
            rpt.SetParameterValue("@id", Me._Filtro.IdAux)
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
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
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", 0)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)
            rpt.SetParameterValue("p_num_planilla", Format(entCab.IDTaller, "0000") & Format(entCab.Correlativo, "000") & "-" & entCab.Anio) 'correlativo+taller - año
            rpt.SetParameterValue("p_pen_nom", Me._Filtro.PenalNombre)
            rpt.SetParameterValue("p_reg_nom", Me._Filtro.RegionNombre)
            rpt.SetParameterValue("p_pab_taller", entTaller.PabellonTaller)
            rpt.SetParameterValue("p_actividad_laboral", entTaller.NombreTaller)
            rpt.SetParameterValue("p_anio_planilla", entCab.Anio)
            rpt.SetParameterValue("p_nom_mes", entCab.NombreMes)
            rpt.SetParameterValue("p_nom_resp_lab", entTaller.NombreRespControlLab) 'responsable laboral
            rpt.SetParameterValue("p_nom_gest_prod", entTaller.NombreGestorProd) 'gestor de produccion

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_AsistenciaInterno()

            Dim objBss As New Bussines.Reporte.Tratamiento

            rpt = New ReportDocument

            Dim objEntCol As New Entity.Reporte.Tratamiento.FichaCol
            'Dim objCol As New Entity.AntecedentesCol

            objEntCol = objBss.FichaIdentificacion(Me._Filtro.InternoID)

            rpt.Load(Me.ReportePath & "rpt_mov_internoasistencia.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_ficha_interno_asi")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@_fecha", 0)

            For Each obj As Entity.Reporte.Tratamiento.Ficha In objEntCol

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"

                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                End If
                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)

                'rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
                'rpt.SetParameterValue("p_fec_ini", Me._Filtro.FechaInicioStr)
                'rpt.SetParameterValue("p_fec_fin", Me._Filtro.FechaFinStr)
                rpt.SetParameterValue("p_int_est_nom", obj.Estado)
                rpt.SetParameterValue("p_lic_pen_nom", obj.LicenciaPenalNombre)
                rpt.SetParameterValue("p_lic_reg_nom", obj.LicenciaRegionNombre)
                rpt.SetParameterValue("p_nom_asoc", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_alias", If(Trim(obj.AliasNombres) = "", "NR", obj.AliasNombres.ToUpper))
                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))

                If obj.FechaIngresoPenalString = "" Then
                    rpt.SetParameterValue("p_fech_ing_penal", "NR")
                Else
                    Dim d As DateTime
                    d = Legolas.Components.FechaHora.FechaDate(obj.FechaIngresoPenal, True)
                    rpt.SetParameterValue("p_fech_ing_penal", Format(d, "short date") & " " & Format(d, "short time"))
                End If

                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                rpt.SetParameterValue("p_bandas", If(obj.Bandas = "", "NR", obj.Bandas.ToUpper))
                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
                rpt.SetParameterValue("p_lugar_nacimiento", If(obj.NacimientoPais = "", "NR", If(obj.NacimientoPais.ToUpper = "PERU", obj.NacimientoDepartamento.ToUpper & " / " & obj.NacimientoProvincia.ToUpper & " / " & obj.NacimientoDistrito.ToUpper, obj.NacimientoPais.ToUpper & " / " & obj.NacimientoLugar.ToUpper)))
                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
                Exit For
            Next

            rpt.Subreports.Item("cr_ingreso").DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst", "cr_ingreso")
            rpt.SetParameterValue("@opcion", "lst_interno_asi", "cr_ingreso")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "cr_ingreso")
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio, "cr_ingreso")
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin, "cr_ingreso")
            'rpt.SetParameterValue("@reg_id", -1, "cr_ingreso")
            'rpt.SetParameterValue("@pen_id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub
        Private Sub Reporte_PlanillaIndividual()
            Dim objBss As New Bussines.Reporte.Tratamiento
            rpt = New ReportDocument

            Dim entTaller As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            entTaller.InternoID = Me._Filtro.InternoID
            entTaller.PenalID = Me._Filtro.PenalID
            entTaller.RegionID = Me._Filtro.RegionID
            entTaller = (New Bussines.Tratamiento.TallerAsistencia.InternoTaller).Listar(entTaller)


            Dim objEntCol As New Entity.Reporte.Tratamiento.FichaCol
            objEntCol = objBss.FichaIdentificacion(Me._Filtro.InternoID)


            rpt.Load(Me.ReportePath & "rpt_planillaIndividual_taller_v1.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_planilla_individual_taller")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@pen_id", entTaller.PenalID) ' Me._Filtro.PenalID)
            rpt.SetParameterValue("@reg_id", entTaller.RegionID) ' Me._Filtro.RegionID)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", 0)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)
            'Foto
            Dim obj As New Entity.Reporte.Tratamiento.Ficha
            obj = objEntCol.Ficha(0)
            strFotoPC = Legolas.Configuration.Path.PathTemp & entTaller.CodigoRP & Now.Millisecond & "PC.tmp"
            If obj.FotoVersionAntigua = True Then
                Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
            Else
                Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
            End If
            rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)

            rpt.SetParameterValue("p_pen_nom", entTaller.PenalNombre)
            rpt.SetParameterValue("p_reg_nom", entTaller.RegionNombre)
            rpt.SetParameterValue("p_pab_taller", entTaller.PabellonNombre)
            rpt.SetParameterValue("p_actividad_laboral", entTaller.NombreTaller)
            rpt.SetParameterValue("p_fecha_inscripcion", entTaller.FechaInscripcionString)
            rpt.SetParameterValue("p_fecha_retiro", entTaller.FechaRetiroString)
            rpt.SetParameterValue("p_anio_planilla", 0)
            rpt.SetParameterValue("p_nom_mes", "")
            rpt.SetParameterValue("p_nom_resp_lab", entTaller.ResponsableLaboral) 'responsable laboral
            rpt.SetParameterValue("p_nom_gest_prod", entTaller.GestorProduccion) 'gestor de produccion

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Clasificacion_Regimen_PROV()

            rpt = New ReportDocument
            Dim objBssReporteTratamiento As New Bussines.Reporte.Clasificacion
            Dim objEntColInterno As New Entity.Reporte.Clasificacion.DatosInternoCol
            Dim objEntInternoFichaFinal As InternoFicha_BE

            rpt = New ReportDocument

            objEntColInterno = objBssReporteTratamiento.FichaDatosInternoPenalProvincia(Me._Filtro.InternoID, Me._Filtro.InternoIngresoID)

            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_ficha_regimen.rpt")

            Dim strServidor As String = Legolas.Configuration.Data.CNServer
            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
            Dim strUser As String = Legolas.Configuration.Data.CNUser
            Dim strClave As String = Legolas.Configuration.Data.CNPass

            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

            '01.- cargar datos del interno
            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
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

                '02.- cargar datos de la ficha                
                Dim objEntFichaFiltro As New InternoFicha_BE
                objEntFichaFiltro.Codigo = Me._Filtro.IDInternoFichaFinal
                objEntInternoFichaFinal = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

                Dim objEntLista As New List(Of InternoFicha_BE)

                Dim objEntSocial As New InternoFicha_BE
                Dim objEntLegal As New InternoFicha_BE
                Dim objEntPsicolo As New InternoFicha_BE

                If Not objEntInternoFichaFinal Is Nothing Then 'obtener todas las fichas individuales
                    objEntFichaFiltro = New InternoFicha_BE
                    objEntFichaFiltro.CodigoPadre = objEntInternoFichaFinal.Codigo
                    objEntLista = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).ListarGrilla(objEntFichaFiltro)

                    For Each objFila As InternoFicha_BE In objEntLista

                        Select Case objFila.IDFichaTipo
                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                                objEntLegal = objFila

                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                                objEntSocial = objFila

                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                                objEntPsicolo = objFila
                        End Select

                    Next
                End If

                Dim d As DateTime = DateTime.FromFileTime(objEntInternoFichaFinal.FechaClasificacion)
                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))
                rpt.SetParameterValue("p_motiv_cambio_pen", "")
                rpt.SetParameterValue("p_obs_psico", objEntPsicolo.Observacion)
                rpt.SetParameterValue("p_obs_legal", objEntLegal.Observacion)
                rpt.SetParameterValue("p_obs_social", objEntSocial.Observacion)
                rpt.SetParameterValue("p_obs_clasificacion", objEntInternoFichaFinal.Observacion.ToUpper)
                rpt.SetParameterValue("p_num_clasificacion", Format(objEntInternoFichaFinal.NumeroClasificacion, "00"))
                rpt.SetParameterValue("p_penal_destino", objEntInternoFichaFinal.PenalNombre.ToUpper)
                rpt.SetParameterValue("p_regimen_penal", objEntInternoFichaFinal.InternoRegimenNombre.ToUpper)

            Next obj

            '03.- cargar los datos del procedure, subreporte delitos
            rpt.SetParameterValue("@accion", "lst", "srDelitos")
            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso", "srDelitos")
            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
            rpt.SetParameterValue("@fk_int_ing_id", Me._Filtro.InternoIngresoID, "srDelitos")
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")

            '04.- cargar los datos del procedure, subreporte ficha
            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
            rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
            rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

            '05.- cargar los datos del procedure 
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencia")
            rpt.SetParameterValue("@fk_int_id", -1)
            rpt.SetParameterValue("@fk_int_ing_id", -1)
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

            '06.- paremtros del reporte
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub
        Private Sub Reporte_Clasificacion_Regimen_LM()


            Dim entFF As InternoFicha_BE

            Dim objEntColInterno = (New Bussines.Reporte.Clasificacion).FichaDatosInterno_LM(Me._Filtro.InternoID, Me._Filtro.IngresoInpeId)

            rpt = New ReportDocument
            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_ficha_regimen.rpt")

            Dim strServidor As String = Legolas.Configuration.Data.CNServer
            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
            Dim strUser As String = Legolas.Configuration.Data.CNUser
            Dim strClave As String = Legolas.Configuration.Data.CNPass

            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

            '01.- cargar datos del interno
            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno
                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
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

                '02.- cargar datos de la ficha                
                Dim objEntFichaFiltro As New InternoFicha_BE With {.Codigo = Me._Filtro.IDInternoFichaFinal}

                entFF = (New InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

                Dim obsSoc As String = ""
                Dim obsLeg As String = ""
                Dim obsPsi As String = ""

                If Not entFF Is Nothing Then 'obtener todas las fichas individuales
                    objEntFichaFiltro = New InternoFicha_BE With {.CodigoPadre = entFF.Codigo}

                    Dim objEntLista = (New InternoFicha_BL).ListarGrilla(objEntFichaFiltro)

                    For Each objFila As InternoFicha_BE In objEntLista

                        Select Case objFila.IDFichaTipo
                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                                obsLeg = objFila.Observacion

                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                                obsSoc = objFila.Observacion

                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                                obsPsi = objFila.Observacion
                        End Select

                    Next
                End If

                Dim d As DateTime = DateTime.FromFileTime(entFF.FechaClasificacion)
                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))
                rpt.SetParameterValue("p_motiv_cambio_pen", "")
                rpt.SetParameterValue("p_obs_psico", obsPsi)
                rpt.SetParameterValue("p_obs_legal", obsLeg)
                rpt.SetParameterValue("p_obs_social", obsSoc)
                rpt.SetParameterValue("p_obs_clasificacion", entFF.Observacion.ToUpper)
                rpt.SetParameterValue("p_num_clasificacion", Format(entFF.NumeroClasificacion, "00"))
                rpt.SetParameterValue("p_penal_destino", entFF.PenalNombre.ToUpper)
                rpt.SetParameterValue("p_regimen_penal", entFF.InternoRegimenNombre.ToUpper)

            Next obj

            '03.- cargar los datos del procedure, subreporte delitos
            rpt.SetParameterValue("@accion", "lst", "srDelitos")
            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso_LM", "srDelitos")
            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
            rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.IngresoInpeId, "srDelitos")
            rpt.SetParameterValue("@fk_int_ing_id", Me._Filtro.InternoIngresoID, "srDelitos")
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")

            '04.- cargar los datos del procedure, subreporte ficha
            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
            rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
            rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

            '05.- cargar los datos del procedure 
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencia")
            rpt.SetParameterValue("@fk_int_id", -1)
            rpt.SetParameterValue("@fk_int_ing_id", -1)
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

            '06.- paremtros del reporte
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Clasificacion_Por_Traslado_PROV()

            Dim entFF As InternoFicha_BE

            Dim objEntColInterno = (New Bussines.Reporte.Clasificacion).FichaDatosInternoPenalProvincia(Me._Filtro.InternoID, Me._Filtro.InternoIngresoID)

            rpt = New ReportDocument
            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_por_traslado_v1.rpt")

            Dim strServidor As String = Legolas.Configuration.Data.CNServer
            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
            Dim strUser As String = Legolas.Configuration.Data.CNUser
            Dim strClave As String = Legolas.Configuration.Data.CNPass

            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            'rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

            '01.- cargar datos del interno
            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
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

                '02.- cargar datos de la ficha                
                Dim objEntFichaFiltro As New InternoFicha_BE With {.Codigo = Me._Filtro.IDInternoFichaFinal}

                entFF = (New InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

                Dim lstFicOtro = (New InternoFichaOtro_BL()).Listar_rpt(New InternoFichaOtro_BE With {.InternoPenalFichaId = entFF.Codigo})
                Dim objOtroEnt = lstFicOtro.Item(0)

                'datos de la ficha
                Dim d As DateTime = DateTime.FromFileTime(entFF.FechaClasificacion)
                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))

                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
                rpt.SetParameterValue("p_obs_clasificacion", entFF.Observacion.ToUpper)
                rpt.SetParameterValue("p_num_clasificacion", Format(entFF.NumeroClasificacion, "00"))
                rpt.SetParameterValue("p_regimen", entFF.InternoRegimenNombre.ToUpper)
                rpt.SetParameterValue("p_etapa", entFF.InternoEtapaNombre.ToUpper)
                rpt.SetParameterValue("p_pabellon", objOtroEnt.PabellonNombre.ToUpper)
                rpt.SetParameterValue("p_piso", objOtroEnt.Piso.ToUpper)
                rpt.SetParameterValue("p_alero", objOtroEnt.Alero.ToUpper)
                rpt.SetParameterValue("p_ambiente", objOtroEnt.Ambiente.ToUpper)
                rpt.SetParameterValue("p_cama", objOtroEnt.Cama.ToUpper)
                rpt.SetParameterValue("p_causal", objOtroEnt.Causal.ToUpper)
                rpt.SetParameterValue("resol_autoriza", objOtroEnt.ResolAutorizacion.ToUpper)
                rpt.SetParameterValue("p_fec_resol", objOtroEnt.FechaResolucionString.ToUpper)
                rpt.SetParameterValue("p_fec_traslado", objOtroEnt.FechaTrasladoString.ToUpper)
                rpt.SetParameterValue("p_ep_origen_nom", objOtroEnt.PenalOrigenNom.ToUpper)
                rpt.SetParameterValue("p_ep_receptor_nom", objOtroEnt.PenalDestinoNom.ToUpper)
                rpt.SetParameterValue("p_fec_ini_regimen", entFF.FechaInicioRegimenString)
                rpt.SetParameterValue("p_fec_ini_etapa", entFF.FechaInicioEtapaString)

                'Dim d2 As DateTime = DateTime.FromFileTime(objOtroEnt.FechaClasificacionUbicacion)
                'rpt.SetParameterValue("p_fecha_clasif_ubica", "Fecha: " + d2.ToString("dd/MM/yyyy hh:mm tt"))

                'Dim entAux As New InternoFichaDetalle_BE()
                'entAux.IDInternoFicha = objEntInternoFichaFinal.Codigo

                'Dim str As String = ""
                'Dim lstDet As List(Of InternoFichaDetalle_BE) = (New InternoFichaDetalle_BL()).Listar(entAux)
                'For Each det As InternoFichaDetalle_BE In lstDet

                '    '------------------------- cargar indicador -------------------
                '    Dim objEnt As New MaestroIndicador_BE With {
                '                .Codigo = det.IDIndicador
                '                }
                '    Dim entValTmp As MaestroIndicadorCol_BE = (New Bussines.Clasificacion.MaestroIndicador).ListarGrillaAgrupada(objEnt)
                '    Dim abc As String = entValTmp.MaestroIndicador(0).Calificacion

                '    rpt.SetParameterValue("p_calificacion", entValTmp.MaestroIndicador(0).Calificacion)

                'Next det
            Next obj

            '04.- cargar los datos del procedure, subreporte delitos
            rpt.SetParameterValue("@accion", "lst", "srDelitos")
            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso", "srDelitos")
            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
            rpt.SetParameterValue("@fk_int_ing_id", Me._Filtro.InternoIngresoID, "srDelitos")
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")


            '05.- cargar los datos del procedure, subreporte ficha      
            'rpt.SetParameterValue("@accion", "lst", "crResultado")
            'rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
            'rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
            'rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
            'rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

            '06.- cargar los datos del procedure 
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencia")
            rpt.SetParameterValue("@fk_int_id", -1)
            rpt.SetParameterValue("@fk_int_ing_id", -1)
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

            '07.- parametros del reporte
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Clasificacion_Por_Traslado_LM()

            Dim objEntInternoFichaFinal As InternoFicha_BE

            Dim objEntColInterno = (New Bussines.Reporte.Clasificacion).FichaDatosInterno_LM(Me._Filtro.InternoID, Me._Filtro.IngresoInpeId)

            rpt = New ReportDocument
            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_por_traslado_v1.rpt")

            Dim strServidor As String = Legolas.Configuration.Data.CNServer
            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
            Dim strUser As String = Legolas.Configuration.Data.CNUser
            Dim strClave As String = Legolas.Configuration.Data.CNPass

            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            'rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

            '01.- cargar datos del interno
            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
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

                '02.- cargar datos de la ficha                
                Dim objEntFichaFiltro As New InternoFicha_BE With {.Codigo = Me._Filtro.IDInternoFichaFinal}

                objEntInternoFichaFinal = (New InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

                Dim lstFicOtro = (New InternoFichaOtro_BL()).Listar_rpt(New InternoFichaOtro_BE With {.InternoPenalFichaId = objEntInternoFichaFinal.Codigo})
                Dim objOtroEnt = lstFicOtro.Item(0)

                'datos de la ficha
                Dim d As DateTime = DateTime.FromFileTime(objEntInternoFichaFinal.FechaClasificacion)
                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))

                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
                rpt.SetParameterValue("p_obs_clasificacion", objEntInternoFichaFinal.Observacion.ToUpper)
                rpt.SetParameterValue("p_num_clasificacion", Format(objEntInternoFichaFinal.NumeroClasificacion, "00"))
                rpt.SetParameterValue("p_regimen", objEntInternoFichaFinal.InternoRegimenNombre.ToUpper)
                rpt.SetParameterValue("p_etapa", objEntInternoFichaFinal.InternoEtapaNombre.ToUpper)
                rpt.SetParameterValue("p_pabellon", objOtroEnt.PabellonNombre.ToUpper)
                rpt.SetParameterValue("p_piso", objOtroEnt.Piso.ToUpper)
                rpt.SetParameterValue("p_alero", objOtroEnt.Alero.ToUpper)
                rpt.SetParameterValue("p_ambiente", objOtroEnt.Ambiente.ToUpper)
                rpt.SetParameterValue("p_cama", objOtroEnt.Cama.ToUpper)
                rpt.SetParameterValue("p_causal", objOtroEnt.Causal.ToUpper)
                rpt.SetParameterValue("resol_autoriza", objOtroEnt.ResolAutorizacion.ToUpper)
                rpt.SetParameterValue("p_fec_resol", objOtroEnt.FechaResolucionString.ToUpper)
                rpt.SetParameterValue("p_fec_traslado", objOtroEnt.FechaTrasladoString.ToUpper)
                rpt.SetParameterValue("p_ep_origen_nom", objOtroEnt.PenalOrigenNom.ToUpper)
                rpt.SetParameterValue("p_ep_receptor_nom", objOtroEnt.PenalDestinoNom.ToUpper)
                rpt.SetParameterValue("p_fec_ini_regimen", objEntInternoFichaFinal.FechaInicioRegimenString)
                rpt.SetParameterValue("p_fec_ini_etapa", objEntInternoFichaFinal.FechaInicioEtapaString)

            Next obj

            '04.- cargar los datos del procedure, subreporte delitos
            rpt.SetParameterValue("@accion", "lst", "srDelitos")
            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso_LM", "srDelitos")
            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
            rpt.SetParameterValue("@fk_int_ing_id", -1, "srDelitos")
            rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.IngresoInpeId, "srDelitos")
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")

            '06.- cargar los datos del procedure 
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencia")
            rpt.SetParameterValue("@fk_int_id", -1)
            rpt.SetParameterValue("@fk_int_ing_id", -1)
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

            '07.- parametros del reporte
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub


        Private Sub Reporte_Clasificacion_Por_Regresion_PROV()

            Dim objEntColInterno = (New Bussines.Reporte.Clasificacion).FichaDatosInternoPenalProvincia(Me._Filtro.InternoID, Me._Filtro.InternoIngresoID)

            rpt = New ReportDocument
            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_por_regresion_v1.rpt")

            Dim strServidor As String = Legolas.Configuration.Data.CNServer
            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
            Dim strUser As String = Legolas.Configuration.Data.CNUser
            Dim strClave As String = Legolas.Configuration.Data.CNPass

            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            'rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

            '01.- cargar datos del interno
            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
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

                '02.- cargar datos de la ficha                
                Dim objEntFichaFiltro As New InternoFicha_BE
                objEntFichaFiltro.Codigo = Me._Filtro.IDInternoFichaFinal
                Dim objEntInternoFichaFinal = (New InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

                'Dim objEntLista As New List(Of InternoFicha_BE)

                'Dim objEntSocial As New InternoFicha_BE
                'Dim objEntLegal As New InternoFicha_BE
                'Dim objEntPsicolo As New InternoFicha_BE

                'If Not objEntInternoFichaFinal Is Nothing Then 'obtener todas las fichas individuales
                '    objEntFichaFiltro = New InternoFicha_BE
                '    objEntFichaFiltro.CodigoPadre = objEntInternoFichaFinal.Codigo
                '    objEntLista = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).ListarGrilla(objEntFichaFiltro)

                '    For Each objFila As InternoFicha_BE In objEntLista

                '        Select Case objFila.IDFichaTipo
                '            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                '                objEntLegal = objFila

                '            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                '                objEntSocial = objFila

                '            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                '                objEntPsicolo = objFila
                '        End Select

                '    Next
                'End If

                '03.- datos del pabellon
                'Dim intIDInternoPabellon As Integer = -1
                'Dim objBssInternoPabellon As New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoPabellon_BL


                'intIDInternoPabellon = objBssInternoPabellon.fn_ObtenerIDCodigo(objEntInternoFichaFinal.Codigo)


                Dim lstFicOtro = (New InternoFichaOtro_BL()).Listar_rpt(New InternoFichaOtro_BE With {.InternoPenalFichaId = objEntInternoFichaFinal.Codigo})
                Dim objOtroEnt = lstFicOtro.Item(0)

                'datos de la ficha
                Dim d As DateTime = DateTime.FromFileTime(objEntInternoFichaFinal.FechaClasificacion)
                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))

                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
                rpt.SetParameterValue("p_obs_clasificacion", objEntInternoFichaFinal.Observacion.ToUpper)
                rpt.SetParameterValue("p_num_clasificacion", Format(objEntInternoFichaFinal.NumeroClasificacion, "00"))
                rpt.SetParameterValue("p_etapa", objEntInternoFichaFinal.InternoEtapaNombre.ToUpper)
                rpt.SetParameterValue("p_pabellon", objOtroEnt.PabellonNombre.ToUpper)
                rpt.SetParameterValue("p_piso", objOtroEnt.Piso.ToUpper)
                rpt.SetParameterValue("p_alero", objOtroEnt.Alero.ToUpper)
                rpt.SetParameterValue("p_ambiente", objOtroEnt.Ambiente.ToUpper)
                rpt.SetParameterValue("p_cama", objOtroEnt.Cama.ToUpper)
                rpt.SetParameterValue("p_causal", objOtroEnt.Causal.ToUpper)
                rpt.SetParameterValue("resol_autoriza", objOtroEnt.ResolAutorizacion.ToUpper)
                rpt.SetParameterValue("p_fec_resol", objOtroEnt.FechaResolucionString.ToUpper)
                rpt.SetParameterValue("p_fec_traslado", objOtroEnt.FechaTrasladoString.ToUpper)
                rpt.SetParameterValue("p_ep_origen_nom", objOtroEnt.PenalOrigenNom.ToUpper)
                rpt.SetParameterValue("p_ep_receptor_nom", objOtroEnt.PenalDestinoNom.ToUpper)
                rpt.SetParameterValue("p_regimen_ep_origen", objOtroEnt.RegimenNombre_PenalOrigen.ToUpper)
                rpt.SetParameterValue("p_etapa_ep_origen", objOtroEnt.EtapaNombre_PenalOrigen.ToUpper)

                Dim d2 As DateTime = DateTime.FromFileTime(objOtroEnt.FechaClasificacionUbicacion)
                rpt.SetParameterValue("p_fecha_clasif_ubica", "Fecha: " + d2.ToString("dd/MM/yyyy hh:mm tt"))

                Dim entAux As New InternoFichaDetalle_BE() With {.IDInternoFicha = objEntInternoFichaFinal.Codigo}

                Dim lstDet = (New InternoFichaDetalle_BL()).Listar(entAux)
                For Each det As InternoFichaDetalle_BE In lstDet

                    '------------------------- cargar indicador -------------------
                    Dim objEnt As New MaestroIndicador_BE With {.Codigo = det.IDIndicador}
                    Dim entValTmp As MaestroIndicadorCol_BE = (New Bussines.Clasificacion.MaestroIndicador).ListarGrillaAgrupada(objEnt)

                    rpt.SetParameterValue("p_calificacion", entValTmp.MaestroIndicador(0).Calificacion)

                Next det
            Next obj

            '04.- cargar los datos del procedure, subreporte delitos
            rpt.SetParameterValue("@accion", "lst", "srDelitos")
            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso", "srDelitos")
            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
            rpt.SetParameterValue("@fk_int_ing_id", Me._Filtro.InternoIngresoID, "srDelitos")
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")


            '05.- cargar los datos del procedure, subreporte ficha      
            'rpt.SetParameterValue("@accion", "lst", "crResultado")
            'rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
            'rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
            'rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
            'rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

            '06.- cargar los datos del procedure 
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencia")
            rpt.SetParameterValue("@fk_int_id", -1)
            rpt.SetParameterValue("@fk_int_ing_id", -1)
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

            '07.- parametros del reporte
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Clasificacion_Por_Regresion_LM()

            Dim objEntColInterno = (New Bussines.Reporte.Clasificacion).FichaDatosInterno_LM(Me._Filtro.InternoID, Me._Filtro.IngresoInpeId)

            rpt = New ReportDocument
            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_por_regresion_v1.rpt")

            Dim strServidor As String = Legolas.Configuration.Data.CNServer
            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
            Dim strUser As String = Legolas.Configuration.Data.CNUser
            Dim strClave As String = Legolas.Configuration.Data.CNPass

            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

            '01.- cargar datos del interno
            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
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

                '02.- cargar datos de la ficha                
                Dim objEntFichaFiltro As New InternoFicha_BE With {.Codigo = Me._Filtro.IDInternoFichaFinal}

                Dim entFF = (New InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

                Dim lstFicOtro = (New InternoFichaOtro_BL()).Listar_rpt(New InternoFichaOtro_BE With {.InternoPenalFichaId = entFF.Codigo})
                Dim entOtro = lstFicOtro.Item(0)

                'datos de la ficha
                Dim d As DateTime = DateTime.FromFileTime(entFF.FechaClasificacion)
                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))

                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
                rpt.SetParameterValue("p_obs_clasificacion", entFF.Observacion.ToUpper)
                rpt.SetParameterValue("p_num_clasificacion", Format(entFF.NumeroClasificacion, "00"))
                rpt.SetParameterValue("p_etapa", entFF.InternoEtapaNombre.ToUpper)
                rpt.SetParameterValue("p_pabellon", entOtro.PabellonNombre.ToUpper)
                rpt.SetParameterValue("p_piso", entOtro.Piso.ToUpper)
                rpt.SetParameterValue("p_alero", entOtro.Alero.ToUpper)
                rpt.SetParameterValue("p_ambiente", entOtro.Ambiente.ToUpper)
                rpt.SetParameterValue("p_cama", entOtro.Cama.ToUpper)
                rpt.SetParameterValue("p_causal", entOtro.Causal.ToUpper)
                rpt.SetParameterValue("resol_autoriza", entOtro.ResolAutorizacion.ToUpper)
                rpt.SetParameterValue("p_fec_resol", entOtro.FechaResolucionString.ToUpper)
                rpt.SetParameterValue("p_fec_traslado", entOtro.FechaTrasladoString.ToUpper)
                rpt.SetParameterValue("p_ep_origen_nom", entOtro.PenalOrigenNom.ToUpper)
                rpt.SetParameterValue("p_ep_receptor_nom", entOtro.PenalDestinoNom.ToUpper)
                rpt.SetParameterValue("p_regimen_ep_origen", entOtro.RegimenNombre_PenalOrigen.ToUpper)
                rpt.SetParameterValue("p_etapa_ep_origen", entOtro.EtapaNombre_PenalOrigen.ToUpper)

                Dim d2 As DateTime = DateTime.FromFileTime(entOtro.FechaClasificacionUbicacion)
                rpt.SetParameterValue("p_fecha_clasif_ubica", "Fecha: " + d2.ToString("dd/MM/yyyy hh:mm tt"))

                Dim entAux As New InternoFichaDetalle_BE() With {.IDInternoFicha = entFF.Codigo}

                Dim lstDet = (New InternoFichaDetalle_BL()).Listar(entAux)
                For Each det As InternoFichaDetalle_BE In lstDet
                    '------------------------- cargar indicador -------------------
                    Dim objEnt As New MaestroIndicador_BE With {.Codigo = det.IDIndicador}
                    Dim entValTmp = (New Bussines.Clasificacion.MaestroIndicador).ListarGrillaAgrupada(objEnt)

                    rpt.SetParameterValue("p_calificacion", entValTmp.MaestroIndicador(0).Calificacion)

                Next det
            Next obj

            '04.- cargar los datos del procedure, subreporte delitos
            rpt.SetParameterValue("@accion", "lst", "srDelitos")
            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso_LM", "srDelitos")
            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
            rpt.SetParameterValue("@fk_int_ing_id", -1, "srDelitos")
            rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.IngresoInpeId, "srDelitos")
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")

            '06.- cargar los datos del procedure 
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencia")
            rpt.SetParameterValue("@fk_int_id", -1)
            rpt.SetParameterValue("@fk_int_ing_id", -1)
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

            '07.- parametros del reporte
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub
        Private Sub Reporte_Clasificacion_Etapa_PROV()
            Dim ffFinalizado As String = ""

            rpt = New ReportDocument

            Dim objEntColInterno = (New Bussines.Reporte.Clasificacion).FichaDatosInternoPenalProvincia(Me._Filtro.InternoID, Me._Filtro.InternoIngresoID)

            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_ficha_etapa.rpt")

            Dim strServidor As String = Legolas.Configuration.Data.CNServer
            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
            Dim strUser As String = Legolas.Configuration.Data.CNUser
            Dim strClave As String = Legolas.Configuration.Data.CNPass

            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

            '01.- cargar datos del interno
            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
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

                '02.- cargar datos de la ficha                
                Dim objEntFichaFiltro As New InternoFicha_BE With {
                                    .Codigo = Me._Filtro.IDInternoFichaFinal
                                    }
                Dim entFF = (New InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

                Dim objEntSocial As String = ""
                Dim objEntLegal As String = ""
                Dim objEntPsicolo As String = ""

                objEntFichaFiltro = New InternoFicha_BE With {.CodigoPadre = entFF.Codigo}

                Dim objEntLista = (New InternoFicha_BL).ListarGrilla(objEntFichaFiltro)

                For Each objFila As InternoFicha_BE In objEntLista
                    Select Case objFila.IDFichaTipo
                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
                            objEntLegal = objFila.Observacion

                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
                            objEntSocial = objFila.Observacion

                        Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
                            objEntPsicolo = objFila.Observacion
                    End Select
                Next


                '03.- datos del pabellon

                Dim bssIntPab As New InternoPabellon_BL
                Dim entIntPab = bssIntPab.Listar(bssIntPab.fn_ObtenerIDCodigo(entFF.Codigo))

                'datos de la ficha
                Dim d As DateTime = DateTime.FromFileTime(entFF.FechaClasificacion)
                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))
                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
                rpt.SetParameterValue("p_obs_psico", objEntPsicolo)
                rpt.SetParameterValue("p_obs_legal", objEntLegal)
                rpt.SetParameterValue("p_obs_social", objEntSocial)
                rpt.SetParameterValue("p_obs_clasificacion", entFF.Observacion.ToUpper)
                rpt.SetParameterValue("p_num_clasificacion", Format(entFF.NumeroClasificacion, "00"))
                rpt.SetParameterValue("p_etapa", entFF.InternoEtapaNombre.ToUpper)
                'datos del pabellon
                rpt.SetParameterValue("p_regimen_penal", If(entIntPab IsNot Nothing, entIntPab.RegimenNombre.ToUpper(), "ORDINARIO"))
                rpt.SetParameterValue("p_pabellon", If(entIntPab IsNot Nothing, entIntPab.PabellonNombre.ToUpper(), ""))
                rpt.SetParameterValue("p_piso", If(entIntPab IsNot Nothing, entIntPab.Piso.ToUpper(), ""))
                rpt.SetParameterValue("p_alero", If(entIntPab IsNot Nothing, entIntPab.Ala.ToUpper(), ""))
                rpt.SetParameterValue("p_ambiente", If(entIntPab IsNot Nothing, entIntPab.Ambiente.ToUpper(), ""))
                rpt.SetParameterValue("p_cama", If(entIntPab IsNot Nothing, entIntPab.Cama.ToUpper(), ""))
                rpt.SetParameterValue("p_obs_jefe_ott", If(entIntPab IsNot Nothing, entIntPab.Observacion.ToUpper(), ""))
                rpt.SetParameterValue("p_pert_org_criminal", entFF.PerteneceOrgCriminal)

                ffFinalizado = entFF.EstadoNombre
            Next obj

            '04.- cargar los datos del procedure, subreporte delitos
            rpt.SetParameterValue("@accion", "lst", "srDelitos")
            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso", "srDelitos")
            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
            rpt.SetParameterValue("@fk_int_ing_id", Me._Filtro.InternoIngresoID, "srDelitos")
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")

            '05.- cargar los datos del procedure, subreporte ficha      
            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
            rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
            rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

            '06.- cargar los datos del procedure 
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencia")
            rpt.SetParameterValue("@fk_int_id", -1)
            rpt.SetParameterValue("@fk_int_ing_id", -1)
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

            '07.- parametros del reporte
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

            rpt.SetParameterValue("p_rpt_vista_previa", If(ffFinalizado = "PENDIENTE", True, False))

            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Clasificacion_Etapa_LM()
            Dim ffFinalizado As String = ""

            rpt = New ReportDocument

            Dim objEntColInterno = (New Bussines.Reporte.Clasificacion).FichaDatosInterno_LM(Me._Filtro.InternoID, Me._Filtro.IngresoInpeId)

            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_ficha_etapa.rpt")

            Dim strServidor As String = Legolas.Configuration.Data.CNServer
            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
            Dim strUser As String = Legolas.Configuration.Data.CNUser
            Dim strClave As String = Legolas.Configuration.Data.CNPass

            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

            '01.- cargar datos del interno
            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

                If obj.FotoVersionAntigua = True Then
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
                Else
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
                End If

                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
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

                '02.- cargar datos de la ficha                
                Dim objEntFichaFiltro As New InternoFicha_BE With {
                                    .Codigo = Me._Filtro.IDInternoFichaFinal
                                    }
                Dim entFF = (New InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

                objEntFichaFiltro = New InternoFicha_BE With {
                                        .IDInternoIngreso = entFF.IDInternoIngreso,
                                        .IDInternoIngresoInpe = entFF.IDInternoIngresoInpe,
                                        .CodigoPadre = entFF.Codigo
                                        }

                Dim objEntLista = (New InternoFicha_BL).ListarGrilla(objEntFichaFiltro)

                Dim entFSoc As String = ""
                Dim entFLeg As String = ""
                Dim entFPsi As String = ""

                For Each f As InternoFicha_BE In objEntLista
                    Select Case f.IDFichaTipo
                        Case enmTipoFicha.Legal
                            entFLeg = f.Observacion

                        Case enmTipoFicha.Social
                            entFSoc = f.Observacion

                        Case enmTipoFicha.Psicologica
                            entFPsi = f.Observacion
                    End Select
                Next

                '03.- datos del pabellon
                Dim bssIntPab As New InternoPabellon_BL
                Dim entIntPab = bssIntPab.Listar(bssIntPab.fn_ObtenerIDCodigo(entFF.Codigo))

                'datos de la ficha
                Dim d As DateTime = DateTime.FromFileTime(entFF.FechaClasificacion)
                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))
                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
                rpt.SetParameterValue("p_obs_psico", entFPsi)
                rpt.SetParameterValue("p_obs_legal", entFLeg)
                rpt.SetParameterValue("p_obs_social", entFSoc)
                rpt.SetParameterValue("p_obs_clasificacion", entFF.Observacion.ToUpper)
                rpt.SetParameterValue("p_num_clasificacion", Format(entFF.NumeroClasificacion, "00"))
                rpt.SetParameterValue("p_etapa", entFF.InternoEtapaNombre.ToUpper)
                'datos del pabellon
                rpt.SetParameterValue("p_regimen_penal", If(entIntPab IsNot Nothing, entIntPab.RegimenNombre.ToUpper(), "ORDINARIO"))
                rpt.SetParameterValue("p_pabellon", If(entIntPab IsNot Nothing, entIntPab.PabellonNombre.ToUpper(), ""))
                rpt.SetParameterValue("p_piso", If(entIntPab IsNot Nothing, entIntPab.Piso.ToUpper(), ""))
                rpt.SetParameterValue("p_alero", If(entIntPab IsNot Nothing, entIntPab.Ala.ToUpper(), ""))
                rpt.SetParameterValue("p_ambiente", If(entIntPab IsNot Nothing, entIntPab.Ambiente.ToUpper(), ""))
                rpt.SetParameterValue("p_cama", If(entIntPab IsNot Nothing, entIntPab.Cama.ToUpper(), ""))
                rpt.SetParameterValue("p_obs_jefe_ott", If(entIntPab IsNot Nothing, entIntPab.Observacion.ToUpper(), ""))
                rpt.SetParameterValue("p_pert_org_criminal", entFF.PerteneceOrgCriminal)

                ffFinalizado = entFF.EstadoNombre
            Next obj

            '04.- cargar los datos del procedure, subreporte delitos
            rpt.SetParameterValue("@accion", "lst", "srDelitos")
            rpt.SetParameterValue("@opcion", "lst_exp_ficha", "srDelitos")
            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
            rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.IngresoInpeId, "srDelitos")
            rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "srDelitos")

            '05.- cargar los datos del procedure, subreporte ficha      
            rpt.SetParameterValue("@accion", "lst", "crResultado")
            rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
            rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
            rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
            rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

            '06.- cargar los datos del procedure 
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_licencia")
            rpt.SetParameterValue("@fk_int_id", -1)
            rpt.SetParameterValue("@fk_int_ing_id", -1)
            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

            '07.- parametros del reporte
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

            rpt.SetParameterValue("p_rpt_vista_previa", If(ffFinalizado = "PENDIENTE", False, True))

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

                If Legolas.Components.Archivo.FileExiste(vFileName) Then Legolas.Components.Archivo.FileDelete(vFileName)

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
            Catch ex As Exception

            End Try

        End Sub

        Private Sub ReporteCrystal_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefault()
            Me.WindowState = FormWindowState.Maximized

        End Sub

        Private Sub ReporteCrystal_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarPropiedadesReporte()
            Me.Text = "Control Asistencia Movimiento Resumen"  ' Me.ReporteNombre
            VerReporte()

        End Sub

        Private Sub ImpirmirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImpirmirToolStripMenuItem.Click

            Me.CrystalReportViewer1.PrintReport()

        End Sub

        Private Sub ExportarPDFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarPDFToolStripMenuItem.Click

            ExportarPDF()

        End Sub

    End Class
End Namespace


'EL SIGUIENTE CODIGO ES DE MI PROYECTO MODIFICADO, DIFERENTE A LA VERSION DE PUBLICACION DE JHON


''''Imports CrystalDecisions.CrystalReports 'borrar
''''Imports CrystalDecisions.CrystalReports.Engine
''''Imports CrystalDecisions.Shared
''''Imports CrystalDecisions.ReportSource
''''Imports CrystalDecisions.Windows 'borrar
''''Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal
''''Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
''''Imports Entity.Registro.Carceleta.Clasificacion
''''Imports System.Linq

''''Namespace Tratamiento.TallerAsistencia
''''    Public Class ReporteCrystal
''''        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
''''        Private strFotoPC As String = ""
''''        Private strFotoPI As String = ""
''''#Region "Propiedades_Parametricas"
''''        Public Property _Filtro() As New Entity.Reporte.Tratamiento.Filtro
''''#End Region
''''#Region "Propiedades_Reporte"
''''        Private intTipoReporte As Type.Reporte.Movimiento = Type.Reporte.Movimiento.rpt
''''        Private ReadOnly Property ReporteID() As Integer
''''            Get
''''                Dim intCodigoReporte As Integer = -1

''''                intCodigoReporte = Me._TipoReporte.GetHashCode

''''                Return intCodigoReporte
''''            End Get
''''        End Property
''''        Public Property _TipoReporte() As Type.Reporte.Tratamiento.Trabajo.TallerAsistencia
''''            Get
''''                Return intTipoReporte
''''            End Get
''''            Set(ByVal value As Type.Reporte.Tratamiento.Trabajo.TallerAsistencia)
''''                intTipoReporte = value
''''            End Set
''''        End Property
''''        Private Property ReporteNombre() As String = ""
''''        Private Property ReporteNombreFisico() As String = ""
''''        Private Property ReporteDependencia() As String = ""
''''        Private Property ReporteModulo() As String = ""
''''        Private Property ReporteModuloVersion() As String = ""
''''        Private Property ReporteActa() As String = ""
''''        Private Property ReporteNumero() As Integer = 0
''''        Private Property ReporteNumeroExportacion() As Integer = 0
''''        Private ReadOnly Property ReportePath() As String
''''            Get
''''                Dim value As String = ""

''''                value = Legolas.Configuration.Path.PathReporte & "Tratamiento\"

''''                Return value
''''            End Get
''''        End Property
''''#Region "Functions"
''''        Private Function FechayHora() As String

''''            Dim strValue As String = ""
''''            Dim strFecha As String = Legolas.Configuration.Aplication.FechayHora.FechaString
''''            Dim dteHora As Date = Now.ToShortTimeString

''''            dteHora = Legolas.LBusiness.Globall.DateTime.HoraServer
''''            strValue = strFecha & " " & dteHora.ToLongTimeString
''''            Return strValue

''''        End Function
''''#End Region
''''#End Region
''''#Region "Reporte"
''''        Private Sub ListarPropiedadesReporte()

''''            Dim objEnt As New Legolas.LEntity.Globall.Reporte
''''            Dim objBssRpt As New Legolas.LBusiness.Globall.Reporte

''''            objEnt = objBssRpt.Listar(Me.ReporteID)

''''            With objEnt
''''                Me.ReporteNombre = .Nombre
''''                Me.ReporteNombreFisico = .NombreFisico
''''                Me.ReporteDependencia = .DependenciaNombre
''''                Me.ReporteModulo = .Modulo
''''                Me.ReporteModuloVersion = .Version
''''                Me.ReporteActa = .Acta
''''            End With

''''        End Sub
''''        Private Sub VerReporte()
''''            Select Case _TipoReporte
''''                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaLaboral_v1
''''                    Reporte_PlanillaLaboral_v1()

''''                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_mov_internoasistencia
''''                    Reporte_AsistenciaInterno()

''''                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaIndividual_v1
''''                    Reporte_PlanillaIndividual()

''''                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionRegimen
''''                    Me.Text = "Ficha de clasificacion para determinacion de regimen penitenciario"
''''                    If _Filtro.IngresoInpeId > 0 Then
''''                        Reporte_Clasificacion_Regimen_LM()
''''                    Else
''''                        Reporte_Clasificacion_Regimen_PROV()
''''                    End If

''''                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionEtapa
''''                    Me.Text = "Ficha de clasificacion para determinacion de etapa en el regimen penitenciario cerrado"
''''                    If _Filtro.IngresoInpeId > 0 Then
''''                        Reporte_Clasificacion_Etapa_LM()
''''                    Else
''''                        Reporte_Clasificacion_Etapa_PROV()
''''                    End If

''''                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionPorRegresion
''''                    If _Filtro.IngresoInpeId > 0 Then
''''                        Reporte_Clasificacion_Por_Regresion_LM()
''''                    Else
''''                        Reporte_Clasificacion_Por_Regresion_PROV()
''''                    End If

''''                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionPorTraslado
''''                    If _Filtro.IngresoInpeId > 0 Then
''''                        Reporte_Clasificacion_Por_Traslado_LM
''''                    Else
''''                        Reporte_Clasificacion_Por_Traslado_PROV()
''''                    End If

''''            End Select

''''        End Sub

''''        Private Sub Reporte_PlanillaLaboral_v1()
''''            rpt = New ReportDocument

''''            Dim entCab As New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
''''            Dim entCabCol As New Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol

''''            entCab.Codigo = Me._Filtro.IdAux
''''            entCabCol = (New Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera).Listar(entCab)

''''            If entCabCol.Count = 0 Then Exit Sub

''''            entCab = entCabCol.Item(0)

''''            Dim entTaller As Entity.Tratamiento.TallerAsistencia.TallerMae
''''            entTaller = (New Bussines.Tratamiento.TallerAsistencia.TallerMae).Listar(entCab.IDTaller)

''''            rpt.Load(Me.ReportePath & "rpt_planilla_taller_v1.rpt")

''''            rpt.DataSourceConnections(0).SetConnection(
''''            Legolas.Configuration.Data.CNServer,
''''            Legolas.Configuration.Data.CNDataBase,
''''            Legolas.Configuration.Data.CNUser,
''''            Legolas.Configuration.Data.CNPass)

''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_rpt_planilla_taller")
''''            rpt.SetParameterValue("@id", Me._Filtro.IdAux)
''''            rpt.SetParameterValue("@pen_id", -1)
''''            rpt.SetParameterValue("@int_id", -1)
''''            rpt.SetParameterValue("@int_ing_id", -1)
''''            rpt.SetParameterValue("@int_exp_id", -1)
''''            rpt.SetParameterValue("@int_sen_id", -1)
''''            rpt.SetParameterValue("@int_del_id", -1)
''''            rpt.SetParameterValue("@nac_id", -1)
''''            rpt.SetParameterValue("@cuadro", -1)
''''            rpt.SetParameterValue("@fec_ini", 0)
''''            rpt.SetParameterValue("@fec_fin", 0)
''''            rpt.SetParameterValue("@_fecha", 0)
''''            rpt.SetParameterValue("@reg_id", -1)
''''            rpt.SetParameterValue("@tip_band_id", -1)
''''            rpt.SetParameterValue("@ban_id", -1)
''''            rpt.SetParameterValue("@int_rnc_id", -1)
''''            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
''''            rpt.SetParameterValue("@mostrar_doc_anulado", 0)
''''            rpt.SetParameterValue("@fk_ing_inp_id", -1)
''''            rpt.SetParameterValue("@n_aut_amb", -1)
''''            rpt.SetParameterValue("p_num_planilla", Format(entCab.IDTaller, "0000") & Format(entCab.Correlativo, "000") & "-" & entCab.Anio) 'correlativo+taller - año
''''            rpt.SetParameterValue("p_pen_nom", Me._Filtro.PenalNombre)
''''            rpt.SetParameterValue("p_reg_nom", Me._Filtro.RegionNombre)
''''            rpt.SetParameterValue("p_pab_taller", entTaller.PabellonTaller)
''''            rpt.SetParameterValue("p_actividad_laboral", entTaller.NombreTaller)
''''            rpt.SetParameterValue("p_anio_planilla", entCab.Anio)
''''            rpt.SetParameterValue("p_nom_mes", entCab.NombreMes)
''''            rpt.SetParameterValue("p_nom_resp_lab", entTaller.NombreRespControlLab) 'responsable laboral
''''            rpt.SetParameterValue("p_nom_gest_prod", entTaller.NombreGestorProd) 'gestor de produccion

''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub

''''        Private Sub Reporte_AsistenciaInterno()

''''            Dim objBss As New Bussines.Reporte.Tratamiento

''''            rpt = New ReportDocument

''''            Dim objEntCol As New Entity.Reporte.Tratamiento.FichaCol
''''            'Dim objCol As New Entity.AntecedentesCol

''''            objEntCol = objBss.FichaIdentificacion(Me._Filtro.InternoID)

''''            rpt.Load(Me.ReportePath & "rpt_mov_internoasistencia.rpt")

''''            rpt.DataSourceConnections(0).SetConnection(
''''            Legolas.Configuration.Data.CNServer,
''''            Legolas.Configuration.Data.CNDataBase,
''''            Legolas.Configuration.Data.CNUser,
''''            Legolas.Configuration.Data.CNPass)
''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_ficha_interno_asi")
''''            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
''''            rpt.SetParameterValue("@int_ing_id", -1)
''''            rpt.SetParameterValue("@pen_id", -1)
''''            rpt.SetParameterValue("@reg_id", -1)
''''            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
''''            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
''''            rpt.SetParameterValue("@_fecha", 0)

''''            For Each obj As Entity.Reporte.Tratamiento.Ficha In objEntCol

''''                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"

''''                If obj.FotoVersionAntigua = True Then
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
''''                Else
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
''''                End If
''''                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)

''''                'rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
''''                'rpt.SetParameterValue("p_fec_ini", Me._Filtro.FechaInicioStr)
''''                'rpt.SetParameterValue("p_fec_fin", Me._Filtro.FechaFinStr)
''''                rpt.SetParameterValue("p_int_est_nom", obj.Estado)
''''                rpt.SetParameterValue("p_lic_pen_nom", obj.LicenciaPenalNombre)
''''                rpt.SetParameterValue("p_lic_reg_nom", obj.LicenciaRegionNombre)
''''                rpt.SetParameterValue("p_nom_asoc", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
''''                rpt.SetParameterValue("p_alias", If(Trim(obj.AliasNombres) = "", "NR", obj.AliasNombres.ToUpper))
''''                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))

''''                If obj.FechaIngresoPenalString = "" Then
''''                    rpt.SetParameterValue("p_fech_ing_penal", "NR")
''''                Else
''''                    Dim d As DateTime
''''                    d = Legolas.Components.FechaHora.FechaDate(obj.FechaIngresoPenal, True)
''''                    rpt.SetParameterValue("p_fech_ing_penal", Format(d, "short date") & " " & Format(d, "short time"))
''''                End If

''''                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
''''                rpt.SetParameterValue("p_bandas", If(obj.Bandas = "", "NR", obj.Bandas.ToUpper))
''''                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
''''                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
''''                rpt.SetParameterValue("p_lugar_nacimiento", If(obj.NacimientoPais = "", "NR", If(obj.NacimientoPais.ToUpper = "PERU", obj.NacimientoDepartamento.ToUpper & " / " & obj.NacimientoProvincia.ToUpper & " / " & obj.NacimientoDistrito.ToUpper, obj.NacimientoPais.ToUpper & " / " & obj.NacimientoLugar.ToUpper)))
''''                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
''''                Exit For
''''            Next

''''            rpt.Subreports.Item("cr_ingreso").DataSourceConnections(0).SetConnection(
''''            Legolas.Configuration.Data.CNServer,
''''            Legolas.Configuration.Data.CNDataBase,
''''            Legolas.Configuration.Data.CNUser,
''''            Legolas.Configuration.Data.CNPass)

''''            rpt.SetParameterValue("@accion", "lst", "cr_ingreso")
''''            rpt.SetParameterValue("@opcion", "lst_interno_asi", "cr_ingreso")
''''            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "cr_ingreso")
''''            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio, "cr_ingreso")
''''            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin, "cr_ingreso")
''''            'rpt.SetParameterValue("@reg_id", -1, "cr_ingreso")
''''            'rpt.SetParameterValue("@pen_id", -1)

''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub
''''        Private Sub Reporte_PlanillaIndividual()
''''            Dim objBss As New Bussines.Reporte.Tratamiento
''''            rpt = New ReportDocument

''''            Dim entTaller As New Entity.Tratamiento.TallerAsistencia.InternoTaller
''''            entTaller.InternoID = Me._Filtro.InternoID
''''            entTaller.PenalID = Me._Filtro.PenalID
''''            entTaller.RegionID = Me._Filtro.RegionID
''''            entTaller = (New Bussines.Tratamiento.TallerAsistencia.InternoTaller).Listar(entTaller)


''''            Dim objEntCol As New Entity.Reporte.Tratamiento.FichaCol
''''            objEntCol = objBss.FichaIdentificacion(Me._Filtro.InternoID)


''''            rpt.Load(Me.ReportePath & "rpt_planillaIndividual_taller_v1.rpt")

''''            rpt.DataSourceConnections(0).SetConnection(
''''            Legolas.Configuration.Data.CNServer,
''''            Legolas.Configuration.Data.CNDataBase,
''''            Legolas.Configuration.Data.CNUser,
''''            Legolas.Configuration.Data.CNPass)

''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_rpt_planilla_individual_taller")
''''            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
''''            rpt.SetParameterValue("@int_ing_id", -1)
''''            rpt.SetParameterValue("@int_exp_id", -1)
''''            rpt.SetParameterValue("@int_sen_id", -1)
''''            rpt.SetParameterValue("@int_del_id", -1)
''''            rpt.SetParameterValue("@nac_id", -1)
''''            rpt.SetParameterValue("@cuadro", -1)
''''            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
''''            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
''''            rpt.SetParameterValue("@_fecha", 0)
''''            rpt.SetParameterValue("@pen_id", entTaller.PenalID) ' Me._Filtro.PenalID)
''''            rpt.SetParameterValue("@reg_id", entTaller.RegionID) ' Me._Filtro.RegionID)
''''            rpt.SetParameterValue("@tip_band_id", -1)
''''            rpt.SetParameterValue("@ban_id", -1)
''''            rpt.SetParameterValue("@int_rnc_id", -1)
''''            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
''''            rpt.SetParameterValue("@mostrar_doc_anulado", 0)
''''            rpt.SetParameterValue("@fk_ing_inp_id", -1)
''''            rpt.SetParameterValue("@n_aut_amb", -1)
''''            'Foto
''''            Dim obj As New Entity.Reporte.Tratamiento.Ficha
''''            obj = objEntCol.Ficha(0)
''''            strFotoPC = Legolas.Configuration.Path.PathTemp & entTaller.CodigoRP & Now.Millisecond & "PC.tmp"
''''            If obj.FotoVersionAntigua = True Then
''''                Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
''''            Else
''''                Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
''''            End If
''''            rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)

''''            rpt.SetParameterValue("p_pen_nom", entTaller.PenalNombre)
''''            rpt.SetParameterValue("p_reg_nom", entTaller.RegionNombre)
''''            rpt.SetParameterValue("p_pab_taller", entTaller.PabellonNombre)
''''            rpt.SetParameterValue("p_actividad_laboral", entTaller.NombreTaller)
''''            rpt.SetParameterValue("p_fecha_inscripcion", entTaller.FechaInscripcionString)
''''            rpt.SetParameterValue("p_fecha_retiro", entTaller.FechaRetiroString)
''''            rpt.SetParameterValue("p_anio_planilla", 0)
''''            rpt.SetParameterValue("p_nom_mes", "")
''''            rpt.SetParameterValue("p_nom_resp_lab", entTaller.ResponsableLaboral) 'responsable laboral
''''            rpt.SetParameterValue("p_nom_gest_prod", entTaller.GestorProduccion) 'gestor de produccion

''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub

''''        Private Sub Reporte_Clasificacion_Regimen_PROV()

''''            rpt = New ReportDocument
''''            Dim objBssReporteTratamiento As New Bussines.Reporte.Clasificacion
''''            Dim objEntColInterno As New Entity.Reporte.Clasificacion.DatosInternoCol
''''            Dim objEntInternoFichaFinal As InternoFicha_BE

''''            rpt = New ReportDocument

''''            objEntColInterno = objBssReporteTratamiento.FichaDatosInternoPenalProvincia(Me._Filtro.InternoID, Me._Filtro.InternoIngresoID)

''''            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_ficha_regimen.rpt")

''''            Dim strServidor As String = Legolas.Configuration.Data.CNServer
''''            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
''''            Dim strUser As String = Legolas.Configuration.Data.CNUser
''''            Dim strClave As String = Legolas.Configuration.Data.CNPass

''''            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

''''            '01.- cargar datos del interno
''''            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno
''''                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
''''                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
''''                If obj.FotoVersionAntigua = True Then
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
''''                Else
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
''''                End If

''''                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
''''                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
''''                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
''''                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
''''                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
''''                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
''''                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
''''                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "" Or obj.InfoDecadactilarInt = "|", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
''''                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
''''                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
''''                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
''''                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
''''                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
''''                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
''''                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
''''                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
''''                rpt.SetParameterValue("p_edad", obj.Edad)
''''                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
''''                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
''''                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
''''                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
''''                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
''''                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
''''                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
''''                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
''''                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
''''                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
''''                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
''''                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
''''                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
''''                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
''''                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
''''                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
''''                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
''''                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
''''                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
''''                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
''''                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))

''''                '02.- cargar datos de la ficha                
''''                Dim objEntFichaFiltro As New InternoFicha_BE
''''                objEntFichaFiltro.Codigo = Me._Filtro.IDInternoFichaFinal
''''                objEntInternoFichaFinal = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

''''                Dim objEntLista As New List(Of InternoFicha_BE)

''''                Dim objEntSocial As New InternoFicha_BE
''''                Dim objEntLegal As New InternoFicha_BE
''''                Dim objEntPsicolo As New InternoFicha_BE

''''                If Not objEntInternoFichaFinal Is Nothing Then 'obtener todas las fichas individuales
''''                    objEntFichaFiltro = New InternoFicha_BE
''''                    objEntFichaFiltro.CodigoPadre = objEntInternoFichaFinal.Codigo
''''                    objEntLista = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).ListarGrilla(objEntFichaFiltro)

''''                    For Each objFila As InternoFicha_BE In objEntLista

''''                        Select Case objFila.IDFichaTipo
''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
''''                                objEntLegal = objFila

''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
''''                                objEntSocial = objFila

''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
''''                                objEntPsicolo = objFila
''''                        End Select

''''                    Next
''''                End If

''''                Dim d As DateTime = DateTime.FromFileTime(objEntInternoFichaFinal.FechaClasificacion)
''''                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))
''''                rpt.SetParameterValue("p_motiv_cambio_pen", "")
''''                rpt.SetParameterValue("p_obs_psico", objEntPsicolo.Observacion)
''''                rpt.SetParameterValue("p_obs_legal", objEntLegal.Observacion)
''''                rpt.SetParameterValue("p_obs_social", objEntSocial.Observacion)
''''                rpt.SetParameterValue("p_obs_clasificacion", objEntInternoFichaFinal.Observacion.ToUpper)
''''                rpt.SetParameterValue("p_num_clasificacion", Format(objEntInternoFichaFinal.NumeroClasificacion, "00"))
''''                rpt.SetParameterValue("p_penal_destino", objEntInternoFichaFinal.PenalNombre.ToUpper)
''''                rpt.SetParameterValue("p_regimen_penal", objEntInternoFichaFinal.InternoRegimenNombre.ToUpper)

''''            Next obj

''''            '03.- cargar los datos del procedure, subreporte delitos
''''            rpt.SetParameterValue("@accion", "lst", "srDelitos")
''''            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso", "srDelitos")
''''            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
''''            rpt.SetParameterValue("@fk_int_ing_id", Me._Filtro.InternoIngresoID, "srDelitos")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")

''''            '04.- cargar los datos del procedure, subreporte ficha
''''            rpt.SetParameterValue("@accion", "lst", "crResultado")
''''            rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
''''            rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
''''            rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

''''            '05.- cargar los datos del procedure 
''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_licencia")
''''            rpt.SetParameterValue("@fk_int_id", -1)
''''            rpt.SetParameterValue("@fk_int_ing_id", -1)
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

''''            '06.- paremtros del reporte
''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub
''''        Private Sub Reporte_Clasificacion_Regimen_LM()

''''            rpt = New ReportDocument
''''            Dim objBssReporteTratamiento As New Bussines.Reporte.Clasificacion
''''            Dim objEntColInterno As New Entity.Reporte.Clasificacion.DatosInternoCol
''''            Dim objEntInternoFichaFinal As InternoFicha_BE

''''            rpt = New ReportDocument

''''            objEntColInterno = objBssReporteTratamiento.FichaDatosInterno_LM(Me._Filtro.InternoID, Me._Filtro.IngresoInpeId)

''''            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_ficha_regimen.rpt")

''''            Dim strServidor As String = Legolas.Configuration.Data.CNServer
''''            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
''''            Dim strUser As String = Legolas.Configuration.Data.CNUser
''''            Dim strClave As String = Legolas.Configuration.Data.CNPass

''''            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

''''            '01.- cargar datos del interno
''''            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno
''''                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
''''                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"
''''                If obj.FotoVersionAntigua = True Then
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
''''                Else
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
''''                End If

''''                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
''''                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
''''                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
''''                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
''''                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
''''                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
''''                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
''''                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "" Or obj.InfoDecadactilarInt = "|", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
''''                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
''''                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
''''                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
''''                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
''''                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
''''                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
''''                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
''''                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
''''                rpt.SetParameterValue("p_edad", obj.Edad)
''''                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
''''                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
''''                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
''''                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
''''                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
''''                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
''''                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
''''                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
''''                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
''''                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
''''                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
''''                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
''''                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
''''                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
''''                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
''''                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
''''                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
''''                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
''''                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
''''                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
''''                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))

''''                '02.- cargar datos de la ficha                
''''                Dim objEntFichaFiltro As New InternoFicha_BE
''''                objEntFichaFiltro.Codigo = Me._Filtro.IDInternoFichaFinal
''''                objEntInternoFichaFinal = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

''''                Dim objEntLista As New List(Of InternoFicha_BE)

''''                Dim objEntSocial As New InternoFicha_BE
''''                Dim objEntLegal As New InternoFicha_BE
''''                Dim objEntPsicolo As New InternoFicha_BE

''''                If Not objEntInternoFichaFinal Is Nothing Then 'obtener todas las fichas individuales
''''                    objEntFichaFiltro = New InternoFicha_BE
''''                    objEntFichaFiltro.CodigoPadre = objEntInternoFichaFinal.Codigo
''''                    objEntLista = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).ListarGrilla(objEntFichaFiltro)

''''                    For Each objFila As InternoFicha_BE In objEntLista

''''                        Select Case objFila.IDFichaTipo
''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
''''                                objEntLegal = objFila

''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
''''                                objEntSocial = objFila

''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
''''                                objEntPsicolo = objFila
''''                        End Select

''''                    Next
''''                End If

''''                Dim d As DateTime = DateTime.FromFileTime(objEntInternoFichaFinal.FechaClasificacion)
''''                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))
''''                rpt.SetParameterValue("p_motiv_cambio_pen", "")
''''                rpt.SetParameterValue("p_obs_psico", objEntPsicolo.Observacion)
''''                rpt.SetParameterValue("p_obs_legal", objEntLegal.Observacion)
''''                rpt.SetParameterValue("p_obs_social", objEntSocial.Observacion)
''''                rpt.SetParameterValue("p_obs_clasificacion", objEntInternoFichaFinal.Observacion.ToUpper)
''''                rpt.SetParameterValue("p_num_clasificacion", Format(objEntInternoFichaFinal.NumeroClasificacion, "00"))
''''                rpt.SetParameterValue("p_penal_destino", objEntInternoFichaFinal.PenalNombre.ToUpper)
''''                rpt.SetParameterValue("p_regimen_penal", objEntInternoFichaFinal.InternoRegimenNombre.ToUpper)

''''            Next obj

''''            '03.- cargar los datos del procedure, subreporte delitos
''''            rpt.SetParameterValue("@accion", "lst", "srDelitos")
''''            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso_LM", "srDelitos")
''''            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
''''            rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.IngresoInpeId, "srDelitos")
''''            rpt.SetParameterValue("@fk_int_ing_id", Me._Filtro.InternoIngresoID, "srDelitos")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")

''''            '04.- cargar los datos del procedure, subreporte ficha
''''            rpt.SetParameterValue("@accion", "lst", "crResultado")
''''            rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
''''            rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
''''            rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

''''            '05.- cargar los datos del procedure 
''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_licencia")
''''            rpt.SetParameterValue("@fk_int_id", -1)
''''            rpt.SetParameterValue("@fk_int_ing_id", -1)
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

''''            '06.- paremtros del reporte
''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub

''''        Private Sub Reporte_Clasificacion_Por_Traslado_PROV()

''''            rpt = New ReportDocument
''''            Dim objBssReporteTratamiento As New Bussines.Reporte.Clasificacion
''''            Dim objEntColInterno As New Entity.Reporte.Clasificacion.DatosInternoCol
''''            Dim objEntInternoFichaFinal As InternoFicha_BE

''''            rpt = New ReportDocument

''''            objEntColInterno = objBssReporteTratamiento.FichaDatosInternoPenalProvincia(Me._Filtro.InternoID, Me._Filtro.InternoIngresoID)

''''            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_por_traslado_v1.rpt")

''''            Dim strServidor As String = Legolas.Configuration.Data.CNServer
''''            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
''''            Dim strUser As String = Legolas.Configuration.Data.CNUser
''''            Dim strClave As String = Legolas.Configuration.Data.CNPass

''''            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            'rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

''''            '01.- cargar datos del interno
''''            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

''''                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
''''                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

''''                If obj.FotoVersionAntigua = True Then
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
''''                Else
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
''''                End If

''''                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
''''                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
''''                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
''''                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
''''                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
''''                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
''''                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
''''                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
''''                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
''''                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
''''                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
''''                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
''''                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
''''                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
''''                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
''''                rpt.SetParameterValue("p_edad", obj.Edad)
''''                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
''''                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
''''                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
''''                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
''''                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
''''                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
''''                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
''''                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
''''                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
''''                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))

''''                '02.- cargar datos de la ficha                
''''                Dim objEntFichaFiltro As New InternoFicha_BE
''''                objEntFichaFiltro.Codigo = Me._Filtro.IDInternoFichaFinal
''''                objEntInternoFichaFinal = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)


''''                Dim lstFicOtro As List(Of InternoFichaOtro_BE) = (New InternoFichaOtro_BL()).Listar_rpt(New InternoFichaOtro_BE With {.InternoPenalFichaId = objEntInternoFichaFinal.Codigo})
''''                Dim objOtroEnt As InternoFichaOtro_BE
''''                objOtroEnt = lstFicOtro.Item(0)

''''                'datos de la ficha
''''                Dim d As DateTime = DateTime.FromFileTime(objEntInternoFichaFinal.FechaClasificacion)
''''                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))

''''                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
''''                rpt.SetParameterValue("p_obs_clasificacion", objEntInternoFichaFinal.Observacion.ToUpper)
''''                rpt.SetParameterValue("p_num_clasificacion", Format(objEntInternoFichaFinal.NumeroClasificacion, "00"))
''''                rpt.SetParameterValue("p_regimen", objEntInternoFichaFinal.InternoRegimenNombre.ToUpper)
''''                rpt.SetParameterValue("p_etapa", objEntInternoFichaFinal.InternoEtapaNombre.ToUpper)
''''                rpt.SetParameterValue("p_pabellon", objOtroEnt.PabellonNombre.ToUpper)
''''                rpt.SetParameterValue("p_piso", objOtroEnt.Piso.ToUpper)
''''                rpt.SetParameterValue("p_alero", objOtroEnt.Alero.ToUpper)
''''                rpt.SetParameterValue("p_ambiente", objOtroEnt.Ambiente.ToUpper)
''''                rpt.SetParameterValue("p_cama", objOtroEnt.Cama.ToUpper)
''''                rpt.SetParameterValue("p_causal", objOtroEnt.Causal.ToUpper)
''''                rpt.SetParameterValue("resol_autoriza", objOtroEnt.ResolAutorizacion.ToUpper)
''''                rpt.SetParameterValue("p_fec_resol", objOtroEnt.FechaResolucionString.ToUpper)
''''                rpt.SetParameterValue("p_fec_traslado", objOtroEnt.FechaTrasladoString.ToUpper)
''''                rpt.SetParameterValue("p_ep_origen_nom", objOtroEnt.PenalOrigenNom.ToUpper)
''''                rpt.SetParameterValue("p_ep_receptor_nom", objOtroEnt.PenalDestinoNom.ToUpper)
''''                rpt.SetParameterValue("p_fec_ini_regimen", objEntInternoFichaFinal.FechaInicioRegimenString)
''''                rpt.SetParameterValue("p_fec_ini_etapa", objEntInternoFichaFinal.FechaInicioEtapaString)

''''                'Dim d2 As DateTime = DateTime.FromFileTime(objOtroEnt.FechaClasificacionUbicacion)
''''                'rpt.SetParameterValue("p_fecha_clasif_ubica", "Fecha: " + d2.ToString("dd/MM/yyyy hh:mm tt"))

''''                'Dim entAux As New InternoFichaDetalle_BE()
''''                'entAux.IDInternoFicha = objEntInternoFichaFinal.Codigo

''''                'Dim str As String = ""
''''                'Dim lstDet As List(Of InternoFichaDetalle_BE) = (New InternoFichaDetalle_BL()).Listar(entAux)
''''                'For Each det As InternoFichaDetalle_BE In lstDet

''''                '    '------------------------- cargar indicador -------------------
''''                '    Dim objEnt As New MaestroIndicador_BE With {
''''                '                .Codigo = det.IDIndicador
''''                '                }
''''                '    Dim entValTmp As MaestroIndicadorCol_BE = (New Bussines.Clasificacion.MaestroIndicador).ListarGrillaAgrupada(objEnt)
''''                '    Dim abc As String = entValTmp.MaestroIndicador(0).Calificacion

''''                '    rpt.SetParameterValue("p_calificacion", entValTmp.MaestroIndicador(0).Calificacion)

''''                'Next det
''''            Next obj

''''            '04.- cargar los datos del procedure, subreporte delitos
''''            rpt.SetParameterValue("@accion", "lst", "srDelitos")
''''            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso", "srDelitos")
''''            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
''''            rpt.SetParameterValue("@fk_int_ing_id", Me._Filtro.InternoIngresoID, "srDelitos")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")


''''            '05.- cargar los datos del procedure, subreporte ficha      
''''            'rpt.SetParameterValue("@accion", "lst", "crResultado")
''''            'rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
''''            'rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
''''            'rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
''''            'rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

''''            '06.- cargar los datos del procedure 
''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_licencia")
''''            rpt.SetParameterValue("@fk_int_id", -1)
''''            rpt.SetParameterValue("@fk_int_ing_id", -1)
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

''''            '07.- parametros del reporte
''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub

''''        Private Sub Reporte_Clasificacion_Por_Traslado_LM()

''''            rpt = New ReportDocument
''''            Dim objBssReporteTratamiento As New Bussines.Reporte.Clasificacion
''''            Dim objEntColInterno As New Entity.Reporte.Clasificacion.DatosInternoCol
''''            Dim objEntInternoFichaFinal As InternoFicha_BE

''''            rpt = New ReportDocument

''''            objEntColInterno = objBssReporteTratamiento.FichaDatosInterno_LM(Me._Filtro.InternoID, Me._Filtro.IngresoInpeId)

''''            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_por_traslado_v1.rpt")

''''            Dim strServidor As String = Legolas.Configuration.Data.CNServer
''''            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
''''            Dim strUser As String = Legolas.Configuration.Data.CNUser
''''            Dim strClave As String = Legolas.Configuration.Data.CNPass

''''            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            'rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

''''            '01.- cargar datos del interno
''''            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

''''                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
''''                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

''''                If obj.FotoVersionAntigua = True Then
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
''''                Else
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
''''                End If

''''                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
''''                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
''''                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
''''                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
''''                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
''''                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
''''                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
''''                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
''''                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
''''                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
''''                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
''''                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
''''                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
''''                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
''''                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
''''                rpt.SetParameterValue("p_edad", obj.Edad)
''''                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
''''                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
''''                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
''''                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
''''                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
''''                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
''''                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
''''                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
''''                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
''''                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))

''''                '02.- cargar datos de la ficha                
''''                Dim objEntFichaFiltro As New InternoFicha_BE
''''                objEntFichaFiltro.Codigo = Me._Filtro.IDInternoFichaFinal
''''                objEntInternoFichaFinal = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)


''''                Dim lstFicOtro As List(Of InternoFichaOtro_BE) = (New InternoFichaOtro_BL()).Listar_rpt(New InternoFichaOtro_BE With {.InternoPenalFichaId = objEntInternoFichaFinal.Codigo})
''''                Dim objOtroEnt As InternoFichaOtro_BE
''''                objOtroEnt = lstFicOtro.Item(0)

''''                'datos de la ficha
''''                Dim d As DateTime = DateTime.FromFileTime(objEntInternoFichaFinal.FechaClasificacion)
''''                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))

''''                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
''''                rpt.SetParameterValue("p_obs_clasificacion", objEntInternoFichaFinal.Observacion.ToUpper)
''''                rpt.SetParameterValue("p_num_clasificacion", Format(objEntInternoFichaFinal.NumeroClasificacion, "00"))
''''                rpt.SetParameterValue("p_regimen", objEntInternoFichaFinal.InternoRegimenNombre.ToUpper)
''''                rpt.SetParameterValue("p_etapa", objEntInternoFichaFinal.InternoEtapaNombre.ToUpper)
''''                rpt.SetParameterValue("p_pabellon", objOtroEnt.PabellonNombre.ToUpper)
''''                rpt.SetParameterValue("p_piso", objOtroEnt.Piso.ToUpper)
''''                rpt.SetParameterValue("p_alero", objOtroEnt.Alero.ToUpper)
''''                rpt.SetParameterValue("p_ambiente", objOtroEnt.Ambiente.ToUpper)
''''                rpt.SetParameterValue("p_cama", objOtroEnt.Cama.ToUpper)
''''                rpt.SetParameterValue("p_causal", objOtroEnt.Causal.ToUpper)
''''                rpt.SetParameterValue("resol_autoriza", objOtroEnt.ResolAutorizacion.ToUpper)
''''                rpt.SetParameterValue("p_fec_resol", objOtroEnt.FechaResolucionString.ToUpper)
''''                rpt.SetParameterValue("p_fec_traslado", objOtroEnt.FechaTrasladoString.ToUpper)
''''                rpt.SetParameterValue("p_ep_origen_nom", objOtroEnt.PenalOrigenNom.ToUpper)
''''                rpt.SetParameterValue("p_ep_receptor_nom", objOtroEnt.PenalDestinoNom.ToUpper)
''''                rpt.SetParameterValue("p_fec_ini_regimen", objEntInternoFichaFinal.FechaInicioRegimenString)
''''                rpt.SetParameterValue("p_fec_ini_etapa", objEntInternoFichaFinal.FechaInicioEtapaString)

''''            Next obj

''''            '04.- cargar los datos del procedure, subreporte delitos
''''            rpt.SetParameterValue("@accion", "lst", "srDelitos")
''''            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso_LM", "srDelitos")
''''            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
''''            rpt.SetParameterValue("@fk_int_ing_id", -1, "srDelitos")
''''            rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.IngresoInpeId, "srDelitos")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")

''''            '06.- cargar los datos del procedure 
''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_licencia")
''''            rpt.SetParameterValue("@fk_int_id", -1)
''''            rpt.SetParameterValue("@fk_int_ing_id", -1)
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

''''            '07.- parametros del reporte
''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub


''''        Private Sub Reporte_Clasificacion_Por_Regresion_PROV()

''''            rpt = New ReportDocument
''''            Dim objBssReporteTratamiento As New Bussines.Reporte.Clasificacion
''''            Dim objEntColInterno As New Entity.Reporte.Clasificacion.DatosInternoCol
''''            Dim objEntInternoFichaFinal As InternoFicha_BE

''''            rpt = New ReportDocument

''''            objEntColInterno = objBssReporteTratamiento.FichaDatosInternoPenalProvincia(Me._Filtro.InternoID, Me._Filtro.InternoIngresoID)

''''            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_por_regresion_v1.rpt")

''''            Dim strServidor As String = Legolas.Configuration.Data.CNServer
''''            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
''''            Dim strUser As String = Legolas.Configuration.Data.CNUser
''''            Dim strClave As String = Legolas.Configuration.Data.CNPass

''''            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            'rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

''''            '01.- cargar datos del interno
''''            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

''''                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
''''                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

''''                If obj.FotoVersionAntigua = True Then
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
''''                Else
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
''''                End If

''''                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
''''                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
''''                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
''''                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
''''                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
''''                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
''''                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
''''                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
''''                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
''''                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
''''                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
''''                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
''''                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
''''                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
''''                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
''''                rpt.SetParameterValue("p_edad", obj.Edad)
''''                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
''''                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
''''                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
''''                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
''''                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
''''                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
''''                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
''''                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
''''                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
''''                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))

''''                '02.- cargar datos de la ficha                
''''                Dim objEntFichaFiltro As New InternoFicha_BE
''''                objEntFichaFiltro.Codigo = Me._Filtro.IDInternoFichaFinal
''''                objEntInternoFichaFinal = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

''''                'Dim objEntLista As New List(Of InternoFicha_BE)

''''                'Dim objEntSocial As New InternoFicha_BE
''''                'Dim objEntLegal As New InternoFicha_BE
''''                'Dim objEntPsicolo As New InternoFicha_BE

''''                'If Not objEntInternoFichaFinal Is Nothing Then 'obtener todas las fichas individuales
''''                '    objEntFichaFiltro = New InternoFicha_BE
''''                '    objEntFichaFiltro.CodigoPadre = objEntInternoFichaFinal.Codigo
''''                '    objEntLista = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).ListarGrilla(objEntFichaFiltro)

''''                '    For Each objFila As InternoFicha_BE In objEntLista

''''                '        Select Case objFila.IDFichaTipo
''''                '            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
''''                '                objEntLegal = objFila

''''                '            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
''''                '                objEntSocial = objFila

''''                '            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
''''                '                objEntPsicolo = objFila
''''                '        End Select

''''                '    Next
''''                'End If

''''                '03.- datos del pabellon
''''                'Dim intIDInternoPabellon As Integer = -1
''''                'Dim objBssInternoPabellon As New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoPabellon_BL


''''                'intIDInternoPabellon = objBssInternoPabellon.fn_ObtenerIDCodigo(objEntInternoFichaFinal.Codigo)


''''                Dim lstFicOtro As List(Of InternoFichaOtro_BE) = (New InternoFichaOtro_BL()).Listar_rpt(New InternoFichaOtro_BE With {.InternoPenalFichaId = objEntInternoFichaFinal.Codigo})
''''                Dim objOtroEnt As InternoFichaOtro_BE
''''                objOtroEnt = lstFicOtro.Item(0)

''''                'datos de la ficha
''''                Dim d As DateTime = DateTime.FromFileTime(objEntInternoFichaFinal.FechaClasificacion)
''''                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))

''''                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
''''                rpt.SetParameterValue("p_obs_clasificacion", objEntInternoFichaFinal.Observacion.ToUpper)
''''                rpt.SetParameterValue("p_num_clasificacion", Format(objEntInternoFichaFinal.NumeroClasificacion, "00"))
''''                rpt.SetParameterValue("p_etapa", objEntInternoFichaFinal.InternoEtapaNombre.ToUpper)
''''                rpt.SetParameterValue("p_pabellon", objOtroEnt.PabellonNombre.ToUpper)
''''                rpt.SetParameterValue("p_piso", objOtroEnt.Piso.ToUpper)
''''                rpt.SetParameterValue("p_alero", objOtroEnt.Alero.ToUpper)
''''                rpt.SetParameterValue("p_ambiente", objOtroEnt.Ambiente.ToUpper)
''''                rpt.SetParameterValue("p_cama", objOtroEnt.Cama.ToUpper)
''''                rpt.SetParameterValue("p_causal", objOtroEnt.Causal.ToUpper)
''''                rpt.SetParameterValue("resol_autoriza", objOtroEnt.ResolAutorizacion.ToUpper)
''''                rpt.SetParameterValue("p_fec_resol", objOtroEnt.FechaResolucionString.ToUpper)
''''                rpt.SetParameterValue("p_fec_traslado", objOtroEnt.FechaTrasladoString.ToUpper)
''''                rpt.SetParameterValue("p_ep_origen_nom", objOtroEnt.PenalOrigenNom.ToUpper)
''''                rpt.SetParameterValue("p_ep_receptor_nom", objOtroEnt.PenalDestinoNom.ToUpper)
''''                rpt.SetParameterValue("p_regimen_ep_origen", objOtroEnt.RegimenNombre_PenalOrigen.ToUpper)
''''                rpt.SetParameterValue("p_etapa_ep_origen", objOtroEnt.EtapaNombre_PenalOrigen.ToUpper)

''''                Dim d2 As DateTime = DateTime.FromFileTime(objOtroEnt.FechaClasificacionUbicacion)
''''                rpt.SetParameterValue("p_fecha_clasif_ubica", "Fecha: " + d2.ToString("dd/MM/yyyy hh:mm tt"))

''''                Dim entAux As New InternoFichaDetalle_BE()
''''                entAux.IDInternoFicha = objEntInternoFichaFinal.Codigo

''''                Dim str As String = ""
''''                Dim lstDet As List(Of InternoFichaDetalle_BE) = (New InternoFichaDetalle_BL()).Listar(entAux)
''''                For Each det As InternoFichaDetalle_BE In lstDet

''''                    '------------------------- cargar indicador -------------------
''''                    Dim objEnt As New MaestroIndicador_BE With {
''''                                .Codigo = det.IDIndicador
''''                                }
''''                    Dim entValTmp As MaestroIndicadorCol_BE = (New Bussines.Clasificacion.MaestroIndicador).ListarGrillaAgrupada(objEnt)
''''                    Dim abc As String = entValTmp.MaestroIndicador(0).Calificacion

''''                    rpt.SetParameterValue("p_calificacion", entValTmp.MaestroIndicador(0).Calificacion)

''''                Next det
''''            Next obj

''''            '04.- cargar los datos del procedure, subreporte delitos
''''            rpt.SetParameterValue("@accion", "lst", "srDelitos")
''''            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso", "srDelitos")
''''            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
''''            rpt.SetParameterValue("@fk_int_ing_id", Me._Filtro.InternoIngresoID, "srDelitos")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")


''''            '05.- cargar los datos del procedure, subreporte ficha      
''''            'rpt.SetParameterValue("@accion", "lst", "crResultado")
''''            'rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
''''            'rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
''''            'rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
''''            'rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

''''            '06.- cargar los datos del procedure 
''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_licencia")
''''            rpt.SetParameterValue("@fk_int_id", -1)
''''            rpt.SetParameterValue("@fk_int_ing_id", -1)
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

''''            '07.- parametros del reporte
''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub

''''        Private Sub Reporte_Clasificacion_Por_Regresion_LM()

''''            rpt = New ReportDocument
''''            Dim objBssReporteTratamiento As New Bussines.Reporte.Clasificacion
''''            Dim objEntColInterno As New Entity.Reporte.Clasificacion.DatosInternoCol
''''            Dim objEntInternoFichaFinal As InternoFicha_BE

''''            rpt = New ReportDocument

''''            objEntColInterno = objBssReporteTratamiento.FichaDatosInterno_LM(Me._Filtro.InternoID, Me._Filtro.IngresoInpeId)

''''            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_por_regresion_v1.rpt")

''''            Dim strServidor As String = Legolas.Configuration.Data.CNServer
''''            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
''''            Dim strUser As String = Legolas.Configuration.Data.CNUser
''''            Dim strClave As String = Legolas.Configuration.Data.CNPass

''''            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

''''            '01.- cargar datos del interno
''''            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

''''                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
''''                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

''''                If obj.FotoVersionAntigua = True Then
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
''''                Else
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
''''                End If

''''                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
''''                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
''''                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
''''                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
''''                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
''''                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
''''                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
''''                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
''''                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
''''                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
''''                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
''''                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
''''                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
''''                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
''''                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
''''                rpt.SetParameterValue("p_edad", obj.Edad)
''''                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
''''                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
''''                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
''''                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
''''                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
''''                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
''''                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
''''                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
''''                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
''''                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))

''''                '02.- cargar datos de la ficha                
''''                Dim objEntFichaFiltro As New InternoFicha_BE
''''                objEntFichaFiltro.Codigo = Me._Filtro.IDInternoFichaFinal
''''                objEntInternoFichaFinal = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)


''''                Dim lstFicOtro As List(Of InternoFichaOtro_BE) = (New InternoFichaOtro_BL()).Listar_rpt(New InternoFichaOtro_BE With {.InternoPenalFichaId = objEntInternoFichaFinal.Codigo})
''''                Dim objOtroEnt As InternoFichaOtro_BE
''''                objOtroEnt = lstFicOtro.Item(0)

''''                'datos de la ficha
''''                Dim d As DateTime = DateTime.FromFileTime(objEntInternoFichaFinal.FechaClasificacion)
''''                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))

''''                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
''''                rpt.SetParameterValue("p_obs_clasificacion", objEntInternoFichaFinal.Observacion.ToUpper)
''''                rpt.SetParameterValue("p_num_clasificacion", Format(objEntInternoFichaFinal.NumeroClasificacion, "00"))
''''                rpt.SetParameterValue("p_etapa", objEntInternoFichaFinal.InternoEtapaNombre.ToUpper)
''''                rpt.SetParameterValue("p_pabellon", objOtroEnt.PabellonNombre.ToUpper)
''''                rpt.SetParameterValue("p_piso", objOtroEnt.Piso.ToUpper)
''''                rpt.SetParameterValue("p_alero", objOtroEnt.Alero.ToUpper)
''''                rpt.SetParameterValue("p_ambiente", objOtroEnt.Ambiente.ToUpper)
''''                rpt.SetParameterValue("p_cama", objOtroEnt.Cama.ToUpper)
''''                rpt.SetParameterValue("p_causal", objOtroEnt.Causal.ToUpper)
''''                rpt.SetParameterValue("resol_autoriza", objOtroEnt.ResolAutorizacion.ToUpper)
''''                rpt.SetParameterValue("p_fec_resol", objOtroEnt.FechaResolucionString.ToUpper)
''''                rpt.SetParameterValue("p_fec_traslado", objOtroEnt.FechaTrasladoString.ToUpper)
''''                rpt.SetParameterValue("p_ep_origen_nom", objOtroEnt.PenalOrigenNom.ToUpper)
''''                rpt.SetParameterValue("p_ep_receptor_nom", objOtroEnt.PenalDestinoNom.ToUpper)
''''                rpt.SetParameterValue("p_regimen_ep_origen", objOtroEnt.RegimenNombre_PenalOrigen.ToUpper)
''''                rpt.SetParameterValue("p_etapa_ep_origen", objOtroEnt.EtapaNombre_PenalOrigen.ToUpper)

''''                Dim d2 As DateTime = DateTime.FromFileTime(objOtroEnt.FechaClasificacionUbicacion)
''''                rpt.SetParameterValue("p_fecha_clasif_ubica", "Fecha: " + d2.ToString("dd/MM/yyyy hh:mm tt"))

''''                Dim entAux As New InternoFichaDetalle_BE()
''''                entAux.IDInternoFicha = objEntInternoFichaFinal.Codigo

''''                Dim str As String = ""
''''                Dim lstDet As List(Of InternoFichaDetalle_BE) = (New InternoFichaDetalle_BL()).Listar(entAux)
''''                For Each det As InternoFichaDetalle_BE In lstDet

''''                    '------------------------- cargar indicador -------------------
''''                    Dim objEnt As New MaestroIndicador_BE With {
''''                                .Codigo = det.IDIndicador
''''                                }
''''                    Dim entValTmp As MaestroIndicadorCol_BE = (New Bussines.Clasificacion.MaestroIndicador).ListarGrillaAgrupada(objEnt)
''''                    Dim abc As String = entValTmp.MaestroIndicador(0).Calificacion

''''                    rpt.SetParameterValue("p_calificacion", entValTmp.MaestroIndicador(0).Calificacion)

''''                Next det
''''            Next obj

''''            '04.- cargar los datos del procedure, subreporte delitos
''''            rpt.SetParameterValue("@accion", "lst", "srDelitos")
''''            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso_LM", "srDelitos")
''''            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
''''            rpt.SetParameterValue("@fk_int_ing_id", -1, "srDelitos")
''''            rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.IngresoInpeId, "srDelitos")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")

''''            '06.- cargar los datos del procedure 
''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_licencia")
''''            rpt.SetParameterValue("@fk_int_id", -1)
''''            rpt.SetParameterValue("@fk_int_ing_id", -1)
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

''''            '07.- parametros del reporte
''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub
''''        Private Sub Reporte_Clasificacion_Etapa_PROV()
''''            rpt = New ReportDocument
''''            Dim objBssReporteTratamiento As New Bussines.Reporte.Clasificacion
''''            Dim objEntColInterno As New Entity.Reporte.Clasificacion.DatosInternoCol
''''            Dim objEntIntFF As InternoFicha_BE

''''            rpt = New ReportDocument

''''            objEntColInterno = objBssReporteTratamiento.FichaDatosInternoPenalProvincia(Me._Filtro.InternoID, Me._Filtro.InternoIngresoID)

''''            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_ficha_etapa.rpt")

''''            Dim strServidor As String = Legolas.Configuration.Data.CNServer
''''            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
''''            Dim strUser As String = Legolas.Configuration.Data.CNUser
''''            Dim strClave As String = Legolas.Configuration.Data.CNPass

''''            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

''''            '01.- cargar datos del interno
''''            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

''''                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
''''                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

''''                If obj.FotoVersionAntigua = True Then
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
''''                Else
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
''''                End If

''''                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
''''                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
''''                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
''''                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
''''                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
''''                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
''''                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
''''                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "" Or obj.InfoDecadactilarInt = "|", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
''''                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
''''                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
''''                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
''''                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
''''                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
''''                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
''''                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
''''                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
''''                rpt.SetParameterValue("p_edad", obj.Edad)
''''                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
''''                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
''''                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
''''                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
''''                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
''''                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
''''                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
''''                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
''''                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
''''                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
''''                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
''''                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
''''                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
''''                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
''''                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
''''                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
''''                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
''''                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
''''                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
''''                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
''''                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))

''''                '02.- cargar datos de la ficha                
''''                Dim objEntFichaFiltro As New InternoFicha_BE
''''                objEntFichaFiltro.Codigo = Me._Filtro.IDInternoFichaFinal
''''                objEntIntFF = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)

''''                Dim objEntLista As New List(Of InternoFicha_BE)

''''                Dim objEntSocial As New InternoFicha_BE
''''                Dim objEntLegal As New InternoFicha_BE
''''                Dim objEntPsicolo As New InternoFicha_BE

''''                If Not objEntIntFF Is Nothing Then 'obtener todas las fichas individuales
''''                    objEntFichaFiltro = New InternoFicha_BE
''''                    objEntFichaFiltro.CodigoPadre = objEntIntFF.Codigo
''''                    objEntLista = (New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BL).ListarGrilla(objEntFichaFiltro)

''''                    For Each objFila As InternoFicha_BE In objEntLista

''''                        Select Case objFila.IDFichaTipo
''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
''''                                objEntLegal = objFila

''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
''''                                objEntSocial = objFila

''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
''''                                objEntPsicolo = objFila
''''                        End Select

''''                    Next
''''                End If

''''                '03.- datos del pabellon
''''                Dim intIDInternoPabellon As Integer = -1
''''                Dim objBssInternoPabellon As New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.InternoPabellon_BL
''''                Dim objEntInternoPabellon As New InternoPabellon_BE

''''                intIDInternoPabellon = objBssInternoPabellon.fn_ObtenerIDCodigo(objEntIntFF.Codigo)
''''                objEntInternoPabellon = objBssInternoPabellon.Listar(intIDInternoPabellon)

''''                'datos de la ficha
''''                Dim d As DateTime = DateTime.FromFileTime(objEntIntFF.FechaClasificacion)
''''                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))
''''                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
''''                rpt.SetParameterValue("p_obs_psico", objEntPsicolo.Observacion)
''''                rpt.SetParameterValue("p_obs_legal", objEntLegal.Observacion)
''''                rpt.SetParameterValue("p_obs_social", objEntSocial.Observacion)
''''                rpt.SetParameterValue("p_obs_clasificacion", objEntIntFF.Observacion.ToUpper)
''''                rpt.SetParameterValue("p_num_clasificacion", Format(objEntIntFF.NumeroClasificacion, "00"))
''''                rpt.SetParameterValue("p_etapa", objEntIntFF.InternoEtapaNombre.ToUpper)
''''                'datos del pabellon
''''                rpt.SetParameterValue("p_regimen_penal", objEntInternoPabellon.RegimenNombre.ToUpper)
''''                rpt.SetParameterValue("p_pabellon", objEntInternoPabellon.PabellonNombre.ToUpper)
''''                rpt.SetParameterValue("p_piso", objEntInternoPabellon.Piso.ToUpper)
''''                rpt.SetParameterValue("p_alero", objEntInternoPabellon.Ala.ToUpper)
''''                rpt.SetParameterValue("p_ambiente", objEntInternoPabellon.Ambiente.ToUpper)
''''                rpt.SetParameterValue("p_cama", objEntInternoPabellon.Cama.ToUpper)
''''                rpt.SetParameterValue("p_obs_jefe_ott", objEntInternoPabellon.Observacion.ToUpper)
''''                rpt.SetParameterValue("p_pert_org_criminal", objEntIntFF.PerteneceOrgCriminal)
''''            Next obj

''''            '04.- cargar los datos del procedure, subreporte delitos
''''            rpt.SetParameterValue("@accion", "lst", "srDelitos")
''''            rpt.SetParameterValue("@opcion", "lst_listar_expediente_delitos_x_ingreso", "srDelitos")
''''            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
''''            rpt.SetParameterValue("@fk_int_ing_id", Me._Filtro.InternoIngresoID, "srDelitos")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1, "srDelitos")

''''            '05.- cargar los datos del procedure, subreporte ficha      
''''            rpt.SetParameterValue("@accion", "lst", "crResultado")
''''            rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
''''            rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
''''            rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

''''            '06.- cargar los datos del procedure 
''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_licencia")
''''            rpt.SetParameterValue("@fk_int_id", -1)
''''            rpt.SetParameterValue("@fk_int_ing_id", -1)
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

''''            '07.- parametros del reporte
''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub

''''        Private Sub Reporte_Clasificacion_Etapa_LM()
''''            Dim ffFinalizado As String = ""
''''            rpt = New ReportDocument

''''            Dim objEntColInterno = (New Bussines.Reporte.Clasificacion).FichaDatosInterno_LM(Me._Filtro.InternoID, Me._Filtro.IngresoInpeId)

''''            rpt.Load(Me.ReportePath & "\Penal\Clasificacion\rpt_cla_ficha_etapa.rpt")

''''            Dim strServidor As String = Legolas.Configuration.Data.CNServer
''''            Dim strBD As String = Legolas.Configuration.Data.CNDataBase
''''            Dim strUser As String = Legolas.Configuration.Data.CNUser
''''            Dim strClave As String = Legolas.Configuration.Data.CNPass

''''            rpt.DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("srDelitos").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)
''''            rpt.Subreports.Item("crResultado").DataSourceConnections(0).SetConnection(strServidor, strBD, strUser, strClave)

''''            '01.- cargar datos del interno
''''            For Each obj As Entity.Reporte.Clasificacion.DatosInterno In objEntColInterno

''''                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"
''''                strFotoPI = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PI.tmp"

''''                If obj.FotoVersionAntigua = True Then
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI, strFotoPI)
''''                Else
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
''''                    Legolas.Components.Archivo.FileCreateByte(obj.FotoPI_v2, strFotoPI)
''''                End If

''''                rpt.SetParameterValue("p_ruta_imagenPF", strFotoPC)
''''                rpt.SetParameterValue("p_ruta_imagenPI", strFotoPI)
''''                rpt.SetParameterValue("p_int_homonimo", If(obj.Hononimo = True, "SI", "NO"))
''''                rpt.SetParameterValue("p_nombres_interno", If(obj.Nombres = "", "NR", obj.Nombres.ToUpper))
''''                rpt.SetParameterValue("p_apellidos_interno", UCase(obj.Apellidos))
''''                rpt.SetParameterValue("p_nombres_asociados", If(obj.NombresAsociados = "", "NR", obj.NombresAsociados.ToUpper))
''''                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))
''''                rpt.SetParameterValue("p_decadactilar_int", If(obj.InfoDecadactilarInt = "" Or obj.InfoDecadactilarInt = "|", "NR", obj.InfoDecadactilarInt.ToUpper.Replace("|", " - ")))
''''                rpt.SetParameterValue("p_tipo_ingreso", If(obj.TipoIngreso = "", "NR", obj.TipoIngreso.ToUpper))
''''                rpt.SetParameterValue("p_fech_ing_penal", If(obj.FechaIngresoPenalString = "", "NR", obj.FechaIngresoPenalString))
''''                rpt.SetParameterValue("p_num_ing", If(obj.NumeroIngreso = 0, "NR", obj.NumeroIngreso))
''''                rpt.SetParameterValue("p_nom_penal", If(obj.PenalActual = "", "NR", obj.PenalActual.ToUpper))
''''                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
''''                rpt.SetParameterValue("p_fec_nac", obj.FechaNacimientoString)
''''                rpt.SetParameterValue("p_doc_ident_tipo", obj.TipoDocumentoyNumero)
''''                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", obj.SexoNombre))
''''                rpt.SetParameterValue("p_edad", obj.Edad)
''''                rpt.SetParameterValue("p_madre_int", If(obj.Madre = "", "NR", obj.Madre.ToUpper))
''''                rpt.SetParameterValue("p_padre_int", If(obj.Padre = "", "NR", obj.Padre.ToUpper))
''''                rpt.SetParameterValue("p_num_hijos", If(obj.NumeroHijos = 0, "NR", obj.NumeroHijos.ToString))
''''                rpt.SetParameterValue("p_conyuge", If(obj.Conyugue = "", "NR", obj.Conyugue.ToUpper))
''''                rpt.SetParameterValue("p_est_civil", If(obj.EstadoCivil = "", "NR", obj.EstadoCivil.ToUpper))
''''                rpt.SetParameterValue("p_nac_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
''''                rpt.SetParameterValue("p_nac_departamento", If(obj.NacimientoDepartamento = "", "NR", obj.NacimientoDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_nac_distrito", If(obj.NacimientoDistrito = "", "NR", obj.NacimientoDistrito.ToUpper))
''''                rpt.SetParameterValue("p_nac_pais", If(obj.NacimientoPais = "", "NR", obj.NacimientoPais.ToUpper))
''''                rpt.SetParameterValue("p_nac_provincia", If(obj.NacimientoProvincia = "", "NR", obj.NacimientoProvincia.ToUpper))
''''                rpt.SetParameterValue("p_nac_lugar", If(obj.NacimientoLugar = "", "NR", obj.NacimientoLugar.ToUpper))
''''                rpt.SetParameterValue("p_dom_depart", If(obj.DomicilioDepartamento = "", "NR", obj.DomicilioDepartamento.ToUpper))
''''                rpt.SetParameterValue("p_dom_distrito", If(obj.DomicilioDistrito = "", "NR", obj.DomicilioDistrito.ToUpper))
''''                rpt.SetParameterValue("p_dom_prov", If(obj.DomicilioProvincia = "", "NR", obj.DomicilioProvincia.ToUpper))
''''                rpt.SetParameterValue("p_dom_direccion", If(obj.Domicilio = "", "NR", obj.Domicilio.ToUpper))
''''                rpt.SetParameterValue("p_datgen_nivel_inst", If(obj.GradoInstruccion = "" Or obj.GradoInstruccion = "No Determinado", "NR", obj.GradoInstruccion.ToUpper))
''''                rpt.SetParameterValue("p_datgen_ocupacion", If(obj.Ocupacion = "" Or obj.Ocupacion = "[No Indica]", "NR", obj.Ocupacion.ToUpper))
''''                rpt.SetParameterValue("p_datgen_profesion", If(obj.Profesion = "" Or obj.Profesion = "[No Indica]", "NR", obj.Profesion.ToUpper))
''''                rpt.SetParameterValue("p_religion", If(obj.Religion = "", "NR", obj.Religion.ToUpper))
''''                rpt.SetParameterValue("p_idioma", If(obj.Idioma = "", "NR", obj.Idioma.ToUpper))
''''                rpt.SetParameterValue("p_fuerza_armada", If(obj.FuerzaArmanda = "", "NR", obj.FuerzaArmanda.ToUpper))
''''                rpt.SetParameterValue("p_centro_trabajo", If(obj.CentroTrabajo = "", "NR", obj.CentroTrabajo.ToUpper))
''''                rpt.SetParameterValue("p_rango_militar", If(obj.Rango = "", "NR", obj.Rango.ToUpper))

''''                '02.- cargar datos de la ficha                
''''                Dim objEntFichaFiltro As New InternoFicha_BE With {
''''                        .Codigo = Me._Filtro.IDInternoFichaFinal
''''                        }

''''                Dim objEntIntFF = (New InternoFicha_BL).Listar(objEntFichaFiltro).Item(0)
''''                Dim objEntSocial As New InternoFicha_BE
''''                Dim objEntLegal As New InternoFicha_BE
''''                Dim objEntPsicolo As New InternoFicha_BE

''''                If Not objEntIntFF Is Nothing Then 'obtener todas las fichas individuales
''''                    objEntFichaFiltro = New InternoFicha_BE With {
''''                                        .IDInternoIngreso = objEntIntFF.IDInternoIngreso,
''''                                        .IDInternoIngresoInpe = objEntIntFF.IDInternoIngresoInpe,
''''                                        .CodigoPadre = objEntIntFF.Codigo
''''                                        }

''''                    Dim objEntLista = (New InternoFicha_BL).ListarGrilla(objEntFichaFiltro)

''''                    For Each objFila As InternoFicha_BE In objEntLista
''''                        Select Case objFila.IDFichaTipo
''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Legal
''''                                objEntLegal = objFila

''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Social
''''                                objEntSocial = objFila

''''                            Case Type.Enumeracion.Clasificacion.enmTipoFicha.Psicologica
''''                                objEntPsicolo = objFila
''''                        End Select
''''                    Next
''''                End If

''''                '03.- datos del pabellon
''''                Dim bssIntPab As New InternoPabellon_BL
''''                Dim entIntPab = bssIntPab.Listar(bssIntPab.fn_ObtenerIDCodigo(objEntIntFF.Codigo))

''''                'datos de la ficha
''''                Dim d As DateTime = DateTime.FromFileTime(objEntIntFF.FechaClasificacion)
''''                rpt.SetParameterValue("p_fec_clasificacion", d.ToString("dd/MM/yyyy hh:mm tt"))
''''                rpt.SetParameterValue("p_motiv_cambio_pen", "") 'omitir
''''                rpt.SetParameterValue("p_obs_psico", objEntPsicolo.Observacion)
''''                rpt.SetParameterValue("p_obs_legal", objEntLegal.Observacion)
''''                rpt.SetParameterValue("p_obs_social", objEntSocial.Observacion)
''''                rpt.SetParameterValue("p_obs_clasificacion", objEntIntFF.Observacion.ToUpper)
''''                rpt.SetParameterValue("p_num_clasificacion", Format(objEntIntFF.NumeroClasificacion, "00"))
''''                rpt.SetParameterValue("p_etapa", objEntIntFF.InternoEtapaNombre.ToUpper)
''''                'datos del pabellon
''''                rpt.SetParameterValue("p_regimen_penal", If(entIntPab IsNot Nothing, entIntPab.RegimenNombre.ToUpper(), "ORDINARIO"))
''''                rpt.SetParameterValue("p_pabellon", If(entIntPab IsNot Nothing, entIntPab.PabellonNombre.ToUpper(), ""))
''''                rpt.SetParameterValue("p_piso", If(entIntPab IsNot Nothing, entIntPab.Piso.ToUpper(), ""))
''''                rpt.SetParameterValue("p_alero", If(entIntPab IsNot Nothing, entIntPab.Ala.ToUpper(), ""))
''''                rpt.SetParameterValue("p_ambiente", If(entIntPab IsNot Nothing, entIntPab.Ambiente.ToUpper(), ""))
''''                rpt.SetParameterValue("p_cama", If(entIntPab IsNot Nothing, entIntPab.Cama.ToUpper(), ""))
''''                rpt.SetParameterValue("p_obs_jefe_ott", If(entIntPab IsNot Nothing, entIntPab.Observacion.ToUpper(), ""))

''''                Dim xxx = objEntIntFF.EstadoNombre
''''                ffFinalizado = objEntIntFF.EstadoNombre
''''            Next obj

''''            '04.- cargar los datos del procedure, subreporte delitos
''''            rpt.SetParameterValue("@accion", "lst", "srDelitos")
''''            rpt.SetParameterValue("@opcion", "lst_exp_ficha", "srDelitos")
''''            rpt.SetParameterValue("@fk_int_id", Me._Filtro.InternoID, "srDelitos")
''''            rpt.SetParameterValue("@fk_ing_inp_id", Me._Filtro.IngresoInpeId, "srDelitos")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "srDelitos")

''''            '05.- cargar los datos del procedure, subreporte ficha      
''''            rpt.SetParameterValue("@accion", "lst", "crResultado")
''''            rpt.SetParameterValue("@opcion", "lst_listar_variables_x_ficha", "crResultado")
''''            rpt.SetParameterValue("@fk_int_id", -1, "crResultado")
''''            rpt.SetParameterValue("@fk_int_ing_id", -1, "crResultado")
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", Me._Filtro.IDInternoFichaFinal, "crResultado")

''''            '06.- cargar los datos del procedure 
''''            rpt.SetParameterValue("@accion", "lst")
''''            rpt.SetParameterValue("@opcion", "lst_licencia")
''''            rpt.SetParameterValue("@fk_int_id", -1)
''''            rpt.SetParameterValue("@fk_int_ing_id", -1)
''''            rpt.SetParameterValue("@pk_int_pen_fic_id", -1)

''''            '07.- parametros del reporte
''''            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
''''            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
''''            rpt.SetParameterValue("p_acta", Me.ReporteActa)
''''            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
''''            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)




''''            rpt.SetParameterValue("p_rpt_vista_previa", If(ffFinalizado = "PENDIENTE", True, False))

''''            Me.CrystalReportViewer1.ReportSource = rpt

''''        End Sub


''''#End Region

''''#Region "Otros"
''''        Private Sub ValoresxDefault()

''''            With Me.CrystalReportViewer1
''''                .ShowExportButton = False
''''                .ShowGroupTreeButton = False
''''                .ShowCloseButton = False
''''                .ShowParameterPanelButton = False
''''                .ShowRefreshButton = False
''''                .ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
''''            End With

''''        End Sub
''''        Private Sub ExportarPDF()

''''            With Me.SaveFileDialog1
''''                .FileName = ""
''''                .Filter = "Solo PDF (*.pdf)|*.pdf"
''''                If .ShowDialog = Windows.Forms.DialogResult.OK Then
''''                    ExportToPDF(Me.rpt, .FileName, "")
''''                End If

''''            End With

''''        End Sub
''''        Public Sub ExportToPDF(ByVal Reporte As ReportDocument, ByVal Path As String, ByVal NombreArchivo As String)

''''            Dim vFileName As String
''''            Dim diskOpts As New DiskFileDestinationOptions

''''            Try
''''                With rpt.ExportOptions
''''                    .ExportDestinationType = ExportDestinationType.DiskFile
''''                    .ExportFormatType = ExportFormatType.PortableDocFormat
''''                End With

''''                vFileName = Path & NombreArchivo

''''                If Legolas.Components.Archivo.FileExiste(vFileName) Then
''''                    Legolas.Components.Archivo.FileDelete(vFileName)
''''                End If

''''                diskOpts.DiskFileName = vFileName
''''                Reporte.ExportOptions.DestinationOptions = diskOpts
''''                Reporte.Export()

''''                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()

''''            Catch ex As Exception
''''                Throw ex
''''            End Try
''''        End Sub
''''#End Region

''''        Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click

''''            Me.Close()

''''        End Sub

''''        Private Sub ReporteCrystal_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

''''            rpt.Dispose()
''''            CrystalReportViewer1.Dispose()

''''            Try
''''                Legolas.Components.Archivo.FileDelete(strFotoPC)
''''            Catch ex As Exception

''''            End Try

''''        End Sub

''''        Private Sub ReporteCrystal_Load(sender As Object, e As System.EventArgs) Handles Me.Load

''''            ValoresxDefault()
''''            Me.WindowState = FormWindowState.Maximized

''''        End Sub

''''        Private Sub ReporteCrystal_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

''''            ListarPropiedadesReporte()
''''            Me.Text = "Control Asistencia Movimiento Resumen"  ' Me.ReporteNombre
''''            VerReporte()

''''        End Sub

''''        Private Sub ImpirmirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImpirmirToolStripMenuItem.Click

''''            Me.CrystalReportViewer1.PrintReport()

''''        End Sub

''''        Private Sub ExportarPDFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarPDFToolStripMenuItem.Click

''''            ExportarPDF()

''''        End Sub

''''    End Class
''''End Namespace
