Namespace Visita.Visitante
    Public Class uscSancionv2
        Private objBss As Bussines.Visita.VisitanteSancion = Nothing
        Private objEntCol As Entity.Visita.VisitanteSancionCol = Nothing
        '/*eventos*/
        Public Event _ClickAgregar()
        Public Event _CellDoubleClick_Grilla(ByVal SancionID As Integer, EstadoID As Integer)
        Public Event _ClickAnulacion(ByVal SancionVisID As Integer)
        Public Event _ClickAnulacion_Desarrollo(ByVal SancionVisID As Integer)
#Region "Propiedades_Parametricas"
        Private intvisitanteid As Integer = -1
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Public Property _VisitanteID() As Integer
            Get
                Return intvisitanteid
            End Get
            Set(ByVal value As Integer)
                intvisitanteid = value
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
        Public Property _PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
#End Region
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

        Private ReadOnly Property GrillaEstadoId() As Integer
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

        Private ReadOnly Property GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaPenalOrigenId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pen_ori_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades_UserControl"
        Private blnVisibleGrabar As Boolean = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
            End Set
        End Property
        Public Property _VisiblePanelBotones As Boolean
            Get
                Return Me.pnlBotones.Visible
            End Get
            Set(value As Boolean)
                Me.pnlBotones.Visible = value
            End Set
        End Property

#End Region
#Region "Listar"
        Private Sub Listar()
            ''
            If Me._VisitanteID < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Visita.VisitanteSancion
            objEntCol = New Entity.Visita.VisitanteSancionCol

            objEntCol = objBss.Listar(-1, Me._VisitanteID, "", "", "", "", _
            0, 0, 0, -1, -1, -1)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.lblNroReg.Text = "Nº de Reg. " & objEntCol.Count

            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AAnular()

            If _VisibleGrabar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "No tiene permisos en el sistema, para poder anular la sancion")
                Exit Sub
            End If

            If Me.dgwGrilla.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Seleccione el registro de sancion para anular.")
                Exit Sub
            End If

            If Me.GrillaEstadoId = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "El registro de sancion ya se encuentra en estado anulado")
                Exit Sub
            End If

            If Me.GrillaPenalId <> Me.GrillaPenalOrigenId Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "El registro de sancion no puede ser anulado, porque ha sido registrado en otro penal.")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question( _
            "Desea anular la sancion") <> DialogResult.Yes Then
                Exit Sub
            End If

            RaiseEvent _ClickAnulacion(Me.GrillaCodigo)
            Listar()
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Me.pnlBotones.Visible = Me._VisibleGrabar

        End Sub
        Public Sub _LoadUsc()

            ValoresxDefault()
            Listar()

        End Sub

        Public Sub _limpiarGrilla()

            Me.dgwGrilla.DataSource = Nothing

        End Sub

#End Region

        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
            'AMantenimiento(True)
            RaiseEvent _ClickAgregar()

        End Sub

        Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click

            AAnular()

        End Sub
        Private Sub uscSancionv2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Me.dgwGrilla.VisibleCampos = True
            Me.dgwGrilla.Columns("col_fec_cre").ReadOnly = True
            Me.dgwGrilla.Columns("col_fec_anu").ReadOnly = True
            Me.dgwGrilla.Columns("col_fec_env_sed").ReadOnly = True
            Me.dgwGrilla.Columns("col_fec_rec_des").ReadOnly = True
            Me.col_fec_env_sed.Tag = "fecha"
            Me.col_fec_rec_des.Tag = "fecha"
        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
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

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            If Me.dgwGrilla.RowCount > 0 Then

                RaiseEvent _CellDoubleClick_Grilla(Me.GrillaCodigo, Me.GrillaEstadoId)

            End If
        End Sub




        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_ini").Index, .Columns("col_fec_fin").Index, .Columns("col_fec_env_sed").Index, _
                        .Columns("col_fec_rec_des").Index, .Columns("col_fec_cre").Index, .Columns("col_fec_anu").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            Select Case e.ColumnIndex
                                Case .Columns("col_fec_cre").Index, .Columns("col_fec_anu").Index, _
                                    .Columns("col_fec_env_sed").Index, .Columns("col_fec_rec_des").Index

                                    e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)

                                Case Else

                                    e.Value = Legolas.Components.FechaHora.FechaDate(e.Value).ToString("dd/MM/yyyy")

                            End Select
                        Else
                            Select Case e.ColumnIndex
                                Case .Columns("col_fec_env_sed").Index, .Columns("col_fec_rec_des").Index
                                    e.Value = "PENDIENTE"
                                Case .Columns("col_fec_fin").Index
                                    e.Value = "Indeterminado"
                                Case Else
                                    e.Value = ""
                            End Select
                        End If
                End Select
            End With
        End Sub

        Private Sub dgwGrilla_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgwGrilla.CellPainting
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            Try
                If dgwGrilla.Columns(e.ColumnIndex).Name = "col_reg_pen_org" Or dgwGrilla.Columns(e.ColumnIndex).Name = "col_fec_env_sed" Or dgwGrilla.Columns(e.ColumnIndex).Name = "col_fec_rec_des" Then

                    e.CellStyle.BackColor = Color.Yellow

                End If
                If dgwGrilla.Columns(e.ColumnIndex).Name = "col_est_nom" Then
                    If dgwGrilla.Item(e.ColumnIndex, e.RowIndex).Value = "Anulado" Then
                        e.CellStyle.BackColor = Color.IndianRed
                    Else
                        e.CellStyle.BackColor = Color.White
                    End If
                End If
            Catch ex As Exception
                Dim S As String
                S = S
            End Try
        End Sub

        Private Sub dgwGrilla_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            Select Case e.KeyData
                Case (Keys.Shift Or Keys.Delete)
                    If MessageBox.Show("Desea actualizar el envio, del registro anulado de la sancion", "Transferencia de Sanciones", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) = DialogResult.Yes Then

                        RaiseEvent _ClickAnulacion_Desarrollo(Me.GrillaCodigo)
                        Listar()
                    End If
                    Exit Sub
            End Select

            If e.KeyCode = Keys.Delete And Me.dgwGrilla.RowCount > 0 Then
                AAnular()
            End If

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter
            With Me.dgwGrilla
                .Rows(e.RowIndex).Cells("col_fec_env_sed").Style.SelectionBackColor = Color.Yellow
                .Rows(e.RowIndex).Cells("col_fec_rec_des").Style.SelectionBackColor = Color.Yellow
                If .Rows(e.RowIndex).Cells("col_est_nom").Value = "Anulado" Then
                    .Rows(e.RowIndex).Cells("col_est_nom").Style.SelectionBackColor = Color.IndianRed
                End If
            End With
        End Sub
    End Class
End Namespace