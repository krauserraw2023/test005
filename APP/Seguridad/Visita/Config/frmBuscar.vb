Namespace Visita.Config
    Public Class frmBuscar
        Private objBss As Bussines.Visita.Config = Nothing
        Private objEntCol As Entity.Visita.ConfigCol = Nothing
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaEstado() As Short
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_est").Value
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
            Set(value As Integer)
                Me.UsrRegionPenal1._RegionID = value
            End Set
        End Property
        Private Property PenalID() As Integer
            Get
                Return Me.UsrRegionPenal1._PenalID
            End Get
            Set(value As Integer)
                Me.UsrRegionPenal1._PenalID = value
            End Set
        End Property
        Private ReadOnly Property Estado() As Short
            Get
                Dim value As Short = -1

                If Me.rdbActivo.Checked = True Then
                    value = 1
                End If

                If Me.rdbInactivo.Checked = True Then
                    value = 0
                End If

                Return value

            End Get
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
#End Region
#Region "Listar"
        Private Sub Buscar()

            objBss = New Bussines.Visita.Config

            Dim objEntFiltro As New Entity.Visita.Config
            With objEntFiltro
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID                
                .Estado = Me.Estado
            End With

            objEntCol = objBss.ListarGrilla(objEntFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.lblReg.Text = .RowCount & " Reg."
            End With

        End Sub
#End Region
#Region "Accion"

#End Region
#Region "Form"
        Private Sub FRM_SelectPenal()

            Dim blnOK As Boolean = False
            Dim intRegion As Short = -1
            Dim intPenal As Short = -1

            Dim frm As New frmPenalPopup
            With frm
                ._TipoCombo = frmPenalPopup.enumTipoCombo.Visitas
                .BRegion = Me.RegionID
                .BPenal = Me.PenalID

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    intRegion = .RegionID
                    intPenal = .PenalID
                    blnOK = True
                End If
            End With

            If blnOK = True Then
                FRM_Mantenimiento(True, intRegion, intPenal)
            End If

        End Sub
        Private Sub FRM_Mantenimiento(Nuevo As Boolean, RegionID As Short, PenalID As Short)

            Dim frm As New Config.frmMantPopup
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                Else
                    ._Codigo = Me.GrillaID
                End If
                ._FormEscritura = Me._FormEscritura
                ._RegionID = RegionID
                ._PenalID = PenalID

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Buscar()
                End If

            End With
        End Sub
#End Region
#Region "Otros"
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

        End Sub
#End Region

        Private Sub frmBuscar_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click

            FRM_SelectPenal()

        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then
                        .Cursor = Cursors.WaitCursor
                        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        .Refresh()
                        .Cursor = Cursors.Default
                    End If
                End With

            Catch ex As Exception

            End Try

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            FRM_Mantenimiento(False, -1, -1)

        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click

            FRM_Mantenimiento(False, -1, -1)

        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub

        Private Sub frmBuscar_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized

        End Sub
        Private Sub rdbActivo_Click(sender As Object, e As System.EventArgs) Handles _
           rdbActivo.Click, _
           rdbInactivo.Click, _
           rdbTodos.Click

            Buscar()

        End Sub

        Private Sub rdbActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbActivo.CheckedChanged

        End Sub

        Private Sub btnHabilitarHuella_Click(sender As System.Object, e As System.EventArgs) Handles btnHabilitarHuella.Click

            'validar el acceso del usuario, correponde a la licencia de la base de datos
            Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Dim objBssLicencia As New Bussines.Sistema.Instalacion
            intTipoLicencia = objBssLicencia.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            Select Case intTipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia, _
                    Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana

                    Dim frm As New Visita.Movimiento.frmServicioHuella
                    With frm
                        ._TipoServicio = Movimiento.frmServicioHuella.enmTipoServicio.Alta
                        .ShowDialog()
                    End With

                Case Else

                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Esta opcion solo esta habilitado para los Establecimientos Penitenciarios")

            End Select

        End Sub

        Private Sub btnDesactivarHuella_Click(sender As System.Object, e As System.EventArgs) Handles btnDesactivarHuella.Click

            'validar el acceso del usuario, correponde a la licencia de la base de datos
            Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Dim objBssLicencia As New Bussines.Sistema.Instalacion
            intTipoLicencia = objBssLicencia.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            Select Case intTipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia, _
                    Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana

                    Dim frm As New Visita.Movimiento.frmServicioHuella
                    With frm
                        ._TipoServicio = Movimiento.frmServicioHuella.enmTipoServicio.Baja
                        .ShowDialog()
                    End With

                Case Else

                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Esta opcion solo esta habilitado para los Establecimientos Penitenciarios")

            End Select

        End Sub
    End Class
End Namespace