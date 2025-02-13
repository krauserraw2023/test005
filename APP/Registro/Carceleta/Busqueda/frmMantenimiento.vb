'version del form3
Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.TipoDocJudicial
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Type.Enumeracion.Usuario
Imports Type.Enumeracion.Licencia
Imports DataClass
Imports System.Data.Linq
Imports System.Linq
Imports APPControls
Imports Legolas.APPUIComponents

Namespace Registro.Main.Carceleta
    Public Class frmMantenimiento
        Private objBssInterno As Bussines.Registro.Interno = Nothing
        Private objBssIngreso As Bussines.Registro.Ingreso = Nothing
        Private objBssInpe As Bussines.Registro.IngresoInpe = Nothing
        Private objBssHistorico As Bussines.Registro.InternoHistorico

        Private objEntColAlias As Entity.Registro.InternoAliasCol = Nothing
        Private objEntColFam As Entity.Registro.FamiliarCol = Nothing
        Private objBssInternoRnc As Bussines.Registro.InternoReniec = Nothing
        Private objEntInt As Entity.Registro.Interno = Nothing

        Private blnModificarDatos As Boolean = False
        Private PerfilUsuarioActual As Type.Enumeracion.Usuario.EnumDependencia
        'El 'tipo de documento' y 'numero de documento' pertenece a otro interno.
        Private formCargaCompletado As Boolean = False
        Private objEntIngresoInpeCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
        Private objOdontoInterno As New Entity.Registro.Odontograma.InternoOdontograma
        'Dim ouscodontonew As New uscOdotoNew


#Region "Propiedades_Publicas"
        Public Property _IDInternoSeleccionado As Long = -1
#End Region
#Region "Propiedades_Interno"

        Public Property _IDInterno As Integer = -1
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
                Try
                    lblEdad.Text = Legolas.Components.FechaHora.FechaCalcularAnio(value, Legolas.Configuration.Aplication.FechayHora.FechaLong, True)
                Catch ex As Exception

                End Try
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
        Dim n_InternoEstado As Integer = -1
        Private Property InternoEstado() As Integer
            Get
                Return n_InternoEstado
            End Get
            Set(value As Integer)
                n_InternoEstado = value
            End Set
        End Property
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

        'Private Property PabellonID() As Integer
        '    Get
        '        Return Me.cbbPabellon.SelectedValue
        '    End Get
        '    Set(ByVal value As Integer)
        '        Me.cbbPabellon.SelectedValue = value
        '    End Set
        'End Property

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
        'Private Property ProfesionOtros() As String
        '    Get
        '        Return Me.txtProfesionOtros.Text.Trim
        '    End Get
        '    Set(ByVal value As String)
        '        Me.txtProfesionOtros.Text = value
        '    End Set
        'End Property
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
        'Private Property OcupacionOtros() As String
        '    Get
        '        Return Me.txtOcupacionOtros.Text.Trim
        '    End Get
        '    Set(ByVal value As String)
        '        Me.txtOcupacionOtros.Text = value
        '    End Set
        'End Property
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
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public ReadOnly Property RegionPenalNombre() As String
            Get
                Dim value As String = ""
                value = Me.RegionNombre & "-" & Me.PenalNombre
                Return value
            End Get
        End Property
        Private n_penId As Integer = -1
        Public Property PenalID() As Integer
            Get
                Return n_penId
            End Get
            Set(value As Integer)
                n_penId = value
            End Set
        End Property
        Public Property PenalNombre() As String = ""
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

        Private _idIngId As Integer = -1
        Public Property _IDIngreso() As Integer
            Get
                Return _idIngId
            End Get
            Set(value As Integer)
                _idIngId = value
            End Set
        End Property

        Private ReadOnly Property IDLicencia As Integer
            Get
                Return Legolas.LBusiness.Globall.WinApp.LicenciaApp
            End Get
        End Property

        Public ReadOnly Property _IDIngresoINPE() As Integer
            Get
                Try
                    Dim value As Integer = -1
                    value = Me.cbbNroIngresoInpe.SelectedValue
                    If value = 0 Then
                        value = -1
                    End If
                    Return value
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property

        Private Property FuerzaArmada() As Integer
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
        Private Property RangoFueraArmada() As Integer
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
#End Region
#Region "Combo"
        Private blnComboDep As Boolean = False
        Private blnComboProv As Boolean = False
        Private blnComboDomDep As Boolean = False
        Private blnComboDomProv As Boolean = False
        Private blnPais As Boolean = False
        Private blnComboComAnd As Boolean = False
        Private blnComboFzaArm As Boolean = False
        'Private blnComboRangFzaArm As Boolean = False

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

            blnComboComAnd = True

        End Sub
        Public ValorIngreso As Boolean = False
        Public ValorIngreso0 As Boolean = False
        Private blnComboIngreso As Boolean = False
        Public Sub ComboNumIngresoINPE()

            blnComboIngreso = False

            If Me._IDInterno < 1 Then
                Exit Sub
            End If

            objBssInpe = New Bussines.Registro.IngresoInpe
            objEntIngresoInpeCol = objBssInpe.ListarNroIngreso(Me._IDInterno, 3)
            If objEntIngresoInpeCol.Count > 0 Then
                Dim listDelete As New List(Of Integer)
                'listar los ingresosInpe de otros penales para excluir
                For i As Integer = 0 To objEntIngresoInpeCol.Count - 1
                    If objEntIngresoInpeCol.Item(i).PenalID <> Me.PenalID Then
                        listDelete.Add(objEntIngresoInpeCol.Item(i).Codigo)
                    End If
                Next
                'quitar los ingresoInpe de los demas penales
                For Each elemento As Integer In listDelete
                    For i As Integer = 0 To objEntIngresoInpeCol.Count - 1
                        If objEntIngresoInpeCol.Item(i).Codigo = elemento Then
                            objEntIngresoInpeCol.RemoveAt(i)
                            Exit For
                        End If
                    Next
                Next

                'artificio, cargar el ultimo ingresoId por cada IngresoInpe y asociarlo al mismo objeto
                For Each obj As Entity.Registro.IngresoInpe In objEntIngresoInpeCol
                    Dim entIng As New Entity.Registro.Ingreso
                    Dim entIngcol As Entity.EntityCol(Of Entity.Registro.Ingreso)
                    entIng.PenalID = Me.PenalID
                    entIng.IngresoInpeId = obj.Codigo
                    entIngcol = (New Bussines.Registro.Ingreso).Listar_LM(entIng)
                    obj.IDIngreso = entIngcol.Item(0).Codigo
                Next
            End If
            objEntIngresoInpeCol.Sort("IngresoNro", Entity.SortDirection.Desc)
            With Me.cbbNroIngresoInpe
                .DataSource = objEntIngresoInpeCol
                .DisplayMember = "IngresoNroLetra"
                .ValueMember = "Codigo"
            End With

            If objEntIngresoInpeCol.Count > 0 Then
                Me._IDIngreso = objEntIngresoInpeCol.Item(0).IDIngreso
            Else
                Me._IDIngreso = -1
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
                .DataSource = objBss.Listar(Type.Combo.ComboTipo.RangoMilitar, Me.FuerzaArmada)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
        End Sub

        'Private Sub ComboPabellon()

        '    'pabellon
        '    Me.cbbPabellon.CodigoPadre = Me.PenalID
        '    Me.cbbPabellon.LoadUsc()

        'End Sub
#End Region
#Region "Validar"
        Public Sub ValidarDuplicadosIngreso()

            If Me._IDInterno < 1 Then
                Exit Sub
            End If

            Dim blnNumIngreDuplicado As Boolean = False
            Dim blnIngreso0 As Boolean = False
            Dim blnEliminarTab As Boolean = False

            Dim objBssIngresoInpe As New Bussines.Registro.IngresoInpe

            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
            'objEntCol = objBssIngresoInpe.ComboPLM(Me._IDInterno, Me._IDPenal)

            objEntCol = objBssInpe.ListarNroIngreso(Me._IDInterno, 3)
            'objEntIngresoInpeCol = (New Bussines.Registro.IngresoInpe).ListarNroIngreso(Me._IDInterno)



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
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("Tenga en cuenta que existe N° de ingresos duplicados, por lo que " +
                '                                                        " se recomienda verificar el ingreso seleccionado en función a la fecha.")

                If blnNumIngreDuplicado = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados y Nº de ingreso [0]." + Chr(13) +
                                                                    "Debe regularizar para poder realizar una operación," + Chr(13) +
                                                                    "Ir a la lista de ingresos.")
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un Nº de ingreso [0]." + Chr(13) +
                                                                        "Debe regularizar para poder realizar una operación," + Chr(13) +
                                                                        "Ir a la lista de ingresos.")
                End If
                'blnEliminarTab = True
            End If

            If blnNumIngreDuplicado = True Then
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("Tenga en cuenta que existe N° de ingresos duplicados, por lo que " +
                '                                                        " se recomienda verificar el ingreso seleccionado en función a la fecha.")

                If blnIngreso0 = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados y Nº de ingreso [0]." + Chr(13) +
                                                                      "Debe regularizar para poder realizar una operación," + Chr(13) +
                                                                      "Ir a la lista de ingresos.")
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados," + Chr(13) +
                                                                     "Debe regularizar para poder realizar una operación," + Chr(13) +
                                                                     "Ir a la lista de ingresos.")
                End If
                'blnEliminarTab = True
            End If

        End Sub
        Private Sub DataValidarReniec()

            If ValidarFichaReniec() = True Then

                Dim CodInterno As Integer = Me._IDInterno
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
            If Me._IDInterno < 1 Then Exit Sub

            Dim obEntRnc As New Entity.Registro.InternoReniec
            obEntRnc.InternoID = Me._IDInterno
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
        Private Sub ListarCodigoRP()

            If Me._IDInterno < 1 Then Exit Sub

            Dim objEnt As Entity.Registro.Interno = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)

            Me.CodigoRPInterno = objEnt.CodigoRP
            Me.InternoEstado = objEnt.EstadoID

            ListarCabecera()
        End Sub

        Private Sub ListarCabecera()

            Me.txtCodigo.Text = Me.CodigoRPInterno

            objEntInt = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)

            Me.InternoApePaternoAux = objEntInt.ApellidoPaterno
            Me.InternoApeMaternoAux = objEntInt.ApellidoMaterno
            Me.InternoNombresAux = objEntInt.Nombres
            Me.txtInterno.Text = Me.InternoApeyNomHis(objEntInt.ApellidoPaterno, objEntInt.ApellidoMaterno, objEntInt.Nombres)
            Me.InternoEstado = objEntInt.EstadoID

            If objEntInt.TrasladadoDeCarceleta > 0 Then
                If objEntInt.TrasladadoDeCarceleta > 0 Then 'tras pend recep, tras recepcionado
                    Me.CabeceraEstado = "INACTIVO"
                Else
                    Me.CabeceraEstado = "ACTIVO"
                End If
            Else
                Me.CabeceraEstado = objEntInt.EstadoNombreReadonly ' Bussines.Registro.Interno.EstadoNombre(Me._IDInterno)
            End If

            Me.txtRegionPenal.Text = Me.RegionPenalNombre

            If Me.CabeceraEstado = "INACTIVO" Then
                UscVisorDetalleHuellas1._ControlSoloVista = True
            End If

        End Sub

        Private Sub ListarDataInterno(objEnt As Entity.Registro.Interno, Optional ValidarIDInterno As Boolean = True)

            If ValidarIDInterno = True And Me._IDInterno < 1 Then Exit Sub

            With objEnt
                If ValidarIDInterno = True Then
                    Me.CodigoRPInterno = .CodigoRP
                End If

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
                Me.Nacionalidad = .NacionalidadID
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
                Me.Obs = .Obs

                '/*datos complementarios*/
                Me.InternoApePaternoAux = Me.InternoApePaterno
                Me.InternoApeMaternoAux = Me.InternoApeMaterno
                Me.InternoNombresAux = Me.InternoNombres
                Me.chk_Homonimia.Checked = IIf(.Homonimia = True, True, False)
                Me.chk_Homonimia.Enabled = False
                Me._IdiomaNativoId = .IdiomaNativoId
                Me.GeneroPersonaId = .GeneroId
                Me.NombreClaveInterno = .NombreClaveInterno
                Me.txtCentroTrabajo.Text = .CentroTrabajo
                Me.ReligionId = .ReligionId
                Me.CodigoFuerzaArmadaId = .CodigoFuerzaArmadaId
                Me.CodigoRangoId = .CodigoRangoId

                '/*region y penal*/
                If ValidarIDInterno = True Then
                    Me.RegionID = .RegionID
                    Me.RegionNombre = .RegionNombre
                    Me.PenalID = .PenalID
                    Me.PenalNombre = .PenalNombre
                End If

                Me.uscGradosAcademicos_LM1._PenalId = Me.PenalID
                Me.uscGradosAcademicos_LM1._RegionId = Me.RegionID
                Me.uscGradosAcademicos_LM1._InternoId = Me._IDInterno
                Me.uscGradosAcademicos_LM1._IngresoInpeID = Me._IDIngresoINPE
                Me.uscGradosAcademicos_LM1._IngresoNroLetra = cbbNroIngresoInpe.Text

                Me.UscIdiomaInterno1._PenalId = Me.PenalID
                Me.UscIdiomaInterno1._RegionId = Me.RegionID
                Me.UscIdiomaInterno1._InternoId = Me._IDInterno
                Me.UscIdiomaInterno1._IngresoInpeID = Me._IDIngresoINPE
                Me.UscIdiomaInterno1._IngresoNroLetra = cbbNroIngresoInpe.Text

                Me.UscDomicilio1._PenalId = Me.PenalID
                Me.UscDomicilio1._RegionId = Me.RegionID
                Me.UscDomicilio1._InternoId = Me._IDInterno
                Me.UscDomicilio1._IngresoInpeID = Me._IDIngresoINPE
                Me.UscDomicilio1._IngresoNroLetra = cbbNroIngresoInpe.Text

            End With

        End Sub

        Private Sub ListarData()

            If Me._IDInterno < 1 Then
                Me.txtRegionPenal.Text = Me.RegionPenalNombre
                Exit Sub
            End If

            objBssHistorico = New Bussines.Registro.InternoHistorico

            Dim objEnInternoHisto As New Entity.Registro.InternoHistorico

            objBssInterno = New Bussines.Registro.Interno
            If Me._IDIngreso > 0 Or Me._IDIngresoINPE > 0 Then

                Dim objEnInternoFiltroHisto As New Entity.Registro.InternoHistorico
                With objEnInternoFiltroHisto
                    .PenalID = Me.PenalID
                    .InternoID = Me._IDInterno
                    .IngresoID = Me._IDIngreso ' Me._IDIngresoINPE  'corregido 06-04-2018
                    .IngresoInpeId = Me._IDIngresoINPE
                End With

                objEnInternoHisto = objBssHistorico.Listar_LM(objEnInternoFiltroHisto)

                If objEnInternoHisto Is Nothing Then
                    Dim objEntInterno As New Entity.Registro.Interno

                    objEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)
                    ListarDataInterno(objEntInterno)
                    Me.UscAuditUser1.LoadAudit(objEntInterno.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)

                    'Dim intValueHis As Long = -1
                    'intValueHis = AGrabarHistorico(Me._IDInterno, Me._IDIngresoINPE, Me._IDIngreso)
                    'objEnInternoHisto = objBssHistorico.Listar_LM(objEnInternoFiltroHisto)
                    'ListarInternoHistorico(objEnInternoHisto)
                    'Me.UscAuditUser1.LoadAudit(objEnInternoHisto.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoHistorico)
                Else

                    If objEnInternoHisto.Codigo < 1 Then
                        Dim objEntInterno As New Entity.Registro.Interno

                        objEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)
                        ListarDataInterno(objEntInterno)
                        Me.UscAuditUser1.LoadAudit(Me._IDInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                    Else
                        ListarInternoHistorico(objEnInternoHisto)
                        Me.UscAuditUser1.LoadAudit(objEnInternoHisto.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoHistorico)
                    End If
                End If

            Else
                'Dim ingInp As New Entity.Registro.IngresoInpe
                'Dim ingInpCol As Entity.EntityCol(Of Entity.Registro.IngresoInpe)

                'ingInp.InternoID = Me._IDInterno
                'ingInp.PenalID = 35

                'ingInpCol = (New Bussines.Registro.IngresoInpe).Listar_Grilla(ingInp)
                'If ingInpCol.Count = 0 Then 'si aun no tiene ningun ingresoInpe ni ingresoId
                '    Dim objEntInterno As New Entity.Registro.Interno

                '    objEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)

                '    ListarDataInterno(objEntInterno)
                '    Me.UscAuditUser1.LoadAudit(Me._IDInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                'Else 'por defecto se muestra del ultimo historico de carceleta
                '    objEnInternoHisto = objBssHistorico.ListarUltimoHistorico_carceleta(Me._IDInterno, Me.PenalID)
                '    ListarInternoHistorico(objEnInternoHisto)
                '    Me.UscAuditUser1.LoadAudit(objEnInternoHisto.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoHistorico)
                'End If

                'listar los datos del interno 
                Dim objEntInterno As New Entity.Registro.Interno
                objEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)
                ListarDataInterno(objEntInterno)
                Me.UscAuditUser1.LoadAudit(Me._IDInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)

            End If
            chk_Homonimia.Enabled = False
            ListarCabecera()
            EnabledControles(True)

            DatosPersonalesVerificacionRnc()

        End Sub

        Private Sub ListarInternoHistorico(objEnt As Entity.Registro.InternoHistorico)

            If Me._IDInterno < 1 Or Me._IDIngresoINPE < 1 Then Exit Sub

            With objEnt
                '/*datos generales*/
                'Me._IDInternoSede = .SedeInternoId
                Me._IDIngreso = .IngresoID
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
                Me.Nacionalidad = .NacionalidadID
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
                Me.Obs = .Obs
                '/*region y penal*/
                Me.RegionID = .RegionID
                Me.RegionNombre = .RegionNombre
                Me.PenalID = .PenalID
                Me.PenalNombre = .PenalNombre
                Me.InternoApePaternoAux = .ApellidoPaterno
                Me.InternoApeMaternoAux = .ApellidoMaterno
                Me.InternoNombresAux = .Nombres
                Me.UscAuditUser1.LoadAudit(Me._IDInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                Me.txtCentroTrabajo.Text = .CentroTrabajo
                Me._IdiomaNativoId = .IdiomaNativoId
                Me.GeneroPersonaId = .GeneroId
                Me.NombreClaveInterno = .NombreClaveInterno
                Me.ReligionId = .ReligionId
                Me.CodigoFuerzaArmadaId = .CodigoFuerzaArmadaId
                Me.CodigoRangoId = .CodigoRangoId

                Me.uscGradosAcademicos_LM1._PenalId = Me.PenalID
                Me.uscGradosAcademicos_LM1._RegionId = Me.RegionID
                Me.uscGradosAcademicos_LM1._InternoId = Me._IDInterno
                Me.uscGradosAcademicos_LM1._IngresoInpeID = Me._IDIngresoINPE
                Me.uscGradosAcademicos_LM1._IngresoNroLetra = cbbNroIngresoInpe.Text
                'Me.UscGradosAcademicos1._LoadUsc()

                Me.UscIdiomaInterno1._PenalId = Me.PenalID
                Me.UscIdiomaInterno1._RegionId = Me.RegionID
                Me.UscIdiomaInterno1._InternoId = Me._IDInterno
                Me.UscIdiomaInterno1._IngresoInpeID = Me._IDIngresoINPE
                Me.UscIdiomaInterno1._IngresoNroLetra = cbbNroIngresoInpe.Text
                'Me.UscIdiomaInterno1._LoadUsc()

                Me.UscDomicilio1._PenalId = Me.PenalID
                Me.UscDomicilio1._RegionId = Me.RegionID
                Me.UscDomicilio1._InternoId = Me._IDInterno
                Me.UscDomicilio1._IngresoInpeID = Me._IDIngresoINPE
                Me.UscDomicilio1._IngresoNroLetra = cbbNroIngresoInpe.Text

            End With

        End Sub

        Private Sub ListarDataInternoSeleccionado(IDInterno As Long)

            If IDInterno < 1 Then Exit Sub

            Dim objEntInterno As New Entity.Registro.Interno

            objEntInterno = (New Bussines.Registro.Interno).Listar_LM(IDInterno)

            ListarDataInterno(objEntInterno, False)
            blnModificarDatos = True

        End Sub

        Private Sub ListarDatosComplementarios()
            If Me._IDInterno < 1 Then
                Me.txtRegionPenal.Text = Me.RegionPenalNombre
                Exit Sub
            End If
            With UscIdiomaInterno1
                ._IngresoNroLetra = cbbNroIngresoInpe.Text
                ._InternoId = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                ._RegionId = Me.RegionID
                ._PenalId = Me.PenalID
                .TipoLicencia = enmTipoLicencia.Carceleta
                ._LoadUsc()
            End With

            With uscGradosAcademicos_LM1
                ._IngresoNroLetra = cbbNroIngresoInpe.Text
                ._PenalId = Me.PenalID
                ._RegionId = Me.RegionID
                ._IngresoInpeID = Me._IDIngresoINPE
                ._InternoId = Me._IDInterno
                .TipoLicencia = enmTipoLicencia.Carceleta
                ._LoadUsc()
            End With

            With UscDomicilio1
                ._IngresoNroLetra = cbbNroIngresoInpe.Text
                ._PenalId = Me.PenalID
                ._RegionId = Me.RegionID
                ._IngresoInpeID = Me._IDIngresoINPE
                ._InternoId = Me._IDInterno
                .TipoLicencia = enmTipoLicencia.Carceleta
                ._LoadUsc()
            End With

            listarUscPoblacionLenguaMaterna(blnModificarDatos)
            EnabledControles(True)

        End Sub

        Public Sub LoadUscNombresAsociados()

            With UscGrillaNombresAsociadosV21
                ._InternoID = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                .TipoLicencia = enmTipoLicencia.Carceleta
                ._Documentos_sin_mov = True
                ._LoadUsc()
            End With
        End Sub

        Private Sub LoadUscFotografia()

            With uscFotoPerfiles
                ._InternoID = Me._IDInterno
                ._InternoCodigoRP = Me.CodigoRPInterno
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .InternoFotoID = -1
                ._IngresoInpeID = Me._IDIngresoINPE
                .TipoLicencia = enmTipoLicencia.Carceleta
                .LoadUsc()
                uscFotoPerfiles.DataGrieView_Click()
            End With

        End Sub

        Private Sub LoadUscListarAlias()

            With UserAlias_LM1
                .InternoID = Me._IDInterno
                .IngresoInpeID = Me._IDIngresoINPE
                .PenalID = Me.PenalID
                .RegionID = Me.RegionID
                .TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                ._Load()
            End With
        End Sub

        Private Sub LoadUscListarBandas()
            With UscBandas21
                .InternoID = Me._IDInterno
                .IngresoInpeID = Me._IDIngresoINPE
                .PenalID = Me.PenalID
                .RegionID = Me.RegionID
                .TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                ._Load()
            End With
        End Sub

        Private Sub LoadUscOrganizacionCriminal()

            If Me._IDInterno < 1 Then Exit Sub

            With UscOrganizacionCriminal
                ._InternoID = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                .TipoLicencia = enmTipoLicencia.Carceleta
                ._LoadUsc()
            End With
        End Sub

        Private Sub ListarFamilia()

            With UscFamilias1
                ._IDInterno = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                .TipoLicencia = enmTipoLicencia.Carceleta
                ._LoadUsc()
            End With

        End Sub

        Private Sub LoadUscOdontograma()
            UscOdotoNew1.Height = UscOdont.Height
            UscOdotoNew1.Width = UscOdont.Width + 100
            If Me._IDInterno < 1 Then Exit Sub

            UscOdont.Visible = False
            With UscOdont
                .Visible = True
                ._VisibleEliminar = False
                ._VisibleGrabar = False
                ._InternoId = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                .TipoLicencia = enmTipoLicencia.Carceleta
                ._RegionId = Me.RegionID
                ._PenalId = Me.PenalID
                ._LoadUsc()
            End With

            UscOdotoNew1.Visible = True


            Dim nc As Integer = 0
            Using DB As New DataContextDataContext(Legolas.Configuration.Data.ConexionIni)
                If (From p In DB.int_mov_interno_odontograma_nts Where p.fk_int_id = Me._IDInterno Where p._flg_eli = False Select p).Count > 0 Then

                    Dim obj As int_mov_interno_odontograma_nts = (From p In DB.int_mov_interno_odontograma_nts Where p.fk_int_id = Me._IDInterno Where p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).First
                    UscOdotoNew1.Odonto_nts = obj
                    UscOdotoNew1.carga_datos()
                Else
                    UscOdotoNew1.Odonto_nts = New int_mov_interno_odontograma_nts
                    UscOdotoNew1.carga_datos()
                End If
                UscOdotoNew1.CodInterno = Me.txtCodInterno.Text.Trim
                UscOdotoNew1.NomInterno = InternoApePaterno + " " + InternoApeMaterno + " " + InternoNombres
                UscOdotoNew1.InternoId = _IDInterno
                UscOdotoNew1.CodIngreso = _IDIngreso
                UscOdotoNew1.CodIngresoInpe = _IDIngresoINPE
                UscOdotoNew1.PenalId = PenalID
                UscOdotoNew1.RegionId = RegionID
                UscOdotoNew1.SoloLectura = IIf(Legolas.Configuration.Usuario.OficinaID = 11 Or Legolas.Configuration.Usuario.OficinaID = 31, False, True)
                'UscOdotoNew1.SoloLectura = Not Me._FormEscritura
                UscOdotoNew1.carga_lista()
            End Using
            ' End If
            btnsiguiente.Enabled = False
            btnanterior.Enabled = True

            ' Aca validar si existe odontograma nuevo
            'With UscOdont
            '    ._VisibleEliminar = False
            '    ._VisibleGrabar = False
            '    ._InternoId = Me._IDInterno
            '    ._IngresoInpeID = Me._IDIngresoINPE
            '    .TipoLicencia = enmTipoLicencia.Carceleta
            '    ._RegionId = Me.RegionID
            '    ._PenalId = Me.PenalID
            '    ._LoadUsc()
            'End With

        End Sub

        Private Sub LoadUscDocumentoDigitalizado()

            If Me._IDInterno < 1 Then Exit Sub

            With UscVisorDocDigital1
                ._InternoID = Me._IDInterno
                '._IngresoID = Me._IDIngreso
                ._IngresoInpeID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._TipoLicencia = enmTipoLicencia.Carceleta
                ._LoadUsc()
            End With

        End Sub

        Private Sub LoadUscHuellas()

            If Me._IDInterno < 1 Then Exit Sub

            With UscVisorDetalleHuellas1
                ._InternoId = Me._IDInterno
                ._TipoLicencia = enmTipoLicencia.Carceleta
                ._RegId = Me.RegionID
                ._PenId = Me.PenalID
                ._TipDocIdentId = Me.TipoDocumento
                ._NumDocIdent = Me.NumeroDocumento
                ._CodRP = Me.CodigoRPInterno
                ._ApePat = Me.InternoApePaterno
                ._ApeMat = Me.InternoApeMaterno
                ._Nombres = Me.InternoNombres
                .loadUsc()
            End With

        End Sub

        Private Sub LoadUscClasificaciones()

            If Me._IDInterno < 1 Then Exit Sub

            With UscClasificaciones1
                ._InternoID = Me._IDInterno
                Select Case Me.Sexo
                    Case 1
                        ._Sexo = "MASCULINO"
                    Case 2
                        ._Sexo = "FEMENINO"
                    Case Else
                        ._Sexo = ""
                End Select
                If Me.Nacionalidad = 141 Then
                    ._Nacionalidad = "PERUANO"
                ElseIf Me.Nacionalidad > 0 Then
                    ._Nacionalidad = "EXTRANJERO"
                Else
                    ._Nacionalidad = ""
                End If
                ._IngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                If Me.CabeceraEstado = "INACTIVO" Then
                    ._EstadoInterno = 0
                Else
                    ._EstadoInterno = 1
                End If
                ._NumDocIdentStr = txtNumDoc.Text
                ._TipoDocIdentStr = cbbTipoDoc.Text
                .LoadUsc()
            End With
        End Sub

        Public Sub ListarResoluciones()
            If Me._IDIngresoINPE < 1 Or Me._IDInterno < 1 Then Exit Sub

            With Me.UscResolucionesMain1
                ._Codigo = -1
                ._InternoID = Me._IDInterno
                ._RegionID = Me.RegionID
                ._PenalID = 35
                ._NroIngresoID = -1
                ._IngresoInpeID = Me._IDIngresoINPE
                ._TipoLicencia = enmTipoLicencia.Carceleta
                .LoadUsc()
            End With

            With Me.UscListaResoluciones
                ._Codigo = -1
                ._InternoID = Me._IDInterno
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._NroIngresoID = -1
                ._IngresoInpeID = Me._IDIngresoINPE
                ._TipoLicencia = enmTipoLicencia.Carceleta
                .LoadUsc()
            End With
        End Sub

        Private Sub ListarMovimientosIngreso()
            If Me._IDIngresoINPE < 1 Or Me._IDInterno < 1 Then Exit Sub

            Dim idIngreso As Integer = -1
            Dim tmlEnt As New Entity.Registro.Ingreso
            Dim tmlEntCol As New Entity.EntityCol(Of Entity.Registro.Ingreso)

            tmlEnt.Codigo = Me._IDIngreso
            'tmlEnt.PenalID = Me.PenalID
            'tmlEnt.RegionID = Me.RegionID

            tmlEntCol = (New Bussines.Registro.Ingreso).Listar_LM(tmlEnt)
            If tmlEntCol.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Error interno, no existe registro internoIngreso, contactese con el administrador del sistema.")
                Exit Sub
            End If

            If tmlEntCol.Count > 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Error interno, existe mas de un registro internoIngreso a carceleta, contactese con el administrador del sistema.")
                Exit Sub
            End If

            idIngreso = tmlEntCol.Entity(0).Codigo
            With Me.UscMovimiento1
                ._InternoID = Me._IDInterno
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._IngresoInpeID = Me._IDIngresoINPE
                ._TipoLicencia = enmTipoLicencia.Carceleta
                ._NroIngresoID = idIngreso
                .LoadUsc()
            End With
        End Sub

        Private Sub LoadArchivoDigital()
            With UscVisorArchDigital1
                ._InternoApeMaterno = Me.InternoApeMaterno
                ._InternoApePaterno = Me.InternoApePaterno
                ._InternoNombres = Me.InternoNombres
                ._InternoId = Me._IDInterno
                .LoadUsc()
            End With
        End Sub

        Private Sub listarUscPoblacionLenguaMaterna(editar As Boolean)

            With UscEtniaLenguaMaterna_v21
                ._load(Me._IDInterno, Me.RegionID, Me.PenalID)
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
            EntInternoRnc.InternoID = Me._IDInterno
            Dim ListaValidados As Integer = (New Bussines.Registro.InternoReniec).InternoValidado(EntInternoRnc)

            If ListaValidados > 0 Then
                UscValidacionReniecV21._Contador = ListaValidados
                UscValidacionReniecV21._VarHistorico = 0
                UscValidacionReniecV21._InternoID = Me._IDInterno
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
                '/*fecha nacimiento>18 */
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
                    .Codigo = Me._IDInterno
                    .TipoDocumentoID = Me.TipoDocumento
                    .NumeroDocumento = Me.NumeroDocumento
                    .NumeroDocumentoAux = Me.NumeroDocumentoAux
                    .RegionID = Me.RegionID
                    .PenalID = Me.PenalID
                End With
                If Me._IDInterno > 0 Then
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
                .Codigo = Me._IDInterno
                .ApellidoPaterno = Me.InternoApePaterno
                .ApellidoMaterno = Me.InternoApeMaterno
                .Nombres = Me.InternoNombres
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                If chk_Homonimia.Checked = True Then
                Else
                    If Me._IDInterno < 1 Then
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

        'valida en función al cabeceraEstado y no de InternoEstado, dado que el interno puede ser activo pero transferido de carceleta a otro penal.
        Private Function validaInternoActivo() As Boolean

            If cbbNroIngresoInpe.Items.Count = 0 Then
                Return True
            End If

            Dim v As Boolean = True

            If Me.CabeceraEstado = "INACTIVO" Then
                v = False
            End If

            Return v

        End Function

        Private Sub AGrabar()
            Select Case Me.tbcDatosInterno.SelectedTab.Name
                Case Me.tbpDatos.Name, Me.tbpDatosComplement.Name
                    If validaInternoActivo() = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Interno inactivo, no es posible completar la operación.")
                        Exit Sub
                    End If

                    If btnGrabar.Text = "Modificar" Then
                        EnabledControles(False)

                        Me.btnGrabar.Image = My.Resources.Drive___USB_32
                        Me.btnGrabar.Text = "&Grabar"

                        Me.btnIngreso.Image = My.Resources.anular2
                        Me.btnIngreso.Text = "Cancelar"
                        txtApePat.Focus()
                        Exit Sub
                    End If

                    If Validar() = True Then

                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                            AGrabarInterno()
                            EnabledControles(True)
                        Else
                            btnIngreso_Click(Nothing, Nothing)
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

            If Me._IDInterno > 0 Then
                obEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)
            End If

            With obEntInterno
                .Codigo = Me._IDInterno
                .CodigoRP = Me.CodigoRPInterno
                .CentroReclusionMenorId = Me.CentroReclusionMenorId
                .Libro = Me.Libro
                .Folio = Me.Folio
                .ApellidoPaterno = Me.InternoApePaterno
                .ApellidoMaterno = Me.InternoApeMaterno
                .Nombres = Me.InternoNombres
                .SexoID = Me.Sexo
                .CentroReclusionMenorId = Me.CentroReclusionMenorId
                .FechaNacimiento = Me.InternoFechaNac
                .NacimientoPaisID = Me.Pais
                .NacimientoUbigeoID = Me.UbigeoNacimiento
                .NacimientoOtros = UbigeoNacimientoOtros
                .NacionalidadID = Me.Nacionalidad
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
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .Obs = Me.Obs
                .Obs_DNI = Me.Obs_DNI
                .Decadactilar = Me.DecadactilarIzq & "|" & Me.DecadactilarDer
                .Homonimia = Me.chk_Homonimia.Checked
                .GeneroId = Me.GeneroPersonaId
                .NombreClaveInterno = Me.NombreClaveInterno
                .ReligionId = Me.ReligionId
                .CentroTrabajo = Me.txtCentroTrabajo.Text
                .CodigoFuerzaArmadaId = Me.CodigoFuerzaArmadaId
                .CodigoRangoId = Me.CodigoRangoId
                .IdiomaNativoId = Me._IdiomaNativoId
                .VersionRegistro = "V6_LM"
            End With

            If Me._IDIngresoINPE > 0 Then
                'grabar interno historico
                objBssHistorico = New Bussines.Registro.InternoHistorico
                Dim ValorHis As Integer = objBssHistorico.Grabar_Interno_v2_LM(Me.IDInternoHistorico, Me._IDIngresoINPE, Me._IDIngreso, obEntInterno)
                Me.UscAuditUser1.LoadAudit(Me.IDInternoHistorico, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoHistorico)
                intValue = obEntInterno.Codigo
            Else
                'grabar datos del interno
                Dim blnaux As Boolean = False

                If Me._IDInterno < 1 Then blnaux = True
                Dim outSms As String = ""
                intValue = (New Bussines.Registro.Interno).Grabar_Carceleta(obEntInterno, outSms)

                If intValue = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(outSms)
                End If

                If intValue > 0 Then
                    Me._IDInterno = intValue
                    If blnaux = True Then Me.NumeroDocumentoAux = Me.NumeroDocumento
                    Me.UscAuditUser1.LoadAudit(Me._IDInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
                End If
            End If

            If intValue > 0 Then
                ListarCodigoRP()
                ListarCabecera()

                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

                EnabledControles(True)
                btnGrabar.Image = My.Resources._1277961326_folder_edit
                btnGrabar.Text = "Modificar"
                btnIngreso.Image = My.Resources._1277961158_folder_new
                btnIngreso.Text = "Nuevo" + Chr(13) + "Ingreso"

                If cbbNroIngresoInpe.Items.Count = 0 Then
                    FRM_ListaIngreso(True)
                End If
            End If

        End Sub
        Private Sub AEliminarInterno()

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de eliminar el registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If validaInternoActivo() = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Interno inactivo, no es posible completar la operación.")
                Exit Sub
            End If

            Dim strMensaje As String = "Esta seguro de eliminar definitivamente el registro del interno de su penal."
            strMensaje = strMensaje & " Al realizar esta operacion el registro del interno NO Pasara al estado inactivo."
            strMensaje = strMensaje & Chr(13)


            strMensaje = strMensaje & "" + Chr(13) +
                  "Esta accion eliminará los siguientes datos: " + Chr(13) +
                  "1. Identificacion del Interno " + Chr(13) +
                  "   (Datos personales, Datos Complementarios, Nombres asociados, Fotos, etc)" + Chr(13) +
                  "2. Datos de Clasificacion " + Chr(13) +
                    "   (Ficha Social, Ficha Psicologica, Ficha Legal y Ficha Final)" + Chr(13) +
                  "3. Datos de Mandato Detencion " + Chr(13) +
                  "4. Datos de Movimiento de ingreso y egreso." + Chr(13) +
                  "" + Chr(13) +
                  ""
            strMensaje = strMensaje & "Aun asi desea continuar con la operacion?"

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = Windows.Forms.DialogResult.Yes Then
                If (New Bussines.Registro.Interno).Eliminar(Me._IDInterno, "") > 0 Then Me.Close()
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

            Select Case Me.tbcDatosInterno.SelectedTab.Name

                Case Me.tbpDatos.Name, Me.tbpDatosComplement.Name 'datos
                    'Me.txtCodIntUnico.ReadOnly = Valor
                    Me.txtNomClaveInt.ReadOnly = Valor
                    Me.txtCentroTrabajo.ReadOnly = Valor
                    Me.txtApePat.ReadOnly = Valor
                    Me.txtApeMat.ReadOnly = Valor
                    Me.txtNom.ReadOnly = Valor
                    Me.txtDecadactDer.ReadOnly = Valor
                    Me.txtDecadactIzq.ReadOnly = Valor
                    Me.txtLibro.ReadOnly = Valor
                    Me.txtFolio.ReadOnly = Valor
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

            btnGrabar.Focus()

        End Sub

#End Region
#Region "Formulario"
#Region "Datos del Interno"

        Private Sub FRM_ListaIngreso(NuevoIngreso As Boolean)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos básicos del interno")
                Exit Sub
            End If

            If Me.cbbNroIngresoInpe.Text = "[Por regularizar]" Then
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

            Dim frm As New Registro.Carceleta.Identificacion.frmIngresoPopup_V2
            With frm
                ._IDInterno = Me._IDInterno
                ._IDRegion = Me.RegionID
                ._IDPenal = Me.PenalID
                ._AgregarNuevoIngreso = NuevoIngreso
                If Me.txtEstado.Text = "ACTIVO" Then
                    ._EstadoInternoCarceleta = 1
                Else
                    ._EstadoInternoCarceleta = 0
                End If

                Select Case Me.PerfilUsuarioActual
                    Case EnumDependencia.Legal, EnumDependencia.Odontologo, EnumDependencia.Psicologo, EnumDependencia.Social
                        ._FormEscritura = False
                        ._FormEliminar = False
                        ._FormReporte = False
                    Case Else
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte
                End Select
                If txtEstado.Text = "INACTIVO" Then

                End If

                If frm.ShowDialog = DialogResult.OK Then

                    ComboNumIngresoINPE()
                    Me.TabControl1.SelectTab(Me.tbpInterno)
                    Me.tbcDatosInterno.SelectTab(Me.tbpDatos)
                    ListarData()
                End If

            End With
        End Sub

        Private Sub FRM_Mant_SeniaParticular(IdSeniaPart As Integer, forzarRegistroSoloLectura As Boolean)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmSeñasPartiPopup
            With frm
                .Codigo = IdSeniaPart
                ._InternoID = Me._IDInterno
                ._InternoIngresoId = -1
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._InternoIngresoNro = Val(cbbNroIngresoInpe.Text)
                .TipoLicencia = enmTipoLicencia.Carceleta
                'permisos
                If forzarRegistroSoloLectura = True Or Me.CabeceraEstado = "INACTIVO" Then
                    ._FormEscritura = False
                    ._FormEliminar = False
                Else
                    ._FormEscritura = uscFotoPerfiles._VisibleGrabar ' Me._FormEscritura
                    ._FormEliminar = uscFotoPerfiles._VisibleEliminar ' Me._FormEliminar
                End If


                If .ShowDialog = DialogResult.OK Then uscFotoPerfiles.ListarSenasParti()
            End With
        End Sub

        Private Sub FRM_Mant_Rasgo(IdRasgo As Integer, forzarRegistroSoloLectura As Boolean)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmRasgosPartiPopup
            With frm
                .Codigo = IdRasgo
                ._InternoID = Me._IDInterno
                ._InternoIngresoId = Me._IDIngreso
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._NroIngreso = Val(cbbNroIngresoInpe.Text)
                .TipoLicencia = enmTipoLicencia.Carceleta

                If forzarRegistroSoloLectura = True Or Me.CabeceraEstado = "INACTIVO" Then
                    ._FormEscritura = False  ' Me._FormEscritura
                    ._FormEliminar = False 'Me._FormEliminar
                Else
                    ._FormEscritura = uscFotoPerfiles._VisibleGrabar ' Me._FormEscritura
                    ._FormEliminar = uscFotoPerfiles._VisibleEliminar 'Me._FormEliminar
                End If
                If .ShowDialog = DialogResult.OK Then uscFotoPerfiles.ListarDataRasgo()

            End With
        End Sub

        Private Sub FRM_Mant_Fotos(InternoID As Integer, RestringirEdicion As Boolean)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm As New Registro.Captura.frmFotoPerfiles
            With frm
                ._InternoID = Me._IDInterno
                .Codigo = InternoID
                .PenalID = Me.PenalID
                .RegionID = Me.RegionID
                .InternoIngresoId = -1
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                .RestringirEdicion = RestringirEdicion
                .TipoLicencia = enmTipoLicencia.Carceleta
                .InternoIngresoNro = Val(Me.cbbNroIngresoInpe.SelectedIndex + 1)
                .LoadUsc()
                'permisos
                If Me.CabeceraEstado = "INACTIVO" Then
                    ._FormEscritura = False
                    ._FormEliminar = False
                Else
                    ._FormEscritura = uscFotoPerfiles._VisibleGrabar ' Me._FormEscritura
                    ._FormEliminar = uscFotoPerfiles._VisibleEliminar ' Me._FormEliminar
                End If

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.uscFotoPerfiles.LoadUsc()
                    Me.uscFotoPerfiles.DataGrieView_Click()
                End If
            End With

        End Sub

        Private Sub FRM_Mant_NombresAsociados(ByVal Nuevo As Boolean, ByVal Codigo As Integer, objEntNA As Entity.Registro.NombreAsociado)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Nuevo = True Then
                Dim frm1 As New Registro.Identificacion.frmNombreAsociadoPopup2(Nothing)
                With frm1
                    .Codigo = Codigo
                    .InternoID = Me._IDInterno
                    ._IngresoInpeID = Me._IDIngresoINPE
                    ._RegionID = Me.RegionID
                    ._PenalID = Me.PenalID
                    ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                    '.TipoLicencia = enmTipoLicencia.Carceleta

                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        ListarCabecera()
                        ListarData()
                        ListarResoluciones()
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
                    ._RegionID = Me.RegionID
                    ._PenalID = Me.PenalID
                    .InternoID = Me._IDInterno
                    'permisos
                    .objEntDocumen = New Entity.Registro.Documento.NombresAsociados
                    .objEntDocumen.NAPaterno = objEntNA.ApellidoPaterno
                    .objEntDocumen.NAMaterno = objEntNA.ApellidoMaterno
                    .objEntDocumen.NANombres = objEntNA.Nombres
                    .objEntDocumen.NAPrincipal = objEntNA.Principal
                    .objEntDocumen.NAEstado = objEntNA.Estado
                    .objEntDocumen.InternoID = objEntNA.InternoID
                    .objEntDocumen.InternoNombreAsociadoID = objEntNA.Codigo

                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    ._TipoFormu = True
                    ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                    .ListarData()
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ListarCabecera()
                        ListarData()
                        ListarResoluciones()
                        'Listar_Expedientes()
                        UscGrillaNombresAsociadosV21.Listar()
                        Me.UscGrillaNombresAsociadosV21._LoadUsc()
                    End If
                End With
            End If

        End Sub

        Private Sub FRM_MantenimientoAlias(ByVal Nuevo As Boolean, AliasID As Integer)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInterno.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresoInpe.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.v5.frmAliasPopup
            With frm
                If Nuevo = False Then
                    .Codigo = AliasID
                End If
                .InternoID = Me._IDInterno
                ._NroIngresoID = -1
                ._NroIngresoInpeID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                .TipoLicencia = enmTipoLicencia.Carceleta
                'permisos
                If Me.CabeceraEstado = "INACTIVO" Then
                    ._FormEscritura = False
                    ._FormEliminar = False
                Else
                    ._FormEscritura = UserAlias_LM1._VisibleGrabar
                    ._FormEliminar = UserAlias_LM1._VisibleEliminar
                End If

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then LoadUscListarAlias()

            End With
        End Sub

        Private Sub FRM_MantenimientoBandas(ByVal Nuevo As Boolean, InternoBandaID As Integer, n_ingresoInpeId As Integer, objEntColBandas As Entity.Registro.InternoBandaCol)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno.")
                Me.tbcDatosInterno.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresoInpe.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmInternoBandaV2
            With frm
                If Nuevo = False Then
                    .Codigo = InternoBandaID
                End If
                .InternoID = Me._IDInterno
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                .TipoLicencia = enmTipoLicencia.Carceleta
                ._NroIngresoInpeID = Me._IDIngresoINPE
                ._NroIngresoID = -1

                'permisos
                If Me.CabeceraEstado = "INACTIVO" Then
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
                ._InternoID = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                ._PenalLM = True
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Siscrico

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

        Private Sub FRM_Mant_Siscrico(ByVal Nuevo As Boolean)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno.")
                Me.tbcDatosInterno.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresoInpe.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Siscrico.Bandas.frmInternoBandaPopupV2
            With frm
                .TipoLicencia = enmTipoLicencia.Carceleta
                ._NroIngresoID = -1
                If Nuevo Then
                    .Codigo = -1
                    ._IngresoInpeID = Me._IDIngresoINPE
                Else
                    .Codigo = Me.UscOrganizacionCriminal.GrillaID
                    ._IngresoInpeID = Me.UscOrganizacionCriminal.GrillaIngresoInpeID
                End If
                .InternoID = Me._IDInterno
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                .TipoLicencia = enmTipoLicencia.Carceleta
                'permisos
                If Me.CabeceraEstado = "INACTIVO" Then
                    ._VisibleGrabar = False
                    ._FormEscritura = False
                    ._FormEliminar = False
                Else
                    ._VisibleGrabar = UscOrganizacionCriminal._VisibleGrabar
                    ._FormEscritura = UscOrganizacionCriminal._VisibleGrabar
                    ._FormEliminar = UscOrganizacionCriminal._VisibleEliminar
                End If

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscOrganizacionCriminal._LoadUsc()
                End If

            End With
        End Sub

        Private Sub FRM_Mant_Familia(ByVal Nuevo As Boolean, IDFamilia As Integer, objFamCol As Entity.Registro.FamiliarCol)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInterno.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresoInpe.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.v5.frmFamiliarPopupV2
            With frm
                .InternoID = Me._IDInterno
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                If Nuevo = True Then
                    .Codigo = -1
                    ._NroIngresoID = -1 'Me._IDIngresoINPE
                    ._objEntColFam = objFamCol
                    ._NuevoFam = Nuevo
                Else
                    .Codigo = IDFamilia
                    ._NroIngresoID = -1 'Me._IDIngresoINPE
                    ._objEntColFam = objFamCol
                    ._NuevoFam = Nuevo
                End If
                .TipoLicencia = enmTipoLicencia.Carceleta
                'permisos
                If Me.CabeceraEstado = "INACTIVO" Then
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

        Private Sub FRM_VerReportes()

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de visualizar los reportes, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm2 As New Registro.Reporte.frmReportePopup_LM
            With frm2
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoID = Me._IDInterno
                ._TipoLicencia = enmTipoLicencia.Carceleta
                ._InternoApeNom = Me.InternoApeyNom
                ._TipoReporte = Reporte.frmReportePopup_LM.enmListarReportes.Interno
                ._VisibleBuscar = False
                .ShowDialog()
            End With

        End Sub

        Private Sub FRM_Odontograma(Nuevo As Boolean, IDOdontograma As Integer)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            Dim f As New Registro.Captura.frmOdontogramaPopup
            f._FormLectura = True
            f._InternoId = Me._IDInterno
            f._InternoIngresoId = -1
            f._InternoIngresoInpeId = Me._IDIngresoINPE
            f._PenalId = Me.PenalID
            f._RegionId = Me.RegionID
            f._TipoLicencia = enmTipoLicencia.Carceleta
            If Me.CabeceraEstado = "INACTIVO" Then
                f._FormEscritura = False
                f._FormEliminar = False
            Else
                f._FormEscritura = UscOdont._VisibleGrabar ' Me._FormEscritura
                f._FormEliminar = UscOdont._VisibleEliminar
            End If

            If Nuevo = True Then
                f._Codigo = -1
            Else
                f._Codigo = IDOdontograma
            End If

            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                UscOdont._LoadUsc()
            End If

        End Sub

#End Region

#Region "Expediente"
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, ByVal ExpedienteID As Integer)

            If Me._IDInterno < 1 Or Me._IDIngresoINPE < 1 Then
                MessageBox.Show("Seleccione el número de ingreso", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                    ._Codigo = ExpedienteID
                    ' ._objEntExpediente = UscMandatoDetencion._ObjEntExp
                    ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                End If
                ._InternoID = Me._IDInterno
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._IngresoID = -1
                ._TipoLicencia = enmTipoLicencia.Carceleta
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                'If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                '    Me.UscMandatoDetencion._ListarExpediente()

                'End If
                'Me.UscMandatoDetencion._ListarDelito()
            End With
        End Sub
#End Region

#Region "Resoluciones"
        Private Sub FRM_ListadoExpediente()
            Dim frm As New Registro.Resoluciones.frmVerExpePorResolPopup(Me._IDIngreso, Me._IDInterno, Me._IDIngresoINPE)
            frm._TipoLicencia = enmTipoLicencia.Carceleta
            frm.ShowDialog()
        End Sub
        Private Sub FRM_Resolucion_Sentencia(TipoResolucion As System.Int32, IDDocumentoJudicial As System.Int32, SubTipo As Integer, _penId As Integer, verSoloLectura As Boolean)
            Select Case TipoResolucion
                Case enumTipoDocumentoJudicial.Libertad
                    FRM_Resolucion_Libertad(IDDocumentoJudicial)
                    ListarCabecera()

                Case enumTipoDocumentoJudicial.Traslado
                    FRM_Resol_Traslado(IDDocumentoJudicial)

                Case enumTipoDocumentoJudicial.Detencion, enumTipoDocumentoJudicial.DetencionReferenciado
                    If _penId = 35 Then
                        If verSoloLectura = True Then
                            FRM_Resol_Detencion(IDDocumentoJudicial, True)
                        Else
                            FRM_Mant_Detencion_Carceleta(IDDocumentoJudicial, False)
                        End If
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Visualización de documento solo lectura.")
                        FRM_Resol_Detencion(IDDocumentoJudicial, True)
                    End If
                Case enumTipoDocumentoJudicial.DetencionCarceleta
                    If verSoloLectura = True Then
                        FRM_Resol_Detencion(IDDocumentoJudicial, True)
                    Else
                        FRM_Mant_Detencion_Carceleta(IDDocumentoJudicial, False)
                    End If
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
                    FRM_Resolucion_Nota(IDDocumentoJudicial)

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

                Case enumTipoDocumentoJudicial.Integracion_Sentencia, enumTipoDocumentoJudicial.Refundicion_de_Sentencia, enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                    FRM_Resol_IntegracionSentencia(IDDocumentoJudicial, TipoResolucion)

                Case enumTipoDocumentoJudicial.Sentencia_Aclaratoria, enumTipoDocumentoJudicial.Sent_Adecuacion_Pena,
                     enumTipoDocumentoJudicial.Sent_Conmutacion_Pena, enumTipoDocumentoJudicial.Sent_Sustitucion_Pena,
                     enumTipoDocumentoJudicial.ResolucionConsentida, enumTipoDocumentoJudicial.Resolucion,
                     enumTipoDocumentoJudicial.Resolucion_Superior, enumTipoDocumentoJudicial.Sent_Pena_Limitativa,
                      enumTipoDocumentoJudicial.Ejecutoria_Superior, enumTipoDocumentoJudicial.Ejecutoria_Suprema
                    FRM_Resol_SentenciaMultiple(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()

                Case enumTipoDocumentoJudicial.Anulacion_Antecedentes
                    FRM_Resol_AnulacionAntecedentes(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()

            End Select

        End Sub

        Private Sub FRM_NuevoMandato()

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            If ValorIngreso = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados," + Chr(13) + "regularizar para poder realizar una operación.")
                Exit Sub
            End If
            If Me.TipoDocumento > 0 And Me.NumeroDocumento = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Tenga en cuenta que no ha especificado el número de documento de identidad del interno, favor de completar dicha información.")
                Exit Sub
            End If

            'verificar que el mov de ingreso este en estado terminado.
            Dim entMov As New Entity.Registro.InternoMovimiento
            Dim entMovCol As New Entity.Registro.InternoMovimientoCol

            entMov.IngresoInpeId = Me._IDIngresoINPE
            entMov.IngresoID = Me._IDIngreso
            entMov._PenalID = 35
            entMov.MovimientoGrupoID = 1 'ingreso
            'entMov.EstadoID = 1 'pendiente

            entMovCol = (New Bussines.Registro.InternoMovimiento).Listar_LM_v2(entMov)
            If entMovCol.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe movimiento de ingreso del interno, por favor dirijase a la pestaña Movimientos y agruegue el movimiento de ingreso.")
                Exit Sub
            Else
                entMov = entMovCol.InternoMovimiento(0)
                If entMov.EstadoID <= 1 Then 'ingreso pendiente
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe movimiento de interno en estado pendiente, por favor dirijase a la pestaña Movimientos y cambie el estado del movimiento de ingreso a terminado.")
                    Exit Sub
                End If
            End If

            Dim frm As New Registro.Resoluciones.frmResolDetencion
            With frm
                ._Codigo = -1
                ._InternoId = Me._IDInterno
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = 3
                ._PenalID = 35
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.txtInterno.Text
                ._blnNuevoRegistro = True
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionCarceleta
                .UscExpeDeResolucion1._Documentos_sin_mov = False
                ._TipoLicencia = enmTipoLicencia.Carceleta
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    UscResolucionesMain1._Listar()
                End If
            End With

            'Dim frm As New Registro.Resoluciones.frmResolucionTipoPopup
            'With frm
            '    ._InternoID = Me._IDInterno
            '    ._IngresoID = IngresoID
            '    ._RegionID = Me.RegionID
            '    ._PenalID = Me.PenalID
            '    ._CodigoInterno = Me.CodigoRPInterno
            '    ._NombresInterno = Me.txtInterno.Text
            '    ._ResolucionIngRegistrado = ResolucionRegistrada
            '    ._OpcionListar = Opcion
            '    ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
            '    ._InternoIngresoInpeId = Me._IDIngresoINPE
            '    ._Documento_sin_mov = False
            '    'permisos
            '    ._FormEscritura = Me._FormEscritura
            '    ._FormEliminar = Me._FormEliminar
            '    ._FormImpresion = Me._FormImpresion
            '    If .ShowDialog() = Windows.Forms.DialogResult.OK Then

            '        UscResolucionesMain1._Listar()
            '        UscListaResoluciones._Listar()


            '        UscGrillaNombresAsociadosV21.Listar()
            '        Me.UscMovimiento1._Listar()
            '        ListarCabecera()
            '        ListarData()
            '    End If
            'End With

        End Sub

        Private Sub FRM_Resolucion_Ingreso(DocJudicialId As Integer, DocSubTipo As Integer)

            If DocSubTipo = 28 Or DocSubTipo = 30 Then 'ojo: cambiar por un type y replicar en v5 del penal
                Dim frm As New Registro.Resoluciones.frmResolIngresoTraslado
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                    ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                    ._RegionID = Me.RegionID
                    ._PenalID = -1
                    ._InternoID = Me._IDInterno
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._blnNuevoRegistro = False
                    ._DocumentoSubTipo = DocSubTipo
                    ._Documento_sin_mov = True
                    '._InternoIngresoInpeId = Me._IDIngresoINPE
                    ._TipoLicencia = enmTipoLicencia.Carceleta
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormReporte = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

                End With
            Else
                Dim frm As New Registro.Resoluciones.frmResolIngreso
                With frm
                    ._Codigo = DocJudicialId
                    ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                    ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                    ._RegionID = Me.RegionID
                    ._PenalID = -1
                    ._InternoID = Me._IDInterno
                    ._CodigoInterno = Me.CodigoRPInterno
                    ._NombresInterno = Me.InternoApeyNom
                    ._blnNuevoRegistro = False
                    ._DocumentoSubtipo = DocSubTipo
                    ._Documento_sin_mov = True
                    ._TipoLicencia = enmTipoLicencia.Carceleta
                    'permisos
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormReporte = False

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

                End With
            End If
        End Sub

        Private Sub FRM_Resolucion_Libertad(DocJudicialId As Integer)

            Dim frm As New Registro.Resoluciones.frmResolLibertad
            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._Documento_sin_mov = True
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With
        End Sub

        Private Sub FRM_Resolucion_Nota(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmNota

            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me._IDInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._TipoLicencia = enmTipoLicencia.Carceleta
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resolucion_ProlongDetencion(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolProlongDetencion

            With frm
                ._Codigo = DocJudicialId
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.Carceleta
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
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.Carceleta
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
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
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
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_Detencion(DocJudicialId As Integer, regSoloLectura As Boolean)
            Dim frm As New Registro.Resoluciones.frmResolDetencionReferenciado

            With frm
                ._Codigo = DocJudicialId
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = enumTipoDocumentoJudicial.Detencion
                ._TipoLicencia = enmTipoLicencia.Carceleta
                'permisos
                If regSoloLectura = True Then
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormReporte = False
                Else
                    If Me.PerfilUsuarioActual <> EnumDependencia.Legal Then
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte
                    End If
                End If


                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Mant_Detencion_Carceleta(DocJudicialId As Integer, regSoloLectura As Boolean)
            Dim frm As New Registro.Resoluciones.frmResolDetencion

            With frm
                ._Codigo = DocJudicialId
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = enumTipoDocumentoJudicial.DetencionCarceleta
                ._TipoLicencia = enmTipoLicencia.Carceleta
                'permisos
                If regSoloLectura = True Then
                    ._FormEscritura = False
                    ._FormEliminar = False
                    ._FormReporte = False
                Else
                    If Me.PerfilUsuarioActual <> EnumDependencia.Legal Then
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte
                    End If
                End If
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()
            End With
        End Sub

        Private Sub FRM_Resol_Expediente(DocJudicialId As Integer)
            Dim frm As New Registro.Sentencias.frmResolSentenciaMultiple

            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me._IDInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._InternoID = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Resolucion
                .UscDetallResolucionEjecutoria1._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.Carceleta
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
                ._InternoId = Me._IDInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._Documento_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.Carceleta
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
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._NuevoRegistro = False
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.Carceleta
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
                ._InternoId = Me._IDInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                .UscDetallAcumulacionExp1._DocumentoJudicialID = True
                ._TipoLicencia = enmTipoLicencia.Carceleta
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
                ._InternoId = Me._IDInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.Carceleta
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
                ._InternoId = Me._IDInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.Carceleta
                'permisos
                ._FormEscritura = False
                ._FormEliminar = False
                ._FormReporte = False

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_AclaratoriaNombres(DocJudicialId As Integer)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInterno.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresoInpe.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmNombreAsociadoPopup2(Nothing)
            With frm
                ' ._Codigo = DocJudicialId
                .InternoID = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._Nuevobln = False
                ._Documentos_sin_mov = True
                .ApellidoPaternoCopi = Me.InternoApePaterno
                .ApellidoMaternoCopi = Me.InternoApeMaterno
                .NombresCopi = Me.InternoNombres
                ._PenalLM = True
                ._TipoFormulario = Type.Formulario.Registro.UserControl.Resoluciones
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarData()
                    ListarCabecera()
                    ListarResoluciones()
                    UscGrillaNombresAsociadosV21.Listar()
                End If
            End With
        End Sub
#End Region

#Region "Sentencias"
        Private Sub FRM_Resol_Sentencia(DocJudicialId As Integer)
            Dim frm As New Registro.Sentencias.frmResolSentencia

            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me._IDInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoLicencia = enmTipoLicencia.Carceleta
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
                ._InternoID = Me._IDInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = -1 ' Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = TipoDocumento
                Me.DocumentoTipo = TipoDocumento
                ._TipoLicencia = enmTipoLicencia.Carceleta

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
                ._InternoID = Me._IDInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoID = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                ._TipoLicencia = enmTipoLicencia.Carceleta
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
                ._InternoID = Me._IDInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._InternoID = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                ._TipoLicencia = enmTipoLicencia.Carceleta
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

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInterno.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresoInpe.Focus()
                Exit Sub
            End If

            If ValorIngreso = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados," + Chr(13) + "debe regularizar para poder realizar una operación.")
                Exit Sub
            End If

            If NroPendientes > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Acción no permitida mientras que exista un movimiento pendiente.")
                Exit Sub
            End If

            'obtener ingresoId a partir de IngresoInpeId ---->
            Dim bss As New Bussines.Registro.Ingreso
            Dim ent As New Entity.Registro.Ingreso
            ent.IngresoInpeId = Me._IDIngresoINPE
            ent.PenalID = Me.PenalID
            ent.RegionID = Me.RegionID

            ent = bss.Listar_LM(ent).Item(0)
            '<------------------------------------------------


            Dim frm As New Registro.Movimientos.frmMovimientoTipoPopup
            With frm
                ._InternoID = Me._IDInterno
                ._IngresoID = ent.Codigo
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._NuevoRegistro = True
                ._NroPendientes = NroPendientes
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                'permisos
                ._FormEscritura = UscMovimiento1._VisibleGrabar ' Me._FormEscritura
                ._FormEliminar = UscMovimiento1._VisibleEliminar ' Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With

        End Sub

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
                Case Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe el tipo de Movimiento")
            End Select

        End Sub
        Private Sub FMR_MovimientoInternamiento(MovimientoID As Integer, MovimientoGrupoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer)

            Dim frm As New Registro.Movimientos.Carceleta.frmInternamiento
            With frm
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me._IDInterno
                ._IngresoID = IngresoID
                ._MovimientoGrupoID = MovimientoGrupoID
                ._MovimientoTipoID = MovimientoTipoID
                ._MovimientoMotivoID = MovimientoMotivoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._TipoDocJudicialID = EnumRegDocTipo.Internamiento
                '._CargarExpedientes = True
                'permisos
                ._FormEscritura = UscMovimiento1._VisibleGrabar ' Me._FormEscritura
                ._FormEliminar = UscMovimiento1._VisibleEliminar ' Me._FormEliminar
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
                ._Licencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me._IDInterno
                ._IngresoID = IngresoID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.Traslado
                'permisos
                ._FormEscritura = UscMovimiento1._VisibleGrabar
                ._FormEliminar = UscMovimiento1._VisibleEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With

        End Sub
        Private Sub FRM_MovimientoLibertad(MovimientoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer, Pendientes As Integer)
            Dim frm As New Registro.Movimientos.frmMovimientoLibertad
            With frm
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me._IDInterno
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._MovimientoMotivoID = MovimientoMotivoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.Libertad
                ._NroPendientes = Pendientes
                'permisos
                ._FormEscritura = UscMovimiento1._VisibleGrabar
                ._FormEliminar = UscMovimiento1._VisibleEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With
        End Sub
        Private Sub FRM_MovimientoLibertadPoput(MovimientoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer,
                                               IngresoID As Integer, DocumentoJudID As Integer)
            Dim frm As New Registro.Movimientos.frmMovimientoLibertadPoput
            With frm
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me._IDInterno
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._MovimientoMotivoID = MovimientoMotivoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.Libertad
                ._CargarExpedientes = True
                'permisos
                ._FormEscritura = UscMovimiento1._VisibleGrabar
                ._FormEliminar = UscMovimiento1._VisibleEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With
        End Sub
        Private Sub FRM_MovimientoFuga(MovimientoID As Integer, MovimientoTipoID As Integer,
                                                       IngresoID As Integer)

            Dim frm As New Registro.Movimientos.frmMovimientoFuga
            With frm
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                ._Codigo = MovimientoID
                ._InternoID = Me._IDInterno
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoMovimiento = MovimientoTipoID

                'permisos
                ._FormEscritura = UscMovimiento1._VisibleGrabar
                ._FormEliminar = UscMovimiento1._VisibleEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With

        End Sub

        Private Sub FRM_MovimientoConducciones(MovimientoID As Integer, MovimientoTipoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer)

            Dim frm As New Registro.Movimientos.frmMovimientoConducciones
            With frm
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me._IDInterno
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._CargarDocumento = True
                'permisos
                ._FormEscritura = UscMovimiento1._VisibleGrabar
                ._FormEliminar = UscMovimiento1._VisibleEliminar
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
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                ._Codigo = MovimientoID
                '._DocumJudicialID = DocumentoJudID
                ._InternoID = Me._IDInterno
                ._IngresoID = IngresoID
                '._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                '._CargarDocumento = True
                'permisos
                ._FormEscritura = UscMovimiento1._VisibleGrabar
                ._FormEliminar = UscMovimiento1._VisibleEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With
        End Sub
#End Region

#Region "Clasificacion"
        Private Sub FRM_Clasificacion(objEnt As Entity.Clasificacion.Documento.DatosFicha)
            If objEnt.GrupoFichaId = 4 Or objEnt.GrupoFichaId = 10 Then
                Dim f As New Registro.Carceleta.Clasificacion.frmDetalleFicha_V2

                f.VariableId = objEnt.MaeVariableId
                f.FichaId = objEnt.MaeFichaId
                f.RegionID = Me.RegionID
                f.PenalID = Me.PenalID
                f.VariableString = objEnt.VariableNombre
                f._ValorPuntaje = objEnt.ValorPuntaje
                f._ValorNoPrevisto = objEnt.ValorNoPrevisto
                f.InternoFichaDetalleId = objEnt.InternoFichaDetalleId
                f.IndicadorId = objEnt.IndicadorId
                f.BloquearRegistro = objEnt.BloquearRegistro
                f.SituacionJuridicaId = objEnt.InternoSituacionJuridica
                f.GrupoFichaId = objEnt.GrupoFichaId

                If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                    UscClasificaciones1.Listar2(f._ValorPuntaje, f.ValorNombreSeleccionado, f.ValorIdSeleccionado, f._ValorNoPrevisto)
                End If
            Else
                Dim f As New Registro.Carceleta.Clasificacion.frmDetalleFicha

                f.VariableId = objEnt.MaeVariableId
                f.FichaId = objEnt.MaeFichaId
                f.RegionID = Me.RegionID
                f.PenalID = Me.PenalID
                f.VariableString = objEnt.VariableNombre
                f._ValorPuntaje = objEnt.ValorPuntaje
                f._ValorNoPrevisto = objEnt.ValorNoPrevisto
                f.InternoFichaDetalleId = objEnt.InternoFichaDetalleId
                f.IndicadorId = objEnt.IndicadorId
                f.BloquearRegistro = objEnt.BloquearRegistro
                f.SituacionJuridicaId = objEnt.InternoSituacionJuridica
                f.GrupoFichaId = objEnt.GrupoFichaId

                If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                    UscClasificaciones1.Listar2(f._ValorPuntaje, f.ValorNombreSeleccionado, f.ValorIdSeleccionado, f._ValorNoPrevisto)
                End If
            End If

        End Sub
#End Region

#End Region
#Region "Permisos_Usuario"
        Private Sub HabilitarControlesxTabs()

            Dim blnVisibleGrabarDatos As Boolean = False
            Dim blnVisibleNuevoReniec As Boolean = False
            Dim blnVisibleEliminarInterno As Boolean = False
            Dim blnVisibleLeyenda As Boolean = False
            Dim blnVerAuditoria As Boolean = False

            Select Case Me.TabControl1.SelectedTab.Name

                Case Me.tbpInterno.Name

                    Select Case Me.tbcDatosInterno.SelectedTab.Name
                        Case Me.tbpDatos.Name   'datos del interno, foto
                            blnVisibleGrabarDatos = Me._FormEscritura
                            blnVisibleNuevoReniec = False
                            blnVisibleEliminarInterno = Me._FormEliminar
                            blnVerAuditoria = True

                        Case Me.tbpDatosComplement.Name 'datos complemtarios
                            blnVisibleGrabarDatos = Me._FormEscritura
                            blnVerAuditoria = True

                        Case Me.tbpFoto.Name  'foto
                            blnVisibleGrabarDatos = False
                            blnVisibleNuevoReniec = False
                            blnVisibleEliminarInterno = False

                        Case Me.tbpReniec.Name  'reniec
                            blnVisibleGrabarDatos = False
                            blnVisibleNuevoReniec = Me._FormEscritura
                            blnVisibleEliminarInterno = False

                        Case Me.tbpBandas.Name 'bandas

                        Case Else

                    End Select
                Case Me.tbpClasificaciones.Name
                    blnVerAuditoria = True
                Case Me.tbpMandDet.Name


                Case Me.tabMovimiento.Name

            End Select

            Me.pnlGrabarDatos.Visible = blnVisibleGrabarDatos
            Me.pnlNuevoReniec.Visible = blnVisibleNuevoReniec
            Me.pnlEliminar.Visible = blnVisibleEliminarInterno

            Me.pnlAuditoria.Visible = blnVerAuditoria

        End Sub
        Private Sub Usuario_Permisos()

            Select Case Me.IDLicencia
                Case 1 'sede central
                    'pasa
                Case Else 'penal o provincias
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Modulo de Carceleta solo está disponible en la Sede Central")
                    Me.Close()
            End Select

            Dim blnGrabar As Boolean = False
            Dim blnEliminar As Boolean = False
            Dim blnReporte As Boolean = False

            'escritura 
            If Me._FormEscritura = True Then

                Select Case Legolas.Configuration.Usuario.NivelUsuario
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta,
                         Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                        Select Case Me.PerfilUsuarioActual

                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                                blnGrabar = Me._FormEscritura

                            Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario, Type.Enumeracion.Usuario.EnumDependencia.GabineteIdentificacionOdontologo
                                blnGrabar = Me._FormEscritura

                            Case Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                    Type.Enumeracion.Usuario.EnumDependencia.Social,
                                    Type.Enumeracion.Usuario.EnumDependencia.Odontologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.Psicologo

                                blnGrabar = Me._FormEscritura
                                Me._FormEscritura = False
                            Case EnumDependencia.SeguridadPenitenciaria
                                blnGrabar = Me._FormEscritura
                                Me._FormEscritura = False
                            Case Else
                                Me._FormEscritura = False
                        End Select

                    Case Else
                        Me._FormEscritura = False
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

                            Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario, Type.Enumeracion.Usuario.EnumDependencia.GabineteIdentificacionOdontologo
                                blnEliminar = Me._FormEliminar

                            Case Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                    Type.Enumeracion.Usuario.EnumDependencia.Social,
                                    Type.Enumeracion.Usuario.EnumDependencia.Odontologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.Psicologo

                                blnEliminar = Me._FormEliminar
                                Me._FormEliminar = False
                            Case EnumDependencia.SeguridadPenitenciaria
                                blnEliminar = Me._FormEliminar
                                Me._FormEliminar = False
                            Case Else
                                Me._FormEliminar = False
                        End Select

                    Case Else
                        Me._FormEliminar = False
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

                            Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario, Type.Enumeracion.Usuario.EnumDependencia.GabineteIdentificacionOdontologo
                                blnReporte = Me._FormReporte

                            Case Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                    Type.Enumeracion.Usuario.EnumDependencia.Social,
                                    Type.Enumeracion.Usuario.EnumDependencia.Odontologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.Psicologo

                                blnReporte = Me._FormReporte
                                Me._FormReporte = False
                            Case EnumDependencia.SeguridadPenitenciaria
                                blnReporte = Me._FormReporte
                                Me._FormReporte = False
                            Case Else
                                Me._FormReporte = False
                        End Select

                    Case Else
                        Me._FormReporte = False
                End Select
            End If

            '/*controles*/
            Me.pnlGrabarDatos.Visible = Me._FormEscritura
            Me.pnlEliminar.Visible = Me._FormEliminar
            Me.pnlReporte.Visible = Me._FormReporte

            '/*user controls*/
            Me.UscIdiomaInterno1._VisibleGrabar = Me._FormEscritura
            Me.UscIdiomaInterno1._VisibleEliminar = Me._FormEliminar

            Me.uscGradosAcademicos_LM1._VisibleGrabar = Me._FormEscritura
            Me.uscGradosAcademicos_LM1._VisibleEliminar = Me._FormEliminar

            Me.UscDomicilio1._VisibleGrabar = Me._FormEscritura
            Me.UscDomicilio1._VisibleEliminar = Me._FormEliminar

            '/*nombres asociados*/
            Me.UscGrillaNombresAsociadosV21._VisibleGrabar = Me._FormEscritura

            '/*fotografia*/
            Me.uscFotoPerfiles._VisibleGrabar = Me._FormEscritura
            Me.uscFotoPerfiles._VisibleEliminar = Me._FormEliminar

            '/*reniec*/

            '/*alias y bandas*/
            Me.UserAlias_LM1._VisibleGrabar = Me._FormEscritura
            Me.UserAlias_LM1._VisibleEliminar = Me._FormEliminar

            Me.UscBandas21._VisibleGrabar = Me._FormEscritura
            Me.UscBandas21._VisibleEliminar = Me._FormEliminar

            '/*organizacion criminal*/
            Me.UscOrganizacionCriminal._VisibleGrabar = Me._FormEscritura
            Me.UscOrganizacionCriminal._VisibleEliminar = Me._FormEliminar

            '/*familiares*/
            Me.UscFamilias1._VisibleGrabar = Me._FormEscritura
            Me.UscFamilias1._VisibleEliminar = Me._FormEliminar

            '/*odontograma*/

            '/*huella*/
            Me.UscVisorDetalleHuellas1._ControlSoloVista = Not Me._FormEscritura

            '/*clasificacion*/        

            '/*documento difitalizado*/
            Me.UscVisorDocDigital1._VisibleGrabar = Me._FormEscritura
            Me.UscVisorDocDigital1._VisibleEliminar = Me._FormEliminar

            '/*resolucion*/
            Me.UscResolucionesMain1._VisibleGrabar = Me._FormEscritura
            Me.UscResolucionesMain1._VisibleEliminar = Me._FormEliminar

            '/*movimiento*/
            Me.UscMovimiento1._VisibleGrabar = Me._FormEscritura
            Me.UscMovimiento1._VisibleEliminar = Me._FormEliminar

            Usuario_Permisos_Perfil(blnGrabar, blnEliminar, blnReporte)

        End Sub
        Private Sub Usuario_Permisos_Perfil(blnGrabar As Boolean, blnEliminar As Boolean, blnReporte As Boolean)

            'eliminacion de tabs
            Select Case Me.PerfilUsuarioActual
                Case EnumDependencia.SeguridadPenitenciaria
                    TabControl1.TabPages.Remove(tbpClasificaciones)
                    TabControl1.TabPages.Remove(tbpDocDigitalizadoLegacy)
                    TabControl2.TabPages.Remove(tpListaResol)

                    tbcDatosInterno.TabPages.Remove(tbpHuella)
                    tbcDatosInterno.TabPages.Remove(tbpDocDigitalizados)
                    tbcDatosInterno.TabPages.Remove(tbpFamiliares)
                    tbcDatosInterno.TabPages.Remove(tbpBandas)
                    tbcDatosInterno.TabPages.Remove(tbpAliasBandas)
                    tbcDatosInterno.TabPages.Remove(tbpDatosComplement)
                    tbcDatosInterno.TabPages.Remove(tbpReniec)
                    tbcDatosInterno.TabPages.Remove(tbpNombresAsoc)
                    tbcDatosInterno.TabPages.Remove(tbpOdontograma)

                    With Me.UscMovimiento1
                        ._VisibleGrabar = blnGrabar
                        ._VisibleEliminar = blnEliminar
                    End With

                Case EnumDependencia.SistemasInformacion 'perfil desarrollo

                    With Me.UscOdont
                        ._VisibleGrabar = blnGrabar
                        ._VisibleEliminar = blnEliminar
                    End With

                    With UscClasificaciones1
                        ._VisibleGrabar = blnGrabar
                        ._VisibleEliminar = blnEliminar
                        ._VisibleImprimir = blnReporte
                    End With

                Case EnumDependencia.Odontologo

                    TabControl1.TabPages.Remove(tbpClasificaciones)
                    TabControl1.TabPages.Remove(tbpMandDet)
                    TabControl1.TabPages.Remove(tabMovimiento)

                    TabControl1.TabPages.Remove(tbpDocDigitalizadoLegacy)
                    tbcDatosInterno.TabPages.Remove(tbpHuella)
                    tbcDatosInterno.TabPages.Remove(tbpDocDigitalizados)
                    tbcDatosInterno.TabPages.Remove(tbpFamiliares)
                    tbcDatosInterno.TabPages.Remove(tbpBandas)
                    tbcDatosInterno.TabPages.Remove(tbpAliasBandas)
                    tbcDatosInterno.TabPages.Remove(tbpDatosComplement)
                    tbcDatosInterno.TabPages.Remove(tbpReniec)
                    tbcDatosInterno.TabPages.Remove(tbpNombresAsoc)

                    With Me.UscOdont
                        ._VisibleGrabar = blnGrabar
                        ._VisibleEliminar = blnEliminar
                    End With


                Case EnumDependencia.Legal,
                    EnumDependencia.Social,
                    EnumDependencia.Psicologo

                    tbcDatosInterno.TabPages.Remove(tbpOdontograma)
                    tbcDatosInterno.TabPages.Remove(tbpHuella)
                    TabControl1.TabPages.Remove(tabMovimiento)

                    With UscClasificaciones1
                        ._VisibleGrabar = blnGrabar
                        ._VisibleEliminar = blnEliminar
                        ._VisibleImprimir = blnReporte
                    End With

                Case EnumDependencia.RegistroPenitenciario, EnumDependencia.GabineteIdentificacionOdontologo

                    TabControl1.TabPages.Remove(tbpClasificaciones)

                    With Me.UscOdont
                        ._VisibleGrabar = blnGrabar
                        ._VisibleEliminar = blnEliminar
                    End With

                Case EnumDependencia.SecretariaJuntaClasificacion

                    tbcDatosInterno.TabPages.Remove(tbpHuella)
                    tbcDatosInterno.TabPages.Remove(tbpOdontograma)

                    tbcDatosInterno.TabPages.Remove(tbpNombresAsoc)
                    tbcDatosInterno.TabPages.Remove(tbpFoto)
                    tbcDatosInterno.TabPages.Remove(tbpReniec)
                    tbcDatosInterno.TabPages.Remove(tbpAliasBandas)
                    tbcDatosInterno.TabPages.Remove(tbpBandas)
                    tbcDatosInterno.TabPages.Remove(tbpFamiliares)
                    tbcDatosInterno.TabPages.Remove(tbpOdontograma)
                    tbcDatosInterno.TabPages.Remove(tbpHuella)
                    tbcDatosInterno.TabPages.Remove(tbpDocDigitalizados)

                    TabControl1.TabPages.Remove(tabMovimiento)
                    TabControl1.TabPages.Remove(tbpMandDet)
                    TabControl1.TabPages.Remove(tbpDocDigitalizadoLegacy)
                    TabControl1.TabPages.Remove(tbpClasificaciones)

                Case EnumDependencia.MedioLibre

                    'datos del interno
                    tbcDatosInterno.TabPages.Remove(tbpNombresAsoc)
                    tbcDatosInterno.TabPages.Remove(tbpReniec)
                    tbcDatosInterno.TabPages.Remove(tbpAliasBandas)
                    tbcDatosInterno.TabPages.Remove(tbpBandas)
                    tbcDatosInterno.TabPages.Remove(tbpFamiliares)
                    tbcDatosInterno.TabPages.Remove(tbpOdontograma)
                    tbcDatosInterno.TabPages.Remove(tbpHuella)
                    tbcDatosInterno.TabPages.Remove(tbpDocDigitalizados)

                    'clasificacion
                    TabControl1.TabPages.Remove(tbpClasificaciones)

                    'documento digitalizado
                    TabControl1.TabPages.Remove(tbpDocDigitalizadoLegacy)

                    'documentos judiciales y resoluciones
                    TabControl2.TabPages.Remove(tpListaResol)

                    'movimiento
                    TabControl1.TabPages.Remove(tabMovimiento)

            End Select
        End Sub
#End Region

#Region "Reniec"
        Private Sub Nuevo_Validacion_Reniec()

            UscValidacionReniecV21.ListarInternoValidado(Me._IDInterno)
            Dim entIngreso As New Entity.Registro.IngresoInpe

            entIngreso = (New Bussines.Registro.IngresoInpe).ListarUltimoIngresoInpe(Me._IDInterno, Me.PenalID)
            'realizar la validacion de reniec

            Dim frmValidacion As New Registro.Reniec.frmTipoValidacionV2
            With frmValidacion

                ._InternoID = Me._IDInterno
                '._NroIngresoID = entIngreso.Codigo
                ._IngresoInpeID = entIngreso.Codigo ' Me._IDIngresoINPE
                ._TipoDocumento = Me.TipoDocumento
                ._NumeroDocumento = Me.NumeroDocumento
                ._Estado = Me.InternoEstado
                ._ImagenSis = UscValidacionReniecV21._NumeroImagen
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._TipoLicencia = enmTipoLicencia.Carceleta

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
            UscValidacionReniecV21.Listar_ReniecHistorico(Me._IDInterno)
        End Sub

        Private Function ValidarFichaReniec() As Boolean

            Dim value As Boolean = False

            If Me._IDInterno < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosInterno.SelectedIndex = 0
                Return value
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Me.tbcDatosInterno.SelectedIndex = 0
                Return value
            End If

            If Me.Nacionalidad <> 141 Then '"nacionalidad peruana"
                Me.tbcDatosInterno.SelectedIndex = 0
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Interno no posee la nacionalidad peruana")
                Return value
            End If

            '/****************************/
            Dim objBssFoto As New Bussines.Registro.InternoFoto
            Dim objEnt As New Entity.Registro.InternoFoto
            Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente(Me._IDInterno)
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
                Me.tbcDatosInterno.SelectedIndex = 3
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Interno no puede ser validado porque no cuenta con fotografia, capture la fotografia luego realize la validación")
                Return value
            End If

            value = True

            Return value

        End Function

#End Region
#Region "Otros"



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
            'ComboPabellon()
            ComboNumIngresoINPE()

            Me.TipoDocumento = -1   '10 dni
            Me.Nacionalidad = 141    '141 peruana
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
            UscGrillaNombresAsociadosV21._Documentos_sin_mov = True

            UscResolucionesMain1._TipoLicencia = enmTipoLicencia.Carceleta
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

        Private Function ValidarFotografia() As Integer
            Dim Imagen As Boolean = False
            Dim objBssFoto As New Bussines.Registro.InternoFoto
            Dim objEnt As New Entity.Registro.InternoFoto
            Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente(_IDInterno)

            Dim strPathServer As String = ""
            Dim intImagen As Integer = -1
            Dim intNombreImagen As String = ""

            objBssFoto = New Bussines.Registro.InternoFoto

            objEnt = objBssFoto.ListarGrilla(intCodigo)
            If objEnt.Codigo > 0 Then
                With objEnt
                    intImagen = .PFrenteID
                    intNombreImagen = .PFrenteName
                    strPathServer = .PFrenteServerPath
                End With
                Dim objImagenByte As Byte()
                Dim objWS As New APPWebService.ws_foto.PopeLocal
                If strPathServer <> "" Then 'nueva version
                    objWS.Url = APPWebService.PathURL.WSPopeLocal
                    objImagenByte = objWS.LeerArchivoByte(1, intNombreImagen & ".jpg", strPathServer)
                Else
                    objWS.Url = APPWebService.PathURL.WSPopeLocal

                    objImagenByte = objWS.LeerImageJpg(intNombreImagen, "1")
                End If


                If objImagenByte Is Nothing Then
                    Imagen = False
                Else
                    Imagen = True
                End If
            End If

            Dim Valor As Integer = 0

            If intNombreImagen = "" Then
                Valor = 1
            ElseIf Imagen = False Then
                Valor = 2
            Else
                Valor = 0
            End If
            Return Valor
        End Function
#End Region

        Private Sub frmMantenimiento_Load(sender As Object, e As System.EventArgs) Handles Me.Load


            'ouscodontonew.Size = New Size(860, 496)
            'ouscodontonew.Location = UscOdont.Location
            'ouscodontonew.Visible = False
            'Me.Controls.Add(ouscodontonew)
            HabilitarControlesxTabs()

        End Sub

        Private Sub frmMantenimiento2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown

            Me.formCargaCompletado = False
            Me.PerfilUsuarioActual = Legolas.Configuration.Usuario.OficinaID

            ValoresxDefault()
            Usuario_Permisos()

            ListarData()
            ListarDatosComplementarios()
            ListarDataInternoSeleccionado(Me._IDInternoSeleccionado)

            If InternoFechaNac > 0 Then
                ActivaDesactivaCheckMenorEdad()
            End If

            Me.formCargaCompletado = True

            Me.tbcDatosInterno.TabPages.Remove(tbpDocDigitalizados)
            UscListaResoluciones._TipoLicencia = enmTipoLicencia.Carceleta
            Me.txtApePat.Focus()

            ValidarDuplicadosIngreso()
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
            Select Case Me.tbcDatosInterno.SelectedTab.Name

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
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If

        End Sub

        Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcDatosInterno.SelectedIndexChanged
            Select Case Me.tbcDatosInterno.SelectedTab.Name
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
                Case Me.tbpDocDigitalizadoLegacy.Name
                    LoadArchivoDigital()
                Case Me.tbpHuella.Name
                    LoadUscHuellas()
                Case Me.tbpDocDigitalizados.Name
                    LoadUscDocumentoDigitalizado()
            End Select

            HabilitarControlesxTabs()

        End Sub


        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
            Select Case Me.TabControl1.SelectedTab.Name
                Case Me.tbpInterno.Name
                Case Me.tbpDocDigitalizadoLegacy.Name
                    LoadArchivoDigital()
                Case Me.tbpClasificaciones.Name
                    LoadUscClasificaciones()
                Case Me.tbpMandDet.Name
                    ListarResoluciones()
                    'Listar_Expedientes()
                Case Me.tabMovimiento.Name
                    ListarMovimientosIngreso()
            End Select

            HabilitarControlesxTabs()

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
            If e.KeyChar = "." Then
                e.Handled = True
            End If
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



        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
            Nuevo_Validacion_Reniec()
        End Sub

        Private Sub UscGrillaNombresAsociados1__UpdNombreAsociado(id As Integer, objEntNA As Entity.Registro.NombreAsociado)
            FRM_Mant_NombresAsociados(False, id, objEntNA)
        End Sub

        Private Sub btnFicha_Click(sender As System.Object, e As System.EventArgs) Handles btnFicha.Click
            FRM_VerReportes()
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__AddNombreAsociado() Handles UscGrillaNombresAsociadosV21._AddNombreAsociado

            FRM_Resol_AclaratoriaNombres(-1)

        End Sub

        Private Sub UscGrillaNombresAsociadosV21__UpdNombreAsociado(id As System.Int32, objEnt As Entity.Registro.NombreAsociado, forzarRegistroSoloLectura As Boolean) Handles UscGrillaNombresAsociadosV21._UpdNombreAsociado
            FRM_Mant_NombresAsociados(False, id, objEnt)
        End Sub

        Private Sub UscGrillaBandasV21__AddInternoBanda() Handles UscOrganizacionCriminal._AddInternoBanda
            FRM_Mant_Siscrico(True)
        End Sub

        Private Sub UscGrillaBandasV21__UpdInternoBanda() Handles UscOrganizacionCriminal._UpdInternoBanda
            FRM_Mant_Siscrico(False)
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

            FRM_ListaIngreso(False)

        End Sub

        Private Sub uscFotoPerfiles__Clik_MantenimientoFotos(InternoFotId As System.Int32, RestringirEdicion As Boolean) Handles uscFotoPerfiles._Clik_MantFotos

            FRM_Mant_Fotos(InternoFotId, RestringirEdicion)

        End Sub

        Private Sub uscFotoPerfiles__Clik_MantRasgos(RasgoId As System.Int32, forzarRegistroSoloLectura As Boolean) Handles uscFotoPerfiles._Clik_MantRasgos
            FRM_Mant_Rasgo(RasgoId, forzarRegistroSoloLectura)
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

            FRM_ListaIngreso(True)

        End Sub

        Private Sub UscGrillaNombresAsociadosV21__MostrarResolucionesAclarados() Handles UscGrillaNombresAsociadosV21._MostrarResolucionesAclarados
            UscResolucionesMain1._ChekedValor = True
            TabControl1.SelectedIndex = 1
        End Sub

        Private Sub UserAlias_LM1__ClickAdd() Handles UserAlias_LM1._ClickAdd

            FRM_MantenimientoAlias(True, -1)

        End Sub

        Private Sub UscBandas21__DoubleClikBandas(Nuevo As System.Boolean, AliasID As System.Int32, IngresoID As System.Int32, BandentCol As Entity.Registro.InternoBandaCol, forzarRegistroSoloLectura As Boolean) Handles UscBandas21._DoubleClikBandas
            FRM_MantenimientoBandas(Nuevo, AliasID, IngresoID, BandentCol)
        End Sub

        Private Sub UscBandas21__ClikBandas(Nuevo As System.Int32, BandaID As System.Int32, IngresoID As System.Int32, BandentCol As Entity.Registro.InternoBandaCol) Handles UscBandas21._ClikBandas
            FRM_MantenimientoBandas(Nuevo, BandaID, -1, BandentCol)
        End Sub

        Private Sub UscOdont__ClicK_Modificar(OdontogramaId As Integer) Handles UscOdont._ClicK_Modificar

            FRM_Odontograma(False, OdontogramaId)

        End Sub

        Private Sub UscOdont__Click_Nuevo() Handles UscOdont._Click_Nuevo

            FRM_Odontograma(True, -1)

        End Sub

        Private Sub UscClasificaciones1__Click_FichaDetalle(EntFichaDet As Entity.Clasificacion.Documento.DatosFicha) Handles UscClasificaciones1._Click_FichaDetalle

            FRM_Clasificacion(EntFichaDet)

        End Sub

        Private Sub UscClasificaciones1__Click_PrintFicha(Codigo As System.Int32, grupoFichaId As Integer, TipoFichaId As Type.Enumeracion.Clasificacion.enmTipoFicha) Handles UscClasificaciones1._Click_PrintFicha

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

                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                ._Filtro.InternoID = Me._IDInterno
                ._Filtro.InternoFichaId = Codigo
                ._Filtro.GrupoFichaId = grupoFichaId
                ._Filtro.InternoIngresoInpeID = Me._IDIngresoINPE

                .ShowDialog()

            End With
        End Sub

        Private Sub UscMovimiento1__Click_AddNuevoMovimiento(NroPendientes As Integer, strMensaje As String) Handles UscMovimiento1._Click_AddNuevoMovimiento
            FRM_MovimientoTipo(NroPendientes, strMensaje)
        End Sub

        Private Sub UscMovimiento1__Click_EliminarMovimiento() Handles UscMovimiento1._Click_EliminarMovimiento
            Me.UscMovimiento1._Listar()
            ListarCabecera()
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnEliminarActualizarEstadoInterno_1() Handles UscResolucionesMain1._Click_BtnEliminarActualizarEstadoInterno
            ListarCabecera()
            ListarData()
            UscGrillaNombresAsociadosV21._LoadUsc()
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnNuevoResolucion(IngresoID As System.Int32, ResIngRegistrado As System.Boolean, Opcion As System.Int32) Handles UscResolucionesMain1._Click_BtnNuevoResolucion
            FRM_NuevoMandato()
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnVerExpedientesPorResolucion(IdResolucion As System.Int32) Handles UscResolucionesMain1._Click_BtnVerExpedientesPorResolucion
            FRM_ListadoExpediente()
        End Sub

        Private Sub UserAlias_LM1__ClickMod(AliasID As Integer, x As Integer, forzarRegistroSoloLectura As Boolean) Handles UserAlias_LM1._ClickMod
            FRM_MantenimientoAlias(False, AliasID)
        End Sub

        Private Sub UscFamilias1__CellDoubleClick(IDFamilia As Integer, objEntFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean) Handles UscFamilias1._CellDoubleClick
            UscFamilias1__ClickModificar(IDFamilia, objEntFamCol, forzarRegistroSoloLectura)
        End Sub

        Private Sub UscFamilias1__ClickAdd(objEntFamCol As Entity.Registro.FamiliarCol) Handles UscFamilias1._ClickAdd
            FRM_Mant_Familia(True, -1, objEntFamCol)
        End Sub

        Private Sub UscFamilias1__ClickModificar(IDFamilia As Integer, objEntFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean) Handles UscFamilias1._ClickModificar
            FRM_Mant_Familia(False, IDFamilia, objEntFamCol)
        End Sub

        Private Sub TabControl2_Selecting(sender As Object, e As System.Windows.Forms.TabControlCancelEventArgs) Handles tbcDatosInterno.Selecting

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


        Private Sub UscMandatoDetencion__CellDoubleClick_GrillaExpediente(ExpedienteCodigo As Integer)

            FRM_MantExpediente(False, ExpedienteCodigo)

        End Sub
        Private Sub UscGrillaNombresAsociadosV21__AnularNombreAsociado() Handles UscGrillaNombresAsociadosV21._AnularNombreAsociado
            UscGrillaNombresAsociadosV21._LoadUsc()
        End Sub
        Private Sub UscMovimiento1__CellDoubleClick_UpdateMovimiento(MovimientoID As System.Int32, MovimientoGrupoID As System.Int32, MovimientoTipoID As System.Int32, MovimientoMotivoID As System.Int32, IngresoID As System.Int32, DocumentoJudID As System.Int32, Pendientes As System.Int32) Handles UscMovimiento1._CellDoubleClick_UpdateMovimiento
            FRM_Movimiento(MovimientoID, MovimientoGrupoID, MovimientoTipoID, MovimientoMotivoID, IngresoID, DocumentoJudID, Pendientes)
        End Sub

        Private Sub cbbNroIngresosINPE_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbNroIngresoInpe.SelectedIndexChanged

            If blnComboIngreso = True Then
                If Me._IDInterno < 1 Or Me._IDIngresoINPE < 1 Then
                    Exit Sub
                End If

                If objEntIngresoInpeCol.Count > 0 Then
                    'obtener ingresoId desde la lista
                    For Each obj As Entity.Registro.IngresoInpe In objEntIngresoInpeCol
                        If obj.Codigo = Me._IDIngresoINPE Then
                            Me._IDIngreso = obj.IDIngreso
                            Exit For
                        End If
                    Next
                    'Me._IDIngreso = objEntIngresoInpeCol.Item(0).Codigo
                Else
                    Me._IDIngreso = -1
                End If

                If Me.formCargaCompletado = True Then
                    TabControl1_SelectedIndexChanged(sender, e)
                    TabControl2_SelectedIndexChanged(sender, e)
                    uscFotoPerfiles.DataGrieView_Click()
                End If

            End If
        End Sub

        Private Sub UserAlias_LM1__DoubleClick(AliasID As Integer, IngresoID As Integer, forzarRegistroSoloLectura As Boolean) Handles UserAlias_LM1._DoubleClick
            FRM_MantenimientoAlias(False, AliasID)
        End Sub

        Private Sub cbbCodFuerArmada_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbCodFuerArmada.SelectedIndexChanged
            If blnComboFzaArm = True Then
                ComboRangoFuerzaArmada()
            End If
        End Sub

        Private Sub FRM_MantenimientoDocDigitalizado(ByVal Nuevo As Boolean, id As Integer)
            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos básicos del interno")
                Me.tbcDatosInterno.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Exit Sub
            End If

            Dim frm As New Registro.Captura.frmDocDigitalizadoPopup
            With frm
                If Nuevo = False Then
                    ._Codigo = id
                End If
                ._RegionId = Me.RegionID
                ._PenalId = Me.PenalID
                ._internoId = Me._IDInterno
                ._IngresoId = Me._IDIngreso
                ._IngresoInpeId = Me._IDIngresoINPE
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta

                ._FormEscritura = UscVisorDocDigital1._VisibleGrabar
                ._FormEliminar = UscVisorDocDigital1._VisibleEliminar
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    LoadUscDocumentoDigitalizado()
                End If
            End With

        End Sub

        Private Sub UscVisorDocDigital1__Click_Add() Handles UscVisorDocDigital1._Click_Add
            FRM_MantenimientoDocDigitalizado(True, -1)
        End Sub

        Private Sub UscVisorDocDigital1__ClicK_Modificar(Codigo As System.Int32) Handles UscVisorDocDigital1._ClicK_Modificar
            FRM_MantenimientoDocDigitalizado(False, Codigo)
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnModificarResolucion(TipoDocumento As System.Int32, DocJudicialId As System.Int32, SubTipo As System.Int32, _penId As System.Int32, Version As System.String) Handles UscResolucionesMain1._Click_BtnModificarResolucion
            FRM_Resolucion_Sentencia(TipoDocumento, DocJudicialId, SubTipo, _penId, False)
        End Sub

        Private Sub UscListaResoluciones__Click_BtnModificarResolucion(TipoDocumento As System.Int32, DocJudicialId As System.Int32, SubTipo As System.Int32, _penId As System.Int32, Version As System.String) Handles UscListaResoluciones._Click_BtnModificarResolucion
            FRM_Resolucion_Sentencia(TipoDocumento, DocJudicialId, SubTipo, _penId, True)
        End Sub

        Private Sub TabControl2_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
            Select Case Me.TabControl2.SelectedTab.Name
                Case Me.tpListaResol.Name
                    UscListaResoluciones._Listar()
                    'Case Me.tabMandDet.Name
                    'Listar_Expedientes()
            End Select

            HabilitarControlesxTabs()
        End Sub

        Private Sub dtpFechaNac__LostFocus() Handles dtpFechaNac._LostFocus
            Try
                lblEdad.Text = Legolas.Components.FechaHora.FechaCalcularAnio(Me.dtpFechaNac.ValueLong, Legolas.Configuration.Aplication.FechayHora.FechaLong, True)
            Catch ex As Exception
                lblEdad.Text = ""
            End Try
        End Sub

        Private Sub UscClasificaciones1__Show_AuditFicha(IdFicha As Integer, TipoTablaAudit As Type.Enumeracion.TipoTabla.EnumTipTabla) Handles UscClasificaciones1._Show_AuditFicha
            Me.UscAuditUser1.LoadAudit(IdFicha, TipoTablaAudit)
        End Sub

        Private Sub UscBandas21__ClikBandas(Nuevo As Boolean, BandaID As Integer, n_IngresoInpeId As Integer, objEntColBandas_ As Entity.Registro.InternoBandaCol) Handles UscBandas21._ClikBandas

        End Sub

        Private Sub UscBandas21__DoubleClikBandas(Nuevo As Integer, AliasID As Integer, n_IngresoInpeId As Integer, objEntColBandas_ As Entity.Registro.InternoBandaCol, forzarRegistroSoloLectura As Boolean) Handles UscBandas21._DoubleClikBandas

        End Sub

        Private Sub UscGrillaBandasV21__UpdInternoBanda(forzarRegistroSoloLectura As Boolean) Handles UscOrganizacionCriminal._UpdInternoBanda

        End Sub

        Private Sub UscClasificaciones1__Click_btn_Formato06(FichaId As Integer, variableIndicador As String, escritura As Boolean) Handles UscClasificaciones1._Click_btn_Formato06
            Dim f As New Registro.Carceleta.Clasificacion.frmEditorTextPopup
            With f
                ._IdFicha = FichaId
                ._FormEscritura = escritura 'pendientehntb asignar permiso UscVisorDocDigital1._VisibleGrabar
                ._FormEliminar = escritura 'UscVisorDocDigital1._VisibleEliminar
                ._VariableIndicador = variableIndicador
                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                End If
            End With
        End Sub

        Private Sub UscClasificaciones1__Click_PrintFormato06(IdFicha As Integer, grupoFichaId As Integer) Handles UscClasificaciones1._Click_PrintFormato06
            Dim frm As New APPReporte.Registro.ReporteCrystal

            With frm

                ._TipoReporte = Type.Reporte.Registro.rptClasificacionFormato06
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                ._Filtro.InternoID = Me._IDInterno
                ._Filtro.InternoFichaId = IdFicha
                ._Filtro.GrupoFichaId = grupoFichaId
                ._Filtro.InternoIngresoInpeID = Me._IDIngresoINPE

                .ShowDialog()

            End With
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
    End Class
End Namespace
