Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.SubTipoDocJudicial
Imports Type.Enumeracion.Licencia
Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal

    Public Class frmGrillaPabellonPopup
        Private objEntFiltro As Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE = Nothing
        Private objEntLista As List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE) = Nothing
        Private objBss As PabellonRegimenEtapa_BL = Nothing
#Region "Propiedades_Publicas"
        Public Property _IDRegimen As Short = -1
        Public Property _IDEtapa As Short = -1
        Public Property _IDRegion As Short = -1
        Public Property _IDPenal As Short = -1
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaIDPabellon() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgvGrilla
                        value = .SelectedRows(0).Cells("col_pab_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaPabellonNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgvGrilla
                        value = .SelectedRows(0).Cells("col_pab_nom").Value
                    End With
                Catch ex As Exception

                End Try

                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Return"
        Public Property _getIDPabellon As Integer = -1
        Public Property _getPabellonNomre As String = ""
#End Region
#Region "Listar"
        Private Sub ListarGrilla()

            If Me._IDEtapa < 1 Then Exit Sub

            objEntFiltro = New Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE
            Dim objEntLista = New List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE)
            objBss = New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BL

            With objEntFiltro
                '.IDRegimen = Me._IDRegimen
                .IDEtapa = Me._IDEtapa
                .IDRegion = Me._IDRegion
                .IDPenal = Me._IDPenal
            End With

            objEntLista = objBss.ListarGrilla(objEntFiltro)

            With Me.dgvGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntLista
            End With

        End Sub
#End Region
        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        'Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        '    If Me.GrillaIDPabellon > 0 Then
        '        Me._getIDPabellon = Me.GrillaIDPabellon
        '        Me._getPabellonNomre = Me.GrillaPabellonNombre
        '        Me.DialogResult = DialogResult.OK
        '    End If

        'End Sub

        Private Sub frmGrillaPabellonPopup_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            ListarGrilla()

        End Sub

        Private Sub dgvGrilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrilla.CellClick
            If e.RowIndex = -1 Then Exit Sub

            If dgvGrilla.Columns(e.ColumnIndex).Name = "col_sel_btn" Then
                Me._getIDPabellon = dgvGrilla.Item("col_pab_id", e.RowIndex).Value
                Me._getPabellonNomre = dgvGrilla.Item("col_pab_nom", e.RowIndex).Value
                Me.DialogResult = DialogResult.OK
            End If
        End Sub

        Private Sub dgvGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrilla.CellContentClick

        End Sub


        ''Private Sub dgvGrilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrilla.CellDoubleClick

        ''    Me.Cursor = Cursors.WaitCursor

        ''    If Me.dgvGrilla.RowCount > 0 And e.RowIndex <> -1 Then
        ''        btnOk_Click(sender, e)
        ''    End If

        ''    Me.Cursor = Cursors.Default

        ''End Sub
    End Class
End Namespace


