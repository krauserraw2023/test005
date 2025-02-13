Namespace Visita.Config
    Public Class frmMantPopup
        Private objBss As Bussines.Visita.Config = Nothing
        Private objEnt As Entity.Visita.Config = Nothing
        '12-09-2024 e.cu.cco
        Private objBssAutConf As Bussines.Visita.AutorizacionConfiguracion = Nothing
        Private objEntAutConf As Entity.Visita.AutorizacionConfiguracion = Nothing
#Region "Propiedades"
        Public Property _Codigo() As Integer = -1
        Public Property _RegionID() As Short = -1
        Public Property _PenalID As Short = -1
        Private Property RegimenTipoID() As Short
            Get
                Return Me.cbbTipoRegimen.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbTipoRegimen.SelectedValue = value
            End Set
        End Property
        Private Property Sexo() As Short
            Get
                Dim value As Integer = -1

                If Me.rdbHombres.Checked = True Then
                    value = 1
                End If

                If Me.rdbMujeres.Checked = True Then
                    value = 0
                End If

                If Me.rdbSexoAmbos.Checked = True Then
                    value = 10
                End If

                Return value

            End Get
            Set(ByVal value As Short)

                Select Case value
                    Case 0
                        Me.rdbMujeres.Checked = True
                    Case 1
                        Me.rdbHombres.Checked = True
                    Case 10
                        Me.rdbSexoAmbos.Checked = True
                    Case Else
                        Me.rdbHombres.Checked = False
                        Me.rdbMujeres.Checked = False
                End Select
            End Set
        End Property
        Private Property InicioHora() As Integer
            Get
                Return Me.nudInicioHora.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudInicioHora.Value = value
            End Set
        End Property
        Private Property InicioMinuto() As Integer
            Get
                Return Me.nudInicioMinuto.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudInicioMinuto.Value = value
            End Set
        End Property
        Private Property FinHora() As Integer
            Get
                Return Me.nudFinHora.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudFinHora.Value = value
            End Set
        End Property
        Private Property FinMinuto() As Integer
            Get
                Return Me.nudFinMinuto.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudFinMinuto.Value = value
            End Set
        End Property
        Private Property CapacidadInternos As Integer
            Get
                Return Me.nudCapacidadInternos.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudCapacidadInternos.Value = value
            End Set
        End Property
        Private Property CapacidadMaxAforo As Short
            Get
                Return Me.nudCantMaxAforo.Value
            End Get
            Set(ByVal value As Short)
                Me.nudCantMaxAforo.Value = value
            End Set
        End Property
        Private Property CapacidadMaxVisitantes As Integer
            Get
                Return Me.nudCantMaxVisitantes.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudCantMaxVisitantes.Value = value
            End Set
        End Property
        Private Property SolicitarInfoPabellon() As Boolean
            Get
                Return Me.chkSolInfoPabellon.Checked
            End Get
            Set(value As Boolean)
                Me.chkSolInfoPabellon.Checked = value
            End Set
        End Property
        Private Property SolicitarAutorizacionRegimenOrdinario() As Boolean
            Get
                Return Me.chkSolicitarAutoRegOrd.Checked
            End Get
            Set(value As Boolean)
                Me.chkSolicitarAutoRegOrd.Checked = value
            End Set
        End Property
        Private Property SolicitarAutorizacionAbogado As Boolean
            Get
                Return Me.chkSolRegAbogado.Checked
            End Get
            Set(value As Boolean)
                Me.chkSolRegAbogado.Checked = value
            End Set
        End Property
        Private Property SolicitaModuloPOPE() As Boolean
            Get
                Return Me.chkModuloPope.Checked
            End Get
            Set(value As Boolean)
                Me.chkModuloPope.Checked = value
            End Set
        End Property

        Private Property HabilitarInternoPJ As Boolean
            Get
                Return Me.chkInternoPJ.Checked
            End Get
            Set(value As Boolean)
                Me.chkInternoPJ.Checked = value
            End Set
        End Property
        Private Property HabilitarSancionesSede As Boolean
            Get
                Return Me.chkSancionSede.Checked
            End Get
            Set(value As Boolean)
                Me.chkSancionSede.Checked = value
            End Set
        End Property

        Private Property HabilitaHuellaDigital As Boolean
            Get
                Return Me.chkHuellaDigital.Checked
            End Get
            Set(value As Boolean)
                Me.chkHuellaDigital.Checked = value
            End Set
        End Property

        Private Property CapturarHuellaValReniec As Boolean
            Get
                Return Me.chkHuellaValReniec.Checked
            End Get
            Set(value As Boolean)
                Me.chkHuellaValReniec.Checked = value
            End Set
        End Property
        Private Property ValidarVisitanteConReniec As Boolean
            Get
                Return Me.chkVisitanteValReniec.Checked
            End Get
            Set(value As Boolean)
                Me.chkVisitanteValReniec.Checked = value
            End Set
        End Property
        Private Property ValidarModuloVisConReniec As Boolean
            Get
                Return Me.chkValidacionReniecModVisita.Checked
            End Get
            Set(value As Boolean)
                Me.chkValidacionReniecModVisita.Checked = value
            End Set
        End Property
        Private Property ValidarModuloVisConMigraciones As Boolean
            Get
                Return Me.chkValModVisConMigra.Checked
            End Get
            Set(value As Boolean)
                Me.chkValModVisConMigra.Checked = value
            End Set
        End Property
        Private Property ValidarVisitanteConMigraciones As Boolean
            Get
                Return Me.chkPermitirVisConMigra.Checked
            End Get
            Set(value As Boolean)
                Me.chkPermitirVisConMigra.Checked = value
            End Set
        End Property
        Private Property Estado() As Short = 1 'alta
#End Region
#Region "PropiedadesAutorizacion"
        Private Property ConfiguracionCodigo() As Integer = -1
        Private Property ConfiguracionDiaMaximo() As Integer
            Get
                Return Me.nudMaximoAutorizacion.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudMaximoAutorizacion.Value = value
            End Set
        End Property

        Private Property ConfiguracionEnero() As Boolean
            Get
                Return Me.ChkConfiguracionEnero.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionEnero.Checked = value
            End Set
        End Property

        Private Property ConfiguracionFebrero As Boolean
            Get
                Return Me.ChkConfiguracionFebrero.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionFebrero.Checked = value
            End Set
        End Property
        Private Property ConfiguracionMarzo As Boolean
            Get
                Return Me.ChkConfiguracionMarzo.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionMarzo.Checked = value
            End Set
        End Property

        Private Property ConfiguracionAbril As Boolean
            Get
                Return Me.ChkConfiguracionAbril.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionAbril.Checked = value
            End Set
        End Property
        Private Property ConfiguracionMayo As Boolean
            Get
                Return Me.ChkConfiguracionMayo.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionMayo.Checked = value
            End Set
        End Property
        Private Property ConfiguracionJunio As Boolean
            Get
                Return Me.ChkConfiguracionJunio.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionJunio.Checked = value
            End Set
        End Property
        Private Property ConfiguracionJulio As Boolean
            Get
                Return Me.ChkConfiguracionJulio.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionJulio.Checked = value
            End Set
        End Property
        Private Property ConfiguracionAgosto As Boolean
            Get
                Return Me.ChkConfiguracionAgosto.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionAgosto.Checked = value
            End Set
        End Property
        Private Property ConfiguracionSetiembre As Boolean
            Get
                Return Me.ChkConfiguracionSetiembre.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionSetiembre.Checked = value
            End Set
        End Property
        Private Property ConfiguracionOctubre As Boolean
            Get
                Return Me.ChkConfiguracionOctubre.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionOctubre.Checked = value
            End Set
        End Property
        Private Property ConfiguracionNoviembre As Boolean
            Get
                Return Me.ChkConfiguracionNoviembre.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionNoviembre.Checked = value
            End Set
        End Property
        Private Property ConfiguracionDiciembre As Boolean
            Get
                Return Me.ChkConfiguracionDiciembre.Checked
            End Get
            Set(value As Boolean)
                Me.ChkConfiguracionDiciembre.Checked = value
            End Set
        End Property
        Private Property ConfiguracionEstado() As Integer = -1
#End Region
#Region "Combo"
        Private Sub ComboRegimenTipo()

            With Me.cbbTipoRegimen
                .Parametro1 = 1 'tipo 1 activado
                ._Todos = False
                ._LoadUsc(Type.Combo.ComboTipo.VIS_RegimenVisita)
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub ListarMant()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Visita.Config
            objEnt = New Entity.Visita.Config

            objEnt = objBss.Listar(Me._Codigo)

            With objEnt
                Me._RegionID = .RegionID
                Me._PenalID = .PenalID
                Me.RegimenTipoID = .RegimenTipoID
                Me.Sexo = .SexoID
                Me.InicioHora = .InicioHora
                Me.InicioMinuto = .InicioMinuto
                Me.FinHora = .FinHora
                Me.FinMinuto = .FinMinuto
                Me.CapacidadInternos = .CapacidadInternos
                Me.CapacidadMaxAforo = .CapacidadAforo
                Me.CapacidadMaxVisitantes = .CapacidadVisitas
                Me.SolicitarInfoPabellon = .SolicitaInfoPabellon
                Me.SolicitarAutorizacionRegimenOrdinario = .SolicitaAutoRegOrdinario
                Me.SolicitarAutorizacionAbogado = .SolicitaAutoRegAbogado
                Me.SolicitaModuloPOPE = .SolicitaModuloPOPE
                'huella
                Me.HabilitaHuellaDigital = .HabilitaHuellaDigital
                Me.CapturarHuellaValReniec = .CapturarHuellaValReniec
                'reniec
                Me.ValidarVisitanteConReniec = .ValidarVisitanteConReniec
                Me.ValidarModuloVisConReniec = .ValidarModVisitaConReniec
                'migraciones
                Me.ValidarModuloVisConMigraciones = .ValidarModVisitaConMigraciones
                Me.ValidarVisitanteConMigraciones = .ValidarVisitanteConMigraciones

                Me.HabilitarInternoPJ = .HabilitarInternosPJ
                Me.HabilitarSancionesSede = .HabilitarSancionSede

                Me.Estado = .Estado
            End With

        End Sub
#End Region
#Region "Listar_Autorizacion"
        Private Sub ListarMant_Autorizacion()

            objBssAutConf = New Bussines.Visita.AutorizacionConfiguracion
            objEntAutConf = New Entity.Visita.AutorizacionConfiguracion
            objEntAutConf.RegionID = Me._RegionID
            objEntAutConf.PenalID = Me._PenalID
            objEntAutConf = objBssAutConf.Listar(Me.ConfiguracionCodigo, Me._PenalID, Me._RegionID)

            With objEntAutConf
                Me.ConfiguracionCodigo = .Codigo
                Me.ConfiguracionDiaMaximo = IIf(.ConfiguracionDiaMaximo = -1, 1, .ConfiguracionDiaMaximo)
                Me.ConfiguracionEnero = .ConfiguracionEnero
                Me.ConfiguracionFebrero = .ConfiguracionFebrero
                Me.ConfiguracionMarzo = .ConfiguracionMarzo
                Me.ConfiguracionAbril = .ConfiguracionAbril
                Me.ConfiguracionMayo = .ConfiguracionMayo
                Me.ConfiguracionJunio = .ConfiguracionJunio
                Me.ConfiguracionJulio = .ConfiguracionJulio
                Me.ConfiguracionAgosto = .ConfiguracionAgosto
                Me.ConfiguracionSetiembre = .ConfiguracionSetiembre
                Me.ConfiguracionOctubre = .ConfiguracionOctubre
                Me.ConfiguracionNoviembre = .ConfiguracionNoviembre
                Me.ConfiguracionDiciembre = .ConfiguracionDiciembre
                Me.ConfiguracionEstado = .EstadoID
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            If Me.RegimenTipoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Seleccione el Regimen de Visita")
                Me.cbbTipoRegimen.Focus()
                Return value
            End If

            value = True

            Return value

        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            Dim value As Integer = -1
            objBss = New Bussines.Visita.Config
            objEnt = New Entity.Visita.Config

            With objEnt
                .Codigo = Me._Codigo
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .RegimenTipoID = Me.RegimenTipoID
                .SexoID = Me.Sexo
                .InicioHora = Me.InicioHora
                .InicioMinuto = Me.InicioMinuto
                .FinHora = Me.FinHora
                .FinMinuto = Me.FinMinuto
                .CapacidadInternos = Me.CapacidadInternos
                .CapacidadAforo = Me.CapacidadMaxAforo
                .CapacidadVisitas = Me.CapacidadMaxVisitantes
                .SolicitaInfoPabellon = Me.SolicitarInfoPabellon
                .SolicitaAutoRegOrdinario = Me.SolicitarAutorizacionRegimenOrdinario
                .SolicitaAutoRegAbogado = Me.SolicitarAutorizacionAbogado
                .SolicitaModuloPOPE = Me.SolicitaModuloPOPE
                .HabilitaHuellaDigital = Me.HabilitaHuellaDigital
                .CapturarHuellaValReniec = Me.CapturarHuellaValReniec
                'reniec
                .ValidarVisitanteConReniec = Me.ValidarVisitanteConReniec
                .ValidarModVisitaConReniec = Me.ValidarModuloVisConReniec
                'migraciones
                .ValidarModVisitaConMigraciones = Me.ValidarModuloVisConMigraciones
                .ValidarVisitanteConMigraciones = Me.ValidarVisitanteConMigraciones

                .HabilitarInternosPJ = Me.HabilitarInternoPJ
                .HabilitarSancionSede = Me.HabilitarSancionesSede

                .Estado = Me.Estado
            End With

            value = objBss.Grabar(objEnt)

            Grabar_Autorizacion()

            If value > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
        Private Sub Grabar_Autorizacion()
            Dim value As Integer = -1
            objBssAutConf = New Bussines.Visita.AutorizacionConfiguracion
            objEntAutConf = New Entity.Visita.AutorizacionConfiguracion

            With objEntAutConf
                .Codigo = Me.ConfiguracionCodigo
                .ConfiguracionDiaMaximo = Me.ConfiguracionDiaMaximo
                .ConfiguracionEnero = Me.ConfiguracionEnero
                .ConfiguracionFebrero = Me.ConfiguracionFebrero
                .ConfiguracionMarzo = Me.ConfiguracionMarzo
                .ConfiguracionAbril = Me.ConfiguracionAbril
                .ConfiguracionMayo = Me.ConfiguracionMayo
                .ConfiguracionJunio = Me.ConfiguracionJunio
                .ConfiguracionJulio = Me.ConfiguracionJulio
                .ConfiguracionAgosto = Me.ConfiguracionAgosto
                .ConfiguracionSetiembre = Me.ConfiguracionSetiembre
                .ConfiguracionOctubre = Me.ConfiguracionOctubre
                .ConfiguracionNoviembre = Me.ConfiguracionNoviembre
                .ConfiguracionDiciembre = Me.ConfiguracionDiciembre
                '.EstadoID = Me.ConfiguracionEstado
                .EstadoID = 0
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            value = objBssAutConf.Grabar(objEntAutConf)

            objEntAutConf.Codigo = -1
            objEntAutConf.EstadoID = 1
            objEntAutConf.RegionID = Me._RegionID
            objEntAutConf.PenalID = Me._PenalID
            value = objBssAutConf.Grabar(objEntAutConf)

            If value > 0 Then
                'Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
        Sub visualizar_cuadro()
            'If Legolas.Configuration.Usuario.Oficina = 1 Then
            If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                grpMeses.Visible = True
            Else
                grpMeses.Visible = False
            End If
        End Sub
#End Region
#Region "Permisos/Accesos"
        Private Sub Usuario_Permisos()

            'Me.btnOK.Visible = Me._FormEscritura

            If Me._Codigo > 0 Then
                Me.btnOK.Visible = False
            End If

        End Sub
#End Region
#Region "Otros"
        
        Private Sub ValoresxDefault()

            Usuario_Permisos()
            ComboRegimenTipo()
            visualizar_cuadro()
        End Sub
#End Region

        Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

            Me.Close()

        End Sub

        Private Sub frmMantPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

            AOK()

        End Sub

        Private Sub frmMantPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarMant()
            ListarMant_Autorizacion()
        End Sub
        Private Sub btnAceptarAutorizacion_Click(sender As Object, e As EventArgs) Handles btnAceptarAutorizacion.Click
            Grabar_Autorizacion()

        End Sub
    End Class
End Namespace