Namespace Visita.Visitante
    Public Class frmBuscar
        Private objBss As Bussines.Visita.Visitante = Nothing
        Private objEntCol As Entity.Visita.VisitanteCol = Nothing
        Private frmLoad As Load.frmLoad = Nothing
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaVisitaID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_vis_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaVisitaApeNom() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_ape_pat").Value & " " &
                            .SelectedRows(0).Cells("col_ape_mat").Value & " " &
                        .SelectedRows(0).Cells("col_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaFotoVisitante() As String
            Get
                Dim Value As String = ""
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_vis_fot").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
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
#Region "Propiedades_Buscar"
        Private Property RegionID() As Integer
            Get
                Return Me.UsrRegionPenal1._RegionID
            End Get
            Set(ByVal value As Integer)
                Me.UsrRegionPenal1._RegionID = value
            End Set
        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.UsrRegionPenal1._RegionNombre
            End Get

        End Property
        Private Property PenalID() As Integer
            Get
                Return Me.UsrRegionPenal1._PenalID
            End Get
            Set(ByVal value As Integer)
                Me.UsrRegionPenal1._PenalID = value
            End Set
        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.UsrRegionPenal1._PenalNombre
            End Get

        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtVisNumDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtVisNumDoc.Text = value
            End Set
        End Property
        Private Property ApellidoPaterno() As String
            Get
                Return Me.txtVisapepat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtVisapepat.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
            Get
                Return Me.txtVisapemat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtVisapemat.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtVisnom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtVisnom.Text = value
            End Set
        End Property
        Private Property Sexo() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbHom.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbMuj.Checked = True Then
                    intValue = 2
                End If

                If Me.rdbSexoTodos.Checked = True Then
                    intValue = -1
                End If

                Return intValue
            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 1
                        Me.rdbHom.Checked = True
                    Case 2
                        rdbMuj.Checked = True
                    Case Else
                        rdbSexoTodos.Checked = True
                End Select

            End Set

        End Property
        Private Property Nacionalidad() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbPeruano.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbExtranjero.Checked = True Then
                    intValue = 2
                End If

                If Me.rdbNacTodos.Checked = True Then
                    intValue = -1
                End If

                Return intValue
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 1
                        Me.rdbPeruano.Checked = True
                    Case 2
                        Me.rdbExtranjero.Checked = True
                    Case Else
                        Me.rdbNacTodos.Checked = True
                End Select
            End Set

        End Property
#End Region
#Region "Propiedades_Otros"
        Dim intNumeroReg As Integer = 0
        Private Property NumeroReg() As Integer
            Get
                Return intNumeroReg
            End Get
            Set(ByVal value As Integer)
                intNumeroReg = value
                ListarNumeroReg()
            End Set
        End Property
        Private Sub ListarNumeroReg()

            Dim strValue As String = ""
            lblReg.Text = Me.NumeroReg & " Reg."

        End Sub
#End Region
#Region "Listar"
        Private strLoadApePat As String = ""
        Private strLoadApeMat As String = ""
        Private strLoadNombres As String = ""
        Private strLoadNumDoc As String = ""
        Private intLoadNac As Integer = -1
        Private intLoadSexo As Integer = -1
        Private intLoadRegion As Integer = -1
        Private intLoadPenal As Integer = -1
        Private Sub LoadPropiedades()

            strLoadApePat = Me.ApellidoPaterno
            strLoadApeMat = Me.ApellidoMaterno
            strLoadNombres = Me.Nombres
            strLoadNumDoc = Me.NumeroDocumento
            intLoadNac = Me.Nacionalidad
            intLoadSexo = Me.Sexo
            intLoadRegion = Me.RegionID
            intLoadPenal = Me.PenalID

        End Sub
        Private Sub Buscar()

            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0

            LoadPropiedades()

            Me.SuspendLayout()
            Me.Timer1.Start()
            frmLoad = New Load.frmLoad
            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.Timer1.Stop()
                Me.BackgroundWorker1.CancelAsync()
                Me.BackgroundWorker1.Dispose()
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            Me.dgwGrilla.VisibleCampos = True

            If Me.PenalID < 1 Then
                Me.col_pen_nom.Visible = True
            End If

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.NumeroReg = .RowCount()
            End With

        End Sub
        Private Function Listar() As Boolean

            objBss = New Bussines.Visita.Visitante
            objEntCol = New Entity.Visita.VisitanteCol

            Dim objEntFiltro As New Entity.Visita.Visitante

            With objEntFiltro                
                .NumeroDocumento = Me.strLoadNumDoc
                .ApellidoPaterno = Me.strLoadApePat
                .ApellidoMaterno = Me.strLoadApeMat
                .Nombres = Me.strLoadNombres
                .NacionalidadID = Me.intLoadNac
                .SexoID = Me.intLoadSexo
                .RegionID = Me.intLoadRegion
                .PenalID = Me.intLoadPenal
            End With

            'objEntCol = objBss.Listar(-1, strLoadApePat, strLoadApeMat, Me.strLoadNombres, -1, _
            '                           Me.strLoadNumDoc, "", Me.intLoadNac, Me.intLoadSexo, _
            '                           Me.intLoadRegion, Me.intLoadPenal)

            objEntCol = objBss.ListarGrilla(objEntFiltro)

            Return True

        End Function
#End Region
#Region "Accion"
        Private Sub AEliminar()

            Dim intCodigo As Integer = Me.GrillaVisitaID
            If intCodigo > 0 Then

                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                    Dim intValue As Integer = -1
                    objBss = New Bussines.Visita.Visitante
                    intValue = objBss.Eliminar(intCodigo, Me.GrillaRegionID, Me.GrillaPenalID)

                    If intValue > 0 Then
                        Buscar()
                    End If

                End If

            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_Mant(ByVal Nuevo As Boolean)

            Dim intCodigo As Integer = -1

            Dim intRegionID As Short = -1
            Dim strRegion As String = ""
            Dim intPenalID As Short = -1
            Dim strPenal As String = ""

            If Nuevo = True Then

                If Me.RegionID < 1 Or Me.PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Debe seleccionar la Region y el Penal, para ingresar un nuevo visitante")
                    Exit Sub
                End If

                intRegionID = Me.RegionID
                strRegion = Me.RegionNombre
                intPenalID = Me.PenalID
                strPenal = Me.PenalNombre

            Else
                intCodigo = Me.GrillaVisitaID
                intRegionID = Me.GrillaRegionID
                strRegion = Me.RegionNombre
                intPenalID = Me.GrillaPenalID
                strPenal = Me.GrillaPenal
            End If

            Dim frm As New Visita.Visitante.frmMantenimiento
            With frm
                .MdiParent = Me.MdiParent
                ._Codigo = intCodigo
                ._RegionID = intRegionID
                ._PenalID = intPenalID
                ._RegionNombre = strRegion
                ._PenalNombre = strPenal
                'permisos
                ._FormLectura = Me._FormLectura
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormImpresion = Me._FormImpresion
                ._FormEliminar = Me._FormEliminar
                .Show()
            End With

        End Sub
        Private Sub FReporte()

            If Me.PenalID < 1 Then
                MessageBox.Show("Seleccione penal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim frm As New Visita.frmReportePopup
            With frm
                ._SelectIDRegion = Me.RegionID
                ._SelectIDPenal = Me.PenalID
                ._VisitanteID = Me.GrillaVisitaID
                ._VisitanteApeNom = Me.GrillaVisitaApeNom
                ._TipoSancion = Type.Enumeracion.Visita.Sancion.Visitante
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Otros"
        Public Sub ValoresxDefault()

            CheckForIllegalCrossThreadCalls = False

            With Me.UsrRegionPenal1
                ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.LicenciaTieneSistemaVisita
                ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._LoadUsc()
            End With

        End Sub
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

            Me.pnlNuevo.Visible = Me._FormEscritura
            Me.pnlModificar.Visible = Me._FormEscritura

            Me.pnlEliminar.Visible = Me._FormEliminar

            Me.pnlExportar.Visible = Me._FormReporte
            Me.pnlReporte.Visible = Me._FormReporte

        End Sub
        Private Sub Limpiar()

            Me.NumeroDocumento = ""
            Me.ApellidoPaterno = ""
            Me.ApellidoMaterno = ""
            Me.Sexo = -1
            Me.Nacionalidad = -1
            Me.UscFoto1._Limpiar()
            Me.txtVisapepat.Focus()

        End Sub

#End Region

        Private Sub frmVisitanteLista_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            'CheckForIllegalCrossThreadCalls = False

            Me.WindowState = FormWindowState.Maximized
            ValoresxDefault()
            UsuarioPermisos()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub


        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

            If Me.BackgroundWorker1.IsBusy Then Exit Sub
            ' inicializa la validacion del ping
            Me.BackgroundWorker1.RunWorkerAsync()

        End Sub

        Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            e.Result = Listar()

        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            'frmLoad.Dispose()
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                Me.Timer1.Stop()
                frmLoad.Close()
                result = e.Result
                ' procesa el resultado del metodo ping        
            End If

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
            If e.RowIndex >= 0 Then
                FRM_Mant(False)
            End If
        End Sub

        Private Sub dgwGrilla_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter

            If Me.dgwGrilla.RowCount > 0 Then
                ImagenFotoVisitante(Me.GrillaFotoVisitante)
            End If

        End Sub
        Private Sub ImagenFotoVisitante(ByVal FotoNameExtension As String)

            'If FotoNameExtension.Trim.Length > 3 Then
            '    With Me.UscFoto1
            '        ._TipoImagen = APPControls.Foto.uscFotografia.DirectotioTipo.Visitante
            '        ._ShowFotoVisitante(FotoNameExtension)                    
            '    End With
            'End If

            With Me.UscFoto1
                '._TipoImagen = APPControls.Foto.uscFotografia.DirectotioTipo.Visitante
                .SizeMode = PictureBoxSizeMode.Zoom
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub


        Private Sub txtVisapepat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVisapepat.KeyDown, txtVisapemat.KeyDown, txtVisNumDoc.KeyDown, txtVisnom.KeyDown

            If e.KeyCode = Keys.Enter Then

                Buscar()

            End If

        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            If Me.dgwGrilla.SelectedRows.Count = 1 Then
                FRM_Mant(False)
            End If

        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            FRM_Mant(True)

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
            'Legolas.Components.ExportarGrillaExcel.ExportarCSV(Me.dgwGrilla, "2017001", False, False, True)

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()

        End Sub

        Private Sub dgwGrilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub UscFoto1__CheckClick() Handles UscFoto1._CheckClick

            ImagenFotoVisitante(Me.GrillaFotoVisitante)

        End Sub

        Private Sub UscFoto1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UscFoto1.Load

        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
            FReporte()
        End Sub

        Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click

            Limpiar()

        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting


        End Sub

        Private Sub dgwGrilla_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            AEliminar()

        End Sub

        Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

        End Sub
    End Class
End Namespace
