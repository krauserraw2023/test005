Namespace Visita
    Public Class frmBuscar2
        Private blnHabilitaHuella As Boolean = False
#Region "Propiedades"
        Private ReadOnly Property RegionID() As Integer
            Get

                Return Me.UsrRegionPenal1._RegionID
            End Get

        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.UsrRegionPenal1._RegionNombre
            End Get
        End Property
        Private ReadOnly Property PenalID() As Integer
            Get

                Return Me.UsrRegionPenal1._PenalID
            End Get

        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.UsrRegionPenal1._PenalNombre
            End Get
        End Property
#End Region
#Region "Propiedades_Otros"
        Private blnVisibleGrabar As Boolean = False
        Private Property VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub ComboRegionPenal()

            With Me.UsrRegionPenal1
                ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.LicenciaTieneSistemaVisita
                ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._NivelUsuario = Legolas.Configuration.Usuario.NivelUsuario
                ._PerfilUsuario = Legolas.Configuration.Usuario.OficinaID
                ._PenalTodos = False
                ._LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub LoasUscVisita()

            Me.UscMovimientov21.Visible = False

            With Me.UscMovimientov21
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._RegionNombre = Me.RegionNombre
                ._PenalNombre = Me.PenalNombre
                .Visible = True
                ._LoadUsc()
            End With

        End Sub
        Private Sub LoadUscBusqueda()

            With Me.UscBusqueda1
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._ModificarSalida = Me.VisibleGrabar
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Accion"

        Private Sub ABusqueda(ByVal SelectTab As Boolean, ByVal Buscar As Boolean)

            If SelectTab = True Then
                Me.TabControl1.SelectedIndex = 1
            End If

            With Me.UscBusqueda1
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                If Buscar = True Then
                    ._Buscar()
                End If

            End With

        End Sub

        Private Sub ANuevo()

            Me.TabControl1.SelectedIndex = 0

        End Sub
        Private Sub AGrabar()

            Me.UscMovimientov21._AGrabar()

        End Sub
#End Region
#Region "Reporte"
        Private Sub AReporte()

            Dim frm As New APPReporte.Visita.frmReporte
            With frm
                ._Filtro.FechaInicio = Me.UscBusqueda1.FechaInicio
                ._Filtro.FechaFin = Me.UscBusqueda1.FechaFin
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.PenalID = Me.PenalID
                ._TipoReporte = Type.Reporte.Visita.rptVisitaMovimiento
                .Show()
            End With

        End Sub
#End Region

#Region "Form"
        Private Sub FRM_Mant_Menores(IDEtapaInterno As Integer, IDVisitanteAdulto As Integer, Optional IDVisitanteMenor As Integer = -1, _
                                     Optional IDTipoDocumentoVisitanteMenor As Integer = -1, Optional VisitanteMenorNumeroDocumento As String = "", _
                                     Optional IDParentescoVisitanteMenor As Integer = -1, Optional VisitanteMenorParentesco As String = "", _
                                     Optional IDCalendarioDetalle As Integer = -1)

            Dim frm As New Visita.Visitante.frmVisitanteMenorPopup
            With frm
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._IDEtapaInterno = IDEtapaInterno
                ._IDVisitanteAdulto = IDVisitanteAdulto
                ._IDVisitanteMenor = IDVisitanteMenor

                If IDVisitanteMenor > 0 Then
                    ._IDTipoDocumentoVisitanteMenor = IDTipoDocumentoVisitanteMenor
                    ._VisitanteMenorNumeroDocumento = VisitanteMenorNumeroDocumento
                End If

                If .ShowDialog = DialogResult.OK Then
                    Me.UscMovimientov21._Temporal_GrabarMenores(._VisitanteID, IDParentescoVisitanteMenor, VisitanteMenorParentesco, IDCalendarioDetalle)
                End If

            End With

        End Sub

        Private Sub Form_Menores(IDEtapaInterno As Short, IDVisitanteAdulto As Integer, IDCalendarioDetalle As Integer, IDCalendatrioDetalleExtraordinario As Integer)


            If IDCalendatrioDetalleExtraordinario > 0 Then

                Dim frm As New Visita.Visitante.frmExtraordinarioMenoresPopup
                With frm
                    ._RegionID = Me.RegionID
                    ._PenalID = Me.PenalID
                    ._IDCalendarioDetalle = IDCalendatrioDetalleExtraordinario

                    Select Case .ShowDialog
                        Case Windows.Forms.DialogResult.OK

                            FRM_Mant_Menores(IDEtapaInterno, IDVisitanteAdulto, ._IDVisitanteGrilla, ._IDTipoDocumentoVisitanteGrilla, _
                                             ._GrillaVisitanteNumeroDocumento, ._IDParentescoVisitanteGrilla, ._GrillaVisitanteParentesco, _
                                             IDCalendatrioDetalleExtraordinario)

                        Case Windows.Forms.DialogResult.Abort

                            If IDCalendarioDetalle > 0 Then
                                FRM_Mant_Menores(IDEtapaInterno, IDVisitanteAdulto)
                            Else
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se han encontrado programaciones para el tipo de visita Menores de Edad.")
                            End If

                    End Select

                End With

            Else

                FRM_Mant_Menores(IDEtapaInterno, IDVisitanteAdulto)

            End If

        End Sub

        Private Sub FRMSalida(blnBuscarGrilla As Boolean)

            Dim blnHuella As Boolean = False
            Dim blnServicioHuella As Boolean = True

            Dim lngFechaHoy As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong
            Dim objBss As New Bussines.Visita.ConfigHuella
            blnServicioHuella = Not objBss.ValidarServicioBaja(lngFechaHoy, Me.RegionID, Me.PenalID)

            If blnHabilitaHuella = True Then
                If blnServicioHuella = True Then
                    blnHuella = True
                End If
            End If

            If blnHuella = True Then

                'Dim frm As New Visita.Movimiento.frmSalidaHuellaPopup
                'With frm
                '    ._RegionID = Me.RegionID
                '    ._PenalID = Me.PenalID
                '    .ShowDialog()
                'End With

                Dim frm As New Visita.Movimiento.frmSalidaHuelllaPopupv2
                With frm
                    ._TipoSalida = Visita.Movimiento.frmSalidaPopup.enmTipoSalida.SalidaNumeroDocumento
                    ._RegionID = Me.RegionID
                    ._PenalID = Me.PenalID
                    .ShowDialog()
                End With

            Else

                Dim frm As New Visita.Movimiento.frmSalidaPopup
                With frm
                    ._TipoSalida = Visita.Movimiento.frmSalidaPopup.enmTipoSalida.SalidaNumeroDocumento
                    ._RegionID = Me.RegionID
                    ._PenalID = Me.PenalID
                    .ShowDialog()
                End With

            End If

            If blnBuscarGrilla = True Then
                Me.UscBusqueda1._Buscar()
            End If

        End Sub

        Private Sub FRM_RegistrarSalida(ByVal MovimientoID As Long, ByVal HoraIngreso As String,
                                        intMovIngresaPor As Short)

            Select Case intMovIngresaPor

                Case Type.Enumeracion.Visita.Movimiento.IngresoPor.Ninguno

                    Dim frm As New Visita.Movimiento.frmSalidaPopup
                    With frm
                        ._TipoSalida = Visita.Movimiento.frmSalidaPopup.enmTipoSalida.Salida
                        ._RegionID = Me.RegionID
                        ._PenalID = Me.PenalID
                        ._MovimientoID = MovimientoID
                        ._HoraIngreso = HoraIngreso

                        If .ShowDialog = DialogResult.OK Then
                            UscBusqueda1._Buscar()
                        End If

                    End With

                Case Else
                    'nada
            End Select

        End Sub

        Private Sub FRMCerrarSalida(ByVal Mensaje As Boolean)

            'verificar si hay movimientos de visitas sin salida
            Dim frm As New Visita.frmVisitaSinSalidaPopup
            With frm
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._BuscarAuto = True
                ._Mensaje = Mensaje
                ._FormEscritura = Me._FormEscritura
                .ShowDialog()
                'If .ShowDialog() <> Windows.Forms.DialogResult.OK Then
                '    Me.Close()
                'End If
            End With


        End Sub

        Private Sub Form_Internos(intIDVisitante As Integer, strInternoApellidos As String, strInternoNombres As String)

            Dim intTipoForm As Integer = -1
            Dim frm As New Visita.Interno.frmInternoPopup
            With frm
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._RegionNombre = Me.RegionNombre
                ._PenalNombre = Me.PenalNombre
                ._FechaVisita = Legolas.Configuration.Aplication.FechayHora.FechaLong
                ._Apellidos = strInternoApellidos
                ._Nombres = strInternoNombres

                If .ShowDialog() = DialogResult.OK Then
                    intTipoForm = ._TipoForm

                    Select Case intTipoForm
                        Case 0
                            Me.UscMovimientov21._EsInternoPJ = False
                            Me.UscMovimientov21._InternoIDArray = ._InternoIDArray
                            Me.UscMovimientov21._Temporal_Grabar()
                        Case 1
                            Form_InternosHistoricos(intIDVisitante)

                        Case 2
                            FRM_BuscarInternosPJ(intIDVisitante)

                    End Select

                End If
            End With

        End Sub

        Private Sub Form_InternosHistoricos(VisitanteID As Integer)

            Dim strApellidos As String = ""
            Dim strNombres As String = ""

            Dim intTipoForm As Integer = -1
            Dim frm As New Visita.Interno.frmInternoHistoricoPopup

            With frm
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._RegionNombre = Me.RegionNombre
                ._PenalNombre = Me.PenalNombre
                ._VisitanteID = VisitanteID
                ._BuscarLoad = True
                ._FechaVisita = Legolas.Configuration.Aplication.FechayHora.FechaLong

                If .ShowDialog = DialogResult.OK Then
                    intTipoForm = ._TipoForm

                    If ._Apellidos.Length > 0 Then
                        strApellidos = ._Apellidos
                    End If

                    If ._Nombres.Length > 0 Then
                        strNombres = ._Nombres
                    End If

                    Select Case intTipoForm
                        Case 0
                            Me.UscMovimientov21._EsInternoPJ = False
                            Me.UscMovimientov21._InternoIDArray = ._InternoIDArray
                            Me.UscMovimientov21._Temporal_Grabar()
                        Case 1

                            Form_Internos(VisitanteID, strApellidos, strNombres)

                        Case 2
                            FRM_BuscarInternosPJ(VisitanteID)

                    End Select

                End If
            End With

        End Sub

        Private Sub FRM_BuscarInternosPJ(intIDVisitante As Integer)

            Dim intTipoForm As Integer = -1

            Dim frm As New Visita.InternoPJ.frmInternoPopup
            With frm
                ._IDRegion = Me.RegionID
                ._RegionNombre = Me.RegionNombre
                ._IDPenal = Me.PenalID
                ._PenalNombre = Me.PenalNombre

                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    intTipoForm = ._TipoForm

                    Select Case intTipoForm
                        Case 0
                            Me.UscMovimientov21._EsInternoPJ = True
                            Me.UscMovimientov21._IDInternoPJ = ._GrillaIDInternoPJ
                            Me.UscMovimientov21._Temporal_Grabar()
                        Case 1
                            Form_InternosHistoricos(intIDVisitante)
                    End Select

                End If
            End With

        End Sub
#End Region
#Region "Permisos/Accesos"
        Private Sub Usuario_Permisos(ByRef blnCerrarVentana As Boolean)

            Dim intTipoLocal As Integer = Type.Enumeracion.Licencia.enmTipoLicencia.Sede 'sede central
            Dim objBss As New Bussines.Sistema.Instalacion

            Dim strMensaje As String = ""

            intTipoLocal = objBss.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo

            Me.VisibleGrabar = True

            Select Case intTipoLocal
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede    'sede central

                    Select Case Legolas.Configuration.Usuario.NivelUsuario

                        Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                            Select Case Legolas.Configuration.Usuario.OficinaID

                                Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion

                                    Me.VisibleGrabar = Me._FormEscritura
                                Case Else
                                    Me.VisibleGrabar = False
                                    strMensaje = "El Modulo de Visita solo está autorizado con el Nivel de Usuario: Carceleta"
                                    blnCerrarVentana = True
                            End Select

                        Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta

                            Select Case Legolas.Configuration.Usuario.OficinaID

                                Case Type.Enumeracion.Usuario.EnumDependencia.SeguridadPenitenciaria,
                                     Type.Enumeracion.Usuario.EnumDependencia.JefeSeguridad,
                                     Type.Enumeracion.Usuario.EnumDependencia.Direccion 'director de penal

                                    Me.VisibleGrabar = Me._FormEscritura

                                Case Else
                                    Me.VisibleGrabar = False
                                    strMensaje = "El Modulo de Visita no esta autorizado para el perfil del usuario actual"
                                    blnCerrarVentana = True
                            End Select

                        Case Else
                            strMensaje = "El Modulo de Visita solo está autorizado con el Nivel de Usuario: Carceleta"
                            Me.VisibleGrabar = False
                            blnCerrarVentana = True
                    End Select

                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia   'region             

                    strMensaje = "El Modulo de Visita solo está disponible en los Establecimientos Penitenciarios"
                    Me.VisibleGrabar = False
                    blnCerrarVentana = True

                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia,
                    Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana 'penal                    

                    Me.VisibleGrabar = Me._FormEscritura

            End Select

            'boton nuevo visita
            Me.pnlNuevo.Visible = Me.VisibleGrabar
            Me.pnlExportar.Visible = Me._FormReporte
            Me.pnlReporte.Visible = Me._FormReporte

            Me.pnlRegistrarSalida.Visible = Me.VisibleGrabar
            Me.pnlPendientes.Visible = Me.VisibleGrabar
            Me.UscBusqueda1._ModificarSalida = Me.VisibleGrabar

            '/***validar el acceso al modulo**/

            If blnCerrarVentana = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Me.Close()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            ComboRegionPenal()

            Me.UscBusqueda1.FechaInicio = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            Me.UscBusqueda1.FechaFin = Me.UscBusqueda1.FechaInicio

            Me.UscMovimientov21._ValoresxDefault()

            LoasUscVisita()

            Me.Focus()
            FRMCerrarSalida(False)

        End Sub
        Private Sub ListarConfig()

            '/*se consulta la tabla configuracion del sistema del modulo de visitas*/
            Dim objBss As New Bussines.Visita.Config
            Dim objEnt As New Entity.Visita.Config
            Dim objEntFiltro As New Entity.Visita.Config

            With objEntFiltro
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .Estado = 1 'alta
            End With

            objEnt = objBss.ListarConfigActual(objEntFiltro)

            If Not objEnt Is Nothing Then
                blnHabilitaHuella = objEnt.HabilitaHuellaDigital
            End If

        End Sub
#End Region

        Private Sub frmBuscar2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

            Select Case e.KeyCode
                Case Keys.F3
                    ABusqueda(True, True)
                    'Case Keys.F4
                    '    ANuevo()
                Case Keys.F12
                    AGrabar()
            End Select

        End Sub

        Private Sub frmBuscar2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized

            Dim blnCerrarForm As Boolean = False
            Usuario_Permisos(blnCerrarForm)

            If blnCerrarForm = False Then
                ValoresxDefault()
                ListarConfig()
                Me.UscMovimientov21._ActualizarParametricasRegionPenal()
            End If

        End Sub

        Private Sub btnBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqueda.Click

            ABusqueda(True, True)

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedIndex
                Case 0 'registro                    
                    LoasUscVisita()
                Case 1 'consulta
                    LoadUscBusqueda()
                    ABusqueda(False, True)
            End Select

        End Sub

        Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
            AGrabar()
        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        btnSalir.Click, _
        btnSalirBusqueda.Click

            Me.Close()

        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            ANuevo()

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Me.UscBusqueda1.AExportar()

        End Sub

        Private Sub btnReporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReporte.Click


            AReporte()

        End Sub

        Private Sub UsrRegionPenal1__PenalSelectedIndexChanged() Handles UsrRegionPenal1._PenalSelectedIndexChanged

            ABusqueda(False, True)

            With Me.UscMovimientov21
                ._RegionID = Me.RegionID
                ._RegionNombre = Me.RegionNombre
                ._PenalID = Me.PenalID
                ._PenalNombre = Me.PenalNombre
                ._ActualizarParametricasRegionPenal()
            End With

            Me.UscMovimientov21._LimpiarMovimiento()
            ListarConfig()

        End Sub

        Private Sub btnRegistarSalida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistarSalida.Click

            FRMSalida(True)

        End Sub

        Private Sub btnNuevoMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoMov.Click

            Me.UscMovimientov21._LimpiarMovimiento()

        End Sub

        Private Sub btnPendientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPendientes.Click
            FRMCerrarSalida(True)
        End Sub


        Private Sub UscMovimientov21__Click_Form_Internos(VisitanteID As Integer) Handles UscMovimientov21._Click_Form_Internos

            Form_Internos(VisitanteID, "", "")

        End Sub

        Private Sub UscMovimientov21__Click_Form_InternosHistoricos(VisitanteID As Integer) Handles UscMovimientov21._Click_Form_InternosHistoricos

            Form_InternosHistoricos(VisitanteID)

        End Sub

        Private Sub UscMovimientov21__Click_Form_InternosPJ(intIDVisitante As Integer) Handles UscMovimientov21._Click_Form_InternosPJ

            FRM_BuscarInternosPJ(intIDVisitante)

        End Sub


        Private Sub UscMovimientov21__Click_Form_Menores(InternoEtapaID As Short, VisitanteID As Integer, IDCalendarioDetalle As Integer, _
                                                         IDCalendatrioDetalleExtraordinario As Integer) Handles UscMovimientov21._Click_Form_Menores

            Form_Menores(InternoEtapaID, VisitanteID, IDCalendarioDetalle, IDCalendatrioDetalleExtraordinario)

        End Sub

        Private Sub UsrRegionPenal1_Load(sender As System.Object, e As System.EventArgs) Handles UsrRegionPenal1.Load

        End Sub

        
        Private Sub UscBusqueda1__CellDoubleClick_RegistrarSalidaVisita(MovimientoID As Long, HoraIngreso As String, intMovIngresaPor As Short) Handles UscBusqueda1._CellDoubleClick_RegistrarSalidaVisita

            FRM_RegistrarSalida(MovimientoID, HoraIngreso, intMovIngresaPor)

        End Sub

        Private Sub pbLeyenda_Click(sender As System.Object, e As System.EventArgs) Handles pbLeyenda.Click

            Dim frm As New Visita.Movimiento.frmLeyendaMovimientoPopup
            frm.ShowDialog()


        End Sub

        Private Sub btnRegSalida_Click(sender As Object, e As EventArgs) Handles btnRegSalida.Click

            FRMSalida(False)

        End Sub
    End Class
End Namespace
