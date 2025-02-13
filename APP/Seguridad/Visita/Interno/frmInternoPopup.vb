Namespace Visita.Interno
    Public Class frmInternoPopup
        Private objBss As Bussines.Visita.Interno = Nothing
        Private objEntCol As Entity.Visita.InternoCol = Nothing
        Private frmLoad As Load.frmLoad = Nothing
#Region "Propiedades_Parametricas"
        Private lngFechaVisita As Long = 0
        Public Property _PenalID() As Integer
            Get
                Return Me.UscRegionPenalLabel1._Penalid
            End Get
            Set(ByVal value As Integer)
                Me.UscRegionPenalLabel1._Penalid = value
            End Set
        End Property
        Public Property _PenalNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._PenalNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._PenalNombre = value
            End Set
        End Property
        Public Property _RegionID() As Integer
            Get
                Return Me.UscRegionPenalLabel1._RegionId
            End Get
            Set(ByVal value As Integer)
                Me.UscRegionPenalLabel1._RegionId = value
            End Set
        End Property
        Public Property _RegionNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._RegionNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._RegionNombre = value
            End Set
        End Property
        Public Property _FechaVisita() As Long
            Get
                Return lngFechaVisita
            End Get
            Set(ByVal value As Long)
                lngFechaVisita = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private intNumeroReg As Integer = -1
        Private Property NumeroReg() As Integer
            Get
                Return intNumeroReg
            End Get
            Set(ByVal value As Integer)
                intNumeroReg = value
                ListarNumeroReg()
            End Set
        End Property
        Private ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaInternoPadre() As Short
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_pdr").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaApePaterno() As String
            Get
                Dim value As String = -1
                Try
                    With Me.dgwGrilla
                        If Me.GrillaInternoPadre = 0 Then
                            value = .SelectedRows(0).Cells("col_ape_pat").Value
                        Else

                            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                                If fila.Cells("col_int_id").Value = Me.GrillaInternoID _
                                And fila.Cells("col_pdr").Value = 0 Then

                                    value = fila.Cells("col_ape_pat").Value

                                End If
                            Next

                        End If
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaApeMaterno() As String
            Get
                Dim value As String = -1
                Try
                    With Me.dgwGrilla
                        If Me.GrillaInternoPadre = 0 Then
                            value = .SelectedRows(0).Cells("col_ape_mat").Value
                        Else
                            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                                If fila.Cells("col_int_id").Value = Me.GrillaInternoID _
                                And fila.Cells("col_pdr").Value = 0 Then

                                    value = fila.Cells("col_ape_mat").Value

                                End If
                            Next
                        End If

                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaApellidos() As String
            Get
                Dim value As String = -1
                Try
                    value = Me.GrillaApePaterno & " " & Me.GrillaApeMaterno
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property        
        Private ReadOnly Property GrillaNombres() As String
            Get
                Dim value As String = -1
                Try
                    With Me.dgwGrilla
                        If Me.GrillaInternoPadre = 0 Then
                            value = .SelectedRows(0).Cells("col_nom").Value
                        Else
                            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                                If fila.Cells("col_int_id").Value = Me.GrillaInternoID _
                                And fila.Cells("col_pdr").Value = 0 Then

                                    value = fila.Cells("col_nom").Value

                                End If
                            Next
                        End If

                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaApeNom() As String
            Get
                Dim strValue As String = -1
                Try
                    With Me.dgwGrilla
                        strValue = Me.GrillaApellidos
                        strValue = strValue & " " & Me.GrillaNombres
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        'Public ReadOnly Property GrillaNumDoc() As String
        '    Get
        '        Dim strValue As String = -1
        '        Try
        '            With Me.dgwGrilla
        '                strValue = .SelectedRows(0).Cells("col_num_doc").Value
        '            End With
        '        Catch ex As Exception

        '        End Try
        '        Return strValue
        '    End Get
        'End Property
#End Region
#Region "Propiedades_Return"
        Public ReadOnly Property _GrillaInternoID() As Integer
            Get
                Return Me.GrillaInternoID
            End Get
        End Property
        Public ReadOnly Property _GrillaApellidosyNombres() As String
            Get
                Return Me.GrillaApeNom
            End Get
        End Property
        Public ReadOnly Property _GrillaApellidoPaterno() As String
            Get
                Return Me.GrillaApePaterno
            End Get
        End Property
        Public ReadOnly Property _GrillaApellidoMaterno() As String
            Get
                Return Me.GrillaApeMaterno
            End Get
        End Property
        Public ReadOnly Property _GrillaNombres() As String
            Get
                Return Me.GrillaNombres
            End Get
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private Property CodigoRP() As String
            Get
                Return Me.txtCodInterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodInterno.Text = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Public Property _Apellidos() As String
            Get
                Return Me.txtApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Public Property _Nombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private Property InternoEstado As Short = 1 'interno activo
#End Region
#Region "Propiedades_Load"
        Private strLoadCodigoRP As String = ""
        Private strLoadNumDoc As String = ""
        Private strLoadApe As String = ""
        Private strLoadNombres As String = ""
        Private intLoadRegion As Integer = -1
        Private intLoadPenal As Integer = -1
#End Region
#Region "Propiedades_Otros"
        Private blnBuscarAuto As Boolean = False
        Private intTipoForm As Integer = 0
        Private strInternoIDArray As String()
        Private blnBusquedaMultipple As Boolean = True
        Public Property _BuscarAuto() As Boolean
            Get
                Return blnBuscarAuto
            End Get
            Set(ByVal value As Boolean)
                blnBuscarAuto = value
            End Set
        End Property
        Public Property _TipoForm() As Integer
            Get
                Return intTipoForm
            End Get
            Set(ByVal value As Integer)
                intTipoForm = value
            End Set
        End Property
        Public Property _InternoIDArray() As String()
            Get
                Return strInternoIDArray
            End Get
            Set(ByVal value As String())
                strInternoIDArray = value
            End Set
        End Property
        Public Property _BusquedaMultipple() As Boolean
            Get
                Return blnBusquedaMultipple
            End Get
            Set(ByVal value As Boolean)
                blnBusquedaMultipple = value
                VisibleBusquedaMultiple()
            End Set
        End Property
        Public Property _VisibleRegionPenal() As Boolean
            Get
                Return Me.gbRegionPenal.Visible
            End Get
            Set(value As Boolean)
                Me.gbRegionPenal.Visible = value
            End Set
        End Property
        Public Property _VisibleBotonHistorial As Boolean
            Get
                Return Me.btnVerHistorial.Visible
            End Get
            Set(value As Boolean)
                Me.btnVerHistorial.Visible = value
            End Set
        End Property
        'Public Property _VisiblePanelFiltroInterno() As Boolean
        '    Get
        '        Return Me.gbPanelFiltroInterno.Visible
        '    End Get
        '    Set(value As Boolean)
        '        Me.gbPanelFiltroInterno.Visible = value
        '    End Set
        'End Property
        'Public Property _FiltrarEstadoInternoPor() As enumFiltrarInternoEstado
        '    Get
        '        Return FiltroEstadoInterno
        '    End Get
        '    Set(value As enumFiltrarInternoEstado)
        '        FiltroEstadoInterno = value
        '    End Set
        'End Property
#End Region
#Region "Functions"
        Private Function GrillaCountInternosPrincipal() As Integer

            Dim value As Integer = 0
            Dim intCount As Integer = 0

            With Me.dgwGrilla
                .CurrentCell = Nothing
                For Each dr As DataGridViewRow In .Rows

                    If dr.Cells("col_pdr").Value = 0 Then
                        intCount = intCount + 1
                    End If
                Next
            End With
            value = intCount

            Return value

        End Function
        Private Function ValidarBusqueda() As Boolean
            Dim value As Boolean = False

            If Me.CodigoRP.Trim = "" And Me.NumeroDocumento.Trim = "" And Me._Apellidos.Trim = "" And Me._Nombres.Trim = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los apellidos del Interno a buscar")
                Me.txtApePat.Focus()
                Return value
            End If

            value = True
            Return value
        End Function
        Public Sub _visibleBotones(blnVf As Boolean)

            Me.pnlBotonEspeciales.Visible = blnVf
            Me.InternoEstado = -1 'busca internos activos y inactivos

        End Sub

#End Region
#Region "Listar"
        Private Sub LoadPropiedades()

            strLoadCodigoRP = Me.CodigoRP
            strLoadNumDoc = Me.NumeroDocumento
            strLoadApe = Me._Apellidos
            strLoadNombres = Me._Nombres
            intLoadRegion = Me._RegionID
            intLoadPenal = Me._PenalID

        End Sub
        Private Sub ListarNumeroReg()

            Dim strValue As String = ""
            'Me.lblReg.Text = Me.NumeroReg & " Reg."
            Me.lblReg.Text = GrillaCountInternosPrincipal() & " Reg."

        End Sub
        Private Function Listar() As Boolean

            objBss = New Bussines.Visita.Interno
            objEntCol = New Entity.Visita.InternoCol

            Dim objEntFiltro As New Entity.Visita.Interno
            With objEntFiltro
                .CodigoRP = Me.strLoadCodigoRP
                .Apellidos = Me.strLoadApe
                .Nombres = Me.strLoadNombres
                .NumeroDocumento = Me.strLoadNumDoc
                .EstadoID = Me.InternoEstado   'internos activos
                .IDRegion = Me.intLoadRegion
                .IDPenal = Me.intLoadPenal
            End With

            objEntCol = objBss.ListarGrillaNombresAsociados(objEntFiltro)

            Return True

        End Function
        Private Sub Buscar()

            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            LoadPropiedades()

            Me.SuspendLayout()
            Me.Timer1.Start()
            frmLoad = New Load.frmLoad
            frmLoad.ShowDialog()
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.NumeroReg = .RowCount()

                If .Rows.Count > 0 Then
                    .Rows(0).Selected = True
                End If

            End With

        End Sub
        Private Sub VisibleBusquedaMultiple()

            If Me._BusquedaMultipple = False Then
                Me.col_chk.Visible = False
            End If

        End Sub

        Private Sub ListarInterno(ByVal InternoID As Integer)

            ListarInternoFotoVersion(InternoID)
            ListarSancionInterno(InternoID, Me._FechaVisita)

        End Sub
        
        Private Sub ListarSancionInterno(ByVal InternoID As Integer, ByVal FechaVisita As Long)

            Dim objBss As New Bussines.Visita.InternoSancion
            Me.UscFotografia_2v1._PanelAutorizacion = objBss.Sancion(InternoID, FechaVisita)

        End Sub

        Private Sub Listar_VisitaConfig()

            Dim objBss As New Bussines.Visita.Config
            Dim objEnt As Entity.Visita.Config = Nothing

            Dim objEntFiltro As New Entity.Visita.Config

            With objEntFiltro
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .Estado = 1 'alta
            End With

            Dim blnHabilitarInternoPJ As Boolean = False

            If Me._PenalID > 0 Then
                objEnt = New Entity.Visita.Config
                objEnt = objBss.ListarConfigActual(objEntFiltro)
            End If

            If Not objEnt Is Nothing Then
                With objEnt
                    blnHabilitarInternoPJ = .HabilitarInternosPJ
                End With            
            End If

            Me.btnBuscarInternosPJ.Visible = blnHabilitarInternoPJ

        End Sub
#End Region
#Region "ListarFoto"
        Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

            If InternoID < 1 Then
                Exit Sub
            End If

            If Me.UscFotografia_2v1._CheckImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            Me.UscFotografia_2v1._showFotoInternoPrincipal(InternoID, 2)

            If UscFotografia_2v1._HasImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
            End If

        End Sub        
#End Region
#Region "Accion"
      
        Private Sub AOk()

            Dim blnValue As Boolean = False
            Dim strValue As String = ""
            Dim strCodigo As String = ""

            For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

                If fila.Cells("col_chk").Value = True Then
                    strCodigo = fila.Cells("col_int_id").Value
                    strValue = strValue & strCodigo & ","

                    'If Validar(fila.Cells("col_int_id").Value) = False Then
                    '    Exit Sub
                    'End If

                    blnValue = True
                End If
            Next

            If blnValue = True Then
                strValue = Legolas.Components.Cadena.Left(strValue, strValue.Length - 1)
                Me._InternoIDArray = strValue.Split(",")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
#End Region
#Region "Form"
        'Private Sub Form_Sancion(ByVal InternoID As Integer)

        '    Dim frm As New Visita.frmSancionDetallePopup
        '    With frm
        '        ._Codigo = InternoID
        '        ._TipoVista = frmSancionDetallePopup.enmTipo.Interno
        '        .ShowDialog()
        '    End With

        'End Sub
#End Region
#Region "Otros"
        Private Sub ALimpiar()

            Me.txtCodInterno.Text = ""
            Me.txtNumDoc.Text = ""
            Me.txtApePat.Text = ""
            'Me.txtApeMat.Text = ""
            Me.txtNom.Text = ""
            Me.txtApePat.Focus()

        End Sub
        Private Sub ValoresxDefault()

            If Me._PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "Falta enviar la Propiedad _PenalID")
                Exit Sub
            End If


            If Me._FechaVisita < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "Falta enviar la Propiedad _FechaVisita")
                Exit Sub
            End If

        End Sub
#End Region
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

        Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
 _
 _
        txtApePat.KeyPress, _
 _
        txtNom.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            'Try
            '    With Me.dgwGrilla
            '        If e.RowIndex = -1 Then
            '            .Cursor = Cursors.WaitCursor
            '            objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
            '            .Refresh()
            '            .Cursor = Cursors.Default
            '        End If
            '    End With
            'Catch ex As Exception

            'End Try

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                Me.dgwGrilla.Rows(e.RowIndex).Cells("col_chk").Value = True
                AOk()
            End If

        End Sub

        Private Sub frmInternoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Listar_VisitaConfig()

            If Me._BuscarAuto = True Then
                Buscar()
            End If

            Me.txtApePat.Focus()

        End Sub

        Private Sub frmInternoPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()

        End Sub

        Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Me._TipoForm = 1
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub dgwGrilla_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter

            If Me.dgwGrilla.RowCount > 0 And Me.GrillaInternoID > 0 Then
                ListarInterno(Me.GrillaInternoID)
            End If

        End Sub

        Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click

            ALimpiar()

        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            If Me.dgwGrilla.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Busque y seleccione el interno")
                Exit Sub
            End If

            With Me.dgwGrilla                                
                .SelectedRows(0).Cells("col_chk").Value = True
                AOk()
            End With

        End Sub

        Private Sub dgwGrilla_RowPrePaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrilla.RowPrePaint

            With Me.dgwGrilla

                Select Case (.Item("col_pdr", e.RowIndex).Value) 'estado color
                    Case 0 'padres
                        .Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White 'Color.PowderBlue
                        .Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(65, 91, 133) 'Color.Black
                    Case 1 'hijos
                        .Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                        .Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(0, 128, 0) 'Color.Black                        
                End Select
                .Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Black
                .Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            End With

        End Sub

        Private Sub btnVerHistorial_Click(sender As System.Object, e As System.EventArgs) Handles btnVerHistorial.Click

            Me._TipoForm = 1
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub btnBuscarInternosPJ_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarInternosPJ.Click

            Me._TipoForm = 2 'internos pj
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub
    End Class
End Namespace


