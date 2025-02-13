Imports System.Web.Services.Description
Imports System.Web.UI.WebControls
Imports Bussines
Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Mantenimiento.General
Imports Entity.Registro
Imports Legolas.APPUIComponents

Namespace Tratamiento.Asistencia.Clasificacion.Penal.Pabellon
    Public Class frmBuscar
        Private _frmLectura As Boolean = False
        Private _frmEscritura As Boolean = False
        Private _frmReporte As Boolean = False
        Private _frmImpresion As Boolean = False
        Private _frmEliminar As Boolean = False

        Private objBss As Bussines.Tratamiento.Asistencia.Clasificacion.Penal.Pabellon_BL = Nothing
        Private objEntCol As List(Of Pabellon_BE) = Nothing
        Private PabellonIdSel As Integer = -1
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim value As Integer = -1
                Try
                    value = Me.dgwGrillaPabellon.SelectedRows(0).Cells("col_id").Value
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaEstado() As Short
            Get
                Dim value As Integer = -1
                Try
                    value = Me.dgwGrillaPabellon.SelectedRows(0).Cells("col_est").Value
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Busqueda"
        Private Property IDRegion() As Integer
            Get
                Return Me.UsrRegionPenal1._RegionID
            End Get
            Set(value As Integer)
                Me.UsrRegionPenal1._RegionID = value
            End Set
        End Property
        Private Property IDPenal() As Integer
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

                If Me.rdbActivo.Checked = True Then value = 1
                If Me.rdbInactivo.Checked = True Then value = 0

                Return value

            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboRegionPenal()

            With Me.UsrRegionPenal1
                ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.Licencia
                ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()
            Dim objEntFiltro As New Pabellon_BE
            With objEntFiltro
                .IDRegion = Me.IDRegion
                .IDPenal = Me.IDPenal
                .Nombre = Me.Nombre
                .Estado = Me.Estado
            End With

            With Me.dgwGrillaPabellon
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = (New Pabellon_BL).ListarGrilla(objEntFiltro)

            End With

            CargarGrillaPiso()
        End Sub
#End Region
#Region "Accion"
        Private Sub AAnular()

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea anular el registro") = Windows.Forms.DialogResult.Yes Then

                If Me.GrillaEstado = 0 Then ' anulado
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "El registro actual no se puede anular, porque ya se encuentra anulado")
                    Exit Sub
                End If

                Dim intEstadoAnulado As Short = 0 'anulado
                Dim strMenajeOut As String = ""

                If (New Pabellon_BL).GrabarEstado(Me.GrillaCodigo, intEstadoAnulado, strMenajeOut) > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Buscar()
                End If

            End If

        End Sub
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar() = Windows.Forms.DialogResult.Yes Then
                Dim strMensajeOut As String = ""

                If (New Pabellon_BL).Eliminar(Me.GrillaCodigo, strMensajeOut) > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Buscar()
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                End If

            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_SeleccionarPenal()
            FRM_Mantenimiento(True)
        End Sub

        Private Sub FRM_Mantenimiento(blnNuevo As Boolean)

            Dim frm As New Tratamiento.Asistencia.Clasificacion.Penal.Pabellon.frmMantPopup
            With frm
                If blnNuevo = True Then
                    ._Codigo = -1
                Else
                    ._Codigo = Me.GrillaCodigo
                End If
                'permisos
                frm._frmLectura = Me._frmLectura
                frm._frmEscritura = Me._frmEscritura
                frm._frmReporte = Me._frmReporte
                frm._frmImpresion = Me._frmImpresion
                frm._frmEliminar = Me._frmEliminar

                .ShowDialog()

                If .accionEjecutada = DialogResult.OK Then
                    Buscar()
                End If

            End With
        End Sub
#End Region
#Region "Otros"

        Private Sub ValoresxDefault()
            ComboRegionPenal()
        End Sub
#End Region
        'artificio modificado 10/11/2023
        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            FRM_SeleccionarPenal()
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaPabellon.CellDoubleClick
            FRM_Mantenimiento(False)
        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
            FRM_Mantenimiento(False)
        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs)
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrillaPabellon)
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
            Buscar()

            UsuarioPermisos()

        End Sub

        Private Sub txtNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            If e.KeyChar = Chr(Keys.Enter) Then Buscar()
        End Sub

        Private Sub rdbActivo_Click(sender As Object, e As System.EventArgs) Handles _
            rdbActivo.Click,
            rdbInactivo.Click,
            rdbTodos.Click

            Buscar()

        End Sub
        Private Sub MantPiso(id As Integer)
            If Me.IDPenal < 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Seleccione el penal por favor.")
                Exit Sub
            End If
            Dim f As New Mantenimiento.Pabellon.frmMantPisoPopup

            f.Codigo = id
            f.NomPabellon = lblPabNomSel.Text
            f.PabellonId = Me.PabellonIdSel
            f.RegionId = Me.IDRegion
            f.PenalId = Me.IDPenal

            f._frmLectura = Me._frmLectura
            f._frmEscritura = Me._frmEscritura
            f._frmReporte = Me._frmReporte
            f._frmImpresion = Me._frmImpresion
            f._frmEliminar = Me._frmEliminar

            If f.ShowDialog = DialogResult.OK Then CargarGrillaPiso()

        End Sub
        Private Sub Mant_alero(id As Integer)
            If Me.IDPenal < 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Seleccione el penal por favor.")
                Exit Sub
            End If
            Dim f As New Mantenimiento.Pabellon.frmMantAleroPopup
            f.RegionId = Me.IDRegion
            f.PenalId = Me.IDPenal
            f.Codigo = id
            f.NomPabellon = lblPabNomSel.Text
            f.NomPiso = Me.dgwPiso.Item("col_nom", dgwPiso.CurrentRow.Index).Value
            f.PisoId = Me.dgwPiso.Item("col_codigo", dgwPiso.CurrentRow.Index).Value

            f._frmLectura = Me._frmLectura
            f._frmEscritura = Me._frmEscritura
            f._frmReporte = Me._frmReporte
            f._frmImpresion = Me._frmImpresion
            f._frmEliminar = Me._frmEliminar
            If f.ShowDialog = DialogResult.OK Then
                CargarGrillaAlero()
            End If

        End Sub

        Private Sub btnAddPiso_Click(sender As Object, e As EventArgs) Handles btnAddPiso.Click
            MantPiso(-1)
        End Sub

        Private Sub btnEditPiso_Click(sender As Object, e As EventArgs) Handles btnEditPiso.Click
            MantPiso(Me.dgwPiso.Item("col_codigo", dgwPiso.CurrentRow.Index).Value)
        End Sub

        Private Sub CargarGrillaPiso()
            If dgwGrillaPabellon.Rows.Count = 0 Then
                lblPabNomSel.Text = ""
                PabellonIdSel = -1
                dgwPiso.DataSource = Nothing
                Exit Sub
            End If

            lblPabNomSel.Text = Me.dgwGrillaPabellon.Item("col_esp_nom", dgwGrillaPabellon.CurrentRow.Index).Value
            Me.PabellonIdSel = Me.dgwGrillaPabellon.Item("col_id", dgwGrillaPabellon.CurrentRow.Index).Value
            Dim id As Integer = Me.dgwGrillaPabellon.Item("col_id", dgwGrillaPabellon.CurrentRow.Index).Value

            With Me.dgwPiso
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = (New Piso_BL).Listar(New Piso_BE() With {.PabellonId = id})
            End With
            CargarGrillaAlero()
        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaPabellon.CellClick
            CargarGrillaPiso()
        End Sub

        Private Sub CargarGrillaAlero()
            If dgwPiso.Rows.Count = 0 Then
                dgwAlero.DataSource = Nothing
                lblPisoSel.Text = ""
                Exit Sub
            End If

            Dim id As Integer = Me.dgwPiso.Item("col_codigo", dgwPiso.CurrentRow.Index).Value
            lblPisoSel.Text = Me.dgwPiso.Item("col_nom", dgwPiso.CurrentRow.Index).Value
            With Me.dgwAlero
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = (New Alero_BL).Listar(New Alero_BE() With {.PisoId = id})
            End With
        End Sub

        Private Sub btnAddAlero_Click(sender As Object, e As EventArgs) Handles btnAddAlero.Click
            Mant_alero(-1)
        End Sub

        Private Sub btnEditAlero_Click(sender As Object, e As EventArgs) Handles btnEditAlero.Click
            Mant_alero(Me.dgwAlero.Item("col_codigo_ale", dgwAlero.CurrentRow.Index).Value)
        End Sub

        Private Sub dgwPiso_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwPiso.CellClick
            CargarGrillaAlero()
        End Sub

        Private Sub btnEliminarPiso_Click(sender As Object, e As EventArgs) Handles btnEliminarPiso.Click
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar() = Windows.Forms.DialogResult.Yes Then
                If (New Piso_BL).Eliminar(Me.dgwPiso.Item("col_codigo", dgwPiso.CurrentRow.Index).Value) > 0 Then
                    CargarGrillaPiso()
                    Legolas.Configuration.Aplication.MessageBox.Information("Registro eliminado satisfactoriamente.")
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo eliminar el registro, intentelo nuevamente por favor.")
                End If
            End If
        End Sub

        Private Sub UsuarioPermisos()

            Dim objEntUsuarioModuloCol As Legolas.LEntity.Seguridad.UsuarioModuloCol = (New Legolas.LBusiness.Seguridad.UsuarioModulo).Listar(Legolas.Configuration.Usuario.Codigo, -1, ModuloID)

            If objEntUsuarioModuloCol IsNot Nothing AndAlso objEntUsuarioModuloCol.Count = 1 Then

                Me._frmLectura = objEntUsuarioModuloCol.Item(0).Lectura
                Me._frmEscritura = objEntUsuarioModuloCol.Item(0).Escritura
                Me._frmReporte = objEntUsuarioModuloCol.Item(0).Reporte
                Me._frmImpresion = objEntUsuarioModuloCol.Item(0).Impresion
                Me._frmEliminar = objEntUsuarioModuloCol.Item(0).Eliminar

            End If

            btnNuevo.Visible = Me._frmEscritura
            btnAnular.Visible = Me._frmEscritura
            btnModificar.Visible = IIf(Me._frmEscritura Or Me._frmLectura, True, False)
            btnEliminar.Visible = Me._frmEliminar

            btnAddPiso.Visible = Me._frmEscritura
            btnEditPiso.Visible = IIf(Me._frmEscritura Or Me._frmLectura, True, False)
            btnEliminarPiso.Visible = Me._frmEliminar

            btnAddAlero.Visible = Me._frmEscritura
            btnEditAlero.Visible = IIf(Me._frmEscritura Or Me._frmLectura, True, False)
            btnEliminarAlero.Visible = Me._frmEliminar
        End Sub

        Private Sub btnEliminarAlero_Click(sender As Object, e As EventArgs) Handles btnEliminarAlero.Click
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar() = Windows.Forms.DialogResult.Yes Then
                If (New Alero_BL).Eliminar(Me.dgwAlero.Item("col_codigo_ale", dgwAlero.CurrentRow.Index).Value) > 0 Then
                    CargarGrillaAlero()
                    Legolas.Configuration.Aplication.MessageBox.Information("Registro eliminado satisfactoriamente.")
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo eliminar el registro, intentelo nuevamente por favor.")
                End If
            End If
        End Sub

    End Class

End Namespace
