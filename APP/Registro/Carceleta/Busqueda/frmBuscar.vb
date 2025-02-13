Imports System.ComponentModel

Namespace Registro.Main.Carceleta
    Public Class frmBuscar
        Private objBss As Bussines.Registro.Interno = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing
        Private objBssMov As Bussines.Registro.InternoMovimiento = Nothing
        Private entMovCol As Entity.Registro.InternoMovimientoCol
        Private frmLoad As Load.frmLoad = Nothing
        Private PerfilUsuarioActual As Type.Enumeracion.Usuario.EnumDependencia
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaInternoID() As Long
            Get
                Dim value As Long = -1
                Try
                    Select Case Me.tbcCarceleta.SelectedTab.Name
                        Case Me.tbpBusquedaInterno.Name

                            If dgwGrilla.RowCount > 0 Then
                                value = Me.dgwGrilla.Item("col_int_id", Me.dgwGrilla.CurrentRow.Index).Value
                            End If

                        Case Me.tbpMovimiento.Name
                            value = Me.UscBusquedaCarceleta1._IDInternoSelect()
                        Case Me.tbpIntegracionInterno.Name
                            value = Me.UscBuscaRegIntegracion1._GrillaInternoCodigo
                        Case Me.tpBandeja.Name
                            value = Me.dgwBandeja.Item("bnd_col_int_id", Me.dgwBandeja.CurrentRow.Index).Value
                    End Select
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaRegionOrigenId() As Integer
            Get
                Dim value As Integer = -1
                Try
                    value = Me.dgwBandeja.SelectedRows(0).Cells("col_reg_ori_id").Value
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaPenalOrigenId() As Integer
            Get
                Dim value As Integer = -1
                Try
                    value = Me.dgwBandeja.SelectedRows(0).Cells("col_pen_ori_id").Value
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaMovimientoTrasladoId() As Integer
            Get
                Dim value As Integer = -1
                Try
                    value = Me.dgwBandeja.SelectedRows(0).Cells("bnd_col_mov_id").Value
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
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
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
        Private ReadOnly Property RegionID() As Short
            Get
                Return 3 'region lima
            End Get

        End Property
        Private ReadOnly Property PenalID() As Short
            Get
                Return 35 'carcelta
            End Get
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
        'Private Property IngresoFechaDesde() As Long
        '    Get
        '        Return Me.dtpFechaIni.ValueLong
        '    End Get
        '    Set(ByVal value As Long)
        '        Me.dtpFechaIni.ValueLong = value
        '    End Set
        'End Property
        'Private Property IngresoFechaHasta() As Long
        '    Get
        '        Return Me.dtpFechaFin.ValueLong
        '    End Get
        '    Set(ByVal value As Long)
        '        Me.dtpFechaFin.ValueLong = value
        '    End Set
        'End Property
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

        Private Property TipoDocumento() As Integer
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
        Private intLoadTipoDocumentoId As Integer = -1
        Private strLoadNumDocIdentidad As String = ""

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
        Private Property LoadTipoDocumentoId() As Integer
            Get
                Return intLoadTipoDocumentoId
            End Get
            Set(ByVal value As Integer)
                intLoadTipoDocumentoId = value
            End Set
        End Property
        Private Property LoadNumDocIdentidad() As String
            Get
                Return strLoadNumDocIdentidad
            End Get
            Set(ByVal value As String)
                strLoadNumDocIdentidad = value
            End Set
        End Property
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
        'Private Sub ComboRegion()

        '    Dim blnTodos As Boolean = False

        '    If Configuracion.Licencia.Codigo = 1 Then 'sede central
        '        blnTodos = True

        '        With Me.cbbRegion
        '            .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
        '            ._Todos = blnTodos
        '            .Parametro1 = Configuracion.Licencia.Codigo
        '            .LoadUsc()
        '        End With

        '        Me.RegionID = 3 'region lima
        '    End If

        'End Sub

        'Private Sub ComboPenal()

        '    Dim blnTodos As Boolean = False

        '    If Configuracion.Licencia.Codigo = 1 Then 'sede central
        '        blnTodos = True
        '        With Me.cbbPenal
        '            ._Todos = blnTodos
        '            .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
        '            .CodigoPadre = Me.RegionID
        '            .Parametro1 = Configuracion.Licencia.Codigo
        '            .LoadUsc()
        '        End With
        '        Me.PenalID = 35 'carcelta de lima 
        '    End If
        'End Sub
        Private Sub Combo()

            With Me.cbbNacionalidad
                ._Todos = True
                .LoadUsc()
            End With

        End Sub

        Private Sub ComboTipoDocumento()

            With Me.cbbTipoDoc
                ._Todos = True
                .LoadUsc()
            End With

        End Sub

#End Region
#Region "Functions"
        Private Function GrillaCountInternosPrincipal() As Integer

            Dim value As Integer = 0

            With Me.dgwGrilla
                .CurrentCell = Nothing
                For Each dr As DataGridViewRow In .Rows

                    If dr.Cells("col_pdr").Value = 0 Then
                        value = value + 1
                    End If
                Next
            End With

            Return value

        End Function

#End Region
#Region "Validar"
        Private Function ValidarBusqueda() As Boolean

            Dim value As Boolean = False

            'validar que el tener la opcion todos ingrese un dato
            If (Me.ApellidoPaterno.Length < 2) And (Me.ApellidoMaterno.Length < 2) And Me.CodigoRP.Length < 5 And txtNumDoc.Text.Length = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese algun apellido o codigo, para realizar la busqueda")
                Me.txtApePat.Focus()
                Return value
            End If

            'delito especifico
            If Me.DelitoGenericoID = -1 Then
                If Me.DelitoEspecificoID > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Primero seleccione el delito generico")
                    Me.cbbDelitoGenerico.Focus()
                    Return value
                End If
            End If

            If cbbTipoDoc.SelectedValue = -1 And txtNumDoc.Text.Length > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe elegir el tipo de documento de identidad.")
                Return value
            End If
            If txtNumDoc.Text.Trim.Length = 0 Then
                cbbTipoDoc.SelectedValue = -1
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
            LoadExtranjero = Me.NacionalidadExtranjero
            LoadNacionalidadPais = Me.NacionalidadPais
            LoadDelGen = Me.DelitoGenericoID
            LoadDelEsp = Me.DelitoEspecificoID
            LoadSitJur = Me.SituacionJuridicaID
            LoadTipoDocumentoId = Me.TipoDocumento
            LoadNumDocIdentidad = Me.NumeroDocumento
            'LoadFechaIni = Me.IngresoFechaDesde
            'LoadFechaFin = Me.IngresoFechaHasta
            LoadRegion = Me.RegionID
            LoadPenal = Me.PenalID
            'LoadPenalMult = Me.PenalMultiple
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
                    .IDRegion = Me.LoadRegion
                    .IDPenal = Me.LoadPenal
                    .IDSexo = Me.LoadSexo
                    .NacionalidadExtranjero = Me.LoadExtranjero
                    .IDNacionalidad = Me.LoadNacionalidadPais
                    .IDTipoDocIdentidad = Me.LoadTipoDocumentoId
                    .InternoNumeroDocumento = Me.LoadNumDocIdentidad
                    '/*delito*/
                    .IDDelitoGenerico = Me.LoadDelGen
                    .IDDelitoEspecifico = Me.LoadDelEsp
                    '/*ingreso*/
                    .FechaIngresoIni = Me.LoadFechaIni
                    .FechaIngresoFin = Me.LoadFechaFin
                    .IDSituacionJuridica = Me.LoadSitJur
                    '/**estado en funcion al traslado/
                    .IDInternoEstado = -1
                    Select Case Me.LoadEstado
                        Case -1
                            .TrasladadoDeCarceleta = -1
                        Case 0
                            .TrasladadoDeCarceleta = 1
                        Case 1
                            .TrasladadoDeCarceleta = 0

                    End Select
                End With
                objEntCol = objBss.Listar_Carceleta(objEntFiltro)

                Return True
            End If

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

            If Me.dgwGrilla.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Ningún registro encontrado.")
            End If

        End Sub

        Private Sub BuscarMovimientos(Optional mostrarAlertaRegNoEncontrado As Boolean = True, Optional buscarRegConFechaHoy As Boolean = False)

            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0

            With Me.UscBusquedaCarceleta1
                ._Buscar(mostrarAlertaRegNoEncontrado)
                Me.NumeroReg = ._GrillaCount
                ._Focus()
            End With

            Dim dteFechaFin As Date = Now

            intSeg = DateDiff(DateInterval.Second, dteFechaIni, dteFechaFin)
            Me.lblSegundo.Text = intSeg.ToString("00:00:00")


        End Sub

        Private Sub BuscarInternoIntegracion()
            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0

            With Me.UscBuscaRegIntegracion1
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
            objLista.Add(Me.NumeroDocumento)
            'combos
            objLista.Add(Me.RegionID)
            objLista.Add(Me.PenalID)
            objLista.Add(Me.cbbNacionalidad.SelectedValue)
            objLista.Add(Me.DelitoGenericoID)
            objLista.Add(Me.DelitoEspecificoID)
            objLista.Add(Me.TipoDocumento)
            'radio buton
            objLista.Add(Me.Estado)
            objLista.Add(Me.NacionalidadExtranjero)
            objLista.Add(Me.SituacionJuridicaID)
            objLista.Add(Me.Sexo)
            'fecha
            'objLista.Add(Me.IngresoFechaDesde)
            'objLista.Add(Me.IngresoFechaHasta)
            Dim FiltroConcatenado As String = ""
            For Each obj As String In objLista
                FiltroConcatenado = FiltroConcatenado & obj
            Next
            Return FiltroConcatenado
        End Function

        Private Sub ListarIngreso()

            If Me.GrillaInternoID < 1 Then
                limpiarIngreso()
                Exit Sub
            End If

            If Me.InternoID = Me.GrillaInternoID And Me.IngresoNumero.Length > 0 Then
                'nada
            Else

                Dim obBssIngreso As New Bussines.Registro.IngresoInpe
                Dim objEntIngreso As New Entity.Registro.IngresoInpe
                objEntIngreso.InternoID = Me.GrillaInternoID
                objEntIngreso.PenalID = Me.GrillaPenalID
                objEntIngreso.PerfilUsuarioId = Me.PerfilUsuarioActual
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
                Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente_LM(Me.GrillaInternoID) 'objBssFoto.ListarIDFotoReciente2(Me.GrillaInternoID)
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

        'Private Sub Buscar_GrillaNacional()

        '    With Me.UscBuscaRegIntegracion1
        '        ._LoadUsc()
        '    End With

        'End Sub

#End Region
#Region "Accion"
        Private Sub Exportar()
            Select Case Me.tbcCarceleta.SelectedTab.Name
                Case Me.tbpBusquedaInterno.Name
                    Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

                Case Me.tbpMovimiento.Name
                    Me.UscBusquedaCarceleta1._Exportar()

                Case Me.tbpIntegracionInterno.Name
                    Me.UscBuscaRegIntegracion1._Exportar()
            End Select
        End Sub

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
            Me.NacionalidadExtranjero = -1 'todos
            Me.Sexo = -1 'todos
            Me.SituacionJuridicaID = -1
            'Me.IngresoFechaDesde = 0
            'Me.IngresoFechaHasta = 0
            Me.DelitoGenericoID = -1
            Me.DelitoEspecificoID = -1
            Me.TipoDocumento = -1
            Me.NumeroDocumento = ""

            Me.txtApePat.Focus()

        End Sub

        Private Sub FRM_Ver_Reportes()

            Dim frm As New Registro.Reporte.frmReportePopup_LM '.frmReportePopupv2
            With frm
                ._RegionID = 3 'region lima Me.RegionID
                ._PenalID = 35 'carceleta Me.PenalID 
                ._TipoReporte = Reporte.frmReportePopup_LM.enmListarReportes.Todos
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                ._InternoID = Me.GrillaInternoID
                ._InternoApeNom = Me.GrillaApellidos & " " & Me.GrillaNombres
                .ShowDialog()
            End With

        End Sub

        Private Sub NuevoInterno()
            Dim blnOK As Boolean = False
            Dim blnOKReniec As Boolean = False
            Dim intIDInternoSelecionado As Long = -1

            Dim frm As New Registro.Main.Carceleta.frmBuscaInternoPopup
            Dim tipoAccion As Registro.Main.Carceleta.frmBuscaInternoPopup.enmTipoAccion

            With frm
                .IDPenal = 35 'carceleta
                .IDRegion = 3 ''region lima
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    intIDInternoSelecionado = ._IDInternoSelecionado
                    tipoAccion = ._TipoAccion
                    blnOK = True
                End If
            End With

            If blnOK = True Then
                Me.InternoRegion = 3 'region lima
                Me.InternoRegionNombre = "Region Lima"
                Me.InternoPenal = 35 'carcelta
                Me.InternoPenalNombre = "Carceleta"

                Select Case tipoAccion
                    Case frmBuscaInternoPopup.enmTipoAccion.SIGUIENTE_OPCION_RENIEC
                        Dim f2 As New Registro.Main.Carceleta.frmTipoNacionalidad
                        If f2.ShowDialog = Windows.Forms.DialogResult.OK Then
                            If f2._ValidarConReniec = True Then
                                blnOKReniec = True
                            Else
                                FRM_Mantenimiento(True, -1)
                            End If
                        End If
                    Case frmBuscaInternoPopup.enmTipoAccion.IMPORTAR_REGISTRO_SEDE
                        'FRM_Mantenimiento(true, intIDInternoSelecionado)
                    Case frmBuscaInternoPopup.enmTipoAccion.REGISTRO_EXISTENTE
                        FRM_Mantenimiento(False, intIDInternoSelecionado)
                    Case frmBuscaInternoPopup.enmTipoAccion.REGISTRO_INTERNO_MANUAL
                        FRM_Mantenimiento(True, -1)
                End Select
            End If

            If blnOKReniec = True Then
                Dim f3 As New Registro.Main.Carceleta.frmBuscaReniecPopup
                f3._PenalId = Me.PenalID
                f3._RegionId = Me.RegionID
                If f3.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Select Case f3._tipoAccion
                        Case frmBuscaReniecPopup.enmAccion.NUEVO_INTERNO_DESDE_RENIEC
                            FRM_Mantenimiento(False, f3._IdInterno, True)
                        Case frmBuscaReniecPopup.enmAccion.NUEVO_INTERNO_SIN_RENIEC
                            FRM_Mantenimiento(True, -1)
                    End Select
                End If
            End If
        End Sub
#End Region
#Region "Form"
        Private Sub FRM_Mantenimiento(ByVal Nuevo As Boolean, IDInternoSeleccionado As Long, Optional origenReniec As Boolean = False)
            Dim verSoloLectura As Boolean = False
            'origenReniec : si los datos provienen de reniec se debe asignar un codigo unico.
            Dim frm As New Registro.Main.Carceleta.frmMantenimiento
            frm.MdiParent = Me.MdiParent
            With frm
                If Nuevo = True Then
                    ._IDInterno = -1
                    ._IDInternoSeleccionado = IDInternoSeleccionado
                    .RegionID = Me.InternoRegion
                    .RegionNombre = Me.InternoRegionNombre
                    .PenalID = Me.InternoPenal
                    .PenalNombre = Me.InternoPenalNombre
                Else
                    If IDInternoSeleccionado < 1 Then
                        Exit Sub
                    End If
                    ._IDInterno = IDInternoSeleccionado
                End If


                If Me.tbcCarceleta.SelectedTab.Name = Me.tbpIntegracionInterno.Name Then
                    Dim entInterno As New Entity.Registro.Interno

                    entInterno = (New Bussines.Registro.Interno).Listar_LM(IDInternoSeleccionado)

                    If entInterno.PenalID <> Me.PenalID Then
                        verSoloLectura = True
                    End If
                End If

                If verSoloLectura = True Then
                    ._FormLectura = False
                    ._FormEscritura = False
                    ._FormReporte = False
                    ._FormImpresion = False
                    ._FormEliminar = False
                Else
                    .RegionID = 3 'region lima
                    .PenalID = 35 'penal carceleta
                    '/*permisos*/
                    ._FormLectura = Me._FormLectura
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar
                End If

                .Show()
            End With

        End Sub
        Private Sub FRM_VerificarHuella()
            Dim f As New Registro.Busqueda.frmBusquedaPorHuella
            f.MdiParent = Me.MdiParent
            f._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
            f._RegionId = 3 'region lima Me.RegionID
            f._PenalId = 35 'carceleta Me.PenalID 
            f._NombrePenal = "Establecimiento transitorio"
            f.Show()
        End Sub
        Private Sub FRM_MantIntegracion(Nuevo As Boolean)
            'Dim f As New Registro.Integracion.frmIntegracionMant
            'f._Codigo = If(Nuevo = True, -1, UscBuscaRegIntegracion1._GrillaInternoCodigo)
            'f.MdiParent = Me.MdiParent
            'f.Show()
        End Sub
        Private Sub VerDetalleInterno(interno_id As Integer)

            Dim frm As New Registro.Main.Carceleta.frmMantenimiento
            frm.MdiParent = Me.MdiParent
            With frm
                ._IDInterno = interno_id
                ._FormEscritura = False
                ._FormReporte = False
                ._FormEliminar = False
                .Show()
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub limpiarIngreso()
            Me.IngresoNumero = ""
            Me.IngresoFecha = ""
            Me.IngresoSituacionJuridica = ""
            Me.TipoEgreso = ""
            Me.EgresoFecha = ""
            Me.PenalClasificacion = ""
        End Sub

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

            Me.pnlBandeja.Visible = False

            Select Case Legolas.Configuration.Usuario.OficinaID
                Case 1 'osin
                    '
                Case Else
                    Me.lblSegundo.Visible = False
            End Select

            Me.pnlRegionPenal.Visible = False

            Combo()
            ComboTipoDocumento()
            ComboDelitoGenerico()
            ComboDelitoEspecifico()
            dgwGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Me.dgwGrilla.VisibleCampos = True

            Me.cbbRegion.Enabled = False
            Me.cbbPenal.Enabled = False

        End Sub

        Private Sub ValidarFiltro()

            FiltroNuevo = ConcatenarFiltro()
            If FiltroNuevo <> FiltroActual Then
                Me.dgwGrilla.DataSource = Nothing
                Me.NumeroReg = 0
            End If
        End Sub
#End Region
#Region "Usuario/Permisos"
        Private blnEscritura As Boolean = False
        Private blnEliminar As Boolean = False
        Private blnReporte As Boolean = False

        Private Sub HabilitarControlesxTabs()

            Dim blnVerBandeja As Boolean = False
            Dim blnVerNuevo As Boolean = False
            Dim blnVerModificar As Boolean = False
            Dim blnVerReporte As Boolean = False

            Select Case Me.tbcCarceleta.SelectedTab.Name

                Case Me.tbpMovimiento.Name

                    blnVerModificar = blnEscritura
                    blnVerReporte = blnReporte

                    Me.UscBusquedaCarceleta1._Focus()

                Case Me.tbpBusquedaInterno.Name

                    blnVerNuevo = blnEscritura
                    blnVerModificar = blnEscritura
                    blnVerReporte = blnReporte

                    Me.txtApePat.Focus()

                Case Me.tpBandeja.Name

                    blnVerBandeja = True
                    CargarBandejaPendiente(False)

            End Select

            Me.pnlBandeja.Visible = blnVerBandeja
            Me.pnlNuevo.Visible = blnVerNuevo
            Me.pnlModificar.Visible = blnVerModificar
            Me.pnlReporte.Visible = blnVerReporte

        End Sub
        Private Sub UsuarioPermisos(ByRef blnCerrarForm As Boolean)

            Me.PerfilUsuarioActual = Legolas.Configuration.Usuario.OficinaID

            Select Case Me.IDLicencia
                Case 1 'sede central

                    'escritura 
                    If Me._FormEscritura = True Then

                        Select Case Legolas.Configuration.Usuario.NivelUsuario
                            Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta,
                                 Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                                Select Case Me.PerfilUsuarioActual

                                    Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                                        blnEscritura = Me._FormEscritura

                                    Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario
                                        blnEscritura = Me._FormEscritura

                                    Case Type.Enumeracion.Usuario.EnumDependencia.GabineteIdentificacionOdontologo
                                        blnEscritura = Me._FormEscritura

                                    Case Else
                                        blnEscritura = False
                                End Select

                            Case Else
                                blnEscritura = False
                        End Select

                    End If

                    'eliminar 
                    If Me._FormEliminar = True Then
                        Select Case Legolas.Configuration.Usuario.NivelUsuario
                            Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta,
                                 Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                                Select Case Me.PerfilUsuarioActual

                                    Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                                        blnEliminar = Me._FormEliminar

                                    Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario
                                        blnEliminar = Me._FormEliminar

                                    Case Else
                                        blnEliminar = False
                                End Select

                            Case Else
                                blnEliminar = False
                        End Select
                    End If

                    'reporte 
                    If Me._FormReporte = True Then
                        Select Case Legolas.Configuration.Usuario.NivelUsuario
                            Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta,
                                 Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                                Select Case Legolas.Configuration.Usuario.OficinaID

                                    Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                                        blnReporte = Me._FormReporte

                                    Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario
                                        blnReporte = Me._FormReporte

                                    Case Else
                                        blnReporte = False
                                End Select

                            Case Else
                                blnReporte = False
                        End Select
                    End If

                    'Me.pnlNuevo.Visible = blnEscritura
                    Me.pnlModificar.Visible = blnEscritura
                    'Me.pnlExportar.Visible = Me._FormReporte
                    Me.pnlReporte.Visible = blnReporte

                    Me.UscBusquedaCarceleta1._PerfilUsuario = Me.PerfilUsuarioActual
                    UsuarioPerfil()

                Case Else 'penal o provincias
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Modulo de Carceleta solo está disponible en la Sede Central")
                    blnCerrarForm = True
                    Me.Close()
            End Select

        End Sub
        Private Sub UsuarioPerfil()

            'eliminacion de tabs
            Select Case Me.PerfilUsuarioActual

                Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion

                Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario

                Case Else

                    Me.btnVerifHuella.Visible = False
                    Me.tbcCarceleta.TabPages.Remove(tpBandeja)

            End Select

        End Sub

        Private Function VerBandeja() As Boolean
            If Me.PerfilUsuarioActual = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Or Me.PerfilUsuarioActual = Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario Then
                If dgwBandeja.Rows.Count > 0 Then
                    If MessageBox.Show("Tiene internos pendientes de recepción en la bandeja de entrada, desea recepcionar el/los interno(s)?.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                        tbcCarceleta.SelectedTab = tpBandeja
                        Return False
                    End If
                End If
            End If

            Return True
        End Function
#End Region
        Private Sub frmBuscar_Load2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.tbcCarceleta.TabPages.Remove(tbpIntegracionInterno) 'en esta version no aplica integracion          

            HabilitarControlesxTabs()
            ValoresxDefault()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Select Case Me.tbcCarceleta.SelectedTab.Name
                Case Me.tbpBusquedaInterno.Name
                    Buscar()
                Case Me.tbpMovimiento.Name
                    BuscarMovimientos()
                Case Me.tbpIntegracionInterno.Name
                    BuscarInternoIntegracion()
            End Select
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            If VerBandeja() = False Then Exit Sub

            Me.Cursor = Cursors.WaitCursor
            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                FRM_Mantenimiento(False, Me.GrillaInternoID)
            End If
            Me.Cursor = Cursors.Default
        End Sub



        Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
        txtCodInterno.KeyPress,
        txtApePat.KeyPress,
        txtApeMat.KeyPress,
        txtNom.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            If e.KeyCode = Keys.Delete Then
                If Me._FormEliminar = False Then
                    Legolas.Configuration.Aplication.MessageBox.Information("No tiene permiso para eliminar registros.")
                    Exit Sub
                End If
                AEliminar()
            End If

        End Sub

        Private Sub cbbDelitoGenerico__ValueChanged() Handles cbbDelitoGenerico._SelectedIndexChanged
            ComboDelitoEspecifico()
        End Sub

        Private Sub cbbuscPenal__ValueChanged() Handles cbbPenal._SelectedIndexChanged
            ColumnasVisible()
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
            If VerBandeja() = False Then Exit Sub

            Select Case Me.tbcCarceleta.SelectedTab.Name
                Case Me.tbpBusquedaInterno.Name
                    NuevoInterno()
                Case Me.tbpMovimiento.Name
                    NuevoInterno()
                Case Me.tbpIntegracionInterno.Name
                    FRM_MantIntegracion(True)
            End Select
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
            Exportar()
        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
            If VerBandeja() = False Then Exit Sub

            Select Case Me.tbcCarceleta.SelectedTab.Name

                Case Me.tbpMovimiento.Name

                    If Me.UscBusquedaCarceleta1._GrillaCount > 0 Then
                        FRM_Mantenimiento(False, Me.GrillaInternoID)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Information("Selecione el registro del interno a modificar")
                    End If

                Case Me.tbpBusquedaInterno.Name

                    If Me.dgwGrilla.RowCount > 0 Then
                        FRM_Mantenimiento(False, Me.GrillaInternoID)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Information("Selecione el registro del interno a modificar")
                    End If

                Case Me.tbpIntegracionInterno.Name

                    If Me.UscBuscaRegIntegracion1._GrillaCount > 0 Then
                        FRM_MantIntegracion(False)
                    End If

            End Select

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub BackgroundWorker1_Disposed(sender As Object, e As System.EventArgs) Handles BackgroundWorker1.Disposed
            If Me.BackgroundWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario canceló el proceso de búsqueda")
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
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()
                result = e.Result
            End If
        End Sub

        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Dim blnCerrar As Boolean = False
            Me.WindowState = FormWindowState.Maximized
            UsuarioPermisos(blnCerrar)
            Me.Refresh()

            'preguntar el form
            If blnCerrar = False Then

                With Me.UscBusquedaCarceleta1
                    ._LoadUsc()
                End With

                BuscarMovimientos(False, True)
                CargarBandejaPendiente(False)

            End If

        End Sub

        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex
                    Case .Columns("col_fec_nac").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
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

            Select Case Me.tbcCarceleta.SelectedTab.Name

                Case Me.tbpMovimiento.Name
                    Me.UscBusquedaCarceleta1._Limpiar()

                Case Me.tbpBusquedaInterno.Name
                    ALimpiar()

                Case Me.tbpIntegracionInterno.Name
                    Me.UscBuscaRegIntegracion1._ALimpiar()
            End Select

            lblSegundo.Text = "00:00:00"
            lblReg.Text = "0 Reg."
        End Sub

        Private Sub txtCodInterno_TextChanged(sender As System.Object, e As System.EventArgs) Handles _
            txtCodInterno.TextChanged,
            txtApePat.TextChanged,
            txtApeMat.TextChanged,
            txtNom.TextChanged

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

        Private Sub dtpFechaIni__ValueChanged()
            ValidarFiltro()
        End Sub

        Private Sub UscFotografia_2v1__CheckClick() Handles UscFotografia_2v1._CheckClick
            ShowFotografia()
        End Sub

        Private Sub UscBusquedaCarceleta1__Grilla_CellDoubleClick() Handles UscBusquedaCarceleta1._Grilla_CellDoubleClick
            If VerBandeja() = False Then Exit Sub

            Me.Cursor = Cursors.WaitCursor
            FRM_Mantenimiento(False, Me.GrillaInternoID)
            Me.Cursor = Cursors.Default
        End Sub

        Private Sub UscBusquedaCarceleta1__Grilla_CellEnter() Handles UscBusquedaCarceleta1._Grilla_CellEnter
            ShowFotografia()
            ListarIngreso()
        End Sub

        Private Sub UscBusquedaCarceleta1__Grilla_ValidarFiltro() Handles UscBusquedaCarceleta1._Grilla_ValidarFiltro
            Me.lblSegundo.Text = "00:00:00"
            Me.NumeroReg = 0
        End Sub


        Private Sub UscBusquedaNacionalCarceleta1__Grilla_CellEnter()
            ShowFotografia()
            ListarIngreso()
        End Sub

        Private Sub UscBusquedaNacionalCarceleta1__Grilla_CellDoubleClick(InternoId As System.Int32)
            btnModificar.PerformClick()
        End Sub

        Private Sub UscBusquedaNacionalCarceleta1__Grilla_NumRowsChange(TotalRegistros As System.Int32, TiempoDuracion As System.String)
            lblReg.Text = TotalRegistros & " Reg."
            lblSegundo.Text = TiempoDuracion
        End Sub

        Private Sub UscBuscaRegIntegracion1__Grilla_CellDoubleClick() Handles UscBuscaRegIntegracion1._Grilla_CellDoubleClick
            FRM_MantIntegracion(False)
        End Sub

        Private Sub UscBuscaRegIntegracion1__Cell_Click_VerDetalleInterno(interno_id As System.Int32, interno_pen_id As System.Int32, interno_reg_id As System.Int32) Handles UscBuscaRegIntegracion1._Cell_Click_VerDetalleInterno
            VerDetalleInterno(interno_id)
        End Sub

        Private Sub btnRefresBandeja_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresBandeja.Click
            CargarBandejaPendiente(True)
        End Sub

        Private Sub CargarBandejaPendiente(Optional mostrarAlertarPopup As Boolean = True)
            'Dim t As DataTable
            't = (New Bussines.Registro.InternoMovimiento).ListarPendRecepTraslado(Me.PenalID)

            Dim ws As New APPWebService.ws_pope_sede_plm_carceleta.Carceleta
            ws.Url = APPWebService.PathURL.ws_sede_plm_carceleta
            Try
                ws._test()
            Catch ex As Exception
                If mostrarAlertarPopup = True Then Legolas.Configuration.Aplication.MessageBox.Exclamation("En estos momentos el servicio de la Sede Central no está disponible, intente luego de unos instantes.")
                Exit Sub
            End Try

            Dim t As DataTable
            t = ws.ListaPendRecepTraslado(Me.PenalID)


            Me.ban_fec_nac.Tag = "fecha"
            With dgwBandeja
                .AutoGenerateColumns = False
                .DataSource = t
            End With

            Dim cant As Integer = 0
            Dim num As String = ""
            cant = t.Rows.Count
            Select Case cant
                Case 0
                    num = ""
                Case Else
                    num = "(" & Format(cant, "0#") & ")"
            End Select
            tpBandeja.Text = "Bandeja de entrada " & num
        End Sub

        Private Sub btnDescargar_Click(sender As System.Object, e As System.EventArgs) Handles btnDescargar.Click
            Dim int_id As Integer = -1

            int_id = Me.GrillaInternoID
            If dgwBandeja.Rows.Count = 0 Then Exit Sub
            If MsgBox("Se va a recepcionar y registrar al interno seleccionado, desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) <> MsgBoxResult.Yes Then
                Exit Sub
            End If

            Dim id As Integer = -1
            Dim bss As New Bussines.Transferencia.RecepcionInternoTraslado(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno,
                                                                           Me.GrillaRegionOrigenId, Me.GrillaPenalOrigenId)  'solo es necesario el objeto

            id = bss.RecepcionIntTrasladoOrigenEPLM(int_id, Me.GrillaRegionOrigenId, Me.GrillaPenalOrigenId, Me.GrillaMovimientoTrasladoId)
            If id < 0 Then
                'id = bssIntHist.Eliminar(intHistId)
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Hubo un error durante la recepción del interno, comuniquese con el administrador de sistema.")
                Exit Sub
            End If

            btnRefresBandeja.PerformClick()
            Legolas.Configuration.Aplication.MessageBox.Information("La operación se ha completado satisfactoriamente, ahora se procede a mostrar la información del interno.")

            Dim frm As New Registro.Main.Carceleta.frmMantenimiento

            frm.MdiParent = Me.MdiParent
            With frm
                ._IDInterno = int_id
                .PenalID = Me.PenalID
                .RegionID = Me.RegionID
                '/*permisos*/
                ._FormLectura = Me._FormLectura
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormImpresion = Me._FormImpresion
                ._FormEliminar = Me._FormEliminar
                .Show()
            End With
        End Sub

        Private Sub btnVerifHuella_Click(sender As System.Object, e As System.EventArgs) Handles btnVerifHuella.Click

            FRM_VerificarHuella()

        End Sub

        Private Sub tbcCarceleta_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tbcCarceleta.SelectedIndexChanged

            ShowFotografia()
            ListarIngreso()

            HabilitarControlesxTabs()

            'UsuarioPerfil()

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub


    End Class
End Namespace
