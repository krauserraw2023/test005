Namespace Visita.Visitante
    Public Class frmReporteHistorialPopup
#Region "Propiedades_Par"
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1
        Public Property _TipoReporte() As Type.Reporte.Visita
        Public Property _InternoID As Integer = -1
        Public Property _InternoApeNom As String = ""
        Public Property _VisitanteID As Integer = -1
        Public Property _VisitanteApeNom As String = ""
#End Region
#Region "Propiedades"
        Private Property VisitanteID As Integer
            Get
                Return Me.UscLabelBusqueda1._Codigo
            End Get
            Set(ByVal value As Integer)
                Me.UscLabelBusqueda1._Codigo = value
            End Set
        End Property
        Private Property InternoID As Integer
            Get
                Return Me.UscLabelBusqueda1._Codigo
            End Get
            Set(ByVal value As Integer)
                Me.UscLabelBusqueda1._Codigo = value
            End Set
        End Property
        Private Property Visitante As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(ByVal value As String)
                Me.UscLabelBusqueda1._Value = value.ToUpper
            End Set
        End Property
        Private Property Interno As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(ByVal value As String)
                Me.UscLabelBusqueda1._Value = value.ToUpper
            End Set
        End Property
        Private Property FechaIni As Long
            Get
                Return Me.dtpFechaIni.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaIni.ValueLong = value
            End Set
        End Property
        Private Property FechaFin As Long
            Get
                Return Me.dtpFechaFin.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaFin.ValueLong = value
            End Set
        End Property
#End Region
#Region "Accion"
        Private Sub AOK()

            Select Case Me._TipoReporte
                Case Type.Reporte.Visita.rptHistorialInterno

                    If Me.InternoID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Selecione Interno")
                        Exit Sub
                    End If

                Case Type.Reporte.Visita.rptHistorialVisitante

                    If Me.VisitanteID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Selecione Visitante")
                        Exit Sub
                    End If

            End Select

            Dim frm As New APPReporte.Visita.frmReporte
            With frm
                ._Filtro.Text = Me.Text
                ._Filtro.VisitanteID = Me.VisitanteID
                ._Filtro.InternoID = Me.InternoID
                ._Filtro.RegionID = Me._RegionID
                ._Filtro.PenalID = Me._PenalID
                ._Filtro.FechaInicio = Me.FechaIni
                ._Filtro.FechaFin = Me.FechaFin
                ._TipoReporte = Me._TipoReporte
                .Show()
            End With

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_BuscarVisitante()

            Dim frm As New Visita.Visitante.frmBuscarPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID

                If .ShowDialog() = DialogResult.OK Then
                    Me.VisitanteID = ._GrillaVisitanteID
                    Me.Visitante = ._GrillaVisitanteApellidosyNombres
                End If
            End With
        End Sub
        Private Sub FRM_BuscarInterno()

            Dim frm As New Visita.Interno.frmInternoPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._FechaVisita = Legolas.Configuration.Aplication.FechayHora.FechaLong
                ._VisibleRegionPenal = False
                If .ShowDialog() = DialogResult.OK Then
                    Me.InternoID = ._GrillaInternoID
                    Me.Interno = ._GrillaApellidosyNombres
                End If
            End With
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Me.FechaFin = Legolas.Configuration.Aplication.FechayHora.FechaLong
            Me.FechaIni = Legolas.Components.FechaHora.FechaPrimerDiaAnio(Me.FechaFin)

            Select Case Me._TipoReporte
                Case Type.Reporte.Visita.rptHistorialVisitante
                    Me.lblTitulo.Text = "Seleccione Visita :"

                    If Me._VisitanteID > 0 Then
                        Me.VisitanteID = Me._VisitanteID
                        Me.Visitante = Me._VisitanteApeNom
                    End If

                Case Type.Reporte.Visita.rptHistorialInterno
                    Me.lblTitulo.Text = "Seleccione Interno(a) :"

                    If Me._InternoID > 0 Then
                        Me.InternoID = Me._InternoID
                        Me.Interno = Me._InternoApeNom
                    End If
            End Select

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AOK()

        End Sub

        Private Sub frmReporteHistorialPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub UscBusquedaVisitante1__Buscar_Click() Handles UscLabelBusqueda1._Click_Buscar

            Select Case Me._TipoReporte

                Case Type.Reporte.Visita.rptHistorialVisitante
                    FRM_BuscarVisitante()
                Case Type.Reporte.Visita.rptHistorialInterno
                    FRM_BuscarInterno()
            End Select

        End Sub

        Private Sub UscLabelBusqueda1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UscLabelBusqueda1.Load

        End Sub
    End Class
End Namespace