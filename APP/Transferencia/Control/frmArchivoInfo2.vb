Option Explicit On

Namespace Transferencia.Control
    Public Class frmArchivoInfo2
        Private objBss As Bussines.Transferencia.ArchivoInfo2 = Nothing
        Private objEntCol As Entity.Transferencia.ArchivoInfo2Col = Nothing
#Region "Propiedades"
        Private _intPenalId As Integer = -1
        Private Property RegionID() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private Property PenalID() As Integer
            Get
                Return _intPenalId
            End Get
            Set(ByVal value As Integer)
                _intPenalId = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaRegionID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    value = Me.dgw_control.SelectedRows(0).Cells("col_reg_id").Value
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaRegionNombre() As String
            Get
                Dim value As String = ""
                Try
                    value = Me.dgw_control.SelectedRows(0).Cells("col_reg_nom").Value
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaPenalID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    value = Me.dgw_control.SelectedRows(0).Cells("col_pen_id").Value
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaPenalNombre() As String
            Get
                Dim value As String = ""
                Try
                    value = Me.dgw_control.SelectedRows(0).Cells("col_pen_nom").Value
                Catch ex As Exception
                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Combo"
        Private blnCombo As Boolean = False
        Private Sub Combo()
            blnCombo = False
            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select

            With Me.cbbRegion
                ._Todos = blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Region
                .LoadUsc()
            End With
            blnCombo = True
        End Sub

#End Region
#Region "Listar"
        Public Sub ListarGrillaRegion()

            Dim sms As String = ""

            Dim ins As New Bussines.Sistema.Instalacion

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                objBss = New Bussines.Transferencia.ArchivoInfo2

                Dim objEntRegCol As New Entity.Transferencia.ArchivoInfoRegionCol
                Dim objEntReg As New Entity.Transferencia.ArchivoInfoRegion

                objEntReg.RegionID = Me.RegionID

                objEntRegCol = objBss.ListarRegion_ws(True, objEntReg, sms)

                If sms <> "" Then
                    Legolas.Configuration.Aplication.MessageBox.Information(sms)
                    Exit Sub
                End If

                With Me.dgwGrillaRegion
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False

                    .DataSource = objEntRegCol
                End With

                Me.PnlRegion.Visible = True

                If Me.dgwGrillaRegion.Rows.Count > 0 Then ListarGrillaPenal(dgwGrillaRegion.SelectedRows(0).Cells("col_region_id").Value)

            Else
                If ins.Listar(Configuracion.Licencia.Codigo).Tipo = 2 Then ListarGrillaPenal(cbbRegion.SelectedValue) 'usuario nivel region
                Me.PnlRegion.Visible = False
            End If          

            For i As Integer = 0 To Me.dgwGrillaRegion.Rows.Count - 1
                Me.dgwGrillaRegion.Item("col_reg_desq", i).Value = "Desbloq."
                Me.dgwGrillaRegion.Item("col_reg_bloq", i).Value = "Bloquear"
            Next

        End Sub
        Public Sub ListarGrillaPenal(RegionID As Integer)

            Dim sms As String = ""
            Dim objBss As Bussines.Transferencia.ArchivoInfo2
            objBss = New Bussines.Transferencia.ArchivoInfo2

            Me.col_pen_ins.Tag = "fecha"
            Me.col_ult_sub_sed.Tag = "fecha_hora"
            Me.col_ult_proc_sed.Tag = "fecha_hora"
            Me.col_ant_proc_sede.Tag = "fecha_hora"
            Me.col_img_transfer.Tag = "image"

            Dim blnVerSede As Boolean = False
            If Configuracion.Licencia.Codigo = 1 Then blnVerSede = True 'sede central

            objEntCol = objBss.Listar_ws(blnVerSede, RegionID, Me.PenalID, (New Bussines.Sistema.Instalacion).Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp()).Tipo, sms)
            If sms <> "" Then
                Legolas.Configuration.Aplication.MessageBox.Information(sms)
                Exit Sub
            End If

            With Me.dgw_control
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

            For i As Integer = 0 To dgw_control.Rows.Count - 1
                If LCase(dgw_control.Item("col_bloq_penal", i).Value) = "bloqueado" Then
                    dgw_control.Item("col_bloq_transfer", i).Value = "Desbloq."
                Else
                    dgw_control.Item("col_bloq_transfer", i).Value = "Bloquear"
                End If
            Next
        End Sub
#End Region
#Region "Otros"
        Private Sub UsuarioPermiso()

            Dim blnEscritura As Boolean = Me._FormEscritura

            If Me._FormEscritura = True Then

                If Legolas.LBusiness.Globall.WinApp.LicenciaApp() = 1 Then
                    If Legolas.Configuration.Usuario.OficinaID <> 1 Then 'oficina de sistemas
                        blnEscritura = False
                    End If
                Else
                    blnEscritura = False
                End If
            End If

            Me.btnExportar.Visible = Me._FormReporte
            Me.pnlBotonesModi.Visible = blnEscritura
            Me.col_reg_bloq.Visible = blnEscritura
            Me.col_reg_desq.Visible = blnEscritura

            Me.col_bloq_transfer.Visible = blnEscritura

        End Sub
        Private Sub FRMDetalle()

            Me.Cursor = Cursors.WaitCursor

            Dim frm As New Transferencia.Control.frmArchivoInfoPopup2
            With frm
                ._pRegionID = Me.GrillaRegionID
                ._pRegionNombre = Me.GrillaRegionNombre
                ._pPenalID = Me.GrillaPenalID
                ._pPenalNombre = Me.GrillaPenalNombre
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormEliminar = Me._FormEliminar
                .ShowDialog()
            End With

            Me.Cursor = Cursors.Default

        End Sub

        Private Sub ValoresxDefault()
            Combo()
        End Sub

        Private Sub TransferenciaActivarBloquear(intBloquear As Short)

            Dim strMensajeOut As String = ""

            Dim bssMnPenal As New Bussines.Transferencia.ArchivoInfo2

            For Each fila As DataGridViewRow In Me.dgw_control.Rows
                bssMnPenal.GrabarBloqueoPenalTranfer(intBloquear, fila.Cells("col_pen_id").Value, fila.Cells("col_reg_id").Value, strMensajeOut)
            Next

        End Sub

#End Region

        Private Sub dgw_control_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw_control.CellClick

            Try
                With Me.dgw_control
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

        Private Sub dgw_control_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw_control.CellDoubleClick
            If e.RowIndex >= 0 And dgw_control.Columns(e.ColumnIndex).Name <> "col_bloq_transfer" Then FRMDetalle()
        End Sub

        Private Sub dgw_control_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgw_control.CellFormatting
            With Me.dgw_control
                Select Case e.ColumnIndex

                    Case .Columns("col_pen_ins").Index, .Columns("col_ult_sub_sed").Index, .Columns("col_ult_proc_sed").Index, .Columns("col_ant_proc_sede").Index ',.Columns("col_ult_proc_reg").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                        Else
                            e.Value = "PENDIENTE"
                        End If
                    Case .Columns("col_img_transfer").Index
                        If LCase(dgw_control.Item("col_bloq_penal", e.RowIndex).Value) = "bloqueado" Then
                            e.Value = My.Resources.anular2
                        Else
                            e.Value = My.Resources.accept_32
                        End If
                End Select
            End With
        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
            dgw_control.Columns("col_indicador").Visible = True
            Me.col_img_transfer.Visible = False
            col_bloq_transfer.Visible = False
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgw_control)
            Me.col_img_transfer.Visible = True
            col_bloq_transfer.Visible = True
            dgw_control.Columns("col_indicador").Visible = False
        End Sub

        Private Sub cbbRegion__ValueChanged() Handles cbbRegion._SelectedIndexChanged
            If blnCombo Then

                Me.col_reg_nom.Visible = IIf(Me.RegionID < 1, True, False)

                Me.Cursor = Cursors.WaitCursor
                ListarGrillaRegion()
                ListarGrillaPenal(Me.RegionID)
                Me.Cursor = Cursors.Default
            End If
        End Sub

        Private Sub dgwGrillaRegion_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaRegion.CellClick

            If e IsNot Nothing AndAlso e.RowIndex = -1 Then Exit Sub

            With Me.dgwGrillaRegion
                If .Rows.Count = 0 Then Exit Sub
                If .Columns(e.ColumnIndex).Name = "col_reg_bloq" Or .Columns(e.ColumnIndex).Name = "col_reg_desq" Then Exit Sub
                Me.Cursor = Cursors.WaitCursor
                ListarGrillaPenal(.SelectedRows(0).Cells("col_region_id").Value)
                Me.Cursor = Cursors.Default
            End With


        End Sub

        Private Sub dgw_control_RowPrePaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgw_control.RowPrePaint

            Try
                Dim intDias As Integer = 0
                If dgw_control.Item("col_ult_sub_sed", e.RowIndex).Value = 0 Then Exit Sub
                If dgw_control.Item("col_indicador", e.RowIndex).Value = "AMARILLO" Then
                    dgw_control.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128) 'amarillo
                ElseIf dgw_control.Item("col_indicador", e.RowIndex).Value = "NARANJA" Then
                    dgw_control.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128) 'naranja
                ElseIf dgw_control.Item("col_indicador", e.RowIndex).Value = "ROJO" Then
                    dgw_control.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128) 'rojo
                End If
                Exit Sub

            Catch ex As Exception

            End Try

        End Sub

        Private Sub frmArchivoInfo2_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            UsuarioPermiso()
            ValoresxDefault()
            Me.WindowState = FormWindowState.Maximized
            Me.Refresh()

            Me.Cursor = Cursors.WaitCursor
            ListarGrillaRegion()
            Me.Cursor = Cursors.Default

        End Sub

        Private Sub dgw_control_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw_control.CellContentClick

            If dgw_control.Columns(e.ColumnIndex).Name = "col_bloq_transfer" Then
                If e.RowIndex = -1 Then Exit Sub
                Dim bssMnPenal As New Bussines.Transferencia.ArchivoInfo2
                Dim strMensajeOut As String = ""

                If dgw_control.Item("col_bloq_transfer", e.RowIndex).Value.ToString.ToLower = "DESBLOQ.".ToLower Then 'on

                    If Legolas.Configuration.Aplication.MessageBox.Question("Confirma ACTIVAR la transferencia de datos del penal origen seleccionado hacia la sede central") = Windows.Forms.DialogResult.Yes Then
                        If bssMnPenal.GrabarBloqueoPenalTranfer(0, dgw_control.Item("col_pen_id", e.RowIndex).Value,
                                                                dgw_control.Item("col_reg_id", e.RowIndex).Value, strMensajeOut) = False Then

                            MsgBox("Error. No se pudo completar la operación " & strMensajeOut, MsgBoxStyle.Critical)
                        Else
                            Me.Cursor = Cursors.WaitCursor
                            ListarGrillaPenal(dgwGrillaRegion.SelectedRows(0).Cells("col_region_id").Value)
                            Me.Cursor = Cursors.Default
                        End If
                    End If
                Else
                    If Legolas.Configuration.Aplication.MessageBox.Question("Confirma BLOQUEAR la transferencia de datos del penal origen seleccionado hacia la sede central") = Windows.Forms.DialogResult.Yes Then
                        If bssMnPenal.GrabarBloqueoPenalTranfer(1, dgw_control.Item("col_pen_id", e.RowIndex).Value,
                                                                dgw_control.Item("col_reg_id", e.RowIndex).Value, strMensajeOut) = False Then
                            MsgBox("Error. No se pudo completar la operación " & strMensajeOut, MsgBoxStyle.Critical)
                        Else
                            Me.Cursor = Cursors.WaitCursor
                            ListarGrillaPenal(dgwGrillaRegion.SelectedRows(0).Cells("col_region_id").Value)
                            Me.Cursor = Cursors.Default
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub dgw_control_ColumnHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw_control.ColumnHeaderMouseClick
            Try
                'setear
                For i As Integer = 0 To dgw_control.Rows.Count - 1
                    dgw_control.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
                Next
                For i As Integer = 0 To dgw_control.Rows.Count - 1
                    Dim intDias As Integer = 0
                    If dgw_control.Item("col_ult_sub_sed", i).Value = 0 Then Continue For

                    Dim fechUltTransfer As Date = Legolas.Components.FechaHora.FechaDate(dgw_control.Item("col_ult_sub_sed", i).Value, True)

                    intDias = DateDiff(DateInterval.Day, fechUltTransfer, Now)

                    If intDias > 3 And intDias <= 10 Then
                        dgw_control.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128) 'amarillo
                    ElseIf intDias > 10 And intDias <= 30 Then
                        dgw_control.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128) 'naranja
                    ElseIf intDias > 30 Then
                        dgw_control.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128) 'rojo
                    End If
                Next
            Catch ex As Exception

            End Try
        End Sub

        Private Sub dgwGrillaRegion_RowPrePaint(sender As System.Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrillaRegion.RowPrePaint
            Try
                If dgwGrillaRegion.Item("col_tul_fec_desc", e.RowIndex).Value = "" Then Exit Sub

                If dgwGrillaRegion.Item("col_indicador_estado", e.RowIndex).Value = "AMARILLO" Then
                    dgwGrillaRegion.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128) 'amarillo
                ElseIf dgwGrillaRegion.Item("col_indicador_estado", e.RowIndex).Value = "NARANJA" Then
                    dgwGrillaRegion.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128) 'naranja
                ElseIf dgwGrillaRegion.Item("col_indicador_estado", e.RowIndex).Value = "ROJO" Then
                    dgwGrillaRegion.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128) 'rojo
                End If
                Exit Sub
            Catch ex As Exception

            End Try
        End Sub

        Private Sub btnBloquearTodo_Click(sender As System.Object, e As System.EventArgs) Handles btnBloquearTodo.Click

            Dim bssMnPenal As New Bussines.Transferencia.ArchivoInfo2
            Dim blnYes As Boolean = False

            If Legolas.Configuration.Aplication.MessageBox.Question("Confirma BLOQUEAR la transferencia de datos de todos los penales a nivel nacional hacia la sede central") = Windows.Forms.DialogResult.Yes Then
                blnYes = True
            End If

            Me.Cursor = Cursors.WaitCursor

            If blnYes Then
                ListarGrillaPenal(-1)
                TransferenciaActivarBloquear(1)
                ListarGrillaPenal(dgwGrillaRegion.SelectedRows(0).Cells("col_region_id").Value)
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            End If

            Me.Cursor = Cursors.Default

        End Sub

        Private Sub btnDesbloquearTodo_Click(sender As System.Object, e As System.EventArgs) Handles btnDesbloquearTodo.Click

            Dim bssMnPenal As New Bussines.Transferencia.ArchivoInfo2
            Dim blnYes As Boolean = False

            If Legolas.Configuration.Aplication.MessageBox.Question("Confirma ACTIVAR la transferencia de datos de los penales a nivel nacional hacia la sede central") = Windows.Forms.DialogResult.Yes Then
                blnYes = True
            End If

            Me.Cursor = Cursors.WaitCursor

            If blnYes Then
                ListarGrillaPenal(-1)
                TransferenciaActivarBloquear(0)
                ListarGrillaPenal(dgwGrillaRegion.SelectedRows(0).Cells("col_region_id").Value)
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            End If

            Me.Cursor = Cursors.Default

        End Sub

        Private Sub dgwGrillaRegion_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaRegion.CellContentClick

            If e.RowIndex = -1 Then Exit Sub

            With Me.dgwGrillaRegion

                Select Case .Columns(e.ColumnIndex).Name
                    Case "col_reg_bloq"

                        If Legolas.Configuration.Aplication.MessageBox.Question("Confirma BLOQUEAR la transferencia de datos de los penales de la region seleccionada hacia la sede central") = Windows.Forms.DialogResult.Yes Then
                            TransferenciaActivarBloquear(1)
                        End If

                        Me.Cursor = Cursors.WaitCursor
                        ListarGrillaPenal(.SelectedRows(0).Cells("col_region_id").Value)
                        Me.Cursor = Cursors.Default

                    Case "col_reg_desq"

                        If Legolas.Configuration.Aplication.MessageBox.Question("Confirma ACTIVAR la transferencia de datos de los penales de la region seleccionada hacia la sede central") = Windows.Forms.DialogResult.Yes Then
                            TransferenciaActivarBloquear(0)
                        End If

                        Me.Cursor = Cursors.WaitCursor
                        ListarGrillaPenal(.SelectedRows(0).Cells("col_region_id").Value)
                        Me.Cursor = Cursors.Default

                End Select

            End With

        End Sub

    End Class
End Namespace