
Namespace Visita
    Public Class uscAutorizacion
        Private objBss As Bussines.Visita.Autorizacion = Nothing
        Private objEntCol As Entity.Visita.AutorizacionCol = Nothing
#Region "Eventos"
        Public Event _Click_Agregar()
        Public Event _Click_RadioButton_Tipo()
        Public Event _Click_RadioButton_Estado()
        Public Event _CellDoubleClick_Grilla(ByVal Codigo As Integer)
#End Region
#Region "Propiedades_Parametricas"
        Public Property _InternoID() As Integer = -1
        Public Property _VisitanteID() As Integer = -1
        Public Property _AutorizavionVista As Type.Enumeracion.Visita.AutorizacionVista = Type.Enumeracion.Visita.AutorizacionVista.Interno
#End Region
#Region "Propiedades_Grilla"
        Public ReadOnly Property GrillaID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_id").Value '
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades_publicas"
        Public ReadOnly Property _GrillaID() As Integer
            Get
                Return Me.GrillaID
            End Get
        End Property
        Public ReadOnly Property _GrillaCount() As Integer
            Get
                Return Me.dgwGrilla.RowCount
            End Get
        End Property
#End Region
#Region "Propiedades_Usc"
        Public Property _visibleCabecera() As Boolean
            Get
                Return Me.pnlCabecera.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.pnlCabecera.Visible = value
            End Set
        End Property
        Public Property _VisibleBotonAdd As Boolean
            Get
                Return Me.pnlAdd.Visible
            End Get
            Set(value As Boolean)
                Me.pnlAdd.Visible = value
            End Set
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private ReadOnly Property TipoID() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbAutorizado.Checked = True Then
                    value = 1
                End If

                If Me.rdbAnulado.Checked = True Then
                    value = 2
                End If

                Return value

            End Get
        End Property
        Private Property EstadoID() As Short
            Get
                Dim value As Integer = -1

                If Me.rdbActivo.Checked = True Then
                    value = 1
                End If

                If Me.rdbInactivo.Checked = True Then
                    value = 0
                End If

                Return value

            End Get
            Set(value As Short)

                Select Case value
                    Case 0
                        Me.rdbInactivo.Checked = True
                    Case 1
                        Me.rdbActivo.Checked = True
                    Case Else
                        Me.rdbTodos.Checked = True
                End Select
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()

            objBss = New Bussines.Visita.Autorizacion
            Dim objEntFiltro As New Entity.Visita.Autorizacion

            With objEntFiltro
                .InternoID = Me._InternoID
                .VisitanteID = Me._VisitanteID
                .TipoID = Me.TipoID
                .EstadoID = Me.EstadoID
            End With

            objEntCol = objBss.Listar(objEntFiltro)

            Dim blnMostrarColumnaInterno As Boolean = False
            Dim blnMostrarColumnaVisitante As Boolean = False

            Select Case Me._AutorizavionVista
                Case Type.Enumeracion.Visita.AutorizacionVista.Visitante
                    blnMostrarColumnaInterno = True
                    blnMostrarColumnaVisitante = False
                Case Type.Enumeracion.Visita.AutorizacionVista.Interno
                    blnMostrarColumnaInterno = False
                    blnMostrarColumnaVisitante = True
            End Select

            Me.col_int_ape_nom.Visible = blnMostrarColumnaInterno
            Me.col_vis_tip_num_doc.Visible = blnMostrarColumnaVisitante
            Me.col_vis_ape_nom.Visible = blnMostrarColumnaVisitante

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .DataSource = objEntCol

                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

        End Sub
#End Region
#Region "Validar"
        Private Function ValidarParametrosEntrada() As Boolean

            Dim value As Boolean = False

            Select Case Me._AutorizavionVista
                Case Type.Enumeracion.Visita.AutorizacionVista.Interno

                    If Me._InternoID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError(
                            "El parametro _InternoID, no ha sido enviado en la aplicacion")
                        Return value
                    End If

                Case Type.Enumeracion.Visita.AutorizacionVista.Visitante

                    If Me._VisitanteID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError(
                            "El parametro _VisitanteID, no ha sido enviado en la aplicacion")
                        Return value
                    End If

            End Select

            value = True

            Return value
        End Function
#End Region
#Region "Usc"
        Public Sub _ExportarGrilla()

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub
        Public Sub _LoadUsc()

            ValidarParametrosEntrada()
            Listar()
        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarEstado()

            Select Case Me.TipoID
                Case 2 'anulado
                    Me.EstadoID = 1
                    Me.grbEstado.Enabled = False
                Case Else
                    Me.grbEstado.Enabled = True
            End Select

        End Sub
#End Region
        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

            RaiseEvent _Click_Agregar()

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

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                RaiseEvent _CellDoubleClick_Grilla(Me.GrillaID)
            End If

        End Sub

        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex
                    Case .Columns("col_fec").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaString(e.Value)
                        Else
                            e.Value = ""
                        End If
                End Select
            End With

        End Sub

        Private Sub rdbAutorizado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles rdbAutorizado.Click,
            rdbAnulado.Click,
            rdbTodos.Click

            HabilitarEstado()

            Listar()

            RaiseEvent _Click_RadioButton_Tipo()

        End Sub

        Private Sub rdbActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
            rdbActivo.Click,
            rdbInactivo.Click,
            rdbTodosEstado.Click

            Listar()
            RaiseEvent _Click_RadioButton_Estado()

        End Sub
    End Class
End Namespace