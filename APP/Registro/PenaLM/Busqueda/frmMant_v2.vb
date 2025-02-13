'version del form3
Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.TipoDocJudicial
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Linq
Imports DataClass
Imports System.Data.Linq
Imports Type.Enumeracion.Usuario
Imports Type.Enumeracion.Licencia

Namespace Registro.PenalLM.Busqueda
    Public Class frmMant_v2
        Private objBssInterno As Bussines.Registro.Interno = Nothing
        Private objBssIngresoInpe As Bussines.Registro.IngresoInpe = Nothing
        Private objBssHistorico As Bussines.Registro.InternoHistorico

        Private objEntInt As Entity.Registro.Interno = Nothing
        Private objEntComboIngCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)

        Private blnModificarDatos As Boolean = False
        Private frmLoad As Load.frmProcesando = Nothing
        Private objEntFiltroRegula As Bussines.Registro.InternoRegularizacion.Interno = Nothing
        Private blnRegistroRegula As Boolean = False

        Private Property _FormEscrituraOriginal As Boolean
        Private Property _FormEliminarOriginal As Boolean
#Region "Propiedades_Publicas"
        Private Property idInterno As Integer = -1
        Public Property _blnFormAux As Boolean = False
#End Region

#Region "Propiedades_Interno"
        Public Property _IDInternoSedeRowId As Integer = -1
        Private Property IDInternoHistorico As Integer = -1
        Private Property CentroReclusionMenorId() As Integer
            Get
                Dim v As Integer = -1
                v = cbbCentroReclu.SelectedIndex

                If v = 0 Then v = -1

                Return v
            End Get
            Set(value As Integer)

                If value = -1 Then value = 0

                cbbCentroReclu.SelectedIndex = value
            End Set
        End Property
        Private Property IDIngresoINPE As Integer
            Get
                Try
                    Return Me.cbbNroIngresos.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get

            Set(value As Integer)
                Me.cbbNroIngresos.SelectedValue = value
            End Set
        End Property
        Private _idIngId As Integer = -1

        Private Property IDIngreso() As Integer
            Get
                Return _idIngId
            End Get
            Set(value As Integer)
                _idIngId = value
            End Set
        End Property
        Private Property IDIngresoEstado() As Integer = -1
        Private Property CodigoRPInterno() As String
            Get
                Return Me.txtCodInterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodInterno.Text = value
            End Set
        End Property
        Private Property Libro() As String
            Get
                Return Me.txtLibro.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtLibro.Text = value
            End Set
        End Property
        Private Property Folio() As String
            Get
                Return Me.txtFolio.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtFolio.Text = value
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
        Private Property Discapacidad() As Integer
            Get
                Try
                    Return Me.cbbDiscapacitado.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbDiscapacitado.SelectedValue = value
            End Set
        End Property

        Private Property InternoEstado() As Integer = -1
        Private Property Obs() As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property

        Private Property Obs_DNI() As String
            Get
                Return Me.txtObs_dni.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs_dni.Text = value
            End Set
        End Property

        Private Property PabellonID() As Integer
            Get
                Return Me.cbbPabellon.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPabellon.SelectedValue = value
            End Set
        End Property
        Private Property DocumentoTipo As Integer = -1
        Private Property DecadactilarIzq As String
            Get
                Return txtDecadactIzq.Text
            End Get
            Set(value As String)
                txtDecadactIzq.Text = value
            End Set
        End Property

        Private Property DecadactilarDer As String
            Get
                Return txtDecadactDer.Text
            End Get
            Set(value As String)
                txtDecadactDer.Text = value
            End Set
        End Property
        Private Property EstadoVerificacionRnc() As String
            Get
                Return Me.txtEstadoVerRnc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtEstadoVerRnc.Text = value

            End Set
        End Property
        Private Property TipoVerificacionRnc() As String
            Get
                Return Me.txtTipoVerRnc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtTipoVerRnc.Text = value
            End Set
        End Property

        Private Property FechaVerificacionRnc() As Date
            Get
                Return txtFechaVerRnc.Text
            End Get
            Set(ByVal value As Date)
                txtFechaVerRnc.Text = value
            End Set
        End Property

        Private Property ObservRnc() As String
            Get
                Return Me.txtObservacionRnc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObservacionRnc.Text = value
            End Set
        End Property
        Private NumeroDocumentoAux As String = ""
        Private InternoApePaternoAux As String = ""
        Private InternoApeMaternoAux As String = ""
        Private InternoNombresAux As String = ""

        Private Property GeneroPersonaId() As Integer
            Get
                Try
                    Return Me.cbbGenero.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbGenero.SelectedValue = value
            End Set
        End Property

        Private Property ReligionId() As Integer
            Get
                Try
                    Return Me.cbbReligion.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbReligion.SelectedValue = value
            End Set
        End Property

        Private Property CodigoFuerzaArmadaId() As Integer
            Get
                Try
                    Return Me.cbbCodFuerArmada.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbCodFuerArmada.SelectedValue = value
            End Set
        End Property

        Private Property CodigoRangoId() As Integer
            Get
                Try
                    Return Me.cbbCodigoRango.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbCodigoRango.SelectedValue = value
            End Set
        End Property

        Public Property _IdiomaNativoId() As Integer
            Get
                Try
                    Dim id As Integer = -1
                    id = Me.cbbIdiomaPrincipal.SelectedValue
                    If cbbIdiomaPrincipal.Text = "" Then id = -1
                    Return id
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbIdiomaPrincipal.SelectedValue = value
            End Set
        End Property

        Private Property NombreClaveInterno As String
            Get
                Return txtNomClaveInt.Text
            End Get
            Set(value As String)
                txtNomClaveInt.Text = value
            End Set
        End Property
        Private NuevoClickfrmIngreso As Boolean = False
#End Region
#Region "Propiedades_Ubigeo"
        Private intUbigeoNacimiento As Integer = -1
        Private Property IDNacionalidad() As Integer
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
        Private Property DomicilioDepartamento() As Integer
            Get
                Try
                    Return Me.cbbDomicilioDepa.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbDomicilioDepa.SelectedValue = value
            End Set
        End Property
        Private Property DomicilioProvincia() As Integer
            Get
                Try
                    Return Me.cbbDomicilioProv.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbDomicilioProv.SelectedValue = value
            End Set
        End Property
        Private Property DomicilioDistrito() As Integer
            Get
                Try
                    Return Me.cbbDomicilioDist.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbDomicilioDist.SelectedValue = value
            End Set
        End Property
        Private Property UbigeoDomicilio() As Integer
            Get
                Try
                    Return Me.cbbDomicilioDist.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)

                Dim intValue As Integer = -1
                intValue = value

                If intValue > 0 Then
                    ListarUbigeoDomicilio(intValue)
                Else
                    Me.cbbDomicilioDepa.SelectedValue = -1
                    Me.cbbDomicilioProv.SelectedValue = -1
                    Me.cbbDomicilioDist.SelectedValue = -1
                End If

            End Set
        End Property
        Private Property Domicilio() As String
            Get
                Return Me.txtDomicilio.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDomicilio.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_DatosAcademicos"
        Private Property NivelAcademcico() As Integer
            Get
                Try
                    Return Me.cbbNivelAca.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbNivelAca.SelectedValue = value
            End Set
        End Property
        Private Property Profesion() As Integer
            Get
                Try
                    Return Me.cbbProfesion.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbProfesion.SelectedValue = value
            End Set
        End Property
        Private Property Ocupacion() As Integer
            Get
                Try
                    Return Me.cbbOcupacion.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbOcupacion.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Propiedades_Comunidad"
        Private Property ComunidadAndina() As Integer
            Get
                Try
                    Return Me.cbbAndina.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbAndina.SelectedValue = value
            End Set
        End Property
        Private Property ComunidadAndinaEspecifica() As Integer
            Get
                Try
                    Return Me.cbbAndinaEsp.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbAndinaEsp.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Propiedades_RegionPenal"
        Private Property idRegion() As Integer = -1
        Private Property regionNombre() As String = ""
        Public ReadOnly Property RegionPenalNombre() As String
            Get
                Dim value As String = ""
                value = Me.regionNombre & "-" & Me.penalNombre
                Return value
            End Get
        End Property
        Private Property idPenal() As Integer = -1
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
        Private Property Pabellon() As String
            Get
                Return Me.txtPabellon.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtPabellon.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Sistema"
        Private ReadOnly Property PerfilUsuario As Type.Enumeracion.Usuario.EnumDependencia
            Get
                Return Legolas.Configuration.Usuario.OficinaID
            End Get
        End Property

        Private ReadOnly Property IDLicencia As Short
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
                        'txtEstado.BackColor = Color.White
                        txtEstado.BackColor = Control.DefaultBackColor()
                End Select
                Me.txtEstado.Text = value

            End Set
        End Property
        Private Property VersionRegistro As String = ""
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
            Me.cbbDiscapacitado.LoadUsc()
            Me.cbbNivelAca.LoadUsc()
            Me.cbbProfesion.LoadUsc()
            Me.cbbOcupacion.LoadUsc()
            Me.cbbAndina.LoadUsc()
            Me.cbbGenero.LoadUsc()
            Me.cbbReligion.LoadUsc()
            Me.cbbIdiomaPrincipal.LoadUsc()

            'Me.cbbPertenenciaEtnica.LoadUsc()
            'Me.cbbPertenenciaEtnica.SelectedValue = -1
            'Me.cbbLenguaMaterna.LoadUsc()
            'Me.cbbLenguaMaterna.SelectedValue = -1

            blnComboComAnd = True
        End Sub
        Private blnComboIngreso As Boolean = False
        Public Sub ComboNumIngreso()

            If Me.idInterno < 1 Then
                Exit Sub
            End If

            blnComboIngreso = False

            objBssIngresoInpe = New Bussines.Registro.IngresoInpe
            objEntComboIngCol = New Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            objEntComboIngCol = objBssIngresoInpe.ComboPLM(Me.idInterno, 3) 'region lima
            If objEntComboIngCol.Count > 0 Then

                Dim listDelete As New List(Of Integer)
                'listar los ingresosInpe de otros penales para excluir
                For i As Integer = 0 To objEntComboIngCol.Count - 1
                    If objEntComboIngCol.Item(i).PenalID <> Me.idPenal Then
                        listDelete.Add(objEntComboIngCol.Item(i).Codigo)
                    End If
                Next
                'quitar los ingresoInpe de los demas penales
                For Each elemento As Integer In listDelete
                    For i As Integer = 0 To objEntComboIngCol.Count - 1
                        If objEntComboIngCol.Item(i).Codigo = elemento Then
                            objEntComboIngCol.RemoveAt(i)
                            Exit For
                        End If
                    Next
                Next

                objEntComboIngCol.Sort("IngresoNro", Entity.SortDirection.Desc)

                With Me.cbbNroIngresos
                    .DataSource = objEntComboIngCol
                    .DisplayMember = "IngresoNroLetra"
                    .ValueMember = "Codigo"
                End With

            End If

            If objEntComboIngCol.Count > 0 Then
                Me.IDIngreso = objEntComboIngCol.Item(0).IDIngreso
                Me.IDIngresoEstado = objEntComboIngCol.Item(0).EstadoId
            Else
                Me.IDIngreso = -1
            End If

            blnComboIngreso = True
        End Sub

        Private Sub ComboComunidadAndinaEspecifico()

            With Me.cbbAndinaEsp
                .CodigoPadre = Me.ComunidadAndina
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboPais()
            blnPais = False
            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbPais
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.Pais)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnPais = True
        End Sub
        Private Sub ComboDepartamento()

            blnComboDep = False

            Dim objBss As New Bussines.General.Parametrica
            With Me.CbbDepartamento
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.Departamento, Me.Pais)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnComboDep = True

        End Sub
        Private Sub ComboProvincia()
            blnComboProv = False
            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbProvincia
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.Provincia, Me.Departamento)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnComboProv = True
        End Sub
        Private Sub ComboDistrito()

            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbDistrito
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.Distrito, Me.Provincia)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With

        End Sub
        Private Sub ComboDomicilioDepartamento()

            blnComboDomDep = False
            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbDomicilioDepa
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.Departamento, 85) 'peru
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnComboDomDep = True

        End Sub
        Private Sub ComboDomicilioProvincia()
            blnComboDomProv = False
            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbDomicilioProv
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.Provincia, Me.DomicilioDepartamento)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnComboDomProv = True
        End Sub
        Private Sub ComboDomicilioDistrito()

            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbDomicilioDist
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.Distrito,
                Me.DomicilioProvincia)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With

        End Sub

        Private Sub ComboFuerzaArmada()

            blnComboFzaArm = False
            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbCodFuerArmada
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.FuerzaArmada) 'peru
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            blnComboFzaArm = True

        End Sub

        Private Sub ComboRangoFuerzaArmada()
            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbCodigoRango
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.RangoMilitar, Me.CodigoFuerzaArmadaId)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
        End Sub

        Private Sub ComboPabellon()

            'pabellon
            Me.cbbPabellon.CodigoPadre = Me.idPenal
            Me.cbbPabellon.LoadUsc()

        End Sub
        'Private Sub ComboPerteneciaEtnicaAuxiliar()
        '    If Me.cbbPertenenciaEtnica.SelectedValue = 3 Then
        '        txtPertenenciaEtnica.Visible = False
        '        cbbPerteneciaEtnicaOtros.Visible = True
        '        Me.cbbPerteneciaEtnicaOtros.Parametro1 = -1
        '    ElseIf Me.cbbPertenenciaEtnica.SelectedValue = 4 Then
        '        txtPertenenciaEtnica.Visible = False
        '        cbbPerteneciaEtnicaOtros.Visible = True
        '        Me.cbbPerteneciaEtnicaOtros.Parametro1 = 2
        '    ElseIf Me.cbbPertenenciaEtnica.SelectedValue = 8 Then
        '        Me.cbbPerteneciaEtnicaOtros.Parametro1 = 3
        '        Me.cbbPerteneciaEtnicaOtros.Visible = False
        '        Me.txtPertenenciaEtnica.Visible = True
        '        Me.txtPertenenciaEtnica.Enabled = True
        '        Me.txtPertenenciaEtnica.Focus()
        '    Else
        '        Me.cbbPerteneciaEtnicaOtros.Parametro1 = 3
        '        Me.cbbPerteneciaEtnicaOtros.Visible = False
        '        Me.txtPertenenciaEtnica.Visible = True
        '        Me.txtPertenenciaEtnica.Enabled = False
        '    End If
        '    Me.cbbPerteneciaEtnicaOtros.LoadUsc()
        '    Me.cbbPerteneciaEtnicaOtros.SelectedValue = -1
        'End Sub
        'Private Sub ComboLenguaMaternaAuxiliar()
        'If Me.cbbLenguaMaterna.SelectedValue = 9 Then
        '        Me.cbbLenguaMaternaAuxiliar.Enabled = True
        '        Me.cbbLenguaMaternaAuxiliar.Parametro1 = -1
        '    ElseIf Me.cbbLenguaMaterna.SelectedValue = 12 Then
        '        Me.cbbLenguaMaternaAuxiliar.Enabled = True
        '        Me.cbbLenguaMaternaAuxiliar.Parametro1 = 1
        '    Else
        '        Me.cbbLenguaMaternaAuxiliar.Parametro1 = 2
        '        Me.cbbLenguaMaternaAuxiliar.Enabled = False
        '    End If
        '    cbbLenguaMaternaAuxiliar.LoadUsc()
        '    cbbLenguaMaternaAuxiliar.SelectedValue = -1
        'End Sub
#End Region
#Region "Validar"

        Public Sub ValidarDuplicadosIngreso()

            If Me.idInterno < 1 Then
                Exit Sub
            End If

            Dim blnNumIngreDuplicado As Boolean = False
            Dim blnIngreso0 As Boolean = False
            Dim blnEliminarTab As Boolean = False

            objBssIngresoInpe = New Bussines.Registro.IngresoInpe

            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            objEntCol = objBssIngresoInpe.ComboPLM(Me.idInterno, Me.idPenal)

            Dim objEntCopiaCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)

            For Each obj As Entity.Registro.IngresoInpe In objEntCol

                If obj.IngresoNro = 0 Then
                    blnIngreso0 = True
                End If

                If objEntCopiaCol.Count = 0 Then
                    objEntCopiaCol.Add(obj)
                Else

                    Dim blnAddFila As Boolean = False
                    For Each obj2 As Entity.Registro.IngresoInpe In objEntCopiaCol
                        If obj.IngresoNro = obj2.IngresoNro Then
                            blnNumIngreDuplicado = True
                        Else
                            blnAddFila = True
                        End If
                    Next

                    If blnAddFila = True Then
                        objEntCopiaCol.Add(obj)
                    End If

                End If
            Next

            If blnIngreso0 = True Then

                If blnNumIngreDuplicado = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados y Nº de ingreso [0]." + Chr(13) +
                                                                    "Debe regularizar para poder realizar una operación," + Chr(13) +
                                                                    "Ir a la lista de ingresos.")
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un Nº de ingreso [0]." + Chr(13) +
                                                                        "Debe regularizar para poder realizar una operación," + Chr(13) +
                                                                        "Ir a la lista de ingresos.")
                End If
                blnEliminarTab = True
            End If

            If blnNumIngreDuplicado = True Then

                If blnIngreso0 = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados y Nº de ingreso [0]." + Chr(13) +
                                                                      "Debe regularizar para poder realizar una operación," + Chr(13) +
                                                                      "Ir a la lista de ingresos.")
                    blnEliminarTab = True
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados," + Chr(13) +
                                                                     "Coordine con la ORL para su regularización, confirmada la operación descargue la información " + Chr(13) +
                                                                     " presionando sobre el botón [Descargar documentos judiciales de la O.R.L.] "
                                                                     )
                End If
                'blnEliminarTab = True
            End If

            If blnEliminarTab = True Then
                Me.TabControl1.TabPages.Remove(Me.tbpMovimientos)
                Me.tcDatosInternos.TabPages.Remove(Me.tbpDatosComplement)
                Me.tcDatosInternos.TabPages.Remove(Me.tbpNombresAsoc)
                Me.tcDatosInternos.TabPages.Remove(Me.tbpFoto)
                Me.tcDatosInternos.TabPages.Remove(Me.tbpReniec)
                Me.tcDatosInternos.TabPages.Remove(Me.tbpAliasBandas)
                Me.tcDatosInternos.TabPages.Remove(Me.tbpBandas)
                Me.tcDatosInternos.TabPages.Remove(Me.tbpFamiliares)
                Me.tcDatosInternos.TabPages.Remove(Me.tbpOdontograma)
                Me.tcDatosInternos.TabPages.Remove(Me.tbpHuella)

                Me.pnlGrabarDatos.Visible = False
                Me.pnlEliminar.Visible = True
                Me.pnlReporte.Visible = False
                'Me.pnlUpdateDocJud.Visible = False, por validar xxx

                Me.cbbNroIngresos.Focus()

            End If

        End Sub
        Private Sub DataValidarReniec()

            If ValidarFichaReniec() = True Then

                Dim CodInterno As Integer = Me.idInterno
                If CodInterno < 1 Then Exit Sub

                Dim EntInternoRnc As New Entity.Registro.InternoReniec
                EntInternoRnc.InternoID = CodInterno

                Dim intInternoReniecID As Integer = (New Bussines.Registro.InternoReniec).InternoValidado(EntInternoRnc)

                If intInternoReniecID < 1 Then

                    UscValidacionReniecV21._VarHistorico = -1
                    UscValidacionReniecV21._Contador = intInternoReniecID
                    UscValidacionReniecV21._InternoID = CodInterno
                Else
                    UscValidacionReniecV21._VarHistorico = 0
                    UscValidacionReniecV21._Contador = intInternoReniecID
                    UscValidacionReniecV21._InternoID = CodInterno
                End If

            End If
        End Sub
        Private Sub DatosPersonalesVerificacionRnc()
            If Me.idInterno < 1 Then Exit Sub

            Dim obEntRnc As New Entity.Registro.InternoReniec
            obEntRnc.InternoID = Me.idInterno
            obEntRnc = (New Bussines.Registro.InternoReniec).ListarUltimaValidacion(obEntRnc)
            If obEntRnc Is Nothing Then
                txtApellidosNombresreniec.Text = ""
                Me.EstadoVerificacionRnc = "SIN VERIFICACION"
                Me.TipoVerificacionRnc = ""
                Me.txtFechaVerRnc.Text = ""
                Me.ObservRnc = ""
            Else
                With obEntRnc
                    If .Codigo > 0 And .TipoBusquedaID <> Type.Enumeracion.Reniec.EnmTipoResultado.No_Encontrado Then
                        '.Codigo
                        Dim Cadena As String = obEntRnc.ReniecData
                        Dim Objeto() As String = Cadena.Split("|")
                        txtApellidosNombresreniec.Text = Objeto(2) & " " & Objeto(3) & " " & Objeto(5)
                        Dim strNombreAsociadoVal As String = ""
                        If obEntRnc.NombreAsociadoVal_ID > 0 Then
                            strNombreAsociadoVal = " (" & obEntRnc.NombreAsociadoVal_Nom & ")"
                        End If
                        Me.EstadoVerificacionRnc = .TipoBusquedaNom
                        Me.TipoVerificacionRnc = .ComparacionNom & strNombreAsociadoVal
                        Me.FechaVerificacionRnc = .FechaHoraPM
                        Me.ObservRnc = .Observaciones
                    ElseIf .TipoBusquedaID = Type.Enumeracion.Reniec.EnmTipoResultado.No_Encontrado Then
                        txtApellidosNombresreniec.Text = ""
                        Me.EstadoVerificacionRnc = .TipoBusquedaNom
                        Me.TipoVerificacionRnc = .ComparacionNom
                        Me.FechaVerificacionRnc = .FechaHoraPM
                        Me.ObservRnc = .Observaciones
                    Else
                        txtApellidosNombresreniec.Text = ""
                        Me.EstadoVerificacionRnc = "SIN VERIFICACION"
                        Me.TipoVerificacionRnc = ""
                        Me.FechaVerificacionRnc = ""
                        Me.ObservRnc = ""
                    End If
                End With
            End If

        End Sub
#End Region
#Region "Listar"

        Private Sub ListarCabecera()

            If Me.idInterno < 1 Then
                Exit Sub
            End If

            objEntInt = (New Bussines.Registro.Interno).Listar_LM(Me.idInterno)
            If objEntInt Is Nothing Then Exit Sub
            Me.txtCodigo.Text = objEntInt.CodigoRP
            Me.txtInterno.Text = Me.InternoApeyNomHis(objEntInt.ApellidoPaterno, objEntInt.ApellidoMaterno, objEntInt.Nombres)
            Me.InternoEstado = objEntInt.EstadoID

            If objEntInt.EstadoID = 0 Or (objEntInt.EstadoID = 1 And objEntInt.EstadoBloqueoId = 1) Then
                Me.CabeceraEstado = "INACTIVO"
                Me._FormEscritura = False
                Me._FormEliminar = False
                Usuario_Permisos()

                ''grabar en la tabla interno penal
                'Dim objBssInternoPenal As New Bussines.Registro.InternoPenal
                'objBssInternoPenal.Grabar(objEntInt.SedeRowId, Me._IDInterno, Me._IDRegion, Me._IDPenal, 0) 'baja

            Else
                Me.CabeceraEstado = Bussines.Registro.Interno.EstadoNombre(Me.idInterno)
                Me._FormEscritura = Me._FormEscrituraOriginal
                Me._FormEliminar = Me._FormEliminarOriginal
            End If

            Me.txtRegionPenal.Text = objEntInt.RegionNombre & " - " & objEntInt.PenalNombre
            Me._IDInternoSedeRowId = objEntInt.SedeRowId
            Me.VersionRegistro = objEntInt.VersionRegistro

            Me.InternoApePaternoAux = objEntInt.ApellidoPaterno
            Me.InternoApeMaternoAux = objEntInt.ApellidoMaterno
            Me.InternoNombresAux = objEntInt.Nombres

            'If Me.PerfilUsuario = EnumDependencia.SistemasInformacion And Me.CabeceraEstado = "INACTIVO" Then
            '    pnlActivaInactivaInt.Visible = True
            '    Me.btnActInactivar.Text = "Activar"
            '    Me.btnActInactivar.BackColor = Color.Green
            'Else
            '    pnlActivaInactivaInt.Visible = False
            'End If
        End Sub

        Private Sub ListarDataInterno(objEnt As Entity.Registro.Interno, Optional ValidarIDInterno As Boolean = True)
            If ValidarIDInterno = True Then
                If Me.idInterno < 1 Then Exit Sub
            End If

            With objEnt
                '/*datos generales*/
                If ValidarIDInterno = True Then Me.CodigoRPInterno = .CodigoRP

                Me._IDInternoSedeRowId = .SedeRowId
                Me.Libro = .Libro
                Me.Folio = .Folio
                Me.InternoApePaterno = .ApellidoPaterno
                Me.InternoApeMaterno = .ApellidoMaterno
                Me.InternoNombres = .Nombres
                Me.Sexo = .SexoID
                Me.CentroReclusionMenorId = .CentroReclusionMenorId
                Me.InternoFechaNac = .FechaNacimiento
                Me.TipoDocumento = .TipoDocumentoID
                If Me.TipoDocumento <= 0 Then
                    Me.Noindica = True
                    Me.cbbTipoDoc.Enabled = False
                    Me.txtNumDoc.Enabled = False
                End If
                Me.NumeroDocumento = .NumeroDocumento
                Me.NumeroDocumentoAux = .NumeroDocumento
                Me.Obs_DNI = .Obs_DNI
                Me.EstadoCivil = .EstadoCivilID
                Me.IDNacionalidad = .NacionalidadID
                Me.Discapacidad = .Discapacidad
                If .Decadactilar.Length > 2 And .Decadactilar.Contains("|") = True Then
                    Dim d() As String = .Decadactilar.Split("|")
                    Me.DecadactilarIzq = d(0)
                    Me.DecadactilarDer = d(1)
                End If
                '/*ubigeo nacimiento*/
                Me.Pais = .NacimientoPaisID
                Me.UbigeoNacimiento = .NacimientoUbigeoID
                Me.UbigeoNacimientoOtros = .NacimientoOtros
                '/*ubigeo domicilio*/
                Me.UbigeoDomicilio = .DomicilioUbigeoID
                Me.Domicilio = .Domicilio
                '/*datos academicos*/
                Me.NivelAcademcico = .NivelAcademicoID
                Me.Profesion = .ProfesionID
                Me.Ocupacion = .OcupacionID
                '/*comunidad*/
                Me.ComunidadAndina = .ComunidadAndinaID
                Me.ComunidadAndinaEspecifica = .ComunidadAndinaEspID
                '/**/                
                Me.PabellonID = .PabellonID
                Me.Pabellon = .PabellonNombre
                Me.Obs = .Obs

                '/*datos complementarios*/
                Me.InternoApePaternoAux = Me.InternoApePaterno
                Me.InternoApeMaternoAux = Me.InternoApeMaterno
                Me.InternoNombresAux = Me.InternoNombres
                Me.chk_Homonimia.Checked = IIf(.Homonimia = True, True, False)
                Me.chk_Homonimia.Enabled = False
                Me._IdiomaNativoId = .IdiomaNativoId
                Me.GeneroPersonaId = .GeneroId
                Me.txtCentroTrabajo.Text = .CentroTrabajo
                'Me.CodigoUnicoInterno = .CodigoUnicoInterno
                Me.NombreClaveInterno = .NombreClaveInterno
                Me.ReligionId = .ReligionId
                Me.CodigoFuerzaArmadaId = .CodigoFuerzaArmadaId
                Me.CodigoRangoId = .CodigoRangoId

                '/*region y penal*/
                If ValidarIDInterno = True Then
                    Me.idRegion = .RegionID
                    Me.regionNombre = .RegionNombre
                    Me.idPenal = .PenalID
                    Me.penalNombre = .PenalNombre
                End If
            End With



        End Sub

        Private Sub ListarData(Optional ByRef blnCerrarForm As Boolean = False)

            If Me.idInterno < 1 Then
                Me.txtRegionPenal.Text = Me.RegionPenalNombre
                Exit Sub
            End If

            objBssHistorico = New Bussines.Registro.InternoHistorico
            Dim objEnInternoHisto As New Entity.Registro.InternoHistorico
            objBssInterno = New Bussines.Registro.Interno

            If Me.IDIngreso > 0 Then

                Dim objEnInternoFiltroHisto As New Entity.Registro.InternoHistorico
                With objEnInternoFiltroHisto
                    .InternoID = Me.idInterno
                    .IngresoInpeId = Me.IDIngresoINPE
                End With
                objEnInternoHisto = objBssHistorico.Listar_LM(objEnInternoFiltroHisto)

                If objEnInternoHisto Is Nothing Then
                    Dim objEntInterno As New Entity.Registro.Interno

                    Me.IDInternoHistorico = -1
                    objEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me.idInterno)
                    ListarDataInterno(objEntInterno)
                    Me.UscAuditUser1.LoadAudit(Me.idInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                Else

                    If objEnInternoHisto.Codigo < 1 Then
                        Dim objEntInterno As New Entity.Registro.Interno

                        objEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me.idInterno)
                        ListarDataInterno(objEntInterno)
                        Me.UscAuditUser1.LoadAudit(Me.idInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                    Else
                        ListarInternoHistorico(objEnInternoHisto)
                        Me.UscAuditUser1.LoadAudit(objEnInternoHisto.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoHistorico)
                    End If

                End If

            Else

                'listar los datos del interno 
                Dim objEntInterno As New Entity.Registro.Interno

                objEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me.idInterno)
                If objEntInterno Is Nothing Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha encontrado al Interno o posiblemente haya sido eliminado.")
                    blnCerrarForm = True
                    Me.Close()
                    Exit Sub
                Else
                    ListarDataInterno(objEntInterno)
                    Me.UscAuditUser1.LoadAudit(Me.idInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                End If
            End If

            chk_Homonimia.Enabled = False

            EnabledControles(True)

            UscGradosAcademicos1._PenalId = Me.idPenal
            UscGradosAcademicos1._RegionId = Me.idRegion
            UscGradosAcademicos1._IngresoId = Me.IDIngreso

            UscIdiomaInterno1._PenalId = Me.idPenal
            UscIdiomaInterno1._RegionId = Me.idRegion
            UscIdiomaInterno1._IngresoId = Me.IDIngreso

            Me.UscDomicilio1._IngresoId = Me.IDIngreso
            Me.UscDomicilio1._IngresoNroLetra = cbbNroIngresos.Text
            Me.UscDomicilio1._LoadUsc()

            DatosPersonalesVerificacionRnc()

        End Sub

        Private Sub ListarInternoHistorico(objEnt As Entity.Registro.InternoHistorico)
            If Me.idInterno < 1 Or Me.IDIngreso < 1 Then Exit Sub

            With objEnt
                '/*datos generales*/
                Me.IDInternoHistorico = .Codigo
                Me.CodigoRPInterno = .CodigoRP
                Me.Libro = .Libro
                Me.Folio = .Folio
                Me.InternoApePaterno = .ApellidoPaterno
                Me.InternoApeMaterno = .ApellidoMaterno
                Me.InternoNombres = .Nombres
                Me.Sexo = .SexoID
                Me.CentroReclusionMenorId = .CentroReclusionMenorId
                Me.InternoFechaNac = .FechaNacimiento
                Me.TipoDocumento = .TipoDocumentoID
                If .TipoDocumentoID < 1 Then
                    Me.Noindica = True
                    Me.cbbTipoDoc.Enabled = False
                    Me.txtNumDoc.Enabled = False
                End If
                Me.NumeroDocumento = .NumeroDocumento
                Me.NumeroDocumentoAux = .NumeroDocumento
                Me.Obs_DNI = .Obs_DNI
                Me.EstadoCivil = .EstadoCivilID
                Me.IDNacionalidad = .NacionalidadID
                Me.Discapacidad = .Discapacidad
                If .Decadactilar.Length > 2 And .Decadactilar.Contains("|") = True Then
                    Dim d() As String = .Decadactilar.Split("|")
                    Me.DecadactilarIzq = d(0)
                    Me.DecadactilarDer = d(1)
                End If
                Me.chk_Homonimia.Checked = .Homonimia
                '/*ubigeo nacimiento*/
                Me.Pais = .NacimientoPaisID
                Me.UbigeoNacimiento = .NacimientoUbigeoID
                Me.UbigeoNacimientoOtros = .NacimientoOtros
                '/*ubigeo domicilio*/
                Me.UbigeoDomicilio = .DomicilioUbigeoID
                Me.Domicilio = .Domicilio
                '/*datos academicos*/
                Me.NivelAcademcico = .NivelAcademicoID
                Me.Profesion = .ProfesionID
                Me.Ocupacion = .OcupacionID
                '/*comunidad*/
                Me.ComunidadAndina = .ComunidadAndinaID
                Me.ComunidadAndinaEspecifica = .ComunidadAndinaEspID
                '/**/                
                Me.PabellonID = .PabellonID
                Me.Pabellon = .PabellonNombre
                Me.Obs = .Obs
                '/*region y penal*/
                Me.idRegion = .RegionID
                Me.regionNombre = .RegionNombre
                Me.idPenal = .PenalID
                Me.penalNombre = .PenalNombre
                Me.InternoApePaternoAux = .ApellidoPaterno
                Me.InternoApeMaternoAux = .ApellidoMaterno
                Me.InternoNombresAux = .Nombres
                Me.UscAuditUser1.LoadAudit(Me.idInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                Me.txtCentroTrabajo.Text = .CentroTrabajo
                Me._IdiomaNativoId = .IdiomaNativoId
                Me.GeneroPersonaId = .GeneroId
                'Me.CodigoUnicoInterno = .CodigoUnicoInterno
                Me.NombreClaveInterno = .NombreClaveInterno
                Me.ReligionId = .ReligionId
                Me.CodigoFuerzaArmadaId = .CodigoFuerzaArmadaId
                Me.CodigoRangoId = .CodigoRangoId
            End With
        End Sub

        Private Sub ListarDatosComplementarios()
            If Me.idInterno < 1 Then
                Me.txtRegionPenal.Text = Me.RegionPenalNombre
                Exit Sub
            End If

            With UscIdiomaInterno1
                ._InternoId = Me.idInterno
                ._IngresoInpeID = Me.IDIngresoINPE
                ._IngresoId = Me.IDIngreso
                ._RegionId = Me.idRegion
                ._PenalId = Me.idPenal
                ._IngresoNroLetra = cbbNroIngresos.Text
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._LoadUsc()
            End With

            With UscGradosAcademicos1
                ._PenalId = Me.idPenal
                ._RegionId = Me.idRegion
                ._IngresoInpeID = Me.IDIngresoINPE
                ._IngresoId = Me.IDIngreso
                ._InternoId = Me.idInterno
                ._IngresoNroLetra = cbbNroIngresos.Text
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._LoadUsc()
            End With

            With UscDomicilio1
                ._PenalId = Me.idPenal
                ._RegionId = Me.idRegion
                ._IngresoInpeID = Me.IDIngresoINPE
                ._IngresoId = Me.IDIngreso
                ._InternoId = Me.idInterno
                ._IngresoNroLetra = cbbNroIngresos.Text
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._LoadUsc()
            End With

            listarUscPoblacionLenguaMaterna(blnModificarDatos)

            EnabledControles(True)

        End Sub

        Public Sub LoadUscNombresAsociados()

            With UscGrillaNombresAsociadosV21
                ._InternoID = Me.idInterno
                ._IngresoID = Me.IDIngreso
                ._IngresoInpeID = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._Documentos_sin_mov = True
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._LoadUsc()
            End With
        End Sub

        Private Sub LoadUscFotografia()

            With uscFotoPerfiles
                ._InternoID = Me.idInterno
                ._InternoCodigoRP = Me.CodigoRPInterno
                .RegionID = Me.idRegion
                .PenalID = Me.idPenal
                .InternoFotoID = -1
                '._InternoIngresoId = Me.IDIngreso
                ._IngresoInpeID = Me.IDIngresoINPE
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                .LoadUsc()
                uscFotoPerfiles.DataGrieView_Click()
            End With

        End Sub

        Private Sub LoadUscListarAlias()

            With UscAlias21
                .InternoID = Me.idInterno
                .IngresoID = Me.IDIngreso
                .IngresoInpeID = Me.IDIngresoINPE
                .PenalID = Me.idPenal
                .RegionID = Me.idRegion
                .TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                ._Load()
            End With
        End Sub

        Private Sub LoadUscListarBandas()

            With UscBandas21
                .InternoID = Me.idInterno
                .IngresoInpeID = Me.IDIngresoINPE
                '.IngresoId = Me.IDIngreso
                .PenalID = Me.idPenal
                .RegionID = Me.idRegion
                .TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                ._Load()
            End With
        End Sub

        Private Sub LoadUscOrganizacionCriminal()

            If Me.idInterno < 1 Then Exit Sub

            With UscOrganizacionCriminal
                ._InternoID = Me.idInterno
                ._IngresoInpeID = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._LoadUsc()
            End With
        End Sub

        Private Sub ListarFamilia()

            With UscFamilias1
                ._IDInterno = Me.idInterno
                ._IDIngreso = Me.IDIngreso
                ._IngresoInpeID = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._LoadUsc()
            End With

        End Sub

        Private Sub LoadUscOdontograma()
            UscOdotoNew1.Height = UscOdont.Height
            UscOdotoNew1.Width = UscOdont.Width + 100
            If Me.idInterno < 1 Then Exit Sub
            UscOdont.Visible = False
            With UscOdont
                ._VisibleEliminar = False
                ._VisibleGrabar = False
                ._InternoId = Me.idInterno
                '._InternoIngresoID = Me.IDIngreso
                ._IngresoInpeID = Me.IDIngresoINPE
                ._RegionId = Me.idRegion
                ._PenalId = Me.idPenal
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._LoadUsc()
            End With
            UscOdotoNew1.Visible = True


            Dim nc As Integer = 0
            Using DB As New DataContextDataContext(Legolas.Configuration.Data.ConexionIni)
                If (From p In DB.int_mov_interno_odontograma_nts Where p.fk_int_id = Me.idInterno Where p._flg_eli = False Select p).Count > 0 Then

                    Dim obj As int_mov_interno_odontograma_nts = (From p In DB.int_mov_interno_odontograma_nts Where p.fk_int_id = Me.idInterno Where p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).First
                    UscOdotoNew1.Odonto_nts = obj
                    UscOdotoNew1.carga_datos()
                Else
                    UscOdotoNew1.Odonto_nts = New int_mov_interno_odontograma_nts
                    UscOdotoNew1.carga_datos()
                End If
                UscOdotoNew1.CodInterno = Me.txtCodInterno.Text.Trim
                UscOdotoNew1.NomInterno = InternoApePaterno + " " + InternoApeMaterno + " " + InternoNombres
                UscOdotoNew1.InternoId = Me.idInterno
                UscOdotoNew1.CodIngreso = Me.IDIngreso
                UscOdotoNew1.CodIngresoInpe = Me.IDIngresoINPE
                UscOdotoNew1.PenalId = Me.idPenal
                UscOdotoNew1.RegionId = Me.idRegion
                'UscOdotoNew1.SoloLectura = Not Me._FormEscritura
                UscOdotoNew1.SoloLectura = True
                UscOdotoNew1.carga_lista()
            End Using

            btnsiguiente.Enabled = False
            btnanterior.Enabled = True
        End Sub

        Private Sub LoadUscDocumentoDigitalizado()

            'If Me._IDInterno < 1 Then Exit Sub

            'With UscVisorDocDigital1
            '    ._InternoID = Me._IDInterno
            '    ._IngresoID = Me.IDIngreso
            '    ._IngresoInpeID = Me.IDIngresoINPE
            '    ._RegionID = Me.RegionID
            '    ._PenalID = Me.PenalID
            '    ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
            '    ._LoadUsc()
            'End With

        End Sub



        Private Sub LoadUscHuellas()

            If Me.idInterno < 1 Then Exit Sub

            With UscVisorDetalleHuellas1
                ._InternoId = Me.idInterno
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._RegId = Me.idRegion
                ._PenId = Me.idPenal
                ._TipDocIdentId = Me.TipoDocumento
                ._NumDocIdent = Me.NumeroDocumento
                ._CodRP = Me.CodigoRPInterno
                ._ApePat = Me.InternoApePaterno
                ._ApeMat = Me.InternoApeMaterno
                ._Nombres = Me.InternoNombres
                .loadUsc()
            End With

        End Sub

        Private Sub Listar_Expedientes()

            If Me.IDIngresoINPE < 1 Or Me.idInterno < 1 Then Exit Sub

            With Me.UscMandatoDetencion
                ._InternoID = Me.idInterno
                ._InternoEstado = Me.InternoEstado
                .RegionID = Me.idRegion
                .PenalID = Me.idPenal
                ._IDIngresoINPE = Me.IDIngresoINPE
                '._IngresoID = Me.IDIngreso
                ._VisibleAnulacion = True
                ._VisiblePadin = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._LoadUsc()
            End With

        End Sub
        Private Sub LoadUscClasificaciones()
            'If Me._IDInterno < 1 Then Exit Sub
            'With UscClasificaciones1
            '    ._InternoID = Me._IDInterno
            '    Select Case Me.Sexo
            '        Case 1
            '            ._Sexo = "MASCULINO"
            '        Case 2
            '            ._Sexo = "FEMENINO"
            '        Case Else
            '            ._Sexo = ""
            '    End Select
            '    If Me.IDNacionalidad = 141 Then
            '        ._Nacionalidad = "PERUANO"
            '    ElseIf Me.IDNacionalidad > 0 Then
            '        ._Nacionalidad = "EXTRANJERO"
            '    Else
            '        ._Nacionalidad = ""
            '    End If
            '    ._IngresoInpeId = Me.IDIngresoINPE
            '    ._RegionID = Me._IDRegion
            '    ._PenalID = Me._IDPenal
            '    If Me.CabeceraEstado = "INACTIVO" Then
            '        ._EstadoInterno = 0
            '    Else
            '        ._EstadoInterno = 1
            '    End If
            '    ._NumDocIdentStr = txtNumDoc.Text
            '    ._TipoDocIdentStr = cbbTipoDoc.Text
            '    ._GrupoFichaId = Type.Enumeracion.Clasificacion.enmGrupoClasificacion.ClasificacionEtapa
            '    .LoadUsc()
            'End With
            'With UscClasificaciones2
            '    ._InternoID = Me._IDInterno
            '    Select Case Me.Sexo
            '        Case 1
            '            ._Sexo = "MASCULINO"
            '        Case 2
            '            ._Sexo = "FEMENINO"
            '        Case Else
            '            ._Sexo = ""
            '    End Select
            '    If Me.IDNacionalidad = 141 Then
            '        ._Nacionalidad = "PERUANO"
            '    ElseIf Me.IDNacionalidad > 0 Then
            '        ._Nacionalidad = "EXTRANJERO"
            '    Else
            '        ._Nacionalidad = ""
            '    End If
            '    ._IngresoInpeId = Me.IDIngresoINPE
            '    ._RegionID = Me._IDRegion
            '    ._PenalID = Me._IDPenal
            '    If Me.CabeceraEstado = "INACTIVO" Then
            '        ._EstadoInterno = 0
            '    Else
            '        ._EstadoInterno = 1
            '    End If
            '    ._NumDocIdentStr = txtNumDoc.Text
            '    ._TipoDocIdentStr = cbbTipoDoc.Text
            '    ._GrupoFichaId = Type.Enumeracion.Clasificacion.enmGrupoClasificacion.ClasificacionPenales  ' Solo para pabellones penales
            'End With
        End Sub

        Public Sub ListarResoluciones()
            If Me.IDIngresoINPE < 1 Or Me.idInterno < 1 Then Exit Sub
            With Me.UscResolucionesMain1
                ._Codigo = -1
                ._InternoID = Me.idInterno
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._IngresoInpeID = Me.IDIngresoINPE
                ' ._NroIngresoID = Me.IDIngreso
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                .LoadUsc()
            End With

        End Sub

        Private Sub ListarMovimientosIngreso()
            If Me.IDIngreso < 1 Or Me.idInterno < 1 Then Exit Sub
            With Me.UscMovimiento1
                ._InternoID = Me.idInterno
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._IngresoInpeID = Me.IDIngresoINPE
                ._NroIngresoID = Me.IDIngreso
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                .LoadUsc()
            End With
        End Sub

        Private Sub listarUscPoblacionLenguaMaterna(editar As Boolean)

            With UscEtniaLenguaMaterna_v21
                ._load(Me.idInterno, Me.idRegion, Me.idPenal)
            End With

        End Sub
        Private Sub listarGrillaConstanciaReclusion()

            With UscInternoDetalle1
                ._visibleBotones = True
                ._loadUsc(Configuracion.Licencia.Codigo,
                          Me.idInterno, Me.IDIngresoINPE, -1, Me.idRegion, Me.idPenal, Me.CodigoRPInterno, Me.InternoApeyNom, Me.regionNombre, Me.penalNombre)
            End With

        End Sub
        Private Function CopiarPropiedades(ObjEntInternoHis As Entity.Registro.InternoHistorico, ObjEntInt As Entity.Registro.Interno) As Entity.Registro.InternoHistorico
            With ObjEntInternoHis
                .InternoID = ObjEntInt.Codigo
                .TipoDocumentoID = 1
                .CodigoRP = ObjEntInt.CodigoRP
                .Libro = ObjEntInt.Libro
                .Folio = ObjEntInt.Folio
                .ApellidoPaterno = ObjEntInt.ApellidoPaterno
                .ApellidoMaterno = ObjEntInt.ApellidoMaterno
                .Nombres = ObjEntInt.Nombres
                .SexoID = ObjEntInt.SexoID
                .CentroReclusionMenorId = ObjEntInt.CentroReclusionMenorId
                .FechaNacimiento = ObjEntInt.FechaNacimiento
                .NacimientoPaisID = ObjEntInt.NacimientoPaisID
                .NacimientoUbigeoID = ObjEntInt.NacimientoUbigeoID
                .NacimientoOtros = ObjEntInt.NacimientoOtros
                .NacionalidadID = ObjEntInt.NacionalidadID
                .TipoDocumentoID = ObjEntInt.TipoDocumentoID
                .NumeroDocumento = ObjEntInt.NumeroDocumento
                .DomicilioUbigeoID = ObjEntInt.DomicilioUbigeoID
                .Domicilio = ObjEntInt.Domicilio
                .EstadoCivilID = ObjEntInt.EstadoCivilID
                .NivelAcademicoID = ObjEntInt.NivelAcademicoID
                .NumeroHijos = ObjEntInt.NumeroHijos
                .ProfesionID = ObjEntInt.ProfesionID
                .OcupacionID = ObjEntInt.OcupacionID
                .EstadoID = -1
                .Discapacidad = ObjEntInt.Discapacidad
                .ComunidadAndinaID = ObjEntInt.ComunidadAndinaID
                .ComunidadAndinaEspID = ObjEntInt.ComunidadAndinaEspID
                .RegionID = ObjEntInt.RegionID
                .PenalID = ObjEntInt.PenalID
                .Obs = ObjEntInt.Obs
                .Obs_DNI = ObjEntInt.Obs_DNI
                .PabellonID = ObjEntInt.PabellonID
                .PabellonNombre = ObjEntInt.PabellonNombre
                .Decadactilar = ObjEntInt.Decadactilar
            End With
            Return ObjEntInternoHis
        End Function

        Private Sub Listar_ReniecHistorico()

            Dim EntInternoRnc As New Entity.Registro.InternoReniec
            EntInternoRnc.InternoID = Me.idInterno
            Dim ListaValidados As Integer = (New Bussines.Registro.InternoReniec).InternoValidado(EntInternoRnc)

            If ListaValidados > 0 Then
                UscValidacionReniecV21._Contador = ListaValidados
                UscValidacionReniecV21._VarHistorico = 0
                UscValidacionReniecV21._InternoID = Me.idInterno
            End If

        End Sub

#Region "Ubigeo"
        Private Sub ListarUbigeoNacimiento(ByVal Codigo As Integer)

            Dim objEnt As New Entity.General.Ubigeo
            Dim objEntCol As New Entity.General.UbigeoCol
            objEntCol = (New Bussines.General.Ubigeo).Listar("lst_mant", Codigo, -1, -1, -1, -1, "")
            If objEntCol Is Nothing Then Exit Sub
            If objEntCol.Count > 0 Then
                objEnt = objEntCol.Ubigeo(0)
                With objEnt
                    Me.Departamento = .Departamento
                    Me.Provincia = .Provincia
                    Me.Distrito = .Distrito
                End With
            End If

        End Sub
        Private Sub ListarUbigeoDomicilio(ByVal Codigo As Integer)

            Dim objEnt As New Entity.General.Ubigeo
            Dim objEntCol As New Entity.General.UbigeoCol
            objEntCol = (New Bussines.General.Ubigeo).Listar("lst_mant", Codigo, -1, -1, -1, -1, "")
            If objEntCol Is Nothing Then Exit Sub
            If objEntCol.Count > 0 Then
                objEnt = objEntCol.Ubigeo(0)
                With objEnt
                    Me.DomicilioDepartamento = .Departamento
                    Me.DomicilioProvincia = .Provincia
                    Me.DomicilioDistrito = .Distrito
                End With
            End If

        End Sub
#End Region
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True
            Dim strMensajeOut As String = ""
            objBssInterno = New Bussines.Registro.Interno

            'validacion de apellidos y nombres, de acuerdo al req de dic-2019
            If objBssInterno.ValidarApellidosyNombres(Me.InternoApePaterno, Me.InternoApeMaterno, Me.InternoNombres, strMensajeOut) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                Me.txtApePat.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*sexo*/
            If Me.Sexo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el sexo del interno")
                Me.cbbSexo.Focus()
                Return False
            End If
            '/*fecha nacimiento*/
            If Me.InternoFechaNac < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha de nacimiento del Interno")
                Me.dtpFechaNac.Focus()
                Return False
            End If
            If Me.InternoFechaNac < 1 Then
                If chk_Obs_DNI.Checked = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Si marco el check [<18 Años], debe ingresar un menor de Edad, con la justificación que lo motiva")
                    Me.dtpFechaNac.Focus()
                    Return False
                End If
            Else
                '/*fecha nacimiento>18  */
                Dim intAnios As Integer = 0
                intAnios = Legolas.Components.FechaHora.FechaCalcularAnio(Me.dtpFechaNac.ValueLong,
                                                                          Legolas.Configuration.Aplication.FechayHora.FechaLong, True)
                Dim dteFechaNac As Date = Me.dtpFechaNac.Value
                Dim dteFechaMay18 As Date = DateAdd(DateInterval.Year, -18, Now)

                If chk_Obs_DNI.Checked = False Then
                    If intAnios < 18 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "La edad del interno corresponde a un menor de Edad, en caso requiera ingresar un menor de Edad," + Chr(13) +
                        "active el check [<18 Años] e ingrese una justificación")
                        Me.dtpFechaNac.Focus()
                        Return False
                    End If
                Else
                    If intAnios > 17 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "La edad del interno pertenece aun mayor de edad," + Chr(13) + "debe tener una fecha de nacimiento menor a la fecha actual")
                        Me.dtpFechaNac.Focus()
                        Return False
                    End If
                    If txtObs_dni.Text = "" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                          "La edad del interno es la de un menor de edad," + Chr(13) + "debe ingresar la justificación que la motiva.")
                        Me.txtObs_dni.Focus()
                        Return False
                    End If

                End If
            End If
            If Me.TipoDocumento > 0 And Me.NumeroDocumento <> "" Then
                objBssInterno = New Bussines.Registro.Interno
                Dim objEnti As New Entity.Registro.Interno
                With objEnti
                    .Codigo = Me.idInterno
                    .TipoDocumentoID = Me.TipoDocumento
                    .NumeroDocumento = Me.NumeroDocumento
                    .NumeroDocumentoAux = Me.NumeroDocumentoAux
                    .RegionID = Me.idRegion
                    .PenalID = Me.idPenal
                End With
                If Me.idInterno > 0 Then
                    If Me.NumeroDocumento = Me.NumeroDocumentoAux Then
                    Else
                        If objBssInterno.ValidarNumeroDocumento(objEnti) = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(
                             "El 'Tipo de documento' y 'Numero de documento'" + Chr(13) + "pertenece a otro interno")
                            txtNumDoc.Focus()
                            Return False
                        End If
                    End If
                Else
                    If objBssInterno.ValidarNumeroDocumento(objEnti) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                         "El 'Tipo de documento' y 'Numero de documento'" + Chr(13) + "pertenece a otro interno")
                        txtNumDoc.Focus()
                        Return False
                    End If
                End If
            ElseIf Me.TipoDocumento < 1 And Me.NumeroDocumento <> "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Número de documento ha sido llenado, seleccione un tipo de documento")
                cbbTipoDoc.Focus()
                Return False
            End If
            '---------Validar Homonimia--------------
            Dim objEnt As New Entity.Registro.Interno
            Dim strMensaje As String = ""
            Dim blnHomonimia As Boolean = False
            With objEnt
                .Codigo = Me.idInterno
                .ApellidoPaterno = Me.InternoApePaterno
                .ApellidoMaterno = Me.InternoApeMaterno
                .Nombres = Me.InternoNombres
                .RegionID = Me.idRegion
                .PenalID = Me.idPenal
                If chk_Homonimia.Checked = True Then
                Else
                    If Me.idInterno < 1 Then
                        If objBssInterno.ValidarApellidosyNombres(objEnt) = 0 Then
                            blnHomonimia = False
                        Else
                            blnHomonimia = True
                        End If
                        If blnHomonimia = True And chk_Homonimia.Checked = False Then

                            strMensaje = "Los apellidos y nombres consignados, ya se encuentran en la base de datos." + Chr(13) +
                           "Si desea grabar, active el campo 'Homonimia', y hacer click en el boton 'Grabar'"
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                            Me.chk_Homonimia.Focus()
                            Return False
                        ElseIf blnHomonimia = False And chk_Homonimia.Checked = True Then
                            strMensaje = "Los apellidos y nombres consignados, no tienen campos de 'Homonimia'." + Chr(13) +
                                               "Si desea grabar, desactive el campo 'Homonimia', y hacer click en el boton [Grabar]"
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                            Me.chk_Homonimia.Focus()
                            Return False
                        End If
                    Else
                        If Me.InternoApePaterno = Me.InternoApePaternoAux And Me.InternoApeMaterno = Me.InternoApeMaternoAux And Me.InternoNombres = Me.InternoNombresAux Then
                            Dim valor As Integer = objBssInterno.ValidarApellidosyNombresUpd(objEnt)
                            If valor > 0 Then
                                strMensaje = "Los apellidos y nombres consignados, ya se encuentran en la base de datos." + Chr(13) +
                                  "Si desea grabar, active el campo [Homonimia], y hacer click en el boton [Grabar]"
                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                                Me.chk_Homonimia.Focus()
                                Return False
                            Else
                                blnValue = True
                            End If
                        Else
                            If objBssInterno.ValidarApellidosyNombres(objEnt) = 0 Then
                                blnValue = True
                            Else
                                strMensaje = "Los apellidos y nombres consignados, ya se encuentran en la base de datos." + Chr(13) +
                                "Si desea grabar, active el campo [Homonimia], y hacer click en el boton [Grabar]"
                                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                                Me.chk_Homonimia.Focus()
                                Return False
                            End If
                        End If
                    End If
                End If
            End With

            Return blnValue
        End Function
        Private Sub AGrabar()

            Select Case Me.tcDatosInternos.SelectedTab.Name
                Case Me.tbpDatos.Name, Me.tbpDatosComplement.Name
                    If btnGrabar.Text = "Modificar" Then
                        If ValidarEstadoIngreso() = False Then
                            Legolas.Configuration.Aplication.MessageBox.Information("No se puede realizar ninguna operacion" + Chr(13) +
                                                                                    "El interno en este ingreso, no esta en el penal.")
                            Exit Sub
                        End If
                        EnabledControles(False)

                        Me.btnGrabar.Image = My.Resources.Drive___USB_32
                        Me.btnGrabar.Text = "&Grabar"

                        Me.btnIngreso.Image = My.Resources.anular2
                        Me.btnIngreso.Text = "Cancelar"
                        Exit Sub
                    End If

                    If Validar() = True Then
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                            AGrabarInterno()
                            EnabledControles(True)
                        End If
                    End If
            End Select

        End Sub
        Private Sub AGrabarInterno()

            Dim intValue As Integer = -1

            Me.InternoApePaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.InternoApePaterno)
            Me.InternoApeMaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.InternoApeMaterno)
            Me.InternoNombres = Legolas.Components.Cadena.LimpiarEspacios(Me.InternoNombres)

            Dim obEntInterno As New Entity.Registro.Interno

            If Me.idInterno > 0 Then
                obEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me.idInterno)
            End If
            With obEntInterno
                .Codigo = Me.idInterno
                .CodigoRP = Me.CodigoRPInterno
                .CentroReclusionMenorId = Me.CentroReclusionMenorId
                .Libro = Me.Libro
                .Folio = Me.Folio
                .ApellidoPaterno = Me.InternoApePaterno
                .ApellidoMaterno = Me.InternoApeMaterno
                .Nombres = Me.InternoNombres
                .SexoID = Me.Sexo
                .FechaNacimiento = Me.InternoFechaNac
                .NacimientoPaisID = Me.Pais
                .NacimientoUbigeoID = Me.UbigeoNacimiento
                .NacimientoOtros = UbigeoNacimientoOtros
                .NacionalidadID = Me.IDNacionalidad
                .TipoDocumentoID = Me.TipoDocumento
                .NumeroDocumento = Me.NumeroDocumento
                .DomicilioUbigeoID = Me.UbigeoDomicilio
                .Domicilio = Me.Domicilio
                .EstadoCivilID = Me.EstadoCivil
                .NivelAcademicoID = Me.NivelAcademcico
                .ProfesionID = Me.Profesion
                .OcupacionID = Me.Ocupacion
                .EstadoID = -1
                .Discapacidad = Me.Discapacidad
                .ComunidadAndinaID = Me.ComunidadAndina
                .ComunidadAndinaEspID = Me.ComunidadAndinaEspecifica
                .RegionID = Me.idRegion
                .PenalID = Me.idPenal
                .Obs = Me.Obs
                .Obs_DNI = Me.Obs_DNI
                .PabellonID = Me.PabellonID
                .PabellonNombre = Pabellon
                .Decadactilar = Me.DecadactilarIzq & "|" & Me.DecadactilarDer
                .Homonimia = Me.chk_Homonimia.Checked
                .GeneroId = Me.GeneroPersonaId
                .ReligionId = Me.ReligionId
                .CentroTrabajo = Me.txtCentroTrabajo.Text
                .CodigoFuerzaArmadaId = Me.CodigoFuerzaArmadaId
                .CodigoRangoId = Me.CodigoRangoId
                .IdiomaNativoId = Me._IdiomaNativoId
                .NombreClaveInterno = Me.NombreClaveInterno
                .VersionRegistro = "V6_LM"
            End With

            If Me.IDIngreso > 0 Then
                'grabar interno historico
                objBssHistorico = New Bussines.Registro.InternoHistorico
                Dim ValorHis As Integer = objBssHistorico.Grabar_Interno_v2_LM(Me.IDInternoHistorico, Me.IDIngresoINPE, Me.IDIngreso, obEntInterno)
                Me.UscAuditUser1.LoadAudit(Me.IDInternoHistorico, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoHistorico)
                If Me.IDInternoHistorico = -1 Then Me.IDInternoHistorico = ValorHis
                intValue = obEntInterno.Codigo
            Else
                'grabar datos del interno
                Dim blnaux As Boolean = False
                Dim outSms As String = ""

                If Me.idInterno < 1 Then blnaux = True

                intValue = (New Bussines.Registro.Interno).Grabar_PLM(obEntInterno, outSms)

                If intValue = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(outSms)
                End If

                If intValue > 0 Then
                    Me.idInterno = intValue
                    If blnaux = True Then Me.NumeroDocumentoAux = Me.NumeroDocumento

                    Me.UscAuditUser1.LoadAudit(Me.idInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                End If
            End If

            If intValue > 0 Then

                'grabar en la tabla poblacion penal
                Dim objBssInternoPenal As New Bussines.Registro.InternoPenal
                objBssInternoPenal.Grabar(-1, Me.idInterno, Me.idRegion, Me.idPenal, Me.InternoEstado) 'alta

                ListarCabecera()

                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

                EnabledControles(True)
                btnGrabar.Image = My.Resources._1277961326_folder_edit
                btnGrabar.Text = "Modificar"
                btnIngreso.Image = My.Resources._1277961158_folder_new
                btnIngreso.Text = "Nuevo" + Chr(13) + "Ingreso"

            End If
        End Sub
        Private Sub AEliminarInterno()

            Dim strMensaje As String = "Desea eliminar el registro del interno. Se validará si existen registros que dependen del interno en la Base de Datos del E.P. y la Base de Sede Central."

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de eliminar el registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            strMensaje = "No se puede eliminar el Interno." + Chr(13) +
                         "Porque cuenta con : "

            Dim objEntMov As New Entity.Registro.InternoMovimiento
            objEntMov.InternoID = Me.idInterno
            If ((New Bussines.Registro.InternoMovimiento).ListarGrilla_LM(objEntMov).Count) > 0 Then
                strMensaje = strMensaje + " Movimientos activos."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If

            If (New Bussines.Registro.DocumentoJudicial).CantidadDocumentosExpedientes(Me.idInterno, Me.idPenal) > 0 Then
                strMensaje = strMensaje + " Documentos Judiciales o procesos (expedientes) activos"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If

            If ((New Bussines.Registro.IngresoInpe).ValidarCantidadIngresosRegistradosXORL(Me.idInterno)) > 0 Then
                strMensaje = strMensaje & "Ingresos activos registrados por la SDRP-ORL"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If

            'validar en la base de datos central
            'uso de la ws
            Dim strMensajeOut As String = ""
            Dim blnTieneRegistros As Boolean = False
            If Me._IDInternoSedeRowId > 0 Then
                Dim objWS As New APPWebService.InpeSedeInterno
                blnTieneRegistros = objWS.ValidarSiTieneRegistros(Me._IDInternoSedeRowId, strMensajeOut)
            End If

            If blnTieneRegistros = True Then
                strMensaje = strMensaje & strMensajeOut & Chr(13) & "Coordine con la SDRP-ORL"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If

            strMensaje = "Esta seguro de eliminar definitivamente el registro del interno de su penal."
            strMensaje = strMensaje & " Al realizar esta operacion el registro del interno NO Pasara al estado inactivo."
            strMensaje = strMensaje & Chr(13)
            strMensaje = strMensaje & "" + Chr(13) +
                  "Esta accion eliminará los siguientes datos: " + Chr(13) +
                  "1. Identificacion del Interno " + Chr(13) +
                  "   (Datos personales, Datos Complementarios, Nombres asociados, Fotos, etc)" + Chr(13)

            strMensaje = strMensaje & "Aun asi desea continuar con la operacion?"

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = Windows.Forms.DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                If (New Bussines.Registro.Interno).EliminarPLM(Me.idInterno, strMensajeOut) > 0 Then
                    Me.Close()
                End If

                Me.Cursor = Cursors.Default

                If strMensajeOut.Trim.Length > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensajeOut)
                End If

            End If

        End Sub

        Private Sub AnularInternoBanda()

            Dim value As Integer = -1
            Dim intIdDocJudAnula As Integer

            intIdDocJudAnula = FRM_Mant_Siscrico_Anular()

            If intIdDocJudAnula = -1 Then Exit Sub

            value = (New Bussines.Registro.InternoOrgCriminal).GrabarEstado(UscOrganizacionCriminal.GrillaID, 0, intIdDocJudAnula)

            If value > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                UscOrganizacionCriminal._LoadUsc()
            End If

        End Sub

        Private Sub EnabledControles(Valor As Boolean)

            Select Case Me.tcDatosInternos.SelectedTab.Name

                Case Me.tbpDatos.Name, Me.tbpDatosComplement.Name 'datos
                    'Me.txtCodIntUnico.ReadOnly = Valor
                    Me.txtNomClaveInt.ReadOnly = Valor
                    Me.txtCentroTrabajo.ReadOnly = Valor
                    Me.txtApePat.ReadOnly = Valor
                    Me.txtApeMat.ReadOnly = Valor
                    Me.txtNom.ReadOnly = Valor
                    Me.txtDecadactIzq.ReadOnly = Valor
                    Me.txtDecadactDer.ReadOnly = Valor
                    Me.txtLibro.ReadOnly = Valor
                    Me.txtFolio.ReadOnly = Valor
                    Me.txtPabellon.ReadOnly = Valor
                    Me.cbbSexo.Enabled = Not (Valor)
                    Me.dtpFechaNac.Enabled = Not (Valor)
                    Me.chk_Obs_DNI.Enabled = Not (Valor)
                    Me.chkNoindica.Enabled = Not (Valor)

                    If chkNoindica.Enabled = True Then
                        If chkNoindica.Checked = True Then
                            cbbTipoDoc.Enabled = False
                            txtNumDoc.ReadOnly = True
                        Else
                            cbbTipoDoc.Enabled = True
                            txtNumDoc.ReadOnly = False
                        End If
                    Else
                        chkNoindica.Enabled = False
                        If cbbTipoDoc.SelectedValue < 1 Then
                            chkNoindica.Checked = True
                        Else
                            chkNoindica.Checked = False
                        End If
                        cbbTipoDoc.Enabled = False
                        txtNumDoc.ReadOnly = True
                    End If

                    Me.chk_Homonimia.Enabled = Not (Valor)
                    Me.cbbEstadoCivil.Enabled = Not (Valor)
                    Me.cbbDiscapacitado.Enabled = Not (Valor)
                    Me.cbbNacionalidad.Enabled = Not (Valor)
                    Me.cbbPais.Enabled = Not (Valor)
                    Me.CbbDepartamento.Enabled = Not (Valor)
                    Me.cbbProvincia.Enabled = Not (Valor)
                    Me.cbbDistrito.Enabled = Not (Valor)
                    Me.cbbDomicilioDepa.Enabled = Not (Valor)
                    Me.cbbDomicilioProv.Enabled = Not (Valor)
                    Me.cbbDomicilioDist.Enabled = Not (Valor)
                    Me.txtDomicilio.ReadOnly = Valor
                    Me.cbbNivelAca.Enabled = Not (Valor)
                    Me.cbbOcupacion.Enabled = Not (Valor)
                    Me.cbbProfesion.Enabled = Not (Valor)
                    Me.cbbAndina.Enabled = Not (Valor)
                    Me.cbbAndinaEsp.Enabled = Not (Valor)
                    Me.txtObs.ReadOnly = Valor
                    Me.txtObs_dni.ReadOnly = Valor
                    Me.cbbGenero.Enabled = Not (Valor)
                    Me.cbbReligion.Enabled = Not (Valor)
                    Me.cbbCodFuerArmada.Enabled = Not (Valor)
                    Me.cbbCodigoRango.Enabled = Not (Valor)
                    Me.cbbIdiomaPrincipal.Enabled = Not (Valor)
                    Me.cbbCentroReclu.Enabled = Not (Valor)

            End Select

            If Valor = False Then
                btnGrabar.Text = "&Grabar"
                btnGrabar.Image = My.Resources.Drive___USB_32

                btnIngreso.Text = "Cancelar"
                btnIngreso.Image = My.Resources.anular2
                blnCheck = True
                blnModificarDatos = True
            Else
                btnGrabar.Text = "Modificar"
                btnGrabar.Image = My.Resources._1277961326_folder_edit

                btnIngreso.Text = "Nuevo" + Chr(13) +
                                  "Ingreso"
                btnIngreso.Image = My.Resources.add_32
                blnCheck = False
                blnModificarDatos = False
            End If

            'habilitar/ deshabilitar los controles 
            If Me._IDInternoSedeRowId > 0 Then 'comentado 12/02/2019 04:21 pm coordinacion GVA
                Me.txtApePat.Enabled = False
                Me.txtApeMat.Enabled = False
                Me.txtNom.Enabled = False
            End If

            Me.btnGrabar.Focus()

        End Sub

        Private Function ARegularizarDatosInterno() As Boolean

            Dim value As Boolean = False

            If Me.idInterno > 0 Then

                'si es un dato existente 
                objEntFiltroRegula = New Bussines.Registro.InternoRegularizacion.Interno

                Dim intRowID As Integer = -1

                objBssInterno = New Bussines.Registro.Interno
                intRowID = objBssInterno.getRowID(Me.idInterno)

                With objEntFiltroRegula
                    .IDInterno = Me.idInterno
                    .IDRow = intRowID
                    .CodigoRP = Me.CodigoRPInterno
                    .IDRegion = Me.idRegion
                    .IDPenal = Me.idPenal
                    .VersionRegistro = Me.VersionRegistro
                    .IDTipoDocumento = Me.TipoDocumento 'leer de la bd de datos, pendiente
                    .NumeroDocumento = Me.NumeroDocumento
                    .PrimerApellido = Me.InternoApePaterno
                    .SegundoApellido = Me.InternoApeMaterno
                    .Nombres = Me.InternoNombres
                    .FechaNacimiento = Me.InternoFechaNac
                    .IDNacionalidad = Me.IDNacionalidad
                    .InternoEstado = Me.InternoEstado
                End With

                'abrir un hilo, para realizar la espera del usuario
                Me.SuspendLayout()

                'If Me.BackgroundWorker1.IsBusy Then Exit Sub
                Me.BackgroundWorker1.RunWorkerAsync()

                frmLoad = New Load.frmProcesando
                If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.BackgroundWorker1.CancelAsync()
                    Me.BackgroundWorker1.Dispose()
                End If
                Me.ResumeLayout(True)
                frmLoad.Refresh()

                value = blnRegistroRegula

            Else
                value = True
            End If

            Return value
        End Function

#End Region
#Region "Formulario"
#Region "Datos del Interno"

        Private Sub frmConstanciaResluMant(nuevo As Boolean, idTramite As Integer)

            Dim codigo As Integer = -1
            Dim abrirForm As Boolean = False

            If nuevo = False Then
                codigo = idTramite
            End If

            Dim frm As New Registro.ConstanciaReclusion.frmTramite(codigo, Me.idInterno, Me.idRegion, Me.idPenal,
                Me.CodigoRPInterno, Me.InternoApeyNom, Me.regionNombre, Me.penalNombre, abrirForm,
                Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana)

            If abrirForm = True Then
                With frm
                    ._FormEscritura = Me._FormEscrituraOriginal
                    ._FormEliminar = Me._FormEliminarOriginal
                    ._FormReporte = Me._FormReporte
                    .ShowDialog()
                    If ._getActualizoDatos = True Then
                        Me.UscInternoDetalle1._buscar()
                    End If
                End With
            End If

        End Sub

        Private Sub FRM_MantIngreso(NuevoIngreso As Boolean)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me.cbbNroIngresos.Text = "[Por regularizar]" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un ingreso, regularizar el Nº de ingreso [0].")
                Exit Sub
            End If

            If NuevoIngreso = True Then
                If Me.btnIngreso.Text = "Cancelar" Then

                    EnabledControles(True)
                    ListarData()
                    Me.InternoApePaterno = Me.InternoApePaternoAux
                    Me.InternoApeMaterno = Me.InternoApeMaternoAux
                    Me.InternoNombres = Me.InternoNombresAux

                    Me.btnGrabar.Image = My.Resources._1277961326_folder_edit
                    Me.btnGrabar.Text = "Modificar"

                    Me.btnIngreso.Image = My.Resources.add_32
                    Me.btnIngreso.Text = "Nuevo" + Chr(13) + "Ingreso"

                    Exit Sub
                End If
            End If

            Dim frm As New Registro.PenalLM.Identificacion.frmIngresoPopup_V2
            With frm
                ._IDInterno = Me.idInterno
                ._InternoSedeRowId = Me._IDInternoSedeRowId
                ._IDRegion = Me.idRegion
                ._IDPenal = Me.idPenal
                ._AgregarNuevoIngreso = NuevoIngreso

                Select Case Me.PerfilUsuario
                    Case EnumDependencia.Legal, EnumDependencia.Odontologo, EnumDependencia.Psicologo, EnumDependencia.Social
                        ._FormEscritura = False
                        ._FormEliminar = False
                        ._FormReporte = False
                    Case Else
                        '._FormEscritura = Me._FormEscritura
                        '._FormEliminar = Me._FormEliminar
                        ._FormEscritura = Me._FormEscrituraOriginal
                        ._FormEliminar = Me._FormEscrituraOriginal
                        ._FormReporte = Me._FormReporte
                End Select

                If .ShowDialog = DialogResult.OK Then

                    'cargar numero de ingresoINPE
                    ComboNumIngreso()

                    Me.TabControl1.SelectTab(Me.tbpInterno)
                    Me.tcDatosInternos.SelectTab(Me.tbpDatos)
                    ListarData()

                    ValidarDuplicadosIngreso()

                End If

            End With
        End Sub

        Private Sub FRM_Mant_SeniaParticular(IdSeniaPart As Integer, forzarRegistroSoloLectura As Boolean)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If ValidarEstadoIngreso() = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("No se puede realizar ninguna operacion" + Chr(13) +
                                                                        "El interno en este ingreso, no esta en el penal.")
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmSeñasPartiPopup
            With frm
                .Codigo = IdSeniaPart
                ._InternoID = Me.idInterno
                ._InternoIngresoId = Me.IDIngreso
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._InternoIngresoNro = Val(cbbNroIngresos.Text)
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                If forzarRegistroSoloLectura = True Then
                    ._FormEscritura = False
                    ._FormEliminar = False
                Else
                    ._FormEscritura = uscFotoPerfiles._VisibleGrabar ' Me._FormEscritura
                    ._FormEliminar = uscFotoPerfiles._VisibleEliminar ' Me._FormEliminar
                End If


                If .ShowDialog = DialogResult.OK Then uscFotoPerfiles.ListarSenasParti()
            End With
        End Sub

        Private Sub FRM_Mant_Rasgos(intIDRasgo As Integer)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos básicos del interno")
                Exit Sub
            End If

            If ValidarEstadoIngreso() = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("No se puede realizar ninguna operación" + Chr(13) +
                                                                        "El interno en este ingreso, no esta en el penal.")
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmRasgosPartiPopup
            With frm
                .Codigo = intIDRasgo
                ._InternoID = Me.idInterno
                ._InternoIngresoId = Me.IDIngreso
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._NroIngreso = Val(cbbNroIngresos.Text)
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._FormEscritura = uscFotoPerfiles._VisibleGrabar ' Me._FormEscritura
                ._FormEliminar = uscFotoPerfiles._VisibleEliminar 'Me._FormEliminar

                If .ShowDialog = DialogResult.OK Then uscFotoPerfiles.ListarDataRasgo()

            End With
        End Sub

        Private Sub FRM_Mant_Fotos(InternoID As Integer, RestringirEdicion As Boolean)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If ValidarEstadoIngreso() = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("No se puede realizar ninguna operacion" + Chr(13) +
                                                                        "El interno en este ingreso, no esta en el penal.")
                Exit Sub
            End If

            Dim frm As New Registro.Captura.frmFotoPerfiles
            With frm
                ._InternoID = Me.idInterno
                .Codigo = InternoID
                .PenalID = Me.idPenal
                .RegionID = Me.idRegion
                .InternoIngresoId = Me.IDIngreso
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                .RestringirEdicion = RestringirEdicion
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                .InternoIngresoNro = Val(Me.cbbNroIngresos.SelectedIndex + 1)
                .LoadUsc()
                'permisos
                ._FormEscritura = uscFotoPerfiles._VisibleGrabar ' Me._FormEscritura
                ._FormEliminar = uscFotoPerfiles._VisibleEliminar ' Me._FormEliminar
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.uscFotoPerfiles.LoadUsc()
                    Me.uscFotoPerfiles.DataGrieView_Click()
                End If
            End With

        End Sub

        Private Sub FRM_Mant_NombresAsociados(ByVal Nuevo As Boolean, ByVal Codigo As Integer, objEntNA As Entity.Registro.NombreAsociado, forzarRegistroSoloLectura As Boolean)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Nuevo = True Then
                Dim frm1 As New Registro.Identificacion.frmNombreAsociadoPopup2(Nothing)
                With frm1
                    .Codigo = Codigo
                    .InternoID = Me.idInterno
                    .IngresoID = Me.IDIngreso
                    ._IngresoInpeID = Me.IDIngresoINPE
                    ._RegionID = Me.idRegion
                    ._PenalID = Me.idPenal
                    ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                    ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                    If forzarRegistroSoloLectura = True Then
                        ._FormEscritura = False
                        ._FormEliminar = False
                        ._FormReporte = False
                    Else
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte
                    End If

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        ListarCabecera()
                        'ListarData()
                        'ListarResoluciones()
                        'Listar_Expedientes()
                        UscGrillaNombresAsociadosV21.Listar()
                    End If
                End With
            Else
                Dim frm As New Registro.Identificacion.frmNombreAsociadoPopup2(Nothing)
                With frm
                    If Nuevo = True Then
                        .Codigo = -1
                    Else
                        .Codigo = Codigo
                    End If
                    ._RegionID = Me.idRegion
                    ._PenalID = Me.idPenal
                    .InternoID = Me.idInterno
                    ._IngresoInpeID = Me.IDIngresoINPE
                    ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    .objEntDocumen = New Entity.Registro.Documento.NombresAsociados
                    .objEntDocumen.NAPaterno = objEntNA.ApellidoPaterno
                    .objEntDocumen.NAMaterno = objEntNA.ApellidoMaterno
                    .objEntDocumen.NANombres = objEntNA.Nombres
                    .objEntDocumen.NAPrincipal = objEntNA.Principal
                    .objEntDocumen.NAEstado = objEntNA.Estado
                    .objEntDocumen.InternoID = objEntNA.InternoID
                    .objEntDocumen.InternoNombreAsociadoID = objEntNA.Codigo

                    ._TipoFormu = True
                    ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                    .ListarData()
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ListarCabecera()
                        'ListarData()
                        'ListarResoluciones()
                        UscGrillaNombresAsociadosV21.Listar()
                        Me.UscGrillaNombresAsociadosV21._LoadUsc()
                    End If
                End With
            End If

        End Sub

        Private Sub FRM_MantenimientoAlias(ByVal Nuevo As Boolean, AliasID As Integer, forzarRegistroSoloLectura As Boolean)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me.IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.v5.frmAliasPopup
            With frm
                If Nuevo = True Then
                    If ValidarEstadoIngreso() = False Then
                        Legolas.Configuration.Aplication.MessageBox.Information("No se puede realizar ninguna operacion" + Chr(13) +
                                                                                "El interno en este ingreso, no esta en el penal.")
                        Exit Sub
                    End If
                ElseIf Nuevo = False Then
                    .Codigo = AliasID
                End If
                .InternoID = Me.idInterno
                '._NroIngresoID = Me.IDIngreso
                ._NroIngresoInpeID = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                .TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                If forzarRegistroSoloLectura = True Then 'forzar a que sea solo lectura
                    ._FormEscritura = False
                    ._FormEliminar = False
                Else
                    ._FormEscritura = UscAlias21._VisibleGrabar
                    ._FormEliminar = UscAlias21._VisibleEliminar
                End If
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then LoadUscListarAlias()

            End With
        End Sub

        Private Sub FRM_MantenimientoBandas(ByVal Nuevo As Boolean, InternoBandaID As Integer, BandaIngesoID As Integer, objEntColBandas As Entity.Registro.InternoBandaCol, forzarRegistroSoloLectura As Boolean)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno.")
                Me.tcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me.IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmInternoBandaV2
            With frm
                If Nuevo = True Then
                    If ValidarEstadoIngreso() = False Then
                        Legolas.Configuration.Aplication.MessageBox.Information("No se puede realizar ninguna operacion" + Chr(13) +
                                                                                "El interno en este ingreso, no esta en el penal.")
                        Exit Sub
                    End If
                ElseIf Nuevo = False Then
                    .Codigo = InternoBandaID
                End If
                .InternoID = Me.idInterno
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._NroIngresoInpeID = Me.IDIngresoINPE
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                If forzarRegistroSoloLectura = True Then
                    ._FormEscritura = False
                    ._FormEliminar = False
                Else
                    ._FormEscritura = UscBandas21._VisibleGrabar
                    ._FormEliminar = UscBandas21._VisibleEliminar
                End If

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then LoadUscListarBandas()

            End With
        End Sub

        Private Function FRM_Mant_Siscrico_Anular() As Integer '24.04.2014 hnrb--> para crear documento judicial de anulacion de registro

            Dim frm As New Registro.Documento.frmDocJudicial
            With frm
                ._DocumentoJudicialID = -1
                ._InternoID = Me.idInterno
                ._IngresoID = Me.IDIngreso
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._IngresoInpeID = Me.IDIngresoINPE
                ._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Siscrico
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana

                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = DialogResult.OK Then
                    Return ._DocumentoJudicialID
                Else
                    Legolas.Configuration.Aplication.MessageBox.Information("Operación cancelada")
                    Return -1
                End If
            End With
        End Function

        Private Sub FRM_Mant_Siscrico(ByVal Nuevo As Boolean, forzarRegistroSoloLectura As Boolean)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno.")
                Me.tcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me.IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Siscrico.Bandas.frmInternoBandaPopupV2
            With frm
                If Nuevo Then
                    .Codigo = -1
                Else
                    .Codigo = Me.UscOrganizacionCriminal.GrillaID
                End If
                .InternoID = Me.idInterno
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._IngresoInpeID = Me.IDIngresoINPE
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                If forzarRegistroSoloLectura = True Then
                    ._VisibleGrabar = False
                    ._FormEscritura = False
                    ._FormEliminar = False
                Else
                    ._VisibleGrabar = False  'UscOrganizacionCriminal._VisibleGrabar
                    ._FormEscritura = False ' UscOrganizacionCriminal._VisibleGrabar
                    ._FormEliminar = False ' UscOrganizacionCriminal._VisibleEliminar
                End If

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscOrganizacionCriminal._LoadUsc()
                End If

            End With
        End Sub

        Private Sub FRM_Mant_Familia(ByVal Nuevo As Boolean, IDFamilia As Integer, objFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me.IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.v5.frmFamiliarPopupV2
            With frm
                .InternoID = Me.idInterno
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                '._NroIngresoID = Me.IDIngreso
                ._objEntColFam = objFamCol
                ._NuevoFam = Nuevo
                If Nuevo = True Then
                    .Codigo = -1
                    If ValidarEstadoIngreso() = False Then
                        Legolas.Configuration.Aplication.MessageBox.Information("No se puede realizar ninguna operacion" + Chr(13) +
                                                                                "El interno en este ingreso, no esta en el penal.")
                        Exit Sub
                    End If
                Else
                    .Codigo = IDFamilia
                End If
                .TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                If forzarRegistroSoloLectura = True Then
                    ._FormEscritura = False
                    ._FormEliminar = False
                Else
                    ._FormEscritura = UscFamilias1._VisibleGrabar
                    ._FormEliminar = UscFamilias1._VisibleEliminar
                End If


                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarFamilia()

                End If
            End With
        End Sub
        Private Sub FRM_Mant_Grilletes(ByVal Nuevo As Boolean, IDFamilia As Integer, objFamCol As Entity.Registro.FamiliarCol)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me.IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

        End Sub
        Private Sub FRM_VerReportes()

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de visualizar los reportes, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm2 As New Registro.Reporte.frmReportePopup_LM
            With frm2
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoID = Me.idInterno
                ._InternoApeNom = Me.InternoApeyNom
                ._TipoReporte = Reporte.frmReportePopup_LM.enmListarReportes.Interno
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._VisibleBuscar = False
                .ShowDialog()
            End With

        End Sub
        Private Sub frmVerReporteConstanciaReclusion(idTramiteConstancia As Integer, estadoTramite As Short)

            Dim filtro As New Entity.Registro.ConstanciaReclusion.ReporteFiltro
            With filtro
                .idTramiteCR = idTramiteConstancia
                .estadoTramite = estadoTramite
                .idRegion = Me.idRegion
                .idPenal = Me.idPenal
            End With

            Dim frm As New APPReporte.Registro.ConstanciaReclusion.ReporteCrystal(Configuracion.Licencia.Codigo,
                                                                                  Type.Enumeracion.ConstanciaReclusion.enmReporte.constanciaReclusion,
                                                                                  filtro)
            With frm
                .ShowDialog()
            End With

        End Sub
        Private Sub FRM_Odontograma(Nuevo As Boolean, IDOdontograma As Integer)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me.IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            Dim f As New Registro.Captura.frmOdontogramaPopup

            f._InternoId = Me.idInterno
            'f._InternoIngresoId = Me.IDIngreso
            f._InternoIngresoInpeId = Me.IDIngresoINPE
            f._PenalId = Me.idPenal
            f._RegionId = Me.idRegion
            f._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
            f._FormEscritura = Me._FormEscritura
            If Nuevo = True Then
                f._Codigo = -1
                If IDIngresoEstado < 1 And objEntComboIngCol.Count > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("No se puede realizar ninguna operacion" + Chr(13) +
                                                                            "El interno en este ingreso, no esta en el penal.")
                    Exit Sub
                End If
            Else
                f._Codigo = IDOdontograma
            End If

            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                UscOdont._LoadUsc()
            End If

        End Sub

#End Region
#Region "Expediente"
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, ByVal ExpedienteCodigo As Integer)
            If Me.IDIngresoINPE < 1 Or Me.IDIngresoINPE < 1 Then
                MessageBox.Show("Seleccione el número de ingreso",
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            Dim blnListarDelito As Boolean = False

            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1

                    If Me.InternoEstado <> 1 Then
                        Dim strMensaje As String = ""
                        strMensaje = "No puede ingresar expedientes, cuando el Interno se encuentra con estado inactivo" _
                        & Chr(13) & "De todas maneras desea ingresar el expediente del Interno"

                        If MessageBox.Show(strMensaje,
                         Legolas.Configuration.Aplication.MessageBox.MensajeTitulo,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                            Exit Sub
                        End If
                    End If

                Else
                    ._Codigo = ExpedienteCodigo
                    ._objEntExpediente = UscMandatoDetencion._ObjEntExp
                    ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                End If
                ._InternoID = Me.idInterno
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._IngresoID = -1
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                    Me.UscMandatoDetencion._ListarExpediente()

                End If
                Me.UscMandatoDetencion._ListarDelito()
            End With
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, ByVal DelitoCodigo As Integer)

            If Me.idInterno < 1 Or IngresoCodigo < 1 Or ExpedienteCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
               "Seleccione Expediente")
                Exit Sub
            End If

            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm
                If Nuevo = True Then

                Else
                    ._Codigo = DelitoCodigo
                    ._objEntDelito = UscMandatoDetencion._ObjEntDel
                    ._objEntAgraviadoCol = UscMandatoDetencion._ObjEntAgrCol
                    ._GrabarEnablet = True
                End If
                ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                '.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMandatoDetencion._ListarDelito()
                    Me.UscMandatoDetencion._ListarExpediente()
                End If

            End With
        End Sub
        Private Sub FRM_MantAgraviado(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, ByVal DelitoCodigo As Integer, ByVal AgraviadoCodigo As Integer)

            If Me.idInterno < 1 Or IngresoCodigo < 1 Or ExpedienteCodigo < 1 Or DelitoCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Delito")
                Exit Sub
            End If

            Dim frm As New Expediente.v5.frmAgraviadoPopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                Else
                    ._Codigo = AgraviadoCodigo
                    ._objEntAgraviado = UscMandatoDetencion._ObjEntAgr
                End If
                ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                '.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMandatoDetencion._ListarAgraviado()
                End If
            End With
        End Sub
        Private Sub FRM_Orden_Traslado(DocJudicialId As Integer, TipoResolucion As Integer)

            Dim frm As New Registro.Resoluciones.frmOrdenTrasladoHospital
            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoInpeId = Me.IDIngresoINPE  'UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._Documento_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._TipoResolucion = TipoResolucion
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                    Listar_Expedientes()
                End If
            End With
        End Sub
        Private Sub FRM_OrdenTraslado_Nuevo_OTSM(DocJudicialId As Integer, TipoResolucionId As Integer)

            Dim frm As New Registro.Resoluciones.frmOrdenTrasladoHospital_Nota
            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId =me.IDIngresoINPE 
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = TipoResolucionId
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = False
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With
        End Sub

#End Region
#Region "Resoluciones"
        Private Sub FRM_ListadoExpediente()
            Dim frm As New Registro.Resoluciones.frmVerExpePorResolPopup(IDIngreso, idInterno)
            frm._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
            frm.ShowDialog()
        End Sub

        Private Sub FRM_Resolucion_Sentencia(TipoResolucion As System.Int32, IDDocumentoJudicial As System.Int32, SubTipo As Integer, Version As String)

            Select Case TipoResolucion
                Case enumTipoDocumentoJudicial.Libertad
                    FRM_Resolucion_Libertad(IDDocumentoJudicial, SubTipo)
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental,
                     enumTipoDocumentoJudicial.Retorno_de_HospitalMental
                    FRM_Orden_Traslado(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota
                    FRM_OrdenTraslado_Nuevo_OTSM(IDDocumentoJudicial, TipoResolucion)
                Case enumTipoDocumentoJudicial.Traslado
                    FRM_Resol_Traslado(IDDocumentoJudicial)
                Case enumTipoDocumentoJudicial.Detencion, enumTipoDocumentoJudicial.DetencionReferenciado
                    FRM_Resol_Detencion(IDDocumentoJudicial)
                Case enumTipoDocumentoJudicial.Resolucion
                    FRM_Resol_Expediente(IDDocumentoJudicial)
                Case enumTipoDocumentoJudicial.Ingreso
                    If SubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoPrisionPreventiva Then
                        FRM_Resol_PrisionPreventiva(IDDocumentoJudicial)
                    Else
                        FRM_Resolucion_Ingreso(IDDocumentoJudicial, SubTipo)
                    End If
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.Aclaratoria
                    FRM_Resol_Aclaratoria(IDDocumentoJudicial)
                    ListarData()
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                    FRM_Resol_AmpliacionAutoapertorio(IDDocumentoJudicial)
                    ListarData()
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.Avocamiento
                    FRM_ResolucionAvocamiento(IDDocumentoJudicial)
                Case enumTipoDocumentoJudicial.Prolongacion_Detencion
                    FRM_Resolucion_ProlongDetencion(IDDocumentoJudicial)
                Case enumTipoDocumentoJudicial.Notas
                    FRM_Resolucion_Nota(IDDocumentoJudicial, SubTipo)
                Case enumTipoDocumentoJudicial.AcumulacionExpedientes
                    FRM_Resolucion_AcumExpediente(IDDocumentoJudicial)
                Case enumTipoDocumentoJudicial.Revocatoria_de_Libertad
                    FRM_Resolucion_RevocatoriaLibertad(IDDocumentoJudicial)
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.Queda
                    FRM_Queda(IDDocumentoJudicial)
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.Sentencia
                    FRM_Resol_Sentencia(IDDocumentoJudicial, Version)
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.Integracion_Sentencia, enumTipoDocumentoJudicial.Refundicion_de_Sentencia, enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                    FRM_Resol_IntegracionSentencia(IDDocumentoJudicial, TipoResolucion)

                Case enumTipoDocumentoJudicial.Sentencia_Aclaratoria, enumTipoDocumentoJudicial.Sent_Adecuacion_Pena,
                     enumTipoDocumentoJudicial.Sent_Conmutacion_Pena, enumTipoDocumentoJudicial.Sent_Sustitucion_Pena,
                     enumTipoDocumentoJudicial.ResolucionConsentida, enumTipoDocumentoJudicial.Resolucion,
                     enumTipoDocumentoJudicial.Resolucion_Superior,
                      enumTipoDocumentoJudicial.Ejecutoria_Superior, enumTipoDocumentoJudicial.Ejecutoria_Suprema

                    FRM_Resol_SentenciaMultiple(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.ResolucionDeclaraConsentida

                    FRM_Resol_DeclaraConsentidaSentencia(IDDocumentoJudicial, TipoResolucion)

                Case enumTipoDocumentoJudicial.Anulacion_Antecedentes

                    FRM_Resol_AnulacionAntecedentes(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()

                Case enumTipoDocumentoJudicial.Sent_Pena_Limitativa,
                  enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD
                    FRM_Resol_SentenciaPLD(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()

                Case enumTipoDocumentoJudicial.Revocatoria
                    FRM_Resol_Revocatoria(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.OtroProceso

                    FRM_Resol_OtroProceso(IDDocumentoJudicial, TipoResolucion)

                    ListarCabecera()
            End Select

        End Sub

        Private Sub FRM_Resol_SentenciaPLD(DocJudicialId As Integer, TipoResolucion As Integer)

            Dim frm As New Registro.RegionLima.Resoluciones.frmResolSentenciaMultiple
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.idInterno
                '._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With

        End Sub


        Private Sub FRM_Resol_Revocatoria(DocJudicialId As Integer, TipoResolucion As Integer)

            Dim frm As New Registro.RegionLima.Resoluciones.frmResolRevocatoria
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.idInterno
                '._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With
        End Sub

        Private Sub FRM_ListarResoluciones(IngresoID As Integer, ResolucionRegistrada As Boolean, Opcion As Integer)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me.IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            Dim frm As New Registro.Resoluciones.frmResolucionTipoPopup
            With frm
                ._InternoID = Me.idInterno
                '._IngresoID = IngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.txtInterno.Text
                ._ResolucionIngRegistrado = ResolucionRegistrada
                ._OpcionListar = Opcion
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                ._Documento_sin_mov = True
                'permisos
                ._FormEscritura = Me._FormEscrituraOriginal  ' Me._FormEscritura
                Dim abc As Boolean = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormImpresion = Me._FormImpresion
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                    UscResolucionesMain1._Listar()
                    UscMandatoDetencion._ListarExpediente()
                    UscGrillaNombresAsociadosV21.Listar()
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                    ListarData()
                End If
            End With

        End Sub

        Private Sub FRM_Resolucion_Ingreso(DocJudicialId As Integer, DocSubTipo As Integer)

            If DocSubTipo = 28 Or DocSubTipo = 30 Then 'ojo: cambiar por un type y replicar en v5 del penal
                Dim frm As New Registro.Resoluciones.frmResolIngresoTraslado
                With frm
                    ._Codigo = DocJudicialId
                    '._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                    ._InternoIngresoInpeId = Me.IDIngresoINPE
                    ._RegionID = Me.idRegion
                    ._PenalID = Me.idPenal
                    ._InternoID = Me.idInterno
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._blnNuevoRegistro = False
                    ._DocumentoSubTipo = DocSubTipo
                    ._Documento_sin_mov = True
                    ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormReporte = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

                End With
            Else
                Dim frm As New Registro.RegionLima.Resoluciones.frmResolIngreso
                With frm
                    ._Codigo = DocJudicialId
                    '._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                    ._InternoIngresoInpeId = Me.IDIngresoINPE
                    ._RegionID = Me.idRegion
                    ._PenalID = Me.idPenal
                    ._InternoID = Me.idInterno
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._blnNuevoRegistro = False
                    ._DocumentoSubtipo = DocSubTipo
                    ._Documento_sin_mov = True
                    ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormReporte = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

                End With
            End If
        End Sub

        Private Sub FRM_Resolucion_Libertad(DocJudicialId As Integer, Optional Version As Integer = -1)

            If Version = -1 Then
                Dim frm As New Registro.Resoluciones.frmResolLibertad
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                    ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                    ._RegionID = Me.idRegion
                    ._PenalID = -1
                    ._InternoId = Me.idInterno
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._blnNuevoRegistro = False
                    ._Documento_sin_mov = True
                    ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormReporte = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ListarResoluciones()
                        Listar_Expedientes()
                    End If
                End With
            Else
                Dim frm As New Registro.Resoluciones.frmResolLibertad_v2
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                    ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                    ._RegionID = Me.idRegion
                    ._PenalID = -1
                    ._InternoId = Me.idInterno
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._blnNuevoRegistro = False
                    ._Documento_sin_mov = True
                    ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormReporte = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ListarResoluciones()
                        Listar_Expedientes()
                    End If
                End With
            End If
        End Sub

        Private Sub FRM_Resolucion_Nota(DocJudicialId As Integer, SubTipo As Integer)
            Select Case SubTipo
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.ProyeccionVencimientoCondena
                    Dim frm As New Registro.Resoluciones.frmProyeccionVencimientoCondena
                    With frm
                        ._Codigo = DocJudicialId
                        ._InternoId = Me.idInterno
                        ._InternoIngresoId = Me.IDIngreso
                        ._InternoIngresoInpeId = Me.IDIngresoINPE
                        ._RegionID = Me.idRegion
                        ._PenalID = Me.idPenal
                        ._CodigoInterno = Me.CodigoRPInterno
                        ._NombresInterno = Me.InternoApeyNom
                        ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                        ._Subtipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.ProyeccionVencimientoCondena
                        ._blnNuevoRegistro = True
                        ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            ListarResoluciones()
                        End If
                    End With
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Nota_de_Sentencia, Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Adelanto_de_Fallo
                    Dim frm As New Registro.Resoluciones.frmNotaPeriodo
                    With frm
                        ._Codigo = DocJudicialId
                        ._InternoId = Me.idInterno
                        ._InternoIngresoId = Me.IDIngreso
                        ._InternoIngresoInpeId = Me.IDIngresoINPE
                        ._RegionID = Me.idRegion
                        ._PenalID = Me.idPenal
                        ._CodigoInterno = Me.CodigoRPInterno
                        ._NombresInterno = Me.InternoApeyNom
                        ._blnNuevoRegistro = False
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            ListarResoluciones()
                        End If
                    End With
                Case Else
                    Dim frm As New Registro.Resoluciones.frmNota

                    With frm
                        ._Codigo = DocJudicialId
                        ._InternoId = Me.idInterno
                        ._InternoIngresoId = Me.IDIngreso
                        ._InternoIngresoInpeId = Me.IDIngresoINPE
                        ._RegionID = Me.idRegion
                        ._PenalID = Me.idPenal
                        ._CodigoInterno = Me.CodigoRPInterno
                        ._NombresInterno = Me.InternoApeyNom
                        ._blnNuevoRegistro = False

                        'permisos
                        ._FormEscritura = _FormEscritura
                        ._FormEliminar = _FormEliminar
                        ._FormReporte = _FormReporte
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            ListarResoluciones()
                        End If

                    End With
            End Select
        End Sub

        Private Sub FRM_Resolucion_ProlongDetencion(DocJudicialId As Integer)

            Dim frm As New Registro.Resoluciones.frmResolProlongDetencion

            With frm
                ._Codigo = DocJudicialId
                '._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_ResolucionAvocamiento(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolAvocamiento

            With frm
                ._Codigo = DocJudicialId
                '._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_AmpliacionAutoapertorio(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolAmpliaAutoapert

            With frm
                ._Codigo = DocJudicialId
                '._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarData()
                    ListarCabecera()
                    UscGrillaNombresAsociadosV21.Listar()
                    ListarResoluciones()
                End If

            End With
        End Sub

        Private Sub FRM_Resol_Traslado(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolTraslado

            With frm
                ._Codigo = DocJudicialId
                '._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_Detencion(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolDetencionReferenciado

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.idInterno
                '._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Detencion
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                .UscExpeDeResolucion1._Documentos_sin_mov = True
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_Expediente(DocJudicialId As Integer)
            Dim frm As New Registro.Sentencias.frmResolSentenciaMultiple

            With frm
                ._Codigo = DocJudicialId
                '._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoID = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Resolucion
                .UscDetallResolucionEjecutoria1._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_PrisionPreventiva(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolPrisionPreventiva

            With frm
                ._Codigo = DocJudicialId
                '._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._Documento_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_Aclaratoria(DocJudicialId As Integer)
            'verificar
            Dim frm As New Registro.Resoluciones.frmResolAclaratoriaExpe

            With frm
                ._Codigo = DocJudicialId
                '._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoId = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._NuevoRegistro = False
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarData()
                    ListarCabecera()
                    ListarResoluciones()
                    UscGrillaNombresAsociadosV21.Listar()
                End If
            End With
        End Sub

        Private Sub FRM_Resolucion_AcumExpediente(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolAcumExpedientes

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.idInterno
                '._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                .UscDetallAcumulacionExp1._DocumentoJudicialID = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resolucion_RevocatoriaLibertad(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolRevocatoriaLibertad

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.idInterno
                '._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Queda(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmQueda

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me.idInterno
                '._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_AclaratoriaNombres(nomAsoID As Integer)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me.IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmNombreAsociadoPopup2(Nothing)
            With frm
                .Codigo = nomAsoID
                ._IngresoInpeID = Me.IDIngresoINPE
                '.IngresoID = Me.IDIngreso'lima metropolitana no es necesario
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                .InternoID = Me.idInterno
                ._Nuevobln = False
                ._TipoFormulario = Type.Formulario.Registro.UserControl.Resoluciones
                ._Documentos_sin_mov = True
                .ApellidoPaternoCopi = Me.InternoApePaterno
                .ApellidoMaternoCopi = Me.InternoApeMaterno
                .NombresCopi = Me.InternoNombres
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarData()
                    ListarCabecera()
                    ListarResoluciones()
                    UscGrillaNombresAsociadosV21.Listar()
                End If
            End With
        End Sub

        Private Sub FRM_Resol_OtroProceso(DocJudicialId As Integer, TipoResolucion As Integer)

            Dim frm As New Registro.Resoluciones.frmOtrosprocesos
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me.idInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._InternoID = Me.idInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoFormulario = TipoResolucion
                ._blnNuevoRegistro = False
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With

        End Sub

#End Region

#Region "Sentencias"
        Private Sub FRM_Resol_Sentencia(DocJudicialId As Integer, Optional Version As String = "")
            If Version = "V2" Then
                Dim frm As New Registro.Sentencias.frmResolSentenciaV2
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoID = Me.idInterno
                    ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                    ._InternoIngresoInpeId = Me.IDIngresoINPE
                    ._RegionID = Me.idRegion
                    ._PenalID = Me.idPenal
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._blnNuevoRegistro = False
                    ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormReporte = False
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ListarResoluciones()
                    End If
                End With
            Else
                Dim frm As New Registro.Sentencias.frmResolSentencia
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoID = Me.idInterno
                    ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                    ._InternoIngresoInpeId = Me.IDIngresoINPE
                    ._RegionID = Me.idRegion
                    ._PenalID = Me.idPenal
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._blnNuevoRegistro = False
                    ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormReporte = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

                End With
            End If
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
                Me.DocumentoTipo = TipoDocumento
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_SentenciaMultiple(DocJudicialId As Integer, TipoResolucion As Integer)
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
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_DeclaraConsentidaSentencia(DocJudicialId As Integer, TipoResolucion As Integer)
            Dim frm As New Registro.Sentencias.frmResolSentenciaNueva
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
                ._FormReporte = False
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
            End With
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
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub
#End Region

#Region "Movimientos"
        Private Sub FRM_MovimientoTipo(NroPendientes As Integer, strMensaje As String)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me.IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

            If NroPendientes > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Acción no permitida mientras que exista un movimiento pendiente.")
                Exit Sub
            End If

            'If ValidarEstadoIngreso() = False Then

            '    Legolas.Configuration.Aplication.MessageBox.Information("No se puede realizar ninguna operacion" + Chr(13) +
            '                                                            "El interno en este ingreso, no esta en el penal.")
            '    Exit Sub
            'End If

            Dim frm As New Registro.Movimientos.frmMovimientoTipoPopup
            With frm
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._InternoID = Me.idInterno
                ._IngresoID = Me.IDIngreso
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._NuevoRegistro = True
                ._NroPendientes = NroPendientes
                ._Documentos_sin_mov = True

                'permisos
                ._FormEscritura = Me._FormEscrituraOriginal
                ._FormEliminar = Me._FormEliminarOriginal

                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarMovimientosIngreso()
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                    Me.UscResolucionesMain1._Listar()
                End If
            End With
        End Sub
        Private Function ValidarEstadoIngreso() As Boolean
            Dim objInt As New Entity.Registro.Interno
            objInt = (New Bussines.Registro.Interno).Listar_LM(Me.idInterno)
            If Not objInt Is Nothing Then
                If objInt.EstadoID = Type.Enumeracion.Interno.EnmEstado.Inactivo Then
                    Return False
                End If
            End If

            Return True
        End Function
        Private Sub FRM_Movimiento(MovimientoID As Integer, MovimientoGrupoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer, Pendientes As Integer)
            Select Case MovimientoTipoID
                Case EnumMovTipo.Internamiento
                    FMR_MovimientoInternamiento(MovimientoID, MovimientoGrupoID, MovimientoTipoID, MovimientoMotivoID, IngresoID, DocumentoJudID)
                Case EnumMovTipo.Traslado
                    FRM_MovimientoTraslado(MovimientoID, MovimientoTipoID, IngresoID, DocumentoJudID)
                Case EnumMovTipo.Libertad
                    FRM_MovimientoLibertad(MovimientoID, MovimientoTipoID, MovimientoTipoID, IngresoID, DocumentoJudID, Pendientes)
                Case EnumMovTipo.Fuga, EnumMovTipo.Fallecimiento
                    FRM_MovimientoFuga(MovimientoID, MovimientoTipoID, IngresoID)
                Case EnumMovTipo.Conducciones
                    FRM_MovimientoConducciones(MovimientoID, MovimientoTipoID, IngresoID, DocumentoJudID)
                Case EnumMovTipo.ConduccionClasificacion
                    FRM_MovimientoConduccionesClasificacion(MovimientoID, MovimientoTipoID, IngresoID, DocumentoJudID)
                Case EnumMovTipo.TrasladoHospitalmental, EnumMovTipo.RetornodeHospitalmental
                    FRM_TrasladoHospitalmental(MovimientoID, MovimientoTipoID, MovimientoTipoID, IngresoID, DocumentoJudID, Pendientes)
                Case Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe el tipo de Movimiento")
            End Select
        End Sub

        Private Sub FMR_MovimientoInternamiento(MovimientoID As Integer, MovimientoGrupoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer)


            Dim frm As New Registro.Movimientos.Carceleta.frmInternamiento
            With frm
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.idInterno
                ._IngresoID = IngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._MovimientoGrupoID = MovimientoGrupoID
                ._MovimientoTipoID = MovimientoTipoID
                ._MovimientoMotivoID = MovimientoMotivoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumRegDocTipo.Internamiento
                ._CargarExpedientes = True


                'permisos
                ._FormEscritura = Me._FormEscrituraOriginal
                ._FormEliminar = Me._FormEliminarOriginal
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With

        End Sub

        Private Sub FRM_MovimientoTraslado(MovimientoID As Integer, MovimientoTipoID As Integer, IngresoID As Integer, DocumentoJudID As Integer)
            Dim frm As New Registro.Movimientos.Carceleta.frmMovimientoTrasladoCarceleta
            With frm
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.idInterno
                ._IngresoID = IngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.Traslado

                'permisos
                ._FormEscritura = Me._FormEscrituraOriginal
                ._FormEliminar = Me._FormEliminarOriginal
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With
        End Sub
        Private Sub FRM_MovimientoLibertad(MovimientoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer, Pendientes As Integer)

            Dim frm As New Registro.PenalLM.Movimientos.frmMovimientoLibertadPLM
            With frm
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.idInterno
                ._IngresoID = IngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._MovimientoTipoID = MovimientoTipoID
                ._MovimientoMotivoID = MovimientoMotivoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.Libertad
                '._NroPendientes = Pendientes
                'permisos
                ._FormEscritura = Me._FormEscrituraOriginal
                ._FormEliminar = Me._FormEliminarOriginal
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With
        End Sub

        Private Sub FRM_MovimientoFuga(MovimientoID As Integer, MovimientoTipoID As Integer, IngresoID As Integer)
            Dim frm As New Registro.Movimientos.frmMovimientoFuga
            With frm
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._Codigo = MovimientoID
                ._InternoID = Me.idInterno
                ._IngresoID = IngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._blnNuevo = False
                ._TipoMovimiento = MovimientoTipoID

                'permisos
                ._FormEscritura = Me._FormEscrituraOriginal
                ._FormEliminar = Me._FormEliminarOriginal
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With
        End Sub

        Private Sub FRM_MovimientoConducciones(MovimientoID As Integer, MovimientoTipoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer)

            Dim frm As New Registro.PenalLM.Movimientos.frmMovimientoConducciones
            With frm
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.idInterno
                ._IngresoID = IngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._blnNuevo = False
                ._CargarDocumento = True
                'permisos
                ._FormEscritura = Me._FormEscrituraOriginal
                ._FormEliminar = Me._FormEliminarOriginal
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With
        End Sub
        Private Sub FRM_MovimientoConduccionesClasificacion(MovimientoID As Integer, MovimientoTipoID As Integer,
                                                      IngresoID As Integer, DocumentoJudID As Integer)

            Dim frm As New Registro.Carceleta.Movimientos.frmMovimientoConduccionClasificacion
            With frm
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                ._Codigo = MovimientoID
                '._DocumJudicialID = DocumentoJudID
                ._InternoID = Me.idInterno
                ._IngresoID = IngresoID
                ._InternoIngresoInpeId = Me.IDIngresoINPE
                '._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._blnNuevo = False
                '._CargarDocumento = True
                'permisos
                ._FormEscritura = Me._FormEscrituraOriginal
                ._FormEliminar = Me._FormEliminarOriginal
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
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
                ._InternoIngresoInpeId = IDIngresoINPE
                ._MovimientoTipoID = MovimientoTipoID
                ._MovimientoMotivoID = MovimientoMotivoID
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.TrasladoHospitalmental
                ._NroPendientes = Pendientes
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscrituraOriginal
                ._FormEliminar = Me._FormEliminarOriginal
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                    Me.UscResolucionesMain1.LoadUsc()
                End If
            End With
        End Sub

#End Region


#End Region
#Region "Permisos_Usuario"
        Private Sub Usuario_Permisos()

            Dim blnBuscarLicenciaPenalEscritura As Boolean = False

            'Select Case Me.IDLicencia
            '    Case 1 'sede central
            '        'pasa
            '    Case Else 'penal o provincias
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("El Modulo de Carceleta solo está disponible en la Sede Central")
            '        Me.Close()
            'End Select

            If Me._FormEscritura = True Then

                Select Case Legolas.Configuration.Usuario.NivelUsuario
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                        'pasa
                    Case Else

                        Select Case Legolas.Configuration.Usuario.OficinaID

                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario

                            Case Else
                                Me._FormEscritura = False
                        End Select

                End Select

            End If

            If Me._FormEliminar = True Then
                Select Case Legolas.Configuration.Usuario.NivelUsuario
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                        'pasa
                    Case Else

                        Select Case Legolas.Configuration.Usuario.OficinaID

                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario

                            Case Else
                                Me._FormEscritura = False
                        End Select

                End Select
            End If

            '/*controles*/
            Me.pnlGrabarDatos.Visible = Me._FormEscritura
            Me.pnlEliminar.Visible = Me._FormEliminar
            Me.pnlReporte.Visible = Me._FormReporte

            '/*datos complementarios*/
            Me.UscIdiomaInterno1._VisibleGrabar = Me._FormEscritura
            Me.UscIdiomaInterno1._VisibleEliminar = Me._FormEliminar

            Me.UscGradosAcademicos1._VisibleGrabar = Me._FormEscritura
            Me.UscGradosAcademicos1._VisibleEliminar = Me._FormEliminar

            Me.UscDomicilio1._VisibleGrabar = Me._FormEscritura
            Me.UscDomicilio1._VisibleEliminar = Me._FormEliminar

            '/*nombres asociados*/
            Me.UscGrillaNombresAsociadosV21._VisibleGrabar = False ' Me._FormEscritura

            '/*fotografia*/
            Me.uscFotoPerfiles._VisibleGrabar = Me._FormEscritura
            Me.uscFotoPerfiles._VisibleEliminar = Me._FormEliminar

            '/*reniec*/

            '/*alias y bandas*/
            Me.UscAlias21._VisibleGrabar = Me._FormEscritura
            Me.UscAlias21._VisibleEliminar = Me._FormEliminar

            Me.UscBandas21._VisibleGrabar = Me._FormEscritura
            Me.UscBandas21._VisibleEliminar = Me._FormEliminar

            '/*organizacion criminal*/
            Me.UscOrganizacionCriminal._VisibleGrabar = False 'Me._FormEscritura
            Me.UscOrganizacionCriminal._VisibleEliminar = False ' Me._FormEliminar

            '/*familiares*/
            Me.UscFamilias1._VisibleGrabar = Me._FormEscritura
            Me.UscFamilias1._VisibleEliminar = Me._FormEliminar

            '/*odontograma*/
            Me.UscOdont._VisibleGrabar = Me._FormEscritura
            Me.UscOdont._VisibleEliminar = Me._FormEliminar

            '/*mandato detencion*/
            Me.UscMandatoDetencion._VisibleAnulacion = True
            Me.UscVisorDetalleHuellas1._ControlSoloVista = Not Me._FormEscritura

            '/*resolucion*/
            Me.UscResolucionesMain1._VisibleGrabar = False ' Me._FormEscritura
            Me.UscResolucionesMain1._VisibleEliminar = False ' Me._FormEliminar

            '/*movimiento*/
            Me.UscMovimiento1._VisibleGrabar = Me._FormEscrituraOriginal ' Me._FormEscritura
            Me.UscMovimiento1._VisibleEliminar = Me._FormEscrituraOriginal

            If Legolas.Configuration.Usuario.NivelUsuario = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                Legolas.Configuration.Usuario.NivelUsuario = Type.Enumeracion.Licencia.enmTipoLicencia.Sede Then
                Usuario_Permisos_Perfil()
            End If

        End Sub
        Private Sub Usuario_Permisos_Perfil()

            If Me.PerfilUsuario <> EnumDependencia.RegistroPenitenciario Then
                Me.uscFotoPerfiles._VisibleGrabar = False
                Me.uscFotoPerfiles._VisibleEliminar = False

                Me.UscGrillaNombresAsociadosV21._VisibleGrabar = False
                'bandas            
                Me.UscOrganizacionCriminal._VisibleGrabar = False
                Me.UscOrganizacionCriminal._VisibleEliminar = False

                Me.UscResolucionesMain1._VisibleGrabar = False
                Me.UscResolucionesMain1._VisibleEliminar = False

                Me.UscMovimiento1._VisibleGrabar = False
                Me.UscMovimiento1._VisibleEliminar = False

                Me.pnlAuditoria.Visible = False

                Me.pnlGrabarDatos.Visible = False
                Me.pnlNuevoReniec.Visible = False
                Me.pnlEliminar.Visible = False

                Me.UscIdiomaInterno1._VisibleGrabar = False
                Me.UscIdiomaInterno1._VisibleEliminar = False

                Me.UscGradosAcademicos1._VisibleGrabar = False
                Me.UscGradosAcademicos1._VisibleEliminar = False

                Me.UscDomicilio1._VisibleGrabar = False
                Me.UscDomicilio1._VisibleEliminar = False

                Me.UscAlias21._VisibleGrabar = False
                Me.UscAlias21._VisibleEliminar = False

                Me.UscBandas21._VisibleGrabar = False
                Me.UscBandas21._VisibleEliminar = False

                Me.UscFamilias1._VisibleGrabar = False
                Me.UscFamilias1._VisibleEliminar = False

                Me.UscOdont._VisibleGrabar = False
                Me.UscOdont._VisibleEliminar = False

                Me.UscVisorDetalleHuellas1._ControlSoloVista = True

            End If

            Select Case Me.PerfilUsuario
                Case EnumDependencia.Odontologo
                    TabControl1.TabPages.Remove(tbpMandDet)
                    Me.UscOdont._VisibleGrabar = Me._FormEscritura
                    Me.UscOdont._VisibleEliminar = Me._FormEliminar

                Case EnumDependencia.RegistroPenitenciario
                    UscResolucionesMain1.Visible = True
                    'TabControl1.TabPages.Remove(tbpClasificacion)
                    'TabControl2.TabPages.Remove(tbpOdontograma)

                Case EnumDependencia.SeguridadPenitenciaria

                    tcDatosInternos.TabPages.Remove(tbpOdontograma)
                    tcDatosInternos.TabPages.Remove(tbpHuella)

                    tcDatosInternos.TabPages.Remove(tbpBandas)
                    tcDatosInternos.TabPages.Remove(tbpFamiliares)

                    If Me.InternoEstado = 1 Then 'solo si el interno se encuentra activo puede agregar/modif/eliminar movimientos.
                        Me.UscMovimiento1._VisibleGrabar = Me._FormEscritura
                        Me.UscMovimiento1._VisibleEliminar = Me._FormEliminar
                    End If


                    Me.pnlGrabarDatos.Visible = Me._FormEscritura
                    Me.pnlNuevoReniec.Visible = Me._FormEscritura
                    Me.pnlEliminar.Visible = Me._FormEliminar
                Case EnumDependencia.TratamientoPenitenciario, EnumDependencia.SistemasInformacion
                    'With UscClasificaciones1
                    '    ._VisibleGrabar = Me._FormEscritura
                    '    ._VisibleEliminar = Me._FormEliminar
                    '    ._VisibleImprimir = Me._FormImpresion
                    'End With
            End Select
        End Sub
#End Region

#Region "Reniec"
        Private Sub Nuevo_Validacion_Reniec()
            If ValidarEstadoIngreso() = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("No se puede realizar ninguna operacion" + Chr(13) +
                                                                        "El interno en este ingreso, no esta en el penal.")
                Exit Sub
            End If
            UscValidacionReniecV21.ListarInternoValidado(Me.idInterno)

            Dim frmValidacion As New Registro.Reniec.frmTipoValidacionV2
            With frmValidacion
                ._InternoID = Me.idInterno
                ._IngresoInpeID = Me.IDIngresoINPE
                '._NroIngresoID = Me.IDIngreso

                ._TipoDocumento = Me.TipoDocumento
                ._NumeroDocumento = Me.NumeroDocumento
                ._Estado = Me.InternoEstado
                ._ImagenSis = UscValidacionReniecV21._NumeroImagen
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana

                ._ListaInternoSisCabecera = UscValidacionReniecV21._ListaCabeceraInterno
                ._ListaInternoSisData = UscValidacionReniecV21._ListaDataInterno
                ._NombresAsociados = UscValidacionReniecV21._NombresAsociados

                ._ApellidoPaterno = objEntInt.ApellidoPaterno
                ._ApellidoMaterno = objEntInt.ApellidoMaterno
                ._Nombres = objEntInt.Nombres
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ListarData()
                End If

            End With
            UscValidacionReniecV21.Listar_ReniecHistorico(Me.idInterno)

        End Sub

        Private Function ValidarFichaReniec() As Boolean

            Dim value As Boolean = False

            If Me.idInterno < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tcDatosInternos.SelectedIndex = 0
                Return value
            End If

            'If Me.IDIngreso < 1 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
            '    Me.TabControl2.SelectedIndex = 0
            '    Return value
            'End If

            If Me.IDNacionalidad <> 141 Then '"nacionalidad peruana"
                Me.tcDatosInternos.SelectedIndex = 0
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Interno no posee la nacionalidad peruana")
                Return value
            End If

            '/****************************/
            Dim objBssFoto As New Bussines.Registro.InternoFoto
            Dim objEnt As New Entity.Registro.InternoFoto
            Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente(Me.idInterno)
            Dim strRutServer As String = ""
            Dim intImagen As Integer = -1
            Dim intNombreImagen As String = ""

            objBssFoto = New Bussines.Registro.InternoFoto
            objEnt = objBssFoto.ListarGrilla(intCodigo)

            If objEnt.Codigo > 0 Then
                With objEnt
                    intImagen = .PFrenteID
                    intNombreImagen = .PFrenteName
                    strRutServer = .PFrenteServerPath
                End With
            End If

            If intImagen < 1 And intNombreImagen = "" Then
                Me.tcDatosInternos.SelectedIndex = 2
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Interno no puede ser validado porque no cuenta con fotografia, capture la fotografia luego realize la validación")
                Return value
            End If

            value = True

            Return value

        End Function

#End Region
#Region "Clasificacion"
        'Private Sub FRM_Clasificacion(objEnt As Entity.Clasificacion.Documento.DatosFicha)
        '    If objEnt.GrupoFichaId = Type.Enumeracion.Clasificacion.enmGrupoClasificacion.ClasificacionPenales Then
        '        Dim f As New Registro.PenaLM.Clasificacion.frmDetalleFicha

        '        f.VariableId = objEnt.MaeVariableId
        '        f.FichaId = objEnt.MaeFichaId
        '        f.RegionID = Me._IDRegion
        '        f.PenalID = Me._IDPenal
        '        f.VariableString = objEnt.VariableNombre
        '        f._ValorPuntaje = objEnt.ValorPuntaje
        '        f._ValorNoPrevisto = objEnt.ValorNoPrevisto
        '        f.InternoFichaDetalleId = objEnt.InternoFichaDetalleId
        '        f.IndicadorId = objEnt.IndicadorId
        '        f.BloquearRegistro = objEnt.BloquearRegistro
        '        f.SituacionJuridicaId = objEnt.InternoSituacionJuridica
        '        f.GrupoFichaId = objEnt.GrupoFichaId
        '        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
        '            UscClasificaciones2.Listar2(f._ValorPuntaje, f.ValorNombreSeleccionado, f.ValorIdSeleccionado, f._ValorNoPrevisto)
        '        End If
        '    Else
        '        Dim f As New Registro.Carceleta.Clasificacion.frmDetalleFicha_V2

        '        f.VariableId = objEnt.MaeVariableId
        '        f.FichaId = objEnt.MaeFichaId
        '        f.RegionID = Me._IDRegion
        '        f.PenalID = Me._IDPenal
        '        f.VariableString = objEnt.VariableNombre
        '        f._ValorPuntaje = objEnt.ValorPuntaje
        '        f._ValorNoPrevisto = objEnt.ValorNoPrevisto
        '        f.InternoFichaDetalleId = objEnt.InternoFichaDetalleId
        '        f.IndicadorId = objEnt.IndicadorId
        '        f.BloquearRegistro = objEnt.BloquearRegistro
        '        f.SituacionJuridicaId = objEnt.InternoSituacionJuridica
        '        f.GrupoFichaId = objEnt.GrupoFichaId
        '        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
        '            UscClasificaciones1.Listar2(f._ValorPuntaje, f.ValorNombreSeleccionado, f.ValorIdSeleccionado, f._ValorNoPrevisto)
        '        End If
        '    End If
        'End Sub
#End Region
#Region "Otros"

        Private Sub HabilitarControlesAccion()

            Dim blnVisibleGrabarDatos As Boolean = False
            Dim blnVisibleNuevoReniec As Boolean = False
            Dim blnVisibleEliminarInterno As Boolean = False
            Dim blnVisibleLeyenda As Boolean = False

            Select Case Me.TabControl1.SelectedTab.Name

                Case Me.tbpInterno.Name

                    Select Case Me.tcDatosInternos.SelectedTab.Name
                        Case Me.tbpDatos.Name   'datos del interno, foto
                            blnVisibleGrabarDatos = Me._FormEscritura
                            blnVisibleNuevoReniec = False
                            blnVisibleEliminarInterno = Me._FormEliminar
                            Me.pnlAuditoria.Visible = True

                        Case Me.tbpDatosComplement.Name 'datos complemtarios
                            blnVisibleGrabarDatos = Me._FormEscritura

                        Case Me.tbpFoto.Name  'foto
                            blnVisibleGrabarDatos = False
                            blnVisibleNuevoReniec = False
                            blnVisibleEliminarInterno = False
                            Me.pnlAuditoria.Visible = False

                        Case Me.tbpReniec.Name  'reniec
                            blnVisibleGrabarDatos = False
                            blnVisibleNuevoReniec = Me._FormEscritura
                            blnVisibleEliminarInterno = False
                            Me.pnlAuditoria.Visible = False

                        Case Me.tbpBandas.Name 'bandas

                            Me.pnlAuditoria.Visible = False

                        Case Else
                            Me.pnlAuditoria.Visible = False
                    End Select

                Case Me.tbpMandDet.Name
                    Me.pnlAuditoria.Visible = False
            End Select

            If Me.PerfilUsuario <> EnumDependencia.RegistroPenitenciario And
               Me.PerfilUsuario <> EnumDependencia.SeguridadPenitenciaria And
               Me.PerfilUsuario <> EnumDependencia.SistemasInformacion Then

                Me.pnlGrabarDatos.Visible = False
                Me.pnlNuevoReniec.Visible = False
                Me.pnlEliminar.Visible = False
            Else
                Me.pnlGrabarDatos.Visible = blnVisibleGrabarDatos
                Me.pnlNuevoReniec.Visible = blnVisibleNuevoReniec
                Me.pnlEliminar.Visible = blnVisibleEliminarInterno
            End If
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

            ComboDomicilioDepartamento()
            ComboComunidadAndinaEspecifico()
            ComboFuerzaArmada()
            ComboRangoFuerzaArmada()
            ComboPabellon()
            ComboNumIngreso()

            Me.TipoDocumento = -1   '10 dni
            Me.IDNacionalidad = 141    '141 peruana
            Me.Pais = -1    '85 peru
            Me.Sexo = -1
            Me.EstadoCivil = -1
            Me.Discapacidad = -1
            Me.DomicilioDepartamento = -1
            Me.NivelAcademcico = -1   '11 ninguno
            Me.Profesion = -1
            Me.Ocupacion = -1
            Me.ComunidadAndina = -1
            Me.GeneroPersonaId = -1
            Me.ReligionId = -1
            Me.CodigoFuerzaArmadaId = -1
            Me.CodigoRangoId = -1
            Me._IdiomaNativoId = -1
            Me.txtUbigeoOtro.Enabled = False

            txtCodigo.BackColor = Control.DefaultBackColor()
            txtInterno.BackColor = Control.DefaultBackColor()
            txtEstado.BackColor = Control.DefaultBackColor()
            txtRegionPenal.BackColor = Control.DefaultBackColor()

            Me.Refresh()
        End Sub

        Private Sub HabilitarTipoDocumento()

            If Me.Noindica = True Then
                Me.cbbTipoDoc.SelectedValue = -1
                Me.cbbTipoDoc.Enabled = False
                Me.txtNumDoc.Text = ""
                Me.txtNumDoc.Enabled = False
            Else
                Me.cbbTipoDoc.Enabled = True
                Me.txtNumDoc.Text = ""
                Me.txtNumDoc.Enabled = True
                Me.txtNumDoc.ReadOnly = False
            End If

        End Sub

        Private Sub ActivaDesactivaCheckMenorEdad()
            Dim dteFechaNac As Date
            dteFechaNac = Me.dtpFechaNac.Value

            Dim dteFechaMay18 As Date = DateAdd(DateInterval.Year, -18, Now)

            If dteFechaNac >= dteFechaMay18 Then
                Me.chk_Obs_DNI.Enabled = True
                Me.chk_Obs_DNI.Checked = True
            End If
        End Sub

#End Region

        Private Sub frmMantenimiento_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            CheckForIllegalCrossThreadCalls = False
            HabilitarControlesAccion()

        End Sub

        Private Sub LimpiarDirectorio(rutaDir As String)
            Try
                For Each item As String In System.IO.Directory.GetFiles(rutaDir)
                    System.IO.File.Delete(item)
                Next
            Catch ex As Exception

            End Try
        End Sub

        Private Sub frmMantenimiento2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown

            Me._FormEscrituraOriginal = Me._FormEscritura
            Me._FormEliminarOriginal = Me._FormEliminar
            'limpiar temporales
            LimpiarDirectorio(My.Computer.FileSystem.CurrentDirectory & "\tmp\doc_digitalizado")
            LimpiarDirectorio(My.Computer.FileSystem.CurrentDirectory & "\tmp\odontograma")

            ValoresxDefault()
            ListarCabecera()

            Dim blnCerrarForm As Boolean = False
            ListarData(blnCerrarForm)

            If blnCerrarForm = False Then

                Usuario_Permisos()
                If InternoFechaNac > 0 Then
                    ActivaDesactivaCheckMenorEdad()
                End If

                Me.Cursor = Cursors.WaitCursor

                Dim blnCargar As Boolean = True

                ''si no es la sede central, ya no debe regularizar, x activar en el futuro para los penales de provincia 2022
                'If IDLicencia > 1 Then
                '    If ARegularizarDatosInterno() = False Then
                '        Me.pnlNuevoReniec.Visible = False
                '        Me.pnlGrabarDatos.Visible = False
                '        Me.pnlEliminar.Visible = False
                '        Me.pnlReporte.Visible = False
                '        Me.btnAddIngreso.Visible = False
                '        Me.pnlUpdateDocJud.Visible = False

                '        Me.TabControl1.Enabled = False
                '        Me.TabControl2.Enabled = False
                '        blnCargar = False
                '    End If
                'End If

                If blnCargar = True Then
                    If objEntComboIngCol.Count < 1 Then
                        ComboNumIngreso() 'volver ha cargar el combo de ingreso una vez regularizado el dato
                    End If

                    ValidarDuplicadosIngreso()
                    Me.TabControl1.Enabled = True
                    Me.tcDatosInternos.Enabled = True
                End If
            End If

            Me.Cursor = Cursors.Default

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

        Private Sub cbbDomicilioProv_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbDomicilioProv.KeyPress
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End Sub

        Private Sub cbbDomicilioProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbDomicilioProv.SelectedIndexChanged
            If blnComboDomProv = True Then
                ComboDomicilioDistrito()
            End If
        End Sub

        Private Sub cbbDomicilioDepa_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbDomicilioDepa.KeyPress
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End Sub

        Private Sub cbbDomicilioDepa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbDomicilioDepa.SelectedIndexChanged
            If blnComboDomDep = True Then
                ComboDomicilioProvincia()
                ComboDomicilioDistrito()
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

        Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
            AGrabar()
        End Sub
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Dim blnSalir As Boolean = True
            Select Case Me.tcDatosInternos.SelectedTab.Name

                Case Me.tbpDatos.Name, Me.tbpDatosComplement.Name

                    If Me.btnGrabar.Text = "&Grabar" Then

                        If MessageBox.Show("¿Desea guardar los datos del interno?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            blnSalir = True
                        Else
                            blnSalir = False
                        End If

                    End If
            End Select

            If blnSalir = True Then
                Dim _MdiParenAux As MDIParent1 = Me.MdiParent
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
                If _blnFormAux = True Then
                    _blnFormAux = False
                    Dim frm As New Registro.frmListaDocumentosDescargados
                    Me.Usuario_Permisos_Perfil()
                    frm._PenalID = Me.idPenal
                    frm._FormEscritura = Me._FormEscritura
                    frm._MdiParenAux = _MdiParenAux
                    frm.PerfilUsuarioId = Legolas.Configuration.Usuario.NivelUsuario
                    frm.Show()
                End If
            End If

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedTab.Name
                Case Me.tbpInterno.Name

                Case Me.tbpMandDet.Name
                    ListarResoluciones()
                    Listar_Expedientes()

                Case Me.tbpMovimientos.Name
                    ListarMovimientosIngreso()
                    'Case Me.tbpClasificacion.Name
                    '    LoadUscClasificaciones()
            End Select

            HabilitarControlesAccion()
        End Sub

        Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcDatosInternos.SelectedIndexChanged
            Select Case Me.tcDatosInternos.SelectedTab.Name
                Case Me.tbpDatos.Name
                    If blnModificarDatos = False Then
                        ListarData()
                    End If
                Case Me.tbpDatosComplement.Name
                    If blnModificarDatos = False Then
                        ListarData()
                        ListarDatosComplementarios()
                    End If
                Case Me.tbpFoto.Name
                    LoadUscFotografia()
                Case Me.tbpNombresAsoc.Name
                    LoadUscNombresAsociados()
                Case Me.tbpAliasBandas.Name
                    LoadUscListarAlias()
                    LoadUscListarBandas()
                Case Me.tbpFamiliares.Name
                    ListarFamilia()
                Case Me.tbpBandas.Name
                    LoadUscOrganizacionCriminal()
                Case Me.tbpReniec.Name
                    DataValidarReniec()
                Case Me.tbpOdontograma.Name
                    LoadUscOdontograma()
                Case Me.tbpHuella.Name
                    LoadUscHuellas()
                    'Case Me.tbpDocDigitalizados.Name
                    '    LoadUscDocumentoDigitalizado()
            End Select
            HabilitarControlesAccion()
        End Sub

        Private Sub cbbAndina__ValueChanged() Handles cbbAndina._SelectedIndexChanged
            If blnComboComAnd = True Then
                ComboComunidadAndinaEspecifico()
            End If
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
            AEliminarInterno()
        End Sub

        Private Sub chkNoindica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNoindica.Click
            HabilitarTipoDocumento()
        End Sub

        Private blnCheck As Boolean = False
        Private Sub cbbTipoDoc__SelectedIndexChanged() Handles cbbTipoDoc._SelectedIndexChanged
            If btnGrabar.Text = "&Grabar" Then
                Select Case Me.TipoDocumento
                    Case 10 'dni
                        Me.txtNumDoc.MaxLength = 8
                        Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
                        Me.txtNumDoc.Enabled = True
                    Case 11 'indocumentado
                        Me.txtNumDoc.MaxLength = 20
                        Me.txtNumDoc.Text = ""
                        Me.txtNumDoc.Enabled = False
                    Case Else
                        Me.txtNumDoc.MaxLength = 20
                        Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
                        Me.txtNumDoc.Enabled = True
                End Select
                txtNumDoc.Text = ""
                If blnCheck = True Then
                    txtNumDoc.Focus()
                End If

            End If
        End Sub

        Private Sub txtNom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
            If e.KeyChar = "." Then e.Handled = True
        End Sub

        Private Sub chk_Obs_DNI_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_Obs_DNI.CheckedChanged
            If Me.chk_Obs_DNI.Checked = True Then
                Me.txtObs_dni.Enabled = True
                txtObs_dni.Focus()
            Else
                Me.txtObs_dni.Text = ""
                Me.txtObs_dni.Enabled = False
                dtpFechaNac.Focus()
            End If
        End Sub

        Private Sub cbbNroIngresos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbNroIngresos.SelectedIndexChanged

            If blnComboIngreso = True Then

                If Me.idInterno < 1 Or Me.IDIngresoINPE < 1 Then
                    Exit Sub
                End If

                If objEntComboIngCol.Count > 0 Then
                    For Each entInp As Entity.Registro.IngresoInpe In objEntComboIngCol
                        If entInp.Codigo = IDIngresoINPE Then
                            Me.IDIngreso = entInp.IDIngreso
                            Me.IDIngresoEstado = entInp.EstadoId
                        End If
                    Next
                Else
                    Me.IDIngreso = -1
                End If

                TabControl1_SelectedIndexChanged(sender, e)
                TabControl2_SelectedIndexChanged(sender, e)
                TabControl3_SelectedIndexChanged(sender, e)
                tcMovimientos_SelectedIndexChanged(sender, e)

                uscFotoPerfiles.DataGrieView_Click()
            End If

        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            Nuevo_Validacion_Reniec()
        End Sub

        Private Sub btnFicha_Click(sender As System.Object, e As System.EventArgs) Handles btnFicha.Click
            FRM_VerReportes()
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__AddNombreAsociado() Handles UscGrillaNombresAsociadosV21._AddNombreAsociado
            FRM_Resol_AclaratoriaNombres(-1)
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__UpdNombreAsociado(id As System.Int32, objEnt As Entity.Registro.NombreAsociado, forzarRegistroSoloLectura As Boolean) Handles UscGrillaNombresAsociadosV21._UpdNombreAsociado
            FRM_Mant_NombresAsociados(False, id, objEnt, forzarRegistroSoloLectura)
        End Sub

        Private Sub UscGrillaBandasV21__AddInternoBanda() Handles UscOrganizacionCriminal._AddInternoBanda
            FRM_Mant_Siscrico(True, False)
        End Sub

        Private Sub UscGrillaBandasV21__UpdInternoBanda(forzarRegistroSoloLectura As Boolean) Handles UscOrganizacionCriminal._UpdInternoBanda
            FRM_Mant_Siscrico(False, forzarRegistroSoloLectura)
        End Sub

        Private Sub UscGrillaBandasV21__AnularInternoBanda() Handles UscOrganizacionCriminal._AnularInternoBanda
            If UscOrganizacionCriminal.GrillaEstadoId = 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("No es posible completar la operación, registro ya se encuentra anulado")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Confirma cambiar el estado del registro seleccionado a ANULADO?") = MsgBoxResult.Yes Then
                AnularInternoBanda()
            End If

        End Sub

        Private Sub btnAddIngreso_Click(sender As System.Object, e As System.EventArgs) Handles btnAddIngreso.Click
            Me.NuevoClickfrmIngreso = False
            FRM_MantIngreso(False)

        End Sub

        Private Sub uscFotoPerfiles__Clik_MantenimientoFotos(InternoFotId As System.Int32, RestringirEdicion As Boolean) Handles uscFotoPerfiles._Clik_MantFotos
            FRM_Mant_Fotos(InternoFotId, RestringirEdicion)
        End Sub

        Private Sub uscFotoPerfiles__Clik_MantRasgos(RasgoId As System.Int32, forzarRegistroSoloLectura As Boolean) Handles uscFotoPerfiles._Clik_MantRasgos
            FRM_Mant_Rasgos(RasgoId)
        End Sub

        Private Sub uscFotoPerfiles__Clik_MantSeniaPart(SenPartId As System.Int32, forzarRegistroSoloLectura As Boolean) Handles uscFotoPerfiles._Clik_MantSeniaPart
            FRM_Mant_SeniaParticular(SenPartId, forzarRegistroSoloLectura)
        End Sub

        Private Sub UscValidacionReniecV21__DoubleClick_CargarDetalle(objEntRnc As Entity.Registro.InternoReniec) Handles UscValidacionReniecV21._DoubleClick_CargarDetalle
            Dim frm As New Registro.Reniec.frmDetalleValidacionPoput
            frm.objEntRnc = objEntRnc
            frm.ShowDialog()
        End Sub

        Private Sub chk_Obs_DNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Obs_DNI.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
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

        Private Sub cbbDomicilioDist_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbDomicilioDist.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub cbbNivelAca_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbNivelAca.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub cbbProfesion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbProfesion.KeyPress
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End Sub

        Private Sub cbbOcupacion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbOcupacion.KeyPress
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End Sub

        Private Sub UscValidacionReniecV21__DoubleClick_CargarDetalleNomAso(objEntRnc As Entity.Registro.NombreAsociadoCol) Handles UscValidacionReniecV21._DoubleClick_CargarDetalleNomAso
            Dim frm As New Registro.Reniec.frmDetalleNombresAsociadosPoput
            frm._objEntCol = objEntRnc
            frm.ShowDialog()
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

        Private Sub UscGrillaNombresAsociadosV21__Clik_btnIngresofocus() Handles UscGrillaNombresAsociadosV21._Clik_btnIngresofocus
            Me.btnAddIngreso.Focus()
        End Sub

        Private Sub uscFotoPerfiles__Clik_btnIngresofocus() Handles uscFotoPerfiles._Clik_btnIngresofocus
            btnAddIngreso.Focus()
        End Sub

        Private Sub chk_Homonimia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Homonimia.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub
        Private Sub btnIngreso_Click(sender As System.Object, e As System.EventArgs) Handles btnIngreso.Click
            FRM_MantIngreso(True)
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__MostrarResolucionesAclarados() Handles UscGrillaNombresAsociadosV21._MostrarResolucionesAclarados
            UscResolucionesMain1._ChekedValor = True
            TabControl1.SelectedIndex = 1
        End Sub

        Private Sub UscAlias21__ClickAdd() Handles UscAlias21._ClickAdd
            FRM_MantenimientoAlias(True, -1, False)
        End Sub

        Private Sub UscBandas21__DoubleClikBandas(Nuevo As System.Boolean, AliasID As System.Int32, IngresoID As System.Int32, BandentCol As Entity.Registro.InternoBandaCol, forzarRegistroSoloLectura As Boolean) Handles UscBandas21._DoubleClikBandas
            FRM_MantenimientoBandas(Nuevo, AliasID, IngresoID, BandentCol, forzarRegistroSoloLectura)
        End Sub



        Private Sub UscOdont__ClicK_Modificar(OdontogramaId As Integer) Handles UscOdont._ClicK_Modificar
            FRM_Odontograma(False, OdontogramaId)
        End Sub

        Private Sub UscOdont__Click_Nuevo() Handles UscOdont._Click_Nuevo
            FRM_Odontograma(True, -1)
        End Sub

        Private Sub UscClasificaciones1__Click_PrintFicha(Codigo As System.Int32, TipoFichaId As Type.Enumeracion.Clasificacion.enmTipoFicha)

            Dim frm As New APPReporte.Registro.ReporteCrystal

            With frm

                Select Case TipoFichaId
                    Case 1
                        ._TipoReporte = Type.Reporte.Registro.rptClasificacionFichaLegal
                    Case 2
                        ._TipoReporte = Type.Reporte.Registro.rptClasificacionFichaSocial
                    Case 3
                        ._TipoReporte = Type.Reporte.Registro.rptClasificacionFichaPsicologica
                    Case 4
                        ._TipoReporte = Type.Reporte.Registro.rptClasificacionFichaFinal
                End Select

                ._Filtro.RegionID = Me.idRegion
                ._Filtro.RegionNombre = Me.regionNombre
                ._Filtro.PenalID = Me.idPenal
                ._Filtro.PenalNombre = Me.penalNombre
                ._Filtro.InternoID = Me.idInterno
                ._Filtro.InternoFichaId = Codigo

                .ShowDialog()

            End With
        End Sub

        Private Sub UscMovimiento1__CellDoubleClick_UpdateMovimiento(MovimientoID As Integer, MovimientoGrupoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer, IngresoID As Integer, DocumentoJudID As Integer, Pendientes As Integer)
            FRM_Movimiento(MovimientoID, MovimientoGrupoID, MovimientoTipoID, MovimientoMotivoID, IngresoID, DocumentoJudID, Pendientes)
        End Sub

        Private Sub UscAlias21__ClickMod(AliasID As Integer, x As Integer, forzarRegistroSoloLectura As Boolean) Handles UscAlias21._ClickMod
            FRM_MantenimientoAlias(False, AliasID, forzarRegistroSoloLectura)
        End Sub

        Private Sub UscFamilias1__CellDoubleClick(IDFamilia As Integer, objEntFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean) Handles UscFamilias1._CellDoubleClick
            UscFamilias1__ClickModificar(IDFamilia, objEntFamCol, forzarRegistroSoloLectura)
        End Sub

        Private Sub UscFamilias1__ClickAdd(objEntFamCol As Entity.Registro.FamiliarCol) Handles UscFamilias1._ClickAdd
            FRM_Mant_Familia(True, -1, objEntFamCol, False)
        End Sub

        Private Sub UscFamilias1__ClickModificar(IDFamilia As Integer, objEntFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean) Handles UscFamilias1._ClickModificar
            FRM_Mant_Familia(False, IDFamilia, objEntFamCol, forzarRegistroSoloLectura)
        End Sub

        Private Sub TabControl2_Selecting(sender As Object, e As System.Windows.Forms.TabControlCancelEventArgs) Handles tcDatosInternos.Selecting

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

            If blnModificarDatos = True Then
                If MessageBox.Show("¿Desea guardar los datos del interno?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    blnModificarDatos = False
                    EnabledControles(True)
                Else
                    e.Cancel = True
                End If
            End If

        End Sub

        Private Sub UscResolucionesMain2__Click_BtnVerExpedientesPorResolucion(IdResolucion As System.Int32)
            FRM_ListadoExpediente()
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnNuevoResolucion_1(IngresoID As System.Int32, ResIngRegistrado As System.Boolean, Opcion As System.Int32) Handles UscResolucionesMain1._Click_BtnNuevoResolucion
            FRM_ListarResoluciones(IngresoID, ResIngRegistrado, Opcion)
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnModificarResolucion_1(TipoDocumento As System.Int32, DocJudicialId As System.Int32, SubTipo As System.Int32, _penid As System.Int32, Version As System.String) Handles UscResolucionesMain1._Click_BtnModificarResolucion
            FRM_Resolucion_Sentencia(TipoDocumento, DocJudicialId, SubTipo, Version)
        End Sub

        Private Sub UscMandatoDetencion__CellDoubleClick_GrillaExpediente(ExpedienteCodigo As System.Int32) Handles UscMandatoDetencion._CellDoubleClick_GrillaExpediente
            FRM_MantExpediente(False, ExpedienteCodigo)
        End Sub

        Private Sub UscMandatoDetencion__CellDoubleClick_GrillaDelito(IngresoCodigo As System.Int32, ExpedienteCodigo As System.Int32, DelitoCodigo As System.Int32) Handles UscMandatoDetencion._CellDoubleClick_GrillaDelito
            FRM_MantDelito(False, IngresoCodigo, ExpedienteCodigo, DelitoCodigo)
        End Sub

        Private Sub UscMandatoDetencion__CellDoubleClick_GrillaAgraviado(IngresoCodigo As System.Int32, ExpedienteCodigo As System.Int32, DelitoCodigo As System.Int32, AgraviadoCodigo As System.Int32) Handles UscMandatoDetencion._CellDoubleClick_GrillaAgraviado
            FRM_MantAgraviado(False, IngresoCodigo, ExpedienteCodigo, DelitoCodigo, AgraviadoCodigo)
        End Sub

        Private Sub UscMovimiento1__CellDoubleClick_UpdateMovimiento_1(MovimientoID As System.Int32, MovimientoGrupoID As System.Int32, MovimientoTipoID As System.Int32, MovimientoMotivoID As System.Int32, IngresoID As System.Int32, DocumentoJudID As System.Int32, Pendientes As System.Int32) Handles UscMovimiento1._CellDoubleClick_UpdateMovimiento
            FRM_Movimiento(MovimientoID, MovimientoGrupoID, MovimientoTipoID, MovimientoMotivoID, IngresoID, DocumentoJudID, Pendientes)
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnVerExpedientesPorResolucion_1(IdResolucion As System.Int32) Handles UscResolucionesMain1._Click_BtnVerExpedientesPorResolucion
            FRM_ListadoExpediente()
        End Sub

        Private Sub UscMovimiento1__Click_AddNuevoMovimiento_1(IngresoID As System.Int32, strMensaje As String) Handles UscMovimiento1._Click_AddNuevoMovimiento
            FRM_MovimientoTipo(IngresoID, strMensaje)
        End Sub

        Private Sub UscMovimiento1__Click_EliminarMovimiento_1() Handles UscMovimiento1._Click_EliminarMovimiento
            Me.UscMovimiento1._Listar()
            ListarCabecera()
        End Sub

        Private Sub TabControl3_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TabControl3.SelectedIndexChanged
            Select Case Me.TabControl3.SelectedTab.Name
                Case Me.tbpMovimientos.Name
                    UscMovimiento1._InternoID = Me.idInterno
                    UscMovimiento1._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                    UscMovimiento1._IngresoInpeID = Me.IDIngresoINPE
                    UscMovimiento1._NroIngresoID = Me.IDIngreso
                    UscMovimiento1._Listar()
                Case Me.tbpListaExpedientes.Name
                    Listar_Expedientes()
                    'Case Me.tbpFoto.Name
                    '    LoadUscFotografia()
            End Select

            HabilitarControlesAccion()
        End Sub
        Private Sub UscResolucionesMain1__Click_BtnEliminarActualizarEstadoInterno() Handles UscResolucionesMain1._Click_BtnEliminarActualizarEstadoInterno
            ListarCabecera()
            ListarData()
            UscGrillaNombresAsociadosV21._LoadUsc()
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__AnularNombreAsociado() Handles UscGrillaNombresAsociadosV21._AnularNombreAsociado
            UscGrillaNombresAsociadosV21._LoadUsc()
        End Sub

        Private Function DescargarDocJudicialesZXP(showAlerta As Boolean) As Boolean

            If Me.idPenal <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Región y penal.")
                Return False
            End If

            'If Me.CabeceraEstado = "INACTIVO" Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("No es posible completar la operación, interno se encuentra inactivo.")
            '    Return False
            'End If

            If Me._IDInternoSedeRowId = -1 Then 'xxx: cambiar el mensaje con respecto al codigo del interno sede rowid, ya que no existe en la sede central 
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no ha sido transferido a la sede central, intente nuevamente luego de algunos minutos.")
                Return False
            End If

            Dim ws As New APPWebService.ws_pope_sede_plm_carceleta.Carceleta
            ws.Timeout = Threading.Timeout.Infinite
            ws.Url = APPWebService.PathURL.ws_sede_plm_carceleta
            Try
                ws._test()
            Catch ex As Exception
                If showAlerta = True Then Legolas.Configuration.Aplication.MessageBox.Exclamation("En estos momentos el servicio de la Sede Central no está disponible, intente luego de unos instantes o solicite asistencia técnica.")
                Return False
            End Try

            Dim dts As DataSet
            'Dim bssDoc As New Bussines.Registro.DocumentoJudicial
            'Dim ultFecMod As Long = 0

            'ultFecMod = bssDoc.UltimFechacModificacionDocJudicial_LM(Me._IDInterno)

            dts = ws.ListarDocumentosZXP(Me._IDInternoSedeRowId, Me.idPenal)

            If dts Is Nothing Then Return False

            If dts.Tables.Count = 0 And showAlerta = True Then
                Legolas.Configuration.Aplication.MessageBox.Information("Por el momento el interno no cuenta datos disponibles para su descarga.")
                Return False
            End If

            Dim bss As New Bussines.Transferencia.ProcesaZXP(Me.idRegion, Me.idPenal)
            Dim outSMS As String = ""
            Dim v As Boolean = False

            v = bss.ProcesarDocumentosORL_ZXP(ws, dts, Me.idInterno, Me.IDIngresoINPE, outSMS)
            If v = False And showAlerta = True Then
                Type.LogSIP.getLog.ErrorCritico("ProcesarDataORL_ZXP", outSMS & " IdInterno = " & Me.idInterno)
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al procesar descarga de documentos, por favor solicite asistencia técnica." & Chr(13) &
                    outSMS)
                Return False
            End If

            'quitar columnas innecesarias para confirmar transferencia
            bss.LimpiarDocParaConfirmarZXP(dts)

            Dim rpt As APPWebService.ws_pope_sede_plm_carceleta.DTO_ResultOfBoolean
            rpt = ws.ConfirmarDescargaDataZXP(dts)

            If rpt.Error_cod = -1 And showAlerta = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Error: " & rpt.Error_Mensaje & ", por favor solicite asistencia técnica.")
            End If

            Return v
        End Function

        Private Sub UserAlias_LM1__DoubleClick(AliasID As Integer, IngresoID As Integer, forzarRegistroSoloLectura As Boolean) Handles UscAlias21._DoubleClick
            FRM_MantenimientoAlias(False, AliasID, forzarRegistroSoloLectura)
        End Sub

        Private Sub btnRefresh_Click(sender As Object, e As System.EventArgs) Handles btnRefresh.Click

            'Legolas.Configuration.Aplication.MessageBox.Exclamation("El servicio no esta disponible actualmente, coordine con Mesa de Ayuda Registro (helpdesk.registro@inpe.gob.pe)")
            'Exit Sub

            If Me.InternoEstado = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación cancelada, el estado del interno es inactivo.")
                Exit Sub
            End If

            ListarCabecera() 'en caso se haya transferido para obtener el SedeRowId del interno

            'abrir un hilo, para realizar la espera del usuario
            Me.SuspendLayout()

            Me.BackgroundWorker2.RunWorkerAsync()

            frmLoad = New Load.frmProcesando
            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackgroundWorker2.CancelAsync()
                Me.BackgroundWorker2.Dispose()
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()

        End Sub

        Private Sub cbbCodFuerArmada_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbCodFuerArmada.SelectedIndexChanged
            If blnComboFzaArm = True Then
                ComboRangoFuerzaArmada()
            End If
        End Sub

        Private Sub FRM_MantenimientoDocDigitalizado(ByVal Nuevo As Boolean, id As Integer)

            If Me.idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos básicos del interno")
                Me.tcDatosInternos.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me.IDIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresos.Focus()
                Exit Sub
            End If

        End Sub

        Private Sub UscBandas21__ClikBandas(Nuevo As System.Boolean, BandaID As System.Int32, n_IngresoInpeId As System.Int32, objEntColBandas_ As Entity.Registro.InternoBandaCol) Handles UscBandas21._ClikBandas
            FRM_MantenimientoBandas(Nuevo, BandaID, n_IngresoInpeId, objEntColBandas_, False) 'nuevo
        End Sub
        Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
            Else

                Dim strMensajeOut As String = ""
                Dim objBss As New Bussines.Registro.InternoRegularizacion(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno)
                e.Result = objBss.RegularizarDatosInterno(False, objEntFiltroRegula, strMensajeOut)

                'Dim strMensajeOut As String = ""
                'Dim objBss As New Bussines.Registro.InternoRegularizacion
                'value = objBss.RegularizarDatosInterno(objEntFiltro, strMensajeOut)      


                If e.Result = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                End If

                blnRegistroRegula = e.Result

            End If
        End Sub

        Private Sub BackgroundWorker1_Disposed(sender As Object, e As EventArgs) Handles BackgroundWorker1.Disposed

            If Me.BackgroundWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker1 = Nothing
                Me.Close()
            End If

        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()
                result = e.Result
            End If

            ListarCabecera()

        End Sub
        Private Sub UscGrilletes1__ClickAdd()
            FRM_Mant_Grilletes(True, -1, Nothing)
        End Sub
        Private Sub UscVisorDocDigital1__Click_Add()
            FRM_MantenimientoDocDigitalizado(True, -1)
        End Sub
        Private Sub UscVisorDocDigital1__ClicK_Modificar(Codigo As System.Int32)
            FRM_MantenimientoDocDigitalizado(False, Codigo)
        End Sub

        Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker2.CancellationPending = True Then
                e.Cancel = True
            Else

                Dim blnOperacion As Boolean = False
                Dim strMensajeOut As String = ""

                blnOperacion = DescargarDocJudicialesZXP(True)

                If blnOperacion = True Then
                    e.Result = True
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                End If

            End If

        End Sub

        Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted

            Dim result As Boolean = False

            'la operaciodn fue ok
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()
                result = e.Result

                ComboNumIngreso()

                ListarCabecera() 'en caso se haya transferido para obtener el SedeRowId del interno
                UscMandatoDetencion._ListarExpediente()
                UscResolucionesMain1._Listar()
            End If

        End Sub

        Private Sub BackgroundWorker2_Disposed(sender As Object, e As EventArgs) Handles BackgroundWorker2.Disposed

            If Me.BackgroundWorker2.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario canceló el proceso")
                Me.BackgroundWorker2 = Nothing
                Me.Close()
            End If

        End Sub

        Private Sub btnActInactivar_Click(sender As Object, e As EventArgs)

            'If Me.CabeceraEstado = "INACTIVO" Then
            '    If MsgBox("Opción válida solo si el interno se encuentra fisicamente en el penal lo cual cambiará el estado a activo y no genera ningún tipo de movimiento, desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            '        Dim bss As New Bussines.Registro.Interno
            '        bss.ActivarEstado_LM(Me._IDInterno, 0) 'baja
            '        Legolas.Configuration.Aplication.MessageBox.Information("Operación satisfactoria, vuelva a cargar los datos del interno.")
            '        Me.Close()
            '    End If
            'Else 'pendiente para inactivar interno.

            'End If
        End Sub

        Private Sub UscMovimiento1_Load(sender As Object, e As EventArgs) Handles UscMovimiento1.Load

        End Sub

        Private Sub UscMandatoDetencion_Load(sender As Object, e As EventArgs) Handles UscMandatoDetencion.Load

        End Sub
        Private Sub btnDelitosHistoricos_Click(sender As Object, e As EventArgs) Handles btnDelitosHistoricos.Click
            ListarDelitosMayorPena()
        End Sub
        Private Sub ListarDelitosMayorPena()
            Dim frm As New Registro.frmListaDelitosHistoricos
            frm._InternoID = Me.idInterno
            frm._InternoIngresoID = -1
            frm._IngresoInpeID = Me.IDIngresoINPE
            frm.ShowDialog()
        End Sub

        Private Sub cbbPertenenciaEtnica__SelectedIndexChanged()
            ' ComboPerteneciaEtnicaAuxiliar()
        End Sub

        Private Sub cbbLenguaMaterna__SelectedIndexChanged()
            'ComboLenguaMaternaAuxiliar()
        End Sub

        Private Sub UscBandas21__DoubleClikBandas(Nuevo As Integer, AliasID As Integer, n_IngresoInpeId As Integer, objEntColBandas_ As Entity.Registro.InternoBandaCol, forzarRegistroSoloLectura As Boolean) Handles UscBandas21._DoubleClikBandas

        End Sub

        Private Sub UscInternoDetalle1__click_VerReporte(idCodigo As Integer, estado As Short) Handles UscInternoDetalle1._Click_Imprimir

            frmVerReporteConstanciaReclusion(idCodigo, estado)

        End Sub

        Private Sub tcMovimientos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMovimientos.SelectedIndexChanged

            Select Case Me.tcMovimientos.SelectedTab.Name
                Case Me.tbMovInterno.Name
                    ListarMovimientosIngreso()

                Case Me.tbConstanciaReclu.Name
                    listarGrillaConstanciaReclusion()

            End Select

        End Sub

        Private Sub UscInternoDetalle1__CellDoubleClick_Modificar(idTramite As Integer) Handles UscInternoDetalle1._CellDoubleClick_Modificar
            frmConstanciaResluMant(False, idTramite)
        End Sub

        Private Sub UscInternoDetalle1__Click_Modificar(idTramite As Integer) Handles UscInternoDetalle1._Click_Modificar
            frmConstanciaResluMant(False, idTramite)
        End Sub

        Private Sub UscInternoDetalle1__Click_Nuevo() Handles UscInternoDetalle1._Click_Nuevo
            frmConstanciaResluMant(True, -1)
        End Sub

        Private Sub btnanterior_Click(sender As Object, e As EventArgs) Handles btnanterior.Click
            UscOdont.Visible = True
            UscOdotoNew1.Visible = False
            btnanterior.Enabled = False
            btnsiguiente.Enabled = True

        End Sub

        Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
            UscOdont.Visible = False
            UscOdotoNew1.Visible = True
            btnanterior.Enabled = True
            btnsiguiente.Enabled = False

        End Sub

        'Private Sub UscClasificaciones1__Click_FichaDetalle(EntFichaDet As Entity.Clasificacion.Documento.DatosFicha) Handles UscClasificaciones1._Click_FichaDetalle
        '    FRM_Clasificacion(EntFichaDet)
        'End Sub

        'Private Sub TabControl4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl4.SelectedIndexChanged
        '    Dim intValorEtapa As Integer = UscClasificaciones1.EtapaInternoId()
        '    If intValorEtapa < 1 Then
        '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Registrar primero la Etapa del Interno, para poder realizar la ubicacion del pabellon.")
        '    End If
        '    Select Case Me.TabControl4.SelectedTab.Name
        '        Case Me.tbpPabellon.Name
        '            With UscClasificaciones2
        '                ._TipoFichaUsc = Type.Enumeracion.Clasificacion.enmGrupoClasificacion.ClasificacionPenales
        '                .LoadUsc()
        '                .ConfigurarClasificacion(UscClasificaciones1.RegimenPenalId, intValorEtapa, UscClasificaciones1.SitucionJuridicaId)
        '                ._VisibleGrabar = Me._FormEscritura
        '                ._VisibleEliminar = Me._FormEliminar
        '                ._VisibleImprimir = Me._FormImpresion
        '            End With
        '    End Select
        'End Sub

        'Private Sub UscClasificaciones2__Click_FichaDetalle(EntFichaDet As Entity.Clasificacion.Documento.DatosFicha) Handles UscClasificaciones2._Click_FichaDetalle
        '    FRM_Clasificacion(EntFichaDet)
        'End Sub

        'Private Sub UscClasificaciones1__Click_btn_Formato06(FichaId As Integer, variableIndicador As String, escritura As Boolean) Handles UscClasificaciones1._Click_btn_Formato06
        '    Dim f As New Registro.Carceleta.Clasificacion.frmEditorTextPopup
        '    With f
        '        ._IdFicha = FichaId
        '        ._FormEscritura = escritura 'pendientehntb asignar permiso UscVisorDocDigital1._VisibleGrabar
        '        ._FormEliminar = escritura 'UscVisorDocDigital1._VisibleEliminar
        '        ._VariableIndicador = variableIndicador
        '        If .ShowDialog = Windows.Forms.DialogResult.OK Then

        '        End If
        '    End With
        'End Sub
    End Class
End Namespace
