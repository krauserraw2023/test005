Imports System.IO
Namespace Mantenimiento.Registro.Sala
    Public Class frmBuscar
        Private objBss As Bussines.Mantenimiento.SalaJuzgado = Nothing
        Private objEntCol As Entity.Mantenimiento.SalaJuzgadoCol = Nothing
#Region "Propiedades"
        Private Property DistritoJudicial() As Integer
            Get
                Return Me.cbbDistritoJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Private Property SalaNombre() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private Property SalaNombreCorto() As String
            Get
                Return Me.txtNomCorto.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNomCorto.Text = value
            End Set
        End Property
        Private ReadOnly Property Estado() As Short
            Get
                Dim value As Short = -1

                If Me.rbHistorico.Checked = True Then
                    value = 0
                End If

                If Me.rbVigente.Checked = True Then
                    value = 1
                End If

                If Me.rbInactivo.Checked = True Then
                    value = 100
                End If

                Return value

            End Get

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
#End Region
#Region "Combo"
        Private Sub Combo()

            With Me.cbbDistritoJud
                ._Todos = True
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()

            objBss = New Bussines.Mantenimiento.SalaJuzgado
            objEntCol = New Entity.Mantenimiento.SalaJuzgadoCol

            Dim objEntFiltro As New Entity.Mantenimiento.SalaJuzgado
            With objEntFiltro
                .DistritoJudID = Me.DistritoJudicial
                .Nombre = Me.SalaNombre
                .NombreCorto = Me.SalaNombreCorto
                .Estado = Me.Estado
            End With

            objEntCol = objBss.Listar(objEntFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Color.Black
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                GrillaCount(.RowCount())
            End With

        End Sub
#End Region
#Region "Accion"

        Private Sub FRM_MantSala(ByVal Nuevo As Boolean)

            Dim frm As New Mantenimiento.Registro.Sala.frmSalaPopup
            With frm

                If Nuevo = True Then
                    .Codigo = -1
                Else
                    .Codigo = Me.GrillaID
                End If
                'permisos
                ._FormEscritura = Me._FormEscritura
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Buscar()
                End If
            End With
        End Sub
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                Dim intValue As Integer = -1
                Dim strMensajeOut As String = ""
                objBss = New Bussines.Mantenimiento.SalaJuzgado

                intValue = objBss.Eliminar(Me.GrillaID, strMensajeOut)

                If intValue > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Buscar()
                Else
                    If strMensajeOut.Trim.Length > 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("La operacion no se pudo completar correctamente. Intentelo nuevamente.")
                    End If
                End If
            End If

            Me.Cursor = Cursors.Default

        End Sub
#End Region
#Region "Otros"
        Private Sub PermisosLicencia()

            Select Case Configuracion.Licencia.Codigo
                Case 1 'sede central

                Case Else
                    Me.pnlModificar.Visible = Me._FormEscritura
                    Me.pnlExportar.Visible = Me._FormReporte
                    Me.pnlEliminar.Visible = Me._FormEliminar
            End Select

        End Sub
        Private Sub ValoresxDefault()

            Combo()
            Me.WindowState = FormWindowState.Maximized

        End Sub
#End Region
        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub frmBuscar_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            PermisosLicencia()

        End Sub

        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ValoresxDefault()

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

            End Try

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 Then
                FRM_MantSala(False)
            End If

        End Sub

        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            If e.KeyCode = Keys.Delete Then
                AEliminar()
            End If

        End Sub

        Private Sub txtNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles _
        txtNom.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

            AEliminar()

        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            FRM_MantSala(True)

        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
            FRM_MantSala(False)
        End Sub

    End Class
End Namespace
