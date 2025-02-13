Option Explicit On
Namespace Registro.SedeCentral
    Public Class frmBuscar

        Private objBss As Bussines.Registro.Interno = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing
        Private objEntFiltro As New Entity.Registro.Interno_Grilla
        Private Property FiltroNuevo As String = ""
        Private Property FiltroActual As String = ""
        Private frmLoad As Load.frmLoad = Nothing
        Private Property PerfilFotoActual As Integer
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try

                    Select Case Me.tbcPrincipal.SelectedTab.Name
                        Case "tpConsultaInterno"
                            With Me.dgwGrilla
                                intValue = .SelectedRows(0).Cells("col_int_id").Value
                            End With
                    End Select

                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaInternoCodigo() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_cod_rp").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaRegionID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_reg_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

        Private ReadOnly Property GrillaPenalID() As Integer
            Get
                Dim intValue As Integer = -1
                Try

                    Select Case Me.tbcPrincipal.SelectedTab.Name
                        Case "tpConsultaInterno"
                            With Me.dgwGrilla
                                intValue = .SelectedRows(0).Cells("col_pen_id").Value
                            End With
                    End Select

                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaVersionRegistro() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_ver_reg").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaPenalTipoLicencia() As Short
            Get
                Dim value As Short = -1
                Try

                    Select Case Me.tbcPrincipal.SelectedTab.Name
                        Case "tpConsultaInterno"
                            With Me.dgwGrilla
                                value = .SelectedRows(0).Cells("col_pen_tip_lic").Value
                            End With
                    End Select

                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private intNumeroReg As Integer = 0

        Private Property NumeroReg() As Integer
            Get
                Return intNumeroReg
            End Get
            Set(ByVal value As Integer)
                intNumeroReg = value
                ListarNumeroReg()
            End Set
        End Property
        Private Property CodigoRP() As String
            Get
                Return Me.txtCodInterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodInterno.Text = value
            End Set
        End Property
        Private Property PrimerApellido() As String
            Get
                Return Me.txtApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property SegundoApellido() As String
            Get
                Return Me.txtApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private Property IDTipoDocumento() As Integer
            Get
                Try
                    Return Me.cbbTipoDoc.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
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
        Private Property NombresAlias() As String
            Get
                Return Me.txtAlias.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtAlias.Text = value
            End Set
        End Property

        Private Property IDSituacionJuridica() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbProcesado.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbSentenciado.Checked = True Then
                    intValue = 2
                End If

                If Me.rdbSentProcs.Checked = True Then
                    intValue = 3
                End If

                If Me.rdbSitJurTodos.Checked = True Then
                    intValue = -1
                End If

                Return intValue

            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 1
                        Me.rdbProcesado.Checked = True
                    Case 2
                        Me.rdbSentenciado.Checked = True
                    Case 3
                        Me.rdbSentProcs.Checked = True
                    Case Else
                        Me.rdbSitJurTodos.Checked = True

                End Select

            End Set
        End Property

        Private Property IDSexo() As Integer
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
        Private ReadOnly Property Estado() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbActivo.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbInactivo.Checked = True Then
                    intValue = 0
                End If

                If Me.rdbEstadoTodos.Checked = True Then
                    intValue = -1
                End If

                Return intValue
            End Get

        End Property

        Private Property NacionalidadExtranjero() As Integer
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
        Private Property IDNacionalidad() As Integer
            Get
                Dim value As Integer = -1

                Select Case Me.NacionalidadExtranjero
                    Case 2 'extranjeros
                        value = Me.cbbNacionalidad.SelectedValue
                    Case Else
                        value = -1
                End Select

                Return value

            End Get
            Set(ByVal value As Integer)

                Me.cbbNacionalidad.SelectedValue = value

            End Set
        End Property

#End Region
#Region "Propiedades_PanelFotografia"
        Private IDInternoTemporal As Integer = -1
        Private Property PerfilFotografia() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbPI.Checked = True Then
                    value = 1
                End If

                If Me.rdbPF.Checked = True Then
                    value = 2
                End If

                If Me.rdbPD.Checked = True Then
                    value = 3
                End If

                Return value

            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 1
                        Me.rdbPI.Checked = True
                    Case 2
                        Me.rdbPF.Checked = True
                    Case 3
                        Me.rdbPD.Checked = True
                    Case Else
                        Me.rdbPI.Checked = False
                        Me.rdbPF.Checked = False
                        Me.rdbPD.Checked = False
                End Select
            End Set
        End Property
        Private Property IngresoNumero() As String
            Get
                Return Me.txtIngresoNum.Text.Trim
            End Get
            Set(ByVal value As String)
                'If value = "" Then
                '    Me.txtIngresoNum.Text = "No Registra"
                'Else
                Me.txtIngresoNum.Text = value
                'End If

            End Set
        End Property
        Private Property IngresoFecha() As String
            Get
                Return Me.txtIngresoFecha.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIngresoFecha.Text = value
            End Set
        End Property
        Private Property IngresoSituacionJuridica() As String
            Get
                Return Me.txtSituacionJur.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtSituacionJur.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Sistema"
        Private ReadOnly Property IDLicencia As Integer
            Get
                Return Legolas.LBusiness.Globall.WinApp.LicenciaApp
            End Get
        End Property
        Private ReadOnly Property UsuarioPerfil As Short
            Get
                Return Legolas.Configuration.Usuario.OficinaID
            End Get
        End Property

#End Region
#Region "Combo"
        Private Sub ComboTipoDocumento()

            With Me.cbbTipoDoc
                ._Todos = True
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboNacionalidad()

            With Me.cbbNacionalidad
                ._Todos = True
                .LoadUsc()
            End With

        End Sub

#End Region
#Region "Functions"
        Private Function GrillaCountInternosPrincipal() As Integer

            Dim value As Integer = 0
            Dim intCount As Integer = 0
            If tbcPrincipal.SelectedTab.Name = "tpConsultaInterno" Then
                With Me.dgwGrilla
                    .CurrentCell = Nothing
                    For Each dr As DataGridViewRow In .Rows

                        If dr.Cells("col_pdr").Value = 0 Then
                            intCount = intCount + 1
                        End If
                    Next
                End With

            End If

            value = intCount

            Return value

        End Function
#End Region
#Region "Validar"
        Private Function ValidarBusqueda() As Boolean

            Dim value As Boolean = False

            If Me.CodigoRP.Trim.Length > 0 Then
                If Me.CodigoRP.Trim.Length <> 10 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El codigo del interno, tiene que ser igual 10 digitos")
                    Me.txtCodInterno.Focus()
                    Return value
                End If
            End If

            'validar el numero de dni
            If Me.NumeroDocumento.Trim.Length > 0 Or Me.IDTipoDocumento > 0 Then
                If Me.NumeroDocumento.Trim.Length < 8 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El numero de documento del interno, tiene que ser mayor igual 08 digitos")
                    Me.txtCodInterno.Focus()
                    Return value
                End If
            End If

            'validar que el tener la opcion todos ingrese un dato
            If (Me.PrimerApellido.Length < 2) And (Me.SegundoApellido.Length < 2) And Me.CodigoRP.Length <> 10 And Me.NumeroDocumento.Trim.Length < 8 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese algun apellido, codigo o numero de documento. Para realizar la busqueda")
                Me.txtApePat.Focus()
                Return value
            End If

            value = True

            Return value
        End Function

#End Region
#Region "Listar"

        Private Sub ListarNumeroReg()

            Dim strValue As String = ""

            Me.lblReg.Text = Me.NumeroReg & " Reg."

        End Sub
        Private Sub ColumnasVisible()

            'mostrar columnas de sistema
            Select Case Legolas.Configuration.Usuario.OficinaID

                Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion

                    Me.col_int_id.DividerWidth = 0
                    Me.col_id_loc_row.DividerWidth = 0
                    Me.col_reg_id.DividerWidth = 0
                    Me.col_pen_id.DividerWidth = 0
                    Me.col_id_sed_row.DividerWidth = 0
                    Me.col_ver_int.DividerWidth = 0

            End Select

        End Sub

        Private Function Listar() As Boolean

            Dim objBss As New Bussines.Registro.Interno_Grilla

            objEntCol = objBss.Listar_SedeCentral(objEntFiltro)
            If objEntCol.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Ningún registro encontrado.")
            End If
            Return True

        End Function
        Private Sub Buscar()

            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0
            Me.lblSegundo.Text = "00:00:00"
            Me.lblSegundo.Refresh()

            FiltroActual = fn_ConcatenarFiltro()

            'filtro de busqueda            
            objEntFiltro = New Entity.Registro.Interno_Grilla
            With objEntFiltro
                '/*interno*/
                .InternoCodigoRP = Me.CodigoRP
                .PrimerApellido = Me.PrimerApellido
                .SegundoApellido = Me.SegundoApellido
                .PreNombres = Me.Nombres
                .IDTipoDocIdentidad = Me.IDTipoDocumento
                .InternoNumeroDocumento = Me.NumeroDocumento
                .InternoAlias = Me.NombresAlias
                .NacionalidadExtranjero = Me.NacionalidadExtranjero
                .IDNacionalidad = Me.IDNacionalidad
                .IDSexo = Me.IDSexo
                .IDInternoEstado = Me.Estado
                .IDSituacionJuridica = Me.IDSituacionJuridica
            End With

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

            ColumnasVisible()

            'formato columnas
            Me.col_fec_nac.Tag = "fecha"
            Me.col_fot_ico_pi.Tag = "1"
            Me.col_fot_ico_pf.Tag = "1"
            Me.col_fot_ico_pd.Tag = "1"

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.NumeroReg = GrillaCountInternosPrincipal() '.RowCount()
            End With

            Dim dteFechaFin As Date = Now

            intSeg = DateDiff(DateInterval.Second, dteFechaIni, dteFechaFin)
            Me.lblSegundo.Text = intSeg.ToString("00:00:00")

        End Sub

        Private Function fn_ConcatenarFiltro() As String
            Dim objLista As New ArrayList
            'texto
            objLista.Add(Me.CodigoRP)
            objLista.Add(Me.PrimerApellido)
            objLista.Add(Me.SegundoApellido)
            objLista.Add(Me.Nombres)
            objLista.Add(Me.NombresAlias)
            objLista.Add(Me.NumeroDocumento)
            'combos
            objLista.Add(Me.IDTipoDocumento)
            objLista.Add(Me.cbbNacionalidad.SelectedValue)
            'radio buton
            objLista.Add(Me.IDSexo)
            objLista.Add(Me.NacionalidadExtranjero)
            objLista.Add(Me.IDSituacionJuridica)
            objLista.Add(Me.Estado)

            Dim FiltroConcatenado As String = ""
            For Each obj As String In objLista
                FiltroConcatenado = FiltroConcatenado & obj
            Next
            Return FiltroConcatenado
        End Function

        Private Sub ListarResumenIngreso()

            If Me.GrillaInternoID < 1 Then
                Exit Sub
            End If

            If Me.IDInternoTemporal = Me.GrillaInternoID And Me.IngresoNumero.Length < 1 Then
                'nada
            Else

                Dim strNumeroIngreso As String = ""
                Dim strFechaIngreso As String = ""
                Dim strSituacionJuridica As String = ""
                Dim blnPenalVersion5 As Boolean = False

                Select Case Me.GrillaPenalTipoLicencia

                    Case 1, 7 'penales de provincia, lima provincia 

                        blnPenalVersion5 = Bussines.General.Penal.Version5(Me.GrillaPenalID)

                        If blnPenalVersion5 = True Then
                            'version6
                            Dim obBssIngreso As New Bussines.Registro.Ingreso
                            Dim objEntIngreso As New Entity.Registro.Ingreso

                            objEntIngreso.InternoID = Me.GrillaInternoID
                            objEntIngreso = obBssIngreso.ListarResumen(objEntIngreso)

                            With objEntIngreso
                                strNumeroIngreso = IIf(.IngresoNro < 1, 0, .IngresoNro)
                                strFechaIngreso = IIf(.FechaIngresoDate = "", "NO REGISTRA", .FechaIngresoDate)
                                strSituacionJuridica = .SituacionJuridicaNombre
                            End With
                        Else
                            'penales cerrados

                            Dim obBssIngreso As New Bussines.Registro.Ingreso
                            Dim objEntIngreso As New Entity.Registro.Ingreso

                            objEntIngreso = obBssIngreso.ListarResumen(Me.GrillaInternoID)

                            With objEntIngreso
                                strNumeroIngreso = .IngresoNro
                                strFechaIngreso = .FechaIngresoDate
                                strSituacionJuridica = .SituacionJuridicaNombre
                            End With
                        End If

                    Case 4, 6 'penal lima metropolitana, carceleta

                        Dim obBssIngreso As New Bussines.Registro.IngresoInpe
                        Dim objEntIngreso As New Entity.Registro.IngresoInpe

                        With objEntIngreso
                            .InternoID = Me.GrillaInternoID
                            .PenalID = Me.GrillaPenalID
                            .PerfilUsuarioId = Me.UsuarioPerfil
                        End With

                        objEntIngreso = obBssIngreso.ListarResumen(objEntIngreso, True)

                        With objEntIngreso
                            strNumeroIngreso = .IngresoNro
                            strFechaIngreso = .FechaMovIngresoString
                            strSituacionJuridica = .SituacionJuridicaNombre
                        End With

                End Select

                Me.IngresoNumero = strNumeroIngreso
                Me.IngresoFecha = strFechaIngreso
                Me.IngresoSituacionJuridica = strSituacionJuridica

                Me.IDInternoTemporal = Me.GrillaInternoID
            End If

        End Sub
        Private Sub ShowFotografia()

            If Me.UscFotografia_2v1._CheckImagen = False Or Me.GrillaInternoID < 1 Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            If Me.IDInternoTemporal = Me.GrillaInternoID And Me.UscFotografia_2v1._HasImagen = True And PerfilFotografia = PerfilFotoActual Then
                'nada
            Else

                Dim objBssFoto As New Bussines.Registro.InternoFoto
                Dim objEnt As New Entity.Registro.InternoFoto
                Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente2(Me.GrillaInternoID)
                Dim strRutServer As String = ""
                Dim intImagen As Integer = -1
                Dim intNombreImagen As String = ""

                objBssFoto = New Bussines.Registro.InternoFoto
                objEnt = objBssFoto.ListarGrilla(intCodigo)

                If objEnt.Codigo > 0 Then

                    With objEnt
                        Select Case Me.PerfilFotografia
                            Case 1 'izquierdo
                                PerfilFotoActual = 1
                                intImagen = .PIzquierdoID
                                intNombreImagen = .PIzquierdoName
                                strRutServer = .PIzquierdoServerPath
                            Case 2 'frente
                                PerfilFotoActual = 2
                                intImagen = .PFrenteID
                                intNombreImagen = .PFrenteName
                                strRutServer = .PFrenteServerPath
                            Case 3 'derecho
                                PerfilFotoActual = 3
                                intImagen = .PDerechoID
                                intNombreImagen = .PDerechoName
                                strRutServer = .PDerechoServerPath
                        End Select
                    End With

                    Me.UscFotografia_2v1._ShowFotoInterno(intImagen)
                Else
                    Me.UscFotografia_2v1._Limpiar()
                End If

            End If

        End Sub
#End Region
#Region "Accion"

        Private Sub ALimpiar()

            Me.CodigoRP = ""
            Me.PrimerApellido = ""
            Me.SegundoApellido = ""
            Me.Nombres = ""
            Me.NombresAlias = ""
            Me.IDTipoDocumento = -1
            Me.NumeroDocumento = ""
            Me.NacionalidadExtranjero = -1 'todos
            Me.IDSexo = -1 'todos
            Me.IDSituacionJuridica = -1

            rdbEstadoTodos.Checked = True
            Me.txtApePat.Focus()

        End Sub

#End Region

#Region "Form"

        Private Sub FRM_Mantenimiento()

            If Me.GrillaInternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el interno")
                Exit Sub
            End If

            Dim intIDInterno As Integer = -1
            Dim intIDRegion As Integer = -1
            Dim intIDPenal As Integer = -1
            Dim intTipoInterno As Short = Type.Enumeracion.Interno.enmTipoInterno.Interno
            Dim blnPenalVersion5 As Boolean = False

            intIDInterno = Me.GrillaInternoID
            intIDRegion = Me.GrillaRegionID
            intIDPenal = Me.GrillaPenalID

            Select Case Me.GrillaPenalTipoLicencia
                Case 1, 7 'penales de provincia 'penales de provincia lima 

                    blnPenalVersion5 = Bussines.General.Penal.Version5(intIDPenal)

                    If blnPenalVersion5 = True Then

                        'penales con version 6
                        Dim frm As New Registro.Penal.Busqueda.frmMant
                        frm.MdiParent = Me.MdiParent
                        With frm
                            .InternoID = intIDInterno
                            '/*permisos*/
                            ._FormLectura = Me._FormLectura
                            ._FormReporte = Me._FormReporte
                            ._FormEscritura = False
                            ._FormEliminar = False
                            .Show()
                        End With
                    Else

                        ''penales cerrados
                        'Dim frm As New Registro.Main.Penal.v45.frmMantenimiento3
                        'frm.MdiParent = Me.MdiParent
                        'With frm
                        '    .InternoID = intIDInterno
                        '    '/*permisos*/
                        '    ._FormLectura = Me._FormLectura
                        '    ._FormReporte = Me._FormReporte
                        '    ._FormEscritura = False
                        '    ._FormEliminar = False
                        '    .Show()
                        'End With
                    End If

                Case 4, 6 ' lima metropolitana, carceleta de lima

                    Dim frm As New Registro.Main.Region.frmMantenimiento
                    frm.MdiParent = Me.MdiParent
                    With frm
                        ._IDInterno = intIDInterno
                        ._TipoInterno = intTipoInterno
                        '/*permisos*/
                        ._FormLectura = Me._FormLectura
                        ._FormReporte = Me._FormReporte
                        ._FormEscritura = False
                        ._FormEliminar = False
                        .Show()
                    End With

                Case Else
                    MessageBox.Show(Me.Text, "El registro del penal del interno no esta identificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Select

        End Sub

#End Region
#Region "Otros"

        Private Sub HabilitarNacionaliadPais()

            Select Case Me.NacionalidadExtranjero
                Case 2 'extranjero
                    Me.cbbNacionalidad.Enabled = True
                Case Else
                    Me.IDNacionalidad = -1
                    Me.cbbNacionalidad.Enabled = False
            End Select
        End Sub

        Private Sub ValoresxDefault()

            Select Case Legolas.Configuration.Usuario.OficinaID
                Case 1 'osin
                    '
                Case Else
                    Me.lblSegundo.Visible = False
            End Select

            ComboTipoDocumento()
            ComboNacionalidad()

            dgwGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dgwGrilla.VisibleCampos = True

        End Sub

        Private Sub ValidarFiltro()

            FiltroNuevo = fn_ConcatenarFiltro()
            If FiltroNuevo <> FiltroActual Then
                Me.dgwGrilla.DataSource = Nothing
                Me.NumeroReg = 0
            End If
        End Sub
        Private Sub FormatoGrillaColumnas()
            'formato columnas
            Me.col_fec_nac.Tag = "fecha"
            Me.col_fot_ico_pi.Tag = "1"
            Me.col_fot_ico_pf.Tag = "1"
            Me.col_fot_ico_pd.Tag = "1"

        End Sub
#End Region
        Private Sub frmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Select Case tbcPrincipal.SelectedTab.Name
                Case "tpConsultaInterno"
                    Buscar()
            End Select

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            Me.Cursor = Cursors.WaitCursor

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                FRM_Mantenimiento()
            End If

            Me.Cursor = Cursors.Default

        End Sub
        Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtCodInterno.KeyPress,
        txtApePat.KeyPress,
        txtApeMat.KeyPress,
        txtNom.KeyPress,
        txtAlias.KeyPress,
        txtNumDoc.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
            FormatoGrillaColumnas()
            Select Case tbcPrincipal.SelectedTab.Name
                Case "tpConsultaInterno"
                    Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
            End Select
        End Sub
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            Select Case Me.tbcPrincipal.SelectedTab.Name
                Case "tpConsultaInterno"
                    If Me.dgwGrilla.RowCount < 1 Then
                        Exit Sub
                    End If
            End Select

            FRM_Mantenimiento()

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
            If Me.BackgroundWorker1.IsBusy Then Exit Sub
            ' inicializa la validacion del ping
            Me.BackgroundWorker1.RunWorkerAsync()
        End Sub

        Private Sub BackgroundWorker1_Disposed(sender As Object, e As System.EventArgs) Handles BackgroundWorker1.Disposed

            If Me.BackgroundWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de bsuqueda")
                Me.BackgroundWorker1 = Nothing
                Me.Close()
            End If

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
        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Me.Refresh()

        End Sub
        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_nac").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub dgwGrilla_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrilla.RowPrePaint

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
        Private Sub rdbPeruano_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rdbPeruano.CheckedChanged,
        rdbExtranjero.CheckedChanged,
        rdbNacTodos.CheckedChanged

            HabilitarNacionaliadPais()

        End Sub
        Private Sub rdbPI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rdbPI.Click, rdbPF.Click, rdbPD.Click

            ShowFotografia()

        End Sub

        Private Sub rdbActivo_Click(sender As Object, e As System.EventArgs) _
            Handles rdbActivo.Click,
            rdbInactivo.Click,
            rdbEstadoTodos.Click
            ColumnasVisible()
        End Sub
        Private Sub dgwGrilla_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick, dgwGrilla.CellEnter
            ShowFotografia()
            ListarResumenIngreso()
        End Sub

        Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click
            Select Case tbcPrincipal.SelectedTab.Name
                Case "tpConsultaInterno"
                    ALimpiar()
            End Select
        End Sub
        Private Sub txtCodInterno_TextChanged(sender As System.Object, e As System.EventArgs) Handles _
            txtCodInterno.TextChanged,
            txtApePat.TextChanged,
            txtApeMat.TextChanged,
            txtNom.TextChanged,
            txtAlias.TextChanged,
            txtNumDoc.TextChanged

            ValidarFiltro()

        End Sub


        Private Sub cbbNacionalidad__SelectedIndexChanged() Handles _
            cbbNacionalidad._SelectedIndexChanged,
                    cbbTipoDoc._SelectedIndexChanged

            ValidarFiltro()

        End Sub


        Private Sub rdbActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles _
            rdbActivo.CheckedChanged,
            rdbInactivo.CheckedChanged,
            rdbEstadoTodos.CheckedChanged,
            rdbPeruano.CheckedChanged,
            rdbExtranjero.CheckedChanged,
            rdbNacTodos.CheckedChanged,
            rdbProcesado.CheckedChanged,
            rdbSentenciado.CheckedChanged,
            rdbSentProcs.CheckedChanged,
            rdbSitJurTodos.CheckedChanged,
            rdbHom.CheckedChanged,
            rdbMuj.CheckedChanged,
            rdbSexoTodos.CheckedChanged

            ValidarFiltro()
        End Sub

        Private Sub UscFotografia_2v1__CheckClick() Handles UscFotografia_2v1._CheckClick

            ShowFotografia()

        End Sub

    End Class
End Namespace
