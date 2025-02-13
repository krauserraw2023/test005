Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion
    Public Class uscIdiomaInterno
        Private ListaIdioma As Entity.Registro.InternoIdiomaCol
#Region "Propiedades"
        Public Property _InternoId As Integer = -1
        Public Property _IngresoId As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property _IngresoNroLetra As String = ""
        Public Property _RegionId As Integer = -1
        Public Property _PenalId As Integer = -1
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region

        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgvIdiomas
                    intValue = .SelectedRows(0).Cells("col_id").Value
                End With
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgvIdiomas
                    intValue = .SelectedRows(0).Cells("col_pen_id").Value
                End With
                Return intValue
            End Get
        End Property

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
                    col_nro_ing.Visible = False
                Case enmTipoLicencia.PenalLimaMetropolitana
                    col_ing_nro_inpe.Visible = True
                    col_nro_ing.Visible = False
                Case Else
                    col_ing_nro_inpe.Visible = False
                    col_nro_ing.Visible = True
            End Select

            Listar()
        End Sub

        Private Sub Listar()
             If Not (Me.TipoLicencia = enmTipoLicencia.Carceleta _
              Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
              Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then
                If Me._IngresoId <= 0 Then Exit Sub
            End If

            Dim entCol As Entity.Registro.InternoIdiomaCol
            Dim ent As New Entity.Registro.InternoIdioma
            ent.InternoId = Me._InternoId
            ent.IngresoInpeId = Me._IngresoInpeID
            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta
                    'ent.PenalId = Me._PenalId
                    entCol = (New Bussines.Registro.InternoIdioma).Listar_Grilla_LM(ent, Me.TipoLicencia)
                Case enmTipoLicencia.RegionLimaMetropolitana
                    entCol = (New Bussines.Registro.InternoIdioma).Listar_Grilla_LM(ent, Me.TipoLicencia)
                Case enmTipoLicencia.PenalLimaMetropolitana
                    entCol = (New Bussines.Registro.InternoIdioma).Listar_Grilla_LM(ent, Me.TipoLicencia)
                Case Else
                    ent.IngresoInpeId = -1
                    ent.IngresoId = Me._IngresoId
                    entCol = (New Bussines.Registro.InternoIdioma).Listar_Grilla(ent)
            End Select

            With dgvIdiomas
                .AutoGenerateColumns = False
                .DataSource = entCol
            End With
        End Sub
#End Region
#Region "Accion"
        Private Sub AgregarIdioma()

            If Me._InternoId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._IngresoInpeID <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                    Exit Sub
                End If
            Else
                If Me._IngresoId <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                    Exit Sub
                End If
            End If

            Dim f As New Registro.Identificacion.frmIdiomaInternoPopup

            f._IngresoId = Me._IngresoId
            f._InternoIngresoInpeId = Me._IngresoInpeID
            f._PenalId = Me._PenalId
            f._RegionId = Me._RegionId
            f._InternoId = Me._InternoId
            f._IngresoNroLetra = Me._IngresoNroLetra
            f.TipoLicencia = Me.TipoLicencia
            'permisos
            f._FormEscritura = Me._VisibleEliminar
            f._FormEliminar = Me._VisibleEliminar

            If f.ShowDialog = DialogResult.OK Then
                Listar()
            End If
        End Sub

        Private Sub FormModificarIdioma()
            If Me.dgvIdiomas.RowCount = 0 OrElse dgvIdiomas.CurrentRow.Index = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            Else
                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaPenalId <> Me._PenalId Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If

                Dim f As New Registro.Identificacion.frmIdiomaInternoPopup
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

            Me.pnlIdiomaMant.Visible = Me._VisibleGrabar
            Me.pnlIdiomaDel.Visible = Me._VisibleEliminar

            If Me._VisibleGrabar = False And Me._VisibleEliminar = False Then
                Me.pnlBotones.Visible = False
            Else
                Me.pnlBotones.Visible = True
            End If

        End Sub
#End Region

        Private Sub btnAgregarIdioma_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarIdioma.Click
            AgregarIdioma()
        End Sub

        Private Sub dgvIdiomas_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIdiomas.CellDoubleClick
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            FormModificarIdioma()
        End Sub

        Private Sub btnModRasgo_Click(sender As System.Object, e As System.EventArgs) Handles btnModRasgo.Click
            FormModificarIdioma()
        End Sub

        Private Sub btnEliminarRasgo_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarRasgo.Click

            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If

            If Me.dgvIdiomas.RowCount = 0 OrElse dgvIdiomas.CurrentRow.Index = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
            Else
                If Me.GrillaPenalId <> Me._PenalId Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede eliminar, el registro es de solo lectura.")
                    Exit Sub
                End If

                If Legolas.Configuration.Aplication.MessageBox.Question("Esta seguro de eliminar el registro seleccionado?") = DialogResult.Yes Then
                    Dim bss As New Bussines.Registro.InternoIdioma
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

        Private Sub dgvIdiomas_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvIdiomas.KeyDown
            Select Case e.KeyCode
                Case Keys.Delete
                    btnEliminarRasgo_Click(sender, e)
            End Select
        End Sub
    End Class
End Namespace