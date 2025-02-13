Namespace Mantenimiento.Registro.Delito
    Public Class frmBuscar_v2
        Private objBss As Bussines.Mantenimiento.General.Delito = Nothing
        Private objEntCol As Entity.Mantenimiento.General.DelitoCol = Nothing
#Region "Propiedades"

        Private Property IDDelitoGenerico() As Integer
            Get
                Return Me.cbbDelitoGenerico.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbDelitoGenerico.SelectedValue = value
            End Set
        End Property
        Private Property Articulo() As String
            Get
                Return Me.txtArticulo.Text
            End Get
            Set(value As String)
                Me.txtArticulo.Text = value
            End Set
        End Property
        Private Property DelitoEspecificoNombre() As String
            Get
                Return Me.txtDelitoEspecifico.Text
            End Get
            Set(value As String)
                Me.txtDelitoEspecifico.Text = value
            End Set
        End Property

        Private Property DelitoEstado() As Integer
            Get
                Return Me.cbbEstado.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbEstado.SelectedValue = value
            End Set
        End Property
        Private Property GrupoGenericoNombre() As String
            Get
                Return Me.txtGrupoGenerico.Text
            End Get
            Set(value As String)
                Me.txtGrupoGenerico.Text = value
            End Set
        End Property
        Private Property GrupoEspecificoNombre() As String
            Get
                Return Me.txtGrupoEspecifico.Text
            End Get
            Set(value As String)
                Me.txtGrupoEspecifico.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"

        Public ReadOnly Property GrillaDelitoEspecificoID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_del_esp_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaDelitoEstado() As Short
            Get
                Dim value As Short = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_del_esp_est").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboDelitoGenerico()
            With Me.cbbDelitoGenerico
                ._Todos = True
                .Parametro1 = 1 'estado del delito
                .Parametro2 = -1 'todos los tipos de delito
                .LoadUsc()
            End With
            Me.IDDelitoGenerico = -1 'todos Me.DelitoGenericoID
        End Sub
        Private Sub ComboEstado()
            'estado

            objBss = New Bussines.Mantenimiento.General.Delito

            With Me.cbbEstado
                .DataSource = objBss.Combo_DelitoEspEstado(True)
                .DisplayMember = "Nombre"
                .ValueMember = "Codigo"
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()

            Dim objEntDelFiltro As New Entity.Mantenimiento.General.Delito

            With objEntDelFiltro
                .DelitoGenericoID = Me.IDDelitoGenerico
                .DelitoArticulo = Me.Articulo
                .DelitoEspecificoNombre = Me.DelitoEspecificoNombre
                .DelitoEspecificoEstado = Me.DelitoEstado
                .DelitoGrupoGenericoNombre = Me.GrupoGenericoNombre
                .DelitoGrupoEspecificoNombre = Me.GrupoEspecificoNombre
            End With

            objEntCol = New Entity.Mantenimiento.General.DelitoCol
            objBss = New Bussines.Mantenimiento.General.Delito

            objEntCol = objBss.Listar_Grilla_V2(objEntDelFiltro)

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .DataSource = objEntCol

                Me.lblReg.Text = .RowCount & " Reg."

            End With
        End Sub
#End Region
#Region "Accion"
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                Dim intValue As Integer = -1
                Dim strMensajeOut As String = ""

                objBss = New Bussines.Mantenimiento.General.Delito
                intValue = objBss.Eliminar(Me.GrillaDelitoEspecificoID, strMensajeOut)

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

        End Sub
        Private Sub AAnular()

            If Me.GrillaDelitoEstado < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro ya se encuentra anulado")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea Anular el registro seleccionado") = Windows.Forms.DialogResult.Yes Then

                Dim intValue As Integer = -1
                Dim strMensajeOut As String = ""

                objBss = New Bussines.Mantenimiento.General.Delito
                intValue = objBss.Anular(Me.GrillaDelitoEspecificoID)

                If intValue > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Buscar()
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("La operacion no se pudo completar correctamente. Intentelo nuevamente.")
                End If

            End If

        End Sub
        Private Sub ALimpiar()

            Me.IDDelitoGenerico = -1
            Me.Articulo = ""
            Me.DelitoEspecificoNombre = ""
            Me.DelitoEstado = -1
            Me.GrupoGenericoNombre = ""
            Me.GrupoEspecificoNombre = ""
            Me.txtArticulo.Focus()

        End Sub
#End Region
#Region "FRM"
        Private Sub FRM_Mant(blnNuevo As Boolean)

            Dim intCodigo As Integer = -1

            If blnNuevo = True Then
                intCodigo = -1
            Else
                intCodigo = Me.GrillaDelitoEspecificoID

                If intCodigo < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
                End If

            End If

            Dim frm As New Mantenimiento.Registro.Delito.frmMant_v2
            With frm
                ._Codigo = intCodigo
                'permisos           
                ._FormEscritura = Me._FormEscritura
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Buscar()
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub Inicio()

            ComboDelitoGenerico()
            ComboEstado()
            Me.txtArticulo.Focus()

        End Sub
        Private Sub UsuarioPermisos()

            Me.pnlModificar.Visible = Me._FormEscritura
            Me.pnlEliminar.Visible = Me._FormEliminar
            Me.pnlExportar.Visible = Me._FormReporte

        End Sub
#End Region
        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub


        Private Sub txtDelitoGenerico_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _
             txtArticulo.KeyPress,
            txtDelitoEspecifico.KeyPress,
            txtGrupoGenerico.KeyPress,
            txtGrupoEspecifico.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub frmBuscar_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            UsuarioPermisos()

        End Sub

        Private Sub frmBuscarDelitoPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Me.dgwGrilla.VisibleCampos = True
            Me.WindowState = FormWindowState.Maximized
            Inicio()

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

            FRM_Mant(False)

        End Sub


        Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click

            ALimpiar()

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            AEliminar()

        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click

            FRM_Mant(False)

        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click

            FRM_Mant(True)

        End Sub

        Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click

            AAnular()

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub btnAnular_DoubleClick(sender As Object, e As EventArgs) Handles btnAnular.DoubleClick

        End Sub

        Private Sub txtDelitoEspecifico_TextChanged(sender As Object, e As EventArgs) Handles txtDelitoEspecifico.TextChanged

        End Sub
    End Class
End Namespace
