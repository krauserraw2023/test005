Namespace Visita.Etapa
    Public Class frmBuscar
        Private objBss As Bussines.Visita.InternoEtapa = Nothing
        Private objEntCol As Entity.Visita.InternoEtapaCol = Nothing
#Region "Propiedades_Grilla"
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
        Private ReadOnly Property GrillaRegionID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaRegion() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_reg_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaPenalID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaPenal() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_pen_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Busqueda"
        Private Property RegionID() As Integer
            Get
                Return Me.UsrRegionPenal1._RegionID
            End Get
            Set(ByVal value As Integer)
                Me.UsrRegionPenal1._RegionID = value
            End Set
        End Property
        Private Property PenalID() As Integer
            Get
                Return Me.UsrRegionPenal1._PenalID
            End Get
            Set(ByVal value As Integer)
                Me.UsrRegionPenal1._PenalID = value
            End Set
        End Property
        Private Property InternoApellidos() As String
            Get
                Return Me.txtInteApe.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtInteApe.Text = value
            End Set
        End Property
        Private Property InternoNombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private Property EtapaID() As Integer
            Get
                Return Me.cbbEtapa.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbEtapa.SelectedValue = value
            End Set
        End Property
        Private Property Estado() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbActivo.Checked = True Then
                    value = 1
                End If

                If Me.rdbInactivo.Checked = True Then
                    value = 0
                End If

                Return value

            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 0
                        Me.rdbInactivo.Checked = True
                    Case 1
                        Me.rdbActivo.Checked = True
                    Case Else
                        Me.rdbActivo.Checked = False
                        Me.rdbInactivo.Checked = False
                End Select
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub ComboRegionPenal()

            With Me.UsrRegionPenal1
                ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.LicenciaTieneSistemaVisita
                ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._LoadUsc()
            End With

        End Sub
        Private Sub ComboEtapa()

            With Me.cbbEtapa
                ._Todos = True
                ._LoadUsc(Type.Combo.ComboTipo.VIS_Etapa)
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub Visible_Columnas()

            Dim blnVisibleRegion As Boolean = True
            Dim blnVisiblePenal As Boolean = True

            If Me.RegionID > 0 Then
                blnVisibleRegion = False
            End If

            If Me.PenalID > 0 Then
                blnVisiblePenal = False
            End If

            'columnas            
            Me.col_fec_reg.Tag = "fecha"

            Me.col_reg_nom.Visible = blnVisibleRegion
            Me.col_pen_nom.Visible = blnVisiblePenal

        End Sub
        Private Sub Buscar()

            objBss = New Bussines.Visita.InternoEtapa
            objEntCol = New Entity.Visita.InternoEtapaCol

            Dim objEntFiltro As New Entity.Visita.InternoEtapa
            With objEntFiltro
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .InternoApellidos = Me.InternoApellidos
                .InternoNombres = Me.InternoNombres
                .EtapaID = Me.EtapaID
                .Estado = Me.Estado
            End With

            Visible_Columnas()

            objEntCol = objBss.Listar(objEntFiltro)

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor

                .DataSource = objEntCol

                Me.lblReg.Text = .RowCount & ". Reg"
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AEliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes _
                And dgwGrilla.RowCount > 0 Then

                objBss = New Bussines.Visita.InternoEtapa

                Dim intEstado As Integer = 0 'baja
                Dim intCodigo As Integer = -1

                intCodigo = objBss.GrabarEstado(Me.GrillaCodigo, intEstado)

                If intCodigo > 0 Then
                    Buscar()
                End If

            End If
        End Sub
#End Region
#Region "Form"
        Private Sub FRM_Mant(ByVal Nuevo As Boolean)

            Dim blnValue As Boolean = False
            Dim intCodigo As Integer = -1
            Dim intRegionID As Integer = -1
            Dim strRegion As String = ""
            Dim intPenalID As Integer = -1
            Dim strPenal As String = ""

            If Nuevo = True Then

                'region, penal
                Dim frm As New frmPenalPopup
                With frm
                    ._TipoCombo = frmPenalPopup.enumTipoCombo.Visitas
                    .BRegion = Me.RegionID
                    .BPenal = Me.PenalID

                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        intRegionID = .RegionID
                        strRegion = .RegionNombre
                        intPenalID = .PenalID
                        strPenal = .PenalNombre
                        blnValue = True
                    End If
                End With

                If intPenalID < 1 Then
                    Exit Sub
                End If

            Else
                'blnValue = True
                'intCodigo = Me.GrillaCodigo
                'intRegionID = Me.GrillaRegionID
                'strRegion = Me.GrillaRegion
                'intPenalID = Me.GrillaPenalID
                'strPenal = Me.GrillaPenal

                If intCodigo < 1 Then
                    Exit Sub
                End If

            End If

            If blnValue = True Then

                Dim frm As New Visita.Etapa.frmAddPopup

                With frm
                    '._CalendarioID = intCodigo                    
                    ._RegionID = intRegionID
                    ._RegionNombre = strRegion
                    ._PenalID = intPenalID
                    ._PenalNombre = strPenal
                    'permisos
                    ._FormLectura = Me._FormLectura
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar

                    If .ShowDialog() = vbOK Then
                        Buscar()
                    End If

                End With

            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permisos()

            Dim blnEscritura As Boolean = False

            Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                Case 1 'sede central
                    If Legolas.Configuration.Usuario.NivelUsuario = Type.Enumeracion.Usuario.EnumTipoUsuario.Nacional Then
                        If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                            blnEscritura = Me._FormEscritura
                        End If
                    End If
                Case Else 'otras licencias
                    blnEscritura = Me._FormEscritura
            End Select

            Me._FormEscritura = blnEscritura
            Me.pnlModificar.Visible = Me._FormEscritura
            Me.pnlExportar.Visible = Me._FormReporte

        End Sub
        Private Sub ValoresxDefault()

            Usuario_Permisos()
            ComboRegionPenal()
            ComboEtapa()

        End Sub
#End Region


        Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub
        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Buscar()

        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            FRM_Mant(True)

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then

                        Me.Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        Me.Cursor = Cursors.Default

                        .Refresh()

                    End If
                End With

            Catch ex As Exception

            End Try

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                FRM_Mant(False)
            End If

        End Sub

        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_reg").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If

                End Select
            End With


        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click


            Buscar()

        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            FRM_Mant(False)

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

            AEliminar()

        End Sub

        Private Sub txtInteApe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
            Handles txtInteApe.KeyDown, _
            txtNom.KeyDown

            If e.KeyCode = Keys.Enter Then
                Buscar()
            End If

        End Sub

        Private Sub rdbActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
            rdbActivo.Click, _
            rdbInactivo.Click, _
            rdbEstadoTodos.Click

            Buscar()

        End Sub

        Private Sub cbbEtapa__SelectedIndexChanged() Handles cbbEtapa._SelectedIndexChanged

            Buscar()

        End Sub

    End Class
End Namespace