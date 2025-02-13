'version del form3fdg
Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.TipoDocJudicial
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Type.Enumeracion.Usuario
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.Auditoria

Namespace Registro.Main.Region
    Public Class frmMantenimiento
        Private objBssInterno As Bussines.Registro.Interno = Nothing
        Private objBssIngreso As Bussines.Registro.Ingreso = Nothing
        Private objBssHistorico As Bussines.Registro.InternoHistorico
        Private objEntInt As Entity.Registro.Interno = Nothing

        Private blnModificarDatos As Boolean = False
        Private formCargaCompletado As Boolean = False
        Private ValorIngreso As Boolean = False
        Private blnAddIngresos As Boolean = False
#Region "Propiedades_Publicas"
        Public Property _TipoInterno As Short = Type.Enumeracion.Interno.enmTipoInterno.Interno
        Private objEntIngresoInpeCol As New Entity.EntityCol(Of Entity.Registro.IngresoInpe)
#End Region
#Region "Propiedades_Interno"
        Public Property _IDInterno As Integer = -1
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
                    Return CInt(Me.cbbCodFuerArmada.SelectedValue)
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
        Public Property _Documentos_sin_mov As Boolean = False
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
                    Return CInt(Me.cbbPais.SelectedValue)
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
        Public Property RegionID() As Short = 3 'region lima
        Public Property RegionNombre() As String = ""
        Public Property PenalID() As Short = -1
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

        Private Property Pabellon() As String
            Get
                Return Me.txtPabellon.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtPabellon.Text = value
            End Set
        End Property

        Public ReadOnly Property _IDIngresoINPE() As Integer
            Get
                Try
                    Return Me.cbbNroIngresoInpe.SelectedValue
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
                        'txtEstado.BackColor = Color.White
                        txtEstado.BackColor = Control.DefaultBackColor()
                End Select
                Me.txtEstado.Text = value

            End Set
        End Property
#End Region
#Region "Propiedades_Config"
        Private ReadOnly Property PerfilUsuario As Short
            Get
                Return Legolas.Configuration.Usuario.OficinaID
            End Get
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
        Private blnComboIngreso As Boolean = False
        Public Sub ComboNumIngresoInpe()

            blnComboIngreso = False

            If Me._IDInterno < 1 Then
                Exit Sub
            End If

            objEntIngresoInpeCol = (New Bussines.Registro.IngresoInpe).ListarNroIngreso(Me._IDInterno)
            objEntIngresoInpeCol.Sort("IngresoNro", Entity.SortDirection.Desc)

            With Me.cbbNroIngresoInpe
                .DataSource = objEntIngresoInpeCol
                .DisplayMember = "IngresoNroLetra"
                .ValueMember = "Codigo"
            End With

            Me.lblIngresoInpe.Text = "N° Ingreso INPE: " & "(ID: " & Me._IDIngresoINPE.ToString & ")"

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

            objEntCol = (New Bussines.Registro.IngresoInpe).ListarNroIngreso(Me._IDInterno)
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
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Tenga en cuenta que existe N° de ingresos 0, por lo que " +
                                                                        " se recomienda verificar y actualizar la informacion del ingreso.")

                'If blnNumIngreDuplicado = True Then
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados y Nº de ingreso [0]." + Chr(13) +
                '                                                    "Debe regularizar para poder realizar una operación," + Chr(13) +
                '                                                    "Ir a la lista de ingresos.")
                'Else
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un Nº de ingreso [0]." + Chr(13) +
                '                                                        "Debe regularizar para poder realizar una operación," + Chr(13) +
                '                                                        "Ir a la lista de ingresos.")
                'End If
                'blnEliminarTab = True
            End If

            If blnNumIngreDuplicado = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Tenga en cuenta que existe N° de ingresos duplicados, por lo que " +
                                                                        " se recomienda verificar el ingreso seleccionado en función a la fecha.")

                'If blnIngreso0 = True Then
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados y Nº de ingreso [0]." + Chr(13) +
                '                                                      "Debe regularizar para poder realizar una operación," + Chr(13) +
                '                                                      "Ir a la lista de ingresos.")
                'Else
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe N° de ingresos duplicados," + Chr(13) +
                '                                                     "Debe regularizar para poder realizar una operación," + Chr(13) +
                '                                                     "Ir a la lista de ingresos.")
                'End If
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

            If Me._IDInterno < 1 Then
                Exit Sub
            End If

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

            If Me._IDInterno < 1 Then
                Exit Sub
            End If

            Dim objEnt As Entity.Registro.Interno = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)

            Me.CodigoRPInterno = objEnt.CodigoRP
            Me.InternoEstado = objEnt.EstadoID

            ListarCabecera()

        End Sub

        Private Sub ListarCabecera()

            Me.txtCodigo.Text = Me.CodigoRPInterno
            Dim intIDPenal As Short = -1

            objEntInt = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)

            With objEntInt
                Me.InternoApePaternoAux = .ApellidoPaterno
                Me.InternoApeMaternoAux = .ApellidoMaterno
                Me.InternoNombresAux = .Nombres
                Me.txtInterno.Text = Me.InternoApeyNomHis(.ApellidoPaterno, .ApellidoMaterno, .Nombres)
                Me.CabeceraEstado = Bussines.Registro.Interno.EstadoNombre(Me._IDInterno)
                intIDPenal = .PenalID
            End With

            'If intIDPenal = 35 Then
            '    Me.lblRegistroRealizado.Text = "Interno Registrado por: ETP Lima"
            'Else
            '    Me.lblRegistroRealizado.Text = "Interno Registrado por: ORL."
            'End If

        End Sub

        Private Sub ListarDataInterno(objEnt As Entity.Registro.Interno, Optional ValidarIDInterno As Boolean = True)

            If ValidarIDInterno = True Then

                If Me._IDInterno < 1 Then
                    Exit Sub
                End If

            End If

            With objEnt

                '/*datos generales*/
                If ValidarIDInterno = True Then
                    Me.CodigoRPInterno = .CodigoRP
                End If

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

                'codigo decadacilar, jmr-06.09.2018
                If .Decadactilar.Length > 2 Then
                    If .Decadactilar.Contains("|") = True Then
                        Dim d() As String = .Decadactilar.Split("|")
                        Me.DecadactilarIzq = d(0)
                        Me.DecadactilarDer = d(1)
                    Else

                        'que los caracteres tengan 10 digitos
                        If .Decadactilar.Trim.Length = 10 Then
                            Me.DecadactilarIzq = .Decadactilar.Substring(0, 5)
                            Me.DecadactilarDer = .Decadactilar.Substring(5, 5)
                        End If

                    End If
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
                'Me.PabellonID = .PabellonID
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

            End With

        End Sub

        Private Sub ListarData()

            If Me._IDInterno < 1 Then
                AEliminarTabs()
                Exit Sub
            End If

            'Dim objEnInternoFiltroHisto As New Entity.Registro.InternoHistorico
            Dim objEntIngresoINPE As Entity.Registro.IngresoInpe
            'objBssInterno = New Bussines.Registro.Interno

            'jmr, se envio el penal -1, xq en region lima, debe ver todos los ingresos de todos los penales
            objEntIngresoINPE = (New Bussines.Registro.IngresoInpe).ListarUltimoIngresoInpe(Me._IDInterno, -1)

            If objEntIngresoINPE Is Nothing Then 'cargar los datos de la tabla interno
                Dim objEntInterno As New Entity.Registro.Interno
                objEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)
                If objEntInterno Is Nothing Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError(
                   "No se ha encontrado al Interno o posiblemente haya sido eliminado.")
                    Me.Close()
                    Exit Sub
                Else
                    ListarDataInterno(objEntInterno)
                    Me.UscAuditUser1.LoadAudit(Me._IDInterno, EnumTipTabla.INT_Interno)
                End If
            Else

                'cargar de historico
                Dim objEnInternoHisto As New Entity.Registro.InternoHistorico
                objBssHistorico = New Bussines.Registro.InternoHistorico
                objEnInternoHisto = objBssHistorico.ListarUltimoHistorico_region_lm(Me._IDInterno, Me._IDIngresoINPE)

                If Not objEnInternoHisto Is Nothing Then
                    objEnInternoHisto.PenalID = objEntIngresoINPE.PenalID
                    ListarInternoHistorico(objEnInternoHisto)
                    Me.UscAuditUser1.LoadAudit(objEnInternoHisto.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoHistorico)

                Else
                    Dim objEntInterno As New Entity.Registro.Interno
                    objEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)
                    ListarDataInterno(objEntInterno)
                    Me.UscAuditUser1.LoadAudit(Me._IDInterno, EnumTipTabla.INT_Interno)
                End If
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
                'Me.PabellonID = .PabellonID
                Me.Pabellon = .PabellonNombre
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

                Me.UscGradosAcademicos1._PenalId = Me.PenalID
                Me.UscGradosAcademicos1._RegionId = Me.RegionID
                Me.UscGradosAcademicos1._InternoId = Me._IDInterno
                Me.UscGradosAcademicos1._IngresoInpeID = Me._IDIngresoINPE
                Me.UscGradosAcademicos1._IngresoNroLetra = cbbNroIngresoInpe.Text
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


        Private Sub ListarDatosComplementarios()

            With UscIdiomaInterno1
                ._InternoId = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                ._RegionId = Me.RegionID
                ._PenalId = Me.PenalID
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._LoadUsc()
            End With

            With UscGradosAcademicos1
                ._PenalId = Me.PenalID
                ._RegionId = Me.RegionID
                ._IngresoInpeID = Me._IDIngresoINPE
                ._InternoId = Me._IDInterno
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._LoadUsc()
            End With

            With UscDomicilio1
                ._PenalId = Me.PenalID
                ._RegionId = Me.RegionID
                ._IngresoInpeID = Me._IDIngresoINPE
                ._InternoId = Me._IDInterno
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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
                ._Documentos_sin_mov = True
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._LoadUsc()
            End With
        End Sub

        Private Sub LoadUscFotografia()
            With uscFotoPerfiles
                ._InternoID = Me._IDInterno
                ._InternoCodigoRP = Me.CodigoRPInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                .InternoFotoID = -1
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                .LoadUsc()
                uscFotoPerfiles.DataGrieView_Click()
            End With
        End Sub

        Private Sub LoadUscListarAlias()
            With UscAlias21
                .InternoID = Me._IDInterno
                .IngresoInpeID = Me._IDIngresoINPE
                .PenalID = Me.PenalID
                .RegionID = Me.RegionID
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._Load()
            End With
        End Sub

        Private Sub LoadUscListarBandas()
            With UscBandas21
                .InternoID = Me._IDInterno
                .IngresoInpeID = Me._IDIngresoINPE
                .PenalID = Me.PenalID
                .RegionID = Me.RegionID
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._Load()
            End With
        End Sub

        Private Sub LoadUscOrganizacionCriminal()

            If Me._IDInterno < 1 Then Exit Sub

            With UscOrganizacionCriminal
                ._InternoID = Me._IDInterno
                ._InternoIngresoID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._VisibleGrabar = Me._FormEscritura
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._LoadUsc()
            End With
        End Sub

        Private Sub ListarFamilia()
            With UscFamilias1
                ._IDInterno = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._LoadUsc()
            End With
        End Sub

        Private Sub LoadUscOdontograma()

            If Me._IDInterno < 1 Then Exit Sub

            With UscOdont
                ._InternoId = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._RegionId = Me.RegionID
                ._PenalId = Me.PenalID
                ._LoadUsc()
            End With

        End Sub

        Private Sub LoadUscHuellas()

            If Me._IDInterno < 1 Then
                Exit Sub
            End If

            With UscVisorDetalleHuellas1
                ._InternoId = Me._IDInterno
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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

        Private Sub Listar_Expedientes()

            If Me._IDIngresoINPE < 1 Or Me._IDInterno < 1 Then Exit Sub

            With Me.UscMandatoDetencion
                ._InternoID = Me._IDInterno
                ._InternoEstado = Me.InternoEstado
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                ._IDIngresoINPE = Me._IDIngresoINPE
                ._VisibleAnulacion = True
                ._VisiblePadin = True
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._LoadUsc()
            End With

        End Sub

        Public Sub ListarResoluciones()
            If Me._IDIngresoINPE < 1 Or Me._IDInterno < 1 Then Exit Sub
            With Me.UscResolucionesMain1
                ._Codigo = -1
                ._InternoID = Me._IDInterno
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._IngresoInpeID = Me._IDIngresoINPE
                ._NroIngresoID = -1
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                .LoadUsc()
            End With
        End Sub

        Private Sub ListarMovimientosIngreso()
            If Me._IDIngresoINPE < 1 Or Me._IDInterno < 1 Then Exit Sub
            With Me.UscMovimiento1
                ._InternoID = Me._IDInterno
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._IngresoInpeID = Me._IDIngresoINPE
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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
        Private Function ValidaInternoActivo() As Boolean

            If cbbNroIngresoInpe.Items.Count = 0 Then
                Return True
            End If

            Dim value As Boolean = True

            If Me.CabeceraEstado = "INACTIVO" Then

                If Me.PenalID = -1 Then 'registros de internos realizados solo x region lima
                    Return value
                Else
                    value = False
                End If

            End If

            Return value
        End Function
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
            Select Case Me._TipoInterno
                Case Type.Enumeracion.Interno.enmTipoInterno.Interno
                    If Me.InternoFechaNac < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha de nacimiento del Interno")
                        Me.dtpFechaNac.Focus()
                        Return False
                    End If
            End Select

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
        Private Sub AGrabar()

            Select Case Me.tbcDatosPersonales.SelectedTab.Name

                Case Me.tbpDatos.Name
                    If ValidaInternoActivo() = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Interno inactivo, no es posible completar la operación.")
                        Exit Sub
                    End If

                    Select Case Me.btnGrabar.Text.Trim

                        Case "&Modificar"
                            EnabledControles(False)

                            Me.btnGrabar.Image = My.Resources.Drive___USB_32
                            Me.btnGrabar.Text = "&Grabar"

                        Case "&Grabar"

                            If Validar() = True Then
                                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                                    AGrabarInterno()
                                    EnabledControles(True)
                                Else
                                    btnCancelar_Click(Nothing, Nothing)
                                End If
                            End If

                    End Select

            End Select
        End Sub
        Private Sub AGrabarInterno()
            Dim intValue As Integer = -1

            Dim obEntInterno As New Entity.Registro.Interno

            If Me._IDInterno > 0 Then
                obEntInterno = (New Bussines.Registro.Interno).Listar_LM(Me._IDInterno)
            End If

            With obEntInterno
                .Codigo = Me._IDInterno
                .TipoInterno = Me._TipoInterno
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
                '.PabellonID = Me.PabellonID
                .PabellonNombre = Pabellon
                .Decadactilar = Me.DecadactilarIzq & "|" & Me.DecadactilarDer
                .Homonimia = Me.chk_Homonimia.Checked
                .GeneroId = Me.GeneroPersonaId
                .NombreClaveInterno = Me.NombreClaveInterno
                .ReligionId = Me.ReligionId
                .CentroTrabajo = Me.txtCentroTrabajo.Text
                .CodigoFuerzaArmadaId = Me.CodigoFuerzaArmadaId
                .CodigoRangoId = Me.CodigoRangoId
                .IdiomaNativoId = Me._IdiomaNativoId
                .TrasladadoDeCarceleta = 1 'internos que se crean solo en region lima con el estado terminado de carcleta
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID

                .VersionRegistro = "V6_RLM"
            End With

            'grabar datos del interno
            Dim blnaux As Boolean = False

            If Me._IDInterno < 1 Then
                blnaux = True
            End If

            Dim outSms As String = ""
            intValue = (New Bussines.Registro.Interno).Grabar_RegionLima(obEntInterno, outSms)

            If intValue < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(outSms)
            End If

            If intValue > 0 Then
                Me._IDInterno = intValue

                If blnaux = True Then
                    Me.NumeroDocumentoAux = Me.NumeroDocumento
                End If

                Me.UscAuditUser1.LoadAudit(Me._IDInterno, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Interno)
            End If


            If intValue > 0 Then
                ListarCodigoRP()
                ListarCabecera()

                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

                EnabledControles(True)
                Me.btnGrabar.Image = My.Resources._1277961326_folder_edit
                Me.btnGrabar.Text = "&Modificar"

                If cbbNroIngresoInpe.Items.Count = 0 Then
                    FRM_MantIngreso(True)
                End If
            End If

        End Sub
        Private Sub AEliminarInterno()

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de eliminar el registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim strMensaje As String = "No se puede eliminar el Interno." + Chr(13) +
                         "Porque cuenta con : "
            Dim ent As New Entity.Registro.InternoMovimiento
            ent.InternoID = Me._IDInterno
            If ((New Bussines.Registro.InternoMovimiento).ListarGrilla_LM(ent).Count) > 0 Then
                strMensaje = strMensaje + " Movimientos activos."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If
            Dim CantidadDoc As Integer = (New Bussines.Registro.DocumentoJudicial).CantidadDocumentosExpedientes_LM(Me._IDInterno)
            If CantidadDoc > 0 Then
                If CantidadDoc = 1 Then
                    strMensaje = strMensaje + " Documentos Judiciales activos."
                Else
                    strMensaje = strMensaje + " Expedientes activos de CARCELETA"
                End If
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If
            Dim objIngresoInp As New Entity.Registro.IngresoInpe
            objIngresoInp.InternoID = Me._IDInterno
            If ((New Bussines.Registro.IngresoInpe).Listar_V2(objIngresoInp).Count) > 0 Then
                strMensaje = strMensaje & "Ingresos activos."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Exit Sub
            End If
            strMensaje = "Esta seguro de eliminar definitivamente el registro del interno." + Chr(13) +
             "Al realizar esta operacion el registro del interno" + Chr(13) +
              "no Pasara al estado inactivo." + Chr(13) +
             "" + Chr(13) +
                              "Esta accion eliminará los siguientes datos: " + Chr(13) +
              "" + Chr(13) +
                  "1. Identificacion del Interno " + Chr(13) +
                  "   (Datos personales, Fotos, Nombres asociados, etc)" + Chr(13) +
                  "2. Datos de Lista de Expedientes " + Chr(13) +
                  "3. Datos de Documentos judiciales y resoluciones" + Chr(13) +
                  "4. Datos de Movimiento de ingreso y egreso." + Chr(13) +
                  "" + Chr(13) +
                  "" + Chr(13) +
                  "Aun asi desea continuar con la operacion?"
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = Windows.Forms.DialogResult.Yes Then
                Dim objBss As New Bussines.Registro.Interno
                Dim Value As Integer = -1
                Value = objBss.Eliminar(Me._IDInterno, "")
                If Value > 0 Then
                    Me._IDInterno = -1
                    Me.Close()
                End If
            End If

        End Sub
#End Region
#Region "Formulario"
#Region "Datos del Interno"

        Private Sub FRM_Mant_SeniaParticular(IdSeniaPart As Integer)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmSeñasPartiPopup
            With frm
                .Codigo = IdSeniaPart
                ._InternoID = Me._IDInterno
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._InternoIngresoNro = Val(cbbNroIngresoInpe.Text)
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = uscFotoPerfiles._VisibleGrabar ' Me._FormEscritura
                ._FormEliminar = uscFotoPerfiles._VisibleEliminar ' Me._FormEliminar

                If .ShowDialog = DialogResult.OK Then uscFotoPerfiles.ListarSenasParti()
            End With
        End Sub

        Private Sub FRM_Mant_Rasgo(IdRasgo As Integer)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.frmRasgosPartiPopup
            With frm
                .Codigo = IdRasgo
                ._InternoID = Me._IDInterno
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._NroIngreso = Val(cbbNroIngresoInpe.Text)
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._FormEscritura = uscFotoPerfiles._VisibleGrabar ' Me._FormEscritura
                ._FormEliminar = uscFotoPerfiles._VisibleEliminar 'Me._FormEliminar

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
                .InternoIngresoId = Me._IDIngresoINPE
                .RestringirEdicion = RestringirEdicion
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                .InternoIngresoNro = Val(Me.cbbNroIngresoInpe.SelectedIndex + 1)
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

        Private Sub FRM_Mant_NombresAsociados(ByVal Nuevo As Boolean, ByVal Codigo As Integer, objEntNA As Entity.Registro.NombreAsociado)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If
            Dim frm As New Registro.RegionLima.Identificacion.frmNombreAsociadoPopup(Nothing)
            With frm
                .InternoID = Me._IDInterno
                ._IngresoInpeID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                If Nuevo = True Then
                    ._PenalID = -1
                Else
                    ._PenalID = Me.PenalID
                    .Codigo = Codigo
                    .objEntNomAsoc = objEntNA
                    .ListarData()
                End If
                .ApellidoPaternoCopi = Me.InternoApePaterno
                .ApellidoMaternoCopi = Me.InternoApeMaterno
                .NombresCopi = Me.InternoNombres

                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarCabecera()
                    ListarData()
                    ListarResoluciones()
                    UscGrillaNombresAsociadosV21._LoadUsc()
                End If
            End With



        End Sub

        Private Sub FRM_MantenimientoAlias(ByVal Nuevo As Boolean, AliasID As Integer)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosPersonales.SelectedIndex = 0 'datos generales
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
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana

                'permisos
                ._FormEscritura = UscAlias21._VisibleGrabar
                ._FormEliminar = UscAlias21._VisibleEliminar
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then LoadUscListarAlias()

            End With
        End Sub

        Private Sub FRM_MantenimientoBandas(ByVal Nuevo As Boolean, InternoBandaID As Integer, BandaIngesoID As Integer, objEntColBandas As Entity.Registro.InternoBandaCol)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno.")
                Me.tbcDatosPersonales.SelectedIndex = 0 'datos generales
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
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._NroIngresoID = -1
                ._NroIngresoInpeID = Me._IDIngresoINPE
                'permisos
                ._FormEscritura = UscBandas21._VisibleGrabar
                ._FormEliminar = UscBandas21._VisibleEliminar

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then LoadUscListarBandas()

            End With
        End Sub

        Private Function FRM_Mant_Siscrico_Anular() As Integer '24.04.2014 hnrb--> para crear documento judicial de anulacion de registro

            Dim frm As New Registro.Documento.frmDocJudicial
            With frm
                ._DocumentoJudicialID = -1
                ._InternoID = Me._IDInterno
                ._IngresoID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Siscrico
                .TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana

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
                Me.tbcDatosPersonales.SelectedIndex = 0 'datos generales
                Exit Sub
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                cbbNroIngresoInpe.Focus()
                Exit Sub
            End If

            Dim frm As New Registro.Siscrico.Bandas.frmInternoBandaPopupV2
            With frm
                If Nuevo Then
                    .Codigo = -1
                    ._IngresoInpeID = Me._IDIngresoINPE
                Else
                    .Codigo = Me.UscOrganizacionCriminal.GrillaID
                    ._NroIngresoID = Me.UscOrganizacionCriminal.GrillaIngresoID
                End If
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                .InternoID = Me._IDInterno
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                'permisos
                ._VisibleGrabar = UscOrganizacionCriminal._VisibleGrabar
                ._FormEscritura = UscOrganizacionCriminal._VisibleGrabar
                ._FormEliminar = UscOrganizacionCriminal._VisibleEliminar

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscOrganizacionCriminal._LoadUsc()
                End If

            End With
        End Sub

        Private Sub FRM_Mant_Familia(ByVal Nuevo As Boolean, IDFamilia As Integer, objFamCol As Entity.Registro.FamiliarCol)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosPersonales.SelectedIndex = 0 'datos generales
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
                ._NroIngresoID = Me._IDIngresoINPE
                If Nuevo = True Then
                    .Codigo = -1
                    ._objEntColFam = objFamCol
                    ._NuevoFam = Nuevo
                Else
                    .Codigo = IDFamilia
                    ._objEntColFam = objFamCol
                    ._NuevoFam = Nuevo
                End If
                .TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = UscFamilias1._VisibleGrabar
                ._FormEliminar = UscFamilias1._VisibleEliminar

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
                ._RegionID = 3
                ._PenalID = Me.PenalID
                ._InternoID = Me._IDInterno
                ._InternoApeNom = Me.InternoApeyNom
                ._TipoReporte = Reporte.frmReportePopup_LM.enmListarReportes.Interno
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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

            Dim frm As New Registro.Captura.frmOdontogramaPopup

            frm._InternoId = Me._IDInterno
            frm._InternoIngresoId = Me._IDIngresoINPE
            frm._PenalId = Me.PenalID
            frm._RegionId = Me.RegionID
            frm._FormEscritura = False
            frm._FormLectura = False
            frm._FormEliminar = False
            If Nuevo = True Then
                frm._Codigo = -1
            Else
                frm._Codigo = IDOdontograma
            End If

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                '    UscOdont._LoadUsc()
            End If

        End Sub

        Private Sub FRM_MantIngreso(blnNuevoIngreso As Boolean)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Me.cbbNroIngresoInpe.Text = "[Por regularizar]" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un ingreso, regularizar el Nº de ingreso [0].")
                Exit Sub
            End If

            Dim frm As New Registro.Identificacion.RegionLM.frmIngresoPopup_v2
            With frm
                ._IDInterno = Me._IDInterno
                'permisos
                ._AgregarNuevoIngreso = blnNuevoIngreso
                ._FormEscritura = blnAddIngresos
                ._FormEliminar = Me._FormEliminar
                '/**********************/
                If frm.ShowDialog = DialogResult.OK Then

                    ComboNumIngresoInpe()
                    ListarData()

                    Me.UscMandatoDetencion._IDIngresoINPE = Me.cbbNroIngresoInpe.SelectedValue
                    Me.UscMandatoDetencion._LoadUsc()

                    Me.UscResolucionesMain1._NroIngresoID = Me.cbbNroIngresoInpe.SelectedValue
                    Me.UscResolucionesMain1.LoadUsc()

                End If

            End With
        End Sub

#End Region

#Region "Expediente"
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, ByVal ExpedienteCodigo As Integer)

            If Me._IDIngresoINPE < 1 Or Me._IDIngresoINPE < 1 Then
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
                ._InternoID = Me._IDInterno
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._IngresoID = -1 'IngresoCodigo
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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

            If Me._IDInterno < 1 Or Me._IDIngresoINPE < 1 Or ExpedienteCodigo < 1 Then
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

            If Me._IDInterno < 1 Or Me._IDIngresoINPE < 1 Or ExpedienteCodigo < 1 Or DelitoCodigo < 1 Then
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
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMandatoDetencion._ListarAgraviado()
                End If
            End With
        End Sub
#End Region

#Region "Resoluciones"
        Private Sub FRM_ListadoExpediente()
            Dim frm As New Registro.Resoluciones.frmVerExpePorResolPopup(_IDIngresoINPE, _IDInterno)
            frm._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
            frm.ShowDialog()
        End Sub

        Private Sub FRM_Modificar_Resolucion(TipoResolucion As System.Int32, IDDocumentoJudicial As System.Int32, SubTipo As Integer)

            Select Case TipoResolucion
                Case enumTipoDocumentoJudicial.Libertad
                    FRM_Resolucion_Libertad(IDDocumentoJudicial)
                    ListarCabecera()

                Case enumTipoDocumentoJudicial.Traslado
                    FRM_Resol_Traslado(IDDocumentoJudicial)

                Case enumTipoDocumentoJudicial.Detencion, enumTipoDocumentoJudicial.DetencionReferenciado
                    'FRM_Resol_Detencion(IDDocumentoJudicial)
                    'Case enumTipoDocumentoJudicial.DetencionReferenciado
                    FRM_Resol_DetencionReferenciado(IDDocumentoJudicial)

                Case enumTipoDocumentoJudicial.Resolucion
                    FRM_Resol_Expediente(IDDocumentoJudicial)

                Case enumTipoDocumentoJudicial.Ingreso
                    FRM_Resolucion_Ingreso(IDDocumentoJudicial, SubTipo)
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

                Case enumTipoDocumentoJudicial.Prolongacion_Detencion,
                     enumTipoDocumentoJudicial.Adecuacion_Prision_Preventiva,
                     enumTipoDocumentoJudicial.Prolongacion_Prision_Preventiva
                    FRM_Resolucion_ProlongDetencion(IDDocumentoJudicial, TipoResolucion)

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
                Case enumTipoDocumentoJudicial.Refundicion_de_Sentencia, enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                    FRM_Resol_IntegracionSentencia(IDDocumentoJudicial, TipoResolucion)
                Case enumTipoDocumentoJudicial.Sentencia_Aclaratoria, enumTipoDocumentoJudicial.Sent_Adecuacion_Pena,
                      enumTipoDocumentoJudicial.Sent_Sustitucion_Pena,
                     enumTipoDocumentoJudicial.ResolucionConsentida, enumTipoDocumentoJudicial.Resolucion,
                     enumTipoDocumentoJudicial.Resolucion_Superior,
                      enumTipoDocumentoJudicial.Ejecutoria_Superior, enumTipoDocumentoJudicial.Ejecutoria_Suprema,
                      enumTipoDocumentoJudicial.Integracion_Sentencia

                    FRM_Resol_SentenciaMultiple(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()
                Case enumTipoDocumentoJudicial.Sent_Conmutacion_Pena
                    FRM_Resol_Conmutacion(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()

                Case enumTipoDocumentoJudicial.Anulacion_Antecedentes

                    FRM_Resol_AnulacionAntecedentes(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()

                Case enumTipoDocumentoJudicial.Sent_Pena_Limitativa,
                      enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD,
                      enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD_Consentida
                    FRM_Resol_SentenciaPLD(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()

                Case enumTipoDocumentoJudicial.Revocatoria
                    FRM_Resol_Revocatoria(IDDocumentoJudicial, TipoResolucion)
                    ListarCabecera()

                Case enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
                    FRM_OrdenTraslado(IDDocumentoJudicial)
                    ListarCabecera()

            End Select

        End Sub
        Private Sub FRM_AgregarResolucion(IngresoID As Integer, ResolucionRegistrada As Boolean, Opcion As Integer)

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

            Dim frm As New Registro.Resoluciones.frmResolucionTipoPopup
            With frm
                ._InternoID = Me._IDInterno
                ._RegionID = Me.RegionID
                ._PenalID = -1 'Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.txtInterno.Text
                ._ResolucionIngRegistrado = ResolucionRegistrada
                ._OpcionListar = Opcion
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._Documento_sin_mov = True
                'permisos
                ._FormEscritura = Me._FormEscritura
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


            Dim frm As New Registro.RegionLima.Resoluciones.frmResolIngreso
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
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With


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
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                    Listar_Expedientes()
                End If
            End With
        End Sub
        Private Sub FRM_Resolucion_Nota(DocJudicialId As Integer, Optional SubTipo As Integer = -1)
            Select Case SubTipo
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.ProyeccionVencimientoCondena
                    Dim frm As New Registro.Resoluciones.frmProyeccionVencimientoCondena
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
                        ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                        ._Subtipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.ProyeccionVencimientoCondena
                        ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

                    End With
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Adelanto_de_Fallo,
                     Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Nota_de_Sentencia

                    Dim frm As New Registro.Resoluciones.frmNotaPeriodo
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
                        ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

                    End With
                Case Else
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
                        ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                        'permisos
                        ._FormEscritura = Me._FormEscritura
                        ._FormEliminar = Me._FormEliminar
                        ._FormReporte = Me._FormReporte

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

                    End With
            End Select
        End Sub
        Private Sub FRM_Resolucion_ProlongDetencion(DocJudicialId As Integer, TipoDocumentoId As Integer)

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
                ._DocumentoTipo = TipoDocumentoId
                .UscExpeDeResolucion._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

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
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

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
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
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
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub
        Private Sub FRM_Resol_Detencion(DocJudicialId As Integer)
            Dim frm As New Registro.Resoluciones.frmResolDetencion

            With frm
                ._Codigo = DocJudicialId
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = enumTipoDocumentoJudicial.Detencion
                .UscExpeDeResolucion1._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub
        Private Sub FRM_Resol_DetencionReferenciado(DocJudicialId As Integer)

            Dim frm As New Registro.Resoluciones.frmResolDetencionReferenciado

            With frm
                ._Codigo = DocJudicialId
                ._RegionID = Me.RegionID
                ._PenalID = -1
                ._InternoIngresoInpeId = UscResolucionesMain1._IngresoInpeID
                ._InternoId = Me._IDInterno
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._blnNuevoRegistro = False
                ._TipoResolucion = enumTipoDocumentoJudicial.DetencionReferenciado
                .UscExpeDeResolucion1._Documentos_sin_mov = True
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
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
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

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
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

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
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

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
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub
        Private Sub FRM_Queda(DocJudicialId As Integer)
            Dim frm As New Registro.RegionLima.Resoluciones.frmQueda

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
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub
        'Private Sub FRM_Resol_AclaratoriaNombres(nomAsoID As Integer)
        '    gfdgfdfd
        '    If Me._IDInterno < 1 Then
        '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
        '        Me.tbcDatosPersonales.SelectedIndex = 0 'datos generales
        '        Exit Sub
        '    End If

        '    If Me._IDIngresoINPE < 1 Then
        '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
        '        cbbNroIngresoInpe.Focus()
        '        Exit Sub
        '    End If

        '    Dim frm As New Registro.Identificacion.frmNombreAsociadoPopup2(Nothing)
        '    With frm
        '        .Codigo = nomAsoID
        '        '._InternoIngresoInpeId = Me._IDIngresoINPE
        '        MsgBox("falta pasar _IDIngresoINPE")
        '        ._PenalID = Me.PenalID
        '        .InternoID = Me._IDInterno
        '        ._Nuevobln = False
        '        ._TipoFormulario = Type.Formulario.Registro.UserControl.Resoluciones
        '        ._Documentos_sin_mov = True
        '        ._RegionID = Me.RegionID
        '        ._PenalID = -1
        '        .ApellidoPaternoCopi = Me.InternoApePaterno
        '        .ApellidoMaternoCopi = Me.InternoApeMaterno
        '        .NombresCopi = Me.InternoNombres
        '        ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
        '        'permisos
        '        ._FormEscritura = Me._FormEscritura
        '        ._FormEliminar = Me._FormEliminar
        '        ._FormReporte = Me._FormReporte
        '        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        '            ListarData()
        '            ListarCabecera()
        '            ListarResoluciones()
        '            UscGrillaNombresAsociadosV21.Listar()
        '        End If
        '    End With
        'End Sub
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
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

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
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub
        Private Sub FRM_Resol_Conmutacion(DocJudicialId As Integer, TipoResolucion As Integer)

            Dim frm As New Registro.Sentencias.frmResolSentenciaConmutacion
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me._IDInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                ._blnNuevoRegistro = False
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If
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
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub

        Private Sub FRM_Resol_SentenciaPLD(DocJudicialId As Integer, TipoResolucion As Integer)

            Dim frm As New Registro.RegionLima.Resoluciones.frmResolSentenciaMultiple
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me._IDInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
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
                ._InternoID = Me._IDInterno
                ._InternoIngresoID = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With
        End Sub
        Private Sub FRM_Mant_Resol_Sent_EjecutoriaPLD(DocJudicialId As Integer, TipoResolucion As Integer)
            Dim frm As New Registro.RegionLima.Resoluciones.frmResolSentenciaMultiple
            With frm
                ._Codigo = DocJudicialId
                ._InternoID = Me._IDInterno
                ._InternoIngresoID = Me.UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

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
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then ListarResoluciones()

            End With
        End Sub
        Private Sub FRM_Resol_ProyeccionAdelantoFallo(DocJudicialId As Integer, TipoResolucion As Integer)

            Dim frm As New Registro.Resoluciones.frmProyeccionVencimientoCondena
            With frm
                ._Codigo = DocJudicialId
                ._InternoId = Me._IDInterno
                ._InternoIngresoId = UscResolucionesMain1._NroIngresoID
                ._InternoIngresoInpeId = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._CodigoInterno = Me.CodigoRPInterno
                ._NombresInterno = Me.InternoApeyNom
                ._TipoResolucion = TipoResolucion
                ._blnNuevoRegistro = False
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                End If

            End With
        End Sub
        Private Sub FRM_OrdenTraslado(DocJudicialId As Integer)

            Dim frm As New Registro.Resoluciones.frmOrdenTrasladoHospital
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
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarResoluciones()
                    Listar_Expedientes()
                End If
            End With
        End Sub
#End Region

#Region "Movimientos"
        Private Sub FRM_MovimientoTipo(NroPendientes As Integer, strMensaje As String)

            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno")
                Me.tbcDatosPersonales.SelectedIndex = 0 'datos generales
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

            Dim frm As New Registro.Movimientos.frmMovimientoTipoPopup
            With frm

                ._InternoID = Me._IDInterno
                ._IngresoID = Me._IDIngresoINPE
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._NuevoRegistro = True
                ._NroPendientes = NroPendientes
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                ._Documentos_sin_mov = True
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
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
        Private Sub FRM_MovimientoConduccionesClasificacion(MovimientoID As Integer, MovimientoTipoID As Integer,
                                                      IngresoID As Integer, DocumentoJudID As Integer)

            Dim frm As New Registro.Carceleta.Movimientos.frmMovimientoConduccionClasificacion
            With frm
                ._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
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
        Private Sub FMR_MovimientoInternamiento(MovimientoID As Integer, MovimientoGrupoID As Integer, MovimientoTipoID As Integer, MovimientoMotivoID As Integer,
                                                       IngresoID As Integer, DocumentoJudID As Integer)

            Dim frm As New Registro.Movimientos.Carceleta.frmInternamiento
            With frm
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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
                ._TipoDocJudicialID = EnumRegDocTipo.Internamiento
                ._CargarExpedientes = True
                'permisos
                ._FormEscritura = False 'Me._FormEscritura
                ._FormEliminar = False 'Me._FormEliminar
                ._FormReporte = False 'Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With

        End Sub
        Private Sub FRM_MovimientoTraslado(MovimientoID As Integer, MovimientoTipoID As Integer, IngresoID As Integer, DocumentoJudID As Integer)

            Dim frm As New Registro.Movimientos.Carceleta.frmMovimientoTrasladoCarceleta
            With frm
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._Codigo = MovimientoID
                ._DocumJudicialID = DocumentoJudID
                ._InternoID = Me._IDInterno
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoDocJudicialID = EnumMovTipo.Traslado
                'permisos
                ._FormEscritura = False 'Me._FormEscritura
                ._FormEliminar = False 'Me._FormEliminar
                ._FormReporte = False 'Me._FormReporte
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
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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
                ._FormEscritura = False 'Me._FormEscritura
                ._FormEliminar = False 'Me._FormEliminar
                ._FormReporte = False ' Me._FormReporte
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
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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
                ._FormEscritura = False ' Me._FormEscritura
                ._FormEliminar = False ' Me._FormEliminar
                ._FormReporte = False 'Me._FormReporte
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
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
                ._Codigo = MovimientoID
                ._InternoID = Me._IDInterno
                ._IngresoID = IngresoID
                ._MovimientoTipoID = MovimientoTipoID
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._blnNuevo = False
                ._TipoMovimiento = MovimientoTipoID
                'permisos
                ._FormEscritura = False 'Me._FormEscritura
                ._FormEliminar = False ' Me._FormEliminar
                ._FormReporte = False ' Me._FormReporte
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
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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
                ._FormEscritura = False ' Me._FormEscritura
                ._FormEliminar = False ' Me._FormEliminar
                ._FormReporte = False 'Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscMovimiento1._Listar()
                    ListarCabecera()
                End If
            End With
        End Sub

#End Region

#End Region
#Region "Permisos_Usuario"
        Private Sub Usuario_Permisos()

            Dim blnBuscarLicenciaPenalEscritura As Boolean = False

            Select Case Me.IDLicencia
                Case 1 'sede central
                    'pasa
                Case Else 'penal o provincias
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Modulo de Region Lima solo está disponible en la Sede Central")
                    Me.Close()
            End Select

            If Me._FormEscritura = True Then

                Select Case Legolas.Configuration.Usuario.NivelUsuario
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana,
                        Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                        Select Case Legolas.Configuration.Usuario.OficinaID

                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                Type.Enumeracion.Usuario.EnumDependencia.RegistroIgresoDetenciones,
                                Type.Enumeracion.Usuario.EnumDependencia.RegistroSentenciasLibertades,
                                Type.Enumeracion.Usuario.EnumDependencia.RegistroAntecedentes

                            Case Else
                                Me._FormEscritura = False
                        End Select

                    Case Else
                        Me._FormEscritura = False
                End Select

            End If

            If Me._FormEliminar = True Then

                Select Case Legolas.Configuration.Usuario.NivelUsuario
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana,
                        Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                        Select Case Legolas.Configuration.Usuario.OficinaID

                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                               Type.Enumeracion.Usuario.EnumDependencia.RegistroIgresoDetenciones,
                               Type.Enumeracion.Usuario.EnumDependencia.RegistroSentenciasLibertades,
                               Type.Enumeracion.Usuario.EnumDependencia.RegistroAntecedentes

                            Case Else
                                Me._FormEliminar = False
                        End Select

                    Case Else
                        Me._FormEliminar = False
                End Select

            End If

            '/*controles*/            
            Me.pnlEliminar.Visible = Me._FormEliminar
            Me.pnlReporte.Visible = Me._FormReporte

            '/*mandato detencion*/
            Me.UscMandatoDetencion._VisibleAnulacion = True

            '/*resolucion*/
            Me.UscResolucionesMain1._VisibleGrabar = Me._FormEscritura
            Me.UscResolucionesMain1._VisibleEliminar = Me._FormEliminar

            Me.UscGrillaNombresAsociadosV21._VisibleGrabar = Me._FormEscritura
            Me.UscGrillaNombresAsociadosV21._VisibleEliminar = Me._FormEliminar

        End Sub
        Private Sub Usuario_Permisos_Perfil()

            Dim blnModificarInterno As Boolean = False

            Select Case Me.PerfilUsuario
                Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                    Type.Enumeracion.Usuario.EnumDependencia.RegistroAntecedentes,
                     Type.Enumeracion.Usuario.EnumDependencia.RegistroIgresoDetenciones,
                     Type.Enumeracion.Usuario.EnumDependencia.RegistroSentenciasLibertades

                    Select Case Me.PenalID
                        Case Is < 1
                            blnModificarInterno = True
                            blnAddIngresos = True

                        Case 35 'carceleta                            
                            blnAddIngresos = True
                        Case Else
                            blnModificarInterno = False
                            blnAddIngresos = True
                    End Select

            End Select

            Me.pnlGrabarDatos.Visible = blnModificarInterno
            Me.pnlCancelar.Visible = blnModificarInterno
        End Sub

#End Region

#Region "Reniec"
        Private Sub Nuevo_Validacion_Reniec()

            UscValidacionReniecV21.ListarInternoValidado(Me._IDInterno)
            Dim entIngreso As New Entity.Registro.IngresoInpe

            'jmr. se envio el penal -1, xq la orl, debe ver todos los ingreso de plm
            entIngreso = (New Bussines.Registro.IngresoInpe).ListarUltimoIngresoInpe(Me._IDInterno, -1)
            'realizar la validacion de reniec

            Dim frmValidacion As New Registro.Reniec.frmTipoValidacionV2
            With frmValidacion

                ._InternoID = Me._IDInterno
                ._NroIngresoID = -1 'en la region no es necesario IngresoId
                ._IngresoInpeID = entIngreso.Codigo
                ._TipoDocumento = Me.TipoDocumento
                ._NumeroDocumento = Me.NumeroDocumento
                ._Estado = Me.InternoEstado
                ._ImagenSis = UscValidacionReniecV21._NumeroImagen
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID

                ._ListaInternoSisCabecera = UscValidacionReniecV21._ListaCabeceraInterno
                ._ListaInternoSisData = UscValidacionReniecV21._ListaDataInterno
                ._NombresAsociados = UscValidacionReniecV21._NombresAsociados
                ._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana
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
                Me.tbcDatosPersonales.SelectedIndex = 0
                Return value
            End If

            If Me._IDIngresoINPE < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, debe registrar el ingreso del interno [N° Ingreso]")
                Me.tbcDatosPersonales.SelectedIndex = 0
                Return value
            End If

            If Me.Nacionalidad <> 141 Then '"nacionalidad peruana"
                Me.tbcDatosPersonales.SelectedIndex = 0
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
                Me.tbcDatosPersonales.SelectedIndex = 2
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Interno no puede ser validado porque no cuenta con fotografia, capture la fotografia luego realize la validación")
                Return value
            End If

            value = True

            Return value

        End Function

#End Region
#Region "Otros"
        Private Sub AEliminarTabs()

            With tbcDatosPersonales.TabPages
                .Remove(tbpDatosComplement)
                .Remove(tbpNombresAsoc)
                .Remove(tbpFoto)
                .Remove(tbpReniec)
                .Remove(tbpAliasBandas)
                .Remove(tbpBandas)
                .Remove(tbpFamiliares)
                .Remove(tbpOdontograma)
                .Remove(tbpHuella)
            End With

        End Sub
        Private Sub VisibleAuditoria()

            Dim blnVerAuditoria As Boolean = False

            Select Case Me.tbcPrincipal.SelectedTab.Name

                Case Me.tbpInterno.Name

                    Select Case Me.tbcDatosPersonales.SelectedTab.Name
                        Case Me.tbpDatos.Name   'datos del interno, foto                            
                            blnVerAuditoria = True
                        Case Me.tbpDatosComplement.Name 'datos complemtarios

                        Case Me.tbpFoto.Name  'foto                            

                        Case Me.tbpReniec.Name  'reniec

                        Case Me.tbpBandas.Name 'bandas

                        Case Else

                    End Select

                Case Me.tbpDocJudyMov.Name

            End Select

            Me.pnlAuditoria.Visible = blnVerAuditoria
            'Usuario_Permisos_Perfil()

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
            ComboFuerzaArmada()
            ComboRangoFuerzaArmada()
            ComboDomicilioDepartamento()
            ComboComunidadAndinaEspecifico()

            'ComboPabellon()
            ComboNumIngresoInpe()

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

        Private Sub EnabledControles(Valor As Boolean)

            Select Case Me.tbcDatosPersonales.SelectedTab.Name

                Case Me.tbpDatos.Name 'datos

                    Me.txtApePat.ReadOnly = Valor
                    Me.txtApeMat.ReadOnly = Valor
                    Me.txtNom.ReadOnly = Valor
                    Me.txtDecadactDer.ReadOnly = Valor
                    Me.txtDecadactIzq.ReadOnly = Valor
                    Me.txtLibro.ReadOnly = Valor
                    'Me.txtCodIntUnico.ReadOnly = Valor
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

                Case Me.tbpDatosComplement.Name 'datos complementarios

                    Me.txtCentroTrabajo.ReadOnly = Valor
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


                blnCheck = True
                blnModificarDatos = True
            Else
                btnGrabar.Text = "&Modificar"
                btnGrabar.Image = My.Resources._1277961326_folder_edit

                blnCheck = False
                blnModificarDatos = False
            End If

            btnGrabar.Focus()

        End Sub
#End Region

        Private Sub frmMantenimiento_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            Me.pnlGrabarDatos.Visible = False
            Usuario_Permisos()
            VisibleAuditoria()

        End Sub

        Private Sub frmMantenimiento2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown

            Me.formCargaCompletado = False

            ValoresxDefault()

            ListarData()

            If InternoFechaNac > 0 Then
                ActivaDesactivaCheckMenorEdad()
            End If
            Usuario_Permisos_Perfil()
            Me.formCargaCompletado = True

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
            Select Case Me.tbcDatosPersonales.SelectedTab.Name

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

        Private Sub tbcPrincipal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcPrincipal.SelectedIndexChanged

            Select Case Me.tbcPrincipal.SelectedTab.Name
                Case Me.tbpInterno.Name
                    'solo se carga en el inicio

                Case Me.tbpDocDigi.Name
                    'cargar manualmente
                    LoadArchivoDigital()

                Case Me.tbpDocJudyMov.Name

                    tbcDocuyMovi_SelectedIndexChanged(sender, e)

            End Select

            VisibleAuditoria()

        End Sub
        Private Sub tbcDatosPersonales_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcDatosPersonales.SelectedIndexChanged

            Select Case Me.tbcDatosPersonales.SelectedTab.Name
                Case Me.tbpDatos.Name
                    ListarData()
                Case Me.tbpDatosComplement.Name
                    ListarDatosComplementarios()
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

            End Select

            VisibleAuditoria()

        End Sub

        Private Sub cbbAndina__ValueChanged() Handles cbbAndina._SelectedIndexChanged
            If blnComboComAnd = True Then
                ComboComunidadAndinaEspecifico()
            End If
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

        Private Sub cbbNroIngresos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbNroIngresoInpe.SelectedIndexChanged

            If Me._IDInterno < 1 Then
                Exit Sub
            End If

            If Me.formCargaCompletado = True Then
                Me.lblIngresoInpe.Text = "N° Ingreso INPE: " & "(ID: " & Me._IDIngresoINPE.ToString & ")"
                tbcPrincipal_SelectedIndexChanged(sender, e)
                tbcDatosPersonales_SelectedIndexChanged(sender, e)
                uscFotoPerfiles.DataGrieView_Click()
            End If

        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs)
            Nuevo_Validacion_Reniec()
        End Sub

        Private Sub btnFicha_Click(sender As System.Object, e As System.EventArgs) Handles btnFicha.Click
            FRM_VerReportes()
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__AddNombreAsociado() Handles UscGrillaNombresAsociadosV21._AddNombreAsociado
            FRM_Mant_NombresAsociados(True, -1, Nothing)
            'FRM_Resol_AclaratoriaNombres(-1)
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

        Private Sub uscFotoPerfiles__Clik_MantenimientoFotos(InternoFotId As System.Int32, RestringirEdicion As Boolean) Handles uscFotoPerfiles._Clik_MantFotos

            FRM_Mant_Fotos(InternoFotId, RestringirEdicion)

        End Sub

        Private Sub uscFotoPerfiles__Clik_MantRasgos(RasgoId As System.Int32, forzarRegistroSoloLectura As Boolean) Handles uscFotoPerfiles._Clik_MantRasgos
            FRM_Mant_Rasgo(RasgoId)
        End Sub

        Private Sub uscFotoPerfiles__Clik_MantSeniaPart(SenPartId As System.Int32, forzarRegistroSoloLectura As Boolean) Handles uscFotoPerfiles._Clik_MantSeniaPart
            FRM_Mant_SeniaParticular(SenPartId)
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

        Private Sub chk_Homonimia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Homonimia.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__MostrarResolucionesAclarados() Handles UscGrillaNombresAsociadosV21._MostrarResolucionesAclarados
            UscResolucionesMain1._ChekedValor = True
            tbcPrincipal.SelectedIndex = 1
        End Sub

        Private Sub UscAlias21__ClickAdd() Handles UscAlias21._ClickAdd
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

        Private Sub UscAlias21__ClickMod(AliasID As Integer, x As Integer, forzarRegistroSoloLectura As Boolean) Handles UscAlias21._ClickMod
            FRM_MantenimientoAlias(False, AliasID)
        End Sub

        Private Sub UscFamilias1__CellDoubleClick(IDFamilia As Integer, objEntFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean) Handles UscFamilias1._CellDoubleClick
            UscFamilias1__ClickModificar(IDFamilia, objEntFamCol, False)
        End Sub

        Private Sub UscFamilias1__ClickAdd(objEntFamCol As Entity.Registro.FamiliarCol) Handles UscFamilias1._ClickAdd
            FRM_Mant_Familia(True, -1, objEntFamCol)
        End Sub

        Private Sub UscFamilias1__ClickModificar(IDFamilia As Integer, objEntFamCol As Entity.Registro.FamiliarCol, forzarRegistroSoloLectura As Boolean) Handles UscFamilias1._ClickModificar
            FRM_Mant_Familia(False, IDFamilia, objEntFamCol)
        End Sub

        Private Sub TabControl2_Selecting(sender As Object, e As System.Windows.Forms.TabControlCancelEventArgs) Handles tbcDatosPersonales.Selecting

            If blnModificarDatos = True Then
                If MessageBox.Show("¿Desea guardar los datos del interno?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    blnModificarDatos = False
                Else
                    e.Cancel = True
                End If
            End If

        End Sub

        Private Sub TabControl1_Selecting(sender As Object, e As System.Windows.Forms.TabControlCancelEventArgs) Handles tbcPrincipal.Selecting

            If blnModificarDatos = True Then
                If MessageBox.Show("¿Desea guardar los datos del interno?", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    blnModificarDatos = False
                    EnabledControles(True)
                Else
                    e.Cancel = True
                End If
            End If

        End Sub

        Private Sub UscResolucionesMain1__Click_BtnNuevoResolucion(IngresoID As System.Int32, ResIngRegistrado As System.Boolean, Opcion As System.Int32) Handles UscResolucionesMain1._Click_BtnNuevoResolucion
            FRM_AgregarResolucion(IngresoID, ResIngRegistrado, Opcion)
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnModificarResolucion(TipoDocumento As System.Int32, DocJudicialId As System.Int32, SubTipo As System.Int32, _penId As System.Int32, Version As System.String) Handles UscResolucionesMain1._Click_BtnModificarResolucion
            FRM_Modificar_Resolucion(TipoDocumento, DocJudicialId, SubTipo)
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

        Private Sub tbcDocuyMovi_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tbcDocuyMovi.SelectedIndexChanged

            Select Case Me.tbcDocuyMovi.SelectedTab.Name

                Case Me.tbpListaExpedientes.Name
                    Listar_Expedientes()

                Case Me.tbpDocumentos.Name
                    ListarResoluciones()

                Case Me.tbpMovimientos.Name
                    ListarMovimientosIngreso()
            End Select

            VisibleAuditoria()
        End Sub

        Private Sub UscResolucionesMain1__Click_BtnEliminarActualizarEstadoInterno() Handles UscResolucionesMain1._Click_BtnEliminarActualizarEstadoInterno
            ListarCabecera()
            ListarData()
            UscGrillaNombresAsociadosV21._LoadUsc()
        End Sub

        Private Sub UscGrillaNombresAsociadosV21__AnularNombreAsociado() Handles UscGrillaNombresAsociadosV21._AnularNombreAsociado
            UscGrillaNombresAsociadosV21._LoadUsc()
        End Sub
        Private Sub UserAlias_LM1__DoubleClick(AliasID As Integer, IngresoID As Integer, forzarRegistroSoloLectura As Boolean) Handles UscAlias21._DoubleClick
            FRM_MantenimientoAlias(False, AliasID)
        End Sub

        Private Sub cbbCodFuerArmada_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbCodFuerArmada.SelectedIndexChanged
            If blnComboFzaArm = True Then
                ComboRangoFuerzaArmada()
            End If
        End Sub


        Private Sub btnAddIngreso_Click(sender As System.Object, e As System.EventArgs) Handles btnAddIngreso.Click

            Me.NuevoClickfrmIngreso = False
            FRM_MantIngreso(False)

        End Sub

        Private Sub UscBandas21__ClikBandas(Nuevo As System.Boolean, BandaID As System.Int32, n_IngresoInpeId As System.Int32, objEntColBandas_ As Entity.Registro.InternoBandaCol) Handles UscBandas21._ClikBandas

        End Sub

        Private Sub dtpFechaNac__LostFocus() Handles dtpFechaNac._LostFocus
            Try
                lblEdad.Text = Legolas.Components.FechaHora.FechaCalcularAnio(Me.dtpFechaNac.ValueLong, Legolas.Configuration.Aplication.FechayHora.FechaLong, True)
            Catch ex As Exception
                lblEdad.Text = ""
            End Try
        End Sub

        Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

            Me.btnGrabar.Image = My.Resources._1277961326_folder_edit
            Me.btnGrabar.Text = "&Modificar"
            EnabledControles(True)

        End Sub

        Private Sub UscVisorArchDigital1_Load(sender As Object, e As EventArgs) Handles UscVisorArchDigital1.Load

        End Sub

        Private Sub UscBandas21__DoubleClikBandas(Nuevo As Integer, AliasID As Integer, n_IngresoInpeId As Integer, objEntColBandas_ As Entity.Registro.InternoBandaCol, forzarRegistroSoloLectura As Boolean) Handles UscBandas21._DoubleClikBandas

        End Sub

        Private Sub UscGrillaBandasV21__UpdInternoBanda(forzarRegistroSoloLectura As Boolean) Handles UscOrganizacionCriminal._UpdInternoBanda

        End Sub

        Private Sub btnVerLibros_Click(sender As Object, e As EventArgs) Handles btnVerLibros.Click
            If Me._IDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no ha sido grabado")
                Exit Sub
            End If

            Dim frm As New Registro.RegionLima.Resoluciones.frmListarLibros
            frm._InternoID = Me._IDInterno
            frm._LicenciaID = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
            frm.ShowDialog()
        End Sub

        Private Sub UscResolucionesMain1_Load(sender As Object, e As EventArgs) Handles UscResolucionesMain1.Load

        End Sub

        Private Sub UscOrganizacionCriminal__AnularInternoBanda() Handles UscOrganizacionCriminal._AnularInternoBanda
            If UscOrganizacionCriminal.GrillaEstadoId = 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "No es posible completar la operación, registro ya se encuentra anulado")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Confirma cambiar el estado del registro seleccionado a ANULADO?") = MsgBoxResult.Yes Then
                AnularInternoBanda()
            End If
        End Sub
        Private Sub AnularInternoBanda()

            Dim objBss As New Bussines.Registro.InternoOrgCriminal
            Dim value As Integer = -1

            Dim intIdDocJudAnula As Integer
            intIdDocJudAnula = FRM_Mant_Siscrico_Anular()
            If intIdDocJudAnula = -1 Then
                Exit Sub
            End If
            value = objBss.GrabarEstado(UscOrganizacionCriminal.GrillaID, 0, intIdDocJudAnula)

            Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            Dim intIdEstadoBand As Integer = -1
            UscOrganizacionCriminal._LoadUsc()

        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            AEliminarInterno()
        End Sub

    End Class
End Namespace
