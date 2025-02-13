Namespace Visita
    Public Class uscMovimientov2
#Region "Eventos"
        Public Event _Click_Form_Menores(InternoEtapaID As Short, VisitanteID As Integer, IDCalendarioDetalle As Integer, IDCalendatrioDetalleExtraordinario As Integer)
        Public Event _Click_Form_Internos(VisitanteID As Integer)
        Public Event _Click_Form_InternosPJ(intIDVisitante As Integer)
        Public Event _Click_Form_InternosHistoricos(VisitanteID As Integer)
#End Region
#Region "Propiedades_Parametricas"
        Public Property _RegionID() As Short = -1
        Public Property _RegionNombre() As String = ""
        Public Property _PenalID() As Short = -1
        Public Property _PenalNombre() As String = ""
        Private Property FechaVisita() As Long
            Get
                Return Me.dtpFechaVis.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaVis.ValueLong = value
            End Set
        End Property
#End Region
#Region "Propiedades_Publicas"
        Public Property _EsInternoPJ As Boolean = False
        Public Property _IDInternoPJ As Integer = -1
        Public Property _InternoIDArray() As String()
            Get
                Return Me.UscRegistrov2._InternoIDArray
            End Get
            Set(value As String())
                Me.UscRegistrov2._InternoIDArray = value
            End Set
        End Property
#End Region
#Region "Propiedades"
        Public Property IsVisitaAdministrativa() As Boolean
            Get
                Return Me.chkVisitaAdmin.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkVisitaAdmin.Checked = value
            End Set
        End Property       
#End Region
#Region "Propiedades_Configuracion"
        '/*parametros de la tabla de configuracion del modulo visitas*/
        Private Property RegimenTipoID As Short = -1
        Private Property RegimenTipoNombre As String = ""
        Private Property SolicitarInfoPabellon As Boolean = False
        Private Property SolicitarAutoRegOrdinario As Boolean = False
        Private Property SolicitarAutoRegAbogado As Boolean = False
        Private Property HabilitarInternoPJ As Boolean = False
        '/*huella*/
        Private Property HabilitarHuellaDigital As Boolean = False
        Private Property HabilitarCapHuellaValReniec As Boolean = False
        '/*reniec*/
        Private Property ValidarModuloVisConReniec As Boolean = False
        Private Property ValidarVisitanteConReniec As Boolean = False
        '/*reniec*/
        Private Property ValidarVisitanteConMigraciones As Boolean = False
        Private Property ValidarModuloVisConMigraciones As Boolean = False
#End Region
#Region "Functions"
        Public Sub _Temporal_GrabarMenores(VisitanteID_Menor As Integer, IDParentescoVisitanteMenor As Integer,
                                            VisitanteMenorParentescoNombre As String, IDCalendarioDetalle As Integer)

            Me.UscRegistrov2._Temporal_GrabarMenores(Me._EsInternoPJ, VisitanteID_Menor, IDParentescoVisitanteMenor, VisitanteMenorParentescoNombre,
                                                    IDCalendarioDetalle)

        End Sub
        Public Sub _Temporal_Grabar()

            Me.UscRegistrov2._Temporal_Grabar(Me._EsInternoPJ, Me._IDInternoPJ)

        End Sub
#End Region
#Region "Listar"
        Private Sub LoadUscVisitaPenal()

            With Me.UscRegistrov2
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._RegionNombre = Me._RegionNombre
                ._PenalNombre = Me._PenalNombre
                ._FechaVisita = Me.FechaVisita
                'configuracion del modulo visita
                ._RegimenTipoID = Me._RegimenTipoID
                ._SolicitarInfoPabellon = Me.SolicitarInfoPabellon
                ._SolicitarAutoRegOrdinario = Me.SolicitarAutoRegOrdinario
                ._SolicitarAutoRegAbogado = Me.SolicitarAutoRegAbogado
                ._HabilitarInternoPJ = Me.HabilitarInternoPJ
                '/*huella*/
                ._HabilitarHuellaDigital = Me.HabilitarHuellaDigital
                ._HabilitarCapHuellaValReniec = Me.HabilitarCapHuellaValReniec
                '/*reniec*/
                ._ValidarModuloVisConReniec = Me.ValidarModuloVisConReniec
                ._ValidarVisitanteConReniec = Me.ValidarVisitanteConReniec
                'migraciones
                ._ValidarModuloVisConMigraciones = Me.ValidarModuloVisConMigraciones
                ._ValidarVisitanteConMigraciones = Me.ValidarVisitanteConMigraciones
                ._LoadUsc()
                ._Focus()
            End With

        End Sub
        Private Sub LoadUscVisitaAdmin()
            With Me.UscRegistroAdminv2
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._RegionNombre = Me._RegionNombre
                ._PenalNombre = Me._PenalNombre
                ._FechaVisita = Me.FechaVisita
                'configuracion del modulo visita
                ._SolicitarAutoRegOrdinario = Me.SolicitarAutoRegOrdinario
                '/*huella*/
                ._HabilitarHuellaDigital = Me.HabilitarHuellaDigital
                ._HabilitarCapHuellaValReniec = Me.HabilitarCapHuellaValReniec
                '/*reniec*/
                ._ValidarModuloVisConReniec = Me.ValidarModuloVisConReniec
                ._ValidarVisitanteConReniec = Me.ValidarVisitanteConReniec
                'migraciones
                ._ValidarModuloVisConMigraciones = Me.ValidarModuloVisConMigraciones
                ._ValidarVisitanteConMigraciones = Me.ValidarVisitanteConMigraciones
                ._LoadUsc()
                ._Focus()
            End With
        End Sub
        Private Sub ListarConfigVisitas()

            Dim objBss As New Bussines.Visita.Config
            Dim objEnt As New Entity.Visita.Config

            Dim objEntFiltro As New Entity.Visita.Config

            With objEntFiltro
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .Estado = 1 'alta
            End With

            objEnt = objBss.ListarConfigActual(objEntFiltro)

            If Not objEnt Is Nothing Then

                With objEnt
                    Me.RegimenTipoID = .RegimenTipoID
                    Me.RegimenTipoNombre = .RegimenTipoNombre
                    Me.SolicitarInfoPabellon = .SolicitaInfoPabellon
                    Me.SolicitarAutoRegOrdinario = .SolicitaAutoRegOrdinario
                    Me.SolicitarAutoRegAbogado = .SolicitaAutoRegAbogado
                    Me.HabilitarInternoPJ = .HabilitarInternosPJ
                    '/*huella*/
                    Me.HabilitarHuellaDigital = .HabilitaHuellaDigital
                    Me.HabilitarCapHuellaValReniec = .CapturarHuellaValReniec
                    '/*reniec*/
                    Me.ValidarModuloVisConReniec = .ValidarModVisitaConReniec
                    Me.ValidarVisitanteConReniec = .ValidarVisitanteConReniec
                    'migraciones                    
                    Me.ValidarModuloVisConMigraciones = .ValidarModVisitaConMigraciones
                    Me.ValidarVisitanteConMigraciones = .ValidarVisitanteConMigraciones
                End With

            Else
                Me.RegimenTipoID = -1
                Me.RegimenTipoNombre = "Regimen Ordinario"
                Me.SolicitarInfoPabellon = False
                Me.SolicitarAutoRegOrdinario = False
                Me.SolicitarAutoRegAbogado = False
                '/*huella*/
                Me.HabilitarHuellaDigital = False
                Me.HabilitarCapHuellaValReniec = False
                '/*reniec*/
                Me.ValidarModuloVisConReniec = False
                Me.ValidarVisitanteConReniec = False
                '/*migraciones*/
                Me.ValidarModuloVisConMigraciones = False
                Me.ValidarVisitanteConMigraciones = False
            End If

            Me.lblRegimen.Text = "Regimen : " & Legolas.Components.Cadena.ProperCase(Me._RegimenTipoNombre)

        End Sub
#End Region
#Region "Accion"
        Public Function _AGrabar() As Boolean

            Dim value As Boolean = False

            If Me.IsVisitaAdministrativa = True Then
                value = Me.UscRegistroAdminv2._AGrabar()
            Else
                value = Me.UscRegistrov2._AGrabar()
            End If

            Return value

        End Function

#End Region
#Region "Otros"
        Public Sub _LimpiarMovimiento()

            If Me.IsVisitaAdministrativa = True Then
                Me.UscRegistroAdminv2._LimpiarMovimiento() 'visita penal
            Else
                Me.UscRegistrov2._LimpiarMovimiento() 'visita penal
            End If

            SubActualizarFechaVisita()

        End Sub
        Private Sub SubActualizarFechaVisita()

            Dim dtFechaLocal As Date = Now.ToShortDateString

            If dtFechaLocal.ToFileTime <> Me.FechaVisita Then
                Me.FechaVisita = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            End If

            Me.UscRegistrov2._FechaVisita = Me.FechaVisita
            Me.UscRegistroAdminv2._FechaVisita = Me.FechaVisita

        End Sub
        Private Sub HabilitarVisitaAdministrativa()

            If Me.IsVisitaAdministrativa = True Then

                'If Legolas.Configuration.Aplication.MessageBox.Question(
                '    "Esta seguro en cambiar al Modo Visita Administrativa, los datos de la visita se perderan") = DialogResult.Yes Then

                Me.UscRegistrov2.Visible = False
                Me.UscRegistroAdminv2.Visible = True
                LoadUscVisitaAdmin()
                'End If

            Else
                Me.UscRegistrov2.Visible = True
                Me.UscRegistroAdminv2.Visible = False
                LoadUscVisitaPenal()
            End If

        End Sub
        Public Sub _ActualizarParametricasRegionPenal()

            ListarConfigVisitas()

            With Me.UscRegistrov2
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._RegionNombre = Me._RegionNombre
                ._PenalNombre = Me._PenalNombre
                ._FechaVisita = Me.FechaVisita
                'tabla configuracion del modulo de visitas
                ._RegimenTipoID = Me.RegimenTipoID
                ._SolicitarInfoPabellon = Me.SolicitarInfoPabellon
                ._SolicitarAutoRegOrdinario = Me.SolicitarAutoRegOrdinario
                ._SolicitarAutoRegAbogado = Me.SolicitarAutoRegAbogado
                ._HabilitarInternoPJ = Me.HabilitarInternoPJ
                '/*huella*/
                ._HabilitarHuellaDigital = Me.HabilitarHuellaDigital
                ._HabilitarCapHuellaValReniec = Me.HabilitarCapHuellaValReniec
                '/*reniec*/
                ._ValidarVisitanteConReniec = Me.ValidarVisitanteConReniec
                ._ValidarModuloVisConReniec = Me.ValidarModuloVisConReniec
                'migraciones
                ._ValidarModuloVisConMigraciones = Me.ValidarModuloVisConMigraciones
                ._ValidarVisitanteConMigraciones = Me.ValidarVisitanteConMigraciones
                ._ActualizarParametricasRegionPenal()
            End With

            With Me.UscRegistroAdminv2
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._RegionNombre = Me._RegionNombre
                ._PenalNombre = Me._PenalNombre
                ._FechaVisita = Me.FechaVisita
                ''configuracion del modulo visita
                ._SolicitarAutoRegOrdinario = Me.SolicitarAutoRegOrdinario
                '/*huella*/
                ._HabilitarHuellaDigital = Me.HabilitarHuellaDigital
                ._HabilitarCapHuellaValReniec = Me.HabilitarCapHuellaValReniec
                '/*reniec*/
                ._ValidarVisitanteConReniec = Me.ValidarVisitanteConReniec
                ._ValidarModuloVisConReniec = Me.ValidarModuloVisConReniec
                'migraciones
                ._ValidarModuloVisConMigraciones = Me.ValidarModuloVisConMigraciones
                ._ValidarVisitanteConMigraciones = Me.ValidarVisitanteConMigraciones
                ._ActualizarParametricasRegionPenal()
            End With

        End Sub
        Private Sub ValoresxDefault()

            Me.UscRegistrov2._ValoresxDefault()

        End Sub
        Public Sub _ValoresxDefault()
            ValoresxDefault()
        End Sub
        Public Sub _LoadUsc()

            If ValidarPropiedadesParametricas() = False Then
                Exit Sub
            End If

            Me.FechaVisita = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            LoadUscVisitaPenal()

        End Sub
        Private Function ValidarPropiedadesParametricas()

            Dim value As Boolean = False

            If Me._RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "El parametro [_RegionID], no esta inicializado")
                Return value
            End If

            If Me._PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "El parametro [_PenalID], no esta inicializado")
                Return value
            End If

            'If Me.FechaVisita < 1 Then
            '    Legolas.Configuration.Aplication.MessageBox.MensajeError( _
            '    "El parametro [_FechaVisita], no esta inicializado")
            '    Return value
            'End If

            value = True
            Return value
        End Function
#End Region
        Private Sub chkVisitaAdmin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkVisitaAdmin.Click

            HabilitarVisitaAdministrativa()

        End Sub

        Private Sub UscRegistrov2__Click_BuscarVisitante() Handles UscRegistrov2._Click_BuscarVisitante

            SubActualizarFechaVisita()

        End Sub

        Private Sub UscRegistrov2__Click_Form_Internos(VisitanteID As Integer) Handles UscRegistrov2._Click_Form_Internos

            SubActualizarFechaVisita()
            RaiseEvent _Click_Form_Internos(VisitanteID)

        End Sub

        Private Sub UscRegistrov2__Click_Form_InternosHistoricos(VisitanteID As Integer) Handles UscRegistrov2._Click_Form_InternosHistoricos

            SubActualizarFechaVisita()
            RaiseEvent _Click_Form_InternosHistoricos(VisitanteID)

        End Sub

        Private Sub UscRegistroAdminv2__Click_BuscarVisitante() Handles UscRegistroAdminv2._Click_BuscarVisitante

            SubActualizarFechaVisita()

        End Sub

        Private Sub UscRegistrov2__Click_Form_InternosPJ(intIDVisitante As Integer) Handles UscRegistrov2._Click_Form_InternosPJ

            SubActualizarFechaVisita()
            RaiseEvent _Click_Form_InternosPJ(intIDVisitante)

        End Sub

        Private Sub UscRegistrov2__Click_Form_Menores(InternoEtapaID As Short, VisitanteID As Integer, IDCalendarioDetalle As Integer, IDCalendatrioDetalleExtraordinario As Integer) Handles UscRegistrov2._Click_Form_Menores

            RaiseEvent _Click_Form_Menores(InternoEtapaID, VisitanteID, IDCalendarioDetalle, IDCalendatrioDetalleExtraordinario)

        End Sub

        Private Sub chkVisitaAdmin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkVisitaAdmin.CheckedChanged

        End Sub
    End Class

End Namespace
