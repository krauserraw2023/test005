Namespace Visita.Programacion
    Public Class frmBuscar
        Private objBss As Bussines.Visita.Programacion.Calendario = Nothing
        Private objEntCol As Entity.Visita.Programacion.CalendarioCol = Nothing
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
        Private ReadOnly Property GrillaRegimenVisitaID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_reg_vis_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaRegimenVisitaNombre() As String
            Get
                Dim value As String = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_reg_vis_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaTipoVisitaID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_tip_vis").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaTipoVisitaNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_tip_vis_nom").Value
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
        Private Property TipoRegimen() As Integer
            Get
                Return Me.cbbTipoVisita.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoVisita.SelectedValue = value
            End Set
        End Property
        Private Property EstadoID() As Integer
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
        Private Sub ComboTipoVisita()

            With Me.cbbTipoVisita
                .Parametro1 = 1 'tipo 1 activado
                .Parametro2 = 1 'tipo 2, activado
                ._Todos = True
                ._LoadUsc(Type.Combo.ComboTipo.VIS_RegimenVisita)
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()

            objBss = New Bussines.Visita.Programacion.Calendario
            objEntCol = New Entity.Visita.Programacion.CalendarioCol

            Dim objEntFiltro As New Entity.Visita.Programacion.Calendario
            With objEntFiltro
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .RegimenVisitaID = Me.TipoRegimen
                .Estado = Me.EstadoID
            End With

            objEntCol = objBss.Listar(objEntFiltro)

            'columnas
            Me.col_fec_ini.Tag = "fecha"

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor

                .DataSource = objEntCol

                Me.lblReg.Text = .RowCount & ". Reg"
            End With

        End Sub
#End Region
#Region "Otros"
        Private Function ValidarTipoVisita(CalendarioID As Integer, RegionID As Short, PenalID As Short, _
                                      RegimenVisitaID As Short, VisitaTipoID As Short) As Boolean

            Dim value As Boolean = False
            objBss = New Bussines.Visita.Programacion.Calendario
            Dim objEntFiltro As New Entity.Visita.Programacion.Calendario

            With objEntFiltro
                .CalendarioID = CalendarioID
                .RegionID = RegionID
                .PenalID = PenalID
                .RegimenVisitaID = RegimenVisitaID
                .VisitaTipoID = VisitaTipoID
            End With

            value = objBss.ValidarCalendario(objEntFiltro)

            If value = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El tipo de visita que desea agregar ya existe")                
            End If

            Return value

        End Function
        Private Sub UsuarioPermisos()

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
            Me.pnlModificar.Visible = blnEscritura
            Me.pnlExportar.Visible = Me._FormReporte

        End Sub
        Private Sub ValoresxDefault()

            UsuarioPermisos()
            ComboRegionPenal()
            ComboTipoVisita()

            Me.RegionID = 3 'lima

        End Sub
#End Region
#Region "FRM"
        Private Sub FRM_Mant(ByVal Nuevo As Boolean)

            Dim blnValue As Boolean = False
            Dim intCalendarioID As Integer = -1
            Dim intRegionID As Integer = -1
            Dim strRegion As String = ""
            Dim intPenalID As Integer = -1
            Dim strPenal As String = ""

            Dim intRegimenVisitaID As Short = -1
            Dim strRegimenVisita As String = ""
            Dim intTipoVisita As Short = -1
            Dim strTipoVisita As String = ""

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

                'tipo visita
                Dim frm2 As New Visita.Programacion.frmTipoVisitaPopup
                With frm2
                    ._RegionID = intRegionID
                    ._PenalID = intPenalID
                    If .ShowDialog = vbOK Then                     
                        intRegimenVisitaID = ._TipoRegimenID
                        strRegimenVisita = ._RegimenVisitaNombre
                        intTipoVisita = ._TipoVisitaID
                        strTipoVisita = ._TipoVisitaNombre
                    End If
                End With

                If intTipoVisita < 1 Then
                    Exit Sub
                End If

            Else
                blnValue = True
                intCalendarioID = Me.GrillaCodigo
                intRegionID = Me.GrillaRegionID
                strRegion = Me.GrillaRegion
                intPenalID = Me.GrillaPenalID
                strPenal = Me.GrillaPenal

                intRegimenVisitaID = Me.GrillaRegimenVisitaID
                strRegimenVisita = Me.GrillaRegimenVisitaNombre
                intTipoVisita = Me.GrillaTipoVisitaID
                strTipoVisita = Me.GrillaTipoVisitaNombre

                If intCalendarioID < 1 Then
                    Exit Sub
                End If

            End If

            If blnValue = True Then

                If ValidarTipoVisita(intCalendarioID, intRegionID, intPenalID, _
                                     intRegimenVisitaID, intTipoVisita) = False Then
                    Exit Sub
                End If
                
                Dim frm As New Visita.Programacion.frmMantenimiento
                frm.MdiParent = Me.MdiParent

                With frm
                    ._CalendarioID = intCalendarioID
                    ._RegimenVisitaID = intRegimenVisitaID
                    ._RegimenVisitaNombre = strRegimenVisita
                    ._TipoVisitaID = intTipoVisita
                    ._TipoVisitaNombre = strTipoVisita
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
                    .Show()
                End With

            End If

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

                    Case .Columns("col_fec_ini").Index

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

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            FRM_Mant(False)

        End Sub

        Private Sub dgwGrilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub
    End Class
End Namespace