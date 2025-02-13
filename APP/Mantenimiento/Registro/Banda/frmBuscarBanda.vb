Imports System.IO
Namespace Mantenimiento.Registro.Banda
    Public Class frmBuscarBanda
        Private objBss As Bussines.Registro.Banda = Nothing
        Private objEntCol As Entity.Registro.BandaCol = Nothing
        Private objEntBand As Entity.Registro.Banda = Nothing

#Region "Propiedades"
        Private Property _BandaTipoID() As Integer
            Get
                Return Me.cbbBandaTipo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbBandaTipo.SelectedValue = value
            End Set
        End Property

        Private Property _BandaNombre() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaID() As Integer
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

        Private Sub GrillaCount(ByVal Rows As Integer)
            Me.lblReg.Text = Rows.ToString & " Reg."
        End Sub

        Private ReadOnly Property _GrillaRegionId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property _GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property _GrillaRegionNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_nom_reg").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property

        Private ReadOnly Property _GrillaPenalNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_nom_pen").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub Combo()
            With Me.cbbBandaTipo
                ._Todos = True
                .LoadUsc()
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()

            objBss = New Bussines.Registro.Banda
            objEntCol = New Entity.Registro.BandaCol
            objEntBand = New Entity.Registro.Banda
            objEntBand.BandaTipoID = Me._BandaTipoID
            objEntBand.BandaNombre = Me._BandaNombre
            objEntCol = objBss.Listar(objEntBand)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                GrillaCount(.RowCount())
            End With
        End Sub
#End Region
#Region "Accion"


        Private Sub AEliminar()
            If dgwGrilla.Rows.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "Debe buscar y seleccionar el registro para completar la operación solicitada")
                Exit Sub
            End If
            If MsgBox("Está seguro de eliminar el registro seleccionado?, una vez eliminada el registro no podrá recuperarla.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                objBss = New Bussines.Registro.Banda
                objBss.Eliminar(Me.GrillaID)
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Listar()
            End If
        End Sub
#End Region
#Region "Form"
        Private Sub FRM_MantBanda(ByVal Nuevo As Boolean)

            Dim frm As New Mantenimiento.Banda.frmMantBandaPopup
            frm._FormEscritura = Me._FormEscritura
            If Nuevo = True Then
                With frm
                    .Codigo = -1
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        Listar()
                    End If
                End With
            Else
                If dgwGrilla.Rows.Count < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                    "Debe buscar y seleccionar el registro para su edición")
                    Exit Sub
                End If
                With frm
                    .Codigo = Me.GrillaID
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        Listar()
                    End If
                End With
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            Combo()
        End Sub
        Private Sub UsuarioPermisos()
            Me.pnlEditar.Visible = Me._FormEscritura
            Me.pnlReporte.Visible = Me._FormReporte
            Me.pnlEliminar.Visible = Me._FormEliminar
        End Sub
#End Region

        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            ValoresxDefault()
            UsuarioPermisos()
            Me.WindowState = FormWindowState.Maximized
        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
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
                Me.dgwGrilla.Cursor = Cursors.Default
            End Try
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            FRM_MantBanda(False)
        End Sub

        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown
            If e.KeyCode = Keys.Delete And Me._FormEliminar Then
                AEliminar()
            End If
        End Sub

        Private Sub txtNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                Listar()
                If dgwGrilla.Rows.Count > 0 Then dgwGrilla.Select()
            End If
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
            AEliminar()
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
            FRM_MantBanda(True)
        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
            FRM_MantBanda(False)
        End Sub

        Public Sub New()
            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            Listar()
        End Sub
    End Class
End Namespace
