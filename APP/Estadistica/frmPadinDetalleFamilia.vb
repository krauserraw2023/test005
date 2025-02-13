Namespace Estadistica
    Public Class frmPadinDetalleFamilia
        Private objEntCol As Entity.Estadistica.PadinDetalleCol = Nothing
        Private objBss As Bussines.Estadistica.PadinDetalle = Nothing
#Region "Propiedades"
        Private intPadinID As Integer = -1
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Private intAnio As Integer = -1
        Private intMes As Integer = -1
        Public Property _PadinID() As Integer
            Get
                Return intPadinID
            End Get
            Set(ByVal value As Integer)
                intPadinID = value
            End Set
        End Property
        Public Property _RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Public Property _RegionNombre() As String
            Get
                Return Me.txtRegion.Text
            End Get
            Set(ByVal value As String)
                Me.txtRegion.Text = value.ToUpper
            End Set
        End Property
        Public Property _PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
        Public Property _PenalNombre() As String
            Get
                Return Me.txtPenal.Text
            End Get
            Set(ByVal value As String)
                Me.txtPenal.Text = value.ToUpper
            End Set
        End Property
        Public Property _Anio() As Integer
            Get
                Return intAnio
            End Get
            Set(ByVal value As Integer)
                intAnio = value
            End Set
        End Property
        Public Property _Mes() As Integer
            Get
                Return intMes
            End Get
            Set(ByVal value As Integer)
                intMes = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()

            objEntCol = New Entity.Estadistica.PadinDetalleCol
            objBss = New Bussines.Estadistica.PadinDetalle

            objEntCol = objBss.Listar(-1, Me._PadinID, -1, -1, -1, "", "")

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.lblReg.Text = .RowCount() & " Reg."
            End With

        End Sub
#End Region
#Region "Accion"


#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Me.dgwGrilla.VisibleCampos = True
            GrillaCampos()

        End Sub
        Private Sub GrillaCampos()

            'Me.col_fec_ing_sis_pen.Tag = "fecha"
            'Me.col_fec_ing_pen.Tag = "fecha"
            'Me.col_fec_sen.Tag = "fecha"
            'Me.col_fec_ini.Tag = "fecha"
            'Me.col_fec_fin.Tag = "fecha"
            'Me.col_fec_nac.Tag = "fecha"
            'Me.col_fec_egr.Tag = "fecha"

            'Me.col_mes_rec.Tag = "numero"
            'Me.col_ing_num.Tag = "numero"
            'Me.col_sen_pen_anio.Tag = "numero"
            'Me.col_sen_pen_mes.Tag = "numero"
            'Me.col_sen_pen_dia.Tag = "numero"
            'Me.col_sen_tot_mes.Tag = "numero"
            'Me.col_eda.Tag = "numero"
            'Me.col_num_hij.Tag = "numero"

        End Sub
        Private Sub ReporteF1()

            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte1
                ._PadinID = Me._PadinID
                ._PenalID = Me._PenalID
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                .Show()
            End With

        End Sub
        Private Sub ReporteCuadro14()

            Dim frm As New Estadistica.frmNominalPopup
            With frm
                ._RegionID = Me._RegionID
                ._RegionNombre = Me._RegionNombre
                ._PenalID = Me._PenalID
                ._PenalNombre = Me._PenalNombre
                ._PadinID = Me._PadinID
                .ShowDialog()
            End With

        End Sub
        Private Sub ReporteCuadro15()

            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte3
                ._PadinID = Me._PadinID
                ._PenalID = Me._PenalID
                .Show()
            End With

        End Sub
#End Region

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then

                        Me.Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        Me.Cursor = Cursors.Default

                        .Refresh()

                    End If
                End With

            Catch ex As Exception

            End Try

        End Sub

        Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting


            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_ing_sis_pen").Index, _
                    .Columns("col_fec_ing_pen").Index, _
                    .Columns("col_fec_sen").Index, _
                    .Columns("col_fec_ini").Index, _
                    .Columns("col_fec_fin").Index, _
                    .Columns("col_fec_nac").Index, _
                    .Columns("col_fec_egr").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                            'e.Value = DateTime.FromFileTime(e.Value).ToShortDateString
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub


        Private Sub frmPadinDetalle_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Listar()

        End Sub

        Private Sub btnReporteF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteF1.Click

            ReporteF1()

        End Sub

        Private Sub btnCuadro14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuadro14.Click

            ReporteCuadro14()

        End Sub

        Private Sub btnCuadro15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuadro15.Click

            ReporteCuadro15()

        End Sub
    End Class
End Namespace
