Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion
    Public Class uscDomicilio
#Region "Propiedades"
        Public Property _InternoId As Integer = -1
        Public Property _IngresoId As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property _IngresoNroLetra As String = String.Empty
        Public Property _RegionId As Integer = -1
        Public Property _PenalId As Integer = -1
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
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
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgvDomicilio
                    intValue = .SelectedRows(0).Cells("col_codigo").Value
                End With
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaPenalId() As Integer
            Get
                Dim intValue As Integer = -1
                With Me.dgvDomicilio
                    intValue = .SelectedRows(0).Cells("col_pen_id").Value
                End With
                Return intValue
            End Get
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
            Dim entCol As Entity.Registro.InternoDomicilioCol
            Dim ent As New Entity.Registro.InternoDomicilio

            If Not (Me.TipoLicencia = enmTipoLicencia.Carceleta _
                          Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                          Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then
                If Me._IngresoId <= 0 Then Exit Sub
            End If
            ent.IngresoInpeId = Me._IngresoInpeID
            ent.InternoId = Me._InternoId
            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta
                    entCol = (New Bussines.Registro.InternoDomicilio).Listar_grilla_LM(ent, Me.TipoLicencia)
                Case enmTipoLicencia.RegionLimaMetropolitana
                    entCol = (New Bussines.Registro.InternoDomicilio).Listar_grilla_LM(ent, Me.TipoLicencia)
                Case enmTipoLicencia.PenalLimaMetropolitana
                    'ent.PenalId = Me._PenalId
                    entCol = (New Bussines.Registro.InternoDomicilio).Listar_grilla_LM(ent, Me.TipoLicencia)
                Case Else
                    ent.IngresoInpeId = -1
                    ent.IngresoId = Me._IngresoId
                    entCol = (New Bussines.Registro.InternoDomicilio).Listar_grilla(ent)
            End Select

            With dgvDomicilio
                .AutoGenerateColumns = False
                .DataSource = entCol
            End With
        End Sub

#End Region
#Region "Accion"
        Private Sub AgregarDomicilio()

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


            Dim f As New Registro.Identificacion.frmDomicilioPopup
            f._IngresoId = Me._IngresoId
            f._InternoIngresoInpeId = Me._IngresoInpeID
            f._PenalId = Me._PenalId
            f._RegionId = Me._RegionId
            f._InternoId = Me._InternoId
            f._IngresoNroLetra = Me._IngresoNroLetra
            f.TipoLicencia = Me.TipoLicencia
            'permisos
            f._FormEscritura = Me._VisibleGrabar
            f._FormEliminar = Me._VisibleEliminar

            If f.ShowDialog = DialogResult.OK Then
                Listar()
            End If
        End Sub

        Private Sub ModificarDomicilio()
            If Me.dgvDomicilio.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
            Else

                Dim regForzarSoloLectura As Boolean = False

                If Me.GrillaPenalId <> Me._PenalId Then
                    regForzarSoloLectura = True
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro es de solo lectura (No es editable).")
                End If


                Dim f As New Registro.Identificacion.frmDomicilioPopup
                f._Codigo = Me.GrillaCodigo
                f._IngresoNroLetra = Me._IngresoNroLetra
                f.TipoLicencia = Me.TipoLicencia
                'permisos
                If regForzarSoloLectura = True Then
                    f._FormEscritura = False
                    f._FormEliminar = False
                Else
                    f._FormEscritura = Me._VisibleGrabar
                    f._FormEliminar = Me._VisibleEliminar
                End If

                If f.ShowDialog = DialogResult.OK Then
                    Listar()
                End If
            End If
        End Sub
#End Region

#Region "Otros"
        Private Sub VisibleControles()

            Me.pnlDomicilioMant.Visible = Me._VisibleGrabar
            Me.pnlDomicilioDel.Visible = Me._VisibleEliminar

            If Me._VisibleGrabar = False And Me._VisibleEliminar = False Then
                Me.pnlBotones.Visible = False
            Else
                Me.pnlBotones.Visible = True
            End If

        End Sub

#End Region

        Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
            AgregarDomicilio()
        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            If Me._VisibleEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El usuario no tiene permiso para realizar esta operacion")
                Exit Sub
            End If

            If Me.dgvDomicilio.RowCount = 0 OrElse dgvDomicilio.CurrentRow.Index = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a eliminar")
            Else
                If Me.GrillaPenalId <> Me._PenalId Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede eliminar, el registro es de solo lectura.")
                    Exit Sub
                End If

                If Legolas.Configuration.Aplication.MessageBox.Question("Esta seguro de eliminar el registro seleccionado?") = DialogResult.Yes Then
                    Dim bss As New Bussines.Registro.InternoDomicilio
                    Dim id As Integer = -1
                    id = bss.Eliminar(Me.GrillaCodigo)
                    If id = -1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo eliminar el registro seleccionado, intente nuevamente.")
                        Exit Sub
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Information("Registro eliminado satisfactoriamente.")
                    End If
                    Listar()
                End If
            End If
        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
            ModificarDomicilio()
        End Sub

        Private Sub dgvDomicilio_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDomicilio.CellDoubleClick
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub

            ModificarDomicilio()
        End Sub

        Private Sub dgvDomicilio_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvDomicilio.KeyDown
            Select Case e.KeyCode
                Case Keys.Delete
                    btnEliminar_Click(sender, e)
            End Select
        End Sub
    End Class
End Namespace