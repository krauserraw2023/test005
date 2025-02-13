Namespace Estadistica.v45

    Public Class frmPadinDetalle
        Private objEntCol As Entity.Estadistica.PadinDetalleCol = Nothing
        Private objBss As Bussines.Estadistica.PadinDetalle = Nothing
#Region "Propiedades_Parametricas"
        Public Property _PadinID() As Integer=-1                  
        Public Property _RegionID() As Integer=-1            
        Public Property _RegionNombre() As String
            Get
                Return Me.txtRegion.Text
            End Get
            Set(ByVal value As String)
                Me.txtRegion.Text = value.ToUpper
            End Set
        End Property
        Public Property _PenalID() As Integer=-1         
        Public Property _PenalNombre() As String
            Get
                Return Me.txtPenal.Text
            End Get
            Set(ByVal value As String)
                Me.txtPenal.Text = value.ToUpper
            End Set
        End Property
        Public Property _Anio() As Integer=-1          
        Public Property _Mes() As Integer = -1

        Public Property _FechaInicio As Long = 0
        Public Property _FechaFin As Long = 0
        Public Property _FechaCorte As Long = 0
        Public Property _Correlativo As Integer = 0
        Public Property _VersionReporte As Integer = -1

#End Region
#Region "Propiedades_Busqueda"
        Private Property CodigoInterno() As String
            Get
                Return Me.txtCodInterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodInterno.Text = value
            End Set
        End Property
        Private Property ApellidosyNombresyAsociados() As String
            Get
                Return Me.txtApeNombres.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeNombres.Text = value
            End Set
        End Property
#End Region
#Region "Functions"
        Private Function CountRegistros(ByVal SexoID As Integer, ByVal SituacionJuridicaID As Integer, ByVal Estado As Integer) As Integer

            Dim value As Integer = 0
            Dim intCount As Integer = 0

            For Each obj As Entity.Estadistica.PadinDetalle In objEntCol
                With obj

                    If SexoID = .InternoSexoID And SituacionJuridicaID = .IngresoSituacionJuridicaID _
                        And .InternoEstadoID = Estado Then

                        intCount = intCount + 1
                    End If

                End With
            Next
            value = intCount

            Return value
        End Function

#End Region
#Region "Listar"
        Private Sub ListarResumenActivo()
            ListarResumen(1)
        End Sub
        Private Sub ListarResumenInactivo()
            ListarResumen(0)
        End Sub
        Private Sub ListarResumen(ByVal EstadoID As Integer)

            Dim intPH As Integer = 0
            Dim intPM As Integer = 0
            Dim intPT As Integer = 0

            Dim intSH As Integer = 0
            Dim intSM As Integer = 0
            Dim intST As Integer = 0

            Dim intPSH As Integer = 0
            Dim intPSM As Integer = 0
            Dim intPST As Integer = 0

            Dim intTH As Integer = 0
            Dim intTM As Integer = 0
            Dim intTT As Integer = 0

            intPH = CountRegistros(1, 1, EstadoID)
            intPM = CountRegistros(2, 1, EstadoID)
            intPT = intPH + intPM

            intSH = CountRegistros(1, 2, EstadoID)
            intSM = CountRegistros(2, 2, EstadoID)
            intST = intSH + intSM

            intPSH = CountRegistros(1, 3, EstadoID)
            intPSM = CountRegistros(2, 3, EstadoID)
            intPST = intPSH + intPSM

            intTH = intPH + intSH + intPSH
            intTM = intPM + intSM + intPSM

            intTT = intTH + intTM

            Me.txtProHombres.Text = intPH.ToString
            Me.txtProMujeres.Text = intPM.ToString
            Me.txtProTotal.Text = intPT.ToString

            Me.txtSenHombres.Text = intSH.ToString
            Me.txtSenMujeres.Text = intSM.ToString
            Me.txtSenTotal.Text = intST.ToString

            Me.txtMixHombres.Text = intPSH.ToString
            Me.txtMixMujeres.Text = intPSM.ToString
            Me.txtMixtoTotal.Text = intPST.ToString

            Me.txtTotalHombres.Text = intTH
            Me.txtTotalMujeres.Text = intTM
            Me.txtTotal.Text = intTT


        End Sub

        Private Sub Listar()

            objEntCol = New Entity.Estadistica.PadinDetalleCol
            objBss = New Bussines.Estadistica.PadinDetalle

            objEntCol = objBss.Listar(-1, Me._PadinID, -1, -1, -1, Me.CodigoInterno, Me.ApellidosyNombresyAsociados)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.lblReg.Text = .RowCount() & " Reg."
            End With

            ListarResumenActivo()

            Dim c As Integer = 0
            For i As Integer = 0 To dgwGrilla.Rows.Count - 1
                If dgwGrilla.Item("col_obs_reg", i).Value() <> "" Then c = c + 1
            Next
            lblErrores.Text = "(" & c & ") Registros con observaciones"
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Me.dgwGrilla.VisibleCampos = True

            UsuarioPermisos()

            'If _LstPadinID.Count > 1 Then
            '    Me.PnlCabecera.Visible = False
            '    Me.dgwGrilla.Columns("col_region").Visible = True
            '    Me.dgwGrilla.Columns("col_penal").Visible = True
            '    Me.pnlReporte.Visible = False
            'End If

            GrillaCampos()

        End Sub
        Private Sub GrillaCampos()

            Me.col_fec_ing_sis_pen.Tag = "fecha"
            Me.col_fec_ing_pen.Tag = "fecha"
            Me.col_fec_sen.Tag = "fecha"
            Me.col_fec_ini.Tag = "fecha"
            Me.col_fec_fin.Tag = "fecha"
            Me.col_fec_nac.Tag = "fecha"
            Me.col_fec_egr.Tag = "fecha"
            Me.col_fec_cor.Tag = "fecha"

            Me.col_mes_rec.Tag = "numero"
            Me.col_ing_num.Tag = "numero"
            'Me.col_sen_pen_anio.Tag = "numero"
            'Me.col_sen_pen_mes.Tag = "numero"
            'Me.col_sen_pen_dia.Tag = "numero"
            'Me.col_sen_tot_mes.Tag = "numero"
            Me.col_eda.Tag = "numero"
            Me.col_num_hij.Tag = "numero"

        End Sub
        Private Sub ReporteF1()

            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte1
                ._PadinID = Me._PadinID
                ._PenalID = Me._PenalID
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                ._FechaInicio = Me._FechaInicio
                ._FechaFin = Me._FechaFin
                '._FechaCorte = Me._FechaCorte
                ._Correlativo = Me._Correlativo
                ._VersionReporte = Me._VersionReporte
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
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                ._FechaFin = Me._FechaFin
                ._Correlativo = Me._Correlativo
                .ShowDialog()
            End With

        End Sub
        Private Sub ReporteCuadro15()

            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte3
                ._PadinID = Me._PadinID
                ._PenalID = Me._PenalID
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                ._FechaFin = Me._FechaFin
                ._Correlativo = Me._Correlativo
                .Show()
            End With

        End Sub
        Private Sub UsuarioPermisos()

            Me.pnlExportar.Visible = Me._FormReporte
            Me.pnlReporte.Visible = Me._FormReporte

        End Sub
#End Region

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
            Try
                With Me.dgwGrilla
                    If .Columns(e.ColumnIndex).Name = "col_img_obs_reg" And e.RowIndex = -1 Then Exit Sub
                    If e.RowIndex = -1 Then
                        Me.Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        Me.Cursor = Cursors.Default
                        .Refresh()
                    End If
                    If .Columns(e.ColumnIndex).Name = "col_img_obs_reg" And e.RowIndex >= 0 And .Item("col_obs_reg", e.RowIndex).Value().ToString.Length > 0 Then MsgBox(.Item("col_obs_reg", e.RowIndex).Value(), MsgBoxStyle.Exclamation)
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
                    .Columns("col_fec_egr").Index, _
                    .Columns("col_fec_cor").Index

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

            Me.col_img_obs_reg.Visible = False
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
            Me.col_img_obs_reg.Visible = True

        End Sub


        Private Sub frmPadinDetalle_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.TabControl1.SelectedIndex = 0
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

        Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
            Handles txtCodInterno.KeyPress, txtApeNombres.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Listar()
            End If

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedIndex
                Case 0 'activos
                    ListarResumenActivo()
                Case 1 'inactivos
                    ListarResumenInactivo()
            End Select
        End Sub

        Private Sub dgwGrilla_CellMouseEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellMouseEnter
            If dgwGrilla.Columns(e.ColumnIndex).Name = "col_img_obs_reg" And e.RowIndex >= 0 Then dgwGrilla.Cursor = Cursors.Hand
        End Sub

        Private Sub dgwGrilla_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellMouseLeave
            If dgwGrilla.Columns(e.ColumnIndex).Name = "col_img_obs_reg" And e.RowIndex >= 0 Then dgwGrilla.Cursor = Cursors.Default
        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub
    End Class
End Namespace

