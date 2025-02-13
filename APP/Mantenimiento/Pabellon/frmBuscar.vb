Namespace Mantenimiento.Pabellon
    Public Class frmBuscar
        Private objBss As Bussines.Mantenimiento.General.Pabellon = Nothing
        Private objEntCol As Entity.Mantenimiento.General.PabellonCol = Nothing
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaEstado() As Short
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_est").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Busqueda"
        Private Property RegionID() As Integer
            Get
                Return Me.UsrRegionPenal1._RegionID
            End Get
            Set(value As Integer)
                Me.UsrRegionPenal1._RegionID = value
            End Set
        End Property
        Private Property PenalID() As Integer
            Get
                Return Me.UsrRegionPenal1._PenalID
            End Get
            Set(value As Integer)
                Me.UsrRegionPenal1._PenalID = value
            End Set
        End Property
        Private Property Nombre() As String
            Get
                Return Me.txtNombre.Text.Trim
            End Get
            Set(value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
        Private ReadOnly Property Estado() As Short
            Get
                Dim value As Short = -1

                If Me.rdbActivo.Checked = True Then
                    value = 1
                End If

                If Me.rdbInactivo.Checked = True Then
                    value = 0
                End If

                Return value

            End Get            
        End Property
#End Region
#Region "Combo"
        Private Sub ComboRegionPenal()

            With Me.UsrRegionPenal1
                ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.LicenciaTieneSistemaVisita
                ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()

            objBss = New Bussines.Mantenimiento.General.Pabellon

            Dim objEntFiltro As New Entity.Mantenimiento.General.Pabellon
            With objEntFiltro
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .Nombre = Me.Nombre
                .Estado = Me.Estado
            End With

            objEntCol = objBss.Listar(objEntFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.lblReg.Text = .RowCount & " Reg."
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AAnular()

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea anular el registro") = Windows.Forms.DialogResult.Yes Then

                If Me.GrillaEstado = 0 Then ' anulado
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "El registro actual no se puede anular, porque ya se encuentra anulado")
                    Exit Sub
                End If

                Dim value As Integer = -1
                objBss = New Bussines.Mantenimiento.General.Pabellon

                Dim objEnt As New Entity.Mantenimiento.General.Pabellon
                objEnt.Codigo = Me.GrillaID

                value = objBss.GrabarEstado(objEnt)

                If value > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Buscar()
                End If

            End If

        End Sub
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar() = Windows.Forms.DialogResult.Yes Then

                Dim value As Integer = -1
                objBss = New Bussines.Mantenimiento.General.Pabellon

                Dim objEnt As New Entity.Mantenimiento.General.Pabellon
                objEnt.Codigo = Me.GrillaID

                value = objBss.Eliminar(objEnt)

                If value > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Buscar()
                End If

            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_SelectPenal()

            Dim blnOK As Boolean = False
            Dim intRegion As Short = -1
            Dim intPenal As Short = -1

            Dim frm As New frmPenalPopup
            With frm                
                .BRegion = Me.RegionID
                .BPenal = Me.PenalID

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    intRegion = .RegionID
                    intPenal = .PenalID
                    blnOK = True
                End If
            End With

            If blnOK = True Then
                FRM_Mantenimiento(True, intRegion, intPenal)
            End If

        End Sub
        Private Sub FRM_Mantenimiento(Nuevo As Boolean, RegionID As Short, PenalID As Short)

            Dim frm As New Mantenimiento.Pabellon.frmMantPopup
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                Else
                    ._Codigo = Me.GrillaID
                End If
                ._FormEscritura = Me._FormEscritura
                ._RegionID = RegionID
                ._PenalID = PenalID

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Buscar()
                End If

            End With
        End Sub
#End Region
#Region "Otros"
        Private Sub UsuarioPermisos()

            Me.pnlModificar.Visible = Me._FormEscritura
            Me.pnlEliminar.Visible = Me._FormEliminar
            Me.pnlExportar.Visible = Me._FormReporte

        End Sub
        Private Sub ValoresxDefault()
            ComboRegionPenal()
            UsuarioPermisos()
        End Sub
#End Region

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click

            FRM_SelectPenal()

        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

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

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            FRM_Mantenimiento(False, -1, -1)

        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click

            FRM_Mantenimiento(False, -1, -1)

        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            AEliminar()

        End Sub

        Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click

            AAnular()

        End Sub

        Private Sub frmBuscar_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmBuscar_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized

        End Sub

        Private Sub txtNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

            If e.KeyChar = Chr(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub rdbActivo_Click(sender As Object, e As System.EventArgs) Handles _
            rdbActivo.Click, _
            rdbInactivo.Click, _
            rdbTodos.Click

            Buscar()

        End Sub

    End Class
End Namespace
