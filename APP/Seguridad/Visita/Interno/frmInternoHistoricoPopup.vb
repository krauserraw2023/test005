Namespace Visita.Interno
    Public Class frmInternoHistoricoPopup
        Private objEntCol As Entity.Visita.MovimientoCol = Nothing
        Private objBss As Bussines.Visita.Movimiento = Nothing

        Private objBssAutorizacion As Bussines.Visita.Autorizacion = Nothing
        Private objEntAutorizacionCol As Entity.Visita.AutorizacionCol = Nothing

        Private frmLoad As Load.frmLoad = Nothing
#Region "Propiedades_Parametricas"
        Private lngFechaVisita As Long = 0
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
        Public Property _VisitanteID() As Integer
            Get
                Return intVisitanteID
            End Get
            Set(ByVal value As Integer)
                intVisitanteID = value
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
        Public ReadOnly Property GrillaInterno() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwMovi
                        intValue = .SelectedRows(0).Cells("col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property _grillaIDInterno As Integer
            Get
                Return Me.GrillaInterno
            End Get
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private intVisitanteID As Integer = -1
        Private Property CodigoInterno() As String
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
        'Private Property ApellidoMaterno() As String
        '    Get
        '        Return Me.txtNom.Text.Trim
        '    End Get
        '    Set(ByVal value As String)
        '        Me.txtNom.Text = value
        '    End Set
        'End Property
        Public Property _Nombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Otros"
        Private blnBuscarLoad As Boolean = False
        Private strInternoIDArray As String()
        Private intTipoForm As Integer = 0
        Public Property _BuscarLoad() As Boolean
            Get
                Return blnBuscarLoad
            End Get
            Set(ByVal value As Boolean)
                blnBuscarLoad = value
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
        Public Property _TipoForm() As Integer
            Get
                Return intTipoForm
            End Get
            Set(ByVal value As Integer)
                intTipoForm = value
            End Set
        End Property
        Private Property MostrarGrillaHistoricos As Boolean = False
#End Region
#Region "Propiedades_Load"
        Private strLoadCodigoRP As String = ""
        Private strLoadNumDoc As String = ""
        Private strLoadApe As String = ""
        Private strLoadApePat As String = ""
        Private strLoadApeMat As String = ""
        Private strLoadNombres As String = ""
        Private intLoadEstado As Integer = -1
        Private intLoadRegionID As Short = -1
        Private intLoadPenalID As Integer = -1
#End Region
#Region "Functions"
        Private Function GrillaCountInternosPrincipal() As Integer

            Dim value As Integer = 0
            Dim intCount As Integer = 0

            With Me.dgwMovi
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

            If Me.CodigoInterno.Trim = "" And Me.NumeroDocumento.Trim = "" And Me._Apellidos.Trim = "" And Me._Nombres.Trim = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los apellidos del Interno a buscar")
                Me.txtApePat.Focus()
                Return value
            End If

            value = True
            Return value
        End Function
#End Region
#Region "Listar"
        Private Sub LoadPropiedades()

            strLoadApe = Me._Apellidos
            'strLoadApeMat = Me.ApellidoMaterno
            strLoadNombres = Me._Nombres
            intLoadEstado = 1 'activo
            intLoadRegionID = Me._RegionID
            Me.intLoadPenalID = Me._PenalID

        End Sub
        Private Sub ListarNumeroReg()

            Dim strValue As String = ""
            'Me.lblReg.Text = Me.NumeroReg & " Reg."
            Me.lblReg.Text = GrillaCountInternosPrincipal() & " Reg."

        End Sub

        Private Function Listar() As Boolean

            Dim value As Boolean = False
            Dim intCountRegistrosMixto As Integer = 0

            Select Case Me.RegimenVisitaID

                Case Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario
                    value = ListarInternos_Movimientos()

                Case Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                    value = ListarInternos_Autorizados()

                Case Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario_RegimenCerradoEspecial 'mixto

                    value = ListarInternos_Autorizados()

                    If objEntAutorizacionCol Is Nothing Then
                        'nada
                    Else
                        intCountRegistrosMixto = objEntAutorizacionCol.Count
                    End If

                    'si no hay registros en autorizacion, busca los historicos
                    If intCountRegistrosMixto < 1 Then
                        MostrarGrillaHistoricos = True
                        value = ListarInternos_Movimientos()
                    End If

            End Select

            Return value

        End Function
        Private Function ListarInternos_Movimientos() As Boolean

            objBss = New Bussines.Visita.Movimiento
            objEntCol = New Entity.Visita.MovimientoCol

            Dim objEntFiltro As New Entity.Visita.Movimiento

            With objEntFiltro
                .VisitaID = Me._VisitanteID
                .InternoCodigo = Me.CodigoInterno
                .InternoNumeroDocumento = Me.NumeroDocumento
                .InternoApellidos = Me.strLoadApe
                .InternoNombres = Me.strLoadNombres
                .RegionID = Me.intLoadRegionID
                .PenalID = Me.intLoadPenalID
            End With

            objEntCol = objBss.ListarInternoHistoricoNA(objEntFiltro)

            Return True

        End Function
        Private Function ListarInternos_Autorizados() As Boolean

            objBssAutorizacion = New Bussines.Visita.Autorizacion
            objEntAutorizacionCol = New Entity.Visita.AutorizacionCol

            Dim objEntFiltro As New Entity.Visita.Autorizacion

            With objEntFiltro
                .VisitanteID = Me._VisitanteID
                .InternoCodigo = Me.CodigoInterno
                .InternoNumeroDocumento = Me.NumeroDocumento
                .InternoApellidos = Me.strLoadApe
                .InternoNombres = Me.strLoadNombres
                .RegionID = Me.intLoadRegionID
                .PenalID = Me.intLoadPenalID
            End With

            objEntAutorizacionCol = objBssAutorizacion.ListarInternos(objEntFiltro)

            Return True

        End Function
        Private Sub Buscar()

            If Me._BuscarLoad = False Then
                If ValidarBusqueda() = False Then
                    Exit Sub
                End If
            End If
            
            LoadPropiedades()

            Me.SuspendLayout()
            Me.Timer1.Start()
            frmLoad = New Load.frmLoad
            frmLoad.ShowDialog()
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            With Me.dgwMovi
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                Select Case Me.RegimenVisitaID
                    Case Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario 'Regimen Ordinario 
                        .DataSource = objEntCol

                    Case Type.Enumeracion.Visita.RegimenVisita.RegimenCerradoEspecial
                        .DataSource = objEntAutorizacionCol

                    Case Type.Enumeracion.Visita.RegimenVisita.RegimenOrdinario_RegimenCerradoEspecial 'mixto

                        If MostrarGrillaHistoricos = True Then
                            .DataSource = objEntCol
                        Else
                            .DataSource = objEntAutorizacionCol
                        End If

                End Select

                Me.NumeroReg = .RowCount()

                If .Rows.Count > 0 Then
                    .Rows(0).Selected = True
                End If

            End With

            If Me.dgwMovi.RowCount < 1 Then
                Me._TipoForm = 1 'otros
                Me.DialogResult = Windows.Forms.DialogResult.OK
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
        'Private Sub ListarInternoFotov(ByVal InternoID As Integer)

        '    If InternoID < 1 Then
        '        Exit Sub
        '    End If

        '    If Me.UscFotografia2._CheckImagen = False Then
        '        Me.UscFotografia2._Limpiar()
        '        Exit Sub
        '    End If

        '    Dim objBssFoto As New Bussines.Registro.InternoFoto
        '    Dim objEnt As New Entity.Registro.InternoFoto
        '    Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente(InternoID)

        '    Dim intImagen As Integer = -1
        '    Dim intNombreImagen As String = ""

        '    objBssFoto = New Bussines.Registro.InternoFoto
        '    objEnt = objBssFoto.Listar(intCodigo)

        '    If objEnt.Codigo > 0 Then

        '        With objEnt
        '            intImagen = .PFrenteID
        '            intNombreImagen = .PFrenteName
        '        End With

        '        Me.UscFotografia2._ShowFotoInterno(intImagen, intNombreImagen)
        '    Else
        '        Me.UscFotografia2._Limpiar()
        '    End If

        'End Sub
        'Private Sub ListarInternoFotov5(ByVal InternoID As Integer)

        '    If InternoID < 1 Then
        '        Exit Sub
        '    End If

        '    If Me.UscFotografia_2v1._CheckImagen = False Then
        '        Me.UscFotografia_2v1._Limpiar()
        '        Exit Sub
        '    End If

        '    Dim objBssFoto As New Bussines.Registro.InternoFoto
        '    Dim objEnt As New Entity.Registro.InternoFoto
        '    Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente2(InternoID)
        '    Dim intImagen As Integer = -1

        '    objBssFoto = New Bussines.Registro.InternoFoto
        '    objEnt = objBssFoto.ListarGrilla(intCodigo)

        '    If objEnt.Codigo > 0 Then

        '        With objEnt
        '            intImagen = .PFrenteID
        '        End With

        '        Me.UscFotografia_2v1._ShowFotoInterno(intImagen)
        '    Else
        '        Me.UscFotografia_2v1._Limpiar()
        '    End If

        'End Sub
        'Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

        '    Dim blnVersion5 As Boolean = Bussines.General.Penal.Version5(Me._PenalID)

        '    If blnVersion5 = True Then
        '        ListarInternoFotov5(InternoID)
        '        Me.UscFotografia_2v1.BringToFront()
        '    Else
        '        ListarInternoFotov(InternoID)
        '        Me.UscFotografia2.BringToFront()

        '    End If

        'End Sub
#End Region
#Region "Accion"
      
        Private Sub AOk()

            Dim blnValue As Boolean = False
            Dim strValue As String = ""
            Dim strCodigo As String = ""

            For Each fila As DataGridViewRow In Me.dgwMovi.Rows

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
        Private Sub Form_Sancion(ByVal InternoID As Integer)

            Dim frm As New Visita.Interno.frmSancionDetallePopup
            With frm
                ._Codigo = InternoID
                ._TipoVista = frmSancionDetallePopup.enmTipo.Interno
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Permisos/Accesos"
        Private Property RegimenVisitaID As Short = -1
        Private Property RegimenTipoNombre As String = ""
        Private Property SolicitarAutoRegOrdinario As Boolean = False
        Private Property SolicitarInfoPabellon As Boolean = False
        Private Property HabilitarInternoPJ As Boolean = False

        Private Sub Listar_VisitaConfig()

            Dim objBss As New Bussines.Visita.Config
            Dim objEnt As New Entity.Visita.Config

            Dim objEntFiltro As New Entity.Visita.Config

            With objEntFiltro
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .Estado = 1 'alta
            End With

            If Me._PenalID > 0 Then
                objEnt = objBss.ListarConfigActual(objEntFiltro)
            End If

            If Not objEnt Is Nothing Then
                With objEnt
                    Me.RegimenVisitaID = .RegimenTipoID
                    Me.RegimenTipoNombre = .RegimenTipoNombre
                    Me.SolicitarInfoPabellon = .SolicitaInfoPabellon
                    Me.SolicitarAutoRegOrdinario = .SolicitaAutoRegOrdinario
                    Me.HabilitarInternoPJ = .HabilitarInternosPJ

                End With
            Else
                Me.RegimenVisitaID = -1
                Me.RegimenTipoNombre = "Regimen Ordinario"
                Me.SolicitarInfoPabellon = False
                Me.SolicitarAutoRegOrdinario = False
                Me.HabilitarInternoPJ = False

            End If

            Select Case Me.RegimenVisitaID
                Case 1 'Regimen Ordinario 
                    Me.Text = "Busqueda de Internos Historicos del Visitante"
                Case 2, 3 'Regimen Cerrado Especial, Regimen Ordinario/Regimen Cerrado Especial
                    Me.Text = "Busqueda de Internos Autorizados"
            End Select

            'ocultar el boton interno pj
            Me.btnBuscarInternosPJ.Visible = Me.HabilitarInternoPJ

        End Sub
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

            If Me._VisitanteID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "Falta enviar la Propiedad _VisitanteID")
                Exit Sub
            End If

            If Me._FechaVisita < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                "Falta enviar la Propiedad _FechaVisita")
                Exit Sub
            End If

        End Sub

#End Region

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtCodInterno.KeyPress, _
        txtNumDoc.KeyPress, _
        txtApePat.KeyPress, _
        txtNom.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

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

        Private Sub btnOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtro.Click

            Me._TipoForm = 1 'otros
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub frmHistoricoPopup__Salir() Handles Me._Salir

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub frmHistoricoPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()
            Listar_VisitaConfig()

            If Me._BuscarLoad = True Then
                Buscar()
                Me._BuscarLoad = False
            End If

        End Sub


        Private Sub frmHistoricoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.txtApePat.Focus()
            'Me.dgwMovi.Focus()

        End Sub

        Private Sub dgwMovi_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellDoubleClick

            If Me.dgwMovi.RowCount > 0 And e.RowIndex <> -1 Then
                Me.dgwMovi.Rows(e.RowIndex).Cells("col_chk").Value = True
                AOk()
            End If

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            If Me.dgwMovi.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Busque y seleccione el interno")
                Exit Sub
            End If

            Me.dgwMovi.SelectedRows(0).Cells("col_chk").Value = True
            AOk()

        End Sub

        Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click

            ALimpiar()

        End Sub


        Private Sub dgwMovi_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellEnter

            If Me.dgwMovi.RowCount > 0 And Me.GrillaInterno > 0 Then
                ListarInterno(Me.GrillaInterno)
            End If

        End Sub

        Private Sub dgwMovi_RowPrePaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwMovi.RowPrePaint

            With Me.dgwMovi

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

        Private Sub UscFotografia_2v1__NoAutorizado_DoubleClick() Handles UscFotografia_2v1._NoAutorizado_DoubleClick

            Form_Sancion(Me.GrillaInterno)

        End Sub

        Private Sub btnBuscarInternosPJ_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarInternosPJ.Click

            Me._TipoForm = 2 'internos pj
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub dgwMovi_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellContentClick

        End Sub
    End Class
End Namespace


