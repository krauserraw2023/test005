Imports System.ComponentModel

Namespace Registro.Penal.Busqueda
    Public Class frmBuscar_v2
        Private objBss As Bussines.Registro.Interno = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing
        Private entMovCol As Entity.Registro.InternoMovimientoCol
        Private frmLoad As Load.frmLoad = Nothing
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim value As Integer = -1
                Try

                    Select Case Me.tcBusqueda.SelectedTab.Name
                        Case Me.tpConsultaInterno.Name
                            With Me.dgwGrilla
                                value = .SelectedRows(0).Cells("col_int_id").Value
                            End With

                        Case Me.tpConsultaMovimiento.Name
                            value = Me.UscBusquedaMovimiento1._IDInternoSelect

                        Case Me.tpConsultaConsReclu.Name

                            If Me.UscConsultaTramite1._count > 0 Then
                                value = Me.UscConsultaTramite1._grillaIdInterno()
                            End If

                    End Select

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
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_ape").Value
                    End With
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
        Private ReadOnly Property grillaApeNom As String
            Get
                Dim value As String = ""

                value = GrillaApellidos + ", " + GrillaNombres
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

                    Select Case Me.tcBusqueda.SelectedTab.Name
                        Case tpConsultaInterno.Name
                            With Me.dgwGrilla
                                value = .SelectedRows(0).Cells("col_pen_id").Value
                            End With

                        Case tpConsultaMovimiento.Name

                            value = Me.UscBusquedaMovimiento1.GrillaPenalID

                        Case tpConsultaConsReclu.Name
                            value = Me.UscConsultaTramite1._grillaIdPenal

                    End Select

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
        Private Property idInternoSelectFotografia As Integer = -1

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
        Private Property NombresAlias() As String
            Get
                Return Me.txtAlias.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtAlias.Text = value
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
        Private Property DelitoGenericoID() As Integer
            Get
                Return Me.cbbDelitoGenerico.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDelitoGenerico.SelectedValue = value
            End Set
        End Property
        Private Property DelitoEspecificoID() As Integer
            Get
                Return Me.cbbDelitoEspecifico.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDelitoEspecifico.SelectedValue = value
            End Set
        End Property
        Private Property SituacionJuridicaID() As Integer
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
        Private Property IngresoFechaDesde() As Long
            Get
                Return Me.dtpFechaIni.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaIni.ValueLong = value
            End Set
        End Property
        Private Property IngresoFechaHasta() As Long
            Get
                Return Me.dtpFechaFin.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaFin.ValueLong = value
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
        Private Property NacionalidadPais() As Integer
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
                'Select Case Me.NacionalidadExtranjero
                '    Case 2
                Me.cbbNacionalidad.SelectedValue = value
                '    Case Else
                '        Me.cbbNacionalidad.SelectedValue = -1
                'End Select

            End Set
        End Property

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
        Private Property idRegion As Short = -1
        Private Property idPenal As Short = -1
        Private Property regionNombre As String = ""
        Private Property penalNombre As String = ""
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
        Private Sub ComboDelitoEspecifico()

            With Me.cbbDelitoEspecifico
                '.DropDownWidth = .Width + 150
                ._Todos = True
                .CodigoPadre = Me.DelitoGenericoID
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboDelitoGenerico()

            With Me.cbbDelitoGenerico
                '.DropDownWidth = .Width + 150
                ._Todos = True
                .LoadUsc()
            End With

        End Sub
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
        Private Sub Combo()

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
            If tcBusqueda.SelectedTab.Name = tpConsultaInterno.Name Then
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

            'validar que el tener la opcion todos ingrese un dato
            If Me.RegionID < 1 Then
                If (Me.ApellidoPaterno.Length < 3) And (Me.ApellidoMaterno.Length < 3) And Me.CodigoRP.Length < 5 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese algun apellido o codigo, para realizar la busqueda")
                    Me.txtApePat.Focus()
                    Return value
                End If
            End If

            'validar fecha
            If Me.IngresoFechaDesde > 0 Or Me.IngresoFechaHasta > 0 Then

                'fecha ingreso
                If Me.IngresoFechaDesde < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha inicio")
                    Me.dtpFechaIni.Focus()
                    Return value
                End If

                'fecha fin
                If Me.IngresoFechaHasta < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha fin")
                    Me.dtpFechaFin.Focus()
                    Return value
                End If

                'fecha fin < fecha ini
                If Me.IngresoFechaHasta < Me.IngresoFechaDesde Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin, no puede ser menor que la fecha de inicio")
                    Me.dtpFechaIni.Focus()
                    Return value
                End If
            End If

            'delito especifico
            If Me.DelitoGenericoID = -1 Then
                If Me.DelitoEspecificoID > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Primero seleccione el delito generico")
                    Me.cbbDelitoGenerico.Focus()
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
                Dim strCadena As String = ""

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

            Dim strValue As String = ""

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
            LoadNombresAlias = Me.NombresAlias
            LoadSexo = Me.Sexo
            LoadExtranjero = Me.NacionalidadExtranjero
            LoadNacionalidadPais = Me.NacionalidadPais
            LoadDelGen = Me.DelitoGenericoID
            LoadDelEsp = Me.DelitoEspecificoID
            LoadSitJur = Me.SituacionJuridicaID
            LoadFechaIni = Me.IngresoFechaDesde
            LoadFechaFin = Me.IngresoFechaHasta
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
            BarraEstado()

        End Sub

        Private Sub BuscarMovimientos()

            'CodigoPenalMultiple()

            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0

            Me.lblSegundo.Text = "00:00:00"
            Me.lblSegundo.Refresh()

            With UscBusquedaMovimiento1
                ._IDRegion = Me.RegionID
                ._IDPenal = Me.PenalID
                ._Buscar()
                Me.NumeroReg = ._GrillaCount
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
            objLista.Add(Me.cbbNacionalidad.SelectedValue)
            objLista.Add(Me.DelitoGenericoID)
            objLista.Add(Me.DelitoEspecificoID)
            'radio buton
            objLista.Add(Me.Estado)
            objLista.Add(Me.NacionalidadExtranjero)
            objLista.Add(Me.SituacionJuridicaID)
            objLista.Add(Me.Sexo)
            'fecha
            objLista.Add(Me.IngresoFechaDesde)
            objLista.Add(Me.IngresoFechaHasta)
            Dim FiltroConcatenado As String = ""
            For Each obj As String In objLista
                FiltroConcatenado = FiltroConcatenado & obj
            Next
            Return FiltroConcatenado
        End Function

        Private Sub listarInternoResumen()

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

            If Me.idInternoSelectFotografia = Me.GrillaInternoID And Me.UscFotografia_2v1._HasImagen = True And Me.PerfilFotografia = PerfilActual Then
                'nada
            Else

                Me.UscFotografia_2v1._showFotoInternoPrincipal(Me.GrillaInternoID, Me.PerfilFotografia)
                Me.PerfilActual = Me.PerfilFotografia
                Me.idInternoSelectFotografia = Me.GrillaInternoID

                If UscFotografia_2v1._HasImagen = False Then
                    Me.UscFotografia_2v1._Limpiar()
                    Me.idInternoSelectFotografia = -1
                End If

            End If

        End Sub

        Private Sub BuscarEmisionAnteJudi()

            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0

            Me.lblSegundo.Text = "00:00:00"
            Me.lblSegundo.Refresh()

            With UscEmisionAntecedentes1
                ._IDRegion = Me.RegionID
                ._IDPenal = Me.PenalID
                ._Buscar()
                Me.NumeroReg = ._GrillaCount
            End With

            Dim dteFechaFin As Date = Now

            intSeg = DateDiff(DateInterval.Second, dteFechaIni, dteFechaFin)
            Me.lblSegundo.Text = intSeg.ToString("00:00:00")

        End Sub
        Private Sub listarUscTramiteConstanciaReclusion()

            Me.UscConsultaTramite1._loadUsc(Configuracion.Licencia.Codigo, False)

        End Sub
#End Region
#Region "Accion"
        Private Sub AEliminar()
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                objBss = New Bussines.Registro.Interno

                'objBss.Eliminar(Me.GrillaInternoID)
                objBss.ActualizarEstadoBaja(Me.GrillaInternoID)
                Buscar()
            End If

        End Sub
        Private Sub ACorregirCodigo()

            Select Case Configuracion.Licencia.Codigo
                Case 1
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                   "Esta opcion, solo esta valida para provincias")
                Case Else
                    Dim strMensaje As String = ""

                    strMensaje = "Desea corregir los codigos duplicados relacionados con este codigo : " & Me.GrillaInternoCodigo
                    strMensaje = strMensaje & Chr(13)
                    strMensaje = strMensaje & "Los codigos duplicados se eliminaran, asi como tambien las fotos asiganadas al codigo."
                    strMensaje = strMensaje & Chr(13)
                    strMensaje = strMensaje & "Desea aplicar los cambios de todas maneras."

                    If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = Windows.Forms.DialogResult.Yes Then
                        Bussines.Registro.Interno.ResetInternoCodigo(Me.GrillaInternoCodigo, Me.RegionID, Me.PenalID)
                        Buscar()
                    End If
            End Select

        End Sub
        Private Sub ALimpiar()

            Me.CodigoRP = ""
            Me.ApellidoPaterno = ""
            Me.ApellidoMaterno = ""
            Me.Nombres = ""
            Me.NombresAlias = ""
            Me.NacionalidadExtranjero = -1 'todos
            Me.Sexo = -1 'todos
            Me.SituacionJuridicaID = -1
            Me.IngresoFechaDesde = 0
            Me.IngresoFechaHasta = 0
            Me.DelitoGenericoID = -1
            Me.DelitoEspecificoID = -1

            Me.txtApePat.Focus()

        End Sub

        Private Sub ALimpiarMov()
            UscBusquedaMovimiento1._Limpiar()
        End Sub

        Private Sub ALimpiarEmisionAnteJudi()
            UscEmisionAntecedentes1._Limpiar()
        End Sub
#End Region
#Region "Form"
        Private Sub frmCRTramiteNuevo(idInterno As Integer)

            Dim idRegion As Short = Me.GrillaRegionID
            Dim idPenal As Short = Me.GrillaPenalID

            If idInterno < 1 Or idRegion < 1 Or idPenal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Interno")
                Exit Sub
            End If

            Dim abrirForm As Boolean = False

            Dim frm As New Registro.ConstanciaReclusion.frmTramite(-1, idInterno, idRegion, idPenal,
                Me.GrillaInternoCodigo, Me.grillaApeNom, Me.GrillaRegionNombre, Me.GrillaPenalNombre, abrirForm,
                Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia)

            If abrirForm = True Then

                Me.tcBusqueda.SelectedTab = tpConsultaConsReclu

                frm._FormEscritura = Me._FormEscritura
                frm._FormEliminar = Me._FormEliminar
                frm._FormReporte = Me._FormReporte
                frm._verDetalleInterno = True

                If frm.ShowDialog() = DialogResult.OK Then
                    Me.Cursor = Cursors.WaitCursor
                    FRM_MantenimientoV2(False, frm._getIdInternoVerDetalle, frm._getIdPenal)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                If frm._getActualizoDatos = True Then
                    Me.UscConsultaTramite1._buscar()
                End If
            Else
                Me.tcBusqueda.SelectedTab = tpConsultaInterno
            End If

        End Sub
        Private Sub frmCRTramiteModificar(idTramite As Integer)

            Dim frm As New Registro.ConstanciaReclusion.frmTramite(idTramite, Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia)
            frm._FormEscritura = Me._FormEscritura
            frm._FormEliminar = Me._FormEliminar
            frm._FormReporte = Me._FormReporte
            frm._verDetalleInterno = True

            If frm.ShowDialog() = DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor
                FRM_MantenimientoV2(False, frm._getIdInternoVerDetalle, frm._getIdPenal)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            If frm._getActualizoDatos = True Then
                Me.UscConsultaTramite1._buscar()
            End If

        End Sub
        Private Sub FRM_NuevoInterno()

            Dim blnOK As Boolean = False
            Dim blnOKReniec As Boolean = False
            Dim intIDInternoSelecionado As Long = -1

            Dim frm As New Registro.Penal.Busqueda.v5.frmBuscaIntSedeCentralPopup
            Dim tipoAccion As Registro.Penal.Busqueda.v5.frmBuscaIntSedeCentralPopup.enmTipoAccion

            With frm
                ._IDPenal = Me.PenalID
                ._IDRegion = Me.RegionID
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    intIDInternoSelecionado = ._IDInternoSelecionado
                    tipoAccion = ._TipoAccion
                    blnOK = True
                End If
            End With

            If blnOK = True Then
                Me.idRegion = Me.RegionID
                Me.regionNombre = cbbRegion.Text
                Me.idPenal = Me.PenalID
                Me.penalNombre = cbbPenal.Text

                Select Case tipoAccion
                    Case Registro.Penal.Busqueda.v5.frmBuscaIntSedeCentralPopup.enmTipoAccion.SIGUIENTE_OPCION_RENIEC

                        Dim f2 As New Registro.Main.Carceleta.frmTipoNacionalidad
                        If f2.ShowDialog = Windows.Forms.DialogResult.OK Then
                            If f2._ValidarConReniec = True Then
                                blnOKReniec = True
                            Else
                                FRM_MantenimientoV2(True, -1, Me.idPenal)
                            End If
                        End If

                    Case Registro.Penal.Busqueda.v5.frmBuscaIntSedeCentralPopup.enmTipoAccion.IMPORTAR_REGISTRO_SEDE
                        FRM_MantenimientoV2(True, intIDInternoSelecionado, Me.idPenal)

                    Case Registro.Penal.Busqueda.v5.frmBuscaIntSedeCentralPopup.enmTipoAccion.REGISTRO_EXISTENTE
                        FRM_MantenimientoV2(False, intIDInternoSelecionado, Me.idPenal)

                    Case Registro.Penal.Busqueda.v5.frmBuscaIntSedeCentralPopup.enmTipoAccion.REGISTRO_MANUAL
                        FRM_MantenimientoV2(True, -1, Me.idPenal)
                End Select
            End If

            If blnOKReniec = True Then
                Dim f3 As New Registro.Main.Carceleta.frmBuscaReniecPopup
                f3._RegionId = Me.RegionID
                f3._PenalId = Me.PenalID
                If f3.ShowDialog = Windows.Forms.DialogResult.OK Then

                    Select Case f3._tipoAccion
                        Case Registro.Main.Carceleta.frmBuscaReniecPopup.enmAccion.NUEVO_INTERNO_DESDE_RENIEC
                            FRM_MantenimientoV2(False, f3._IdInterno, Me.idPenal)

                        Case Registro.Main.Carceleta.frmBuscaReniecPopup.enmAccion.NUEVO_INTERNO_SIN_RENIEC '  frmBuscaReniecPopup.enmAccion.NUEVO_INTERNO_SIN_RENIEC
                            FRM_MantenimientoV2(True, -1, Me.idPenal)
                    End Select
                End If
            End If
        End Sub

        'Private Sub FRM_Mantenimiento(ByVal Nuevo As Boolean, intIDInterno As Integer, intIDPenal As Integer)

        '    If Legolas.Configuration.Usuario.Login = "USR0023" Then
        '        FRM_MantenimientoV2(Nuevo, intIDInterno, intIDPenal)
        '        Exit Sub
        '    End If

        '    Dim frm As New Registro.Penal.Busqueda.frmMant
        '    frm.MdiParent = Me.MdiParent
        '    With frm
        '        If Nuevo = True Then
        '            .InternoID = -1
        '            .RegionID = Me.InternoRegion
        '            .RegionNombre = Me.InternoRegionNombre
        '            .PenalID = Me.InternoPenal
        '            .PenalNombre = Me.InternoPenalNombre
        '        Else
        '            If intIDInterno < 1 Then
        '                Exit Sub
        '            End If
        '            .InternoID = intIDInterno
        '            .PenalID = If(UscBusquedaMovimiento1._TipoBusqueda = False, intIDPenal, UscBusquedaMovimiento1.GrillaPenalID)
        '        End If
        '        'permisos
        '        ._FormLectura = Me._FormLectura
        '        ._FormEscritura = Me._FormEscritura
        '        ._FormReporte = Me._FormReporte
        '        ._FormImpresion = Me._FormImpresion
        '        ._FormEliminar = Me._FormEliminar
        '        .Show()
        '    End With

        'End Sub
        Private Sub FRM_MantenimientoV2(ByVal nuevo As Boolean, idInterno As Integer, idPenal As Short)

            If nuevo = True Then
                idInterno = -1
            Else
                If idInterno < 1 Then
                    Exit Sub
                End If
            End If

            Dim frm As New Registro.Penal.Busqueda.frmMant_v2(idInterno, idRegion, idPenal, regionNombre, penalNombre)
            frm.MdiParent = Me.MdiParent
            With frm
                'permisos
                ._FormLectura = Me._FormLectura
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormImpresion = Me._FormImpresion
                ._FormEliminar = Me._FormEliminar
                .Show()
            End With

        End Sub

        Private Sub FRM_Ver_Reportes()

            Dim intIDRegion As Short = Me.RegionID
            Dim intIDPenal As Short = Me.PenalID

            Dim frm As New Registro.Reporte.frmReportePopupv2
            With frm

                If Me.RegionID < 1 Then
                    intIDRegion = Me.GrillaRegionID
                End If

                If Me.PenalID < 1 Then
                    intIDPenal = Me.GrillaPenalID
                End If

                ._RegionID = intIDRegion
                ._PenalID = intIDPenal
                ._InternoID = Me.GrillaInternoID
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                ._InternoApeNom = Me.GrillaApellidos & " " & Me.GrillaNombres
                ._TipoReporte = Reporte.frmReportePopupv2.enmListarReportes.Todos
                .ShowDialog()
            End With

        End Sub
        Private Sub frmCRVerReporte()

            Dim frm As New Registro.ConstanciaReclusion.frmReporte(Configuracion.Licencia.Codigo, False)
            With frm
                .ShowDialog()
            End With

        End Sub
        Private Sub FRM_MantEmisionAntecedente(blnNuevo As Boolean, intCodigo As Integer, intIDTipoCertAntecedente As Short)

            Dim blnOK As Boolean = False
            Dim blnBuscar As Boolean = False

            'si el antecedentes es nuevo
            If blnNuevo = True Then
                intCodigo = -1
                Dim frm As New Registro.Main.Antecedentes.frmTipoCertAntecedente
                With frm
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        intIDTipoCertAntecedente = ._TipoAntecedente
                        blnOK = True
                    End If
                End With
            Else
                blnOK = True

                If intCodigo < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el registro a modificar")
                    Exit Sub
                End If

            End If

            If blnOK = True Then
                Dim frm2 As New Registro.Penal.Antecedentes.frmMantPopup
                With frm2
                    ._Codigo = intCodigo
                    ._TipoAntecedenteId = intIDTipoCertAntecedente
                    ._IDRegion = Me.RegionID
                    ._IDPenal = Me.PenalID
                    ._RegionNombre = Me.cbbRegion.Text
                    ._PenalNombre = Me.cbbPenal.Text

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        blnBuscar = True
                    Else
                        blnBuscar = ._Finalizado
                    End If
                End With
            End If

            'If blnBuscar = True Then
            '    Dim fila As Integer = dgwGrillaCAJ.CurrentRow.Index
            '    BuscarCAJ()
            '    Try
            '        dgwGrillaCAJ.Rows(fila).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
            '        dgwGrillaCAJ.CurrentCell = dgwGrillaCAJ.Rows(fila).Cells("col_tip_caj")
            '    Catch ex As Exception
            '    End Try
            'End If

        End Sub

        Private Sub FRM_Reporte_AnteJudi()

            If Me.UscEmisionAntecedentes1.GrillaCount = 0 Then Exit Sub
            If Me.UscEmisionAntecedentes1.GrillaEstadoCAJ = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Pendiente Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro se encuentra en estado pendiente, para continuar es necesario finalizar el registro.")
                Exit Sub
            End If

            Dim intCodigo As Integer = Me.UscEmisionAntecedentes1.GrillaIDCodigo
            Dim intTipoCerti As Integer = Me.UscEmisionAntecedentes1.GrillaTipoCertificado

            Dim frm As New APPReporte.Registro.ReporteCrystal_v2
            With frm
                Select Case intTipoCerti
                    Case 1
                        ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudNegativo_v1

                    Case 2
                        ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudNoPPPMD_v1

                    Case 3
                        ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudSiPPPMD_v1

                    Case 4
                        ._ReporteId = Type.Reporte.Registro.rpt_tupa_v0
                End Select
                ._Filtro.Text = Me.Text
                ._Filtro.DocSolicitudAntecedenteId = intCodigo
                ._Filtro.RegionID = Me.UscEmisionAntecedentes1.GrillaIDRegion
                ._Filtro.RegionNombre = Me.UscEmisionAntecedentes1.GrillaRegionNombre
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarNacionaliadPais()

            Select Case Me.NacionalidadExtranjero
                Case 2 'extranjero
                    Me.cbbNacionalidad.Enabled = True
                Case Else
                    Me.NacionalidadPais = -1
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

            ComboRegion()
            ComboPenal()
            Combo()

            ComboDelitoGenerico()
            ComboDelitoEspecifico()
            dgwGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dgwGrilla.VisibleCampos = True
            UscBusquedaMovimiento1._LoadUsc()
            listarUscTramiteConstanciaReclusion()

        End Sub
        Private Sub BarraEstado()

            'Dim strMensaje As String = "Status"
            'Dim strMensajeError As String = ""
            'Me.StatusStrip1.Visible = False

            'If Me.PenalID > 0 Then
            '    Dim objBss As New Bussines.Transferencia.ArchivoInfo2
            '    Dim objEntCol As New Entity.Transferencia.ArchivoInfo2Col
            '    Dim objEnt As New Entity.Transferencia.ArchivoInfo2

            '    objEntCol = objBss.Listar(Me.RegionID, Me.PenalID, strMensajeError)

            '    If objEntCol Is Nothing Then Exit Sub
            '    If objEntCol.Count > 0 Then

            '        objEnt = objEntCol.ArchivoInfo(0)
            '        With objEnt
            '            strMensaje = "Datos de la ultima Transferencia ("
            '            strMensaje = strMensaje & "Numero : " & .ArchivoNumero
            '            strMensaje = strMensaje & " | Fecha : " & .ArchivoFechaHoraDate
            '            strMensaje = strMensaje & " | Total Internos : " & .TotalInternos
            '            strMensaje = strMensaje & ")"
            '            If .ArchivoNumero = 0 Then strMensaje = ""
            '        End With
            '    End If

            '    Me.StatusStrip1.Visible = True
            '    Me.ToolStripStatusLabel1.Text = strMensaje
            'End If

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
        Private Sub UsuarioPermisos(ByRef blnCerrarForm As Boolean)

            Dim intTipoLicencia As Short = -1
            Dim objBssInst As New Bussines.Sistema.Instalacion
            intTipoLicencia = objBssInst.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            Select Case intTipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Modulo [Registro Penal] no está disponible en los Establecimientos Penitenciarios de LimaMetropolitana")
                    blnCerrarForm = True
                    Me.Close()
                    Exit Sub
                Case Else
                    'pasa en la sede, en los penales de provincias y la sede regionales
            End Select

            Dim intLicenciaID As Integer = Configuracion.Licencia.Codigo

            Dim blnEscritura As Boolean = Me._FormEscritura
            Dim blnReporte As Boolean = Me._FormReporte
            Dim blnElimnarTab As Boolean = False

            Select Case intTipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                    ''/*Implementacion 03112022*/
                    Dim obj As Entity.Sistema.Seguridad.Usuario = Permisos._FormPermisosRegistro(Legolas.Configuration.Usuario.Codigo, Type.Enumeracion.Modulo.enmModulo.RegistroProvinciaV2, intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
                    blnEscritura = obj.FormEscritura
                    Me._FormEliminar = obj.FormEliminacion
                    blnReporte = obj.FormReporte
                Case Else
                    'blnLecturaRegistro = Permisos._FormLecturaRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
                    blnEscritura = Permisos._FormEscrituraRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
                    Me._FormEliminar = Permisos._FormEliminarRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
                    blnReporte = Permisos._FormReporteRegistro(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            End Select
            'permisos de tratamiento            
            blnElimnarTab = Permisos._FormEscrituraTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)

            If blnElimnarTab = True Then
                Me.tcBusqueda.TabPages.Remove(Me.tpConsultaMovimiento)
                Me.tcBusqueda.TabPages.Remove(Me.tpEmisionAntec)
                Me.btnVerLibros.Visible = False
                blnEscritura = False
                blnReporte = False
            End If

            Me.pnlBotonGrabar.Visible = blnEscritura
            Me.pnlBotonReporte.Visible = blnReporte
            Me.tcBusqueda.TabPages.Remove(Me.tpEmisionAntec) 'temporal hasta hacer el pase a produccion

            Me._FormEscritura = blnEscritura
            Me._FormReporte = blnReporte

        End Sub
#End Region
        Private Sub frmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()

        End Sub
        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

            Select Case Me.tcBusqueda.SelectedTab.Name

                Case Me.tpConsultaInterno.Name
                    Buscar()

                Case Me.tpConsultaMovimiento.Name
                    BuscarMovimientos()

                Case Me.tpConsultaConsReclu.Name
                    Me.UscConsultaTramite1._buscar()
                    Me.NumeroReg = Me.UscConsultaTramite1._count

                Case Me.tpEmisionAntec.Name
                    BuscarEmisionAnteJudi()
            End Select

            BarraEstado()

        End Sub

        Private Sub dgwGrilla_CellContextMenuStripChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContextMenuStripChanged

        End Sub
        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            Me.Cursor = Cursors.WaitCursor

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                FRM_MantenimientoV2(False, Me.GrillaInternoID, Me.GrillaPenalID)
            End If

            Me.Cursor = Cursors.Default

        End Sub
        Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtCodInterno.KeyPress,
        txtApePat.KeyPress,
        txtApeMat.KeyPress,
        txtNom.KeyPress,
        txtAlias.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub
        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            If e.KeyCode = Keys.Delete Then
                AEliminar()
            End If

        End Sub
        Private Sub cbbuscRegion__ValueChanged() Handles cbbRegion._SelectedIndexChanged

            Me.ComboPenal()
        End Sub
        Private Sub cbbDelitoGenerico__ValueChanged() Handles cbbDelitoGenerico._SelectedIndexChanged

            ComboDelitoEspecifico()

        End Sub
        Private Sub cbbuscPenal__ValueChanged() Handles cbbPenal._SelectedIndexChanged

            ColumnasVisible()

        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

            Select Case Me.tcBusqueda.SelectedTab.Name

                Case Me.tpConsultaInterno.Name, Me.tpConsultaMovimiento.Name
                    FRM_NuevoInterno()

                Case Me.tpEmisionAntec.Name
                    FRM_MantEmisionAntecedente(True, -1, -1)
            End Select

        End Sub


        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Select Case Me.tcBusqueda.SelectedTab.Name

                Case Me.tpConsultaInterno.Name
                    FormatoGrillaColumnas()
                    Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

                Case Me.tpConsultaMovimiento.Name
                    Me.UscBusquedaMovimiento1._Exportar()

                Case Me.tpConsultaConsReclu.Name
                    Me.UscConsultaTramite1._exportar()

                Case Me.tpEmisionAntec.Name
                    Me.UscEmisionAntecedentes1._Exportar()
            End Select

        End Sub
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            Dim blnModificar As Boolean = False

            Select Case Me.tcBusqueda.SelectedTab.Name
                Case Me.tpConsultaInterno.Name

                    If Me.dgwGrilla.RowCount > 0 Then
                        blnModificar = True
                    End If

                Case Me.tpConsultaMovimiento.Name

                    If UscBusquedaMovimiento1._GrillaCount > 0 Then
                        blnModificar = True
                    End If

                Case Me.tpEmisionAntec.Name
                    blnModificar = False

                    Dim intCodigo As Integer = Me.UscEmisionAntecedentes1.GrillaIDCodigo
                    Dim intTipoCerti As Integer = Me.UscEmisionAntecedentes1.GrillaTipoCertificado

                    FRM_MantEmisionAntecedente(False, intCodigo, intTipoCerti)

            End Select

            If blnModificar = True Then
                FRM_MantenimientoV2(False, Me.GrillaInternoID, Me.GrillaPenalID)
            End If

        End Sub
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

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
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()
                result = e.Result
                ' procesa el resultado del metodo ping        
            End If

        End Sub
        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.WindowState = FormWindowState.Maximized
            Dim blnCerrar As Boolean = False
            UsuarioPermisos(blnCerrar)

        End Sub
        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

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
        Private Sub btnFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click

            Select Case Me.tcBusqueda.SelectedTab.Name

                Case Me.tpConsultaInterno.Name, Me.tpConsultaMovimiento.Name
                    FRM_Ver_Reportes()

                Case Me.tpConsultaConsReclu.Name
                    frmCRVerReporte()

                Case Me.tpEmisionAntec.Name
                    FRM_Reporte_AnteJudi()
            End Select

        End Sub
        Private Sub btnCorregirCod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            ACorregirCodigo()
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
            listarInternoResumen()
        End Sub

        Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click

            Select Case Me.tcBusqueda.SelectedTab.Name

                Case Me.tpConsultaInterno.Name
                    ALimpiar()

                Case Me.tpConsultaMovimiento.Name
                    ALimpiarMov()

                Case Me.tpConsultaConsReclu.Name
                    Me.UscConsultaTramite1._limpiarFiltros()

                Case Me.tpEmisionAntec.Name
                    ALimpiarEmisionAnteJudi()
            End Select

        End Sub
        Private Sub txtCodInterno_TextChanged(sender As System.Object, e As System.EventArgs) Handles _
            txtCodInterno.TextChanged,
            txtApePat.TextChanged,
            txtApeMat.TextChanged,
            txtNom.TextChanged,
            txtAlias.TextChanged

            ValidarFiltro()

        End Sub


        Private Sub cbbNacionalidad__SelectedIndexChanged() Handles _
            cbbNacionalidad._SelectedIndexChanged,
            cbbRegion._SelectedIndexChanged,
            cbbPenal._SelectedIndexChanged,
            cbbDelitoGenerico._SelectedIndexChanged,
            cbbDelitoEspecifico._SelectedIndexChanged

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

        Private Sub dtpFechaIni__ValueChanged() Handles _
            dtpFechaIni._ValueChanged,
            dtpFechaFin._ValueChanged

            ValidarFiltro()

        End Sub


        Private Sub UscFotografia_2v1__CheckClick() Handles UscFotografia_2v1._CheckClick

            ShowFotografia()

        End Sub

        Private Sub UscBusquedaMovimiento1__Grilla_CellDoubleClick() Handles UscBusquedaMovimiento1._Grilla_CellDoubleClick

            FRM_MantenimientoV2(False, Me.GrillaInternoID, Me.GrillaPenalID)

        End Sub

        Private Sub UscBusquedaMovimiento1__Grilla_CellEnter() Handles UscBusquedaMovimiento1._Grilla_CellEnter
            If UscBusquedaMovimiento1._GrillaCount > 0 Then
                ShowFotografia()
                listarInternoResumen()
            End If
        End Sub

        Private Sub UscBusquedaMovimiento1__Grilla_ValidarFiltro() Handles UscBusquedaMovimiento1._Grilla_ValidarFiltro
            Me.lblSegundo.Text = "00:00:00"
            Me.NumeroReg = 0
        End Sub

        Private Sub btnVerifHuella_Click(sender As System.Object, e As System.EventArgs)
            If Me.PenalID = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar un penal.")
                Exit Sub
            End If

            Dim f As New Registro.Busqueda.frmBusquedaPorHuella
            f.MdiParent = Me.MdiParent
            f._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
            f._RegionId = Me.RegionID
            f._PenalId = Me.PenalID
            f._NombrePenal = "E.P. " & cbbPenal.Text
            f.Show()
        End Sub

        Private Sub btnVerLibros_Click(sender As Object, e As EventArgs) Handles btnVerLibros.Click

            If Me.GrillaInternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el interno")
                Exit Sub
            End If

            Dim frm As New Registro.RegionLima.Resoluciones.frmListarLibros
            frm._InternoID = Me.GrillaInternoID
            frm._LicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
            frm.ShowDialog()

        End Sub

        Private Sub tcConsultaInternoMovimientos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcBusqueda.SelectedIndexChanged

            Dim visibleAnular As Boolean = False
            Dim strBotonReporte As String = "Reporte"
            Dim blnVerLeyendaEmiAntece As Boolean = False
            Me.pnlResumenInterno.Visible = False

            Select Case Me.tcBusqueda.SelectedTab.Name

                Case Me.tpConsultaInterno.Name

                    Me.pnlResumenInterno.Visible = True
                    Me.pnlBotonGrabar.Visible = Me._FormEscritura

                Case Me.tpConsultaMovimiento.Name
                    Me.pnlBotonGrabar.Visible = False

                Case Me.tpConsultaConsReclu.Name
                    Me.pnlBotonGrabar.Visible = False
                    Me.UscConsultaTramite1._buscar()

                Case Me.tpEmisionAntec.Name
                    visibleAnular = True
                    strBotonReporte = "Im&primir"
                    blnVerLeyendaEmiAntece = True

            End Select

            Me.pnlAnular.Visible = visibleAnular
            Me.btnReporte.Text = strBotonReporte
            Me.pblLeyendaEmiAnte.Visible = blnVerLeyendaEmiAntece
            Me.btnVerLibros.Visible = Not blnVerLeyendaEmiAntece
            Me.pnlBotonReporte.Visible = Me._FormReporte
            UscFotografia_2v1._Limpiar()

        End Sub

        Private Sub UscEmisionAntecedentes1__Modificar_CellDoubleClick(intIDCodigo As Integer, intTipoCertificado As Short) Handles UscEmisionAntecedentes1._Modificar_CellDoubleClick

            FRM_MantEmisionAntecedente(False, intIDCodigo, intTipoCertificado)

        End Sub

        Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click

            Me.UscEmisionAntecedentes1._Anular()

        End Sub

        Private Sub UscConsultaTramite1__Grilla_CellEnter() Handles UscConsultaTramite1._Grilla_CellEnter

            If UscConsultaTramite1._count > 0 Then
                ShowFotografia()
            End If

        End Sub

        Private Sub UscConsultaTramite1__CellDoubleClick_Ver(idTramite As Integer) Handles UscConsultaTramite1._CellDoubleClick_Ver

            frmCRTramiteModificar(idTramite)
        End Sub

        Private Sub btnTramite_Click(sender As Object, e As EventArgs) Handles btnTramite.Click

            Me.ContextMenuStrip1.Show(Me.btnTramite.Location.X, MousePosition.Y - (btnTramite.Height * 1.5))

        End Sub

        Private Sub ToolStripMenuItemCR_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemCR.Click

            frmCRTramiteNuevo(Me.GrillaInternoID)

        End Sub
    End Class
End Namespace
