Namespace Registro.Siscrico
    Public Class uscGrillaOrgCriminalV2
        Private objEntCol As Entity.Registro.InternoOrgCriminalCol = Nothing
        Private objBss As New Bussines.Registro.InternoOrgCriminal
        Public Event _AddInternoBanda()
        Public Event _UpdInternoBanda()
        Public Event _AnularInternoBanda()
#Region "Propiedades_Par"
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoIngresoID As Integer = -1
#End Region
#Region "Propiedades_Grilla"
        Public ReadOnly Property GrillaID() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_id").Value
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
        Private intInternoID As Integer = -1
        Public Property _InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property
        Private intCodigo As Integer = -1
        Public Property _Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
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
            Set(value As Boolean)
                blnVisibleEliminar = value
                VisibleControles()
            End Set
        End Property
#End Region
#Region "Listar"
        Public Sub _LoadUsc()

            Listar()

        End Sub
        Private Sub Listar()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            Dim objIntBand As New Entity.Registro.InternoOrgCriminal
            objIntBand.InternoID = Me._InternoID
            objIntBand.IngresoID = Me._InternoIngresoID
            objIntBand.BandaID = -1
            objIntBand.Estado = -1
            objIntBand.BandaMiembroTipoID = -1

            objIntBand.CodigoInterno = ""
            objIntBand.ApePatInterno = ""
            objIntBand.ApeMatInterno = ""
            objIntBand.NombresInterno = ""
            objBss = New Bussines.Registro.InternoOrgCriminal()
            objEntCol = New Entity.Registro.InternoOrgCriminalCol()

            objEntCol = objBss.ListarIntegrantesBanda2(objIntBand)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol

                If .RowCount > 0 Then
                    '.SelectedRows(0).Selected = False
                End If

                'Me.lblCount.Text = .RowCount.ToString & " Reg."
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

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then
                Dim objBss As New Bussines.Registro.InternoOrgCriminal
                Dim intValue As Integer = -1
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
            'Me.pnlEliminar.Visible = Me._VisibleEliminar

            If Me._VisibleGrabar = False And Me._VisibleEliminar = False Then
                blnCabecera = False
            End If

            Me.pnlCabecera.Visible = blnCabecera

        End Sub
        Private Sub ValoresxDefault()

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
                RaiseEvent _UpdInternoBanda()
            End If

        End Sub
        Private Sub btnAddIntBanda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddIntBanda.Click

            RaiseEvent _AddInternoBanda()

        End Sub
        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            If e.KeyCode = Keys.Delete Then
                btnEliminar_Click(sender, e)
            End If

        End Sub
        Private Sub dgwGrilla_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrilla.RowPrePaint

            With Me.dgwGrilla

                .Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Black
                .Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor

            End With
        End Sub
        Private Sub uscGrillaBandas_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click
            If dgwGrilla.SelectedRows.Count > 0 Then
                If GrillaEstadoId = 1 Then
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
                RaiseEvent _UpdInternoBanda()
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            End If
        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub
    End Class
End Namespace
