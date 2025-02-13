Namespace Mantenimiento.Reporte
    Public Class frmBuscar
        Private objBss As Bussines.Mantenimiento.Reportecuadro2 = Nothing
        Private objEntCol As Entity.Mantenimiento.ReporteCuadro2Col = Nothing
#Region "Propiedades"
        Private Property DelitoGenerico() As String
            Get
                Return Me.txtDelGene.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDelGene.Text = value
            End Set
        End Property
        Private Property DelitoEspecifico() As String
            Get
                Return Me.txtDelEsp.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDelEsp.Text = value
            End Set
        End Property
        Private Property Estado() As Integer = -1
        Private Property Cuadro As Integer
            Get
                Dim value As Integer = Me.cbbCuadro.SelectedIndex

                If value < 1 Then
                    value = -1
                End If
                Return value
            End Get
            Set(value As Integer)
                Me.cbbCuadro.SelectedIndex = value
            End Set
        End Property

#End Region
#Region "Propiedades_Grilla"
        Private intNumeroReg As Integer = 0
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaVersionReporte() As Short
            Get
                Dim intValue As Short = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_cua").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private Sub GrillaCount(ByVal NumeroReg As Integer)

            Me.lblReg.Text = NumeroReg.ToString & " Reg."

        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()

            objBss = New Bussines.Mantenimiento.Reportecuadro2

            objEntCol = objBss.Listar(-1, Me.DelitoGenerico, Me.DelitoEspecifico, Me.Cuadro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                GrillaCount(.RowCount)
            End With

        End Sub
#End Region
#Region "Combo"
        Private blnComboCargo As Boolean = False
        Private Sub ComboCuadro()

            With Me.cbbCuadro
                .Items.Add("[Todos]")
                .Items.Add("1")
                .Items.Add("2")
                .Items.Add("3")
                .SelectedIndex = 0
            End With
            blnComboCargo = True
        End Sub
#End Region
#Region "Accion"

        Private Sub AMantenimiento(ByVal Nuevo As Boolean)

            Try
                Dim frm As New Mantenimiento.Reporte.frmCuadro2Popup_v2
                With frm

                    If Nuevo = True Then
                        ._IDCuadroDelito = -1
                    Else
                        ._IDCuadroDelito = Me.GrillaCodigo
                    End If
                    ._VersionReporte = Me.GrillaVersionReporte
                    .ShowDialog()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            ComboCuadro()
        End Sub
#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            If Me.GrillaCodigo > 0 Then
                AMantenimiento(False)
            End If

        End Sub

        Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized

        End Sub

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then
                        .Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                        .Cursor = Cursors.Default
                    End If
                End With

            Catch ex As Exception

            End Try

        End Sub


        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 Then
                AMantenimiento(False)
            End If

        End Sub

        Private Sub txtDelGene_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtDelGene.KeyPress,
        txtDelEsp.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(DataGridView1)

            'Dim objEntReporteExcel As Entity.Mantenimiento.ReporteCuadro2 = Nothing
            'Dim objEntReporteExcelCol As New Entity.Mantenimiento.ReporteCuadro2Col
            'Dim intCodigo As Integer = -1
            'Dim strCodigoGenerico As String = ""
            'Dim strGenerico As String = ""
            'Dim strEspecifico As String = ""
            'Dim strDelitoString As String = ""

            'Dim objEntDelitosGen As Entity.Mantenimiento.ReporteCuadro2Col = Nothing
            'objBss = New Bussines.Mantenimiento.Reportecuadro2
            'objEntCol = objBss.Listar(-1, "", "", "", "", "", -1, -1, Me.Estado)

            'For Each obj As Entity.Mantenimiento.ReporteCuadro2 In objEntCol

            '    intCodigo = obj.Codigo
            '    strCodigoGenerico = obj.CodigoGenerico
            '    strGenerico = obj.Generico
            '    strEspecifico = obj.Especifico
            '    strDelitoString = obj.DelitoString

            '    objEntDelitosGen = New Entity.Mantenimiento.ReporteCuadro2Col
            '    objBss = New Bussines.Mantenimiento.Reportecuadro2
            '    objEntDelitosGen = objBss.ListarDelito(strDelitoString)

            '    For Each obj2 As Entity.Mantenimiento.ReporteCuadro2 In objEntDelitosGen

            '        objEntReporteExcel = New Entity.Mantenimiento.ReporteCuadro2

            '        With objEntReporteExcel

            '            .Codigo = intCodigo
            '            .CodigoGenerico = strCodigoGenerico
            '            .Generico = strGenerico
            '            .Especifico = strEspecifico

            '            .DetalleGenerico = obj2.Generico
            '            .DetalleEspecificoCodigo = obj2.CodigoString
            '            .DetalleEspecifico = obj2.Especifico
            '        End With
            '        objEntReporteExcelCol.Add(objEntReporteExcel)
            '    Next

            'Next

            'With DataGridView1
            '    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            '    .AllowUserToResizeRows = False
            '    .AutoGenerateColumns = False
            '    .DataSource = objEntReporteExcelCol
            'End With

            'Legolas.Components.ExportarGrillaExcel.Exportar(DataGridView1)

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_esp_nom").Index

                        If (e.Value).ToString.ToUpper = "Otrosv".ToUpper Then
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub cbbCuadro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCuadro.SelectedIndexChanged

            If blnComboCargo = True Then
                Buscar()
            End If

        End Sub
    End Class
End Namespace
