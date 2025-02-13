Imports Bussines
Imports Bussines.Mantenimiento.General
Imports Bussines.Registro
Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Mantenimiento.General
Imports Entity.Registro
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Public Class frmSelectAleroPopup
    Public _frmLectura As Boolean = False
    Public _frmEscritura As Boolean = False
    Public _frmReporte As Boolean = False
    Public _frmEliminar As Boolean = False

    Public _PabellonId As Integer = -1
    Public _PabellonNombre As String = ""

    Public _PisoNom As String = ""
    Public _PisoId As Integer = -1
    Public _AleroNom As String = ""
    Public _AleroId As Integer = -1

    Private Sub btnGrabarClasificacion_Click(sender As Object, e As EventArgs)
        'artificio modificado 10/11/2023
    End Sub

    Private Sub frmSelectAmbientePopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ent As New Alero_BE
        ent.PabellonId = _PabellonId

        Dim ls As List(Of Alero_BE) = (New Alero_BL()).ListarGrilla(ent)

        With Me.dgvFichaVariables
            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False
            .DataSource = ls
        End With
        Label2.Text = Me._PabellonNombre
    End Sub

    Private Sub dgvFichaVariables_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFichaVariables.CellClick
        If e.RowIndex = -1 Then Exit Sub

        If dgvFichaVariables.Columns(e.ColumnIndex).Name = "col_sel" Then

            Me._PisoNom = dgvFichaVariables.Item("col_piso_nom", e.RowIndex).Value
            Me._PisoId = dgvFichaVariables.Item("col_piso_id", e.RowIndex).Value
            Me._AleroNom = dgvFichaVariables.Item("col_alero_nom", e.RowIndex).Value
            Me._AleroId = dgvFichaVariables.Item("col_aleroId", e.RowIndex).Value

            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
