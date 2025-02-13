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
Imports APPControls.Tratamiento.Asistencia.Clasificacion.Penal
Imports Type

Namespace Tratamiento.Asistencia.Clasificacion.Penal

    Public Class frmMantClasifPenalLM
        Public _frmLectura As Boolean = False
        Public _frmEscritura As Boolean = False
        Public _frmReporte As Boolean = False
        Public _frmImpresion As Boolean = False
        Public _frmEliminar As Boolean = False

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


        Private Property InternoEstado() As Integer = -1

        Private Property DocumentoTipo As Integer = -1


        Private NumeroDocumentoAux As String = ""
        Private InternoApePaternoAux As String = ""
        Private InternoApeMaternoAux As String = ""
        Private InternoNombresAux As String = ""


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

        End Sub

        Private Sub ListarDataInterno(objEnt As Entity.Registro.Interno, Optional ValidarIDInterno As Boolean = True)
            If ValidarIDInterno = True Then
                If Me.idInterno < 1 Then Exit Sub
            End If

            With objEnt
                '/*datos generales*/
                If ValidarIDInterno = True Then Me.CodigoRPInterno = .CodigoRP

                Me._IDInternoSedeRowId = .SedeRowId
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
                Me.IDNacionalidad = .NacionalidadID

                '/*ubigeo nacimiento*/
                Me.Pais = .NacimientoPaisID
                Me.UbigeoNacimiento = .NacimientoUbigeoID
                Me.UbigeoNacimientoOtros = .NacimientoOtros
                '/*ubigeo domicilio*/

                '/*datos complementarios*/
                Me.InternoApePaternoAux = Me.InternoApePaterno
                Me.InternoApeMaternoAux = Me.InternoApeMaterno
                Me.InternoNombresAux = Me.InternoNombres

                'Me.CodigoUnicoInterno = .CodigoUnicoInterno

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

            EnabledControles(True)

        End Sub

        Private Sub ListarInternoHistorico(objEnt As Entity.Registro.InternoHistorico)
            If Me.idInterno < 1 Or Me.IDIngreso < 1 Then Exit Sub

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
                Me.IDNacionalidad = .NacionalidadID
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

        Private Sub ListarDatosComplementarios()
            If Me.idInterno < 1 Then
                Me.txtRegionPenal.Text = Me.RegionPenalNombre
                Exit Sub
            End If

            EnabledControles(True)

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
                .MostrarGrillaRasgo(False)
                .MostrarGrillaSeniaParticular(False)
                .LoadUsc()
                uscFotoPerfiles.DataGrieView_Click()
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

#End Region
#End Region
#Region "Listar_UserControl_Clasificacion"

        Private Sub ListarClasificacionRegimen()

            If Me.idInterno < 1 Then Exit Sub

            With Me.UscFichaClasificacion1
                ._IDInterno = Me.idInterno
                ._InternoApeNom = Me.InternoApeyNom
                ._IDIngreso = Me.IDIngreso
                ._IDIngresoInpe = Me.IDIngresoINPE
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
                ._IDIngreso = Me.IDIngreso
                ._IDIngresoInpe = Me.IDIngresoINPE
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
                ._IDIngreso = Me.IDIngreso
                ._IDIngresoInpe = Me.IDIngresoINPE
                ._IDRegion = Me.idRegion
                ._IDPenal = Me.idPenal

                'permisos
                ._uscPerfilUsuario = Legolas.Configuration.Usuario.OficinaID
                ._ListarUsc()
            End With

        End Sub

        Private Sub ListarClasificacionEtapa()

            If Me.idInterno < 1 Then Exit Sub

            With Me.UscFichaClasificacionEtapaLM1
                ._IDInterno = Me.idInterno
                ._InternoApeNom = Me.InternoApeyNom
                ._IDIngreso = Me.IDIngreso
                ._IDIngresoInpe = Me.IDIngresoINPE
                ._IDRegion = Me.idRegion
                ._IDPenal = Me.idPenal
                'permisos
                ._uscPerfilUsuario = Legolas.Configuration.Usuario.OficinaID
                ._uscFichaTab = APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionRegimen.EnmFichaTab.enmEtapa
                ._LoadUsc()
            End With

        End Sub

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


            Return blnValue
        End Function

        Private Sub EnabledControles(Valor As Boolean)

            Select Case Me.tcDatosInternos.SelectedTab.Name

                Case Me.tbpDatos.Name 'datos
                    'Me.txtCodIntUnico.ReadOnly = Valor
                    Me.txtApePat.ReadOnly = Valor
                    Me.txtApeMat.ReadOnly = Valor
                    Me.txtNom.ReadOnly = Valor
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

            'habilitar/ deshabilitar los controles 
            If Me._IDInternoSedeRowId > 0 Then 'comentado 12/02/2019 04:21 pm coordinacion GVA
                Me.txtApePat.Enabled = False
                Me.txtApeMat.Enabled = False
                Me.txtNom.Enabled = False
            End If

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

            Dim frm As New Registro.PenalLM.Identificacion.frmIngresoPopup_V2
            With frm
                ._IDInterno = Me.idInterno
                ._InternoSedeRowId = Me._IDInternoSedeRowId
                ._IDRegion = Me.idRegion
                ._IDPenal = Me.idPenal
                ._AgregarNuevoIngreso = NuevoIngreso
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False


                If .ShowDialog = DialogResult.OK Then

                    'cargar numero de ingresoINPE
                    ComboNumIngreso()

                    Me.TabControl1.SelectTab(Me.tbpInterno)
                    Me.tcDatosInternos.SelectTab(Me.tbpDatos)
                    ListarData()

                End If

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
                End If


            End With
        End Sub


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


#End Region
#Region "Expediente"

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

        Private Sub FRM_Resolucion_Sentencia(TipoResolucion As System.Int32, IDDocumentoJudicial As System.Int32, SubTipo As Integer)

            Select Case TipoResolucion
                Case enumTipoDocumentoJudicial.Libertad
                    FRM_Resolucion_Libertad(IDDocumentoJudicial, SubTipo)
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental,
                     enumTipoDocumentoJudicial.Retorno_de_HospitalMental
                    FRM_Orden_Traslado(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()
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
                    FRM_Resol_Sentencia(IDDocumentoJudicial)
                    ListarCabecera()
                    'Case enumTipoDocumentoJudicial.Sentencia_Aclaratoria
                    '    FRM_Resol_SentenciaAclaratoria(IDDocumentoJudicial)
                    '    ListarCabecera()
                Case enumTipoDocumentoJudicial.Integracion_Sentencia, enumTipoDocumentoJudicial.Refundicion_de_Sentencia, enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                    FRM_Resol_IntegracionSentencia(IDDocumentoJudicial, TipoResolucion)

                Case enumTipoDocumentoJudicial.Sentencia_Aclaratoria, enumTipoDocumentoJudicial.Sent_Adecuacion_Pena,
                     enumTipoDocumentoJudicial.Sent_Conmutacion_Pena, enumTipoDocumentoJudicial.Sent_Sustitucion_Pena,
                     enumTipoDocumentoJudicial.ResolucionConsentida, enumTipoDocumentoJudicial.Resolucion,
                     enumTipoDocumentoJudicial.Resolucion_Superior,
                      enumTipoDocumentoJudicial.Ejecutoria_Superior, enumTipoDocumentoJudicial.Ejecutoria_Suprema

                    FRM_Resol_SentenciaMultiple(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()

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
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

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
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

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
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    UscResolucionesMain1._Listar()
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
                        ._FormEscritura = False
                        ._FormEliminar = False
                        ._FormReporte = False
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
                        ._FormEscritura = False
                        ._FormEliminar = False
                        ._FormReporte = False
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
                        ._FormEscritura = False
                        ._FormEliminar = False
                        ._FormReporte = False
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
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

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

                    ListarCabecera()
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


#End Region


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
                            UscFichaClasificacionEtapaLM1._ListarFilaVariable(._ValorPuntaje, .ValorNombreSeleccionado, .ValorIdSeleccionado, ._ValorNoPrevisto)
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
                ._Filtro.InternoIngresoID = -1 ' Me.IDIngreso
                ._Filtro.IngresoInpeId = Me.IDIngresoINPE
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
#Region "Permisos_Usuario"
        Private Sub Usuario_Permisos()
            Dim intLicenciaID As Integer = Me.IDLicencia
            Dim intTipoLicencia As Short = -1
            Dim blnBuscarLicenciaPenalEscritura As Boolean = False
            intTipoLicencia = (New Bussines.Sistema.Instalacion).ListarTipo(intLicenciaID)
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


            '/*fotografia*/
            Me.uscFotoPerfiles._VisibleGrabar = Me._FormEscritura
            Me.uscFotoPerfiles._VisibleEliminar = Me._FormEliminar

            '/*reniec*/

            '/*organizacion criminal*/
            Me.UscOrganizacionCriminal._VisibleGrabar = False 'Me._FormEscritura
            Me.UscOrganizacionCriminal._VisibleEliminar = False ' Me._FormEliminar

            '/*resolucion*/
            Me.UscResolucionesMain1._VisibleGrabar = False ' Me._FormEscritura
            Me.UscResolucionesMain1._VisibleEliminar = False ' Me._FormEliminar
            Me.UscResolucionesMain1.MostrarBotonOcultaDetExp(False)

            If Legolas.Configuration.Usuario.NivelUsuario = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or
                Legolas.Configuration.Usuario.NivelUsuario = Type.Enumeracion.Licencia.enmTipoLicencia.Sede Then
                Usuario_Permisos_Perfil()
            End If

            Dim blnLecturaTratamiento As Boolean = Permisos._FormLecturaTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            Dim blnEscrituraTratamiento As Boolean = Permisos._FormEscrituraTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)
            Dim blnReporteTratamiento As Boolean = Permisos._FormReporteTratamiento(intLicenciaID, intTipoLicencia, Legolas.Configuration.Usuario.OficinaID)

            With Me.UscFichaClasificacion1
                ._uscEscritura = blnEscrituraTratamiento
                ._uscReporte = blnReporteTratamiento

            End With

            With Me.UscFichaClasificacionEtapaLM1
                ._uscEscritura = blnEscrituraTratamiento
                ._uscReporte = blnReporteTratamiento
            End With

            UscFichaPorRegresion1._uscEscritura = Me._frmEscritura
            UscFichaPorRegresion1._uscLectura = Me._frmLectura
            UscFichaPorRegresion1._uscReporte = Me._frmReporte

            UscFichaClasifTraslado1._uscEscritura = Me._frmEscritura
            UscFichaClasifTraslado1._uscLectura = Me._frmLectura
            UscFichaClasifTraslado1._uscReporte = Me._frmReporte

            Dim intPerfil As Type.Enumeracion.Usuario.EnumDependencia
            intPerfil = Legolas.Configuration.Usuario.OficinaID
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

            TabControl1.TabPages.Remove(tbpMandDet)
        End Sub
        Private Sub Usuario_Permisos_Perfil()

            If Me.PerfilUsuario <> EnumDependencia.RegistroPenitenciario Then
                Me.uscFotoPerfiles._VisibleGrabar = False
                Me.uscFotoPerfiles._VisibleEliminar = False

                Me.UscOrganizacionCriminal._VisibleGrabar = False
                Me.UscOrganizacionCriminal._VisibleEliminar = False

                Me.UscResolucionesMain1._VisibleGrabar = False
                Me.UscResolucionesMain1._VisibleEliminar = False

                Me.pnlAuditoria.Visible = False

            End If

            Select Case Me.PerfilUsuario


                Case EnumDependencia.RegistroPenitenciario
                    UscResolucionesMain1.Visible = True

                Case EnumDependencia.SeguridadPenitenciaria

                    tcDatosInternos.TabPages.Remove(tbpBandas)
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

            Dim frmValidacion As New Registro.Reniec.frmTipoValidacionV2
            With frmValidacion
                ._InternoID = Me.idInterno
                ._IngresoInpeID = Me.IDIngresoINPE
                '._NroIngresoID = Me.IDIngreso

                ._TipoDocumento = Me.TipoDocumento
                ._NumeroDocumento = Me.NumeroDocumento
                ._Estado = Me.InternoEstado
                ._RegionID = Me.idRegion
                ._PenalID = Me.idPenal
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana

                ._ApellidoPaterno = objEntInt.ApellidoPaterno
                ._ApellidoMaterno = objEntInt.ApellidoMaterno
                ._Nombres = objEntInt.Nombres
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ListarData()
                End If

            End With

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

                        Case Me.tbpFoto.Name  'foto
                            blnVisibleGrabarDatos = False
                            blnVisibleNuevoReniec = False
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
            Me.IDNacionalidad = 141    '141 peruana
            Me.Pais = -1    '85 peru
            Me.Sexo = -1
            Me.EstadoCivil = -1
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

                If objEntComboIngCol.Count < 1 Then
                    ComboNumIngreso() 'volver ha cargar el combo de ingreso una vez regularizado el dato
                End If

                Me.TabControl1.Enabled = True
                Me.tcDatosInternos.Enabled = True

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

        Private Sub cbbDomicilioProv_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End Sub

        Private Sub cbbDomicilioDepa_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
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
                Case Me.tbpClasificacion.Name
                    ListarClasificacionRegimen()
                Case Me.tbpMandDet.Name
                    ListarResoluciones()

            End Select

            HabilitarControlesAccion()
        End Sub

        Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcDatosInternos.SelectedIndexChanged
            Select Case Me.tcDatosInternos.SelectedTab.Name
                Case Me.tbpDatos.Name
                    If blnModificarDatos = False Then
                        ListarData()
                    End If
                Case Me.tbpFoto.Name
                    LoadUscFotografia()

                Case Me.tbpBandas.Name
                    LoadUscOrganizacionCriminal()

                    'Case Me.tbpDocDigitalizados.Name
                    '    LoadUscDocumentoDigitalizado()
            End Select
            HabilitarControlesAccion()
        End Sub


        Private Sub chkNoindica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNoindica.Click
            HabilitarTipoDocumento()
        End Sub

        Private blnCheck As Boolean = False


        Private Sub txtNom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
            If e.KeyChar = "." Then e.Handled = True
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



                uscFotoPerfiles.DataGrieView_Click()
            End If

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


        End Sub

        Private Sub btnAddIngreso_Click(sender As System.Object, e As System.EventArgs) Handles btnAddIngreso.Click
            Me.NuevoClickfrmIngreso = False
            FRM_MantIngreso(False)

        End Sub

        Private Sub uscFotoPerfiles__Clik_MantenimientoFotos(InternoFotId As System.Int32, RestringirEdicion As Boolean) Handles uscFotoPerfiles._Clik_MantFotos
            FRM_Mant_Fotos(InternoFotId, RestringirEdicion)
        End Sub



        Private Sub UscValidacionReniecV21__DoubleClick_CargarDetalle(objEntRnc As Entity.Registro.InternoReniec)
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

        Private Sub cbbDomicilioDist_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub cbbNivelAca_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub cbbProfesion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End Sub

        Private Sub cbbOcupacion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End Sub

        Private Sub UscValidacionReniecV21__DoubleClick_CargarDetalleNomAso(objEntRnc As Entity.Registro.NombreAsociadoCol)
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

        Private Sub UscGrillaNombresAsociadosV21__Clik_btnIngresofocus()
            Me.btnAddIngreso.Focus()
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
        Private Sub btnIngreso_Click(sender As System.Object, e As System.EventArgs)
            FRM_MantIngreso(True)
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__MostrarResolucionesAclarados()
            UscResolucionesMain1._ChekedValor = True
            TabControl1.SelectedIndex = 1
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

        Private Sub UscResolucionesMain2__Click_BtnVerExpedientesPorResolucion(IdResolucion As System.Int32)
            FRM_ListadoExpediente()
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnNuevoResolucion_1(IngresoID As System.Int32, ResIngRegistrado As System.Boolean, Opcion As System.Int32) Handles UscResolucionesMain1._Click_BtnNuevoResolucion
            FRM_ListarResoluciones(IngresoID, ResIngRegistrado, Opcion)
        End Sub




        Private Sub UscResolucionesMain1__Click_BtnVerExpedientesPorResolucion_1(IdResolucion As System.Int32) Handles UscResolucionesMain1._Click_BtnVerExpedientesPorResolucion
            FRM_ListadoExpediente()
        End Sub

        Private Sub UscMovimiento1__Click_AddNuevoMovimiento_1(IngresoID As System.Int32, strMensaje As String)
            FRM_MovimientoTipo(IngresoID, strMensaje)
        End Sub

        Private Sub UscMovimiento1__Click_EliminarMovimiento_1()

            ListarCabecera()
        End Sub


        Private Sub UscResolucionesMain1__Click_BtnEliminarActualizarEstadoInterno() Handles UscResolucionesMain1._Click_BtnEliminarActualizarEstadoInterno
            ListarCabecera()
            ListarData()
        End Sub


        Private Function DescargarDocJudicialesZXP(showAlerta As Boolean) As Boolean

            If Me.idPenal <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Región y penal.")
                Return False
            End If

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


        Private Sub UscBandas21__ClikBandas(Nuevo As System.Boolean, BandaID As System.Int32, n_IngresoInpeId As System.Int32, objEntColBandas_ As Entity.Registro.InternoBandaCol)
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

        Private Sub btnDelitosHistoricos_Click(sender As Object, e As EventArgs)
            ListarDelitosMayorPena()
        End Sub
        Private Sub ListarDelitosMayorPena()
            Dim frm As New Registro.frmListaDelitosHistoricos
            frm._InternoID = Me.idInterno
            frm._InternoIngresoID = -1
            frm._IngresoInpeID = Me.IDIngresoINPE
            frm.ShowDialog()
        End Sub

        Private Sub btnanterior_Click(sender As Object, e As EventArgs) Handles btnanterior.Click
            UscOdotoNew1.Visible = False
            btnanterior.Enabled = False
            btnsiguiente.Enabled = True

        End Sub

        Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
            UscOdotoNew1.Visible = True
            btnanterior.Enabled = True
            btnsiguiente.Enabled = False

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




        Private Sub UscFichaClasificacion1_GrillaFicha_CellEnter(intCodigo As Integer, TipoTablaAudit As Type.Enumeracion.Auditoria.EnumTipTabla) Handles UscFichaClasificacion1.GrillaFicha_CellEnter
            Me.UscAuditUser1.LoadAudit(intCodigo, TipoTablaAudit)
        End Sub

        Private Sub UscFichaClasificacion2__GrillaFichaVariable_CellClick(objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.DatosFicha) Handles UscFichaClasificacionEtapaLM1.GrillaFichaVariable_CellClick
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

        Private Sub UscFichaClasificacion1__Reporte_Click(intIDInternoFichaFinal As Integer, objFichaTab As uscFichaClasificacionRegimen.EnmFichaTab) Handles UscFichaClasificacion1.Reporte_Click
            FRM_ReporteClasificacion(intIDInternoFichaFinal, objFichaTab)
        End Sub
        Private Sub UscFichaClasificacion2__Reporte_Click(intIDInternoFichaFinal As Integer, objFichaTab As uscFichaClasificacionRegimen.EnmFichaTab) Handles UscFichaClasificacionEtapaLM1.Reporte_Click
            FRM_ReporteClasificacion(intIDInternoFichaFinal, objFichaTab)
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
                ._Filtro.InternoIngresoID = -1
                ._Filtro.IngresoInpeId = Me.IDIngresoINPE

                ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionPorTraslado

                .ShowDialog()
            End With
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
                ._Filtro.InternoIngresoID = -1
                ._Filtro.IngresoInpeId = Me.IDIngresoINPE

                ._TipoReporte = Type.Reporte.Tratamiento.Trabajo.TallerAsistencia.rpt_ClasificacionPorRegresion

                .ShowDialog()
            End With
        End Sub

        Private Sub UscResolucionesMain1_Load(sender As Object, e As EventArgs) Handles UscResolucionesMain1.Load

        End Sub

        Private Sub UscResolucionesMain1__Click_BtnModificarResolucion(TipoDocumento As Integer, DocJudicialId As Integer, SubTipo As Integer, _penId As Integer, Version As String) Handles UscResolucionesMain1._Click_BtnModificarResolucion
            FRM_Resolucion_Sentencia(TipoDocumento, DocJudicialId, SubTipo)
        End Sub
    End Class
End Namespace
