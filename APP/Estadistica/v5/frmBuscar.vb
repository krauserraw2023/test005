Imports System
Imports System.Collections
Imports System.Linq
Imports Type.Enumeracion

Namespace Estadistica.v5
    Public Class frmBuscar
        Private objEntCol As Entity.Estadistica.PadinCol = Nothing
        Private objBss As Bussines.Estadistica.Padin = Nothing
#Region "Propiedades_Grilla"
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
        Private ReadOnly Property GrillaRegionID() As Integer
            Get
                Dim Value As Integer = -1
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaRegionNombre() As String
            Get
                Dim Value As String = ""
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_reg_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaPenalID() As Integer
            Get
                Dim Value As Integer = -1
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaPenalNombre() As String
            Get
                Dim Value As String = ""
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_pen_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaAnio() As Integer
            Get
                Dim Value As Integer = -1
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_anio").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaMes() As Integer
            Get
                Dim Value As Integer = -1
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_mes_num").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaMesNombre() As String
            Get
                Dim Value As String = ""
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_mes").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaFechaInicio As Long
            Get
                Dim Value As Long = 0
                Value = Legolas.Components.FechaHora.FechaPrimerDiaMes(GrillaFechaFin)
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaFechaFin As Long
            Get
                Dim Value As Long = 0
                With Me.dgwGrilla
                    Value = .SelectedRows(0).Cells("col_fec_cor").Value
                End With
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaFechaProcesamiento As Long
            Get
                Dim Value As Long = 0
                With Me.dgwGrilla
                    Value = .SelectedRows(0).Cells("col_fec_pro").Value
                End With
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaCorrelativo As Integer
            Get
                Dim Value As Integer = 0
                With Me.dgwGrilla
                    Value = .SelectedRows(0).Cells("col_correla").Value
                End With
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaEstado() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_est_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaEstadoNombre() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_est_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaVersionPadin() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pad_ver").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaVersionReporte() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_ver_rpt").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

#End Region
#Region "Propiedades_Buscar"
        Private Property RegionID() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.cbbRegion.Text.Trim
            End Get
        End Property
        Private Property PenalID() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.cbbPenal.Text.Trim
            End Get
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
                Dim value As Integer = -1

                If Me.rdbPendiente.Checked Then
                    value = 1
                End If

                If Me.rdbProcesado.Checked Then
                    value = 2
                End If

                If Me.rdbEnviado.Checked Then
                    value = 3
                End If

                If Me.rdbEnvSdCentral.Checked Then
                    value = 4
                End If

                Return value
            End Get
            Set(ByVal value As Integer)

                Me.rdbPendiente.Checked = False
                Me.rdbProcesado.Checked = False
                Me.rdbEnviado.Checked = False
                Me.rdbEnvSdCentral.Checked = False
                Me.rdbTodos.Checked = False

                Select Case value
                    Case 1
                        Me.rdbPendiente.Checked = True
                    Case 2
                        Me.rdbProcesado.Checked = True
                    Case 3
                        Me.rdbEnviado.Checked = True
                    Case 4
                        Me.rdbEnvSdCentral.Checked = True
                    Case Else
                        Me.rdbTodos.Checked = True
                End Select
            End Set

        End Property
        Private Property FechaCorte() As Long
            Get
                Return Me.dtpFechaCorte.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaCorte.ValueLong = value
            End Set
        End Property
#End Region
#Region "Combo"

        Private blnCombo As Boolean = False
        Private Sub ComboRegion()

            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select

            With Me.cbbRegion
                ._Todos = blnTodos
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                .Parametro1 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboPenal()

            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1
                    blnTodos = False
                Case 2, 3
                    blnTodos = True
            End Select

            With Me.cbbPenal
                ._Todos = blnTodos
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.RegionID
                .Parametro1 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub
        Private Sub Combo()
            blnCombo = False
            Dim intAnio As Integer = Legolas.Configuration.Aplication.FechayHora.FechaAnio

            With Me.cbbAnio
                ._Todos = True
                .AnioInicio = 2010
                .AnioFin = intAnio
                .LoadUsc()
            End With

            With Me.cbbMes
                ._Todos = True
                .LoadUsc()
            End With

            blnCombo = True
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()

            objEntCol = New Entity.Estadistica.PadinCol
            objBss = New Bussines.Estadistica.Padin

            If Me.chkFechaCorte.Checked And Me.FechaCorte = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Fecha de corte")
                Exit Sub
            End If

            objEntCol = objBss.Listar(-1, Me.RegionID, Me.PenalID, Me.Anio, Me.Mes, Me.Estado, Me.FechaCorte)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = VerAnulados(objEntCol)  ' objEntCol
                Me.lblReg.Text = .RowCount() & " Reg."
            End With

            If objEntCol.Count > 0 Then
                Me.btnModificar.Enabled = True
                Me.btnEliminar.Enabled = True
                Me.btnPadinDetalle.Enabled = True
                Me.btnCuadro14.Enabled = True
                Me.btnCuadro15.Enabled = True
                Me.btnExportar.Enabled = True
                Me.btnFicha.Enabled = True

                HabilitarAnularEliminar()
            End If

            GrillaPintar()

        End Sub

        Private Function VerAnulados(objEntCol As Entity.Estadistica.PadinCol) As Entity.Estadistica.PadinCol

            If ckbAnulados.Checked = False And rdbTodos.Checked Then
                Dim objEntColAux As New Entity.Estadistica.PadinCol
                objEntColAux = objEntCol

                For i As Integer = objEntColAux.Count - 1 To 0 Step -1
                    If objEntColAux.Padin(i).Estado = 5 Then objEntColAux.RemoveAt(i)
                Next

                objEntCol = New Entity.Estadistica.PadinCol
                objEntCol = objEntColAux
            End If

            Return objEntCol
        End Function

        Private Sub GrillaPintar()
            For Each obj As Entity.Estadistica.Padin In objEntCol
                Select Case obj.Estado
                    Case 5 'cambiar color texto si es registro anulado
                        obj.PadinColor = Color.FromArgb(207, 148, 149)
                    Case 4 'enviado a sede
                        obj.PadinColor = Color.LightGreen
                    Case 3  'enviado a region
                        obj.PadinColor = Color.CornflowerBlue
                    Case 2 'pendiente
                        obj.PadinColor = Color.DarkOrange
                End Select
            Next
        End Sub

#End Region
#Region "Accion"
        Private Function ValidarEliminar() As Boolean

            Dim value As Boolean = False

            If Me.GrillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de eliminar, seleccione un registro")
                Return value
            End If

            Select Case Me.GrillaEstado
                Case 4 'transferida a sede central
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "No puede realizar ninguna accion, la informacion ha sido transferida a la Sede Central")
                    Return value
            End Select

            value = True

            Return value
        End Function
        Private Sub AAnular()

            If Legolas.Configuration.Aplication.MessageBox.Question("Confirma anular el registro seleccionado?") = Windows.Forms.DialogResult.Yes Then

                objBss = New Bussines.Estadistica.Padin
                objBss.Anular(Me.GrillaCodigo)
                Listar()
            End If

        End Sub
        Private Sub AEliminar()

            If ValidarEliminar() = False Then
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                objBss = New Bussines.Estadistica.Padin
                objBss.Eliminar(Me.GrillaCodigo)
                Listar()
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        End Sub
        Private Sub HabilitarAnularEliminar()

            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.Image = SIPPOPE.My.Resources.Resources.delete_32

            Select Case Me.GrillaEstado
                Case Padin.EnumPadinEstado.EnviadoSCentral, Padin.EnumPadinEstado.Anulado
                    Me.btnEliminar.Enabled = False
                Case Padin.EnumPadinEstado.EnviadoRegion
                    Me.btnEliminar.Enabled = True
                    Me.btnEliminar.Text = "&Anular"
                    Me.btnEliminar.Image = SIPPOPE.My.Resources.Resources.anular2
                Case Else
                    Me.btnEliminar.Enabled = True
            End Select

        End Sub
        Private Sub HabilitarBotones()

            Select Case Me.GrillaEstado
                Case Padin.EnumPadinEstado.Pendiente
                    Me.btnPadinDetalle.Enabled = False
                    Me.btnCuadro14.Enabled = False
                    Me.btnCuadro15.Enabled = False
                    Me.btnFicha.Enabled = False

                Case Padin.EnumPadinEstado.Procesado, Padin.EnumPadinEstado.EnviadoRegion, Padin.EnumPadinEstado.EnviadoSCentral, Padin.EnumPadinEstado.Anulado
                    Me.btnPadinDetalle.Enabled = True
                    Me.btnCuadro14.Enabled = True
                    Me.btnCuadro15.Enabled = True
                    Me.btnFicha.Enabled = True
            End Select

        End Sub
        Private Function validarExportacionMultiplePadin() As Boolean

            Dim value As Boolean = False

            '01, validar que existan registros
            If Me.dgwGrilla.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("No existen registros para exportar la información")
                Return value
            End If

            '02.-validar que al menos haiga una registro activado
            Dim blnSeleccionado As Boolean = False
            Dim intContadorSeleccionado As Short = 0

            For Each fila As DataGridViewRow In dgwGrilla.Rows
                blnSeleccionado = fila.Cells("col_check").Value
                If blnSeleccionado = True Then
                    intContadorSeleccionado += 1
                End If
            Next

            If intContadorSeleccionado < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione registro a exportar")
                Return value
            End If

            '03.- validar versiones distintas de reporte
            blnSeleccionado = False
            Dim intVersionPadin As Short = -1
            Dim intVersionPadinSeleccionado As Short = -1
            Dim blnSalioBucle As Boolean = False

            For Each fila As DataGridViewRow In dgwGrilla.Rows

                blnSeleccionado = fila.Cells("col_check").Value
                intVersionPadinSeleccionado = fila.Cells("col_pad_ver").Value

                If blnSeleccionado = True Then
                    If intVersionPadin = -1 OrElse intVersionPadinSeleccionado = intVersionPadin Then
                        intVersionPadin = intVersionPadinSeleccionado
                    Else
                        blnSalioBucle = True
                        Exit For
                    End If
                End If
            Next

            If blnSalioBucle = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede ejecutar la exportación multiple, cuando dos o más registros de PADINES seleccionados tienen distinta versión")
                Return value
            End If

            'validar el nuevo menu
            If intVersionPadin = 6 Then
                Me.ContextMenuStrip1.Show(Me.pnlReporte.Location.X + Me.btnExportar.Location.X, MousePosition.Y - (btnExportar.Height * 2))
                Return value
            End If

            value = True
            Return value
        End Function
        Private Function Leer_Reg_Seleccionadas(ByVal dgw As DataGridView) As Dictionary(Of Integer, Integer)

            Dim lstInteger As New Dictionary(Of Integer, Integer) '(PadinId,Version)
            Dim seleccionado As Boolean = False
            Dim valorID As String = ""

            For Each fila As DataGridViewRow In dgw.Rows
                seleccionado = fila.Cells("col_check").Value
                If seleccionado Then
                    lstInteger.Add(fila.Cells("col_id").Value, fila.Cells("col_pad_ver").Value)
                End If
            Next

            If lstInteger.Count = 0 Then
                lstInteger.Add(dgw.Item("col_id", dgw.CurrentCell.RowIndex).Value, dgw.Item("col_pad_ver", dgw.CurrentCell.RowIndex).Value)
            End If

            Return lstInteger
        End Function
        Private Sub exportarMultiplePadin(tipoExportacion As Short)

            Dim LstPadin As Dictionary(Of Integer, Integer) = Leer_Reg_Seleccionadas(Me.dgwGrilla)

            If LstPadin.Count >= 1 Then
                If LstPadin.Count <> 1 AndAlso MessageBox.Show("Está seguro de exportar el detalle de todos los padines seleccionados, Esta opción tomará más tiempo, desea continuar de todas maneras?.", "INPE - SIP-POPE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
                ExportarMultiplePadin(tipoExportacion, LstPadin)
            End If

        End Sub
        Private Sub ExportarMultiplePadin(tipoExportacion As Short, LstPadin As Dictionary(Of Integer, Integer))

            Me.Cursor = Cursors.WaitCursor
            Me.Refresh()
            Me.SuspendLayout()

            Dim frm As New Estadistica.frmExportDetPadin(tipoExportacion, LstPadin)

            If frm._GrillaPadin.RowCount > 0 Then
                Legolas.Components.ExportarGrillaExcel.Exportar(frm._GrillaPadin)
            End If

            Me.Cursor = Cursors.Default
            Me.ResumeLayout()
        End Sub
#End Region
#Region "Form"

        Private Sub FRM_Mantenimiento(ByVal Nuevo As Boolean)

            Dim intRegion As Integer = -1
            Dim strRegion As String = ""
            Dim intPenal As Integer = -1
            Dim strPenal As String = ""
            Dim PadinColor As System.Drawing.Color
            If Nuevo = True Then
                Dim frm As New frmPenalPopup
                With frm
                    .BRegion = Me.RegionID
                    .BPenal = Me.PenalID
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        intRegion = .RegionID
                        strRegion = .RegionNombre
                        intPenal = .PenalID
                        strPenal = .PenalNombre
                    Else
                        Exit Sub
                    End If
                End With
            Else
                intRegion = Me.GrillaRegionID
                strRegion = Me.GrillaRegionNombre
                intPenal = Me.GrillaPenalID
                strPenal = Me.GrillaPenalNombre
            End If

            If Nuevo = True AndAlso objBss.ValidarEstadoTransferencia(intRegion, intPenal) = False Then Exit Sub

            Dim frmPadin As New Estadistica.v5.frmPadinPopup
            With frmPadin
                'PadinColor = dgwGrilla.SelectedRows(0).Cells("col_pad_col").Value
                ._IDRegion = intRegion
                ._RegionNombre = strRegion
                ._IDPenal = intPenal
                ._PenalNombre = strPenal
                ._PadColor = PadinColor
                ._IDPadin = If(Nuevo = True, -1, Me.GrillaCodigo)

                'permisos
                ._FormLectura = Me._FormLectura
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormEliminar = Me._FormEliminar

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    If ._PadinDetalle = True Then

                        Dim LstPadin As New List(Of Integer)
                        LstPadin.Add(._IDPadin)
                        Frm_PadinDetalle()
                    End If
                    Listar()
                End If
            End With

        End Sub

        Public Sub Frm_PadinDetalle()

            Select Case Me.GrillaVersionPadin

                Case Is < 2 'padin version 1

                    Dim frm As New Estadistica.v45.frmPadinDetalle
                    frm.MdiParent = Me.MdiParent

                    With frm
                        ._PadinID = Me.GrillaCodigo
                        ._RegionID = Me.GrillaRegionID
                        ._RegionNombre = Me.GrillaRegionNombre
                        ._PenalID = Me.GrillaPenalID
                        ._PenalNombre = Me.GrillaPenalNombre
                        ._Anio = Me.GrillaAnio
                        ._Mes = Me.GrillaMes
                        ._FechaInicio = Me.GrillaFechaInicio
                        ._FechaFin = Me.GrillaFechaFin
                        ._Correlativo = Me.GrillaCorrelativo
                        ._VersionReporte = Me.GrillaVersionReporte
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormReporte = Me._FormReporte
                        ._FormImpresion = Me._FormImpresion
                        ._FormEliminar = Me._FormEliminar
                        .Show()
                    End With

                Case 2 'padin version 4.6

                    Dim PadinColor As System.Drawing.Color = dgwGrilla.SelectedRows(0).Cells("col_pad_col").Value
                    'Dim frm As New Estadistica.v46.frmPadinDetalle
                    Dim frm As New Estadistica.v5.frmPadinDetalle
                    frm.MdiParent = Me.MdiParent

                    With frm
                        ._IDPadin = Me.GrillaCodigo
                        ._IDRegion = Me.GrillaRegionID
                        ._RegionNombre = Me.GrillaRegionNombre
                        ._IDPenal = Me.GrillaPenalID
                        ._PenalNombre = Me.GrillaPenalNombre
                        ._Anio = Me.GrillaAnio
                        ._Mes = Me.GrillaMes
                        ._MesNombre = Me.GrillaMesNombre
                        ._FechaInicio = Me.GrillaFechaInicio
                        ._FechaFin = Me.GrillaFechaFin
                        ._FechaProcesamiento = Me.GrillaFechaProcesamiento
                        ._Correlativo = Me.GrillaCorrelativo
                        ._EstadoNombre = Me.GrillaEstadoNombre
                        ._Version = Me.GrillaVersionPadin
                        ._PadinEstadoColor = PadinColor
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormReporte = Me._FormReporte
                        ._FormImpresion = Me._FormImpresion
                        ._FormEliminar = Me._FormEliminar
                        .Show()
                    End With

                Case 5 'padin version 5

                    Dim PadinColor As System.Drawing.Color = dgwGrilla.SelectedRows(0).Cells("col_pad_col").Value
                    Dim frm As New Estadistica.v5.frmPadinDetalle
                    frm.MdiParent = Me.MdiParent

                    With frm
                        ._IDPadin = Me.GrillaCodigo
                        ._IDRegion = Me.GrillaRegionID
                        ._RegionNombre = Me.GrillaRegionNombre
                        ._IDPenal = Me.GrillaPenalID
                        ._PenalNombre = Me.GrillaPenalNombre
                        ._Anio = Me.GrillaAnio
                        ._Mes = Me.GrillaMes
                        ._MesNombre = Me.GrillaMesNombre
                        ._FechaInicio = Me.GrillaFechaInicio
                        ._FechaFin = Me.GrillaFechaFin
                        ._FechaProcesamiento = Me.GrillaFechaProcesamiento
                        ._Correlativo = Me.GrillaCorrelativo
                        ._EstadoNombre = Me.GrillaEstadoNombre
                        ._Version = Me.GrillaVersionPadin
                        ._VersionReporte = Me.GrillaVersionReporte
                        ._PadinEstadoColor = PadinColor
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormReporte = Me._FormReporte
                        ._FormImpresion = Me._FormImpresion
                        ._FormEliminar = Me._FormEliminar
                        .Show()
                    End With
                Case 6 'padin version 6

                    Dim PadinColor As System.Drawing.Color = dgwGrilla.SelectedRows(0).Cells("col_pad_col").Value
                    Dim frm As New Estadistica.v5.frmPadinDetalleV2
                    frm.MdiParent = Me.MdiParent

                    With frm
                        ._IDPadin = Me.GrillaCodigo
                        ._IDRegion = Me.GrillaRegionID
                        ._RegionNombre = Me.GrillaRegionNombre
                        ._IDPenal = Me.GrillaPenalID
                        ._PenalNombre = Me.GrillaPenalNombre
                        ._Anio = Me.GrillaAnio
                        ._Mes = Me.GrillaMes
                        ._MesNombre = Me.GrillaMesNombre
                        ._FechaInicio = Me.GrillaFechaInicio
                        ._FechaFin = Me.GrillaFechaFin
                        ._FechaProcesamiento = Me.GrillaFechaProcesamiento
                        ._Correlativo = Me.GrillaCorrelativo
                        ._EstadoNombre = Me.GrillaEstadoNombre
                        ._Version = Me.GrillaVersionPadin
                        ._VersionReporte = Me.GrillaVersionReporte
                        ._PadinEstadoColor = PadinColor
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormReporte = Me._FormReporte
                        ._FormImpresion = Me._FormImpresion
                        ._FormEliminar = Me._FormEliminar
                        .Show()
                    End With
                Case Else

                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede mostrar la version del Padin " & Me.GrillaVersionPadin)

            End Select

        End Sub

        Private Sub FRM_ReporteF1()

            If Me.GrillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione registro")
                Exit Sub
            End If

            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte1
                ._PadinID = Me.GrillaCodigo
                ._PenalID = Me.GrillaPenalID
                ._Anio = Me.GrillaAnio
                ._Mes = Me.GrillaMes
                ._FechaInicio = Me.GrillaFechaInicio
                ._FechaFin = Me.GrillaFechaFin
                ._Correlativo = Me.GrillaCorrelativo
                ._EstadoPadin = Me.GrillaEstado
                ._VersionReporte = Me.GrillaVersionReporte
                .Show()
            End With

        End Sub

        Private Sub FRM_ReporteCuadro14()

            If Me.GrillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
               "Seleccione registro")
                Exit Sub
            End If

            Dim frm As New Estadistica.frmNominalPopup
            With frm
                ._PadinID = Me.GrillaCodigo
                ._RegionID = Me.GrillaRegionID
                ._RegionNombre = Me.GrillaRegionNombre
                ._PenalID = Me.GrillaPenalID
                ._PenalNombre = Me.GrillaPenalNombre
                ._Anio = Me.GrillaAnio
                ._Mes = Me.GrillaMes
                ._FechaFin = Me.GrillaFechaFin
                ._Correlativo = Me.GrillaCorrelativo
                ._EstadoPadin = Me.GrillaEstado
                .ShowDialog()
            End With
        End Sub

        Private Sub FRM_ReporteCuadro15()

            If Me.GrillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
               "Seleccione registro")
                Exit Sub
            End If

            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte3
                ._PadinID = Me.GrillaCodigo
                ._PenalID = Me.GrillaPenalID
                ._Anio = Me.GrillaAnio
                ._Mes = Me.GrillaMes
                ._FechaFin = Me.GrillaFechaFin
                ._Correlativo = Me.GrillaCorrelativo
                ._EstadoPadin = Me.GrillaEstado
                .Show()
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub CheckUncheckAllColumn(ByVal checked As Boolean, ByVal migrilla As DataGridView)
            migrilla.SuspendLayout()
            For Each row As DataGridViewRow In migrilla.Rows
                row.Cells(0).Value = checked
            Next
            migrilla.ResumeLayout(True)
            migrilla.RefreshEdit()
        End Sub
        Private Sub ValoresxDefault()

            ComboRegion()
            ComboPenal()
            Combo()

            Me.Anio = Legolas.Configuration.Aplication.FechayHora.FechaAnio
            Me.Mes = -1 'Para que salga por defecto todos

            If chkFechaCorte.Checked Then
                Me.dtpFechaCorte.ValueLong = 0
            Else
                Me.dtpFechaCorte.ValueLong = 0
                Me.dtpFechaCorte.Enabled = False
            End If

            GrillaCamposFormato()

            Me.dgwGrilla.VisibleCampos = False

            For i As Integer = 0 To dgwGrilla.ColumnCount - 1
                Me.dgwGrilla.Columns(i).ReadOnly = True
                If Me.dgwGrilla.Columns(i).Name = "col_check" Then
                    Me.dgwGrilla.Columns(i).ReadOnly = False
                End If
            Next

            Dim intTipoUsuario As Integer = Legolas.Configuration.Usuario.NivelUsuario
            Dim intOficina As Integer = Legolas.Configuration.Usuario.OficinaID

            Select Case intTipoUsuario
                'Case Usuario.EnumTipoUsuario.Penal
                '    Select Case intOficina
                '        Case Usuario.EnumDependencia.RegistroPenitenciario

                '        Case Usuario.EnumDependencia.UnidadEstadistica
                '            Me.rdbEnvSdCentral.Checked = True
                '            Me.grbEstado.Enabled = False
                '    End Select
                'Case Usuario.EnumTipoUsuario.Region

                Case Usuario.EnumTipoUsuario.Nacional
                    Select Case intOficina
                        Case Usuario.EnumDependencia.UnidadEstadistica
                            Me.rdbEnvSdCentral.Checked = True
                            Me.grbEstado.Visible = False
                    End Select
            End Select

            UsuarioPermisos()

        End Sub
        Private Sub GrillaCamposFormato()

            Me.col_fec.Tag = "fecha"
            Me.col_fec_pro.Tag = "fecha_hora"
            Me.col_fec_env.Tag = "fecha_hora"
            Me.col_fec_cor.Tag = "fecha"
            Me.col_check.Tag = "check"
            Me.col_Obs.Tag = "check"

            With Me.dgwGrilla
                .Columns("col_correla").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("col_anio").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("col_mes").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("col_fec").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("col_fec_cor").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("col_fec_env").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("col_fec_pro").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        End Sub

        Private Sub UsuarioPermisos()

            'nuevo/modificar
            Me.pnlNuevoModificar.Visible = Me._FormEscritura
            'eliminar
            Me.pnlEliminar.Visible = Me._FormEliminar
            'reporte
            Me.pnlReporte.Visible = Me._FormReporte

        End Sub
#End Region
#Region "Eventos"
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            FRM_Mantenimiento(True)

        End Sub
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub


        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            If e.RowIndex = -1 Then
                With Me.dgwGrilla
                    Me.Cursor = Cursors.WaitCursor
                    objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                    .CurrentCell = Nothing
                    Me.Cursor = Cursors.Default
                    .Refresh()
                End With
            End If

        End Sub
        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                FRM_Mantenimiento(False)
            End If

        End Sub
        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            Me.ComboPenal()

        End Sub
        Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub
        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Listar()
            dgwGrilla.ClearSelection()
        End Sub
        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                '.Columns("col_correla").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns("col_anio").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns("col_mes").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns("col_fec").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns("col_fec_cor").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns("col_fec_env").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns("col_fec_pro").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                Select Case e.ColumnIndex

                    Case .Columns("col_fec").Index, .Columns("col_fec_cor").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If
                    Case .Columns("col_fec_pro").Index, .Columns("col_fec_env").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                        Else
                            e.Value = ""
                        End If
                End Select

            End With

        End Sub
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            If dgwGrilla.CurrentRow.Selected = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione una fila")
                Exit Sub
            End If
            If Me.dgwGrilla.RowCount > 0 Then
                FRM_Mantenimiento(False)
            End If

        End Sub
        Private Sub btnPadinDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadinDetalle.Click

            If dgwGrilla.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione una fila")
                Exit Sub
            Else
                If dgwGrilla.CurrentRow.Selected = False Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Seleccione una fila")
                    Exit Sub
                End If
                Frm_PadinDetalle()
            End If

        End Sub
        Private Sub btnFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFicha.Click

            If dgwGrilla.CurrentRow.Selected = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione una fila")
                Exit Sub
            End If
            If Me.dgwGrilla.RowCount > 0 Then

                FRM_ReporteF1()

            End If

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            If validarExportacionMultiplePadin() = False Then
                Exit Sub
            End If

            Dim LstPadin As Dictionary(Of Integer, Integer) = Leer_Reg_Seleccionadas(Me.dgwGrilla)

            If LstPadin.Count >= 1 Then
                If LstPadin.Count <> 1 AndAlso MessageBox.Show("Está seguro de exportar el detalle de todos los padines seleccionados, Esta opción tomará más tiempo, desea continuar de todas maneras?.", "INPE - SIP-POPE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
                ExportarMultiplePadin(3, LstPadin)
            End If

        End Sub
        Private Sub btnCuadro14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuadro14.Click
            If dgwGrilla.CurrentRow.Selected = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione una fila")
                Exit Sub
            End If
            If Me.dgwGrilla.RowCount > 0 Then

                FRM_ReporteCuadro14()

            End If

        End Sub
        Private Sub btnCuadro15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuadro15.Click

            If dgwGrilla.CurrentRow.Selected = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione una fila")
                Exit Sub
            End If

            If Me.dgwGrilla.RowCount > 0 Then

                FRM_ReporteCuadro15()

            End If

        End Sub

        Private Sub cbbAnio__SelectedIndexChanged() Handles cbbAnio._SelectedIndexChanged

            If Me.blnCombo = True And Me.Anio = -1 Then
                Me.Mes = -1
            End If

            If Me.Anio > 0 And Me.Mes > 0 Then
                If chkFechaCorte.Checked Then
                    Me.dtpFechaCorte.Enabled = True
                    Me.dtpFechaCorte.ValueLong = 0
                Else
                    Me.dtpFechaCorte.ValueLong = 0
                End If
            Else
                Me.FechaCorte = 0
                Me.dtpFechaCorte.Enabled = False
                Me.chkFechaCorte.CheckState = CheckState.Unchecked
            End If
        End Sub
        Private Sub cbbMes__SelectedIndexChanged() Handles cbbMes._SelectedIndexChanged

            If Me.Anio > 0 And Me.Mes > 0 Then
                If chkFechaCorte.Checked Then
                    Me.dtpFechaCorte.Enabled = True
                    Me.dtpFechaCorte.ValueLong = 0
                Else
                    Me.dtpFechaCorte.ValueLong = 0
                End If
            Else
                Me.FechaCorte = 0
                Me.dtpFechaCorte.Enabled = False
                Me.chkFechaCorte.CheckState = CheckState.Unchecked
            End If

        End Sub
        Private Sub chkFechaCorte_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFechaCorte.CheckedChanged
            If chkFechaCorte.Checked Then
                Me.dtpFechaCorte.Enabled = True
                Me.dtpFechaCorte.ValueLong = 0
            Else
                Me.dtpFechaCorte.Enabled = False
                Me.dtpFechaCorte.ValueLong = 0
            End If

        End Sub
        Private Sub dgwGrilla_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter

            HabilitarAnularEliminar()
            HabilitarBotones()
            Me.dgwGrilla.Rows(e.RowIndex).Cells("col_est_nom").Style.SelectionBackColor = dgwGrilla.Item("col_pad_col", e.RowIndex).Value

        End Sub
        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            If dgwGrilla.CurrentRow.Selected = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione una fila")
                Exit Sub
            End If

            Select Case Me.GrillaEstado
                Case Padin.EnumPadinEstado.Anulado
                    Legolas.Configuration.Aplication.MessageBox.Information("El registro ya se encuentra anulado")
                Case Padin.EnumPadinEstado.EnviadoRegion
                    AAnular()
                Case Else
                    AEliminar()
            End Select

        End Sub
        Private Sub rdbPendiente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbPendiente.CheckedChanged, _
                                   rdbProcesado.CheckedChanged, rdbEnviado.CheckedChanged, rdbEnvSdCentral.CheckedChanged, rdbTodos.CheckedChanged

            If Me.rdbPendiente.Checked Or Me.rdbProcesado.Checked = True Then
                ckbAnulados.Visible = False
            Else
                ckbAnulados.Checked = False
                ckbAnulados.Visible = True
            End If
            Listar()

        End Sub
#End Region
#Region "Usuario/Permisos"
        Private Sub UsuarioPermisos(ByRef blnCerrarForm As Boolean)

            Dim intTipoLocal As Short = -1
            Dim objBssInst As New Bussines.Sistema.Instalacion
            intTipoLocal = objBssInst.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            Select Case intTipoLocal
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Modulo [Padin] no está disponible en los Establecimientos Penitenciarios de LimaMetropolitana")
                    blnCerrarForm = True
                    Me.Close()
                    Exit Sub
                Case Else
                    'pasa en la sede, en los penales de provincias y la sede regionales
            End Select

        End Sub
#End Region
        Private Sub rdbTodos_Click(sender As Object, e As System.EventArgs) Handles rdbTodos.Click
            If Me.rdbTodos.Checked Then
                ckbAnulados.Visible = True
            Else
                ckbAnulados.Visible = False
            End If
        End Sub

        Private Sub ckbAnulados_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbAnulados.CheckedChanged
            Listar()
        End Sub

        Private Sub dgwGrilla_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgwGrilla.CellPainting

            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub

            If dgwGrilla.Columns(e.ColumnIndex).Name = "col_est_nom" Then
                e.CellStyle.BackColor = dgwGrilla.Item("col_pad_col", e.RowIndex).Value
            End If

        End Sub

        Private Sub frmBuscar_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Dim blnCerrar As Boolean = False
            UsuarioPermisos(blnCerrar)

        End Sub

        Private Sub chkSelect_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSeleccionar.CheckedChanged

            If Me.chkSeleccionar.Checked Then
                CheckUncheckAllColumn(True, Me.dgwGrilla)
            Else
                CheckUncheckAllColumn(False, Me.dgwGrilla)
            End If

        End Sub

        Private Sub PadinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PadinToolStripMenuItem.Click

            exportarMultiplePadin(3)
        End Sub

        Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click

            exportarMultiplePadin(1)

        End Sub

        Private Sub EgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgresosToolStripMenuItem.Click

            exportarMultiplePadin(2)

        End Sub
    End Class
End Namespace
