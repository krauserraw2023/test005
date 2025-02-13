Imports System.ComponentModel
Imports Type
Namespace Tratamiento.TallerAsistencia.Planilla
    'ddd
    Public Class frmPlanillaBuscar
        Private frmLoad As Load.frmLoad = Nothing
        Private objentACol As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
        Private objEntCol As Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol
        Private objBss As Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera = Nothing

#Region "Propiedades_Busqueda"
        Private Property IDRegion() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private Property IDPenal() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Private Property IDTaller() As Integer
            Get
                Dim value As Integer = -1
                Return Me.cbbTalleres.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTalleres.SelectedValue = value
            End Set
        End Property
        Private Property Anio() As Integer
            Get
                Return Me.cbbAnio.Value
            End Get
            Set(ByVal value As Integer)
                Me.cbbAnio.Value = value
            End Set
        End Property
        Private Property Mes() As Integer
            Get
                Return Me.cbbMes.Value
            End Get
            Set(ByVal value As Integer)
                Me.cbbMes.Value = value
            End Set
        End Property
        Private Property Estado() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rbtProcesados.Checked = True Then
                    intValue = 1
                End If

                If Me.rbtTerminados.Checked = True Then
                    intValue = 2
                End If

                If Me.rbtTodos.Checked = True Then
                    intValue = -1
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 1
                        Me.rbtProcesados.Checked = True
                    Case 2
                        rbtTerminados.Checked = True
                    Case Else
                        rbtTodos.Checked = True
                End Select

            End Set

        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaIDPlanilla() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaNumero() As Integer
            Get
                Dim intValue As Integer = 0
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_correla").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaRegionNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_reg_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaPenalNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pen_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaTallerNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_tal_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaPabellonNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pab_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaAnio() As Short
            Get
                Dim intValue As Short = 0
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_anio").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaMesNumero() As String
            Get
                Dim intValue As String = ""
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_mes_num").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaMesNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_mes").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaEstadoId() As Integer
            Get
                Dim intValue As Integer = 0
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_est_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaEstado() As String
            Get
                Dim intValue As String = ""
                Try
                    With dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_est_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region

#Region "Combo"
        Private blnCombo As Boolean = False
        Private Sub ComboRegion()

            Dim blnTodos As Boolean = False

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True
            End If

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                .Parametro1 = Configuracion.Licencia.Codigo
                ._Todos = blnTodos
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboPenal()

            Dim blnTodos As Boolean = False

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True
            End If

            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.IDRegion
                .Parametro1 = Configuracion.Licencia.Codigo
                ._Todos = blnTodos
                .LoadUsc()
            End With

            If Me.IDRegion < 1 Then
                Me.cbbPenal.Enabled = False
                ComboTalleres()
            Else
                Me.cbbPenal.Enabled = True
            End If

        End Sub
        Private Sub ComboAnioMes()

            Dim intAnio As Integer = Legolas.Configuration.Aplication.FechayHora.FechaAnio

            With Me.cbbAnio
                ._Todos = True
                .AnioInicio = 2018
                .AnioFin = intAnio
                .LoadUsc()
            End With

            With Me.cbbMes
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboTalleres()
            With Me.cbbTalleres
                ._Todos = True
                .CodigoPadre = Me.IDPenal
                ._LoadUsc(Type.Combo.Tratamiento.Trabajo.TallerAsistencia.Talleres, True)
            End With
            blnCombo = False
        End Sub


#End Region
#Region "Listar"
        Private Sub Buscar()

            LoadPropiedades()

            Me.SuspendLayout()

            Me.BackgroundWorker1.RunWorkerAsync()

            frmLoad = New Load.frmLoad
            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackgroundWorker1.CancelAsync()
                Me.BackgroundWorker1.Dispose()
            End If

            Me.ResumeLayout(True)
            frmLoad.Refresh()

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                lblReg.Text = objEntCol.Count & " Reg."
            End With

        End Sub

        Private Function Listar(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean

            If worker.CancellationPending = True Then
                e.Cancel = True
            Else
                objEntCol = New Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol
                Dim objBss As New Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera
                Dim objEntFiltro As New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera

                With objEntFiltro
                    .IDTaller = Me.LoadIDTaller
                    .Anio = Me.LoadAnio
                    .Mes = Me.LoadMes
                    .IDRegion = Me.LoadRegion
                    .IDPenal = Me.LoadPenal
                    .Estado = Me.LoadEstado
                End With
                objEntCol = ListarFiltro(objBss.Listar(objEntFiltro))
            End If
            Return True
        End Function
        Private Function ListarFiltro(objCol As Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol) As Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol
            Dim Value As New Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol
            If ckbAnulado.Checked = True Then
                Return objCol
            End If
            For Each obj As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera In objCol
                'Filtra por anulado           
                If obj.Estado <> 0 Then
                    Value.Add(obj)
                End If
            Next
            Return Value
        End Function
        Private Sub ListarAnulados()
            objEntCol = New Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol
            Dim objBss As New Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera
            Dim objEntFiltro As New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
            With objEntFiltro
                .IDTaller = Me.LoadIDTaller
                .Anio = Me.LoadAnio
                .Mes = Me.LoadMes
                .IDRegion = Me.LoadRegion
                .IDPenal = Me.LoadPenal
                If ckbAnulado.Checked = True Then
                    gbEstado.Enabled = False
                    .Estado = 0 ' Anulados
                Else
                    Me.gbEstado.Enabled = True
                    .Estado = Me.LoadEstado
                End If
            End With
            objEntCol = ListarFiltro(objBss.Listar(objEntFiltro))
            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                lblReg.Text = objEntCol.Count & " Reg."
            End With
        End Sub
#End Region
#Region "Accion"

        Private Sub AProcesarPlanilla(PlanillaID As Integer)

            'If Me.GrillaEstadoId <> 1 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se puede procesar la planilla en estado [pendiente]")
            '    Exit Sub
            'End If

            'If Legolas.Configuration.Aplication.MessageBox.Question("Desea procesar la planilla") <> Windows.Forms.DialogResult.Yes Then
            '    Exit Sub
            'End If

            Dim blnOK As Boolean = False
            Dim objBss As New Bussines.Tratamiento.TallerAsistencia.ProcesarPlanilla

            Me.Cursor = Cursors.WaitCursor

            blnOK = objBss.ProcesarPlanilla(PlanillaID)

            If blnOK = True Then
                'Dim objBssCab As New Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera
                'Dim objEnt As New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
                'With objEnt
                '    .Codigo = Me.GrillaIDPlanilla
                '    .Estado = 2 'procesado
                'End With
                'objBssCab.GrabarEstado(objEnt)
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Buscar()
            End If

            Me.Cursor = Cursors.Default

        End Sub

        Private Sub AEliminar()

            If Me.GrillaIDPlanilla < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione registro")
                Exit Sub
            End If

            Select Case Me.GrillaEstadoId
                Case 1
                Case Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se puede eliminar la planilla en estado [procesado]")
                    Exit Sub
            End Select

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            Dim objBss As New Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera
            intValue = objBss.Eliminar(Me.GrillaIDPlanilla)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Buscar()
            End If

        End Sub
#End Region
#Region "Propiedades_Load"
        Private Property LoadRegion() As Short = -1
        Private Property LoadPenal() As Short = -1
        Private Property LoadIDTaller() As Integer = -1
        Private Property LoadAnio() As Short = -1
        Private Property LoadMes() As Short = -1
        Private Property LoadEstado As Short = -1
#End Region

#Region "Formularios"
        Private Sub frm_GenerarPlanillaCabecera()
            If Me.IDPenal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Penal")
                Exit Sub
            End If
            Dim frm As New Tratamiento.TallerAsistencia.Planilla.frmPlanillaPopup
            With frm
                ._RegionID = Me.IDRegion
                ._PenalID = Me.IDPenal
                'permisos
                ._FormEscritura = Me._FormEscritura
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    AProcesarPlanilla(._PlanillaID)
                    'Buscar()
                End If
            End With

        End Sub

        Private Sub frm_Reporte()

            Dim frm As New APPReporte.Tratamiento.TallerAsistencia.ReporteCrystal
            With frm
                ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rptPlanillaLaboral_v1
                ._Filtro.IdAux = Me.GrillaIDPlanilla
                ._Filtro.Text = Me.Text
                ._Filtro.RegionNombre = Me.GrillaRegionNombre
                ._Filtro.PenalNombre = Me.GrillaPenalNombre
                .ShowDialog()
            End With

        End Sub
        Private Sub frm_Detalle()
            Dim frm As New Tratamiento.TallerAsistencia.Planilla.frmPlanillaDetalle
            frm.MdiParent = Me.MdiParent
            With frm
                .IDPlanilla = Me.GrillaIDPlanilla
                .Numero = Me.GrillaNumero
                .RegionNombre = Me.GrillaRegionNombre
                .PenalNombre = Me.GrillaPenalNombre
                .TallerNombre = Me.GrillaTallerNombre
                .PabellonNombre = Me.GrillaPabellonNombre
                .Anio = Me.GrillaAnio
                .MesNumero = Me.GrillaMesNumero
                .MesNombre = Me.GrillaMesNombre
                .EstadoID = Me.GrillaEstadoId
                .Estado = Me.GrillaEstado
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                .Show()
                Buscar()
            End With
        End Sub
#End Region
#Region "Otros"
        Private Sub ALimpiar()

            Me.IDTaller = -1
            Me.Anio = -1
            Me.Mes = -1
            Me.Estado = -1

        End Sub
        Private Sub LoadPropiedades()

            LoadRegion = Me.IDRegion
            LoadPenal = Me.IDPenal
            LoadIDTaller = Me.IDTaller
            LoadAnio = Me.Anio
            LoadMes = Me.Mes
            LoadEstado = Me.Estado

        End Sub
        Private Sub ValoresDefault()

            ComboRegion()
            ComboPenal()

            ComboTalleres()
            ComboAnioMes()

            Me.Anio = Legolas.Configuration.Aplication.FechayHora.FechaAnio
            Me.Mes = Legolas.Configuration.Aplication.FechayHora.FechaMes
            Me.dgwGrilla.ReadOnly = True

            Timer1.Interval = 1000 * 30  ' 30 segundos
            Timer1.Start()
        End Sub
        Private Sub UsuarioPermisos()

            Me.pnlNuevo.Visible = Me._FormEscritura
            Me.pnlReporte.Visible = Me._FormReporte
            Me.pnlEliminar.Visible = Me._FormEliminar

        End Sub
#End Region

        Private Sub btnReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnReporte.Click
            frm_Reporte()
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub frmTallerAsistencia_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ValoresDefault()
        End Sub

        Private Sub frmTallerAsistencia_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Buscar()
            UsuarioPermisos()

        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
            ALimpiar()
        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea exportar el archivo a excel") = Windows.Forms.DialogResult.Yes Then
                Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
            End If

        End Sub

        Private Sub BackgroundWorker1_Disposed(sender As Object, e As System.EventArgs) Handles BackgroundWorker1.Disposed
            If Me.BackgroundWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker1 = Nothing
                Me.Close()
            End If
        End Sub

        Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
            If Me.BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
            Else

                e.Result = Listar(worker, e)

            End If
        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()
                result = e.Result
                ' procesa el resultado del metodo ping        
            End If
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            frm_Detalle()
        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex
                    Case .Columns("col_fec_pro").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = DateTime.FromFileTime(e.Value).ToShortDateString
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            frm_GenerarPlanillaCabecera()
        End Sub

        Private Sub btnPadinDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnPadinDetalle.Click

            frm_Detalle()

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            AEliminar()

        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            ComboPenal()

        End Sub

        Private Sub cbbRegion_Load(sender As System.Object, e As System.EventArgs) Handles cbbRegion.Load

        End Sub

        Private Sub cbbPenal_Load(sender As Object, e As EventArgs) Handles cbbPenal.Load

        End Sub

        Private Sub cbbPenal__SelectedIndexChanged() Handles cbbPenal._SelectedIndexChanged

            If Me.IDPenal > 0 Then
                ComboTalleres()
            End If

        End Sub

        Private Sub ckbAnulado_CheckedChanged(sender As Object, e As EventArgs) Handles ckbAnulado.CheckedChanged
            ListarAnulados()
        End Sub
    End Class
End Namespace