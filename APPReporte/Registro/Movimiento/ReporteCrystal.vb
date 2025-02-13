Imports CrystalDecisions.CrystalReports 'borrar
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows 'borrar
Imports Type.Enumeracion.Licencia

Namespace Registro.Movimiento
    Public Class ReporteCrystal
        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Private strFotoPC As String = ""
        Public Property ReporteOpcion As String = ""
#Region "Propiedades_Parametricas"
        Public Property _Filtro() As New Entity.Reporte.Registro.Filtro
#End Region
#Region "Propiedades_Reporte"
        Private intTipoReporte As Type.Reporte.Movimiento = Type.Reporte.Movimiento.rpt
        Private ReadOnly Property ReporteID() As Integer
            Get
                Dim intCodigoReporte As Integer = -1

                intCodigoReporte = Me._TipoReporte.GetHashCode

                Return intCodigoReporte
            End Get
        End Property
        Public Property _TipoReporte() As Type.Reporte.Movimiento
            Get
                Return intTipoReporte
            End Get
            Set(ByVal value As Type.Reporte.Movimiento)
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

                value = Legolas.Configuration.Path.PathReporte & "Registro\Movimiento\"

                Return value
            End Get
        End Property
        Public Property _TipoLicencia() As enmTipoLicencia = enmTipoLicencia.Ninguno
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

            Select Case Me._TipoReporte

                Case Type.Reporte.Movimiento.rptMovIngresosPorPenal, Type.Reporte.Movimiento.rptMovIngresosPorSede
                    Reporte_MovimientoIngreso()

                Case Type.Reporte.Movimiento.rptMovIngresoACarceleta
                    Reporte_MovimientoIngresoCarceleta()

                Case Type.Reporte.Movimiento.rptMovEgresosPorPenal, Type.Reporte.Movimiento.rptMovEgresosPorSede
                    Reporte_MovimientoEgresos()

                Case Type.Reporte.Movimiento.rptMovPorInterno
                    'If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    '    Reporte_MovimientoInterno_LM()
                    'Else
                    Reporte_MovimientoInterno()
                    'End If

                Case Type.Reporte.Movimiento.rptMovLibEjecutadasPorPenal, Type.Reporte.Movimiento.rptMovLibEjecutadasPorSede
                    Reporte_Movimiento_Libertades()

                Case Type.Reporte.Movimiento.rptFichaFinalGeneradas
                    Reporte_ListaFichaFinalGeneradas()

                Case Type.Reporte.Movimiento.rptListaInternoClasifPorPenal
                    Reporte_ListaIngInternoClasificadoPorPenal()
            End Select

        End Sub

        Private Sub Reporte_ListaIngInternoClasificadoPorPenal()

            Dim objBss As New Bussines.Reporte.Registro
            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_lst_ing_int_clasif_carceleta_v1.rpt")

            rpt.DataSourceConnections(0).SetConnection( _
                Legolas.Configuration.Data.CNServer, _
                Legolas.Configuration.Data.CNDataBase, _
                Legolas.Configuration.Data.CNUser, _
                Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_int_clasificado_x_penal")

            rpt.SetParameterValue("p_fec_ini", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio))
            rpt.SetParameterValue("p_fec_fin", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFinOri))
            rpt.SetParameterValue("p_ep", UCase(Me._Filtro.PenalNombre))

            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", 0)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)



            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_ListaFichaFinalGeneradas()

            Dim objBss As New Bussines.Reporte.Registro
            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_lst_ficha_final_carceleta_v1.rpt")
            'rpt.SetParameterValue("p_region_nom", UCase(Me._Filtro.RegionNombre))


            rpt.DataSourceConnections(0).SetConnection( _
                Legolas.Configuration.Data.CNServer, _
                Legolas.Configuration.Data.CNDataBase, _
                Legolas.Configuration.Data.CNUser, _
                Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_ficha_final_gen")

            rpt.SetParameterValue("p_fec_ini", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio))
            rpt.SetParameterValue("p_fec_fin", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFinOri))
            rpt.SetParameterValue("p_ep", UCase(Me._Filtro.PenalNombre))

            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", 0)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)



            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_MovimientoIngresoCarceleta()

            Dim objBss As New Bussines.Reporte.Registro
            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_mov_ing_x_penal_carceleta_v1.rpt")
            rpt.SetParameterValue("p_region_nom", UCase(Me._Filtro.RegionNombre))


            rpt.DataSourceConnections(0).SetConnection( _
                Legolas.Configuration.Data.CNServer, _
                Legolas.Configuration.Data.CNDataBase, _
                Legolas.Configuration.Data.CNUser, _
                Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_hoja_ing_diario_carceleta")

            rpt.SetParameterValue("p_fec_ini", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio))
            rpt.SetParameterValue("p_fec_fin", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFinOri))
            rpt.SetParameterValue("p_ep", UCase(Me._Filtro.PenalNombre))

            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@fk_ing_inp_id", -1)
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@n_aut_amb", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_MovimientoIngreso()

            Dim objBss As New Bussines.Reporte.Registro
            rpt = New ReportDocument

            If Me._Filtro.PenalID = -1 Then
                rpt.Load(Me.ReportePath & "rpt_mov_ing_x_sede.rpt")
            Else
                rpt.Load(Me.ReportePath & "rpt_mov_ing_x_penal.rpt")
                rpt.SetParameterValue("p_region_nom", UCase(Me._Filtro.RegionNombre))
            End If

            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_hoja_ingreso_diario")

            rpt.SetParameterValue("p_fec_ini", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio))
            rpt.SetParameterValue("p_fec_fin", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFinOri))
            rpt.SetParameterValue("p_ep", UCase(Me._Filtro.PenalNombre))

            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@int_rnc_id", -1)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_MovimientoEgresos()

            Dim objBss As New Bussines.Reporte.Registro
            rpt = New ReportDocument

            If Me._Filtro.PenalID = -1 Then
                rpt.Load(Me.ReportePath & "rpt_mov_egreso_x_sede.rpt")
            Else
                rpt.Load(Me.ReportePath & "rpt_mov_egreso_x_penal.rpt")
                rpt.SetParameterValue("p_region_nom", UCase(Me._Filtro.RegionNombre))
            End If

            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_hoja_egreso_diario")
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFinOri)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@int_rnc_id", -1)
            rpt.SetParameterValue("@id", -1)
            rpt.SetParameterValue("@pk_rpt_cab_id", -1)
            rpt.SetParameterValue("@mostrar_doc_anulado", 0)

            rpt.SetParameterValue("p_fec_ini", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio))
            rpt.SetParameterValue("p_fec_fin", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFinOri))
            rpt.SetParameterValue("p_ep", UCase(Me._Filtro.PenalNombre))
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_MovimientoInterno()

            Dim objBss As New Bussines.Reporte.Registro

            rpt = New ReportDocument

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.FichaCol
            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEntCol = objBss.FichaIdentificacion_PLM(Me._Filtro.InternoID)
            Else
                objEntCol = objBss.FichaIdentificacion_Provincia(Me._Filtro.InternoID)
            End If

            rpt.Load(Me.ReportePath & "rpt_mov_interno.rpt")

            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_ficha_interno")
            rpt.SetParameterValue("@int_ing_id", -1)

            For Each obj As Entity.Reporte.FichaIdentificacion.Ficha In objEntCol

                'litar imagenes
                Dim objBssInstal As New Bussines.Sistema.Instalacion
                Dim intIDTipoLocal = objBssInstal.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
                Dim ObjBssArchDigital As New Bussines.Globall.ArchivoDigital

                Dim objFotoTemp As Byte()

                strFotoPC = Legolas.Configuration.Path.PathTemp & obj.CodigoRP & Now.Millisecond & "PC.tmp"

                Select Case intIDTipoLocal
                    Case 2 'region
                        objFotoTemp = ObjBssArchDigital.getArchivoDigitalByte_Region(obj.FotoPerfilCentralId, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "")
                        Legolas.Components.Archivo.FileCreateByte(objFotoTemp, strFotoPC)

                    Case Else
                        'sede, penal 
                        If obj.FotoVersionAntigua = True Then
                            Legolas.Components.Archivo.FileCreateByte(obj.FotoPC, strFotoPC)
                        Else
                            Legolas.Components.Archivo.FileCreateByte(obj.FotoPC_v2, strFotoPC)
                        End If
                End Select

                rpt.SetParameterValue("p_ruta_imagenPC", strFotoPC)

                rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
                rpt.SetParameterValue("p_nom_interno", obj.Apellidos & ", " & obj.Nombres)
                rpt.SetParameterValue("p_cod_rp_interno", obj.CodigoRP)
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
                rpt.SetParameterValue("p_fech_nac", If(obj.FechaNacimientoString = "", "NR", obj.FechaNacimientoString))
                rpt.SetParameterValue("p_doc_identidad", If(obj.TipoDocumentoyNumero = "", "NR", obj.TipoDocumentoyNumero.ToUpper))
                rpt.SetParameterValue("p_sit_juridica_int", If(obj.SituacionJuridicaNombre = "", "NR", obj.SituacionJuridicaNombre.ToUpper))

                rpt.SetParameterValue("p_nacionalidad", If(obj.Nacionalidad = "", "NR", obj.Nacionalidad.ToUpper))
                rpt.SetParameterValue("p_sexo", If(obj.SexoNombre = "", "NR", If(obj.SexoNombre.ToUpper = "M", "MASCULINO", "FEMENINO")))
                rpt.SetParameterValue("p_lugar_nacimiento", If(obj.NacimientoPais = "", "NR", If(obj.NacimientoPais.ToUpper = "PERU", obj.NacimientoDepartamento.ToUpper & " / " & obj.NacimientoProvincia.ToUpper & " / " & obj.NacimientoDistrito.ToUpper, obj.NacimientoPais.ToUpper & " / " & obj.NacimientoLugar.ToUpper)))
                Exit For
            Next

            rpt.Subreports.Item("cr_ingreso").DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

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


            rpt.SetParameterValue("@accion", "lst", "cr_ingreso")
            rpt.SetParameterValue("@opcion", "lst_rpt_mov_interno", "cr_ingreso")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID, "cr_ingreso")
            rpt.SetParameterValue("@pen_id", -1, "cr_ingreso")
            rpt.SetParameterValue("@int_ing_id", -1, "cr_ingreso")
            rpt.SetParameterValue("@int_exp_id", -1, "cr_ingreso")
            rpt.SetParameterValue("@int_sen_id", -1, "cr_ingreso")
            rpt.SetParameterValue("@int_del_id", -1, "cr_ingreso")
            rpt.SetParameterValue("@nac_id", -1, "cr_ingreso")
            rpt.SetParameterValue("@cuadro", -1, "cr_ingreso")
            rpt.SetParameterValue("@fec_ini", 0, "cr_ingreso")
            rpt.SetParameterValue("@fec_fin", 0, "cr_ingreso")
            rpt.SetParameterValue("@_fecha", 0, "cr_ingreso")
            rpt.SetParameterValue("@reg_id", -1, "cr_ingreso")
            rpt.SetParameterValue("@tip_band_id", -1, "cr_ingreso")
            rpt.SetParameterValue("@ban_id", -1, "cr_ingreso")
            rpt.SetParameterValue("@int_rnc_id", -1, "cr_ingreso")



            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Movimiento_Libertades()

            Dim objBss As New Bussines.Reporte.Registro
            rpt = New ReportDocument

            If Me._Filtro.PenalID = -1 Then
                rpt.Load(Me.ReportePath & "rpt_mov_libertad_x_sede.rpt")
            Else
                rpt.Load(Me.ReportePath & "rpt_mov_libertad_x_penal.rpt")
                rpt.SetParameterValue("p_region_nom", UCase(Me._Filtro.RegionNombre))
            End If

            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("p_fec_ini", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio))
            rpt.SetParameterValue("p_fec_fin", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFinOri))

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_libertades_ejecutadas")
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)

            rpt.SetParameterValue("p_ep", UCase(Me._Filtro.PenalNombre))
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        'Private Sub Reporte_FichaFinalGenereradas()

        '    Dim objBss As New Bussines.Reporte.Registro
        '    rpt = New ReportDocument

        '    If Me._Filtro.PenalID = -1 Then
        '        rpt.Load(Me.ReportePath & "rpt_ficha_final_generadas.rpt")
        '    Else
        '        rpt.Load(Me.ReportePath & "rpt_lst_ficha_final_carceleta_v1.rpt")
        '        ' rpt.SetParameterValue("p_region_nom", UCase(Me._Filtro.RegionNombre))
        '    End If

        '    rpt.DataSourceConnections(0).SetConnection( _
        '    Legolas.Configuration.Data.CNServer, _
        '    Legolas.Configuration.Data.CNDataBase, _
        '    Legolas.Configuration.Data.CNUser, _
        '    Legolas.Configuration.Data.CNPass)

        '    rpt.SetParameterValue("p_fec_ini", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio))
        '    rpt.SetParameterValue("p_fec_fin", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFinOri))

        '    rpt.SetParameterValue("@accion", "lst")
        '    rpt.SetParameterValue("@opcion", "lst_rpt_ficha_final_gen")
        '    rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
        '    rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
        '    rpt.SetParameterValue("@int_id", -1)
        '    rpt.SetParameterValue("@int_ing_id", -1)
        '    rpt.SetParameterValue("@int_exp_id", -1)
        '    rpt.SetParameterValue("@int_sen_id", -1)
        '    rpt.SetParameterValue("@int_del_id", -1)
        '    rpt.SetParameterValue("@nac_id", -1)
        '    rpt.SetParameterValue("@cuadro", -1)
        '    rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
        '    rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
        '    rpt.SetParameterValue("@_fecha", 0)
        '    rpt.SetParameterValue("@tip_band_id", -1)
        '    rpt.SetParameterValue("@ban_id", -1)
        '    rpt.SetParameterValue("@int_rnc_id", -1)

        '    rpt.SetParameterValue("p_ep", UCase(Me._Filtro.PenalNombre))
        '    rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
        '    rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
        '    rpt.SetParameterValue("p_acta", Me.ReporteActa)
        '    rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
        '    rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

        '    Me.CrystalReportViewer1.ReportSource = rpt

        'End Sub



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

    End Class
End Namespace
