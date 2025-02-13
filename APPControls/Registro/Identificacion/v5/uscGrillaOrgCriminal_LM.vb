Imports Type.Enumeracion.Licencia

Namespace Registro.Siscrico
    Public Class uscGrillaOrgCriminal_LM
        Private objEntCol As Entity.Registro.InternoOrgCriminalCol = Nothing
        Private objBss As New Bussines.Registro.InternoOrgCriminal
        Public Event _AddInternoBanda()
        Public Event _UpdInternoBanda(forzarRegistroSoloLectura As Boolean)
        Public Event _AnularInternoBanda()
#Region "Propiedades_Par"
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoIngresoID As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades_Grilla"

        Public ReadOnly Property GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_pen_id").Value
                End With
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaID() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_id").Value
                End With
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaIngresoInpeNro() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_ing_inpe_nro").Value
                End With
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaIngresoInpeID() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_ing_inpe_id").Value
                End With
                Return intValue
            End Get
        End Property

        Public ReadOnly Property GrillaIngresoNro() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_ing_nro").Value
                End With
                Return intValue
            End Get
        End Property

        Public ReadOnly Property GrillaIngresoID() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_ing_id").Value
                End With
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaDocJudID() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_doc_jud_id").Value
                End With
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaEstadoId() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_int_ban_est").Value
                End With
                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades_Busqueda"
        Public Property _InternoID() As Integer = -1
        Public Property _Codigo() As Integer = -1
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
            Set(value As Boolean)
                blnVisibleEliminar = value
                VisibleControles()
            End Set
        End Property
#End Region
#Region "Listar"
        Public Sub _LoadUsc()

            Listar()

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana
                    col_ing_inpe_nro.Visible = True
                    col_ing_nro.Visible = False
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    col_ing_nro.Visible = False
                    col_ing_inpe_nro.Visible = True
                Case Else
                    col_ing_nro.Visible = True
                    col_ing_inpe_nro.Visible = False
            End Select
        End Sub

        Private Sub Listar()

            If Me._InternoID < 1 Then Exit Sub

            Dim objIntBand As New Entity.Registro.InternoOrgCriminal
            objIntBand.InternoID = Me._InternoID

            objBss = New Bussines.Registro.InternoOrgCriminal
            objEntCol = New Entity.Registro.InternoOrgCriminalCol
            objIntBand.IngresoInpeID = Me._IngresoInpeID
            Select Case Me.TipoLicencia
                Case enmTipoLicencia.PenalLimaMetropolitana
                    'objIntBand.PenalID = Me._PenalID
                    '    objIntBand.IngresoID = Me._InternoIngresoID
                Case enmTipoLicencia.Carceleta
                    'objIntBand.PenalID = Me._PenalID'no es necesario filtrar x penal
            End Select

            objEntCol = objBss.ListarIntegrantesBandaGrilla_LM(objIntBand, Me.TipoLicencia)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With
        End Sub

#End Region
#Region "Accion"
        Private Sub AEliminarIntBanda()

            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If

            Dim regForzarSoloLectura As Boolean = False

            If Me.GrillaPenalId <> Me._PenalID Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Registro bloqueado, no es posible eliminar el registro seleccionado.")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then
                objBss = New Bussines.Registro.InternoOrgCriminal
                objBss.Eliminar(Me.GrillaID)
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Listar()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub VisibleControles()

            Dim blnCabecera As Boolean = True

            Me.pnlGrabar.Visible = Me._VisibleGrabar

            If Me._VisibleGrabar = False And Me._VisibleEliminar = False Then blnCabecera = False

            Me.pnlCabecera.Visible = blnCabecera

        End Sub

        Private Function GrillaCheckCount() As Integer

            Dim value As Integer = 0

            Me.dgwGrilla.CurrentCell = Nothing
            For Each row As DataGridViewRow In Me.dgwGrilla.Rows
                If row.Cells("col_chk").Value = True Then
                    value = value + 1
                End If
            Next

            Return value

        End Function
#End Region

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
            ' e.ColumnIndex 
            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                    End If

                End With

            Catch ex As Exception

            End Try

        End Sub
        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 Then
                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaPenalId <> Me._PenalID Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If
                RaiseEvent _UpdInternoBanda(regForzarSoloLectura)
            End If

        End Sub
        Private Sub btnAddIntBanda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddIntBanda.Click

            RaiseEvent _AddInternoBanda()

        End Sub
        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            If e.KeyCode = Keys.Delete Then btnEliminar_Click(sender, e)

        End Sub
        Private Sub dgwGrilla_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrilla.RowPrePaint

            With Me.dgwGrilla
                .Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Black
                .Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            End With
        End Sub


        Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click
            If dgwGrilla.SelectedRows.Count > 0 Then
                If GrillaEstadoId = 1 Then
                    
                    If Me.GrillaPenalId <> Me._PenalID Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                        Exit Sub
                    End If
                    RaiseEvent _AnularInternoBanda()
                Else
                    Dim strMensaje As String = ""
                    strMensaje = "Registro ya se encuentra ANULADO, Seleccione Otro Registro"
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                    Exit Sub

                End If
            Else
                Dim strMensaje As String = ""
                strMensaje = "Seleccione un registro para INACTIVAR"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If

        End Sub
        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
            If dgwGrilla.SelectedRows.Count > 0 Then
                AEliminarIntBanda()
            Else
                Dim strMensaje As String = ""
                strMensaje = "Seleccione el Registro a eliminar"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
            End If

        End Sub
        Private Sub dgwGrilla_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellMouseEnter
            If dgwGrilla.Columns(e.ColumnIndex).Name = "verDoc" And e.RowIndex >= 0 Then
                dgwGrilla.Cursor = Cursors.Hand
            End If
        End Sub
        Private Sub dgwGrilla_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellMouseLeave
            If dgwGrilla.Columns(e.ColumnIndex).Name = "verDoc" And e.RowIndex >= 0 Then
                dgwGrilla.Cursor = Cursors.Default
            End If
        End Sub

        Private Sub btnModFamiliar_Click(sender As System.Object, e As System.EventArgs) Handles btnModFamiliar.Click
            If Me.dgwGrilla.RowCount > 0 Then
                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaPenalId <> Me._PenalID Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If

                RaiseEvent _UpdInternoBanda(regForzarSoloLectura)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            End If
        End Sub
    End Class
End Namespace
