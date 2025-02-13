Imports System.ComponentModel
Imports Bussines

Namespace Tratamiento
    Public Class frmBuscarInterno
        Private _frmLectura As Boolean = False
        Private _frmEscritura As Boolean = False
        Private _frmReporte As Boolean = False
        Private _frmImpresion As Boolean = False
        Private _frmEliminar As Boolean = False

        Private objBss As Bussines.Registro.Interno = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing
        Private entMovCol As Entity.Registro.InternoMovimientoCol
        Private frmLoad As Load.frmLoad = Nothing

        Private Property IDLicencia As Integer = -1

#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    value = Me.dgwGrilla.SelectedRows(0).Cells("col_int_id").Value
                Catch ex As Exception

                End Try
                Return value
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
        Private ReadOnly Property GrillaIngresoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_ing_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaApellidos() As String
            Get
                Dim strValue As String = ""
                Try
                    strValue = Me.dgwGrilla.SelectedRows(0).Cells("col_ape").Value
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaNombres() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaApeNom As String
            Get
                Return GrillaApellidos + ", " + GrillaNombres
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
        Private ReadOnly Property GrillaRegionNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_reg_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
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
        Private ReadOnly Property GrillaPenalNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_pen_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Private ReadOnly Property GrillaEstado() As String
            Get
                Dim str As String = ""
                Try
                    With Me.dgwGrilla
                        str = .SelectedRows(0).Cells("col_est_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return str
            End Get
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private intNumeroReg As Integer = 0
        Private strPenalMultiple As String = ""
        Private Property IdInternoSelectFotografia As Integer = -1

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
        Private Property ApellidoPaterno() As String
            Get
                Return Me.txtApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
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

        Private Property RegionID() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private Property PenalID() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Private Property PenalMultiple() As String
            Get
                Return strPenalMultiple
            End Get
            Set(ByVal value As String)
                strPenalMultiple = value
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
        Private Property EstadoEspecifico As Integer = -1
        Private Property FechaIngresoPenal As Long = -0
        Private Property FechaIngresoPenalDate As String = 0
        Private Property FiltroNuevo As String = ""
        Private Property FiltroActual As String = ""
#End Region
#Region "Propiedades_Load"
        Private strLoadCodigoRP As String = ""
        Private strLoadApePat As String = ""
        Private strLoadApeMat As String = ""
        Private strLoadNombres As String = ""
        Private strLoadNombresAlias As String = ""
        Private intLoadRegion As Integer = -1
        Private intLoadPenal As Integer = -1
        Private intLoadSexo As Integer = -1
        Private intLoadNacionalidad As Integer = -1
        Private intLoadNacionalidadPais As Integer = -1
        Private intLoadEstado As Integer = -1
        Private intLoadDelGene As Integer = -1
        Private intLoadDelEsp As Integer = -1
        Private intLoadSitJur As Integer = -1
        Private lngLoadFechaIni As Long = 0
        Private lngLoadFechaFin As Long = 0
        Private strLoadPenalMult As String = ""
        Private intLoadEstadoReniec As Integer = -1
        Private Property LoadCodigoRP() As String
            Get
                Return strLoadCodigoRP
            End Get
            Set(ByVal value As String)
                strLoadCodigoRP = value
            End Set
        End Property
        Private Property LoadApePat() As String
            Get
                Return strLoadApePat
            End Get
            Set(ByVal value As String)
                strLoadApePat = value
            End Set
        End Property
        Private Property LoadApeMat() As String
            Get
                Return strLoadApeMat
            End Get
            Set(ByVal value As String)
                strLoadApeMat = value
            End Set
        End Property
        Private Property LoadNombres() As String
            Get
                Return strLoadNombres
            End Get
            Set(ByVal value As String)
                strLoadNombres = value
            End Set
        End Property
        Private Property LoadNombresAlias() As String
            Get
                Return strLoadNombresAlias
            End Get
            Set(ByVal value As String)
                strLoadNombresAlias = value
            End Set
        End Property
        Private Property LoadSexo() As Integer
            Get
                Return intLoadSexo
            End Get
            Set(ByVal value As Integer)
                intLoadSexo = value
            End Set
        End Property
        Private Property LoadExtranjero() As Integer
            Get
                Return intLoadNacionalidad
            End Get
            Set(ByVal value As Integer)
                intLoadNacionalidad = value
            End Set
        End Property
        Private Property LoadNacionalidadPais() As Integer
            Get
                Return intLoadNacionalidadPais
            End Get
            Set(ByVal value As Integer)
                intLoadNacionalidadPais = value
            End Set
        End Property
        Private Property LoadDelGen() As Integer
            Get
                Return intLoadDelGene
            End Get
            Set(ByVal value As Integer)
                intLoadDelGene = value
            End Set
        End Property
        Private Property LoadDelEsp() As Integer
            Get
                Return intLoadDelEsp
            End Get
            Set(ByVal value As Integer)
                intLoadDelEsp = value
            End Set
        End Property
        Private Property LoadSitJur() As Integer
            Get
                Return intLoadSitJur
            End Get
            Set(ByVal value As Integer)
                intLoadSitJur = value
            End Set
        End Property
        Private Property LoadFechaIni() As Long
            Get
                Return lngLoadFechaIni
            End Get
            Set(ByVal value As Long)
                lngLoadFechaIni = value
            End Set
        End Property
        Private Property LoadFechaFin() As Long
            Get
                Return lngLoadFechaFin
            End Get
            Set(ByVal value As Long)
                lngLoadFechaFin = value
            End Set
        End Property
        Private Property LoadRegion() As Integer
            Get
                Return intLoadRegion
            End Get
            Set(ByVal value As Integer)
                intLoadRegion = value
            End Set
        End Property
        Private Property LoadPenal() As Integer
            Get
                Return intLoadPenal
            End Get
            Set(ByVal value As Integer)
                intLoadPenal = value
            End Set
        End Property
        Private Property LoadPenalMult() As String
            Get
                Return strLoadPenalMult
            End Get
            Set(ByVal value As String)
                strLoadPenalMult = value
            End Set
        End Property

        Private Property LoadEstado() As Integer
            Get
                Return intLoadEstado
            End Get
            Set(ByVal value As Integer)
                intLoadEstado = value
            End Set
        End Property
        Private Property LoadEstadoReniec() As Integer
            Get
                Return intLoadEstadoReniec
            End Get
            Set(ByVal value As Integer)
                intLoadEstadoReniec = value
            End Set
        End Property
        Private Property LoadEstadoEspecifico() As Integer = -1
        Private Property LoadFechaIngresoPenal As Long = 0
        Private Property LoadFechaIngresoPenalDate As String = ""
#End Region
#Region "Propiedades_Interno_Nuevo"
        Private Property IdRegion As Short = -1
        Private Property IdPenal As Short = -1
        Private Property RegionNombre As String = ""
        Private Property PenalNombre As String = ""
#End Region
#Region "Propiedades_PanelFotografia"
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
        Private Property TipoEgreso() As String
            Get
                Return Me.txtTipoEgreso.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtTipoEgreso.Text = value
            End Set
        End Property
        Private Property EgresoFecha() As String
            Get
                Return Me.txtFechaEgreso.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtFechaEgreso.Text = value
            End Set
        End Property
        Private Property PerfilActual As Integer
#End Region
#Region "Combo"

        Private Sub ComboRegion()

            Dim blnTodos As Boolean = False

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True
            End If

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                ._Todos = blnTodos
                .Parametro1 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboPenal()

            Dim blnTodos As Boolean = False

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True
            Else
                Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
                Dim objBssLicencia As New Bussines.Sistema.Instalacion
                intTipoLicencia = objBssLicencia.ListarTipo(Configuracion.Licencia.Codigo)

                Select Case intTipoLicencia
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                        blnTodos = True
                End Select
            End If

            With Me.cbbPenal
                ._Todos = blnTodos
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.RegionID
                .Parametro1 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub

#End Region
#Region "Functions"
        Private Function GrillaCountInternosPrincipal() As Integer

            Dim value As Integer = 0
            Dim intCount As Integer = 0
            With Me.dgwGrilla
                .CurrentCell = Nothing
                For Each dr As DataGridViewRow In .Rows

                    If dr.Cells("col_pdr").Value = 0 Then
                        intCount += 1
                    End If
                Next
            End With

            value = intCount

            Return value

        End Function
#End Region
#Region "Validar"
        Private Function ValidarBusqueda() As Boolean

            Dim value As Boolean = False

            'validar que el tener la opcion todos ingrese un dato
            If Me.RegionID < 1 Then
                If (Me.ApellidoPaterno.Length < 3) And (Me.ApellidoMaterno.Length < 3) And Me.CodigoRP.Length < 5 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese algun apellido o codigo, para realizar la busqueda")
                    Me.txtApePat.Focus()
                    Return value
                End If
            End If



            value = True

            Return value
        End Function

#End Region
#Region "Listar"

        Private Sub CodigoPenalMultiple()

            Me.PenalMultiple = ""

            If Me.PenalID = -1 And Me.cbbPenal.ItemsCount > 1 Then
                'sdswd
                Dim strPenalArray As New ArrayList
                Dim strCadena As String

                For i As Integer = 1 To Me.cbbPenal.ItemsCount - 1
                    Me.cbbPenal.SelectedIndex = i
                    strCadena = Me.cbbPenal.SelectedValue
                    strPenalArray.Add(strCadena)
                Next
                Me.cbbPenal.SelectedIndex = 0 'inicio

                strCadena = ""

                strPenalArray.Sort()
                For Each str As String In strPenalArray
                    strCadena = strCadena & str & ","
                Next

                Me.PenalMultiple = Legolas.Components.Cadena.Left(strCadena, strCadena.Length - 1)
            End If

        End Sub
        Private Sub ListarNumeroReg()
            Me.lblReg.Text = Me.NumeroReg & " Registros encontrados."
        End Sub
        Private Sub ColumnasVisible()

            If Me.PenalID > 0 Then
                Me.col_pen_nom.Visible = False
            Else
                Me.col_pen_nom.Visible = True
            End If

        End Sub
        Private Sub LoadPropiedades()

            LoadCodigoRP = Me.CodigoRP
            LoadApePat = Me.ApellidoPaterno
            LoadApeMat = Me.ApellidoMaterno
            LoadNombres = Me.Nombres
            LoadSexo = Me.Sexo

            LoadRegion = Me.RegionID
            LoadPenal = Me.PenalID
            LoadPenalMult = Me.PenalMultiple
            LoadEstado = Me.Estado
            LoadEstadoEspecifico = Me.EstadoEspecifico

        End Sub

        Private Function Listar(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean

            If worker.CancellationPending = True Then

                e.Cancel = True

            Else
                Dim objBss As New Bussines.Registro.Interno_Grilla
                Dim objEntFiltro As New Entity.Registro.Interno_Grilla

                With objEntFiltro
                    '/*interno*/
                    .InternoCodigoRP = Me.LoadCodigoRP
                    .PrimerApellido = Me.LoadApePat
                    .SegundoApellido = Me.LoadApeMat
                    .PreNombres = Me.LoadNombres
                    .InternoAlias = Me.LoadNombresAlias
                    .IDRegion = Me.LoadRegion
                    .IDPenal = Me.LoadPenal
                    .IDPenalString = Me.LoadPenalMult
                    .IDSexo = Me.LoadSexo
                    .NacionalidadExtranjero = Me.LoadExtranjero
                    .IDNacionalidad = Me.LoadNacionalidadPais
                    .IDInternoEstado = Me.LoadEstado
                    '/*delito*/
                    .IDDelitoGenerico = Me.LoadDelGen
                    .IDDelitoEspecifico = Me.LoadDelEsp
                    '/*ingreso*/
                    .FechaIngresoIni = Me.LoadFechaIni
                    .FechaIngresoFin = Me.LoadFechaFin
                    .IDSituacionJuridica = Me.LoadSitJur
                End With
                objEntCol = objBss.Listar_v5(objEntFiltro)

                Return True
            End If

        End Function

        Private Sub Buscar()


            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            FiltroActual = ConcatenarFiltro()

            CodigoPenalMultiple()

            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0
            Me.lblSegundo.Text = "00:00:00"
            Me.lblSegundo.Refresh()

            LoadPropiedades()
            Me.IngresoNumero = ""
            Me.IngresoFecha = ""
            Me.IngresoSituacionJuridica = ""
            Me.TipoEgreso = ""
            Me.EgresoFecha = ""

            Me.SuspendLayout()

            'If Me.BackgroundWorker1.IsBusy Then Exit Sub
            Me.BackgroundWorker1.RunWorkerAsync()

            frmLoad = New Load.frmLoad
            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackgroundWorker1.CancelAsync()
                Me.BackgroundWorker1.Dispose()
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            ColumnasVisible()

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

        Private Function ConcatenarFiltro() As String
            Dim objLista As New ArrayList
            'texto
            objLista.Add(Me.CodigoRP)
            objLista.Add(Me.ApellidoPaterno)
            objLista.Add(Me.ApellidoMaterno)
            objLista.Add(Me.Nombres)
            'combos
            objLista.Add(Me.RegionID)
            objLista.Add(Me.PenalID)
            'radio buton
            objLista.Add(Me.Estado)
            objLista.Add(Me.Sexo)
            'fecha
            Dim FiltroConcatenado As String = ""
            For Each obj As String In objLista
                FiltroConcatenado &= FiltroConcatenado & obj
            Next
            Return FiltroConcatenado
        End Function

        Private Sub ListarInternoResumen()

            If Me.GrillaInternoID < 1 Or pnlResumenInterno.Visible = False Then
                Exit Sub
            End If

            Dim obBssIngreso As New Bussines.Registro.Ingreso
            Dim objEntIngreso As New Entity.Registro.Ingreso
            objEntIngreso.InternoID = Me.GrillaInternoID
            objEntIngreso = obBssIngreso.ListarResumen(objEntIngreso)

            With objEntIngreso
                Me.IngresoNumero = IIf(.IngresoNro < 1, 0, .IngresoNro)
                Me.IngresoFecha = .FechaIngresoDate
                Me.IngresoFecha = IIf(Me.IngresoFecha = "", "NO REGISTRA", Me.IngresoFecha)
                Me.IngresoSituacionJuridica = .SituacionJuridicaNombre
                Me.TipoEgreso = IIf(.MovimientoNombre = "", "NO REGISTRA", .MovimientoNombre)
                Me.EgresoFecha = .FechaLibertadDate
                Me.EgresoFecha = IIf(Me.EgresoFecha = "", "NO REGISTRA", Me.EgresoFecha)
            End With

        End Sub

        Private Sub ShowFotografia()

            If Me.UscFotografia_2v1._CheckImagen = False Or Me.GrillaInternoID < 1 Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            If Me.IdInternoSelectFotografia = Me.GrillaInternoID And Me.UscFotografia_2v1._HasImagen = True And Me.PerfilFotografia = PerfilActual Then
                'nada
            Else

                Me.UscFotografia_2v1._showFotoInternoPrincipal(Me.GrillaInternoID, Me.PerfilFotografia)
                Me.PerfilActual = Me.PerfilFotografia
                Me.IdInternoSelectFotografia = Me.GrillaInternoID

                If UscFotografia_2v1._HasImagen = False Then
                    Me.UscFotografia_2v1._Limpiar()
                    Me.IdInternoSelectFotografia = -1
                End If

            End If

        End Sub

#End Region
#Region "Accion"
        Private Sub ALimpiar()

            Me.CodigoRP = ""
            Me.ApellidoPaterno = ""
            Me.ApellidoMaterno = ""
            Me.Nombres = ""

            Me.Sexo = -1 'todos

            Me.txtApePat.Focus()

        End Sub

#End Region
#Region "Form"

        Private Sub FRM_MantenimientoV2(idInterno As Integer, idPenal As Short)
            Dim AmbitoPenalLM As Boolean = False


            Select Case (New Bussines.Sistema.Instalacion).Listar(Me.IDLicencia).Tipo
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia, Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaProvincia, Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    AmbitoPenalLM = False
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana ', Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    AmbitoPenalLM = True
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    If idPenal > 0 Then
                        Dim l As Integer = (New General.Penal).Listar_v2(idPenal).PenalTipoLicenciaId
                        Select Case l
                            Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                                AmbitoPenalLM = False
                            Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                                AmbitoPenalLM = True
                        End Select
                    Else
                        AmbitoPenalLM = True
                    End If
            End Select

            If AmbitoPenalLM Then
                Dim frm As New Tratamiento.Asistencia.Clasificacion.Penal.frmMantClasifPenalLM(idInterno, IdRegion, idPenal, RegionNombre, PenalNombre)
                frm.MdiParent = Me.MdiParent
                With frm
                    'permisos
                    ._FormLectura = Me._FormLectura
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar

                    ._frmLectura = Me._frmLectura
                    ._frmEscritura = Me._frmEscritura
                    ._frmReporte = Me._frmReporte
                    ._frmImpresion = Me._frmImpresion
                    ._frmEliminar = Me._frmEliminar
                    .Show()
                End With
            Else
                Dim frm As New Tratamiento.Asistencia.Clasificacion.Penal.frmMantClasifPenalProv_v2(idInterno, IdRegion, idPenal, RegionNombre, PenalNombre)
                frm.MdiParent = Me.MdiParent
                With frm
                    'permisos
                    ._FormLectura = Me._FormLectura
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar

                    ._frmLectura = Me._frmLectura
                    ._frmEscritura = Me._frmEscritura
                    ._frmReporte = Me._frmReporte
                    ._frmImpresion = Me._frmImpresion
                    ._frmEliminar = Me._frmEliminar
                    .Show()
                End With
            End If

        End Sub

#End Region
#Region "Otros"

        Private Sub ValoresxDefault()

            Select Case Legolas.Configuration.Usuario.OficinaID
                Case 1 'osin
                    '
                Case Else
                    Me.lblSegundo.Visible = False
            End Select

            ComboRegion()
            ComboPenal()

            dgwGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dgwGrilla.VisibleCampos = True

        End Sub

        Private Sub ValidarFiltro()

            FiltroNuevo = ConcatenarFiltro()
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
#Region "Usuario/Permisos"

        Private Sub UsuarioPermisos_v2(ByRef blnCerrarForm As Boolean)

            Dim intTipoLicencia As Short
            Dim objBssInst As New Bussines.Sistema.Instalacion
            intTipoLicencia = objBssInst.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            Select Case intTipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Modulo [Registro Penal] no está disponible para Carceleta de Lima")
                    blnCerrarForm = True
                    Me.Close()
                    Exit Sub
                Case Else
                    'pasa en la sede, en los penales de provincias y la sede regionales
            End Select


            Dim intLicenciaID As Integer = Configuracion.Licencia.Codigo

            Dim blnEscritura As Boolean
            Dim blnReporte As Boolean
            Dim blnElimnarTab As Boolean

            Select Case intTipoLicencia
                'Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaProvincia, Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia, Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                    Dim obj As Entity.Sistema.Seguridad.Usuario = Permisos._FormPermisosRegistro(Legolas.Configuration.Usuario.Codigo, Type.Enumeracion.Modulo.enmModulo.RegistroProvinciaV2, intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
                    blnEscritura = obj.FormEscritura
                    Me._FormEliminar = obj.FormEliminacion
                    blnReporte = obj.FormReporte

                Case Else
                    blnEscritura = Permisos._FormEscrituraRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
                    Me._FormEliminar = Permisos._FormEliminarRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
                    blnReporte = Permisos._FormReporteRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            End Select
            'permisos de tratamiento            
            blnElimnarTab = Permisos._FormEscrituraTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)

            If blnElimnarTab = True Then
                blnEscritura = False
                blnReporte = False
            End If

            Me._FormEscritura = blnEscritura
            Me._FormReporte = blnReporte




            Dim objEntUsuarioModuloCol As Legolas.LEntity.Seguridad.UsuarioModuloCol = (New Legolas.LBusiness.Seguridad.UsuarioModulo).Listar(Legolas.Configuration.Usuario.Codigo, -1, ModuloID)

            If objEntUsuarioModuloCol IsNot Nothing AndAlso objEntUsuarioModuloCol.Count = 1 Then

                Me._frmLectura = objEntUsuarioModuloCol.Item(0).Lectura
                Me._frmEscritura = objEntUsuarioModuloCol.Item(0).Escritura
                Me._frmReporte = objEntUsuarioModuloCol.Item(0).Reporte
                Me._frmImpresion = objEntUsuarioModuloCol.Item(0).Impresion
                Me._frmEliminar = objEntUsuarioModuloCol.Item(0).Eliminar

            End If
        End Sub
#End Region
        Private Sub FrmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()
            Me.IDLicencia = Legolas.LBusiness.Globall.WinApp.LicenciaApp
        End Sub

        Private Sub TsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub DgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            Me.Cursor = Cursors.WaitCursor

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                FRM_MantenimientoV2(Me.GrillaInternoID, Me.GrillaPenalID)
            End If

            Me.Cursor = Cursors.Default

        End Sub
        Private Sub TxtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtCodInterno.KeyPress,
        txtApePat.KeyPress,
        txtApeMat.KeyPress,
        txtNom.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub CbbuscRegion__ValueChanged() Handles cbbRegion._SelectedIndexChanged
            Me.ComboPenal()
        End Sub

        Private Sub CbbuscPenal__ValueChanged() Handles cbbPenal._SelectedIndexChanged
            ColumnasVisible()
        End Sub

        Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            If Me.dgwGrilla.RowCount > 0 Then
                FRM_MantenimientoV2(Me.GrillaInternoID, Me.GrillaPenalID)
            End If

        End Sub
        Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub BackgroundWorker1_Disposed(sender As Object, e As System.EventArgs) Handles BackgroundWorker1.Disposed

            If Me.BackgroundWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker1 = Nothing
                Me.Close()
            End If

        End Sub
        Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
            Else
                e.Result = Listar(worker, e)
            End If

        End Sub
        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            'frmLoad.Dispose()

            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()

                ' procesa el resultado del metodo ping        
            End If

        End Sub
        Private Sub FrmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Dim blnCerrar As Boolean = False
            UsuarioPermisos_v2(blnCerrar)

        End Sub
        Private Sub DgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_nac").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                            'e.Value = DateTime.FromFileTime(e.Value).ToShortDateString
                        Else
                            e.Value = ""
                        End If

                End Select
            End With


        End Sub

        Private Sub DgwGrilla_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrilla.RowPrePaint

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

        Private Sub RdbPI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rdbPI.Click, rdbPF.Click, rdbPD.Click

            ShowFotografia()

        End Sub

        Private Sub RdbActivo_Click(sender As Object, e As System.EventArgs) _
            Handles rdbActivo.Click,
            rdbInactivo.Click,
            rdbEstadoTodos.Click
            ColumnasVisible()
        End Sub
        Private Sub DgwGrilla_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick, dgwGrilla.CellEnter
            ShowFotografia()
            ListarInternoResumen()
        End Sub

        Private Sub TsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click
            ALimpiar()
        End Sub
        Private Sub TxtCodInterno_TextChanged(sender As System.Object, e As System.EventArgs) Handles _
            txtCodInterno.TextChanged,
            txtApePat.TextChanged,
            txtApeMat.TextChanged,
            txtNom.TextChanged

            ValidarFiltro()

        End Sub

        Private Sub UscFotografia_2v1__CheckClick() Handles UscFotografia_2v1._CheckClick
            ShowFotografia()
        End Sub


    End Class
End Namespace
