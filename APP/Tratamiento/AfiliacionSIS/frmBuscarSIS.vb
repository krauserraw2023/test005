Imports System.ComponentModel
Imports System.Text
Namespace Tratamiento.AfiliacionSIS
    Public Class frmBuscarSIS
        Private objBss As Bussines.Registro.Interno = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing
        Private objEntSolCol As Entity.Tratamiento.Afiliacion.InternoSolicitudCol = Nothing
        Private entMovCol As Entity.Registro.InternoMovimientoCol
        Private frmLoad As Load.frmLoad = Nothing
        Private frmLoadRnc As Load.frmLoad02 = Nothing
        Private objInternoReniec As Bussines.Visita.VisitanteReniec.objDTOPersona = Nothing

#Region "Propiedades_Interno"
        Private intInternoEstado As Integer = -1
        Dim UscGrillaNombresAsociados1 As Object ''''

        Private Property CodigoRPInterno() As String
            Get
                Return Me.txtCodInterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodInterno.Text = value
            End Set
        End Property
        Private Property InternoApePaterno() As String
            Get
                Return Me.txtApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property InternoApeMaterno() As String
            Get
                Return Me.txtApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
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
        Private ReadOnly Property InternoApeyNom() As String
            Get
                Dim strValue As String = ""
                'strValue = Me.InternoApePaterno & " " & Me.InternoApeMaterno & ", " & Me.InternoNombres
                'strValue = txtInterno.Text
                Return strValue
            End Get
        End Property
        Private ReadOnly Property InternoApeyNomHis(ApellidoPat As String, ApellidoMat As String, Nombres As String) As String
            Get
                Dim strValue As String = ""
                strValue = ApellidoPat & " " & ApellidoMat & ", " & Nombres
                Return strValue
            End Get
        End Property
        Private Property InternoFechaAfiliacion() As Long
            Get
                Return Me.dtpFechaAfi.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaAfi.ValueLong = value
            End Set
        End Property

        Private Property InternoEstado() As Integer
            Get
                Return intInternoEstado
            End Get
            Set(ByVal value As Integer)
                intInternoEstado = value
            End Set
        End Property



        Private Property DocumentoTipo As Integer = -1


        Private NumeroDocumentoAux As String = ""
        Private InternoApePaternoAux As String = ""
        Private InternoApeMaternoAux As String = ""
        Private InternoNombresAux As String = ""
        Private NuevoClickfrmIngreso As Boolean = False
        '////////////////Datos Basicos del interno/////////////////////////
        Private Property CodigoRPInterno2() As String
            Get
                Return Me.txtCodigoInterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodInterno.Text = value
            End Set
        End Property
        Private Property InternoApePaterno2() As String
            Get
                Return Me.txtApellidoPat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property InternoApeMaterno2() As String
            Get
                Return Me.txtApellidoMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property InternoNombres2() As String
            Get
                Return Me.txtNombres.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private Property InternoEdad() As String
            Get
                Return Me.txtEdad.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtEdad.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Interno_Solicitud"

        Private Property Anio() As Integer
            Get
                Return Me.cbbAnio.Value
            End Get
            Set(ByVal value As Integer)
                Me.cbbAnio.Value = value
            End Set
        End Property
        Private Property Mes() As Integer
            Get
                Return Me.cbbMes.Value
            End Get
            Set(ByVal value As Integer)
                Me.cbbMes.Value = value
            End Set
        End Property
        Private ReadOnly Property EstadoSolicitud As String
            Get
                Dim Valor As String = ""
                If Me.ckbVer.Checked = False Then
                    If Me.Estado = 1 Then
                        Valor = "PENDIENTE"
                    ElseIf Me.Estado = 2 Then
                        Valor = "ENVIADO"
                    ElseIf Me.Estado = 3 Then
                        Valor = "ATENDIDO"
                    End If
                End If
                Return Valor
            End Get
        End Property
        Private FechaRegistroSol As Long = 0
        Private ReadOnly Property FechaRegistroSolString() As String
            Get
                Dim valor As String = ""
                If Me.FechaRegistroSol > 0 Then
                    valor = Legolas.Components.FechaHora.FechaDate(Me.FechaRegistroSol, False)
                End If
                Return valor
            End Get
        End Property


        Public Property NumeroDocumentoFiltro() As String
            Get
                Return txtDocumentoBusca.Text
            End Get
            Set(ByVal value As String)
                txtDocumentoBusca.Text = value
            End Set
        End Property

        Public Property ApellidosNombresFiltro() As String
            Get
                Return txtApellidosNombresBus.Text
            End Get
            Set(ByVal value As String)
                txtApellidosNombresBus.Text = value
            End Set
        End Property
        Private Property VerObservados As Boolean
            Get
                Return Me.chkRegistrosObservados.Checked
            End Get
            Set(value As Boolean)
                Me.chkRegistrosObservados.Checked = value
            End Set
        End Property
#End Region
#Region "Propiedades_Interno_Afiliacion"
        Private CodigoAfiliacion As Integer = -1
#End Region

#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    Select Case Me.tcPrincipal.SelectedTab.Name
                        Case "tpPoblacionInterno"
                            With Me.dgwGrilla
                                intValue = .SelectedRows(0).Cells("col_int_id").Value
                            End With
                        Case "tpSolicitudAfiliaciones"
                            With Me.dgwGrillaSolicitudes
                                intValue = .SelectedRows(0).Cells("col_sol_int_id").Value
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
                Dim intValue As Integer = -1
                Try

                    Select Case Me.tcPrincipal.SelectedTab.Name
                        Case "tpPoblacionInterno"
                            With Me.dgwGrilla
                                intValue = .SelectedRows(0).Cells("col_pen_id").Value
                            End With
                        Case "tpSolicitudAfiliaciones"
                            With Me.dgwGrillaSolicitudes
                                intValue = .SelectedRows(0).Cells("col_sol_pen_id").Value
                            End With
                    End Select

                Catch ex As Exception

                End Try
                Return intValue
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
        '/*Grilla Solicitudes*/
        Private ReadOnly Property GrillaEstadoSol() As String
            Get
                Dim str As String = ""
                Try
                    With Me.dgwGrillaSolicitudes
                        If Me.ckbVer.Checked = False Then
                            If .SelectedRows(0).Cells("col_est_id").Value = 1 Then
                                str = "PENDIENTE"
                            ElseIf .SelectedRows(0).Cells("col_est_id").Value = 2 Then
                                str = "EN PROCESO"
                            ElseIf .SelectedRows(0).Cells("col_est_id").Value = 3 Then
                                str = "ENVIADO"
                            End If
                        End If

                    End With
                Catch ex As Exception

                End Try
                Return str
            End Get
        End Property
        Private ReadOnly Property GrillaFechaReg() As String
            Get
                Dim str As String = ""
                Try
                    With Me.dgwGrillaSolicitudes
                        If Me.ckbVer.Checked = False Then
                            str = Legolas.Components.FechaHora.FechaDate(.SelectedRows(0).Cells("col_fec_reg").Value, True)
                        End If
                    End With
                Catch ex As Exception
                End Try
                Return str
            End Get
        End Property
        Private ReadOnly Property GrillaFechaEnvio() As String
            Get
                Dim str As String = ""
                Try
                    With Me.dgwGrillaSolicitudes
                        If Me.ckbVer.Checked = False Then
                            If .SelectedRows(0).Cells("col_sol_fec_env").Value = 0 Then
                                str = ""
                            Else
                                str = Legolas.Components.FechaHora.FechaDate(.SelectedRows(0).Cells("col_sol_fec_env").Value, True)
                            End If
                        End If
                    End With
                Catch ex As Exception
                End Try
                Return str
            End Get
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private intNumeroReg As Integer = -1
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
        Private Property NumeroDocumentoPer() As String = ""
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumeroDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumeroDoc.Text = value
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
        Private Property RegionID2() As Integer
            Get
                Return Me.cbbOficinaRegional.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbOficinaRegional.SelectedValue = value
            End Set
        End Property
        Private Property PenalID2() As Integer
            Get
                Return Me.cbbEstablecimientoPenitenciario.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbEstablecimientoPenitenciario.SelectedValue = value
            End Set
        End Property

        Private Property NumeroRegistro() As Integer
            Get
                Return Me.cbbRegistro.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegistro.SelectedValue = value
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
        Public Property EstadoRNC As Integer = -1

        Private ReadOnly Property AfiliacionID() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbAfiliacionSI.Checked = True Then
                    intValue = 1
                End If
                If Me.rdbAfiliacionNO.Checked = True Then
                    intValue = 0
                End If
                If Me.rdbAfiliacionTodos.Checked = True Then
                    intValue = -1
                End If

                Return intValue
            End Get

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
        Private Property TipoDocumentoPer() As Integer = 0
        Private Property TipoDocumento() As Integer
            Get
                Dim value As Integer = -1
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property NacionalidadPais() As Integer
            Get
                Dim value As Integer = -1
                Return Me.cbbNacionalidad.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property
        Private Property FiltroNuevo As String = ""
        Private Property FiltroActual As String = ""
        Private Property EstadoAfiliacionID As Integer = -1
        Private fechaUltimoDia As Integer = -1
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
        'Private intLoadNacionalidad As Integer = -1
        Private intLoadNacionalidadPais As Integer = -1
        Private intLoadEstado As Integer = -1
        Private intLoadDelGene As Integer = -1
        Private intLoadDelEsp As Integer = -1
        Private intLoadSitJur As Integer = -1
        Private lngLoadFechaIni As Long = 0
        Private lngLoadFechaFin As Long = 0
        Private strLoadPenalMult As String = ""
        Private intLoadEstadoReniec As Integer = -1
        Private intLoadAfiliacion As Integer = -1
        Private intLoadTipoDoc As Integer = -1
        Private intLoadNumeroDocumento As String = ""
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

        Private Property LoadTipoDoc() As Integer
            Get
                Return intLoadTipoDoc
            End Get
            Set(ByVal value As Integer)
                intLoadTipoDoc = value
            End Set
        End Property
        Private Property LoadNumeroDocumento() As String
            Get
                Return intLoadNumeroDocumento
            End Get
            Set(ByVal value As String)
                intLoadNumeroDocumento = value
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
        Private Property LoadNacionalidadPais() As Integer
            Get
                Return intLoadNacionalidadPais
            End Get
            Set(ByVal value As Integer)
                intLoadNacionalidadPais = value
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
        Private Property LoadAfiliacion() As Integer
            Get
                Return intLoadAfiliacion
            End Get
            Set(ByVal value As Integer)
                intLoadAfiliacion = value
            End Set
        End Property
        Private Property LoadEstadoEspecifico() As Integer = -1
        Private Property LoadFechaIngresoPenal As Long = 0
        Private Property LoadFechaIngresoPenalDate As String = ""

        'Solicitud
        Private Property LoadInicioFechaSol() As Long
        Private Property LoadFechaSol() As Long
        Private Property LoadNumeroSol() As Integer = -1
        Private Property LoadAnio() As Integer = -1
        Private Property LoadMes() As Integer = -1
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
        Private Property PerfilActual As Integer
#End Region
#Region "Combo"

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

        End Sub
        Private Sub ComboPenal()

            Dim blnTodos As Boolean = False

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True
                With Me.cbbPenal
                    ._Todos = blnTodos
                    .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                    .CodigoPadre = Me.RegionID
                    .Parametro1 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With
            Else
                Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
                Dim objBssLicencia As New Bussines.Sistema.Instalacion
                intTipoLicencia = objBssLicencia.ListarTipo(Configuracion.Licencia.Codigo)

                Select Case intTipoLicencia
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                        blnTodos = True
                End Select

                With Me.cbbPenal
                    ._Todos = blnTodos
                    .ComboTipo = Type.Combo.ComboTipo.PenalUsuario
                    .CodigoPadre = Me.RegionID
                    .Parametro1 = Legolas.Configuration.Usuario.Codigo
                    .Parametro2 = Configuracion.Licencia.Codigo
                    .LoadUsc()
                End With

            End If

        End Sub
        Private blnCombo As Boolean = False
        Private Sub Combo()
            With Me.cbbNacionalidad
                ._Todos = True
                .LoadUsc()
            End With
            With Me.cbbTipoDoc
                ._Todos = True
                .LoadUsc()
            End With
            blnCombo = False
            Dim intAnio As Integer = Legolas.Configuration.Aplication.FechayHora.FechaAnio

            With Me.cbbAnio
                ._Todos = True
                .AnioInicio = 2010
                .AnioFin = intAnio
                .LoadUsc()
            End With

            With Me.cbbMes
                ._Todos = True
                .LoadUsc()
            End With

            blnCombo = True
            With Me.cbbOficinaRegional
                ._Todos = True
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboEstablecimientoPenal()
            With Me.cbbEstablecimientoPenitenciario
                ._Todos = True
                If Me.RegionID2 = -1 Then
                    .CodigoPadre = 1
                Else
                    .CodigoPadre = Me.RegionID2
                End If
                .LoadUsc()
            End With
        End Sub

        Private Sub ComboRegistros()
            With Me.cbbRegistro
                ._Todos = True
                .Parametro1 = -1
                .LoadUsc()
            End With
        End Sub
#End Region
#Region "Functions"
        Private Function GrillaCountInternosPrincipal() As Integer

            Dim value As Integer = 0
            Dim intCount As Integer = 0
            If tcPrincipal.SelectedTab.Name = "tpConsultaInterno" Then
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
        Private Function ExportarCSV(Nombre As String) As Boolean
            Dim saveFileDialog1 As New FolderBrowserDialog
            If saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim Rutas As String = saveFileDialog1.SelectedPath
                Using outputFile As New IO.StreamWriter(Rutas & "\" & Nombre & ".csv")
                    Try
                        Dim line As New StringBuilder
                        For Each row As DataGridViewRow In Me.dgwGrillaSolicitudes.Rows
                            If Not row.IsNewRow Then
                                For x As Integer = 0 To row.Cells.Count - 1
                                    line.Append(CStr(row.Cells(x).Value))
                                    If x <> (row.Cells.Count - 1) Then line.Append(","c)
                                Next
                                outputFile.WriteLine(line.ToString)
                                'line.clear()
                            End If
                        Next
                        outputFile.Flush()
                        MessageBox.Show("Exportado Correctamente")
                        Return True
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End Using
            End If
            Return False
        End Function
        Private Function FRM_ValidarVisitaReniec(ByRef strMensaje As String, ByRef intMostrarTipoMensaje As Short) As Boolean
            Dim value As Boolean = False
            Dim intIDUsuario As Integer = Legolas.Configuration.Usuario.Codigo

            If Me.TipoDocumentoPer = Type.Enumeracion.enmTipoDocumento.DNI Then
                If Me.NumeroDocumentoPer.Length <> 8 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El número documento DNI debe tener 8 digitos/ operación cancelada.")
                Else
                    Dim objPersona As New APPWebService.ws_reniec_sede.NumeroDocumento
                    Dim intErrorReniec As Integer = -1
                    Dim strMensajeReniec As String = ""
                    Dim blnHayReniec As Boolean = True
                    Dim blnCancelarVerificacion As Boolean = False
                    objPersona = ConsultarReniec(Me.NumeroDocumentoPer, blnHayReniec, blnCancelarVerificacion, intErrorReniec, strMensajeReniec)
                    If blnCancelarVerificacion = True Then
                        strMensaje = "Se canceló el proceso de verificacion con Reniec"
                    Else
                        If blnHayReniec = True Then
                            If intErrorReniec <> 0 Then ' si presenta algun tipo de error en la reniec 
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("Codigo Error: " & intErrorReniec & "-" & strMensajeReniec)
                            Else
                                If Not objPersona Is Nothing Then
                                    'preguntamos si el dni devulto x reniec es el mismo
                                    If objPersona.NumeroDNI = Me.NumeroDocumentoPer Then
                                        With objPersona
                                            Dim frm As New Tratamiento.AfiliacionSIS.frmReniec
                                            With frm
                                                .objPersona = objPersona
                                                .ShowDialog()
                                            End With
                                        End With
                                    End If
                                Else
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Codigo Error: " & intErrorReniec & "-" & strMensajeReniec)
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno debe poseer el tipo de documento DNI / operación cancelada.")
            End If
        End Function
#End Region
#Region "Reniec"
        Private Function ConsultarReniec(strNumeroDNI As String, ByRef blnHayReniec As Boolean,
                                         ByRef blnCancelarVerificacion As Boolean, ByRef intCodigoErrorReniec As Integer, ByRef strMensajeReniec As String) As APPWebService.ws_reniec_sede.NumeroDocumento

            Dim value As New APPWebService.ws_reniec_sede.NumeroDocumento
            Me.SuspendLayout()

            If Me.BackgroundWorker3.IsBusy = True Then
                Return value
            End If

            Me.BackgroundWorker3.RunWorkerAsync(strNumeroDNI)

            blnCancelarVerificacion = False

            frmLoadRnc = New Load.frmLoad02
            If frmLoadRnc.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackgroundWorker3.CancelAsync()
                Me.BackgroundWorker3.Dispose()
                blnCancelarVerificacion = True
            End If
            Me.ResumeLayout(True)
            frmLoadRnc.Refresh()

            If blnCancelarVerificacion = False Then
                value = objInternoReniec.objPersona
                blnHayReniec = objInternoReniec.HayServicioReniec
                intCodigoErrorReniec = objInternoReniec.ErrorCodigo
                strMensajeReniec = objInternoReniec.ErrorMensaje
            End If

            Return value

        End Function
        Private Function ConsultarReniecHilo(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Bussines.Visita.VisitanteReniec.objDTOPersona

            Dim value As New Bussines.Visita.VisitanteReniec.objDTOPersona

            If worker.CancellationPending = True Then

                e.Cancel = True

            Else

                Dim objBssMQReniec As New Bussines.Globall.Reniec
                Dim objPersonaCabecera As New APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento
                Dim intErrorCodigo As String = -1
                Dim strErrorMensaje As String = ""


                Try
                    objPersonaCabecera = objBssMQReniec.WS_ReniecxDNI_Resultado(e.Argument, intErrorCodigo, strErrorMensaje)

                    value.objPersona = objPersonaCabecera.Resultado
                    value.ErrorCodigo = intErrorCodigo
                    value.ErrorMensaje = strErrorMensaje

                    If intErrorCodigo = 0 Then
                        value.HayServicioReniec = True
                    End If

                Catch ex As Exception
                    value.HayServicioReniec = False
                End Try

            End If

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
        Private Sub ListarNumeroReg()

            Dim strValue As String = ""

            Me.lblReg.Text = Me.NumeroReg & " Reg."

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
            LoadTipoDoc = Me.TipoDocumento
            LoadNumeroDocumento = Me.NumeroDocumento
            LoadNacionalidadPais = Me.NacionalidadPais
            LoadRegion = Me.RegionID
            LoadPenal = Me.PenalID
            LoadEstado = Me.Estado
            LoadEstadoEspecifico = Me.EstadoEspecifico
            LoadAfiliacion = Me.AfiliacionID
        End Sub
        Private Sub LoadPropiedadesSolicitud()
            LoadRegion = Me.RegionID2
            LoadPenal = Me.PenalID2
            'LoadEstado = Me.Estado
            LoadNumeroSol = Me.NumeroRegistro
            LoadInicioFechaSol = Me.FechaInicioLong
            LoadFechaSol = Me.FechaLong
            LoadAnio = Me.Anio
            LoadMes = Me.Mes
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
                    .IDPenalString = Me.LoadPenalMult
                    .IDSexo = Me.LoadSexo
                    .IDTipoDocIdentidad = Me.LoadTipoDoc
                    .InternoNumeroDocumento = Me.LoadNumeroDocumento
                    .IDNacionalidad = Me.LoadNacionalidadPais
                    .IDInternoEstado = Me.LoadEstado
                    .IDRegion = Me.LoadRegion
                    .IDPenal = Me.LoadPenal
                    .IDAfiliacion = Me.LoadAfiliacion
                End With
                objEntCol = objBss.Listar_sis(objEntFiltro)

                Return True
            End If

        End Function

        Private Sub Buscar()

            If ValidarBusqueda() = False Then
                Exit Sub
            End If
            FiltroActual = ConcatenarFiltro()
            'CodigoPenalMultiple()

            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0
            Me.lblSegundo.Text = "00:00:00"
            Me.lblSegundo.Refresh()

            LoadPropiedades()


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
                lblReg.Text = objEntCol.Count & " Reg."
            End With

            Dim dteFechaFin As Date = Now

            intSeg = DateDiff(DateInterval.Second, dteFechaIni, dteFechaFin)
            Me.lblSegundo.Text = intSeg.ToString("00:00:00")
            BarraEstado()

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
            objLista.Add(Me.cbbTipoDoc.SelectedValue)
            objLista.Add(Me.NumeroDocumento)
            objLista.Add(Me.cbbNacionalidad.SelectedValue)
            'radio buton
            objLista.Add(Me.Estado)
            objLista.Add(Me.Sexo)
            objLista.Add(Me.AfiliacionID)
            'fecha
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

        End Sub

        Private Sub ShowFotografia()

            If Me.UscFotografia_2v1._CheckImagen = False Or Me.GrillaInternoID < 1 Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            'If Me.InternoID = Me.GrillaInternoID And Me.UscFotografia_2v1._HasImagen = True And 2 = PerfilActual Then
            '    'nada
            'Else

            Me.UscFotografia_2v1._showFotoInternoPrincipal(Me.GrillaInternoID, 2)
            Me.PerfilActual = 2

            If UscFotografia_2v1._HasImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
            End If

            'End If

        End Sub
        Private Sub ShowFotografiaDatosPersonales()
            Me.UscFotografia_2v2._CheckImagen = True
            If Me.InternoID < 1 Or Me.PenalID < 1 Then
                Me.UscFotografia_2v2._Limpiar()
                Exit Sub
            End If

            Me.UscFotografia_2v2._showFotoInternoPrincipal(Me.InternoID, 2)
            Me.PerfilActual = 2
            If UscFotografia_2v2._HasImagen = False Then
                Me.UscFotografia_2v2._Limpiar()
            End If

        End Sub
        Private Sub ShowFotografiaSol()

            If Me.UscFotografia_2v3._CheckImagen = False Or Me.GrillaInternoID < 1 Then
                Me.UscFotografia_2v3._Limpiar()
                Exit Sub
            End If

            If Me.InternoID = Me.GrillaInternoID And Me.UscFotografia_2v3._HasImagen = True And 2 = PerfilActual Then
                'nada
            Else

                Me.UscFotografia_2v3._showFotoInternoPrincipal(Me.GrillaInternoID, 2)
                Me.PerfilActual = 2

                If UscFotografia_2v3._HasImagen = False Then
                    Me.UscFotografia_2v1._Limpiar()
                End If
            End If
        End Sub
        ' /*Datos personales del interno*/
        Dim objBssA As New Bussines.Tratamiento.Afiliacion.InternoAfiliacion
        Private Sub ListarDataInterno(objEnt As Entity.Registro.Interno)
            'objBss = New Bussines.Registro.Interno
            objEnt = objBssA.ListarSIS(objEnt)
            With objEnt
                '/*datos generales*/
                Me.InternoID = .Codigo
                Me.txtCodigoInterno.Text = .CodigoRP
                Me.txtApellidoPat.Text = .ApellidoPaterno
                Me.txtApellidoMat.Text = .ApellidoMaterno
                Me.txtNombres.Text = .Nombres
                Me.Sexo = .SexoID
                If Me.Sexo = 1 Then
                    Me.rbtMasculino.Checked = True
                Else
                    Me.rbtFemenino.Checked = True
                End If
                Me.txtFechaNacimiento.Text = .FechaNacimientoString
                Me.txtTipoNumeroDoc.Text = .TipoDocumentoNombre & "-" & .NumeroDocumento
                Me.TipoDocumentoPer = .TipoDocumentoID
                Me.NumeroDocumentoPer = .NumeroDocumento
                Me.txtEstadoCivil.Text = .EstadoCivilNombre
                Me.txtPaisNacimiento.Text = .NacimientoPaisNombre
                Me.txtDepartamentoNacimiento.Text = .NacimientoDepartamentoNombre
                Me.txtProvinciaNacimiento.Text = .NacimientoProvinciaNombre
                Me.txtDistritoNacimiento.Text = .NacimientoDistritoNombre
                Me.EstadoRNC = .EstadoRncID
                If .EstadoRncID > 0 Then
                    Me.rbtSiRNC.Checked = True
                Else
                    Me.rbtNoRNC.Checked = True
                End If
                '/*datos academicos*/
                Me.RegionID = .RegionID
                Me.PenalID = .PenalID
                Me.txtPenal.Text = .PenalNombre
                Me.txtEstado.Text = IIf(.EstadoID = 1, "ACTIVO", "INACTIVO")
                Me.txtEdad.Text = .Edad.ToString
                Me.RegionID = .RegionID
                Me.PenalID = .PenalID
                Me.txtFechaIngreso.Text = .FechaIngresoDate
                Me.txtFechaLibertad.Text = .FechaLibertadString
                Me.CodigoAfiliacion = .CodigoAfiliacion
                Me.EstadoAfiliacionID = .EstadoAfiliacionID
                rbtAfiliacionSI.Checked = IIf(Me.EstadoAfiliacionID = 1, True, False)
                rbtAfiliacionNO.Checked = IIf(Me.EstadoAfiliacionID = 1, False, True)
                Me.InternoFechaAfiliacion = .FechaAfiliacion
                Me.txtNacionalidad.Text = .NacionalidadNombre
                Me.txtpadre.Text = .Padre
                Me.txtMadre.Text = .Madre
            End With
        End Sub
        Private Sub ListarResumen()
            dgwResumen.RowCount = 0
            If objEntSolCol.Count = 0 Then
                Exit Sub
            End If
            Dim codSolicitud As Integer = -1
            If cbbMes.Value > 0 Then
                codSolicitud = objEntSolCol.Item(0).CodigoSolicitud
            End If
            Dim valaux As Integer = 0
            Dim obj As New Entity.Tratamiento.Afiliacion.InternoSolicitud
            Dim objCol As New Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            bssSol = New Bussines.Tratamiento.Afiliacion.InternoSolicitud
            obj.CodigoSolicitud = codSolicitud
            objCol = bssSol.ListarResumen(obj)
            Dim idPen As Integer = 0
            Dim ConPen As Integer = 0
            Dim k As Integer = -1
            For Each obje As Entity.Tratamiento.Afiliacion.InternoSolicitud In objCol
                k += 1
                If k = 0 Then
                    idPen = obje.PenalID
                    ConPen += 1
                Else
                    If idPen <> obje.PenalID Then
                        idPen = obje.PenalID
                        ConPen += 1
                    End If
                End If
            Next
            dgwResumen.RowCount = ConPen + 1
            idPen = 0
            k = -1
            Dim kY As Integer = 0
            Dim ob As New Entity.Tratamiento.Afiliacion.InternoSolicitud
            For Each ob In objCol
                k += 1
                If k = 0 Then
                    idPen = ob.PenalID
                    kY = k
                End If
                With dgwResumen
                    If idPen = ob.PenalID Then
                        .Item(1, kY).Value = ob.RegionNombre
                        .Item(3, kY).Value = ob.PenalNombre
                        If ob.TipoMovimientoID = 1 Then
                            .Item(5, kY).Value = 0
                            .Item(5, kY).Value = ob.Cantidad
                        ElseIf ob.TipoMovimientoID = 3 Then
                            .Item(6, kY).Value = 0
                            .Item(6, kY).Value = ob.Cantidad
                        ElseIf ob.TipoMovimientoID = 2 Then
                            .Item(7, kY).Value = 0
                            .Item(7, kY).Value = ob.Cantidad
                        Else
                            .Item(8, kY).Value = ob.Cantidad
                        End If
                        .Item(4, kY).Value = 0
                        .Item(4, kY).Value = Val(.Item(5, kY).Value) + Val(.Item(6, kY).Value) + Val(.Item(7, kY).Value) + Val(.Item(8, kY).Value)
                    Else
                        idPen = ob.PenalID
                        kY += 1
                        .Item(1, kY).Value = ob.RegionNombre
                        .Item(3, kY).Value = ob.PenalNombre
                        If ob.TipoMovimientoID = 1 Then
                            .Item(5, kY).Value = 0
                            .Item(5, kY).Value = ob.Cantidad
                        ElseIf ob.TipoMovimientoID = 3 Then
                            .Item(6, kY).Value = 0
                            .Item(6, kY).Value = ob.Cantidad
                        ElseIf ob.TipoMovimientoID = 2 Then
                            .Item(7, kY).Value = 0
                            .Item(7, kY).Value = ob.Cantidad
                        Else
                            .Item(8, kY).Value = ob.Cantidad
                        End If
                        .Item(4, kY).Value = 0
                        .Item(4, kY).Value = Val(.Item(5, kY).Value) + Val(.Item(6, kY).Value) + Val(.Item(7, kY).Value) + Val(.Item(8, kY).Value)
                    End If
                End With
            Next
            Dim Total As Integer = 0
            Dim TIng As Integer = 0
            Dim TLiber As Integer = 0, TTras As Integer = 0
            Dim Col As Integer = Me.dgwResumen.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.dgwResumen.Rows
                Total += Val(row.Cells(4).Value)
                TIng += Val(row.Cells(5).Value)
                TLiber += Val(row.Cells(6).Value)
                TTras += Val(row.Cells(7).Value)
            Next
            With dgwResumen
                .Item(4, ConPen).Value = Total.ToString
                .Item(5, ConPen).Value = TIng.ToString
                .Item(6, ConPen).Value = TLiber.ToString
                .Item(7, ConPen).Value = TTras.ToString
                .Item(3, ConPen).Value = "TOTAL"
                .Rows(ConPen).DefaultCellStyle.BackColor = Color.Orange
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            End With
        End Sub


        Private Function ListarGrillaEnvio(objEntCol As Entity.Tratamiento.Afiliacion.InternoSolicitudCol) As Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            Dim objCol As New Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            For Each ent As Entity.Tratamiento.Afiliacion.InternoSolicitud In objEntCol
                If ent.ObservacionRegistro = "" Then
                    objCol.Add(ent)
                End If
            Next

            With Me.dgwGrillaSolicitudes
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objCol
                lblRegSolicitud.Text = objCol.Count & " Reg."
            End With
            Return objCol
        End Function

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

        Private Sub ALimpiar()
            Me.CodigoRP = ""
            Me.ApellidoPaterno = ""
            Me.ApellidoMaterno = ""
            Me.Nombres = ""
            Me.NumeroDocumento = ""
            Me.Sexo = -1 'todos
            Me.txtApePat.Focus()
        End Sub
        Private Sub ALimpiarFiltro()
            Me.txtFechaRegistro.Text = ""
            Me.txtFechaEnvio.Text = ""
            Me.txtEstadoSolicitud.Text = ""
            Me.ApellidosNombresFiltro = ""
            Me.NumeroDocumentoFiltro = ""
            Me.RegionID2 = -1
            Me.PenalID2 = -1
            Me.chkRegistrosObservados.Checked = False
        End Sub
        Private Property fechaBusquedaSol As Long

        Private Function FechaInicioLong() As Long
            Dim fechaAnio As Integer = Me.Anio
            Dim fechaMes As Integer = Me.Mes
            Dim fechaDia As Integer = -1
            Dim fecha As String = ""

            If Me.Anio < 1 And Me.Mes < 1 Then
                fecha = ""
                Return 0
            ElseIf Me.Anio > 0 Then
                If Me.Mes < 1 Then
                    fechaMes = 1
                Else
                    fechaMes = Me.Mes
                End If
                fechaDia = 1
                fecha = fechaDia & "/" & fechaMes & "/" & fechaAnio
                Return CDate(fecha).ToFileTime
            End If
        End Function
        Private Function FechaLong() As Long
            Dim fechaAnio As Integer = Me.Anio
            Dim fechaMes As Integer = Me.Mes
            Dim fecha As String = ""
            If Me.Anio < 1 And Me.Mes < 1 Then
                fechaAnio = Now.Year
                fechaMes = Now.Month
                fechaUltimoDia = Now.Day
                fecha = fechaUltimoDia & "/" & fechaMes & "/" & fechaAnio
            Else
                If Me.Mes < 1 Then
                    fechaMes = Now.Month
                End If
                fechaUltimoDia = DateSerial(fechaAnio, fechaMes + 1, 0).Day
                fecha = fechaUltimoDia & "/" & fechaMes & "/" & fechaAnio
            End If
            Return CDate(fecha).ToFileTime
        End Function
#End Region
#Region "Form"
        Private Sub FRM_Mantenimiento(ByVal Nuevo As Boolean, intIDPenal As Integer)

            Dim frm As New Registro.Penal.Busqueda.frmMant
            frm.MdiParent = Me.MdiParent
            With frm
                If Nuevo = True Then
                    .InternoID = -1
                    .RegionID = Me.InternoRegion
                    .RegionNombre = Me.InternoRegionNombre
                    .PenalID = Me.InternoPenal
                    .PenalNombre = Me.InternoPenalNombre
                Else
                    If Me.GrillaInternoID < 1 Then
                        Exit Sub
                    End If
                    .InternoID = Me.GrillaInternoID
                    '.PenalID = If(UscBusquedaMovimiento1._TipoBusqueda = False, Me.GrillaPenalID, UscBusquedaMovimiento1.GrillaPenalID)
                End If
                ._FormLectura = Me._FormLectura
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormImpresion = Me._FormImpresion
                ._FormEliminar = Me._FormEliminar
                .Show()
            End With

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
            Combo()
            ComboEstablecimientoPenal()
            Me.Anio = Legolas.Configuration.Aplication.FechayHora.FechaAnio
            Me.Mes = -1 'Para que salga por defecto todos
            dgwGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dgwGrilla.VisibleCampos = True
            UscFotografia_2v1._PanelCheck = True
            UscFotografia_2v3._PanelCheck = True
            Me.col_sol_fec_nac.Tag = "fecha"
            Me.col_sol_fec_ing.Tag = "fecha"
        End Sub
        Private Sub BarraEstado()

        End Sub
        Private Sub UsuarioPermisos()
            'Me.pnlBotonGrabar.Visible = Me._FormEscritura
            Me.pnlBotonReporte.Visible = Me._FormReporte
            Me.gbBotones.Visible = Me._FormEscritura
        End Sub
        Private Sub ValidarFiltro()
            If tcInternos.SelectedIndex = 0 Then
                FiltroNuevo = ConcatenarFiltro()
            End If
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
            Me.col_sol_chk.Visible = False
            Me.col_sol_obs_img.Visible = False
        End Sub
        Private Sub FormatoGrillaColumnasSolicitud()
            'formato columnas
            Me.col_sol_tip_pob.Visible = True
            Me.col_sol_pen_cod.Visible = True
            Me.col_sol_sex_id.Visible = True
            Me.col_sol_tip_doc_env.Visible = True
            Me.col_sol_tip_ope.Visible = True
            Me.col_sol_fec_str.Visible = True
            Me.col_sol_num_doc.Visible = True

            Me.col_sol_fec_nac.Visible = False
            Me.col_sol_int_cod.Visible = False
            Me.col_tip_mov.Visible = False
            Me.col_sol_chk.Visible = False
            Me.col_nro_sol.Visible = False
            Me.col_sol_pen_nom.Visible = False
            Me.col_sol_det_est_nom.Visible = False
            Me.col_sol_mes.Visible = False
            Me.col_sol_obs_img.Visible = False
            Me.col_sol_tip_doc_num.Visible = False
            Me.col_sol_tip_doc_id.Visible = False
            Me.col_sol_fec_ing.Visible = False
            Me.col_sol_fec_egr.Visible = False
        End Sub
        Private Sub FormatoGrillaColumnasSolicitudActivar(objEntSolCol As Entity.Tratamiento.Afiliacion.InternoSolicitudCol)
            'formato columnas
            Me.col_sol_tip_pob.Visible = False
            Me.col_sol_pen_cod.Visible = False
            Me.col_sol_sex_id.Visible = False
            Me.col_sol_tip_doc_env.Visible = False
            Me.col_sol_tip_ope.Visible = False
            Me.col_sol_fec_str.Visible = False
            Me.col_sol_num_doc.Visible = False

            Me.col_sol_fec_ing.Visible = True
            Me.col_sol_fec_egr.Visible = True

            Me.col_sol_fec_nac.Visible = True
            Me.col_sol_int_cod.Visible = True
            Me.col_tip_mov.Visible = True
            Me.col_sol_chk.Visible = True
            Me.col_sol_pen_nom.Visible = True
            Me.col_sol_tip_doc_num.Visible = True
            Me.col_sol_mes.Visible = True
            Me.col_sol_obs_img.Visible = True
            Dim codigo As Integer = -1
            Dim ind As Integer = -1
            bssSol = New Bussines.Tratamiento.Afiliacion.InternoSolicitud
            bssDet = New Bussines.Tratamiento.Afiliacion.InternoSolicitudDetalle
            For Each obj As Entity.Tratamiento.Afiliacion.InternoSolicitud In objEntSolCol
                ind += 1
                obj.FechaEnvio = Legolas.Configuration.Aplication.FechayHora.FechaLong()
                If ind = 0 Then
                    obj.Tipo = True
                    bssSol.GrabarEstadoEnvio(obj)
                    obj.Tipo = False
                End If
                bssDet.GrabarEstadoEnvio(obj)
            Next
        End Sub
#End Region
        Private Sub frmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()

        End Sub


        Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtCodInterno.KeyPress, _
        txtApePat.KeyPress, _
        txtApeMat.KeyPress, _
        txtNom.KeyPress, _
        txtNumeroDoc.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub dgwGrilla_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentDoubleClick
            tcInternos.SelectedIndex = 1
        End Sub
        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            If e.KeyCode = Keys.Delete Then
                AEliminar()
            End If

        End Sub
        Private Sub cbbuscRegion__ValueChanged() Handles cbbRegion._SelectedIndexChanged

            Me.ComboPenal()
        End Sub

        Private Sub cbbuscPenal__ValueChanged() Handles cbbPenal._SelectedIndexChanged

            ColumnasVisible()

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
            UsuarioPermisos()
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

        Private Sub rdbPI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

            ShowFotografia()

        End Sub

        Private Sub rdbActivo_Click(sender As Object, e As System.EventArgs) _
            Handles rdbActivo.Click, _
            rdbInactivo.Click, _
            rdbEstadoTodos.Click
            ColumnasVisible()
        End Sub
        Private Sub dgwGrilla_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick, dgwGrilla.CellEnter

            ShowFotografia()

        End Sub

        Private Sub txtCodInterno_TextChanged(sender As System.Object, e As System.EventArgs) Handles _
            txtCodInterno.TextChanged, _
            txtApePat.TextChanged, _
            txtApeMat.TextChanged, _
            txtNom.TextChanged, _
            txtNumeroDoc.TextChanged

            ValidarFiltro()

        End Sub


        Private Sub cbbNacionalidad__SelectedIndexChanged() Handles _
            cbbNacionalidad._SelectedIndexChanged, _
            cbbRegion._SelectedIndexChanged, _
            cbbPenal._SelectedIndexChanged

            ValidarFiltro()
        End Sub


        Private Sub rdbActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles _
            rdbActivo.CheckedChanged, _
            rdbInactivo.CheckedChanged, _
            rdbEstadoTodos.CheckedChanged, _
            rdbHom.CheckedChanged, _
            rdbMuj.CheckedChanged, _
            rdbSexoTodos.CheckedChanged

            ValidarFiltro()
        End Sub

        Private Sub dtpFechaIni__ValueChanged()

            ValidarFiltro()

        End Sub


        Private Sub UscBusquedaMovimiento1__Grilla_CellDoubleClick()

            FRM_Mantenimiento(False, Me.GrillaPenalID)

        End Sub



        Private Sub UscBusquedaMovimiento1__Grilla_ValidarFiltro()
            Me.lblSegundo.Text = "00:00:00"
            Me.NumeroReg = 0
        End Sub



        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
            If tcPrincipal.SelectedTab.Name = "tpPoblacionInterno" Then
                If tcInternos.SelectedTab.Name = "tpBusquedaInternos" Then
                    Buscar()
                End If
            End If
            BarraEstado()
        End Sub


        Private Sub tcInternos_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tcInternos.SelectedIndexChanged
            If tcInternos.SelectedIndex = 1 Then
                If Me.GrillaInternoID < 1 Then
                    tcInternos.SelectedIndex = 0
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un interno")
                Else
                    pnlBotonReporte.Visible = False
                    Dim objInt As New Entity.Registro.Interno
                    objInt.Codigo = Me.GrillaInternoID
                    ListarDataInterno(objInt)
                    ShowFotografiaDatosPersonales()
                End If
            Else
                pnlBotonReporte.Visible = Me._FormReporte
                Exit Sub
            End If
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            If tcPrincipal.SelectedIndex = 0 Then
                If tcInternos.SelectedIndex = 1 Then
                    tcInternos.SelectedIndex = 0
                Else
                    Me.Close()
                End If
            Else
                tcPrincipal.SelectedIndex = 0
            End If
        End Sub




        Private bssSol As Bussines.Tratamiento.Afiliacion.InternoSolicitud
        Private bssDet As Bussines.Tratamiento.Afiliacion.InternoSolicitudDetalle
        Private Sub tsbGenerarSolicitud_Click(sender As System.Object, e As System.EventArgs) Handles tsbGenerarSolicitud.Click
            bssSol = New Bussines.Tratamiento.Afiliacion.InternoSolicitud
            bssDet = New Bussines.Tratamiento.Afiliacion.InternoSolicitudDetalle
            Dim objSol As New Entity.Tratamiento.Afiliacion.InternoSolicitud
            Dim objAfiCol As New Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            objSol.PenalID = -1
            objSol.RegionID = -1
            objSol.FechaInicioBusqueda = Me.FechaInicioLong
            objSol.FechaBusqueda = Me.FechaLong
            objSol.Anio = Me.Anio
            objSol.Mes = Me.Mes

            If Me.Anio < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccionar Año de generacion de solicitud")
                cbbAnio.Focus()
                Exit Sub
            ElseIf Me.Mes < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccionar Mes de generacion de solicitud")
                cbbMes.Focus()
                Exit Sub
            Else
                Dim ContPend As Integer = Bussines.Tratamiento.Afiliacion.InternoSolicitud.ListarPendientes(objSol)
                If ContPend > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("En este periodo de tiempo ya se ha generado un archivo")
                    Exit Sub
                End If
            End If

            objAfiCol = bssSol.Listar_Afiliacion(objSol)
            If objAfiCol.Count > 0 Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Esta seguro de generar la solicitud de Afiliacion en el periodo: " + cbbMes.MesString + "/" + CStr(Me.Anio)) = Windows.Forms.DialogResult.Yes Then
                    Dim obj As New Entity.Tratamiento.Afiliacion.InternoSolicitud

                    Dim RegionRegID As Integer = -1
                    Dim PenalRegID As Integer = -1
                    Dim Config As Integer = -1
                    If Configuracion.Licencia.Codigo = 1 Then 'sede central
                        Config = 1
                        RegionRegID = 2
                        PenalRegID = -1
                    Else
                        Config = Configuracion.Licencia.Codigo
                        RegionRegID = Me.RegionID2
                        PenalRegID = Me.PenalID2
                    End If

                    With obj
                        .FechaRegistro = 0
                        .FechaEnvio = 0
                        If Configuracion.Licencia.Codigo = 1 Then 'sede central
                            .RegionID = 2
                            .PenalID = -1
                        Else
                            .RegionID = Me.RegionID
                            .PenalID = Me.PenalID
                        End If
                        .RegionRegistroID = RegionRegID
                        .PenalRegistroID = PenalRegID
                        .EstadoID = 1
                        .Email = ""
                        .Anio = Me.Anio
                        .Mes = Me.Mes
                    End With
                    Dim codSolicitud As Integer = bssSol.Grabar(obj)

                    If codSolicitud > 0 Then
                        For Each objA As Entity.Tratamiento.Afiliacion.InternoSolicitud In objAfiCol
                            objA.CodigoSolicitud = codSolicitud
                            objA.RegionRegistroID = RegionRegID
                            objA.PenalRegistroID = PenalRegID
                            objA.Anio = Me.Anio
                            objA.Mes = Me.Mes
                            bssDet.Grabar(objA)
                        Next
                        Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                    End If

                    'ComboRegistros()
                    'ckbVer.Checked = False
                    Dim objEntFiltro As New Entity.Tratamiento.Afiliacion.InternoSolicitud

                    With objEntFiltro
                        .RegionID = Me.LoadRegion
                        .PenalID = Me.LoadPenal
                        .FechaInicioBusqueda = Me.LoadInicioFechaSol
                        .FechaBusqueda = Me.LoadFechaSol
                        .NumeroSol = IIf(ckbVer.Checked, -1, -1)
                        .Anio = Me.LoadAnio
                        .Mes = Me.LoadMes
                    End With
                    objEntSolCol = bssSol.Listar_Solicitud(objEntFiltro)

                    With Me.dgwGrillaSolicitudes
                        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False
                        .DataSource = objEntSolCol
                        lblRegSolicitud.Text = objEntSolCol.Count & " Reg."
                    End With
                    ListarResumen()
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Information("No existe internos pendientes en este periodo," + Chr(13) +
                                                                         "para realizar solicitud de afiliacion SIS")
            End If
        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick
            ShowFotografia()
        End Sub

        Private Sub cbbOficinaRegional__SelectedIndexChanged() Handles cbbOficinaRegional._SelectedIndexChanged

            ComboEstablecimientoPenal()
            ListarFiltroGrilla()
        End Sub

        Private Sub cbbEstablecimientoPenitenciario__SelectedIndexChanged() Handles cbbEstablecimientoPenitenciario._SelectedIndexChanged
            ListarFiltroGrilla()
        End Sub


        Private Function Listarsolicitudes(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean
            If worker.CancellationPending = True Then

                e.Cancel = True

            Else
                Dim objBss As New Bussines.Tratamiento.Afiliacion.InternoSolicitud
                Dim objEntFiltro As New Entity.Tratamiento.Afiliacion.InternoSolicitud

                With objEntFiltro
                    .RegionID = Me.LoadRegion
                    .PenalID = Me.LoadPenal
                    .FechaInicioBusqueda = Me.LoadInicioFechaSol
                    .FechaBusqueda = Me.LoadFechaSol
                    .NumeroSol = IIf(ckbVer.Checked, -1, -1)
                    .Anio = Me.LoadAnio
                    .Mes = Me.LoadMes
                End With
                objEntSolCol = New Entity.Tratamiento.Afiliacion.InternoSolicitudCol
                If ckbVer.Checked Then
                    objEntFiltro.FechaInicioBusqueda = Me.LoadInicioFechaSol
                    objEntSolCol = objBss.Listar_Afiliacion(objEntFiltro)
                Else
                    objEntSolCol = objBss.Listar_Solicitud(objEntFiltro)
                End If

                Return True
            End If

        End Function

        Private Sub ckbVer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbVer.CheckedChanged
            Me.col_sol_obs_img.Visible = True
            If ckbVer.Checked = True Then
                dgwGrillaSolicitudes.Columns("col_sol_det_est_nom").Visible = False
                dgwGrillaSolicitudes.Columns("col_sol_mes").Visible = False
                lblEtiqueta.Text = "LISTA DE INTERNOS SIN SOLICITUD DE AFILIACION"
            Else
                dgwGrillaSolicitudes.Columns("col_sol_det_est_nom").Visible = True
                dgwGrillaSolicitudes.Columns("col_sol_mes").Visible = True
                lblEtiqueta.Text = Legolas.Components.Cadena.ProperCase("LISTA DE SOLICITUDES PARA AFILIACION")
            End If
            dgwGrillaSolicitudes.DataSource = Nothing
        End Sub


        Private Sub UscFotografia_2v3__CheckClick() Handles UscFotografia_2v3._CheckClick
            ShowFotografiaSol()
        End Sub

        Private Sub UscFotografia_2v1__CheckClick() Handles UscFotografia_2v1._CheckClick
            ShowFotografia()
        End Sub

        Private Sub dgwGrillaSolicitudes_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaSolicitudes.CellClick
            txtEstadoSolicitud.Text = Me.GrillaEstadoSol
            txtFechaRegistro.Text = Me.GrillaFechaReg
            txtFechaEnvio.Text = Me.GrillaFechaEnvio
            ShowFotografiaSol()
        End Sub

        Private Sub dgwGrillaSolicitudes_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaSolicitudes.CellContentClick
            txtEstadoSolicitud.Text = Me.GrillaEstadoSol
            txtFechaRegistro.Text = Me.GrillaFechaReg
            txtFechaEnvio.Text = Me.GrillaFechaEnvio
            ShowFotografiaSol()
        End Sub

        Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
            If tcPrincipal.SelectedTab.Name = "tpPoblacionInterno" Then
                ALimpiar()
            End If
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            tcInternos.SelectedIndex = 1
        End Sub

        Private bssAfi As New Bussines.Tratamiento.Afiliacion.InternoAfiliacion
        Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
            If Me.InternoID < 1 Then
                Exit Sub
            End If
            If Me.CodigoAfiliacion > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("El interno se encuentra afiliado.")
                Exit Sub
            End If
            If Me.InternoFechaAfiliacion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Ingresar fecha de afiliación.")
                Exit Sub
            End If
            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Esta seguro de Afiliar al interno") = Windows.Forms.DialogResult.Yes Then
                bssAfi = New Bussines.Tratamiento.Afiliacion.InternoAfiliacion
                Dim ent As New Entity.Tratamiento.Afiliacion.InternoAfiliacion
                With ent
                    .InternoID = Me.InternoID
                    .FechaRegistro = Me.InternoFechaAfiliacion
                    .EstadoID = 1
                    .RegionID = Me.RegionID
                    .PenalID = Me.PenalID
                    .RegionRegistroID = Me.RegionID
                    .PenalRegistroID = Me.PenalID
                End With
                bssAfi.Grabar(ent)
                Dim objInt As New Entity.Registro.Interno
                objInt.Codigo = Me.InternoID
                objInt.PenalID = Me.PenalID
                ListarDataInterno(objInt)
            End If
        End Sub

        Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
            If Me.InternoID < 1 Then
                Exit Sub
            End If
            If Me.EstadoAfiliacionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("El interno no esta afiliado.")
                Exit Sub
            End If
            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Esta seguro de eliminar la afiliación") = Windows.Forms.DialogResult.Yes Then
                bssAfi = New Bussines.Tratamiento.Afiliacion.InternoAfiliacion
                Dim ent As New Entity.Tratamiento.Afiliacion.InternoAfiliacion
                With ent
                    .CodigoAfiliacion = Me.CodigoAfiliacion
                    .InternoID = Me.InternoID
                    .FechaRegistro = Me.InternoFechaAfiliacion
                    .EstadoID = 0
                    .RegionID = Me.RegionID
                    .PenalID = Me.PenalID
                End With
                bssAfi.Grabar(ent)
                Dim objInt As New Entity.Registro.Interno
                objInt.Codigo = Me.InternoID
                objInt.PenalID = Me.PenalID
                ListarDataInterno(objInt)
            End If
        End Sub

        Private Sub tsbListarSolicitudesAfi_Click(sender As System.Object, e As System.EventArgs) Handles tsbListarSolicitudesAfi.Click

            ALimpiarFiltro()
            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0
            Me.lblSegundoSol.Text = "00:00:00"
            Me.lblSegundoSol.Refresh()

            LoadPropiedadesSolicitud()

            Me.SuspendLayout()

            'If Me.BackgroundWorker1.IsBusy Then Exit Sub
            Me.BackgroundWorker2.RunWorkerAsync()

            frmLoad = New Load.frmLoad
            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackgroundWorker2.CancelAsync()
                Me.BackgroundWorker2.Dispose()
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            With Me.dgwGrillaSolicitudes
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntSolCol
                If Not (objEntSolCol Is Nothing) Then
                    lblRegSolicitud.Text = objEntSolCol.Count & " Reg."
                End If
            End With

            Dim dteFechaFin As Date = Now

            intSeg = DateDiff(DateInterval.Second, dteFechaIni, dteFechaFin)
            Me.lblSegundoSol.Text = intSeg.ToString("00:00:00")
            ListarResumen()
        End Sub

        Private Sub dgwGrillaSolicitudes_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaSolicitudes.CellEnter
            With Me.dgwGrillaSolicitudes
                'If .Rows(e.RowIndex).Cells("col_sol_obs").Value = "NO" Then
                .Rows(e.RowIndex).Cells("col_sol_obs_img").Style.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                'End If
            End With
        End Sub

     
        Private Sub dgwGrillaSolicitudes_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrillaSolicitudes.CellFormatting
            With Me.dgwGrillaSolicitudes
                Select Case e.ColumnIndex
                    Case .Columns("col_sol_fec_nac").Index, .Columns("col_sol_fec_ing").Index, .Columns("col_sol_fec_egr").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Format(Legolas.Components.FechaHora.FechaDate(e.Value), "dd/MM/yyyy")
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub

        Private Sub BackgroundWorker2_Disposed(sender As Object, e As System.EventArgs) Handles BackgroundWorker2.Disposed
            If Me.BackgroundWorker2.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker2 = Nothing
                Me.Close()
            End If
        End Sub

        Private Sub BackgroundWorker2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker2.CancellationPending = True Then
                e.Cancel = True
            Else

                e.Result = Listarsolicitudes(worker, e)

            End If
        End Sub

        Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()
                result = e.Result
                ' procesa el resultado del metodo ping        
            End If
        End Sub
        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click
            If tcPrincipal.SelectedTab.Name = "tpPoblacionInterno" Then
                FormatoGrillaColumnas()
                Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
            ElseIf tcPrincipal.SelectedTab.Name = "tpSolicitudAfiliaciones" Then
                FormatoGrillaColumnas()
                Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrillaSolicitudes)
                Me.col_sol_chk.Visible = True
                Me.col_sol_obs_img.Visible = True
            End If
        End Sub
        Private Sub tsbExportar_Click(sender As System.Object, e As System.EventArgs) Handles tsbExportar.Click
            If dgwGrillaSolicitudes.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Debe listar las solicitudes pendientes para generar el ENVIO SIS.")
            ElseIf objEntSolCol.Count > 0 Then
                Dim val As Boolean = False
                For Each obj As Entity.Tratamiento.Afiliacion.InternoSolicitud In objEntSolCol
                    If obj.EstadoID > 1 Then
                        val = True
                        Exit For
                    End If
                Next
                If val = True Then
                    Legolas.Configuration.Aplication.MessageBox.Information("No se puede generar el formato, porque este esta archivo ya ha sido enviado.")
                Else
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Esta seguro de generar el Formato de Envio al SIS") = Windows.Forms.DialogResult.Yes Then
                        Dim NombreArchivo As String = ""
                        Dim day As String = IIf(Me.fechaUltimoDia < 10, "0" & fechaUltimoDia, fechaUltimoDia)
                        NombreArchivo = "INPE_INTERNOS_" & Me.Anio & IIf(CStr(Me.Mes).Length = 1, "0" & CStr(Me.Mes), Me.Mes) & day
                        FormatoGrillaColumnasSolicitud()
                        Dim objCol As New Entity.Tratamiento.Afiliacion.InternoSolicitudCol
                        objCol = ListarGrillaEnvio(objEntSolCol)
                        Legolas.Components.ExportarGrillaExcel.ExportarCSV(dgwGrillaSolicitudes, NombreArchivo, False, False, False)
                        FormatoGrillaColumnasSolicitudActivar(objCol)
                        tsbBuscar.PerformClick()
                    End If
                End If
            End If
        End Sub
        Private Sub tcPrincipal_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tcPrincipal.SelectedIndexChanged
            If tcPrincipal.SelectedIndex = 1 Then
                pnlBotonReporte.Visible = Me._FormReporte
            Else
                If tcInternos.SelectedIndex = 0 Then
                    pnlBotonReporte.Visible = Me._FormReporte
                Else
                    pnlBotonReporte.Visible = False
                End If
            End If
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

        Private Sub ListarFiltroGrilla()
            Dim ObjCol As New Entity.Tratamiento.Afiliacion.InternoSolicitudCol

            ObjCol = ListarFiltro(objEntSolCol)

            With Me.dgwGrillaSolicitudes
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = ObjCol
                If Not (objEntSolCol Is Nothing) Then
                    lblRegSolicitud.Text = ObjCol.Count & " Reg."
                End If
            End With
        End Sub

        Private Function ListarFiltro(objEntCol As Entity.Tratamiento.Afiliacion.InternoSolicitudCol) As Entity.Tratamiento.Afiliacion.InternoSolicitudCol

            Dim Value As New Entity.Tratamiento.Afiliacion.InternoSolicitudCol

            If Me.NumeroDocumentoFiltro.Length < 1 And Me.ApellidosNombresFiltro.Length < 1 And _
                Me.RegionID2 = -1 And Me.PenalID2 = -1 And Me.VerObservados = False Then
                Return objEntCol
            End If

            For Each obj As Entity.Tratamiento.Afiliacion.InternoSolicitud In objEntCol
                'Filtra por codigo de interno
                If (Me.NumeroDocumentoFiltro = obj.NumeroDocumento) Or Me.NumeroDocumentoFiltro.Length < 1 Then
                    If (obj.ApellidosyNombres.Contains(Me.ApellidosNombresFiltro) = True Or Me.ApellidosNombresFiltro.Length < 1) And _
                        (Me.RegionID2 = obj.RegionID Or Me.RegionID2 = -1) And _
                        (Me.PenalID2 = obj.PenalID Or Me.PenalID2 = -1) Then
                        If (obj.ObservacionRegistro.Length > 0 Or Me.VerObservados = False) Then
                            '    If obj.ObservacionRegistro.Length > 1 Then
                            Value.Add(obj)
                            '    End If
                        End If

                    End If
                End If
            Next

            Return Value
        End Function


        Private Sub dgwGrillaSolicitudes_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgwGrillaSolicitudes.CellPainting
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            Try
              
                If dgwGrillaSolicitudes.Columns(e.ColumnIndex).Name = "col_sol_obs_img" Then

                    e.CellStyle.BackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita

                End If
            Catch ex As Exception

            End Try
        End Sub

   

        Private Sub txtDocumentoBusca_Validated(sender As Object, e As System.EventArgs) Handles _
            txtDocumentoBusca.Validated, _
            txtApellidosNombresBus.Validated

            ListarFiltroGrilla()

        End Sub

        Private Sub chkRegistrosObservados_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkRegistrosObservados.CheckedChanged
            ListarFiltroGrilla()
        End Sub

        Private Sub btnValidarReniec_Click(sender As System.Object, e As System.EventArgs) Handles btnValidarReniec.Click
            FRM_ValidarVisitaReniec("", 1)
        End Sub

        Private Sub BackgroundWorker3_Disposed(sender As Object, e As System.EventArgs) Handles BackgroundWorker3.Disposed
            If Me.BackgroundWorker3.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker3 = Nothing
            End If
        End Sub

        Private Sub BackgroundWorker3_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker3.CancellationPending = True Then
                e.Cancel = True
            Else

                Dim blnHayReniec As Boolean = False
                Dim strErrorReniec As String = ""
                Dim strMensajeReniec As String = ""

                e.Result = ConsultarReniecHilo(worker, e)

            End If

        End Sub

        Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted

            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoadRnc.Close()

                objInternoReniec = New Bussines.Visita.VisitanteReniec.objDTOPersona
                objInternoReniec = e.Result

            End If
        End Sub

        Private Sub txtDocumentoBusca_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDocumentoBusca.TextChanged

        End Sub

        Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        End Sub

        Private Sub cbbEstablecimientoPenitenciario_Load(sender As System.Object, e As System.EventArgs) Handles cbbEstablecimientoPenitenciario.Load

        End Sub
    End Class
End Namespace
