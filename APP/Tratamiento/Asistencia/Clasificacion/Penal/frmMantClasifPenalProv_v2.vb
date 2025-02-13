Option Explicit On
'version del form3
Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.SubTipoDocJudicial
Imports Type
Imports APPControls.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class frmMantClasifPenalProv_v2
        Public _frmLectura As Boolean = False
        Public _frmEscritura As Boolean = False
        Public _frmReporte As Boolean = False
        Public _frmImpresion As Boolean = False
        Public _frmEliminar As Boolean = False

        Private objBssInterno As Bussines.Registro.Interno = Nothing
        Private objBssIngreso As Bussines.Registro.Ingreso = Nothing
        Private objBssHistorico As Bussines.Registro.InternoHistorico

        Private objEntColAlias As Entity.Registro.InternoAliasCol = Nothing
        Private objEntColFam As Entity.Registro.FamiliarCol = Nothing
        Private objBssInternoRnc As Bussines.Registro.InternoReniec = Nothing
        Private blnModificarDatos As Boolean = False

        'permisos registro
        Private blnLecturaRegistro As Boolean = False
        Private blnEscrituraRegistro As Boolean = False
        Private blnEliminarRegistro As Boolean = False
        Private blnReporteRegistro As Boolean = False

#Region "Propiedades_Interno"
        Private intTipoInterno As Integer = -1
        Private intInternoEstado As Integer = -1
        Dim UscGrillaNombresAsociados1 As Object ''''



        Private Property idInterno() As Integer = -1
        Public Property IDInternoHistorico As Integer = -1
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
                strValue = txtInterno.Text
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
        Private Property Sexo() As Integer
            Get
                Try
                    Return Me.cbbSexo.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbSexo.SelectedValue = value
            End Set
        End Property
        Private Property InternoFechaNac() As Long
            Get
                Return Me.dtpFechaNac.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaNac.ValueLong = value
            End Set
        End Property

        Private Property TipoDocumento() As Integer
            Get
                Try
                    If chkNoindica.CheckState = CheckState.Checked Then
                        Return -1
                    Else
                        Return Me.cbbTipoDoc.SelectedValue
                    End If
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

        Private Property EstadoCivil() As Integer
            Get
                Try
                    Return Me.cbbEstadoCivil.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbEstadoCivil.SelectedValue = value
            End Set
        End Property

        'Private Property InternoNHijos() As Integer
        '    Get
        '        Dim intValue As Integer = 0

        '        If IsNumeric(Me.txtNumHijos.Text) = True Then
        '            intValue = Integer.Parse(Me.txtNumHijos.Text)
        '        End If
        '        Return intValue
        '    End Get
        '    Set(ByVal value As Integer)
        '        Me.txtNumHijos.Text = value.ToString
        '    End Set
        'End Property
        'Private Property InternoNHijosMen18() As Integer
        '    Get
        '        Dim intValue As Integer = 0

        '        If IsNumeric(Me.txtNHijos.Text) = True Then
        '            intValue = Integer.Parse(Me.txtNHijos.Text)
        '        End If
        '        Return intValue
        '    End Get
        '    Set(ByVal value As Integer)
        '        Me.txtNHijos.Text = value.ToString
        '    End Set
        'End Property
        Private Property InternoEstado() As Integer
            Get
                Return intInternoEstado
            End Get
            Set(ByVal value As Integer)
                intInternoEstado = value
            End Set
        End Property


        Private NumeroDocumentoAux As String = ""
        Private InternoApePaternoAux As String = ""
        Private InternoApeMaternoAux As String = ""
        Private InternoNombresAux As String = ""

        Private NuevoClickfrmIngreso As Boolean = False
#End Region
#Region "Propiedades_Ubigeo"
        Private intUbigeoNacimiento As Integer = -1
        Private Property Nacionalidad() As Integer
            Get
                Try
                    Return Me.cbbNacionalidad.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property
        Private Property Pais() As Integer
            Get
                Try
                    Return Me.cbbPais.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbPais.SelectedValue = value
            End Set
        End Property
        Private Property Departamento() As Integer
            Get
                Try
                    Return Me.CbbDepartamento.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.CbbDepartamento.SelectedValue = value
            End Set
        End Property
        Private Property Provincia() As Integer
            Get
                Try
                    Return Me.cbbProvincia.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbProvincia.SelectedValue = value
            End Set
        End Property
        Private Property Distrito() As Integer
            Get
                Try
                    Return Me.cbbDistrito.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbDistrito.SelectedValue = value
            End Set
        End Property
        Private Property UbigeoNacimiento() As Integer
            Get
                Try
                    Return Me.cbbDistrito.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)

                Dim intValue As Integer = -1
                intValue = value

                If intValue > 0 Then
                    ListarUbigeoNacimiento(intValue)
                End If

            End Set
        End Property
        Private Property UbigeoNacimientoOtros() As String
            Get
                Return Me.txtUbigeoOtro.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtUbigeoOtro.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Domicilio"
        Private intUbigeoDomicilio As Integer = -1


#End Region


#Region "Propiedades_Grilla"

        Private ReadOnly Property GrillaFamiliaCodigo() As Integer
            Get

                Return -1
            End Get
        End Property
        Private ReadOnly Property GrillaFamiliaIngresoID() As Integer
            Get

                Return -1
            End Get
        End Property

#End Region
#Region "Propiedades_RegionPenal"
        Private Property idRegion() As Short = -1
        Private Property regionNombre() As String = ""
        Private ReadOnly Property RegionPenalNombre() As String
            Get
                Return Me.regionNombre & "-" & Me.penalNombre
            End Get
        End Property
        Private Property idPenal() As Short = -1
        Private Property penalNombre() As String = ""
#End Region
#Region "Propiedades_Otros"
        Private Property Noindica() As Boolean
            Get
                Return Me.chkNoindica.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkNoindica.Checked = value
            End Set
        End Property

        Public ReadOnly Property _IDIngreso() As Integer
            Get
                Try
                    Return Me.cbbNroIngresos.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Private ReadOnly Property IDLicencia As Integer
            Get
                Return Legolas.LBusiness.Globall.WinApp.LicenciaApp
            End Get
        End Property
#End Region
#Region "Propiedades_Cabecera"
        Private Property CabeceraEstado() As String
            Get
                Return Me.txtEstado.Text.Trim

            End Get
            Set(ByVal value As String)
                Select Case value
                    Case "INACTIVO"
                        txtEstado.BackColor = Color.LightCoral
                    Case Else
                        txtEstado.BackColor = Control.DefaultBackColor()
                End Select
                Me.txtEstado.Text = value

            End Set
        End Property
#End Region

        Public Sub New(idInterno As Integer, idRegion As Short, idPenal As Short, regionNombre As String, penalNombre As String)

            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

            Me.idInterno = idInterno
            Me.idRegion = idRegion
            Me.regionNombre = regionNombre
            Me.idPenal = idPenal
            Me.penalNombre = penalNombre

        End Sub
#Region "Combo"
        Private blnComboDep As Boolean = False
        Private blnComboProv As Boolean = False
        Private blnComboDomDep As Boolean = False
        Private blnComboDomProv As Boolean = False
        Private blnPais As Boolean = False
        Private blnComboComAnd As Boolean = False
        Private blnComboFzaArm As Boolean = False
        Private conta As Integer = 0
        Private Sub Combo()
            Me.cbbSexo.LoadUsc()
            Me.cbbTipoDoc.LoadUsc()
            Me.cbbEstadoCivil.LoadUsc()
            Me.cbbNacionalidad.LoadUsc()
            blnComboComAnd = True
        End Sub
        Public ValorIngreso As Boolean = False
        Dim objBssIng As New Bussines.Registro.Ingreso

        Public Sub ComboNumIngreso()
            If Me.idInterno < 1 Then Exit Sub

            objBssIng = New Bussines.Registro.Ingreso
            Dim objEnt As New Entity.Registro.Ingreso
            Dim objEntCol2 As New Entity.Registro.IngresoCol
            With objEnt
                .InternoID = Me.idInterno
                .PenalID = Me.idPenal
            End With

            objEntCol2 = objBssIng.ListarNroIngreso(Me.idInterno, Me.idPenal)

            With Me.cbbNroIngresos
                .DataSource = objEntCol2
                .DisplayMember = "IngresoNroLetra"
                .ValueMember = "Codigo"
            End With

        End Sub

        Private Sub ComboPais()
            blnPais = False

            With Me.cbbPais
                .DataSource = (New Bussines.General.Parametrica).Listar(Type.Combo.ComboTipo.Pais)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnPais = True
        End Sub
        Private Sub ComboDepartamento()

            blnComboDep = False

            With Me.CbbDepartamento
                .DataSource = (New Bussines.General.Parametrica).Listar(Type.Combo.ComboTipo.Departamento, Me.Pais)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnComboDep = True

        End Sub
        Private Sub ComboProvincia()
            blnComboProv = False

            With Me.cbbProvincia
                .DataSource = (New Bussines.General.Parametrica).Listar(Type.Combo.ComboTipo.Provincia, Me.Departamento)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnComboProv = True
        End Sub
        Private Sub ComboDistrito()

            With Me.cbbDistrito
                .DataSource = (New Bussines.General.Parametrica).Listar(Type.Combo.ComboTipo.Distrito, Me.Provincia)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With

        End Sub


#End Region
#Region "Validar"

        Private CodigoInternoRnc As Integer = -1


#End Region
#Region "Listar"
        Dim objEntInt As Entity.Registro.Interno
        Private Sub ListarCabecera()

            objEntInt = New Entity.Registro.Interno

            Me.txtCodigo.Text = Me.CodigoRPInterno

            objEntInt = (New Bussines.Registro.Interno).Listar_v6(Me.idInterno)

            Me.InternoApePaternoAux = objEntInt.ApellidoPaterno
            Me.InternoApeMaternoAux = objEntInt.ApellidoMaterno
            Me.InternoNombresAux = objEntInt.Nombres
            Me.txtInterno.Text = Me.InternoApeyNomHis(objEntInt.ApellidoPaterno, objEntInt.ApellidoMaterno, objEntInt.Nombres)
            Me.CabeceraEstado = Bussines.Registro.Interno.EstadoNombre(Me.idInterno)
            Me.txtRegionPenal.Text = Me.RegionPenalNombre
            Me.InternoEstado = objEntInt.EstadoID
        End Sub


        Private Sub ListarDataInterno(objEnt As Entity.Registro.Interno)

            If Me.idInterno < 1 Then Exit Sub

            With objEnt
                '/*datos generales*/
                Me.CodigoRPInterno = .CodigoRP
                Me.InternoApePaterno = .ApellidoPaterno
                Me.InternoApeMaterno = .ApellidoMaterno
                Me.InternoNombres = .Nombres
                Me.Sexo = .SexoID
                Me.InternoFechaNac = .FechaNacimiento
                Me.TipoDocumento = .TipoDocumentoID
                If Me.TipoDocumento <= 0 Then
                    Me.Noindica = True
                    Me.cbbTipoDoc.Enabled = False
                    Me.txtNumDoc.Enabled = False
                End If
                Me.NumeroDocumento = .NumeroDocumento
                Me.NumeroDocumentoAux = .NumeroDocumento
                Me.EstadoCivil = .EstadoCivilID
                Me.Nacionalidad = .NacionalidadID

                '/*ubigeo nacimiento*/
                Me.Pais = .NacimientoPaisID
                Me.UbigeoNacimiento = .NacimientoUbigeoID
                Me.UbigeoNacimientoOtros = .NacimientoOtros
                '/*ubigeo domicilio*/

                '/*region y penal*/
                Me.idRegion = .RegionID
                Me.regionNombre = .RegionNombre
                Me.idPenal = .PenalID
                Me.penalNombre = .PenalNombre
                Me.InternoApePaternoAux = Me.InternoApePaterno
                Me.InternoApeMaternoAux = Me.InternoApeMaterno
                Me.InternoNombresAux = Me.InternoNombres
                Me.InternoEstado = .EstadoID

            End With

        End Sub
        Private Sub ListarInternoHistorico(objEnt As Entity.Registro.InternoHistorico)

            If Me.idInterno < 1 Or Me._IDIngreso < 1 Then Exit Sub

            With objEnt
                '/*datos generales*/
                Me.IDInternoHistorico = .Codigo
                Me.CodigoRPInterno = .CodigoRP
                Me.InternoApePaterno = .ApellidoPaterno
                Me.InternoApeMaterno = .ApellidoMaterno
                Me.InternoNombres = .Nombres
                Me.Sexo = .SexoID
                Me.InternoFechaNac = .FechaNacimiento
                Me.TipoDocumento = .TipoDocumentoID
                If .TipoDocumentoID < 1 Then
                    Me.Noindica = True
                    Me.cbbTipoDoc.Enabled = False
                    Me.txtNumDoc.Enabled = False
                End If
                Me.NumeroDocumento = .NumeroDocumento
                Me.NumeroDocumentoAux = .NumeroDocumento
                Me.EstadoCivil = .EstadoCivilID
                Me.Nacionalidad = .NacionalidadID
                '/*ubigeo nacimiento*/
                Me.Pais = .NacimientoPaisID
                Me.UbigeoNacimiento = .NacimientoUbigeoID
                Me.UbigeoNacimientoOtros = .NacimientoOtros
                '/*ubigeo domicilio*/

                '/*region y penal*/
                Me.idRegion = .RegionID
                Me.regionNombre = .RegionNombre
                Me.idPenal = .PenalID
                Me.penalNombre = .PenalNombre
                Me.InternoApePaternoAux = .ApellidoPaterno
                Me.InternoApeMaternoAux = .ApellidoMaterno
                Me.InternoNombresAux = .Nombres
                Me.UscAuditUser1.LoadAudit(Me.idInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)

            End With

        End Sub
        Private Sub ListarData()

            If Me.idInterno < 1 Then
                Me.txtRegionPenal.Text = Me.RegionPenalNombre
                Exit Sub
            End If

            objBssHistorico = New Bussines.Registro.InternoHistorico

            Dim objEntIng As New Entity.Registro.Ingreso
            Dim objEnInternoHisto As New Entity.Registro.InternoHistorico
            Dim objEnInternoFiltroHisto As New Entity.Registro.InternoHistorico
            objBssInterno = New Bussines.Registro.Interno
            If Me._IDIngreso > 0 Then

                objEnInternoFiltroHisto.InternoID = Me.idInterno
                objEnInternoFiltroHisto.IngresoID = Me._IDIngreso

                objEnInternoHisto = objBssHistorico.Listar(objEnInternoFiltroHisto)

                If objEnInternoHisto Is Nothing Then
                    Dim objEntInterno As New Entity.Registro.Interno
                    'Dim objEntInternoFiltro As New Entity.Registro.Interno

                    'objEntInternoFiltro.Codigo = Me.InternoID
                    objEntInterno = objBssInterno.Listar_v6(Me.idInterno)
                    ListarDataInterno(objEntInterno)
                    Me.UscAuditUser1.LoadAudit(Me.idInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                Else
                    If objEnInternoHisto.InternoID < 1 Then
                        'no existe el registro historico del interno, hay que crearlo de la tabla int_interno
                        objEnInternoHisto = objBssHistorico.Listar_Data_Interno(Me.idInterno, Me._IDIngreso)
                        If objEnInternoHisto.InternoID > 0 Then
                            If ValidarSedeLicencia(objEnInternoHisto.PenalID) = -1 Then
                                objEnInternoHisto.Codigo = -1
                                objEnInternoHisto.IngresoID = Me._IDIngreso
                                objBssHistorico.Grabar(objEnInternoHisto)
                            End If
                            ListarInternoHistorico(objEnInternoHisto)
                        End If
                    Else
                        If objEnInternoHisto.Codigo < 1 Then
                            Dim objEntInterno As Entity.Registro.Interno = objBssInterno.Listar_v5(Me.idInterno)
                            ListarDataInterno(objEntInterno)
                        Else
                            ListarInternoHistorico(objEnInternoHisto)
                        End If
                    End If
                    Me.UscAuditUser1.LoadAudit(objEnInternoHisto.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoHistorico)
                End If
            Else
                'listar los datos del interno 
                Dim objEntInterno As Entity.Registro.Interno = objBssInterno.Listar_v5(Me.idInterno)

                If objEntInterno.Codigo > 0 Then
                    ListarDataInterno(objEntInterno)
                    Me.UscAuditUser1.LoadAudit(Me.idInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError(
                    "No se ha encontrado al Interno o posiblemente haya sido eliminado. Actualice la busqueda.")
                    Me.Close()
                End If
            End If

            ListarCabecera()
            EnabledControles(True)

            'ListarUbigeoGeoreferencia()
        End Sub

        Private Sub LoadUscFotografia()

            If Me.idInterno < 1 Then Exit Sub

            With uscFotoPerfiles
                ._InternoID = Me.idInterno
                ._InternoCodigoRP = Me.CodigoRPInterno
                .RegionID = Me.idRegion
                .PenalID = Me.idPenal
                .InternoFotoID = -1
                .InternoIngresoId = Me._IDIngreso
                .MostrarGrillaRasgo(False)
                .MostrarGrillaSeniaParticular(False)
                .LoadUsc()
                uscFotoPerfiles.DataGrieView_Click()
            End With

        End Sub


        Private Sub LoadUscBandas()

            If Me.idInterno < 1 Then Exit Sub

            With UscGrillaBandasV21
                ._InternoID = Me.idInterno
                ._InternoIngresoID = Me._IDIngreso
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._LoadUsc()
            End With
        End Sub


        Public Sub ListarResoluciones()
            If Me._IDIngreso < 1 Or Me.idInterno < 1 Then Exit Sub
            With Me.UscResolucionesMain1
                ._Codigo = -1
                ._InternoID = Me.idInterno
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._NroIngresoID = Me._IDIngreso
                .LoadUsc()
            End With

        End Sub

        Private Sub ListarMovimientosIngreso()
            If Me._IDIngreso < 1 Or Me.idInterno < 1 Then Exit Sub
        End Sub

#Region "Ubigeo"
        Private Sub ListarUbigeoNacimiento(ByVal Codigo As Integer)

            Dim objBss As New Bussines.General.Ubigeo
            Dim objEnt As New Entity.General.Ubigeo
            Dim objEntCol As New Entity.General.UbigeoCol
            objEntCol = objBss.Listar("lst_mant", Codigo, -1, -1, -1, -1, "")

            If objEntCol Is Nothing Then Exit Sub

            If objEntCol.Count > 0 Then
                objEnt = objEntCol.Ubigeo(0)
                With objEnt
                    'Me.Codigo = .Codigo
                    'Me.Pais = .Pais
                    Me.Departamento = .Departamento
                    Me.Provincia = .Provincia
                    Me.Distrito = .Distrito
                End With
            End If

        End Sub

#End Region
#End Region
#Region "Listar_UserControl_Clasificacion"

        Private Sub ListarClasificacionRegimen()

            If Me.idInterno < 1 Then Exit Sub

            With Me.UscFichaClasificacion1
                ._IDInterno = Me.idInterno
                ._InternoApeNom = Me.InternoApeyNom
                ._IDIngreso = Me._IDIngreso
                ._IDRegion = Me.idRegion
                ._IDPenal = Me.idPenal
                'permisos
                ._uscPerfilUsuario = Legolas.Configuration.Usuario.OficinaID
                ._uscFichaTab = APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionRegimen.EnmFichaTab.enmRegimen
                ._ListarUsc()
            End With

        End Sub

        Private Sub ListarClasificacionRegresion()

            If Me.idInterno < 1 Then Exit Sub

            With Me.UscFichaPorRegresion1
                ._IDInterno = Me.idInterno
                ._InternoApeNom = Me.InternoApeyNom
                ._IDIngreso = Me._IDIngreso
                ._IDRegion = Me.idRegion
                ._IDPenal = Me.idPenal

                'permisos
                ._uscPerfilUsuario = Legolas.Configuration.Usuario.OficinaID
                ._ListarUsc()

            End With

        End Sub
        Private Sub ListarClasificacionTraslado()

            If Me.idInterno < 1 Then Exit Sub

            With Me.UscFichaClasifTraslado1
                ._IDInterno = Me.idInterno
                ._InternoApeNom = Me.InternoApeyNom
                ._IDIngreso = Me._IDIngreso
                ._IDRegion = Me.idRegion
                ._IDPenal = Me.idPenal

                'permisos
                ._uscPerfilUsuario = Legolas.Configuration.Usuario.OficinaID
                ._ListarUsc()
            End With

        End Sub

        Private Sub ListarClasificacionEtapa()

            If Me.idInterno < 1 Then Exit Sub

            With Me.uscFicClasifEtapaProv
                ._IDInterno = Me.idInterno
                ._InternoApeNom = Me.InternoApeyNom
                ._IDIngreso = Me._IDIngreso
                ._IDRegion = Me.idRegion
                ._IDPenal = Me.idPenal
                'permisos
                ._uscPerfilUsuario = Legolas.Configuration.Usuario.OficinaID
                ._uscFichaTab = APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionRegimen.EnmFichaTab.enmEtapa
                ._ListarUsc()
            End With

        End Sub

#End Region
#Region "Accion"


        Private Sub EnabledControles(Valor As Boolean)
            Select Case Me.tbcDatosInternos.SelectedTab.Name
                Case Me.tbpDatos.Name
                    Me.txtApePat.ReadOnly = Valor
                    Me.txtApeMat.ReadOnly = Valor
                    Me.txtNom.ReadOnly = Valor
                    Me.cbbSexo.Enabled = Not (Valor)
                    Me.dtpFechaNac.Enabled = Not (Valor)
                    Me.chk_Obs_DNI.Enabled = Not (Valor)
                    Me.chkNoindica.Enabled = Not (Valor)
                    If Me.chkNoindica.Enabled = True Then
                        If Me.chkNoindica.Checked = True Then
                            Me.cbbTipoDoc.Enabled = False
                            Me.txtNumDoc.ReadOnly = True
                        Else
                            Me.cbbTipoDoc.Enabled = True
                            Me.txtNumDoc.ReadOnly = False
                        End If
                    Else
                        Me.chkNoindica.Enabled = False
                        If Me.cbbTipoDoc.SelectedValue < 1 Then
                            Me.chkNoindica.Checked = True
                        Else
                            Me.chkNoindica.Checked = False
                        End If
                        Me.cbbTipoDoc.Enabled = False
                        Me.txtNumDoc.ReadOnly = True
                    End If

                    Me.cbbEstadoCivil.Enabled = Not (Valor)
                    Me.cbbNacionalidad.Enabled = Not (Valor)
                    Me.cbbPais.Enabled = Not (Valor)
                    Me.CbbDepartamento.Enabled = Not (Valor)
                    Me.cbbProvincia.Enabled = Not (Valor)
                    Me.cbbDistrito.Enabled = Not (Valor)

            End Select

            If Valor = False Then
                blnCheck = True
                blnModificarDatos = True
            Else

                blnCheck = False
                blnModificarDatos = False
            End If

        End Sub

#End Region
#Region "Formulario"
#Region "Datos del Interno"

        Private Sub frmConstanciaResluMant(nuevo As Boolean, idTramite As Integer)

            Dim codigo As Integer = -1
            Dim abrirForm As Boolean = False

            If nuevo = False Then codigo = idTramite

            Dim frm As New Registro.ConstanciaReclusion.frmTramite(codigo, Me.idInterno, Me.idRegion, Me.idPenal,
                Me.CodigoRPInterno, Me.InternoApeyNom, Me.regionNombre, Me.penalNombre, abrirForm,
                Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia)

            If abrirForm = True Then
                With frm
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    .ShowDialog()
                End With
            End If

        End Sub


        Private Sub FRM_ListaIngreso()

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me.cbbNroIngresos.Text = "[Por regularizar]" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un ingreso, regularizar el Nº de ingreso [0].")
                Exit Sub
            End If


            Dim frm As New Registro.Identificacion.v5.frmIngresoPopup3
            With frm
                .InternoID = Me.idInterno
                .RegionID = Me.idRegion
                .PenalID = Me.idPenal
                ._NuevoClick = Me.NuevoClickfrmIngreso
                ._ValidarIngreso = Me.ValorIngreso
                ._ValidarIngreso0 = Me.ValorIngreso
                ._LoadUsc()

                Dim ContadorIngresos As Integer = frm.GrillaDgwFilas
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If frm.ShowDialog = DialogResult.OK Then
                    ComboNumIngreso()
                    ListarData()
                    uscFotoPerfiles.InternoIngresoId = Me._IDIngreso
                    uscFotoPerfiles.LoadUsc()
                    ListarResoluciones()
                    LoadUscBandas()
                    UscResolucionesMain1._NroIngresoID = Me.cbbNroIngresos.SelectedValue
                    UscResolucionesMain1.LoadUsc()

                    EnabledControles(IIf(frm.blnNuevosDatos = True, False, True))

                    Dim EntInt As New Entity.Registro.Ingreso With {
                        .InternoID = Me.idInterno,
                        .PenalID = Me.idPenal
                    }
                    Dim entIngCol As Entity.Registro.IngresoCol = objBssIng.Listar(EntInt)
                    Dim blnValor As Boolean = False
                    Dim blnValor2 As Boolean = False
                    Dim intValor As Integer = -1
                    For Each Ent As Entity.Registro.Ingreso In entIngCol
                        If intValor = Ent.IngresoNro Then
                            blnValor2 = True
                        Else
                            intValor = Ent.IngresoNro
                        End If

                        If Ent.IngresoNro = 0 Then blnValor = True
                    Next

                    If blnValor = False And blnValor2 = False Then
                        tbpInterno.Enabled = True
                        tbpResoluciones.Enabled = True
                    Else
                        tbpInterno.Enabled = False
                        tbpResoluciones.Enabled = False
                    End If
                End If
            End With
        End Sub


        Private Sub FRM_Mant_Fotos(InternoID As Integer, RestringirEdicion As Boolean)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm As New Registro.Captura.frmFotoPerfiles
            With frm
                ._InternoID = Me.idInterno
                .Codigo = InternoID
                .PenalID = Me.idPenal
                .RegionID = Me.idRegion
                .InternoIngresoId = Me._IDIngreso
                .RestringirEdicion = RestringirEdicion

                .InternoIngresoNro = Val(Me.cbbNroIngresos.SelectedIndex + 1)
                .LoadUsc()
                'permisos
                ._FormEscritura = blnEscrituraRegistro
                ._FormEliminar = blnEliminarRegistro
                ._FormReporte = blnReporteRegistro
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.uscFotoPerfiles.LoadUsc()
                    Me.uscFotoPerfiles.DataGrieView_Click()
                End If
            End With

        End Sub


        Private Sub FRM_Mant_Siscrico(ByVal Nuevo As Boolean)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Siscrico.Bandas.frmInternoBandaPopupV2
            With frm

                If Nuevo Then
                    .Codigo = -1
                    ._NroIngresoID = Me._IDIngreso
                Else
                    .Codigo = Me.UscGrillaBandasV21.GrillaID
                    ._NroIngresoID = Me.UscGrillaBandasV21.GrillaIngresoID
                End If
                .InternoID = Me.idInterno
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._VisibleGrabar = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then Me.UscGrillaBandasV21._LoadUsc()

            End With
        End Sub

        Private Sub frmCRImpresion(idTramiteConstancia As Integer, estadoTramite As Short)

            Dim filtro As New Entity.Registro.ConstanciaReclusion.ReporteFiltro
            With filtro
                .idTramiteCR = idTramiteConstancia
                .estadoTramite = estadoTramite
                .idRegion = Me.idRegion
                .idPenal = Me.idPenal
            End With

            Dim frm As New APPReporte.Registro.ConstanciaReclusion.ReporteCrystal(Configuracion.Licencia.Codigo,
                                                                                  Enumeracion.ConstanciaReclusion.enmReporte.constanciaReclusion,
                                                                                  filtro)

            frm.ShowDialog()

        End Sub

#End Region


#Region "Resoluciones"
        Private Sub FRM_ListadoExpediente()

            Dim frm As New Registro.Resoluciones.frmVerExpePorResolPopup(_IDIngreso, idInterno)
            frm.ShowDialog()

        End Sub
        Private Sub FRM_Resolucion_Sentencia(TipoResolucion As System.Int32, IDDocumentoJudicial As System.Int32, SubTipo As Integer)

            Select Case TipoResolucion
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                    FRM_Resolucion_Libertad(IDDocumentoJudicial, SubTipo)
                    ListarCabecera()
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental
                    FRM_OrdenTraslado(IDDocumentoJudicial, TipoResolucion)
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Traslado
                    FRM_Resol_Traslado(IDDocumentoJudicial)
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionReferenciado
                    FRM_Resol_Detencion(IDDocumentoJudicial)
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Resolucion
                    FRM_Resol_Expediente(IDDocumentoJudicial)
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso

                    FRM_Resolucion_Ingreso(IDDocumentoJudicial, SubTipo)
                    ListarCabecera()

                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                    FRM_Resol_Aclaratoria(IDDocumentoJudicial)
                    ListarData()
                    ListarCabecera()
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                    FRM_Resol_AmpliacionAutoapertorio(IDDocumentoJudicial)
                    ListarData()
                    ListarCabecera()
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                    FRM_ResolucionAvocamiento(IDDocumentoJudicial)
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion
                    FRM_Resolucion_ProlongDetencion(IDDocumentoJudicial)
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                    FRM_Resolucion_Nota(IDDocumentoJudicial, SubTipo)
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes
                    FRM_Resolucion_AcumExpediente(IDDocumentoJudicial)
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria_de_Libertad
                    FRM_Resolucion_RevocatoriaLibertad(IDDocumentoJudicial)
                    ListarCabecera()
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
                    FRM_Queda(IDDocumentoJudicial)
                    ListarCabecera()
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia
                    FRM_Resol_Sentencia(IDDocumentoJudicial)
                    ListarCabecera()
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                     Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                    FRM_Resol_IntegracionSentencia(IDDocumentoJudicial, TipoResolucion)
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Conmutacion_Pena
                    FRM_Resol_Conmutacion(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.Sentencia_Aclaratoria, enumTipoDocumentoJudicial.Sent_Adecuacion_Pena,
                      enumTipoDocumentoJudicial.Sent_Sustitucion_Pena,
                     enumTipoDocumentoJudicial.ResolucionConsentida, enumTipoDocumentoJudicial.Resolucion,
                     enumTipoDocumentoJudicial.Resolucion_Superior, enumTipoDocumentoJudicial.Sent_Pena_Limitativa,
                     enumTipoDocumentoJudicial.Ejecutoria_Superior, enumTipoDocumentoJudicial.Ejecutoria_Suprema,
                     enumTipoDocumentoJudicial.Integracion_Sentencia

                    FRM_Resol_SentenciaMultiple(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()

                Case enumTipoDocumentoJudicial.Anulacion_Antecedentes

                    FRM_Resol_AnulacionAntecedentes(IDDocumentoJudicial, TipoResolucion)

                    ListarCabecera()
            End Select

        End Sub
        Private Sub FRM_ListarResoluciones(IngresoID As Integer, ResolucionRegistrada As Boolean, Opcion As Integer)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me._IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            If ValorIngreso = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados," + Chr(13) +
                                                            "regularizar para poder realizar una operación.")
                Exit Sub
            End If

            Dim frm As New Registro.Resoluciones.frmResolucionTipoPopup
            With frm
                ._InternoID = Me.idInterno
                ._IngresoID = IngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.txtInterno.Text
                ._ResolucionIngRegistrado = ResolucionRegistrada
                ._OpcionListar = Opcion
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    UscResolucionesMain1._Listar()

                    ListarCabecera()
                    ListarData()
                End If
            End With

        End Sub

        Private Sub FRM_Resolucion_Ingreso(DocJudicialId As Integer, DocSubTipo As Integer)

            Dim frm As New Registro.Resoluciones.frmResolIngreso
            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoID = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._DocumentoSubtipo = DocSubTipo
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub
        Private Sub FRM_Resolucion_Libertad(DocJudicialId As Integer, Optional Version As Integer = -1)
            If Version = -1 Then
                Dim frm As New Registro.Resoluciones.frmResolLibertad
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                    ._RegionID = Me.idRegion
                    ._PenalID = Me.idPenal
                    ._InternoId = Me.idInterno
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._blnNuevoRegistro = False
                    ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormImpresion = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

                End With
            Else
                Dim frm As New Registro.Resoluciones.frmResolLibertad_v2
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                    ._RegionID = Me.idRegion
                    ._PenalID = Me.idPenal
                    ._InternoId = Me.idInterno
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._blnNuevoRegistro = False
                    ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormImpresion = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

                End With
            End If
        End Sub
        Private Sub FRM_Resolucion_Nota(DocJudicialId As Integer, SubTipo As Integer)
            Select Case SubTipo
                Case enumSubTipo.ProyeccionVencimientoCondena
                    Dim frm As New Registro.Resoluciones.frmProyeccionVencimientoCondena
                    With frm
                        ._Codigo = DocJudicialId
                        ._InternoId = Me.idInterno
                        ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                        ._RegionID = Me.idRegion
                        ._PenalID = Me.idPenal
                        ._CodigoInterno = Me.CodigoRPInterno
                        ._NombresInterno = Me.InternoApeyNom
                        ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                        ._Subtipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.ProyeccionVencimientoCondena
                        ._blnNuevoRegistro = True
                        ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                        'permisos
                        ._FormEscritura = False
                        ._FormEliminar = False
                        ._FormImpresion = False

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                        End If

                    End With
                Case enumSubTipo.Nota_de_Sentencia, enumSubTipo.Adelanto_de_Fallo
                    Dim frm As New Registro.Resoluciones.frmNotaPeriodo
                    With frm
                        ._Codigo = DocJudicialId
                        ._InternoId = Me.idInterno
                        ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                        ._RegionID = Me.idRegion
                        ._PenalID = Me.idPenal
                        ._CodigoInterno = Me.CodigoRPInterno
                        ._NombresInterno = Me.InternoApeyNom
                        ._blnNuevoRegistro = False
                        'permisos
                        ._FormEscritura = False
                        ._FormEliminar = False
                        ._FormImpresion = False

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                        End If

                    End With
                Case Else
                    Dim frm As New Registro.Resoluciones.frmNota

                    With frm
                        ._Codigo = DocJudicialId
                        ._InternoId = Me.idInterno
                        ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                        ._RegionID = Me.idRegion
                        ._PenalID = Me.idPenal
                        ._CodigoInterno = Me.CodigoRPInterno
                        ._NombresInterno = Me.InternoApeyNom
                        ._blnNuevoRegistro = False

                        'permisos
                        ._FormEscritura = False
                        ._FormEliminar = False
                        ._FormImpresion = False

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                        End If

                    End With
            End Select
        End Sub
        Private Sub FRM_Resolucion_ProlongDetencion(DocJudicialId As Integer)

            Dim frm As New Registro.Resoluciones.frmResolProlongDetencion

            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_ResolucionAvocamiento(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolAvocamiento

            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_Resol_AmpliacionAutoapertorio(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolAmpliaAutoapert

            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_Resol_Traslado(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolTraslado

            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_Resol_Detencion(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolDetencionReferenciado

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.idInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionReferenciado
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_Resol_Expediente(DocJudicialId As Integer)
            Dim frm As New Registro.Sentencias.frmResolSentenciaMultiple

            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.idInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoID = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Resolucion
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_Resol_PrisionPreventiva(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolPrisionPreventiva

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.idInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_Resol_Aclaratoria(DocJudicialId As Integer)
            'verificar
            Dim frm As New Registro.Resoluciones.frmResolAclaratoriaExpe

            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._NuevoRegistro = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If
            End With
        End Sub
        Private Sub FRM_Resolucion_AcumExpediente(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolAcumExpedientes

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.idInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_Resolucion_RevocatoriaLibertad(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolRevocatoriaLibertad

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.idInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_Queda(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmQueda

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.idInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_Resol_AclaratoriaNombres(intIDDocJudicial As Integer)


            Dim frm As New Registro.Resoluciones.frmResolAclaratoriaExpe
            With frm
                ._Codigo = intIDDocJudicial
                ._InternoIngresoId = Me._IDIngreso  'UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._NuevoRegistro = False
                ._Subtipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Nombre
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If
            End With

        End Sub
        Private Sub FRM_TrasladoHospitalmental(MovimientoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer, Pendientes As Integer)
            Dim frm As New Registro.Movimientos.frmMovimientoTrasladoHospitalmental
            With frm
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.idInterno
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._MovimientoMotivoID = MovimientoMotivoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.TrasladoHospitalmental
                ._NroPendientes = Pendientes
                '._CargarExpedientes = True
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_OrdenTraslado(DocJudicialId As Integer, TipoResolucionId As Integer)

            Dim frm As New Registro.Resoluciones.frmOrdenTrasladoHospital
            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = TipoResolucionId
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
#End Region

#Region "Sentencias"
        Private Sub FRM_Resol_Sentencia(DocJudicialId As Integer)
            Dim frm As New Registro.Sentencias.frmResolSentencia

            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.idInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub

        Private Sub FRM_Resol_IntegracionSentencia(DocJudicialId As Integer, TipoDocumento As Integer)
            Dim frm As New Registro.Sentencias.frmResolIntegracionSent
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.idInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = TipoDocumento
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub
        Private Sub FRM_Resol_Conmutacion(DocJudicialId As Integer, TipoResolucion As Integer)

            Dim frm As New Registro.Sentencias.frmResolSentenciaConmutacion
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.idInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoID = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With

        End Sub
        Private Sub FRM_Resol_SentenciaMultiple(DocJudicialId As Integer, TipoResolucion As Integer)
            If TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia Then
                Dim frm As New Registro.Sentencias.frmResolIntegracionSent
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoID = Me.idInterno
                    ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                    ._RegionID = Me.idRegion
                    ._PenalID = Me.idPenal
                    ._InternoID = Me.idInterno
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._TipoResolucion = TipoResolucion
                    ._blnNuevoRegistro = False
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormImpresion = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                    End If

                End With
            Else
                Dim frm As New Registro.Sentencias.frmResolSentenciaMultiple
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoID = Me.idInterno
                    ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                    ._RegionID = Me.idRegion
                    ._PenalID = Me.idPenal
                    ._InternoID = Me.idInterno
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._TipoResolucion = TipoResolucion
                    ._blnNuevoRegistro = False
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormImpresion = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                    End If

                End With
            End If
        End Sub
        Private Sub FRM_Resol_AnulacionAntecedentes(DocJudicialId As Integer, TipoResolucion As Integer)
            Dim frm As New Registro.Sentencias.frmResolAnulacion
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.idInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoID = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormImpresion = False
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If
            End With
        End Sub
#End Region


#Region "Clasificacion"
        Private Sub FRM_ClasificacionIndicadores(intTipoFicha As Short, objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.DatosFicha)

            Dim frm As New Registro.Carceleta.Clasificacion.frmDetalleFicha_V2

            With frm
                .VariableId = objEnt.MaeIDVariable
                .FichaId = objEnt.MaeIDFicha
                .RegionID = Me.idRegion
                .PenalID = Me.idPenal
                .VariableString = objEnt.VariableNombre
                ._ValorPuntaje = objEnt.ValorPuntaje
                ._ValorNoPrevisto = objEnt.ValorNoPrevisto
                .InternoFichaDetalleId = objEnt.IDInternoFichaDetalle
                .IndicadorId = objEnt.IDIndicador
                .BloquearRegistro = objEnt.BloquearRegistro
                .SituacionJuridicaId = objEnt.InternoIDSituacionJuridica
                .GrupoFichaId = objEnt.IDGrupoFicha
                ._VisibleNoPrevisto = False

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Select Case intTipoFicha
                        Case 1
                            UscFichaClasificacion1._ListarFilaVariable(._ValorPuntaje, .ValorNombreSeleccionado, .ValorIdSeleccionado, ._ValorNoPrevisto)
                        Case 2
                            uscFicClasifEtapaProv._ListarFilaVariable(._ValorPuntaje, .ValorNombreSeleccionado, .ValorIdSeleccionado, ._ValorNoPrevisto)
                    End Select
                End If
            End With

        End Sub
        Private Sub FRM_ReporteClasificacion(intIDInternoFichaFinal As Integer, objFichaTab As uscFichaClasificacionRegimen.EnmFichaTab)

            Dim frm As New APPReporte.Tratamiento.TallerAsistencia.ReporteCrystal
            With frm
                ._Filtro.RegionID = Me.idRegion
                ._Filtro.RegionNombre = Me.regionNombre
                ._Filtro.PenalID = Me.idPenal
                ._Filtro.PenalNombre = Me.penalNombre
                ._Filtro.InternoID = Me.idInterno
                ._Filtro.IDInternoFichaFinal = intIDInternoFichaFinal
                ._Filtro.InternoIngresoID = Me._IDIngreso

                Select Case objFichaTab
                    Case uscFichaClasificacionRegimen.EnmFichaTab.enmRegimen
                        ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionRegimen

                    Case uscFichaClasificacionRegimen.EnmFichaTab.enmEtapa
                        ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionEtapa

                    Case Else
                        ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionEtapa
                End Select

                .ShowDialog()
            End With

        End Sub
#End Region

#End Region
#Region "Permisos_Usuario"
        Private Function ValidarSedeLicencia(IDPenal As Integer) As Integer

            Dim value As Integer = -1

            Select Case (New Bussines.Sistema.Instalacion).Listar(Me.IDLicencia).Tipo

                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede
                    value = Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    Dim intLicEscritura As Integer = (New Bussines.Sistema.InstalacionDetalle).VerificarPermisoEscritura(-1, Me.IDLicencia, IDPenal)
                    If intLicEscritura > 0 Then
                        value = -1
                    Else
                        value = Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    End If
                Case Else
                    value = -1

            End Select

            Return value

        End Function

        Private Sub Usuario_Permisos()

            Dim intLicenciaID As Integer = Me.IDLicencia
            Dim intTipoLicencia As Short = -1
            Dim blnVerTabClasificacion As Boolean = False

            intTipoLicencia = (New Bussines.Sistema.Instalacion).ListarTipo(intLicenciaID)

            '/*Implementado 04112022*/
            Dim obj As Entity.Sistema.Seguridad.Usuario = Permisos._FormPermisosRegistro(Legolas.Configuration.Usuario.Codigo, Type.Enumeracion.Modulo.enmModulo.RegistroProvinciaV2, intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            blnLecturaRegistro = obj.FormLectura
            blnEscrituraRegistro = obj.FormEscritura
            blnEliminarRegistro = obj.FormEliminacion
            blnReporteRegistro = obj.FormReporte
            'permisos de tratamiento
            Dim blnLecturaTratamiento As Boolean = Permisos._FormLecturaTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            Dim blnEscrituraTratamiento As Boolean = Permisos._FormEscrituraTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            Dim blnReporteTratamiento As Boolean = Permisos._FormReporteTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)

            'fotografia
            Me.uscFotoPerfiles._VisibleGrabar = False
            Me.uscFotoPerfiles._VisibleEliminar = False

            '/*organizacion criminal*/
            Me.UscGrillaBandasV21._VisibleGrabar = False
            Me.UscGrillaBandasV21._VisibleEliminar = False

            '/*documentos, resoluciones */
            Me.UscResolucionesMain1._VisibleGrabar = False
            Me.UscResolucionesMain1._VisibleEliminar = False
            Me.UscResolucionesMain1.MostrarBotonDetExp(False)

            If blnLecturaTratamiento = True And blnLecturaRegistro = True Then
                'nada, perfil osin

                With Me.UscFichaClasificacion1
                    ._uscEscritura = False
                    ._uscReporte = True
                End With

                With Me.uscFicClasifEtapaProv
                    ._uscEscritura = False
                    ._uscReporte = True
                End With
                UscFichaPorRegresion1._uscLectura = True
                UscFichaPorRegresion1._uscEscritura = IIf(Me._frmEscritura, blnEscrituraTratamiento, False) 'PENDIENTEHNRB para produccion, debe ser solo lectura
                UscFichaPorRegresion1._uscReporte = IIf(Me._frmReporte, blnReporteTratamiento, False)

                UscFichaClasifTraslado1._uscLectura = True
                UscFichaClasifTraslado1._uscEscritura = IIf(Me._frmEscritura, blnEscrituraTratamiento, False)
                UscFichaClasifTraslado1._uscReporte = IIf(Me._frmReporte, blnReporteTratamiento, False)
            Else
                If blnLecturaTratamiento = True Then
                    'eliminar el tabs de registros
                    Me.TabControl1.TabPages.Remove(Me.tbpResoluciones)
                    Me.tbcDatosInternos.TabPages.Remove(tbpOrgCriminal)

                    'pemrisos
                    UscFichaClasificacion1._uscEscritura = blnEscrituraTratamiento
                    UscFichaClasificacion1._uscReporte = blnReporteTratamiento

                    uscFicClasifEtapaProv._uscEscritura = blnEscrituraTratamiento
                    uscFicClasifEtapaProv._uscReporte = blnReporteTratamiento

                    UscFichaPorRegresion1._uscLectura = blnLecturaTratamiento
                    UscFichaPorRegresion1._uscEscritura = IIf(Me._frmEscritura, blnEscrituraTratamiento, False)
                    UscFichaPorRegresion1._uscReporte = IIf(Me._frmReporte, blnReporteTratamiento, False)

                    UscFichaClasifTraslado1._uscLectura = blnLecturaTratamiento
                    UscFichaClasifTraslado1._uscEscritura = IIf(Me._frmEscritura, blnEscrituraTratamiento, False)
                    UscFichaClasifTraslado1._uscReporte = IIf(Me._frmReporte, blnReporteTratamiento, False)
                Else
                    'eliminar el tabs de tratamiento
                    Me.TabControl1.TabPages.Remove(Me.tbpClasificacion)
                End If
            End If

            Dim intPerfil As Type.Enumeracion.Usuario.EnumDependencia = Legolas.Configuration.Usuario.OficinaID
            Select Case intPerfil
                Case Enumeracion.Usuario.EnumDependencia.Legal,
                     Enumeracion.Usuario.EnumDependencia.Social,
                     Enumeracion.Usuario.EnumDependencia.Psicologo,
                     Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal,
                     Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial,
                     Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo,
                     Enumeracion.Usuario.EnumDependencia.JefeJTCySocial,
                     Enumeracion.Usuario.EnumDependencia.SecretariaJuntaClasificacion
                    tcClasificacion.TabPages.Remove(Me.tabAnexo05)
            End Select

            Me.TabControl1.TabPages.Remove(Me.tbpResoluciones)
        End Sub
#End Region

#Region "Otros"
        Private Sub HabilitarControlesAccion()

            Dim blnVisibleLeyenda As Boolean = False

            Select Case Me.TabControl1.SelectedTab.Name

                Case Me.tbpInterno.Name

                    Select Case Me.tbcDatosInternos.SelectedTab.Name

                        Case Me.tbpDatos.Name   'datos del interno, foto
                            Me.Panel3.Visible = True

                        Case Me.tbpFoto.Name  'foto
                            Me.Panel3.Visible = False

                        Case Me.tbpOrgCriminal.Name 'bandas
                            Me.Panel3.Visible = False

                        Case Else
                            Me.Panel3.Visible = False
                    End Select

                Case Me.tbpResoluciones.Name
                    Me.Panel3.Visible = False

            End Select


        End Sub

        Private Sub HabilitarNacimiento()
            If Me.Pais = 85 Then 'peru
                Me.Departamento = -1
                Me.CbbDepartamento.Enabled = True
                Me.cbbProvincia.Enabled = True
                Me.cbbDistrito.Enabled = True
                Me.UbigeoNacimientoOtros = ""
                Me.txtUbigeoOtro.Enabled = False
            Else
                Me.CbbDepartamento.DataSource = Nothing
                Me.cbbProvincia.DataSource = Nothing
                Me.cbbDistrito.DataSource = Nothing

                Me.CbbDepartamento.Enabled = False
                Me.cbbProvincia.Enabled = False
                Me.cbbDistrito.Enabled = False
                Me.txtUbigeoOtro.Enabled = True
            End If
        End Sub

        Private Sub ValoresxDefault()

            Combo()
            ComboPais()
            ComboDepartamento()
            ComboProvincia()
            ComboDistrito()

            ComboNumIngreso()

            Me.TipoDocumento = -1   '10 dni
            Me.Nacionalidad = 141    '141 peruana
            Me.Pais = -1    '85 peru
            Me.Sexo = -1
            Me.EstadoCivil = -1
            Me.txtUbigeoOtro.Enabled = False
            Me.txtCodigo.BackColor = Control.DefaultBackColor()
            Me.txtInterno.BackColor = Control.DefaultBackColor()
            Me.txtEstado.BackColor = Control.DefaultBackColor()
            Me.txtRegionPenal.BackColor = Control.DefaultBackColor()

            Me.Refresh()

        End Sub


#End Region


        Private Sub UscResolucionesMain1__Click_BtnVerExpedientesPorResolucion(_NroIngresoID As System.Int32) Handles UscResolucionesMain1._Click_BtnVerExpedientesPorResolucion
            FRM_ListadoExpediente()
        End Sub
        Private Sub UscResolucionesMain1__Click_BtnNuevoResolucion(IngresoID As System.Int32, ResIngRegistrado As Boolean, Opcion As Integer) Handles UscResolucionesMain1._Click_BtnNuevoResolucion
            FRM_ListarResoluciones(IngresoID, ResIngRegistrado, Opcion)
        End Sub

        Private Sub frmMantenimiento2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()
            HabilitarControlesAccion()

        End Sub

        Private Sub frmMantenimiento2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown

            ListarData()

            Usuario_Permisos()


        End Sub

        Private Sub CbbDepartamento_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CbbDepartamento.KeyPress
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End Sub

        Private Sub CbbDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbbDepartamento.SelectedIndexChanged
            If blnComboDep = True Then
                ComboProvincia()
                ComboDistrito()
            End If
        End Sub

        Private Sub cbbProvincia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbProvincia.KeyPress
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End Sub

        Private Sub cbbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbProvincia.SelectedIndexChanged
            If blnComboProv = True Then
                ComboDistrito()
            End If
        End Sub


        Private Sub cbbPais_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbPais.KeyPress
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End Sub

        Private Sub cbbPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbPais.SelectedIndexChanged
            If blnPais = True Then
                ComboDepartamento()
                HabilitarNacimiento()
            End If
        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Dim blnSalir As Boolean = True
            Select Case Me.tbcDatosInternos.SelectedTab.Name
                Case Me.tbpDatos.Name
            End Select

            If blnSalir = True Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If

        End Sub

        Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcDatosInternos.SelectedIndexChanged

            Select Case Me.tbcDatosInternos.SelectedTab.Name
                Case Me.tbpDatos.Name
                    If blnModificarDatos = False Then
                        ListarData()
                    End If
                Case Me.tbpFoto.Name
                    LoadUscFotografia()

                Case Me.tbpOrgCriminal.Name
                    LoadUscBandas()

            End Select

            HabilitarControlesAccion()

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedTab.Name
                Case Me.tbpResoluciones.Name
                    ListarResoluciones()

                Case Me.tbpClasificacion.Name
                    ListarClasificacionRegimen()
            End Select

            HabilitarControlesAccion()

        End Sub



        Private blnCheck As Boolean = False


        Private Sub txtNom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
            If e.KeyChar = "." Then e.Handled = True
        End Sub


        Private Sub cbbNroIngresos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbNroIngresos.SelectedIndexChanged

            If Me.idInterno < 1 Or Me._IDIngreso < 1 Then
                Exit Sub
            End If

            TabControl1_SelectedIndexChanged(sender, e)
            TabControl2_SelectedIndexChanged(sender, e)
            uscFotoPerfiles.DataGrieView_Click()

        End Sub


        Private Sub UscGrillaBandasV21__AddInternoBanda() Handles UscGrillaBandasV21._AddInternoBanda
            FRM_Mant_Siscrico(True)
        End Sub

        Private Sub UscGrillaBandasV21__UpdInternoBanda() Handles UscGrillaBandasV21._UpdInternoBanda
            FRM_Mant_Siscrico(False)
        End Sub

        Private Sub btnAddIngreso_Click(sender As System.Object, e As System.EventArgs) Handles btnAddIngreso.Click
            Me.NuevoClickfrmIngreso = False
            FRM_ListaIngreso()
        End Sub

        Private Sub uscFotoPerfiles__Clik_MantenimientoFotos(InternoFotId As System.Int32, RestringirEdicion As Boolean) Handles uscFotoPerfiles._Clik_MantFotos
            FRM_Mant_Fotos(InternoFotId, RestringirEdicion)
        End Sub



        Private Sub UscResolucionesMain1__Click_BtnEliminarActualizarEstadoInterno() Handles UscResolucionesMain1._Click_BtnEliminarActualizarEstadoInterno

            ListarCabecera()
            ListarData()

        End Sub


        Private Sub chkNoindica_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chkNoindica.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub cbbDistrito_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbDistrito.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub UscResolucionesMain1__ClickFocusCombo() Handles UscResolucionesMain1._ClickFocusCombo
            Me.cbbNroIngresos.Focus()
        End Sub


        Private Sub cbbSexo_Validated(sender As Object, e As System.EventArgs) Handles cbbSexo.Validated
            dtpFechaNac.Focus()
        End Sub

        Private Sub dtpFechaNac_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaNac.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub dtpFechaNac_Validated(sender As Object, e As System.EventArgs) Handles dtpFechaNac.Validated
            chk_Obs_DNI.Focus()
        End Sub

        Private Sub uscFotoPerfiles__Clik_btnIngresofocus() Handles uscFotoPerfiles._Clik_btnIngresofocus
            btnAddIngreso.Focus()
        End Sub

        Private Sub chk_Homonimia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub


        Private Sub TabControl2_Selecting(sender As Object, e As System.Windows.Forms.TabControlCancelEventArgs) Handles tbcDatosInternos.Selecting

            If blnModificarDatos = True Then
                If e.TabPage.Name = "tbpDatosComplement" Or e.TabPage.Name = "tbpDatos" Then

                Else
                    If MessageBox.Show("¿Desea guardar los datos del interno?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        blnModificarDatos = False
                    Else
                        e.Cancel = True
                    End If
                End If
            End If

        End Sub

        Private Sub TabControl1_Selecting(sender As Object, e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting
            If UscFichaClasificacion1.IsRegimenEnEstadoEdicion Then 'para no permitir cambiar a otra ficha mientras esta en edicion
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede cambiar de pestaña mientras se encuentre en modo de edición.")
                'tcClasificacion.SelectedTab = tpRegimen
                e.Cancel = True
                Exit Sub
            End If
            If UscFichaClasificacion1.IsEtapaEnEstadoEdicion Then 'para no permitir cambiar a otra ficha mientras esta en edicion
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede cambiar de pestaña mientras se encuentre en modo de edición.")
                'tcClasificacion.SelectedTab = tpEtapa
                e.Cancel = True
                Exit Sub
            End If
            If blnModificarDatos = True Then
                If MessageBox.Show("¿Desea guardar los datos del interno?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    blnModificarDatos = False
                    EnabledControles(True)
                Else
                    e.Cancel = True
                End If
            End If

        End Sub


        Private Sub UscFichaClasificacion1__GrillaFichaVariable_CellClick(objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.DatosFicha) Handles UscFichaClasificacion1.GrillaFichaVariable_CellClick
            FRM_ClasificacionIndicadores(1, objEnt)
        End Sub

        Private Sub tcClasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcClasificacion.SelectedIndexChanged

            Select Case Me.tcClasificacion.SelectedTab.Name
                Case Me.tpRegimen.Name
                    ListarClasificacionRegimen()

                Case Me.tpEtapa.Name
                    ListarClasificacionEtapa()

                Case Me.tabClasifRegresion.Name
                    ListarClasificacionRegresion()
                Case Me.tabAnexo05.Name
                    ListarClasificacionTraslado()
            End Select

        End Sub


        Private Sub UscFichaClasificacion1__GrillaFicha_CellEnter(intCodigo As Integer, TipoTablaAudit As Enumeracion.Auditoria.EnumTipTabla) Handles UscFichaClasificacion1.GrillaFicha_CellEnter
            Me.UscAuditUser1.LoadAudit(intCodigo, TipoTablaAudit)
        End Sub

        Private Sub UscFichaClasificacion1__Reporte_Click(intIDInternoFichaFinal As Integer, objFichaTab As uscFichaClasificacionRegimen.EnmFichaTab) Handles UscFichaClasificacion1.Reporte_Click

            Dim frm As New APPReporte.Tratamiento.TallerAsistencia.ReporteCrystal
            With frm
                ._Filtro.RegionID = Me.idRegion
                ._Filtro.RegionNombre = Me.regionNombre
                ._Filtro.PenalID = Me.idPenal
                ._Filtro.PenalNombre = Me.penalNombre
                ._Filtro.InternoID = Me.idInterno
                ._Filtro.IDInternoFichaFinal = intIDInternoFichaFinal
                ._Filtro.InternoIngresoID = Me._IDIngreso

                Select Case objFichaTab
                    Case uscFichaClasificacionRegimen.EnmFichaTab.enmRegimen
                        ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionRegimen

                    Case uscFichaClasificacionRegimen.EnmFichaTab.enmEtapa
                        ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionEtapa

                    Case Else
                        ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionEtapa
                End Select

                .ShowDialog()
            End With
        End Sub



        Private Sub btnDelitosHistoricos_Click(sender As Object, e As EventArgs)
            ListarDelitosMayorPena()
        End Sub

        Private Sub ListarDelitosMayorPena()
            Dim frm As New Registro.frmListaDelitosHistoricos
            frm._InternoID = Me.idInterno
            frm.ShowDialog()
        End Sub

        Private Sub UscInternoDetalle1__click_VerReporte(idCodigo As Integer, estado As Short)
            frmCRImpresion(idCodigo, estado)
        End Sub

        Private Sub UscInternoDetalle1__Click_Nuevo()
            frmConstanciaResluMant(True, -1)
        End Sub

        Private Sub UscInternoDetalle1__Click_Modificar(idTramite As Integer)
            frmConstanciaResluMant(False, idTramite)
        End Sub

        Private Sub UscInternoDetalle1__CellDoubleClick_Modificar(idTramite As Integer)
            frmConstanciaResluMant(False, idTramite)
        End Sub

        Private Sub UscFichaPorRegresion1_Reporte_Click(intIDInternoFichaFinal As Integer) Handles UscFichaPorRegresion1.Reporte_Click
            Dim frm As New APPReporte.Tratamiento.TallerAsistencia.ReporteCrystal
            With frm
                ._Filtro.RegionID = Me.idRegion
                ._Filtro.RegionNombre = Me.regionNombre
                ._Filtro.PenalID = Me.idPenal
                ._Filtro.PenalNombre = Me.penalNombre
                ._Filtro.InternoID = Me.idInterno
                ._Filtro.IDInternoFichaFinal = intIDInternoFichaFinal
                ._Filtro.InternoIngresoID = Me._IDIngreso

                ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionPorRegresion

                .ShowDialog()
            End With
        End Sub

        Private Sub UscFichaClasifTraslado1_Reporte_Click(intIDInternoFichaFinal As Integer) Handles UscFichaClasifTraslado1.Reporte_Click
            Dim frm As New APPReporte.Tratamiento.TallerAsistencia.ReporteCrystal
            With frm
                ._Filtro.RegionID = Me.idRegion
                ._Filtro.RegionNombre = Me.regionNombre
                ._Filtro.PenalID = Me.idPenal
                ._Filtro.PenalNombre = Me.penalNombre
                ._Filtro.InternoID = Me.idInterno
                ._Filtro.IDInternoFichaFinal = intIDInternoFichaFinal
                ._Filtro.InternoIngresoID = Me._IDIngreso

                ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionPorTraslado

                .ShowDialog()
            End With
        End Sub

        Private Sub UscFichaClasificacionEtapa1_Reporte_Click(intIDInternoFichaFinal As Integer, objFichaTab As uscFichaClasificacionEtapaProv_v2.EnmFichaTab) Handles uscFicClasifEtapaProv.Reporte_Click
            FRM_ReporteClasificacion(intIDInternoFichaFinal, objFichaTab)
        End Sub

        Private Sub UscFichaClasificacionEtapa1_GrillaFichaVariable_CellClick(objEnt As DatosFicha) Handles uscFicClasifEtapaProv.GrillaFichaVariable_CellClick
            FRM_ClasificacionIndicadores(2, objEnt)
        End Sub

        Private Sub tcClasificacion_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tcClasificacion.Selecting
            If UscFichaClasificacion1.IsRegimenEnEstadoEdicion Then 'para no permitir cambiar a otra ficha mientras esta en edicion
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede cambiar de pestaña mientras se encuentre en modo de edición.")
                'tcClasificacion.SelectedTab = tpRegimen
                e.Cancel = True
                Exit Sub
            End If
            If UscFichaClasificacion1.IsEtapaEnEstadoEdicion Then 'para no permitir cambiar a otra ficha mientras esta en edicion
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No puede cambiar de pestaña mientras se encuentre en modo de edición.")
                'tcClasificacion.SelectedTab = tpEtapa
                e.Cancel = True
                Exit Sub
            End If
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnModificarResolucion(TipoDocumento As Integer, DocJudicialId As Integer, SubTipo As Integer, Version As String) Handles UscResolucionesMain1._Click_BtnModificarResolucion
            FRM_Resolucion_Sentencia(TipoDocumento, DocJudicialId, SubTipo)
        End Sub
    End Class
End Namespace
