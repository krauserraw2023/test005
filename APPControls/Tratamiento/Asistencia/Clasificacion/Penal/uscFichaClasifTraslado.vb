Imports System.Web.Services.Description
Imports APPControls.Tratamiento.Asistencia.Clasificacion.Penal
Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal
Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class uscFichaClasifTraslado
#Region "Propiedades_Publicas"
        Public Property _IDInterno As Integer = -1
        Public Property _InternoApeNom As String = ""
        Public Property _IDIngresoInpe As Integer = -1
        Public Property _IDIngreso As Integer = -1
        Public Property _InternoEstado As Short = -1
        Public Property _IDRegion As Short = -1
        Public Property _IDPenal As Short = -1
#End Region

        Public Property _uscEscritura As Boolean = False
        Public Property _uscLectura As Boolean = False
        Public Property _uscEliminar() As Boolean = False
        Public Property _uscReporte() As Boolean = False
        Public Property _uscPerfilUsuario As Type.Enumeracion.Usuario.EnumDependencia

#Region "validar"
        Private Function ValidarDatosInterno() As Boolean

            If Me._IDInterno = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para completar la acción, guardar los datos básicos del interno.")
                Return False
            End If

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe ningún Ingreso activo, ir a la etiqueta [N° Ingreso] y registrar.")
                Return False
            End If

            If Me._InternoEstado = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del interno se encuentra inactivo.")
                Return False
            End If

            Return True
        End Function
#End Region
#Region "listas"
        Public Sub _ListarUsc()
            MostrarControlesFicha()

            Dim ent As New InternoFichaOtro_BE With {
            .InternoId = Me._IDInterno,
            .IngresoId = Me._IDIngreso,
            .IngresoInpeId = Me._IDIngresoInpe,
            .TipoFichaId = 6'ficha por traslado
            }

            Dim ls As List(Of InternoFichaOtro_BE) = (New InternoFichaOtro_BL()).ListarGrilla(ent)

            With Me.dgvGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = ls
            End With

        End Sub
#End Region
#Region "otros"
        Private Sub MostrarControlesFicha()
            BtnEditar.Visible = IIf(Me._uscEscritura Or Me._uscLectura, True, False)
            btnNuevo.Visible = Me._uscEscritura
            btnReporte.Visible = Me._uscReporte


        End Sub
#End Region
#Region "Accion"

        Private Sub ANuevo(Codigo As Integer)

            If ValidarDatosInterno() = False Then Exit Sub

            Dim strMensaje As String = "Desea generar un nuevo registro de clasificación? "

            If Codigo <= 0 AndAlso Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) <> DialogResult.Yes Then
                Exit Sub
            End If

            Dim f As New frmMantFichClasifTrasladoPopup

            f._Codigo = Codigo
            f._InternoIngresoId = Me._IDIngreso
            f._PenId = Me._IDPenal
            f._RegId = Me._IDRegion
            f._InternoId = Me._IDInterno
            f._InternoIngresoInpeId = Me._IDIngresoInpe

            f._frmEscritura = Me._uscEscritura
            f._frmLectura = Me._uscLectura
            If f.ShowDialog = DialogResult.OK Then
                Me._ListarUsc()
            End If

        End Sub
        Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
            For i As Integer = 0 To dgvGrilla.Rows.Count - 1
                If dgvGrilla.Item("col_estado", i).Value = "PENDIENTE" Then
                    Legolas.Configuration.Aplication.MessageBox.Information("No es posible agregar registro mientras exista fichas pendientes de finalizar.")
                    Exit Sub
                End If
            Next

            ANuevo(-1)
        End Sub
        Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
            If dgvGrilla.Rows.Count <= 0 Then Exit Sub

            ANuevo(dgvGrilla.Item("col_id", dgvGrilla.CurrentRow.Index).Value)
        End Sub

        Public Event Reporte_Click(intIDInternoFichaFinal As Integer)


        Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
            If dgvGrilla.Rows.Count <= 0 Then Exit Sub

            If dgvGrilla.Item("col_estado", dgvGrilla.CurrentRow.Index).Value <> "FINALIZADO" Then
                Legolas.Configuration.Aplication.MessageBox.Information("El registro se encuentra pendiente de finalizar.")
                Exit Sub
            End If
            RaiseEvent Reporte_Click(dgvGrilla.Item("col_id", dgvGrilla.CurrentRow.Index).Value)

        End Sub

        Private Sub btnEditClasifOTT_Click(sender As Object, e As EventArgs) 
            If dgvGrilla.Rows.Count <= 0 Then Exit Sub

            If ValidarDatosInterno() = False Then Exit Sub

            Dim strMensaje As String = "Desea generar un nuevo registro de clasificación? "

            If dgvGrilla.Item("col_id", dgvGrilla.CurrentRow.Index).Value <= 0 AndAlso Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) <> DialogResult.Yes Then
                Exit Sub
            End If

            Dim f As New frmClasifUbicacionRegresion

            f._Codigo = dgvGrilla.Item("col_id", dgvGrilla.CurrentRow.Index).Value
            f._InternoIngresoId = Me._IDIngreso
            f._PenId = Me._IDPenal
            f._RegId = Me._IDRegion
            f._InternoId = Me._IDInterno
            f._InternoIngresoInpeId = Me._IDIngresoInpe

            f._frmEliminar = Me._uscEliminar
            f._frmEscritura = Me._uscEscritura
            f._frmLectura = Me._uscLectura
            f._frmReporte = Me._uscReporte

            If f.ShowDialog = DialogResult.OK Then
                Me._ListarUsc()
                Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria.")
            End If
            'col_est_ott
        End Sub


#End Region

    End Class

End Namespace
