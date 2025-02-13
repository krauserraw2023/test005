Namespace Mantenimiento.Clasificacion
    Public Class frmMantFicha
#Region "Propiedades"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    intValue = Me.dgvFicha.SelectedRows(0).Cells("col_codigo").Value
                Catch ex As Exception
                    'nada
                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()
            Dim entCol As Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol_BE

            entCol = (New Bussines.Clasificacion.MaestroFicha).Listar()
            dgvFicha.AutoGenerateColumns = False
            dgvFicha.DataSource = entCol
        End Sub
#End Region

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub frmMantFicha_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Me.WindowState = FormWindowState.Maximized
            Listar()
        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            Dim f As New Mantenimiento.Clasificacion.frmFichaPopup

            If f.ShowDialog = Windows.Forms.DialogResult.OK Then Listar()

        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
            Dim f As New Mantenimiento.Clasificacion.frmFichaPopup

            f._Codigo = Me.GrillaCodigo
            If f.ShowDialog = Windows.Forms.DialogResult.OK Then Listar()

        End Sub

        Private Sub dgvFicha_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFicha.CellDoubleClick
            If e.RowIndex = -1 Then Exit Sub

            btnModificar_Click(Nothing, Nothing)
        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
            Dim s As String = ""

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Confirma eliminar el registro seleccionado") = Windows.Forms.DialogResult.Yes Then
                If (New Bussines.Clasificacion.MaestroFicha).Eliminar(Me.GrillaCodigo, s) = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Error al eliminar, " & s)
                Else
                    Listar()
                End If
            End If
        End Sub

        Private Sub dgvFicha_RowPrePaint(sender As System.Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvFicha.RowPrePaint
            If dgvFicha.Item("col_est_nom", e.RowIndex).Value = "INACTIVO" Then dgvFicha.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkGray
        End Sub

        Private Sub cmdAnular_Click(sender As System.Object, e As System.EventArgs) Handles cmdAnular.Click
            If dgvFicha.Item("col_est_nom", dgvFicha.CurrentRow.Index).Value = "INACTIVO" Then
                Legolas.Configuration.Aplication.MessageBox.Information("La ficha ya se encuentra INACTIVO")
                Exit Sub
            End If

            Dim id As Integer = -1
            id = (New Bussines.Clasificacion.MaestroFicha).InactivarRegistro(Me.GrillaCodigo)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Error, no se pudo guardar el registro")
            Else
                Listar()
            End If
        End Sub
    End Class
End Namespace