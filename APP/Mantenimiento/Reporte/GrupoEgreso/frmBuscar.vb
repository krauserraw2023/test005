Namespace Mantenimiento.Reporte.GrupoEgreso
    Public Class frmBuscar
        Private objBss As Bussines.Mantenimiento.Registro.PadinCuadro13 = Nothing
        Private objEntCol As Entity.Mantenimiento.Registro.PadinCuadro13Col = Nothing
#Region "Propiedades"
        Private Property Nombre() As String
            Get
                Return Me.txtNombre.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
        Private Property NombreDetalle() As String
            Get
                Return Me.txtNombreDet.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombreDet.Text = value
            End Set
        End Property
        Private Property Cuadro As Integer
            Get
                Dim value As Integer = Me.cbbCuadro.SelectedIndex

                If value < 1 Then
                    value = -1
                End If
                Return value
            End Get
            Set(value As Integer)
                Me.cbbCuadro.SelectedIndex = value
            End Set
        End Property

#End Region
#Region "Propiedades_Grilla"
        Private intNumeroReg As Integer = 0
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
        Private ReadOnly Property GrillaTipoEgreso() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_tip_egr").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaNombreTabla() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_nom_tbl").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaNombreDetalle() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_nom_det").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaVersionReporte() As Short
            Get
                Dim value As Short = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_ver_rpt").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private Sub GrillaCount(ByVal NumeroReg As Integer)

            Me.lblReg.Text = NumeroReg.ToString & " Reg."

        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()

            objBss = New Bussines.Mantenimiento.Registro.PadinCuadro13
            Dim objFiltro As New Entity.Mantenimiento.Registro.PadinCuadro13
            With objFiltro
                .Nombre = Me.Nombre
                .NombreDetalle = Me.NombreDetalle
                .Cuadro = Me.Cuadro
            End With

            objEntCol = objBss.Listar(objFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                GrillaCount(.RowCount)
            End With

        End Sub
#End Region
#Region "Combo"
        Private blnComboCargo As Boolean = False
        Private Sub ComboCuadro()

            With Me.cbbCuadro
                .Items.Add("[Todos]")
                .Items.Add("1")
                .Items.Add("2")
                .Items.Add("3")
                .SelectedIndex = 0
            End With
            blnComboCargo = True
        End Sub
#End Region
#Region "Accion"

        Private Sub AMantenimiento(ByVal Nuevo As Boolean)

            Try
                Dim frm As New Mantenimiento.Reporte.GrupoEgreso.frmMantDetPopup
                With frm
                    ._VersionReporte = GrillaVersionReporte
                    ._TipoEgreso = Me.GrillaTipoEgreso
                    ._NombreTabla = Me.GrillaNombreTabla
                    ._Nombre = Me.GrillaNombre
                    ._NombreDetalle = Me.GrillaNombreDetalle

                    If Nuevo = True Then
                        ._IDCuadro13 = -1
                    Else
                        ._IDCuadro13 = Me.GrillaCodigo
                    End If
                    .ShowDialog()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End Sub

        Private Sub fn_Migrar()

            Me.Nombre = ""
            Me.NombreDetalle = ""

            If Me.Cuadro < 1 Then
                MessageBox.Show("Seleccione un cuadro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Buscar()

            Dim objFiltro As New Entity.Mantenimiento.Registro.PadinCuadro13
            With objFiltro
                .Cuadro = Me.Cuadro
            End With

            objEntCol = objBss.Listar(objFiltro)
            objEntCol.Sort("Codigo")

            Dim objEntDet As New Entity.Mantenimiento.Registro.PadinCuadro13_Detalle
            Dim objBssDet As New Bussines.Mantenimiento.Registro.PadinCuadro13_Detalle
            Dim objBssMovMotivo As Bussines.Mantenimiento.Registro.Movimiento = Nothing

            Dim strMensajeOut As String = ""

            For Each objFila As Entity.Mantenimiento.Registro.PadinCuadro13 In objEntCol

                Dim strCodigoList As String()

                Select Case objFila.Cuadro
                    Case 1
                        strCodigoList = objFila.MovimientoMotivoCodigo01String.Split(",")
                    Case 2
                        strCodigoList = objFila.MovimientoMotivoCodigo02String.Split(",")
                End Select

                For Each str As String In strCodigoList

                    objEntDet = New Entity.Mantenimiento.Registro.PadinCuadro13_Detalle
                    objBssDet = New Bussines.Mantenimiento.Registro.PadinCuadro13_Detalle
                    objBssMovMotivo = New Bussines.Mantenimiento.Registro.Movimiento
                    With objEntDet
                        .IDCuadro13 = objFila.Codigo
                        .IDMovimientoMotivo = str
                        .MovimientoMotivoNombre = objBssMovMotivo.fn_ListarMotivoNombre(objFila.Cuadro, objFila.TipoEgresoNombre, str)
                        objBssDet.Grabar(objEntDet, strMensajeOut)
                    End With
                Next
            Next

            MessageBox.Show("Operacion ok", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            ComboCuadro()
        End Sub
#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            If Me.GrillaCodigo > 0 Then
                AMantenimiento(False)
            End If

        End Sub

        Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized

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
                AMantenimiento(False)
            End If

        End Sub

        Private Sub txtDelGene_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtNombre.KeyPress,
        txtNombreDet.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(dgwGrilla)

        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_nom_det").Index

                        If (e.Value).ToString.ToUpper = "Otrosv".ToUpper Then
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub cbbCuadro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCuadro.SelectedIndexChanged

            If blnComboCargo = True Then
                Buscar()
            End If

        End Sub

        Private Sub btnMigrar_Click(sender As Object, e As EventArgs) Handles btnMigrar.Click

            fn_Migrar()

        End Sub
    End Class
End Namespace
