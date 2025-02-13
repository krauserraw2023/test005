Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Linq

Namespace Registro.PenalLM.Busqueda
    Public Class frmBuscar
        Private objBss As Bussines.Registro.Interno = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing
        Private objEntFiltroLoad As Entity.Registro.Interno_Grilla = Nothing
        Private frmLoad As Load.frmLoad = Nothing
        Private frmProcesando As Load.frmProcesando = Nothing

        Private outDownSMS As String = ""
        Private n_interno_id As Integer = -1

        Private nInternoSedeId_hilo As Integer = -1
        Private nRegionId_hilo As Integer = -1
        Private nPenalId_hilo As Integer = -1
        Private blnCargoForm As Boolean = False

#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    If tcConsultaInternoMovimientos.SelectedTab.Name = "tpConsultaInterno" Then
                        With Me.dgwGrilla
                            intValue = .SelectedRows(0).Cells("col_int_id").Value
                        End With
                    ElseIf tcConsultaInternoMovimientos.SelectedTab.Name = "tpConsultaMovimiento" Then
                        If UscBusquedaMovimiento1._GrillaCount > 0 Then
                            intValue = UscBusquedaMovimiento1._IDInternoSelect
                        End If
                    ElseIf tcConsultaInternoMovimientos.SelectedTab.Name = "tpBandeja" Then
                        intValue = dgwBandeja.SelectedRows(0).Cells("bnd_col_int_id").Value
                    End If
                Catch ex As Exception
                    Dim s As String
                    s = s
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
        'Private ReadOnly Property GrillaIngresoID() As Integer
        '    Get
        '        Dim intValue As Integer = -1
        '        Try
        '            With Me.dgwGrilla
        '                intValue = .SelectedRows(0).Cells("col_ing_id").Value
        '            End With
        '        Catch ex As Exception

        '        End Try
        '        Return intValue
        '    End Get
        'End Property
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
        Private Property PerfilActual As Integer
#End Region
#Region "Combo"
        Private Sub ComboDelitoEspecifico()

            With Me.cbbDelitoEspecifico
                '.DropDownWidth = .Width + 150
                ._Todos = True
                .CodigoPadre = Me.DelitoGenericoID
                .LoadUsc()

                If Me.DelitoGenericoID < 1 Then
                    .Enabled = False
                Else
                    .Enabled = True
                End If

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
            'cbbRegion.Enabled = False
            'cbbRegion.SelectedValue = 3
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
        Private Sub Combo()

            'FormActualizarNacionalidad()
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
            Dim intCount As Integer = 0
            If tcConsultaInternoMovimientos.SelectedTab.Name = "tpConsultaInterno" Then
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


            If Me.PenalID > 0 Then
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

            objEntFiltroLoad = New Entity.Registro.Interno_Grilla

            With objEntFiltroLoad
                .IDRegion = Me.RegionID
                .IDPenal = Me.PenalID
                .InternoCodigoRP = Me.CodigoRP
                .PrimerApellido = Me.ApellidoPaterno
                .SegundoApellido = Me.ApellidoMaterno
                .PreNombres = Me.Nombres
                .InternoAlias = Me.NombresAlias
                .NacionalidadExtranjero = Me.NacionalidadExtranjero
                .IDNacionalidad = Me.NacionalidadPais
                .IDSexo = Me.Sexo
                .IDSituacionJuridica = Me.SituacionJuridicaID

                .IDTipoDocIdentidad = Me.IDTipoDocumento
                .InternoNumeroDocumento = Me.NumeroDocumento

                .IDDelitoGenerico = Me.DelitoGenericoID
                .IDDelitoEspecifico = Me.DelitoEspecificoID

                .IDInternoEstado = Me.Estado

            End With

        End Sub

        Private Function Listar() As Boolean

            Dim objBss As New Bussines.Registro.Interno_Grilla
            Dim objEntFiltro As New Entity.Registro.Interno_Grilla

            With objEntFiltro

                '/*interno*/
                .IDRegion = objEntFiltroLoad.IDRegion
                .IDPenal = objEntFiltroLoad.IDPenal
                .InternoCodigoRP = objEntFiltroLoad.InternoCodigoRP
                .PrimerApellido = objEntFiltroLoad.PrimerApellido
                .SegundoApellido = objEntFiltroLoad.SegundoApellido
                .PreNombres = objEntFiltroLoad.PreNombres
                .NacionalidadExtranjero = objEntFiltroLoad.NacionalidadExtranjero
                .IDNacionalidad = objEntFiltroLoad.IDNacionalidad
                .IDSexo = objEntFiltroLoad.IDSexo

                .IDTipoDocIdentidad = objEntFiltroLoad.IDTipoDocIdentidad
                .InternoNumeroDocumento = objEntFiltroLoad.InternoNumeroDocumento
                .IDInternoEstado = objEntFiltroLoad.IDInternoEstado

                '/*filtros x tablas*/
                .InternoAlias = objEntFiltroLoad.InternoAlias
                .IDSituacionJuridica = objEntFiltroLoad.IDSituacionJuridica
                .IDDelitoGenerico = objEntFiltroLoad.IDDelitoGenerico
                .IDDelitoEspecifico = objEntFiltroLoad.IDDelitoEspecifico
            End With

            objEntCol = objBss.Listar_PLM(objEntFiltro)

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

        Private Sub BuscarMovimientos()

            Dim dteFechaIni As Date = Now
            Dim intSeg As Integer = 0

            Me.lblSegundo.Text = "00:00:00"
            Me.lblSegundo.Refresh()

            With UscBusquedaMovimiento1
                ._IDRegion = Me.RegionID
                ._IDPenal = Me.PenalID
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
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
            objLista.Add(Me.NombresAlias)
            objLista.Add(Me.NumeroDocumento)
            'combos
            objLista.Add(Me.RegionID)
            objLista.Add(Me.PenalID)
            objLista.Add(Me.NacionalidadPais)
            objLista.Add(Me.IDTipoDocumento)
            objLista.Add(Me.DelitoGenericoID)
            objLista.Add(Me.DelitoEspecificoID)
            'radio buton
            objLista.Add(Me.Estado)
            objLista.Add(Me.NacionalidadExtranjero)
            objLista.Add(Me.SituacionJuridicaID)
            objLista.Add(Me.Sexo)
            'fecha
            Dim FiltroConcatenado As String = ""
            For Each obj As String In objLista
                FiltroConcatenado = FiltroConcatenado & obj
            Next

            Return FiltroConcatenado

        End Function

        Private Sub ListarResumen()

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
                objEntIngreso = obBssIngreso.ListarResumenPLM(objEntIngreso) 'pendiente

                With objEntIngreso
                    Me.IngresoNumero = .IngresoNro
                    Me.IngresoFecha = .FechaMovIngresoString
                    Me.IngresoFecha = Me.IngresoFecha
                    Me.IngresoSituacionJuridica = .SituacionJuridicaNombre
                    Me.TipoEgreso = IIf(.TipoMovimientoNombre = "", "NO REGISTRA", .TipoMovimientoNombre)
                    Me.EgresoFecha = .strFechaLibertadDate
                End With
                Me.InternoID = Me.GrillaInternoID
            End If

        End Sub
        Private Sub ShowFotografia()

            If Me.UscFotografia_2v1._CheckImagen = False Or Me.GrillaInternoID < 1 Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            'If Me.InternoID = Me.GrillaInternoID And Me.UscFotografia_2v1._HasImagen = True And Me.PerfilFotografia = PerfilActual Then
            '    'nada
            'Else
            If tcConsultaInternoMovimientos.SelectedTab.Name = "tpBandeja" Then
                Dim objBssFoto As New Bussines.Registro.InternoFoto
                Dim objEnt As New Entity.Registro.InternoFoto
                Select Case Me.PerfilFotografia
                    Case 1 'izquierdo
                        Me.PerfilActual = 1
                        Me.UscFotografia_2v1._ShowFotoInterno(dgwBandeja.Item("col_pizq_arch_dig_id", dgwBandeja.CurrentCell.RowIndex).Value, True)
                    Case 2 'frente
                        Me.PerfilActual = 2
                        Me.UscFotografia_2v1._ShowFotoInterno(dgwBandeja.Item("col_pfron_arch_dig_id", dgwBandeja.CurrentCell.RowIndex).Value, True)
                    Case 3 'derecho
                        Me.PerfilActual = 3
                        Me.UscFotografia_2v1._ShowFotoInterno(dgwBandeja.Item("col_pder_arch_dig_id", dgwBandeja.CurrentCell.RowIndex).Value, True)
                End Select
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
                                Me.PerfilActual = 1
                                intImagen = .PIzquierdoID
                                intNombreImagen = .PIzquierdoName
                                strRutServer = .PIzquierdoServerPath
                            Case 2 'frente
                                Me.PerfilActual = 2
                                intImagen = .PFrenteID
                                intNombreImagen = .PFrenteName
                                strRutServer = .PFrenteServerPath
                            Case 3 'derecho
                                Me.PerfilActual = 3
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
            'End If
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
            Me.DelitoGenericoID = -1
            Me.DelitoEspecificoID = -1
            Me.IDTipoDocumento = -1
            Me.NumeroDocumento = ""
            Me.dgwGrilla.DataSource = Nothing
            Me.rdbEstadoTodos.Checked = True

            Me.txtApePat.Focus()

        End Sub
        Private Sub ALimpiarMov()

            UscBusquedaMovimiento1._Limpiar()

        End Sub
        Private Sub CargarBandejaPendiente(Optional mostrarAlertarPopup As Boolean = True)
            If Me.PenalID <= 0 Then
                If mostrarAlertarPopup = True Then Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Región y penal.")
                Exit Sub
            End If

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
#End Region
#Region "Form"
        Private Sub FRM_Mantenimiento(ByVal Nuevo As Boolean)

            Dim frm As New Registro.PenalLM.Busqueda.frmMantenimiento
            frm.MdiParent = Me.MdiParent
            With frm
                If Nuevo = True Then
                    ._IDInterno = -1
                    ._IDRegion = Me.InternoRegion
                    .RegionNombre = Me.InternoRegionNombre
                    ._IDPenal = Me.InternoPenal
                    .PenalNombre = Me.InternoPenalNombre
                Else
                    If Me.GrillaInternoID < 1 Then
                        Exit Sub
                    End If
                    ._IDRegion = Me.RegionID
                    ._IDPenal = Me.PenalID
                    ._IDInterno = Me.GrillaInternoID
                End If
                '._FormLectura = Me._FormLectura
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormImpresion = Me._FormReporte
                ._FormEliminar = Me._FormEliminar
                .Show()
            End With

        End Sub

        Private Sub ANuevo()
            Dim blnValue As Boolean = False
            If Me.PenalID = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione región y penal")
                Exit Sub
            End If

            Dim f As New Registro.PenalLM.Busqueda.frmBuscaIntSedeCentralPopup
            f._IDPenal = Me.PenalID
            f._IDRegion = Me.RegionID

            Dim ok As Boolean = False

            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                ok = True
            End If

            If ok = True Then
                Dim frm As New Registro.PenalLM.Busqueda.frmMantenimiento
                frm.MdiParent = Me.MdiParent
                With frm
                    ._IDInterno = f._IDInternoSelecionado
                    ._FormLectura = Me._FormLectura
                    ._IDRegion = Me.cbbRegion.SelectedValue
                    .RegionNombre = Me.cbbRegion.Text ' Me.InternoRegionNombre 
                    ._IDPenal = Me.cbbPenal.SelectedValue
                    .PenalNombre = Me.cbbPenal.Text
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar
                    .Show()
                End With
            End If
        End Sub
        Private Sub FRM_Ver_Reportes()
            Dim frm As New Registro.Reporte.frmReportePopup_LM
            With frm
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoID = Me.GrillaInternoID
                ._TipoReporte = Reporte.frmReportePopup_LM.enmListarReportes.Todos
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                ._InternoApeNom = Me.GrillaApellidos & " " & Me.GrillaNombres
                .ShowDialog()
            End With
        End Sub

        Private Sub RecibirDatosBasicosInterno()
            If (New Bussines.Globall.ArchivoDigital).TestServicioArchivoDigital(True) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se encuentra disponible el servicio " & APPWebService.PathURL.WSPopeSedeCentral & " de la Sede Central, " &
                                                                        "intente luego de unos instantes, si persiste el problema solicite asistencia técnica.")
                Exit Sub
            End If
            If (New Bussines.Globall.ArchivoDigital).TestServicioArchivoDigital(False) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se encuentra disponible el servicio " & APPWebService.PathURL.WSPopeLocal &
                                                                        "intente luego de unos instantes, si persiste el problema solicite asistencia técnica.")
                Exit Sub
            End If

            If MsgBox("Se va a recepcionar y registrar la información del interno seleccionado, desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) <> MsgBoxResult.Yes Then Exit Sub

            Try

                Me.nRegionId_hilo = Me.RegionID
                Me.nPenalId_hilo = Me.PenalID
                Me.nInternoSedeId_hilo = Me.GrillaInternoID

                Me.SuspendLayout()

                Me.bgwDownloadData.RunWorkerAsync()

                frmProcesando = New Load.frmProcesando
                frmProcesando._PermitirCancelar = False
                If frmProcesando.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.bgwDownloadData.CancelAsync()
                    Me.bgwDownloadData.Dispose()
                End If
                Me.ResumeLayout(True)
                frmProcesando.Refresh()

                If Me.n_interno_id = -1 Then
                    If outDownSMS.Length > 2 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(outDownSMS)
                    End If
                    outDownSMS = ""
                    Exit Sub
                End If

                btnRefresBandeja.PerformClick()
                Legolas.Configuration.Aplication.MessageBox.Information("La operación se ha completado satisfactoriamente, ahora se procede a mostrar la información del interno.")

                'se registra en la tabla interno penal
                Dim objBssInternoPenal As New Bussines.Registro.InternoPenal
                objBssInternoPenal.Grabar(Me.nInternoSedeId_hilo, Me.n_interno_id, Me.nRegionId_hilo, Me.nPenalId_hilo, 1) 'alta
                '*****************/

                Dim frm As New Registro.PenalLM.Busqueda.frmMantenimiento

                frm.MdiParent = Me.MdiParent
                With frm
                    ._IDInterno = Me.n_interno_id
                    ._IDPenal = Me.PenalID
                    'permsisos
                    ._FormLectura = Me._FormLectura
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar
                    .Show()
                End With

            Catch ex As Exception
                Dim s As String
                s = s
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Error, " & ex.Message)
            End Try
        End Sub
        Private Sub FRM_VerificarHuella()

            If Me.PenalID = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar un penal.")
                Exit Sub
            End If

            Dim f As New Registro.Busqueda.frmBusquedaPorHuella
            f.MdiParent = Me.MdiParent
            f._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
            f._RegionId = Me.RegionID
            f._PenalId = Me.PenalID
            f._NombrePenal = "E.P. " & cbbPenal.Text
            f.Show()

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
            ComboTipoDocumento()
            ComboDelitoGenerico()
            ComboDelitoEspecifico()
            dgwGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dgwGrilla.VisibleCampos = True

            UscBusquedaMovimiento1._LoadUsc()
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
        Private Sub VisibleResumen(value As Boolean)

            Me.lblResUltIngreso.Visible = value
            Me.lblResFecIngreso.Visible = value
            Me.lblResSitJur.Visible = value
            Me.lblResTipoEgreso.Visible = value
            Me.lblResFecEgreso.Visible = value

            Me.txtIngresoNum.Visible = value
            Me.txtIngresoFecha.Visible = value
            Me.txtSituacionJur.Visible = value
            Me.txtTipoEgreso.Visible = value
            Me.txtFechaEgreso.Visible = value

        End Sub
#End Region
#Region "Usuario/Permisos"
        Private Sub UsuarioPermisos(ByRef blnCerrarForm As Boolean)

            Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                Case 1 'sede central
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Modulo [Penal Limametropolitana] no esta disponible para la Sede Central")
                    blnCerrarForm = True
                    Me.Close()
                    Exit Sub
                Case Else 'penal o provincias

                    Dim intTipoLocal As Short = -1
                    Dim objBssInst As New Bussines.Sistema.Instalacion
                    intTipoLocal = objBssInst.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

                    Select Case intTipoLocal
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                            'solo se abre en los penales de lima metropolitana 

                        Case Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Modulo [Penal Limametropolitana] no está disponible para el Penal Actual")
                            blnCerrarForm = True
                            Me.Close()
                            Exit Sub
                    End Select

            End Select

            Me.pnlBotonGrabar.Visible = Me._FormEscritura
            Me.pnlBotonReporte.Visible = Me._FormReporte

            Select Case Legolas.Configuration.Usuario.OficinaID

                Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion

                Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario

                Case Else
                    Me.btnVerifHuella.Visible = False
            End Select

        End Sub
#End Region


        Private Sub frmBuscar_Load2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()

        End Sub

        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Select Case tcConsultaInternoMovimientos.SelectedTab.Name
                Case "tpConsultaInterno"
                    Buscar()
                Case "tpConsultaMovimiento"
                    BuscarMovimientos()
                Case "tpBandeja"
                    btnRefresBandeja.PerformClick()
            End Select

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            Me.Cursor = Cursors.WaitCursor

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                FRM_Mantenimiento(False)
            End If

            Me.Cursor = Cursors.Default

        End Sub
        Private Sub txtApePat_Click(sender As Object, e As System.EventArgs) Handles txtApePat.Click

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

        Private Sub dgwGrilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            'shit delete
            Select Case e.KeyData

                Case (Keys.Shift Or Keys.R) 'shift + r==> PERMITE REVINCULAR 
                    Select Case Legolas.Configuration.Usuario.OficinaID
                        Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion 'osin dev
                            Dim frm As New Registro.PenalLM.Busqueda.frmVinculacionPLMPopup
                            With frm
                                ._IDInternoLocal = Me.GrillaInternoID
                                ._IDPenal = Me.GrillaPenalID
                                If .ShowDialog() = DialogResult.OK Then
                                    Buscar()
                                End If
                            End With
                    End Select
                    Exit Sub

                Case (Keys.Shift Or Keys.I) 'shift + i==> PERMITE actualizar el ingreso 
                    Select Case Legolas.Configuration.Usuario.OficinaID
                        Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion 'osin dev
                            Dim frm As New Registro.PenalLM.Busqueda.frmUpdateIngresoInpePopup
                            With frm
                                ._IDInternoLocal = Me.GrillaInternoID
                                ._IDPenal = Me.GrillaPenalID
                                If .ShowDialog() = DialogResult.OK Then
                                    Buscar()
                                End If
                            End With
                    End Select
                    Exit Sub

                Case (Keys.Shift Or Keys.D) 'shift + D==> PERMITE BORRAR 

                    'solo para osin-dev
                    Select Case Legolas.Configuration.Usuario.OficinaID
                        Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion 'osin dev

                            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar <> DialogResult.Yes Then
                                Exit Sub
                            End If

                            Dim strMensajeOut As String = ""

                            'regularizar las tablas de visitas
                            Dim strSqlMasivo As New System.Text.StringBuilder
                            With strSqlMasivo
                                .AppendLine("update int_interno set _flg_trf =1,_flg_eli=1, _usu_eli=" & Legolas.Configuration.Usuario.Codigo & ", _fec_eli = " & Now.ToFileTime & " where int_id=" & Me.GrillaInternoID)
                                .AppendLine("update reg_mov_internopenal set _flg_trf =1,_flg_eli=1,_usu_eli=" & Legolas.Configuration.Usuario.Codigo & ", _fec_eli = " & Now.ToFileTime & " where fk_int_id_pen=" & GrillaInternoID)
                            End With

                            Dim intResul As Integer = -1
                            intResul = Bussines.Registro.Interno.UpdateQuery(strSqlMasivo.ToString, strMensajeOut)

                            If strMensajeOut.Trim.Length > 3 Then
                                Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensajeOut)
                            Else
                                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                            End If

                            Buscar()

                    End Select
                    Exit Sub
            End Select

            'eliminar
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
            UscBusquedaMovimiento1._Limpiar()
            dgwBandeja.DataSource = Nothing
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
            ANuevo()
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            FormatoGrillaColumnas()

            Select Case tcConsultaInternoMovimientos.SelectedTab.Name
                Case "tpConsultaInterno"
                    Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
                Case "tpConsultaMovimiento"
                    UscBusquedaMovimiento1._Exportar()
                Case "tpBandeja"
                    ban_fec_nac.Visible = False
                    Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwBandeja)
                    ban_fec_nac.Visible = True
            End Select
        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
            If tcConsultaInternoMovimientos.SelectedTab.Name = "tpConsultaInterno" Then
                If Me.dgwGrilla.RowCount < 1 Then
                    Exit Sub
                End If
            ElseIf tcConsultaInternoMovimientos.SelectedTab.Name = "tpConsultaMovimiento" Then
                If UscBusquedaMovimiento1._GrillaCount < 1 Then
                    Exit Sub
                End If
            End If
            FRM_Mantenimiento(False)
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
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario canceló el proceso de búsqueda")
                Me.BackgroundWorker1 = Nothing
                Me.Close()
            End If

        End Sub

        Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
            e.Result = Listar()
        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                Me.Timer1.Stop()
                frmLoad.Close()
                result = e.Result
            End If
        End Sub

        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.Cursor = Cursors.WaitCursor

            Me.WindowState = FormWindowState.Maximized
            Dim blnCerrar As Boolean = False
            UsuarioPermisos(blnCerrar)

            If blnCerrar = False Then
                Me.Refresh()
                Me.pnlBandeja.Visible = True
                Me.pnlBotonGrabar.Visible = False
                Me.pnlBotonReporte.Visible = False
                VisibleResumen(False)
                'CargarBandejaPendiente(False)'se comenta para no saturar la busqueda 
                blnCargoForm = True
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
            ListarResumen()
        End Sub

        Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click
            Select Case tcConsultaInternoMovimientos.SelectedTab.Name
                Case "tpBandeja"
                    dgwBandeja.DataSource = Nothing
                Case "tpConsultaInterno"
                    ALimpiar()
                Case "tpConsultaMovimiento"
                    ALimpiarMov()
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
            cbbPenal._SelectedIndexChanged,
            cbbDelitoGenerico._SelectedIndexChanged,
            cbbDelitoEspecifico._SelectedIndexChanged,
            cbbTipoDoc._SelectedIndexChanged

            ValidarFiltro()
            If cbbTipoDoc.SelectedValue = Type.Enumeracion.enmTipoDocumento.DNI Then
                txtNumDoc.MaxLength = 8
                txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            Else
                txtNumDoc.MaxLength = 20
                txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            End If

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

        Private Sub UscBusquedaMovimiento1__Grilla_CellDoubleClick() Handles UscBusquedaMovimiento1._Grilla_CellDoubleClick

            FRM_Mantenimiento(False)

        End Sub

        Private Sub UscBusquedaMovimiento1__Grilla_CellEnter() Handles UscBusquedaMovimiento1._Grilla_CellEnter
            If UscBusquedaMovimiento1._GrillaCount > 0 Then
                ShowFotografia()
                ListarResumen()
            End If
        End Sub

        Private Sub UscBusquedaMovimiento1__Click_Numreg() Handles UscBusquedaMovimiento1._Grilla_ValidarFiltro
            Me.lblSegundo.Text = "00:00:00"
            Me.NumeroReg = 0
        End Sub

        Private Sub dgwBandeja_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwBandeja.CellEnter
            ShowFotografia()
        End Sub

        Private Sub btnRefresBandeja_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresBandeja.Click
            CargarBandejaPendiente(True)
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            Me.ComboPenal()
            ValidarFiltro()
        End Sub

        Private Sub btnDescargar_Click(sender As System.Object, e As System.EventArgs) Handles btnDescargar.Click

            If dgwBandeja.Rows.Count = 0 Then Exit Sub

            RecibirDatosBasicosInterno()
        End Sub

        Private Sub tcConsultaInternoMovimientos_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tcConsultaInternoMovimientos.SelectedIndexChanged

            Select Case Me.tcConsultaInternoMovimientos.SelectedTab.Name
                Case Me.tpBandeja.Name
                    btnFicha.Enabled = False
                    Me.pnlBandeja.Visible = True
                    Me.pnlBotonGrabar.Visible = False
                    Me.pnlBotonReporte.Visible = True
                    VisibleResumen(False)

                    Me.Refresh()

                    Me.Cursor = Cursors.WaitCursor
                    CargarBandejaPendiente(False)
                    Me.Cursor = Cursors.Default

                Case Me.tpConsultaInterno.Name
                    btnFicha.Enabled = True
                    Me.pnlBandeja.Visible = False
                    VisibleResumen(True)
                    Me.pnlBotonGrabar.Visible = Me._FormEscritura
                    Me.pnlBotonReporte.Visible = Me._FormReporte

                    txtApePat.Focus()
                Case Me.tpConsultaMovimiento.Name
                    btnFicha.Enabled = True
                    Me.pnlBandeja.Visible = False
                    VisibleResumen(True)
                    Me.pnlBotonGrabar.Visible = Me._FormEscritura
                    Me.pnlBotonReporte.Visible = Me._FormReporte

                    UscBusquedaMovimiento1._Focus()
            End Select

            ShowFotografia()

        End Sub

        Private Sub btnVerifHuella_Click(sender As System.Object, e As System.EventArgs) Handles btnVerifHuella.Click
            FRM_VerificarHuella()
        End Sub

        Private Sub tmrDownloadData_Tick(sender As Object, e As EventArgs)

            If Me.BackgroundWorker1.IsBusy Then Exit Sub
            ' inicializa la validacion del ping
            Me.BackgroundWorker1.RunWorkerAsync()
        End Sub

        Private Sub bgwDownloadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwDownloadData.DoWork

            Dim movSedeId As Integer = -1
            Dim movRegOriId As Integer = -1
            Dim movPenOriId As Integer = -1

            Dim bss As New Bussines.Transferencia.RecepcionInternoTraslado(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno, Me.nRegionId_hilo, Me.nPenalId_hilo)

            movSedeId = dgwBandeja.SelectedRows(0).Cells("bnd_col_mov_id").Value
            movRegOriId = dgwBandeja.SelectedRows(0).Cells("col_reg_ori_id").Value
            movPenOriId = dgwBandeja.SelectedRows(0).Cells("col_pen_ori_id").Value

            n_interno_id = bss.RecepcionTrasladoIntCarceleta(Me.nInternoSedeId_hilo, movSedeId, movRegOriId, movPenOriId, Me.nPenalId_hilo, Me.nRegionId_hilo, outDownSMS)

        End Sub

        Private Sub bgwDownloadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwDownloadData.RunWorkerCompleted
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmProcesando.Close()
            End If
        End Sub

        Private Sub bgwDownloadData_Disposed(sender As Object, e As EventArgs) Handles bgwDownloadData.Disposed
            Me.bgwDownloadData = Nothing
            Me.Close()
        End Sub

        Private Sub frmBuscar_Activated(sender As Object, e As EventArgs) Handles Me.Activated

            If blnCargoForm = True Then
                tsbBuscar_Click(sender, e)
            End If

        End Sub

        Private Sub btnListarDescarga_Click(sender As Object, e As EventArgs) Handles btnListarDescarga.Click
            Dim frm As New Registro.frmListaDocumentosDescargados
            frm._PenalID = Me.PenalID
            frm._FormEscritura = Me._FormEscritura
            frm._MdiParenAux = Me.MdiParent
            frm.PerfilUsuarioId = Legolas.Configuration.Usuario.NivelUsuario
            frm.Show()
        End Sub
    End Class
End Namespace
