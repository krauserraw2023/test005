Imports System.Data.SqlClient

Namespace Registro.Main.Region
    Public Class frmBuscar
        Private objBss As Bussines.Registro.Interno = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing
        Private objBssMov As Bussines.Registro.InternoMovimiento = Nothing
        Private entMovCol As Entity.Registro.InternoMovimientoCol
        Private frmLoad As Load.frmLoad = Nothing

        Private Property FiltroNuevoCAJ As String = ""
        Private Property FiltroActualCAJ As String = ""
        Private blnEscritura As Boolean = False
        Private PerfilUsuarioActual As Type.Enumeracion.Usuario.EnumDependencia

#Region "propiedades_filtro_CAJ"
        Private Property PenalMultipleCAJ() As String
            Get
                Return strPenalMultipleCAJ
            End Get
            Set(ByVal value As String)
                strPenalMultipleCAJ = value
            End Set
        End Property
#End Region
#Region "grilla_CAJ"
        Private ReadOnly Property GrillaCodigoCAJ() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaCAJ
                        intValue = .SelectedRows(0).Cells("col_cod_caj").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaEstadoCAJ() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaCAJ
                        intValue = .SelectedRows(0).Cells("col_est_id_caj").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaNombresInternoCAJ() As String
            Get
                Dim intValue As String = ""
                Try
                    With Me.dgwGrillaCAJ
                        intValue = .SelectedRows(0).Cells("col_ape_pat_caj").Value & " " & .SelectedRows(0).Cells("col_ape_mat_caj").Value & ", " & .SelectedRows(0).Cells("col_nom_caj").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaTipoCertAntJudIdCAJ() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrillaCAJ
                        intValue = .SelectedRows(0).Cells("col_tip_aj_id_caj").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

#End Region
#Region "property_CAJ"
        Private strPenalMultipleCAJ As String = ""
        Private Property ApeMaternoCAJ As String
            Get
                Return txtApeMatCAJ.Text
            End Get
            Set(value As String)
                txtApeMatCAJ.Text = value
            End Set
        End Property
        Private Property ApePaternoCAJ As String
            Get
                Return txtApePatCAJ.Text
            End Get
            Set(value As String)
                txtApePatCAJ.Text = value
            End Set
        End Property
        Private Property NombresCAJ As String
            Get
                Return txtNombresCAJ.Text
            End Get
            Set(value As String)
                txtNombresCAJ.Text = value
            End Set
        End Property
        Private Property CodInternoCAJ As String
            Get
                Return txtInternoCodCAJ.Text
            End Get
            Set(value As String)
                txtInternoCodCAJ.Text = value
            End Set
        End Property
        Private Property NumSolicitudCAJ As String
            Get
                Return txtDocSolicitudCAJ.Text
            End Get
            Set(value As String)
                txtDocSolicitudCAJ.Text = value
            End Set
        End Property
        Private Property FechaDesdeCAJ As Long
            Get
                Return dtpFechaIniCAJ.ValueLong
            End Get
            Set(value As Long)
                dtpFechaIniCAJ.ValueLong = value
            End Set
        End Property
        Private Property FechaHastaCAJ As Long
            Get
                Return dtpFechaFinCAJ.ValueLong
            End Get
            Set(value As Long)
                dtpFechaFinCAJ.ValueLong = value
            End Set
        End Property
        Private Property TipoCertificadoId As Integer
            Get
                Dim v As Integer = -1

                If rbTupa.Checked Then v = 4
                If rbNoProPendMD.Checked Then v = 2
                If drbPositivo.Checked Then v = 3
                If rdbNegativo.Checked Then v = 1
                If rdbTodosTipAnt.Checked Then v = -1

                Return v
            End Get
            Set(value As Integer)
                Select Case value
                    Case -1
                        rdbTodosTipAnt.Checked = True
                    Case 1
                        rdbNegativo.Checked = True
                    Case 2
                        rbNoProPendMD.Checked = True
                    Case 3
                        drbPositivo.Checked = True
                    Case 4
                        rbTupa.Checked = True
                End Select
            End Set
        End Property
        Private Property EstadoCertificadoCAJ As Integer
            Get
                Dim v As Integer = -1
                If rdbPendiente.Checked Then v = 0
                If rdbTerminado.Checked Then v = 1
                If rdbImpreso.Checked Then v = 2
                If rdbAnulado.Checked Then v = 3
                If rdbTodos.Checked Then v = -1
                Return v
            End Get
            Set(value As Integer)
                Select Case value
                    Case 0
                        rdbPendiente.Checked = True
                    Case 1
                        rdbTerminado.Checked = True
                    Case 2
                        rdbImpreso.Checked = True
                    Case 3
                        rdbAnulado.Checked = True
                    Case Else
                        rdbTodos.Checked = True
                End Select
            End Set
        End Property
#End Region

#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    If tbcPrincipal.SelectedTab.Name = "tpConsultaInterno" Then
                        With Me.dgwGrilla
                            intValue = .SelectedRows(0).Cells("col_int_id").Value
                        End With
                    ElseIf tbcPrincipal.SelectedTab.Name = "tpConsultaMovimiento" Then

                        If UscBusquedaMovimiento1._GrillaCount > 0 Then
                            intValue = UscBusquedaMovimiento1._IDInternoSelect
                        End If

                    End If
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

        Private ReadOnly Property GrillaNombresCompleto() As String
            Get
                Dim strValue As String = ""
                Try
                    If tbcPrincipal.SelectedTab.Name = "tpConsultaInterno" Then
                        With Me.dgwGrilla
                            strValue = Me.GrillaApellidos & ", " & Me.GrillaNombres
                        End With
                    ElseIf tbcPrincipal.SelectedTab.Name = "tpConsultaMovimiento" Then
                        If UscBusquedaMovimiento1._GrillaCount > 0 Then
                            strValue = UscBusquedaMovimiento1._NombresCompletoSelect
                        End If
                    End If
                Catch ex As Exception

                End Try
                Return strValue
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
                    If tbcPrincipal.SelectedTab.Name = "tpConsultaInterno" Then
                        With Me.dgwGrilla
                            intValue = .SelectedRows(0).Cells("col_pen_id").Value
                        End With
                    ElseIf tbcPrincipal.SelectedTab.Name = "tpConsultaMovimiento" Then
                        If UscBusquedaMovimiento1._GrillaCount > 0 Then
                            intValue = UscBusquedaMovimiento1._PenIdSelect
                        End If
                    End If
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

#End Region
#Region "Propiedades_Buscar"
        Private intNumeroReg As Integer = 0
        Private strPenalMultiple As String = ""
        Private intInternoID As Integer = -1
        Private Property InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property
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
        Private ReadOnly Property IDRegion() As Short
            Get
                Return 3 'region lima
            End Get
        End Property
        Private ReadOnly Property NomRegion() As String
            Get
                Return "Region Lima" 'region lima
            End Get
        End Property
        Private ReadOnly Property IDPenal() As Short
            Get
                Return -1
            End Get
        End Property
        Private Property NomPenal() As String
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

                Me.cbbNacionalidad.SelectedValue = value


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
#Region "Propiedades_Interno"
        Private intSentRegion As Integer = -1
        Private strSentRegionNombre As String = ""
        Private intSentPenal As Integer = -1
        Private strSentPenalNombre As String = ""
        Private Property InternoRegion() As Integer
            Get
                Return intSentRegion
            End Get
            Set(ByVal value As Integer)
                intSentRegion = value
            End Set
        End Property
        Private Property InternoRegionNombre() As String
            Get
                Return strSentRegionNombre
            End Get
            Set(ByVal value As String)
                strSentRegionNombre = value
            End Set
        End Property
        Private Property InternoPenal() As Integer
            Get
                Return intSentPenal
            End Get
            Set(ByVal value As Integer)
                intSentPenal = value
            End Set
        End Property
        Private Property InternoPenalNombre() As String
            Get
                Return strSentPenalNombre
            End Get
            Set(ByVal value As String)
                strSentPenalNombre = value
            End Set
        End Property
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
                Me.txtIngresoNum.Text = value

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
        Private Property PenalClasificacion() As String
            Get
                Return Me.txtPenalClasificacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtPenalClasificacion.Text = value
            End Set
        End Property
        Private Property PerfilActual As Integer
        Public Property _PerfilUsuario As Type.Enumeracion.Usuario.EnumDependencia
#End Region
#Region "Propiedades_Config"
        Private ReadOnly Property UsuarioPerfil As Short
            Get
                Return Legolas.Configuration.Usuario.OficinaID
            End Get
        End Property

#End Region
#Region "Propiedades_Sistema"
        Private ReadOnly Property IDLicencia As Integer
            Get
                Return Legolas.LBusiness.Globall.WinApp.LicenciaApp
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboDelitoEspecifico()

            With Me.cbbDelitoEspecifico
                ._Todos = True
                .CodigoPadre = Me.DelitoGenericoID
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboDelitoGenerico()

            With Me.cbbDelitoGenerico
                ._Todos = True
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboRegion()
            Dim blnTodos As Boolean = False
            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True

                With Me.cbbRegion
                    .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                    ._Todos = blnTodos
                    .Parametro1 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With

            Else

                With Me.cbbRegion
                    .ComboTipo = Type.Combo.ComboTipo.RegionUsuario
                    ._Todos = blnTodos
                    .Parametro1 = Legolas.Configuration.Usuario.Codigo
                    .Parametro2 = Configuracion.Licencia.Codigo
                    .LoadUsc()

                End With

            End If
            cbbRegion.Enabled = False
            cbbRegion.SelectedValue = 3
        End Sub
        Private Sub ComboPenal()
            Dim blnTodos As Boolean = False

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True
                With Me.cbbPenal
                    ._Todos = blnTodos
                    .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                    .CodigoPadre = Me.IDRegion
                    .Parametro1 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With
            Else

                With Me.cbbPenal
                    ._Todos = blnTodos
                    .ComboTipo = Type.Combo.ComboTipo.PenalUsuario
                    .CodigoPadre = Me.IDRegion
                    .Parametro1 = Legolas.Configuration.Usuario.Codigo
                    .Parametro2 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With

            End If
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

            'validar que el tener la opcion todos ingrese un dato
            If (Me.ApellidoPaterno.Length < 2) And (Me.ApellidoMaterno.Length < 2) And Me.CodigoRP.Length < 5 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese algun apellido o codigo, para realizar la busqueda")
                Me.txtApePat.Focus()
                Return value
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

        Private Sub ListarNumeroReg()

            Dim strValue As String = ""

            Me.lblReg.Text = Me.NumeroReg & " Reg."

        End Sub
        Private Sub ColumnasVisible()


            If Me.IDPenal > 0 Then
                Me.col_pen_nom.Visible = False
            Else
                Me.col_pen_nom.Visible = True
            End If

            'mostrar columnas de sistema en el plm
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
            LoadRegion = Me.IDRegion
            LoadPenal = Me.IDPenal
            LoadPenalMult = Me.PenalMultiple
            LoadEstado = Me.Estado
            LoadEstadoEspecifico = Me.EstadoEspecifico

        End Sub

        Private Function Listar() As Boolean


            Dim objEntFiltro As New Entity.Registro.Interno_Grilla

            With objEntFiltro
                '/*interno*/
                .InternoCodigoRP = Me.LoadCodigoRP
                .PrimerApellido = Me.LoadApePat
                .SegundoApellido = Me.LoadApeMat
                .PreNombres = Me.LoadNombres
                .InternoAlias = Me.LoadNombresAlias
                .IDRegion = Me.IDRegion
                .IDPenal = Me.IDPenal
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
                .TrasladadoDeCarceleta = 1 'solo los que ya no se encuentran en carceleta (trasladados de carceleta)
            End With

            Dim objBss As New Bussines.Registro.Interno_Grilla.RegionLima
            objEntCol = objBss.Listar(objEntFiltro)

            If objEntCol.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Ningún registro encontrado.")
            End If
            Return True

        End Function
        Private Sub Buscar()

            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            FiltroActual = ConcatenarFiltro()

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
            Me.PenalClasificacion = ""

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

        Private Sub BuscarMovimientos(Optional mostrarAlertaRegNoEncontrado As Boolean = True, Optional buscarRegConFechaHoy As Boolean = False)
            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0

            Me.lblSegundo.Text = "00:00:00"
            Me.lblSegundo.Refresh()

            With UscBusquedaMovimiento1
                ._IDRegion = Me.IDRegion
                ._IDPenal = Me.IDPenal
                ._Buscar(mostrarAlertaRegNoEncontrado)
                Me.NumeroReg = ._GrillaCount
                ._Focus()
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
            objLista.Add(Me.IDRegion)
            objLista.Add(Me.IDPenal)
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

        Private Sub ListarIngreso()

            If Me.GrillaInternoID < 1 Then
                Exit Sub
            End If

            If Me.InternoID = Me.GrillaInternoID And Me.IngresoNumero.Length > 0 Then
                'nada
            Else

                Dim obBssIngreso As New Bussines.Registro.IngresoInpe
                Dim objEntIngreso As New Entity.Registro.IngresoInpe
                objEntIngreso.InternoID = Me.GrillaInternoID
                objEntIngreso.PenalID = Me.GrillaPenalID
                objEntIngreso.PerfilUsuarioId = Me.UsuarioPerfil
                objEntIngreso = obBssIngreso.ListarResumen(objEntIngreso, True)

                With objEntIngreso
                    Me.IngresoNumero = .IngresoNro
                    Me.IngresoFecha = .FechaMovIngresoString
                    Me.IngresoSituacionJuridica = .SituacionJuridicaNombre
                    Me.TipoEgreso = .TipoMovimientoNombre
                    Me.EgresoFecha = .strFechaLibertadDate
                    Me.PenalClasificacion = .PenalNom
                End With
                Me.InternoID = Me.GrillaInternoID
            End If

        End Sub
        Private Sub ShowFotografia()

            If Me.UscFotografia_2v1._CheckImagen = False Or Me.GrillaInternoID < 1 Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            If Me.InternoID = Me.GrillaInternoID And Me.UscFotografia_2v1._HasImagen = True And PerfilFotografia = PerfilActual Then
                'nada
            Else

                Dim objBssFoto As New Bussines.Registro.InternoFoto
                Dim objEnt As New Entity.Registro.InternoFoto
                Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente_LM(Me.GrillaInternoID)
                Dim strRutServer As String = ""
                Dim intImagen As Integer = -1
                Dim intNombreImagen As String = ""

                objBssFoto = New Bussines.Registro.InternoFoto
                objEnt = objBssFoto.ListarGrilla(intCodigo)

                If objEnt.Codigo > 0 Then

                    With objEnt
                        Select Case Me.PerfilFotografia
                            Case 1 'izquierdo
                                PerfilActual = 1
                                intImagen = .PIzquierdoID
                                intNombreImagen = .PIzquierdoName
                                strRutServer = .PIzquierdoServerPath
                            Case 2 'frente
                                PerfilActual = 2
                                intImagen = .PFrenteID
                                intNombreImagen = .PFrenteName
                                strRutServer = .PFrenteServerPath
                            Case 3 'derecho
                                PerfilActual = 3
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
                        Bussines.Registro.Interno.ResetInternoCodigo(Me.GrillaInternoCodigo, Me.IDRegion, Me.IDPenal)
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
            rdbEstadoTodos.Checked = True
            Me.txtApePat.Focus()

        End Sub
        Private Sub ALimpiarMov()

            UscBusquedaMovimiento1._Limpiar()

        End Sub
#End Region
#Region "OTROS_CAJ"
        Private Sub LimpiarCamposCAJ()
            Me.ApePaternoCAJ = ""
            Me.ApeMaternoCAJ = ""
            Me.CodInternoCAJ = ""
            Me.NombresCAJ = ""
            Me.NumSolicitudCAJ = ""
            Me.EstadoCertificadoCAJ = -1
            'Me.TipoCertificadoId = -1
            Me.FechaDesdeCAJ = 0
            Me.FechaHastaCAJ = 0
        End Sub
        Private Function ValidarBusquedaCAJ() As Boolean
            Dim v As Boolean = False
            If txtDocSolicitudCAJ.Text.Length > 0 And txtDocSolicitudCAJ.Text.Length < 5 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe proporcionar mas datos al número de documento de solicitud.")
                Return False
            End If
            If (Me.FechaDesdeCAJ > 0 And Me.FechaHastaCAJ = 0) Or (Me.FechaDesdeCAJ = 0 And Me.FechaHastaCAJ > 0) Then
                If Me.FechaDesdeCAJ = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha de inicio para la búsqueda")
                    Me.dtpFechaIniCAJ.Focus()
                End If
                If Me.FechaHastaCAJ = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha fin para la búsqueda")
                    Me.dtpFechaFinCAJ.Focus()
                End If
                If Me.FechaHastaCAJ < Me.FechaDesdeCAJ Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin no puede ser menor a la fecha de inicio")
                    Me.dtpFechaFinCAJ.Focus()
                End If
                Return v
            End If
            Return True
        End Function
#End Region
#Region "Listar_CAJ"
        Private Sub BuscarCAJ()

            FiltroActualCAJ = ConcatenarFiltroCAJ()

            Dim Lista As New Entity.Registro.Antecedente.SolicitudAntecedenteCol
            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            With ent
                .PenalMultiple = Me.PenalMultipleCAJ
                .InternoApePaterno = Me.ApePaternoCAJ
                .InternoApeMaterno = Me.ApeMaternoCAJ
                .InternoCodigo = Me.CodInternoCAJ
                .InternoNombres = Me.NombresCAJ
                .EstadoSolicitudId = Me.EstadoCertificadoCAJ
                .FechaDesde = Me.FechaDesdeCAJ
                .FechaHasta = Me.FechaHastaCAJ
                .CodigoPenal = -1
                .RegionId = -1
                .DocumentoNumero = txtDocSolicitudCAJ.Text.Trim
                .TipoAntecedenteId = Me.TipoCertificadoId
            End With
            Lista = (New Bussines.Registro.Antecedente.SolicitudAntecedente).ListarGrilla_LM(ent)

            With dgwGrillaCAJ
                .AutoGenerateColumns = False
                .DataSource = Lista
            End With

        End Sub
#End Region


#Region "Permisos_Usuario"
        Private Sub Usuario_Permisos(ByRef blnCerrarForm As Boolean)

            Me.PerfilUsuarioActual = Legolas.Configuration.Usuario.OficinaID

            Select Case Me.IDLicencia
                Case 1 'sede central

                    blnEscritura = Me._FormEscritura

                    If blnEscritura = True Then

                        Select Case Legolas.Configuration.Usuario.NivelUsuario
                            Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana,
                                Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                                Select Case Legolas.Configuration.Usuario.OficinaID

                                    Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                        Type.Enumeracion.Usuario.EnumDependencia.RegistroAntecedentes

                                    Case Else
                                        blnEscritura = False
                                End Select

                            Case Else
                                blnEscritura = False
                        End Select

                    End If

                    Me.pnlNuevo.Visible = blnEscritura
                    Me.pnlBotonModificar.Visible = blnEscritura
                    Me.pnlBotonReporte.Visible = Me._FormReporte

                    'eliminar el tab de antecedentes
                    Select Case Me.UsuarioPerfil

                        Case Type.Enumeracion.Usuario.EnumDependencia.RegistroAntecedentes,
                            Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion

                        Case Else
                            Me.tbcPrincipal.TabPages.Remove(Me.tpAntecedente)
                    End Select
                    Me.UscBusquedaMovimiento1._PerfilUsuario = Me.UsuarioPerfil

                Case Else
                    'penal o provincias
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Modulo de ORL solo está disponible en la Sede Central")
                    blnCerrarForm = True
                    Me.Close()
            End Select

        End Sub

#End Region

#Region "Form"
        Private Function FRM_SelectInterno() As Short

            Dim value As Short = -1
            Dim frm As New Registro.RegionLima.Identificacion.frmSelectInternoPopup
            With frm
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    value = ._TipoInterno
                End If
            End With

            Return value

        End Function
        Private Sub FRM_Mantenimiento(blnNuevo As Boolean)

            Dim intIDInterno As Integer = -1
            Dim intIDRegion As Integer = -1
            Dim intTipoInterno As Short = Type.Enumeracion.Interno.enmTipoInterno.Interno

            If blnNuevo = True Then
                intIDInterno = -1
                intIDRegion = Me.IDRegion

                intTipoInterno = FRM_SelectInterno()

                If intTipoInterno < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha seleccionado el tipo de interno")
                    Exit Sub
                End If

            Else
                If Me.GrillaInternoID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el interno")
                    Exit Sub
                End If

                intIDInterno = Me.GrillaInternoID
                intIDRegion = Me.GrillaRegionID
            End If

            Dim frm As New Registro.Main.Region.frmMantenimiento
            frm.MdiParent = Me.MdiParent
            With frm
                ._IDInterno = intIDInterno
                ._TipoInterno = intTipoInterno
                '/*permisos*/
                ._FormLectura = Me._FormLectura
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormImpresion = Me._FormImpresion
                ._FormEliminar = Me._FormEliminar
                .Show()
            End With

        End Sub
        Private Sub FRM_Ver_Reportes()
            Select Case Me.tbcPrincipal.SelectedTab.Name
                Case Me.tpAntecedente.Name
                    If Me.dgwGrillaCAJ.Rows.Count = 0 Then Exit Sub
                    If Me.GrillaEstadoCAJ = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Pendiente Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro se encuentra en estado pendiente, para continuar es necesario finalizar el registro.")
                        Exit Sub
                    End If

                    Dim frm As New APPReporte.Registro.ReporteCrystal_v2
                    With frm
                        Select Case Me.GrillaTipoCertAntJudIdCAJ
                            Case 1
                                If dgwGrillaCAJ.Item("col_dat_hist_migra", dgwGrillaCAJ.CurrentRow.Index).Value = True Then
                                    ._ReporteId = Type.Reporte.Registro.rptCertificadoAntJudNegativo_v0
                                Else
                                    ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudNegativo_v1
                                End If
                            Case 2
                                If dgwGrillaCAJ.Item("col_dat_hist_migra", dgwGrillaCAJ.CurrentRow.Index).Value = True Then
                                    ._ReporteId = Type.Reporte.Registro.rptCertificadoAntJudNoPPPMD_v0
                                Else
                                    ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudNoPPPMD_v1
                                End If
                            Case 3
                                If dgwGrillaCAJ.Item("col_dat_hist_migra", dgwGrillaCAJ.CurrentRow.Index).Value = True Then
                                    ._ReporteId = Type.Reporte.Registro.rptCertificadoAntJudPositivo_v0
                                Else
                                    ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudSiPPPMD_v1
                                End If
                            Case 4
                                ._ReporteId = Type.Reporte.Registro.rpt_tupa_v0
                        End Select
                        ._Filtro.Text = Me.Text
                        ._Filtro.DocSolicitudAntecedenteId = Me.GrillaCodigoCAJ
                        ._Filtro.Nota = ""
                        .ShowDialog()
                    End With
                Case Else
                    Dim frm As New Registro.Reporte.frmReportePopup_LM
                    With frm
                        ._RegionID = 3 'region lima 
                        ._PenalID = Me.GrillaPenalID
                        ._TipoReporte = Reporte.frmReportePopup_LM.enmListarReportes.Todos
                        ._InternoID = Me.GrillaInternoID
                        ._InternoApeNom = Me.GrillaNombresCompleto
                        ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                        .ShowDialog()
                    End With
            End Select

        End Sub
        Private Sub FRM_Antecedente()

            Dim blnValue As Boolean = False
            Dim TipoAntecedenteId As Integer = -1
            Dim frm As New Registro.Main.Antecedentes.frmTipoCertAntecedente
            With frm
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    TipoAntecedenteId = ._TipoAntecedente
                    blnValue = True
                End If
            End With

            If blnValue = True Then
                Dim f As New Registro.Main.Antecedentes.frmCertAntecedenteMant
                f._TipoAntecedenteId = TipoAntecedenteId
                If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Datos guardados satisfactorialmente")
                End If
            End If

        End Sub
#End Region
#Region "Otros"
        Private Function ConcatenarFiltroCAJ() As String
            Dim objLista As New ArrayList
            'texto
            objLista.Add(Me.ApePaternoCAJ)
            objLista.Add(Me.ApeMaternoCAJ)
            objLista.Add(Me.NombresCAJ)
            objLista.Add(Me.CodInternoCAJ)
            objLista.Add(Me.NumSolicitudCAJ)
            'combos
            'objLista.Add(Me.TipoCertificadoId)
            objLista.Add(Me.EstadoCertificadoCAJ)

            'fecha
            objLista.Add(Me.FechaDesdeCAJ)
            objLista.Add(Me.FechaHastaCAJ)
            Dim FiltroConcatenado As String = ""
            For Each obj As String In objLista
                FiltroConcatenado = FiltroConcatenado & obj
            Next
            Return FiltroConcatenado
        End Function

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

            Combo()

            ComboDelitoGenerico()
            ComboDelitoEspecifico()
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
        Private Sub frmBuscar_Load2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.pnlRegionPenal.Visible = False
            ValoresxDefault()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Select Case tbcPrincipal.SelectedTab.Name
                Case "tpConsultaInterno"
                    Buscar()
                Case "tpConsultaMovimiento"
                    BuscarMovimientos()
                Case "tpAntecedente"
                    If ValidarBusquedaCAJ() = False Then Exit Sub
                    BuscarCAJ()
            End Select

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            Me.Cursor = Cursors.WaitCursor

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                FRM_Mantenimiento(False)
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

            Select Case e.KeyData
                Case (Keys.Shift Or Keys.D) 'shift + D==> PERMITE BORRAR 

                    'solo para osin-dev
                    Select Case Legolas.Configuration.Usuario.OficinaID
                        Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion 'osin dev

                            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar <> DialogResult.Yes Then
                                Exit Sub
                            End If

                            Dim strMensajeOut As String = ""
                            Dim sqlCone As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

                            Dim strQuery As String = "update int_interno set _flg_eli=1, _usu_eli=" & Legolas.Configuration.Usuario.Codigo &
                            ", _fec_eli = " & Now.ToFileTime & " where int_id=" & Me.GrillaInternoID

                            Legolas.Components.SQL.ExecuteBatchNonQuery(sqlCone, strQuery, strMensajeOut)

                            If strMensajeOut.Trim.Length > 3 Then
                                Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensajeOut)
                            Else
                                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                            End If
                            Buscar()

                    End Select
                    Exit Sub
            End Select

            If e.KeyCode = Keys.Delete Then
                If Me._FormEliminar = False Then
                    Legolas.Configuration.Aplication.MessageBox.Information("No tiene permiso para eliminar registros.")
                    Exit Sub
                End If
                AEliminar()
            End If

        End Sub
        Private Sub cbbuscRegion__ValueChanged()

            Me.ComboPenal()
        End Sub
        Private Sub cbbDelitoGenerico__ValueChanged() Handles cbbDelitoGenerico._SelectedIndexChanged

            ComboDelitoEspecifico()

        End Sub
        Private Sub cbbuscPenal__ValueChanged() Handles cbbPenal._SelectedIndexChanged

            ColumnasVisible()

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
            FormatoGrillaColumnas()
            Select Case tbcPrincipal.SelectedTab.Name
                Case "tpConsultaInterno"
                    Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
                Case "tpConsultaMovimiento"
                    UscBusquedaMovimiento1._Exportar()
                Case "tpAntecedente"
                    Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrillaCAJ)
            End Select
        End Sub
        Dim objcol As Entity.Registro.Antecedente.DetalleAntecedenteCol
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

            If tbcPrincipal.SelectedTab.Name = "tpConsultaInterno" Then
                If Me.dgwGrilla.RowCount < 1 Then
                    Exit Sub
                End If
            ElseIf tbcPrincipal.SelectedTab.Name = "tpConsultaMovimiento" Then
                If UscBusquedaMovimiento1._GrillaCount < 1 Then
                    Exit Sub
                End If
            End If

            Dim modifInterno As Boolean = True
            Select Case tbcPrincipal.SelectedTab.Name
                Case "tpConsultaInterno", "tpConsultaMovimiento"
                    modifInterno = True
                Case "tpAntecedente"
                    modifInterno = False
            End Select

            If modifInterno = True Then
                FRM_Mantenimiento(False)
            Else
                Dim print As Boolean = False
                Dim actualizarGrilla As Boolean = False

                If dgwGrillaCAJ.Rows.Count = 0 Then Exit Sub
                If dgwGrillaCAJ.CurrentRow.Selected = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione una fila")
                    Exit Sub
                End If

                If dgwGrillaCAJ.Item("col_dat_hist_migra", dgwGrillaCAJ.CurrentRow.Index).Value = True Then 'si el tupa mostrar impresion directa
                    print = True
                Else
                    Dim f As New Registro.Main.Antecedentes.frmCertAntecedenteMant
                    objcol = New Entity.Registro.Antecedente.DetalleAntecedenteCol
                    f._Codigo = Me.GrillaCodigoCAJ
                    f._TipoAntecedenteId = GrillaTipoCertAntJudIdCAJ
                    If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        print = f._Imprimir
                        actualizarGrilla = True
                    Else
                        actualizarGrilla = f._Finalizado
                    End If

                    If actualizarGrilla = True Then
                        Dim fila As Integer = dgwGrillaCAJ.CurrentRow.Index
                        BuscarCAJ()
                        Try
                            dgwGrillaCAJ.Rows(fila).Selected = True 'volver a seleccionar el mismo registro que se modifico luego de refrescar los datos
                            dgwGrillaCAJ.CurrentCell = dgwGrillaCAJ.Rows(fila).Cells("col_tip_caj")
                        Catch ex As Exception
                        End Try
                    End If

                End If

                If print = True Then btnFicha.PerformClick()
            End If

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
            'ggg
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

            Dim blnCerrar As Boolean = False
            Usuario_Permisos(blnCerrar)

            If blnCerrar = False Then

                Me.Refresh()
                Me.Cursor = Cursors.WaitCursor

                With Me.UscBusquedaMovimiento1
                    ._IDRegion = Me.IDRegion
                    ._IDPenal = Me.IDPenal
                    ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    ._LoadUsc()
                End With

                'BuscarMovimientos(False, True), jmr, se comento la bsuqwuda en el evento, para no saturar a la region lima 
                dtpFechaIniCAJ.ValueLong = Now.ToFileTime
                dtpFechaFinCAJ.ValueLong = Now.ToFileTime

            End If

            Me.Cursor = Cursors.Default

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
        Private Sub btnFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFicha.Click

            FRM_Ver_Reportes()

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
            ListarIngreso()
        End Sub

        Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click
            Select Case tbcPrincipal.SelectedTab.Name
                Case "tpConsultaInterno"
                    ALimpiar()
                Case "tpConsultaMovimiento"
                    ALimpiarMov()
                Case "tpAntecedente"
                    LimpiarCamposCAJ()
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

            FRM_Mantenimiento(False)

        End Sub

        Private Sub UscBusquedaMovimiento1__Grilla_CellEnter() Handles UscBusquedaMovimiento1._Grilla_CellEnter
            If UscBusquedaMovimiento1._GrillaCount > 0 Then
                ShowFotografia()
                ListarIngreso()
            End If
        End Sub

        Private Sub UscBusquedaMovimiento1__Click_Numreg() Handles UscBusquedaMovimiento1._Grilla_ValidarFiltro
            Me.lblSegundo.Text = "00:00:00"
            Me.NumeroReg = 0
        End Sub

        Private Sub ValidarFiltroCAJ()

            'FiltroNuevoCAJ = ConcatenarFiltroCAJ()
            'If FiltroNuevoCAJ <> FiltroActualCAJ Then
            '    Me.dgwGrillaCAJ.DataSource = Nothing
            'End If
        End Sub

        Private Sub rdbTerminados_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbPendiente.CheckedChanged, rdbTerminado.CheckedChanged, rdbImpreso.CheckedChanged,
                                                                                                        rdbAnulado.CheckedChanged, rdbTodos.CheckedChanged, drbPositivo.CheckedChanged,
                                                                                                        rdbNegativo.CheckedChanged, rdbTodosTipAnt.CheckedChanged
            ValidarFiltroCAJ()
        End Sub


        Private Sub dtpFechaInis__ValueChanged() Handles dtpFechaIniCAJ._ValueChanged, dtpFechaFinCAJ._ValueChanged
            ValidarFiltroCAJ()
        End Sub


        Private Sub txtApePats_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApePatCAJ.TextChanged, txtApeMatCAJ.TextChanged,
                                                                                                    txtNombresCAJ.TextChanged, txtInternoCodCAJ.TextChanged,
                                                                                                   txtDocSolicitudCAJ.TextChanged
            ValidarFiltroCAJ()
        End Sub

        Private Sub dgwGrillaCAJ_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaCAJ.CellDoubleClick
            If dgwGrillaCAJ.Rows.Count = 0 Then Exit Sub
            If e.ColumnIndex = 0 Or e.RowIndex = -1 Then Exit Sub

            btnModificar.PerformClick()
        End Sub

        Private Sub btnNuevoCAJ_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click

            Select Case Me.tbcPrincipal.SelectedTab.Name

                Case Me.tpConsultaInterno.Name, Me.tpConsultaMovimiento.Name

                    FRM_Mantenimiento(True)
                Case Me.tpAntecedente.Name
                    FRM_Antecedente()

            End Select

        End Sub

        Private Sub dgwGrillaCAJ_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrillaCAJ.CellFormatting
            If dgwGrillaCAJ.Columns(e.ColumnIndex).Name = "col_est_caj" Then
                Select Case dgwGrillaCAJ.Item("col_est_id_caj", e.RowIndex).Value
                    Case 0 'pendiente
                        e.CellStyle.BackColor = Color.FromArgb(249, 241, 151)
                        Me.dgwGrillaCAJ.Rows(e.RowIndex).Cells("col_est_caj").Style.SelectionBackColor = Color.FromArgb(249, 241, 151)
                    Case 1 'terminado
                        e.CellStyle.BackColor = Color.FromArgb(175, 184, 69)
                        Me.dgwGrillaCAJ.Rows(e.RowIndex).Cells("col_est_caj").Style.SelectionBackColor = Color.FromArgb(175, 184, 69)
                    Case 2 'impreso
                        e.CellStyle.BackColor = Color.FromArgb(180, 223, 237)
                        Me.dgwGrillaCAJ.Rows(e.RowIndex).Cells("col_est_caj").Style.SelectionBackColor = Color.FromArgb(180, 223, 237)
                    Case 3 'anulado
                        e.CellStyle.BackColor = Color.FromArgb(221, 68, 72)
                        Me.dgwGrillaCAJ.Rows(e.RowIndex).Cells("col_est_caj").Style.SelectionBackColor = Color.FromArgb(221, 68, 72)
                End Select
            End If
        End Sub

        Private Sub tcConsultaInternoMovimientos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tbcPrincipal.SelectedIndexChanged

            Dim blnVerLeyenda As Boolean = False
            Select Case Me.tbcPrincipal.SelectedTab.Name

                Case Me.tpConsultaMovimiento.Name
                    Me.pblLeyenda.Visible = False
                    Me.pnlAnular.Visible = False
                    Me.UscBusquedaMovimiento1._Focus()
                    Me.pnlNuevo.Visible = False
                    Me.btnVerLibros.Visible = False
                Case Me.tpConsultaInterno.Name
                    Me.pblLeyenda.Visible = False
                    Me.pnlAnular.Visible = False
                    Me.txtApePat.Focus()
                    Me.pnlNuevo.Visible = blnEscritura
                    Me.btnVerLibros.Visible = True
                Case Me.tpAntecedente.Name
                    blnVerLeyenda = True
                    Me.pnlAnular.Visible = True
                    Me.pnlNuevo.Visible = blnEscritura
                    Me.btnVerLibros.Visible = False
                    BuscarCAJ()
            End Select

            Me.pblLeyenda.Visible = blnVerLeyenda

        End Sub

        Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click
            If dgwGrillaCAJ.Rows.Count = 0 Then Exit Sub
            If dgwGrillaCAJ.CurrentRow.Selected = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione una fila")
                Exit Sub
            End If
            Dim sms As String = ""
            Select Case Me.GrillaEstadoCAJ
                Case 0
                    'sms = "El registro se encuentra en estado pendiente"
                Case 3
                    sms = "El registro ya se encuentra anulado"
            End Select
            If sms.Length > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(sms)
                Exit Sub
            End If
            If MessageBox.Show("Confirma anular el registro seleccionado", "ANULAR SOLICITUD DE ANTECEDENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Dim bss As New Bussines.Registro.Antecedente.SolicitudAntecedente
                Dim id As Integer = -1
                Dim outSms As String = ""
                Dim fila As Integer = -1
                Dim strMotAnulacion As String = ""
                strMotAnulacion = InputBox("Ingrese el motivo por el cual anula el registro.", "Motivo de anulación")
                If strMotAnulacion = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Operación de anulación cancelada")
                    Exit Sub
                End If
                fila = dgwGrillaCAJ.CurrentRow.Index
                id = bss.CambiarEstado(Me.GrillaCodigoCAJ, Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Anulado.GetHashCode, outSms, strMotAnulacion)

                If id = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Error al anular registro, " & outSms)
                    Exit Sub
                End If
                BuscarCAJ()
                Try

                    dgwGrillaCAJ.Rows(fila).Selected = True
                Catch ex As Exception

                End Try
            End If
        End Sub

        Private Sub btnVerLibros_Click(sender As System.Object, e As System.EventArgs) Handles btnVerLibros.Click

            If Me.GrillaInternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el interno")
                Exit Sub
            End If

            Dim frm As New Registro.RegionLima.Resoluciones.frmListarLibros
            frm._InternoID = Me.InternoID
            frm._LicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
            frm.ShowDialog()

        End Sub
        Private Sub dgwGrillaCAJ_KeyDown(sender As Object, e As KeyEventArgs) Handles dgwGrillaCAJ.KeyDown

            Select Case e.KeyData
                Case (Keys.Shift Or Keys.D) 'shift + D==> PERMITE BORRAR 

                    'solo para osin-dev
                    Select Case Legolas.Configuration.Usuario.OficinaID
                        Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion 'osin dev

                            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar <> DialogResult.Yes Then
                                Exit Sub
                            End If

                            Dim objBssAntecedentes As New Bussines.Registro.Antecedente.SolicitudAntecedente
                            objBssAntecedentes.Eliminar(Me.GrillaCodigoCAJ)
                            Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                            BuscarCAJ()

                    End Select
                    Exit Sub
            End Select

        End Sub
    End Class

End Namespace
