Namespace Tratamiento.TallerAsistencia.Reporte
    Public Class frmReportePopup
        Private objentCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
#Region "Propiedades_Para"
        Private Property TipoReporte() As Type.Reporte.Tratamiento.Trabajo.TallerAsistencia = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.Ninguno
#End Region
#Region "Propiedades"
        Public Property _RegionId As Integer = -1
        Public Property _PenalId As Integer = -1
        Private Property IDInterno As Integer
            Get
                Return Me.UscLabelBusqueda1._Codigo
            End Get
            Set(ByVal value As Integer)
                Me.UscLabelBusqueda1._Codigo = value
            End Set
        End Property
        Private Property CodigoRP As String = ""
        Private Property InternoApeNom As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(ByVal value As String)
                Me.UscLabelBusqueda1._Value = value.ToUpper
            End Set
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
        Public Property _FechaIncripcion As Long = 0
#End Region
#Region "Combo"

        Private Sub ComboTaller()
            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbTalleres
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = Combo_Talleres(True)
                .SelectedValue = -1
            End With
        End Sub
        Public Function Combo_Talleres(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]") As DataTable

            Dim Bss As New Bussines.Tratamiento.TallerAsistencia.InternoTaller
            Dim objCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim objEnt As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            objEnt.InternoID = Me.IDInterno
            objEnt.RegionID = Me._RegionId
            objEnt.PenalID = Me._PenalId
            objentCol = Bss.ListarTaller_v2(objEnt)

            Dim objDT As New DataTable("Cargo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))

            If blnAddprimeraFila = True Then
                objDT.Rows.Add(New Object() {-1, strMensaje})
            End If

            For Each obj As Entity.Tratamiento.TallerAsistencia.InternoTaller In objentCol
                objDT.Rows.Add(New Object() {obj.CodigoTaller, (obj.NombreTaller).ToUpper})
            Next

            objDT.AcceptChanges()
            Return objDT

        End Function

#End Region
#Region "Otros"

        Private Sub AOK()

            frm_Reporte()

        End Sub

#End Region
#Region "Form"
        Private Sub frm_Reporte()

            Select Case Me.TipoReporte

                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_mov_internoasistencia
                    FRM_ReporteAsistenciaInterno()
                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaLaboral_v1

                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_mov_asistencia
                    FRM_ReporteAsistencia()
                Case Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaIndividual_v1
                    FRM_ReportePlanillaIndividual()
            End Select

        End Sub
        Private Sub FRM_ReporteAsistencia()

            If Me.FechaInicio < 1 Or Me.FechaFin < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese rango de fechas")
                Exit Sub
            End If

            If Me.FechaFin < Me.FechaInicio Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin, no puede ser menor a la fecha inicio")
                Exit Sub
            End If

            Dim frm As New APPReporte.Tratamiento.TallerAsistencia.ReporteCrystal
            With frm
                ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaLaboral_v1
                ._Filtro.FechaInicio = Me.FechaInicio
                ._Filtro.FechaFin = Me.FechaFin
                .ShowDialog()
            End With
        End Sub
        Private Sub FRM_ReporteAsistenciaInterno()

            If Me.IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione interno")
                Exit Sub
            End If

            If Me.FechaInicio < 1 Or Me.FechaFin < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese rango de fechas")
                Exit Sub
            End If

            If Me.FechaFin < Me.FechaInicio Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin, no puede ser menor a la fecha inicio")
                Exit Sub
            End If

            Dim frm As New APPReporte.Tratamiento.TallerAsistencia.ReporteCrystal
            With frm
                ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_mov_internoasistencia
                ._Filtro.InternoID = Me.IDInterno
                ._Filtro.FechaInicio = Me.FechaInicio
                ._Filtro.FechaFin = Me.FechaFin
                .ShowDialog()
            End With

        End Sub
        Private Sub FRM_ReportePlanillaIndividual()

            If Me.IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione interno")
                Exit Sub
            End If

            If Me.FechaInicio < 1 Or Me.FechaFin < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese rango de fechas")
                Exit Sub
            End If

            If Me.FechaFin < Me.FechaInicio Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin, no puede ser menor a la fecha inicio")
                Exit Sub
            End If

            Dim frm As New APPReporte.Tratamiento.TallerAsistencia.ReporteCrystal
            With frm
                ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaIndividual_v1
                ._Filtro.InternoID = Me.IDInterno
                ._Filtro.FechaInicio = Me.FechaInicio
                ._Filtro.FechaFin = Me.FechaFin
                ._Filtro.RegionID = Me._RegionId
                ._Filtro.PenalID = Me._PenalId
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Otros"
        Public Sub _LoadParametros(objTipoReporte As Type.Reporte.Tratamiento.Trabajo.TallerAsistencia,
                                    intIDInterno As Integer, strInternoApeNom As String)

            Me.TipoReporte = objTipoReporte
            Me.IDInterno = intIDInterno
            Me.InternoApeNom = strInternoApeNom

        End Sub
        Private Sub ValoresxDefault()
            ComboTaller()
            Dim lngFecha As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong
            Me.FechaInicio = Legolas.Components.FechaHora.FechaPrimerDiaMes(lngFecha)
            Me.FechaFin = Legolas.Components.FechaHora.FechaUltimoDiaMes(lngFecha)
            gbTaller.Visible = False
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

        Private Sub rbtAsistencia_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAsistencia.CheckedChanged
            gbTaller.Visible = False
            Dim lngFecha As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong
            dtpFechaIni.ValueLong = Legolas.Components.FechaHora.FechaPrimerDiaMes(lngFecha)
            dtpFechaIni.Enabled = True
            dtpFechaFin.Enabled = True
            Me.TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_mov_internoasistencia
        End Sub

        Private Sub rbtPlanilla_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPlanilla.CheckedChanged
            gbTaller.Visible = True
            dtpFechaIni.ValueLong = Me._FechaIncripcion
            dtpFechaIni.Enabled = False
            dtpFechaFin.Enabled = False
            Me.TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaIndividual_v1
        End Sub
    End Class
End Namespace