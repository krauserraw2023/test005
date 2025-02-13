Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion
    Public Class uscGradosAcademicos
#Region "Propiedades"
        Public Property _InternoId As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property _IngresoId As Integer = -1
        Public Property _IngresoNroLetra As String = ""
        Public Property _PenalId As Integer = -1
        Public Property _RegionId As Integer = -1
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGradoInst
                    intValue = .SelectedRows(0).Cells("col_codigo").Value
                End With
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgwGradoInst
                    intValue = .SelectedRows(0).Cells("col_pen_id").Value
                End With
                Return intValue
            End Get
        End Property

#End Region
#Region "Propiedades_UserControl"
        Private blnVisibleGrabar As Boolean = False
        Private blnVisibleEliminar As Boolean = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
                VisibleControles()
            End Set
        End Property
        Public Property _VisibleEliminar() As Boolean
            Get
                Return blnVisibleEliminar
            End Get
            Set(value As Boolean)
                blnVisibleEliminar = value
                VisibleControles()
            End Set
        End Property
#End Region
#Region "Listar"

        Public Sub _LoadUsc()
            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana
                    col_num_ing.Visible = False
                Case enmTipoLicencia.PenalLimaMetropolitana
                    col_ing_nro_inpe.Visible = True
                    col_num_ing.Visible = False
                Case Else
                    col_ing_nro_inpe.Visible = False
                    col_num_ing.Visible = True
            End Select

            Listar()
        End Sub

        Private Sub Listar()
            If Not (Me.TipoLicencia = enmTipoLicencia.Carceleta _
               Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
               Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then
                If Me._IngresoId <= 0 Then Exit Sub
            End If

            Dim entCol As Entity.Registro.InternoGradoInstruccionCol
            Dim ent As New Entity.Registro.InternoGradoInstruccion
            ent.InternoId = Me._InternoId
            ent.IngresoInpeId = Me._IngresoInpeID
            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta
                    entCol = (New Bussines.Registro.InternoGradoInstruccion).Listar_Grilla_LM(ent, Me.TipoLicencia)
                Case enmTipoLicencia.RegionLimaMetropolitana
                    entCol = (New Bussines.Registro.InternoGradoInstruccion).Listar_Grilla_LM(ent, Me.TipoLicencia)
                Case enmTipoLicencia.PenalLimaMetropolitana
                    'ent.PenalId = Me._PenalId
                    entCol = (New Bussines.Registro.InternoGradoInstruccion).Listar_Grilla_LM(ent, Me.TipoLicencia)
                Case Else
                    ent.IngresoInpeId = -1
                    ent.IngresoId = Me._IngresoId
                    entCol = (New Bussines.Registro.InternoGradoInstruccion).Listar_Grilla(ent)
            End Select

            With dgwGradoInst
                .AutoGenerateColumns = False
                .DataSource = entCol
            End With
        End Sub
#End Region
#Region "Accion"
        Private Sub AgregarGradoIns()

            If Me._InternoId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If
            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._IngresoInpeID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                    Exit Sub
                End If
            Else
                If Me._IngresoId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                    Exit Sub
                End If
            End If


            Dim f As New Registro.Identificacion.frmInternoGradoInsPopup
            f._IngresoId = Me._IngresoId
            f._InternoIngresoInpeId = Me._IngresoInpeID
            f._penalId = Me._PenalId
            f._RegionId = Me._RegionId
            f._IngresoNroLetra = Me._IngresoNroLetra
            f._InternoId = Me._InternoId
            f.TipoLicencia = Me.TipoLicencia
            'permisos
            f._FormEscritura = Me._VisibleGrabar
            f._FormEliminar = Me._VisibleEliminar
            If f.ShowDialog = DialogResult.OK Then
                Listar()
            End If
        End Sub

        Private Sub FormModificaGradoAcademico()
            If Me.dgwGradoInst.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            Else
                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaPenalId <> Me._PenalId Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If

                Dim f As New Registro.Identificacion.frmInternoGradoInsPopup
                f._Codigo = Me.GrillaCodigo
                f._IngresoNroLetra = Me._IngresoNroLetra
                If regForzarSoloLectura = True Then
                    f._FormEscritura = False
                Else
                    f._FormEscritura = Me._VisibleGrabar
                End If
                f.TipoLicencia = Me.TipoLicencia
                If f.ShowDialog = DialogResult.OK Then
                    Listar()
                End If
            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub VisibleControles()

            Me.pnlGradAcadMant.Visible = Me._VisibleGrabar
            Me.pnlGradAcadDel.Visible = Me._VisibleEliminar

            If Me._VisibleGrabar = False And Me._VisibleEliminar = False Then
                Me.pnlBotones.Visible = False
            Else
                Me.pnlBotones.Visible = True
            End If

        End Sub
#End Region

        Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
            AgregarGradoIns()
        End Sub

        Private Sub dgwGradoInst_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGradoInst.CellDoubleClick
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            FormModificaGradoAcademico()
        End Sub


        Private Sub dgwGradoInst_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGradoInst.CellMouseEnter
            If (dgwGradoInst.Columns(e.ColumnIndex).Name = "col_edit" Or dgwGradoInst.Columns(e.ColumnIndex).Name = "col_del") And e.RowIndex >= 0 Then dgwGradoInst.Cursor = Cursors.Hand
        End Sub

        Private Sub dgwGradoInst_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGradoInst.CellMouseLeave
            If dgwGradoInst.Columns(e.ColumnIndex).Name = "col_edit" And e.RowIndex >= 0 Then dgwGradoInst.Cursor = Cursors.Default
            If dgwGradoInst.Columns(e.ColumnIndex).Name = "col_del" And e.RowIndex >= 0 Then dgwGradoInst.Cursor = Cursors.Default
        End Sub

        Private Sub btnModGradAca_Click(sender As System.Object, e As System.EventArgs) Handles btnModGradAca.Click
            FormModificaGradoAcademico()
        End Sub

        Private Sub btnEliminarGradAcad_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarGradAcad.Click

            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If

            If Me.dgwGradoInst.RowCount = 0 OrElse dgwGradoInst.CurrentRow.Index = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
            Else
                If Me.GrillaPenalId <> Me._PenalId Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede eliminar, el registro es de solo lectura.")
                    Exit Sub
                End If

                If Legolas.Configuration.Aplication.MessageBox.Question("Esta seguro de eliminar el registro seleccionado?") = DialogResult.Yes Then
                    Dim bss As New Bussines.Registro.InternoGradoInstruccion
                    Dim id As Integer = -1
                    id = bss.Eliminar(Me.GrillaCodigo)
                    If id = -1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo eliminar el registro seleccionado, intente nuevamente.")
                        Exit Sub
                    End If
                    Listar()
                End If
            End If
        End Sub

        Private Sub dgwGradoInst_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwGradoInst.KeyDown
            Select Case e.KeyCode
                Case Keys.Delete
                    btnEliminarGradAcad_Click(sender, e)
            End Select
        End Sub
    End Class
End Namespace