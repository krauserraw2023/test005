Imports Type.Enumeracion.Licencia

Namespace Registro
    Public Class uscMovimiento
        Private objEntCol As Entity.Registro.InternoMovimientoCol = Nothing
        Private objBss As Bussines.Registro.InternoMovimiento

        Public Event _Click_AddNuevoMovimiento(IngresoID As Integer, strMensaje As String)
        Public Event _CellDoubleClick_UpdateMovimiento(MovimientoID As Integer, MovimientoGrupoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer, IngresoID As Integer, DocumentoJudID As Integer, Pendientes As Integer)
        Public Event _Click_EliminarMovimiento()
        Public Event _ClickFocusCombo()

#Region "Propiedades_Parametricas"
        Public Property Codigo() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _NroIngresoID() As Integer = -1
        Public Property _IngresoInpeID As Integer = -1
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#End Region
#Region "Propiedad_Retorno"

#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaMovID() As Integer
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
        Private ReadOnly Property GrillaConMovID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaConducciones
                        intValue = .SelectedRows(0).Cells("col_con_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaMovGrpID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_mov_grp_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaConMovGrpID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaConducciones
                        intValue = .SelectedRows(0).Cells("col_con_mov_grp_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaMovTipID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_mov_tip_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaConMovTipID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaConducciones
                        intValue = .SelectedRows(0).Cells("col_con_mov_tip_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaMovSubMotID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_mov_mot_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaMovMotID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_mov_mot_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaConMovMotID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaConducciones
                        intValue = .SelectedRows(0).Cells("col_con_mov_mot_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIngresoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_int_ing_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaConIngresoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaConducciones
                        intValue = .SelectedRows(0).Cells("col_con_int_ing_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaFechaMovLon() As Long
            Get
                Dim intValue As Long = 0
                Try
                    With Me.dgwGrilla
                        If .Rows(0).Selected = True Then
                            intValue = .SelectedRows(0).Cells("col_fec_mov_lon").Value
                        End If
                    End With
                    With Me.dgwGrillaConducciones
                        If .Rows(0).Selected = True Then
                            intValue = .SelectedRows(0).Cells("col_mov_fec_con").Value
                        End If
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaDocJudID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_doc_jud_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private intGrillaCount As Integer = 0
        Private Property GrillaCount() As Integer
            Get
                Return intGrillaCount
            End Get
            Set(ByVal value As Integer)
                intGrillaCount = value
                Me.lblReg.Text = intGrillaCount.ToString & " Reg."
            End Set
        End Property
        Public ReadOnly Property GrillaEstadoTram() As Integer
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
#End Region
#Region "Propiedades_UserControl"
        Private blnVisibleGrabar As Boolean = False
        Private blnVisibleEliminar As Boolean = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
                VisibleControles()
            End Set
        End Property
        Public Property _VisibleEliminar() As Boolean
            Get
                Return blnVisibleEliminar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleEliminar = value
                VisibleControles()
            End Set
        End Property
#End Region
#Region "Listar"

        Public Sub _Listar()

            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then dgwGrilla.Columns("col_pen_nom").Visible = False
            If Me._InternoID < 1 Then Exit Sub

            objEntCol = New Entity.Registro.InternoMovimientoCol
            objBss = New Bussines.Registro.InternoMovimiento

            Dim objEnt As New Entity.Registro.InternoMovimiento
            objEnt.InternoID = Me._InternoID
            objEnt.IngresoID = Me._NroIngresoID

            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta

                    objEnt.IngresoID = Me._NroIngresoID
                    objEnt._PenalID = Me._PenalID
                    objEnt.IngresoInpeId = Me._IngresoInpeID

                Case enmTipoLicencia.RegionLimaMetropolitana

                    objEnt.IngresoID = -1
                    objEnt.IngresoInpeId = Me._IngresoInpeID

                Case enmTipoLicencia.PenalLimaMetropolitana
                    objEnt.IngresoID = -1
                    objEnt.IngresoInpeId = Me._IngresoInpeID
            End Select

            Dim objCol As New Entity.Registro.InternoMovimientoCol
            Dim objcondCol As New Entity.Registro.InternoMovimientoCol

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then

                objEntCol = objBss.ListarGrilla_LM(objEnt)
            Else
                objEntCol = objBss.ListarGrilla(objEnt)
            End If

            For Each obj As Entity.Registro.InternoMovimiento In objEntCol
                If obj.MovimientoTipoID = 6 Then
                    objcondCol.Add(obj)
                Else
                    objCol.Add(obj)
                End If
            Next

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objCol
                Me.GrillaCount = .RowCount
                Me.dgwGrilla.ClearSelection()
            End With
            With Me.dgwGrillaConducciones
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objcondCol
                Me.GrillaCount = .RowCount
                Me.dgwGrillaConducciones.ClearSelection()
            End With
        End Sub

        'Public Sub _EjecutarMovimiento()
        '    If Me._InternoID < 1 Then Exit Sub

        '    objBss = New Bussines.Registro.InternoMovimiento
        '    If Me.GrillaEstadoTram = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
        '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Este Movimiento ya tiene el estado como ejecutado")
        '        Exit Sub
        '    Else
        '        Dim strMensaje As String = ""
        '        strMensaje = "Esta seguro de poner en estado de ejecutado, al movimiento !!!"
        '        If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then
        '            Dim valor As Boolean = False
        '            If Me.GrillaMovGrpID = 1 Then
        '                valor = 1
        '            Else
        '                valor = 0
        '            End If
        '            Dim objEnt As New Entity.Registro.InternoMovimiento
        '            With objEnt
        '                .Codigo = Me.GrillaMovID
        '                .EstadoID = valor
        '                .InternoID = Me._InternoID
        '                .IngresoID = Me._NroIngresoID
        '                .IngresoInpeId = Me._IngresoInpeID
        '                .MovimientoTipoID = Me.GrillaMovTipID
        '            End With
        '            objBss.ActualizarEstado(objEnt)
        '            'Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
        '            LoadUsc()
        '            Exit Sub
        '        End If
        '    End If
        'End Sub
#End Region
#Region "Accion"
        Private Function ValidarMovimientoEliminar() As Boolean
            Dim value As Boolean = False
            ''-------------------------------
            objBss = New Bussines.Registro.InternoMovimiento
            Dim objEntMov As New Entity.Registro.InternoMovimiento
            objEntMov.InternoID = Me._InternoID
            objEntMov.IngresoID = Me._NroIngresoID
            objEntMov.IngresoInpeId = Me._IngresoInpeID

            Dim objEntColec As New Entity.Registro.InternoMovimientoCol

            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEntColec = objBss.ListarGrilla_LM(objEntMov)
            Else
                objEntColec = objBss.ListarGrilla(objEntMov)
            End If

            '************************
            Dim dteFechaMov, dteFechaUltimoMov As Date
            dteFechaMov = Legolas.Components.FechaHora.FechaDate(Me.GrillaFechaMovLon, True)
            If objEntColec.Count > 0 Then
                dteFechaUltimoMov = Legolas.Components.FechaHora.FechaDate(objEntColec.InternoMovimiento(0).Fecha, True)
                If dteFechaMov < dteFechaUltimoMov Then
                    If Me.GrillaMovTipID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then
                        Dim objMovCol As New Entity.Registro.InternoMovimientoCol
                        Dim objMov As New Entity.Registro.InternoMovimiento
                        objMov.InternoID = Me._InternoID
                        objMov.IngresoID = Me._NroIngresoID
                        objMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                        objMovCol = objBss.ListarGrilla(objMov)
                        If objMovCol.InternoMovimiento(0).Fecha >= Me.GrillaFechaMovLon Then
                        Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede eliminar, porque existe un movimiento con fecha superior")
                            Return value
                        End If
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede eliminar, porque existe un movimiento con fecha superior")
                        Return value
                    End If
                End If
            End If
            ''-------------------------------
            Dim intTipoMov As Integer = GrillaConMovTipID

            'solo si es carceleta y el traslado se confirmó en el penal no permitir eliminar.
            If Me._TipoLicencia = enmTipoLicencia.Carceleta And intTipoMov = 2 Then
                Dim entMov As New Entity.Registro.InternoMovimiento
                entMov.Codigo = Me.GrillaMovID
                entMov = (New Bussines.Registro.InternoMovimiento).Listar_LM(entMov)
                If entMov.EstadoPenalDestinoID = 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible completar la operación, el traslado ya se hizo efectivo en el EP Destino.")
                    Return value
                End If
            End If

            value = True
            Return value
        End Function

        Private Sub EliminarMovimiento(esMovimientoConduccion As Boolean)
            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If

            If ValidarMovimientoEliminar() = False Then Exit Sub

            If Legolas.Configuration.Aplication.MessageBox.Question(
                "Confirma eliminar el registro de movimiento seleccionado?,completada la operación no podrá recuperar el registro eliminado.") = DialogResult.Yes Then

                Dim idMovimiento As Integer = -1

                If esMovimientoConduccion = True Then
                    idMovimiento = Me.GrillaConMovID
                Else
                    idMovimiento = Me.GrillaMovID
                End If

                objBss = New Bussines.Registro.InternoMovimiento

                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or
                    Me._TipoLicencia = enmTipoLicencia.Carceleta Then

                    objBss.Eliminar_LM(idMovimiento, Me._InternoID, Me.GrillaIngresoID, Me._IngresoInpeID)
                Else

                    objBss.Eliminar(idMovimiento, Me.GrillaIngresoID)
                End If

                _Listar()

                RaiseEvent _Click_EliminarMovimiento()
            End If
        End Sub

        'Private Sub CambiarEstadoMovimiento()
        '    If UCase(dgwGrilla.SelectedRows(0).Cells("col_est_nom").Value) <> "ACTIVO" Then
        '        MsgBox("El movimiento ya se encuentra inactivo", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If
        '    If MsgBox("Confirma cambiar el registro de movimiento seleccionado a estado INACTIVO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = DialogResult.Yes Then
        '        objBss = New Bussines.Registro.InternoMovimiento
        '        Dim objEnt As New Entity.Registro.InternoMovimiento
        '        With objEnt
        '            .Codigo = Me.GrillaMovID
        '            '.EstadoID = 0
        '            '.InternoID = Me._InternoID
        '            '.IngresoID = Me._NroIngresoID
        '            '.MovimientoTipoID = Me.GrillaMovTipID
        '        End With
        '        objBss.ActualizarEstado(objEnt) 'sin ...LM
        '        _Listar()
        '        MsgBox("Operación completada satisfactoriamente", MsgBoxStyle.Information)
        '    End If
        'End Sub
#End Region
#Region "Otros"
        Private Sub VisibleControles()
            Dim blnVisibleCabecera As Boolean = True
            Me.pnlGrabar.Visible = Me._VisibleGrabar
            Me.pnlEliminar.Visible = Me._VisibleEliminar

            If Me._VisibleGrabar = False And Me._VisibleEliminar = False Then blnVisibleCabecera = False
            Me.pnlCabecera.Visible = blnVisibleCabecera
        End Sub

        Public Sub LoadUsc()
            If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                col_pen_nom.Visible = True
            Else
                col_pen_nom.Visible = False
                col_pen_nom_con.Visible = False
            End If
            _Listar()
        End Sub
#End Region
#Region "Eventos_Formulario"

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            If e.RowIndex > -1 Then
                Dim pendientes As Integer = 0
                If Me._NroIngresoID > 0 Or Me._IngresoInpeID > 0 Then
                    For i As Integer = 0 To dgwGrilla.Rows.Count - 1
                        If dgwGrilla.Rows(i).Cells("col_est_id").Value = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente And
                           dgwGrilla.Rows(i).Cells("col_id").Value <> Me.GrillaMovID Then
                            pendientes = pendientes + 1
                        End If
                    Next
                End If
                If Me.dgwGrilla.RowCount > 0 Then
                    RaiseEvent _CellDoubleClick_UpdateMovimiento(Me.GrillaMovID, Me.GrillaMovGrpID, Me.GrillaMovTipID, Me.GrillaMovMotID, Me.GrillaIngresoID, Me.GrillaDocJudID, pendientes)
                    _Listar()
                End If
            End If
        End Sub

        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown
            Select Case e.KeyCode
                Case Keys.Delete
                    EliminarMovimiento(False)
            End Select
        End Sub

        Private Sub dgwGrilla_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
            With Me.dgwGrilla
                If e.RowIndex = -1 Then
                    Me.Cursor = Cursors.WaitCursor
                    objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                    Me.Cursor = Cursors.Default
                    .Refresh()
                End If
            End With
            Me.dgwGrillaConducciones.ClearSelection()
        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
            If Me.GrillaMovGrpID < 1 And Me.GrillaConMovGrpID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            Else
                If GrillaMovGrpID > 0 Then
                    RaiseEvent _CellDoubleClick_UpdateMovimiento(Me.GrillaMovID, Me.GrillaMovGrpID, Me.GrillaMovTipID, Me.GrillaMovMotID, Me.GrillaIngresoID, Me.GrillaDocJudID, 0)
                End If
                If GrillaConMovGrpID > 0 Then
                    RaiseEvent _CellDoubleClick_UpdateMovimiento(Me.GrillaConMovID, Me.GrillaConMovGrpID, Me.GrillaConMovTipID, Me.GrillaConMovMotID, Me.GrillaConIngresoID, -1, 0)
                End If
            End If
        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            Dim intValor_ As Integer = 0
            Dim strValor As String = ""
            If Me._NroIngresoID > 0 Or Me._IngresoInpeID > 0 Then
                For i As Integer = 0 To dgwGrilla.Rows.Count - 1
                    If dgwGrilla.Rows(i).Cells("col_est_id").Value = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente Then
                        intValor_ = intValor_ + 1
                        strValor = dgwGrilla.Rows(i).Cells("col_est_nom").Value
                    End If
                Next
            End If
            RaiseEvent _Click_AddNuevoMovimiento(intValor_, strValor)
        End Sub

#End Region

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
            If dgwGrilla.CurrentRow Is Nothing And dgwGrillaConducciones.CurrentRow Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
            Else
                If Not (dgwGrilla.CurrentRow Is Nothing) Then
                    If dgwGrilla.Rows(dgwGrilla.CurrentRow.Index).Selected = True Then
                        EliminarMovimiento(False)
                    End If
                End If
                If Not (dgwGrillaConducciones.CurrentRow Is Nothing) Then
                    If dgwGrillaConducciones.Rows(dgwGrillaConducciones.CurrentRow.Index).Selected = True Then
                        EliminarMovimiento(True)
                    End If
                End If
            End If
        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex
                    Case .Columns("col_mov_fec").Index, .Columns("col_fec_reg").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub

        Private Sub dgwGrillaConducciones_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwGrillaConducciones.CellFormatting
            With Me.dgwGrillaConducciones
                Select Case e.ColumnIndex
                    Case .Columns("col_mov_fec_con").Index, .Columns("col_fec_reg_con").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub

        Private Sub dgwGrillaConducciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaConducciones.CellClick
            Me.dgwGrilla.ClearSelection()
        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrillaConducciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaConducciones.CellContentClick

        End Sub

        Private Sub dgwGrillaConducciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaConducciones.CellDoubleClick
            If e.RowIndex > -1 Then
                Dim pendientes As Integer = 0
                If Me._NroIngresoID > 0 Or Me._IngresoInpeID > 0 Then
                    For i As Integer = 0 To dgwGrillaConducciones.Rows.Count - 1
                        If dgwGrillaConducciones.Rows(i).Cells("col_con_est_id").Value = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente And
                           dgwGrillaConducciones.Rows(i).Cells("col_con_id").Value <> Me.GrillaMovID Then
                            pendientes = pendientes + 1
                        End If
                    Next
                End If
                If Me.dgwGrilla.RowCount > 0 Then
                    RaiseEvent _CellDoubleClick_UpdateMovimiento(Me.GrillaConMovID, Me.GrillaConMovGrpID, Me.GrillaConMovTipID, Me.GrillaConMovMotID, Me.GrillaConIngresoID, Me.GrillaDocJudID, pendientes)
                    _Listar()
                End If
            End If
        End Sub

        Private Sub dgwGrillaConducciones_KeyDown(sender As Object, e As KeyEventArgs) Handles dgwGrillaConducciones.KeyDown
            Select Case e.KeyCode
                Case Keys.Delete
                    EliminarMovimiento(True)
            End Select
        End Sub
    End Class

End Namespace
