Imports System.ComponentModel
Imports Type
Namespace Tratamiento.TallerAsistencia.Planilla

    Public Class frmPlanillaDetalle

#Region "Propiedades Parametricas"
        Private objentCol As Entity.Tratamiento.TallerAsistencia.PlanillaDetalleCol
        Private Bss As Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera
        Private objBss As Bussines.Tratamiento.TallerAsistencia.PlanillaDetalle
#End Region

#Region "Propiedades"
        Public Property IDPlanilla As Integer = -1
        Private Property IDRegion() As Integer = -1
        Private Property IDPenal() As Integer = -1
        Public Property RegionNombre As String = ""
        Public Property PenalNombre As String = ""
        Public Property TallerNombre As String = ""
        Public Property PabellonNombre As String = ""
        Public Property Anio As Integer = -1
        Public Property MesNumero As Integer = -1
        Public Property MesNombre As String = ""
        Public Property Numero As String = ""
        Public Property EstadoID As Integer = -1
        Public Property Estado As String = ""
#End Region
#Region "Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With dgwListar
                        value = .SelectedRows(0).Cells("col_cod_det").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaApellidosNombres() As String
            Get
                Dim value As String = ""
                Try
                    With dgwListar
                        value = .SelectedRows(0).Cells("col_ape_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaMonto() As Decimal
            Get
                Dim value As Decimal = "0.00"
                Try
                    With dgwListar
                        value = .SelectedRows(0).Cells("col_ing_tot").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Listar"
        Private Sub ListarCabecera()
            txtRegion.Text = Me.RegionNombre.ToUpper
            txtPenal.Text = Me.PenalNombre.ToUpper
            txtTaller.Text = Me.TallerNombre.ToUpper
            txtPabellon.Text = Me.PabellonNombre.ToUpper
            txtNumero.Text = Me.Numero
            txtAnio.Text = Me.Anio
            txtMes.Text = Me.MesNombre.ToUpper
            txtEstado.Text = Me.Estado.ToUpper
        End Sub

        Private Sub ListarGrilla()

            ListarCabecera()

            objentCol = New Entity.Tratamiento.TallerAsistencia.PlanillaDetalleCol
            objBss = New Bussines.Tratamiento.TallerAsistencia.PlanillaDetalle
            Dim objEntFiltro As New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle

            With objEntFiltro
                .IDPlanilla = Me.IDPlanilla
            End With
            objentCol = objBss.Listar(objEntFiltro)

            With Me.dgwListar
                .ReadOnly = True
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objentCol
                lblReg.Text = objentCol.Count & " Reg. encontrados"

                For i As Integer = 0 To objentCol.Count - 1
                    .Item("col_num", i).Value = i + 1
                Next
            End With

            For i As Integer = 0 To dgwListar.Rows.Count - 1
                For j As Integer = 0 To dgwListar.Columns.Count - 1
                    If j > 6 And dgwListar.Columns(j).Name <> "col_tot_dia" And dgwListar.Columns(j).Name <> "col_ing_tot" Then
                        If dgwListar.Item(j, i).Value = "X" Then
                            dgwListar.Item(j, i).Style.BackColor = Color.FromArgb(232, 81, 81)
                            dgwListar.Item(j, i).Style.ForeColor = Color.FromArgb(232, 81, 81)
                        End If
                        If dgwListar.Item(j, i).Value = "F" Then
                            dgwListar.Item(j, i).Style.BackColor = Color.FromArgb(255, 212, 140)
                            dgwListar.Item(j, i).Style.ForeColor = Color.Brown
                        End If
                    End If
                Next
            Next
        End Sub

#End Region

#Region "Accion"
        Private Sub ATerminarPlanilla()
            If Me.EstadoID = 2 Then '(3=Terminado)
                Legolas.Configuration.Aplication.MessageBox.Information("Esta planilla se encuentra en estado TERMINADO")
            ElseIf Me.EstadoID = 0 Then '(0=anulado)
                Legolas.Configuration.Aplication.MessageBox.Information("Esta planilla se encuentra en estado ANULADO, no podra realizar ninguna accion.")
            Else
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Desea poner a la planilla en estado TERMINADO") = Windows.Forms.DialogResult.Yes Then
                    Bss = New Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera
                    Dim entPla As New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
                    entPla.Codigo = Me.IDPlanilla
                    entPla.Estado = 2 ' Estado Terminado
                    Dim valor As Integer = Bss.GrabarEstado(entPla)
                    If valor > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                        Me.EstadoID = 2 ' terminado
                        Me.txtEstado.Text = "TERMINADO"
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            End If
        End Sub
        Private Sub AnularPlanilla()
            If Me.EstadoID = 1 Then  '(procesado)
                Legolas.Configuration.Aplication.MessageBox.Information("Solo se puede Anular una planilla si su estado es TERMINADO")
            ElseIf Me.EstadoID = 0 Then '"ANULADO"
                Legolas.Configuration.Aplication.MessageBox.Information("Esta planilla ya se encuentra en estado ANULADO")
            ElseIf Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Desea Anular la planilla de " & Me.TallerNombre) = Windows.Forms.DialogResult.Yes Then
                Bss = New Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera
                Dim entPla As New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
                entPla.Codigo = Me.IDPlanilla
                entPla.Estado = 0 ' Estado anulado
                Dim Valor As Integer = Bss.GrabarEstado(entPla)
                If Valor > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End Sub
        Private Sub AProcesarPlanilla()

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea procesar la planilla") <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            Dim blnOK As Boolean = False
            Dim objBss As New Bussines.Tratamiento.TallerAsistencia.ProcesarPlanilla

            Me.Cursor = Cursors.WaitCursor

            blnOK = objBss.ProcesarPlanilla(Me.IDPlanilla)

            If blnOK = True Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            End If

            Me.Cursor = Cursors.Default

        End Sub
#End Region

#Region "Formularios"
        Private Sub frm_Reporte()

            Dim frm As New APPReporte.Tratamiento.TallerAsistencia.ReporteCrystal
            With frm
                ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaLaboral_v1
                ._Filtro.IdAux = Me.IDPlanilla
                ._Filtro.Text = Me.Text
                ._Filtro.RegionNombre = txtRegion.Text
                ._Filtro.PenalNombre = txtPenal.Text
                .ShowDialog()
            End With

        End Sub
#End Region

#Region "Otros"
        Private Sub UsuarioPermisos()
            Me.pnlGrabar.Visible = Me._FormEscritura
            Me.pnlReporte.Visible = Me._FormReporte
        End Sub
        Private Sub ValoresDefault()
            ConfigurarCalendario()
            With dgwListar
                .Columns("col_tot_dia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns("col_ing_tot").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns("col_tot_dia").DefaultCellStyle.BackColor = Color.FromArgb(198, 255, 240)
                .Columns("col_ing_tot").DefaultCellStyle.BackColor = Color.FromArgb(198, 255, 240)
            End With

        End Sub
        Private Sub ConfigurarCalendario()
            If Me.MesNumero < 1 Then
                Exit Sub
            End If
            Dim NumeroMes As String = IIf(Me.MesNumero < 10, "0" & Me.MesNumero, Me.MesNumero)
            Dim fechainicio As Date = "01/" & NumeroMes & "/" & Me.Anio
            Dim fechafin As DateTime = fechainicio.AddMonths(1).AddDays(-1)
            If fechafin.Day = 30 Then
                col_dia_31.Visible = False
            ElseIf fechafin.Day = 29 Then
                col_dia_31.Visible = False
                col_dia_30.Visible = False
            ElseIf fechafin.Day = 28 Then
                col_dia_31.Visible = False
                col_dia_30.Visible = False
                col_dia_29.Visible = False
            End If
        End Sub
#End Region
        Private Sub btnReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnReporte.Click
            frm_Reporte()
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End Sub

        Private Sub frmTallerAsistencia_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ValoresDefault()
        End Sub

        Private Sub frmTallerAsistencia_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Me.WindowState = FormWindowState.Maximized
            Me.SuspendLayout()
            ListarGrilla()
            UsuarioPermisos()
            Me.ResumeLayout()
        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

            If dgwListar.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pueder exportar a excel porque no hay registros")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea exportar el archivo a excel") = Windows.Forms.DialogResult.Yes Then
                Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwListar)
            End If

        End Sub


        Private Sub dgwListar_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwListar.CellDoubleClick

            If e.RowIndex = -1 Then
                Exit Sub
            End If

            If Me.GrillaCodigo < 1 Then
                Exit Sub
            End If

            Dim intIndiceFilaSel As Integer = -1

            If dgwListar.Columns(e.ColumnIndex).Name = "col_ing_tot" Then
                Dim frm As New frmRegistromonto
                frm._Codigo = Me.GrillaCodigo
                frm._Monto = Me.GrillaMonto
                If Me.EstadoID = 1 Then 'Procesado
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        intIndiceFilaSel = dgwListar.CurrentRow.Index
                        ListarGrilla()
                        Try
                            dgwListar.Rows(intIndiceFilaSel).Selected = True 'vuelve a seleccionar la misma fila la cual se esta actualizando
                            dgwListar.CurrentCell = dgwListar.Item(1, intIndiceFilaSel)
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Esta accion solo se puede realizar si el estado de la planilla es PROCESADO")
                End If
            End If

        End Sub


        Private Sub btnTerminar_Click(sender As System.Object, e As System.EventArgs) Handles btnTerminar.Click
            ATerminarPlanilla()
        End Sub

        Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click
            AnularPlanilla()
        End Sub

        Private Sub dgwListar_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwListar.CellEnter
            For i As Integer = 1 To Me.dgwListar.Columns.Count - 1
                'Me.dgwListar.Item(i, e.ColumnIndex).Style.SelectionBackColor = Me.dgwListar.Item(i, e.ColumnIndex).Style.BackColor

                'Me.dgwListar.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Me.dgwListar.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor
            Next
            'Me.dgwListar.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Me.dgwListar.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor
        End Sub


    End Class
End Namespace