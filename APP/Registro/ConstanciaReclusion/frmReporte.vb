
Namespace Registro.ConstanciaReclusion
    Public Class frmReporte
        Private idLicencia As Short = 0
        Private esORL As Boolean = False
        Public Sub New(idLicencia As Short, esORL As Boolean)

            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Me.idLicencia = idLicencia
            Me.esORL = esORL

        End Sub
#Region "Propiedades"
        Private Property idRegion As Integer
            Get
                Return cbbRegion.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegion.SelectedValue = value
            End Set
        End Property

        Private Property idPenal As Integer
            Get
                Return cbbPenal.SelectedValue
            End Get
            Set(value As Integer)
                cbbPenal.SelectedValue = value
            End Set
        End Property

        Private Property idTipoSolicitante As Integer
            Get
                Return cbbTipSolicitante.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipSolicitante.SelectedValue = value
            End Set
        End Property

        Private Property fechaInicioBusqueda As DateTime
            Get
                Dim value As DateTime
                If Me.dtpFechaIni.ValueLong > 0 Then
                    value = Me.dtpFechaIni.Value
                Else
                    value = Nothing
                End If
                Return value
            End Get
            Set(value As DateTime)
                Me.dtpFechaIni.Value = value
            End Set
        End Property

        Private Property fechaFinBusqueda As DateTime
            Get
                Dim value As DateTime
                If Me.dtpFechaFin.ValueLong > 0 Then
                    value = Me.dtpFechaFin.Value
                Else
                    value = Nothing
                End If
                Return value
            End Get
            Set(value As DateTime)
                Me.dtpFechaFin.Value = value
            End Set
        End Property


        Private ReadOnly Property tipoTramite As Short
            Get
                Dim value As Integer = -1

                If rdbsinCosto.Checked = True Then
                    value = 0
                End If

                If rdbconCosto.Checked = True Then
                    value = 1
                End If

                Return value
            End Get

        End Property
        Private ReadOnly Property tipoTramiteNombre As String
            Get
                Dim value As String = ""

                Select Case Me.tipoTramite
                    Case 0
                        value = "SIN COSTO"
                    Case 1
                        value = "CON COSTO"
                    Case Else
                        value = "AMBOS"
                End Select
                Return value
            End Get
        End Property
#End Region
#Region "Combos"
        Private cargoComboRegion As Boolean = False
        Private Sub comboRegion()
            Dim blnTodos As Boolean = False

            If Me.idLicencia = 1 Then 'sede central
                blnTodos = True
            End If

            With cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                ._Todos = blnTodos
                .Parametro1 = Me.idLicencia
                .LoadUsc()

                If esORL = True Then
                    .SelectedValue = 3 'region lima
                    .Enabled = False
                End If

            End With
            cargoComboRegion = True
        End Sub
        Private Sub comboPenal()
            Dim blnTodos As Boolean = False

            If Me.idLicencia = 1 Then 'sede central
                blnTodos = True
            Else
                Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
                Dim objBssLicencia As New Bussines.Sistema.Instalacion
                intTipoLicencia = objBssLicencia.ListarTipo(idLicencia)

                Select Case intTipoLicencia
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                        blnTodos = True
                End Select
            End If

            With Me.cbbPenal
                ._Todos = blnTodos
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.idRegion
                .Parametro1 = Me.idLicencia
                .LoadUsc()
            End With
        End Sub
        Private Sub comboSolicitante()
            With cbbTipSolicitante
                .ComboTipo = Type.Combo.ComboTipo.TipoAutoridadJudicialSolicitante
                ._Todos = True
                .LoadUsc()
            End With
        End Sub

#End Region
#Region "Formularios"
        Private Sub frmVerReporte()

            If Me.dtpFechaIni.ValueLong < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha desde")
                Me.dtpFechaIni.Focus()
                Exit Sub
            End If

            If Me.dtpFechaFin.ValueLong < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha hasta")
                Me.dtpFechaFin.Focus()
                Exit Sub
            End If

            Dim filtro As New Entity.Registro.ConstanciaReclusion.ReporteFiltro
            With filtro
                .idRegion = Me.idRegion
                .regionNombre = Me.cbbRegion.Text
                .idPenal = Me.idPenal
                .penalNombre = Me.cbbPenal.Text
                .fechaInicio = Me.dtpFechaIni.Value
                .fechaFin = Me.dtpFechaFin.Value
                .idSolicitante = Me.idTipoSolicitante
                .tipoTramite = Me.tipoTramite
                .tipoTramiteNombre = Me.tipoTramiteNombre
            End With

            Dim tipoReporte As Type.Enumeracion.ConstanciaReclusion.enmReporte = Type.Enumeracion.ConstanciaReclusion.enmReporte.expedicionConstancias

            If Me.idPenal = -1 Then
                tipoReporte = Type.Enumeracion.ConstanciaReclusion.enmReporte.expedicionConstanciaGrupo
            End If

            Dim frm As New APPReporte.Registro.ConstanciaReclusion.frmReporte(tipoReporte, filtro)
            With frm
                .ShowDialog()
            End With

        End Sub
#End Region

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

            frmVerReporte

        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles Me.Load

            comboRegion()
            comboPenal()
            comboSolicitante()

        End Sub

        Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        End Sub

        Private Sub dtpFechaIni_Load(sender As Object, e As EventArgs) Handles dtpFechaIni.Load

        End Sub

        Private Sub cbbRegion_Load(sender As Object, e As EventArgs) Handles cbbRegion.Load

        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            If cargoComboRegion = True Then
                comboPenal()
            End If

        End Sub
    End Class
End Namespace

