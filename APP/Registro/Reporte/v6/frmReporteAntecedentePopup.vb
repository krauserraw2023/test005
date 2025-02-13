Namespace Registro.Reporte.V6
    Public Class frmReporteAntecedentePopup
        Private Enum TipoReporte
            Ninguno = -1
            AntecedenteJudicial = 1
            ListaAntecedenteJudicial = 3
            HistorialAntecedenteJudicial = 4
        End Enum
        Private Enum TipoReporteCertAntJudicial
            Todos = -1
            Positivo = 1
            Negativo = 2
        End Enum

        Public Property _QuitarPenalRegion As Boolean

#Region "Propiedades_UserControls"
        Public Property _VisibleBuscar As Boolean
            Get
                Return Me.UscLabelBusqueda1._Visible_Buscar
            End Get
            Set(value As Boolean)
                Me.UscLabelBusqueda1._Visible_Buscar = value
            End Set
        End Property
#End Region
#Region "propiedades_parametricas"
        Public Property _RegionID As Integer = -1
        Public Property _RegionNom As String = ""
        Public Property _PenalID As Integer = -1
        Public Property _PenalNom As String = ""
        Public Property _SolicitudId As Integer = -1
        Public Property _InternoApeNom As String = ""
        Public Property _TipoCertAntJudId As Integer = -1
        Public Property _EstadoCertAntJud As Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud
        Private Property InternoId As Integer = -1
#End Region
#Region "Propieades"
        Private Property RegionID() As Short
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.cbbRegion.Text
            End Get
        End Property
        Private Property PenalID() As Short
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.cbbPenal.Text
            End Get
        End Property
        Private Property FechaInicio() As Long
            Get

                Return Me.dtpFechaIni.ValueLong

            End Get
            Set(value As Long)
                Me.dtpFechaIni.ValueLong = value
            End Set
        End Property
        Private Property FechaFin() As Long
            Get

                Return Me.dtpFechaFin.ValueLong

            End Get
            Set(value As Long)
                Me.dtpFechaFin.ValueLong = value
            End Set
        End Property

        Private Property SolicitudCertAntJudId As Integer
            Get
                Return Me.UscLabelBusqueda1._Codigo
            End Get
            Set(ByVal value As Integer)
                Me.UscLabelBusqueda1._Codigo = value
            End Set
        End Property
        Private Property InternoNombres As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(ByVal value As String)
                Me.UscLabelBusqueda1._Value = value.ToUpper
            End Set
        End Property

        Private ReadOnly Property OpcionReporte As TipoReporte
            Get
                Dim v As TipoReporte = TipoReporte.Ninguno

                If rdbAntJudPos.Checked = True Then v = TipoReporte.AntecedenteJudicial
                If rdbListaAntJud.Checked = True Then v = TipoReporte.ListaAntecedenteJudicial
                If rdbHisAntJud.Checked = True Then v = TipoReporte.HistorialAntecedenteJudicial

                Return v
            End Get
        End Property

        Private ReadOnly Property TipoCertAntJudial As TipoReporteCertAntJudicial
            Get
                Dim v As TipoReporteCertAntJudicial = TipoReporteCertAntJudicial.Todos
                If rdbPositivo.Checked = True Then v = TipoReporteCertAntJudicial.Positivo
                If rdbNegativo.Checked = True Then v = TipoReporteCertAntJudicial.Negativo
                If rdbTodos.Checked = True Then v = TipoReporteCertAntJudicial.Todos
                Return v
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboRegion()

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                .Parametro1 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboPenal()

            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.RegionID
                .Parametro1 = Configuracion.Licencia.Codigo
                ._Todos = False
                .LoadUsc()
            End With

        End Sub
#End Region

#Region "Form"
        Private Sub FRM_ReporteAntJudicial()

            Dim frm As New APPReporte.Registro.ReporteCrystal_v2
            With frm
                Select Case Me._TipoCertAntJudId
                    Case 1
                        ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudNegativo_v1
                    Case 2
                        ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudNoPPPMD_v1
                    Case 3
                        ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudSiPPPMD_v1
                End Select

                ._Filtro.DocSolicitudAntecedenteId = Me._SolicitudId
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                ._Filtro.InternoID = -1
                ._Filtro.FechaEmisionLong = 0
                ._Filtro.DocumentoNumero = ""
                ._Filtro.Observacion = ""
                ._Filtro.FechaInicio = Me.FechaInicio
                ._Filtro.FechaFin = Me.FechaFin
                '._CebeceraReporteId = Me._CebeceraReporteId
                ._Filtro.Nota = ""
                .ShowDialog()
            End With

        End Sub

        Private Sub FRM_ReporteListaAntecedentes()
            Dim frm As New APPReporte.Registro.ReporteCrystal_v2
            With frm
                ._ReporteId = Type.Reporte.Registro.rptListaCertificadoAntecedendeJudicial_v1
                ._Filtro.Text = Me.Text
                ._Filtro.DocSolicitudAntecedenteId = Me._SolicitudId
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                ._Filtro.InternoID = -1
                ._Filtro.FechaEmisionLong = 0
                ._Filtro.DocumentoNumero = ""
                ._Filtro.Observacion = ""
                ._Filtro.FechaInicio = Me.FechaInicio
                ._Filtro.FechaFin = Me.FechaFin
                ._Filtro.TipoAntecedenteId = Me.TipoCertAntJudial.GetHashCode
                ._Filtro.Nota = ""
                .ShowDialog()
            End With
        End Sub
        Private Sub FRM_ReporteHistorialAntecedentes()
            Dim frm As New APPReporte.Registro.ReporteCrystal_v2
            With frm
                ._ReporteId = Type.Reporte.Registro.rptListaHistorialAntecedendeJudicial_LM_v1
                ._Filtro.Text = Me.Text
                ._Filtro.DocSolicitudAntecedenteId = -1 ' Me._SolicitudId
                ._Filtro.RegionID = -1 'Me._RegionID
                ._Filtro.RegionNombre = Me._RegionNom
                ._Filtro.PenalID = -1 ' Me.PenalID
                ._Filtro.InternoID = Me.InternoId
                ._Filtro.FechaEmisionLong = 0
                ._Filtro.DocumentoNumero = ""
                ._Filtro.Observacion = ""
                ._Filtro.FechaInicio = 0 'Me.FechaInicio
                ._Filtro.FechaFin = 0 'Me.FechaFin
                ' ._Filtro.TipoAntecedenteId = Me.TipoCertAntJudial.GetHashCode
                ._Filtro.Nota = ""
                .ShowDialog()
            End With
        End Sub
#End Region
#Region "accion"
        Private Function Validar() As Boolean
            Dim value As Boolean = False

            Select Case Me.OpcionReporte
                Case TipoReporte.HistorialAntecedenteJudicial
                    If Me.InternoId <= 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el interno.")
                        Return False
                    End If
                Case TipoReporte.AntecedenteJudicial
                    If Me._SolicitudId < 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la solicitud de certificado de antecedente judicial por nombre del interno.")
                        Return False
                    End If
                    If Me._EstadoCertAntJud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Pendiente Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro se encuentra en estado pendiente, para continuar es necesario finalizar el registro.")
                        Return False
                    End If
                Case TipoReporte.ListaAntecedenteJudicial
                    If Me._QuitarPenalRegion = False Then
                        If Me.RegionID < 1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Región.")
                            Me.cbbRegion.Focus()
                            Return value
                        End If

                        If Me.PenalID < 1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Penal.")
                            Me.cbbPenal.Focus()
                            Return value
                        End If
                    End If

                    'por fechas inicio
                    If Me.FechaInicio < 1 Or Me.FechaFin < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el rango de fechas.")
                        Me.dtpFechaIni.Focus()
                        Return value
                    End If

                    'la fecha mayor no puede ser menor a la fecha ini
                    If Me.FechaFin < Me.FechaInicio Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin, no puede ser mayor a la fecha de inicio.")
                        Me.dtpFechaIni.Focus()
                        Return value
                    End If
            End Select

            Return True
        End Function


        Private Sub AOK()

            If Validar() = False Then Exit Sub

            Select Case Me.OpcionReporte
                Case TipoReporte.AntecedenteJudicial
                    FRM_ReporteAntJudicial()
                Case TipoReporte.ListaAntecedenteJudicial
                    FRM_ReporteListaAntecedentes()
                Case TipoReporte.HistorialAntecedenteJudicial
                    FRM_ReporteHistorialAntecedentes()
                Case Else
                    Exit Sub
            End Select
            'Me.DialogResult = Windows.Forms.DialogResult.OK
        End Sub
#End Region
        Private Sub HabilitarControl()
            Select Case Me.OpcionReporte
                Case TipoReporte.AntecedenteJudicial
                    rdbInternoTodos.Enabled = False
                    rdbSeleccionarInterno.Enabled = True
                    UscLabelBusqueda1.Enabled = True
                    grbFechas.Enabled = False
                    grbTipoCertAnt.Enabled = False
                    rdbSeleccionarInterno.Checked = True
                    Me.InternoNombres = Me._InternoApeNom
                Case TipoReporte.ListaAntecedenteJudicial
                    Me.InternoNombres = "[TODOS]"
                    rdbInternoTodos.Checked = True
                    rdbInternoTodos.Enabled = True
                    rdbSeleccionarInterno.Enabled = False
                    UscLabelBusqueda1.Enabled = False
                    grbFechas.Enabled = True
                    grbTipoCertAnt.Enabled = True
                Case TipoReporte.HistorialAntecedenteJudicial
                    'rdbInternoTodos.Checked = True
                    rdbInternoTodos.Enabled = False
                    rdbSeleccionarInterno.Enabled = False
                    UscLabelBusqueda1.Enabled = True
                    grbFechas.Enabled = False
                    grbTipoCertAnt.Enabled = False
                    Me.InternoNombres = ""
                    UscLabelBusqueda1._Codigo = -1
            End Select
        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

            AOK()

        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub rdbAntJud_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbAntJudPos.CheckedChanged, rdbListaAntJud.CheckedChanged
            HabilitarControl()
        End Sub

        Private Sub frmReporteAntecedentePopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            ComboRegion()
            ComboPenal()

            If Me._PenalID > 0 Then
                Me.RegionID = Me._RegionID
                Me.PenalID = Me._PenalID
            End If
            dtpFechaFin.ValueLong = Now.ToFileTime
            Me.InternoNombres = Me._InternoApeNom

            If Me._QuitarPenalRegion = True Then
                grbRegionPenal.Visible = False
                Me.RegionID = -1
                Me.PenalID = -1
            End If


        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            ComboPenal()
        End Sub

        Private Sub FRM_BuscarCertificadoAJ()
            If rdbHisAntJud.Checked = True Then
                Dim frm As New Registro.Main.Antecedentes.frmBuscaInternoPopup
                With frm
                    If .ShowDialog() = DialogResult.OK Then
                        Me.InternoId = frm._InternoId
                        Me.InternoNombres = frm._ApellidosNombres
                    End If
                End With
            Else
                Dim frm As New Registro.Main.Antecedentes.frmBuscarAntecedentesPopup
                With frm
                    If .ShowDialog() = DialogResult.OK Then
                        Me.SolicitudCertAntJudId = frm._SolicitudAntJudId
                        Me.InternoNombres = frm._InternoNombres
                        Me._InternoApeNom = frm._InternoNombres
                        Me._SolicitudId = frm._SolicitudAntJudId
                        Me._TipoCertAntJudId = frm._TipoCertAntJudId
                        Me._EstadoCertAntJud = frm._EstadoCertAntJud
                    End If
                End With
            End If
        End Sub

        Private Sub UscLabelBusqueda1__Click_Buscar() Handles UscLabelBusqueda1._Click_Buscar
            FRM_BuscarCertificadoAJ()
        End Sub

        Private Sub frmReporteAntecedentePopup_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then Me.Close()
        End Sub

        Private Sub rdbHisAntJud_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbHisAntJud.CheckedChanged
            HabilitarControl()
        End Sub
    End Class
End Namespace