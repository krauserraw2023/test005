Namespace Seguridad.Paquetes
    Public Class frmBuscar
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
        Private Sub LoasUscRegistroPaquete()

            With Me.UscRegistroDetalle1
                ._idRegion = Me.RegionID
                ._idPenal = Me.PenalID
                ._regionNombre = Me.RegionNombre
                ._penalNombre = Me.PenalNombre
                .Visible = True
                ._LoadUsc()
            End With

        End Sub
        Private Sub LoadUscBusqueda()

            With Me.UscBusqueda1
                ._idRegion = Me.RegionID
                ._idPenal = Me.PenalID
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
                ._idRegion = Me.RegionID
                ._idPenal = Me.PenalID
                If Buscar = True Then
                    ._Buscar()
                End If

            End With

        End Sub

        Private Sub ANuevo()

            Me.TabControl1.SelectedIndex = 0
            Me.UscRegistroDetalle1._LimpiarMovimiento()

        End Sub
        Private Sub AGrabar()

            Me.UscRegistroDetalle1._AGrabar()

        End Sub
#End Region
#Region "Reporte"
        Private Sub AReporte()

            'Dim frm As New APPReporte.Visita.frmReporte
            'With frm
            '    ._Filtro.FechaInicio = Me.UscBusqueda1.FechaInicio
            '    ._Filtro.FechaFin = Me.UscBusqueda1.FechaFin
            '    ._Filtro.RegionID = Me.RegionID
            '    ._Filtro.PenalID = Me.PenalID
            '    ._TipoReporte = Type.Reporte.Visita.rptVisitaMovimiento
            '    .Show()
            'End With

        End Sub
#End Region

#Region "Form"

        Private Sub Form_Internos(intIDVisitante As Integer, strInternoApellidos As String, strInternoNombres As String)

            Dim intTipoForm As Integer = -1
            Dim idInternoSeleccionado As Integer = -1

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
                    idInternoSeleccionado = ._GrillaInternoID

                    Select Case intTipoForm
                        Case 0

                            Me.UscRegistroDetalle1._listarInterno(idInternoSeleccionado, False)
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
            Dim idInternoSeleccionado As Integer = -1

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
                    idInternoSeleccionado = ._grillaIDInterno

                    If ._Apellidos.Length > 0 Then
                        strApellidos = ._Apellidos
                    End If

                    If ._Nombres.Length > 0 Then
                        strNombres = ._Nombres
                    End If

                    Select Case intTipoForm
                        Case 0
                            Me.UscRegistroDetalle1._listarInterno(idInternoSeleccionado, False)
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
            Dim idInternoSeleccionado As Integer = -1

            Dim frm As New Visita.InternoPJ.frmInternoPopup
            With frm
                ._IDRegion = Me.RegionID
                ._RegionNombre = Me.RegionNombre
                ._IDPenal = Me.PenalID
                ._PenalNombre = Me.PenalNombre

                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    intTipoForm = ._TipoForm
                    idInternoSeleccionado = ._GrillaIDInterno

                    Select Case intTipoForm
                        Case 0
                            Me.UscRegistroDetalle1._listarInterno(idInternoSeleccionado, True)
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
            Me.pnlReporte.Visible = Me._FormReporte

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

            Me.UscRegistroDetalle1._ValoresxDefault()

            LoasUscRegistroPaquete()

            Me.Focus()

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
                Me.UscRegistroDetalle1._ActualizarParametricasRegionPenal()
                Me.UscRegistroDetalle1._LimpiarMovimiento()
            End If

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedIndex
                Case 0 'registro                    
                    LoasUscRegistroPaquete()
                Case 1 'consulta
                    LoadUscBusqueda()
                    ABusqueda(False, True)
            End Select

        End Sub

        Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
            AGrabar()
        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        btnSalir.Click,
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

            With Me.UscRegistroDetalle1
                ._idRegion = Me.RegionID
                ._regionNombre = Me.RegionNombre
                ._idPenal = Me.PenalID
                ._penalNombre = Me.PenalNombre
                ._ActualizarParametricasRegionPenal()
            End With

            Me.UscRegistroDetalle1._LimpiarMovimiento()
            ListarConfig()

        End Sub


        Private Sub btnNuevoMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoMov.Click

            Me.UscRegistroDetalle1._LimpiarMovimiento()

        End Sub

        Private Sub pbLeyenda_Click(sender As System.Object, e As System.EventArgs)

            Dim frm As New Visita.Movimiento.frmLeyendaMovimientoPopup
            frm.ShowDialog()


        End Sub

        Private Sub UscRegistroDetalle1__Click_Form_Internos(VisitanteID As Integer) Handles UscRegistroDetalle1._Click_Form_Internos

            Form_Internos(VisitanteID, "", "")

        End Sub

        Private Sub UscRegistroDetalle1__Click_Form_InternosHistoricos(VisitanteID As Integer) Handles UscRegistroDetalle1._Click_Form_InternosHistoricos

            Form_InternosHistoricos(VisitanteID)

        End Sub

        Private Sub UscRegistroDetalle1__Click_Form_InternosPJ(intIDVisitante As Integer) Handles UscRegistroDetalle1._Click_Form_InternosPJ

            FRM_BuscarInternosPJ(intIDVisitante)

        End Sub

        Private Sub btnVerPaquetes_Click(sender As Object, e As EventArgs) Handles btnVerPaquetes.Click

            ABusqueda(True, True)

        End Sub
    End Class
End Namespace
